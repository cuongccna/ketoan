<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uThaoTacNhanh
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Đầu Kỳ", System.Windows.Forms.HorizontalAlignment.Center)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Nhập Chứng Từ", System.Windows.Forms.HorizontalAlignment.Center)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Báo Cáo Chi Tiết", System.Windows.Forms.HorizontalAlignment.Center)
        Dim ListViewGroup4 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Báo Cáo Tổng Hợp", System.Windows.Forms.HorizontalAlignment.Center)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Bán Hàng", 0)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Nhập Vật Tư", 1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Xuất Vật Tư", 2)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Thu nợ", 12)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Trả nợ", 13)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Nhập Chi Phí Tổng Hợp", 6)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Vật Tư Hàng Hóa", 7)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Công Nợ", 8)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Giá Thành", 9)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Tài Sản Cố Định", 10)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Công Cụ Dụng Cụ", 11)
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Chi Phí Tổng Hợp", 11)
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Báo Cáo Tổng Hợp", 8)
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Vật tư đầu kỳ", 14)
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Công nợ đầu kỳ", 15)
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Tài sản đầu kỳ", 16)
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Công cụ đầu kỳ", 17)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uThaoTacNhanh))
        Me.ListView_ThaoTacNhanh = New System.Windows.Forms.ListView
        Me.ImageList_thaotacnhanh = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'ListView_ThaoTacNhanh
        '
        Me.ListView_ThaoTacNhanh.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView_ThaoTacNhanh.BackColor = System.Drawing.Color.AliceBlue
        Me.ListView_ThaoTacNhanh.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup1.Header = "Đầu Kỳ"
        ListViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup1.Name = "gDauKy"
        ListViewGroup2.Header = "Nhập Chứng Từ"
        ListViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup2.Name = "gNhapChungTu"
        ListViewGroup3.Header = "Báo Cáo Chi Tiết"
        ListViewGroup3.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup3.Name = "gBaoCaoChiTiet"
        ListViewGroup4.Header = "Báo Cáo Tổng Hợp"
        ListViewGroup4.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup4.Name = "gBaoCaoTongHop"
        Me.ListView_ThaoTacNhanh.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3, ListViewGroup4})
        Me.ListView_ThaoTacNhanh.HotTracking = True
        Me.ListView_ThaoTacNhanh.HoverSelection = True
        ListViewItem1.Group = ListViewGroup2
        ListViewItem1.Tag = "tag_ttn_banhang"
        ListViewItem2.Group = ListViewGroup2
        ListViewItem2.Tag = "tag_ttn_nhapvattu"
        ListViewItem3.Group = ListViewGroup2
        ListViewItem3.Tag = "tag_ttn_xuatvattu"
        ListViewItem4.Group = ListViewGroup2
        ListViewItem4.Tag = "tag_ttn_thuno"
        ListViewItem5.Group = ListViewGroup2
        ListViewItem5.Tag = "tag_ttn_trano"
        ListViewItem6.Group = ListViewGroup2
        ListViewItem6.Tag = "tag_ttn_nhapchiphitonghop"
        ListViewItem7.Group = ListViewGroup3
        ListViewItem7.Tag = "tag_ttn_vattuhanghoa"
        ListViewItem8.Group = ListViewGroup3
        ListViewItem8.Tag = "tag_ttn_congno"
        ListViewItem9.Group = ListViewGroup3
        ListViewItem9.Tag = "tag_ttn_giathanh"
        ListViewItem10.Group = ListViewGroup3
        ListViewItem10.Tag = "tag_ttn_taisancodinh"
        ListViewItem11.Group = ListViewGroup3
        ListViewItem11.Tag = "tag_ttn_congcudungcu"
        ListViewItem12.Group = ListViewGroup3
        ListViewItem12.Tag = "tag_ttn_chiphitonghop"
        ListViewItem13.Group = ListViewGroup4
        ListViewItem13.Tag = "tag_ttn_baocaotonghop"
        ListViewItem14.Group = ListViewGroup1
        ListViewItem14.Tag = "tag_vattudauky"
        ListViewItem15.Group = ListViewGroup1
        ListViewItem15.Tag = "tag_congnodauky"
        ListViewItem16.Group = ListViewGroup1
        ListViewItem16.Tag = "tag_taisandauky"
        ListViewItem17.Group = ListViewGroup1
        ListViewItem17.Tag = "tag_congcudauky"
        Me.ListView_ThaoTacNhanh.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14, ListViewItem15, ListViewItem16, ListViewItem17})
        Me.ListView_ThaoTacNhanh.LargeImageList = Me.ImageList_thaotacnhanh
        Me.ListView_ThaoTacNhanh.Location = New System.Drawing.Point(0, 0)
        Me.ListView_ThaoTacNhanh.MultiSelect = False
        Me.ListView_ThaoTacNhanh.Name = "ListView_ThaoTacNhanh"
        Me.ListView_ThaoTacNhanh.Size = New System.Drawing.Size(262, 503)
        Me.ListView_ThaoTacNhanh.TabIndex = 62
        Me.ListView_ThaoTacNhanh.UseCompatibleStateImageBehavior = False
        Me.ListView_ThaoTacNhanh.View = System.Windows.Forms.View.Tile
        '
        'ImageList_thaotacnhanh
        '
        Me.ImageList_thaotacnhanh.ImageStream = CType(resources.GetObject("ImageList_thaotacnhanh.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_thaotacnhanh.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_thaotacnhanh.Images.SetKeyName(0, "banhang-23.png")
        Me.ImageList_thaotacnhanh.Images.SetKeyName(1, "nhaphang-23.png")
        Me.ImageList_thaotacnhanh.Images.SetKeyName(2, "nhapkhau-23.png")
        Me.ImageList_thaotacnhanh.Images.SetKeyName(3, "danhgialaitaisan-23.png")
        Me.ImageList_thaotacnhanh.Images.SetKeyName(4, "suagiatritaisan-23.png")
        Me.ImageList_thaotacnhanh.Images.SetKeyName(5, "khauhaotaisan-23.png")
        Me.ImageList_thaotacnhanh.Images.SetKeyName(6, "nhapchungtutonghop-23.png")
        Me.ImageList_thaotacnhanh.Images.SetKeyName(7, "baocaochitiet-23.png")
        Me.ImageList_thaotacnhanh.Images.SetKeyName(8, "baocaochitiet-23.png")
        Me.ImageList_thaotacnhanh.Images.SetKeyName(9, "sogiathanh-23.png")
        Me.ImageList_thaotacnhanh.Images.SetKeyName(10, "sochitiettaisan-23.png")
        Me.ImageList_thaotacnhanh.Images.SetKeyName(11, "sochiphi-23.png")
        Me.ImageList_thaotacnhanh.Images.SetKeyName(12, "ngaoitevatigia-23.png")
        Me.ImageList_thaotacnhanh.Images.SetKeyName(13, "trano-23.png")
        Me.ImageList_thaotacnhanh.Images.SetKeyName(14, "vattudauky-23.png")
        Me.ImageList_thaotacnhanh.Images.SetKeyName(15, "congnodauky-23.png")
        Me.ImageList_thaotacnhanh.Images.SetKeyName(16, "taisandauky-23.png")
        Me.ImageList_thaotacnhanh.Images.SetKeyName(17, "chiphidauky-23.png")
        '
        'uThaoTacNhanh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListView_ThaoTacNhanh)
        Me.Name = "uThaoTacNhanh"
        Me.Size = New System.Drawing.Size(262, 503)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView_ThaoTacNhanh As System.Windows.Forms.ListView
    Friend WithEvents ImageList_thaotacnhanh As System.Windows.Forms.ImageList

End Class
