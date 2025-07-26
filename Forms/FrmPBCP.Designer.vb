<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPBCP
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
        isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		InitializeOpt()
		InitializeLbKC()
		InitializeCommand()
		InitializeChkKC()
		InitializeCbo()
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
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _ChkKC_7 As System.Windows.Forms.RadioButton
    Private WithEvents _ChkKC_6 As System.Windows.Forms.RadioButton
    Private WithEvents _ChkKC_5 As System.Windows.Forms.RadioButton
    Private WithEvents _ChkKC_4 As System.Windows.Forms.RadioButton
    Private WithEvents _ChkKC_3 As System.Windows.Forms.RadioButton
    Private WithEvents _ChkKC_2 As System.Windows.Forms.RadioButton
    Private WithEvents _Opt_4 As System.Windows.Forms.CheckBox
    Public WithEvents T As System.Windows.Forms.TextBox
    Private WithEvents _Opt_3 As System.Windows.Forms.CheckBox
    Private WithEvents _Opt_2 As System.Windows.Forms.CheckBox
    Private WithEvents _Opt_1 As System.Windows.Forms.CheckBox
    Private WithEvents _Opt_0 As System.Windows.Forms.CheckBox
    Private WithEvents _LbKC_2 As System.Windows.Forms.Label
    Private WithEvents _LbKC_3 As System.Windows.Forms.Label
    Public WithEvents Frame As System.Windows.Forms.GroupBox
    Private WithEvents _Cbo_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Cbo_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _ChkKC_0 As System.Windows.Forms.RadioButton
    Private WithEvents _ChkKC_1 As System.Windows.Forms.RadioButton
    Private WithEvents _LbKC_1 As System.Windows.Forms.Label
    Private WithEvents _LbKC_0 As System.Windows.Forms.Label
    Public Cbo(1) As ComboBoxEx.ComboBoxExt
    Public ChkKC(7) As System.Windows.Forms.RadioButton
    Public Command(3) As System.Windows.Forms.Button
    Public Command1(3) As System.Windows.Forms.Button
    Public LbKC(3) As System.Windows.Forms.Label
    Public Opt(4) As System.Windows.Forms.CheckBox
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._ChkKC_7 = New System.Windows.Forms.RadioButton
        Me._ChkKC_6 = New System.Windows.Forms.RadioButton
        Me._ChkKC_5 = New System.Windows.Forms.RadioButton
        Me._ChkKC_4 = New System.Windows.Forms.RadioButton
        Me._ChkKC_3 = New System.Windows.Forms.RadioButton
        Me._ChkKC_2 = New System.Windows.Forms.RadioButton
        Me._Opt_4 = New System.Windows.Forms.CheckBox
        Me._Opt_3 = New System.Windows.Forms.CheckBox
        Me._Opt_2 = New System.Windows.Forms.CheckBox
        Me._Opt_1 = New System.Windows.Forms.CheckBox
        Me._Opt_0 = New System.Windows.Forms.CheckBox
        Me._ChkKC_0 = New System.Windows.Forms.RadioButton
        Me._ChkKC_1 = New System.Windows.Forms.RadioButton
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me.Frame = New System.Windows.Forms.GroupBox
        Me.T = New System.Windows.Forms.TextBox
        Me._LbKC_2 = New System.Windows.Forms.Label
        Me._LbKC_3 = New System.Windows.Forms.Label
        Me._Cbo_1 = New ComboBoxEx.ComboBoxExt
        Me._Cbo_0 = New ComboBoxEx.ComboBoxExt
        Me._LbKC_1 = New System.Windows.Forms.Label
        Me._LbKC_0 = New System.Windows.Forms.Label
        Me.Frame.SuspendLayout()
        Me.SuspendLayout()
        '
        '_ChkKC_7
        '
        Me._ChkKC_7.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_7.Location = New System.Drawing.Point(8, 192)
        Me._ChkKC_7.Name = "_ChkKC_7"
        Me._ChkKC_7.Size = New System.Drawing.Size(161, 17)
        Me._ChkKC_7.TabIndex = 24
        Me._ChkKC_7.TabStop = True
        Me._ChkKC_7.Tag = "627"
        Me._ChkKC_7.Text = "Chi phí tài chính"
        Me.ToolTipMain.SetToolTip(Me._ChkKC_7, "Pending Expenses ")
        Me._ChkKC_7.UseVisualStyleBackColor = False
        '
        '_ChkKC_6
        '
        Me._ChkKC_6.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_6.Location = New System.Drawing.Point(8, 96)
        Me._ChkKC_6.Name = "_ChkKC_6"
        Me._ChkKC_6.Size = New System.Drawing.Size(161, 17)
        Me._ChkKC_6.TabIndex = 4
        Me._ChkKC_6.TabStop = True
        Me._ChkKC_6.Tag = "641"
        Me._ChkKC_6.Text = "Chi phí máy thi công"
        Me.ToolTipMain.SetToolTip(Me._ChkKC_6, "Machine expenses")
        Me._ChkKC_6.UseVisualStyleBackColor = False
        '
        '_ChkKC_5
        '
        Me._ChkKC_5.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_5.Location = New System.Drawing.Point(8, 48)
        Me._ChkKC_5.Name = "_ChkKC_5"
        Me._ChkKC_5.Size = New System.Drawing.Size(177, 17)
        Me._ChkKC_5.TabIndex = 2
        Me._ChkKC_5.TabStop = True
        Me._ChkKC_5.Tag = "641"
        Me._ChkKC_5.Text = "Chi phí nguyên vật liệu trực tiếp"
        Me.ToolTipMain.SetToolTip(Me._ChkKC_5, "Raw material Expenses")
        Me._ChkKC_5.UseVisualStyleBackColor = False
        '
        '_ChkKC_4
        '
        Me._ChkKC_4.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_4.Location = New System.Drawing.Point(8, 72)
        Me._ChkKC_4.Name = "_ChkKC_4"
        Me._ChkKC_4.Size = New System.Drawing.Size(161, 17)
        Me._ChkKC_4.TabIndex = 3
        Me._ChkKC_4.TabStop = True
        Me._ChkKC_4.Tag = "641"
        Me._ChkKC_4.Text = "Chi phí nhân công trực tiếp"
        Me.ToolTipMain.SetToolTip(Me._ChkKC_4, "Labour Expenses")
        Me._ChkKC_4.UseVisualStyleBackColor = False
        '
        '_ChkKC_3
        '
        Me._ChkKC_3.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_3.Location = New System.Drawing.Point(8, 216)
        Me._ChkKC_3.Name = "_ChkKC_3"
        Me._ChkKC_3.Size = New System.Drawing.Size(161, 17)
        Me._ChkKC_3.TabIndex = 8
        Me._ChkKC_3.TabStop = True
        Me._ChkKC_3.Tag = "627"
        Me._ChkKC_3.Text = "Chi phí chờ phân bổ"
        Me.ToolTipMain.SetToolTip(Me._ChkKC_3, "Pending Expenses ")
        Me._ChkKC_3.UseVisualStyleBackColor = False
        '
        '_ChkKC_2
        '
        Me._ChkKC_2.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_2.Checked = True
        Me._ChkKC_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_2.Location = New System.Drawing.Point(8, 168)
        Me._ChkKC_2.Name = "_ChkKC_2"
        Me._ChkKC_2.Size = New System.Drawing.Size(161, 17)
        Me._ChkKC_2.TabIndex = 7
        Me._ChkKC_2.TabStop = True
        Me._ChkKC_2.Tag = "642"
        Me._ChkKC_2.Text = "Chi phí quản lý doanh nghiệp"
        Me.ToolTipMain.SetToolTip(Me._ChkKC_2, "Administrative Cost")
        Me._ChkKC_2.UseVisualStyleBackColor = False
        '
        '_Opt_4
        '
        Me._Opt_4.BackColor = System.Drawing.Color.Transparent
        Me._Opt_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_4.Enabled = False
        Me._Opt_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_4.Location = New System.Drawing.Point(8, 80)
        Me._Opt_4.Name = "_Opt_4"
        Me._Opt_4.Size = New System.Drawing.Size(137, 17)
        Me._Opt_4.TabIndex = 11
        Me._Opt_4.Tag = "6"
        Me._Opt_4.Text = "Chi phí sản xuất chung"
        Me.ToolTipMain.SetToolTip(Me._Opt_4, "General Expenses")
        Me._Opt_4.UseVisualStyleBackColor = False
        '
        '_Opt_3
        '
        Me._Opt_3.BackColor = System.Drawing.Color.Transparent
        Me._Opt_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_3.Enabled = False
        Me._Opt_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_3.Location = New System.Drawing.Point(8, 64)
        Me._Opt_3.Name = "_Opt_3"
        Me._Opt_3.Size = New System.Drawing.Size(129, 17)
        Me._Opt_3.TabIndex = 13
        Me._Opt_3.Tag = "7"
        Me._Opt_3.Text = "Chi phí máy thi công"
        Me.ToolTipMain.SetToolTip(Me._Opt_3, "Machine expenses")
        Me._Opt_3.UseVisualStyleBackColor = False
        '
        '_Opt_2
        '
        Me._Opt_2.BackColor = System.Drawing.Color.Transparent
        Me._Opt_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_2.Enabled = False
        Me._Opt_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_2.Location = New System.Drawing.Point(8, 48)
        Me._Opt_2.Name = "_Opt_2"
        Me._Opt_2.Size = New System.Drawing.Size(137, 17)
        Me._Opt_2.TabIndex = 12
        Me._Opt_2.Tag = "2"
        Me._Opt_2.Text = "Nhân công trực tiếp"
        Me.ToolTipMain.SetToolTip(Me._Opt_2, "Labour Expenses")
        Me._Opt_2.UseVisualStyleBackColor = False
        '
        '_Opt_1
        '
        Me._Opt_1.BackColor = System.Drawing.Color.Transparent
        Me._Opt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_1.Enabled = False
        Me._Opt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_1.Location = New System.Drawing.Point(8, 32)
        Me._Opt_1.Name = "_Opt_1"
        Me._Opt_1.Size = New System.Drawing.Size(137, 17)
        Me._Opt_1.TabIndex = 10
        Me._Opt_1.Tag = "1"
        Me._Opt_1.Text = "Nguyên vật liệu trực tiếp"
        Me.ToolTipMain.SetToolTip(Me._Opt_1, "Raw material Expenses")
        Me._Opt_1.UseVisualStyleBackColor = False
        '
        '_Opt_0
        '
        Me._Opt_0.BackColor = System.Drawing.Color.Transparent
        Me._Opt_0.Checked = True
        Me._Opt_0.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Opt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_0.Location = New System.Drawing.Point(8, 16)
        Me._Opt_0.Name = "_Opt_0"
        Me._Opt_0.Size = New System.Drawing.Size(137, 17)
        Me._Opt_0.TabIndex = 9
        Me._Opt_0.Tag = "4"
        Me._Opt_0.Text = "Doanh thu"
        Me.ToolTipMain.SetToolTip(Me._Opt_0, "Turnover")
        Me._Opt_0.UseVisualStyleBackColor = False
        '
        '_ChkKC_0
        '
        Me._ChkKC_0.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_0.Location = New System.Drawing.Point(8, 144)
        Me._ChkKC_0.Name = "_ChkKC_0"
        Me._ChkKC_0.Size = New System.Drawing.Size(137, 17)
        Me._ChkKC_0.TabIndex = 5
        Me._ChkKC_0.TabStop = True
        Me._ChkKC_0.Tag = "641"
        Me._ChkKC_0.Text = "Chi phí bán hàng"
        Me.ToolTipMain.SetToolTip(Me._ChkKC_0, "Sale expense")
        Me._ChkKC_0.UseVisualStyleBackColor = False
        '
        '_ChkKC_1
        '
        Me._ChkKC_1.BackColor = System.Drawing.Color.Transparent
        Me._ChkKC_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkKC_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkKC_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkKC_1.Location = New System.Drawing.Point(8, 120)
        Me._ChkKC_1.Name = "_ChkKC_1"
        Me._ChkKC_1.Size = New System.Drawing.Size(161, 17)
        Me._ChkKC_1.TabIndex = 6
        Me._ChkKC_1.TabStop = True
        Me._ChkKC_1.Tag = "627"
        Me._ChkKC_1.Text = "Chi phí sản xuất chung"
        Me.ToolTipMain.SetToolTip(Me._ChkKC_1, "General Expense")
        Me._ChkKC_1.UseVisualStyleBackColor = False
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(352, 120)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 28
        Me._Command_3.Tag = "Delete"
        Me._Command_3.Text = "&Xoá PB"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(352, 152)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 27
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.search2_16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(352, 88)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 26
        Me._Command_2.Tag = "Detail"
        Me._Command_2.Text = "&Chi tiết"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.list16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(352, 56)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 25
        Me._Command_0.Tag = "Allocation"
        Me._Command_0.Text = "&Phân bổ"
        '
        'Frame
        '
        Me.Frame.BackColor = System.Drawing.Color.Transparent
        Me.Frame.Controls.Add(Me._Opt_4)
        Me.Frame.Controls.Add(Me.T)
        Me.Frame.Controls.Add(Me._Opt_3)
        Me.Frame.Controls.Add(Me._Opt_2)
        Me.Frame.Controls.Add(Me._Opt_1)
        Me.Frame.Controls.Add(Me._Opt_0)
        Me.Frame.Controls.Add(Me._LbKC_2)
        Me.Frame.Controls.Add(Me._LbKC_3)
        Me.Frame.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame.Location = New System.Drawing.Point(192, 48)
        Me.Frame.Name = "Frame"
        Me.Frame.Size = New System.Drawing.Size(153, 129)
        Me.Frame.TabIndex = 19
        Me.Frame.TabStop = False
        Me.Frame.Tag = "Criteria"
        Me.Frame.Text = "Tiêu thức phân bổ"
        '
        'T
        '
        Me.T.AcceptsReturn = True
        Me.T.BackColor = System.Drawing.SystemColors.Window
        Me.T.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.T.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T.Location = New System.Drawing.Point(88, 104)
        Me.T.MaxLength = 3
        Me.T.Name = "T"
        Me.T.Size = New System.Drawing.Size(33, 20)
        Me.T.TabIndex = 14
        Me.T.Text = "100"
        '
        '_LbKC_2
        '
        Me._LbKC_2.BackColor = System.Drawing.Color.Transparent
        Me._LbKC_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbKC_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbKC_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LbKC_2.Location = New System.Drawing.Point(8, 106)
        Me._LbKC_2.Name = "_LbKC_2"
        Me._LbKC_2.Size = New System.Drawing.Size(73, 17)
        Me._LbKC_2.TabIndex = 21
        Me._LbKC_2.Tag = "Allocation Rate"
        Me._LbKC_2.Text = "Tỷ lệ phân bổ"
        '
        '_LbKC_3
        '
        Me._LbKC_3.BackColor = System.Drawing.Color.Transparent
        Me._LbKC_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbKC_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbKC_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LbKC_3.Location = New System.Drawing.Point(128, 106)
        Me._LbKC_3.Name = "_LbKC_3"
        Me._LbKC_3.Size = New System.Drawing.Size(17, 17)
        Me._LbKC_3.TabIndex = 20
        Me._LbKC_3.Text = "%"
        '
        '_Cbo_1
        '
        Me._Cbo_1.BackColor = System.Drawing.SystemColors.Window
        Me._Cbo_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Cbo_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Cbo_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Cbo_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cbo_1.Location = New System.Drawing.Point(296, 8)
        Me._Cbo_1.Name = "_Cbo_1"
        Me._Cbo_1.Size = New System.Drawing.Size(73, 21)
        Me._Cbo_1.TabIndex = 1
        '
        '_Cbo_0
        '
        Me._Cbo_0.BackColor = System.Drawing.SystemColors.Window
        Me._Cbo_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Cbo_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Cbo_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Cbo_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cbo_0.Location = New System.Drawing.Point(152, 8)
        Me._Cbo_0.Name = "_Cbo_0"
        Me._Cbo_0.Size = New System.Drawing.Size(73, 21)
        Me._Cbo_0.TabIndex = 0
        '
        '_LbKC_1
        '
        Me._LbKC_1.BackColor = System.Drawing.Color.Transparent
        Me._LbKC_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbKC_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbKC_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LbKC_1.Location = New System.Drawing.Point(232, 12)
        Me._LbKC_1.Name = "_LbKC_1"
        Me._LbKC_1.Size = New System.Drawing.Size(57, 17)
        Me._LbKC_1.TabIndex = 18
        Me._LbKC_1.Tag = "to"
        Me._LbKC_1.Text = "Đến tháng"
        Me._LbKC_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_LbKC_0
        '
        Me._LbKC_0.BackColor = System.Drawing.Color.Transparent
        Me._LbKC_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbKC_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbKC_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LbKC_0.Location = New System.Drawing.Point(8, 12)
        Me._LbKC_0.Name = "_LbKC_0"
        Me._LbKC_0.Size = New System.Drawing.Size(129, 17)
        Me._LbKC_0.TabIndex = 17
        Me._LbKC_0.Tag = "Expenses distributed FROM"
        Me._LbKC_0.Text = "Phân bổ chi phí từ tháng"
        '
        'FrmPBCP
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(434, 241)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._ChkKC_7)
        Me.Controls.Add(Me._ChkKC_6)
        Me.Controls.Add(Me._ChkKC_5)
        Me.Controls.Add(Me._ChkKC_4)
        Me.Controls.Add(Me._ChkKC_3)
        Me.Controls.Add(Me._ChkKC_2)
        Me.Controls.Add(Me.Frame)
        Me.Controls.Add(Me._Cbo_1)
        Me.Controls.Add(Me._Cbo_0)
        Me.Controls.Add(Me._ChkKC_0)
        Me.Controls.Add(Me._ChkKC_1)
        Me.Controls.Add(Me._LbKC_1)
        Me.Controls.Add(Me._LbKC_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(100, 161)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPBCP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Phân bổ chi phí"
        Me.ToolTipMain.SetToolTip(Me, "Costs Allocation")
        Me.Frame.ResumeLayout(False)
        Me.Frame.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
	Sub InitializeOpt()
		Me.Opt(4) = _Opt_4
		Me.Opt(3) = _Opt_3
		Me.Opt(2) = _Opt_2
		Me.Opt(1) = _Opt_1
		Me.Opt(0) = _Opt_0
	End Sub
	Sub InitializeLbKC()
		Me.LbKC(2) = _LbKC_2
		Me.LbKC(3) = _LbKC_3
		Me.LbKC(1) = _LbKC_1
		Me.LbKC(0) = _LbKC_0
	End Sub
	Sub InitializeCommand()
		Me.Command(3) = _Command_3
		Me.Command(1) = _Command_1
		Me.Command(2) = _Command_2
		Me.Command(0) = _Command_0
	End Sub
	Sub InitializeChkKC()
		Me.ChkKC(7) = _ChkKC_7
		Me.ChkKC(6) = _ChkKC_6
		Me.ChkKC(5) = _ChkKC_5
		Me.ChkKC(4) = _ChkKC_4
		Me.ChkKC(3) = _ChkKC_3
		Me.ChkKC(2) = _ChkKC_2
		Me.ChkKC(0) = _ChkKC_0
		Me.ChkKC(1) = _ChkKC_1
	End Sub
	Sub InitializeCbo()
		Me.Cbo(1) = _Cbo_1
		Me.Cbo(0) = _Cbo_0
	End Sub
#End Region 
End Class
