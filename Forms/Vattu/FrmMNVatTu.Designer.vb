<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMNVatTu
    Inherits System.Windows.Forms.Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeLine3()
		InitializeLine22()
		InitializeFrame1()
		InitializeCmd1()
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
    Private WithEvents _Cmd1_7 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_8 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_9 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_11 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_12 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_13 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_14 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_15 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_19 As System.Windows.Forms.Button
    Private WithEvents _Frame1_1 As System.Windows.Forms.GroupBox
    Private WithEvents _Cmd1_0 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_1 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_2 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_3 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_4 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_5 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_6 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_10 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_17 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_18 As System.Windows.Forms.Button
    Private WithEvents _Line22_2 As System.Windows.Forms.Label
    Private WithEvents _Line22_1 As System.Windows.Forms.Label
    Private WithEvents _Line3_1 As System.Windows.Forms.Label
    Public WithEvents Line26 As System.Windows.Forms.Label
    Public WithEvents Line24 As System.Windows.Forms.Label
    Public WithEvents Line23 As System.Windows.Forms.Label
    Public WithEvents Line1 As System.Windows.Forms.Label
    Public WithEvents Line2 As System.Windows.Forms.Label
    Private WithEvents _Line3_0 As System.Windows.Forms.Label
    Public WithEvents Line4 As System.Windows.Forms.Label
    Public WithEvents Line5 As System.Windows.Forms.Label
    Public WithEvents Line6 As System.Windows.Forms.Label
    Public WithEvents Line7 As System.Windows.Forms.Label
    Public WithEvents Line8 As System.Windows.Forms.Label
    Public WithEvents Line9 As System.Windows.Forms.Label
    Public WithEvents Line10 As System.Windows.Forms.Label
    Public WithEvents Line11 As System.Windows.Forms.Label
    Public WithEvents Line12 As System.Windows.Forms.Label
    Public WithEvents Line13 As System.Windows.Forms.Label
    Public WithEvents Line14 As System.Windows.Forms.Label
    Public WithEvents Line17 As System.Windows.Forms.Label
    Public WithEvents Line18 As System.Windows.Forms.Label
    Public WithEvents Line21 As System.Windows.Forms.Label
    Private WithEvents _Line22_0 As System.Windows.Forms.Label
    Private WithEvents _Frame1_0 As System.Windows.Forms.GroupBox
    Private WithEvents _Cmd1_16 As System.Windows.Forms.Button
    Public Cmd1(22) As System.Windows.Forms.Button
    Public Frame1(1) As System.Windows.Forms.GroupBox
    Public Line22(2) As System.Windows.Forms.Label
    Public Line3(1) As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMNVatTu))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Frame1_1 = New System.Windows.Forms.GroupBox()
        Me._Cmd1_8 = New System.Windows.Forms.Button()
        Me._Cmd1_9 = New System.Windows.Forms.Button()
        Me._Cmd1_11 = New System.Windows.Forms.Button()
        Me._Cmd1_12 = New System.Windows.Forms.Button()
        Me._Cmd1_7 = New System.Windows.Forms.Button()
        Me._Cmd1_14 = New System.Windows.Forms.Button()
        Me._Cmd1_13 = New System.Windows.Forms.Button()
        Me._Frame1_0 = New System.Windows.Forms.GroupBox()
        Me._Cmd1_19 = New System.Windows.Forms.Button()
        Me._Cmd1_6 = New System.Windows.Forms.Button()
        Me._Cmd1_17 = New System.Windows.Forms.Button()
        Me._Cmd1_18 = New System.Windows.Forms.Button()
        Me._Line22_2 = New System.Windows.Forms.Label()
        Me._Line22_1 = New System.Windows.Forms.Label()
        Me._Line3_1 = New System.Windows.Forms.Label()
        Me.Line26 = New System.Windows.Forms.Label()
        Me.Line24 = New System.Windows.Forms.Label()
        Me.Line23 = New System.Windows.Forms.Label()
        Me.Line1 = New System.Windows.Forms.Label()
        Me.Line2 = New System.Windows.Forms.Label()
        Me._Line3_0 = New System.Windows.Forms.Label()
        Me.Line4 = New System.Windows.Forms.Label()
        Me.Line5 = New System.Windows.Forms.Label()
        Me.Line6 = New System.Windows.Forms.Label()
        Me.Line7 = New System.Windows.Forms.Label()
        Me.Line8 = New System.Windows.Forms.Label()
        Me.Line9 = New System.Windows.Forms.Label()
        Me.Line10 = New System.Windows.Forms.Label()
        Me.Line11 = New System.Windows.Forms.Label()
        Me.Line12 = New System.Windows.Forms.Label()
        Me.Line13 = New System.Windows.Forms.Label()
        Me.Line14 = New System.Windows.Forms.Label()
        Me.Line17 = New System.Windows.Forms.Label()
        Me.Line18 = New System.Windows.Forms.Label()
        Me.Line21 = New System.Windows.Forms.Label()
        Me._Line22_0 = New System.Windows.Forms.Label()
        Me._Cmd1_15 = New System.Windows.Forms.Button()
        Me._Cmd1_0 = New System.Windows.Forms.Button()
        Me._Cmd1_1 = New System.Windows.Forms.Button()
        Me._Cmd1_2 = New System.Windows.Forms.Button()
        Me._Cmd1_3 = New System.Windows.Forms.Button()
        Me._Cmd1_4 = New System.Windows.Forms.Button()
        Me._Cmd1_5 = New System.Windows.Forms.Button()
        Me._Cmd1_10 = New System.Windows.Forms.Button()
        Me._Cmd1_16 = New System.Windows.Forms.Button()
        Me._Cmd1_22 = New System.Windows.Forms.Button()
        Me._Cmd1_20 = New System.Windows.Forms.Button()
        Me._Cmd1_21 = New System.Windows.Forms.Button()
        Me.LabelControl7 = New System.Windows.Forms.Label()
        Me.LabelControl1 = New System.Windows.Forms.Label()
        Me.LabelControl2 = New System.Windows.Forms.Label()
        Me.LabelControl3 = New System.Windows.Forms.Label()
        Me.LabelControl4 = New System.Windows.Forms.Label()
        Me.LabelControl5 = New System.Windows.Forms.Label()
        Me.LabelControl6 = New System.Windows.Forms.Label()
        Me.LabelControl8 = New System.Windows.Forms.Label()
        Me.LabelControl9 = New System.Windows.Forms.Label()
        Me.LabelControl10 = New System.Windows.Forms.Label()
        Me.LabelControl11 = New System.Windows.Forms.Label()
        Me.LabelControl12 = New System.Windows.Forms.Label()
        Me._Frame1_0.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Frame1_1
        '
        Me._Frame1_1.BackColor = System.Drawing.Color.Transparent
        Me._Frame1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame1_1.ForeColor = System.Drawing.Color.Blue
        Me._Frame1_1.Location = New System.Drawing.Point(357, 233)
        Me._Frame1_1.Name = "_Frame1_1"
        Me._Frame1_1.Size = New System.Drawing.Size(79, 19)
        Me._Frame1_1.TabIndex = 19
        Me._Frame1_1.TabStop = False
        Me._Frame1_1.Tag = "Lists"
        Me._Frame1_1.Text = "Danh mục"
        Me._Frame1_1.Visible = False
        '
        '_Cmd1_8
        '
        Me._Cmd1_8.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_8.Cursor = System.Windows.Forms.Cursors.Hand
        Me._Cmd1_8.FlatAppearance.BorderSize = 0
        Me._Cmd1_8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cmd1_8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me._Cmd1_8.Image = CType(resources.GetObject("_Cmd1_8.Image"), System.Drawing.Image)
        Me._Cmd1_8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_8.Location = New System.Drawing.Point(138, 373)
        Me._Cmd1_8.Name = "_Cmd1_8"
        Me._Cmd1_8.Size = New System.Drawing.Size(81, 68)
        Me._Cmd1_8.TabIndex = 10
        Me._Cmd1_8.Tag = "Stock list"
        Me._Cmd1_8.Text = "Danh sách kho"
        Me._Cmd1_8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_8.UseVisualStyleBackColor = False
        '
        '_Cmd1_9
        '
        Me._Cmd1_9.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_9.Cursor = System.Windows.Forms.Cursors.Hand
        Me._Cmd1_9.FlatAppearance.BorderSize = 0
        Me._Cmd1_9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cmd1_9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me._Cmd1_9.Image = CType(resources.GetObject("_Cmd1_9.Image"), System.Drawing.Image)
        Me._Cmd1_9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_9.Location = New System.Drawing.Point(243, 373)
        Me._Cmd1_9.Name = "_Cmd1_9"
        Me._Cmd1_9.Size = New System.Drawing.Size(81, 68)
        Me._Cmd1_9.TabIndex = 11
        Me._Cmd1_9.Tag = "Classification"
        Me._Cmd1_9.Text = "Phân loại vật tư"
        Me._Cmd1_9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_9.UseVisualStyleBackColor = False
        '
        '_Cmd1_11
        '
        Me._Cmd1_11.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_11.Cursor = System.Windows.Forms.Cursors.Hand
        Me._Cmd1_11.FlatAppearance.BorderSize = 0
        Me._Cmd1_11.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cmd1_11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me._Cmd1_11.Image = CType(resources.GetObject("_Cmd1_11.Image"), System.Drawing.Image)
        Me._Cmd1_11.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_11.Location = New System.Drawing.Point(346, 373)
        Me._Cmd1_11.Name = "_Cmd1_11"
        Me._Cmd1_11.Size = New System.Drawing.Size(81, 68)
        Me._Cmd1_11.TabIndex = 12
        Me._Cmd1_11.Tag = "List of materials"
        Me._Cmd1_11.Text = "Danh sách vật tư"
        Me._Cmd1_11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_11.UseVisualStyleBackColor = False
        '
        '_Cmd1_12
        '
        Me._Cmd1_12.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_12.Cursor = System.Windows.Forms.Cursors.Hand
        Me._Cmd1_12.FlatAppearance.BorderSize = 0
        Me._Cmd1_12.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cmd1_12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me._Cmd1_12.Image = CType(resources.GetObject("_Cmd1_12.Image"), System.Drawing.Image)
        Me._Cmd1_12.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_12.Location = New System.Drawing.Point(553, 372)
        Me._Cmd1_12.Name = "_Cmd1_12"
        Me._Cmd1_12.Size = New System.Drawing.Size(81, 68)
        Me._Cmd1_12.TabIndex = 14
        Me._Cmd1_12.Tag = "To provide for lower"
        Me._Cmd1_12.Text = "Dự phòng giảm giá"
        Me._Cmd1_12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_12.UseVisualStyleBackColor = False
        '
        '_Cmd1_7
        '
        Me._Cmd1_7.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_7.Cursor = System.Windows.Forms.Cursors.Hand
        Me._Cmd1_7.FlatAppearance.BorderSize = 0
        Me._Cmd1_7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cmd1_7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me._Cmd1_7.Image = CType(resources.GetObject("_Cmd1_7.Image"), System.Drawing.Image)
        Me._Cmd1_7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_7.Location = New System.Drawing.Point(33, 371)
        Me._Cmd1_7.Name = "_Cmd1_7"
        Me._Cmd1_7.Size = New System.Drawing.Size(81, 68)
        Me._Cmd1_7.TabIndex = 9
        Me._Cmd1_7.Tag = "Distribution channels"
        Me._Cmd1_7.Text = "Kênh phân phối"
        Me._Cmd1_7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_7.UseVisualStyleBackColor = False
        '
        '_Cmd1_14
        '
        Me._Cmd1_14.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_14.Cursor = System.Windows.Forms.Cursors.Hand
        Me._Cmd1_14.FlatAppearance.BorderSize = 0
        Me._Cmd1_14.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cmd1_14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me._Cmd1_14.Image = CType(resources.GetObject("_Cmd1_14.Image"), System.Drawing.Image)
        Me._Cmd1_14.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_14.Location = New System.Drawing.Point(656, 375)
        Me._Cmd1_14.Name = "_Cmd1_14"
        Me._Cmd1_14.Size = New System.Drawing.Size(81, 68)
        Me._Cmd1_14.TabIndex = 15
        Me._Cmd1_14.Tag = "Set saling account"
        Me._Cmd1_14.Text = "Chi tiết TK doanh thu"
        Me._Cmd1_14.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_14.UseVisualStyleBackColor = False
        '
        '_Cmd1_13
        '
        Me._Cmd1_13.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_13.Cursor = System.Windows.Forms.Cursors.Hand
        Me._Cmd1_13.FlatAppearance.BorderSize = 0
        Me._Cmd1_13.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cmd1_13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me._Cmd1_13.Image = CType(resources.GetObject("_Cmd1_13.Image"), System.Drawing.Image)
        Me._Cmd1_13.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_13.Location = New System.Drawing.Point(451, 373)
        Me._Cmd1_13.Name = "_Cmd1_13"
        Me._Cmd1_13.Size = New System.Drawing.Size(81, 68)
        Me._Cmd1_13.TabIndex = 13
        Me._Cmd1_13.Tag = "Set gooding account"
        Me._Cmd1_13.Text = "Chi tiết TK vật tư"
        Me._Cmd1_13.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_13.UseVisualStyleBackColor = False
        '
        '_Frame1_0
        '
        Me._Frame1_0.BackColor = System.Drawing.Color.Transparent
        Me._Frame1_0.Controls.Add(Me._Cmd1_19)
        Me._Frame1_0.Controls.Add(Me._Cmd1_6)
        Me._Frame1_0.Controls.Add(Me._Cmd1_17)
        Me._Frame1_0.Controls.Add(Me._Cmd1_18)
        Me._Frame1_0.Controls.Add(Me._Line22_2)
        Me._Frame1_0.Controls.Add(Me._Line22_1)
        Me._Frame1_0.Controls.Add(Me._Line3_1)
        Me._Frame1_0.Controls.Add(Me.Line26)
        Me._Frame1_0.Controls.Add(Me.Line24)
        Me._Frame1_0.Controls.Add(Me.Line23)
        Me._Frame1_0.Controls.Add(Me.Line1)
        Me._Frame1_0.Controls.Add(Me.Line2)
        Me._Frame1_0.Controls.Add(Me._Line3_0)
        Me._Frame1_0.Controls.Add(Me.Line4)
        Me._Frame1_0.Controls.Add(Me.Line5)
        Me._Frame1_0.Controls.Add(Me.Line6)
        Me._Frame1_0.Controls.Add(Me.Line7)
        Me._Frame1_0.Controls.Add(Me.Line8)
        Me._Frame1_0.Controls.Add(Me.Line9)
        Me._Frame1_0.Controls.Add(Me.Line10)
        Me._Frame1_0.Controls.Add(Me.Line11)
        Me._Frame1_0.Controls.Add(Me.Line12)
        Me._Frame1_0.Controls.Add(Me.Line13)
        Me._Frame1_0.Controls.Add(Me.Line14)
        Me._Frame1_0.Controls.Add(Me.Line17)
        Me._Frame1_0.Controls.Add(Me.Line18)
        Me._Frame1_0.Controls.Add(Me.Line21)
        Me._Frame1_0.Controls.Add(Me._Line22_0)
        Me._Frame1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame1_0.ForeColor = System.Drawing.Color.Blue
        Me._Frame1_0.Location = New System.Drawing.Point(250, 176)
        Me._Frame1_0.Name = "_Frame1_0"
        Me._Frame1_0.Size = New System.Drawing.Size(114, 51)
        Me._Frame1_0.TabIndex = 18
        Me._Frame1_0.TabStop = False
        Me._Frame1_0.Tag = "Functional diagram"
        Me._Frame1_0.Text = "Sơ đồ chức năng"
        Me._Frame1_0.Visible = False
        '
        '_Cmd1_19
        '
        Me._Cmd1_19.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Hoa_don_Noi_dia
        Me._Cmd1_19.Location = New System.Drawing.Point(85, 16)
        Me._Cmd1_19.Name = "_Cmd1_19"
        Me._Cmd1_19.Size = New System.Drawing.Size(78, 59)
        Me._Cmd1_19.TabIndex = 21
        Me._Cmd1_19.Tag = "Domestic contract"
        Me._Cmd1_19.Text = "Hoá đơn nội địa   "
        '
        '_Cmd1_6
        '
        Me._Cmd1_6.Image = Nothing 'Global.NVC.My.Resources.Resources._32x32_Kiem_tra_NXT
        Me._Cmd1_6.Location = New System.Drawing.Point(243, 16)
        Me._Cmd1_6.Name = "_Cmd1_6"
        Me._Cmd1_6.Size = New System.Drawing.Size(73, 73)
        Me._Cmd1_6.TabIndex = 6
        Me._Cmd1_6.Tag = "Inventory Check-Up"
        Me._Cmd1_6.Text = "Kiểm tra " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NXT"
        '
        '_Cmd1_17
        '
        Me._Cmd1_17.Location = New System.Drawing.Point(164, 16)
        Me._Cmd1_17.Name = "_Cmd1_17"
        Me._Cmd1_17.Size = New System.Drawing.Size(73, 73)
        Me._Cmd1_17.TabIndex = 20
        Me._Cmd1_17.Tag = "Retail listing"
        Me._Cmd1_17.Text = "Lập bảng" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "kê bán lẻ"
        '
        '_Cmd1_18
        '
        Me._Cmd1_18.Image = Nothing 'Global.NVC.My.Resources.Resources._32x32_Nhap_noi_dia
        Me._Cmd1_18.Location = New System.Drawing.Point(6, 16)
        Me._Cmd1_18.Name = "_Cmd1_18"
        Me._Cmd1_18.Size = New System.Drawing.Size(73, 73)
        Me._Cmd1_18.TabIndex = 1
        Me._Cmd1_18.Tag = "Domestic purchase"
        Me._Cmd1_18.Text = "Nhập nội địa"
        '
        '_Line22_2
        '
        Me._Line22_2.BackColor = System.Drawing.Color.Blue
        Me._Line22_2.Enabled = False
        Me._Line22_2.Location = New System.Drawing.Point(224, 96)
        Me._Line22_2.Name = "_Line22_2"
        Me._Line22_2.Size = New System.Drawing.Size(1, 16)
        Me._Line22_2.TabIndex = 21
        '
        '_Line22_1
        '
        Me._Line22_1.BackColor = System.Drawing.Color.Blue
        Me._Line22_1.Enabled = False
        Me._Line22_1.Location = New System.Drawing.Point(128, 96)
        Me._Line22_1.Name = "_Line22_1"
        Me._Line22_1.Size = New System.Drawing.Size(1, 16)
        Me._Line22_1.TabIndex = 22
        '
        '_Line3_1
        '
        Me._Line3_1.BackColor = System.Drawing.Color.Blue
        Me._Line3_1.Enabled = False
        Me._Line3_1.Location = New System.Drawing.Point(128, 112)
        Me._Line3_1.Name = "_Line3_1"
        Me._Line3_1.Size = New System.Drawing.Size(97, 1)
        Me._Line3_1.TabIndex = 23
        '
        'Line26
        '
        Me.Line26.BackColor = System.Drawing.Color.Blue
        Me.Line26.Enabled = False
        Me.Line26.Location = New System.Drawing.Point(176, 112)
        Me.Line26.Name = "Line26"
        Me.Line26.Size = New System.Drawing.Size(1, 16)
        Me.Line26.TabIndex = 24
        '
        'Line24
        '
        Me.Line24.BackColor = System.Drawing.Color.Red
        Me.Line24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Line24.Enabled = False
        Me.Line24.ForeColor = System.Drawing.Color.Black
        Me.Line24.Location = New System.Drawing.Point(176, 120)
        Me.Line24.Name = "Line24"
        Me.Line24.Size = New System.Drawing.Size(8, 8)
        Me.Line24.TabIndex = 25
        Me.Line24.Text = "Line24"
        '
        'Line23
        '
        Me.Line23.BackColor = System.Drawing.Color.Red
        Me.Line23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Line23.Enabled = False
        Me.Line23.ForeColor = System.Drawing.Color.Black
        Me.Line23.Location = New System.Drawing.Point(168, 120)
        Me.Line23.Name = "Line23"
        Me.Line23.Size = New System.Drawing.Size(8, 8)
        Me.Line23.TabIndex = 26
        Me.Line23.Text = "Line23"
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.Color.Blue
        Me.Line1.Enabled = False
        Me.Line1.Location = New System.Drawing.Point(88, 96)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(16, 1)
        Me.Line1.TabIndex = 27
        '
        'Line2
        '
        Me.Line2.BackColor = System.Drawing.Color.Blue
        Me.Line2.Enabled = False
        Me.Line2.Location = New System.Drawing.Point(88, 248)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(16, 1)
        Me.Line2.TabIndex = 28
        '
        '_Line3_0
        '
        Me._Line3_0.BackColor = System.Drawing.Color.Blue
        Me._Line3_0.Enabled = False
        Me._Line3_0.Location = New System.Drawing.Point(240, 128)
        Me._Line3_0.Name = "_Line3_0"
        Me._Line3_0.Size = New System.Drawing.Size(16, 1)
        Me._Line3_0.TabIndex = 29
        '
        'Line4
        '
        Me.Line4.BackColor = System.Drawing.Color.Blue
        Me.Line4.Enabled = False
        Me.Line4.Location = New System.Drawing.Point(240, 224)
        Me.Line4.Name = "Line4"
        Me.Line4.Size = New System.Drawing.Size(16, 1)
        Me.Line4.TabIndex = 30
        '
        'Line5
        '
        Me.Line5.BackColor = System.Drawing.Color.Blue
        Me.Line5.Enabled = False
        Me.Line5.Location = New System.Drawing.Point(128, 232)
        Me.Line5.Name = "Line5"
        Me.Line5.Size = New System.Drawing.Size(1, 16)
        Me.Line5.TabIndex = 31
        '
        'Line6
        '
        Me.Line6.BackColor = System.Drawing.Color.Blue
        Me.Line6.Enabled = False
        Me.Line6.Location = New System.Drawing.Point(224, 232)
        Me.Line6.Name = "Line6"
        Me.Line6.Size = New System.Drawing.Size(1, 16)
        Me.Line6.TabIndex = 32
        '
        'Line7
        '
        Me.Line7.BackColor = System.Drawing.Color.Red
        Me.Line7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Line7.Enabled = False
        Me.Line7.ForeColor = System.Drawing.Color.Black
        Me.Line7.Location = New System.Drawing.Point(120, 168)
        Me.Line7.Name = "Line7"
        Me.Line7.Size = New System.Drawing.Size(8, 8)
        Me.Line7.TabIndex = 33
        Me.Line7.Text = "Line7"
        '
        'Line8
        '
        Me.Line8.BackColor = System.Drawing.Color.Red
        Me.Line8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Line8.Enabled = False
        Me.Line8.ForeColor = System.Drawing.Color.Black
        Me.Line8.Location = New System.Drawing.Point(120, 176)
        Me.Line8.Name = "Line8"
        Me.Line8.Size = New System.Drawing.Size(8, 8)
        Me.Line8.TabIndex = 34
        Me.Line8.Text = "Line8"
        '
        'Line9
        '
        Me.Line9.BackColor = System.Drawing.Color.Red
        Me.Line9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Line9.Enabled = False
        Me.Line9.ForeColor = System.Drawing.Color.Black
        Me.Line9.Location = New System.Drawing.Point(216, 168)
        Me.Line9.Name = "Line9"
        Me.Line9.Size = New System.Drawing.Size(8, 8)
        Me.Line9.TabIndex = 35
        Me.Line9.Text = "Line9"
        '
        'Line10
        '
        Me.Line10.BackColor = System.Drawing.Color.Blue
        Me.Line10.Enabled = False
        Me.Line10.Location = New System.Drawing.Point(240, 128)
        Me.Line10.Name = "Line10"
        Me.Line10.Size = New System.Drawing.Size(1, 96)
        Me.Line10.TabIndex = 36
        '
        'Line11
        '
        Me.Line11.BackColor = System.Drawing.Color.Blue
        Me.Line11.Enabled = False
        Me.Line11.Location = New System.Drawing.Point(216, 176)
        Me.Line11.Name = "Line11"
        Me.Line11.Size = New System.Drawing.Size(24, 1)
        Me.Line11.TabIndex = 37
        '
        'Line12
        '
        Me.Line12.BackColor = System.Drawing.Color.Red
        Me.Line12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Line12.Enabled = False
        Me.Line12.ForeColor = System.Drawing.Color.Black
        Me.Line12.Location = New System.Drawing.Point(216, 176)
        Me.Line12.Name = "Line12"
        Me.Line12.Size = New System.Drawing.Size(8, 8)
        Me.Line12.TabIndex = 38
        Me.Line12.Text = "Line12"
        '
        'Line13
        '
        Me.Line13.BackColor = System.Drawing.Color.Blue
        Me.Line13.Enabled = False
        Me.Line13.Location = New System.Drawing.Point(176, 216)
        Me.Line13.Name = "Line13"
        Me.Line13.Size = New System.Drawing.Size(1, 16)
        Me.Line13.TabIndex = 39
        '
        'Line14
        '
        Me.Line14.BackColor = System.Drawing.Color.Blue
        Me.Line14.Enabled = False
        Me.Line14.Location = New System.Drawing.Point(128, 232)
        Me.Line14.Name = "Line14"
        Me.Line14.Size = New System.Drawing.Size(96, 1)
        Me.Line14.TabIndex = 40
        '
        'Line17
        '
        Me.Line17.BackColor = System.Drawing.Color.Red
        Me.Line17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Line17.Enabled = False
        Me.Line17.ForeColor = System.Drawing.Color.Black
        Me.Line17.Location = New System.Drawing.Point(168, 216)
        Me.Line17.Name = "Line17"
        Me.Line17.Size = New System.Drawing.Size(8, 8)
        Me.Line17.TabIndex = 41
        Me.Line17.Text = "Line17"
        '
        'Line18
        '
        Me.Line18.BackColor = System.Drawing.Color.Red
        Me.Line18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Line18.Enabled = False
        Me.Line18.ForeColor = System.Drawing.Color.Black
        Me.Line18.Location = New System.Drawing.Point(176, 216)
        Me.Line18.Name = "Line18"
        Me.Line18.Size = New System.Drawing.Size(8, 8)
        Me.Line18.TabIndex = 42
        Me.Line18.Text = "Line18"
        '
        'Line21
        '
        Me.Line21.BackColor = System.Drawing.Color.Blue
        Me.Line21.Enabled = False
        Me.Line21.Location = New System.Drawing.Point(88, 176)
        Me.Line21.Name = "Line21"
        Me.Line21.Size = New System.Drawing.Size(40, 1)
        Me.Line21.TabIndex = 43
        '
        '_Line22_0
        '
        Me._Line22_0.BackColor = System.Drawing.Color.Blue
        Me._Line22_0.Enabled = False
        Me._Line22_0.Location = New System.Drawing.Point(104, 96)
        Me._Line22_0.Name = "_Line22_0"
        Me._Line22_0.Size = New System.Drawing.Size(1, 153)
        Me._Line22_0.TabIndex = 44
        '
        '_Cmd1_15
        '
        Me._Cmd1_15.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_15.Cursor = System.Windows.Forms.Cursors.Hand
        Me._Cmd1_15.FlatAppearance.BorderSize = 0
        Me._Cmd1_15.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_15.Image = CType(resources.GetObject("_Cmd1_15.Image"), System.Drawing.Image)
        Me._Cmd1_15.Location = New System.Drawing.Point(469, 265)
        Me._Cmd1_15.Name = "_Cmd1_15"
        Me._Cmd1_15.Size = New System.Drawing.Size(125, 36)
        Me._Cmd1_15.TabIndex = 16
        Me._Cmd1_15.TabStop = False
        Me._Cmd1_15.Tag = "Import contracts"
        Me._Cmd1_15.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_15.UseVisualStyleBackColor = False
        '
        '_Cmd1_0
        '
        Me._Cmd1_0.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_0.Cursor = System.Windows.Forms.Cursors.Hand
        Me._Cmd1_0.FlatAppearance.BorderSize = 0
        Me._Cmd1_0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_0.Image = CType(resources.GetObject("_Cmd1_0.Image"), System.Drawing.Image)
        Me._Cmd1_0.Location = New System.Drawing.Point(30, 66)
        Me._Cmd1_0.Name = "_Cmd1_0"
        Me._Cmd1_0.Size = New System.Drawing.Size(131, 37)
        Me._Cmd1_0.TabIndex = 0
        Me._Cmd1_0.TabStop = False
        Me._Cmd1_0.Tag = "Purchase"
        Me._Cmd1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_0.UseVisualStyleBackColor = False
        '
        '_Cmd1_1
        '
        Me._Cmd1_1.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me._Cmd1_1.FlatAppearance.BorderSize = 0
        Me._Cmd1_1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_1.Image = CType(resources.GetObject("_Cmd1_1.Image"), System.Drawing.Image)
        Me._Cmd1_1.Location = New System.Drawing.Point(466, 61)
        Me._Cmd1_1.Name = "_Cmd1_1"
        Me._Cmd1_1.Size = New System.Drawing.Size(128, 43)
        Me._Cmd1_1.TabIndex = 2
        Me._Cmd1_1.TabStop = False
        Me._Cmd1_1.Tag = "Import"
        Me._Cmd1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_1.UseVisualStyleBackColor = False
        '
        '_Cmd1_2
        '
        Me._Cmd1_2.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me._Cmd1_2.FlatAppearance.BorderSize = 0
        Me._Cmd1_2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_2.Image = CType(resources.GetObject("_Cmd1_2.Image"), System.Drawing.Image)
        Me._Cmd1_2.Location = New System.Drawing.Point(466, 162)
        Me._Cmd1_2.Name = "_Cmd1_2"
        Me._Cmd1_2.Size = New System.Drawing.Size(128, 38)
        Me._Cmd1_2.TabIndex = 4
        Me._Cmd1_2.TabStop = False
        Me._Cmd1_2.Tag = "Reports"
        Me._Cmd1_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_2.UseVisualStyleBackColor = False
        '
        '_Cmd1_3
        '
        Me._Cmd1_3.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me._Cmd1_3.FlatAppearance.BorderSize = 0
        Me._Cmd1_3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_3.Image = CType(resources.GetObject("_Cmd1_3.Image"), System.Drawing.Image)
        Me._Cmd1_3.Location = New System.Drawing.Point(250, 63)
        Me._Cmd1_3.Name = "_Cmd1_3"
        Me._Cmd1_3.Size = New System.Drawing.Size(128, 37)
        Me._Cmd1_3.TabIndex = 7
        Me._Cmd1_3.TabStop = False
        Me._Cmd1_3.Tag = "Sales / Contracts"
        Me._Cmd1_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_3.UseVisualStyleBackColor = False
        '
        '_Cmd1_4
        '
        Me._Cmd1_4.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_4.Cursor = System.Windows.Forms.Cursors.Hand
        Me._Cmd1_4.FlatAppearance.BorderSize = 0
        Me._Cmd1_4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_4.Image = CType(resources.GetObject("_Cmd1_4.Image"), System.Drawing.Image)
        Me._Cmd1_4.Location = New System.Drawing.Point(708, 162)
        Me._Cmd1_4.Name = "_Cmd1_4"
        Me._Cmd1_4.Size = New System.Drawing.Size(127, 38)
        Me._Cmd1_4.TabIndex = 8
        Me._Cmd1_4.TabStop = False
        Me._Cmd1_4.Tag = "Bill"
        Me._Cmd1_4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_4.UseVisualStyleBackColor = False
        '
        '_Cmd1_5
        '
        Me._Cmd1_5.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_5.Cursor = System.Windows.Forms.Cursors.Hand
        Me._Cmd1_5.FlatAppearance.BorderSize = 0
        Me._Cmd1_5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_5.Image = CType(resources.GetObject("_Cmd1_5.Image"), System.Drawing.Image)
        Me._Cmd1_5.Location = New System.Drawing.Point(250, 264)
        Me._Cmd1_5.Name = "_Cmd1_5"
        Me._Cmd1_5.Size = New System.Drawing.Size(128, 40)
        Me._Cmd1_5.TabIndex = 5
        Me._Cmd1_5.TabStop = False
        Me._Cmd1_5.Tag = "Internally circulated"
        Me._Cmd1_5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_5.UseVisualStyleBackColor = False
        '
        '_Cmd1_10
        '
        Me._Cmd1_10.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_10.Cursor = System.Windows.Forms.Cursors.Hand
        Me._Cmd1_10.FlatAppearance.BorderSize = 0
        Me._Cmd1_10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_10.Image = CType(resources.GetObject("_Cmd1_10.Image"), System.Drawing.Image)
        Me._Cmd1_10.Location = New System.Drawing.Point(33, 268)
        Me._Cmd1_10.Name = "_Cmd1_10"
        Me._Cmd1_10.Size = New System.Drawing.Size(128, 36)
        Me._Cmd1_10.TabIndex = 3
        Me._Cmd1_10.TabStop = False
        Me._Cmd1_10.Tag = "Opening balance"
        Me._Cmd1_10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_10.UseVisualStyleBackColor = False
        '
        '_Cmd1_16
        '
        Me._Cmd1_16.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_16.FlatAppearance.BorderSize = 0
        Me._Cmd1_16.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cmd1_16.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me._Cmd1_16.Image = CType(resources.GetObject("_Cmd1_16.Image"), System.Drawing.Image)
        Me._Cmd1_16.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_16.Location = New System.Drawing.Point(757, 372)
        Me._Cmd1_16.Name = "_Cmd1_16"
        Me._Cmd1_16.Size = New System.Drawing.Size(81, 68)
        Me._Cmd1_16.TabIndex = 17
        Me._Cmd1_16.Tag = "Return"
        Me._Cmd1_16.Text = "Trở &về"
        Me._Cmd1_16.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_16.UseVisualStyleBackColor = False
        '
        '_Cmd1_22
        '
        Me._Cmd1_22.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_22.Cursor = System.Windows.Forms.Cursors.Hand
        Me._Cmd1_22.FlatAppearance.BorderSize = 0
        Me._Cmd1_22.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_22.Image = CType(resources.GetObject("_Cmd1_22.Image"), System.Drawing.Image)
        Me._Cmd1_22.Location = New System.Drawing.Point(708, 263)
        Me._Cmd1_22.Name = "_Cmd1_22"
        Me._Cmd1_22.Size = New System.Drawing.Size(127, 38)
        Me._Cmd1_22.TabIndex = 20
        Me._Cmd1_22.TabStop = False
        Me._Cmd1_22.Tag = "Import contracts"
        Me._Cmd1_22.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_22.UseVisualStyleBackColor = False
        '
        '_Cmd1_20
        '
        Me._Cmd1_20.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_20.Cursor = System.Windows.Forms.Cursors.Hand
        Me._Cmd1_20.FlatAppearance.BorderSize = 0
        Me._Cmd1_20.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_20.Image = CType(resources.GetObject("_Cmd1_20.Image"), System.Drawing.Image)
        Me._Cmd1_20.Location = New System.Drawing.Point(708, 65)
        Me._Cmd1_20.Name = "_Cmd1_20"
        Me._Cmd1_20.Size = New System.Drawing.Size(127, 35)
        Me._Cmd1_20.TabIndex = 21
        Me._Cmd1_20.TabStop = False
        Me._Cmd1_20.Tag = "Purchase"
        Me._Cmd1_20.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_20.UseVisualStyleBackColor = False
        '
        '_Cmd1_21
        '
        Me._Cmd1_21.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_21.Cursor = System.Windows.Forms.Cursors.Hand
        Me._Cmd1_21.FlatAppearance.BorderSize = 0
        Me._Cmd1_21.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_21.Image = CType(resources.GetObject("_Cmd1_21.Image"), System.Drawing.Image)
        Me._Cmd1_21.Location = New System.Drawing.Point(30, 167)
        Me._Cmd1_21.Name = "_Cmd1_21"
        Me._Cmd1_21.Size = New System.Drawing.Size(131, 34)
        Me._Cmd1_21.TabIndex = 22
        Me._Cmd1_21.TabStop = False
        Me._Cmd1_21.Tag = "Bill"
        Me._Cmd1_21.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_21.UseVisualStyleBackColor = False
        '
        'LabelControl7
        '
        Me.LabelControl7.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelControl7.Location = New System.Drawing.Point(465, 308)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(129, 13)
        Me.LabelControl7.TabIndex = 90
        Me.LabelControl7.Tag = "Contracts - Orders"
        Me.LabelControl7.Text = "Hợp đồng - Đơn hàng"
        Me.LabelControl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl1
        '
        Me.LabelControl1.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelControl1.Location = New System.Drawing.Point(715, 308)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(120, 13)
        Me.LabelControl1.TabIndex = 91
        Me.LabelControl1.Tag = "Expenses - Services"
        Me.LabelControl1.Text = "Chi phí - Dịch vụ"
        Me.LabelControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl2
        '
        Me.LabelControl2.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelControl2.Location = New System.Drawing.Point(33, 310)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(128, 13)
        Me.LabelControl2.TabIndex = 92
        Me.LabelControl2.Tag = "Opening balance"
        Me.LabelControl2.Text = "Vật tư đầu kỳ"
        Me.LabelControl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl3
        '
        Me.LabelControl3.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelControl3.Location = New System.Drawing.Point(253, 312)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(119, 13)
        Me.LabelControl3.TabIndex = 93
        Me.LabelControl3.Tag = "Internally circulated"
        Me.LabelControl3.Text = "Lưu chuyển nội bộ"
        Me.LabelControl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl4
        '
        Me.LabelControl4.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelControl4.Location = New System.Drawing.Point(705, 108)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(130, 13)
        Me.LabelControl4.TabIndex = 94
        Me.LabelControl4.Tag = "Delivery Note"
        Me.LabelControl4.Text = "Hàng nhập trả lại"
        Me.LabelControl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl5
        '
        Me.LabelControl5.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelControl5.Location = New System.Drawing.Point(30, 105)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(131, 18)
        Me.LabelControl5.TabIndex = 95
        Me.LabelControl5.Tag = "Purchase"
        Me.LabelControl5.Text = "Mua hàng"
        Me.LabelControl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl6
        '
        Me.LabelControl6.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelControl6.Location = New System.Drawing.Point(458, 110)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(138, 13)
        Me.LabelControl6.TabIndex = 96
        Me.LabelControl6.Tag = "Import"
        Me.LabelControl6.Text = "Nhập khẩu"
        Me.LabelControl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl8
        '
        Me.LabelControl8.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelControl8.Location = New System.Drawing.Point(247, 107)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(131, 13)
        Me.LabelControl8.TabIndex = 97
        Me.LabelControl8.Tag = "Sales / Contracts"
        Me.LabelControl8.Text = "Bán hàng"
        Me.LabelControl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl9
        '
        Me.LabelControl9.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelControl9.Location = New System.Drawing.Point(705, 203)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(130, 17)
        Me.LabelControl9.TabIndex = 98
        Me.LabelControl9.Tag = "Bill"
        Me.LabelControl9.Text = "Xuất kho"
        Me.LabelControl9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl10
        '
        Me.LabelControl10.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelControl10.Location = New System.Drawing.Point(28, 207)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(133, 13)
        Me.LabelControl10.TabIndex = 99
        Me.LabelControl10.Tag = "Receiable Note"
        Me.LabelControl10.Text = "Hàng bán trả lại"
        Me.LabelControl10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl11
        '
        Me.LabelControl11.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelControl11.Location = New System.Drawing.Point(465, 205)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(129, 13)
        Me.LabelControl11.TabIndex = 100
        Me.LabelControl11.Tag = "Reports"
        Me.LabelControl11.Text = "Sổ sách báo cáo"
        Me.LabelControl11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl12
        '
        Me.LabelControl12.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl12.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelControl12.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelControl12.Location = New System.Drawing.Point(288, 9)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(320, 28)
        Me.LabelControl12.TabIndex = 120
        Me.LabelControl12.Tag = "GOODS"
        Me.LabelControl12.Text = "VẬT TƯ - HÀNG HÓA"
        Me.LabelControl12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmMNVatTu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(869, 461)
        Me.Controls.Add(Me._Cmd1_8)
        Me.Controls.Add(Me._Cmd1_11)
        Me.Controls.Add(Me._Cmd1_9)
        Me.Controls.Add(Me._Cmd1_13)
        Me.Controls.Add(Me._Cmd1_14)
        Me.Controls.Add(Me._Cmd1_12)
        Me.Controls.Add(Me._Cmd1_7)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me._Cmd1_21)
        Me.Controls.Add(Me._Cmd1_4)
        Me.Controls.Add(Me._Cmd1_3)
        Me.Controls.Add(Me._Cmd1_2)
        Me.Controls.Add(Me._Cmd1_20)
        Me.Controls.Add(Me._Cmd1_0)
        Me.Controls.Add(Me._Cmd1_22)
        Me.Controls.Add(Me._Frame1_0)
        Me.Controls.Add(Me._Cmd1_1)
        Me.Controls.Add(Me._Frame1_1)
        Me.Controls.Add(Me._Cmd1_16)
        Me.Controls.Add(Me._Cmd1_15)
        Me.Controls.Add(Me._Cmd1_5)
        Me.Controls.Add(Me._Cmd1_10)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMNVatTu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Goods"
        Me.Text = "Vật tư hàng hóa"
        Me._Frame1_0.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Sub InitializeLine3()
        Me.Line3(1) = _Line3_1
        Me.Line3(0) = _Line3_0
    End Sub
    Sub InitializeLine22()
        Me.Line22(2) = _Line22_2
        Me.Line22(1) = _Line22_1
        Me.Line22(0) = _Line22_0
    End Sub
    Sub InitializeFrame1()
        Me.Frame1(1) = _Frame1_1
        Me.Frame1(0) = _Frame1_0
    End Sub
    Sub InitializeCmd1()
        Me.Cmd1(7) = _Cmd1_7
        Me.Cmd1(8) = _Cmd1_8
        Me.Cmd1(9) = _Cmd1_9
        Me.Cmd1(11) = _Cmd1_11
        Me.Cmd1(12) = _Cmd1_12
        Me.Cmd1(13) = _Cmd1_13
        Me.Cmd1(14) = _Cmd1_14
        Me.Cmd1(15) = _Cmd1_15
        Me.Cmd1(19) = _Cmd1_19
        Me.Cmd1(20) = _Cmd1_20
        Me.Cmd1(21) = _Cmd1_21
        Me.Cmd1(22) = _Cmd1_22
        Me.Cmd1(0) = _Cmd1_0
        Me.Cmd1(1) = _Cmd1_1
        Me.Cmd1(2) = _Cmd1_2
        Me.Cmd1(3) = _Cmd1_3
        Me.Cmd1(4) = _Cmd1_4
        Me.Cmd1(5) = _Cmd1_5
        Me.Cmd1(6) = _Cmd1_6
        Me.Cmd1(10) = _Cmd1_10
        Me.Cmd1(17) = _Cmd1_17
        Me.Cmd1(18) = _Cmd1_18
        Me.Cmd1(16) = _Cmd1_16
    End Sub
    Private WithEvents _Cmd1_22 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_20 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_21 As System.Windows.Forms.Button
    Friend WithEvents LabelControl7 As System.Windows.Forms.Label
    Friend WithEvents LabelControl1 As System.Windows.Forms.Label
    Friend WithEvents LabelControl2 As System.Windows.Forms.Label
    Friend WithEvents LabelControl3 As System.Windows.Forms.Label
    Friend WithEvents LabelControl4 As System.Windows.Forms.Label
    Friend WithEvents LabelControl5 As System.Windows.Forms.Label
    Friend WithEvents LabelControl6 As System.Windows.Forms.Label
    Friend WithEvents LabelControl8 As System.Windows.Forms.Label
    Friend WithEvents LabelControl9 As System.Windows.Forms.Label
    Friend WithEvents LabelControl10 As System.Windows.Forms.Label
    Friend WithEvents LabelControl11 As System.Windows.Forms.Label
    Friend WithEvents LabelControl12 As System.Windows.Forms.Label
#End Region
End Class
