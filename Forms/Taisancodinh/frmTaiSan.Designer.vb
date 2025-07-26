<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaiSan
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializemnDD()
		InitializeText_Renamed()
		InitializeLabel()
		InitializeCommand1()
		InitializeCommand()
		InitializeCombo()
	End Sub
    Private Sub Ctx_mnPU_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Ctx_mnPU.Opening
        Dim list As System.Collections.Generic.List(Of System.Windows.Forms.ToolStripItem) = New System.Collections.Generic.List(Of System.Windows.Forms.ToolStripItem)()
        Ctx_mnPU.Items.Clear()
        'We are moving the submenus FROM original menu to the context menu before displaying it
        For Each item As System.Windows.Forms.ToolStripItem In mnPU.DropDownItems
            list.Add(item)
        Next item
        For Each item As System.Windows.Forms.ToolStripItem In list
            Ctx_mnPU.Items.Add(item)
        Next item
        e.Cancel = False
    End Sub
    Private Sub Ctx_mnPU_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosingEventArgs) Handles Ctx_mnPU.Closing
        Dim list As System.Collections.Generic.List(Of System.Windows.Forms.ToolStripItem) = New System.Collections.Generic.List(Of System.Windows.Forms.ToolStripItem)()
        'We are moving the submenus the context menu back to the original menu after displaying
        For Each item As System.Windows.Forms.ToolStripItem In Ctx_mnPU.Items
            list.Add(item)
        Next item
        For Each item As System.Windows.Forms.ToolStripItem In list
            mnPU.DropDownItems.Add(item)
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
    Private WithEvents _mnDD_0 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents _mnDD_1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents _mnDD_2 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents _mnDD_3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents _mnDD_4 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnPU As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
    Private WithEvents _Command_4 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Text_19 As System.Windows.Forms.TextBox
    Public WithEvents Chk As System.Windows.Forms.CheckBox
    Private WithEvents _Text_18 As System.Windows.Forms.TextBox
    Private WithEvents _Text_14 As System.Windows.Forms.TextBox
    Private WithEvents _Text_13 As System.Windows.Forms.TextBox
    Private WithEvents _Text_12 As System.Windows.Forms.TextBox
    Private WithEvents _Text_11 As System.Windows.Forms.TextBox
    Private WithEvents _Text_10 As System.Windows.Forms.TextBox
    Private WithEvents _Text_9 As System.Windows.Forms.TextBox
    Private WithEvents _Text_8 As System.Windows.Forms.TextBox
    Private WithEvents _Text_7 As System.Windows.Forms.TextBox
    Private WithEvents _Text_6 As System.Windows.Forms.TextBox
    Private WithEvents _Text_15 As System.Windows.Forms.TextBox
    Private WithEvents _Text_16 As System.Windows.Forms.TextBox
    Private WithEvents _Text_17 As System.Windows.Forms.TextBox
    Private WithEvents _Text_3 As System.Windows.Forms.TextBox
    Private WithEvents _Text_2 As System.Windows.Forms.TextBox
    Private WithEvents _Text_1 As System.Windows.Forms.TextBox
    Private WithEvents _Text_0 As System.Windows.Forms.TextBox
    Private WithEvents _Text_4 As System.Windows.Forms.TextBox
    Private WithEvents _Text_5 As System.Windows.Forms.TextBox
    Private WithEvents _Combo_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Combo_2 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Combo_3 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Command1_4 As System.Windows.Forms.Button
    Private WithEvents _Command1_3 As System.Windows.Forms.Button
    Private WithEvents _Command1_2 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Private WithEvents _Combo_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Combo_5 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Combo_4 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Combo_6 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Combo_7 As ComboBoxEx.ComboBoxExt
    Public WithEvents MedNgay As System.Windows.Forms.MaskedTextBox
    Private WithEvents _Label_34 As System.Windows.Forms.Label
    Private WithEvents _Label_33 As System.Windows.Forms.Label
    Private WithEvents _Label_32 As System.Windows.Forms.Label
    Private WithEvents _Label_31 As System.Windows.Forms.Label
    Private WithEvents _Label_28 As System.Windows.Forms.Label
    Private WithEvents _Label_27 As System.Windows.Forms.Label
    Private WithEvents _Label_26 As System.Windows.Forms.Label
    Private WithEvents _Label_22 As System.Windows.Forms.Label
    Private WithEvents _Label_21 As System.Windows.Forms.Label
    Private WithEvents _Label_16 As System.Windows.Forms.Label
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Label_9 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_18 As System.Windows.Forms.Label
    Private WithEvents _Label_19 As System.Windows.Forms.Label
    Private WithEvents _Label_20 As System.Windows.Forms.Label
    Private WithEvents _Label_29 As System.Windows.Forms.Label
    Private WithEvents _Label_30 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_24 As System.Windows.Forms.Label
    Private WithEvents _Label_25 As System.Windows.Forms.Label
    Private WithEvents _Label_23 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Private WithEvents _Label_15 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Public Combo(7) As ComboBoxEx.ComboBoxExt
    Public Command(4) As System.Windows.Forms.Button
    Public Command1(4) As System.Windows.Forms.Button
    Public Label(34) As System.Windows.Forms.Label
    Public Line1(11) As System.Windows.Forms.Label
    Public Text_Renamed(19) As System.Windows.Forms.TextBox
    Public mnDD(4) As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents Ctx_mnPU As System.Windows.Forms.ContextMenuStrip
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTaiSan))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip
        Me.mnPU = New System.Windows.Forms.ToolStripMenuItem
        Me._mnDD_0 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnDD_1 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnDD_2 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnDD_3 = New System.Windows.Forms.ToolStripSeparator
        Me._mnDD_4 = New System.Windows.Forms.ToolStripMenuItem
        Me._Command_4 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Text_19 = New System.Windows.Forms.TextBox
        Me.Chk = New System.Windows.Forms.CheckBox
        Me._Text_18 = New System.Windows.Forms.TextBox
        Me._Text_14 = New System.Windows.Forms.TextBox
        Me._Text_13 = New System.Windows.Forms.TextBox
        Me._Text_12 = New System.Windows.Forms.TextBox
        Me._Text_11 = New System.Windows.Forms.TextBox
        Me._Text_10 = New System.Windows.Forms.TextBox
        Me._Text_9 = New System.Windows.Forms.TextBox
        Me._Text_8 = New System.Windows.Forms.TextBox
        Me._Text_7 = New System.Windows.Forms.TextBox
        Me._Text_6 = New System.Windows.Forms.TextBox
        Me._Text_15 = New System.Windows.Forms.TextBox
        Me._Text_16 = New System.Windows.Forms.TextBox
        Me._Text_17 = New System.Windows.Forms.TextBox
        Me._Text_3 = New System.Windows.Forms.TextBox
        Me._Text_2 = New System.Windows.Forms.TextBox
        Me._Text_1 = New System.Windows.Forms.TextBox
        Me._Text_0 = New System.Windows.Forms.TextBox
        Me._Text_4 = New System.Windows.Forms.TextBox
        Me._Text_5 = New System.Windows.Forms.TextBox
        Me._Combo_1 = New ComboBoxEx.ComboBoxExt
        Me._Combo_2 = New ComboBoxEx.ComboBoxExt
        Me._Combo_3 = New ComboBoxEx.ComboBoxExt
        Me._Command1_4 = New System.Windows.Forms.Button
        Me._Command1_3 = New System.Windows.Forms.Button
        Me._Command1_2 = New System.Windows.Forms.Button
        Me._Command1_1 = New System.Windows.Forms.Button
        Me._Command1_0 = New System.Windows.Forms.Button
        Me._Combo_0 = New ComboBoxEx.ComboBoxExt
        Me._Combo_5 = New ComboBoxEx.ComboBoxExt
        Me._Combo_4 = New ComboBoxEx.ComboBoxExt
        Me._Combo_6 = New ComboBoxEx.ComboBoxExt
        Me._Combo_7 = New ComboBoxEx.ComboBoxExt
        Me.MedNgay = New System.Windows.Forms.MaskedTextBox
        Me._Label_34 = New System.Windows.Forms.Label
        Me._Label_33 = New System.Windows.Forms.Label
        Me._Label_32 = New System.Windows.Forms.Label
        Me._Label_31 = New System.Windows.Forms.Label
        Me._Label_28 = New System.Windows.Forms.Label
        Me._Label_27 = New System.Windows.Forms.Label
        Me._Label_26 = New System.Windows.Forms.Label
        Me._Label_22 = New System.Windows.Forms.Label
        Me._Label_21 = New System.Windows.Forms.Label
        Me._Label_16 = New System.Windows.Forms.Label
        Me._Label_11 = New System.Windows.Forms.Label
        Me._Label_10 = New System.Windows.Forms.Label
        Me._Label_9 = New System.Windows.Forms.Label
        Me._Label_13 = New System.Windows.Forms.Label
        Me._Label_12 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Label_18 = New System.Windows.Forms.Label
        Me._Label_19 = New System.Windows.Forms.Label
        Me._Label_20 = New System.Windows.Forms.Label
        Me._Label_29 = New System.Windows.Forms.Label
        Me._Label_30 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_24 = New System.Windows.Forms.Label
        Me._Label_25 = New System.Windows.Forms.Label
        Me._Label_23 = New System.Windows.Forms.Label
        Me._Label_14 = New System.Windows.Forms.Label
        Me._Label_15 = New System.Windows.Forms.Label
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Label_5 = New System.Windows.Forms.Label
        Me._Label_17 = New System.Windows.Forms.Label
        Me.Ctx_mnPU = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.MainMenu1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnPU})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(562, 24)
        Me.MainMenu1.TabIndex = 87
        '
        'mnPU
        '
        Me.mnPU.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._mnDD_0, Me._mnDD_1, Me._mnDD_2, Me._mnDD_3, Me._mnDD_4})
        Me.mnPU.Name = "mnPU"
        Me.mnPU.Size = New System.Drawing.Size(77, 20)
        Me.mnPU.Tag = "Lists"
        Me.mnPU.Text = "Danh điểm"
        '
        '_mnDD_0
        '
        Me._mnDD_0.Name = "_mnDD_0"
        Me._mnDD_0.Size = New System.Drawing.Size(184, 22)
        Me._mnDD_0.Tag = "Country List..."
        Me._mnDD_0.Text = "Nước sản xuất..."
        '
        '_mnDD_1
        '
        Me._mnDD_1.Name = "_mnDD_1"
        Me._mnDD_1.Size = New System.Drawing.Size(184, 22)
        Me._mnDD_1.Tag = "Conjucture List..."
        Me._mnDD_1.Text = "Tình trạng sử dụng..."
        '
        '_mnDD_2
        '
        Me._mnDD_2.Name = "_mnDD_2"
        Me._mnDD_2.Size = New System.Drawing.Size(184, 22)
        Me._mnDD_2.Tag = "Administrative Object List"
        Me._mnDD_2.Text = "Đối tượng quản lý"
        '
        '_mnDD_3
        '
        Me._mnDD_3.Name = "_mnDD_3"
        Me._mnDD_3.Size = New System.Drawing.Size(181, 6)
        '
        '_mnDD_4
        '
        Me._mnDD_4.Name = "_mnDD_4"
        Me._mnDD_4.Size = New System.Drawing.Size(184, 22)
        Me._mnDD_4.Tag = "Chart of Account"
        Me._mnDD_4.Text = "Hệ thống tài khoản"
        '
        '_Command_4
        '
        Me._Command_4.Image = Global.UNET.My.Resources.Resources.print16
        Me._Command_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_4.Location = New System.Drawing.Point(478, 168)
        Me._Command_4.Name = "_Command_4"
        Me._Command_4.Size = New System.Drawing.Size(81, 25)
        Me._Command_4.TabIndex = 39
        Me._Command_4.Text = "&In"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.tool16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(478, 104)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(81, 25)
        Me._Command_2.TabIndex = 37
        Me._Command_2.Text = "P. Tùng"
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.report16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(478, 136)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(81, 25)
        Me._Command_3.TabIndex = 38
        Me._Command_3.Text = "&Xem"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(478, 72)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(81, 25)
        Me._Command_1.TabIndex = 36
        Me._Command_1.Text = "Trở &về"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(478, 40)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(81, 25)
        Me._Command_0.TabIndex = 35
        Me._Command_0.Text = "&Ghi"
        '
        '_Text_19
        '
        Me._Text_19.AcceptsReturn = True
        Me._Text_19.BackColor = System.Drawing.SystemColors.Window
        Me._Text_19.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text_19.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Text_19.Location = New System.Drawing.Point(253, 9)
        Me._Text_19.MaxLength = 15
        Me._Text_19.Name = "_Text_19"
        Me._Text_19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text_19.Size = New System.Drawing.Size(89, 20)
        Me._Text_19.TabIndex = 4
        '
        'Chk
        '
        Me.Chk.BackColor = System.Drawing.Color.Transparent
        Me.Chk.Cursor = System.Windows.Forms.Cursors.Default
        Me.Chk.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk.Location = New System.Drawing.Point(277, 107)
        Me.Chk.Name = "Chk"
        Me.Chk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Chk.Size = New System.Drawing.Size(185, 17)
        Me.Chk.TabIndex = 25
        Me.Chk.Tag = "Depreciate FROM month after increasing"
        Me.Chk.Text = "Trích khấu hao từ tháng tiếp theo"
        Me.Chk.UseVisualStyleBackColor = False
        Me.Chk.Visible = False
        '
        '_Text_18
        '
        Me._Text_18.AcceptsReturn = True
        Me._Text_18.BackColor = System.Drawing.SystemColors.Window
        Me._Text_18.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text_18.ForeColor = System.Drawing.Color.Navy
        Me._Text_18.Location = New System.Drawing.Point(173, 103)
        Me._Text_18.MaxLength = 5
        Me._Text_18.Multiline = True
        Me._Text_18.Name = "_Text_18"
        Me._Text_18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text_18.Size = New System.Drawing.Size(33, 21)
        Me._Text_18.TabIndex = 24
        Me._Text_18.Text = "5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._Text_18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Text_14
        '
        Me._Text_14.AcceptsReturn = True
        Me._Text_14.BackColor = System.Drawing.SystemColors.Window
        Me._Text_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text_14.ForeColor = System.Drawing.Color.Navy
        Me._Text_14.Location = New System.Drawing.Point(487, 440)
        Me._Text_14.MaxLength = 15
        Me._Text_14.Multiline = True
        Me._Text_14.Name = "_Text_14"
        Me._Text_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text_14.Size = New System.Drawing.Size(65, 21)
        Me._Text_14.TabIndex = 26
        Me._Text_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._Text_14.Visible = False
        '
        '_Text_13
        '
        Me._Text_13.AcceptsReturn = True
        Me._Text_13.BackColor = System.Drawing.SystemColors.Window
        Me._Text_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text_13.ForeColor = System.Drawing.Color.Navy
        Me._Text_13.Location = New System.Drawing.Point(489, 372)
        Me._Text_13.MaxLength = 15
        Me._Text_13.Multiline = True
        Me._Text_13.Name = "_Text_13"
        Me._Text_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text_13.Size = New System.Drawing.Size(49, 21)
        Me._Text_13.TabIndex = 23
        Me._Text_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._Text_13.Visible = False
        '
        '_Text_12
        '
        Me._Text_12.AcceptsReturn = True
        Me._Text_12.BackColor = System.Drawing.SystemColors.Window
        Me._Text_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text_12.ForeColor = System.Drawing.Color.Navy
        Me._Text_12.Location = New System.Drawing.Point(489, 372)
        Me._Text_12.MaxLength = 15
        Me._Text_12.Multiline = True
        Me._Text_12.Name = "_Text_12"
        Me._Text_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text_12.Size = New System.Drawing.Size(65, 21)
        Me._Text_12.TabIndex = 22
        Me._Text_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._Text_12.Visible = False
        '
        '_Text_11
        '
        Me._Text_11.AcceptsReturn = True
        Me._Text_11.BackColor = System.Drawing.SystemColors.Window
        Me._Text_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text_11.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Text_11.Location = New System.Drawing.Point(317, 55)
        Me._Text_11.MaxLength = 15
        Me._Text_11.Multiline = True
        Me._Text_11.Name = "_Text_11"
        Me._Text_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text_11.Size = New System.Drawing.Size(145, 21)
        Me._Text_11.TabIndex = 21
        Me._Text_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Text_10
        '
        Me._Text_10.AcceptsReturn = True
        Me._Text_10.BackColor = System.Drawing.SystemColors.Window
        Me._Text_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text_10.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Text_10.Location = New System.Drawing.Point(487, 372)
        Me._Text_10.MaxLength = 15
        Me._Text_10.Multiline = True
        Me._Text_10.Name = "_Text_10"
        Me._Text_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text_10.Size = New System.Drawing.Size(65, 21)
        Me._Text_10.TabIndex = 20
        Me._Text_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._Text_10.Visible = False
        '
        '_Text_9
        '
        Me._Text_9.AcceptsReturn = True
        Me._Text_9.BackColor = System.Drawing.SystemColors.Window
        Me._Text_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Text_9.Location = New System.Drawing.Point(489, 348)
        Me._Text_9.MaxLength = 15
        Me._Text_9.Multiline = True
        Me._Text_9.Name = "_Text_9"
        Me._Text_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text_9.Size = New System.Drawing.Size(49, 21)
        Me._Text_9.TabIndex = 19
        Me._Text_9.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._Text_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._Text_9.Visible = False
        '
        '_Text_8
        '
        Me._Text_8.AcceptsReturn = True
        Me._Text_8.BackColor = System.Drawing.SystemColors.Window
        Me._Text_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Text_8.Location = New System.Drawing.Point(489, 348)
        Me._Text_8.MaxLength = 15
        Me._Text_8.Multiline = True
        Me._Text_8.Name = "_Text_8"
        Me._Text_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text_8.Size = New System.Drawing.Size(65, 21)
        Me._Text_8.TabIndex = 18
        Me._Text_8.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._Text_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._Text_8.Visible = False
        '
        '_Text_7
        '
        Me._Text_7.AcceptsReturn = True
        Me._Text_7.BackColor = System.Drawing.SystemColors.Window
        Me._Text_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Text_7.Location = New System.Drawing.Point(317, 31)
        Me._Text_7.MaxLength = 15
        Me._Text_7.Multiline = True
        Me._Text_7.Name = "_Text_7"
        Me._Text_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text_7.Size = New System.Drawing.Size(145, 21)
        Me._Text_7.TabIndex = 17
        Me._Text_7.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._Text_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Text_6
        '
        Me._Text_6.AcceptsReturn = True
        Me._Text_6.BackColor = System.Drawing.SystemColors.Window
        Me._Text_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Text_6.Location = New System.Drawing.Point(487, 348)
        Me._Text_6.MaxLength = 15
        Me._Text_6.Multiline = True
        Me._Text_6.Name = "_Text_6"
        Me._Text_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text_6.Size = New System.Drawing.Size(65, 21)
        Me._Text_6.TabIndex = 16
        Me._Text_6.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._Text_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._Text_6.Visible = False
        '
        '_Text_15
        '
        Me._Text_15.AcceptsReturn = True
        Me._Text_15.BackColor = System.Drawing.SystemColors.Window
        Me._Text_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text_15.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Text_15.Location = New System.Drawing.Point(317, 126)
        Me._Text_15.MaxLength = 15
        Me._Text_15.Multiline = True
        Me._Text_15.Name = "_Text_15"
        Me._Text_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text_15.Size = New System.Drawing.Size(145, 21)
        Me._Text_15.TabIndex = 27
        Me._Text_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Text_16
        '
        Me._Text_16.AcceptsReturn = True
        Me._Text_16.BackColor = System.Drawing.SystemColors.Window
        Me._Text_16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text_16.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Text_16.Location = New System.Drawing.Point(489, 443)
        Me._Text_16.MaxLength = 15
        Me._Text_16.Multiline = True
        Me._Text_16.Name = "_Text_16"
        Me._Text_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text_16.Size = New System.Drawing.Size(65, 21)
        Me._Text_16.TabIndex = 28
        Me._Text_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._Text_16.Visible = False
        '
        '_Text_17
        '
        Me._Text_17.AcceptsReturn = True
        Me._Text_17.BackColor = System.Drawing.SystemColors.Window
        Me._Text_17.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text_17.ForeColor = System.Drawing.Color.Navy
        Me._Text_17.Location = New System.Drawing.Point(489, 443)
        Me._Text_17.MaxLength = 15
        Me._Text_17.Multiline = True
        Me._Text_17.Name = "_Text_17"
        Me._Text_17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text_17.Size = New System.Drawing.Size(49, 21)
        Me._Text_17.TabIndex = 29
        Me._Text_17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._Text_17.Visible = False
        '
        '_Text_3
        '
        Me._Text_3.AcceptsReturn = True
        Me._Text_3.BackColor = System.Drawing.SystemColors.Window
        Me._Text_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Text_3.Location = New System.Drawing.Point(93, 81)
        Me._Text_3.MaxLength = 4
        Me._Text_3.Name = "_Text_3"
        Me._Text_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text_3.Size = New System.Drawing.Size(41, 20)
        Me._Text_3.TabIndex = 8
        '
        '_Text_2
        '
        Me._Text_2.AcceptsReturn = True
        Me._Text_2.BackColor = System.Drawing.SystemColors.Window
        Me._Text_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Text_2.Location = New System.Drawing.Point(93, 57)
        Me._Text_2.MaxLength = 50
        Me._Text_2.Name = "_Text_2"
        Me._Text_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text_2.Size = New System.Drawing.Size(369, 20)
        Me._Text_2.TabIndex = 7
        '
        '_Text_1
        '
        Me._Text_1.AcceptsReturn = True
        Me._Text_1.BackColor = System.Drawing.SystemColors.Window
        Me._Text_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Text_1.Location = New System.Drawing.Point(93, 33)
        Me._Text_1.MaxLength = 50
        Me._Text_1.Name = "_Text_1"
        Me._Text_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text_1.Size = New System.Drawing.Size(369, 20)
        Me._Text_1.TabIndex = 6
        '
        '_Text_0
        '
        Me._Text_0.AcceptsReturn = True
        Me._Text_0.BackColor = System.Drawing.SystemColors.Window
        Me._Text_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Text_0.Location = New System.Drawing.Point(93, 9)
        Me._Text_0.MaxLength = 15
        Me._Text_0.Name = "_Text_0"
        Me._Text_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text_0.Size = New System.Drawing.Size(89, 20)
        Me._Text_0.TabIndex = 3
        '
        '_Text_4
        '
        Me._Text_4.AcceptsReturn = True
        Me._Text_4.BackColor = System.Drawing.SystemColors.Window
        Me._Text_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Text_4.Location = New System.Drawing.Point(253, 81)
        Me._Text_4.MaxLength = 4
        Me._Text_4.Name = "_Text_4"
        Me._Text_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text_4.Size = New System.Drawing.Size(41, 20)
        Me._Text_4.TabIndex = 9
        '
        '_Text_5
        '
        Me._Text_5.AcceptsReturn = True
        Me._Text_5.BackColor = System.Drawing.SystemColors.Window
        Me._Text_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Text_5.Location = New System.Drawing.Point(93, 113)
        Me._Text_5.MaxLength = 50
        Me._Text_5.Name = "_Text_5"
        Me._Text_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text_5.Size = New System.Drawing.Size(369, 20)
        Me._Text_5.TabIndex = 11
        '
        '_Combo_1
        '
        Me._Combo_1.BackColor = System.Drawing.SystemColors.Window
        Me._Combo_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Combo_1.Location = New System.Drawing.Point(93, 15)
        Me._Combo_1.Name = "_Combo_1"
        Me._Combo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Combo_1.Size = New System.Drawing.Size(369, 21)
        Me._Combo_1.TabIndex = 0
        '
        '_Combo_2
        '
        Me._Combo_2.BackColor = System.Drawing.SystemColors.Window
        Me._Combo_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Combo_2.Location = New System.Drawing.Point(93, 38)
        Me._Combo_2.Name = "_Combo_2"
        Me._Combo_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Combo_2.Size = New System.Drawing.Size(369, 21)
        Me._Combo_2.TabIndex = 1
        '
        '_Combo_3
        '
        Me._Combo_3.BackColor = System.Drawing.SystemColors.Window
        Me._Combo_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Combo_3.Location = New System.Drawing.Point(93, 61)
        Me._Combo_3.Name = "_Combo_3"
        Me._Combo_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Combo_3.Size = New System.Drawing.Size(369, 21)
        Me._Combo_3.TabIndex = 2
        '
        '_Command1_4
        '
        Me._Command1_4.BackColor = System.Drawing.Color.Silver
        Me._Command1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_4.Image = CType(resources.GetObject("_Command1_4.Image"), System.Drawing.Image)
        Me._Command1_4.Location = New System.Drawing.Point(478, 168)
        Me._Command1_4.Name = "_Command1_4"
        Me._Command1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Command1_4.Size = New System.Drawing.Size(81, 25)
        Me._Command1_4.TabIndex = 44
        Me._Command1_4.TabStop = False
        Me._Command1_4.Tag = "&Print"
        Me._Command1_4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_4.UseVisualStyleBackColor = False
        Me._Command1_4.Visible = False
        '
        '_Command1_3
        '
        Me._Command1_3.BackColor = System.Drawing.Color.Silver
        Me._Command1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_3.Image = CType(resources.GetObject("_Command1_3.Image"), System.Drawing.Image)
        Me._Command1_3.Location = New System.Drawing.Point(478, 136)
        Me._Command1_3.Name = "_Command1_3"
        Me._Command1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Command1_3.Size = New System.Drawing.Size(81, 25)
        Me._Command1_3.TabIndex = 43
        Me._Command1_3.TabStop = False
        Me._Command1_3.Tag = "&View"
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
        Me._Command1_2.Location = New System.Drawing.Point(478, 104)
        Me._Command1_2.Name = "_Command1_2"
        Me._Command1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Command1_2.Size = New System.Drawing.Size(81, 25)
        Me._Command1_2.TabIndex = 42
        Me._Command1_2.TabStop = False
        Me._Command1_2.Tag = "&Equipment"
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
        Me._Command1_1.Location = New System.Drawing.Point(478, 72)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Command1_1.Size = New System.Drawing.Size(81, 25)
        Me._Command1_1.TabIndex = 41
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
        Me._Command1_0.Location = New System.Drawing.Point(478, 40)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Command1_0.Size = New System.Drawing.Size(81, 25)
        Me._Command1_0.TabIndex = 40
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&Save"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        '_Combo_0
        '
        Me._Combo_0.BackColor = System.Drawing.SystemColors.Window
        Me._Combo_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Combo_0.Location = New System.Drawing.Point(93, 145)
        Me._Combo_0.Name = "_Combo_0"
        Me._Combo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Combo_0.Size = New System.Drawing.Size(145, 21)
        Me._Combo_0.TabIndex = 12
        '
        '_Combo_5
        '
        Me._Combo_5.BackColor = System.Drawing.SystemColors.Window
        Me._Combo_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Combo_5.Location = New System.Drawing.Point(317, 177)
        Me._Combo_5.Name = "_Combo_5"
        Me._Combo_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Combo_5.Size = New System.Drawing.Size(145, 21)
        Me._Combo_5.TabIndex = 15
        '
        '_Combo_4
        '
        Me._Combo_4.BackColor = System.Drawing.SystemColors.Window
        Me._Combo_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Combo_4.Location = New System.Drawing.Point(317, 145)
        Me._Combo_4.Name = "_Combo_4"
        Me._Combo_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Combo_4.Size = New System.Drawing.Size(145, 21)
        Me._Combo_4.TabIndex = 14
        '
        '_Combo_6
        '
        Me._Combo_6.BackColor = System.Drawing.SystemColors.Window
        Me._Combo_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Combo_6.Location = New System.Drawing.Point(93, 177)
        Me._Combo_6.Name = "_Combo_6"
        Me._Combo_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Combo_6.Size = New System.Drawing.Size(145, 21)
        Me._Combo_6.TabIndex = 13
        '
        '_Combo_7
        '
        Me._Combo_7.BackColor = System.Drawing.SystemColors.Window
        Me._Combo_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_7.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Combo_7.Location = New System.Drawing.Point(389, 81)
        Me._Combo_7.Name = "_Combo_7"
        Me._Combo_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Combo_7.Size = New System.Drawing.Size(73, 21)
        Me._Combo_7.TabIndex = 10
        '
        'MedNgay
        '
        Me.MedNgay.AllowPromptAsInput = False
        Me.MedNgay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedNgay.Location = New System.Drawing.Point(405, 9)
        Me.MedNgay.Name = "MedNgay"
        Me.MedNgay.Size = New System.Drawing.Size(57, 20)
        Me.MedNgay.TabIndex = 5
        '
        '_Label_34
        '
        Me._Label_34.BackColor = System.Drawing.Color.Transparent
        Me._Label_34.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_34.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_34.Location = New System.Drawing.Point(349, 10)
        Me._Label_34.Name = "_Label_34"
        Me._Label_34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_34.Size = New System.Drawing.Size(49, 17)
        Me._Label_34.TabIndex = 74
        Me._Label_34.Tag = "Code"
        Me._Label_34.Text = "Ngày CT"
        Me._Label_34.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_33
        '
        Me._Label_33.BackColor = System.Drawing.Color.Transparent
        Me._Label_33.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_33.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_33.Location = New System.Drawing.Point(184, 10)
        Me._Label_33.Name = "_Label_33"
        Me._Label_33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_33.Size = New System.Drawing.Size(65, 17)
        Me._Label_33.TabIndex = 73
        Me._Label_33.Tag = "Code"
        Me._Label_33.Text = "Số CT tăng"
        Me._Label_33.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_32
        '
        Me._Label_32.BackColor = System.Drawing.Color.Transparent
        Me._Label_32.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_32.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_32.Location = New System.Drawing.Point(213, 107)
        Me._Label_32.Name = "_Label_32"
        Me._Label_32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_32.Size = New System.Drawing.Size(27, 17)
        Me._Label_32.TabIndex = 72
        Me._Label_32.Tag = "Year(s)"
        Me._Label_32.Text = "năm"
        '
        '_Label_31
        '
        Me._Label_31.BackColor = System.Drawing.Color.Transparent
        Me._Label_31.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_31.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_31.Location = New System.Drawing.Point(23, 105)
        Me._Label_31.Name = "_Label_31"
        Me._Label_31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_31.Size = New System.Drawing.Size(86, 17)
        Me._Label_31.TabIndex = 71
        Me._Label_31.Tag = "Year of Depreciation"
        Me._Label_31.Text = "Số năm tính KH"
        Me._Label_31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_28
        '
        Me._Label_28.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me._Label_28.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_28.ForeColor = System.Drawing.Color.Black
        Me._Label_28.Location = New System.Drawing.Point(489, 398)
        Me._Label_28.Name = "_Label_28"
        Me._Label_28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_28.Size = New System.Drawing.Size(59, 17)
        Me._Label_28.TabIndex = 70
        Me._Label_28.Text = "0,0"
        Me._Label_28.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me._Label_28.Visible = False
        '
        '_Label_27
        '
        Me._Label_27.BackColor = System.Drawing.Color.Transparent
        Me._Label_27.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_27.ForeColor = System.Drawing.Color.Black
        Me._Label_27.Location = New System.Drawing.Point(317, 83)
        Me._Label_27.Name = "_Label_27"
        Me._Label_27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_27.Size = New System.Drawing.Size(145, 17)
        Me._Label_27.TabIndex = 69
        Me._Label_27.Text = "0,0"
        Me._Label_27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_26
        '
        Me._Label_26.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me._Label_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_26.ForeColor = System.Drawing.Color.Black
        Me._Label_26.Location = New System.Drawing.Point(487, 398)
        Me._Label_26.Name = "_Label_26"
        Me._Label_26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_26.Size = New System.Drawing.Size(59, 17)
        Me._Label_26.TabIndex = 68
        Me._Label_26.Text = "0,0"
        Me._Label_26.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me._Label_26.Visible = False
        '
        '_Label_22
        '
        Me._Label_22.BackColor = System.Drawing.Color.Transparent
        Me._Label_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_22.ForeColor = System.Drawing.Color.Navy
        Me._Label_22.Location = New System.Drawing.Point(120, 129)
        Me._Label_22.Name = "_Label_22"
        Me._Label_22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_22.Size = New System.Drawing.Size(113, 17)
        Me._Label_22.TabIndex = 67
        Me._Label_22.Text = "0,0"
        Me._Label_22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_21
        '
        Me._Label_21.BackColor = System.Drawing.Color.Transparent
        Me._Label_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_21.ForeColor = System.Drawing.Color.Black
        Me._Label_21.Location = New System.Drawing.Point(120, 81)
        Me._Label_21.Name = "_Label_21"
        Me._Label_21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_21.Size = New System.Drawing.Size(113, 17)
        Me._Label_21.TabIndex = 66
        Me._Label_21.Text = "0,0"
        Me._Label_21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_16
        '
        Me._Label_16.BackColor = System.Drawing.Color.Transparent
        Me._Label_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_16.ForeColor = System.Drawing.Color.Black
        Me._Label_16.Location = New System.Drawing.Point(5, 131)
        Me._Label_16.Name = "_Label_16"
        Me._Label_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_16.Size = New System.Drawing.Size(114, 17)
        Me._Label_16.TabIndex = 65
        Me._Label_16.Tag = "Monthly Depreciattion:"
        Me._Label_16.Text = "Hao mòn trong tháng :"
        Me._Label_16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_11.Location = New System.Drawing.Point(489, 328)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_11.Size = New System.Drawing.Size(65, 17)
        Me._Label_11.TabIndex = 64
        Me._Label_11.Tag = "Other"
        Me._Label_11.Text = "Nguồn khác"
        Me._Label_11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_11.Visible = False
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.Transparent
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_10.Location = New System.Drawing.Point(317, 11)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_10.Size = New System.Drawing.Size(145, 17)
        Me._Label_10.TabIndex = 63
        Me._Label_10.Tag = "Capital"
        Me._Label_10.Text = "Tự bổ sung"
        Me._Label_10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_9
        '
        Me._Label_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_9.Location = New System.Drawing.Point(487, 328)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_9.Size = New System.Drawing.Size(57, 17)
        Me._Label_9.TabIndex = 62
        Me._Label_9.Tag = "Budget"
        Me._Label_9.Text = "Ngân sách"
        Me._Label_9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_9.Visible = False
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.Transparent
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_13.Location = New System.Drawing.Point(26, 81)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_13.Size = New System.Drawing.Size(86, 17)
        Me._Label_13.TabIndex = 61
        Me._Label_13.Tag = "Residual Value:"
        Me._Label_13.Text = "Giá trị còn lại :"
        Me._Label_13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_12
        '
        Me._Label_12.BackColor = System.Drawing.Color.Transparent
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_12.Location = New System.Drawing.Point(18, 57)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_12.Size = New System.Drawing.Size(94, 17)
        Me._Label_12.TabIndex = 60
        Me._Label_12.Tag = "Depreciation:"
        Me._Label_12.Text = "Hao mòn :"
        Me._Label_12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.Transparent
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_8.Location = New System.Drawing.Point(18, 33)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_8.Size = New System.Drawing.Size(94, 17)
        Me._Label_8.TabIndex = 59
        Me._Label_8.Tag = "Original Cost:"
        Me._Label_8.Text = "Nguyên giá :"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_18
        '
        Me._Label_18.BackColor = System.Drawing.Color.Transparent
        Me._Label_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_18.Location = New System.Drawing.Point(176, 11)
        Me._Label_18.Name = "_Label_18"
        Me._Label_18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_18.Size = New System.Drawing.Size(49, 17)
        Me._Label_18.TabIndex = 58
        Me._Label_18.Tag = "Total"
        Me._Label_18.Text = "Tổng số"
        Me._Label_18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_19
        '
        Me._Label_19.BackColor = System.Drawing.Color.Transparent
        Me._Label_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_19.ForeColor = System.Drawing.Color.Black
        Me._Label_19.Location = New System.Drawing.Point(120, 33)
        Me._Label_19.Name = "_Label_19"
        Me._Label_19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_19.Size = New System.Drawing.Size(113, 17)
        Me._Label_19.TabIndex = 57
        Me._Label_19.Text = "0,0"
        Me._Label_19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_20
        '
        Me._Label_20.BackColor = System.Drawing.Color.Transparent
        Me._Label_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_20.ForeColor = System.Drawing.Color.Black
        Me._Label_20.Location = New System.Drawing.Point(120, 57)
        Me._Label_20.Name = "_Label_20"
        Me._Label_20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_20.Size = New System.Drawing.Size(113, 17)
        Me._Label_20.TabIndex = 56
        Me._Label_20.Text = "0,0"
        Me._Label_20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_29
        '
        Me._Label_29.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me._Label_29.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_29.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_29.Location = New System.Drawing.Point(489, 328)
        Me._Label_29.Name = "_Label_29"
        Me._Label_29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_29.Size = New System.Drawing.Size(51, 17)
        Me._Label_29.TabIndex = 55
        Me._Label_29.Tag = "Credit"
        Me._Label_29.Text = "Tín dụng"
        Me._Label_29.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_29.Visible = False
        '
        '_Label_30
        '
        Me._Label_30.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me._Label_30.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_30.ForeColor = System.Drawing.Color.Black
        Me._Label_30.Location = New System.Drawing.Point(489, 398)
        Me._Label_30.Name = "_Label_30"
        Me._Label_30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_30.Size = New System.Drawing.Size(49, 17)
        Me._Label_30.TabIndex = 54
        Me._Label_30.Text = "0,0"
        Me._Label_30.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me._Label_30.Visible = False
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.Transparent
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_3.Location = New System.Drawing.Point(37, 113)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_3.Size = New System.Drawing.Size(49, 17)
        Me._Label_3.TabIndex = 53
        Me._Label_3.Tag = "Notes"
        Me._Label_3.Text = "Ghi chú :"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.Transparent
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(21, 58)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_2.Size = New System.Drawing.Size(65, 17)
        Me._Label_2.TabIndex = 52
        Me._Label_2.Tag = "Ability"
        Me._Label_2.Text = "Năng lực :"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(21, 34)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_1.Size = New System.Drawing.Size(65, 17)
        Me._Label_1.TabIndex = 51
        Me._Label_1.Tag = "Description"
        Me._Label_1.Text = "Tên :"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(21, 12)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_0.Size = New System.Drawing.Size(65, 17)
        Me._Label_0.TabIndex = 50
        Me._Label_0.Tag = "Code"
        Me._Label_0.Text = "Số hiệu :"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_24
        '
        Me._Label_24.BackColor = System.Drawing.Color.Transparent
        Me._Label_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_24.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_24.Location = New System.Drawing.Point(13, 83)
        Me._Label_24.Name = "_Label_24"
        Me._Label_24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_24.Size = New System.Drawing.Size(73, 17)
        Me._Label_24.TabIndex = 49
        Me._Label_24.Tag = "Pro. Year"
        Me._Label_24.Text = "Năm sản xuất :"
        Me._Label_24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_25
        '
        Me._Label_25.BackColor = System.Drawing.Color.Transparent
        Me._Label_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_25.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_25.Location = New System.Drawing.Point(173, 83)
        Me._Label_25.Name = "_Label_25"
        Me._Label_25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_25.Size = New System.Drawing.Size(73, 17)
        Me._Label_25.TabIndex = 48
        Me._Label_25.Tag = "Usage Year"
        Me._Label_25.Text = "Năm sử dụng :"
        Me._Label_25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_23
        '
        Me._Label_23.BackColor = System.Drawing.Color.Transparent
        Me._Label_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_23.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_23.Location = New System.Drawing.Point(9, 15)
        Me._Label_23.Name = "_Label_23"
        Me._Label_23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_23.Size = New System.Drawing.Size(71, 17)
        Me._Label_23.TabIndex = 47
        Me._Label_23.Tag = "Account"
        Me._Label_23.Text = "Tài khoản :"
        Me._Label_23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.Color.Transparent
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_14.Location = New System.Drawing.Point(9, 38)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_14.Size = New System.Drawing.Size(71, 17)
        Me._Label_14.TabIndex = 46
        Me._Label_14.Tag = "Class"
        Me._Label_14.Text = "Loại :"
        Me._Label_14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_15
        '
        Me._Label_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_15.Location = New System.Drawing.Point(8, 65)
        Me._Label_15.Name = "_Label_15"
        Me._Label_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_15.Size = New System.Drawing.Size(72, 17)
        Me._Label_15.TabIndex = 45
        Me._Label_15.Tag = "Group"
        Me._Label_15.Text = "Nhóm :"
        Me._Label_15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.Transparent
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_4.Location = New System.Drawing.Point(5, 145)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_4.Size = New System.Drawing.Size(81, 17)
        Me._Label_4.TabIndex = 34
        Me._Label_4.Tag = "Made in"
        Me._Label_4.Text = "Nước sản xuất :"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.Transparent
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_7.Location = New System.Drawing.Point(29, 177)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_7.Size = New System.Drawing.Size(57, 17)
        Me._Label_7.TabIndex = 33
        Me._Label_7.Tag = "State"
        Me._Label_7.Text = "Tình trạng :"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.Transparent
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_6.Location = New System.Drawing.Point(245, 145)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_6.Size = New System.Drawing.Size(65, 17)
        Me._Label_6.TabIndex = 32
        Me._Label_6.Tag = "Managed by"
        Me._Label_6.Text = "Quản lý :"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.Transparent
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_5.Location = New System.Drawing.Point(245, 177)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_5.Size = New System.Drawing.Size(65, 17)
        Me._Label_5.TabIndex = 31
        Me._Label_5.Tag = "Used by"
        Me._Label_5.Text = "Sử dụng :"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.Color.Transparent
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_17.Location = New System.Drawing.Point(341, 83)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_17.Size = New System.Drawing.Size(41, 17)
        Me._Label_17.TabIndex = 30
        Me._Label_17.Tag = "Month"
        Me._Label_17.Text = "Tháng :"
        Me._Label_17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Ctx_mnPU
        '
        Me.Ctx_mnPU.Name = "Ctx_mnPU"
        Me.Ctx_mnPU.Size = New System.Drawing.Size(61, 4)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me._Combo_1)
        Me.GroupBox1.Controls.Add(Me._Label_15)
        Me.GroupBox1.Controls.Add(Me._Label_14)
        Me.GroupBox1.Controls.Add(Me._Label_23)
        Me.GroupBox1.Controls.Add(Me._Combo_3)
        Me.GroupBox1.Controls.Add(Me._Combo_2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 89)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me._Text_1)
        Me.GroupBox2.Controls.Add(Me._Label_17)
        Me.GroupBox2.Controls.Add(Me._Text_19)
        Me.GroupBox2.Controls.Add(Me._Label_5)
        Me.GroupBox2.Controls.Add(Me._Label_6)
        Me.GroupBox2.Controls.Add(Me._Label_7)
        Me.GroupBox2.Controls.Add(Me._Label_4)
        Me.GroupBox2.Controls.Add(Me._Label_25)
        Me.GroupBox2.Controls.Add(Me._Label_0)
        Me.GroupBox2.Controls.Add(Me._Label_24)
        Me.GroupBox2.Controls.Add(Me._Label_1)
        Me.GroupBox2.Controls.Add(Me._Label_2)
        Me.GroupBox2.Controls.Add(Me._Label_3)
        Me.GroupBox2.Controls.Add(Me._Label_33)
        Me.GroupBox2.Controls.Add(Me._Label_34)
        Me.GroupBox2.Controls.Add(Me.MedNgay)
        Me.GroupBox2.Controls.Add(Me._Combo_7)
        Me.GroupBox2.Controls.Add(Me._Combo_6)
        Me.GroupBox2.Controls.Add(Me._Combo_4)
        Me.GroupBox2.Controls.Add(Me._Combo_5)
        Me.GroupBox2.Controls.Add(Me._Combo_0)
        Me.GroupBox2.Controls.Add(Me._Text_5)
        Me.GroupBox2.Controls.Add(Me._Text_4)
        Me.GroupBox2.Controls.Add(Me._Text_0)
        Me.GroupBox2.Controls.Add(Me._Text_3)
        Me.GroupBox2.Controls.Add(Me._Text_2)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(469, 204)
        Me.GroupBox2.TabIndex = 89
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me._Text_7)
        Me.GroupBox3.Controls.Add(Me.Chk)
        Me.GroupBox3.Controls.Add(Me._Label_20)
        Me.GroupBox3.Controls.Add(Me._Label_19)
        Me.GroupBox3.Controls.Add(Me._Label_18)
        Me.GroupBox3.Controls.Add(Me._Label_8)
        Me.GroupBox3.Controls.Add(Me._Text_18)
        Me.GroupBox3.Controls.Add(Me._Label_12)
        Me.GroupBox3.Controls.Add(Me._Label_13)
        Me.GroupBox3.Controls.Add(Me._Label_10)
        Me.GroupBox3.Controls.Add(Me._Label_16)
        Me.GroupBox3.Controls.Add(Me._Label_21)
        Me.GroupBox3.Controls.Add(Me._Label_22)
        Me.GroupBox3.Controls.Add(Me._Label_27)
        Me.GroupBox3.Controls.Add(Me._Text_11)
        Me.GroupBox3.Controls.Add(Me._Label_31)
        Me.GroupBox3.Controls.Add(Me._Label_32)
        Me.GroupBox3.Controls.Add(Me._Text_15)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 317)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(469, 162)
        Me.GroupBox3.TabIndex = 90
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = " "
        '
        'frmTaiSan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(562, 480)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me._Text_14)
        Me.Controls.Add(Me._Command_4)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Text_13)
        Me.Controls.Add(Me._Command1_4)
        Me.Controls.Add(Me._Text_12)
        Me.Controls.Add(Me._Text_10)
        Me.Controls.Add(Me._Text_9)
        Me.Controls.Add(Me._Text_8)
        Me.Controls.Add(Me._Text_6)
        Me.Controls.Add(Me._Text_16)
        Me.Controls.Add(Me._Text_17)
        Me.Controls.Add(Me._Command1_3)
        Me.Controls.Add(Me._Label_11)
        Me.Controls.Add(Me._Command1_2)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me._Label_28)
        Me.Controls.Add(Me._Label_26)
        Me.Controls.Add(Me.MainMenu1)
        Me.Controls.Add(Me._Label_9)
        Me.Controls.Add(Me._Label_30)
        Me.Controls.Add(Me._Label_29)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(14, 34)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTaiSan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Tài sản"
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializemnDD()
		Me.mnDD(0) = _mnDD_0
		Me.mnDD(1) = _mnDD_1
		Me.mnDD(2) = _mnDD_2
        'Me.mnDD(3) = _mnDD_3
		Me.mnDD(4) = _mnDD_4
	End Sub
	Sub InitializeText_Renamed()
		Me.Text_Renamed(19) = _Text_19
		Me.Text_Renamed(18) = _Text_18
		Me.Text_Renamed(14) = _Text_14
		Me.Text_Renamed(13) = _Text_13
		Me.Text_Renamed(12) = _Text_12
		Me.Text_Renamed(11) = _Text_11
		Me.Text_Renamed(10) = _Text_10
		Me.Text_Renamed(9) = _Text_9
		Me.Text_Renamed(8) = _Text_8
		Me.Text_Renamed(7) = _Text_7
		Me.Text_Renamed(6) = _Text_6
		Me.Text_Renamed(15) = _Text_15
		Me.Text_Renamed(16) = _Text_16
		Me.Text_Renamed(17) = _Text_17
		Me.Text_Renamed(3) = _Text_3
		Me.Text_Renamed(2) = _Text_2
		Me.Text_Renamed(1) = _Text_1
		Me.Text_Renamed(0) = _Text_0
		Me.Text_Renamed(4) = _Text_4
		Me.Text_Renamed(5) = _Text_5
	End Sub
	
	Sub InitializeLabel()
		Me.Label(34) = _Label_34
		Me.Label(33) = _Label_33
		Me.Label(32) = _Label_32
		Me.Label(31) = _Label_31
		Me.Label(28) = _Label_28
		Me.Label(27) = _Label_27
		Me.Label(26) = _Label_26
		Me.Label(22) = _Label_22
		Me.Label(21) = _Label_21
		Me.Label(16) = _Label_16
		Me.Label(11) = _Label_11
		Me.Label(10) = _Label_10
		Me.Label(9) = _Label_9
		Me.Label(13) = _Label_13
		Me.Label(12) = _Label_12
		Me.Label(8) = _Label_8
		Me.Label(18) = _Label_18
		Me.Label(19) = _Label_19
		Me.Label(20) = _Label_20
		Me.Label(29) = _Label_29
		Me.Label(30) = _Label_30
		Me.Label(3) = _Label_3
		Me.Label(2) = _Label_2
		Me.Label(1) = _Label_1
		Me.Label(0) = _Label_0
		Me.Label(24) = _Label_24
		Me.Label(25) = _Label_25
		Me.Label(23) = _Label_23
		Me.Label(14) = _Label_14
		Me.Label(15) = _Label_15
		Me.Label(4) = _Label_4
		Me.Label(7) = _Label_7
		Me.Label(6) = _Label_6
		Me.Label(5) = _Label_5
		Me.Label(17) = _Label_17
	End Sub
	Sub InitializeCommand1()
		Me.Command1(4) = _Command1_4
		Me.Command1(3) = _Command1_3
		Me.Command1(2) = _Command1_2
		Me.Command1(1) = _Command1_1
		Me.Command1(0) = _Command1_0
	End Sub
	Sub InitializeCommand()
		Me.Command(4) = _Command_4
		Me.Command(2) = _Command_2
		Me.Command(3) = _Command_3
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
	Sub InitializeCombo()
		Me.Combo(1) = _Combo_1
		Me.Combo(2) = _Combo_2
		Me.Combo(3) = _Combo_3
		Me.Combo(0) = _Combo_0
		Me.Combo(5) = _Combo_5
		Me.Combo(4) = _Combo_4
		Me.Combo(6) = _Combo_6
		Me.Combo(7) = _Combo_7
    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
#End Region 
End Class
