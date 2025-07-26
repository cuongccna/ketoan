Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Module modCongcudungcu
    Public pMaCongcudungcu As Integer
    ''' <summary>
    ''' Tính và cập nhật giá trị cho tất cả các tài sản trong một tháng (Quy tắc xem thur tujc TinhGiaTriCongcudungcu)
    ''' 
    ''' </summary>
    ''' <param name="thg">Tháng cần tính giá trị</param>
    ''' <param name="gauge_control">Gauge Control để hiển thị số % đã hoàn thành</param>
    ''' <remarks>Sử dụng : frmBaoCao và frmKhauHao</remarks>
    Public Sub CapNhatGiaTriCongcudungcu(ByRef thg As Integer, ByRef gauge_control As ProgressBar)
        Try
            gauge_control.Maximum = 3
            ' Tổng khấu hao
            Dim TongKhauHao As String = String.Format("SELECT DISTINCT Sum(thongso1.KH_NS) AS TKH_NS, Sum(thongso1.KH_TBS) AS TKH_TBS, Sum(thongso1.KH_CNK) AS TKH_CNK, Sum(thongso1.KH_TD) AS TKH_TD, thongso1.MaTS FROM Congcudungcu RIGHT JOIN thongso1 ON Congcudungcu.MaSo = thongso1.MaTS WHERE {0} AND {1} AND thongso1.Thang <= {2} GROUP BY thongso1.MaTS", _
                                             WThang("ThangTang", 0, CThangFR(thg)), _
                                             WThang("ThangGiam", CThangFR(thg), 0), _
                                             ConvertToStrSafe(thg))
            gauge_control.Value = 1
            ' Lượng tăng giảm
            Dim TongGiaTri As String = String.Format("SELECT Sum(NG_NS) AS TNG_NS, Sum(NG_TBS) AS TNG_TBS, Sum(NG_CNK) AS TNG_CNK, Sum(NG_TD) AS TNG_TD, Sum(CL_NS) AS TCL_NS, Sum(CL_TBS) AS TCL_TBS, Sum(CL_CNK) AS TCL_CNK, Sum(CL_TD) AS TCL_TD, MaTS FROM CTCongcudungcu WHERE {0} GROUP BY MaTS", WThang("Thang", 0, CThangFR(thg)))
            gauge_control.Value = 2
            ' Giá trị tài sản
            Dim GiaTriCongcudungcu As String = String.Format("SELECT DISTINCT TNG_NS AS NG_NS, TNG_TBS AS NG_TBS, TNG_CNK AS NG_CNK, TNG_TD AS NG_TD, TCL_NS-TKH_NS AS CL_NS, TCL_TBS-TKH_TBS AS CL_TBS, TCL_CNK-TKH_CNK AS CL_CNK, TCL_TD-TKH_TD AS CL_TD, TongGiaTri.MaTS FROM ({0}) AS TongKhauHao INNER JOIN ({1}) AS TongGiaTri ON TongKhauHao.MaTS = TongGiaTri.MaTS", _
                                                   TongKhauHao, _
                                                   TongGiaTri)
            'van.nguyen 16-Nov-2011
            'Dim rs_giatri AS DataTable = ExecSQLReturnDT("GiaTriCongcudungcu")
            Dim rs_giatri As DataTable = ExecSQLReturnDT(GiaTriCongcudungcu)
            gauge_control.Value = 3
            '      gauge_control.Refresh
            Try
                gauge_control.Value = 0
                gauge_control.Maximum = rs_giatri.Rows.Count
                For Each rsgiatriItem As DataRow In rs_giatri.Rows
                    Dim str As String = String.Format("UPDATE thongso1 SET NG_NS = {0}, NG_TBS = {1}, NG_CNK = {2}, NG_TD = {3}, CL_NS = {4}, CL_TBS = {5}, CL_CNK = {6}, CL_TD = {7} WHERE MaTS = {8} AND Thang = {9}", _
                                        CStr(ConvertToDblSafe(rsgiatriItem("NG_NS"))), _
                                        CStr(ConvertToDblSafe(rsgiatriItem("NG_TBS"))), _
                                        CStr(ConvertToDblSafe(rsgiatriItem("NG_CNK"))), _
                                        CStr(ConvertToDblSafe(rsgiatriItem("NG_TD"))), _
                                        CStr(RoundMoney(ConvertToDblSafe(rsgiatriItem("CL_NS")))), _
                                        CStr(RoundMoney(ConvertToDblSafe(rsgiatriItem("CL_TBS")))), _
                                        CStr(RoundMoney(ConvertToDblSafe(rsgiatriItem("CL_CNK")))), _
                                        CStr(RoundMoney(ConvertToDblSafe(rsgiatriItem("CL_TD")))), _
                                        rsgiatriItem("MaTS"), _
                                        thg)
                    ExecSQLNonQuery(str)
                    gauge_control.Value += 1
                Next
            Catch ex As Exception
            Finally
                ' Kiểm tra và điều chỉnh lại lượng khấu hao cho tất cả các tài sản trong tháng
                DieuChinhPhanBo(thg)
            End Try
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' Thành lập các dòng phát sinh phản ánh nghiệp vụ kế toán tác động lên một tài sản.
    ''' Định khoản dựa trên tài khoản tài sản và tài khoản chi phí khấu hao tương ứng.
    ''' Số phát sinh lấy từ biến chung GiaTri và loại phát sinh (nợ hoặc có) được xác định qua nghiệp vụ.
    ''' Số dòng phát sinh đã thành lập được cho trong biến chung pSoPhatSinh
    ''' </summary>
    ''' <param name="nghiep_vu">Mã nghiệp vụ</param>
    ''' <param name="ma_tkts">Mã loại của tài sản bị tác động</param>
    ''' <remarks>Chú ý : Không tạo ra dòng phát sinh thể hiện lượng tăng giảm khấu hao nếu nghiệp vụ là thay đổi giá trị tài sản</remarks>
    Public Sub ThanhLapPhatSinhCCDC(ByRef nghiep_vu As Integer, ByRef ma_tkts As Integer)
        Try
            parSoPS = 1
            ReDim arPhatSinh(parSoPS)
            ' Tính số phát sinh
            Dim tong_ng As Double = (GiaTri.NG_NS + GiaTri.NG_TBS + GiaTri.NG_CNK + GiaTri.NG_TD)
            Dim tong_hm As Double = tong_ng - (GiaTri.CL_NS + GiaTri.CL_TBS + GiaTri.CL_CNK + GiaTri.CL_TD)
            ' Xác định tài khoản tài sản
            Dim sql As String = String.Format("SELECT SoHieu AS F1 FROM LoaiCongcudungcu WHERE MaSo = {0}", ma_tkts)
            arPhatSinh(0).TK_SoHieu = ConvertToStrSafe(GetSelectValue(sql))
            ' Số hiệu của tài khoản chi phí khấu hao xác định qua loại tài sản
            arPhatSinh(1).TK_SoHieu = "214" & Strings.Mid(arPhatSinh(0).TK_SoHieu, 3, 1)
            arPhatSinh(0).PS_SoLg = tong_ng
            arPhatSinh(1).PS_SoLg = tong_hm
            ' Loại  phát sinh xác định qua nghiệp vụ
            Select Case nghiep_vu
                Case NV_TANG
                    arPhatSinh(0).PS_Loai = -1
                    arPhatSinh(1).PS_Loai = 1
                Case NV_GIAM
                    arPhatSinh(0).PS_Loai = 1
                    arPhatSinh(1).PS_Loai = -1
                Case NV_DGLAI
                    arPhatSinh(0).PS_Loai = -1
                    arPhatSinh(1).PS_Loai = 1
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' Tính giá trị của tài sản tại một thời điểm cho trước dựa trên thông tin đã lưu
    ''' trong các chứng từ có liên quan và lượng khấu hao hàng tháng.
    ''' Giá trị được tính bằng số đầu kỳ (lưu trong chứng từ đầu kỳ hoặc chứng từ
    ''' tăng tương ứng) cộng tổng lượng tăng giảm cho đến tháng hiện tại (lưu trong
    ''' các chứng từ tăng giảm) trừ đi tổng lượng khấu hao cho đến tháng hiện tại.
    ''' Kết quả trả về được chứa trong biến chung GiaTri
    ''' </summary>
    ''' <param name="ma_ts">Mã số tài sản</param>
    ''' <param name="thg">Tháng cần tính giá trị</param>
    ''' <param name="khau_hao">Kiểu tính(có trích khấu hao hay không)</param>
    ''' <remarks></remarks>
    Public Sub TinhGiaTriCongcudungcu(ByRef ma_ts As Integer, ByRef thg As Integer, ByRef khau_hao As Integer)
        Try
            Dim rs_giatridau, rs_tongkhauhao, rs_khauhao As DataTable
            Dim sql As String = String.Empty
            With GiaTri
                If ma_ts = 0 Then Exit Sub
                .NG_NS = 0
                .NG_TBS = 0
                .NG_CNK = 0
                .NG_TD = 0
                .CL_NS = 0
                .CL_TBS = 0
                .CL_CNK = 0
                .CL_TD = 0
                ' Lấy nguyên giá và giá trị còn lại cho đến thời điểm hiện tại
                sql = String.Format("SELECT Sum(NG_NS) AS TNG_NS, Sum(NG_TBS) AS TNG_TBS, Sum(NG_CNK) AS TNG_CNK, Sum(NG_TD) AS TNG_TD, Sum(CL_NS) AS TCL_NS, Sum(CL_TBS) AS TCL_TBS, Sum(CL_CNK) AS TCL_CNK, Sum(CL_TD) AS TCL_TD FROM CTCongcudungcu WHERE MaTS = {0} AND {1}", _
                          ma_ts, _
                          WThang("Thang", 0, thg))
                rs_giatridau = ExecSQLReturnDT(sql)
                If IsDBNull(rs_giatridau.Rows(0)("TNG_NS")) Then
                    sql = String.Format("SELECT (NG_NS) AS TNG_NS, (NG_TBS) AS TNG_TBS, (NG_CNK) AS TNG_CNK, (NG_TD) AS TNG_TD, (CL_NS) AS TCL_NS, (CL_TBS) AS TCL_TBS, (CL_CNK) AS TCL_CNK, (CL_TD) AS TCL_TD FROM thongso1 WHERE MaTS = {0} AND Thang={1}", _
                              ma_ts, _
                              CThangDB2(thg))
                    rs_giatridau = ExecSQLReturnDT(sql)
                End If
                ' Nguyên giá tài sản
                If rs_giatridau.Rows.Count > 0 Then
                    .NG_NS = ConvertToDblSafe(rs_giatridau.Rows(0)("TNG_NS"))
                    .NG_TBS = ConvertToDblSafe(rs_giatridau.Rows(0)("TNG_TBS"))
                    .NG_CNK = ConvertToDblSafe(rs_giatridau.Rows(0)("TNG_CNK"))
                    .NG_TD = ConvertToDblSafe(rs_giatridau.Rows(0)("TNG_TD"))


                    If thg > 0 Then
                        ' Lấy tổng lượng khấu hao cho đến thời điểm hiện tại
                        sql = String.Format("SELECT DISTINCT Sum(thongso1.KH_NS) AS TKH_NS, Sum(thongso1.KH_TBS) AS TKH_TBS, Sum(thongso1.KH_CNK) AS TKH_CNK, Sum(thongso1.KH_TD) AS TKH_TD FROM Congcudungcu RIGHT JOIN thongso1 ON Congcudungcu.MaSo = thongso1.MaTS WHERE thongso1.MaTS = {0} AND {1} AND thongso1.Thang <= {2}", _
                                  ma_ts, _
                                  VC("thongso1.Thang", String.Format("CASE WHEN Congcudungcu.ThangTang=0 THEN {0} ELSE Congcudungcu.ThangTang END", pThangDauKy)), _
                                  CThangDB2(thg))
                        rs_tongkhauhao = ExecSQLReturnDT(sql)

                        'If Not IsDBNull(rs_tongkhauhao("TKH_NS")) AND Not IsDBNull(rs_giatridau.Rows(0)("TCL_NS")) Then
                        If Not IsDBNull(rs_tongkhauhao.Rows(0).Item("TKH_NS")) And Not IsDBNull(rs_giatridau.Rows(0).Item("TCL_NS")) Then
                            Dim rs_giatridauItem As DataRow = rs_giatridau.Rows(0)
                            ' Giá trị tài sản
                            If rs_tongkhauhao.Rows.Count > 0 Then
                                .CL_NS = ConvertToDblSafe(rs_giatridauItem.Item("TCL_NS")) - ConvertToDblSafe(rs_tongkhauhao.Rows(0).Item("TKH_NS"))
                                .CL_TBS = ConvertToDblSafe(rs_giatridauItem.Item("TCL_TBS")) - ConvertToDblSafe(rs_tongkhauhao.Rows(0).Item("TKH_TBS"))
                                .CL_CNK = ConvertToDblSafe(rs_giatridauItem.Item("TCL_CNK")) - ConvertToDblSafe(rs_tongkhauhao.Rows(0).Item("TKH_CNK"))
                                .CL_TD = ConvertToDblSafe(rs_giatridauItem.Item("TCL_TD")) - ConvertToDblSafe(rs_tongkhauhao.Rows(0).Item("TKH_TD"))
                            End If
                        End If
                        rs_tongkhauhao = Nothing
                        ' Lượng khấuhao
                        sql = String.Format("SELECT KH_NS, KH_TBS, KH_CNK, KH_TD FROM thongso1 WHERE Thang = {0} AND MaTS = {1}", _
                                  CThangDB2(thg), _
                                  ma_ts)
                        rs_khauhao = ExecSQLReturnDT(sql)
                        If rs_khauhao.Rows.Count > 0 Then
                            .KH_NS = ConvertToDblSafe(rs_khauhao.Rows(0).Item("KH_NS"))
                            .KH_TBS = ConvertToDblSafe(rs_khauhao.Rows(0).Item("KH_TBS"))
                            .KH_CNK = ConvertToDblSafe(rs_khauhao.Rows(0).Item("KH_CNK"))
                            .KH_TD = ConvertToDblSafe(rs_khauhao.Rows(0).Item("KH_TD"))
                        End If
                        ' Kiểm tra lượng khấu hao và điều chỉnh lại kết quả (chú ý rằng giá trị tính
                        ' được ở đây luôn là giá trị khi đã trích khấu hao hay là giá trị cuối tháng)
                        If .CL_NS < 0 Then
                            If .KH_NS + .CL_NS > 0 Then .KH_NS += .CL_NS Else .KH_NS = 0
                            .CL_NS = 0
                        End If
                        If .CL_TBS < 0 Then
                            If .KH_TBS + .CL_TBS > 0 Then .KH_TBS += .CL_TBS Else .KH_TBS = 0
                            .CL_TBS = 0
                        End If
                        If .CL_CNK < 0 Then
                            If .KH_CNK + .CL_CNK > 0 Then .KH_CNK += .CL_CNK Else .KH_CNK = 0
                            .CL_CNK = 0
                        End If
                        If .CL_TD < 0 Then
                            If .KH_TD + .CL_TD > 0 Then .KH_TD += .CL_TD Else .KH_TD = 0
                            .CL_TD = 0
                        End If
                        ' Nếu tính giá trị mà không trừ đi lượng khấu hao trong tháng (coi như chưa trính khấu hao)
                        If khau_hao = KH_KHONG Then
                            .CL_NS += .KH_NS
                            .CL_TBS += .KH_TBS
                            .CL_CNK += .KH_CNK
                            .CL_TD += .KH_TD
                        End If
                    Else
                        If rs_giatridau.Rows.Count > 0 Then
                            .CL_NS = ConvertToDblSafe(rs_giatridau.Rows(0).Item("TCL_NS"))
                            .CL_TBS = ConvertToDblSafe(rs_giatridau.Rows(0).Item("TCL_TBS"))
                            .CL_CNK = ConvertToDblSafe(rs_giatridau.Rows(0).Item("TCL_CNK"))
                            .CL_TD = ConvertToDblSafe(rs_giatridau.Rows(0).Item("TCL_TD"))
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' Thực hiện nghiệp vụ giảm tài sản bao gồm:
    ''' - Ghi chứng từ giảm dựa trên giá trị của tài sản trong tháng giảm.
    ''' - Cập nhật tháng giảm cho tài sản.
    ''' - Đặt lượng khấu hao của tài sản cho các tháng sau kể từ tháng giảm bằng 0.
    ''' </summary>
    ''' <param name="ma_ts">Mã số của tài sản</param>
    ''' <param name="thg_giam">Tháng có tác động giảm</param>
    ''' <remarks> Chú ý : Tài sản không tính khấu hao trong tháng giảm. Thủ tục này được gọi duy nhất từ mnHoatDong: "Giảm tài sản"</remarks>
    Public Sub GiamCongcudungcu(ByRef ma_ts As Integer, ByRef thg_giam As Integer)
        Try
            ' Tính giá trị tài sản trong tháng giảm (chưa trích khấu hao)
            TinhGiaTriCongcudungcu(ma_ts, thg_giam + 1, KH_KHONG)
            ' Lấy mã tài khoản tài sản
            Dim sql As String = String.Format("SELECT MaTaiKhoan AS F1 FROM Congcudungcu WHERE MaSo = {0}", ma_ts)
            ' Thành lập phát sinh
            ThanhLapPhatSinhCCDC(NV_GIAM, ConvertToDblSafe(GetSelectValue(sql)))
            ' clsChungTu sẽ sử dụng các thông tin lưu trong biến chung GiaTri để ghi
            ' vào lượng tăng giảm trên chứng từ (khi giảm cần phải cập nhật số âm).
            With GiaTri
                .NG_NS *= -1
                .NG_TBS *= -1
                .NG_CNK *= -1
                .NG_TD *= -1
                .CL_NS *= -1
                .CL_TBS *= -1
                .CL_CNK *= -1
                .CL_TD *= -1
            End With
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' Thể hiện các thay đổi trên dữ liệu đối với nghiệp vụ giảm tài sản
    ''' - Lượng khấu hao của các tháng kể sau từ tháng giảm bị đặt bằng 0
    ''' - Tháng giảm của tài sản được ghi khác 13
    ''' Khôi phục lại trạng thái trước đó (khi xoá chứng từ giảm)
    ''' - Lượng khấu hao của các tháng kể sau từ tháng giảm được đặt lại bằng giá trị của tháng ngay trước đó
    ''' - Tháng giảm của tài sản được ghi lại bằng 13
    ''' </summary>
    ''' <param name="ma_ts">Mã tài sản bị tác động</param>
    ''' <param name="thg">Tháng tác động</param>
    ''' <param name="tac_dong">Kiểu tác động</param>
    ''' <remarks>Sử dụng : Thủ tục này được gọi từ thủ tục GiamCongcudungcu và frmChungTu</remarks>
    Public Sub TacDongGiamCongcudungcu(ByRef ma_ts As Integer, ByRef thg As Integer, ByRef tac_dong As Integer)
        Try
            Dim sql As String = String.Empty
            Dim rs_khauhao As DataTable
            If tac_dong = TD_GIAM Then ' Giảm tài sản
                ExecSQLNonQuery(String.Format("UPDATE thongso1 SET KH_NS = 0, KH_TBS = 0, KH_CNK = 0, KH_TD = 0 WHERE MaTS = {0} AND {1}", _
                                    ma_ts, _
                                    WThang2("Thang", thg, 0)))
            Else
                ' Khôi phục lại dữ liệu
                ' Cập nhật lại lượng khấu hao với dữ liệu của tháng ngay trước tháng giảm
                sql = String.Format("SELECT DISTINCT thongso1.Thang, Congcudungcu.ThangGiam, thongso1.KH_NS, thongso1.KH_TBS, thongso1.KH_CNK, thongso1.KH_TD FROM Congcudungcu INNER JOIN thongso1 ON (thongso1.Thang = Congcudungcu.ThangGiam-1) AND (Congcudungcu.MaSo = thongso1.MaTS) WHERE thongso1.MaTS = {0}", ma_ts)
                rs_khauhao = ExecSQLReturnDT(sql)
                For Each rskhauhaoItem As DataRow In rs_khauhao.Rows
                    If ConvertToDblSafe(rskhauhaoItem("thang")) = CThangDB2(ThangTruoc(rskhauhaoItem("ThangGiam"))) Then
                        ExecSQLNonQuery(String.Format("UPDATE DISTINCT Congcudungcu INNER JOIN thongso1 ON Congcudungcu.MaSo = thongso1.MaTS SET thongso1.KH_NS = {0}, KH_TBS = {1}, KH_CNK = {2}, KH_TD = {3} WHERE MaTS = {4} AND thongso1.Thang >= {5}", _
                                            CStr(ConvertToDblSafe(rskhauhaoItem("KH_NS"))), _
                                            CStr(ConvertToDblSafe(rskhauhaoItem("KH_TBS"))), _
                                            CStr(ConvertToDblSafe(rskhauhaoItem("KH_CNK"))), _
                                            CStr(ConvertToDblSafe(rskhauhaoItem("KH_TD"))), _
                                            ma_ts, _
                                            rskhauhaoItem("thang")))
                        Exit For
                    End If
                Next
            End If
            ' Ghi tháng giảm tài sản
            ExecSQLNonQuery(String.Format("UPDATE Congcudungcu SET ThangGiam = {0} WHERE MaSo = {1}", _
                                thg, _
                                ma_ts))
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' Xoá tài sản
    ''' </summary>
    ''' <param name="ma_ts"></param>
    ''' <returns></returns>
    ''' <remarks>Sử dụng : frmCongcudungcu (Khi nhập đầu kỳ hoặc khi không ghi chứng từ tăng hợp lệ)</remarks>
    Public Function XoaCongcudungcu(ByRef ma_ts As Integer) As Integer

        Dim rs_chungtu, rs_thue As DataTable
        Dim ctu As New ClsChungtu
        Dim sql, Thue As String
        Dim masochungtu, masoxt As Integer
        ' Xoá chứng từ
        Dim mvt As Integer = ConvertToDblSafe(Timten("maso", Timten("sohieu", ConvertToStrSafe(ma_ts), "maso", "congcudungcu"), "sohieu", "vattu"))
        Try
            If mvt = 0 Then
                GoTo Loi
            Else
                masochungtu = ConvertToDblSafe(GetSelectValue(String.Format("SELECT chungtu.ct_id AS f1 FROM chungtu,congcudungcu WHERE congcudungcu.maso={0} AND (congcudungcu.shct=LEFT(chungtu.sohieu,len(chungtu.sohieu)-2) OR congcudungcu.shct=LEFT(chungtu.sohieu,len(chungtu.sohieu)-3)) AND congcudungcu.thangtang=chungtu.thangct AND chungtu.maloai=2 AND chungtu.mavattu={1} ORDER BY chungtu.maso", ma_ts, mvt)))
                If masochungtu = 0 Then
                    masochungtu = ConvertToDblSafe(GetSelectValue(String.Format("SELECT t3.maso AS f1 FROM (congcudungcu t1 inner join ctcongcudungcu t2 on t1.maso=t2.mats)inner join chungtu t3 on t2.mactkt=t3.mact WHERE t3.sohieu LIKE 'XTCCDK%' AND t1.maso={0}", ma_ts)))
                    If masochungtu <> 0 Then
                        If masochungtu <> 0 And frmDSCCDC.Visible Then
                            If MessageBox.Show(String.Format("Công cụ có phát sinh !{0}Tiếp tục xoá ...", Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then GoTo Xong
                        End If
                        ctu.InitChungtu(masochungtu, _
                            0, _
                            String.Empty, _
                            0, _
                            DateTime.Today, _
                            DateTime.Today, _
                            0, _
                            0, _
                            String.Empty, _
                            0, _
                            0, _
                            0, _
                            0, _
                            0, _
                            0, _
                            String.Empty, _
                            0, DateTime.Today)
                        XoaPhanboPhieuxuat(ctu.MaSo, masochungtu)
                    Else
                        masoxt = ConvertToDblSafe(GetSelectValue(String.Format("SELECT t3.maso AS f1 FROM (congcudungcu t1 inner join ctcongcudungcu t2 on t1.maso=t2.mats)inner join chungtu t3 on t2.mactkt=t3.mact WHERE t3.sohieu like '%XT%' AND t1.maso={0}", ma_ts)))
                        If masoxt <> 0 And frmDSCCDC.Visible Then
                            If MessageBox.Show(String.Format("Công cụ có phát sinh !{0}Tiếp tục xoá ...", Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then GoTo Xong
                        End If
                        XoaPhanboPhieuxuat(0, 0, masoxt)
                    End If
                    GoTo Loi
                Else
                    If frmDSCCDC.Visible Then
                        If MessageBox.Show(String.Format("Công cụ có phát sinh !{0}Tiếp tục xoá ...", Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then GoTo Xong
                    End If
                End If
            End If
            sql = String.Format("SELECT ChungTu.MaSo FROM chungtu WHERE maso={0}", masochungtu - 900000000)
            rs_chungtu = ExecSQLReturnDT(sql)
            For Each rschungtuItem As DataRow In rs_chungtu.Rows
                ctu.InitChungtu(ConvertToIDSafe(rschungtuItem("MaSo")), _
                    0, _
                    String.Empty, _
                    0, _
                    DateTime.Today, _
                    DateTime.Today, _
                    0, _
                    0, _
                    String.Empty, _
                    0, _
                    0, _
                    0, _
                    0, _
                    0, _
                    0, _
                    String.Empty, _
                    0, DateTime.Today)
                XoaPhanboPhieuxuat(ctu.MaSo)
                Thue = ctu.SoHieu
                ctu.XoaChungtu()
                ' Xoá thuế nếu chứng từ không còn chi tiết
                sql = String.Format("SELECT * FROM chungtu WHERE maloai=13 AND sohieu=N'{0}' ORDER BY mavattu", Thue)
                rs_thue = ExecSQLReturnDT(sql)
                If rs_thue.Rows.Count > 0 Then
                    ctu.InitChungtu(ConvertToIDSafe(rs_thue.Rows(0)("MaSo")), _
                        0, _
                        String.Empty, _
                        0, _
                        DateTime.Today, _
                        DateTime.Today, _
                        0, _
                        0, _
                        String.Empty, _
                        0, _
                        0, _
                        0, _
                        0, _
                        0, _
                        0, _
                        String.Empty, _
                        0, DateTime.Today)
                    If rs_thue.Rows.Count = 1.0F And ctu.MaVattu = 0 Then
                        ctu.XoaChungtu()
                    End If
                End If
            Next
Loi:
            ExecSQLNonQuery(String.Format("DELETE FROM CTCongcudungcu WHERE MaTS = {0}", ma_ts))
            ' Xoá tài sản
            ExecSQLNonQuery(String.Format("DELETE FROM Congcudungcu WHERE MaSo = {0}", ma_ts))
            ExecSQLNonQuery(String.Format("DELETE FROM thongso1 WHERE MaTS = {0}", ma_ts))
            Return 0
            Exit Function
Xong:
            Return 1
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return 0
        End Try
        
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="MasoChungtunhap"></param>
    ''' <param name="masophieuxuat"></param>
    ''' <param name="masoxt"></param>
    ''' <remarks></remarks>
    Public Sub XoaPhanboPhieuxuat(ByVal MasoChungtunhap As Integer, Optional ByRef masophieuxuat As Integer = 0, Optional ByRef masoxt As Integer = 0)
        Try
            Dim rs_chungtu1 As DataTable
            Dim sql As String = String.Empty
            Dim ctu As New ClsChungtu
            ' Liệt kê phiếu xuất
            If MasoChungtunhap = 0 And masophieuxuat = 0 And masoxt <> 0 Then
                sql = String.Format("SELECT * FROM chungtu WHERE maloai=2 AND maso={0}", masoxt)
            Else
                sql = String.Format("SELECT * FROM chungtu WHERE maloai=2 AND {0}", (IIf(masophieuxuat = 0, _
                                                                                         String.Format("ct_id={0}", MasoChungtunhap + 900000000), _
                                                                                         String.Format("maso={0}", masophieuxuat))))
            End If
            Dim rs_chungtu As DataTable = ExecSQLReturnDT(sql)
            For Each rschungtuItem As DataRow In rs_chungtu.Rows
                ' Liệt kê phân bổ
                sql = String.Format("SELECT maso FROM chungtu WHERE maloai=14 AND thangct>={0}", rschungtuItem("ThangCT"))
                rs_chungtu1 = ExecSQLReturnDT(sql)
                For Each rsItem As DataRow In rs_chungtu1.Rows
                    ' Xoá phân bổ
                    ctu.InitChungtu(ConvertToIDSafe(rsItem("MaSo")), _
                        0, _
                        String.Empty, _
                        0, _
                        DateTime.Today, _
                        DateTime.Today, _
                        0, _
                        0, _
                        String.Empty, _
                        0, _
                        0, _
                        0, _
                        0, _
                        0, _
                        0, _
                        String.Empty, _
                        0, DateTime.Today)
                    ctu.XoaChungtu()
                Next
                ' Xoá phiếu xuất
                ctu.InitChungtu(ConvertToIDSafe(rschungtuItem("MaSo")), _
                    0, _
                    String.Empty, _
                    0, _
                    DateTime.Today, _
                    DateTime.Today, _
                    0, _
                    0, _
                    String.Empty, _
                    0, _
                    0, _
                    0, _
                    0, _
                    0, _
                    0, _
                    String.Empty, _
                    0, DateTime.Today)
                ctu.XoaChungtu()
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' Tự động điều chỉnh lại lượng khấu hao nếu lớn hơn giá trị còn lại của tài sản
    ''' thực hiện cho tất cả các tài sản trong một tháng.
    ''' </summary>
    ''' <param name="thg">Tháng kiểm tra</param>
    ''' <remarks>Sử dụng : Được gọi từ thủ tục CapNhatGiaTriCongcudungcu trong frmBaoCao</remarks>
    Public Sub DieuChinhPhanBo(ByRef thg As Integer)
        Try
            ' Ngân sách
            ExecSQLNonQuery(String.Format("UPDATE thongso1 SET KH_NS =  CASE WHEN ((KH_NS + CL_NS) < 0) THEN 0 ELSE KH_NS + CL_NS END WHERE CL_NS < KH_NS AND CL_NS < 1000 AND Thang = {0}", thg))
            ' Tự bổ sung
            ExecSQLNonQuery(String.Format("UPDATE thongso1 SET KH_TBS =  CASE WHEN ((KH_TBS + CL_TBS) < 0) THEN 0 ELSE KH_TBS + CL_TBS END WHERE CL_TBS < KH_TBS AND CL_TBS < 1000 AND Thang = {0}", thg))
            ' Các nguồn khác
            ExecSQLNonQuery(String.Format("UPDATE thongso1 SET KH_CNK =  CASE WHEN ((KH_CNK + CL_CNK)) < 0 THEN 0 ELSE KH_CNK + CL_CNK END WHERE CL_CNK < KH_CNK AND CL_CNK < 1000 AND Thang = {0}", thg))
            ' Tín dụng
            ExecSQLNonQuery(String.Format("UPDATE thongso1 SET KH_TD =  CASE WHEN ((KH_TD + CL_TD)) < 0 THEN 0 ELSE KH_TD + CL_TD END WHERE CL_TD < KH_TD AND CL_TD < 1000 AND Thang = {0}", thg))
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="LoaiKH"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ThangDaPhanBo(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef LoaiKH As Integer) As Boolean
        Return ConvertToDblSafe(GetSelectValue(String.Format("SELECT DISTINCT TOP 1 ChungTu.MaCT AS F1 FROM {0} WHERE {1} AND MaLoai = 14", _
                                                   ChungTu2TKNC(-1), _
                                                   WThang("ThangCT", tdau, tcuoi)))) > 0
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="SoHieu"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="LoaiKH"></param>
    ''' <param name="ctmoi"></param>
    ''' <param name="shtk"></param>
    ''' <remarks></remarks>
    Public Sub XoaChungTuPhanBo(ByRef SoHieu As String, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef LoaiKH As Integer, ByRef ctmoi As Integer, ByRef shtk As String)
        Dim ctu As New ClsChungtu
        Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT DISTINCT ChungTu.mact FROM {0} WHERE ChungTu.SoHieu=N'{1}' AND HethongTK.SoHieu LIKE N'{2}%' AND MaCT <> {3} AND {4} AND MaLoai = 14 group by ChungTu.mact", _
                                                  ChungTu2TKNC(-1), _
                                                  SoHieu, _
                                                  shtk, _
                                                  ctmoi, _
                                                  WThang("ThangCT", tdau, tcuoi)))
        For Each rsItem As DataRow In rs.Rows
            ExecSQLNonQuery(String.Format("DELETE FROM ctcongcudungcu WHERE mactkt={0}", rsItem("MaCT")))
            ExecSQLNonQuery(String.Format("DELETE FROM chungtu WHERE mact={0}", rsItem("MaCT")))
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="loaict"></param>
    ''' <param name="MaSoCT"></param>
    ''' <remarks></remarks>
    Public Sub XoaChungtuCCDC(ByRef loaict As Integer, ByRef MaSoCT As Integer)
        Dim sql As String = String.Empty
        Dim rs As DataTable
        Select Case loaict
            Case 13
                sql = String.Format("SELECT MaTS AS F1 FROM CTCongcudungcu  WHERE MaCTKT={0}", MaSoCT)
                rs = ExecSQLReturnDT(sql)
                For Each rsItem As DataRow In rs.Rows
                    XoaCongcudungcu(ConvertToIDSafe(rsItem("f1")))
                Next
            Case 10
                sql = String.Format("SELECT MaTS AS F1 FROM CTCongcudungcu  WHERE MaCTKT={0}", MaSoCT)
                TacDongGiamCongcudungcu(ConvertToDblSafe(GetSelectValue(sql)), 13, TD_KHOIPHUC)
        End Select
        If loaict <> 13 Then ExecSQLNonQuery(String.Format("DELETE FROM CTCongcudungcu WHERE MaCTKT = {0}", MaSoCT))
    End Sub
    ''' <summary>
    ''' Hàm trả về mã số, tên TK từ số hiệu
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <param name="mtk"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TenCCDC(ByRef sh As String, ByRef mtk As Integer) As String
        Dim result As String = String.Empty
        Dim rs_tk As DataTable
        If mtk > 0 Then
            rs_tk = ExecSQLReturnDT(String.Format("SELECT SoHieu, Ten FROM Congcudungcu WHERE MaSo={0}", mtk))
            result = ConvertToStrSafe(rs_tk.Rows(0)("ten"))
            sh = ConvertToStrSafe(rs_tk.Rows(0)("SoHieu"))
        Else
            rs_tk = ExecSQLReturnDT(String.Format("SELECT MaSo, Ten FROM Congcudungcu WHERE SoHieu=N'{0}'", sh))
            If rs_tk.Rows.Count > 0 Then
                mtk = ConvertToIDSafe(rs_tk.Rows(0)("MaSo"))
                result = ConvertToStrSafe(rs_tk.Rows(0)("ten"))
            Else
                mtk = 0
                result = String.Empty
            End If
        End If
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <remarks></remarks>
    Public Sub XoaPSCCDC(ByRef thang As Integer)
        Dim rs_chungtu As DataTable = ExecSQLReturnDT(String.Format("SELECT CTCongcudungcu.* FROM CTCongcudungcu WHERE Thang = {0}", thang))
        For Each rschungtuItem As DataRow In rs_chungtu.Rows
            Select Case ConvertToDblSafe(rschungtuItem("maloai"))
                Case NV_TANG
                    XoaCongcudungcu(ConvertToDblSafe(rschungtuItem("MaTS")))
                Case NV_GIAM
                    TacDongGiamCongcudungcu(ConvertToDblSafe(rschungtuItem("MaTS")), 13, TD_KHOIPHUC)
            End Select
        Next
        ExecSQLNonQuery(String.Format("DELETE FROM CTCongcudungcu WHERE Thang = {0}", thang))
    End Sub
    ''' <summary>
    ''' Chuyen Nam Moi TS
    ''' </summary>
    ''' <param name="chuyennam"></param>
    ''' <remarks></remarks>
    Public Sub ChuyenNamMoiCCDC(Optional ByRef chuyennam As Boolean = False)
        'Dim i AS Integer
        ' Xoá các tài sản đã bị giảm trong năm
        ExecSQLNonQuery(String.Format("DELETE DCPTung FROM DCPTung RIGHT JOIN Congcudungcu ON DCPTung.MaTS = Congcudungcu.MaSo WHERE Congcudungcu.ThangGiam < 13"))
        ExecSQLNonQuery(String.Format("DELETE thongso1 FROM thongso1 RIGHT JOIN Congcudungcu ON thongso1.MaTS = Congcudungcu.MaSo WHERE Congcudungcu.ThangGiam < 13"))
        ExecSQLNonQuery("DELETE FROM Congcudungcu WHERE ThangGiam < 13")
        'ExecSQLNonQuery("UPDATE Congcudungcu SET NamKH = 0 WHERE NamKH ISNULL")
        If chuyennam Then ExecSQLNonQuery("UPDATE Congcudungcu SET NamSD = 1")
        ' Tính giá trị cho các tài sản vào cuối kỳ
        TinhGiaTriCuoiKy1()
        ' Tạo chứng từ kết chuyển
        TaoChungTuKetChuyen1()
        ' Cập nhật lại lượng khấu hao hàng tháng và các đối tượng quan hệ
        ExecSQLNonQuery("UPDATE thongso1 SET thongso1.KH_NS = thongso1CuoiKy.KH_NS, thongso1.KH_TBS = thongso1CuoiKy.KH_TBS, thongso1.KH_CNK = thongso1CuoiKy.KH_CNK, thongso1.KH_TD = thongso1CuoiKy.KH_TD, thongso1.MaDTQL = thongso1CuoiKy.MaDTQL, thongso1.MaDTSD = thongso1CuoiKy.MaDTSD, thongso1.MaTTSD = thongso1CuoiKy.MaTTSD from thongso1 LEFT JOIN (SELECT DISTINCT * FROM Thongso1 WHERE thang=12) as thongso1CuoiKy ON thongso1.MaTS = thongso1CuoiKy.MaTS WHERE (((thongso1.Thang)<12 AND (thongso1.Thang)>0))")
        ' Cập nhật lại thời gian
        ExecSQLNonQuery("UPDATE Congcudungcu SET ThangTang = 0")
    End Sub
    ''' <summary>
    ''' Tính giá trị cuối kỳ
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub TinhGiaTriCuoiKy1()
        'Dim TongKhauHao AS String = String.Format("SELECT Sum(Thongso1.KH_NS) AS TKH_NS, Sum(Thongso1.KH_TBS) AS TKH_TBS, Sum(Thongso1.KH_CNK) AS TKH_CNK, Sum(Thongso1.KH_TD) AS TKH_TD, Thongso1.MaTS, (Congcudungcu.ThangTang) AS ThangT, Max(CASE WHEN Thongso1.Thang = 12 THEN MaDTQL ELSE 0 END) AS DTQL, Max(CASE WHEN Thongso1.Thang = 12 THEN MaDTSD ELSE 0 END) AS DTSD, Max(CASE WHEN Thongso1.Thang = 12 THEN MaTTSD ELSE 0 END) AS TTSD FROM Congcudungcu RIGHT JOIN Thongso1 ON Congcudungcu.MaSo = Thongso1.MaTS WHERE {0} GROUP BY MaTS", VC("Thongso1.Thang", "CASE WHEN  Congcudungcu.ThangTang=0 THEN " & pThangDauKy & " ELSE Congcudungcu.ThangTang END"))
        Dim TongKhauHao As String = String.Format("SELECT Sum(Thongso1.KH_NS) AS TKH_NS, Sum(Thongso1.KH_TBS) AS TKH_TBS, Sum(Thongso1.KH_CNK) AS TKH_CNK, Sum(Thongso1.KH_TD) AS TKH_TD, Thongso1.MaTS, Congcudungcu.ThangTang AS ThangT, Max(CASE WHEN Thongso1.Thang = 12 THEN MaDTQL ELSE 0 END) AS DTQL, Max(CASE WHEN Thongso1.Thang = 12 THEN MaDTSD ELSE 0 END) AS DTSD, Max(CASE WHEN Thongso1.Thang = 12 THEN MaTTSD ELSE 0 END) AS TTSD FROM Congcudungcu RIGHT JOIN Thongso1 ON Congcudungcu.MaSo = Thongso1.MaTS WHERE {0} GROUP BY MaTS, congcudungcu.thangtang", VC("Thongso1.Thang", "CASE WHEN  Congcudungcu.ThangTang=0 THEN " & pThangDauKy & " ELSE Congcudungcu.ThangTang END"))
        Dim TongGiaTri As String = "SELECT Sum(NG_NS) AS TNG_NS, Sum(NG_TBS) AS TNG_TBS, Sum(NG_CNK) AS TNG_CNK, Sum(NG_TD) AS TNG_TD, Sum(CL_NS) AS TCL_NS, Sum(CL_TBS) AS TCL_TBS, Sum(CL_CNK) AS TCL_CNK, Sum(CL_TD) AS TCL_TD, MaTS FROM CTCongcudungcu WHERE Thang < 13 GROUP BY MaTS"
        Dim GiaTriCongcudungcu As String = String.Format("SELECT DISTINCT TongKhauHao.ThangT, TongKhauHao.DTQL, TongKhauHao.DTSD, TongKhauHao.TTSD, TNG_NS AS NG_NS, TNG_TBS AS NG_TBS, TNG_CNK AS NG_CNK, TNG_TD AS NG_TD, TCL_NS-TKH_NS AS CL_NS, TCL_TBS-TKH_TBS AS CL_TBS, TCL_CNK-TKH_CNK AS CL_CNK, TCL_TD-TKH_TD AS CL_TD, TongGiaTri.MaTS FROM ({0}) AS TongKhauHao INNER JOIN ({1}) AS TongGiaTri ON TongKhauHao.MaTS = TongGiaTri.MaTS", _
                                               TongKhauHao, _
                                               TongGiaTri)
        Dim rs_giatri As DataTable = ExecSQLReturnDT(GiaTriCongcudungcu)
        For Each rsgiatriItem As DataRow In rs_giatri.Rows
            ExecSQLNonQuery(String.Format("UPDATE thongso1 SET NG_NS = {0}, NG_TBS = {1}, NG_CNK = {2}, NG_TD = {3}, CL_NS = {4}, CL_TBS = {5}, CL_CNK = {6}, CL_TD = {7} WHERE MaTS = {8} AND Thang = 0", _
                                        CStr(ConvertToDblSafe(rsgiatriItem("NG_NS"))), _
                                        CStr(ConvertToDblSafe(rsgiatriItem("NG_TBS"))), _
                                        CStr(ConvertToDblSafe(rsgiatriItem("NG_CNK"))), _
                                        CStr(ConvertToDblSafe(rsgiatriItem("NG_TD"))), _
                                        CStr(ConvertToDblSafe(rsgiatriItem("CL_NS"))), _
                                        CStr(ConvertToDblSafe(rsgiatriItem("CL_TBS"))), _
                                        CStr(ConvertToDblSafe(rsgiatriItem("CL_CNK"))), _
                                        CStr(ConvertToDblSafe(rsgiatriItem("CL_TD"))), _
                                        rsgiatriItem("MaTS")))
            If ConvertToDblSafe(rsgiatriItem("ThangT")) > 0 Then
                For i As Integer = 0 To ConvertToDblSafe(rsgiatriItem("ThangT")) - 1
                    ExecSQLNonQuery(String.Format("INSERT INTO thongso1 (MaSo,MaTS, Thang, NG_NS, NG_TBS, NG_CNK, NG_TD, CL_NS, CL_TBS, CL_CNK, CL_TD, MaDTQL, MaDTSD, MaTTSD) VALUES ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})", _
                                        Lng_MaxValue("MaSo", "thongso1") + 1, _
                                        rsgiatriItem("MaTS"), _
                                        ConvertToStrSafe(i), _
                                        CStr(ConvertToDblSafe(rsgiatriItem("NG_NS"))), _
                                        CStr(ConvertToDblSafe(rsgiatriItem("NG_TBS"))), _
                                        CStr(ConvertToDblSafe(rsgiatriItem("NG_CNK"))), _
                                        CStr(ConvertToDblSafe(rsgiatriItem("NG_TD"))), _
                                        CStr(ConvertToDblSafe(rsgiatriItem("CL_NS"))), _
                                        CStr(ConvertToDblSafe(rsgiatriItem("CL_TBS"))), _
                                        CStr(ConvertToDblSafe(rsgiatriItem("CL_CNK"))), _
                                        CStr(ConvertToDblSafe(rsgiatriItem("CL_TD"))), _
                                        rsgiatriItem("DTQL"), _
                                        rsgiatriItem("DTSD"), _
                                        rsgiatriItem("TTSD")))
                Next
            End If
        Next
        ' Xoá các chứng từ của năm cũ
        ExecSQLNonQuery("DELETE FROM CTCongcudungcu")
    End Sub
    ''' <summary>
    ''' Tạo chứng từ kết chuyển
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub TaoChungTuKetChuyen1()
        Dim rs As DataTable = ExecSQLReturnDT("SELECT DISTINCT Congcudungcu.MaSo, Congcudungcu.SoHieu, Congcudungcu.Ten, thongso1.NG_NS, thongso1.NG_TBS, thongso1.NG_CNK, thongso1.NG_TD, thongso1.CL_NS, thongso1.CL_TBS, thongso1.CL_CNK, thongso1.CL_TD FROM Congcudungcu RIGHT JOIN thongso1 ON Congcudungcu.MaSo = thongso1.MaTS WHERE thongso1.Thang=0")
        For Each rsItem As DataRow In rs.Rows
            ExecSQLNonQuery(String.Format("INSERT INTO CTCongcudungcu (MaSo, SoHieu, Thang, VaoSo, NgayGhi, DienGiai, MaLoai, MaNhom, MaTS, NG_NS, NG_TBS, NG_CNK, NG_TD, CL_NS, CL_TBS, CL_CNK, CL_TD) {0}{1}{2}', 0, N'{3}', N'{3}','Đầu năm: {4}',{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15})", _
                                String.Format("VALUES ({0},'", Lng_MaxValue("MaSo", "CTCongcudungcu") + 1), _
                                rsItem("SoHieu"), _
                                pNamTC - 1899, _
                                Format(DateTime.Today, Mask_DB), _
                                rsItem("ten"), _
                                DK_LOAI, _
                                DK_NHOM, _
                                rsItem("MaSo"), _
                                CStr(ConvertToDblSafe(rsItem("NG_NS"))), _
                                CStr(ConvertToDblSafe(rsItem("NG_TBS"))), _
                                CStr(ConvertToDblSafe(rsItem("NG_CNK"))), _
                                CStr(ConvertToDblSafe(rsItem("NG_TD"))), _
                                CStr(ConvertToDblSafe(rsItem("CL_NS"))), _
                                CStr(ConvertToDblSafe(rsItem("CL_TBS"))), _
                                CStr(ConvertToDblSafe(rsItem("CL_CNK"))), _
                                CStr(ConvertToDblSafe(rsItem("CL_TD")))))
        Next
    End Sub
    ''' <summary>
    ''' Thủ tục tính số dư đầu kỳ của các tài khoản vật tư
    ''' </summary>
    ''' <param name="co"></param>
    ''' <remarks></remarks>
    Public Sub SoDuTKTSCCDC(Optional ByRef co As Boolean = False)
        Dim taikhoan As New ClsTaikhoan
        Dim rs_tk As DataTable = ExecSQLReturnDT("SELECT HeThongTK.SoHieu, Sum(CTCongcudungcu.cl_NS + CTCongcudungcu.cl_TBS + CTCongcudungcu.cl_CNK + CTCongcudungcu.cl_TD) AS TNG FROM (LoaiCongcudungcu INNER JOIN (Congcudungcu INNER JOIN CTCongcudungcu ON Congcudungcu.MaSo = CTCongcudungcu.MaTS) ON LoaiCongcudungcu.MaSo = Congcudungcu.MaTaiKhoan) INNER JOIN HeThongTK ON LEFT(LoaiCongcudungcu.SoHieu,LEN(HeThongTK.SoHieu)) = HeThongTK.SoHieu WHERE CTCongcudungcu.thang > 0 AND CTCongcudungcu.maloai = 30 AND LoaiCongcudungcu.Cap=1 AND TKCon=0 GROUP BY HeThongTK.SoHieu")
        For Each rstkItem As DataRow In rs_tk.Rows
            taikhoan.InitTaikhoanSohieu(ConvertToStrSafe(rstkItem("SoHieu")))
            taikhoan.NoDauKy = ConvertToDblSafe(rstkItem("TNG"))
            taikhoan.CapNhatTk()
        Next
        rs_tk = ExecSQLReturnDT("SELECT LEFT(HeThongTK.SoHieu,3) AS SHTK, Sum((CTCongcudungcu.cl_NS + CTCongcudungcu.cl_TBS + CTCongcudungcu.cl_CNK + CTCongcudungcu.cl_TD) - (CTCongcudungcu.CL_NS + CTCongcudungcu.CL_TBS + CTCongcudungcu.CL_CNK + CTCongcudungcu.CL_TD)) AS THM,max(CTCongcudungcu.thang)AS thang  FROM (LoaiCongcudungcu INNER JOIN (Congcudungcu INNER JOIN CTCongcudungcu ON Congcudungcu.MaSo = CTCongcudungcu.MaTS) ON LoaiCongcudungcu.MaSo = Congcudungcu.MaTaiKhoan) INNER JOIN HeThongTK ON (LEFT(LoaiCongcudungcu.SoHieu,LEN(HeThongTK.SoHieu)) = HeThongTK.SoHieu AND LoaiCongcudungcu.Cap=1) WHERE CTCongcudungcu.thang > 0 AND CTCongcudungcu.maloai = 30 AND LoaiCongcudungcu.Cap=1 AND TKCon=0 GROUP BY LEFT(HeThongTK.SoHieu,3)")
        For Each rstkItem As DataRow In rs_tk.Rows
            taikhoan.InitTaikhoanSohieu(String.Format("153{0}", Strings.Right(ConvertToStrSafe(rstkItem("shtk")), 1)))
            taikhoan.CoDauKy = ConvertToDblSafe(rstkItem("THM"))
            taikhoan.CapNhatTk(ConvertToDblSafe(rstkItem("thang")))
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mts"></param>
    ''' <param name="thang"></param>
    ''' <remarks></remarks>
    Public Sub DieuChinhPB(ByRef mts As Integer, ByRef thang As Integer)
        Dim ts As New ClsCongcudungcu
        ts.ChiDinh(mts, thang)
        If ts.NamKH > 0 Then
            With ts.ThongSo
                .KH_NS = RoundMoney(.NG_NS / ts.NamKH)
                .KH_TBS = RoundMoney(.NG_TBS / ts.NamKH)
                .KH_CNK = RoundMoney(.NG_CNK / ts.NamKH)
                .KH_TD = RoundMoney(.NG_TD / ts.NamKH)
                .SuaDoiQuanHe1()
            End With
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ms"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function KhongDCCCDC(ByRef ms As Integer) As Boolean
        Dim sql As String = String.Format("SELECT Count(MaSo) AS F1 FROM CTCongcudungcu WHERE MaTS={0} AND MaNhom={1}", _
                                ms, _
                                NV_DGLAI)
        Return ConvertToDblSafe(GetSelectValue(sql)) > 0
    End Function
End Module
