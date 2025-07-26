<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDuphong
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeLbDuphong()
		InitializeLabel1()
		InitializeCommand1()
		InitializeCommand()
		InitializeChk()
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
    Public WithEvents cmdghi As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Chk_1 As System.Windows.Forms.CheckBox
    Private WithEvents _Chk_0 As System.Windows.Forms.CheckBox
    Private WithEvents _Cbo_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Cbo_0 As ComboBoxEx.ComboBoxExt
    Public WithEvents CboThang As ComboBoxEx.ComboBoxExt
    Public WithEvents txtGia As System.Windows.Forms.TextBox
    Public WithEvents GrdGia As ListViewEx.ListviewExt
    Private WithEvents _LbDuphong_0 As System.Windows.Forms.Label
    Private WithEvents _LbDuphong_1 As System.Windows.Forms.Label
    Private WithEvents _LbDuphong_2 As System.Windows.Forms.Label
    Private WithEvents _LbDuphong_3 As System.Windows.Forms.Label
    Private WithEvents _LbDuphong_4 As System.Windows.Forms.Label
    Private WithEvents _Label1_1 As System.Windows.Forms.Label
    Private WithEvents _Label1_3 As System.Windows.Forms.Label
    Private WithEvents _Label1_4 As System.Windows.Forms.Label
    Private WithEvents _Label1_5 As System.Windows.Forms.Label
    Private WithEvents _Label1_6 As System.Windows.Forms.Label
    Private WithEvents _Label1_7 As System.Windows.Forms.Label
    Private WithEvents _Label1_8 As System.Windows.Forms.Label
    Private WithEvents _Label1_9 As System.Windows.Forms.Label
    Public Cbo(1) As ComboBoxEx.ComboBoxExt
    Public Chk(1) As System.Windows.Forms.CheckBox
    Public Command(3) As System.Windows.Forms.Button
    Public Command1(3) As System.Windows.Forms.Button
    Public Label1(9) As System.Windows.Forms.Label
    Public LbDuphong(4) As System.Windows.Forms.Label
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'Private listBoxComboBoxHelper1 As Artinsoft.VB6.Gui.ListControlHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdghi = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Chk_1 = New System.Windows.Forms.CheckBox
        Me._Chk_0 = New System.Windows.Forms.CheckBox
        Me._Cbo_1 = New ComboBoxEx.ComboBoxExt
        Me._Cbo_0 = New ComboBoxEx.ComboBoxExt
        Me.CboThang = New ComboBoxEx.ComboBoxExt
        Me.txtGia = New System.Windows.Forms.TextBox
        Me._LbDuphong_0 = New System.Windows.Forms.Label
        Me._LbDuphong_1 = New System.Windows.Forms.Label
        Me._LbDuphong_2 = New System.Windows.Forms.Label
        Me._LbDuphong_3 = New System.Windows.Forms.Label
        Me._LbDuphong_4 = New System.Windows.Forms.Label
        Me._Label1_1 = New System.Windows.Forms.Label
        Me._Label1_3 = New System.Windows.Forms.Label
        Me._Label1_4 = New System.Windows.Forms.Label
        Me._Label1_5 = New System.Windows.Forms.Label
        Me._Label1_6 = New System.Windows.Forms.Label
        Me._Label1_7 = New System.Windows.Forms.Label
        Me._Label1_8 = New System.Windows.Forms.Label
        Me._Label1_9 = New System.Windows.Forms.Label
        Me.GrdGia = New ListViewEx.ListviewExt
        Me.SuspendLayout()
        '
        'cmdghi
        '
        Me.cmdghi.BackColor = System.Drawing.SystemColors.Control
        Me.cmdghi.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdghi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdghi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdghi.Location = New System.Drawing.Point(546, 416)
        Me.cmdghi.Name = "cmdghi"
        Me.cmdghi.Size = New System.Drawing.Size(17, 19)
        Me.cmdghi.TabIndex = 7
        Me.cmdghi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdghi.UseVisualStyleBackColor = False
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.list16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(318, 441)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 28
        Me._Command_3.Tag = "Listed"
        Me._Command_3.Text = "&Liệt kê"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(558, 441)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 27
        Me._Command_2.Tag = "Return"
        Me._Command_2.Text = "Trở &về"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.print16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(478, 441)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 26
        Me._Command_1.Tag = "Print"
        Me._Command_1.Text = "&In"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.report16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(398, 441)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 25
        Me._Command_0.Tag = "Preview"
        Me._Command_0.Text = "&Xem"
        '
        '_Chk_1
        '
        Me._Chk_1.BackColor = System.Drawing.Color.Transparent
        Me._Chk_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_1.Location = New System.Drawing.Point(304, 32)
        Me._Chk_1.Name = "_Chk_1"
        Me._Chk_1.Size = New System.Drawing.Size(105, 17)
        Me._Chk_1.TabIndex = 3
        Me._Chk_1.Tag = "Inventory Class"
        Me._Chk_1.Text = "Phân loại vật tư"
        Me._Chk_1.UseVisualStyleBackColor = False
        '
        '_Chk_0
        '
        Me._Chk_0.BackColor = System.Drawing.Color.Transparent
        Me._Chk_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_0.Location = New System.Drawing.Point(304, 8)
        Me._Chk_0.Name = "_Chk_0"
        Me._Chk_0.Size = New System.Drawing.Size(89, 17)
        Me._Chk_0.TabIndex = 1
        Me._Chk_0.Tag = "Store"
        Me._Chk_0.Text = "Lập cho kho"
        Me._Chk_0.UseVisualStyleBackColor = False
        '
        '_Cbo_1
        '
        Me._Cbo_1.BackColor = System.Drawing.SystemColors.Window
        Me._Cbo_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Cbo_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Cbo_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Cbo_1.DropDownWidth = 36
        Me._Cbo_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cbo_1.Location = New System.Drawing.Point(416, 32)
        Me._Cbo_1.Name = "_Cbo_1"
        Me._Cbo_1.Size = New System.Drawing.Size(217, 21)
        Me._Cbo_1.TabIndex = 4
        '
        '_Cbo_0
        '
        Me._Cbo_0.BackColor = System.Drawing.SystemColors.Window
        Me._Cbo_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Cbo_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Cbo_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Cbo_0.DropDownWidth = 36
        Me._Cbo_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cbo_0.Location = New System.Drawing.Point(416, 8)
        Me._Cbo_0.Name = "_Cbo_0"
        Me._Cbo_0.Size = New System.Drawing.Size(217, 21)
        Me._Cbo_0.TabIndex = 2
        '
        'CboThang
        '
        Me.CboThang.BackColor = System.Drawing.SystemColors.Window
        Me.CboThang.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboThang.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboThang.Location = New System.Drawing.Point(56, 8)
        Me.CboThang.Name = "CboThang"
        Me.CboThang.Size = New System.Drawing.Size(73, 21)
        Me.CboThang.TabIndex = 0
        '
        'txtGia
        '
        Me.txtGia.AcceptsReturn = True
        Me.txtGia.BackColor = System.Drawing.SystemColors.Window
        Me.txtGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGia.ForeColor = System.Drawing.Color.Blue
        Me.txtGia.Location = New System.Drawing.Point(464, 416)
        Me.txtGia.MaxLength = 0
        Me.txtGia.Multiline = True
        Me.txtGia.Name = "txtGia"
        Me.txtGia.Size = New System.Drawing.Size(81, 19)
        Me.txtGia.TabIndex = 6
        Me.txtGia.Text = "0"
        Me.txtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_LbDuphong_0
        '
        Me._LbDuphong_0.BackColor = System.Drawing.SystemColors.Window
        Me._LbDuphong_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbDuphong_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbDuphong_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbDuphong_0.Location = New System.Drawing.Point(8, 416)
        Me._LbDuphong_0.Name = "_LbDuphong_0"
        Me._LbDuphong_0.Size = New System.Drawing.Size(89, 19)
        Me._LbDuphong_0.TabIndex = 12
        Me._LbDuphong_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_LbDuphong_1
        '
        Me._LbDuphong_1.BackColor = System.Drawing.SystemColors.Window
        Me._LbDuphong_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbDuphong_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbDuphong_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbDuphong_1.Location = New System.Drawing.Point(96, 416)
        Me._LbDuphong_1.Name = "_LbDuphong_1"
        Me._LbDuphong_1.Size = New System.Drawing.Size(153, 19)
        Me._LbDuphong_1.TabIndex = 13
        '
        '_LbDuphong_2
        '
        Me._LbDuphong_2.BackColor = System.Drawing.SystemColors.Window
        Me._LbDuphong_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbDuphong_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbDuphong_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbDuphong_2.Location = New System.Drawing.Point(248, 416)
        Me._LbDuphong_2.Name = "_LbDuphong_2"
        Me._LbDuphong_2.Size = New System.Drawing.Size(57, 19)
        Me._LbDuphong_2.TabIndex = 14
        Me._LbDuphong_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_LbDuphong_3
        '
        Me._LbDuphong_3.BackColor = System.Drawing.SystemColors.Window
        Me._LbDuphong_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbDuphong_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbDuphong_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbDuphong_3.Location = New System.Drawing.Point(304, 416)
        Me._LbDuphong_3.Name = "_LbDuphong_3"
        Me._LbDuphong_3.Size = New System.Drawing.Size(81, 19)
        Me._LbDuphong_3.TabIndex = 15
        Me._LbDuphong_3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbDuphong_4
        '
        Me._LbDuphong_4.BackColor = System.Drawing.SystemColors.Window
        Me._LbDuphong_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbDuphong_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbDuphong_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbDuphong_4.Location = New System.Drawing.Point(384, 416)
        Me._LbDuphong_4.Name = "_LbDuphong_4"
        Me._LbDuphong_4.Size = New System.Drawing.Size(81, 19)
        Me._LbDuphong_4.TabIndex = 16
        Me._LbDuphong_4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.Color.Transparent
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(8, 8)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.Size = New System.Drawing.Size(41, 17)
        Me._Label1_1.TabIndex = 24
        Me._Label1_1.Tag = "Month"
        Me._Label1_1.Text = "Tháng"
        '
        '_Label1_3
        '
        Me._Label1_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label1_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_3.ForeColor = System.Drawing.Color.Black
        Me._Label1_3.Location = New System.Drawing.Point(96, 61)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.Size = New System.Drawing.Size(153, 17)
        Me._Label1_3.TabIndex = 23
        Me._Label1_3.Tag = "Description"
        Me._Label1_3.Text = "Tên vật tư"
        Me._Label1_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_4
        '
        Me._Label1_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label1_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_4.ForeColor = System.Drawing.Color.Black
        Me._Label1_4.Location = New System.Drawing.Point(248, 61)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.Size = New System.Drawing.Size(57, 17)
        Me._Label1_4.TabIndex = 22
        Me._Label1_4.Tag = "Unit"
        Me._Label1_4.Text = "Đ.v.t"
        Me._Label1_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_5
        '
        Me._Label1_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label1_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_5.ForeColor = System.Drawing.Color.Black
        Me._Label1_5.Location = New System.Drawing.Point(384, 61)
        Me._Label1_5.Name = "_Label1_5"
        Me._Label1_5.Size = New System.Drawing.Size(81, 17)
        Me._Label1_5.TabIndex = 21
        Me._Label1_5.Tag = "Unit price"
        Me._Label1_5.Text = "Đơn giá"
        Me._Label1_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_6
        '
        Me._Label1_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label1_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label1_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_6.ForeColor = System.Drawing.Color.Black
        Me._Label1_6.Location = New System.Drawing.Point(464, 61)
        Me._Label1_6.Name = "_Label1_6"
        Me._Label1_6.Size = New System.Drawing.Size(81, 17)
        Me._Label1_6.TabIndex = 20
        Me._Label1_6.Tag = "Real Price"
        Me._Label1_6.Text = "Đơn giá Thực tế"
        Me._Label1_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_7
        '
        Me._Label1_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label1_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label1_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_7.ForeColor = System.Drawing.Color.Black
        Me._Label1_7.Location = New System.Drawing.Point(8, 61)
        Me._Label1_7.Name = "_Label1_7"
        Me._Label1_7.Size = New System.Drawing.Size(89, 17)
        Me._Label1_7.TabIndex = 19
        Me._Label1_7.Tag = "Code"
        Me._Label1_7.Text = "Số hiệu vật tư"
        Me._Label1_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_8
        '
        Me._Label1_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label1_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label1_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_8.ForeColor = System.Drawing.Color.Black
        Me._Label1_8.Location = New System.Drawing.Point(544, 61)
        Me._Label1_8.Name = "_Label1_8"
        Me._Label1_8.Size = New System.Drawing.Size(87, 17)
        Me._Label1_8.TabIndex = 18
        Me._Label1_8.Tag = "Difference"
        Me._Label1_8.Text = "Chênh lệch"
        Me._Label1_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_9
        '
        Me._Label1_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label1_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label1_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_9.ForeColor = System.Drawing.Color.Black
        Me._Label1_9.Location = New System.Drawing.Point(304, 61)
        Me._Label1_9.Name = "_Label1_9"
        Me._Label1_9.Size = New System.Drawing.Size(81, 17)
        Me._Label1_9.TabIndex = 17
        Me._Label1_9.Tag = "Quantity"
        Me._Label1_9.Text = "Số lượng tồn"
        Me._Label1_9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GrdGia
        '
        Me.GrdGia.AllowColumnResize = True
        Me.GrdGia.AllowMultiselect = False
        Me.GrdGia.AlternateBackground = System.Drawing.Color.DarkGreen
        Me.GrdGia.AlternatingColors = False
        Me.GrdGia.AutoHeight = True
        Me.GrdGia.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdGia.BackgroundStretchToFit = True
        Me.GrdGia.Col = 0
        Me.GrdGia.Cols = 0
        Me.GrdGia.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me.GrdGia.FullRowSelect = True
        Me.GrdGia.GridColor = System.Drawing.Color.LightGray
        Me.GrdGia.GridLines = ListViewEx.GLGridLines.gridBoth
        Me.GrdGia.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me.GrdGia.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me.GrdGia.HeaderHeight = 22
        Me.GrdGia.HeaderVisible = True
        Me.GrdGia.HeaderWordWrap = False
        Me.GrdGia.HotColumnTracking = False
        Me.GrdGia.HotItemTracking = False
        Me.GrdGia.HotTrackingColor = System.Drawing.Color.LightGray
        Me.GrdGia.HoverEvents = False
        Me.GrdGia.HoverTime = 1
        Me.GrdGia.ImageList = Nothing
        Me.GrdGia.ItemHeight = 18
        Me.GrdGia.ItemWordWrap = False
        Me.GrdGia.Location = New System.Drawing.Point(8, 77)
        Me.GrdGia.Name = "GrdGia"
        Me.GrdGia.Row = 0
        Me.GrdGia.Rows = 0
        Me.GrdGia.Selectable = True
        Me.GrdGia.SelectedTextColor = System.Drawing.Color.White
        Me.GrdGia.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.GrdGia.ShowBorder = True
        Me.GrdGia.ShowFocusRect = False
        Me.GrdGia.Size = New System.Drawing.Size(623, 340)
        Me.GrdGia.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdGia.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdGia.TabIndex = 10
        '
        'FrmDuphong
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(640, 472)
        Me.Controls.Add(Me.GrdGia)
        Me.Controls.Add(Me.cmdghi)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Chk_1)
        Me.Controls.Add(Me._Chk_0)
        Me.Controls.Add(Me._Cbo_1)
        Me.Controls.Add(Me._Cbo_0)
        Me.Controls.Add(Me.CboThang)
        Me.Controls.Add(Me.txtGia)
        Me.Controls.Add(Me._LbDuphong_0)
        Me.Controls.Add(Me._LbDuphong_1)
        Me.Controls.Add(Me._LbDuphong_2)
        Me.Controls.Add(Me._LbDuphong_3)
        Me.Controls.Add(Me._LbDuphong_4)
        Me.Controls.Add(Me._Label1_1)
        Me.Controls.Add(Me._Label1_3)
        Me.Controls.Add(Me._Label1_4)
        Me.Controls.Add(Me._Label1_5)
        Me.Controls.Add(Me._Label1_6)
        Me.Controls.Add(Me._Label1_7)
        Me.Controls.Add(Me._Label1_8)
        Me.Controls.Add(Me._Label1_9)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(13, 47)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDuphong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Provision for decreasing stock "
        Me.Text = "Dự phòng giảm giá hàng tồn kho"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializeLbDuphong()
		Me.LbDuphong(0) = _LbDuphong_0
		Me.LbDuphong(1) = _LbDuphong_1
		Me.LbDuphong(2) = _LbDuphong_2
		Me.LbDuphong(3) = _LbDuphong_3
		Me.LbDuphong(4) = _LbDuphong_4
	End Sub
	Sub InitializeLabel1()
		Me.Label1(1) = _Label1_1
		Me.Label1(3) = _Label1_3
		Me.Label1(4) = _Label1_4
		Me.Label1(5) = _Label1_5
		Me.Label1(6) = _Label1_6
		Me.Label1(7) = _Label1_7
		Me.Label1(8) = _Label1_8
		Me.Label1(9) = _Label1_9
	End Sub
	Sub InitializeCommand1()
        'Me.Command1(2) = _Command1_2
        'Me.Command1(1) = _Command1_1
        'Me.Command1(0) = _Command1_0
        'Me.Command1(3) = _Command1_3
	End Sub
	Sub InitializeCommand()
		Me.Command(3) = _Command_3
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
	Sub InitializeChk()
		Me.Chk(1) = _Chk_1
		Me.Chk(0) = _Chk_0
	End Sub
	Sub InitializeCbo()
		Me.Cbo(1) = _Cbo_1
		Me.Cbo(0) = _Cbo_0
	End Sub
#End Region 
End Class
