<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSogiathanh
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
        isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		InitializetxtShTk()
		InitializetxtCT()
		Initializecmdtk()
		InitializecmdCT()
		InitializeOptTG()
		InitializeOptKho()
		InitializeOptBC()
		InitializeMedNgay()
		InitializeLbTenTk()
		InitializeLbCT()
		InitializeLabel()
		InitializeFrame()
		InitializeCommand()
		InitializeChkDu()
		InitializeCboVV()
		InitializeCboThang()
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
	Private WithEvents _OptTG_1 As System.Windows.Forms.RadioButton
	Private WithEvents _OptTG_0 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_1 As System.Windows.Forms.RadioButton
	Public WithEvents CboSohieu As ComboBoxEx.ComboBoxExt
	Private WithEvents _CboKho_1 As ComboBoxEx.ComboBoxExt
	Private WithEvents _ChkDu_9 As System.Windows.Forms.CheckBox
	Private WithEvents _ChkDu_12 As System.Windows.Forms.CheckBox
	Private WithEvents _txtShTk_9 As System.Windows.Forms.TextBox
	Private WithEvents _ChkDu_13 As System.Windows.Forms.CheckBox
    Private WithEvents _cmdtk_9 As System.Windows.Forms.Button
    Private WithEvents _LbTenTk_9 As System.Windows.Forms.Label
    Private WithEvents _Frame_2 As System.Windows.Forms.GroupBox
    Private WithEvents _OptBC_0 As System.Windows.Forms.RadioButton
    Private WithEvents _OptKho_1 As System.Windows.Forms.RadioButton
    Private WithEvents _OptKho_0 As System.Windows.Forms.RadioButton
    Private WithEvents _CboKho_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Frame_5 As System.Windows.Forms.GroupBox
    Private WithEvents _CboVV_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _OptBC_10 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBC_11 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBC_33 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBC_50 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBC_51 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBC_59 As System.Windows.Forms.RadioButton
    Private WithEvents _txtCT_0 As System.Windows.Forms.TextBox
    Private WithEvents _OptBC_54 As System.Windows.Forms.RadioButton
    Private WithEvents _cmdCT_0 As System.Windows.Forms.Button
    Private WithEvents _LbCT_0 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents GauGe As System.Windows.Forms.ProgressBar
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _MedNgay_0 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _MedNgay_1 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Frame_1 As System.Windows.Forms.GroupBox
    Private WithEvents _CboThang_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboThang_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Frame_0 As System.Windows.Forms.GroupBox
    Public CboKho(1) As ComboBoxEx.ComboBoxExt
    Public CboThang(1) As ComboBoxEx.ComboBoxExt
    Public CboVV(0) As ComboBoxEx.ComboBoxExt
    Public ChkDu(13) As System.Windows.Forms.CheckBox
    Public Command(2) As System.Windows.Forms.Button
    Public Frame(5) As System.Windows.Forms.GroupBox
    Public Label(5) As System.Windows.Forms.Label
    Public LbCT(0) As System.Windows.Forms.Label
    Public LbTenTk(9) As System.Windows.Forms.Label
    Public MedNgay(1) As System.Windows.Forms.MaskedTextBox
    Public OptBC(59) As System.Windows.Forms.RadioButton
    Public OptKho(1) As System.Windows.Forms.RadioButton
    Public OptTG(1) As System.Windows.Forms.RadioButton
    Public cmdCT(0) As System.Windows.Forms.Button
    Public cmdtk(9) As System.Windows.Forms.Button
    Public txtCT(0) As System.Windows.Forms.TextBox
    Public txtShTk(9) As System.Windows.Forms.TextBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSogiathanh))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._OptTG_1 = New System.Windows.Forms.RadioButton
        Me._OptTG_0 = New System.Windows.Forms.RadioButton
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me._OptBC_2 = New System.Windows.Forms.RadioButton
        Me._OptBC_1 = New System.Windows.Forms.RadioButton
        Me.CboSohieu = New ComboBoxEx.ComboBoxExt
        Me._Frame_2 = New System.Windows.Forms.GroupBox
        Me._CboKho_1 = New ComboBoxEx.ComboBoxExt
        Me._ChkDu_9 = New System.Windows.Forms.CheckBox
        Me._ChkDu_12 = New System.Windows.Forms.CheckBox
        Me._txtShTk_9 = New System.Windows.Forms.TextBox
        Me._ChkDu_13 = New System.Windows.Forms.CheckBox
        Me._cmdtk_9 = New System.Windows.Forms.Button
        Me._LbTenTk_9 = New System.Windows.Forms.Label
        Me._OptBC_0 = New System.Windows.Forms.RadioButton
        Me._Frame_5 = New System.Windows.Forms.GroupBox
        Me._OptKho_1 = New System.Windows.Forms.RadioButton
        Me._OptKho_0 = New System.Windows.Forms.RadioButton
        Me._CboKho_0 = New ComboBoxEx.ComboBoxExt
        Me._CboVV_0 = New ComboBoxEx.ComboBoxExt
        Me._OptBC_10 = New System.Windows.Forms.RadioButton
        Me._OptBC_11 = New System.Windows.Forms.RadioButton
        Me._OptBC_33 = New System.Windows.Forms.RadioButton
        Me._OptBC_50 = New System.Windows.Forms.RadioButton
        Me._OptBC_51 = New System.Windows.Forms.RadioButton
        Me._OptBC_59 = New System.Windows.Forms.RadioButton
        Me._txtCT_0 = New System.Windows.Forms.TextBox
        Me._OptBC_54 = New System.Windows.Forms.RadioButton
        Me._cmdCT_0 = New System.Windows.Forms.Button
        Me._LbCT_0 = New System.Windows.Forms.Label
        Me.GauGe = New System.Windows.Forms.ProgressBar
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Frame_1 = New System.Windows.Forms.GroupBox
        Me._MedNgay_0 = New System.Windows.Forms.MaskedTextBox
        Me._MedNgay_1 = New System.Windows.Forms.MaskedTextBox
        Me._Label_5 = New System.Windows.Forms.Label
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Frame_0 = New System.Windows.Forms.GroupBox
        Me._CboThang_0 = New ComboBoxEx.ComboBoxExt
        Me._CboThang_1 = New ComboBoxEx.ComboBoxExt
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me.Frame1.SuspendLayout()
        Me._Frame_2.SuspendLayout()
        Me._Frame_5.SuspendLayout()
        Me._Frame_1.SuspendLayout()
        Me._Frame_0.SuspendLayout()
        Me.SuspendLayout()
        '
        '_OptTG_1
        '
        Me._OptTG_1.BackColor = System.Drawing.Color.Transparent
        Me._OptTG_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptTG_1.Enabled = False
        Me._OptTG_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptTG_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptTG_1.Location = New System.Drawing.Point(95, 407)
        Me._OptTG_1.Name = "_OptTG_1"
        Me._OptTG_1.Size = New System.Drawing.Size(81, 17)
        Me._OptTG_1.TabIndex = 21
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
        Me._OptTG_0.Location = New System.Drawing.Point(8, 407)
        Me._OptTG_0.Name = "_OptTG_0"
        Me._OptTG_0.Size = New System.Drawing.Size(81, 17)
        Me._OptTG_0.TabIndex = 20
        Me._OptTG_0.TabStop = True
        Me._OptTG_0.Tag = "By month"
        Me._OptTG_0.Text = "Theo tháng"
        Me._OptTG_0.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.Transparent
        Me.Frame1.Controls.Add(Me._OptBC_2)
        Me.Frame1.Controls.Add(Me._OptBC_1)
        Me.Frame1.Controls.Add(Me.CboSohieu)
        Me.Frame1.Controls.Add(Me._Frame_2)
        Me.Frame1.Controls.Add(Me._OptBC_0)
        Me.Frame1.Controls.Add(Me._Frame_5)
        Me.Frame1.Controls.Add(Me._CboVV_0)
        Me.Frame1.Controls.Add(Me._OptBC_10)
        Me.Frame1.Controls.Add(Me._OptBC_11)
        Me.Frame1.Controls.Add(Me._OptBC_33)
        Me.Frame1.Controls.Add(Me._OptBC_50)
        Me.Frame1.Controls.Add(Me._OptBC_51)
        Me.Frame1.Controls.Add(Me._OptBC_59)
        Me.Frame1.Controls.Add(Me._txtCT_0)
        Me.Frame1.Controls.Add(Me._OptBC_54)
        Me.Frame1.Controls.Add(Me._cmdCT_0)
        Me.Frame1.Controls.Add(Me._LbCT_0)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(489, 390)
        Me.Frame1.TabIndex = 30
        Me.Frame1.TabStop = False
        '
        '_OptBC_2
        '
        Me._OptBC_2.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_2.Location = New System.Drawing.Point(8, 151)
        Me._OptBC_2.Name = "_OptBC_2"
        Me._OptBC_2.Size = New System.Drawing.Size(249, 17)
        Me._OptBC_2.TabIndex = 43
        Me._OptBC_2.TabStop = True
        Me._OptBC_2.Tag = "Cost and price of production"
        Me._OptBC_2.Text = "Chi phí và giá thành sản xuất"
        Me._OptBC_2.UseVisualStyleBackColor = False
        '
        '_OptBC_1
        '
        Me._OptBC_1.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_1.Location = New System.Drawing.Point(8, 80)
        Me._OptBC_1.Name = "_OptBC_1"
        Me._OptBC_1.Size = New System.Drawing.Size(249, 17)
        Me._OptBC_1.TabIndex = 42
        Me._OptBC_1.TabStop = True
        Me._OptBC_1.Tag = "Cost and Profit of Unfinished Goods"
        Me._OptBC_1.Text = "Chi tiết giá thành sản phẩm dở dang"
        Me._OptBC_1.UseVisualStyleBackColor = False
        '
        'CboSohieu
        '
        Me.CboSohieu.BackColor = System.Drawing.Color.White
        Me.CboSohieu.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboSohieu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboSohieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSohieu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSohieu.Location = New System.Drawing.Point(296, 52)
        Me.CboSohieu.Name = "CboSohieu"
        Me.CboSohieu.Size = New System.Drawing.Size(105, 21)
        Me.CboSohieu.TabIndex = 41
        '
        '_Frame_2
        '
        Me._Frame_2.BackColor = System.Drawing.Color.Transparent
        Me._Frame_2.Controls.Add(Me._CboKho_1)
        Me._Frame_2.Controls.Add(Me._ChkDu_9)
        Me._Frame_2.Controls.Add(Me._ChkDu_12)
        Me._Frame_2.Controls.Add(Me._txtShTk_9)
        Me._Frame_2.Controls.Add(Me._ChkDu_13)
        Me._Frame_2.Controls.Add(Me._cmdtk_9)
        Me._Frame_2.Controls.Add(Me._LbTenTk_9)
        Me._Frame_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_2.Location = New System.Drawing.Point(8, 299)
        Me._Frame_2.Name = "_Frame_2"
        Me._Frame_2.Size = New System.Drawing.Size(473, 85)
        Me._Frame_2.TabIndex = 33
        Me._Frame_2.TabStop = False
        Me._Frame_2.Visible = False
        '
        '_CboKho_1
        '
        Me._CboKho_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboKho_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboKho_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboKho_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboKho_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboKho_1.Location = New System.Drawing.Point(160, 8)
        Me._CboKho_1.Name = "_CboKho_1"
        Me._CboKho_1.Size = New System.Drawing.Size(121, 21)
        Me._CboKho_1.TabIndex = 15
        '
        '_ChkDu_9
        '
        Me._ChkDu_9.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_9.Location = New System.Drawing.Point(16, 12)
        Me._ChkDu_9.Name = "_ChkDu_9"
        Me._ChkDu_9.Size = New System.Drawing.Size(81, 17)
        Me._ChkDu_9.TabIndex = 14
        Me._ChkDu_9.Tag = "Store"
        Me._ChkDu_9.Text = "Kho hàng"
        Me._ChkDu_9.UseVisualStyleBackColor = False
        '
        '_ChkDu_12
        '
        Me._ChkDu_12.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_12.Location = New System.Drawing.Point(16, 36)
        Me._ChkDu_12.Name = "_ChkDu_12"
        Me._ChkDu_12.Size = New System.Drawing.Size(89, 17)
        Me._ChkDu_12.TabIndex = 16
        Me._ChkDu_12.Tag = "Account"
        Me._ChkDu_12.Text = "Tài khoản"
        Me._ChkDu_12.UseVisualStyleBackColor = False
        '
        '_txtShTk_9
        '
        Me._txtShTk_9.AcceptsReturn = True
        Me._txtShTk_9.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_9.Location = New System.Drawing.Point(160, 38)
        Me._txtShTk_9.MaxLength = 12
        Me._txtShTk_9.Name = "_txtShTk_9"
        Me._txtShTk_9.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_9.TabIndex = 17
        Me._txtShTk_9.Tag = "0"
        '
        '_ChkDu_13
        '
        Me._ChkDu_13.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_13.Location = New System.Drawing.Point(16, 60)
        Me._ChkDu_13.Name = "_ChkDu_13"
        Me._ChkDu_13.Size = New System.Drawing.Size(233, 17)
        Me._ChkDu_13.TabIndex = 19
        Me._ChkDu_13.Tag = "Turnover - Cost after dicount"
        Me._ChkDu_13.Text = "Doanh thu - Giá vốn sau chiết khấu"
        Me._ChkDu_13.UseVisualStyleBackColor = False
        '
        '_cmdtk_9
        '
        Me._cmdtk_9.Image = CType(resources.GetObject("_cmdtk_9.Image"), System.Drawing.Image)
        Me._cmdtk_9.Location = New System.Drawing.Point(256, 38)
        Me._cmdtk_9.Name = "_cmdtk_9"
        Me._cmdtk_9.Size = New System.Drawing.Size(23, 22)
        Me._cmdtk_9.TabIndex = 18
        '
        '_LbTenTk_9
        '
        Me._LbTenTk_9.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_9.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_9.Location = New System.Drawing.Point(285, 41)
        Me._LbTenTk_9.Name = "_LbTenTk_9"
        Me._LbTenTk_9.Size = New System.Drawing.Size(185, 17)
        Me._LbTenTk_9.TabIndex = 34
        Me._LbTenTk_9.Tag = "1"
        '
        '_OptBC_0
        '
        Me._OptBC_0.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_0.Location = New System.Drawing.Point(8, 271)
        Me._OptBC_0.Name = "_OptBC_0"
        Me._OptBC_0.Size = New System.Drawing.Size(249, 17)
        Me._OptBC_0.TabIndex = 13
        Me._OptBC_0.TabStop = True
        Me._OptBC_0.Tag = "Production Norm Table"
        Me._OptBC_0.Text = "Doanh thu theo giá vốn"
        Me._OptBC_0.UseVisualStyleBackColor = False
        '
        '_Frame_5
        '
        Me._Frame_5.BackColor = System.Drawing.Color.Transparent
        Me._Frame_5.Controls.Add(Me._OptKho_1)
        Me._Frame_5.Controls.Add(Me._OptKho_0)
        Me._Frame_5.Controls.Add(Me._CboKho_0)
        Me._Frame_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_5.Location = New System.Drawing.Point(8, 8)
        Me._Frame_5.Name = "_Frame_5"
        Me._Frame_5.Size = New System.Drawing.Size(473, 41)
        Me._Frame_5.TabIndex = 32
        Me._Frame_5.TabStop = False
        '
        '_OptKho_1
        '
        Me._OptKho_1.BackColor = System.Drawing.Color.Transparent
        Me._OptKho_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptKho_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptKho_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptKho_1.Location = New System.Drawing.Point(288, 16)
        Me._OptKho_1.Name = "_OptKho_1"
        Me._OptKho_1.Size = New System.Drawing.Size(121, 17)
        Me._OptKho_1.TabIndex = 2
        Me._OptKho_1.TabStop = True
        Me._OptKho_1.Tag = "All store"
        Me._OptKho_1.Text = "Tổng hợp các kho"
        Me._OptKho_1.UseVisualStyleBackColor = False
        '
        '_OptKho_0
        '
        Me._OptKho_0.BackColor = System.Drawing.Color.Transparent
        Me._OptKho_0.Checked = True
        Me._OptKho_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptKho_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptKho_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptKho_0.Location = New System.Drawing.Point(8, 16)
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
        Me._CboKho_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboKho_0.Location = New System.Drawing.Point(64, 12)
        Me._CboKho_0.Name = "_CboKho_0"
        Me._CboKho_0.Size = New System.Drawing.Size(217, 21)
        Me._CboKho_0.TabIndex = 1
        '
        '_CboVV_0
        '
        Me._CboVV_0.BackColor = System.Drawing.Color.White
        Me._CboVV_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboVV_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboVV_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboVV_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboVV_0.Location = New System.Drawing.Point(184, 199)
        Me._CboVV_0.Name = "_CboVV_0"
        Me._CboVV_0.Size = New System.Drawing.Size(105, 21)
        Me._CboVV_0.TabIndex = 10
        '
        '_OptBC_10
        '
        Me._OptBC_10.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_10.Checked = True
        Me._OptBC_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_10.Location = New System.Drawing.Point(8, 56)
        Me._OptBC_10.Name = "_OptBC_10"
        Me._OptBC_10.Size = New System.Drawing.Size(249, 17)
        Me._OptBC_10.TabIndex = 3
        Me._OptBC_10.TabStop = True
        Me._OptBC_10.Tag = "Expense and cost of products"
        Me._OptBC_10.Text = "Chi tiết giá thành sản phẩm hoàn thành"
        Me._OptBC_10.UseVisualStyleBackColor = False
        '
        '_OptBC_11
        '
        Me._OptBC_11.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_11.Location = New System.Drawing.Point(8, 104)
        Me._OptBC_11.Name = "_OptBC_11"
        Me._OptBC_11.Size = New System.Drawing.Size(249, 17)
        Me._OptBC_11.TabIndex = 4
        Me._OptBC_11.TabStop = True
        Me._OptBC_11.Tag = "Profits on constructions and products"
        Me._OptBC_11.Text = "Thẻ giá thành sản phẩm hoàn thành"
        Me._OptBC_11.UseVisualStyleBackColor = False
        '
        '_OptBC_33
        '
        Me._OptBC_33.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_33.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_33.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_33.Location = New System.Drawing.Point(8, 199)
        Me._OptBC_33.Name = "_OptBC_33"
        Me._OptBC_33.Size = New System.Drawing.Size(169, 17)
        Me._OptBC_33.TabIndex = 9
        Me._OptBC_33.TabStop = True
        Me._OptBC_33.Tag = "Arising under the contract"
        Me._OptBC_33.Text = "Phát sinh theo hợp đồng"
        Me._OptBC_33.UseVisualStyleBackColor = False
        '
        '_OptBC_50
        '
        Me._OptBC_50.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_50.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_50.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_50.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_50.Location = New System.Drawing.Point(8, 127)
        Me._OptBC_50.Name = "_OptBC_50"
        Me._OptBC_50.Size = New System.Drawing.Size(249, 17)
        Me._OptBC_50.TabIndex = 5
        Me._OptBC_50.TabStop = True
        Me._OptBC_50.Tag = "Cost and Profit of Finished Goods"
        Me._OptBC_50.Text = "Chi tiết chi phí nguyên vật liệu trực tiếp"
        Me._OptBC_50.UseVisualStyleBackColor = False
        '
        '_OptBC_51
        '
        Me._OptBC_51.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_51.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_51.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_51.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_51.Location = New System.Drawing.Point(8, 223)
        Me._OptBC_51.Name = "_OptBC_51"
        Me._OptBC_51.Size = New System.Drawing.Size(249, 17)
        Me._OptBC_51.TabIndex = 11
        Me._OptBC_51.TabStop = True
        Me._OptBC_51.Tag = "Cost of Product Detail Report"
        Me._OptBC_51.Text = "Chi tiết giá thành thành phẩm"
        Me._OptBC_51.UseVisualStyleBackColor = False
        '
        '_OptBC_59
        '
        Me._OptBC_59.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_59.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_59.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_59.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_59.Location = New System.Drawing.Point(8, 175)
        Me._OptBC_59.Name = "_OptBC_59"
        Me._OptBC_59.Size = New System.Drawing.Size(169, 17)
        Me._OptBC_59.TabIndex = 6
        Me._OptBC_59.TabStop = True
        Me._OptBC_59.Tag = "Detail expense in product"
        Me._OptBC_59.Text = "Chi tiết chi phí theo công trình"
        Me._OptBC_59.UseVisualStyleBackColor = False
        '
        '_txtCT_0
        '
        Me._txtCT_0.AcceptsReturn = True
        Me._txtCT_0.BackColor = System.Drawing.Color.White
        Me._txtCT_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtCT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtCT_0.Location = New System.Drawing.Point(184, 175)
        Me._txtCT_0.MaxLength = 20
        Me._txtCT_0.Name = "_txtCT_0"
        Me._txtCT_0.Size = New System.Drawing.Size(73, 20)
        Me._txtCT_0.TabIndex = 7
        Me._txtCT_0.Tag = "0"
        '
        '_OptBC_54
        '
        Me._OptBC_54.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_54.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_54.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_54.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_54.Location = New System.Drawing.Point(8, 247)
        Me._OptBC_54.Name = "_OptBC_54"
        Me._OptBC_54.Size = New System.Drawing.Size(249, 17)
        Me._OptBC_54.TabIndex = 12
        Me._OptBC_54.TabStop = True
        Me._OptBC_54.Tag = "Production Norm Table"
        Me._OptBC_54.Text = "Định mức thành phẩm"
        Me._OptBC_54.UseVisualStyleBackColor = False
        '
        '_cmdCT_0
        '
        Me._cmdCT_0.Image = CType(resources.GetObject("_cmdCT_0.Image"), System.Drawing.Image)
        Me._cmdCT_0.Location = New System.Drawing.Point(264, 174)
        Me._cmdCT_0.Name = "_cmdCT_0"
        Me._cmdCT_0.Size = New System.Drawing.Size(23, 22)
        Me._cmdCT_0.TabIndex = 8
        '
        '_LbCT_0
        '
        Me._LbCT_0.BackColor = System.Drawing.Color.Transparent
        Me._LbCT_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbCT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbCT_0.ForeColor = System.Drawing.Color.Blue
        Me._LbCT_0.Location = New System.Drawing.Point(296, 175)
        Me._LbCT_0.Name = "_LbCT_0"
        Me._LbCT_0.Size = New System.Drawing.Size(185, 17)
        Me._LbCT_0.TabIndex = 31
        Me._LbCT_0.Tag = "1"
        '
        'GauGe
        '
        Me.GauGe.Location = New System.Drawing.Point(8, 444)
        Me.GauGe.Name = "GauGe"
        Me.GauGe.Size = New System.Drawing.Size(260, 17)
        Me.GauGe.TabIndex = 26
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(424, 440)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 29
        Me._Command_2.Tag = "Return"
        Me._Command_2.Text = "Trở &về"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.print16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(350, 440)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 28
        Me._Command_1.Tag = "Print"
        Me._Command_1.Text = "&In"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.report16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(272, 440)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 27
        Me._Command_0.Tag = "Preview"
        Me._Command_0.Text = "&Xem"
        '
        '_Frame_1
        '
        Me._Frame_1.BackColor = System.Drawing.Color.Transparent
        Me._Frame_1.Controls.Add(Me._MedNgay_0)
        Me._Frame_1.Controls.Add(Me._MedNgay_1)
        Me._Frame_1.Controls.Add(Me._Label_5)
        Me._Frame_1.Controls.Add(Me._Label_4)
        Me._Frame_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_1.Location = New System.Drawing.Point(192, 399)
        Me._Frame_1.Name = "_Frame_1"
        Me._Frame_1.Size = New System.Drawing.Size(304, 39)
        Me._Frame_1.TabIndex = 38
        Me._Frame_1.TabStop = False
        Me._Frame_1.Visible = False
        '
        '_MedNgay_0
        '
        Me._MedNgay_0.AllowPromptAsInput = False
        Me._MedNgay_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_0.Location = New System.Drawing.Point(76, 13)
        Me._MedNgay_0.Mask = "00/00/0000"
        Me._MedNgay_0.Name = "_MedNgay_0"
        Me._MedNgay_0.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_0.TabIndex = 22
        '
        '_MedNgay_1
        '
        Me._MedNgay_1.AllowPromptAsInput = False
        Me._MedNgay_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_1.Location = New System.Drawing.Point(222, 13)
        Me._MedNgay_1.Mask = "00/00/0000"
        Me._MedNgay_1.Name = "_MedNgay_1"
        Me._MedNgay_1.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_1.TabIndex = 23
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.Transparent
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_5.Location = New System.Drawing.Point(154, 15)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(56, 17)
        Me._Label_5.TabIndex = 40
        Me._Label_5.Tag = "to"
        Me._Label_5.Text = "Đến ngày"
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.Transparent
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_4.Location = New System.Drawing.Point(6, 15)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(48, 17)
        Me._Label_4.TabIndex = 39
        Me._Label_4.Tag = "From"
        Me._Label_4.Text = "Từ ngày"
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
        Me._Frame_0.Location = New System.Drawing.Point(193, 396)
        Me._Frame_0.Name = "_Frame_0"
        Me._Frame_0.Size = New System.Drawing.Size(304, 38)
        Me._Frame_0.TabIndex = 35
        Me._Frame_0.TabStop = False
        '
        '_CboThang_0
        '
        Me._CboThang_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_0.Location = New System.Drawing.Point(75, 12)
        Me._CboThang_0.Name = "_CboThang_0"
        Me._CboThang_0.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_0.TabIndex = 24
        '
        '_CboThang_1
        '
        Me._CboThang_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_1.Location = New System.Drawing.Point(222, 12)
        Me._CboThang_1.Name = "_CboThang_1"
        Me._CboThang_1.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_1.TabIndex = 25
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(8, 14)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(61, 17)
        Me._Label_0.TabIndex = 37
        Me._Label_0.Tag = "From"
        Me._Label_0.Text = "Từ tháng"
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(154, 14)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(62, 17)
        Me._Label_1.TabIndex = 36
        Me._Label_1.Tag = "to"
        Me._Label_1.Text = "Đến tháng"
        '
        'FrmSogiathanh
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(503, 470)
        Me.Controls.Add(Me._OptTG_1)
        Me.Controls.Add(Me._OptTG_0)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.GauGe)
        Me.Controls.Add(Me._Frame_1)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Frame_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSogiathanh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Price reports"
        Me.Text = "Sổ giá thành"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me._Frame_2.ResumeLayout(False)
        Me._Frame_2.PerformLayout()
        Me._Frame_5.ResumeLayout(False)
        Me._Frame_1.ResumeLayout(False)
        Me._Frame_1.PerformLayout()
        Me._Frame_0.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
	Sub InitializetxtShTk()
		Me.txtShTk(9) = _txtShTk_9
	End Sub
	Sub InitializetxtCT()
		Me.txtCT(0) = _txtCT_0
	End Sub
	Sub Initializecmdtk()
		Me.cmdtk(9) = _cmdtk_9
	End Sub
	Sub InitializecmdCT()
		Me.cmdCT(0) = _cmdCT_0
	End Sub
	Sub InitializeOptTG()
		Me.OptTG(1) = _OptTG_1
		Me.OptTG(0) = _OptTG_0
	End Sub
	Sub InitializeOptKho()
		Me.OptKho(1) = _OptKho_1
		Me.OptKho(0) = _OptKho_0
	End Sub
	Sub InitializeOptBC()
        Me.OptBC(1) = _OptBC_1
        Me.OptBC(2) = _OptBC_2
		Me.OptBC(0) = _OptBC_0
		Me.OptBC(10) = _OptBC_10
		Me.OptBC(11) = _OptBC_11
		Me.OptBC(33) = _OptBC_33
		Me.OptBC(50) = _OptBC_50
		Me.OptBC(51) = _OptBC_51
		Me.OptBC(59) = _OptBC_59
		Me.OptBC(54) = _OptBC_54
	End Sub
	Sub InitializeMedNgay()
		Me.MedNgay(0) = _MedNgay_0
		Me.MedNgay(1) = _MedNgay_1
	End Sub
	Sub InitializeLbTenTk()
		Me.LbTenTk(9) = _LbTenTk_9
	End Sub
	Sub InitializeLbCT()
		Me.LbCT(0) = _LbCT_0
	End Sub
	Sub InitializeLabel()
		Me.Label(5) = _Label_5
		Me.Label(4) = _Label_4
		Me.Label(0) = _Label_0
		Me.Label(1) = _Label_1
	End Sub
	Sub InitializeFrame()
		Me.Frame(2) = _Frame_2
		Me.Frame(5) = _Frame_5
		Me.Frame(1) = _Frame_1
		Me.Frame(0) = _Frame_0
	End Sub
	Sub InitializeCommand()
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
	Sub InitializeChkDu()
		Me.ChkDu(9) = _ChkDu_9
		Me.ChkDu(12) = _ChkDu_12
		Me.ChkDu(13) = _ChkDu_13
	End Sub
	Sub InitializeCboVV()
		Me.CboVV(0) = _CboVV_0
	End Sub
	Sub InitializeCboThang()
		Me.CboThang(0) = _CboThang_0
		Me.CboThang(1) = _CboThang_1
	End Sub
	Sub InitializeCboKho()
		Me.CboKho(1) = _CboKho_1
		Me.CboKho(0) = _CboKho_0
    End Sub
    Private WithEvents _OptBC_2 As System.Windows.Forms.RadioButton
#End Region 
End Class
