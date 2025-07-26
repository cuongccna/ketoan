<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uGiaThanh
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Dở giang đầu kỳ", 4)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Nhập kho thành phẩm", 3)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Tính lại giá trị xuất kho", 7)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Sổ giá thành", 6)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Phân loại lô sản xuất", 5)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Danh sách lô sản xuất", 5)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Định mức NVL", 2)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Phân bổ chi phí CT SP", 4)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uGiaThanh))
        Me.ListView_giathanh = New System.Windows.Forms.ListView
        Me.ImageList_giathanh = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ListView_giathanh
        '
        Me.ListView_giathanh.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView_giathanh.BackColor = System.Drawing.Color.AliceBlue
        Me.ListView_giathanh.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup1.Header = ""
        ListViewGroup1.Name = "gChucNang"
        ListViewGroup2.Header = ""
        ListViewGroup2.Name = "gDanhMuc"
        ListViewGroup3.Header = ""
        ListViewGroup3.Name = "gBaoCao"
        Me.ListView_giathanh.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        Me.ListView_giathanh.HotTracking = True
        Me.ListView_giathanh.HoverSelection = True
        ListViewItem1.Group = ListViewGroup1
        ListViewItem1.Tag = "tag_DoGiangDauKy"
        ListViewItem1.ToolTipText = "Dở giang đầu kỳ"
        ListViewItem2.Group = ListViewGroup1
        ListViewItem2.Tag = "tag_Nhapkhothanhpham"
        ListViewItem2.ToolTipText = "Nhập kho thành phẩm"
        ListViewItem3.Group = ListViewGroup1
        ListViewItem3.Tag = "tag_TinhLaiGiaTriXuatKho"
        ListViewItem3.ToolTipText = "Tính lại giá trị xuất kho"
        ListViewItem4.Group = ListViewGroup3
        ListViewItem4.Tag = "tag_SoGiaThanh"
        ListViewItem4.ToolTipText = "Sổ giá thành"
        ListViewItem5.Group = ListViewGroup2
        ListViewItem5.Tag = "tag_PhanLoaiLoSanXuat"
        ListViewItem5.ToolTipText = "Phân loại lô sản xuất"
        ListViewItem6.Group = ListViewGroup2
        ListViewItem6.Tag = "tag_DSLoSanXuat"
        ListViewItem6.ToolTipText = "Danh sách lô sản xuất"
        ListViewItem7.Group = ListViewGroup2
        ListViewItem7.Tag = "tag_DinhMucNVL"
        ListViewItem7.ToolTipText = "Định mức NVL"
        ListViewItem8.Group = ListViewGroup2
        ListViewItem8.Tag = "tag_PhanBoCPCTSP"
        ListViewItem8.ToolTipText = "Phân bổ chi phí CT SP"
        Me.ListView_giathanh.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8})
        Me.ListView_giathanh.LargeImageList = Me.ImageList_giathanh
        Me.ListView_giathanh.Location = New System.Drawing.Point(0, 23)
        Me.ListView_giathanh.MultiSelect = False
        Me.ListView_giathanh.Name = "ListView_giathanh"
        Me.ListView_giathanh.Size = New System.Drawing.Size(205, 352)
        Me.ListView_giathanh.TabIndex = 3
        Me.ListView_giathanh.UseCompatibleStateImageBehavior = False
        Me.ListView_giathanh.View = System.Windows.Forms.View.Tile
        '
        'ImageList_giathanh
        '
        Me.ImageList_giathanh.ImageStream = CType(resources.GetObject("ImageList_giathanh.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_giathanh.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_giathanh.Images.SetKeyName(0, "chiphitratruoc-23.png")
        Me.ImageList_giathanh.Images.SetKeyName(1, "dinhmucnvl-23.png")
        Me.ImageList_giathanh.Images.SetKeyName(2, "dogiangdauky-23.png")
        Me.ImageList_giathanh.Images.SetKeyName(3, "nhapkhothanhpham-23.png")
        Me.ImageList_giathanh.Images.SetKeyName(4, "phanbonvl-23.png")
        Me.ImageList_giathanh.Images.SetKeyName(5, "phanloai-losx-23.png")
        Me.ImageList_giathanh.Images.SetKeyName(6, "sogiathanh-23.png")
        Me.ImageList_giathanh.Images.SetKeyName(7, "tinhlai-gia-xuat-kho-23.png")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "GIÁ THÀNH"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uGiaThanh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListView_giathanh)
        Me.Controls.Add(Me.Label1)
        Me.Name = "uGiaThanh"
        Me.Size = New System.Drawing.Size(205, 375)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView_giathanh As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList_giathanh As System.Windows.Forms.ImageList

End Class
