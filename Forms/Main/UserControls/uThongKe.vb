Imports System.Threading

Public Class uThongKe

    Dim udoanhthusp As New uThongKe_DoanhThuSanPham()

    Private Sub addControlDoanhThuSanPham()
        Try
            addDoanhThuSanPham()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Delegate Sub startDoanhThuSanPham(ByVal dtsp_control As Control)

    ' them control thong ke doanh thu san pham
    Private Sub addDoanhThuSanPham()
        Try
            If (Me.InvokeRequired) Then
                Me.Invoke(New startDoanhThuSanPham(AddressOf Me.addDoanhThuSanPham), New Object() {udoanhthusp})
            Else
                SplitContainer_top.Panel1.Controls.Clear()
                udoanhthusp.Dock = DockStyle.Fill
                SplitContainer_top.Panel1.Controls.Add(udoanhthusp)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ' them control thong ke doanh thu chi phi
    Private Sub addDoanhThuChiPhi()
        Try
            If (Me.InvokeRequired) Then
                Me.Invoke(New MethodInvoker(AddressOf Me.addDoanhThuChiPhi))
            Else
                SplitContainer_top.Panel2.Controls.Clear()
                Dim udoanhthucp As New uThongKe_doanhthu_chiphi
                udoanhthucp.Dock = DockStyle.Fill
                SplitContainer_top.Panel2.Controls.Add(udoanhthucp)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


    Private Sub uThongKe_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Cursor = Cursors.WaitCursor
        Try
            ' them so du tai khoan
            SplitContainer_bottom.Panel1.Controls.Clear()
            Dim uSoDuTaiKhoan As New uThongKe_SoDuTaiKhoan()
            uSoDuTaiKhoan.Dock = DockStyle.Fill
            SplitContainer_bottom.Panel1.Controls.Add(uSoDuTaiKhoan)

            ' them doanh thu san pham

            SplitContainer_top.Panel1.Controls.Clear()
            Dim udoanhthusp As New uThongKe_DoanhThuSanPham()
            udoanhthusp.Dock = DockStyle.Fill
            SplitContainer_top.Panel1.Controls.Add(udoanhthusp)

            'Dim thr_doanhthusanpham As New Thread(AddressOf addControlDoanhThuSanPham)
            'thr_doanhthusanpham.IsBackground = True
            'thr_doanhthusanpham.Start()

            ' doanh thu chi phi

            SplitContainer_top.Panel2.Controls.Clear()
            Dim udoanhthucp As New uThongKe_doanhthu_chiphi
            udoanhthucp.Dock = DockStyle.Fill
            SplitContainer_top.Panel2.Controls.Add(udoanhthucp)

            'Dim thr_doanhthuchiphi As New Threading.Thread(AddressOf addDoanhThuChiPhi)
            'thr_doanhthuchiphi.IsBackground = True
            'thr_doanhthuchiphi.Start()

            ' so lieu tong hop

            SplitContainer_SoLieuTongHop.Panel1.Controls.Clear()
            Dim usolieutonghop As New uThongKe_SoLieuTongHop
            usolieutonghop.Dock = DockStyle.Fill
            SplitContainer_SoLieuTongHop.Panel1.Controls.Add(usolieutonghop)


            ' ket qua kinh doanh

            SplitContainer_SoLieuTongHop.Panel2.Controls.Clear()
            Dim uketquakinhdoanh As New uThongKe_KetQuaKinhDoanh
            uketquakinhdoanh.Dock = DockStyle.Fill
            SplitContainer_SoLieuTongHop.Panel2.Controls.Add(uketquakinhdoanh)

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
End Class
