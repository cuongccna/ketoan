<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCongCuDungCu
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Công cụ đầu kỳ", 2)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Nhập tăng công cụ", 3)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Chi phí trả trước đầu kỳ", 0)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Chi phí trả trước", 0)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Phân bổ", 4)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Tra cứu CT CCDC", 8)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Sổ CCDC", 7)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Phân loại CCDC", 9)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Sửa giá trị CCDC", 5)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Sửa giá trị chi phí", 6)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Đối tượng quản lý CCDC", 10)
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("TK Chi phí phân bổ", 11)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCongCuDungCu))
        Me.Label1 = New System.Windows.Forms.Label
        Me.ListView_CongCuDungCu = New System.Windows.Forms.ListView
        Me.ImageList_ccdc = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CÔNG CỤ DỤNG CỤ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListView_CongCuDungCu
        '
        Me.ListView_CongCuDungCu.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView_CongCuDungCu.BackColor = System.Drawing.Color.AliceBlue
        Me.ListView_CongCuDungCu.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup1.Header = ""
        ListViewGroup1.Name = "gChucNang"
        ListViewGroup2.Header = ""
        ListViewGroup2.Name = "gDanhMuc"
        ListViewGroup3.Header = ""
        ListViewGroup3.Name = "gBaoCao"
        Me.ListView_CongCuDungCu.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        Me.ListView_CongCuDungCu.HotTracking = True
        Me.ListView_CongCuDungCu.HoverSelection = True
        ListViewItem1.Group = ListViewGroup1
        ListViewItem1.Tag = "tag_CongCuDauKy"
        ListViewItem1.ToolTipText = "Công cụ đầu kỳ"
        ListViewItem2.Group = ListViewGroup1
        ListViewItem2.Tag = "tag_NhapTangCongCu"
        ListViewItem2.ToolTipText = "Nhập tăng công cụ"
        ListViewItem3.Group = ListViewGroup1
        ListViewItem3.Tag = "tag_ChiPhiTraTruocDauKy"
        ListViewItem3.ToolTipText = "Chi phí trả trước đầu kỳ"
        ListViewItem4.Group = ListViewGroup1
        ListViewItem4.Tag = "tag_ChiPhiTraTruoc"
        ListViewItem4.ToolTipText = "Chi phí trả trước"
        ListViewItem5.Group = ListViewGroup1
        ListViewItem5.Tag = "tag_PhanBo"
        ListViewItem5.ToolTipText = "Phân bổ"
        ListViewItem6.Group = ListViewGroup1
        ListViewItem6.Tag = "tag_TraCuuCTCCDC"
        ListViewItem6.ToolTipText = "Tra cứu CT CCDC"
        ListViewItem7.Group = ListViewGroup3
        ListViewItem7.Tag = "tag_SoCCDC"
        ListViewItem7.ToolTipText = "Sổ CCDC"
        ListViewItem8.Group = ListViewGroup2
        ListViewItem8.Tag = "tag_PhanLoaiCCDC"
        ListViewItem8.ToolTipText = "Phân loại CCDC"
        ListViewItem9.Group = ListViewGroup2
        ListViewItem9.Tag = "tag_SuaGiaTriCCDC"
        ListViewItem9.ToolTipText = "Sửa giá trị CCDC"
        ListViewItem10.Group = ListViewGroup2
        ListViewItem10.Tag = "tag_SuaGiaTriCP"
        ListViewItem10.ToolTipText = "Sửa giá trị chi phí"
        ListViewItem11.Group = ListViewGroup2
        ListViewItem11.Tag = "tag_DoiTuongQuanLyCCDC"
        ListViewItem11.ToolTipText = "Đối tượng quản lý CCDC"
        ListViewItem12.Group = ListViewGroup2
        ListViewItem12.Tag = "tag_TKChiPhiPB"
        ListViewItem12.ToolTipText = "TK Chi phí phân bổ"
        Me.ListView_CongCuDungCu.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12})
        Me.ListView_CongCuDungCu.LargeImageList = Me.ImageList_ccdc
        Me.ListView_CongCuDungCu.Location = New System.Drawing.Point(0, 23)
        Me.ListView_CongCuDungCu.MultiSelect = False
        Me.ListView_CongCuDungCu.Name = "ListView_CongCuDungCu"
        Me.ListView_CongCuDungCu.Size = New System.Drawing.Size(209, 444)
        Me.ListView_CongCuDungCu.TabIndex = 1
        Me.ListView_CongCuDungCu.UseCompatibleStateImageBehavior = False
        Me.ListView_CongCuDungCu.View = System.Windows.Forms.View.Tile
        '
        'ImageList_ccdc
        '
        Me.ImageList_ccdc.ImageStream = CType(resources.GetObject("ImageList_ccdc.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_ccdc.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_ccdc.Images.SetKeyName(0, "chiphidauky-23.png")
        Me.ImageList_ccdc.Images.SetKeyName(1, "chiphitratruoc-23.png")
        Me.ImageList_ccdc.Images.SetKeyName(2, "congcudauky-23.png")
        Me.ImageList_ccdc.Images.SetKeyName(3, "nhaptangcongcu-23.png")
        Me.ImageList_ccdc.Images.SetKeyName(4, "phanbo-23.png")
        Me.ImageList_ccdc.Images.SetKeyName(5, "phanloaiccdc1-23.png.png")
        Me.ImageList_ccdc.Images.SetKeyName(6, "phanloaiccdc-23.png")
        Me.ImageList_ccdc.Images.SetKeyName(7, "hoadonnoidia-23.png")
        Me.ImageList_ccdc.Images.SetKeyName(8, "timkiemphieuthuchi-23.png")
        Me.ImageList_ccdc.Images.SetKeyName(9, "phanloaivattu-23.png")
        Me.ImageList_ccdc.Images.SetKeyName(10, "phanloai-losx-23.png")
        Me.ImageList_ccdc.Images.SetKeyName(11, "danhsachvattu-23.png")
        '
        'uCongCuDungCu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListView_CongCuDungCu)
        Me.Controls.Add(Me.Label1)
        Me.Name = "uCongCuDungCu"
        Me.Size = New System.Drawing.Size(209, 467)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListView_CongCuDungCu As System.Windows.Forms.ListView
    Friend WithEvents ImageList_ccdc As System.Windows.Forms.ImageList

End Class
