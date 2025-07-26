<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSochitiet
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		Initializetxtdauky()
		InitializetxtShTk()
		Initializemnct()
		InitializeOptTG()
		InitializeMedNgay()
		InitializeLabel()
		InitializeFrame()
		InitializeCommand()
		InitializeCmdTK1()
		InitializeCmdTK()
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
    Public WithEvents TxtSohieu As System.Windows.Forms.TextBox
    Public WithEvents ChkKH As System.Windows.Forms.CheckBox
    Private WithEvents _CmdTK_0 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _txtdauky_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtdauky_0 As System.Windows.Forms.TextBox
    Private WithEvents _txtShTk_1 As System.Windows.Forms.TextBox
    Public WithEvents Chk As System.Windows.Forms.CheckBox
    Private WithEvents _CmdTK1_0 As System.Windows.Forms.Button
    Private WithEvents _CboThang_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _MedNgay_0 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _OptTG_1 As System.Windows.Forms.RadioButton
    Private WithEvents _OptTG_0 As System.Windows.Forms.RadioButton
    Private WithEvents _CboThang_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _MedNgay_1 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _Label_18 As System.Windows.Forms.Label
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Private WithEvents _Frame_4 As System.Windows.Forms.Panel
    Private WithEvents _txtShTk_0 As System.Windows.Forms.TextBox
    Public WithEvents Grd As ListViewEx.ListviewExt
    Public WithEvents GauGe As System.Windows.Forms.ProgressBar
    Private WithEvents _CmdTK_1 As System.Windows.Forms.Button
    Private WithEvents _CmdTK1_1 As System.Windows.Forms.Button
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Private WithEvents _Label_9 As System.Windows.Forms.Label
    Public CboThang(1) As ComboBoxEx.ComboBoxExt
    Public CmdTK(1) As System.Windows.Forms.Button
    Public CmdTK1(1) As System.Windows.Forms.Button
    Public Command(2) As System.Windows.Forms.Button
    Public Command1(2) As System.Windows.Forms.Button
    Public Frame(4) As System.Windows.Forms.Panel
    Public Label(18) As System.Windows.Forms.Label
    Public MedNgay(1) As System.Windows.Forms.MaskedTextBox
    Public OptTG(1) As System.Windows.Forms.RadioButton
    Public mnct(0) As System.Windows.Forms.ToolStripMenuItem
    Public txtShTk(1) As System.Windows.Forms.TextBox
    Public txtdauky(1) As System.Windows.Forms.TextBox
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSochitiet))
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip
        Me.mnPU = New System.Windows.Forms.ToolStripMenuItem
        Me._mnct_0 = New System.Windows.Forms.ToolStripMenuItem
        Me.TxtSohieu = New System.Windows.Forms.TextBox
        Me.ChkKH = New System.Windows.Forms.CheckBox
        Me._CmdTK_0 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._txtdauky_1 = New System.Windows.Forms.TextBox
        Me._txtdauky_0 = New System.Windows.Forms.TextBox
        Me._txtShTk_1 = New System.Windows.Forms.TextBox
        Me.Chk = New System.Windows.Forms.CheckBox
        Me._CmdTK1_0 = New System.Windows.Forms.Button
        Me._Frame_4 = New System.Windows.Forms.Panel
        Me._CboThang_0 = New ComboBoxEx.ComboBoxExt
        Me._MedNgay_0 = New System.Windows.Forms.MaskedTextBox
        Me._OptTG_1 = New System.Windows.Forms.RadioButton
        Me._OptTG_0 = New System.Windows.Forms.RadioButton
        Me._CboThang_1 = New ComboBoxEx.ComboBoxExt
        Me._MedNgay_1 = New System.Windows.Forms.MaskedTextBox
        Me._Label_18 = New System.Windows.Forms.Label
        Me._Label_17 = New System.Windows.Forms.Label
        Me._txtShTk_0 = New System.Windows.Forms.TextBox
        Me.GauGe = New System.Windows.Forms.ProgressBar
        Me._CmdTK_1 = New System.Windows.Forms.Button
        Me._CmdTK1_1 = New System.Windows.Forms.Button
        Me._Label_13 = New System.Windows.Forms.Label
        Me._Label_12 = New System.Windows.Forms.Label
        Me._Label_11 = New System.Windows.Forms.Label
        Me._Label_10 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Label_5 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Label_14 = New System.Windows.Forms.Label
        Me._Label_9 = New System.Windows.Forms.Label
        Me.Grd = New ListViewEx.ListviewExt
        Me.Label1 = New System.Windows.Forms.Label
        Me.lb_soct = New System.Windows.Forms.Label
        Me.MainMenu1.SuspendLayout()
        Me._Frame_4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnPU})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(745, 24)
        Me.MainMenu1.TabIndex = 42
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
        Me._mnct_0.Tag = "Edit Voucher"
        Me._mnct_0.Text = "Sửa chứng từ"
        '
        'TxtSohieu
        '
        Me.TxtSohieu.AcceptsReturn = True
        Me.TxtSohieu.BackColor = System.Drawing.SystemColors.Window
        Me.TxtSohieu.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSohieu.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSohieu.Location = New System.Drawing.Point(288, 56)
        Me.TxtSohieu.MaxLength = 0
        Me.TxtSohieu.Name = "TxtSohieu"
        Me.TxtSohieu.Size = New System.Drawing.Size(57, 21)
        Me.TxtSohieu.TabIndex = 40
        '
        'ChkKH
        '
        Me.ChkKH.BackColor = System.Drawing.Color.Transparent
        Me.ChkKH.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkKH.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkKH.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkKH.Location = New System.Drawing.Point(208, 56)
        Me.ChkKH.Name = "ChkKH"
        Me.ChkKH.Size = New System.Drawing.Size(81, 17)
        Me.ChkKH.TabIndex = 41
        Me.ChkKH.Tag = "Customer"
        Me.ChkKH.Text = "Khách hàng"
        Me.ChkKH.UseVisualStyleBackColor = False
        '
        '_CmdTK_0
        '
        Me._CmdTK_0.Image = CType(resources.GetObject("_CmdTK_0.Image"), System.Drawing.Image)
        Me._CmdTK_0.Location = New System.Drawing.Point(168, 28)
        Me._CmdTK_0.Name = "_CmdTK_0"
        Me._CmdTK_0.Size = New System.Drawing.Size(25, 25)
        Me._CmdTK_0.TabIndex = 38
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(506, 551)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 37
        Me._Command_2.Tag = "Save"
        Me._Command_2.Text = "&Ghi"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(664, 551)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 36
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.list16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(585, 551)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 35
        Me._Command_0.Tag = "Listed"
        Me._Command_0.Text = "&Liệt kê"
        '
        '_txtdauky_1
        '
        Me._txtdauky_1.AcceptsReturn = True
        Me._txtdauky_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtdauky_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtdauky_1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtdauky_1.Location = New System.Drawing.Point(520, 56)
        Me._txtdauky_1.MaxLength = 0
        Me._txtdauky_1.Name = "_txtdauky_1"
        Me._txtdauky_1.Size = New System.Drawing.Size(97, 22)
        Me._txtdauky_1.TabIndex = 12
        Me._txtdauky_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtdauky_0
        '
        Me._txtdauky_0.AcceptsReturn = True
        Me._txtdauky_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtdauky_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtdauky_0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtdauky_0.Location = New System.Drawing.Point(424, 56)
        Me._txtdauky_0.MaxLength = 0
        Me._txtdauky_0.Name = "_txtdauky_0"
        Me._txtdauky_0.Size = New System.Drawing.Size(97, 22)
        Me._txtdauky_0.TabIndex = 11
        Me._txtdauky_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtShTk_1
        '
        Me._txtShTk_1.AcceptsReturn = True
        Me._txtShTk_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_1.Location = New System.Drawing.Point(88, 56)
        Me._txtShTk_1.MaxLength = 0
        Me._txtShTk_1.Name = "_txtShTk_1"
        Me._txtShTk_1.Size = New System.Drawing.Size(73, 22)
        Me._txtShTk_1.TabIndex = 3
        '
        'Chk
        '
        Me.Chk.BackColor = System.Drawing.Color.Transparent
        Me.Chk.Cursor = System.Windows.Forms.Cursors.Default
        Me.Chk.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk.Location = New System.Drawing.Point(8, 56)
        Me.Chk.Name = "Chk"
        Me.Chk.Size = New System.Drawing.Size(73, 17)
        Me.Chk.TabIndex = 2
        Me.Chk.Tag = "by Ref. Acc."
        Me.Chk.Text = "Đối ứng"
        Me.Chk.UseVisualStyleBackColor = False
        '
        '_CmdTK1_0
        '
        Me._CmdTK1_0.BackColor = System.Drawing.SystemColors.Control
        Me._CmdTK1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CmdTK1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CmdTK1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CmdTK1_0.Image = CType(resources.GetObject("_CmdTK1_0.Image"), System.Drawing.Image)
        Me._CmdTK1_0.Location = New System.Drawing.Point(168, 28)
        Me._CmdTK1_0.Name = "_CmdTK1_0"
        Me._CmdTK1_0.Size = New System.Drawing.Size(25, 25)
        Me._CmdTK1_0.TabIndex = 1
        Me._CmdTK1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._CmdTK1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._CmdTK1_0.UseVisualStyleBackColor = False
        '
        '_Frame_4
        '
        Me._Frame_4.BackColor = System.Drawing.Color.Transparent
        Me._Frame_4.Controls.Add(Me._CboThang_0)
        Me._Frame_4.Controls.Add(Me._MedNgay_0)
        Me._Frame_4.Controls.Add(Me._OptTG_1)
        Me._Frame_4.Controls.Add(Me._OptTG_0)
        Me._Frame_4.Controls.Add(Me._CboThang_1)
        Me._Frame_4.Controls.Add(Me._MedNgay_1)
        Me._Frame_4.Controls.Add(Me._Label_18)
        Me._Frame_4.Controls.Add(Me._Label_17)
        Me._Frame_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Frame_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_4.Location = New System.Drawing.Point(208, 24)
        Me._Frame_4.Name = "_Frame_4"
        Me._Frame_4.Size = New System.Drawing.Size(529, 33)
        Me._Frame_4.TabIndex = 17
        Me._Frame_4.Text = "Sổ kế toán tổng hợp và báo cáo Tài chính"
        '
        '_CboThang_0
        '
        Me._CboThang_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_0.Location = New System.Drawing.Point(64, 8)
        Me._CboThang_0.Name = "_CboThang_0"
        Me._CboThang_0.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_0.TabIndex = 6
        '
        '_MedNgay_0
        '
        Me._MedNgay_0.AllowPromptAsInput = False
        Me._MedNgay_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_0.Location = New System.Drawing.Point(344, 8)
        Me._MedNgay_0.Mask = "00/00/0000"
        Me._MedNgay_0.Name = "_MedNgay_0"
        Me._MedNgay_0.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_0.TabIndex = 9
        '
        '_OptTG_1
        '
        Me._OptTG_1.BackColor = System.Drawing.Color.Transparent
        Me._OptTG_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptTG_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptTG_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptTG_1.Location = New System.Drawing.Point(281, 11)
        Me._OptTG_1.Name = "_OptTG_1"
        Me._OptTG_1.Size = New System.Drawing.Size(65, 17)
        Me._OptTG_1.TabIndex = 8
        Me._OptTG_1.TabStop = True
        Me._OptTG_1.Tag = "FROM"
        Me._OptTG_1.Text = "Từ ngày"
        Me._OptTG_1.UseVisualStyleBackColor = False
        '
        '_OptTG_0
        '
        Me._OptTG_0.BackColor = System.Drawing.Color.Transparent
        Me._OptTG_0.Checked = True
        Me._OptTG_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptTG_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptTG_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptTG_0.Location = New System.Drawing.Point(-1, 11)
        Me._OptTG_0.Name = "_OptTG_0"
        Me._OptTG_0.Size = New System.Drawing.Size(70, 17)
        Me._OptTG_0.TabIndex = 5
        Me._OptTG_0.TabStop = True
        Me._OptTG_0.Tag = "FROM"
        Me._OptTG_0.Text = "Từ tháng"
        Me._OptTG_0.UseVisualStyleBackColor = False
        '
        '_CboThang_1
        '
        Me._CboThang_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_1.Location = New System.Drawing.Point(200, 8)
        Me._CboThang_1.Name = "_CboThang_1"
        Me._CboThang_1.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_1.TabIndex = 7
        '
        '_MedNgay_1
        '
        Me._MedNgay_1.AllowPromptAsInput = False
        Me._MedNgay_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_1.Location = New System.Drawing.Point(464, 8)
        Me._MedNgay_1.Mask = "00/00/0000"
        Me._MedNgay_1.Name = "_MedNgay_1"
        Me._MedNgay_1.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_1.TabIndex = 10
        '
        '_Label_18
        '
        Me._Label_18.BackColor = System.Drawing.Color.Transparent
        Me._Label_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_18.Location = New System.Drawing.Point(403, 11)
        Me._Label_18.Name = "_Label_18"
        Me._Label_18.Size = New System.Drawing.Size(55, 17)
        Me._Label_18.TabIndex = 30
        Me._Label_18.Tag = "to"
        Me._Label_18.Text = "Đến ngày"
        Me._Label_18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.Color.Transparent
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_17.Location = New System.Drawing.Point(143, 11)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(58, 17)
        Me._Label_17.TabIndex = 18
        Me._Label_17.Tag = "to"
        Me._Label_17.Text = "Đến tháng"
        Me._Label_17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_txtShTk_0
        '
        Me._txtShTk_0.AcceptsReturn = True
        Me._txtShTk_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_0.Location = New System.Drawing.Point(88, 32)
        Me._txtShTk_0.MaxLength = 0
        Me._txtShTk_0.Name = "_txtShTk_0"
        Me._txtShTk_0.Size = New System.Drawing.Size(73, 22)
        Me._txtShTk_0.TabIndex = 0
        '
        'GauGe
        '
        Me.GauGe.Location = New System.Drawing.Point(8, 555)
        Me.GauGe.Name = "GauGe"
        Me.GauGe.Size = New System.Drawing.Size(369, 17)
        Me.GauGe.TabIndex = 19
        '
        '_CmdTK_1
        '
        Me._CmdTK_1.Image = CType(resources.GetObject("_CmdTK_1.Image"), System.Drawing.Image)
        Me._CmdTK_1.Location = New System.Drawing.Point(168, 52)
        Me._CmdTK_1.Name = "_CmdTK_1"
        Me._CmdTK_1.Size = New System.Drawing.Size(25, 25)
        Me._CmdTK_1.TabIndex = 39
        '
        '_CmdTK1_1
        '
        Me._CmdTK1_1.BackColor = System.Drawing.SystemColors.Control
        Me._CmdTK1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CmdTK1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CmdTK1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CmdTK1_1.Image = CType(resources.GetObject("_CmdTK1_1.Image"), System.Drawing.Image)
        Me._CmdTK1_1.Location = New System.Drawing.Point(168, 52)
        Me._CmdTK1_1.Name = "_CmdTK1_1"
        Me._CmdTK1_1.Size = New System.Drawing.Size(25, 25)
        Me._CmdTK1_1.TabIndex = 4
        Me._CmdTK1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._CmdTK1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._CmdTK1_1.UseVisualStyleBackColor = False
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.Color.Black
        Me._Label_13.Location = New System.Drawing.Point(424, 80)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(313, 17)
        Me._Label_13.TabIndex = 21
        Me._Label_13.Tag = "Amount"
        Me._Label_13.Text = "Số tiền"
        Me._Label_13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_12
        '
        Me._Label_12.BackColor = System.Drawing.Color.Transparent
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_12.Location = New System.Drawing.Point(8, 32)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.Size = New System.Drawing.Size(65, 17)
        Me._Label_12.TabIndex = 34
        Me._Label_12.Tag = "Account"
        Me._Label_12.Text = "Tài khoản"
        Me._Label_12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.Transparent
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_11.Location = New System.Drawing.Point(522, 531)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(97, 17)
        Me._Label_11.TabIndex = 33
        Me._Label_11.Tag = "Residual"
        Me._Label_11.Text = "Tồn cuối kỳ:"
        Me._Label_11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.Transparent
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_10.Location = New System.Drawing.Point(618, 531)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(103, 17)
        Me._Label_10.TabIndex = 32
        Me._Label_10.Tag = "to"
        Me._Label_10.Text = "0"
        Me._Label_10.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me._Label_0.TabIndex = 29
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
        Me._Label_1.Location = New System.Drawing.Point(32, 96)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(81, 17)
        Me._Label_1.TabIndex = 28
        Me._Label_1.Tag = "Code"
        Me._Label_1.Text = "Số hiệu"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.Black
        Me._Label_2.Location = New System.Drawing.Point(168, 80)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(209, 33)
        Me._Label_2.TabIndex = 27
        Me._Label_2.Tag = "Description"
        Me._Label_2.Text = "Diễn giải"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.Black
        Me._Label_3.Location = New System.Drawing.Point(376, 80)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(49, 33)
        Me._Label_3.TabIndex = 26
        Me._Label_3.Tag = "by Ref. Acc."
        Me._Label_3.Text = "T.khoản đối ứng"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(424, 96)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(97, 17)
        Me._Label_4.TabIndex = 25
        Me._Label_4.Tag = "Debt"
        Me._Label_4.Text = "Nợ"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.Color.Black
        Me._Label_5.Location = New System.Drawing.Point(520, 96)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(97, 17)
        Me._Label_5.TabIndex = 24
        Me._Label_5.Tag = "Credit"
        Me._Label_5.Text = "Có"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.Color.Black
        Me._Label_6.Location = New System.Drawing.Point(616, 96)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(121, 17)
        Me._Label_6.TabIndex = 23
        Me._Label_6.Tag = "Residual"
        Me._Label_6.Text = "Tồn"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(112, 96)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(57, 17)
        Me._Label_7.TabIndex = 22
        Me._Label_7.Tag = "Date"
        Me._Label_7.Text = "Ngày"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.Color.Black
        Me._Label_14.Location = New System.Drawing.Point(32, 80)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(137, 17)
        Me._Label_14.TabIndex = 20
        Me._Label_14.Tag = "Voucher"
        Me._Label_14.Text = "Chứng từ"
        Me._Label_14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_9
        '
        Me._Label_9.BackColor = System.Drawing.Color.Transparent
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_9.Location = New System.Drawing.Point(328, 59)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.Size = New System.Drawing.Size(97, 17)
        Me._Label_9.TabIndex = 31
        Me._Label_9.Tag = "Beginning"
        Me._Label_9.Text = "Tồn đầu kỳ:"
        Me._Label_9.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.Grd.GridColor = System.Drawing.Color.Red
        Me.Grd.GridLines = ListViewEx.GLGridLines.gridHorizontal
        Me.Grd.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me.Grd.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me.Grd.HeaderHeight = 22
        Me.Grd.HeaderVisible = True
        Me.Grd.HeaderWordWrap = False
        Me.Grd.HotColumnTracking = False
        Me.Grd.HotItemTracking = False
        Me.Grd.HotTrackingColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
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
        Me.Grd.Size = New System.Drawing.Size(729, 416)
        Me.Grd.SortType = ListViewEx.SortTypes.InsertionSort
        Me.Grd.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.Grd.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 531)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 43
        Me.Label1.Tag = "Total :"
        Me.Label1.Text = "Số chứng từ :"
        '
        'lb_soct
        '
        Me.lb_soct.AutoSize = True
        Me.lb_soct.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_soct.Location = New System.Drawing.Point(111, 532)
        Me.lb_soct.Name = "lb_soct"
        Me.lb_soct.Size = New System.Drawing.Size(13, 14)
        Me.lb_soct.TabIndex = 44
        Me.lb_soct.Text = "0"
        '
        'FrmSochitiet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(745, 581)
        Me.Controls.Add(Me.lb_soct)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Grd)
        Me.Controls.Add(Me.TxtSohieu)
        Me.Controls.Add(Me.ChkKH)
        Me.Controls.Add(Me._CmdTK_0)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._txtShTk_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._txtdauky_1)
        Me.Controls.Add(Me._txtdauky_0)
        Me.Controls.Add(Me.Chk)
        Me.Controls.Add(Me._CmdTK1_0)
        Me.Controls.Add(Me._Frame_4)
        Me.Controls.Add(Me._txtShTk_0)
        Me.Controls.Add(Me.GauGe)
        Me.Controls.Add(Me._CmdTK_1)
        Me.Controls.Add(Me._CmdTK1_1)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me._Label_12)
        Me.Controls.Add(Me._Label_11)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_5)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_14)
        Me.Controls.Add(Me._Label_9)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSochitiet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Ledger"
        Me.Text = "Sổ chi tiết"
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me._Frame_4.ResumeLayout(False)
        Me._Frame_4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub Initializetxtdauky()
		Me.txtdauky(1) = _txtdauky_1
		Me.txtdauky(0) = _txtdauky_0
	End Sub
	Sub InitializetxtShTk()
		Me.txtShTk(1) = _txtShTk_1
		Me.txtShTk(0) = _txtShTk_0
	End Sub
	Sub Initializemnct()
		Me.mnct(0) = _mnct_0
	End Sub
	Sub InitializeOptTG()
		Me.OptTG(1) = _OptTG_1
		Me.OptTG(0) = _OptTG_0
	End Sub
	Sub InitializeMedNgay()
		Me.MedNgay(0) = _MedNgay_0
		Me.MedNgay(1) = _MedNgay_1
	End Sub
	Sub InitializeLabel()
		Me.Label(18) = _Label_18
		Me.Label(17) = _Label_17
		Me.Label(13) = _Label_13
		Me.Label(12) = _Label_12
		Me.Label(11) = _Label_11
		Me.Label(10) = _Label_10
		Me.Label(0) = _Label_0
		Me.Label(1) = _Label_1
		Me.Label(2) = _Label_2
		Me.Label(3) = _Label_3
		Me.Label(4) = _Label_4
		Me.Label(5) = _Label_5
		Me.Label(6) = _Label_6
		Me.Label(7) = _Label_7
		Me.Label(14) = _Label_14
		Me.Label(9) = _Label_9
	End Sub
	Sub InitializeFrame()
		Me.Frame(4) = _Frame_4
	End Sub	
	Sub InitializeCommand()
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
	Sub InitializeCmdTK1()
		Me.CmdTK1(0) = _CmdTK1_0
		Me.CmdTK1(1) = _CmdTK1_1
	End Sub
	Sub InitializeCmdTK()
		Me.CmdTK(0) = _CmdTK_0
		Me.CmdTK(1) = _CmdTK_1
	End Sub
	Sub InitializeCboThang()
		Me.CboThang(0) = _CboThang_0
		Me.CboThang(1) = _CboThang_1
    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lb_soct As System.Windows.Forms.Label
#End Region 
End Class
