<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FVTDauKy
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializetxtTon()
		InitializeLbTien()
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
    Public WithEvents CboKho As ComboBoxEx.ComboBoxExt
    Public WithEvents Cboloai As ComboBoxEx.ComboBoxExt
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Public WithEvents cmdct As System.Windows.Forms.Button
    Private WithEvents _txtTon_7 As System.Windows.Forms.TextBox
    Public WithEvents CboDV As ComboBoxEx.ComboBoxExt
    Public WithEvents Cbo As ComboBoxEx.ComboBoxExt
    Private WithEvents _txtTon_6 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_5 As System.Windows.Forms.TextBox
    Public WithEvents GrdVT As ListViewEx.ListviewExt
    Private WithEvents _txtTon_4 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_3 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_0 As System.Windows.Forms.TextBox
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _LbTien_1 As System.Windows.Forms.Label
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Label_9 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _LbTien_0 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Public Command(3) As System.Windows.Forms.Button
    Public Command1(2) As System.Windows.Forms.Button
    Public Label(12) As System.Windows.Forms.Label
    Public LbTien(1) As System.Windows.Forms.Label
    Public txtTon(7) As System.Windows.Forms.TextBox
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FVTDauKy))
        Me.CboKho = New ComboBoxEx.ComboBoxExt
        Me.Cboloai = New ComboBoxEx.ComboBoxExt
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me.cmdct = New System.Windows.Forms.Button
        Me._txtTon_7 = New System.Windows.Forms.TextBox
        Me.CboDV = New ComboBoxEx.ComboBoxExt
        Me.Cbo = New ComboBoxEx.ComboBoxExt
        Me._txtTon_6 = New System.Windows.Forms.TextBox
        Me._txtTon_5 = New System.Windows.Forms.TextBox
        Me._txtTon_4 = New System.Windows.Forms.TextBox
        Me._txtTon_3 = New System.Windows.Forms.TextBox
        Me._txtTon_2 = New System.Windows.Forms.TextBox
        Me._txtTon_1 = New System.Windows.Forms.TextBox
        Me._txtTon_0 = New System.Windows.Forms.TextBox
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_12 = New System.Windows.Forms.Label
        Me._LbTien_1 = New System.Windows.Forms.Label
        Me._Label_11 = New System.Windows.Forms.Label
        Me._Label_10 = New System.Windows.Forms.Label
        Me._Label_9 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._LbTien_0 = New System.Windows.Forms.Label
        Me._Label_5 = New System.Windows.Forms.Label
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me.GrdVT = New ListViewEx.ListviewExt
        Me.SuspendLayout()
        '
        'CboKho
        '
        Me.CboKho.BackColor = System.Drawing.SystemColors.Window
        Me.CboKho.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboKho.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboKho.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboKho.Location = New System.Drawing.Point(320, 9)
        Me.CboKho.Name = "CboKho"
        Me.CboKho.Size = New System.Drawing.Size(137, 21)
        Me.CboKho.TabIndex = 32
        '
        'Cboloai
        '
        Me.Cboloai.BackColor = System.Drawing.SystemColors.Window
        Me.Cboloai.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cboloai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.Cboloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cboloai.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cboloai.Location = New System.Drawing.Point(72, 9)
        Me.Cboloai.Name = "Cboloai"
        Me.Cboloai.Size = New System.Drawing.Size(201, 21)
        Me.Cboloai.TabIndex = 31
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.Inventory16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(338, 441)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(81, 25)
        Me._Command_2.TabIndex = 30
        Me._Command_2.Tag = "Residual"
        Me._Command_2.Text = "&Tồn kho"
        Me._Command_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._Command_2.Visible = False
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(574, 441)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 29
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        Me._Command_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.tool16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(422, 441)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 28
        Me._Command_0.Tag = "Apply"
        Me._Command_0.Text = "Xử &lý"
        Me._Command_0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._Command_0.Visible = False
        '
        'cmdct
        '
        Me.cmdct.BackColor = System.Drawing.SystemColors.Control
        Me.cmdct.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdct.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdct.Image = Global.UNET.My.Resources.Resources.up16
        Me.cmdct.Location = New System.Drawing.Point(630, 416)
        Me.cmdct.Name = "cmdct"
        Me.cmdct.Size = New System.Drawing.Size(19, 19)
        Me.cmdct.TabIndex = 9
        Me.cmdct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdct.UseVisualStyleBackColor = False
        '
        '_txtTon_7
        '
        Me._txtTon_7.AcceptsReturn = True
        Me._txtTon_7.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_7.Location = New System.Drawing.Point(634, 415)
        Me._txtTon_7.MaxLength = 20
        Me._txtTon_7.Multiline = True
        Me._txtTon_7.Name = "_txtTon_7"
        Me._txtTon_7.Size = New System.Drawing.Size(89, 21)
        Me._txtTon_7.TabIndex = 8
        Me._txtTon_7.Text = "0"
        Me._txtTon_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._txtTon_7.Visible = False
        '
        'CboDV
        '
        Me.CboDV.BackColor = System.Drawing.SystemColors.Window
        Me.CboDV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboDV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDV.Location = New System.Drawing.Point(304, 414)
        Me.CboDV.Name = "CboDV"
        Me.CboDV.Size = New System.Drawing.Size(65, 21)
        Me.CboDV.TabIndex = 3
        Me.CboDV.Visible = False
        '
        'Cbo
        '
        Me.Cbo.BackColor = System.Drawing.SystemColors.Window
        Me.Cbo.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cbo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.Cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo.Location = New System.Drawing.Point(232, 443)
        Me.Cbo.Name = "Cbo"
        Me.Cbo.Size = New System.Drawing.Size(73, 21)
        Me.Cbo.TabIndex = 21
        Me.Cbo.Visible = False
        '
        '_txtTon_6
        '
        Me._txtTon_6.AcceptsReturn = True
        Me._txtTon_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_6.Location = New System.Drawing.Point(544, 415)
        Me._txtTon_6.MaxLength = 20
        Me._txtTon_6.Multiline = True
        Me._txtTon_6.Name = "_txtTon_6"
        Me._txtTon_6.Size = New System.Drawing.Size(87, 21)
        Me._txtTon_6.TabIndex = 7
        Me._txtTon_6.Text = "0"
        Me._txtTon_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtTon_5
        '
        Me._txtTon_5.AcceptsReturn = True
        Me._txtTon_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_5.Location = New System.Drawing.Point(456, 415)
        Me._txtTon_5.MaxLength = 20
        Me._txtTon_5.Multiline = True
        Me._txtTon_5.Name = "_txtTon_5"
        Me._txtTon_5.Size = New System.Drawing.Size(89, 21)
        Me._txtTon_5.TabIndex = 6
        Me._txtTon_5.Text = "0"
        Me._txtTon_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtTon_4
        '
        Me._txtTon_4.AcceptsReturn = True
        Me._txtTon_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_4.Location = New System.Drawing.Point(368, 415)
        Me._txtTon_4.MaxLength = 20
        Me._txtTon_4.Multiline = True
        Me._txtTon_4.Name = "_txtTon_4"
        Me._txtTon_4.Size = New System.Drawing.Size(89, 21)
        Me._txtTon_4.TabIndex = 5
        Me._txtTon_4.Text = "0"
        Me._txtTon_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtTon_3
        '
        Me._txtTon_3.AcceptsReturn = True
        Me._txtTon_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_3.Location = New System.Drawing.Point(320, 416)
        Me._txtTon_3.MaxLength = 20
        Me._txtTon_3.Name = "_txtTon_3"
        Me._txtTon_3.Size = New System.Drawing.Size(49, 20)
        Me._txtTon_3.TabIndex = 4
        Me._txtTon_3.TabStop = False
        '
        '_txtTon_2
        '
        Me._txtTon_2.AcceptsReturn = True
        Me._txtTon_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_2.Location = New System.Drawing.Point(160, 416)
        Me._txtTon_2.MaxLength = 50
        Me._txtTon_2.Name = "_txtTon_2"
        Me._txtTon_2.Size = New System.Drawing.Size(161, 20)
        Me._txtTon_2.TabIndex = 2
        Me._txtTon_2.TabStop = False
        '
        '_txtTon_1
        '
        Me._txtTon_1.AcceptsReturn = True
        Me._txtTon_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_1.Location = New System.Drawing.Point(72, 416)
        Me._txtTon_1.MaxLength = 20
        Me._txtTon_1.Name = "_txtTon_1"
        Me._txtTon_1.Size = New System.Drawing.Size(89, 20)
        Me._txtTon_1.TabIndex = 1
        '
        '_txtTon_0
        '
        Me._txtTon_0.AcceptsReturn = True
        Me._txtTon_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_0.Location = New System.Drawing.Point(8, 416)
        Me._txtTon_0.MaxLength = 20
        Me._txtTon_0.Name = "_txtTon_0"
        Me._txtTon_0.Size = New System.Drawing.Size(65, 20)
        Me._txtTon_0.TabIndex = 0
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(498, 441)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 35
        Me._Command_3.Tag = "Delete"
        Me._Command_3.Text = "&Xoá"
        Me._Command_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(285, 11)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(28, 17)
        Me._Label_0.TabIndex = 34
        Me._Label_0.Tag = "Store"
        Me._Label_0.Text = "Kho"
        '
        '_Label_12
        '
        Me._Label_12.BackColor = System.Drawing.Color.Transparent
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_12.Location = New System.Drawing.Point(5, 11)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.Size = New System.Drawing.Size(57, 17)
        Me._Label_12.TabIndex = 33
        Me._Label_12.Tag = "Class"
        Me._Label_12.Text = "Phân loại"
        '
        '_LbTien_1
        '
        Me._LbTien_1.BackColor = System.Drawing.Color.Transparent
        Me._LbTien_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTien_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTien_1.ForeColor = System.Drawing.Color.Blue
        Me._LbTien_1.Location = New System.Drawing.Point(636, 11)
        Me._LbTien_1.Name = "_LbTien_1"
        Me._LbTien_1.Size = New System.Drawing.Size(81, 17)
        Me._LbTien_1.TabIndex = 27
        Me._LbTien_1.Text = "0"
        Me._LbTien_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.Transparent
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_11.Location = New System.Drawing.Point(8, 445)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(129, 17)
        Me._Label_11.TabIndex = 26
        Me._Label_11.Tag = "Beginning rate"
        Me._Label_11.Text = "Tỷ giá đầu kỳ:"
        Me._Label_11.Visible = False
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.Color.Black
        Me._Label_10.Location = New System.Drawing.Point(630, 40)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(89, 17)
        Me._Label_10.TabIndex = 25
        Me._Label_10.Tag = "Amount"
        Me._Label_10.Text = "Thành tiền USD"
        Me._Label_10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_10.Visible = False
        '
        '_Label_9
        '
        Me._Label_9.BackColor = System.Drawing.Color.Transparent
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_9.Location = New System.Drawing.Point(185, 445)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.Size = New System.Drawing.Size(41, 17)
        Me._Label_9.TabIndex = 22
        Me._Label_9.Tag = "Month"
        Me._Label_9.Text = "Tháng"
        Me._Label_9.Visible = False
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.Color.Black
        Me._Label_8.Location = New System.Drawing.Point(456, 40)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(89, 17)
        Me._Label_8.TabIndex = 20
        Me._Label_8.Tag = "Unit Price"
        Me._Label_8.Text = "Đơn giá"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(8, 40)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(65, 17)
        Me._Label_7.TabIndex = 19
        Me._Label_7.Tag = "Account"
        Me._Label_7.Text = "Số hiệu TK"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.Transparent
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_6.Location = New System.Drawing.Point(456, 11)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(73, 17)
        Me._Label_6.TabIndex = 17
        Me._Label_6.Tag = "Total"
        Me._Label_6.Text = "Tổng tiền"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbTien_0
        '
        Me._LbTien_0.BackColor = System.Drawing.Color.Transparent
        Me._LbTien_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTien_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTien_0.ForeColor = System.Drawing.Color.Blue
        Me._LbTien_0.Location = New System.Drawing.Point(542, 11)
        Me._LbTien_0.Name = "_LbTien_0"
        Me._LbTien_0.Size = New System.Drawing.Size(89, 17)
        Me._LbTien_0.TabIndex = 16
        Me._LbTien_0.Text = "0"
        Me._LbTien_0.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.Color.Black
        Me._Label_5.Location = New System.Drawing.Point(544, 40)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(87, 17)
        Me._Label_5.TabIndex = 15
        Me._Label_5.Tag = "Amount"
        Me._Label_5.Text = "Thành tiền"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(368, 40)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(89, 17)
        Me._Label_4.TabIndex = 14
        Me._Label_4.Tag = "Quantity"
        Me._Label_4.Text = "Số lượng"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.Black
        Me._Label_3.Location = New System.Drawing.Point(320, 40)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(49, 17)
        Me._Label_3.TabIndex = 13
        Me._Label_3.Tag = "Unit"
        Me._Label_3.Text = "Đ.vị"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.Black
        Me._Label_2.Location = New System.Drawing.Point(160, 40)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(161, 17)
        Me._Label_2.TabIndex = 12
        Me._Label_2.Tag = "Description"
        Me._Label_2.Text = "Tên vật tư"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(72, 40)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(89, 17)
        Me._Label_1.TabIndex = 11
        Me._Label_1.Tag = "Inventory Code"
        Me._Label_1.Text = "Số hiệu VT"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GrdVT
        '
        Me.GrdVT.AllowColumnResize = True
        Me.GrdVT.AllowMultiselect = False
        Me.GrdVT.AlternateBackground = System.Drawing.Color.DarkGreen
        Me.GrdVT.AlternatingColors = False
        Me.GrdVT.AutoHeight = True
        Me.GrdVT.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdVT.BackgroundStretchToFit = True
        Me.GrdVT.Col = 0
        Me.GrdVT.Cols = 0
        Me.GrdVT.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me.GrdVT.FullRowSelect = True
        Me.GrdVT.GridColor = System.Drawing.Color.LightGray
        Me.GrdVT.GridLines = ListViewEx.GLGridLines.gridBoth
        Me.GrdVT.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me.GrdVT.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me.GrdVT.HeaderHeight = 22
        Me.GrdVT.HeaderVisible = True
        Me.GrdVT.HeaderWordWrap = False
        Me.GrdVT.HotColumnTracking = False
        Me.GrdVT.HotItemTracking = False
        Me.GrdVT.HotTrackingColor = System.Drawing.Color.LightGray
        Me.GrdVT.HoverEvents = False
        Me.GrdVT.HoverTime = 1
        Me.GrdVT.ImageList = Nothing
        Me.GrdVT.ItemHeight = 18
        Me.GrdVT.ItemWordWrap = False
        Me.GrdVT.Location = New System.Drawing.Point(8, 56)
        Me.GrdVT.Name = "GrdVT"
        Me.GrdVT.Row = 0
        Me.GrdVT.Rows = 0
        Me.GrdVT.Selectable = True
        Me.GrdVT.SelectedTextColor = System.Drawing.Color.White
        Me.GrdVT.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.GrdVT.ShowBorder = True
        Me.GrdVT.ShowFocusRect = False
        Me.GrdVT.Size = New System.Drawing.Size(643, 361)
        Me.GrdVT.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdVT.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdVT.TabIndex = 10
        '
        'FVTDauKy
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(652, 470)
        Me.Controls.Add(Me.GrdVT)
        Me.Controls.Add(Me.CboKho)
        Me.Controls.Add(Me.Cboloai)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me.cmdct)
        Me.Controls.Add(Me._txtTon_7)
        Me.Controls.Add(Me.CboDV)
        Me.Controls.Add(Me.Cbo)
        Me.Controls.Add(Me._txtTon_6)
        Me.Controls.Add(Me._txtTon_5)
        Me.Controls.Add(Me._txtTon_4)
        Me.Controls.Add(Me._txtTon_3)
        Me.Controls.Add(Me._txtTon_2)
        Me.Controls.Add(Me._txtTon_1)
        Me.Controls.Add(Me._txtTon_0)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_12)
        Me.Controls.Add(Me._LbTien_1)
        Me.Controls.Add(Me._Label_11)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Label_9)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._LbTien_0)
        Me.Controls.Add(Me._Label_5)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(58, 49)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FVTDauKy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Tồn kho đầu kỳ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializetxtTon()
		Me.txtTon(7) = _txtTon_7
		Me.txtTon(6) = _txtTon_6
		Me.txtTon(5) = _txtTon_5
		Me.txtTon(4) = _txtTon_4
		Me.txtTon(3) = _txtTon_3
		Me.txtTon(2) = _txtTon_2
		Me.txtTon(1) = _txtTon_1
		Me.txtTon(0) = _txtTon_0
	End Sub
	Sub InitializeLbTien()
		Me.LbTien(1) = _LbTien_1
		Me.LbTien(0) = _LbTien_0
	End Sub
	Sub InitializeLabel()
		Me.Label(0) = _Label_0
		Me.Label(12) = _Label_12
		Me.Label(11) = _Label_11
		Me.Label(10) = _Label_10
		Me.Label(9) = _Label_9
		Me.Label(8) = _Label_8
		Me.Label(7) = _Label_7
		Me.Label(6) = _Label_6
		Me.Label(5) = _Label_5
		Me.Label(4) = _Label_4
		Me.Label(3) = _Label_3
		Me.Label(2) = _Label_2
		Me.Label(1) = _Label_1
	End Sub
	Sub InitializeCommand()
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
		Me.Command(3) = _Command_3
	End Sub
#End Region 
End Class
