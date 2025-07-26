<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTNCN
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeLbTxt()
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
	Public WithEvents cmdct As System.Windows.Forms.Button
	Public WithEvents GrdVT  As ListviewEx.ListviewExt 
	Public WithEvents CboThang As ComboBoxEx.ComboBoxExt
	Public WithEvents txt As System.Windows.Forms.TextBox
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _LbTxt_8 As System.Windows.Forms.Label
    Private WithEvents _LbTxt_7 As System.Windows.Forms.Label
    Private WithEvents _LbTxt_6 As System.Windows.Forms.Label
    Private WithEvents _LbTxt_5 As System.Windows.Forms.Label
    Private WithEvents _LbTxt_4 As System.Windows.Forms.Label
    Private WithEvents _LbTxt_3 As System.Windows.Forms.Label
    Private WithEvents _LbTxt_2 As System.Windows.Forms.Label
    Private WithEvents _LbTxt_1 As System.Windows.Forms.Label
    Private WithEvents _LbTxt_0 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_9 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Private WithEvents _Label_15 As System.Windows.Forms.Label
    Public Command(2) As System.Windows.Forms.Button
    Public Label(15) As System.Windows.Forms.Label
    Public LbTxt(8) As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTNCN))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdct = New System.Windows.Forms.Button()
        Me.CboThang = New ComboBoxEx.ComboBoxExt()
        Me.txt = New System.Windows.Forms.TextBox()
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._LbTxt_8 = New System.Windows.Forms.Label()
        Me._LbTxt_7 = New System.Windows.Forms.Label()
        Me._LbTxt_6 = New System.Windows.Forms.Label()
        Me._LbTxt_5 = New System.Windows.Forms.Label()
        Me._LbTxt_4 = New System.Windows.Forms.Label()
        Me._LbTxt_3 = New System.Windows.Forms.Label()
        Me._LbTxt_2 = New System.Windows.Forms.Label()
        Me._LbTxt_1 = New System.Windows.Forms.Label()
        Me._LbTxt_0 = New System.Windows.Forms.Label()
        Me._Label_12 = New System.Windows.Forms.Label()
        Me._Label_11 = New System.Windows.Forms.Label()
        Me._Label_10 = New System.Windows.Forms.Label()
        Me._Label_6 = New System.Windows.Forms.Label()
        Me._Label_5 = New System.Windows.Forms.Label()
        Me._Label_4 = New System.Windows.Forms.Label()
        Me._Label_1 = New System.Windows.Forms.Label()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me._Label_9 = New System.Windows.Forms.Label()
        Me._Label_8 = New System.Windows.Forms.Label()
        Me._Label_2 = New System.Windows.Forms.Label()
        Me._Label_3 = New System.Windows.Forms.Label()
        Me._Label_7 = New System.Windows.Forms.Label()
        Me._Label_13 = New System.Windows.Forms.Label()
        Me._Label_14 = New System.Windows.Forms.Label()
        Me._Label_15 = New System.Windows.Forms.Label()
        Me._Command_2 = New System.Windows.Forms.Button()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me.GrdVT = New ListViewEx.ListviewExt()
        Me.SuspendLayout()
        '
        'cmdct
        '
        Me.cmdct.BackColor = System.Drawing.SystemColors.Control
        Me.cmdct.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdct.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdct.Image = CType(resources.GetObject("cmdct.Image"), System.Drawing.Image)
        Me.cmdct.Location = New System.Drawing.Point(993, 296)
        Me.cmdct.Name = "cmdct"
        Me.cmdct.Size = New System.Drawing.Size(17, 21)
        Me.cmdct.TabIndex = 0
        Me.cmdct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdct.UseVisualStyleBackColor = False
        Me.cmdct.Visible = False
        '
        'CboThang
        '
        Me.CboThang.BackColor = System.Drawing.SystemColors.Window
        Me.CboThang.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboThang.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboThang.Location = New System.Drawing.Point(472, 32)
        Me.CboThang.Name = "CboThang"
        Me.CboThang.Size = New System.Drawing.Size(73, 21)
        Me.CboThang.TabIndex = 15
        '
        'txt
        '
        Me.txt.AcceptsReturn = True
        Me.txt.BackColor = System.Drawing.SystemColors.Window
        Me.txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.ForeColor = System.Drawing.Color.Blue
        Me.txt.Location = New System.Drawing.Point(800, 297)
        Me.txt.MaxLength = 100
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(105, 20)
        Me.txt.TabIndex = 14
        Me.txt.Text = "0"
        Me.txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt.Visible = False
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Trich_thue
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(827, 325)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(102, 25)
        Me._Command_1.TabIndex = 28
        Me._Command_1.Tag = "Update book"
        Me._Command_1.Text = "Trích th&uế"
        '
        '_LbTxt_8
        '
        Me._LbTxt_8.BackColor = System.Drawing.SystemColors.Window
        Me._LbTxt_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbTxt_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTxt_8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTxt_8.Location = New System.Drawing.Point(904, 296)
        Me._LbTxt_8.Name = "_LbTxt_8"
        Me._LbTxt_8.Size = New System.Drawing.Size(89, 21)
        Me._LbTxt_8.TabIndex = 26
        Me._LbTxt_8.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me._LbTxt_8.Visible = False
        '
        '_LbTxt_7
        '
        Me._LbTxt_7.BackColor = System.Drawing.SystemColors.Window
        Me._LbTxt_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbTxt_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTxt_7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTxt_7.Location = New System.Drawing.Point(712, 296)
        Me._LbTxt_7.Name = "_LbTxt_7"
        Me._LbTxt_7.Size = New System.Drawing.Size(89, 21)
        Me._LbTxt_7.TabIndex = 25
        Me._LbTxt_7.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me._LbTxt_7.Visible = False
        '
        '_LbTxt_6
        '
        Me._LbTxt_6.BackColor = System.Drawing.SystemColors.Window
        Me._LbTxt_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbTxt_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTxt_6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTxt_6.Location = New System.Drawing.Point(624, 296)
        Me._LbTxt_6.Name = "_LbTxt_6"
        Me._LbTxt_6.Size = New System.Drawing.Size(89, 21)
        Me._LbTxt_6.TabIndex = 24
        Me._LbTxt_6.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me._LbTxt_6.Visible = False
        '
        '_LbTxt_5
        '
        Me._LbTxt_5.BackColor = System.Drawing.SystemColors.Window
        Me._LbTxt_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbTxt_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTxt_5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTxt_5.Location = New System.Drawing.Point(536, 296)
        Me._LbTxt_5.Name = "_LbTxt_5"
        Me._LbTxt_5.Size = New System.Drawing.Size(89, 21)
        Me._LbTxt_5.TabIndex = 23
        Me._LbTxt_5.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me._LbTxt_5.Visible = False
        '
        '_LbTxt_4
        '
        Me._LbTxt_4.BackColor = System.Drawing.SystemColors.Window
        Me._LbTxt_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbTxt_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTxt_4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTxt_4.Location = New System.Drawing.Point(448, 296)
        Me._LbTxt_4.Name = "_LbTxt_4"
        Me._LbTxt_4.Size = New System.Drawing.Size(89, 21)
        Me._LbTxt_4.TabIndex = 22
        Me._LbTxt_4.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me._LbTxt_4.Visible = False
        '
        '_LbTxt_3
        '
        Me._LbTxt_3.BackColor = System.Drawing.SystemColors.Window
        Me._LbTxt_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbTxt_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTxt_3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTxt_3.Location = New System.Drawing.Point(368, 296)
        Me._LbTxt_3.Name = "_LbTxt_3"
        Me._LbTxt_3.Size = New System.Drawing.Size(81, 21)
        Me._LbTxt_3.TabIndex = 21
        Me._LbTxt_3.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me._LbTxt_3.Visible = False
        '
        '_LbTxt_2
        '
        Me._LbTxt_2.BackColor = System.Drawing.SystemColors.Window
        Me._LbTxt_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbTxt_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTxt_2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTxt_2.Location = New System.Drawing.Point(256, 296)
        Me._LbTxt_2.Name = "_LbTxt_2"
        Me._LbTxt_2.Size = New System.Drawing.Size(113, 21)
        Me._LbTxt_2.TabIndex = 20
        Me._LbTxt_2.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me._LbTxt_2.Visible = False
        '
        '_LbTxt_1
        '
        Me._LbTxt_1.BackColor = System.Drawing.SystemColors.Window
        Me._LbTxt_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbTxt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTxt_1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTxt_1.Location = New System.Drawing.Point(160, 296)
        Me._LbTxt_1.Name = "_LbTxt_1"
        Me._LbTxt_1.Size = New System.Drawing.Size(97, 21)
        Me._LbTxt_1.TabIndex = 19
        Me._LbTxt_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me._LbTxt_1.Visible = False
        '
        '_LbTxt_0
        '
        Me._LbTxt_0.BackColor = System.Drawing.SystemColors.Window
        Me._LbTxt_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbTxt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTxt_0.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTxt_0.Location = New System.Drawing.Point(8, 296)
        Me._LbTxt_0.Name = "_LbTxt_0"
        Me._LbTxt_0.Size = New System.Drawing.Size(153, 21)
        Me._LbTxt_0.TabIndex = 18
        Me._LbTxt_0.Visible = False
        '
        '_Label_12
        '
        Me._Label_12.BackColor = System.Drawing.Color.Transparent
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_12.Location = New System.Drawing.Point(425, 35)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.Size = New System.Drawing.Size(41, 13)
        Me._Label_12.TabIndex = 16
        Me._Label_12.Tag = "Month"
        Me._Label_12.Text = "Tháng"
        Me._Label_12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.Teal
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.Color.White
        Me._Label_11.Location = New System.Drawing.Point(312, 8)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(353, 20)
        Me._Label_11.TabIndex = 13
        Me._Label_11.Tag = "Personal income tax table"
        Me._Label_11.Text = "Bảng kê thuế thu nhập cá nhân"
        Me._Label_11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.Teal
        Me._Label_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.Color.White
        Me._Label_10.Location = New System.Drawing.Point(160, 64)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(97, 33)
        Me._Label_10.TabIndex = 12
        Me._Label_10.Tag = "Tax code"
        Me._Label_10.Text = "Mã số thuế"
        Me._Label_10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.Teal
        Me._Label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.Color.White
        Me._Label_6.Location = New System.Drawing.Point(256, 64)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(113, 33)
        Me._Label_6.TabIndex = 11
        Me._Label_6.Tag = "ID card / Passport"
        Me._Label_6.Text = "         Số CMND/        hộ chiếu"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.Teal
        Me._Label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.Color.White
        Me._Label_5.Location = New System.Drawing.Point(624, 80)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(89, 17)
        Me._Label_5.TabIndex = 10
        Me._Label_5.Tag = "Charity"
        Me._Label_5.Text = "Từ thiện"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.Teal
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.White
        Me._Label_4.Location = New System.Drawing.Point(536, 80)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(89, 17)
        Me._Label_4.TabIndex = 9
        Me._Label_4.Tag = "Dependents"
        Me._Label_4.Text = "Người phụ thuộc"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Teal
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.White
        Me._Label_1.Location = New System.Drawing.Point(448, 80)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(89, 17)
        Me._Label_1.TabIndex = 8
        Me._Label_1.Tag = "Itself"
        Me._Label_1.Text = "Bản thân"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Teal
        Me._Label_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.Color.White
        Me._Label_0.Location = New System.Drawing.Point(448, 64)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(353, 17)
        Me._Label_0.TabIndex = 7
        Me._Label_0.Tag = "Deductions"
        Me._Label_0.Text = "Các khoản giảm trừ"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_9
        '
        Me._Label_9.BackColor = System.Drawing.Color.Teal
        Me._Label_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.Color.White
        Me._Label_9.Location = New System.Drawing.Point(904, 64)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.Size = New System.Drawing.Size(89, 33)
        Me._Label_9.TabIndex = 6
        Me._Label_9.Tag = "Personal income tax"
        Me._Label_9.Text = "Thuế TNCN"
        Me._Label_9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.Teal
        Me._Label_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.Color.White
        Me._Label_8.Location = New System.Drawing.Point(368, 64)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(81, 33)
        Me._Label_8.TabIndex = 5
        Me._Label_8.Tag = "Taxable income"
        Me._Label_8.Text = "Thu nhập chịu thuế"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.Teal
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.White
        Me._Label_2.Location = New System.Drawing.Point(712, 80)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(89, 17)
        Me._Label_2.TabIndex = 4
        Me._Label_2.Tag = "Insurance"
        Me._Label_2.Text = "Bảo hiểm"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.Teal
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.White
        Me._Label_3.Location = New System.Drawing.Point(800, 64)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(105, 33)
        Me._Label_3.TabIndex = 3
        Me._Label_3.Tag = "Personal income for calculation"
        Me._Label_3.Text = "TNCN làm căn cứ tính giảm"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.Teal
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.White
        Me._Label_7.Location = New System.Drawing.Point(8, 64)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(153, 33)
        Me._Label_7.TabIndex = 2
        Me._Label_7.Tag = "Full name"
        Me._Label_7.Text = "Họ và tên"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.Transparent
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.Color.Black
        Me._Label_13.Location = New System.Drawing.Point(712, 48)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(89, 17)
        Me._Label_13.TabIndex = 29
        Me._Label_13.Tag = "Total"
        Me._Label_13.Text = "Tổng giá trị"
        Me._Label_13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.Color.Transparent
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.Color.Black
        Me._Label_14.Location = New System.Drawing.Point(800, 48)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(105, 17)
        Me._Label_14.TabIndex = 30
        Me._Label_14.Tag = ""
        Me._Label_14.Text = "0"
        Me._Label_14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_15
        '
        Me._Label_15.BackColor = System.Drawing.Color.Transparent
        Me._Label_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_15.ForeColor = System.Drawing.Color.Black
        Me._Label_15.Location = New System.Drawing.Point(904, 48)
        Me._Label_15.Name = "_Label_15"
        Me._Label_15.Size = New System.Drawing.Size(89, 17)
        Me._Label_15.TabIndex = 31
        Me._Label_15.Tag = ""
        Me._Label_15.Text = "0"
        Me._Label_15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Command_2
        '
        Me._Command_2.Image = CType(resources.GetObject("_Command_2.Image"), System.Drawing.Image)
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(936, 325)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 17
        Me._Command_2.Tag = "Return"
        Me._Command_2.Text = "Trở &về"
        '
        '_Command_0
        '
        Me._Command_0.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Tinh_thue
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(717, 325)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(104, 25)
        Me._Command_0.TabIndex = 27
        Me._Command_0.Tag = "Tax calculation"
        Me._Command_0.Text = "&Tính thuế"
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
        Me.GrdVT.Location = New System.Drawing.Point(8, 97)
        Me.GrdVT.Name = "GrdVT"
        Me.GrdVT.Row = 0
        Me.GrdVT.Rows = 0
        Me.GrdVT.Selectable = True
        Me.GrdVT.SelectedTextColor = System.Drawing.Color.White
        Me.GrdVT.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.GrdVT.ShowBorder = True
        Me.GrdVT.ShowFocusRect = False
        Me.GrdVT.Size = New System.Drawing.Size(1002, 201)
        Me.GrdVT.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdVT.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdVT.TabIndex = 10
        '
        'FrmTNCN
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1018, 356)
        Me.Controls.Add(Me.GrdVT)
        Me.Controls.Add(Me.cmdct)
        Me.Controls.Add(Me.CboThang)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._LbTxt_8)
        Me.Controls.Add(Me._LbTxt_7)
        Me.Controls.Add(Me._LbTxt_6)
        Me.Controls.Add(Me._LbTxt_5)
        Me.Controls.Add(Me._LbTxt_4)
        Me.Controls.Add(Me._LbTxt_3)
        Me.Controls.Add(Me._LbTxt_2)
        Me.Controls.Add(Me._LbTxt_1)
        Me.Controls.Add(Me._LbTxt_0)
        Me.Controls.Add(Me._Label_12)
        Me.Controls.Add(Me._Label_11)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_5)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_9)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me._Label_14)
        Me.Controls.Add(Me._Label_15)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTNCN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Personal income tax table"
        Me.Text = "Bảng kê thuế thu nhập cá nhân"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializeLbTxt()
		Me.LbTxt(8) = _LbTxt_8
		Me.LbTxt(7) = _LbTxt_7
		Me.LbTxt(6) = _LbTxt_6
		Me.LbTxt(5) = _LbTxt_5
		Me.LbTxt(4) = _LbTxt_4
		Me.LbTxt(3) = _LbTxt_3
		Me.LbTxt(2) = _LbTxt_2
		Me.LbTxt(1) = _LbTxt_1
		Me.LbTxt(0) = _LbTxt_0
	End Sub
	Sub InitializeLabel()
		Me.Label(12) = _Label_12
		Me.Label(11) = _Label_11
		Me.Label(10) = _Label_10
		Me.Label(6) = _Label_6
		Me.Label(5) = _Label_5
		Me.Label(4) = _Label_4
		Me.Label(1) = _Label_1
		Me.Label(0) = _Label_0
		Me.Label(9) = _Label_9
		Me.Label(8) = _Label_8
		Me.Label(2) = _Label_2
		Me.Label(3) = _Label_3
		Me.Label(7) = _Label_7
		Me.Label(13) = _Label_13
		Me.Label(14) = _Label_14
		Me.Label(15) = _Label_15
	End Sub
	Sub InitializeCommand()
		Me.Command(2) = _Command_2
		Me.Command(0) = _Command_0
		Me.Command(1) = _Command_1
	End Sub
#End Region 
End Class
