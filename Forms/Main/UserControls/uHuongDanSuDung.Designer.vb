<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uHuongDanSuDung
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Video giới thiệu tổng quan phần mềm.", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Video hướng dẫn nhập dữ liệu đầu kỳ.", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Video hướng dẫn nhập dữ liệu chưng từ.", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup4 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Video hướng dẫn xem và kết xuất dữ liệu báo cáo.", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Giới thiệu tổng quan phần mềm.", 0)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Hướng dẫn nhập đầu kỳ các tài khoản không có chi tiết.", 0)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Hướng dẫn nhập đầu kỳ công nợ", 0)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Hướng dẫn nhập đầu kỳ hàng hóa nguyên vật liệu.", 0)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Hướng dẫn nhập hóa đơn bán hàng", 0)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Hướng dẫn nhập hóa đơn mua hàng (trong nước)", 0)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Hướng dẫn tra cứu chứng từ ...", 0)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uHuongDanSuDung))
        Me.ListViewHuongDan = New System.Windows.Forms.ListView
        Me.ImageList_huongdan = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'ListViewHuongDan
        '
        Me.ListViewHuongDan.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListViewHuongDan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewHuongDan.FullRowSelect = True
        ListViewGroup1.Header = "Video giới thiệu tổng quan phần mềm."
        ListViewGroup1.Name = "ListViewGroup_tongquan"
        ListViewGroup2.Header = "Video hướng dẫn nhập dữ liệu đầu kỳ."
        ListViewGroup2.Name = "ListViewGroup_nhapdauky"
        ListViewGroup3.Header = "Video hướng dẫn nhập dữ liệu chưng từ."
        ListViewGroup3.Name = "ListViewGroup_nhapLieu"
        ListViewGroup4.Header = "Video hướng dẫn xem và kết xuất dữ liệu báo cáo."
        ListViewGroup4.Name = "ListViewGroup_baocao"
        Me.ListViewHuongDan.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3, ListViewGroup4})
        Me.ListViewHuongDan.HotTracking = True
        Me.ListViewHuongDan.HoverSelection = True
        ListViewItem1.Group = ListViewGroup1
        ListViewItem1.Tag = "tag_gioithieutongquan"
        ListViewItem2.Group = ListViewGroup2
        ListViewItem2.Tag = "tag_daukykhongchitiet"
        ListViewItem3.Group = ListViewGroup2
        ListViewItem3.Tag = "tag_daukycongno"
        ListViewItem4.Group = ListViewGroup2
        ListViewItem4.Tag = "tag_daukyhanghoavattu"
        ListViewItem5.Group = ListViewGroup3
        ListViewItem5.Tag = "tag_nhaphoadonbanhang"
        ListViewItem6.Group = ListViewGroup3
        ListViewItem6.Tag = "tag_nhapmuahang"
        ListViewItem7.Group = ListViewGroup3
        ListViewItem7.Tag = "tag_tracuuchungtu"
        Me.ListViewHuongDan.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7})
        Me.ListViewHuongDan.LabelWrap = False
        Me.ListViewHuongDan.Location = New System.Drawing.Point(0, 0)
        Me.ListViewHuongDan.MultiSelect = False
        Me.ListViewHuongDan.Name = "ListViewHuongDan"
        Me.ListViewHuongDan.Size = New System.Drawing.Size(591, 454)
        Me.ListViewHuongDan.SmallImageList = Me.ImageList_huongdan
        Me.ListViewHuongDan.TabIndex = 2
        Me.ListViewHuongDan.TileSize = New System.Drawing.Size(400, 30)
        Me.ListViewHuongDan.UseCompatibleStateImageBehavior = False
        Me.ListViewHuongDan.View = System.Windows.Forms.View.SmallIcon
        '
        'ImageList_huongdan
        '
        Me.ImageList_huongdan.ImageStream = CType(resources.GetObject("ImageList_huongdan.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_huongdan.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_huongdan.Images.SetKeyName(0, "video-16.png")
        '
        'uHuongDanSuDung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListViewHuongDan)
        Me.Name = "uHuongDanSuDung"
        Me.Size = New System.Drawing.Size(591, 454)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListViewHuongDan As System.Windows.Forms.ListView
    Friend WithEvents ImageList_huongdan As System.Windows.Forms.ImageList

End Class
