<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FThuChi
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
        isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		InitializeT()
		InitializeOptHD()
		InitializeLabel1()
		InitializeChkNT()
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
	Private WithEvents _OptHD_0 As System.Windows.Forms.RadioButton
	Private WithEvents _OptHD_1 As System.Windows.Forms.RadioButton
	Private WithEvents _T_4 As System.Windows.Forms.TextBox
    Public WithEvents cmdkh As System.Windows.Forms.Button
    Private WithEvents _T_3 As System.Windows.Forms.TextBox
    Public WithEvents cmdkh1 As System.Windows.Forms.Button
    Public WithEvents txtshkh As System.Windows.Forms.TextBox
    Private WithEvents _T_2 As System.Windows.Forms.TextBox
    Private WithEvents _T_1 As System.Windows.Forms.TextBox
    Private WithEvents _T_0 As System.Windows.Forms.TextBox
    Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents MedNgay As System.Windows.Forms.MaskedTextBox
    Private WithEvents _T_5 As System.Windows.Forms.TextBox
    Private WithEvents _ChkNT_4 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkNT_3 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkNT_2 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkNT_1 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkNT_0 As System.Windows.Forms.CheckBox
    Private WithEvents _Label1_7 As System.Windows.Forms.Label
    Private WithEvents _Label1_4 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Private WithEvents _Label1_5 As System.Windows.Forms.Label
    Public WithEvents lbkh As System.Windows.Forms.Label
    Private WithEvents _Label1_3 As System.Windows.Forms.Label
    Private WithEvents _Label1_2 As System.Windows.Forms.Label
    Private WithEvents _Label1_1 As System.Windows.Forms.Label
    Private WithEvents _Label1_0 As System.Windows.Forms.Label
    Public ChkNT(4) As System.Windows.Forms.CheckBox
    Public Label1(7) As System.Windows.Forms.Label
    Public OptHD(2) As System.Windows.Forms.RadioButton
    Public T(5) As System.Windows.Forms.TextBox
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FThuChi))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._OptHD_0 = New System.Windows.Forms.RadioButton
        Me._OptHD_1 = New System.Windows.Forms.RadioButton
        Me._T_4 = New System.Windows.Forms.TextBox
        Me.cmdkh = New System.Windows.Forms.Button
        Me._T_3 = New System.Windows.Forms.TextBox
        Me.cmdkh1 = New System.Windows.Forms.Button
        Me.txtshkh = New System.Windows.Forms.TextBox
        Me._T_2 = New System.Windows.Forms.TextBox
        Me._T_1 = New System.Windows.Forms.TextBox
        Me._T_0 = New System.Windows.Forms.TextBox
        Me.Command1 = New System.Windows.Forms.Button
        Me.MedNgay = New System.Windows.Forms.MaskedTextBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me._T_5 = New System.Windows.Forms.TextBox
        Me._ChkNT_4 = New System.Windows.Forms.CheckBox
        Me._ChkNT_3 = New System.Windows.Forms.CheckBox
        Me._ChkNT_2 = New System.Windows.Forms.CheckBox
        Me._ChkNT_1 = New System.Windows.Forms.CheckBox
        Me._ChkNT_0 = New System.Windows.Forms.CheckBox
        Me._Label1_7 = New System.Windows.Forms.Label
        Me._Label1_4 = New System.Windows.Forms.Label
        Me._Label1_5 = New System.Windows.Forms.Label
        Me.lbkh = New System.Windows.Forms.Label
        Me._Label1_3 = New System.Windows.Forms.Label
        Me._Label1_2 = New System.Windows.Forms.Label
        Me._Label1_1 = New System.Windows.Forms.Label
        Me._Label1_0 = New System.Windows.Forms.Label
        Me.Command = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_hinhthucthanhtoan = New System.Windows.Forms.TextBox
        Me._OptHD_2 = New System.Windows.Forms.RadioButton
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_OptHD_0
        '
        Me._OptHD_0.BackColor = System.Drawing.Color.Transparent
        Me._OptHD_0.Checked = True
        Me._OptHD_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptHD_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptHD_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptHD_0.Location = New System.Drawing.Point(13, 131)
        Me._OptHD_0.Name = "_OptHD_0"
        Me._OptHD_0.Size = New System.Drawing.Size(105, 17)
        Me._OptHD_0.TabIndex = 27
        Me._OptHD_0.TabStop = True
        Me._OptHD_0.Tag = "Invoice"
        Me._OptHD_0.Text = "Hoá đơn đặt in"
        Me._OptHD_0.UseVisualStyleBackColor = False
        '
        '_OptHD_1
        '
        Me._OptHD_1.BackColor = System.Drawing.Color.Transparent
        Me._OptHD_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptHD_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptHD_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptHD_1.Location = New System.Drawing.Point(13, 154)
        Me._OptHD_1.Name = "_OptHD_1"
        Me._OptHD_1.Size = New System.Drawing.Size(105, 17)
        Me._OptHD_1.TabIndex = 26
        Me._OptHD_1.TabStop = True
        Me._OptHD_1.Tag = "Delivery Notes"
        Me._OptHD_1.Text = "Hóa đơn tự in"
        Me._OptHD_1.UseVisualStyleBackColor = False
        '
        '_T_4
        '
        Me._T_4.AcceptsReturn = True
        Me._T_4.BackColor = System.Drawing.SystemColors.Window
        Me._T_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_4.Location = New System.Drawing.Point(458, 56)
        Me._T_4.MaxLength = 20
        Me._T_4.Name = "_T_4"
        Me._T_4.Size = New System.Drawing.Size(153, 20)
        Me._T_4.TabIndex = 22
        Me._T_4.Text = "..."
        '
        'cmdkh
        '
        Me.cmdkh.Image = Global.UNET.My.Resources.Resources.search3_16
        Me.cmdkh.Location = New System.Drawing.Point(298, 76)
        Me.cmdkh.Name = "cmdkh"
        Me.cmdkh.Size = New System.Drawing.Size(25, 25)
        Me.cmdkh.TabIndex = 14
        '
        '_T_3
        '
        Me._T_3.AcceptsReturn = True
        Me._T_3.BackColor = System.Drawing.SystemColors.Window
        Me._T_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_3.Location = New System.Drawing.Point(130, 80)
        Me._T_3.MaxLength = 20
        Me._T_3.Name = "_T_3"
        Me._T_3.Size = New System.Drawing.Size(161, 20)
        Me._T_3.TabIndex = 4
        Me._T_3.Text = "..."
        Me._T_3.Visible = False
        '
        'cmdkh1
        '
        Me.cmdkh1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdkh1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdkh1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdkh1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdkh1.Image = CType(resources.GetObject("cmdkh1.Image"), System.Drawing.Image)
        Me.cmdkh1.Location = New System.Drawing.Point(298, 76)
        Me.cmdkh1.Name = "cmdkh1"
        Me.cmdkh1.Size = New System.Drawing.Size(25, 25)
        Me.cmdkh1.TabIndex = 6
        Me.cmdkh1.TabStop = False
        Me.cmdkh1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdkh1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdkh1.UseVisualStyleBackColor = False
        Me.cmdkh1.Visible = False
        '
        'txtshkh
        '
        Me.txtshkh.AcceptsReturn = True
        Me.txtshkh.BackColor = System.Drawing.SystemColors.Window
        Me.txtshkh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtshkh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtshkh.Location = New System.Drawing.Point(130, 80)
        Me.txtshkh.MaxLength = 20
        Me.txtshkh.Name = "txtshkh"
        Me.txtshkh.Size = New System.Drawing.Size(161, 20)
        Me.txtshkh.TabIndex = 5
        Me.txtshkh.Tag = "0"
        '
        '_T_2
        '
        Me._T_2.AcceptsReturn = True
        Me._T_2.BackColor = System.Drawing.SystemColors.Window
        Me._T_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_2.Location = New System.Drawing.Point(130, 56)
        Me._T_2.MaxLength = 20
        Me._T_2.Name = "_T_2"
        Me._T_2.Size = New System.Drawing.Size(161, 20)
        Me._T_2.TabIndex = 2
        Me._T_2.Text = "..."
        '
        '_T_1
        '
        Me._T_1.AcceptsReturn = True
        Me._T_1.BackColor = System.Drawing.SystemColors.Window
        Me._T_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_1.Location = New System.Drawing.Point(130, 32)
        Me._T_1.MaxLength = 100
        Me._T_1.Name = "_T_1"
        Me._T_1.Size = New System.Drawing.Size(481, 20)
        Me._T_1.TabIndex = 1
        Me._T_1.Text = "..."
        '
        '_T_0
        '
        Me._T_0.AcceptsReturn = True
        Me._T_0.BackColor = System.Drawing.SystemColors.Window
        Me._T_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_0.Location = New System.Drawing.Point(130, 8)
        Me._T_0.MaxLength = 50
        Me._T_0.Name = "_T_0"
        Me._T_0.Size = New System.Drawing.Size(481, 20)
        Me._T_0.TabIndex = 0
        Me._T_0.Text = "..."
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.Color.Silver
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Image = CType(resources.GetObject("Command1.Image"), System.Drawing.Image)
        Me.Command1.Location = New System.Drawing.Point(277, 249)
        Me.Command1.Name = "Command1"
        Me.Command1.Size = New System.Drawing.Size(73, 25)
        Me.Command1.TabIndex = 7
        Me.Command1.TabStop = False
        Me.Command1.Tag = "&Save"
        Me.Command1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Command1.UseVisualStyleBackColor = False
        Me.Command1.Visible = False
        '
        'MedNgay
        '
        Me.MedNgay.AllowPromptAsInput = False
        Me.MedNgay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedNgay.Location = New System.Drawing.Point(130, 56)
        Me.MedNgay.Name = "MedNgay"
        Me.MedNgay.Size = New System.Drawing.Size(57, 20)
        Me.MedNgay.TabIndex = 3
        Me.MedNgay.Visible = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.Transparent
        Me.Frame1.Controls.Add(Me._T_5)
        Me.Frame1.Controls.Add(Me._ChkNT_4)
        Me.Frame1.Controls.Add(Me._ChkNT_3)
        Me.Frame1.Controls.Add(Me._ChkNT_2)
        Me.Frame1.Controls.Add(Me._ChkNT_1)
        Me.Frame1.Controls.Add(Me._ChkNT_0)
        Me.Frame1.Controls.Add(Me._Label1_7)
        Me.Frame1.Controls.Add(Me._Label1_4)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(127, 131)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(481, 73)
        Me.Frame1.TabIndex = 15
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Hoá đơn nội địa"
        Me.Frame1.Visible = False
        '
        '_T_5
        '
        Me._T_5.AcceptsReturn = True
        Me._T_5.BackColor = System.Drawing.SystemColors.Window
        Me._T_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_5.Location = New System.Drawing.Point(298, 16)
        Me._T_5.MaxLength = 20
        Me._T_5.Name = "_T_5"
        Me._T_5.Size = New System.Drawing.Size(17, 20)
        Me._T_5.TabIndex = 24
        Me._T_5.Text = "1"
        Me._T_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_ChkNT_4
        '
        Me._ChkNT_4.BackColor = System.Drawing.Color.Transparent
        Me._ChkNT_4.Checked = True
        Me._ChkNT_4.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkNT_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkNT_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkNT_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkNT_4.Location = New System.Drawing.Point(2, 48)
        Me._ChkNT_4.Name = "_ChkNT_4"
        Me._ChkNT_4.Size = New System.Drawing.Size(161, 17)
        Me._ChkNT_4.TabIndex = 20
        Me._ChkNT_4.Text = "Liên 3: Nội bộ"
        Me._ChkNT_4.UseVisualStyleBackColor = False
        '
        '_ChkNT_3
        '
        Me._ChkNT_3.BackColor = System.Drawing.Color.Transparent
        Me._ChkNT_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkNT_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkNT_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkNT_3.Location = New System.Drawing.Point(354, 32)
        Me._ChkNT_3.Name = "_ChkNT_3"
        Me._ChkNT_3.Size = New System.Drawing.Size(97, 17)
        Me._ChkNT_3.TabIndex = 19
        Me._ChkNT_3.Text = "Liên 2: Nội bộ"
        Me._ChkNT_3.UseVisualStyleBackColor = False
        '
        '_ChkNT_2
        '
        Me._ChkNT_2.BackColor = System.Drawing.Color.Transparent
        Me._ChkNT_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkNT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkNT_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkNT_2.Location = New System.Drawing.Point(354, 16)
        Me._ChkNT_2.Name = "_ChkNT_2"
        Me._ChkNT_2.Size = New System.Drawing.Size(81, 17)
        Me._ChkNT_2.TabIndex = 18
        Me._ChkNT_2.Text = "Liên 1: Lưu"
        Me._ChkNT_2.UseVisualStyleBackColor = False
        '
        '_ChkNT_1
        '
        Me._ChkNT_1.BackColor = System.Drawing.Color.Transparent
        Me._ChkNT_1.Checked = True
        Me._ChkNT_1.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkNT_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkNT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkNT_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkNT_1.Location = New System.Drawing.Point(2, 32)
        Me._ChkNT_1.Name = "_ChkNT_1"
        Me._ChkNT_1.Size = New System.Drawing.Size(161, 17)
        Me._ChkNT_1.TabIndex = 17
        Me._ChkNT_1.Text = "Liên 2: Giao khách hàng"
        Me._ChkNT_1.UseVisualStyleBackColor = False
        '
        '_ChkNT_0
        '
        Me._ChkNT_0.BackColor = System.Drawing.Color.Transparent
        Me._ChkNT_0.Checked = True
        Me._ChkNT_0.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkNT_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkNT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkNT_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkNT_0.Location = New System.Drawing.Point(2, 16)
        Me._ChkNT_0.Name = "_ChkNT_0"
        Me._ChkNT_0.Size = New System.Drawing.Size(81, 17)
        Me._ChkNT_0.TabIndex = 16
        Me._ChkNT_0.Text = "Liên 1: Lưu"
        Me._ChkNT_0.UseVisualStyleBackColor = False
        '
        '_Label1_7
        '
        Me._Label1_7.BackColor = System.Drawing.Color.Transparent
        Me._Label1_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_7.Location = New System.Drawing.Point(138, 19)
        Me._Label1_7.Name = "_Label1_7"
        Me._Label1_7.Size = New System.Drawing.Size(161, 17)
        Me._Label1_7.TabIndex = 25
        Me._Label1_7.Tag = "Number of Voucher"
        Me._Label1_7.Text = "Số dòng của chi tiết HD (1, 2, 3)"
        '
        '_Label1_4
        '
        Me._Label1_4.AutoSize = True
        Me._Label1_4.BackColor = System.Drawing.Color.Transparent
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_4.Location = New System.Drawing.Point(354, 0)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.Size = New System.Drawing.Size(98, 14)
        Me._Label1_4.TabIndex = 21
        Me._Label1_4.Tag = "Object code"
        Me._Label1_4.Text = "Hoá đơn xuất khẩu"
        '
        '_Label1_5
        '
        Me._Label1_5.BackColor = System.Drawing.Color.Transparent
        Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_5.Location = New System.Drawing.Point(378, 56)
        Me._Label1_5.Name = "_Label1_5"
        Me._Label1_5.Size = New System.Drawing.Size(73, 25)
        Me._Label1_5.TabIndex = 23
        Me._Label1_5.Tag = "Receipts (Spending)"
        Me._Label1_5.Text = "Phiếu thu (chi)"
        '
        'lbkh
        '
        Me.lbkh.BackColor = System.Drawing.Color.Transparent
        Me.lbkh.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbkh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbkh.ForeColor = System.Drawing.Color.Blue
        Me.lbkh.Location = New System.Drawing.Point(330, 80)
        Me.lbkh.Name = "lbkh"
        Me.lbkh.Size = New System.Drawing.Size(281, 17)
        Me.lbkh.TabIndex = 12
        Me.lbkh.Tag = "1"
        '
        '_Label1_3
        '
        Me._Label1_3.BackColor = System.Drawing.Color.Transparent
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_3.Location = New System.Drawing.Point(10, 80)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.Size = New System.Drawing.Size(121, 17)
        Me._Label1_3.TabIndex = 11
        Me._Label1_3.Tag = "Object code"
        Me._Label1_3.Text = "Số hiệu đối tượng"
        '
        '_Label1_2
        '
        Me._Label1_2.BackColor = System.Drawing.Color.Transparent
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(10, 56)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.Size = New System.Drawing.Size(121, 17)
        Me._Label1_2.TabIndex = 10
        Me._Label1_2.Tag = "Number of Voucher"
        Me._Label1_2.Text = "Số chứng từ gốc:"
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.Color.Transparent
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(10, 32)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.Size = New System.Drawing.Size(121, 17)
        Me._Label1_1.TabIndex = 9
        Me._Label1_1.Tag = "Address:"
        Me._Label1_1.Text = "Địa chỉ người nộp tiền:"
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.Color.Transparent
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(10, 8)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.Size = New System.Drawing.Size(121, 17)
        Me._Label1_0.TabIndex = 8
        Me._Label1_0.Tag = "Name of receiver,payer:"
        Me._Label1_0.Text = "Tên người nộp tiền:"
        '
        'Command
        '
        Me.Command.Image = Global.UNET.My.Resources.Resources.save16
        Me.Command.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Command.Location = New System.Drawing.Point(278, 172)
        Me.Command.Name = "Command"
        Me.Command.Size = New System.Drawing.Size(73, 25)
        Me.Command.TabIndex = 30
        Me.Command.Tag = "Save"
        Me.Command.Text = "&Ghi"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(10, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Tag = "Object code"
        Me.Label2.Text = "Hình thức thanh toán"
        '
        'txt_hinhthucthanhtoan
        '
        Me.txt_hinhthucthanhtoan.Location = New System.Drawing.Point(130, 105)
        Me.txt_hinhthucthanhtoan.Name = "txt_hinhthucthanhtoan"
        Me.txt_hinhthucthanhtoan.Size = New System.Drawing.Size(160, 20)
        Me.txt_hinhthucthanhtoan.TabIndex = 31
        Me.txt_hinhthucthanhtoan.Text = "..."
        '
        '_OptHD_2
        '
        Me._OptHD_2.BackColor = System.Drawing.Color.Transparent
        Me._OptHD_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptHD_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptHD_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptHD_2.Location = New System.Drawing.Point(13, 177)
        Me._OptHD_2.Name = "_OptHD_2"
        Me._OptHD_2.Size = New System.Drawing.Size(105, 17)
        Me._OptHD_2.TabIndex = 32
        Me._OptHD_2.TabStop = True
        Me._OptHD_2.Tag = "Delivery Notes"
        Me._OptHD_2.Text = "Phiếu giao hàng"
        Me._OptHD_2.UseVisualStyleBackColor = False
        '
        'FThuChi
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(617, 204)
        Me.ControlBox = False
        Me.Controls.Add(Me._OptHD_2)
        Me.Controls.Add(Me.txt_hinhthucthanhtoan)
        Me.Controls.Add(Me.Command)
        Me.Controls.Add(Me._OptHD_0)
        Me.Controls.Add(Me._OptHD_1)
        Me.Controls.Add(Me._T_4)
        Me.Controls.Add(Me.cmdkh)
        Me.Controls.Add(Me._T_3)
        Me.Controls.Add(Me.cmdkh1)
        Me.Controls.Add(Me.txtshkh)
        Me.Controls.Add(Me._T_2)
        Me.Controls.Add(Me._T_1)
        Me.Controls.Add(Me._T_0)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.MedNgay)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me._Label1_5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbkh)
        Me.Controls.Add(Me._Label1_3)
        Me.Controls.Add(Me._Label1_2)
        Me.Controls.Add(Me._Label1_1)
        Me.Controls.Add(Me._Label1_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(252, 270)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FThuChi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Thông tin về phiếu thu - chi"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Sub InitializeT()
        Me.T(4) = _T_4
        Me.T(3) = _T_3
        Me.T(2) = _T_2
        Me.T(1) = _T_1
        Me.T(0) = _T_0
        Me.T(5) = _T_5
    End Sub
    Sub InitializeOptHD()
        Me.OptHD(0) = _OptHD_0
        Me.OptHD(1) = _OptHD_1
        Me.OptHD(2) = _OptHD_2
    End Sub
    Sub InitializeLabel1()
        Me.Label1(7) = _Label1_7
        Me.Label1(4) = _Label1_4
        Me.Label1(5) = _Label1_5
        Me.Label1(3) = _Label1_3
        Me.Label1(2) = _Label1_2
        Me.Label1(1) = _Label1_1
        Me.Label1(0) = _Label1_0
    End Sub
    Sub InitializeChkNT()
        Me.ChkNT(4) = _ChkNT_4
        Me.ChkNT(3) = _ChkNT_3
        Me.ChkNT(2) = _ChkNT_2
        Me.ChkNT(1) = _ChkNT_1
        Me.ChkNT(0) = _ChkNT_0
    End Sub
    Public WithEvents Command As System.Windows.Forms.Button
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_hinhthucthanhtoan As System.Windows.Forms.TextBox
    Private WithEvents _OptHD_2 As System.Windows.Forms.RadioButton
#End Region
End Class
