<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBCVT
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
        isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		InitializeOptTG()
		InitializeOptBC()
		InitializeMedNgay()
		InitializeLabel()
		InitializeFrame()
		InitializeCommand1()
		InitializeCommand()
		InitializeChk()
		InitializeCboThang()
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
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Public WithEvents CboLoai As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboKho_2 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Chk_1 As System.Windows.Forms.CheckBox
    Private WithEvents _Chk_0 As System.Windows.Forms.CheckBox
    Private WithEvents _OptTG_1 As System.Windows.Forms.RadioButton
    Private WithEvents _OptTG_0 As System.Windows.Forms.RadioButton
    Private WithEvents _CboThang_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboThang_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _MedNgay_0 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _MedNgay_1 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Frame_0 As System.Windows.Forms.Panel
    Private WithEvents _CboKho_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboKho_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Command1_2 As System.Windows.Forms.Button
    Private WithEvents _OptBC_1 As System.Windows.Forms.RadioButton
    Private WithEvents _OptBC_0 As System.Windows.Forms.RadioButton
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Public CboKho(2) As ComboBoxEx.ComboBoxExt
    Public CboThang(1) As ComboBoxEx.ComboBoxExt
    Public Chk(1) As System.Windows.Forms.CheckBox
    Public Command(2) As System.Windows.Forms.Button
    Public Command1(2) As System.Windows.Forms.Button
    Public Frame(0) As System.Windows.Forms.Panel
    Public Label(6) As System.Windows.Forms.Label
    Public MedNgay(1) As System.Windows.Forms.MaskedTextBox
    Public OptBC(1) As System.Windows.Forms.RadioButton
    Public OptTG(1) As System.Windows.Forms.RadioButton
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBCVT))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me.CboLoai = New ComboBoxEx.ComboBoxExt
        Me._CboKho_2 = New ComboBoxEx.ComboBoxExt
        Me._Chk_1 = New System.Windows.Forms.CheckBox
        Me._Chk_0 = New System.Windows.Forms.CheckBox
        Me._Frame_0 = New System.Windows.Forms.Panel
        Me._OptTG_1 = New System.Windows.Forms.RadioButton
        Me._OptTG_0 = New System.Windows.Forms.RadioButton
        Me._CboThang_1 = New ComboBoxEx.ComboBoxExt
        Me._CboThang_0 = New ComboBoxEx.ComboBoxExt
        Me._MedNgay_0 = New System.Windows.Forms.MaskedTextBox
        Me._MedNgay_1 = New System.Windows.Forms.MaskedTextBox
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._CboKho_1 = New ComboBoxEx.ComboBoxExt
        Me._CboKho_0 = New ComboBoxEx.ComboBoxExt
        Me._Command1_0 = New System.Windows.Forms.Button
        Me._Command1_1 = New System.Windows.Forms.Button
        Me._Command1_2 = New System.Windows.Forms.Button
        Me._OptBC_1 = New System.Windows.Forms.RadioButton
        Me._OptBC_0 = New System.Windows.Forms.RadioButton
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Frame_0.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(352, 208)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 24
        Me._Command_2.Tag = "Return"
        Me._Command_2.Text = "Trở &về"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.print16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(272, 208)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 23
        Me._Command_1.Tag = "Print"
        Me._Command_1.Text = "&In"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.report16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(192, 208)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 22
        Me._Command_0.Tag = "Preview"
        Me._Command_0.Text = "&Xem"
        '
        'CboLoai
        '
        Me.CboLoai.BackColor = System.Drawing.SystemColors.Window
        Me.CboLoai.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLoai.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLoai.Location = New System.Drawing.Point(184, 176)
        Me.CboLoai.Name = "CboLoai"
        Me.CboLoai.Size = New System.Drawing.Size(225, 21)
        Me.CboLoai.TabIndex = 13
        '
        '_CboKho_2
        '
        Me._CboKho_2.BackColor = System.Drawing.SystemColors.Window
        Me._CboKho_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboKho_2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboKho_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboKho_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboKho_2.Location = New System.Drawing.Point(184, 144)
        Me._CboKho_2.Name = "_CboKho_2"
        Me._CboKho_2.Size = New System.Drawing.Size(225, 21)
        Me._CboKho_2.TabIndex = 11
        '
        '_Chk_1
        '
        Me._Chk_1.BackColor = System.Drawing.Color.Transparent
        Me._Chk_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_1.Location = New System.Drawing.Point(24, 176)
        Me._Chk_1.Name = "_Chk_1"
        Me._Chk_1.Size = New System.Drawing.Size(145, 17)
        Me._Chk_1.TabIndex = 12
        Me._Chk_1.Tag = "Class"
        Me._Chk_1.Text = "Theo phân loại hàng hoá"
        Me._Chk_1.UseVisualStyleBackColor = False
        '
        '_Chk_0
        '
        Me._Chk_0.BackColor = System.Drawing.Color.Transparent
        Me._Chk_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_0.Location = New System.Drawing.Point(24, 144)
        Me._Chk_0.Name = "_Chk_0"
        Me._Chk_0.Size = New System.Drawing.Size(73, 17)
        Me._Chk_0.TabIndex = 10
        Me._Chk_0.Tag = "Stock"
        Me._Chk_0.Text = "Theo kho"
        Me._Chk_0.UseVisualStyleBackColor = False
        '
        '_Frame_0
        '
        Me._Frame_0.BackColor = System.Drawing.Color.Transparent
        Me._Frame_0.Controls.Add(Me._OptTG_1)
        Me._Frame_0.Controls.Add(Me._OptTG_0)
        Me._Frame_0.Controls.Add(Me._CboThang_1)
        Me._Frame_0.Controls.Add(Me._CboThang_0)
        Me._Frame_0.Controls.Add(Me._MedNgay_0)
        Me._Frame_0.Controls.Add(Me._MedNgay_1)
        Me._Frame_0.Controls.Add(Me._Label_0)
        Me._Frame_0.Controls.Add(Me._Label_6)
        Me._Frame_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Frame_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_0.Location = New System.Drawing.Point(97, 0)
        Me._Frame_0.Name = "_Frame_0"
        Me._Frame_0.Size = New System.Drawing.Size(336, 65)
        Me._Frame_0.TabIndex = 19
        '
        '_OptTG_1
        '
        Me._OptTG_1.BackColor = System.Drawing.Color.Transparent
        Me._OptTG_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptTG_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptTG_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptTG_1.Location = New System.Drawing.Point(10, 41)
        Me._OptTG_1.Name = "_OptTG_1"
        Me._OptTG_1.Size = New System.Drawing.Size(65, 17)
        Me._OptTG_1.TabIndex = 3
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
        Me._OptTG_0.Location = New System.Drawing.Point(10, 9)
        Me._OptTG_0.Name = "_OptTG_0"
        Me._OptTG_0.Size = New System.Drawing.Size(76, 17)
        Me._OptTG_0.TabIndex = 0
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
        Me._CboThang_1.Location = New System.Drawing.Point(245, 8)
        Me._CboThang_1.Name = "_CboThang_1"
        Me._CboThang_1.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_1.TabIndex = 2
        '
        '_CboThang_0
        '
        Me._CboThang_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_0.Location = New System.Drawing.Point(92, 8)
        Me._CboThang_0.Name = "_CboThang_0"
        Me._CboThang_0.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_0.TabIndex = 1
        '
        '_MedNgay_0
        '
        Me._MedNgay_0.AllowPromptAsInput = False
        Me._MedNgay_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_0.Location = New System.Drawing.Point(92, 39)
        Me._MedNgay_0.Mask = "00/00/0000"
        Me._MedNgay_0.Name = "_MedNgay_0"
        Me._MedNgay_0.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_0.TabIndex = 4
        '
        '_MedNgay_1
        '
        Me._MedNgay_1.AllowPromptAsInput = False
        Me._MedNgay_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_1.Location = New System.Drawing.Point(245, 40)
        Me._MedNgay_1.Mask = "00/00/0000"
        Me._MedNgay_1.Name = "_MedNgay_1"
        Me._MedNgay_1.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_1.TabIndex = 5
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(178, 42)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(58, 17)
        Me._Label_0.TabIndex = 21
        Me._Label_0.Tag = "to"
        Me._Label_0.Text = "Đến ngày"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.Transparent
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_6.Location = New System.Drawing.Point(178, 11)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(58, 17)
        Me._Label_6.TabIndex = 20
        Me._Label_6.Tag = "to"
        Me._Label_6.Text = "Đến tháng"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_CboKho_1
        '
        Me._CboKho_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboKho_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboKho_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboKho_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboKho_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboKho_1.Location = New System.Drawing.Point(280, 88)
        Me._CboKho_1.Name = "_CboKho_1"
        Me._CboKho_1.Size = New System.Drawing.Size(145, 21)
        Me._CboKho_1.TabIndex = 8
        '
        '_CboKho_0
        '
        Me._CboKho_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboKho_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboKho_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboKho_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboKho_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboKho_0.Location = New System.Drawing.Point(72, 88)
        Me._CboKho_0.Name = "_CboKho_0"
        Me._CboKho_0.Size = New System.Drawing.Size(145, 21)
        Me._CboKho_0.TabIndex = 7
        '
        '_Command1_0
        '
        Me._Command1_0.BackColor = System.Drawing.Color.Silver
        Me._Command1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_0.Image = CType(resources.GetObject("_Command1_0.Image"), System.Drawing.Image)
        Me._Command1_0.Location = New System.Drawing.Point(192, 208)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(73, 25)
        Me._Command1_0.TabIndex = 14
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&View"
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
        Me._Command1_1.Location = New System.Drawing.Point(272, 208)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(73, 25)
        Me._Command1_1.TabIndex = 15
        Me._Command1_1.TabStop = False
        Me._Command1_1.Tag = "&Print"
        Me._Command1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_1.UseVisualStyleBackColor = False
        Me._Command1_1.Visible = False
        '
        '_Command1_2
        '
        Me._Command1_2.BackColor = System.Drawing.Color.Silver
        Me._Command1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_2.Image = CType(resources.GetObject("_Command1_2.Image"), System.Drawing.Image)
        Me._Command1_2.Location = New System.Drawing.Point(352, 208)
        Me._Command1_2.Name = "_Command1_2"
        Me._Command1_2.Size = New System.Drawing.Size(73, 25)
        Me._Command1_2.TabIndex = 16
        Me._Command1_2.TabStop = False
        Me._Command1_2.Tag = "&Return"
        Me._Command1_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_2.UseVisualStyleBackColor = False
        Me._Command1_2.Visible = False
        '
        '_OptBC_1
        '
        Me._OptBC_1.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_1.Location = New System.Drawing.Point(8, 120)
        Me._OptBC_1.Name = "_OptBC_1"
        Me._OptBC_1.Size = New System.Drawing.Size(201, 17)
        Me._OptBC_1.TabIndex = 9
        Me._OptBC_1.TabStop = True
        Me._OptBC_1.Tag = "Journal Ledger"
        Me._OptBC_1.Text = "Bảng kê chứng từ nhập kho"
        Me._OptBC_1.UseVisualStyleBackColor = False
        '
        '_OptBC_0
        '
        Me._OptBC_0.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_0.Checked = True
        Me._OptBC_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_0.Location = New System.Drawing.Point(8, 64)
        Me._OptBC_0.Name = "_OptBC_0"
        Me._OptBC_0.Size = New System.Drawing.Size(201, 17)
        Me._OptBC_0.TabIndex = 6
        Me._OptBC_0.TabStop = True
        Me._OptBC_0.Tag = "Journal Ledger"
        Me._OptBC_0.Text = "Bảng kê chứng từ lưu chuyển nội bộ"
        Me._OptBC_0.UseVisualStyleBackColor = False
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.Transparent
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(223, 88)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(50, 17)
        Me._Label_2.TabIndex = 18
        Me._Label_2.Tag = "to"
        Me._Label_2.Text = "đến kho"
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(24, 88)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(41, 17)
        Me._Label_1.TabIndex = 17
        Me._Label_1.Tag = "to"
        Me._Label_1.Text = "Từ kho"
        '
        'FrmBCVT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 240)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me.CboLoai)
        Me.Controls.Add(Me._CboKho_2)
        Me.Controls.Add(Me._Chk_1)
        Me.Controls.Add(Me._Chk_0)
        Me.Controls.Add(Me._Frame_0)
        Me.Controls.Add(Me._CboKho_1)
        Me.Controls.Add(Me._CboKho_0)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Command1_2)
        Me.Controls.Add(Me._OptBC_1)
        Me.Controls.Add(Me._OptBC_0)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(110, 103)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBCVT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Stock reports"
        Me.Text = "Báo cáo nhập xuất kho"
        Me._Frame_0.ResumeLayout(False)
        Me._Frame_0.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
	Sub InitializeOptTG()
		Me.OptTG(1) = _OptTG_1
		Me.OptTG(0) = _OptTG_0
	End Sub
	Sub InitializeOptBC()
		Me.OptBC(1) = _OptBC_1
		Me.OptBC(0) = _OptBC_0
	End Sub
	Sub InitializeMedNgay()
		Me.MedNgay(0) = _MedNgay_0
		Me.MedNgay(1) = _MedNgay_1
	End Sub
	Sub InitializeLabel()
		Me.Label(0) = _Label_0
		Me.Label(6) = _Label_6
		Me.Label(2) = _Label_2
		Me.Label(1) = _Label_1
	End Sub
	Sub InitializeFrame()
		Me.Frame(0) = _Frame_0
	End Sub
	Sub InitializeCommand1()
		Me.Command1(0) = _Command1_0
		Me.Command1(1) = _Command1_1
		Me.Command1(2) = _Command1_2
	End Sub
	Sub InitializeCommand()
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
	Sub InitializeChk()
		Me.Chk(1) = _Chk_1
		Me.Chk(0) = _Chk_0
	End Sub
	Sub InitializeCboThang()
		Me.CboThang(1) = _CboThang_1
		Me.CboThang(0) = _CboThang_0
	End Sub
	Sub InitializeCboKho()
		Me.CboKho(2) = _CboKho_2
		Me.CboKho(1) = _CboKho_1
		Me.CboKho(0) = _CboKho_0
	End Sub
#End Region 
End Class
