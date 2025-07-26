<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhanLoai
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeText_Renamed()
		InitializeLine1()
		InitializeCommand1()
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
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command1_3 As System.Windows.Forms.Button
    Private WithEvents _Command1_2 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Private WithEvents _Text_0 As System.Windows.Forms.TextBox
    Private WithEvents _Text_1 As System.Windows.Forms.TextBox
    Public WithEvents Outline As System.Windows.Forms.TreeView
    Private WithEvents _Line1_3 As System.Windows.Forms.Label
    Private WithEvents _Line1_2 As System.Windows.Forms.Label
    Private WithEvents _Line1_1 As System.Windows.Forms.Label
    Private WithEvents _Line1_0 As System.Windows.Forms.Label
    Public Command(3) As System.Windows.Forms.Button
    Public Command1(3) As System.Windows.Forms.Button
    Public Line1(3) As System.Windows.Forms.Label
    Public Text_Renamed(1) As System.Windows.Forms.TextBox
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhanLoai))
        Me.Outline = New System.Windows.Forms.TreeView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Command1_3 = New System.Windows.Forms.Button
        Me._Command1_2 = New System.Windows.Forms.Button
        Me._Command1_1 = New System.Windows.Forms.Button
        Me._Command1_0 = New System.Windows.Forms.Button
        Me._Text_0 = New System.Windows.Forms.TextBox
        Me._Text_1 = New System.Windows.Forms.TextBox
        Me._Line1_3 = New System.Windows.Forms.Label
        Me._Line1_2 = New System.Windows.Forms.Label
        Me._Line1_1 = New System.Windows.Forms.Label
        Me._Line1_0 = New System.Windows.Forms.Label
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
        Me.Outline.Size = New System.Drawing.Size(345, 319)
        Me.Outline.TabIndex = 80
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-folder-16.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8-open-16.png")
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(355, 72)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(88, 25)
        Me._Command_2.TabIndex = 9
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(355, 104)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(88, 25)
        Me._Command_3.TabIndex = 10
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(355, 40)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(88, 25)
        Me._Command_1.TabIndex = 8
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.add16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(355, 8)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(88, 25)
        Me._Command_0.TabIndex = 7
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        '
        '_Command1_3
        '
        Me._Command1_3.BackColor = System.Drawing.Color.Silver
        Me._Command1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_3.Image = CType(resources.GetObject("_Command1_3.Image"), System.Drawing.Image)
        Me._Command1_3.Location = New System.Drawing.Point(355, 104)
        Me._Command1_3.Name = "_Command1_3"
        Me._Command1_3.Size = New System.Drawing.Size(88, 25)
        Me._Command1_3.TabIndex = 5
        Me._Command1_3.TabStop = False
        Me._Command1_3.Tag = "&Return"
        Me._Command1_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_3.UseVisualStyleBackColor = False
        Me._Command1_3.Visible = False
        '
        '_Command1_2
        '
        Me._Command1_2.BackColor = System.Drawing.Color.Silver
        Me._Command1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_2.Image = CType(resources.GetObject("_Command1_2.Image"), System.Drawing.Image)
        Me._Command1_2.Location = New System.Drawing.Point(355, 72)
        Me._Command1_2.Name = "_Command1_2"
        Me._Command1_2.Size = New System.Drawing.Size(88, 25)
        Me._Command1_2.TabIndex = 4
        Me._Command1_2.TabStop = False
        Me._Command1_2.Tag = "&DELETE"
        Me._Command1_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_2.UseVisualStyleBackColor = False
        Me._Command1_2.Visible = False
        '
        '_Command1_1
        '
        Me._Command1_1.BackColor = System.Drawing.Color.Silver
        Me._Command1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_1.Image = CType(resources.GetObject("_Command1_1.Image"), System.Drawing.Image)
        Me._Command1_1.Location = New System.Drawing.Point(355, 40)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(88, 25)
        Me._Command1_1.TabIndex = 3
        Me._Command1_1.TabStop = False
        Me._Command1_1.Tag = "&Save"
        Me._Command1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_1.UseVisualStyleBackColor = False
        Me._Command1_1.Visible = False
        '
        '_Command1_0
        '
        Me._Command1_0.BackColor = System.Drawing.Color.Silver
        Me._Command1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_0.Image = CType(resources.GetObject("_Command1_0.Image"), System.Drawing.Image)
        Me._Command1_0.Location = New System.Drawing.Point(355, 8)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(88, 25)
        Me._Command1_0.TabIndex = 2
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&Add"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        '_Text_0
        '
        Me._Text_0.Location = New System.Drawing.Point(88, 328)
        Me._Text_0.MaxLength = 50
        Me._Text_0.Name = "_Text_0"
        Me._Text_0.Size = New System.Drawing.Size(265, 20)
        Me._Text_0.TabIndex = 1
        '
        '_Text_1
        '
        Me._Text_1.Location = New System.Drawing.Point(8, 328)
        Me._Text_1.MaxLength = 15
        Me._Text_1.Name = "_Text_1"
        Me._Text_1.Size = New System.Drawing.Size(77, 20)
        Me._Text_1.TabIndex = 0
        '
        '_Line1_3
        '
        Me._Line1_3.BackColor = System.Drawing.SystemColors.Window
        Me._Line1_3.Enabled = False
        Me._Line1_3.Location = New System.Drawing.Point(352, 8)
        Me._Line1_3.Name = "_Line1_3"
        Me._Line1_3.Size = New System.Drawing.Size(1, 312)
        Me._Line1_3.TabIndex = 11
        '
        '_Line1_2
        '
        Me._Line1_2.Enabled = False
        Me._Line1_2.Location = New System.Drawing.Point(8, 8)
        Me._Line1_2.Name = "_Line1_2"
        Me._Line1_2.Size = New System.Drawing.Size(1, 312)
        Me._Line1_2.TabIndex = 12
        '
        '_Line1_1
        '
        Me._Line1_1.BackColor = System.Drawing.SystemColors.Window
        Me._Line1_1.Enabled = False
        Me._Line1_1.Location = New System.Drawing.Point(8, 320)
        Me._Line1_1.Name = "_Line1_1"
        Me._Line1_1.Size = New System.Drawing.Size(344, 1)
        Me._Line1_1.TabIndex = 13
        '
        '_Line1_0
        '
        Me._Line1_0.Enabled = False
        Me._Line1_0.Location = New System.Drawing.Point(8, 8)
        Me._Line1_0.Name = "_Line1_0"
        Me._Line1_0.Size = New System.Drawing.Size(344, 1)
        Me._Line1_0.TabIndex = 14
        '
        'frmPhanLoai
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(444, 355)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me.Outline)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command1_3)
        Me.Controls.Add(Me._Command1_2)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me._Text_0)
        Me.Controls.Add(Me._Text_1)
        Me.Controls.Add(Me._Line1_3)
        Me.Controls.Add(Me._Line1_2)
        Me.Controls.Add(Me._Line1_1)
        Me.Controls.Add(Me._Line1_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(107, 70)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPhanLoai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Phân loại"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Sub InitializeText_Renamed()
        Me.Text_Renamed(0) = _Text_0
        Me.Text_Renamed(1) = _Text_1
    End Sub
    Sub InitializeLine1()
        Me.Line1(3) = _Line1_3
        Me.Line1(2) = _Line1_2
        Me.Line1(1) = _Line1_1
        Me.Line1(0) = _Line1_0
    End Sub
    Sub InitializeCommand1()
        Me.Command1(3) = _Command1_3
        Me.Command1(2) = _Command1_2
        Me.Command1(1) = _Command1_1
        Me.Command1(0) = _Command1_0
    End Sub
    Sub InitializeCommand()
        Me.Command(2) = _Command_2
        Me.Command(3) = _Command_3
        Me.Command(1) = _Command_1
        Me.Command(0) = _Command_0
    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
#End Region
End Class
