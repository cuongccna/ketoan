<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCandoi
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		Initializemnct()
		InitializeOptTG()
		InitializeLabel()
		InitializeFrame()
		InitializeCommand1()
		InitializeCommand()
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
	Private WithEvents _mnct_0 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnPU As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _CboThang_2 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Public WithEvents Grd As ListviewEx.ListviewExt
    Public WithEvents GauGe As System.Windows.Forms.ProgressBar
    Private WithEvents _CboThang_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboThang_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _OptTG_0 As System.Windows.Forms.RadioButton
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Private WithEvents _Frame_4 As System.Windows.Forms.Panel
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Private WithEvents _Label_26 As System.Windows.Forms.Label
    Private WithEvents _Label_25 As System.Windows.Forms.Label
    Private WithEvents _Label_24 As System.Windows.Forms.Label
    Private WithEvents _Label_23 As System.Windows.Forms.Label
    Private WithEvents _Label_22 As System.Windows.Forms.Label
    Private WithEvents _Label_21 As System.Windows.Forms.Label
    Private WithEvents _Label_19 As System.Windows.Forms.Label
    Private WithEvents _Label_16 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _Label_9 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_20 As System.Windows.Forms.Label
    Public CboThang(2) As ComboBoxEx.ComboBoxExt
    Public Command(1) As System.Windows.Forms.Button
    Public Command1(1) As System.Windows.Forms.Button
    Public Frame(4) As System.Windows.Forms.Panel
    Public Label(26) As System.Windows.Forms.Label
    Public OptTG(0) As System.Windows.Forms.RadioButton
    Public mnct(0) As System.Windows.Forms.ToolStripMenuItem
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'Private listBoxComboBoxHelper1 As Artinsoft.VB6.Gui.ListControlHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCandoi))
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip
        Me.mnPU = New System.Windows.Forms.ToolStripMenuItem
        Me._mnct_0 = New System.Windows.Forms.ToolStripMenuItem
        Me._Command_1 = New System.Windows.Forms.Button
        Me._CboThang_2 = New ComboBoxEx.ComboBoxExt
        Me._Command1_1 = New System.Windows.Forms.Button
        Me.GauGe = New System.Windows.Forms.ProgressBar
        Me._Frame_4 = New System.Windows.Forms.Panel
        Me._CboThang_0 = New ComboBoxEx.ComboBoxExt
        Me._CboThang_1 = New ComboBoxEx.ComboBoxExt
        Me._Label_17 = New System.Windows.Forms.Label
        Me._OptTG_0 = New System.Windows.Forms.RadioButton
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Command1_0 = New System.Windows.Forms.Button
        Me._Label_26 = New System.Windows.Forms.Label
        Me._Label_25 = New System.Windows.Forms.Label
        Me._Label_24 = New System.Windows.Forms.Label
        Me._Label_23 = New System.Windows.Forms.Label
        Me._Label_22 = New System.Windows.Forms.Label
        Me._Label_21 = New System.Windows.Forms.Label
        Me._Label_19 = New System.Windows.Forms.Label
        Me._Label_16 = New System.Windows.Forms.Label
        Me._Label_14 = New System.Windows.Forms.Label
        Me._Label_13 = New System.Windows.Forms.Label
        Me._Label_9 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Label_5 = New System.Windows.Forms.Label
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_20 = New System.Windows.Forms.Label
        Me.Grd = New ListViewEx.ListviewExt
        Me.MainMenu1.SuspendLayout()
        Me._Frame_4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnPU})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(1015, 24)
        Me.MainMenu1.TabIndex = 32
        Me.MainMenu1.Visible = False
        '
        'mnPU
        '
        Me.mnPU.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._mnct_0})
        Me.mnPU.Name = "mnPU"
        Me.mnPU.Size = New System.Drawing.Size(129, 20)
        Me.mnPU.Tag = "Detailed vouchers"
        Me.mnPU.Text = "Chi tiết các chứng từ"
        '
        '_mnct_0
        '
        Me._mnct_0.Name = "_mnct_0"
        Me._mnct_0.Size = New System.Drawing.Size(126, 22)
        Me._mnct_0.Tag = "Ledger"
        Me._mnct_0.Text = "Sổ chi tiết"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(936, 540)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 30
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        '
        '_CboThang_2
        '
        Me._CboThang_2.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_2.DropDownWidth = 29
        Me._CboThang_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_2.Location = New System.Drawing.Point(131, 29)
        Me._CboThang_2.Name = "_CboThang_2"
        Me._CboThang_2.Size = New System.Drawing.Size(41, 21)
        Me._CboThang_2.TabIndex = 0
        '
        '_Command1_1
        '
        Me._Command1_1.BackColor = System.Drawing.Color.Silver
        Me._Command1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_1.Image = CType(resources.GetObject("_Command1_1.Image"), System.Drawing.Image)
        Me._Command1_1.Location = New System.Drawing.Point(936, 540)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(73, 25)
        Me._Command1_1.TabIndex = 6
        Me._Command1_1.TabStop = False
        Me._Command1_1.Tag = "&Return"
        Me._Command1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_1.UseVisualStyleBackColor = False
        Me._Command1_1.Visible = False
        '
        'GauGe
        '
        Me.GauGe.Location = New System.Drawing.Point(8, 548)
        Me.GauGe.Name = "GauGe"
        Me.GauGe.Size = New System.Drawing.Size(313, 17)
        Me.GauGe.TabIndex = 19
        '
        '_Frame_4
        '
        Me._Frame_4.BackColor = System.Drawing.Color.Transparent
        Me._Frame_4.Controls.Add(Me._CboThang_0)
        Me._Frame_4.Controls.Add(Me._CboThang_1)
        Me._Frame_4.Controls.Add(Me._Label_17)
        Me._Frame_4.Controls.Add(Me._OptTG_0)
        Me._Frame_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Frame_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_4.Location = New System.Drawing.Point(703, 24)
        Me._Frame_4.Name = "_Frame_4"
        Me._Frame_4.Size = New System.Drawing.Size(314, 33)
        Me._Frame_4.TabIndex = 20
        Me._Frame_4.Text = "Sổ kế toán tổng hợp và báo cáo Tài chính"
        '
        '_CboThang_0
        '
        Me._CboThang_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_0.Location = New System.Drawing.Point(68, 7)
        Me._CboThang_0.Name = "_CboThang_0"
        Me._CboThang_0.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_0.TabIndex = 2
        '
        '_CboThang_1
        '
        Me._CboThang_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_1.Location = New System.Drawing.Point(232, 7)
        Me._CboThang_1.Name = "_CboThang_1"
        Me._CboThang_1.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_1.TabIndex = 3
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.Color.Transparent
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_17.Location = New System.Drawing.Point(158, 10)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(59, 17)
        Me._Label_17.TabIndex = 21
        Me._Label_17.Tag = "to"
        Me._Label_17.Text = "Đến tháng"
        Me._Label_17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_OptTG_0
        '
        Me._OptTG_0.BackColor = System.Drawing.Color.Transparent
        Me._OptTG_0.Checked = True
        Me._OptTG_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptTG_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptTG_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptTG_0.Location = New System.Drawing.Point(-15, 8)
        Me._OptTG_0.Name = "_OptTG_0"
        Me._OptTG_0.Size = New System.Drawing.Size(74, 17)
        Me._OptTG_0.TabIndex = 1
        Me._OptTG_0.TabStop = True
        Me._OptTG_0.Tag = "From"
        Me._OptTG_0.Text = "Từ tháng"
        Me._OptTG_0.UseVisualStyleBackColor = False
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.list16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(856, 540)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 31
        Me._Command_0.Tag = "Listed"
        Me._Command_0.Text = "&Liệt kê"
        '
        '_Command1_0
        '
        Me._Command1_0.BackColor = System.Drawing.Color.Silver
        Me._Command1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_0.Image = CType(resources.GetObject("_Command1_0.Image"), System.Drawing.Image)
        Me._Command1_0.Location = New System.Drawing.Point(856, 540)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(73, 25)
        Me._Command1_0.TabIndex = 5
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&List"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        '_Label_26
        '
        Me._Label_26.BackColor = System.Drawing.Color.Transparent
        Me._Label_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_26.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_26.Location = New System.Drawing.Point(888, 524)
        Me._Label_26.Name = "_Label_26"
        Me._Label_26.Size = New System.Drawing.Size(105, 17)
        Me._Label_26.TabIndex = 28
        Me._Label_26.Tag = "Level of Account"
        Me._Label_26.Text = "0"
        Me._Label_26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_25
        '
        Me._Label_25.BackColor = System.Drawing.Color.Transparent
        Me._Label_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_25.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_25.Location = New System.Drawing.Point(776, 524)
        Me._Label_25.Name = "_Label_25"
        Me._Label_25.Size = New System.Drawing.Size(105, 17)
        Me._Label_25.TabIndex = 27
        Me._Label_25.Tag = "Level of Account"
        Me._Label_25.Text = "0"
        Me._Label_25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_24
        '
        Me._Label_24.BackColor = System.Drawing.Color.Transparent
        Me._Label_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_24.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_24.Location = New System.Drawing.Point(664, 524)
        Me._Label_24.Name = "_Label_24"
        Me._Label_24.Size = New System.Drawing.Size(105, 17)
        Me._Label_24.TabIndex = 26
        Me._Label_24.Tag = "Level of Account"
        Me._Label_24.Text = "0"
        Me._Label_24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_23
        '
        Me._Label_23.BackColor = System.Drawing.Color.Transparent
        Me._Label_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_23.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_23.Location = New System.Drawing.Point(552, 524)
        Me._Label_23.Name = "_Label_23"
        Me._Label_23.Size = New System.Drawing.Size(105, 17)
        Me._Label_23.TabIndex = 25
        Me._Label_23.Tag = "Level of Account"
        Me._Label_23.Text = "0"
        Me._Label_23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_22
        '
        Me._Label_22.BackColor = System.Drawing.Color.Transparent
        Me._Label_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_22.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_22.Location = New System.Drawing.Point(440, 524)
        Me._Label_22.Name = "_Label_22"
        Me._Label_22.Size = New System.Drawing.Size(105, 17)
        Me._Label_22.TabIndex = 24
        Me._Label_22.Tag = "Level of Account"
        Me._Label_22.Text = "0"
        Me._Label_22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_21
        '
        Me._Label_21.BackColor = System.Drawing.Color.Transparent
        Me._Label_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_21.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_21.Location = New System.Drawing.Point(328, 524)
        Me._Label_21.Name = "_Label_21"
        Me._Label_21.Size = New System.Drawing.Size(105, 17)
        Me._Label_21.TabIndex = 23
        Me._Label_21.Tag = "Level of Account"
        Me._Label_21.Text = "0"
        Me._Label_21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_19
        '
        Me._Label_19.BackColor = System.Drawing.Color.Transparent
        Me._Label_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_19.Location = New System.Drawing.Point(8, 32)
        Me._Label_19.Name = "_Label_19"
        Me._Label_19.Size = New System.Drawing.Size(117, 17)
        Me._Label_19.TabIndex = 22
        Me._Label_19.Tag = "Level of Account"
        Me._Label_19.Text = "In đến tài khoản cấp"
        '
        '_Label_16
        '
        Me._Label_16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_16.ForeColor = System.Drawing.Color.Black
        Me._Label_16.Location = New System.Drawing.Point(768, 64)
        Me._Label_16.Name = "_Label_16"
        Me._Label_16.Size = New System.Drawing.Size(241, 17)
        Me._Label_16.TabIndex = 18
        Me._Label_16.Tag = "Ending balance"
        Me._Label_16.Text = "Tồn cuối kỳ"
        Me._Label_16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.Color.Black
        Me._Label_14.Location = New System.Drawing.Point(544, 64)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(225, 17)
        Me._Label_14.TabIndex = 17
        Me._Label_14.Tag = "Generate in period"
        Me._Label_14.Text = "Phát sinh trong kỳ"
        Me._Label_14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.Color.Black
        Me._Label_13.Location = New System.Drawing.Point(320, 64)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(225, 17)
        Me._Label_13.TabIndex = 16
        Me._Label_13.Tag = "Beginning Balance"
        Me._Label_13.Text = "Tồn đầu kỳ"
        Me._Label_13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_9
        '
        Me._Label_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.Color.Black
        Me._Label_9.Location = New System.Drawing.Point(880, 80)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.Size = New System.Drawing.Size(129, 17)
        Me._Label_9.TabIndex = 15
        Me._Label_9.Tag = "Credit"
        Me._Label_9.Text = "Có"
        Me._Label_9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.Color.Black
        Me._Label_8.Location = New System.Drawing.Point(768, 80)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(113, 17)
        Me._Label_8.TabIndex = 14
        Me._Label_8.Tag = "Debt"
        Me._Label_8.Text = "Nợ"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(656, 80)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(113, 17)
        Me._Label_7.TabIndex = 13
        Me._Label_7.Tag = "Credit"
        Me._Label_7.Text = "Có"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.Color.Black
        Me._Label_6.Location = New System.Drawing.Point(544, 80)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(113, 17)
        Me._Label_6.TabIndex = 12
        Me._Label_6.Tag = "Debt"
        Me._Label_6.Text = "Nợ"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.Color.Black
        Me._Label_5.Location = New System.Drawing.Point(432, 80)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(113, 17)
        Me._Label_5.TabIndex = 11
        Me._Label_5.Tag = "Credit"
        Me._Label_5.Text = "Có"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(320, 80)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(113, 17)
        Me._Label_4.TabIndex = 10
        Me._Label_4.Tag = "Debt"
        Me._Label_4.Text = "Nợ"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.Black
        Me._Label_2.Location = New System.Drawing.Point(96, 64)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(225, 33)
        Me._Label_2.TabIndex = 9
        Me._Label_2.Tag = "Name Account"
        Me._Label_2.Text = "Tên tài khoản"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(32, 64)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(65, 33)
        Me._Label_1.TabIndex = 8
        Me._Label_1.Tag = "Code"
        Me._Label_1.Text = "Số hiệu"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.Color.Black
        Me._Label_0.Location = New System.Drawing.Point(8, 64)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(25, 33)
        Me._Label_0.TabIndex = 7
        Me._Label_0.Tag = "Order"
        Me._Label_0.Text = "STT"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_20
        '
        Me._Label_20.BackColor = System.Drawing.Color.Transparent
        Me._Label_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_20.Location = New System.Drawing.Point(208, 524)
        Me._Label_20.Name = "_Label_20"
        Me._Label_20.Size = New System.Drawing.Size(113, 17)
        Me._Label_20.TabIndex = 29
        Me._Label_20.Tag = "Total :"
        Me._Label_20.Text = "Tổng cộng : "
        Me._Label_20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Grd
        '
        Me.Grd.AllowColumnResize = True
        Me.Grd.AllowMultiselect = False
        Me.Grd.AlternateBackground = System.Drawing.Color.DarkGreen
        Me.Grd.AlternatingColors = False
        Me.Grd.AutoHeight = True
        Me.Grd.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Grd.BackgroundStretchToFit = True
        Me.Grd.Col = 0
        Me.Grd.Cols = 0
        Me.Grd.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me.Grd.FullRowSelect = True
        Me.Grd.GridColor = System.Drawing.Color.LightGray
        Me.Grd.GridLines = ListViewEx.GLGridLines.gridBoth
        Me.Grd.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me.Grd.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me.Grd.HeaderHeight = 22
        Me.Grd.HeaderVisible = True
        Me.Grd.HeaderWordWrap = False
        Me.Grd.HotColumnTracking = False
        Me.Grd.HotItemTracking = False
        Me.Grd.HotTrackingColor = System.Drawing.Color.LightGray
        Me.Grd.HoverEvents = False
        Me.Grd.HoverTime = 1
        Me.Grd.ImageList = Nothing
        Me.Grd.ItemHeight = 18
        Me.Grd.ItemWordWrap = False
        Me.Grd.Location = New System.Drawing.Point(8, 96)
        Me.Grd.Name = "Grd"
        Me.Grd.Row = 0
        Me.Grd.Rows = 0
        Me.Grd.Selectable = True
        Me.Grd.SelectedTextColor = System.Drawing.Color.White
        Me.Grd.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.Grd.ShowBorder = True
        Me.Grd.ShowFocusRect = False
        Me.Grd.Size = New System.Drawing.Size(1001, 425)
        Me.Grd.SortType = ListViewEx.SortTypes.InsertionSort
        Me.Grd.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.Grd.TabIndex = 10
        '
        'FrmCandoi
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1015, 572)
        Me.Controls.Add(Me.Grd)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._CboThang_2)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me.GauGe)
        Me.Controls.Add(Me._Frame_4)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me._Label_26)
        Me.Controls.Add(Me._Label_25)
        Me.Controls.Add(Me._Label_24)
        Me.Controls.Add(Me._Label_23)
        Me.Controls.Add(Me._Label_22)
        Me.Controls.Add(Me._Label_21)
        Me.Controls.Add(Me._Label_19)
        Me.Controls.Add(Me._Label_16)
        Me.Controls.Add(Me._Label_14)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me._Label_9)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_5)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_20)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCandoi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Balance in the preriod"
        Me.Text = "Bảng cân đối trong kỳ"
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me._Frame_4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub Initializemnct()
		Me.mnct(0) = _mnct_0
	End Sub
	Sub InitializeOptTG()
		Me.OptTG(0) = _OptTG_0
	End Sub
	Sub InitializeLabel()
		Me.Label(17) = _Label_17
		Me.Label(26) = _Label_26
		Me.Label(25) = _Label_25
		Me.Label(24) = _Label_24
		Me.Label(23) = _Label_23
		Me.Label(22) = _Label_22
		Me.Label(21) = _Label_21
		Me.Label(19) = _Label_19
		Me.Label(16) = _Label_16
		Me.Label(14) = _Label_14
		Me.Label(13) = _Label_13
		Me.Label(9) = _Label_9
		Me.Label(8) = _Label_8
		Me.Label(7) = _Label_7
		Me.Label(6) = _Label_6
		Me.Label(5) = _Label_5
		Me.Label(4) = _Label_4
		Me.Label(2) = _Label_2
		Me.Label(1) = _Label_1
		Me.Label(0) = _Label_0
		Me.Label(20) = _Label_20
	End Sub
	Sub InitializeFrame()
		Me.Frame(4) = _Frame_4
	End Sub
	Sub InitializeCommand1()
		Me.Command1(1) = _Command1_1
		Me.Command1(0) = _Command1_0
	End Sub
	Sub InitializeCommand()
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
	Sub InitializeCboThang()
		Me.CboThang(2) = _CboThang_2
		Me.CboThang(0) = _CboThang_0
		Me.CboThang(1) = _CboThang_1
	End Sub
#End Region 
End Class
