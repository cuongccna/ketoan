<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBbbg
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeTienthue()
		InitializeSosach()
		InitializeLabel5()
		InitializeLabel4()
		InitializeLabel3()
		InitializeLabel2()
		InitializeCommand1()
		InitializeCommand()
		InitializeChungtu()
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
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Chungtu_10 As System.Windows.Forms.TextBox
    Private WithEvents _Chungtu_9 As System.Windows.Forms.TextBox
    Private WithEvents _Chungtu_8 As System.Windows.Forms.TextBox
    Private WithEvents _Sosach_7 As System.Windows.Forms.TextBox
    Private WithEvents _Sosach_6 As System.Windows.Forms.TextBox
    Private WithEvents _Sosach_5 As System.Windows.Forms.TextBox
    Private WithEvents _Sosach_8 As System.Windows.Forms.TextBox
    Public WithEvents CboThang As ComboBoxEx.ComboBoxExt
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Private WithEvents _Command1_3 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Command1_2 As System.Windows.Forms.Button
    Private WithEvents _Chungtu_7 As System.Windows.Forms.TextBox
    Private WithEvents _Chungtu_6 As System.Windows.Forms.TextBox
    Private WithEvents _Chungtu_5 As System.Windows.Forms.TextBox
    Private WithEvents _Chungtu_4 As System.Windows.Forms.TextBox
    Private WithEvents _Chungtu_3 As System.Windows.Forms.TextBox
    Private WithEvents _Chungtu_2 As System.Windows.Forms.TextBox
    Private WithEvents _Chungtu_1 As System.Windows.Forms.TextBox
    Public WithEvents Nguoinhan As System.Windows.Forms.TextBox
    Public WithEvents Nguoigiao As System.Windows.Forms.TextBox
    Private WithEvents _Tienthue_4 As System.Windows.Forms.TextBox
    Private WithEvents _Tienthue_3 As System.Windows.Forms.TextBox
    Private WithEvents _Tienthue_2 As System.Windows.Forms.TextBox
    Private WithEvents _Tienthue_1 As System.Windows.Forms.TextBox
    Private WithEvents _Sosach_4 As System.Windows.Forms.TextBox
    Private WithEvents _Sosach_3 As System.Windows.Forms.TextBox
    Private WithEvents _Sosach_2 As System.Windows.Forms.TextBox
    Private WithEvents _Sosach_1 As System.Windows.Forms.TextBox
    Private WithEvents _Chungtu_14 As System.Windows.Forms.TextBox
    Private WithEvents _Chungtu_13 As System.Windows.Forms.TextBox
    Private WithEvents _Chungtu_12 As System.Windows.Forms.TextBox
    Private WithEvents _Chungtu_11 As System.Windows.Forms.TextBox
    Private WithEvents _Label3_16 As System.Windows.Forms.Label
    Private WithEvents _Label3_15 As System.Windows.Forms.Label
    Private WithEvents _Label3_14 As System.Windows.Forms.Label
    Private WithEvents _Label3_13 As System.Windows.Forms.Label
    Private WithEvents _Label4_7 As System.Windows.Forms.Label
    Private WithEvents _Label3_12 As System.Windows.Forms.Label
    Private WithEvents _Label3_11 As System.Windows.Forms.Label
    Private WithEvents _Label4_6 As System.Windows.Forms.Label
    Private WithEvents _Label3_10 As System.Windows.Forms.Label
    Private WithEvents _Label3_9 As System.Windows.Forms.Label
    Private WithEvents _Label3_8 As System.Windows.Forms.Label
    Private WithEvents _Label3_7 As System.Windows.Forms.Label
    Private WithEvents _Label5_6 As System.Windows.Forms.Label
    Private WithEvents _Label4_5 As System.Windows.Forms.Label
    Private WithEvents _Label4_4 As System.Windows.Forms.Label
    Private WithEvents _Label5_5 As System.Windows.Forms.Label
    Private WithEvents _Label5_4 As System.Windows.Forms.Label
    Private WithEvents _Label5_3 As System.Windows.Forms.Label
    Private WithEvents _Label5_2 As System.Windows.Forms.Label
    Private WithEvents _Label5_1 As System.Windows.Forms.Label
    Private WithEvents _Label5_0 As System.Windows.Forms.Label
    Private WithEvents _Label4_3 As System.Windows.Forms.Label
    Private WithEvents _Label4_2 As System.Windows.Forms.Label
    Private WithEvents _Label4_1 As System.Windows.Forms.Label
    Private WithEvents _Label4_0 As System.Windows.Forms.Label
    Private WithEvents _Label3_6 As System.Windows.Forms.Label
    Private WithEvents _Label3_5 As System.Windows.Forms.Label
    Private WithEvents _Label3_4 As System.Windows.Forms.Label
    Private WithEvents _Label3_3 As System.Windows.Forms.Label
    Private WithEvents _Label3_2 As System.Windows.Forms.Label
    Private WithEvents _Label3_1 As System.Windows.Forms.Label
    Private WithEvents _Label3_0 As System.Windows.Forms.Label
    Private WithEvents _Label2_2 As System.Windows.Forms.Label
    Private WithEvents _Label2_1 As System.Windows.Forms.Label
    Private WithEvents _Label2_0 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public Chungtu(14) As System.Windows.Forms.TextBox
    Public Command(3) As System.Windows.Forms.Button
    Public Command1(3) As System.Windows.Forms.Button
    Public Label2(2) As System.Windows.Forms.Label
    Public Label3(16) As System.Windows.Forms.Label
    Public Label4(7) As System.Windows.Forms.Label
    Public Label5(6) As System.Windows.Forms.Label
    Public Sosach(8) As System.Windows.Forms.TextBox
    Public Tienthue(4) As System.Windows.Forms.TextBox
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBbbg))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Chungtu_10 = New System.Windows.Forms.TextBox()
        Me._Chungtu_9 = New System.Windows.Forms.TextBox()
        Me._Chungtu_8 = New System.Windows.Forms.TextBox()
        Me._Sosach_7 = New System.Windows.Forms.TextBox()
        Me._Sosach_6 = New System.Windows.Forms.TextBox()
        Me._Sosach_5 = New System.Windows.Forms.TextBox()
        Me._Sosach_8 = New System.Windows.Forms.TextBox()
        Me.CboThang = New ComboBoxEx.ComboBoxExt()
        Me._Chungtu_7 = New System.Windows.Forms.TextBox()
        Me._Chungtu_6 = New System.Windows.Forms.TextBox()
        Me._Chungtu_5 = New System.Windows.Forms.TextBox()
        Me._Chungtu_4 = New System.Windows.Forms.TextBox()
        Me._Chungtu_3 = New System.Windows.Forms.TextBox()
        Me._Chungtu_2 = New System.Windows.Forms.TextBox()
        Me._Chungtu_1 = New System.Windows.Forms.TextBox()
        Me.Nguoinhan = New System.Windows.Forms.TextBox()
        Me.Nguoigiao = New System.Windows.Forms.TextBox()
        Me._Tienthue_4 = New System.Windows.Forms.TextBox()
        Me._Tienthue_3 = New System.Windows.Forms.TextBox()
        Me._Tienthue_2 = New System.Windows.Forms.TextBox()
        Me._Tienthue_1 = New System.Windows.Forms.TextBox()
        Me._Sosach_4 = New System.Windows.Forms.TextBox()
        Me._Sosach_3 = New System.Windows.Forms.TextBox()
        Me._Sosach_2 = New System.Windows.Forms.TextBox()
        Me._Sosach_1 = New System.Windows.Forms.TextBox()
        Me._Chungtu_14 = New System.Windows.Forms.TextBox()
        Me._Chungtu_13 = New System.Windows.Forms.TextBox()
        Me._Chungtu_12 = New System.Windows.Forms.TextBox()
        Me._Chungtu_11 = New System.Windows.Forms.TextBox()
        Me._Label3_16 = New System.Windows.Forms.Label()
        Me._Label3_15 = New System.Windows.Forms.Label()
        Me._Label3_14 = New System.Windows.Forms.Label()
        Me._Label3_13 = New System.Windows.Forms.Label()
        Me._Label4_7 = New System.Windows.Forms.Label()
        Me._Label3_12 = New System.Windows.Forms.Label()
        Me._Label3_11 = New System.Windows.Forms.Label()
        Me._Label4_6 = New System.Windows.Forms.Label()
        Me._Label3_10 = New System.Windows.Forms.Label()
        Me._Label3_9 = New System.Windows.Forms.Label()
        Me._Label3_8 = New System.Windows.Forms.Label()
        Me._Label3_7 = New System.Windows.Forms.Label()
        Me._Label5_6 = New System.Windows.Forms.Label()
        Me._Label4_5 = New System.Windows.Forms.Label()
        Me._Label4_4 = New System.Windows.Forms.Label()
        Me._Label5_5 = New System.Windows.Forms.Label()
        Me._Label5_4 = New System.Windows.Forms.Label()
        Me._Label5_3 = New System.Windows.Forms.Label()
        Me._Label5_2 = New System.Windows.Forms.Label()
        Me._Label5_1 = New System.Windows.Forms.Label()
        Me._Label5_0 = New System.Windows.Forms.Label()
        Me._Label4_3 = New System.Windows.Forms.Label()
        Me._Label4_2 = New System.Windows.Forms.Label()
        Me._Label4_1 = New System.Windows.Forms.Label()
        Me._Label4_0 = New System.Windows.Forms.Label()
        Me._Label3_6 = New System.Windows.Forms.Label()
        Me._Label3_5 = New System.Windows.Forms.Label()
        Me._Label3_4 = New System.Windows.Forms.Label()
        Me._Label3_3 = New System.Windows.Forms.Label()
        Me._Label3_2 = New System.Windows.Forms.Label()
        Me._Label3_1 = New System.Windows.Forms.Label()
        Me._Label3_0 = New System.Windows.Forms.Label()
        Me._Label2_2 = New System.Windows.Forms.Label()
        Me._Label2_1 = New System.Windows.Forms.Label()
        Me._Label2_0 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._Command_3 = New System.Windows.Forms.Button()
        Me._Command_2 = New System.Windows.Forms.Button()
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me._Command1_0 = New System.Windows.Forms.Button()
        Me._Command1_3 = New System.Windows.Forms.Button()
        Me._Command1_1 = New System.Windows.Forms.Button()
        Me._Command1_2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        '_Chungtu_10
        '
        Me._Chungtu_10.AcceptsReturn = True
        Me._Chungtu_10.BackColor = System.Drawing.SystemColors.Window
        Me._Chungtu_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Chungtu_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Chungtu_10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chungtu_10.Location = New System.Drawing.Point(72, 616)
        Me._Chungtu_10.MaxLength = 0
        Me._Chungtu_10.Name = "_Chungtu_10"
        Me._Chungtu_10.Size = New System.Drawing.Size(321, 22)
        Me._Chungtu_10.TabIndex = 26
        '
        '_Chungtu_9
        '
        Me._Chungtu_9.AcceptsReturn = True
        Me._Chungtu_9.BackColor = System.Drawing.SystemColors.Window
        Me._Chungtu_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Chungtu_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Chungtu_9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chungtu_9.Location = New System.Drawing.Point(72, 592)
        Me._Chungtu_9.MaxLength = 0
        Me._Chungtu_9.Name = "_Chungtu_9"
        Me._Chungtu_9.Size = New System.Drawing.Size(321, 22)
        Me._Chungtu_9.TabIndex = 25
        '
        '_Chungtu_8
        '
        Me._Chungtu_8.AcceptsReturn = True
        Me._Chungtu_8.BackColor = System.Drawing.SystemColors.Window
        Me._Chungtu_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Chungtu_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Chungtu_8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chungtu_8.Location = New System.Drawing.Point(72, 568)
        Me._Chungtu_8.MaxLength = 0
        Me._Chungtu_8.Name = "_Chungtu_8"
        Me._Chungtu_8.Size = New System.Drawing.Size(321, 22)
        Me._Chungtu_8.TabIndex = 24
        '
        '_Sosach_7
        '
        Me._Sosach_7.AcceptsReturn = True
        Me._Sosach_7.BackColor = System.Drawing.SystemColors.Window
        Me._Sosach_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Sosach_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Sosach_7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Sosach_7.Location = New System.Drawing.Point(176, 232)
        Me._Sosach_7.MaxLength = 0
        Me._Sosach_7.Name = "_Sosach_7"
        Me._Sosach_7.Size = New System.Drawing.Size(105, 22)
        Me._Sosach_7.TabIndex = 8
        '
        '_Sosach_6
        '
        Me._Sosach_6.AcceptsReturn = True
        Me._Sosach_6.BackColor = System.Drawing.SystemColors.Window
        Me._Sosach_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Sosach_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Sosach_6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Sosach_6.Location = New System.Drawing.Point(176, 208)
        Me._Sosach_6.MaxLength = 0
        Me._Sosach_6.Name = "_Sosach_6"
        Me._Sosach_6.Size = New System.Drawing.Size(105, 22)
        Me._Sosach_6.TabIndex = 7
        '
        '_Sosach_5
        '
        Me._Sosach_5.AcceptsReturn = True
        Me._Sosach_5.BackColor = System.Drawing.SystemColors.Window
        Me._Sosach_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Sosach_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Sosach_5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Sosach_5.Location = New System.Drawing.Point(176, 184)
        Me._Sosach_5.MaxLength = 0
        Me._Sosach_5.Name = "_Sosach_5"
        Me._Sosach_5.Size = New System.Drawing.Size(105, 22)
        Me._Sosach_5.TabIndex = 6
        '
        '_Sosach_8
        '
        Me._Sosach_8.AcceptsReturn = True
        Me._Sosach_8.BackColor = System.Drawing.SystemColors.Window
        Me._Sosach_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Sosach_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Sosach_8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Sosach_8.Location = New System.Drawing.Point(176, 160)
        Me._Sosach_8.MaxLength = 0
        Me._Sosach_8.Name = "_Sosach_8"
        Me._Sosach_8.Size = New System.Drawing.Size(105, 22)
        Me._Sosach_8.TabIndex = 5
        '
        'CboThang
        '
        Me.CboThang.BackColor = System.Drawing.SystemColors.Window
        Me.CboThang.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboThang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboThang.Location = New System.Drawing.Point(320, 56)
        Me.CboThang.Name = "CboThang"
        Me.CboThang.Size = New System.Drawing.Size(73, 21)
        Me.CboThang.TabIndex = 0
        '
        '_Chungtu_7
        '
        Me._Chungtu_7.AcceptsReturn = True
        Me._Chungtu_7.BackColor = System.Drawing.SystemColors.Window
        Me._Chungtu_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Chungtu_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Chungtu_7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chungtu_7.Location = New System.Drawing.Point(176, 544)
        Me._Chungtu_7.MaxLength = 0
        Me._Chungtu_7.Name = "_Chungtu_7"
        Me._Chungtu_7.Size = New System.Drawing.Size(217, 22)
        Me._Chungtu_7.TabIndex = 23
        '
        '_Chungtu_6
        '
        Me._Chungtu_6.AcceptsReturn = True
        Me._Chungtu_6.BackColor = System.Drawing.SystemColors.Window
        Me._Chungtu_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Chungtu_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Chungtu_6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chungtu_6.Location = New System.Drawing.Point(176, 520)
        Me._Chungtu_6.MaxLength = 0
        Me._Chungtu_6.Name = "_Chungtu_6"
        Me._Chungtu_6.Size = New System.Drawing.Size(217, 22)
        Me._Chungtu_6.TabIndex = 22
        '
        '_Chungtu_5
        '
        Me._Chungtu_5.AcceptsReturn = True
        Me._Chungtu_5.BackColor = System.Drawing.SystemColors.Window
        Me._Chungtu_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Chungtu_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Chungtu_5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chungtu_5.Location = New System.Drawing.Point(176, 496)
        Me._Chungtu_5.MaxLength = 0
        Me._Chungtu_5.Name = "_Chungtu_5"
        Me._Chungtu_5.Size = New System.Drawing.Size(217, 22)
        Me._Chungtu_5.TabIndex = 21
        '
        '_Chungtu_4
        '
        Me._Chungtu_4.AcceptsReturn = True
        Me._Chungtu_4.BackColor = System.Drawing.SystemColors.Window
        Me._Chungtu_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Chungtu_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Chungtu_4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chungtu_4.Location = New System.Drawing.Point(176, 472)
        Me._Chungtu_4.MaxLength = 0
        Me._Chungtu_4.Name = "_Chungtu_4"
        Me._Chungtu_4.Size = New System.Drawing.Size(105, 22)
        Me._Chungtu_4.TabIndex = 20
        '
        '_Chungtu_3
        '
        Me._Chungtu_3.AcceptsReturn = True
        Me._Chungtu_3.BackColor = System.Drawing.SystemColors.Window
        Me._Chungtu_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Chungtu_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Chungtu_3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chungtu_3.Location = New System.Drawing.Point(176, 448)
        Me._Chungtu_3.MaxLength = 0
        Me._Chungtu_3.Name = "_Chungtu_3"
        Me._Chungtu_3.Size = New System.Drawing.Size(105, 22)
        Me._Chungtu_3.TabIndex = 19
        '
        '_Chungtu_2
        '
        Me._Chungtu_2.AcceptsReturn = True
        Me._Chungtu_2.BackColor = System.Drawing.SystemColors.Window
        Me._Chungtu_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Chungtu_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Chungtu_2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chungtu_2.Location = New System.Drawing.Point(176, 424)
        Me._Chungtu_2.MaxLength = 0
        Me._Chungtu_2.Name = "_Chungtu_2"
        Me._Chungtu_2.Size = New System.Drawing.Size(105, 22)
        Me._Chungtu_2.TabIndex = 18
        '
        '_Chungtu_1
        '
        Me._Chungtu_1.AcceptsReturn = True
        Me._Chungtu_1.BackColor = System.Drawing.SystemColors.Window
        Me._Chungtu_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Chungtu_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Chungtu_1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chungtu_1.Location = New System.Drawing.Point(176, 400)
        Me._Chungtu_1.MaxLength = 0
        Me._Chungtu_1.Name = "_Chungtu_1"
        Me._Chungtu_1.Size = New System.Drawing.Size(105, 22)
        Me._Chungtu_1.TabIndex = 17
        '
        'Nguoinhan
        '
        Me.Nguoinhan.AcceptsReturn = True
        Me.Nguoinhan.BackColor = System.Drawing.SystemColors.Window
        Me.Nguoinhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nguoinhan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Nguoinhan.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nguoinhan.Location = New System.Drawing.Point(232, 660)
        Me.Nguoinhan.MaxLength = 0
        Me.Nguoinhan.Name = "Nguoinhan"
        Me.Nguoinhan.Size = New System.Drawing.Size(137, 22)
        Me.Nguoinhan.TabIndex = 28
        '
        'Nguoigiao
        '
        Me.Nguoigiao.AcceptsReturn = True
        Me.Nguoigiao.BackColor = System.Drawing.SystemColors.Window
        Me.Nguoigiao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nguoigiao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Nguoigiao.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nguoigiao.Location = New System.Drawing.Point(32, 660)
        Me.Nguoigiao.MaxLength = 0
        Me.Nguoigiao.Name = "Nguoigiao"
        Me.Nguoigiao.Size = New System.Drawing.Size(137, 22)
        Me.Nguoigiao.TabIndex = 27
        '
        '_Tienthue_4
        '
        Me._Tienthue_4.AcceptsReturn = True
        Me._Tienthue_4.BackColor = System.Drawing.SystemColors.Window
        Me._Tienthue_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Tienthue_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Tienthue_4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Tienthue_4.Location = New System.Drawing.Point(232, 352)
        Me._Tienthue_4.MaxLength = 0
        Me._Tienthue_4.Name = "_Tienthue_4"
        Me._Tienthue_4.Size = New System.Drawing.Size(161, 22)
        Me._Tienthue_4.TabIndex = 16
        '
        '_Tienthue_3
        '
        Me._Tienthue_3.AcceptsReturn = True
        Me._Tienthue_3.BackColor = System.Drawing.SystemColors.Window
        Me._Tienthue_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Tienthue_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Tienthue_3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Tienthue_3.Location = New System.Drawing.Point(232, 328)
        Me._Tienthue_3.MaxLength = 0
        Me._Tienthue_3.Name = "_Tienthue_3"
        Me._Tienthue_3.Size = New System.Drawing.Size(161, 22)
        Me._Tienthue_3.TabIndex = 14
        '
        '_Tienthue_2
        '
        Me._Tienthue_2.AcceptsReturn = True
        Me._Tienthue_2.BackColor = System.Drawing.SystemColors.Window
        Me._Tienthue_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Tienthue_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Tienthue_2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Tienthue_2.Location = New System.Drawing.Point(232, 304)
        Me._Tienthue_2.MaxLength = 0
        Me._Tienthue_2.Name = "_Tienthue_2"
        Me._Tienthue_2.Size = New System.Drawing.Size(161, 22)
        Me._Tienthue_2.TabIndex = 12
        '
        '_Tienthue_1
        '
        Me._Tienthue_1.AcceptsReturn = True
        Me._Tienthue_1.BackColor = System.Drawing.SystemColors.Window
        Me._Tienthue_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Tienthue_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Tienthue_1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Tienthue_1.Location = New System.Drawing.Point(232, 280)
        Me._Tienthue_1.MaxLength = 0
        Me._Tienthue_1.Name = "_Tienthue_1"
        Me._Tienthue_1.Size = New System.Drawing.Size(161, 22)
        Me._Tienthue_1.TabIndex = 10
        '
        '_Sosach_4
        '
        Me._Sosach_4.AcceptsReturn = True
        Me._Sosach_4.BackColor = System.Drawing.SystemColors.Window
        Me._Sosach_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Sosach_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Sosach_4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Sosach_4.Location = New System.Drawing.Point(176, 136)
        Me._Sosach_4.MaxLength = 0
        Me._Sosach_4.Name = "_Sosach_4"
        Me._Sosach_4.Size = New System.Drawing.Size(105, 22)
        Me._Sosach_4.TabIndex = 4
        '
        '_Sosach_3
        '
        Me._Sosach_3.AcceptsReturn = True
        Me._Sosach_3.BackColor = System.Drawing.SystemColors.Window
        Me._Sosach_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Sosach_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Sosach_3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Sosach_3.Location = New System.Drawing.Point(176, 112)
        Me._Sosach_3.MaxLength = 0
        Me._Sosach_3.Name = "_Sosach_3"
        Me._Sosach_3.Size = New System.Drawing.Size(105, 22)
        Me._Sosach_3.TabIndex = 3
        '
        '_Sosach_2
        '
        Me._Sosach_2.AcceptsReturn = True
        Me._Sosach_2.BackColor = System.Drawing.SystemColors.Window
        Me._Sosach_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Sosach_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Sosach_2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Sosach_2.Location = New System.Drawing.Point(176, 88)
        Me._Sosach_2.MaxLength = 0
        Me._Sosach_2.Name = "_Sosach_2"
        Me._Sosach_2.Size = New System.Drawing.Size(105, 22)
        Me._Sosach_2.TabIndex = 2
        '
        '_Sosach_1
        '
        Me._Sosach_1.AcceptsReturn = True
        Me._Sosach_1.BackColor = System.Drawing.SystemColors.Window
        Me._Sosach_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Sosach_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Sosach_1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Sosach_1.Location = New System.Drawing.Point(176, 64)
        Me._Sosach_1.MaxLength = 0
        Me._Sosach_1.Name = "_Sosach_1"
        Me._Sosach_1.Size = New System.Drawing.Size(105, 22)
        Me._Sosach_1.TabIndex = 1
        '
        '_Chungtu_14
        '
        Me._Chungtu_14.AcceptsReturn = True
        Me._Chungtu_14.BackColor = System.Drawing.SystemColors.Window
        Me._Chungtu_14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Chungtu_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Chungtu_14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chungtu_14.Location = New System.Drawing.Point(176, 352)
        Me._Chungtu_14.MaxLength = 0
        Me._Chungtu_14.Name = "_Chungtu_14"
        Me._Chungtu_14.Size = New System.Drawing.Size(49, 22)
        Me._Chungtu_14.TabIndex = 15
        '
        '_Chungtu_13
        '
        Me._Chungtu_13.AcceptsReturn = True
        Me._Chungtu_13.BackColor = System.Drawing.SystemColors.Window
        Me._Chungtu_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Chungtu_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Chungtu_13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chungtu_13.Location = New System.Drawing.Point(176, 328)
        Me._Chungtu_13.MaxLength = 0
        Me._Chungtu_13.Name = "_Chungtu_13"
        Me._Chungtu_13.Size = New System.Drawing.Size(49, 22)
        Me._Chungtu_13.TabIndex = 13
        '
        '_Chungtu_12
        '
        Me._Chungtu_12.AcceptsReturn = True
        Me._Chungtu_12.BackColor = System.Drawing.SystemColors.Window
        Me._Chungtu_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Chungtu_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Chungtu_12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chungtu_12.Location = New System.Drawing.Point(176, 304)
        Me._Chungtu_12.MaxLength = 0
        Me._Chungtu_12.Name = "_Chungtu_12"
        Me._Chungtu_12.Size = New System.Drawing.Size(49, 22)
        Me._Chungtu_12.TabIndex = 11
        '
        '_Chungtu_11
        '
        Me._Chungtu_11.AcceptsReturn = True
        Me._Chungtu_11.BackColor = System.Drawing.SystemColors.Window
        Me._Chungtu_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Chungtu_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Chungtu_11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chungtu_11.Location = New System.Drawing.Point(176, 280)
        Me._Chungtu_11.MaxLength = 0
        Me._Chungtu_11.Name = "_Chungtu_11"
        Me._Chungtu_11.Size = New System.Drawing.Size(49, 22)
        Me._Chungtu_11.TabIndex = 9
        '
        '_Label3_16
        '
        Me._Label3_16.BackColor = System.Drawing.Color.Transparent
        Me._Label3_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_16.Location = New System.Drawing.Point(224, 352)
        Me._Label3_16.Name = "_Label3_16"
        Me._Label3_16.Size = New System.Drawing.Size(9, 17)
        Me._Label3_16.TabIndex = 72
        Me._Label3_16.Text = ":"
        Me._Label3_16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label3_15
        '
        Me._Label3_15.BackColor = System.Drawing.Color.Transparent
        Me._Label3_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_15.Location = New System.Drawing.Point(224, 328)
        Me._Label3_15.Name = "_Label3_15"
        Me._Label3_15.Size = New System.Drawing.Size(9, 17)
        Me._Label3_15.TabIndex = 71
        Me._Label3_15.Text = ":"
        Me._Label3_15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label3_14
        '
        Me._Label3_14.BackColor = System.Drawing.Color.Transparent
        Me._Label3_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_14.Location = New System.Drawing.Point(224, 304)
        Me._Label3_14.Name = "_Label3_14"
        Me._Label3_14.Size = New System.Drawing.Size(9, 17)
        Me._Label3_14.TabIndex = 70
        Me._Label3_14.Text = ":"
        Me._Label3_14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label3_13
        '
        Me._Label3_13.BackColor = System.Drawing.Color.Transparent
        Me._Label3_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_13.Location = New System.Drawing.Point(224, 280)
        Me._Label3_13.Name = "_Label3_13"
        Me._Label3_13.Size = New System.Drawing.Size(9, 17)
        Me._Label3_13.TabIndex = 69
        Me._Label3_13.Text = ":"
        Me._Label3_13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label4_7
        '
        Me._Label4_7.BackColor = System.Drawing.Color.Transparent
        Me._Label4_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label4_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label4_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label4_7.Location = New System.Drawing.Point(16, 568)
        Me._Label4_7.Name = "_Label4_7"
        Me._Label4_7.Size = New System.Drawing.Size(49, 17)
        Me._Label4_7.TabIndex = 68
        Me._Label4_7.Text = "- Ghi chú"
        '
        '_Label3_12
        '
        Me._Label3_12.BackColor = System.Drawing.Color.Transparent
        Me._Label3_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_12.Location = New System.Drawing.Point(16, 160)
        Me._Label3_12.Name = "_Label3_12"
        Me._Label3_12.Size = New System.Drawing.Size(137, 17)
        Me._Label3_12.TabIndex = 67
        Me._Label3_12.Text = "- Chứng từ ngân hàng"
        '
        '_Label3_11
        '
        Me._Label3_11.BackColor = System.Drawing.Color.Transparent
        Me._Label3_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_11.Location = New System.Drawing.Point(288, 160)
        Me._Label3_11.Name = "_Label3_11"
        Me._Label3_11.Size = New System.Drawing.Size(17, 17)
        Me._Label3_11.TabIndex = 66
        Me._Label3_11.Text = "tờ"
        '
        '_Label4_6
        '
        Me._Label4_6.BackColor = System.Drawing.Color.Transparent
        Me._Label4_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label4_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label4_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label4_6.Location = New System.Drawing.Point(320, 40)
        Me._Label4_6.Name = "_Label4_6"
        Me._Label4_6.Size = New System.Drawing.Size(73, 17)
        Me._Label4_6.TabIndex = 65
        Me._Label4_6.Text = "Báo cáo tháng"
        '
        '_Label3_10
        '
        Me._Label3_10.BackColor = System.Drawing.Color.Transparent
        Me._Label3_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_10.Location = New System.Drawing.Point(288, 136)
        Me._Label3_10.Name = "_Label3_10"
        Me._Label3_10.Size = New System.Drawing.Size(17, 17)
        Me._Label3_10.TabIndex = 64
        Me._Label3_10.Text = "tờ"
        '
        '_Label3_9
        '
        Me._Label3_9.BackColor = System.Drawing.Color.Transparent
        Me._Label3_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_9.Location = New System.Drawing.Point(288, 112)
        Me._Label3_9.Name = "_Label3_9"
        Me._Label3_9.Size = New System.Drawing.Size(17, 17)
        Me._Label3_9.TabIndex = 63
        Me._Label3_9.Text = "tờ"
        '
        '_Label3_8
        '
        Me._Label3_8.BackColor = System.Drawing.Color.Transparent
        Me._Label3_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_8.Location = New System.Drawing.Point(288, 88)
        Me._Label3_8.Name = "_Label3_8"
        Me._Label3_8.Size = New System.Drawing.Size(17, 17)
        Me._Label3_8.TabIndex = 62
        Me._Label3_8.Text = "tờ"
        '
        '_Label3_7
        '
        Me._Label3_7.BackColor = System.Drawing.Color.Transparent
        Me._Label3_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_7.Location = New System.Drawing.Point(288, 64)
        Me._Label3_7.Name = "_Label3_7"
        Me._Label3_7.Size = New System.Drawing.Size(17, 17)
        Me._Label3_7.TabIndex = 61
        Me._Label3_7.Text = "tờ"
        '
        '_Label5_6
        '
        Me._Label5_6.BackColor = System.Drawing.Color.Transparent
        Me._Label5_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label5_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label5_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label5_6.Location = New System.Drawing.Point(16, 544)
        Me._Label5_6.Name = "_Label5_6"
        Me._Label5_6.Size = New System.Drawing.Size(137, 17)
        Me._Label5_6.TabIndex = 60
        Me._Label5_6.Text = "- Định mức sản phẩm"
        '
        '_Label4_5
        '
        Me._Label4_5.BackColor = System.Drawing.Color.Transparent
        Me._Label4_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label4_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label4_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label4_5.Location = New System.Drawing.Point(272, 644)
        Me._Label4_5.Name = "_Label4_5"
        Me._Label4_5.Size = New System.Drawing.Size(65, 17)
        Me._Label4_5.TabIndex = 59
        Me._Label4_5.Text = "Người nhận"
        '
        '_Label4_4
        '
        Me._Label4_4.BackColor = System.Drawing.Color.Transparent
        Me._Label4_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label4_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label4_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label4_4.Location = New System.Drawing.Point(72, 644)
        Me._Label4_4.Name = "_Label4_4"
        Me._Label4_4.Size = New System.Drawing.Size(65, 17)
        Me._Label4_4.TabIndex = 58
        Me._Label4_4.Text = "Người giao"
        '
        '_Label5_5
        '
        Me._Label5_5.BackColor = System.Drawing.Color.Transparent
        Me._Label5_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label5_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label5_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label5_5.Location = New System.Drawing.Point(16, 520)
        Me._Label5_5.Name = "_Label5_5"
        Me._Label5_5.Size = New System.Drawing.Size(137, 17)
        Me._Label5_5.TabIndex = 57
        Me._Label5_5.Text = "- Dự toán công trình"
        '
        '_Label5_4
        '
        Me._Label5_4.BackColor = System.Drawing.Color.Transparent
        Me._Label5_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label5_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label5_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label5_4.Location = New System.Drawing.Point(16, 496)
        Me._Label5_4.Name = "_Label5_4"
        Me._Label5_4.Size = New System.Drawing.Size(137, 17)
        Me._Label5_4.TabIndex = 56
        Me._Label5_4.Text = "- Hợp đồng kinh tế"
        '
        '_Label5_3
        '
        Me._Label5_3.BackColor = System.Drawing.Color.Transparent
        Me._Label5_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label5_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label5_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label5_3.Location = New System.Drawing.Point(16, 472)
        Me._Label5_3.Name = "_Label5_3"
        Me._Label5_3.Size = New System.Drawing.Size(137, 17)
        Me._Label5_3.TabIndex = 55
        Me._Label5_3.Text = "- Chứng từ ngân hàng tháng"
        '
        '_Label5_2
        '
        Me._Label5_2.BackColor = System.Drawing.Color.Transparent
        Me._Label5_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label5_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label5_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label5_2.Location = New System.Drawing.Point(16, 448)
        Me._Label5_2.Name = "_Label5_2"
        Me._Label5_2.Size = New System.Drawing.Size(153, 17)
        Me._Label5_2.TabIndex = 54
        Me._Label5_2.Text = "- Biên lai nộp BHKH+BHYT quý"
        '
        '_Label5_1
        '
        Me._Label5_1.BackColor = System.Drawing.Color.Transparent
        Me._Label5_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label5_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label5_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label5_1.Location = New System.Drawing.Point(16, 424)
        Me._Label5_1.Name = "_Label5_1"
        Me._Label5_1.Size = New System.Drawing.Size(145, 17)
        Me._Label5_1.TabIndex = 53
        Me._Label5_1.Text = "- Biên lai nộp thuế TNDN quý"
        '
        '_Label5_0
        '
        Me._Label5_0.BackColor = System.Drawing.Color.Transparent
        Me._Label5_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label5_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label5_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label5_0.Location = New System.Drawing.Point(16, 400)
        Me._Label5_0.Name = "_Label5_0"
        Me._Label5_0.Size = New System.Drawing.Size(153, 17)
        Me._Label5_0.TabIndex = 52
        Me._Label5_0.Text = "- Biên lai nộp thuế GTGT tháng"
        '
        '_Label4_3
        '
        Me._Label4_3.BackColor = System.Drawing.Color.Transparent
        Me._Label4_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label4_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label4_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label4_3.Location = New System.Drawing.Point(16, 352)
        Me._Label4_3.Name = "_Label4_3"
        Me._Label4_3.Size = New System.Drawing.Size(137, 17)
        Me._Label4_3.TabIndex = 51
        Me._Label4_3.Text = "- BHXH+BHYT tháng"
        '
        '_Label4_2
        '
        Me._Label4_2.BackColor = System.Drawing.Color.Transparent
        Me._Label4_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label4_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label4_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label4_2.Location = New System.Drawing.Point(16, 328)
        Me._Label4_2.Name = "_Label4_2"
        Me._Label4_2.Size = New System.Drawing.Size(137, 17)
        Me._Label4_2.TabIndex = 50
        Me._Label4_2.Text = "- Thuế môn bài năm"
        '
        '_Label4_1
        '
        Me._Label4_1.BackColor = System.Drawing.Color.Transparent
        Me._Label4_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label4_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label4_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label4_1.Location = New System.Drawing.Point(16, 304)
        Me._Label4_1.Name = "_Label4_1"
        Me._Label4_1.Size = New System.Drawing.Size(137, 17)
        Me._Label4_1.TabIndex = 49
        Me._Label4_1.Text = "- Thuế TNDN quý"
        '
        '_Label4_0
        '
        Me._Label4_0.BackColor = System.Drawing.Color.Transparent
        Me._Label4_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label4_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label4_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label4_0.Location = New System.Drawing.Point(16, 280)
        Me._Label4_0.Name = "_Label4_0"
        Me._Label4_0.Size = New System.Drawing.Size(137, 17)
        Me._Label4_0.TabIndex = 48
        Me._Label4_0.Text = "- Thuế GTGT tháng"
        '
        '_Label3_6
        '
        Me._Label3_6.BackColor = System.Drawing.Color.Transparent
        Me._Label3_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_6.Location = New System.Drawing.Point(16, 208)
        Me._Label3_6.Name = "_Label3_6"
        Me._Label3_6.Size = New System.Drawing.Size(137, 17)
        Me._Label3_6.TabIndex = 47
        Me._Label3_6.Text = "- Báo cáo quyết toán năm"
        '
        '_Label3_5
        '
        Me._Label3_5.BackColor = System.Drawing.Color.Transparent
        Me._Label3_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_5.Location = New System.Drawing.Point(16, 232)
        Me._Label3_5.Name = "_Label3_5"
        Me._Label3_5.Size = New System.Drawing.Size(137, 17)
        Me._Label3_5.TabIndex = 46
        Me._Label3_5.Text = "- Sổ sách kế toán tháng"
        '
        '_Label3_4
        '
        Me._Label3_4.BackColor = System.Drawing.Color.Transparent
        Me._Label3_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_4.Location = New System.Drawing.Point(16, 184)
        Me._Label3_4.Name = "_Label3_4"
        Me._Label3_4.Size = New System.Drawing.Size(137, 17)
        Me._Label3_4.TabIndex = 45
        Me._Label3_4.Text = "- Báo cáo thuế tháng"
        '
        '_Label3_3
        '
        Me._Label3_3.BackColor = System.Drawing.Color.Transparent
        Me._Label3_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_3.Location = New System.Drawing.Point(16, 136)
        Me._Label3_3.Name = "_Label3_3"
        Me._Label3_3.Size = New System.Drawing.Size(137, 17)
        Me._Label3_3.TabIndex = 44
        Me._Label3_3.Text = "- Biên lai nộp BHXH+BHYT"
        '
        '_Label3_2
        '
        Me._Label3_2.BackColor = System.Drawing.Color.Transparent
        Me._Label3_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_2.Location = New System.Drawing.Point(16, 112)
        Me._Label3_2.Name = "_Label3_2"
        Me._Label3_2.Size = New System.Drawing.Size(137, 17)
        Me._Label3_2.TabIndex = 43
        Me._Label3_2.Text = "- Biên lai nộp thuế"
        '
        '_Label3_1
        '
        Me._Label3_1.BackColor = System.Drawing.Color.Transparent
        Me._Label3_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_1.Location = New System.Drawing.Point(16, 88)
        Me._Label3_1.Name = "_Label3_1"
        Me._Label3_1.Size = New System.Drawing.Size(137, 17)
        Me._Label3_1.TabIndex = 42
        Me._Label3_1.Text = "- Hoá đơn bán ra (liên 3)"
        '
        '_Label3_0
        '
        Me._Label3_0.BackColor = System.Drawing.Color.Transparent
        Me._Label3_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_0.Location = New System.Drawing.Point(16, 64)
        Me._Label3_0.Name = "_Label3_0"
        Me._Label3_0.Size = New System.Drawing.Size(137, 17)
        Me._Label3_0.TabIndex = 41
        Me._Label3_0.Text = "- Hoá đơn mua vào (liên 2)"
        '
        '_Label2_2
        '
        Me._Label2_2.BackColor = System.Drawing.Color.Transparent
        Me._Label2_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label2_2.Location = New System.Drawing.Point(8, 376)
        Me._Label2_2.Name = "_Label2_2"
        Me._Label2_2.Size = New System.Drawing.Size(161, 17)
        Me._Label2_2.TabIndex = 40
        Me._Label2_2.Text = "3. Chứng từ cần cung cấp"
        '
        '_Label2_1
        '
        Me._Label2_1.BackColor = System.Drawing.Color.Transparent
        Me._Label2_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label2_1.Location = New System.Drawing.Point(8, 256)
        Me._Label2_1.Name = "_Label2_1"
        Me._Label2_1.Size = New System.Drawing.Size(145, 17)
        Me._Label2_1.TabIndex = 39
        Me._Label2_1.Text = "2. Tiền thuƠ ph¶i nép"
        '
        '_Label2_0
        '
        Me._Label2_0.BackColor = System.Drawing.Color.Transparent
        Me._Label2_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label2_0.Location = New System.Drawing.Point(8, 40)
        Me._Label2_0.Name = "_Label2_0"
        Me._Label2_0.Size = New System.Drawing.Size(169, 17)
        Me._Label2_0.TabIndex = 38
        Me._Label2_0.Text = "1. Sổ sách chứng từ kế toán"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(80, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 25)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Biên bản bàn giao"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Command_3
        '
        Me._Command_3.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_3.Location = New System.Drawing.Point(320, 688)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 32
        Me._Command_3.Text = "Trở &về"
        '
        '_Command_2
        '
        Me._Command_2.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Print
        Me._Command_2.Location = New System.Drawing.Point(240, 688)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 31
        Me._Command_2.Text = "&In"
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Preview
        Me._Command_1.Location = New System.Drawing.Point(160, 688)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 30
        Me._Command_1.Text = "&Xem"
        '
        '_Command_0
        '
        Me._Command_0.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Save
        Me._Command_0.Location = New System.Drawing.Point(80, 688)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 29
        Me._Command_0.Text = "&Ghi"
        '
        '_Command1_0
        '
        Me._Command1_0.BackColor = System.Drawing.Color.Silver
        Me._Command1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_0.Image = CType(resources.GetObject("_Command1_0.Image"), System.Drawing.Image)
        Me._Command1_0.Location = New System.Drawing.Point(80, 688)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(73, 25)
        Me._Command1_0.TabIndex = 33
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&Save"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        '_Command1_3
        '
        Me._Command1_3.BackColor = System.Drawing.Color.Silver
        Me._Command1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_3.Image = CType(resources.GetObject("_Command1_3.Image"), System.Drawing.Image)
        Me._Command1_3.Location = New System.Drawing.Point(320, 688)
        Me._Command1_3.Name = "_Command1_3"
        Me._Command1_3.Size = New System.Drawing.Size(73, 25)
        Me._Command1_3.TabIndex = 36
        Me._Command1_3.TabStop = False
        Me._Command1_3.Tag = "&Return"
        Me._Command1_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_3.UseVisualStyleBackColor = False
        Me._Command1_3.Visible = False
        '
        '_Command1_1
        '
        Me._Command1_1.BackColor = System.Drawing.Color.Silver
        Me._Command1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_1.Image = CType(resources.GetObject("_Command1_1.Image"), System.Drawing.Image)
        Me._Command1_1.Location = New System.Drawing.Point(160, 688)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(73, 25)
        Me._Command1_1.TabIndex = 34
        Me._Command1_1.TabStop = False
        Me._Command1_1.Tag = "&View"
        Me._Command1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_1.UseVisualStyleBackColor = False
        Me._Command1_1.Visible = False
        '
        '_Command1_2
        '
        Me._Command1_2.BackColor = System.Drawing.Color.Silver
        Me._Command1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_2.Image = CType(resources.GetObject("_Command1_2.Image"), System.Drawing.Image)
        Me._Command1_2.Location = New System.Drawing.Point(240, 688)
        Me._Command1_2.Name = "_Command1_2"
        Me._Command1_2.Size = New System.Drawing.Size(73, 25)
        Me._Command1_2.TabIndex = 35
        Me._Command1_2.TabStop = False
        Me._Command1_2.Tag = "&Print"
        Me._Command1_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_2.UseVisualStyleBackColor = False
        Me._Command1_2.Visible = False
        '
        'FrmBbbg
        '
        'Me.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.Appearance.Options.UseFont = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(402, 724)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Chungtu_10)
        Me.Controls.Add(Me._Chungtu_9)
        Me.Controls.Add(Me._Chungtu_8)
        Me.Controls.Add(Me._Sosach_7)
        Me.Controls.Add(Me._Sosach_6)
        Me.Controls.Add(Me._Sosach_5)
        Me.Controls.Add(Me._Sosach_8)
        Me.Controls.Add(Me.CboThang)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me._Command1_3)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Command1_2)
        Me.Controls.Add(Me._Chungtu_7)
        Me.Controls.Add(Me._Chungtu_6)
        Me.Controls.Add(Me._Chungtu_5)
        Me.Controls.Add(Me._Chungtu_4)
        Me.Controls.Add(Me._Chungtu_3)
        Me.Controls.Add(Me._Chungtu_2)
        Me.Controls.Add(Me._Chungtu_1)
        Me.Controls.Add(Me.Nguoinhan)
        Me.Controls.Add(Me.Nguoigiao)
        Me.Controls.Add(Me._Tienthue_4)
        Me.Controls.Add(Me._Tienthue_3)
        Me.Controls.Add(Me._Tienthue_2)
        Me.Controls.Add(Me._Tienthue_1)
        Me.Controls.Add(Me._Sosach_4)
        Me.Controls.Add(Me._Sosach_3)
        Me.Controls.Add(Me._Sosach_2)
        Me.Controls.Add(Me._Sosach_1)
        Me.Controls.Add(Me._Chungtu_14)
        Me.Controls.Add(Me._Chungtu_13)
        Me.Controls.Add(Me._Chungtu_12)
        Me.Controls.Add(Me._Chungtu_11)
        Me.Controls.Add(Me._Label3_16)
        Me.Controls.Add(Me._Label3_15)
        Me.Controls.Add(Me._Label3_14)
        Me.Controls.Add(Me._Label3_13)
        Me.Controls.Add(Me._Label4_7)
        Me.Controls.Add(Me._Label3_12)
        Me.Controls.Add(Me._Label3_11)
        Me.Controls.Add(Me._Label4_6)
        Me.Controls.Add(Me._Label3_10)
        Me.Controls.Add(Me._Label3_9)
        Me.Controls.Add(Me._Label3_8)
        Me.Controls.Add(Me._Label3_7)
        Me.Controls.Add(Me._Label5_6)
        Me.Controls.Add(Me._Label4_5)
        Me.Controls.Add(Me._Label4_4)
        Me.Controls.Add(Me._Label5_5)
        Me.Controls.Add(Me._Label5_4)
        Me.Controls.Add(Me._Label5_3)
        Me.Controls.Add(Me._Label5_2)
        Me.Controls.Add(Me._Label5_1)
        Me.Controls.Add(Me._Label5_0)
        Me.Controls.Add(Me._Label4_3)
        Me.Controls.Add(Me._Label4_2)
        Me.Controls.Add(Me._Label4_1)
        Me.Controls.Add(Me._Label4_0)
        Me.Controls.Add(Me._Label3_6)
        Me.Controls.Add(Me._Label3_5)
        Me.Controls.Add(Me._Label3_4)
        Me.Controls.Add(Me._Label3_3)
        Me.Controls.Add(Me._Label3_2)
        Me.Controls.Add(Me._Label3_1)
        Me.Controls.Add(Me._Label3_0)
        Me.Controls.Add(Me._Label2_2)
        Me.Controls.Add(Me._Label2_1)
        Me.Controls.Add(Me._Label2_0)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBbbg"
        Me.ShowInTaskbar = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Biên bản bàn giao"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializeTienthue()
		Me.Tienthue(4) = _Tienthue_4
		Me.Tienthue(3) = _Tienthue_3
		Me.Tienthue(2) = _Tienthue_2
		Me.Tienthue(1) = _Tienthue_1
	End Sub
	Sub InitializeSosach()
		Me.Sosach(7) = _Sosach_7
		Me.Sosach(6) = _Sosach_6
		Me.Sosach(5) = _Sosach_5
		Me.Sosach(8) = _Sosach_8
		Me.Sosach(4) = _Sosach_4
		Me.Sosach(3) = _Sosach_3
		Me.Sosach(2) = _Sosach_2
		Me.Sosach(1) = _Sosach_1
	End Sub
	Sub InitializeLabel5()
		Me.Label5(6) = _Label5_6
		Me.Label5(5) = _Label5_5
		Me.Label5(4) = _Label5_4
		Me.Label5(3) = _Label5_3
		Me.Label5(2) = _Label5_2
		Me.Label5(1) = _Label5_1
		Me.Label5(0) = _Label5_0
	End Sub
	Sub InitializeLabel4()
		Me.Label4(7) = _Label4_7
		Me.Label4(6) = _Label4_6
		Me.Label4(5) = _Label4_5
		Me.Label4(4) = _Label4_4
		Me.Label4(3) = _Label4_3
		Me.Label4(2) = _Label4_2
		Me.Label4(1) = _Label4_1
		Me.Label4(0) = _Label4_0
	End Sub
	Sub InitializeLabel3()
		Me.Label3(16) = _Label3_16
		Me.Label3(15) = _Label3_15
		Me.Label3(14) = _Label3_14
		Me.Label3(13) = _Label3_13
		Me.Label3(12) = _Label3_12
		Me.Label3(11) = _Label3_11
		Me.Label3(10) = _Label3_10
		Me.Label3(9) = _Label3_9
		Me.Label3(8) = _Label3_8
		Me.Label3(7) = _Label3_7
		Me.Label3(6) = _Label3_6
		Me.Label3(5) = _Label3_5
		Me.Label3(4) = _Label3_4
		Me.Label3(3) = _Label3_3
		Me.Label3(2) = _Label3_2
		Me.Label3(1) = _Label3_1
		Me.Label3(0) = _Label3_0
	End Sub
	Sub InitializeLabel2()
		Me.Label2(2) = _Label2_2
		Me.Label2(1) = _Label2_1
		Me.Label2(0) = _Label2_0
	End Sub
	Sub InitializeCommand1()
		Me.Command1(0) = _Command1_0
		Me.Command1(3) = _Command1_3
		Me.Command1(1) = _Command1_1
		Me.Command1(2) = _Command1_2
	End Sub
	Sub InitializeCommand()
		Me.Command(3) = _Command_3
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
	Sub InitializeChungtu()
		Me.Chungtu(10) = _Chungtu_10
		Me.Chungtu(9) = _Chungtu_9
		Me.Chungtu(8) = _Chungtu_8
		Me.Chungtu(7) = _Chungtu_7
		Me.Chungtu(6) = _Chungtu_6
		Me.Chungtu(5) = _Chungtu_5
		Me.Chungtu(4) = _Chungtu_4
		Me.Chungtu(3) = _Chungtu_3
		Me.Chungtu(2) = _Chungtu_2
		Me.Chungtu(1) = _Chungtu_1
		Me.Chungtu(14) = _Chungtu_14
		Me.Chungtu(13) = _Chungtu_13
		Me.Chungtu(12) = _Chungtu_12
		Me.Chungtu(11) = _Chungtu_11
	End Sub
#End Region 
End Class
