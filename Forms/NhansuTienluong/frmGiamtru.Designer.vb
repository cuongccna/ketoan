<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGiamtru
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		Initializetxt()
		InitializeSSOpt()
		InitializeMedNgay()
		InitializeLine()
		InitializeLabel1()
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
	Public WithEvents txtF As System.Windows.Forms.TextBox
	Public WithEvents LstVt As System.Windows.Forms.ListBox
	Public WithEvents CboLoai As ComboBoxEx.ComboBoxExt
	Private WithEvents _SSOpt_0 As System.Windows.Forms.RadioButton
	Private WithEvents _SSOpt_1 As System.Windows.Forms.RadioButton
	Private WithEvents _txt_4 As System.Windows.Forms.TextBox
	Private WithEvents _txt_5 As System.Windows.Forms.TextBox
	Private WithEvents _txt_6 As System.Windows.Forms.TextBox
	Public WithEvents CboThang As ComboBoxEx.ComboBoxExt
	Private WithEvents _Label1_3 As System.Windows.Forms.Label
	Private WithEvents _Line_12 As System.Windows.Forms.Label
	Private WithEvents _Line_10 As System.Windows.Forms.Label
	Private WithEvents _Line_11 As System.Windows.Forms.Label
	Private WithEvents _Label1_12 As System.Windows.Forms.Label
	Private WithEvents _Label1_13 As System.Windows.Forms.Label
	Private WithEvents _Label1_14 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents CboQH As ComboBoxEx.ComboBoxExt
	Public WithEvents cmdct As System.Windows.Forms.Button
	Public WithEvents GrdVT  As ListviewEx.ListviewExt 
	Private WithEvents _txt_2 As System.Windows.Forms.TextBox
	Private WithEvents _txt_1 As System.Windows.Forms.TextBox
	Private WithEvents _txt_0 As System.Windows.Forms.TextBox
	Private WithEvents _MedNgay_1 As System.Windows.Forms.MaskedTextBox
	Private WithEvents _MedNgay_2 As System.Windows.Forms.MaskedTextBox
	Private WithEvents _MedNgay_0 As System.Windows.Forms.MaskedTextBox
	Private WithEvents _Label_7 As System.Windows.Forms.Label
	Private WithEvents _Label_3 As System.Windows.Forms.Label
	Private WithEvents _Label_2 As System.Windows.Forms.Label
	Private WithEvents _Label_6 As System.Windows.Forms.Label
	Private WithEvents _Label_8 As System.Windows.Forms.Label
	Private WithEvents _Label_9 As System.Windows.Forms.Label
	Private WithEvents _Label_11 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_4 As System.Windows.Forms.Button
    Public WithEvents SSCmdF As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Label1_0 As System.Windows.Forms.Label
    Public Command(4) As System.Windows.Forms.Button
    Public Label(11) As System.Windows.Forms.Label
    Public Label1(14) As System.Windows.Forms.Label
    Public Line(12) As System.Windows.Forms.Label
    Public MedNgay(2) As System.Windows.Forms.MaskedTextBox
    Public SSOpt(1) As System.Windows.Forms.RadioButton
    Public txt(6) As System.Windows.Forms.TextBox
    'Private listBoxHelper1 As Artinsoft.VB6.Gui.ListBoxHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGiamtru))
        Me.txtF = New System.Windows.Forms.TextBox()
        Me.LstVt = New System.Windows.Forms.ListBox()
        Me.CboLoai = New ComboBoxEx.ComboBoxExt()
        Me._SSOpt_0 = New System.Windows.Forms.RadioButton()
        Me._SSOpt_1 = New System.Windows.Forms.RadioButton()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me._txt_4 = New System.Windows.Forms.TextBox()
        Me._txt_5 = New System.Windows.Forms.TextBox()
        Me._txt_6 = New System.Windows.Forms.TextBox()
        Me.CboThang = New ComboBoxEx.ComboBoxExt()
        Me._Label1_3 = New System.Windows.Forms.Label()
        Me._Line_12 = New System.Windows.Forms.Label()
        Me._Line_10 = New System.Windows.Forms.Label()
        Me._Line_11 = New System.Windows.Forms.Label()
        Me._Label1_12 = New System.Windows.Forms.Label()
        Me._Label1_13 = New System.Windows.Forms.Label()
        Me._Label1_14 = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.GrdVT = New ListViewEx.ListviewExt()
        Me.CboQH = New ComboBoxEx.ComboBoxExt()
        Me.cmdct = New System.Windows.Forms.Button()
        Me._txt_2 = New System.Windows.Forms.TextBox()
        Me._txt_1 = New System.Windows.Forms.TextBox()
        Me._txt_0 = New System.Windows.Forms.TextBox()
        Me._MedNgay_1 = New System.Windows.Forms.MaskedTextBox()
        Me._MedNgay_2 = New System.Windows.Forms.MaskedTextBox()
        Me._MedNgay_0 = New System.Windows.Forms.MaskedTextBox()
        Me._Label_7 = New System.Windows.Forms.Label()
        Me._Label_3 = New System.Windows.Forms.Label()
        Me._Label_2 = New System.Windows.Forms.Label()
        Me._Label_6 = New System.Windows.Forms.Label()
        Me._Label_8 = New System.Windows.Forms.Label()
        Me._Label_9 = New System.Windows.Forms.Label()
        Me._Label_11 = New System.Windows.Forms.Label()
        Me._Command_3 = New System.Windows.Forms.Button()
        Me._Command_4 = New System.Windows.Forms.Button()
        Me.SSCmdF = New System.Windows.Forms.Button()
        Me._Command_2 = New System.Windows.Forms.Button()
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtF
        '
        Me.txtF.AcceptsReturn = True
        Me.txtF.BackColor = System.Drawing.SystemColors.Window
        Me.txtF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF.Location = New System.Drawing.Point(113, 332)
        Me.txtF.MaxLength = 0
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(141, 20)
        Me.txtF.TabIndex = 32
        '
        'LstVt
        '
        Me.LstVt.BackColor = System.Drawing.SystemColors.Window
        Me.LstVt.Cursor = System.Windows.Forms.Cursors.Default
        Me.LstVt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstVt.ItemHeight = 14
        Me.LstVt.Location = New System.Drawing.Point(7, 28)
        Me.LstVt.Name = "LstVt"
        Me.LstVt.Size = New System.Drawing.Size(154, 284)
        Me.LstVt.TabIndex = 36
        '
        'CboLoai
        '
        Me.CboLoai.BackColor = System.Drawing.SystemColors.Window
        Me.CboLoai.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLoai.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLoai.ForeColor = System.Drawing.Color.Blue
        Me.CboLoai.Location = New System.Drawing.Point(7, 7)
        Me.CboLoai.Name = "CboLoai"
        Me.CboLoai.Size = New System.Drawing.Size(154, 21)
        Me.CboLoai.TabIndex = 35
        '
        '_SSOpt_0
        '
        Me._SSOpt_0.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_0.Checked = True
        Me._SSOpt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_0.Location = New System.Drawing.Point(7, 333)
        Me._SSOpt_0.Name = "_SSOpt_0"
        Me._SSOpt_0.Size = New System.Drawing.Size(54, 18)
        Me._SSOpt_0.TabIndex = 34
        Me._SSOpt_0.TabStop = True
        Me._SSOpt_0.Tag = "Code"
        Me._SSOpt_0.Text = "Số hiệu"
        Me._SSOpt_0.UseVisualStyleBackColor = False
        '
        '_SSOpt_1
        '
        Me._SSOpt_1.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_1.Location = New System.Drawing.Point(67, 333)
        Me._SSOpt_1.Name = "_SSOpt_1"
        Me._SSOpt_1.Size = New System.Drawing.Size(47, 18)
        Me._SSOpt_1.TabIndex = 33
        Me._SSOpt_1.TabStop = True
        Me._SSOpt_1.Tag = "Name"
        Me._SSOpt_1.Text = "Tên "
        Me._SSOpt_1.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.White
        Me.Frame2.Controls.Add(Me._txt_4)
        Me.Frame2.Controls.Add(Me._txt_5)
        Me.Frame2.Controls.Add(Me._txt_6)
        Me.Frame2.Controls.Add(Me.CboThang)
        Me.Frame2.Controls.Add(Me._Label1_3)
        Me.Frame2.Controls.Add(Me._Line_12)
        Me.Frame2.Controls.Add(Me._Line_10)
        Me.Frame2.Controls.Add(Me._Line_11)
        Me.Frame2.Controls.Add(Me._Label1_12)
        Me.Frame2.Controls.Add(Me._Label1_13)
        Me.Frame2.Controls.Add(Me._Label1_14)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(173, 257)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(654, 49)
        Me.Frame2.TabIndex = 21
        Me.Frame2.TabStop = False
        Me.Frame2.Tag = "Other deductions"
        Me.Frame2.Text = "Các khoản giảm trừ khác"
        '
        '_txt_4
        '
        Me._txt_4.AcceptsReturn = True
        Me._txt_4.BackColor = System.Drawing.SystemColors.Window
        Me._txt_4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txt_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_4.Location = New System.Drawing.Point(193, 21)
        Me._txt_4.MaxLength = 100
        Me._txt_4.Name = "_txt_4"
        Me._txt_4.Size = New System.Drawing.Size(74, 15)
        Me._txt_4.TabIndex = 9
        Me._txt_4.Text = "0"
        Me._txt_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txt_5
        '
        Me._txt_5.AcceptsReturn = True
        Me._txt_5.BackColor = System.Drawing.SystemColors.Window
        Me._txt_5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txt_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_5.Location = New System.Drawing.Point(553, 21)
        Me._txt_5.MaxLength = 100
        Me._txt_5.Name = "_txt_5"
        Me._txt_5.Size = New System.Drawing.Size(74, 15)
        Me._txt_5.TabIndex = 10
        Me._txt_5.Text = "0"
        Me._txt_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txt_6
        '
        Me._txt_6.AcceptsReturn = True
        Me._txt_6.BackColor = System.Drawing.SystemColors.Window
        Me._txt_6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txt_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_6.Location = New System.Drawing.Point(373, 21)
        Me._txt_6.MaxLength = 100
        Me._txt_6.Name = "_txt_6"
        Me._txt_6.Size = New System.Drawing.Size(74, 15)
        Me._txt_6.TabIndex = 11
        Me._txt_6.Text = "0"
        Me._txt_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CboThang
        '
        Me.CboThang.BackColor = System.Drawing.SystemColors.Window
        Me.CboThang.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboThang.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboThang.Location = New System.Drawing.Point(47, 17)
        Me.CboThang.Name = "CboThang"
        Me.CboThang.Size = New System.Drawing.Size(54, 21)
        Me.CboThang.TabIndex = 8
        '
        '_Label1_3
        '
        Me._Label1_3.BackColor = System.Drawing.Color.Transparent
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_3.Location = New System.Drawing.Point(7, 21)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.Size = New System.Drawing.Size(40, 15)
        Me._Label1_3.TabIndex = 28
        Me._Label1_3.Tag = "Month"
        Me._Label1_3.Text = "Tháng"
        '
        '_Line_12
        '
        Me._Line_12.Enabled = False
        Me._Line_12.Location = New System.Drawing.Point(373, 37)
        Me._Line_12.Name = "_Line_12"
        Me._Line_12.Size = New System.Drawing.Size(74, 1)
        Me._Line_12.TabIndex = 29
        '
        '_Line_10
        '
        Me._Line_10.Enabled = False
        Me._Line_10.Location = New System.Drawing.Point(553, 37)
        Me._Line_10.Name = "_Line_10"
        Me._Line_10.Size = New System.Drawing.Size(74, 1)
        Me._Line_10.TabIndex = 30
        '
        '_Line_11
        '
        Me._Line_11.Enabled = False
        Me._Line_11.Location = New System.Drawing.Point(193, 37)
        Me._Line_11.Name = "_Line_11"
        Me._Line_11.Size = New System.Drawing.Size(74, 1)
        Me._Line_11.TabIndex = 31
        '
        '_Label1_12
        '
        Me._Label1_12.BackColor = System.Drawing.Color.Transparent
        Me._Label1_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_12.Location = New System.Drawing.Point(147, 21)
        Me._Label1_12.Name = "_Label1_12"
        Me._Label1_12.Size = New System.Drawing.Size(58, 15)
        Me._Label1_12.TabIndex = 27
        Me._Label1_12.Tag = "Charity"
        Me._Label1_12.Text = "Từ thiện"
        '
        '_Label1_13
        '
        Me._Label1_13.BackColor = System.Drawing.Color.Transparent
        Me._Label1_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_13.Location = New System.Drawing.Point(493, 21)
        Me._Label1_13.Name = "_Label1_13"
        Me._Label1_13.Size = New System.Drawing.Size(80, 15)
        Me._Label1_13.TabIndex = 26
        Me._Label1_13.Tag = "Humanitarian"
        Me._Label1_13.Text = "Nhân đạo"
        '
        '_Label1_14
        '
        Me._Label1_14.BackColor = System.Drawing.Color.Transparent
        Me._Label1_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_14.Location = New System.Drawing.Point(313, 21)
        Me._Label1_14.Name = "_Label1_14"
        Me._Label1_14.Size = New System.Drawing.Size(74, 15)
        Me._Label1_14.TabIndex = 25
        Me._Label1_14.Tag = "Study promotion"
        Me._Label1_14.Text = "Khuyến học"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.White
        Me.Frame1.Controls.Add(Me.GrdVT)
        Me.Frame1.Controls.Add(Me.CboQH)
        Me.Frame1.Controls.Add(Me.cmdct)
        Me.Frame1.Controls.Add(Me._txt_2)
        Me.Frame1.Controls.Add(Me._txt_1)
        Me.Frame1.Controls.Add(Me._txt_0)
        Me.Frame1.Controls.Add(Me._MedNgay_1)
        Me.Frame1.Controls.Add(Me._MedNgay_2)
        Me.Frame1.Controls.Add(Me._MedNgay_0)
        Me.Frame1.Controls.Add(Me._Label_7)
        Me.Frame1.Controls.Add(Me._Label_3)
        Me.Frame1.Controls.Add(Me._Label_2)
        Me.Frame1.Controls.Add(Me._Label_6)
        Me.Frame1.Controls.Add(Me._Label_8)
        Me.Frame1.Controls.Add(Me._Label_9)
        Me.Frame1.Controls.Add(Me._Label_11)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(173, 14)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(654, 236)
        Me.Frame1.TabIndex = 13
        Me.Frame1.TabStop = False
        Me.Frame1.Tag = "Family allowances"
        Me.Frame1.Text = "Giảm trừ gia cảnh"
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
        Me.GrdVT.Location = New System.Drawing.Point(7, 59)
        Me.GrdVT.Name = "GrdVT"
        Me.GrdVT.Row = 0
        Me.GrdVT.Rows = 0
        Me.GrdVT.Selectable = True
        Me.GrdVT.SelectedTextColor = System.Drawing.Color.White
        Me.GrdVT.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.GrdVT.ShowBorder = True
        Me.GrdVT.ShowFocusRect = False
        Me.GrdVT.Size = New System.Drawing.Size(636, 150)
        Me.GrdVT.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdVT.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdVT.TabIndex = 10
        '
        'CboQH
        '
        Me.CboQH.BackColor = System.Drawing.SystemColors.Window
        Me.CboQH.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboQH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboQH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboQH.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboQH.Location = New System.Drawing.Point(447, 208)
        Me.CboQH.Name = "CboQH"
        Me.CboQH.Size = New System.Drawing.Size(67, 21)
        Me.CboQH.TabIndex = 4
        '
        'cmdct
        '
        Me.cmdct.BackColor = System.Drawing.SystemColors.Control
        Me.cmdct.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdct.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdct.Image = CType(resources.GetObject("cmdct.Image"), System.Drawing.Image)
        Me.cmdct.Location = New System.Drawing.Point(627, 208)
        Me.cmdct.Name = "cmdct"
        Me.cmdct.Size = New System.Drawing.Size(16, 20)
        Me.cmdct.TabIndex = 7
        Me.cmdct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdct.UseVisualStyleBackColor = False
        '
        '_txt_2
        '
        Me._txt_2.AcceptsReturn = True
        Me._txt_2.BackColor = System.Drawing.SystemColors.Window
        Me._txt_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_2.Location = New System.Drawing.Point(353, 208)
        Me._txt_2.MaxLength = 100
        Me._txt_2.Name = "_txt_2"
        Me._txt_2.Size = New System.Drawing.Size(94, 21)
        Me._txt_2.TabIndex = 3
        Me._txt_2.Text = "..."
        Me._txt_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txt_1
        '
        Me._txt_1.AcceptsReturn = True
        Me._txt_1.BackColor = System.Drawing.SystemColors.Window
        Me._txt_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_1.Location = New System.Drawing.Point(273, 208)
        Me._txt_1.MaxLength = 100
        Me._txt_1.Name = "_txt_1"
        Me._txt_1.Size = New System.Drawing.Size(81, 21)
        Me._txt_1.TabIndex = 2
        Me._txt_1.Text = "..."
        Me._txt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txt_0
        '
        Me._txt_0.AcceptsReturn = True
        Me._txt_0.BackColor = System.Drawing.SystemColors.Window
        Me._txt_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_0.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_0.Location = New System.Drawing.Point(7, 208)
        Me._txt_0.MaxLength = 100
        Me._txt_0.Name = "_txt_0"
        Me._txt_0.Size = New System.Drawing.Size(220, 21)
        Me._txt_0.TabIndex = 0
        Me._txt_0.Text = "..."
        '
        '_MedNgay_1
        '
        Me._MedNgay_1.AllowPromptAsInput = False
        Me._MedNgay_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_1.Location = New System.Drawing.Point(513, 208)
        Me._MedNgay_1.Mask = "00/00/0000"
        Me._MedNgay_1.Name = "_MedNgay_1"
        Me._MedNgay_1.Size = New System.Drawing.Size(54, 20)
        Me._MedNgay_1.TabIndex = 5
        '
        '_MedNgay_2
        '
        Me._MedNgay_2.AllowPromptAsInput = False
        Me._MedNgay_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_2.Location = New System.Drawing.Point(567, 208)
        Me._MedNgay_2.Name = "_MedNgay_2"
        Me._MedNgay_2.Size = New System.Drawing.Size(60, 20)
        Me._MedNgay_2.TabIndex = 6
        '
        '_MedNgay_0
        '
        Me._MedNgay_0.AllowPromptAsInput = False
        Me._MedNgay_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_0.Location = New System.Drawing.Point(227, 209)
        Me._MedNgay_0.Mask = "00/00/0000"
        Me._MedNgay_0.Name = "_MedNgay_0"
        Me._MedNgay_0.Size = New System.Drawing.Size(47, 20)
        Me._MedNgay_0.TabIndex = 1
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(7, 21)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(220, 39)
        Me._Label_7.TabIndex = 20
        Me._Label_7.Tag = "Full name"
        Me._Label_7.Text = "Họ và tên(*)"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.Black
        Me._Label_3.Location = New System.Drawing.Point(353, 21)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(94, 39)
        Me._Label_3.TabIndex = 19
        Me._Label_3.Tag = "         ID card /           Passport"
        Me._Label_3.Text = "          Số CMND/         hộ chiếu"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.Black
        Me._Label_2.Location = New System.Drawing.Point(273, 21)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(81, 39)
        Me._Label_2.TabIndex = 18
        Me._Label_2.Tag = "Code tax"
        Me._Label_2.Text = "Mã số thuế"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.Color.Black
        Me._Label_6.Location = New System.Drawing.Point(227, 21)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(47, 39)
        Me._Label_6.TabIndex = 17
        Me._Label_6.Tag = "Date of birth"
        Me._Label_6.Text = "Ngày sinh(*)"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.Color.Black
        Me._Label_8.Location = New System.Drawing.Point(447, 21)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(67, 39)
        Me._Label_8.TabIndex = 16
        Me._Label_8.Tag = "Relations with employee"
        Me._Label_8.Text = "Quan hệ với ĐTNT(*)"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_9
        '
        Me._Label_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.Color.Black
        Me._Label_9.Location = New System.Drawing.Point(513, 21)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.Size = New System.Drawing.Size(54, 39)
        Me._Label_9.TabIndex = 15
        Me._Label_9.Tag = "From "
        Me._Label_9.Text = "  Thời điểm tính giảm trừ (tháng năm)"
        Me._Label_9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.Color.Black
        Me._Label_11.Location = New System.Drawing.Point(567, 21)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(60, 39)
        Me._Label_11.TabIndex = 14
        Me._Label_11.Tag = "To"
        Me._Label_11.Text = "Thời điểm kết thúc giảm trừ (tháng năm)"
        Me._Label_11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Command_3
        '
        Me._Command_3.Image = CType(resources.GetObject("_Command_3.Image"), System.Drawing.Image)
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(770, 323)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(71, 26)
        Me._Command_3.TabIndex = 29
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_Command_4
        '
        Me._Command_4.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Print
        Me._Command_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_4.Location = New System.Drawing.Point(540, 323)
        Me._Command_4.Name = "_Command_4"
        Me._Command_4.Size = New System.Drawing.Size(71, 26)
        Me._Command_4.TabIndex = 30
        Me._Command_4.Tag = "Print"
        Me._Command_4.Text = "&In"
        '
        'SSCmdF
        '
        Me.SSCmdF.Image = CType(resources.GetObject("SSCmdF.Image"), System.Drawing.Image)
        Me.SSCmdF.Location = New System.Drawing.Point(259, 333)
        Me.SSCmdF.Name = "SSCmdF"
        Me.SSCmdF.Size = New System.Drawing.Size(30, 19)
        Me.SSCmdF.TabIndex = 31
        '
        '_Command_2
        '
        Me._Command_2.Image = CType(resources.GetObject("_Command_2.Image"), System.Drawing.Image)
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(693, 323)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(71, 26)
        Me._Command_2.TabIndex = 38
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_1
        '
        Me._Command_1.Image = CType(resources.GetObject("_Command_1.Image"), System.Drawing.Image)
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(617, 323)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(70, 26)
        Me._Command_1.TabIndex = 39
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Window
        Me._Label1_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.Location = New System.Drawing.Point(167, 7)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.Size = New System.Drawing.Size(667, 306)
        Me._Label1_0.TabIndex = 22
        '
        'frmGiamtru
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(853, 356)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me.LstVt)
        Me.Controls.Add(Me.CboLoai)
        Me.Controls.Add(Me._SSOpt_0)
        Me.Controls.Add(Me._SSOpt_1)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_4)
        Me.Controls.Add(Me.SSCmdF)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Label1_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(4, 30)
        Me.MaximizeBox = False
        Me.Name = "frmGiamtru"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Reduce personal income tax"
        Me.Text = "Giảm trừ thuế thu nhập cá nhân"
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub Initializetxt()
		Me.txt(4) = _txt_4
		Me.txt(5) = _txt_5
		Me.txt(6) = _txt_6
		Me.txt(2) = _txt_2
		Me.txt(1) = _txt_1
		Me.txt(0) = _txt_0
	End Sub
	Sub InitializeSSOpt()
		Me.SSOpt(0) = _SSOpt_0
		Me.SSOpt(1) = _SSOpt_1
	End Sub
	Sub InitializeMedNgay()
		Me.MedNgay(1) = _MedNgay_1
		Me.MedNgay(2) = _MedNgay_2
		Me.MedNgay(0) = _MedNgay_0
	End Sub
	Sub InitializeLine()
		Me.Line(12) = _Line_12
		Me.Line(10) = _Line_10
		Me.Line(11) = _Line_11
	End Sub
	Sub InitializeLabel1()
		Me.Label1(3) = _Label1_3
		Me.Label1(12) = _Label1_12
		Me.Label1(13) = _Label1_13
		Me.Label1(14) = _Label1_14
		Me.Label1(0) = _Label1_0
        'Me.Label1(1) = _Label1_1
        'Me.Label1(2) = _Label1_2
	End Sub
	Sub InitializeLabel()
		Me.Label(7) = _Label_7
		Me.Label(3) = _Label_3
		Me.Label(2) = _Label_2
		Me.Label(6) = _Label_6
		Me.Label(8) = _Label_8
		Me.Label(9) = _Label_9
		Me.Label(11) = _Label_11
        'Me.Label(0) = _Label_0
	End Sub
	Sub InitializeCommand()
		Me.Command(3) = _Command_3
		Me.Command(4) = _Command_4
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
	End Sub
#End Region 
End Class
