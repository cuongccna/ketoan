<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCongcudungcu
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		Initializemndd()
		InitializeText_Renamed()
		InitializeLine1()
		InitializeLabel()
		InitializeCommand()
		InitializeCombo()
	End Sub
	Private Sub Ctx_mnpu_Opening(ByVal sender As object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Ctx_mnpu.Opening
		Dim list As System.Collections.Generic.List(Of System.Windows.Forms.ToolStripItem) = New System.Collections.Generic.List(Of System.Windows.Forms.ToolStripItem)()
        Ctx_mnpu.Items.Clear()
        'We are moving the submenus FROM original menu to the context menu before displaying it
		For	Each item As System.Windows.Forms.ToolStripItem In mnpu.DropDownItems
			list.Add(item)
		Next item
		For	Each item As System.Windows.Forms.ToolStripItem In list
			Ctx_mnpu.Items.Add(item)
		Next item
		e.Cancel = False
	End Sub
	Private Sub Ctx_mnpu_Closing(ByVal sender As object, ByVal e As System.Windows.Forms.ToolStripDropDownClosingEventArgs) Handles Ctx_mnpu.Closing
		Dim list As System.Collections.Generic.List(Of System.Windows.Forms.ToolStripItem) = New System.Collections.Generic.List(Of System.Windows.Forms.ToolStripItem)()
		'We are moving the submenus the context menu back to the original menu after displaying
		For	Each item As System.Windows.Forms.ToolStripItem In Ctx_mnpu.Items
			list.Add(item)
		Next item
		For	Each item As System.Windows.Forms.ToolStripItem In list
			mnpu.DropDownItems.Add(item)
		Next item
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
	Private WithEvents _mndd_0 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_1 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_2 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mndd_3 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents _mndd_4 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnpu As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
    Private WithEvents _Command_4 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Combo_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Text_4 As System.Windows.Forms.TextBox
    Private WithEvents _Combo_7 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Combo_5 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Combo_2 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Combo_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Text_1 As System.Windows.Forms.TextBox
    Private WithEvents _Text_15 As System.Windows.Forms.TextBox
    Private WithEvents _Text_7 As System.Windows.Forms.TextBox
    Private WithEvents _Text_11 As System.Windows.Forms.TextBox
    Private WithEvents _Text_18 As System.Windows.Forms.TextBox
    Private WithEvents _Text_19 As System.Windows.Forms.TextBox
    Public WithEvents MedNgay As System.Windows.Forms.MaskedTextBox
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Private WithEvents _Label_23 As System.Windows.Forms.Label
    Private WithEvents _Line1_0 As System.Windows.Forms.Label
    Private WithEvents _Line1_1 As System.Windows.Forms.Label
    Private WithEvents _Line1_2 As System.Windows.Forms.Label
    Private WithEvents _Line1_3 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Line1_4 As System.Windows.Forms.Label
    Private WithEvents _Line1_5 As System.Windows.Forms.Label
    Private WithEvents _Line1_6 As System.Windows.Forms.Label
    Private WithEvents _Line1_7 As System.Windows.Forms.Label
    Private WithEvents _Label_20 As System.Windows.Forms.Label
    Private WithEvents _Label_19 As System.Windows.Forms.Label
    Private WithEvents _Label_18 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Label_16 As System.Windows.Forms.Label
    Private WithEvents _Label_21 As System.Windows.Forms.Label
    Private WithEvents _Label_22 As System.Windows.Forms.Label
    Private WithEvents _Label_27 As System.Windows.Forms.Label
    Private WithEvents _Line1_8 As System.Windows.Forms.Label
    Private WithEvents _Line1_9 As System.Windows.Forms.Label
    Private WithEvents _Line1_10 As System.Windows.Forms.Label
    Private WithEvents _Line1_11 As System.Windows.Forms.Label
    Private WithEvents _Label_31 As System.Windows.Forms.Label
    Private WithEvents _Label_32 As System.Windows.Forms.Label
    Private WithEvents _Label_33 As System.Windows.Forms.Label
    Private WithEvents _Label_34 As System.Windows.Forms.Label
    Public Combo(7) As ComboBoxEx.ComboBoxExt
    Public Command(4) As System.Windows.Forms.Button
    Public Command1(4) As System.Windows.Forms.Button
    Public Label(34) As System.Windows.Forms.Label
    Public Line1(11) As System.Windows.Forms.Label
    Public Text_Renamed(19) As System.Windows.Forms.TextBox
    Public mndd(4) As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents Ctx_mnpu As System.Windows.Forms.ContextMenuStrip
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCongcudungcu))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip
        Me.mnpu = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_0 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_1 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_2 = New System.Windows.Forms.ToolStripMenuItem
        Me._mndd_3 = New System.Windows.Forms.ToolStripSeparator
        Me._mndd_4 = New System.Windows.Forms.ToolStripMenuItem
        Me._Combo_0 = New ComboBoxEx.ComboBoxExt
        Me._Text_4 = New System.Windows.Forms.TextBox
        Me._Combo_7 = New ComboBoxEx.ComboBoxExt
        Me._Combo_5 = New ComboBoxEx.ComboBoxExt
        Me._Combo_2 = New ComboBoxEx.ComboBoxExt
        Me._Combo_1 = New ComboBoxEx.ComboBoxExt
        Me._Text_1 = New System.Windows.Forms.TextBox
        Me._Text_15 = New System.Windows.Forms.TextBox
        Me._Text_7 = New System.Windows.Forms.TextBox
        Me._Text_11 = New System.Windows.Forms.TextBox
        Me._Text_18 = New System.Windows.Forms.TextBox
        Me._Text_19 = New System.Windows.Forms.TextBox
        Me.MedNgay = New System.Windows.Forms.MaskedTextBox
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Label_17 = New System.Windows.Forms.Label
        Me._Label_5 = New System.Windows.Forms.Label
        Me._Label_14 = New System.Windows.Forms.Label
        Me._Label_23 = New System.Windows.Forms.Label
        Me._Line1_0 = New System.Windows.Forms.Label
        Me._Line1_1 = New System.Windows.Forms.Label
        Me._Line1_2 = New System.Windows.Forms.Label
        Me._Line1_3 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Line1_4 = New System.Windows.Forms.Label
        Me._Line1_5 = New System.Windows.Forms.Label
        Me._Line1_6 = New System.Windows.Forms.Label
        Me._Line1_7 = New System.Windows.Forms.Label
        Me._Label_20 = New System.Windows.Forms.Label
        Me._Label_19 = New System.Windows.Forms.Label
        Me._Label_18 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Label_12 = New System.Windows.Forms.Label
        Me._Label_13 = New System.Windows.Forms.Label
        Me._Label_10 = New System.Windows.Forms.Label
        Me._Label_16 = New System.Windows.Forms.Label
        Me._Label_21 = New System.Windows.Forms.Label
        Me._Label_22 = New System.Windows.Forms.Label
        Me._Label_27 = New System.Windows.Forms.Label
        Me._Line1_8 = New System.Windows.Forms.Label
        Me._Line1_9 = New System.Windows.Forms.Label
        Me._Line1_10 = New System.Windows.Forms.Label
        Me._Line1_11 = New System.Windows.Forms.Label
        Me._Label_31 = New System.Windows.Forms.Label
        Me._Label_32 = New System.Windows.Forms.Label
        Me._Label_33 = New System.Windows.Forms.Label
        Me._Label_34 = New System.Windows.Forms.Label
        Me.Ctx_mnpu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me._Command_4 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me.MainMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnpu})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(463, 24)
        Me.MainMenu1.TabIndex = 58
        '
        'mnpu
        '
        Me.mnpu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._mndd_0, Me._mndd_1, Me._mndd_2, Me._mndd_3, Me._mndd_4})
        Me.mnpu.Name = "mnpu"
        Me.mnpu.Size = New System.Drawing.Size(71, 20)
        Me.mnpu.Tag = "Lists"
        Me.mnpu.Text = "Danh điểm"
        '
        '_mndd_0
        '
        Me._mndd_0.Name = "_mndd_0"
        Me._mndd_0.Size = New System.Drawing.Size(175, 22)
        Me._mndd_0.Tag = "Country List..."
        Me._mndd_0.Text = "Nước sản xuất ..."
        Me._mndd_0.Visible = False
        '
        '_mndd_1
        '
        Me._mndd_1.Name = "_mndd_1"
        Me._mndd_1.Size = New System.Drawing.Size(175, 22)
        Me._mndd_1.Tag = "Conjucture List..."
        Me._mndd_1.Text = "Tình trạng sử dụng ..."
        '
        '_mndd_2
        '
        Me._mndd_2.Name = "_mndd_2"
        Me._mndd_2.Size = New System.Drawing.Size(175, 22)
        Me._mndd_2.Tag = "Administrative Object List"
        Me._mndd_2.Text = "Đối tượng quản lý"
        Me._mndd_2.Visible = False
        '
        '_mndd_3
        '
        Me._mndd_3.Name = "_mndd_3"
        Me._mndd_3.Size = New System.Drawing.Size(172, 6)
        '
        '_mndd_4
        '
        Me._mndd_4.Name = "_mndd_4"
        Me._mndd_4.Size = New System.Drawing.Size(175, 22)
        Me._mndd_4.Tag = "Chart of Account"
        Me._mndd_4.Text = "Hệ thống tài khoản"
        '
        '_Combo_0
        '
        Me._Combo_0.BackColor = System.Drawing.SystemColors.Window
        Me._Combo_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_0.Location = New System.Drawing.Point(104, 200)
        Me._Combo_0.Name = "_Combo_0"
        Me._Combo_0.Size = New System.Drawing.Size(73, 21)
        Me._Combo_0.TabIndex = 6
        '
        '_Text_4
        '
        Me._Text_4.Location = New System.Drawing.Point(216, 264)
        Me._Text_4.MaxLength = 15
        Me._Text_4.Multiline = True
        Me._Text_4.Name = "_Text_4"
        Me._Text_4.Size = New System.Drawing.Size(137, 21)
        Me._Text_4.TabIndex = 8
        Me._Text_4.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._Text_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Combo_7
        '
        Me._Combo_7.BackColor = System.Drawing.SystemColors.Window
        Me._Combo_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_7.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_7.Location = New System.Drawing.Point(280, 200)
        Me._Combo_7.Name = "_Combo_7"
        Me._Combo_7.Size = New System.Drawing.Size(73, 21)
        Me._Combo_7.TabIndex = 7
        '
        '_Combo_5
        '
        Me._Combo_5.BackColor = System.Drawing.SystemColors.Window
        Me._Combo_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_5.Location = New System.Drawing.Point(104, 168)
        Me._Combo_5.Name = "_Combo_5"
        Me._Combo_5.Size = New System.Drawing.Size(249, 21)
        Me._Combo_5.TabIndex = 5
        '
        '_Combo_2
        '
        Me._Combo_2.BackColor = System.Drawing.SystemColors.Window
        Me._Combo_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_2.Location = New System.Drawing.Point(104, 72)
        Me._Combo_2.Name = "_Combo_2"
        Me._Combo_2.Size = New System.Drawing.Size(249, 21)
        Me._Combo_2.TabIndex = 1
        '
        '_Combo_1
        '
        Me._Combo_1.BackColor = System.Drawing.SystemColors.Window
        Me._Combo_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_1.Location = New System.Drawing.Point(104, 40)
        Me._Combo_1.Name = "_Combo_1"
        Me._Combo_1.Size = New System.Drawing.Size(249, 21)
        Me._Combo_1.TabIndex = 0
        '
        '_Text_1
        '
        Me._Text_1.Location = New System.Drawing.Point(104, 144)
        Me._Text_1.MaxLength = 50
        Me._Text_1.Name = "_Text_1"
        Me._Text_1.Size = New System.Drawing.Size(249, 20)
        Me._Text_1.TabIndex = 4
        '
        '_Text_15
        '
        Me._Text_15.Location = New System.Drawing.Point(216, 387)
        Me._Text_15.MaxLength = 15
        Me._Text_15.Multiline = True
        Me._Text_15.Name = "_Text_15"
        Me._Text_15.Size = New System.Drawing.Size(137, 21)
        Me._Text_15.TabIndex = 12
        Me._Text_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Text_7
        '
        Me._Text_7.Location = New System.Drawing.Point(216, 288)
        Me._Text_7.MaxLength = 15
        Me._Text_7.Multiline = True
        Me._Text_7.Name = "_Text_7"
        Me._Text_7.Size = New System.Drawing.Size(137, 21)
        Me._Text_7.TabIndex = 9
        Me._Text_7.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._Text_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Text_11
        '
        Me._Text_11.Location = New System.Drawing.Point(216, 312)
        Me._Text_11.MaxLength = 15
        Me._Text_11.Multiline = True
        Me._Text_11.Name = "_Text_11"
        Me._Text_11.Size = New System.Drawing.Size(137, 21)
        Me._Text_11.TabIndex = 10
        Me._Text_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Text_18
        '
        Me._Text_18.ForeColor = System.Drawing.Color.Navy
        Me._Text_18.Location = New System.Drawing.Point(216, 364)
        Me._Text_18.MaxLength = 5
        Me._Text_18.Name = "_Text_18"
        Me._Text_18.Size = New System.Drawing.Size(49, 20)
        Me._Text_18.TabIndex = 11
        Me._Text_18.Text = "12"
        Me._Text_18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Text_19
        '
        Me._Text_19.Location = New System.Drawing.Point(104, 120)
        Me._Text_19.MaxLength = 15
        Me._Text_19.Name = "_Text_19"
        Me._Text_19.Size = New System.Drawing.Size(97, 20)
        Me._Text_19.TabIndex = 2
        '
        'MedNgay
        '
        Me.MedNgay.AllowPromptAsInput = False
        Me.MedNgay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedNgay.Location = New System.Drawing.Point(296, 120)
        Me.MedNgay.Name = "MedNgay"
        Me.MedNgay.Size = New System.Drawing.Size(57, 20)
        Me.MedNgay.TabIndex = 3
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(11, 200)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(92, 17)
        Me._Label_0.TabIndex = 40
        Me._Label_0.Tag = "Month Import:"
        Me._Label_0.Text = "Tháng nhập :"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.Transparent
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(110, 270)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(86, 17)
        Me._Label_4.TabIndex = 39
        Me._Label_4.Text = "0,0"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.Transparent
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(16, 270)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(89, 17)
        Me._Label_2.TabIndex = 38
        Me._Label_2.Tag = "Quantity"
        Me._Label_2.Text = "Số lượng :"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.Color.Transparent
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_17.Location = New System.Drawing.Point(183, 200)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(92, 17)
        Me._Label_17.TabIndex = 37
        Me._Label_17.Tag = "Month Export:"
        Me._Label_17.Text = "Tháng xuất :"
        Me._Label_17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.Transparent
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_5.Location = New System.Drawing.Point(40, 168)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(57, 17)
        Me._Label_5.TabIndex = 36
        Me._Label_5.Tag = "Used by"
        Me._Label_5.Text = "Sử dụng :"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.Color.Transparent
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_14.Location = New System.Drawing.Point(40, 72)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(57, 17)
        Me._Label_14.TabIndex = 35
        Me._Label_14.Tag = "Class"
        Me._Label_14.Text = "Loại :"
        Me._Label_14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_23
        '
        Me._Label_23.BackColor = System.Drawing.Color.Transparent
        Me._Label_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_23.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_23.Location = New System.Drawing.Point(33, 40)
        Me._Label_23.Name = "_Label_23"
        Me._Label_23.Size = New System.Drawing.Size(64, 17)
        Me._Label_23.TabIndex = 34
        Me._Label_23.Tag = "Account :"
        Me._Label_23.Text = "Tài khoản :"
        Me._Label_23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Line1_0
        '
        Me._Line1_0.Enabled = False
        Me._Line1_0.Location = New System.Drawing.Point(8, 32)
        Me._Line1_0.Name = "_Line1_0"
        Me._Line1_0.Size = New System.Drawing.Size(360, 1)
        Me._Line1_0.TabIndex = 46
        '
        '_Line1_1
        '
        Me._Line1_1.BackColor = System.Drawing.SystemColors.Window
        Me._Line1_1.Enabled = False
        Me._Line1_1.Location = New System.Drawing.Point(8, 104)
        Me._Line1_1.Name = "_Line1_1"
        Me._Line1_1.Size = New System.Drawing.Size(360, 1)
        Me._Line1_1.TabIndex = 47
        '
        '_Line1_2
        '
        Me._Line1_2.Enabled = False
        Me._Line1_2.Location = New System.Drawing.Point(8, 32)
        Me._Line1_2.Name = "_Line1_2"
        Me._Line1_2.Size = New System.Drawing.Size(1, 72)
        Me._Line1_2.TabIndex = 48
        '
        '_Line1_3
        '
        Me._Line1_3.BackColor = System.Drawing.SystemColors.Window
        Me._Line1_3.Enabled = False
        Me._Line1_3.Location = New System.Drawing.Point(368, 32)
        Me._Line1_3.Name = "_Line1_3"
        Me._Line1_3.Size = New System.Drawing.Size(1, 72)
        Me._Line1_3.TabIndex = 49
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(40, 144)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(57, 17)
        Me._Label_1.TabIndex = 33
        Me._Label_1.Tag = "Name"
        Me._Label_1.Text = "Tên :"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Line1_4
        '
        Me._Line1_4.Enabled = False
        Me._Line1_4.Location = New System.Drawing.Point(8, 112)
        Me._Line1_4.Name = "_Line1_4"
        Me._Line1_4.Size = New System.Drawing.Size(360, 1)
        Me._Line1_4.TabIndex = 50
        '
        '_Line1_5
        '
        Me._Line1_5.BackColor = System.Drawing.SystemColors.Window
        Me._Line1_5.Enabled = False
        Me._Line1_5.Location = New System.Drawing.Point(8, 232)
        Me._Line1_5.Name = "_Line1_5"
        Me._Line1_5.Size = New System.Drawing.Size(360, 1)
        Me._Line1_5.TabIndex = 51
        '
        '_Line1_6
        '
        Me._Line1_6.Enabled = False
        Me._Line1_6.Location = New System.Drawing.Point(8, 112)
        Me._Line1_6.Name = "_Line1_6"
        Me._Line1_6.Size = New System.Drawing.Size(1, 120)
        Me._Line1_6.TabIndex = 52
        '
        '_Line1_7
        '
        Me._Line1_7.BackColor = System.Drawing.SystemColors.Window
        Me._Line1_7.Enabled = False
        Me._Line1_7.Location = New System.Drawing.Point(368, 112)
        Me._Line1_7.Name = "_Line1_7"
        Me._Line1_7.Size = New System.Drawing.Size(1, 120)
        Me._Line1_7.TabIndex = 53
        '
        '_Label_20
        '
        Me._Label_20.BackColor = System.Drawing.Color.Transparent
        Me._Label_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_20.ForeColor = System.Drawing.Color.Black
        Me._Label_20.Location = New System.Drawing.Point(107, 318)
        Me._Label_20.Name = "_Label_20"
        Me._Label_20.Size = New System.Drawing.Size(89, 17)
        Me._Label_20.TabIndex = 32
        Me._Label_20.Text = "0,0"
        Me._Label_20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_19
        '
        Me._Label_19.BackColor = System.Drawing.Color.Transparent
        Me._Label_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_19.ForeColor = System.Drawing.Color.Black
        Me._Label_19.Location = New System.Drawing.Point(110, 294)
        Me._Label_19.Name = "_Label_19"
        Me._Label_19.Size = New System.Drawing.Size(86, 17)
        Me._Label_19.TabIndex = 31
        Me._Label_19.Text = "0,0"
        Me._Label_19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_18
        '
        Me._Label_18.BackColor = System.Drawing.Color.Transparent
        Me._Label_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_18.Location = New System.Drawing.Point(144, 248)
        Me._Label_18.Name = "_Label_18"
        Me._Label_18.Size = New System.Drawing.Size(49, 17)
        Me._Label_18.TabIndex = 30
        Me._Label_18.Tag = "Total"
        Me._Label_18.Text = "Tổng số"
        Me._Label_18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.Transparent
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_8.Location = New System.Drawing.Point(11, 294)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(94, 17)
        Me._Label_8.TabIndex = 29
        Me._Label_8.Tag = "Original Cost:"
        Me._Label_8.Text = "Tổng giá trị :"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_12
        '
        Me._Label_12.BackColor = System.Drawing.Color.Transparent
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_12.Location = New System.Drawing.Point(0, 318)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.Size = New System.Drawing.Size(105, 17)
        Me._Label_12.TabIndex = 28
        Me._Label_12.Tag = "Allocation:"
        Me._Label_12.Text = "Giá trị đã phân bổ :"
        Me._Label_12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.Transparent
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_13.Location = New System.Drawing.Point(3, 342)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(102, 17)
        Me._Label_13.TabIndex = 27
        Me._Label_13.Tag = "Residual Value:"
        Me._Label_13.Text = "Giá trị còn lại :"
        Me._Label_13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.Transparent
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_10.Location = New System.Drawing.Point(283, 248)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(57, 17)
        Me._Label_10.TabIndex = 26
        Me._Label_10.Tag = "Capital"
        Me._Label_10.Text = "Giá trị"
        Me._Label_10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_16
        '
        Me._Label_16.BackColor = System.Drawing.Color.Transparent
        Me._Label_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_16.ForeColor = System.Drawing.Color.Black
        Me._Label_16.Location = New System.Drawing.Point(0, 392)
        Me._Label_16.Name = "_Label_16"
        Me._Label_16.Size = New System.Drawing.Size(116, 17)
        Me._Label_16.TabIndex = 25
        Me._Label_16.Tag = "Monthly Allocation:"
        Me._Label_16.Text = "Giá trị phân bổ 1 kỳ :"
        Me._Label_16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_21
        '
        Me._Label_21.BackColor = System.Drawing.Color.Transparent
        Me._Label_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_21.ForeColor = System.Drawing.Color.Black
        Me._Label_21.Location = New System.Drawing.Point(99, 342)
        Me._Label_21.Name = "_Label_21"
        Me._Label_21.Size = New System.Drawing.Size(97, 17)
        Me._Label_21.TabIndex = 24
        Me._Label_21.Text = "0,0"
        Me._Label_21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_22
        '
        Me._Label_22.BackColor = System.Drawing.Color.Transparent
        Me._Label_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_22.ForeColor = System.Drawing.Color.Navy
        Me._Label_22.Location = New System.Drawing.Point(123, 390)
        Me._Label_22.Name = "_Label_22"
        Me._Label_22.Size = New System.Drawing.Size(73, 17)
        Me._Label_22.TabIndex = 23
        Me._Label_22.Text = "0,0"
        Me._Label_22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_27
        '
        Me._Label_27.BackColor = System.Drawing.Color.Transparent
        Me._Label_27.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_27.ForeColor = System.Drawing.Color.Black
        Me._Label_27.Location = New System.Drawing.Point(216, 344)
        Me._Label_27.Name = "_Label_27"
        Me._Label_27.Size = New System.Drawing.Size(133, 17)
        Me._Label_27.TabIndex = 22
        Me._Label_27.Text = "0,0"
        Me._Label_27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Line1_8
        '
        Me._Line1_8.Enabled = False
        Me._Line1_8.Location = New System.Drawing.Point(8, 240)
        Me._Line1_8.Name = "_Line1_8"
        Me._Line1_8.Size = New System.Drawing.Size(360, 1)
        Me._Line1_8.TabIndex = 54
        '
        '_Line1_9
        '
        Me._Line1_9.BackColor = System.Drawing.SystemColors.Window
        Me._Line1_9.Enabled = False
        Me._Line1_9.Location = New System.Drawing.Point(8, 416)
        Me._Line1_9.Name = "_Line1_9"
        Me._Line1_9.Size = New System.Drawing.Size(360, 1)
        Me._Line1_9.TabIndex = 55
        '
        '_Line1_10
        '
        Me._Line1_10.Enabled = False
        Me._Line1_10.Location = New System.Drawing.Point(8, 240)
        Me._Line1_10.Name = "_Line1_10"
        Me._Line1_10.Size = New System.Drawing.Size(1, 176)
        Me._Line1_10.TabIndex = 56
        '
        '_Line1_11
        '
        Me._Line1_11.BackColor = System.Drawing.SystemColors.Window
        Me._Line1_11.Enabled = False
        Me._Line1_11.Location = New System.Drawing.Point(368, 240)
        Me._Line1_11.Name = "_Line1_11"
        Me._Line1_11.Size = New System.Drawing.Size(1, 176)
        Me._Line1_11.TabIndex = 57
        '
        '_Label_31
        '
        Me._Label_31.BackColor = System.Drawing.Color.Transparent
        Me._Label_31.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_31.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_31.Location = New System.Drawing.Point(0, 366)
        Me._Label_31.Name = "_Label_31"
        Me._Label_31.Size = New System.Drawing.Size(105, 17)
        Me._Label_31.TabIndex = 21
        Me._Label_31.Tag = "Year of Allocation:"
        Me._Label_31.Text = "Số kỳ phân bổ :"
        Me._Label_31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_32
        '
        Me._Label_32.BackColor = System.Drawing.Color.Transparent
        Me._Label_32.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_32.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_32.Location = New System.Drawing.Point(271, 368)
        Me._Label_32.Name = "_Label_32"
        Me._Label_32.Size = New System.Drawing.Size(91, 17)
        Me._Label_32.TabIndex = 20
        Me._Label_32.Tag = "Month(s)"
        Me._Label_32.Text = "tháng"
        '
        '_Label_33
        '
        Me._Label_33.BackColor = System.Drawing.Color.Transparent
        Me._Label_33.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_33.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_33.Location = New System.Drawing.Point(14, 120)
        Me._Label_33.Name = "_Label_33"
        Me._Label_33.Size = New System.Drawing.Size(83, 17)
        Me._Label_33.TabIndex = 19
        Me._Label_33.Tag = "Code :"
        Me._Label_33.Text = "Số CT tăng :"
        Me._Label_33.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_34
        '
        Me._Label_34.BackColor = System.Drawing.Color.Transparent
        Me._Label_34.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_34.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_34.Location = New System.Drawing.Point(216, 120)
        Me._Label_34.Name = "_Label_34"
        Me._Label_34.Size = New System.Drawing.Size(73, 17)
        Me._Label_34.TabIndex = 18
        Me._Label_34.Tag = "Date :"
        Me._Label_34.Text = "Ngày CT :"
        Me._Label_34.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Ctx_mnpu
        '
        Me.Ctx_mnpu.Name = "Ctx_mnpu"
        Me.Ctx_mnpu.Size = New System.Drawing.Size(61, 4)
        '
        '_Command_4
        '
        Me._Command_4.Image = Global.UNET.My.Resources.Resources.print16
        Me._Command_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_4.Location = New System.Drawing.Point(377, 128)
        Me._Command_4.Name = "_Command_4"
        Me._Command_4.Size = New System.Drawing.Size(82, 25)
        Me._Command_4.TabIndex = 45
        Me._Command_4.Tag = "Print"
        Me._Command_4.Text = "&In"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.tool16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(377, 160)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(82, 25)
        Me._Command_2.TabIndex = 43
        Me._Command_2.Text = "&P. tùng"
        Me._Command_2.Visible = False
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(377, 64)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(82, 25)
        Me._Command_1.TabIndex = 42
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(377, 32)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(82, 25)
        Me._Command_0.TabIndex = 41
        Me._Command_0.Tag = "Save"
        Me._Command_0.Text = "&Ghi"
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.report16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(377, 96)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(82, 25)
        Me._Command_3.TabIndex = 44
        Me._Command_3.Tag = "Preview"
        Me._Command_3.Text = "&Xem"
        '
        'FrmCongcudungcu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(463, 424)
        Me.Controls.Add(Me._Command_4)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Combo_0)
        Me.Controls.Add(Me._Text_4)
        Me.Controls.Add(Me._Combo_7)
        Me.Controls.Add(Me._Combo_5)
        Me.Controls.Add(Me._Combo_2)
        Me.Controls.Add(Me._Combo_1)
        Me.Controls.Add(Me._Text_1)
        Me.Controls.Add(Me._Text_15)
        Me.Controls.Add(Me._Text_7)
        Me.Controls.Add(Me._Text_11)
        Me.Controls.Add(Me._Text_18)
        Me.Controls.Add(Me._Text_19)
        Me.Controls.Add(Me.MedNgay)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_17)
        Me.Controls.Add(Me._Label_5)
        Me.Controls.Add(Me._Label_14)
        Me.Controls.Add(Me._Label_23)
        Me.Controls.Add(Me._Line1_0)
        Me.Controls.Add(Me._Line1_1)
        Me.Controls.Add(Me._Line1_2)
        Me.Controls.Add(Me._Line1_3)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Line1_4)
        Me.Controls.Add(Me._Line1_5)
        Me.Controls.Add(Me._Line1_6)
        Me.Controls.Add(Me._Line1_7)
        Me.Controls.Add(Me._Label_20)
        Me.Controls.Add(Me._Label_19)
        Me.Controls.Add(Me._Label_18)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_12)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Label_16)
        Me.Controls.Add(Me._Label_21)
        Me.Controls.Add(Me._Label_22)
        Me.Controls.Add(Me._Label_27)
        Me.Controls.Add(Me._Line1_8)
        Me.Controls.Add(Me._Line1_9)
        Me.Controls.Add(Me._Line1_10)
        Me.Controls.Add(Me._Line1_11)
        Me.Controls.Add(Me._Label_31)
        Me.Controls.Add(Me._Label_32)
        Me.Controls.Add(Me._Label_33)
        Me.Controls.Add(Me._Label_34)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(14, 34)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCongcudungcu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Công cụ dụng cụ"
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub Initializemndd()
		Me.mndd(0) = _mndd_0
		Me.mndd(1) = _mndd_1
		Me.mndd(2) = _mndd_2
        'Me.mndd(3) = _mndd_3
		Me.mndd(4) = _mndd_4
	End Sub
	Sub InitializeText_Renamed()
		Me.Text_Renamed(4) = _Text_4
		Me.Text_Renamed(1) = _Text_1
		Me.Text_Renamed(15) = _Text_15
		Me.Text_Renamed(7) = _Text_7
		Me.Text_Renamed(11) = _Text_11
		Me.Text_Renamed(18) = _Text_18
		Me.Text_Renamed(19) = _Text_19
	End Sub
	Sub InitializeLine1()
		Me.Line1(0) = _Line1_0
		Me.Line1(1) = _Line1_1
		Me.Line1(2) = _Line1_2
		Me.Line1(3) = _Line1_3
		Me.Line1(4) = _Line1_4
		Me.Line1(5) = _Line1_5
		Me.Line1(6) = _Line1_6
		Me.Line1(7) = _Line1_7
		Me.Line1(8) = _Line1_8
		Me.Line1(9) = _Line1_9
		Me.Line1(10) = _Line1_10
		Me.Line1(11) = _Line1_11
	End Sub
	Sub InitializeLabel()
		Me.Label(0) = _Label_0
		Me.Label(4) = _Label_4
		Me.Label(2) = _Label_2
		Me.Label(17) = _Label_17
		Me.Label(5) = _Label_5
		Me.Label(14) = _Label_14
		Me.Label(23) = _Label_23
		Me.Label(1) = _Label_1
		Me.Label(20) = _Label_20
		Me.Label(19) = _Label_19
		Me.Label(18) = _Label_18
		Me.Label(8) = _Label_8
		Me.Label(12) = _Label_12
		Me.Label(13) = _Label_13
		Me.Label(10) = _Label_10
		Me.Label(16) = _Label_16
		Me.Label(21) = _Label_21
		Me.Label(22) = _Label_22
		Me.Label(27) = _Label_27
		Me.Label(31) = _Label_31
		Me.Label(32) = _Label_32
		Me.Label(33) = _Label_33
		Me.Label(34) = _Label_34
	End Sub
	Sub InitializeCommand()
		Me.Command(4) = _Command_4
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
		Me.Command(3) = _Command_3
	End Sub
	Sub InitializeCombo()
		Me.Combo(0) = _Combo_0
		Me.Combo(7) = _Combo_7
		Me.Combo(5) = _Combo_5
		Me.Combo(2) = _Combo_2
		Me.Combo(1) = _Combo_1
	End Sub
#End Region 
End Class
