<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FVAT
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeT()
		InitializeLabel1()
		InitializeChkV()
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
    Private WithEvents _T_20 As System.Windows.Forms.TextBox
    Private WithEvents _T_14 As System.Windows.Forms.TextBox
    Private WithEvents _T_19 As System.Windows.Forms.TextBox
    Private WithEvents _T_18 As System.Windows.Forms.TextBox
    Private WithEvents _T_17 As System.Windows.Forms.TextBox
    Private WithEvents _T_16 As System.Windows.Forms.TextBox
    Private WithEvents _T_11 As System.Windows.Forms.TextBox
    Private WithEvents _T_12 As System.Windows.Forms.TextBox
    Private WithEvents _T_4 As System.Windows.Forms.TextBox
    Private WithEvents _ChkV_6 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkV_7 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkV_4 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkV_3 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkV_2 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkV_0 As System.Windows.Forms.CheckBox
    Private WithEvents _Label1_20 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Command As System.Windows.Forms.Button
    Private WithEvents _T_9 As System.Windows.Forms.TextBox
    Private WithEvents _T_8 As System.Windows.Forms.TextBox
    Private WithEvents _T_7 As System.Windows.Forms.TextBox
    Private WithEvents _T_6 As System.Windows.Forms.TextBox
    Private WithEvents _T_5 As System.Windows.Forms.TextBox
    Private WithEvents _T_3 As System.Windows.Forms.TextBox
    Private WithEvents _T_2 As System.Windows.Forms.TextBox
    Private WithEvents _T_1 As System.Windows.Forms.TextBox
    Private WithEvents _T_0 As System.Windows.Forms.TextBox
    Public WithEvents MedNgay As System.Windows.Forms.MaskedTextBox
    Public WithEvents MedNgayhd As System.Windows.Forms.MaskedTextBox
    Private WithEvents _T_13 As System.Windows.Forms.TextBox
    Private WithEvents _T_10 As System.Windows.Forms.TextBox
    Private WithEvents _ChkV_1 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkV_5 As System.Windows.Forms.CheckBox
    Private WithEvents _Label1_15 As System.Windows.Forms.Label
    Private WithEvents _Label1_11 As System.Windows.Forms.Label
    Private WithEvents _Label1_16 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Private WithEvents _Label1_23 As System.Windows.Forms.Label
    Private WithEvents _Label1_22 As System.Windows.Forms.Label
    Private WithEvents _Label1_21 As System.Windows.Forms.Label
    Private WithEvents _Label1_19 As System.Windows.Forms.Label
    Private WithEvents _Label1_18 As System.Windows.Forms.Label
    Private WithEvents _Label1_17 As System.Windows.Forms.Label
    Private WithEvents _Label1_12 As System.Windows.Forms.Label
    Private WithEvents _Label1_14 As System.Windows.Forms.Label
    Private WithEvents _Label1_13 As System.Windows.Forms.Label
    Private WithEvents _Label1_8 As System.Windows.Forms.Label
    Private WithEvents _Label1_10 As System.Windows.Forms.Label
    Private WithEvents _Label1_9 As System.Windows.Forms.Label
    Private WithEvents _Label1_7 As System.Windows.Forms.Label
    Private WithEvents _Label1_6 As System.Windows.Forms.Label
    Private WithEvents _Label1_5 As System.Windows.Forms.Label
    Private WithEvents _Label1_4 As System.Windows.Forms.Label
    Private WithEvents _Label1_3 As System.Windows.Forms.Label
    Private WithEvents _Label1_2 As System.Windows.Forms.Label
    Private WithEvents _Label1_1 As System.Windows.Forms.Label
    Private WithEvents _Label1_0 As System.Windows.Forms.Label
    Public ChkV(8) As System.Windows.Forms.CheckBox
    Public Label1(25) As System.Windows.Forms.Label
    Public T(23) As System.Windows.Forms.TextBox
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._T_20 = New System.Windows.Forms.TextBox
        Me._T_14 = New System.Windows.Forms.TextBox
        Me._T_19 = New System.Windows.Forms.TextBox
        Me._T_18 = New System.Windows.Forms.TextBox
        Me._T_17 = New System.Windows.Forms.TextBox
        Me._T_16 = New System.Windows.Forms.TextBox
        Me._T_11 = New System.Windows.Forms.TextBox
        Me._T_12 = New System.Windows.Forms.TextBox
        Me._T_4 = New System.Windows.Forms.TextBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.llink_chitiet = New System.Windows.Forms.LinkLabel
        Me._ChkV_6 = New System.Windows.Forms.CheckBox
        Me._ChkV_7 = New System.Windows.Forms.CheckBox
        Me._ChkV_4 = New System.Windows.Forms.CheckBox
        Me._ChkV_3 = New System.Windows.Forms.CheckBox
        Me._ChkV_8 = New System.Windows.Forms.CheckBox
        Me._ChkV_2 = New System.Windows.Forms.CheckBox
        Me._ChkV_0 = New System.Windows.Forms.CheckBox
        Me._Label1_20 = New System.Windows.Forms.Label
        Me.Command = New System.Windows.Forms.Button
        Me._T_9 = New System.Windows.Forms.TextBox
        Me._T_8 = New System.Windows.Forms.TextBox
        Me._T_7 = New System.Windows.Forms.TextBox
        Me._T_6 = New System.Windows.Forms.TextBox
        Me._T_5 = New System.Windows.Forms.TextBox
        Me._T_3 = New System.Windows.Forms.TextBox
        Me._T_2 = New System.Windows.Forms.TextBox
        Me._T_1 = New System.Windows.Forms.TextBox
        Me._T_0 = New System.Windows.Forms.TextBox
        Me.MedNgay = New System.Windows.Forms.MaskedTextBox
        Me.MedNgayhd = New System.Windows.Forms.MaskedTextBox
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me._T_13 = New System.Windows.Forms.TextBox
        Me._T_10 = New System.Windows.Forms.TextBox
        Me._ChkV_1 = New System.Windows.Forms.CheckBox
        Me._ChkV_5 = New System.Windows.Forms.CheckBox
        Me._Label1_15 = New System.Windows.Forms.Label
        Me._Label1_11 = New System.Windows.Forms.Label
        Me._Label1_16 = New System.Windows.Forms.Label
        Me._Label1_23 = New System.Windows.Forms.Label
        Me._Label1_22 = New System.Windows.Forms.Label
        Me._Label1_21 = New System.Windows.Forms.Label
        Me._Label1_19 = New System.Windows.Forms.Label
        Me._Label1_18 = New System.Windows.Forms.Label
        Me._Label1_17 = New System.Windows.Forms.Label
        Me._Label1_12 = New System.Windows.Forms.Label
        Me._Label1_14 = New System.Windows.Forms.Label
        Me._Label1_13 = New System.Windows.Forms.Label
        Me._Label1_8 = New System.Windows.Forms.Label
        Me._Label1_10 = New System.Windows.Forms.Label
        Me._Label1_9 = New System.Windows.Forms.Label
        Me._Label1_7 = New System.Windows.Forms.Label
        Me._Label1_6 = New System.Windows.Forms.Label
        Me._Label1_5 = New System.Windows.Forms.Label
        Me._Label1_4 = New System.Windows.Forms.Label
        Me._Label1_3 = New System.Windows.Forms.Label
        Me._Label1_2 = New System.Windows.Forms.Label
        Me._Label1_1 = New System.Windows.Forms.Label
        Me._Label1_0 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me._T_15 = New System.Windows.Forms.TextBox
        Me._Label1_24 = New System.Windows.Forms.Label
        Me._T_22 = New System.Windows.Forms.TextBox
        Me._Label1_25 = New System.Windows.Forms.Label
        Me._T_23 = New System.Windows.Forms.TextBox
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        '_T_20
        '
        Me._T_20.AcceptsReturn = True
        Me._T_20.BackColor = System.Drawing.SystemColors.Window
        Me._T_20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_20.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_20.Location = New System.Drawing.Point(409, 152)
        Me._T_20.MaxLength = 20
        Me._T_20.Name = "_T_20"
        Me._T_20.Size = New System.Drawing.Size(177, 20)
        Me._T_20.TabIndex = 17
        '
        '_T_14
        '
        Me._T_14.AcceptsReturn = True
        Me._T_14.BackColor = System.Drawing.SystemColors.Window
        Me._T_14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_14.Location = New System.Drawing.Point(409, 8)
        Me._T_14.MaxLength = 20
        Me._T_14.Name = "_T_14"
        Me._T_14.Size = New System.Drawing.Size(177, 20)
        Me._T_14.TabIndex = 11
        '
        '_T_19
        '
        Me._T_19.AcceptsReturn = True
        Me._T_19.BackColor = System.Drawing.SystemColors.Window
        Me._T_19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_19.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_19.Location = New System.Drawing.Point(409, 128)
        Me._T_19.MaxLength = 20
        Me._T_19.Name = "_T_19"
        Me._T_19.Size = New System.Drawing.Size(177, 20)
        Me._T_19.TabIndex = 16
        '
        '_T_18
        '
        Me._T_18.AcceptsReturn = True
        Me._T_18.BackColor = System.Drawing.SystemColors.Window
        Me._T_18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_18.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_18.Location = New System.Drawing.Point(409, 104)
        Me._T_18.MaxLength = 20
        Me._T_18.Name = "_T_18"
        Me._T_18.Size = New System.Drawing.Size(177, 20)
        Me._T_18.TabIndex = 15
        '
        '_T_17
        '
        Me._T_17.AcceptsReturn = True
        Me._T_17.BackColor = System.Drawing.SystemColors.Window
        Me._T_17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_17.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_17.Location = New System.Drawing.Point(409, 80)
        Me._T_17.MaxLength = 20
        Me._T_17.Name = "_T_17"
        Me._T_17.Size = New System.Drawing.Size(177, 20)
        Me._T_17.TabIndex = 14
        '
        '_T_16
        '
        Me._T_16.AcceptsReturn = True
        Me._T_16.BackColor = System.Drawing.SystemColors.Window
        Me._T_16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_16.Location = New System.Drawing.Point(409, 56)
        Me._T_16.MaxLength = 20
        Me._T_16.Name = "_T_16"
        Me._T_16.Size = New System.Drawing.Size(177, 20)
        Me._T_16.TabIndex = 13
        '
        '_T_11
        '
        Me._T_11.AcceptsReturn = True
        Me._T_11.BackColor = System.Drawing.SystemColors.Window
        Me._T_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_11.Location = New System.Drawing.Point(409, 176)
        Me._T_11.MaxLength = 20
        Me._T_11.Name = "_T_11"
        Me._T_11.Size = New System.Drawing.Size(177, 20)
        Me._T_11.TabIndex = 18
        '
        '_T_12
        '
        Me._T_12.AcceptsReturn = True
        Me._T_12.BackColor = System.Drawing.SystemColors.Window
        Me._T_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_12.Location = New System.Drawing.Point(409, 251)
        Me._T_12.MaxLength = 20
        Me._T_12.Name = "_T_12"
        Me._T_12.Size = New System.Drawing.Size(177, 20)
        Me._T_12.TabIndex = 21
        '
        '_T_4
        '
        Me._T_4.AcceptsReturn = True
        Me._T_4.BackColor = System.Drawing.SystemColors.Window
        Me._T_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_4.Location = New System.Drawing.Point(409, 276)
        Me._T_4.MaxLength = 20
        Me._T_4.Multiline = True
        Me._T_4.Name = "_T_4"
        Me._T_4.Size = New System.Drawing.Size(177, 21)
        Me._T_4.TabIndex = 22
        Me._T_4.Text = "0"
        Me._T_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._T_4.Visible = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.Transparent
        Me.Frame1.Controls.Add(Me.llink_chitiet)
        Me.Frame1.Controls.Add(Me._ChkV_6)
        Me.Frame1.Controls.Add(Me._ChkV_7)
        Me.Frame1.Controls.Add(Me._ChkV_4)
        Me.Frame1.Controls.Add(Me._ChkV_3)
        Me.Frame1.Controls.Add(Me._ChkV_8)
        Me.Frame1.Controls.Add(Me._ChkV_2)
        Me.Frame1.Controls.Add(Me._ChkV_0)
        Me.Frame1.Controls.Add(Me._Label1_20)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 297)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(489, 89)
        Me.Frame1.TabIndex = 23
        Me.Frame1.TabStop = False
        Me.Frame1.Tag = "Invoice"
        Me.Frame1.Text = "Có hóa đơn"
        '
        'llink_chitiet
        '
        Me.llink_chitiet.AutoSize = True
        Me.llink_chitiet.Location = New System.Drawing.Point(139, 66)
        Me.llink_chitiet.Name = "llink_chitiet"
        Me.llink_chitiet.Size = New System.Drawing.Size(50, 14)
        Me.llink_chitiet.TabIndex = 7
        Me.llink_chitiet.TabStop = True
        Me.llink_chitiet.Text = "chi tiết ..."
        Me.llink_chitiet.Visible = False
        '
        '_ChkV_6
        '
        Me._ChkV_6.BackColor = System.Drawing.Color.Transparent
        Me._ChkV_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkV_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkV_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkV_6.Location = New System.Drawing.Point(316, 16)
        Me._ChkV_6.Name = "_ChkV_6"
        Me._ChkV_6.Size = New System.Drawing.Size(167, 17)
        Me._ChkV_6.TabIndex = 2
        Me._ChkV_6.Tag = "Agriculture, forastry, fisheries"
        Me._ChkV_6.Text = "Nông, lâm, thủy sản"
        Me._ChkV_6.UseVisualStyleBackColor = False
        '
        '_ChkV_7
        '
        Me._ChkV_7.BackColor = System.Drawing.Color.Transparent
        Me._ChkV_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkV_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkV_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkV_7.Location = New System.Drawing.Point(316, 40)
        Me._ChkV_7.Name = "_ChkV_7"
        Me._ChkV_7.Size = New System.Drawing.Size(167, 17)
        Me._ChkV_7.TabIndex = 5
        Me._ChkV_7.Tag = "Retail Bill"
        Me._ChkV_7.Text = "Điện nước"
        Me._ChkV_7.UseVisualStyleBackColor = False
        '
        '_ChkV_4
        '
        Me._ChkV_4.BackColor = System.Drawing.Color.Transparent
        Me._ChkV_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkV_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkV_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkV_4.Location = New System.Drawing.Point(192, 16)
        Me._ChkV_4.Name = "_ChkV_4"
        Me._ChkV_4.Size = New System.Drawing.Size(81, 17)
        Me._ChkV_4.TabIndex = 1
        Me._ChkV_4.Tag = "Fixed Assets"
        Me._ChkV_4.Text = "TSCĐ"
        Me._ChkV_4.UseVisualStyleBackColor = False
        '
        '_ChkV_3
        '
        Me._ChkV_3.BackColor = System.Drawing.Color.Transparent
        Me._ChkV_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkV_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkV_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkV_3.Location = New System.Drawing.Point(192, 40)
        Me._ChkV_3.Name = "_ChkV_3"
        Me._ChkV_3.Size = New System.Drawing.Size(97, 17)
        Me._ChkV_3.TabIndex = 4
        Me._ChkV_3.Tag = "Import"
        Me._ChkV_3.Text = "Nhập khẩu"
        Me._ChkV_3.UseVisualStyleBackColor = False
        '
        '_ChkV_8
        '
        Me._ChkV_8.BackColor = System.Drawing.Color.Transparent
        Me._ChkV_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkV_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkV_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkV_8.Location = New System.Drawing.Point(8, 63)
        Me._ChkV_8.Name = "_ChkV_8"
        Me._ChkV_8.Size = New System.Drawing.Size(125, 17)
        Me._ChkV_8.TabIndex = 6
        Me._ChkV_8.Tag = "Electronic invoice"
        Me._ChkV_8.Text = "Hóa đơn điện tử"
        Me._ChkV_8.UseVisualStyleBackColor = False
        '
        '_ChkV_2
        '
        Me._ChkV_2.BackColor = System.Drawing.Color.Transparent
        Me._ChkV_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkV_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkV_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkV_2.Location = New System.Drawing.Point(8, 40)
        Me._ChkV_2.Name = "_ChkV_2"
        Me._ChkV_2.Size = New System.Drawing.Size(105, 17)
        Me._ChkV_2.TabIndex = 3
        Me._ChkV_2.Tag = "Retail Bill"
        Me._ChkV_2.Text = "Hóa đơn bán lẻ"
        Me._ChkV_2.UseVisualStyleBackColor = False
        '
        '_ChkV_0
        '
        Me._ChkV_0.BackColor = System.Drawing.Color.Transparent
        Me._ChkV_0.Checked = True
        Me._ChkV_0.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ChkV_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkV_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkV_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkV_0.Location = New System.Drawing.Point(8, 16)
        Me._ChkV_0.Name = "_ChkV_0"
        Me._ChkV_0.Size = New System.Drawing.Size(105, 17)
        Me._ChkV_0.TabIndex = 0
        Me._ChkV_0.Tag = "VAT Bill"
        Me._ChkV_0.Text = "Có hoá đơn"
        Me._ChkV_0.UseVisualStyleBackColor = False
        '
        '_Label1_20
        '
        Me._Label1_20.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._Label1_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_20.Location = New System.Drawing.Point(313, 0)
        Me._Label1_20.Name = "_Label1_20"
        Me._Label1_20.Size = New System.Drawing.Size(81, 17)
        Me._Label1_20.TabIndex = 39
        Me._Label1_20.Tag = "Quantity"
        Me._Label1_20.Text = "Không hoá đơn"
        Me._Label1_20.Visible = False
        '
        'Command
        '
        Me.Command.Image = Global.UNET.My.Resources.Resources.select16
        Me.Command.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Command.Location = New System.Drawing.Point(503, 359)
        Me.Command.Name = "Command"
        Me.Command.Size = New System.Drawing.Size(82, 25)
        Me.Command.TabIndex = 24
        Me.Command.Tag = "Save"
        Me.Command.Text = "&Ghi"
        '
        '_T_9
        '
        Me._T_9.AcceptsReturn = True
        Me._T_9.BackColor = System.Drawing.SystemColors.Window
        Me._T_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_9.Enabled = False
        Me._T_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_9.Location = New System.Drawing.Point(120, 80)
        Me._T_9.MaxLength = 20
        Me._T_9.Name = "_T_9"
        Me._T_9.ReadOnly = True
        Me._T_9.Size = New System.Drawing.Size(177, 20)
        Me._T_9.TabIndex = 3
        Me._T_9.TabStop = False
        '
        '_T_8
        '
        Me._T_8.AcceptsReturn = True
        Me._T_8.BackColor = System.Drawing.SystemColors.Window
        Me._T_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_8.Enabled = False
        Me._T_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_8.Location = New System.Drawing.Point(120, 56)
        Me._T_8.MaxLength = 100
        Me._T_8.Name = "_T_8"
        Me._T_8.ReadOnly = True
        Me._T_8.Size = New System.Drawing.Size(177, 20)
        Me._T_8.TabIndex = 2
        Me._T_8.TabStop = False
        '
        '_T_7
        '
        Me._T_7.AcceptsReturn = True
        Me._T_7.BackColor = System.Drawing.SystemColors.Window
        Me._T_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_7.Enabled = False
        Me._T_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_7.Location = New System.Drawing.Point(120, 32)
        Me._T_7.MaxLength = 50
        Me._T_7.Name = "_T_7"
        Me._T_7.ReadOnly = True
        Me._T_7.Size = New System.Drawing.Size(177, 20)
        Me._T_7.TabIndex = 1
        Me._T_7.TabStop = False
        '
        '_T_6
        '
        Me._T_6.AcceptsReturn = True
        Me._T_6.BackColor = System.Drawing.SystemColors.Window
        Me._T_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_6.Enabled = False
        Me._T_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_6.Location = New System.Drawing.Point(120, 254)
        Me._T_6.MaxLength = 2
        Me._T_6.Name = "_T_6"
        Me._T_6.ReadOnly = True
        Me._T_6.Size = New System.Drawing.Size(177, 20)
        Me._T_6.TabIndex = 10
        Me._T_6.TabStop = False
        Me._T_6.Text = "0"
        Me._T_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_T_5
        '
        Me._T_5.AcceptsReturn = True
        Me._T_5.BackColor = System.Drawing.SystemColors.Window
        Me._T_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_5.Location = New System.Drawing.Point(120, 230)
        Me._T_5.MaxLength = 20
        Me._T_5.Multiline = True
        Me._T_5.Name = "_T_5"
        Me._T_5.Size = New System.Drawing.Size(177, 21)
        Me._T_5.TabIndex = 9
        Me._T_5.Text = "0"
        Me._T_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_T_3
        '
        Me._T_3.AcceptsReturn = True
        Me._T_3.BackColor = System.Drawing.SystemColors.Window
        Me._T_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_3.Location = New System.Drawing.Point(120, 206)
        Me._T_3.MaxLength = 50
        Me._T_3.Name = "_T_3"
        Me._T_3.Size = New System.Drawing.Size(177, 20)
        Me._T_3.TabIndex = 8
        '
        '_T_2
        '
        Me._T_2.AcceptsReturn = True
        Me._T_2.BackColor = System.Drawing.SystemColors.Window
        Me._T_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_2.Location = New System.Drawing.Point(120, 158)
        Me._T_2.MaxLength = 20
        Me._T_2.Name = "_T_2"
        Me._T_2.Size = New System.Drawing.Size(177, 20)
        Me._T_2.TabIndex = 6
        '
        '_T_1
        '
        Me._T_1.AcceptsReturn = True
        Me._T_1.BackColor = System.Drawing.SystemColors.Window
        Me._T_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_1.Location = New System.Drawing.Point(120, 134)
        Me._T_1.MaxLength = 20
        Me._T_1.Name = "_T_1"
        Me._T_1.Size = New System.Drawing.Size(177, 20)
        Me._T_1.TabIndex = 5
        '
        '_T_0
        '
        Me._T_0.AcceptsReturn = True
        Me._T_0.BackColor = System.Drawing.SystemColors.Window
        Me._T_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_0.Location = New System.Drawing.Point(120, 8)
        Me._T_0.MaxLength = 20
        Me._T_0.Name = "_T_0"
        Me._T_0.Size = New System.Drawing.Size(177, 20)
        Me._T_0.TabIndex = 0
        '
        'MedNgay
        '
        Me.MedNgay.AllowPromptAsInput = False
        Me.MedNgay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MedNgay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedNgay.Location = New System.Drawing.Point(120, 182)
        Me.MedNgay.Mask = "00/00/00"
        Me.MedNgay.Name = "MedNgay"
        Me.MedNgay.Size = New System.Drawing.Size(177, 20)
        Me.MedNgay.TabIndex = 7
        '
        'MedNgayhd
        '
        Me.MedNgayhd.AllowPromptAsInput = False
        Me.MedNgayhd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MedNgayhd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedNgayhd.Location = New System.Drawing.Point(409, 32)
        Me.MedNgayhd.Mask = "00/00/00"
        Me.MedNgayhd.Name = "MedNgayhd"
        Me.MedNgayhd.Size = New System.Drawing.Size(177, 20)
        Me.MedNgayhd.TabIndex = 12
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Frame2.Controls.Add(Me._T_13)
        Me.Frame2.Controls.Add(Me._T_10)
        Me.Frame2.Controls.Add(Me._ChkV_1)
        Me.Frame2.Controls.Add(Me._ChkV_5)
        Me.Frame2.Controls.Add(Me._Label1_15)
        Me.Frame2.Controls.Add(Me._Label1_11)
        Me.Frame2.Controls.Add(Me._Label1_16)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(504, 321)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(82, 25)
        Me.Frame2.TabIndex = 40
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Frame2"
        Me.Frame2.Visible = False
        '
        '_T_13
        '
        Me._T_13.AcceptsReturn = True
        Me._T_13.BackColor = System.Drawing.SystemColors.Window
        Me._T_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_13.Location = New System.Drawing.Point(104, 88)
        Me._T_13.MaxLength = 20
        Me._T_13.Name = "_T_13"
        Me._T_13.Size = New System.Drawing.Size(177, 20)
        Me._T_13.TabIndex = 44
        Me._T_13.Text = "0"
        Me._T_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._T_13.Visible = False
        '
        '_T_10
        '
        Me._T_10.AcceptsReturn = True
        Me._T_10.BackColor = System.Drawing.SystemColors.Window
        Me._T_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_10.Location = New System.Drawing.Point(88, 64)
        Me._T_10.MaxLength = 20
        Me._T_10.Multiline = True
        Me._T_10.Name = "_T_10"
        Me._T_10.Size = New System.Drawing.Size(137, 21)
        Me._T_10.TabIndex = 43
        Me._T_10.Text = "0"
        Me._T_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._T_10.Visible = False
        '
        '_ChkV_1
        '
        Me._ChkV_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me._ChkV_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkV_1.Enabled = False
        Me._ChkV_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkV_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkV_1.Location = New System.Drawing.Point(8, 32)
        Me._ChkV_1.Name = "_ChkV_1"
        Me._ChkV_1.Size = New System.Drawing.Size(105, 17)
        Me._ChkV_1.TabIndex = 42
        Me._ChkV_1.Tag = "Non-Taxable"
        Me._ChkV_1.Text = "Không chịu thuế"
        Me._ChkV_1.UseVisualStyleBackColor = False
        Me._ChkV_1.Visible = False
        '
        '_ChkV_5
        '
        Me._ChkV_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me._ChkV_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkV_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkV_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkV_5.Location = New System.Drawing.Point(8, 16)
        Me._ChkV_5.Name = "_ChkV_5"
        Me._ChkV_5.Size = New System.Drawing.Size(81, 17)
        Me._ChkV_5.TabIndex = 41
        Me._ChkV_5.Tag = "Adjustment"
        Me._ChkV_5.Text = "Điều chỉnh"
        Me._ChkV_5.UseVisualStyleBackColor = False
        Me._ChkV_5.Visible = False
        '
        '_Label1_15
        '
        Me._Label1_15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me._Label1_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_15.Location = New System.Drawing.Point(16, 88)
        Me._Label1_15.Name = "_Label1_15"
        Me._Label1_15.Size = New System.Drawing.Size(81, 17)
        Me._Label1_15.TabIndex = 47
        Me._Label1_15.Tag = "Ex. Rate"
        Me._Label1_15.Text = "Tỷ giá"
        Me._Label1_15.Visible = False
        '
        '_Label1_11
        '
        Me._Label1_11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me._Label1_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_11.Location = New System.Drawing.Point(16, 48)
        Me._Label1_11.Name = "_Label1_11"
        Me._Label1_11.Size = New System.Drawing.Size(161, 17)
        Me._Label1_11.TabIndex = 46
        Me._Label1_11.Tag = "(# for un-frequent liability)"
        Me._Label1_11.Text = "(Nhập dấu # cho khách vãng lai)"
        '
        '_Label1_16
        '
        Me._Label1_16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me._Label1_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_16.Location = New System.Drawing.Point(8, 64)
        Me._Label1_16.Name = "_Label1_16"
        Me._Label1_16.Size = New System.Drawing.Size(65, 17)
        Me._Label1_16.TabIndex = 45
        Me._Label1_16.Tag = "Taxable Amount"
        Me._Label1_16.Text = "Giá tính thuế"
        Me._Label1_16.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me._Label1_16.Visible = False
        '
        '_Label1_23
        '
        Me._Label1_23.BackColor = System.Drawing.Color.Transparent
        Me._Label1_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_23.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_23.Location = New System.Drawing.Point(321, 152)
        Me._Label1_23.Name = "_Label1_23"
        Me._Label1_23.Size = New System.Drawing.Size(81, 17)
        Me._Label1_23.TabIndex = 57
        Me._Label1_23.Tag = "Tra. inv. name"
        Me._Label1_23.Text = "Tên vận đơn"
        '
        '_Label1_22
        '
        Me._Label1_22.BackColor = System.Drawing.Color.Transparent
        Me._Label1_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_22.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_22.Location = New System.Drawing.Point(321, 32)
        Me._Label1_22.Name = "_Label1_22"
        Me._Label1_22.Size = New System.Drawing.Size(81, 17)
        Me._Label1_22.TabIndex = 56
        Me._Label1_22.Tag = "Date"
        Me._Label1_22.Text = "ngày hợp đồng"
        '
        '_Label1_21
        '
        Me._Label1_21.BackColor = System.Drawing.Color.Transparent
        Me._Label1_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_21.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_21.Location = New System.Drawing.Point(321, 8)
        Me._Label1_21.Name = "_Label1_21"
        Me._Label1_21.Size = New System.Drawing.Size(81, 17)
        Me._Label1_21.TabIndex = 55
        Me._Label1_21.Tag = "Contract code"
        Me._Label1_21.Text = "Số hợp đồng"
        '
        '_Label1_19
        '
        Me._Label1_19.BackColor = System.Drawing.Color.Transparent
        Me._Label1_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_19.Location = New System.Drawing.Point(321, 128)
        Me._Label1_19.Name = "_Label1_19"
        Me._Label1_19.Size = New System.Drawing.Size(81, 17)
        Me._Label1_19.TabIndex = 54
        Me._Label1_19.Tag = "Container code"
        Me._Label1_19.Text = "Số container"
        '
        '_Label1_18
        '
        Me._Label1_18.BackColor = System.Drawing.Color.Transparent
        Me._Label1_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_18.Location = New System.Drawing.Point(321, 104)
        Me._Label1_18.Name = "_Label1_18"
        Me._Label1_18.Size = New System.Drawing.Size(81, 17)
        Me._Label1_18.TabIndex = 53
        Me._Label1_18.Tag = "Tra. inv. code"
        Me._Label1_18.Text = "Số vận đơn"
        '
        '_Label1_17
        '
        Me._Label1_17.BackColor = System.Drawing.Color.Transparent
        Me._Label1_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_17.Location = New System.Drawing.Point(321, 80)
        Me._Label1_17.Name = "_Label1_17"
        Me._Label1_17.Size = New System.Drawing.Size(81, 17)
        Me._Label1_17.TabIndex = 52
        Me._Label1_17.Tag = "Receiving locations"
        Me._Label1_17.Text = "Địa điểm nhận"
        '
        '_Label1_12
        '
        Me._Label1_12.BackColor = System.Drawing.Color.Transparent
        Me._Label1_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_12.Location = New System.Drawing.Point(321, 56)
        Me._Label1_12.Name = "_Label1_12"
        Me._Label1_12.Size = New System.Drawing.Size(81, 17)
        Me._Label1_12.TabIndex = 51
        Me._Label1_12.Tag = "delivery locations"
        Me._Label1_12.Text = "Địa điểm giao"
        '
        '_Label1_14
        '
        Me._Label1_14.BackColor = System.Drawing.Color.Transparent
        Me._Label1_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_14.Location = New System.Drawing.Point(321, 251)
        Me._Label1_14.Name = "_Label1_14"
        Me._Label1_14.Size = New System.Drawing.Size(65, 17)
        Me._Label1_14.TabIndex = 50
        Me._Label1_14.Tag = "Notes"
        Me._Label1_14.Text = "Ghi chú"
        '
        '_Label1_13
        '
        Me._Label1_13.BackColor = System.Drawing.Color.Transparent
        Me._Label1_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_13.Location = New System.Drawing.Point(321, 176)
        Me._Label1_13.Name = "_Label1_13"
        Me._Label1_13.Size = New System.Drawing.Size(81, 17)
        Me._Label1_13.TabIndex = 49
        Me._Label1_13.Tag = "Order list"
        Me._Label1_13.Text = "Thứ tự bảng kê"
        '
        '_Label1_8
        '
        Me._Label1_8.BackColor = System.Drawing.Color.Transparent
        Me._Label1_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_8.Location = New System.Drawing.Point(321, 276)
        Me._Label1_8.Name = "_Label1_8"
        Me._Label1_8.Size = New System.Drawing.Size(78, 17)
        Me._Label1_8.TabIndex = 48
        Me._Label1_8.Tag = "Quantity"
        Me._Label1_8.Text = "Số lượng"
        Me._Label1_8.Visible = False
        '
        '_Label1_10
        '
        Me._Label1_10.BackColor = System.Drawing.Color.Transparent
        Me._Label1_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_10.Location = New System.Drawing.Point(8, 254)
        Me._Label1_10.Name = "_Label1_10"
        Me._Label1_10.Size = New System.Drawing.Size(89, 17)
        Me._Label1_10.TabIndex = 37
        Me._Label1_10.Tag = "Tax Rate"
        Me._Label1_10.Text = "Tỷ lệ thuế (%)"
        '
        '_Label1_9
        '
        Me._Label1_9.BackColor = System.Drawing.Color.Transparent
        Me._Label1_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_9.Location = New System.Drawing.Point(8, 230)
        Me._Label1_9.Name = "_Label1_9"
        Me._Label1_9.Size = New System.Drawing.Size(105, 17)
        Me._Label1_9.TabIndex = 36
        Me._Label1_9.Tag = "Amount before Tax"
        Me._Label1_9.Text = "Thành tiền trước thuế"
        '
        '_Label1_7
        '
        Me._Label1_7.BackColor = System.Drawing.Color.Transparent
        Me._Label1_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_7.Location = New System.Drawing.Point(8, 206)
        Me._Label1_7.Name = "_Label1_7"
        Me._Label1_7.Size = New System.Drawing.Size(89, 17)
        Me._Label1_7.TabIndex = 35
        Me._Label1_7.Tag = "Items"
        Me._Label1_7.Text = "Mặt hàng"
        '
        '_Label1_6
        '
        Me._Label1_6.BackColor = System.Drawing.Color.Transparent
        Me._Label1_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_6.Location = New System.Drawing.Point(8, 182)
        Me._Label1_6.Name = "_Label1_6"
        Me._Label1_6.Size = New System.Drawing.Size(89, 17)
        Me._Label1_6.TabIndex = 34
        Me._Label1_6.Tag = "Bill Date"
        Me._Label1_6.Text = "Ngày phát hành"
        '
        '_Label1_5
        '
        Me._Label1_5.BackColor = System.Drawing.Color.Transparent
        Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_5.Location = New System.Drawing.Point(8, 134)
        Me._Label1_5.Name = "_Label1_5"
        Me._Label1_5.Size = New System.Drawing.Size(89, 17)
        Me._Label1_5.TabIndex = 33
        Me._Label1_5.Tag = "Bill Code"
        Me._Label1_5.Text = "Ký hiệu hoá đơn"
        '
        '_Label1_4
        '
        Me._Label1_4.BackColor = System.Drawing.Color.Transparent
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_4.Location = New System.Drawing.Point(8, 158)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.Size = New System.Drawing.Size(89, 17)
        Me._Label1_4.TabIndex = 32
        Me._Label1_4.Tag = "Bill Number"
        Me._Label1_4.Text = "Số hoá đơn"
        '
        '_Label1_3
        '
        Me._Label1_3.BackColor = System.Drawing.Color.Transparent
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_3.Location = New System.Drawing.Point(8, 80)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.Size = New System.Drawing.Size(89, 17)
        Me._Label1_3.TabIndex = 31
        Me._Label1_3.Tag = "Tax Code"
        Me._Label1_3.Text = "Mã số thuế"
        '
        '_Label1_2
        '
        Me._Label1_2.BackColor = System.Drawing.Color.Transparent
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(8, 56)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.Size = New System.Drawing.Size(89, 17)
        Me._Label1_2.TabIndex = 30
        Me._Label1_2.Tag = "Address"
        Me._Label1_2.Text = "Địa chỉ"
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.Color.Transparent
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(8, 32)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.Size = New System.Drawing.Size(89, 17)
        Me._Label1_1.TabIndex = 29
        Me._Label1_1.Tag = "Description"
        Me._Label1_1.Text = "Tên khách hàng"
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.Color.Transparent
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(8, 8)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.Size = New System.Drawing.Size(89, 17)
        Me._Label1_0.TabIndex = 28
        Me._Label1_0.Tag = "Liability Code"
        Me._Label1_0.Text = "Mã số đơn vị"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 33
        Me.Label2.Tag = "Sample invoice form"
        Me.Label2.Text = "Ký hiệu mẫu"
        '
        '_T_15
        '
        Me._T_15.AcceptsReturn = True
        Me._T_15.BackColor = System.Drawing.SystemColors.Window
        Me._T_15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_15.Location = New System.Drawing.Point(120, 108)
        Me._T_15.MaxLength = 20
        Me._T_15.Name = "_T_15"
        Me._T_15.Size = New System.Drawing.Size(177, 20)
        Me._T_15.TabIndex = 4
        '
        '_Label1_24
        '
        Me._Label1_24.BackColor = System.Drawing.Color.Transparent
        Me._Label1_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_24.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_24.Location = New System.Drawing.Point(321, 201)
        Me._Label1_24.Name = "_Label1_24"
        Me._Label1_24.Size = New System.Drawing.Size(65, 17)
        Me._Label1_24.TabIndex = 50
        Me._Label1_24.Tag = "Lot number"
        Me._Label1_24.Text = "Số lô"
        '
        '_T_22
        '
        Me._T_22.AcceptsReturn = True
        Me._T_22.BackColor = System.Drawing.SystemColors.Window
        Me._T_22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_22.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_22.Location = New System.Drawing.Point(409, 201)
        Me._T_22.MaxLength = 20
        Me._T_22.Name = "_T_22"
        Me._T_22.Size = New System.Drawing.Size(177, 20)
        Me._T_22.TabIndex = 19
        '
        '_Label1_25
        '
        Me._Label1_25.BackColor = System.Drawing.Color.Transparent
        Me._Label1_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_25.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_25.Location = New System.Drawing.Point(321, 226)
        Me._Label1_25.Name = "_Label1_25"
        Me._Label1_25.Size = New System.Drawing.Size(65, 17)
        Me._Label1_25.TabIndex = 50
        Me._Label1_25.Tag = "Due date"
        Me._Label1_25.Text = "Hạn dùng"
        '
        '_T_23
        '
        Me._T_23.AcceptsReturn = True
        Me._T_23.BackColor = System.Drawing.SystemColors.Window
        Me._T_23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._T_23.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._T_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._T_23.Location = New System.Drawing.Point(409, 226)
        Me._T_23.MaxLength = 20
        Me._T_23.Name = "_T_23"
        Me._T_23.Size = New System.Drawing.Size(177, 20)
        Me._T_23.TabIndex = 20
        '
        'FVAT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(594, 393)
        Me.ControlBox = False
        Me.Controls.Add(Me._T_20)
        Me.Controls.Add(Me._T_14)
        Me.Controls.Add(Me._T_19)
        Me.Controls.Add(Me._T_18)
        Me.Controls.Add(Me._T_17)
        Me.Controls.Add(Me._T_16)
        Me.Controls.Add(Me._T_11)
        Me.Controls.Add(Me._T_22)
        Me.Controls.Add(Me._T_23)
        Me.Controls.Add(Me._T_12)
        Me.Controls.Add(Me.Command)
        Me.Controls.Add(Me._T_4)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me._T_9)
        Me.Controls.Add(Me._T_8)
        Me.Controls.Add(Me._T_7)
        Me.Controls.Add(Me._T_6)
        Me.Controls.Add(Me._T_5)
        Me.Controls.Add(Me._T_3)
        Me.Controls.Add(Me._T_2)
        Me.Controls.Add(Me._T_15)
        Me.Controls.Add(Me._T_1)
        Me.Controls.Add(Me._T_0)
        Me.Controls.Add(Me.MedNgay)
        Me.Controls.Add(Me.MedNgayhd)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me._Label1_23)
        Me.Controls.Add(Me._Label1_22)
        Me.Controls.Add(Me._Label1_21)
        Me.Controls.Add(Me._Label1_19)
        Me.Controls.Add(Me._Label1_18)
        Me.Controls.Add(Me._Label1_17)
        Me.Controls.Add(Me._Label1_24)
        Me.Controls.Add(Me._Label1_25)
        Me.Controls.Add(Me._Label1_12)
        Me.Controls.Add(Me._Label1_14)
        Me.Controls.Add(Me._Label1_13)
        Me.Controls.Add(Me._Label1_8)
        Me.Controls.Add(Me._Label1_10)
        Me.Controls.Add(Me._Label1_9)
        Me.Controls.Add(Me._Label1_7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me._Label1_6)
        Me.Controls.Add(Me._Label1_5)
        Me.Controls.Add(Me._Label1_4)
        Me.Controls.Add(Me._Label1_3)
        Me.Controls.Add(Me._Label1_2)
        Me.Controls.Add(Me._Label1_1)
        Me.Controls.Add(Me._Label1_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(312, 211)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FVAT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Thông tin hoá đơn"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Sub InitializeT()
        Me.T(20) = _T_20
        Me.T(14) = _T_14
        Me.T(19) = _T_19
        Me.T(18) = _T_18
        Me.T(17) = _T_17
        Me.T(16) = _T_16
        Me.T(11) = _T_11
        Me.T(12) = _T_12
        Me.T(4) = _T_4
        Me.T(9) = _T_9
        Me.T(8) = _T_8
        Me.T(7) = _T_7
        Me.T(6) = _T_6
        Me.T(5) = _T_5
        Me.T(3) = _T_3
        Me.T(2) = _T_2
        Me.T(1) = _T_1
        Me.T(0) = _T_0
        Me.T(13) = _T_13
        Me.T(10) = _T_10
        Me.T(21) = _T_15
        Me.T(22) = _T_22
        Me.T(23) = _T_23
    End Sub
    Sub InitializeLabel1()
        Me.Label1(25) = _Label1_25
        Me.Label1(24) = _Label1_24
        Me.Label1(20) = _Label1_20
        Me.Label1(15) = _Label1_15
        Me.Label1(11) = _Label1_11
        Me.Label1(16) = _Label1_16
        Me.Label1(23) = _Label1_23
        Me.Label1(22) = _Label1_22
        Me.Label1(21) = _Label1_21
        Me.Label1(19) = _Label1_19
        Me.Label1(18) = _Label1_18
        Me.Label1(17) = _Label1_17
        Me.Label1(12) = _Label1_12
        Me.Label1(14) = _Label1_14
        Me.Label1(13) = _Label1_13
        Me.Label1(8) = _Label1_8
        Me.Label1(10) = _Label1_10
        Me.Label1(9) = _Label1_9
        Me.Label1(7) = _Label1_7
        Me.Label1(6) = _Label1_6
        Me.Label1(5) = _Label1_5
        Me.Label1(4) = _Label1_4
        Me.Label1(3) = _Label1_3
        Me.Label1(2) = _Label1_2
        Me.Label1(1) = _Label1_1
        Me.Label1(0) = _Label1_0
    End Sub
    Sub InitializeChkV()
        Me.ChkV(6) = _ChkV_6
        Me.ChkV(7) = _ChkV_7
        Me.ChkV(8) = _ChkV_8
        Me.ChkV(4) = _ChkV_4
        Me.ChkV(3) = _ChkV_3
        Me.ChkV(2) = _ChkV_2
        Me.ChkV(0) = _ChkV_0
        Me.ChkV(1) = _ChkV_1
        Me.ChkV(5) = _ChkV_5
    End Sub
    Private WithEvents _ChkV_8 As System.Windows.Forms.CheckBox
    Friend WithEvents llink_chitiet As System.Windows.Forms.LinkLabel
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents _T_15 As System.Windows.Forms.TextBox
    Private WithEvents _Label1_24 As System.Windows.Forms.Label
    Private WithEvents _T_22 As System.Windows.Forms.TextBox
    Private WithEvents _Label1_25 As System.Windows.Forms.Label
    Private WithEvents _T_23 As System.Windows.Forms.TextBox
#End Region 
End Class
