<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNhanVien
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializetxtVT()
		InitializeSSOpt()
		InitializeLine()
		InitializeLabel()
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
    Public WithEvents SSCmdF As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Public WithEvents txtF As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_0 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_3 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_4 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_5 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_6 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_7 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_8 As System.Windows.Forms.TextBox
    Private WithEvents _SSOpt_2 As System.Windows.Forms.RadioButton
    Private WithEvents _Command1_3 As System.Windows.Forms.Button
    Private WithEvents _Command1_2 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Public WithEvents SSCmdF1 As System.Windows.Forms.Button
    Private WithEvents _SSOpt_1 As System.Windows.Forms.RadioButton
    Private WithEvents _SSOpt_0 As System.Windows.Forms.RadioButton
    Public WithEvents CboLoai As ComboBoxEx.ComboBoxExt
    Public WithEvents LstVt As System.Windows.Forms.ListBox
    Public WithEvents MedNgay As System.Windows.Forms.MaskedTextBox
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Line_0 As System.Windows.Forms.Label
    Private WithEvents _Line_1 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Line_2 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Line_3 As System.Windows.Forms.Label
    Private WithEvents _Line_4 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Line_5 As System.Windows.Forms.Label
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Line_7 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Private WithEvents _Line_9 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Line_10 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Public Command(3) As System.Windows.Forms.Button
    Public Command1(3) As System.Windows.Forms.Button
    Public Label(17) As System.Windows.Forms.Label
    Public Line(10) As System.Windows.Forms.Label
    Public SSOpt(2) As System.Windows.Forms.RadioButton
    Public txtVT(8) As System.Windows.Forms.TextBox
    'Private listBoxHelper1 As Artinsoft.VB6.Gui.ListBoxHelper
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNhanVien))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.SSCmdF = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me.txtF = New System.Windows.Forms.TextBox
        Me._txtVT_0 = New System.Windows.Forms.TextBox
        Me._txtVT_1 = New System.Windows.Forms.TextBox
        Me._txtVT_3 = New System.Windows.Forms.TextBox
        Me._txtVT_2 = New System.Windows.Forms.TextBox
        Me._txtVT_4 = New System.Windows.Forms.TextBox
        Me._txtVT_5 = New System.Windows.Forms.TextBox
        Me._txtVT_6 = New System.Windows.Forms.TextBox
        Me._txtVT_7 = New System.Windows.Forms.TextBox
        Me._txtVT_8 = New System.Windows.Forms.TextBox
        Me._SSOpt_2 = New System.Windows.Forms.RadioButton
        Me._Command1_3 = New System.Windows.Forms.Button
        Me._Command1_2 = New System.Windows.Forms.Button
        Me._Command1_1 = New System.Windows.Forms.Button
        Me._Command1_0 = New System.Windows.Forms.Button
        Me.SSCmdF1 = New System.Windows.Forms.Button
        Me._SSOpt_1 = New System.Windows.Forms.RadioButton
        Me._SSOpt_0 = New System.Windows.Forms.RadioButton
        Me.CboLoai = New ComboBoxEx.ComboBoxExt
        Me.LstVt = New System.Windows.Forms.ListBox
        Me.MedNgay = New System.Windows.Forms.MaskedTextBox
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Line_0 = New System.Windows.Forms.Label
        Me._Line_1 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Line_2 = New System.Windows.Forms.Label
        Me._Label_10 = New System.Windows.Forms.Label
        Me._Line_3 = New System.Windows.Forms.Label
        Me._Line_4 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Line_5 = New System.Windows.Forms.Label
        Me._Label_11 = New System.Windows.Forms.Label
        Me._Line_7 = New System.Windows.Forms.Label
        Me._Label_13 = New System.Windows.Forms.Label
        Me._Label_14 = New System.Windows.Forms.Label
        Me._Line_9 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Line_10 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Label_17 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'SSCmdF
        '
        Me.SSCmdF.Image = Global.UNET.My.Resources.Resources.search3_16
        Me.SSCmdF.Location = New System.Drawing.Point(304, 448)
        Me.SSCmdF.Name = "SSCmdF"
        Me.SSCmdF.Size = New System.Drawing.Size(17, 19)
        Me.SSCmdF.TabIndex = 6
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.add16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(336, 445)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 36
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(416, 445)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 37
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(496, 445)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 38
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(576, 445)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 39
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        'txtF
        '
        Me.txtF.AcceptsReturn = True
        Me.txtF.BackColor = System.Drawing.SystemColors.Window
        Me.txtF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF.Location = New System.Drawing.Point(208, 447)
        Me.txtF.MaxLength = 0
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(89, 20)
        Me.txtF.TabIndex = 5
        '
        '_txtVT_0
        '
        Me._txtVT_0.AcceptsReturn = True
        Me._txtVT_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me._txtVT_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_0.Location = New System.Drawing.Point(384, 32)
        Me._txtVT_0.MaxLength = 20
        Me._txtVT_0.Name = "_txtVT_0"
        Me._txtVT_0.Size = New System.Drawing.Size(89, 13)
        Me._txtVT_0.TabIndex = 7
        Me._txtVT_0.Text = "..."
        '
        '_txtVT_1
        '
        Me._txtVT_1.AcceptsReturn = True
        Me._txtVT_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_1.Location = New System.Drawing.Point(384, 64)
        Me._txtVT_1.MaxLength = 100
        Me._txtVT_1.Name = "_txtVT_1"
        Me._txtVT_1.Size = New System.Drawing.Size(241, 13)
        Me._txtVT_1.TabIndex = 8
        Me._txtVT_1.Text = "..."
        '
        '_txtVT_3
        '
        Me._txtVT_3.AcceptsReturn = True
        Me._txtVT_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_3.Location = New System.Drawing.Point(384, 160)
        Me._txtVT_3.MaxLength = 20
        Me._txtVT_3.Name = "_txtVT_3"
        Me._txtVT_3.Size = New System.Drawing.Size(89, 13)
        Me._txtVT_3.TabIndex = 11
        Me._txtVT_3.Text = "..."
        '
        '_txtVT_2
        '
        Me._txtVT_2.AcceptsReturn = True
        Me._txtVT_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_2.Location = New System.Drawing.Point(384, 96)
        Me._txtVT_2.MaxLength = 100
        Me._txtVT_2.Name = "_txtVT_2"
        Me._txtVT_2.Size = New System.Drawing.Size(241, 13)
        Me._txtVT_2.TabIndex = 9
        Me._txtVT_2.Text = "..."
        '
        '_txtVT_4
        '
        Me._txtVT_4.AcceptsReturn = True
        Me._txtVT_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_4.Location = New System.Drawing.Point(384, 192)
        Me._txtVT_4.MaxLength = 20
        Me._txtVT_4.Name = "_txtVT_4"
        Me._txtVT_4.Size = New System.Drawing.Size(89, 13)
        Me._txtVT_4.TabIndex = 12
        Me._txtVT_4.Text = "..."
        '
        '_txtVT_5
        '
        Me._txtVT_5.AcceptsReturn = True
        Me._txtVT_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_5.Location = New System.Drawing.Point(536, 192)
        Me._txtVT_5.MaxLength = 20
        Me._txtVT_5.Name = "_txtVT_5"
        Me._txtVT_5.Size = New System.Drawing.Size(89, 13)
        Me._txtVT_5.TabIndex = 13
        Me._txtVT_5.Text = "..."
        '
        '_txtVT_6
        '
        Me._txtVT_6.AcceptsReturn = True
        Me._txtVT_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_6.Location = New System.Drawing.Point(384, 224)
        Me._txtVT_6.MaxLength = 20
        Me._txtVT_6.Name = "_txtVT_6"
        Me._txtVT_6.Size = New System.Drawing.Size(89, 13)
        Me._txtVT_6.TabIndex = 14
        Me._txtVT_6.Text = "..."
        '
        '_txtVT_7
        '
        Me._txtVT_7.AcceptsReturn = True
        Me._txtVT_7.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_7.Location = New System.Drawing.Point(384, 256)
        Me._txtVT_7.MaxLength = 100
        Me._txtVT_7.Name = "_txtVT_7"
        Me._txtVT_7.Size = New System.Drawing.Size(241, 13)
        Me._txtVT_7.TabIndex = 15
        Me._txtVT_7.Text = "..."
        '
        '_txtVT_8
        '
        Me._txtVT_8.AcceptsReturn = True
        Me._txtVT_8.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_8.Location = New System.Drawing.Point(383, 334)
        Me._txtVT_8.MaxLength = 250
        Me._txtVT_8.Multiline = True
        Me._txtVT_8.Name = "_txtVT_8"
        Me._txtVT_8.Size = New System.Drawing.Size(241, 74)
        Me._txtVT_8.TabIndex = 16
        Me._txtVT_8.Text = "..."
        '
        '_SSOpt_2
        '
        Me._SSOpt_2.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_2.Location = New System.Drawing.Point(144, 449)
        Me._SSOpt_2.Name = "_SSOpt_2"
        Me._SSOpt_2.Size = New System.Drawing.Size(65, 17)
        Me._SSOpt_2.TabIndex = 4
        Me._SSOpt_2.TabStop = True
        Me._SSOpt_2.Tag = "Id card"
        Me._SSOpt_2.Text = "CMND"
        Me._SSOpt_2.UseVisualStyleBackColor = False
        '
        '_Command1_3
        '
        Me._Command1_3.BackColor = System.Drawing.Color.Silver
        Me._Command1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_3.Image = CType(resources.GetObject("_Command1_3.Image"), System.Drawing.Image)
        Me._Command1_3.Location = New System.Drawing.Point(576, 445)
        Me._Command1_3.Name = "_Command1_3"
        Me._Command1_3.Size = New System.Drawing.Size(73, 25)
        Me._Command1_3.TabIndex = 19
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
        Me._Command1_2.Location = New System.Drawing.Point(496, 445)
        Me._Command1_2.Name = "_Command1_2"
        Me._Command1_2.Size = New System.Drawing.Size(73, 25)
        Me._Command1_2.TabIndex = 24
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
        Me._Command1_1.Location = New System.Drawing.Point(416, 445)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(73, 25)
        Me._Command1_1.TabIndex = 17
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
        Me._Command1_0.Location = New System.Drawing.Point(336, 445)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(73, 25)
        Me._Command1_0.TabIndex = 18
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&Add"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        'SSCmdF1
        '
        Me.SSCmdF1.BackColor = System.Drawing.SystemColors.Control
        Me.SSCmdF1.Cursor = System.Windows.Forms.Cursors.Default
        Me.SSCmdF1.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.SSCmdF1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SSCmdF1.Location = New System.Drawing.Point(304, 448)
        Me.SSCmdF1.Name = "SSCmdF1"
        Me.SSCmdF1.Size = New System.Drawing.Size(17, 19)
        Me.SSCmdF1.TabIndex = 23
        Me.SSCmdF1.TabStop = False
        Me.SSCmdF1.Text = "ư"
        Me.SSCmdF1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SSCmdF1.UseVisualStyleBackColor = False
        Me.SSCmdF1.Visible = False
        '
        '_SSOpt_1
        '
        Me._SSOpt_1.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_1.Location = New System.Drawing.Point(80, 449)
        Me._SSOpt_1.Name = "_SSOpt_1"
        Me._SSOpt_1.Size = New System.Drawing.Size(57, 17)
        Me._SSOpt_1.TabIndex = 3
        Me._SSOpt_1.TabStop = True
        Me._SSOpt_1.Tag = "Name"
        Me._SSOpt_1.Text = "Tên "
        Me._SSOpt_1.UseVisualStyleBackColor = False
        '
        '_SSOpt_0
        '
        Me._SSOpt_0.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_0.Checked = True
        Me._SSOpt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_0.Location = New System.Drawing.Point(8, 449)
        Me._SSOpt_0.Name = "_SSOpt_0"
        Me._SSOpt_0.Size = New System.Drawing.Size(65, 17)
        Me._SSOpt_0.TabIndex = 2
        Me._SSOpt_0.TabStop = True
        Me._SSOpt_0.Tag = "Code"
        Me._SSOpt_0.Text = "Số hiệu"
        Me._SSOpt_0.UseVisualStyleBackColor = False
        '
        'CboLoai
        '
        Me.CboLoai.BackColor = System.Drawing.SystemColors.Window
        Me.CboLoai.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLoai.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLoai.ForeColor = System.Drawing.Color.Blue
        Me.CboLoai.Location = New System.Drawing.Point(8, 8)
        Me.CboLoai.Name = "CboLoai"
        Me.CboLoai.Size = New System.Drawing.Size(297, 21)
        Me.CboLoai.TabIndex = 0
        '
        'LstVt
        '
        Me.LstVt.BackColor = System.Drawing.SystemColors.Window
        Me.LstVt.Cursor = System.Windows.Forms.Cursors.Default
        Me.LstVt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstVt.ItemHeight = 14
        Me.LstVt.Location = New System.Drawing.Point(8, 32)
        Me.LstVt.Name = "LstVt"
        Me.LstVt.Size = New System.Drawing.Size(297, 410)
        Me.LstVt.TabIndex = 1
        '
        'MedNgay
        '
        Me.MedNgay.AllowPromptAsInput = False
        Me.MedNgay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MedNgay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedNgay.Location = New System.Drawing.Point(384, 128)
        Me.MedNgay.Name = "MedNgay"
        Me.MedNgay.Size = New System.Drawing.Size(57, 13)
        Me.MedNgay.TabIndex = 10
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.White
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(328, 32)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(55, 17)
        Me._Label_1.TabIndex = 35
        Me._Label_1.Tag = "Code"
        Me._Label_1.Text = "Số hiệu"
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.White
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(328, 64)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(55, 17)
        Me._Label_2.TabIndex = 34
        Me._Label_2.Tag = "Name"
        Me._Label_2.Text = "Tên"
        '
        '_Line_0
        '
        Me._Line_0.Enabled = False
        Me._Line_0.Location = New System.Drawing.Point(384, 51)
        Me._Line_0.Name = "_Line_0"
        Me._Line_0.Size = New System.Drawing.Size(88, 1)
        Me._Line_0.TabIndex = 40
        '
        '_Line_1
        '
        Me._Line_1.Enabled = False
        Me._Line_1.Location = New System.Drawing.Point(384, 83)
        Me._Line_1.Name = "_Line_1"
        Me._Line_1.Size = New System.Drawing.Size(240, 1)
        Me._Line_1.TabIndex = 41
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.White
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_3.Location = New System.Drawing.Point(328, 96)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(55, 17)
        Me._Label_3.TabIndex = 33
        Me._Label_3.Tag = "Address"
        Me._Label_3.Text = "Địa chỉ"
        '
        '_Line_2
        '
        Me._Line_2.Enabled = False
        Me._Line_2.Location = New System.Drawing.Point(384, 115)
        Me._Line_2.Name = "_Line_2"
        Me._Line_2.Size = New System.Drawing.Size(240, 1)
        Me._Line_2.TabIndex = 42
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.White
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_10.Location = New System.Drawing.Point(328, 160)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(55, 17)
        Me._Label_10.TabIndex = 32
        Me._Label_10.Tag = "ID card"
        Me._Label_10.Text = "Số CMND"
        '
        '_Line_3
        '
        Me._Line_3.Enabled = False
        Me._Line_3.Location = New System.Drawing.Point(384, 179)
        Me._Line_3.Name = "_Line_3"
        Me._Line_3.Size = New System.Drawing.Size(88, 1)
        Me._Line_3.TabIndex = 43
        '
        '_Line_4
        '
        Me._Line_4.Enabled = False
        Me._Line_4.Location = New System.Drawing.Point(384, 211)
        Me._Line_4.Name = "_Line_4"
        Me._Line_4.Size = New System.Drawing.Size(88, 1)
        Me._Line_4.TabIndex = 44
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.White
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(328, 192)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(55, 17)
        Me._Label_0.TabIndex = 31
        Me._Label_0.Text = "Điện .T"
        '
        '_Line_5
        '
        Me._Line_5.Enabled = False
        Me._Line_5.Location = New System.Drawing.Point(536, 211)
        Me._Line_5.Name = "_Line_5"
        Me._Line_5.Size = New System.Drawing.Size(88, 1)
        Me._Line_5.TabIndex = 45
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.White
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_11.Location = New System.Drawing.Point(479, 192)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(51, 17)
        Me._Label_11.TabIndex = 30
        Me._Label_11.Text = "Điện .T 1"
        '
        '_Line_7
        '
        Me._Line_7.Enabled = False
        Me._Line_7.Location = New System.Drawing.Point(384, 243)
        Me._Line_7.Name = "_Line_7"
        Me._Line_7.Size = New System.Drawing.Size(88, 1)
        Me._Line_7.TabIndex = 46
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.White
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_13.Location = New System.Drawing.Point(328, 224)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(55, 17)
        Me._Label_13.TabIndex = 29
        Me._Label_13.Text = "Email"
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.Color.White
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_14.Location = New System.Drawing.Point(328, 128)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(55, 17)
        Me._Label_14.TabIndex = 28
        Me._Label_14.Tag = "Birth Date"
        Me._Label_14.Text = "Ngày sinh"
        '
        '_Line_9
        '
        Me._Line_9.Enabled = False
        Me._Line_9.Location = New System.Drawing.Point(384, 275)
        Me._Line_9.Name = "_Line_9"
        Me._Line_9.Size = New System.Drawing.Size(240, 1)
        Me._Line_9.TabIndex = 47
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.White
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_6.Location = New System.Drawing.Point(328, 256)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(55, 17)
        Me._Label_6.TabIndex = 27
        Me._Label_6.Tag = "Bank Acc."
        Me._Label_6.Text = "T.khoản"
        '
        '_Line_10
        '
        Me._Line_10.Enabled = False
        Me._Line_10.Location = New System.Drawing.Point(384, 411)
        Me._Line_10.Name = "_Line_10"
        Me._Line_10.Size = New System.Drawing.Size(240, 1)
        Me._Line_10.TabIndex = 48
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.White
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_7.Location = New System.Drawing.Point(328, 334)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(49, 17)
        Me._Label_7.TabIndex = 26
        Me._Label_7.Tag = "Notes"
        Me._Label_7.Text = "Ghi chú"
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.SystemColors.Window
        Me._Label_17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.Location = New System.Drawing.Point(312, 8)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(337, 433)
        Me._Label_17.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(384, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 1)
        Me.Label1.TabIndex = 49
        '
        'FrmNhanVien
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(657, 478)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SSCmdF)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me._txtVT_0)
        Me.Controls.Add(Me._txtVT_1)
        Me.Controls.Add(Me._txtVT_3)
        Me.Controls.Add(Me._txtVT_2)
        Me.Controls.Add(Me._txtVT_4)
        Me.Controls.Add(Me._txtVT_5)
        Me.Controls.Add(Me._txtVT_6)
        Me.Controls.Add(Me._txtVT_7)
        Me.Controls.Add(Me._txtVT_8)
        Me.Controls.Add(Me._SSOpt_2)
        Me.Controls.Add(Me._Command1_3)
        Me.Controls.Add(Me._Command1_2)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me.SSCmdF1)
        Me.Controls.Add(Me._SSOpt_1)
        Me.Controls.Add(Me._SSOpt_0)
        Me.Controls.Add(Me.CboLoai)
        Me.Controls.Add(Me.LstVt)
        Me.Controls.Add(Me.MedNgay)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Line_0)
        Me.Controls.Add(Me._Line_1)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Line_2)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Line_3)
        Me.Controls.Add(Me._Line_4)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Line_5)
        Me.Controls.Add(Me._Label_11)
        Me.Controls.Add(Me._Line_7)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me._Label_14)
        Me.Controls.Add(Me._Line_9)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Line_10)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_17)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(72, 67)
        Me.MaximizeBox = False
        Me.Name = "FrmNhanVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Danh sách Nhân viên bán hàng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializetxtVT()
		Me.txtVT(0) = _txtVT_0
		Me.txtVT(1) = _txtVT_1
		Me.txtVT(3) = _txtVT_3
		Me.txtVT(2) = _txtVT_2
		Me.txtVT(4) = _txtVT_4
		Me.txtVT(5) = _txtVT_5
		Me.txtVT(6) = _txtVT_6
		Me.txtVT(7) = _txtVT_7
		Me.txtVT(8) = _txtVT_8
	End Sub
	Sub InitializeSSOpt()
		Me.SSOpt(2) = _SSOpt_2
		Me.SSOpt(1) = _SSOpt_1
		Me.SSOpt(0) = _SSOpt_0
	End Sub
	Sub InitializeLine()
		Me.Line(0) = _Line_0
		Me.Line(1) = _Line_1
		Me.Line(2) = _Line_2
		Me.Line(3) = _Line_3
		Me.Line(4) = _Line_4
		Me.Line(5) = _Line_5
		Me.Line(7) = _Line_7
		Me.Line(9) = _Line_9
		Me.Line(10) = _Line_10
	End Sub
	Sub InitializeLabel()
		Me.Label(1) = _Label_1
		Me.Label(2) = _Label_2
		Me.Label(3) = _Label_3
		Me.Label(10) = _Label_10
		Me.Label(0) = _Label_0
		Me.Label(11) = _Label_11
		Me.Label(13) = _Label_13
		Me.Label(14) = _Label_14
		Me.Label(6) = _Label_6
		Me.Label(7) = _Label_7
		Me.Label(17) = _Label_17
        'Me.Label(5) = _Label_5
        'Me.Label(4) = _Label_4
        'Me.Label(9) = _Label_9
	End Sub
	Sub InitializeCommand1()
		Me.Command1(3) = _Command1_3
		Me.Command1(2) = _Command1_2
		Me.Command1(1) = _Command1_1
		Me.Command1(0) = _Command1_0
	End Sub
	Sub InitializeCommand()
		Me.Command(0) = _Command_0
		Me.Command(1) = _Command_1
		Me.Command(2) = _Command_2
		Me.Command(3) = _Command_3
    End Sub
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
#End Region 
End Class
