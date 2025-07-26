<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMNBaocao
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
		InitializetxtShVT()
		InitializetxtShTk()
		Initializelbkh()
		Initializelb()
		Initializecmdtk()
		Initializecmdkh()
		Initializecmd()
		InitializeOptVAT()
		InitializeOptTG()
		InitializeOptSo()
		InitializeOptQT()
		InitializeOptKho()
		InitializeOptInso()
		InitializeOptDT()
		InitializeOptCDT()
		InitializeOptBCQT()
		InitializeMedNgay()
		InitializeLine1()
		InitializeLbTenVT()
		InitializeLbTenTk()
		InitializeLabel()
		InitializeFrame4()
		InitializeFrame2()
		InitializeFrame10()
		InitializeFrame()
		InitializeCommand()
		InitializeCmdvt()
		InitializeCmd1()
		InitializeChkDu()
		InitializeChk()
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
    Private WithEvents _Cmd1_0 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_1 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_2 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_3 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_4 As System.Windows.Forms.Button
    Private WithEvents _Frame4_0 As System.Windows.Forms.GroupBox
    Private WithEvents _OptCDT_15 As System.Windows.Forms.RadioButton
    Private WithEvents _OptCDT_14 As System.Windows.Forms.RadioButton
    Private WithEvents _OptCDT_13 As System.Windows.Forms.RadioButton
    Private WithEvents _OptCDT_12 As System.Windows.Forms.RadioButton
    Private WithEvents _OptCDT_11 As System.Windows.Forms.RadioButton
    Private WithEvents _OptCDT_10 As System.Windows.Forms.RadioButton
    Private WithEvents _OptCDT_9 As System.Windows.Forms.RadioButton
    Private WithEvents _OptCDT_8 As System.Windows.Forms.RadioButton
    Private WithEvents _OptCDT_7 As System.Windows.Forms.RadioButton
    Private WithEvents _OptCDT_6 As System.Windows.Forms.RadioButton
    Private WithEvents _OptCDT_5 As System.Windows.Forms.RadioButton
    Private WithEvents _OptCDT_4 As System.Windows.Forms.RadioButton
    Private WithEvents _OptCDT_3 As System.Windows.Forms.RadioButton
    Private WithEvents _OptCDT_2 As System.Windows.Forms.RadioButton
    Private WithEvents _OptCDT_1 As System.Windows.Forms.RadioButton
    Private WithEvents _OptCDT_0 As System.Windows.Forms.RadioButton
    Private WithEvents _txtShTk_8 As System.Windows.Forms.TextBox
    Private WithEvents _txtShVT_2 As System.Windows.Forms.TextBox
    Public WithEvents CboNK As ComboBoxEx.ComboBoxExt
    Private WithEvents _cmdtk_8 As System.Windows.Forms.Button
    Private WithEvents _Cmdvt_2 As System.Windows.Forms.Button
    Private WithEvents _Line1_1 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Line1_0 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_8 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _LbTenVT_2 As System.Windows.Forms.Label
    Private WithEvents _Frame10_4 As System.Windows.Forms.GroupBox
    Private WithEvents _OptBCQT_0 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBCQT_1 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBCQT_2 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBCQT_12 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBCQT_3 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBCQT_4 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBCQT_5 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBCQT_6 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBCQT_7 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBCQT_8 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBCQT_9 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBCQT_10 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBCQT_11 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBCQT_13 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBCQT_14 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBCQT_15 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBCQT_16 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBCQT_17 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBCQT_18 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBCQT_19 As System.Windows.Forms.RadioButton
    Private WithEvents _Frame10_3 As System.Windows.Forms.GroupBox
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Public WithEvents GauGe As System.Windows.Forms.ProgressBar
    Private WithEvents _CboThang_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboThang_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Frame_0 As System.Windows.Forms.GroupBox
    Private WithEvents _MedNgay_0 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _MedNgay_1 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Frame_1 As System.Windows.Forms.GroupBox
    Private WithEvents _OptTG_0 As System.Windows.Forms.RadioButton
    Private WithEvents _OptTG_1 As System.Windows.Forms.RadioButton
    Private WithEvents _ChkDu_16 As System.Windows.Forms.CheckBox
    Private WithEvents _Command_4 As System.Windows.Forms.Button
    Public WithEvents CTGS As ComboBoxEx.ComboBoxExt
    Private WithEvents _OptSo_34 As System.Windows.Forms.RadioButton
    Private WithEvents _OptSo_35 As System.Windows.Forms.RadioButton
    Public WithEvents CboThuchi As ComboBoxEx.ComboBoxExt
    Private WithEvents _OptSo_15 As System.Windows.Forms.RadioButton
    Private WithEvents _OptKho_1 As System.Windows.Forms.RadioButton
    Private WithEvents _OptKho_0 As System.Windows.Forms.RadioButton
    Private WithEvents _CboKho_0 As ComboBoxEx.ComboBoxExt
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Private WithEvents _txtShTk_3 As System.Windows.Forms.TextBox
    Private WithEvents _ChkDu_11 As System.Windows.Forms.CheckBox
    Private WithEvents _txtShTk_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtShVT_1 As System.Windows.Forms.TextBox
    Private WithEvents _ChkDu_8 As System.Windows.Forms.CheckBox
    Private WithEvents _txtshkh_0 As System.Windows.Forms.TextBox
    Private WithEvents _OptSo_33 As System.Windows.Forms.RadioButton
    Private WithEvents _ChkDu_5 As System.Windows.Forms.CheckBox
    Private WithEvents _CboLoai_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _txtShTk_4 As System.Windows.Forms.TextBox
    Private WithEvents _ChkDu_4 As System.Windows.Forms.CheckBox
    Private WithEvents _CboLoai_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _ChkDu_7 As System.Windows.Forms.CheckBox
    Private WithEvents _txtShVT_0 As System.Windows.Forms.TextBox
    Private WithEvents _txtShTk_10 As System.Windows.Forms.TextBox
    Private WithEvents _ChkDu_0 As System.Windows.Forms.CheckBox
    Private WithEvents _txtShTk_0 As System.Windows.Forms.TextBox
    Private WithEvents _ChkDu_3 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkDu_1 As System.Windows.Forms.CheckBox
    Public WithEvents CboVV As ComboBoxEx.ComboBoxExt
    Private WithEvents _OptSo_31 As System.Windows.Forms.RadioButton
    Private WithEvents _OptSo_30 As System.Windows.Forms.RadioButton
    Private WithEvents _OptSo_29 As System.Windows.Forms.RadioButton
    Private WithEvents _OptSo_21 As System.Windows.Forms.RadioButton
    Private WithEvents _OptSo_20 As System.Windows.Forms.RadioButton
    Private WithEvents _OptSo_19 As System.Windows.Forms.RadioButton
    Private WithEvents _OptSo_16 As System.Windows.Forms.RadioButton
    Private WithEvents _OptSo_14 As System.Windows.Forms.RadioButton
    Private WithEvents _OptSo_13 As System.Windows.Forms.RadioButton
    Private WithEvents _OptSo_12 As System.Windows.Forms.RadioButton
    Private WithEvents _OptSo_9 As System.Windows.Forms.RadioButton
    Private WithEvents _OptSo_7 As System.Windows.Forms.RadioButton
    Private WithEvents _OptSo_5 As System.Windows.Forms.RadioButton
    Private WithEvents _OptSo_4 As System.Windows.Forms.RadioButton
    Private WithEvents _OptSo_3 As System.Windows.Forms.RadioButton
    Private WithEvents _OptSo_2 As System.Windows.Forms.RadioButton
    Private WithEvents _OptSo_1 As System.Windows.Forms.RadioButton
    Private WithEvents _OptSo_0 As System.Windows.Forms.RadioButton
    Private WithEvents _OptSo_6 As System.Windows.Forms.RadioButton
    Private WithEvents _OptSo_8 As System.Windows.Forms.RadioButton
    Private WithEvents _txtShTk_1 As System.Windows.Forms.TextBox
    Private WithEvents _ChkDu_2 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkDu_6 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkDu_10 As System.Windows.Forms.CheckBox
    Private WithEvents _OptSo_11 As System.Windows.Forms.RadioButton
    Private WithEvents _cmdtk_10 As System.Windows.Forms.Button
    Private WithEvents _Cmdvt_0 As System.Windows.Forms.Button
    Private WithEvents _cmdtk_1 As System.Windows.Forms.Button
    Private WithEvents _cmdtk_0 As System.Windows.Forms.Button
    Private WithEvents _cmdtk_4 As System.Windows.Forms.Button
    Private WithEvents _cmdkh_0 As System.Windows.Forms.Button
    Private WithEvents _Cmdvt_1 As System.Windows.Forms.Button
    Private WithEvents _cmdtk_2 As System.Windows.Forms.Button
    Private WithEvents _cmdtk_3 As System.Windows.Forms.Button
    Private WithEvents _LbTenTk_3 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_2 As System.Windows.Forms.Label
    Private WithEvents _LbTenVT_1 As System.Windows.Forms.Label
    Private WithEvents _lbkh_0 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_4 As System.Windows.Forms.Label
    Private WithEvents _LbTenVT_0 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_10 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_0 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_1 As System.Windows.Forms.Label
    Private WithEvents _Frame10_2 As System.Windows.Forms.GroupBox
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
    Private WithEvents _cmdtk_9 As System.Windows.Forms.Button
    Private WithEvents _lbkh_2 As System.Windows.Forms.Label
    Private WithEvents _lb_0 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_9 As System.Windows.Forms.Label
    Private WithEvents _Frame2_5 As System.Windows.Forms.GroupBox
    Private WithEvents _OptQT_7 As System.Windows.Forms.RadioButton
    Private WithEvents _OptQT_23 As System.Windows.Forms.RadioButton
    Private WithEvents _OptQT_8 As System.Windows.Forms.RadioButton
    Private WithEvents _OptQT_19 As System.Windows.Forms.RadioButton
    Private WithEvents _OptQT_22 As System.Windows.Forms.RadioButton
    Private WithEvents _OptQT_21 As System.Windows.Forms.RadioButton
    Private WithEvents _OptQT_16 As System.Windows.Forms.RadioButton
    Private WithEvents _OptQT_18 As System.Windows.Forms.RadioButton
    Private WithEvents _OptQT_17 As System.Windows.Forms.RadioButton
    Private WithEvents _OptQT_20 As System.Windows.Forms.RadioButton
    Public WithEvents CboCap As ComboBoxEx.ComboBoxExt
    Public WithEvents Chk1 As System.Windows.Forms.CheckBox
    Private WithEvents _OptQT_15 As System.Windows.Forms.RadioButton
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Frame2_3 As System.Windows.Forms.GroupBox
    Private WithEvents _OptQT_4 As System.Windows.Forms.RadioButton
    Private WithEvents _OptQT_5 As System.Windows.Forms.RadioButton
    Private WithEvents _OptQT_6 As System.Windows.Forms.RadioButton
    Private WithEvents _OptQT_0 As System.Windows.Forms.RadioButton
    Private WithEvents _OptQT_3 As System.Windows.Forms.RadioButton
    Private WithEvents _OptQT_2 As System.Windows.Forms.RadioButton
    Private WithEvents _OptQT_1 As System.Windows.Forms.RadioButton
    Private WithEvents _OptQT_9 As System.Windows.Forms.RadioButton
    Private WithEvents _OptQT_14 As System.Windows.Forms.RadioButton
    Private WithEvents _OptQT_13 As System.Windows.Forms.RadioButton
    Private WithEvents _OptQT_11 As System.Windows.Forms.RadioButton
    Private WithEvents _OptQT_10 As System.Windows.Forms.RadioButton
    Private WithEvents _OptQT_12 As System.Windows.Forms.RadioButton
    Private WithEvents _txtShTk_5 As System.Windows.Forms.TextBox
    Private WithEvents _cmdtk_5 As System.Windows.Forms.Button
    Private WithEvents _Frame2_2 As System.Windows.Forms.GroupBox
    Private WithEvents _LbTenTk_5 As System.Windows.Forms.Label
    Private WithEvents _Frame2_4 As System.Windows.Forms.GroupBox
    Private WithEvents _Frame10_1 As System.Windows.Forms.GroupBox
    Private WithEvents _ChkDu_20 As System.Windows.Forms.CheckBox
    Private WithEvents _txtShTk_14 As System.Windows.Forms.TextBox
    Private WithEvents _OptVAT_19 As System.Windows.Forms.RadioButton
    Private WithEvents _OptVAT_18 As System.Windows.Forms.RadioButton
    Private WithEvents _OptVAT_17 As System.Windows.Forms.RadioButton
    Private WithEvents _ChkDu_14 As System.Windows.Forms.CheckBox
    Private WithEvents _OptVAT_20 As System.Windows.Forms.RadioButton
    Public WithEvents cboQuy As ComboBoxEx.ComboBoxExt
    Private WithEvents _OptVAT_9 As System.Windows.Forms.RadioButton
    Private WithEvents _OptVAT_1 As System.Windows.Forms.RadioButton
    Private WithEvents _OptVAT_0 As System.Windows.Forms.RadioButton
    Private WithEvents _OptVAT_2 As System.Windows.Forms.RadioButton
    Private WithEvents _OptVAT_3 As System.Windows.Forms.RadioButton
    Private WithEvents _OptVAT_6 As System.Windows.Forms.RadioButton
    Public WithEvents CboTL As ComboBoxEx.ComboBoxExt
    Private WithEvents _OptVAT_5 As System.Windows.Forms.RadioButton
    Private WithEvents _OptVAT_7 As System.Windows.Forms.RadioButton
    Private WithEvents _OptVAT_8 As System.Windows.Forms.RadioButton
    Private WithEvents _ChkDu_15 As System.Windows.Forms.CheckBox
    Private WithEvents _txtShTk_15 As System.Windows.Forms.TextBox
    Private WithEvents _OptVAT_10 As System.Windows.Forms.RadioButton
    Private WithEvents _txtShTk_11 As System.Windows.Forms.TextBox
    Private WithEvents _txtShTk_7 As System.Windows.Forms.TextBox
    Private WithEvents _Chk_7 As System.Windows.Forms.CheckBox
    Private WithEvents _OptVAT_11 As System.Windows.Forms.RadioButton
    Private WithEvents _OptVAT_4 As System.Windows.Forms.RadioButton
    Private WithEvents _Chk_1 As System.Windows.Forms.CheckBox
    Private WithEvents _OptVAT_12 As System.Windows.Forms.RadioButton
    Private WithEvents _OptVAT_13 As System.Windows.Forms.RadioButton
    Private WithEvents _OptVAT_15 As System.Windows.Forms.RadioButton
    Private WithEvents _OptVAT_14 As System.Windows.Forms.RadioButton
    Private WithEvents _OptVAT_16 As System.Windows.Forms.RadioButton
    Private WithEvents _cmdtk_7 As System.Windows.Forms.Button
    Private WithEvents _cmdtk_11 As System.Windows.Forms.Button
    Private WithEvents _cmdtk_15 As System.Windows.Forms.Button
    Private WithEvents _Frame2_0 As System.Windows.Forms.GroupBox
    Private WithEvents _cmdtk_14 As System.Windows.Forms.Button
    Private WithEvents _LbTenTk_14 As System.Windows.Forms.Label
    Private WithEvents _Frame2_1 As System.Windows.Forms.GroupBox
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_11 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_15 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_7 As System.Windows.Forms.Label
    Private WithEvents _Frame10_0 As System.Windows.Forms.GroupBox
    Public CboKho(2) As ComboBoxEx.ComboBoxExt
    Public CboLoai(1) As ComboBoxEx.ComboBoxExt
    Public CboThang(1) As ComboBoxEx.ComboBoxExt
    Public Chk(7) As System.Windows.Forms.CheckBox
    Public ChkDu(20) As System.Windows.Forms.CheckBox
    Public Cmd1(4) As System.Windows.Forms.Button
    Public Cmdvt(2) As System.Windows.Forms.Button
    Public Command(4) As System.Windows.Forms.Button
    Public Frame(1) As System.Windows.Forms.GroupBox
    Public Frame10(6) As System.Windows.Forms.GroupBox
    Public Frame2(5) As System.Windows.Forms.GroupBox
    Public Frame4(0) As System.Windows.Forms.GroupBox
    Public Label(8) As System.Windows.Forms.Label
    Public LbTenTk(15) As System.Windows.Forms.Label
    Public LbTenVT(2) As System.Windows.Forms.Label
    Public Line1(1) As System.Windows.Forms.Label
    Public MedNgay(1) As System.Windows.Forms.MaskedTextBox
    Public OptBCQT(19) As System.Windows.Forms.RadioButton
    Public OptCDT(15) As System.Windows.Forms.RadioButton
    Public OptDT(2) As System.Windows.Forms.RadioButton
    Public OptInso(7) As System.Windows.Forms.RadioButton
    Public OptKho(1) As System.Windows.Forms.RadioButton
    Public OptQT(23) As System.Windows.Forms.RadioButton
    Public OptSo(35) As System.Windows.Forms.RadioButton
    Public OptTG(1) As System.Windows.Forms.RadioButton
    Public OptVAT(20) As System.Windows.Forms.RadioButton
    Public cmd(0) As System.Windows.Forms.Button
    Public cmdkh(2) As System.Windows.Forms.Button
    Public cmdtk(15) As System.Windows.Forms.Button
    Public lb(0) As System.Windows.Forms.Label
    Public lbkh(2) As System.Windows.Forms.Label
    Public txtShTk(15) As System.Windows.Forms.TextBox
    Public txtShVT(2) As System.Windows.Forms.TextBox
    Public txtsh(0) As System.Windows.Forms.TextBox
    Public txtshkh(2) As System.Windows.Forms.TextBox
    Public OptNN(1) As System.Windows.Forms.RadioButton
    'Private listBoxComboBoxHelper1 As Artinsoft.VB6.Gui.ListControlHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMNBaocao))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._ChkDu_0 = New System.Windows.Forms.CheckBox
        Me._ChkDu_1 = New System.Windows.Forms.CheckBox
        Me._Frame4_0 = New System.Windows.Forms.GroupBox
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Frame_1 = New System.Windows.Forms.GroupBox
        Me._MedNgay_0 = New System.Windows.Forms.MaskedTextBox
        Me._MedNgay_1 = New System.Windows.Forms.MaskedTextBox
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Label_5 = New System.Windows.Forms.Label
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Frame_0 = New System.Windows.Forms.GroupBox
        Me._CboThang_1 = New ComboBoxEx.ComboBoxExt
        Me._CboThang_0 = New ComboBoxEx.ComboBoxExt
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me.GauGe = New System.Windows.Forms.ProgressBar
        Me._Command_4 = New System.Windows.Forms.Button
        Me._OptTG_0 = New System.Windows.Forms.RadioButton
        Me._ChkDu_16 = New System.Windows.Forms.CheckBox
        Me._OptTG_1 = New System.Windows.Forms.RadioButton
        Me._Cmd1_0 = New System.Windows.Forms.Button
        Me._Cmd1_1 = New System.Windows.Forms.Button
        Me._Cmd1_2 = New System.Windows.Forms.Button
        Me._Cmd1_3 = New System.Windows.Forms.Button
        Me._Cmd1_4 = New System.Windows.Forms.Button
        Me._Frame10_2 = New System.Windows.Forms.GroupBox
        Me.CTGS = New ComboBoxEx.ComboBoxExt
        Me._OptSo_34 = New System.Windows.Forms.RadioButton
        Me._OptSo_35 = New System.Windows.Forms.RadioButton
        Me.CboThuchi = New ComboBoxEx.ComboBoxExt
        Me._OptSo_15 = New System.Windows.Forms.RadioButton
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me._OptKho_1 = New System.Windows.Forms.RadioButton
        Me._OptKho_0 = New System.Windows.Forms.RadioButton
        Me._CboKho_0 = New ComboBoxEx.ComboBoxExt
        Me._txtShTk_3 = New System.Windows.Forms.TextBox
        Me._ChkDu_11 = New System.Windows.Forms.CheckBox
        Me._txtShTk_2 = New System.Windows.Forms.TextBox
        Me._txtShVT_1 = New System.Windows.Forms.TextBox
        Me._ChkDu_8 = New System.Windows.Forms.CheckBox
        Me._txtshkh_0 = New System.Windows.Forms.TextBox
        Me._OptSo_33 = New System.Windows.Forms.RadioButton
        Me._ChkDu_5 = New System.Windows.Forms.CheckBox
        Me._CboLoai_0 = New ComboBoxEx.ComboBoxExt
        Me._txtShTk_4 = New System.Windows.Forms.TextBox
        Me._ChkDu_4 = New System.Windows.Forms.CheckBox
        Me._CboLoai_1 = New ComboBoxEx.ComboBoxExt
        Me._ChkDu_7 = New System.Windows.Forms.CheckBox
        Me._txtShVT_0 = New System.Windows.Forms.TextBox
        Me._txtShTk_10 = New System.Windows.Forms.TextBox
        Me._txtShTk_0 = New System.Windows.Forms.TextBox
        Me._ChkDu_3 = New System.Windows.Forms.CheckBox
        Me.CboVV = New ComboBoxEx.ComboBoxExt
        Me._OptSo_31 = New System.Windows.Forms.RadioButton
        Me._OptSo_30 = New System.Windows.Forms.RadioButton
        Me._OptSo_29 = New System.Windows.Forms.RadioButton
        Me._OptSo_21 = New System.Windows.Forms.RadioButton
        Me._OptSo_20 = New System.Windows.Forms.RadioButton
        Me._OptSo_19 = New System.Windows.Forms.RadioButton
        Me._OptSo_16 = New System.Windows.Forms.RadioButton
        Me._OptSo_14 = New System.Windows.Forms.RadioButton
        Me._OptSo_13 = New System.Windows.Forms.RadioButton
        Me._OptSo_12 = New System.Windows.Forms.RadioButton
        Me._OptSo_9 = New System.Windows.Forms.RadioButton
        Me._OptSo_7 = New System.Windows.Forms.RadioButton
        Me._OptSo_5 = New System.Windows.Forms.RadioButton
        Me._OptSo_4 = New System.Windows.Forms.RadioButton
        Me._OptSo_3 = New System.Windows.Forms.RadioButton
        Me._OptSo_2 = New System.Windows.Forms.RadioButton
        Me._OptSo_1 = New System.Windows.Forms.RadioButton
        Me._OptSo_0 = New System.Windows.Forms.RadioButton
        Me._OptSo_6 = New System.Windows.Forms.RadioButton
        Me._OptSo_8 = New System.Windows.Forms.RadioButton
        Me._txtShTk_1 = New System.Windows.Forms.TextBox
        Me._ChkDu_2 = New System.Windows.Forms.CheckBox
        Me._ChkDu_6 = New System.Windows.Forms.CheckBox
        Me._ChkDu_10 = New System.Windows.Forms.CheckBox
        Me._OptSo_11 = New System.Windows.Forms.RadioButton
        Me._cmdtk_10 = New System.Windows.Forms.Button
        Me._Cmdvt_0 = New System.Windows.Forms.Button
        Me._cmdtk_1 = New System.Windows.Forms.Button
        Me._cmdtk_0 = New System.Windows.Forms.Button
        Me._cmdtk_4 = New System.Windows.Forms.Button
        Me._cmdkh_0 = New System.Windows.Forms.Button
        Me._Cmdvt_1 = New System.Windows.Forms.Button
        Me._cmdtk_2 = New System.Windows.Forms.Button
        Me._cmdtk_3 = New System.Windows.Forms.Button
        Me._LbTenTk_3 = New System.Windows.Forms.Label
        Me._LbTenTk_2 = New System.Windows.Forms.Label
        Me._LbTenVT_1 = New System.Windows.Forms.Label
        Me._lbkh_0 = New System.Windows.Forms.Label
        Me._LbTenTk_4 = New System.Windows.Forms.Label
        Me._LbTenTk_10 = New System.Windows.Forms.Label
        Me._LbTenTk_0 = New System.Windows.Forms.Label
        Me._LbTenTk_1 = New System.Windows.Forms.Label
        Me._LbTenVT_0 = New System.Windows.Forms.Label
        Me._Frame10_4 = New System.Windows.Forms.GroupBox
        Me._OptCDT_15 = New System.Windows.Forms.RadioButton
        Me._OptCDT_14 = New System.Windows.Forms.RadioButton
        Me._OptCDT_13 = New System.Windows.Forms.RadioButton
        Me._OptCDT_12 = New System.Windows.Forms.RadioButton
        Me._OptCDT_11 = New System.Windows.Forms.RadioButton
        Me._OptCDT_10 = New System.Windows.Forms.RadioButton
        Me._OptCDT_9 = New System.Windows.Forms.RadioButton
        Me._OptCDT_8 = New System.Windows.Forms.RadioButton
        Me._OptCDT_7 = New System.Windows.Forms.RadioButton
        Me._OptCDT_6 = New System.Windows.Forms.RadioButton
        Me._OptCDT_5 = New System.Windows.Forms.RadioButton
        Me._OptCDT_4 = New System.Windows.Forms.RadioButton
        Me._OptCDT_3 = New System.Windows.Forms.RadioButton
        Me._OptCDT_2 = New System.Windows.Forms.RadioButton
        Me._OptCDT_1 = New System.Windows.Forms.RadioButton
        Me._OptCDT_0 = New System.Windows.Forms.RadioButton
        Me._txtShTk_8 = New System.Windows.Forms.TextBox
        Me._txtShVT_2 = New System.Windows.Forms.TextBox
        Me.CboNK = New ComboBoxEx.ComboBoxExt
        Me._cmdtk_8 = New System.Windows.Forms.Button
        Me._Cmdvt_2 = New System.Windows.Forms.Button
        Me._Line1_1 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Line1_0 = New System.Windows.Forms.Label
        Me._LbTenTk_8 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._LbTenVT_2 = New System.Windows.Forms.Label
        Me._Frame10_3 = New System.Windows.Forms.GroupBox
        Me._OptBCQT_0 = New System.Windows.Forms.RadioButton
        Me._OptBCQT_1 = New System.Windows.Forms.RadioButton
        Me._OptBCQT_2 = New System.Windows.Forms.RadioButton
        Me._OptBCQT_12 = New System.Windows.Forms.RadioButton
        Me._OptBCQT_3 = New System.Windows.Forms.RadioButton
        Me._OptBCQT_4 = New System.Windows.Forms.RadioButton
        Me._OptBCQT_5 = New System.Windows.Forms.RadioButton
        Me._OptBCQT_6 = New System.Windows.Forms.RadioButton
        Me._OptBCQT_7 = New System.Windows.Forms.RadioButton
        Me._OptBCQT_8 = New System.Windows.Forms.RadioButton
        Me._OptBCQT_9 = New System.Windows.Forms.RadioButton
        Me._OptBCQT_10 = New System.Windows.Forms.RadioButton
        Me._OptBCQT_11 = New System.Windows.Forms.RadioButton
        Me._OptBCQT_13 = New System.Windows.Forms.RadioButton
        Me._OptBCQT_14 = New System.Windows.Forms.RadioButton
        Me._OptBCQT_15 = New System.Windows.Forms.RadioButton
        Me._OptBCQT_16 = New System.Windows.Forms.RadioButton
        Me._OptBCQT_17 = New System.Windows.Forms.RadioButton
        Me._OptBCQT_18 = New System.Windows.Forms.RadioButton
        Me._OptBCQT_19 = New System.Windows.Forms.RadioButton
        Me._Frame10_1 = New System.Windows.Forms.GroupBox
        Me._Frame2_5 = New System.Windows.Forms.GroupBox
        Me._cmd_0 = New System.Windows.Forms.Button
        Me._cmdkh_2 = New System.Windows.Forms.Button
        Me._OptDT_2 = New System.Windows.Forms.RadioButton
        Me._CboKho_2 = New ComboBoxEx.ComboBoxExt
        Me._txtsh_0 = New System.Windows.Forms.TextBox
        Me._ChkDu_13 = New System.Windows.Forms.CheckBox
        Me._OptDT_0 = New System.Windows.Forms.RadioButton
        Me._CboKho_1 = New ComboBoxEx.ComboBoxExt
        Me._txtshkh_2 = New System.Windows.Forms.TextBox
        Me._ChkDu_18 = New System.Windows.Forms.CheckBox
        Me._ChkDu_9 = New System.Windows.Forms.CheckBox
        Me._ChkDu_19 = New System.Windows.Forms.CheckBox
        Me._ChkDu_17 = New System.Windows.Forms.CheckBox
        Me._OptDT_1 = New System.Windows.Forms.RadioButton
        Me._ChkDu_12 = New System.Windows.Forms.CheckBox
        Me._txtShTk_9 = New System.Windows.Forms.TextBox
        Me._cmdtk_9 = New System.Windows.Forms.Button
        Me._lbkh_2 = New System.Windows.Forms.Label
        Me._lb_0 = New System.Windows.Forms.Label
        Me._LbTenTk_9 = New System.Windows.Forms.Label
        Me._OptQT_7 = New System.Windows.Forms.RadioButton
        Me._OptQT_23 = New System.Windows.Forms.RadioButton
        Me._OptQT_8 = New System.Windows.Forms.RadioButton
        Me._OptQT_19 = New System.Windows.Forms.RadioButton
        Me._OptQT_22 = New System.Windows.Forms.RadioButton
        Me._OptQT_21 = New System.Windows.Forms.RadioButton
        Me._OptQT_16 = New System.Windows.Forms.RadioButton
        Me._OptQT_18 = New System.Windows.Forms.RadioButton
        Me._OptQT_17 = New System.Windows.Forms.RadioButton
        Me._OptQT_20 = New System.Windows.Forms.RadioButton
        Me.CboCap = New ComboBoxEx.ComboBoxExt
        Me.Chk1 = New System.Windows.Forms.CheckBox
        Me._OptQT_15 = New System.Windows.Forms.RadioButton
        Me._Frame2_3 = New System.Windows.Forms.GroupBox
        Me._Label_3 = New System.Windows.Forms.Label
        Me._OptQT_4 = New System.Windows.Forms.RadioButton
        Me._OptQT_5 = New System.Windows.Forms.RadioButton
        Me._OptQT_6 = New System.Windows.Forms.RadioButton
        Me._OptQT_0 = New System.Windows.Forms.RadioButton
        Me._OptQT_3 = New System.Windows.Forms.RadioButton
        Me._OptQT_2 = New System.Windows.Forms.RadioButton
        Me._OptQT_1 = New System.Windows.Forms.RadioButton
        Me._OptQT_9 = New System.Windows.Forms.RadioButton
        Me._OptQT_14 = New System.Windows.Forms.RadioButton
        Me._OptQT_13 = New System.Windows.Forms.RadioButton
        Me._OptQT_11 = New System.Windows.Forms.RadioButton
        Me._OptQT_10 = New System.Windows.Forms.RadioButton
        Me._OptQT_12 = New System.Windows.Forms.RadioButton
        Me._txtShTk_5 = New System.Windows.Forms.TextBox
        Me._cmdtk_5 = New System.Windows.Forms.Button
        Me._Frame2_2 = New System.Windows.Forms.GroupBox
        Me._Frame2_4 = New System.Windows.Forms.GroupBox
        Me._LbTenTk_5 = New System.Windows.Forms.Label
        Me._Frame10_0 = New System.Windows.Forms.GroupBox
        Me._ChkDu_20 = New System.Windows.Forms.CheckBox
        Me._txtShTk_14 = New System.Windows.Forms.TextBox
        Me._OptVAT_19 = New System.Windows.Forms.RadioButton
        Me._OptVAT_18 = New System.Windows.Forms.RadioButton
        Me._OptVAT_17 = New System.Windows.Forms.RadioButton
        Me._ChkDu_14 = New System.Windows.Forms.CheckBox
        Me._OptVAT_20 = New System.Windows.Forms.RadioButton
        Me.cboQuy = New ComboBoxEx.ComboBoxExt
        Me._OptVAT_9 = New System.Windows.Forms.RadioButton
        Me._OptVAT_1 = New System.Windows.Forms.RadioButton
        Me._OptVAT_0 = New System.Windows.Forms.RadioButton
        Me._OptVAT_2 = New System.Windows.Forms.RadioButton
        Me._OptVAT_3 = New System.Windows.Forms.RadioButton
        Me._OptVAT_6 = New System.Windows.Forms.RadioButton
        Me.CboTL = New ComboBoxEx.ComboBoxExt
        Me._OptVAT_5 = New System.Windows.Forms.RadioButton
        Me._OptVAT_7 = New System.Windows.Forms.RadioButton
        Me._OptVAT_8 = New System.Windows.Forms.RadioButton
        Me._ChkDu_15 = New System.Windows.Forms.CheckBox
        Me._txtShTk_15 = New System.Windows.Forms.TextBox
        Me._OptVAT_10 = New System.Windows.Forms.RadioButton
        Me._txtShTk_11 = New System.Windows.Forms.TextBox
        Me._txtShTk_7 = New System.Windows.Forms.TextBox
        Me._Chk_7 = New System.Windows.Forms.CheckBox
        Me._OptVAT_11 = New System.Windows.Forms.RadioButton
        Me._OptVAT_4 = New System.Windows.Forms.RadioButton
        Me._Chk_1 = New System.Windows.Forms.CheckBox
        Me._OptVAT_12 = New System.Windows.Forms.RadioButton
        Me._OptVAT_13 = New System.Windows.Forms.RadioButton
        Me._OptVAT_15 = New System.Windows.Forms.RadioButton
        Me._OptVAT_14 = New System.Windows.Forms.RadioButton
        Me._OptVAT_16 = New System.Windows.Forms.RadioButton
        Me._cmdtk_7 = New System.Windows.Forms.Button
        Me._cmdtk_11 = New System.Windows.Forms.Button
        Me._cmdtk_15 = New System.Windows.Forms.Button
        Me._Frame2_0 = New System.Windows.Forms.GroupBox
        Me._cmdtk_14 = New System.Windows.Forms.Button
        Me._Frame2_1 = New System.Windows.Forms.GroupBox
        Me._LbTenTk_14 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._LbTenTk_11 = New System.Windows.Forms.Label
        Me._LbTenTk_15 = New System.Windows.Forms.Label
        Me._LbTenTk_7 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Tab_Accounting = New System.Windows.Forms.TabPage
        Me.Tab_Tax_Report = New System.Windows.Forms.TabPage
        Me.Tab_VAT_Reports = New System.Windows.Forms.TabPage
        Me.Tab_Investoes_reports = New System.Windows.Forms.TabPage
        Me.Tab_Management_Reports = New System.Windows.Forms.TabPage
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me._Frame4_0.SuspendLayout()
        Me._Frame_1.SuspendLayout()
        Me._Frame_0.SuspendLayout()
        Me._Frame10_2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me._Frame10_4.SuspendLayout()
        Me._Frame10_3.SuspendLayout()
        Me._Frame10_1.SuspendLayout()
        Me._Frame2_5.SuspendLayout()
        Me._Frame2_3.SuspendLayout()
        Me._Frame2_4.SuspendLayout()
        Me._Frame10_0.SuspendLayout()
        Me._Frame2_1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Tab_Accounting.SuspendLayout()
        Me.Tab_Tax_Report.SuspendLayout()
        Me.Tab_VAT_Reports.SuspendLayout()
        Me.Tab_Investoes_reports.SuspendLayout()
        Me.Tab_Management_Reports.SuspendLayout()
        Me.SuspendLayout()
        '
        '_ChkDu_0
        '
        Me._ChkDu_0.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_0.Location = New System.Drawing.Point(152, 112)
        Me._ChkDu_0.Name = "_ChkDu_0"
        Me._ChkDu_0.Size = New System.Drawing.Size(97, 17)
        Me._ChkDu_0.TabIndex = 68
        Me._ChkDu_0.Tag = "by Ref. Acc."
        Me._ChkDu_0.Text = "TK đối ứng"
        Me.ToolTipMain.SetToolTip(Me._ChkDu_0, "by Ref. Acc.")
        Me._ChkDu_0.UseVisualStyleBackColor = False
        '
        '_ChkDu_1
        '
        Me._ChkDu_1.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_1.Location = New System.Drawing.Point(152, 16)
        Me._ChkDu_1.Name = "_ChkDu_1"
        Me._ChkDu_1.Size = New System.Drawing.Size(101, 17)
        Me._ChkDu_1.TabIndex = 64
        Me._ChkDu_1.Tag = "Index"
        Me._ChkDu_1.Text = "Theo hợp đồng"
        Me.ToolTipMain.SetToolTip(Me._ChkDu_1, "by Object")
        Me._ChkDu_1.UseVisualStyleBackColor = False
        '
        '_Frame4_0
        '
        Me._Frame4_0.BackColor = System.Drawing.Color.Transparent
        Me._Frame4_0.Controls.Add(Me._Command_3)
        Me._Frame4_0.Controls.Add(Me._Frame_1)
        Me._Frame4_0.Controls.Add(Me._Command_2)
        Me._Frame4_0.Controls.Add(Me._Command_1)
        Me._Frame4_0.Controls.Add(Me._Command_0)
        Me._Frame4_0.Controls.Add(Me._Frame_0)
        Me._Frame4_0.Controls.Add(Me.GauGe)
        Me._Frame4_0.Controls.Add(Me._Command_4)
        Me._Frame4_0.Controls.Add(Me._OptTG_0)
        Me._Frame4_0.Controls.Add(Me._ChkDu_16)
        Me._Frame4_0.Controls.Add(Me._OptTG_1)
        Me._Frame4_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame4_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame4_0.Location = New System.Drawing.Point(654, 14)
        Me._Frame4_0.Name = "_Frame4_0"
        Me._Frame4_0.Size = New System.Drawing.Size(465, 104)
        Me._Frame4_0.TabIndex = 135
        Me._Frame4_0.TabStop = False
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.excel16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(279, 67)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(100, 25)
        Me._Command_3.TabIndex = 133
        Me._Command_3.Tag = "Export Excel"
        Me._Command_3.Text = "Xuất &Excel"
        Me._Command_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Frame_1
        '
        Me._Frame_1.BackColor = System.Drawing.Color.Transparent
        Me._Frame_1.Controls.Add(Me._MedNgay_0)
        Me._Frame_1.Controls.Add(Me._MedNgay_1)
        Me._Frame_1.Controls.Add(Me._Label_4)
        Me._Frame_1.Controls.Add(Me._Label_5)
        Me._Frame_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_1.Location = New System.Drawing.Point(118, 5)
        Me._Frame_1.Name = "_Frame_1"
        Me._Frame_1.Size = New System.Drawing.Size(339, 33)
        Me._Frame_1.TabIndex = 138
        Me._Frame_1.TabStop = False
        Me._Frame_1.Visible = False
        '
        '_MedNgay_0
        '
        Me._MedNgay_0.AllowPromptAsInput = False
        Me._MedNgay_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_0.Location = New System.Drawing.Point(67, 8)
        Me._MedNgay_0.Mask = "00/00/0000"
        Me._MedNgay_0.Name = "_MedNgay_0"
        Me._MedNgay_0.Size = New System.Drawing.Size(67, 20)
        Me._MedNgay_0.TabIndex = 126
        '
        '_MedNgay_1
        '
        Me._MedNgay_1.AllowPromptAsInput = False
        Me._MedNgay_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_1.Location = New System.Drawing.Point(215, 8)
        Me._MedNgay_1.Mask = "00/00/0000"
        Me._MedNgay_1.Name = "_MedNgay_1"
        Me._MedNgay_1.Size = New System.Drawing.Size(67, 20)
        Me._MedNgay_1.TabIndex = 127
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.Transparent
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_4.Location = New System.Drawing.Point(8, 10)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(57, 17)
        Me._Label_4.TabIndex = 140
        Me._Label_4.Tag = "From"
        Me._Label_4.Text = "Từ ngày"
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.Transparent
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_5.Location = New System.Drawing.Point(146, 10)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(57, 17)
        Me._Label_5.TabIndex = 139
        Me._Label_5.Tag = "to"
        Me._Label_5.Text = "Đến ngày"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(387, 67)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(70, 25)
        Me._Command_2.TabIndex = 132
        Me._Command_2.Tag = "Return"
        Me._Command_2.Text = "Trở &về"
        Me._Command_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.print16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(123, 67)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(70, 25)
        Me._Command_1.TabIndex = 130
        Me._Command_1.Tag = "Print"
        Me._Command_1.Text = "&In"
        Me._Command_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.report16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(45, 67)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(70, 25)
        Me._Command_0.TabIndex = 129
        Me._Command_0.Tag = "Preview"
        Me._Command_0.Text = "&Xem"
        Me._Command_0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me._Frame_0.Location = New System.Drawing.Point(118, 5)
        Me._Frame_0.Name = "_Frame_0"
        Me._Frame_0.Size = New System.Drawing.Size(339, 33)
        Me._Frame_0.TabIndex = 141
        Me._Frame_0.TabStop = False
        '
        '_CboThang_1
        '
        Me._CboThang_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_1.Location = New System.Drawing.Point(215, 9)
        Me._CboThang_1.Name = "_CboThang_1"
        Me._CboThang_1.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_1.TabIndex = 125
        '
        '_CboThang_0
        '
        Me._CboThang_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_0.Location = New System.Drawing.Point(67, 9)
        Me._CboThang_0.Name = "_CboThang_0"
        Me._CboThang_0.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_0.TabIndex = 124
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(146, 11)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(62, 17)
        Me._Label_1.TabIndex = 143
        Me._Label_1.Tag = "to"
        Me._Label_1.Text = "Đến tháng"
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(8, 11)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(53, 17)
        Me._Label_0.TabIndex = 142
        Me._Label_0.Tag = "From"
        Me._Label_0.Text = "Từ tháng"
        '
        'GauGe
        '
        Me.GauGe.Location = New System.Drawing.Point(219, 45)
        Me.GauGe.Name = "GauGe"
        Me.GauGe.Size = New System.Drawing.Size(238, 17)
        Me.GauGe.TabIndex = 134
        '
        '_Command_4
        '
        Me._Command_4.Image = Global.UNET.My.Resources.Resources.search16
        Me._Command_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_4.Location = New System.Drawing.Point(201, 67)
        Me._Command_4.Name = "_Command_4"
        Me._Command_4.Size = New System.Drawing.Size(70, 25)
        Me._Command_4.TabIndex = 131
        Me._Command_4.Tag = "Print books"
        Me._Command_4.Text = "In &sổ"
        Me._Command_4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_OptTG_0
        '
        Me._OptTG_0.BackColor = System.Drawing.Color.Transparent
        Me._OptTG_0.Checked = True
        Me._OptTG_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptTG_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptTG_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptTG_0.Location = New System.Drawing.Point(15, 14)
        Me._OptTG_0.Name = "_OptTG_0"
        Me._OptTG_0.Size = New System.Drawing.Size(95, 17)
        Me._OptTG_0.TabIndex = 122
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
        Me._ChkDu_16.Location = New System.Drawing.Point(118, 45)
        Me._ChkDu_16.Name = "_ChkDu_16"
        Me._ChkDu_16.Size = New System.Drawing.Size(95, 17)
        Me._ChkDu_16.TabIndex = 128
        Me._ChkDu_16.Tag = "List view"
        Me._ChkDu_16.Text = "&Hiển thị lưới"
        Me._ChkDu_16.UseVisualStyleBackColor = False
        '
        '_OptTG_1
        '
        Me._OptTG_1.BackColor = System.Drawing.Color.Transparent
        Me._OptTG_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptTG_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptTG_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptTG_1.Location = New System.Drawing.Point(15, 45)
        Me._OptTG_1.Name = "_OptTG_1"
        Me._OptTG_1.Size = New System.Drawing.Size(95, 17)
        Me._OptTG_1.TabIndex = 123
        Me._OptTG_1.TabStop = True
        Me._OptTG_1.Tag = "By date"
        Me._OptTG_1.Text = "Theo ngày"
        Me._OptTG_1.UseVisualStyleBackColor = False
        '
        '_Cmd1_0
        '
        Me._Cmd1_0.Location = New System.Drawing.Point(764, 306)
        Me._Cmd1_0.Name = "_Cmd1_0"
        Me._Cmd1_0.Size = New System.Drawing.Size(73, 73)
        Me._Cmd1_0.TabIndex = 0
        Me._Cmd1_0.Tag = "VAT"
        Me._Cmd1_0.Text = "Thuế GTGT"
        Me._Cmd1_0.Visible = False
        '
        '_Cmd1_1
        '
        Me._Cmd1_1.Location = New System.Drawing.Point(843, 306)
        Me._Cmd1_1.Name = "_Cmd1_1"
        Me._Cmd1_1.Size = New System.Drawing.Size(73, 73)
        Me._Cmd1_1.TabIndex = 1
        Me._Cmd1_1.Tag = "Tax Reports"
        Me._Cmd1_1.Text = "Báo cáo thuế"
        Me._Cmd1_1.Visible = False
        '
        '_Cmd1_2
        '
        Me._Cmd1_2.Location = New System.Drawing.Point(922, 306)
        Me._Cmd1_2.Name = "_Cmd1_2"
        Me._Cmd1_2.Size = New System.Drawing.Size(73, 73)
        Me._Cmd1_2.TabIndex = 2
        Me._Cmd1_2.Tag = "Book Reports"
        Me._Cmd1_2.Text = "Sổ kế toán"
        Me._Cmd1_2.Visible = False
        '
        '_Cmd1_3
        '
        Me._Cmd1_3.Location = New System.Drawing.Point(669, 306)
        Me._Cmd1_3.Name = "_Cmd1_3"
        Me._Cmd1_3.Size = New System.Drawing.Size(73, 73)
        Me._Cmd1_3.TabIndex = 183
        Me._Cmd1_3.Tag = "Management Reports"
        Me._Cmd1_3.Text = "Báo cáo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "quản trị"
        Me._Cmd1_3.Visible = False
        '
        '_Cmd1_4
        '
        Me._Cmd1_4.Location = New System.Drawing.Point(1001, 306)
        Me._Cmd1_4.Name = "_Cmd1_4"
        Me._Cmd1_4.Size = New System.Drawing.Size(73, 73)
        Me._Cmd1_4.TabIndex = 184
        Me._Cmd1_4.Tag = "Investment accounting"
        Me._Cmd1_4.Text = "Kế toán " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "chủ đầu tư"
        Me._Cmd1_4.Visible = False
        '
        '_Frame10_2
        '
        Me._Frame10_2.BackColor = System.Drawing.Color.Transparent
        Me._Frame10_2.Controls.Add(Me.CTGS)
        Me._Frame10_2.Controls.Add(Me._OptSo_34)
        Me._Frame10_2.Controls.Add(Me._OptSo_35)
        Me._Frame10_2.Controls.Add(Me.CboThuchi)
        Me._Frame10_2.Controls.Add(Me._OptSo_15)
        Me._Frame10_2.Controls.Add(Me.Frame1)
        Me._Frame10_2.Controls.Add(Me._txtShTk_3)
        Me._Frame10_2.Controls.Add(Me._ChkDu_11)
        Me._Frame10_2.Controls.Add(Me._txtShTk_2)
        Me._Frame10_2.Controls.Add(Me._txtShVT_1)
        Me._Frame10_2.Controls.Add(Me._ChkDu_8)
        Me._Frame10_2.Controls.Add(Me._txtshkh_0)
        Me._Frame10_2.Controls.Add(Me._OptSo_33)
        Me._Frame10_2.Controls.Add(Me._ChkDu_5)
        Me._Frame10_2.Controls.Add(Me._CboLoai_0)
        Me._Frame10_2.Controls.Add(Me._txtShTk_4)
        Me._Frame10_2.Controls.Add(Me._ChkDu_4)
        Me._Frame10_2.Controls.Add(Me._CboLoai_1)
        Me._Frame10_2.Controls.Add(Me._ChkDu_7)
        Me._Frame10_2.Controls.Add(Me._txtShVT_0)
        Me._Frame10_2.Controls.Add(Me._txtShTk_10)
        Me._Frame10_2.Controls.Add(Me._ChkDu_0)
        Me._Frame10_2.Controls.Add(Me._txtShTk_0)
        Me._Frame10_2.Controls.Add(Me._ChkDu_3)
        Me._Frame10_2.Controls.Add(Me._ChkDu_1)
        Me._Frame10_2.Controls.Add(Me.CboVV)
        Me._Frame10_2.Controls.Add(Me._OptSo_31)
        Me._Frame10_2.Controls.Add(Me._OptSo_30)
        Me._Frame10_2.Controls.Add(Me._OptSo_29)
        Me._Frame10_2.Controls.Add(Me._OptSo_21)
        Me._Frame10_2.Controls.Add(Me._OptSo_20)
        Me._Frame10_2.Controls.Add(Me._OptSo_19)
        Me._Frame10_2.Controls.Add(Me._OptSo_16)
        Me._Frame10_2.Controls.Add(Me._OptSo_14)
        Me._Frame10_2.Controls.Add(Me._OptSo_13)
        Me._Frame10_2.Controls.Add(Me._OptSo_12)
        Me._Frame10_2.Controls.Add(Me._OptSo_9)
        Me._Frame10_2.Controls.Add(Me._OptSo_7)
        Me._Frame10_2.Controls.Add(Me._OptSo_5)
        Me._Frame10_2.Controls.Add(Me._OptSo_4)
        Me._Frame10_2.Controls.Add(Me._OptSo_3)
        Me._Frame10_2.Controls.Add(Me._OptSo_2)
        Me._Frame10_2.Controls.Add(Me._OptSo_1)
        Me._Frame10_2.Controls.Add(Me._OptSo_0)
        Me._Frame10_2.Controls.Add(Me._OptSo_6)
        Me._Frame10_2.Controls.Add(Me._OptSo_8)
        Me._Frame10_2.Controls.Add(Me._txtShTk_1)
        Me._Frame10_2.Controls.Add(Me._ChkDu_2)
        Me._Frame10_2.Controls.Add(Me._ChkDu_6)
        Me._Frame10_2.Controls.Add(Me._ChkDu_10)
        Me._Frame10_2.Controls.Add(Me._OptSo_11)
        Me._Frame10_2.Controls.Add(Me._cmdtk_10)
        Me._Frame10_2.Controls.Add(Me._Cmdvt_0)
        Me._Frame10_2.Controls.Add(Me._cmdtk_1)
        Me._Frame10_2.Controls.Add(Me._cmdtk_0)
        Me._Frame10_2.Controls.Add(Me._cmdtk_4)
        Me._Frame10_2.Controls.Add(Me._cmdkh_0)
        Me._Frame10_2.Controls.Add(Me._Cmdvt_1)
        Me._Frame10_2.Controls.Add(Me._cmdtk_2)
        Me._Frame10_2.Controls.Add(Me._cmdtk_3)
        Me._Frame10_2.Controls.Add(Me._LbTenTk_3)
        Me._Frame10_2.Controls.Add(Me._LbTenTk_2)
        Me._Frame10_2.Controls.Add(Me._LbTenVT_1)
        Me._Frame10_2.Controls.Add(Me._lbkh_0)
        Me._Frame10_2.Controls.Add(Me._LbTenTk_4)
        Me._Frame10_2.Controls.Add(Me._LbTenTk_10)
        Me._Frame10_2.Controls.Add(Me._LbTenTk_0)
        Me._Frame10_2.Controls.Add(Me._LbTenTk_1)
        Me._Frame10_2.Controls.Add(Me._LbTenVT_0)
        Me._Frame10_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me._Frame10_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame10_2.ForeColor = System.Drawing.Color.Blue
        Me._Frame10_2.Location = New System.Drawing.Point(3, 3)
        Me._Frame10_2.Name = "_Frame10_2"
        Me._Frame10_2.Size = New System.Drawing.Size(634, 613)
        Me._Frame10_2.TabIndex = 144
        Me._Frame10_2.TabStop = False
        Me._Frame10_2.Tag = "Accounting"
        Me._Frame10_2.Text = "Sổ kế toán"
        '
        'CTGS
        '
        Me.CTGS.BackColor = System.Drawing.SystemColors.Window
        Me.CTGS.Cursor = System.Windows.Forms.Cursors.Default
        Me.CTGS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CTGS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CTGS.DropDownWidth = 36
        Me.CTGS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTGS.Location = New System.Drawing.Point(344, 160)
        Me.CTGS.Name = "CTGS"
        Me.CTGS.Size = New System.Drawing.Size(201, 21)
        Me.CTGS.TabIndex = 255
        '
        '_OptSo_34
        '
        Me._OptSo_34.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_34.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_34.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_34.Location = New System.Drawing.Point(152, 136)
        Me._OptSo_34.Name = "_OptSo_34"
        Me._OptSo_34.Size = New System.Drawing.Size(185, 17)
        Me._OptSo_34.TabIndex = 257
        Me._OptSo_34.TabStop = True
        Me._OptSo_34.Tag = "Voucher Book Register"
        Me._OptSo_34.Text = "Sổ đăng ký chứng từ ghi sổ"
        Me._OptSo_34.UseVisualStyleBackColor = False
        '
        '_OptSo_35
        '
        Me._OptSo_35.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_35.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_35.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_35.Location = New System.Drawing.Point(152, 160)
        Me._OptSo_35.Name = "_OptSo_35"
        Me._OptSo_35.Size = New System.Drawing.Size(185, 17)
        Me._OptSo_35.TabIndex = 256
        Me._OptSo_35.TabStop = True
        Me._OptSo_35.Tag = "Voucher Book"
        Me._OptSo_35.Text = "Chứng từ ghi sổ số"
        Me._OptSo_35.UseVisualStyleBackColor = False
        '
        'CboThuchi
        '
        Me.CboThuchi.BackColor = System.Drawing.SystemColors.Window
        Me.CboThuchi.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboThuchi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboThuchi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboThuchi.DropDownWidth = 120
        Me.CboThuchi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboThuchi.Location = New System.Drawing.Point(264, 38)
        Me.CboThuchi.Name = "CboThuchi"
        Me.CboThuchi.Size = New System.Drawing.Size(145, 21)
        Me.CboThuchi.TabIndex = 182
        '
        '_OptSo_15
        '
        Me._OptSo_15.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_15.Location = New System.Drawing.Point(16, 376)
        Me._OptSo_15.Name = "_OptSo_15"
        Me._OptSo_15.Size = New System.Drawing.Size(133, 17)
        Me._OptSo_15.TabIndex = 55
        Me._OptSo_15.TabStop = True
        Me._OptSo_15.Tag = "Form 2"
        Me._OptSo_15.Text = "Thẻ kho"
        Me._OptSo_15.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame1.BackColor = System.Drawing.Color.Transparent
        Me.Frame1.Controls.Add(Me._OptKho_1)
        Me.Frame1.Controls.Add(Me._OptKho_0)
        Me.Frame1.Controls.Add(Me._CboKho_0)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 280)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(620, 41)
        Me.Frame1.TabIndex = 145
        Me.Frame1.TabStop = False
        '
        '_OptKho_1
        '
        Me._OptKho_1.BackColor = System.Drawing.Color.Transparent
        Me._OptKho_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptKho_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptKho_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptKho_1.Location = New System.Drawing.Point(354, 14)
        Me._OptKho_1.Name = "_OptKho_1"
        Me._OptKho_1.Size = New System.Drawing.Size(126, 17)
        Me._OptKho_1.TabIndex = 53
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
        Me._OptKho_0.Size = New System.Drawing.Size(50, 17)
        Me._OptKho_0.TabIndex = 51
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
        Me._CboKho_0.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboKho_0.Location = New System.Drawing.Point(64, 12)
        Me._CboKho_0.Name = "_CboKho_0"
        Me._CboKho_0.Size = New System.Drawing.Size(266, 23)
        Me._CboKho_0.TabIndex = 52
        '
        '_txtShTk_3
        '
        Me._txtShTk_3.AcceptsReturn = True
        Me._txtShTk_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_3.Location = New System.Drawing.Point(264, 256)
        Me._txtShTk_3.MaxLength = 12
        Me._txtShTk_3.Name = "_txtShTk_3"
        Me._txtShTk_3.Size = New System.Drawing.Size(73, 20)
        Me._txtShTk_3.TabIndex = 78
        Me._txtShTk_3.Tag = "0"
        '
        '_ChkDu_11
        '
        Me._ChkDu_11.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_11.Location = New System.Drawing.Point(264, 568)
        Me._ChkDu_11.Name = "_ChkDu_11"
        Me._ChkDu_11.Size = New System.Drawing.Size(74, 17)
        Me._ChkDu_11.TabIndex = 93
        Me._ChkDu_11.Tag = "Account"
        Me._ChkDu_11.Text = "Tài khoản"
        Me._ChkDu_11.UseVisualStyleBackColor = False
        '
        '_txtShTk_2
        '
        Me._txtShTk_2.AcceptsReturn = True
        Me._txtShTk_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_2.Location = New System.Drawing.Point(344, 568)
        Me._txtShTk_2.MaxLength = 12
        Me._txtShTk_2.Name = "_txtShTk_2"
        Me._txtShTk_2.Size = New System.Drawing.Size(65, 20)
        Me._txtShTk_2.TabIndex = 94
        Me._txtShTk_2.Tag = "0"
        '
        '_txtShVT_1
        '
        Me._txtShVT_1.AcceptsReturn = True
        Me._txtShVT_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtShVT_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShVT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShVT_1.Location = New System.Drawing.Point(152, 232)
        Me._txtShVT_1.MaxLength = 20
        Me._txtShVT_1.Name = "_txtShVT_1"
        Me._txtShVT_1.Size = New System.Drawing.Size(65, 20)
        Me._txtShVT_1.TabIndex = 76
        Me._txtShVT_1.Tag = "0"
        '
        '_ChkDu_8
        '
        Me._ChkDu_8.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_8.Location = New System.Drawing.Point(416, 208)
        Me._ChkDu_8.Name = "_ChkDu_8"
        Me._ChkDu_8.Size = New System.Drawing.Size(129, 17)
        Me._ChkDu_8.TabIndex = 75
        Me._ChkDu_8.Tag = "View foreign currency"
        Me._ChkDu_8.Text = "Theo ngoại tệ"
        Me._ChkDu_8.UseVisualStyleBackColor = False
        '
        '_txtshkh_0
        '
        Me._txtshkh_0.AcceptsReturn = True
        Me._txtshkh_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtshkh_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtshkh_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtshkh_0.Location = New System.Drawing.Point(152, 208)
        Me._txtshkh_0.MaxLength = 20
        Me._txtshkh_0.Name = "_txtshkh_0"
        Me._txtshkh_0.Size = New System.Drawing.Size(65, 20)
        Me._txtshkh_0.TabIndex = 73
        Me._txtshkh_0.Tag = "0"
        '
        '_OptSo_33
        '
        Me._OptSo_33.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_33.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_33.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_33.Location = New System.Drawing.Point(16, 400)
        Me._OptSo_33.Name = "_OptSo_33"
        Me._OptSo_33.Size = New System.Drawing.Size(241, 17)
        Me._OptSo_33.TabIndex = 56
        Me._OptSo_33.TabStop = True
        Me._OptSo_33.Tag = "Material, tool and Product Summary Report"
        Me._OptSo_33.Text = "Tổng hợp chi tiết vật liệu, dụng cụ, sản phẩm"
        Me._OptSo_33.UseVisualStyleBackColor = False
        '
        '_ChkDu_5
        '
        Me._ChkDu_5.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_5.Location = New System.Drawing.Point(264, 400)
        Me._ChkDu_5.Name = "_ChkDu_5"
        Me._ChkDu_5.Size = New System.Drawing.Size(73, 17)
        Me._ChkDu_5.TabIndex = 91
        Me._ChkDu_5.Tag = "Class"
        Me._ChkDu_5.Text = "Loại vật tư"
        Me._ChkDu_5.UseVisualStyleBackColor = False
        '
        '_CboLoai_0
        '
        Me._CboLoai_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboLoai_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboLoai_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboLoai_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboLoai_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboLoai_0.Location = New System.Drawing.Point(344, 399)
        Me._CboLoai_0.Name = "_CboLoai_0"
        Me._CboLoai_0.Size = New System.Drawing.Size(201, 21)
        Me._CboLoai_0.TabIndex = 92
        '
        '_txtShTk_4
        '
        Me._txtShTk_4.AcceptsReturn = True
        Me._txtShTk_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_4.Location = New System.Drawing.Point(344, 424)
        Me._txtShTk_4.MaxLength = 12
        Me._txtShTk_4.Name = "_txtShTk_4"
        Me._txtShTk_4.Size = New System.Drawing.Size(65, 20)
        Me._txtShTk_4.TabIndex = 89
        Me._txtShTk_4.Tag = "0"
        '
        '_ChkDu_4
        '
        Me._ChkDu_4.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_4.Location = New System.Drawing.Point(152, 376)
        Me._ChkDu_4.Name = "_ChkDu_4"
        Me._ChkDu_4.Size = New System.Drawing.Size(97, 17)
        Me._ChkDu_4.TabIndex = 86
        Me._ChkDu_4.Tag = "Resource"
        Me._ChkDu_4.Text = "Nguồn NX"
        Me._ChkDu_4.UseVisualStyleBackColor = False
        '
        '_CboLoai_1
        '
        Me._CboLoai_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboLoai_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboLoai_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboLoai_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboLoai_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboLoai_1.Location = New System.Drawing.Point(264, 373)
        Me._CboLoai_1.Name = "_CboLoai_1"
        Me._CboLoai_1.Size = New System.Drawing.Size(145, 21)
        Me._CboLoai_1.TabIndex = 87
        '
        '_ChkDu_7
        '
        Me._ChkDu_7.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_7.Location = New System.Drawing.Point(152, 352)
        Me._ChkDu_7.Name = "_ChkDu_7"
        Me._ChkDu_7.Size = New System.Drawing.Size(97, 17)
        Me._ChkDu_7.TabIndex = 83
        Me._ChkDu_7.Tag = "by Ref. Acc."
        Me._ChkDu_7.Text = "TK đối ứng"
        Me._ChkDu_7.UseVisualStyleBackColor = False
        '
        '_txtShVT_0
        '
        Me._txtShVT_0.AcceptsReturn = True
        Me._txtShVT_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtShVT_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShVT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShVT_0.Location = New System.Drawing.Point(264, 328)
        Me._txtShVT_0.MaxLength = 20
        Me._txtShVT_0.Name = "_txtShVT_0"
        Me._txtShVT_0.Size = New System.Drawing.Size(73, 20)
        Me._txtShVT_0.TabIndex = 80
        Me._txtShVT_0.Tag = "0"
        '
        '_txtShTk_10
        '
        Me._txtShTk_10.AcceptsReturn = True
        Me._txtShTk_10.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_10.Location = New System.Drawing.Point(264, 352)
        Me._txtShTk_10.MaxLength = 12
        Me._txtShTk_10.Name = "_txtShTk_10"
        Me._txtShTk_10.Size = New System.Drawing.Size(73, 20)
        Me._txtShTk_10.TabIndex = 84
        Me._txtShTk_10.Tag = "0"
        '
        '_txtShTk_0
        '
        Me._txtShTk_0.AcceptsReturn = True
        Me._txtShTk_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_0.Location = New System.Drawing.Point(152, 88)
        Me._txtShTk_0.MaxLength = 12
        Me._txtShTk_0.Name = "_txtShTk_0"
        Me._txtShTk_0.Size = New System.Drawing.Size(65, 20)
        Me._txtShTk_0.TabIndex = 66
        Me._txtShTk_0.Tag = "0"
        '
        '_ChkDu_3
        '
        Me._ChkDu_3.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_3.Location = New System.Drawing.Point(416, 88)
        Me._ChkDu_3.Name = "_ChkDu_3"
        Me._ChkDu_3.Size = New System.Drawing.Size(129, 17)
        Me._ChkDu_3.TabIndex = 72
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
        Me.CboVV.Location = New System.Drawing.Point(264, 12)
        Me.CboVV.Name = "CboVV"
        Me.CboVV.Size = New System.Drawing.Size(145, 21)
        Me.CboVV.TabIndex = 65
        '
        '_OptSo_31
        '
        Me._OptSo_31.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_31.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_31.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_31.Location = New System.Drawing.Point(16, 568)
        Me._OptSo_31.Name = "_OptSo_31"
        Me._OptSo_31.Size = New System.Drawing.Size(241, 17)
        Me._OptSo_31.TabIndex = 62
        Me._OptSo_31.TabStop = True
        Me._OptSo_31.Tag = "VAT Abatement Detail Report"
        Me._OptSo_31.Text = "Sổ chi tiết thuế GTGT được miễn giảm"
        Me._OptSo_31.UseVisualStyleBackColor = False
        '
        '_OptSo_30
        '
        Me._OptSo_30.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_30.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_30.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_30.Location = New System.Drawing.Point(16, 544)
        Me._OptSo_30.Name = "_OptSo_30"
        Me._OptSo_30.Size = New System.Drawing.Size(241, 17)
        Me._OptSo_30.TabIndex = 61
        Me._OptSo_30.TabStop = True
        Me._OptSo_30.Tag = "Returned VAT Detail Report"
        Me._OptSo_30.Text = "Sổ chi tiết thuế GTGT được hoàn lại"
        Me._OptSo_30.UseVisualStyleBackColor = False
        '
        '_OptSo_29
        '
        Me._OptSo_29.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_29.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_29.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_29.Location = New System.Drawing.Point(16, 472)
        Me._OptSo_29.Name = "_OptSo_29"
        Me._OptSo_29.Size = New System.Drawing.Size(241, 17)
        Me._OptSo_29.TabIndex = 58
        Me._OptSo_29.TabStop = True
        Me._OptSo_29.Tag = "Increasing Fixed Asset Report"
        Me._OptSo_29.Text = "Thẻ TSCĐ"
        Me._OptSo_29.UseVisualStyleBackColor = False
        '
        '_OptSo_21
        '
        Me._OptSo_21.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_21.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_21.Location = New System.Drawing.Point(16, 256)
        Me._OptSo_21.Name = "_OptSo_21"
        Me._OptSo_21.Size = New System.Drawing.Size(241, 17)
        Me._OptSo_21.TabIndex = 50
        Me._OptSo_21.TabStop = True
        Me._OptSo_21.Tag = "Book Production Expenses"
        Me._OptSo_21.Text = "Sổ chi phí sản xuất kinh doanh"
        Me._OptSo_21.UseVisualStyleBackColor = False
        '
        '_OptSo_20
        '
        Me._OptSo_20.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_20.Location = New System.Drawing.Point(16, 232)
        Me._OptSo_20.Name = "_OptSo_20"
        Me._OptSo_20.Size = New System.Drawing.Size(137, 17)
        Me._OptSo_20.TabIndex = 49
        Me._OptSo_20.TabStop = True
        Me._OptSo_20.Tag = "Selling detail book"
        Me._OptSo_20.Text = "Sổ chi tiết bán hàng"
        Me._OptSo_20.UseVisualStyleBackColor = False
        '
        '_OptSo_19
        '
        Me._OptSo_19.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_19.Location = New System.Drawing.Point(16, 184)
        Me._OptSo_19.Name = "_OptSo_19"
        Me._OptSo_19.Size = New System.Drawing.Size(137, 17)
        Me._OptSo_19.TabIndex = 46
        Me._OptSo_19.TabStop = True
        Me._OptSo_19.Tag = "Loan Detail Book"
        Me._OptSo_19.Text = "Sổ chi tiết tiền vay"
        Me._OptSo_19.UseVisualStyleBackColor = False
        '
        '_OptSo_16
        '
        Me._OptSo_16.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_16.Location = New System.Drawing.Point(16, 520)
        Me._OptSo_16.Name = "_OptSo_16"
        Me._OptSo_16.Size = New System.Drawing.Size(241, 17)
        Me._OptSo_16.TabIndex = 60
        Me._OptSo_16.TabStop = True
        Me._OptSo_16.Tag = "The book tracking tools used in place"
        Me._OptSo_16.Text = "Sổ theo dõi CCDC tại nơi sử dụng"
        Me._OptSo_16.UseVisualStyleBackColor = False
        '
        '_OptSo_14
        '
        Me._OptSo_14.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_14.Location = New System.Drawing.Point(16, 496)
        Me._OptSo_14.Name = "_OptSo_14"
        Me._OptSo_14.Size = New System.Drawing.Size(241, 17)
        Me._OptSo_14.TabIndex = 59
        Me._OptSo_14.TabStop = True
        Me._OptSo_14.Tag = "The book for monitoring fixed assets used in place"
        Me._OptSo_14.Text = "Sổ theo dõi TSCĐ tại nơi sử dụng"
        Me._OptSo_14.UseVisualStyleBackColor = False
        '
        '_OptSo_13
        '
        Me._OptSo_13.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_13.Location = New System.Drawing.Point(16, 448)
        Me._OptSo_13.Name = "_OptSo_13"
        Me._OptSo_13.Size = New System.Drawing.Size(241, 17)
        Me._OptSo_13.TabIndex = 57
        Me._OptSo_13.TabStop = True
        Me._OptSo_13.Tag = "Fixed Asset Book"
        Me._OptSo_13.Text = "Sổ TSCĐ"
        Me._OptSo_13.UseVisualStyleBackColor = False
        '
        '_OptSo_12
        '
        Me._OptSo_12.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_12.Location = New System.Drawing.Point(16, 328)
        Me._OptSo_12.Name = "_OptSo_12"
        Me._OptSo_12.Size = New System.Drawing.Size(241, 17)
        Me._OptSo_12.TabIndex = 54
        Me._OptSo_12.TabStop = True
        Me._OptSo_12.Tag = "Materials, Tool, Product Detail Book"
        Me._OptSo_12.Text = "Sổ chi tiết vật liệu, dụng cụ, sản phẩm"
        Me._OptSo_12.UseVisualStyleBackColor = False
        '
        '_OptSo_9
        '
        Me._OptSo_9.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_9.Location = New System.Drawing.Point(16, 160)
        Me._OptSo_9.Name = "_OptSo_9"
        Me._OptSo_9.Size = New System.Drawing.Size(137, 17)
        Me._OptSo_9.TabIndex = 45
        Me._OptSo_9.TabStop = True
        Me._OptSo_9.Tag = "Bank deposit books"
        Me._OptSo_9.Text = "Sổ tiền gửi ngân hàng"
        Me._OptSo_9.UseVisualStyleBackColor = False
        '
        '_OptSo_7
        '
        Me._OptSo_7.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_7.Location = New System.Drawing.Point(16, 136)
        Me._OptSo_7.Name = "_OptSo_7"
        Me._OptSo_7.Size = New System.Drawing.Size(137, 17)
        Me._OptSo_7.TabIndex = 44
        Me._OptSo_7.TabStop = True
        Me._OptSo_7.Tag = "Cashbook"
        Me._OptSo_7.Text = "Sổ quỹ tiền mặt"
        Me._OptSo_7.UseVisualStyleBackColor = False
        '
        '_OptSo_5
        '
        Me._OptSo_5.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_5.Location = New System.Drawing.Point(16, 88)
        Me._OptSo_5.Name = "_OptSo_5"
        Me._OptSo_5.Size = New System.Drawing.Size(137, 17)
        Me._OptSo_5.TabIndex = 43
        Me._OptSo_5.TabStop = True
        Me._OptSo_5.Tag = "Ledger - Detail book"
        Me._OptSo_5.Text = "Sổ cái - Sổ chi tiết"
        Me._OptSo_5.UseVisualStyleBackColor = False
        '
        '_OptSo_4
        '
        Me._OptSo_4.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_4.Location = New System.Drawing.Point(152, 64)
        Me._OptSo_4.Name = "_OptSo_4"
        Me._OptSo_4.Size = New System.Drawing.Size(113, 17)
        Me._OptSo_4.TabIndex = 42
        Me._OptSo_4.TabStop = True
        Me._OptSo_4.Tag = "Selling journal"
        Me._OptSo_4.Text = "Nhật ký bán hàng"
        Me._OptSo_4.UseVisualStyleBackColor = False
        '
        '_OptSo_3
        '
        Me._OptSo_3.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_3.Location = New System.Drawing.Point(16, 64)
        Me._OptSo_3.Name = "_OptSo_3"
        Me._OptSo_3.Size = New System.Drawing.Size(137, 17)
        Me._OptSo_3.TabIndex = 41
        Me._OptSo_3.TabStop = True
        Me._OptSo_3.Tag = "Purachasing journal"
        Me._OptSo_3.Text = "Nhật ký mua hàng"
        Me._OptSo_3.UseVisualStyleBackColor = False
        '
        '_OptSo_2
        '
        Me._OptSo_2.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_2.Location = New System.Drawing.Point(152, 40)
        Me._OptSo_2.Name = "_OptSo_2"
        Me._OptSo_2.Size = New System.Drawing.Size(113, 17)
        Me._OptSo_2.TabIndex = 40
        Me._OptSo_2.TabStop = True
        Me._OptSo_2.Tag = "Expenses journal"
        Me._OptSo_2.Text = "Nhật ký chi tiền"
        Me._OptSo_2.UseVisualStyleBackColor = False
        '
        '_OptSo_1
        '
        Me._OptSo_1.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_1.Location = New System.Drawing.Point(16, 40)
        Me._OptSo_1.Name = "_OptSo_1"
        Me._OptSo_1.Size = New System.Drawing.Size(137, 17)
        Me._OptSo_1.TabIndex = 39
        Me._OptSo_1.TabStop = True
        Me._OptSo_1.Tag = "Receipts journal"
        Me._OptSo_1.Text = "Nhật ký thu tiền"
        Me._OptSo_1.UseVisualStyleBackColor = False
        '
        '_OptSo_0
        '
        Me._OptSo_0.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_0.Checked = True
        Me._OptSo_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_0.Location = New System.Drawing.Point(16, 16)
        Me._OptSo_0.Name = "_OptSo_0"
        Me._OptSo_0.Size = New System.Drawing.Size(137, 17)
        Me._OptSo_0.TabIndex = 38
        Me._OptSo_0.TabStop = True
        Me._OptSo_0.Tag = "General journal"
        Me._OptSo_0.Text = "Nhật ký chung"
        Me._OptSo_0.UseVisualStyleBackColor = False
        '
        '_OptSo_6
        '
        Me._OptSo_6.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_6.Location = New System.Drawing.Point(16, 208)
        Me._OptSo_6.Name = "_OptSo_6"
        Me._OptSo_6.Size = New System.Drawing.Size(137, 17)
        Me._OptSo_6.TabIndex = 48
        Me._OptSo_6.TabStop = True
        Me._OptSo_6.Tag = "Payment Detail Book"
        Me._OptSo_6.Text = "Sổ chi tiết thanh toán"
        Me._OptSo_6.UseVisualStyleBackColor = False
        '
        '_OptSo_8
        '
        Me._OptSo_8.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_8.Location = New System.Drawing.Point(16, 592)
        Me._OptSo_8.Name = "_OptSo_8"
        Me._OptSo_8.Size = New System.Drawing.Size(241, 17)
        Me._OptSo_8.TabIndex = 63
        Me._OptSo_8.TabStop = True
        Me._OptSo_8.Tag = "Employee payroll"
        Me._OptSo_8.Text = "Bảng lương nhân viên"
        Me._OptSo_8.UseVisualStyleBackColor = False
        '
        '_txtShTk_1
        '
        Me._txtShTk_1.AcceptsReturn = True
        Me._txtShTk_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_1.Location = New System.Drawing.Point(264, 112)
        Me._txtShTk_1.MaxLength = 12
        Me._txtShTk_1.Name = "_txtShTk_1"
        Me._txtShTk_1.Size = New System.Drawing.Size(73, 20)
        Me._txtShTk_1.TabIndex = 69
        Me._txtShTk_1.Tag = "0"
        '
        '_ChkDu_2
        '
        Me._ChkDu_2.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_2.Location = New System.Drawing.Point(264, 424)
        Me._ChkDu_2.Name = "_ChkDu_2"
        Me._ChkDu_2.Size = New System.Drawing.Size(74, 17)
        Me._ChkDu_2.TabIndex = 88
        Me._ChkDu_2.Tag = "Account"
        Me._ChkDu_2.Text = "Tài khoản"
        Me._ChkDu_2.UseVisualStyleBackColor = False
        '
        '_ChkDu_6
        '
        Me._ChkDu_6.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_6.Location = New System.Drawing.Point(32, 352)
        Me._ChkDu_6.Name = "_ChkDu_6"
        Me._ChkDu_6.Size = New System.Drawing.Size(117, 17)
        Me._ChkDu_6.TabIndex = 82
        Me._ChkDu_6.Tag = "Print all Inventory detail report"
        Me._ChkDu_6.Text = "In toàn bộ sổ chi tiết"
        Me._ChkDu_6.UseVisualStyleBackColor = False
        '
        '_ChkDu_10
        '
        Me._ChkDu_10.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_10.Location = New System.Drawing.Point(24, 112)
        Me._ChkDu_10.Name = "_ChkDu_10"
        Me._ChkDu_10.Size = New System.Drawing.Size(129, 17)
        Me._ChkDu_10.TabIndex = 71
        Me._ChkDu_10.Tag = "Print All Ledgers"
        Me._ChkDu_10.Text = "In toàn bộ sổ cái"
        Me._ChkDu_10.UseVisualStyleBackColor = False
        '
        '_OptSo_11
        '
        Me._OptSo_11.BackColor = System.Drawing.Color.Transparent
        Me._OptSo_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptSo_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptSo_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptSo_11.Location = New System.Drawing.Point(152, 184)
        Me._OptSo_11.Name = "_OptSo_11"
        Me._OptSo_11.Size = New System.Drawing.Size(177, 17)
        Me._OptSo_11.TabIndex = 47
        Me._OptSo_11.TabStop = True
        Me._OptSo_11.Tag = ""
        Me._OptSo_11.Text = "Sổ kế toán chi tiết quỹ tiền mặt"
        Me._OptSo_11.UseVisualStyleBackColor = False
        Me._OptSo_11.Visible = False
        '
        '_cmdtk_10
        '
        Me._cmdtk_10.Image = CType(resources.GetObject("_cmdtk_10.Image"), System.Drawing.Image)
        Me._cmdtk_10.Location = New System.Drawing.Point(344, 348)
        Me._cmdtk_10.Name = "_cmdtk_10"
        Me._cmdtk_10.Size = New System.Drawing.Size(25, 25)
        Me._cmdtk_10.TabIndex = 85
        '
        '_Cmdvt_0
        '
        Me._Cmdvt_0.Image = CType(resources.GetObject("_Cmdvt_0.Image"), System.Drawing.Image)
        Me._Cmdvt_0.Location = New System.Drawing.Point(344, 324)
        Me._Cmdvt_0.Name = "_Cmdvt_0"
        Me._Cmdvt_0.Size = New System.Drawing.Size(25, 25)
        Me._Cmdvt_0.TabIndex = 81
        '
        '_cmdtk_1
        '
        Me._cmdtk_1.Image = CType(resources.GetObject("_cmdtk_1.Image"), System.Drawing.Image)
        Me._cmdtk_1.Location = New System.Drawing.Point(344, 108)
        Me._cmdtk_1.Name = "_cmdtk_1"
        Me._cmdtk_1.Size = New System.Drawing.Size(25, 25)
        Me._cmdtk_1.TabIndex = 70
        '
        '_cmdtk_0
        '
        Me._cmdtk_0.Image = CType(resources.GetObject("_cmdtk_0.Image"), System.Drawing.Image)
        Me._cmdtk_0.Location = New System.Drawing.Point(224, 84)
        Me._cmdtk_0.Name = "_cmdtk_0"
        Me._cmdtk_0.Size = New System.Drawing.Size(25, 25)
        Me._cmdtk_0.TabIndex = 67
        '
        '_cmdtk_4
        '
        Me._cmdtk_4.Image = CType(resources.GetObject("_cmdtk_4.Image"), System.Drawing.Image)
        Me._cmdtk_4.Location = New System.Drawing.Point(416, 424)
        Me._cmdtk_4.Name = "_cmdtk_4"
        Me._cmdtk_4.Size = New System.Drawing.Size(25, 25)
        Me._cmdtk_4.TabIndex = 90
        '
        '_cmdkh_0
        '
        Me._cmdkh_0.Image = CType(resources.GetObject("_cmdkh_0.Image"), System.Drawing.Image)
        Me._cmdkh_0.Location = New System.Drawing.Point(224, 204)
        Me._cmdkh_0.Name = "_cmdkh_0"
        Me._cmdkh_0.Size = New System.Drawing.Size(25, 25)
        Me._cmdkh_0.TabIndex = 74
        '
        '_Cmdvt_1
        '
        Me._Cmdvt_1.Image = CType(resources.GetObject("_Cmdvt_1.Image"), System.Drawing.Image)
        Me._Cmdvt_1.Location = New System.Drawing.Point(224, 228)
        Me._Cmdvt_1.Name = "_Cmdvt_1"
        Me._Cmdvt_1.Size = New System.Drawing.Size(25, 25)
        Me._Cmdvt_1.TabIndex = 77
        '
        '_cmdtk_2
        '
        Me._cmdtk_2.Image = CType(resources.GetObject("_cmdtk_2.Image"), System.Drawing.Image)
        Me._cmdtk_2.Location = New System.Drawing.Point(416, 564)
        Me._cmdtk_2.Name = "_cmdtk_2"
        Me._cmdtk_2.Size = New System.Drawing.Size(25, 25)
        Me._cmdtk_2.TabIndex = 95
        '
        '_cmdtk_3
        '
        Me._cmdtk_3.Image = CType(resources.GetObject("_cmdtk_3.Image"), System.Drawing.Image)
        Me._cmdtk_3.Location = New System.Drawing.Point(344, 252)
        Me._cmdtk_3.Name = "_cmdtk_3"
        Me._cmdtk_3.Size = New System.Drawing.Size(25, 25)
        Me._cmdtk_3.TabIndex = 79
        '
        '_LbTenTk_3
        '
        Me._LbTenTk_3.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_3.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_3.Location = New System.Drawing.Point(376, 256)
        Me._LbTenTk_3.Name = "_LbTenTk_3"
        Me._LbTenTk_3.Size = New System.Drawing.Size(169, 17)
        Me._LbTenTk_3.TabIndex = 154
        Me._LbTenTk_3.Tag = "1"
        '
        '_LbTenTk_2
        '
        Me._LbTenTk_2.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_2.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_2.Location = New System.Drawing.Point(344, 592)
        Me._LbTenTk_2.Name = "_LbTenTk_2"
        Me._LbTenTk_2.Size = New System.Drawing.Size(201, 17)
        Me._LbTenTk_2.TabIndex = 153
        Me._LbTenTk_2.Tag = "1"
        '
        '_LbTenVT_1
        '
        Me._LbTenVT_1.BackColor = System.Drawing.Color.Transparent
        Me._LbTenVT_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenVT_1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenVT_1.ForeColor = System.Drawing.Color.Blue
        Me._LbTenVT_1.Location = New System.Drawing.Point(264, 232)
        Me._LbTenVT_1.Name = "_LbTenVT_1"
        Me._LbTenVT_1.Size = New System.Drawing.Size(281, 17)
        Me._LbTenVT_1.TabIndex = 152
        Me._LbTenVT_1.Tag = "1"
        '
        '_lbkh_0
        '
        Me._lbkh_0.BackColor = System.Drawing.Color.Transparent
        Me._lbkh_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbkh_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbkh_0.ForeColor = System.Drawing.Color.Blue
        Me._lbkh_0.Location = New System.Drawing.Point(264, 208)
        Me._lbkh_0.Name = "_lbkh_0"
        Me._lbkh_0.Size = New System.Drawing.Size(145, 17)
        Me._lbkh_0.TabIndex = 151
        Me._lbkh_0.Tag = "1"
        '
        '_LbTenTk_4
        '
        Me._LbTenTk_4.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_4.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_4.Location = New System.Drawing.Point(344, 448)
        Me._LbTenTk_4.Name = "_LbTenTk_4"
        Me._LbTenTk_4.Size = New System.Drawing.Size(201, 17)
        Me._LbTenTk_4.TabIndex = 150
        Me._LbTenTk_4.Tag = "1"
        '
        '_LbTenTk_10
        '
        Me._LbTenTk_10.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_10.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_10.Location = New System.Drawing.Point(376, 352)
        Me._LbTenTk_10.Name = "_LbTenTk_10"
        Me._LbTenTk_10.Size = New System.Drawing.Size(169, 17)
        Me._LbTenTk_10.TabIndex = 148
        Me._LbTenTk_10.Tag = "1"
        '
        '_LbTenTk_0
        '
        Me._LbTenTk_0.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_0.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_0.Location = New System.Drawing.Point(264, 88)
        Me._LbTenTk_0.Name = "_LbTenTk_0"
        Me._LbTenTk_0.Size = New System.Drawing.Size(145, 17)
        Me._LbTenTk_0.TabIndex = 147
        Me._LbTenTk_0.Tag = "1"
        '
        '_LbTenTk_1
        '
        Me._LbTenTk_1.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_1.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_1.Location = New System.Drawing.Point(376, 112)
        Me._LbTenTk_1.Name = "_LbTenTk_1"
        Me._LbTenTk_1.Size = New System.Drawing.Size(169, 17)
        Me._LbTenTk_1.TabIndex = 146
        Me._LbTenTk_1.Tag = "1"
        '
        '_LbTenVT_0
        '
        Me._LbTenVT_0.BackColor = System.Drawing.Color.Transparent
        Me._LbTenVT_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenVT_0.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenVT_0.ForeColor = System.Drawing.Color.Blue
        Me._LbTenVT_0.Location = New System.Drawing.Point(376, 328)
        Me._LbTenVT_0.Name = "_LbTenVT_0"
        Me._LbTenVT_0.Size = New System.Drawing.Size(169, 17)
        Me._LbTenVT_0.TabIndex = 149
        Me._LbTenVT_0.Tag = "1"
        '
        '_Frame10_4
        '
        Me._Frame10_4.BackColor = System.Drawing.Color.Transparent
        Me._Frame10_4.Controls.Add(Me._OptCDT_15)
        Me._Frame10_4.Controls.Add(Me._OptCDT_14)
        Me._Frame10_4.Controls.Add(Me._OptCDT_13)
        Me._Frame10_4.Controls.Add(Me._OptCDT_12)
        Me._Frame10_4.Controls.Add(Me._OptCDT_11)
        Me._Frame10_4.Controls.Add(Me._OptCDT_10)
        Me._Frame10_4.Controls.Add(Me._OptCDT_9)
        Me._Frame10_4.Controls.Add(Me._OptCDT_8)
        Me._Frame10_4.Controls.Add(Me._OptCDT_7)
        Me._Frame10_4.Controls.Add(Me._OptCDT_6)
        Me._Frame10_4.Controls.Add(Me._OptCDT_5)
        Me._Frame10_4.Controls.Add(Me._OptCDT_4)
        Me._Frame10_4.Controls.Add(Me._OptCDT_3)
        Me._Frame10_4.Controls.Add(Me._OptCDT_2)
        Me._Frame10_4.Controls.Add(Me._OptCDT_1)
        Me._Frame10_4.Controls.Add(Me._OptCDT_0)
        Me._Frame10_4.Controls.Add(Me._txtShTk_8)
        Me._Frame10_4.Controls.Add(Me._txtShVT_2)
        Me._Frame10_4.Controls.Add(Me.CboNK)
        Me._Frame10_4.Controls.Add(Me._cmdtk_8)
        Me._Frame10_4.Controls.Add(Me._Cmdvt_2)
        Me._Frame10_4.Controls.Add(Me._Line1_1)
        Me._Frame10_4.Controls.Add(Me._Label_7)
        Me._Frame10_4.Controls.Add(Me._Line1_0)
        Me._Frame10_4.Controls.Add(Me._LbTenTk_8)
        Me._Frame10_4.Controls.Add(Me._Label_8)
        Me._Frame10_4.Controls.Add(Me._LbTenVT_2)
        Me._Frame10_4.Dock = System.Windows.Forms.DockStyle.Fill
        Me._Frame10_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame10_4.ForeColor = System.Drawing.Color.Blue
        Me._Frame10_4.Location = New System.Drawing.Point(3, 3)
        Me._Frame10_4.Name = "_Frame10_4"
        Me._Frame10_4.Size = New System.Drawing.Size(634, 613)
        Me._Frame10_4.TabIndex = 185
        Me._Frame10_4.TabStop = False
        Me._Frame10_4.Tag = "Investoes reports"
        Me._Frame10_4.Text = "Báo cáo chủ đầu tư"
        '
        '_OptCDT_15
        '
        Me._OptCDT_15.BackColor = System.Drawing.Color.Transparent
        Me._OptCDT_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptCDT_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptCDT_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptCDT_15.Location = New System.Drawing.Point(16, 392)
        Me._OptCDT_15.Name = "_OptCDT_15"
        Me._OptCDT_15.Size = New System.Drawing.Size(385, 17)
        Me._OptCDT_15.TabIndex = 204
        Me._OptCDT_15.TabStop = True
        Me._OptCDT_15.Tag = "Reports on the settlement of investment capital to complete - Form 09/QTDA"
        Me._OptCDT_15.Text = "Báo cáo quyết toán vốn đầu tư hoàn thành - Mẫu số 09/QTDA"
        Me._OptCDT_15.UseVisualStyleBackColor = False
        '
        '_OptCDT_14
        '
        Me._OptCDT_14.BackColor = System.Drawing.Color.Transparent
        Me._OptCDT_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptCDT_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptCDT_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptCDT_14.Location = New System.Drawing.Point(16, 368)
        Me._OptCDT_14.Name = "_OptCDT_14"
        Me._OptCDT_14.Size = New System.Drawing.Size(385, 17)
        Me._OptCDT_14.TabIndex = 203
        Me._OptCDT_14.TabStop = True
        Me._OptCDT_14.Tag = "Debt situation and capital reconciliation table - Form 07 and 08/QTDA"
        Me._OptCDT_14.Text = "Tình hình công nợ và Bảng đối chiếu vốn - Mẫu số 07 và 08/QTDA"
        Me._OptCDT_14.UseVisualStyleBackColor = False
        '
        '_OptCDT_13
        '
        Me._OptCDT_13.BackColor = System.Drawing.Color.Transparent
        Me._OptCDT_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptCDT_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptCDT_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptCDT_13.Location = New System.Drawing.Point(16, 344)
        Me._OptCDT_13.Name = "_OptCDT_13"
        Me._OptCDT_13.Size = New System.Drawing.Size(385, 17)
        Me._OptCDT_13.TabIndex = 202
        Me._OptCDT_13.TabStop = True
        Me._OptCDT_13.Tag = "Newly increased fixed assets and current assets handed over - Form 06 and 06/QTDA" & _
            ""
        Me._OptCDT_13.Text = "TSCĐ mới tăng và tài sản lưu động bàn giao - Mẫu số 05 và 06/QTDA"
        Me._OptCDT_13.UseVisualStyleBackColor = False
        '
        '_OptCDT_12
        '
        Me._OptCDT_12.BackColor = System.Drawing.Color.Transparent
        Me._OptCDT_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptCDT_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptCDT_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptCDT_12.Location = New System.Drawing.Point(16, 240)
        Me._OptCDT_12.Name = "_OptCDT_12"
        Me._OptCDT_12.Size = New System.Drawing.Size(337, 17)
        Me._OptCDT_12.TabIndex = 201
        Me._OptCDT_12.TabStop = True
        Me._OptCDT_12.Tag = "Implementation of investment projects, projects, work items"
        Me._OptCDT_12.Text = "Thực hiện đầu tư theo dự án, công trình, hạng mục công trình"
        Me._OptCDT_12.UseVisualStyleBackColor = False
        '
        '_OptCDT_11
        '
        Me._OptCDT_11.BackColor = System.Drawing.Color.Transparent
        Me._OptCDT_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptCDT_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptCDT_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptCDT_11.Location = New System.Drawing.Point(16, 216)
        Me._OptCDT_11.Name = "_OptCDT_11"
        Me._OptCDT_11.Size = New System.Drawing.Size(273, 17)
        Me._OptCDT_11.TabIndex = 200
        Me._OptCDT_11.TabStop = True
        Me._OptCDT_11.Tag = "Notes to financial statements"
        Me._OptCDT_11.Text = "Thuyết minh báo cáo Tài chính"
        Me._OptCDT_11.UseVisualStyleBackColor = False
        '
        '_OptCDT_10
        '
        Me._OptCDT_10.BackColor = System.Drawing.Color.Transparent
        Me._OptCDT_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptCDT_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptCDT_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptCDT_10.Location = New System.Drawing.Point(16, 192)
        Me._OptCDT_10.Name = "_OptCDT_10"
        Me._OptCDT_10.Size = New System.Drawing.Size(273, 17)
        Me._OptCDT_10.TabIndex = 199
        Me._OptCDT_10.TabStop = True
        Me._OptCDT_10.Tag = "Implementationg of investment"
        Me._OptCDT_10.Text = "Thực hiện đầu tư"
        Me._OptCDT_10.UseVisualStyleBackColor = False
        '
        '_OptCDT_9
        '
        Me._OptCDT_9.BackColor = System.Drawing.Color.Transparent
        Me._OptCDT_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptCDT_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptCDT_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptCDT_9.Location = New System.Drawing.Point(16, 168)
        Me._OptCDT_9.Name = "_OptCDT_9"
        Me._OptCDT_9.Size = New System.Drawing.Size(273, 17)
        Me._OptCDT_9.TabIndex = 198
        Me._OptCDT_9.TabStop = True
        Me._OptCDT_9.Tag = "Capital investment"
        Me._OptCDT_9.Text = "Nguồn vốn đầu tư"
        Me._OptCDT_9.UseVisualStyleBackColor = False
        '
        '_OptCDT_8
        '
        Me._OptCDT_8.BackColor = System.Drawing.Color.Transparent
        Me._OptCDT_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptCDT_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptCDT_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptCDT_8.Location = New System.Drawing.Point(16, 416)
        Me._OptCDT_8.Name = "_OptCDT_8"
        Me._OptCDT_8.Size = New System.Drawing.Size(337, 17)
        Me._OptCDT_8.TabIndex = 197
        Me._OptCDT_8.TabStop = True
        Me._OptCDT_8.Tag = "Browse the complete settlement capital - Form 10/QTDA"
        Me._OptCDT_8.Text = "Duyệt quyết toán vốn đầu tư hoàn thành - Mẫu số 10/QTDA"
        Me._OptCDT_8.UseVisualStyleBackColor = False
        '
        '_OptCDT_7
        '
        Me._OptCDT_7.BackColor = System.Drawing.Color.Transparent
        Me._OptCDT_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptCDT_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptCDT_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptCDT_7.Location = New System.Drawing.Point(16, 320)
        Me._OptCDT_7.Name = "_OptCDT_7"
        Me._OptCDT_7.Size = New System.Drawing.Size(425, 17)
        Me._OptCDT_7.TabIndex = 196
        Me._OptCDT_7.TabStop = True
        Me._OptCDT_7.Tag = "Settlement costs of investment in the project, completed items - Form 04/QTDA"
        Me._OptCDT_7.Text = "Quyết toán chi phí đầu tư theo công trình, hạng mục hoàn thành - Mẫu số 04/QTDA"
        Me._OptCDT_7.UseVisualStyleBackColor = False
        '
        '_OptCDT_6
        '
        Me._OptCDT_6.BackColor = System.Drawing.Color.Transparent
        Me._OptCDT_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptCDT_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptCDT_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptCDT_6.Location = New System.Drawing.Point(16, 296)
        Me._OptCDT_6.Name = "_OptCDT_6"
        Me._OptCDT_6.Size = New System.Drawing.Size(385, 17)
        Me._OptCDT_6.TabIndex = 195
        Me._OptCDT_6.TabStop = True
        Me._OptCDT_6.Tag = "The implementation of investment over the years - Form 03/QTDA"
        Me._OptCDT_6.Text = "Tình hình thực hiện đầu tư qua các năm - Mẫu số 03/QTDA"
        Me._OptCDT_6.UseVisualStyleBackColor = False
        '
        '_OptCDT_5
        '
        Me._OptCDT_5.BackColor = System.Drawing.Color.Transparent
        Me._OptCDT_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptCDT_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptCDT_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptCDT_5.Location = New System.Drawing.Point(16, 272)
        Me._OptCDT_5.Name = "_OptCDT_5"
        Me._OptCDT_5.Size = New System.Drawing.Size(401, 17)
        Me._OptCDT_5.TabIndex = 194
        Me._OptCDT_5.TabStop = True
        Me._OptCDT_5.Tag = "Aggregate investment capital settlement completed - Form 01 and 02/QTDA"
        Me._OptCDT_5.Text = "Báo cáo tổng hợp quyết toán vốn đầu tư hoàn thành - Mẫu số 01và 02/QTDA"
        Me._OptCDT_5.UseVisualStyleBackColor = False
        '
        '_OptCDT_4
        '
        Me._OptCDT_4.BackColor = System.Drawing.Color.Transparent
        Me._OptCDT_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptCDT_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptCDT_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptCDT_4.Location = New System.Drawing.Point(16, 136)
        Me._OptCDT_4.Name = "_OptCDT_4"
        Me._OptCDT_4.Size = New System.Drawing.Size(233, 17)
        Me._OptCDT_4.TabIndex = 193
        Me._OptCDT_4.TabStop = True
        Me._OptCDT_4.Tag = "Advanced sales of products"
        Me._OptCDT_4.Text = "Sổ chi tiết doanh thu sản phẩm sản xuất thử"
        Me._OptCDT_4.UseVisualStyleBackColor = False
        '
        '_OptCDT_3
        '
        Me._OptCDT_3.BackColor = System.Drawing.Color.Transparent
        Me._OptCDT_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptCDT_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptCDT_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptCDT_3.Location = New System.Drawing.Point(16, 112)
        Me._OptCDT_3.Name = "_OptCDT_3"
        Me._OptCDT_3.Size = New System.Drawing.Size(185, 17)
        Me._OptCDT_3.TabIndex = 192
        Me._OptCDT_3.TabStop = True
        Me._OptCDT_3.Tag = "Investment details"
        Me._OptCDT_3.Text = "Sổ chi tiết nguồn vốn đầu tư"
        Me._OptCDT_3.UseVisualStyleBackColor = False
        '
        '_OptCDT_2
        '
        Me._OptCDT_2.BackColor = System.Drawing.Color.Transparent
        Me._OptCDT_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptCDT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptCDT_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptCDT_2.Location = New System.Drawing.Point(16, 88)
        Me._OptCDT_2.Name = "_OptCDT_2"
        Me._OptCDT_2.Size = New System.Drawing.Size(185, 17)
        Me._OptCDT_2.TabIndex = 191
        Me._OptCDT_2.TabStop = True
        Me._OptCDT_2.Tag = "Construction costs"
        Me._OptCDT_2.Text = "Sổ chi phí đầu tư xây dựng"
        Me._OptCDT_2.UseVisualStyleBackColor = False
        '
        '_OptCDT_1
        '
        Me._OptCDT_1.BackColor = System.Drawing.Color.Transparent
        Me._OptCDT_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptCDT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptCDT_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptCDT_1.Location = New System.Drawing.Point(16, 64)
        Me._OptCDT_1.Name = "_OptCDT_1"
        Me._OptCDT_1.Size = New System.Drawing.Size(185, 17)
        Me._OptCDT_1.TabIndex = 190
        Me._OptCDT_1.TabStop = True
        Me._OptCDT_1.Tag = "Other costs"
        Me._OptCDT_1.Text = "Sổ chi phí khác"
        Me._OptCDT_1.UseVisualStyleBackColor = False
        '
        '_OptCDT_0
        '
        Me._OptCDT_0.BackColor = System.Drawing.Color.Transparent
        Me._OptCDT_0.Checked = True
        Me._OptCDT_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptCDT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptCDT_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptCDT_0.Location = New System.Drawing.Point(16, 40)
        Me._OptCDT_0.Name = "_OptCDT_0"
        Me._OptCDT_0.Size = New System.Drawing.Size(185, 17)
        Me._OptCDT_0.TabIndex = 189
        Me._OptCDT_0.TabStop = True
        Me._OptCDT_0.Tag = "Cost project management"
        Me._OptCDT_0.Text = "Sổ chi phí ban quản lý dự án"
        Me._OptCDT_0.UseVisualStyleBackColor = False
        '
        '_txtShTk_8
        '
        Me._txtShTk_8.AcceptsReturn = True
        Me._txtShTk_8.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_8.Location = New System.Drawing.Point(80, 16)
        Me._txtShTk_8.MaxLength = 12
        Me._txtShTk_8.Name = "_txtShTk_8"
        Me._txtShTk_8.Size = New System.Drawing.Size(65, 20)
        Me._txtShTk_8.TabIndex = 188
        Me._txtShTk_8.Tag = "0"
        '
        '_txtShVT_2
        '
        Me._txtShVT_2.AcceptsReturn = True
        Me._txtShVT_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtShVT_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShVT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShVT_2.Location = New System.Drawing.Point(256, 132)
        Me._txtShVT_2.MaxLength = 20
        Me._txtShVT_2.Name = "_txtShVT_2"
        Me._txtShVT_2.Size = New System.Drawing.Size(65, 20)
        Me._txtShVT_2.TabIndex = 187
        Me._txtShVT_2.Tag = "0"
        '
        'CboNK
        '
        Me.CboNK.BackColor = System.Drawing.SystemColors.Window
        Me.CboNK.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboNK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboNK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboNK.DropDownWidth = 29
        Me.CboNK.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboNK.Location = New System.Drawing.Point(424, 36)
        Me.CboNK.Name = "CboNK"
        Me.CboNK.Size = New System.Drawing.Size(41, 21)
        Me.CboNK.TabIndex = 186
        '
        '_cmdtk_8
        '
        Me._cmdtk_8.Image = CType(resources.GetObject("_cmdtk_8.Image"), System.Drawing.Image)
        Me._cmdtk_8.Location = New System.Drawing.Point(152, 15)
        Me._cmdtk_8.Name = "_cmdtk_8"
        Me._cmdtk_8.Size = New System.Drawing.Size(24, 22)
        Me._cmdtk_8.TabIndex = 205
        '
        '_Cmdvt_2
        '
        Me._Cmdvt_2.Image = CType(resources.GetObject("_Cmdvt_2.Image"), System.Drawing.Image)
        Me._Cmdvt_2.Location = New System.Drawing.Point(328, 131)
        Me._Cmdvt_2.Name = "_Cmdvt_2"
        Me._Cmdvt_2.Size = New System.Drawing.Size(24, 22)
        Me._Cmdvt_2.TabIndex = 206
        '
        '_Line1_1
        '
        Me._Line1_1.BackColor = System.Drawing.SystemColors.Info
        Me._Line1_1.Enabled = False
        Me._Line1_1.Location = New System.Drawing.Point(16, 264)
        Me._Line1_1.Name = "_Line1_1"
        Me._Line1_1.Size = New System.Drawing.Size(432, 1)
        Me._Line1_1.TabIndex = 207
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.Transparent
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_7.Location = New System.Drawing.Point(328, 40)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(89, 17)
        Me._Label_7.TabIndex = 210
        Me._Label_7.Tag = "by Ref. Acc."
        Me._Label_7.Text = "Cấp TK đối ứng"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Line1_0
        '
        Me._Line1_0.BackColor = System.Drawing.SystemColors.Info
        Me._Line1_0.Enabled = False
        Me._Line1_0.Location = New System.Drawing.Point(16, 160)
        Me._Line1_0.Name = "_Line1_0"
        Me._Line1_0.Size = New System.Drawing.Size(432, 1)
        Me._Line1_0.TabIndex = 211
        '
        '_LbTenTk_8
        '
        Me._LbTenTk_8.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_8.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_8.Location = New System.Drawing.Point(184, 16)
        Me._LbTenTk_8.Name = "_LbTenTk_8"
        Me._LbTenTk_8.Size = New System.Drawing.Size(337, 17)
        Me._LbTenTk_8.TabIndex = 209
        Me._LbTenTk_8.Tag = "1"
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.Transparent
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_8.Location = New System.Drawing.Point(16, 16)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(57, 17)
        Me._Label_8.TabIndex = 208
        Me._Label_8.Tag = "Account"
        Me._Label_8.Text = "Tài khoản"
        '
        '_LbTenVT_2
        '
        Me._LbTenVT_2.BackColor = System.Drawing.Color.Transparent
        Me._LbTenVT_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenVT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenVT_2.ForeColor = System.Drawing.Color.Blue
        Me._LbTenVT_2.Location = New System.Drawing.Point(360, 132)
        Me._LbTenVT_2.Name = "_LbTenVT_2"
        Me._LbTenVT_2.Size = New System.Drawing.Size(177, 17)
        Me._LbTenVT_2.TabIndex = 207
        Me._LbTenVT_2.Tag = "1"
        '
        '_Frame10_3
        '
        Me._Frame10_3.BackColor = System.Drawing.Color.Transparent
        Me._Frame10_3.Controls.Add(Me._OptBCQT_0)
        Me._Frame10_3.Controls.Add(Me._OptBCQT_1)
        Me._Frame10_3.Controls.Add(Me._OptBCQT_2)
        Me._Frame10_3.Controls.Add(Me._OptBCQT_12)
        Me._Frame10_3.Controls.Add(Me._OptBCQT_3)
        Me._Frame10_3.Controls.Add(Me._OptBCQT_4)
        Me._Frame10_3.Controls.Add(Me._OptBCQT_5)
        Me._Frame10_3.Controls.Add(Me._OptBCQT_6)
        Me._Frame10_3.Controls.Add(Me._OptBCQT_7)
        Me._Frame10_3.Controls.Add(Me._OptBCQT_8)
        Me._Frame10_3.Controls.Add(Me._OptBCQT_9)
        Me._Frame10_3.Controls.Add(Me._OptBCQT_10)
        Me._Frame10_3.Controls.Add(Me._OptBCQT_11)
        Me._Frame10_3.Controls.Add(Me._OptBCQT_13)
        Me._Frame10_3.Controls.Add(Me._OptBCQT_14)
        Me._Frame10_3.Controls.Add(Me._OptBCQT_15)
        Me._Frame10_3.Controls.Add(Me._OptBCQT_16)
        Me._Frame10_3.Controls.Add(Me._OptBCQT_17)
        Me._Frame10_3.Controls.Add(Me._OptBCQT_18)
        Me._Frame10_3.Controls.Add(Me._OptBCQT_19)
        Me._Frame10_3.Dock = System.Windows.Forms.DockStyle.Fill
        Me._Frame10_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame10_3.ForeColor = System.Drawing.Color.Blue
        Me._Frame10_3.Location = New System.Drawing.Point(3, 3)
        Me._Frame10_3.Name = "_Frame10_3"
        Me._Frame10_3.Size = New System.Drawing.Size(634, 613)
        Me._Frame10_3.TabIndex = 211
        Me._Frame10_3.TabStop = False
        Me._Frame10_3.Tag = "Management Reports"
        Me._Frame10_3.Text = "Báo cáo quản trị"
        '
        '_OptBCQT_0
        '
        Me._OptBCQT_0.BackColor = System.Drawing.Color.Transparent
        Me._OptBCQT_0.Checked = True
        Me._OptBCQT_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBCQT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBCQT_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBCQT_0.Location = New System.Drawing.Point(16, 16)
        Me._OptBCQT_0.Name = "_OptBCQT_0"
        Me._OptBCQT_0.Size = New System.Drawing.Size(523, 17)
        Me._OptBCQT_0.TabIndex = 231
        Me._OptBCQT_0.TabStop = True
        Me._OptBCQT_0.Tag = "Cash, deposits, cash in transit"
        Me._OptBCQT_0.Text = "Tiền mặt, Tiền gửi, Tiền đang chuyển"
        Me._OptBCQT_0.UseVisualStyleBackColor = False
        '
        '_OptBCQT_1
        '
        Me._OptBCQT_1.BackColor = System.Drawing.Color.Transparent
        Me._OptBCQT_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBCQT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBCQT_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBCQT_1.Location = New System.Drawing.Point(16, 40)
        Me._OptBCQT_1.Name = "_OptBCQT_1"
        Me._OptBCQT_1.Size = New System.Drawing.Size(523, 17)
        Me._OptBCQT_1.TabIndex = 230
        Me._OptBCQT_1.TabStop = True
        Me._OptBCQT_1.Tag = "Investment banking and investment allowance to reduce short-term"
        Me._OptBCQT_1.Text = "Đầu tư ngắn hạn và dự phòng giảm giá đầu tư ngắn hạn"
        Me._OptBCQT_1.UseVisualStyleBackColor = False
        '
        '_OptBCQT_2
        '
        Me._OptBCQT_2.BackColor = System.Drawing.Color.Transparent
        Me._OptBCQT_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBCQT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBCQT_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBCQT_2.Location = New System.Drawing.Point(16, 64)
        Me._OptBCQT_2.Name = "_OptBCQT_2"
        Me._OptBCQT_2.Size = New System.Drawing.Size(523, 17)
        Me._OptBCQT_2.TabIndex = 229
        Me._OptBCQT_2.TabStop = True
        Me._OptBCQT_2.Tag = "Receivables anh advances to customers"
        Me._OptBCQT_2.Text = "Phải thu và ứng trước của khách hàng"
        Me._OptBCQT_2.UseVisualStyleBackColor = False
        '
        '_OptBCQT_12
        '
        Me._OptBCQT_12.BackColor = System.Drawing.Color.Transparent
        Me._OptBCQT_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBCQT_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBCQT_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBCQT_12.Location = New System.Drawing.Point(16, 304)
        Me._OptBCQT_12.Name = "_OptBCQT_12"
        Me._OptBCQT_12.Size = New System.Drawing.Size(523, 17)
        Me._OptBCQT_12.TabIndex = 228
        Me._OptBCQT_12.TabStop = True
        Me._OptBCQT_12.Tag = "Payables anh advances to suppliers"
        Me._OptBCQT_12.Text = "Phải trả và ứng trước cho người bán"
        Me._OptBCQT_12.UseVisualStyleBackColor = False
        '
        '_OptBCQT_3
        '
        Me._OptBCQT_3.BackColor = System.Drawing.Color.Transparent
        Me._OptBCQT_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBCQT_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBCQT_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBCQT_3.Location = New System.Drawing.Point(16, 88)
        Me._OptBCQT_3.Name = "_OptBCQT_3"
        Me._OptBCQT_3.Size = New System.Drawing.Size(523, 17)
        Me._OptBCQT_3.TabIndex = 227
        Me._OptBCQT_3.TabStop = True
        Me._OptBCQT_3.Tag = "Other receivables and bad debts provision"
        Me._OptBCQT_3.Text = "Phải thu khác và dự phòng thu khó đòi"
        Me._OptBCQT_3.UseVisualStyleBackColor = False
        '
        '_OptBCQT_4
        '
        Me._OptBCQT_4.BackColor = System.Drawing.Color.Transparent
        Me._OptBCQT_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBCQT_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBCQT_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBCQT_4.Location = New System.Drawing.Point(16, 112)
        Me._OptBCQT_4.Name = "_OptBCQT_4"
        Me._OptBCQT_4.Size = New System.Drawing.Size(523, 17)
        Me._OptBCQT_4.TabIndex = 226
        Me._OptBCQT_4.TabStop = True
        Me._OptBCQT_4.Tag = "Detailed advance"
        Me._OptBCQT_4.Text = "Chi tiết tạm ứng"
        Me._OptBCQT_4.UseVisualStyleBackColor = False
        '
        '_OptBCQT_5
        '
        Me._OptBCQT_5.BackColor = System.Drawing.Color.Transparent
        Me._OptBCQT_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBCQT_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBCQT_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBCQT_5.Location = New System.Drawing.Point(16, 136)
        Me._OptBCQT_5.Name = "_OptBCQT_5"
        Me._OptBCQT_5.Size = New System.Drawing.Size(523, 17)
        Me._OptBCQT_5.TabIndex = 225
        Me._OptBCQT_5.TabStop = True
        Me._OptBCQT_5.Tag = "Prepaid expenses"
        Me._OptBCQT_5.Text = "Chi phí trả trước"
        Me._OptBCQT_5.UseVisualStyleBackColor = False
        '
        '_OptBCQT_6
        '
        Me._OptBCQT_6.BackColor = System.Drawing.Color.Transparent
        Me._OptBCQT_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBCQT_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBCQT_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBCQT_6.Location = New System.Drawing.Point(16, 160)
        Me._OptBCQT_6.Name = "_OptBCQT_6"
        Me._OptBCQT_6.Size = New System.Drawing.Size(523, 17)
        Me._OptBCQT_6.TabIndex = 224
        Me._OptBCQT_6.TabStop = True
        Me._OptBCQT_6.Tag = "Mortgage and collateral"
        Me._OptBCQT_6.Text = "Thế chấp, ký quỹ"
        Me._OptBCQT_6.UseVisualStyleBackColor = False
        '
        '_OptBCQT_7
        '
        Me._OptBCQT_7.BackColor = System.Drawing.Color.Transparent
        Me._OptBCQT_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBCQT_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBCQT_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBCQT_7.Location = New System.Drawing.Point(16, 184)
        Me._OptBCQT_7.Name = "_OptBCQT_7"
        Me._OptBCQT_7.Size = New System.Drawing.Size(523, 17)
        Me._OptBCQT_7.TabIndex = 223
        Me._OptBCQT_7.TabStop = True
        Me._OptBCQT_7.Tag = "Inventory of supplies, tools, finished products and goods"
        Me._OptBCQT_7.Text = "Kiểm kê vật tư, công cụ dụng cụ, thành phẩm, hàng hoá"
        Me._OptBCQT_7.UseVisualStyleBackColor = False
        '
        '_OptBCQT_8
        '
        Me._OptBCQT_8.BackColor = System.Drawing.Color.Transparent
        Me._OptBCQT_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBCQT_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBCQT_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBCQT_8.Location = New System.Drawing.Point(16, 208)
        Me._OptBCQT_8.Name = "_OptBCQT_8"
        Me._OptBCQT_8.Size = New System.Drawing.Size(523, 17)
        Me._OptBCQT_8.TabIndex = 222
        Me._OptBCQT_8.TabStop = True
        Me._OptBCQT_8.Tag = "Inventory value of uncompleted construction"
        Me._OptBCQT_8.Text = "Kiểm kê giá trị khối lượng xây lắp thi công dở dang"
        Me._OptBCQT_8.UseVisualStyleBackColor = False
        '
        '_OptBCQT_9
        '
        Me._OptBCQT_9.BackColor = System.Drawing.Color.Transparent
        Me._OptBCQT_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBCQT_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBCQT_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBCQT_9.Location = New System.Drawing.Point(16, 232)
        Me._OptBCQT_9.Name = "_OptBCQT_9"
        Me._OptBCQT_9.Size = New System.Drawing.Size(523, 17)
        Me._OptBCQT_9.TabIndex = 221
        Me._OptBCQT_9.TabStop = True
        Me._OptBCQT_9.Tag = "Detailed joint long-term investments, provision for diminution in value of invest" & _
            "ments in long-term"
        Me._OptBCQT_9.Text = "Chi tiết liên doanh, đầu tư dài hạn, dự phòng giảm giá đầu tư dài hạn"
        Me._OptBCQT_9.UseVisualStyleBackColor = False
        '
        '_OptBCQT_10
        '
        Me._OptBCQT_10.BackColor = System.Drawing.Color.Transparent
        Me._OptBCQT_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBCQT_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBCQT_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBCQT_10.Location = New System.Drawing.Point(16, 256)
        Me._OptBCQT_10.Name = "_OptBCQT_10"
        Me._OptBCQT_10.Size = New System.Drawing.Size(523, 17)
        Me._OptBCQT_10.TabIndex = 220
        Me._OptBCQT_10.TabStop = True
        Me._OptBCQT_10.Tag = "The implementation of basic construction investment"
        Me._OptBCQT_10.Text = "Tình hình thực hiện đầu tư xây dựng cơ bản"
        Me._OptBCQT_10.UseVisualStyleBackColor = False
        '
        '_OptBCQT_11
        '
        Me._OptBCQT_11.BackColor = System.Drawing.Color.Transparent
        Me._OptBCQT_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBCQT_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBCQT_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBCQT_11.Location = New System.Drawing.Point(16, 280)
        Me._OptBCQT_11.Name = "_OptBCQT_11"
        Me._OptBCQT_11.Size = New System.Drawing.Size(523, 17)
        Me._OptBCQT_11.TabIndex = 219
        Me._OptBCQT_11.TabStop = True
        Me._OptBCQT_11.Tag = "Short-term borrowing, long-term debt payment, loan term, long-term debt, long-ter" & _
            "m deposits"
        Me._OptBCQT_11.Text = "Vay ngắn hạn, nợ dài hạn đến hạn trả, vay dài hạn, nợ dài hạn, ký quỹ dài hạn"
        Me._OptBCQT_11.UseVisualStyleBackColor = False
        '
        '_OptBCQT_13
        '
        Me._OptBCQT_13.BackColor = System.Drawing.Color.Transparent
        Me._OptBCQT_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBCQT_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBCQT_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBCQT_13.Location = New System.Drawing.Point(16, 328)
        Me._OptBCQT_13.Name = "_OptBCQT_13"
        Me._OptBCQT_13.Size = New System.Drawing.Size(523, 17)
        Me._OptBCQT_13.TabIndex = 218
        Me._OptBCQT_13.TabStop = True
        Me._OptBCQT_13.Tag = "The implementatin of state obligations, the budget remittances with the superior " & _
            "obligation"
        Me._OptBCQT_13.Text = "Tình hình thực hiện nghĩa vụ với Nhà nước, các khoản nộp Ngân sách, nghĩa vụ với " & _
            "cấp trên"
        Me._OptBCQT_13.UseVisualStyleBackColor = False
        '
        '_OptBCQT_14
        '
        Me._OptBCQT_14.BackColor = System.Drawing.Color.Transparent
        Me._OptBCQT_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBCQT_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBCQT_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBCQT_14.Location = New System.Drawing.Point(16, 352)
        Me._OptBCQT_14.Name = "_OptBCQT_14"
        Me._OptBCQT_14.Size = New System.Drawing.Size(523, 17)
        Me._OptBCQT_14.TabIndex = 217
        Me._OptBCQT_14.TabStop = True
        Me._OptBCQT_14.Tag = "Wages anh social insurance"
        Me._OptBCQT_14.Text = "Lương và bảo hiễm xã hội"
        Me._OptBCQT_14.UseVisualStyleBackColor = False
        '
        '_OptBCQT_15
        '
        Me._OptBCQT_15.BackColor = System.Drawing.Color.Transparent
        Me._OptBCQT_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBCQT_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBCQT_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBCQT_15.Location = New System.Drawing.Point(16, 376)
        Me._OptBCQT_15.Name = "_OptBCQT_15"
        Me._OptBCQT_15.Size = New System.Drawing.Size(523, 17)
        Me._OptBCQT_15.TabIndex = 216
        Me._OptBCQT_15.TabStop = True
        Me._OptBCQT_15.Tag = "Payment in progress, to be remitted to pay"
        Me._OptBCQT_15.Text = "Thanh toán theo tiến độ, phải trả phải nộp khác"
        Me._OptBCQT_15.UseVisualStyleBackColor = False
        '
        '_OptBCQT_16
        '
        Me._OptBCQT_16.BackColor = System.Drawing.Color.Transparent
        Me._OptBCQT_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBCQT_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBCQT_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBCQT_16.Location = New System.Drawing.Point(16, 400)
        Me._OptBCQT_16.Name = "_OptBCQT_16"
        Me._OptBCQT_16.Size = New System.Drawing.Size(523, 17)
        Me._OptBCQT_16.TabIndex = 215
        Me._OptBCQT_16.TabStop = True
        Me._OptBCQT_16.Tag = "Business capital, reserves"
        Me._OptBCQT_16.Text = "Nguồn vốn kinh doanh, các quỹ"
        Me._OptBCQT_16.UseVisualStyleBackColor = False
        '
        '_OptBCQT_17
        '
        Me._OptBCQT_17.BackColor = System.Drawing.Color.Transparent
        Me._OptBCQT_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBCQT_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBCQT_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBCQT_17.Location = New System.Drawing.Point(16, 424)
        Me._OptBCQT_17.Name = "_OptBCQT_17"
        Me._OptBCQT_17.Size = New System.Drawing.Size(523, 17)
        Me._OptBCQT_17.TabIndex = 214
        Me._OptBCQT_17.TabStop = True
        Me._OptBCQT_17.Tag = "Cost and productin work, the product"
        Me._OptBCQT_17.Text = "Chi phí và sản lượng công trình, sản phẩm"
        Me._OptBCQT_17.UseVisualStyleBackColor = False
        '
        '_OptBCQT_18
        '
        Me._OptBCQT_18.BackColor = System.Drawing.Color.Transparent
        Me._OptBCQT_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBCQT_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBCQT_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBCQT_18.Location = New System.Drawing.Point(16, 448)
        Me._OptBCQT_18.Name = "_OptBCQT_18"
        Me._OptBCQT_18.Size = New System.Drawing.Size(523, 17)
        Me._OptBCQT_18.TabIndex = 213
        Me._OptBCQT_18.TabStop = True
        Me._OptBCQT_18.Tag = "Enterprise cost manegement"
        Me._OptBCQT_18.Text = "Chi phí quản lý doanh nghiệp"
        Me._OptBCQT_18.UseVisualStyleBackColor = False
        '
        '_OptBCQT_19
        '
        Me._OptBCQT_19.BackColor = System.Drawing.Color.Transparent
        Me._OptBCQT_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBCQT_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBCQT_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBCQT_19.Location = New System.Drawing.Point(16, 472)
        Me._OptBCQT_19.Name = "_OptBCQT_19"
        Me._OptBCQT_19.Size = New System.Drawing.Size(523, 17)
        Me._OptBCQT_19.TabIndex = 212
        Me._OptBCQT_19.TabStop = True
        Me._OptBCQT_19.Tag = "Analysis of financial indicators"
        Me._OptBCQT_19.Text = "Phân tích chỉ tiêu tài chính"
        Me._OptBCQT_19.UseVisualStyleBackColor = False
        '
        '_Frame10_1
        '
        Me._Frame10_1.BackColor = System.Drawing.Color.Transparent
        Me._Frame10_1.Controls.Add(Me._Frame2_5)
        Me._Frame10_1.Controls.Add(Me._OptQT_7)
        Me._Frame10_1.Controls.Add(Me._OptQT_23)
        Me._Frame10_1.Controls.Add(Me._OptQT_8)
        Me._Frame10_1.Controls.Add(Me._OptQT_19)
        Me._Frame10_1.Controls.Add(Me._OptQT_22)
        Me._Frame10_1.Controls.Add(Me._OptQT_21)
        Me._Frame10_1.Controls.Add(Me._OptQT_16)
        Me._Frame10_1.Controls.Add(Me._OptQT_18)
        Me._Frame10_1.Controls.Add(Me._OptQT_17)
        Me._Frame10_1.Controls.Add(Me._OptQT_20)
        Me._Frame10_1.Controls.Add(Me.CboCap)
        Me._Frame10_1.Controls.Add(Me.Chk1)
        Me._Frame10_1.Controls.Add(Me._OptQT_15)
        Me._Frame10_1.Controls.Add(Me._Frame2_3)
        Me._Frame10_1.Controls.Add(Me._OptQT_4)
        Me._Frame10_1.Controls.Add(Me._OptQT_5)
        Me._Frame10_1.Controls.Add(Me._OptQT_6)
        Me._Frame10_1.Controls.Add(Me._OptQT_0)
        Me._Frame10_1.Controls.Add(Me._OptQT_3)
        Me._Frame10_1.Controls.Add(Me._OptQT_2)
        Me._Frame10_1.Controls.Add(Me._OptQT_1)
        Me._Frame10_1.Controls.Add(Me._OptQT_9)
        Me._Frame10_1.Controls.Add(Me._OptQT_14)
        Me._Frame10_1.Controls.Add(Me._OptQT_13)
        Me._Frame10_1.Controls.Add(Me._OptQT_11)
        Me._Frame10_1.Controls.Add(Me._OptQT_10)
        Me._Frame10_1.Controls.Add(Me._OptQT_12)
        Me._Frame10_1.Controls.Add(Me._txtShTk_5)
        Me._Frame10_1.Controls.Add(Me._cmdtk_5)
        Me._Frame10_1.Controls.Add(Me._Frame2_2)
        Me._Frame10_1.Controls.Add(Me._Frame2_4)
        Me._Frame10_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me._Frame10_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame10_1.ForeColor = System.Drawing.Color.Blue
        Me._Frame10_1.Location = New System.Drawing.Point(3, 3)
        Me._Frame10_1.Name = "_Frame10_1"
        Me._Frame10_1.Size = New System.Drawing.Size(634, 613)
        Me._Frame10_1.TabIndex = 136
        Me._Frame10_1.TabStop = False
        Me._Frame10_1.Tag = "Tax Report"
        Me._Frame10_1.Text = "Báo cáo thuế"
        '
        '_Frame2_5
        '
        Me._Frame2_5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Frame2_5.BackColor = System.Drawing.Color.Transparent
        Me._Frame2_5.Controls.Add(Me._cmd_0)
        Me._Frame2_5.Controls.Add(Me._cmdkh_2)
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
        Me._Frame2_5.Controls.Add(Me._cmdtk_9)
        Me._Frame2_5.Controls.Add(Me._lbkh_2)
        Me._Frame2_5.Controls.Add(Me._lb_0)
        Me._Frame2_5.Controls.Add(Me._LbTenTk_9)
        Me._Frame2_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame2_5.ForeColor = System.Drawing.Color.Blue
        Me._Frame2_5.Location = New System.Drawing.Point(8, 192)
        Me._Frame2_5.Name = "_Frame2_5"
        Me._Frame2_5.Size = New System.Drawing.Size(620, 200)
        Me._Frame2_5.TabIndex = 232
        Me._Frame2_5.TabStop = False
        Me._Frame2_5.Tag = "Turnover table"
        Me._Frame2_5.Text = "Bảng kê doanh thu theo"
        Me._Frame2_5.Visible = False
        '
        '_cmd_0
        '
        Me._cmd_0.Image = CType(resources.GetObject("_cmd_0.Image"), System.Drawing.Image)
        Me._cmd_0.Location = New System.Drawing.Point(256, 87)
        Me._cmd_0.Name = "_cmd_0"
        Me._cmd_0.Size = New System.Drawing.Size(25, 25)
        Me._cmd_0.TabIndex = 254
        '
        '_cmdkh_2
        '
        Me._cmdkh_2.Image = CType(resources.GetObject("_cmdkh_2.Image"), System.Drawing.Image)
        Me._cmdkh_2.Location = New System.Drawing.Point(255, 12)
        Me._cmdkh_2.Name = "_cmdkh_2"
        Me._cmdkh_2.Size = New System.Drawing.Size(25, 25)
        Me._cmdkh_2.TabIndex = 253
        '
        '_OptDT_2
        '
        Me._OptDT_2.BackColor = System.Drawing.Color.Transparent
        Me._OptDT_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptDT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptDT_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptDT_2.Location = New System.Drawing.Point(8, 136)
        Me._OptDT_2.Name = "_OptDT_2"
        Me._OptDT_2.Size = New System.Drawing.Size(82, 17)
        Me._OptDT_2.TabIndex = 246
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
        Me._CboKho_2.TabIndex = 245
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
        Me._txtsh_0.Size = New System.Drawing.Size(57, 20)
        Me._txtsh_0.TabIndex = 244
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
        Me._ChkDu_13.Size = New System.Drawing.Size(241, 17)
        Me._ChkDu_13.TabIndex = 243
        Me._ChkDu_13.Tag = "Summary Sale and Cost of good sold after Discount report"
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
        Me._OptDT_0.Size = New System.Drawing.Size(80, 17)
        Me._OptDT_0.TabIndex = 242
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
        Me._CboKho_1.TabIndex = 241
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
        Me._txtshkh_2.Size = New System.Drawing.Size(57, 20)
        Me._txtshkh_2.TabIndex = 240
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
        Me._ChkDu_18.Size = New System.Drawing.Size(93, 17)
        Me._ChkDu_18.TabIndex = 239
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
        Me._ChkDu_9.Size = New System.Drawing.Size(81, 17)
        Me._ChkDu_9.TabIndex = 238
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
        Me._ChkDu_19.TabIndex = 237
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
        Me._ChkDu_17.TabIndex = 236
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
        Me._OptDT_1.Size = New System.Drawing.Size(87, 17)
        Me._OptDT_1.TabIndex = 235
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
        Me._ChkDu_12.TabIndex = 234
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
        Me._txtShTk_9.Location = New System.Drawing.Point(192, 115)
        Me._txtShTk_9.MaxLength = 12
        Me._txtShTk_9.Name = "_txtShTk_9"
        Me._txtShTk_9.Size = New System.Drawing.Size(57, 20)
        Me._txtShTk_9.TabIndex = 233
        Me._txtShTk_9.Tag = "0"
        '
        '_cmdtk_9
        '
        Me._cmdtk_9.Image = CType(resources.GetObject("_cmdtk_9.Image"), System.Drawing.Image)
        Me._cmdtk_9.Location = New System.Drawing.Point(256, 112)
        Me._cmdtk_9.Name = "_cmdtk_9"
        Me._cmdtk_9.Size = New System.Drawing.Size(25, 25)
        Me._cmdtk_9.TabIndex = 249
        '
        '_lbkh_2
        '
        Me._lbkh_2.BackColor = System.Drawing.Color.Transparent
        Me._lbkh_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbkh_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbkh_2.ForeColor = System.Drawing.Color.Blue
        Me._lbkh_2.Location = New System.Drawing.Point(288, 16)
        Me._lbkh_2.Name = "_lbkh_2"
        Me._lbkh_2.Size = New System.Drawing.Size(241, 17)
        Me._lbkh_2.TabIndex = 252
        Me._lbkh_2.Tag = "1"
        '
        '_lb_0
        '
        Me._lb_0.BackColor = System.Drawing.Color.Transparent
        Me._lb_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lb_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lb_0.ForeColor = System.Drawing.Color.Blue
        Me._lb_0.Location = New System.Drawing.Point(288, 92)
        Me._lb_0.Name = "_lb_0"
        Me._lb_0.Size = New System.Drawing.Size(241, 17)
        Me._lb_0.TabIndex = 251
        Me._lb_0.Tag = "1"
        '
        '_LbTenTk_9
        '
        Me._LbTenTk_9.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_9.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_9.Location = New System.Drawing.Point(288, 116)
        Me._LbTenTk_9.Name = "_LbTenTk_9"
        Me._LbTenTk_9.Size = New System.Drawing.Size(241, 17)
        Me._LbTenTk_9.TabIndex = 250
        Me._LbTenTk_9.Tag = "1"
        '
        '_OptQT_7
        '
        Me._OptQT_7.BackColor = System.Drawing.Color.Transparent
        Me._OptQT_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_7.Location = New System.Drawing.Point(16, 152)
        Me._OptQT_7.Name = "_OptQT_7"
        Me._OptQT_7.Size = New System.Drawing.Size(161, 17)
        Me._OptQT_7.TabIndex = 254
        Me._OptQT_7.TabStop = True
        Me._OptQT_7.Tag = "Revenue, cost price List"
        Me._OptQT_7.Text = "Bảng kê doanh thu - giá vốn"
        Me._OptQT_7.UseVisualStyleBackColor = False
        '
        '_OptQT_23
        '
        Me._OptQT_23.BackColor = System.Drawing.Color.Transparent
        Me._OptQT_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_23.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_23.Location = New System.Drawing.Point(16, 176)
        Me._OptQT_23.Name = "_OptQT_23"
        Me._OptQT_23.Size = New System.Drawing.Size(161, 17)
        Me._OptQT_23.TabIndex = 253
        Me._OptQT_23.TabStop = True
        Me._OptQT_23.Tag = "Revenue List"
        Me._OptQT_23.Text = "Bảng kê doanh thu theo"
        Me._OptQT_23.UseVisualStyleBackColor = False
        '
        '_OptQT_8
        '
        Me._OptQT_8.BackColor = System.Drawing.Color.Transparent
        Me._OptQT_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_8.Location = New System.Drawing.Point(16, 440)
        Me._OptQT_8.Name = "_OptQT_8"
        Me._OptQT_8.Size = New System.Drawing.Size(209, 17)
        Me._OptQT_8.TabIndex = 113
        Me._OptQT_8.TabStop = True
        Me._OptQT_8.Tag = "Profit and Lost Appendix"
        Me._OptQT_8.Text = "Phụ lục kết quả kinh doanh"
        Me._OptQT_8.UseVisualStyleBackColor = False
        '
        '_OptQT_19
        '
        Me._OptQT_19.BackColor = System.Drawing.Color.Transparent
        Me._OptQT_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_19.Location = New System.Drawing.Point(16, 536)
        Me._OptQT_19.Name = "_OptQT_19"
        Me._OptQT_19.Size = New System.Drawing.Size(209, 17)
        Me._OptQT_19.TabIndex = 119
        Me._OptQT_19.TabStop = True
        Me._OptQT_19.Tag = "Trial balance report"
        Me._OptQT_19.Text = "Bảng cân đối số phát sinh"
        Me._OptQT_19.UseVisualStyleBackColor = False
        '
        '_OptQT_22
        '
        Me._OptQT_22.BackColor = System.Drawing.Color.Transparent
        Me._OptQT_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_22.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_22.Location = New System.Drawing.Point(16, 584)
        Me._OptQT_22.Name = "_OptQT_22"
        Me._OptQT_22.Size = New System.Drawing.Size(209, 17)
        Me._OptQT_22.TabIndex = 121
        Me._OptQT_22.TabStop = True
        Me._OptQT_22.Tag = "Detail Tax Payment Report"
        Me._OptQT_22.Text = "Bảng kê tình hình nộp thuế"
        Me._OptQT_22.UseVisualStyleBackColor = False
        '
        '_OptQT_21
        '
        Me._OptQT_21.BackColor = System.Drawing.Color.Transparent
        Me._OptQT_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_21.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_21.Location = New System.Drawing.Point(16, 560)
        Me._OptQT_21.Name = "_OptQT_21"
        Me._OptQT_21.Size = New System.Drawing.Size(209, 17)
        Me._OptQT_21.TabIndex = 120
        Me._OptQT_21.TabStop = True
        Me._OptQT_21.Tag = "Tax Payment Report"
        Me._OptQT_21.Text = "Bảng tổng hợp nghĩa vụ nộp thuế"
        Me._OptQT_21.UseVisualStyleBackColor = False
        '
        '_OptQT_16
        '
        Me._OptQT_16.BackColor = System.Drawing.Color.Transparent
        Me._OptQT_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_16.Location = New System.Drawing.Point(16, 416)
        Me._OptQT_16.Name = "_OptQT_16"
        Me._OptQT_16.Size = New System.Drawing.Size(209, 17)
        Me._OptQT_16.TabIndex = 112
        Me._OptQT_16.TabStop = True
        Me._OptQT_16.Tag = "Business results report"
        Me._OptQT_16.Text = "Báo cáo kết quả kinh doanh"
        Me._OptQT_16.UseVisualStyleBackColor = False
        '
        '_OptQT_18
        '
        Me._OptQT_18.BackColor = System.Drawing.Color.Transparent
        Me._OptQT_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_18.Location = New System.Drawing.Point(16, 488)
        Me._OptQT_18.Name = "_OptQT_18"
        Me._OptQT_18.Size = New System.Drawing.Size(209, 17)
        Me._OptQT_18.TabIndex = 115
        Me._OptQT_18.TabStop = True
        Me._OptQT_18.Tag = "Notes to financial statements"
        Me._OptQT_18.Text = "Thuyết minh báo cáo tài chính"
        Me._OptQT_18.UseVisualStyleBackColor = False
        '
        '_OptQT_17
        '
        Me._OptQT_17.BackColor = System.Drawing.Color.Transparent
        Me._OptQT_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_17.Location = New System.Drawing.Point(16, 464)
        Me._OptQT_17.Name = "_OptQT_17"
        Me._OptQT_17.Size = New System.Drawing.Size(209, 17)
        Me._OptQT_17.TabIndex = 114
        Me._OptQT_17.TabStop = True
        Me._OptQT_17.Tag = "Cash flow statement (under the direct method)"
        Me._OptQT_17.Text = "Báo cáo lưu chuyển tiền tệ (trực tiếp)"
        Me._OptQT_17.UseVisualStyleBackColor = False
        '
        '_OptQT_20
        '
        Me._OptQT_20.BackColor = System.Drawing.Color.Transparent
        Me._OptQT_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_20.Location = New System.Drawing.Point(16, 512)
        Me._OptQT_20.Name = "_OptQT_20"
        Me._OptQT_20.Size = New System.Drawing.Size(209, 17)
        Me._OptQT_20.TabIndex = 116
        Me._OptQT_20.TabStop = True
        Me._OptQT_20.Tag = "Account Balance Report"
        Me._OptQT_20.Text = "Bảng cân đối tài khoản"
        Me._OptQT_20.UseVisualStyleBackColor = False
        '
        'CboCap
        '
        Me.CboCap.BackColor = System.Drawing.SystemColors.Window
        Me.CboCap.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboCap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCap.DropDownWidth = 29
        Me.CboCap.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCap.Location = New System.Drawing.Point(440, 508)
        Me.CboCap.Name = "CboCap"
        Me.CboCap.Size = New System.Drawing.Size(50, 21)
        Me.CboCap.TabIndex = 118
        '
        'Chk1
        '
        Me.Chk1.BackColor = System.Drawing.Color.Transparent
        Me.Chk1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Chk1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk1.Location = New System.Drawing.Point(240, 512)
        Me.Chk1.Name = "Chk1"
        Me.Chk1.Size = New System.Drawing.Size(156, 17)
        Me.Chk1.TabIndex = 117
        Me.Chk1.Tag = "Print all account"
        Me.Chk1.Text = "In chi tiết không phát sinh"
        Me.Chk1.UseVisualStyleBackColor = False
        '
        '_OptQT_15
        '
        Me._OptQT_15.BackColor = System.Drawing.Color.Transparent
        Me._OptQT_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_15.Location = New System.Drawing.Point(16, 392)
        Me._OptQT_15.Name = "_OptQT_15"
        Me._OptQT_15.Size = New System.Drawing.Size(209, 17)
        Me._OptQT_15.TabIndex = 111
        Me._OptQT_15.TabStop = True
        Me._OptQT_15.Tag = "Balance sheet"
        Me._OptQT_15.Text = "Bảng cân đối kế toán"
        Me._OptQT_15.UseVisualStyleBackColor = False
        '
        '_Frame2_3
        '
        Me._Frame2_3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Frame2_3.BackColor = System.Drawing.Color.Transparent
        Me._Frame2_3.Controls.Add(Me._Label_3)
        Me._Frame2_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame2_3.ForeColor = System.Drawing.Color.Blue
        Me._Frame2_3.Location = New System.Drawing.Point(8, 376)
        Me._Frame2_3.Name = "_Frame2_3"
        Me._Frame2_3.Size = New System.Drawing.Size(620, 234)
        Me._Frame2_3.TabIndex = 178
        Me._Frame2_3.TabStop = False
        Me._Frame2_3.Tag = "Financial reports"
        Me._Frame2_3.Text = "Báo cáo tài chính"
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.Transparent
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_3.Location = New System.Drawing.Point(400, 136)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(33, 17)
        Me._Label_3.TabIndex = 179
        Me._Label_3.Tag = "Rate (%)"
        Me._Label_3.Text = "Cấp"
        '
        '_OptQT_4
        '
        Me._OptQT_4.BackColor = System.Drawing.Color.Transparent
        Me._OptQT_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_4.Location = New System.Drawing.Point(16, 296)
        Me._OptQT_4.Name = "_OptQT_4"
        Me._OptQT_4.Size = New System.Drawing.Size(249, 17)
        Me._OptQT_4.TabIndex = 108
        Me._OptQT_4.TabStop = True
        Me._OptQT_4.Tag = "Tax balance-sheet"
        Me._OptQT_4.Text = "Tờ khai quyết toán thuế"
        Me._OptQT_4.UseVisualStyleBackColor = False
        '
        '_OptQT_5
        '
        Me._OptQT_5.BackColor = System.Drawing.Color.Transparent
        Me._OptQT_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_5.Location = New System.Drawing.Point(16, 320)
        Me._OptQT_5.Name = "_OptQT_5"
        Me._OptQT_5.Size = New System.Drawing.Size(249, 17)
        Me._OptQT_5.TabIndex = 109
        Me._OptQT_5.TabStop = True
        Me._OptQT_5.Tag = "Taxable Income table 05A/BK-TNCN"
        Me._OptQT_5.Text = "Bảng kê thu nhập chịu thuế 05A/BK-TNCN"
        Me._OptQT_5.UseVisualStyleBackColor = False
        '
        '_OptQT_6
        '
        Me._OptQT_6.BackColor = System.Drawing.Color.Transparent
        Me._OptQT_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_6.Location = New System.Drawing.Point(16, 344)
        Me._OptQT_6.Name = "_OptQT_6"
        Me._OptQT_6.Size = New System.Drawing.Size(249, 17)
        Me._OptQT_6.TabIndex = 110
        Me._OptQT_6.TabStop = True
        Me._OptQT_6.Tag = "Taxable Income table 05B/BK-TNCN"
        Me._OptQT_6.Text = "Bảng kê thu nhập chịu thuế 05B/BK-TNCN"
        Me._OptQT_6.UseVisualStyleBackColor = False
        '
        '_OptQT_0
        '
        Me._OptQT_0.BackColor = System.Drawing.Color.Transparent
        Me._OptQT_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_0.Location = New System.Drawing.Point(16, 248)
        Me._OptQT_0.Name = "_OptQT_0"
        Me._OptQT_0.Size = New System.Drawing.Size(249, 17)
        Me._OptQT_0.TabIndex = 106
        Me._OptQT_0.TabStop = True
        Me._OptQT_0.Tag = "Tax Declaration Form"
        Me._OptQT_0.Text = "Tờ khai Thuế"
        Me._OptQT_0.UseVisualStyleBackColor = False
        '
        '_OptQT_3
        '
        Me._OptQT_3.BackColor = System.Drawing.Color.Transparent
        Me._OptQT_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_3.Location = New System.Drawing.Point(16, 272)
        Me._OptQT_3.Name = "_OptQT_3"
        Me._OptQT_3.Size = New System.Drawing.Size(249, 17)
        Me._OptQT_3.TabIndex = 107
        Me._OptQT_3.TabStop = True
        Me._OptQT_3.Tag = "Tax register list"
        Me._OptQT_3.Text = "Danh sách đăng ký thuế"
        Me._OptQT_3.UseVisualStyleBackColor = False
        '
        '_OptQT_2
        '
        Me._OptQT_2.BackColor = System.Drawing.Color.Transparent
        Me._OptQT_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_2.Location = New System.Drawing.Point(16, 32)
        Me._OptQT_2.Name = "_OptQT_2"
        Me._OptQT_2.Size = New System.Drawing.Size(313, 17)
        Me._OptQT_2.TabIndex = 96
        Me._OptQT_2.TabStop = True
        Me._OptQT_2.Tag = "Profit Tax Declaration"
        Me._OptQT_2.Text = "Tờ khai tự quyết toán thuế thu nhập doanh nghiệp"
        Me._OptQT_2.UseVisualStyleBackColor = False
        '
        '_OptQT_1
        '
        Me._OptQT_1.BackColor = System.Drawing.Color.Transparent
        Me._OptQT_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_1.Location = New System.Drawing.Point(16, 56)
        Me._OptQT_1.Name = "_OptQT_1"
        Me._OptQT_1.Size = New System.Drawing.Size(249, 17)
        Me._OptQT_1.TabIndex = 97
        Me._OptQT_1.TabStop = True
        Me._OptQT_1.Tag = "Profit Tax Provision Declaration"
        Me._OptQT_1.Text = "Tờ khai tạm tính thuế thu nhập doanh nghiệp"
        Me._OptQT_1.UseVisualStyleBackColor = False
        '
        '_OptQT_9
        '
        Me._OptQT_9.BackColor = System.Drawing.Color.LightCyan
        Me._OptQT_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_9.Location = New System.Drawing.Point(280, 248)
        Me._OptQT_9.Name = "_OptQT_9"
        Me._OptQT_9.Size = New System.Drawing.Size(249, 17)
        Me._OptQT_9.TabIndex = 98
        Me._OptQT_9.TabStop = True
        Me._OptQT_9.Tag = "Detail Output VAT"
        Me._OptQT_9.Text = "Phụ lục giảm thuế"
        Me._OptQT_9.UseVisualStyleBackColor = False
        Me._OptQT_9.Visible = False
        '
        '_OptQT_14
        '
        Me._OptQT_14.BackColor = System.Drawing.Color.Transparent
        Me._OptQT_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_14.Location = New System.Drawing.Point(16, 128)
        Me._OptQT_14.Name = "_OptQT_14"
        Me._OptQT_14.Size = New System.Drawing.Size(249, 17)
        Me._OptQT_14.TabIndex = 105
        Me._OptQT_14.TabStop = True
        Me._OptQT_14.Tag = "Revenue, Expense, Income Detail Table"
        Me._OptQT_14.Text = "Bảng kê chi tiết doanh thu, chi phí, thu nhập"
        Me._OptQT_14.UseVisualStyleBackColor = False
        '
        '_OptQT_13
        '
        Me._OptQT_13.BackColor = System.Drawing.Color.LightCyan
        Me._OptQT_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_13.Location = New System.Drawing.Point(280, 296)
        Me._OptQT_13.Name = "_OptQT_13"
        Me._OptQT_13.Size = New System.Drawing.Size(249, 17)
        Me._OptQT_13.TabIndex = 104
        Me._OptQT_13.TabStop = True
        Me._OptQT_13.Tag = "Detail Output VAT"
        Me._OptQT_13.Text = "Doanh thu chi tiết"
        Me._OptQT_13.UseVisualStyleBackColor = False
        Me._OptQT_13.Visible = False
        '
        '_OptQT_11
        '
        Me._OptQT_11.BackColor = System.Drawing.Color.Transparent
        Me._OptQT_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_11.Location = New System.Drawing.Point(16, 80)
        Me._OptQT_11.Name = "_OptQT_11"
        Me._OptQT_11.Size = New System.Drawing.Size(153, 17)
        Me._OptQT_11.TabIndex = 102
        Me._OptQT_11.TabStop = True
        Me._OptQT_11.Tag = "Summary Expenses Report"
        Me._OptQT_11.Text = "Tổng hợp chi phí"
        Me._OptQT_11.UseVisualStyleBackColor = False
        '
        '_OptQT_10
        '
        Me._OptQT_10.BackColor = System.Drawing.Color.LightCyan
        Me._OptQT_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_10.Location = New System.Drawing.Point(280, 272)
        Me._OptQT_10.Name = "_OptQT_10"
        Me._OptQT_10.Size = New System.Drawing.Size(153, 17)
        Me._OptQT_10.TabIndex = 99
        Me._OptQT_10.TabStop = True
        Me._OptQT_10.Tag = "Detail Deducted Input VAT"
        Me._OptQT_10.Text = "Báo cáo chi phí"
        Me._OptQT_10.UseVisualStyleBackColor = False
        Me._OptQT_10.Visible = False
        '
        '_OptQT_12
        '
        Me._OptQT_12.BackColor = System.Drawing.Color.Transparent
        Me._OptQT_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptQT_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptQT_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptQT_12.Location = New System.Drawing.Point(16, 104)
        Me._OptQT_12.Name = "_OptQT_12"
        Me._OptQT_12.Size = New System.Drawing.Size(249, 17)
        Me._OptQT_12.TabIndex = 103
        Me._OptQT_12.TabStop = True
        Me._OptQT_12.Tag = "Econemic Contracts List"
        Me._OptQT_12.Text = "Bảng kê tổng hợp hợp đồng kinh tế"
        Me._OptQT_12.UseVisualStyleBackColor = False
        '
        '_txtShTk_5
        '
        Me._txtShTk_5.AcceptsReturn = True
        Me._txtShTk_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_5.Location = New System.Drawing.Point(176, 80)
        Me._txtShTk_5.MaxLength = 12
        Me._txtShTk_5.Name = "_txtShTk_5"
        Me._txtShTk_5.Size = New System.Drawing.Size(57, 20)
        Me._txtShTk_5.TabIndex = 100
        Me._txtShTk_5.Tag = "0"
        '
        '_cmdtk_5
        '
        Me._cmdtk_5.Image = CType(resources.GetObject("_cmdtk_5.Image"), System.Drawing.Image)
        Me._cmdtk_5.Location = New System.Drawing.Point(240, 76)
        Me._cmdtk_5.Name = "_cmdtk_5"
        Me._cmdtk_5.Size = New System.Drawing.Size(25, 25)
        Me._cmdtk_5.TabIndex = 101
        '
        '_Frame2_2
        '
        Me._Frame2_2.BackColor = System.Drawing.Color.Transparent
        Me._Frame2_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame2_2.ForeColor = System.Drawing.Color.Blue
        Me._Frame2_2.Location = New System.Drawing.Point(8, 232)
        Me._Frame2_2.Name = "_Frame2_2"
        Me._Frame2_2.Size = New System.Drawing.Size(537, 137)
        Me._Frame2_2.TabIndex = 175
        Me._Frame2_2.TabStop = False
        Me._Frame2_2.Tag = "Personal incoming tax reports"
        Me._Frame2_2.Text = "Báo cáo thuế thu nhập cá nhân"
        '
        '_Frame2_4
        '
        Me._Frame2_4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Frame2_4.BackColor = System.Drawing.Color.Transparent
        Me._Frame2_4.Controls.Add(Me._LbTenTk_5)
        Me._Frame2_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame2_4.ForeColor = System.Drawing.Color.Blue
        Me._Frame2_4.Location = New System.Drawing.Point(8, 16)
        Me._Frame2_4.Name = "_Frame2_4"
        Me._Frame2_4.Size = New System.Drawing.Size(620, 209)
        Me._Frame2_4.TabIndex = 180
        Me._Frame2_4.TabStop = False
        Me._Frame2_4.Tag = "Income Tax Report"
        Me._Frame2_4.Text = "Báo cáo thuế thu nhập doanh nghiệp"
        '
        '_LbTenTk_5
        '
        Me._LbTenTk_5.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_5.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_5.Location = New System.Drawing.Point(264, 64)
        Me._LbTenTk_5.Name = "_LbTenTk_5"
        Me._LbTenTk_5.Size = New System.Drawing.Size(265, 17)
        Me._LbTenTk_5.TabIndex = 181
        Me._LbTenTk_5.Tag = "1"
        '
        '_Frame10_0
        '
        Me._Frame10_0.BackColor = System.Drawing.Color.Transparent
        Me._Frame10_0.Controls.Add(Me._ChkDu_20)
        Me._Frame10_0.Controls.Add(Me._txtShTk_14)
        Me._Frame10_0.Controls.Add(Me._OptVAT_19)
        Me._Frame10_0.Controls.Add(Me._OptVAT_18)
        Me._Frame10_0.Controls.Add(Me._OptVAT_17)
        Me._Frame10_0.Controls.Add(Me._ChkDu_14)
        Me._Frame10_0.Controls.Add(Me._OptVAT_20)
        Me._Frame10_0.Controls.Add(Me.cboQuy)
        Me._Frame10_0.Controls.Add(Me._OptVAT_9)
        Me._Frame10_0.Controls.Add(Me._OptVAT_1)
        Me._Frame10_0.Controls.Add(Me._OptVAT_0)
        Me._Frame10_0.Controls.Add(Me._OptVAT_2)
        Me._Frame10_0.Controls.Add(Me._OptVAT_3)
        Me._Frame10_0.Controls.Add(Me._OptVAT_6)
        Me._Frame10_0.Controls.Add(Me.CboTL)
        Me._Frame10_0.Controls.Add(Me._OptVAT_5)
        Me._Frame10_0.Controls.Add(Me._OptVAT_7)
        Me._Frame10_0.Controls.Add(Me._OptVAT_8)
        Me._Frame10_0.Controls.Add(Me._ChkDu_15)
        Me._Frame10_0.Controls.Add(Me._txtShTk_15)
        Me._Frame10_0.Controls.Add(Me._OptVAT_10)
        Me._Frame10_0.Controls.Add(Me._txtShTk_11)
        Me._Frame10_0.Controls.Add(Me._txtShTk_7)
        Me._Frame10_0.Controls.Add(Me._Chk_7)
        Me._Frame10_0.Controls.Add(Me._OptVAT_11)
        Me._Frame10_0.Controls.Add(Me._OptVAT_4)
        Me._Frame10_0.Controls.Add(Me._Chk_1)
        Me._Frame10_0.Controls.Add(Me._OptVAT_12)
        Me._Frame10_0.Controls.Add(Me._OptVAT_13)
        Me._Frame10_0.Controls.Add(Me._OptVAT_15)
        Me._Frame10_0.Controls.Add(Me._OptVAT_14)
        Me._Frame10_0.Controls.Add(Me._OptVAT_16)
        Me._Frame10_0.Controls.Add(Me._cmdtk_7)
        Me._Frame10_0.Controls.Add(Me._cmdtk_11)
        Me._Frame10_0.Controls.Add(Me._cmdtk_15)
        Me._Frame10_0.Controls.Add(Me._Frame2_0)
        Me._Frame10_0.Controls.Add(Me._cmdtk_14)
        Me._Frame10_0.Controls.Add(Me._Frame2_1)
        Me._Frame10_0.Controls.Add(Me._Label_2)
        Me._Frame10_0.Controls.Add(Me._LbTenTk_11)
        Me._Frame10_0.Controls.Add(Me._LbTenTk_15)
        Me._Frame10_0.Controls.Add(Me._LbTenTk_7)
        Me._Frame10_0.Dock = System.Windows.Forms.DockStyle.Fill
        Me._Frame10_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame10_0.ForeColor = System.Drawing.Color.Blue
        Me._Frame10_0.Location = New System.Drawing.Point(3, 3)
        Me._Frame10_0.Name = "_Frame10_0"
        Me._Frame10_0.Size = New System.Drawing.Size(634, 613)
        Me._Frame10_0.TabIndex = 137
        Me._Frame10_0.TabStop = False
        Me._Frame10_0.Tag = "VAT Reports"
        Me._Frame10_0.Text = "Báo cáo thuế giá trị gia tăng"
        '
        '_ChkDu_20
        '
        Me._ChkDu_20.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_20.Location = New System.Drawing.Point(304, 112)
        Me._ChkDu_20.Name = "_ChkDu_20"
        Me._ChkDu_20.Size = New System.Drawing.Size(241, 17)
        Me._ChkDu_20.TabIndex = 258
        Me._ChkDu_20.Tag = "Enumerate online"
        Me._ChkDu_20.Text = "Kê khai qua mạng"
        Me._ChkDu_20.UseVisualStyleBackColor = False
        '
        '_txtShTk_14
        '
        Me._txtShTk_14.AcceptsReturn = True
        Me._txtShTk_14.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_14.Location = New System.Drawing.Point(304, 488)
        Me._txtShTk_14.MaxLength = 12
        Me._txtShTk_14.Name = "_txtShTk_14"
        Me._txtShTk_14.Size = New System.Drawing.Size(57, 20)
        Me._txtShTk_14.TabIndex = 36
        Me._txtShTk_14.Tag = "0"
        '
        '_OptVAT_19
        '
        Me._OptVAT_19.BackColor = System.Drawing.Color.Transparent
        Me._OptVAT_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVAT_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVAT_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVAT_19.Location = New System.Drawing.Point(16, 512)
        Me._OptVAT_19.Name = "_OptVAT_19"
        Me._OptVAT_19.Size = New System.Drawing.Size(177, 17)
        Me._OptVAT_19.TabIndex = 22
        Me._OptVAT_19.TabStop = True
        Me._OptVAT_19.Tag = "VAT Ouput Table"
        Me._OptVAT_19.Text = "Biên bản bàn giao"
        Me._OptVAT_19.UseVisualStyleBackColor = False
        Me._OptVAT_19.Visible = False
        '
        '_OptVAT_18
        '
        Me._OptVAT_18.BackColor = System.Drawing.Color.Transparent
        Me._OptVAT_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVAT_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVAT_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVAT_18.Location = New System.Drawing.Point(16, 488)
        Me._OptVAT_18.Name = "_OptVAT_18"
        Me._OptVAT_18.Size = New System.Drawing.Size(177, 17)
        Me._OptVAT_18.TabIndex = 21
        Me._OptVAT_18.TabStop = True
        Me._OptVAT_18.Tag = "Excise Tax Declaration Form"
        Me._OptVAT_18.Text = "Tờ khai thuế tiêu thụ đặc biệt"
        Me._OptVAT_18.UseVisualStyleBackColor = False
        '
        '_OptVAT_17
        '
        Me._OptVAT_17.BackColor = System.Drawing.Color.Transparent
        Me._OptVAT_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVAT_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVAT_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVAT_17.Location = New System.Drawing.Point(16, 464)
        Me._OptVAT_17.Name = "_OptVAT_17"
        Me._OptVAT_17.Size = New System.Drawing.Size(177, 17)
        Me._OptVAT_17.TabIndex = 20
        Me._OptVAT_17.TabStop = True
        Me._OptVAT_17.Tag = "Licence Tax Declaration Form"
        Me._OptVAT_17.Text = "Tờ khai thuế môn bài"
        Me._OptVAT_17.UseVisualStyleBackColor = False
        '
        '_ChkDu_14
        '
        Me._ChkDu_14.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_14.Location = New System.Drawing.Point(200, 488)
        Me._ChkDu_14.Name = "_ChkDu_14"
        Me._ChkDu_14.Size = New System.Drawing.Size(97, 17)
        Me._ChkDu_14.TabIndex = 35
        Me._ChkDu_14.Tag = "Account"
        Me._ChkDu_14.Text = "Tài khoản"
        Me._ChkDu_14.UseVisualStyleBackColor = False
        '
        '_OptVAT_20
        '
        Me._OptVAT_20.BackColor = System.Drawing.Color.Transparent
        Me._OptVAT_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVAT_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVAT_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVAT_20.Location = New System.Drawing.Point(16, 536)
        Me._OptVAT_20.Name = "_OptVAT_20"
        Me._OptVAT_20.Size = New System.Drawing.Size(177, 17)
        Me._OptVAT_20.TabIndex = 23
        Me._OptVAT_20.TabStop = True
        Me._OptVAT_20.Tag = "VAT Ouput Table"
        Me._OptVAT_20.Text = "Biên bản bàn giao công việc"
        Me._OptVAT_20.UseVisualStyleBackColor = False
        Me._OptVAT_20.Visible = False
        '
        'cboQuy
        '
        Me.cboQuy.BackColor = System.Drawing.SystemColors.Window
        Me.cboQuy.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboQuy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboQuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuy.DropDownWidth = 29
        Me.cboQuy.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQuy.Location = New System.Drawing.Point(200, 56)
        Me.cboQuy.Name = "cboQuy"
        Me.cboQuy.Size = New System.Drawing.Size(57, 21)
        Me.cboQuy.TabIndex = 24
        '
        '_OptVAT_9
        '
        Me._OptVAT_9.BackColor = System.Drawing.Color.Transparent
        Me._OptVAT_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVAT_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVAT_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVAT_9.Location = New System.Drawing.Point(16, 80)
        Me._OptVAT_9.Name = "_OptVAT_9"
        Me._OptVAT_9.Size = New System.Drawing.Size(177, 17)
        Me._OptVAT_9.TabIndex = 5
        Me._OptVAT_9.TabStop = True
        Me._OptVAT_9.Tag = "VAT detail report in year"
        Me._OptVAT_9.Text = "Báo cáo số lượng hoá đơn năm"
        Me._OptVAT_9.UseVisualStyleBackColor = False
        '
        '_OptVAT_1
        '
        Me._OptVAT_1.BackColor = System.Drawing.Color.Transparent
        Me._OptVAT_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVAT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVAT_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVAT_1.Location = New System.Drawing.Point(16, 56)
        Me._OptVAT_1.Name = "_OptVAT_1"
        Me._OptVAT_1.Size = New System.Drawing.Size(177, 17)
        Me._OptVAT_1.TabIndex = 4
        Me._OptVAT_1.TabStop = True
        Me._OptVAT_1.Tag = "VAT detail report in quarter"
        Me._OptVAT_1.Text = "Báo cáo số lượng hoá đơn quý"
        Me._OptVAT_1.UseVisualStyleBackColor = False
        '
        '_OptVAT_0
        '
        Me._OptVAT_0.BackColor = System.Drawing.Color.Transparent
        Me._OptVAT_0.Checked = True
        Me._OptVAT_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVAT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVAT_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVAT_0.Location = New System.Drawing.Point(16, 32)
        Me._OptVAT_0.Name = "_OptVAT_0"
        Me._OptVAT_0.Size = New System.Drawing.Size(185, 17)
        Me._OptVAT_0.TabIndex = 3
        Me._OptVAT_0.TabStop = True
        Me._OptVAT_0.Tag = "VAT detail report in month"
        Me._OptVAT_0.Text = "Báo cáo số lượng hoá đơn tháng"
        Me._OptVAT_0.UseVisualStyleBackColor = False
        '
        '_OptVAT_2
        '
        Me._OptVAT_2.BackColor = System.Drawing.Color.Transparent
        Me._OptVAT_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVAT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVAT_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVAT_2.Location = New System.Drawing.Point(16, 112)
        Me._OptVAT_2.Name = "_OptVAT_2"
        Me._OptVAT_2.Size = New System.Drawing.Size(177, 17)
        Me._OptVAT_2.TabIndex = 6
        Me._OptVAT_2.TabStop = True
        Me._OptVAT_2.Tag = "VAT Output Table"
        Me._OptVAT_2.Text = "Bảng kê hoá đơn  đầu ra"
        Me._OptVAT_2.UseVisualStyleBackColor = False
        '
        '_OptVAT_3
        '
        Me._OptVAT_3.BackColor = System.Drawing.Color.Transparent
        Me._OptVAT_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVAT_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVAT_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVAT_3.Location = New System.Drawing.Point(16, 136)
        Me._OptVAT_3.Name = "_OptVAT_3"
        Me._OptVAT_3.Size = New System.Drawing.Size(177, 17)
        Me._OptVAT_3.TabIndex = 7
        Me._OptVAT_3.TabStop = True
        Me._OptVAT_3.Tag = "VAT Input Table"
        Me._OptVAT_3.Text = "Bảng kê hoá đơn đầu vào"
        Me._OptVAT_3.UseVisualStyleBackColor = False
        '
        '_OptVAT_6
        '
        Me._OptVAT_6.BackColor = System.Drawing.Color.Transparent
        Me._OptVAT_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVAT_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVAT_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVAT_6.Location = New System.Drawing.Point(16, 208)
        Me._OptVAT_6.Name = "_OptVAT_6"
        Me._OptVAT_6.Size = New System.Drawing.Size(177, 17)
        Me._OptVAT_6.TabIndex = 10
        Me._OptVAT_6.TabStop = True
        Me._OptVAT_6.Tag = "Value Added Tax Declaration"
        Me._OptVAT_6.Text = "Tờ khai thuế giá trị gia tăng"
        Me._OptVAT_6.UseVisualStyleBackColor = False
        '
        'CboTL
        '
        Me.CboTL.BackColor = System.Drawing.SystemColors.Window
        Me.CboTL.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboTL.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTL.DropDownWidth = 53
        Me.CboTL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTL.Location = New System.Drawing.Point(240, 112)
        Me.CboTL.Name = "CboTL"
        Me.CboTL.Size = New System.Drawing.Size(57, 21)
        Me.CboTL.TabIndex = 25
        '
        '_OptVAT_5
        '
        Me._OptVAT_5.BackColor = System.Drawing.Color.Transparent
        Me._OptVAT_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVAT_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVAT_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVAT_5.Location = New System.Drawing.Point(16, 184)
        Me._OptVAT_5.Name = "_OptVAT_5"
        Me._OptVAT_5.Size = New System.Drawing.Size(281, 17)
        Me._OptVAT_5.TabIndex = 9
        Me._OptVAT_5.TabStop = True
        Me._OptVAT_5.Tag = "VAT Inputs without Invoice"
        Me._OptVAT_5.Text = "Bảng kê hoá đơn, chứng từ đầu vào không hoá đơn"
        Me._OptVAT_5.UseVisualStyleBackColor = False
        '
        '_OptVAT_7
        '
        Me._OptVAT_7.BackColor = System.Drawing.Color.Transparent
        Me._OptVAT_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVAT_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVAT_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVAT_7.Location = New System.Drawing.Point(16, 232)
        Me._OptVAT_7.Name = "_OptVAT_7"
        Me._OptVAT_7.Size = New System.Drawing.Size(281, 17)
        Me._OptVAT_7.TabIndex = 11
        Me._OptVAT_7.TabStop = True
        Me._OptVAT_7.Tag = "Invoice List of Excise tax"
        Me._OptVAT_7.Text = "Bảng kê hoá đơn, chứng từ đầu ra có thuế TTĐB"
        Me._OptVAT_7.UseVisualStyleBackColor = False
        '
        '_OptVAT_8
        '
        Me._OptVAT_8.BackColor = System.Drawing.Color.Transparent
        Me._OptVAT_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVAT_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVAT_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVAT_8.Location = New System.Drawing.Point(16, 256)
        Me._OptVAT_8.Name = "_OptVAT_8"
        Me._OptVAT_8.Size = New System.Drawing.Size(281, 17)
        Me._OptVAT_8.TabIndex = 12
        Me._OptVAT_8.TabStop = True
        Me._OptVAT_8.Tag = "Sales Product List of Excise Tax"
        Me._OptVAT_8.Text = "Bảng kê hàng hoá dịch vụ bán ra chịu thuế TTĐB"
        Me._OptVAT_8.UseVisualStyleBackColor = False
        '
        '_ChkDu_15
        '
        Me._ChkDu_15.BackColor = System.Drawing.Color.Transparent
        Me._ChkDu_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkDu_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkDu_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkDu_15.Location = New System.Drawing.Point(200, 136)
        Me._ChkDu_15.Name = "_ChkDu_15"
        Me._ChkDu_15.Size = New System.Drawing.Size(97, 17)
        Me._ChkDu_15.TabIndex = 26
        Me._ChkDu_15.Tag = "Account"
        Me._ChkDu_15.Text = "Tài khoản"
        Me._ChkDu_15.UseVisualStyleBackColor = False
        '
        '_txtShTk_15
        '
        Me._txtShTk_15.AcceptsReturn = True
        Me._txtShTk_15.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_15.Location = New System.Drawing.Point(304, 136)
        Me._txtShTk_15.MaxLength = 12
        Me._txtShTk_15.Name = "_txtShTk_15"
        Me._txtShTk_15.Size = New System.Drawing.Size(57, 20)
        Me._txtShTk_15.TabIndex = 27
        Me._txtShTk_15.Tag = "0"
        '
        '_OptVAT_10
        '
        Me._OptVAT_10.BackColor = System.Drawing.Color.Transparent
        Me._OptVAT_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVAT_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVAT_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVAT_10.Location = New System.Drawing.Point(16, 280)
        Me._OptVAT_10.Name = "_OptVAT_10"
        Me._OptVAT_10.Size = New System.Drawing.Size(181, 17)
        Me._OptVAT_10.TabIndex = 13
        Me._OptVAT_10.TabStop = True
        Me._OptVAT_10.Tag = "Input Accordly Acccounting Table"
        Me._OptVAT_10.Text = "Bảng kê đầu vào theo tài khoản"
        Me._OptVAT_10.UseVisualStyleBackColor = False
        '
        '_txtShTk_11
        '
        Me._txtShTk_11.AcceptsReturn = True
        Me._txtShTk_11.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_11.Location = New System.Drawing.Point(200, 280)
        Me._txtShTk_11.MaxLength = 12
        Me._txtShTk_11.Name = "_txtShTk_11"
        Me._txtShTk_11.Size = New System.Drawing.Size(57, 20)
        Me._txtShTk_11.TabIndex = 30
        Me._txtShTk_11.Tag = "0"
        '
        '_txtShTk_7
        '
        Me._txtShTk_7.AcceptsReturn = True
        Me._txtShTk_7.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_7.Location = New System.Drawing.Point(304, 304)
        Me._txtShTk_7.MaxLength = 12
        Me._txtShTk_7.Name = "_txtShTk_7"
        Me._txtShTk_7.Size = New System.Drawing.Size(57, 20)
        Me._txtShTk_7.TabIndex = 33
        Me._txtShTk_7.Tag = "0"
        '
        '_Chk_7
        '
        Me._Chk_7.BackColor = System.Drawing.Color.Transparent
        Me._Chk_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_7.Location = New System.Drawing.Point(200, 304)
        Me._Chk_7.Name = "_Chk_7"
        Me._Chk_7.Size = New System.Drawing.Size(97, 17)
        Me._Chk_7.TabIndex = 32
        Me._Chk_7.Tag = "by Ref. Acc."
        Me._Chk_7.Text = "Tk đối ứng"
        Me._Chk_7.UseVisualStyleBackColor = False
        '
        '_OptVAT_11
        '
        Me._OptVAT_11.BackColor = System.Drawing.Color.Transparent
        Me._OptVAT_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVAT_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVAT_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVAT_11.Location = New System.Drawing.Point(16, 304)
        Me._OptVAT_11.Name = "_OptVAT_11"
        Me._OptVAT_11.Size = New System.Drawing.Size(177, 17)
        Me._OptVAT_11.TabIndex = 14
        Me._OptVAT_11.TabStop = True
        Me._OptVAT_11.Tag = "Output Accordly Acccounting Table"
        Me._OptVAT_11.Text = "Bảng kê đầu ra theo tài khoản"
        Me._OptVAT_11.UseVisualStyleBackColor = False
        '
        '_OptVAT_4
        '
        Me._OptVAT_4.BackColor = System.Drawing.Color.Transparent
        Me._OptVAT_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVAT_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVAT_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVAT_4.Location = New System.Drawing.Point(16, 160)
        Me._OptVAT_4.Name = "_OptVAT_4"
        Me._OptVAT_4.Size = New System.Drawing.Size(193, 17)
        Me._OptVAT_4.TabIndex = 8
        Me._OptVAT_4.TabStop = True
        Me._OptVAT_4.Tag = "Utility payment statement"
        Me._OptVAT_4.Text = "Bảng kê thanh toán tiền điện, nước"
        Me._OptVAT_4.UseVisualStyleBackColor = False
        '
        '_Chk_1
        '
        Me._Chk_1.BackColor = System.Drawing.Color.Transparent
        Me._Chk_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_1.Location = New System.Drawing.Point(200, 208)
        Me._Chk_1.Name = "_Chk_1"
        Me._Chk_1.Size = New System.Drawing.Size(97, 17)
        Me._Chk_1.TabIndex = 29
        Me._Chk_1.Tag = "Print Bar Code"
        Me._Chk_1.Text = "Mã vạch"
        Me._Chk_1.UseVisualStyleBackColor = False
        '
        '_OptVAT_12
        '
        Me._OptVAT_12.BackColor = System.Drawing.Color.Transparent
        Me._OptVAT_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVAT_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVAT_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVAT_12.Location = New System.Drawing.Point(16, 328)
        Me._OptVAT_12.Name = "_OptVAT_12"
        Me._OptVAT_12.Size = New System.Drawing.Size(177, 17)
        Me._OptVAT_12.TabIndex = 15
        Me._OptVAT_12.TabStop = True
        Me._OptVAT_12.Tag = "Tax Report"
        Me._OptVAT_12.Text = "Báo cáo thuế"
        Me._OptVAT_12.UseVisualStyleBackColor = False
        '
        '_OptVAT_13
        '
        Me._OptVAT_13.BackColor = System.Drawing.Color.Transparent
        Me._OptVAT_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVAT_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVAT_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVAT_13.Location = New System.Drawing.Point(16, 352)
        Me._OptVAT_13.Name = "_OptVAT_13"
        Me._OptVAT_13.Size = New System.Drawing.Size(289, 17)
        Me._OptVAT_13.TabIndex = 16
        Me._OptVAT_13.TabStop = True
        Me._OptVAT_13.Tag = "Deducted, Refunded, Exempted VAT"
        Me._OptVAT_13.Text = "Thuế GTGT được khấu trừ, được hoàn lại, miễn giảm"
        Me._OptVAT_13.UseVisualStyleBackColor = False
        '
        '_OptVAT_15
        '
        Me._OptVAT_15.BackColor = System.Drawing.Color.Transparent
        Me._OptVAT_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVAT_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVAT_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVAT_15.Location = New System.Drawing.Point(16, 400)
        Me._OptVAT_15.Name = "_OptVAT_15"
        Me._OptVAT_15.Size = New System.Drawing.Size(289, 17)
        Me._OptVAT_15.TabIndex = 18
        Me._OptVAT_15.TabStop = True
        Me._OptVAT_15.Tag = "Summary Revenue and Output VAT Report"
        Me._OptVAT_15.Text = "Doanh số và thuế GTGT đầu ra"
        Me._OptVAT_15.UseVisualStyleBackColor = False
        '
        '_OptVAT_14
        '
        Me._OptVAT_14.BackColor = System.Drawing.Color.Transparent
        Me._OptVAT_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVAT_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVAT_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVAT_14.Location = New System.Drawing.Point(16, 376)
        Me._OptVAT_14.Name = "_OptVAT_14"
        Me._OptVAT_14.Size = New System.Drawing.Size(289, 17)
        Me._OptVAT_14.TabIndex = 17
        Me._OptVAT_14.TabStop = True
        Me._OptVAT_14.Tag = "Detail Deducted Input VAT"
        Me._OptVAT_14.Text = "Bảng phân tích thuế GTGT đầu vào được khấu trừ"
        Me._OptVAT_14.UseVisualStyleBackColor = False
        '
        '_OptVAT_16
        '
        Me._OptVAT_16.BackColor = System.Drawing.Color.Transparent
        Me._OptVAT_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVAT_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVAT_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVAT_16.Location = New System.Drawing.Point(16, 424)
        Me._OptVAT_16.Name = "_OptVAT_16"
        Me._OptVAT_16.Size = New System.Drawing.Size(289, 17)
        Me._OptVAT_16.TabIndex = 19
        Me._OptVAT_16.TabStop = True
        Me._OptVAT_16.Tag = "Detail Tax Payment Report"
        Me._OptVAT_16.Text = "Bảng kê tình trạng thuế GTGT"
        Me._OptVAT_16.UseVisualStyleBackColor = False
        '
        '_cmdtk_7
        '
        Me._cmdtk_7.Image = CType(resources.GetObject("_cmdtk_7.Image"), System.Drawing.Image)
        Me._cmdtk_7.Location = New System.Drawing.Point(368, 301)
        Me._cmdtk_7.Name = "_cmdtk_7"
        Me._cmdtk_7.Size = New System.Drawing.Size(25, 25)
        Me._cmdtk_7.TabIndex = 34
        '
        '_cmdtk_11
        '
        Me._cmdtk_11.Image = CType(resources.GetObject("_cmdtk_11.Image"), System.Drawing.Image)
        Me._cmdtk_11.Location = New System.Drawing.Point(264, 276)
        Me._cmdtk_11.Name = "_cmdtk_11"
        Me._cmdtk_11.Size = New System.Drawing.Size(25, 25)
        Me._cmdtk_11.TabIndex = 31
        '
        '_cmdtk_15
        '
        Me._cmdtk_15.Image = CType(resources.GetObject("_cmdtk_15.Image"), System.Drawing.Image)
        Me._cmdtk_15.Location = New System.Drawing.Point(368, 132)
        Me._cmdtk_15.Name = "_cmdtk_15"
        Me._cmdtk_15.Size = New System.Drawing.Size(25, 25)
        Me._cmdtk_15.TabIndex = 28
        '
        '_Frame2_0
        '
        Me._Frame2_0.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Frame2_0.BackColor = System.Drawing.Color.Transparent
        Me._Frame2_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame2_0.ForeColor = System.Drawing.Color.Blue
        Me._Frame2_0.Location = New System.Drawing.Point(8, 16)
        Me._Frame2_0.Name = "_Frame2_0"
        Me._Frame2_0.Size = New System.Drawing.Size(620, 89)
        Me._Frame2_0.TabIndex = 172
        Me._Frame2_0.TabStop = False
        Me._Frame2_0.Tag = "Invoice reports"
        Me._Frame2_0.Text = "Báo cáo hoá đơn"
        '
        '_cmdtk_14
        '
        Me._cmdtk_14.Image = CType(resources.GetObject("_cmdtk_14.Image"), System.Drawing.Image)
        Me._cmdtk_14.Location = New System.Drawing.Point(368, 484)
        Me._cmdtk_14.Name = "_cmdtk_14"
        Me._cmdtk_14.Size = New System.Drawing.Size(25, 25)
        Me._cmdtk_14.TabIndex = 37
        '
        '_Frame2_1
        '
        Me._Frame2_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Frame2_1.BackColor = System.Drawing.Color.Transparent
        Me._Frame2_1.Controls.Add(Me._LbTenTk_14)
        Me._Frame2_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame2_1.ForeColor = System.Drawing.Color.Blue
        Me._Frame2_1.Location = New System.Drawing.Point(8, 448)
        Me._Frame2_1.Name = "_Frame2_1"
        Me._Frame2_1.Size = New System.Drawing.Size(620, 73)
        Me._Frame2_1.TabIndex = 173
        Me._Frame2_1.TabStop = False
        Me._Frame2_1.Tag = "Other reports"
        Me._Frame2_1.Text = "Báo cáo khác"
        '
        '_LbTenTk_14
        '
        Me._LbTenTk_14.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_14.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_14.Location = New System.Drawing.Point(392, 40)
        Me._LbTenTk_14.Name = "_LbTenTk_14"
        Me._LbTenTk_14.Size = New System.Drawing.Size(137, 17)
        Me._LbTenTk_14.TabIndex = 174
        Me._LbTenTk_14.Tag = "1"
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.Transparent
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(200, 112)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(41, 17)
        Me._Label_2.TabIndex = 158
        Me._Label_2.Tag = "Rate (%)"
        Me._Label_2.Text = "Tỷ lệ %"
        '
        '_LbTenTk_11
        '
        Me._LbTenTk_11.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_11.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_11.Location = New System.Drawing.Point(304, 280)
        Me._LbTenTk_11.Name = "_LbTenTk_11"
        Me._LbTenTk_11.Size = New System.Drawing.Size(241, 17)
        Me._LbTenTk_11.TabIndex = 157
        Me._LbTenTk_11.Tag = "1"
        '
        '_LbTenTk_15
        '
        Me._LbTenTk_15.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_15.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_15.Location = New System.Drawing.Point(400, 136)
        Me._LbTenTk_15.Name = "_LbTenTk_15"
        Me._LbTenTk_15.Size = New System.Drawing.Size(145, 17)
        Me._LbTenTk_15.TabIndex = 156
        Me._LbTenTk_15.Tag = "1"
        '
        '_LbTenTk_7
        '
        Me._LbTenTk_7.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_7.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_7.Location = New System.Drawing.Point(400, 304)
        Me._LbTenTk_7.Name = "_LbTenTk_7"
        Me._LbTenTk_7.Size = New System.Drawing.Size(145, 17)
        Me._LbTenTk_7.TabIndex = 155
        Me._LbTenTk_7.Tag = "1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tab_VAT_Reports)
        Me.TabControl1.Controls.Add(Me.Tab_Tax_Report)
        Me.TabControl1.Controls.Add(Me.Tab_Accounting)
        Me.TabControl1.Controls.Add(Me.Tab_Management_Reports)
        Me.TabControl1.Controls.Add(Me.Tab_Investoes_reports)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(648, 646)
        Me.TabControl1.TabIndex = 212
        '
        'Tab_Accounting
        '
        Me.Tab_Accounting.Controls.Add(Me._Frame10_2)
        Me.Tab_Accounting.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_Accounting.ForeColor = System.Drawing.Color.Blue
        Me.Tab_Accounting.ImageIndex = 0
        Me.Tab_Accounting.Location = New System.Drawing.Point(4, 23)
        Me.Tab_Accounting.Name = "Tab_Accounting"
        Me.Tab_Accounting.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Accounting.Size = New System.Drawing.Size(640, 619)
        Me.Tab_Accounting.TabIndex = 0
        Me.Tab_Accounting.Tag = "Accounting"
        Me.Tab_Accounting.Text = "Sổ kế toán"
        Me.Tab_Accounting.UseVisualStyleBackColor = True
        '
        'Tab_Tax_Report
        '
        Me.Tab_Tax_Report.Controls.Add(Me._Frame10_1)
        Me.Tab_Tax_Report.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_Tax_Report.ForeColor = System.Drawing.Color.Blue
        Me.Tab_Tax_Report.ImageIndex = 3
        Me.Tab_Tax_Report.Location = New System.Drawing.Point(4, 23)
        Me.Tab_Tax_Report.Name = "Tab_Tax_Report"
        Me.Tab_Tax_Report.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Tax_Report.Size = New System.Drawing.Size(640, 619)
        Me.Tab_Tax_Report.TabIndex = 2
        Me.Tab_Tax_Report.Tag = "Tax Report"
        Me.Tab_Tax_Report.Text = "Báo cáo thuế"
        Me.Tab_Tax_Report.UseVisualStyleBackColor = True
        '
        'Tab_VAT_Reports
        '
        Me.Tab_VAT_Reports.Controls.Add(Me._Frame10_0)
        Me.Tab_VAT_Reports.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_VAT_Reports.ForeColor = System.Drawing.Color.Blue
        Me.Tab_VAT_Reports.ImageIndex = 4
        Me.Tab_VAT_Reports.Location = New System.Drawing.Point(4, 23)
        Me.Tab_VAT_Reports.Name = "Tab_VAT_Reports"
        Me.Tab_VAT_Reports.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_VAT_Reports.Size = New System.Drawing.Size(640, 619)
        Me.Tab_VAT_Reports.TabIndex = 3
        Me.Tab_VAT_Reports.Tag = "VAT Reports"
        Me.Tab_VAT_Reports.Text = "Thuế giá trị gia tăng"
        Me.Tab_VAT_Reports.UseVisualStyleBackColor = True
        '
        'Tab_Investoes_reports
        '
        Me.Tab_Investoes_reports.Controls.Add(Me._Frame10_4)
        Me.Tab_Investoes_reports.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_Investoes_reports.ForeColor = System.Drawing.Color.Blue
        Me.Tab_Investoes_reports.ImageIndex = 1
        Me.Tab_Investoes_reports.Location = New System.Drawing.Point(4, 23)
        Me.Tab_Investoes_reports.Name = "Tab_Investoes_reports"
        Me.Tab_Investoes_reports.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Investoes_reports.Size = New System.Drawing.Size(640, 619)
        Me.Tab_Investoes_reports.TabIndex = 1
        Me.Tab_Investoes_reports.Tag = "Investoes reports"
        Me.Tab_Investoes_reports.Text = "Chủ đầu tư"
        Me.Tab_Investoes_reports.UseVisualStyleBackColor = True
        '
        'Tab_Management_Reports
        '
        Me.Tab_Management_Reports.Controls.Add(Me._Frame10_3)
        Me.Tab_Management_Reports.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_Management_Reports.ForeColor = System.Drawing.Color.Blue
        Me.Tab_Management_Reports.ImageIndex = 2
        Me.Tab_Management_Reports.Location = New System.Drawing.Point(4, 23)
        Me.Tab_Management_Reports.Name = "Tab_Management_Reports"
        Me.Tab_Management_Reports.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Management_Reports.Size = New System.Drawing.Size(640, 619)
        Me.Tab_Management_Reports.TabIndex = 5
        Me.Tab_Management_Reports.Tag = "Management Reports"
        Me.Tab_Management_Reports.Text = "Quản trị"
        Me.Tab_Management_Reports.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "accounting-16.png")
        Me.ImageList1.Images.SetKeyName(1, "investor.png")
        Me.ImageList1.Images.SetKeyName(2, "reportmanager.png")
        Me.ImageList1.Images.SetKeyName(3, "tax.png")
        Me.ImageList1.Images.SetKeyName(4, "vat.png")
        '
        'FrmMNBaocao
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1122, 646)
        Me.Controls.Add(Me._Cmd1_0)
        Me.Controls.Add(Me._Cmd1_1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me._Frame4_0)
        Me.Controls.Add(Me._Cmd1_2)
        Me.Controls.Add(Me._Cmd1_4)
        Me.Controls.Add(Me._Cmd1_3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMNBaocao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Reporting and accounting"
        Me.Text = "Báo cáo và sổ kế toán"
        Me._Frame4_0.ResumeLayout(False)
        Me._Frame_1.ResumeLayout(False)
        Me._Frame_1.PerformLayout()
        Me._Frame_0.ResumeLayout(False)
        Me._Frame10_2.ResumeLayout(False)
        Me._Frame10_2.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me._Frame10_4.ResumeLayout(False)
        Me._Frame10_4.PerformLayout()
        Me._Frame10_3.ResumeLayout(False)
        Me._Frame10_1.ResumeLayout(False)
        Me._Frame10_1.PerformLayout()
        Me._Frame2_5.ResumeLayout(False)
        Me._Frame2_5.PerformLayout()
        Me._Frame2_3.ResumeLayout(False)
        Me._Frame2_4.ResumeLayout(False)
        Me._Frame10_0.ResumeLayout(False)
        Me._Frame10_0.PerformLayout()
        Me._Frame2_1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Tab_Accounting.ResumeLayout(False)
        Me.Tab_Tax_Report.ResumeLayout(False)
        Me.Tab_VAT_Reports.ResumeLayout(False)
        Me.Tab_Investoes_reports.ResumeLayout(False)
        Me.Tab_Management_Reports.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Sub Initializetxtshkh()
        Me.txtshkh(0) = _txtshkh_0
        Me.txtshkh(2) = _txtshkh_2
    End Sub
    Sub Initializetxtsh()
        Me.txtsh(0) = _txtsh_0
    End Sub
    Sub InitializetxtShVT()
        Me.txtShVT(2) = _txtShVT_2
        Me.txtShVT(1) = _txtShVT_1
        Me.txtShVT(0) = _txtShVT_0
    End Sub
    Sub InitializetxtShTk()
        Me.txtShTk(8) = _txtShTk_8
        Me.txtShTk(3) = _txtShTk_3
        Me.txtShTk(2) = _txtShTk_2
        Me.txtShTk(4) = _txtShTk_4
        Me.txtShTk(10) = _txtShTk_10
        Me.txtShTk(0) = _txtShTk_0
        Me.txtShTk(1) = _txtShTk_1
        Me.txtShTk(9) = _txtShTk_9
        Me.txtShTk(5) = _txtShTk_5
        Me.txtShTk(14) = _txtShTk_14
        Me.txtShTk(15) = _txtShTk_15
        Me.txtShTk(11) = _txtShTk_11
        Me.txtShTk(7) = _txtShTk_7
        'Me.txtShTk(6) = _txtShTk_6
    End Sub
    Sub Initializelbkh()
        Me.lbkh(0) = _lbkh_0
        Me.lbkh(2) = _lbkh_2
    End Sub
    Sub Initializelb()
        Me.lb(0) = _lb_0
    End Sub
    Sub Initializecmdtk()
        Me.cmdtk(8) = _cmdtk_8
        Me.cmdtk(10) = _cmdtk_10
        Me.cmdtk(1) = _cmdtk_1
        Me.cmdtk(0) = _cmdtk_0
        Me.cmdtk(4) = _cmdtk_4
        Me.cmdtk(2) = _cmdtk_2
        Me.cmdtk(3) = _cmdtk_3
        Me.cmdtk(9) = _cmdtk_9
        Me.cmdtk(5) = _cmdtk_5
        Me.cmdtk(7) = _cmdtk_7
        Me.cmdtk(11) = _cmdtk_11
        Me.cmdtk(15) = _cmdtk_15
        Me.cmdtk(14) = _cmdtk_14
        'Me.cmdtk(6) = _cmdtk_6
    End Sub
    Sub Initializecmdkh()
        Me.cmdkh(0) = _cmdkh_0
        Me.cmdkh(2) = _cmdkh_2
    End Sub
    Sub Initializecmd()
        Me.cmd(0) = _cmd_0
    End Sub
    Sub InitializeOptVAT()
        Me.OptVAT(19) = _OptVAT_19
        Me.OptVAT(18) = _OptVAT_18
        Me.OptVAT(17) = _OptVAT_17
        Me.OptVAT(20) = _OptVAT_20
        Me.OptVAT(9) = _OptVAT_9
        Me.OptVAT(1) = _OptVAT_1
        Me.OptVAT(0) = _OptVAT_0
        Me.OptVAT(2) = _OptVAT_2
        Me.OptVAT(3) = _OptVAT_3
        Me.OptVAT(6) = _OptVAT_6
        Me.OptVAT(5) = _OptVAT_5
        Me.OptVAT(7) = _OptVAT_7
        Me.OptVAT(8) = _OptVAT_8
        Me.OptVAT(10) = _OptVAT_10
        Me.OptVAT(11) = _OptVAT_11
        Me.OptVAT(4) = _OptVAT_4
        Me.OptVAT(12) = _OptVAT_12
        Me.OptVAT(13) = _OptVAT_13
        Me.OptVAT(15) = _OptVAT_15
        Me.OptVAT(14) = _OptVAT_14
        Me.OptVAT(16) = _OptVAT_16
    End Sub
    Sub InitializeOptTG()
        Me.OptTG(0) = _OptTG_0
        Me.OptTG(1) = _OptTG_1
    End Sub
    Sub InitializeOptSo()
        Me.OptSo(34) = _OptSo_34
        Me.OptSo(35) = _OptSo_35
        Me.OptSo(15) = _OptSo_15
        Me.OptSo(33) = _OptSo_33
        Me.OptSo(31) = _OptSo_31
        Me.OptSo(30) = _OptSo_30
        Me.OptSo(29) = _OptSo_29
        Me.OptSo(21) = _OptSo_21
        Me.OptSo(20) = _OptSo_20
        Me.OptSo(19) = _OptSo_19
        Me.OptSo(16) = _OptSo_16
        Me.OptSo(14) = _OptSo_14
        Me.OptSo(13) = _OptSo_13
        Me.OptSo(12) = _OptSo_12
        Me.OptSo(9) = _OptSo_9
        Me.OptSo(7) = _OptSo_7
        Me.OptSo(5) = _OptSo_5
        Me.OptSo(4) = _OptSo_4
        Me.OptSo(3) = _OptSo_3
        Me.OptSo(2) = _OptSo_2
        Me.OptSo(1) = _OptSo_1
        Me.OptSo(0) = _OptSo_0
        Me.OptSo(6) = _OptSo_6
        Me.OptSo(8) = _OptSo_8
        Me.OptSo(11) = _OptSo_11
    End Sub
    Sub InitializeOptQT()
        Me.OptQT(7) = _OptQT_7
        Me.OptQT(23) = _OptQT_23
        Me.OptQT(8) = _OptQT_8
        Me.OptQT(19) = _OptQT_19
        Me.OptQT(22) = _OptQT_22
        Me.OptQT(21) = _OptQT_21
        Me.OptQT(16) = _OptQT_16
        Me.OptQT(18) = _OptQT_18
        Me.OptQT(17) = _OptQT_17
        Me.OptQT(20) = _OptQT_20
        Me.OptQT(15) = _OptQT_15
        Me.OptQT(4) = _OptQT_4
        Me.OptQT(5) = _OptQT_5
        Me.OptQT(6) = _OptQT_6
        Me.OptQT(0) = _OptQT_0
        Me.OptQT(3) = _OptQT_3
        Me.OptQT(2) = _OptQT_2
        Me.OptQT(1) = _OptQT_1
        Me.OptQT(9) = _OptQT_9
        Me.OptQT(14) = _OptQT_14
        Me.OptQT(13) = _OptQT_13
        Me.OptQT(11) = _OptQT_11
        Me.OptQT(10) = _OptQT_10
        Me.OptQT(12) = _OptQT_12
    End Sub
    Sub InitializeOptKho()
        Me.OptKho(1) = _OptKho_1
        Me.OptKho(0) = _OptKho_0
    End Sub
    Sub InitializeOptInso()
        'Me.OptInso(7) = _OptInso_7
        'Me.OptInso(6) = _OptInso_6
        'Me.OptInso(0) = _OptInso_0
        'Me.OptInso(1) = _OptInso_1
        'Me.OptInso(2) = _OptInso_2
        'Me.OptInso(3) = _OptInso_3
        'Me.OptInso(4) = _OptInso_4
        'Me.OptInso(5) = _OptInso_5
    End Sub
    Sub InitializeOptDT()
        Me.OptDT(2) = _OptDT_2
        Me.OptDT(0) = _OptDT_0
        Me.OptDT(1) = _OptDT_1
    End Sub
    Sub InitializeOptCDT()
        Me.OptCDT(15) = _OptCDT_15
        Me.OptCDT(14) = _OptCDT_14
        Me.OptCDT(13) = _OptCDT_13
        Me.OptCDT(12) = _OptCDT_12
        Me.OptCDT(11) = _OptCDT_11
        Me.OptCDT(10) = _OptCDT_10
        Me.OptCDT(9) = _OptCDT_9
        Me.OptCDT(8) = _OptCDT_8
        Me.OptCDT(7) = _OptCDT_7
        Me.OptCDT(6) = _OptCDT_6
        Me.OptCDT(5) = _OptCDT_5
        Me.OptCDT(4) = _OptCDT_4
        Me.OptCDT(3) = _OptCDT_3
        Me.OptCDT(2) = _OptCDT_2
        Me.OptCDT(1) = _OptCDT_1
        Me.OptCDT(0) = _OptCDT_0
    End Sub
    Sub InitializeOptBCQT()
        Me.OptBCQT(0) = _OptBCQT_0
        Me.OptBCQT(1) = _OptBCQT_1
        Me.OptBCQT(2) = _OptBCQT_2
        Me.OptBCQT(12) = _OptBCQT_12
        Me.OptBCQT(3) = _OptBCQT_3
        Me.OptBCQT(4) = _OptBCQT_4
        Me.OptBCQT(5) = _OptBCQT_5
        Me.OptBCQT(6) = _OptBCQT_6
        Me.OptBCQT(7) = _OptBCQT_7
        Me.OptBCQT(8) = _OptBCQT_8
        Me.OptBCQT(9) = _OptBCQT_9
        Me.OptBCQT(10) = _OptBCQT_10
        Me.OptBCQT(11) = _OptBCQT_11
        Me.OptBCQT(13) = _OptBCQT_13
        Me.OptBCQT(14) = _OptBCQT_14
        Me.OptBCQT(15) = _OptBCQT_15
        Me.OptBCQT(16) = _OptBCQT_16
        Me.OptBCQT(17) = _OptBCQT_17
        Me.OptBCQT(18) = _OptBCQT_18
        Me.OptBCQT(19) = _OptBCQT_19
    End Sub
    Sub InitializeMedNgay()
        Me.MedNgay(0) = _MedNgay_0
        Me.MedNgay(1) = _MedNgay_1
    End Sub
    Sub InitializeLine1()
        Me.Line1(1) = _Line1_1
        Me.Line1(0) = _Line1_0
    End Sub
    Sub InitializeLbTenVT()
        Me.LbTenVT(2) = _LbTenVT_2
        Me.LbTenVT(1) = _LbTenVT_1
        Me.LbTenVT(0) = _LbTenVT_0
    End Sub
    Sub InitializeLbTenTk()
        Me.LbTenTk(8) = _LbTenTk_8
        Me.LbTenTk(3) = _LbTenTk_3
        Me.LbTenTk(2) = _LbTenTk_2
        Me.LbTenTk(4) = _LbTenTk_4
        Me.LbTenTk(10) = _LbTenTk_10
        Me.LbTenTk(0) = _LbTenTk_0
        Me.LbTenTk(1) = _LbTenTk_1
        Me.LbTenTk(9) = _LbTenTk_9
        Me.LbTenTk(5) = _LbTenTk_5
        Me.LbTenTk(14) = _LbTenTk_14
        Me.LbTenTk(11) = _LbTenTk_11
        Me.LbTenTk(15) = _LbTenTk_15
        Me.LbTenTk(7) = _LbTenTk_7
        'Me.LbTenTk(6) = _LbTenTk_6
    End Sub
    Sub InitializeLabel()
        Me.Label(7) = _Label_7
        Me.Label(8) = _Label_8
        Me.Label(1) = _Label_1
        Me.Label(0) = _Label_0
        Me.Label(4) = _Label_4
        Me.Label(5) = _Label_5
        Me.Label(3) = _Label_3
        Me.Label(2) = _Label_2
        'Me.Label(6) = _Label_6
    End Sub
    Sub InitializeFrame4()
        Me.Frame4(0) = _Frame4_0
    End Sub
    Sub InitializeFrame2()
        Me.Frame2(5) = _Frame2_5
        Me.Frame2(3) = _Frame2_3
        Me.Frame2(2) = _Frame2_2
        Me.Frame2(4) = _Frame2_4
        Me.Frame2(0) = _Frame2_0
        Me.Frame2(1) = _Frame2_1
    End Sub
    Sub InitializeFrame10()
        Me.Frame10(4) = _Frame10_4
        Me.Frame10(3) = _Frame10_3
        Me.Frame10(2) = _Frame10_2
        Me.Frame10(1) = _Frame10_1
        Me.Frame10(0) = _Frame10_0
        'Me.Frame10(6) = _Frame10_6
    End Sub
    Sub InitializeFrame()
        Me.Frame(0) = _Frame_0
        Me.Frame(1) = _Frame_1
    End Sub
    Sub InitializeCommand()
        Me.Command(3) = _Command_3
        Me.Command(2) = _Command_2
        Me.Command(1) = _Command_1
        Me.Command(0) = _Command_0
        Me.Command(4) = _Command_4
    End Sub
    Sub InitializeCmdvt()
        Me.Cmdvt(2) = _Cmdvt_2
        Me.Cmdvt(0) = _Cmdvt_0
        Me.Cmdvt(1) = _Cmdvt_1
    End Sub
    Sub InitializeCmd1()
        Me.Cmd1(0) = _Cmd1_0
        Me.Cmd1(1) = _Cmd1_1
        Me.Cmd1(2) = _Cmd1_2
        Me.Cmd1(3) = _Cmd1_3
        Me.Cmd1(4) = _Cmd1_4
    End Sub
    Sub InitializeChkDu()
        Me.ChkDu(16) = _ChkDu_16
        Me.ChkDu(11) = _ChkDu_11
        Me.ChkDu(8) = _ChkDu_8
        Me.ChkDu(5) = _ChkDu_5
        Me.ChkDu(4) = _ChkDu_4
        Me.ChkDu(7) = _ChkDu_7
        Me.ChkDu(0) = _ChkDu_0
        Me.ChkDu(3) = _ChkDu_3
        Me.ChkDu(1) = _ChkDu_1
        Me.ChkDu(2) = _ChkDu_2
        Me.ChkDu(6) = _ChkDu_6
        Me.ChkDu(10) = _ChkDu_10
        Me.ChkDu(13) = _ChkDu_13
        Me.ChkDu(18) = _ChkDu_18
        Me.ChkDu(9) = _ChkDu_9
        Me.ChkDu(19) = _ChkDu_19
        Me.ChkDu(17) = _ChkDu_17
        Me.ChkDu(12) = _ChkDu_12
        Me.ChkDu(20) = _ChkDu_20
        Me.ChkDu(14) = _ChkDu_14
        Me.ChkDu(15) = _ChkDu_15
    End Sub
    Sub InitializeChk()
        Me.Chk(7) = _Chk_7
        Me.Chk(1) = _Chk_1
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
        Me.CboKho(2) = _CboKho_2
        Me.CboKho(1) = _CboKho_1
    End Sub
    Private WithEvents _cmd_0 As System.Windows.Forms.Button
    Private WithEvents _cmdkh_2 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Accounting As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Investoes_reports As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Tax_Report As System.Windows.Forms.TabPage
    Friend WithEvents Tab_VAT_Reports As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Management_Reports As System.Windows.Forms.TabPage
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
#End Region
End Class
