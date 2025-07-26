Imports UNET.DataAdapter
Imports UNET.Utilities
Imports UNET.Utility
Imports System.Threading

Public Class uThongKe_doanhthu_chiphi

    Dim tientrinh As Thread


    ''' <summary>
    ''' InLuyKe
    ''' </summary>
    ''' <param name="GauGe"></param>
    ''' <param name="mkho"></param> 1
    ''' <param name="shtk"></param> ""
    ''' <param name="mloai"></param> 0
    ''' <param name="tdau"></param> 1
    ''' <param name="tcuoi"></param> 12
    ''' <param name="T"></param>
    ''' <param name="loailk"></param>
    ''' <param name="nn"></param>
    ''' <param name="KiemTra"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function InLuyKe_tonkho(ByRef mkho As Integer, ByRef shtk As String, ByRef mloai As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer, Optional ByRef T As Boolean = True, Optional ByRef loailk As Integer = 0, Optional ByRef nn As Integer = 0, Optional ByRef KiemTra As Boolean = True) As Boolean
        Dim sql, st As String
        Dim sqltx2 As New StringBuilder
        Dim sqltn2 As New StringBuilder
        Dim sqltx As New StringBuilder
        Dim sqltn As New StringBuilder
        Dim sqllx As New StringBuilder
        Dim sqlln As New StringBuilder
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            If sqlln.Length = 0 Then
                sqlln.Append(String.Format("TonKho.Luong_Nhap_{0}", i))
            Else
                sqlln.Append(String.Format(" + TonKho.Luong_Nhap_{0}", i))
            End If
            '---
            If sqllx.Length = 0 Then
                sqllx.Append(String.Format("TonKho.Luong_Xuat_{0}", i))
            Else
                sqllx.Append(String.Format(" + TonKho.Luong_Xuat_{0}", i))
            End If
            '---
            If sqltn.Length = 0 Then
                sqltn.Append(String.Format("TonKho.Tien_Nhap_{0}", i))
            Else
                sqltn.Append(String.Format(" + TonKho.Tien_Nhap_{0}", i))
            End If
            '---
            If sqltx.Length = 0 Then
                sqltx.Append(String.Format("TonKho.Tien_Xuat_{0}", i))
            Else
                sqltx.Append(String.Format(" + TonKho.Tien_Xuat_{0}", i))
            End If
            '---
            If sqltn2.Length = 0 Then
                sqltn2.Append(String.Format("TonKho.USDTien_Nhap_{0}", i))
            Else
                sqltn2.Append(String.Format(" + TonKho.USDTien_Nhap_{0}", i))
            End If
            '---
            If sqltx2.Length = 0 Then
                sqltx2.Append(String.Format("TonKho.USDTien_Xuat_{0}", i))
            Else
                sqltx2.Append(String.Format(" + TonKho.USDTien_Xuat_{0}", i))
            End If
        Next

        st = ConvertToStrSafe(CThangDB2(tcuoi))
        XDTyLeQD(0)
        If mkho > 0 Then
            sql = String.Format("SELECT DISTINCT (HeThongTK.SoHieu) AS SHTK, (HeThongTK.Ten{0}) AS TenTK, (PhanLoaiVattu.PLCha) AS PLCha3, (PhanLoaiVattu.SoHieu) AS SHPL3, (PhanLoaiVattu.TenPhanLoai) AS TenPL3, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, Sum(TonKho.Tien_{1}) AS DkTien, Sum(TonKho.Luong_{1}) AS DkLuong, Sum({2}) AS TienNhap, Sum({3}) AS LuongNhap, Sum({4}) AS TienXuat, Sum({5}) AS LuongXuat, Sum(TonKho.Luong_{6}) AS CkLuong, Sum(TonKho.Tien_{6}) AS CkTien{7} FROM HeThongTK RIGHT JOIN ((PhanLoaiVattu RIGHT JOIN Vattu ON PhanLoaiVattu.MaSo = Vattu.MaPhanLoai) RIGHT JOIN TonKho ON Vattu.MaSo = TonKho.MaVatTu) ON HeThongTK.MaSo = TonKho.MaTaiKhoan GROUP BY Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, HethongTK.SoHieu, Tonkho.MaSoKho, Hethongtk.ten{0},phanloaivattu.PLCha,PhanLoaiVattu.sohieu,PhanLoaiVattu.TenPhanLoai {8}{9} Having (Sum(TonKho.Luong_{6})<>0 OR Sum(TonKho.Tien_{6})<>0 OR SUM({3})<>0 OR SUM({2})<>0 OR SUM({5})<>0 OR SUM({4})<>0{10}{11}{12}{13} ", _
                      (IIf(pNN > 0, "E", String.Empty)), _
                      CThangDB2(ThangTruoc(tdau)), _
                      sqltn, _
                      sqlln, _
                      sqltx, _
                      sqllx, _
                      st, _
                      (IIf(pGiaUSD > 0, String.Format(", Sum(TonKho.USDTien_{0}) AS DkUSD, Sum({1}) AS TienNhapUSD, Sum({2}) AS TienXuatUSD, Sum(TonKho.USDTien_{3}) AS CkUSD", CThangDB2(ThangTruoc(tdau)), sqltn2, sqltx2, st), String.Empty)), _
                      String.Empty, _
                      String.Empty, _
                      (IIf(pGiaUSD > 0, String.Format(" OR Sum(TonKho.USDTien_{0})<>0 OR SUM({1})<>0 OR SUM({2})<>0)", st, sqltn2, sqltx2), ")")), _
                      (IIf(mkho <> 0, String.Format(" AND TonKho.MaSoKho = {0}", mkho), String.Empty)), _
                      (IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty)), _
                      (IIf(mloai <> 0, String.Format(" AND PhanLoaiVattu.SoHieu LIKE '{0}%'", MaSo2SoHieu(mloai, "PhanLoaiVattu")), String.Empty)))
            '(IIf(mkho > 0, ", TonKho.MaSoKho", String.Empty)), _
            '(IIf(mloai > 0, ", PhanLoaiVattu.SoHieu", String.Empty)), _
        Else
            ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
            ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (SoHieu,MaCha,BC_ID,MK,Kq1,Kq2) SELECT SoHieu,MaTKNo,MaVattu,MaKho,Sum(SoPS2No),Sum(SoPS) FROM ChungTu WHERE MaLoai=4 AND MaTKNo=MaTKCo AND {0} GROUP BY SoHieu,MaKho,MaTKNo,MaVattu", WThang("ThangCT", tdau, tcuoi)))
            sql = String.Format("SELECT DISTINCT (HeThongTK.SoHieu) AS SHTK, (HeThongTK.Ten{0}) AS TenTK, (PhanLoaiVattu.PLCha) AS PLCha3, (PhanLoaiVattu.SoHieu) AS SHPL3, (PhanLoaiVattu.TenPhanLoai) AS TenPL3, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, Sum(TonKho.Tien_{1}) AS DkTien, Sum(TonKho.Luong_{1}) AS DkLuong, Sum({2}- ISNULL(Kq2,0)) AS TienNhap, Sum({3}- (case when Kq1 is null then 0 else Kq1 end)) AS LuongNhap, Sum({4}-ISNULL(Kq2,0)) AS TienXuat, Sum({5}-ISNULL(Kq1,0)) AS LuongXuat, Sum(TonKho.Luong_{6}) AS CkLuong, Sum(TonKho.Tien_{6}) AS CkTien{7} FROM (HeThongTK RIGHT JOIN ((PhanLoaiVattu RIGHT JOIN Vattu ON PhanLoaiVattu.MaSo = Vattu.MaPhanLoai) RIGHT JOIN TonKho ON Vattu.MaSo = TonKho.MaVatTu) ON HeThongTK.MaSo = TonKho.MaTaiKhoan) LEFT JOIN BaoCaoCP2 ON TonKho.MaSoKho=BaoCaoCP2.MK AND TonKho.MaTaiKhoan=BaoCaoCP2.MaCha AND TonKho.MaVattu=BaoCaoCP2.BC_ID GROUP BY Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, HethongTK.SoHieu {8},PhanLoaiVattu.TenPhanLoai,PhanLoaiVattu.SoHieu,PhanLoaiVattu.PLCha,HeThongTK.Ten{0} Having Sum(TonKho.Luong_{6})<>0 OR Sum(TonKho.Tien_{6})<>0 OR SUM({3})<>0 OR SUM({2})<>0 OR SUM({5})<>0 OR SUM({4})<>0{9}{10}{11}", _
                      (IIf(pNN > 0, "E", String.Empty)), _
                      CThangDB2(ThangTruoc(tdau)), _
                      sqltn, _
                      sqlln, _
                      sqltx, _
                      sqllx, _
                      st, _
                      (IIf(pGiaUSD > 0, String.Format(", Sum(TonKho.USDTien_{0}) AS DkUSD, Sum({1}) AS TienNhapUSD, Sum({2}) AS TienXuatUSD, Sum(TonKho.USDTien_{3}) AS CkUSD", CThangDB2(ThangTruoc(tdau)), sqltn2, sqltx2, st), String.Empty)), _
                      (IIf(mloai > 0, ", PhanLoaiVattu.SoHieu", String.Empty)), _
                      (IIf(pGiaUSD > 0, String.Format(" OR Sum(TonKho.USDTien_{0})<>0 OR SUM({1})<>0 OR SUM({2})<>0", st, sqltn2, sqltx2), String.Empty)), _
                      (IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty)), _
                      (IIf(mloai <> 0, String.Format(" AND PhanLoaiVattu.SoHieu LIKE '{0}%'", MaSo2SoHieu(mloai, "PhanLoaiVattu")), String.Empty)))
        End If
        'SetSQL("QChitiet", sql)
        sql = String.Format("SELECT QChitiet.*,PhanLoaiVattu.SoHieu AS SHPL2,TenPhanLoai AS TenPL2,PhanLoaiVattu.PLCha AS PLCha2 FROM ({0}) AS QChitiet LEFT JOIN PhanLoaiVattu ON QChitiet.PLCha3=PhanLoaiVattu.MaSo", sql)
        sql = String.Format("SELECT QDuPhong.*,PhanLoaiVattu.SoHieu AS SHPL1,TenPhanLoai AS TenPL1 FROM ({0}) AS QDuPhong LEFT JOIN PhanLoaiVattu ON QDuPhong.PLCha2=PhanLoaiVattu.MaSo  ", sql)
        Dim QLuyKe As String = sql
        '************************************ Kiểm tra âm hàng **********************************************
        Dim rs As DataTable
        Dim str As String = String.Empty
        If KiemTra Then
            rs = ExecSQLReturnDT(String.Format("SELECT DISTINCT TB.dkluong,TB.ckluong,TB.sohieu FROM ({0}) as TB ORDER BY TB.sohieu", QLuyKe))
            Dim rsIndex As Integer = 0
            While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                If rsItem("dkluong") < 0 Or rsItem("ckluong") < 0 Then
                    str = String.Format("{0}, ", ConvertToDblSafe(str) + rsItem("SoHieu"))
                End If
            End While
            If str <> "" Then
                str = Strings.Left(str, str.Length - 2)
                MessageBox.Show(String.Format("Âm hàng tại vật tư có số hiệu {0}.", str), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        '************************************ Hết kiểm tra ****************************************************

        Dim rsData As DataTable = ExecSQLReturnDT(QLuyKe)
        If rsData.Rows.Count > 0 Then
            Chart_Doanhthu_chiphi.Series(0).Points.Clear()
            Dim rsIndex As Integer = 0
            While rsIndex < rsData.Rows.Count
                Dim rsItem As DataRow = rsData.Rows(rsIndex)
                Dim tn As Double = rsItem("TienNhap")
                Dim tx As Double = rsItem("TienXuat")
                Chart_Doanhthu_chiphi.Series("TienNhap").Points.AddXY(rsItem("TenVattu").ToString(), Format(tn, Mask_0))
                Chart_Doanhthu_chiphi.Series("TienXuat").Points.AddXY(rsItem("TenVattu").ToString(), Format(tx, Mask_0))

                rsIndex = rsIndex + 1
            End While
        End If

        Return True
    End Function

    Private Function kiemTraTonTaiProc(ByVal name As String) As Boolean
        Try
            Return ExecSQLReturnDT(String.Format("SELECT name FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('{0}')", name)).Rows.Count > 0
        Catch ex As Exception
            Return True
        End Try
    End Function

    Private Function taoProc() As Boolean
        Try
            Dim sql = My.Resources.sql.create_proce_Doanh_Thu_Chi_Phi
            Return ExecSQLNonQuery(sql)
        Catch ex As Exception
            Return True
        End Try
    End Function

    Private Function tong_pscp_psdt(ByRef tong_cp As Double, ByRef tong_dt As Double, ByVal dt As DataTable) As Double
        Dim res As Double = 0
        Try
            For i As Integer = 0 To dt.Rows.Count
                tong_cp = tong_cp + ConvertToDblSafe(dt.Rows(i)("pscp"))
                tong_dt = tong_dt + ConvertToDblSafe(dt.Rows(i)("psdt"))
            Next
        Catch ex As Exception
            res = 0
        End Try
        Return res
    End Function

    Private Sub doanhthu_chiphi()
        Try
            Me.LinkLabel_lammoi.Visible = False
            Me.Label_ThongBaoDuLieu.Text = "Đang tải dữ liệu ..."
            
            'kiem tra proc ton tai hay khong
            If Not kiemTraTonTaiProc("dbo.sp_danhsach_doanhthu_chiphi") Then
                taoProc()
            End If
            Dim rsData As DataTable = ExecSQLReturnDTByStoreProcedure("sp_danhsach_doanhthu_chiphi")
            Dim tong_cp As Double = 0
            Dim tong_dt As Double = 0
            tong_pscp_psdt(tong_cp, tong_dt, rsData)
            If rsData.Rows.Count > 0 And tong_cp <> 0 And tong_dt <> 0 Then
                Me.Label_ThongBaoDuLieu.Visible = False
                Me.Chart_Doanhthu_chiphi.Visible = True

                Chart_Doanhthu_chiphi.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
                Chart_Doanhthu_chiphi.ChartAreas(0).AxisY.Title = "Tiền"
                Chart_Doanhthu_chiphi.ChartAreas(0).AxisY.LabelStyle.Format = Mask_0
                Chart_Doanhthu_chiphi.ChartAreas(0).AxisX.Title = "Tháng"
                Chart_Doanhthu_chiphi.ChartAreas(0).AxisX.Interval = 1
                Chart_Doanhthu_chiphi.ChartAreas(0).AxisX.Maximum = 12
                Chart_Doanhthu_chiphi.ChartAreas(0).AxisX.Minimum = 1
                Chart_Doanhthu_chiphi.Series("PSDT").Points.Clear()
                Chart_Doanhthu_chiphi.Series("PSCP").Points.Clear()
                Dim rsIndex As Integer = 0
                While rsIndex < rsData.Rows.Count
                    Dim rsItem As DataRow = rsData.Rows(rsIndex)
                    Dim dt As Double = rsItem("psdt")
                    Dim cp As Double = rsItem("pscp")                    
                    Chart_Doanhthu_chiphi.Series("PSDT").Points.AddXY(rsItem("thang").ToString(), Format(dt, Mask_0))
                    Chart_Doanhthu_chiphi.Series("PSCP").Points.AddXY(rsItem("thang").ToString(), Format(cp, Mask_0))
                    Thread.Sleep(100)
                    rsIndex = rsIndex + 1
                End While
                Me.LinkLabel_lammoi.Visible = True
            Else
                Me.Label_ThongBaoDuLieu.Text = "Không có dữ liệu thống kê."
                Me.Label_ThongBaoDuLieu.Visible = True
                Me.LinkLabel_lammoi.Visible = True
                Me.Chart_Doanhthu_chiphi.Visible = False
            End If
        Catch ex As Exception
            Me.Label_ThongBaoDuLieu.Text = "Không có dữ liệu thống kê."
            Me.Label_ThongBaoDuLieu.Visible = True
            Me.LinkLabel_lammoi.Visible = True
            Me.Chart_Doanhthu_chiphi.Visible = False
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub uThongKe_doanhthu_chiphi_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            tientrinh.Abort()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub uThongKe_doanhthu_chiphi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Cursor = Cursors.WaitCursor
        Try
            Me.DoubleBuffered = True

            Me.Label_ThongBaoDuLieu.Visible = True
            Me.Chart_Doanhthu_chiphi.Visible = False

            'Control.CheckForIllegalCrossThreadCalls = False
            'tientrinh = New Thread(AddressOf doanhthu_chiphi)
            'tientrinh.Start()
            doanhthu_chiphi()

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Label_ThongBaoDuLieu.Text = "Lỗi tải dữ liệu !"
            Me.Label_ThongBaoDuLieu.ForeColor = Color.Red
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel_lammoi_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_lammoi.LinkClicked
        Me.Cursor = Cursors.WaitCursor
        Try
            Me.Label_ThongBaoDuLieu.Visible = True
            Me.Chart_Doanhthu_chiphi.Visible = False
            Me.LinkLabel_lammoi.Visible = False

            'Control.CheckForIllegalCrossThreadCalls = False
            'tientrinh = New Thread(AddressOf doanhthu_chiphi)
            'tientrinh.Start()
            doanhthu_chiphi()

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
