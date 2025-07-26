Imports UNET.DataAdapter
Imports UNET.Utilities
Imports UNET.Utility
Imports System.Threading

Public Class uThongKe_DoanhThuSanPham

    Private Delegate Sub InTHDoanhThu_ThongKe2CallBack()

    Dim tientrinh As Thread

    Private Sub InTHDoanhThu_ThongKe(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef loai As Integer, ByRef mkho As Integer, ByRef shkh As String, ByRef mnv As Integer, ByRef MN As Integer, Optional ByRef shtk As String = "")

        Me.Cursor = Cursors.WaitCursor
        Try
            Dim wsql As String, sql As String, QChitiet As String, QDuPhong As String, QLuyKe As String
            wsql = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
            ExecSQLNonQuery("DELETE  FROM BaoCaoCP")
            sql = String.Format("INSERT INTO BaoCaoCP (MaSo,SoHieu,MaCha) SELECT ChungTu.MaSo,ChungTu.MaSo,MaCT FROM {0} WHERE (TK_ID={1}) AND {2}{3}{4} GROUP BY ChungTu.MaSo, MaCT", _
                                ChungTu2TKNC(1), _
                                ConvertToStrSafe(TKDT_ID), _
                                wsql, _
                                IIf(mkho > 0, String.Format(" AND MaKho={0}", mkho), String.Empty), _
                                IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty))
            ExecSQLNonQuery(sql)
            ExecSQLNonQuery("UPDATE BaoCaoCP set BC_ID=(select max(makh) from ChungTu where BaoCaoCP.MaCha=ChungTu.MaCT and MaKH>0)")
            sql = String.Format("UPDATE BaoCaoCP set bc_id= (select max(makhachhang) from {0} where BaoCaoCP.MaCha=ChungTu.MaCT) where (BC_ID=0 or BC_ID is null)", ChungTu2TKHD(0))
            ExecSQLNonQuery(sql)
            sql = String.Format("SELECT DISTINCT Sum(ChungTu.SoPS) AS Tien, Sum(ChungTu.SoPS2Co) AS Luong, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, (KhachHang.SoHieu) AS SHKH,(KhachHang.Ten) AS Ten, (PhanLoaiVattu.PLCha) AS PLCha3, (PhanLoaiVattu.SoHieu) AS SHPL3, (PhanLoaiVattu.TenPhanLoai) AS TenPL3 FROM ((ChungTu LEFT JOIN (PhanLoaiVattu RIGHT JOIN Vattu ON PhanLoaiVattu.MaSo = Vattu.MaPhanLoai) ON ChungTu.MaVattu = Vattu.MaSo) INNER JOIN BaoCaoCP ON ChungTu.MaSo=BaoCaoCP.MaSo) LEFT JOIN KhachHang ON BaoCaoCP.BC_ID=KhachHang.MaSo WHERE (1=1) {0}{1}{2} GROUP BY {3}Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi,KhachHang.SoHieu,KhachHang.Ten,PhanLoaiVattu.PLCha,PhanLoaiVattu.SoHieu,PhanLoaiVattu.TenPhanLoai", (IIf(mnv > 0, "AND ChungTu.MaNV=" & mnv, String.Empty)), (IIf(MN > 0, "AND ChungTu.MaNguon=" & MN, String.Empty)), (IIf(shkh.Length > 0, "AND KhachHang.SoHieu='" & shkh & "'", String.Empty)), (IIf(loai <> 0, "KhachHang.SoHieu,KhachHang.Ten,", String.Empty)))
            QChitiet = sql
            sql = String.Format("SELECT QChitiet.*,PhanLoaiVattu.SoHieu AS SHPL2,TenPhanLoai AS TenPL2,PhanLoaiVattu.PLCha AS PLCha2 FROM ({0}) AS QChitiet LEFT JOIN PhanLoaiVattu ON QChitiet.PLCha3=PhanLoaiVattu.MaSo", QChitiet)
            QDuPhong = sql
            sql = String.Format("SELECT QDuPhong.*,PhanLoaiVattu.SoHieu AS SHPL1,TenPhanLoai AS TenPL1 FROM ({0}) As QDuPhong LEFT JOIN PhanLoaiVattu ON QDuPhong.PLCha2=PhanLoaiVattu.MaSo ORDER BY QDuPhong.Sohieu", QDuPhong)
            QLuyKe = sql

            If loai = 0 Then
                'rptFrom.InitForm("THDT1.RPT", QLuyKe, "QLuyKe")
            Else
                If shkh.Length > 0 Then
                    QLuyKe = (String.Format("SELECT * FROM " & QLuyKe & " WHERE SHKH =N'{0}'", shkh))
                End If
                'rptFrom.InitForm("THDT2.RPT", QLuyKe, "QLuyKe")
            End If

            Dim rsData As DataTable = ExecSQLReturnDT(QLuyKe)
            If rsData.Rows.Count > 0 Then
                Chart1.Series(0).Points.Clear()
                Dim rsIndex As Integer = 0
                While rsIndex < rsData.Rows.Count
                    Dim rsItem As DataRow = rsData.Rows(rsIndex)
                    Dim t As Double = rsItem("Tien")
                    Chart1.Series("DoanhThuSanPham").Points.Add(t).Label = rsItem("TenVattu").ToString() & " | (#PERCENT)"
                    'Chart1.Series("DoanhThuSanPham").Label = 

                    rsIndex = rsIndex + 1
                End While
            End If


            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    ' ham toi uu ten vat tu de hien thi tren bieu do
    Private Function ToiUuTenVatTu(ByVal ten As String) As String
        Dim res As String = String.Empty
        Try
            If ten.Length > 14 Then
                Dim l As String() = ten.Split(New Char() {" "c})
                Dim cd As Integer = 0
                For i As Integer = 0 To l.Length - 1
                    cd = cd + l(i).Length + 1
                    If cd <= 14 Then
                        res = res + " "c + l(i)
                    Else
                        res = res + "..." + l.Last()
                        Exit For
                    End If
                Next
            Else
                res = ten
            End If
        Catch ex As Exception
            res = ten
            'Throw New Exception(ex.Message)
        End Try
        Return res
    End Function

    Private Sub InTHDoanhThu_ThongKe1()

        Me.Cursor = Cursors.WaitCursor
        Try
            Me.LinkLabel_LamMoi.Visible = False
            Me.Label_ThongBaoKhongCoDuLieu.Text = "Đang tải dữ liệu ..."
            'kiem tra proc ton tai hay khong
            If Not kiemTraTonTaiProc("dbo.sp_thongke_doanhthusanpham") Then
                taoProc()
            End If
            Dim rsData As DataTable = ExecSQLReturnDTByStoreProcedure("sp_thongke_doanhthusanpham", New String() {"@TKDT_ID"}, New String() {ConvertToStrSafe(TKDT_ID)}) 'ExecSQLReturnDT(QLuyKe)
            If rsData.Rows.Count > 0 Then
                Me.Label_ThongBaoKhongCoDuLieu.Visible = False
                Me.Chart1.Visible = True
                Chart1.Series(0).Points.Clear()
                Dim rsIndex As Integer = 0
                While rsIndex < rsData.Rows.Count
                    Dim rsItem As DataRow = rsData.Rows(rsIndex)
                    Dim t As Double = rsItem("Tien")
                    Dim t1 As System.Windows.Forms.DataVisualization.Charting.DataPoint
                    t1 = Chart1.Series("DoanhThuSanPham").Points.Add(t) '.Label = "#PERCENT" 'rsItem("TenVattu").ToString() &
                    t1.LegendText = ToiUuTenVatTu(rsItem("TenVattu").ToString())
                    t1.Label = "#PERCENT"
                    Thread.Sleep(100)
                    rsIndex = rsIndex + 1
                End While
                Me.Label_ThongBaoKhongCoDuLieu.Visible = False
                Me.LinkLabel_LamMoi.Visible = True
                Me.Chart1.Visible = True
            Else
                Me.Label_ThongBaoKhongCoDuLieu.Text = "Không có dữ liệu thống kê."
                Me.Label_ThongBaoKhongCoDuLieu.Visible = True
                Me.LinkLabel_LamMoi.Visible = True
                Me.Chart1.Visible = False
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InTHDoanhThu_ThongKe2()

        Me.Cursor = Cursors.WaitCursor
        Try
            If LinkLabel_LamMoi.InvokeRequired Or Label_ThongBaoKhongCoDuLieu.InvokeRequired Or Chart1.InvokeRequired Then
                'Me.Invoke(New 
            Else
                Me.LinkLabel_LamMoi.Visible = False
                Me.Label_ThongBaoKhongCoDuLieu.Text = "Đang tải dữ liệu ..."
                'kiem tra proc ton tai hay khong
                If Not kiemTraTonTaiProc("dbo.sp_thongke_doanhthusanpham") Then
                    taoProc()
                End If
                Dim rsData As DataTable = ExecSQLReturnDTByStoreProcedure("sp_thongke_doanhthusanpham", New String() {"@TKDT_ID"}, New String() {ConvertToStrSafe(TKDT_ID)}) 'ExecSQLReturnDT(QLuyKe)
                If rsData.Rows.Count > 0 Then
                    Me.Label_ThongBaoKhongCoDuLieu.Visible = False
                    Me.Chart1.Visible = True
                    Chart1.Series(0).Points.Clear()
                    Dim rsIndex As Integer = 0
                    While rsIndex < rsData.Rows.Count
                        Dim rsItem As DataRow = rsData.Rows(rsIndex)
                        Dim t As Double = rsItem("Tien")
                        Dim t1 As System.Windows.Forms.DataVisualization.Charting.DataPoint
                        t1 = Chart1.Series("DoanhThuSanPham").Points.Add(t) '.Label = "#PERCENT" 'rsItem("TenVattu").ToString() &
                        t1.LegendText = ToiUuTenVatTu(rsItem("TenVattu").ToString())
                        t1.Label = "#PERCENT"
                        Thread.Sleep(100)
                        rsIndex = rsIndex + 1
                    End While
                    Me.Label_ThongBaoKhongCoDuLieu.Visible = False
                    Me.LinkLabel_LamMoi.Visible = True
                    Me.Chart1.Visible = True
                Else
                    Me.Label_ThongBaoKhongCoDuLieu.Text = "Không có dữ liệu thống kê."
                    Me.Label_ThongBaoKhongCoDuLieu.Visible = True
                    Me.LinkLabel_LamMoi.Visible = True
                    Me.Chart1.Visible = False
                End If
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function kiemTraTonTaiProc(ByVal name As String) As Boolean
        Try
            Return ExecSQLReturnDT(String.Format("SELECT name FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('{0}')", name)).Rows.Count > 0
        Catch ex As Exception
            Return True
        End Try
    End Function

    Private Function taoProc() As Boolean
        Try
            Dim sql = My.Resources.sql.create_proce_doanh_thu_san_Pham
            Return ExecSQLNonQuery(sql)
        Catch ex As Exception
            Return True
        End Try
    End Function

    Private Sub uThongKe_DoanhThuSanPham_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            tientrinh.Abort()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub uThongKe_DoanhThuSanPham_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Cursor = Cursors.WaitCursor
        Try
            Me.Label_ThongBaoKhongCoDuLieu.Visible = True
            Me.Chart1.Visible = False

            'Control.CheckForIllegalCrossThreadCalls = False
            'tientrinh = New Thread(AddressOf InTHDoanhThu_ThongKe1)
            'tientrinh.Start()
            InTHDoanhThu_ThongKe1()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Label_ThongBaoKhongCoDuLieu.Text = "Lỗi tải dữ liệu !"
            Me.Label_ThongBaoKhongCoDuLieu.ForeColor = Color.Red
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel_LamMoi_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_LamMoi.LinkClicked
        Me.Cursor = Cursors.WaitCursor
        Try
            Me.Label_ThongBaoKhongCoDuLieu.Visible = True
            Me.Chart1.Visible = False

            'tientrinh = New Thread(AddressOf InTHDoanhThu_ThongKe1)
            'tientrinh.Start()
            InTHDoanhThu_ThongKe1()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Label_ThongBaoKhongCoDuLieu.Text = "Lỗi tải dữ liệu !"
            Me.Label_ThongBaoKhongCoDuLieu.ForeColor = Color.Red
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
