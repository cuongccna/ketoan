<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKhachHang
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializetxtVT()
		InitializeSSOpt()
		InitializeLine()
		InitializeLbTon()
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
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Public WithEvents txtF As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_0 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_10 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_3 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_4 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_5 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_6 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_7 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_8 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_9 As System.Windows.Forms.TextBox
    Private WithEvents _SSOpt_2 As System.Windows.Forms.RadioButton
    Public WithEvents CboNT As ComboBoxEx.ComboBoxExt
    Private WithEvents _Command1_3 As System.Windows.Forms.Button
    Private WithEvents _Command1_2 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Private WithEvents _SSOpt_1 As System.Windows.Forms.RadioButton
    Private WithEvents _SSOpt_0 As System.Windows.Forms.RadioButton
    Public WithEvents CboLoai As ComboBoxEx.ComboBoxExt
    Public WithEvents LstVt As System.Windows.Forms.ListBox
    Private WithEvents _Command_4 As System.Windows.Forms.Button
    Private WithEvents _Command_5 As System.Windows.Forms.Button
    Private WithEvents _Command_6 As System.Windows.Forms.Button
    Private WithEvents _Label_19 As System.Windows.Forms.Label
    Private WithEvents _Label_18 As System.Windows.Forms.Label
    Private WithEvents _LbTon_2 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Line_0 As System.Windows.Forms.Label
    Private WithEvents _Line_1 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _LbTon_0 As System.Windows.Forms.Label
    Private WithEvents _Line_2 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _Line_6 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Line_3 As System.Windows.Forms.Label
    Private WithEvents _Line_4 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Line_5 As System.Windows.Forms.Label
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Line_7 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _Line_8 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Private WithEvents _Line_9 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Line_10 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_15 As System.Windows.Forms.Label
    Private WithEvents _Label_16 As System.Windows.Forms.Label
    Private WithEvents _LbTon_1 As System.Windows.Forms.Label
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Public Command(6) As System.Windows.Forms.Button
    Public Command1(3) As System.Windows.Forms.Button
    Public Label(19) As System.Windows.Forms.Label
    Public LbTon(2) As System.Windows.Forms.Label
    Public Line(10) As System.Windows.Forms.Label
    Public SSOpt(2) As System.Windows.Forms.RadioButton
    Public txtVT(10) As System.Windows.Forms.TextBox
    'Private listBoxHelper1 As Artinsoft.VB6.Gui.ListBoxHelper
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKhachHang))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.SSCmdF = New System.Windows.Forms.Button
        Me.txtF = New System.Windows.Forms.TextBox
        Me._txtVT_0 = New System.Windows.Forms.TextBox
        Me._txtVT_1 = New System.Windows.Forms.TextBox
        Me._txtVT_10 = New System.Windows.Forms.TextBox
        Me._txtVT_3 = New System.Windows.Forms.TextBox
        Me._txtVT_2 = New System.Windows.Forms.TextBox
        Me._txtVT_4 = New System.Windows.Forms.TextBox
        Me._txtVT_5 = New System.Windows.Forms.TextBox
        Me._txtVT_6 = New System.Windows.Forms.TextBox
        Me._txtVT_7 = New System.Windows.Forms.TextBox
        Me._txtVT_8 = New System.Windows.Forms.TextBox
        Me._txtVT_9 = New System.Windows.Forms.TextBox
        Me._SSOpt_2 = New System.Windows.Forms.RadioButton
        Me.CboNT = New ComboBoxEx.ComboBoxExt
        Me._SSOpt_1 = New System.Windows.Forms.RadioButton
        Me._SSOpt_0 = New System.Windows.Forms.RadioButton
        Me.CboLoai = New ComboBoxEx.ComboBoxExt
        Me.LstVt = New System.Windows.Forms.ListBox
        Me._Label_19 = New System.Windows.Forms.Label
        Me._Label_18 = New System.Windows.Forms.Label
        Me._LbTon_2 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Line_0 = New System.Windows.Forms.Label
        Me._Line_1 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._LbTon_0 = New System.Windows.Forms.Label
        Me._Line_2 = New System.Windows.Forms.Label
        Me._Label_12 = New System.Windows.Forms.Label
        Me._Line_6 = New System.Windows.Forms.Label
        Me._Label_10 = New System.Windows.Forms.Label
        Me._Line_3 = New System.Windows.Forms.Label
        Me._Line_4 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Line_5 = New System.Windows.Forms.Label
        Me._Label_11 = New System.Windows.Forms.Label
        Me._Line_7 = New System.Windows.Forms.Label
        Me._Label_13 = New System.Windows.Forms.Label
        Me._Line_8 = New System.Windows.Forms.Label
        Me._Label_14 = New System.Windows.Forms.Label
        Me._Line_9 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Line_10 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Label_15 = New System.Windows.Forms.Label
        Me._Label_16 = New System.Windows.Forms.Label
        Me._LbTon_1 = New System.Windows.Forms.Label
        Me._Label_17 = New System.Windows.Forms.Label
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Command1_3 = New System.Windows.Forms.Button
        Me._Command1_2 = New System.Windows.Forms.Button
        Me._Command1_1 = New System.Windows.Forms.Button
        Me._Command1_0 = New System.Windows.Forms.Button
        Me._Command_4 = New System.Windows.Forms.Button
        Me._Command_5 = New System.Windows.Forms.Button
        Me._Command_6 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'SSCmdF
        '
        Me.SSCmdF.Location = New System.Drawing.Point(288, 434)
        Me.SSCmdF.Name = "SSCmdF"
        Me.SSCmdF.Size = New System.Drawing.Size(18, 19)
        Me.SSCmdF.TabIndex = 6
        Me.SSCmdF.Text = "*"
        '
        'txtF
        '
        Me.txtF.AcceptsReturn = True
        Me.txtF.BackColor = System.Drawing.SystemColors.Window
        Me.txtF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF.Location = New System.Drawing.Point(199, 434)
        Me.txtF.MaxLength = 0
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(82, 20)
        Me.txtF.TabIndex = 5
        '
        '_txtVT_0
        '
        Me._txtVT_0.AcceptsReturn = True
        Me._txtVT_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_0.Location = New System.Drawing.Point(384, 32)
        Me._txtVT_0.MaxLength = 20
        Me._txtVT_0.Name = "_txtVT_0"
        Me._txtVT_0.Size = New System.Drawing.Size(121, 13)
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
        Me._txtVT_1.MaxLength = 250
        Me._txtVT_1.Name = "_txtVT_1"
        Me._txtVT_1.Size = New System.Drawing.Size(297, 13)
        Me._txtVT_1.TabIndex = 8
        Me._txtVT_1.Text = "..."
        '
        '_txtVT_10
        '
        Me._txtVT_10.AcceptsReturn = True
        Me._txtVT_10.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_10.Location = New System.Drawing.Point(416, 288)
        Me._txtVT_10.MaxLength = 20
        Me._txtVT_10.Multiline = True
        Me._txtVT_10.Name = "_txtVT_10"
        Me._txtVT_10.Size = New System.Drawing.Size(105, 19)
        Me._txtVT_10.TabIndex = 16
        Me._txtVT_10.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._txtVT_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_3
        '
        Me._txtVT_3.AcceptsReturn = True
        Me._txtVT_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_3.Location = New System.Drawing.Point(384, 128)
        Me._txtVT_3.MaxLength = 20
        Me._txtVT_3.Name = "_txtVT_3"
        Me._txtVT_3.Size = New System.Drawing.Size(121, 13)
        Me._txtVT_3.TabIndex = 10
        '
        '_txtVT_2
        '
        Me._txtVT_2.AcceptsReturn = True
        Me._txtVT_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_2.Location = New System.Drawing.Point(384, 96)
        Me._txtVT_2.MaxLength = 250
        Me._txtVT_2.Name = "_txtVT_2"
        Me._txtVT_2.Size = New System.Drawing.Size(297, 13)
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
        Me._txtVT_4.Location = New System.Drawing.Point(384, 160)
        Me._txtVT_4.MaxLength = 50
        Me._txtVT_4.Name = "_txtVT_4"
        Me._txtVT_4.Size = New System.Drawing.Size(121, 13)
        Me._txtVT_4.TabIndex = 11
        Me._txtVT_4.Text = "..."
        '
        '_txtVT_5
        '
        Me._txtVT_5.AcceptsReturn = True
        Me._txtVT_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_5.Location = New System.Drawing.Point(560, 160)
        Me._txtVT_5.MaxLength = 50
        Me._txtVT_5.Name = "_txtVT_5"
        Me._txtVT_5.Size = New System.Drawing.Size(121, 13)
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
        Me._txtVT_6.Location = New System.Drawing.Point(384, 192)
        Me._txtVT_6.MaxLength = 50
        Me._txtVT_6.Name = "_txtVT_6"
        Me._txtVT_6.Size = New System.Drawing.Size(121, 13)
        Me._txtVT_6.TabIndex = 12
        Me._txtVT_6.Text = "..."
        '
        '_txtVT_7
        '
        Me._txtVT_7.AcceptsReturn = True
        Me._txtVT_7.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_7.Location = New System.Drawing.Point(384, 224)
        Me._txtVT_7.MaxLength = 100
        Me._txtVT_7.Name = "_txtVT_7"
        Me._txtVT_7.Size = New System.Drawing.Size(297, 13)
        Me._txtVT_7.TabIndex = 14
        Me._txtVT_7.Text = "..."
        '
        '_txtVT_8
        '
        Me._txtVT_8.AcceptsReturn = True
        Me._txtVT_8.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_8.Location = New System.Drawing.Point(384, 256)
        Me._txtVT_8.MaxLength = 100
        Me._txtVT_8.Name = "_txtVT_8"
        Me._txtVT_8.Size = New System.Drawing.Size(297, 13)
        Me._txtVT_8.TabIndex = 15
        Me._txtVT_8.Text = "..."
        '
        '_txtVT_9
        '
        Me._txtVT_9.AcceptsReturn = True
        Me._txtVT_9.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_9.Location = New System.Drawing.Point(384, 392)
        Me._txtVT_9.MaxLength = 100
        Me._txtVT_9.Name = "_txtVT_9"
        Me._txtVT_9.Size = New System.Drawing.Size(297, 13)
        Me._txtVT_9.TabIndex = 18
        Me._txtVT_9.Text = "..."
        '
        '_SSOpt_2
        '
        Me._SSOpt_2.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_2.Location = New System.Drawing.Point(136, 435)
        Me._SSOpt_2.Name = "_SSOpt_2"
        Me._SSOpt_2.Size = New System.Drawing.Size(72, 17)
        Me._SSOpt_2.TabIndex = 4
        Me._SSOpt_2.TabStop = True
        Me._SSOpt_2.Tag = "T. Code"
        Me._SSOpt_2.Text = "MST"
        Me._SSOpt_2.UseVisualStyleBackColor = False
        '
        'CboNT
        '
        Me.CboNT.BackColor = System.Drawing.SystemColors.Window
        Me.CboNT.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboNT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboNT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboNT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboNT.Location = New System.Drawing.Point(552, 304)
        Me.CboNT.Name = "CboNT"
        Me.CboNT.Size = New System.Drawing.Size(89, 21)
        Me.CboNT.TabIndex = 17
        '
        '_SSOpt_1
        '
        Me._SSOpt_1.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_1.Location = New System.Drawing.Point(72, 435)
        Me._SSOpt_1.Name = "_SSOpt_1"
        Me._SSOpt_1.Size = New System.Drawing.Size(63, 17)
        Me._SSOpt_1.TabIndex = 3
        Me._SSOpt_1.TabStop = True
        Me._SSOpt_1.Tag = "Name"
        Me._SSOpt_1.Text = "Tên KH"
        Me._SSOpt_1.UseVisualStyleBackColor = False
        '
        '_SSOpt_0
        '
        Me._SSOpt_0.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_0.Checked = True
        Me._SSOpt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_0.Location = New System.Drawing.Point(8, 435)
        Me._SSOpt_0.Name = "_SSOpt_0"
        Me._SSOpt_0.Size = New System.Drawing.Size(62, 17)
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
        Me.LstVt.Size = New System.Drawing.Size(297, 396)
        Me.LstVt.TabIndex = 1
        '
        '_Label_19
        '
        Me._Label_19.BackColor = System.Drawing.Color.White
        Me._Label_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_19.Location = New System.Drawing.Point(536, 344)
        Me._Label_19.Name = "_Label_19"
        Me._Label_19.Size = New System.Drawing.Size(47, 17)
        Me._Label_19.TabIndex = 53
        Me._Label_19.Tag = "Current Balance"
        Me._Label_19.Text = "Dư có"
        '
        '_Label_18
        '
        Me._Label_18.BackColor = System.Drawing.Color.White
        Me._Label_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_18.Location = New System.Drawing.Point(352, 344)
        Me._Label_18.Name = "_Label_18"
        Me._Label_18.Size = New System.Drawing.Size(41, 17)
        Me._Label_18.TabIndex = 52
        Me._Label_18.Tag = "Current Balance"
        Me._Label_18.Text = "Dư nợ"
        '
        '_LbTon_2
        '
        Me._LbTon_2.BackColor = System.Drawing.Color.White
        Me._LbTon_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTon_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTon_2.ForeColor = System.Drawing.Color.Blue
        Me._LbTon_2.Location = New System.Drawing.Point(416, 368)
        Me._LbTon_2.Name = "_LbTon_2"
        Me._LbTon_2.Size = New System.Drawing.Size(105, 17)
        Me._LbTon_2.TabIndex = 51
        Me._LbTon_2.Text = "0"
        Me._LbTon_2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.White
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(328, 32)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(49, 17)
        Me._Label_1.TabIndex = 50
        Me._Label_1.Tag = "Code"
        Me._Label_1.Text = "Mã KH"
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.White
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(328, 64)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(57, 17)
        Me._Label_2.TabIndex = 49
        Me._Label_2.Tag = "Name"
        Me._Label_2.Text = "Tên KH"
        '
        '_Line_0
        '
        Me._Line_0.Enabled = False
        Me._Line_0.Location = New System.Drawing.Point(384, 51)
        Me._Line_0.Name = "_Line_0"
        Me._Line_0.Size = New System.Drawing.Size(120, 1)
        Me._Line_0.TabIndex = 54
        '
        '_Line_1
        '
        Me._Line_1.Enabled = False
        Me._Line_1.Location = New System.Drawing.Point(384, 83)
        Me._Line_1.Name = "_Line_1"
        Me._Line_1.Size = New System.Drawing.Size(296, 1)
        Me._Line_1.TabIndex = 55
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.White
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_3.Location = New System.Drawing.Point(328, 96)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(41, 17)
        Me._Label_3.TabIndex = 48
        Me._Label_3.Tag = "Address"
        Me._Label_3.Text = "Địa chỉ"
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.White
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_8.Location = New System.Drawing.Point(328, 320)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(81, 17)
        Me._Label_8.TabIndex = 47
        Me._Label_8.Tag = "Current Balance"
        Me._Label_8.Text = "Số dư hiện thời"
        '
        '_LbTon_0
        '
        Me._LbTon_0.BackColor = System.Drawing.Color.White
        Me._LbTon_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTon_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTon_0.ForeColor = System.Drawing.Color.Blue
        Me._LbTon_0.Location = New System.Drawing.Point(416, 344)
        Me._LbTon_0.Name = "_LbTon_0"
        Me._LbTon_0.Size = New System.Drawing.Size(105, 17)
        Me._LbTon_0.TabIndex = 46
        Me._LbTon_0.Text = "0"
        Me._LbTon_0.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Line_2
        '
        Me._Line_2.Enabled = False
        Me._Line_2.Location = New System.Drawing.Point(384, 115)
        Me._Line_2.Name = "_Line_2"
        Me._Line_2.Size = New System.Drawing.Size(296, 1)
        Me._Line_2.TabIndex = 56
        '
        '_Label_12
        '
        Me._Label_12.BackColor = System.Drawing.Color.White
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_12.Location = New System.Drawing.Point(328, 288)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.Size = New System.Drawing.Size(81, 17)
        Me._Label_12.TabIndex = 45
        Me._Label_12.Tag = "Credit"
        Me._Label_12.Text = "Số dư tối đa"
        '
        '_Line_6
        '
        Me._Line_6.Enabled = False
        Me._Line_6.Location = New System.Drawing.Point(416, 307)
        Me._Line_6.Name = "_Line_6"
        Me._Line_6.Size = New System.Drawing.Size(104, 1)
        Me._Line_6.TabIndex = 57
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.White
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_10.Location = New System.Drawing.Point(328, 128)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(49, 17)
        Me._Label_10.TabIndex = 44
        Me._Label_10.Tag = "Tax Code"
        Me._Label_10.Text = "MS Thuế"
        '
        '_Line_3
        '
        Me._Line_3.Enabled = False
        Me._Line_3.Location = New System.Drawing.Point(384, 147)
        Me._Line_3.Name = "_Line_3"
        Me._Line_3.Size = New System.Drawing.Size(120, 1)
        Me._Line_3.TabIndex = 58
        '
        '_Line_4
        '
        Me._Line_4.Enabled = False
        Me._Line_4.Location = New System.Drawing.Point(384, 179)
        Me._Line_4.Name = "_Line_4"
        Me._Line_4.Size = New System.Drawing.Size(120, 1)
        Me._Line_4.TabIndex = 59
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.White
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(328, 160)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(25, 17)
        Me._Label_0.TabIndex = 43
        Me._Label_0.Text = "Tel"
        '
        '_Line_5
        '
        Me._Line_5.Enabled = False
        Me._Line_5.Location = New System.Drawing.Point(560, 179)
        Me._Line_5.Name = "_Line_5"
        Me._Line_5.Size = New System.Drawing.Size(120, 1)
        Me._Line_5.TabIndex = 60
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.White
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_11.Location = New System.Drawing.Point(528, 160)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(25, 17)
        Me._Label_11.TabIndex = 42
        Me._Label_11.Text = "Fax"
        '
        '_Line_7
        '
        Me._Line_7.Enabled = False
        Me._Line_7.Location = New System.Drawing.Point(384, 211)
        Me._Line_7.Name = "_Line_7"
        Me._Line_7.Size = New System.Drawing.Size(120, 1)
        Me._Line_7.TabIndex = 61
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.White
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_13.Location = New System.Drawing.Point(328, 192)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(41, 17)
        Me._Label_13.TabIndex = 41
        Me._Label_13.Text = "Email"
        '
        '_Line_8
        '
        Me._Line_8.Enabled = False
        Me._Line_8.Location = New System.Drawing.Point(384, 243)
        Me._Line_8.Name = "_Line_8"
        Me._Line_8.Size = New System.Drawing.Size(296, 1)
        Me._Line_8.TabIndex = 62
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.Color.White
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_14.Location = New System.Drawing.Point(328, 224)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(57, 17)
        Me._Label_14.TabIndex = 40
        Me._Label_14.Tag = "Representative"
        Me._Label_14.Text = "Đại diện"
        '
        '_Line_9
        '
        Me._Line_9.Enabled = False
        Me._Line_9.Location = New System.Drawing.Point(384, 275)
        Me._Line_9.Name = "_Line_9"
        Me._Line_9.Size = New System.Drawing.Size(296, 1)
        Me._Line_9.TabIndex = 63
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.White
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_6.Location = New System.Drawing.Point(328, 256)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(49, 17)
        Me._Label_6.TabIndex = 39
        Me._Label_6.Tag = "Bank Acc."
        Me._Label_6.Text = "T.khoản"
        '
        '_Line_10
        '
        Me._Line_10.Enabled = False
        Me._Line_10.Location = New System.Drawing.Point(384, 411)
        Me._Line_10.Name = "_Line_10"
        Me._Line_10.Size = New System.Drawing.Size(296, 1)
        Me._Line_10.TabIndex = 64
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.White
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_7.Location = New System.Drawing.Point(328, 392)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(49, 17)
        Me._Label_7.TabIndex = 38
        Me._Label_7.Tag = "Notes"
        Me._Label_7.Text = "Ghi chú"
        '
        '_Label_15
        '
        Me._Label_15.BackColor = System.Drawing.Color.White
        Me._Label_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_15.Location = New System.Drawing.Point(536, 288)
        Me._Label_15.Name = "_Label_15"
        Me._Label_15.Size = New System.Drawing.Size(73, 17)
        Me._Label_15.TabIndex = 37
        Me._Label_15.Tag = "by Currency"
        Me._Label_15.Text = "Theo dõi bằng"
        '
        '_Label_16
        '
        Me._Label_16.BackColor = System.Drawing.Color.White
        Me._Label_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_16.Location = New System.Drawing.Point(352, 368)
        Me._Label_16.Name = "_Label_16"
        Me._Label_16.Size = New System.Drawing.Size(57, 17)
        Me._Label_16.TabIndex = 36
        Me._Label_16.Tag = "F. Currency"
        Me._Label_16.Text = "Nguyên tệ"
        '
        '_LbTon_1
        '
        Me._LbTon_1.BackColor = System.Drawing.Color.White
        Me._LbTon_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTon_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTon_1.ForeColor = System.Drawing.Color.Blue
        Me._LbTon_1.Location = New System.Drawing.Point(576, 344)
        Me._LbTon_1.Name = "_LbTon_1"
        Me._LbTon_1.Size = New System.Drawing.Size(105, 17)
        Me._LbTon_1.TabIndex = 35
        Me._LbTon_1.Text = "0"
        Me._LbTon_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.Color.White
        Me._Label_17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.Location = New System.Drawing.Point(312, 8)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(389, 420)
        Me._Label_17.TabIndex = 34
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(628, 460)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 25
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        Me._Command_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(468, 460)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 23
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        Me._Command_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(388, 460)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 22
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        Me._Command_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.add16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(308, 460)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 21
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        Me._Command_0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command1_3
        '
        Me._Command1_3.BackColor = System.Drawing.Color.Silver
        Me._Command1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_3.Image = CType(resources.GetObject("_Command1_3.Image"), System.Drawing.Image)
        Me._Command1_3.Location = New System.Drawing.Point(628, 460)
        Me._Command1_3.Name = "_Command1_3"
        Me._Command1_3.Size = New System.Drawing.Size(73, 25)
        Me._Command1_3.TabIndex = 28
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
        Me._Command1_2.Location = New System.Drawing.Point(468, 460)
        Me._Command1_2.Name = "_Command1_2"
        Me._Command1_2.Size = New System.Drawing.Size(73, 25)
        Me._Command1_2.TabIndex = 33
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
        Me._Command1_1.Location = New System.Drawing.Point(388, 460)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(73, 25)
        Me._Command1_1.TabIndex = 26
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
        Me._Command1_0.Location = New System.Drawing.Point(308, 460)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(73, 25)
        Me._Command1_0.TabIndex = 27
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&Add"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        '_Command_4
        '
        Me._Command_4.Image = Global.UNET.My.Resources.Resources.money16
        Me._Command_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_4.Location = New System.Drawing.Point(548, 460)
        Me._Command_4.Name = "_Command_4"
        Me._Command_4.Size = New System.Drawing.Size(73, 25)
        Me._Command_4.TabIndex = 24
        Me._Command_4.Tag = "Prict table"
        Me._Command_4.Text = "Giá &bán"
        Me._Command_4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_5
        '
        Me._Command_5.Image = CType(resources.GetObject("_Command_5.Image"), System.Drawing.Image)
        Me._Command_5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_5.Location = New System.Drawing.Point(4, 460)
        Me._Command_5.Name = "_Command_5"
        Me._Command_5.Size = New System.Drawing.Size(113, 25)
        Me._Command_5.TabIndex = 19
        Me._Command_5.Tag = "Excel Imp. "
        Me._Command_5.Text = "&Nhập từ Excel"
        Me._Command_5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_6
        '
        Me._Command_6.Image = CType(resources.GetObject("_Command_6.Image"), System.Drawing.Image)
        Me._Command_6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_6.Location = New System.Drawing.Point(124, 460)
        Me._Command_6.Name = "_Command_6"
        Me._Command_6.Size = New System.Drawing.Size(113, 25)
        Me._Command_6.TabIndex = 20
        Me._Command_6.Tag = "Excel Exp."
        Me._Command_6.Text = "Xuất ra &Excel"
        Me._Command_6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmKhachHang
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(713, 487)
        Me.Controls.Add(Me.SSCmdF)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me._txtVT_0)
        Me.Controls.Add(Me._txtVT_1)
        Me.Controls.Add(Me._txtVT_10)
        Me.Controls.Add(Me._txtVT_3)
        Me.Controls.Add(Me._txtVT_2)
        Me.Controls.Add(Me._txtVT_4)
        Me.Controls.Add(Me._txtVT_5)
        Me.Controls.Add(Me._txtVT_6)
        Me.Controls.Add(Me._txtVT_7)
        Me.Controls.Add(Me._txtVT_8)
        Me.Controls.Add(Me._txtVT_9)
        Me.Controls.Add(Me._SSOpt_2)
        Me.Controls.Add(Me.CboNT)
        Me.Controls.Add(Me._Command1_3)
        Me.Controls.Add(Me._Command1_2)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me._SSOpt_1)
        Me.Controls.Add(Me._SSOpt_0)
        Me.Controls.Add(Me.CboLoai)
        Me.Controls.Add(Me.LstVt)
        Me.Controls.Add(Me._Command_4)
        Me.Controls.Add(Me._Command_5)
        Me.Controls.Add(Me._Command_6)
        Me.Controls.Add(Me._Label_19)
        Me.Controls.Add(Me._Label_18)
        Me.Controls.Add(Me._LbTon_2)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Line_0)
        Me.Controls.Add(Me._Line_1)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._LbTon_0)
        Me.Controls.Add(Me._Line_2)
        Me.Controls.Add(Me._Label_12)
        Me.Controls.Add(Me._Line_6)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Line_3)
        Me.Controls.Add(Me._Line_4)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Line_5)
        Me.Controls.Add(Me._Label_11)
        Me.Controls.Add(Me._Line_7)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me._Line_8)
        Me.Controls.Add(Me._Label_14)
        Me.Controls.Add(Me._Line_9)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Line_10)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_15)
        Me.Controls.Add(Me._Label_16)
        Me.Controls.Add(Me._LbTon_1)
        Me.Controls.Add(Me._Label_17)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(72, 67)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmKhachHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Danh sách khách hàng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
	Sub InitializetxtVT()
		Me.txtVT(0) = _txtVT_0
		Me.txtVT(1) = _txtVT_1
		Me.txtVT(10) = _txtVT_10
		Me.txtVT(3) = _txtVT_3
		Me.txtVT(2) = _txtVT_2
		Me.txtVT(4) = _txtVT_4
		Me.txtVT(5) = _txtVT_5
		Me.txtVT(6) = _txtVT_6
		Me.txtVT(7) = _txtVT_7
		Me.txtVT(8) = _txtVT_8
		Me.txtVT(9) = _txtVT_9
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
		Me.Line(6) = _Line_6
		Me.Line(3) = _Line_3
		Me.Line(4) = _Line_4
		Me.Line(5) = _Line_5
		Me.Line(7) = _Line_7
		Me.Line(8) = _Line_8
		Me.Line(9) = _Line_9
		Me.Line(10) = _Line_10
	End Sub
	Sub InitializeLbTon()
		Me.LbTon(2) = _LbTon_2
		Me.LbTon(0) = _LbTon_0
		Me.LbTon(1) = _LbTon_1
	End Sub
	Sub InitializeLabel()
		Me.Label(19) = _Label_19
		Me.Label(18) = _Label_18
		Me.Label(1) = _Label_1
		Me.Label(2) = _Label_2
		Me.Label(3) = _Label_3
		Me.Label(8) = _Label_8
		Me.Label(12) = _Label_12
		Me.Label(10) = _Label_10
		Me.Label(0) = _Label_0
		Me.Label(11) = _Label_11
		Me.Label(13) = _Label_13
		Me.Label(14) = _Label_14
		Me.Label(6) = _Label_6
		Me.Label(7) = _Label_7
		Me.Label(15) = _Label_15
		Me.Label(16) = _Label_16
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
		Me.Command(3) = _Command_3
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
		Me.Command(4) = _Command_4
		Me.Command(5) = _Command_5
		Me.Command(6) = _Command_6
	End Sub
#End Region 
End Class
