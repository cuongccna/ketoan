<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhanLoaiVT
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeText_Renamed()
		InitializeCommand()
	End Sub
    Private Sub ReleaseResources(ByVal eventSender As Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        Dispose(True)
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
     Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTipMain As System.Windows.Forms.ToolTip
    Private WithEvents _Command_4 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Text_2 As System.Windows.Forms.TextBox
    Private WithEvents _Text_0 As System.Windows.Forms.TextBox
    Private WithEvents _Text_1 As System.Windows.Forms.TextBox
    Public WithEvents Outline As System.Windows.Forms.TreeView
    Public Command(5) As System.Windows.Forms.Button
    Public Text_Renamed(2) As System.Windows.Forms.TextBox
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhanLoaiVT))
        Me.Outline = New System.Windows.Forms.TreeView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_4 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Text_2 = New System.Windows.Forms.TextBox
        Me._Text_0 = New System.Windows.Forms.TextBox
        Me._Text_1 = New System.Windows.Forms.TextBox
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Command_5 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Outline
        '
        Me.Outline.FullRowSelect = True
        Me.Outline.HideSelection = False
        Me.Outline.ImageIndex = 0
        Me.Outline.ImageList = Me.ImageList1
        Me.Outline.Location = New System.Drawing.Point(8, 8)
        Me.Outline.Name = "Outline"
        Me.Outline.SelectedImageIndex = 1
        Me.Outline.ShowNodeToolTips = True
        Me.Outline.Size = New System.Drawing.Size(341, 319)
        Me.Outline.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-folder-16.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8-open-16.png")
        '
        '_Command_4
        '
        Me._Command_4.Image = Global.UNET.My.Resources.Resources.print16
        Me._Command_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_4.Location = New System.Drawing.Point(355, 108)
        Me._Command_4.Name = "_Command_4"
        Me._Command_4.Size = New System.Drawing.Size(88, 25)
        Me._Command_4.TabIndex = 5
        Me._Command_4.Tag = "Preview"
        Me._Command_4.Text = "&Xem in"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.add16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(355, 33)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(88, 25)
        Me._Command_0.TabIndex = 2
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(355, 58)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(88, 25)
        Me._Command_1.TabIndex = 3
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(355, 83)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(88, 25)
        Me._Command_2.TabIndex = 4
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(355, 133)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(88, 25)
        Me._Command_3.TabIndex = 6
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_Text_2
        '
        Me._Text_2.Location = New System.Drawing.Point(355, 328)
        Me._Text_2.MaxLength = 15
        Me._Text_2.Name = "_Text_2"
        Me._Text_2.Size = New System.Drawing.Size(88, 20)
        Me._Text_2.TabIndex = 10
        Me._Text_2.Visible = False
        '
        '_Text_0
        '
        Me._Text_0.Location = New System.Drawing.Point(131, 328)
        Me._Text_0.MaxLength = 50
        Me._Text_0.Name = "_Text_0"
        Me._Text_0.Size = New System.Drawing.Size(222, 20)
        Me._Text_0.TabIndex = 8
        '
        '_Text_1
        '
        Me._Text_1.Location = New System.Drawing.Point(8, 328)
        Me._Text_1.MaxLength = 15
        Me._Text_1.Name = "_Text_1"
        Me._Text_1.Size = New System.Drawing.Size(124, 20)
        Me._Text_1.TabIndex = 7
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.Transparent
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_6.Location = New System.Drawing.Point(358, 303)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(85, 17)
        Me._Label_6.TabIndex = 9
        Me._Label_6.Tag = "Account"
        Me._Label_6.Text = "Tài khoản"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Label_6.Visible = False
        '
        '_Command_5
        '
        Me._Command_5.Image = Global.UNET.My.Resources.Resources.up16
        Me._Command_5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_5.Location = New System.Drawing.Point(355, 8)
        Me._Command_5.Name = "_Command_5"
        Me._Command_5.Size = New System.Drawing.Size(88, 25)
        Me._Command_5.TabIndex = 1
        Me._Command_5.Tag = "Add"
        Me._Command_5.Text = "&Thêm Cha"
        '
        'frmPhanLoaiVT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(453, 358)
        Me.Controls.Add(Me._Text_0)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Command_4)
        Me.Controls.Add(Me._Command_5)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Text_2)
        Me.Controls.Add(Me.Outline)
        Me.Controls.Add(Me._Text_1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(107, 70)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPhanLoaiVT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Sub InitializeText_Renamed()
        Me.Text_Renamed(2) = _Text_2
        Me.Text_Renamed(0) = _Text_0
        Me.Text_Renamed(1) = _Text_1
    End Sub

    Sub InitializeCommand()
        Me.Command(4) = _Command_4
        Me.Command(0) = _Command_0
        Me.Command(1) = _Command_1
        Me.Command(2) = _Command_2
        Me.Command(3) = _Command_3
        Me.Command(5) = _Command_5
    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    'Friend WithEvents ButtonEdit1 As DevExpress.XtraEditors.ButtonEdit
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Command_5 As System.Windows.Forms.Button
#End Region
End Class
