<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSovattuhanghoabh
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
        isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		InitializetxtShVT()
		InitializetxtShTk()
		InitializetxtCT()
		Initializecmdvt()
		Initializecmdtk()
		InitializecmdCT()
		InitializeOptTG()
		InitializeOptKho()
		InitializeOptBC()
		InitializeMedNgay()
		InitializeLbTenVT()
		InitializeLbTenTk()
		InitializeLbCT()
		InitializeLabel()
		InitializeFrame()
		InitializeCommand()
		InitializeChkDu()
		InitializeCboThang()
		InitializeCboLoai()
		InitializeCboKho()
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
	Private WithEvents _txtShTk_10 As System.Windows.Forms.TextBox
    Private WithEvents _cmdtk_10 As System.Windows.Forms.Button
    Private WithEvents _txtShTk_4 As System.Windows.Forms.TextBox
    Private WithEvents _ChkDu_3 As System.Windows.Forms.CheckBox
    Private WithEvents _CboLoai_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _ChkDu_2 As System.Windows.Forms.CheckBox
    Private WithEvents _OptBC_12 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBC_13 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBC_14 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBC_15 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBC_16 As System.Windows.Forms.RadioButton
    Private WithEvents _ChkDu_4 As System.Windows.Forms.CheckBox
    Private WithEvents _CboLoai_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _ChkDu_7 As System.Windows.Forms.CheckBox
    Private WithEvents _OptBC_44 As System.Windows.Forms.RadioButton
    Private WithEvents _txtShTk_11 As System.Windows.Forms.TextBox
    Private WithEvents _OptBC_46 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBC_47 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBC_48 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBC_52 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBC_55 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBC_60 As System.Windows.Forms.RadioButton
    Private WithEvents _txtCT_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtShVT_0 As System.Windows.Forms.TextBox
    Private WithEvents _OptBC_64 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBC_65 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBC_43 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBC_74 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBC_77 As System.Windows.Forms.RadioButton
    Private WithEvents _OptKho_1 As System.Windows.Forms.RadioButton
    Private WithEvents _OptKho_0 As System.Windows.Forms.RadioButton
    Private WithEvents _CboKho_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Frame_5 As System.Windows.Forms.GroupBox
    Public WithEvents CmdAdd As System.Windows.Forms.Button
    Private WithEvents _cmdtk_11 As System.Windows.Forms.Button
    Private WithEvents _cmdvt_0 As System.Windows.Forms.Button
    Private WithEvents _cmdCT_1 As System.Windows.Forms.Button
    Private WithEvents _cmdtk_4 As System.Windows.Forms.Button
    Private WithEvents _LbTenVT_0 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_4 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_10 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_11 As System.Windows.Forms.Label
    Private WithEvents _LbCT_1 As System.Windows.Forms.Label
    Public WithEvents FVattu As System.Windows.Forms.GroupBox
    Private WithEvents _CboThang_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboThang_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Frame_0 As System.Windows.Forms.GroupBox
    Private WithEvents _OptTG_0 As System.Windows.Forms.RadioButton
    Private WithEvents _OptTG_1 As System.Windows.Forms.RadioButton
    Private WithEvents _MedNgay_1 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _MedNgay_2 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Frame_1 As System.Windows.Forms.GroupBox
    Private WithEvents _ChkDu_16 As System.Windows.Forms.CheckBox
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Public WithEvents GauGe As System.Windows.Forms.ProgressBar
    Public CboKho(0) As ComboBoxEx.ComboBoxExt
    Public CboLoai(1) As ComboBoxEx.ComboBoxExt
    Public CboThang(1) As ComboBoxEx.ComboBoxExt
    Public ChkDu(16) As System.Windows.Forms.CheckBox
    Public Command(3) As System.Windows.Forms.Button
    Public Frame(5) As System.Windows.Forms.GroupBox
    Public Label(5) As System.Windows.Forms.Label
    Public LbCT(1) As System.Windows.Forms.Label
    Public LbTenTk(11) As System.Windows.Forms.Label
    Public LbTenVT(0) As System.Windows.Forms.Label
    Public MedNgay(2) As System.Windows.Forms.MaskedTextBox
    Public OptBC(77) As System.Windows.Forms.RadioButton
    Public OptKho(1) As System.Windows.Forms.RadioButton
    Public OptTG(1) As System.Windows.Forms.RadioButton
    Public cmdCT(1) As System.Windows.Forms.Button
    Public cmdtk(11) As System.Windows.Forms.Button
    Public cmdvt(0) As System.Windows.Forms.Button
    Public txtCT(1) As System.Windows.Forms.TextBox
    Public txtShTk(11) As System.Windows.Forms.TextBox
    Public txtShVT(0) As System.Windows.Forms.TextBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSovattuhanghoabh))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.FVattu = New System.Windows.Forms.GroupBox()
        Me._txtShTk_10 = New System.Windows.Forms.TextBox()
        Me._cmdtk_10 = New System.Windows.Forms.Button()
        Me._txtShTk_4 = New System.Windows.Forms.TextBox()
        Me._ChkDu_3 = New System.Windows.Forms.CheckBox()
        Me._CboLoai_0 = New ComboBoxEx.ComboBoxExt()
        Me._ChkDu_2 = New System.Windows.Forms.CheckBox()
        Me._OptBC_12 = New System.Windows.Forms.RadioButton()
        Me._OptBC_13 = New System.Windows.Forms.RadioButton()
        Me._OptBC_14 = New System.Windows.Forms.RadioButton()
        Me._OptBC_15 = New System.Windows.Forms.RadioButton()
        Me._OptBC_16 = New System.Windows.Forms.RadioButton()
        Me._ChkDu_4 = New System.Windows.Forms.CheckBox()
        Me._CboLoai_1 = New ComboBoxEx.ComboBoxExt()
        Me._ChkDu_7 = New System.Windows.Forms.CheckBox()
        Me._OptBC_44 = New System.Windows.Forms.RadioButton()
        Me._txtShTk_11 = New System.Windows.Forms.TextBox()
        Me._OptBC_46 = New System.Windows.Forms.RadioButton()
        Me._OptBC_47 = New System.Windows.Forms.RadioButton()
        Me._OptBC_48 = New System.Windows.Forms.RadioButton()
        Me._OptBC_52 = New System.Windows.Forms.RadioButton()
        Me._OptBC_55 = New System.Windows.Forms.RadioButton()
        Me._OptBC_60 = New System.Windows.Forms.RadioButton()
        Me._txtCT_1 = New System.Windows.Forms.TextBox()
        Me._txtShVT_0 = New System.Windows.Forms.TextBox()
        Me._OptBC_64 = New System.Windows.Forms.RadioButton()
        Me._OptBC_65 = New System.Windows.Forms.RadioButton()
        Me._OptBC_43 = New System.Windows.Forms.RadioButton()
        Me._OptBC_74 = New System.Windows.Forms.RadioButton()
        Me._OptBC_77 = New System.Windows.Forms.RadioButton()
        Me._Frame_5 = New System.Windows.Forms.GroupBox()
        Me._OptKho_1 = New System.Windows.Forms.RadioButton()
        Me._OptKho_0 = New System.Windows.Forms.RadioButton()
        Me._CboKho_0 = New ComboBoxEx.ComboBoxExt()
        Me.CmdAdd = New System.Windows.Forms.Button()
        Me._cmdtk_11 = New System.Windows.Forms.Button()
        Me._cmdvt_0 = New System.Windows.Forms.Button()
        Me._cmdCT_1 = New System.Windows.Forms.Button()
        Me._cmdtk_4 = New System.Windows.Forms.Button()
        Me._LbTenVT_0 = New System.Windows.Forms.Label()
        Me._LbTenTk_4 = New System.Windows.Forms.Label()
        Me._LbTenTk_10 = New System.Windows.Forms.Label()
        Me._LbTenTk_11 = New System.Windows.Forms.Label()
        Me._LbCT_1 = New System.Windows.Forms.Label()
        Me._Frame_0 = New System.Windows.Forms.GroupBox()
        Me._CboThang_1 = New ComboBoxEx.ComboBoxExt()
        Me._CboThang_0 = New ComboBoxEx.ComboBoxExt()
        Me._Label_1 = New System.Windows.Forms.Label()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me._OptTG_0 = New System.Windows.Forms.RadioButton()
        Me._OptTG_1 = New System.Windows.Forms.RadioButton()
        Me._Frame_1 = New System.Windows.Forms.GroupBox()
        Me._MedNgay_1 = New System.Windows.Forms.MaskedTextBox()
        Me._MedNgay_2 = New System.Windows.Forms.MaskedTextBox()
        Me._Label_4 = New System.Windows.Forms.Label()
        Me._Label_5 = New System.Windows.Forms.Label()
        Me._ChkDu_16 = New System.Windows.Forms.CheckBox()
        Me._Command_3 = New System.Windows.Forms.Button()
        Me._Command_2 = New System.Windows.Forms.Button()
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me.GauGe = New System.Windows.Forms.ProgressBar()
        Me.FVattu.SuspendLayout()
        Me._Frame_5.SuspendLayout()
        Me._Frame_0.SuspendLayout()
        Me._Frame_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FVattu
        '
        Me.FVattu.BackColor = System.Drawing.Color.Transparent
        Me.FVattu.Controls.Add(Me._txtShTk_10)
        Me.FVattu.Controls.Add(Me._cmdtk_10)
        Me.FVattu.Controls.Add(Me._txtShTk_4)
        Me.FVattu.Controls.Add(Me._ChkDu_3)
        Me.FVattu.Controls.Add(Me._CboLoai_0)
        Me.FVattu.Controls.Add(Me._ChkDu_2)
        Me.FVattu.Controls.Add(Me._OptBC_12)
        Me.FVattu.Controls.Add(Me._OptBC_13)
        Me.FVattu.Controls.Add(Me._OptBC_14)
        Me.FVattu.Controls.Add(Me._OptBC_15)
        Me.FVattu.Controls.Add(Me._OptBC_16)
        Me.FVattu.Controls.Add(Me._ChkDu_4)
        Me.FVattu.Controls.Add(Me._CboLoai_1)
        Me.FVattu.Controls.Add(Me._ChkDu_7)
        Me.FVattu.Controls.Add(Me._OptBC_44)
        Me.FVattu.Controls.Add(Me._txtShTk_11)
        Me.FVattu.Controls.Add(Me._OptBC_46)
        Me.FVattu.Controls.Add(Me._OptBC_47)
        Me.FVattu.Controls.Add(Me._OptBC_48)
        Me.FVattu.Controls.Add(Me._OptBC_52)
        Me.FVattu.Controls.Add(Me._OptBC_55)
        Me.FVattu.Controls.Add(Me._OptBC_60)
        Me.FVattu.Controls.Add(Me._txtCT_1)
        Me.FVattu.Controls.Add(Me._txtShVT_0)
        Me.FVattu.Controls.Add(Me._OptBC_64)
        Me.FVattu.Controls.Add(Me._OptBC_65)
        Me.FVattu.Controls.Add(Me._OptBC_43)
        Me.FVattu.Controls.Add(Me._OptBC_74)
        Me.FVattu.Controls.Add(Me._OptBC_77)
        Me.FVattu.Controls.Add(Me._Frame_5)
        Me.FVattu.Controls.Add(Me.CmdAdd)
        Me.FVattu.Controls.Add(Me._cmdtk_11)
        Me.FVattu.Controls.Add(Me._cmdvt_0)
        Me.FVattu.Controls.Add(Me._cmdCT_1)
        Me.FVattu.Controls.Add(Me._cmdtk_4)
        Me.FVattu.Controls.Add(Me._LbTenVT_0)
        Me.FVattu.Controls.Add(Me._LbTenTk_4)
        Me.FVattu.Controls.Add(Me._LbTenTk_10)
        Me.FVattu.Controls.Add(Me._LbTenTk_11)
        Me.FVattu.Controls.Add(Me._LbCT_1)
        Me.FVattu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FVattu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FVattu.Location = New System.Drawing.Point(8, 0)
        Me.FVattu.Name = "FVattu"
        Me.FVattu.Size = New System.Drawing.Size(633, 354)
        Me.FVattu.TabIndex = 55
        Me.FVattu.TabStop = False
        '
        '_txtShTk_10
        '
        Me._txtShTk_10.AcceptsReturn = True
        Me._txtShTk_10.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_10.Location = New System.Drawing.Point(344, 72)
        Me._txtShTk_10.MaxLength = 12
        Me._txtShTk_10.Name = "_txtShTk_10"
        Me._txtShTk_10.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_10.TabIndex = 9
        Me._txtShTk_10.Tag = "0"
        '
        '_cmdtk_10
        '
        Me._cmdtk_10.Image = CType(resources.GetObject("_cmdtk_10.Image"), System.Drawing.Image)
        Me._cmdtk_10.Location = New System.Drawing.Point(440, 71)
        Me._cmdtk_10.Name = "_cmdtk_10"
        Me._cmdtk_10.Size = New System.Drawing.Size(23, 22)
        Me._cmdtk_10.TabIndex = 10
        '
        '_txtShTk_4
        '
        Me._txtShTk_4.AcceptsReturn = True
        Me._txtShTk_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_4.Location = New System.Drawing.Point(344, 136)
        Me._txtShTk_4.MaxLength = 12
        Me._txtShTk_4.Name = "_txtShTk_4"
        Me._txtShTk_4.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_4.TabIndex = 20
        Me._txtShTk_4.Tag = "0"
        '
        '_ChkDu_3
        '
        Me._ChkDu_3.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_3.Location = New System.Drawing.Point(240, 168)
        Me._ChkDu_3.Name = "_ChkDu_3"
        Me._ChkDu_3.Size = New System.Drawing.Size(78, 17)
        Me._ChkDu_3.TabIndex = 23
        Me._ChkDu_3.Tag = "Class"
        Me._ChkDu_3.Text = "Loại vật tư"
        Me._ChkDu_3.UseVisualStyleBackColor = False
        '
        '_CboLoai_0
        '
        Me._CboLoai_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboLoai_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboLoai_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboLoai_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboLoai_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboLoai_0.Location = New System.Drawing.Point(344, 168)
        Me._CboLoai_0.Name = "_CboLoai_0"
        Me._CboLoai_0.Size = New System.Drawing.Size(225, 21)
        Me._CboLoai_0.TabIndex = 24
        '
        '_ChkDu_2
        '
        Me._ChkDu_2.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_2.Location = New System.Drawing.Point(240, 136)
        Me._ChkDu_2.Name = "_ChkDu_2"
        Me._ChkDu_2.Size = New System.Drawing.Size(78, 17)
        Me._ChkDu_2.TabIndex = 19
        Me._ChkDu_2.Tag = "Account"
        Me._ChkDu_2.Text = "Tài khoản"
        Me._ChkDu_2.UseVisualStyleBackColor = False
        '
        '_OptBC_12
        '
        Me._OptBC_12.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_12.Checked = True
        Me._OptBC_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_12.Location = New System.Drawing.Point(13, 48)
        Me._OptBC_12.Name = "_OptBC_12"
        Me._OptBC_12.Size = New System.Drawing.Size(129, 17)
        Me._OptBC_12.TabIndex = 3
        Me._OptBC_12.TabStop = True
        Me._OptBC_12.Tag = "Inventory detail report"
        Me._OptBC_12.Text = "Sổ chi tiết"
        Me._OptBC_12.UseVisualStyleBackColor = False
        '
        '_OptBC_13
        '
        Me._OptBC_13.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_13.Location = New System.Drawing.Point(13, 72)
        Me._OptBC_13.Name = "_OptBC_13"
        Me._OptBC_13.Size = New System.Drawing.Size(217, 17)
        Me._OptBC_13.TabIndex = 7
        Me._OptBC_13.TabStop = True
        Me._OptBC_13.Tag = "Print all Inventory detail report"
        Me._OptBC_13.Text = "In toàn bộ sổ chi tiết vật tư hoặc thẻ kho"
        Me._OptBC_13.UseVisualStyleBackColor = False
        '
        '_OptBC_14
        '
        Me._OptBC_14.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_14.Location = New System.Drawing.Point(13, 120)
        Me._OptBC_14.Name = "_OptBC_14"
        Me._OptBC_14.Size = New System.Drawing.Size(217, 17)
        Me._OptBC_14.TabIndex = 13
        Me._OptBC_14.TabStop = True
        Me._OptBC_14.Tag = "Fluctuation of inventories"
        Me._OptBC_14.Text = "Bảng kê luỹ kế nhập xuất tồn"
        Me._OptBC_14.UseVisualStyleBackColor = False
        '
        '_OptBC_15
        '
        Me._OptBC_15.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_15.Location = New System.Drawing.Point(240, 312)
        Me._OptBC_15.Name = "_OptBC_15"
        Me._OptBC_15.Size = New System.Drawing.Size(217, 17)
        Me._OptBC_15.TabIndex = 22
        Me._OptBC_15.TabStop = True
        Me._OptBC_15.Tag = "Import table by resource"
        Me._OptBC_15.Text = "Báo cáo nhập theo kênh phân phối"
        Me._OptBC_15.UseVisualStyleBackColor = False
        Me._OptBC_15.Visible = False
        '
        '_OptBC_16
        '
        Me._OptBC_16.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_16.Location = New System.Drawing.Point(240, 336)
        Me._OptBC_16.Name = "_OptBC_16"
        Me._OptBC_16.Size = New System.Drawing.Size(217, 17)
        Me._OptBC_16.TabIndex = 25
        Me._OptBC_16.TabStop = True
        Me._OptBC_16.Tag = "Export table by customer"
        Me._OptBC_16.Text = "Báo cáo xuất theo kênh phân phối"
        Me._OptBC_16.UseVisualStyleBackColor = False
        Me._OptBC_16.Visible = False
        '
        '_ChkDu_4
        '
        Me._ChkDu_4.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_4.Location = New System.Drawing.Point(240, 108)
        Me._ChkDu_4.Name = "_ChkDu_4"
        Me._ChkDu_4.Size = New System.Drawing.Size(78, 17)
        Me._ChkDu_4.TabIndex = 16
        Me._ChkDu_4.Tag = "Resource"
        Me._ChkDu_4.Text = "Nguồn"
        Me._ChkDu_4.UseVisualStyleBackColor = False
        '
        '_CboLoai_1
        '
        Me._CboLoai_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboLoai_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboLoai_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboLoai_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboLoai_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboLoai_1.Location = New System.Drawing.Point(344, 104)
        Me._CboLoai_1.Name = "_CboLoai_1"
        Me._CboLoai_1.Size = New System.Drawing.Size(225, 21)
        Me._CboLoai_1.TabIndex = 17
        '
        '_ChkDu_7
        '
        Me._ChkDu_7.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_7.Location = New System.Drawing.Point(240, 72)
        Me._ChkDu_7.Name = "_ChkDu_7"
        Me._ChkDu_7.Size = New System.Drawing.Size(86, 17)
        Me._ChkDu_7.TabIndex = 8
        Me._ChkDu_7.Tag = "by Ref. Acc."
        Me._ChkDu_7.Text = "Đối ứng"
        Me._ChkDu_7.UseVisualStyleBackColor = False
        '
        '_OptBC_44
        '
        Me._OptBC_44.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_44.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_44.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_44.Location = New System.Drawing.Point(240, 360)
        Me._OptBC_44.Name = "_OptBC_44"
        Me._OptBC_44.Size = New System.Drawing.Size(217, 17)
        Me._OptBC_44.TabIndex = 26
        Me._OptBC_44.TabStop = True
        Me._OptBC_44.Tag = "Export table by account "
        Me._OptBC_44.Text = "Bảng kê xuất theo tài khoản "
        Me._OptBC_44.UseVisualStyleBackColor = False
        Me._OptBC_44.Visible = False
        '
        '_txtShTk_11
        '
        Me._txtShTk_11.AcceptsReturn = True
        Me._txtShTk_11.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_11.Location = New System.Drawing.Point(240, 235)
        Me._txtShTk_11.MaxLength = 12
        Me._txtShTk_11.Name = "_txtShTk_11"
        Me._txtShTk_11.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_11.TabIndex = 27
        Me._txtShTk_11.Tag = "0"
        Me._txtShTk_11.Visible = False
        '
        '_OptBC_46
        '
        Me._OptBC_46.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_46.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_46.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_46.Location = New System.Drawing.Point(240, 288)
        Me._OptBC_46.Name = "_OptBC_46"
        Me._OptBC_46.Size = New System.Drawing.Size(217, 17)
        Me._OptBC_46.TabIndex = 18
        Me._OptBC_46.TabStop = True
        Me._OptBC_46.Tag = "Fluctuation following resource"
        Me._OptBC_46.Text = "Bảng kê luỹ kế nhập xuất tồn theo nguồn"
        Me._OptBC_46.UseVisualStyleBackColor = False
        Me._OptBC_46.Visible = False
        '
        '_OptBC_47
        '
        Me._OptBC_47.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_47.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_47.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_47.Location = New System.Drawing.Point(16, 360)
        Me._OptBC_47.Name = "_OptBC_47"
        Me._OptBC_47.Size = New System.Drawing.Size(217, 17)
        Me._OptBC_47.TabIndex = 35
        Me._OptBC_47.TabStop = True
        Me._OptBC_47.Tag = "Under minimum quantity"
        Me._OptBC_47.Text = "Bảng kê tồn kho dưới mức tối thiểu"
        Me._OptBC_47.UseVisualStyleBackColor = False
        Me._OptBC_47.Visible = False
        '
        '_OptBC_48
        '
        Me._OptBC_48.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_48.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_48.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_48.Location = New System.Drawing.Point(13, 336)
        Me._OptBC_48.Name = "_OptBC_48"
        Me._OptBC_48.Size = New System.Drawing.Size(217, 17)
        Me._OptBC_48.TabIndex = 34
        Me._OptBC_48.TabStop = True
        Me._OptBC_48.Tag = "Over maximum quantity table "
        Me._OptBC_48.Text = "Bảng kê tồn kho trên mức tối đa"
        Me._OptBC_48.UseVisualStyleBackColor = False
        Me._OptBC_48.Visible = False
        '
        '_OptBC_52
        '
        Me._OptBC_52.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_52.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_52.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_52.Location = New System.Drawing.Point(13, 96)
        Me._OptBC_52.Name = "_OptBC_52"
        Me._OptBC_52.Size = New System.Drawing.Size(217, 17)
        Me._OptBC_52.TabIndex = 11
        Me._OptBC_52.TabStop = True
        Me._OptBC_52.Tag = "InternaI flows Report"
        Me._OptBC_52.Text = "Bảng kê lưu chuyển nội bộ"
        Me._OptBC_52.UseVisualStyleBackColor = False
        '
        '_OptBC_55
        '
        Me._OptBC_55.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_55.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_55.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_55.Location = New System.Drawing.Point(13, 288)
        Me._OptBC_55.Name = "_OptBC_55"
        Me._OptBC_55.Size = New System.Drawing.Size(217, 17)
        Me._OptBC_55.TabIndex = 32
        Me._OptBC_55.TabStop = True
        Me._OptBC_55.Tag = "Stock table "
        Me._OptBC_55.Text = "Bảng tổng hợp tồn kho"
        Me._OptBC_55.UseVisualStyleBackColor = False
        Me._OptBC_55.Visible = False
        '
        '_OptBC_60
        '
        Me._OptBC_60.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_60.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_60.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_60.Location = New System.Drawing.Point(240, 384)
        Me._OptBC_60.Name = "_OptBC_60"
        Me._OptBC_60.Size = New System.Drawing.Size(217, 17)
        Me._OptBC_60.TabIndex = 29
        Me._OptBC_60.TabStop = True
        Me._OptBC_60.Tag = "Export table by product"
        Me._OptBC_60.Text = "Bảng kê xuất theo sản phẩm"
        Me._OptBC_60.UseVisualStyleBackColor = False
        Me._OptBC_60.Visible = False
        '
        '_txtCT_1
        '
        Me._txtCT_1.AcceptsReturn = True
        Me._txtCT_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtCT_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtCT_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtCT_1.Location = New System.Drawing.Point(240, 264)
        Me._txtCT_1.MaxLength = 12
        Me._txtCT_1.Name = "_txtCT_1"
        Me._txtCT_1.Size = New System.Drawing.Size(89, 20)
        Me._txtCT_1.TabIndex = 30
        Me._txtCT_1.Tag = "0"
        Me._txtCT_1.Visible = False
        '
        '_txtShVT_0
        '
        Me._txtShVT_0.AcceptsReturn = True
        Me._txtShVT_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtShVT_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShVT_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShVT_0.Location = New System.Drawing.Point(240, 48)
        Me._txtShVT_0.MaxLength = 20
        Me._txtShVT_0.Name = "_txtShVT_0"
        Me._txtShVT_0.Size = New System.Drawing.Size(89, 20)
        Me._txtShVT_0.TabIndex = 5
        Me._txtShVT_0.Tag = "0"
        '
        '_OptBC_64
        '
        Me._OptBC_64.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_64.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_64.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_64.Location = New System.Drawing.Point(152, 48)
        Me._OptBC_64.Name = "_OptBC_64"
        Me._OptBC_64.Size = New System.Drawing.Size(81, 17)
        Me._OptBC_64.TabIndex = 4
        Me._OptBC_64.TabStop = True
        Me._OptBC_64.Tag = "Form 2"
        Me._OptBC_64.Text = "Thẻ kho"
        Me._OptBC_64.UseVisualStyleBackColor = False
        '
        '_OptBC_65
        '
        Me._OptBC_65.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_65.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_65.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_65.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_65.Location = New System.Drawing.Point(13, 144)
        Me._OptBC_65.Name = "_OptBC_65"
        Me._OptBC_65.Size = New System.Drawing.Size(217, 17)
        Me._OptBC_65.TabIndex = 15
        Me._OptBC_65.TabStop = True
        Me._OptBC_65.Tag = "Material and Product Summary Report"
        Me._OptBC_65.Text = "Bảng tổng hợp chi tiết vật liệu, sp, hh"
        Me._OptBC_65.UseVisualStyleBackColor = False
        '
        '_OptBC_43
        '
        Me._OptBC_43.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_43.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_43.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_43.Location = New System.Drawing.Point(13, 168)
        Me._OptBC_43.Name = "_OptBC_43"
        Me._OptBC_43.Size = New System.Drawing.Size(233, 17)
        Me._OptBC_43.TabIndex = 12
        Me._OptBC_43.TabStop = True
        Me._OptBC_43.Tag = "Inventory"
        Me._OptBC_43.Text = "Báo cáo kiểm kê"
        Me._OptBC_43.UseVisualStyleBackColor = False
        '
        '_OptBC_74
        '
        Me._OptBC_74.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_74.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_74.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_74.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_74.Location = New System.Drawing.Point(13, 264)
        Me._OptBC_74.Name = "_OptBC_74"
        Me._OptBC_74.Size = New System.Drawing.Size(233, 17)
        Me._OptBC_74.TabIndex = 14
        Me._OptBC_74.TabStop = True
        Me._OptBC_74.Tag = "Inventory"
        Me._OptBC_74.Text = "Bảng kê sản lượng thành phẩm hoàn thành"
        Me._OptBC_74.UseVisualStyleBackColor = False
        Me._OptBC_74.Visible = False
        '
        '_OptBC_77
        '
        Me._OptBC_77.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_77.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_77.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_77.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_77.Location = New System.Drawing.Point(13, 312)
        Me._OptBC_77.Name = "_OptBC_77"
        Me._OptBC_77.Size = New System.Drawing.Size(217, 17)
        Me._OptBC_77.TabIndex = 33
        Me._OptBC_77.TabStop = True
        Me._OptBC_77.Tag = "Export table by product"
        Me._OptBC_77.Text = "Bảng kê nhập xuất thẳng"
        Me._OptBC_77.UseVisualStyleBackColor = False
        Me._OptBC_77.Visible = False
        '
        '_Frame_5
        '
        Me._Frame_5.BackColor = System.Drawing.Color.Transparent
        Me._Frame_5.Controls.Add(Me._OptKho_1)
        Me._Frame_5.Controls.Add(Me._OptKho_0)
        Me._Frame_5.Controls.Add(Me._CboKho_0)
        Me._Frame_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_5.Location = New System.Drawing.Point(8, 8)
        Me._Frame_5.Name = "_Frame_5"
        Me._Frame_5.Size = New System.Drawing.Size(361, 33)
        Me._Frame_5.TabIndex = 56
        Me._Frame_5.TabStop = False
        '
        '_OptKho_1
        '
        Me._OptKho_1.BackColor = System.Drawing.Color.Transparent
        Me._OptKho_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptKho_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptKho_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptKho_1.Location = New System.Drawing.Point(226, 11)
        Me._OptKho_1.Name = "_OptKho_1"
        Me._OptKho_1.Size = New System.Drawing.Size(129, 17)
        Me._OptKho_1.TabIndex = 2
        Me._OptKho_1.TabStop = True
        Me._OptKho_1.Tag = "All store"
        Me._OptKho_1.Text = "Tổng hợp các kho"
        Me._OptKho_1.UseVisualStyleBackColor = False
        Me._OptKho_1.Visible = False
        '
        '_OptKho_0
        '
        Me._OptKho_0.BackColor = System.Drawing.Color.Transparent
        Me._OptKho_0.Checked = True
        Me._OptKho_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptKho_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptKho_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptKho_0.Location = New System.Drawing.Point(8, 11)
        Me._OptKho_0.Name = "_OptKho_0"
        Me._OptKho_0.Size = New System.Drawing.Size(49, 17)
        Me._OptKho_0.TabIndex = 0
        Me._OptKho_0.TabStop = True
        Me._OptKho_0.Tag = "Store"
        Me._OptKho_0.Text = "Kho"
        Me._OptKho_0.UseVisualStyleBackColor = False
        '
        '_CboKho_0
        '
        Me._CboKho_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboKho_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboKho_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboKho_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboKho_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboKho_0.Location = New System.Drawing.Point(63, 10)
        Me._CboKho_0.Name = "_CboKho_0"
        Me._CboKho_0.Size = New System.Drawing.Size(145, 21)
        Me._CboKho_0.TabIndex = 1
        '
        'CmdAdd
        '
        Me.CmdAdd.Location = New System.Drawing.Point(344, 200)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(121, 25)
        Me.CmdAdd.TabIndex = 36
        '
        '_cmdtk_11
        '
        Me._cmdtk_11.Image = CType(resources.GetObject("_cmdtk_11.Image"), System.Drawing.Image)
        Me._cmdtk_11.Location = New System.Drawing.Point(336, 235)
        Me._cmdtk_11.Name = "_cmdtk_11"
        Me._cmdtk_11.Size = New System.Drawing.Size(23, 22)
        Me._cmdtk_11.TabIndex = 28
        Me._cmdtk_11.Visible = False
        '
        '_cmdvt_0
        '
        Me._cmdvt_0.Image = CType(resources.GetObject("_cmdvt_0.Image"), System.Drawing.Image)
        Me._cmdvt_0.Location = New System.Drawing.Point(336, 47)
        Me._cmdvt_0.Name = "_cmdvt_0"
        Me._cmdvt_0.Size = New System.Drawing.Size(23, 22)
        Me._cmdvt_0.TabIndex = 6
        '
        '_cmdCT_1
        '
        Me._cmdCT_1.Image = CType(resources.GetObject("_cmdCT_1.Image"), System.Drawing.Image)
        Me._cmdCT_1.Location = New System.Drawing.Point(336, 264)
        Me._cmdCT_1.Name = "_cmdCT_1"
        Me._cmdCT_1.Size = New System.Drawing.Size(23, 22)
        Me._cmdCT_1.TabIndex = 31
        Me._cmdCT_1.Visible = False
        '
        '_cmdtk_4
        '
        Me._cmdtk_4.Image = CType(resources.GetObject("_cmdtk_4.Image"), System.Drawing.Image)
        Me._cmdtk_4.Location = New System.Drawing.Point(440, 135)
        Me._cmdtk_4.Name = "_cmdtk_4"
        Me._cmdtk_4.Size = New System.Drawing.Size(23, 22)
        Me._cmdtk_4.TabIndex = 21
        '
        '_LbTenVT_0
        '
        Me._LbTenVT_0.BackColor = System.Drawing.Color.Transparent
        Me._LbTenVT_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenVT_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenVT_0.ForeColor = System.Drawing.Color.Blue
        Me._LbTenVT_0.Location = New System.Drawing.Point(376, 49)
        Me._LbTenVT_0.Name = "_LbTenVT_0"
        Me._LbTenVT_0.Size = New System.Drawing.Size(249, 17)
        Me._LbTenVT_0.TabIndex = 61
        Me._LbTenVT_0.Tag = "1"
        '
        '_LbTenTk_4
        '
        Me._LbTenTk_4.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_4.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_4.Location = New System.Drawing.Point(472, 137)
        Me._LbTenTk_4.Name = "_LbTenTk_4"
        Me._LbTenTk_4.Size = New System.Drawing.Size(153, 17)
        Me._LbTenTk_4.TabIndex = 60
        Me._LbTenTk_4.Tag = "1"
        '
        '_LbTenTk_10
        '
        Me._LbTenTk_10.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_10.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_10.Location = New System.Drawing.Point(472, 73)
        Me._LbTenTk_10.Name = "_LbTenTk_10"
        Me._LbTenTk_10.Size = New System.Drawing.Size(153, 17)
        Me._LbTenTk_10.TabIndex = 59
        Me._LbTenTk_10.Tag = "1"
        '
        '_LbTenTk_11
        '
        Me._LbTenTk_11.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_11.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_11.Location = New System.Drawing.Point(376, 237)
        Me._LbTenTk_11.Name = "_LbTenTk_11"
        Me._LbTenTk_11.Size = New System.Drawing.Size(249, 17)
        Me._LbTenTk_11.TabIndex = 58
        Me._LbTenTk_11.Tag = "1"
        '
        '_LbCT_1
        '
        Me._LbCT_1.BackColor = System.Drawing.Color.Transparent
        Me._LbCT_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbCT_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbCT_1.ForeColor = System.Drawing.Color.Blue
        Me._LbCT_1.Location = New System.Drawing.Point(376, 268)
        Me._LbCT_1.Name = "_LbCT_1"
        Me._LbCT_1.Size = New System.Drawing.Size(249, 17)
        Me._LbCT_1.TabIndex = 57
        Me._LbCT_1.Tag = "1"
        '
        '_Frame_0
        '
        Me._Frame_0.BackColor = System.Drawing.Color.Transparent
        Me._Frame_0.Controls.Add(Me._CboThang_1)
        Me._Frame_0.Controls.Add(Me._CboThang_0)
        Me._Frame_0.Controls.Add(Me._Label_1)
        Me._Frame_0.Controls.Add(Me._Label_0)
        Me._Frame_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_0.Location = New System.Drawing.Point(648, 56)
        Me._Frame_0.Name = "_Frame_0"
        Me._Frame_0.Size = New System.Drawing.Size(81, 113)
        Me._Frame_0.TabIndex = 51
        Me._Frame_0.TabStop = False
        '
        '_CboThang_1
        '
        Me._CboThang_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_1.Location = New System.Drawing.Point(8, 80)
        Me._CboThang_1.Name = "_CboThang_1"
        Me._CboThang_1.Size = New System.Drawing.Size(65, 21)
        Me._CboThang_1.TabIndex = 40
        '
        '_CboThang_0
        '
        Me._CboThang_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_0.Location = New System.Drawing.Point(8, 32)
        Me._CboThang_0.Name = "_CboThang_0"
        Me._CboThang_0.Size = New System.Drawing.Size(65, 21)
        Me._CboThang_0.TabIndex = 39
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(5, 64)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(52, 17)
        Me._Label_1.TabIndex = 53
        Me._Label_1.Tag = "to"
        Me._Label_1.Text = "Đến tháng"
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(5, 16)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(52, 17)
        Me._Label_0.TabIndex = 52
        Me._Label_0.Tag = "FROM"
        Me._Label_0.Text = "Từ tháng"
        '
        '_OptTG_0
        '
        Me._OptTG_0.BackColor = System.Drawing.Color.Transparent
        Me._OptTG_0.Checked = True
        Me._OptTG_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptTG_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptTG_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptTG_0.Location = New System.Drawing.Point(648, 8)
        Me._OptTG_0.Name = "_OptTG_0"
        Me._OptTG_0.Size = New System.Drawing.Size(81, 17)
        Me._OptTG_0.TabIndex = 37
        Me._OptTG_0.TabStop = True
        Me._OptTG_0.Tag = "By month"
        Me._OptTG_0.Text = "Theo tháng"
        Me._OptTG_0.UseVisualStyleBackColor = False
        '
        '_OptTG_1
        '
        Me._OptTG_1.BackColor = System.Drawing.Color.Transparent
        Me._OptTG_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptTG_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptTG_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptTG_1.Location = New System.Drawing.Point(648, 32)
        Me._OptTG_1.Name = "_OptTG_1"
        Me._OptTG_1.Size = New System.Drawing.Size(81, 17)
        Me._OptTG_1.TabIndex = 38
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
        Me._Frame_1.Controls.Add(Me._Label_4)
        Me._Frame_1.Controls.Add(Me._Label_5)
        Me._Frame_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_1.Location = New System.Drawing.Point(648, 56)
        Me._Frame_1.Name = "_Frame_1"
        Me._Frame_1.Size = New System.Drawing.Size(73, 113)
        Me._Frame_1.TabIndex = 48
        Me._Frame_1.TabStop = False
        Me._Frame_1.Visible = False
        '
        '_MedNgay_1
        '
        Me._MedNgay_1.AllowPromptAsInput = False
        Me._MedNgay_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_1.Location = New System.Drawing.Point(8, 32)
        Me._MedNgay_1.Mask = "00/00/0000"
        Me._MedNgay_1.Name = "_MedNgay_1"
        Me._MedNgay_1.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_1.TabIndex = 41
        '
        '_MedNgay_2
        '
        Me._MedNgay_2.AllowPromptAsInput = False
        Me._MedNgay_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_2.Location = New System.Drawing.Point(8, 80)
        Me._MedNgay_2.Name = "_MedNgay_2"
        Me._MedNgay_2.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_2.TabIndex = 42
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.Transparent
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_4.Location = New System.Drawing.Point(8, 16)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(57, 17)
        Me._Label_4.TabIndex = 50
        Me._Label_4.Tag = "FROM"
        Me._Label_4.Text = "Từ ngày"
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.Transparent
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_5.Location = New System.Drawing.Point(8, 64)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(57, 17)
        Me._Label_5.TabIndex = 49
        Me._Label_5.Tag = "to"
        Me._Label_5.Text = "Đến ngày"
        '
        '_ChkDu_16
        '
        Me._ChkDu_16.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_16.Location = New System.Drawing.Point(648, 176)
        Me._ChkDu_16.Name = "_ChkDu_16"
        Me._ChkDu_16.Size = New System.Drawing.Size(89, 17)
        Me._ChkDu_16.TabIndex = 43
        Me._ChkDu_16.Tag = "Resource"
        Me._ChkDu_16.Text = "&Hiển thị lưới"
        Me._ChkDu_16.UseVisualStyleBackColor = False
        '
        '_Command_3
        '
        Me._Command_3.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Export_Excel
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(648, 320)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(81, 25)
        Me._Command_3.TabIndex = 47
        Me._Command_3.Text = "Xuất &Excel"
        '
        '_Command_2
        '
        Me._Command_2.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(648, 288)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(81, 25)
        Me._Command_2.TabIndex = 46
        Me._Command_2.Text = "Trở &về"
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Print
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(648, 256)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(81, 25)
        Me._Command_1.TabIndex = 45
        Me._Command_1.Text = "&In"
        '
        '_Command_0
        '
        Me._Command_0.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Preview
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(648, 224)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(81, 25)
        Me._Command_0.TabIndex = 44
        Me._Command_0.Text = "&Xem"
        '
        'GauGe
        '
        Me.GauGe.Location = New System.Drawing.Point(648, 200)
        Me.GauGe.Name = "GauGe"
        Me.GauGe.Size = New System.Drawing.Size(81, 17)
        Me.GauGe.TabIndex = 54
        '
        'FrmSovattuhanghoabh
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(737, 362)
        Me.Controls.Add(Me.FVattu)
        Me.Controls.Add(Me._Frame_0)
        Me.Controls.Add(Me._OptTG_0)
        Me.Controls.Add(Me._OptTG_1)
        Me.Controls.Add(Me._Frame_1)
        Me.Controls.Add(Me._ChkDu_16)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me.GauGe)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSovattuhanghoabh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sổ vật tư - hàng hoá"
        Me.FVattu.ResumeLayout(False)
        Me.FVattu.PerformLayout()
        Me._Frame_5.ResumeLayout(False)
        Me._Frame_0.ResumeLayout(False)
        Me._Frame_1.ResumeLayout(False)
        Me._Frame_1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
	Sub InitializetxtShVT()
		Me.txtShVT(0) = _txtShVT_0
	End Sub
	Sub InitializetxtShTk()
		Me.txtShTk(10) = _txtShTk_10
		Me.txtShTk(4) = _txtShTk_4
		Me.txtShTk(11) = _txtShTk_11
	End Sub
	Sub InitializetxtCT()
		Me.txtCT(1) = _txtCT_1
	End Sub
	Sub Initializecmdvt()
		Me.cmdvt(0) = _cmdvt_0
	End Sub
	Sub Initializecmdtk()
		Me.cmdtk(10) = _cmdtk_10
		Me.cmdtk(11) = _cmdtk_11
		Me.cmdtk(4) = _cmdtk_4
	End Sub
	Sub InitializecmdCT()
		Me.cmdCT(1) = _cmdCT_1
	End Sub
	Sub InitializeOptTG()
		Me.OptTG(0) = _OptTG_0
		Me.OptTG(1) = _OptTG_1
	End Sub
	Sub InitializeOptKho()
		Me.OptKho(1) = _OptKho_1
		Me.OptKho(0) = _OptKho_0
	End Sub
	Sub InitializeOptBC()
		Me.OptBC(12) = _OptBC_12
		Me.OptBC(13) = _OptBC_13
		Me.OptBC(14) = _OptBC_14
		Me.OptBC(15) = _OptBC_15
		Me.OptBC(16) = _OptBC_16
		Me.OptBC(44) = _OptBC_44
		Me.OptBC(46) = _OptBC_46
		Me.OptBC(47) = _OptBC_47
		Me.OptBC(48) = _OptBC_48
		Me.OptBC(52) = _OptBC_52
		Me.OptBC(55) = _OptBC_55
		Me.OptBC(60) = _OptBC_60
		Me.OptBC(64) = _OptBC_64
		Me.OptBC(65) = _OptBC_65
		Me.OptBC(43) = _OptBC_43
		Me.OptBC(74) = _OptBC_74
		Me.OptBC(77) = _OptBC_77
	End Sub
	Sub InitializeMedNgay()
		Me.MedNgay(1) = _MedNgay_1
		Me.MedNgay(2) = _MedNgay_2
	End Sub
	Sub InitializeLbTenVT()
		Me.LbTenVT(0) = _LbTenVT_0
	End Sub
	Sub InitializeLbTenTk()
		Me.LbTenTk(4) = _LbTenTk_4
		Me.LbTenTk(10) = _LbTenTk_10
		Me.LbTenTk(11) = _LbTenTk_11
	End Sub
	Sub InitializeLbCT()
		Me.LbCT(1) = _LbCT_1
	End Sub
	Sub InitializeLabel()
		Me.Label(1) = _Label_1
		Me.Label(0) = _Label_0
		Me.Label(4) = _Label_4
		Me.Label(5) = _Label_5
	End Sub
	Sub InitializeFrame()
		Me.Frame(5) = _Frame_5
		Me.Frame(0) = _Frame_0
		Me.Frame(1) = _Frame_1
	End Sub
	Sub InitializeCommand()
		Me.Command(3) = _Command_3
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
	Sub InitializeChkDu()
		Me.ChkDu(3) = _ChkDu_3
		Me.ChkDu(2) = _ChkDu_2
		Me.ChkDu(4) = _ChkDu_4
		Me.ChkDu(7) = _ChkDu_7
		Me.ChkDu(16) = _ChkDu_16
	End Sub
	Sub InitializeCboThang()
		Me.CboThang(1) = _CboThang_1
		Me.CboThang(0) = _CboThang_0
	End Sub
	Sub InitializeCboLoai()
		Me.CboLoai(0) = _CboLoai_0
		Me.CboLoai(1) = _CboLoai_1
	End Sub
	Sub InitializeCboKho()
		Me.CboKho(0) = _CboKho_0
	End Sub
#End Region 
End Class
