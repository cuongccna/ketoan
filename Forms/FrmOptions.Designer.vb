<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOptions
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
        isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		Initializecn()
		InitializeText_Renamed()
		InitializeOptVT()
		InitializeOptBH()
		InitializeLabel()
		InitializeFrame()
		InitializeCommand()
		InitializeCombo()
		InitializeChkVT()
		InitializeCheck()
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
    Private WithEvents _OptBH_2 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBH_1 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBH_0 As System.Windows.Forms.RadioButton
    Private WithEvents _Text_28 As System.Windows.Forms.TextBox
    Private WithEvents _Check_39 As System.Windows.Forms.CheckBox
    Private WithEvents _Text_27 As System.Windows.Forms.TextBox
    Private WithEvents _Text_26 As System.Windows.Forms.TextBox
    Private WithEvents _Check_28 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_55 As System.Windows.Forms.CheckBox
    Private WithEvents _Text_9 As System.Windows.Forms.TextBox
    Private WithEvents _Check_26 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_25 As System.Windows.Forms.CheckBox
    Private WithEvents _Combo_3 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Text_17 As System.Windows.Forms.TextBox
    Private WithEvents _Text_11 As System.Windows.Forms.TextBox
    Private WithEvents _Combo_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Text_18 As System.Windows.Forms.TextBox
    Private WithEvents _Text_12 As System.Windows.Forms.TextBox
    Private WithEvents _Text_23 As System.Windows.Forms.TextBox
    Private WithEvents _Text_0 As System.Windows.Forms.TextBox
    Private WithEvents _Text_1 As System.Windows.Forms.TextBox
    Private WithEvents _Text_2 As System.Windows.Forms.TextBox
    Private WithEvents _Text_3 As System.Windows.Forms.TextBox
    Private WithEvents _Text_4 As System.Windows.Forms.TextBox
    Private WithEvents _Text_5 As System.Windows.Forms.TextBox
    Private WithEvents _Text_6 As System.Windows.Forms.TextBox
    Private WithEvents _Text_7 As System.Windows.Forms.TextBox
    Private WithEvents _Combo_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Text_14 As System.Windows.Forms.TextBox
    Private WithEvents _Text_16 As System.Windows.Forms.TextBox
    Private WithEvents _Text_15 As System.Windows.Forms.TextBox
    Private WithEvents _Text_19 As System.Windows.Forms.TextBox
    Private WithEvents _Text_20 As System.Windows.Forms.TextBox
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Label_20 As System.Windows.Forms.Label
    Private WithEvents _Label_30 As System.Windows.Forms.Label
    Private WithEvents _Label_31 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Label_21 As System.Windows.Forms.Label
    Private WithEvents _Label_22 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_9 As System.Windows.Forms.Label
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Private WithEvents _Label_19 As System.Windows.Forms.Label
    Private WithEvents _Frame_0 As System.Windows.Forms.GroupBox
    Private WithEvents _Text_8 As System.Windows.Forms.TextBox
    Private WithEvents _Check_17 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_16 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_15 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_13 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_12 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_10 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_9 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_8 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_7 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_6 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_5 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_4 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_3 As System.Windows.Forms.CheckBox
    Private WithEvents _Text_13 As System.Windows.Forms.TextBox
    Private WithEvents _Check_2 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_1 As System.Windows.Forms.CheckBox
    Private WithEvents _Combo_2 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Check_18 As System.Windows.Forms.CheckBox
    Private WithEvents _Text_21 As System.Windows.Forms.TextBox
    Private WithEvents _Text_22 As System.Windows.Forms.TextBox
    Private WithEvents _Check_19 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_20 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_21 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_22 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_23 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_24 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_29 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_30 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_31 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_32 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_33 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_34 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_11 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_35 As System.Windows.Forms.CheckBox
    Private WithEvents _Text_25 As System.Windows.Forms.TextBox
    Private WithEvents _Check_36 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_37 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_38 As System.Windows.Forms.CheckBox
    Public WithEvents CTGS As ComboBoxEx.ComboBoxExt
    Private WithEvents _Check_0 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_14 As System.Windows.Forms.CheckBox
    Private WithEvents _Text_24 As System.Windows.Forms.TextBox
    Private WithEvents _Text_10 As System.Windows.Forms.TextBox
    Private WithEvents _Label_18 As System.Windows.Forms.Label
    Private WithEvents _Label_15 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Label_16 As System.Windows.Forms.Label
    Private WithEvents _Label_24 As System.Windows.Forms.Label
    Private WithEvents _Frame_1 As System.Windows.Forms.GroupBox
    Private WithEvents _Check_40 As System.Windows.Forms.CheckBox
    Private WithEvents _cn_1 As System.Windows.Forms.TextBox
    Private WithEvents _cn_2 As System.Windows.Forms.TextBox
    Private WithEvents _cn_3 As System.Windows.Forms.TextBox
    Private WithEvents _cn_4 As System.Windows.Forms.TextBox
    Private WithEvents _cn_5 As System.Windows.Forms.TextBox
    Private WithEvents _cn_6 As System.Windows.Forms.TextBox
    Private WithEvents _cn_8 As System.Windows.Forms.TextBox
    Private WithEvents _cn_7 As System.Windows.Forms.TextBox
    Private WithEvents _cn_10 As System.Windows.Forms.TextBox
    Private WithEvents _cn_9 As System.Windows.Forms.TextBox
    Private WithEvents _Label_23 As System.Windows.Forms.Label
    Private WithEvents _Label_25 As System.Windows.Forms.Label
    Private WithEvents _Label_26 As System.Windows.Forms.Label
    Private WithEvents _Label_27 As System.Windows.Forms.Label
    Private WithEvents _Label_28 As System.Windows.Forms.Label
    Private WithEvents _Label_29 As System.Windows.Forms.Label
    Private WithEvents _Label_33 As System.Windows.Forms.Label
    Private WithEvents _Label_34 As System.Windows.Forms.Label
    Private WithEvents _Label_35 As System.Windows.Forms.Label
    Private WithEvents _Label_36 As System.Windows.Forms.Label
    Private WithEvents _Frame_3 As System.Windows.Forms.GroupBox
    Public WithEvents ChkKBS As System.Windows.Forms.CheckBox
    Public WithEvents nnt As System.Windows.Forms.TextBox
    Private WithEvents _Label_32 As System.Windows.Forms.Label
    Private WithEvents _Frame_4 As System.Windows.Forms.GroupBox
    Public WithEvents ChkMonbai As System.Windows.Forms.CheckBox
    Private WithEvents _ChkVT_2 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkVT_1 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkVT_0 As System.Windows.Forms.CheckBox
    Private WithEvents _OptVT_3 As System.Windows.Forms.RadioButton
    Private WithEvents _OptVT_2 As System.Windows.Forms.RadioButton
    Private WithEvents _OptVT_1 As System.Windows.Forms.RadioButton
    Private WithEvents _OptVT_0 As System.Windows.Forms.RadioButton
    Private WithEvents _ChkVT_3 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkVT_4 As System.Windows.Forms.CheckBox
    Private WithEvents _Frame_2 As System.Windows.Forms.GroupBox
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Public Check(55) As System.Windows.Forms.CheckBox
    Public ChkVT(4) As System.Windows.Forms.CheckBox
    Public Combo(3) As ComboBoxEx.ComboBoxExt
    Public Command(3) As System.Windows.Forms.Button
    Public Command1(1) As System.Windows.Forms.Button
    Public Frame(4) As System.Windows.Forms.GroupBox
    Public Label(36) As System.Windows.Forms.Label
    Public OptBH(2) As System.Windows.Forms.RadioButton
    Public OptVT(3) As System.Windows.Forms.RadioButton
    Public Text_Renamed(28) As System.Windows.Forms.TextBox
    Public cn(10) As System.Windows.Forms.TextBox
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'Private listBoxComboBoxHelper1 As Artinsoft.VB6.Gui.ListControlHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Frame_0 = New System.Windows.Forms.GroupBox
        Me._Combo_1 = New ComboBoxEx.ComboBoxExt
        Me._OptBH_2 = New System.Windows.Forms.RadioButton
        Me._OptBH_1 = New System.Windows.Forms.RadioButton
        Me._OptBH_0 = New System.Windows.Forms.RadioButton
        Me._Text_28 = New System.Windows.Forms.TextBox
        Me._Check_39 = New System.Windows.Forms.CheckBox
        Me._Text_27 = New System.Windows.Forms.TextBox
        Me._Text_26 = New System.Windows.Forms.TextBox
        Me._Check_28 = New System.Windows.Forms.CheckBox
        Me._Check_55 = New System.Windows.Forms.CheckBox
        Me._Text_9 = New System.Windows.Forms.TextBox
        Me._Check_26 = New System.Windows.Forms.CheckBox
        Me._Check_25 = New System.Windows.Forms.CheckBox
        Me._Combo_3 = New ComboBoxEx.ComboBoxExt
        Me._Text_17 = New System.Windows.Forms.TextBox
        Me._Text_11 = New System.Windows.Forms.TextBox
        Me._Text_18 = New System.Windows.Forms.TextBox
        Me._Text_12 = New System.Windows.Forms.TextBox
        Me._Text_23 = New System.Windows.Forms.TextBox
        Me._Text_0 = New System.Windows.Forms.TextBox
        Me._Text_1 = New System.Windows.Forms.TextBox
        Me._Text_2 = New System.Windows.Forms.TextBox
        Me._Text_3 = New System.Windows.Forms.TextBox
        Me._Text_4 = New System.Windows.Forms.TextBox
        Me._Text_5 = New System.Windows.Forms.TextBox
        Me._Text_6 = New System.Windows.Forms.TextBox
        Me._Text_7 = New System.Windows.Forms.TextBox
        Me._Combo_0 = New ComboBoxEx.ComboBoxExt
        Me._Text_14 = New System.Windows.Forms.TextBox
        Me._Text_16 = New System.Windows.Forms.TextBox
        Me._Text_15 = New System.Windows.Forms.TextBox
        Me._Text_19 = New System.Windows.Forms.TextBox
        Me._Text_20 = New System.Windows.Forms.TextBox
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Label_20 = New System.Windows.Forms.Label
        Me._Label_30 = New System.Windows.Forms.Label
        Me._Label_31 = New System.Windows.Forms.Label
        Me._Label_12 = New System.Windows.Forms.Label
        Me._Label_11 = New System.Windows.Forms.Label
        Me._Label_21 = New System.Windows.Forms.Label
        Me._Label_22 = New System.Windows.Forms.Label
        Me._Label_14 = New System.Windows.Forms.Label
        Me._Label_13 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Label_5 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Label_9 = New System.Windows.Forms.Label
        Me._Label_17 = New System.Windows.Forms.Label
        Me._Label_19 = New System.Windows.Forms.Label
        Me._Frame_1 = New System.Windows.Forms.GroupBox
        Me._Check_37 = New System.Windows.Forms.CheckBox
        Me._Check_27 = New System.Windows.Forms.CheckBox
        Me._Text_8 = New System.Windows.Forms.TextBox
        Me._Check_17 = New System.Windows.Forms.CheckBox
        Me._Check_16 = New System.Windows.Forms.CheckBox
        Me._Check_15 = New System.Windows.Forms.CheckBox
        Me._Check_13 = New System.Windows.Forms.CheckBox
        Me._Check_12 = New System.Windows.Forms.CheckBox
        Me._Check_10 = New System.Windows.Forms.CheckBox
        Me._Check_9 = New System.Windows.Forms.CheckBox
        Me._Check_8 = New System.Windows.Forms.CheckBox
        Me._Check_7 = New System.Windows.Forms.CheckBox
        Me._Check_6 = New System.Windows.Forms.CheckBox
        Me._Check_5 = New System.Windows.Forms.CheckBox
        Me._Check_4 = New System.Windows.Forms.CheckBox
        Me._Check_3 = New System.Windows.Forms.CheckBox
        Me._Text_13 = New System.Windows.Forms.TextBox
        Me._Check_2 = New System.Windows.Forms.CheckBox
        Me._Check_1 = New System.Windows.Forms.CheckBox
        Me._Combo_2 = New ComboBoxEx.ComboBoxExt
        Me._Check_18 = New System.Windows.Forms.CheckBox
        Me._Text_21 = New System.Windows.Forms.TextBox
        Me._Text_22 = New System.Windows.Forms.TextBox
        Me._Check_19 = New System.Windows.Forms.CheckBox
        Me._Check_20 = New System.Windows.Forms.CheckBox
        Me._Check_21 = New System.Windows.Forms.CheckBox
        Me._Check_22 = New System.Windows.Forms.CheckBox
        Me._Check_23 = New System.Windows.Forms.CheckBox
        Me._Check_24 = New System.Windows.Forms.CheckBox
        Me._Check_29 = New System.Windows.Forms.CheckBox
        Me._Check_30 = New System.Windows.Forms.CheckBox
        Me._Check_31 = New System.Windows.Forms.CheckBox
        Me._Check_32 = New System.Windows.Forms.CheckBox
        Me._Check_33 = New System.Windows.Forms.CheckBox
        Me._Check_34 = New System.Windows.Forms.CheckBox
        Me._Check_11 = New System.Windows.Forms.CheckBox
        Me._Check_35 = New System.Windows.Forms.CheckBox
        Me._Text_25 = New System.Windows.Forms.TextBox
        Me._Check_36 = New System.Windows.Forms.CheckBox
        Me._Check_38 = New System.Windows.Forms.CheckBox
        Me.CTGS = New ComboBoxEx.ComboBoxExt
        Me._Check_0 = New System.Windows.Forms.CheckBox
        Me._Check_14 = New System.Windows.Forms.CheckBox
        Me._Text_24 = New System.Windows.Forms.TextBox
        Me._Text_10 = New System.Windows.Forms.TextBox
        Me._Label_18 = New System.Windows.Forms.Label
        Me._Label_15 = New System.Windows.Forms.Label
        Me._Label_10 = New System.Windows.Forms.Label
        Me._Label_16 = New System.Windows.Forms.Label
        Me._Label_24 = New System.Windows.Forms.Label
        Me._Check_40 = New System.Windows.Forms.CheckBox
        Me._Frame_4 = New System.Windows.Forms.GroupBox
        Me._Frame_3 = New System.Windows.Forms.GroupBox
        Me._cn_1 = New System.Windows.Forms.TextBox
        Me._cn_2 = New System.Windows.Forms.TextBox
        Me._cn_3 = New System.Windows.Forms.TextBox
        Me._cn_4 = New System.Windows.Forms.TextBox
        Me._cn_5 = New System.Windows.Forms.TextBox
        Me._cn_6 = New System.Windows.Forms.TextBox
        Me._cn_8 = New System.Windows.Forms.TextBox
        Me._cn_7 = New System.Windows.Forms.TextBox
        Me._cn_10 = New System.Windows.Forms.TextBox
        Me._cn_9 = New System.Windows.Forms.TextBox
        Me._Label_23 = New System.Windows.Forms.Label
        Me._Label_25 = New System.Windows.Forms.Label
        Me._Label_26 = New System.Windows.Forms.Label
        Me._Label_27 = New System.Windows.Forms.Label
        Me._Label_28 = New System.Windows.Forms.Label
        Me._Label_29 = New System.Windows.Forms.Label
        Me._Label_33 = New System.Windows.Forms.Label
        Me._Label_34 = New System.Windows.Forms.Label
        Me._Label_35 = New System.Windows.Forms.Label
        Me._Label_36 = New System.Windows.Forms.Label
        Me.ChkKBS = New System.Windows.Forms.CheckBox
        Me.nnt = New System.Windows.Forms.TextBox
        Me._Label_32 = New System.Windows.Forms.Label
        Me.ChkMonbai = New System.Windows.Forms.CheckBox
        Me._Frame_2 = New System.Windows.Forms.GroupBox
        Me._Check_43 = New System.Windows.Forms.CheckBox
        Me._ChkVT_2 = New System.Windows.Forms.CheckBox
        Me._ChkVT_1 = New System.Windows.Forms.CheckBox
        Me._ChkVT_0 = New System.Windows.Forms.CheckBox
        Me._OptVT_3 = New System.Windows.Forms.RadioButton
        Me._OptVT_2 = New System.Windows.Forms.RadioButton
        Me._OptVT_1 = New System.Windows.Forms.RadioButton
        Me._OptVT_0 = New System.Windows.Forms.RadioButton
        Me._ChkVT_3 = New System.Windows.Forms.CheckBox
        Me._ChkVT_4 = New System.Windows.Forms.CheckBox
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Check_41 = New System.Windows.Forms.CheckBox
        Me._Check_42 = New System.Windows.Forms.CheckBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tab_coban = New System.Windows.Forms.TabPage
        Me.tab_NangCao = New System.Windows.Forms.TabPage
        Me._Frame_0.SuspendLayout()
        Me._Frame_1.SuspendLayout()
        Me._Frame_4.SuspendLayout()
        Me._Frame_3.SuspendLayout()
        Me._Frame_2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tab_coban.SuspendLayout()
        Me.tab_NangCao.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Frame_0
        '
        Me._Frame_0.BackColor = System.Drawing.Color.Transparent
        Me._Frame_0.Controls.Add(Me._Combo_1)
        Me._Frame_0.Controls.Add(Me._OptBH_2)
        Me._Frame_0.Controls.Add(Me._OptBH_1)
        Me._Frame_0.Controls.Add(Me._OptBH_0)
        Me._Frame_0.Controls.Add(Me._Text_28)
        Me._Frame_0.Controls.Add(Me._Check_39)
        Me._Frame_0.Controls.Add(Me._Text_27)
        Me._Frame_0.Controls.Add(Me._Text_26)
        Me._Frame_0.Controls.Add(Me._Check_28)
        Me._Frame_0.Controls.Add(Me._Check_55)
        Me._Frame_0.Controls.Add(Me._Text_9)
        Me._Frame_0.Controls.Add(Me._Check_26)
        Me._Frame_0.Controls.Add(Me._Check_25)
        Me._Frame_0.Controls.Add(Me._Combo_3)
        Me._Frame_0.Controls.Add(Me._Text_17)
        Me._Frame_0.Controls.Add(Me._Text_11)
        Me._Frame_0.Controls.Add(Me._Text_18)
        Me._Frame_0.Controls.Add(Me._Text_12)
        Me._Frame_0.Controls.Add(Me._Text_23)
        Me._Frame_0.Controls.Add(Me._Text_0)
        Me._Frame_0.Controls.Add(Me._Text_1)
        Me._Frame_0.Controls.Add(Me._Text_2)
        Me._Frame_0.Controls.Add(Me._Text_3)
        Me._Frame_0.Controls.Add(Me._Text_4)
        Me._Frame_0.Controls.Add(Me._Text_5)
        Me._Frame_0.Controls.Add(Me._Text_6)
        Me._Frame_0.Controls.Add(Me._Text_7)
        Me._Frame_0.Controls.Add(Me._Combo_0)
        Me._Frame_0.Controls.Add(Me._Text_14)
        Me._Frame_0.Controls.Add(Me._Text_16)
        Me._Frame_0.Controls.Add(Me._Text_15)
        Me._Frame_0.Controls.Add(Me._Text_19)
        Me._Frame_0.Controls.Add(Me._Text_20)
        Me._Frame_0.Controls.Add(Me._Command_2)
        Me._Frame_0.Controls.Add(Me._Label_20)
        Me._Frame_0.Controls.Add(Me._Label_30)
        Me._Frame_0.Controls.Add(Me._Label_31)
        Me._Frame_0.Controls.Add(Me._Label_12)
        Me._Frame_0.Controls.Add(Me._Label_11)
        Me._Frame_0.Controls.Add(Me._Label_21)
        Me._Frame_0.Controls.Add(Me._Label_22)
        Me._Frame_0.Controls.Add(Me._Label_14)
        Me._Frame_0.Controls.Add(Me._Label_13)
        Me._Frame_0.Controls.Add(Me._Label_0)
        Me._Frame_0.Controls.Add(Me._Label_1)
        Me._Frame_0.Controls.Add(Me._Label_2)
        Me._Frame_0.Controls.Add(Me._Label_3)
        Me._Frame_0.Controls.Add(Me._Label_4)
        Me._Frame_0.Controls.Add(Me._Label_5)
        Me._Frame_0.Controls.Add(Me._Label_6)
        Me._Frame_0.Controls.Add(Me._Label_7)
        Me._Frame_0.Controls.Add(Me._Label_8)
        Me._Frame_0.Controls.Add(Me._Label_9)
        Me._Frame_0.Controls.Add(Me._Label_17)
        Me._Frame_0.Controls.Add(Me._Label_19)
        Me._Frame_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_0.Location = New System.Drawing.Point(6, 6)
        Me._Frame_0.Name = "_Frame_0"
        Me._Frame_0.Size = New System.Drawing.Size(705, 224)
        Me._Frame_0.TabIndex = 43
        Me._Frame_0.TabStop = False
        '
        '_Combo_1
        '
        Me._Combo_1.BackColor = System.Drawing.SystemColors.Window
        Me._Combo_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_1.DropDownWidth = 36
        Me._Combo_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_1.Location = New System.Drawing.Point(310, 172)
        Me._Combo_1.Name = "_Combo_1"
        Me._Combo_1.Size = New System.Drawing.Size(33, 21)
        Me._Combo_1.TabIndex = 20
        '
        '_OptBH_2
        '
        Me._OptBH_2.AutoSize = True
        Me._OptBH_2.BackColor = System.Drawing.Color.Transparent
        Me._OptBH_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBH_2.Enabled = False
        Me._OptBH_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBH_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBH_2.Location = New System.Drawing.Point(540, 147)
        Me._OptBH_2.Name = "_OptBH_2"
        Me._OptBH_2.Size = New System.Drawing.Size(38, 18)
        Me._OptBH_2.TabIndex = 148
        Me._OptBH_2.TabStop = True
        Me._OptBH_2.Text = "KT"
        Me._OptBH_2.UseVisualStyleBackColor = False
        Me._OptBH_2.Visible = False
        '
        '_OptBH_1
        '
        Me._OptBH_1.AutoSize = True
        Me._OptBH_1.BackColor = System.Drawing.Color.Transparent
        Me._OptBH_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBH_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBH_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBH_1.Location = New System.Drawing.Point(489, 147)
        Me._OptBH_1.Name = "_OptBH_1"
        Me._OptBH_1.Size = New System.Drawing.Size(39, 18)
        Me._OptBH_1.TabIndex = 97
        Me._OptBH_1.TabStop = True
        Me._OptBH_1.Text = "TM"
        Me._OptBH_1.UseVisualStyleBackColor = False
        Me._OptBH_1.Visible = False
        '
        '_OptBH_0
        '
        Me._OptBH_0.AutoSize = True
        Me._OptBH_0.BackColor = System.Drawing.Color.Transparent
        Me._OptBH_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBH_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBH_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBH_0.Location = New System.Drawing.Point(427, 147)
        Me._OptBH_0.Name = "_OptBH_0"
        Me._OptBH_0.Size = New System.Drawing.Size(39, 18)
        Me._OptBH_0.TabIndex = 96
        Me._OptBH_0.TabStop = True
        Me._OptBH_0.Text = "MP"
        Me._OptBH_0.UseVisualStyleBackColor = False
        Me._OptBH_0.Visible = False
        '
        '_Text_28
        '
        Me._Text_28.Location = New System.Drawing.Point(292, 198)
        Me._Text_28.MaxLength = 1
        Me._Text_28.Name = "_Text_28"
        Me._Text_28.Size = New System.Drawing.Size(12, 20)
        Me._Text_28.TabIndex = 92
        Me._Text_28.Text = "3"
        '
        '_Check_39
        '
        Me._Check_39.AutoSize = True
        Me._Check_39.BackColor = System.Drawing.Color.Transparent
        Me._Check_39.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_39.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_39.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_39.Location = New System.Drawing.Point(322, 199)
        Me._Check_39.Name = "_Check_39"
        Me._Check_39.Size = New System.Drawing.Size(122, 18)
        Me._Check_39.TabIndex = 91
        Me._Check_39.Text = "Không bán hàng âm"
        Me._Check_39.UseVisualStyleBackColor = False
        '
        '_Text_27
        '
        Me._Text_27.Location = New System.Drawing.Point(564, 16)
        Me._Text_27.MaxLength = 30
        Me._Text_27.Name = "_Text_27"
        Me._Text_27.ReadOnly = True
        Me._Text_27.Size = New System.Drawing.Size(35, 20)
        Me._Text_27.TabIndex = 1
        Me._Text_27.Text = "0"
        Me._Text_27.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._Text_27.Visible = False
        '
        '_Text_26
        '
        Me._Text_26.Location = New System.Drawing.Point(378, 42)
        Me._Text_26.MaxLength = 30
        Me._Text_26.Name = "_Text_26"
        Me._Text_26.Size = New System.Drawing.Size(145, 20)
        Me._Text_26.TabIndex = 5
        Me._Text_26.Text = "0"
        Me._Text_26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._Text_26.Visible = False
        '
        '_Check_28
        '
        Me._Check_28.AutoSize = True
        Me._Check_28.BackColor = System.Drawing.Color.Transparent
        Me._Check_28.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_28.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_28.Location = New System.Drawing.Point(487, 121)
        Me._Check_28.Name = "_Check_28"
        Me._Check_28.Size = New System.Drawing.Size(40, 18)
        Me._Check_28.TabIndex = 15
        Me._Check_28.Text = "SX"
        Me._Check_28.UseVisualStyleBackColor = False
        '
        '_Check_55
        '
        Me._Check_55.AutoSize = True
        Me._Check_55.BackColor = System.Drawing.Color.Transparent
        Me._Check_55.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_55.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_55.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_55.Location = New System.Drawing.Point(538, 43)
        Me._Check_55.Name = "_Check_55"
        Me._Check_55.Size = New System.Drawing.Size(98, 18)
        Me._Check_55.TabIndex = 4
        Me._Check_55.Text = "Báo cáo nội bộ"
        Me._Check_55.UseVisualStyleBackColor = False
        Me._Check_55.Visible = False
        '
        '_Text_9
        '
        Me._Text_9.Location = New System.Drawing.Point(483, 172)
        Me._Text_9.MaxLength = 20
        Me._Text_9.Name = "_Text_9"
        Me._Text_9.Size = New System.Drawing.Size(216, 20)
        Me._Text_9.TabIndex = 22
        Me._Text_9.Text = "..."
        Me._Text_9.Visible = False
        '
        '_Check_26
        '
        Me._Check_26.AutoSize = True
        Me._Check_26.BackColor = System.Drawing.Color.Transparent
        Me._Check_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_26.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_26.Location = New System.Drawing.Point(539, 121)
        Me._Check_26.Name = "_Check_26"
        Me._Check_26.Size = New System.Drawing.Size(40, 18)
        Me._Check_26.TabIndex = 16
        Me._Check_26.Text = "XD"
        Me._Check_26.UseVisualStyleBackColor = False
        '
        '_Check_25
        '
        Me._Check_25.AutoSize = True
        Me._Check_25.BackColor = System.Drawing.Color.Transparent
        Me._Check_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_25.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_25.Location = New System.Drawing.Point(426, 121)
        Me._Check_25.Name = "_Check_25"
        Me._Check_25.Size = New System.Drawing.Size(55, 18)
        Me._Check_25.TabIndex = 14
        Me._Check_25.Text = "TMDV"
        Me._Check_25.UseVisualStyleBackColor = False
        '
        '_Combo_3
        '
        Me._Combo_3.BackColor = System.Drawing.SystemColors.Window
        Me._Combo_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_3.DropDownWidth = 173
        Me._Combo_3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_3.Location = New System.Drawing.Point(483, 197)
        Me._Combo_3.Name = "_Combo_3"
        Me._Combo_3.Size = New System.Drawing.Size(216, 23)
        Me._Combo_3.TabIndex = 18
        Me._Combo_3.Visible = False
        '
        '_Text_17
        '
        Me._Text_17.Location = New System.Drawing.Point(202, 224)
        Me._Text_17.MaxLength = 30
        Me._Text_17.Name = "_Text_17"
        Me._Text_17.Size = New System.Drawing.Size(143, 20)
        Me._Text_17.TabIndex = 26
        Me._Text_17.Text = "..."
        Me._Text_17.Visible = False
        '
        '_Text_11
        '
        Me._Text_11.Location = New System.Drawing.Point(162, 198)
        Me._Text_11.MaxLength = 1
        Me._Text_11.Name = "_Text_11"
        Me._Text_11.Size = New System.Drawing.Size(12, 20)
        Me._Text_11.TabIndex = 23
        Me._Text_11.Text = "2"
        '
        '_Text_18
        '
        Me._Text_18.Location = New System.Drawing.Point(247, 198)
        Me._Text_18.MaxLength = 1
        Me._Text_18.Name = "_Text_18"
        Me._Text_18.Size = New System.Drawing.Size(12, 20)
        Me._Text_18.TabIndex = 25
        Me._Text_18.Text = "2"
        '
        '_Text_12
        '
        Me._Text_12.Location = New System.Drawing.Point(196, 198)
        Me._Text_12.MaxLength = 1
        Me._Text_12.Name = "_Text_12"
        Me._Text_12.Size = New System.Drawing.Size(12, 20)
        Me._Text_12.TabIndex = 24
        Me._Text_12.Text = "2"
        '
        '_Text_23
        '
        Me._Text_23.Location = New System.Drawing.Point(351, 224)
        Me._Text_23.MaxLength = 7
        Me._Text_23.Name = "_Text_23"
        Me._Text_23.Size = New System.Drawing.Size(47, 20)
        Me._Text_23.TabIndex = 39
        Me._Text_23.Visible = False
        '
        '_Text_0
        '
        Me._Text_0.Location = New System.Drawing.Point(162, 16)
        Me._Text_0.MaxLength = 250
        Me._Text_0.Name = "_Text_0"
        Me._Text_0.Size = New System.Drawing.Size(361, 20)
        Me._Text_0.TabIndex = 0
        Me._Text_0.Text = "..."
        '
        '_Text_1
        '
        Me._Text_1.Location = New System.Drawing.Point(538, 94)
        Me._Text_1.MaxLength = 50
        Me._Text_1.Name = "_Text_1"
        Me._Text_1.Size = New System.Drawing.Size(161, 20)
        Me._Text_1.TabIndex = 12
        Me._Text_1.Text = "..."
        '
        '_Text_2
        '
        Me._Text_2.Location = New System.Drawing.Point(162, 68)
        Me._Text_2.MaxLength = 100
        Me._Text_2.Name = "_Text_2"
        Me._Text_2.Size = New System.Drawing.Size(210, 20)
        Me._Text_2.TabIndex = 6
        Me._Text_2.Text = "..."
        '
        '_Text_3
        '
        Me._Text_3.Location = New System.Drawing.Point(162, 94)
        Me._Text_3.MaxLength = 50
        Me._Text_3.Name = "_Text_3"
        Me._Text_3.Size = New System.Drawing.Size(63, 20)
        Me._Text_3.TabIndex = 9
        Me._Text_3.Text = "0"
        '
        '_Text_4
        '
        Me._Text_4.Location = New System.Drawing.Point(256, 94)
        Me._Text_4.MaxLength = 20
        Me._Text_4.Name = "_Text_4"
        Me._Text_4.Size = New System.Drawing.Size(84, 20)
        Me._Text_4.TabIndex = 10
        Me._Text_4.Text = "0"
        '
        '_Text_5
        '
        Me._Text_5.Location = New System.Drawing.Point(162, 120)
        Me._Text_5.MaxLength = 250
        Me._Text_5.Name = "_Text_5"
        Me._Text_5.Size = New System.Drawing.Size(178, 20)
        Me._Text_5.TabIndex = 13
        Me._Text_5.Text = "..."
        '
        '_Text_6
        '
        Me._Text_6.Location = New System.Drawing.Point(162, 146)
        Me._Text_6.MaxLength = 250
        Me._Text_6.Name = "_Text_6"
        Me._Text_6.Size = New System.Drawing.Size(178, 20)
        Me._Text_6.TabIndex = 17
        Me._Text_6.Text = "..."
        '
        '_Text_7
        '
        Me._Text_7.Location = New System.Drawing.Point(162, 42)
        Me._Text_7.MaxLength = 20
        Me._Text_7.Name = "_Text_7"
        Me._Text_7.Size = New System.Drawing.Size(178, 20)
        Me._Text_7.TabIndex = 3
        Me._Text_7.Text = "..."
        '
        '_Combo_0
        '
        Me._Combo_0.BackColor = System.Drawing.SystemColors.Window
        Me._Combo_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_0.Location = New System.Drawing.Point(162, 172)
        Me._Combo_0.Name = "_Combo_0"
        Me._Combo_0.Size = New System.Drawing.Size(52, 21)
        Me._Combo_0.TabIndex = 19
        '
        '_Text_14
        '
        Me._Text_14.Location = New System.Drawing.Point(449, 172)
        Me._Text_14.MaxLength = 2
        Me._Text_14.Name = "_Text_14"
        Me._Text_14.Size = New System.Drawing.Size(29, 20)
        Me._Text_14.TabIndex = 21
        Me._Text_14.Text = "0"
        '
        '_Text_16
        '
        Me._Text_16.Location = New System.Drawing.Point(409, 224)
        Me._Text_16.MaxLength = 30
        Me._Text_16.Name = "_Text_16"
        Me._Text_16.Size = New System.Drawing.Size(114, 20)
        Me._Text_16.TabIndex = 40
        Me._Text_16.Text = "..."
        Me._Text_16.Visible = False
        '
        '_Text_15
        '
        Me._Text_15.Location = New System.Drawing.Point(378, 94)
        Me._Text_15.MaxLength = 30
        Me._Text_15.Name = "_Text_15"
        Me._Text_15.Size = New System.Drawing.Size(145, 20)
        Me._Text_15.TabIndex = 11
        Me._Text_15.Text = "..."
        '
        '_Text_19
        '
        Me._Text_19.Location = New System.Drawing.Point(378, 68)
        Me._Text_19.MaxLength = 30
        Me._Text_19.Name = "_Text_19"
        Me._Text_19.Size = New System.Drawing.Size(144, 20)
        Me._Text_19.TabIndex = 7
        Me._Text_19.Text = "..."
        '
        '_Text_20
        '
        Me._Text_20.Location = New System.Drawing.Point(538, 68)
        Me._Text_20.MaxLength = 30
        Me._Text_20.Name = "_Text_20"
        Me._Text_20.Size = New System.Drawing.Size(161, 20)
        Me._Text_20.TabIndex = 8
        Me._Text_20.Text = "..."
        '
        '_Command_2
        '
        Me._Command_2.AutoSize = True
        Me._Command_2.Location = New System.Drawing.Point(605, 14)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(40, 24)
        Me._Command_2.TabIndex = 2
        Me._Command_2.Text = "Tỷ lệ"
        Me._Command_2.Visible = False
        '
        '_Label_20
        '
        Me._Label_20.AutoSize = True
        Me._Label_20.BackColor = System.Drawing.Color.Transparent
        Me._Label_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_20.Location = New System.Drawing.Point(265, 201)
        Me._Label_20.Name = "_Label_20"
        Me._Label_20.Size = New System.Drawing.Size(22, 14)
        Me._Label_20.TabIndex = 93
        Me._Label_20.Text = "HĐ"
        '
        '_Label_30
        '
        Me._Label_30.AutoSize = True
        Me._Label_30.BackColor = System.Drawing.Color.Transparent
        Me._Label_30.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_30.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_30.Location = New System.Drawing.Point(345, 45)
        Me._Label_30.Name = "_Label_30"
        Me._Label_30.Size = New System.Drawing.Size(27, 14)
        Me._Label_30.TabIndex = 64
        Me._Label_30.Tag = "Company"
        Me._Label_30.Text = "Vốn"
        Me._Label_30.Visible = False
        '
        '_Label_31
        '
        Me._Label_31.AutoSize = True
        Me._Label_31.BackColor = System.Drawing.Color.Transparent
        Me._Label_31.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_31.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_31.Location = New System.Drawing.Point(535, 19)
        Me._Label_31.Name = "_Label_31"
        Me._Label_31.Size = New System.Drawing.Size(26, 14)
        Me._Label_31.TabIndex = 63
        Me._Label_31.Tag = "Company"
        Me._Label_31.Text = "Bậc"
        Me._Label_31.Visible = False
        '
        '_Label_12
        '
        Me._Label_12.AutoSize = True
        Me._Label_12.BackColor = System.Drawing.Color.Transparent
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_12.Location = New System.Drawing.Point(348, 123)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.Size = New System.Drawing.Size(67, 14)
        Me._Label_12.TabIndex = 61
        Me._Label_12.Tag = "Activities"
        Me._Label_12.Text = "Lĩnh vực HĐ"
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.Transparent
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_11.Location = New System.Drawing.Point(396, 204)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(46, 10)
        Me._Label_11.TabIndex = 60
        Me._Label_11.Tag = "Class"
        Me._Label_11.Text = "Loại hình DN"
        Me._Label_11.Visible = False
        '
        '_Label_21
        '
        Me._Label_21.AutoSize = True
        Me._Label_21.BackColor = System.Drawing.Color.Transparent
        Me._Label_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_21.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_21.Location = New System.Drawing.Point(164, 227)
        Me._Label_21.Name = "_Label_21"
        Me._Label_21.Size = New System.Drawing.Size(31, 14)
        Me._Label_21.TabIndex = 59
        Me._Label_21.Tag = "Send data to default addr"
        Me._Label_21.Text = "Email"
        Me._Label_21.Visible = False
        '
        '_Label_22
        '
        Me._Label_22.AutoSize = True
        Me._Label_22.BackColor = System.Drawing.Color.Transparent
        Me._Label_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_22.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_22.Location = New System.Drawing.Point(174, 201)
        Me._Label_22.Name = "_Label_22"
        Me._Label_22.Size = New System.Drawing.Size(21, 14)
        Me._Label_22.TabIndex = 58
        Me._Label_22.Text = "chi"
        '
        '_Label_14
        '
        Me._Label_14.AutoSize = True
        Me._Label_14.BackColor = System.Drawing.Color.Transparent
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_14.Location = New System.Drawing.Point(215, 201)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(28, 14)
        Me._Label_14.TabIndex = 57
        Me._Label_14.Text = "UNC"
        '
        '_Label_13
        '
        Me._Label_13.AutoSize = True
        Me._Label_13.BackColor = System.Drawing.Color.Transparent
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_13.Location = New System.Drawing.Point(13, 201)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(114, 14)
        Me._Label_13.TabIndex = 56
        Me._Label_13.Text = "Số lần in mỗi phiếu thu"
        '
        '_Label_0
        '
        Me._Label_0.AutoSize = True
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(13, 19)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(64, 14)
        Me._Label_0.TabIndex = 55
        Me._Label_0.Tag = "Company"
        Me._Label_0.Text = "Tên công ty"
        '
        '_Label_1
        '
        Me._Label_1.AutoSize = True
        Me._Label_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(13, 227)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(75, 14)
        Me._Label_1.TabIndex = 54
        Me._Label_1.Tag = "Branch Name"
        Me._Label_1.Text = "Tên chi nhánh"
        Me._Label_1.Visible = False
        '
        '_Label_2
        '
        Me._Label_2.AutoSize = True
        Me._Label_2.BackColor = System.Drawing.Color.Transparent
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(13, 71)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(103, 14)
        Me._Label_2.TabIndex = 53
        Me._Label_2.Tag = "Address"
        Me._Label_2.Text = "Địa chỉ, quận, t. phố"
        '
        '_Label_3
        '
        Me._Label_3.AutoSize = True
        Me._Label_3.BackColor = System.Drawing.Color.Transparent
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_3.Location = New System.Drawing.Point(13, 97)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(55, 14)
        Me._Label_3.TabIndex = 52
        Me._Label_3.Tag = "Tel"
        Me._Label_3.Text = "Điện thoại"
        '
        '_Label_4
        '
        Me._Label_4.AutoSize = True
        Me._Label_4.BackColor = System.Drawing.Color.Transparent
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_4.Location = New System.Drawing.Point(228, 97)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(25, 14)
        Me._Label_4.TabIndex = 51
        Me._Label_4.Text = "Fax"
        '
        '_Label_5
        '
        Me._Label_5.AutoSize = True
        Me._Label_5.BackColor = System.Drawing.Color.Transparent
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_5.Location = New System.Drawing.Point(13, 123)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(98, 14)
        Me._Label_5.TabIndex = 50
        Me._Label_5.Tag = "Bank VND Account"
        Me._Label_5.Text = "Tài khoản Tiền Việt"
        '
        '_Label_6
        '
        Me._Label_6.AutoSize = True
        Me._Label_6.BackColor = System.Drawing.Color.Transparent
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_6.Location = New System.Drawing.Point(13, 149)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(95, 14)
        Me._Label_6.TabIndex = 49
        Me._Label_6.Tag = "Bank F.C. Account"
        Me._Label_6.Text = "Tài khoản Ngoại tệ"
        '
        '_Label_7
        '
        Me._Label_7.AutoSize = True
        Me._Label_7.BackColor = System.Drawing.Color.Transparent
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_7.Location = New System.Drawing.Point(13, 45)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(60, 14)
        Me._Label_7.TabIndex = 48
        Me._Label_7.Tag = "Tax Code"
        Me._Label_7.Text = "Mã số thuế"
        '
        '_Label_8
        '
        Me._Label_8.AutoSize = True
        Me._Label_8.BackColor = System.Drawing.Color.Transparent
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_8.Location = New System.Drawing.Point(13, 175)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(71, 14)
        Me._Label_8.TabIndex = 47
        Me._Label_8.Tag = "Year"
        Me._Label_8.Text = "Năm tài chính"
        '
        '_Label_9
        '
        Me._Label_9.AutoSize = True
        Me._Label_9.BackColor = System.Drawing.Color.Transparent
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_9.Location = New System.Drawing.Point(218, 175)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.Size = New System.Drawing.Size(87, 14)
        Me._Label_9.TabIndex = 46
        Me._Label_9.Tag = "FROM month"
        Me._Label_9.Text = "Bắt đầu từ tháng"
        '
        '_Label_17
        '
        Me._Label_17.AutoSize = True
        Me._Label_17.BackColor = System.Drawing.Color.Transparent
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_17.Location = New System.Drawing.Point(350, 175)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(83, 14)
        Me._Label_17.TabIndex = 45
        Me._Label_17.Tag = "Month FROM Date"
        Me._Label_17.Text = "Ngày đầu tháng"
        '
        '_Label_19
        '
        Me._Label_19.AutoSize = True
        Me._Label_19.BackColor = System.Drawing.Color.Transparent
        Me._Label_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_19.Location = New System.Drawing.Point(343, 97)
        Me._Label_19.Name = "_Label_19"
        Me._Label_19.Size = New System.Drawing.Size(31, 14)
        Me._Label_19.TabIndex = 44
        Me._Label_19.Text = "Email"
        '
        '_Frame_1
        '
        Me._Frame_1.Controls.Add(Me._Check_37)
        Me._Frame_1.Controls.Add(Me._Check_27)
        Me._Frame_1.Controls.Add(Me._Text_8)
        Me._Frame_1.Controls.Add(Me._Check_17)
        Me._Frame_1.Controls.Add(Me._Check_16)
        Me._Frame_1.Controls.Add(Me._Check_15)
        Me._Frame_1.Controls.Add(Me._Check_13)
        Me._Frame_1.Controls.Add(Me._Check_12)
        Me._Frame_1.Controls.Add(Me._Check_10)
        Me._Frame_1.Controls.Add(Me._Check_9)
        Me._Frame_1.Controls.Add(Me._Check_8)
        Me._Frame_1.Controls.Add(Me._Check_7)
        Me._Frame_1.Controls.Add(Me._Check_6)
        Me._Frame_1.Controls.Add(Me._Check_5)
        Me._Frame_1.Controls.Add(Me._Check_4)
        Me._Frame_1.Controls.Add(Me._Check_3)
        Me._Frame_1.Controls.Add(Me._Text_13)
        Me._Frame_1.Controls.Add(Me._Check_2)
        Me._Frame_1.Controls.Add(Me._Check_1)
        Me._Frame_1.Controls.Add(Me._Combo_2)
        Me._Frame_1.Controls.Add(Me._Check_18)
        Me._Frame_1.Controls.Add(Me._Text_21)
        Me._Frame_1.Controls.Add(Me._Text_22)
        Me._Frame_1.Controls.Add(Me._Check_19)
        Me._Frame_1.Controls.Add(Me._Check_20)
        Me._Frame_1.Controls.Add(Me._Check_21)
        Me._Frame_1.Controls.Add(Me._Check_22)
        Me._Frame_1.Controls.Add(Me._Check_23)
        Me._Frame_1.Controls.Add(Me._Check_24)
        Me._Frame_1.Controls.Add(Me._Check_29)
        Me._Frame_1.Controls.Add(Me._Check_30)
        Me._Frame_1.Controls.Add(Me._Check_31)
        Me._Frame_1.Controls.Add(Me._Check_32)
        Me._Frame_1.Controls.Add(Me._Check_33)
        Me._Frame_1.Controls.Add(Me._Check_34)
        Me._Frame_1.Controls.Add(Me._Check_11)
        Me._Frame_1.Controls.Add(Me._Check_35)
        Me._Frame_1.Controls.Add(Me._Text_25)
        Me._Frame_1.Controls.Add(Me._Check_36)
        Me._Frame_1.Controls.Add(Me._Check_38)
        Me._Frame_1.Controls.Add(Me.CTGS)
        Me._Frame_1.Controls.Add(Me._Check_0)
        Me._Frame_1.Controls.Add(Me._Check_14)
        Me._Frame_1.Controls.Add(Me._Text_24)
        Me._Frame_1.Controls.Add(Me._Text_10)
        Me._Frame_1.Controls.Add(Me._Label_18)
        Me._Frame_1.Controls.Add(Me._Label_15)
        Me._Frame_1.Controls.Add(Me._Label_10)
        Me._Frame_1.Controls.Add(Me._Label_16)
        Me._Frame_1.Controls.Add(Me._Label_24)
        Me._Frame_1.Location = New System.Drawing.Point(6, 6)
        Me._Frame_1.Name = "_Frame_1"
        Me._Frame_1.Size = New System.Drawing.Size(705, 510)
        Me._Frame_1.TabIndex = 98
        Me._Frame_1.TabStop = False
        '
        '_Check_37
        '
        Me._Check_37.AutoSize = True
        Me._Check_37.BackColor = System.Drawing.Color.Transparent
        Me._Check_37.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_37.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_37.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_37.Location = New System.Drawing.Point(174, 51)
        Me._Check_37.Name = "_Check_37"
        Me._Check_37.Size = New System.Drawing.Size(93, 18)
        Me._Check_37.TabIndex = 105
        Me._Check_37.Text = "Nhập theo tên"
        Me._Check_37.UseVisualStyleBackColor = False
        '
        '_Check_27
        '
        Me._Check_27.AutoSize = True
        Me._Check_27.BackColor = System.Drawing.Color.Transparent
        Me._Check_27.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_27.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_27.Location = New System.Drawing.Point(360, 265)
        Me._Check_27.Name = "_Check_27"
        Me._Check_27.Size = New System.Drawing.Size(117, 18)
        Me._Check_27.TabIndex = 148
        Me._Check_27.Text = "Chứng từ tổng hợp"
        Me._Check_27.UseVisualStyleBackColor = False
        '
        '_Text_8
        '
        Me._Text_8.Location = New System.Drawing.Point(242, 284)
        Me._Text_8.MaxLength = 50
        Me._Text_8.Name = "_Text_8"
        Me._Text_8.Size = New System.Drawing.Size(101, 20)
        Me._Text_8.TabIndex = 142
        Me._Text_8.Text = "..."
        '
        '_Check_17
        '
        Me._Check_17.AutoSize = True
        Me._Check_17.BackColor = System.Drawing.Color.Transparent
        Me._Check_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_17.Location = New System.Drawing.Point(8, 285)
        Me._Check_17.Name = "_Check_17"
        Me._Check_17.Size = New System.Drawing.Size(220, 18)
        Me._Check_17.TabIndex = 141
        Me._Check_17.Text = "Chương trình sửa đổi theo doanh nghiệp"
        Me._Check_17.UseVisualStyleBackColor = False
        '
        '_Check_16
        '
        Me._Check_16.AutoSize = True
        Me._Check_16.BackColor = System.Drawing.Color.Transparent
        Me._Check_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_16.Location = New System.Drawing.Point(8, 267)
        Me._Check_16.Name = "_Check_16"
        Me._Check_16.Size = New System.Drawing.Size(182, 18)
        Me._Check_16.TabIndex = 140
        Me._Check_16.Text = "Cho sử dụng chức năng đổi font"
        Me._Check_16.UseVisualStyleBackColor = False
        Me._Check_16.Visible = False
        '
        '_Check_15
        '
        Me._Check_15.AutoSize = True
        Me._Check_15.BackColor = System.Drawing.Color.Transparent
        Me._Check_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_15.Location = New System.Drawing.Point(8, 249)
        Me._Check_15.Name = "_Check_15"
        Me._Check_15.Size = New System.Drawing.Size(186, 18)
        Me._Check_15.TabIndex = 139
        Me._Check_15.Text = "Quản lý quyền xem từng báo cáo"
        Me._Check_15.UseVisualStyleBackColor = False
        '
        '_Check_13
        '
        Me._Check_13.AutoSize = True
        Me._Check_13.BackColor = System.Drawing.Color.Transparent
        Me._Check_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_13.Location = New System.Drawing.Point(8, 123)
        Me._Check_13.Name = "_Check_13"
        Me._Check_13.Size = New System.Drawing.Size(185, 18)
        Me._Check_13.TabIndex = 138
        Me._Check_13.Text = "Định mức thành phẩm theo tháng"
        Me._Check_13.UseVisualStyleBackColor = False
        '
        '_Check_12
        '
        Me._Check_12.AutoSize = True
        Me._Check_12.BackColor = System.Drawing.Color.Transparent
        Me._Check_12.Checked = True
        Me._Check_12.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Check_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_12.Location = New System.Drawing.Point(451, 87)
        Me._Check_12.Name = "_Check_12"
        Me._Check_12.Size = New System.Drawing.Size(87, 18)
        Me._Check_12.TabIndex = 137
        Me._Check_12.Text = "NK chứng từ"
        Me._Check_12.UseVisualStyleBackColor = False
        '
        '_Check_10
        '
        Me._Check_10.AutoSize = True
        Me._Check_10.BackColor = System.Drawing.Color.Transparent
        Me._Check_10.Checked = True
        Me._Check_10.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Check_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_10.Location = New System.Drawing.Point(451, 63)
        Me._Check_10.Name = "_Check_10"
        Me._Check_10.Size = New System.Drawing.Size(95, 18)
        Me._Check_10.TabIndex = 136
        Me._Check_10.Text = "Nhật ký chung"
        Me._Check_10.UseVisualStyleBackColor = False
        '
        '_Check_9
        '
        Me._Check_9.AutoSize = True
        Me._Check_9.BackColor = System.Drawing.Color.Transparent
        Me._Check_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_9.Location = New System.Drawing.Point(8, 177)
        Me._Check_9.Name = "_Check_9"
        Me._Check_9.Size = New System.Drawing.Size(159, 18)
        Me._Check_9.TabIndex = 135
        Me._Check_9.Text = "In báo cáo thuế có mã vạch"
        Me._Check_9.UseVisualStyleBackColor = False
        '
        '_Check_8
        '
        Me._Check_8.AutoSize = True
        Me._Check_8.BackColor = System.Drawing.Color.Transparent
        Me._Check_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_8.Location = New System.Drawing.Point(8, 231)
        Me._Check_8.Name = "_Check_8"
        Me._Check_8.Size = New System.Drawing.Size(250, 18)
        Me._Check_8.TabIndex = 134
        Me._Check_8.Text = "Kiểm tra tỷ lệ thuế các mặt hàng cùng hoá đơn"
        Me._Check_8.UseVisualStyleBackColor = False
        '
        '_Check_7
        '
        Me._Check_7.AutoSize = True
        Me._Check_7.BackColor = System.Drawing.Color.Transparent
        Me._Check_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_7.Location = New System.Drawing.Point(8, 213)
        Me._Check_7.Name = "_Check_7"
        Me._Check_7.Size = New System.Drawing.Size(178, 18)
        Me._Check_7.TabIndex = 133
        Me._Check_7.Text = "In chi tiết mặt hàng trên bảng kê"
        Me._Check_7.UseVisualStyleBackColor = False
        '
        '_Check_6
        '
        Me._Check_6.AutoSize = True
        Me._Check_6.BackColor = System.Drawing.Color.Transparent
        Me._Check_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_6.Location = New System.Drawing.Point(8, 195)
        Me._Check_6.Name = "_Check_6"
        Me._Check_6.Size = New System.Drawing.Size(237, 18)
        Me._Check_6.TabIndex = 132
        Me._Check_6.Text = "Tự động trừ lùi thuế GTGT trên hoá đơn bán"
        Me._Check_6.UseVisualStyleBackColor = False
        '
        '_Check_5
        '
        Me._Check_5.AutoSize = True
        Me._Check_5.BackColor = System.Drawing.Color.Transparent
        Me._Check_5.Checked = True
        Me._Check_5.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Check_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_5.Location = New System.Drawing.Point(8, 105)
        Me._Check_5.Name = "_Check_5"
        Me._Check_5.Size = New System.Drawing.Size(186, 18)
        Me._Check_5.TabIndex = 131
        Me._Check_5.Text = "Tập hợp giá thành theo đối tượng"
        Me._Check_5.UseVisualStyleBackColor = False
        '
        '_Check_4
        '
        Me._Check_4.AutoSize = True
        Me._Check_4.BackColor = System.Drawing.Color.Transparent
        Me._Check_4.Checked = True
        Me._Check_4.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Check_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_4.Location = New System.Drawing.Point(8, 87)
        Me._Check_4.Name = "_Check_4"
        Me._Check_4.Size = New System.Drawing.Size(176, 18)
        Me._Check_4.TabIndex = 130
        Me._Check_4.Text = "Tự động xuất giá vốn hàng bán"
        Me._Check_4.UseVisualStyleBackColor = False
        '
        '_Check_3
        '
        Me._Check_3.AutoSize = True
        Me._Check_3.BackColor = System.Drawing.Color.Transparent
        Me._Check_3.Checked = True
        Me._Check_3.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Check_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_3.Location = New System.Drawing.Point(8, 69)
        Me._Check_3.Name = "_Check_3"
        Me._Check_3.Size = New System.Drawing.Size(95, 18)
        Me._Check_3.TabIndex = 129
        Me._Check_3.Text = "Hạch toán kép"
        Me._Check_3.UseVisualStyleBackColor = False
        '
        '_Text_13
        '
        Me._Text_13.Location = New System.Drawing.Point(529, 134)
        Me._Text_13.MaxLength = 2
        Me._Text_13.Name = "_Text_13"
        Me._Text_13.Size = New System.Drawing.Size(51, 20)
        Me._Text_13.TabIndex = 128
        Me._Text_13.Text = "2"
        '
        '_Check_2
        '
        Me._Check_2.AutoSize = True
        Me._Check_2.BackColor = System.Drawing.Color.Transparent
        Me._Check_2.Checked = True
        Me._Check_2.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Check_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_2.Location = New System.Drawing.Point(8, 51)
        Me._Check_2.Name = "_Check_2"
        Me._Check_2.Size = New System.Drawing.Size(144, 18)
        Me._Check_2.TabIndex = 127
        Me._Check_2.Text = "Theo dõi chi tiết công nợ"
        Me._Check_2.UseVisualStyleBackColor = False
        '
        '_Check_1
        '
        Me._Check_1.AutoSize = True
        Me._Check_1.BackColor = System.Drawing.Color.Transparent
        Me._Check_1.Checked = True
        Me._Check_1.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Check_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_1.Location = New System.Drawing.Point(8, 33)
        Me._Check_1.Name = "_Check_1"
        Me._Check_1.Size = New System.Drawing.Size(174, 18)
        Me._Check_1.TabIndex = 126
        Me._Check_1.Text = "Theo dõi chi tiết tài sản cố định"
        Me._Check_1.UseVisualStyleBackColor = False
        '
        '_Combo_2
        '
        Me._Combo_2.BackColor = System.Drawing.Color.White
        Me._Combo_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_2.Location = New System.Drawing.Point(465, 160)
        Me._Combo_2.Name = "_Combo_2"
        Me._Combo_2.Size = New System.Drawing.Size(115, 21)
        Me._Combo_2.TabIndex = 125
        '
        '_Check_18
        '
        Me._Check_18.AutoSize = True
        Me._Check_18.BackColor = System.Drawing.Color.Transparent
        Me._Check_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_18.Location = New System.Drawing.Point(8, 303)
        Me._Check_18.Name = "_Check_18"
        Me._Check_18.Size = New System.Drawing.Size(270, 18)
        Me._Check_18.TabIndex = 124
        Me._Check_18.Text = "Theo dõi tỷ giá từng chứng từ với tỷ giá đầu năm là"
        Me._Check_18.UseVisualStyleBackColor = False
        '
        '_Text_21
        '
        Me._Text_21.Location = New System.Drawing.Point(296, 302)
        Me._Text_21.MaxLength = 20
        Me._Text_21.Name = "_Text_21"
        Me._Text_21.Size = New System.Drawing.Size(47, 20)
        Me._Text_21.TabIndex = 123
        Me._Text_21.Text = "0"
        '
        '_Text_22
        '
        Me._Text_22.BackColor = System.Drawing.Color.White
        Me._Text_22.Location = New System.Drawing.Point(625, 160)
        Me._Text_22.MaxLength = 20
        Me._Text_22.Name = "_Text_22"
        Me._Text_22.Size = New System.Drawing.Size(70, 20)
        Me._Text_22.TabIndex = 122
        '
        '_Check_19
        '
        Me._Check_19.AutoSize = True
        Me._Check_19.BackColor = System.Drawing.Color.Transparent
        Me._Check_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_19.Location = New System.Drawing.Point(360, 187)
        Me._Check_19.Name = "_Check_19"
        Me._Check_19.Size = New System.Drawing.Size(192, 18)
        Me._Check_19.TabIndex = 121
        Me._Check_19.Text = "Cho phép điều chỉnh tên chi nhánh"
        Me._Check_19.UseVisualStyleBackColor = False
        '
        '_Check_20
        '
        Me._Check_20.AutoSize = True
        Me._Check_20.BackColor = System.Drawing.Color.Transparent
        Me._Check_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_20.Location = New System.Drawing.Point(8, 378)
        Me._Check_20.Name = "_Check_20"
        Me._Check_20.Size = New System.Drawing.Size(223, 18)
        Me._Check_20.TabIndex = 120
        Me._Check_20.Text = "Cho sử dụng chức năng tổng hợp số liệu"
        Me._Check_20.UseVisualStyleBackColor = False
        '
        '_Check_21
        '
        Me._Check_21.AutoSize = True
        Me._Check_21.BackColor = System.Drawing.Color.Transparent
        Me._Check_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_21.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_21.Location = New System.Drawing.Point(8, 141)
        Me._Check_21.Name = "_Check_21"
        Me._Check_21.Size = New System.Drawing.Size(105, 18)
        Me._Check_21.TabIndex = 119
        Me._Check_21.Text = "Tỷ giá bình quân"
        Me._Check_21.UseVisualStyleBackColor = False
        '
        '_Check_22
        '
        Me._Check_22.AutoSize = True
        Me._Check_22.BackColor = System.Drawing.Color.Transparent
        Me._Check_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_22.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_22.Location = New System.Drawing.Point(8, 159)
        Me._Check_22.Name = "_Check_22"
        Me._Check_22.Size = New System.Drawing.Size(117, 18)
        Me._Check_22.TabIndex = 118
        Me._Check_22.Text = "Giá thành sản xuất"
        Me._Check_22.UseVisualStyleBackColor = False
        '
        '_Check_23
        '
        Me._Check_23.AutoSize = True
        Me._Check_23.BackColor = System.Drawing.Color.Transparent
        Me._Check_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_23.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_23.Location = New System.Drawing.Point(8, 321)
        Me._Check_23.Name = "_Check_23"
        Me._Check_23.Size = New System.Drawing.Size(171, 18)
        Me._Check_23.TabIndex = 117
        Me._Check_23.Text = "Sử dụng chức năng in báo giá"
        Me._Check_23.UseVisualStyleBackColor = False
        Me._Check_23.Visible = False
        '
        '_Check_24
        '
        Me._Check_24.AutoSize = True
        Me._Check_24.BackColor = System.Drawing.Color.Transparent
        Me._Check_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_24.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_24.Location = New System.Drawing.Point(8, 397)
        Me._Check_24.Name = "_Check_24"
        Me._Check_24.Size = New System.Drawing.Size(165, 18)
        Me._Check_24.TabIndex = 116
        Me._Check_24.Text = "Theo dõi nhân viên bán hàng"
        Me._Check_24.UseVisualStyleBackColor = False
        '
        '_Check_29
        '
        Me._Check_29.AutoSize = True
        Me._Check_29.BackColor = System.Drawing.Color.Transparent
        Me._Check_29.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_29.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_29.Location = New System.Drawing.Point(360, 225)
        Me._Check_29.Name = "_Check_29"
        Me._Check_29.Size = New System.Drawing.Size(145, 18)
        Me._Check_29.TabIndex = 115
        Me._Check_29.Text = "Tách chức năng in phiếu"
        Me._Check_29.UseVisualStyleBackColor = False
        '
        '_Check_30
        '
        Me._Check_30.AutoSize = True
        Me._Check_30.BackColor = System.Drawing.Color.Transparent
        Me._Check_30.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_30.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_30.Location = New System.Drawing.Point(360, 245)
        Me._Check_30.Name = "_Check_30"
        Me._Check_30.Size = New System.Drawing.Size(169, 18)
        Me._Check_30.TabIndex = 114
        Me._Check_30.Text = "Sử dụng các báo cáo quản trị"
        Me._Check_30.UseVisualStyleBackColor = False
        '
        '_Check_31
        '
        Me._Check_31.AutoSize = True
        Me._Check_31.BackColor = System.Drawing.Color.Transparent
        Me._Check_31.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_31.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_31.Location = New System.Drawing.Point(8, 359)
        Me._Check_31.Name = "_Check_31"
        Me._Check_31.Size = New System.Drawing.Size(134, 18)
        Me._Check_31.TabIndex = 113
        Me._Check_31.Text = "Công nợ theo hoá đơn"
        Me._Check_31.UseVisualStyleBackColor = False
        '
        '_Check_32
        '
        Me._Check_32.AutoSize = True
        Me._Check_32.BackColor = System.Drawing.Color.Transparent
        Me._Check_32.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_32.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_32.Location = New System.Drawing.Point(360, 206)
        Me._Check_32.Name = "_Check_32"
        Me._Check_32.Size = New System.Drawing.Size(153, 18)
        Me._Check_32.TabIndex = 112
        Me._Check_32.Text = "Phân quyền theo tài khoản"
        Me._Check_32.UseVisualStyleBackColor = False
        '
        '_Check_33
        '
        Me._Check_33.AutoSize = True
        Me._Check_33.BackColor = System.Drawing.Color.Transparent
        Me._Check_33.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_33.Enabled = False
        Me._Check_33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_33.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_33.Location = New System.Drawing.Point(8, 340)
        Me._Check_33.Name = "_Check_33"
        Me._Check_33.Size = New System.Drawing.Size(237, 18)
        Me._Check_33.TabIndex = 111
        Me._Check_33.Text = "Đơn giá hàng hoá và hoá đơn sử dụng USD"
        Me._Check_33.UseVisualStyleBackColor = False
        Me._Check_33.Visible = False
        '
        '_Check_34
        '
        Me._Check_34.AutoSize = True
        Me._Check_34.BackColor = System.Drawing.Color.Transparent
        Me._Check_34.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_34.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_34.Location = New System.Drawing.Point(8, 416)
        Me._Check_34.Name = "_Check_34"
        Me._Check_34.Size = New System.Drawing.Size(181, 18)
        Me._Check_34.TabIndex = 110
        Me._Check_34.Text = "Chiết khấu đầu ra theo mặt hàng"
        Me._Check_34.UseVisualStyleBackColor = False
        '
        '_Check_11
        '
        Me._Check_11.AutoSize = True
        Me._Check_11.BackColor = System.Drawing.Color.Transparent
        Me._Check_11.Checked = True
        Me._Check_11.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Check_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_11.Location = New System.Drawing.Point(570, 63)
        Me._Check_11.Name = "_Check_11"
        Me._Check_11.Size = New System.Drawing.Size(71, 18)
        Me._Check_11.TabIndex = 109
        Me._Check_11.Text = "CT ghi sổ"
        Me._Check_11.UseVisualStyleBackColor = False
        '
        '_Check_35
        '
        Me._Check_35.AutoSize = True
        Me._Check_35.BackColor = System.Drawing.Color.Transparent
        Me._Check_35.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_35.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_35.Location = New System.Drawing.Point(8, 437)
        Me._Check_35.Name = "_Check_35"
        Me._Check_35.Size = New System.Drawing.Size(234, 18)
        Me._Check_35.TabIndex = 108
        Me._Check_35.Text = "Số thông tin chứng từ bổ sung cần theo dõi"
        Me._Check_35.UseVisualStyleBackColor = False
        Me._Check_35.Visible = False
        '
        '_Text_25
        '
        Me._Text_25.Location = New System.Drawing.Point(296, 436)
        Me._Text_25.MaxLength = 2
        Me._Text_25.Name = "_Text_25"
        Me._Text_25.Size = New System.Drawing.Size(47, 20)
        Me._Text_25.TabIndex = 107
        Me._Text_25.Text = "0"
        Me._Text_25.Visible = False
        '
        '_Check_36
        '
        Me._Check_36.AutoSize = True
        Me._Check_36.BackColor = System.Drawing.Color.Transparent
        Me._Check_36.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_36.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_36.Location = New System.Drawing.Point(360, 18)
        Me._Check_36.Name = "_Check_36"
        Me._Check_36.Size = New System.Drawing.Size(164, 18)
        Me._Check_36.TabIndex = 106
        Me._Check_36.Text = "Tính giá vốn hàng nhập khẩu"
        Me._Check_36.UseVisualStyleBackColor = False
        Me._Check_36.Visible = False
        '
        '_Check_38
        '
        Me._Check_38.AutoSize = True
        Me._Check_38.BackColor = System.Drawing.Color.Transparent
        Me._Check_38.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_38.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_38.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_38.Location = New System.Drawing.Point(389, 43)
        Me._Check_38.Name = "_Check_38"
        Me._Check_38.Size = New System.Drawing.Size(241, 18)
        Me._Check_38.TabIndex = 104
        Me._Check_38.Text = "Cho nhập trùng số hiệu chứng từ khác tháng"
        Me._Check_38.UseVisualStyleBackColor = False
        Me._Check_38.Visible = False
        '
        'CTGS
        '
        Me.CTGS.BackColor = System.Drawing.SystemColors.Window
        Me.CTGS.Cursor = System.Windows.Forms.Cursors.Default
        Me.CTGS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CTGS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CTGS.DropDownWidth = 36
        Me.CTGS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTGS.Location = New System.Drawing.Point(194, 86)
        Me.CTGS.Name = "CTGS"
        Me.CTGS.Size = New System.Drawing.Size(149, 21)
        Me.CTGS.TabIndex = 103
        '
        '_Check_0
        '
        Me._Check_0.AutoSize = True
        Me._Check_0.BackColor = System.Drawing.Color.Transparent
        Me._Check_0.Checked = True
        Me._Check_0.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Check_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_0.Location = New System.Drawing.Point(8, 15)
        Me._Check_0.Name = "_Check_0"
        Me._Check_0.Size = New System.Drawing.Size(183, 18)
        Me._Check_0.TabIndex = 102
        Me._Check_0.Text = "Theo dõi chi tiết vật tư, hàng hoá"
        Me._Check_0.UseVisualStyleBackColor = False
        '
        '_Check_14
        '
        Me._Check_14.AutoSize = True
        Me._Check_14.BackColor = System.Drawing.Color.Transparent
        Me._Check_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_14.Location = New System.Drawing.Point(570, 87)
        Me._Check_14.Name = "_Check_14"
        Me._Check_14.Size = New System.Drawing.Size(73, 18)
        Me._Check_14.TabIndex = 101
        Me._Check_14.Text = "Song ngữ"
        Me._Check_14.UseVisualStyleBackColor = False
        '
        '_Text_24
        '
        Me._Text_24.Location = New System.Drawing.Point(529, 108)
        Me._Text_24.MaxLength = 2
        Me._Text_24.Name = "_Text_24"
        Me._Text_24.Size = New System.Drawing.Size(51, 20)
        Me._Text_24.TabIndex = 100
        Me._Text_24.Tag = "0"
        Me._Text_24.Text = "0"
        '
        '_Text_10
        '
        Me._Text_10.Location = New System.Drawing.Point(648, 62)
        Me._Text_10.MaxLength = 20
        Me._Text_10.Name = "_Text_10"
        Me._Text_10.Size = New System.Drawing.Size(47, 20)
        Me._Text_10.TabIndex = 99
        Me._Text_10.Text = "..."
        Me._Text_10.Visible = False
        '
        '_Label_18
        '
        Me._Label_18.AutoSize = True
        Me._Label_18.BackColor = System.Drawing.Color.Transparent
        Me._Label_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_18.Location = New System.Drawing.Point(360, 65)
        Me._Label_18.Name = "_Label_18"
        Me._Label_18.Size = New System.Drawing.Size(84, 14)
        Me._Label_18.TabIndex = 147
        Me._Label_18.Text = "Sử dụng các sổ"
        '
        '_Label_15
        '
        Me._Label_15.AutoSize = True
        Me._Label_15.BackColor = System.Drawing.Color.Transparent
        Me._Label_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_15.Location = New System.Drawing.Point(360, 137)
        Me._Label_15.Name = "_Label_15"
        Me._Label_15.Size = New System.Drawing.Size(108, 14)
        Me._Label_15.TabIndex = 146
        Me._Label_15.Text = "Số chữ số thập phân"
        '
        '_Label_10
        '
        Me._Label_10.AutoSize = True
        Me._Label_10.BackColor = System.Drawing.Color.Transparent
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_10.Location = New System.Drawing.Point(360, 163)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(83, 14)
        Me._Label_10.TabIndex = 145
        Me._Label_10.Text = "Hạch toán bằng"
        '
        '_Label_16
        '
        Me._Label_16.AutoSize = True
        Me._Label_16.BackColor = System.Drawing.Color.Transparent
        Me._Label_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_16.Location = New System.Drawing.Point(591, 163)
        Me._Label_16.Name = "_Label_16"
        Me._Label_16.Size = New System.Drawing.Size(28, 14)
        Me._Label_16.TabIndex = 144
        Me._Label_16.Text = "Rev."
        '
        '_Label_24
        '
        Me._Label_24.AutoSize = True
        Me._Label_24.BackColor = System.Drawing.Color.Transparent
        Me._Label_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_24.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_24.Location = New System.Drawing.Point(360, 111)
        Me._Label_24.Name = "_Label_24"
        Me._Label_24.Size = New System.Drawing.Size(166, 14)
        Me._Label_24.TabIndex = 143
        Me._Label_24.Text = "Số máy truy cập tối đa trên mạng"
        '
        '_Check_40
        '
        Me._Check_40.AutoSize = True
        Me._Check_40.BackColor = System.Drawing.Color.Transparent
        Me._Check_40.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_40.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_40.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_40.Location = New System.Drawing.Point(274, 303)
        Me._Check_40.Name = "_Check_40"
        Me._Check_40.Size = New System.Drawing.Size(146, 18)
        Me._Check_40.TabIndex = 95
        Me._Check_40.Text = "Giá bán theo khách hàng"
        Me._Check_40.UseVisualStyleBackColor = False
        '
        '_Frame_4
        '
        Me._Frame_4.BackColor = System.Drawing.Color.Transparent
        Me._Frame_4.Controls.Add(Me._Frame_3)
        Me._Frame_4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_4.Location = New System.Drawing.Point(22, 354)
        Me._Frame_4.Name = "_Frame_4"
        Me._Frame_4.Size = New System.Drawing.Size(689, 165)
        Me._Frame_4.TabIndex = 65
        Me._Frame_4.TabStop = False
        Me._Frame_4.Visible = False
        '
        '_Frame_3
        '
        Me._Frame_3.BackColor = System.Drawing.Color.Transparent
        Me._Frame_3.Controls.Add(Me._cn_1)
        Me._Frame_3.Controls.Add(Me._cn_2)
        Me._Frame_3.Controls.Add(Me._cn_3)
        Me._Frame_3.Controls.Add(Me._cn_4)
        Me._Frame_3.Controls.Add(Me._cn_5)
        Me._Frame_3.Controls.Add(Me._cn_6)
        Me._Frame_3.Controls.Add(Me._cn_8)
        Me._Frame_3.Controls.Add(Me._cn_7)
        Me._Frame_3.Controls.Add(Me._cn_10)
        Me._Frame_3.Controls.Add(Me._cn_9)
        Me._Frame_3.Controls.Add(Me._Label_23)
        Me._Frame_3.Controls.Add(Me._Label_25)
        Me._Frame_3.Controls.Add(Me._Label_26)
        Me._Frame_3.Controls.Add(Me._Label_27)
        Me._Frame_3.Controls.Add(Me._Label_28)
        Me._Frame_3.Controls.Add(Me._Label_29)
        Me._Frame_3.Controls.Add(Me._Label_33)
        Me._Frame_3.Controls.Add(Me._Label_34)
        Me._Frame_3.Controls.Add(Me._Label_35)
        Me._Frame_3.Controls.Add(Me._Label_36)
        Me._Frame_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_3.Location = New System.Drawing.Point(7, 15)
        Me._Frame_3.Name = "_Frame_3"
        Me._Frame_3.Size = New System.Drawing.Size(676, 141)
        Me._Frame_3.TabIndex = 68
        Me._Frame_3.TabStop = False
        Me._Frame_3.Text = "Các đơn vị trực thuộc hạch toán phụ thuộc cùng địa phương"
        '
        '_cn_1
        '
        Me._cn_1.AcceptsReturn = True
        Me._cn_1.BackColor = System.Drawing.SystemColors.Window
        Me._cn_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._cn_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cn_1.Location = New System.Drawing.Point(91, 22)
        Me._cn_1.MaxLength = 255
        Me._cn_1.Name = "_cn_1"
        Me._cn_1.Size = New System.Drawing.Size(184, 20)
        Me._cn_1.TabIndex = 78
        Me._cn_1.Text = "..."
        '
        '_cn_2
        '
        Me._cn_2.AcceptsReturn = True
        Me._cn_2.BackColor = System.Drawing.SystemColors.Window
        Me._cn_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._cn_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cn_2.Location = New System.Drawing.Point(432, 22)
        Me._cn_2.MaxLength = 255
        Me._cn_2.Name = "_cn_2"
        Me._cn_2.Size = New System.Drawing.Size(190, 20)
        Me._cn_2.TabIndex = 77
        Me._cn_2.Text = "..."
        '
        '_cn_3
        '
        Me._cn_3.AcceptsReturn = True
        Me._cn_3.BackColor = System.Drawing.SystemColors.Window
        Me._cn_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._cn_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cn_3.Location = New System.Drawing.Point(91, 44)
        Me._cn_3.MaxLength = 255
        Me._cn_3.Name = "_cn_3"
        Me._cn_3.Size = New System.Drawing.Size(184, 20)
        Me._cn_3.TabIndex = 76
        Me._cn_3.Text = "..."
        '
        '_cn_4
        '
        Me._cn_4.AcceptsReturn = True
        Me._cn_4.BackColor = System.Drawing.SystemColors.Window
        Me._cn_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._cn_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cn_4.Location = New System.Drawing.Point(432, 44)
        Me._cn_4.MaxLength = 255
        Me._cn_4.Name = "_cn_4"
        Me._cn_4.Size = New System.Drawing.Size(190, 20)
        Me._cn_4.TabIndex = 75
        Me._cn_4.Text = "..."
        '
        '_cn_5
        '
        Me._cn_5.AcceptsReturn = True
        Me._cn_5.BackColor = System.Drawing.SystemColors.Window
        Me._cn_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._cn_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cn_5.Location = New System.Drawing.Point(91, 66)
        Me._cn_5.MaxLength = 255
        Me._cn_5.Name = "_cn_5"
        Me._cn_5.Size = New System.Drawing.Size(184, 20)
        Me._cn_5.TabIndex = 74
        Me._cn_5.Text = "..."
        '
        '_cn_6
        '
        Me._cn_6.AcceptsReturn = True
        Me._cn_6.BackColor = System.Drawing.SystemColors.Window
        Me._cn_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._cn_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cn_6.Location = New System.Drawing.Point(432, 66)
        Me._cn_6.MaxLength = 255
        Me._cn_6.Name = "_cn_6"
        Me._cn_6.Size = New System.Drawing.Size(190, 20)
        Me._cn_6.TabIndex = 73
        Me._cn_6.Text = "..."
        '
        '_cn_8
        '
        Me._cn_8.AcceptsReturn = True
        Me._cn_8.BackColor = System.Drawing.SystemColors.Window
        Me._cn_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._cn_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cn_8.Location = New System.Drawing.Point(432, 88)
        Me._cn_8.MaxLength = 255
        Me._cn_8.Name = "_cn_8"
        Me._cn_8.Size = New System.Drawing.Size(190, 20)
        Me._cn_8.TabIndex = 72
        Me._cn_8.Text = "..."
        '
        '_cn_7
        '
        Me._cn_7.AcceptsReturn = True
        Me._cn_7.BackColor = System.Drawing.SystemColors.Window
        Me._cn_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._cn_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cn_7.Location = New System.Drawing.Point(91, 88)
        Me._cn_7.MaxLength = 255
        Me._cn_7.Name = "_cn_7"
        Me._cn_7.Size = New System.Drawing.Size(184, 20)
        Me._cn_7.TabIndex = 71
        Me._cn_7.Text = "..."
        '
        '_cn_10
        '
        Me._cn_10.AcceptsReturn = True
        Me._cn_10.BackColor = System.Drawing.SystemColors.Window
        Me._cn_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._cn_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cn_10.Location = New System.Drawing.Point(432, 110)
        Me._cn_10.MaxLength = 255
        Me._cn_10.Name = "_cn_10"
        Me._cn_10.Size = New System.Drawing.Size(190, 20)
        Me._cn_10.TabIndex = 70
        Me._cn_10.Text = "..."
        '
        '_cn_9
        '
        Me._cn_9.AcceptsReturn = True
        Me._cn_9.BackColor = System.Drawing.SystemColors.Window
        Me._cn_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._cn_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cn_9.Location = New System.Drawing.Point(91, 110)
        Me._cn_9.MaxLength = 255
        Me._cn_9.Name = "_cn_9"
        Me._cn_9.Size = New System.Drawing.Size(184, 20)
        Me._cn_9.TabIndex = 69
        Me._cn_9.Text = "..."
        '
        '_Label_23
        '
        Me._Label_23.AutoSize = True
        Me._Label_23.BackColor = System.Drawing.Color.Transparent
        Me._Label_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_23.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_23.Location = New System.Drawing.Point(16, 25)
        Me._Label_23.Name = "_Label_23"
        Me._Label_23.Size = New System.Drawing.Size(64, 14)
        Me._Label_23.TabIndex = 88
        Me._Label_23.Tag = "Branch Name"
        Me._Label_23.Text = "Chi nhánh 1"
        '
        '_Label_25
        '
        Me._Label_25.AutoSize = True
        Me._Label_25.BackColor = System.Drawing.Color.Transparent
        Me._Label_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_25.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_25.Location = New System.Drawing.Point(16, 47)
        Me._Label_25.Name = "_Label_25"
        Me._Label_25.Size = New System.Drawing.Size(64, 14)
        Me._Label_25.TabIndex = 87
        Me._Label_25.Tag = "Branch Name"
        Me._Label_25.Text = "Chi nhánh 2"
        '
        '_Label_26
        '
        Me._Label_26.AutoSize = True
        Me._Label_26.BackColor = System.Drawing.Color.Transparent
        Me._Label_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_26.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_26.Location = New System.Drawing.Point(16, 69)
        Me._Label_26.Name = "_Label_26"
        Me._Label_26.Size = New System.Drawing.Size(64, 14)
        Me._Label_26.TabIndex = 86
        Me._Label_26.Tag = "Branch Name"
        Me._Label_26.Text = "Chi nhánh 3"
        '
        '_Label_27
        '
        Me._Label_27.AutoSize = True
        Me._Label_27.BackColor = System.Drawing.Color.Transparent
        Me._Label_27.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_27.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_27.Location = New System.Drawing.Point(370, 25)
        Me._Label_27.Name = "_Label_27"
        Me._Label_27.Size = New System.Drawing.Size(49, 14)
        Me._Label_27.TabIndex = 85
        Me._Label_27.Tag = "Branch Name"
        Me._Label_27.Text = "Địa chỉ 1"
        Me._Label_27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_28
        '
        Me._Label_28.AutoSize = True
        Me._Label_28.BackColor = System.Drawing.Color.Transparent
        Me._Label_28.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_28.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_28.Location = New System.Drawing.Point(370, 47)
        Me._Label_28.Name = "_Label_28"
        Me._Label_28.Size = New System.Drawing.Size(49, 14)
        Me._Label_28.TabIndex = 84
        Me._Label_28.Tag = "Branch Name"
        Me._Label_28.Text = "Địa chỉ 2"
        Me._Label_28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_29
        '
        Me._Label_29.AutoSize = True
        Me._Label_29.BackColor = System.Drawing.Color.Transparent
        Me._Label_29.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_29.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_29.Location = New System.Drawing.Point(370, 69)
        Me._Label_29.Name = "_Label_29"
        Me._Label_29.Size = New System.Drawing.Size(49, 14)
        Me._Label_29.TabIndex = 83
        Me._Label_29.Tag = "Branch Name"
        Me._Label_29.Text = "Địa chỉ 3"
        Me._Label_29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_33
        '
        Me._Label_33.AutoSize = True
        Me._Label_33.BackColor = System.Drawing.Color.Transparent
        Me._Label_33.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_33.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_33.Location = New System.Drawing.Point(370, 91)
        Me._Label_33.Name = "_Label_33"
        Me._Label_33.Size = New System.Drawing.Size(49, 14)
        Me._Label_33.TabIndex = 82
        Me._Label_33.Tag = "Branch Name"
        Me._Label_33.Text = "Địa chỉ 4"
        Me._Label_33.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_34
        '
        Me._Label_34.AutoSize = True
        Me._Label_34.BackColor = System.Drawing.Color.Transparent
        Me._Label_34.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_34.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_34.Location = New System.Drawing.Point(16, 91)
        Me._Label_34.Name = "_Label_34"
        Me._Label_34.Size = New System.Drawing.Size(64, 14)
        Me._Label_34.TabIndex = 81
        Me._Label_34.Tag = "Branch Name"
        Me._Label_34.Text = "Chi nhánh 4"
        '
        '_Label_35
        '
        Me._Label_35.AutoSize = True
        Me._Label_35.BackColor = System.Drawing.Color.Transparent
        Me._Label_35.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_35.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_35.Location = New System.Drawing.Point(370, 113)
        Me._Label_35.Name = "_Label_35"
        Me._Label_35.Size = New System.Drawing.Size(49, 14)
        Me._Label_35.TabIndex = 80
        Me._Label_35.Tag = "Branch Name"
        Me._Label_35.Text = "Địa chỉ 5"
        Me._Label_35.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_36
        '
        Me._Label_36.AutoSize = True
        Me._Label_36.BackColor = System.Drawing.Color.Transparent
        Me._Label_36.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_36.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_36.Location = New System.Drawing.Point(16, 113)
        Me._Label_36.Name = "_Label_36"
        Me._Label_36.Size = New System.Drawing.Size(64, 14)
        Me._Label_36.TabIndex = 79
        Me._Label_36.Tag = "Branch Name"
        Me._Label_36.Text = "Chi nhánh 5"
        '
        'ChkKBS
        '
        Me.ChkKBS.AutoSize = True
        Me.ChkKBS.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkKBS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkKBS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkKBS.Location = New System.Drawing.Point(274, 329)
        Me.ChkKBS.Name = "ChkKBS"
        Me.ChkKBS.Size = New System.Drawing.Size(89, 18)
        Me.ChkKBS.TabIndex = 67
        Me.ChkKBS.Text = "Khai bổ sung"
        Me.ChkKBS.UseVisualStyleBackColor = False
        '
        'nnt
        '
        Me.nnt.AcceptsReturn = True
        Me.nnt.BackColor = System.Drawing.SystemColors.Window
        Me.nnt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nnt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nnt.Location = New System.Drawing.Point(113, 328)
        Me.nnt.MaxLength = 50
        Me.nnt.Name = "nnt"
        Me.nnt.Size = New System.Drawing.Size(149, 20)
        Me.nnt.TabIndex = 66
        Me.nnt.Text = "..."
        '
        '_Label_32
        '
        Me._Label_32.AutoSize = True
        Me._Label_32.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_32.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_32.Location = New System.Drawing.Point(7, 331)
        Me._Label_32.Name = "_Label_32"
        Me._Label_32.Size = New System.Drawing.Size(81, 14)
        Me._Label_32.TabIndex = 89
        Me._Label_32.Tag = "Company"
        Me._Label_32.Text = "Người nộp thuế"
        '
        'ChkMonbai
        '
        Me.ChkMonbai.AutoSize = True
        Me.ChkMonbai.BackColor = System.Drawing.Color.Transparent
        Me.ChkMonbai.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkMonbai.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMonbai.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkMonbai.Location = New System.Drawing.Point(10, 303)
        Me.ChkMonbai.Name = "ChkMonbai"
        Me.ChkMonbai.Size = New System.Drawing.Size(90, 18)
        Me.ChkMonbai.TabIndex = 36
        Me.ChkMonbai.Text = "Thuế môn bài"
        Me.ChkMonbai.UseVisualStyleBackColor = False
        '
        '_Frame_2
        '
        Me._Frame_2.BackColor = System.Drawing.Color.Transparent
        Me._Frame_2.Controls.Add(Me._Check_43)
        Me._Frame_2.Controls.Add(Me._ChkVT_2)
        Me._Frame_2.Controls.Add(Me._ChkVT_1)
        Me._Frame_2.Controls.Add(Me._ChkVT_0)
        Me._Frame_2.Controls.Add(Me._OptVT_3)
        Me._Frame_2.Controls.Add(Me._OptVT_2)
        Me._Frame_2.Controls.Add(Me._OptVT_1)
        Me._Frame_2.Controls.Add(Me._OptVT_0)
        Me._Frame_2.Controls.Add(Me._ChkVT_3)
        Me._Frame_2.Controls.Add(Me._ChkVT_4)
        Me._Frame_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_2.Location = New System.Drawing.Point(6, 233)
        Me._Frame_2.Name = "_Frame_2"
        Me._Frame_2.Size = New System.Drawing.Size(615, 64)
        Me._Frame_2.TabIndex = 62
        Me._Frame_2.TabStop = False
        Me._Frame_2.Text = "Phương pháp tính giá xuất kho"
        '
        '_Check_43
        '
        Me._Check_43.AutoSize = True
        Me._Check_43.BackColor = System.Drawing.Color.Transparent
        Me._Check_43.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_43.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_43.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_43.Location = New System.Drawing.Point(460, 19)
        Me._Check_43.Name = "_Check_43"
        Me._Check_43.Size = New System.Drawing.Size(126, 18)
        Me._Check_43.TabIndex = 36
        Me._Check_43.Text = "Chiết khấu mua hàng"
        Me._Check_43.UseVisualStyleBackColor = False
        '
        '_ChkVT_2
        '
        Me._ChkVT_2.AutoSize = True
        Me._ChkVT_2.BackColor = System.Drawing.Color.Transparent
        Me._ChkVT_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkVT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkVT_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkVT_2.Location = New System.Drawing.Point(271, 42)
        Me._ChkVT_2.Name = "_ChkVT_2"
        Me._ChkVT_2.Size = New System.Drawing.Size(233, 18)
        Me._ChkVT_2.TabIndex = 30
        Me._ChkVT_2.Text = "Luỹ kế theo ngày chỉ kê vật tư có phát sinh"
        Me._ChkVT_2.UseVisualStyleBackColor = False
        '
        '_ChkVT_1
        '
        Me._ChkVT_1.AutoSize = True
        Me._ChkVT_1.BackColor = System.Drawing.Color.Transparent
        Me._ChkVT_1.Checked = True
        Me._ChkVT_1.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkVT_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkVT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkVT_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkVT_1.Location = New System.Drawing.Point(164, 42)
        Me._ChkVT_1.Name = "_ChkVT_1"
        Me._ChkVT_1.Size = New System.Drawing.Size(100, 18)
        Me._ChkVT_1.TabIndex = 34
        Me._ChkVT_1.Text = "Sử dụng giá HT"
        Me._ChkVT_1.UseVisualStyleBackColor = False
        '
        '_ChkVT_0
        '
        Me._ChkVT_0.AutoSize = True
        Me._ChkVT_0.BackColor = System.Drawing.Color.Transparent
        Me._ChkVT_0.Checked = True
        Me._ChkVT_0.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkVT_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkVT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkVT_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkVT_0.Location = New System.Drawing.Point(163, 19)
        Me._ChkVT_0.Name = "_ChkVT_0"
        Me._ChkVT_0.Size = New System.Drawing.Size(103, 18)
        Me._ChkVT_0.TabIndex = 29
        Me._ChkVT_0.Text = "Cố định giá xuất"
        Me._ChkVT_0.UseVisualStyleBackColor = False
        '
        '_OptVT_3
        '
        Me._OptVT_3.AutoSize = True
        Me._OptVT_3.BackColor = System.Drawing.Color.Transparent
        Me._OptVT_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVT_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVT_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVT_3.Location = New System.Drawing.Point(110, 42)
        Me._OptVT_3.Name = "_OptVT_3"
        Me._OptVT_3.Size = New System.Drawing.Size(47, 18)
        Me._OptVT_3.TabIndex = 33
        Me._OptVT_3.TabStop = True
        Me._OptVT_3.Text = "LIFO"
        Me._OptVT_3.UseVisualStyleBackColor = False
        '
        '_OptVT_2
        '
        Me._OptVT_2.AutoSize = True
        Me._OptVT_2.BackColor = System.Drawing.Color.Transparent
        Me._OptVT_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVT_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVT_2.Location = New System.Drawing.Point(110, 19)
        Me._OptVT_2.Name = "_OptVT_2"
        Me._OptVT_2.Size = New System.Drawing.Size(47, 18)
        Me._OptVT_2.TabIndex = 28
        Me._OptVT_2.TabStop = True
        Me._OptVT_2.Text = "FIFO"
        Me._OptVT_2.UseVisualStyleBackColor = False
        '
        '_OptVT_1
        '
        Me._OptVT_1.AutoSize = True
        Me._OptVT_1.BackColor = System.Drawing.Color.Transparent
        Me._OptVT_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVT_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVT_1.Location = New System.Drawing.Point(6, 42)
        Me._OptVT_1.Name = "_OptVT_1"
        Me._OptVT_1.Size = New System.Drawing.Size(97, 18)
        Me._OptVT_1.TabIndex = 32
        Me._OptVT_1.TabStop = True
        Me._OptVT_1.Text = "Xuất đích danh"
        Me._OptVT_1.UseVisualStyleBackColor = False
        '
        '_OptVT_0
        '
        Me._OptVT_0.AutoSize = True
        Me._OptVT_0.BackColor = System.Drawing.Color.Transparent
        Me._OptVT_0.Checked = True
        Me._OptVT_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptVT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptVT_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptVT_0.Location = New System.Drawing.Point(7, 19)
        Me._OptVT_0.Name = "_OptVT_0"
        Me._OptVT_0.Size = New System.Drawing.Size(91, 18)
        Me._OptVT_0.TabIndex = 27
        Me._OptVT_0.TabStop = True
        Me._OptVT_0.Text = "Giá bình quân"
        Me._OptVT_0.UseVisualStyleBackColor = False
        '
        '_ChkVT_3
        '
        Me._ChkVT_3.AutoSize = True
        Me._ChkVT_3.BackColor = System.Drawing.Color.Transparent
        Me._ChkVT_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkVT_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkVT_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkVT_3.Location = New System.Drawing.Point(271, 19)
        Me._ChkVT_3.Name = "_ChkVT_3"
        Me._ChkVT_3.Size = New System.Drawing.Size(152, 18)
        Me._ChkVT_3.TabIndex = 35
        Me._ChkVT_3.Text = "Kiểm kê tồn kho theo ngày"
        Me._ChkVT_3.UseVisualStyleBackColor = False
        '
        '_ChkVT_4
        '
        Me._ChkVT_4.AutoSize = True
        Me._ChkVT_4.BackColor = System.Drawing.Color.Transparent
        Me._ChkVT_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkVT_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkVT_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkVT_4.Location = New System.Drawing.Point(510, 42)
        Me._ChkVT_4.Name = "_ChkVT_4"
        Me._ChkVT_4.Size = New System.Drawing.Size(77, 18)
        Me._ChkVT_4.TabIndex = 31
        Me._ChkVT_4.Text = "In barcode"
        Me._ChkVT_4.UseVisualStyleBackColor = False
        Me._ChkVT_4.Visible = False
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(589, 554)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(80, 24)
        Me._Command_1.TabIndex = 38
        Me._Command_1.Text = "Trở &về"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.select16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(505, 554)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(80, 24)
        Me._Command_0.TabIndex = 37
        Me._Command_0.Text = "&Ghi"
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.lock16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(673, 554)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(80, 24)
        Me._Command_3.TabIndex = 94
        Me._Command_3.Text = "&Khoá"
        '
        '_Check_41
        '
        Me._Check_41.AutoSize = True
        Me._Check_41.BackColor = System.Drawing.Color.Transparent
        Me._Check_41.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_41.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_41.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_41.Location = New System.Drawing.Point(463, 303)
        Me._Check_41.Name = "_Check_41"
        Me._Check_41.Size = New System.Drawing.Size(117, 18)
        Me._Check_41.TabIndex = 99
        Me._Check_41.Text = "Giảm giá hàng mua"
        Me._Check_41.UseVisualStyleBackColor = False
        '
        '_Check_42
        '
        Me._Check_42.AutoSize = True
        Me._Check_42.BackColor = System.Drawing.Color.Transparent
        Me._Check_42.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_42.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check_42.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_42.Location = New System.Drawing.Point(113, 303)
        Me._Check_42.Name = "_Check_42"
        Me._Check_42.Size = New System.Drawing.Size(154, 18)
        Me._Check_42.TabIndex = 100
        Me._Check_42.Text = "Kiểm tra số người sử dụng"
        Me._Check_42.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.tab_coban)
        Me.TabControl1.Controls.Add(Me.tab_NangCao)
        Me.TabControl1.Location = New System.Drawing.Point(12, 11)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(744, 538)
        Me.TabControl1.TabIndex = 101
        '
        'tab_coban
        '
        Me.tab_coban.Controls.Add(Me._Frame_0)
        Me.tab_coban.Controls.Add(Me._Check_42)
        Me.tab_coban.Controls.Add(Me._Frame_4)
        Me.tab_coban.Controls.Add(Me._Frame_2)
        Me.tab_coban.Controls.Add(Me.nnt)
        Me.tab_coban.Controls.Add(Me._Check_40)
        Me.tab_coban.Controls.Add(Me.ChkKBS)
        Me.tab_coban.Controls.Add(Me.ChkMonbai)
        Me.tab_coban.Controls.Add(Me._Check_41)
        Me.tab_coban.Controls.Add(Me._Label_32)
        Me.tab_coban.Location = New System.Drawing.Point(23, 4)
        Me.tab_coban.Name = "tab_coban"
        Me.tab_coban.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_coban.Size = New System.Drawing.Size(717, 530)
        Me.tab_coban.TabIndex = 0
        Me.tab_coban.Text = "Tùy chọn cơ bản"
        Me.tab_coban.UseVisualStyleBackColor = True
        '
        'tab_NangCao
        '
        Me.tab_NangCao.Controls.Add(Me._Frame_1)
        Me.tab_NangCao.Location = New System.Drawing.Point(23, 4)
        Me.tab_NangCao.Name = "tab_NangCao"
        Me.tab_NangCao.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_NangCao.Size = New System.Drawing.Size(717, 530)
        Me.tab_NangCao.TabIndex = 1
        Me.tab_NangCao.Text = "Nâng cao"
        Me.tab_NangCao.UseVisualStyleBackColor = True
        '
        'FrmOptions
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(764, 581)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command_3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(44, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Options"
        Me.Text = "Tùy chọn sử dụng chương trình"
        Me._Frame_0.ResumeLayout(False)
        Me._Frame_0.PerformLayout()
        Me._Frame_1.ResumeLayout(False)
        Me._Frame_1.PerformLayout()
        Me._Frame_4.ResumeLayout(False)
        Me._Frame_3.ResumeLayout(False)
        Me._Frame_3.PerformLayout()
        Me._Frame_2.ResumeLayout(False)
        Me._Frame_2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tab_coban.ResumeLayout(False)
        Me.tab_coban.PerformLayout()
        Me.tab_NangCao.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Sub Initializecn()
        Me.cn(1) = _cn_1
        Me.cn(2) = _cn_2
        Me.cn(3) = _cn_3
        Me.cn(4) = _cn_4
        Me.cn(5) = _cn_5
        Me.cn(6) = _cn_6
        Me.cn(8) = _cn_8
        Me.cn(7) = _cn_7
        Me.cn(10) = _cn_10
        Me.cn(9) = _cn_9
    End Sub
    Sub InitializeText_Renamed()
        Me.Text_Renamed(28) = _Text_28
        Me.Text_Renamed(27) = _Text_27
        Me.Text_Renamed(26) = _Text_26
        Me.Text_Renamed(9) = _Text_9
        Me.Text_Renamed(17) = _Text_17
        Me.Text_Renamed(11) = _Text_11
        Me.Text_Renamed(18) = _Text_18
        Me.Text_Renamed(12) = _Text_12
        Me.Text_Renamed(23) = _Text_23
        Me.Text_Renamed(0) = _Text_0
        Me.Text_Renamed(1) = _Text_1
        Me.Text_Renamed(2) = _Text_2
        Me.Text_Renamed(3) = _Text_3
        Me.Text_Renamed(4) = _Text_4
        Me.Text_Renamed(5) = _Text_5
        Me.Text_Renamed(6) = _Text_6
        Me.Text_Renamed(7) = _Text_7
        Me.Text_Renamed(14) = _Text_14
        Me.Text_Renamed(16) = _Text_16
        Me.Text_Renamed(15) = _Text_15
        Me.Text_Renamed(19) = _Text_19
        Me.Text_Renamed(20) = _Text_20
        Me.Text_Renamed(8) = _Text_8
        Me.Text_Renamed(13) = _Text_13
        Me.Text_Renamed(21) = _Text_21
        Me.Text_Renamed(22) = _Text_22
        Me.Text_Renamed(25) = _Text_25
        Me.Text_Renamed(24) = _Text_24
        Me.Text_Renamed(10) = _Text_10
    End Sub
    Sub InitializeOptVT()
        Me.OptVT(3) = _OptVT_3
        Me.OptVT(2) = _OptVT_2
        Me.OptVT(1) = _OptVT_1
        Me.OptVT(0) = _OptVT_0
    End Sub
    Sub InitializeOptBH()
        Me.OptBH(2) = _OptBH_2
        Me.OptBH(1) = _OptBH_1
        Me.OptBH(0) = _OptBH_0
    End Sub
    Sub InitializeLabel()
        Me.Label(20) = _Label_20
        Me.Label(30) = _Label_30
        Me.Label(31) = _Label_31
        Me.Label(12) = _Label_12
        Me.Label(11) = _Label_11
        Me.Label(21) = _Label_21
        Me.Label(22) = _Label_22
        Me.Label(14) = _Label_14
        Me.Label(13) = _Label_13
        Me.Label(0) = _Label_0
        Me.Label(1) = _Label_1
        Me.Label(2) = _Label_2
        Me.Label(3) = _Label_3
        Me.Label(4) = _Label_4
        Me.Label(5) = _Label_5
        Me.Label(6) = _Label_6
        Me.Label(7) = _Label_7
        Me.Label(8) = _Label_8
        Me.Label(9) = _Label_9
        Me.Label(17) = _Label_17
        Me.Label(19) = _Label_19
        Me.Label(18) = _Label_18
        Me.Label(15) = _Label_15
        Me.Label(10) = _Label_10
        Me.Label(16) = _Label_16
        Me.Label(24) = _Label_24
        Me.Label(23) = _Label_23
        Me.Label(25) = _Label_25
        Me.Label(26) = _Label_26
        Me.Label(27) = _Label_27
        Me.Label(28) = _Label_28
        Me.Label(29) = _Label_29
        Me.Label(33) = _Label_33
        Me.Label(34) = _Label_34
        Me.Label(35) = _Label_35
        Me.Label(36) = _Label_36
        Me.Label(32) = _Label_32
    End Sub
    Sub InitializeFrame()
        Me.Frame(0) = _Frame_0
        Me.Frame(1) = _Frame_1
        Me.Frame(3) = _Frame_3
        Me.Frame(4) = _Frame_4
        Me.Frame(2) = _Frame_2
    End Sub

    Sub InitializeCommand()
        Me.Command(2) = _Command_2
        Me.Command(1) = _Command_1
        Me.Command(0) = _Command_0
        Me.Command(3) = _Command_3
    End Sub
    Sub InitializeCombo()
        Me.Combo(3) = _Combo_3
        Me.Combo(1) = _Combo_1
        Me.Combo(0) = _Combo_0
        Me.Combo(2) = _Combo_2
    End Sub
    Sub InitializeChkVT()
        Me.ChkVT(2) = _ChkVT_2
        Me.ChkVT(1) = _ChkVT_1
        Me.ChkVT(0) = _ChkVT_0
        Me.ChkVT(3) = _ChkVT_3
        Me.ChkVT(4) = _ChkVT_4
    End Sub
    Sub InitializeCheck()
        Me.Check(0) = _Check_0
        Me.Check(1) = _Check_1
        Me.Check(2) = _Check_2
        Me.Check(3) = _Check_3
        Me.Check(4) = _Check_4
        Me.Check(5) = _Check_5
        Me.Check(6) = _Check_6
        Me.Check(7) = _Check_7
        Me.Check(8) = _Check_8
        Me.Check(9) = _Check_9
        Me.Check(10) = _Check_10
        Me.Check(11) = _Check_11
        Me.Check(12) = _Check_12
        Me.Check(13) = _Check_13
        Me.Check(14) = _Check_14
        Me.Check(15) = _Check_15
        Me.Check(16) = _Check_16
        Me.Check(17) = _Check_17
        Me.Check(18) = _Check_18
        Me.Check(19) = _Check_19
        Me.Check(20) = _Check_20
        Me.Check(21) = _Check_21
        Me.Check(22) = _Check_22
        Me.Check(23) = _Check_23
        Me.Check(24) = _Check_24
        Me.Check(25) = _Check_25
        Me.Check(26) = _Check_26
        Me.Check(27) = _Check_27
        Me.Check(28) = _Check_28
        Me.Check(29) = _Check_29
        Me.Check(30) = _Check_30
        Me.Check(31) = _Check_31
        Me.Check(32) = _Check_32
        Me.Check(33) = _Check_33
        Me.Check(34) = _Check_34
        Me.Check(35) = _Check_35
        Me.Check(36) = _Check_36
        Me.Check(37) = _Check_37
        Me.Check(38) = _Check_38
        Me.Check(39) = _Check_39
        Me.Check(40) = _Check_40
        Me.Check(41) = _Check_41
        Me.Check(42) = _Check_42
        Me.Check(43) = _Check_43
        Me.Check(55) = _Check_55
    End Sub
    Private WithEvents _Check_41 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_42 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_27 As System.Windows.Forms.CheckBox
    Private WithEvents _Check_43 As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab_coban As System.Windows.Forms.TabPage
    Friend WithEvents tab_NangCao As System.Windows.Forms.TabPage
#End Region
End Class
