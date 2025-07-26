<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDsCTTonghop
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
        isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		InitializetxtShTk()
		InitializeSSOpt()
		InitializeOptLK()
		InitializeMedNgay()
		InitializeLbTenTk()
		InitializeLabel()
		InitializeFrame2()
		InitializeCommand()
		InitializeCmdTK()
		InitializeChkTaikhoan()
		InitializeChkLoai()
		InitializeCboThang()
		InitializeCboN()
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
    Private WithEvents _Command_7 As System.Windows.Forms.Button
    Private WithEvents _MedNgay_0 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _ChkLoai_12 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkLoai_11 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkLoai_0 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkLoai_1 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkLoai_2 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkLoai_3 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkLoai_9 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkLoai_10 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkLoai_8 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkLoai_7 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkLoai_13 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkLoai_14 As System.Windows.Forms.CheckBox
    Public WithEvents Frame1 As System.Windows.Forms.Panel
    Private WithEvents _OptLK_1 As System.Windows.Forms.RadioButton
    Private WithEvents _Command_4 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command_6 As System.Windows.Forms.Button
    Private WithEvents _Command_5 As System.Windows.Forms.Button
    Private WithEvents _OptLK_0 As System.Windows.Forms.RadioButton
    Private WithEvents _CboThang_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboThang_0 As ComboBoxEx.ComboBoxExt
    Public WithEvents GrdChungtu As ListviewEx.ListviewExt
    Private WithEvents _MedNgay_1 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _txtShTk_5 As System.Windows.Forms.TextBox
    Private WithEvents _txtShTk_0 As System.Windows.Forms.TextBox
    Private WithEvents _txtShTk_2 As System.Windows.Forms.TextBox
    Private WithEvents _CboN_2 As ComboBoxEx.ComboBoxExt
    Private WithEvents _txtShTk_4 As System.Windows.Forms.TextBox
    Private WithEvents _txtShTk_6 As System.Windows.Forms.TextBox
    Private WithEvents _txtShTk_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtShTk_3 As System.Windows.Forms.TextBox
    Private WithEvents _ChkTaikhoan_0 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkTaikhoan_1 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkTaikhoan_2 As System.Windows.Forms.CheckBox
    Private WithEvents _SSOpt_2 As System.Windows.Forms.RadioButton
    Private WithEvents _SSOpt_1 As System.Windows.Forms.RadioButton
    Private WithEvents _SSOpt_0 As System.Windows.Forms.RadioButton
    Public WithEvents Frame As System.Windows.Forms.Panel
    Private WithEvents _ChkTaikhoan_3 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkTaikhoan_4 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkTaikhoan_5 As System.Windows.Forms.CheckBox
    Private WithEvents _CboN_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboN_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _ChkTaikhoan_6 As System.Windows.Forms.CheckBox
    Private WithEvents _CboN_3 As ComboBoxEx.ComboBoxExt
    Private WithEvents _ChkTaikhoan_7 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkTaikhoan_8 As System.Windows.Forms.CheckBox
    Private WithEvents _CmdTK_2 As System.Windows.Forms.Button
    Private WithEvents _CmdTK_3 As System.Windows.Forms.Button
    Private WithEvents _CmdTK_1 As System.Windows.Forms.Button
    Private WithEvents _CmdTK_0 As System.Windows.Forms.Button
    Private WithEvents _CmdTK_6 As System.Windows.Forms.Button
    Private WithEvents _LbTenTk_0 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_1 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_2 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_3 As System.Windows.Forms.Label
    Private WithEvents _Label_9 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_6 As System.Windows.Forms.Label
    Private WithEvents _Frame2_0 As System.Windows.Forms.GroupBox
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Public WithEvents LbSoCT As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Public CboN(3) As ComboBoxEx.ComboBoxExt
    Public CboThang(1) As ComboBoxEx.ComboBoxExt
    Public ChkLoai(14) As System.Windows.Forms.CheckBox
    Public ChkTaikhoan(8) As System.Windows.Forms.CheckBox
    Public CmdTK(6) As System.Windows.Forms.Button
    Public CmdTK1(6) As System.Windows.Forms.Button
    Public Command(7) As System.Windows.Forms.Button
    Public Command1(6) As System.Windows.Forms.Button
    Public Frame2(0) As System.Windows.Forms.GroupBox
    Public Label(13) As System.Windows.Forms.Label
    Public LbTenTk(6) As System.Windows.Forms.Label
    Public MedNgay(1) As System.Windows.Forms.MaskedTextBox
    Public OptLK(1) As System.Windows.Forms.RadioButton
    Public SSOpt(2) As System.Windows.Forms.RadioButton
    Public txtShTk(6) As System.Windows.Forms.TextBox
    'Private listBoxComboBoxHelper1 As Artinsoft.VB6.Gui.ListControlHelper
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me._Command_7 = New System.Windows.Forms.Button
        Me._MedNgay_0 = New System.Windows.Forms.MaskedTextBox
        Me.Frame1 = New System.Windows.Forms.Panel
        Me._ChkLoai_12 = New System.Windows.Forms.CheckBox
        Me._ChkLoai_11 = New System.Windows.Forms.CheckBox
        Me._ChkLoai_0 = New System.Windows.Forms.CheckBox
        Me._ChkLoai_1 = New System.Windows.Forms.CheckBox
        Me._ChkLoai_2 = New System.Windows.Forms.CheckBox
        Me._ChkLoai_3 = New System.Windows.Forms.CheckBox
        Me._ChkLoai_9 = New System.Windows.Forms.CheckBox
        Me._ChkLoai_10 = New System.Windows.Forms.CheckBox
        Me._ChkLoai_8 = New System.Windows.Forms.CheckBox
        Me._ChkLoai_7 = New System.Windows.Forms.CheckBox
        Me._ChkLoai_13 = New System.Windows.Forms.CheckBox
        Me._ChkLoai_14 = New System.Windows.Forms.CheckBox
        Me._OptLK_1 = New System.Windows.Forms.RadioButton
        Me._Command_4 = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Command_6 = New System.Windows.Forms.Button
        Me._Command_5 = New System.Windows.Forms.Button
        Me._OptLK_0 = New System.Windows.Forms.RadioButton
        Me._CboThang_1 = New ComboBoxEx.ComboBoxExt
        Me._CboThang_0 = New ComboBoxEx.ComboBoxExt
        Me._MedNgay_1 = New System.Windows.Forms.MaskedTextBox
        Me._Frame2_0 = New System.Windows.Forms.GroupBox
        Me._txtShTk_5 = New System.Windows.Forms.TextBox
        Me._txtShTk_0 = New System.Windows.Forms.TextBox
        Me._txtShTk_2 = New System.Windows.Forms.TextBox
        Me._CboN_2 = New ComboBoxEx.ComboBoxExt
        Me._txtShTk_4 = New System.Windows.Forms.TextBox
        Me._txtShTk_6 = New System.Windows.Forms.TextBox
        Me._txtShTk_1 = New System.Windows.Forms.TextBox
        Me._txtShTk_3 = New System.Windows.Forms.TextBox
        Me._ChkTaikhoan_0 = New System.Windows.Forms.CheckBox
        Me._ChkTaikhoan_1 = New System.Windows.Forms.CheckBox
        Me._ChkTaikhoan_2 = New System.Windows.Forms.CheckBox
        Me.Frame = New System.Windows.Forms.Panel
        Me._SSOpt_2 = New System.Windows.Forms.RadioButton
        Me._SSOpt_1 = New System.Windows.Forms.RadioButton
        Me._SSOpt_0 = New System.Windows.Forms.RadioButton
        Me._ChkTaikhoan_3 = New System.Windows.Forms.CheckBox
        Me._ChkTaikhoan_4 = New System.Windows.Forms.CheckBox
        Me._ChkTaikhoan_5 = New System.Windows.Forms.CheckBox
        Me._CboN_1 = New ComboBoxEx.ComboBoxExt
        Me._CboN_0 = New ComboBoxEx.ComboBoxExt
        Me._ChkTaikhoan_6 = New System.Windows.Forms.CheckBox
        Me._CboN_3 = New ComboBoxEx.ComboBoxExt
        Me._ChkTaikhoan_7 = New System.Windows.Forms.CheckBox
        Me._ChkTaikhoan_8 = New System.Windows.Forms.CheckBox
        Me._CmdTK_2 = New System.Windows.Forms.Button
        Me._CmdTK_3 = New System.Windows.Forms.Button
        Me._CmdTK_1 = New System.Windows.Forms.Button
        Me._CmdTK_0 = New System.Windows.Forms.Button
        Me._CmdTK_6 = New System.Windows.Forms.Button
        Me._LbTenTk_0 = New System.Windows.Forms.Label
        Me._LbTenTk_1 = New System.Windows.Forms.Label
        Me._Label_5 = New System.Windows.Forms.Label
        Me._LbTenTk_2 = New System.Windows.Forms.Label
        Me._LbTenTk_3 = New System.Windows.Forms.Label
        Me._Label_9 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Label_10 = New System.Windows.Forms.Label
        Me._LbTenTk_6 = New System.Windows.Forms.Label
        Me._Label_13 = New System.Windows.Forms.Label
        Me.LbSoCT = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me.GrdChungtu = New ListViewEx.ListviewExt
        Me.Frame1.SuspendLayout()
        Me._Frame2_0.SuspendLayout()
        Me.Frame.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Command_7
        '
        Me._Command_7.Image = Global.UNET.My.Resources.Resources.makedocumen16
        Me._Command_7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_7.Location = New System.Drawing.Point(96, 530)
        Me._Command_7.Name = "_Command_7"
        Me._Command_7.Size = New System.Drawing.Size(89, 25)
        Me._Command_7.TabIndex = 43
        Me._Command_7.Tag = "Up Votes I/E"
        Me._Command_7.Text = "Lập &phiếu NX"
        Me._Command_7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._Command_7.Visible = False
        '
        '_MedNgay_0
        '
        Me._MedNgay_0.AllowPromptAsInput = False
        Me._MedNgay_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_0.Location = New System.Drawing.Point(80, 40)
        Me._MedNgay_0.Mask = "00/00/0000"
        Me._MedNgay_0.Name = "_MedNgay_0"
        Me._MedNgay_0.Size = New System.Drawing.Size(73, 20)
        Me._MedNgay_0.TabIndex = 4
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.Transparent
        Me.Frame1.Controls.Add(Me._ChkLoai_12)
        Me.Frame1.Controls.Add(Me._ChkLoai_11)
        Me.Frame1.Controls.Add(Me._ChkLoai_0)
        Me.Frame1.Controls.Add(Me._ChkLoai_1)
        Me.Frame1.Controls.Add(Me._ChkLoai_2)
        Me.Frame1.Controls.Add(Me._ChkLoai_3)
        Me.Frame1.Controls.Add(Me._ChkLoai_9)
        Me.Frame1.Controls.Add(Me._ChkLoai_10)
        Me.Frame1.Controls.Add(Me._ChkLoai_8)
        Me.Frame1.Controls.Add(Me._ChkLoai_7)
        Me.Frame1.Controls.Add(Me._ChkLoai_13)
        Me.Frame1.Controls.Add(Me._ChkLoai_14)
        Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(296, -8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(361, 82)
        Me.Frame1.TabIndex = 30
        '
        '_ChkLoai_12
        '
        Me._ChkLoai_12.BackColor = System.Drawing.Color.Transparent
        Me._ChkLoai_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkLoai_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkLoai_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkLoai_12.Location = New System.Drawing.Point(256, 48)
        Me._ChkLoai_12.Name = "_ChkLoai_12"
        Me._ChkLoai_12.Size = New System.Drawing.Size(97, 17)
        Me._ChkLoai_12.TabIndex = 35
        Me._ChkLoai_12.Tag = "Depreciation"
        Me._ChkLoai_12.Text = "Trích khấu hao"
        Me._ChkLoai_12.UseVisualStyleBackColor = False
        '
        '_ChkLoai_11
        '
        Me._ChkLoai_11.BackColor = System.Drawing.Color.Transparent
        Me._ChkLoai_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkLoai_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkLoai_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkLoai_11.Location = New System.Drawing.Point(176, 48)
        Me._ChkLoai_11.Name = "_ChkLoai_11"
        Me._ChkLoai_11.Size = New System.Drawing.Size(84, 17)
        Me._ChkLoai_11.TabIndex = 36
        Me._ChkLoai_11.Tag = "Revaluation"
        Me._ChkLoai_11.Text = "Đánh giá lại"
        Me._ChkLoai_11.UseVisualStyleBackColor = False
        '
        '_ChkLoai_0
        '
        Me._ChkLoai_0.BackColor = System.Drawing.Color.Transparent
        Me._ChkLoai_0.Checked = True
        Me._ChkLoai_0.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkLoai_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkLoai_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkLoai_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkLoai_0.Location = New System.Drawing.Point(8, 16)
        Me._ChkLoai_0.Name = "_ChkLoai_0"
        Me._ChkLoai_0.Size = New System.Drawing.Size(86, 17)
        Me._ChkLoai_0.TabIndex = 42
        Me._ChkLoai_0.Tag = "Common"
        Me._ChkLoai_0.Text = "CT tổng hợp"
        Me._ChkLoai_0.UseVisualStyleBackColor = False
        '
        '_ChkLoai_1
        '
        Me._ChkLoai_1.BackColor = System.Drawing.Color.Transparent
        Me._ChkLoai_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkLoai_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkLoai_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkLoai_1.Location = New System.Drawing.Point(8, 32)
        Me._ChkLoai_1.Name = "_ChkLoai_1"
        Me._ChkLoai_1.Size = New System.Drawing.Size(83, 17)
        Me._ChkLoai_1.TabIndex = 41
        Me._ChkLoai_1.Tag = "Import"
        Me._ChkLoai_1.Text = "Nhập vật tư"
        Me._ChkLoai_1.UseVisualStyleBackColor = False
        '
        '_ChkLoai_2
        '
        Me._ChkLoai_2.BackColor = System.Drawing.Color.Transparent
        Me._ChkLoai_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkLoai_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkLoai_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkLoai_2.Location = New System.Drawing.Point(96, 32)
        Me._ChkLoai_2.Name = "_ChkLoai_2"
        Me._ChkLoai_2.Size = New System.Drawing.Size(79, 17)
        Me._ChkLoai_2.TabIndex = 40
        Me._ChkLoai_2.Tag = "Export"
        Me._ChkLoai_2.Text = "Xuất vật tư"
        Me._ChkLoai_2.UseVisualStyleBackColor = False
        '
        '_ChkLoai_3
        '
        Me._ChkLoai_3.BackColor = System.Drawing.Color.Transparent
        Me._ChkLoai_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkLoai_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkLoai_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkLoai_3.Location = New System.Drawing.Point(256, 32)
        Me._ChkLoai_3.Name = "_ChkLoai_3"
        Me._ChkLoai_3.Size = New System.Drawing.Size(97, 17)
        Me._ChkLoai_3.TabIndex = 39
        Me._ChkLoai_3.Tag = "Conversion"
        Me._ChkLoai_3.Text = "Kết chuyển"
        Me._ChkLoai_3.UseVisualStyleBackColor = False
        '
        '_ChkLoai_9
        '
        Me._ChkLoai_9.BackColor = System.Drawing.Color.Transparent
        Me._ChkLoai_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkLoai_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkLoai_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkLoai_9.Location = New System.Drawing.Point(8, 48)
        Me._ChkLoai_9.Name = "_ChkLoai_9"
        Me._ChkLoai_9.Size = New System.Drawing.Size(83, 17)
        Me._ChkLoai_9.TabIndex = 38
        Me._ChkLoai_9.Tag = "Inc. Assets"
        Me._ChkLoai_9.Text = "Tăng TSCĐ"
        Me._ChkLoai_9.UseVisualStyleBackColor = False
        '
        '_ChkLoai_10
        '
        Me._ChkLoai_10.BackColor = System.Drawing.Color.Transparent
        Me._ChkLoai_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkLoai_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkLoai_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkLoai_10.Location = New System.Drawing.Point(96, 48)
        Me._ChkLoai_10.Name = "_ChkLoai_10"
        Me._ChkLoai_10.Size = New System.Drawing.Size(82, 17)
        Me._ChkLoai_10.TabIndex = 37
        Me._ChkLoai_10.Tag = "Dec. Assets"
        Me._ChkLoai_10.Text = "Giảm TSCĐ"
        Me._ChkLoai_10.UseVisualStyleBackColor = False
        '
        '_ChkLoai_8
        '
        Me._ChkLoai_8.BackColor = System.Drawing.Color.Transparent
        Me._ChkLoai_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkLoai_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkLoai_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkLoai_8.Location = New System.Drawing.Point(176, 32)
        Me._ChkLoai_8.Name = "_ChkLoai_8"
        Me._ChkLoai_8.Size = New System.Drawing.Size(76, 17)
        Me._ChkLoai_8.TabIndex = 34
        Me._ChkLoai_8.Tag = "Sale"
        Me._ChkLoai_8.Text = "Bán hàng"
        Me._ChkLoai_8.UseVisualStyleBackColor = False
        '
        '_ChkLoai_7
        '
        Me._ChkLoai_7.BackColor = System.Drawing.Color.Transparent
        Me._ChkLoai_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkLoai_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkLoai_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkLoai_7.Location = New System.Drawing.Point(256, 16)
        Me._ChkLoai_7.Name = "_ChkLoai_7"
        Me._ChkLoai_7.Size = New System.Drawing.Size(81, 17)
        Me._ChkLoai_7.TabIndex = 33
        Me._ChkLoai_7.Tag = "Quotation"
        Me._ChkLoai_7.Text = "Báo giá"
        Me._ChkLoai_7.UseVisualStyleBackColor = False
        '
        '_ChkLoai_13
        '
        Me._ChkLoai_13.BackColor = System.Drawing.Color.Transparent
        Me._ChkLoai_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkLoai_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkLoai_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkLoai_13.Location = New System.Drawing.Point(8, 64)
        Me._ChkLoai_13.Name = "_ChkLoai_13"
        Me._ChkLoai_13.Size = New System.Drawing.Size(83, 17)
        Me._ChkLoai_13.TabIndex = 32
        Me._ChkLoai_13.Tag = "Inc. Assets"
        Me._ChkLoai_13.Text = "Tăng CCDC"
        Me._ChkLoai_13.UseVisualStyleBackColor = False
        '
        '_ChkLoai_14
        '
        Me._ChkLoai_14.BackColor = System.Drawing.Color.Transparent
        Me._ChkLoai_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkLoai_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkLoai_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkLoai_14.Location = New System.Drawing.Point(256, 64)
        Me._ChkLoai_14.Name = "_ChkLoai_14"
        Me._ChkLoai_14.Size = New System.Drawing.Size(97, 17)
        Me._ChkLoai_14.TabIndex = 31
        Me._ChkLoai_14.Tag = "Inc. Assets"
        Me._ChkLoai_14.Text = "Trích phân bổ"
        Me._ChkLoai_14.UseVisualStyleBackColor = False
        '
        '_OptLK_1
        '
        Me._OptLK_1.BackColor = System.Drawing.Color.Transparent
        Me._OptLK_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptLK_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptLK_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptLK_1.Location = New System.Drawing.Point(7, 39)
        Me._OptLK_1.Name = "_OptLK_1"
        Me._OptLK_1.Size = New System.Drawing.Size(70, 17)
        Me._OptLK_1.TabIndex = 3
        Me._OptLK_1.TabStop = True
        Me._OptLK_1.Tag = "From"
        Me._OptLK_1.Text = "Từ ngày"
        Me._OptLK_1.UseVisualStyleBackColor = False
        '
        '_Command_4
        '
        Me._Command_4.Image = Global.UNET.My.Resources.Resources.print16
        Me._Command_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_4.Location = New System.Drawing.Point(344, 530)
        Me._Command_4.Name = "_Command_4"
        Me._Command_4.Size = New System.Drawing.Size(65, 25)
        Me._Command_4.TabIndex = 29
        Me._Command_4.Tag = "Print"
        Me._Command_4.Text = "&In"
        Me._Command_4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.report16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(272, 530)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(65, 25)
        Me._Command_3.TabIndex = 28
        Me._Command_3.Tag = "Preview"
        Me._Command_3.Text = "&Xem"
        Me._Command_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(576, 530)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 27
        Me._Command_2.Tag = "Return"
        Me._Command_2.Text = "Trở &về"
        Me._Command_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.select16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(496, 530)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 26
        Me._Command_1.Tag = "Choose"
        Me._Command_1.Text = "&Chọn"
        Me._Command_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.list16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(416, 530)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 25
        Me._Command_0.Tag = "Listed"
        Me._Command_0.Text = "&Liệt kê"
        Me._Command_0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_6
        '
        Me._Command_6.Image = Global.UNET.My.Resources.Resources.kenh_phan_phoi_16
        Me._Command_6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_6.Location = New System.Drawing.Point(192, 530)
        Me._Command_6.Name = "_Command_6"
        Me._Command_6.Size = New System.Drawing.Size(73, 25)
        Me._Command_6.TabIndex = 24
        Me._Command_6.Tag = "Change Acc"
        Me._Command_6.Text = "Đổi T&K"
        Me._Command_6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._Command_6.Visible = False
        '
        '_Command_5
        '
        Me._Command_5.Location = New System.Drawing.Point(95, 530)
        Me._Command_5.Name = "_Command_5"
        Me._Command_5.Size = New System.Drawing.Size(89, 25)
        Me._Command_5.TabIndex = 23
        Me._Command_5.Tag = "Save to book"
        Me._Command_5.Text = "Vào sổ"
        Me._Command_5.Visible = False
        '
        '_OptLK_0
        '
        Me._OptLK_0.BackColor = System.Drawing.Color.Transparent
        Me._OptLK_0.Checked = True
        Me._OptLK_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptLK_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptLK_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptLK_0.Location = New System.Drawing.Point(7, 7)
        Me._OptLK_0.Name = "_OptLK_0"
        Me._OptLK_0.Size = New System.Drawing.Size(69, 17)
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
        '_MedNgay_1
        '
        Me._MedNgay_1.AllowPromptAsInput = False
        Me._MedNgay_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_1.Location = New System.Drawing.Point(216, 40)
        Me._MedNgay_1.Mask = "00/00/0000"
        Me._MedNgay_1.Name = "_MedNgay_1"
        Me._MedNgay_1.Size = New System.Drawing.Size(73, 20)
        Me._MedNgay_1.TabIndex = 5
        '
        '_Frame2_0
        '
        Me._Frame2_0.BackColor = System.Drawing.Color.Transparent
        Me._Frame2_0.Controls.Add(Me._txtShTk_5)
        Me._Frame2_0.Controls.Add(Me._txtShTk_0)
        Me._Frame2_0.Controls.Add(Me._txtShTk_2)
        Me._Frame2_0.Controls.Add(Me._CboN_2)
        Me._Frame2_0.Controls.Add(Me._txtShTk_4)
        Me._Frame2_0.Controls.Add(Me._txtShTk_6)
        Me._Frame2_0.Controls.Add(Me._txtShTk_1)
        Me._Frame2_0.Controls.Add(Me._txtShTk_3)
        Me._Frame2_0.Controls.Add(Me._ChkTaikhoan_0)
        Me._Frame2_0.Controls.Add(Me._ChkTaikhoan_1)
        Me._Frame2_0.Controls.Add(Me._ChkTaikhoan_2)
        Me._Frame2_0.Controls.Add(Me.Frame)
        Me._Frame2_0.Controls.Add(Me._ChkTaikhoan_3)
        Me._Frame2_0.Controls.Add(Me._ChkTaikhoan_4)
        Me._Frame2_0.Controls.Add(Me._ChkTaikhoan_5)
        Me._Frame2_0.Controls.Add(Me._CboN_1)
        Me._Frame2_0.Controls.Add(Me._CboN_0)
        Me._Frame2_0.Controls.Add(Me._ChkTaikhoan_6)
        Me._Frame2_0.Controls.Add(Me._CboN_3)
        Me._Frame2_0.Controls.Add(Me._ChkTaikhoan_7)
        Me._Frame2_0.Controls.Add(Me._ChkTaikhoan_8)
        Me._Frame2_0.Controls.Add(Me._CmdTK_2)
        Me._Frame2_0.Controls.Add(Me._CmdTK_3)
        Me._Frame2_0.Controls.Add(Me._CmdTK_1)
        Me._Frame2_0.Controls.Add(Me._CmdTK_0)
        Me._Frame2_0.Controls.Add(Me._CmdTK_6)
        Me._Frame2_0.Controls.Add(Me._LbTenTk_0)
        Me._Frame2_0.Controls.Add(Me._LbTenTk_1)
        Me._Frame2_0.Controls.Add(Me._Label_5)
        Me._Frame2_0.Controls.Add(Me._LbTenTk_2)
        Me._Frame2_0.Controls.Add(Me._LbTenTk_3)
        Me._Frame2_0.Controls.Add(Me._Label_9)
        Me._Frame2_0.Controls.Add(Me._Label_8)
        Me._Frame2_0.Controls.Add(Me._Label_10)
        Me._Frame2_0.Controls.Add(Me._LbTenTk_6)
        Me._Frame2_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame2_0.ForeColor = System.Drawing.Color.Blue
        Me._Frame2_0.Location = New System.Drawing.Point(8, 72)
        Me._Frame2_0.Name = "_Frame2_0"
        Me._Frame2_0.Size = New System.Drawing.Size(641, 189)
        Me._Frame2_0.TabIndex = 44
        Me._Frame2_0.TabStop = False
        Me._Frame2_0.Tag = "Conditions listed"
        Me._Frame2_0.Text = "Điều kiện liệt kê"
        '
        '_txtShTk_5
        '
        Me._txtShTk_5.AcceptsReturn = True
        Me._txtShTk_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_5.Location = New System.Drawing.Point(416, 12)
        Me._txtShTk_5.MaxLength = 20
        Me._txtShTk_5.Name = "_txtShTk_5"
        Me._txtShTk_5.Size = New System.Drawing.Size(55, 20)
        Me._txtShTk_5.TabIndex = 58
        Me._txtShTk_5.Tag = "0"
        Me._txtShTk_5.Text = "0"
        Me._txtShTk_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtShTk_0
        '
        Me._txtShTk_0.AcceptsReturn = True
        Me._txtShTk_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_0.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_0.Location = New System.Drawing.Point(135, 12)
        Me._txtShTk_0.MaxLength = 20
        Me._txtShTk_0.Name = "_txtShTk_0"
        Me._txtShTk_0.Size = New System.Drawing.Size(89, 21)
        Me._txtShTk_0.TabIndex = 76
        Me._txtShTk_0.Tag = "0"
        '
        '_txtShTk_2
        '
        Me._txtShTk_2.AcceptsReturn = True
        Me._txtShTk_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_2.Location = New System.Drawing.Point(135, 60)
        Me._txtShTk_2.MaxLength = 20
        Me._txtShTk_2.Name = "_txtShTk_2"
        Me._txtShTk_2.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_2.TabIndex = 72
        Me._txtShTk_2.Tag = "0"
        '
        '_CboN_2
        '
        Me._CboN_2.BackColor = System.Drawing.SystemColors.Window
        Me._CboN_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboN_2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboN_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboN_2.DropDownWidth = 36
        Me._CboN_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboN_2.Location = New System.Drawing.Point(135, 156)
        Me._CboN_2.Name = "_CboN_2"
        Me._CboN_2.Size = New System.Drawing.Size(193, 21)
        Me._CboN_2.TabIndex = 63
        '
        '_txtShTk_4
        '
        Me._txtShTk_4.AcceptsReturn = True
        Me._txtShTk_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_4.Location = New System.Drawing.Point(135, 132)
        Me._txtShTk_4.MaxLength = 20
        Me._txtShTk_4.Name = "_txtShTk_4"
        Me._txtShTk_4.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_4.TabIndex = 61
        Me._txtShTk_4.Tag = "0"
        '
        '_txtShTk_6
        '
        Me._txtShTk_6.AcceptsReturn = True
        Me._txtShTk_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_6.Location = New System.Drawing.Point(135, 108)
        Me._txtShTk_6.MaxLength = 20
        Me._txtShTk_6.Name = "_txtShTk_6"
        Me._txtShTk_6.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_6.TabIndex = 53
        Me._txtShTk_6.Tag = "0"
        '
        '_txtShTk_1
        '
        Me._txtShTk_1.AcceptsReturn = True
        Me._txtShTk_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_1.Location = New System.Drawing.Point(135, 36)
        Me._txtShTk_1.MaxLength = 20
        Me._txtShTk_1.Name = "_txtShTk_1"
        Me._txtShTk_1.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_1.TabIndex = 46
        Me._txtShTk_1.Tag = "0"
        '
        '_txtShTk_3
        '
        Me._txtShTk_3.AcceptsReturn = True
        Me._txtShTk_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_3.Location = New System.Drawing.Point(135, 84)
        Me._txtShTk_3.MaxLength = 20
        Me._txtShTk_3.Name = "_txtShTk_3"
        Me._txtShTk_3.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_3.TabIndex = 45
        Me._txtShTk_3.Tag = "0"
        '
        '_ChkTaikhoan_0
        '
        Me._ChkTaikhoan_0.BackColor = System.Drawing.Color.Transparent
        Me._ChkTaikhoan_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkTaikhoan_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkTaikhoan_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkTaikhoan_0.Location = New System.Drawing.Point(8, 12)
        Me._ChkTaikhoan_0.Name = "_ChkTaikhoan_0"
        Me._ChkTaikhoan_0.Size = New System.Drawing.Size(121, 17)
        Me._ChkTaikhoan_0.TabIndex = 78
        Me._ChkTaikhoan_0.Tag = "Account"
        Me._ChkTaikhoan_0.Text = "Tài khoản phát sinh"
        Me._ChkTaikhoan_0.UseVisualStyleBackColor = False
        '
        '_ChkTaikhoan_1
        '
        Me._ChkTaikhoan_1.BackColor = System.Drawing.Color.Transparent
        Me._ChkTaikhoan_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkTaikhoan_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkTaikhoan_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkTaikhoan_1.Location = New System.Drawing.Point(8, 36)
        Me._ChkTaikhoan_1.Name = "_ChkTaikhoan_1"
        Me._ChkTaikhoan_1.Size = New System.Drawing.Size(121, 17)
        Me._ChkTaikhoan_1.TabIndex = 77
        Me._ChkTaikhoan_1.Tag = "Inventory Code"
        Me._ChkTaikhoan_1.Text = "Vật tư phát sinh"
        Me._ChkTaikhoan_1.UseVisualStyleBackColor = False
        '
        '_ChkTaikhoan_2
        '
        Me._ChkTaikhoan_2.BackColor = System.Drawing.Color.Transparent
        Me._ChkTaikhoan_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkTaikhoan_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkTaikhoan_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkTaikhoan_2.Location = New System.Drawing.Point(8, 60)
        Me._ChkTaikhoan_2.Name = "_ChkTaikhoan_2"
        Me._ChkTaikhoan_2.Size = New System.Drawing.Size(121, 17)
        Me._ChkTaikhoan_2.TabIndex = 73
        Me._ChkTaikhoan_2.Tag = "Assets Code"
        Me._ChkTaikhoan_2.Text = "Tài sản phát sinh"
        Me._ChkTaikhoan_2.UseVisualStyleBackColor = False
        '
        'Frame
        '
        Me.Frame.BackColor = System.Drawing.Color.Transparent
        Me.Frame.Controls.Add(Me._SSOpt_2)
        Me.Frame.Controls.Add(Me._SSOpt_1)
        Me.Frame.Controls.Add(Me._SSOpt_0)
        Me.Frame.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame.Location = New System.Drawing.Point(511, 36)
        Me.Frame.Name = "Frame"
        Me.Frame.Size = New System.Drawing.Size(122, 65)
        Me.Frame.TabIndex = 67
        Me.Frame.Text = "Frame1"
        '
        '_SSOpt_2
        '
        Me._SSOpt_2.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_2.Location = New System.Drawing.Point(0, 48)
        Me._SSOpt_2.Name = "_SSOpt_2"
        Me._SSOpt_2.Size = New System.Drawing.Size(119, 17)
        Me._SSOpt_2.TabIndex = 70
        Me._SSOpt_2.TabStop = True
        Me._SSOpt_2.Tag = "V. Code"
        Me._SSOpt_2.Text = "Số hiệu CT"
        Me._SSOpt_2.UseVisualStyleBackColor = False
        '
        '_SSOpt_1
        '
        Me._SSOpt_1.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_1.Location = New System.Drawing.Point(0, 24)
        Me._SSOpt_1.Name = "_SSOpt_1"
        Me._SSOpt_1.Size = New System.Drawing.Size(119, 17)
        Me._SSOpt_1.TabIndex = 69
        Me._SSOpt_1.TabStop = True
        Me._SSOpt_1.Tag = "V. Date, V. Code"
        Me._SSOpt_1.Text = "Ngày CT, Sốhiệu"
        Me._SSOpt_1.UseVisualStyleBackColor = False
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
        Me._SSOpt_0.Size = New System.Drawing.Size(119, 17)
        Me._SSOpt_0.TabIndex = 68
        Me._SSOpt_0.TabStop = True
        Me._SSOpt_0.Tag = "B. Date, V. Code"
        Me._SSOpt_0.Text = "Ngày GS, Sốhiệu"
        Me._SSOpt_0.UseVisualStyleBackColor = False
        '
        '_ChkTaikhoan_3
        '
        Me._ChkTaikhoan_3.BackColor = System.Drawing.Color.Transparent
        Me._ChkTaikhoan_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkTaikhoan_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkTaikhoan_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkTaikhoan_3.Location = New System.Drawing.Point(8, 84)
        Me._ChkTaikhoan_3.Name = "_ChkTaikhoan_3"
        Me._ChkTaikhoan_3.Size = New System.Drawing.Size(121, 17)
        Me._ChkTaikhoan_3.TabIndex = 65
        Me._ChkTaikhoan_3.Tag = "Liability Code"
        Me._ChkTaikhoan_3.Text = "Công nợ liên quan"
        Me._ChkTaikhoan_3.UseVisualStyleBackColor = False
        '
        '_ChkTaikhoan_4
        '
        Me._ChkTaikhoan_4.BackColor = System.Drawing.Color.Transparent
        Me._ChkTaikhoan_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkTaikhoan_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkTaikhoan_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkTaikhoan_4.Location = New System.Drawing.Point(8, 156)
        Me._ChkTaikhoan_4.Name = "_ChkTaikhoan_4"
        Me._ChkTaikhoan_4.Size = New System.Drawing.Size(121, 17)
        Me._ChkTaikhoan_4.TabIndex = 64
        Me._ChkTaikhoan_4.Tag = "V. Book"
        Me._ChkTaikhoan_4.Text = "Chứng từ ghi sổ"
        Me._ChkTaikhoan_4.UseVisualStyleBackColor = False
        '
        '_ChkTaikhoan_5
        '
        Me._ChkTaikhoan_5.BackColor = System.Drawing.Color.Transparent
        Me._ChkTaikhoan_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkTaikhoan_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkTaikhoan_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkTaikhoan_5.Location = New System.Drawing.Point(8, 132)
        Me._ChkTaikhoan_5.Name = "_ChkTaikhoan_5"
        Me._ChkTaikhoan_5.Size = New System.Drawing.Size(121, 17)
        Me._ChkTaikhoan_5.TabIndex = 62
        Me._ChkTaikhoan_5.Tag = "V. Code"
        Me._ChkTaikhoan_5.Text = "CT, Hoá đơn số"
        Me._ChkTaikhoan_5.UseVisualStyleBackColor = False
        '
        '_CboN_1
        '
        Me._CboN_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboN_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboN_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboN_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboN_1.DropDownWidth = 36
        Me._CboN_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboN_1.Location = New System.Drawing.Point(440, 132)
        Me._CboN_1.Name = "_CboN_1"
        Me._CboN_1.Size = New System.Drawing.Size(193, 21)
        Me._CboN_1.TabIndex = 60
        Me._CboN_1.Visible = False
        '
        '_CboN_0
        '
        Me._CboN_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboN_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboN_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboN_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboN_0.DropDownWidth = 36
        Me._CboN_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboN_0.Location = New System.Drawing.Point(440, 108)
        Me._CboN_0.Name = "_CboN_0"
        Me._CboN_0.Size = New System.Drawing.Size(193, 21)
        Me._CboN_0.TabIndex = 59
        Me._CboN_0.Visible = False
        '
        '_ChkTaikhoan_6
        '
        Me._ChkTaikhoan_6.BackColor = System.Drawing.Color.Transparent
        Me._ChkTaikhoan_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkTaikhoan_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkTaikhoan_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkTaikhoan_6.Location = New System.Drawing.Point(356, 156)
        Me._ChkTaikhoan_6.Name = "_ChkTaikhoan_6"
        Me._ChkTaikhoan_6.Size = New System.Drawing.Size(83, 17)
        Me._ChkTaikhoan_6.TabIndex = 57
        Me._ChkTaikhoan_6.Tag = "User Name"
        Me._ChkTaikhoan_6.Text = "Người nhập"
        Me._ChkTaikhoan_6.UseVisualStyleBackColor = False
        '
        '_CboN_3
        '
        Me._CboN_3.BackColor = System.Drawing.SystemColors.Window
        Me._CboN_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboN_3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboN_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboN_3.DropDownWidth = 36
        Me._CboN_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboN_3.Location = New System.Drawing.Point(440, 156)
        Me._CboN_3.Name = "_CboN_3"
        Me._CboN_3.Size = New System.Drawing.Size(193, 21)
        Me._CboN_3.TabIndex = 56
        '
        '_ChkTaikhoan_7
        '
        Me._ChkTaikhoan_7.BackColor = System.Drawing.Color.Transparent
        Me._ChkTaikhoan_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkTaikhoan_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkTaikhoan_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkTaikhoan_7.Location = New System.Drawing.Point(480, 12)
        Me._ChkTaikhoan_7.Name = "_ChkTaikhoan_7"
        Me._ChkTaikhoan_7.Size = New System.Drawing.Size(159, 17)
        Me._ChkTaikhoan_7.TabIndex = 55
        Me._ChkTaikhoan_7.Tag = "Unpaid"
        Me._ChkTaikhoan_7.Text = "Chưa thanh toán đích danh"
        Me._ChkTaikhoan_7.UseVisualStyleBackColor = False
        Me._ChkTaikhoan_7.Visible = False
        '
        '_ChkTaikhoan_8
        '
        Me._ChkTaikhoan_8.BackColor = System.Drawing.Color.Transparent
        Me._ChkTaikhoan_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkTaikhoan_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkTaikhoan_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkTaikhoan_8.Location = New System.Drawing.Point(8, 108)
        Me._ChkTaikhoan_8.Name = "_ChkTaikhoan_8"
        Me._ChkTaikhoan_8.Size = New System.Drawing.Size(137, 17)
        Me._ChkTaikhoan_8.TabIndex = 54
        Me._ChkTaikhoan_8.Tag = "Liability Code"
        Me._ChkTaikhoan_8.Text = "Công trình, sản phẩm"
        Me._ChkTaikhoan_8.UseVisualStyleBackColor = False
        '
        '_CmdTK_2
        '
        Me._CmdTK_2.Image = Global.UNET.My.Resources.Resources.search3_16
        Me._CmdTK_2.Location = New System.Drawing.Point(228, 60)
        Me._CmdTK_2.Name = "_CmdTK_2"
        Me._CmdTK_2.Size = New System.Drawing.Size(24, 23)
        Me._CmdTK_2.TabIndex = 47
        '
        '_CmdTK_3
        '
        Me._CmdTK_3.Image = Global.UNET.My.Resources.Resources.search3_16
        Me._CmdTK_3.Location = New System.Drawing.Point(228, 84)
        Me._CmdTK_3.Name = "_CmdTK_3"
        Me._CmdTK_3.Size = New System.Drawing.Size(24, 23)
        Me._CmdTK_3.TabIndex = 48
        '
        '_CmdTK_1
        '
        Me._CmdTK_1.Image = Global.UNET.My.Resources.Resources.search3_16
        Me._CmdTK_1.Location = New System.Drawing.Point(228, 36)
        Me._CmdTK_1.Name = "_CmdTK_1"
        Me._CmdTK_1.Size = New System.Drawing.Size(24, 23)
        Me._CmdTK_1.TabIndex = 49
        '
        '_CmdTK_0
        '
        Me._CmdTK_0.Image = Global.UNET.My.Resources.Resources.search3_16
        Me._CmdTK_0.Location = New System.Drawing.Point(228, 12)
        Me._CmdTK_0.Name = "_CmdTK_0"
        Me._CmdTK_0.Size = New System.Drawing.Size(24, 23)
        Me._CmdTK_0.TabIndex = 50
        '
        '_CmdTK_6
        '
        Me._CmdTK_6.Image = Global.UNET.My.Resources.Resources.search3_16
        Me._CmdTK_6.Location = New System.Drawing.Point(228, 108)
        Me._CmdTK_6.Name = "_CmdTK_6"
        Me._CmdTK_6.Size = New System.Drawing.Size(24, 23)
        Me._CmdTK_6.TabIndex = 51
        '
        '_LbTenTk_0
        '
        Me._LbTenTk_0.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_0.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_0.Location = New System.Drawing.Point(256, 12)
        Me._LbTenTk_0.Name = "_LbTenTk_0"
        Me._LbTenTk_0.Size = New System.Drawing.Size(89, 17)
        Me._LbTenTk_0.TabIndex = 87
        Me._LbTenTk_0.Tag = "1"
        '
        '_LbTenTk_1
        '
        Me._LbTenTk_1.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_1.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_1.Location = New System.Drawing.Point(256, 36)
        Me._LbTenTk_1.Name = "_LbTenTk_1"
        Me._LbTenTk_1.Size = New System.Drawing.Size(207, 17)
        Me._LbTenTk_1.TabIndex = 86
        Me._LbTenTk_1.Tag = "1"
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.Transparent
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_5.Location = New System.Drawing.Point(465, 36)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(40, 17)
        Me._Label_5.TabIndex = 85
        Me._Label_5.Tag = "Sort by"
        Me._Label_5.Text = "Thứ tự"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbTenTk_2
        '
        Me._LbTenTk_2.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_2.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_2.Location = New System.Drawing.Point(256, 60)
        Me._LbTenTk_2.Name = "_LbTenTk_2"
        Me._LbTenTk_2.Size = New System.Drawing.Size(247, 17)
        Me._LbTenTk_2.TabIndex = 84
        Me._LbTenTk_2.Tag = "1"
        '
        '_LbTenTk_3
        '
        Me._LbTenTk_3.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_3.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_3.Location = New System.Drawing.Point(256, 84)
        Me._LbTenTk_3.Name = "_LbTenTk_3"
        Me._LbTenTk_3.Size = New System.Drawing.Size(247, 17)
        Me._LbTenTk_3.TabIndex = 83
        Me._LbTenTk_3.Tag = "1"
        '
        '_Label_9
        '
        Me._Label_9.BackColor = System.Drawing.Color.Transparent
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_9.Location = New System.Drawing.Point(384, 108)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.Size = New System.Drawing.Size(54, 17)
        Me._Label_9.TabIndex = 82
        Me._Label_9.Tag = "Store"
        Me._Label_9.Text = "Kho hàng"
        Me._Label_9.Visible = False
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.Transparent
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_8.Location = New System.Drawing.Point(384, 132)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(54, 17)
        Me._Label_8.TabIndex = 81
        Me._Label_8.Tag = "Class"
        Me._Label_8.Text = "Phân loại"
        Me._Label_8.Visible = False
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.Transparent
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_10.Location = New System.Drawing.Point(344, 16)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(67, 17)
        Me._Label_10.TabIndex = 80
        Me._Label_10.Tag = "Amount"
        Me._Label_10.Text = "Số phát sinh"
        '
        '_LbTenTk_6
        '
        Me._LbTenTk_6.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_6.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_6.Location = New System.Drawing.Point(256, 108)
        Me._LbTenTk_6.Name = "_LbTenTk_6"
        Me._LbTenTk_6.Size = New System.Drawing.Size(121, 17)
        Me._LbTenTk_6.TabIndex = 79
        Me._LbTenTk_6.Tag = "1"
        '
        '_Label_13
        '
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_13.Location = New System.Drawing.Point(8, 538)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(41, 17)
        Me._Label_13.TabIndex = 18
        Me._Label_13.Tag = "Total"
        Me._Label_13.Text = "Số CT"
        '
        'LbSoCT
        '
        Me.LbSoCT.Cursor = System.Windows.Forms.Cursors.Default
        Me.LbSoCT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSoCT.ForeColor = System.Drawing.Color.Blue
        Me.LbSoCT.Location = New System.Drawing.Point(48, 538)
        Me.LbSoCT.Name = "LbSoCT"
        Me.LbSoCT.Size = New System.Drawing.Size(41, 17)
        Me.LbSoCT.TabIndex = 17
        Me.LbSoCT.Text = "0"
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(544, 264)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(87, 17)
        Me._Label_7.TabIndex = 16
        Me._Label_7.Tag = "Amount"
        Me._Label_7.Text = "Tổng Phát sinh"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(154, 43)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(59, 17)
        Me._Label_0.TabIndex = 15
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
        Me._Label_6.Location = New System.Drawing.Point(159, 11)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(58, 17)
        Me._Label_6.TabIndex = 11
        Me._Label_6.Tag = "to"
        Me._Label_6.Text = "Đến tháng"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(224, 264)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(321, 17)
        Me._Label_4.TabIndex = 10
        Me._Label_4.Tag = "Description"
        Me._Label_4.Text = "Diễn giải"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.Black
        Me._Label_3.Location = New System.Drawing.Point(160, 264)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(65, 17)
        Me._Label_3.TabIndex = 9
        Me._Label_3.Tag = "B. Date"
        Me._Label_3.Text = "Ngày GS"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.Black
        Me._Label_2.Location = New System.Drawing.Point(96, 264)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(65, 17)
        Me._Label_2.TabIndex = 8
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
        Me._Label_1.Location = New System.Drawing.Point(8, 264)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(89, 17)
        Me._Label_1.TabIndex = 7
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
        Me.GrdChungtu.Location = New System.Drawing.Point(8, 280)
        Me.GrdChungtu.Name = "GrdChungtu"
        Me.GrdChungtu.Row = 0
        Me.GrdChungtu.Rows = 0
        Me.GrdChungtu.Selectable = True
        Me.GrdChungtu.SelectedTextColor = System.Drawing.Color.White
        Me.GrdChungtu.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.GrdChungtu.ShowBorder = True
        Me.GrdChungtu.ShowFocusRect = False
        Me.GrdChungtu.Size = New System.Drawing.Size(640, 242)
        Me.GrdChungtu.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdChungtu.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdChungtu.TabIndex = 10
        '
        'FrmDsCTTonghop
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(657, 561)
        Me.Controls.Add(Me.GrdChungtu)
        Me.Controls.Add(Me._Command_7)
        Me.Controls.Add(Me._MedNgay_0)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me._OptLK_1)
        Me.Controls.Add(Me._Command_4)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command_6)
        Me.Controls.Add(Me._Command_5)
        Me.Controls.Add(Me._OptLK_0)
        Me.Controls.Add(Me._CboThang_1)
        Me.Controls.Add(Me._CboThang_0)
        Me.Controls.Add(Me._MedNgay_1)
        Me.Controls.Add(Me._Frame2_0)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me.LbSoCT)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(79, 36)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDsCTTonghop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Voucher List"
        Me.Text = "Danh sách chứng từ"
        Me.Frame1.ResumeLayout(False)
        Me._Frame2_0.ResumeLayout(False)
        Me._Frame2_0.PerformLayout()
        Me.Frame.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializetxtShTk()
		Me.txtShTk(5) = _txtShTk_5
		Me.txtShTk(0) = _txtShTk_0
		Me.txtShTk(2) = _txtShTk_2
		Me.txtShTk(4) = _txtShTk_4
		Me.txtShTk(6) = _txtShTk_6
		Me.txtShTk(1) = _txtShTk_1
		Me.txtShTk(3) = _txtShTk_3
	End Sub
	Sub InitializeSSOpt()
		Me.SSOpt(2) = _SSOpt_2
		Me.SSOpt(1) = _SSOpt_1
		Me.SSOpt(0) = _SSOpt_0
	End Sub
	Sub InitializeOptLK()
		Me.OptLK(1) = _OptLK_1
		Me.OptLK(0) = _OptLK_0
	End Sub
	Sub InitializeMedNgay()
		Me.MedNgay(0) = _MedNgay_0
		Me.MedNgay(1) = _MedNgay_1
	End Sub
	Sub InitializeLbTenTk()
		Me.LbTenTk(0) = _LbTenTk_0
		Me.LbTenTk(1) = _LbTenTk_1
		Me.LbTenTk(2) = _LbTenTk_2
		Me.LbTenTk(3) = _LbTenTk_3
		Me.LbTenTk(6) = _LbTenTk_6
	End Sub
	Sub InitializeLabel()
		Me.Label(5) = _Label_5
		Me.Label(9) = _Label_9
		Me.Label(8) = _Label_8
		Me.Label(10) = _Label_10
		Me.Label(13) = _Label_13
		Me.Label(7) = _Label_7
		Me.Label(0) = _Label_0
		Me.Label(6) = _Label_6
		Me.Label(4) = _Label_4
		Me.Label(3) = _Label_3
		Me.Label(2) = _Label_2
		Me.Label(1) = _Label_1
	End Sub
	Sub InitializeFrame2()
		Me.Frame2(0) = _Frame2_0
	End Sub
	Sub InitializeCommand()
		Me.Command(7) = _Command_7
		Me.Command(4) = _Command_4
		Me.Command(3) = _Command_3
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
		Me.Command(6) = _Command_6
		Me.Command(5) = _Command_5
	End Sub
	Sub InitializeCmdTK()
		Me.CmdTK(2) = _CmdTK_2
		Me.CmdTK(3) = _CmdTK_3
		Me.CmdTK(1) = _CmdTK_1
		Me.CmdTK(0) = _CmdTK_0
		Me.CmdTK(6) = _CmdTK_6
	End Sub
	Sub InitializeChkTaikhoan()
		Me.ChkTaikhoan(0) = _ChkTaikhoan_0
		Me.ChkTaikhoan(1) = _ChkTaikhoan_1
		Me.ChkTaikhoan(2) = _ChkTaikhoan_2
		Me.ChkTaikhoan(3) = _ChkTaikhoan_3
		Me.ChkTaikhoan(4) = _ChkTaikhoan_4
		Me.ChkTaikhoan(5) = _ChkTaikhoan_5
		Me.ChkTaikhoan(6) = _ChkTaikhoan_6
		Me.ChkTaikhoan(7) = _ChkTaikhoan_7
		Me.ChkTaikhoan(8) = _ChkTaikhoan_8
	End Sub
	Sub InitializeChkLoai()
		Me.ChkLoai(12) = _ChkLoai_12
		Me.ChkLoai(11) = _ChkLoai_11
		Me.ChkLoai(0) = _ChkLoai_0
		Me.ChkLoai(1) = _ChkLoai_1
		Me.ChkLoai(2) = _ChkLoai_2
		Me.ChkLoai(3) = _ChkLoai_3
		Me.ChkLoai(9) = _ChkLoai_9
		Me.ChkLoai(10) = _ChkLoai_10
		Me.ChkLoai(8) = _ChkLoai_8
		Me.ChkLoai(7) = _ChkLoai_7
		Me.ChkLoai(13) = _ChkLoai_13
		Me.ChkLoai(14) = _ChkLoai_14
	End Sub
	Sub InitializeCboThang()
		Me.CboThang(1) = _CboThang_1
		Me.CboThang(0) = _CboThang_0
	End Sub
	Sub InitializeCboN()
		Me.CboN(2) = _CboN_2
		Me.CboN(1) = _CboN_1
		Me.CboN(0) = _CboN_0
		Me.CboN(3) = _CboN_3
    End Sub
#End Region
End Class
