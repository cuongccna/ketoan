<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSoCongNo
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
        isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		Initializetxtshkh()
		InitializetxtShVT()
		InitializetxtShTk()
		Initializelbkh()
		Initializecmdvt()
		Initializecmdtk()
		Initializecmdkh()
		InitializeOptTG()
		InitializeOptBC()
		InitializeOpt()
		InitializeMedNgay()
		InitializeLbTenVT()
		InitializeLbTenTk()
		InitializeLabel()
		InitializeFrame()
		InitializeCommand()
		InitializeChkDu()
		InitializeCboThang()
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
    Private WithEvents _ChkDu_16 As System.Windows.Forms.CheckBox
	Private WithEvents _CboThang_1 As ComboBoxEx.ComboBoxExt
	Private WithEvents _CboThang_0 As ComboBoxEx.ComboBoxExt
	Private WithEvents _Label_1 As System.Windows.Forms.Label
	Private WithEvents _Label_0 As System.Windows.Forms.Label
	Private WithEvents _Frame_0 As System.Windows.Forms.GroupBox
	Private WithEvents _OptTG_0 As System.Windows.Forms.RadioButton
	Private WithEvents _OptTG_1 As System.Windows.Forms.RadioButton
	Private WithEvents _MedNgay_1 As System.Windows.Forms.MaskedTextBox
	Private WithEvents _MedNgay_2 As System.Windows.Forms.MaskedTextBox
	Private WithEvents _Label_2 As System.Windows.Forms.Label
	Private WithEvents _Label_5 As System.Windows.Forms.Label
	Private WithEvents _Frame_1 As System.Windows.Forms.GroupBox
	Private WithEvents _OptBC_80 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_53 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_66 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_39 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_38 As System.Windows.Forms.RadioButton
	Private WithEvents _txtShVT_1 As System.Windows.Forms.TextBox
	Private WithEvents _ChkDu_5 As System.Windows.Forms.CheckBox
	Private WithEvents _OptBC_35 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_91 As System.Windows.Forms.RadioButton
	Private WithEvents _ChkDu_14 As System.Windows.Forms.CheckBox
	Private WithEvents _OptBC_84 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_83 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_82 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_78 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_72 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_73 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_70 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_67 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_63 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_62 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_58 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_57 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_49 As System.Windows.Forms.RadioButton
	Public WithEvents CboHD As ComboBoxEx.ComboBoxExt
	Private WithEvents _OptBC_41 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_40 As System.Windows.Forms.RadioButton
	Private WithEvents _txtshkh_0 As System.Windows.Forms.TextBox
	Private WithEvents _OptBC_36 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_17 As System.Windows.Forms.RadioButton
	Public WithEvents txtHan As System.Windows.Forms.TextBox
	Public WithEvents CboKH As ComboBoxEx.ComboBoxExt
	Private WithEvents _txtShTk_7 As System.Windows.Forms.TextBox
	Private WithEvents _Opt_3 As System.Windows.Forms.RadioButton
	Private WithEvents _Opt_2 As System.Windows.Forms.RadioButton
    Private WithEvents _cmdtk_7 As System.Windows.Forms.Button
    Private WithEvents _LbTenTk_7 As System.Windows.Forms.Label
    Private WithEvents _Frame_3 As System.Windows.Forms.GroupBox
    Private WithEvents _cmdkh_0 As System.Windows.Forms.Button
    Private WithEvents _MedNgay_0 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _cmdvt_1 As System.Windows.Forms.Button
    Private WithEvents _LbTenVT_1 As System.Windows.Forms.Label
    Public WithEvents Line1 As System.Windows.Forms.Label
    Private WithEvents _lbkh_0 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Public WithEvents FCongno As System.Windows.Forms.GroupBox
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Public WithEvents GauGe As System.Windows.Forms.ProgressBar
    Public CboThang(1) As ComboBoxEx.ComboBoxExt
    Public ChkDu(16) As System.Windows.Forms.CheckBox
    Public Command(3) As System.Windows.Forms.Button
    Public Frame(6) As System.Windows.Forms.GroupBox
    Public Label(5) As System.Windows.Forms.Label
    Public LbTenTk(7) As System.Windows.Forms.Label
    Public LbTenVT(1) As System.Windows.Forms.Label
    Public MedNgay(2) As System.Windows.Forms.MaskedTextBox
    Public Opt(3) As System.Windows.Forms.RadioButton
    Public OptBC(91) As System.Windows.Forms.RadioButton
    Public OptNN(1) As System.Windows.Forms.RadioButton
    Public OptTG(1) As System.Windows.Forms.RadioButton
    Public cmdkh(0) As System.Windows.Forms.Button
    Public cmdtk(7) As System.Windows.Forms.Button
    Public cmdvt(1) As System.Windows.Forms.Button
    Public lbkh(0) As System.Windows.Forms.Label
    Public txtShTk(7) As System.Windows.Forms.TextBox
    Public txtShVT(1) As System.Windows.Forms.TextBox
    Public txtshkh(0) As System.Windows.Forms.TextBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSoCongNo))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.CboHD = New ComboBoxEx.ComboBoxExt
        Me._Opt_2 = New System.Windows.Forms.RadioButton
        Me._ChkDu_16 = New System.Windows.Forms.CheckBox
        Me._Frame_0 = New System.Windows.Forms.GroupBox
        Me._CboThang_1 = New ComboBoxEx.ComboBoxExt
        Me._CboThang_0 = New ComboBoxEx.ComboBoxExt
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._OptTG_0 = New System.Windows.Forms.RadioButton
        Me._OptTG_1 = New System.Windows.Forms.RadioButton
        Me._Frame_1 = New System.Windows.Forms.GroupBox
        Me._MedNgay_1 = New System.Windows.Forms.MaskedTextBox
        Me._MedNgay_2 = New System.Windows.Forms.MaskedTextBox
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Label_5 = New System.Windows.Forms.Label
        Me.FCongno = New System.Windows.Forms.GroupBox
        Me._OptBC_64 = New System.Windows.Forms.RadioButton
        Me._OptBC_80 = New System.Windows.Forms.RadioButton
        Me._OptBC_53 = New System.Windows.Forms.RadioButton
        Me._OptBC_66 = New System.Windows.Forms.RadioButton
        Me._OptBC_39 = New System.Windows.Forms.RadioButton
        Me._OptBC_38 = New System.Windows.Forms.RadioButton
        Me._txtShVT_1 = New System.Windows.Forms.TextBox
        Me._ChkDu_5 = New System.Windows.Forms.CheckBox
        Me._OptBC_35 = New System.Windows.Forms.RadioButton
        Me._OptBC_91 = New System.Windows.Forms.RadioButton
        Me._ChkDu_14 = New System.Windows.Forms.CheckBox
        Me._OptBC_84 = New System.Windows.Forms.RadioButton
        Me._OptBC_83 = New System.Windows.Forms.RadioButton
        Me._OptBC_82 = New System.Windows.Forms.RadioButton
        Me._OptBC_78 = New System.Windows.Forms.RadioButton
        Me._OptBC_72 = New System.Windows.Forms.RadioButton
        Me._OptBC_73 = New System.Windows.Forms.RadioButton
        Me._OptBC_70 = New System.Windows.Forms.RadioButton
        Me._OptBC_67 = New System.Windows.Forms.RadioButton
        Me._OptBC_63 = New System.Windows.Forms.RadioButton
        Me._OptBC_62 = New System.Windows.Forms.RadioButton
        Me._OptBC_58 = New System.Windows.Forms.RadioButton
        Me._OptBC_57 = New System.Windows.Forms.RadioButton
        Me._OptBC_49 = New System.Windows.Forms.RadioButton
        Me._OptBC_41 = New System.Windows.Forms.RadioButton
        Me._OptBC_40 = New System.Windows.Forms.RadioButton
        Me._txtshkh_0 = New System.Windows.Forms.TextBox
        Me._OptBC_36 = New System.Windows.Forms.RadioButton
        Me._OptBC_17 = New System.Windows.Forms.RadioButton
        Me.txtHan = New System.Windows.Forms.TextBox
        Me._Frame_3 = New System.Windows.Forms.GroupBox
        Me.CboKH = New ComboBoxEx.ComboBoxExt
        Me._txtShTk_7 = New System.Windows.Forms.TextBox
        Me._Opt_3 = New System.Windows.Forms.RadioButton
        Me._cmdtk_7 = New System.Windows.Forms.Button
        Me._LbTenTk_7 = New System.Windows.Forms.Label
        Me._cmdkh_0 = New System.Windows.Forms.Button
        Me._MedNgay_0 = New System.Windows.Forms.MaskedTextBox
        Me._cmdvt_1 = New System.Windows.Forms.Button
        Me._LbTenVT_1 = New System.Windows.Forms.Label
        Me.Line1 = New System.Windows.Forms.Label
        Me._lbkh_0 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me.GauGe = New System.Windows.Forms.ProgressBar
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Frame_0.SuspendLayout()
        Me._Frame_1.SuspendLayout()
        Me.FCongno.SuspendLayout()
        Me._Frame_3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CboHD
        '
        Me.CboHD.BackColor = System.Drawing.SystemColors.Window
        Me.CboHD.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboHD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboHD.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboHD.Location = New System.Drawing.Point(208, 486)
        Me.CboHD.Name = "CboHD"
        Me.CboHD.Size = New System.Drawing.Size(137, 21)
        Me.CboHD.TabIndex = 28
        Me.ToolTipMain.SetToolTip(Me.CboHD, "Nhấn chuột phải để đăng ký")
        Me.CboHD.Visible = False
        '
        '_Opt_2
        '
        Me._Opt_2.BackColor = System.Drawing.Color.Transparent
        Me._Opt_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_2.Location = New System.Drawing.Point(344, 16)
        Me._Opt_2.Name = "_Opt_2"
        Me._Opt_2.Size = New System.Drawing.Size(73, 17)
        Me._Opt_2.TabIndex = 3
        Me._Opt_2.TabStop = True
        Me._Opt_2.Tag = "Class"
        Me._Opt_2.Text = "Phân loại"
        Me.ToolTipMain.SetToolTip(Me._Opt_2, "by Group")
        Me._Opt_2.UseVisualStyleBackColor = False
        '
        '_ChkDu_16
        '
        Me._ChkDu_16.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_16.Location = New System.Drawing.Point(524, 540)
        Me._ChkDu_16.Name = "_ChkDu_16"
        Me._ChkDu_16.Size = New System.Drawing.Size(85, 17)
        Me._ChkDu_16.TabIndex = 37
        Me._ChkDu_16.Tag = "Resource"
        Me._ChkDu_16.Text = "&Hiển thị lưới"
        Me._ChkDu_16.UseVisualStyleBackColor = False
        '
        '_Frame_0
        '
        Me._Frame_0.BackColor = System.Drawing.Color.Transparent
        Me._Frame_0.Controls.Add(Me._CboThang_1)
        Me._Frame_0.Controls.Add(Me._CboThang_0)
        Me._Frame_0.Controls.Add(Me._Label_1)
        Me._Frame_0.Controls.Add(Me._Label_0)
        Me._Frame_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_0.Location = New System.Drawing.Point(216, 526)
        Me._Frame_0.Name = "_Frame_0"
        Me._Frame_0.Size = New System.Drawing.Size(294, 36)
        Me._Frame_0.TabIndex = 49
        Me._Frame_0.TabStop = False
        '
        '_CboThang_1
        '
        Me._CboThang_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_1.Location = New System.Drawing.Point(215, 10)
        Me._CboThang_1.Name = "_CboThang_1"
        Me._CboThang_1.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_1.TabIndex = 34
        '
        '_CboThang_0
        '
        Me._CboThang_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_0.Location = New System.Drawing.Point(68, 10)
        Me._CboThang_0.Name = "_CboThang_0"
        Me._CboThang_0.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_0.TabIndex = 33
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(150, 12)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(68, 17)
        Me._Label_1.TabIndex = 51
        Me._Label_1.Tag = "to"
        Me._Label_1.Text = "Đến tháng"
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(6, 12)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(52, 17)
        Me._Label_0.TabIndex = 50
        Me._Label_0.Tag = "From"
        Me._Label_0.Text = "Từ tháng"
        '
        '_OptTG_0
        '
        Me._OptTG_0.BackColor = System.Drawing.Color.Transparent
        Me._OptTG_0.Checked = True
        Me._OptTG_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptTG_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptTG_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptTG_0.Location = New System.Drawing.Point(8, 537)
        Me._OptTG_0.Name = "_OptTG_0"
        Me._OptTG_0.Size = New System.Drawing.Size(81, 17)
        Me._OptTG_0.TabIndex = 31
        Me._OptTG_0.TabStop = True
        Me._OptTG_0.Tag = "By month"
        Me._OptTG_0.Text = "Theo tháng"
        Me._OptTG_0.UseVisualStyleBackColor = False
        '
        '_OptTG_1
        '
        Me._OptTG_1.BackColor = System.Drawing.Color.Transparent
        Me._OptTG_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptTG_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptTG_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptTG_1.Location = New System.Drawing.Point(112, 537)
        Me._OptTG_1.Name = "_OptTG_1"
        Me._OptTG_1.Size = New System.Drawing.Size(81, 17)
        Me._OptTG_1.TabIndex = 32
        Me._OptTG_1.TabStop = True
        Me._OptTG_1.Tag = "By date"
        Me._OptTG_1.Text = "Theo ngày"
        Me._OptTG_1.UseVisualStyleBackColor = False
        '
        '_Frame_1
        '
        Me._Frame_1.BackColor = System.Drawing.Color.Transparent
        Me._Frame_1.Controls.Add(Me._MedNgay_1)
        Me._Frame_1.Controls.Add(Me._MedNgay_2)
        Me._Frame_1.Controls.Add(Me._Label_2)
        Me._Frame_1.Controls.Add(Me._Label_5)
        Me._Frame_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_1.Location = New System.Drawing.Point(216, 526)
        Me._Frame_1.Name = "_Frame_1"
        Me._Frame_1.Size = New System.Drawing.Size(293, 37)
        Me._Frame_1.TabIndex = 46
        Me._Frame_1.TabStop = False
        Me._Frame_1.Visible = False
        '
        '_MedNgay_1
        '
        Me._MedNgay_1.AllowPromptAsInput = False
        Me._MedNgay_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_1.Location = New System.Drawing.Point(67, 11)
        Me._MedNgay_1.Mask = "00/00/0000"
        Me._MedNgay_1.Name = "_MedNgay_1"
        Me._MedNgay_1.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_1.TabIndex = 35
        '
        '_MedNgay_2
        '
        Me._MedNgay_2.AllowPromptAsInput = False
        Me._MedNgay_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_2.Location = New System.Drawing.Point(214, 11)
        Me._MedNgay_2.Name = "_MedNgay_2"
        Me._MedNgay_2.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_2.TabIndex = 36
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.Transparent
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(6, 13)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(53, 17)
        Me._Label_2.TabIndex = 48
        Me._Label_2.Tag = "From"
        Me._Label_2.Text = "Từ ngày"
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.Transparent
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_5.Location = New System.Drawing.Point(149, 11)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(55, 17)
        Me._Label_5.TabIndex = 47
        Me._Label_5.Tag = "to"
        Me._Label_5.Text = "Đến ngày"
        '
        'FCongno
        '
        Me.FCongno.BackColor = System.Drawing.Color.Transparent
        Me.FCongno.Controls.Add(Me._OptBC_64)
        Me.FCongno.Controls.Add(Me._OptBC_80)
        Me.FCongno.Controls.Add(Me._OptBC_53)
        Me.FCongno.Controls.Add(Me._OptBC_66)
        Me.FCongno.Controls.Add(Me._OptBC_39)
        Me.FCongno.Controls.Add(Me._OptBC_38)
        Me.FCongno.Controls.Add(Me._txtShVT_1)
        Me.FCongno.Controls.Add(Me._ChkDu_5)
        Me.FCongno.Controls.Add(Me._OptBC_35)
        Me.FCongno.Controls.Add(Me._OptBC_91)
        Me.FCongno.Controls.Add(Me._ChkDu_14)
        Me.FCongno.Controls.Add(Me._OptBC_84)
        Me.FCongno.Controls.Add(Me._OptBC_83)
        Me.FCongno.Controls.Add(Me._OptBC_82)
        Me.FCongno.Controls.Add(Me._OptBC_78)
        Me.FCongno.Controls.Add(Me._OptBC_72)
        Me.FCongno.Controls.Add(Me._OptBC_73)
        Me.FCongno.Controls.Add(Me._OptBC_70)
        Me.FCongno.Controls.Add(Me._OptBC_67)
        Me.FCongno.Controls.Add(Me._OptBC_63)
        Me.FCongno.Controls.Add(Me._OptBC_62)
        Me.FCongno.Controls.Add(Me._OptBC_58)
        Me.FCongno.Controls.Add(Me._OptBC_57)
        Me.FCongno.Controls.Add(Me._OptBC_49)
        Me.FCongno.Controls.Add(Me.CboHD)
        Me.FCongno.Controls.Add(Me._OptBC_41)
        Me.FCongno.Controls.Add(Me._OptBC_40)
        Me.FCongno.Controls.Add(Me._txtshkh_0)
        Me.FCongno.Controls.Add(Me._OptBC_36)
        Me.FCongno.Controls.Add(Me._OptBC_17)
        Me.FCongno.Controls.Add(Me.txtHan)
        Me.FCongno.Controls.Add(Me._Frame_3)
        Me.FCongno.Controls.Add(Me._cmdkh_0)
        Me.FCongno.Controls.Add(Me._MedNgay_0)
        Me.FCongno.Controls.Add(Me._cmdvt_1)
        Me.FCongno.Controls.Add(Me._LbTenVT_1)
        Me.FCongno.Controls.Add(Me.Line1)
        Me.FCongno.Controls.Add(Me._lbkh_0)
        Me.FCongno.Controls.Add(Me._Label_3)
        Me.FCongno.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FCongno.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FCongno.Location = New System.Drawing.Point(8, 0)
        Me.FCongno.Name = "FCongno"
        Me.FCongno.Size = New System.Drawing.Size(601, 521)
        Me.FCongno.TabIndex = 41
        Me.FCongno.TabStop = False
        '
        '_OptBC_64
        '
        Me._OptBC_64.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_64.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_64.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_64.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_64.Location = New System.Drawing.Point(352, 200)
        Me._OptBC_64.Name = "_OptBC_64"
        Me._OptBC_64.Size = New System.Drawing.Size(233, 17)
        Me._OptBC_64.TabIndex = 65
        Me._OptBC_64.TabStop = True
        Me._OptBC_64.Tag = "Print all Liability Details"
        Me._OptBC_64.Text = "Dự phòng nợ phải thu"
        Me._OptBC_64.UseVisualStyleBackColor = False
        '
        '_OptBC_80
        '
        Me._OptBC_80.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_80.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_80.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_80.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_80.Location = New System.Drawing.Point(16, 370)
        Me._OptBC_80.Name = "_OptBC_80"
        Me._OptBC_80.Size = New System.Drawing.Size(329, 17)
        Me._OptBC_80.TabIndex = 61
        Me._OptBC_80.TabStop = True
        Me._OptBC_80.Tag = "Promotion details"
        Me._OptBC_80.Text = "Chi tiết hàng khuyến mại"
        Me._OptBC_80.UseVisualStyleBackColor = False
        '
        '_OptBC_53
        '
        Me._OptBC_53.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_53.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_53.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_53.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_53.Location = New System.Drawing.Point(16, 346)
        Me._OptBC_53.Name = "_OptBC_53"
        Me._OptBC_53.Size = New System.Drawing.Size(329, 17)
        Me._OptBC_53.TabIndex = 60
        Me._OptBC_53.TabStop = True
        Me._OptBC_53.Tag = "Detail Turnover 2"
        Me._OptBC_53.Text = "Chi tiết doanh thu bán hàng 2"
        Me._OptBC_53.UseVisualStyleBackColor = False
        '
        '_OptBC_66
        '
        Me._OptBC_66.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_66.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_66.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_66.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_66.Location = New System.Drawing.Point(16, 394)
        Me._OptBC_66.Name = "_OptBC_66"
        Me._OptBC_66.Size = New System.Drawing.Size(329, 17)
        Me._OptBC_66.TabIndex = 59
        Me._OptBC_66.TabStop = True
        Me._OptBC_66.Tag = "Sales Invoice List"
        Me._OptBC_66.Text = "Sổ chi tiết bán hàng"
        Me._OptBC_66.UseVisualStyleBackColor = False
        '
        '_OptBC_39
        '
        Me._OptBC_39.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_39.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_39.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_39.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_39.Location = New System.Drawing.Point(16, 322)
        Me._OptBC_39.Name = "_OptBC_39"
        Me._OptBC_39.Size = New System.Drawing.Size(329, 17)
        Me._OptBC_39.TabIndex = 58
        Me._OptBC_39.TabStop = True
        Me._OptBC_39.Tag = "Detail Turnover"
        Me._OptBC_39.Text = "Chi tiết phải thu theo hoá đơn"
        Me._OptBC_39.UseVisualStyleBackColor = False
        '
        '_OptBC_38
        '
        Me._OptBC_38.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_38.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_38.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_38.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_38.Location = New System.Drawing.Point(16, 298)
        Me._OptBC_38.Name = "_OptBC_38"
        Me._OptBC_38.Size = New System.Drawing.Size(193, 17)
        Me._OptBC_38.TabIndex = 57
        Me._OptBC_38.TabStop = True
        Me._OptBC_38.Tag = "Detail Sale and cost of good sold report"
        Me._OptBC_38.Text = "Chi tiết Doanh thu - Giá vốn"
        Me._OptBC_38.UseVisualStyleBackColor = False
        '
        '_txtShVT_1
        '
        Me._txtShVT_1.AcceptsReturn = True
        Me._txtShVT_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtShVT_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShVT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShVT_1.Location = New System.Drawing.Point(216, 298)
        Me._txtShVT_1.MaxLength = 20
        Me._txtShVT_1.Name = "_txtShVT_1"
        Me._txtShVT_1.Size = New System.Drawing.Size(97, 20)
        Me._txtShVT_1.TabIndex = 56
        Me._txtShVT_1.Tag = "0"
        '
        '_ChkDu_5
        '
        Me._ChkDu_5.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_5.Location = New System.Drawing.Point(248, 152)
        Me._ChkDu_5.Name = "_ChkDu_5"
        Me._ChkDu_5.Size = New System.Drawing.Size(89, 17)
        Me._ChkDu_5.TabIndex = 15
        Me._ChkDu_5.Tag = "View foreign currency"
        Me._ChkDu_5.Text = "Theo ngoại tệ"
        Me._ChkDu_5.UseVisualStyleBackColor = False
        '
        '_OptBC_35
        '
        Me._OptBC_35.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_35.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_35.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_35.Location = New System.Drawing.Point(16, 152)
        Me._OptBC_35.Name = "_OptBC_35"
        Me._OptBC_35.Size = New System.Drawing.Size(233, 17)
        Me._OptBC_35.TabIndex = 14
        Me._OptBC_35.TabStop = True
        Me._OptBC_35.Tag = "Liabilities balance"
        Me._OptBC_35.Text = "Tổng hợp số dư công nợ theo đối tượng"
        Me._OptBC_35.UseVisualStyleBackColor = False
        '
        '_OptBC_91
        '
        Me._OptBC_91.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_91.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_91.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_91.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_91.Location = New System.Drawing.Point(16, 224)
        Me._OptBC_91.Name = "_OptBC_91"
        Me._OptBC_91.Size = New System.Drawing.Size(329, 17)
        Me._OptBC_91.TabIndex = 23
        Me._OptBC_91.TabStop = True
        Me._OptBC_91.Tag = "Liability Detail"
        Me._OptBC_91.Text = "Bảng thanh toán công nợ theo hoá đơn"
        Me._OptBC_91.UseVisualStyleBackColor = False
        '
        '_ChkDu_14
        '
        Me._ChkDu_14.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_14.Location = New System.Drawing.Point(248, 418)
        Me._ChkDu_14.Name = "_ChkDu_14"
        Me._ChkDu_14.Size = New System.Drawing.Size(93, 17)
        Me._ChkDu_14.TabIndex = 25
        Me._ChkDu_14.Tag = "View foreign currency"
        Me._ChkDu_14.Text = "Theo ngoại tệ"
        Me._ChkDu_14.UseVisualStyleBackColor = False
        '
        '_OptBC_84
        '
        Me._OptBC_84.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_84.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_84.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_84.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_84.Location = New System.Drawing.Point(16, 418)
        Me._OptBC_84.Name = "_OptBC_84"
        Me._OptBC_84.Size = New System.Drawing.Size(225, 17)
        Me._OptBC_84.TabIndex = 24
        Me._OptBC_84.TabStop = True
        Me._OptBC_84.Tag = "Aggregate debt balances by account"
        Me._OptBC_84.Text = "Tổng hợp số dư công nợ theo tài khoản"
        Me._OptBC_84.UseVisualStyleBackColor = False
        '
        '_OptBC_83
        '
        Me._OptBC_83.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_83.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_83.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_83.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_83.Location = New System.Drawing.Point(16, 272)
        Me._OptBC_83.Name = "_OptBC_83"
        Me._OptBC_83.Size = New System.Drawing.Size(329, 17)
        Me._OptBC_83.TabIndex = 18
        Me._OptBC_83.TabStop = True
        Me._OptBC_83.Tag = "Lists the product of the debt"
        Me._OptBC_83.Text = "Bảng kê tích số"
        Me._OptBC_83.UseVisualStyleBackColor = False
        '
        '_OptBC_82
        '
        Me._OptBC_82.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_82.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_82.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_82.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_82.Location = New System.Drawing.Point(16, 200)
        Me._OptBC_82.Name = "_OptBC_82"
        Me._OptBC_82.Size = New System.Drawing.Size(329, 17)
        Me._OptBC_82.TabIndex = 22
        Me._OptBC_82.TabStop = True
        Me._OptBC_82.Tag = "Liability Detail"
        Me._OptBC_82.Text = "Biên bảng đối chiếu công nợ theo hoá đơn"
        Me._OptBC_82.UseVisualStyleBackColor = False
        '
        '_OptBC_78
        '
        Me._OptBC_78.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_78.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_78.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_78.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_78.Location = New System.Drawing.Point(16, 248)
        Me._OptBC_78.Name = "_OptBC_78"
        Me._OptBC_78.Size = New System.Drawing.Size(329, 17)
        Me._OptBC_78.TabIndex = 17
        Me._OptBC_78.TabStop = True
        Me._OptBC_78.Tag = "Ledger number 3"
        Me._OptBC_78.Text = "Sổ chi tiết số 3"
        Me._OptBC_78.UseVisualStyleBackColor = False
        '
        '_OptBC_72
        '
        Me._OptBC_72.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_72.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_72.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_72.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_72.Location = New System.Drawing.Point(16, 466)
        Me._OptBC_72.Name = "_OptBC_72"
        Me._OptBC_72.Size = New System.Drawing.Size(329, 17)
        Me._OptBC_72.TabIndex = 30
        Me._OptBC_72.TabStop = True
        Me._OptBC_72.Tag = "Aggregate balance of debts under the age of debt"
        Me._OptBC_72.Text = "Tổng hợp số dư công nợ theo tuổi nợ"
        Me._OptBC_72.UseVisualStyleBackColor = False
        '
        '_OptBC_73
        '
        Me._OptBC_73.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_73.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_73.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_73.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_73.Location = New System.Drawing.Point(352, 80)
        Me._OptBC_73.Name = "_OptBC_73"
        Me._OptBC_73.Size = New System.Drawing.Size(233, 17)
        Me._OptBC_73.TabIndex = 9
        Me._OptBC_73.TabStop = True
        Me._OptBC_73.Tag = "Detail Report of liabilities under the age of debt"
        Me._OptBC_73.Text = "Chi tiết công nợ theo tuổi nợ"
        Me._OptBC_73.UseVisualStyleBackColor = False
        '
        '_OptBC_70
        '
        Me._OptBC_70.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_70.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_70.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_70.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_70.Location = New System.Drawing.Point(352, 104)
        Me._OptBC_70.Name = "_OptBC_70"
        Me._OptBC_70.Size = New System.Drawing.Size(233, 17)
        Me._OptBC_70.TabIndex = 11
        Me._OptBC_70.TabStop = True
        Me._OptBC_70.Tag = "Print all Detail Report of Payable and Receivable Form 2"
        Me._OptBC_70.Text = "In toàn bộ sổ ct đối tượng thanh toán"
        Me._OptBC_70.UseVisualStyleBackColor = False
        '
        '_OptBC_67
        '
        Me._OptBC_67.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_67.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_67.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_67.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_67.Location = New System.Drawing.Point(16, 80)
        Me._OptBC_67.Name = "_OptBC_67"
        Me._OptBC_67.Size = New System.Drawing.Size(329, 17)
        Me._OptBC_67.TabIndex = 8
        Me._OptBC_67.TabStop = True
        Me._OptBC_67.Tag = "Over Maximum Credit Table"
        Me._OptBC_67.Text = "Danh sách nợ quá hạn mức"
        Me._OptBC_67.UseVisualStyleBackColor = False
        '
        '_OptBC_63
        '
        Me._OptBC_63.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_63.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_63.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_63.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_63.Location = New System.Drawing.Point(352, 152)
        Me._OptBC_63.Name = "_OptBC_63"
        Me._OptBC_63.Size = New System.Drawing.Size(233, 17)
        Me._OptBC_63.TabIndex = 16
        Me._OptBC_63.TabStop = True
        Me._OptBC_63.Tag = "Print all Liability Details"
        Me._OptBC_63.Text = "In toàn bộ biên bản đối chiếu công nợ"
        Me._OptBC_63.UseVisualStyleBackColor = False
        '
        '_OptBC_62
        '
        Me._OptBC_62.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_62.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_62.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_62.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_62.Location = New System.Drawing.Point(352, 128)
        Me._OptBC_62.Name = "_OptBC_62"
        Me._OptBC_62.Size = New System.Drawing.Size(233, 17)
        Me._OptBC_62.TabIndex = 13
        Me._OptBC_62.TabStop = True
        Me._OptBC_62.Tag = "Print all Detail Report of Payable and Receivable"
        Me._OptBC_62.Text = "In toàn bộ sổ chi tiết công nợ"
        Me._OptBC_62.UseVisualStyleBackColor = False
        '
        '_OptBC_58
        '
        Me._OptBC_58.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_58.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_58.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_58.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_58.Location = New System.Drawing.Point(16, 442)
        Me._OptBC_58.Name = "_OptBC_58"
        Me._OptBC_58.Size = New System.Drawing.Size(329, 17)
        Me._OptBC_58.TabIndex = 26
        Me._OptBC_58.TabStop = True
        Me._OptBC_58.Tag = "Liabities Balance sheet"
        Me._OptBC_58.Text = "Bảng cân đối công nợ"
        Me._OptBC_58.UseVisualStyleBackColor = False
        '
        '_OptBC_57
        '
        Me._OptBC_57.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_57.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_57.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_57.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_57.Location = New System.Drawing.Point(16, 104)
        Me._OptBC_57.Name = "_OptBC_57"
        Me._OptBC_57.Size = New System.Drawing.Size(329, 17)
        Me._OptBC_57.TabIndex = 10
        Me._OptBC_57.TabStop = True
        Me._OptBC_57.Tag = "Detail Report of Payable and Receivable 2"
        Me._OptBC_57.Text = "Sổ chi tiết công nợ (một đối tượng theo dõi  trên nhiều tài khoản)"
        Me._OptBC_57.UseVisualStyleBackColor = False
        '
        '_OptBC_49
        '
        Me._OptBC_49.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_49.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_49.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_49.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_49.Location = New System.Drawing.Point(16, 176)
        Me._OptBC_49.Name = "_OptBC_49"
        Me._OptBC_49.Size = New System.Drawing.Size(193, 17)
        Me._OptBC_49.TabIndex = 19
        Me._OptBC_49.TabStop = True
        Me._OptBC_49.Tag = "Liability Detail"
        Me._OptBC_49.Text = "Biên bảng đối chiếu công nợ"
        Me._OptBC_49.UseVisualStyleBackColor = False
        '
        '_OptBC_41
        '
        Me._OptBC_41.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_41.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_41.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_41.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_41.Location = New System.Drawing.Point(352, 418)
        Me._OptBC_41.Name = "_OptBC_41"
        Me._OptBC_41.Size = New System.Drawing.Size(233, 17)
        Me._OptBC_41.TabIndex = 29
        Me._OptBC_41.TabStop = True
        Me._OptBC_41.Tag = "List of output contract"
        Me._OptBC_41.Text = "Bảng kê theo hợp đồng đầu ra"
        Me._OptBC_41.UseVisualStyleBackColor = False
        Me._OptBC_41.Visible = False
        '
        '_OptBC_40
        '
        Me._OptBC_40.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_40.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_40.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_40.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_40.Location = New System.Drawing.Point(16, 490)
        Me._OptBC_40.Name = "_OptBC_40"
        Me._OptBC_40.Size = New System.Drawing.Size(185, 17)
        Me._OptBC_40.TabIndex = 27
        Me._OptBC_40.TabStop = True
        Me._OptBC_40.Tag = "List of input contract"
        Me._OptBC_40.Text = "Bảng kê theo hợp đồng đầu vào"
        Me._OptBC_40.UseVisualStyleBackColor = False
        Me._OptBC_40.Visible = False
        '
        '_txtshkh_0
        '
        Me._txtshkh_0.AcceptsReturn = True
        Me._txtshkh_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtshkh_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtshkh_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtshkh_0.Location = New System.Drawing.Point(216, 176)
        Me._txtshkh_0.MaxLength = 20
        Me._txtshkh_0.Name = "_txtshkh_0"
        Me._txtshkh_0.Size = New System.Drawing.Size(97, 20)
        Me._txtshkh_0.TabIndex = 20
        Me._txtshkh_0.Tag = "0"
        '
        '_OptBC_36
        '
        Me._OptBC_36.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_36.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_36.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_36.Location = New System.Drawing.Point(16, 128)
        Me._OptBC_36.Name = "_OptBC_36"
        Me._OptBC_36.Size = New System.Drawing.Size(329, 17)
        Me._OptBC_36.TabIndex = 12
        Me._OptBC_36.TabStop = True
        Me._OptBC_36.Tag = "Detail Report of Payable and Receivable"
        Me._OptBC_36.Text = "Sổ chi tiết công nợ (từng tài khoản)"
        Me._OptBC_36.UseVisualStyleBackColor = False
        '
        '_OptBC_17
        '
        Me._OptBC_17.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_17.Checked = True
        Me._OptBC_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_17.Location = New System.Drawing.Point(16, 56)
        Me._OptBC_17.Name = "_OptBC_17"
        Me._OptBC_17.Size = New System.Drawing.Size(169, 17)
        Me._OptBC_17.TabIndex = 5
        Me._OptBC_17.TabStop = True
        Me._OptBC_17.Tag = "Time of liabilities"
        Me._OptBC_17.Text = "Chi tiết nợ phải thu với thời hạn"
        Me._OptBC_17.UseVisualStyleBackColor = False
        '
        'txtHan
        '
        Me.txtHan.AcceptsReturn = True
        Me.txtHan.BackColor = System.Drawing.SystemColors.Window
        Me.txtHan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHan.Location = New System.Drawing.Point(216, 56)
        Me.txtHan.MaxLength = 3
        Me.txtHan.Name = "txtHan"
        Me.txtHan.Size = New System.Drawing.Size(33, 20)
        Me.txtHan.TabIndex = 6
        Me.txtHan.Text = "0"
        '
        '_Frame_3
        '
        Me._Frame_3.BackColor = System.Drawing.Color.Transparent
        Me._Frame_3.Controls.Add(Me.CboKH)
        Me._Frame_3.Controls.Add(Me._txtShTk_7)
        Me._Frame_3.Controls.Add(Me._Opt_3)
        Me._Frame_3.Controls.Add(Me._Opt_2)
        Me._Frame_3.Controls.Add(Me._cmdtk_7)
        Me._Frame_3.Controls.Add(Me._LbTenTk_7)
        Me._Frame_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_3.Location = New System.Drawing.Point(8, 8)
        Me._Frame_3.Name = "_Frame_3"
        Me._Frame_3.Size = New System.Drawing.Size(585, 41)
        Me._Frame_3.TabIndex = 42
        Me._Frame_3.TabStop = False
        '
        'CboKH
        '
        Me.CboKH.BackColor = System.Drawing.SystemColors.Window
        Me.CboKH.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboKH.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboKH.Location = New System.Drawing.Point(416, 12)
        Me.CboKH.Name = "CboKH"
        Me.CboKH.Size = New System.Drawing.Size(161, 21)
        Me.CboKH.TabIndex = 4
        '
        '_txtShTk_7
        '
        Me._txtShTk_7.AcceptsReturn = True
        Me._txtShTk_7.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_7.Location = New System.Drawing.Point(80, 16)
        Me._txtShTk_7.MaxLength = 12
        Me._txtShTk_7.Name = "_txtShTk_7"
        Me._txtShTk_7.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_7.TabIndex = 1
        Me._txtShTk_7.Tag = "0"
        '
        '_Opt_3
        '
        Me._Opt_3.BackColor = System.Drawing.Color.Transparent
        Me._Opt_3.Checked = True
        Me._Opt_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_3.Location = New System.Drawing.Point(8, 16)
        Me._Opt_3.Name = "_Opt_3"
        Me._Opt_3.Size = New System.Drawing.Size(73, 17)
        Me._Opt_3.TabIndex = 0
        Me._Opt_3.TabStop = True
        Me._Opt_3.Tag = "Account"
        Me._Opt_3.Text = "Tài khoản"
        Me._Opt_3.UseVisualStyleBackColor = False
        '
        '_cmdtk_7
        '
        Me._cmdtk_7.Image = CType(resources.GetObject("_cmdtk_7.Image"), System.Drawing.Image)
        Me._cmdtk_7.Location = New System.Drawing.Point(176, 16)
        Me._cmdtk_7.Name = "_cmdtk_7"
        Me._cmdtk_7.Size = New System.Drawing.Size(23, 22)
        Me._cmdtk_7.TabIndex = 2
        '
        '_LbTenTk_7
        '
        Me._LbTenTk_7.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_7.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_7.Location = New System.Drawing.Point(208, 16)
        Me._LbTenTk_7.Name = "_LbTenTk_7"
        Me._LbTenTk_7.Size = New System.Drawing.Size(121, 17)
        Me._LbTenTk_7.TabIndex = 43
        Me._LbTenTk_7.Tag = "1"
        '
        '_cmdkh_0
        '
        Me._cmdkh_0.Image = CType(resources.GetObject("_cmdkh_0.Image"), System.Drawing.Image)
        Me._cmdkh_0.Location = New System.Drawing.Point(320, 176)
        Me._cmdkh_0.Name = "_cmdkh_0"
        Me._cmdkh_0.Size = New System.Drawing.Size(23, 22)
        Me._cmdkh_0.TabIndex = 21
        '
        '_MedNgay_0
        '
        Me._MedNgay_0.AllowPromptAsInput = False
        Me._MedNgay_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_0.Location = New System.Drawing.Point(352, 56)
        Me._MedNgay_0.Mask = "00/00/0000"
        Me._MedNgay_0.Name = "_MedNgay_0"
        Me._MedNgay_0.Size = New System.Drawing.Size(65, 20)
        Me._MedNgay_0.TabIndex = 7
        '
        '_cmdvt_1
        '
        Me._cmdvt_1.Image = CType(resources.GetObject("_cmdvt_1.Image"), System.Drawing.Image)
        Me._cmdvt_1.Location = New System.Drawing.Point(320, 298)
        Me._cmdvt_1.Name = "_cmdvt_1"
        Me._cmdvt_1.Size = New System.Drawing.Size(23, 22)
        Me._cmdvt_1.TabIndex = 62
        '
        '_LbTenVT_1
        '
        Me._LbTenVT_1.BackColor = System.Drawing.Color.Transparent
        Me._LbTenVT_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenVT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenVT_1.ForeColor = System.Drawing.Color.Blue
        Me._LbTenVT_1.Location = New System.Drawing.Point(360, 301)
        Me._LbTenVT_1.Name = "_LbTenVT_1"
        Me._LbTenVT_1.Size = New System.Drawing.Size(233, 17)
        Me._LbTenVT_1.TabIndex = 63
        Me._LbTenVT_1.Tag = "1"
        '
        'Line1
        '
        Me.Line1.Enabled = False
        Me.Line1.Location = New System.Drawing.Point(8, 416)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(584, 1)
        Me.Line1.TabIndex = 64
        '
        '_lbkh_0
        '
        Me._lbkh_0.BackColor = System.Drawing.Color.Transparent
        Me._lbkh_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbkh_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbkh_0.ForeColor = System.Drawing.Color.Blue
        Me._lbkh_0.Location = New System.Drawing.Point(349, 176)
        Me._lbkh_0.Name = "_lbkh_0"
        Me._lbkh_0.Size = New System.Drawing.Size(246, 17)
        Me._lbkh_0.TabIndex = 45
        Me._lbkh_0.Tag = "1"
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.Transparent
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_3.Location = New System.Drawing.Point(257, 59)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(89, 17)
        Me._Label_3.TabIndex = 44
        Me._Label_3.Tag = "date, FROM"
        Me._Label_3.Text = "ngày, tính đến"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.print16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(360, 563)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(79, 25)
        Me._Command_1.TabIndex = 39
        Me._Command_1.Tag = "Print"
        Me._Command_1.Text = "&In"
        Me._Command_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.report16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(275, 563)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(79, 25)
        Me._Command_0.TabIndex = 38
        Me._Command_0.Tag = "Preview"
        Me._Command_0.Text = "&Xem"
        Me._Command_0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GauGe
        '
        Me.GauGe.Location = New System.Drawing.Point(8, 569)
        Me.GauGe.Name = "GauGe"
        Me.GauGe.Size = New System.Drawing.Size(261, 17)
        Me.GauGe.TabIndex = 52
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(530, 563)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(79, 25)
        Me._Command_2.TabIndex = 53
        Me._Command_2.Tag = "Return"
        Me._Command_2.Text = "Trở &về"
        Me._Command_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.excel16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(445, 563)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(79, 25)
        Me._Command_3.TabIndex = 134
        Me._Command_3.Tag = "Export Excel"
        Me._Command_3.Text = "Xuất &Excel"
        Me._Command_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmSoCongNo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(615, 590)
        Me.Controls.Add(Me._Frame_0)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._ChkDu_16)
        Me.Controls.Add(Me._OptTG_0)
        Me.Controls.Add(Me._Frame_1)
        Me.Controls.Add(Me._OptTG_1)
        Me.Controls.Add(Me.FCongno)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me.GauGe)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSoCongNo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Reports"
        Me.Text = "Báo cáo chi tiết công nợ"
        Me._Frame_0.ResumeLayout(False)
        Me._Frame_1.ResumeLayout(False)
        Me._Frame_1.PerformLayout()
        Me.FCongno.ResumeLayout(False)
        Me.FCongno.PerformLayout()
        Me._Frame_3.ResumeLayout(False)
        Me._Frame_3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Sub Initializetxtshkh()
        Me.txtshkh(0) = _txtshkh_0
    End Sub
    Sub InitializetxtShVT()
        Me.txtShVT(1) = _txtShVT_1
    End Sub
    Sub InitializetxtShTk()
        Me.txtShTk(7) = _txtShTk_7
    End Sub
    Sub Initializelbkh()
        Me.lbkh(0) = _lbkh_0
    End Sub
    Sub Initializecmdvt()
        Me.cmdvt(1) = _cmdvt_1
    End Sub
    Sub Initializecmdtk()
        Me.cmdtk(7) = _cmdtk_7
    End Sub
    Sub Initializecmdkh()
        Me.cmdkh(0) = _cmdkh_0
    End Sub
    Sub InitializeOptTG()
        Me.OptTG(0) = _OptTG_0
        Me.OptTG(1) = _OptTG_1
    End Sub
    Sub InitializeOptBC()
        Me.OptBC(80) = _OptBC_80
        Me.OptBC(53) = _OptBC_53
        Me.OptBC(66) = _OptBC_66
        Me.OptBC(39) = _OptBC_39
        Me.OptBC(38) = _OptBC_38
        Me.OptBC(35) = _OptBC_35
        Me.OptBC(91) = _OptBC_91
        Me.OptBC(84) = _OptBC_84
        Me.OptBC(83) = _OptBC_83
        Me.OptBC(82) = _OptBC_82
        Me.OptBC(78) = _OptBC_78
        Me.OptBC(72) = _OptBC_72
        Me.OptBC(73) = _OptBC_73
        Me.OptBC(70) = _OptBC_70
        Me.OptBC(67) = _OptBC_67
        Me.OptBC(64) = _OptBC_64
        Me.OptBC(63) = _OptBC_63
        Me.OptBC(62) = _OptBC_62
        Me.OptBC(58) = _OptBC_58
        Me.OptBC(57) = _OptBC_57
        Me.OptBC(49) = _OptBC_49
        Me.OptBC(41) = _OptBC_41
        Me.OptBC(40) = _OptBC_40
        Me.OptBC(36) = _OptBC_36
        Me.OptBC(17) = _OptBC_17
    End Sub
    Sub InitializeOpt()
        Me.Opt(3) = _Opt_3
        Me.Opt(2) = _Opt_2
    End Sub
    Sub InitializeMedNgay()
        Me.MedNgay(1) = _MedNgay_1
        Me.MedNgay(2) = _MedNgay_2
        Me.MedNgay(0) = _MedNgay_0
    End Sub
    Sub InitializeLbTenVT()
        Me.LbTenVT(1) = _LbTenVT_1
    End Sub
    Sub InitializeLbTenTk()
        Me.LbTenTk(7) = _LbTenTk_7
    End Sub
    Sub InitializeLabel()
        Me.Label(1) = _Label_1
        Me.Label(0) = _Label_0
        Me.Label(2) = _Label_2
        Me.Label(5) = _Label_5
        Me.Label(3) = _Label_3
    End Sub
    Sub InitializeFrame()
        Me.Frame(0) = _Frame_0
        Me.Frame(1) = _Frame_1
        Me.Frame(3) = _Frame_3
    End Sub
    Sub InitializeCommand()
        Me.Command(3) = _Command_3
        Me.Command(2) = _Command_2
        Me.Command(1) = _Command_1
        Me.Command(0) = _Command_0
    End Sub
    Sub InitializeChkDu()
        Me.ChkDu(16) = _ChkDu_16
        Me.ChkDu(5) = _ChkDu_5
        Me.ChkDu(14) = _ChkDu_14
    End Sub
    Sub InitializeCboThang()
        Me.CboThang(1) = _CboThang_1
        Me.CboThang(0) = _CboThang_0
    End Sub
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _OptBC_64 As System.Windows.Forms.RadioButton
#End Region
End Class
