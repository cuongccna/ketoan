<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uVatTuHangHoa
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Vật tư đầu kỳ", 16)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Mua hàng trong nước", 0)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Nhập nội địa", 11)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Nhập khẩu", 11)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Bán hàng", 13)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Phiếu xuất", 15)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Lưu chuyển nội bộ", 10)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Lập bảng kê bán lẻ", 5)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Báo cáo chi tiết", 1)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Danh sách vật tư", 9)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Phân loại vật tư", 7)
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Kênh phân phối", 14)
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Danh sách kho", 2)
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Chi tiết TK VT", 3)
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Dự phòng giảm giá", 4)
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Chi tiết TK DT", 3)
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Hợp đồng nhập khẩu", 6)
        Dim ListViewItem18 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Hóa đơn nội địa", 5)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uVatTuHangHoa))
        Me.ListView_VatTuHangHoa = New System.Windows.Forms.ListView
        Me.ImageList_vattuhanghoa = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ListView_VatTuHangHoa
        '
        Me.ListView_VatTuHangHoa.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView_VatTuHangHoa.BackColor = System.Drawing.Color.AliceBlue
        Me.ListView_VatTuHangHoa.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup1.Header = ""
        ListViewGroup1.Name = "gChucNang"
        ListViewGroup2.Header = ""
        ListViewGroup2.Name = "gDanhMuc"
        ListViewGroup3.Header = ""
        ListViewGroup3.Name = "gBaoCao"
        Me.ListView_VatTuHangHoa.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        Me.ListView_VatTuHangHoa.HotTracking = True
        Me.ListView_VatTuHangHoa.HoverSelection = True
        ListViewItem1.Group = ListViewGroup1
        ListViewItem1.Tag = "tag_VatTuDauKy"
        ListViewItem1.ToolTipText = "Vật tư đầu kỳ"
        ListViewItem2.Group = ListViewGroup1
        ListViewItem2.Tag = "tag_MuaHangTrongNuoc"
        ListViewItem3.Group = ListViewGroup1
        ListViewItem3.Tag = "tag_NhapNoiDia"
        ListViewItem4.Group = ListViewGroup1
        ListViewItem4.Tag = "tag_NhapKhau"
        ListViewItem5.Group = ListViewGroup1
        ListViewItem5.Tag = "tag_BanHang"
        ListViewItem6.Group = ListViewGroup1
        ListViewItem6.Tag = "tag_PhieuXuat"
        ListViewItem7.Group = ListViewGroup1
        ListViewItem7.Tag = "tag_LuuChuyenNoiBo"
        ListViewItem8.Group = ListViewGroup1
        ListViewItem8.Tag = "tag_LapBangKeBanLe"
        ListViewItem9.Group = ListViewGroup3
        ListViewItem9.Tag = "tag_BaoCaoChiTiet"
        ListViewItem10.Group = ListViewGroup2
        ListViewItem10.Tag = "tag_DanhSachVatTu"
        ListViewItem11.Group = ListViewGroup2
        ListViewItem11.Tag = "tag_PhanLoaiVatTu"
        ListViewItem12.Group = ListViewGroup2
        ListViewItem12.Tag = "tag_KenhPhanPhoi"
        ListViewItem13.Group = ListViewGroup2
        ListViewItem13.Tag = "tag_DanhSachKho"
        ListViewItem14.Group = ListViewGroup2
        ListViewItem14.Tag = "tag_ChiTietTKVT"
        ListViewItem15.Group = ListViewGroup2
        ListViewItem15.Tag = "tag_DuPhongGiamGia"
        ListViewItem16.Group = ListViewGroup2
        ListViewItem16.Tag = "tag_ChiTietTKDT"
        ListViewItem17.Group = ListViewGroup2
        ListViewItem17.Tag = "tag_HopDongNhapKhau"
        ListViewItem18.Group = ListViewGroup2
        ListViewItem18.Tag = "tag_HoaDonNoiDia"
        ListViewItem18.ToolTipText = "Hóa đơn nội địa"
        Me.ListView_VatTuHangHoa.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14, ListViewItem15, ListViewItem16, ListViewItem17, ListViewItem18})
        Me.ListView_VatTuHangHoa.LabelWrap = False
        Me.ListView_VatTuHangHoa.LargeImageList = Me.ImageList_vattuhanghoa
        Me.ListView_VatTuHangHoa.Location = New System.Drawing.Point(0, 23)
        Me.ListView_VatTuHangHoa.MultiSelect = False
        Me.ListView_VatTuHangHoa.Name = "ListView_VatTuHangHoa"
        Me.ListView_VatTuHangHoa.Size = New System.Drawing.Size(217, 649)
        Me.ListView_VatTuHangHoa.SmallImageList = Me.ImageList_vattuhanghoa
        Me.ListView_VatTuHangHoa.TabIndex = 0
        Me.ListView_VatTuHangHoa.UseCompatibleStateImageBehavior = False
        Me.ListView_VatTuHangHoa.View = System.Windows.Forms.View.Tile
        '
        'ImageList_vattuhanghoa
        '
        Me.ImageList_vattuhanghoa.ImageStream = CType(resources.GetObject("ImageList_vattuhanghoa.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_vattuhanghoa.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_vattuhanghoa.Images.SetKeyName(0, "banhang-23.png")
        Me.ImageList_vattuhanghoa.Images.SetKeyName(1, "baocaochitiet-23.png")
        Me.ImageList_vattuhanghoa.Images.SetKeyName(2, "chitiettkvt-23.png")
        Me.ImageList_vattuhanghoa.Images.SetKeyName(3, "danhsachvattu-23.png")
        Me.ImageList_vattuhanghoa.Images.SetKeyName(4, "duphonggiamgia-23.png")
        Me.ImageList_vattuhanghoa.Images.SetKeyName(5, "hoadonnoidia-23.png")
        Me.ImageList_vattuhanghoa.Images.SetKeyName(6, "hopdongnhapkhau-23.png")
        Me.ImageList_vattuhanghoa.Images.SetKeyName(7, "kenhphanphoi-23.png")
        Me.ImageList_vattuhanghoa.Images.SetKeyName(8, "khohang-23.png")
        Me.ImageList_vattuhanghoa.Images.SetKeyName(9, "lapbangkebanle-23.png")
        Me.ImageList_vattuhanghoa.Images.SetKeyName(10, "luuchuyennoibo-23.png")
        Me.ImageList_vattuhanghoa.Images.SetKeyName(11, "muahang-23.png")
        Me.ImageList_vattuhanghoa.Images.SetKeyName(12, "nhaphang-23.png")
        Me.ImageList_vattuhanghoa.Images.SetKeyName(13, "nhapkhau-23.png")
        Me.ImageList_vattuhanghoa.Images.SetKeyName(14, "phanloaivattu-23.png")
        Me.ImageList_vattuhanghoa.Images.SetKeyName(15, "phieuxuat-23.png")
        Me.ImageList_vattuhanghoa.Images.SetKeyName(16, "vattudauky-23.png")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "VẬT TƯ HÀNG HÓA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uVatTuHangHoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListView_VatTuHangHoa)
        Me.Controls.Add(Me.Label1)
        Me.Name = "uVatTuHangHoa"
        Me.Size = New System.Drawing.Size(217, 672)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView_VatTuHangHoa As System.Windows.Forms.ListView
    Friend WithEvents ImageList_vattuhanghoa As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
