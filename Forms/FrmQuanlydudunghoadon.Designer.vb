<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuanlydudunghoadon
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
        isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		InitializetxtTon()
		Initializetxt()
		InitializeOpt()
		InitializeMedNgay()
		InitializeLabel()
		InitializeFrame1()
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
	Private WithEvents _Opt_1 As System.Windows.Forms.RadioButton
	Private WithEvents _Opt_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cmdct As System.Windows.Forms.Button
	Public WithEvents GrdVT  As ListviewEx.ListviewExt 
	Private WithEvents _txtTon_7 As System.Windows.Forms.TextBox
	Private WithEvents _txtTon_0 As System.Windows.Forms.TextBox
	Private WithEvents _txtTon_1 As System.Windows.Forms.TextBox
	Private WithEvents _txtTon_2 As System.Windows.Forms.TextBox
	Private WithEvents _txtTon_3 As System.Windows.Forms.TextBox
	Private WithEvents _txtTon_4 As System.Windows.Forms.TextBox
	Private WithEvents _txtTon_5 As System.Windows.Forms.TextBox
	Private WithEvents _txtTon_6 As System.Windows.Forms.TextBox
	Private WithEvents _Label_7 As System.Windows.Forms.Label
	Private WithEvents _Label_4 As System.Windows.Forms.Label
	Private WithEvents _Label_5 As System.Windows.Forms.Label
	Private WithEvents _Label_3 As System.Windows.Forms.Label
	Private WithEvents _Label_2 As System.Windows.Forms.Label
	Private WithEvents _Label_1 As System.Windows.Forms.Label
	Private WithEvents _Label_0 As System.Windows.Forms.Label
	Private WithEvents _Label_6 As System.Windows.Forms.Label
	Private WithEvents _Frame1_1 As System.Windows.Forms.GroupBox
	Public WithEvents Cbo As ComboBoxEx.ComboBoxExt
	Private WithEvents _txt_5 As System.Windows.Forms.TextBox
	Private WithEvents _txt_4 As System.Windows.Forms.TextBox
	Private WithEvents _txt_3 As System.Windows.Forms.TextBox
	Private WithEvents _txt_2 As System.Windows.Forms.TextBox
	Private WithEvents _txt_1 As System.Windows.Forms.TextBox
	Private WithEvents _MedNgay_0 As System.Windows.Forms.MaskedTextBox
	Private WithEvents _MedNgay_1 As System.Windows.Forms.MaskedTextBox
	Private WithEvents _Label_8 As System.Windows.Forms.Label
	Private WithEvents _Label_20 As System.Windows.Forms.Label
	Private WithEvents _Label_19 As System.Windows.Forms.Label
	Private WithEvents _Label_18 As System.Windows.Forms.Label
	Private WithEvents _Label_16 As System.Windows.Forms.Label
	Private WithEvents _Label_15 As System.Windows.Forms.Label
	Private WithEvents _Label_14 As System.Windows.Forms.Label
	Private WithEvents _Label_13 As System.Windows.Forms.Label
	Private WithEvents _Frame1_0 As System.Windows.Forms.GroupBox
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_4 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Public Command(4) As System.Windows.Forms.Button
    Public Frame1(1) As System.Windows.Forms.GroupBox
    Public Label(20) As System.Windows.Forms.Label
    Public MedNgay(1) As System.Windows.Forms.MaskedTextBox
    Public Opt(1) As System.Windows.Forms.RadioButton
    Public txt(5) As System.Windows.Forms.TextBox
    Public txtTon(7) As System.Windows.Forms.TextBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._txtTon_2 = New System.Windows.Forms.TextBox()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me._Opt_1 = New System.Windows.Forms.RadioButton()
        Me._Opt_0 = New System.Windows.Forms.RadioButton()
        Me._Frame1_1 = New System.Windows.Forms.GroupBox()
        Me.GrdVT = New ListViewEx.ListviewExt()
        Me.cmdct = New System.Windows.Forms.Button()
        Me._txtTon_7 = New System.Windows.Forms.TextBox()
        Me._txtTon_0 = New System.Windows.Forms.TextBox()
        Me._txtTon_1 = New System.Windows.Forms.TextBox()
        Me._txtTon_3 = New System.Windows.Forms.TextBox()
        Me._txtTon_4 = New System.Windows.Forms.TextBox()
        Me._txtTon_5 = New System.Windows.Forms.TextBox()
        Me._txtTon_6 = New System.Windows.Forms.TextBox()
        Me._Label_7 = New System.Windows.Forms.Label()
        Me._Label_4 = New System.Windows.Forms.Label()
        Me._Label_5 = New System.Windows.Forms.Label()
        Me._Label_3 = New System.Windows.Forms.Label()
        Me._Label_2 = New System.Windows.Forms.Label()
        Me._Label_1 = New System.Windows.Forms.Label()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me._Label_6 = New System.Windows.Forms.Label()
        Me._Frame1_0 = New System.Windows.Forms.GroupBox()
        Me.Cbo = New ComboBoxEx.ComboBoxExt()
        Me._txt_5 = New System.Windows.Forms.TextBox()
        Me._txt_4 = New System.Windows.Forms.TextBox()
        Me._txt_3 = New System.Windows.Forms.TextBox()
        Me._txt_2 = New System.Windows.Forms.TextBox()
        Me._txt_1 = New System.Windows.Forms.TextBox()
        Me._MedNgay_0 = New System.Windows.Forms.MaskedTextBox()
        Me._MedNgay_1 = New System.Windows.Forms.MaskedTextBox()
        Me._Label_8 = New System.Windows.Forms.Label()
        Me._Label_20 = New System.Windows.Forms.Label()
        Me._Label_19 = New System.Windows.Forms.Label()
        Me._Label_18 = New System.Windows.Forms.Label()
        Me._Label_16 = New System.Windows.Forms.Label()
        Me._Label_15 = New System.Windows.Forms.Label()
        Me._Label_14 = New System.Windows.Forms.Label()
        Me._Label_13 = New System.Windows.Forms.Label()
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._Command_2 = New System.Windows.Forms.Button()
        Me._Command_3 = New System.Windows.Forms.Button()
        Me._Command_4 = New System.Windows.Forms.Button()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me._Label_17 = New System.Windows.Forms.Label()
        Me.Frame2.SuspendLayout()
        Me._Frame1_1.SuspendLayout()
        Me._Frame1_0.SuspendLayout()
        Me.SuspendLayout()
        '
        '_txtTon_2
        '
        Me._txtTon_2.AcceptsReturn = True
        Me._txtTon_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_2.Location = New System.Drawing.Point(320, 256)
        Me._txtTon_2.MaxLength = 0
        Me._txtTon_2.Name = "_txtTon_2"
        Me._txtTon_2.Size = New System.Drawing.Size(121, 20)
        Me._txtTon_2.TabIndex = 13
        Me._txtTon_2.Text = "Enter để chọn"
        Me.ToolTipMain.SetToolTip(Me._txtTon_2, "Enter để chọn")
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.Transparent
        Me.Frame2.Controls.Add(Me._Opt_1)
        Me.Frame2.Controls.Add(Me._Opt_0)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.Color.Blue
        Me.Frame2.Location = New System.Drawing.Point(8, 8)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(321, 49)
        Me.Frame2.TabIndex = 43
        Me.Frame2.TabStop = False
        Me.Frame2.Tag = "Invoice Class"
        Me.Frame2.Text = "Loại hoá đơn quản lý"
        '
        '_Opt_1
        '
        Me._Opt_1.BackColor = System.Drawing.Color.Transparent
        Me._Opt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_1.Location = New System.Drawing.Point(160, 24)
        Me._Opt_1.Name = "_Opt_1"
        Me._Opt_1.Size = New System.Drawing.Size(153, 17)
        Me._Opt_1.TabIndex = 1
        Me._Opt_1.TabStop = True
        Me._Opt_1.Tag = "Loss, fire, failure Invoice"
        Me._Opt_1.Text = "Hoá đơn mất, cháy, hỏng"
        Me._Opt_1.UseVisualStyleBackColor = False
        '
        '_Opt_0
        '
        Me._Opt_0.BackColor = System.Drawing.Color.Transparent
        Me._Opt_0.Checked = True
        Me._Opt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_0.Location = New System.Drawing.Point(8, 24)
        Me._Opt_0.Name = "_Opt_0"
        Me._Opt_0.Size = New System.Drawing.Size(105, 17)
        Me._Opt_0.TabIndex = 0
        Me._Opt_0.TabStop = True
        Me._Opt_0.Tag = "Canceled Invoice"
        Me._Opt_0.Text = "Hoá đơn huỷ"
        Me._Opt_0.UseVisualStyleBackColor = False
        '
        '_Frame1_1
        '
        Me._Frame1_1.BackColor = System.Drawing.Color.Transparent
        Me._Frame1_1.Controls.Add(Me.GrdVT)
        Me._Frame1_1.Controls.Add(Me.cmdct)
        Me._Frame1_1.Controls.Add(Me._txtTon_7)
        Me._Frame1_1.Controls.Add(Me._txtTon_0)
        Me._Frame1_1.Controls.Add(Me._txtTon_1)
        Me._Frame1_1.Controls.Add(Me._txtTon_2)
        Me._Frame1_1.Controls.Add(Me._txtTon_3)
        Me._Frame1_1.Controls.Add(Me._txtTon_4)
        Me._Frame1_1.Controls.Add(Me._txtTon_5)
        Me._Frame1_1.Controls.Add(Me._txtTon_6)
        Me._Frame1_1.Controls.Add(Me._Label_7)
        Me._Frame1_1.Controls.Add(Me._Label_4)
        Me._Frame1_1.Controls.Add(Me._Label_5)
        Me._Frame1_1.Controls.Add(Me._Label_3)
        Me._Frame1_1.Controls.Add(Me._Label_2)
        Me._Frame1_1.Controls.Add(Me._Label_1)
        Me._Frame1_1.Controls.Add(Me._Label_0)
        Me._Frame1_1.Controls.Add(Me._Label_6)
        Me._Frame1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame1_1.ForeColor = System.Drawing.Color.Blue
        Me._Frame1_1.Location = New System.Drawing.Point(8, 233)
        Me._Frame1_1.Name = "_Frame1_1"
        Me._Frame1_1.Size = New System.Drawing.Size(1001, 289)
        Me._Frame1_1.TabIndex = 26
        Me._Frame1_1.TabStop = False
        Me._Frame1_1.Tag = "Information detail"
        Me._Frame1_1.Text = "Thông tin chi tiết"
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
        Me.GrdVT.Location = New System.Drawing.Point(8, 40)
        Me.GrdVT.Name = "GrdVT"
        Me.GrdVT.Row = 0
        Me.GrdVT.Rows = 0
        Me.GrdVT.Selectable = True
        Me.GrdVT.SelectedTextColor = System.Drawing.Color.White
        Me.GrdVT.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.GrdVT.ShowBorder = True
        Me.GrdVT.ShowFocusRect = False
        Me.GrdVT.Size = New System.Drawing.Size(985, 217)
        Me.GrdVT.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdVT.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdVT.TabIndex = 10
        '
        'cmdct
        '
        Me.cmdct.BackColor = System.Drawing.SystemColors.Control
        Me.cmdct.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdct.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdct.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_addtogrid
        Me.cmdct.Location = New System.Drawing.Point(976, 256)
        Me.cmdct.Name = "cmdct"
        Me.cmdct.Size = New System.Drawing.Size(18, 21)
        Me.cmdct.TabIndex = 19
        Me.cmdct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdct.UseVisualStyleBackColor = False
        '
        '_txtTon_7
        '
        Me._txtTon_7.AcceptsReturn = True
        Me._txtTon_7.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_7.Location = New System.Drawing.Point(872, 256)
        Me._txtTon_7.MaxLength = 0
        Me._txtTon_7.Name = "_txtTon_7"
        Me._txtTon_7.Size = New System.Drawing.Size(104, 20)
        Me._txtTon_7.TabIndex = 18
        '
        '_txtTon_0
        '
        Me._txtTon_0.AcceptsReturn = True
        Me._txtTon_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_0.Location = New System.Drawing.Point(8, 256)
        Me._txtTon_0.MaxLength = 0
        Me._txtTon_0.Name = "_txtTon_0"
        Me._txtTon_0.ReadOnly = True
        Me._txtTon_0.Size = New System.Drawing.Size(193, 20)
        Me._txtTon_0.TabIndex = 11
        Me._txtTon_0.TabStop = False
        '
        '_txtTon_1
        '
        Me._txtTon_1.AcceptsReturn = True
        Me._txtTon_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_1.Location = New System.Drawing.Point(200, 256)
        Me._txtTon_1.MaxLength = 0
        Me._txtTon_1.Name = "_txtTon_1"
        Me._txtTon_1.ReadOnly = True
        Me._txtTon_1.Size = New System.Drawing.Size(121, 20)
        Me._txtTon_1.TabIndex = 12
        Me._txtTon_1.TabStop = False
        '
        '_txtTon_3
        '
        Me._txtTon_3.AcceptsReturn = True
        Me._txtTon_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_3.Location = New System.Drawing.Point(440, 256)
        Me._txtTon_3.MaxLength = 0
        Me._txtTon_3.Name = "_txtTon_3"
        Me._txtTon_3.Size = New System.Drawing.Size(121, 20)
        Me._txtTon_3.TabIndex = 14
        Me._txtTon_3.Text = "0"
        '
        '_txtTon_4
        '
        Me._txtTon_4.AcceptsReturn = True
        Me._txtTon_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_4.Location = New System.Drawing.Point(560, 256)
        Me._txtTon_4.MaxLength = 0
        Me._txtTon_4.Name = "_txtTon_4"
        Me._txtTon_4.Size = New System.Drawing.Size(121, 20)
        Me._txtTon_4.TabIndex = 15
        Me._txtTon_4.Text = "0"
        '
        '_txtTon_5
        '
        Me._txtTon_5.AcceptsReturn = True
        Me._txtTon_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_5.Location = New System.Drawing.Point(680, 256)
        Me._txtTon_5.MaxLength = 0
        Me._txtTon_5.Name = "_txtTon_5"
        Me._txtTon_5.Size = New System.Drawing.Size(97, 20)
        Me._txtTon_5.TabIndex = 16
        Me._txtTon_5.Text = "0"
        Me._txtTon_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtTon_6
        '
        Me._txtTon_6.AcceptsReturn = True
        Me._txtTon_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_6.Location = New System.Drawing.Point(776, 256)
        Me._txtTon_6.MaxLength = 0
        Me._txtTon_6.Name = "_txtTon_6"
        Me._txtTon_6.Size = New System.Drawing.Size(97, 20)
        Me._txtTon_6.TabIndex = 17
        Me._txtTon_6.Text = "0"
        Me._txtTon_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(872, 24)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(105, 17)
        Me._Label_7.TabIndex = 42
        Me._Label_7.Tag = "Notes"
        Me._Label_7.Text = "Ghi chú"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(440, 24)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(121, 17)
        Me._Label_4.TabIndex = 36
        Me._Label_4.Tag = "From"
        Me._Label_4.Text = "Từ Số"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.Color.Black
        Me._Label_5.Location = New System.Drawing.Point(560, 24)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(121, 17)
        Me._Label_5.TabIndex = 35
        Me._Label_5.Tag = "To"
        Me._Label_5.Text = "Đến số"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.Black
        Me._Label_3.Location = New System.Drawing.Point(680, 24)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(97, 17)
        Me._Label_3.TabIndex = 34
        Me._Label_3.Tag = "Quantity"
        Me._Label_3.Text = "Số lượng"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.Black
        Me._Label_2.Location = New System.Drawing.Point(320, 24)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(121, 17)
        Me._Label_2.TabIndex = 33
        Me._Label_2.Tag = "Notation"
        Me._Label_2.Text = "Ký hiệu"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(200, 24)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(121, 17)
        Me._Label_1.TabIndex = 32
        Me._Label_1.Tag = "Form"
        Me._Label_1.Text = "Mẫu số"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.Color.Black
        Me._Label_0.Location = New System.Drawing.Point(8, 24)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(193, 17)
        Me._Label_0.TabIndex = 31
        Me._Label_0.Tag = "Class name"
        Me._Label_0.Text = "Tên loại hoá đơn"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.Color.Black
        Me._Label_6.Location = New System.Drawing.Point(776, 24)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(97, 17)
        Me._Label_6.TabIndex = 37
        Me._Label_6.Tag = "Copy"
        Me._Label_6.Text = "Liên"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Frame1_0
        '
        Me._Frame1_0.BackColor = System.Drawing.Color.Transparent
        Me._Frame1_0.Controls.Add(Me.Cbo)
        Me._Frame1_0.Controls.Add(Me._txt_5)
        Me._Frame1_0.Controls.Add(Me._txt_4)
        Me._Frame1_0.Controls.Add(Me._txt_3)
        Me._Frame1_0.Controls.Add(Me._txt_2)
        Me._Frame1_0.Controls.Add(Me._txt_1)
        Me._Frame1_0.Controls.Add(Me._MedNgay_0)
        Me._Frame1_0.Controls.Add(Me._MedNgay_1)
        Me._Frame1_0.Controls.Add(Me._Label_8)
        Me._Frame1_0.Controls.Add(Me._Label_20)
        Me._Frame1_0.Controls.Add(Me._Label_19)
        Me._Frame1_0.Controls.Add(Me._Label_18)
        Me._Frame1_0.Controls.Add(Me._Label_16)
        Me._Frame1_0.Controls.Add(Me._Label_15)
        Me._Frame1_0.Controls.Add(Me._Label_14)
        Me._Frame1_0.Controls.Add(Me._Label_13)
        Me._Frame1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame1_0.ForeColor = System.Drawing.Color.Blue
        Me._Frame1_0.Location = New System.Drawing.Point(8, 64)
        Me._Frame1_0.Name = "_Frame1_0"
        Me._Frame1_0.Size = New System.Drawing.Size(1001, 170)
        Me._Frame1_0.TabIndex = 25
        Me._Frame1_0.TabStop = False
        Me._Frame1_0.Tag = "Common information"
        Me._Frame1_0.Text = "Thông tin chung"
        '
        'Cbo
        '
        Me.Cbo.BackColor = System.Drawing.SystemColors.Window
        Me.Cbo.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cbo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.Cbo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo.Location = New System.Drawing.Point(208, 20)
        Me.Cbo.Name = "Cbo"
        Me.Cbo.Size = New System.Drawing.Size(121, 21)
        Me.Cbo.TabIndex = 2
        Me.Cbo.Text = "Cbo"
        '
        '_txt_5
        '
        Me._txt_5.AcceptsReturn = True
        Me._txt_5.BackColor = System.Drawing.SystemColors.Window
        Me._txt_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_5.Location = New System.Drawing.Point(208, 144)
        Me._txt_5.MaxLength = 0
        Me._txt_5.Name = "_txt_5"
        Me._txt_5.Size = New System.Drawing.Size(785, 20)
        Me._txt_5.TabIndex = 9
        '
        '_txt_4
        '
        Me._txt_4.AcceptsReturn = True
        Me._txt_4.BackColor = System.Drawing.SystemColors.Window
        Me._txt_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_4.Location = New System.Drawing.Point(208, 120)
        Me._txt_4.MaxLength = 0
        Me._txt_4.Name = "_txt_4"
        Me._txt_4.Size = New System.Drawing.Size(113, 20)
        Me._txt_4.TabIndex = 7
        '
        '_txt_3
        '
        Me._txt_3.AcceptsReturn = True
        Me._txt_3.BackColor = System.Drawing.SystemColors.Window
        Me._txt_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_3.Location = New System.Drawing.Point(208, 96)
        Me._txt_3.MaxLength = 0
        Me._txt_3.Name = "_txt_3"
        Me._txt_3.Size = New System.Drawing.Size(785, 20)
        Me._txt_3.TabIndex = 6
        '
        '_txt_2
        '
        Me._txt_2.AcceptsReturn = True
        Me._txt_2.BackColor = System.Drawing.SystemColors.Window
        Me._txt_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_2.Location = New System.Drawing.Point(208, 72)
        Me._txt_2.MaxLength = 0
        Me._txt_2.Name = "_txt_2"
        Me._txt_2.Size = New System.Drawing.Size(785, 20)
        Me._txt_2.TabIndex = 5
        '
        '_txt_1
        '
        Me._txt_1.AcceptsReturn = True
        Me._txt_1.BackColor = System.Drawing.SystemColors.Window
        Me._txt_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_1.Location = New System.Drawing.Point(208, 48)
        Me._txt_1.MaxLength = 0
        Me._txt_1.Name = "_txt_1"
        Me._txt_1.Size = New System.Drawing.Size(785, 20)
        Me._txt_1.TabIndex = 4
        '
        '_MedNgay_0
        '
        Me._MedNgay_0.AllowPromptAsInput = False
        Me._MedNgay_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_0.Location = New System.Drawing.Point(416, 24)
        Me._MedNgay_0.Mask = "00/00/0000"
        Me._MedNgay_0.Name = "_MedNgay_0"
        Me._MedNgay_0.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_0.TabIndex = 3
        '
        '_MedNgay_1
        '
        Me._MedNgay_1.AllowPromptAsInput = False
        Me._MedNgay_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_1.Location = New System.Drawing.Point(416, 120)
        Me._MedNgay_1.Mask = "00/00/0000"
        Me._MedNgay_1.Name = "_MedNgay_1"
        Me._MedNgay_1.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_1.TabIndex = 8
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.Transparent
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_8.Location = New System.Drawing.Point(8, 144)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(201, 17)
        Me._Label_8.TabIndex = 44
        Me._Label_8.Tag = "Method of destruction"
        Me._Label_8.Text = "Phương pháp huỷ"
        '
        '_Label_20
        '
        Me._Label_20.BackColor = System.Drawing.Color.Transparent
        Me._Label_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_20.Location = New System.Drawing.Point(8, 120)
        Me._Label_20.Name = "_Label_20"
        Me._Label_20.Size = New System.Drawing.Size(201, 17)
        Me._Label_20.TabIndex = 41
        Me._Label_20.Tag = "At"
        Me._Label_20.Text = "Lúc"
        '
        '_Label_19
        '
        Me._Label_19.BackColor = System.Drawing.Color.Transparent
        Me._Label_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_19.Location = New System.Drawing.Point(352, 120)
        Me._Label_19.Name = "_Label_19"
        Me._Label_19.Size = New System.Drawing.Size(57, 17)
        Me._Label_19.TabIndex = 40
        Me._Label_19.Tag = "Date"
        Me._Label_19.Text = "Ngày "
        '
        '_Label_18
        '
        Me._Label_18.BackColor = System.Drawing.Color.Transparent
        Me._Label_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_18.Location = New System.Drawing.Point(8, 96)
        Me._Label_18.Name = "_Label_18"
        Me._Label_18.Size = New System.Drawing.Size(201, 17)
        Me._Label_18.TabIndex = 39
        Me._Label_18.Tag = "Representative"
        Me._Label_18.Text = "Đại diện theo pháp luật"
        '
        '_Label_16
        '
        Me._Label_16.BackColor = System.Drawing.Color.Transparent
        Me._Label_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_16.Location = New System.Drawing.Point(8, 72)
        Me._Label_16.Name = "_Label_16"
        Me._Label_16.Size = New System.Drawing.Size(201, 17)
        Me._Label_16.TabIndex = 30
        Me._Label_16.Tag = "Loss, fire, failure Reason"
        Me._Label_16.Text = "Lý do mất, cháy, hỏng"
        '
        '_Label_15
        '
        Me._Label_15.BackColor = System.Drawing.Color.Transparent
        Me._Label_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_15.Location = New System.Drawing.Point(8, 48)
        Me._Label_15.Name = "_Label_15"
        Me._Label_15.Size = New System.Drawing.Size(201, 17)
        Me._Label_15.TabIndex = 29
        Me._Label_15.Tag = "Object detetion"
        Me._Label_15.Text = "Đối tượng phát hiện"
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.Color.Transparent
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_14.Location = New System.Drawing.Point(352, 24)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(57, 17)
        Me._Label_14.TabIndex = 28
        Me._Label_14.Tag = "Date"
        Me._Label_14.Text = "Ngày lập"
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.Transparent
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_13.Location = New System.Drawing.Point(8, 24)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(201, 17)
        Me._Label_13.TabIndex = 27
        Me._Label_13.Tag = "Code"
        Me._Label_13.Text = "Số "
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Save
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(776, 525)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 22
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_2
        '
        Me._Command_2.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Xoa
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(856, 525)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 23
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_3
        '
        Me._Command_3.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(936, 524)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 24
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_Command_4
        '
        Me._Command_4.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Preview
        Me._Command_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_4.Location = New System.Drawing.Point(616, 525)
        Me._Command_4.Name = "_Command_4"
        Me._Command_4.Size = New System.Drawing.Size(73, 25)
        Me._Command_4.TabIndex = 20
        Me._Command_4.Tag = "Preview"
        Me._Command_4.Text = "&Xem"
        '
        '_Command_0
        '
        Me._Command_0.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Add
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(696, 525)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 21
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.ForeColor = System.Drawing.Color.Black
        Me._Label_17.Location = New System.Drawing.Point(336, 8)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(353, 20)
        Me._Label_17.TabIndex = 38
        Me._Label_17.Tag = "Canceled Invoice"
        Me._Label_17.Text = "Hoá đơn huỷ"
        Me._Label_17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmQuanlydudunghoadon
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1018, 553)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me._Frame1_1)
        Me.Controls.Add(Me._Frame1_0)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_4)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Label_17)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmQuanlydudunghoadon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Canceled Invoice"
        Me.Text = "Hoá đơn huỷ"
        Me.Frame2.ResumeLayout(False)
        Me._Frame1_1.ResumeLayout(False)
        Me._Frame1_1.PerformLayout()
        Me._Frame1_0.ResumeLayout(False)
        Me._Frame1_0.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
	Sub InitializetxtTon()
		Me.txtTon(7) = _txtTon_7
		Me.txtTon(0) = _txtTon_0
		Me.txtTon(1) = _txtTon_1
		Me.txtTon(2) = _txtTon_2
		Me.txtTon(3) = _txtTon_3
		Me.txtTon(4) = _txtTon_4
		Me.txtTon(5) = _txtTon_5
		Me.txtTon(6) = _txtTon_6
	End Sub
	Sub Initializetxt()
		Me.txt(5) = _txt_5
		Me.txt(4) = _txt_4
		Me.txt(3) = _txt_3
		Me.txt(2) = _txt_2
		Me.txt(1) = _txt_1
	End Sub
	Sub InitializeOpt()
		Me.Opt(1) = _Opt_1
		Me.Opt(0) = _Opt_0
	End Sub
	Sub InitializeMedNgay()
		Me.MedNgay(0) = _MedNgay_0
		Me.MedNgay(1) = _MedNgay_1
	End Sub
	Sub InitializeLabel()
		Me.Label(7) = _Label_7
		Me.Label(4) = _Label_4
		Me.Label(5) = _Label_5
		Me.Label(3) = _Label_3
		Me.Label(2) = _Label_2
		Me.Label(1) = _Label_1
		Me.Label(0) = _Label_0
		Me.Label(6) = _Label_6
		Me.Label(8) = _Label_8
		Me.Label(20) = _Label_20
		Me.Label(19) = _Label_19
		Me.Label(18) = _Label_18
		Me.Label(16) = _Label_16
		Me.Label(15) = _Label_15
		Me.Label(14) = _Label_14
		Me.Label(13) = _Label_13
		Me.Label(17) = _Label_17
	End Sub
	Sub InitializeFrame1()
		Me.Frame1(1) = _Frame1_1
		Me.Frame1(0) = _Frame1_0
	End Sub
	Sub InitializeCommand()
		Me.Command(1) = _Command_1
		Me.Command(2) = _Command_2
		Me.Command(3) = _Command_3
		Me.Command(4) = _Command_4
		Me.Command(0) = _Command_0
	End Sub
#End Region 
End Class
