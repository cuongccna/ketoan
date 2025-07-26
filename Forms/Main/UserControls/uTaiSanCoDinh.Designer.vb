<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uTaiSanCoDinh
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Tài sản đầu kỳ", 4)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Nhập tăng tài sản", 8)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Giảm tài sản", 9)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Đánh giá lại tài sản", 0)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Khấu hao", 3)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Tra cứu chứng từ tài sản", 11)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Sổ tài sản", 7)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Phân loại tài sản", 6)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Sửa giá trị tài sản", 2)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Nước sản xuất", 5)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Tình trạng sử dụng", 10)
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Đối tượng quản lý", 1)
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Tài khoản chi phí ...", 12)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uTaiSanCoDinh))
        Me.ListView_taisancodinh = New System.Windows.Forms.ListView
        Me.Label1 = New System.Windows.Forms.Label
        Me.ImageList_taisan = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'ListView_taisancodinh
        '
        Me.ListView_taisancodinh.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView_taisancodinh.BackColor = System.Drawing.Color.AliceBlue
        Me.ListView_taisancodinh.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup1.Header = ""
        ListViewGroup1.Name = "gChucNang"
        ListViewGroup2.Header = ""
        ListViewGroup2.Name = "gBaoCao"
        ListViewGroup3.Header = ""
        ListViewGroup3.Name = "gDanhMuc"
        Me.ListView_taisancodinh.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        Me.ListView_taisancodinh.HotTracking = True
        Me.ListView_taisancodinh.HoverSelection = True
        ListViewItem1.Group = ListViewGroup1
        ListViewItem1.Tag = "tag_TaiSanDauKy"
        ListViewItem2.Group = ListViewGroup1
        ListViewItem2.Tag = "tag_NhapTangTaiSan"
        ListViewItem3.Group = ListViewGroup1
        ListViewItem3.Tag = "tag_GiamTaiSan"
        ListViewItem4.Group = ListViewGroup1
        ListViewItem4.Tag = "tag_DanhGiaLaiTaiSan"
        ListViewItem5.Group = ListViewGroup1
        ListViewItem5.Tag = "tag_KhauHao"
        ListViewItem6.Group = ListViewGroup1
        ListViewItem6.Tag = "tag_TraCuuCTTaiSan"
        ListViewItem7.Group = ListViewGroup2
        ListViewItem7.Tag = "tag_SoTaiSan"
        ListViewItem8.Group = ListViewGroup3
        ListViewItem8.Tag = "tag_PhanLoaiTaiSan"
        ListViewItem9.Group = ListViewGroup3
        ListViewItem9.Tag = "tag_SuaGiatriTaiSan"
        ListViewItem10.Group = ListViewGroup3
        ListViewItem10.Tag = "tag_NuocSanXuat"
        ListViewItem11.Group = ListViewGroup3
        ListViewItem11.Tag = "tag_TinhTrangSuDung"
        ListViewItem12.Group = ListViewGroup3
        ListViewItem12.Tag = "tag_DoiTuongQuanLy"
        ListViewItem13.Group = ListViewGroup3
        ListViewItem13.Tag = "tag_TaiKhoanChiPhi"
        Me.ListView_taisancodinh.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13})
        Me.ListView_taisancodinh.LargeImageList = Me.ImageList_taisan
        Me.ListView_taisancodinh.Location = New System.Drawing.Point(0, 23)
        Me.ListView_taisancodinh.MultiSelect = False
        Me.ListView_taisancodinh.Name = "ListView_taisancodinh"
        Me.ListView_taisancodinh.Size = New System.Drawing.Size(216, 484)
        Me.ListView_taisancodinh.TabIndex = 0
        Me.ListView_taisancodinh.UseCompatibleStateImageBehavior = False
        Me.ListView_taisancodinh.View = System.Windows.Forms.View.Tile
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TÀI SẢN CỐ ĐỊNH"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageList_taisan
        '
        Me.ImageList_taisan.ImageStream = CType(resources.GetObject("ImageList_taisan.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_taisan.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_taisan.Images.SetKeyName(0, "danhgialaitaisan-23.png")
        Me.ImageList_taisan.Images.SetKeyName(1, "doituongquanly-23.png")
        Me.ImageList_taisan.Images.SetKeyName(2, "giamtaisan-23.png")
        Me.ImageList_taisan.Images.SetKeyName(3, "khauhaotaisan-23.png")
        Me.ImageList_taisan.Images.SetKeyName(4, "nhaptangtaisan-23.png")
        Me.ImageList_taisan.Images.SetKeyName(5, "nuocsanxuat-23.png")
        Me.ImageList_taisan.Images.SetKeyName(6, "phanloaitaisan-23.png")
        Me.ImageList_taisan.Images.SetKeyName(7, "sochitiettaisan-23.png")
        Me.ImageList_taisan.Images.SetKeyName(8, "suagiatritaisan-23.png")
        Me.ImageList_taisan.Images.SetKeyName(9, "taisandauky-23.png")
        Me.ImageList_taisan.Images.SetKeyName(10, "tinhtrangsudung-23.png")
        Me.ImageList_taisan.Images.SetKeyName(11, "timkiemphieuthuchi-23.png")
        Me.ImageList_taisan.Images.SetKeyName(12, "danhsachvattu-23.png")
        '
        'uTaiSanCoDinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListView_taisancodinh)
        Me.Controls.Add(Me.Label1)
        Me.Name = "uTaiSanCoDinh"
        Me.Size = New System.Drawing.Size(216, 507)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView_taisancodinh As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList_taisan As System.Windows.Forms.ImageList

End Class
