<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPhucap
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
        isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		InitializetxtVT()
		InitializeSSOpt()
		InitializeOptloai()
		InitializeLine()
		InitializeLabel1()
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
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Public WithEvents SSCmdF As System.Windows.Forms.Button
    Public WithEvents CboThang As ComboBoxEx.ComboBoxExt
    Public WithEvents ChkGiamtru As System.Windows.Forms.CheckBox
    Private WithEvents _txtVT_4 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_14 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_15 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_16 As System.Windows.Forms.TextBox
    Private WithEvents _Optloai_1 As System.Windows.Forms.RadioButton
    Private WithEvents _Optloai_2 As System.Windows.Forms.RadioButton
    Private WithEvents _txtVT_13 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_12 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_11 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_10 As System.Windows.Forms.TextBox
    Public WithEvents Chloai As System.Windows.Forms.CheckBox
    Private WithEvents _txtVT_3 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_9 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_8 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_7 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_6 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_5 As System.Windows.Forms.TextBox
    Private WithEvents _Line_1 As System.Windows.Forms.Label
    Private WithEvents _Label1_5 As System.Windows.Forms.Label
    Private WithEvents _Line_4 As System.Windows.Forms.Label
    Private WithEvents _Label1_15 As System.Windows.Forms.Label
    Private WithEvents _Label1_16 As System.Windows.Forms.Label
    Private WithEvents _Line_14 As System.Windows.Forms.Label
    Private WithEvents _Label1_17 As System.Windows.Forms.Label
    Private WithEvents _Line_15 As System.Windows.Forms.Label
    Private WithEvents _Label1_14 As System.Windows.Forms.Label
    Private WithEvents _Label1_13 As System.Windows.Forms.Label
    Private WithEvents _Label1_12 As System.Windows.Forms.Label
    Private WithEvents _Line_13 As System.Windows.Forms.Label
    Private WithEvents _Label1_11 As System.Windows.Forms.Label
    Private WithEvents _Line_3 As System.Windows.Forms.Label
    Private WithEvents _Label1_10 As System.Windows.Forms.Label
    Private WithEvents _Line_2 As System.Windows.Forms.Label
    Private WithEvents _Label1_3 As System.Windows.Forms.Label
    Private WithEvents _Line_0 As System.Windows.Forms.Label
    Private WithEvents _Label1_2 As System.Windows.Forms.Label
    Private WithEvents _Line_11 As System.Windows.Forms.Label
    Private WithEvents _Line_10 As System.Windows.Forms.Label
    Private WithEvents _Line_12 As System.Windows.Forms.Label
    Private WithEvents _Label1_9 As System.Windows.Forms.Label
    Private WithEvents _Line_9 As System.Windows.Forms.Label
    Private WithEvents _Label1_8 As System.Windows.Forms.Label
    Private WithEvents _Line_8 As System.Windows.Forms.Label
    Private WithEvents _Label1_7 As System.Windows.Forms.Label
    Private WithEvents _Line_7 As System.Windows.Forms.Label
    Private WithEvents _Label1_6 As System.Windows.Forms.Label
    Private WithEvents _Line_6 As System.Windows.Forms.Label
    Private WithEvents _Line_5 As System.Windows.Forms.Label
    Private WithEvents _Label1_4 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Private WithEvents _txtVT_0 As System.Windows.Forms.TextBox
    Public WithEvents txtF As System.Windows.Forms.TextBox
    Public WithEvents SSCmdF1 As System.Windows.Forms.Button
    Private WithEvents _SSOpt_1 As System.Windows.Forms.RadioButton
    Private WithEvents _SSOpt_0 As System.Windows.Forms.RadioButton
    Public WithEvents CboLoai As ComboBoxEx.ComboBoxExt
    Public WithEvents LstVt As System.Windows.Forms.ListBox
    Private WithEvents _Label1_0 As System.Windows.Forms.Label
    Private WithEvents _Label1_1 As System.Windows.Forms.Label
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Public Command(3) As System.Windows.Forms.Button
    Public Command1(3) As System.Windows.Forms.Button
    Public Label(17) As System.Windows.Forms.Label
    Public Label1(17) As System.Windows.Forms.Label
    Public Line(15) As System.Windows.Forms.Label
    Public Optloai(2) As System.Windows.Forms.RadioButton
    Public SSOpt(1) As System.Windows.Forms.RadioButton
    Public txtVT(16) As System.Windows.Forms.TextBox
    'Private listBoxHelper1 As Artinsoft.VB6.Gui.ListBoxHelper
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_1 = New System.Windows.Forms.Button
        Me.SSCmdF = New System.Windows.Forms.Button
        Me.CboThang = New ComboBoxEx.ComboBoxExt
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.ChkGiamtru = New System.Windows.Forms.CheckBox
        Me._txtVT_4 = New System.Windows.Forms.TextBox
        Me._txtVT_14 = New System.Windows.Forms.TextBox
        Me._txtVT_15 = New System.Windows.Forms.TextBox
        Me._txtVT_16 = New System.Windows.Forms.TextBox
        Me._Optloai_1 = New System.Windows.Forms.RadioButton
        Me._Optloai_2 = New System.Windows.Forms.RadioButton
        Me._txtVT_13 = New System.Windows.Forms.TextBox
        Me._txtVT_12 = New System.Windows.Forms.TextBox
        Me._txtVT_11 = New System.Windows.Forms.TextBox
        Me._txtVT_10 = New System.Windows.Forms.TextBox
        Me.Chloai = New System.Windows.Forms.CheckBox
        Me._txtVT_3 = New System.Windows.Forms.TextBox
        Me._txtVT_2 = New System.Windows.Forms.TextBox
        Me._txtVT_1 = New System.Windows.Forms.TextBox
        Me._txtVT_9 = New System.Windows.Forms.TextBox
        Me._txtVT_8 = New System.Windows.Forms.TextBox
        Me._txtVT_7 = New System.Windows.Forms.TextBox
        Me._txtVT_6 = New System.Windows.Forms.TextBox
        Me._txtVT_5 = New System.Windows.Forms.TextBox
        Me._Line_1 = New System.Windows.Forms.Label
        Me._Label1_5 = New System.Windows.Forms.Label
        Me._Line_4 = New System.Windows.Forms.Label
        Me._Label1_15 = New System.Windows.Forms.Label
        Me._Label1_16 = New System.Windows.Forms.Label
        Me._Line_14 = New System.Windows.Forms.Label
        Me._Label1_17 = New System.Windows.Forms.Label
        Me._Line_15 = New System.Windows.Forms.Label
        Me._Label1_14 = New System.Windows.Forms.Label
        Me._Label1_13 = New System.Windows.Forms.Label
        Me._Label1_12 = New System.Windows.Forms.Label
        Me._Line_13 = New System.Windows.Forms.Label
        Me._Label1_11 = New System.Windows.Forms.Label
        Me._Line_3 = New System.Windows.Forms.Label
        Me._Label1_10 = New System.Windows.Forms.Label
        Me._Line_2 = New System.Windows.Forms.Label
        Me._Label1_3 = New System.Windows.Forms.Label
        Me._Line_0 = New System.Windows.Forms.Label
        Me._Label1_2 = New System.Windows.Forms.Label
        Me._Line_11 = New System.Windows.Forms.Label
        Me._Line_10 = New System.Windows.Forms.Label
        Me._Line_12 = New System.Windows.Forms.Label
        Me._Label1_9 = New System.Windows.Forms.Label
        Me._Line_9 = New System.Windows.Forms.Label
        Me._Label1_8 = New System.Windows.Forms.Label
        Me._Line_8 = New System.Windows.Forms.Label
        Me._Label1_7 = New System.Windows.Forms.Label
        Me._Line_7 = New System.Windows.Forms.Label
        Me._Label1_6 = New System.Windows.Forms.Label
        Me._Line_6 = New System.Windows.Forms.Label
        Me._Line_5 = New System.Windows.Forms.Label
        Me._Label1_4 = New System.Windows.Forms.Label
        Me._txtVT_0 = New System.Windows.Forms.TextBox
        Me.txtF = New System.Windows.Forms.TextBox
        Me.SSCmdF1 = New System.Windows.Forms.Button
        Me._SSOpt_1 = New System.Windows.Forms.RadioButton
        Me._SSOpt_0 = New System.Windows.Forms.RadioButton
        Me.CboLoai = New ComboBoxEx.ComboBoxExt
        Me.LstVt = New System.Windows.Forms.ListBox
        Me._Label1_0 = New System.Windows.Forms.Label
        Me._Label1_1 = New System.Windows.Forms.Label
        Me._Label_17 = New System.Windows.Forms.Label
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(496, 442)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 51
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        'SSCmdF
        '
        Me.SSCmdF.Image = Global.UNET.My.Resources.Resources.search3_16
        Me.SSCmdF.Location = New System.Drawing.Point(288, 448)
        Me.SSCmdF.Name = "SSCmdF"
        Me.SSCmdF.Size = New System.Drawing.Size(30, 19)
        Me.SSCmdF.TabIndex = 30
        '
        'CboThang
        '
        Me.CboThang.BackColor = System.Drawing.SystemColors.Window
        Me.CboThang.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboThang.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboThang.Location = New System.Drawing.Point(408, 56)
        Me.CboThang.Name = "CboThang"
        Me.CboThang.Size = New System.Drawing.Size(65, 21)
        Me.CboThang.TabIndex = 3
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Window
        Me.Frame1.Controls.Add(Me.ChkGiamtru)
        Me.Frame1.Controls.Add(Me._txtVT_4)
        Me.Frame1.Controls.Add(Me._txtVT_14)
        Me.Frame1.Controls.Add(Me._txtVT_15)
        Me.Frame1.Controls.Add(Me._txtVT_16)
        Me.Frame1.Controls.Add(Me._Optloai_1)
        Me.Frame1.Controls.Add(Me._Optloai_2)
        Me.Frame1.Controls.Add(Me._txtVT_13)
        Me.Frame1.Controls.Add(Me._txtVT_12)
        Me.Frame1.Controls.Add(Me._txtVT_11)
        Me.Frame1.Controls.Add(Me._txtVT_10)
        Me.Frame1.Controls.Add(Me.Chloai)
        Me.Frame1.Controls.Add(Me._txtVT_3)
        Me.Frame1.Controls.Add(Me._txtVT_2)
        Me.Frame1.Controls.Add(Me._txtVT_1)
        Me.Frame1.Controls.Add(Me._txtVT_9)
        Me.Frame1.Controls.Add(Me._txtVT_8)
        Me.Frame1.Controls.Add(Me._txtVT_7)
        Me.Frame1.Controls.Add(Me._txtVT_6)
        Me.Frame1.Controls.Add(Me._txtVT_5)
        Me.Frame1.Controls.Add(Me._Line_1)
        Me.Frame1.Controls.Add(Me._Label1_5)
        Me.Frame1.Controls.Add(Me._Line_4)
        Me.Frame1.Controls.Add(Me._Label1_15)
        Me.Frame1.Controls.Add(Me._Label1_16)
        Me.Frame1.Controls.Add(Me._Line_14)
        Me.Frame1.Controls.Add(Me._Label1_17)
        Me.Frame1.Controls.Add(Me._Line_15)
        Me.Frame1.Controls.Add(Me._Label1_14)
        Me.Frame1.Controls.Add(Me._Label1_13)
        Me.Frame1.Controls.Add(Me._Label1_12)
        Me.Frame1.Controls.Add(Me._Line_13)
        Me.Frame1.Controls.Add(Me._Label1_11)
        Me.Frame1.Controls.Add(Me._Line_3)
        Me.Frame1.Controls.Add(Me._Label1_10)
        Me.Frame1.Controls.Add(Me._Line_2)
        Me.Frame1.Controls.Add(Me._Label1_3)
        Me.Frame1.Controls.Add(Me._Line_0)
        Me.Frame1.Controls.Add(Me._Label1_2)
        Me.Frame1.Controls.Add(Me._Line_11)
        Me.Frame1.Controls.Add(Me._Line_10)
        Me.Frame1.Controls.Add(Me._Line_12)
        Me.Frame1.Controls.Add(Me._Label1_9)
        Me.Frame1.Controls.Add(Me._Line_9)
        Me.Frame1.Controls.Add(Me._Label1_8)
        Me.Frame1.Controls.Add(Me._Line_8)
        Me.Frame1.Controls.Add(Me._Label1_7)
        Me.Frame1.Controls.Add(Me._Line_7)
        Me.Frame1.Controls.Add(Me._Label1_6)
        Me.Frame1.Controls.Add(Me._Line_6)
        Me.Frame1.Controls.Add(Me._Line_5)
        Me.Frame1.Controls.Add(Me._Label1_4)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(320, 88)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(393, 329)
        Me.Frame1.TabIndex = 37
        Me.Frame1.TabStop = False
        Me.Frame1.Tag = "Coefficient / Levels of allowance"
        Me.Frame1.Text = " Hệ số / Mức phụ cấp"
        '
        'ChkGiamtru
        '
        Me.ChkGiamtru.BackColor = System.Drawing.Color.White
        Me.ChkGiamtru.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkGiamtru.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkGiamtru.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkGiamtru.Location = New System.Drawing.Point(227, 24)
        Me.ChkGiamtru.Name = "ChkGiamtru"
        Me.ChkGiamtru.Size = New System.Drawing.Size(121, 17)
        Me.ChkGiamtru.TabIndex = 10
        Me.ChkGiamtru.Tag = "Decrease levels"
        Me.ChkGiamtru.Text = "Mức giảm trừ lương"
        Me.ChkGiamtru.UseVisualStyleBackColor = False
        '
        '_txtVT_4
        '
        Me._txtVT_4.AcceptsReturn = True
        Me._txtVT_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_4.Location = New System.Drawing.Point(288, 80)
        Me._txtVT_4.MaxLength = 100
        Me._txtVT_4.Name = "_txtVT_4"
        Me._txtVT_4.Size = New System.Drawing.Size(97, 13)
        Me._txtVT_4.TabIndex = 12
        Me._txtVT_4.Text = "0"
        Me._txtVT_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_14
        '
        Me._txtVT_14.AcceptsReturn = True
        Me._txtVT_14.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_14.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_14.Location = New System.Drawing.Point(288, 48)
        Me._txtVT_14.MaxLength = 100
        Me._txtVT_14.Name = "_txtVT_14"
        Me._txtVT_14.Size = New System.Drawing.Size(97, 13)
        Me._txtVT_14.TabIndex = 11
        Me._txtVT_14.Text = "0"
        Me._txtVT_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_15
        '
        Me._txtVT_15.AcceptsReturn = True
        Me._txtVT_15.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_15.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_15.Location = New System.Drawing.Point(288, 112)
        Me._txtVT_15.MaxLength = 100
        Me._txtVT_15.Name = "_txtVT_15"
        Me._txtVT_15.Size = New System.Drawing.Size(97, 13)
        Me._txtVT_15.TabIndex = 13
        Me._txtVT_15.Text = "0"
        Me._txtVT_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_16
        '
        Me._txtVT_16.AcceptsReturn = True
        Me._txtVT_16.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_16.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_16.Location = New System.Drawing.Point(296, 144)
        Me._txtVT_16.MaxLength = 100
        Me._txtVT_16.Name = "_txtVT_16"
        Me._txtVT_16.ReadOnly = True
        Me._txtVT_16.Size = New System.Drawing.Size(89, 13)
        Me._txtVT_16.TabIndex = 14
        Me._txtVT_16.Text = "0"
        Me._txtVT_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Optloai_1
        '
        Me._Optloai_1.BackColor = System.Drawing.SystemColors.Window
        Me._Optloai_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Optloai_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Optloai_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Optloai_1.Location = New System.Drawing.Point(8, 24)
        Me._Optloai_1.Name = "_Optloai_1"
        Me._Optloai_1.Size = New System.Drawing.Size(97, 17)
        Me._Optloai_1.TabIndex = 4
        Me._Optloai_1.TabStop = True
        Me._Optloai_1.Tag = "Coefficient"
        Me._Optloai_1.Text = "Hệ Số Phụ cấp"
        Me._Optloai_1.UseVisualStyleBackColor = False
        '
        '_Optloai_2
        '
        Me._Optloai_2.BackColor = System.Drawing.SystemColors.Window
        Me._Optloai_2.Checked = True
        Me._Optloai_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Optloai_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Optloai_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Optloai_2.Location = New System.Drawing.Point(112, 24)
        Me._Optloai_2.Name = "_Optloai_2"
        Me._Optloai_2.Size = New System.Drawing.Size(89, 17)
        Me._Optloai_2.TabIndex = 5
        Me._Optloai_2.TabStop = True
        Me._Optloai_2.Tag = "Increase levels"
        Me._Optloai_2.Text = "Mức phụ cấp"
        Me._Optloai_2.UseVisualStyleBackColor = False
        '
        '_txtVT_13
        '
        Me._txtVT_13.AcceptsReturn = True
        Me._txtVT_13.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_13.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_13.Location = New System.Drawing.Point(288, 296)
        Me._txtVT_13.MaxLength = 100
        Me._txtVT_13.Name = "_txtVT_13"
        Me._txtVT_13.Size = New System.Drawing.Size(97, 13)
        Me._txtVT_13.TabIndex = 23
        Me._txtVT_13.Text = "0"
        Me._txtVT_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_12
        '
        Me._txtVT_12.AcceptsReturn = True
        Me._txtVT_12.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_12.Location = New System.Drawing.Point(96, 296)
        Me._txtVT_12.MaxLength = 100
        Me._txtVT_12.Name = "_txtVT_12"
        Me._txtVT_12.Size = New System.Drawing.Size(105, 13)
        Me._txtVT_12.TabIndex = 22
        Me._txtVT_12.Text = "..."
        '
        '_txtVT_11
        '
        Me._txtVT_11.AcceptsReturn = True
        Me._txtVT_11.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_11.Location = New System.Drawing.Point(288, 264)
        Me._txtVT_11.MaxLength = 100
        Me._txtVT_11.Name = "_txtVT_11"
        Me._txtVT_11.Size = New System.Drawing.Size(97, 13)
        Me._txtVT_11.TabIndex = 21
        Me._txtVT_11.Text = "0"
        Me._txtVT_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_10
        '
        Me._txtVT_10.AcceptsReturn = True
        Me._txtVT_10.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_10.Location = New System.Drawing.Point(96, 264)
        Me._txtVT_10.MaxLength = 100
        Me._txtVT_10.Name = "_txtVT_10"
        Me._txtVT_10.Size = New System.Drawing.Size(105, 13)
        Me._txtVT_10.TabIndex = 20
        Me._txtVT_10.Text = "..."
        '
        'Chloai
        '
        Me.Chloai.BackColor = System.Drawing.Color.White
        Me.Chloai.Cursor = System.Windows.Forms.Cursors.Default
        Me.Chloai.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chloai.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chloai.Location = New System.Drawing.Point(8, 176)
        Me.Chloai.Name = "Chloai"
        Me.Chloai.Size = New System.Drawing.Size(121, 17)
        Me.Chloai.TabIndex = 15
        Me.Chloai.Tag = "Other income"
        Me.Chloai.Text = "Thu nhập khác"
        Me.Chloai.UseVisualStyleBackColor = False
        '
        '_txtVT_3
        '
        Me._txtVT_3.AcceptsReturn = True
        Me._txtVT_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_3.Location = New System.Drawing.Point(96, 112)
        Me._txtVT_3.MaxLength = 100
        Me._txtVT_3.Name = "_txtVT_3"
        Me._txtVT_3.Size = New System.Drawing.Size(105, 13)
        Me._txtVT_3.TabIndex = 8
        Me._txtVT_3.Text = "0"
        Me._txtVT_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_2
        '
        Me._txtVT_2.AcceptsReturn = True
        Me._txtVT_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_2.Location = New System.Drawing.Point(96, 80)
        Me._txtVT_2.MaxLength = 100
        Me._txtVT_2.Name = "_txtVT_2"
        Me._txtVT_2.Size = New System.Drawing.Size(105, 13)
        Me._txtVT_2.TabIndex = 7
        Me._txtVT_2.Text = "0"
        Me._txtVT_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_1
        '
        Me._txtVT_1.AcceptsReturn = True
        Me._txtVT_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_1.Location = New System.Drawing.Point(96, 48)
        Me._txtVT_1.MaxLength = 100
        Me._txtVT_1.Name = "_txtVT_1"
        Me._txtVT_1.Size = New System.Drawing.Size(105, 13)
        Me._txtVT_1.TabIndex = 6
        Me._txtVT_1.Text = "0"
        Me._txtVT_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_9
        '
        Me._txtVT_9.AcceptsReturn = True
        Me._txtVT_9.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_9.Location = New System.Drawing.Point(288, 232)
        Me._txtVT_9.MaxLength = 100
        Me._txtVT_9.Name = "_txtVT_9"
        Me._txtVT_9.Size = New System.Drawing.Size(97, 13)
        Me._txtVT_9.TabIndex = 19
        Me._txtVT_9.Text = "0"
        Me._txtVT_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_8
        '
        Me._txtVT_8.AcceptsReturn = True
        Me._txtVT_8.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_8.Location = New System.Drawing.Point(96, 232)
        Me._txtVT_8.MaxLength = 100
        Me._txtVT_8.Name = "_txtVT_8"
        Me._txtVT_8.Size = New System.Drawing.Size(105, 13)
        Me._txtVT_8.TabIndex = 18
        Me._txtVT_8.Text = "..."
        '
        '_txtVT_7
        '
        Me._txtVT_7.AcceptsReturn = True
        Me._txtVT_7.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_7.Location = New System.Drawing.Point(288, 200)
        Me._txtVT_7.MaxLength = 100
        Me._txtVT_7.Name = "_txtVT_7"
        Me._txtVT_7.Size = New System.Drawing.Size(97, 13)
        Me._txtVT_7.TabIndex = 17
        Me._txtVT_7.Text = "0"
        Me._txtVT_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_6
        '
        Me._txtVT_6.AcceptsReturn = True
        Me._txtVT_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_6.Location = New System.Drawing.Point(96, 200)
        Me._txtVT_6.MaxLength = 100
        Me._txtVT_6.Name = "_txtVT_6"
        Me._txtVT_6.Size = New System.Drawing.Size(105, 13)
        Me._txtVT_6.TabIndex = 16
        Me._txtVT_6.Text = "..."
        '
        '_txtVT_5
        '
        Me._txtVT_5.AcceptsReturn = True
        Me._txtVT_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_5.Location = New System.Drawing.Point(96, 144)
        Me._txtVT_5.MaxLength = 100
        Me._txtVT_5.Name = "_txtVT_5"
        Me._txtVT_5.Size = New System.Drawing.Size(105, 13)
        Me._txtVT_5.TabIndex = 9
        Me._txtVT_5.Text = "0"
        Me._txtVT_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Line_1
        '
        Me._Line_1.Enabled = False
        Me._Line_1.Location = New System.Drawing.Point(288, 99)
        Me._Line_1.Name = "_Line_1"
        Me._Line_1.Size = New System.Drawing.Size(96, 1)
        Me._Line_1.TabIndex = 24
        '
        '_Label1_5
        '
        Me._Label1_5.BackColor = System.Drawing.SystemColors.Window
        Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_5.Location = New System.Drawing.Point(213, 80)
        Me._Label1_5.Name = "_Label1_5"
        Me._Label1_5.Size = New System.Drawing.Size(79, 17)
        Me._Label1_5.TabIndex = 57
        Me._Label1_5.Tag = "Other than"
        Me._Label1_5.Text = "Trừ khác"
        '
        '_Line_4
        '
        Me._Line_4.Enabled = False
        Me._Line_4.Location = New System.Drawing.Point(288, 67)
        Me._Line_4.Name = "_Line_4"
        Me._Line_4.Size = New System.Drawing.Size(96, 1)
        Me._Line_4.TabIndex = 58
        '
        '_Label1_15
        '
        Me._Label1_15.BackColor = System.Drawing.SystemColors.Window
        Me._Label1_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_15.Location = New System.Drawing.Point(216, 48)
        Me._Label1_15.Name = "_Label1_15"
        Me._Label1_15.Size = New System.Drawing.Size(76, 17)
        Me._Label1_15.TabIndex = 56
        Me._Label1_15.Tag = "Advance"
        Me._Label1_15.Text = "Tạm ứng"
        '
        '_Label1_16
        '
        Me._Label1_16.BackColor = System.Drawing.SystemColors.Window
        Me._Label1_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_16.Location = New System.Drawing.Point(216, 112)
        Me._Label1_16.Name = "_Label1_16"
        Me._Label1_16.Size = New System.Drawing.Size(77, 17)
        Me._Label1_16.TabIndex = 55
        Me._Label1_16.Tag = "Other than"
        Me._Label1_16.Text = "Trừ khác"
        '
        '_Line_14
        '
        Me._Line_14.Enabled = False
        Me._Line_14.Location = New System.Drawing.Point(288, 131)
        Me._Line_14.Name = "_Line_14"
        Me._Line_14.Size = New System.Drawing.Size(96, 1)
        Me._Line_14.TabIndex = 59
        '
        '_Label1_17
        '
        Me._Label1_17.BackColor = System.Drawing.SystemColors.Window
        Me._Label1_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_17.Location = New System.Drawing.Point(216, 144)
        Me._Label1_17.Name = "_Label1_17"
        Me._Label1_17.Size = New System.Drawing.Size(79, 17)
        Me._Label1_17.TabIndex = 54
        Me._Label1_17.Tag = "Per-income tax"
        Me._Label1_17.Text = "Thuế TNCN"
        '
        '_Line_15
        '
        Me._Line_15.Enabled = False
        Me._Line_15.Location = New System.Drawing.Point(296, 163)
        Me._Line_15.Name = "_Line_15"
        Me._Line_15.Size = New System.Drawing.Size(88, 1)
        Me._Line_15.TabIndex = 60
        '
        '_Label1_14
        '
        Me._Label1_14.BackColor = System.Drawing.SystemColors.Window
        Me._Label1_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_14.Location = New System.Drawing.Point(8, 112)
        Me._Label1_14.Name = "_Label1_14"
        Me._Label1_14.Size = New System.Drawing.Size(73, 17)
        Me._Label1_14.TabIndex = 50
        Me._Label1_14.Tag = "Moving"
        Me._Label1_14.Text = "Lưu động"
        '
        '_Label1_13
        '
        Me._Label1_13.BackColor = System.Drawing.SystemColors.Window
        Me._Label1_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_13.Location = New System.Drawing.Point(8, 80)
        Me._Label1_13.Name = "_Label1_13"
        Me._Label1_13.Size = New System.Drawing.Size(73, 17)
        Me._Label1_13.TabIndex = 49
        Me._Label1_13.Tag = "Responsibility"
        Me._Label1_13.Text = "Trách nhiệm"
        '
        '_Label1_12
        '
        Me._Label1_12.BackColor = System.Drawing.SystemColors.Window
        Me._Label1_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_12.Location = New System.Drawing.Point(8, 48)
        Me._Label1_12.Name = "_Label1_12"
        Me._Label1_12.Size = New System.Drawing.Size(73, 17)
        Me._Label1_12.TabIndex = 48
        Me._Label1_12.Tag = "Position"
        Me._Label1_12.Text = "Chức vụ"
        '
        '_Line_13
        '
        Me._Line_13.Enabled = False
        Me._Line_13.Location = New System.Drawing.Point(96, 315)
        Me._Line_13.Name = "_Line_13"
        Me._Line_13.Size = New System.Drawing.Size(104, 1)
        Me._Line_13.TabIndex = 61
        '
        '_Label1_11
        '
        Me._Label1_11.BackColor = System.Drawing.Color.White
        Me._Label1_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_11.Location = New System.Drawing.Point(223, 296)
        Me._Label1_11.Name = "_Label1_11"
        Me._Label1_11.Size = New System.Drawing.Size(56, 17)
        Me._Label1_11.TabIndex = 47
        Me._Label1_11.Tag = "Amount"
        Me._Label1_11.Text = "Giá trị"
        '
        '_Line_3
        '
        Me._Line_3.Enabled = False
        Me._Line_3.Location = New System.Drawing.Point(288, 315)
        Me._Line_3.Name = "_Line_3"
        Me._Line_3.Size = New System.Drawing.Size(96, 1)
        Me._Line_3.TabIndex = 62
        '
        '_Label1_10
        '
        Me._Label1_10.BackColor = System.Drawing.Color.White
        Me._Label1_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_10.Location = New System.Drawing.Point(8, 296)
        Me._Label1_10.Name = "_Label1_10"
        Me._Label1_10.Size = New System.Drawing.Size(51, 17)
        Me._Label1_10.TabIndex = 46
        Me._Label1_10.Tag = "Reasons"
        Me._Label1_10.Text = "Lý do"
        '
        '_Line_2
        '
        Me._Line_2.Enabled = False
        Me._Line_2.Location = New System.Drawing.Point(96, 283)
        Me._Line_2.Name = "_Line_2"
        Me._Line_2.Size = New System.Drawing.Size(104, 1)
        Me._Line_2.TabIndex = 63
        '
        '_Label1_3
        '
        Me._Label1_3.BackColor = System.Drawing.Color.White
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_3.Location = New System.Drawing.Point(223, 264)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.Size = New System.Drawing.Size(56, 17)
        Me._Label1_3.TabIndex = 45
        Me._Label1_3.Tag = "Amount"
        Me._Label1_3.Text = "Giá trị"
        '
        '_Line_0
        '
        Me._Line_0.Enabled = False
        Me._Line_0.Location = New System.Drawing.Point(288, 283)
        Me._Line_0.Name = "_Line_0"
        Me._Line_0.Size = New System.Drawing.Size(96, 1)
        Me._Line_0.TabIndex = 64
        '
        '_Label1_2
        '
        Me._Label1_2.BackColor = System.Drawing.Color.White
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(8, 264)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.Size = New System.Drawing.Size(51, 17)
        Me._Label1_2.TabIndex = 44
        Me._Label1_2.Tag = "Reasons"
        Me._Label1_2.Text = "Lý do"
        '
        '_Line_11
        '
        Me._Line_11.Enabled = False
        Me._Line_11.Location = New System.Drawing.Point(96, 67)
        Me._Line_11.Name = "_Line_11"
        Me._Line_11.Size = New System.Drawing.Size(104, 1)
        Me._Line_11.TabIndex = 65
        '
        '_Line_10
        '
        Me._Line_10.Enabled = False
        Me._Line_10.Location = New System.Drawing.Point(96, 99)
        Me._Line_10.Name = "_Line_10"
        Me._Line_10.Size = New System.Drawing.Size(104, 1)
        Me._Line_10.TabIndex = 66
        '
        '_Line_12
        '
        Me._Line_12.Enabled = False
        Me._Line_12.Location = New System.Drawing.Point(96, 131)
        Me._Line_12.Name = "_Line_12"
        Me._Line_12.Size = New System.Drawing.Size(104, 1)
        Me._Line_12.TabIndex = 67
        '
        '_Label1_9
        '
        Me._Label1_9.BackColor = System.Drawing.Color.White
        Me._Label1_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_9.Location = New System.Drawing.Point(8, 232)
        Me._Label1_9.Name = "_Label1_9"
        Me._Label1_9.Size = New System.Drawing.Size(51, 17)
        Me._Label1_9.TabIndex = 42
        Me._Label1_9.Tag = "Reasons"
        Me._Label1_9.Text = "Lý do"
        '
        '_Line_9
        '
        Me._Line_9.Enabled = False
        Me._Line_9.Location = New System.Drawing.Point(288, 251)
        Me._Line_9.Name = "_Line_9"
        Me._Line_9.Size = New System.Drawing.Size(96, 1)
        Me._Line_9.TabIndex = 68
        '
        '_Label1_8
        '
        Me._Label1_8.BackColor = System.Drawing.Color.White
        Me._Label1_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_8.Location = New System.Drawing.Point(223, 232)
        Me._Label1_8.Name = "_Label1_8"
        Me._Label1_8.Size = New System.Drawing.Size(56, 17)
        Me._Label1_8.TabIndex = 41
        Me._Label1_8.Tag = "Amount"
        Me._Label1_8.Text = "Giá trị"
        '
        '_Line_8
        '
        Me._Line_8.Enabled = False
        Me._Line_8.Location = New System.Drawing.Point(96, 251)
        Me._Line_8.Name = "_Line_8"
        Me._Line_8.Size = New System.Drawing.Size(104, 1)
        Me._Line_8.TabIndex = 69
        '
        '_Label1_7
        '
        Me._Label1_7.BackColor = System.Drawing.Color.White
        Me._Label1_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_7.Location = New System.Drawing.Point(8, 200)
        Me._Label1_7.Name = "_Label1_7"
        Me._Label1_7.Size = New System.Drawing.Size(51, 17)
        Me._Label1_7.TabIndex = 40
        Me._Label1_7.Tag = "Reasons"
        Me._Label1_7.Text = "Lý do"
        '
        '_Line_7
        '
        Me._Line_7.Enabled = False
        Me._Line_7.Location = New System.Drawing.Point(288, 219)
        Me._Line_7.Name = "_Line_7"
        Me._Line_7.Size = New System.Drawing.Size(96, 1)
        Me._Line_7.TabIndex = 70
        '
        '_Label1_6
        '
        Me._Label1_6.BackColor = System.Drawing.Color.White
        Me._Label1_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_6.Location = New System.Drawing.Point(223, 200)
        Me._Label1_6.Name = "_Label1_6"
        Me._Label1_6.Size = New System.Drawing.Size(56, 17)
        Me._Label1_6.TabIndex = 39
        Me._Label1_6.Tag = "Amount"
        Me._Label1_6.Text = "Giá trị"
        '
        '_Line_6
        '
        Me._Line_6.Enabled = False
        Me._Line_6.Location = New System.Drawing.Point(96, 219)
        Me._Line_6.Name = "_Line_6"
        Me._Line_6.Size = New System.Drawing.Size(104, 1)
        Me._Line_6.TabIndex = 71
        '
        '_Line_5
        '
        Me._Line_5.Enabled = False
        Me._Line_5.Location = New System.Drawing.Point(96, 163)
        Me._Line_5.Name = "_Line_5"
        Me._Line_5.Size = New System.Drawing.Size(104, 1)
        Me._Line_5.TabIndex = 72
        '
        '_Label1_4
        '
        Me._Label1_4.BackColor = System.Drawing.SystemColors.Window
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_4.Location = New System.Drawing.Point(8, 144)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.Size = New System.Drawing.Size(73, 17)
        Me._Label1_4.TabIndex = 38
        Me._Label1_4.Tag = "Eat"
        Me._Label1_4.Text = "Cơm"
        '
        '_txtVT_0
        '
        Me._txtVT_0.AcceptsReturn = True
        Me._txtVT_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_0.Location = New System.Drawing.Point(408, 24)
        Me._txtVT_0.MaxLength = 100
        Me._txtVT_0.Name = "_txtVT_0"
        Me._txtVT_0.Size = New System.Drawing.Size(169, 13)
        Me._txtVT_0.TabIndex = 2
        Me._txtVT_0.Text = "..."
        '
        'txtF
        '
        Me.txtF.AcceptsReturn = True
        Me.txtF.BackColor = System.Drawing.SystemColors.Window
        Me.txtF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF.Location = New System.Drawing.Point(152, 447)
        Me.txtF.MaxLength = 0
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(129, 20)
        Me.txtF.TabIndex = 29
        '
        'SSCmdF1
        '
        Me.SSCmdF1.BackColor = System.Drawing.SystemColors.Control
        Me.SSCmdF1.Cursor = System.Windows.Forms.Cursors.Default
        Me.SSCmdF1.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.SSCmdF1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SSCmdF1.Location = New System.Drawing.Point(288, 448)
        Me.SSCmdF1.Name = "SSCmdF1"
        Me.SSCmdF1.Size = New System.Drawing.Size(17, 19)
        Me.SSCmdF1.TabIndex = 31
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
        Me._SSOpt_1.Location = New System.Drawing.Point(72, 448)
        Me._SSOpt_1.Name = "_SSOpt_1"
        Me._SSOpt_1.Size = New System.Drawing.Size(73, 17)
        Me._SSOpt_1.TabIndex = 28
        Me._SSOpt_1.TabStop = True
        Me._SSOpt_1.Tag = "Name"
        Me._SSOpt_1.Text = "Họ và tên "
        Me._SSOpt_1.UseVisualStyleBackColor = False
        '
        '_SSOpt_0
        '
        Me._SSOpt_0.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_0.Checked = True
        Me._SSOpt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_0.Location = New System.Drawing.Point(8, 448)
        Me._SSOpt_0.Name = "_SSOpt_0"
        Me._SSOpt_0.Size = New System.Drawing.Size(73, 17)
        Me._SSOpt_0.TabIndex = 27
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
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Window
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(328, 59)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.Size = New System.Drawing.Size(65, 17)
        Me._Label1_0.TabIndex = 43
        Me._Label1_0.Tag = "Month"
        Me._Label1_0.Text = "Tháng"
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Window
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(328, 24)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.Size = New System.Drawing.Size(49, 17)
        Me._Label1_1.TabIndex = 36
        Me._Label1_1.Tag = "Position"
        Me._Label1_1.Text = "Chức vụ"
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.SystemColors.Window
        Me._Label_17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.Location = New System.Drawing.Point(312, 8)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(417, 420)
        Me._Label_17.TabIndex = 35
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(656, 442)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 53
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(576, 442)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 52
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        'FrmPhucap
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(737, 472)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me.SSCmdF)
        Me.Controls.Add(Me.CboThang)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me._txtVT_0)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me.SSCmdF1)
        Me.Controls.Add(Me._SSOpt_1)
        Me.Controls.Add(Me._SSOpt_0)
        Me.Controls.Add(Me.CboLoai)
        Me.Controls.Add(Me.LstVt)
        Me.Controls.Add(Me._Label1_0)
        Me.Controls.Add(Me._Label1_1)
        Me.Controls.Add(Me._Label_17)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(72, 67)
        Me.MaximizeBox = False
        Me.Name = "FrmPhucap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Allowances"
        Me.Text = "Phụ cấp lương"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Sub InitializetxtVT()
        Me.txtVT(4) = _txtVT_4
        Me.txtVT(14) = _txtVT_14
        Me.txtVT(15) = _txtVT_15
        Me.txtVT(16) = _txtVT_16
        Me.txtVT(13) = _txtVT_13
        Me.txtVT(12) = _txtVT_12
        Me.txtVT(11) = _txtVT_11
        Me.txtVT(10) = _txtVT_10
        Me.txtVT(3) = _txtVT_3
        Me.txtVT(2) = _txtVT_2
        Me.txtVT(1) = _txtVT_1
        Me.txtVT(9) = _txtVT_9
        Me.txtVT(8) = _txtVT_8
        Me.txtVT(7) = _txtVT_7
        Me.txtVT(6) = _txtVT_6
        Me.txtVT(5) = _txtVT_5
        Me.txtVT(0) = _txtVT_0
    End Sub
    Sub InitializeSSOpt()
        Me.SSOpt(1) = _SSOpt_1
        Me.SSOpt(0) = _SSOpt_0
    End Sub
    Sub InitializeOptloai()
        Me.Optloai(1) = _Optloai_1
        Me.Optloai(2) = _Optloai_2
    End Sub
    Sub InitializeLine()
        Me.Line(1) = _Line_1
        Me.Line(4) = _Line_4
        Me.Line(14) = _Line_14
        Me.Line(15) = _Line_15
        Me.Line(13) = _Line_13
        Me.Line(3) = _Line_3
        Me.Line(2) = _Line_2
        Me.Line(0) = _Line_0
        Me.Line(11) = _Line_11
        Me.Line(10) = _Line_10
        Me.Line(12) = _Line_12
        Me.Line(9) = _Line_9
        Me.Line(8) = _Line_8
        Me.Line(7) = _Line_7
        Me.Line(6) = _Line_6
        Me.Line(5) = _Line_5
    End Sub
    Sub InitializeLabel1()
        Me.Label1(5) = _Label1_5
        Me.Label1(15) = _Label1_15
        Me.Label1(16) = _Label1_16
        Me.Label1(17) = _Label1_17
        Me.Label1(14) = _Label1_14
        Me.Label1(13) = _Label1_13
        Me.Label1(12) = _Label1_12
        Me.Label1(11) = _Label1_11
        Me.Label1(10) = _Label1_10
        Me.Label1(3) = _Label1_3
        Me.Label1(2) = _Label1_2
        Me.Label1(9) = _Label1_9
        Me.Label1(8) = _Label1_8
        Me.Label1(7) = _Label1_7
        Me.Label1(6) = _Label1_6
        Me.Label1(4) = _Label1_4
        Me.Label1(0) = _Label1_0
        Me.Label1(1) = _Label1_1
    End Sub
    Sub InitializeLabel()
        Me.Label(17) = _Label_17
        'Me.Label(5) = _Label_5
        'Me.Label(4) = _Label_4
        'Me.Label(9) = _Label_9
    End Sub
    Sub InitializeCommand()
        Me.Command(2) = _Command_2
        Me.Command(3) = _Command_3
        Me.Command(1) = _Command_1
    End Sub
    'Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'Friend WithEvents LineShape16 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Friend WithEvents LineShape15 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Friend WithEvents LineShape14 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Friend WithEvents LineShape13 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Friend WithEvents LineShape12 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Friend WithEvents LineShape11 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Friend WithEvents LineShape10 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Friend WithEvents LineShape9 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Friend WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
#End Region 
End Class
