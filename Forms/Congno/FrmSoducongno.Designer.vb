<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSoducongno
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		Initializemnct()
		InitializeOpt()
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
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Private WithEvents _CboThang_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboThang_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Private WithEvents _Label_18 As System.Windows.Forms.Label
    Private WithEvents _Frame_4 As System.Windows.Forms.Panel
    Public WithEvents Grd As ListviewEx.ListviewExt
    Public WithEvents cmdtk As System.Windows.Forms.Button
    Public WithEvents txtShTk As System.Windows.Forms.TextBox
    Public WithEvents CboKH As ComboBoxEx.ComboBoxExt
    Private WithEvents _Opt_1 As System.Windows.Forms.RadioButton
    Private WithEvents _Opt_0 As System.Windows.Forms.RadioButton
    Public WithEvents cmdtk1 As System.Windows.Forms.Button
    Public WithEvents LbTenTk As System.Windows.Forms.Label
    Private WithEvents _Frame_3 As System.Windows.Forms.Panel
    Public WithEvents GauGe As System.Windows.Forms.ProgressBar
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Label_25 As System.Windows.Forms.Label
    Private WithEvents _Label_31 As System.Windows.Forms.Label
    Private WithEvents _Label_30 As System.Windows.Forms.Label
    Private WithEvents _Label_32 As System.Windows.Forms.Label
    Private WithEvents _Label_33 As System.Windows.Forms.Label
    Private WithEvents _Label_36 As System.Windows.Forms.Label
    Private WithEvents _Label_37 As System.Windows.Forms.Label
    Private WithEvents _Label_35 As System.Windows.Forms.Label
    Private WithEvents _Label_34 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_15 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Label_9 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Public CboThang(1) As ComboBoxEx.ComboBoxExt
    Public Command(1) As System.Windows.Forms.Button
    Public Command1(1) As System.Windows.Forms.Button
    Public Frame(4) As System.Windows.Forms.Panel
    Public Label(37) As System.Windows.Forms.Label
    Public Opt(1) As System.Windows.Forms.RadioButton
    Public mnct(0) As System.Windows.Forms.ToolStripMenuItem
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSoducongno))
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnPU = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnct_0 = New System.Windows.Forms.ToolStripMenuItem()
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me._Command1_0 = New System.Windows.Forms.Button()
        Me._Frame_4 = New System.Windows.Forms.Panel()
        Me._CboThang_0 = New ComboBoxEx.ComboBoxExt()
        Me._CboThang_1 = New ComboBoxEx.ComboBoxExt()
        Me._Label_17 = New System.Windows.Forms.Label()
        Me._Label_18 = New System.Windows.Forms.Label()
        Me._Frame_3 = New System.Windows.Forms.Panel()
        Me.cmdtk = New System.Windows.Forms.Button()
        Me.txtShTk = New System.Windows.Forms.TextBox()
        Me.CboKH = New ComboBoxEx.ComboBoxExt()
        Me._Opt_1 = New System.Windows.Forms.RadioButton()
        Me._Opt_0 = New System.Windows.Forms.RadioButton()
        Me.cmdtk1 = New System.Windows.Forms.Button()
        Me.LbTenTk = New System.Windows.Forms.Label()
        Me.GauGe = New System.Windows.Forms.ProgressBar()
        Me._Command1_1 = New System.Windows.Forms.Button()
        Me._Label_25 = New System.Windows.Forms.Label()
        Me._Label_31 = New System.Windows.Forms.Label()
        Me._Label_30 = New System.Windows.Forms.Label()
        Me._Label_32 = New System.Windows.Forms.Label()
        Me._Label_33 = New System.Windows.Forms.Label()
        Me._Label_36 = New System.Windows.Forms.Label()
        Me._Label_37 = New System.Windows.Forms.Label()
        Me._Label_35 = New System.Windows.Forms.Label()
        Me._Label_34 = New System.Windows.Forms.Label()
        Me._Label_4 = New System.Windows.Forms.Label()
        Me._Label_2 = New System.Windows.Forms.Label()
        Me._Label_15 = New System.Windows.Forms.Label()
        Me._Label_12 = New System.Windows.Forms.Label()
        Me._Label_11 = New System.Windows.Forms.Label()
        Me._Label_10 = New System.Windows.Forms.Label()
        Me._Label_9 = New System.Windows.Forms.Label()
        Me._Label_8 = New System.Windows.Forms.Label()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me._Label_1 = New System.Windows.Forms.Label()
        Me._Label_3 = New System.Windows.Forms.Label()
        Me._Label_6 = New System.Windows.Forms.Label()
        Me._Label_7 = New System.Windows.Forms.Label()
        Me._Label_13 = New System.Windows.Forms.Label()
        Me._Label_14 = New System.Windows.Forms.Label()
        Me.Grd = New ListViewEx.ListviewExt()
        Me.MainMenu1.SuspendLayout()
        Me._Frame_4.SuspendLayout()
        Me._Frame_3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnPU})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(977, 24)
        Me.MainMenu1.TabIndex = 43
        Me.MainMenu1.Visible = False
        '
        'mnPU
        '
        Me.mnPU.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._mnct_0})
        Me.mnPU.Name = "mnPU"
        Me.mnPU.Size = New System.Drawing.Size(69, 20)
        Me.mnPU.Tag = "Voucher"
        Me.mnPU.Text = "Chứng từ"
        '
        '_mnct_0
        '
        Me._mnct_0.Name = "_mnct_0"
        Me._mnct_0.Size = New System.Drawing.Size(144, 22)
        Me._mnct_0.Tag = "Edit voucher"
        Me._mnct_0.Text = "Sửa chứng từ"
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(895, 696)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(74, 25)
        Me._Command_1.TabIndex = 42
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        '
        '_Command_0
        '
        Me._Command_0.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Liet_ke
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(800, 696)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(89, 25)
        Me._Command_0.TabIndex = 41
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
        Me._Command1_0.Location = New System.Drawing.Point(816, 696)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(73, 25)
        Me._Command1_0.TabIndex = 28
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&List"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        '_Frame_4
        '
        Me._Frame_4.BackColor = System.Drawing.Color.Transparent
        Me._Frame_4.Controls.Add(Me._CboThang_0)
        Me._Frame_4.Controls.Add(Me._CboThang_1)
        Me._Frame_4.Controls.Add(Me._Label_17)
        Me._Frame_4.Controls.Add(Me._Label_18)
        Me._Frame_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Frame_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_4.Location = New System.Drawing.Point(680, 24)
        Me._Frame_4.Name = "_Frame_4"
        Me._Frame_4.Size = New System.Drawing.Size(281, 33)
        Me._Frame_4.TabIndex = 23
        '
        '_CboThang_0
        '
        Me._CboThang_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_0.Location = New System.Drawing.Point(64, 6)
        Me._CboThang_0.Name = "_CboThang_0"
        Me._CboThang_0.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_0.TabIndex = 25
        '
        '_CboThang_1
        '
        Me._CboThang_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_1.Location = New System.Drawing.Point(200, 6)
        Me._CboThang_1.Name = "_CboThang_1"
        Me._CboThang_1.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_1.TabIndex = 24
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.Color.Transparent
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_17.Location = New System.Drawing.Point(138, 9)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(58, 17)
        Me._Label_17.TabIndex = 27
        Me._Label_17.Tag = "to"
        Me._Label_17.Text = "Đến tháng"
        Me._Label_17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_18
        '
        Me._Label_18.BackColor = System.Drawing.Color.Transparent
        Me._Label_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_18.Location = New System.Drawing.Point(5, 9)
        Me._Label_18.Name = "_Label_18"
        Me._Label_18.Size = New System.Drawing.Size(58, 17)
        Me._Label_18.TabIndex = 26
        Me._Label_18.Tag = "From"
        Me._Label_18.Text = "Từ tháng"
        Me._Label_18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Frame_3
        '
        Me._Frame_3.BackColor = System.Drawing.Color.Transparent
        Me._Frame_3.Controls.Add(Me.cmdtk)
        Me._Frame_3.Controls.Add(Me.txtShTk)
        Me._Frame_3.Controls.Add(Me.CboKH)
        Me._Frame_3.Controls.Add(Me._Opt_1)
        Me._Frame_3.Controls.Add(Me._Opt_0)
        Me._Frame_3.Controls.Add(Me.cmdtk1)
        Me._Frame_3.Controls.Add(Me.LbTenTk)
        Me._Frame_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Frame_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_3.Location = New System.Drawing.Point(8, 23)
        Me._Frame_3.Name = "_Frame_3"
        Me._Frame_3.Size = New System.Drawing.Size(601, 41)
        Me._Frame_3.TabIndex = 21
        '
        'cmdtk
        '
        Me.cmdtk.Image = CType(resources.GetObject("cmdtk.Image"), System.Drawing.Image)
        Me.cmdtk.Location = New System.Drawing.Point(175, 8)
        Me.cmdtk.Name = "cmdtk"
        Me.cmdtk.Size = New System.Drawing.Size(23, 22)
        Me.cmdtk.TabIndex = 40
        '
        'txtShTk
        '
        Me.txtShTk.AcceptsReturn = True
        Me.txtShTk.BackColor = System.Drawing.SystemColors.Window
        Me.txtShTk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShTk.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShTk.Location = New System.Drawing.Point(80, 8)
        Me.txtShTk.MaxLength = 12
        Me.txtShTk.Name = "txtShTk"
        Me.txtShTk.Size = New System.Drawing.Size(89, 20)
        Me.txtShTk.TabIndex = 1
        Me.txtShTk.Tag = "0"
        '
        'CboKH
        '
        Me.CboKH.BackColor = System.Drawing.SystemColors.Window
        Me.CboKH.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboKH.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboKH.Location = New System.Drawing.Point(432, 7)
        Me.CboKH.Name = "CboKH"
        Me.CboKH.Size = New System.Drawing.Size(161, 23)
        Me.CboKH.TabIndex = 4
        '
        '_Opt_1
        '
        Me._Opt_1.BackColor = System.Drawing.Color.Transparent
        Me._Opt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_1.Location = New System.Drawing.Point(360, 8)
        Me._Opt_1.Name = "_Opt_1"
        Me._Opt_1.Size = New System.Drawing.Size(70, 17)
        Me._Opt_1.TabIndex = 3
        Me._Opt_1.TabStop = True
        Me._Opt_1.Tag = "Class"
        Me._Opt_1.Text = "Phân loại"
        Me._Opt_1.UseVisualStyleBackColor = False
        '
        '_Opt_0
        '
        Me._Opt_0.BackColor = System.Drawing.Color.Transparent
        Me._Opt_0.Checked = True
        Me._Opt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_0.Location = New System.Drawing.Point(8, 8)
        Me._Opt_0.Name = "_Opt_0"
        Me._Opt_0.Size = New System.Drawing.Size(73, 17)
        Me._Opt_0.TabIndex = 0
        Me._Opt_0.TabStop = True
        Me._Opt_0.Tag = "Account"
        Me._Opt_0.Text = "Tài khoản"
        Me._Opt_0.UseVisualStyleBackColor = False
        '
        'cmdtk1
        '
        Me.cmdtk1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdtk1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdtk1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdtk1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdtk1.Image = CType(resources.GetObject("cmdtk1.Image"), System.Drawing.Image)
        Me.cmdtk1.Location = New System.Drawing.Point(-42, 14)
        Me.cmdtk1.Name = "cmdtk1"
        Me.cmdtk1.Size = New System.Drawing.Size(25, 25)
        Me.cmdtk1.TabIndex = 2
        Me.cmdtk1.TabStop = False
        Me.cmdtk1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdtk1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdtk1.UseVisualStyleBackColor = False
        Me.cmdtk1.Visible = False
        '
        'LbTenTk
        '
        Me.LbTenTk.BackColor = System.Drawing.Color.Transparent
        Me.LbTenTk.Cursor = System.Windows.Forms.Cursors.Default
        Me.LbTenTk.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTenTk.ForeColor = System.Drawing.Color.Blue
        Me.LbTenTk.Location = New System.Drawing.Point(208, 8)
        Me.LbTenTk.Name = "LbTenTk"
        Me.LbTenTk.Size = New System.Drawing.Size(145, 17)
        Me.LbTenTk.TabIndex = 22
        Me.LbTenTk.Tag = "1"
        '
        'GauGe
        '
        Me.GauGe.Location = New System.Drawing.Point(8, 704)
        Me.GauGe.Name = "GauGe"
        Me.GauGe.Size = New System.Drawing.Size(281, 17)
        Me.GauGe.TabIndex = 30
        '
        '_Command1_1
        '
        Me._Command1_1.BackColor = System.Drawing.Color.Silver
        Me._Command1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_1.Image = CType(resources.GetObject("_Command1_1.Image"), System.Drawing.Image)
        Me._Command1_1.Location = New System.Drawing.Point(896, 696)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(73, 25)
        Me._Command1_1.TabIndex = 29
        Me._Command1_1.TabStop = False
        Me._Command1_1.Tag = "&Return"
        Me._Command1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_1.UseVisualStyleBackColor = False
        Me._Command1_1.Visible = False
        '
        '_Label_25
        '
        Me._Label_25.BackColor = System.Drawing.Color.Transparent
        Me._Label_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_25.Location = New System.Drawing.Point(176, 680)
        Me._Label_25.Name = "_Label_25"
        Me._Label_25.Size = New System.Drawing.Size(113, 17)
        Me._Label_25.TabIndex = 39
        Me._Label_25.Tag = "Total:"
        Me._Label_25.Text = "Tổng cộng: "
        Me._Label_25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_31
        '
        Me._Label_31.BackColor = System.Drawing.Color.Transparent
        Me._Label_31.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_31.Location = New System.Drawing.Point(368, 680)
        Me._Label_31.Name = "_Label_31"
        Me._Label_31.Size = New System.Drawing.Size(81, 17)
        Me._Label_31.TabIndex = 38
        Me._Label_31.Tag = "User Name"
        Me._Label_31.Text = "Có"
        Me._Label_31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_30
        '
        Me._Label_30.BackColor = System.Drawing.Color.Transparent
        Me._Label_30.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_30.Location = New System.Drawing.Point(288, 680)
        Me._Label_30.Name = "_Label_30"
        Me._Label_30.Size = New System.Drawing.Size(81, 17)
        Me._Label_30.TabIndex = 37
        Me._Label_30.Tag = "User Name"
        Me._Label_30.Text = "Nợ"
        Me._Label_30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_32
        '
        Me._Label_32.BackColor = System.Drawing.Color.Transparent
        Me._Label_32.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_32.Location = New System.Drawing.Point(448, 680)
        Me._Label_32.Name = "_Label_32"
        Me._Label_32.Size = New System.Drawing.Size(81, 17)
        Me._Label_32.TabIndex = 36
        Me._Label_32.Tag = "User Name"
        Me._Label_32.Text = "Nợ"
        Me._Label_32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_33
        '
        Me._Label_33.BackColor = System.Drawing.Color.Transparent
        Me._Label_33.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_33.Location = New System.Drawing.Point(528, 680)
        Me._Label_33.Name = "_Label_33"
        Me._Label_33.Size = New System.Drawing.Size(81, 17)
        Me._Label_33.TabIndex = 35
        Me._Label_33.Tag = "User Name"
        Me._Label_33.Text = "Luỹ kế"
        Me._Label_33.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_36
        '
        Me._Label_36.BackColor = System.Drawing.Color.Transparent
        Me._Label_36.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_36.Location = New System.Drawing.Point(768, 680)
        Me._Label_36.Name = "_Label_36"
        Me._Label_36.Size = New System.Drawing.Size(89, 17)
        Me._Label_36.TabIndex = 34
        Me._Label_36.Tag = "User Name"
        Me._Label_36.Text = "Nợ"
        Me._Label_36.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_37
        '
        Me._Label_37.BackColor = System.Drawing.Color.Transparent
        Me._Label_37.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_37.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_37.Location = New System.Drawing.Point(856, 680)
        Me._Label_37.Name = "_Label_37"
        Me._Label_37.Size = New System.Drawing.Size(97, 17)
        Me._Label_37.TabIndex = 33
        Me._Label_37.Tag = "User Name"
        Me._Label_37.Text = "Có"
        Me._Label_37.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_35
        '
        Me._Label_35.BackColor = System.Drawing.Color.Transparent
        Me._Label_35.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_35.Location = New System.Drawing.Point(688, 680)
        Me._Label_35.Name = "_Label_35"
        Me._Label_35.Size = New System.Drawing.Size(81, 17)
        Me._Label_35.TabIndex = 32
        Me._Label_35.Tag = "User Name"
        Me._Label_35.Text = "Luỹ kế"
        Me._Label_35.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_34
        '
        Me._Label_34.BackColor = System.Drawing.Color.Transparent
        Me._Label_34.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_34.Location = New System.Drawing.Point(608, 680)
        Me._Label_34.Name = "_Label_34"
        Me._Label_34.Size = New System.Drawing.Size(81, 17)
        Me._Label_34.TabIndex = 31
        Me._Label_34.Tag = "User Name"
        Me._Label_34.Text = "Có"
        Me._Label_34.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(608, 80)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(81, 17)
        Me._Label_4.TabIndex = 20
        Me._Label_4.Tag = "Credit"
        Me._Label_4.Text = "Có"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.Black
        Me._Label_2.Location = New System.Drawing.Point(688, 80)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(81, 17)
        Me._Label_2.TabIndex = 19
        Me._Label_2.Tag = "Accumlated"
        Me._Label_2.Text = "Luỹ kế"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_15
        '
        Me._Label_15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_15.ForeColor = System.Drawing.Color.Black
        Me._Label_15.Location = New System.Drawing.Point(768, 64)
        Me._Label_15.Name = "_Label_15"
        Me._Label_15.Size = New System.Drawing.Size(201, 17)
        Me._Label_15.TabIndex = 18
        Me._Label_15.Tag = "Ending balance"
        Me._Label_15.Text = "Tồn cuối kỳ"
        Me._Label_15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_12
        '
        Me._Label_12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.Color.Black
        Me._Label_12.Location = New System.Drawing.Point(856, 80)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.Size = New System.Drawing.Size(113, 17)
        Me._Label_12.TabIndex = 17
        Me._Label_12.Tag = "Credit"
        Me._Label_12.Text = "Có"
        Me._Label_12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.Color.Black
        Me._Label_11.Location = New System.Drawing.Point(768, 80)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(89, 17)
        Me._Label_11.TabIndex = 16
        Me._Label_11.Tag = "Debt"
        Me._Label_11.Text = "Nợ"
        Me._Label_11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.Color.Black
        Me._Label_10.Location = New System.Drawing.Point(448, 64)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(321, 17)
        Me._Label_10.TabIndex = 15
        Me._Label_10.Tag = "Generate in period"
        Me._Label_10.Text = "Phát sinh trong kỳ"
        Me._Label_10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_9
        '
        Me._Label_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.Color.Black
        Me._Label_9.Location = New System.Drawing.Point(528, 80)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.Size = New System.Drawing.Size(81, 17)
        Me._Label_9.TabIndex = 14
        Me._Label_9.Tag = "Accumlated"
        Me._Label_9.Text = "Luỹ kế"
        Me._Label_9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.Color.Black
        Me._Label_8.Location = New System.Drawing.Point(448, 80)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(81, 17)
        Me._Label_8.TabIndex = 13
        Me._Label_8.Tag = "Debt"
        Me._Label_8.Text = "Nợ"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me._Label_0.TabIndex = 11
        Me._Label_0.Tag = "Order"
        Me._Label_0.Text = "STT"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(32, 80)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(73, 17)
        Me._Label_1.TabIndex = 10
        Me._Label_1.Tag = "Code"
        Me._Label_1.Text = "Số hiệu"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.Black
        Me._Label_3.Location = New System.Drawing.Point(104, 80)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(185, 17)
        Me._Label_3.TabIndex = 9
        Me._Label_3.Tag = "Full name"
        Me._Label_3.Text = "Họ và tên"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.Color.Black
        Me._Label_6.Location = New System.Drawing.Point(288, 80)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(81, 17)
        Me._Label_6.TabIndex = 8
        Me._Label_6.Tag = "Debt"
        Me._Label_6.Text = "Nợ"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(368, 80)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(81, 17)
        Me._Label_7.TabIndex = 7
        Me._Label_7.Tag = "Credit"
        Me._Label_7.Text = "Có"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.Color.Black
        Me._Label_13.Location = New System.Drawing.Point(32, 64)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(257, 17)
        Me._Label_13.TabIndex = 6
        Me._Label_13.Tag = "Customer"
        Me._Label_13.Text = "Khách hàng"
        Me._Label_13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.Color.Black
        Me._Label_14.Location = New System.Drawing.Point(288, 64)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(161, 17)
        Me._Label_14.TabIndex = 5
        Me._Label_14.Tag = "Beginning Balance"
        Me._Label_14.Text = "Tồn đầu kỳ"
        Me._Label_14.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.Grd.Size = New System.Drawing.Size(961, 581)
        Me.Grd.SortType = ListViewEx.SortTypes.InsertionSort
        Me.Grd.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.Grd.TabIndex = 10
        '
        'FrmSoducongno
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(977, 729)
        Me.Controls.Add(Me.Grd)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me._Frame_4)
        Me.Controls.Add(Me._Frame_3)
        Me.Controls.Add(Me.GauGe)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Label_25)
        Me.Controls.Add(Me._Label_31)
        Me.Controls.Add(Me._Label_30)
        Me.Controls.Add(Me._Label_32)
        Me.Controls.Add(Me._Label_33)
        Me.Controls.Add(Me._Label_36)
        Me.Controls.Add(Me._Label_37)
        Me.Controls.Add(Me._Label_35)
        Me.Controls.Add(Me._Label_34)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_15)
        Me.Controls.Add(Me._Label_12)
        Me.Controls.Add(Me._Label_11)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Label_9)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me._Label_14)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSoducongno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Balance sheet liabilities"
        Me.Text = "Bảng cân đối công nợ"
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me._Frame_4.ResumeLayout(False)
        Me._Frame_3.ResumeLayout(False)
        Me._Frame_3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub Initializemnct()
		Me.mnct(0) = _mnct_0
	End Sub
	Sub InitializeOpt()
		Me.Opt(1) = _Opt_1
		Me.Opt(0) = _Opt_0
	End Sub
	Sub InitializeLabel()
		Me.Label(17) = _Label_17
		Me.Label(18) = _Label_18
		Me.Label(25) = _Label_25
		Me.Label(31) = _Label_31
		Me.Label(30) = _Label_30
		Me.Label(32) = _Label_32
		Me.Label(33) = _Label_33
		Me.Label(36) = _Label_36
		Me.Label(37) = _Label_37
		Me.Label(35) = _Label_35
		Me.Label(34) = _Label_34
		Me.Label(4) = _Label_4
		Me.Label(2) = _Label_2
		Me.Label(15) = _Label_15
		Me.Label(12) = _Label_12
		Me.Label(11) = _Label_11
		Me.Label(10) = _Label_10
		Me.Label(9) = _Label_9
		Me.Label(8) = _Label_8
		Me.Label(0) = _Label_0
		Me.Label(1) = _Label_1
		Me.Label(3) = _Label_3
		Me.Label(6) = _Label_6
		Me.Label(7) = _Label_7
		Me.Label(13) = _Label_13
		Me.Label(14) = _Label_14
	End Sub
	Sub InitializeFrame()
		Me.Frame(4) = _Frame_4
		Me.Frame(3) = _Frame_3
	End Sub
	Sub InitializeCommand1()
		Me.Command1(0) = _Command1_0
		Me.Command1(1) = _Command1_1
	End Sub
	Sub InitializeCommand()
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
	Sub InitializeCboThang()
		Me.CboThang(0) = _CboThang_0
		Me.CboThang(1) = _CboThang_1
	End Sub
#End Region 
End Class
