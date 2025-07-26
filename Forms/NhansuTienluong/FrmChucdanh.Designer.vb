<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChucdanh
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializetxtVT()
		InitializeSSOpt()
		InitializeLine()
		InitializeLabel()
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
    Private WithEvents _Command_4 As System.Windows.Forms.Button
    Private WithEvents _txtVT_0 As System.Windows.Forms.TextBox
    Public WithEvents SSCmdF As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Public WithEvents CboThang As ComboBoxEx.ComboBoxExt
    Public WithEvents MedNgayApdung As System.Windows.Forms.MaskedTextBox
    Public WithEvents CboChucvu As ComboBoxEx.ComboBoxExt
    Public WithEvents CboLuong As ComboBoxEx.ComboBoxExt
    Public WithEvents CboBacluong As ComboBoxEx.ComboBoxExt
    Private WithEvents _txtVT_17 As System.Windows.Forms.TextBox
    Public WithEvents txtF As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_1 As System.Windows.Forms.TextBox
    Private WithEvents _SSOpt_1 As System.Windows.Forms.RadioButton
    Private WithEvents _SSOpt_0 As System.Windows.Forms.RadioButton
    Public WithEvents CboLoai As ComboBoxEx.ComboBoxExt
    Public WithEvents LstVt As System.Windows.Forms.ListBox
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Line_0 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_28 As System.Windows.Forms.Label
    Private WithEvents _Label_25 As System.Windows.Forms.Label
    Private WithEvents _Label_21 As System.Windows.Forms.Label
    Private WithEvents _Label_18 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Line_1 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Public Command(4) As System.Windows.Forms.Button
    Public Command1(3) As System.Windows.Forms.Button
    Public Label(28) As System.Windows.Forms.Label
    Public Line(1) As System.Windows.Forms.Label
    Public SSOpt(1) As System.Windows.Forms.RadioButton
    Public txtVT(17) As System.Windows.Forms.TextBox
    ''Private listBoxHelper1 As Artinsoft.VB6.Gui.ListBoxHelper
    ''Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChucdanh))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_4 = New System.Windows.Forms.Button
        Me._txtVT_0 = New System.Windows.Forms.TextBox
        Me.SSCmdF = New System.Windows.Forms.Button
        Me.CboThang = New ComboBoxEx.ComboBoxExt
        Me.MedNgayApdung = New System.Windows.Forms.MaskedTextBox
        Me.CboChucvu = New ComboBoxEx.ComboBoxExt
        Me.CboLuong = New ComboBoxEx.ComboBoxExt
        Me.CboBacluong = New ComboBoxEx.ComboBoxExt
        Me._txtVT_17 = New System.Windows.Forms.TextBox
        Me.txtF = New System.Windows.Forms.TextBox
        Me._txtVT_1 = New System.Windows.Forms.TextBox
        Me._SSOpt_1 = New System.Windows.Forms.RadioButton
        Me._SSOpt_0 = New System.Windows.Forms.RadioButton
        Me.CboLoai = New ComboBoxEx.ComboBoxExt
        Me.LstVt = New System.Windows.Forms.ListBox
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Line_0 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_28 = New System.Windows.Forms.Label
        Me._Label_25 = New System.Windows.Forms.Label
        Me._Label_21 = New System.Windows.Forms.Label
        Me._Label_18 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Line_1 = New System.Windows.Forms.Label
        Me._Label_13 = New System.Windows.Forms.Label
        Me._Label_17 = New System.Windows.Forms.Label
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        '_Command_4
        '
        Me._Command_4.Image = Global.UNET.My.Resources.Resources.righticon
        Me._Command_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_4.Location = New System.Drawing.Point(487, 224)
        Me._Command_4.Name = "_Command_4"
        Me._Command_4.Size = New System.Drawing.Size(82, 21)
        Me._Command_4.TabIndex = 9
        Me._Command_4.Tag = "Apply"
        Me._Command_4.Text = "Áp dụng"
        '
        '_txtVT_0
        '
        Me._txtVT_0.AcceptsReturn = True
        Me._txtVT_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_0.Location = New System.Drawing.Point(408, 224)
        Me._txtVT_0.MaxLength = 100
        Me._txtVT_0.Name = "_txtVT_0"
        Me._txtVT_0.Size = New System.Drawing.Size(73, 13)
        Me._txtVT_0.TabIndex = 8
        Me._txtVT_0.Text = "0"
        Me._txtVT_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SSCmdF
        '
        Me.SSCmdF.Image = Global.UNET.My.Resources.Resources.search3_16
        Me.SSCmdF.Location = New System.Drawing.Point(289, 447)
        Me.SSCmdF.Name = "SSCmdF"
        Me.SSCmdF.Size = New System.Drawing.Size(20, 20)
        Me.SSCmdF.TabIndex = 18
        Me.SSCmdF.TabStop = False
        Me.SSCmdF.Visible = False
        '
        'CboThang
        '
        Me.CboThang.BackColor = System.Drawing.SystemColors.Window
        Me.CboThang.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboThang.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboThang.Location = New System.Drawing.Point(408, 32)
        Me.CboThang.Name = "CboThang"
        Me.CboThang.Size = New System.Drawing.Size(73, 21)
        Me.CboThang.TabIndex = 2
        '
        'MedNgayApdung
        '
        Me.MedNgayApdung.AllowPromptAsInput = False
        Me.MedNgayApdung.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedNgayApdung.Location = New System.Drawing.Point(408, 192)
        Me.MedNgayApdung.Name = "MedNgayApdung"
        Me.MedNgayApdung.Size = New System.Drawing.Size(73, 20)
        Me.MedNgayApdung.TabIndex = 7
        '
        'CboChucvu
        '
        Me.CboChucvu.BackColor = System.Drawing.SystemColors.Window
        Me.CboChucvu.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboChucvu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboChucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboChucvu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboChucvu.Location = New System.Drawing.Point(408, 96)
        Me.CboChucvu.Name = "CboChucvu"
        Me.CboChucvu.Size = New System.Drawing.Size(210, 21)
        Me.CboChucvu.TabIndex = 4
        '
        'CboLuong
        '
        Me.CboLuong.BackColor = System.Drawing.SystemColors.Window
        Me.CboLuong.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboLuong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLuong.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLuong.Location = New System.Drawing.Point(408, 128)
        Me.CboLuong.Name = "CboLuong"
        Me.CboLuong.Size = New System.Drawing.Size(210, 21)
        Me.CboLuong.TabIndex = 5
        '
        'CboBacluong
        '
        Me.CboBacluong.BackColor = System.Drawing.SystemColors.Window
        Me.CboBacluong.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboBacluong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboBacluong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBacluong.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboBacluong.Location = New System.Drawing.Point(408, 160)
        Me.CboBacluong.Name = "CboBacluong"
        Me.CboBacluong.Size = New System.Drawing.Size(73, 21)
        Me.CboBacluong.TabIndex = 6
        '
        '_txtVT_17
        '
        Me._txtVT_17.AcceptsReturn = True
        Me._txtVT_17.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_17.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_17.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_17.Location = New System.Drawing.Point(484, 163)
        Me._txtVT_17.MaxLength = 100
        Me._txtVT_17.Name = "_txtVT_17"
        Me._txtVT_17.ReadOnly = True
        Me._txtVT_17.Size = New System.Drawing.Size(91, 13)
        Me._txtVT_17.TabIndex = 10
        Me._txtVT_17.TabStop = False
        Me._txtVT_17.Text = "0"
        Me._txtVT_17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtF
        '
        Me.txtF.AcceptsReturn = True
        Me.txtF.BackColor = System.Drawing.SystemColors.Window
        Me.txtF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF.Location = New System.Drawing.Point(144, 447)
        Me.txtF.MaxLength = 0
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(139, 20)
        Me.txtF.TabIndex = 17
        Me.txtF.Visible = False
        '
        '_txtVT_1
        '
        Me._txtVT_1.AcceptsReturn = True
        Me._txtVT_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_1.Location = New System.Drawing.Point(408, 64)
        Me._txtVT_1.MaxLength = 100
        Me._txtVT_1.Name = "_txtVT_1"
        Me._txtVT_1.ReadOnly = True
        Me._txtVT_1.Size = New System.Drawing.Size(210, 13)
        Me._txtVT_1.TabIndex = 3
        Me._txtVT_1.Text = "..."
        '
        '_SSOpt_1
        '
        Me._SSOpt_1.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_1.Location = New System.Drawing.Point(81, 449)
        Me._SSOpt_1.Name = "_SSOpt_1"
        Me._SSOpt_1.Size = New System.Drawing.Size(57, 17)
        Me._SSOpt_1.TabIndex = 16
        Me._SSOpt_1.TabStop = True
        Me._SSOpt_1.Tag = "Name"
        Me._SSOpt_1.Text = "Tên "
        Me._SSOpt_1.UseVisualStyleBackColor = False
        Me._SSOpt_1.Visible = False
        '
        '_SSOpt_0
        '
        Me._SSOpt_0.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_0.Checked = True
        Me._SSOpt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_0.Location = New System.Drawing.Point(8, 449)
        Me._SSOpt_0.Name = "_SSOpt_0"
        Me._SSOpt_0.Size = New System.Drawing.Size(67, 17)
        Me._SSOpt_0.TabIndex = 15
        Me._SSOpt_0.TabStop = True
        Me._SSOpt_0.Tag = "Code"
        Me._SSOpt_0.Text = "Số hiệu"
        Me._SSOpt_0.UseVisualStyleBackColor = False
        Me._SSOpt_0.Visible = False
        '
        'CboLoai
        '
        Me.CboLoai.BackColor = System.Drawing.SystemColors.Window
        Me.CboLoai.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLoai.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLoai.ForeColor = System.Drawing.Color.Blue
        Me.CboLoai.Location = New System.Drawing.Point(8, 8)
        Me.CboLoai.Name = "CboLoai"
        Me.CboLoai.Size = New System.Drawing.Size(297, 21)
        Me.CboLoai.TabIndex = 0
        '
        'LstVt
        '
        Me.LstVt.BackColor = System.Drawing.SystemColors.Window
        Me.LstVt.Cursor = System.Windows.Forms.Cursors.Default
        Me.LstVt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstVt.ItemHeight = 14
        Me.LstVt.Location = New System.Drawing.Point(8, 32)
        Me.LstVt.Name = "LstVt"
        Me.LstVt.Size = New System.Drawing.Size(297, 396)
        Me.LstVt.TabIndex = 1
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.White
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(328, 224)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(145, 17)
        Me._Label_1.TabIndex = 35
        Me._Label_1.Tag = "Month 13"
        Me._Label_1.Text = "Tháng 13                            %"
        '
        '_Line_0
        '
        Me._Line_0.Enabled = False
        Me._Line_0.Location = New System.Drawing.Point(408, 243)
        Me._Line_0.Name = "_Line_0"
        Me._Line_0.Size = New System.Drawing.Size(73, 1)
        Me._Line_0.TabIndex = 36
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.White
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(328, 32)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(73, 17)
        Me._Label_0.TabIndex = 30
        Me._Label_0.Tag = "Month"
        Me._Label_0.Text = "Tháng"
        '
        '_Label_28
        '
        Me._Label_28.BackColor = System.Drawing.Color.White
        Me._Label_28.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_28.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_28.Location = New System.Drawing.Point(328, 192)
        Me._Label_28.Name = "_Label_28"
        Me._Label_28.Size = New System.Drawing.Size(73, 17)
        Me._Label_28.TabIndex = 29
        Me._Label_28.Tag = "Date apply"
        Me._Label_28.Text = "Ngày áp dụng"
        '
        '_Label_25
        '
        Me._Label_25.BackColor = System.Drawing.Color.White
        Me._Label_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_25.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_25.Location = New System.Drawing.Point(578, 161)
        Me._Label_25.Name = "_Label_25"
        Me._Label_25.Size = New System.Drawing.Size(40, 17)
        Me._Label_25.TabIndex = 28
        Me._Label_25.Tag = "Month"
        Me._Label_25.Text = "Tháng"
        '
        '_Label_21
        '
        Me._Label_21.BackColor = System.Drawing.Color.White
        Me._Label_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_21.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_21.Location = New System.Drawing.Point(328, 160)
        Me._Label_21.Name = "_Label_21"
        Me._Label_21.Size = New System.Drawing.Size(73, 17)
        Me._Label_21.TabIndex = 27
        Me._Label_21.Tag = "Level salary"
        Me._Label_21.Text = "Bậc lương"
        '
        '_Label_18
        '
        Me._Label_18.BackColor = System.Drawing.Color.White
        Me._Label_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_18.Location = New System.Drawing.Point(328, 96)
        Me._Label_18.Name = "_Label_18"
        Me._Label_18.Size = New System.Drawing.Size(73, 17)
        Me._Label_18.TabIndex = 26
        Me._Label_18.Tag = "Position"
        Me._Label_18.Text = "Chức vụ"
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.White
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(328, 64)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(73, 17)
        Me._Label_2.TabIndex = 25
        Me._Label_2.Tag = "Employees"
        Me._Label_2.Text = "Nhân viên"
        '
        '_Line_1
        '
        Me._Line_1.Enabled = False
        Me._Line_1.Location = New System.Drawing.Point(408, 83)
        Me._Line_1.Name = "_Line_1"
        Me._Line_1.Size = New System.Drawing.Size(210, 1)
        Me._Line_1.TabIndex = 37
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.White
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_13.Location = New System.Drawing.Point(328, 128)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(73, 17)
        Me._Label_13.TabIndex = 24
        Me._Label_13.Tag = "Type salary"
        Me._Label_13.Text = "Loại lương"
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.SystemColors.Window
        Me._Label_17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.Location = New System.Drawing.Point(312, 8)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(337, 420)
        Me._Label_17.TabIndex = 23
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(576, 442)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 34
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(496, 442)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 33
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(416, 442)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 32
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.tool16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(315, 442)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(95, 25)
        Me._Command_0.TabIndex = 31
        Me._Command_0.Tag = "Adjustments"
        Me._Command_0.Text = "Điều &chỉnh"
        '
        'FrmChucdanh
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(657, 475)
        Me.Controls.Add(Me._Command_4)
        Me.Controls.Add(Me._txtVT_0)
        Me.Controls.Add(Me.SSCmdF)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me.CboThang)
        Me.Controls.Add(Me.MedNgayApdung)
        Me.Controls.Add(Me.CboChucvu)
        Me.Controls.Add(Me.CboLuong)
        Me.Controls.Add(Me.CboBacluong)
        Me.Controls.Add(Me._txtVT_17)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me._txtVT_1)
        Me.Controls.Add(Me._SSOpt_1)
        Me.Controls.Add(Me._SSOpt_0)
        Me.Controls.Add(Me.CboLoai)
        Me.Controls.Add(Me.LstVt)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Line_0)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_28)
        Me.Controls.Add(Me._Label_25)
        Me.Controls.Add(Me._Label_21)
        Me.Controls.Add(Me._Label_18)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Line_1)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me._Label_17)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(72, 67)
        Me.MaximizeBox = False
        Me.Name = "FrmChucdanh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Salary adjustments"
        Me.Text = "Điều chỉnh lương"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializetxtVT()
		Me.txtVT(0) = _txtVT_0
		Me.txtVT(17) = _txtVT_17
		Me.txtVT(1) = _txtVT_1
	End Sub
	Sub InitializeSSOpt()
		Me.SSOpt(1) = _SSOpt_1
		Me.SSOpt(0) = _SSOpt_0
	End Sub
	Sub InitializeLine()
		Me.Line(0) = _Line_0
		Me.Line(1) = _Line_1
	End Sub
	Sub InitializeLabel()
		Me.Label(1) = _Label_1
		Me.Label(0) = _Label_0
		Me.Label(28) = _Label_28
		Me.Label(25) = _Label_25
		Me.Label(21) = _Label_21
		Me.Label(18) = _Label_18
		Me.Label(2) = _Label_2
		Me.Label(13) = _Label_13
		Me.Label(17) = _Label_17
        'Me.Label(5) = _Label_5
        'Me.Label(4) = _Label_4
        'Me.Label(9) = _Label_9
	End Sub
	Sub InitializeCommand()
		Me.Command(4) = _Command_4
		Me.Command(3) = _Command_3
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
#End Region 
End Class
