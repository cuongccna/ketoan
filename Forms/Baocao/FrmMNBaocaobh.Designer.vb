<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMNBaocaobh
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
        isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		Initializetxtshkh()
		Initializetxtsh()
		InitializetxtShTk()
		Initializelbkh()
		Initializelb()
		Initializecmdtk()
		Initializecmdkh()
		Initializecmd()
		InitializeOptTG()
		InitializeOptDT()
		InitializeOptBC()
		InitializeMedNgay()
		InitializeLbTenTk()
		InitializeLabel()
		InitializeFrame2()
		InitializeFrame()
		InitializeCommand()
		InitializeChkDu()
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
	Private WithEvents _ChkDu_3 As System.Windows.Forms.CheckBox
	Public WithEvents CboVV As ComboBoxEx.ComboBoxExt
	Private WithEvents _OptBC_1 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_9 As System.Windows.Forms.RadioButton
	Public WithEvents cboQuy As ComboBoxEx.ComboBoxExt
	Private WithEvents _OptBC_6 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_11 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_12 As System.Windows.Forms.RadioButton
	Private WithEvents _txtShTk_0 As System.Windows.Forms.TextBox
	Public WithEvents Chk1 As System.Windows.Forms.CheckBox
	Public WithEvents CboCap As ComboBoxEx.ComboBoxExt
	Private WithEvents _OptBC_19 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_21 As System.Windows.Forms.RadioButton
	Private WithEvents _txtShTk_3 As System.Windows.Forms.TextBox
	Private WithEvents _OptBC_0 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_8 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_10 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_5 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_4 As System.Windows.Forms.RadioButton
	Private WithEvents _ChkDu_1 As System.Windows.Forms.CheckBox
	Public WithEvents CboThuchi As ComboBoxEx.ComboBoxExt
	Private WithEvents _OptBC_23 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_7 As System.Windows.Forms.RadioButton
	Private WithEvents _OptDT_2 As System.Windows.Forms.RadioButton
	Private WithEvents _CboKho_2 As ComboBoxEx.ComboBoxExt
	Private WithEvents _txtsh_0 As System.Windows.Forms.TextBox
	Private WithEvents _ChkDu_13 As System.Windows.Forms.CheckBox
	Private WithEvents _OptDT_0 As System.Windows.Forms.RadioButton
	Private WithEvents _CboKho_1 As ComboBoxEx.ComboBoxExt
	Private WithEvents _txtshkh_2 As System.Windows.Forms.TextBox
	Private WithEvents _ChkDu_18 As System.Windows.Forms.CheckBox
	Private WithEvents _ChkDu_9 As System.Windows.Forms.CheckBox
	Private WithEvents _ChkDu_19 As System.Windows.Forms.CheckBox
	Private WithEvents _ChkDu_17 As System.Windows.Forms.CheckBox
	Private WithEvents _OptDT_1 As System.Windows.Forms.RadioButton
	Private WithEvents _ChkDu_12 As System.Windows.Forms.CheckBox
	Private WithEvents _txtShTk_9 As System.Windows.Forms.TextBox
    Private WithEvents _cmdkh_2 As System.Windows.Forms.Button
    Private WithEvents _cmd_0 As System.Windows.Forms.Button
    Private WithEvents _cmdtk_9 As System.Windows.Forms.Button
    Private WithEvents _lb_0 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_9 As System.Windows.Forms.Label
    Private WithEvents _lbkh_2 As System.Windows.Forms.Label
    Private WithEvents _Frame2_5 As System.Windows.Forms.GroupBox
    Private WithEvents _txtShTk_15 As System.Windows.Forms.TextBox
    Private WithEvents _ChkDu_15 As System.Windows.Forms.CheckBox
    Public WithEvents CboTL As ComboBoxEx.ComboBoxExt
    Private WithEvents _OptBC_3 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBC_2 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBC_16 As System.Windows.Forms.RadioButton
    Private WithEvents _ChkDu_16 As System.Windows.Forms.CheckBox
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Public WithEvents GauGe As System.Windows.Forms.ProgressBar
    Private WithEvents _cmdtk_15 As System.Windows.Forms.Button
    Private WithEvents _cmdtk_3 As System.Windows.Forms.Button
    Private WithEvents _cmdtk_0 As System.Windows.Forms.Button
    Private WithEvents _OptTG_0 As System.Windows.Forms.RadioButton
    Private WithEvents _OptTG_1 As System.Windows.Forms.RadioButton
    Private WithEvents _Frame_2 As System.Windows.Forms.GroupBox
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
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_0 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_3 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_15 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Public CboKho(2) As ComboBoxEx.ComboBoxExt
    Public CboThang(1) As ComboBoxEx.ComboBoxExt
    Public ChkDu(19) As System.Windows.Forms.CheckBox
    Public Command(3) As System.Windows.Forms.Button
    Public Frame(2) As System.Windows.Forms.GroupBox
    Public Frame2(5) As System.Windows.Forms.GroupBox
    Public Label(5) As System.Windows.Forms.Label
    Public LbTenTk(15) As System.Windows.Forms.Label
    Public MedNgay(1) As System.Windows.Forms.MaskedTextBox
    Public OptBC(23) As System.Windows.Forms.RadioButton
    Public OptDT(2) As System.Windows.Forms.RadioButton
    Public OptTG(1) As System.Windows.Forms.RadioButton
    Public cmd(0) As System.Windows.Forms.Button
    Public cmdkh(2) As System.Windows.Forms.Button
    Public cmdtk(15) As System.Windows.Forms.Button
    Public lb(0) As System.Windows.Forms.Label
    Public lbkh(2) As System.Windows.Forms.Label
    Public txtShTk(15) As System.Windows.Forms.TextBox
    Public txtsh(0) As System.Windows.Forms.TextBox
    Public txtshkh(2) As System.Windows.Forms.TextBox
    'Private listBoxComboBoxHelper1 As Artinsoft.VB6.Gui.ListControlHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMNBaocaobh))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._ChkDu_1 = New System.Windows.Forms.CheckBox()
        Me._ChkDu_3 = New System.Windows.Forms.CheckBox()
        Me.CboVV = New ComboBoxEx.ComboBoxExt()
        Me._OptBC_1 = New System.Windows.Forms.RadioButton()
        Me._OptBC_9 = New System.Windows.Forms.RadioButton()
        Me.cboQuy = New ComboBoxEx.ComboBoxExt()
        Me._OptBC_6 = New System.Windows.Forms.RadioButton()
        Me._OptBC_11 = New System.Windows.Forms.RadioButton()
        Me._OptBC_12 = New System.Windows.Forms.RadioButton()
        Me._txtShTk_0 = New System.Windows.Forms.TextBox()
        Me.Chk1 = New System.Windows.Forms.CheckBox()
        Me.CboCap = New ComboBoxEx.ComboBoxExt()
        Me._OptBC_19 = New System.Windows.Forms.RadioButton()
        Me._OptBC_21 = New System.Windows.Forms.RadioButton()
        Me._txtShTk_3 = New System.Windows.Forms.TextBox()
        Me._OptBC_0 = New System.Windows.Forms.RadioButton()
        Me._OptBC_8 = New System.Windows.Forms.RadioButton()
        Me._OptBC_10 = New System.Windows.Forms.RadioButton()
        Me._OptBC_5 = New System.Windows.Forms.RadioButton()
        Me._OptBC_4 = New System.Windows.Forms.RadioButton()
        Me.CboThuchi = New ComboBoxEx.ComboBoxExt()
        Me._OptBC_23 = New System.Windows.Forms.RadioButton()
        Me._OptBC_7 = New System.Windows.Forms.RadioButton()
        Me._Frame2_5 = New System.Windows.Forms.GroupBox()
        Me._OptDT_2 = New System.Windows.Forms.RadioButton()
        Me._CboKho_2 = New ComboBoxEx.ComboBoxExt()
        Me._txtsh_0 = New System.Windows.Forms.TextBox()
        Me._ChkDu_13 = New System.Windows.Forms.CheckBox()
        Me._OptDT_0 = New System.Windows.Forms.RadioButton()
        Me._CboKho_1 = New ComboBoxEx.ComboBoxExt()
        Me._txtshkh_2 = New System.Windows.Forms.TextBox()
        Me._ChkDu_18 = New System.Windows.Forms.CheckBox()
        Me._ChkDu_9 = New System.Windows.Forms.CheckBox()
        Me._ChkDu_19 = New System.Windows.Forms.CheckBox()
        Me._ChkDu_17 = New System.Windows.Forms.CheckBox()
        Me._OptDT_1 = New System.Windows.Forms.RadioButton()
        Me._ChkDu_12 = New System.Windows.Forms.CheckBox()
        Me._txtShTk_9 = New System.Windows.Forms.TextBox()
        Me._cmdkh_2 = New System.Windows.Forms.Button()
        Me._cmd_0 = New System.Windows.Forms.Button()
        Me._cmdtk_9 = New System.Windows.Forms.Button()
        Me._lb_0 = New System.Windows.Forms.Label()
        Me._LbTenTk_9 = New System.Windows.Forms.Label()
        Me._lbkh_2 = New System.Windows.Forms.Label()
        Me._txtShTk_15 = New System.Windows.Forms.TextBox()
        Me._ChkDu_15 = New System.Windows.Forms.CheckBox()
        Me.CboTL = New ComboBoxEx.ComboBoxExt()
        Me._OptBC_3 = New System.Windows.Forms.RadioButton()
        Me._OptBC_2 = New System.Windows.Forms.RadioButton()
        Me._OptBC_16 = New System.Windows.Forms.RadioButton()
        Me._ChkDu_16 = New System.Windows.Forms.CheckBox()
        Me._Command_3 = New System.Windows.Forms.Button()
        Me._Command_2 = New System.Windows.Forms.Button()
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me.GauGe = New System.Windows.Forms.ProgressBar()
        Me._cmdtk_15 = New System.Windows.Forms.Button()
        Me._cmdtk_3 = New System.Windows.Forms.Button()
        Me._cmdtk_0 = New System.Windows.Forms.Button()
        Me._Frame_2 = New System.Windows.Forms.GroupBox()
        Me._OptTG_0 = New System.Windows.Forms.RadioButton()
        Me._OptTG_1 = New System.Windows.Forms.RadioButton()
        Me._Frame_1 = New System.Windows.Forms.GroupBox()
        Me._MedNgay_0 = New System.Windows.Forms.MaskedTextBox()
        Me._MedNgay_1 = New System.Windows.Forms.MaskedTextBox()
        Me._Label_5 = New System.Windows.Forms.Label()
        Me._Label_4 = New System.Windows.Forms.Label()
        Me._Frame_0 = New System.Windows.Forms.GroupBox()
        Me._CboThang_0 = New ComboBoxEx.ComboBoxExt()
        Me._CboThang_1 = New ComboBoxEx.ComboBoxExt()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me._Label_1 = New System.Windows.Forms.Label()
        Me._Label_3 = New System.Windows.Forms.Label()
        Me._LbTenTk_0 = New System.Windows.Forms.Label()
        Me._LbTenTk_3 = New System.Windows.Forms.Label()
        Me._LbTenTk_15 = New System.Windows.Forms.Label()
        Me._Label_2 = New System.Windows.Forms.Label()
        Me._Frame2_5.SuspendLayout()
        Me._Frame_2.SuspendLayout()
        Me._Frame_1.SuspendLayout()
        Me._Frame_0.SuspendLayout()
        Me.SuspendLayout()
        '
        '_ChkDu_1
        '
        Me._ChkDu_1.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_1.Location = New System.Drawing.Point(152, 248)
        Me._ChkDu_1.Name = "_ChkDu_1"
        Me._ChkDu_1.Size = New System.Drawing.Size(97, 17)
        Me._ChkDu_1.TabIndex = 32
        Me._ChkDu_1.Tag = "Index"
        Me._ChkDu_1.Text = "Theo hợp đồng"
        Me.ToolTipMain.SetToolTip(Me._ChkDu_1, "by Object")
        Me._ChkDu_1.UseVisualStyleBackColor = False
        '
        '_ChkDu_3
        '
        Me._ChkDu_3.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_3.Location = New System.Drawing.Point(256, 200)
        Me._ChkDu_3.Name = "_ChkDu_3"
        Me._ChkDu_3.Size = New System.Drawing.Size(129, 17)
        Me._ChkDu_3.TabIndex = 29
        Me._ChkDu_3.Tag = "Group by Reference Account"
        Me._ChkDu_3.Text = "Nhóm theo tk đối ứng"
        Me._ChkDu_3.UseVisualStyleBackColor = False
        '
        'CboVV
        '
        Me.CboVV.BackColor = System.Drawing.SystemColors.Window
        Me.CboVV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboVV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboVV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboVV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboVV.Location = New System.Drawing.Point(256, 248)
        Me.CboVV.Name = "CboVV"
        Me.CboVV.Size = New System.Drawing.Size(145, 21)
        Me.CboVV.TabIndex = 33
        '
        '_OptBC_1
        '
        Me._OptBC_1.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_1.Checked = True
        Me._OptBC_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_1.Location = New System.Drawing.Point(8, 8)
        Me._OptBC_1.Name = "_OptBC_1"
        Me._OptBC_1.Size = New System.Drawing.Size(177, 17)
        Me._OptBC_1.TabIndex = 0
        Me._OptBC_1.TabStop = True
        Me._OptBC_1.Tag = "Returned VAT Detail Report"
        Me._OptBC_1.Text = "Báo cáo số lượng hoá đơn quý"
        Me._OptBC_1.UseVisualStyleBackColor = False
        '
        '_OptBC_9
        '
        Me._OptBC_9.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_9.Location = New System.Drawing.Point(8, 32)
        Me._OptBC_9.Name = "_OptBC_9"
        Me._OptBC_9.Size = New System.Drawing.Size(177, 17)
        Me._OptBC_9.TabIndex = 1
        Me._OptBC_9.TabStop = True
        Me._OptBC_9.Tag = "Returned VAT Detail Report"
        Me._OptBC_9.Text = "Báo cáo số lượng hoá đơn năm"
        Me._OptBC_9.UseVisualStyleBackColor = False
        '
        'cboQuy
        '
        Me.cboQuy.BackColor = System.Drawing.SystemColors.Window
        Me.cboQuy.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboQuy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboQuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuy.DropDownWidth = 29
        Me.cboQuy.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQuy.Location = New System.Drawing.Point(192, 8)
        Me.cboQuy.Name = "cboQuy"
        Me.cboQuy.Size = New System.Drawing.Size(57, 21)
        Me.cboQuy.TabIndex = 20
        '
        '_OptBC_6
        '
        Me._OptBC_6.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_6.Location = New System.Drawing.Point(8, 104)
        Me._OptBC_6.Name = "_OptBC_6"
        Me._OptBC_6.Size = New System.Drawing.Size(161, 17)
        Me._OptBC_6.TabIndex = 4
        Me._OptBC_6.TabStop = True
        Me._OptBC_6.Tag = "Monthly VAT Declaration Form"
        Me._OptBC_6.Text = "Tờ khai thuế giá trị gia tăng"
        Me._OptBC_6.UseVisualStyleBackColor = False
        '
        '_OptBC_11
        '
        Me._OptBC_11.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_11.Location = New System.Drawing.Point(8, 176)
        Me._OptBC_11.Name = "_OptBC_11"
        Me._OptBC_11.Size = New System.Drawing.Size(137, 17)
        Me._OptBC_11.TabIndex = 7
        Me._OptBC_11.TabStop = True
        Me._OptBC_11.Tag = "Print All Ledgers"
        Me._OptBC_11.Text = "Sổ quỹ tiền mặt"
        Me._OptBC_11.UseVisualStyleBackColor = False
        '
        '_OptBC_12
        '
        Me._OptBC_12.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_12.Location = New System.Drawing.Point(8, 200)
        Me._OptBC_12.Name = "_OptBC_12"
        Me._OptBC_12.Size = New System.Drawing.Size(137, 17)
        Me._OptBC_12.TabIndex = 8
        Me._OptBC_12.TabStop = True
        Me._OptBC_12.Tag = "Print All Ledgers"
        Me._OptBC_12.Text = "Sổ tiền gửi ngân hàng"
        Me._OptBC_12.UseVisualStyleBackColor = False
        '
        '_txtShTk_0
        '
        Me._txtShTk_0.AcceptsReturn = True
        Me._txtShTk_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_0.Location = New System.Drawing.Point(256, 176)
        Me._txtShTk_0.MaxLength = 12
        Me._txtShTk_0.Name = "_txtShTk_0"
        Me._txtShTk_0.Size = New System.Drawing.Size(73, 20)
        Me._txtShTk_0.TabIndex = 27
        Me._txtShTk_0.Tag = "0"
        '
        'Chk1
        '
        Me.Chk1.BackColor = System.Drawing.Color.Transparent
        Me.Chk1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Chk1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk1.Location = New System.Drawing.Point(176, 152)
        Me.Chk1.Name = "Chk1"
        Me.Chk1.Size = New System.Drawing.Size(145, 17)
        Me.Chk1.TabIndex = 25
        Me.Chk1.Tag = "Print Bar Code"
        Me.Chk1.Text = "In chi tiết không phát sinh"
        Me.Chk1.UseVisualStyleBackColor = False
        '
        'CboCap
        '
        Me.CboCap.BackColor = System.Drawing.SystemColors.Window
        Me.CboCap.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboCap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCap.DropDownWidth = 29
        Me.CboCap.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCap.Location = New System.Drawing.Point(400, 148)
        Me.CboCap.Name = "CboCap"
        Me.CboCap.Size = New System.Drawing.Size(50, 21)
        Me.CboCap.TabIndex = 26
        '
        '_OptBC_19
        '
        Me._OptBC_19.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_19.Location = New System.Drawing.Point(8, 152)
        Me._OptBC_19.Name = "_OptBC_19"
        Me._OptBC_19.Size = New System.Drawing.Size(161, 17)
        Me._OptBC_19.TabIndex = 6
        Me._OptBC_19.TabStop = True
        Me._OptBC_19.Tag = "Yearly final tax reports"
        Me._OptBC_19.Text = "Bảng cân đối số phát sinh"
        Me._OptBC_19.UseVisualStyleBackColor = False
        '
        '_OptBC_21
        '
        Me._OptBC_21.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_21.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_21.Location = New System.Drawing.Point(8, 224)
        Me._OptBC_21.Name = "_OptBC_21"
        Me._OptBC_21.Size = New System.Drawing.Size(241, 17)
        Me._OptBC_21.TabIndex = 9
        Me._OptBC_21.TabStop = True
        Me._OptBC_21.Tag = "Print All Ledgers"
        Me._OptBC_21.Text = "Sổ chi phí sản xuất, kinh doanh"
        Me._OptBC_21.UseVisualStyleBackColor = False
        '
        '_txtShTk_3
        '
        Me._txtShTk_3.AcceptsReturn = True
        Me._txtShTk_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_3.Location = New System.Drawing.Point(256, 224)
        Me._txtShTk_3.MaxLength = 12
        Me._txtShTk_3.Name = "_txtShTk_3"
        Me._txtShTk_3.Size = New System.Drawing.Size(73, 20)
        Me._txtShTk_3.TabIndex = 30
        Me._txtShTk_3.Tag = "0"
        '
        '_OptBC_0
        '
        Me._OptBC_0.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_0.Location = New System.Drawing.Point(8, 248)
        Me._OptBC_0.Name = "_OptBC_0"
        Me._OptBC_0.Size = New System.Drawing.Size(137, 17)
        Me._OptBC_0.TabIndex = 10
        Me._OptBC_0.TabStop = True
        Me._OptBC_0.Tag = "Print All Ledgers"
        Me._OptBC_0.Text = "Nhật ký chung"
        Me._OptBC_0.UseVisualStyleBackColor = False
        '
        '_OptBC_8
        '
        Me._OptBC_8.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_8.Location = New System.Drawing.Point(8, 296)
        Me._OptBC_8.Name = "_OptBC_8"
        Me._OptBC_8.Size = New System.Drawing.Size(137, 17)
        Me._OptBC_8.TabIndex = 13
        Me._OptBC_8.TabStop = True
        Me._OptBC_8.Tag = "Print All Ledgers"
        Me._OptBC_8.Text = "Nhật ký thu tiền"
        Me._OptBC_8.UseVisualStyleBackColor = False
        '
        '_OptBC_10
        '
        Me._OptBC_10.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_10.Location = New System.Drawing.Point(152, 296)
        Me._OptBC_10.Name = "_OptBC_10"
        Me._OptBC_10.Size = New System.Drawing.Size(97, 17)
        Me._OptBC_10.TabIndex = 14
        Me._OptBC_10.TabStop = True
        Me._OptBC_10.Tag = "Print All Ledgers"
        Me._OptBC_10.Text = "Nhật ký chi tiền"
        Me._OptBC_10.UseVisualStyleBackColor = False
        '
        '_OptBC_5
        '
        Me._OptBC_5.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_5.Location = New System.Drawing.Point(8, 272)
        Me._OptBC_5.Name = "_OptBC_5"
        Me._OptBC_5.Size = New System.Drawing.Size(137, 17)
        Me._OptBC_5.TabIndex = 11
        Me._OptBC_5.TabStop = True
        Me._OptBC_5.Tag = "Print All Ledgers"
        Me._OptBC_5.Text = "Nhật ký mua hàng"
        Me._OptBC_5.UseVisualStyleBackColor = False
        '
        '_OptBC_4
        '
        Me._OptBC_4.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_4.Location = New System.Drawing.Point(152, 272)
        Me._OptBC_4.Name = "_OptBC_4"
        Me._OptBC_4.Size = New System.Drawing.Size(113, 17)
        Me._OptBC_4.TabIndex = 12
        Me._OptBC_4.TabStop = True
        Me._OptBC_4.Tag = "Print All Ledgers"
        Me._OptBC_4.Text = "Nhật ký bán hàng"
        Me._OptBC_4.UseVisualStyleBackColor = False
        '
        'CboThuchi
        '
        Me.CboThuchi.BackColor = System.Drawing.SystemColors.Window
        Me.CboThuchi.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboThuchi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboThuchi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboThuchi.DropDownWidth = 121
        Me.CboThuchi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboThuchi.Location = New System.Drawing.Point(256, 292)
        Me.CboThuchi.Name = "CboThuchi"
        Me.CboThuchi.Size = New System.Drawing.Size(145, 21)
        Me.CboThuchi.TabIndex = 34
        '
        '_OptBC_23
        '
        Me._OptBC_23.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_23.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_23.Location = New System.Drawing.Point(8, 344)
        Me._OptBC_23.Name = "_OptBC_23"
        Me._OptBC_23.Size = New System.Drawing.Size(161, 17)
        Me._OptBC_23.TabIndex = 16
        Me._OptBC_23.TabStop = True
        Me._OptBC_23.Tag = "Summary Sale and Cost of good sold report"
        Me._OptBC_23.Text = "Bảng kê doanh thu theo"
        Me._OptBC_23.UseVisualStyleBackColor = False
        '
        '_OptBC_7
        '
        Me._OptBC_7.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_7.Location = New System.Drawing.Point(8, 320)
        Me._OptBC_7.Name = "_OptBC_7"
        Me._OptBC_7.Size = New System.Drawing.Size(161, 17)
        Me._OptBC_7.TabIndex = 15
        Me._OptBC_7.TabStop = True
        Me._OptBC_7.Tag = "Summary Sale and Cost of good sold report"
        Me._OptBC_7.Text = "Bảng kê doanh thu - giá vốn"
        Me._OptBC_7.UseVisualStyleBackColor = False
        '
        '_Frame2_5
        '
        Me._Frame2_5.BackColor = System.Drawing.Color.Transparent
        Me._Frame2_5.Controls.Add(Me._OptDT_2)
        Me._Frame2_5.Controls.Add(Me._CboKho_2)
        Me._Frame2_5.Controls.Add(Me._txtsh_0)
        Me._Frame2_5.Controls.Add(Me._ChkDu_13)
        Me._Frame2_5.Controls.Add(Me._OptDT_0)
        Me._Frame2_5.Controls.Add(Me._CboKho_1)
        Me._Frame2_5.Controls.Add(Me._txtshkh_2)
        Me._Frame2_5.Controls.Add(Me._ChkDu_18)
        Me._Frame2_5.Controls.Add(Me._ChkDu_9)
        Me._Frame2_5.Controls.Add(Me._ChkDu_19)
        Me._Frame2_5.Controls.Add(Me._ChkDu_17)
        Me._Frame2_5.Controls.Add(Me._OptDT_1)
        Me._Frame2_5.Controls.Add(Me._ChkDu_12)
        Me._Frame2_5.Controls.Add(Me._txtShTk_9)
        Me._Frame2_5.Controls.Add(Me._cmdkh_2)
        Me._Frame2_5.Controls.Add(Me._cmd_0)
        Me._Frame2_5.Controls.Add(Me._cmdtk_9)
        Me._Frame2_5.Controls.Add(Me._lb_0)
        Me._Frame2_5.Controls.Add(Me._LbTenTk_9)
        Me._Frame2_5.Controls.Add(Me._lbkh_2)
        Me._Frame2_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame2_5.ForeColor = System.Drawing.Color.Blue
        Me._Frame2_5.Location = New System.Drawing.Point(8, 368)
        Me._Frame2_5.Name = "_Frame2_5"
        Me._Frame2_5.Size = New System.Drawing.Size(537, 185)
        Me._Frame2_5.TabIndex = 69
        Me._Frame2_5.TabStop = False
        Me._Frame2_5.Text = "Bảng kê doanh thu theo"
        '
        '_OptDT_2
        '
        Me._OptDT_2.BackColor = System.Drawing.Color.Transparent
        Me._OptDT_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptDT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptDT_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptDT_2.Location = New System.Drawing.Point(8, 136)
        Me._OptDT_2.Name = "_OptDT_2"
        Me._OptDT_2.Size = New System.Drawing.Size(77, 17)
        Me._OptDT_2.TabIndex = 19
        Me._OptDT_2.TabStop = True
        Me._OptDT_2.Tag = "VAT Rate"
        Me._OptDT_2.Text = "Thuế VAT"
        Me._OptDT_2.UseVisualStyleBackColor = False
        '
        '_CboKho_2
        '
        Me._CboKho_2.BackColor = System.Drawing.SystemColors.Window
        Me._CboKho_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboKho_2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboKho_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboKho_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboKho_2.Location = New System.Drawing.Point(192, 64)
        Me._CboKho_2.Name = "_CboKho_2"
        Me._CboKho_2.Size = New System.Drawing.Size(145, 21)
        Me._CboKho_2.TabIndex = 41
        '
        '_txtsh_0
        '
        Me._txtsh_0.AcceptsReturn = True
        Me._txtsh_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtsh_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtsh_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtsh_0.Location = New System.Drawing.Point(192, 91)
        Me._txtsh_0.MaxLength = 20
        Me._txtsh_0.Name = "_txtsh_0"
        Me._txtsh_0.Size = New System.Drawing.Size(73, 20)
        Me._txtsh_0.TabIndex = 43
        Me._txtsh_0.Tag = "0"
        '
        '_ChkDu_13
        '
        Me._ChkDu_13.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_13.Location = New System.Drawing.Point(8, 160)
        Me._ChkDu_13.Name = "_ChkDu_13"
        Me._ChkDu_13.Size = New System.Drawing.Size(250, 17)
        Me._ChkDu_13.TabIndex = 70
        Me._ChkDu_13.Tag = "Salesman"
        Me._ChkDu_13.Text = "Doanh thu - Giá vốn sau chiết khấu"
        Me._ChkDu_13.UseVisualStyleBackColor = False
        '
        '_OptDT_0
        '
        Me._OptDT_0.BackColor = System.Drawing.Color.Transparent
        Me._OptDT_0.Checked = True
        Me._OptDT_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptDT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptDT_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptDT_0.Location = New System.Drawing.Point(8, 40)
        Me._OptDT_0.Name = "_OptDT_0"
        Me._OptDT_0.Size = New System.Drawing.Size(75, 17)
        Me._OptDT_0.TabIndex = 18
        Me._OptDT_0.TabStop = True
        Me._OptDT_0.Tag = "Product"
        Me._OptDT_0.Text = "Mặt hàng"
        Me._OptDT_0.UseVisualStyleBackColor = False
        '
        '_CboKho_1
        '
        Me._CboKho_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboKho_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboKho_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboKho_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboKho_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboKho_1.Location = New System.Drawing.Point(192, 40)
        Me._CboKho_1.Name = "_CboKho_1"
        Me._CboKho_1.Size = New System.Drawing.Size(145, 21)
        Me._CboKho_1.TabIndex = 39
        '
        '_txtshkh_2
        '
        Me._txtshkh_2.AcceptsReturn = True
        Me._txtshkh_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtshkh_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtshkh_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtshkh_2.Location = New System.Drawing.Point(192, 16)
        Me._txtshkh_2.MaxLength = 12
        Me._txtshkh_2.Name = "_txtshkh_2"
        Me._txtshkh_2.Size = New System.Drawing.Size(73, 20)
        Me._txtshkh_2.TabIndex = 36
        Me._txtshkh_2.Tag = "0"
        '
        '_ChkDu_18
        '
        Me._ChkDu_18.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_18.Location = New System.Drawing.Point(96, 16)
        Me._ChkDu_18.Name = "_ChkDu_18"
        Me._ChkDu_18.Size = New System.Drawing.Size(84, 17)
        Me._ChkDu_18.TabIndex = 35
        Me._ChkDu_18.Tag = "Customer"
        Me._ChkDu_18.Text = "Khách hàng"
        Me._ChkDu_18.UseVisualStyleBackColor = False
        '
        '_ChkDu_9
        '
        Me._ChkDu_9.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_9.Location = New System.Drawing.Point(96, 40)
        Me._ChkDu_9.Name = "_ChkDu_9"
        Me._ChkDu_9.Size = New System.Drawing.Size(83, 17)
        Me._ChkDu_9.TabIndex = 38
        Me._ChkDu_9.Tag = "Store"
        Me._ChkDu_9.Text = "Kho hàng"
        Me._ChkDu_9.UseVisualStyleBackColor = False
        '
        '_ChkDu_19
        '
        Me._ChkDu_19.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_19.Location = New System.Drawing.Point(96, 64)
        Me._ChkDu_19.Name = "_ChkDu_19"
        Me._ChkDu_19.Size = New System.Drawing.Size(97, 17)
        Me._ChkDu_19.TabIndex = 40
        Me._ChkDu_19.Tag = "Source"
        Me._ChkDu_19.Text = "Kênh phân phối"
        Me._ChkDu_19.UseVisualStyleBackColor = False
        '
        '_ChkDu_17
        '
        Me._ChkDu_17.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_17.Location = New System.Drawing.Point(96, 92)
        Me._ChkDu_17.Name = "_ChkDu_17"
        Me._ChkDu_17.Size = New System.Drawing.Size(97, 17)
        Me._ChkDu_17.TabIndex = 42
        Me._ChkDu_17.Tag = "Salesman"
        Me._ChkDu_17.Text = "NV bán hàng"
        Me._ChkDu_17.UseVisualStyleBackColor = False
        '
        '_OptDT_1
        '
        Me._OptDT_1.BackColor = System.Drawing.Color.Transparent
        Me._OptDT_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptDT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptDT_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptDT_1.Location = New System.Drawing.Point(8, 16)
        Me._OptDT_1.Name = "_OptDT_1"
        Me._OptDT_1.Size = New System.Drawing.Size(83, 17)
        Me._OptDT_1.TabIndex = 17
        Me._OptDT_1.TabStop = True
        Me._OptDT_1.Tag = "Customer"
        Me._OptDT_1.Text = "Khách hàng"
        Me._OptDT_1.UseVisualStyleBackColor = False
        '
        '_ChkDu_12
        '
        Me._ChkDu_12.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_12.Location = New System.Drawing.Point(96, 116)
        Me._ChkDu_12.Name = "_ChkDu_12"
        Me._ChkDu_12.Size = New System.Drawing.Size(89, 17)
        Me._ChkDu_12.TabIndex = 45
        Me._ChkDu_12.Tag = "Salesman"
        Me._ChkDu_12.Text = "Tài khoản"
        Me._ChkDu_12.UseVisualStyleBackColor = False
        '
        '_txtShTk_9
        '
        Me._txtShTk_9.AcceptsReturn = True
        Me._txtShTk_9.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_9.Location = New System.Drawing.Point(192, 115)
        Me._txtShTk_9.MaxLength = 12
        Me._txtShTk_9.Name = "_txtShTk_9"
        Me._txtShTk_9.Size = New System.Drawing.Size(73, 20)
        Me._txtShTk_9.TabIndex = 46
        Me._txtShTk_9.Tag = "0"
        '
        '_cmdkh_2
        '
        Me._cmdkh_2.Image = CType(resources.GetObject("_cmdkh_2.Image"), System.Drawing.Image)
        Me._cmdkh_2.Location = New System.Drawing.Point(272, 15)
        Me._cmdkh_2.Name = "_cmdkh_2"
        Me._cmdkh_2.Size = New System.Drawing.Size(23, 22)
        Me._cmdkh_2.TabIndex = 37
        '
        '_cmd_0
        '
        Me._cmd_0.Image = CType(resources.GetObject("_cmd_0.Image"), System.Drawing.Image)
        Me._cmd_0.Location = New System.Drawing.Point(272, 91)
        Me._cmd_0.Name = "_cmd_0"
        Me._cmd_0.Size = New System.Drawing.Size(23, 22)
        Me._cmd_0.TabIndex = 44
        '
        '_cmdtk_9
        '
        Me._cmdtk_9.Image = CType(resources.GetObject("_cmdtk_9.Image"), System.Drawing.Image)
        Me._cmdtk_9.Location = New System.Drawing.Point(272, 115)
        Me._cmdtk_9.Name = "_cmdtk_9"
        Me._cmdtk_9.Size = New System.Drawing.Size(23, 22)
        Me._cmdtk_9.TabIndex = 47
        '
        '_lb_0
        '
        Me._lb_0.BackColor = System.Drawing.Color.Transparent
        Me._lb_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lb_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lb_0.ForeColor = System.Drawing.Color.Blue
        Me._lb_0.Location = New System.Drawing.Point(304, 92)
        Me._lb_0.Name = "_lb_0"
        Me._lb_0.Size = New System.Drawing.Size(225, 17)
        Me._lb_0.TabIndex = 73
        Me._lb_0.Tag = "1"
        '
        '_LbTenTk_9
        '
        Me._LbTenTk_9.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_9.Enabled = False
        Me._LbTenTk_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_9.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_9.Location = New System.Drawing.Point(304, 116)
        Me._LbTenTk_9.Name = "_LbTenTk_9"
        Me._LbTenTk_9.Size = New System.Drawing.Size(225, 17)
        Me._LbTenTk_9.TabIndex = 72
        Me._LbTenTk_9.Tag = "1"
        '
        '_lbkh_2
        '
        Me._lbkh_2.BackColor = System.Drawing.Color.Transparent
        Me._lbkh_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbkh_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbkh_2.ForeColor = System.Drawing.Color.Blue
        Me._lbkh_2.Location = New System.Drawing.Point(304, 16)
        Me._lbkh_2.Name = "_lbkh_2"
        Me._lbkh_2.Size = New System.Drawing.Size(225, 17)
        Me._lbkh_2.TabIndex = 71
        Me._lbkh_2.Tag = "1"
        '
        '_txtShTk_15
        '
        Me._txtShTk_15.AcceptsReturn = True
        Me._txtShTk_15.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_15.Location = New System.Drawing.Point(256, 104)
        Me._txtShTk_15.MaxLength = 12
        Me._txtShTk_15.Name = "_txtShTk_15"
        Me._txtShTk_15.Size = New System.Drawing.Size(73, 20)
        Me._txtShTk_15.TabIndex = 23
        Me._txtShTk_15.Tag = "0"
        '
        '_ChkDu_15
        '
        Me._ChkDu_15.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_15.Location = New System.Drawing.Point(176, 104)
        Me._ChkDu_15.Name = "_ChkDu_15"
        Me._ChkDu_15.Size = New System.Drawing.Size(89, 17)
        Me._ChkDu_15.TabIndex = 22
        Me._ChkDu_15.Tag = "Acc"
        Me._ChkDu_15.Text = "Tài khoản"
        Me._ChkDu_15.UseVisualStyleBackColor = False
        '
        'CboTL
        '
        Me.CboTL.BackColor = System.Drawing.SystemColors.Window
        Me.CboTL.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboTL.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTL.DropDownWidth = 53
        Me.CboTL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTL.Location = New System.Drawing.Point(216, 56)
        Me.CboTL.Name = "CboTL"
        Me.CboTL.Size = New System.Drawing.Size(57, 21)
        Me.CboTL.TabIndex = 21
        '
        '_OptBC_3
        '
        Me._OptBC_3.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_3.Location = New System.Drawing.Point(8, 80)
        Me._OptBC_3.Name = "_OptBC_3"
        Me._OptBC_3.Size = New System.Drawing.Size(161, 17)
        Me._OptBC_3.TabIndex = 3
        Me._OptBC_3.TabStop = True
        Me._OptBC_3.Tag = "VAT Input Table"
        Me._OptBC_3.Text = "Bảng kê hoá đơn đầu vào"
        Me._OptBC_3.UseVisualStyleBackColor = False
        '
        '_OptBC_2
        '
        Me._OptBC_2.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_2.Location = New System.Drawing.Point(8, 56)
        Me._OptBC_2.Name = "_OptBC_2"
        Me._OptBC_2.Size = New System.Drawing.Size(161, 17)
        Me._OptBC_2.TabIndex = 2
        Me._OptBC_2.TabStop = True
        Me._OptBC_2.Tag = "VAT Ouput Table"
        Me._OptBC_2.Text = "Bảng kê hoá đơn  đầu ra"
        Me._OptBC_2.UseVisualStyleBackColor = False
        '
        '_OptBC_16
        '
        Me._OptBC_16.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_16.Location = New System.Drawing.Point(8, 128)
        Me._OptBC_16.Name = "_OptBC_16"
        Me._OptBC_16.Size = New System.Drawing.Size(161, 17)
        Me._OptBC_16.TabIndex = 5
        Me._OptBC_16.TabStop = True
        Me._OptBC_16.Tag = "Profit and Lost"
        Me._OptBC_16.Text = "Báo cáo kết quả kinh doanh"
        Me._OptBC_16.UseVisualStyleBackColor = False
        '
        '_ChkDu_16
        '
        Me._ChkDu_16.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_16.Location = New System.Drawing.Point(543, 200)
        Me._ChkDu_16.Name = "_ChkDu_16"
        Me._ChkDu_16.Size = New System.Drawing.Size(88, 17)
        Me._ChkDu_16.TabIndex = 54
        Me._ChkDu_16.Tag = "Resource"
        Me._ChkDu_16.Text = "&Hiển thị lưới"
        Me._ChkDu_16.UseVisualStyleBackColor = False
        '
        '_Command_3
        '
        Me._Command_3.Image = CType(resources.GetObject("_Command_3.Image"), System.Drawing.Image)
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(552, 496)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(81, 25)
        Me._Command_3.TabIndex = 57
        Me._Command_3.Text = "&Xuất Excel"
        '
        '_Command_2
        '
        Me._Command_2.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(552, 528)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(81, 25)
        Me._Command_2.TabIndex = 58
        Me._Command_2.Text = "Trở &về"
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Print
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(552, 464)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(81, 25)
        Me._Command_1.TabIndex = 56
        Me._Command_1.Text = "&In"
        '
        '_Command_0
        '
        Me._Command_0.Image = CType(resources.GetObject("_Command_0.Image"), System.Drawing.Image)
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(552, 432)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(81, 25)
        Me._Command_0.TabIndex = 55
        Me._Command_0.Text = "&Xem"
        '
        'GauGe
        '
        Me.GauGe.Location = New System.Drawing.Point(552, 408)
        Me.GauGe.Name = "GauGe"
        Me.GauGe.Size = New System.Drawing.Size(80, 17)
        Me.GauGe.TabIndex = 59
        '
        '_cmdtk_15
        '
        Me._cmdtk_15.Location = New System.Drawing.Point(336, 103)
        Me._cmdtk_15.Name = "_cmdtk_15"
        Me._cmdtk_15.Size = New System.Drawing.Size(23, 22)
        Me._cmdtk_15.TabIndex = 24
        '
        '_cmdtk_3
        '
        Me._cmdtk_3.Image = CType(resources.GetObject("_cmdtk_3.Image"), System.Drawing.Image)
        Me._cmdtk_3.Location = New System.Drawing.Point(336, 223)
        Me._cmdtk_3.Name = "_cmdtk_3"
        Me._cmdtk_3.Size = New System.Drawing.Size(23, 22)
        Me._cmdtk_3.TabIndex = 31
        '
        '_cmdtk_0
        '
        Me._cmdtk_0.Image = CType(resources.GetObject("_cmdtk_0.Image"), System.Drawing.Image)
        Me._cmdtk_0.Location = New System.Drawing.Point(336, 175)
        Me._cmdtk_0.Name = "_cmdtk_0"
        Me._cmdtk_0.Size = New System.Drawing.Size(23, 22)
        Me._cmdtk_0.TabIndex = 28
        '
        '_Frame_2
        '
        Me._Frame_2.BackColor = System.Drawing.Color.Transparent
        Me._Frame_2.Controls.Add(Me._OptTG_0)
        Me._Frame_2.Controls.Add(Me._OptTG_1)
        Me._Frame_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_2.Location = New System.Drawing.Point(542, 8)
        Me._Frame_2.Name = "_Frame_2"
        Me._Frame_2.Size = New System.Drawing.Size(91, 57)
        Me._Frame_2.TabIndex = 66
        Me._Frame_2.TabStop = False
        '
        '_OptTG_0
        '
        Me._OptTG_0.BackColor = System.Drawing.Color.Transparent
        Me._OptTG_0.Checked = True
        Me._OptTG_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptTG_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptTG_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptTG_0.Location = New System.Drawing.Point(5, 15)
        Me._OptTG_0.Name = "_OptTG_0"
        Me._OptTG_0.Size = New System.Drawing.Size(82, 17)
        Me._OptTG_0.TabIndex = 48
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
        Me._OptTG_1.Location = New System.Drawing.Point(5, 34)
        Me._OptTG_1.Name = "_OptTG_1"
        Me._OptTG_1.Size = New System.Drawing.Size(82, 17)
        Me._OptTG_1.TabIndex = 49
        Me._OptTG_1.TabStop = True
        Me._OptTG_1.Tag = "By date"
        Me._OptTG_1.Text = "Theo ngày"
        Me._OptTG_1.UseVisualStyleBackColor = False
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
        Me._Frame_1.Location = New System.Drawing.Point(542, 74)
        Me._Frame_1.Name = "_Frame_1"
        Me._Frame_1.Size = New System.Drawing.Size(91, 113)
        Me._Frame_1.TabIndex = 63
        Me._Frame_1.TabStop = False
        Me._Frame_1.Visible = False
        '
        '_MedNgay_0
        '
        Me._MedNgay_0.AllowPromptAsInput = False
        Me._MedNgay_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_0.Location = New System.Drawing.Point(14, 32)
        Me._MedNgay_0.Mask = "00/00/0000"
        Me._MedNgay_0.Name = "_MedNgay_0"
        Me._MedNgay_0.Size = New System.Drawing.Size(63, 20)
        Me._MedNgay_0.TabIndex = 50
        '
        '_MedNgay_1
        '
        Me._MedNgay_1.AllowPromptAsInput = False
        Me._MedNgay_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_1.Location = New System.Drawing.Point(14, 80)
        Me._MedNgay_1.Mask = "00/00/0000"
        Me._MedNgay_1.Name = "_MedNgay_1"
        Me._MedNgay_1.Size = New System.Drawing.Size(63, 20)
        Me._MedNgay_1.TabIndex = 51
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.Transparent
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_5.Location = New System.Drawing.Point(8, 64)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(57, 17)
        Me._Label_5.TabIndex = 65
        Me._Label_5.Tag = "to"
        Me._Label_5.Text = "Đến ngày"
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.Transparent
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_4.Location = New System.Drawing.Point(8, 16)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(57, 17)
        Me._Label_4.TabIndex = 64
        Me._Label_4.Tag = "FROM"
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
        Me._Frame_0.Location = New System.Drawing.Point(543, 71)
        Me._Frame_0.Name = "_Frame_0"
        Me._Frame_0.Size = New System.Drawing.Size(90, 113)
        Me._Frame_0.TabIndex = 60
        Me._Frame_0.TabStop = False
        '
        '_CboThang_0
        '
        Me._CboThang_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_0.Location = New System.Drawing.Point(8, 32)
        Me._CboThang_0.Name = "_CboThang_0"
        Me._CboThang_0.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_0.TabIndex = 52
        '
        '_CboThang_1
        '
        Me._CboThang_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_1.Location = New System.Drawing.Point(8, 80)
        Me._CboThang_1.Name = "_CboThang_1"
        Me._CboThang_1.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_1.TabIndex = 53
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(8, 16)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(78, 17)
        Me._Label_0.TabIndex = 62
        Me._Label_0.Tag = "FROM"
        Me._Label_0.Text = "Từ tháng"
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(8, 64)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(69, 17)
        Me._Label_1.TabIndex = 61
        Me._Label_1.Tag = "to"
        Me._Label_1.Text = "Đến tháng"
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.Transparent
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_3.Location = New System.Drawing.Point(368, 152)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(33, 17)
        Me._Label_3.TabIndex = 76
        Me._Label_3.Tag = "Rate (%)"
        Me._Label_3.Text = "Cấp"
        '
        '_LbTenTk_0
        '
        Me._LbTenTk_0.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_0.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_0.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_0.Location = New System.Drawing.Point(368, 176)
        Me._LbTenTk_0.Name = "_LbTenTk_0"
        Me._LbTenTk_0.Size = New System.Drawing.Size(169, 17)
        Me._LbTenTk_0.TabIndex = 75
        Me._LbTenTk_0.Tag = "1"
        '
        '_LbTenTk_3
        '
        Me._LbTenTk_3.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_3.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_3.Location = New System.Drawing.Point(368, 224)
        Me._LbTenTk_3.Name = "_LbTenTk_3"
        Me._LbTenTk_3.Size = New System.Drawing.Size(169, 17)
        Me._LbTenTk_3.TabIndex = 74
        Me._LbTenTk_3.Tag = "1"
        '
        '_LbTenTk_15
        '
        Me._LbTenTk_15.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_15.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_15.Location = New System.Drawing.Point(368, 104)
        Me._LbTenTk_15.Name = "_LbTenTk_15"
        Me._LbTenTk_15.Size = New System.Drawing.Size(169, 17)
        Me._LbTenTk_15.TabIndex = 68
        Me._LbTenTk_15.Tag = "1"
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.Transparent
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(176, 56)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(41, 17)
        Me._Label_2.TabIndex = 67
        Me._Label_2.Tag = "Rate (%)"
        Me._Label_2.Text = "Tỷ lệ %"
        '
        'FrmMNBaocaobh
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(638, 561)
        Me.Controls.Add(Me._ChkDu_3)
        Me.Controls.Add(Me.CboVV)
        Me.Controls.Add(Me._OptBC_1)
        Me.Controls.Add(Me._OptBC_9)
        Me.Controls.Add(Me.cboQuy)
        Me.Controls.Add(Me._OptBC_6)
        Me.Controls.Add(Me._OptBC_11)
        Me.Controls.Add(Me._OptBC_12)
        Me.Controls.Add(Me._txtShTk_0)
        Me.Controls.Add(Me.Chk1)
        Me.Controls.Add(Me.CboCap)
        Me.Controls.Add(Me._OptBC_19)
        Me.Controls.Add(Me._OptBC_21)
        Me.Controls.Add(Me._txtShTk_3)
        Me.Controls.Add(Me._OptBC_0)
        Me.Controls.Add(Me._OptBC_8)
        Me.Controls.Add(Me._OptBC_10)
        Me.Controls.Add(Me._OptBC_5)
        Me.Controls.Add(Me._OptBC_4)
        Me.Controls.Add(Me._ChkDu_1)
        Me.Controls.Add(Me.CboThuchi)
        Me.Controls.Add(Me._OptBC_23)
        Me.Controls.Add(Me._OptBC_7)
        Me.Controls.Add(Me._Frame2_5)
        Me.Controls.Add(Me._txtShTk_15)
        Me.Controls.Add(Me._ChkDu_15)
        Me.Controls.Add(Me.CboTL)
        Me.Controls.Add(Me._OptBC_3)
        Me.Controls.Add(Me._OptBC_2)
        Me.Controls.Add(Me._OptBC_16)
        Me.Controls.Add(Me._ChkDu_16)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me.GauGe)
        Me.Controls.Add(Me._cmdtk_15)
        Me.Controls.Add(Me._cmdtk_3)
        Me.Controls.Add(Me._cmdtk_0)
        Me.Controls.Add(Me._Frame_2)
        Me.Controls.Add(Me._Frame_1)
        Me.Controls.Add(Me._Frame_0)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._LbTenTk_0)
        Me.Controls.Add(Me._LbTenTk_3)
        Me.Controls.Add(Me._LbTenTk_15)
        Me.Controls.Add(Me._Label_2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(4, 30)
        Me.MaximizeBox = False
        Me.Name = "FrmMNBaocaobh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Báo cáo"
        Me._Frame2_5.ResumeLayout(False)
        Me._Frame2_5.PerformLayout()
        Me._Frame_2.ResumeLayout(False)
        Me._Frame_1.ResumeLayout(False)
        Me._Frame_1.PerformLayout()
        Me._Frame_0.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub Initializetxtshkh()
		Me.txtshkh(2) = _txtshkh_2
	End Sub
	Sub Initializetxtsh()
		Me.txtsh(0) = _txtsh_0
	End Sub
	Sub InitializetxtShTk()
		Me.txtShTk(0) = _txtShTk_0
		Me.txtShTk(3) = _txtShTk_3
		Me.txtShTk(9) = _txtShTk_9
		Me.txtShTk(15) = _txtShTk_15
	End Sub
	Sub Initializelbkh()
		Me.lbkh(2) = _lbkh_2
	End Sub
	Sub Initializelb()
		Me.lb(0) = _lb_0
	End Sub
	Sub Initializecmdtk()
		Me.cmdtk(9) = _cmdtk_9
		Me.cmdtk(15) = _cmdtk_15
		Me.cmdtk(3) = _cmdtk_3
		Me.cmdtk(0) = _cmdtk_0
	End Sub
	Sub Initializecmdkh()
		Me.cmdkh(2) = _cmdkh_2
	End Sub
	Sub Initializecmd()
		Me.cmd(0) = _cmd_0
	End Sub
	Sub InitializeOptTG()
		Me.OptTG(0) = _OptTG_0
		Me.OptTG(1) = _OptTG_1
	End Sub
	Sub InitializeOptDT()
		Me.OptDT(2) = _OptDT_2
		Me.OptDT(0) = _OptDT_0
		Me.OptDT(1) = _OptDT_1
	End Sub
	Sub InitializeOptBC()
		Me.OptBC(1) = _OptBC_1
		Me.OptBC(9) = _OptBC_9
		Me.OptBC(6) = _OptBC_6
		Me.OptBC(11) = _OptBC_11
		Me.OptBC(12) = _OptBC_12
		Me.OptBC(19) = _OptBC_19
		Me.OptBC(21) = _OptBC_21
		Me.OptBC(0) = _OptBC_0
		Me.OptBC(8) = _OptBC_8
		Me.OptBC(10) = _OptBC_10
		Me.OptBC(5) = _OptBC_5
		Me.OptBC(4) = _OptBC_4
		Me.OptBC(23) = _OptBC_23
		Me.OptBC(7) = _OptBC_7
		Me.OptBC(3) = _OptBC_3
		Me.OptBC(2) = _OptBC_2
		Me.OptBC(16) = _OptBC_16
	End Sub
	Sub InitializeMedNgay()
		Me.MedNgay(0) = _MedNgay_0
		Me.MedNgay(1) = _MedNgay_1
	End Sub
	Sub InitializeLbTenTk()
		Me.LbTenTk(9) = _LbTenTk_9
		Me.LbTenTk(0) = _LbTenTk_0
		Me.LbTenTk(3) = _LbTenTk_3
		Me.LbTenTk(15) = _LbTenTk_15
	End Sub
	Sub InitializeLabel()
		Me.Label(5) = _Label_5
		Me.Label(4) = _Label_4
		Me.Label(0) = _Label_0
		Me.Label(1) = _Label_1
		Me.Label(3) = _Label_3
		Me.Label(2) = _Label_2
	End Sub
	Sub InitializeFrame2()
		Me.Frame2(5) = _Frame2_5
	End Sub
	Sub InitializeFrame()
		Me.Frame(2) = _Frame_2
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
		Me.ChkDu(3) = _ChkDu_3
		Me.ChkDu(1) = _ChkDu_1
		Me.ChkDu(13) = _ChkDu_13
		Me.ChkDu(18) = _ChkDu_18
		Me.ChkDu(9) = _ChkDu_9
		Me.ChkDu(19) = _ChkDu_19
		Me.ChkDu(17) = _ChkDu_17
		Me.ChkDu(12) = _ChkDu_12
		Me.ChkDu(15) = _ChkDu_15
		Me.ChkDu(16) = _ChkDu_16
	End Sub
	Sub InitializeCboThang()
		Me.CboThang(0) = _CboThang_0
		Me.CboThang(1) = _CboThang_1
	End Sub
	Sub InitializeCboKho()
		Me.CboKho(2) = _CboKho_2
		Me.CboKho(1) = _CboKho_1
	End Sub
#End Region 
End Class
