<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uChiPhiTongHop
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Nhập chi phí tổng hợp", 1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Tìm phiếu thu chi", 4)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Tính giá xuất ngoại tệ", 5)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Nhập chứng từ tổng hợp", 0)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Sổ chi phí", 3)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uChiPhiTongHop))
        Me.ListView_Chiphitonghop = New System.Windows.Forms.ListView
        Me.ImageList_chiphitonghop = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ListView_Chiphitonghop
        '
        Me.ListView_Chiphitonghop.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView_Chiphitonghop.BackColor = System.Drawing.Color.AliceBlue
        Me.ListView_Chiphitonghop.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup1.Header = ""
        ListViewGroup1.Name = "gChucNang"
        ListViewGroup2.Header = ""
        ListViewGroup2.Name = "gBaoCao"
        Me.ListView_Chiphitonghop.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.ListView_Chiphitonghop.HotTracking = True
        Me.ListView_Chiphitonghop.HoverSelection = True
        ListViewItem1.Group = ListViewGroup1
        ListViewItem1.Tag = "tag_NhapChiPhiTongHop"
        ListViewItem1.ToolTipText = "Nhập chi phí tổng hợp"
        ListViewItem2.Group = ListViewGroup1
        ListViewItem2.Tag = "tag_TimPhieuThuChi"
        ListViewItem2.ToolTipText = "Tìm phiếu thu chi"
        ListViewItem3.Group = ListViewGroup1
        ListViewItem3.Tag = "tag_TinhGiaXuatNgoaiTe"
        ListViewItem3.ToolTipText = "Tính giá xuất ngoại tệ"
        ListViewItem4.Group = ListViewGroup1
        ListViewItem4.Tag = "tag_NhapChungTuTongHop"
        ListViewItem4.ToolTipText = "Nhập chứng từ tổng hợp"
        ListViewItem5.Group = ListViewGroup2
        ListViewItem5.Tag = "tag_SoChiPhi"
        ListViewItem5.ToolTipText = "Sổ chi phí"
        Me.ListView_Chiphitonghop.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5})
        Me.ListView_Chiphitonghop.LargeImageList = Me.ImageList_chiphitonghop
        Me.ListView_Chiphitonghop.Location = New System.Drawing.Point(0, 23)
        Me.ListView_Chiphitonghop.MultiSelect = False
        Me.ListView_Chiphitonghop.Name = "ListView_Chiphitonghop"
        Me.ListView_Chiphitonghop.Size = New System.Drawing.Size(213, 235)
        Me.ListView_Chiphitonghop.TabIndex = 3
        Me.ListView_Chiphitonghop.UseCompatibleStateImageBehavior = False
        Me.ListView_Chiphitonghop.View = System.Windows.Forms.View.Tile
        '
        'ImageList_chiphitonghop
        '
        Me.ImageList_chiphitonghop.ImageStream = CType(resources.GetObject("ImageList_chiphitonghop.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_chiphitonghop.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_chiphitonghop.Images.SetKeyName(0, "nhapchiphitonghop-23.png")
        Me.ImageList_chiphitonghop.Images.SetKeyName(1, "nhapchungtutonghop-23.png")
        Me.ImageList_chiphitonghop.Images.SetKeyName(2, "phanbo-23.png")
        Me.ImageList_chiphitonghop.Images.SetKeyName(3, "sochiphi-23.png")
        Me.ImageList_chiphitonghop.Images.SetKeyName(4, "timkiemphieuthuchi-23.png")
        Me.ImageList_chiphitonghop.Images.SetKeyName(5, "tinhgiaxuatngoite-23.png")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CHI PHÍ TỔNG HỢP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uChiPhiTongHop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListView_Chiphitonghop)
        Me.Controls.Add(Me.Label1)
        Me.Name = "uChiPhiTongHop"
        Me.Size = New System.Drawing.Size(213, 258)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView_Chiphitonghop As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList_chiphitonghop As System.Windows.Forms.ImageList

End Class
