<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSothu
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializetxtShTk()
		InitializeOptTG()
		InitializeMedNgay()
		InitializeLabel()
		InitializeFrame()
		InitializeCommand1()
		InitializeCommand()
		InitializeCmdTK1()
		InitializeCmdTK()
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
    Private WithEvents _CmdTK_4 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Private WithEvents _Command1_2 As System.Windows.Forms.Button
    Private WithEvents _Command1_3 As System.Windows.Forms.Button
    Private WithEvents _txtShTk_1 As System.Windows.Forms.TextBox
    Private WithEvents _CmdTK1_0 As System.Windows.Forms.Button
    Private WithEvents _MedNgay_0 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _OptTG_1 As System.Windows.Forms.RadioButton
    Private WithEvents _MedNgay_1 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _Label_18 As System.Windows.Forms.Label
    Private WithEvents _Frame_4 As System.Windows.Forms.Panel
    Private WithEvents _txtShTk_0 As System.Windows.Forms.TextBox
    Public WithEvents Grd As ListviewEx.ListviewExt
    Public WithEvents GauGe As System.Windows.Forms.ProgressBar
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Public CmdTK(4) As System.Windows.Forms.Button
    Public CmdTK1(0) As System.Windows.Forms.Button
    Public Command(3) As System.Windows.Forms.Button
    Public Command1(3) As System.Windows.Forms.Button
    Public Frame(4) As System.Windows.Forms.Panel
    Public Label(18) As System.Windows.Forms.Label
    Public MedNgay(1) As System.Windows.Forms.MaskedTextBox
    Public OptTG(1) As System.Windows.Forms.RadioButton
    Public txtShTk(1) As System.Windows.Forms.TextBox
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSothu))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me._Command1_3 = New System.Windows.Forms.Button()
        Me._txtShTk_1 = New System.Windows.Forms.TextBox()
        Me._Frame_4 = New System.Windows.Forms.Panel()
        Me._MedNgay_0 = New System.Windows.Forms.MaskedTextBox()
        Me._OptTG_1 = New System.Windows.Forms.RadioButton()
        Me._MedNgay_1 = New System.Windows.Forms.MaskedTextBox()
        Me._Label_18 = New System.Windows.Forms.Label()
        Me._txtShTk_0 = New System.Windows.Forms.TextBox()
        Me.GauGe = New System.Windows.Forms.ProgressBar()
        Me._Label_3 = New System.Windows.Forms.Label()
        Me._Label_6 = New System.Windows.Forms.Label()
        Me._Label_12 = New System.Windows.Forms.Label()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me._Label_1 = New System.Windows.Forms.Label()
        Me._Label_2 = New System.Windows.Forms.Label()
        Me._Label_7 = New System.Windows.Forms.Label()
        Me._Label_14 = New System.Windows.Forms.Label()
        Me._CmdTK_4 = New System.Windows.Forms.Button()
        Me._Command_3 = New System.Windows.Forms.Button()
        Me._Command_2 = New System.Windows.Forms.Button()
        Me._Command1_1 = New System.Windows.Forms.Button()
        Me._Command1_0 = New System.Windows.Forms.Button()
        Me._Command1_2 = New System.Windows.Forms.Button()
        Me._CmdTK1_0 = New System.Windows.Forms.Button()
        Me.Grd = New ListViewEx.ListviewExt()
        Me._Frame_4.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(424, 32)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 7
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        '
        '_Command_0
        '
        Me._Command_0.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Liet_ke
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(346, 32)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 2
        Me._Command_0.Tag = "Listed"
        Me._Command_0.Text = "&Liệt kê"
        '
        '_Command1_3
        '
        Me._Command1_3.BackColor = System.Drawing.Color.Silver
        Me._Command1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_3.Location = New System.Drawing.Point(264, 32)
        Me._Command1_3.Name = "_Command1_3"
        Me._Command1_3.Size = New System.Drawing.Size(73, 25)
        Me._Command1_3.TabIndex = 9
        Me._Command1_3.TabStop = False
        Me._Command1_3.Text = "In &toàn bộ"
        Me._Command1_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_3.UseVisualStyleBackColor = False
        Me._Command1_3.Visible = False
        '
        '_txtShTk_1
        '
        Me._txtShTk_1.AcceptsReturn = True
        Me._txtShTk_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_1.Location = New System.Drawing.Point(104, 32)
        Me._txtShTk_1.MaxLength = 0
        Me._txtShTk_1.Name = "_txtShTk_1"
        Me._txtShTk_1.Size = New System.Drawing.Size(73, 22)
        Me._txtShTk_1.TabIndex = 4
        '
        '_Frame_4
        '
        Me._Frame_4.BackColor = System.Drawing.Color.Transparent
        Me._Frame_4.Controls.Add(Me._MedNgay_0)
        Me._Frame_4.Controls.Add(Me._OptTG_1)
        Me._Frame_4.Controls.Add(Me._MedNgay_1)
        Me._Frame_4.Controls.Add(Me._Label_18)
        Me._Frame_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Frame_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_4.Location = New System.Drawing.Point(254, 8)
        Me._Frame_4.Name = "_Frame_4"
        Me._Frame_4.Size = New System.Drawing.Size(243, 25)
        Me._Frame_4.TabIndex = 16
        Me._Frame_4.Text = "Sổ kế toán tổng hợp và báo cáo Tài chính"
        '
        '_MedNgay_0
        '
        Me._MedNgay_0.AllowPromptAsInput = False
        Me._MedNgay_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_0.Location = New System.Drawing.Point(57, 0)
        Me._MedNgay_0.Mask = "00/00/0000"
        Me._MedNgay_0.Name = "_MedNgay_0"
        Me._MedNgay_0.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_0.TabIndex = 0
        '
        '_OptTG_1
        '
        Me._OptTG_1.BackColor = System.Drawing.Color.Transparent
        Me._OptTG_1.Checked = True
        Me._OptTG_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptTG_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptTG_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptTG_1.Location = New System.Drawing.Point(-16, 0)
        Me._OptTG_1.Name = "_OptTG_1"
        Me._OptTG_1.Size = New System.Drawing.Size(65, 17)
        Me._OptTG_1.TabIndex = 14
        Me._OptTG_1.TabStop = True
        Me._OptTG_1.Tag = "FROM"
        Me._OptTG_1.Text = "Từ ngày"
        Me._OptTG_1.UseVisualStyleBackColor = False
        '
        '_MedNgay_1
        '
        Me._MedNgay_1.AllowPromptAsInput = False
        Me._MedNgay_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_1.Location = New System.Drawing.Point(181, 0)
        Me._MedNgay_1.Mask = "00/00/0000"
        Me._MedNgay_1.Name = "_MedNgay_1"
        Me._MedNgay_1.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_1.TabIndex = 1
        '
        '_Label_18
        '
        Me._Label_18.BackColor = System.Drawing.Color.Transparent
        Me._Label_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_18.Location = New System.Drawing.Point(119, 0)
        Me._Label_18.Name = "_Label_18"
        Me._Label_18.Size = New System.Drawing.Size(56, 17)
        Me._Label_18.TabIndex = 23
        Me._Label_18.Tag = "to"
        Me._Label_18.Text = "Đến ngày"
        Me._Label_18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_txtShTk_0
        '
        Me._txtShTk_0.AcceptsReturn = True
        Me._txtShTk_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_0.Location = New System.Drawing.Point(104, 8)
        Me._txtShTk_0.MaxLength = 0
        Me._txtShTk_0.Name = "_txtShTk_0"
        Me._txtShTk_0.Size = New System.Drawing.Size(73, 20)
        Me._txtShTk_0.TabIndex = 11
        Me._txtShTk_0.Text = "KT"
        '
        'GauGe
        '
        Me.GauGe.Location = New System.Drawing.Point(8, 575)
        Me.GauGe.Name = "GauGe"
        Me.GauGe.Size = New System.Drawing.Size(489, 17)
        Me.GauGe.TabIndex = 17
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.Transparent
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_3.Location = New System.Drawing.Point(8, 32)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(89, 17)
        Me._Label_3.TabIndex = 26
        Me._Label_3.Tag = "Bill code"
        Me._Label_3.Text = "Số phiếu muốn in"
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.Color.Black
        Me._Label_6.Location = New System.Drawing.Point(376, 64)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(121, 33)
        Me._Label_6.TabIndex = 25
        Me._Label_6.Tag = "Generate"
        Me._Label_6.Text = "Số phát sinh"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_12
        '
        Me._Label_12.BackColor = System.Drawing.Color.Transparent
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_12.Location = New System.Drawing.Point(8, 8)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.Size = New System.Drawing.Size(89, 17)
        Me._Label_12.TabIndex = 24
        Me._Label_12.Tag = "Payer"
        Me._Label_12.Text = "Người nộp tiền"
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
        Me._Label_0.TabIndex = 22
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
        Me._Label_1.Size = New System.Drawing.Size(81, 17)
        Me._Label_1.TabIndex = 21
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
        Me._Label_2.Location = New System.Drawing.Point(168, 64)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(209, 33)
        Me._Label_2.TabIndex = 20
        Me._Label_2.Tag = "Description"
        Me._Label_2.Text = "Diễn giải"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(112, 80)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(57, 17)
        Me._Label_7.TabIndex = 19
        Me._Label_7.Tag = "Date"
        Me._Label_7.Text = "Ngày GS"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.Color.Black
        Me._Label_14.Location = New System.Drawing.Point(32, 64)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(137, 17)
        Me._Label_14.TabIndex = 18
        Me._Label_14.Tag = "Voucher"
        Me._Label_14.Text = "Chứng từ"
        Me._Label_14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_CmdTK_4
        '
        Me._CmdTK_4.Image = CType(resources.GetObject("_CmdTK_4.Image"), System.Drawing.Image)
        Me._CmdTK_4.Location = New System.Drawing.Point(183, 8)
        Me._CmdTK_4.Name = "_CmdTK_4"
        Me._CmdTK_4.Size = New System.Drawing.Size(23, 21)
        Me._CmdTK_4.TabIndex = 12
        '
        '_Command_3
        '
        Me._Command_3.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Print_all
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(264, 32)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(78, 25)
        Me._Command_3.TabIndex = 6
        Me._Command_3.Tag = "Print all"
        Me._Command_3.Text = "I&n toàn bộ"
        '
        '_Command_2
        '
        Me._Command_2.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Print
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(184, 32)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(72, 25)
        Me._Command_2.TabIndex = 5
        Me._Command_2.Tag = "Print"
        Me._Command_2.Text = "&In"
        '
        '_Command1_1
        '
        Me._Command1_1.BackColor = System.Drawing.Color.Silver
        Me._Command1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_1.Image = CType(resources.GetObject("_Command1_1.Image"), System.Drawing.Image)
        Me._Command1_1.Location = New System.Drawing.Point(424, 32)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(73, 25)
        Me._Command1_1.TabIndex = 10
        Me._Command1_1.TabStop = False
        Me._Command1_1.Tag = "&Return"
        Me._Command1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_1.UseVisualStyleBackColor = False
        Me._Command1_1.Visible = False
        '
        '_Command1_0
        '
        Me._Command1_0.BackColor = System.Drawing.Color.Silver
        Me._Command1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_0.Image = CType(resources.GetObject("_Command1_0.Image"), System.Drawing.Image)
        Me._Command1_0.Location = New System.Drawing.Point(349, 32)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(68, 25)
        Me._Command1_0.TabIndex = 3
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&List"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        '_Command1_2
        '
        Me._Command1_2.BackColor = System.Drawing.Color.Silver
        Me._Command1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_2.Image = CType(resources.GetObject("_Command1_2.Image"), System.Drawing.Image)
        Me._Command1_2.Location = New System.Drawing.Point(184, 32)
        Me._Command1_2.Name = "_Command1_2"
        Me._Command1_2.Size = New System.Drawing.Size(73, 25)
        Me._Command1_2.TabIndex = 8
        Me._Command1_2.TabStop = False
        Me._Command1_2.Tag = "&Print"
        Me._Command1_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_2.UseVisualStyleBackColor = False
        Me._Command1_2.Visible = False
        '
        '_CmdTK1_0
        '
        Me._CmdTK1_0.BackColor = System.Drawing.SystemColors.Control
        Me._CmdTK1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CmdTK1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CmdTK1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CmdTK1_0.Image = CType(resources.GetObject("_CmdTK1_0.Image"), System.Drawing.Image)
        Me._CmdTK1_0.Location = New System.Drawing.Point(515, 57)
        Me._CmdTK1_0.Name = "_CmdTK1_0"
        Me._CmdTK1_0.Size = New System.Drawing.Size(25, 25)
        Me._CmdTK1_0.TabIndex = 13
        Me._CmdTK1_0.TabStop = False
        Me._CmdTK1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._CmdTK1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._CmdTK1_0.UseVisualStyleBackColor = False
        Me._CmdTK1_0.Visible = False
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
        Me.Grd.Size = New System.Drawing.Size(489, 473)
        Me.Grd.SortType = ListViewEx.SortTypes.InsertionSort
        Me.Grd.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.Grd.TabIndex = 10
        '
        'FrmSothu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(505, 593)
        Me.Controls.Add(Me.Grd)
        Me.Controls.Add(Me._CmdTK_4)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me._Command1_2)
        Me.Controls.Add(Me._Command1_3)
        Me.Controls.Add(Me._txtShTk_1)
        Me.Controls.Add(Me._CmdTK1_0)
        Me.Controls.Add(Me._Frame_4)
        Me.Controls.Add(Me._txtShTk_0)
        Me.Controls.Add(Me.GauGe)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_12)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_14)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSothu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me._Frame_4.ResumeLayout(False)
        Me._Frame_4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializetxtShTk()
		Me.txtShTk(1) = _txtShTk_1
		Me.txtShTk(0) = _txtShTk_0
	End Sub
	Sub InitializeOptTG()
		Me.OptTG(1) = _OptTG_1
	End Sub
	Sub InitializeMedNgay()
		Me.MedNgay(0) = _MedNgay_0
		Me.MedNgay(1) = _MedNgay_1
	End Sub
	Sub InitializeLabel()
		Me.Label(18) = _Label_18
		Me.Label(3) = _Label_3
		Me.Label(6) = _Label_6
		Me.Label(12) = _Label_12
		Me.Label(0) = _Label_0
		Me.Label(1) = _Label_1
		Me.Label(2) = _Label_2
		Me.Label(7) = _Label_7
		Me.Label(14) = _Label_14
	End Sub
	Sub InitializeFrame()
		Me.Frame(4) = _Frame_4
	End Sub
	Sub InitializeCommand1()
		Me.Command1(1) = _Command1_1
		Me.Command1(0) = _Command1_0
		Me.Command1(2) = _Command1_2
		Me.Command1(3) = _Command1_3
	End Sub
	Sub InitializeCommand()
		Me.Command(3) = _Command_3
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
	Sub InitializeCmdTK1()
		Me.CmdTK1(0) = _CmdTK1_0
	End Sub
	Sub InitializeCmdTK()
		Me.CmdTK(4) = _CmdTK_4
	End Sub
#End Region 
End Class
