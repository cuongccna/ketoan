<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBangke
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
	Public WithEvents TxtTen As System.Windows.Forms.TextBox
	Public WithEvents Chk As System.Windows.Forms.CheckBox
	Public WithEvents TxtSohieu As System.Windows.Forms.TextBox
	Public WithEvents Cbooption As ComboBoxEx.ComboBoxExt
	Public WithEvents ChkTen As System.Windows.Forms.CheckBox
	Public WithEvents CboLai As ComboBoxEx.ComboBoxExt
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Public WithEvents CboSole As ComboBoxEx.ComboBoxExt
    Private WithEvents _Command1_2 As System.Windows.Forms.Button
    Public WithEvents CboTL As ComboBoxEx.ComboBoxExt
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Public WithEvents Grd As ListviewEx.ListviewExt
    Public WithEvents GauGe As System.Windows.Forms.ProgressBar
    Private WithEvents _CboThang_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboThang_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _OptTG_0 As System.Windows.Forms.RadioButton
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Private WithEvents _Frame_4 As System.Windows.Forms.Panel
    Public WithEvents txt As System.Windows.Forms.TextBox
    Public WithEvents LbTen As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_20 As System.Windows.Forms.Label
    Private WithEvents _Label_19 As System.Windows.Forms.Label
    Private WithEvents _Label_18 As System.Windows.Forms.Label
    Private WithEvents _Label_15 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Label_26 As System.Windows.Forms.Label
    Private WithEvents _Label_25 As System.Windows.Forms.Label
    Private WithEvents _Label_16 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _Label_9 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Public CboThang(1) As ComboBoxEx.ComboBoxExt
    Public Command(2) As System.Windows.Forms.Button
    Public Command1(2) As System.Windows.Forms.Button
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBangke))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt = New System.Windows.Forms.TextBox()
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnPU = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnct_0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtTen = New System.Windows.Forms.TextBox()
        Me.Chk = New System.Windows.Forms.CheckBox()
        Me.TxtSohieu = New System.Windows.Forms.TextBox()
        Me.Cbooption = New ComboBoxEx.ComboBoxExt()
        Me.ChkTen = New System.Windows.Forms.CheckBox()
        Me.CboLai = New ComboBoxEx.ComboBoxExt()
        Me._Command_2 = New System.Windows.Forms.Button()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me._Command_1 = New System.Windows.Forms.Button()
        Me.CboSole = New ComboBoxEx.ComboBoxExt()
        Me._Command1_2 = New System.Windows.Forms.Button()
        Me.CboTL = New ComboBoxEx.ComboBoxExt()
        Me._Command1_0 = New System.Windows.Forms.Button()
        Me._Command1_1 = New System.Windows.Forms.Button()
        Me.GauGe = New System.Windows.Forms.ProgressBar()
        Me._Frame_4 = New System.Windows.Forms.Panel()
        Me._CboThang_0 = New ComboBoxEx.ComboBoxExt()
        Me._CboThang_1 = New ComboBoxEx.ComboBoxExt()
        Me._OptTG_0 = New System.Windows.Forms.RadioButton()
        Me._Label_17 = New System.Windows.Forms.Label()
        Me.LbTen = New System.Windows.Forms.Label()
        Me._Label_6 = New System.Windows.Forms.Label()
        Me._Label_3 = New System.Windows.Forms.Label()
        Me._Label_20 = New System.Windows.Forms.Label()
        Me._Label_19 = New System.Windows.Forms.Label()
        Me._Label_18 = New System.Windows.Forms.Label()
        Me._Label_15 = New System.Windows.Forms.Label()
        Me._Label_12 = New System.Windows.Forms.Label()
        Me._Label_11 = New System.Windows.Forms.Label()
        Me._Label_10 = New System.Windows.Forms.Label()
        Me._Label_26 = New System.Windows.Forms.Label()
        Me._Label_25 = New System.Windows.Forms.Label()
        Me._Label_16 = New System.Windows.Forms.Label()
        Me._Label_14 = New System.Windows.Forms.Label()
        Me._Label_13 = New System.Windows.Forms.Label()
        Me._Label_9 = New System.Windows.Forms.Label()
        Me._Label_8 = New System.Windows.Forms.Label()
        Me._Label_5 = New System.Windows.Forms.Label()
        Me._Label_4 = New System.Windows.Forms.Label()
        Me._Label_2 = New System.Windows.Forms.Label()
        Me._Label_1 = New System.Windows.Forms.Label()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me.Grd = New ListViewEx.ListviewExt()
        Me.MainMenu1.SuspendLayout()
        Me._Frame_4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt
        '
        Me.txt.AcceptsReturn = True
        Me.txt.BackColor = System.Drawing.SystemColors.Window
        Me.txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.Location = New System.Drawing.Point(40, 56)
        Me.txt.MaxLength = 20
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(73, 20)
        Me.txt.TabIndex = 35
        Me.txt.Text = "Hiện máy tính"
        Me.ToolTipMain.SetToolTip(Me.txt, "Bấm ENTER để hiện danh sách tài khoản")
        Me.txt.Visible = False
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnPU})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(1015, 24)
        Me.MainMenu1.TabIndex = 44
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
        'TxtTen
        '
        Me.TxtTen.AcceptsReturn = True
        Me.TxtTen.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTen.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTen.Location = New System.Drawing.Point(200, 56)
        Me.TxtTen.MaxLength = 0
        Me.TxtTen.Name = "TxtTen"
        Me.TxtTen.Size = New System.Drawing.Size(177, 22)
        Me.TxtTen.TabIndex = 38
        '
        'Chk
        '
        Me.Chk.BackColor = System.Drawing.Color.Transparent
        Me.Chk.Cursor = System.Windows.Forms.Cursors.Default
        Me.Chk.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk.Location = New System.Drawing.Point(119, 36)
        Me.Chk.Name = "Chk"
        Me.Chk.Size = New System.Drawing.Size(75, 17)
        Me.Chk.TabIndex = 42
        Me.Chk.Tag = "Code"
        Me.Chk.Text = "Số hiệu"
        Me.Chk.UseVisualStyleBackColor = False
        '
        'TxtSohieu
        '
        Me.TxtSohieu.AcceptsReturn = True
        Me.TxtSohieu.BackColor = System.Drawing.SystemColors.Window
        Me.TxtSohieu.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSohieu.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSohieu.Location = New System.Drawing.Point(296, 29)
        Me.TxtSohieu.MaxLength = 0
        Me.TxtSohieu.Name = "TxtSohieu"
        Me.TxtSohieu.Size = New System.Drawing.Size(81, 22)
        Me.TxtSohieu.TabIndex = 41
        '
        'Cbooption
        '
        Me.Cbooption.BackColor = System.Drawing.SystemColors.Window
        Me.Cbooption.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cbooption.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.Cbooption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbooption.DropDownWidth = 84
        Me.Cbooption.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbooption.Location = New System.Drawing.Point(200, 29)
        Me.Cbooption.Name = "Cbooption"
        Me.Cbooption.Size = New System.Drawing.Size(89, 21)
        Me.Cbooption.TabIndex = 40
        '
        'ChkTen
        '
        Me.ChkTen.BackColor = System.Drawing.Color.Transparent
        Me.ChkTen.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkTen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkTen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkTen.Location = New System.Drawing.Point(119, 56)
        Me.ChkTen.Name = "ChkTen"
        Me.ChkTen.Size = New System.Drawing.Size(82, 17)
        Me.ChkTen.TabIndex = 39
        Me.ChkTen.Tag = "G. Name"
        Me.ChkTen.Text = "Tên vật tư"
        Me.ChkTen.UseVisualStyleBackColor = False
        '
        'CboLai
        '
        Me.CboLai.BackColor = System.Drawing.SystemColors.Window
        Me.CboLai.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboLai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboLai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLai.DropDownWidth = 36
        Me.CboLai.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLai.Location = New System.Drawing.Point(832, 55)
        Me.CboLai.Name = "CboLai"
        Me.CboLai.Size = New System.Drawing.Size(41, 21)
        Me.CboLai.TabIndex = 1
        '
        '_Command_2
        '
        Me._Command_2.Image = CType(resources.GetObject("_Command_2.Image"), System.Drawing.Image)
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(837, 647)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 8
        Me._Command_2.Tag = "Preview"
        Me._Command_2.Text = "&Xem"
        '
        '_Command_0
        '
        Me._Command_0.Image = Nothing
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(749, 647)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 7
        Me._Command_0.Tag = "Listed"
        Me._Command_0.Text = "&Liệt kê"
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(925, 647)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 9
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        '
        'CboSole
        '
        Me.CboSole.BackColor = System.Drawing.SystemColors.Window
        Me.CboSole.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboSole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboSole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSole.DropDownWidth = 29
        Me.CboSole.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSole.Location = New System.Drawing.Point(968, 55)
        Me.CboSole.Name = "CboSole"
        Me.CboSole.Size = New System.Drawing.Size(41, 21)
        Me.CboSole.TabIndex = 2
        '
        '_Command1_2
        '
        Me._Command1_2.BackColor = System.Drawing.Color.Silver
        Me._Command1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_2.Image = CType(resources.GetObject("_Command1_2.Image"), System.Drawing.Image)
        Me._Command1_2.Location = New System.Drawing.Point(837, 647)
        Me._Command1_2.Name = "_Command1_2"
        Me._Command1_2.Size = New System.Drawing.Size(73, 25)
        Me._Command1_2.TabIndex = 11
        Me._Command1_2.TabStop = False
        Me._Command1_2.Tag = "&View"
        Me._Command1_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_2.UseVisualStyleBackColor = False
        Me._Command1_2.Visible = False
        '
        'CboTL
        '
        Me.CboTL.BackColor = System.Drawing.SystemColors.Window
        Me.CboTL.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboTL.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTL.DropDownWidth = 53
        Me.CboTL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTL.Location = New System.Drawing.Point(48, 32)
        Me.CboTL.Name = "CboTL"
        Me.CboTL.Size = New System.Drawing.Size(65, 21)
        Me.CboTL.TabIndex = 0
        '
        '_Command1_0
        '
        Me._Command1_0.BackColor = System.Drawing.Color.Silver
        Me._Command1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_0.Image = CType(resources.GetObject("_Command1_0.Image"), System.Drawing.Image)
        Me._Command1_0.Location = New System.Drawing.Point(749, 647)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(73, 25)
        Me._Command1_0.TabIndex = 10
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&List"
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
        Me._Command1_1.Location = New System.Drawing.Point(925, 647)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(73, 25)
        Me._Command1_1.TabIndex = 12
        Me._Command1_1.TabStop = False
        Me._Command1_1.Tag = "&Return"
        Me._Command1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_1.UseVisualStyleBackColor = False
        Me._Command1_1.Visible = False
        '
        'GauGe
        '
        Me.GauGe.Location = New System.Drawing.Point(8, 655)
        Me.GauGe.Name = "GauGe"
        Me.GauGe.Size = New System.Drawing.Size(465, 17)
        Me.GauGe.TabIndex = 23
        '
        '_Frame_4
        '
        Me._Frame_4.BackColor = System.Drawing.Color.Transparent
        Me._Frame_4.Controls.Add(Me._CboThang_0)
        Me._Frame_4.Controls.Add(Me._CboThang_1)
        Me._Frame_4.Controls.Add(Me._OptTG_0)
        Me._Frame_4.Controls.Add(Me._Label_17)
        Me._Frame_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Frame_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_4.Location = New System.Drawing.Point(729, 24)
        Me._Frame_4.Name = "_Frame_4"
        Me._Frame_4.Size = New System.Drawing.Size(288, 33)
        Me._Frame_4.TabIndex = 24
        Me._Frame_4.Text = "Sổ kế toán tổng hợp và báo cáo Tài chính"
        '
        '_CboThang_0
        '
        Me._CboThang_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_0.Location = New System.Drawing.Point(56, 4)
        Me._CboThang_0.Name = "_CboThang_0"
        Me._CboThang_0.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_0.TabIndex = 4
        '
        '_CboThang_1
        '
        Me._CboThang_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_1.Location = New System.Drawing.Point(207, 4)
        Me._CboThang_1.Name = "_CboThang_1"
        Me._CboThang_1.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_1.TabIndex = 5
        '
        '_OptTG_0
        '
        Me._OptTG_0.BackColor = System.Drawing.Color.Transparent
        Me._OptTG_0.Checked = True
        Me._OptTG_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptTG_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptTG_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptTG_0.Location = New System.Drawing.Point(-16, 8)
        Me._OptTG_0.Name = "_OptTG_0"
        Me._OptTG_0.Size = New System.Drawing.Size(81, 17)
        Me._OptTG_0.TabIndex = 3
        Me._OptTG_0.TabStop = True
        Me._OptTG_0.Tag = "From"
        Me._OptTG_0.Text = "Từ tháng"
        Me._OptTG_0.UseVisualStyleBackColor = False
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.Color.Transparent
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_17.Location = New System.Drawing.Point(136, 8)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(58, 17)
        Me._Label_17.TabIndex = 25
        Me._Label_17.Tag = "to"
        Me._Label_17.Text = "Đến tháng"
        Me._Label_17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LbTen
        '
        Me.LbTen.BackColor = System.Drawing.Color.Transparent
        Me.LbTen.Cursor = System.Windows.Forms.Cursors.Default
        Me.LbTen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTen.ForeColor = System.Drawing.Color.Blue
        Me.LbTen.Location = New System.Drawing.Point(384, 36)
        Me.LbTen.Name = "LbTen"
        Me.LbTen.Size = New System.Drawing.Size(305, 17)
        Me.LbTen.TabIndex = 43
        Me.LbTen.Tag = "1"
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.Transparent
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_6.Location = New System.Drawing.Point(741, 58)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(148, 17)
        Me._Label_6.TabIndex = 37
        Me._Label_6.Tag = "Rate                                      %"
        Me._Label_6.Text = "Tỷ lệ lệch giá vốn               %"
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.Transparent
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_3.Location = New System.Drawing.Point(889, 59)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(73, 17)
        Me._Label_3.TabIndex = 36
        Me._Label_3.Tag = "Odd number"
        Me._Label_3.Text = "Số lẻ làm tròn"
        '
        '_Label_20
        '
        Me._Label_20.BackColor = System.Drawing.Color.Transparent
        Me._Label_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_20.Location = New System.Drawing.Point(709, 631)
        Me._Label_20.Name = "_Label_20"
        Me._Label_20.Size = New System.Drawing.Size(113, 17)
        Me._Label_20.TabIndex = 28
        Me._Label_20.Tag = "Total :"
        Me._Label_20.Text = "Tổng cộng : "
        Me._Label_20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_19
        '
        Me._Label_19.BackColor = System.Drawing.Color.Transparent
        Me._Label_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_19.Location = New System.Drawing.Point(8, 36)
        Me._Label_19.Name = "_Label_19"
        Me._Label_19.Size = New System.Drawing.Size(41, 17)
        Me._Label_19.TabIndex = 34
        Me._Label_19.Tag = "Rate (%)"
        Me._Label_19.Text = "Tỷ lệ %"
        '
        '_Label_18
        '
        Me._Label_18.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_18.ForeColor = System.Drawing.Color.Black
        Me._Label_18.Location = New System.Drawing.Point(32, 96)
        Me._Label_18.Name = "_Label_18"
        Me._Label_18.Size = New System.Drawing.Size(65, 17)
        Me._Label_18.TabIndex = 33
        Me._Label_18.Tag = "Notation"
        Me._Label_18.Text = "Ký hiệu"
        Me._Label_18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_15
        '
        Me._Label_15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_15.ForeColor = System.Drawing.Color.Black
        Me._Label_15.Location = New System.Drawing.Point(224, 80)
        Me._Label_15.Name = "_Label_15"
        Me._Label_15.Size = New System.Drawing.Size(345, 17)
        Me._Label_15.TabIndex = 32
        Me._Label_15.Tag = "Customers"
        Me._Label_15.Text = "Khách hàng"
        Me._Label_15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_12
        '
        Me._Label_12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.Color.Black
        Me._Label_12.Location = New System.Drawing.Point(920, 80)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.Size = New System.Drawing.Size(89, 33)
        Me._Label_12.TabIndex = 31
        Me._Label_12.Tag = "VAT"
        Me._Label_12.Text = "Thuế GTGT"
        Me._Label_12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.Color.Black
        Me._Label_11.Location = New System.Drawing.Point(808, 80)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(81, 33)
        Me._Label_11.TabIndex = 30
        Me._Label_11.Tag = "Pre-tax amount"
        Me._Label_11.Text = "Số phát sinh trước thuế"
        Me._Label_11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.Color.Black
        Me._Label_10.Location = New System.Drawing.Point(888, 80)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(33, 33)
        Me._Label_10.TabIndex = 29
        Me._Label_10.Tag = "VAT rate"
        Me._Label_10.Text = "Thuế suất"
        Me._Label_10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_26
        '
        Me._Label_26.BackColor = System.Drawing.Color.Transparent
        Me._Label_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_26.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_26.Location = New System.Drawing.Point(933, 631)
        Me._Label_26.Name = "_Label_26"
        Me._Label_26.Size = New System.Drawing.Size(65, 17)
        Me._Label_26.TabIndex = 27
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
        Me._Label_25.Location = New System.Drawing.Point(813, 631)
        Me._Label_25.Name = "_Label_25"
        Me._Label_25.Size = New System.Drawing.Size(81, 17)
        Me._Label_25.TabIndex = 26
        Me._Label_25.Tag = "Level of Account"
        Me._Label_25.Text = "0"
        Me._Label_25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_16
        '
        Me._Label_16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_16.ForeColor = System.Drawing.Color.Black
        Me._Label_16.Location = New System.Drawing.Point(568, 80)
        Me._Label_16.Name = "_Label_16"
        Me._Label_16.Size = New System.Drawing.Size(241, 17)
        Me._Label_16.TabIndex = 22
        Me._Label_16.Tag = "Items"
        Me._Label_16.Text = "Mặt hàng"
        Me._Label_16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.Color.Black
        Me._Label_14.Location = New System.Drawing.Point(568, 96)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(129, 17)
        Me._Label_14.TabIndex = 21
        Me._Label_14.Tag = "Name / Quantity"
        Me._Label_14.Text = "Tên hàng / Số lượng"
        Me._Label_14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.Color.Black
        Me._Label_13.Location = New System.Drawing.Point(152, 96)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(73, 17)
        Me._Label_13.TabIndex = 20
        Me._Label_13.Tag = "Date/G.code"
        Me._Label_13.Text = "Ngày / MaVT"
        Me._Label_13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_9
        '
        Me._Label_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.Color.Black
        Me._Label_9.Location = New System.Drawing.Point(752, 96)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.Size = New System.Drawing.Size(57, 17)
        Me._Label_9.TabIndex = 19
        Me._Label_9.Tag = "Stock price"
        Me._Label_9.Text = "Giá  vốn"
        Me._Label_9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.Color.Black
        Me._Label_8.Location = New System.Drawing.Point(696, 96)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(57, 17)
        Me._Label_8.TabIndex = 18
        Me._Label_8.Tag = "price"
        Me._Label_8.Text = "Giá bán"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.Color.Black
        Me._Label_5.Location = New System.Drawing.Point(472, 96)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(97, 17)
        Me._Label_5.TabIndex = 17
        Me._Label_5.Tag = "User Name"
        Me._Label_5.Text = "Mã số thuế"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(224, 96)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(249, 17)
        Me._Label_4.TabIndex = 16
        Me._Label_4.Tag = "Customer name / Goods name"
        Me._Label_4.Text = "Tên khách / Tên hàng"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.Black
        Me._Label_2.Location = New System.Drawing.Point(32, 80)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(193, 17)
        Me._Label_2.TabIndex = 15
        Me._Label_2.Tag = "Vouchers, Invoice"
        Me._Label_2.Text = "Chứng từ, hoá đơn"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(96, 96)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(57, 17)
        Me._Label_1.TabIndex = 14
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
        Me._Label_0.Location = New System.Drawing.Point(8, 80)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(25, 33)
        Me._Label_0.TabIndex = 13
        Me._Label_0.Tag = "No."
        Me._Label_0.Text = "STT"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.Grd.Location = New System.Drawing.Point(8, 112)
        Me.Grd.Name = "Grd"
        Me.Grd.Row = 0
        Me.Grd.Rows = 0
        Me.Grd.Selectable = True
        Me.Grd.SelectedTextColor = System.Drawing.Color.White
        Me.Grd.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.Grd.ShowBorder = True
        Me.Grd.ShowFocusRect = False
        Me.Grd.Size = New System.Drawing.Size(1001, 516)
        Me.Grd.SortType = ListViewEx.SortTypes.InsertionSort
        Me.Grd.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.Grd.TabIndex = 10
        '
        'FrmBangke
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1015, 677)
        Me.Controls.Add(Me.Grd)
        Me.Controls.Add(Me.TxtTen)
        Me.Controls.Add(Me.Chk)
        Me.Controls.Add(Me.TxtSohieu)
        Me.Controls.Add(Me.Cbooption)
        Me.Controls.Add(Me.ChkTen)
        Me.Controls.Add(Me.CboLai)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me.CboSole)
        Me.Controls.Add(Me._Command1_2)
        Me.Controls.Add(Me.CboTL)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me.GauGe)
        Me.Controls.Add(Me._Frame_4)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.LbTen)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_20)
        Me.Controls.Add(Me._Label_19)
        Me.Controls.Add(Me._Label_18)
        Me.Controls.Add(Me._Label_15)
        Me.Controls.Add(Me._Label_12)
        Me.Controls.Add(Me._Label_11)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Label_26)
        Me.Controls.Add(Me._Label_25)
        Me.Controls.Add(Me._Label_16)
        Me.Controls.Add(Me._Label_14)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me._Label_9)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_5)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBangke"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Inventory table"
        Me.Text = "Bảng tồn kho"
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
		Me.Label(6) = _Label_6
		Me.Label(3) = _Label_3
		Me.Label(20) = _Label_20
		Me.Label(19) = _Label_19
		Me.Label(18) = _Label_18
		Me.Label(15) = _Label_15
		Me.Label(12) = _Label_12
		Me.Label(11) = _Label_11
		Me.Label(10) = _Label_10
		Me.Label(26) = _Label_26
		Me.Label(25) = _Label_25
		Me.Label(16) = _Label_16
		Me.Label(14) = _Label_14
		Me.Label(13) = _Label_13
		Me.Label(9) = _Label_9
		Me.Label(8) = _Label_8
		Me.Label(5) = _Label_5
		Me.Label(4) = _Label_4
		Me.Label(2) = _Label_2
		Me.Label(1) = _Label_1
		Me.Label(0) = _Label_0
	End Sub
	Sub InitializeFrame()
		Me.Frame(4) = _Frame_4
	End Sub
	Sub InitializeCommand1()
		Me.Command1(2) = _Command1_2
		Me.Command1(0) = _Command1_0
		Me.Command1(1) = _Command1_1
	End Sub
	Sub InitializeCommand()
		Me.Command(2) = _Command_2
		Me.Command(0) = _Command_0
		Me.Command(1) = _Command_1
	End Sub
	Sub InitializeCboThang()
		Me.CboThang(0) = _CboThang_0
		Me.CboThang(1) = _CboThang_1
	End Sub
#End Region 
End Class
