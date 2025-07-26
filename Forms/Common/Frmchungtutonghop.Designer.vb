<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChungtutonghop
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
        isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		Initializetxtsh()
		Initializetxtchungtu()
		Initializetxt()
		Initializemnpt()
		Initializemnpc()
		Initializemndd()
		InitializemnPU()
		InitializemnNhap()
		InitializemnIn()
		Initializelb()
		Initializecmd()
		InitializeOptNhap()
		InitializeOptLoai()
		InitializeMedNgay()
		InitializeLine1()
		InitializeLbTT()
		InitializeLbKho()
		InitializeLabel()
		InitializeCommand()
		InitializeCmdPhieu()
		InitializeCmdDanhSach1()
		InitializeCmdDanhSach()
		InitializeCboVV()
		InitializeCboNguon()
		InitializeCboNT()
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
	Private WithEvents _mndd_0 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_1 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_2 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_3 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents _mndd_4 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_5 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_6 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_7 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_8 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_9 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_10 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_11 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents _mndd_12 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_13 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_14 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_15 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnNhap_0 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnNhap_1 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnNhap_2 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnNhap_3 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnNhap_4 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnNhap_5 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnNhap_6 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnNhap_7 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnNhap_8 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnNhap_9 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnNhap_10 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnNhap_11 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnNhap_12 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_16 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_17 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents _mndd_18 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_19 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_20 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_21 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_22 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents _mndd_23 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_24 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnPU_0 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnpt_0 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnpt_1 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnIn_0 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnpc_0 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnpc_1 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnIn_1 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnIn_2 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnIn_3 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnIn_4 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnIn_5 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnIn_6 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents _mnIn_7 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnIn_8 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnIn_9 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnPU_1 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Private WithEvents _txt_5 As System.Windows.Forms.TextBox
	Private WithEvents _txt_4 As System.Windows.Forms.TextBox
	Public WithEvents CmdChitiet As System.Windows.Forms.Button
	Private WithEvents _OptLoai_14 As System.Windows.Forms.RadioButton
	Private WithEvents _OptLoai_13 As System.Windows.Forms.RadioButton
	Private WithEvents _OptLoai_8 As System.Windows.Forms.RadioButton
	Private WithEvents _OptLoai_11 As System.Windows.Forms.RadioButton
	Private WithEvents _OptLoai_10 As System.Windows.Forms.RadioButton
    Private WithEvents _OptLoai_0 As System.Windows.Forms.RadioButton
	Private WithEvents _OptLoai_1 As System.Windows.Forms.RadioButton
	Private WithEvents _OptLoai_2 As System.Windows.Forms.RadioButton
	Private WithEvents _OptLoai_3 As System.Windows.Forms.RadioButton
	Private WithEvents _OptLoai_12 As System.Windows.Forms.RadioButton
	Private WithEvents _OptLoai_4 As System.Windows.Forms.RadioButton
    Public WithEvents CmdThemTK As System.Windows.Forms.Button
    Public WithEvents ChkTudong As System.Windows.Forms.CheckBox
    Private WithEvents _OptNhap_1 As System.Windows.Forms.RadioButton
    Private WithEvents _OptNhap_0 As System.Windows.Forms.RadioButton
    Private WithEvents _OptNhap_2 As System.Windows.Forms.RadioButton
    Public WithEvents CboCo As ComboBoxEx.ComboBoxExt
    Public WithEvents CboNo As ComboBoxEx.ComboBoxExt
    Private WithEvents _Label_26 As System.Windows.Forms.Label
    Private WithEvents _Label_27 As System.Windows.Forms.Label
    Public WithEvents FNhap As System.Windows.Forms.GroupBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Private WithEvents _cmd_0 As System.Windows.Forms.Button
    Private WithEvents _cmd_1 As System.Windows.Forms.Button
    Private WithEvents _txtsh_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtsh_0 As System.Windows.Forms.TextBox
    Private WithEvents _lb_1 As System.Windows.Forms.Label
    Private WithEvents _lb_0 As System.Windows.Forms.Label
    Private WithEvents _Label_19 As System.Windows.Forms.Label
    Private WithEvents _Label_18 As System.Windows.Forms.Label
    Public WithEvents Frame As System.Windows.Forms.GroupBox
    Private WithEvents _CboNT_3 As ComboBoxEx.ComboBoxExt
    Public WithEvents SSCmdV As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_4 As System.Windows.Forms.Button
    Public WithEvents CmdBC As System.Windows.Forms.Button
    Private WithEvents _CmdPhieu_0 As System.Windows.Forms.Button
    Private WithEvents _CmdPhieu_1 As System.Windows.Forms.Button
    Private WithEvents _CmdPhieu_2 As System.Windows.Forms.Button
    Private WithEvents _CmdPhieu_3 As System.Windows.Forms.Button
    Private WithEvents _CmdDanhSach_0 As System.Windows.Forms.Button
    Public WithEvents CboDoituong As ComboBoxEx.ComboBoxExt
    Public WithEvents chkXT As System.Windows.Forms.CheckBox
    Public WithEvents ChkDoiTuong As System.Windows.Forms.CheckBox
    Public WithEvents CboThang1 As ComboBoxEx.ComboBoxExt
    Public WithEvents ChkHNT As System.Windows.Forms.CheckBox
    Private WithEvents _CboVV_2 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboVV_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboVV_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _txtchungtu_11 As System.Windows.Forms.TextBox
    Private WithEvents _txtchungtu_10 As System.Windows.Forms.TextBox
    Private WithEvents _txtchungtu_9 As System.Windows.Forms.TextBox
    Private WithEvents _txtchungtu_8 As System.Windows.Forms.TextBox
    Private WithEvents _txt_3 As System.Windows.Forms.TextBox
    Public WithEvents Chk As System.Windows.Forms.CheckBox
    Private WithEvents _txtchungtu_7 As System.Windows.Forms.TextBox
    Private WithEvents _txt_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtchungtu_6 As System.Windows.Forms.TextBox
    Private WithEvents _CboNguon_3 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboNT_2 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboNT_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CmdDanhSach1_0 As System.Windows.Forms.Button
    Private WithEvents _CboNT_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboNguon_2 As ComboBoxEx.ComboBoxExt
    Public WithEvents GrdChungtu As ListViewEx.ListviewExt
    Public WithEvents SSCmdV1 As System.Windows.Forms.Button
    Public WithEvents CboThang As ComboBoxEx.ComboBoxExt
    Private WithEvents _txt_0 As System.Windows.Forms.TextBox
    Private WithEvents _txt_1 As System.Windows.Forms.TextBox
    Private WithEvents _CboNguon_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboNguon_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _txtchungtu_5 As System.Windows.Forms.TextBox
    Private WithEvents _txtchungtu_4 As System.Windows.Forms.TextBox
    Private WithEvents _txtchungtu_3 As System.Windows.Forms.TextBox
    Private WithEvents _txtchungtu_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtchungtu_0 As System.Windows.Forms.TextBox
    Private WithEvents _txtchungtu_1 As System.Windows.Forms.TextBox
    Private WithEvents _MedNgay_0 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _MedNgay_1 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _CmdDanhSach_1 As System.Windows.Forms.Button
    Private WithEvents _CmdDanhSach1_1 As System.Windows.Forms.Button
    Private WithEvents _Command_5 As System.Windows.Forms.Button
    Private WithEvents _Label_29 As System.Windows.Forms.Label
    Public WithEvents LBKH As System.Windows.Forms.Label
    Public WithEvents Nut As System.Windows.Forms.Label
    Public WithEvents loai1 As System.Windows.Forms.Label
    Public WithEvents loaino As System.Windows.Forms.Label
    Private WithEvents _Label_28 As System.Windows.Forms.Label
    Private WithEvents _LbTT_2 As System.Windows.Forms.Label
    Private WithEvents _LbTT_1 As System.Windows.Forms.Label
    Private WithEvents _LbTT_0 As System.Windows.Forms.Label
    Private WithEvents _Label_25 As System.Windows.Forms.Label
    Private WithEvents _Label_24 As System.Windows.Forms.Label
    Private WithEvents _Label_23 As System.Windows.Forms.Label
    Private WithEvents _Label_22 As System.Windows.Forms.Label
    Private WithEvents _Label_21 As System.Windows.Forms.Label
    Public WithEvents LBNV As System.Windows.Forms.Label
    Private WithEvents _Label_20 As System.Windows.Forms.Label
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Private WithEvents _Label_16 As System.Windows.Forms.Label
    Public WithEvents LbUser As System.Windows.Forms.Label
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _Label_15 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Private WithEvents _Line1_3 As System.Windows.Forms.Label
    Private WithEvents _Line1_2 As System.Windows.Forms.Label
    Private WithEvents _Line1_1 As System.Windows.Forms.Label
    Private WithEvents _Line1_0 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _LbKho_0 As System.Windows.Forms.Label
    Private WithEvents _LbKho_1 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Label_9 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Public CboNT(3) As ComboBoxEx.ComboBoxExt
    Public CboNguon(3) As ComboBoxEx.ComboBoxExt
    Public CboVV(2) As ComboBoxEx.ComboBoxExt
    Public CmdDanhSach(1) As System.Windows.Forms.Button
    Public CmdDanhSach1(1) As System.Windows.Forms.Button
    Public CmdPhieu(3) As System.Windows.Forms.Button
    Public Command(5) As System.Windows.Forms.Button
    Public Label(29) As System.Windows.Forms.Label
    Public LbKho(1) As System.Windows.Forms.Label
    Public LbTT(2) As System.Windows.Forms.Label
    Public Line1(3) As System.Windows.Forms.Label
    Public MedNgay(1) As System.Windows.Forms.MaskedTextBox
    Public OptLoai(16) As System.Windows.Forms.RadioButton
    Public OptNhap(2) As System.Windows.Forms.RadioButton
    Public cmd(1) As System.Windows.Forms.Button
    Public cmd1(1) As System.Windows.Forms.Button
    Public lb(1) As System.Windows.Forms.Label
    Public mnIn(9) As System.Windows.Forms.ToolStripMenuItem
    Public mnNhap(12) As System.Windows.Forms.ToolStripMenuItem
    Public mnPU(1) As System.Windows.Forms.ToolStripMenuItem
    Public mndd(24) As System.Windows.Forms.ToolStripMenuItem
    Public mnpc(1) As System.Windows.Forms.ToolStripMenuItem
    Public mnpt(1) As System.Windows.Forms.ToolStripMenuItem
    Public txt(5) As System.Windows.Forms.TextBox
    Public txtchungtu(11) As System.Windows.Forms.TextBox
    Public txtsh(1) As System.Windows.Forms.TextBox
    'Private listBoxComboBoxHelper1 As Artinsoft.VB6.Gui.ListControlHelper
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChungtutonghop))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.CmdChitiet = New System.Windows.Forms.Button
        Me._OptLoai_14 = New System.Windows.Forms.RadioButton
        Me._OptLoai_13 = New System.Windows.Forms.RadioButton
        Me._OptLoai_11 = New System.Windows.Forms.RadioButton
        Me._OptLoai_10 = New System.Windows.Forms.RadioButton
        Me._OptLoai_9 = New System.Windows.Forms.RadioButton
        Me._OptLoai_12 = New System.Windows.Forms.RadioButton
        Me._CboNT_3 = New ComboBoxEx.ComboBoxExt
        Me._CboNT_2 = New ComboBoxEx.ComboBoxExt
        Me._CboNT_1 = New ComboBoxEx.ComboBoxExt
        Me._CboNT_0 = New ComboBoxEx.ComboBoxExt
        Me._txtchungtu_2 = New System.Windows.Forms.TextBox
        Me._txtchungtu_0 = New System.Windows.Forms.TextBox
        Me._OptLoai_0 = New System.Windows.Forms.RadioButton
        Me._OptLoai_15 = New System.Windows.Forms.RadioButton
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip
        Me._mnPU_0 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_0 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_1 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_2 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_3 = New System.Windows.Forms.ToolStripSeparator
        Me._mndd_4 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_5 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_6 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_7 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_8 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_9 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_10 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_11 = New System.Windows.Forms.ToolStripSeparator
        Me._mndd_12 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_13 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_14 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_15 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_16 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnNhap_0 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnNhap_1 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnNhap_2 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnNhap_3 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnNhap_4 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnNhap_5 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnNhap_6 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnNhap_7 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnNhap_8 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnNhap_9 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnNhap_10 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnNhap_11 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnNhap_12 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_17 = New System.Windows.Forms.ToolStripSeparator
        Me._mndd_18 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_19 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_20 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_21 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_22 = New System.Windows.Forms.ToolStripSeparator
        Me._mndd_23 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_24 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnPU_1 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnIn_0 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnpt_0 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnpt_1 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnIn_1 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnpc_0 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnpc_1 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnIn_2 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnIn_3 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnIn_4 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnIn_5 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnIn_6 = New System.Windows.Forms.ToolStripSeparator
        Me._mnIn_7 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnIn_8 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnIn_9 = New System.Windows.Forms.ToolStripMenuItem
        Me._txt_5 = New System.Windows.Forms.TextBox
        Me._txt_4 = New System.Windows.Forms.TextBox
        Me._OptLoai_8 = New System.Windows.Forms.RadioButton
        Me._OptLoai_1 = New System.Windows.Forms.RadioButton
        Me._OptLoai_2 = New System.Windows.Forms.RadioButton
        Me._OptLoai_3 = New System.Windows.Forms.RadioButton
        Me._OptLoai_4 = New System.Windows.Forms.RadioButton
        Me.CmdThemTK = New System.Windows.Forms.Button
        Me.ChkTudong = New System.Windows.Forms.CheckBox
        Me.FNhap = New System.Windows.Forms.GroupBox
        Me._OptNhap_1 = New System.Windows.Forms.RadioButton
        Me._OptNhap_0 = New System.Windows.Forms.RadioButton
        Me._OptNhap_2 = New System.Windows.Forms.RadioButton
        Me.CboCo = New ComboBoxEx.ComboBoxExt
        Me.CboNo = New ComboBoxEx.ComboBoxExt
        Me._Label_26 = New System.Windows.Forms.Label
        Me._Label_27 = New System.Windows.Forms.Label
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.Frame = New System.Windows.Forms.GroupBox
        Me._cmd_0 = New System.Windows.Forms.Button
        Me._cmd_1 = New System.Windows.Forms.Button
        Me._txtsh_1 = New System.Windows.Forms.TextBox
        Me._txtsh_0 = New System.Windows.Forms.TextBox
        Me._lb_1 = New System.Windows.Forms.Label
        Me._lb_0 = New System.Windows.Forms.Label
        Me._Label_19 = New System.Windows.Forms.Label
        Me._Label_18 = New System.Windows.Forms.Label
        Me.SSCmdV = New System.Windows.Forms.Button
        Me._CmdPhieu_0 = New System.Windows.Forms.Button
        Me._CmdPhieu_1 = New System.Windows.Forms.Button
        Me._CmdPhieu_2 = New System.Windows.Forms.Button
        Me._CmdPhieu_3 = New System.Windows.Forms.Button
        Me.CboDoituong = New ComboBoxEx.ComboBoxExt
        Me.chkXT = New System.Windows.Forms.CheckBox
        Me.ChkDoiTuong = New System.Windows.Forms.CheckBox
        Me.CboThang1 = New ComboBoxEx.ComboBoxExt
        Me.ChkHNT = New System.Windows.Forms.CheckBox
        Me._CboVV_2 = New ComboBoxEx.ComboBoxExt
        Me._CboVV_1 = New ComboBoxEx.ComboBoxExt
        Me._CboVV_0 = New ComboBoxEx.ComboBoxExt
        Me._txtchungtu_11 = New System.Windows.Forms.TextBox
        Me._txtchungtu_10 = New System.Windows.Forms.TextBox
        Me._txtchungtu_9 = New System.Windows.Forms.TextBox
        Me._txtchungtu_8 = New System.Windows.Forms.TextBox
        Me._txt_3 = New System.Windows.Forms.TextBox
        Me.Chk = New System.Windows.Forms.CheckBox
        Me._txtchungtu_7 = New System.Windows.Forms.TextBox
        Me._txt_2 = New System.Windows.Forms.TextBox
        Me._txtchungtu_6 = New System.Windows.Forms.TextBox
        Me._CboNguon_3 = New ComboBoxEx.ComboBoxExt
        Me._CboNguon_2 = New ComboBoxEx.ComboBoxExt
        Me.SSCmdV1 = New System.Windows.Forms.Button
        Me.CboThang = New ComboBoxEx.ComboBoxExt
        Me._txt_0 = New System.Windows.Forms.TextBox
        Me._txt_1 = New System.Windows.Forms.TextBox
        Me._CboNguon_1 = New ComboBoxEx.ComboBoxExt
        Me._CboNguon_0 = New ComboBoxEx.ComboBoxExt
        Me._txtchungtu_5 = New System.Windows.Forms.TextBox
        Me._txtchungtu_4 = New System.Windows.Forms.TextBox
        Me._txtchungtu_3 = New System.Windows.Forms.TextBox
        Me._txtchungtu_1 = New System.Windows.Forms.TextBox
        Me._MedNgay_0 = New System.Windows.Forms.MaskedTextBox
        Me._MedNgay_1 = New System.Windows.Forms.MaskedTextBox
        Me._Label_29 = New System.Windows.Forms.Label
        Me.LBKH = New System.Windows.Forms.Label
        Me.Nut = New System.Windows.Forms.Label
        Me.loai1 = New System.Windows.Forms.Label
        Me.loaino = New System.Windows.Forms.Label
        Me._Label_28 = New System.Windows.Forms.Label
        Me._LbTT_2 = New System.Windows.Forms.Label
        Me._LbTT_1 = New System.Windows.Forms.Label
        Me._LbTT_0 = New System.Windows.Forms.Label
        Me._Label_25 = New System.Windows.Forms.Label
        Me._Label_24 = New System.Windows.Forms.Label
        Me._Label_23 = New System.Windows.Forms.Label
        Me._Label_22 = New System.Windows.Forms.Label
        Me._Label_21 = New System.Windows.Forms.Label
        Me.LBNV = New System.Windows.Forms.Label
        Me._Label_20 = New System.Windows.Forms.Label
        Me._Label_17 = New System.Windows.Forms.Label
        Me._Label_16 = New System.Windows.Forms.Label
        Me.LbUser = New System.Windows.Forms.Label
        Me._Label_11 = New System.Windows.Forms.Label
        Me._Label_13 = New System.Windows.Forms.Label
        Me._Label_15 = New System.Windows.Forms.Label
        Me._Label_14 = New System.Windows.Forms.Label
        Me._Line1_3 = New System.Windows.Forms.Label
        Me._Line1_2 = New System.Windows.Forms.Label
        Me._Line1_1 = New System.Windows.Forms.Label
        Me._Line1_0 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Label_4 = New System.Windows.Forms.Label
        Me._LbKho_0 = New System.Windows.Forms.Label
        Me._LbKho_1 = New System.Windows.Forms.Label
        Me._Label_10 = New System.Windows.Forms.Label
        Me._Label_9 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Label_5 = New System.Windows.Forms.Label
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_4 = New System.Windows.Forms.Button
        Me.CmdBC = New System.Windows.Forms.Button
        Me._CmdDanhSach_0 = New System.Windows.Forms.Button
        Me._CmdDanhSach1_0 = New System.Windows.Forms.Button
        Me._CmdDanhSach_1 = New System.Windows.Forms.Button
        Me._CmdDanhSach1_1 = New System.Windows.Forms.Button
        Me._Command_5 = New System.Windows.Forms.Button
        Me.GrdChungtu = New ListViewEx.ListviewExt
        Me._Label_12 = New System.Windows.Forms.Label
        Me.MainMenu1.SuspendLayout()
        Me.FNhap.SuspendLayout()
        Me.Frame.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdChitiet
        '
        Me.CmdChitiet.BackColor = System.Drawing.SystemColors.Control
        Me.CmdChitiet.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdChitiet.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdChitiet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdChitiet.Image = Global.UNET.My.Resources.Resources.up16
        Me.CmdChitiet.Location = New System.Drawing.Point(811, 566)
        Me.CmdChitiet.Name = "CmdChitiet"
        Me.CmdChitiet.Size = New System.Drawing.Size(19, 21)
        Me.CmdChitiet.TabIndex = 27
        Me.CmdChitiet.Tag = -1
        Me.CmdChitiet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTipMain.SetToolTip(Me.CmdChitiet, "Ghi phát sinh")
        Me.CmdChitiet.UseVisualStyleBackColor = False
        '
        '_OptLoai_14
        '
        Me._OptLoai_14.BackColor = System.Drawing.Color.Transparent
        Me._OptLoai_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptLoai_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptLoai_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptLoai_14.Location = New System.Drawing.Point(696, 64)
        Me._OptLoai_14.Name = "_OptLoai_14"
        Me._OptLoai_14.Size = New System.Drawing.Size(117, 17)
        Me._OptLoai_14.TabIndex = 121
        Me._OptLoai_14.TabStop = True
        Me._OptLoai_14.Tag = "102"
        Me._OptLoai_14.Text = "&Phân bổ CCDC"
        Me.ToolTipMain.SetToolTip(Me._OptLoai_14, "Apportion")
        Me._OptLoai_14.UseVisualStyleBackColor = False
        '
        '_OptLoai_13
        '
        Me._OptLoai_13.BackColor = System.Drawing.Color.Transparent
        Me._OptLoai_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptLoai_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptLoai_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptLoai_13.Location = New System.Drawing.Point(176, 64)
        Me._OptLoai_13.Name = "_OptLoai_13"
        Me._OptLoai_13.Size = New System.Drawing.Size(162, 17)
        Me._OptLoai_13.TabIndex = 120
        Me._OptLoai_13.TabStop = True
        Me._OptLoai_13.Tag = "32"
        Me._OptLoai_13.Text = "Tăng &CCDC"
        Me.ToolTipMain.SetToolTip(Me._OptLoai_13, "Tools Increasing")
        Me._OptLoai_13.UseVisualStyleBackColor = False
        '
        '_OptLoai_11
        '
        Me._OptLoai_11.BackColor = System.Drawing.Color.Transparent
        Me._OptLoai_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptLoai_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptLoai_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptLoai_11.Location = New System.Drawing.Point(528, 48)
        Me._OptLoai_11.Name = "_OptLoai_11"
        Me._OptLoai_11.Size = New System.Drawing.Size(162, 17)
        Me._OptLoai_11.TabIndex = 118
        Me._OptLoai_11.TabStop = True
        Me._OptLoai_11.Tag = "34"
        Me._OptLoai_11.Text = "Đánh giá lại"
        Me.ToolTipMain.SetToolTip(Me._OptLoai_11, "Assets Revaluation")
        Me._OptLoai_11.UseVisualStyleBackColor = False
        '
        '_OptLoai_10
        '
        Me._OptLoai_10.BackColor = System.Drawing.Color.Transparent
        Me._OptLoai_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptLoai_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptLoai_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptLoai_10.Location = New System.Drawing.Point(344, 48)
        Me._OptLoai_10.Name = "_OptLoai_10"
        Me._OptLoai_10.Size = New System.Drawing.Size(178, 17)
        Me._OptLoai_10.TabIndex = 117
        Me._OptLoai_10.TabStop = True
        Me._OptLoai_10.Tag = "33"
        Me._OptLoai_10.Text = "Giả&m TSCĐ"
        Me.ToolTipMain.SetToolTip(Me._OptLoai_10, "Assets Decreasing")
        Me._OptLoai_10.UseVisualStyleBackColor = False
        '
        '_OptLoai_9
        '
        Me._OptLoai_9.BackColor = System.Drawing.Color.Transparent
        Me._OptLoai_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptLoai_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptLoai_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptLoai_9.Location = New System.Drawing.Point(176, 48)
        Me._OptLoai_9.Name = "_OptLoai_9"
        Me._OptLoai_9.Size = New System.Drawing.Size(162, 17)
        Me._OptLoai_9.TabIndex = 116
        Me._OptLoai_9.TabStop = True
        Me._OptLoai_9.Tag = "32"
        Me._OptLoai_9.Text = "Tăng T&SCĐ"
        Me.ToolTipMain.SetToolTip(Me._OptLoai_9, "Assets Increasing")
        Me._OptLoai_9.UseVisualStyleBackColor = False
        '
        '_OptLoai_12
        '
        Me._OptLoai_12.BackColor = System.Drawing.Color.Transparent
        Me._OptLoai_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptLoai_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptLoai_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptLoai_12.Location = New System.Drawing.Point(696, 48)
        Me._OptLoai_12.Name = "_OptLoai_12"
        Me._OptLoai_12.Size = New System.Drawing.Size(117, 17)
        Me._OptLoai_12.TabIndex = 111
        Me._OptLoai_12.TabStop = True
        Me._OptLoai_12.Tag = "35"
        Me._OptLoai_12.Text = "Khấu h&ao TSCĐ"
        Me.ToolTipMain.SetToolTip(Me._OptLoai_12, "Depreciation")
        Me._OptLoai_12.UseVisualStyleBackColor = False
        '
        '_CboNT_3
        '
        Me._CboNT_3.BackColor = System.Drawing.SystemColors.Window
        Me._CboNT_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboNT_3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboNT_3.DropDownWidth = 36
        Me._CboNT_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboNT_3.Location = New System.Drawing.Point(104, 566)
        Me._CboNT_3.Name = "_CboNT_3"
        Me._CboNT_3.Size = New System.Drawing.Size(217, 21)
        Me._CboNT_3.TabIndex = 15
        Me._CboNT_3.Tag = "0"
        Me._CboNT_3.Text = "CboNT"
        Me.ToolTipMain.SetToolTip(Me._CboNT_3, "Ngoại tệ phát sinh")
        Me._CboNT_3.Visible = False
        '
        '_CboNT_2
        '
        Me._CboNT_2.BackColor = System.Drawing.SystemColors.Window
        Me._CboNT_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboNT_2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboNT_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboNT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboNT_2.Location = New System.Drawing.Point(152, 590)
        Me._CboNT_2.Name = "_CboNT_2"
        Me._CboNT_2.Size = New System.Drawing.Size(89, 21)
        Me._CboNT_2.TabIndex = 17
        Me.ToolTipMain.SetToolTip(Me._CboNT_2, "Danh sách đơn vị tính")
        Me._CboNT_2.Visible = False
        '
        '_CboNT_1
        '
        Me._CboNT_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboNT_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboNT_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboNT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboNT_1.Location = New System.Drawing.Point(480, 590)
        Me._CboNT_1.Name = "_CboNT_1"
        Me._CboNT_1.Size = New System.Drawing.Size(89, 21)
        Me._CboNT_1.TabIndex = 20
        Me._CboNT_1.Text = "CboNT"
        Me.ToolTipMain.SetToolTip(Me._CboNT_1, "Đơn giá mặc định")
        Me._CboNT_1.Visible = False
        '
        '_CboNT_0
        '
        Me._CboNT_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboNT_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboNT_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboNT_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboNT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboNT_0.Location = New System.Drawing.Point(480, 590)
        Me._CboNT_0.Name = "_CboNT_0"
        Me._CboNT_0.Size = New System.Drawing.Size(89, 21)
        Me._CboNT_0.TabIndex = 29
        Me.ToolTipMain.SetToolTip(Me._CboNT_0, "Ngoại tệ phát sinh")
        Me._CboNT_0.Visible = False
        '
        '_txtchungtu_2
        '
        Me._txtchungtu_2.AcceptsReturn = True
        Me._txtchungtu_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtchungtu_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtchungtu_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtchungtu_2.Location = New System.Drawing.Point(320, 566)
        Me._txtchungtu_2.MaxLength = 20
        Me._txtchungtu_2.Name = "_txtchungtu_2"
        Me._txtchungtu_2.Size = New System.Drawing.Size(89, 20)
        Me._txtchungtu_2.TabIndex = 16
        Me._txtchungtu_2.Tag = "0"
        Me.ToolTipMain.SetToolTip(Me._txtchungtu_2, "Bấm ENTER để hiện danh sách đối tượng")
        '
        '_txtchungtu_0
        '
        Me._txtchungtu_0.AcceptsReturn = True
        Me._txtchungtu_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtchungtu_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtchungtu_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtchungtu_0.Location = New System.Drawing.Point(32, 566)
        Me._txtchungtu_0.MaxLength = 20
        Me._txtchungtu_0.Name = "_txtchungtu_0"
        Me._txtchungtu_0.Size = New System.Drawing.Size(73, 20)
        Me._txtchungtu_0.TabIndex = 14
        Me.ToolTipMain.SetToolTip(Me._txtchungtu_0, "Bấm ENTER để hiện danh sách tài khoản")
        '
        '_OptLoai_0
        '
        Me._OptLoai_0.BackColor = System.Drawing.Color.Transparent
        Me._OptLoai_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptLoai_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptLoai_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptLoai_0.Location = New System.Drawing.Point(16, 32)
        Me._OptLoai_0.Name = "_OptLoai_0"
        Me._OptLoai_0.Size = New System.Drawing.Size(154, 17)
        Me._OptLoai_0.TabIndex = 115
        Me._OptLoai_0.TabStop = True
        Me._OptLoai_0.Tag = "0"
        Me._OptLoai_0.Text = "Tổng &hợp"
        Me.ToolTipMain.SetToolTip(Me._OptLoai_0, "Common")
        Me._OptLoai_0.UseVisualStyleBackColor = False
        '
        '_OptLoai_15
        '
        Me._OptLoai_15.BackColor = System.Drawing.Color.Transparent
        Me._OptLoai_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptLoai_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptLoai_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptLoai_15.Location = New System.Drawing.Point(344, 64)
        Me._OptLoai_15.Name = "_OptLoai_15"
        Me._OptLoai_15.Size = New System.Drawing.Size(162, 17)
        Me._OptLoai_15.TabIndex = 133
        Me._OptLoai_15.TabStop = True
        Me._OptLoai_15.Tag = "32"
        Me._OptLoai_15.Text = "Giảm CCDC"
        Me.ToolTipMain.SetToolTip(Me._OptLoai_15, "Tools Increasing")
        Me._OptLoai_15.UseVisualStyleBackColor = False
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._mnPU_0, Me._mnPU_1})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(947, 24)
        Me.MainMenu1.TabIndex = 132
        '
        '_mnPU_0
        '
        Me._mnPU_0.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._mndd_0, Me._mndd_1, Me._mndd_2, Me._mndd_3, Me._mndd_4, Me._mndd_5, Me._mndd_6, Me._mndd_7, Me._mndd_8, Me._mndd_9, Me._mndd_10, Me._mndd_11, Me._mndd_12, Me._mndd_13, Me._mndd_14, Me._mndd_15, Me._mndd_16, Me._mndd_17, Me._mndd_18, Me._mndd_19, Me._mndd_20, Me._mndd_21, Me._mndd_22, Me._mndd_23, Me._mndd_24})
        Me._mnPU_0.Name = "_mnPU_0"
        Me._mnPU_0.Size = New System.Drawing.Size(74, 20)
        Me._mnPU_0.Tag = "Lists"
        Me._mnPU_0.Text = "&Danh sách"
        '
        '_mndd_0
        '
        Me._mndd_0.Name = "_mndd_0"
        Me._mndd_0.Size = New System.Drawing.Size(237, 22)
        Me._mndd_0.Tag = "Inventory classification..."
        Me._mndd_0.Text = "Phân loại vật tư, hàng hoá..."
        '
        '_mndd_1
        '
        Me._mndd_1.Name = "_mndd_1"
        Me._mndd_1.Size = New System.Drawing.Size(237, 22)
        Me._mndd_1.Tag = "Fixed Assets Classification..."
        Me._mndd_1.Text = "Phân loại tài sản cố định"
        '
        '_mndd_2
        '
        Me._mndd_2.Name = "_mndd_2"
        Me._mndd_2.Size = New System.Drawing.Size(237, 22)
        Me._mndd_2.Tag = "Receivable and Payable classification..."
        Me._mndd_2.Text = "Phân loại công nợ"
        '
        '_mndd_3
        '
        Me._mndd_3.Name = "_mndd_3"
        Me._mndd_3.Size = New System.Drawing.Size(234, 6)
        '
        '_mndd_4
        '
        Me._mndd_4.Name = "_mndd_4"
        Me._mndd_4.Size = New System.Drawing.Size(237, 22)
        Me._mndd_4.Tag = "Chart of Account..."
        Me._mndd_4.Text = "Hệ thống tài khoản"
        '
        '_mndd_5
        '
        Me._mndd_5.Name = "_mndd_5"
        Me._mndd_5.Size = New System.Drawing.Size(237, 22)
        Me._mndd_5.Tag = "Inventory List..."
        Me._mndd_5.Text = "Danh sách vật tư"
        '
        '_mndd_6
        '
        Me._mndd_6.Name = "_mndd_6"
        Me._mndd_6.Size = New System.Drawing.Size(237, 22)
        Me._mndd_6.Tag = "Fixed Asset List..."
        Me._mndd_6.Text = "Danh sách TSCĐ"
        '
        '_mndd_7
        '
        Me._mndd_7.Name = "_mndd_7"
        Me._mndd_7.Size = New System.Drawing.Size(237, 22)
        Me._mndd_7.Tag = "Receivabe and Payable List ..."
        Me._mndd_7.Text = "Danh sách công nợ"
        '
        '_mndd_8
        '
        Me._mndd_8.Name = "_mndd_8"
        Me._mndd_8.Size = New System.Drawing.Size(237, 22)
        Me._mndd_8.Tag = "List of Vouchers"
        Me._mndd_8.Text = "Danh sách chứng từ GS"
        '
        '_mndd_9
        '
        Me._mndd_9.Name = "_mndd_9"
        Me._mndd_9.Size = New System.Drawing.Size(237, 22)
        Me._mndd_9.Tag = "Other Index..."
        Me._mndd_9.Text = "Vụ việc liên quan"
        '
        '_mndd_10
        '
        Me._mndd_10.Name = "_mndd_10"
        Me._mndd_10.Size = New System.Drawing.Size(237, 22)
        Me._mndd_10.Tag = "Contract List..."
        Me._mndd_10.Text = "Hợp đồng kinh tế"
        '
        '_mndd_11
        '
        Me._mndd_11.Name = "_mndd_11"
        Me._mndd_11.Size = New System.Drawing.Size(234, 6)
        '
        '_mndd_12
        '
        Me._mndd_12.Name = "_mndd_12"
        Me._mndd_12.Size = New System.Drawing.Size(237, 22)
        Me._mndd_12.Tag = "Reporting - Accounting"
        Me._mndd_12.Text = "Báo cáo - sổ kế toán"
        '
        '_mndd_13
        '
        Me._mndd_13.Name = "_mndd_13"
        Me._mndd_13.Size = New System.Drawing.Size(237, 22)
        Me._mndd_13.Tag = "Expense reports"
        Me._mndd_13.Text = "Báo cáo chi phí"
        '
        '_mndd_14
        '
        Me._mndd_14.Name = "_mndd_14"
        Me._mndd_14.Size = New System.Drawing.Size(237, 22)
        Me._mndd_14.Tag = "Material reports"
        Me._mndd_14.Text = "Báo cáo vật tư"
        '
        '_mndd_15
        '
        Me._mndd_15.Name = "_mndd_15"
        Me._mndd_15.Size = New System.Drawing.Size(237, 22)
        Me._mndd_15.Tag = "Debts reports"
        Me._mndd_15.Text = "Báo cáo công nợ"
        '
        '_mndd_16
        '
        Me._mndd_16.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._mnNhap_0, Me._mnNhap_1, Me._mnNhap_2, Me._mnNhap_3, Me._mnNhap_4, Me._mnNhap_5, Me._mnNhap_6, Me._mnNhap_7, Me._mnNhap_8, Me._mnNhap_9, Me._mnNhap_10, Me._mnNhap_11, Me._mnNhap_12})
        Me._mndd_16.Name = "_mndd_16"
        Me._mndd_16.Size = New System.Drawing.Size(237, 22)
        Me._mndd_16.Tag = "Other documents"
        Me._mndd_16.Text = "Nhập các chứng từ khác..."
        '
        '_mnNhap_0
        '
        Me._mnNhap_0.Name = "_mnNhap_0"
        Me._mnNhap_0.Size = New System.Drawing.Size(173, 22)
        Me._mnNhap_0.Tag = "Costs"
        Me._mnNhap_0.Text = "Chi phí"
        '
        '_mnNhap_1
        '
        Me._mnNhap_1.Name = "_mnNhap_1"
        Me._mnNhap_1.Size = New System.Drawing.Size(173, 22)
        Me._mnNhap_1.Tag = "Debt collection"
        Me._mnNhap_1.Text = "Thu Nợ"
        '
        '_mnNhap_2
        '
        Me._mnNhap_2.Name = "_mnNhap_2"
        Me._mnNhap_2.Size = New System.Drawing.Size(173, 22)
        Me._mnNhap_2.Tag = "Repayment"
        Me._mnNhap_2.Text = "Trả nợ"
        '
        '_mnNhap_3
        '
        Me._mnNhap_3.Name = "_mnNhap_3"
        Me._mnNhap_3.Size = New System.Drawing.Size(173, 22)
        Me._mnNhap_3.Tag = "Purchase"
        Me._mnNhap_3.Text = "Mua hàng"
        '
        '_mnNhap_4
        '
        Me._mnNhap_4.Name = "_mnNhap_4"
        Me._mnNhap_4.Size = New System.Drawing.Size(173, 22)
        Me._mnNhap_4.Tag = "Bill"
        Me._mnNhap_4.Text = "Xuất hàng"
        '
        '_mnNhap_5
        '
        Me._mnNhap_5.Name = "_mnNhap_5"
        Me._mnNhap_5.Size = New System.Drawing.Size(173, 22)
        Me._mnNhap_5.Tag = "Sales"
        Me._mnNhap_5.Text = "Bán hàng"
        '
        '_mnNhap_6
        '
        Me._mnNhap_6.Name = "_mnNhap_6"
        Me._mnNhap_6.Size = New System.Drawing.Size(173, 22)
        Me._mnNhap_6.Tag = "Conversion"
        Me._mnNhap_6.Text = "Kết chuyển"
        '
        '_mnNhap_7
        '
        Me._mnNhap_7.Name = "_mnNhap_7"
        Me._mnNhap_7.Size = New System.Drawing.Size(173, 22)
        Me._mnNhap_7.Tag = "Assets Increasing"
        Me._mnNhap_7.Text = "Tăng tài sản"
        '
        '_mnNhap_8
        '
        Me._mnNhap_8.Name = "_mnNhap_8"
        Me._mnNhap_8.Size = New System.Drawing.Size(173, 22)
        Me._mnNhap_8.Tag = "Assets Decreasing"
        Me._mnNhap_8.Text = "Giảm tài sản"
        '
        '_mnNhap_9
        '
        Me._mnNhap_9.Name = "_mnNhap_9"
        Me._mnNhap_9.Size = New System.Drawing.Size(173, 22)
        Me._mnNhap_9.Tag = "Assets Revaluation"
        Me._mnNhap_9.Text = "Đánh giá lại tài sản"
        '
        '_mnNhap_10
        '
        Me._mnNhap_10.Name = "_mnNhap_10"
        Me._mnNhap_10.Size = New System.Drawing.Size(173, 22)
        Me._mnNhap_10.Tag = "Depreciation"
        Me._mnNhap_10.Text = "Khấu hao tài sản"
        '
        '_mnNhap_11
        '
        Me._mnNhap_11.Name = "_mnNhap_11"
        Me._mnNhap_11.Size = New System.Drawing.Size(173, 22)
        Me._mnNhap_11.Tag = "Tools Increasing"
        Me._mnNhap_11.Text = "Tăng công cụ"
        '
        '_mnNhap_12
        '
        Me._mnNhap_12.Name = "_mnNhap_12"
        Me._mnNhap_12.Size = New System.Drawing.Size(173, 22)
        Me._mnNhap_12.Tag = "Apportion"
        Me._mnNhap_12.Text = "Phân bổ công cụ"
        '
        '_mndd_17
        '
        Me._mndd_17.Name = "_mndd_17"
        Me._mndd_17.Size = New System.Drawing.Size(234, 6)
        '
        '_mndd_18
        '
        Me._mndd_18.Name = "_mndd_18"
        Me._mndd_18.Size = New System.Drawing.Size(237, 22)
        Me._mndd_18.Text = "Tra cứu chứng từ"
        '
        '_mndd_19
        '
        Me._mndd_19.Name = "_mndd_19"
        Me._mndd_19.Size = New System.Drawing.Size(237, 22)
        Me._mndd_19.Tag = "Invoice Default Code..."
        Me._mndd_19.Text = "Số hiệu chứng từ"
        '
        '_mndd_20
        '
        Me._mndd_20.Name = "_mndd_20"
        Me._mndd_20.Size = New System.Drawing.Size(237, 22)
        Me._mndd_20.Tag = "Invoice List"
        Me._mndd_20.Text = "Danh sách chứng từ"
        '
        '_mndd_21
        '
        Me._mndd_21.Name = "_mndd_21"
        Me._mndd_21.Size = New System.Drawing.Size(237, 22)
        Me._mndd_21.Tag = "Journal Ledger"
        Me._mndd_21.Text = "Nhật ký chung"
        '
        '_mndd_22
        '
        Me._mndd_22.Name = "_mndd_22"
        Me._mndd_22.Size = New System.Drawing.Size(234, 6)
        '
        '_mndd_23
        '
        Me._mndd_23.Name = "_mndd_23"
        Me._mndd_23.Size = New System.Drawing.Size(237, 22)
        Me._mndd_23.Tag = "Employee classification..."
        Me._mndd_23.Text = "Phân loại nhân viên bán hàng"
        '
        '_mndd_24
        '
        Me._mndd_24.Name = "_mndd_24"
        Me._mndd_24.Size = New System.Drawing.Size(237, 22)
        Me._mndd_24.Tag = "List of employees"
        Me._mndd_24.Text = "Danh sách nhân viên bán hàng"
        '
        '_mnPU_1
        '
        Me._mnPU_1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._mnIn_0, Me._mnIn_1, Me._mnIn_2, Me._mnIn_3, Me._mnIn_4, Me._mnIn_5, Me._mnIn_6, Me._mnIn_7, Me._mnIn_8, Me._mnIn_9})
        Me._mnPU_1.Name = "_mnPU_1"
        Me._mnPU_1.Size = New System.Drawing.Size(62, 20)
        Me._mnPU_1.Text = "In &Phiếu"
        '
        '_mnIn_0
        '
        Me._mnIn_0.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._mnpt_0, Me._mnpt_1})
        Me._mnIn_0.Name = "_mnIn_0"
        Me._mnIn_0.Size = New System.Drawing.Size(243, 22)
        Me._mnIn_0.Tag = "Print Receipt Voucher"
        Me._mnIn_0.Text = "In toàn bộ phiếu thu"
        '
        '_mnpt_0
        '
        Me._mnpt_0.Name = "_mnpt_0"
        Me._mnpt_0.Size = New System.Drawing.Size(190, 22)
        Me._mnpt_0.Tag = "One Vote Per Day"
        Me._mnpt_0.Text = "Mỗi ngày một phiếu"
        '
        '_mnpt_1
        '
        Me._mnpt_1.Name = "_mnpt_1"
        Me._mnpt_1.Size = New System.Drawing.Size(190, 22)
        Me._mnpt_1.Tag = "Every Day More Votes"
        Me._mnpt_1.Text = "Mỗi ngày nhiều phiếu"
        '
        '_mnIn_1
        '
        Me._mnIn_1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._mnpc_0, Me._mnpc_1})
        Me._mnIn_1.Name = "_mnIn_1"
        Me._mnIn_1.Size = New System.Drawing.Size(243, 22)
        Me._mnIn_1.Tag = "Print Payment Voucher"
        Me._mnIn_1.Text = "In toàn bộ phiếu chi"
        '
        '_mnpc_0
        '
        Me._mnpc_0.Name = "_mnpc_0"
        Me._mnpc_0.Size = New System.Drawing.Size(190, 22)
        Me._mnpc_0.Tag = "One Vote Per Day"
        Me._mnpc_0.Text = "Mỗi ngày một phiếu"
        '
        '_mnpc_1
        '
        Me._mnpc_1.Name = "_mnpc_1"
        Me._mnpc_1.Size = New System.Drawing.Size(190, 22)
        Me._mnpc_1.Tag = "Every Day More Votes"
        Me._mnpc_1.Text = "Mỗi ngày nhiều phiếu"
        '
        '_mnIn_2
        '
        Me._mnIn_2.Name = "_mnIn_2"
        Me._mnIn_2.Size = New System.Drawing.Size(243, 22)
        Me._mnIn_2.Tag = "Print Inventory Import Voucher"
        Me._mnIn_2.Text = "In toàn bộ phiếu nhập"
        '
        '_mnIn_3
        '
        Me._mnIn_3.Name = "_mnIn_3"
        Me._mnIn_3.Size = New System.Drawing.Size(243, 22)
        Me._mnIn_3.Tag = "Print Inventory Export Voucher"
        Me._mnIn_3.Text = "In toàn bộ phiếu xuất"
        '
        '_mnIn_4
        '
        Me._mnIn_4.Name = "_mnIn_4"
        Me._mnIn_4.Size = New System.Drawing.Size(243, 22)
        Me._mnIn_4.Tag = "Print Agricultural product import bills"
        Me._mnIn_4.Text = "In toàn bộ phiếu nhập nông sản"
        '
        '_mnIn_5
        '
        Me._mnIn_5.Name = "_mnIn_5"
        Me._mnIn_5.Size = New System.Drawing.Size(243, 22)
        Me._mnIn_5.Tag = "Unit price List"
        Me._mnIn_5.Text = "Đơn giá nhập mới nhất"
        '
        '_mnIn_6
        '
        Me._mnIn_6.Name = "_mnIn_6"
        Me._mnIn_6.Size = New System.Drawing.Size(240, 6)
        Me._mnIn_6.Visible = False
        '
        '_mnIn_7
        '
        Me._mnIn_7.Name = "_mnIn_7"
        Me._mnIn_7.Size = New System.Drawing.Size(243, 22)
        Me._mnIn_7.Text = "Thông tin chứng từ 1"
        Me._mnIn_7.Visible = False
        '
        '_mnIn_8
        '
        Me._mnIn_8.Name = "_mnIn_8"
        Me._mnIn_8.Size = New System.Drawing.Size(243, 22)
        Me._mnIn_8.Text = "Thông tin chứng từ 2"
        Me._mnIn_8.Visible = False
        '
        '_mnIn_9
        '
        Me._mnIn_9.Name = "_mnIn_9"
        Me._mnIn_9.Size = New System.Drawing.Size(243, 22)
        Me._mnIn_9.Text = "Thông tin chứng từ 3"
        Me._mnIn_9.Visible = False
        '
        '_txt_5
        '
        Me._txt_5.AcceptsReturn = True
        Me._txt_5.BackColor = System.Drawing.SystemColors.Window
        Me._txt_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_5.Location = New System.Drawing.Point(664, 232)
        Me._txt_5.MaxLength = 20
        Me._txt_5.Name = "_txt_5"
        Me._txt_5.Size = New System.Drawing.Size(129, 20)
        Me._txt_5.TabIndex = 13
        Me._txt_5.Tag = "10"
        '
        '_txt_4
        '
        Me._txt_4.AcceptsReturn = True
        Me._txt_4.BackColor = System.Drawing.SystemColors.Window
        Me._txt_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_4.Location = New System.Drawing.Point(376, 136)
        Me._txt_4.MaxLength = 20
        Me._txt_4.Name = "_txt_4"
        Me._txt_4.Size = New System.Drawing.Size(113, 20)
        Me._txt_4.TabIndex = 8
        '
        '_OptLoai_8
        '
        Me._OptLoai_8.BackColor = System.Drawing.Color.Transparent
        Me._OptLoai_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptLoai_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptLoai_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptLoai_8.Location = New System.Drawing.Point(528, 32)
        Me._OptLoai_8.Name = "_OptLoai_8"
        Me._OptLoai_8.Size = New System.Drawing.Size(162, 17)
        Me._OptLoai_8.TabIndex = 119
        Me._OptLoai_8.TabStop = True
        Me._OptLoai_8.Tag = "Sales Invoice"
        Me._OptLoai_8.Text = "&Bán hàng"
        Me._OptLoai_8.UseVisualStyleBackColor = False
        '
        '_OptLoai_1
        '
        Me._OptLoai_1.BackColor = System.Drawing.Color.Transparent
        Me._OptLoai_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptLoai_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptLoai_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptLoai_1.Location = New System.Drawing.Point(176, 32)
        Me._OptLoai_1.Name = "_OptLoai_1"
        Me._OptLoai_1.Size = New System.Drawing.Size(162, 17)
        Me._OptLoai_1.TabIndex = 114
        Me._OptLoai_1.TabStop = True
        Me._OptLoai_1.Tag = "Import Inventory"
        Me._OptLoai_1.Text = "&Nhập vật tư"
        Me._OptLoai_1.UseVisualStyleBackColor = False
        '
        '_OptLoai_2
        '
        Me._OptLoai_2.BackColor = System.Drawing.Color.Transparent
        Me._OptLoai_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptLoai_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptLoai_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptLoai_2.Location = New System.Drawing.Point(344, 32)
        Me._OptLoai_2.Name = "_OptLoai_2"
        Me._OptLoai_2.Size = New System.Drawing.Size(178, 17)
        Me._OptLoai_2.TabIndex = 113
        Me._OptLoai_2.TabStop = True
        Me._OptLoai_2.Tag = "Export Inventory"
        Me._OptLoai_2.Text = "X&uất vật tư"
        Me._OptLoai_2.UseVisualStyleBackColor = False
        '
        '_OptLoai_3
        '
        Me._OptLoai_3.BackColor = System.Drawing.Color.Transparent
        Me._OptLoai_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptLoai_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptLoai_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptLoai_3.Location = New System.Drawing.Point(696, 32)
        Me._OptLoai_3.Name = "_OptLoai_3"
        Me._OptLoai_3.Size = New System.Drawing.Size(117, 17)
        Me._OptLoai_3.TabIndex = 112
        Me._OptLoai_3.TabStop = True
        Me._OptLoai_3.Tag = "Conversion"
        Me._OptLoai_3.Text = "&Kết chuyển"
        Me._OptLoai_3.UseVisualStyleBackColor = False
        '
        '_OptLoai_4
        '
        Me._OptLoai_4.BackColor = System.Drawing.Color.Transparent
        Me._OptLoai_4.Checked = True
        Me._OptLoai_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptLoai_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptLoai_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptLoai_4.Location = New System.Drawing.Point(112, 32)
        Me._OptLoai_4.Name = "_OptLoai_4"
        Me._OptLoai_4.Size = New System.Drawing.Size(53, 17)
        Me._OptLoai_4.TabIndex = 110
        Me._OptLoai_4.TabStop = True
        Me._OptLoai_4.Tag = "0"
        Me._OptLoai_4.Text = "reset"
        Me._OptLoai_4.UseVisualStyleBackColor = False
        Me._OptLoai_4.Visible = False
        '
        'CmdThemTK
        '
        Me.CmdThemTK.Location = New System.Drawing.Point(174, 232)
        Me.CmdThemTK.Name = "CmdThemTK"
        Me.CmdThemTK.Size = New System.Drawing.Size(25, 17)
        Me.CmdThemTK.TabIndex = 11
        Me.CmdThemTK.Text = "..."
        Me.CmdThemTK.Visible = False
        '
        'ChkTudong
        '
        Me.ChkTudong.BackColor = System.Drawing.Color.Transparent
        Me.ChkTudong.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkTudong.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkTudong.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkTudong.Location = New System.Drawing.Point(24, 209)
        Me.ChkTudong.Name = "ChkTudong"
        Me.ChkTudong.Size = New System.Drawing.Size(146, 17)
        Me.ChkTudong.TabIndex = 11
        Me.ChkTudong.TabStop = False
        Me.ChkTudong.Tag = "Auto enter account"
        Me.ChkTudong.Text = "Tự động nhập tài khoản"
        Me.ChkTudong.UseVisualStyleBackColor = False
        '
        'FNhap
        '
        Me.FNhap.BackColor = System.Drawing.Color.Transparent
        Me.FNhap.Controls.Add(Me._OptNhap_1)
        Me.FNhap.Controls.Add(Me._OptNhap_0)
        Me.FNhap.Controls.Add(Me._OptNhap_2)
        Me.FNhap.Controls.Add(Me.CboCo)
        Me.FNhap.Controls.Add(Me.CboNo)
        Me.FNhap.Controls.Add(Me._Label_26)
        Me.FNhap.Controls.Add(Me._Label_27)
        Me.FNhap.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNhap.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FNhap.Location = New System.Drawing.Point(32, 227)
        Me.FNhap.Name = "FNhap"
        Me.FNhap.Size = New System.Drawing.Size(537, 60)
        Me.FNhap.TabIndex = 105
        Me.FNhap.TabStop = False
        Me.FNhap.Visible = False
        '
        '_OptNhap_1
        '
        Me._OptNhap_1.BackColor = System.Drawing.Color.Transparent
        Me._OptNhap_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptNhap_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptNhap_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptNhap_1.Location = New System.Drawing.Point(88, 16)
        Me._OptNhap_1.Name = "_OptNhap_1"
        Me._OptNhap_1.Size = New System.Drawing.Size(73, 17)
        Me._OptNhap_1.TabIndex = 13
        Me._OptNhap_1.TabStop = True
        Me._OptNhap_1.Tag = "VAT rate"
        Me._OptNhap_1.Text = "Thuế suất"
        Me._OptNhap_1.UseVisualStyleBackColor = False
        '
        '_OptNhap_0
        '
        Me._OptNhap_0.BackColor = System.Drawing.Color.Transparent
        Me._OptNhap_0.Checked = True
        Me._OptNhap_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptNhap_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptNhap_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptNhap_0.Location = New System.Drawing.Point(8, 16)
        Me._OptNhap_0.Name = "_OptNhap_0"
        Me._OptNhap_0.Size = New System.Drawing.Size(81, 17)
        Me._OptNhap_0.TabIndex = 12
        Me._OptNhap_0.TabStop = True
        Me._OptNhap_0.Tag = "Imports"
        Me._OptNhap_0.Text = "Hàng nhập"
        Me._OptNhap_0.UseVisualStyleBackColor = False
        '
        '_OptNhap_2
        '
        Me._OptNhap_2.BackColor = System.Drawing.Color.Transparent
        Me._OptNhap_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptNhap_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptNhap_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptNhap_2.Location = New System.Drawing.Point(272, 16)
        Me._OptNhap_2.Name = "_OptNhap_2"
        Me._OptNhap_2.Size = New System.Drawing.Size(81, 17)
        Me._OptNhap_2.TabIndex = 15
        Me._OptNhap_2.TabStop = True
        Me._OptNhap_2.Tag = "Payment"
        Me._OptNhap_2.Text = "Thanh toán"
        Me._OptNhap_2.UseVisualStyleBackColor = False
        '
        'CboCo
        '
        Me.CboCo.BackColor = System.Drawing.SystemColors.Window
        Me.CboCo.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboCo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboCo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCo.Enabled = False
        Me.CboCo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCo.Location = New System.Drawing.Point(272, 36)
        Me.CboCo.Name = "CboCo"
        Me.CboCo.Size = New System.Drawing.Size(257, 21)
        Me.CboCo.TabIndex = 16
        '
        'CboNo
        '
        Me.CboNo.BackColor = System.Drawing.SystemColors.Window
        Me.CboNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboNo.Enabled = False
        Me.CboNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboNo.Location = New System.Drawing.Point(8, 36)
        Me.CboNo.Name = "CboNo"
        Me.CboNo.Size = New System.Drawing.Size(257, 21)
        Me.CboNo.TabIndex = 14
        '
        '_Label_26
        '
        Me._Label_26.BackColor = System.Drawing.Color.Transparent
        Me._Label_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_26.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_26.Location = New System.Drawing.Point(8, -1)
        Me._Label_26.Name = "_Label_26"
        Me._Label_26.Size = New System.Drawing.Size(81, 17)
        Me._Label_26.TabIndex = 107
        Me._Label_26.Tag = "Debit"
        Me._Label_26.Text = "Phát sinh nợ"
        Me._Label_26.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_27
        '
        Me._Label_27.BackColor = System.Drawing.Color.Transparent
        Me._Label_27.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_27.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_27.Location = New System.Drawing.Point(272, 0)
        Me._Label_27.Name = "_Label_27"
        Me._Label_27.Size = New System.Drawing.Size(81, 17)
        Me._Label_27.TabIndex = 106
        Me._Label_27.Tag = "Month"
        Me._Label_27.Text = "Phát sinh có"
        Me._Label_27.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(16, 324)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(809, 73)
        Me.Frame1.TabIndex = 103
        Me.Frame1.TabStop = False
        Me.Frame1.Visible = False
        '
        'Frame
        '
        Me.Frame.BackColor = System.Drawing.Color.Transparent
        Me.Frame.Controls.Add(Me._cmd_0)
        Me.Frame.Controls.Add(Me._cmd_1)
        Me.Frame.Controls.Add(Me._txtsh_1)
        Me.Frame.Controls.Add(Me._txtsh_0)
        Me.Frame.Controls.Add(Me._lb_1)
        Me.Frame.Controls.Add(Me._lb_0)
        Me.Frame.Controls.Add(Me._Label_19)
        Me.Frame.Controls.Add(Me._Label_18)
        Me.Frame.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame.Location = New System.Drawing.Point(104, 568)
        Me.Frame.Name = "Frame"
        Me.Frame.Size = New System.Drawing.Size(465, 65)
        Me.Frame.TabIndex = 76
        Me.Frame.TabStop = False
        Me.Frame.Visible = False
        '
        '_cmd_0
        '
        Me._cmd_0.Image = CType(resources.GetObject("_cmd_0.Image"), System.Drawing.Image)
        Me._cmd_0.Location = New System.Drawing.Point(201, 10)
        Me._cmd_0.Name = "_cmd_0"
        Me._cmd_0.Size = New System.Drawing.Size(25, 23)
        Me._cmd_0.TabIndex = 80
        '
        '_cmd_1
        '
        Me._cmd_1.Image = CType(resources.GetObject("_cmd_1.Image"), System.Drawing.Image)
        Me._cmd_1.Location = New System.Drawing.Point(201, 34)
        Me._cmd_1.Name = "_cmd_1"
        Me._cmd_1.Size = New System.Drawing.Size(25, 23)
        Me._cmd_1.TabIndex = 84
        '
        '_txtsh_1
        '
        Me._txtsh_1.AcceptsReturn = True
        Me._txtsh_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtsh_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtsh_1.Enabled = False
        Me._txtsh_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtsh_1.Location = New System.Drawing.Point(104, 35)
        Me._txtsh_1.MaxLength = 20
        Me._txtsh_1.Name = "_txtsh_1"
        Me._txtsh_1.Size = New System.Drawing.Size(89, 20)
        Me._txtsh_1.TabIndex = 83
        Me._txtsh_1.Tag = "0"
        '
        '_txtsh_0
        '
        Me._txtsh_0.AcceptsReturn = True
        Me._txtsh_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtsh_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtsh_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtsh_0.Location = New System.Drawing.Point(104, 11)
        Me._txtsh_0.MaxLength = 20
        Me._txtsh_0.Name = "_txtsh_0"
        Me._txtsh_0.Size = New System.Drawing.Size(89, 20)
        Me._txtsh_0.TabIndex = 79
        Me._txtsh_0.Tag = "0"
        '
        '_lb_1
        '
        Me._lb_1.BackColor = System.Drawing.Color.Transparent
        Me._lb_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lb_1.Enabled = False
        Me._lb_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lb_1.ForeColor = System.Drawing.Color.Blue
        Me._lb_1.Location = New System.Drawing.Point(232, 40)
        Me._lb_1.Name = "_lb_1"
        Me._lb_1.Size = New System.Drawing.Size(225, 17)
        Me._lb_1.TabIndex = 86
        Me._lb_1.Tag = "1"
        '
        '_lb_0
        '
        Me._lb_0.BackColor = System.Drawing.Color.Transparent
        Me._lb_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lb_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lb_0.ForeColor = System.Drawing.Color.Blue
        Me._lb_0.Location = New System.Drawing.Point(232, 16)
        Me._lb_0.Name = "_lb_0"
        Me._lb_0.Size = New System.Drawing.Size(225, 17)
        Me._lb_0.TabIndex = 82
        Me._lb_0.Tag = "1"
        '
        '_Label_19
        '
        Me._Label_19.BackColor = System.Drawing.Color.Transparent
        Me._Label_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_19.Enabled = False
        Me._Label_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_19.Location = New System.Drawing.Point(8, 40)
        Me._Label_19.Name = "_Label_19"
        Me._Label_19.Size = New System.Drawing.Size(89, 17)
        Me._Label_19.TabIndex = 78
        Me._Label_19.Tag = "Object"
        Me._Label_19.Text = "Đối tượng"
        '
        '_Label_18
        '
        Me._Label_18.BackColor = System.Drawing.Color.Transparent
        Me._Label_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_18.Location = New System.Drawing.Point(8, 16)
        Me._Label_18.Name = "_Label_18"
        Me._Label_18.Size = New System.Drawing.Size(89, 17)
        Me._Label_18.TabIndex = 77
        Me._Label_18.Tag = "Deb. Account"
        Me._Label_18.Text = "Ghi nợ tài khoản"
        '
        'SSCmdV
        '
        Me.SSCmdV.Location = New System.Drawing.Point(301, 566)
        Me.SSCmdV.Name = "SSCmdV"
        Me.SSCmdV.Size = New System.Drawing.Size(20, 19)
        Me.SSCmdV.TabIndex = 102
        '
        '_CmdPhieu_0
        '
        Me._CmdPhieu_0.Location = New System.Drawing.Point(3, 638)
        Me._CmdPhieu_0.Name = "_CmdPhieu_0"
        Me._CmdPhieu_0.Size = New System.Drawing.Size(73, 25)
        Me._CmdPhieu_0.TabIndex = 30
        Me._CmdPhieu_0.Tag = "&1 Bill P/R"
        Me._CmdPhieu_0.Text = "&1 Phiếu TC"
        Me._CmdPhieu_0.Visible = False
        '
        '_CmdPhieu_1
        '
        Me._CmdPhieu_1.Location = New System.Drawing.Point(76, 638)
        Me._CmdPhieu_1.Name = "_CmdPhieu_1"
        Me._CmdPhieu_1.Size = New System.Drawing.Size(74, 25)
        Me._CmdPhieu_1.TabIndex = 31
        Me._CmdPhieu_1.Tag = "&2 Invoice"
        Me._CmdPhieu_1.Text = "&2 Hoá đơn"
        Me._CmdPhieu_1.Visible = False
        '
        '_CmdPhieu_2
        '
        Me._CmdPhieu_2.Location = New System.Drawing.Point(150, 638)
        Me._CmdPhieu_2.Name = "_CmdPhieu_2"
        Me._CmdPhieu_2.Size = New System.Drawing.Size(65, 25)
        Me._CmdPhieu_2.TabIndex = 32
        Me._CmdPhieu_2.Tag = "&3 MS"
        Me._CmdPhieu_2.Text = "&3 UNC"
        Me._CmdPhieu_2.Visible = False
        '
        '_CmdPhieu_3
        '
        Me._CmdPhieu_3.Location = New System.Drawing.Point(289, 638)
        Me._CmdPhieu_3.Name = "_CmdPhieu_3"
        Me._CmdPhieu_3.Size = New System.Drawing.Size(69, 25)
        Me._CmdPhieu_3.TabIndex = 64
        Me._CmdPhieu_3.Text = "&4 TCNH"
        Me._CmdPhieu_3.Visible = False
        '
        'CboDoituong
        '
        Me.CboDoituong.BackColor = System.Drawing.SystemColors.Window
        Me.CboDoituong.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboDoituong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboDoituong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDoituong.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDoituong.Location = New System.Drawing.Point(104, 590)
        Me.CboDoituong.Name = "CboDoituong"
        Me.CboDoituong.Size = New System.Drawing.Size(217, 21)
        Me.CboDoituong.TabIndex = 13
        Me.CboDoituong.Visible = False
        '
        'chkXT
        '
        Me.chkXT.BackColor = System.Drawing.Color.Transparent
        Me.chkXT.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkXT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkXT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkXT.Location = New System.Drawing.Point(32, 590)
        Me.chkXT.Name = "chkXT"
        Me.chkXT.Size = New System.Drawing.Size(81, 17)
        Me.chkXT.TabIndex = 73
        Me.chkXT.Tag = "Direct Export"
        Me.chkXT.Text = "Xuất thẳng"
        Me.chkXT.UseVisualStyleBackColor = False
        Me.chkXT.Visible = False
        '
        'ChkDoiTuong
        '
        Me.ChkDoiTuong.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ChkDoiTuong.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkDoiTuong.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDoiTuong.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkDoiTuong.Location = New System.Drawing.Point(32, 590)
        Me.ChkDoiTuong.Name = "ChkDoiTuong"
        Me.ChkDoiTuong.Size = New System.Drawing.Size(73, 17)
        Me.ChkDoiTuong.TabIndex = 101
        Me.ChkDoiTuong.Tag = "&Quotation"
        Me.ChkDoiTuong.Text = "Sử dụng"
        Me.ChkDoiTuong.UseVisualStyleBackColor = False
        Me.ChkDoiTuong.Visible = False
        '
        'CboThang1
        '
        Me.CboThang1.BackColor = System.Drawing.SystemColors.Window
        Me.CboThang1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboThang1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboThang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboThang1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboThang1.Location = New System.Drawing.Point(168, 611)
        Me.CboThang1.Name = "CboThang1"
        Me.CboThang1.Size = New System.Drawing.Size(73, 21)
        Me.CboThang1.TabIndex = 75
        Me.CboThang1.Visible = False
        '
        'ChkHNT
        '
        Me.ChkHNT.BackColor = System.Drawing.Color.Transparent
        Me.ChkHNT.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkHNT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHNT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkHNT.Location = New System.Drawing.Point(32, 614)
        Me.ChkHNT.Name = "ChkHNT"
        Me.ChkHNT.Size = New System.Drawing.Size(132, 17)
        Me.ChkHNT.TabIndex = 74
        Me.ChkHNT.Tag = "Create import bill"
        Me.ChkHNT.Text = "Tạo phiếu nhập tháng"
        Me.ChkHNT.UseVisualStyleBackColor = False
        '
        '_CboVV_2
        '
        Me._CboVV_2.BackColor = System.Drawing.SystemColors.Window
        Me._CboVV_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboVV_2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboVV_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboVV_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboVV_2.Location = New System.Drawing.Point(368, 256)
        Me._CboVV_2.Name = "_CboVV_2"
        Me._CboVV_2.Size = New System.Drawing.Size(137, 21)
        Me._CboVV_2.TabIndex = 100
        Me._CboVV_2.Visible = False
        '
        '_CboVV_1
        '
        Me._CboVV_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboVV_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboVV_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboVV_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboVV_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboVV_1.Location = New System.Drawing.Point(368, 232)
        Me._CboVV_1.Name = "_CboVV_1"
        Me._CboVV_1.Size = New System.Drawing.Size(201, 21)
        Me._CboVV_1.TabIndex = 99
        Me._CboVV_1.Visible = False
        '
        '_CboVV_0
        '
        Me._CboVV_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboVV_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboVV_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboVV_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboVV_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboVV_0.Location = New System.Drawing.Point(88, 232)
        Me._CboVV_0.Name = "_CboVV_0"
        Me._CboVV_0.Size = New System.Drawing.Size(201, 21)
        Me._CboVV_0.TabIndex = 98
        Me._CboVV_0.Visible = False
        '
        '_txtchungtu_11
        '
        Me._txtchungtu_11.AcceptsReturn = True
        Me._txtchungtu_11.BackColor = System.Drawing.SystemColors.Window
        Me._txtchungtu_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtchungtu_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtchungtu_11.Location = New System.Drawing.Point(320, 590)
        Me._txtchungtu_11.MaxLength = 20
        Me._txtchungtu_11.Multiline = True
        Me._txtchungtu_11.Name = "_txtchungtu_11"
        Me._txtchungtu_11.Size = New System.Drawing.Size(89, 19)
        Me._txtchungtu_11.TabIndex = 19
        Me._txtchungtu_11.Tag = "0"
        Me._txtchungtu_11.Text = "0"
        Me._txtchungtu_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._txtchungtu_11.Visible = False
        '
        '_txtchungtu_10
        '
        Me._txtchungtu_10.AcceptsReturn = True
        Me._txtchungtu_10.BackColor = System.Drawing.SystemColors.Window
        Me._txtchungtu_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtchungtu_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtchungtu_10.Location = New System.Drawing.Point(859, 566)
        Me._txtchungtu_10.MaxLength = 20
        Me._txtchungtu_10.Multiline = True
        Me._txtchungtu_10.Name = "_txtchungtu_10"
        Me._txtchungtu_10.Size = New System.Drawing.Size(65, 20)
        Me._txtchungtu_10.TabIndex = 26
        Me._txtchungtu_10.Tag = "0"
        Me._txtchungtu_10.Text = "0"
        Me._txtchungtu_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtchungtu_9
        '
        Me._txtchungtu_9.AcceptsReturn = True
        Me._txtchungtu_9.BackColor = System.Drawing.SystemColors.Window
        Me._txtchungtu_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtchungtu_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtchungtu_9.Location = New System.Drawing.Point(829, 566)
        Me._txtchungtu_9.MaxLength = 5
        Me._txtchungtu_9.Multiline = True
        Me._txtchungtu_9.Name = "_txtchungtu_9"
        Me._txtchungtu_9.Size = New System.Drawing.Size(31, 20)
        Me._txtchungtu_9.TabIndex = 25
        Me._txtchungtu_9.Tag = "0"
        Me._txtchungtu_9.Text = "0"
        Me._txtchungtu_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtchungtu_8
        '
        Me._txtchungtu_8.AcceptsReturn = True
        Me._txtchungtu_8.BackColor = System.Drawing.SystemColors.Window
        Me._txtchungtu_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtchungtu_8.Enabled = False
        Me._txtchungtu_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtchungtu_8.Location = New System.Drawing.Point(768, 590)
        Me._txtchungtu_8.MaxLength = 3
        Me._txtchungtu_8.Multiline = True
        Me._txtchungtu_8.Name = "_txtchungtu_8"
        Me._txtchungtu_8.Size = New System.Drawing.Size(45, 19)
        Me._txtchungtu_8.TabIndex = 28
        Me._txtchungtu_8.Tag = "0"
        Me._txtchungtu_8.Text = "0"
        Me._txtchungtu_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txt_3
        '
        Me._txt_3.AcceptsReturn = True
        Me._txt_3.BackColor = System.Drawing.SystemColors.Window
        Me._txt_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_3.Location = New System.Drawing.Point(664, 164)
        Me._txt_3.MaxLength = 20
        Me._txt_3.Name = "_txt_3"
        Me._txt_3.Size = New System.Drawing.Size(129, 20)
        Me._txt_3.TabIndex = 11
        Me._txt_3.Tag = "9"
        Me._txt_3.Visible = False
        '
        'Chk
        '
        Me.Chk.BackColor = System.Drawing.Color.Transparent
        Me.Chk.Cursor = System.Windows.Forms.Cursors.Default
        Me.Chk.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk.Location = New System.Drawing.Point(376, 88)
        Me.Chk.Name = "Chk"
        Me.Chk.Size = New System.Drawing.Size(65, 17)
        Me.Chk.TabIndex = 10
        Me.Chk.Tag = "&Quotation"
        Me.Chk.Text = "&Báo giá"
        Me.Chk.UseVisualStyleBackColor = False
        Me.Chk.Visible = False
        '
        '_txtchungtu_7
        '
        Me._txtchungtu_7.AcceptsReturn = True
        Me._txtchungtu_7.BackColor = System.Drawing.SystemColors.Window
        Me._txtchungtu_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtchungtu_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtchungtu_7.Location = New System.Drawing.Point(736, 112)
        Me._txtchungtu_7.MaxLength = 20
        Me._txtchungtu_7.Multiline = True
        Me._txtchungtu_7.Name = "_txtchungtu_7"
        Me._txtchungtu_7.Size = New System.Drawing.Size(57, 19)
        Me._txtchungtu_7.TabIndex = 72
        Me._txtchungtu_7.TabStop = False
        Me._txtchungtu_7.Tag = "0"
        Me._txtchungtu_7.Text = "0"
        Me._txtchungtu_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._txtchungtu_7.Visible = False
        '
        '_txt_2
        '
        Me._txt_2.AcceptsReturn = True
        Me._txt_2.BackColor = System.Drawing.SystemColors.Window
        Me._txt_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_2.Location = New System.Drawing.Point(88, 208)
        Me._txt_2.MaxLength = 150
        Me._txt_2.Name = "_txt_2"
        Me._txt_2.Size = New System.Drawing.Size(481, 20)
        Me._txt_2.TabIndex = 15
        Me._txt_2.Visible = False
        '
        '_txtchungtu_6
        '
        Me._txtchungtu_6.AcceptsReturn = True
        Me._txtchungtu_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtchungtu_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtchungtu_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtchungtu_6.Location = New System.Drawing.Point(688, 566)
        Me._txtchungtu_6.MaxLength = 20
        Me._txtchungtu_6.Multiline = True
        Me._txtchungtu_6.Name = "_txtchungtu_6"
        Me._txtchungtu_6.Size = New System.Drawing.Size(124, 20)
        Me._txtchungtu_6.TabIndex = 24
        Me._txtchungtu_6.Tag = "0"
        Me._txtchungtu_6.Text = "0"
        Me._txtchungtu_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_CboNguon_3
        '
        Me._CboNguon_3.BackColor = System.Drawing.SystemColors.Window
        Me._CboNguon_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboNguon_3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboNguon_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboNguon_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboNguon_3.Location = New System.Drawing.Point(592, 111)
        Me._CboNguon_3.Name = "_CboNguon_3"
        Me._CboNguon_3.Size = New System.Drawing.Size(105, 21)
        Me._CboNguon_3.TabIndex = 4
        Me._CboNguon_3.TabStop = False
        '
        '_CboNguon_2
        '
        Me._CboNguon_2.BackColor = System.Drawing.SystemColors.Window
        Me._CboNguon_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboNguon_2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboNguon_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboNguon_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboNguon_2.Location = New System.Drawing.Point(88, 183)
        Me._CboNguon_2.Name = "_CboNguon_2"
        Me._CboNguon_2.Size = New System.Drawing.Size(481, 21)
        Me._CboNguon_2.TabIndex = 12
        '
        'SSCmdV1
        '
        Me.SSCmdV1.BackColor = System.Drawing.SystemColors.Control
        Me.SSCmdV1.Cursor = System.Windows.Forms.Cursors.Default
        Me.SSCmdV1.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.SSCmdV1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SSCmdV1.Location = New System.Drawing.Point(304, 566)
        Me.SSCmdV1.Name = "SSCmdV1"
        Me.SSCmdV1.Size = New System.Drawing.Size(17, 19)
        Me.SSCmdV1.TabIndex = 47
        Me.SSCmdV1.Text = "0"
        Me.SSCmdV1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SSCmdV1.UseVisualStyleBackColor = False
        Me.SSCmdV1.Visible = False
        '
        'CboThang
        '
        Me.CboThang.BackColor = System.Drawing.SystemColors.Window
        Me.CboThang.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboThang.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboThang.Location = New System.Drawing.Point(88, 85)
        Me.CboThang.Name = "CboThang"
        Me.CboThang.Size = New System.Drawing.Size(73, 21)
        Me.CboThang.TabIndex = 0
        '
        '_txt_0
        '
        Me._txt_0.AcceptsReturn = True
        Me._txt_0.BackColor = System.Drawing.SystemColors.Window
        Me._txt_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_0.Location = New System.Drawing.Point(88, 136)
        Me._txt_0.MaxLength = 20
        Me._txt_0.Name = "_txt_0"
        Me._txt_0.Size = New System.Drawing.Size(113, 20)
        Me._txt_0.TabIndex = 5
        '
        '_txt_1
        '
        Me._txt_1.AcceptsReturn = True
        Me._txt_1.BackColor = System.Drawing.SystemColors.Window
        Me._txt_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_1.Location = New System.Drawing.Point(88, 160)
        Me._txt_1.MaxLength = 150
        Me._txt_1.Name = "_txt_1"
        Me._txt_1.Size = New System.Drawing.Size(481, 20)
        Me._txt_1.TabIndex = 10
        '
        '_CboNguon_1
        '
        Me._CboNguon_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboNguon_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboNguon_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboNguon_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboNguon_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboNguon_1.Location = New System.Drawing.Point(592, 137)
        Me._CboNguon_1.Name = "_CboNguon_1"
        Me._CboNguon_1.Size = New System.Drawing.Size(201, 21)
        Me._CboNguon_1.TabIndex = 9
        '
        '_CboNguon_0
        '
        Me._CboNguon_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboNguon_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboNguon_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboNguon_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboNguon_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboNguon_0.Location = New System.Drawing.Point(592, 85)
        Me._CboNguon_0.Name = "_CboNguon_0"
        Me._CboNguon_0.Size = New System.Drawing.Size(201, 21)
        Me._CboNguon_0.TabIndex = 1
        Me._CboNguon_0.TabStop = False
        Me._CboNguon_0.Tag = """"""
        '
        '_txtchungtu_5
        '
        Me._txtchungtu_5.AcceptsReturn = True
        Me._txtchungtu_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtchungtu_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtchungtu_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtchungtu_5.Location = New System.Drawing.Point(568, 566)
        Me._txtchungtu_5.MaxLength = 20
        Me._txtchungtu_5.Multiline = True
        Me._txtchungtu_5.Name = "_txtchungtu_5"
        Me._txtchungtu_5.Size = New System.Drawing.Size(121, 20)
        Me._txtchungtu_5.TabIndex = 23
        Me._txtchungtu_5.Tag = "0"
        Me._txtchungtu_5.Text = "0"
        Me._txtchungtu_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtchungtu_4
        '
        Me._txtchungtu_4.AcceptsReturn = True
        Me._txtchungtu_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtchungtu_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtchungtu_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtchungtu_4.Location = New System.Drawing.Point(480, 566)
        Me._txtchungtu_4.MaxLength = 20
        Me._txtchungtu_4.Multiline = True
        Me._txtchungtu_4.Name = "_txtchungtu_4"
        Me._txtchungtu_4.Size = New System.Drawing.Size(89, 20)
        Me._txtchungtu_4.TabIndex = 22
        Me._txtchungtu_4.Tag = "0"
        Me._txtchungtu_4.Text = "0"
        Me._txtchungtu_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtchungtu_3
        '
        Me._txtchungtu_3.AcceptsReturn = True
        Me._txtchungtu_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtchungtu_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtchungtu_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtchungtu_3.Location = New System.Drawing.Point(408, 566)
        Me._txtchungtu_3.MaxLength = 20
        Me._txtchungtu_3.Multiline = True
        Me._txtchungtu_3.Name = "_txtchungtu_3"
        Me._txtchungtu_3.Size = New System.Drawing.Size(73, 20)
        Me._txtchungtu_3.TabIndex = 21
        Me._txtchungtu_3.Tag = "0"
        Me._txtchungtu_3.Text = "0"
        Me._txtchungtu_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtchungtu_1
        '
        Me._txtchungtu_1.AcceptsReturn = True
        Me._txtchungtu_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtchungtu_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtchungtu_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtchungtu_1.Location = New System.Drawing.Point(104, 566)
        Me._txtchungtu_1.MaxLength = 50
        Me._txtchungtu_1.Name = "_txtchungtu_1"
        Me._txtchungtu_1.Size = New System.Drawing.Size(217, 20)
        Me._txtchungtu_1.TabIndex = 26
        Me._txtchungtu_1.TabStop = False
        '
        '_MedNgay_0
        '
        Me._MedNgay_0.AllowPromptAsInput = False
        Me._MedNgay_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_0.Location = New System.Drawing.Point(88, 112)
        Me._MedNgay_0.Mask = "00/00/0000"
        Me._MedNgay_0.Name = "_MedNgay_0"
        Me._MedNgay_0.Size = New System.Drawing.Size(70, 20)
        Me._MedNgay_0.TabIndex = 2
        '
        '_MedNgay_1
        '
        Me._MedNgay_1.AllowPromptAsInput = False
        Me._MedNgay_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_1.Location = New System.Drawing.Point(376, 112)
        Me._MedNgay_1.Mask = "00/00/0000"
        Me._MedNgay_1.Name = "_MedNgay_1"
        Me._MedNgay_1.Size = New System.Drawing.Size(70, 20)
        Me._MedNgay_1.TabIndex = 3
        '
        '_Label_29
        '
        Me._Label_29.BackColor = System.Drawing.Color.Transparent
        Me._Label_29.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_29.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_29.Location = New System.Drawing.Point(592, 235)
        Me._Label_29.Name = "_Label_29"
        Me._Label_29.Size = New System.Drawing.Size(65, 17)
        Me._Label_29.TabIndex = 127
        Me._Label_29.Tag = "Salesman"
        Me._Label_29.Text = "Khách hàng"
        '
        'LBKH
        '
        Me.LBKH.BackColor = System.Drawing.Color.Transparent
        Me.LBKH.Cursor = System.Windows.Forms.Cursors.Default
        Me.LBKH.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBKH.ForeColor = System.Drawing.Color.Blue
        Me.LBKH.Location = New System.Drawing.Point(592, 256)
        Me.LBKH.Name = "LBKH"
        Me.LBKH.Size = New System.Drawing.Size(201, 17)
        Me.LBKH.TabIndex = 126
        Me.LBKH.Tag = "1"
        '
        'Nut
        '
        Me.Nut.BackColor = System.Drawing.Color.Transparent
        Me.Nut.Cursor = System.Windows.Forms.Cursors.Default
        Me.Nut.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nut.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Nut.Location = New System.Drawing.Point(16, 48)
        Me.Nut.Name = "Nut"
        Me.Nut.Size = New System.Drawing.Size(57, 33)
        Me.Nut.TabIndex = 124
        Me.Nut.Tag = "0"
        Me.Nut.Text = "CT: tag=0 CN: tag=1"
        Me.Nut.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Nut.Visible = False
        '
        'loai1
        '
        Me.loai1.BackColor = System.Drawing.Color.Transparent
        Me.loai1.Cursor = System.Windows.Forms.Cursors.Default
        Me.loai1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loai1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.loai1.Location = New System.Drawing.Point(104, 48)
        Me.loai1.Name = "loai1"
        Me.loai1.Size = New System.Drawing.Size(57, 33)
        Me.loai1.TabIndex = 123
        Me.loai1.Tag = "0"
        Me.loai1.Text = "TH: tag=0 CN: tag=1"
        Me.loai1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.loai1.Visible = False
        '
        'loaino
        '
        Me.loaino.BackColor = System.Drawing.Color.Transparent
        Me.loaino.Cursor = System.Windows.Forms.Cursors.Default
        Me.loaino.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loaino.ForeColor = System.Drawing.SystemColors.ControlText
        Me.loaino.Location = New System.Drawing.Point(264, 48)
        Me.loaino.Name = "loaino"
        Me.loaino.Size = New System.Drawing.Size(57, 33)
        Me.loaino.TabIndex = 122
        Me.loaino.Tag = "0"
        Me.loaino.Text = "Thu: tag=0 Tra: tag=1"
        Me.loaino.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.loaino.Visible = False
        '
        '_Label_28
        '
        Me._Label_28.BackColor = System.Drawing.Color.Transparent
        Me._Label_28.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_28.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_28.Location = New System.Drawing.Point(281, 140)
        Me._Label_28.Name = "_Label_28"
        Me._Label_28.Size = New System.Drawing.Size(89, 17)
        Me._Label_28.TabIndex = 109
        Me._Label_28.Tag = "B. Date"
        Me._Label_28.Text = "Phiếu nhập(xuất):"
        Me._Label_28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbTT_2
        '
        Me._LbTT_2.BackColor = System.Drawing.Color.Transparent
        Me._LbTT_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTT_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LbTT_2.Location = New System.Drawing.Point(304, 256)
        Me._LbTT_2.Name = "_LbTT_2"
        Me._LbTT_2.Size = New System.Drawing.Size(57, 17)
        Me._LbTT_2.TabIndex = 97
        Me._LbTT_2.Tag = "Index"
        Me._LbTT_2.Text = "Thông tin 3"
        Me._LbTT_2.Visible = False
        '
        '_LbTT_1
        '
        Me._LbTT_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me._LbTT_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTT_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LbTT_1.Location = New System.Drawing.Point(304, 232)
        Me._LbTT_1.Name = "_LbTT_1"
        Me._LbTT_1.Size = New System.Drawing.Size(57, 17)
        Me._LbTT_1.TabIndex = 95
        Me._LbTT_1.Tag = "Index"
        Me._LbTT_1.Text = "Thông tin 2"
        Me._LbTT_1.Visible = False
        '
        '_LbTT_0
        '
        Me._LbTT_0.BackColor = System.Drawing.Color.Transparent
        Me._LbTT_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTT_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LbTT_0.Location = New System.Drawing.Point(24, 232)
        Me._LbTT_0.Name = "_LbTT_0"
        Me._LbTT_0.Size = New System.Drawing.Size(57, 17)
        Me._LbTT_0.TabIndex = 94
        Me._LbTT_0.Tag = "Index"
        Me._LbTT_0.Text = "Thông tin 1"
        Me._LbTT_0.Visible = False
        '
        '_Label_25
        '
        Me._Label_25.BackColor = System.Drawing.Color.Transparent
        Me._Label_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_25.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_25.Location = New System.Drawing.Point(240, 590)
        Me._Label_25.Name = "_Label_25"
        Me._Label_25.Size = New System.Drawing.Size(81, 17)
        Me._Label_25.TabIndex = 18
        Me._Label_25.Text = "Phát sinh USD"
        Me._Label_25.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me._Label_25.Visible = False
        '
        '_Label_24
        '
        Me._Label_24.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_24.ForeColor = System.Drawing.Color.Black
        Me._Label_24.Location = New System.Drawing.Point(859, 297)
        Me._Label_24.Name = "_Label_24"
        Me._Label_24.Size = New System.Drawing.Size(65, 17)
        Me._Label_24.TabIndex = 92
        Me._Label_24.Text = "Tiền CK"
        Me._Label_24.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_23
        '
        Me._Label_23.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_23.ForeColor = System.Drawing.Color.Black
        Me._Label_23.Location = New System.Drawing.Point(829, 297)
        Me._Label_23.Name = "_Label_23"
        Me._Label_23.Size = New System.Drawing.Size(31, 17)
        Me._Label_23.TabIndex = 91
        Me._Label_23.Text = "CK"
        Me._Label_23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_22
        '
        Me._Label_22.BackColor = System.Drawing.Color.Transparent
        Me._Label_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_22.Enabled = False
        Me._Label_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_22.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_22.Location = New System.Drawing.Point(688, 590)
        Me._Label_22.Name = "_Label_22"
        Me._Label_22.Size = New System.Drawing.Size(81, 17)
        Me._Label_22.TabIndex = 90
        Me._Label_22.Tag = "Payment term"
        Me._Label_22.Text = "Hạn thanh toán"
        '
        '_Label_21
        '
        Me._Label_21.BackColor = System.Drawing.Color.Transparent
        Me._Label_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_21.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_21.Location = New System.Drawing.Point(592, 167)
        Me._Label_21.Name = "_Label_21"
        Me._Label_21.Size = New System.Drawing.Size(65, 17)
        Me._Label_21.TabIndex = 89
        Me._Label_21.Tag = "Salesman"
        Me._Label_21.Text = "NV Bán hàng"
        Me._Label_21.Visible = False
        '
        'LBNV
        '
        Me.LBNV.BackColor = System.Drawing.Color.Transparent
        Me.LBNV.Cursor = System.Windows.Forms.Cursors.Default
        Me.LBNV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBNV.ForeColor = System.Drawing.Color.Blue
        Me.LBNV.Location = New System.Drawing.Point(664, 188)
        Me.LBNV.Name = "LBNV"
        Me.LBNV.Size = New System.Drawing.Size(129, 17)
        Me.LBNV.TabIndex = 88
        Me.LBNV.Tag = "1"
        Me.LBNV.Visible = False
        '
        '_Label_20
        '
        Me._Label_20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_20.ForeColor = System.Drawing.Color.Black
        Me._Label_20.Location = New System.Drawing.Point(8, 297)
        Me._Label_20.Name = "_Label_20"
        Me._Label_20.Size = New System.Drawing.Size(29, 17)
        Me._Label_20.TabIndex = 87
        Me._Label_20.Tag = "No."
        Me._Label_20.Text = "STT"
        Me._Label_20.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.Color.Transparent
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_17.Location = New System.Drawing.Point(698, 114)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(36, 17)
        Me._Label_17.TabIndex = 71
        Me._Label_17.Tag = "Ex. Rate"
        Me._Label_17.Text = "Tỷ giá"
        Me._Label_17.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me._Label_17.Visible = False
        '
        '_Label_16
        '
        Me._Label_16.BackColor = System.Drawing.Color.Transparent
        Me._Label_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_16.Location = New System.Drawing.Point(24, 208)
        Me._Label_16.Name = "_Label_16"
        Me._Label_16.Size = New System.Drawing.Size(62, 17)
        Me._Label_16.TabIndex = 70
        Me._Label_16.Text = "Description"
        Me._Label_16.Visible = False
        '
        'LbUser
        '
        Me.LbUser.BackColor = System.Drawing.Color.Transparent
        Me.LbUser.Cursor = System.Windows.Forms.Cursors.Default
        Me.LbUser.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUser.ForeColor = System.Drawing.Color.Blue
        Me.LbUser.Location = New System.Drawing.Point(664, 208)
        Me.LbUser.Name = "LbUser"
        Me.LbUser.Size = New System.Drawing.Size(129, 17)
        Me.LbUser.TabIndex = 69
        Me.LbUser.Tag = "1"
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.Transparent
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_11.Location = New System.Drawing.Point(592, 208)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(65, 17)
        Me._Label_11.TabIndex = 68
        Me._Label_11.Tag = "Input by"
        Me._Label_11.Text = "Người nhập"
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.Color.Black
        Me._Label_13.Location = New System.Drawing.Point(480, 297)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(89, 17)
        Me._Label_13.TabIndex = 67
        Me._Label_13.Tag = "Unit price"
        Me._Label_13.Text = "Đơn giá"
        Me._Label_13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_15
        '
        Me._Label_15.BackColor = System.Drawing.Color.Transparent
        Me._Label_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_15.Location = New System.Drawing.Point(529, 114)
        Me._Label_15.Name = "_Label_15"
        Me._Label_15.Size = New System.Drawing.Size(57, 17)
        Me._Label_15.TabIndex = 32
        Me._Label_15.Tag = "Voucher Type"
        Me._Label_15.Text = "CT Ghi sổ"
        Me._Label_15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.Color.Transparent
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_14.Location = New System.Drawing.Point(24, 184)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(57, 17)
        Me._Label_14.TabIndex = 60
        Me._Label_14.Tag = "Index"
        Me._Label_14.Text = "Hợp đồng"
        '
        '_Line1_3
        '
        Me._Line1_3.BackColor = System.Drawing.SystemColors.Window
        Me._Line1_3.Enabled = False
        Me._Line1_3.Location = New System.Drawing.Point(816, 28)
        Me._Line1_3.Name = "_Line1_3"
        Me._Line1_3.Size = New System.Drawing.Size(1, 264)
        Me._Line1_3.TabIndex = 128
        '
        '_Line1_2
        '
        Me._Line1_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Line1_2.Enabled = False
        Me._Line1_2.Location = New System.Drawing.Point(6, 27)
        Me._Line1_2.Name = "_Line1_2"
        Me._Line1_2.Size = New System.Drawing.Size(1, 265)
        Me._Line1_2.TabIndex = 129
        '
        '_Line1_1
        '
        Me._Line1_1.BackColor = System.Drawing.SystemColors.Window
        Me._Line1_1.Enabled = False
        Me._Line1_1.Location = New System.Drawing.Point(8, 291)
        Me._Line1_1.Name = "_Line1_1"
        Me._Line1_1.Size = New System.Drawing.Size(808, 1)
        Me._Line1_1.TabIndex = 130
        '
        '_Line1_0
        '
        Me._Line1_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Line1_0.Enabled = False
        Me._Line1_0.Location = New System.Drawing.Point(8, 27)
        Me._Line1_0.Name = "_Line1_0"
        Me._Line1_0.Size = New System.Drawing.Size(808, 1)
        Me._Line1_0.TabIndex = 131
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(24, 89)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(57, 17)
        Me._Label_0.TabIndex = 48
        Me._Label_0.Tag = "Month"
        Me._Label_0.Text = "Tháng"
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(24, 114)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(57, 17)
        Me._Label_1.TabIndex = 49
        Me._Label_1.Tag = "V. Date"
        Me._Label_1.Text = "Ngày CT"
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.Transparent
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(304, 115)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(65, 17)
        Me._Label_2.TabIndex = 45
        Me._Label_2.Tag = "B. Date"
        Me._Label_2.Text = "Ngày GS"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.Transparent
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_3.Location = New System.Drawing.Point(24, 136)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(57, 17)
        Me._Label_3.TabIndex = 46
        Me._Label_3.Tag = "V. Code"
        Me._Label_3.Text = "Số CT"
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.Transparent
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_4.Location = New System.Drawing.Point(24, 161)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(57, 17)
        Me._Label_4.TabIndex = 58
        Me._Label_4.Tag = "Desc. (V)"
        Me._Label_4.Text = "Diễn giải"
        '
        '_LbKho_0
        '
        Me._LbKho_0.BackColor = System.Drawing.Color.Transparent
        Me._LbKho_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbKho_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbKho_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LbKho_0.Location = New System.Drawing.Point(528, 140)
        Me._LbKho_0.Name = "_LbKho_0"
        Me._LbKho_0.Size = New System.Drawing.Size(57, 17)
        Me._LbKho_0.TabIndex = 57
        Me._LbKho_0.Tag = "Store"
        Me._LbKho_0.Text = "Kho hàng"
        Me._LbKho_0.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbKho_1
        '
        Me._LbKho_1.BackColor = System.Drawing.Color.Transparent
        Me._LbKho_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbKho_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbKho_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LbKho_1.Location = New System.Drawing.Point(449, 88)
        Me._LbKho_1.Name = "_LbKho_1"
        Me._LbKho_1.Size = New System.Drawing.Size(137, 17)
        Me._LbKho_1.TabIndex = 56
        Me._LbKho_1.Tag = "Class"
        Me._LbKho_1.Text = "Phân loại"
        Me._LbKho_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.Color.Black
        Me._Label_10.Location = New System.Drawing.Point(688, 297)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(124, 17)
        Me._Label_10.TabIndex = 55
        Me._Label_10.Tag = "Credit"
        Me._Label_10.Text = "Phát sinh có"
        Me._Label_10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_9
        '
        Me._Label_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.Color.Black
        Me._Label_9.Location = New System.Drawing.Point(568, 297)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.Size = New System.Drawing.Size(122, 17)
        Me._Label_9.TabIndex = 54
        Me._Label_9.Tag = "Debit"
        Me._Label_9.Text = "Phát sinh nợ"
        Me._Label_9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.Color.Black
        Me._Label_8.Location = New System.Drawing.Point(408, 297)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(73, 17)
        Me._Label_8.TabIndex = 53
        Me._Label_8.Tag = "Quantity"
        Me._Label_8.Text = "Số lượng"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(320, 297)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(89, 17)
        Me._Label_7.TabIndex = 52
        Me._Label_7.Tag = "Code"
        Me._Label_7.Text = "Mã số"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.Color.Black
        Me._Label_6.Location = New System.Drawing.Point(104, 297)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(223, 17)
        Me._Label_6.TabIndex = 51
        Me._Label_6.Tag = "Description"
        Me._Label_6.Text = "Diễn giải"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.Color.Black
        Me._Label_5.Location = New System.Drawing.Point(32, 297)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(73, 17)
        Me._Label_5.TabIndex = 50
        Me._Label_5.Tag = "Account"
        Me._Label_5.Text = "Tài khoản"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Command_0
        '
        Me._Command_0.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.add16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(610, 638)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 36
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        Me._Command_0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_1
        '
        Me._Command_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(691, 638)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 29
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        Me._Command_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_2
        '
        Me._Command_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(772, 638)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 37
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        Me._Command_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_3
        '
        Me._Command_3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(853, 638)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 38
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        Me._Command_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_4
        '
        Me._Command_4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Command_4.Image = Global.UNET.My.Resources.Resources.report16
        Me._Command_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_4.Location = New System.Drawing.Point(529, 638)
        Me._Command_4.Name = "_Command_4"
        Me._Command_4.Size = New System.Drawing.Size(73, 25)
        Me._Command_4.TabIndex = 35
        Me._Command_4.Tag = "Preview"
        Me._Command_4.Text = "Xe&m"
        Me._Command_4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdBC
        '
        Me.CmdBC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdBC.Location = New System.Drawing.Point(215, 638)
        Me.CmdBC.Name = "CmdBC"
        Me.CmdBC.Size = New System.Drawing.Size(74, 25)
        Me.CmdBC.TabIndex = 33
        Me.CmdBC.Text = "&Barcode"
        Me.CmdBC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdBC.Visible = False
        '
        '_CmdDanhSach_0
        '
        Me._CmdDanhSach_0.Image = Global.UNET.My.Resources.Resources.search3_16
        Me._CmdDanhSach_0.Location = New System.Drawing.Point(209, 135)
        Me._CmdDanhSach_0.Name = "_CmdDanhSach_0"
        Me._CmdDanhSach_0.Size = New System.Drawing.Size(24, 22)
        Me._CmdDanhSach_0.TabIndex = 6
        '
        '_CmdDanhSach1_0
        '
        Me._CmdDanhSach1_0.BackColor = System.Drawing.Color.Silver
        Me._CmdDanhSach1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CmdDanhSach1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CmdDanhSach1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CmdDanhSach1_0.Image = CType(resources.GetObject("_CmdDanhSach1_0.Image"), System.Drawing.Image)
        Me._CmdDanhSach1_0.Location = New System.Drawing.Point(208, 134)
        Me._CmdDanhSach1_0.Name = "_CmdDanhSach1_0"
        Me._CmdDanhSach1_0.Size = New System.Drawing.Size(24, 23)
        Me._CmdDanhSach1_0.TabIndex = 6
        Me._CmdDanhSach1_0.TabStop = False
        Me._CmdDanhSach1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._CmdDanhSach1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._CmdDanhSach1_0.UseVisualStyleBackColor = False
        Me._CmdDanhSach1_0.Visible = False
        '
        '_CmdDanhSach_1
        '
        Me._CmdDanhSach_1.Image = Global.UNET.My.Resources.Resources.search3_16
        Me._CmdDanhSach_1.Location = New System.Drawing.Point(241, 135)
        Me._CmdDanhSach_1.Name = "_CmdDanhSach_1"
        Me._CmdDanhSach_1.Size = New System.Drawing.Size(24, 22)
        Me._CmdDanhSach_1.TabIndex = 7
        '
        '_CmdDanhSach1_1
        '
        Me._CmdDanhSach1_1.BackColor = System.Drawing.Color.Silver
        Me._CmdDanhSach1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CmdDanhSach1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CmdDanhSach1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CmdDanhSach1_1.Image = CType(resources.GetObject("_CmdDanhSach1_1.Image"), System.Drawing.Image)
        Me._CmdDanhSach1_1.Location = New System.Drawing.Point(240, 134)
        Me._CmdDanhSach1_1.Name = "_CmdDanhSach1_1"
        Me._CmdDanhSach1_1.Size = New System.Drawing.Size(24, 23)
        Me._CmdDanhSach1_1.TabIndex = 9
        Me._CmdDanhSach1_1.TabStop = False
        Me._CmdDanhSach1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._CmdDanhSach1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._CmdDanhSach1_1.UseVisualStyleBackColor = False
        Me._CmdDanhSach1_1.Visible = False
        '
        '_Command_5
        '
        Me._Command_5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_5.Location = New System.Drawing.Point(358, 638)
        Me._Command_5.Name = "_Command_5"
        Me._Command_5.Size = New System.Drawing.Size(117, 25)
        Me._Command_5.TabIndex = 34
        Me._Command_5.Tag = "Register in voice"
        Me._Command_5.Text = "Đăng ký hoá đơn"
        Me._Command_5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._Command_5.Visible = False
        '
        'GrdChungtu
        '
        Me.GrdChungtu.AllowColumnResize = True
        Me.GrdChungtu.AllowMultiselect = False
        Me.GrdChungtu.AlternateBackground = System.Drawing.Color.DarkGreen
        Me.GrdChungtu.AlternatingColors = False
        Me.GrdChungtu.AutoHeight = True
        Me.GrdChungtu.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdChungtu.BackgroundStretchToFit = True
        Me.GrdChungtu.Col = 0
        Me.GrdChungtu.Cols = 0
        Me.GrdChungtu.ControlStyle = ListViewEx.GLControlStyles.SuperFlat
        Me.GrdChungtu.FullRowSelect = True
        Me.GrdChungtu.GridColor = System.Drawing.Color.LightGray
        Me.GrdChungtu.GridLines = ListViewEx.GLGridLines.gridBoth
        Me.GrdChungtu.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me.GrdChungtu.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me.GrdChungtu.HeaderHeight = 22
        Me.GrdChungtu.HeaderVisible = True
        Me.GrdChungtu.HeaderWordWrap = False
        Me.GrdChungtu.HotColumnTracking = False
        Me.GrdChungtu.HotItemTracking = False
        Me.GrdChungtu.HotTrackingColor = System.Drawing.Color.LightGray
        Me.GrdChungtu.HoverEvents = False
        Me.GrdChungtu.HoverTime = 1
        Me.GrdChungtu.ImageList = Nothing
        Me.GrdChungtu.ItemHeight = 18
        Me.GrdChungtu.ItemWordWrap = False
        Me.GrdChungtu.Location = New System.Drawing.Point(8, 313)
        Me.GrdChungtu.Name = "GrdChungtu"
        Me.GrdChungtu.Row = 0
        Me.GrdChungtu.Rows = 0
        Me.GrdChungtu.Selectable = True
        Me.GrdChungtu.SelectedTextColor = System.Drawing.Color.White
        Me.GrdChungtu.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.GrdChungtu.ShowBorder = True
        Me.GrdChungtu.ShowFocusRect = False
        Me.GrdChungtu.Size = New System.Drawing.Size(916, 254)
        Me.GrdChungtu.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdChungtu.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdChungtu.TabIndex = 17
        '
        '_Label_12
        '
        Me._Label_12.BackColor = System.Drawing.Color.Transparent
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_12.Location = New System.Drawing.Point(105, 591)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.Size = New System.Drawing.Size(49, 17)
        Me._Label_12.TabIndex = 12
        Me._Label_12.Text = "Đ.v.t"
        Me._Label_12.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me._Label_12.Visible = False
        '
        'FrmChungtutonghop
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(947, 666)
        Me.Controls.Add(Me._OptLoai_15)
        Me.Controls.Add(Me.Frame)
        Me.Controls.Add(Me.GrdChungtu)
        Me.Controls.Add(Me._txt_5)
        Me.Controls.Add(Me._txt_4)
        Me.Controls.Add(Me.CmdChitiet)
        Me.Controls.Add(Me._OptLoai_14)
        Me.Controls.Add(Me._OptLoai_13)
        Me.Controls.Add(Me._OptLoai_8)
        Me.Controls.Add(Me._OptLoai_11)
        Me.Controls.Add(Me._OptLoai_10)
        Me.Controls.Add(Me._OptLoai_9)
        Me.Controls.Add(Me._OptLoai_0)
        Me.Controls.Add(Me._OptLoai_1)
        Me.Controls.Add(Me._OptLoai_2)
        Me.Controls.Add(Me._OptLoai_3)
        Me.Controls.Add(Me._OptLoai_12)
        Me.Controls.Add(Me._OptLoai_4)
        Me.Controls.Add(Me.ChkTudong)
        Me.Controls.Add(Me.FNhap)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me._CboNT_3)
        Me.Controls.Add(Me.SSCmdV)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_4)
        Me.Controls.Add(Me.CmdBC)
        Me.Controls.Add(Me._CmdPhieu_0)
        Me.Controls.Add(Me._CmdPhieu_1)
        Me.Controls.Add(Me._CmdPhieu_2)
        Me.Controls.Add(Me._CmdDanhSach_0)
        Me.Controls.Add(Me.CmdThemTK)
        Me.Controls.Add(Me._CmdPhieu_3)
        Me.Controls.Add(Me.CboDoituong)
        Me.Controls.Add(Me.CboThang1)
        Me.Controls.Add(Me.ChkHNT)
        Me.Controls.Add(Me._CboVV_2)
        Me.Controls.Add(Me._CboVV_1)
        Me.Controls.Add(Me._CboVV_0)
        Me.Controls.Add(Me._txtchungtu_11)
        Me.Controls.Add(Me._txtchungtu_10)
        Me.Controls.Add(Me._txtchungtu_9)
        Me.Controls.Add(Me._txtchungtu_8)
        Me.Controls.Add(Me._txt_3)
        Me.Controls.Add(Me.Chk)
        Me.Controls.Add(Me._txtchungtu_7)
        Me.Controls.Add(Me._txt_2)
        Me.Controls.Add(Me._txtchungtu_6)
        Me.Controls.Add(Me._CboNguon_3)
        Me.Controls.Add(Me._CboNT_2)
        Me.Controls.Add(Me._CboNT_1)
        Me.Controls.Add(Me._CmdDanhSach1_0)
        Me.Controls.Add(Me._CboNT_0)
        Me.Controls.Add(Me._CboNguon_2)
        Me.Controls.Add(Me.SSCmdV1)
        Me.Controls.Add(Me._txt_0)
        Me.Controls.Add(Me.CboThang)
        Me.Controls.Add(Me._txt_1)
        Me.Controls.Add(Me._CboNguon_1)
        Me.Controls.Add(Me._CboNguon_0)
        Me.Controls.Add(Me._txtchungtu_5)
        Me.Controls.Add(Me._txtchungtu_4)
        Me.Controls.Add(Me._txtchungtu_3)
        Me.Controls.Add(Me._txtchungtu_2)
        Me.Controls.Add(Me._txtchungtu_0)
        Me.Controls.Add(Me._txtchungtu_1)
        Me.Controls.Add(Me._MedNgay_0)
        Me.Controls.Add(Me._MedNgay_1)
        Me.Controls.Add(Me._CmdDanhSach_1)
        Me.Controls.Add(Me._CmdDanhSach1_1)
        Me.Controls.Add(Me._Command_5)
        Me.Controls.Add(Me._Label_29)
        Me.Controls.Add(Me.LBKH)
        Me.Controls.Add(Me.Nut)
        Me.Controls.Add(Me.loai1)
        Me.Controls.Add(Me.loaino)
        Me.Controls.Add(Me._Label_28)
        Me.Controls.Add(Me._LbTT_2)
        Me.Controls.Add(Me._LbTT_1)
        Me.Controls.Add(Me._LbTT_0)
        Me.Controls.Add(Me._Label_25)
        Me.Controls.Add(Me._Label_24)
        Me.Controls.Add(Me._Label_23)
        Me.Controls.Add(Me._Label_22)
        Me.Controls.Add(Me._Label_21)
        Me.Controls.Add(Me.LBNV)
        Me.Controls.Add(Me._Label_20)
        Me.Controls.Add(Me._Label_17)
        Me.Controls.Add(Me._Label_16)
        Me.Controls.Add(Me.LbUser)
        Me.Controls.Add(Me._Label_11)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me._Label_15)
        Me.Controls.Add(Me._Label_14)
        Me.Controls.Add(Me._Line1_3)
        Me.Controls.Add(Me._Line1_2)
        Me.Controls.Add(Me._Line1_1)
        Me.Controls.Add(Me._Line1_0)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._LbKho_0)
        Me.Controls.Add(Me._LbKho_1)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Label_9)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_5)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me.MainMenu1)
        Me.Controls.Add(Me.chkXT)
        Me.Controls.Add(Me.ChkDoiTuong)
        Me.Controls.Add(Me._Label_12)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(4, 62)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmChungtutonghop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Nhập chứng từ kế toán"
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.FNhap.ResumeLayout(False)
        Me.Frame.ResumeLayout(False)
        Me.Frame.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub Initializetxtsh()
		Me.txtsh(1) = _txtsh_1
		Me.txtsh(0) = _txtsh_0
	End Sub
	Sub Initializetxtchungtu()
		Me.txtchungtu(11) = _txtchungtu_11
		Me.txtchungtu(10) = _txtchungtu_10
		Me.txtchungtu(9) = _txtchungtu_9
		Me.txtchungtu(8) = _txtchungtu_8
		Me.txtchungtu(7) = _txtchungtu_7
		Me.txtchungtu(6) = _txtchungtu_6
		Me.txtchungtu(5) = _txtchungtu_5
		Me.txtchungtu(4) = _txtchungtu_4
		Me.txtchungtu(3) = _txtchungtu_3
		Me.txtchungtu(2) = _txtchungtu_2
		Me.txtchungtu(0) = _txtchungtu_0
		Me.txtchungtu(1) = _txtchungtu_1
	End Sub
	Sub Initializetxt()
		Me.txt(5) = _txt_5
		Me.txt(4) = _txt_4
		Me.txt(3) = _txt_3
		Me.txt(2) = _txt_2
		Me.txt(0) = _txt_0
		Me.txt(1) = _txt_1
	End Sub
	Sub Initializemnpt()
		Me.mnpt(0) = _mnpt_0
		Me.mnpt(1) = _mnpt_1
	End Sub
	Sub Initializemnpc()
		Me.mnpc(0) = _mnpc_0
		Me.mnpc(1) = _mnpc_1
	End Sub
	Sub Initializemndd()
		Me.mndd(0) = _mndd_0
		Me.mndd(1) = _mndd_1
		Me.mndd(2) = _mndd_2
        'Me.mndd(3) = _mndd_3
		Me.mndd(4) = _mndd_4
		Me.mndd(5) = _mndd_5
		Me.mndd(6) = _mndd_6
		Me.mndd(7) = _mndd_7
		Me.mndd(8) = _mndd_8
		Me.mndd(9) = _mndd_9
		Me.mndd(10) = _mndd_10
        'Me.mndd(11) = _mndd_11
		Me.mndd(12) = _mndd_12
		Me.mndd(13) = _mndd_13
		Me.mndd(14) = _mndd_14
		Me.mndd(15) = _mndd_15
		Me.mndd(16) = _mndd_16
        'Me.mndd(17) = _mndd_17
		Me.mndd(18) = _mndd_18
		Me.mndd(19) = _mndd_19
		Me.mndd(20) = _mndd_20
		Me.mndd(21) = _mndd_21
        'Me.mndd(22) = _mndd_22
		Me.mndd(23) = _mndd_23
		Me.mndd(24) = _mndd_24
	End Sub
	Sub InitializemnPU()
		Me.mnPU(0) = _mnPU_0
		Me.mnPU(1) = _mnPU_1
	End Sub
	Sub InitializemnNhap()
		Me.mnNhap(0) = _mnNhap_0
		Me.mnNhap(1) = _mnNhap_1
		Me.mnNhap(2) = _mnNhap_2
		Me.mnNhap(3) = _mnNhap_3
		Me.mnNhap(4) = _mnNhap_4
		Me.mnNhap(5) = _mnNhap_5
		Me.mnNhap(6) = _mnNhap_6
		Me.mnNhap(7) = _mnNhap_7
		Me.mnNhap(8) = _mnNhap_8
		Me.mnNhap(9) = _mnNhap_9
		Me.mnNhap(10) = _mnNhap_10
		Me.mnNhap(11) = _mnNhap_11
		Me.mnNhap(12) = _mnNhap_12
	End Sub
	Sub InitializemnIn()
		Me.mnIn(0) = _mnIn_0
		Me.mnIn(1) = _mnIn_1
		Me.mnIn(2) = _mnIn_2
		Me.mnIn(3) = _mnIn_3
		Me.mnIn(4) = _mnIn_4
		Me.mnIn(5) = _mnIn_5
        'Me.mnIn(6) = _mnIn_6
		Me.mnIn(7) = _mnIn_7
		Me.mnIn(8) = _mnIn_8
		Me.mnIn(9) = _mnIn_9
	End Sub
	Sub Initializelb()
		Me.lb(1) = _lb_1
		Me.lb(0) = _lb_0
	End Sub
	Sub Initializecmd()
		Me.cmd(0) = _cmd_0
		Me.cmd(1) = _cmd_1
	End Sub
	Sub InitializeOptNhap()
		Me.OptNhap(1) = _OptNhap_1
		Me.OptNhap(0) = _OptNhap_0
		Me.OptNhap(2) = _OptNhap_2
	End Sub
    Sub InitializeOptLoai()
        Me.OptLoai(15) = _OptLoai_15
        Me.OptLoai(14) = _OptLoai_14
        Me.OptLoai(13) = _OptLoai_13
        Me.OptLoai(8) = _OptLoai_8
        Me.OptLoai(11) = _OptLoai_11
        Me.OptLoai(10) = _OptLoai_10
        Me.OptLoai(9) = _OptLoai_9
        Me.OptLoai(0) = _OptLoai_0
        Me.OptLoai(1) = _OptLoai_1
        Me.OptLoai(2) = _OptLoai_2
        Me.OptLoai(3) = _OptLoai_3
        Me.OptLoai(12) = _OptLoai_12
        Me.OptLoai(4) = _OptLoai_4
    End Sub
	Sub InitializeMedNgay()
		Me.MedNgay(0) = _MedNgay_0
		Me.MedNgay(1) = _MedNgay_1
	End Sub
	Sub InitializeLine1()
		Me.Line1(3) = _Line1_3
		Me.Line1(2) = _Line1_2
		Me.Line1(1) = _Line1_1
		Me.Line1(0) = _Line1_0
	End Sub
	Sub InitializeLbTT()
		Me.LbTT(2) = _LbTT_2
		Me.LbTT(1) = _LbTT_1
		Me.LbTT(0) = _LbTT_0
	End Sub
	Sub InitializeLbKho()
		Me.LbKho(0) = _LbKho_0
		Me.LbKho(1) = _LbKho_1
	End Sub
	Sub InitializeLabel()
		Me.Label(26) = _Label_26
		Me.Label(27) = _Label_27
		Me.Label(19) = _Label_19
		Me.Label(18) = _Label_18
		Me.Label(29) = _Label_29
		Me.Label(28) = _Label_28
		Me.Label(25) = _Label_25
		Me.Label(24) = _Label_24
		Me.Label(23) = _Label_23
		Me.Label(22) = _Label_22
		Me.Label(21) = _Label_21
		Me.Label(20) = _Label_20
		Me.Label(17) = _Label_17
		Me.Label(16) = _Label_16
		Me.Label(11) = _Label_11
		Me.Label(13) = _Label_13
		Me.Label(12) = _Label_12
		Me.Label(15) = _Label_15
		Me.Label(14) = _Label_14
		Me.Label(0) = _Label_0
		Me.Label(1) = _Label_1
		Me.Label(2) = _Label_2
		Me.Label(3) = _Label_3
		Me.Label(4) = _Label_4
		Me.Label(10) = _Label_10
		Me.Label(9) = _Label_9
		Me.Label(8) = _Label_8
		Me.Label(7) = _Label_7
		Me.Label(6) = _Label_6
		Me.Label(5) = _Label_5
	End Sub
	Sub InitializeCommand()
		Me.Command(0) = _Command_0
		Me.Command(1) = _Command_1
		Me.Command(2) = _Command_2
		Me.Command(3) = _Command_3
		Me.Command(4) = _Command_4
		Me.Command(5) = _Command_5
	End Sub
	Sub InitializeCmdPhieu()
		Me.CmdPhieu(0) = _CmdPhieu_0
		Me.CmdPhieu(1) = _CmdPhieu_1
		Me.CmdPhieu(2) = _CmdPhieu_2
		Me.CmdPhieu(3) = _CmdPhieu_3
	End Sub
	Sub InitializeCmdDanhSach1()
		Me.CmdDanhSach1(0) = _CmdDanhSach1_0
		Me.CmdDanhSach1(1) = _CmdDanhSach1_1
	End Sub
	Sub InitializeCmdDanhSach()
		Me.CmdDanhSach(0) = _CmdDanhSach_0
		Me.CmdDanhSach(1) = _CmdDanhSach_1
	End Sub
	Sub InitializeCboVV()
		Me.CboVV(2) = _CboVV_2
		Me.CboVV(1) = _CboVV_1
		Me.CboVV(0) = _CboVV_0
	End Sub
	Sub InitializeCboNguon()
		Me.CboNguon(3) = _CboNguon_3
		Me.CboNguon(2) = _CboNguon_2
		Me.CboNguon(1) = _CboNguon_1
		Me.CboNguon(0) = _CboNguon_0
	End Sub
	Sub InitializeCboNT()
		Me.CboNT(3) = _CboNT_3
		Me.CboNT(2) = _CboNT_2
		Me.CboNT(1) = _CboNT_1
		Me.CboNT(0) = _CboNT_0
    End Sub
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _OptLoai_9 As System.Windows.Forms.RadioButton
    Private WithEvents _OptLoai_15 As System.Windows.Forms.RadioButton
#End Region
End Class
