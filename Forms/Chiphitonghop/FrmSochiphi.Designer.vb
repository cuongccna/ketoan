<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSochiphi
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
        isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		InitializetxtShTk()
		InitializetxtShCT()
		InitializetxtLS()
		Initializecmdtk()
		InitializeOptTG()
		InitializeOptBC()
		InitializeMedNgay()
		InitializeLine()
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
    Private WithEvents _MedNgay_1 As System.Windows.Forms.MaskedTextBox
	Private WithEvents _MedNgay_2 As System.Windows.Forms.MaskedTextBox
	Private WithEvents _Label_5 As System.Windows.Forms.Label
	Private WithEvents _Label_2 As System.Windows.Forms.Label
	Private WithEvents _Frame_1 As System.Windows.Forms.GroupBox
	Private WithEvents _OptTG_1 As System.Windows.Forms.RadioButton
	Private WithEvents _OptTG_0 As System.Windows.Forms.RadioButton
	Private WithEvents _CboThang_0 As ComboBoxEx.ComboBoxExt
	Private WithEvents _CboThang_1 As ComboBoxEx.ComboBoxExt
	Private WithEvents _Label_0 As System.Windows.Forms.Label
	Private WithEvents _Label_1 As System.Windows.Forms.Label
	Private WithEvents _Frame_0 As System.Windows.Forms.GroupBox
	Private WithEvents _ChkDu_16 As System.Windows.Forms.CheckBox
	Public WithEvents CboNT As ComboBoxEx.ComboBoxExt
	Private WithEvents _txtShTk_1 As System.Windows.Forms.TextBox
	Private WithEvents _txtShTk_0 As System.Windows.Forms.TextBox
	Private WithEvents _ChkDu_0 As System.Windows.Forms.CheckBox
	Private WithEvents _txtShTk_5 As System.Windows.Forms.TextBox
	Private WithEvents _OptBC_0 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_1 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_2 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_3 As System.Windows.Forms.RadioButton
	Private WithEvents _txtShTk_6 As System.Windows.Forms.TextBox
	Private WithEvents _OptBC_4 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_5 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_6 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_7 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_8 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_9 As System.Windows.Forms.RadioButton
	Private WithEvents _txtShTk_2 As System.Windows.Forms.TextBox
	Private WithEvents _txtShTk_3 As System.Windows.Forms.TextBox
	Private WithEvents _txtShCT_0 As System.Windows.Forms.TextBox
	Private WithEvents _OptBC_32 As System.Windows.Forms.RadioButton
	Private WithEvents _txtShCT_1 As System.Windows.Forms.TextBox
	Private WithEvents _CboThang_2 As ComboBoxEx.ComboBoxExt
	Private WithEvents _ChkDu_6 As System.Windows.Forms.CheckBox
	Private WithEvents _OptBC_42 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_56 As System.Windows.Forms.RadioButton
	Private WithEvents _txtShTk_8 As System.Windows.Forms.TextBox
	Private WithEvents _txtLS_1 As System.Windows.Forms.TextBox
	Private WithEvents _OptBC_69 As System.Windows.Forms.RadioButton
	Private WithEvents _txtLS_0 As System.Windows.Forms.TextBox
	Private WithEvents _ChkDu_1 As System.Windows.Forms.CheckBox
	Private WithEvents _OptBC_75 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_76 As System.Windows.Forms.RadioButton
    Private WithEvents _cmdtk_0 As System.Windows.Forms.Button
    Private WithEvents _cmdtk_1 As System.Windows.Forms.Button
    Private WithEvents _cmdtk_2 As System.Windows.Forms.Button
    Private WithEvents _cmdtk_3 As System.Windows.Forms.Button
    Private WithEvents _cmdtk_5 As System.Windows.Forms.Button
    Private WithEvents _cmdtk_8 As System.Windows.Forms.Button
    Private WithEvents _cmdtk_6 As System.Windows.Forms.Button
    Private WithEvents _LbTenTk_3 As System.Windows.Forms.Label
    Private WithEvents _Line_0 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_1 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_0 As System.Windows.Forms.Label
    Private WithEvents _Line_2 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_5 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_6 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_2 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_8 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Public WithEvents FTonghop As System.Windows.Forms.GroupBox
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Public WithEvents GauGe As System.Windows.Forms.ProgressBar
    Public CboThang(2) As ComboBoxEx.ComboBoxExt
    Public ChkDu(16) As System.Windows.Forms.CheckBox
    Public Command(3) As System.Windows.Forms.Button
    Public Frame(6) As System.Windows.Forms.GroupBox
    Public Label(8) As System.Windows.Forms.Label
    Public LbTenTk(8) As System.Windows.Forms.Label
    Public Line(2) As System.Windows.Forms.Label
    Public MedNgay(2) As System.Windows.Forms.MaskedTextBox
    Public OptBC(76) As System.Windows.Forms.RadioButton
    Public OptNN(1) As System.Windows.Forms.RadioButton
    Public OptTG(1) As System.Windows.Forms.RadioButton
    Public cmdtk(8) As System.Windows.Forms.Button
    Public txtLS(1) As System.Windows.Forms.TextBox
    Public txtShCT(1) As System.Windows.Forms.TextBox
    Public txtShTk(8) As System.Windows.Forms.TextBox
    'Private listBoxComboBoxHelper1 As Artinsoft.VB6.Gui.ListControlHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSochiphi))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Frame_1 = New System.Windows.Forms.GroupBox
        Me._MedNgay_1 = New System.Windows.Forms.MaskedTextBox
        Me._MedNgay_2 = New System.Windows.Forms.MaskedTextBox
        Me._Label_5 = New System.Windows.Forms.Label
        Me._Frame_0 = New System.Windows.Forms.GroupBox
        Me._CboThang_0 = New ComboBoxEx.ComboBoxExt
        Me._CboThang_1 = New ComboBoxEx.ComboBoxExt
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._OptTG_1 = New System.Windows.Forms.RadioButton
        Me._OptTG_0 = New System.Windows.Forms.RadioButton
        Me._ChkDu_16 = New System.Windows.Forms.CheckBox
        Me.FTonghop = New System.Windows.Forms.GroupBox
        Me.CboNT = New ComboBoxEx.ComboBoxExt
        Me._txtShTk_1 = New System.Windows.Forms.TextBox
        Me._txtShTk_0 = New System.Windows.Forms.TextBox
        Me._ChkDu_0 = New System.Windows.Forms.CheckBox
        Me._txtShTk_5 = New System.Windows.Forms.TextBox
        Me._OptBC_0 = New System.Windows.Forms.RadioButton
        Me._OptBC_1 = New System.Windows.Forms.RadioButton
        Me._OptBC_2 = New System.Windows.Forms.RadioButton
        Me._OptBC_3 = New System.Windows.Forms.RadioButton
        Me._txtShTk_6 = New System.Windows.Forms.TextBox
        Me._OptBC_4 = New System.Windows.Forms.RadioButton
        Me._OptBC_5 = New System.Windows.Forms.RadioButton
        Me._OptBC_6 = New System.Windows.Forms.RadioButton
        Me._OptBC_7 = New System.Windows.Forms.RadioButton
        Me._OptBC_8 = New System.Windows.Forms.RadioButton
        Me._OptBC_9 = New System.Windows.Forms.RadioButton
        Me._txtShTk_2 = New System.Windows.Forms.TextBox
        Me._txtShTk_3 = New System.Windows.Forms.TextBox
        Me._txtShCT_0 = New System.Windows.Forms.TextBox
        Me._OptBC_32 = New System.Windows.Forms.RadioButton
        Me._txtShCT_1 = New System.Windows.Forms.TextBox
        Me._CboThang_2 = New ComboBoxEx.ComboBoxExt
        Me._ChkDu_6 = New System.Windows.Forms.CheckBox
        Me._OptBC_42 = New System.Windows.Forms.RadioButton
        Me._OptBC_56 = New System.Windows.Forms.RadioButton
        Me._txtShTk_8 = New System.Windows.Forms.TextBox
        Me._txtLS_1 = New System.Windows.Forms.TextBox
        Me._OptBC_69 = New System.Windows.Forms.RadioButton
        Me._txtLS_0 = New System.Windows.Forms.TextBox
        Me._ChkDu_1 = New System.Windows.Forms.CheckBox
        Me._OptBC_75 = New System.Windows.Forms.RadioButton
        Me._OptBC_76 = New System.Windows.Forms.RadioButton
        Me._cmdtk_0 = New System.Windows.Forms.Button
        Me._cmdtk_1 = New System.Windows.Forms.Button
        Me._cmdtk_2 = New System.Windows.Forms.Button
        Me._cmdtk_3 = New System.Windows.Forms.Button
        Me._cmdtk_5 = New System.Windows.Forms.Button
        Me._cmdtk_8 = New System.Windows.Forms.Button
        Me._cmdtk_6 = New System.Windows.Forms.Button
        Me._LbTenTk_3 = New System.Windows.Forms.Label
        Me._Line_0 = New System.Windows.Forms.Label
        Me._LbTenTk_1 = New System.Windows.Forms.Label
        Me._LbTenTk_0 = New System.Windows.Forms.Label
        Me._Line_2 = New System.Windows.Forms.Label
        Me._LbTenTk_5 = New System.Windows.Forms.Label
        Me._LbTenTk_6 = New System.Windows.Forms.Label
        Me._LbTenTk_2 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._LbTenTk_8 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me.GauGe = New System.Windows.Forms.ProgressBar
        Me._Frame_1.SuspendLayout()
        Me._Frame_0.SuspendLayout()
        Me.FTonghop.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Frame_1
        '
        Me._Frame_1.BackColor = System.Drawing.Color.Transparent
        Me._Frame_1.Controls.Add(Me._MedNgay_1)
        Me._Frame_1.Controls.Add(Me._MedNgay_2)
        Me._Frame_1.Controls.Add(Me._Label_5)
        Me._Frame_1.Controls.Add(Me._Label_2)
        Me._Frame_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_1.Location = New System.Drawing.Point(206, 459)
        Me._Frame_1.Name = "_Frame_1"
        Me._Frame_1.Size = New System.Drawing.Size(305, 37)
        Me._Frame_1.TabIndex = 67
        Me._Frame_1.TabStop = False
        Me._Frame_1.Visible = False
        '
        '_MedNgay_1
        '
        Me._MedNgay_1.AllowPromptAsInput = False
        Me._MedNgay_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_1.Location = New System.Drawing.Point(76, 10)
        Me._MedNgay_1.Mask = "00/00/0000"
        Me._MedNgay_1.Name = "_MedNgay_1"
        Me._MedNgay_1.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_1.TabIndex = 41
        '
        '_MedNgay_2
        '
        Me._MedNgay_2.AllowPromptAsInput = False
        Me._MedNgay_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_2.Location = New System.Drawing.Point(225, 10)
        Me._MedNgay_2.Name = "_MedNgay_2"
        Me._MedNgay_2.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_2.TabIndex = 42
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.Transparent
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_5.Location = New System.Drawing.Point(155, 12)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(57, 17)
        Me._Label_5.TabIndex = 69
        Me._Label_5.Tag = "to"
        Me._Label_5.Text = "Đến ngày"
        '
        '_Frame_0
        '
        Me._Frame_0.BackColor = System.Drawing.Color.Transparent
        Me._Frame_0.Controls.Add(Me._CboThang_0)
        Me._Frame_0.Controls.Add(Me._CboThang_1)
        Me._Frame_0.Controls.Add(Me._Label_0)
        Me._Frame_0.Controls.Add(Me._Label_1)
        Me._Frame_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_0.Location = New System.Drawing.Point(200, 463)
        Me._Frame_0.Name = "_Frame_0"
        Me._Frame_0.Size = New System.Drawing.Size(305, 36)
        Me._Frame_0.TabIndex = 64
        Me._Frame_0.TabStop = False
        '
        '_CboThang_0
        '
        Me._CboThang_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_0.Location = New System.Drawing.Point(76, 11)
        Me._CboThang_0.Name = "_CboThang_0"
        Me._CboThang_0.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_0.TabIndex = 43
        '
        '_CboThang_1
        '
        Me._CboThang_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_1.Location = New System.Drawing.Point(225, 11)
        Me._CboThang_1.Name = "_CboThang_1"
        Me._CboThang_1.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_1.TabIndex = 44
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(8, 13)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(57, 17)
        Me._Label_0.TabIndex = 66
        Me._Label_0.Tag = "From"
        Me._Label_0.Text = "Từ tháng"
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(155, 13)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(64, 17)
        Me._Label_1.TabIndex = 65
        Me._Label_1.Tag = "to"
        Me._Label_1.Text = "Đến tháng"
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.Transparent
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(8, 12)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(49, 17)
        Me._Label_2.TabIndex = 68
        Me._Label_2.Tag = "From"
        Me._Label_2.Text = "Từ ngày"
        '
        '_OptTG_1
        '
        Me._OptTG_1.BackColor = System.Drawing.Color.Transparent
        Me._OptTG_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptTG_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptTG_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptTG_1.Location = New System.Drawing.Point(109, 467)
        Me._OptTG_1.Name = "_OptTG_1"
        Me._OptTG_1.Size = New System.Drawing.Size(81, 17)
        Me._OptTG_1.TabIndex = 40
        Me._OptTG_1.TabStop = True
        Me._OptTG_1.Tag = "By date"
        Me._OptTG_1.Text = "Theo ngày"
        Me._OptTG_1.UseVisualStyleBackColor = False
        '
        '_OptTG_0
        '
        Me._OptTG_0.BackColor = System.Drawing.Color.Transparent
        Me._OptTG_0.Checked = True
        Me._OptTG_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptTG_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptTG_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptTG_0.Location = New System.Drawing.Point(8, 467)
        Me._OptTG_0.Name = "_OptTG_0"
        Me._OptTG_0.Size = New System.Drawing.Size(81, 17)
        Me._OptTG_0.TabIndex = 39
        Me._OptTG_0.TabStop = True
        Me._OptTG_0.Tag = "By month"
        Me._OptTG_0.Text = "Theo tháng"
        Me._OptTG_0.UseVisualStyleBackColor = False
        '
        '_ChkDu_16
        '
        Me._ChkDu_16.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_16.Location = New System.Drawing.Point(523, 472)
        Me._ChkDu_16.Name = "_ChkDu_16"
        Me._ChkDu_16.Size = New System.Drawing.Size(83, 17)
        Me._ChkDu_16.TabIndex = 45
        Me._ChkDu_16.Tag = "List view"
        Me._ChkDu_16.Text = "&Hiển thị lưới"
        Me._ChkDu_16.UseVisualStyleBackColor = False
        '
        'FTonghop
        '
        Me.FTonghop.BackColor = System.Drawing.Color.Transparent
        Me.FTonghop.Controls.Add(Me.CboNT)
        Me.FTonghop.Controls.Add(Me._txtShTk_1)
        Me.FTonghop.Controls.Add(Me._txtShTk_0)
        Me.FTonghop.Controls.Add(Me._ChkDu_0)
        Me.FTonghop.Controls.Add(Me._txtShTk_5)
        Me.FTonghop.Controls.Add(Me._OptBC_0)
        Me.FTonghop.Controls.Add(Me._OptBC_1)
        Me.FTonghop.Controls.Add(Me._OptBC_2)
        Me.FTonghop.Controls.Add(Me._OptBC_3)
        Me.FTonghop.Controls.Add(Me._txtShTk_6)
        Me.FTonghop.Controls.Add(Me._OptBC_4)
        Me.FTonghop.Controls.Add(Me._OptBC_5)
        Me.FTonghop.Controls.Add(Me._OptBC_6)
        Me.FTonghop.Controls.Add(Me._OptBC_7)
        Me.FTonghop.Controls.Add(Me._OptBC_8)
        Me.FTonghop.Controls.Add(Me._OptBC_9)
        Me.FTonghop.Controls.Add(Me._txtShTk_2)
        Me.FTonghop.Controls.Add(Me._txtShTk_3)
        Me.FTonghop.Controls.Add(Me._txtShCT_0)
        Me.FTonghop.Controls.Add(Me._OptBC_32)
        Me.FTonghop.Controls.Add(Me._txtShCT_1)
        Me.FTonghop.Controls.Add(Me._CboThang_2)
        Me.FTonghop.Controls.Add(Me._ChkDu_6)
        Me.FTonghop.Controls.Add(Me._OptBC_42)
        Me.FTonghop.Controls.Add(Me._OptBC_56)
        Me.FTonghop.Controls.Add(Me._txtShTk_8)
        Me.FTonghop.Controls.Add(Me._txtLS_1)
        Me.FTonghop.Controls.Add(Me._OptBC_69)
        Me.FTonghop.Controls.Add(Me._txtLS_0)
        Me.FTonghop.Controls.Add(Me._ChkDu_1)
        Me.FTonghop.Controls.Add(Me._OptBC_75)
        Me.FTonghop.Controls.Add(Me._OptBC_76)
        Me.FTonghop.Controls.Add(Me._cmdtk_0)
        Me.FTonghop.Controls.Add(Me._cmdtk_1)
        Me.FTonghop.Controls.Add(Me._cmdtk_2)
        Me.FTonghop.Controls.Add(Me._cmdtk_3)
        Me.FTonghop.Controls.Add(Me._cmdtk_5)
        Me.FTonghop.Controls.Add(Me._cmdtk_8)
        Me.FTonghop.Controls.Add(Me._cmdtk_6)
        Me.FTonghop.Controls.Add(Me._LbTenTk_3)
        Me.FTonghop.Controls.Add(Me._Line_0)
        Me.FTonghop.Controls.Add(Me._LbTenTk_1)
        Me.FTonghop.Controls.Add(Me._LbTenTk_0)
        Me.FTonghop.Controls.Add(Me._Line_2)
        Me.FTonghop.Controls.Add(Me._LbTenTk_5)
        Me.FTonghop.Controls.Add(Me._LbTenTk_6)
        Me.FTonghop.Controls.Add(Me._LbTenTk_2)
        Me.FTonghop.Controls.Add(Me._Label_6)
        Me.FTonghop.Controls.Add(Me._Label_7)
        Me.FTonghop.Controls.Add(Me._LbTenTk_8)
        Me.FTonghop.Controls.Add(Me._Label_8)
        Me.FTonghop.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FTonghop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FTonghop.Location = New System.Drawing.Point(8, 8)
        Me.FTonghop.Name = "FTonghop"
        Me.FTonghop.Size = New System.Drawing.Size(617, 449)
        Me.FTonghop.TabIndex = 52
        Me.FTonghop.TabStop = False
        '
        'CboNT
        '
        Me.CboNT.BackColor = System.Drawing.SystemColors.Window
        Me.CboNT.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboNT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboNT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboNT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboNT.Location = New System.Drawing.Point(336, 260)
        Me.CboNT.Name = "CboNT"
        Me.CboNT.Size = New System.Drawing.Size(73, 21)
        Me.CboNT.TabIndex = 27
        '
        '_txtShTk_1
        '
        Me._txtShTk_1.AcceptsReturn = True
        Me._txtShTk_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_1.Location = New System.Drawing.Point(208, 76)
        Me._txtShTk_1.MaxLength = 12
        Me._txtShTk_1.Name = "_txtShTk_1"
        Me._txtShTk_1.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_1.TabIndex = 7
        Me._txtShTk_1.Tag = "0"
        '
        '_txtShTk_0
        '
        Me._txtShTk_0.AcceptsReturn = True
        Me._txtShTk_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_0.Location = New System.Drawing.Point(208, 20)
        Me._txtShTk_0.MaxLength = 12
        Me._txtShTk_0.Name = "_txtShTk_0"
        Me._txtShTk_0.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_0.TabIndex = 1
        Me._txtShTk_0.Tag = "0"
        '
        '_ChkDu_0
        '
        Me._ChkDu_0.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_0.Location = New System.Drawing.Point(208, 44)
        Me._ChkDu_0.Name = "_ChkDu_0"
        Me._ChkDu_0.Size = New System.Drawing.Size(89, 17)
        Me._ChkDu_0.TabIndex = 3
        Me._ChkDu_0.Tag = "by Ref. Acc."
        Me._ChkDu_0.Text = "Theo đối ứng"
        Me._ChkDu_0.UseVisualStyleBackColor = False
        '
        '_txtShTk_5
        '
        Me._txtShTk_5.AcceptsReturn = True
        Me._txtShTk_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_5.Location = New System.Drawing.Point(336, 44)
        Me._txtShTk_5.MaxLength = 12
        Me._txtShTk_5.Name = "_txtShTk_5"
        Me._txtShTk_5.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_5.TabIndex = 4
        Me._txtShTk_5.Tag = "0"
        '
        '_OptBC_0
        '
        Me._OptBC_0.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_0.Checked = True
        Me._OptBC_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_0.Location = New System.Drawing.Point(16, 20)
        Me._OptBC_0.Name = "_OptBC_0"
        Me._OptBC_0.Size = New System.Drawing.Size(185, 17)
        Me._OptBC_0.TabIndex = 0
        Me._OptBC_0.TabStop = True
        Me._OptBC_0.Tag = "Account Detail Report"
        Me._OptBC_0.Text = "Sổ chi tiết"
        Me._OptBC_0.UseVisualStyleBackColor = False
        '
        '_OptBC_1
        '
        Me._OptBC_1.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_1.Location = New System.Drawing.Point(16, 76)
        Me._OptBC_1.Name = "_OptBC_1"
        Me._OptBC_1.Size = New System.Drawing.Size(185, 17)
        Me._OptBC_1.TabIndex = 6
        Me._OptBC_1.TabStop = True
        Me._OptBC_1.Tag = "Print all Detail Report of Account"
        Me._OptBC_1.Text = "In toàn bộ chi tiết tài khoản"
        Me._OptBC_1.UseVisualStyleBackColor = False
        '
        '_OptBC_2
        '
        Me._OptBC_2.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_2.Location = New System.Drawing.Point(16, 100)
        Me._OptBC_2.Name = "_OptBC_2"
        Me._OptBC_2.Size = New System.Drawing.Size(185, 17)
        Me._OptBC_2.TabIndex = 9
        Me._OptBC_2.TabStop = True
        Me._OptBC_2.Tag = "Print all Detail Report FROM"
        Me._OptBC_2.Text = "In toàn bộ các sổ chi tiết từ"
        Me._OptBC_2.UseVisualStyleBackColor = False
        '
        '_OptBC_3
        '
        Me._OptBC_3.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_3.Location = New System.Drawing.Point(16, 124)
        Me._OptBC_3.Name = "_OptBC_3"
        Me._OptBC_3.Size = New System.Drawing.Size(185, 17)
        Me._OptBC_3.TabIndex = 12
        Me._OptBC_3.TabStop = True
        Me._OptBC_3.Tag = "Detail Account Balance Report"
        Me._OptBC_3.Text = "Bảng tổng hợp số dư chi tiết"
        Me._OptBC_3.UseVisualStyleBackColor = False
        '
        '_txtShTk_6
        '
        Me._txtShTk_6.AcceptsReturn = True
        Me._txtShTk_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_6.Location = New System.Drawing.Point(336, 124)
        Me._txtShTk_6.MaxLength = 12
        Me._txtShTk_6.Name = "_txtShTk_6"
        Me._txtShTk_6.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_6.TabIndex = 14
        Me._txtShTk_6.Tag = "0"
        '
        '_OptBC_4
        '
        Me._OptBC_4.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_4.Location = New System.Drawing.Point(16, 260)
        Me._OptBC_4.Name = "_OptBC_4"
        Me._OptBC_4.Size = New System.Drawing.Size(185, 17)
        Me._OptBC_4.TabIndex = 24
        Me._OptBC_4.TabStop = True
        Me._OptBC_4.Tag = "Foreign currency detail report"
        Me._OptBC_4.Text = "Sổ chi tiết nguyên tệ"
        Me._OptBC_4.UseVisualStyleBackColor = False
        '
        '_OptBC_5
        '
        Me._OptBC_5.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_5.Location = New System.Drawing.Point(16, 284)
        Me._OptBC_5.Name = "_OptBC_5"
        Me._OptBC_5.Size = New System.Drawing.Size(185, 17)
        Me._OptBC_5.TabIndex = 28
        Me._OptBC_5.TabStop = True
        Me._OptBC_5.Tag = "Print all detail of account"
        Me._OptBC_5.Text = "In chi tiết nguyên tệ tài khoản"
        Me._OptBC_5.UseVisualStyleBackColor = False
        '
        '_OptBC_6
        '
        Me._OptBC_6.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_6.Location = New System.Drawing.Point(16, 308)
        Me._OptBC_6.Name = "_OptBC_6"
        Me._OptBC_6.Size = New System.Drawing.Size(281, 17)
        Me._OptBC_6.TabIndex = 31
        Me._OptBC_6.TabStop = True
        Me._OptBC_6.Tag = "Print all Foreign currency detail report"
        Me._OptBC_6.Text = "In toàn bộ các sổ chi tiết nguyên tệ"
        Me._OptBC_6.UseVisualStyleBackColor = False
        '
        '_OptBC_7
        '
        Me._OptBC_7.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_7.Location = New System.Drawing.Point(16, 332)
        Me._OptBC_7.Name = "_OptBC_7"
        Me._OptBC_7.Size = New System.Drawing.Size(281, 17)
        Me._OptBC_7.TabIndex = 32
        Me._OptBC_7.TabStop = True
        Me._OptBC_7.Tag = "Balance of foreign currency report"
        Me._OptBC_7.Text = "Bảng tổng hợp số dư chi tiết nguyên tệ"
        Me._OptBC_7.UseVisualStyleBackColor = False
        '
        '_OptBC_8
        '
        Me._OptBC_8.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_8.Location = New System.Drawing.Point(16, 372)
        Me._OptBC_8.Name = "_OptBC_8"
        Me._OptBC_8.Size = New System.Drawing.Size(281, 17)
        Me._OptBC_8.TabIndex = 33
        Me._OptBC_8.TabStop = True
        Me._OptBC_8.Tag = "Trial balance before closing"
        Me._OptBC_8.Text = "Bảng cân đối số phát sinh trước khoá sổ"
        Me._OptBC_8.UseVisualStyleBackColor = False
        '
        '_OptBC_9
        '
        Me._OptBC_9.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_9.Location = New System.Drawing.Point(16, 396)
        Me._OptBC_9.Name = "_OptBC_9"
        Me._OptBC_9.Size = New System.Drawing.Size(281, 17)
        Me._OptBC_9.TabIndex = 35
        Me._OptBC_9.TabStop = True
        Me._OptBC_9.Tag = "Trial balance after closing"
        Me._OptBC_9.Text = "Bảng cân đối số phát sinh sau khoá sổ"
        Me._OptBC_9.UseVisualStyleBackColor = False
        '
        '_txtShTk_2
        '
        Me._txtShTk_2.AcceptsReturn = True
        Me._txtShTk_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_2.Location = New System.Drawing.Point(208, 260)
        Me._txtShTk_2.MaxLength = 12
        Me._txtShTk_2.Name = "_txtShTk_2"
        Me._txtShTk_2.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_2.TabIndex = 25
        Me._txtShTk_2.Tag = "0"
        '
        '_txtShTk_3
        '
        Me._txtShTk_3.AcceptsReturn = True
        Me._txtShTk_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_3.Location = New System.Drawing.Point(208, 284)
        Me._txtShTk_3.MaxLength = 12
        Me._txtShTk_3.Name = "_txtShTk_3"
        Me._txtShTk_3.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_3.TabIndex = 29
        Me._txtShTk_3.Tag = "0"
        '
        '_txtShCT_0
        '
        Me._txtShCT_0.AcceptsReturn = True
        Me._txtShCT_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtShCT_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShCT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShCT_0.Location = New System.Drawing.Point(208, 100)
        Me._txtShCT_0.MaxLength = 12
        Me._txtShCT_0.Name = "_txtShCT_0"
        Me._txtShCT_0.Size = New System.Drawing.Size(89, 20)
        Me._txtShCT_0.TabIndex = 10
        Me._txtShCT_0.Tag = "0"
        '
        '_OptBC_32
        '
        Me._OptBC_32.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_32.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_32.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_32.Location = New System.Drawing.Point(304, 420)
        Me._OptBC_32.Name = "_OptBC_32"
        Me._OptBC_32.Size = New System.Drawing.Size(153, 17)
        Me._OptBC_32.TabIndex = 38
        Me._OptBC_32.TabStop = True
        Me._OptBC_32.Tag = "Chart of Account"
        Me._OptBC_32.Text = "Hệ thống tài khoản"
        Me._OptBC_32.UseVisualStyleBackColor = False
        '
        '_txtShCT_1
        '
        Me._txtShCT_1.AcceptsReturn = True
        Me._txtShCT_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtShCT_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShCT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShCT_1.Location = New System.Drawing.Point(336, 100)
        Me._txtShCT_1.MaxLength = 12
        Me._txtShCT_1.Name = "_txtShCT_1"
        Me._txtShCT_1.Size = New System.Drawing.Size(89, 20)
        Me._txtShCT_1.TabIndex = 11
        Me._txtShCT_1.Tag = "0"
        Me._txtShCT_1.Visible = False
        '
        '_CboThang_2
        '
        Me._CboThang_2.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_2.DropDownWidth = 29
        Me._CboThang_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_2.Location = New System.Drawing.Point(416, 368)
        Me._CboThang_2.Name = "_CboThang_2"
        Me._CboThang_2.Size = New System.Drawing.Size(41, 21)
        Me._CboThang_2.TabIndex = 34
        '
        '_ChkDu_6
        '
        Me._ChkDu_6.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_6.Location = New System.Drawing.Point(304, 396)
        Me._ChkDu_6.Name = "_ChkDu_6"
        Me._ChkDu_6.Size = New System.Drawing.Size(153, 17)
        Me._ChkDu_6.TabIndex = 36
        Me._ChkDu_6.Tag = "Print all account"
        Me._ChkDu_6.Text = "In chi tiết không có số liệu"
        Me._ChkDu_6.UseVisualStyleBackColor = False
        '
        '_OptBC_42
        '
        Me._OptBC_42.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_42.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_42.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_42.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_42.Location = New System.Drawing.Point(16, 148)
        Me._OptBC_42.Name = "_OptBC_42"
        Me._OptBC_42.Size = New System.Drawing.Size(185, 17)
        Me._OptBC_42.TabIndex = 16
        Me._OptBC_42.TabStop = True
        Me._OptBC_42.Tag = "Detail for arising cost"
        Me._OptBC_42.Text = "Bảng kê chi tiết phát sinh"
        Me._OptBC_42.UseVisualStyleBackColor = False
        '
        '_OptBC_56
        '
        Me._OptBC_56.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_56.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_56.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_56.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_56.Location = New System.Drawing.Point(16, 172)
        Me._OptBC_56.Name = "_OptBC_56"
        Me._OptBC_56.Size = New System.Drawing.Size(313, 17)
        Me._OptBC_56.TabIndex = 19
        Me._OptBC_56.TabStop = True
        Me._OptBC_56.Tag = "Summary of arising cost according to group"
        Me._OptBC_56.Text = "Tổng hợp phát sinh theo nhóm"
        Me._OptBC_56.UseVisualStyleBackColor = False
        '
        '_txtShTk_8
        '
        Me._txtShTk_8.AcceptsReturn = True
        Me._txtShTk_8.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_8.Location = New System.Drawing.Point(208, 148)
        Me._txtShTk_8.MaxLength = 12
        Me._txtShTk_8.Name = "_txtShTk_8"
        Me._txtShTk_8.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_8.TabIndex = 17
        Me._txtShTk_8.Tag = "0"
        '
        '_txtLS_1
        '
        Me._txtLS_1.AcceptsReturn = True
        Me._txtLS_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtLS_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtLS_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtLS_1.Location = New System.Drawing.Point(464, 196)
        Me._txtLS_1.MaxLength = 5
        Me._txtLS_1.Name = "_txtLS_1"
        Me._txtLS_1.Size = New System.Drawing.Size(41, 20)
        Me._txtLS_1.TabIndex = 22
        Me._txtLS_1.Text = "0"
        '
        '_OptBC_69
        '
        Me._OptBC_69.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_69.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_69.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_69.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_69.Location = New System.Drawing.Point(16, 196)
        Me._OptBC_69.Name = "_OptBC_69"
        Me._OptBC_69.Size = New System.Drawing.Size(313, 17)
        Me._OptBC_69.TabIndex = 20
        Me._OptBC_69.TabStop = True
        Me._OptBC_69.Tag = "Detail Interest Table                           Debit Interest Rate"
        Me._OptBC_69.Text = "Bảng kê tích số theo lãi suất (% tháng):                   Lãi dư nợ"
        Me._OptBC_69.UseVisualStyleBackColor = False
        '
        '_txtLS_0
        '
        Me._txtLS_0.AcceptsReturn = True
        Me._txtLS_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtLS_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtLS_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtLS_0.Location = New System.Drawing.Point(336, 196)
        Me._txtLS_0.MaxLength = 5
        Me._txtLS_0.Name = "_txtLS_0"
        Me._txtLS_0.Size = New System.Drawing.Size(41, 20)
        Me._txtLS_0.TabIndex = 21
        Me._txtLS_0.Text = "0"
        '
        '_ChkDu_1
        '
        Me._ChkDu_1.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_1.Location = New System.Drawing.Point(208, 124)
        Me._ChkDu_1.Name = "_ChkDu_1"
        Me._ChkDu_1.Size = New System.Drawing.Size(97, 17)
        Me._ChkDu_1.TabIndex = 13
        Me._ChkDu_1.Tag = "By Account"
        Me._ChkDu_1.Text = "Theo tài khoản"
        Me._ChkDu_1.UseVisualStyleBackColor = False
        '
        '_OptBC_75
        '
        Me._OptBC_75.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_75.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_75.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_75.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_75.Location = New System.Drawing.Point(16, 220)
        Me._OptBC_75.Name = "_OptBC_75"
        Me._OptBC_75.Size = New System.Drawing.Size(313, 17)
        Me._OptBC_75.TabIndex = 23
        Me._OptBC_75.TabStop = True
        Me._OptBC_75.Tag = "Common spring with form letter T"
        Me._OptBC_75.Text = "Tổng hợp phát sinh chữ T"
        Me._OptBC_75.UseVisualStyleBackColor = False
        '
        '_OptBC_76
        '
        Me._OptBC_76.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_76.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_76.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_76.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_76.Location = New System.Drawing.Point(16, 420)
        Me._OptBC_76.Name = "_OptBC_76"
        Me._OptBC_76.Size = New System.Drawing.Size(281, 17)
        Me._OptBC_76.TabIndex = 37
        Me._OptBC_76.TabStop = True
        Me._OptBC_76.Tag = "Trail balance from the begining of the year"
        Me._OptBC_76.Text = "Bảng cân đối số phát sinh luỹ kế từ đầu năm"
        Me._OptBC_76.UseVisualStyleBackColor = False
        '
        '_cmdtk_0
        '
        Me._cmdtk_0.Image = CType(resources.GetObject("_cmdtk_0.Image"), System.Drawing.Image)
        Me._cmdtk_0.Location = New System.Drawing.Point(304, 19)
        Me._cmdtk_0.Name = "_cmdtk_0"
        Me._cmdtk_0.Size = New System.Drawing.Size(24, 22)
        Me._cmdtk_0.TabIndex = 2
        '
        '_cmdtk_1
        '
        Me._cmdtk_1.Image = CType(resources.GetObject("_cmdtk_1.Image"), System.Drawing.Image)
        Me._cmdtk_1.Location = New System.Drawing.Point(304, 75)
        Me._cmdtk_1.Name = "_cmdtk_1"
        Me._cmdtk_1.Size = New System.Drawing.Size(24, 22)
        Me._cmdtk_1.TabIndex = 8
        '
        '_cmdtk_2
        '
        Me._cmdtk_2.Image = CType(resources.GetObject("_cmdtk_2.Image"), System.Drawing.Image)
        Me._cmdtk_2.Location = New System.Drawing.Point(304, 259)
        Me._cmdtk_2.Name = "_cmdtk_2"
        Me._cmdtk_2.Size = New System.Drawing.Size(24, 22)
        Me._cmdtk_2.TabIndex = 26
        '
        '_cmdtk_3
        '
        Me._cmdtk_3.Image = CType(resources.GetObject("_cmdtk_3.Image"), System.Drawing.Image)
        Me._cmdtk_3.Location = New System.Drawing.Point(304, 283)
        Me._cmdtk_3.Name = "_cmdtk_3"
        Me._cmdtk_3.Size = New System.Drawing.Size(24, 22)
        Me._cmdtk_3.TabIndex = 30
        '
        '_cmdtk_5
        '
        Me._cmdtk_5.Image = CType(resources.GetObject("_cmdtk_5.Image"), System.Drawing.Image)
        Me._cmdtk_5.Location = New System.Drawing.Point(432, 43)
        Me._cmdtk_5.Name = "_cmdtk_5"
        Me._cmdtk_5.Size = New System.Drawing.Size(24, 22)
        Me._cmdtk_5.TabIndex = 5
        '
        '_cmdtk_8
        '
        Me._cmdtk_8.Image = CType(resources.GetObject("_cmdtk_8.Image"), System.Drawing.Image)
        Me._cmdtk_8.Location = New System.Drawing.Point(304, 147)
        Me._cmdtk_8.Name = "_cmdtk_8"
        Me._cmdtk_8.Size = New System.Drawing.Size(24, 22)
        Me._cmdtk_8.TabIndex = 18
        '
        '_cmdtk_6
        '
        Me._cmdtk_6.Image = CType(resources.GetObject("_cmdtk_6.Image"), System.Drawing.Image)
        Me._cmdtk_6.Location = New System.Drawing.Point(432, 123)
        Me._cmdtk_6.Name = "_cmdtk_6"
        Me._cmdtk_6.Size = New System.Drawing.Size(24, 22)
        Me._cmdtk_6.TabIndex = 15
        '
        '_LbTenTk_3
        '
        Me._LbTenTk_3.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_3.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_3.Location = New System.Drawing.Point(336, 284)
        Me._LbTenTk_3.Name = "_LbTenTk_3"
        Me._LbTenTk_3.Size = New System.Drawing.Size(273, 17)
        Me._LbTenTk_3.TabIndex = 62
        Me._LbTenTk_3.Tag = "1"
        '
        '_Line_0
        '
        Me._Line_0.Enabled = False
        Me._Line_0.Location = New System.Drawing.Point(16, 244)
        Me._Line_0.Name = "_Line_0"
        Me._Line_0.Size = New System.Drawing.Size(224, 1)
        Me._Line_0.TabIndex = 63
        '
        '_LbTenTk_1
        '
        Me._LbTenTk_1.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_1.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_1.Location = New System.Drawing.Point(336, 76)
        Me._LbTenTk_1.Name = "_LbTenTk_1"
        Me._LbTenTk_1.Size = New System.Drawing.Size(273, 17)
        Me._LbTenTk_1.TabIndex = 61
        Me._LbTenTk_1.Tag = "1"
        '
        '_LbTenTk_0
        '
        Me._LbTenTk_0.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_0.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_0.Location = New System.Drawing.Point(336, 20)
        Me._LbTenTk_0.Name = "_LbTenTk_0"
        Me._LbTenTk_0.Size = New System.Drawing.Size(273, 17)
        Me._LbTenTk_0.TabIndex = 60
        Me._LbTenTk_0.Tag = "1"
        '
        '_Line_2
        '
        Me._Line_2.Enabled = False
        Me._Line_2.Location = New System.Drawing.Point(16, 356)
        Me._Line_2.Name = "_Line_2"
        Me._Line_2.Size = New System.Drawing.Size(224, 1)
        Me._Line_2.TabIndex = 64
        '
        '_LbTenTk_5
        '
        Me._LbTenTk_5.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_5.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_5.Location = New System.Drawing.Point(464, 44)
        Me._LbTenTk_5.Name = "_LbTenTk_5"
        Me._LbTenTk_5.Size = New System.Drawing.Size(145, 17)
        Me._LbTenTk_5.TabIndex = 59
        Me._LbTenTk_5.Tag = "1"
        '
        '_LbTenTk_6
        '
        Me._LbTenTk_6.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_6.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_6.Location = New System.Drawing.Point(464, 124)
        Me._LbTenTk_6.Name = "_LbTenTk_6"
        Me._LbTenTk_6.Size = New System.Drawing.Size(145, 17)
        Me._LbTenTk_6.TabIndex = 58
        Me._LbTenTk_6.Tag = "1"
        '
        '_LbTenTk_2
        '
        Me._LbTenTk_2.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_2.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_2.Location = New System.Drawing.Point(416, 260)
        Me._LbTenTk_2.Name = "_LbTenTk_2"
        Me._LbTenTk_2.Size = New System.Drawing.Size(193, 17)
        Me._LbTenTk_2.TabIndex = 57
        Me._LbTenTk_2.Tag = "1"
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.Transparent
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_6.Location = New System.Drawing.Point(301, 103)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(25, 17)
        Me._Label_6.TabIndex = 56
        Me._Label_6.Tag = "to"
        Me._Label_6.Text = "đến"
        Me._Label_6.Visible = False
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.Transparent
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_7.Location = New System.Drawing.Point(304, 372)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(105, 17)
        Me._Label_7.TabIndex = 55
        Me._Label_7.Tag = "Level of Account"
        Me._Label_7.Text = "In đến tài khoản cấp"
        '
        '_LbTenTk_8
        '
        Me._LbTenTk_8.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_8.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_8.Location = New System.Drawing.Point(336, 148)
        Me._LbTenTk_8.Name = "_LbTenTk_8"
        Me._LbTenTk_8.Size = New System.Drawing.Size(273, 17)
        Me._LbTenTk_8.TabIndex = 54
        Me._LbTenTk_8.Tag = "1"
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.Transparent
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_8.Location = New System.Drawing.Point(400, 196)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(57, 17)
        Me._Label_8.TabIndex = 53
        Me._Label_8.Tag = "Credit Interest Rate"
        Me._Label_8.Text = "Lãi dư có"
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.excel16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(447, 507)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(86, 25)
        Me._Command_3.TabIndex = 51
        Me._Command_3.Tag = "Exp. Excel"
        Me._Command_3.Text = "Xuất &Excel"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(539, 507)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(86, 25)
        Me._Command_2.TabIndex = 50
        Me._Command_2.Tag = "Return"
        Me._Command_2.Text = "Trở &về"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.print16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(355, 507)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(86, 25)
        Me._Command_1.TabIndex = 49
        Me._Command_1.Tag = "Print"
        Me._Command_1.Text = "&In"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.report16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(263, 507)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(86, 25)
        Me._Command_0.TabIndex = 48
        Me._Command_0.Tag = "Preview"
        Me._Command_0.Text = "&Xem"
        '
        'GauGe
        '
        Me.GauGe.Location = New System.Drawing.Point(8, 511)
        Me.GauGe.Name = "GauGe"
        Me.GauGe.Size = New System.Drawing.Size(249, 17)
        Me.GauGe.TabIndex = 63
        '
        'FrmSochiphi
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(630, 540)
        Me.Controls.Add(Me._Frame_1)
        Me.Controls.Add(Me._OptTG_1)
        Me.Controls.Add(Me._OptTG_0)
        Me.Controls.Add(Me._Frame_0)
        Me.Controls.Add(Me._ChkDu_16)
        Me.Controls.Add(Me.FTonghop)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me.GauGe)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSochiphi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Reports"
        Me.Text = "Sổ chi phí"
        Me._Frame_1.ResumeLayout(False)
        Me._Frame_1.PerformLayout()
        Me._Frame_0.ResumeLayout(False)
        Me.FTonghop.ResumeLayout(False)
        Me.FTonghop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
	Sub InitializetxtShTk()
		Me.txtShTk(1) = _txtShTk_1
		Me.txtShTk(0) = _txtShTk_0
		Me.txtShTk(5) = _txtShTk_5
		Me.txtShTk(6) = _txtShTk_6
		Me.txtShTk(2) = _txtShTk_2
		Me.txtShTk(3) = _txtShTk_3
		Me.txtShTk(8) = _txtShTk_8
	End Sub
	Sub InitializetxtShCT()
		Me.txtShCT(0) = _txtShCT_0
		Me.txtShCT(1) = _txtShCT_1
	End Sub
	Sub InitializetxtLS()
		Me.txtLS(1) = _txtLS_1
		Me.txtLS(0) = _txtLS_0
	End Sub
	Sub Initializecmdtk()
		Me.cmdtk(0) = _cmdtk_0
		Me.cmdtk(1) = _cmdtk_1
		Me.cmdtk(2) = _cmdtk_2
		Me.cmdtk(3) = _cmdtk_3
		Me.cmdtk(5) = _cmdtk_5
		Me.cmdtk(8) = _cmdtk_8
		Me.cmdtk(6) = _cmdtk_6
	End Sub
	Sub InitializeOptTG()
		Me.OptTG(1) = _OptTG_1
		Me.OptTG(0) = _OptTG_0
	End Sub
	Sub InitializeOptBC()
		Me.OptBC(0) = _OptBC_0
		Me.OptBC(1) = _OptBC_1
		Me.OptBC(2) = _OptBC_2
		Me.OptBC(3) = _OptBC_3
		Me.OptBC(4) = _OptBC_4
		Me.OptBC(5) = _OptBC_5
		Me.OptBC(6) = _OptBC_6
		Me.OptBC(7) = _OptBC_7
		Me.OptBC(8) = _OptBC_8
		Me.OptBC(9) = _OptBC_9
		Me.OptBC(32) = _OptBC_32
		Me.OptBC(42) = _OptBC_42
		Me.OptBC(56) = _OptBC_56
		Me.OptBC(69) = _OptBC_69
		Me.OptBC(75) = _OptBC_75
		Me.OptBC(76) = _OptBC_76
	End Sub
	Sub InitializeMedNgay()
		Me.MedNgay(1) = _MedNgay_1
		Me.MedNgay(2) = _MedNgay_2
	End Sub
	Sub InitializeLine()
		Me.Line(0) = _Line_0
		Me.Line(2) = _Line_2
	End Sub
	Sub InitializeLbTenTk()
		Me.LbTenTk(3) = _LbTenTk_3
		Me.LbTenTk(1) = _LbTenTk_1
		Me.LbTenTk(0) = _LbTenTk_0
		Me.LbTenTk(5) = _LbTenTk_5
		Me.LbTenTk(6) = _LbTenTk_6
		Me.LbTenTk(2) = _LbTenTk_2
		Me.LbTenTk(8) = _LbTenTk_8
	End Sub
	Sub InitializeLabel()
		Me.Label(5) = _Label_5
		Me.Label(2) = _Label_2
		Me.Label(0) = _Label_0
		Me.Label(1) = _Label_1
		Me.Label(6) = _Label_6
		Me.Label(7) = _Label_7
		Me.Label(8) = _Label_8
	End Sub
	Sub InitializeFrame()
		Me.Frame(1) = _Frame_1
		Me.Frame(0) = _Frame_0
	End Sub
	Sub InitializeCommand()
		Me.Command(3) = _Command_3
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
	Sub InitializeChkDu()
		Me.ChkDu(16) = _ChkDu_16
		Me.ChkDu(0) = _ChkDu_0
		Me.ChkDu(6) = _ChkDu_6
		Me.ChkDu(1) = _ChkDu_1
	End Sub
	Sub InitializeCboThang()
		Me.CboThang(0) = _CboThang_0
		Me.CboThang(1) = _CboThang_1
		Me.CboThang(2) = _CboThang_2
	End Sub
#End Region 
End Class
