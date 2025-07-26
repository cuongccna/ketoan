<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSotaisan
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
        isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		InitializeOptBC()
		InitializeOpt()
		InitializeLabel()
		InitializeFrame()
		InitializeCommand()
		InitializeCboThang()
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
	Private WithEvents _OptBC_0 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_18 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_19 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_20 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_21 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_22 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_23 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_24 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_25 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_26 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_27 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_28 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_29 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_30 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_31 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_45 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_61 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_68 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_71 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_79 As System.Windows.Forms.RadioButton
	Public WithEvents Cbo As ComboBoxEx.ComboBoxExt
	Public WithEvents txtShTS As System.Windows.Forms.TextBox
	Private WithEvents _Opt_1 As System.Windows.Forms.RadioButton
	Private WithEvents _Opt_0 As System.Windows.Forms.RadioButton
	Private WithEvents _Frame_2 As System.Windows.Forms.GroupBox
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Private WithEvents _CboThang_1 As ComboBoxEx.ComboBoxExt
	Private WithEvents _CboThang_0 As ComboBoxEx.ComboBoxExt
	Private WithEvents _Label_1 As System.Windows.Forms.Label
	Private WithEvents _Label_0 As System.Windows.Forms.Label
	Private WithEvents _Frame_0 As System.Windows.Forms.GroupBox
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Public WithEvents GauGe As System.Windows.Forms.ProgressBar
    Public CboThang(1) As ComboBoxEx.ComboBoxExt
    Public Command(2) As System.Windows.Forms.Button
    Public Frame(2) As System.Windows.Forms.GroupBox
    Public Label(1) As System.Windows.Forms.Label
    Public Opt(1) As System.Windows.Forms.RadioButton
    Public OptBC(79) As System.Windows.Forms.RadioButton
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me._OptBC_0 = New System.Windows.Forms.RadioButton
        Me._OptBC_18 = New System.Windows.Forms.RadioButton
        Me._OptBC_19 = New System.Windows.Forms.RadioButton
        Me._OptBC_20 = New System.Windows.Forms.RadioButton
        Me._OptBC_21 = New System.Windows.Forms.RadioButton
        Me._OptBC_22 = New System.Windows.Forms.RadioButton
        Me._OptBC_23 = New System.Windows.Forms.RadioButton
        Me._OptBC_24 = New System.Windows.Forms.RadioButton
        Me._OptBC_25 = New System.Windows.Forms.RadioButton
        Me._OptBC_26 = New System.Windows.Forms.RadioButton
        Me._OptBC_27 = New System.Windows.Forms.RadioButton
        Me._OptBC_28 = New System.Windows.Forms.RadioButton
        Me._OptBC_29 = New System.Windows.Forms.RadioButton
        Me._OptBC_30 = New System.Windows.Forms.RadioButton
        Me._OptBC_31 = New System.Windows.Forms.RadioButton
        Me._OptBC_45 = New System.Windows.Forms.RadioButton
        Me._OptBC_61 = New System.Windows.Forms.RadioButton
        Me._OptBC_68 = New System.Windows.Forms.RadioButton
        Me._OptBC_71 = New System.Windows.Forms.RadioButton
        Me._OptBC_79 = New System.Windows.Forms.RadioButton
        Me._Frame_2 = New System.Windows.Forms.GroupBox
        Me.Cbo = New ComboBoxEx.ComboBoxExt
        Me.txtShTS = New System.Windows.Forms.TextBox
        Me._Opt_1 = New System.Windows.Forms.RadioButton
        Me._Opt_0 = New System.Windows.Forms.RadioButton
        Me._Frame_0 = New System.Windows.Forms.GroupBox
        Me._CboThang_1 = New ComboBoxEx.ComboBoxExt
        Me._CboThang_0 = New ComboBoxEx.ComboBoxExt
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me.GauGe = New System.Windows.Forms.ProgressBar
        Me.Frame1.SuspendLayout()
        Me._Frame_2.SuspendLayout()
        Me._Frame_0.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.Transparent
        Me.Frame1.Controls.Add(Me._OptBC_0)
        Me.Frame1.Controls.Add(Me._OptBC_18)
        Me.Frame1.Controls.Add(Me._OptBC_19)
        Me.Frame1.Controls.Add(Me._OptBC_20)
        Me.Frame1.Controls.Add(Me._OptBC_21)
        Me.Frame1.Controls.Add(Me._OptBC_22)
        Me.Frame1.Controls.Add(Me._OptBC_23)
        Me.Frame1.Controls.Add(Me._OptBC_24)
        Me.Frame1.Controls.Add(Me._OptBC_25)
        Me.Frame1.Controls.Add(Me._OptBC_26)
        Me.Frame1.Controls.Add(Me._OptBC_27)
        Me.Frame1.Controls.Add(Me._OptBC_28)
        Me.Frame1.Controls.Add(Me._OptBC_29)
        Me.Frame1.Controls.Add(Me._OptBC_30)
        Me.Frame1.Controls.Add(Me._OptBC_31)
        Me.Frame1.Controls.Add(Me._OptBC_45)
        Me.Frame1.Controls.Add(Me._OptBC_61)
        Me.Frame1.Controls.Add(Me._OptBC_68)
        Me.Frame1.Controls.Add(Me._OptBC_71)
        Me.Frame1.Controls.Add(Me._OptBC_79)
        Me.Frame1.Controls.Add(Me._Frame_2)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(489, 353)
        Me.Frame1.TabIndex = 33
        Me.Frame1.TabStop = False
        '
        '_OptBC_0
        '
        Me._OptBC_0.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_0.Location = New System.Drawing.Point(208, 64)
        Me._OptBC_0.Name = "_OptBC_0"
        Me._OptBC_0.Size = New System.Drawing.Size(257, 17)
        Me._OptBC_0.TabIndex = 14
        Me._OptBC_0.TabStop = True
        Me._OptBC_0.Tag = "Detail Apportion of Depreciation"
        Me._OptBC_0.Text = "Thẻ tài sản"
        Me._OptBC_0.UseVisualStyleBackColor = False
        '
        '_OptBC_18
        '
        Me._OptBC_18.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_18.Checked = True
        Me._OptBC_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_18.Location = New System.Drawing.Point(16, 64)
        Me._OptBC_18.Name = "_OptBC_18"
        Me._OptBC_18.Size = New System.Drawing.Size(193, 17)
        Me._OptBC_18.TabIndex = 4
        Me._OptBC_18.TabStop = True
        Me._OptBC_18.Tag = "Depriciation Detail"
        Me._OptBC_18.Text = "Sổ khấu hao chi tiết"
        Me._OptBC_18.UseVisualStyleBackColor = False
        '
        '_OptBC_19
        '
        Me._OptBC_19.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_19.Location = New System.Drawing.Point(16, 112)
        Me._OptBC_19.Name = "_OptBC_19"
        Me._OptBC_19.Size = New System.Drawing.Size(189, 17)
        Me._OptBC_19.TabIndex = 6
        Me._OptBC_19.TabStop = True
        Me._OptBC_19.Tag = "Opening Balance "
        Me._OptBC_19.Text = "Số dư đầu kỳ"
        Me._OptBC_19.UseVisualStyleBackColor = False
        '
        '_OptBC_20
        '
        Me._OptBC_20.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_20.Location = New System.Drawing.Point(16, 136)
        Me._OptBC_20.Name = "_OptBC_20"
        Me._OptBC_20.Size = New System.Drawing.Size(189, 17)
        Me._OptBC_20.TabIndex = 7
        Me._OptBC_20.TabStop = True
        Me._OptBC_20.Tag = "Closing Balance"
        Me._OptBC_20.Text = "Số dư cuối kỳ"
        Me._OptBC_20.UseVisualStyleBackColor = False
        '
        '_OptBC_21
        '
        Me._OptBC_21.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_21.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_21.Location = New System.Drawing.Point(16, 176)
        Me._OptBC_21.Name = "_OptBC_21"
        Me._OptBC_21.Size = New System.Drawing.Size(190, 17)
        Me._OptBC_21.TabIndex = 8
        Me._OptBC_21.TabStop = True
        Me._OptBC_21.Tag = "Increasing Fixed Asset Report"
        Me._OptBC_21.Text = "Tăng tài sản"
        Me._OptBC_21.UseVisualStyleBackColor = False
        '
        '_OptBC_22
        '
        Me._OptBC_22.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_22.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_22.Location = New System.Drawing.Point(16, 200)
        Me._OptBC_22.Name = "_OptBC_22"
        Me._OptBC_22.Size = New System.Drawing.Size(190, 17)
        Me._OptBC_22.TabIndex = 9
        Me._OptBC_22.TabStop = True
        Me._OptBC_22.Tag = "Increased by Revaluation "
        Me._OptBC_22.Text = "Đánh giá lại tăng"
        Me._OptBC_22.UseVisualStyleBackColor = False
        '
        '_OptBC_23
        '
        Me._OptBC_23.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_23.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_23.Location = New System.Drawing.Point(16, 240)
        Me._OptBC_23.Name = "_OptBC_23"
        Me._OptBC_23.Size = New System.Drawing.Size(190, 17)
        Me._OptBC_23.TabIndex = 10
        Me._OptBC_23.TabStop = True
        Me._OptBC_23.Tag = "Decrease Fixed Asset Report"
        Me._OptBC_23.Text = "Giảm tài sản"
        Me._OptBC_23.UseVisualStyleBackColor = False
        '
        '_OptBC_24
        '
        Me._OptBC_24.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_24.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_24.Location = New System.Drawing.Point(16, 264)
        Me._OptBC_24.Name = "_OptBC_24"
        Me._OptBC_24.Size = New System.Drawing.Size(190, 17)
        Me._OptBC_24.TabIndex = 11
        Me._OptBC_24.TabStop = True
        Me._OptBC_24.Tag = "Decreased by Revaluation"
        Me._OptBC_24.Text = "Đánh giá lại giảm"
        Me._OptBC_24.UseVisualStyleBackColor = False
        '
        '_OptBC_25
        '
        Me._OptBC_25.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_25.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_25.Location = New System.Drawing.Point(208, 88)
        Me._OptBC_25.Name = "_OptBC_25"
        Me._OptBC_25.Size = New System.Drawing.Size(257, 17)
        Me._OptBC_25.TabIndex = 15
        Me._OptBC_25.TabStop = True
        Me._OptBC_25.Tag = "Detail Apportion of Depreciation"
        Me._OptBC_25.Text = "Chi tiết phân bổ khấu hao"
        Me._OptBC_25.UseVisualStyleBackColor = False
        '
        '_OptBC_26
        '
        Me._OptBC_26.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_26.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_26.Location = New System.Drawing.Point(208, 112)
        Me._OptBC_26.Name = "_OptBC_26"
        Me._OptBC_26.Size = New System.Drawing.Size(257, 17)
        Me._OptBC_26.TabIndex = 16
        Me._OptBC_26.TabStop = True
        Me._OptBC_26.Tag = "Summary Apportion of Depreciation"
        Me._OptBC_26.Text = "Tổng hợp phân bổ khấu hao"
        Me._OptBC_26.UseVisualStyleBackColor = False
        '
        '_OptBC_27
        '
        Me._OptBC_27.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_27.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_27.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_27.Location = New System.Drawing.Point(208, 136)
        Me._OptBC_27.Name = "_OptBC_27"
        Me._OptBC_27.Size = New System.Drawing.Size(257, 17)
        Me._OptBC_27.TabIndex = 17
        Me._OptBC_27.TabStop = True
        Me._OptBC_27.Tag = "Liability of fixed asset"
        Me._OptBC_27.Text = "Năng lực tài sản"
        Me._OptBC_27.UseVisualStyleBackColor = False
        '
        '_OptBC_28
        '
        Me._OptBC_28.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_28.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_28.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_28.Location = New System.Drawing.Point(208, 176)
        Me._OptBC_28.Name = "_OptBC_28"
        Me._OptBC_28.Size = New System.Drawing.Size(257, 17)
        Me._OptBC_28.TabIndex = 18
        Me._OptBC_28.TabStop = True
        Me._OptBC_28.Tag = "Fluctuation of Fixed Asset "
        Me._OptBC_28.Text = "Tổng hợp biến động trong kỳ"
        Me._OptBC_28.UseVisualStyleBackColor = False
        '
        '_OptBC_29
        '
        Me._OptBC_29.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_29.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_29.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_29.Location = New System.Drawing.Point(208, 200)
        Me._OptBC_29.Name = "_OptBC_29"
        Me._OptBC_29.Size = New System.Drawing.Size(257, 17)
        Me._OptBC_29.TabIndex = 19
        Me._OptBC_29.TabStop = True
        Me._OptBC_29.Tag = "Accured Fluctuation of Fixed Assets"
        Me._OptBC_29.Text = "Tổng hợp biến động luỹ kế"
        Me._OptBC_29.UseVisualStyleBackColor = False
        '
        '_OptBC_30
        '
        Me._OptBC_30.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_30.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_30.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_30.Location = New System.Drawing.Point(208, 240)
        Me._OptBC_30.Name = "_OptBC_30"
        Me._OptBC_30.Size = New System.Drawing.Size(257, 17)
        Me._OptBC_30.TabIndex = 20
        Me._OptBC_30.TabStop = True
        Me._OptBC_30.Tag = "Detail of Asset not Depriciation "
        Me._OptBC_30.Text = "Chi tiết tài sản không phải tính khấu hao"
        Me._OptBC_30.UseVisualStyleBackColor = False
        '
        '_OptBC_31
        '
        Me._OptBC_31.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_31.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_31.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_31.Location = New System.Drawing.Point(208, 264)
        Me._OptBC_31.Name = "_OptBC_31"
        Me._OptBC_31.Size = New System.Drawing.Size(257, 17)
        Me._OptBC_31.TabIndex = 21
        Me._OptBC_31.TabStop = True
        Me._OptBC_31.Tag = "Avarage of Depriciated Asset"
        Me._OptBC_31.Text = "Bình quân tài sản cần tính khấu hao"
        Me._OptBC_31.UseVisualStyleBackColor = False
        '
        '_OptBC_45
        '
        Me._OptBC_45.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_45.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_45.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_45.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_45.Location = New System.Drawing.Point(16, 304)
        Me._OptBC_45.Name = "_OptBC_45"
        Me._OptBC_45.Size = New System.Drawing.Size(190, 17)
        Me._OptBC_45.TabIndex = 12
        Me._OptBC_45.TabStop = True
        Me._OptBC_45.Tag = "Fixed Asset Table 1"
        Me._OptBC_45.Text = "Sổ tài sản cố định 1"
        Me._OptBC_45.UseVisualStyleBackColor = False
        '
        '_OptBC_61
        '
        Me._OptBC_61.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_61.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_61.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_61.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_61.Location = New System.Drawing.Point(16, 88)
        Me._OptBC_61.Name = "_OptBC_61"
        Me._OptBC_61.Size = New System.Drawing.Size(189, 17)
        Me._OptBC_61.TabIndex = 5
        Me._OptBC_61.TabStop = True
        Me._OptBC_61.Tag = "Depreciation Summary"
        Me._OptBC_61.Text = "Sổ khấu hao tổng hợp"
        Me._OptBC_61.UseVisualStyleBackColor = False
        '
        '_OptBC_68
        '
        Me._OptBC_68.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_68.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_68.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_68.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_68.Location = New System.Drawing.Point(16, 328)
        Me._OptBC_68.Name = "_OptBC_68"
        Me._OptBC_68.Size = New System.Drawing.Size(190, 17)
        Me._OptBC_68.TabIndex = 13
        Me._OptBC_68.TabStop = True
        Me._OptBC_68.Tag = "Fixed Asset Table 2"
        Me._OptBC_68.Text = "Sổ tài sản cố định 2"
        Me._OptBC_68.UseVisualStyleBackColor = False
        '
        '_OptBC_71
        '
        Me._OptBC_71.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_71.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_71.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_71.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_71.Location = New System.Drawing.Point(208, 304)
        Me._OptBC_71.Name = "_OptBC_71"
        Me._OptBC_71.Size = New System.Drawing.Size(257, 17)
        Me._OptBC_71.TabIndex = 22
        Me._OptBC_71.TabStop = True
        Me._OptBC_71.Text = "Kiểm kê tài sản cố định"
        Me._OptBC_71.UseVisualStyleBackColor = False
        '
        '_OptBC_79
        '
        Me._OptBC_79.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_79.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_79.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_79.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_79.Location = New System.Drawing.Point(208, 328)
        Me._OptBC_79.Name = "_OptBC_79"
        Me._OptBC_79.Size = New System.Drawing.Size(257, 17)
        Me._OptBC_79.TabIndex = 23
        Me._OptBC_79.TabStop = True
        Me._OptBC_79.Text = "Bảng phân bổ khấu hao"
        Me._OptBC_79.UseVisualStyleBackColor = False
        '
        '_Frame_2
        '
        Me._Frame_2.BackColor = System.Drawing.Color.Transparent
        Me._Frame_2.Controls.Add(Me.Cbo)
        Me._Frame_2.Controls.Add(Me.txtShTS)
        Me._Frame_2.Controls.Add(Me._Opt_1)
        Me._Frame_2.Controls.Add(Me._Opt_0)
        Me._Frame_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_2.ForeColor = System.Drawing.Color.Blue
        Me._Frame_2.Location = New System.Drawing.Point(8, 8)
        Me._Frame_2.Name = "_Frame_2"
        Me._Frame_2.Size = New System.Drawing.Size(473, 41)
        Me._Frame_2.TabIndex = 34
        Me._Frame_2.TabStop = False
        '
        'Cbo
        '
        Me.Cbo.BackColor = System.Drawing.SystemColors.Window
        Me.Cbo.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cbo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.Cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo.Location = New System.Drawing.Point(296, 13)
        Me.Cbo.Name = "Cbo"
        Me.Cbo.Size = New System.Drawing.Size(169, 21)
        Me.Cbo.TabIndex = 3
        '
        'txtShTS
        '
        Me.txtShTS.AcceptsReturn = True
        Me.txtShTS.BackColor = System.Drawing.SystemColors.Window
        Me.txtShTS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShTS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShTS.Location = New System.Drawing.Point(88, 13)
        Me.txtShTS.MaxLength = 12
        Me.txtShTS.Name = "txtShTS"
        Me.txtShTS.Size = New System.Drawing.Size(89, 20)
        Me.txtShTS.TabIndex = 1
        Me.txtShTS.Tag = "0"
        '
        '_Opt_1
        '
        Me._Opt_1.BackColor = System.Drawing.Color.Transparent
        Me._Opt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_1.Location = New System.Drawing.Point(200, 16)
        Me._Opt_1.Name = "_Opt_1"
        Me._Opt_1.Size = New System.Drawing.Size(97, 17)
        Me._Opt_1.TabIndex = 2
        Me._Opt_1.TabStop = True
        Me._Opt_1.Tag = "Managed by"
        Me._Opt_1.Text = "Đơn vị quản lý"
        Me._Opt_1.UseVisualStyleBackColor = False
        '
        '_Opt_0
        '
        Me._Opt_0.BackColor = System.Drawing.Color.Transparent
        Me._Opt_0.Checked = True
        Me._Opt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_0.Location = New System.Drawing.Point(8, 16)
        Me._Opt_0.Name = "_Opt_0"
        Me._Opt_0.Size = New System.Drawing.Size(81, 17)
        Me._Opt_0.TabIndex = 0
        Me._Opt_0.TabStop = True
        Me._Opt_0.Tag = "Sort by Code"
        Me._Opt_0.Text = "Tài sản"
        Me._Opt_0.UseVisualStyleBackColor = False
        '
        '_Frame_0
        '
        Me._Frame_0.BackColor = System.Drawing.Color.Transparent
        Me._Frame_0.Controls.Add(Me._CboThang_1)
        Me._Frame_0.Controls.Add(Me._CboThang_0)
        Me._Frame_0.Controls.Add(Me._Label_1)
        Me._Frame_0.Controls.Add(Me._Label_0)
        Me._Frame_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_0.Location = New System.Drawing.Point(8, 351)
        Me._Frame_0.Name = "_Frame_0"
        Me._Frame_0.Size = New System.Drawing.Size(266, 43)
        Me._Frame_0.TabIndex = 30
        Me._Frame_0.TabStop = False
        '
        '_CboThang_1
        '
        Me._CboThang_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_1.Location = New System.Drawing.Point(194, 14)
        Me._CboThang_1.Name = "_CboThang_1"
        Me._CboThang_1.Size = New System.Drawing.Size(61, 21)
        Me._CboThang_1.TabIndex = 25
        '
        '_CboThang_0
        '
        Me._CboThang_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_0.Location = New System.Drawing.Point(63, 14)
        Me._CboThang_0.Name = "_CboThang_0"
        Me._CboThang_0.Size = New System.Drawing.Size(61, 21)
        Me._CboThang_0.TabIndex = 24
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(130, 16)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(58, 17)
        Me._Label_1.TabIndex = 32
        Me._Label_1.Tag = "to"
        Me._Label_1.Text = "Đến tháng"
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(4, 16)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(53, 17)
        Me._Label_0.TabIndex = 31
        Me._Label_0.Tag = "From"
        Me._Label_0.Text = "Từ tháng"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(424, 393)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 29
        Me._Command_2.Text = "Trở &về"
        Me._Command_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.print16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(345, 393)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 28
        Me._Command_1.Text = "&In"
        Me._Command_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.report16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(266, 393)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 27
        Me._Command_0.Text = "&Xem"
        Me._Command_0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GauGe
        '
        Me.GauGe.Location = New System.Drawing.Point(280, 365)
        Me.GauGe.Name = "GauGe"
        Me.GauGe.Size = New System.Drawing.Size(217, 17)
        Me.GauGe.TabIndex = 26
        '
        'FrmSotaisan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(503, 423)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me._Frame_0)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me.GauGe)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSotaisan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sổ tài sản cố định"
        Me.Frame1.ResumeLayout(False)
        Me._Frame_2.ResumeLayout(False)
        Me._Frame_2.PerformLayout()
        Me._Frame_0.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
	Sub InitializeOptBC()
		Me.OptBC(0) = _OptBC_0
		Me.OptBC(18) = _OptBC_18
		Me.OptBC(19) = _OptBC_19
		Me.OptBC(20) = _OptBC_20
		Me.OptBC(21) = _OptBC_21
		Me.OptBC(22) = _OptBC_22
		Me.OptBC(23) = _OptBC_23
		Me.OptBC(24) = _OptBC_24
		Me.OptBC(25) = _OptBC_25
		Me.OptBC(26) = _OptBC_26
		Me.OptBC(27) = _OptBC_27
		Me.OptBC(28) = _OptBC_28
		Me.OptBC(29) = _OptBC_29
		Me.OptBC(30) = _OptBC_30
		Me.OptBC(31) = _OptBC_31
		Me.OptBC(45) = _OptBC_45
		Me.OptBC(61) = _OptBC_61
		Me.OptBC(68) = _OptBC_68
		Me.OptBC(71) = _OptBC_71
		Me.OptBC(79) = _OptBC_79
	End Sub
	Sub InitializeOpt()
		Me.Opt(1) = _Opt_1
		Me.Opt(0) = _Opt_0
	End Sub
	Sub InitializeLabel()
		Me.Label(1) = _Label_1
		Me.Label(0) = _Label_0
	End Sub
	Sub InitializeFrame()
		Me.Frame(2) = _Frame_2
		Me.Frame(0) = _Frame_0
	End Sub
	Sub InitializeCommand()
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
	Sub InitializeCboThang()
		Me.CboThang(1) = _CboThang_1
		Me.CboThang(0) = _CboThang_0
	End Sub
#End Region 
End Class
