<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTongHop
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeTxtSohieu()
		InitializeOpt()
		InitializeMedNgay()
		InitializeLstDB()
		InitializeLbTen()
		InitializeLabel1()
		InitializeCommand1()
		InitializeCommand()
		InitializeChk()
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
	Private WithEvents _TxtSohieu_1 As System.Windows.Forms.TextBox
	Private WithEvents _Chk_8 As System.Windows.Forms.CheckBox
	Private WithEvents _MedNgay_0 As System.Windows.Forms.MaskedTextBox
	Private WithEvents _TxtSohieu_0 As System.Windows.Forms.TextBox
	Private WithEvents _Chk_0 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_1 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_2 As System.Windows.Forms.CheckBox
	Private WithEvents _Opt_0 As System.Windows.Forms.RadioButton
	Private WithEvents _CboThang_0 As ComboBoxEx.ComboBoxExt
	Private WithEvents _Opt_1 As System.Windows.Forms.RadioButton
	Private WithEvents _CboThang_1 As ComboBoxEx.ComboBoxExt
	Private WithEvents _Chk_3 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_4 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_5 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_6 As System.Windows.Forms.CheckBox
	Private WithEvents _MedNgay_1 As System.Windows.Forms.MaskedTextBox
	Private WithEvents _Label1_1 As System.Windows.Forms.Label
	Private WithEvents _Label1_0 As System.Windows.Forms.Label
	Private WithEvents _Label1_2 As System.Windows.Forms.Label
	Private WithEvents _LbTen_0 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Private WithEvents _Chk_7 As System.Windows.Forms.CheckBox
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command1_3 As System.Windows.Forms.Button
    Private WithEvents _Command1_2 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Private WithEvents _LstDB_1 As System.Windows.Forms.ListBox
    Private WithEvents _LstDB_0 As System.Windows.Forms.ListBox
    Private WithEvents _LbTen_1 As System.Windows.Forms.Label
    Public CboThang(1) As ComboBoxEx.ComboBoxExt
    Public Chk(8) As System.Windows.Forms.CheckBox
    Public Command(3) As System.Windows.Forms.Button
    Public Command1(3) As System.Windows.Forms.Button
    Public Label1(3) As System.Windows.Forms.Label
    Public LbTen(1) As System.Windows.Forms.Label
    Public LstDB(1) As System.Windows.Forms.ListBox
    Public MedNgay(1) As System.Windows.Forms.MaskedTextBox
    Public Opt(1) As System.Windows.Forms.RadioButton
    Public TxtSohieu(1) As System.Windows.Forms.TextBox
    'Private listBoxHelper1 As Artinsoft.VB6.Gui.ListBoxHelper
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTongHop))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._TxtSohieu_1 = New System.Windows.Forms.TextBox()
        Me._Chk_8 = New System.Windows.Forms.CheckBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me._MedNgay_0 = New System.Windows.Forms.MaskedTextBox()
        Me._TxtSohieu_0 = New System.Windows.Forms.TextBox()
        Me._Chk_0 = New System.Windows.Forms.CheckBox()
        Me._Chk_1 = New System.Windows.Forms.CheckBox()
        Me._Chk_2 = New System.Windows.Forms.CheckBox()
        Me._Opt_0 = New System.Windows.Forms.RadioButton()
        Me._CboThang_0 = New ComboBoxEx.ComboBoxExt()
        Me._Opt_1 = New System.Windows.Forms.RadioButton()
        Me._CboThang_1 = New ComboBoxEx.ComboBoxExt()
        Me._Chk_3 = New System.Windows.Forms.CheckBox()
        Me._Chk_4 = New System.Windows.Forms.CheckBox()
        Me._Chk_5 = New System.Windows.Forms.CheckBox()
        Me._Chk_6 = New System.Windows.Forms.CheckBox()
        Me._MedNgay_1 = New System.Windows.Forms.MaskedTextBox()
        Me._Label1_1 = New System.Windows.Forms.Label()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me._Label1_2 = New System.Windows.Forms.Label()
        Me._LbTen_0 = New System.Windows.Forms.Label()
        Me._Chk_7 = New System.Windows.Forms.CheckBox()
        Me._Command_2 = New System.Windows.Forms.Button()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._Command_3 = New System.Windows.Forms.Button()
        Me._Command1_3 = New System.Windows.Forms.Button()
        Me._Command1_2 = New System.Windows.Forms.Button()
        Me._Command1_1 = New System.Windows.Forms.Button()
        Me._Command1_0 = New System.Windows.Forms.Button()
        Me._LstDB_1 = New System.Windows.Forms.ListBox()
        Me._LstDB_0 = New System.Windows.Forms.ListBox()
        Me._LbTen_1 = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_TxtSohieu_1
        '
        Me._TxtSohieu_1.AcceptsReturn = True
        Me._TxtSohieu_1.BackColor = System.Drawing.SystemColors.Window
        Me._TxtSohieu_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtSohieu_1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtSohieu_1.Location = New System.Drawing.Point(112, 168)
        Me._TxtSohieu_1.MaxLength = 0
        Me._TxtSohieu_1.Name = "_TxtSohieu_1"
        Me._TxtSohieu_1.Size = New System.Drawing.Size(65, 21)
        Me._TxtSohieu_1.TabIndex = 11
        Me._TxtSohieu_1.Tag = "0"
        '
        '_Chk_8
        '
        Me._Chk_8.BackColor = System.Drawing.Color.Transparent
        Me._Chk_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_8.Location = New System.Drawing.Point(16, 184)
        Me._Chk_8.Name = "_Chk_8"
        Me._Chk_8.Size = New System.Drawing.Size(97, 17)
        Me._Chk_8.TabIndex = 33
        Me._Chk_8.Tag = "Arising"
        Me._Chk_8.Text = "Số phát sinh"
        Me._Chk_8.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.Transparent
        Me.Frame1.Controls.Add(Me._MedNgay_0)
        Me.Frame1.Controls.Add(Me._TxtSohieu_0)
        Me.Frame1.Controls.Add(Me._Chk_0)
        Me.Frame1.Controls.Add(Me._Chk_1)
        Me.Frame1.Controls.Add(Me._Chk_2)
        Me.Frame1.Controls.Add(Me._Opt_0)
        Me.Frame1.Controls.Add(Me._CboThang_0)
        Me.Frame1.Controls.Add(Me._Opt_1)
        Me.Frame1.Controls.Add(Me._CboThang_1)
        Me.Frame1.Controls.Add(Me._Chk_3)
        Me.Frame1.Controls.Add(Me._Chk_4)
        Me.Frame1.Controls.Add(Me._Chk_5)
        Me.Frame1.Controls.Add(Me._Chk_6)
        Me.Frame1.Controls.Add(Me._MedNgay_1)
        Me.Frame1.Controls.Add(Me._Label1_1)
        Me.Frame1.Controls.Add(Me._Label1_0)
        Me.Frame1.Controls.Add(Me._Label1_2)
        Me.Frame1.Controls.Add(Me._LbTen_0)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 200)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(665, 89)
        Me.Frame1.TabIndex = 14
        Me.Frame1.TabStop = False
        '
        '_MedNgay_0
        '
        Me._MedNgay_0.AllowPromptAsInput = False
        Me._MedNgay_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_0.Location = New System.Drawing.Point(120, 40)
        Me._MedNgay_0.Mask = "00/00/0000"
        Me._MedNgay_0.Name = "_MedNgay_0"
        Me._MedNgay_0.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_0.TabIndex = 22
        '
        '_TxtSohieu_0
        '
        Me._TxtSohieu_0.AcceptsReturn = True
        Me._TxtSohieu_0.BackColor = System.Drawing.SystemColors.Window
        Me._TxtSohieu_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtSohieu_0.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtSohieu_0.Location = New System.Drawing.Point(520, 16)
        Me._TxtSohieu_0.MaxLength = 0
        Me._TxtSohieu_0.Name = "_TxtSohieu_0"
        Me._TxtSohieu_0.Size = New System.Drawing.Size(65, 21)
        Me._TxtSohieu_0.TabIndex = 15
        Me._TxtSohieu_0.Tag = "0"
        '
        '_Chk_0
        '
        Me._Chk_0.BackColor = System.Drawing.Color.Transparent
        Me._Chk_0.Checked = True
        Me._Chk_0.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Chk_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_0.Location = New System.Drawing.Point(136, 64)
        Me._Chk_0.Name = "_Chk_0"
        Me._Chk_0.Size = New System.Drawing.Size(65, 17)
        Me._Chk_0.TabIndex = 28
        Me._Chk_0.Tag = "Material"
        Me._Chk_0.Text = "Vật tư"
        Me._Chk_0.UseVisualStyleBackColor = False
        '
        '_Chk_1
        '
        Me._Chk_1.BackColor = System.Drawing.Color.Transparent
        Me._Chk_1.Checked = True
        Me._Chk_1.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Chk_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_1.Location = New System.Drawing.Point(208, 64)
        Me._Chk_1.Name = "_Chk_1"
        Me._Chk_1.Size = New System.Drawing.Size(73, 17)
        Me._Chk_1.TabIndex = 27
        Me._Chk_1.Tag = "Debt"
        Me._Chk_1.Text = "Công nợ"
        Me._Chk_1.UseVisualStyleBackColor = False
        '
        '_Chk_2
        '
        Me._Chk_2.BackColor = System.Drawing.Color.Transparent
        Me._Chk_2.Checked = True
        Me._Chk_2.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Chk_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_2.Location = New System.Drawing.Point(288, 64)
        Me._Chk_2.Name = "_Chk_2"
        Me._Chk_2.Size = New System.Drawing.Size(130, 17)
        Me._Chk_2.TabIndex = 26
        Me._Chk_2.Tag = "Fixed Assets - Tool"
        Me._Chk_2.Text = "Tài sản và Công cụ"
        Me._Chk_2.UseVisualStyleBackColor = False
        '
        '_Opt_0
        '
        Me._Opt_0.BackColor = System.Drawing.Color.Transparent
        Me._Opt_0.Checked = True
        Me._Opt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_0.Location = New System.Drawing.Point(8, 16)
        Me._Opt_0.Name = "_Opt_0"
        Me._Opt_0.Size = New System.Drawing.Size(143, 17)
        Me._Opt_0.TabIndex = 25
        Me._Opt_0.TabStop = True
        Me._Opt_0.Tag = "Import data FROM"
        Me._Opt_0.Text = "Tháng tập hợp phát sinh"
        Me._Opt_0.UseVisualStyleBackColor = False
        '
        '_CboThang_0
        '
        Me._CboThang_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_0.Location = New System.Drawing.Point(152, 13)
        Me._CboThang_0.Name = "_CboThang_0"
        Me._CboThang_0.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_0.TabIndex = 24
        '
        '_Opt_1
        '
        Me._Opt_1.BackColor = System.Drawing.Color.Transparent
        Me._Opt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_1.Location = New System.Drawing.Point(8, 40)
        Me._Opt_1.Name = "_Opt_1"
        Me._Opt_1.Size = New System.Drawing.Size(113, 17)
        Me._Opt_1.TabIndex = 23
        Me._Opt_1.TabStop = True
        Me._Opt_1.Tag = "Import FROM"
        Me._Opt_1.Text = "Tổng hợp từ ngày"
        Me._Opt_1.UseVisualStyleBackColor = False
        '
        '_CboThang_1
        '
        Me._CboThang_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_1.Location = New System.Drawing.Point(288, 13)
        Me._CboThang_1.Name = "_CboThang_1"
        Me._CboThang_1.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_1.TabIndex = 20
        '
        '_Chk_3
        '
        Me._Chk_3.BackColor = System.Drawing.Color.Transparent
        Me._Chk_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_3.Location = New System.Drawing.Point(424, 48)
        Me._Chk_3.Name = "_Chk_3"
        Me._Chk_3.Size = New System.Drawing.Size(169, 17)
        Me._Chk_3.TabIndex = 19
        Me._Chk_3.Tag = "Create sub-account"
        Me._Chk_3.Text = "Tạo chi tiết cho các tài khoản"
        Me._Chk_3.UseVisualStyleBackColor = False
        '
        '_Chk_4
        '
        Me._Chk_4.BackColor = System.Drawing.Color.Transparent
        Me._Chk_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_4.Location = New System.Drawing.Point(424, 64)
        Me._Chk_4.Name = "_Chk_4"
        Me._Chk_4.Size = New System.Drawing.Size(209, 17)
        Me._Chk_4.TabIndex = 18
        Me._Chk_4.Tag = "Create sub-account"
        Me._Chk_4.Text = "Tách riêng các đối tượng cùng số hiệu"
        Me._Chk_4.UseVisualStyleBackColor = False
        '
        '_Chk_5
        '
        Me._Chk_5.BackColor = System.Drawing.Color.Transparent
        Me._Chk_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_5.Location = New System.Drawing.Point(424, 32)
        Me._Chk_5.Name = "_Chk_5"
        Me._Chk_5.Size = New System.Drawing.Size(169, 17)
        Me._Chk_5.TabIndex = 17
        Me._Chk_5.Tag = "Choose vouchers"
        Me._Chk_5.Text = "Chọn chứng từ "
        Me._Chk_5.UseVisualStyleBackColor = False
        Me._Chk_5.Visible = False
        '
        '_Chk_6
        '
        Me._Chk_6.BackColor = System.Drawing.Color.Transparent
        Me._Chk_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_6.Location = New System.Drawing.Point(424, 16)
        Me._Chk_6.Name = "_Chk_6"
        Me._Chk_6.Size = New System.Drawing.Size(97, 17)
        Me._Chk_6.TabIndex = 16
        Me._Chk_6.Tag = "Account"
        Me._Chk_6.Text = "Chọn tài khoản"
        Me._Chk_6.UseVisualStyleBackColor = False
        '
        '_MedNgay_1
        '
        Me._MedNgay_1.AllowPromptAsInput = False
        Me._MedNgay_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_1.Location = New System.Drawing.Point(232, 40)
        Me._MedNgay_1.Mask = "00/00/0000"
        Me._MedNgay_1.Name = "_MedNgay_1"
        Me._MedNgay_1.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_1.TabIndex = 21
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.Color.Transparent
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(8, 64)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.Size = New System.Drawing.Size(129, 17)
        Me._Label1_1.TabIndex = 32
        Me._Label1_1.Tag = "Import Detail"
        Me._Label1_1.Text = "Tổng hợp các chi tiết"
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.Color.Transparent
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(179, 43)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.Size = New System.Drawing.Size(54, 17)
        Me._Label1_0.TabIndex = 31
        Me._Label1_0.Tag = "to"
        Me._Label1_0.Text = "Đến ngày"
        Me._Label1_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_2
        '
        Me._Label1_2.BackColor = System.Drawing.Color.Transparent
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(232, 16)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.Size = New System.Drawing.Size(58, 17)
        Me._Label1_2.TabIndex = 30
        Me._Label1_2.Tag = "to"
        Me._Label1_2.Text = "Đến tháng"
        Me._Label1_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_LbTen_0
        '
        Me._LbTen_0.AutoSize = True
        Me._LbTen_0.BackColor = System.Drawing.Color.Transparent
        Me._LbTen_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTen_0.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTen_0.ForeColor = System.Drawing.Color.Blue
        Me._LbTen_0.Location = New System.Drawing.Point(592, 16)
        Me._LbTen_0.Name = "_LbTen_0"
        Me._LbTen_0.Size = New System.Drawing.Size(0, 15)
        Me._LbTen_0.TabIndex = 29
        Me._LbTen_0.Tag = "1"
        '
        '_Chk_7
        '
        Me._Chk_7.BackColor = System.Drawing.Color.Transparent
        Me._Chk_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_7.Location = New System.Drawing.Point(16, 168)
        Me._Chk_7.Name = "_Chk_7"
        Me._Chk_7.Size = New System.Drawing.Size(97, 17)
        Me._Chk_7.TabIndex = 12
        Me._Chk_7.Tag = "Openning Inventory"
        Me._Chk_7.Text = "Số dư đầu kỳ"
        Me._Chk_7.UseVisualStyleBackColor = False
        '
        '_Command_2
        '
        Me._Command_2.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Tong_hop
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(680, 72)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(92, 25)
        Me._Command_2.TabIndex = 10
        Me._Command_2.Tag = "Import"
        Me._Command_2.Text = "T. Hợ&p"
        '
        '_Command_0
        '
        Me._Command_0.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Add
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(680, 8)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(92, 25)
        Me._Command_0.TabIndex = 7
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Xoa
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(680, 40)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(92, 25)
        Me._Command_1.TabIndex = 8
        Me._Command_1.Tag = "Delete"
        Me._Command_1.Text = "&Xóa"
        '
        '_Command_3
        '
        Me._Command_3.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(680, 104)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(92, 25)
        Me._Command_3.TabIndex = 9
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_Command1_3
        '
        Me._Command1_3.BackColor = System.Drawing.Color.Silver
        Me._Command1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_3.Image = CType(resources.GetObject("_Command1_3.Image"), System.Drawing.Image)
        Me._Command1_3.Location = New System.Drawing.Point(680, 104)
        Me._Command1_3.Name = "_Command1_3"
        Me._Command1_3.Size = New System.Drawing.Size(85, 25)
        Me._Command1_3.TabIndex = 5
        Me._Command1_3.TabStop = False
        Me._Command1_3.Tag = "&Return"
        Me._Command1_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_3.UseVisualStyleBackColor = False
        Me._Command1_3.Visible = False
        '
        '_Command1_2
        '
        Me._Command1_2.BackColor = System.Drawing.Color.Silver
        Me._Command1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_2.Image = CType(resources.GetObject("_Command1_2.Image"), System.Drawing.Image)
        Me._Command1_2.Location = New System.Drawing.Point(680, 72)
        Me._Command1_2.Name = "_Command1_2"
        Me._Command1_2.Size = New System.Drawing.Size(85, 25)
        Me._Command1_2.TabIndex = 4
        Me._Command1_2.TabStop = False
        Me._Command1_2.Tag = "&Import"
        Me._Command1_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_2.UseVisualStyleBackColor = False
        Me._Command1_2.Visible = False
        '
        '_Command1_1
        '
        Me._Command1_1.BackColor = System.Drawing.Color.Silver
        Me._Command1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_1.Image = CType(resources.GetObject("_Command1_1.Image"), System.Drawing.Image)
        Me._Command1_1.Location = New System.Drawing.Point(680, 40)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(85, 25)
        Me._Command1_1.TabIndex = 3
        Me._Command1_1.TabStop = False
        Me._Command1_1.Tag = "&DELETE"
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
        Me._Command1_0.Location = New System.Drawing.Point(680, 8)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(85, 25)
        Me._Command1_0.TabIndex = 2
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&Add"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        '_LstDB_1
        '
        Me._LstDB_1.BackColor = System.Drawing.SystemColors.Window
        Me._LstDB_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LstDB_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LstDB_1.ItemHeight = 14
        Me._LstDB_1.Location = New System.Drawing.Point(296, 0)
        Me._LstDB_1.Name = "_LstDB_1"
        Me._LstDB_1.Size = New System.Drawing.Size(377, 158)
        Me._LstDB_1.TabIndex = 1
        '
        '_LstDB_0
        '
        Me._LstDB_0.BackColor = System.Drawing.SystemColors.Window
        Me._LstDB_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LstDB_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LstDB_0.ItemHeight = 14
        Me._LstDB_0.Location = New System.Drawing.Point(0, 0)
        Me._LstDB_0.Name = "_LstDB_0"
        Me._LstDB_0.Size = New System.Drawing.Size(297, 158)
        Me._LstDB_0.TabIndex = 0
        '
        '_LbTen_1
        '
        Me._LbTen_1.AutoSize = True
        Me._LbTen_1.BackColor = System.Drawing.Color.Transparent
        Me._LbTen_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTen_1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTen_1.ForeColor = System.Drawing.Color.Blue
        Me._LbTen_1.Location = New System.Drawing.Point(184, 168)
        Me._LbTen_1.Name = "_LbTen_1"
        Me._LbTen_1.Size = New System.Drawing.Size(0, 15)
        Me._LbTen_1.TabIndex = 13
        Me._LbTen_1.Tag = "1"
        '
        'FrmTongHop
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(773, 297)
        Me.Controls.Add(Me._TxtSohieu_1)
        Me.Controls.Add(Me._Chk_8)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me._Chk_7)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command1_3)
        Me.Controls.Add(Me._Command1_2)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me._LstDB_1)
        Me.Controls.Add(Me._LstDB_0)
        Me.Controls.Add(Me._LbTen_1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(57, 161)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTongHop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Import data form other file"
        Me.Text = "Tổng hợp số liệu"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializeTxtSohieu()
		Me.TxtSohieu(1) = _TxtSohieu_1
		Me.TxtSohieu(0) = _TxtSohieu_0
	End Sub
	Sub InitializeOpt()
		Me.Opt(0) = _Opt_0
		Me.Opt(1) = _Opt_1
	End Sub
	Sub InitializeMedNgay()
		Me.MedNgay(0) = _MedNgay_0
		Me.MedNgay(1) = _MedNgay_1
	End Sub
	Sub InitializeLstDB()
		Me.LstDB(1) = _LstDB_1
		Me.LstDB(0) = _LstDB_0
	End Sub
	Sub InitializeLbTen()
		Me.LbTen(0) = _LbTen_0
		Me.LbTen(1) = _LbTen_1
	End Sub
	Sub InitializeLabel1()
		Me.Label1(1) = _Label1_1
		Me.Label1(0) = _Label1_0
		Me.Label1(2) = _Label1_2
	End Sub
	Sub InitializeCommand1()
		Me.Command1(3) = _Command1_3
		Me.Command1(2) = _Command1_2
		Me.Command1(1) = _Command1_1
		Me.Command1(0) = _Command1_0
	End Sub
	Sub InitializeCommand()
		Me.Command(2) = _Command_2
		Me.Command(0) = _Command_0
		Me.Command(1) = _Command_1
		Me.Command(3) = _Command_3
	End Sub
	Sub InitializeChk()
		Me.Chk(8) = _Chk_8
		Me.Chk(0) = _Chk_0
		Me.Chk(1) = _Chk_1
		Me.Chk(2) = _Chk_2
		Me.Chk(3) = _Chk_3
		Me.Chk(4) = _Chk_4
		Me.Chk(5) = _Chk_5
		Me.Chk(6) = _Chk_6
		Me.Chk(7) = _Chk_7
	End Sub
	Sub InitializeCboThang()
		Me.CboThang(0) = _CboThang_0
		Me.CboThang(1) = _CboThang_1
	End Sub
#End Region 
End Class
