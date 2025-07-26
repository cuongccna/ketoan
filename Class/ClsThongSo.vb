Imports System
Imports System.Media
Imports UNET.Utility
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Friend Class clsThongSo
#Region "Thuộc tính"
    Public MaTS As Integer
    Public thang As Integer
    ' Nguyên giá
    Public NG_NS As Double
    Public NG_TBS As Double
    Public NG_CNK As Double
    Public NG_TD As Double
    ' Giá trị còn lại
    Public CL_NS As Double
    Public CL_TBS As Double
    Public CL_CNK As Double
    Public CL_TD As Double
    ' Lượng hao mòn
    Public HM_NS As Double
    Public HM_TBS As Double
    Public HM_CNK As Double
    Public HM_TD As Double
    ' Lượng khấu hao hàng tháng
    Public KH_NS As Double
    Public KH_TBS As Double
    Public KH_CNK As Double
    Public KH_TD As Double
    ' Mã số của các đối tượng quan hệ
    Public MaDTQL As Integer
    Public MaDTSD As Integer
    Public MaTTSD As Integer
#End Region
#Region "Phương thức"
    ''' <summary>
    ''' Kiểm tra dữ liệu
    ''' </summary>
    ''' <returns>0 nếu hợp lệ, -1 nếu có lỗi</returns>
    ''' <remarks></remarks>
    Public Function HopLe() As Integer
        Dim thong_bao As String = String.Empty
        Dim returnValue As Integer = 0
        If MaDTSD = 0 Then
            thong_bao = "Thiếu hoặc chưa đăng ký đối tượng sử dụng"
            returnValue = -1
        End If
        If (NG_NS = 0 And (KH_NS <> 0)) Or (NG_TBS = 0 And (KH_TBS <> 0)) Or (NG_CNK = 0 And (KH_CNK <> 0)) Or (NG_TD = 0 And (KH_TD <> 0)) Then
            thong_bao = "Lượng khấu hao chỉ có nếu tài sản có thành phần nguồn vốn tương ứng"
            returnValue = -1
        End If
        If (CL_NS < KH_NS) Or (CL_TBS < KH_TBS) Or (CL_CNK < KH_CNK) Or (CL_TD < KH_TD) Then
            thong_bao = String.Format("Lượng khấu hao lớn hơn giá trị còn lại của tài sản{0}Tiếp tục ghi", Environment.NewLine) ': GoTo Err_InValidate
            SystemSounds.Beep.Play()
            If myUMessager.mQuestion(thong_bao, My.Computer.Name, _
                                     MessageBoxButtons.YesNo, _
                                     MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
                Return -1
            End If
        End If
        If returnValue = -1 Then
            SystemSounds.Beep.Play()
            myUMessager.mError(thong_bao, My.Computer.Name, _
                               MessageBoxButtons.OK, _
                               MessageBoxIcon.Error)
        End If

        Return returnValue
    End Function
    ''' <summary>
    ''' Thêm một bản ghi chứa giá trị hàng tháng của tài sản
    ''' </summary>
    ''' <returns>0 nếu thành công, -1 nếu có lỗi</returns>
    ''' <remarks></remarks>
    Public Function ThemMoi() As Integer
        Try
            Dim sql As String = String.Empty
            sql = String.Format("INSERT INTO ThongSo ( MaSo, MaTS, Thang, NG_NS, NG_TBS, NG_CNK, NG_TD, CL_NS, CL_TBS, CL_CNK, CL_TD, KH_NS, KH_TBS, KH_CNK, KH_TD, MaDTQL, MaDTSD, MaTTSD ) VALUES ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17})", _
                        (Lng_MaxValue("MaSo", "ThongSo") + 1), _
                        ConvertToStrSafe(MaTS), _
                        ConvertToStrSafe(thang), _
                        CStr(NG_NS), _
                        CStr(NG_TBS), _
                        CStr(NG_CNK), _
                        CStr(NG_TD), _
                        CStr(CL_NS), _
                        CStr(CL_TBS), _
                        CStr(CL_CNK), _
                        CStr(CL_TD), _
                        IIf(thang = 0, 0, CStr(KH_NS)), _
                        IIf(thang = 0, 0, CStr(KH_TBS)), _
                        IIf(thang = 0, 0, CStr(KH_CNK)), _
                        IIf(thang = 0, 0, CStr(KH_TD)), _
                        ConvertToStrSafe(MaDTQL), _
                        ConvertToStrSafe(MaDTSD), _
                        ConvertToStrSafe(MaTTSD))
            Return ExecSQLNonQuery(sql)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ThemMoi1() As Integer
        Dim sql As String = String.Empty
        If thang > 0 Then
            sql = String.Format("INSERT INTO ThongSo1 ( MaSo, MaTS, Thang, NG_NS, NG_TBS, NG_CNK, NG_TD, CL_NS, CL_TBS, CL_CNK, CL_TD, KH_NS, KH_TBS, KH_CNK, KH_TD, MaDTSD) VALUES ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15})", _
                      (Lng_MaxValue("MaSo", "ThongSo1") + 1), _
                      ConvertToStrSafe(MaTS), _
                      ConvertToStrSafe(thang), _
                      CStr(NG_NS), _
                      CStr(NG_TBS), _
                      CStr(NG_CNK), _
                      CStr(NG_TD), _
                      CStr(CL_NS), _
                      CStr(CL_TBS), _
                      CStr(CL_CNK), _
                      CStr(CL_TD), _
                      CStr(KH_NS), _
                      CStr(KH_TBS), _
                      CStr(KH_CNK), _
                      CStr(KH_TD), _
                      ConvertToStrSafe(MaDTSD))
        Else
            sql = String.Format("INSERT INTO ThongSo1 ( MaSo, MaTS, Thang, NG_NS, NG_TBS, NG_CNK, NG_TD, CL_NS, CL_TBS, CL_CNK, CL_TD, MaDTSD) VALUES ({0},{1},0,{2},{3},{4},{5},{6},{7},{8},{9},{10})", _
                      (Lng_MaxValue("MaSo", "ThongSo1") + 1), _
                      ConvertToStrSafe(MaTS), _
                      CStr(NG_NS), _
                      CStr(NG_TBS), _
                      CStr(NG_CNK), _
                      CStr(NG_TD), _
                      CStr(CL_NS), _
                      CStr(CL_TBS), _
                      CStr(CL_CNK), _
                      CStr(CL_TD), _
                      ConvertToStrSafe(MaDTSD))
        End If
        Return ExecSQLNonQuery(sql)
    End Function
    ''' <summary>
    ''' Gán các thuộc tính của đối tượng hiện tại theo giá trị lưu trong cơ sở dữ liệu
    ''' -  Chú ý: Ngoài mã số của các đối tượng quan hệ, các thuộc tính giá trị sẽ được 
    ''' tính toán lại theo dữ liệu lưu trong chứng từ có liên quan và lượng khấu hao hàng tháng. 
    ''' </summary>
    ''' <param name="ma_ts"></param>
    ''' <param name="thang_cd"></param>
    ''' <remarks></remarks>
    Public Sub ChiDinh(ByVal ma_ts As Integer, ByVal thang_cd As Integer)
        ' Các đối tượng quan hệ
        Dim sql As String = String.Format("SELECT  * FROM ThongSo WHERE MaTS = {0} AND Thang = {1}", _
                                ma_ts, _
                                ConvertToStrSafe(CThangDB2(thang_cd)))
        Dim dt_thongso As DataTable = ExecSQLReturnDT(sql)
        If dt_thongso.Rows.Count > 0 Then
            With dt_thongso.Rows(0)
                'van.nguyen 2-Dec-2011
                If .Item("MaTS") IsNot Nothing Then
                    MaTS = ConvertToDblSafe(.Item("MaTS"))
                End If

                If .Item("thang") IsNot Nothing Then
                    thang = ConvertToDblSafe(.Item("thang"))
                End If
                If .Item("MaDTQL") IsNot Nothing Then
                    MaDTQL = ConvertToDblSafe(.Item("MaDTQL"))
                End If
                If .Item("MaDTSD") IsNot Nothing Then
                    MaDTSD = ConvertToDblSafe(.Item("MaDTSD"))
                End If
                If .Item("MaTTSD") IsNot Nothing Then
                    MaTTSD = ConvertToDblSafe(.Item("MaTTSD"))
                End If


            End With
        End If
        ' Nguyên giá, giá trị còn lại, lượng hao mòn và khấuhao
        ' (giá trị đã được điều chỉnh và không trích khấu hao)
        TinhGiaTriTaiSan(MaTS, thang_cd, KH_KHONG)
        With GiaTri
            NG_NS = .NG_NS
            NG_TBS = .NG_TBS
            NG_CNK = .NG_CNK
            NG_TD = .NG_TD
            CL_NS = .CL_NS
            CL_TBS = .CL_TBS
            CL_CNK = .CL_CNK
            CL_TD = .CL_TD
            KH_NS = .KH_NS
            KH_TBS = .KH_TBS
            KH_CNK = .KH_CNK
            KH_TD = .KH_TD
        End With
        ' Lượng hao mòn
        HM_NS = NG_NS - CL_NS
        HM_TBS = NG_TBS - CL_TBS
        HM_CNK = NG_CNK - CL_CNK
        HM_TD = NG_TD - CL_TD
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ma_ts"></param>
    ''' <param name="thang_cd"></param>
    ''' <remarks></remarks>
    Public Sub ChiDinh1(ByVal ma_ts As Integer, ByVal thang_cd As Integer)
        ' Các đối tượng quan hệ
        Dim sql As String = String.Format("SELECT  * FROM ThongSo1 WHERE MaTS = {0} AND Thang = {1}", _
                                ma_ts, _
                                ConvertToStrSafe(CThangDB2(thang_cd)))
        Dim rs_thongso As DataTable = ExecSQLReturnDT(sql)
        If rs_thongso.Rows.Count > 0 Then
            Dim rs_thongsoItem As DataRow = rs_thongso.Rows(0)
            If rs_thongsoItem("MaTS") IsNot Nothing Then
                MaTS = ConvertToDblSafe(rs_thongsoItem("MaTS"))
            End If

            If rs_thongsoItem("thang") IsNot Nothing Then
                thang = ConvertToDblSafe(rs_thongsoItem("thang"))
            End If

            If rs_thongsoItem("MaDTSD") IsNot Nothing Then
                MaDTSD = ConvertToDblSafe(rs_thongsoItem("MaDTSD"))
            End If

        End If
        ' Nguyên giá, giá trị còn lại, lượng hao mòn và khấuhao
        ' (giá trị đã được điều chỉnh và không trích khấu hao)
        TinhGiaTriCongcudungcu(MaTS, thang_cd, KH_KHONG)
        With GiaTri
            NG_NS = .NG_NS
            NG_TBS = .NG_TBS
            NG_CNK = .NG_CNK
            NG_TD = .NG_TD
            CL_NS = .CL_NS
            CL_TBS = .CL_TBS
            CL_CNK = .CL_CNK
            CL_TD = .CL_TD
            KH_NS = .KH_NS
            KH_TBS = .KH_TBS
            KH_CNK = .KH_CNK
            KH_TD = .KH_TD
        End With
        ' Lượng hao mòn
        HM_NS = NG_NS - CL_NS
        HM_TBS = NG_TBS - CL_TBS
        HM_CNK = NG_CNK - CL_CNK
        HM_TD = NG_TD - CL_TD
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub KhoiTao()
        MaTS = 0
        thang = 0
        ' Nguyên giá
        NG_NS = 0
        NG_TBS = 0
        NG_CNK = 0
        NG_TD = 0
        ' Giá trị còn lại
        CL_NS = 0
        CL_TBS = 0
        CL_CNK = 0
        CL_TD = 0
        ' Hao mòn
        HM_NS = 0
        HM_TBS = 0
        HM_CNK = 0
        HM_TD = 0
        ' Khấu hao
        KH_NS = 0
        KH_TBS = 0
        KH_CNK = 0
        KH_TD = 0
        ' Các đối tượng quan hệ
        MaDTQL = 0
        MaDTSD = 0
        MaTTSD = 0
    End Sub
    ''' <summary>
    ''' Thay đổi luỹ tiến lượng khấu hao và các đối tượng quan hệ
    ''' - Chú ý: Các thay đổi về lượng khấu hao sẽ có thể làm sai lệch lượng khấu hao đã được điều chỉnh
    ''' </summary>
    ''' <param name="dau_ky"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SuaDoiQuanHe(ByVal dau_ky As Boolean) As Object
        Dim sql As String = String.Format("UPDATE ThongSo SET [KH_NS] = {0}, [KH_TBS] = {1}, [KH_CNK] = {2}, [KH_TD] = {3}, MaDTQL = {4}, MaDTSD = {5}, MaTTSD = {6} WHERE Thang>=1 AND MaTS = {7}{8}", _
                                CStr(KH_NS), _
                                CStr(KH_TBS), _
                                CStr(KH_CNK), _
                                CStr(KH_TD), _
                                ConvertToStrSafe(MaDTQL), _
                                ConvertToStrSafe(MaDTSD), _
                                ConvertToStrSafe(MaTTSD), _
                                ConvertToStrSafe(MaTS), _
                                (IIf(dau_ky, String.Empty, String.Format(" AND Thang >= {0}", thang))))
        Return ExecSQLNonQuery(sql)
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SuaDoiQuanHe1() As Object
        Dim sql As String = String.Format("UPDATE ThongSo1 SET KH_NS = {0}, KH_TBS = {1}, KH_CNK = {2}, KH_TD = {3}, MaDTSD = {4} WHERE Thang>=1 AND MaTS = {5} AND Thang >= {6}", _
                                CStr(KH_NS), _
                                CStr(KH_TBS), _
                                CStr(KH_CNK), _
                                CStr(KH_TD), _
                                ConvertToStrSafe(MaDTSD), _
                                ConvertToStrSafe(MaTS), _
                                ConvertToStrSafe(thang))
        Dim sql1 As String = String.Format("UPDATE ThongSo1 SET KH_NS = {0}, KH_TBS = 0, KH_CNK = {1}, KH_TD = {2}, MaDTSD = {3} WHERE Thang>=1 AND MaTS = {4} AND Thang < {5}", _
                                 CStr(KH_NS), _
                                 CStr(KH_CNK), _
                                 CStr(KH_TD), _
                                 ConvertToStrSafe(MaDTSD), _
                                 ConvertToStrSafe(MaTS), _
                                 ConvertToStrSafe(thang))
        Return ExecSQLNonQuery(sql) + ExecSQLNonQuery(sql1)
    End Function
    ''' <summary>
    ''' Thay đổi giá trị cho các tháng trước tháng đầu kỳ hoặc tháng tăng.
    ''' - Chú ý: Thủ tục này không có ý nghĩa đối với các tháng sau tháng tăng hoặc tháng
    ''' đầu kỳ vì giá trị tài sản sẽ được cập nhật lại, nhưng đối với các tháng trước
    ''' thì cần thiết vì phải duy trì lượng tổng nguyên giá đầu kỳ cho các báo cáo
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SuaDoiGiaTri() As Object
        Dim sql As String = String.Format("UPDATE ThongSo SET NG_NS = {0}, NG_TBS = {1}, NG_CNK = {2}, NG_TD = {3}, CL_NS = {4}, CL_TBS = {5}, CL_CNK = {6}, CL_TD = {7} WHERE MaTS = {8} AND Thang  <= {9}", _
                                CStr(NG_NS), _
                                CStr(NG_TBS), _
                                CStr(NG_CNK), _
                                CStr(NG_TD), _
                                CStr(CL_NS), _
                                CStr(CL_TBS), _
                                CStr(CL_CNK), _
                                CStr(CL_TD), _
                                ConvertToStrSafe(MaTS), _
                                ConvertToStrSafe(thang))
        Return ExecSQLNonQuery(sql)
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SuaDoiGiaTri1() As Object
        Dim sql As String = String.Format("UPDATE ThongSo1 SET NG_NS = {0}, NG_TBS = {1}, NG_CNK = {2}, NG_TD = {3}, CL_NS = {4}, CL_TBS = {5}, CL_CNK = {6}, CL_TD = {7} WHERE MaTS = {8} AND Thang  <= {9}", _
                                CStr(NG_NS), _
                                CStr(NG_TBS), _
                                CStr(NG_CNK), _
                                CStr(NG_TD), _
                                CStr(CL_NS), _
                                CStr(CL_TBS), _
                                CStr(CL_CNK), _
                                CStr(CL_TD), _
                                ConvertToStrSafe(MaTS), _
                                ConvertToStrSafe(thang))
        Return ExecSQLNonQuery(sql)
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ts1"></param>
    ''' <remarks></remarks>
    Public Sub DanXuat(ByVal ts1 As clsThongSo)
        With ts1
            .MaTS = MaTS
            .thang = thang
            ' Nguyên giá
            .NG_NS = NG_NS
            .NG_TBS = NG_TBS
            .NG_CNK = NG_CNK
            .NG_TD = NG_TD
            ' Giá trị còn lại
            .CL_NS = CL_NS
            .CL_TBS = CL_TBS
            .CL_CNK = CL_CNK
            .CL_TD = CL_TD
            ' Hao mòn
            .HM_NS = HM_NS
            .HM_TBS = HM_TBS
            .HM_CNK = HM_CNK
            .HM_TD = HM_TD
            ' Khấu hao
            .KH_NS = KH_NS
            .KH_TBS = KH_TBS
            .KH_CNK = KH_CNK
            .KH_TD = KH_TD
            ' Các đối tượng quan hệ
            .MaDTQL = MaDTQL
            .MaDTSD = MaDTSD
            .MaTTSD = MaTTSD
        End With
    End Sub
#End Region
End Class