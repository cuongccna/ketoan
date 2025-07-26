<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChamconggio
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		Initializetxtnd()
		Initializetxtnc()
		Initializetxtn()
		Initializetxtch()
		InitializeLabel()
		InitializeCommand1()
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
	Public WithEvents TxtNgayle As System.Windows.Forms.TextBox
	Public WithEvents TxtChunhat As System.Windows.Forms.TextBox
	Public WithEvents TxtTrongtuan As System.Windows.Forms.TextBox
	Private WithEvents _Label_82 As System.Windows.Forms.Label
	Private WithEvents _Label_81 As System.Windows.Forms.Label
	Private WithEvents _Label_37 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _txtn_31 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_30 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_29 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_28 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_27 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_26 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_25 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_24 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_23 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_22 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_21 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_20 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_19 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_18 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_17 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_16 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_15 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_14 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_13 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_12 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_11 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_10 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_9 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_8 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_7 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_6 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_5 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_4 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_3 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtn_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_31 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_30 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_29 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_28 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_27 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_26 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_25 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_24 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_23 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_22 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_21 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_20 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_19 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_18 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_17 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_16 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_15 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_14 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_13 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_12 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_11 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_10 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_9 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_8 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_7 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_6 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_5 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_4 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_3 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtnc_0 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_31 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_30 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_29 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_28 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_27 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_26 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_25 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_24 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_23 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_22 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_21 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_20 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_19 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_18 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_17 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_16 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_15 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_14 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_13 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_12 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_11 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_10 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_9 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_8 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_7 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_6 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_5 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_4 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_3 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_0 As System.Windows.Forms.TextBox
    Private WithEvents _txtch_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtch_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtch_0 As System.Windows.Forms.TextBox
    Public WithEvents GrdNhanvien As ListviewEx.ListviewExt
    Public WithEvents CboThang As ComboBoxEx.ComboBoxExt
    Private WithEvents _Command1_2 As System.Windows.Forms.Button
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Public WithEvents Lich As System.Windows.Forms.MonthCalendar
    Private WithEvents _txtnc_32 As System.Windows.Forms.TextBox
    Private WithEvents _txtnd_32 As System.Windows.Forms.TextBox
    Private WithEvents _Label_36 As System.Windows.Forms.Label
    Private WithEvents _Label_41 As System.Windows.Forms.Label
    Private WithEvents _Label_42 As System.Windows.Forms.Label
    Private WithEvents _Label_43 As System.Windows.Forms.Label
    Private WithEvents _Label_44 As System.Windows.Forms.Label
    Private WithEvents _Label_45 As System.Windows.Forms.Label
    Private WithEvents _Label_46 As System.Windows.Forms.Label
    Private WithEvents _Label_47 As System.Windows.Forms.Label
    Private WithEvents _Label_48 As System.Windows.Forms.Label
    Private WithEvents _Label_49 As System.Windows.Forms.Label
    Private WithEvents _Label_50 As System.Windows.Forms.Label
    Private WithEvents _Label_51 As System.Windows.Forms.Label
    Private WithEvents _Label_52 As System.Windows.Forms.Label
    Private WithEvents _Label_53 As System.Windows.Forms.Label
    Private WithEvents _Label_54 As System.Windows.Forms.Label
    Private WithEvents _Label_55 As System.Windows.Forms.Label
    Private WithEvents _Label_56 As System.Windows.Forms.Label
    Private WithEvents _Label_57 As System.Windows.Forms.Label
    Private WithEvents _Label_58 As System.Windows.Forms.Label
    Private WithEvents _Label_59 As System.Windows.Forms.Label
    Private WithEvents _Label_60 As System.Windows.Forms.Label
    Private WithEvents _Label_61 As System.Windows.Forms.Label
    Private WithEvents _Label_62 As System.Windows.Forms.Label
    Private WithEvents _Label_63 As System.Windows.Forms.Label
    Private WithEvents _Label_64 As System.Windows.Forms.Label
    Private WithEvents _Label_65 As System.Windows.Forms.Label
    Private WithEvents _Label_66 As System.Windows.Forms.Label
    Private WithEvents _Label_67 As System.Windows.Forms.Label
    Private WithEvents _Label_68 As System.Windows.Forms.Label
    Private WithEvents _Label_69 As System.Windows.Forms.Label
    Private WithEvents _Label_70 As System.Windows.Forms.Label
    Private WithEvents _Label_71 As System.Windows.Forms.Label
    Private WithEvents _Label_35 As System.Windows.Forms.Label
    Private WithEvents _Label_31 As System.Windows.Forms.Label
    Private WithEvents _Label_30 As System.Windows.Forms.Label
    Private WithEvents _Label_29 As System.Windows.Forms.Label
    Private WithEvents _Label_28 As System.Windows.Forms.Label
    Private WithEvents _Label_27 As System.Windows.Forms.Label
    Private WithEvents _Label_26 As System.Windows.Forms.Label
    Private WithEvents _Label_25 As System.Windows.Forms.Label
    Private WithEvents _Label_24 As System.Windows.Forms.Label
    Private WithEvents _Label_23 As System.Windows.Forms.Label
    Private WithEvents _Label_22 As System.Windows.Forms.Label
    Private WithEvents _Label_21 As System.Windows.Forms.Label
    Private WithEvents _Label_20 As System.Windows.Forms.Label
    Private WithEvents _Label_19 As System.Windows.Forms.Label
    Private WithEvents _Label_18 As System.Windows.Forms.Label
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Private WithEvents _Label_16 As System.Windows.Forms.Label
    Private WithEvents _Label_15 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Label_9 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_34 As System.Windows.Forms.Label
    Private WithEvents _Label_32 As System.Windows.Forms.Label
    Private WithEvents _Label_33 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Public Command(2) As System.Windows.Forms.Button
    Public Command1(2) As System.Windows.Forms.Button
    Public Label(82) As System.Windows.Forms.Label
    Public txtch(2) As System.Windows.Forms.TextBox
    Public txtn(32) As System.Windows.Forms.TextBox
    Public txtnc(32) As System.Windows.Forms.TextBox
    Public txtnd(32) As System.Windows.Forms.TextBox
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChamconggio))
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.TxtNgayle = New System.Windows.Forms.TextBox
        Me.TxtChunhat = New System.Windows.Forms.TextBox
        Me.TxtTrongtuan = New System.Windows.Forms.TextBox
        Me._Label_82 = New System.Windows.Forms.Label
        Me._Label_81 = New System.Windows.Forms.Label
        Me._Label_37 = New System.Windows.Forms.Label
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._txtn_31 = New System.Windows.Forms.TextBox
        Me._txtn_30 = New System.Windows.Forms.TextBox
        Me._txtn_29 = New System.Windows.Forms.TextBox
        Me._txtn_28 = New System.Windows.Forms.TextBox
        Me._txtn_27 = New System.Windows.Forms.TextBox
        Me._txtn_26 = New System.Windows.Forms.TextBox
        Me._txtn_25 = New System.Windows.Forms.TextBox
        Me._txtn_24 = New System.Windows.Forms.TextBox
        Me._txtn_23 = New System.Windows.Forms.TextBox
        Me._txtn_22 = New System.Windows.Forms.TextBox
        Me._txtn_21 = New System.Windows.Forms.TextBox
        Me._txtn_20 = New System.Windows.Forms.TextBox
        Me._txtn_19 = New System.Windows.Forms.TextBox
        Me._txtn_18 = New System.Windows.Forms.TextBox
        Me._txtn_17 = New System.Windows.Forms.TextBox
        Me._txtn_16 = New System.Windows.Forms.TextBox
        Me._txtn_15 = New System.Windows.Forms.TextBox
        Me._txtn_14 = New System.Windows.Forms.TextBox
        Me._txtn_13 = New System.Windows.Forms.TextBox
        Me._txtn_12 = New System.Windows.Forms.TextBox
        Me._txtn_11 = New System.Windows.Forms.TextBox
        Me._txtn_10 = New System.Windows.Forms.TextBox
        Me._txtn_9 = New System.Windows.Forms.TextBox
        Me._txtn_8 = New System.Windows.Forms.TextBox
        Me._txtn_7 = New System.Windows.Forms.TextBox
        Me._txtn_6 = New System.Windows.Forms.TextBox
        Me._txtn_5 = New System.Windows.Forms.TextBox
        Me._txtn_4 = New System.Windows.Forms.TextBox
        Me._txtn_3 = New System.Windows.Forms.TextBox
        Me._txtn_2 = New System.Windows.Forms.TextBox
        Me._txtn_1 = New System.Windows.Forms.TextBox
        Me._txtnc_31 = New System.Windows.Forms.TextBox
        Me._txtnc_30 = New System.Windows.Forms.TextBox
        Me._txtnc_29 = New System.Windows.Forms.TextBox
        Me._txtnc_28 = New System.Windows.Forms.TextBox
        Me._txtnc_27 = New System.Windows.Forms.TextBox
        Me._txtnc_26 = New System.Windows.Forms.TextBox
        Me._txtnc_25 = New System.Windows.Forms.TextBox
        Me._txtnc_24 = New System.Windows.Forms.TextBox
        Me._txtnc_23 = New System.Windows.Forms.TextBox
        Me._txtnc_22 = New System.Windows.Forms.TextBox
        Me._txtnc_21 = New System.Windows.Forms.TextBox
        Me._txtnc_20 = New System.Windows.Forms.TextBox
        Me._txtnc_19 = New System.Windows.Forms.TextBox
        Me._txtnc_18 = New System.Windows.Forms.TextBox
        Me._txtnc_17 = New System.Windows.Forms.TextBox
        Me._txtnc_16 = New System.Windows.Forms.TextBox
        Me._txtnc_15 = New System.Windows.Forms.TextBox
        Me._txtnc_14 = New System.Windows.Forms.TextBox
        Me._txtnc_13 = New System.Windows.Forms.TextBox
        Me._txtnc_12 = New System.Windows.Forms.TextBox
        Me._txtnc_11 = New System.Windows.Forms.TextBox
        Me._txtnc_10 = New System.Windows.Forms.TextBox
        Me._txtnc_9 = New System.Windows.Forms.TextBox
        Me._txtnc_8 = New System.Windows.Forms.TextBox
        Me._txtnc_7 = New System.Windows.Forms.TextBox
        Me._txtnc_6 = New System.Windows.Forms.TextBox
        Me._txtnc_5 = New System.Windows.Forms.TextBox
        Me._txtnc_4 = New System.Windows.Forms.TextBox
        Me._txtnc_3 = New System.Windows.Forms.TextBox
        Me._txtnc_2 = New System.Windows.Forms.TextBox
        Me._txtnc_1 = New System.Windows.Forms.TextBox
        Me._txtnc_0 = New System.Windows.Forms.TextBox
        Me._txtnd_31 = New System.Windows.Forms.TextBox
        Me._txtnd_30 = New System.Windows.Forms.TextBox
        Me._txtnd_29 = New System.Windows.Forms.TextBox
        Me._txtnd_28 = New System.Windows.Forms.TextBox
        Me._txtnd_27 = New System.Windows.Forms.TextBox
        Me._txtnd_26 = New System.Windows.Forms.TextBox
        Me._txtnd_25 = New System.Windows.Forms.TextBox
        Me._txtnd_24 = New System.Windows.Forms.TextBox
        Me._txtnd_23 = New System.Windows.Forms.TextBox
        Me._txtnd_22 = New System.Windows.Forms.TextBox
        Me._txtnd_21 = New System.Windows.Forms.TextBox
        Me._txtnd_20 = New System.Windows.Forms.TextBox
        Me._txtnd_19 = New System.Windows.Forms.TextBox
        Me._txtnd_18 = New System.Windows.Forms.TextBox
        Me._txtnd_17 = New System.Windows.Forms.TextBox
        Me._txtnd_16 = New System.Windows.Forms.TextBox
        Me._txtnd_15 = New System.Windows.Forms.TextBox
        Me._txtnd_14 = New System.Windows.Forms.TextBox
        Me._txtnd_13 = New System.Windows.Forms.TextBox
        Me._txtnd_12 = New System.Windows.Forms.TextBox
        Me._txtnd_11 = New System.Windows.Forms.TextBox
        Me._txtnd_10 = New System.Windows.Forms.TextBox
        Me._txtnd_9 = New System.Windows.Forms.TextBox
        Me._txtnd_8 = New System.Windows.Forms.TextBox
        Me._txtnd_7 = New System.Windows.Forms.TextBox
        Me._txtnd_6 = New System.Windows.Forms.TextBox
        Me._txtnd_5 = New System.Windows.Forms.TextBox
        Me._txtnd_4 = New System.Windows.Forms.TextBox
        Me._txtnd_3 = New System.Windows.Forms.TextBox
        Me._txtnd_2 = New System.Windows.Forms.TextBox
        Me._txtnd_1 = New System.Windows.Forms.TextBox
        Me._txtnd_0 = New System.Windows.Forms.TextBox
        Me._txtch_2 = New System.Windows.Forms.TextBox
        Me._txtch_1 = New System.Windows.Forms.TextBox
        Me._txtch_0 = New System.Windows.Forms.TextBox
        Me.CboThang = New ComboBoxEx.ComboBoxExt
        Me._Command1_2 = New System.Windows.Forms.Button
        Me._Command1_0 = New System.Windows.Forms.Button
        Me._Command1_1 = New System.Windows.Forms.Button
        Me.Lich = New System.Windows.Forms.MonthCalendar
        Me._txtnc_32 = New System.Windows.Forms.TextBox
        Me._txtnd_32 = New System.Windows.Forms.TextBox
        Me._Label_36 = New System.Windows.Forms.Label
        Me._Label_41 = New System.Windows.Forms.Label
        Me._Label_42 = New System.Windows.Forms.Label
        Me._Label_43 = New System.Windows.Forms.Label
        Me._Label_44 = New System.Windows.Forms.Label
        Me._Label_45 = New System.Windows.Forms.Label
        Me._Label_46 = New System.Windows.Forms.Label
        Me._Label_47 = New System.Windows.Forms.Label
        Me._Label_48 = New System.Windows.Forms.Label
        Me._Label_49 = New System.Windows.Forms.Label
        Me._Label_50 = New System.Windows.Forms.Label
        Me._Label_51 = New System.Windows.Forms.Label
        Me._Label_52 = New System.Windows.Forms.Label
        Me._Label_53 = New System.Windows.Forms.Label
        Me._Label_54 = New System.Windows.Forms.Label
        Me._Label_55 = New System.Windows.Forms.Label
        Me._Label_56 = New System.Windows.Forms.Label
        Me._Label_57 = New System.Windows.Forms.Label
        Me._Label_58 = New System.Windows.Forms.Label
        Me._Label_59 = New System.Windows.Forms.Label
        Me._Label_60 = New System.Windows.Forms.Label
        Me._Label_61 = New System.Windows.Forms.Label
        Me._Label_62 = New System.Windows.Forms.Label
        Me._Label_63 = New System.Windows.Forms.Label
        Me._Label_64 = New System.Windows.Forms.Label
        Me._Label_65 = New System.Windows.Forms.Label
        Me._Label_66 = New System.Windows.Forms.Label
        Me._Label_67 = New System.Windows.Forms.Label
        Me._Label_68 = New System.Windows.Forms.Label
        Me._Label_69 = New System.Windows.Forms.Label
        Me._Label_70 = New System.Windows.Forms.Label
        Me._Label_71 = New System.Windows.Forms.Label
        Me._Label_35 = New System.Windows.Forms.Label
        Me._Label_31 = New System.Windows.Forms.Label
        Me._Label_30 = New System.Windows.Forms.Label
        Me._Label_29 = New System.Windows.Forms.Label
        Me._Label_28 = New System.Windows.Forms.Label
        Me._Label_27 = New System.Windows.Forms.Label
        Me._Label_26 = New System.Windows.Forms.Label
        Me._Label_25 = New System.Windows.Forms.Label
        Me._Label_24 = New System.Windows.Forms.Label
        Me._Label_23 = New System.Windows.Forms.Label
        Me._Label_22 = New System.Windows.Forms.Label
        Me._Label_21 = New System.Windows.Forms.Label
        Me._Label_20 = New System.Windows.Forms.Label
        Me._Label_19 = New System.Windows.Forms.Label
        Me._Label_18 = New System.Windows.Forms.Label
        Me._Label_17 = New System.Windows.Forms.Label
        Me._Label_16 = New System.Windows.Forms.Label
        Me._Label_15 = New System.Windows.Forms.Label
        Me._Label_14 = New System.Windows.Forms.Label
        Me._Label_13 = New System.Windows.Forms.Label
        Me._Label_12 = New System.Windows.Forms.Label
        Me._Label_11 = New System.Windows.Forms.Label
        Me._Label_10 = New System.Windows.Forms.Label
        Me._Label_9 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Label_5 = New System.Windows.Forms.Label
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_34 = New System.Windows.Forms.Label
        Me._Label_32 = New System.Windows.Forms.Label
        Me._Label_33 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me.GrdNhanvien = New ListViewEx.ListviewExt
        Me._txtn_32 = New System.Windows.Forms.TextBox
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.Transparent
        Me.Frame1.Controls.Add(Me.TxtNgayle)
        Me.Frame1.Controls.Add(Me.TxtChunhat)
        Me.Frame1.Controls.Add(Me.TxtTrongtuan)
        Me.Frame1.Controls.Add(Me._Label_82)
        Me.Frame1.Controls.Add(Me._Label_81)
        Me.Frame1.Controls.Add(Me._Label_37)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(32, 456)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(209, 89)
        Me.Frame1.TabIndex = 181
        Me.Frame1.TabStop = False
        Me.Frame1.Tag = "Overtime rate"
        Me.Frame1.Text = "Tỷ lệ tăng ca"
        '
        'TxtNgayle
        '
        Me.TxtNgayle.AcceptsReturn = True
        Me.TxtNgayle.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNgayle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNgayle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgayle.Location = New System.Drawing.Point(88, 64)
        Me.TxtNgayle.MaxLength = 0
        Me.TxtNgayle.Name = "TxtNgayle"
        Me.TxtNgayle.Size = New System.Drawing.Size(25, 20)
        Me.TxtNgayle.TabIndex = 176
        Me.TxtNgayle.Text = "3"
        Me.TxtNgayle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtChunhat
        '
        Me.TxtChunhat.AcceptsReturn = True
        Me.TxtChunhat.BackColor = System.Drawing.SystemColors.Window
        Me.TxtChunhat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtChunhat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtChunhat.Location = New System.Drawing.Point(88, 40)
        Me.TxtChunhat.MaxLength = 0
        Me.TxtChunhat.Name = "TxtChunhat"
        Me.TxtChunhat.Size = New System.Drawing.Size(25, 20)
        Me.TxtChunhat.TabIndex = 175
        Me.TxtChunhat.Text = "2"
        Me.TxtChunhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTrongtuan
        '
        Me.TxtTrongtuan.AcceptsReturn = True
        Me.TxtTrongtuan.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTrongtuan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTrongtuan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTrongtuan.Location = New System.Drawing.Point(88, 16)
        Me.TxtTrongtuan.MaxLength = 0
        Me.TxtTrongtuan.Name = "TxtTrongtuan"
        Me.TxtTrongtuan.Size = New System.Drawing.Size(25, 20)
        Me.TxtTrongtuan.TabIndex = 174
        Me.TxtTrongtuan.Text = "1.5"
        Me.TxtTrongtuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Label_82
        '
        Me._Label_82.BackColor = System.Drawing.Color.Transparent
        Me._Label_82.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_82.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_82.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_82.Location = New System.Drawing.Point(16, 64)
        Me._Label_82.Name = "_Label_82"
        Me._Label_82.Size = New System.Drawing.Size(177, 17)
        Me._Label_82.TabIndex = 184
        Me._Label_82.Tag = "Holiday      =               x  day"
        Me._Label_82.Text = "Ngày lễ      =               x  ngày thường"
        '
        '_Label_81
        '
        Me._Label_81.BackColor = System.Drawing.Color.Transparent
        Me._Label_81.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_81.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_81.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_81.Location = New System.Drawing.Point(16, 40)
        Me._Label_81.Name = "_Label_81"
        Me._Label_81.Size = New System.Drawing.Size(177, 17)
        Me._Label_81.TabIndex = 183
        Me._Label_81.Tag = "Sunday      =              x  day"
        Me._Label_81.Text = "Chủ nhật    =              x  ngày thường"
        '
        '_Label_37
        '
        Me._Label_37.BackColor = System.Drawing.Color.Transparent
        Me._Label_37.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_37.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_37.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_37.Location = New System.Drawing.Point(16, 16)
        Me._Label_37.Name = "_Label_37"
        Me._Label_37.Size = New System.Drawing.Size(177, 17)
        Me._Label_37.TabIndex = 182
        Me._Label_37.Tag = "Weekdays  =              x  day"
        Me._Label_37.Text = "Trong tuần =              x  ngày thường"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(800, 520)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(81, 25)
        Me._Command_2.TabIndex = 180
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(888, 520)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(81, 25)
        Me._Command_1.TabIndex = 179
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.select16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(696, 520)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(97, 25)
        Me._Command_0.TabIndex = 178
        Me._Command_0.Tag = "Save"
        Me._Command_0.Text = "Chấm côn&g"
        '
        '_txtn_31
        '
        Me._txtn_31.AcceptsReturn = True
        Me._txtn_31.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_31.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_31.Location = New System.Drawing.Point(928, 432)
        Me._txtn_31.MaxLength = 2
        Me._txtn_31.Name = "_txtn_31"
        Me._txtn_31.Size = New System.Drawing.Size(17, 20)
        Me._txtn_31.TabIndex = 173
        Me._txtn_31.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_30
        '
        Me._txtn_30.AcceptsReturn = True
        Me._txtn_30.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_30.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_30.Location = New System.Drawing.Point(912, 432)
        Me._txtn_30.MaxLength = 2
        Me._txtn_30.Name = "_txtn_30"
        Me._txtn_30.Size = New System.Drawing.Size(17, 20)
        Me._txtn_30.TabIndex = 172
        Me._txtn_30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_29
        '
        Me._txtn_29.AcceptsReturn = True
        Me._txtn_29.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_29.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_29.Location = New System.Drawing.Point(896, 432)
        Me._txtn_29.MaxLength = 2
        Me._txtn_29.Name = "_txtn_29"
        Me._txtn_29.Size = New System.Drawing.Size(17, 20)
        Me._txtn_29.TabIndex = 171
        Me._txtn_29.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_28
        '
        Me._txtn_28.AcceptsReturn = True
        Me._txtn_28.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_28.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_28.Location = New System.Drawing.Point(880, 432)
        Me._txtn_28.MaxLength = 2
        Me._txtn_28.Name = "_txtn_28"
        Me._txtn_28.Size = New System.Drawing.Size(17, 20)
        Me._txtn_28.TabIndex = 170
        Me._txtn_28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_27
        '
        Me._txtn_27.AcceptsReturn = True
        Me._txtn_27.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_27.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_27.Location = New System.Drawing.Point(864, 432)
        Me._txtn_27.MaxLength = 2
        Me._txtn_27.Name = "_txtn_27"
        Me._txtn_27.Size = New System.Drawing.Size(17, 20)
        Me._txtn_27.TabIndex = 169
        Me._txtn_27.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_26
        '
        Me._txtn_26.AcceptsReturn = True
        Me._txtn_26.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_26.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_26.Location = New System.Drawing.Point(848, 432)
        Me._txtn_26.MaxLength = 2
        Me._txtn_26.Name = "_txtn_26"
        Me._txtn_26.Size = New System.Drawing.Size(17, 20)
        Me._txtn_26.TabIndex = 168
        Me._txtn_26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_25
        '
        Me._txtn_25.AcceptsReturn = True
        Me._txtn_25.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_25.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_25.Location = New System.Drawing.Point(832, 432)
        Me._txtn_25.MaxLength = 2
        Me._txtn_25.Name = "_txtn_25"
        Me._txtn_25.Size = New System.Drawing.Size(17, 20)
        Me._txtn_25.TabIndex = 167
        Me._txtn_25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_24
        '
        Me._txtn_24.AcceptsReturn = True
        Me._txtn_24.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_24.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_24.Location = New System.Drawing.Point(816, 432)
        Me._txtn_24.MaxLength = 2
        Me._txtn_24.Name = "_txtn_24"
        Me._txtn_24.Size = New System.Drawing.Size(17, 20)
        Me._txtn_24.TabIndex = 166
        Me._txtn_24.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_23
        '
        Me._txtn_23.AcceptsReturn = True
        Me._txtn_23.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_23.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_23.Location = New System.Drawing.Point(800, 432)
        Me._txtn_23.MaxLength = 2
        Me._txtn_23.Name = "_txtn_23"
        Me._txtn_23.Size = New System.Drawing.Size(17, 20)
        Me._txtn_23.TabIndex = 165
        Me._txtn_23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_22
        '
        Me._txtn_22.AcceptsReturn = True
        Me._txtn_22.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_22.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_22.Location = New System.Drawing.Point(784, 432)
        Me._txtn_22.MaxLength = 2
        Me._txtn_22.Name = "_txtn_22"
        Me._txtn_22.Size = New System.Drawing.Size(17, 20)
        Me._txtn_22.TabIndex = 164
        Me._txtn_22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_21
        '
        Me._txtn_21.AcceptsReturn = True
        Me._txtn_21.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_21.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_21.Location = New System.Drawing.Point(768, 432)
        Me._txtn_21.MaxLength = 2
        Me._txtn_21.Name = "_txtn_21"
        Me._txtn_21.Size = New System.Drawing.Size(17, 20)
        Me._txtn_21.TabIndex = 163
        Me._txtn_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_20
        '
        Me._txtn_20.AcceptsReturn = True
        Me._txtn_20.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_20.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_20.Location = New System.Drawing.Point(752, 432)
        Me._txtn_20.MaxLength = 2
        Me._txtn_20.Name = "_txtn_20"
        Me._txtn_20.Size = New System.Drawing.Size(17, 20)
        Me._txtn_20.TabIndex = 162
        Me._txtn_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_19
        '
        Me._txtn_19.AcceptsReturn = True
        Me._txtn_19.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_19.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_19.Location = New System.Drawing.Point(736, 432)
        Me._txtn_19.MaxLength = 2
        Me._txtn_19.Name = "_txtn_19"
        Me._txtn_19.Size = New System.Drawing.Size(17, 20)
        Me._txtn_19.TabIndex = 161
        Me._txtn_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_18
        '
        Me._txtn_18.AcceptsReturn = True
        Me._txtn_18.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_18.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_18.Location = New System.Drawing.Point(720, 432)
        Me._txtn_18.MaxLength = 2
        Me._txtn_18.Name = "_txtn_18"
        Me._txtn_18.Size = New System.Drawing.Size(17, 20)
        Me._txtn_18.TabIndex = 160
        Me._txtn_18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_17
        '
        Me._txtn_17.AcceptsReturn = True
        Me._txtn_17.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_17.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_17.Location = New System.Drawing.Point(704, 432)
        Me._txtn_17.MaxLength = 2
        Me._txtn_17.Name = "_txtn_17"
        Me._txtn_17.Size = New System.Drawing.Size(17, 20)
        Me._txtn_17.TabIndex = 159
        Me._txtn_17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_16
        '
        Me._txtn_16.AcceptsReturn = True
        Me._txtn_16.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_16.Location = New System.Drawing.Point(688, 432)
        Me._txtn_16.MaxLength = 2
        Me._txtn_16.Name = "_txtn_16"
        Me._txtn_16.Size = New System.Drawing.Size(17, 20)
        Me._txtn_16.TabIndex = 158
        Me._txtn_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_15
        '
        Me._txtn_15.AcceptsReturn = True
        Me._txtn_15.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_15.Location = New System.Drawing.Point(672, 432)
        Me._txtn_15.MaxLength = 2
        Me._txtn_15.Name = "_txtn_15"
        Me._txtn_15.Size = New System.Drawing.Size(17, 20)
        Me._txtn_15.TabIndex = 157
        Me._txtn_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_14
        '
        Me._txtn_14.AcceptsReturn = True
        Me._txtn_14.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_14.Location = New System.Drawing.Point(656, 432)
        Me._txtn_14.MaxLength = 2
        Me._txtn_14.Name = "_txtn_14"
        Me._txtn_14.Size = New System.Drawing.Size(17, 20)
        Me._txtn_14.TabIndex = 156
        Me._txtn_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_13
        '
        Me._txtn_13.AcceptsReturn = True
        Me._txtn_13.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_13.Location = New System.Drawing.Point(640, 432)
        Me._txtn_13.MaxLength = 2
        Me._txtn_13.Name = "_txtn_13"
        Me._txtn_13.Size = New System.Drawing.Size(17, 20)
        Me._txtn_13.TabIndex = 155
        Me._txtn_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_12
        '
        Me._txtn_12.AcceptsReturn = True
        Me._txtn_12.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_12.Location = New System.Drawing.Point(624, 432)
        Me._txtn_12.MaxLength = 2
        Me._txtn_12.Name = "_txtn_12"
        Me._txtn_12.Size = New System.Drawing.Size(17, 20)
        Me._txtn_12.TabIndex = 154
        Me._txtn_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_11
        '
        Me._txtn_11.AcceptsReturn = True
        Me._txtn_11.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_11.Location = New System.Drawing.Point(608, 432)
        Me._txtn_11.MaxLength = 2
        Me._txtn_11.Name = "_txtn_11"
        Me._txtn_11.Size = New System.Drawing.Size(17, 20)
        Me._txtn_11.TabIndex = 153
        Me._txtn_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_10
        '
        Me._txtn_10.AcceptsReturn = True
        Me._txtn_10.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_10.Location = New System.Drawing.Point(592, 432)
        Me._txtn_10.MaxLength = 2
        Me._txtn_10.Name = "_txtn_10"
        Me._txtn_10.Size = New System.Drawing.Size(17, 20)
        Me._txtn_10.TabIndex = 152
        Me._txtn_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_9
        '
        Me._txtn_9.AcceptsReturn = True
        Me._txtn_9.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_9.Location = New System.Drawing.Point(576, 432)
        Me._txtn_9.MaxLength = 2
        Me._txtn_9.Name = "_txtn_9"
        Me._txtn_9.Size = New System.Drawing.Size(17, 20)
        Me._txtn_9.TabIndex = 151
        Me._txtn_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_8
        '
        Me._txtn_8.AcceptsReturn = True
        Me._txtn_8.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_8.Location = New System.Drawing.Point(560, 432)
        Me._txtn_8.MaxLength = 2
        Me._txtn_8.Name = "_txtn_8"
        Me._txtn_8.Size = New System.Drawing.Size(17, 20)
        Me._txtn_8.TabIndex = 150
        Me._txtn_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_7
        '
        Me._txtn_7.AcceptsReturn = True
        Me._txtn_7.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_7.Location = New System.Drawing.Point(544, 432)
        Me._txtn_7.MaxLength = 2
        Me._txtn_7.Name = "_txtn_7"
        Me._txtn_7.Size = New System.Drawing.Size(17, 20)
        Me._txtn_7.TabIndex = 149
        Me._txtn_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_6
        '
        Me._txtn_6.AcceptsReturn = True
        Me._txtn_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_6.Location = New System.Drawing.Point(528, 432)
        Me._txtn_6.MaxLength = 2
        Me._txtn_6.Name = "_txtn_6"
        Me._txtn_6.Size = New System.Drawing.Size(17, 20)
        Me._txtn_6.TabIndex = 148
        Me._txtn_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_5
        '
        Me._txtn_5.AcceptsReturn = True
        Me._txtn_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_5.Location = New System.Drawing.Point(512, 432)
        Me._txtn_5.MaxLength = 2
        Me._txtn_5.Name = "_txtn_5"
        Me._txtn_5.Size = New System.Drawing.Size(17, 20)
        Me._txtn_5.TabIndex = 147
        Me._txtn_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_4
        '
        Me._txtn_4.AcceptsReturn = True
        Me._txtn_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_4.Location = New System.Drawing.Point(496, 432)
        Me._txtn_4.MaxLength = 2
        Me._txtn_4.Name = "_txtn_4"
        Me._txtn_4.Size = New System.Drawing.Size(17, 20)
        Me._txtn_4.TabIndex = 146
        Me._txtn_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_3
        '
        Me._txtn_3.AcceptsReturn = True
        Me._txtn_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_3.Location = New System.Drawing.Point(480, 432)
        Me._txtn_3.MaxLength = 2
        Me._txtn_3.Name = "_txtn_3"
        Me._txtn_3.Size = New System.Drawing.Size(17, 20)
        Me._txtn_3.TabIndex = 145
        Me._txtn_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_2
        '
        Me._txtn_2.AcceptsReturn = True
        Me._txtn_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_2.Location = New System.Drawing.Point(464, 432)
        Me._txtn_2.MaxLength = 2
        Me._txtn_2.Name = "_txtn_2"
        Me._txtn_2.Size = New System.Drawing.Size(17, 20)
        Me._txtn_2.TabIndex = 144
        Me._txtn_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtn_1
        '
        Me._txtn_1.AcceptsReturn = True
        Me._txtn_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtn_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_1.Location = New System.Drawing.Point(448, 432)
        Me._txtn_1.MaxLength = 2
        Me._txtn_1.Name = "_txtn_1"
        Me._txtn_1.Size = New System.Drawing.Size(17, 20)
        Me._txtn_1.TabIndex = 143
        Me._txtn_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_31
        '
        Me._txtnc_31.AcceptsReturn = True
        Me._txtnc_31.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_31.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_31.Location = New System.Drawing.Point(928, 480)
        Me._txtnc_31.MaxLength = 2
        Me._txtnc_31.Name = "_txtnc_31"
        Me._txtnc_31.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_31.TabIndex = 139
        Me._txtnc_31.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_30
        '
        Me._txtnc_30.AcceptsReturn = True
        Me._txtnc_30.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_30.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_30.Location = New System.Drawing.Point(912, 480)
        Me._txtnc_30.MaxLength = 2
        Me._txtnc_30.Name = "_txtnc_30"
        Me._txtnc_30.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_30.TabIndex = 137
        Me._txtnc_30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_29
        '
        Me._txtnc_29.AcceptsReturn = True
        Me._txtnc_29.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_29.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_29.Location = New System.Drawing.Point(896, 480)
        Me._txtnc_29.MaxLength = 2
        Me._txtnc_29.Name = "_txtnc_29"
        Me._txtnc_29.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_29.TabIndex = 135
        Me._txtnc_29.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_28
        '
        Me._txtnc_28.AcceptsReturn = True
        Me._txtnc_28.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_28.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_28.Location = New System.Drawing.Point(880, 480)
        Me._txtnc_28.MaxLength = 2
        Me._txtnc_28.Name = "_txtnc_28"
        Me._txtnc_28.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_28.TabIndex = 133
        Me._txtnc_28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_27
        '
        Me._txtnc_27.AcceptsReturn = True
        Me._txtnc_27.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_27.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_27.Location = New System.Drawing.Point(864, 480)
        Me._txtnc_27.MaxLength = 2
        Me._txtnc_27.Name = "_txtnc_27"
        Me._txtnc_27.Size = New System.Drawing.Size(18, 20)
        Me._txtnc_27.TabIndex = 131
        Me._txtnc_27.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_26
        '
        Me._txtnc_26.AcceptsReturn = True
        Me._txtnc_26.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_26.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_26.Location = New System.Drawing.Point(848, 480)
        Me._txtnc_26.MaxLength = 2
        Me._txtnc_26.Name = "_txtnc_26"
        Me._txtnc_26.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_26.TabIndex = 129
        Me._txtnc_26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_25
        '
        Me._txtnc_25.AcceptsReturn = True
        Me._txtnc_25.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_25.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_25.Location = New System.Drawing.Point(832, 480)
        Me._txtnc_25.MaxLength = 2
        Me._txtnc_25.Name = "_txtnc_25"
        Me._txtnc_25.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_25.TabIndex = 127
        Me._txtnc_25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_24
        '
        Me._txtnc_24.AcceptsReturn = True
        Me._txtnc_24.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_24.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_24.Location = New System.Drawing.Point(816, 480)
        Me._txtnc_24.MaxLength = 2
        Me._txtnc_24.Name = "_txtnc_24"
        Me._txtnc_24.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_24.TabIndex = 125
        Me._txtnc_24.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_23
        '
        Me._txtnc_23.AcceptsReturn = True
        Me._txtnc_23.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_23.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_23.Location = New System.Drawing.Point(800, 480)
        Me._txtnc_23.MaxLength = 2
        Me._txtnc_23.Name = "_txtnc_23"
        Me._txtnc_23.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_23.TabIndex = 123
        Me._txtnc_23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_22
        '
        Me._txtnc_22.AcceptsReturn = True
        Me._txtnc_22.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_22.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_22.Location = New System.Drawing.Point(784, 480)
        Me._txtnc_22.MaxLength = 2
        Me._txtnc_22.Name = "_txtnc_22"
        Me._txtnc_22.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_22.TabIndex = 121
        Me._txtnc_22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_21
        '
        Me._txtnc_21.AcceptsReturn = True
        Me._txtnc_21.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_21.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_21.Location = New System.Drawing.Point(768, 480)
        Me._txtnc_21.MaxLength = 2
        Me._txtnc_21.Name = "_txtnc_21"
        Me._txtnc_21.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_21.TabIndex = 119
        Me._txtnc_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_20
        '
        Me._txtnc_20.AcceptsReturn = True
        Me._txtnc_20.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_20.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_20.Location = New System.Drawing.Point(752, 480)
        Me._txtnc_20.MaxLength = 2
        Me._txtnc_20.Name = "_txtnc_20"
        Me._txtnc_20.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_20.TabIndex = 117
        Me._txtnc_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_19
        '
        Me._txtnc_19.AcceptsReturn = True
        Me._txtnc_19.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_19.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_19.Location = New System.Drawing.Point(736, 480)
        Me._txtnc_19.MaxLength = 2
        Me._txtnc_19.Name = "_txtnc_19"
        Me._txtnc_19.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_19.TabIndex = 115
        Me._txtnc_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_18
        '
        Me._txtnc_18.AcceptsReturn = True
        Me._txtnc_18.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_18.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_18.Location = New System.Drawing.Point(720, 480)
        Me._txtnc_18.MaxLength = 2
        Me._txtnc_18.Name = "_txtnc_18"
        Me._txtnc_18.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_18.TabIndex = 113
        Me._txtnc_18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_17
        '
        Me._txtnc_17.AcceptsReturn = True
        Me._txtnc_17.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_17.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_17.Location = New System.Drawing.Point(704, 480)
        Me._txtnc_17.MaxLength = 2
        Me._txtnc_17.Name = "_txtnc_17"
        Me._txtnc_17.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_17.TabIndex = 111
        Me._txtnc_17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_16
        '
        Me._txtnc_16.AcceptsReturn = True
        Me._txtnc_16.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_16.Location = New System.Drawing.Point(688, 480)
        Me._txtnc_16.MaxLength = 2
        Me._txtnc_16.Name = "_txtnc_16"
        Me._txtnc_16.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_16.TabIndex = 109
        Me._txtnc_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_15
        '
        Me._txtnc_15.AcceptsReturn = True
        Me._txtnc_15.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_15.Location = New System.Drawing.Point(672, 480)
        Me._txtnc_15.MaxLength = 2
        Me._txtnc_15.Name = "_txtnc_15"
        Me._txtnc_15.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_15.TabIndex = 107
        Me._txtnc_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_14
        '
        Me._txtnc_14.AcceptsReturn = True
        Me._txtnc_14.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_14.Location = New System.Drawing.Point(656, 480)
        Me._txtnc_14.MaxLength = 2
        Me._txtnc_14.Name = "_txtnc_14"
        Me._txtnc_14.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_14.TabIndex = 105
        Me._txtnc_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_13
        '
        Me._txtnc_13.AcceptsReturn = True
        Me._txtnc_13.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_13.Location = New System.Drawing.Point(640, 480)
        Me._txtnc_13.MaxLength = 2
        Me._txtnc_13.Name = "_txtnc_13"
        Me._txtnc_13.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_13.TabIndex = 103
        Me._txtnc_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_12
        '
        Me._txtnc_12.AcceptsReturn = True
        Me._txtnc_12.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_12.Location = New System.Drawing.Point(624, 480)
        Me._txtnc_12.MaxLength = 2
        Me._txtnc_12.Name = "_txtnc_12"
        Me._txtnc_12.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_12.TabIndex = 101
        Me._txtnc_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_11
        '
        Me._txtnc_11.AcceptsReturn = True
        Me._txtnc_11.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_11.Location = New System.Drawing.Point(608, 480)
        Me._txtnc_11.MaxLength = 2
        Me._txtnc_11.Name = "_txtnc_11"
        Me._txtnc_11.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_11.TabIndex = 99
        Me._txtnc_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_10
        '
        Me._txtnc_10.AcceptsReturn = True
        Me._txtnc_10.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_10.Location = New System.Drawing.Point(592, 480)
        Me._txtnc_10.MaxLength = 2
        Me._txtnc_10.Name = "_txtnc_10"
        Me._txtnc_10.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_10.TabIndex = 97
        Me._txtnc_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_9
        '
        Me._txtnc_9.AcceptsReturn = True
        Me._txtnc_9.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_9.Location = New System.Drawing.Point(576, 480)
        Me._txtnc_9.MaxLength = 2
        Me._txtnc_9.Name = "_txtnc_9"
        Me._txtnc_9.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_9.TabIndex = 95
        Me._txtnc_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_8
        '
        Me._txtnc_8.AcceptsReturn = True
        Me._txtnc_8.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_8.Location = New System.Drawing.Point(560, 480)
        Me._txtnc_8.MaxLength = 2
        Me._txtnc_8.Name = "_txtnc_8"
        Me._txtnc_8.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_8.TabIndex = 93
        Me._txtnc_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_7
        '
        Me._txtnc_7.AcceptsReturn = True
        Me._txtnc_7.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_7.Location = New System.Drawing.Point(544, 480)
        Me._txtnc_7.MaxLength = 2
        Me._txtnc_7.Name = "_txtnc_7"
        Me._txtnc_7.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_7.TabIndex = 91
        Me._txtnc_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_6
        '
        Me._txtnc_6.AcceptsReturn = True
        Me._txtnc_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_6.Location = New System.Drawing.Point(528, 480)
        Me._txtnc_6.MaxLength = 2
        Me._txtnc_6.Name = "_txtnc_6"
        Me._txtnc_6.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_6.TabIndex = 89
        Me._txtnc_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_5
        '
        Me._txtnc_5.AcceptsReturn = True
        Me._txtnc_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_5.Location = New System.Drawing.Point(512, 480)
        Me._txtnc_5.MaxLength = 2
        Me._txtnc_5.Name = "_txtnc_5"
        Me._txtnc_5.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_5.TabIndex = 87
        Me._txtnc_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_4
        '
        Me._txtnc_4.AcceptsReturn = True
        Me._txtnc_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_4.Location = New System.Drawing.Point(496, 480)
        Me._txtnc_4.MaxLength = 2
        Me._txtnc_4.Name = "_txtnc_4"
        Me._txtnc_4.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_4.TabIndex = 85
        Me._txtnc_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_3
        '
        Me._txtnc_3.AcceptsReturn = True
        Me._txtnc_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_3.Location = New System.Drawing.Point(480, 480)
        Me._txtnc_3.MaxLength = 2
        Me._txtnc_3.Name = "_txtnc_3"
        Me._txtnc_3.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_3.TabIndex = 83
        Me._txtnc_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_2
        '
        Me._txtnc_2.AcceptsReturn = True
        Me._txtnc_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_2.Location = New System.Drawing.Point(464, 480)
        Me._txtnc_2.MaxLength = 2
        Me._txtnc_2.Name = "_txtnc_2"
        Me._txtnc_2.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_2.TabIndex = 81
        Me._txtnc_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_1
        '
        Me._txtnc_1.AcceptsReturn = True
        Me._txtnc_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtnc_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_1.Location = New System.Drawing.Point(448, 480)
        Me._txtnc_1.MaxLength = 2
        Me._txtnc_1.Name = "_txtnc_1"
        Me._txtnc_1.Size = New System.Drawing.Size(17, 20)
        Me._txtnc_1.TabIndex = 79
        Me._txtnc_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnc_0
        '
        Me._txtnc_0.AcceptsReturn = True
        Me._txtnc_0.BackColor = System.Drawing.Color.Silver
        Me._txtnc_0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtnc_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._txtnc_0.Location = New System.Drawing.Point(415, 483)
        Me._txtnc_0.MaxLength = 20
        Me._txtnc_0.Name = "_txtnc_0"
        Me._txtnc_0.ReadOnly = True
        Me._txtnc_0.Size = New System.Drawing.Size(34, 13)
        Me._txtnc_0.TabIndex = 140
        Me._txtnc_0.TabStop = False
        Me._txtnc_0.Tag = "To"
        Me._txtnc_0.Text = "Đến"
        Me._txtnc_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtnd_31
        '
        Me._txtnd_31.AcceptsReturn = True
        Me._txtnd_31.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_31.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_31.Location = New System.Drawing.Point(928, 456)
        Me._txtnd_31.MaxLength = 2
        Me._txtnd_31.Name = "_txtnd_31"
        Me._txtnd_31.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_31.TabIndex = 138
        Me._txtnd_31.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_30
        '
        Me._txtnd_30.AcceptsReturn = True
        Me._txtnd_30.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_30.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_30.Location = New System.Drawing.Point(912, 456)
        Me._txtnd_30.MaxLength = 2
        Me._txtnd_30.Name = "_txtnd_30"
        Me._txtnd_30.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_30.TabIndex = 136
        Me._txtnd_30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_29
        '
        Me._txtnd_29.AcceptsReturn = True
        Me._txtnd_29.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_29.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_29.Location = New System.Drawing.Point(896, 456)
        Me._txtnd_29.MaxLength = 2
        Me._txtnd_29.Name = "_txtnd_29"
        Me._txtnd_29.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_29.TabIndex = 134
        Me._txtnd_29.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_28
        '
        Me._txtnd_28.AcceptsReturn = True
        Me._txtnd_28.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_28.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_28.Location = New System.Drawing.Point(880, 456)
        Me._txtnd_28.MaxLength = 2
        Me._txtnd_28.Name = "_txtnd_28"
        Me._txtnd_28.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_28.TabIndex = 132
        Me._txtnd_28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_27
        '
        Me._txtnd_27.AcceptsReturn = True
        Me._txtnd_27.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_27.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_27.Location = New System.Drawing.Point(864, 456)
        Me._txtnd_27.MaxLength = 2
        Me._txtnd_27.Name = "_txtnd_27"
        Me._txtnd_27.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_27.TabIndex = 130
        Me._txtnd_27.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_26
        '
        Me._txtnd_26.AcceptsReturn = True
        Me._txtnd_26.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_26.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_26.Location = New System.Drawing.Point(848, 456)
        Me._txtnd_26.MaxLength = 2
        Me._txtnd_26.Name = "_txtnd_26"
        Me._txtnd_26.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_26.TabIndex = 128
        Me._txtnd_26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_25
        '
        Me._txtnd_25.AcceptsReturn = True
        Me._txtnd_25.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_25.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_25.Location = New System.Drawing.Point(832, 456)
        Me._txtnd_25.MaxLength = 2
        Me._txtnd_25.Name = "_txtnd_25"
        Me._txtnd_25.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_25.TabIndex = 126
        Me._txtnd_25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_24
        '
        Me._txtnd_24.AcceptsReturn = True
        Me._txtnd_24.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_24.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_24.Location = New System.Drawing.Point(816, 456)
        Me._txtnd_24.MaxLength = 2
        Me._txtnd_24.Name = "_txtnd_24"
        Me._txtnd_24.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_24.TabIndex = 124
        Me._txtnd_24.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_23
        '
        Me._txtnd_23.AcceptsReturn = True
        Me._txtnd_23.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_23.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_23.Location = New System.Drawing.Point(800, 456)
        Me._txtnd_23.MaxLength = 2
        Me._txtnd_23.Name = "_txtnd_23"
        Me._txtnd_23.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_23.TabIndex = 122
        Me._txtnd_23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_22
        '
        Me._txtnd_22.AcceptsReturn = True
        Me._txtnd_22.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_22.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_22.Location = New System.Drawing.Point(784, 456)
        Me._txtnd_22.MaxLength = 2
        Me._txtnd_22.Name = "_txtnd_22"
        Me._txtnd_22.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_22.TabIndex = 120
        Me._txtnd_22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_21
        '
        Me._txtnd_21.AcceptsReturn = True
        Me._txtnd_21.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_21.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_21.Location = New System.Drawing.Point(768, 456)
        Me._txtnd_21.MaxLength = 2
        Me._txtnd_21.Name = "_txtnd_21"
        Me._txtnd_21.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_21.TabIndex = 118
        Me._txtnd_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_20
        '
        Me._txtnd_20.AcceptsReturn = True
        Me._txtnd_20.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_20.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_20.Location = New System.Drawing.Point(752, 456)
        Me._txtnd_20.MaxLength = 2
        Me._txtnd_20.Name = "_txtnd_20"
        Me._txtnd_20.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_20.TabIndex = 116
        Me._txtnd_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_19
        '
        Me._txtnd_19.AcceptsReturn = True
        Me._txtnd_19.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_19.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_19.Location = New System.Drawing.Point(736, 456)
        Me._txtnd_19.MaxLength = 2
        Me._txtnd_19.Name = "_txtnd_19"
        Me._txtnd_19.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_19.TabIndex = 114
        Me._txtnd_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_18
        '
        Me._txtnd_18.AcceptsReturn = True
        Me._txtnd_18.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_18.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_18.Location = New System.Drawing.Point(720, 456)
        Me._txtnd_18.MaxLength = 2
        Me._txtnd_18.Name = "_txtnd_18"
        Me._txtnd_18.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_18.TabIndex = 112
        Me._txtnd_18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_17
        '
        Me._txtnd_17.AcceptsReturn = True
        Me._txtnd_17.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_17.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_17.Location = New System.Drawing.Point(704, 456)
        Me._txtnd_17.MaxLength = 2
        Me._txtnd_17.Name = "_txtnd_17"
        Me._txtnd_17.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_17.TabIndex = 110
        Me._txtnd_17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_16
        '
        Me._txtnd_16.AcceptsReturn = True
        Me._txtnd_16.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_16.Location = New System.Drawing.Point(688, 456)
        Me._txtnd_16.MaxLength = 2
        Me._txtnd_16.Name = "_txtnd_16"
        Me._txtnd_16.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_16.TabIndex = 108
        Me._txtnd_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_15
        '
        Me._txtnd_15.AcceptsReturn = True
        Me._txtnd_15.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_15.Location = New System.Drawing.Point(672, 456)
        Me._txtnd_15.MaxLength = 2
        Me._txtnd_15.Name = "_txtnd_15"
        Me._txtnd_15.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_15.TabIndex = 106
        Me._txtnd_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_14
        '
        Me._txtnd_14.AcceptsReturn = True
        Me._txtnd_14.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_14.Location = New System.Drawing.Point(656, 456)
        Me._txtnd_14.MaxLength = 2
        Me._txtnd_14.Name = "_txtnd_14"
        Me._txtnd_14.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_14.TabIndex = 104
        Me._txtnd_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_13
        '
        Me._txtnd_13.AcceptsReturn = True
        Me._txtnd_13.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_13.Location = New System.Drawing.Point(640, 456)
        Me._txtnd_13.MaxLength = 2
        Me._txtnd_13.Name = "_txtnd_13"
        Me._txtnd_13.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_13.TabIndex = 102
        Me._txtnd_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_12
        '
        Me._txtnd_12.AcceptsReturn = True
        Me._txtnd_12.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_12.Location = New System.Drawing.Point(624, 456)
        Me._txtnd_12.MaxLength = 2
        Me._txtnd_12.Name = "_txtnd_12"
        Me._txtnd_12.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_12.TabIndex = 100
        Me._txtnd_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_11
        '
        Me._txtnd_11.AcceptsReturn = True
        Me._txtnd_11.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_11.Location = New System.Drawing.Point(608, 456)
        Me._txtnd_11.MaxLength = 2
        Me._txtnd_11.Name = "_txtnd_11"
        Me._txtnd_11.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_11.TabIndex = 98
        Me._txtnd_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_10
        '
        Me._txtnd_10.AcceptsReturn = True
        Me._txtnd_10.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_10.Location = New System.Drawing.Point(592, 456)
        Me._txtnd_10.MaxLength = 2
        Me._txtnd_10.Name = "_txtnd_10"
        Me._txtnd_10.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_10.TabIndex = 96
        Me._txtnd_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_9
        '
        Me._txtnd_9.AcceptsReturn = True
        Me._txtnd_9.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_9.Location = New System.Drawing.Point(576, 456)
        Me._txtnd_9.MaxLength = 2
        Me._txtnd_9.Name = "_txtnd_9"
        Me._txtnd_9.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_9.TabIndex = 94
        Me._txtnd_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_8
        '
        Me._txtnd_8.AcceptsReturn = True
        Me._txtnd_8.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_8.Location = New System.Drawing.Point(560, 456)
        Me._txtnd_8.MaxLength = 2
        Me._txtnd_8.Name = "_txtnd_8"
        Me._txtnd_8.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_8.TabIndex = 92
        Me._txtnd_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_7
        '
        Me._txtnd_7.AcceptsReturn = True
        Me._txtnd_7.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_7.Location = New System.Drawing.Point(544, 456)
        Me._txtnd_7.MaxLength = 2
        Me._txtnd_7.Name = "_txtnd_7"
        Me._txtnd_7.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_7.TabIndex = 90
        Me._txtnd_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_6
        '
        Me._txtnd_6.AcceptsReturn = True
        Me._txtnd_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_6.Location = New System.Drawing.Point(528, 456)
        Me._txtnd_6.MaxLength = 2
        Me._txtnd_6.Name = "_txtnd_6"
        Me._txtnd_6.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_6.TabIndex = 88
        Me._txtnd_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_5
        '
        Me._txtnd_5.AcceptsReturn = True
        Me._txtnd_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_5.Location = New System.Drawing.Point(512, 456)
        Me._txtnd_5.MaxLength = 2
        Me._txtnd_5.Name = "_txtnd_5"
        Me._txtnd_5.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_5.TabIndex = 86
        Me._txtnd_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_4
        '
        Me._txtnd_4.AcceptsReturn = True
        Me._txtnd_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_4.Location = New System.Drawing.Point(496, 456)
        Me._txtnd_4.MaxLength = 2
        Me._txtnd_4.Name = "_txtnd_4"
        Me._txtnd_4.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_4.TabIndex = 84
        Me._txtnd_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_3
        '
        Me._txtnd_3.AcceptsReturn = True
        Me._txtnd_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_3.Location = New System.Drawing.Point(480, 456)
        Me._txtnd_3.MaxLength = 2
        Me._txtnd_3.Name = "_txtnd_3"
        Me._txtnd_3.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_3.TabIndex = 82
        Me._txtnd_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_2
        '
        Me._txtnd_2.AcceptsReturn = True
        Me._txtnd_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_2.Location = New System.Drawing.Point(464, 456)
        Me._txtnd_2.MaxLength = 2
        Me._txtnd_2.Name = "_txtnd_2"
        Me._txtnd_2.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_2.TabIndex = 80
        Me._txtnd_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_1
        '
        Me._txtnd_1.AcceptsReturn = True
        Me._txtnd_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtnd_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_1.Location = New System.Drawing.Point(448, 456)
        Me._txtnd_1.MaxLength = 2
        Me._txtnd_1.Name = "_txtnd_1"
        Me._txtnd_1.Size = New System.Drawing.Size(17, 20)
        Me._txtnd_1.TabIndex = 78
        Me._txtnd_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtnd_0
        '
        Me._txtnd_0.AcceptsReturn = True
        Me._txtnd_0.BackColor = System.Drawing.Color.Silver
        Me._txtnd_0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtnd_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._txtnd_0.Location = New System.Drawing.Point(415, 459)
        Me._txtnd_0.MaxLength = 20
        Me._txtnd_0.Name = "_txtnd_0"
        Me._txtnd_0.ReadOnly = True
        Me._txtnd_0.Size = New System.Drawing.Size(35, 13)
        Me._txtnd_0.TabIndex = 77
        Me._txtnd_0.TabStop = False
        Me._txtnd_0.Tag = "From"
        Me._txtnd_0.Text = "Từ"
        Me._txtnd_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtch_2
        '
        Me._txtch_2.AcceptsReturn = True
        Me._txtch_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtch_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtch_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtch_2.Location = New System.Drawing.Point(320, 432)
        Me._txtch_2.MaxLength = 50
        Me._txtch_2.Name = "_txtch_2"
        Me._txtch_2.Size = New System.Drawing.Size(129, 20)
        Me._txtch_2.TabIndex = 76
        '
        '_txtch_1
        '
        Me._txtch_1.AcceptsReturn = True
        Me._txtch_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtch_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtch_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtch_1.Location = New System.Drawing.Point(192, 432)
        Me._txtch_1.MaxLength = 50
        Me._txtch_1.Name = "_txtch_1"
        Me._txtch_1.Size = New System.Drawing.Size(129, 20)
        Me._txtch_1.TabIndex = 75
        '
        '_txtch_0
        '
        Me._txtch_0.AcceptsReturn = True
        Me._txtch_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtch_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtch_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtch_0.Location = New System.Drawing.Point(32, 432)
        Me._txtch_0.MaxLength = 50
        Me._txtch_0.Name = "_txtch_0"
        Me._txtch_0.Size = New System.Drawing.Size(161, 20)
        Me._txtch_0.TabIndex = 74
        '
        'CboThang
        '
        Me.CboThang.BackColor = System.Drawing.SystemColors.Window
        Me.CboThang.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboThang.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboThang.Location = New System.Drawing.Point(8, 24)
        Me.CboThang.Name = "CboThang"
        Me.CboThang.Size = New System.Drawing.Size(73, 21)
        Me.CboThang.TabIndex = 0
        '
        '_Command1_2
        '
        Me._Command1_2.BackColor = System.Drawing.Color.Silver
        Me._Command1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_2.Image = CType(resources.GetObject("_Command1_2.Image"), System.Drawing.Image)
        Me._Command1_2.Location = New System.Drawing.Point(800, 520)
        Me._Command1_2.Name = "_Command1_2"
        Me._Command1_2.Size = New System.Drawing.Size(81, 25)
        Me._Command1_2.TabIndex = 7
        Me._Command1_2.TabStop = False
        Me._Command1_2.Tag = "&DELETE"
        Me._Command1_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_2.UseVisualStyleBackColor = False
        Me._Command1_2.Visible = False
        '
        '_Command1_0
        '
        Me._Command1_0.BackColor = System.Drawing.Color.Silver
        Me._Command1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_0.Image = CType(resources.GetObject("_Command1_0.Image"), System.Drawing.Image)
        Me._Command1_0.Location = New System.Drawing.Point(696, 520)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(97, 25)
        Me._Command1_0.TabIndex = 2
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&Save"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        '_Command1_1
        '
        Me._Command1_1.BackColor = System.Drawing.Color.Silver
        Me._Command1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_1.Image = CType(resources.GetObject("_Command1_1.Image"), System.Drawing.Image)
        Me._Command1_1.Location = New System.Drawing.Point(888, 520)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(81, 25)
        Me._Command1_1.TabIndex = 1
        Me._Command1_1.TabStop = False
        Me._Command1_1.Tag = "&Return"
        Me._Command1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_1.UseVisualStyleBackColor = False
        Me._Command1_1.Visible = False
        '
        'Lich
        '
        Me.Lich.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Lich.CalendarDimensions = New System.Drawing.Size(2, 1)
        Me.Lich.FirstDayOfWeek = System.Windows.Forms.Day.Sunday
        Me.Lich.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lich.Location = New System.Drawing.Point(160, 632)
        Me.Lich.Name = "Lich"
        Me.Lich.TabIndex = 41
        Me.Lich.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer))
        '
        '_txtnc_32
        '
        Me._txtnc_32.AcceptsReturn = True
        Me._txtnc_32.BackColor = System.Drawing.Color.Silver
        Me._txtnc_32.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtnc_32.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnc_32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnc_32.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._txtnc_32.Location = New System.Drawing.Point(944, 483)
        Me._txtnc_32.MaxLength = 20
        Me._txtnc_32.Name = "_txtnc_32"
        Me._txtnc_32.ReadOnly = True
        Me._txtnc_32.Size = New System.Drawing.Size(33, 13)
        Me._txtnc_32.TabIndex = 141
        Me._txtnc_32.TabStop = False
        Me._txtnc_32.Tag = "Hours"
        Me._txtnc_32.Text = "Giờ"
        Me._txtnc_32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtnd_32
        '
        Me._txtnd_32.AcceptsReturn = True
        Me._txtnd_32.BackColor = System.Drawing.Color.Silver
        Me._txtnd_32.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtnd_32.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtnd_32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtnd_32.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._txtnd_32.Location = New System.Drawing.Point(944, 459)
        Me._txtnd_32.MaxLength = 20
        Me._txtnd_32.Name = "_txtnd_32"
        Me._txtnd_32.ReadOnly = True
        Me._txtnd_32.Size = New System.Drawing.Size(33, 13)
        Me._txtnd_32.TabIndex = 142
        Me._txtnd_32.TabStop = False
        Me._txtnd_32.Tag = "Hours"
        Me._txtnd_32.Text = "Giờ"
        Me._txtnd_32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_Label_36
        '
        Me._Label_36.BackColor = System.Drawing.Color.Transparent
        Me._Label_36.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_36.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_36.ForeColor = System.Drawing.Color.Black
        Me._Label_36.Location = New System.Drawing.Point(88, 24)
        Me._Label_36.Name = "_Label_36"
        Me._Label_36.Size = New System.Drawing.Size(161, 17)
        Me._Label_36.TabIndex = 73
        Me._Label_36.Tag = "Full name"
        Me._Label_36.Text = "Họ và tên"
        Me._Label_36.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_41
        '
        Me._Label_41.BackColor = System.Drawing.Color.Gray
        Me._Label_41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_41.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_41.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_41.ForeColor = System.Drawing.Color.Black
        Me._Label_41.Location = New System.Drawing.Point(448, 40)
        Me._Label_41.Name = "_Label_41"
        Me._Label_41.Size = New System.Drawing.Size(21, 17)
        Me._Label_41.TabIndex = 72
        Me._Label_41.Tag = "Ho."
        Me._Label_41.Text = "Lễ"
        Me._Label_41.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_41.Visible = False
        '
        '_Label_42
        '
        Me._Label_42.BackColor = System.Drawing.Color.Gray
        Me._Label_42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_42.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_42.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_42.ForeColor = System.Drawing.Color.Black
        Me._Label_42.Location = New System.Drawing.Point(464, 40)
        Me._Label_42.Name = "_Label_42"
        Me._Label_42.Size = New System.Drawing.Size(21, 17)
        Me._Label_42.TabIndex = 71
        Me._Label_42.Tag = "Ho."
        Me._Label_42.Text = "Lễ"
        Me._Label_42.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_42.Visible = False
        '
        '_Label_43
        '
        Me._Label_43.BackColor = System.Drawing.Color.Gray
        Me._Label_43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_43.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_43.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_43.ForeColor = System.Drawing.Color.Black
        Me._Label_43.Location = New System.Drawing.Point(480, 40)
        Me._Label_43.Name = "_Label_43"
        Me._Label_43.Size = New System.Drawing.Size(21, 17)
        Me._Label_43.TabIndex = 70
        Me._Label_43.Tag = "Ho."
        Me._Label_43.Text = "Lễ"
        Me._Label_43.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_43.Visible = False
        '
        '_Label_44
        '
        Me._Label_44.BackColor = System.Drawing.Color.Gray
        Me._Label_44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_44.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_44.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_44.ForeColor = System.Drawing.Color.Black
        Me._Label_44.Location = New System.Drawing.Point(496, 40)
        Me._Label_44.Name = "_Label_44"
        Me._Label_44.Size = New System.Drawing.Size(21, 17)
        Me._Label_44.TabIndex = 69
        Me._Label_44.Tag = "Ho."
        Me._Label_44.Text = "Lễ"
        Me._Label_44.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_44.Visible = False
        '
        '_Label_45
        '
        Me._Label_45.BackColor = System.Drawing.Color.Gray
        Me._Label_45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_45.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_45.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_45.ForeColor = System.Drawing.Color.Black
        Me._Label_45.Location = New System.Drawing.Point(512, 40)
        Me._Label_45.Name = "_Label_45"
        Me._Label_45.Size = New System.Drawing.Size(21, 17)
        Me._Label_45.TabIndex = 68
        Me._Label_45.Tag = "Ho."
        Me._Label_45.Text = "Lễ"
        Me._Label_45.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_45.Visible = False
        '
        '_Label_46
        '
        Me._Label_46.BackColor = System.Drawing.Color.Gray
        Me._Label_46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_46.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_46.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_46.ForeColor = System.Drawing.Color.Black
        Me._Label_46.Location = New System.Drawing.Point(528, 40)
        Me._Label_46.Name = "_Label_46"
        Me._Label_46.Size = New System.Drawing.Size(21, 17)
        Me._Label_46.TabIndex = 67
        Me._Label_46.Tag = "Ho."
        Me._Label_46.Text = "Lễ"
        Me._Label_46.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_46.Visible = False
        '
        '_Label_47
        '
        Me._Label_47.BackColor = System.Drawing.Color.Gray
        Me._Label_47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_47.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_47.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_47.ForeColor = System.Drawing.Color.Black
        Me._Label_47.Location = New System.Drawing.Point(544, 40)
        Me._Label_47.Name = "_Label_47"
        Me._Label_47.Size = New System.Drawing.Size(21, 17)
        Me._Label_47.TabIndex = 66
        Me._Label_47.Tag = "Ho."
        Me._Label_47.Text = "Lễ"
        Me._Label_47.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_47.Visible = False
        '
        '_Label_48
        '
        Me._Label_48.BackColor = System.Drawing.Color.Gray
        Me._Label_48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_48.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_48.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_48.ForeColor = System.Drawing.Color.Black
        Me._Label_48.Location = New System.Drawing.Point(560, 40)
        Me._Label_48.Name = "_Label_48"
        Me._Label_48.Size = New System.Drawing.Size(21, 17)
        Me._Label_48.TabIndex = 65
        Me._Label_48.Tag = "Ho."
        Me._Label_48.Text = "Lễ"
        Me._Label_48.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_48.Visible = False
        '
        '_Label_49
        '
        Me._Label_49.BackColor = System.Drawing.Color.Gray
        Me._Label_49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_49.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_49.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_49.ForeColor = System.Drawing.Color.Black
        Me._Label_49.Location = New System.Drawing.Point(576, 40)
        Me._Label_49.Name = "_Label_49"
        Me._Label_49.Size = New System.Drawing.Size(21, 17)
        Me._Label_49.TabIndex = 64
        Me._Label_49.Tag = "Ho."
        Me._Label_49.Text = "Lễ"
        Me._Label_49.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_49.Visible = False
        '
        '_Label_50
        '
        Me._Label_50.BackColor = System.Drawing.Color.Gray
        Me._Label_50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_50.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_50.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_50.ForeColor = System.Drawing.Color.Black
        Me._Label_50.Location = New System.Drawing.Point(592, 40)
        Me._Label_50.Name = "_Label_50"
        Me._Label_50.Size = New System.Drawing.Size(21, 17)
        Me._Label_50.TabIndex = 63
        Me._Label_50.Tag = "Ho."
        Me._Label_50.Text = "Lễ"
        Me._Label_50.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_50.Visible = False
        '
        '_Label_51
        '
        Me._Label_51.BackColor = System.Drawing.Color.Gray
        Me._Label_51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_51.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_51.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_51.ForeColor = System.Drawing.Color.Black
        Me._Label_51.Location = New System.Drawing.Point(608, 40)
        Me._Label_51.Name = "_Label_51"
        Me._Label_51.Size = New System.Drawing.Size(21, 17)
        Me._Label_51.TabIndex = 62
        Me._Label_51.Tag = "Ho."
        Me._Label_51.Text = "Lễ"
        Me._Label_51.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_51.Visible = False
        '
        '_Label_52
        '
        Me._Label_52.BackColor = System.Drawing.Color.Gray
        Me._Label_52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_52.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_52.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_52.ForeColor = System.Drawing.Color.Black
        Me._Label_52.Location = New System.Drawing.Point(624, 40)
        Me._Label_52.Name = "_Label_52"
        Me._Label_52.Size = New System.Drawing.Size(21, 17)
        Me._Label_52.TabIndex = 61
        Me._Label_52.Tag = "Ho."
        Me._Label_52.Text = "Lễ"
        Me._Label_52.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_52.Visible = False
        '
        '_Label_53
        '
        Me._Label_53.BackColor = System.Drawing.Color.Gray
        Me._Label_53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_53.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_53.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_53.ForeColor = System.Drawing.Color.Black
        Me._Label_53.Location = New System.Drawing.Point(640, 40)
        Me._Label_53.Name = "_Label_53"
        Me._Label_53.Size = New System.Drawing.Size(21, 17)
        Me._Label_53.TabIndex = 60
        Me._Label_53.Tag = "Ho."
        Me._Label_53.Text = "Lễ"
        Me._Label_53.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_53.Visible = False
        '
        '_Label_54
        '
        Me._Label_54.BackColor = System.Drawing.Color.Gray
        Me._Label_54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_54.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_54.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_54.ForeColor = System.Drawing.Color.Black
        Me._Label_54.Location = New System.Drawing.Point(656, 40)
        Me._Label_54.Name = "_Label_54"
        Me._Label_54.Size = New System.Drawing.Size(21, 17)
        Me._Label_54.TabIndex = 59
        Me._Label_54.Tag = "Ho."
        Me._Label_54.Text = "Lễ"
        Me._Label_54.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_54.Visible = False
        '
        '_Label_55
        '
        Me._Label_55.BackColor = System.Drawing.Color.Gray
        Me._Label_55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_55.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_55.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_55.ForeColor = System.Drawing.Color.Black
        Me._Label_55.Location = New System.Drawing.Point(672, 40)
        Me._Label_55.Name = "_Label_55"
        Me._Label_55.Size = New System.Drawing.Size(21, 17)
        Me._Label_55.TabIndex = 58
        Me._Label_55.Tag = "Ho."
        Me._Label_55.Text = "Lễ"
        Me._Label_55.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_55.Visible = False
        '
        '_Label_56
        '
        Me._Label_56.BackColor = System.Drawing.Color.Gray
        Me._Label_56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_56.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_56.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_56.ForeColor = System.Drawing.Color.Black
        Me._Label_56.Location = New System.Drawing.Point(688, 40)
        Me._Label_56.Name = "_Label_56"
        Me._Label_56.Size = New System.Drawing.Size(21, 17)
        Me._Label_56.TabIndex = 57
        Me._Label_56.Tag = "Ho."
        Me._Label_56.Text = "Lễ"
        Me._Label_56.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_56.Visible = False
        '
        '_Label_57
        '
        Me._Label_57.BackColor = System.Drawing.Color.Gray
        Me._Label_57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_57.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_57.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_57.ForeColor = System.Drawing.Color.Black
        Me._Label_57.Location = New System.Drawing.Point(704, 40)
        Me._Label_57.Name = "_Label_57"
        Me._Label_57.Size = New System.Drawing.Size(21, 17)
        Me._Label_57.TabIndex = 56
        Me._Label_57.Tag = "Ho."
        Me._Label_57.Text = "Lễ"
        Me._Label_57.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_57.Visible = False
        '
        '_Label_58
        '
        Me._Label_58.BackColor = System.Drawing.Color.Gray
        Me._Label_58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_58.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_58.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_58.ForeColor = System.Drawing.Color.Black
        Me._Label_58.Location = New System.Drawing.Point(720, 40)
        Me._Label_58.Name = "_Label_58"
        Me._Label_58.Size = New System.Drawing.Size(21, 17)
        Me._Label_58.TabIndex = 55
        Me._Label_58.Tag = "Ho."
        Me._Label_58.Text = "Lễ"
        Me._Label_58.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_58.Visible = False
        '
        '_Label_59
        '
        Me._Label_59.BackColor = System.Drawing.Color.Gray
        Me._Label_59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_59.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_59.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_59.ForeColor = System.Drawing.Color.Black
        Me._Label_59.Location = New System.Drawing.Point(736, 40)
        Me._Label_59.Name = "_Label_59"
        Me._Label_59.Size = New System.Drawing.Size(21, 17)
        Me._Label_59.TabIndex = 54
        Me._Label_59.Tag = "Ho."
        Me._Label_59.Text = "Lễ"
        Me._Label_59.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_59.Visible = False
        '
        '_Label_60
        '
        Me._Label_60.BackColor = System.Drawing.Color.Gray
        Me._Label_60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_60.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_60.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_60.ForeColor = System.Drawing.Color.Black
        Me._Label_60.Location = New System.Drawing.Point(752, 40)
        Me._Label_60.Name = "_Label_60"
        Me._Label_60.Size = New System.Drawing.Size(21, 17)
        Me._Label_60.TabIndex = 53
        Me._Label_60.Tag = "Ho."
        Me._Label_60.Text = "Lễ"
        Me._Label_60.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_60.Visible = False
        '
        '_Label_61
        '
        Me._Label_61.BackColor = System.Drawing.Color.Gray
        Me._Label_61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_61.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_61.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_61.ForeColor = System.Drawing.Color.Black
        Me._Label_61.Location = New System.Drawing.Point(768, 40)
        Me._Label_61.Name = "_Label_61"
        Me._Label_61.Size = New System.Drawing.Size(21, 17)
        Me._Label_61.TabIndex = 52
        Me._Label_61.Tag = "Ho."
        Me._Label_61.Text = "Lễ"
        Me._Label_61.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_61.Visible = False
        '
        '_Label_62
        '
        Me._Label_62.BackColor = System.Drawing.Color.Gray
        Me._Label_62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_62.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_62.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_62.ForeColor = System.Drawing.Color.Black
        Me._Label_62.Location = New System.Drawing.Point(784, 40)
        Me._Label_62.Name = "_Label_62"
        Me._Label_62.Size = New System.Drawing.Size(21, 17)
        Me._Label_62.TabIndex = 51
        Me._Label_62.Tag = "Ho."
        Me._Label_62.Text = "Lễ"
        Me._Label_62.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_62.Visible = False
        '
        '_Label_63
        '
        Me._Label_63.BackColor = System.Drawing.Color.Gray
        Me._Label_63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_63.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_63.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_63.ForeColor = System.Drawing.Color.Black
        Me._Label_63.Location = New System.Drawing.Point(800, 40)
        Me._Label_63.Name = "_Label_63"
        Me._Label_63.Size = New System.Drawing.Size(21, 17)
        Me._Label_63.TabIndex = 50
        Me._Label_63.Tag = "Ho."
        Me._Label_63.Text = "Lễ"
        Me._Label_63.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_63.Visible = False
        '
        '_Label_64
        '
        Me._Label_64.BackColor = System.Drawing.Color.Gray
        Me._Label_64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_64.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_64.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_64.ForeColor = System.Drawing.Color.Black
        Me._Label_64.Location = New System.Drawing.Point(816, 40)
        Me._Label_64.Name = "_Label_64"
        Me._Label_64.Size = New System.Drawing.Size(21, 17)
        Me._Label_64.TabIndex = 49
        Me._Label_64.Tag = "Ho."
        Me._Label_64.Text = "Lễ"
        Me._Label_64.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_64.Visible = False
        '
        '_Label_65
        '
        Me._Label_65.BackColor = System.Drawing.Color.Gray
        Me._Label_65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_65.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_65.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_65.ForeColor = System.Drawing.Color.Black
        Me._Label_65.Location = New System.Drawing.Point(832, 40)
        Me._Label_65.Name = "_Label_65"
        Me._Label_65.Size = New System.Drawing.Size(21, 17)
        Me._Label_65.TabIndex = 48
        Me._Label_65.Tag = "Ho."
        Me._Label_65.Text = "Lễ"
        Me._Label_65.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_65.Visible = False
        '
        '_Label_66
        '
        Me._Label_66.BackColor = System.Drawing.Color.Gray
        Me._Label_66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_66.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_66.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_66.ForeColor = System.Drawing.Color.Black
        Me._Label_66.Location = New System.Drawing.Point(848, 40)
        Me._Label_66.Name = "_Label_66"
        Me._Label_66.Size = New System.Drawing.Size(21, 17)
        Me._Label_66.TabIndex = 47
        Me._Label_66.Tag = "Ho."
        Me._Label_66.Text = "Lễ"
        Me._Label_66.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_66.Visible = False
        '
        '_Label_67
        '
        Me._Label_67.BackColor = System.Drawing.Color.Gray
        Me._Label_67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_67.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_67.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_67.ForeColor = System.Drawing.Color.Black
        Me._Label_67.Location = New System.Drawing.Point(864, 40)
        Me._Label_67.Name = "_Label_67"
        Me._Label_67.Size = New System.Drawing.Size(21, 17)
        Me._Label_67.TabIndex = 46
        Me._Label_67.Tag = "Ho."
        Me._Label_67.Text = "Lễ"
        Me._Label_67.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_67.Visible = False
        '
        '_Label_68
        '
        Me._Label_68.BackColor = System.Drawing.Color.Gray
        Me._Label_68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_68.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_68.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_68.ForeColor = System.Drawing.Color.Black
        Me._Label_68.Location = New System.Drawing.Point(880, 40)
        Me._Label_68.Name = "_Label_68"
        Me._Label_68.Size = New System.Drawing.Size(21, 17)
        Me._Label_68.TabIndex = 45
        Me._Label_68.Tag = "Ho."
        Me._Label_68.Text = "Lễ"
        Me._Label_68.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_68.Visible = False
        '
        '_Label_69
        '
        Me._Label_69.BackColor = System.Drawing.Color.Gray
        Me._Label_69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_69.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_69.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_69.ForeColor = System.Drawing.Color.Black
        Me._Label_69.Location = New System.Drawing.Point(896, 40)
        Me._Label_69.Name = "_Label_69"
        Me._Label_69.Size = New System.Drawing.Size(25, 17)
        Me._Label_69.TabIndex = 44
        Me._Label_69.Tag = "Ho."
        Me._Label_69.Text = "Lễ"
        Me._Label_69.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_69.Visible = False
        '
        '_Label_70
        '
        Me._Label_70.BackColor = System.Drawing.Color.Gray
        Me._Label_70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_70.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_70.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_70.ForeColor = System.Drawing.Color.Black
        Me._Label_70.Location = New System.Drawing.Point(920, 40)
        Me._Label_70.Name = "_Label_70"
        Me._Label_70.Size = New System.Drawing.Size(21, 17)
        Me._Label_70.TabIndex = 43
        Me._Label_70.Tag = "Ho."
        Me._Label_70.Text = "Lễ"
        Me._Label_70.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_70.Visible = False
        '
        '_Label_71
        '
        Me._Label_71.BackColor = System.Drawing.Color.Gray
        Me._Label_71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_71.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_71.Font = New System.Drawing.Font("Arial", 7.0!)
        Me._Label_71.ForeColor = System.Drawing.Color.Black
        Me._Label_71.Location = New System.Drawing.Point(938, 40)
        Me._Label_71.Name = "_Label_71"
        Me._Label_71.Size = New System.Drawing.Size(21, 17)
        Me._Label_71.TabIndex = 42
        Me._Label_71.Tag = "Ho."
        Me._Label_71.Text = "Lễ"
        Me._Label_71.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_71.Visible = False
        '
        '_Label_35
        '
        Me._Label_35.BackColor = System.Drawing.Color.Gray
        Me._Label_35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_35.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_35.ForeColor = System.Drawing.Color.Black
        Me._Label_35.Location = New System.Drawing.Point(192, 56)
        Me._Label_35.Name = "_Label_35"
        Me._Label_35.Size = New System.Drawing.Size(129, 17)
        Me._Label_35.TabIndex = 40
        Me._Label_35.Tag = "Component"
        Me._Label_35.Text = "Bộ phận"
        Me._Label_35.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_31
        '
        Me._Label_31.BackColor = System.Drawing.Color.Gray
        Me._Label_31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_31.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_31.ForeColor = System.Drawing.Color.Black
        Me._Label_31.Location = New System.Drawing.Point(938, 56)
        Me._Label_31.Name = "_Label_31"
        Me._Label_31.Size = New System.Drawing.Size(21, 17)
        Me._Label_31.TabIndex = 39
        Me._Label_31.Tag = ""
        Me._Label_31.Text = "31"
        Me._Label_31.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_30
        '
        Me._Label_30.BackColor = System.Drawing.Color.Gray
        Me._Label_30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_30.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_30.ForeColor = System.Drawing.Color.Black
        Me._Label_30.Location = New System.Drawing.Point(920, 56)
        Me._Label_30.Name = "_Label_30"
        Me._Label_30.Size = New System.Drawing.Size(21, 17)
        Me._Label_30.TabIndex = 38
        Me._Label_30.Tag = ""
        Me._Label_30.Text = "30"
        Me._Label_30.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_29
        '
        Me._Label_29.BackColor = System.Drawing.Color.Gray
        Me._Label_29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_29.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_29.ForeColor = System.Drawing.Color.Black
        Me._Label_29.Location = New System.Drawing.Point(900, 56)
        Me._Label_29.Name = "_Label_29"
        Me._Label_29.Size = New System.Drawing.Size(21, 17)
        Me._Label_29.TabIndex = 37
        Me._Label_29.Tag = ""
        Me._Label_29.Text = "29"
        Me._Label_29.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_28
        '
        Me._Label_28.BackColor = System.Drawing.Color.Gray
        Me._Label_28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_28.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_28.ForeColor = System.Drawing.Color.Black
        Me._Label_28.Location = New System.Drawing.Point(884, 56)
        Me._Label_28.Name = "_Label_28"
        Me._Label_28.Size = New System.Drawing.Size(21, 17)
        Me._Label_28.TabIndex = 36
        Me._Label_28.Tag = ""
        Me._Label_28.Text = "28"
        Me._Label_28.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_27
        '
        Me._Label_27.BackColor = System.Drawing.Color.Gray
        Me._Label_27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_27.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_27.ForeColor = System.Drawing.Color.Black
        Me._Label_27.Location = New System.Drawing.Point(868, 56)
        Me._Label_27.Name = "_Label_27"
        Me._Label_27.Size = New System.Drawing.Size(21, 17)
        Me._Label_27.TabIndex = 35
        Me._Label_27.Tag = ""
        Me._Label_27.Text = "27"
        Me._Label_27.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_26
        '
        Me._Label_26.BackColor = System.Drawing.Color.Gray
        Me._Label_26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_26.ForeColor = System.Drawing.Color.Black
        Me._Label_26.Location = New System.Drawing.Point(852, 56)
        Me._Label_26.Name = "_Label_26"
        Me._Label_26.Size = New System.Drawing.Size(21, 17)
        Me._Label_26.TabIndex = 34
        Me._Label_26.Tag = ""
        Me._Label_26.Text = "26"
        Me._Label_26.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_25
        '
        Me._Label_25.BackColor = System.Drawing.Color.Gray
        Me._Label_25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_25.ForeColor = System.Drawing.Color.Black
        Me._Label_25.Location = New System.Drawing.Point(836, 56)
        Me._Label_25.Name = "_Label_25"
        Me._Label_25.Size = New System.Drawing.Size(21, 17)
        Me._Label_25.TabIndex = 33
        Me._Label_25.Tag = ""
        Me._Label_25.Text = "25"
        Me._Label_25.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_24
        '
        Me._Label_24.BackColor = System.Drawing.Color.Gray
        Me._Label_24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_24.ForeColor = System.Drawing.Color.Black
        Me._Label_24.Location = New System.Drawing.Point(820, 56)
        Me._Label_24.Name = "_Label_24"
        Me._Label_24.Size = New System.Drawing.Size(21, 17)
        Me._Label_24.TabIndex = 32
        Me._Label_24.Tag = ""
        Me._Label_24.Text = "24"
        Me._Label_24.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_23
        '
        Me._Label_23.BackColor = System.Drawing.Color.Gray
        Me._Label_23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_23.ForeColor = System.Drawing.Color.Black
        Me._Label_23.Location = New System.Drawing.Point(804, 56)
        Me._Label_23.Name = "_Label_23"
        Me._Label_23.Size = New System.Drawing.Size(21, 17)
        Me._Label_23.TabIndex = 31
        Me._Label_23.Tag = ""
        Me._Label_23.Text = "23"
        Me._Label_23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_22
        '
        Me._Label_22.BackColor = System.Drawing.Color.Gray
        Me._Label_22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_22.ForeColor = System.Drawing.Color.Black
        Me._Label_22.Location = New System.Drawing.Point(788, 56)
        Me._Label_22.Name = "_Label_22"
        Me._Label_22.Size = New System.Drawing.Size(21, 17)
        Me._Label_22.TabIndex = 30
        Me._Label_22.Tag = ""
        Me._Label_22.Text = "22"
        Me._Label_22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_21
        '
        Me._Label_21.BackColor = System.Drawing.Color.Gray
        Me._Label_21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_21.ForeColor = System.Drawing.Color.Black
        Me._Label_21.Location = New System.Drawing.Point(772, 56)
        Me._Label_21.Name = "_Label_21"
        Me._Label_21.Size = New System.Drawing.Size(21, 17)
        Me._Label_21.TabIndex = 29
        Me._Label_21.Tag = ""
        Me._Label_21.Text = "21"
        Me._Label_21.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_20
        '
        Me._Label_20.BackColor = System.Drawing.Color.Gray
        Me._Label_20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_20.ForeColor = System.Drawing.Color.Black
        Me._Label_20.Location = New System.Drawing.Point(756, 56)
        Me._Label_20.Name = "_Label_20"
        Me._Label_20.Size = New System.Drawing.Size(21, 17)
        Me._Label_20.TabIndex = 28
        Me._Label_20.Tag = ""
        Me._Label_20.Text = "20"
        Me._Label_20.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_19
        '
        Me._Label_19.BackColor = System.Drawing.Color.Gray
        Me._Label_19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_19.ForeColor = System.Drawing.Color.Black
        Me._Label_19.Location = New System.Drawing.Point(740, 56)
        Me._Label_19.Name = "_Label_19"
        Me._Label_19.Size = New System.Drawing.Size(21, 17)
        Me._Label_19.TabIndex = 27
        Me._Label_19.Tag = ""
        Me._Label_19.Text = "19"
        Me._Label_19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_18
        '
        Me._Label_18.BackColor = System.Drawing.Color.Gray
        Me._Label_18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_18.ForeColor = System.Drawing.Color.Black
        Me._Label_18.Location = New System.Drawing.Point(724, 56)
        Me._Label_18.Name = "_Label_18"
        Me._Label_18.Size = New System.Drawing.Size(21, 17)
        Me._Label_18.TabIndex = 26
        Me._Label_18.Tag = ""
        Me._Label_18.Text = "18"
        Me._Label_18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.Color.Gray
        Me._Label_17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.ForeColor = System.Drawing.Color.Black
        Me._Label_17.Location = New System.Drawing.Point(708, 56)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(21, 17)
        Me._Label_17.TabIndex = 25
        Me._Label_17.Tag = ""
        Me._Label_17.Text = "17"
        Me._Label_17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_16
        '
        Me._Label_16.BackColor = System.Drawing.Color.Gray
        Me._Label_16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_16.ForeColor = System.Drawing.Color.Black
        Me._Label_16.Location = New System.Drawing.Point(692, 56)
        Me._Label_16.Name = "_Label_16"
        Me._Label_16.Size = New System.Drawing.Size(21, 17)
        Me._Label_16.TabIndex = 24
        Me._Label_16.Tag = ""
        Me._Label_16.Text = "16"
        Me._Label_16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_15
        '
        Me._Label_15.BackColor = System.Drawing.Color.Gray
        Me._Label_15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_15.ForeColor = System.Drawing.Color.Black
        Me._Label_15.Location = New System.Drawing.Point(676, 56)
        Me._Label_15.Name = "_Label_15"
        Me._Label_15.Size = New System.Drawing.Size(21, 17)
        Me._Label_15.TabIndex = 23
        Me._Label_15.Tag = ""
        Me._Label_15.Text = "15"
        Me._Label_15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.Color.Gray
        Me._Label_14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.Color.Black
        Me._Label_14.Location = New System.Drawing.Point(660, 56)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(21, 17)
        Me._Label_14.TabIndex = 22
        Me._Label_14.Tag = ""
        Me._Label_14.Text = "14"
        Me._Label_14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.Gray
        Me._Label_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.Color.Black
        Me._Label_13.Location = New System.Drawing.Point(644, 56)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(21, 17)
        Me._Label_13.TabIndex = 21
        Me._Label_13.Tag = ""
        Me._Label_13.Text = "13"
        Me._Label_13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_12
        '
        Me._Label_12.BackColor = System.Drawing.Color.Gray
        Me._Label_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.Color.Black
        Me._Label_12.Location = New System.Drawing.Point(628, 56)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.Size = New System.Drawing.Size(21, 17)
        Me._Label_12.TabIndex = 20
        Me._Label_12.Tag = ""
        Me._Label_12.Text = "12"
        Me._Label_12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.Gray
        Me._Label_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.Color.Black
        Me._Label_11.Location = New System.Drawing.Point(612, 56)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(21, 17)
        Me._Label_11.TabIndex = 19
        Me._Label_11.Tag = ""
        Me._Label_11.Text = "11"
        Me._Label_11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.Gray
        Me._Label_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.Color.Black
        Me._Label_10.Location = New System.Drawing.Point(596, 56)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(21, 17)
        Me._Label_10.TabIndex = 18
        Me._Label_10.Tag = ""
        Me._Label_10.Text = "10"
        Me._Label_10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_9
        '
        Me._Label_9.BackColor = System.Drawing.Color.Gray
        Me._Label_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.Color.Black
        Me._Label_9.Location = New System.Drawing.Point(580, 56)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.Size = New System.Drawing.Size(21, 17)
        Me._Label_9.TabIndex = 17
        Me._Label_9.Tag = ""
        Me._Label_9.Text = "9"
        Me._Label_9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.Gray
        Me._Label_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.Color.Black
        Me._Label_8.Location = New System.Drawing.Point(564, 56)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(21, 17)
        Me._Label_8.TabIndex = 16
        Me._Label_8.Tag = ""
        Me._Label_8.Text = "8"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.Gray
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(548, 56)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(21, 17)
        Me._Label_7.TabIndex = 15
        Me._Label_7.Tag = ""
        Me._Label_7.Text = "7"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.Gray
        Me._Label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.Color.Black
        Me._Label_6.Location = New System.Drawing.Point(532, 56)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(21, 17)
        Me._Label_6.TabIndex = 14
        Me._Label_6.Tag = ""
        Me._Label_6.Text = "6"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.Gray
        Me._Label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.Color.Black
        Me._Label_5.Location = New System.Drawing.Point(516, 56)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(21, 17)
        Me._Label_5.TabIndex = 13
        Me._Label_5.Tag = ""
        Me._Label_5.Text = "5"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.Gray
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(500, 56)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(21, 17)
        Me._Label_4.TabIndex = 12
        Me._Label_4.Tag = ""
        Me._Label_4.Text = "4"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.Gray
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.Black
        Me._Label_3.Location = New System.Drawing.Point(484, 56)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(21, 17)
        Me._Label_3.TabIndex = 11
        Me._Label_3.Tag = ""
        Me._Label_3.Text = "3"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.Gray
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.Black
        Me._Label_2.Location = New System.Drawing.Point(468, 56)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(21, 17)
        Me._Label_2.TabIndex = 10
        Me._Label_2.Tag = ""
        Me._Label_2.Text = "2"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Gray
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(448, 56)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(21, 17)
        Me._Label_1.TabIndex = 9
        Me._Label_1.Tag = ""
        Me._Label_1.Text = "1"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_34
        '
        Me._Label_34.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_34.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_34.ForeColor = System.Drawing.Color.Black
        Me._Label_34.Location = New System.Drawing.Point(304, 8)
        Me._Label_34.Name = "_Label_34"
        Me._Label_34.Size = New System.Drawing.Size(353, 20)
        Me._Label_34.TabIndex = 8
        Me._Label_34.Tag = "List of Attendance Employees Hourly Overtime"
        Me._Label_34.Text = "Danh sách chấm công nhân viên tăng ca theo giờ"
        Me._Label_34.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_32
        '
        Me._Label_32.BackColor = System.Drawing.Color.Gray
        Me._Label_32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_32.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_32.ForeColor = System.Drawing.Color.Black
        Me._Label_32.Location = New System.Drawing.Point(32, 56)
        Me._Label_32.Name = "_Label_32"
        Me._Label_32.Size = New System.Drawing.Size(161, 17)
        Me._Label_32.TabIndex = 6
        Me._Label_32.Tag = "Full name"
        Me._Label_32.Text = "Họ và Tên"
        Me._Label_32.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_33
        '
        Me._Label_33.BackColor = System.Drawing.Color.Gray
        Me._Label_33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_33.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_33.ForeColor = System.Drawing.Color.Black
        Me._Label_33.Location = New System.Drawing.Point(320, 56)
        Me._Label_33.Name = "_Label_33"
        Me._Label_33.Size = New System.Drawing.Size(129, 17)
        Me._Label_33.TabIndex = 5
        Me._Label_33.Tag = "Position"
        Me._Label_33.Text = "Chức vụ"
        Me._Label_33.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Gray
        Me._Label_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.Color.Black
        Me._Label_0.Location = New System.Drawing.Point(8, 56)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(25, 17)
        Me._Label_0.TabIndex = 4
        Me._Label_0.Tag = "No."
        Me._Label_0.Text = "STT"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GrdNhanvien
        '
        Me.GrdNhanvien.AllowColumnResize = True
        Me.GrdNhanvien.AllowMultiselect = False
        Me.GrdNhanvien.AlternateBackground = System.Drawing.Color.DarkGreen
        Me.GrdNhanvien.AlternatingColors = False
        Me.GrdNhanvien.AutoHeight = True
        Me.GrdNhanvien.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdNhanvien.BackgroundStretchToFit = True
        Me.GrdNhanvien.Col = 0
        Me.GrdNhanvien.Cols = 0
        Me.GrdNhanvien.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me.GrdNhanvien.FullRowSelect = True
        Me.GrdNhanvien.GridColor = System.Drawing.Color.LightGray
        Me.GrdNhanvien.GridLines = ListViewEx.GLGridLines.gridBoth
        Me.GrdNhanvien.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me.GrdNhanvien.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me.GrdNhanvien.HeaderHeight = 22
        Me.GrdNhanvien.HeaderVisible = True
        Me.GrdNhanvien.HeaderWordWrap = False
        Me.GrdNhanvien.HotColumnTracking = False
        Me.GrdNhanvien.HotItemTracking = False
        Me.GrdNhanvien.HotTrackingColor = System.Drawing.Color.LightGray
        Me.GrdNhanvien.HoverEvents = False
        Me.GrdNhanvien.HoverTime = 1
        Me.GrdNhanvien.ImageList = Nothing
        Me.GrdNhanvien.ItemHeight = 18
        Me.GrdNhanvien.ItemWordWrap = False
        Me.GrdNhanvien.Location = New System.Drawing.Point(8, 72)
        Me.GrdNhanvien.Name = "GrdNhanvien"
        Me.GrdNhanvien.Row = 0
        Me.GrdNhanvien.Rows = 0
        Me.GrdNhanvien.Selectable = True
        Me.GrdNhanvien.SelectedTextColor = System.Drawing.Color.White
        Me.GrdNhanvien.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.GrdNhanvien.ShowBorder = True
        Me.GrdNhanvien.ShowFocusRect = False
        Me.GrdNhanvien.Size = New System.Drawing.Size(960, 361)
        Me.GrdNhanvien.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdNhanvien.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdNhanvien.TabIndex = 10
        '
        '_txtn_32
        '
        Me._txtn_32.AcceptsReturn = True
        Me._txtn_32.BackColor = System.Drawing.Color.Silver
        Me._txtn_32.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtn_32.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtn_32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtn_32.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._txtn_32.Location = New System.Drawing.Point(944, 435)
        Me._txtn_32.MaxLength = 20
        Me._txtn_32.Name = "_txtn_32"
        Me._txtn_32.ReadOnly = True
        Me._txtn_32.Size = New System.Drawing.Size(33, 13)
        Me._txtn_32.TabIndex = 182
        Me._txtn_32.TabStop = False
        Me._txtn_32.Tag = "Hours"
        Me._txtn_32.Text = "Giờ"
        Me._txtn_32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmChamconggio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(977, 553)
        Me.Controls.Add(Me._txtn_32)
        Me.Controls.Add(Me._Label_71)
        Me.Controls.Add(Me.GrdNhanvien)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._txtn_31)
        Me.Controls.Add(Me._txtn_30)
        Me.Controls.Add(Me._txtn_29)
        Me.Controls.Add(Me._txtn_28)
        Me.Controls.Add(Me._txtn_27)
        Me.Controls.Add(Me._txtn_26)
        Me.Controls.Add(Me._txtn_25)
        Me.Controls.Add(Me._txtn_24)
        Me.Controls.Add(Me._txtn_23)
        Me.Controls.Add(Me._txtn_22)
        Me.Controls.Add(Me._txtn_21)
        Me.Controls.Add(Me._txtn_20)
        Me.Controls.Add(Me._txtn_19)
        Me.Controls.Add(Me._txtn_18)
        Me.Controls.Add(Me._txtn_17)
        Me.Controls.Add(Me._txtn_16)
        Me.Controls.Add(Me._txtn_15)
        Me.Controls.Add(Me._txtn_14)
        Me.Controls.Add(Me._txtn_13)
        Me.Controls.Add(Me._txtn_12)
        Me.Controls.Add(Me._txtn_11)
        Me.Controls.Add(Me._txtn_10)
        Me.Controls.Add(Me._txtn_9)
        Me.Controls.Add(Me._txtn_8)
        Me.Controls.Add(Me._txtn_7)
        Me.Controls.Add(Me._txtn_6)
        Me.Controls.Add(Me._txtn_5)
        Me.Controls.Add(Me._txtn_4)
        Me.Controls.Add(Me._txtn_3)
        Me.Controls.Add(Me._txtn_2)
        Me.Controls.Add(Me._txtn_1)
        Me.Controls.Add(Me._txtnc_31)
        Me.Controls.Add(Me._txtnc_30)
        Me.Controls.Add(Me._txtnc_29)
        Me.Controls.Add(Me._txtnc_28)
        Me.Controls.Add(Me._txtnc_27)
        Me.Controls.Add(Me._txtnc_26)
        Me.Controls.Add(Me._txtnc_25)
        Me.Controls.Add(Me._txtnc_24)
        Me.Controls.Add(Me._txtnc_23)
        Me.Controls.Add(Me._txtnc_22)
        Me.Controls.Add(Me._txtnc_21)
        Me.Controls.Add(Me._txtnc_20)
        Me.Controls.Add(Me._txtnc_19)
        Me.Controls.Add(Me._txtnc_18)
        Me.Controls.Add(Me._txtnc_17)
        Me.Controls.Add(Me._txtnc_16)
        Me.Controls.Add(Me._txtnc_15)
        Me.Controls.Add(Me._txtnc_14)
        Me.Controls.Add(Me._txtnc_13)
        Me.Controls.Add(Me._txtnc_12)
        Me.Controls.Add(Me._txtnc_11)
        Me.Controls.Add(Me._txtnc_10)
        Me.Controls.Add(Me._txtnc_9)
        Me.Controls.Add(Me._txtnc_8)
        Me.Controls.Add(Me._txtnc_7)
        Me.Controls.Add(Me._txtnc_6)
        Me.Controls.Add(Me._txtnc_5)
        Me.Controls.Add(Me._txtnc_4)
        Me.Controls.Add(Me._txtnc_3)
        Me.Controls.Add(Me._txtnc_2)
        Me.Controls.Add(Me._txtnc_1)
        Me.Controls.Add(Me._txtnc_0)
        Me.Controls.Add(Me._txtnd_31)
        Me.Controls.Add(Me._txtnd_30)
        Me.Controls.Add(Me._txtnd_29)
        Me.Controls.Add(Me._txtnd_28)
        Me.Controls.Add(Me._txtnd_27)
        Me.Controls.Add(Me._txtnd_26)
        Me.Controls.Add(Me._txtnd_25)
        Me.Controls.Add(Me._txtnd_24)
        Me.Controls.Add(Me._txtnd_23)
        Me.Controls.Add(Me._txtnd_22)
        Me.Controls.Add(Me._txtnd_21)
        Me.Controls.Add(Me._txtnd_20)
        Me.Controls.Add(Me._txtnd_19)
        Me.Controls.Add(Me._txtnd_18)
        Me.Controls.Add(Me._txtnd_17)
        Me.Controls.Add(Me._txtnd_16)
        Me.Controls.Add(Me._txtnd_15)
        Me.Controls.Add(Me._txtnd_14)
        Me.Controls.Add(Me._txtnd_13)
        Me.Controls.Add(Me._txtnd_12)
        Me.Controls.Add(Me._txtnd_11)
        Me.Controls.Add(Me._txtnd_10)
        Me.Controls.Add(Me._txtnd_9)
        Me.Controls.Add(Me._txtnd_8)
        Me.Controls.Add(Me._txtnd_7)
        Me.Controls.Add(Me._txtnd_6)
        Me.Controls.Add(Me._txtnd_5)
        Me.Controls.Add(Me._txtnd_4)
        Me.Controls.Add(Me._txtnd_3)
        Me.Controls.Add(Me._txtnd_2)
        Me.Controls.Add(Me._txtnd_1)
        Me.Controls.Add(Me._txtnd_0)
        Me.Controls.Add(Me._txtch_2)
        Me.Controls.Add(Me._txtch_1)
        Me.Controls.Add(Me._txtch_0)
        Me.Controls.Add(Me.CboThang)
        Me.Controls.Add(Me._Command1_2)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me.Lich)
        Me.Controls.Add(Me._txtnc_32)
        Me.Controls.Add(Me._txtnd_32)
        Me.Controls.Add(Me._Label_36)
        Me.Controls.Add(Me._Label_41)
        Me.Controls.Add(Me._Label_42)
        Me.Controls.Add(Me._Label_43)
        Me.Controls.Add(Me._Label_44)
        Me.Controls.Add(Me._Label_45)
        Me.Controls.Add(Me._Label_46)
        Me.Controls.Add(Me._Label_47)
        Me.Controls.Add(Me._Label_48)
        Me.Controls.Add(Me._Label_49)
        Me.Controls.Add(Me._Label_50)
        Me.Controls.Add(Me._Label_51)
        Me.Controls.Add(Me._Label_52)
        Me.Controls.Add(Me._Label_53)
        Me.Controls.Add(Me._Label_54)
        Me.Controls.Add(Me._Label_55)
        Me.Controls.Add(Me._Label_56)
        Me.Controls.Add(Me._Label_57)
        Me.Controls.Add(Me._Label_58)
        Me.Controls.Add(Me._Label_59)
        Me.Controls.Add(Me._Label_60)
        Me.Controls.Add(Me._Label_61)
        Me.Controls.Add(Me._Label_62)
        Me.Controls.Add(Me._Label_63)
        Me.Controls.Add(Me._Label_64)
        Me.Controls.Add(Me._Label_65)
        Me.Controls.Add(Me._Label_66)
        Me.Controls.Add(Me._Label_67)
        Me.Controls.Add(Me._Label_68)
        Me.Controls.Add(Me._Label_69)
        Me.Controls.Add(Me._Label_70)
        Me.Controls.Add(Me._Label_35)
        Me.Controls.Add(Me._Label_31)
        Me.Controls.Add(Me._Label_30)
        Me.Controls.Add(Me._Label_29)
        Me.Controls.Add(Me._Label_28)
        Me.Controls.Add(Me._Label_27)
        Me.Controls.Add(Me._Label_26)
        Me.Controls.Add(Me._Label_25)
        Me.Controls.Add(Me._Label_24)
        Me.Controls.Add(Me._Label_23)
        Me.Controls.Add(Me._Label_22)
        Me.Controls.Add(Me._Label_21)
        Me.Controls.Add(Me._Label_20)
        Me.Controls.Add(Me._Label_19)
        Me.Controls.Add(Me._Label_18)
        Me.Controls.Add(Me._Label_17)
        Me.Controls.Add(Me._Label_16)
        Me.Controls.Add(Me._Label_15)
        Me.Controls.Add(Me._Label_14)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me._Label_12)
        Me.Controls.Add(Me._Label_11)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Label_9)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_5)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_34)
        Me.Controls.Add(Me._Label_32)
        Me.Controls.Add(Me._Label_33)
        Me.Controls.Add(Me._Label_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(4, 47)
        Me.MaximizeBox = False
        Me.Name = "FrmChamconggio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Attendance Employees Hourly Overtime"
        Me.Text = "Chấm công nhân viên tăng ca theo giờ"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Sub Initializetxtnd()
        Me.txtnd(31) = _txtnd_31
        Me.txtnd(30) = _txtnd_30
        Me.txtnd(29) = _txtnd_29
        Me.txtnd(28) = _txtnd_28
        Me.txtnd(27) = _txtnd_27
        Me.txtnd(26) = _txtnd_26
        Me.txtnd(25) = _txtnd_25
        Me.txtnd(24) = _txtnd_24
        Me.txtnd(23) = _txtnd_23
        Me.txtnd(22) = _txtnd_22
        Me.txtnd(21) = _txtnd_21
        Me.txtnd(20) = _txtnd_20
        Me.txtnd(19) = _txtnd_19
        Me.txtnd(18) = _txtnd_18
        Me.txtnd(17) = _txtnd_17
        Me.txtnd(16) = _txtnd_16
        Me.txtnd(15) = _txtnd_15
        Me.txtnd(14) = _txtnd_14
        Me.txtnd(13) = _txtnd_13
        Me.txtnd(12) = _txtnd_12
        Me.txtnd(11) = _txtnd_11
        Me.txtnd(10) = _txtnd_10
        Me.txtnd(9) = _txtnd_9
        Me.txtnd(8) = _txtnd_8
        Me.txtnd(7) = _txtnd_7
        Me.txtnd(6) = _txtnd_6
        Me.txtnd(5) = _txtnd_5
        Me.txtnd(4) = _txtnd_4
        Me.txtnd(3) = _txtnd_3
        Me.txtnd(2) = _txtnd_2
        Me.txtnd(1) = _txtnd_1
        Me.txtnd(0) = _txtnd_0
        Me.txtnd(32) = _txtnd_32
    End Sub
    Sub Initializetxtnc()
        Me.txtnc(31) = _txtnc_31
        Me.txtnc(30) = _txtnc_30
        Me.txtnc(29) = _txtnc_29
        Me.txtnc(28) = _txtnc_28
        Me.txtnc(27) = _txtnc_27
        Me.txtnc(26) = _txtnc_26
        Me.txtnc(25) = _txtnc_25
        Me.txtnc(24) = _txtnc_24
        Me.txtnc(23) = _txtnc_23
        Me.txtnc(22) = _txtnc_22
        Me.txtnc(21) = _txtnc_21
        Me.txtnc(20) = _txtnc_20
        Me.txtnc(19) = _txtnc_19
        Me.txtnc(18) = _txtnc_18
        Me.txtnc(17) = _txtnc_17
        Me.txtnc(16) = _txtnc_16
        Me.txtnc(15) = _txtnc_15
        Me.txtnc(14) = _txtnc_14
        Me.txtnc(13) = _txtnc_13
        Me.txtnc(12) = _txtnc_12
        Me.txtnc(11) = _txtnc_11
        Me.txtnc(10) = _txtnc_10
        Me.txtnc(9) = _txtnc_9
        Me.txtnc(8) = _txtnc_8
        Me.txtnc(7) = _txtnc_7
        Me.txtnc(6) = _txtnc_6
        Me.txtnc(5) = _txtnc_5
        Me.txtnc(4) = _txtnc_4
        Me.txtnc(3) = _txtnc_3
        Me.txtnc(2) = _txtnc_2
        Me.txtnc(1) = _txtnc_1
        Me.txtnc(0) = _txtnc_0
        Me.txtnc(32) = _txtnc_32
    End Sub
    Sub Initializetxtn()
        Me.txtn(31) = _txtn_31
        Me.txtn(30) = _txtn_30
        Me.txtn(29) = _txtn_29
        Me.txtn(28) = _txtn_28
        Me.txtn(27) = _txtn_27
        Me.txtn(26) = _txtn_26
        Me.txtn(25) = _txtn_25
        Me.txtn(24) = _txtn_24
        Me.txtn(23) = _txtn_23
        Me.txtn(22) = _txtn_22
        Me.txtn(21) = _txtn_21
        Me.txtn(20) = _txtn_20
        Me.txtn(19) = _txtn_19
        Me.txtn(18) = _txtn_18
        Me.txtn(17) = _txtn_17
        Me.txtn(16) = _txtn_16
        Me.txtn(15) = _txtn_15
        Me.txtn(14) = _txtn_14
        Me.txtn(13) = _txtn_13
        Me.txtn(12) = _txtn_12
        Me.txtn(11) = _txtn_11
        Me.txtn(10) = _txtn_10
        Me.txtn(9) = _txtn_9
        Me.txtn(8) = _txtn_8
        Me.txtn(7) = _txtn_7
        Me.txtn(6) = _txtn_6
        Me.txtn(5) = _txtn_5
        Me.txtn(4) = _txtn_4
        Me.txtn(3) = _txtn_3
        Me.txtn(2) = _txtn_2
        Me.txtn(1) = _txtn_1
        Me.txtn(32) = _txtn_32
    End Sub
    Sub Initializetxtch()
        Me.txtch(2) = _txtch_2
        Me.txtch(1) = _txtch_1
        Me.txtch(0) = _txtch_0
    End Sub
    Sub InitializeLabel()
        Me.Label(82) = _Label_82
        Me.Label(81) = _Label_81
        Me.Label(37) = _Label_37
        Me.Label(36) = _Label_36
        Me.Label(41) = _Label_41
        Me.Label(42) = _Label_42
        Me.Label(43) = _Label_43
        Me.Label(44) = _Label_44
        Me.Label(45) = _Label_45
        Me.Label(46) = _Label_46
        Me.Label(47) = _Label_47
        Me.Label(48) = _Label_48
        Me.Label(49) = _Label_49
        Me.Label(50) = _Label_50
        Me.Label(51) = _Label_51
        Me.Label(52) = _Label_52
        Me.Label(53) = _Label_53
        Me.Label(54) = _Label_54
        Me.Label(55) = _Label_55
        Me.Label(56) = _Label_56
        Me.Label(57) = _Label_57
        Me.Label(58) = _Label_58
        Me.Label(59) = _Label_59
        Me.Label(60) = _Label_60
        Me.Label(61) = _Label_61
        Me.Label(62) = _Label_62
        Me.Label(63) = _Label_63
        Me.Label(64) = _Label_64
        Me.Label(65) = _Label_65
        Me.Label(66) = _Label_66
        Me.Label(67) = _Label_67
        Me.Label(68) = _Label_68
        Me.Label(69) = _Label_69
        Me.Label(70) = _Label_70
        Me.Label(71) = _Label_71
        Me.Label(35) = _Label_35
        Me.Label(31) = _Label_31
        Me.Label(30) = _Label_30
        Me.Label(29) = _Label_29
        Me.Label(28) = _Label_28
        Me.Label(27) = _Label_27
        Me.Label(26) = _Label_26
        Me.Label(25) = _Label_25
        Me.Label(24) = _Label_24
        Me.Label(23) = _Label_23
        Me.Label(22) = _Label_22
        Me.Label(21) = _Label_21
        Me.Label(20) = _Label_20
        Me.Label(19) = _Label_19
        Me.Label(18) = _Label_18
        Me.Label(17) = _Label_17
        Me.Label(16) = _Label_16
        Me.Label(15) = _Label_15
        Me.Label(14) = _Label_14
        Me.Label(13) = _Label_13
        Me.Label(12) = _Label_12
        Me.Label(11) = _Label_11
        Me.Label(10) = _Label_10
        Me.Label(9) = _Label_9
        Me.Label(8) = _Label_8
        Me.Label(7) = _Label_7
        Me.Label(6) = _Label_6
        Me.Label(5) = _Label_5
        Me.Label(4) = _Label_4
        Me.Label(3) = _Label_3
        Me.Label(2) = _Label_2
        Me.Label(1) = _Label_1
        Me.Label(34) = _Label_34
        Me.Label(32) = _Label_32
        Me.Label(33) = _Label_33
        Me.Label(0) = _Label_0
    End Sub
    Sub InitializeCommand1()
        Me.Command1(2) = _Command1_2
        Me.Command1(0) = _Command1_0
        Me.Command1(1) = _Command1_1
    End Sub
    Sub InitializeCommand()
        Me.Command(2) = _Command_2
        Me.Command(1) = _Command_1
        Me.Command(0) = _Command_0
    End Sub
    Private WithEvents _txtn_32 As System.Windows.Forms.TextBox
#End Region 
End Class
