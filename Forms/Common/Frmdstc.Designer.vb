<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDsTC
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
        isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		InitializeSSOpt()
		InitializeOptLK()
		InitializeMedNgay()
		InitializeLine1()
		InitializeLabel1()
		InitializeLabel()
		InitializeL()
		InitializeFrame()
		InitializeCommand()
		InitializeChkLoai()
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
    Public WithEvents cmdkh As System.Windows.Forms.Button
    Private WithEvents _Command_6 As System.Windows.Forms.Button
    Private WithEvents _Command_5 As System.Windows.Forms.Button
    Private WithEvents _Command_4 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Public WithEvents txtshkh As System.Windows.Forms.TextBox
    Private WithEvents _CboThang_2 As ComboBoxEx.ComboBoxExt
    Public WithEvents CboNguon As ComboBoxEx.ComboBoxExt
    Private WithEvents _SSOpt_0 As System.Windows.Forms.RadioButton
    Private WithEvents _SSOpt_1 As System.Windows.Forms.RadioButton
    Private WithEvents _SSOpt_2 As System.Windows.Forms.RadioButton
    Private WithEvents _Frame_0 As System.Windows.Forms.Panel
    Private WithEvents _OptLK_1 As System.Windows.Forms.RadioButton
    Private WithEvents _OptLK_0 As System.Windows.Forms.RadioButton
    Private WithEvents _CboThang_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _ChkLoai_1 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkLoai_0 As System.Windows.Forms.CheckBox
    Private WithEvents _CboThang_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _MedNgay_0 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _MedNgay_1 As System.Windows.Forms.MaskedTextBox
    Public WithEvents GrdChungtu As ListViewEx.ListviewExt
    Private WithEvents _L_3 As System.Windows.Forms.Label
    Private WithEvents _Label1_3 As System.Windows.Forms.Label
    Public WithEvents lbkh As System.Windows.Forms.Label
    Private WithEvents _Label_16 As System.Windows.Forms.Label
    Private WithEvents _Label_15 As System.Windows.Forms.Label
    Private WithEvents _L_2 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Private WithEvents _L_1 As System.Windows.Forms.Label
    Private WithEvents _L_0 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Label_9 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Line1_3 As System.Windows.Forms.Label
    Private WithEvents _Line1_2 As System.Windows.Forms.Label
    Private WithEvents _Line1_1 As System.Windows.Forms.Label
    Private WithEvents _Line1_0 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Public CboThang(2) As ComboBoxEx.ComboBoxExt
    Public ChkLoai(1) As System.Windows.Forms.CheckBox
    Public Command(6) As System.Windows.Forms.Button
    Public Command1(6) As System.Windows.Forms.Button
    Public Frame(0) As System.Windows.Forms.Panel
    Public L(3) As System.Windows.Forms.Label
    Public Label(16) As System.Windows.Forms.Label
    Public Label1(3) As System.Windows.Forms.Label
    Public Line1(3) As System.Windows.Forms.Label
    Public MedNgay(1) As System.Windows.Forms.MaskedTextBox
    Public OptLK(1) As System.Windows.Forms.RadioButton
    Public SSOpt(2) As System.Windows.Forms.RadioButton
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdkh = New System.Windows.Forms.Button
        Me._Command_6 = New System.Windows.Forms.Button
        Me._Command_5 = New System.Windows.Forms.Button
        Me._Command_4 = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me.txtshkh = New System.Windows.Forms.TextBox
        Me._CboThang_2 = New ComboBoxEx.ComboBoxExt
        Me.CboNguon = New ComboBoxEx.ComboBoxExt
        Me._Frame_0 = New System.Windows.Forms.Panel
        Me._SSOpt_0 = New System.Windows.Forms.RadioButton
        Me._SSOpt_1 = New System.Windows.Forms.RadioButton
        Me._SSOpt_2 = New System.Windows.Forms.RadioButton
        Me._OptLK_1 = New System.Windows.Forms.RadioButton
        Me._OptLK_0 = New System.Windows.Forms.RadioButton
        Me._CboThang_1 = New ComboBoxEx.ComboBoxExt
        Me._ChkLoai_1 = New System.Windows.Forms.CheckBox
        Me._ChkLoai_0 = New System.Windows.Forms.CheckBox
        Me._CboThang_0 = New ComboBoxEx.ComboBoxExt
        Me._MedNgay_0 = New System.Windows.Forms.MaskedTextBox
        Me._MedNgay_1 = New System.Windows.Forms.MaskedTextBox
        Me._L_3 = New System.Windows.Forms.Label
        Me._Label1_3 = New System.Windows.Forms.Label
        Me.lbkh = New System.Windows.Forms.Label
        Me._Label_16 = New System.Windows.Forms.Label
        Me._Label_15 = New System.Windows.Forms.Label
        Me._L_2 = New System.Windows.Forms.Label
        Me._Label_14 = New System.Windows.Forms.Label
        Me._L_1 = New System.Windows.Forms.Label
        Me._L_0 = New System.Windows.Forms.Label
        Me._Label_13 = New System.Windows.Forms.Label
        Me._Label_12 = New System.Windows.Forms.Label
        Me._Label_11 = New System.Windows.Forms.Label
        Me._Label_10 = New System.Windows.Forms.Label
        Me._Label_9 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Line1_3 = New System.Windows.Forms.Label
        Me._Line1_2 = New System.Windows.Forms.Label
        Me._Line1_1 = New System.Windows.Forms.Label
        Me._Line1_0 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Label_5 = New System.Windows.Forms.Label
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me.GrdChungtu = New ListViewEx.ListviewExt
        Me._Frame_0.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdkh
        '
        Me.cmdkh.Image = Global.UNET.My.Resources.Resources.search3_16
        Me.cmdkh.Location = New System.Drawing.Point(177, 109)
        Me.cmdkh.Name = "cmdkh"
        Me.cmdkh.Size = New System.Drawing.Size(22, 22)
        Me.cmdkh.TabIndex = 53
        '
        '_Command_6
        '
        Me._Command_6.Image = Global.UNET.My.Resources.Resources.makedocumen16
        Me._Command_6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_6.Location = New System.Drawing.Point(142, 457)
        Me._Command_6.Name = "_Command_6"
        Me._Command_6.Size = New System.Drawing.Size(107, 25)
        Me._Command_6.TabIndex = 52
        Me._Command_6.Tag = "Up bill"
        Me._Command_6.Text = "Lập &phiếu TC"
        Me._Command_6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_5
        '
        Me._Command_5.Location = New System.Drawing.Point(142, 457)
        Me._Command_5.Name = "_Command_5"
        Me._Command_5.Size = New System.Drawing.Size(107, 25)
        Me._Command_5.TabIndex = 51
        Me._Command_5.Tag = "Save to book"
        Me._Command_5.Text = "Vào sổ"
        Me._Command_5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._Command_5.Visible = False
        '
        '_Command_4
        '
        Me._Command_4.Image = Global.UNET.My.Resources.Resources.report16
        Me._Command_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_4.Location = New System.Drawing.Point(256, 457)
        Me._Command_4.Name = "_Command_4"
        Me._Command_4.Size = New System.Drawing.Size(73, 25)
        Me._Command_4.TabIndex = 50
        Me._Command_4.Tag = "Preview"
        Me._Command_4.Text = "&Xem"
        Me._Command_4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.print16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(336, 457)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 49
        Me._Command_3.Tag = "Print"
        Me._Command_3.Text = "&In"
        Me._Command_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(576, 457)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 48
        Me._Command_2.Tag = "Return"
        Me._Command_2.Text = "Trở &về"
        Me._Command_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.select16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(496, 457)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 47
        Me._Command_1.Tag = "Choose"
        Me._Command_1.Text = "&Chọn"
        Me._Command_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.list16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(416, 457)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 46
        Me._Command_0.Tag = "Listed"
        Me._Command_0.Text = "&Liệt kê"
        Me._Command_0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtshkh
        '
        Me.txtshkh.AcceptsReturn = True
        Me.txtshkh.BackColor = System.Drawing.SystemColors.Window
        Me.txtshkh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtshkh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtshkh.Location = New System.Drawing.Point(80, 112)
        Me.txtshkh.MaxLength = 20
        Me.txtshkh.Name = "txtshkh"
        Me.txtshkh.Size = New System.Drawing.Size(89, 20)
        Me.txtshkh.TabIndex = 9
        Me.txtshkh.Tag = "0"
        '
        '_CboThang_2
        '
        Me._CboThang_2.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_2.Location = New System.Drawing.Point(592, 8)
        Me._CboThang_2.Name = "_CboThang_2"
        Me._CboThang_2.Size = New System.Drawing.Size(57, 21)
        Me._CboThang_2.TabIndex = 42
        '
        'CboNguon
        '
        Me.CboNguon.BackColor = System.Drawing.SystemColors.Window
        Me.CboNguon.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboNguon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboNguon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboNguon.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboNguon.Location = New System.Drawing.Point(80, 86)
        Me.CboNguon.Name = "CboNguon"
        Me.CboNguon.Size = New System.Drawing.Size(209, 21)
        Me.CboNguon.TabIndex = 8
        '
        '_Frame_0
        '
        Me._Frame_0.BackColor = System.Drawing.Color.Transparent
        Me._Frame_0.Controls.Add(Me._SSOpt_0)
        Me._Frame_0.Controls.Add(Me._SSOpt_1)
        Me._Frame_0.Controls.Add(Me._SSOpt_2)
        Me._Frame_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Frame_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_0.Location = New System.Drawing.Point(343, 64)
        Me._Frame_0.Name = "_Frame_0"
        Me._Frame_0.Size = New System.Drawing.Size(122, 65)
        Me._Frame_0.TabIndex = 22
        Me._Frame_0.Text = "Frame1"
        '
        '_SSOpt_0
        '
        Me._SSOpt_0.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_0.Checked = True
        Me._SSOpt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_0.Location = New System.Drawing.Point(0, 0)
        Me._SSOpt_0.Name = "_SSOpt_0"
        Me._SSOpt_0.Size = New System.Drawing.Size(109, 17)
        Me._SSOpt_0.TabIndex = 25
        Me._SSOpt_0.TabStop = True
        Me._SSOpt_0.Tag = "B. Date, V. Code"
        Me._SSOpt_0.Text = "Ngày GS, Số hiệu"
        Me._SSOpt_0.UseVisualStyleBackColor = False
        '
        '_SSOpt_1
        '
        Me._SSOpt_1.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_1.Location = New System.Drawing.Point(0, 24)
        Me._SSOpt_1.Name = "_SSOpt_1"
        Me._SSOpt_1.Size = New System.Drawing.Size(109, 17)
        Me._SSOpt_1.TabIndex = 24
        Me._SSOpt_1.TabStop = True
        Me._SSOpt_1.Tag = "V. Date, V. Code"
        Me._SSOpt_1.Text = "Ngày CT, Số hiệu"
        Me._SSOpt_1.UseVisualStyleBackColor = False
        '
        '_SSOpt_2
        '
        Me._SSOpt_2.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_2.Location = New System.Drawing.Point(0, 48)
        Me._SSOpt_2.Name = "_SSOpt_2"
        Me._SSOpt_2.Size = New System.Drawing.Size(109, 17)
        Me._SSOpt_2.TabIndex = 23
        Me._SSOpt_2.TabStop = True
        Me._SSOpt_2.Tag = "V. Code"
        Me._SSOpt_2.Text = "Số hiệu CT"
        Me._SSOpt_2.UseVisualStyleBackColor = False
        '
        '_OptLK_1
        '
        Me._OptLK_1.BackColor = System.Drawing.Color.Transparent
        Me._OptLK_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptLK_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptLK_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptLK_1.Location = New System.Drawing.Point(8, 32)
        Me._OptLK_1.Name = "_OptLK_1"
        Me._OptLK_1.Size = New System.Drawing.Size(70, 17)
        Me._OptLK_1.TabIndex = 3
        Me._OptLK_1.TabStop = True
        Me._OptLK_1.Tag = "From"
        Me._OptLK_1.Text = "Từ ngày"
        Me._OptLK_1.UseVisualStyleBackColor = False
        '
        '_OptLK_0
        '
        Me._OptLK_0.BackColor = System.Drawing.Color.Transparent
        Me._OptLK_0.Checked = True
        Me._OptLK_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptLK_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptLK_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptLK_0.Location = New System.Drawing.Point(8, 9)
        Me._OptLK_0.Name = "_OptLK_0"
        Me._OptLK_0.Size = New System.Drawing.Size(70, 17)
        Me._OptLK_0.TabIndex = 0
        Me._OptLK_0.TabStop = True
        Me._OptLK_0.Tag = "From"
        Me._OptLK_0.Text = "Từ tháng"
        Me._OptLK_0.UseVisualStyleBackColor = False
        '
        '_CboThang_1
        '
        Me._CboThang_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_1.Location = New System.Drawing.Point(216, 8)
        Me._CboThang_1.Name = "_CboThang_1"
        Me._CboThang_1.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_1.TabIndex = 2
        '
        '_ChkLoai_1
        '
        Me._ChkLoai_1.BackColor = System.Drawing.Color.Transparent
        Me._ChkLoai_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkLoai_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkLoai_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkLoai_1.Location = New System.Drawing.Point(192, 64)
        Me._ChkLoai_1.Name = "_ChkLoai_1"
        Me._ChkLoai_1.Size = New System.Drawing.Size(81, 17)
        Me._ChkLoai_1.TabIndex = 7
        Me._ChkLoai_1.Tag = "Money out"
        Me._ChkLoai_1.Text = "Phiếu chi"
        Me._ChkLoai_1.UseVisualStyleBackColor = False
        '
        '_ChkLoai_0
        '
        Me._ChkLoai_0.BackColor = System.Drawing.Color.Transparent
        Me._ChkLoai_0.Checked = True
        Me._ChkLoai_0.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkLoai_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkLoai_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkLoai_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkLoai_0.Location = New System.Drawing.Point(16, 64)
        Me._ChkLoai_0.Name = "_ChkLoai_0"
        Me._ChkLoai_0.Size = New System.Drawing.Size(81, 17)
        Me._ChkLoai_0.TabIndex = 6
        Me._ChkLoai_0.Tag = "Money in"
        Me._ChkLoai_0.Text = "Phiếu thu"
        Me._ChkLoai_0.UseVisualStyleBackColor = False
        '
        '_CboThang_0
        '
        Me._CboThang_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_0.Location = New System.Drawing.Point(80, 8)
        Me._CboThang_0.Name = "_CboThang_0"
        Me._CboThang_0.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_0.TabIndex = 1
        '
        '_MedNgay_0
        '
        Me._MedNgay_0.AllowPromptAsInput = False
        Me._MedNgay_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_0.Location = New System.Drawing.Point(80, 31)
        Me._MedNgay_0.Mask = "00/00/0000"
        Me._MedNgay_0.Name = "_MedNgay_0"
        Me._MedNgay_0.Size = New System.Drawing.Size(73, 20)
        Me._MedNgay_0.TabIndex = 4
        '
        '_MedNgay_1
        '
        Me._MedNgay_1.AllowPromptAsInput = False
        Me._MedNgay_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_1.Location = New System.Drawing.Point(216, 31)
        Me._MedNgay_1.Mask = "00/00/0000"
        Me._MedNgay_1.Name = "_MedNgay_1"
        Me._MedNgay_1.Size = New System.Drawing.Size(73, 20)
        Me._MedNgay_1.TabIndex = 5
        '
        '_L_3
        '
        Me._L_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._L_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._L_3.ForeColor = System.Drawing.Color.Red
        Me._L_3.Location = New System.Drawing.Point(79, 461)
        Me._L_3.Name = "_L_3"
        Me._L_3.Size = New System.Drawing.Size(57, 17)
        Me._L_3.TabIndex = 40
        Me._L_3.Text = "0"
        '
        '_Label1_3
        '
        Me._Label1_3.BackColor = System.Drawing.Color.Transparent
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_3.Location = New System.Drawing.Point(16, 112)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.Size = New System.Drawing.Size(57, 17)
        Me._Label1_3.TabIndex = 44
        Me._Label1_3.Tag = "Object"
        Me._Label1_3.Text = "Đối tượng"
        '
        'lbkh
        '
        Me.lbkh.BackColor = System.Drawing.Color.Transparent
        Me.lbkh.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbkh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbkh.ForeColor = System.Drawing.Color.Blue
        Me.lbkh.Location = New System.Drawing.Point(208, 113)
        Me.lbkh.Name = "lbkh"
        Me.lbkh.Size = New System.Drawing.Size(145, 17)
        Me.lbkh.TabIndex = 43
        Me.lbkh.Tag = "1"
        '
        '_Label_16
        '
        Me._Label_16.BackColor = System.Drawing.Color.Transparent
        Me._Label_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_16.Location = New System.Drawing.Point(536, 11)
        Me._Label_16.Name = "_Label_16"
        Me._Label_16.Size = New System.Drawing.Size(57, 17)
        Me._Label_16.TabIndex = 41
        Me._Label_16.Tag = "Account"
        Me._Label_16.Text = "Tài khoản"
        '
        '_Label_15
        '
        Me._Label_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_15.Location = New System.Drawing.Point(8, 461)
        Me._Label_15.Name = "_Label_15"
        Me._Label_15.Size = New System.Drawing.Size(65, 17)
        Me._Label_15.TabIndex = 39
        Me._Label_15.Tag = "Number of Voucher"
        Me._Label_15.Text = "Số phiếu"
        '
        '_L_2
        '
        Me._L_2.BackColor = System.Drawing.Color.Transparent
        Me._L_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._L_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._L_2.ForeColor = System.Drawing.Color.Teal
        Me._L_2.Location = New System.Drawing.Point(544, 112)
        Me._L_2.Name = "_L_2"
        Me._L_2.Size = New System.Drawing.Size(97, 17)
        Me._L_2.TabIndex = 36
        Me._L_2.Text = "0"
        Me._L_2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.Color.Transparent
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_14.Location = New System.Drawing.Point(487, 114)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(65, 17)
        Me._Label_14.TabIndex = 35
        Me._Label_14.Tag = "Result"
        Me._Label_14.Text = "Chênh lệch"
        '
        '_L_1
        '
        Me._L_1.BackColor = System.Drawing.Color.Transparent
        Me._L_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._L_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._L_1.ForeColor = System.Drawing.Color.Teal
        Me._L_1.Location = New System.Drawing.Point(536, 88)
        Me._L_1.Name = "_L_1"
        Me._L_1.Size = New System.Drawing.Size(105, 17)
        Me._L_1.TabIndex = 34
        Me._L_1.Text = "0"
        Me._L_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_L_0
        '
        Me._L_0.BackColor = System.Drawing.Color.Transparent
        Me._L_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._L_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._L_0.ForeColor = System.Drawing.Color.Teal
        Me._L_0.Location = New System.Drawing.Point(536, 64)
        Me._L_0.Name = "_L_0"
        Me._L_0.Size = New System.Drawing.Size(105, 17)
        Me._L_0.TabIndex = 33
        Me._L_0.Text = "0"
        Me._L_0.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.Transparent
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_13.Location = New System.Drawing.Point(487, 89)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(57, 17)
        Me._Label_13.TabIndex = 32
        Me._Label_13.Tag = "Expense"
        Me._Label_13.Text = "Tổng chi"
        '
        '_Label_12
        '
        Me._Label_12.BackColor = System.Drawing.Color.Transparent
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_12.Location = New System.Drawing.Point(487, 64)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.Size = New System.Drawing.Size(57, 17)
        Me._Label_12.TabIndex = 31
        Me._Label_12.Tag = "Income"
        Me._Label_12.Text = "Tổng thu"
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.Color.Black
        Me._Label_11.Location = New System.Drawing.Point(544, 152)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(87, 17)
        Me._Label_11.TabIndex = 30
        Me._Label_11.Tag = "Expense"
        Me._Label_11.Text = "Chi"
        Me._Label_11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.Transparent
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_10.Location = New System.Drawing.Point(16, 88)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(57, 17)
        Me._Label_10.TabIndex = 29
        Me._Label_10.Tag = "Index"
        Me._Label_10.Text = "Bộ phận"
        '
        '_Label_9
        '
        Me._Label_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.Color.Black
        Me._Label_9.Location = New System.Drawing.Point(456, 152)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.Size = New System.Drawing.Size(89, 17)
        Me._Label_9.TabIndex = 28
        Me._Label_9.Tag = "Income"
        Me._Label_9.Text = "Thu"
        Me._Label_9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.Color.Black
        Me._Label_8.Location = New System.Drawing.Point(344, 152)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(113, 17)
        Me._Label_8.TabIndex = 27
        Me._Label_8.Tag = "Reason"
        Me._Label_8.Text = "Lý do thu/chi"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(248, 152)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(97, 17)
        Me._Label_7.TabIndex = 26
        Me._Label_7.Tag = "Address"
        Me._Label_7.Text = "Địa chỉ"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(154, 34)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(58, 17)
        Me._Label_0.TabIndex = 21
        Me._Label_0.Tag = "to"
        Me._Label_0.Text = "Đến ngày"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Line1_3
        '
        Me._Line1_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._Line1_3.Enabled = False
        Me._Line1_3.Location = New System.Drawing.Point(8, 56)
        Me._Line1_3.Name = "_Line1_3"
        Me._Line1_3.Size = New System.Drawing.Size(1, 88)
        Me._Line1_3.TabIndex = 54
        '
        '_Line1_2
        '
        Me._Line1_2.BackColor = System.Drawing.SystemColors.Window
        Me._Line1_2.Enabled = False
        Me._Line1_2.Location = New System.Drawing.Point(648, 56)
        Me._Line1_2.Name = "_Line1_2"
        Me._Line1_2.Size = New System.Drawing.Size(1, 88)
        Me._Line1_2.TabIndex = 55
        '
        '_Line1_1
        '
        Me._Line1_1.BackColor = System.Drawing.SystemColors.Window
        Me._Line1_1.Enabled = False
        Me._Line1_1.Location = New System.Drawing.Point(8, 144)
        Me._Line1_1.Name = "_Line1_1"
        Me._Line1_1.Size = New System.Drawing.Size(640, 1)
        Me._Line1_1.TabIndex = 56
        '
        '_Line1_0
        '
        Me._Line1_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._Line1_0.Enabled = False
        Me._Line1_0.Location = New System.Drawing.Point(8, 56)
        Me._Line1_0.Name = "_Line1_0"
        Me._Line1_0.Size = New System.Drawing.Size(640, 1)
        Me._Line1_0.TabIndex = 57
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.Transparent
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_6.Location = New System.Drawing.Point(152, 11)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(62, 17)
        Me._Label_6.TabIndex = 16
        Me._Label_6.Tag = "to"
        Me._Label_6.Text = "Đến tháng"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.Transparent
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_5.Location = New System.Drawing.Point(280, 64)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(57, 17)
        Me._Label_5.TabIndex = 15
        Me._Label_5.Tag = "Sort by"
        Me._Label_5.Text = "Thứ tự"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(152, 152)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(97, 17)
        Me._Label_4.TabIndex = 14
        Me._Label_4.Tag = "Name"
        Me._Label_4.Text = "Họ tên"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.Black
        Me._Label_2.Location = New System.Drawing.Point(96, 152)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(57, 17)
        Me._Label_2.TabIndex = 13
        Me._Label_2.Tag = "V. Date"
        Me._Label_2.Text = "Ngày CT"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(8, 152)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(89, 17)
        Me._Label_1.TabIndex = 12
        Me._Label_1.Tag = "V. Code"
        Me._Label_1.Text = "Số CT"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GrdChungtu
        '
        Me.GrdChungtu.AllowColumnResize = True
        Me.GrdChungtu.AllowMultiselect = False
        Me.GrdChungtu.AlternateBackground = System.Drawing.Color.DarkGreen
        Me.GrdChungtu.AlternatingColors = False
        Me.GrdChungtu.AutoHeight = True
        Me.GrdChungtu.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdChungtu.BackgroundStretchToFit = True
        Me.GrdChungtu.Col = 0
        Me.GrdChungtu.Cols = 0
        Me.GrdChungtu.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me.GrdChungtu.FullRowSelect = True
        Me.GrdChungtu.GridColor = System.Drawing.Color.LightGray
        Me.GrdChungtu.GridLines = ListViewEx.GLGridLines.gridBoth
        Me.GrdChungtu.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me.GrdChungtu.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me.GrdChungtu.HeaderHeight = 22
        Me.GrdChungtu.HeaderVisible = True
        Me.GrdChungtu.HeaderWordWrap = False
        Me.GrdChungtu.HotColumnTracking = False
        Me.GrdChungtu.HotItemTracking = False
        Me.GrdChungtu.HotTrackingColor = System.Drawing.Color.LightGray
        Me.GrdChungtu.HoverEvents = False
        Me.GrdChungtu.HoverTime = 1
        Me.GrdChungtu.ImageList = Nothing
        Me.GrdChungtu.ItemHeight = 18
        Me.GrdChungtu.ItemWordWrap = False
        Me.GrdChungtu.Location = New System.Drawing.Point(8, 168)
        Me.GrdChungtu.Name = "GrdChungtu"
        Me.GrdChungtu.Row = 0
        Me.GrdChungtu.Rows = 0
        Me.GrdChungtu.Selectable = True
        Me.GrdChungtu.SelectedTextColor = System.Drawing.Color.White
        Me.GrdChungtu.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.GrdChungtu.ShowBorder = True
        Me.GrdChungtu.ShowFocusRect = False
        Me.GrdChungtu.Size = New System.Drawing.Size(641, 282)
        Me.GrdChungtu.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdChungtu.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdChungtu.TabIndex = 10
        '
        'FrmDsTC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(657, 489)
        Me.Controls.Add(Me.GrdChungtu)
        Me.Controls.Add(Me.cmdkh)
        Me.Controls.Add(Me._Command_6)
        Me.Controls.Add(Me._Command_5)
        Me.Controls.Add(Me._Command_4)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me.txtshkh)
        Me.Controls.Add(Me._CboThang_2)
        Me.Controls.Add(Me.CboNguon)
        Me.Controls.Add(Me._Frame_0)
        Me.Controls.Add(Me._OptLK_1)
        Me.Controls.Add(Me._OptLK_0)
        Me.Controls.Add(Me._CboThang_1)
        Me.Controls.Add(Me._ChkLoai_1)
        Me.Controls.Add(Me._ChkLoai_0)
        Me.Controls.Add(Me._CboThang_0)
        Me.Controls.Add(Me._MedNgay_0)
        Me.Controls.Add(Me._MedNgay_1)
        Me.Controls.Add(Me._L_3)
        Me.Controls.Add(Me._Label1_3)
        Me.Controls.Add(Me.lbkh)
        Me.Controls.Add(Me._Label_16)
        Me.Controls.Add(Me._Label_15)
        Me.Controls.Add(Me._L_2)
        Me.Controls.Add(Me._Label_14)
        Me.Controls.Add(Me._L_1)
        Me.Controls.Add(Me._L_0)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me._Label_12)
        Me.Controls.Add(Me._Label_11)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Label_9)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Line1_3)
        Me.Controls.Add(Me._Line1_2)
        Me.Controls.Add(Me._Line1_1)
        Me.Controls.Add(Me._Line1_0)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_5)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(17, 26)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDsTC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Cash Voucher List"
        Me.Text = "Danh sách phiếu thu chi"
        Me._Frame_0.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializeSSOpt()
		Me.SSOpt(0) = _SSOpt_0
		Me.SSOpt(1) = _SSOpt_1
		Me.SSOpt(2) = _SSOpt_2
	End Sub
	Sub InitializeOptLK()
		Me.OptLK(1) = _OptLK_1
		Me.OptLK(0) = _OptLK_0
	End Sub
	Sub InitializeMedNgay()
		Me.MedNgay(0) = _MedNgay_0
		Me.MedNgay(1) = _MedNgay_1
	End Sub
	Sub InitializeLine1()
		Me.Line1(3) = _Line1_3
		Me.Line1(2) = _Line1_2
		Me.Line1(1) = _Line1_1
		Me.Line1(0) = _Line1_0
	End Sub
	Sub InitializeLabel1()
		Me.Label1(3) = _Label1_3
	End Sub
	Sub InitializeLabel()
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
		Me.Label(0) = _Label_0
		Me.Label(6) = _Label_6
		Me.Label(5) = _Label_5
		Me.Label(4) = _Label_4
		Me.Label(2) = _Label_2
		Me.Label(1) = _Label_1
	End Sub
	Sub InitializeL()
		Me.L(3) = _L_3
		Me.L(2) = _L_2
		Me.L(1) = _L_1
		Me.L(0) = _L_0
	End Sub
	Sub InitializeFrame()
		Me.Frame(0) = _Frame_0
	End Sub
	Sub InitializeCommand()
		Me.Command(6) = _Command_6
		Me.Command(5) = _Command_5
		Me.Command(4) = _Command_4
		Me.Command(3) = _Command_3
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
	Sub InitializeChkLoai()
		Me.ChkLoai(1) = _ChkLoai_1
		Me.ChkLoai(0) = _ChkLoai_0
	End Sub
	Sub InitializeCboThang()
		Me.CboThang(2) = _CboThang_2
		Me.CboThang(1) = _CboThang_1
		Me.CboThang(0) = _CboThang_0
	End Sub
#End Region 
End Class
