<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuyetdinhapdunghoadontuin
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializetxtTon()
		Initializetxt()
		Initializecmdct()
		InitializeMedNgay()
		InitializeLabel()
		InitializeGrdVT()
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
	Private WithEvents _cmdct_2 As System.Windows.Forms.Button
	Private WithEvents _txtTon_5 As System.Windows.Forms.TextBox
	Private WithEvents _txtTon_6 As System.Windows.Forms.TextBox
    Private WithEvents _GrdVT_2  As ListviewEx.ListviewExt 
	Private WithEvents _Label_7 As System.Windows.Forms.Label
	Private WithEvents _Label_6 As System.Windows.Forms.Label
	Private WithEvents _Frame1_3 As System.Windows.Forms.GroupBox
	Private WithEvents _cmdct_1 As System.Windows.Forms.Button
	Private WithEvents _txtTon_4 As System.Windows.Forms.TextBox
	Private WithEvents _txtTon_2 As System.Windows.Forms.TextBox
	Private WithEvents _txtTon_3 As System.Windows.Forms.TextBox
    Private WithEvents _GrdVT_1  As ListviewEx.ListviewExt 
	Private WithEvents _Label_5 As System.Windows.Forms.Label
	Private WithEvents _Label_4 As System.Windows.Forms.Label
	Private WithEvents _Label_3 As System.Windows.Forms.Label
	Private WithEvents _Frame1_2 As System.Windows.Forms.GroupBox
	Private WithEvents _txt_6 As System.Windows.Forms.TextBox
	Private WithEvents _cmdct_0 As System.Windows.Forms.Button
	Private WithEvents _txtTon_1 As System.Windows.Forms.TextBox
	Private WithEvents _txtTon_0 As System.Windows.Forms.TextBox
    Private WithEvents _GrdVT_0  As ListviewEx.ListviewExt 
	Private WithEvents _Label_1 As System.Windows.Forms.Label
	Private WithEvents _Label_0 As System.Windows.Forms.Label
	Private WithEvents _Frame1_1 As System.Windows.Forms.GroupBox
	Public WithEvents Cbo As ComboBoxEx.ComboBoxExt
	Private WithEvents _txt_5 As System.Windows.Forms.TextBox
	Private WithEvents _txt_4 As System.Windows.Forms.TextBox
	Private WithEvents _txt_1 As System.Windows.Forms.TextBox
	Private WithEvents _txt_3 As System.Windows.Forms.TextBox
	Private WithEvents _txt_2 As System.Windows.Forms.TextBox
	Private WithEvents _MedNgay_0 As System.Windows.Forms.MaskedTextBox
	Private WithEvents _MedNgay_1 As System.Windows.Forms.MaskedTextBox
	Private WithEvents _MedNgay_2 As System.Windows.Forms.MaskedTextBox
	Private WithEvents _Label_8 As System.Windows.Forms.Label
	Private WithEvents _Label_21 As System.Windows.Forms.Label
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
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Public Command(4) As System.Windows.Forms.Button
    Public Frame1(3) As System.Windows.Forms.GroupBox
    Public GrdVT(2) As ListviewEx.ListviewExt
    Public Label(21) As System.Windows.Forms.Label
    Public MedNgay(2) As System.Windows.Forms.MaskedTextBox
    Public cmdct(2) As System.Windows.Forms.Button
    Public txt(6) As System.Windows.Forms.TextBox
    Public txtTon(6) As System.Windows.Forms.TextBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me._Frame1_3 = New System.Windows.Forms.GroupBox()
        Me._GrdVT_2 = New ListViewEx.ListviewExt()
        Me._cmdct_2 = New System.Windows.Forms.Button()
        Me._txtTon_5 = New System.Windows.Forms.TextBox()
        Me._txtTon_6 = New System.Windows.Forms.TextBox()
        Me._Label_7 = New System.Windows.Forms.Label()
        Me._Label_6 = New System.Windows.Forms.Label()
        Me._Frame1_2 = New System.Windows.Forms.GroupBox()
        Me._GrdVT_1 = New ListViewEx.ListviewExt()
        Me._cmdct_1 = New System.Windows.Forms.Button()
        Me._txtTon_4 = New System.Windows.Forms.TextBox()
        Me._txtTon_2 = New System.Windows.Forms.TextBox()
        Me._txtTon_3 = New System.Windows.Forms.TextBox()
        Me._Label_5 = New System.Windows.Forms.Label()
        Me._Label_4 = New System.Windows.Forms.Label()
        Me._Label_3 = New System.Windows.Forms.Label()
        Me._txt_6 = New System.Windows.Forms.TextBox()
        Me._Frame1_1 = New System.Windows.Forms.GroupBox()
        Me._GrdVT_0 = New ListViewEx.ListviewExt()
        Me._cmdct_0 = New System.Windows.Forms.Button()
        Me._txtTon_1 = New System.Windows.Forms.TextBox()
        Me._txtTon_0 = New System.Windows.Forms.TextBox()
        Me._Label_1 = New System.Windows.Forms.Label()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me._Frame1_0 = New System.Windows.Forms.GroupBox()
        Me.Cbo = New ComboBoxEx.ComboBoxExt()
        Me._txt_5 = New System.Windows.Forms.TextBox()
        Me._txt_4 = New System.Windows.Forms.TextBox()
        Me._txt_1 = New System.Windows.Forms.TextBox()
        Me._txt_3 = New System.Windows.Forms.TextBox()
        Me._txt_2 = New System.Windows.Forms.TextBox()
        Me._MedNgay_0 = New System.Windows.Forms.MaskedTextBox()
        Me._MedNgay_1 = New System.Windows.Forms.MaskedTextBox()
        Me._MedNgay_2 = New System.Windows.Forms.MaskedTextBox()
        Me._Label_8 = New System.Windows.Forms.Label()
        Me._Label_21 = New System.Windows.Forms.Label()
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
        Me._Label_2 = New System.Windows.Forms.Label()
        Me._Label_17 = New System.Windows.Forms.Label()
        Me._Frame1_3.SuspendLayout()
        Me._Frame1_2.SuspendLayout()
        Me._Frame1_1.SuspendLayout()
        Me._Frame1_0.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Frame1_3
        '
        Me._Frame1_3.BackColor = System.Drawing.Color.Transparent
        Me._Frame1_3.Controls.Add(Me._GrdVT_2)
        Me._Frame1_3.Controls.Add(Me._cmdct_2)
        Me._Frame1_3.Controls.Add(Me._txtTon_5)
        Me._Frame1_3.Controls.Add(Me._txtTon_6)
        Me._Frame1_3.Controls.Add(Me._Label_7)
        Me._Frame1_3.Controls.Add(Me._Label_6)
        Me._Frame1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame1_3.ForeColor = System.Drawing.Color.Blue
        Me._Frame1_3.Location = New System.Drawing.Point(8, 504)
        Me._Frame1_3.Name = "_Frame1_3"
        Me._Frame1_3.Size = New System.Drawing.Size(1001, 137)
        Me._Frame1_3.TabIndex = 45
        Me._Frame1_3.TabStop = False
        Me._Frame1_3.Tag = "Responsibilities of each relevant department under"
        Me._Frame1_3.Text = "Trách nhiệm của từng bộ phận trực thuộc liên quan"
        '
        '_GrdVT_2
        '
        Me._GrdVT_2.AllowColumnResize = True
        Me._GrdVT_2.AllowMultiselect = False
        Me._GrdVT_2.AlternateBackground = System.Drawing.Color.DarkGreen
        Me._GrdVT_2.AlternatingColors = False
        Me._GrdVT_2.AutoHeight = True
        Me._GrdVT_2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me._GrdVT_2.BackgroundStretchToFit = True
        Me._GrdVT_2.Col = 0
        Me._GrdVT_2.Cols = 0
        Me._GrdVT_2.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me._GrdVT_2.FullRowSelect = True
        Me._GrdVT_2.GridColor = System.Drawing.Color.LightGray
        Me._GrdVT_2.GridLines = ListViewEx.GLGridLines.gridBoth
        Me._GrdVT_2.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me._GrdVT_2.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me._GrdVT_2.HeaderHeight = 22
        Me._GrdVT_2.HeaderVisible = True
        Me._GrdVT_2.HeaderWordWrap = False
        Me._GrdVT_2.HotColumnTracking = False
        Me._GrdVT_2.HotItemTracking = False
        Me._GrdVT_2.HotTrackingColor = System.Drawing.Color.LightGray
        Me._GrdVT_2.HoverEvents = False
        Me._GrdVT_2.HoverTime = 1
        Me._GrdVT_2.ImageList = Nothing
        Me._GrdVT_2.ItemHeight = 18
        Me._GrdVT_2.ItemWordWrap = False
        Me._GrdVT_2.Location = New System.Drawing.Point(8, 40)
        Me._GrdVT_2.Name = "_GrdVT_2"
        Me._GrdVT_2.Row = 0
        Me._GrdVT_2.Rows = 0
        Me._GrdVT_2.Selectable = True
        Me._GrdVT_2.SelectedTextColor = System.Drawing.Color.White
        Me._GrdVT_2.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me._GrdVT_2.ShowBorder = True
        Me._GrdVT_2.ShowFocusRect = False
        Me._GrdVT_2.Size = New System.Drawing.Size(985, 61)
        Me._GrdVT_2.SortType = ListViewEx.SortTypes.InsertionSort
        Me._GrdVT_2.SuperFlatHeaderColor = System.Drawing.Color.White
        Me._GrdVT_2.TabIndex = 10
        '
        '_cmdct_2
        '
        Me._cmdct_2.BackColor = System.Drawing.SystemColors.Control
        Me._cmdct_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdct_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdct_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdct_2.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_addtogrid
        Me._cmdct_2.Location = New System.Drawing.Point(976, 100)
        Me._cmdct_2.Name = "_cmdct_2"
        Me._cmdct_2.Size = New System.Drawing.Size(17, 20)
        Me._cmdct_2.TabIndex = 46
        Me._cmdct_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._cmdct_2.UseVisualStyleBackColor = False
        '
        '_txtTon_5
        '
        Me._txtTon_5.AcceptsReturn = True
        Me._txtTon_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_5.Location = New System.Drawing.Point(8, 100)
        Me._txtTon_5.MaxLength = 0
        Me._txtTon_5.Name = "_txtTon_5"
        Me._txtTon_5.Size = New System.Drawing.Size(385, 20)
        Me._txtTon_5.TabIndex = 20
        '
        '_txtTon_6
        '
        Me._txtTon_6.AcceptsReturn = True
        Me._txtTon_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_6.Location = New System.Drawing.Point(392, 100)
        Me._txtTon_6.MaxLength = 0
        Me._txtTon_6.Name = "_txtTon_6"
        Me._txtTon_6.Size = New System.Drawing.Size(584, 20)
        Me._txtTon_6.TabIndex = 21
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(8, 24)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(385, 17)
        Me._Label_7.TabIndex = 48
        Me._Label_7.Tag = "Department name"
        Me._Label_7.Text = "Tên bộ phận"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.Color.Black
        Me._Label_6.Location = New System.Drawing.Point(392, 24)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(601, 17)
        Me._Label_6.TabIndex = 47
        Me._Label_6.Tag = "Responsibility"
        Me._Label_6.Text = "Trách nhiệm"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Frame1_2
        '
        Me._Frame1_2.BackColor = System.Drawing.Color.Transparent
        Me._Frame1_2.Controls.Add(Me._GrdVT_1)
        Me._Frame1_2.Controls.Add(Me._cmdct_1)
        Me._Frame1_2.Controls.Add(Me._txtTon_4)
        Me._Frame1_2.Controls.Add(Me._txtTon_2)
        Me._Frame1_2.Controls.Add(Me._txtTon_3)
        Me._Frame1_2.Controls.Add(Me._Label_5)
        Me._Frame1_2.Controls.Add(Me._Label_4)
        Me._Frame1_2.Controls.Add(Me._Label_3)
        Me._Frame1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame1_2.ForeColor = System.Drawing.Color.Blue
        Me._Frame1_2.Location = New System.Drawing.Point(8, 360)
        Me._Frame1_2.Name = "_Frame1_2"
        Me._Frame1_2.Size = New System.Drawing.Size(1001, 137)
        Me._Frame1_2.TabIndex = 41
        Me._Frame1_2.TabStop = False
        Me._Frame1_2.Tag = "Class invoice issued"
        Me._Frame1_2.Text = "Các loại hoá đơn phát hành"
        '
        '_GrdVT_1
        '
        Me._GrdVT_1.AllowColumnResize = True
        Me._GrdVT_1.AllowMultiselect = False
        Me._GrdVT_1.AlternateBackground = System.Drawing.Color.DarkGreen
        Me._GrdVT_1.AlternatingColors = False
        Me._GrdVT_1.AutoHeight = True
        Me._GrdVT_1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me._GrdVT_1.BackgroundStretchToFit = True
        Me._GrdVT_1.Col = 0
        Me._GrdVT_1.Cols = 0
        Me._GrdVT_1.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me._GrdVT_1.FullRowSelect = True
        Me._GrdVT_1.GridColor = System.Drawing.Color.LightGray
        Me._GrdVT_1.GridLines = ListViewEx.GLGridLines.gridBoth
        Me._GrdVT_1.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me._GrdVT_1.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me._GrdVT_1.HeaderHeight = 22
        Me._GrdVT_1.HeaderVisible = True
        Me._GrdVT_1.HeaderWordWrap = False
        Me._GrdVT_1.HotColumnTracking = False
        Me._GrdVT_1.HotItemTracking = False
        Me._GrdVT_1.HotTrackingColor = System.Drawing.Color.LightGray
        Me._GrdVT_1.HoverEvents = False
        Me._GrdVT_1.HoverTime = 1
        Me._GrdVT_1.ImageList = Nothing
        Me._GrdVT_1.ItemHeight = 18
        Me._GrdVT_1.ItemWordWrap = False
        Me._GrdVT_1.Location = New System.Drawing.Point(8, 40)
        Me._GrdVT_1.Name = "_GrdVT_1"
        Me._GrdVT_1.Row = 0
        Me._GrdVT_1.Rows = 0
        Me._GrdVT_1.Selectable = True
        Me._GrdVT_1.SelectedTextColor = System.Drawing.Color.White
        Me._GrdVT_1.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me._GrdVT_1.ShowBorder = True
        Me._GrdVT_1.ShowFocusRect = False
        Me._GrdVT_1.Size = New System.Drawing.Size(985, 61)
        Me._GrdVT_1.SortType = ListViewEx.SortTypes.InsertionSort
        Me._GrdVT_1.SuperFlatHeaderColor = System.Drawing.Color.White
        Me._GrdVT_1.TabIndex = 10
        '
        '_cmdct_1
        '
        Me._cmdct_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdct_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdct_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdct_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdct_1.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_addtogrid
        Me._cmdct_1.Location = New System.Drawing.Point(976, 100)
        Me._cmdct_1.Name = "_cmdct_1"
        Me._cmdct_1.Size = New System.Drawing.Size(17, 19)
        Me._cmdct_1.TabIndex = 18
        Me._cmdct_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._cmdct_1.UseVisualStyleBackColor = False
        '
        '_txtTon_4
        '
        Me._txtTon_4.AcceptsReturn = True
        Me._txtTon_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_4.Location = New System.Drawing.Point(392, 100)
        Me._txtTon_4.MaxLength = 0
        Me._txtTon_4.Name = "_txtTon_4"
        Me._txtTon_4.Size = New System.Drawing.Size(584, 20)
        Me._txtTon_4.TabIndex = 17
        '
        '_txtTon_2
        '
        Me._txtTon_2.AcceptsReturn = True
        Me._txtTon_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_2.Location = New System.Drawing.Point(8, 100)
        Me._txtTon_2.MaxLength = 0
        Me._txtTon_2.Name = "_txtTon_2"
        Me._txtTon_2.ReadOnly = True
        Me._txtTon_2.Size = New System.Drawing.Size(193, 20)
        Me._txtTon_2.TabIndex = 15
        Me._txtTon_2.TabStop = False
        '
        '_txtTon_3
        '
        Me._txtTon_3.AcceptsReturn = True
        Me._txtTon_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_3.Location = New System.Drawing.Point(200, 100)
        Me._txtTon_3.MaxLength = 0
        Me._txtTon_3.Name = "_txtTon_3"
        Me._txtTon_3.Size = New System.Drawing.Size(193, 20)
        Me._txtTon_3.TabIndex = 16
        Me._txtTon_3.Text = "Ấn enter để chọn"
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.Color.Black
        Me._Label_5.Location = New System.Drawing.Point(392, 24)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(601, 17)
        Me._Label_5.TabIndex = 44
        Me._Label_5.Tag = "Purpose"
        Me._Label_5.Text = "Mục đích sử dụng"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(8, 24)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(193, 17)
        Me._Label_4.TabIndex = 43
        Me._Label_4.Tag = "Class"
        Me._Label_4.Text = "Loại hoá đơn"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.Black
        Me._Label_3.Location = New System.Drawing.Point(200, 24)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(193, 17)
        Me._Label_3.TabIndex = 42
        Me._Label_3.Tag = "Form"
        Me._Label_3.Text = "Mẫu số hoá đơn"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_txt_6
        '
        Me._txt_6.AcceptsReturn = True
        Me._txt_6.BackColor = System.Drawing.SystemColors.Window
        Me._txt_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_6.Location = New System.Drawing.Point(16, 328)
        Me._txt_6.MaxLength = 0
        Me._txt_6.Name = "_txt_6"
        Me._txt_6.Size = New System.Drawing.Size(993, 20)
        Me._txt_6.TabIndex = 13
        '
        '_Frame1_1
        '
        Me._Frame1_1.BackColor = System.Drawing.Color.Transparent
        Me._Frame1_1.Controls.Add(Me._GrdVT_0)
        Me._Frame1_1.Controls.Add(Me._cmdct_0)
        Me._Frame1_1.Controls.Add(Me._txtTon_1)
        Me._Frame1_1.Controls.Add(Me._txtTon_0)
        Me._Frame1_1.Controls.Add(Me._Label_1)
        Me._Frame1_1.Controls.Add(Me._Label_0)
        Me._Frame1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame1_1.ForeColor = System.Drawing.Color.Blue
        Me._Frame1_1.Location = New System.Drawing.Point(8, 168)
        Me._Frame1_1.Name = "_Frame1_1"
        Me._Frame1_1.Size = New System.Drawing.Size(1001, 137)
        Me._Frame1_1.TabIndex = 28
        Me._Frame1_1.TabStop = False
        Me._Frame1_1.Tag = "System equipment"
        Me._Frame1_1.Text = "Hệ thống thiết bị "
        '
        '_GrdVT_0
        '
        Me._GrdVT_0.AllowColumnResize = True
        Me._GrdVT_0.AllowMultiselect = False
        Me._GrdVT_0.AlternateBackground = System.Drawing.Color.DarkGreen
        Me._GrdVT_0.AlternatingColors = False
        Me._GrdVT_0.AutoHeight = True
        Me._GrdVT_0.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me._GrdVT_0.BackgroundStretchToFit = True
        Me._GrdVT_0.Col = 0
        Me._GrdVT_0.Cols = 0
        Me._GrdVT_0.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me._GrdVT_0.FullRowSelect = True
        Me._GrdVT_0.GridColor = System.Drawing.Color.LightGray
        Me._GrdVT_0.GridLines = ListViewEx.GLGridLines.gridBoth
        Me._GrdVT_0.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me._GrdVT_0.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me._GrdVT_0.HeaderHeight = 22
        Me._GrdVT_0.HeaderVisible = True
        Me._GrdVT_0.HeaderWordWrap = False
        Me._GrdVT_0.HotColumnTracking = False
        Me._GrdVT_0.HotItemTracking = False
        Me._GrdVT_0.HotTrackingColor = System.Drawing.Color.LightGray
        Me._GrdVT_0.HoverEvents = False
        Me._GrdVT_0.HoverTime = 1
        Me._GrdVT_0.ImageList = Nothing
        Me._GrdVT_0.ItemHeight = 18
        Me._GrdVT_0.ItemWordWrap = False
        Me._GrdVT_0.Location = New System.Drawing.Point(8, 40)
        Me._GrdVT_0.Name = "_GrdVT_0"
        Me._GrdVT_0.Row = 0
        Me._GrdVT_0.Rows = 0
        Me._GrdVT_0.Selectable = True
        Me._GrdVT_0.SelectedTextColor = System.Drawing.Color.White
        Me._GrdVT_0.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me._GrdVT_0.ShowBorder = True
        Me._GrdVT_0.ShowFocusRect = False
        Me._GrdVT_0.Size = New System.Drawing.Size(985, 61)
        Me._GrdVT_0.SortType = ListViewEx.SortTypes.InsertionSort
        Me._GrdVT_0.SuperFlatHeaderColor = System.Drawing.Color.White
        Me._GrdVT_0.TabIndex = 10
        '
        '_cmdct_0
        '
        Me._cmdct_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdct_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdct_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdct_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdct_0.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_addtogrid
        Me._cmdct_0.Location = New System.Drawing.Point(976, 100)
        Me._cmdct_0.Name = "_cmdct_0"
        Me._cmdct_0.Size = New System.Drawing.Size(17, 20)
        Me._cmdct_0.TabIndex = 12
        Me._cmdct_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._cmdct_0.UseVisualStyleBackColor = False
        '
        '_txtTon_1
        '
        Me._txtTon_1.AcceptsReturn = True
        Me._txtTon_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_1.Location = New System.Drawing.Point(392, 100)
        Me._txtTon_1.MaxLength = 0
        Me._txtTon_1.Name = "_txtTon_1"
        Me._txtTon_1.Size = New System.Drawing.Size(584, 20)
        Me._txtTon_1.TabIndex = 11
        '
        '_txtTon_0
        '
        Me._txtTon_0.AcceptsReturn = True
        Me._txtTon_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_0.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_0.Location = New System.Drawing.Point(8, 100)
        Me._txtTon_0.MaxLength = 0
        Me._txtTon_0.Name = "_txtTon_0"
        Me._txtTon_0.Size = New System.Drawing.Size(385, 20)
        Me._txtTon_0.TabIndex = 10
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(392, 24)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(601, 17)
        Me._Label_1.TabIndex = 34
        Me._Label_1.Tag = "Specifications"
        Me._Label_1.Text = "Thông số kỹ thuật"
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
        Me._Label_0.Size = New System.Drawing.Size(385, 17)
        Me._Label_0.TabIndex = 33
        Me._Label_0.Tag = "Name"
        Me._Label_0.Text = "Tên"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Frame1_0
        '
        Me._Frame1_0.BackColor = System.Drawing.Color.Transparent
        Me._Frame1_0.Controls.Add(Me.Cbo)
        Me._Frame1_0.Controls.Add(Me._txt_5)
        Me._Frame1_0.Controls.Add(Me._txt_4)
        Me._Frame1_0.Controls.Add(Me._txt_1)
        Me._Frame1_0.Controls.Add(Me._txt_3)
        Me._Frame1_0.Controls.Add(Me._txt_2)
        Me._Frame1_0.Controls.Add(Me._MedNgay_0)
        Me._Frame1_0.Controls.Add(Me._MedNgay_1)
        Me._Frame1_0.Controls.Add(Me._MedNgay_2)
        Me._Frame1_0.Controls.Add(Me._Label_8)
        Me._Frame1_0.Controls.Add(Me._Label_21)
        Me._Frame1_0.Controls.Add(Me._Label_20)
        Me._Frame1_0.Controls.Add(Me._Label_19)
        Me._Frame1_0.Controls.Add(Me._Label_18)
        Me._Frame1_0.Controls.Add(Me._Label_16)
        Me._Frame1_0.Controls.Add(Me._Label_15)
        Me._Frame1_0.Controls.Add(Me._Label_14)
        Me._Frame1_0.Controls.Add(Me._Label_13)
        Me._Frame1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame1_0.ForeColor = System.Drawing.Color.Blue
        Me._Frame1_0.Location = New System.Drawing.Point(8, 32)
        Me._Frame1_0.Name = "_Frame1_0"
        Me._Frame1_0.Size = New System.Drawing.Size(1001, 129)
        Me._Frame1_0.TabIndex = 27
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
        Me.Cbo.Location = New System.Drawing.Point(144, 48)
        Me.Cbo.Name = "Cbo"
        Me.Cbo.Size = New System.Drawing.Size(329, 21)
        Me.Cbo.TabIndex = 1
        '
        '_txt_5
        '
        Me._txt_5.AcceptsReturn = True
        Me._txt_5.BackColor = System.Drawing.SystemColors.Window
        Me._txt_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_5.Location = New System.Drawing.Point(664, 96)
        Me._txt_5.MaxLength = 0
        Me._txt_5.Name = "_txt_5"
        Me._txt_5.Size = New System.Drawing.Size(329, 20)
        Me._txt_5.TabIndex = 8
        '
        '_txt_4
        '
        Me._txt_4.AcceptsReturn = True
        Me._txt_4.BackColor = System.Drawing.SystemColors.Window
        Me._txt_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_4.Location = New System.Drawing.Point(664, 72)
        Me._txt_4.MaxLength = 0
        Me._txt_4.Name = "_txt_4"
        Me._txt_4.Size = New System.Drawing.Size(329, 20)
        Me._txt_4.TabIndex = 7
        '
        '_txt_1
        '
        Me._txt_1.AcceptsReturn = True
        Me._txt_1.BackColor = System.Drawing.SystemColors.Window
        Me._txt_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_1.Location = New System.Drawing.Point(144, 72)
        Me._txt_1.MaxLength = 0
        Me._txt_1.Name = "_txt_1"
        Me._txt_1.Size = New System.Drawing.Size(329, 20)
        Me._txt_1.TabIndex = 2
        '
        '_txt_3
        '
        Me._txt_3.AcceptsReturn = True
        Me._txt_3.BackColor = System.Drawing.SystemColors.Window
        Me._txt_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_3.Location = New System.Drawing.Point(664, 48)
        Me._txt_3.MaxLength = 0
        Me._txt_3.Name = "_txt_3"
        Me._txt_3.Size = New System.Drawing.Size(329, 20)
        Me._txt_3.TabIndex = 6
        '
        '_txt_2
        '
        Me._txt_2.AcceptsReturn = True
        Me._txt_2.BackColor = System.Drawing.SystemColors.Window
        Me._txt_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_2.Location = New System.Drawing.Point(664, 24)
        Me._txt_2.MaxLength = 0
        Me._txt_2.Name = "_txt_2"
        Me._txt_2.Size = New System.Drawing.Size(329, 20)
        Me._txt_2.TabIndex = 5
        '
        '_MedNgay_0
        '
        Me._MedNgay_0.AllowPromptAsInput = False
        Me._MedNgay_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_0.Location = New System.Drawing.Point(144, 24)
        Me._MedNgay_0.Mask = "00/00/0000"
        Me._MedNgay_0.Name = "_MedNgay_0"
        Me._MedNgay_0.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_0.TabIndex = 0
        '
        '_MedNgay_1
        '
        Me._MedNgay_1.AllowPromptAsInput = False
        Me._MedNgay_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_1.Location = New System.Drawing.Point(144, 96)
        Me._MedNgay_1.Mask = "00/00/0000"
        Me._MedNgay_1.Name = "_MedNgay_1"
        Me._MedNgay_1.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_1.TabIndex = 3
        '
        '_MedNgay_2
        '
        Me._MedNgay_2.AllowPromptAsInput = False
        Me._MedNgay_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_2.Location = New System.Drawing.Point(416, 96)
        Me._MedNgay_2.Name = "_MedNgay_2"
        Me._MedNgay_2.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_2.TabIndex = 4
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.Transparent
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_8.Location = New System.Drawing.Point(8, 48)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(113, 17)
        Me._Label_8.TabIndex = 49
        Me._Label_8.Tag = "Decision code"
        Me._Label_8.Text = "Số quyết định"
        '
        '_Label_21
        '
        Me._Label_21.BackColor = System.Drawing.Color.Transparent
        Me._Label_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_21.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_21.Location = New System.Drawing.Point(280, 96)
        Me._Label_21.Name = "_Label_21"
        Me._Label_21.Size = New System.Drawing.Size(113, 17)
        Me._Label_21.TabIndex = 39
        Me._Label_21.Tag = "Decision effect on"
        Me._Label_21.Text = "Ngày QĐ có hiệu lực"
        '
        '_Label_20
        '
        Me._Label_20.BackColor = System.Drawing.Color.Transparent
        Me._Label_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_20.Location = New System.Drawing.Point(498, 48)
        Me._Label_20.Name = "_Label_20"
        Me._Label_20.Size = New System.Drawing.Size(167, 17)
        Me._Label_20.TabIndex = 38
        Me._Label_20.Tag = "Director"
        Me._Label_20.Text = "Giám đốc"
        '
        '_Label_19
        '
        Me._Label_19.BackColor = System.Drawing.Color.Transparent
        Me._Label_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_19.Location = New System.Drawing.Point(498, 72)
        Me._Label_19.Name = "_Label_19"
        Me._Label_19.Size = New System.Drawing.Size(167, 17)
        Me._Label_19.TabIndex = 37
        Me._Label_19.Tag = "Department/person proposal"
        Me._Label_19.Text = "Bộ phận/Người đề nghị"
        '
        '_Label_18
        '
        Me._Label_18.BackColor = System.Drawing.Color.Transparent
        Me._Label_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_18.Location = New System.Drawing.Point(498, 96)
        Me._Label_18.Name = "_Label_18"
        Me._Label_18.Size = New System.Drawing.Size(167, 17)
        Me._Label_18.TabIndex = 36
        Me._Label_18.Tag = "Tax agency management"
        Me._Label_18.Text = "Cơ quan thuế quản lý"
        '
        '_Label_16
        '
        Me._Label_16.BackColor = System.Drawing.Color.Transparent
        Me._Label_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_16.Location = New System.Drawing.Point(8, 96)
        Me._Label_16.Name = "_Label_16"
        Me._Label_16.Size = New System.Drawing.Size(113, 17)
        Me._Label_16.TabIndex = 32
        Me._Label_16.Tag = "Application on"
        Me._Label_16.Text = "Ngày áp dụng tự in"
        '
        '_Label_15
        '
        Me._Label_15.BackColor = System.Drawing.Color.Transparent
        Me._Label_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_15.Location = New System.Drawing.Point(498, 24)
        Me._Label_15.Name = "_Label_15"
        Me._Label_15.Size = New System.Drawing.Size(167, 17)
        Me._Label_15.TabIndex = 31
        Me._Label_15.Tag = "Business registration No."
        Me._Label_15.Text = "Số ĐKKD"
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.Color.Transparent
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_14.Location = New System.Drawing.Point(8, 24)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(113, 17)
        Me._Label_14.TabIndex = 30
        Me._Label_14.Tag = "Date of decision"
        Me._Label_14.Text = "Ngày lập quyết định"
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.Transparent
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_13.Location = New System.Drawing.Point(8, 72)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(113, 17)
        Me._Label_13.TabIndex = 29
        Me._Label_13.Tag = "Unit Name"
        Me._Label_13.Text = "Tên đơn vị"
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Save
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(776, 648)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 24
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_2
        '
        Me._Command_2.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Xoa
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(856, 648)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 25
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_3
        '
        Me._Command_3.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(936, 648)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 26
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_Command_4
        '
        Me._Command_4.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Preview
        Me._Command_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_4.Location = New System.Drawing.Point(616, 648)
        Me._Command_4.Name = "_Command_4"
        Me._Command_4.Size = New System.Drawing.Size(73, 25)
        Me._Command_4.TabIndex = 22
        Me._Command_4.Tag = "Preview"
        Me._Command_4.Text = "&Xem in"
        '
        '_Command_0
        '
        Me._Command_0.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Add
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(696, 648)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 23
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.Transparent
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(16, 312)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(993, 17)
        Me._Label_2.TabIndex = 40
        Me._Label_2.Tag = "The engineering department anh name of the service providers responsible for the " & _
            "technial"
        Me._Label_2.Text = "Các bộ phận kỹ thuật và tên nhà cung ứng dịch vụ chịu trách nhiệm về mặt kỹ thuật" & _
            ":"
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.ForeColor = System.Drawing.Color.Black
        Me._Label_17.Location = New System.Drawing.Point(344, 8)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(353, 20)
        Me._Label_17.TabIndex = 35
        Me._Label_17.Tag = "Decided to adopt the invoice"
        Me._Label_17.Text = "Quyết định áp dụng hoá đơn tự in"
        Me._Label_17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmQuyetdinhapdunghoadontuin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1018, 682)
        Me.Controls.Add(Me._Frame1_3)
        Me.Controls.Add(Me._Frame1_2)
        Me.Controls.Add(Me._txt_6)
        Me.Controls.Add(Me._Frame1_1)
        Me.Controls.Add(Me._Frame1_0)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_4)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_17)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmQuyetdinhapdunghoadontuin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Decided to adopt the invoice"
        Me.Text = "Quyết định áp dụng hoá đơn tự in"
        Me._Frame1_3.ResumeLayout(False)
        Me._Frame1_3.PerformLayout()
        Me._Frame1_2.ResumeLayout(False)
        Me._Frame1_2.PerformLayout()
        Me._Frame1_1.ResumeLayout(False)
        Me._Frame1_1.PerformLayout()
        Me._Frame1_0.ResumeLayout(False)
        Me._Frame1_0.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializetxtTon()
		Me.txtTon(5) = _txtTon_5
		Me.txtTon(6) = _txtTon_6
		Me.txtTon(4) = _txtTon_4
		Me.txtTon(2) = _txtTon_2
		Me.txtTon(3) = _txtTon_3
		Me.txtTon(1) = _txtTon_1
		Me.txtTon(0) = _txtTon_0
	End Sub
	Sub Initializetxt()
		Me.txt(6) = _txt_6
		Me.txt(5) = _txt_5
		Me.txt(4) = _txt_4
		Me.txt(1) = _txt_1
		Me.txt(3) = _txt_3
		Me.txt(2) = _txt_2
	End Sub
	Sub Initializecmdct()
		Me.cmdct(2) = _cmdct_2
		Me.cmdct(1) = _cmdct_1
		Me.cmdct(0) = _cmdct_0
	End Sub
	Sub InitializeMedNgay()
		Me.MedNgay(0) = _MedNgay_0
		Me.MedNgay(1) = _MedNgay_1
		Me.MedNgay(2) = _MedNgay_2
	End Sub
	Sub InitializeLabel()
		Me.Label(7) = _Label_7
		Me.Label(6) = _Label_6
		Me.Label(5) = _Label_5
		Me.Label(4) = _Label_4
		Me.Label(3) = _Label_3
		Me.Label(1) = _Label_1
		Me.Label(0) = _Label_0
		Me.Label(8) = _Label_8
		Me.Label(21) = _Label_21
		Me.Label(20) = _Label_20
		Me.Label(19) = _Label_19
		Me.Label(18) = _Label_18
		Me.Label(16) = _Label_16
		Me.Label(15) = _Label_15
		Me.Label(14) = _Label_14
		Me.Label(13) = _Label_13
		Me.Label(2) = _Label_2
		Me.Label(17) = _Label_17
	End Sub
	Sub InitializeGrdVT()
        Me.GrdVT(2) = _GrdVT_2
        Me.GrdVT(1) = _GrdVT_1
        Me.GrdVT(0) = _GrdVT_0
	End Sub
	Sub InitializeFrame1()
		Me.Frame1(3) = _Frame1_3
		Me.Frame1(2) = _Frame1_2
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
