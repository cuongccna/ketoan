<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQTTNDN
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		Initializechk()
		InitializeTxt()
		InitializeTL()
		InitializeNgay()
		InitializeLine()
		InitializeLabel0()
		InitializeLB()
		InitializeFrame()
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
	Public WithEvents Nghe As System.Windows.Forms.TextBox
	Public WithEvents MST As System.Windows.Forms.TextBox
	Private WithEvents _Txt_19 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_18 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_17 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_16 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_15 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_14 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_13 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_12 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_11 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_10 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_9 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_8 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_7 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_6 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_5 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_4 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_3 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_2 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_1 As System.Windows.Forms.TextBox
	Private WithEvents _chk_0 As System.Windows.Forms.CheckBox
	Private WithEvents _Txt_0 As System.Windows.Forms.TextBox
	Public WithEvents KY As System.Windows.Forms.TextBox
	Public WithEvents CTY As System.Windows.Forms.TextBox
	Private WithEvents _Label0_159 As System.Windows.Forms.Label
	Private WithEvents _Line_29 As System.Windows.Forms.Label
	Private WithEvents _Line_28 As System.Windows.Forms.Label
	Private WithEvents _Line_27 As System.Windows.Forms.Label
	Private WithEvents _Line_26 As System.Windows.Forms.Label
	Private WithEvents _Line_25 As System.Windows.Forms.Label
	Private WithEvents _Line_24 As System.Windows.Forms.Label
	Private WithEvents _Line_23 As System.Windows.Forms.Label
	Private WithEvents _Line_22 As System.Windows.Forms.Label
	Private WithEvents _Line_21 As System.Windows.Forms.Label
	Private WithEvents _Line_20 As System.Windows.Forms.Label
	Private WithEvents _Line_19 As System.Windows.Forms.Label
	Private WithEvents _Line_18 As System.Windows.Forms.Label
	Private WithEvents _Line_17 As System.Windows.Forms.Label
	Private WithEvents _Line_16 As System.Windows.Forms.Label
	Private WithEvents _Line_15 As System.Windows.Forms.Label
	Private WithEvents _Line_14 As System.Windows.Forms.Label
	Private WithEvents _Line_13 As System.Windows.Forms.Label
	Private WithEvents _Line_12 As System.Windows.Forms.Label
	Private WithEvents _Line_11 As System.Windows.Forms.Label
	Private WithEvents _Line_10 As System.Windows.Forms.Label
	Private WithEvents _Line_9 As System.Windows.Forms.Label
	Private WithEvents _Line_8 As System.Windows.Forms.Label
	Private WithEvents _Line_7 As System.Windows.Forms.Label
	Private WithEvents _Line_6 As System.Windows.Forms.Label
	Private WithEvents _Line_5 As System.Windows.Forms.Label
	Private WithEvents _Line_4 As System.Windows.Forms.Label
	Private WithEvents _Line_3 As System.Windows.Forms.Label
	Private WithEvents _Line_2 As System.Windows.Forms.Label
	Private WithEvents _Line_1 As System.Windows.Forms.Label
	Private WithEvents _Line_0 As System.Windows.Forms.Label
	Private WithEvents _Label0_58 As System.Windows.Forms.Label
	Private WithEvents _Label0_57 As System.Windows.Forms.Label
	Private WithEvents _Label0_56 As System.Windows.Forms.Label
	Private WithEvents _Label0_55 As System.Windows.Forms.Label
	Private WithEvents _Label0_54 As System.Windows.Forms.Label
	Private WithEvents _Label0_53 As System.Windows.Forms.Label
	Private WithEvents _Label0_48 As System.Windows.Forms.Label
	Private WithEvents _Label0_47 As System.Windows.Forms.Label
	Private WithEvents _Label0_46 As System.Windows.Forms.Label
	Private WithEvents _Label0_45 As System.Windows.Forms.Label
	Private WithEvents _Label0_44 As System.Windows.Forms.Label
	Private WithEvents _Label0_43 As System.Windows.Forms.Label
	Private WithEvents _Label0_42 As System.Windows.Forms.Label
	Private WithEvents _Label0_41 As System.Windows.Forms.Label
    Private WithEvents _Label0_39 As System.Windows.Forms.Label
	Private WithEvents _Label0_38 As System.Windows.Forms.Label
	Private WithEvents _Label0_37 As System.Windows.Forms.Label
	Private WithEvents _Label0_36 As System.Windows.Forms.Label
	Private WithEvents _Label0_35 As System.Windows.Forms.Label
	Private WithEvents _Label0_34 As System.Windows.Forms.Label
	Private WithEvents _Label0_33 As System.Windows.Forms.Label
	Private WithEvents _Label0_32 As System.Windows.Forms.Label
	Private WithEvents _Label0_31 As System.Windows.Forms.Label
	Private WithEvents _Label0_30 As System.Windows.Forms.Label
	Private WithEvents _Label0_29 As System.Windows.Forms.Label
	Private WithEvents _Label0_28 As System.Windows.Forms.Label
	Private WithEvents _Label0_27 As System.Windows.Forms.Label
	Private WithEvents _Label0_26 As System.Windows.Forms.Label
	Private WithEvents _Label0_25 As System.Windows.Forms.Label
	Private WithEvents _Label0_24 As System.Windows.Forms.Label
	Private WithEvents _Label0_23 As System.Windows.Forms.Label
	Private WithEvents _Label0_0 As System.Windows.Forms.Label
	Private WithEvents _Label0_3 As System.Windows.Forms.Label
	Private WithEvents _Label0_4 As System.Windows.Forms.Label
	Private WithEvents _Label0_5 As System.Windows.Forms.Label
	Private WithEvents _Label0_6 As System.Windows.Forms.Label
	Private WithEvents _Label0_7 As System.Windows.Forms.Label
	Private WithEvents _Label0_8 As System.Windows.Forms.Label
	Private WithEvents _Label0_9 As System.Windows.Forms.Label
	Private WithEvents _Label0_10 As System.Windows.Forms.Label
	Private WithEvents _Label0_11 As System.Windows.Forms.Label
	Private WithEvents _Label0_12 As System.Windows.Forms.Label
	Private WithEvents _Label0_13 As System.Windows.Forms.Label
	Private WithEvents _Label0_14 As System.Windows.Forms.Label
	Private WithEvents _Label0_15 As System.Windows.Forms.Label
	Private WithEvents _Label0_16 As System.Windows.Forms.Label
	Private WithEvents _Label0_17 As System.Windows.Forms.Label
	Private WithEvents _Label0_18 As System.Windows.Forms.Label
	Private WithEvents _Label0_19 As System.Windows.Forms.Label
	Private WithEvents _Label0_20 As System.Windows.Forms.Label
	Private WithEvents _Label0_21 As System.Windows.Forms.Label
	Private WithEvents _Label0_22 As System.Windows.Forms.Label
	Private WithEvents _Label0_50 As System.Windows.Forms.Label
	Private WithEvents _Label0_49 As System.Windows.Forms.Label
	Private WithEvents _Label0_52 As System.Windows.Forms.Label
	Private WithEvents _Label0_51 As System.Windows.Forms.Label
	Private WithEvents _Label0_163 As System.Windows.Forms.Label
	Private WithEvents _Label0_162 As System.Windows.Forms.Label
	Private WithEvents _Label0_160 As System.Windows.Forms.Label
	Private WithEvents _Label0_158 As System.Windows.Forms.Label
	Private WithEvents _Label0_157 As System.Windows.Forms.Label
	Private WithEvents _Label0_156 As System.Windows.Forms.Label
	Private WithEvents _Label0_155 As System.Windows.Forms.Label
	Private WithEvents _Label0_154 As System.Windows.Forms.Label
	Private WithEvents _Label0_153 As System.Windows.Forms.Label
	Private WithEvents _Label0_152 As System.Windows.Forms.Label
	Private WithEvents _Label0_151 As System.Windows.Forms.Label
	Private WithEvents _Label0_150 As System.Windows.Forms.Label
	Private WithEvents _Label0_149 As System.Windows.Forms.Label
	Private WithEvents _Label0_148 As System.Windows.Forms.Label
	Private WithEvents _Label0_147 As System.Windows.Forms.Label
	Private WithEvents _Label0_146 As System.Windows.Forms.Label
	Private WithEvents _Label0_145 As System.Windows.Forms.Label
	Private WithEvents _Label0_144 As System.Windows.Forms.Label
	Private WithEvents _Label0_140 As System.Windows.Forms.Label
	Private WithEvents _Label0_120 As System.Windows.Forms.Label
	Private WithEvents _Label0_1 As System.Windows.Forms.Label
	Private WithEvents _Label0_2 As System.Windows.Forms.Label
	Private WithEvents _Frame_1 As System.Windows.Forms.Panel
	Private WithEvents _chk_6 As System.Windows.Forms.CheckBox
	Private WithEvents _chk_5 As System.Windows.Forms.CheckBox
	Private WithEvents _chk_4 As System.Windows.Forms.CheckBox
	Private WithEvents _chk_3 As System.Windows.Forms.CheckBox
	Private WithEvents _chk_2 As System.Windows.Forms.CheckBox
	Private WithEvents _Ngay_2 As System.Windows.Forms.TextBox
	Private WithEvents _Ngay_1 As System.Windows.Forms.TextBox
	Private WithEvents _Ngay_0 As System.Windows.Forms.TextBox
	Private WithEvents _TL_2 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_20 As System.Windows.Forms.TextBox
	Private WithEvents _TL_1 As System.Windows.Forms.TextBox
	Private WithEvents _TL_0 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_41 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_40 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_39 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_38 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_37 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_36 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_35 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_34 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_33 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_32 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_31 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_30 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_29 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_28 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_27 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_26 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_25 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_24 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_23 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_22 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_21 As System.Windows.Forms.TextBox
	Private WithEvents _chk_1 As System.Windows.Forms.CheckBox
	Private WithEvents _Line_52 As System.Windows.Forms.Label
	Private WithEvents _Line_30 As System.Windows.Forms.Label
	Private WithEvents _Line_65 As System.Windows.Forms.Label
	Public WithEvents Line1 As System.Windows.Forms.Label
	Private WithEvents _Line_64 As System.Windows.Forms.Label
	Private WithEvents _Line_63 As System.Windows.Forms.Label
	Private WithEvents _Line_62 As System.Windows.Forms.Label
	Private WithEvents _Line_61 As System.Windows.Forms.Label
	Private WithEvents _Line_60 As System.Windows.Forms.Label
	Private WithEvents _Label0_119 As System.Windows.Forms.Label
	Private WithEvents _Line_59 As System.Windows.Forms.Label
	Private WithEvents _Line_58 As System.Windows.Forms.Label
	Private WithEvents _Line_57 As System.Windows.Forms.Label
	Private WithEvents _Line_56 As System.Windows.Forms.Label
	Private WithEvents _Line_55 As System.Windows.Forms.Label
	Private WithEvents _Line_54 As System.Windows.Forms.Label
	Private WithEvents _Line_53 As System.Windows.Forms.Label
	Private WithEvents _Line_51 As System.Windows.Forms.Label
	Private WithEvents _Line_50 As System.Windows.Forms.Label
	Private WithEvents _Line_49 As System.Windows.Forms.Label
	Private WithEvents _Line_48 As System.Windows.Forms.Label
	Private WithEvents _Line_47 As System.Windows.Forms.Label
	Private WithEvents _Line_46 As System.Windows.Forms.Label
	Private WithEvents _Line_45 As System.Windows.Forms.Label
	Private WithEvents _Line_44 As System.Windows.Forms.Label
	Private WithEvents _Line_43 As System.Windows.Forms.Label
	Private WithEvents _Line_42 As System.Windows.Forms.Label
	Private WithEvents _Line_41 As System.Windows.Forms.Label
	Private WithEvents _Line_40 As System.Windows.Forms.Label
	Private WithEvents _Line_39 As System.Windows.Forms.Label
	Private WithEvents _Line_38 As System.Windows.Forms.Label
	Private WithEvents _Line_37 As System.Windows.Forms.Label
	Private WithEvents _Line_36 As System.Windows.Forms.Label
	Private WithEvents _Line_35 As System.Windows.Forms.Label
	Private WithEvents _Line_34 As System.Windows.Forms.Label
	Private WithEvents _Line_33 As System.Windows.Forms.Label
	Private WithEvents _Line_32 As System.Windows.Forms.Label
	Private WithEvents _Line_31 As System.Windows.Forms.Label
	Private WithEvents _Label0_118 As System.Windows.Forms.Label
	Private WithEvents _Label0_112 As System.Windows.Forms.Label
	Private WithEvents _Label0_111 As System.Windows.Forms.Label
	Private WithEvents _Label0_110 As System.Windows.Forms.Label
	Private WithEvents _Label0_109 As System.Windows.Forms.Label
	Private WithEvents _Label0_108 As System.Windows.Forms.Label
	Private WithEvents _Label0_107 As System.Windows.Forms.Label
	Private WithEvents _Label0_106 As System.Windows.Forms.Label
	Private WithEvents _Label0_105 As System.Windows.Forms.Label
	Private WithEvents _Label0_97 As System.Windows.Forms.Label
	Private WithEvents _Label0_96 As System.Windows.Forms.Label
	Private WithEvents _Label0_95 As System.Windows.Forms.Label
	Private WithEvents _Label0_94 As System.Windows.Forms.Label
	Private WithEvents _Label0_93 As System.Windows.Forms.Label
	Private WithEvents _Label0_92 As System.Windows.Forms.Label
	Private WithEvents _Label0_91 As System.Windows.Forms.Label
	Private WithEvents _Label0_115 As System.Windows.Forms.Label
	Private WithEvents _Label0_114 As System.Windows.Forms.Label
	Private WithEvents _Label0_113 As System.Windows.Forms.Label
	Private WithEvents _Label0_104 As System.Windows.Forms.Label
	Private WithEvents _Label0_103 As System.Windows.Forms.Label
	Private WithEvents _Label0_102 As System.Windows.Forms.Label
	Private WithEvents _Label0_101 As System.Windows.Forms.Label
	Private WithEvents _Label0_99 As System.Windows.Forms.Label
	Private WithEvents _Label0_98 As System.Windows.Forms.Label
	Private WithEvents _Label0_90 As System.Windows.Forms.Label
	Private WithEvents _Label0_89 As System.Windows.Forms.Label
	Private WithEvents _Label0_88 As System.Windows.Forms.Label
	Private WithEvents _Label0_87 As System.Windows.Forms.Label
	Private WithEvents _Label0_86 As System.Windows.Forms.Label
	Private WithEvents _Label0_85 As System.Windows.Forms.Label
	Private WithEvents _Label0_84 As System.Windows.Forms.Label
	Private WithEvents _Label0_83 As System.Windows.Forms.Label
	Private WithEvents _Label0_82 As System.Windows.Forms.Label
	Private WithEvents _Label0_81 As System.Windows.Forms.Label
	Private WithEvents _Label0_80 As System.Windows.Forms.Label
	Private WithEvents _Label0_79 As System.Windows.Forms.Label
	Private WithEvents _Label0_78 As System.Windows.Forms.Label
	Private WithEvents _Label0_77 As System.Windows.Forms.Label
	Private WithEvents _Label0_76 As System.Windows.Forms.Label
	Private WithEvents _Label0_75 As System.Windows.Forms.Label
	Private WithEvents _Label0_74 As System.Windows.Forms.Label
	Private WithEvents _Label0_73 As System.Windows.Forms.Label
	Private WithEvents _Label0_72 As System.Windows.Forms.Label
	Private WithEvents _Label0_71 As System.Windows.Forms.Label
	Private WithEvents _Label0_70 As System.Windows.Forms.Label
	Private WithEvents _Label0_69 As System.Windows.Forms.Label
	Private WithEvents _Label0_68 As System.Windows.Forms.Label
	Private WithEvents _Label0_67 As System.Windows.Forms.Label
	Private WithEvents _Label0_66 As System.Windows.Forms.Label
	Private WithEvents _Label0_65 As System.Windows.Forms.Label
	Private WithEvents _Label0_64 As System.Windows.Forms.Label
	Private WithEvents _Label0_63 As System.Windows.Forms.Label
	Private WithEvents _Label0_62 As System.Windows.Forms.Label
	Private WithEvents _Label0_61 As System.Windows.Forms.Label
	Private WithEvents _Label0_60 As System.Windows.Forms.Label
	Private WithEvents _Label0_59 As System.Windows.Forms.Label
	Private WithEvents _Label0_116 As System.Windows.Forms.Label
	Private WithEvents _Label0_117 As System.Windows.Forms.Label
	Private WithEvents _Label0_100 As System.Windows.Forms.Label
	Private WithEvents _Label0_143 As System.Windows.Forms.Label
	Private WithEvents _Label0_142 As System.Windows.Forms.Label
	Private WithEvents _Label0_141 As System.Windows.Forms.Label
	Private WithEvents _Label0_139 As System.Windows.Forms.Label
	Private WithEvents _Label0_138 As System.Windows.Forms.Label
	Private WithEvents _Label0_137 As System.Windows.Forms.Label
	Private WithEvents _Label0_136 As System.Windows.Forms.Label
	Private WithEvents _Label0_135 As System.Windows.Forms.Label
	Private WithEvents _Label0_134 As System.Windows.Forms.Label
	Private WithEvents _Label0_133 As System.Windows.Forms.Label
	Private WithEvents _Label0_132 As System.Windows.Forms.Label
	Private WithEvents _Label0_131 As System.Windows.Forms.Label
	Private WithEvents _Label0_130 As System.Windows.Forms.Label
	Private WithEvents _Label0_129 As System.Windows.Forms.Label
	Private WithEvents _Label0_128 As System.Windows.Forms.Label
	Private WithEvents _Label0_127 As System.Windows.Forms.Label
	Private WithEvents _Label0_126 As System.Windows.Forms.Label
	Private WithEvents _Label0_125 As System.Windows.Forms.Label
	Private WithEvents _Label0_124 As System.Windows.Forms.Label
	Private WithEvents _Label0_123 As System.Windows.Forms.Label
	Private WithEvents _Label0_122 As System.Windows.Forms.Label
	Private WithEvents _Label0_121 As System.Windows.Forms.Label
	Private WithEvents _Frame_2 As System.Windows.Forms.Panel
    Private WithEvents _Command_5 As System.Windows.Forms.Button
    Private WithEvents _Command_6 As System.Windows.Forms.Button
    Private WithEvents _Command_4 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _LB_0 As System.Windows.Forms.Label
    Private WithEvents _LB_1 As System.Windows.Forms.Label
    Private WithEvents _LB_2 As System.Windows.Forms.Label
    Public Command(6) As System.Windows.Forms.Button
    Public Frame(2) As System.Windows.Forms.Panel
    Public LB(2) As System.Windows.Forms.Label
    Public Label0(163) As System.Windows.Forms.Label
    Public Line(65) As System.Windows.Forms.Label
    Public Ngay(2) As System.Windows.Forms.TextBox
    Public TL(2) As System.Windows.Forms.TextBox
    Public Txt(41) As System.Windows.Forms.TextBox
    Public chk(6) As System.Windows.Forms.CheckBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmQTTNDN))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Frame_1 = New System.Windows.Forms.Panel()
        Me._Label0_40 = New System.Windows.Forms.Label()
        Me.Nghe = New System.Windows.Forms.TextBox()
        Me.MST = New System.Windows.Forms.TextBox()
        Me._Txt_19 = New System.Windows.Forms.TextBox()
        Me._Txt_18 = New System.Windows.Forms.TextBox()
        Me._Txt_17 = New System.Windows.Forms.TextBox()
        Me._Txt_16 = New System.Windows.Forms.TextBox()
        Me._Txt_15 = New System.Windows.Forms.TextBox()
        Me._Txt_14 = New System.Windows.Forms.TextBox()
        Me._Txt_13 = New System.Windows.Forms.TextBox()
        Me._Txt_12 = New System.Windows.Forms.TextBox()
        Me._Txt_11 = New System.Windows.Forms.TextBox()
        Me._Txt_10 = New System.Windows.Forms.TextBox()
        Me._Txt_9 = New System.Windows.Forms.TextBox()
        Me._Txt_8 = New System.Windows.Forms.TextBox()
        Me._Txt_7 = New System.Windows.Forms.TextBox()
        Me._Txt_6 = New System.Windows.Forms.TextBox()
        Me._Txt_5 = New System.Windows.Forms.TextBox()
        Me._Txt_4 = New System.Windows.Forms.TextBox()
        Me._Txt_3 = New System.Windows.Forms.TextBox()
        Me._Txt_2 = New System.Windows.Forms.TextBox()
        Me._Txt_1 = New System.Windows.Forms.TextBox()
        Me._chk_0 = New System.Windows.Forms.CheckBox()
        Me._Txt_0 = New System.Windows.Forms.TextBox()
        Me.KY = New System.Windows.Forms.TextBox()
        Me.CTY = New System.Windows.Forms.TextBox()
        Me._Label0_159 = New System.Windows.Forms.Label()
        Me._Line_29 = New System.Windows.Forms.Label()
        Me._Line_28 = New System.Windows.Forms.Label()
        Me._Line_27 = New System.Windows.Forms.Label()
        Me._Line_26 = New System.Windows.Forms.Label()
        Me._Line_25 = New System.Windows.Forms.Label()
        Me._Line_24 = New System.Windows.Forms.Label()
        Me._Line_23 = New System.Windows.Forms.Label()
        Me._Line_22 = New System.Windows.Forms.Label()
        Me._Line_21 = New System.Windows.Forms.Label()
        Me._Line_20 = New System.Windows.Forms.Label()
        Me._Line_19 = New System.Windows.Forms.Label()
        Me._Line_18 = New System.Windows.Forms.Label()
        Me._Line_17 = New System.Windows.Forms.Label()
        Me._Line_16 = New System.Windows.Forms.Label()
        Me._Line_15 = New System.Windows.Forms.Label()
        Me._Line_14 = New System.Windows.Forms.Label()
        Me._Line_13 = New System.Windows.Forms.Label()
        Me._Line_12 = New System.Windows.Forms.Label()
        Me._Line_11 = New System.Windows.Forms.Label()
        Me._Line_10 = New System.Windows.Forms.Label()
        Me._Line_9 = New System.Windows.Forms.Label()
        Me._Line_8 = New System.Windows.Forms.Label()
        Me._Line_7 = New System.Windows.Forms.Label()
        Me._Line_6 = New System.Windows.Forms.Label()
        Me._Line_5 = New System.Windows.Forms.Label()
        Me._Line_4 = New System.Windows.Forms.Label()
        Me._Line_3 = New System.Windows.Forms.Label()
        Me._Line_2 = New System.Windows.Forms.Label()
        Me._Line_1 = New System.Windows.Forms.Label()
        Me._Line_0 = New System.Windows.Forms.Label()
        Me._Label0_58 = New System.Windows.Forms.Label()
        Me._Label0_57 = New System.Windows.Forms.Label()
        Me._Label0_56 = New System.Windows.Forms.Label()
        Me._Label0_55 = New System.Windows.Forms.Label()
        Me._Label0_54 = New System.Windows.Forms.Label()
        Me._Label0_53 = New System.Windows.Forms.Label()
        Me._Label0_48 = New System.Windows.Forms.Label()
        Me._Label0_47 = New System.Windows.Forms.Label()
        Me._Label0_46 = New System.Windows.Forms.Label()
        Me._Label0_45 = New System.Windows.Forms.Label()
        Me._Label0_44 = New System.Windows.Forms.Label()
        Me._Label0_43 = New System.Windows.Forms.Label()
        Me._Label0_42 = New System.Windows.Forms.Label()
        Me._Label0_41 = New System.Windows.Forms.Label()
        Me._Label0_39 = New System.Windows.Forms.Label()
        Me._Label0_38 = New System.Windows.Forms.Label()
        Me._Label0_37 = New System.Windows.Forms.Label()
        Me._Label0_36 = New System.Windows.Forms.Label()
        Me._Label0_35 = New System.Windows.Forms.Label()
        Me._Label0_34 = New System.Windows.Forms.Label()
        Me._Label0_33 = New System.Windows.Forms.Label()
        Me._Label0_32 = New System.Windows.Forms.Label()
        Me._Label0_31 = New System.Windows.Forms.Label()
        Me._Label0_30 = New System.Windows.Forms.Label()
        Me._Label0_29 = New System.Windows.Forms.Label()
        Me._Label0_28 = New System.Windows.Forms.Label()
        Me._Label0_27 = New System.Windows.Forms.Label()
        Me._Label0_26 = New System.Windows.Forms.Label()
        Me._Label0_25 = New System.Windows.Forms.Label()
        Me._Label0_24 = New System.Windows.Forms.Label()
        Me._Label0_23 = New System.Windows.Forms.Label()
        Me._Label0_0 = New System.Windows.Forms.Label()
        Me._Label0_3 = New System.Windows.Forms.Label()
        Me._Label0_4 = New System.Windows.Forms.Label()
        Me._Label0_5 = New System.Windows.Forms.Label()
        Me._Label0_6 = New System.Windows.Forms.Label()
        Me._Label0_7 = New System.Windows.Forms.Label()
        Me._Label0_8 = New System.Windows.Forms.Label()
        Me._Label0_9 = New System.Windows.Forms.Label()
        Me._Label0_10 = New System.Windows.Forms.Label()
        Me._Label0_11 = New System.Windows.Forms.Label()
        Me._Label0_12 = New System.Windows.Forms.Label()
        Me._Label0_13 = New System.Windows.Forms.Label()
        Me._Label0_14 = New System.Windows.Forms.Label()
        Me._Label0_15 = New System.Windows.Forms.Label()
        Me._Label0_16 = New System.Windows.Forms.Label()
        Me._Label0_17 = New System.Windows.Forms.Label()
        Me._Label0_18 = New System.Windows.Forms.Label()
        Me._Label0_19 = New System.Windows.Forms.Label()
        Me._Label0_20 = New System.Windows.Forms.Label()
        Me._Label0_21 = New System.Windows.Forms.Label()
        Me._Label0_22 = New System.Windows.Forms.Label()
        Me._Label0_50 = New System.Windows.Forms.Label()
        Me._Label0_49 = New System.Windows.Forms.Label()
        Me._Label0_52 = New System.Windows.Forms.Label()
        Me._Label0_51 = New System.Windows.Forms.Label()
        Me._Label0_163 = New System.Windows.Forms.Label()
        Me._Label0_162 = New System.Windows.Forms.Label()
        Me._Label0_160 = New System.Windows.Forms.Label()
        Me._Label0_158 = New System.Windows.Forms.Label()
        Me._Label0_157 = New System.Windows.Forms.Label()
        Me._Label0_156 = New System.Windows.Forms.Label()
        Me._Label0_155 = New System.Windows.Forms.Label()
        Me._Label0_154 = New System.Windows.Forms.Label()
        Me._Label0_153 = New System.Windows.Forms.Label()
        Me._Label0_152 = New System.Windows.Forms.Label()
        Me._Label0_151 = New System.Windows.Forms.Label()
        Me._Label0_150 = New System.Windows.Forms.Label()
        Me._Label0_149 = New System.Windows.Forms.Label()
        Me._Label0_148 = New System.Windows.Forms.Label()
        Me._Label0_147 = New System.Windows.Forms.Label()
        Me._Label0_146 = New System.Windows.Forms.Label()
        Me._Label0_145 = New System.Windows.Forms.Label()
        Me._Label0_144 = New System.Windows.Forms.Label()
        Me._Label0_140 = New System.Windows.Forms.Label()
        Me._Label0_120 = New System.Windows.Forms.Label()
        Me._Label0_1 = New System.Windows.Forms.Label()
        Me._Label0_2 = New System.Windows.Forms.Label()
        Me._Frame_2 = New System.Windows.Forms.Panel()
        Me._chk_6 = New System.Windows.Forms.CheckBox()
        Me._chk_5 = New System.Windows.Forms.CheckBox()
        Me._chk_4 = New System.Windows.Forms.CheckBox()
        Me._chk_3 = New System.Windows.Forms.CheckBox()
        Me._chk_2 = New System.Windows.Forms.CheckBox()
        Me._Ngay_2 = New System.Windows.Forms.TextBox()
        Me._Ngay_1 = New System.Windows.Forms.TextBox()
        Me._Ngay_0 = New System.Windows.Forms.TextBox()
        Me._TL_2 = New System.Windows.Forms.TextBox()
        Me._Txt_20 = New System.Windows.Forms.TextBox()
        Me._TL_1 = New System.Windows.Forms.TextBox()
        Me._TL_0 = New System.Windows.Forms.TextBox()
        Me._Txt_41 = New System.Windows.Forms.TextBox()
        Me._Txt_40 = New System.Windows.Forms.TextBox()
        Me._Txt_39 = New System.Windows.Forms.TextBox()
        Me._Txt_38 = New System.Windows.Forms.TextBox()
        Me._Txt_37 = New System.Windows.Forms.TextBox()
        Me._Txt_36 = New System.Windows.Forms.TextBox()
        Me._Txt_35 = New System.Windows.Forms.TextBox()
        Me._Txt_34 = New System.Windows.Forms.TextBox()
        Me._Txt_33 = New System.Windows.Forms.TextBox()
        Me._Txt_32 = New System.Windows.Forms.TextBox()
        Me._Txt_31 = New System.Windows.Forms.TextBox()
        Me._Txt_30 = New System.Windows.Forms.TextBox()
        Me._Txt_29 = New System.Windows.Forms.TextBox()
        Me._Txt_28 = New System.Windows.Forms.TextBox()
        Me._Txt_27 = New System.Windows.Forms.TextBox()
        Me._Txt_26 = New System.Windows.Forms.TextBox()
        Me._Txt_25 = New System.Windows.Forms.TextBox()
        Me._Txt_24 = New System.Windows.Forms.TextBox()
        Me._Txt_23 = New System.Windows.Forms.TextBox()
        Me._Txt_22 = New System.Windows.Forms.TextBox()
        Me._Txt_21 = New System.Windows.Forms.TextBox()
        Me._chk_1 = New System.Windows.Forms.CheckBox()
        Me._Line_52 = New System.Windows.Forms.Label()
        Me._Line_30 = New System.Windows.Forms.Label()
        Me._Line_65 = New System.Windows.Forms.Label()
        Me.Line1 = New System.Windows.Forms.Label()
        Me._Line_64 = New System.Windows.Forms.Label()
        Me._Line_63 = New System.Windows.Forms.Label()
        Me._Line_62 = New System.Windows.Forms.Label()
        Me._Line_61 = New System.Windows.Forms.Label()
        Me._Line_60 = New System.Windows.Forms.Label()
        Me._Label0_119 = New System.Windows.Forms.Label()
        Me._Line_59 = New System.Windows.Forms.Label()
        Me._Line_58 = New System.Windows.Forms.Label()
        Me._Line_57 = New System.Windows.Forms.Label()
        Me._Line_56 = New System.Windows.Forms.Label()
        Me._Line_55 = New System.Windows.Forms.Label()
        Me._Line_54 = New System.Windows.Forms.Label()
        Me._Line_53 = New System.Windows.Forms.Label()
        Me._Line_51 = New System.Windows.Forms.Label()
        Me._Line_50 = New System.Windows.Forms.Label()
        Me._Line_49 = New System.Windows.Forms.Label()
        Me._Line_48 = New System.Windows.Forms.Label()
        Me._Line_47 = New System.Windows.Forms.Label()
        Me._Line_46 = New System.Windows.Forms.Label()
        Me._Line_45 = New System.Windows.Forms.Label()
        Me._Line_44 = New System.Windows.Forms.Label()
        Me._Line_43 = New System.Windows.Forms.Label()
        Me._Line_42 = New System.Windows.Forms.Label()
        Me._Line_41 = New System.Windows.Forms.Label()
        Me._Line_40 = New System.Windows.Forms.Label()
        Me._Line_39 = New System.Windows.Forms.Label()
        Me._Line_38 = New System.Windows.Forms.Label()
        Me._Line_37 = New System.Windows.Forms.Label()
        Me._Line_36 = New System.Windows.Forms.Label()
        Me._Line_35 = New System.Windows.Forms.Label()
        Me._Line_34 = New System.Windows.Forms.Label()
        Me._Line_33 = New System.Windows.Forms.Label()
        Me._Line_32 = New System.Windows.Forms.Label()
        Me._Line_31 = New System.Windows.Forms.Label()
        Me._Label0_118 = New System.Windows.Forms.Label()
        Me._Label0_112 = New System.Windows.Forms.Label()
        Me._Label0_111 = New System.Windows.Forms.Label()
        Me._Label0_110 = New System.Windows.Forms.Label()
        Me._Label0_109 = New System.Windows.Forms.Label()
        Me._Label0_108 = New System.Windows.Forms.Label()
        Me._Label0_107 = New System.Windows.Forms.Label()
        Me._Label0_106 = New System.Windows.Forms.Label()
        Me._Label0_105 = New System.Windows.Forms.Label()
        Me._Label0_97 = New System.Windows.Forms.Label()
        Me._Label0_96 = New System.Windows.Forms.Label()
        Me._Label0_95 = New System.Windows.Forms.Label()
        Me._Label0_94 = New System.Windows.Forms.Label()
        Me._Label0_93 = New System.Windows.Forms.Label()
        Me._Label0_92 = New System.Windows.Forms.Label()
        Me._Label0_91 = New System.Windows.Forms.Label()
        Me._Label0_115 = New System.Windows.Forms.Label()
        Me._Label0_114 = New System.Windows.Forms.Label()
        Me._Label0_113 = New System.Windows.Forms.Label()
        Me._Label0_104 = New System.Windows.Forms.Label()
        Me._Label0_103 = New System.Windows.Forms.Label()
        Me._Label0_102 = New System.Windows.Forms.Label()
        Me._Label0_101 = New System.Windows.Forms.Label()
        Me._Label0_99 = New System.Windows.Forms.Label()
        Me._Label0_98 = New System.Windows.Forms.Label()
        Me._Label0_90 = New System.Windows.Forms.Label()
        Me._Label0_89 = New System.Windows.Forms.Label()
        Me._Label0_88 = New System.Windows.Forms.Label()
        Me._Label0_87 = New System.Windows.Forms.Label()
        Me._Label0_86 = New System.Windows.Forms.Label()
        Me._Label0_85 = New System.Windows.Forms.Label()
        Me._Label0_84 = New System.Windows.Forms.Label()
        Me._Label0_83 = New System.Windows.Forms.Label()
        Me._Label0_82 = New System.Windows.Forms.Label()
        Me._Label0_81 = New System.Windows.Forms.Label()
        Me._Label0_80 = New System.Windows.Forms.Label()
        Me._Label0_79 = New System.Windows.Forms.Label()
        Me._Label0_78 = New System.Windows.Forms.Label()
        Me._Label0_77 = New System.Windows.Forms.Label()
        Me._Label0_76 = New System.Windows.Forms.Label()
        Me._Label0_75 = New System.Windows.Forms.Label()
        Me._Label0_74 = New System.Windows.Forms.Label()
        Me._Label0_73 = New System.Windows.Forms.Label()
        Me._Label0_72 = New System.Windows.Forms.Label()
        Me._Label0_71 = New System.Windows.Forms.Label()
        Me._Label0_70 = New System.Windows.Forms.Label()
        Me._Label0_69 = New System.Windows.Forms.Label()
        Me._Label0_68 = New System.Windows.Forms.Label()
        Me._Label0_67 = New System.Windows.Forms.Label()
        Me._Label0_66 = New System.Windows.Forms.Label()
        Me._Label0_65 = New System.Windows.Forms.Label()
        Me._Label0_64 = New System.Windows.Forms.Label()
        Me._Label0_63 = New System.Windows.Forms.Label()
        Me._Label0_62 = New System.Windows.Forms.Label()
        Me._Label0_61 = New System.Windows.Forms.Label()
        Me._Label0_60 = New System.Windows.Forms.Label()
        Me._Label0_59 = New System.Windows.Forms.Label()
        Me._Label0_116 = New System.Windows.Forms.Label()
        Me._Label0_117 = New System.Windows.Forms.Label()
        Me._Label0_100 = New System.Windows.Forms.Label()
        Me._Label0_143 = New System.Windows.Forms.Label()
        Me._Label0_142 = New System.Windows.Forms.Label()
        Me._Label0_141 = New System.Windows.Forms.Label()
        Me._Label0_139 = New System.Windows.Forms.Label()
        Me._Label0_138 = New System.Windows.Forms.Label()
        Me._Label0_137 = New System.Windows.Forms.Label()
        Me._Label0_136 = New System.Windows.Forms.Label()
        Me._Label0_135 = New System.Windows.Forms.Label()
        Me._Label0_134 = New System.Windows.Forms.Label()
        Me._Label0_133 = New System.Windows.Forms.Label()
        Me._Label0_132 = New System.Windows.Forms.Label()
        Me._Label0_131 = New System.Windows.Forms.Label()
        Me._Label0_130 = New System.Windows.Forms.Label()
        Me._Label0_129 = New System.Windows.Forms.Label()
        Me._Label0_128 = New System.Windows.Forms.Label()
        Me._Label0_127 = New System.Windows.Forms.Label()
        Me._Label0_126 = New System.Windows.Forms.Label()
        Me._Label0_125 = New System.Windows.Forms.Label()
        Me._Label0_124 = New System.Windows.Forms.Label()
        Me._Label0_123 = New System.Windows.Forms.Label()
        Me._Label0_122 = New System.Windows.Forms.Label()
        Me._Label0_121 = New System.Windows.Forms.Label()
        Me._Command_5 = New System.Windows.Forms.Button()
        Me._Command_6 = New System.Windows.Forms.Button()
        Me._Command_4 = New System.Windows.Forms.Button()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._Command_2 = New System.Windows.Forms.Button()
        Me._LB_0 = New System.Windows.Forms.Label()
        Me._LB_1 = New System.Windows.Forms.Label()
        Me._LB_2 = New System.Windows.Forms.Label()
        Me._Frame_1.SuspendLayout()
        Me._Frame_2.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Frame_1
        '
        Me._Frame_1.BackColor = System.Drawing.SystemColors.Window
        Me._Frame_1.Controls.Add(Me._Label0_40)
        Me._Frame_1.Controls.Add(Me.Nghe)
        Me._Frame_1.Controls.Add(Me.MST)
        Me._Frame_1.Controls.Add(Me._Txt_19)
        Me._Frame_1.Controls.Add(Me._Txt_18)
        Me._Frame_1.Controls.Add(Me._Txt_17)
        Me._Frame_1.Controls.Add(Me._Txt_16)
        Me._Frame_1.Controls.Add(Me._Txt_15)
        Me._Frame_1.Controls.Add(Me._Txt_14)
        Me._Frame_1.Controls.Add(Me._Txt_13)
        Me._Frame_1.Controls.Add(Me._Txt_12)
        Me._Frame_1.Controls.Add(Me._Txt_11)
        Me._Frame_1.Controls.Add(Me._Txt_10)
        Me._Frame_1.Controls.Add(Me._Txt_9)
        Me._Frame_1.Controls.Add(Me._Txt_8)
        Me._Frame_1.Controls.Add(Me._Txt_7)
        Me._Frame_1.Controls.Add(Me._Txt_6)
        Me._Frame_1.Controls.Add(Me._Txt_5)
        Me._Frame_1.Controls.Add(Me._Txt_4)
        Me._Frame_1.Controls.Add(Me._Txt_3)
        Me._Frame_1.Controls.Add(Me._Txt_2)
        Me._Frame_1.Controls.Add(Me._Txt_1)
        Me._Frame_1.Controls.Add(Me._chk_0)
        Me._Frame_1.Controls.Add(Me._Txt_0)
        Me._Frame_1.Controls.Add(Me.KY)
        Me._Frame_1.Controls.Add(Me.CTY)
        Me._Frame_1.Controls.Add(Me._Label0_159)
        Me._Frame_1.Controls.Add(Me._Line_29)
        Me._Frame_1.Controls.Add(Me._Line_28)
        Me._Frame_1.Controls.Add(Me._Line_27)
        Me._Frame_1.Controls.Add(Me._Line_26)
        Me._Frame_1.Controls.Add(Me._Line_25)
        Me._Frame_1.Controls.Add(Me._Line_24)
        Me._Frame_1.Controls.Add(Me._Line_23)
        Me._Frame_1.Controls.Add(Me._Line_22)
        Me._Frame_1.Controls.Add(Me._Line_21)
        Me._Frame_1.Controls.Add(Me._Line_20)
        Me._Frame_1.Controls.Add(Me._Line_19)
        Me._Frame_1.Controls.Add(Me._Line_18)
        Me._Frame_1.Controls.Add(Me._Line_17)
        Me._Frame_1.Controls.Add(Me._Line_16)
        Me._Frame_1.Controls.Add(Me._Line_15)
        Me._Frame_1.Controls.Add(Me._Line_14)
        Me._Frame_1.Controls.Add(Me._Line_13)
        Me._Frame_1.Controls.Add(Me._Line_12)
        Me._Frame_1.Controls.Add(Me._Line_11)
        Me._Frame_1.Controls.Add(Me._Line_10)
        Me._Frame_1.Controls.Add(Me._Line_9)
        Me._Frame_1.Controls.Add(Me._Line_8)
        Me._Frame_1.Controls.Add(Me._Line_7)
        Me._Frame_1.Controls.Add(Me._Line_6)
        Me._Frame_1.Controls.Add(Me._Line_5)
        Me._Frame_1.Controls.Add(Me._Line_4)
        Me._Frame_1.Controls.Add(Me._Line_3)
        Me._Frame_1.Controls.Add(Me._Line_2)
        Me._Frame_1.Controls.Add(Me._Line_1)
        Me._Frame_1.Controls.Add(Me._Line_0)
        Me._Frame_1.Controls.Add(Me._Label0_58)
        Me._Frame_1.Controls.Add(Me._Label0_57)
        Me._Frame_1.Controls.Add(Me._Label0_56)
        Me._Frame_1.Controls.Add(Me._Label0_55)
        Me._Frame_1.Controls.Add(Me._Label0_54)
        Me._Frame_1.Controls.Add(Me._Label0_53)
        Me._Frame_1.Controls.Add(Me._Label0_48)
        Me._Frame_1.Controls.Add(Me._Label0_47)
        Me._Frame_1.Controls.Add(Me._Label0_46)
        Me._Frame_1.Controls.Add(Me._Label0_45)
        Me._Frame_1.Controls.Add(Me._Label0_44)
        Me._Frame_1.Controls.Add(Me._Label0_43)
        Me._Frame_1.Controls.Add(Me._Label0_42)
        Me._Frame_1.Controls.Add(Me._Label0_41)
        Me._Frame_1.Controls.Add(Me._Label0_39)
        Me._Frame_1.Controls.Add(Me._Label0_38)
        Me._Frame_1.Controls.Add(Me._Label0_37)
        Me._Frame_1.Controls.Add(Me._Label0_36)
        Me._Frame_1.Controls.Add(Me._Label0_35)
        Me._Frame_1.Controls.Add(Me._Label0_34)
        Me._Frame_1.Controls.Add(Me._Label0_33)
        Me._Frame_1.Controls.Add(Me._Label0_32)
        Me._Frame_1.Controls.Add(Me._Label0_31)
        Me._Frame_1.Controls.Add(Me._Label0_30)
        Me._Frame_1.Controls.Add(Me._Label0_29)
        Me._Frame_1.Controls.Add(Me._Label0_28)
        Me._Frame_1.Controls.Add(Me._Label0_27)
        Me._Frame_1.Controls.Add(Me._Label0_26)
        Me._Frame_1.Controls.Add(Me._Label0_25)
        Me._Frame_1.Controls.Add(Me._Label0_24)
        Me._Frame_1.Controls.Add(Me._Label0_23)
        Me._Frame_1.Controls.Add(Me._Label0_0)
        Me._Frame_1.Controls.Add(Me._Label0_3)
        Me._Frame_1.Controls.Add(Me._Label0_4)
        Me._Frame_1.Controls.Add(Me._Label0_5)
        Me._Frame_1.Controls.Add(Me._Label0_6)
        Me._Frame_1.Controls.Add(Me._Label0_7)
        Me._Frame_1.Controls.Add(Me._Label0_8)
        Me._Frame_1.Controls.Add(Me._Label0_9)
        Me._Frame_1.Controls.Add(Me._Label0_10)
        Me._Frame_1.Controls.Add(Me._Label0_11)
        Me._Frame_1.Controls.Add(Me._Label0_12)
        Me._Frame_1.Controls.Add(Me._Label0_13)
        Me._Frame_1.Controls.Add(Me._Label0_14)
        Me._Frame_1.Controls.Add(Me._Label0_15)
        Me._Frame_1.Controls.Add(Me._Label0_16)
        Me._Frame_1.Controls.Add(Me._Label0_17)
        Me._Frame_1.Controls.Add(Me._Label0_18)
        Me._Frame_1.Controls.Add(Me._Label0_19)
        Me._Frame_1.Controls.Add(Me._Label0_20)
        Me._Frame_1.Controls.Add(Me._Label0_21)
        Me._Frame_1.Controls.Add(Me._Label0_22)
        Me._Frame_1.Controls.Add(Me._Label0_50)
        Me._Frame_1.Controls.Add(Me._Label0_49)
        Me._Frame_1.Controls.Add(Me._Label0_52)
        Me._Frame_1.Controls.Add(Me._Label0_51)
        Me._Frame_1.Controls.Add(Me._Label0_163)
        Me._Frame_1.Controls.Add(Me._Label0_162)
        Me._Frame_1.Controls.Add(Me._Label0_160)
        Me._Frame_1.Controls.Add(Me._Label0_158)
        Me._Frame_1.Controls.Add(Me._Label0_157)
        Me._Frame_1.Controls.Add(Me._Label0_156)
        Me._Frame_1.Controls.Add(Me._Label0_155)
        Me._Frame_1.Controls.Add(Me._Label0_154)
        Me._Frame_1.Controls.Add(Me._Label0_153)
        Me._Frame_1.Controls.Add(Me._Label0_152)
        Me._Frame_1.Controls.Add(Me._Label0_151)
        Me._Frame_1.Controls.Add(Me._Label0_150)
        Me._Frame_1.Controls.Add(Me._Label0_149)
        Me._Frame_1.Controls.Add(Me._Label0_148)
        Me._Frame_1.Controls.Add(Me._Label0_147)
        Me._Frame_1.Controls.Add(Me._Label0_146)
        Me._Frame_1.Controls.Add(Me._Label0_145)
        Me._Frame_1.Controls.Add(Me._Label0_144)
        Me._Frame_1.Controls.Add(Me._Label0_140)
        Me._Frame_1.Controls.Add(Me._Label0_120)
        Me._Frame_1.Controls.Add(Me._Label0_1)
        Me._Frame_1.Controls.Add(Me._Label0_2)
        Me._Frame_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Frame_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_1.Location = New System.Drawing.Point(15, 16)
        Me._Frame_1.Name = "_Frame_1"
        Me._Frame_1.Size = New System.Drawing.Size(554, 657)
        Me._Frame_1.TabIndex = 66
        '
        '_Label0_40
        '
        Me._Label0_40.BackColor = System.Drawing.Color.White
        Me._Label0_40.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_40.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_40.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_40.Location = New System.Drawing.Point(27, 368)
        Me._Label0_40.Name = "_Label0_40"
        Me._Label0_40.Size = New System.Drawing.Size(413, 86)
        Me._Label0_40.TabIndex = 263
        Me._Label0_40.Tag = resources.GetString("_Label0_40.Tag")
        Me._Label0_40.Text = resources.GetString("_Label0_40.Text")
        '
        'Nghe
        '
        Me.Nghe.AcceptsReturn = True
        Me.Nghe.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Nghe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nghe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Nghe.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nghe.Location = New System.Drawing.Point(107, 109)
        Me.Nghe.MaxLength = 100
        Me.Nghe.Name = "Nghe"
        Me.Nghe.Size = New System.Drawing.Size(445, 14)
        Me.Nghe.TabIndex = 3
        Me.Nghe.Text = "..."
        '
        'MST
        '
        Me.MST.AcceptsReturn = True
        Me.MST.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.MST.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MST.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MST.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MST.Location = New System.Drawing.Point(87, 94)
        Me.MST.MaxLength = 100
        Me.MST.Name = "MST"
        Me.MST.Size = New System.Drawing.Size(79, 14)
        Me.MST.TabIndex = 1
        Me.MST.Text = "..."
        '
        '_Txt_19
        '
        Me._Txt_19.AcceptsReturn = True
        Me._Txt_19.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_19.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_19.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_19.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_19.Location = New System.Drawing.Point(474, 641)
        Me._Txt_19.MaxLength = 100
        Me._Txt_19.Name = "_Txt_19"
        Me._Txt_19.Size = New System.Drawing.Size(80, 14)
        Me._Txt_19.TabIndex = 23
        Me._Txt_19.Text = "0"
        Me._Txt_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_18
        '
        Me._Txt_18.AcceptsReturn = True
        Me._Txt_18.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_18.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_18.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_18.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_18.Location = New System.Drawing.Point(474, 625)
        Me._Txt_18.MaxLength = 100
        Me._Txt_18.Name = "_Txt_18"
        Me._Txt_18.Size = New System.Drawing.Size(80, 14)
        Me._Txt_18.TabIndex = 22
        Me._Txt_18.Text = "0"
        Me._Txt_18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_17
        '
        Me._Txt_17.AcceptsReturn = True
        Me._Txt_17.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_17.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_17.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_17.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_17.Location = New System.Drawing.Point(474, 585)
        Me._Txt_17.MaxLength = 100
        Me._Txt_17.Name = "_Txt_17"
        Me._Txt_17.Size = New System.Drawing.Size(80, 14)
        Me._Txt_17.TabIndex = 21
        Me._Txt_17.Text = "0"
        Me._Txt_17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_16
        '
        Me._Txt_16.AcceptsReturn = True
        Me._Txt_16.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_16.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_16.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_16.Location = New System.Drawing.Point(474, 569)
        Me._Txt_16.MaxLength = 100
        Me._Txt_16.Name = "_Txt_16"
        Me._Txt_16.Size = New System.Drawing.Size(80, 14)
        Me._Txt_16.TabIndex = 20
        Me._Txt_16.Text = "0"
        Me._Txt_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_15
        '
        Me._Txt_15.AcceptsReturn = True
        Me._Txt_15.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_15.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_15.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_15.Location = New System.Drawing.Point(474, 537)
        Me._Txt_15.MaxLength = 100
        Me._Txt_15.Name = "_Txt_15"
        Me._Txt_15.Size = New System.Drawing.Size(80, 14)
        Me._Txt_15.TabIndex = 19
        Me._Txt_15.Text = "0"
        Me._Txt_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_14
        '
        Me._Txt_14.AcceptsReturn = True
        Me._Txt_14.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_14.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_14.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_14.Location = New System.Drawing.Point(474, 505)
        Me._Txt_14.MaxLength = 100
        Me._Txt_14.Name = "_Txt_14"
        Me._Txt_14.Size = New System.Drawing.Size(80, 14)
        Me._Txt_14.TabIndex = 18
        Me._Txt_14.Text = "0"
        Me._Txt_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_13
        '
        Me._Txt_13.AcceptsReturn = True
        Me._Txt_13.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_13.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_13.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_13.Location = New System.Drawing.Point(474, 489)
        Me._Txt_13.MaxLength = 100
        Me._Txt_13.Name = "_Txt_13"
        Me._Txt_13.Size = New System.Drawing.Size(80, 14)
        Me._Txt_13.TabIndex = 17
        Me._Txt_13.Text = "0"
        Me._Txt_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_12
        '
        Me._Txt_12.AcceptsReturn = True
        Me._Txt_12.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_12.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_12.Location = New System.Drawing.Point(474, 473)
        Me._Txt_12.MaxLength = 100
        Me._Txt_12.Name = "_Txt_12"
        Me._Txt_12.Size = New System.Drawing.Size(80, 14)
        Me._Txt_12.TabIndex = 16
        Me._Txt_12.Text = "0"
        Me._Txt_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_11
        '
        Me._Txt_11.AcceptsReturn = True
        Me._Txt_11.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_11.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_11.Location = New System.Drawing.Point(474, 457)
        Me._Txt_11.MaxLength = 100
        Me._Txt_11.Name = "_Txt_11"
        Me._Txt_11.Size = New System.Drawing.Size(80, 14)
        Me._Txt_11.TabIndex = 15
        Me._Txt_11.Text = "0"
        Me._Txt_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_10
        '
        Me._Txt_10.AcceptsReturn = True
        Me._Txt_10.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_10.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_10.Location = New System.Drawing.Point(474, 384)
        Me._Txt_10.MaxLength = 100
        Me._Txt_10.Name = "_Txt_10"
        Me._Txt_10.Size = New System.Drawing.Size(80, 14)
        Me._Txt_10.TabIndex = 14
        Me._Txt_10.Text = "0"
        Me._Txt_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_9
        '
        Me._Txt_9.AcceptsReturn = True
        Me._Txt_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_9.Location = New System.Drawing.Point(475, 353)
        Me._Txt_9.MaxLength = 100
        Me._Txt_9.Name = "_Txt_9"
        Me._Txt_9.Size = New System.Drawing.Size(80, 14)
        Me._Txt_9.TabIndex = 13
        Me._Txt_9.Text = "0"
        Me._Txt_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_8
        '
        Me._Txt_8.AcceptsReturn = True
        Me._Txt_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_8.Location = New System.Drawing.Point(474, 337)
        Me._Txt_8.MaxLength = 100
        Me._Txt_8.Name = "_Txt_8"
        Me._Txt_8.Size = New System.Drawing.Size(80, 14)
        Me._Txt_8.TabIndex = 12
        Me._Txt_8.Text = "0"
        Me._Txt_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_7
        '
        Me._Txt_7.AcceptsReturn = True
        Me._Txt_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_7.Location = New System.Drawing.Point(474, 321)
        Me._Txt_7.MaxLength = 100
        Me._Txt_7.Name = "_Txt_7"
        Me._Txt_7.Size = New System.Drawing.Size(80, 14)
        Me._Txt_7.TabIndex = 11
        Me._Txt_7.Text = "0"
        Me._Txt_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_6
        '
        Me._Txt_6.AcceptsReturn = True
        Me._Txt_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_6.Location = New System.Drawing.Point(474, 305)
        Me._Txt_6.MaxLength = 100
        Me._Txt_6.Name = "_Txt_6"
        Me._Txt_6.Size = New System.Drawing.Size(80, 14)
        Me._Txt_6.TabIndex = 10
        Me._Txt_6.Text = "0"
        Me._Txt_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_5
        '
        Me._Txt_5.AcceptsReturn = True
        Me._Txt_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_5.Location = New System.Drawing.Point(474, 289)
        Me._Txt_5.MaxLength = 100
        Me._Txt_5.Name = "_Txt_5"
        Me._Txt_5.Size = New System.Drawing.Size(80, 14)
        Me._Txt_5.TabIndex = 9
        Me._Txt_5.Text = "0"
        Me._Txt_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_4
        '
        Me._Txt_4.AcceptsReturn = True
        Me._Txt_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_4.Location = New System.Drawing.Point(474, 273)
        Me._Txt_4.MaxLength = 100
        Me._Txt_4.Name = "_Txt_4"
        Me._Txt_4.Size = New System.Drawing.Size(80, 14)
        Me._Txt_4.TabIndex = 8
        Me._Txt_4.Text = "0"
        Me._Txt_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_3
        '
        Me._Txt_3.AcceptsReturn = True
        Me._Txt_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_3.Location = New System.Drawing.Point(474, 257)
        Me._Txt_3.MaxLength = 100
        Me._Txt_3.Name = "_Txt_3"
        Me._Txt_3.Size = New System.Drawing.Size(80, 14)
        Me._Txt_3.TabIndex = 7
        Me._Txt_3.Text = "0"
        Me._Txt_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_2
        '
        Me._Txt_2.AcceptsReturn = True
        Me._Txt_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_2.Location = New System.Drawing.Point(474, 241)
        Me._Txt_2.MaxLength = 100
        Me._Txt_2.Name = "_Txt_2"
        Me._Txt_2.Size = New System.Drawing.Size(80, 14)
        Me._Txt_2.TabIndex = 6
        Me._Txt_2.Text = "0"
        Me._Txt_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_1
        '
        Me._Txt_1.AcceptsReturn = True
        Me._Txt_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_1.Location = New System.Drawing.Point(474, 225)
        Me._Txt_1.MaxLength = 100
        Me._Txt_1.Name = "_Txt_1"
        Me._Txt_1.ReadOnly = True
        Me._Txt_1.Size = New System.Drawing.Size(80, 14)
        Me._Txt_1.TabIndex = 5
        Me._Txt_1.Text = "0"
        Me._Txt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_chk_0
        '
        Me._chk_0.BackColor = System.Drawing.SystemColors.Window
        Me._chk_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._chk_0.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chk_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chk_0.Location = New System.Drawing.Point(7, 124)
        Me._chk_0.Name = "_chk_0"
        Me._chk_0.Size = New System.Drawing.Size(547, 18)
        Me._chk_0.TabIndex = 67
        Me._chk_0.Tag = "Payment extension accordance with Decree 30/NQ-CP  "
        Me._chk_0.Text = "Gia hạn nộp NĐ 30/NQ-CP"
        Me._chk_0.UseVisualStyleBackColor = False
        '
        '_Txt_0
        '
        Me._Txt_0.AcceptsReturn = True
        Me._Txt_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_0.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_0.Location = New System.Drawing.Point(474, 193)
        Me._Txt_0.MaxLength = 100
        Me._Txt_0.Name = "_Txt_0"
        Me._Txt_0.Size = New System.Drawing.Size(80, 14)
        Me._Txt_0.TabIndex = 4
        Me._Txt_0.Text = "0"
        Me._Txt_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KY
        '
        Me.KY.AcceptsReturn = True
        Me.KY.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.KY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.KY.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.KY.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KY.Location = New System.Drawing.Point(227, 68)
        Me.KY.MaxLength = 100
        Me.KY.Name = "KY"
        Me.KY.Size = New System.Drawing.Size(185, 14)
        Me.KY.TabIndex = 0
        Me.KY.Text = "..."
        '
        'CTY
        '
        Me.CTY.AcceptsReturn = True
        Me.CTY.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.CTY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CTY.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CTY.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTY.Location = New System.Drawing.Point(273, 93)
        Me.CTY.MaxLength = 100
        Me.CTY.Name = "CTY"
        Me.CTY.Size = New System.Drawing.Size(279, 14)
        Me.CTY.TabIndex = 2
        Me.CTY.Text = "..."
        '
        '_Label0_159
        '
        Me._Label0_159.AutoSize = True
        Me._Label0_159.BackColor = System.Drawing.Color.White
        Me._Label0_159.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_159.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_159.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_159.Location = New System.Drawing.Point(7, 108)
        Me._Label0_159.Name = "_Label0_159"
        Me._Label0_159.Size = New System.Drawing.Size(70, 15)
        Me._Label0_159.TabIndex = 232
        Me._Label0_159.Tag = "[04] Address:"
        Me._Label0_159.Text = "[04] Địa chỉ:"
        '
        '_Line_29
        '
        Me._Line_29.Enabled = False
        Me._Line_29.Location = New System.Drawing.Point(0, 640)
        Me._Line_29.Name = "_Line_29"
        Me._Line_29.Size = New System.Drawing.Size(553, 1)
        Me._Line_29.TabIndex = 233
        '
        '_Line_28
        '
        Me._Line_28.Enabled = False
        Me._Line_28.Location = New System.Drawing.Point(0, 624)
        Me._Line_28.Name = "_Line_28"
        Me._Line_28.Size = New System.Drawing.Size(553, 1)
        Me._Line_28.TabIndex = 234
        '
        '_Line_27
        '
        Me._Line_27.Enabled = False
        Me._Line_27.Location = New System.Drawing.Point(0, 584)
        Me._Line_27.Name = "_Line_27"
        Me._Line_27.Size = New System.Drawing.Size(553, 1)
        Me._Line_27.TabIndex = 235
        '
        '_Line_26
        '
        Me._Line_26.Enabled = False
        Me._Line_26.Location = New System.Drawing.Point(0, 568)
        Me._Line_26.Name = "_Line_26"
        Me._Line_26.Size = New System.Drawing.Size(553, 1)
        Me._Line_26.TabIndex = 236
        '
        '_Line_25
        '
        Me._Line_25.Enabled = False
        Me._Line_25.Location = New System.Drawing.Point(0, 536)
        Me._Line_25.Name = "_Line_25"
        Me._Line_25.Size = New System.Drawing.Size(553, 1)
        Me._Line_25.TabIndex = 237
        '
        '_Line_24
        '
        Me._Line_24.Enabled = False
        Me._Line_24.Location = New System.Drawing.Point(0, 504)
        Me._Line_24.Name = "_Line_24"
        Me._Line_24.Size = New System.Drawing.Size(553, 1)
        Me._Line_24.TabIndex = 238
        '
        '_Line_23
        '
        Me._Line_23.Enabled = False
        Me._Line_23.Location = New System.Drawing.Point(0, 488)
        Me._Line_23.Name = "_Line_23"
        Me._Line_23.Size = New System.Drawing.Size(553, 1)
        Me._Line_23.TabIndex = 239
        '
        '_Line_22
        '
        Me._Line_22.Enabled = False
        Me._Line_22.Location = New System.Drawing.Point(0, 472)
        Me._Line_22.Name = "_Line_22"
        Me._Line_22.Size = New System.Drawing.Size(553, 1)
        Me._Line_22.TabIndex = 240
        '
        '_Line_21
        '
        Me._Line_21.Enabled = False
        Me._Line_21.Location = New System.Drawing.Point(0, 456)
        Me._Line_21.Name = "_Line_21"
        Me._Line_21.Size = New System.Drawing.Size(553, 1)
        Me._Line_21.TabIndex = 241
        '
        '_Line_20
        '
        Me._Line_20.Enabled = False
        Me._Line_20.Location = New System.Drawing.Point(0, 400)
        Me._Line_20.Name = "_Line_20"
        Me._Line_20.Size = New System.Drawing.Size(553, 1)
        Me._Line_20.TabIndex = 242
        '
        '_Line_19
        '
        Me._Line_19.Enabled = False
        Me._Line_19.Location = New System.Drawing.Point(0, 352)
        Me._Line_19.Name = "_Line_19"
        Me._Line_19.Size = New System.Drawing.Size(553, 1)
        Me._Line_19.TabIndex = 243
        '
        '_Line_18
        '
        Me._Line_18.Enabled = False
        Me._Line_18.Location = New System.Drawing.Point(0, 336)
        Me._Line_18.Name = "_Line_18"
        Me._Line_18.Size = New System.Drawing.Size(553, 1)
        Me._Line_18.TabIndex = 244
        '
        '_Line_17
        '
        Me._Line_17.Enabled = False
        Me._Line_17.Location = New System.Drawing.Point(0, 320)
        Me._Line_17.Name = "_Line_17"
        Me._Line_17.Size = New System.Drawing.Size(553, 1)
        Me._Line_17.TabIndex = 245
        '
        '_Line_16
        '
        Me._Line_16.Enabled = False
        Me._Line_16.Location = New System.Drawing.Point(0, 304)
        Me._Line_16.Name = "_Line_16"
        Me._Line_16.Size = New System.Drawing.Size(553, 1)
        Me._Line_16.TabIndex = 246
        '
        '_Line_15
        '
        Me._Line_15.Enabled = False
        Me._Line_15.Location = New System.Drawing.Point(0, 288)
        Me._Line_15.Name = "_Line_15"
        Me._Line_15.Size = New System.Drawing.Size(553, 1)
        Me._Line_15.TabIndex = 247
        '
        '_Line_14
        '
        Me._Line_14.Enabled = False
        Me._Line_14.Location = New System.Drawing.Point(0, 272)
        Me._Line_14.Name = "_Line_14"
        Me._Line_14.Size = New System.Drawing.Size(553, 1)
        Me._Line_14.TabIndex = 248
        '
        '_Line_13
        '
        Me._Line_13.Enabled = False
        Me._Line_13.Location = New System.Drawing.Point(0, 256)
        Me._Line_13.Name = "_Line_13"
        Me._Line_13.Size = New System.Drawing.Size(553, 1)
        Me._Line_13.TabIndex = 249
        '
        '_Line_12
        '
        Me._Line_12.Enabled = False
        Me._Line_12.Location = New System.Drawing.Point(0, 240)
        Me._Line_12.Name = "_Line_12"
        Me._Line_12.Size = New System.Drawing.Size(553, 1)
        Me._Line_12.TabIndex = 250
        '
        '_Line_11
        '
        Me._Line_11.Enabled = False
        Me._Line_11.Location = New System.Drawing.Point(0, 224)
        Me._Line_11.Name = "_Line_11"
        Me._Line_11.Size = New System.Drawing.Size(553, 1)
        Me._Line_11.TabIndex = 251
        '
        '_Line_10
        '
        Me._Line_10.Enabled = False
        Me._Line_10.Location = New System.Drawing.Point(0, 208)
        Me._Line_10.Name = "_Line_10"
        Me._Line_10.Size = New System.Drawing.Size(553, 1)
        Me._Line_10.TabIndex = 252
        '
        '_Line_9
        '
        Me._Line_9.Enabled = False
        Me._Line_9.Location = New System.Drawing.Point(0, 192)
        Me._Line_9.Name = "_Line_9"
        Me._Line_9.Size = New System.Drawing.Size(553, 1)
        Me._Line_9.TabIndex = 253
        '
        '_Line_8
        '
        Me._Line_8.Enabled = False
        Me._Line_8.Location = New System.Drawing.Point(0, 176)
        Me._Line_8.Name = "_Line_8"
        Me._Line_8.Size = New System.Drawing.Size(553, 1)
        Me._Line_8.TabIndex = 254
        '
        '_Line_7
        '
        Me._Line_7.Enabled = False
        Me._Line_7.Location = New System.Drawing.Point(0, 160)
        Me._Line_7.Name = "_Line_7"
        Me._Line_7.Size = New System.Drawing.Size(553, 1)
        Me._Line_7.TabIndex = 255
        '
        '_Line_6
        '
        Me._Line_6.Enabled = False
        Me._Line_6.Location = New System.Drawing.Point(0, 144)
        Me._Line_6.Name = "_Line_6"
        Me._Line_6.Size = New System.Drawing.Size(553, 1)
        Me._Line_6.TabIndex = 256
        '
        '_Line_5
        '
        Me._Line_5.Enabled = False
        Me._Line_5.Location = New System.Drawing.Point(473, 144)
        Me._Line_5.Name = "_Line_5"
        Me._Line_5.Size = New System.Drawing.Size(1, 512)
        Me._Line_5.TabIndex = 257
        '
        '_Line_4
        '
        Me._Line_4.Enabled = False
        Me._Line_4.Location = New System.Drawing.Point(440, 144)
        Me._Line_4.Name = "_Line_4"
        Me._Line_4.Size = New System.Drawing.Size(1, 512)
        Me._Line_4.TabIndex = 258
        '
        '_Line_3
        '
        Me._Line_3.Enabled = False
        Me._Line_3.Location = New System.Drawing.Point(25, 144)
        Me._Line_3.Name = "_Line_3"
        Me._Line_3.Size = New System.Drawing.Size(1, 512)
        Me._Line_3.TabIndex = 259
        '
        '_Line_2
        '
        Me._Line_2.Enabled = False
        Me._Line_2.Location = New System.Drawing.Point(553, 144)
        Me._Line_2.Name = "_Line_2"
        Me._Line_2.Size = New System.Drawing.Size(1, 512)
        Me._Line_2.TabIndex = 260
        '
        '_Line_1
        '
        Me._Line_1.Enabled = False
        Me._Line_1.Location = New System.Drawing.Point(0, 656)
        Me._Line_1.Name = "_Line_1"
        Me._Line_1.Size = New System.Drawing.Size(553, 1)
        Me._Line_1.TabIndex = 261
        '
        '_Line_0
        '
        Me._Line_0.Enabled = False
        Me._Line_0.Location = New System.Drawing.Point(0, 144)
        Me._Line_0.Name = "_Line_0"
        Me._Line_0.Size = New System.Drawing.Size(1, 514)
        Me._Line_0.TabIndex = 262
        '
        '_Label0_58
        '
        Me._Label0_58.BackColor = System.Drawing.Color.White
        Me._Label0_58.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_58.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_58.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_58.Location = New System.Drawing.Point(27, 640)
        Me._Label0_58.Name = "_Label0_58"
        Me._Label0_58.Size = New System.Drawing.Size(413, 17)
        Me._Label0_58.TabIndex = 127
        Me._Label0_58.Tag = "The reduction of revenues to increase."
        Me._Label0_58.Text = "Giảm trừ các khoản doanh thu đã tính thuế năm trước"
        '
        '_Label0_57
        '
        Me._Label0_57.BackColor = System.Drawing.Color.White
        Me._Label0_57.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_57.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_57.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_57.Location = New System.Drawing.Point(0, 640)
        Me._Label0_57.Name = "_Label0_57"
        Me._Label0_57.Size = New System.Drawing.Size(25, 17)
        Me._Label0_57.TabIndex = 126
        Me._Label0_57.Text = "2.2"
        Me._Label0_57.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_56
        '
        Me._Label0_56.BackColor = System.Drawing.Color.White
        Me._Label0_56.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_56.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_56.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_56.Location = New System.Drawing.Point(27, 624)
        Me._Label0_56.Name = "_Label0_56"
        Me._Label0_56.Size = New System.Drawing.Size(413, 17)
        Me._Label0_56.TabIndex = 125
        Me._Label0_56.Tag = "The profit of operations which did not submited tax."
        Me._Label0_56.Text = "Lợi nhuận từ hoạt động không thuộc diện chịu thuế thu nhập doanh nghiệp"
        '
        '_Label0_55
        '
        Me._Label0_55.BackColor = System.Drawing.Color.White
        Me._Label0_55.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_55.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_55.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_55.Location = New System.Drawing.Point(0, 624)
        Me._Label0_55.Name = "_Label0_55"
        Me._Label0_55.Size = New System.Drawing.Size(25, 17)
        Me._Label0_55.TabIndex = 124
        Me._Label0_55.Text = "2.1"
        Me._Label0_55.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_54
        '
        Me._Label0_54.BackColor = System.Drawing.Color.White
        Me._Label0_54.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_54.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_54.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_54.Location = New System.Drawing.Point(27, 584)
        Me._Label0_54.Name = "_Label0_54"
        Me._Label0_54.Size = New System.Drawing.Size(413, 41)
        Me._Label0_54.TabIndex = 123
        Me._Label0_54.Tag = "Adjusted to decrease the total profit before corporate income tax (B17=B18+B19+B2" & _
            "0+B21+B22)."
        Me._Label0_54.Text = "Điều chỉnh giảm tông lợi nhuận trước thuế thu nhập doanh nghiệp (B17=B18+B19+B20+" & _
            "B21+B22)"
        '
        '_Label0_53
        '
        Me._Label0_53.BackColor = System.Drawing.Color.White
        Me._Label0_53.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_53.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_53.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_53.Location = New System.Drawing.Point(0, 584)
        Me._Label0_53.Name = "_Label0_53"
        Me._Label0_53.Size = New System.Drawing.Size(25, 25)
        Me._Label0_53.TabIndex = 122
        Me._Label0_53.Text = "2"
        Me._Label0_53.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_48
        '
        Me._Label0_48.BackColor = System.Drawing.Color.White
        Me._Label0_48.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_48.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_48.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_48.Location = New System.Drawing.Point(27, 504)
        Me._Label0_48.Name = "_Label0_48"
        Me._Label0_48.Size = New System.Drawing.Size(413, 33)
        Me._Label0_48.TabIndex = 117
        Me._Label0_48.Tag = "Loss of exchange rate differences from revalution of monetary items originated fr" & _
            "om foreign currencies at the end of fiscal year."
        Me._Label0_48.Text = "Lỗ chênh lệch tỷ giá hối đoái do đánh giá lại các khoản mục tiền tệ có nguồn gốc " & _
            "ngoại tệ tại thời điểm cuối năm tài chính"
        '
        '_Label0_47
        '
        Me._Label0_47.BackColor = System.Drawing.Color.White
        Me._Label0_47.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_47.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_47.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_47.Location = New System.Drawing.Point(0, 504)
        Me._Label0_47.Name = "_Label0_47"
        Me._Label0_47.Size = New System.Drawing.Size(25, 33)
        Me._Label0_47.TabIndex = 116
        Me._Label0_47.Text = "1.13"
        Me._Label0_47.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_46
        '
        Me._Label0_46.BackColor = System.Drawing.Color.White
        Me._Label0_46.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_46.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_46.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_46.Location = New System.Drawing.Point(27, 488)
        Me._Label0_46.Name = "_Label0_46"
        Me._Label0_46.Size = New System.Drawing.Size(413, 17)
        Me._Label0_46.TabIndex = 115
        Me._Label0_46.Tag = "The enpexse of management to run companies."
        Me._Label0_46.Text = "Chi phí quản lý kinh doanh do công ty ở nước ngoài phân bổ vượt mức quy định"
        '
        '_Label0_45
        '
        Me._Label0_45.BackColor = System.Drawing.Color.White
        Me._Label0_45.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_45.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_45.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_45.Location = New System.Drawing.Point(0, 488)
        Me._Label0_45.Name = "_Label0_45"
        Me._Label0_45.Size = New System.Drawing.Size(25, 17)
        Me._Label0_45.TabIndex = 114
        Me._Label0_45.Text = "1.12"
        Me._Label0_45.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_44
        '
        Me._Label0_44.BackColor = System.Drawing.Color.White
        Me._Label0_44.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_44.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_44.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_44.Location = New System.Drawing.Point(27, 472)
        Me._Label0_44.Name = "_Label0_44"
        Me._Label0_44.Size = New System.Drawing.Size(413, 17)
        Me._Label0_44.TabIndex = 113
        Me._Label0_44.Tag = "The costs of eating in rest break which excess regulation."
        Me._Label0_44.Text = "Chi phí tiền ăn giữa ca vượt mức quy định"
        '
        '_Label0_43
        '
        Me._Label0_43.BackColor = System.Drawing.Color.White
        Me._Label0_43.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_43.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_43.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_43.Location = New System.Drawing.Point(0, 472)
        Me._Label0_43.Name = "_Label0_43"
        Me._Label0_43.Size = New System.Drawing.Size(25, 17)
        Me._Label0_43.TabIndex = 112
        Me._Label0_43.Text = "1.11"
        Me._Label0_43.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_42
        '
        Me._Label0_42.BackColor = System.Drawing.Color.White
        Me._Label0_42.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_42.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_42.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_42.Location = New System.Drawing.Point(27, 456)
        Me._Label0_42.Name = "_Label0_42"
        Me._Label0_42.Size = New System.Drawing.Size(413, 17)
        Me._Label0_42.TabIndex = 111
        Me._Label0_42.Tag = "Before other amount for expenses but actually not spent."
        Me._Label0_42.Text = "Các khoản trích trước vào chi phí mà thực tế không chi"
        '
        '_Label0_41
        '
        Me._Label0_41.BackColor = System.Drawing.Color.White
        Me._Label0_41.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_41.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_41.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_41.Location = New System.Drawing.Point(0, 456)
        Me._Label0_41.Name = "_Label0_41"
        Me._Label0_41.Size = New System.Drawing.Size(25, 17)
        Me._Label0_41.TabIndex = 110
        Me._Label0_41.Text = "1.10"
        Me._Label0_41.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_39
        '
        Me._Label0_39.BackColor = System.Drawing.Color.White
        Me._Label0_39.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_39.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_39.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_39.Location = New System.Drawing.Point(-1, 369)
        Me._Label0_39.Name = "_Label0_39"
        Me._Label0_39.Size = New System.Drawing.Size(25, 73)
        Me._Label0_39.TabIndex = 108
        Me._Label0_39.Text = "     1.9"
        Me._Label0_39.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_38
        '
        Me._Label0_38.BackColor = System.Drawing.Color.White
        Me._Label0_38.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_38.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_38.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_38.Location = New System.Drawing.Point(27, 352)
        Me._Label0_38.Name = "_Label0_38"
        Me._Label0_38.Size = New System.Drawing.Size(413, 17)
        Me._Label0_38.TabIndex = 107
        Me._Label0_38.Tag = "The expenses not related to revenue income subject to corporate income tax."
        Me._Label0_38.Text = "Chi phí không liên quan đến doanh thu, thu nhập chịu thuế thu nhập doanh nghiệp"
        '
        '_Label0_37
        '
        Me._Label0_37.BackColor = System.Drawing.Color.White
        Me._Label0_37.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_37.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_37.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_37.Location = New System.Drawing.Point(0, 352)
        Me._Label0_37.Name = "_Label0_37"
        Me._Label0_37.Size = New System.Drawing.Size(25, 18)
        Me._Label0_37.TabIndex = 106
        Me._Label0_37.Text = "1.8"
        Me._Label0_37.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_36
        '
        Me._Label0_36.BackColor = System.Drawing.Color.White
        Me._Label0_36.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_36.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_36.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_36.Location = New System.Drawing.Point(0, 336)
        Me._Label0_36.Name = "_Label0_36"
        Me._Label0_36.Size = New System.Drawing.Size(25, 17)
        Me._Label0_36.TabIndex = 105
        Me._Label0_36.Text = "1.7"
        Me._Label0_36.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_35
        '
        Me._Label0_35.BackColor = System.Drawing.Color.White
        Me._Label0_35.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_35.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_35.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_35.Location = New System.Drawing.Point(27, 336)
        Me._Label0_35.Name = "_Label0_35"
        Me._Label0_35.Size = New System.Drawing.Size(413, 17)
        Me._Label0_35.TabIndex = 104
        Me._Label0_35.Tag = "The tax arrears and fines for administrative violations were included in the cost" & _
            ""
        Me._Label0_35.Text = "Các khoản thuế bị truy thu và tiền phạt về vi phạm hành chính đã tính vào chi phí" & _
            ""
        '
        '_Label0_34
        '
        Me._Label0_34.BackColor = System.Drawing.Color.White
        Me._Label0_34.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_34.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_34.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_34.Location = New System.Drawing.Point(0, 320)
        Me._Label0_34.Name = "_Label0_34"
        Me._Label0_34.Size = New System.Drawing.Size(25, 17)
        Me._Label0_34.TabIndex = 103
        Me._Label0_34.Text = "1.6"
        Me._Label0_34.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_33
        '
        Me._Label0_33.BackColor = System.Drawing.Color.White
        Me._Label0_33.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_33.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_33.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_33.Location = New System.Drawing.Point(27, 320)
        Me._Label0_33.Name = "_Label0_33"
        Me._Label0_33.Size = New System.Drawing.Size(413, 17)
        Me._Label0_33.TabIndex = 102
        Me._Label0_33.Tag = "Expenses without receipts and vouchers according to regulations"
        Me._Label0_33.Text = "Chi phí không có hóa đơn, chứng từ theo chế độ quy định"
        '
        '_Label0_32
        '
        Me._Label0_32.BackColor = System.Drawing.Color.White
        Me._Label0_32.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_32.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_32.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_32.Location = New System.Drawing.Point(0, 304)
        Me._Label0_32.Name = "_Label0_32"
        Me._Label0_32.Size = New System.Drawing.Size(25, 17)
        Me._Label0_32.TabIndex = 101
        Me._Label0_32.Text = "1.5"
        Me._Label0_32.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_31
        '
        Me._Label0_31.BackColor = System.Drawing.Color.White
        Me._Label0_31.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_31.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_31.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_31.Location = New System.Drawing.Point(27, 304)
        Me._Label0_31.Name = "_Label0_31"
        Me._Label0_31.Size = New System.Drawing.Size(413, 17)
        Me._Label0_31.TabIndex = 100
        Me._Label0_31.Tag = "Interest expense in excess of limition prescribed. "
        Me._Label0_31.Text = "Chi phí lãi tiền vay vượt mức khống chế theo quy định"
        '
        '_Label0_30
        '
        Me._Label0_30.BackColor = System.Drawing.Color.White
        Me._Label0_30.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_30.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_30.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_30.Location = New System.Drawing.Point(0, 288)
        Me._Label0_30.Name = "_Label0_30"
        Me._Label0_30.Size = New System.Drawing.Size(25, 17)
        Me._Label0_30.TabIndex = 99
        Me._Label0_30.Text = "1.4"
        Me._Label0_30.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_29
        '
        Me._Label0_29.BackColor = System.Drawing.Color.White
        Me._Label0_29.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_29.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_29.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_29.Location = New System.Drawing.Point(27, 288)
        Me._Label0_29.Name = "_Label0_29"
        Me._Label0_29.Size = New System.Drawing.Size(413, 17)
        Me._Label0_29.TabIndex = 98
        Me._Label0_29.Tag = "Depreciation costs of fixed assets are not properly regulated"
        Me._Label0_29.Text = "Chi phí khấu hao TSCĐ không đúng quy định"
        '
        '_Label0_28
        '
        Me._Label0_28.BackColor = System.Drawing.Color.White
        Me._Label0_28.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_28.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_28.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_28.Location = New System.Drawing.Point(0, 272)
        Me._Label0_28.Name = "_Label0_28"
        Me._Label0_28.Size = New System.Drawing.Size(25, 17)
        Me._Label0_28.TabIndex = 97
        Me._Label0_28.Text = "1.3"
        Me._Label0_28.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_27
        '
        Me._Label0_27.BackColor = System.Drawing.Color.White
        Me._Label0_27.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_27.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_27.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_27.Location = New System.Drawing.Point(27, 272)
        Me._Label0_27.Name = "_Label0_27"
        Me._Label0_27.Size = New System.Drawing.Size(413, 17)
        Me._Label0_27.TabIndex = 96
        Me._Label0_27.Tag = "Income tax paid on the income received in foreign countries "
        Me._Label0_27.Text = "Thuế thu nhập đã nộp cho phần thu nhập được ở nước ngoài"
        '
        '_Label0_26
        '
        Me._Label0_26.BackColor = System.Drawing.Color.White
        Me._Label0_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_26.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_26.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_26.Location = New System.Drawing.Point(27, 256)
        Me._Label0_26.Name = "_Label0_26"
        Me._Label0_26.Size = New System.Drawing.Size(413, 17)
        Me._Label0_26.TabIndex = 95
        Me._Label0_26.Tag = "Costs of  decrease revenue "
        Me._Label0_26.Text = "Chi phớ của phaàn doanh thu ủieàu chổnh giaỷm"
        '
        '_Label0_25
        '
        Me._Label0_25.BackColor = System.Drawing.Color.White
        Me._Label0_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_25.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_25.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_25.Location = New System.Drawing.Point(0, 256)
        Me._Label0_25.Name = "_Label0_25"
        Me._Label0_25.Size = New System.Drawing.Size(25, 17)
        Me._Label0_25.TabIndex = 94
        Me._Label0_25.Text = "1.2"
        Me._Label0_25.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_24
        '
        Me._Label0_24.BackColor = System.Drawing.Color.White
        Me._Label0_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_24.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_24.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_24.Location = New System.Drawing.Point(27, 240)
        Me._Label0_24.Name = "_Label0_24"
        Me._Label0_24.Size = New System.Drawing.Size(413, 17)
        Me._Label0_24.TabIndex = 93
        Me._Label0_24.Tag = "Clause to increase for revenue"
        Me._Label0_24.Text = "Các khoản điều chỉnh tăng doanh thu"
        '
        '_Label0_23
        '
        Me._Label0_23.BackColor = System.Drawing.Color.White
        Me._Label0_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_23.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_23.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_23.Location = New System.Drawing.Point(0, 240)
        Me._Label0_23.Name = "_Label0_23"
        Me._Label0_23.Size = New System.Drawing.Size(25, 17)
        Me._Label0_23.TabIndex = 92
        Me._Label0_23.Text = "1.1"
        Me._Label0_23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_0
        '
        Me._Label0_0.BackColor = System.Drawing.Color.White
        Me._Label0_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_0.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_0.Location = New System.Drawing.Point(-7, 0)
        Me._Label0_0.Name = "_Label0_0"
        Me._Label0_0.Size = New System.Drawing.Size(561, 19)
        Me._Label0_0.TabIndex = 89
        Me._Label0_0.Tag = "SOCIALIST REPUBLIC OF VIETNAM"
        Me._Label0_0.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM"
        Me._Label0_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_3
        '
        Me._Label0_3.BackColor = System.Drawing.Color.White
        Me._Label0_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_3.Location = New System.Drawing.Point(-7, 48)
        Me._Label0_3.Name = "_Label0_3"
        Me._Label0_3.Size = New System.Drawing.Size(561, 20)
        Me._Label0_3.TabIndex = 87
        Me._Label0_3.Tag = "DECLARATION OF SELF-SETTLEMENT OF ENTERPRISE IN COME TAX"
        Me._Label0_3.Text = "TỜ KHAI TỰ QUYẾT TOÁN THUẾ THU NHẬP DOANH NGHIỆP"
        Me._Label0_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_4
        '
        Me._Label0_4.AutoSize = True
        Me._Label0_4.BackColor = System.Drawing.Color.White
        Me._Label0_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_4.Location = New System.Drawing.Point(140, 68)
        Me._Label0_4.Name = "_Label0_4"
        Me._Label0_4.Size = New System.Drawing.Size(103, 15)
        Me._Label0_4.TabIndex = 86
        Me._Label0_4.Tag = "[01] Tax period:"
        Me._Label0_4.Text = "[01] Kỳ tính thuế: "
        '
        '_Label0_5
        '
        Me._Label0_5.AutoSize = True
        Me._Label0_5.BackColor = System.Drawing.Color.White
        Me._Label0_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_5.Location = New System.Drawing.Point(7, 92)
        Me._Label0_5.Name = "_Label0_5"
        Me._Label0_5.Size = New System.Drawing.Size(97, 15)
        Me._Label0_5.TabIndex = 85
        Me._Label0_5.Tag = "[02] Tax code:  "
        Me._Label0_5.Text = "[02] Mã số thuế: "
        '
        '_Label0_6
        '
        Me._Label0_6.AutoSize = True
        Me._Label0_6.BackColor = System.Drawing.Color.White
        Me._Label0_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_6.Location = New System.Drawing.Point(173, 92)
        Me._Label0_6.Name = "_Label0_6"
        Me._Label0_6.Size = New System.Drawing.Size(120, 15)
        Me._Label0_6.TabIndex = 84
        Me._Label0_6.Tag = "[03] Enterprise name:"
        Me._Label0_6.Text = "[03] Người nộp thuế: "
        '
        '_Label0_7
        '
        Me._Label0_7.BackColor = System.Drawing.Color.White
        Me._Label0_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_7.Location = New System.Drawing.Point(27, 176)
        Me._Label0_7.Name = "_Label0_7"
        Me._Label0_7.Size = New System.Drawing.Size(413, 17)
        Me._Label0_7.TabIndex = 83
        Me._Label0_7.Tag = "The results of contempt business recorded by the financial statements"
        Me._Label0_7.Text = "Kết quả kinh doanh ghi nhận theo báo cáo tài chính"
        '
        '_Label0_8
        '
        Me._Label0_8.BackColor = System.Drawing.Color.White
        Me._Label0_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_8.Location = New System.Drawing.Point(0, 192)
        Me._Label0_8.Name = "_Label0_8"
        Me._Label0_8.Size = New System.Drawing.Size(25, 17)
        Me._Label0_8.TabIndex = 82
        Me._Label0_8.Text = "1"
        Me._Label0_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_9
        '
        Me._Label0_9.BackColor = System.Drawing.Color.White
        Me._Label0_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_9.Location = New System.Drawing.Point(27, 192)
        Me._Label0_9.Name = "_Label0_9"
        Me._Label0_9.Size = New System.Drawing.Size(413, 17)
        Me._Label0_9.TabIndex = 81
        Me._Label0_9.Tag = "Total profit before tax of enprise income"
        Me._Label0_9.Text = "Tổng lợi nhuận trước thuế thu nhập doanh nghiệp"
        '
        '_Label0_10
        '
        Me._Label0_10.BackColor = System.Drawing.Color.White
        Me._Label0_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_10.Location = New System.Drawing.Point(0, 208)
        Me._Label0_10.Name = "_Label0_10"
        Me._Label0_10.Size = New System.Drawing.Size(25, 17)
        Me._Label0_10.TabIndex = 80
        Me._Label0_10.Text = "B"
        Me._Label0_10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_11
        '
        Me._Label0_11.BackColor = System.Drawing.Color.White
        Me._Label0_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_11.Location = New System.Drawing.Point(27, 208)
        Me._Label0_11.Name = "_Label0_11"
        Me._Label0_11.Size = New System.Drawing.Size(413, 17)
        Me._Label0_11.TabIndex = 79
        Me._Label0_11.Tag = "Determining taxable income under the corporate income tax law"
        Me._Label0_11.Text = "Xác định thu nhập chịu thuế theo Luật thuế thu nhập doanh nghiệp"
        '
        '_Label0_12
        '
        Me._Label0_12.BackColor = System.Drawing.Color.White
        Me._Label0_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_12.Location = New System.Drawing.Point(27, 224)
        Me._Label0_12.Name = "_Label0_12"
        Me._Label0_12.Size = New System.Drawing.Size(413, 17)
        Me._Label0_12.TabIndex = 78
        Me._Label0_12.Tag = "To increase total profit before corporate income tax (B1=B2+B3+...+B16)"
        Me._Label0_12.Text = "Điều chỉnh tăng tổng lợi nuận trước thuế (B1=B2+B3+...+B16)"
        '
        '_Label0_13
        '
        Me._Label0_13.BackColor = System.Drawing.Color.White
        Me._Label0_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_13.Location = New System.Drawing.Point(0, 224)
        Me._Label0_13.Name = "_Label0_13"
        Me._Label0_13.Size = New System.Drawing.Size(25, 17)
        Me._Label0_13.TabIndex = 77
        Me._Label0_13.Text = "1"
        Me._Label0_13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_14
        '
        Me._Label0_14.BackColor = System.Drawing.Color.White
        Me._Label0_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_14.Location = New System.Drawing.Point(0, 144)
        Me._Label0_14.Name = "_Label0_14"
        Me._Label0_14.Size = New System.Drawing.Size(28, 17)
        Me._Label0_14.TabIndex = 76
        Me._Label0_14.Tag = "No"
        Me._Label0_14.Text = "STT"
        Me._Label0_14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_15
        '
        Me._Label0_15.BackColor = System.Drawing.Color.White
        Me._Label0_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_15.Location = New System.Drawing.Point(27, 144)
        Me._Label0_15.Name = "_Label0_15"
        Me._Label0_15.Size = New System.Drawing.Size(414, 17)
        Me._Label0_15.TabIndex = 75
        Me._Label0_15.Tag = "The targets"
        Me._Label0_15.Text = "Chỉ tiêu"
        Me._Label0_15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_16
        '
        Me._Label0_16.BackColor = System.Drawing.Color.White
        Me._Label0_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_16.Location = New System.Drawing.Point(440, 144)
        Me._Label0_16.Name = "_Label0_16"
        Me._Label0_16.Size = New System.Drawing.Size(33, 17)
        Me._Label0_16.TabIndex = 74
        Me._Label0_16.Tag = "Code"
        Me._Label0_16.Text = "Mã số"
        Me._Label0_16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_17
        '
        Me._Label0_17.BackColor = System.Drawing.Color.White
        Me._Label0_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_17.Location = New System.Drawing.Point(473, 144)
        Me._Label0_17.Name = "_Label0_17"
        Me._Label0_17.Size = New System.Drawing.Size(81, 18)
        Me._Label0_17.TabIndex = 73
        Me._Label0_17.Tag = "Cash"
        Me._Label0_17.Text = "Số tiền"
        Me._Label0_17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_18
        '
        Me._Label0_18.BackColor = System.Drawing.Color.White
        Me._Label0_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_18.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_18.Location = New System.Drawing.Point(0, 160)
        Me._Label0_18.Name = "_Label0_18"
        Me._Label0_18.Size = New System.Drawing.Size(25, 17)
        Me._Label0_18.TabIndex = 72
        Me._Label0_18.Text = "(1)"
        Me._Label0_18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_19
        '
        Me._Label0_19.BackColor = System.Drawing.Color.White
        Me._Label0_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_19.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_19.Location = New System.Drawing.Point(27, 160)
        Me._Label0_19.Name = "_Label0_19"
        Me._Label0_19.Size = New System.Drawing.Size(414, 17)
        Me._Label0_19.TabIndex = 71
        Me._Label0_19.Text = "(2)"
        Me._Label0_19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_20
        '
        Me._Label0_20.BackColor = System.Drawing.Color.White
        Me._Label0_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_20.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_20.Location = New System.Drawing.Point(440, 160)
        Me._Label0_20.Name = "_Label0_20"
        Me._Label0_20.Size = New System.Drawing.Size(33, 17)
        Me._Label0_20.TabIndex = 70
        Me._Label0_20.Text = "(3)"
        Me._Label0_20.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_21
        '
        Me._Label0_21.BackColor = System.Drawing.Color.White
        Me._Label0_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_21.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_21.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_21.Location = New System.Drawing.Point(473, 160)
        Me._Label0_21.Name = "_Label0_21"
        Me._Label0_21.Size = New System.Drawing.Size(81, 17)
        Me._Label0_21.TabIndex = 69
        Me._Label0_21.Text = "(4)"
        Me._Label0_21.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_22
        '
        Me._Label0_22.BackColor = System.Drawing.Color.White
        Me._Label0_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_22.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_22.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_22.Location = New System.Drawing.Point(0, 176)
        Me._Label0_22.Name = "_Label0_22"
        Me._Label0_22.Size = New System.Drawing.Size(25, 17)
        Me._Label0_22.TabIndex = 68
        Me._Label0_22.Text = "A"
        Me._Label0_22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_50
        '
        Me._Label0_50.BackColor = System.Drawing.Color.White
        Me._Label0_50.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_50.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_50.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_50.Location = New System.Drawing.Point(27, 536)
        Me._Label0_50.Name = "_Label0_50"
        Me._Label0_50.Size = New System.Drawing.Size(413, 33)
        Me._Label0_50.TabIndex = 119
        Me._Label0_50.Tag = "The cost of advertising, marketing, promotion, reception festivities, the foreign" & _
            " transaction fees, brokerage commissions, expenses and other conference expenses" & _
            " exceeds the prescribed limit."
        Me._Label0_50.Text = "Chi phí quảng cáo, tiếp thị, khuyến mại, tiếp tân khánh tiết, chi phí giao dịch đ" & _
            "ối ngoại, chi hoa hồng môi giới, chi phí hội nghị và các loại chi phí khác vượt " & _
            "mức quy định"
        '
        '_Label0_49
        '
        Me._Label0_49.BackColor = System.Drawing.Color.White
        Me._Label0_49.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_49.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_49.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_49.Location = New System.Drawing.Point(0, 536)
        Me._Label0_49.Name = "_Label0_49"
        Me._Label0_49.Size = New System.Drawing.Size(25, 33)
        Me._Label0_49.TabIndex = 118
        Me._Label0_49.Text = "1.14"
        Me._Label0_49.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_52
        '
        Me._Label0_52.BackColor = System.Drawing.Color.White
        Me._Label0_52.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_52.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_52.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_52.Location = New System.Drawing.Point(27, 568)
        Me._Label0_52.Name = "_Label0_52"
        Me._Label0_52.Size = New System.Drawing.Size(413, 17)
        Me._Label0_52.TabIndex = 121
        Me._Label0_52.Tag = "Other adjustments to increase profit before tax."
        Me._Label0_52.Text = "Các khoản điều chỉnh làm tăng lợi nhuận trước thuế khác"
        '
        '_Label0_51
        '
        Me._Label0_51.BackColor = System.Drawing.Color.White
        Me._Label0_51.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_51.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_51.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_51.Location = New System.Drawing.Point(0, 568)
        Me._Label0_51.Name = "_Label0_51"
        Me._Label0_51.Size = New System.Drawing.Size(25, 17)
        Me._Label0_51.TabIndex = 120
        Me._Label0_51.Text = "1.15"
        Me._Label0_51.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_163
        '
        Me._Label0_163.BackColor = System.Drawing.Color.White
        Me._Label0_163.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_163.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_163.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_163.Location = New System.Drawing.Point(440, 568)
        Me._Label0_163.Name = "_Label0_163"
        Me._Label0_163.Size = New System.Drawing.Size(32, 17)
        Me._Label0_163.TabIndex = 231
        Me._Label0_163.Text = "B16"
        Me._Label0_163.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_162
        '
        Me._Label0_162.BackColor = System.Drawing.Color.White
        Me._Label0_162.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_162.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_162.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_162.Location = New System.Drawing.Point(440, 536)
        Me._Label0_162.Name = "_Label0_162"
        Me._Label0_162.Size = New System.Drawing.Size(32, 33)
        Me._Label0_162.TabIndex = 230
        Me._Label0_162.Text = "B15"
        Me._Label0_162.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_160
        '
        Me._Label0_160.BackColor = System.Drawing.Color.White
        Me._Label0_160.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_160.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_160.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_160.Location = New System.Drawing.Point(440, 224)
        Me._Label0_160.Name = "_Label0_160"
        Me._Label0_160.Size = New System.Drawing.Size(32, 17)
        Me._Label0_160.TabIndex = 229
        Me._Label0_160.Text = "B1"
        Me._Label0_160.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_158
        '
        Me._Label0_158.BackColor = System.Drawing.Color.White
        Me._Label0_158.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_158.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_158.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_158.Location = New System.Drawing.Point(440, 192)
        Me._Label0_158.Name = "_Label0_158"
        Me._Label0_158.Size = New System.Drawing.Size(32, 17)
        Me._Label0_158.TabIndex = 228
        Me._Label0_158.Text = "A1"
        Me._Label0_158.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_157
        '
        Me._Label0_157.BackColor = System.Drawing.Color.White
        Me._Label0_157.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_157.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_157.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_157.Location = New System.Drawing.Point(440, 240)
        Me._Label0_157.Name = "_Label0_157"
        Me._Label0_157.Size = New System.Drawing.Size(32, 17)
        Me._Label0_157.TabIndex = 227
        Me._Label0_157.Text = "B2"
        Me._Label0_157.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_156
        '
        Me._Label0_156.BackColor = System.Drawing.Color.White
        Me._Label0_156.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_156.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_156.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_156.Location = New System.Drawing.Point(440, 256)
        Me._Label0_156.Name = "_Label0_156"
        Me._Label0_156.Size = New System.Drawing.Size(32, 17)
        Me._Label0_156.TabIndex = 226
        Me._Label0_156.Text = "B3"
        Me._Label0_156.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_155
        '
        Me._Label0_155.BackColor = System.Drawing.Color.White
        Me._Label0_155.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_155.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_155.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_155.Location = New System.Drawing.Point(440, 272)
        Me._Label0_155.Name = "_Label0_155"
        Me._Label0_155.Size = New System.Drawing.Size(32, 17)
        Me._Label0_155.TabIndex = 225
        Me._Label0_155.Text = "B4"
        Me._Label0_155.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_154
        '
        Me._Label0_154.BackColor = System.Drawing.Color.White
        Me._Label0_154.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_154.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_154.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_154.Location = New System.Drawing.Point(440, 288)
        Me._Label0_154.Name = "_Label0_154"
        Me._Label0_154.Size = New System.Drawing.Size(32, 17)
        Me._Label0_154.TabIndex = 224
        Me._Label0_154.Text = "B5"
        Me._Label0_154.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_153
        '
        Me._Label0_153.BackColor = System.Drawing.Color.White
        Me._Label0_153.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_153.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_153.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_153.Location = New System.Drawing.Point(440, 304)
        Me._Label0_153.Name = "_Label0_153"
        Me._Label0_153.Size = New System.Drawing.Size(32, 17)
        Me._Label0_153.TabIndex = 223
        Me._Label0_153.Text = "B6"
        Me._Label0_153.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_152
        '
        Me._Label0_152.BackColor = System.Drawing.Color.White
        Me._Label0_152.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_152.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_152.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_152.Location = New System.Drawing.Point(440, 320)
        Me._Label0_152.Name = "_Label0_152"
        Me._Label0_152.Size = New System.Drawing.Size(32, 17)
        Me._Label0_152.TabIndex = 222
        Me._Label0_152.Text = "B7"
        Me._Label0_152.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_151
        '
        Me._Label0_151.BackColor = System.Drawing.Color.White
        Me._Label0_151.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_151.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_151.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_151.Location = New System.Drawing.Point(440, 336)
        Me._Label0_151.Name = "_Label0_151"
        Me._Label0_151.Size = New System.Drawing.Size(32, 17)
        Me._Label0_151.TabIndex = 221
        Me._Label0_151.Text = "B8"
        Me._Label0_151.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_150
        '
        Me._Label0_150.BackColor = System.Drawing.Color.White
        Me._Label0_150.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_150.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_150.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_150.Location = New System.Drawing.Point(440, 352)
        Me._Label0_150.Name = "_Label0_150"
        Me._Label0_150.Size = New System.Drawing.Size(32, 18)
        Me._Label0_150.TabIndex = 220
        Me._Label0_150.Text = "B9"
        Me._Label0_150.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_149
        '
        Me._Label0_149.BackColor = System.Drawing.Color.White
        Me._Label0_149.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_149.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_149.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_149.Location = New System.Drawing.Point(442, 368)
        Me._Label0_149.Name = "_Label0_149"
        Me._Label0_149.Size = New System.Drawing.Size(32, 57)
        Me._Label0_149.TabIndex = 219
        Me._Label0_149.Text = "      B10"
        Me._Label0_149.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_148
        '
        Me._Label0_148.BackColor = System.Drawing.Color.White
        Me._Label0_148.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_148.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_148.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_148.Location = New System.Drawing.Point(440, 456)
        Me._Label0_148.Name = "_Label0_148"
        Me._Label0_148.Size = New System.Drawing.Size(32, 17)
        Me._Label0_148.TabIndex = 218
        Me._Label0_148.Text = "B11"
        Me._Label0_148.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_147
        '
        Me._Label0_147.BackColor = System.Drawing.Color.White
        Me._Label0_147.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_147.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_147.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_147.Location = New System.Drawing.Point(440, 472)
        Me._Label0_147.Name = "_Label0_147"
        Me._Label0_147.Size = New System.Drawing.Size(32, 17)
        Me._Label0_147.TabIndex = 217
        Me._Label0_147.Text = "B12"
        Me._Label0_147.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_146
        '
        Me._Label0_146.BackColor = System.Drawing.Color.White
        Me._Label0_146.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_146.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_146.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_146.Location = New System.Drawing.Point(440, 488)
        Me._Label0_146.Name = "_Label0_146"
        Me._Label0_146.Size = New System.Drawing.Size(32, 17)
        Me._Label0_146.TabIndex = 216
        Me._Label0_146.Text = "B13"
        Me._Label0_146.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_145
        '
        Me._Label0_145.BackColor = System.Drawing.Color.White
        Me._Label0_145.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_145.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_145.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_145.Location = New System.Drawing.Point(440, 504)
        Me._Label0_145.Name = "_Label0_145"
        Me._Label0_145.Size = New System.Drawing.Size(32, 33)
        Me._Label0_145.TabIndex = 215
        Me._Label0_145.Text = "B14"
        Me._Label0_145.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_144
        '
        Me._Label0_144.BackColor = System.Drawing.Color.White
        Me._Label0_144.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_144.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_144.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_144.Location = New System.Drawing.Point(440, 584)
        Me._Label0_144.Name = "_Label0_144"
        Me._Label0_144.Size = New System.Drawing.Size(32, 41)
        Me._Label0_144.TabIndex = 214
        Me._Label0_144.Text = "B17"
        Me._Label0_144.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_140
        '
        Me._Label0_140.BackColor = System.Drawing.Color.White
        Me._Label0_140.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_140.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_140.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_140.Location = New System.Drawing.Point(440, 624)
        Me._Label0_140.Name = "_Label0_140"
        Me._Label0_140.Size = New System.Drawing.Size(32, 17)
        Me._Label0_140.TabIndex = 213
        Me._Label0_140.Text = "B18"
        Me._Label0_140.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_120
        '
        Me._Label0_120.BackColor = System.Drawing.Color.White
        Me._Label0_120.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_120.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_120.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_120.Location = New System.Drawing.Point(440, 640)
        Me._Label0_120.Name = "_Label0_120"
        Me._Label0_120.Size = New System.Drawing.Size(32, 17)
        Me._Label0_120.TabIndex = 212
        Me._Label0_120.Text = "B19"
        Me._Label0_120.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_1
        '
        Me._Label0_1.BackColor = System.Drawing.Color.White
        Me._Label0_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_1.Location = New System.Drawing.Point(-7, 16)
        Me._Label0_1.Name = "_Label0_1"
        Me._Label0_1.Size = New System.Drawing.Size(561, 17)
        Me._Label0_1.TabIndex = 88
        Me._Label0_1.Tag = "Independence - Freedom - Happiness"
        Me._Label0_1.Text = "Độc lập - Tự do - Hạnh phúc"
        Me._Label0_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_2
        '
        Me._Label0_2.BackColor = System.Drawing.Color.White
        Me._Label0_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_2.Location = New System.Drawing.Point(-7, 24)
        Me._Label0_2.Name = "_Label0_2"
        Me._Label0_2.Size = New System.Drawing.Size(561, 17)
        Me._Label0_2.TabIndex = 90
        Me._Label0_2.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _"
        Me._Label0_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Frame_2
        '
        Me._Frame_2.BackColor = System.Drawing.Color.White
        Me._Frame_2.Controls.Add(Me._chk_6)
        Me._Frame_2.Controls.Add(Me._chk_5)
        Me._Frame_2.Controls.Add(Me._chk_4)
        Me._Frame_2.Controls.Add(Me._chk_3)
        Me._Frame_2.Controls.Add(Me._chk_2)
        Me._Frame_2.Controls.Add(Me._Ngay_2)
        Me._Frame_2.Controls.Add(Me._Ngay_1)
        Me._Frame_2.Controls.Add(Me._Ngay_0)
        Me._Frame_2.Controls.Add(Me._TL_2)
        Me._Frame_2.Controls.Add(Me._Txt_20)
        Me._Frame_2.Controls.Add(Me._TL_1)
        Me._Frame_2.Controls.Add(Me._TL_0)
        Me._Frame_2.Controls.Add(Me._Txt_41)
        Me._Frame_2.Controls.Add(Me._Txt_40)
        Me._Frame_2.Controls.Add(Me._Txt_39)
        Me._Frame_2.Controls.Add(Me._Txt_38)
        Me._Frame_2.Controls.Add(Me._Txt_37)
        Me._Frame_2.Controls.Add(Me._Txt_36)
        Me._Frame_2.Controls.Add(Me._Txt_35)
        Me._Frame_2.Controls.Add(Me._Txt_34)
        Me._Frame_2.Controls.Add(Me._Txt_33)
        Me._Frame_2.Controls.Add(Me._Txt_32)
        Me._Frame_2.Controls.Add(Me._Txt_31)
        Me._Frame_2.Controls.Add(Me._Txt_30)
        Me._Frame_2.Controls.Add(Me._Txt_29)
        Me._Frame_2.Controls.Add(Me._Txt_28)
        Me._Frame_2.Controls.Add(Me._Txt_27)
        Me._Frame_2.Controls.Add(Me._Txt_26)
        Me._Frame_2.Controls.Add(Me._Txt_25)
        Me._Frame_2.Controls.Add(Me._Txt_24)
        Me._Frame_2.Controls.Add(Me._Txt_23)
        Me._Frame_2.Controls.Add(Me._Txt_22)
        Me._Frame_2.Controls.Add(Me._Txt_21)
        Me._Frame_2.Controls.Add(Me._chk_1)
        Me._Frame_2.Controls.Add(Me._Line_52)
        Me._Frame_2.Controls.Add(Me._Line_30)
        Me._Frame_2.Controls.Add(Me._Line_65)
        Me._Frame_2.Controls.Add(Me.Line1)
        Me._Frame_2.Controls.Add(Me._Line_64)
        Me._Frame_2.Controls.Add(Me._Line_63)
        Me._Frame_2.Controls.Add(Me._Line_62)
        Me._Frame_2.Controls.Add(Me._Line_61)
        Me._Frame_2.Controls.Add(Me._Line_60)
        Me._Frame_2.Controls.Add(Me._Label0_119)
        Me._Frame_2.Controls.Add(Me._Line_59)
        Me._Frame_2.Controls.Add(Me._Line_58)
        Me._Frame_2.Controls.Add(Me._Line_57)
        Me._Frame_2.Controls.Add(Me._Line_56)
        Me._Frame_2.Controls.Add(Me._Line_55)
        Me._Frame_2.Controls.Add(Me._Line_54)
        Me._Frame_2.Controls.Add(Me._Line_53)
        Me._Frame_2.Controls.Add(Me._Line_51)
        Me._Frame_2.Controls.Add(Me._Line_50)
        Me._Frame_2.Controls.Add(Me._Line_49)
        Me._Frame_2.Controls.Add(Me._Line_48)
        Me._Frame_2.Controls.Add(Me._Line_47)
        Me._Frame_2.Controls.Add(Me._Line_46)
        Me._Frame_2.Controls.Add(Me._Line_45)
        Me._Frame_2.Controls.Add(Me._Line_44)
        Me._Frame_2.Controls.Add(Me._Line_43)
        Me._Frame_2.Controls.Add(Me._Line_42)
        Me._Frame_2.Controls.Add(Me._Line_41)
        Me._Frame_2.Controls.Add(Me._Line_40)
        Me._Frame_2.Controls.Add(Me._Line_39)
        Me._Frame_2.Controls.Add(Me._Line_38)
        Me._Frame_2.Controls.Add(Me._Line_37)
        Me._Frame_2.Controls.Add(Me._Line_36)
        Me._Frame_2.Controls.Add(Me._Line_35)
        Me._Frame_2.Controls.Add(Me._Line_34)
        Me._Frame_2.Controls.Add(Me._Line_33)
        Me._Frame_2.Controls.Add(Me._Line_32)
        Me._Frame_2.Controls.Add(Me._Line_31)
        Me._Frame_2.Controls.Add(Me._Label0_118)
        Me._Frame_2.Controls.Add(Me._Label0_112)
        Me._Frame_2.Controls.Add(Me._Label0_111)
        Me._Frame_2.Controls.Add(Me._Label0_110)
        Me._Frame_2.Controls.Add(Me._Label0_109)
        Me._Frame_2.Controls.Add(Me._Label0_108)
        Me._Frame_2.Controls.Add(Me._Label0_107)
        Me._Frame_2.Controls.Add(Me._Label0_106)
        Me._Frame_2.Controls.Add(Me._Label0_105)
        Me._Frame_2.Controls.Add(Me._Label0_97)
        Me._Frame_2.Controls.Add(Me._Label0_96)
        Me._Frame_2.Controls.Add(Me._Label0_95)
        Me._Frame_2.Controls.Add(Me._Label0_94)
        Me._Frame_2.Controls.Add(Me._Label0_93)
        Me._Frame_2.Controls.Add(Me._Label0_92)
        Me._Frame_2.Controls.Add(Me._Label0_91)
        Me._Frame_2.Controls.Add(Me._Label0_115)
        Me._Frame_2.Controls.Add(Me._Label0_114)
        Me._Frame_2.Controls.Add(Me._Label0_113)
        Me._Frame_2.Controls.Add(Me._Label0_104)
        Me._Frame_2.Controls.Add(Me._Label0_103)
        Me._Frame_2.Controls.Add(Me._Label0_102)
        Me._Frame_2.Controls.Add(Me._Label0_101)
        Me._Frame_2.Controls.Add(Me._Label0_99)
        Me._Frame_2.Controls.Add(Me._Label0_98)
        Me._Frame_2.Controls.Add(Me._Label0_90)
        Me._Frame_2.Controls.Add(Me._Label0_89)
        Me._Frame_2.Controls.Add(Me._Label0_88)
        Me._Frame_2.Controls.Add(Me._Label0_87)
        Me._Frame_2.Controls.Add(Me._Label0_86)
        Me._Frame_2.Controls.Add(Me._Label0_85)
        Me._Frame_2.Controls.Add(Me._Label0_84)
        Me._Frame_2.Controls.Add(Me._Label0_83)
        Me._Frame_2.Controls.Add(Me._Label0_82)
        Me._Frame_2.Controls.Add(Me._Label0_81)
        Me._Frame_2.Controls.Add(Me._Label0_80)
        Me._Frame_2.Controls.Add(Me._Label0_79)
        Me._Frame_2.Controls.Add(Me._Label0_78)
        Me._Frame_2.Controls.Add(Me._Label0_77)
        Me._Frame_2.Controls.Add(Me._Label0_76)
        Me._Frame_2.Controls.Add(Me._Label0_75)
        Me._Frame_2.Controls.Add(Me._Label0_74)
        Me._Frame_2.Controls.Add(Me._Label0_73)
        Me._Frame_2.Controls.Add(Me._Label0_72)
        Me._Frame_2.Controls.Add(Me._Label0_71)
        Me._Frame_2.Controls.Add(Me._Label0_70)
        Me._Frame_2.Controls.Add(Me._Label0_69)
        Me._Frame_2.Controls.Add(Me._Label0_68)
        Me._Frame_2.Controls.Add(Me._Label0_67)
        Me._Frame_2.Controls.Add(Me._Label0_66)
        Me._Frame_2.Controls.Add(Me._Label0_65)
        Me._Frame_2.Controls.Add(Me._Label0_64)
        Me._Frame_2.Controls.Add(Me._Label0_63)
        Me._Frame_2.Controls.Add(Me._Label0_62)
        Me._Frame_2.Controls.Add(Me._Label0_61)
        Me._Frame_2.Controls.Add(Me._Label0_60)
        Me._Frame_2.Controls.Add(Me._Label0_59)
        Me._Frame_2.Controls.Add(Me._Label0_116)
        Me._Frame_2.Controls.Add(Me._Label0_117)
        Me._Frame_2.Controls.Add(Me._Label0_100)
        Me._Frame_2.Controls.Add(Me._Label0_143)
        Me._Frame_2.Controls.Add(Me._Label0_142)
        Me._Frame_2.Controls.Add(Me._Label0_141)
        Me._Frame_2.Controls.Add(Me._Label0_139)
        Me._Frame_2.Controls.Add(Me._Label0_138)
        Me._Frame_2.Controls.Add(Me._Label0_137)
        Me._Frame_2.Controls.Add(Me._Label0_136)
        Me._Frame_2.Controls.Add(Me._Label0_135)
        Me._Frame_2.Controls.Add(Me._Label0_134)
        Me._Frame_2.Controls.Add(Me._Label0_133)
        Me._Frame_2.Controls.Add(Me._Label0_132)
        Me._Frame_2.Controls.Add(Me._Label0_131)
        Me._Frame_2.Controls.Add(Me._Label0_130)
        Me._Frame_2.Controls.Add(Me._Label0_129)
        Me._Frame_2.Controls.Add(Me._Label0_128)
        Me._Frame_2.Controls.Add(Me._Label0_127)
        Me._Frame_2.Controls.Add(Me._Label0_126)
        Me._Frame_2.Controls.Add(Me._Label0_125)
        Me._Frame_2.Controls.Add(Me._Label0_124)
        Me._Frame_2.Controls.Add(Me._Label0_123)
        Me._Frame_2.Controls.Add(Me._Label0_122)
        Me._Frame_2.Controls.Add(Me._Label0_121)
        Me._Frame_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Frame_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_2.Location = New System.Drawing.Point(13, 16)
        Me._Frame_2.Name = "_Frame_2"
        Me._Frame_2.Size = New System.Drawing.Size(554, 657)
        Me._Frame_2.TabIndex = 128
        '
        '_chk_6
        '
        Me._chk_6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._chk_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._chk_6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chk_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chk_6.Location = New System.Drawing.Point(27, 616)
        Me._chk_6.Name = "_chk_6"
        Me._chk_6.Size = New System.Drawing.Size(14, 17)
        Me._chk_6.TabIndex = 54
        Me._chk_6.UseVisualStyleBackColor = False
        '
        '_chk_5
        '
        Me._chk_5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._chk_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._chk_5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chk_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chk_5.Location = New System.Drawing.Point(27, 584)
        Me._chk_5.Name = "_chk_5"
        Me._chk_5.Size = New System.Drawing.Size(14, 17)
        Me._chk_5.TabIndex = 53
        Me._chk_5.UseVisualStyleBackColor = False
        '
        '_chk_4
        '
        Me._chk_4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._chk_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._chk_4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chk_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chk_4.Location = New System.Drawing.Point(27, 568)
        Me._chk_4.Name = "_chk_4"
        Me._chk_4.Size = New System.Drawing.Size(14, 17)
        Me._chk_4.TabIndex = 52
        Me._chk_4.UseVisualStyleBackColor = False
        '
        '_chk_3
        '
        Me._chk_3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._chk_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._chk_3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chk_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chk_3.Location = New System.Drawing.Point(27, 552)
        Me._chk_3.Name = "_chk_3"
        Me._chk_3.Size = New System.Drawing.Size(14, 17)
        Me._chk_3.TabIndex = 51
        Me._chk_3.UseVisualStyleBackColor = False
        '
        '_chk_2
        '
        Me._chk_2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._chk_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._chk_2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chk_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chk_2.Location = New System.Drawing.Point(27, 520)
        Me._chk_2.Name = "_chk_2"
        Me._chk_2.Size = New System.Drawing.Size(14, 17)
        Me._chk_2.TabIndex = 50
        Me._chk_2.UseVisualStyleBackColor = False
        '
        '_Ngay_2
        '
        Me._Ngay_2.AcceptsReturn = True
        Me._Ngay_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Ngay_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Ngay_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Ngay_2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Ngay_2.Location = New System.Drawing.Point(517, 636)
        Me._Ngay_2.MaxLength = 100
        Me._Ngay_2.Name = "_Ngay_2"
        Me._Ngay_2.Size = New System.Drawing.Size(25, 14)
        Me._Ngay_2.TabIndex = 57
        Me._Ngay_2.Text = "0000"
        Me._Ngay_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Ngay_1
        '
        Me._Ngay_1.AcceptsReturn = True
        Me._Ngay_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Ngay_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Ngay_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Ngay_1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Ngay_1.Location = New System.Drawing.Point(481, 636)
        Me._Ngay_1.MaxLength = 100
        Me._Ngay_1.Name = "_Ngay_1"
        Me._Ngay_1.Size = New System.Drawing.Size(12, 14)
        Me._Ngay_1.TabIndex = 56
        Me._Ngay_1.Text = "0"
        Me._Ngay_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Ngay_0
        '
        Me._Ngay_0.AcceptsReturn = True
        Me._Ngay_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Ngay_0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Ngay_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Ngay_0.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Ngay_0.Location = New System.Drawing.Point(440, 636)
        Me._Ngay_0.MaxLength = 100
        Me._Ngay_0.Name = "_Ngay_0"
        Me._Ngay_0.Size = New System.Drawing.Size(12, 14)
        Me._Ngay_0.TabIndex = 55
        Me._Ngay_0.Text = "0"
        Me._Ngay_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_TL_2
        '
        Me._TL_2.AcceptsReturn = True
        Me._TL_2.BackColor = System.Drawing.Color.LightCyan
        Me._TL_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TL_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TL_2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TL_2.Location = New System.Drawing.Point(73, 408)
        Me._TL_2.MaxLength = 100
        Me._TL_2.Name = "_TL_2"
        Me._TL_2.Size = New System.Drawing.Size(13, 14)
        Me._TL_2.TabIndex = 48
        Me._TL_2.Text = "0"
        Me._TL_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_20
        '
        Me._Txt_20.AcceptsReturn = True
        Me._Txt_20.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_20.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_20.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_20.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_20.Location = New System.Drawing.Point(474, 1)
        Me._Txt_20.MaxLength = 100
        Me._Txt_20.Name = "_Txt_20"
        Me._Txt_20.Size = New System.Drawing.Size(80, 14)
        Me._Txt_20.TabIndex = 24
        Me._Txt_20.Text = "0"
        Me._Txt_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_TL_1
        '
        Me._TL_1.AcceptsReturn = True
        Me._TL_1.BackColor = System.Drawing.Color.LightCyan
        Me._TL_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TL_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TL_1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TL_1.Location = New System.Drawing.Point(303, 304)
        Me._TL_1.MaxLength = 100
        Me._TL_1.Name = "_TL_1"
        Me._TL_1.Size = New System.Drawing.Size(13, 14)
        Me._TL_1.TabIndex = 47
        Me._TL_1.Text = "0"
        Me._TL_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_TL_0
        '
        Me._TL_0.AcceptsReturn = True
        Me._TL_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._TL_0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TL_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TL_0.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TL_0.Location = New System.Drawing.Point(357, 288)
        Me._TL_0.MaxLength = 100
        Me._TL_0.Name = "_TL_0"
        Me._TL_0.Size = New System.Drawing.Size(12, 14)
        Me._TL_0.TabIndex = 46
        Me._TL_0.Text = "0"
        Me._TL_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_41
        '
        Me._Txt_41.AcceptsReturn = True
        Me._Txt_41.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_41.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_41.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_41.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_41.Location = New System.Drawing.Point(474, 473)
        Me._Txt_41.MaxLength = 100
        Me._Txt_41.Name = "_Txt_41"
        Me._Txt_41.Size = New System.Drawing.Size(80, 14)
        Me._Txt_41.TabIndex = 45
        Me._Txt_41.Text = "0"
        Me._Txt_41.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_40
        '
        Me._Txt_40.AcceptsReturn = True
        Me._Txt_40.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_40.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_40.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_40.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_40.Location = New System.Drawing.Point(474, 441)
        Me._Txt_40.MaxLength = 100
        Me._Txt_40.Name = "_Txt_40"
        Me._Txt_40.Size = New System.Drawing.Size(80, 14)
        Me._Txt_40.TabIndex = 44
        Me._Txt_40.Text = "0"
        Me._Txt_40.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_39
        '
        Me._Txt_39.AcceptsReturn = True
        Me._Txt_39.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_39.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_39.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_39.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_39.Location = New System.Drawing.Point(474, 425)
        Me._Txt_39.MaxLength = 100
        Me._Txt_39.Name = "_Txt_39"
        Me._Txt_39.Size = New System.Drawing.Size(80, 14)
        Me._Txt_39.TabIndex = 43
        Me._Txt_39.Text = "0"
        Me._Txt_39.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_38
        '
        Me._Txt_38.AcceptsReturn = True
        Me._Txt_38.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_38.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_38.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_38.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_38.Location = New System.Drawing.Point(473, 393)
        Me._Txt_38.MaxLength = 100
        Me._Txt_38.Name = "_Txt_38"
        Me._Txt_38.Size = New System.Drawing.Size(80, 14)
        Me._Txt_38.TabIndex = 42
        Me._Txt_38.Text = "0"
        Me._Txt_38.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_37
        '
        Me._Txt_37.AcceptsReturn = True
        Me._Txt_37.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_37.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_37.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_37.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_37.Location = New System.Drawing.Point(474, 353)
        Me._Txt_37.MaxLength = 100
        Me._Txt_37.Name = "_Txt_37"
        Me._Txt_37.Size = New System.Drawing.Size(80, 14)
        Me._Txt_37.TabIndex = 41
        Me._Txt_37.Text = "0"
        Me._Txt_37.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_36
        '
        Me._Txt_36.AcceptsReturn = True
        Me._Txt_36.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_36.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_36.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_36.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_36.Location = New System.Drawing.Point(474, 337)
        Me._Txt_36.MaxLength = 100
        Me._Txt_36.Name = "_Txt_36"
        Me._Txt_36.Size = New System.Drawing.Size(80, 14)
        Me._Txt_36.TabIndex = 40
        Me._Txt_36.Text = "0"
        Me._Txt_36.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_35
        '
        Me._Txt_35.AcceptsReturn = True
        Me._Txt_35.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_35.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_35.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_35.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_35.Location = New System.Drawing.Point(474, 321)
        Me._Txt_35.MaxLength = 100
        Me._Txt_35.Name = "_Txt_35"
        Me._Txt_35.Size = New System.Drawing.Size(80, 14)
        Me._Txt_35.TabIndex = 39
        Me._Txt_35.Text = "0"
        Me._Txt_35.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_34
        '
        Me._Txt_34.AcceptsReturn = True
        Me._Txt_34.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_34.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_34.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_34.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_34.Location = New System.Drawing.Point(474, 305)
        Me._Txt_34.MaxLength = 100
        Me._Txt_34.Name = "_Txt_34"
        Me._Txt_34.Size = New System.Drawing.Size(80, 14)
        Me._Txt_34.TabIndex = 38
        Me._Txt_34.Text = "0"
        Me._Txt_34.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_33
        '
        Me._Txt_33.AcceptsReturn = True
        Me._Txt_33.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_33.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_33.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_33.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_33.Location = New System.Drawing.Point(474, 289)
        Me._Txt_33.MaxLength = 100
        Me._Txt_33.Name = "_Txt_33"
        Me._Txt_33.Size = New System.Drawing.Size(80, 14)
        Me._Txt_33.TabIndex = 37
        Me._Txt_33.Text = "0"
        Me._Txt_33.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_32
        '
        Me._Txt_32.AcceptsReturn = True
        Me._Txt_32.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_32.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_32.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_32.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_32.Location = New System.Drawing.Point(474, 273)
        Me._Txt_32.MaxLength = 100
        Me._Txt_32.Name = "_Txt_32"
        Me._Txt_32.Size = New System.Drawing.Size(80, 14)
        Me._Txt_32.TabIndex = 36
        Me._Txt_32.Text = "0"
        Me._Txt_32.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_31
        '
        Me._Txt_31.AcceptsReturn = True
        Me._Txt_31.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_31.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_31.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_31.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_31.Location = New System.Drawing.Point(474, 225)
        Me._Txt_31.MaxLength = 100
        Me._Txt_31.Name = "_Txt_31"
        Me._Txt_31.Size = New System.Drawing.Size(80, 14)
        Me._Txt_31.TabIndex = 35
        Me._Txt_31.Text = "0"
        Me._Txt_31.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_30
        '
        Me._Txt_30.AcceptsReturn = True
        Me._Txt_30.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_30.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_30.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_30.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_30.Location = New System.Drawing.Point(474, 193)
        Me._Txt_30.MaxLength = 100
        Me._Txt_30.Name = "_Txt_30"
        Me._Txt_30.Size = New System.Drawing.Size(80, 14)
        Me._Txt_30.TabIndex = 34
        Me._Txt_30.Text = "0"
        Me._Txt_30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_29
        '
        Me._Txt_29.AcceptsReturn = True
        Me._Txt_29.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_29.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_29.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_29.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_29.Location = New System.Drawing.Point(474, 177)
        Me._Txt_29.MaxLength = 100
        Me._Txt_29.Name = "_Txt_29"
        Me._Txt_29.Size = New System.Drawing.Size(80, 14)
        Me._Txt_29.TabIndex = 33
        Me._Txt_29.Text = "0"
        Me._Txt_29.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_28
        '
        Me._Txt_28.AcceptsReturn = True
        Me._Txt_28.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_28.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_28.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_28.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_28.Location = New System.Drawing.Point(474, 161)
        Me._Txt_28.MaxLength = 100
        Me._Txt_28.Name = "_Txt_28"
        Me._Txt_28.Size = New System.Drawing.Size(80, 14)
        Me._Txt_28.TabIndex = 32
        Me._Txt_28.Text = "0"
        Me._Txt_28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_27
        '
        Me._Txt_27.AcceptsReturn = True
        Me._Txt_27.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_27.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_27.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_27.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_27.Location = New System.Drawing.Point(474, 145)
        Me._Txt_27.MaxLength = 100
        Me._Txt_27.Name = "_Txt_27"
        Me._Txt_27.Size = New System.Drawing.Size(80, 14)
        Me._Txt_27.TabIndex = 31
        Me._Txt_27.Text = "0"
        Me._Txt_27.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_26
        '
        Me._Txt_26.AcceptsReturn = True
        Me._Txt_26.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_26.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_26.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_26.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_26.Location = New System.Drawing.Point(474, 129)
        Me._Txt_26.MaxLength = 100
        Me._Txt_26.Name = "_Txt_26"
        Me._Txt_26.Size = New System.Drawing.Size(80, 14)
        Me._Txt_26.TabIndex = 30
        Me._Txt_26.Text = "0"
        Me._Txt_26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_25
        '
        Me._Txt_25.AcceptsReturn = True
        Me._Txt_25.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_25.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_25.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_25.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_25.Location = New System.Drawing.Point(474, 113)
        Me._Txt_25.MaxLength = 100
        Me._Txt_25.Name = "_Txt_25"
        Me._Txt_25.Size = New System.Drawing.Size(80, 14)
        Me._Txt_25.TabIndex = 29
        Me._Txt_25.Text = "0"
        Me._Txt_25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_24
        '
        Me._Txt_24.AcceptsReturn = True
        Me._Txt_24.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_24.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_24.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_24.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_24.Location = New System.Drawing.Point(474, 81)
        Me._Txt_24.MaxLength = 100
        Me._Txt_24.Name = "_Txt_24"
        Me._Txt_24.Size = New System.Drawing.Size(80, 14)
        Me._Txt_24.TabIndex = 28
        Me._Txt_24.Text = "0"
        Me._Txt_24.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_23
        '
        Me._Txt_23.AcceptsReturn = True
        Me._Txt_23.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_23.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_23.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_23.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_23.Location = New System.Drawing.Point(474, 65)
        Me._Txt_23.MaxLength = 100
        Me._Txt_23.Name = "_Txt_23"
        Me._Txt_23.Size = New System.Drawing.Size(80, 14)
        Me._Txt_23.TabIndex = 27
        Me._Txt_23.Text = "0"
        Me._Txt_23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_22
        '
        Me._Txt_22.AcceptsReturn = True
        Me._Txt_22.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_22.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_22.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_22.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_22.Location = New System.Drawing.Point(474, 49)
        Me._Txt_22.MaxLength = 100
        Me._Txt_22.Name = "_Txt_22"
        Me._Txt_22.Size = New System.Drawing.Size(80, 14)
        Me._Txt_22.TabIndex = 26
        Me._Txt_22.Text = "0"
        Me._Txt_22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Txt_21
        '
        Me._Txt_21.AcceptsReturn = True
        Me._Txt_21.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Txt_21.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._Txt_21.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_21.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_21.Location = New System.Drawing.Point(474, 17)
        Me._Txt_21.MaxLength = 100
        Me._Txt_21.Name = "_Txt_21"
        Me._Txt_21.Size = New System.Drawing.Size(80, 14)
        Me._Txt_21.TabIndex = 25
        Me._Txt_21.Text = "0"
        Me._Txt_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_chk_1
        '
        Me._chk_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._chk_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._chk_1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chk_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chk_1.Location = New System.Drawing.Point(27, 504)
        Me._chk_1.Name = "_chk_1"
        Me._chk_1.Size = New System.Drawing.Size(14, 17)
        Me._chk_1.TabIndex = 49
        Me._chk_1.UseVisualStyleBackColor = False
        '
        '_Line_52
        '
        Me._Line_52.Enabled = False
        Me._Line_52.Location = New System.Drawing.Point(0, 520)
        Me._Line_52.Name = "_Line_52"
        Me._Line_52.Size = New System.Drawing.Size(553, 1)
        Me._Line_52.TabIndex = 58
        '
        '_Line_30
        '
        Me._Line_30.Enabled = False
        Me._Line_30.Location = New System.Drawing.Point(0, 0)
        Me._Line_30.Name = "_Line_30"
        Me._Line_30.Size = New System.Drawing.Size(553, 1)
        Me._Line_30.TabIndex = 59
        '
        '_Line_65
        '
        Me._Line_65.Enabled = False
        Me._Line_65.Location = New System.Drawing.Point(0, 616)
        Me._Line_65.Name = "_Line_65"
        Me._Line_65.Size = New System.Drawing.Size(553, 1)
        Me._Line_65.TabIndex = 60
        '
        'Line1
        '
        Me.Line1.Enabled = False
        Me.Line1.Location = New System.Drawing.Point(47, 504)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(0, 128)
        Me.Line1.TabIndex = 61
        '
        '_Line_64
        '
        Me._Line_64.Enabled = False
        Me._Line_64.Location = New System.Drawing.Point(473, 0)
        Me._Line_64.Name = "_Line_64"
        Me._Line_64.Size = New System.Drawing.Size(1, 488)
        Me._Line_64.TabIndex = 62
        '
        '_Line_63
        '
        Me._Line_63.Enabled = False
        Me._Line_63.Location = New System.Drawing.Point(440, 0)
        Me._Line_63.Name = "_Line_63"
        Me._Line_63.Size = New System.Drawing.Size(1, 488)
        Me._Line_63.TabIndex = 63
        '
        '_Line_62
        '
        Me._Line_62.Enabled = False
        Me._Line_62.Location = New System.Drawing.Point(553, 0)
        Me._Line_62.Name = "_Line_62"
        Me._Line_62.Size = New System.Drawing.Size(1, 632)
        Me._Line_62.TabIndex = 64
        '
        '_Line_61
        '
        Me._Line_61.Enabled = False
        Me._Line_61.Location = New System.Drawing.Point(25, 0)
        Me._Line_61.Name = "_Line_61"
        Me._Line_61.Size = New System.Drawing.Size(1, 632)
        Me._Line_61.TabIndex = 65
        '
        '_Line_60
        '
        Me._Line_60.Enabled = False
        Me._Line_60.Location = New System.Drawing.Point(0, 0)
        Me._Line_60.Name = "_Line_60"
        Me._Line_60.Size = New System.Drawing.Size(1, 632)
        Me._Line_60.TabIndex = 66
        '
        '_Label0_119
        '
        Me._Label0_119.AutoSize = True
        Me._Label0_119.BackColor = System.Drawing.Color.White
        Me._Label0_119.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_119.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_119.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_119.Location = New System.Drawing.Point(413, 636)
        Me._Label0_119.Name = "_Label0_119"
        Me._Label0_119.Size = New System.Drawing.Size(125, 15)
        Me._Label0_119.TabIndex = 189
        Me._Label0_119.Tag = "Date       month       year"
        Me._Label0_119.Text = "Ngày      tháng      năm"
        '
        '_Line_59
        '
        Me._Line_59.Enabled = False
        Me._Line_59.Location = New System.Drawing.Point(0, 632)
        Me._Line_59.Name = "_Line_59"
        Me._Line_59.Size = New System.Drawing.Size(553, 1)
        Me._Line_59.TabIndex = 190
        '
        '_Line_58
        '
        Me._Line_58.Enabled = False
        Me._Line_58.Location = New System.Drawing.Point(0, 584)
        Me._Line_58.Name = "_Line_58"
        Me._Line_58.Size = New System.Drawing.Size(553, 1)
        Me._Line_58.TabIndex = 191
        '
        '_Line_57
        '
        Me._Line_57.Enabled = False
        Me._Line_57.Location = New System.Drawing.Point(0, 568)
        Me._Line_57.Name = "_Line_57"
        Me._Line_57.Size = New System.Drawing.Size(553, 1)
        Me._Line_57.TabIndex = 192
        '
        '_Line_56
        '
        Me._Line_56.Enabled = False
        Me._Line_56.Location = New System.Drawing.Point(0, 552)
        Me._Line_56.Name = "_Line_56"
        Me._Line_56.Size = New System.Drawing.Size(553, 1)
        Me._Line_56.TabIndex = 193
        '
        '_Line_55
        '
        Me._Line_55.Enabled = False
        Me._Line_55.Location = New System.Drawing.Point(0, 504)
        Me._Line_55.Name = "_Line_55"
        Me._Line_55.Size = New System.Drawing.Size(553, 1)
        Me._Line_55.TabIndex = 194
        '
        '_Line_54
        '
        Me._Line_54.Enabled = False
        Me._Line_54.Location = New System.Drawing.Point(0, 488)
        Me._Line_54.Name = "_Line_54"
        Me._Line_54.Size = New System.Drawing.Size(553, 1)
        Me._Line_54.TabIndex = 195
        '
        '_Line_53
        '
        Me._Line_53.Enabled = False
        Me._Line_53.Location = New System.Drawing.Point(0, 472)
        Me._Line_53.Name = "_Line_53"
        Me._Line_53.Size = New System.Drawing.Size(553, 1)
        Me._Line_53.TabIndex = 196
        '
        '_Line_51
        '
        Me._Line_51.Enabled = False
        Me._Line_51.Location = New System.Drawing.Point(0, 440)
        Me._Line_51.Name = "_Line_51"
        Me._Line_51.Size = New System.Drawing.Size(553, 1)
        Me._Line_51.TabIndex = 197
        '
        '_Line_50
        '
        Me._Line_50.Enabled = False
        Me._Line_50.Location = New System.Drawing.Point(0, 424)
        Me._Line_50.Name = "_Line_50"
        Me._Line_50.Size = New System.Drawing.Size(553, 1)
        Me._Line_50.TabIndex = 198
        '
        '_Line_49
        '
        Me._Line_49.Enabled = False
        Me._Line_49.Location = New System.Drawing.Point(0, 392)
        Me._Line_49.Name = "_Line_49"
        Me._Line_49.Size = New System.Drawing.Size(553, 1)
        Me._Line_49.TabIndex = 199
        '
        '_Line_48
        '
        Me._Line_48.Enabled = False
        Me._Line_48.Location = New System.Drawing.Point(0, 352)
        Me._Line_48.Name = "_Line_48"
        Me._Line_48.Size = New System.Drawing.Size(553, 1)
        Me._Line_48.TabIndex = 200
        '
        '_Line_47
        '
        Me._Line_47.Enabled = False
        Me._Line_47.Location = New System.Drawing.Point(0, 336)
        Me._Line_47.Name = "_Line_47"
        Me._Line_47.Size = New System.Drawing.Size(553, 1)
        Me._Line_47.TabIndex = 201
        '
        '_Line_46
        '
        Me._Line_46.Enabled = False
        Me._Line_46.Location = New System.Drawing.Point(0, 320)
        Me._Line_46.Name = "_Line_46"
        Me._Line_46.Size = New System.Drawing.Size(553, 1)
        Me._Line_46.TabIndex = 202
        '
        '_Line_45
        '
        Me._Line_45.Enabled = False
        Me._Line_45.Location = New System.Drawing.Point(0, 304)
        Me._Line_45.Name = "_Line_45"
        Me._Line_45.Size = New System.Drawing.Size(553, 1)
        Me._Line_45.TabIndex = 203
        '
        '_Line_44
        '
        Me._Line_44.Enabled = False
        Me._Line_44.Location = New System.Drawing.Point(0, 288)
        Me._Line_44.Name = "_Line_44"
        Me._Line_44.Size = New System.Drawing.Size(553, 1)
        Me._Line_44.TabIndex = 204
        '
        '_Line_43
        '
        Me._Line_43.Enabled = False
        Me._Line_43.Location = New System.Drawing.Point(0, 272)
        Me._Line_43.Name = "_Line_43"
        Me._Line_43.Size = New System.Drawing.Size(553, 1)
        Me._Line_43.TabIndex = 205
        '
        '_Line_42
        '
        Me._Line_42.Enabled = False
        Me._Line_42.Location = New System.Drawing.Point(0, 256)
        Me._Line_42.Name = "_Line_42"
        Me._Line_42.Size = New System.Drawing.Size(553, 1)
        Me._Line_42.TabIndex = 206
        '
        '_Line_41
        '
        Me._Line_41.Enabled = False
        Me._Line_41.Location = New System.Drawing.Point(0, 224)
        Me._Line_41.Name = "_Line_41"
        Me._Line_41.Size = New System.Drawing.Size(553, 1)
        Me._Line_41.TabIndex = 207
        '
        '_Line_40
        '
        Me._Line_40.Enabled = False
        Me._Line_40.Location = New System.Drawing.Point(0, 192)
        Me._Line_40.Name = "_Line_40"
        Me._Line_40.Size = New System.Drawing.Size(553, 1)
        Me._Line_40.TabIndex = 208
        '
        '_Line_39
        '
        Me._Line_39.Enabled = False
        Me._Line_39.Location = New System.Drawing.Point(0, 176)
        Me._Line_39.Name = "_Line_39"
        Me._Line_39.Size = New System.Drawing.Size(553, 1)
        Me._Line_39.TabIndex = 209
        '
        '_Line_38
        '
        Me._Line_38.Enabled = False
        Me._Line_38.Location = New System.Drawing.Point(0, 160)
        Me._Line_38.Name = "_Line_38"
        Me._Line_38.Size = New System.Drawing.Size(553, 1)
        Me._Line_38.TabIndex = 210
        '
        '_Line_37
        '
        Me._Line_37.Enabled = False
        Me._Line_37.Location = New System.Drawing.Point(0, 144)
        Me._Line_37.Name = "_Line_37"
        Me._Line_37.Size = New System.Drawing.Size(553, 1)
        Me._Line_37.TabIndex = 211
        '
        '_Line_36
        '
        Me._Line_36.Enabled = False
        Me._Line_36.Location = New System.Drawing.Point(0, 128)
        Me._Line_36.Name = "_Line_36"
        Me._Line_36.Size = New System.Drawing.Size(553, 1)
        Me._Line_36.TabIndex = 212
        '
        '_Line_35
        '
        Me._Line_35.Enabled = False
        Me._Line_35.Location = New System.Drawing.Point(0, 112)
        Me._Line_35.Name = "_Line_35"
        Me._Line_35.Size = New System.Drawing.Size(553, 1)
        Me._Line_35.TabIndex = 213
        '
        '_Line_34
        '
        Me._Line_34.Enabled = False
        Me._Line_34.Location = New System.Drawing.Point(0, 80)
        Me._Line_34.Name = "_Line_34"
        Me._Line_34.Size = New System.Drawing.Size(553, 1)
        Me._Line_34.TabIndex = 214
        '
        '_Line_33
        '
        Me._Line_33.Enabled = False
        Me._Line_33.Location = New System.Drawing.Point(0, 64)
        Me._Line_33.Name = "_Line_33"
        Me._Line_33.Size = New System.Drawing.Size(553, 1)
        Me._Line_33.TabIndex = 215
        '
        '_Line_32
        '
        Me._Line_32.Enabled = False
        Me._Line_32.Location = New System.Drawing.Point(0, 48)
        Me._Line_32.Name = "_Line_32"
        Me._Line_32.Size = New System.Drawing.Size(553, 1)
        Me._Line_32.TabIndex = 216
        '
        '_Line_31
        '
        Me._Line_31.Enabled = False
        Me._Line_31.Location = New System.Drawing.Point(0, 16)
        Me._Line_31.Name = "_Line_31"
        Me._Line_31.Size = New System.Drawing.Size(553, 1)
        Me._Line_31.TabIndex = 217
        '
        '_Label0_118
        '
        Me._Label0_118.BackColor = System.Drawing.Color.White
        Me._Label0_118.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_118.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_118.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_118.Location = New System.Drawing.Point(49, 616)
        Me._Label0_118.Name = "_Label0_118"
        Me._Label0_118.Size = New System.Drawing.Size(507, 17)
        Me._Label0_118.TabIndex = 188
        Me._Label0_118.Tag = "Other documents ralating to the determination of revenue, expenses and taxable in" & _
            "come in the tax period."
        Me._Label0_118.Text = "Các văn bản khác liên quan đến việc xác định doanh thu, chi phí và thu nhập chịu " & _
            "thuế trong kỳ tính thuế."
        '
        '_Label0_112
        '
        Me._Label0_112.BackColor = System.Drawing.Color.White
        Me._Label0_112.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_112.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_112.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_112.Location = New System.Drawing.Point(0, 616)
        Me._Label0_112.Name = "_Label0_112"
        Me._Label0_112.Size = New System.Drawing.Size(25, 17)
        Me._Label0_112.TabIndex = 187
        Me._Label0_112.Text = "6"
        Me._Label0_112.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_111
        '
        Me._Label0_111.BackColor = System.Drawing.Color.White
        Me._Label0_111.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_111.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_111.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_111.Location = New System.Drawing.Point(49, 584)
        Me._Label0_111.Name = "_Label0_111"
        Me._Label0_111.Size = New System.Drawing.Size(507, 33)
        Me._Label0_111.TabIndex = 186
        Me._Label0_111.Tag = "The text of goverment for the reasonable costs charged to expenses charities and " & _
            "sponsoring unions, social organizations and localities support."
        Me._Label0_111.Text = "Văn bản của Chính phủ cho tính vào chi phí hợp lý các khoản chi từ thiện, tài trợ" & _
            " cho các đoàn thể, tổ chức xã hội và ủng hộ các địa phương."
        '
        '_Label0_110
        '
        Me._Label0_110.BackColor = System.Drawing.Color.White
        Me._Label0_110.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_110.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_110.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_110.Location = New System.Drawing.Point(0, 584)
        Me._Label0_110.Name = "_Label0_110"
        Me._Label0_110.Size = New System.Drawing.Size(25, 33)
        Me._Label0_110.TabIndex = 185
        Me._Label0_110.Text = "5"
        Me._Label0_110.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_109
        '
        Me._Label0_109.BackColor = System.Drawing.Color.White
        Me._Label0_109.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_109.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_109.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_109.Location = New System.Drawing.Point(49, 568)
        Me._Label0_109.Name = "_Label0_109"
        Me._Label0_109.Size = New System.Drawing.Size(507, 17)
        Me._Label0_109.TabIndex = 184
        Me._Label0_109.Tag = "The text have written consent of finance ministries on prepaid expenses included " & _
            "in reasonable cost."
        Me._Label0_109.Text = "Văn bản thoả thuận của Bộ Tài chính về khoản chi phí trích trước tính vào chi phí" & _
            " hợp lý."
        '
        '_Label0_108
        '
        Me._Label0_108.BackColor = System.Drawing.Color.White
        Me._Label0_108.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_108.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_108.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_108.Location = New System.Drawing.Point(0, 568)
        Me._Label0_108.Name = "_Label0_108"
        Me._Label0_108.Size = New System.Drawing.Size(25, 17)
        Me._Label0_108.TabIndex = 183
        Me._Label0_108.Text = "4"
        Me._Label0_108.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_107
        '
        Me._Label0_107.BackColor = System.Drawing.Color.White
        Me._Label0_107.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_107.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_107.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_107.Location = New System.Drawing.Point(49, 552)
        Me._Label0_107.Name = "_Label0_107"
        Me._Label0_107.Size = New System.Drawing.Size(507, 17)
        Me._Label0_107.TabIndex = 182
        Me._Label0_107.Tag = "The text distribution business management expenses of the overseas Company for a " & _
            "permanent establishment in VietNam. "
        Me._Label0_107.Text = "Văn bản phân bổ chi phí quản lý kinh doanh của Công ty  ở nước ngoài cho cơ sở th" & _
            "ường trú tại VN."
        '
        '_Label0_106
        '
        Me._Label0_106.BackColor = System.Drawing.Color.White
        Me._Label0_106.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_106.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_106.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_106.Location = New System.Drawing.Point(0, 552)
        Me._Label0_106.Name = "_Label0_106"
        Me._Label0_106.Size = New System.Drawing.Size(25, 17)
        Me._Label0_106.TabIndex = 181
        Me._Label0_106.Text = "3"
        Me._Label0_106.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_105
        '
        Me._Label0_105.BackColor = System.Drawing.Color.White
        Me._Label0_105.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_105.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_105.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_105.Location = New System.Drawing.Point(49, 520)
        Me._Label0_105.Name = "_Label0_105"
        Me._Label0_105.Size = New System.Drawing.Size(507, 33)
        Me._Label0_105.TabIndex = 180
        Me._Label0_105.Tag = "The registration period for tax exemption or reduction under the guidance at Poin" & _
            "t 3.4, Section II, Part E of  Circular No.128/2003/TT - BTC date 22 December 200" & _
            "3."
        Me._Label0_105.Text = "Bản đăng ký thời gian miễn thuế, giảm thuế theo hướng dẫn tại điểm 3.4, mục II, p" & _
            "hần E Thông tư số 128/2003/TT-BTC ngày 22 tháng 12 năm 2003."
        '
        '_Label0_97
        '
        Me._Label0_97.BackColor = System.Drawing.Color.White
        Me._Label0_97.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_97.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_97.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_97.Location = New System.Drawing.Point(0, 520)
        Me._Label0_97.Name = "_Label0_97"
        Me._Label0_97.Size = New System.Drawing.Size(25, 33)
        Me._Label0_97.TabIndex = 179
        Me._Label0_97.Text = "2"
        Me._Label0_97.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_96
        '
        Me._Label0_96.BackColor = System.Drawing.Color.White
        Me._Label0_96.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_96.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_96.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_96.Location = New System.Drawing.Point(49, 504)
        Me._Label0_96.Name = "_Label0_96"
        Me._Label0_96.Size = New System.Drawing.Size(507, 17)
        Me._Label0_96.TabIndex = 178
        Me._Label0_96.Tag = "The recordd or documents evidencing income tax paid abroad."
        Me._Label0_96.Text = "Biên lai hoặc chứng từ chứng minh đã nộp thuế thu nhập tại nước ngoài."
        '
        '_Label0_95
        '
        Me._Label0_95.BackColor = System.Drawing.Color.White
        Me._Label0_95.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_95.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_95.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_95.Location = New System.Drawing.Point(0, 504)
        Me._Label0_95.Name = "_Label0_95"
        Me._Label0_95.Size = New System.Drawing.Size(25, 17)
        Me._Label0_95.TabIndex = 177
        Me._Label0_95.Text = "1"
        Me._Label0_95.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_94
        '
        Me._Label0_94.BackColor = System.Drawing.Color.White
        Me._Label0_94.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_94.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_94.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_94.Location = New System.Drawing.Point(27, 488)
        Me._Label0_94.Name = "_Label0_94"
        Me._Label0_94.Size = New System.Drawing.Size(526, 17)
        Me._Label0_94.TabIndex = 176
        Me._Label0_94.Tag = "In addition of the annex to this declaration, we enclose the following documents:" & _
            ""
        Me._Label0_94.Text = "Ngoài các Phụ lục của  tờ khai này, chúng tôi gửi kèm theo các tài liệu sau:"
        '
        '_Label0_93
        '
        Me._Label0_93.BackColor = System.Drawing.Color.White
        Me._Label0_93.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_93.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_93.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_93.Location = New System.Drawing.Point(0, 488)
        Me._Label0_93.Name = "_Label0_93"
        Me._Label0_93.Size = New System.Drawing.Size(25, 17)
        Me._Label0_93.TabIndex = 175
        Me._Label0_93.Text = "D"
        Me._Label0_93.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_92
        '
        Me._Label0_92.BackColor = System.Drawing.Color.White
        Me._Label0_92.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_92.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_92.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_92.Location = New System.Drawing.Point(27, 472)
        Me._Label0_92.Name = "_Label0_92"
        Me._Label0_92.Size = New System.Drawing.Size(413, 17)
        Me._Label0_92.TabIndex = 174
        Me._Label0_92.Tag = "The corporate income tax payable arising in the tax period (C10=C1+C6)."
        Me._Label0_92.Text = "Thuế thu nhập doanh nghiệp phát sinh phải nộp trong kỳ tính thuế (C10=C1+C6)"
        '
        '_Label0_91
        '
        Me._Label0_91.BackColor = System.Drawing.Color.White
        Me._Label0_91.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_91.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_91.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_91.Location = New System.Drawing.Point(0, 472)
        Me._Label0_91.Name = "_Label0_91"
        Me._Label0_91.Size = New System.Drawing.Size(25, 17)
        Me._Label0_91.TabIndex = 173
        Me._Label0_91.Text = "3"
        Me._Label0_91.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_115
        '
        Me._Label0_115.BackColor = System.Drawing.Color.White
        Me._Label0_115.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_115.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_115.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_115.Location = New System.Drawing.Point(0, 352)
        Me._Label0_115.Name = "_Label0_115"
        Me._Label0_115.Size = New System.Drawing.Size(25, 41)
        Me._Label0_115.TabIndex = 170
        Me._Label0_115.Text = "2"
        Me._Label0_115.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_114
        '
        Me._Label0_114.BackColor = System.Drawing.Color.White
        Me._Label0_114.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_114.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_114.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_114.Location = New System.Drawing.Point(27, 352)
        Me._Label0_114.Name = "_Label0_114"
        Me._Label0_114.Size = New System.Drawing.Size(413, 41)
        Me._Label0_114.TabIndex = 169
        Me._Label0_114.Tag = "The corporate income tax from assignment of land use, land lease (C6=C7+C8-C9)."
        Me._Label0_114.Text = "Thuế TNDN từ hoạt động chuyển quyền sử dụng đất, chuyển quyền thuê đất (C6=C7+C8-" & _
            "C9)"
        '
        '_Label0_113
        '
        Me._Label0_113.BackColor = System.Drawing.Color.White
        Me._Label0_113.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_113.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_113.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_113.Location = New System.Drawing.Point(0, 176)
        Me._Label0_113.Name = "_Label0_113"
        Me._Label0_113.Size = New System.Drawing.Size(25, 17)
        Me._Label0_113.TabIndex = 168
        Me._Label0_113.Text = "5"
        Me._Label0_113.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_104
        '
        Me._Label0_104.BackColor = System.Drawing.Color.White
        Me._Label0_104.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_104.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_104.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_104.Location = New System.Drawing.Point(0, 64)
        Me._Label0_104.Name = "_Label0_104"
        Me._Label0_104.Size = New System.Drawing.Size(25, 17)
        Me._Label0_104.TabIndex = 167
        Me._Label0_104.Text = "3"
        Me._Label0_104.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_103
        '
        Me._Label0_103.BackColor = System.Drawing.Color.White
        Me._Label0_103.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_103.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_103.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_103.Location = New System.Drawing.Point(27, 64)
        Me._Label0_103.Name = "_Label0_103"
        Me._Label0_103.Size = New System.Drawing.Size(413, 17)
        Me._Label0_103.TabIndex = 166
        Me._Label0_103.Tag = "Total business turnover taxable income excluding switching losses (B23=A1+B1-B17)" & _
            "."
        Me._Label0_103.Text = "Tổng thu nhập chịu thuế thu nhập doanh nghiệp chưa trừ chuyển lỗ (B23=A1+B1-B17)"
        '
        '_Label0_102
        '
        Me._Label0_102.BackColor = System.Drawing.Color.White
        Me._Label0_102.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_102.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_102.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_102.Location = New System.Drawing.Point(27, 128)
        Me._Label0_102.Name = "_Label0_102"
        Me._Label0_102.Size = New System.Drawing.Size(413, 17)
        Me._Label0_102.TabIndex = 165
        Me._Label0_102.Tag = "Losses from the previous year (B26=B27+B28)"
        Me._Label0_102.Text = "Lỗ từ các năm trước chuyển sang (B26=B27+B28)"
        '
        '_Label0_101
        '
        Me._Label0_101.BackColor = System.Drawing.Color.White
        Me._Label0_101.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_101.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_101.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_101.Location = New System.Drawing.Point(0, 128)
        Me._Label0_101.Name = "_Label0_101"
        Me._Label0_101.Size = New System.Drawing.Size(25, 17)
        Me._Label0_101.TabIndex = 164
        Me._Label0_101.Text = "4"
        Me._Label0_101.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_99
        '
        Me._Label0_99.BackColor = System.Drawing.Color.White
        Me._Label0_99.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_99.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_99.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_99.Location = New System.Drawing.Point(0, 0)
        Me._Label0_99.Name = "_Label0_99"
        Me._Label0_99.Size = New System.Drawing.Size(25, 17)
        Me._Label0_99.TabIndex = 162
        Me._Label0_99.Text = "2.3"
        Me._Label0_99.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_98
        '
        Me._Label0_98.BackColor = System.Drawing.Color.White
        Me._Label0_98.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_98.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_98.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_98.Location = New System.Drawing.Point(27, 176)
        Me._Label0_98.Name = "_Label0_98"
        Me._Label0_98.Size = New System.Drawing.Size(413, 17)
        Me._Label0_98.TabIndex = 161
        Me._Label0_98.Tag = "Total income subject to corrporate income tax(excluded losses) (B29=B30+B31)"
        Me._Label0_98.Text = "Tổng thu nhập chịu thuế thu nhập doanh nghiệp (đã trừ chuyển lỗ) (B29=B30+B31)"
        '
        '_Label0_90
        '
        Me._Label0_90.BackColor = System.Drawing.Color.White
        Me._Label0_90.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_90.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_90.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_90.Location = New System.Drawing.Point(0, 16)
        Me._Label0_90.Name = "_Label0_90"
        Me._Label0_90.Size = New System.Drawing.Size(25, 33)
        Me._Label0_90.TabIndex = 160
        Me._Label0_90.Text = "2.4"
        Me._Label0_90.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_89
        '
        Me._Label0_89.BackColor = System.Drawing.Color.White
        Me._Label0_89.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_89.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_89.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_89.Location = New System.Drawing.Point(27, 16)
        Me._Label0_89.Name = "_Label0_89"
        Me._Label0_89.Size = New System.Drawing.Size(413, 33)
        Me._Label0_89.TabIndex = 159
        Me._Label0_89.Tag = "The interest exchange rate differences from revaluation of monetary items, are or" & _
            "ginated from foreign currencies at the end of fiscal year."
        Me._Label0_89.Text = "Lãi chênh lệch tủ giá hối đoái do đánh giá lại các khoản mục tiền tệ, có nguồn gố" & _
            "c ngoại tệ tại thời điểm cuối năm tài chính"
        '
        '_Label0_88
        '
        Me._Label0_88.BackColor = System.Drawing.Color.White
        Me._Label0_88.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_88.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_88.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_88.Location = New System.Drawing.Point(0, 48)
        Me._Label0_88.Name = "_Label0_88"
        Me._Label0_88.Size = New System.Drawing.Size(25, 17)
        Me._Label0_88.TabIndex = 158
        Me._Label0_88.Text = "2.5"
        Me._Label0_88.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_87
        '
        Me._Label0_87.BackColor = System.Drawing.Color.White
        Me._Label0_87.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_87.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_87.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_87.Location = New System.Drawing.Point(27, 48)
        Me._Label0_87.Name = "_Label0_87"
        Me._Label0_87.Size = New System.Drawing.Size(413, 17)
        Me._Label0_87.TabIndex = 157
        Me._Label0_87.Tag = "Other adjustments reduce profit before the tax."
        Me._Label0_87.Text = "Các khoản điều chỉnh làm giảm lợi nhuận trước thuế khác"
        '
        '_Label0_86
        '
        Me._Label0_86.BackColor = System.Drawing.Color.White
        Me._Label0_86.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_86.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_86.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_86.Location = New System.Drawing.Point(27, 80)
        Me._Label0_86.Name = "_Label0_86"
        Me._Label0_86.Size = New System.Drawing.Size(413, 33)
        Me._Label0_86.TabIndex = 156
        Me._Label0_86.Tag = "Income from business activities (Excluding income from land use, land lease)"
        Me._Label0_86.Text = "Thu nhập từ hoạt động SXKD (trừ thu nhập từ chuyển quyền sử dụng đất, chuyển quyề" & _
            "n thuê đất)"
        '
        '_Label0_85
        '
        Me._Label0_85.BackColor = System.Drawing.Color.White
        Me._Label0_85.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_85.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_85.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_85.Location = New System.Drawing.Point(0, 80)
        Me._Label0_85.Name = "_Label0_85"
        Me._Label0_85.Size = New System.Drawing.Size(25, 33)
        Me._Label0_85.TabIndex = 155
        Me._Label0_85.Text = "3.1"
        Me._Label0_85.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_84
        '
        Me._Label0_84.BackColor = System.Drawing.Color.White
        Me._Label0_84.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_84.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_84.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_84.Location = New System.Drawing.Point(27, 112)
        Me._Label0_84.Name = "_Label0_84"
        Me._Label0_84.Size = New System.Drawing.Size(413, 17)
        Me._Label0_84.TabIndex = 154
        Me._Label0_84.Tag = "Income from land use, land lease"
        Me._Label0_84.Text = "Thu nhập từ chuyển quyền sử dụng đất, chuyền quyền thuê đất"
        '
        '_Label0_83
        '
        Me._Label0_83.BackColor = System.Drawing.Color.White
        Me._Label0_83.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_83.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_83.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_83.Location = New System.Drawing.Point(0, 112)
        Me._Label0_83.Name = "_Label0_83"
        Me._Label0_83.Size = New System.Drawing.Size(25, 17)
        Me._Label0_83.TabIndex = 153
        Me._Label0_83.Text = "3.2"
        Me._Label0_83.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_82
        '
        Me._Label0_82.BackColor = System.Drawing.Color.White
        Me._Label0_82.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_82.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_82.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_82.Location = New System.Drawing.Point(27, 144)
        Me._Label0_82.Name = "_Label0_82"
        Me._Label0_82.Size = New System.Drawing.Size(413, 17)
        Me._Label0_82.TabIndex = 152
        Me._Label0_82.Tag = "Losses from business activities (Excluding losses from change of land use, land l" & _
            "ease)"
        Me._Label0_82.Text = "Lỗ từ hoạt động SXKD (trừ lỗ từ chuyển quyền sử dụng đất, chuyển quyền thuê đất)"
        '
        '_Label0_81
        '
        Me._Label0_81.BackColor = System.Drawing.Color.White
        Me._Label0_81.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_81.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_81.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_81.Location = New System.Drawing.Point(0, 144)
        Me._Label0_81.Name = "_Label0_81"
        Me._Label0_81.Size = New System.Drawing.Size(25, 17)
        Me._Label0_81.TabIndex = 151
        Me._Label0_81.Text = "4.1"
        Me._Label0_81.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_80
        '
        Me._Label0_80.BackColor = System.Drawing.Color.White
        Me._Label0_80.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_80.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_80.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_80.Location = New System.Drawing.Point(27, 160)
        Me._Label0_80.Name = "_Label0_80"
        Me._Label0_80.Size = New System.Drawing.Size(413, 17)
        Me._Label0_80.TabIndex = 150
        Me._Label0_80.Tag = "Losses from change of land use, land lease."
        Me._Label0_80.Text = "Lỗ từ chuyển quyền sử dụng đất, chuyển quyền thuê đất"
        '
        '_Label0_79
        '
        Me._Label0_79.BackColor = System.Drawing.Color.White
        Me._Label0_79.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_79.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_79.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_79.Location = New System.Drawing.Point(0, 160)
        Me._Label0_79.Name = "_Label0_79"
        Me._Label0_79.Size = New System.Drawing.Size(25, 17)
        Me._Label0_79.TabIndex = 149
        Me._Label0_79.Text = "4.2"
        Me._Label0_79.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_78
        '
        Me._Label0_78.BackColor = System.Drawing.Color.White
        Me._Label0_78.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_78.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_78.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_78.Location = New System.Drawing.Point(27, 192)
        Me._Label0_78.Name = "_Label0_78"
        Me._Label0_78.Size = New System.Drawing.Size(413, 33)
        Me._Label0_78.TabIndex = 148
        Me._Label0_78.Tag = "Income from business activities (Excluding losses from change of land use, land l" & _
            "ease) (B30=B24-B27)"
        Me._Label0_78.Text = "Thu nhập từ hoạt động SXKD (trừ thu nhập từ hoạt động chuyển quyền sử dụng đất, c" & _
            "huyển quyền thuê đất) (B30=B24-B27)"
        '
        '_Label0_77
        '
        Me._Label0_77.BackColor = System.Drawing.Color.White
        Me._Label0_77.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_77.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_77.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_77.Location = New System.Drawing.Point(0, 192)
        Me._Label0_77.Name = "_Label0_77"
        Me._Label0_77.Size = New System.Drawing.Size(25, 33)
        Me._Label0_77.TabIndex = 147
        Me._Label0_77.Text = "5.1"
        Me._Label0_77.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_76
        '
        Me._Label0_76.BackColor = System.Drawing.Color.White
        Me._Label0_76.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_76.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_76.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_76.Location = New System.Drawing.Point(0, 224)
        Me._Label0_76.Name = "_Label0_76"
        Me._Label0_76.Size = New System.Drawing.Size(25, 33)
        Me._Label0_76.TabIndex = 146
        Me._Label0_76.Text = "5.2"
        Me._Label0_76.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_75
        '
        Me._Label0_75.BackColor = System.Drawing.Color.White
        Me._Label0_75.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_75.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_75.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_75.Location = New System.Drawing.Point(27, 224)
        Me._Label0_75.Name = "_Label0_75"
        Me._Label0_75.Size = New System.Drawing.Size(413, 33)
        Me._Label0_75.TabIndex = 145
        Me._Label0_75.Tag = "Income from change of land use, land lease (B31=B25-B28)."
        Me._Label0_75.Text = "Thu nhập từ hoạt động chuyển quyền sử dụng đất, chuyển quyền thuê đất (B31=B25+B2" & _
            "8)"
        '
        '_Label0_74
        '
        Me._Label0_74.BackColor = System.Drawing.Color.White
        Me._Label0_74.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_74.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_74.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_74.Location = New System.Drawing.Point(0, 272)
        Me._Label0_74.Name = "_Label0_74"
        Me._Label0_74.Size = New System.Drawing.Size(25, 17)
        Me._Label0_74.TabIndex = 144
        Me._Label0_74.Text = "1"
        Me._Label0_74.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_73
        '
        Me._Label0_73.BackColor = System.Drawing.Color.White
        Me._Label0_73.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_73.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_73.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_73.Location = New System.Drawing.Point(27, 272)
        Me._Label0_73.Name = "_Label0_73"
        Me._Label0_73.Size = New System.Drawing.Size(413, 17)
        Me._Label0_73.TabIndex = 143
        Me._Label0_73.Tag = "Corporate income tax from production and business activities (C1=C2-C3-C4-C5)"
        Me._Label0_73.Text = "Thuế TNDN từ hoạt động SXKD (C1=C2-C3-C4-C5)"
        '
        '_Label0_72
        '
        Me._Label0_72.BackColor = System.Drawing.Color.White
        Me._Label0_72.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_72.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_72.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_72.Location = New System.Drawing.Point(0, 288)
        Me._Label0_72.Name = "_Label0_72"
        Me._Label0_72.Size = New System.Drawing.Size(25, 17)
        Me._Label0_72.TabIndex = 142
        Me._Label0_72.Text = "1.1"
        Me._Label0_72.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_71
        '
        Me._Label0_71.BackColor = System.Drawing.Color.White
        Me._Label0_71.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_71.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_71.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_71.Location = New System.Drawing.Point(27, 288)
        Me._Label0_71.Name = "_Label0_71"
        Me._Label0_71.Size = New System.Drawing.Size(413, 17)
        Me._Label0_71.TabIndex = 141
        Me._Label0_71.Tag = "Corporate income tax from production and business activities taxed at oridinary r" & _
            "ates(C2=B30*       %)"
        Me._Label0_71.Text = "Thuế TNDN từ hoạt động SXKD tính theo thuế suất phổ thông (C2=B30*      %)"
        '
        '_Label0_70
        '
        Me._Label0_70.BackColor = System.Drawing.Color.White
        Me._Label0_70.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_70.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_70.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_70.Location = New System.Drawing.Point(0, 304)
        Me._Label0_70.Name = "_Label0_70"
        Me._Label0_70.Size = New System.Drawing.Size(25, 17)
        Me._Label0_70.TabIndex = 140
        Me._Label0_70.Text = "1.2"
        Me._Label0_70.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_69
        '
        Me._Label0_69.BackColor = System.Drawing.Color.White
        Me._Label0_69.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_69.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_69.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_69.Location = New System.Drawing.Point(27, 304)
        Me._Label0_69.Name = "_Label0_69"
        Me._Label0_69.Size = New System.Drawing.Size(413, 17)
        Me._Label0_69.TabIndex = 139
        Me._Label0_69.Tag = "The business income tax different because applied to tax rate another with tax ra" & _
            "te                %"
        Me._Label0_69.Text = "Thuế TNDN Chênh lệch do áp dụng thuế suất khác thuế suất      %"
        '
        '_Label0_68
        '
        Me._Label0_68.BackColor = System.Drawing.Color.White
        Me._Label0_68.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_68.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_68.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_68.Location = New System.Drawing.Point(0, 320)
        Me._Label0_68.Name = "_Label0_68"
        Me._Label0_68.Size = New System.Drawing.Size(25, 17)
        Me._Label0_68.TabIndex = 138
        Me._Label0_68.Text = "1.3"
        Me._Label0_68.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_67
        '
        Me._Label0_67.BackColor = System.Drawing.Color.White
        Me._Label0_67.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_67.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_67.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_67.Location = New System.Drawing.Point(27, 320)
        Me._Label0_67.Name = "_Label0_67"
        Me._Label0_67.Size = New System.Drawing.Size(413, 17)
        Me._Label0_67.TabIndex = 137
        Me._Label0_67.Tag = "Corporate income tax exemption in the tax period."
        Me._Label0_67.Text = "Thuế thu nhập doanh nghiệp được miễn, giảm trong kỳ tính thuế"
        '
        '_Label0_66
        '
        Me._Label0_66.BackColor = System.Drawing.Color.White
        Me._Label0_66.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_66.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_66.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_66.Location = New System.Drawing.Point(0, 336)
        Me._Label0_66.Name = "_Label0_66"
        Me._Label0_66.Size = New System.Drawing.Size(25, 17)
        Me._Label0_66.TabIndex = 136
        Me._Label0_66.Text = "1.4"
        Me._Label0_66.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_65
        '
        Me._Label0_65.BackColor = System.Drawing.Color.White
        Me._Label0_65.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_65.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_65.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_65.Location = New System.Drawing.Point(27, 336)
        Me._Label0_65.Name = "_Label0_65"
        Me._Label0_65.Size = New System.Drawing.Size(413, 17)
        Me._Label0_65.TabIndex = 135
        Me._Label0_65.Tag = "The income tax already paid abroad are deducted in the tax period."
        Me._Label0_65.Text = "Số thuế thu nhập đã nộp ở nước ngoài được trừ trong kỳ tính thuế"
        '
        '_Label0_64
        '
        Me._Label0_64.BackColor = System.Drawing.Color.White
        Me._Label0_64.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_64.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_64.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_64.Location = New System.Drawing.Point(0, 256)
        Me._Label0_64.Name = "_Label0_64"
        Me._Label0_64.Size = New System.Drawing.Size(25, 17)
        Me._Label0_64.TabIndex = 134
        Me._Label0_64.Text = "C"
        Me._Label0_64.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_63
        '
        Me._Label0_63.BackColor = System.Drawing.Color.White
        Me._Label0_63.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_63.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_63.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_63.Location = New System.Drawing.Point(27, 256)
        Me._Label0_63.Name = "_Label0_63"
        Me._Label0_63.Size = New System.Drawing.Size(413, 17)
        Me._Label0_63.TabIndex = 133
        Me._Label0_63.Tag = "Determining the enterprise income tax payable in the tax period."
        Me._Label0_63.Text = "Xác định số thuế thu nhập doanh nghiệp phải nộp trong kỳ tính thuế"
        '
        '_Label0_62
        '
        Me._Label0_62.BackColor = System.Drawing.Color.White
        Me._Label0_62.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_62.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_62.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_62.Location = New System.Drawing.Point(0, 424)
        Me._Label0_62.Name = "_Label0_62"
        Me._Label0_62.Size = New System.Drawing.Size(25, 17)
        Me._Label0_62.TabIndex = 132
        Me._Label0_62.Text = "2.2"
        Me._Label0_62.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_61
        '
        Me._Label0_61.BackColor = System.Drawing.Color.White
        Me._Label0_61.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_61.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_61.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_61.Location = New System.Drawing.Point(27, 424)
        Me._Label0_61.Name = "_Label0_61"
        Me._Label0_61.Size = New System.Drawing.Size(413, 17)
        Me._Label0_61.TabIndex = 131
        Me._Label0_61.Tag = "Additional tax revenue from income tranfer of land use, land lease."
        Me._Label0_61.Text = "Thuế thu nhập bổ sung từ thu nhập chuyển quyền sử dụng đất, chuyển quyền thuê đất" & _
            ""
        '
        '_Label0_60
        '
        Me._Label0_60.BackColor = System.Drawing.Color.White
        Me._Label0_60.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_60.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_60.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_60.Location = New System.Drawing.Point(0, 440)
        Me._Label0_60.Name = "_Label0_60"
        Me._Label0_60.Size = New System.Drawing.Size(25, 33)
        Me._Label0_60.TabIndex = 130
        Me._Label0_60.Text = "2.3"
        Me._Label0_60.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_59
        '
        Me._Label0_59.BackColor = System.Drawing.Color.White
        Me._Label0_59.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_59.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_59.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_59.Location = New System.Drawing.Point(27, 440)
        Me._Label0_59.Name = "_Label0_59"
        Me._Label0_59.Size = New System.Drawing.Size(413, 33)
        Me._Label0_59.TabIndex = 129
        Me._Label0_59.Tag = "The corporate income tax from the tranfer of land use, land lease was paid in pro" & _
            "vinces/cities where they are headquartered outside."
        Me._Label0_59.Text = "Thuế TNDN từ hoạt động chuyển quyền sử dụng đất, chuyển quyền thuê đất đã nộp ở t" & _
            "hành tỉnh/thành phố ngoài nơi đóng trụ sở chính"
        '
        '_Label0_116
        '
        Me._Label0_116.BackColor = System.Drawing.Color.White
        Me._Label0_116.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_116.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_116.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_116.Location = New System.Drawing.Point(27, 392)
        Me._Label0_116.Name = "_Label0_116"
        Me._Label0_116.Size = New System.Drawing.Size(413, 33)
        Me._Label0_116.TabIndex = 171
        Me._Label0_116.Tag = "The corporate income tax for active tranfer of land use, land lease (C7=B31*     " & _
            "       %)"
        Me._Label0_116.Text = "Thuế TNDN đối với thu nhập từ chuyển quyền sử dụng đất, chuyển quyền thuê đất (C7" & _
            "=B31*      %)"
        '
        '_Label0_117
        '
        Me._Label0_117.BackColor = System.Drawing.Color.White
        Me._Label0_117.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_117.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_117.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_117.Location = New System.Drawing.Point(0, 392)
        Me._Label0_117.Name = "_Label0_117"
        Me._Label0_117.Size = New System.Drawing.Size(25, 33)
        Me._Label0_117.TabIndex = 172
        Me._Label0_117.Text = "2.1"
        Me._Label0_117.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_100
        '
        Me._Label0_100.BackColor = System.Drawing.Color.White
        Me._Label0_100.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_100.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_100.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_100.Location = New System.Drawing.Point(27, 0)
        Me._Label0_100.Name = "_Label0_100"
        Me._Label0_100.Size = New System.Drawing.Size(413, 17)
        Me._Label0_100.TabIndex = 163
        Me._Label0_100.Tag = "Cost of revenues to increase."
        Me._Label0_100.Text = "Chi phớ của phaàn doanh thu ủieàu chổnh taờng"
        '
        '_Label0_143
        '
        Me._Label0_143.BackColor = System.Drawing.Color.White
        Me._Label0_143.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_143.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_143.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_143.Location = New System.Drawing.Point(440, 392)
        Me._Label0_143.Name = "_Label0_143"
        Me._Label0_143.Size = New System.Drawing.Size(32, 33)
        Me._Label0_143.TabIndex = 211
        Me._Label0_143.Text = "C7"
        Me._Label0_143.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_142
        '
        Me._Label0_142.BackColor = System.Drawing.Color.White
        Me._Label0_142.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_142.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_142.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_142.Location = New System.Drawing.Point(440, 440)
        Me._Label0_142.Name = "_Label0_142"
        Me._Label0_142.Size = New System.Drawing.Size(32, 33)
        Me._Label0_142.TabIndex = 210
        Me._Label0_142.Text = "C9"
        Me._Label0_142.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_141
        '
        Me._Label0_141.BackColor = System.Drawing.Color.White
        Me._Label0_141.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_141.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_141.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_141.Location = New System.Drawing.Point(440, 424)
        Me._Label0_141.Name = "_Label0_141"
        Me._Label0_141.Size = New System.Drawing.Size(32, 17)
        Me._Label0_141.TabIndex = 209
        Me._Label0_141.Text = "C8"
        Me._Label0_141.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_139
        '
        Me._Label0_139.BackColor = System.Drawing.Color.White
        Me._Label0_139.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_139.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_139.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_139.Location = New System.Drawing.Point(440, 336)
        Me._Label0_139.Name = "_Label0_139"
        Me._Label0_139.Size = New System.Drawing.Size(32, 17)
        Me._Label0_139.TabIndex = 208
        Me._Label0_139.Text = "C5"
        Me._Label0_139.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_138
        '
        Me._Label0_138.BackColor = System.Drawing.Color.White
        Me._Label0_138.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_138.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_138.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_138.Location = New System.Drawing.Point(440, 320)
        Me._Label0_138.Name = "_Label0_138"
        Me._Label0_138.Size = New System.Drawing.Size(32, 17)
        Me._Label0_138.TabIndex = 207
        Me._Label0_138.Text = "C4"
        Me._Label0_138.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_137
        '
        Me._Label0_137.BackColor = System.Drawing.Color.White
        Me._Label0_137.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_137.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_137.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_137.Location = New System.Drawing.Point(440, 304)
        Me._Label0_137.Name = "_Label0_137"
        Me._Label0_137.Size = New System.Drawing.Size(32, 17)
        Me._Label0_137.TabIndex = 206
        Me._Label0_137.Text = "C3"
        Me._Label0_137.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_136
        '
        Me._Label0_136.BackColor = System.Drawing.Color.White
        Me._Label0_136.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_136.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_136.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_136.Location = New System.Drawing.Point(440, 288)
        Me._Label0_136.Name = "_Label0_136"
        Me._Label0_136.Size = New System.Drawing.Size(32, 17)
        Me._Label0_136.TabIndex = 205
        Me._Label0_136.Text = "C2"
        Me._Label0_136.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_135
        '
        Me._Label0_135.BackColor = System.Drawing.Color.White
        Me._Label0_135.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_135.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_135.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_135.Location = New System.Drawing.Point(440, 272)
        Me._Label0_135.Name = "_Label0_135"
        Me._Label0_135.Size = New System.Drawing.Size(32, 17)
        Me._Label0_135.TabIndex = 204
        Me._Label0_135.Text = "C1"
        Me._Label0_135.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_134
        '
        Me._Label0_134.BackColor = System.Drawing.Color.White
        Me._Label0_134.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_134.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_134.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_134.Location = New System.Drawing.Point(440, 224)
        Me._Label0_134.Name = "_Label0_134"
        Me._Label0_134.Size = New System.Drawing.Size(32, 33)
        Me._Label0_134.TabIndex = 203
        Me._Label0_134.Text = "B31"
        Me._Label0_134.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_133
        '
        Me._Label0_133.BackColor = System.Drawing.Color.White
        Me._Label0_133.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_133.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_133.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_133.Location = New System.Drawing.Point(440, 192)
        Me._Label0_133.Name = "_Label0_133"
        Me._Label0_133.Size = New System.Drawing.Size(32, 33)
        Me._Label0_133.TabIndex = 202
        Me._Label0_133.Text = "B30"
        Me._Label0_133.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_132
        '
        Me._Label0_132.BackColor = System.Drawing.Color.White
        Me._Label0_132.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_132.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_132.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_132.Location = New System.Drawing.Point(440, 160)
        Me._Label0_132.Name = "_Label0_132"
        Me._Label0_132.Size = New System.Drawing.Size(32, 17)
        Me._Label0_132.TabIndex = 201
        Me._Label0_132.Text = "B28"
        Me._Label0_132.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_131
        '
        Me._Label0_131.BackColor = System.Drawing.Color.White
        Me._Label0_131.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_131.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_131.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_131.Location = New System.Drawing.Point(440, 144)
        Me._Label0_131.Name = "_Label0_131"
        Me._Label0_131.Size = New System.Drawing.Size(32, 17)
        Me._Label0_131.TabIndex = 200
        Me._Label0_131.Text = "B27"
        Me._Label0_131.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_130
        '
        Me._Label0_130.BackColor = System.Drawing.Color.White
        Me._Label0_130.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_130.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_130.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_130.Location = New System.Drawing.Point(440, 112)
        Me._Label0_130.Name = "_Label0_130"
        Me._Label0_130.Size = New System.Drawing.Size(32, 17)
        Me._Label0_130.TabIndex = 199
        Me._Label0_130.Text = "B25"
        Me._Label0_130.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_129
        '
        Me._Label0_129.BackColor = System.Drawing.Color.White
        Me._Label0_129.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_129.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_129.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_129.Location = New System.Drawing.Point(440, 80)
        Me._Label0_129.Name = "_Label0_129"
        Me._Label0_129.Size = New System.Drawing.Size(32, 33)
        Me._Label0_129.TabIndex = 198
        Me._Label0_129.Text = "B24"
        Me._Label0_129.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_128
        '
        Me._Label0_128.BackColor = System.Drawing.Color.White
        Me._Label0_128.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_128.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_128.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_128.Location = New System.Drawing.Point(440, 48)
        Me._Label0_128.Name = "_Label0_128"
        Me._Label0_128.Size = New System.Drawing.Size(32, 17)
        Me._Label0_128.TabIndex = 197
        Me._Label0_128.Text = "B22"
        Me._Label0_128.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_127
        '
        Me._Label0_127.BackColor = System.Drawing.Color.White
        Me._Label0_127.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_127.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_127.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_127.Location = New System.Drawing.Point(440, 16)
        Me._Label0_127.Name = "_Label0_127"
        Me._Label0_127.Size = New System.Drawing.Size(32, 33)
        Me._Label0_127.TabIndex = 196
        Me._Label0_127.Text = "B21"
        Me._Label0_127.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_126
        '
        Me._Label0_126.BackColor = System.Drawing.Color.White
        Me._Label0_126.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_126.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_126.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_126.Location = New System.Drawing.Point(440, 0)
        Me._Label0_126.Name = "_Label0_126"
        Me._Label0_126.Size = New System.Drawing.Size(32, 17)
        Me._Label0_126.TabIndex = 195
        Me._Label0_126.Text = "B20"
        Me._Label0_126.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_125
        '
        Me._Label0_125.BackColor = System.Drawing.Color.White
        Me._Label0_125.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_125.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_125.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_125.Location = New System.Drawing.Point(440, 128)
        Me._Label0_125.Name = "_Label0_125"
        Me._Label0_125.Size = New System.Drawing.Size(32, 17)
        Me._Label0_125.TabIndex = 194
        Me._Label0_125.Text = "B26"
        Me._Label0_125.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_124
        '
        Me._Label0_124.BackColor = System.Drawing.Color.White
        Me._Label0_124.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_124.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_124.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_124.Location = New System.Drawing.Point(440, 64)
        Me._Label0_124.Name = "_Label0_124"
        Me._Label0_124.Size = New System.Drawing.Size(32, 17)
        Me._Label0_124.TabIndex = 193
        Me._Label0_124.Text = "B23"
        Me._Label0_124.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_123
        '
        Me._Label0_123.BackColor = System.Drawing.Color.White
        Me._Label0_123.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_123.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_123.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_123.Location = New System.Drawing.Point(440, 176)
        Me._Label0_123.Name = "_Label0_123"
        Me._Label0_123.Size = New System.Drawing.Size(32, 17)
        Me._Label0_123.TabIndex = 192
        Me._Label0_123.Text = "B29"
        Me._Label0_123.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_122
        '
        Me._Label0_122.BackColor = System.Drawing.Color.White
        Me._Label0_122.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_122.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_122.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_122.Location = New System.Drawing.Point(440, 352)
        Me._Label0_122.Name = "_Label0_122"
        Me._Label0_122.Size = New System.Drawing.Size(32, 41)
        Me._Label0_122.TabIndex = 191
        Me._Label0_122.Text = "C6"
        Me._Label0_122.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label0_121
        '
        Me._Label0_121.BackColor = System.Drawing.Color.White
        Me._Label0_121.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label0_121.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label0_121.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label0_121.Location = New System.Drawing.Point(440, 472)
        Me._Label0_121.Name = "_Label0_121"
        Me._Label0_121.Size = New System.Drawing.Size(32, 17)
        Me._Label0_121.TabIndex = 190
        Me._Label0_121.Text = "C10"
        Me._Label0_121.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Command_5
        '
        Me._Command_5.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_5.Location = New System.Drawing.Point(520, 692)
        Me._Command_5.Name = "_Command_5"
        Me._Command_5.Size = New System.Drawing.Size(61, 21)
        Me._Command_5.TabIndex = 63
        Me._Command_5.Tag = "Return"
        Me._Command_5.Text = "Trở &về"
        '
        '_Command_6
        '
        Me._Command_6.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Print
        Me._Command_6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_6.Location = New System.Drawing.Point(453, 692)
        Me._Command_6.Name = "_Command_6"
        Me._Command_6.Size = New System.Drawing.Size(61, 21)
        Me._Command_6.TabIndex = 62
        Me._Command_6.Tag = "Print"
        Me._Command_6.Text = "&In"
        '
        '_Command_4
        '
        Me._Command_4.Image = CType(resources.GetObject("_Command_4.Image"), System.Drawing.Image)
        Me._Command_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_4.Location = New System.Drawing.Point(387, 692)
        Me._Command_4.Name = "_Command_4"
        Me._Command_4.Size = New System.Drawing.Size(60, 21)
        Me._Command_4.TabIndex = 61
        Me._Command_4.Tag = "Preview"
        Me._Command_4.Text = "&Xem"
        '
        '_Command_0
        '
        Me._Command_0.Location = New System.Drawing.Point(180, 692)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(67, 21)
        Me._Command_0.TabIndex = 58
        Me._Command_0.Tag = "Next"
        Me._Command_0.Text = "&Trang sau"
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Save
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(320, 692)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(61, 21)
        Me._Command_1.TabIndex = 60
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_2
        '
        Me._Command_2.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Xoa
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(253, 692)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(61, 21)
        Me._Command_2.TabIndex = 59
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_LB_0
        '
        Me._LB_0.BackColor = System.Drawing.SystemColors.Window
        Me._LB_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LB_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LB_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LB_0.Location = New System.Drawing.Point(7, 8)
        Me._LB_0.Name = "_LB_0"
        Me._LB_0.Size = New System.Drawing.Size(567, 673)
        Me._LB_0.TabIndex = 65
        '
        '_LB_1
        '
        Me._LB_1.BackColor = System.Drawing.SystemColors.Window
        Me._LB_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LB_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LB_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LB_1.Location = New System.Drawing.Point(10, 12)
        Me._LB_1.Name = "_LB_1"
        Me._LB_1.Size = New System.Drawing.Size(567, 673)
        Me._LB_1.TabIndex = 64
        '
        '_LB_2
        '
        Me._LB_2.BackColor = System.Drawing.SystemColors.Window
        Me._LB_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LB_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LB_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LB_2.Location = New System.Drawing.Point(13, 16)
        Me._LB_2.Name = "_LB_2"
        Me._LB_2.Size = New System.Drawing.Size(568, 673)
        Me._LB_2.TabIndex = 91
        '
        'FrmQTTNDN
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(704, 721)
        Me.Controls.Add(Me._Command_5)
        Me.Controls.Add(Me._Command_6)
        Me.Controls.Add(Me._Command_4)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Frame_1)
        Me.Controls.Add(Me._Frame_2)
        Me.Controls.Add(Me._LB_0)
        Me.Controls.Add(Me._LB_1)
        Me.Controls.Add(Me._LB_2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(245, 63)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmQTTNDN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Yearly Income Tax Report"
        Me.Text = "Quyết toán thuế thu nhập doanh nghiệp"
        Me._Frame_1.ResumeLayout(False)
        Me._Frame_1.PerformLayout()
        Me._Frame_2.ResumeLayout(False)
        Me._Frame_2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Sub Initializechk()
        Me.chk(0) = _chk_0
        Me.chk(6) = _chk_6
        Me.chk(5) = _chk_5
        Me.chk(4) = _chk_4
        Me.chk(3) = _chk_3
        Me.chk(2) = _chk_2
        Me.chk(1) = _chk_1
    End Sub
    Sub InitializeTxt()
        Me.Txt(19) = _Txt_19
        Me.Txt(18) = _Txt_18
        Me.Txt(17) = _Txt_17
        Me.Txt(16) = _Txt_16
        Me.Txt(15) = _Txt_15
        Me.Txt(14) = _Txt_14
        Me.Txt(13) = _Txt_13
        Me.Txt(12) = _Txt_12
        Me.Txt(11) = _Txt_11
        Me.Txt(10) = _Txt_10
        Me.Txt(9) = _Txt_9
        Me.Txt(8) = _Txt_8
        Me.Txt(7) = _Txt_7
        Me.Txt(6) = _Txt_6
        Me.Txt(5) = _Txt_5
        Me.Txt(4) = _Txt_4
        Me.Txt(3) = _Txt_3
        Me.Txt(2) = _Txt_2
        Me.Txt(1) = _Txt_1
        Me.Txt(0) = _Txt_0
        Me.Txt(20) = _Txt_20
        Me.Txt(41) = _Txt_41
        Me.Txt(40) = _Txt_40
        Me.Txt(39) = _Txt_39
        Me.Txt(38) = _Txt_38
        Me.Txt(37) = _Txt_37
        Me.Txt(36) = _Txt_36
        Me.Txt(35) = _Txt_35
        Me.Txt(34) = _Txt_34
        Me.Txt(33) = _Txt_33
        Me.Txt(32) = _Txt_32
        Me.Txt(31) = _Txt_31
        Me.Txt(30) = _Txt_30
        Me.Txt(29) = _Txt_29
        Me.Txt(28) = _Txt_28
        Me.Txt(27) = _Txt_27
        Me.Txt(26) = _Txt_26
        Me.Txt(25) = _Txt_25
        Me.Txt(24) = _Txt_24
        Me.Txt(23) = _Txt_23
        Me.Txt(22) = _Txt_22
        Me.Txt(21) = _Txt_21
    End Sub
    Sub InitializeTL()
        Me.TL(2) = _TL_2
        Me.TL(1) = _TL_1
        Me.TL(0) = _TL_0
    End Sub
    Sub InitializeNgay()
        Me.Ngay(2) = _Ngay_2
        Me.Ngay(1) = _Ngay_1
        Me.Ngay(0) = _Ngay_0
    End Sub
    Sub InitializeLine()
        Me.Line(29) = _Line_29
        Me.Line(28) = _Line_28
        Me.Line(27) = _Line_27
        Me.Line(26) = _Line_26
        Me.Line(25) = _Line_25
        Me.Line(24) = _Line_24
        Me.Line(23) = _Line_23
        Me.Line(22) = _Line_22
        Me.Line(21) = _Line_21
        Me.Line(20) = _Line_20
        Me.Line(19) = _Line_19
        Me.Line(18) = _Line_18
        Me.Line(17) = _Line_17
        Me.Line(16) = _Line_16
        Me.Line(15) = _Line_15
        Me.Line(14) = _Line_14
        Me.Line(13) = _Line_13
        Me.Line(12) = _Line_12
        Me.Line(11) = _Line_11
        Me.Line(10) = _Line_10
        Me.Line(9) = _Line_9
        Me.Line(8) = _Line_8
        Me.Line(7) = _Line_7
        Me.Line(6) = _Line_6
        Me.Line(5) = _Line_5
        Me.Line(4) = _Line_4
        Me.Line(3) = _Line_3
        Me.Line(2) = _Line_2
        Me.Line(1) = _Line_1
        Me.Line(0) = _Line_0
        Me.Line(52) = _Line_52
        Me.Line(30) = _Line_30
        Me.Line(65) = _Line_65
        Me.Line(64) = _Line_64
        Me.Line(63) = _Line_63
        Me.Line(62) = _Line_62
        Me.Line(61) = _Line_61
        Me.Line(60) = _Line_60
        Me.Line(59) = _Line_59
        Me.Line(58) = _Line_58
        Me.Line(57) = _Line_57
        Me.Line(56) = _Line_56
        Me.Line(55) = _Line_55
        Me.Line(54) = _Line_54
        Me.Line(53) = _Line_53
        Me.Line(51) = _Line_51
        Me.Line(50) = _Line_50
        Me.Line(49) = _Line_49
        Me.Line(48) = _Line_48
        Me.Line(47) = _Line_47
        Me.Line(46) = _Line_46
        Me.Line(45) = _Line_45
        Me.Line(44) = _Line_44
        Me.Line(43) = _Line_43
        Me.Line(42) = _Line_42
        Me.Line(41) = _Line_41
        Me.Line(40) = _Line_40
        Me.Line(39) = _Line_39
        Me.Line(38) = _Line_38
        Me.Line(37) = _Line_37
        Me.Line(36) = _Line_36
        Me.Line(35) = _Line_35
        Me.Line(34) = _Line_34
        Me.Line(33) = _Line_33
        Me.Line(32) = _Line_32
        Me.Line(31) = _Line_31
    End Sub
    Sub InitializeLabel0()
        Me.Label0(159) = _Label0_159
        Me.Label0(58) = _Label0_58
        Me.Label0(57) = _Label0_57
        Me.Label0(56) = _Label0_56
        Me.Label0(55) = _Label0_55
        Me.Label0(54) = _Label0_54
        Me.Label0(53) = _Label0_53
        Me.Label0(48) = _Label0_48
        Me.Label0(47) = _Label0_47
        Me.Label0(46) = _Label0_46
        Me.Label0(45) = _Label0_45
        Me.Label0(44) = _Label0_44
        Me.Label0(43) = _Label0_43
        Me.Label0(42) = _Label0_42
        Me.Label0(41) = _Label0_41
        Me.Label0(40) = _Label0_40
        Me.Label0(39) = _Label0_39
        Me.Label0(38) = _Label0_38
        Me.Label0(37) = _Label0_37
        Me.Label0(36) = _Label0_36
        Me.Label0(35) = _Label0_35
        Me.Label0(34) = _Label0_34
        Me.Label0(33) = _Label0_33
        Me.Label0(32) = _Label0_32
        Me.Label0(31) = _Label0_31
        Me.Label0(30) = _Label0_30
        Me.Label0(29) = _Label0_29
        Me.Label0(28) = _Label0_28
        Me.Label0(27) = _Label0_27
        Me.Label0(26) = _Label0_26
        Me.Label0(25) = _Label0_25
        Me.Label0(24) = _Label0_24
        Me.Label0(23) = _Label0_23
        Me.Label0(0) = _Label0_0
        Me.Label0(3) = _Label0_3
        Me.Label0(4) = _Label0_4
        Me.Label0(5) = _Label0_5
        Me.Label0(6) = _Label0_6
        Me.Label0(7) = _Label0_7
        Me.Label0(8) = _Label0_8
        Me.Label0(9) = _Label0_9
        Me.Label0(10) = _Label0_10
        Me.Label0(11) = _Label0_11
        Me.Label0(12) = _Label0_12
        Me.Label0(13) = _Label0_13
        Me.Label0(14) = _Label0_14
        Me.Label0(15) = _Label0_15
        Me.Label0(16) = _Label0_16
        Me.Label0(17) = _Label0_17
        Me.Label0(18) = _Label0_18
        Me.Label0(19) = _Label0_19
        Me.Label0(20) = _Label0_20
        Me.Label0(21) = _Label0_21
        Me.Label0(22) = _Label0_22
        Me.Label0(50) = _Label0_50
        Me.Label0(49) = _Label0_49
        Me.Label0(52) = _Label0_52
        Me.Label0(51) = _Label0_51
        Me.Label0(163) = _Label0_163
        Me.Label0(162) = _Label0_162
        Me.Label0(160) = _Label0_160
        Me.Label0(158) = _Label0_158
        Me.Label0(157) = _Label0_157
        Me.Label0(156) = _Label0_156
        Me.Label0(155) = _Label0_155
        Me.Label0(154) = _Label0_154
        Me.Label0(153) = _Label0_153
        Me.Label0(152) = _Label0_152
        Me.Label0(151) = _Label0_151
        Me.Label0(150) = _Label0_150
        Me.Label0(149) = _Label0_149
        Me.Label0(148) = _Label0_148
        Me.Label0(147) = _Label0_147
        Me.Label0(146) = _Label0_146
        Me.Label0(145) = _Label0_145
        Me.Label0(144) = _Label0_144
        Me.Label0(140) = _Label0_140
        Me.Label0(120) = _Label0_120
        Me.Label0(1) = _Label0_1
        Me.Label0(2) = _Label0_2
        Me.Label0(119) = _Label0_119
        Me.Label0(118) = _Label0_118
        Me.Label0(112) = _Label0_112
        Me.Label0(111) = _Label0_111
        Me.Label0(110) = _Label0_110
        Me.Label0(109) = _Label0_109
        Me.Label0(108) = _Label0_108
        Me.Label0(107) = _Label0_107
        Me.Label0(106) = _Label0_106
        Me.Label0(105) = _Label0_105
        Me.Label0(97) = _Label0_97
        Me.Label0(96) = _Label0_96
        Me.Label0(95) = _Label0_95
        Me.Label0(94) = _Label0_94
        Me.Label0(93) = _Label0_93
        Me.Label0(92) = _Label0_92
        Me.Label0(91) = _Label0_91
        Me.Label0(115) = _Label0_115
        Me.Label0(114) = _Label0_114
        Me.Label0(113) = _Label0_113
        Me.Label0(104) = _Label0_104
        Me.Label0(103) = _Label0_103
        Me.Label0(102) = _Label0_102
        Me.Label0(101) = _Label0_101
        Me.Label0(99) = _Label0_99
        Me.Label0(98) = _Label0_98
        Me.Label0(90) = _Label0_90
        Me.Label0(89) = _Label0_89
        Me.Label0(88) = _Label0_88
        Me.Label0(87) = _Label0_87
        Me.Label0(86) = _Label0_86
        Me.Label0(85) = _Label0_85
        Me.Label0(84) = _Label0_84
        Me.Label0(83) = _Label0_83
        Me.Label0(82) = _Label0_82
        Me.Label0(81) = _Label0_81
        Me.Label0(80) = _Label0_80
        Me.Label0(79) = _Label0_79
        Me.Label0(78) = _Label0_78
        Me.Label0(77) = _Label0_77
        Me.Label0(76) = _Label0_76
        Me.Label0(75) = _Label0_75
        Me.Label0(74) = _Label0_74
        Me.Label0(73) = _Label0_73
        Me.Label0(72) = _Label0_72
        Me.Label0(71) = _Label0_71
        Me.Label0(70) = _Label0_70
        Me.Label0(69) = _Label0_69
        Me.Label0(68) = _Label0_68
        Me.Label0(67) = _Label0_67
        Me.Label0(66) = _Label0_66
        Me.Label0(65) = _Label0_65
        Me.Label0(64) = _Label0_64
        Me.Label0(63) = _Label0_63
        Me.Label0(62) = _Label0_62
        Me.Label0(61) = _Label0_61
        Me.Label0(60) = _Label0_60
        Me.Label0(59) = _Label0_59
        Me.Label0(116) = _Label0_116
        Me.Label0(117) = _Label0_117
        Me.Label0(100) = _Label0_100
        Me.Label0(143) = _Label0_143
        Me.Label0(142) = _Label0_142
        Me.Label0(141) = _Label0_141
        Me.Label0(139) = _Label0_139
        Me.Label0(138) = _Label0_138
        Me.Label0(137) = _Label0_137
        Me.Label0(136) = _Label0_136
        Me.Label0(135) = _Label0_135
        Me.Label0(134) = _Label0_134
        Me.Label0(133) = _Label0_133
        Me.Label0(132) = _Label0_132
        Me.Label0(131) = _Label0_131
        Me.Label0(130) = _Label0_130
        Me.Label0(129) = _Label0_129
        Me.Label0(128) = _Label0_128
        Me.Label0(127) = _Label0_127
        Me.Label0(126) = _Label0_126
        Me.Label0(125) = _Label0_125
        Me.Label0(124) = _Label0_124
        Me.Label0(123) = _Label0_123
        Me.Label0(122) = _Label0_122
        Me.Label0(121) = _Label0_121
    End Sub
    Sub InitializeLB()
        Me.LB(0) = _LB_0
        Me.LB(1) = _LB_1
        Me.LB(2) = _LB_2
    End Sub
    Sub InitializeFrame()
        Me.Frame(1) = _Frame_1
        Me.Frame(2) = _Frame_2
    End Sub
    Sub InitializeCommand()
        Me.Command(5) = _Command_5
        Me.Command(6) = _Command_6
        Me.Command(4) = _Command_4
        Me.Command(0) = _Command_0
        Me.Command(1) = _Command_1
        Me.Command(2) = _Command_2
    End Sub
    Private WithEvents _Label0_40 As System.Windows.Forms.Label
#End Region
End Class
