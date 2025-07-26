<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCongNo
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Công nợ đầu kỳ", 1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Thu nợ", 6)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Trả nợ", 7)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Báo cáo chi tiết", 0)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Phân loại khách hàng", 2)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Danh sách khách hàng", 3)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Tài khoản công nợ", 8)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Lãi suất công nợ", 9)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Ngoại tệ và tỷ giá", 4)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCongNo))
        Me.ListView_CongNo = New System.Windows.Forms.ListView
        Me.ImageList_congno = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ListView_CongNo
        '
        Me.ListView_CongNo.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView_CongNo.BackColor = System.Drawing.Color.AliceBlue
        Me.ListView_CongNo.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup1.Header = ""
        ListViewGroup1.Name = "gChucNang"
        ListViewGroup2.Header = ""
        ListViewGroup2.Name = "gDanhMuc"
        ListViewGroup3.Header = ""
        ListViewGroup3.Name = "gBaoCao"
        Me.ListView_CongNo.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        Me.ListView_CongNo.HotTracking = True
        Me.ListView_CongNo.HoverSelection = True
        ListViewItem1.Group = ListViewGroup1
        ListViewItem1.Tag = "tag_CongNoDauKy"
        ListViewItem1.ToolTipText = "Công nợ đầu kỳ"
        ListViewItem2.Group = ListViewGroup1
        ListViewItem2.Tag = "tag_ThuNo"
        ListViewItem2.ToolTipText = "Thu nợ"
        ListViewItem3.Group = ListViewGroup1
        ListViewItem3.Tag = "tag_TraNo"
        ListViewItem3.ToolTipText = "Trả nợ"
        ListViewItem4.Group = ListViewGroup3
        ListViewItem4.Tag = "tag_BaoCaoCongNo"
        ListViewItem4.ToolTipText = "Báo cáo chi tiết"
        ListViewItem5.Group = ListViewGroup2
        ListViewItem5.Tag = "tag_PhanLoaiKhachHang"
        ListViewItem5.ToolTipText = "Phân loại khách hàng"
        ListViewItem6.Group = ListViewGroup2
        ListViewItem6.Tag = "tag_DSKH"
        ListViewItem6.ToolTipText = "Danh sách khách hàng"
        ListViewItem7.Group = ListViewGroup2
        ListViewItem7.Tag = "tag_TKCongNo"
        ListViewItem7.ToolTipText = "Tài khoản công nợ"
        ListViewItem8.Group = ListViewGroup2
        ListViewItem8.Tag = "tag_LaiSuatCN"
        ListViewItem8.ToolTipText = "Lãi suất công nợ"
        ListViewItem9.Group = ListViewGroup2
        ListViewItem9.Tag = "tag_NgoaiTeVaTyGia"
        ListViewItem9.ToolTipText = "Ngoại tệ và tỷ giá"
        Me.ListView_CongNo.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9})
        Me.ListView_CongNo.LargeImageList = Me.ImageList_congno
        Me.ListView_CongNo.Location = New System.Drawing.Point(0, 23)
        Me.ListView_CongNo.MultiSelect = False
        Me.ListView_CongNo.Name = "ListView_CongNo"
        Me.ListView_CongNo.Size = New System.Drawing.Size(199, 360)
        Me.ListView_CongNo.TabIndex = 3
        Me.ListView_CongNo.UseCompatibleStateImageBehavior = False
        Me.ListView_CongNo.View = System.Windows.Forms.View.Tile
        '
        'ImageList_congno
        '
        Me.ImageList_congno.ImageStream = CType(resources.GetObject("ImageList_congno.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_congno.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_congno.Images.SetKeyName(0, "baocaochitiet-23.png")
        Me.ImageList_congno.Images.SetKeyName(1, "congnodauky-23.png")
        Me.ImageList_congno.Images.SetKeyName(2, "danhsachkhachhang-23.png")
        Me.ImageList_congno.Images.SetKeyName(3, "laisuatcongno-23.png")
        Me.ImageList_congno.Images.SetKeyName(4, "ngaoitevatigia-23.png")
        Me.ImageList_congno.Images.SetKeyName(5, "phanloaikhachhang-23.png")
        Me.ImageList_congno.Images.SetKeyName(6, "thuno-23.png")
        Me.ImageList_congno.Images.SetKeyName(7, "trano-23.png")
        Me.ImageList_congno.Images.SetKeyName(8, "danhsachvattu-23.png")
        Me.ImageList_congno.Images.SetKeyName(9, "laisuatcongno-kh-23.png")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CÔNG NỢ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uCongNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListView_CongNo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "uCongNo"
        Me.Size = New System.Drawing.Size(199, 383)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView_CongNo As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList_congno As System.Windows.Forms.ImageList

End Class
