<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGiaVTKH
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeTxtVT()
		InitializeSSOpt()
		InitializeLine()
		InitializeLabel()
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
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _TxtVT_7 As System.Windows.Forms.TextBox
    Private WithEvents _TxtVT_6 As System.Windows.Forms.TextBox
    Private WithEvents _TxtVT_5 As System.Windows.Forms.TextBox
    Private WithEvents _TxtVT_4 As System.Windows.Forms.TextBox
    Private WithEvents _TxtVT_2 As System.Windows.Forms.TextBox
    Private WithEvents _TxtVT_3 As System.Windows.Forms.TextBox
    Public WithEvents LstVt As System.Windows.Forms.ListBox
    Public WithEvents CboLoai As ComboBoxEx.ComboBoxExt
    Public WithEvents txtF As System.Windows.Forms.TextBox
    Private WithEvents _SSOpt_0 As System.Windows.Forms.RadioButton
    Private WithEvents _SSOpt_1 As System.Windows.Forms.RadioButton
    Public WithEvents SSCmdF1 As System.Windows.Forms.Button
    Private WithEvents _TxtVT_1 As System.Windows.Forms.TextBox
    Private WithEvents _TxtVT_0 As System.Windows.Forms.TextBox
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Line_7 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Line_6 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Line_2 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Line_5 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Line_4 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Line_3 As System.Windows.Forms.Label
    Private WithEvents _Line_1 As System.Windows.Forms.Label
    Private WithEvents _Line_0 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Public Command(3) As System.Windows.Forms.Button
    Public Label(14) As System.Windows.Forms.Label
    Public Line(7) As System.Windows.Forms.Label
    Public SSOpt(1) As System.Windows.Forms.RadioButton
    Public TxtVT(7) As System.Windows.Forms.TextBox
    'Private listBoxHelper1 As Artinsoft.VB6.Gui.ListBoxHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_0 = New System.Windows.Forms.Button()
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._Command_2 = New System.Windows.Forms.Button()
        Me._Command_3 = New System.Windows.Forms.Button()
        Me._TxtVT_7 = New System.Windows.Forms.TextBox()
        Me._TxtVT_6 = New System.Windows.Forms.TextBox()
        Me._TxtVT_5 = New System.Windows.Forms.TextBox()
        Me._TxtVT_4 = New System.Windows.Forms.TextBox()
        Me._TxtVT_2 = New System.Windows.Forms.TextBox()
        Me._TxtVT_3 = New System.Windows.Forms.TextBox()
        Me.LstVt = New System.Windows.Forms.ListBox()
        Me.CboLoai = New ComboBoxEx.ComboBoxExt()
        Me.txtF = New System.Windows.Forms.TextBox()
        Me._SSOpt_0 = New System.Windows.Forms.RadioButton()
        Me._SSOpt_1 = New System.Windows.Forms.RadioButton()
        Me.SSCmdF1 = New System.Windows.Forms.Button()
        Me._TxtVT_1 = New System.Windows.Forms.TextBox()
        Me._TxtVT_0 = New System.Windows.Forms.TextBox()
        Me._Label_10 = New System.Windows.Forms.Label()
        Me._Line_7 = New System.Windows.Forms.Label()
        Me._Label_8 = New System.Windows.Forms.Label()
        Me._Line_6 = New System.Windows.Forms.Label()
        Me._Label_3 = New System.Windows.Forms.Label()
        Me._Line_2 = New System.Windows.Forms.Label()
        Me._Label_7 = New System.Windows.Forms.Label()
        Me._Line_5 = New System.Windows.Forms.Label()
        Me._Label_6 = New System.Windows.Forms.Label()
        Me._Line_4 = New System.Windows.Forms.Label()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me._Line_3 = New System.Windows.Forms.Label()
        Me._Line_1 = New System.Windows.Forms.Label()
        Me._Line_0 = New System.Windows.Forms.Label()
        Me._Label_2 = New System.Windows.Forms.Label()
        Me._Label_1 = New System.Windows.Forms.Label()
        Me._Label_4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        '_Command_0
        '
        Me._Command_0.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Add
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(344, 288)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 26
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Save
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(424, 288)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 27
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_2
        '
        Me._Command_2.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Xoa
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(504, 288)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 28
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_3
        '
        Me._Command_3.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(584, 288)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 29
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_TxtVT_7
        '
        Me._TxtVT_7.AcceptsReturn = True
        Me._TxtVT_7.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_7.Location = New System.Drawing.Point(408, 192)
        Me._TxtVT_7.MaxLength = 20
        Me._TxtVT_7.Name = "_TxtVT_7"
        Me._TxtVT_7.Size = New System.Drawing.Size(129, 13)
        Me._TxtVT_7.TabIndex = 13
        '
        '_TxtVT_6
        '
        Me._TxtVT_6.AcceptsReturn = True
        Me._TxtVT_6.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_6.Location = New System.Drawing.Point(408, 168)
        Me._TxtVT_6.MaxLength = 20
        Me._TxtVT_6.Name = "_TxtVT_6"
        Me._TxtVT_6.Size = New System.Drawing.Size(129, 13)
        Me._TxtVT_6.TabIndex = 12
        '
        '_TxtVT_5
        '
        Me._TxtVT_5.AcceptsReturn = True
        Me._TxtVT_5.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_5.Location = New System.Drawing.Point(408, 144)
        Me._TxtVT_5.MaxLength = 20
        Me._TxtVT_5.Name = "_TxtVT_5"
        Me._TxtVT_5.Size = New System.Drawing.Size(129, 13)
        Me._TxtVT_5.TabIndex = 11
        '
        '_TxtVT_4
        '
        Me._TxtVT_4.AcceptsReturn = True
        Me._TxtVT_4.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_4.Location = New System.Drawing.Point(408, 120)
        Me._TxtVT_4.MaxLength = 20
        Me._TxtVT_4.Name = "_TxtVT_4"
        Me._TxtVT_4.Size = New System.Drawing.Size(129, 13)
        Me._TxtVT_4.TabIndex = 10
        '
        '_TxtVT_2
        '
        Me._TxtVT_2.AcceptsReturn = True
        Me._TxtVT_2.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_2.Location = New System.Drawing.Point(408, 72)
        Me._TxtVT_2.MaxLength = 20
        Me._TxtVT_2.Name = "_TxtVT_2"
        Me._TxtVT_2.Size = New System.Drawing.Size(129, 13)
        Me._TxtVT_2.TabIndex = 8
        '
        '_TxtVT_3
        '
        Me._TxtVT_3.AcceptsReturn = True
        Me._TxtVT_3.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_3.Location = New System.Drawing.Point(408, 96)
        Me._TxtVT_3.MaxLength = 20
        Me._TxtVT_3.Name = "_TxtVT_3"
        Me._TxtVT_3.Size = New System.Drawing.Size(233, 13)
        Me._TxtVT_3.TabIndex = 9
        '
        'LstVt
        '
        Me.LstVt.BackColor = System.Drawing.SystemColors.Window
        Me.LstVt.Cursor = System.Windows.Forms.Cursors.Default
        Me.LstVt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstVt.ItemHeight = 14
        Me.LstVt.Location = New System.Drawing.Point(8, 32)
        Me.LstVt.Name = "LstVt"
        Me.LstVt.Size = New System.Drawing.Size(313, 242)
        Me.LstVt.TabIndex = 1
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
        Me.CboLoai.Size = New System.Drawing.Size(313, 21)
        Me.CboLoai.TabIndex = 0
        '
        'txtF
        '
        Me.txtF.AcceptsReturn = True
        Me.txtF.BackColor = System.Drawing.SystemColors.Window
        Me.txtF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF.Location = New System.Drawing.Point(152, 296)
        Me.txtF.MaxLength = 0
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(145, 20)
        Me.txtF.TabIndex = 4
        '
        '_SSOpt_0
        '
        Me._SSOpt_0.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_0.Checked = True
        Me._SSOpt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_0.Location = New System.Drawing.Point(8, 296)
        Me._SSOpt_0.Name = "_SSOpt_0"
        Me._SSOpt_0.Size = New System.Drawing.Size(73, 17)
        Me._SSOpt_0.TabIndex = 2
        Me._SSOpt_0.TabStop = True
        Me._SSOpt_0.Tag = "Code"
        Me._SSOpt_0.Text = "Số hiệu"
        Me._SSOpt_0.UseVisualStyleBackColor = False
        '
        '_SSOpt_1
        '
        Me._SSOpt_1.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_1.Location = New System.Drawing.Point(80, 296)
        Me._SSOpt_1.Name = "_SSOpt_1"
        Me._SSOpt_1.Size = New System.Drawing.Size(73, 17)
        Me._SSOpt_1.TabIndex = 3
        Me._SSOpt_1.TabStop = True
        Me._SSOpt_1.Tag = "Name"
        Me._SSOpt_1.Text = "Tên TP"
        Me._SSOpt_1.UseVisualStyleBackColor = False
        '
        'SSCmdF1
        '
        Me.SSCmdF1.BackColor = System.Drawing.SystemColors.Control
        Me.SSCmdF1.Cursor = System.Windows.Forms.Cursors.Default
        Me.SSCmdF1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSCmdF1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SSCmdF1.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_addtogrid
        Me.SSCmdF1.Location = New System.Drawing.Point(301, 297)
        Me.SSCmdF1.Name = "SSCmdF1"
        Me.SSCmdF1.Size = New System.Drawing.Size(17, 19)
        Me.SSCmdF1.TabIndex = 5
        Me.SSCmdF1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SSCmdF1.UseVisualStyleBackColor = False
        '
        '_TxtVT_1
        '
        Me._TxtVT_1.AcceptsReturn = True
        Me._TxtVT_1.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_1.Location = New System.Drawing.Point(408, 48)
        Me._TxtVT_1.MaxLength = 50
        Me._TxtVT_1.Name = "_TxtVT_1"
        Me._TxtVT_1.Size = New System.Drawing.Size(233, 13)
        Me._TxtVT_1.TabIndex = 7
        '
        '_TxtVT_0
        '
        Me._TxtVT_0.AcceptsReturn = True
        Me._TxtVT_0.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_0.Location = New System.Drawing.Point(408, 24)
        Me._TxtVT_0.MaxLength = 20
        Me._TxtVT_0.Name = "_TxtVT_0"
        Me._TxtVT_0.Size = New System.Drawing.Size(129, 13)
        Me._TxtVT_0.TabIndex = 6
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.White
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_10.Location = New System.Drawing.Point(344, 192)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(57, 17)
        Me._Label_10.TabIndex = 25
        Me._Label_10.Tag = "Exc. rate"
        Me._Label_10.Text = "Tỷ Lệ QĐ"
        '
        '_Line_7
        '
        Me._Line_7.Enabled = False
        Me._Line_7.Location = New System.Drawing.Point(408, 211)
        Me._Line_7.Name = "_Line_7"
        Me._Line_7.Size = New System.Drawing.Size(128, 1)
        Me._Line_7.TabIndex = 30
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.White
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_8.Location = New System.Drawing.Point(344, 168)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(57, 17)
        Me._Label_8.TabIndex = 24
        Me._Label_8.Tag = "Unit 2"
        Me._Label_8.Text = "DVT2"
        '
        '_Line_6
        '
        Me._Line_6.Enabled = False
        Me._Line_6.Location = New System.Drawing.Point(408, 187)
        Me._Line_6.Name = "_Line_6"
        Me._Line_6.Size = New System.Drawing.Size(128, 1)
        Me._Line_6.TabIndex = 31
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.White
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_3.Location = New System.Drawing.Point(344, 144)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(57, 17)
        Me._Label_3.TabIndex = 23
        Me._Label_3.Tag = "Unit 1"
        Me._Label_3.Text = "DVT1"
        '
        '_Line_2
        '
        Me._Line_2.Enabled = False
        Me._Line_2.Location = New System.Drawing.Point(408, 163)
        Me._Line_2.Name = "_Line_2"
        Me._Line_2.Size = New System.Drawing.Size(128, 1)
        Me._Line_2.TabIndex = 32
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.White
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_7.Location = New System.Drawing.Point(344, 96)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(57, 17)
        Me._Label_7.TabIndex = 22
        Me._Label_7.Tag = "Name"
        Me._Label_7.Text = "Tên VT"
        '
        '_Line_5
        '
        Me._Line_5.Enabled = False
        Me._Line_5.Location = New System.Drawing.Point(408, 115)
        Me._Line_5.Name = "_Line_5"
        Me._Line_5.Size = New System.Drawing.Size(232, 1)
        Me._Line_5.TabIndex = 33
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.White
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_6.Location = New System.Drawing.Point(344, 72)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(57, 17)
        Me._Label_6.TabIndex = 21
        Me._Label_6.Tag = "Code"
        Me._Label_6.Text = "Số hiệu VT"
        '
        '_Line_4
        '
        Me._Line_4.Enabled = False
        Me._Line_4.Location = New System.Drawing.Point(408, 91)
        Me._Line_4.Name = "_Line_4"
        Me._Line_4.Size = New System.Drawing.Size(128, 1)
        Me._Line_4.TabIndex = 34
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.White
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(344, 48)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(57, 17)
        Me._Label_0.TabIndex = 20
        Me._Label_0.Tag = "Name"
        Me._Label_0.Text = "Tên KH"
        '
        '_Line_3
        '
        Me._Line_3.Enabled = False
        Me._Line_3.Location = New System.Drawing.Point(408, 67)
        Me._Line_3.Name = "_Line_3"
        Me._Line_3.Size = New System.Drawing.Size(232, 1)
        Me._Line_3.TabIndex = 35
        '
        '_Line_1
        '
        Me._Line_1.Enabled = False
        Me._Line_1.Location = New System.Drawing.Point(408, 139)
        Me._Line_1.Name = "_Line_1"
        Me._Line_1.Size = New System.Drawing.Size(128, 1)
        Me._Line_1.TabIndex = 36
        '
        '_Line_0
        '
        Me._Line_0.Enabled = False
        Me._Line_0.Location = New System.Drawing.Point(408, 43)
        Me._Line_0.Name = "_Line_0"
        Me._Line_0.Size = New System.Drawing.Size(128, 1)
        Me._Line_0.TabIndex = 37
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.White
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(344, 120)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(57, 17)
        Me._Label_2.TabIndex = 15
        Me._Label_2.Tag = "Price"
        Me._Label_2.Text = "Giá bán"
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.White
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(344, 24)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(57, 17)
        Me._Label_1.TabIndex = 14
        Me._Label_1.Tag = "Code"
        Me._Label_1.Text = "Số hiệu KH"
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.SystemColors.Window
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.Location = New System.Drawing.Point(328, 8)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(329, 266)
        Me._Label_4.TabIndex = 18
        '
        'FrmGiaVTKH
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(665, 321)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._TxtVT_7)
        Me.Controls.Add(Me._TxtVT_6)
        Me.Controls.Add(Me._TxtVT_5)
        Me.Controls.Add(Me._TxtVT_4)
        Me.Controls.Add(Me._TxtVT_2)
        Me.Controls.Add(Me._TxtVT_3)
        Me.Controls.Add(Me.LstVt)
        Me.Controls.Add(Me.CboLoai)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me._SSOpt_0)
        Me.Controls.Add(Me._SSOpt_1)
        Me.Controls.Add(Me.SSCmdF1)
        Me.Controls.Add(Me._TxtVT_1)
        Me.Controls.Add(Me._TxtVT_0)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Line_7)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Line_6)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Line_2)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Line_5)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Line_4)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Line_3)
        Me.Controls.Add(Me._Line_1)
        Me.Controls.Add(Me._Line_0)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_4)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 25)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGiaVTKH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Equivalent cost of material to customers"
        Me.Text = "Giá vật tư ứng với từng khách hàng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializeTxtVT()
		Me.TxtVT(7) = _TxtVT_7
		Me.TxtVT(6) = _TxtVT_6
		Me.TxtVT(5) = _TxtVT_5
		Me.TxtVT(4) = _TxtVT_4
		Me.TxtVT(2) = _TxtVT_2
		Me.TxtVT(3) = _TxtVT_3
		Me.TxtVT(1) = _TxtVT_1
		Me.TxtVT(0) = _TxtVT_0
	End Sub
	Sub InitializeSSOpt()
		Me.SSOpt(0) = _SSOpt_0
		Me.SSOpt(1) = _SSOpt_1
	End Sub
	Sub InitializeLine()
		Me.Line(7) = _Line_7
		Me.Line(6) = _Line_6
		Me.Line(2) = _Line_2
		Me.Line(5) = _Line_5
		Me.Line(4) = _Line_4
		Me.Line(3) = _Line_3
		Me.Line(1) = _Line_1
		Me.Line(0) = _Line_0
	End Sub
	Sub InitializeLabel()
		Me.Label(10) = _Label_10
        Me.Label(8) = _Label_8
		Me.Label(3) = _Label_3
		Me.Label(7) = _Label_7
		Me.Label(6) = _Label_6
		Me.Label(0) = _Label_0
        'Me.Label(9) = _Label_9
		Me.Label(2) = _Label_2
		Me.Label(1) = _Label_1
		Me.Label(4) = _Label_4
        'Me.Label(5) = _Label_5
        'Me.Label(14) = _Label_14
	End Sub
	Sub InitializeCommand()
		Me.Command(0) = _Command_0
		Me.Command(1) = _Command_1
		Me.Command(2) = _Command_2
		Me.Command(3) = _Command_3
	End Sub
#End Region 
End Class
