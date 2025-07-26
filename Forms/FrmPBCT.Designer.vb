<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPBCT
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializetxtTon()
		InitializeLbTien()
		InitializeLabel()
		InitializeCommand1()
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
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _txtTon_10 As System.Windows.Forms.TextBox
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Private WithEvents _txtTon_9 As System.Windows.Forms.TextBox
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _txtTon_8 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_7 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_6 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_5 As System.Windows.Forms.TextBox
    Public WithEvents GrdVT As ListviewEx.ListviewExt
    Private WithEvents _txtTon_4 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_3 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_0 As System.Windows.Forms.TextBox
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _LbTien_13 As System.Windows.Forms.Label
    Private WithEvents _LbTien_6 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _LbTien_12 As System.Windows.Forms.Label
    Private WithEvents _LbTien_11 As System.Windows.Forms.Label
    Private WithEvents _LbTien_5 As System.Windows.Forms.Label
    Private WithEvents _LbTien_4 As System.Windows.Forms.Label
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _LbTien_10 As System.Windows.Forms.Label
    Private WithEvents _LbTien_9 As System.Windows.Forms.Label
    Private WithEvents _LbTien_8 As System.Windows.Forms.Label
    Private WithEvents _LbTien_7 As System.Windows.Forms.Label
    Private WithEvents _Label_9 As System.Windows.Forms.Label
    Private WithEvents _LbTien_3 As System.Windows.Forms.Label
    Private WithEvents _LbTien_2 As System.Windows.Forms.Label
    Private WithEvents _LbTien_1 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _LbTien_0 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Public Command(1) As System.Windows.Forms.Button
    Public Command1(1) As System.Windows.Forms.Button
    Public Label(13) As System.Windows.Forms.Label
    Public LbTien(13) As System.Windows.Forms.Label
    Public txtTon(10) As System.Windows.Forms.TextBox
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPBCT))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdct = New System.Windows.Forms.Button()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._txtTon_10 = New System.Windows.Forms.TextBox()
        Me._Command1_0 = New System.Windows.Forms.Button()
        Me._txtTon_9 = New System.Windows.Forms.TextBox()
        Me._Command1_1 = New System.Windows.Forms.Button()
        Me._txtTon_8 = New System.Windows.Forms.TextBox()
        Me._txtTon_7 = New System.Windows.Forms.TextBox()
        Me._txtTon_6 = New System.Windows.Forms.TextBox()
        Me._txtTon_5 = New System.Windows.Forms.TextBox()
        Me._txtTon_4 = New System.Windows.Forms.TextBox()
        Me._txtTon_3 = New System.Windows.Forms.TextBox()
        Me._txtTon_2 = New System.Windows.Forms.TextBox()
        Me._txtTon_1 = New System.Windows.Forms.TextBox()
        Me._txtTon_0 = New System.Windows.Forms.TextBox()
        Me._Label_13 = New System.Windows.Forms.Label()
        Me._LbTien_13 = New System.Windows.Forms.Label()
        Me._LbTien_6 = New System.Windows.Forms.Label()
        Me._Label_12 = New System.Windows.Forms.Label()
        Me._LbTien_12 = New System.Windows.Forms.Label()
        Me._LbTien_11 = New System.Windows.Forms.Label()
        Me._LbTien_5 = New System.Windows.Forms.Label()
        Me._LbTien_4 = New System.Windows.Forms.Label()
        Me._Label_11 = New System.Windows.Forms.Label()
        Me._Label_10 = New System.Windows.Forms.Label()
        Me._LbTien_10 = New System.Windows.Forms.Label()
        Me._LbTien_9 = New System.Windows.Forms.Label()
        Me._LbTien_8 = New System.Windows.Forms.Label()
        Me._LbTien_7 = New System.Windows.Forms.Label()
        Me._Label_9 = New System.Windows.Forms.Label()
        Me._LbTien_3 = New System.Windows.Forms.Label()
        Me._LbTien_2 = New System.Windows.Forms.Label()
        Me._LbTien_1 = New System.Windows.Forms.Label()
        Me._Label_8 = New System.Windows.Forms.Label()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me._Label_7 = New System.Windows.Forms.Label()
        Me._Label_6 = New System.Windows.Forms.Label()
        Me._LbTien_0 = New System.Windows.Forms.Label()
        Me._Label_5 = New System.Windows.Forms.Label()
        Me._Label_4 = New System.Windows.Forms.Label()
        Me._Label_3 = New System.Windows.Forms.Label()
        Me._Label_2 = New System.Windows.Forms.Label()
        Me._Label_1 = New System.Windows.Forms.Label()
        Me.GrdVT = New ListViewEx.ListviewExt()
        Me.SuspendLayout()
        '
        'cmdct
        '
        Me.cmdct.BackColor = System.Drawing.SystemColors.Control
        Me.cmdct.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdct.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdct.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_addtogrid
        Me.cmdct.Location = New System.Drawing.Point(742, 422)
        Me.cmdct.Name = "cmdct"
        Me.cmdct.Size = New System.Drawing.Size(19, 23)
        Me.cmdct.TabIndex = 11
        Me.cmdct.Tag = "-1"
        Me.cmdct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdct.UseVisualStyleBackColor = False
        '
        '_Command_0
        '
        Me._Command_0.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Preview
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(575, 472)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 44
        Me._Command_0.Tag = "Preview"
        Me._Command_0.Text = "&Xem"
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(655, 472)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 43
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        '
        '_txtTon_10
        '
        Me._txtTon_10.AcceptsReturn = True
        Me._txtTon_10.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_10.Location = New System.Drawing.Point(727, 424)
        Me._txtTon_10.MaxLength = 20
        Me._txtTon_10.Name = "_txtTon_10"
        Me._txtTon_10.ReadOnly = True
        Me._txtTon_10.Size = New System.Drawing.Size(17, 20)
        Me._txtTon_10.TabIndex = 10
        Me._txtTon_10.TabStop = False
        Me._txtTon_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_Command1_0
        '
        Me._Command1_0.BackColor = System.Drawing.Color.Silver
        Me._Command1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_0.Image = CType(resources.GetObject("_Command1_0.Image"), System.Drawing.Image)
        Me._Command1_0.Location = New System.Drawing.Point(575, 472)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(73, 25)
        Me._Command1_0.TabIndex = 41
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&View"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        '_txtTon_9
        '
        Me._txtTon_9.AcceptsReturn = True
        Me._txtTon_9.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_9.Location = New System.Drawing.Point(655, 424)
        Me._txtTon_9.MaxLength = 20
        Me._txtTon_9.Name = "_txtTon_9"
        Me._txtTon_9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._txtTon_9.Size = New System.Drawing.Size(73, 20)
        Me._txtTon_9.TabIndex = 9
        Me._txtTon_9.Text = "0"
        '
        '_Command1_1
        '
        Me._Command1_1.BackColor = System.Drawing.Color.Silver
        Me._Command1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_1.Image = CType(resources.GetObject("_Command1_1.Image"), System.Drawing.Image)
        Me._Command1_1.Location = New System.Drawing.Point(655, 472)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(73, 25)
        Me._Command1_1.TabIndex = 37
        Me._Command1_1.TabStop = False
        Me._Command1_1.Tag = "Return"
        Me._Command1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_1.UseVisualStyleBackColor = False
        Me._Command1_1.Visible = False
        '
        '_txtTon_8
        '
        Me._txtTon_8.AcceptsReturn = True
        Me._txtTon_8.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_8.Location = New System.Drawing.Point(583, 424)
        Me._txtTon_8.MaxLength = 20
        Me._txtTon_8.Name = "_txtTon_8"
        Me._txtTon_8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._txtTon_8.Size = New System.Drawing.Size(73, 20)
        Me._txtTon_8.TabIndex = 8
        Me._txtTon_8.Text = "0"
        '
        '_txtTon_7
        '
        Me._txtTon_7.AcceptsReturn = True
        Me._txtTon_7.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_7.Location = New System.Drawing.Point(511, 424)
        Me._txtTon_7.MaxLength = 20
        Me._txtTon_7.Name = "_txtTon_7"
        Me._txtTon_7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._txtTon_7.Size = New System.Drawing.Size(73, 20)
        Me._txtTon_7.TabIndex = 7
        Me._txtTon_7.Text = "0"
        '
        '_txtTon_6
        '
        Me._txtTon_6.AcceptsReturn = True
        Me._txtTon_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_6.Location = New System.Drawing.Point(439, 424)
        Me._txtTon_6.MaxLength = 20
        Me._txtTon_6.Name = "_txtTon_6"
        Me._txtTon_6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._txtTon_6.Size = New System.Drawing.Size(73, 20)
        Me._txtTon_6.TabIndex = 6
        Me._txtTon_6.Text = "0"
        '
        '_txtTon_5
        '
        Me._txtTon_5.AcceptsReturn = True
        Me._txtTon_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_5.Location = New System.Drawing.Point(383, 424)
        Me._txtTon_5.MaxLength = 20
        Me._txtTon_5.Name = "_txtTon_5"
        Me._txtTon_5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._txtTon_5.Size = New System.Drawing.Size(57, 20)
        Me._txtTon_5.TabIndex = 5
        Me._txtTon_5.Text = "0"
        '
        '_txtTon_4
        '
        Me._txtTon_4.AcceptsReturn = True
        Me._txtTon_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_4.Location = New System.Drawing.Point(311, 424)
        Me._txtTon_4.MaxLength = 20
        Me._txtTon_4.Name = "_txtTon_4"
        Me._txtTon_4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._txtTon_4.Size = New System.Drawing.Size(73, 20)
        Me._txtTon_4.TabIndex = 4
        Me._txtTon_4.Text = "0"
        '
        '_txtTon_3
        '
        Me._txtTon_3.AcceptsReturn = True
        Me._txtTon_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_3.Location = New System.Drawing.Point(239, 424)
        Me._txtTon_3.MaxLength = 20
        Me._txtTon_3.Name = "_txtTon_3"
        Me._txtTon_3.ReadOnly = True
        Me._txtTon_3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._txtTon_3.Size = New System.Drawing.Size(73, 20)
        Me._txtTon_3.TabIndex = 3
        Me._txtTon_3.TabStop = False
        Me._txtTon_3.Text = "0"
        '
        '_txtTon_2
        '
        Me._txtTon_2.AcceptsReturn = True
        Me._txtTon_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_2.Location = New System.Drawing.Point(191, 424)
        Me._txtTon_2.MaxLength = 20
        Me._txtTon_2.Name = "_txtTon_2"
        Me._txtTon_2.ReadOnly = True
        Me._txtTon_2.Size = New System.Drawing.Size(49, 20)
        Me._txtTon_2.TabIndex = 2
        Me._txtTon_2.TabStop = False
        '
        '_txtTon_1
        '
        Me._txtTon_1.AcceptsReturn = True
        Me._txtTon_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_1.Location = New System.Drawing.Point(63, 424)
        Me._txtTon_1.MaxLength = 50
        Me._txtTon_1.Name = "_txtTon_1"
        Me._txtTon_1.ReadOnly = True
        Me._txtTon_1.Size = New System.Drawing.Size(129, 20)
        Me._txtTon_1.TabIndex = 1
        Me._txtTon_1.TabStop = False
        '
        '_txtTon_0
        '
        Me._txtTon_0.AcceptsReturn = True
        Me._txtTon_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_0.Location = New System.Drawing.Point(7, 424)
        Me._txtTon_0.MaxLength = 20
        Me._txtTon_0.Name = "_txtTon_0"
        Me._txtTon_0.ReadOnly = True
        Me._txtTon_0.Size = New System.Drawing.Size(57, 20)
        Me._txtTon_0.TabIndex = 0
        Me._txtTon_0.TabStop = False
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.Color.Black
        Me._Label_13.Location = New System.Drawing.Point(727, 32)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(34, 17)
        Me._Label_13.TabIndex = 42
        Me._Label_13.Tag = "Unit"
        Me._Label_13.Text = "PB"
        Me._Label_13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_LbTien_13
        '
        Me._LbTien_13.BackColor = System.Drawing.Color.Transparent
        Me._LbTien_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTien_13.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTien_13.ForeColor = System.Drawing.Color.Blue
        Me._LbTien_13.Location = New System.Drawing.Point(663, 456)
        Me._LbTien_13.Name = "_LbTien_13"
        Me._LbTien_13.Size = New System.Drawing.Size(65, 17)
        Me._LbTien_13.TabIndex = 40
        Me._LbTien_13.Text = "0"
        Me._LbTien_13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbTien_6
        '
        Me._LbTien_6.BackColor = System.Drawing.Color.Transparent
        Me._LbTien_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTien_6.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTien_6.ForeColor = System.Drawing.Color.Blue
        Me._LbTien_6.Location = New System.Drawing.Point(660, 8)
        Me._LbTien_6.Name = "_LbTien_6"
        Me._LbTien_6.Size = New System.Drawing.Size(65, 17)
        Me._LbTien_6.TabIndex = 39
        Me._LbTien_6.Text = "0"
        Me._LbTien_6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_12
        '
        Me._Label_12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.Color.Black
        Me._Label_12.Location = New System.Drawing.Point(655, 32)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.Size = New System.Drawing.Size(73, 17)
        Me._Label_12.TabIndex = 38
        Me._Label_12.Tag = "Administration"
        Me._Label_12.Text = "CPTC"
        Me._Label_12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_LbTien_12
        '
        Me._LbTien_12.BackColor = System.Drawing.Color.Transparent
        Me._LbTien_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTien_12.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTien_12.ForeColor = System.Drawing.Color.Blue
        Me._LbTien_12.Location = New System.Drawing.Point(591, 456)
        Me._LbTien_12.Name = "_LbTien_12"
        Me._LbTien_12.Size = New System.Drawing.Size(65, 17)
        Me._LbTien_12.TabIndex = 36
        Me._LbTien_12.Text = "0"
        Me._LbTien_12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbTien_11
        '
        Me._LbTien_11.BackColor = System.Drawing.Color.Transparent
        Me._LbTien_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTien_11.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTien_11.ForeColor = System.Drawing.Color.Blue
        Me._LbTien_11.Location = New System.Drawing.Point(519, 456)
        Me._LbTien_11.Name = "_LbTien_11"
        Me._LbTien_11.Size = New System.Drawing.Size(65, 17)
        Me._LbTien_11.TabIndex = 35
        Me._LbTien_11.Text = "0"
        Me._LbTien_11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbTien_5
        '
        Me._LbTien_5.BackColor = System.Drawing.Color.Transparent
        Me._LbTien_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTien_5.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTien_5.ForeColor = System.Drawing.Color.Blue
        Me._LbTien_5.Location = New System.Drawing.Point(588, 8)
        Me._LbTien_5.Name = "_LbTien_5"
        Me._LbTien_5.Size = New System.Drawing.Size(65, 17)
        Me._LbTien_5.TabIndex = 34
        Me._LbTien_5.Text = "0"
        Me._LbTien_5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbTien_4
        '
        Me._LbTien_4.BackColor = System.Drawing.Color.Transparent
        Me._LbTien_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTien_4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTien_4.ForeColor = System.Drawing.Color.Blue
        Me._LbTien_4.Location = New System.Drawing.Point(516, 8)
        Me._LbTien_4.Name = "_LbTien_4"
        Me._LbTien_4.Size = New System.Drawing.Size(65, 17)
        Me._LbTien_4.TabIndex = 33
        Me._LbTien_4.Text = "0"
        Me._LbTien_4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.Color.Black
        Me._Label_11.Location = New System.Drawing.Point(583, 32)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(73, 17)
        Me._Label_11.TabIndex = 32
        Me._Label_11.Tag = "Administration"
        Me._Label_11.Text = "CPQL"
        Me._Label_11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.Color.Black
        Me._Label_10.Location = New System.Drawing.Point(511, 32)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(73, 17)
        Me._Label_10.TabIndex = 31
        Me._Label_10.Tag = "Sale Exp."
        Me._Label_10.Text = "CPBH"
        Me._Label_10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_LbTien_10
        '
        Me._LbTien_10.BackColor = System.Drawing.Color.Transparent
        Me._LbTien_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTien_10.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTien_10.ForeColor = System.Drawing.Color.Blue
        Me._LbTien_10.Location = New System.Drawing.Point(444, 456)
        Me._LbTien_10.Name = "_LbTien_10"
        Me._LbTien_10.Size = New System.Drawing.Size(65, 17)
        Me._LbTien_10.TabIndex = 30
        Me._LbTien_10.Text = "0"
        Me._LbTien_10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbTien_9
        '
        Me._LbTien_9.BackColor = System.Drawing.Color.Transparent
        Me._LbTien_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTien_9.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTien_9.ForeColor = System.Drawing.Color.Blue
        Me._LbTien_9.Location = New System.Drawing.Point(380, 456)
        Me._LbTien_9.Name = "_LbTien_9"
        Me._LbTien_9.Size = New System.Drawing.Size(57, 17)
        Me._LbTien_9.TabIndex = 29
        Me._LbTien_9.Text = "0"
        Me._LbTien_9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbTien_8
        '
        Me._LbTien_8.BackColor = System.Drawing.Color.Transparent
        Me._LbTien_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTien_8.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTien_8.ForeColor = System.Drawing.Color.Blue
        Me._LbTien_8.Location = New System.Drawing.Point(316, 456)
        Me._LbTien_8.Name = "_LbTien_8"
        Me._LbTien_8.Size = New System.Drawing.Size(65, 17)
        Me._LbTien_8.TabIndex = 28
        Me._LbTien_8.Text = "0"
        Me._LbTien_8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbTien_7
        '
        Me._LbTien_7.BackColor = System.Drawing.Color.Transparent
        Me._LbTien_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTien_7.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTien_7.ForeColor = System.Drawing.Color.Blue
        Me._LbTien_7.Location = New System.Drawing.Point(244, 456)
        Me._LbTien_7.Name = "_LbTien_7"
        Me._LbTien_7.Size = New System.Drawing.Size(65, 17)
        Me._LbTien_7.TabIndex = 27
        Me._LbTien_7.Text = "0"
        Me._LbTien_7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_9
        '
        Me._Label_9.BackColor = System.Drawing.Color.Transparent
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_9.Location = New System.Drawing.Point(135, 456)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.Size = New System.Drawing.Size(97, 17)
        Me._Label_9.TabIndex = 26
        Me._Label_9.Tag = "Allocated"
        Me._Label_9.Text = "Đã phân bổ"
        Me._Label_9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbTien_3
        '
        Me._LbTien_3.BackColor = System.Drawing.Color.Transparent
        Me._LbTien_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTien_3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTien_3.ForeColor = System.Drawing.Color.Blue
        Me._LbTien_3.Location = New System.Drawing.Point(444, 8)
        Me._LbTien_3.Name = "_LbTien_3"
        Me._LbTien_3.Size = New System.Drawing.Size(65, 17)
        Me._LbTien_3.TabIndex = 25
        Me._LbTien_3.Text = "0"
        Me._LbTien_3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbTien_2
        '
        Me._LbTien_2.BackColor = System.Drawing.Color.Transparent
        Me._LbTien_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTien_2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTien_2.ForeColor = System.Drawing.Color.Blue
        Me._LbTien_2.Location = New System.Drawing.Point(388, 8)
        Me._LbTien_2.Name = "_LbTien_2"
        Me._LbTien_2.Size = New System.Drawing.Size(52, 17)
        Me._LbTien_2.TabIndex = 24
        Me._LbTien_2.Text = "0"
        Me._LbTien_2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbTien_1
        '
        Me._LbTien_1.BackColor = System.Drawing.Color.Transparent
        Me._LbTien_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTien_1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTien_1.ForeColor = System.Drawing.Color.Blue
        Me._LbTien_1.Location = New System.Drawing.Point(316, 8)
        Me._LbTien_1.Name = "_LbTien_1"
        Me._LbTien_1.Size = New System.Drawing.Size(65, 17)
        Me._LbTien_1.TabIndex = 23
        Me._LbTien_1.Text = "0"
        Me._LbTien_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.Color.Black
        Me._Label_8.Location = New System.Drawing.Point(439, 32)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(73, 17)
        Me._Label_8.TabIndex = 22
        Me._Label_8.Tag = "Other Exp."
        Me._Label_8.Text = "CP SXC"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Teal
        Me._Label_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.Color.White
        Me._Label_0.Location = New System.Drawing.Point(439, 32)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(57, 17)
        Me._Label_0.TabIndex = 21
        Me._Label_0.Tag = "Depreciation"
        Me._Label_0.Text = "KH TSCĐ"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_0.Visible = False
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(239, 32)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(73, 17)
        Me._Label_7.TabIndex = 20
        Me._Label_7.Tag = "Material"
        Me._Label_7.Text = "CP NVL"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.Transparent
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_6.Location = New System.Drawing.Point(119, 8)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(113, 17)
        Me._Label_6.TabIndex = 19
        Me._Label_6.Tag = "Total Expenses"
        Me._Label_6.Text = "Tổng chi phí"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbTien_0
        '
        Me._LbTien_0.BackColor = System.Drawing.Color.Transparent
        Me._LbTien_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTien_0.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTien_0.ForeColor = System.Drawing.Color.Blue
        Me._LbTien_0.Location = New System.Drawing.Point(244, 8)
        Me._LbTien_0.Name = "_LbTien_0"
        Me._LbTien_0.Size = New System.Drawing.Size(65, 17)
        Me._LbTien_0.TabIndex = 18
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
        Me._Label_5.Location = New System.Drawing.Point(383, 32)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(57, 17)
        Me._Label_5.TabIndex = 17
        Me._Label_5.Tag = "Machine"
        Me._Label_5.Text = "CP Máy"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(311, 32)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(73, 17)
        Me._Label_4.TabIndex = 16
        Me._Label_4.Tag = "Labour"
        Me._Label_4.Text = "CP Nhân công"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.Black
        Me._Label_3.Location = New System.Drawing.Point(191, 32)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(49, 17)
        Me._Label_3.TabIndex = 15
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
        Me._Label_2.Location = New System.Drawing.Point(63, 32)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(129, 17)
        Me._Label_2.TabIndex = 14
        Me._Label_2.Tag = "Description"
        Me._Label_2.Text = "Tên Thành phẩm"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(7, 32)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(57, 17)
        Me._Label_1.TabIndex = 13
        Me._Label_1.Tag = "Code"
        Me._Label_1.Text = "Số hiệu TP"
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
        Me.GrdVT.Location = New System.Drawing.Point(7, 49)
        Me.GrdVT.Name = "GrdVT"
        Me.GrdVT.Row = 0
        Me.GrdVT.Rows = 0
        Me.GrdVT.Selectable = True
        Me.GrdVT.SelectedTextColor = System.Drawing.Color.White
        Me.GrdVT.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.GrdVT.ShowBorder = True
        Me.GrdVT.ShowFocusRect = False
        Me.GrdVT.Size = New System.Drawing.Size(754, 376)
        Me.GrdVT.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdVT.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdVT.TabIndex = 10
        Me.GrdVT.Tag = "0"
        '
        'FrmPBCT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(768, 505)
        Me.Controls.Add(Me.GrdVT)
        Me.Controls.Add(Me.cmdct)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._txtTon_10)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me._txtTon_9)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._txtTon_8)
        Me.Controls.Add(Me._txtTon_7)
        Me.Controls.Add(Me._txtTon_6)
        Me.Controls.Add(Me._txtTon_5)
        Me.Controls.Add(Me._txtTon_4)
        Me.Controls.Add(Me._txtTon_3)
        Me.Controls.Add(Me._txtTon_2)
        Me.Controls.Add(Me._txtTon_1)
        Me.Controls.Add(Me._txtTon_0)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me._LbTien_13)
        Me.Controls.Add(Me._LbTien_6)
        Me.Controls.Add(Me._Label_12)
        Me.Controls.Add(Me._LbTien_12)
        Me.Controls.Add(Me._LbTien_11)
        Me.Controls.Add(Me._LbTien_5)
        Me.Controls.Add(Me._LbTien_4)
        Me.Controls.Add(Me._Label_11)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._LbTien_10)
        Me.Controls.Add(Me._LbTien_9)
        Me.Controls.Add(Me._LbTien_8)
        Me.Controls.Add(Me._LbTien_7)
        Me.Controls.Add(Me._Label_9)
        Me.Controls.Add(Me._LbTien_3)
        Me.Controls.Add(Me._LbTien_2)
        Me.Controls.Add(Me._LbTien_1)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_0)
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
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(17, 46)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPBCT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Chi tiết phân bổ chi phí"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializetxtTon()
		Me.txtTon(10) = _txtTon_10
		Me.txtTon(9) = _txtTon_9
		Me.txtTon(8) = _txtTon_8
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
		Me.LbTien(13) = _LbTien_13
		Me.LbTien(6) = _LbTien_6
		Me.LbTien(12) = _LbTien_12
		Me.LbTien(11) = _LbTien_11
		Me.LbTien(5) = _LbTien_5
		Me.LbTien(4) = _LbTien_4
		Me.LbTien(10) = _LbTien_10
		Me.LbTien(9) = _LbTien_9
		Me.LbTien(8) = _LbTien_8
		Me.LbTien(7) = _LbTien_7
		Me.LbTien(3) = _LbTien_3
		Me.LbTien(2) = _LbTien_2
		Me.LbTien(1) = _LbTien_1
		Me.LbTien(0) = _LbTien_0
	End Sub
	Sub InitializeLabel()
		Me.Label(13) = _Label_13
		Me.Label(12) = _Label_12
		Me.Label(11) = _Label_11
		Me.Label(10) = _Label_10
		Me.Label(9) = _Label_9
		Me.Label(8) = _Label_8
		Me.Label(0) = _Label_0
		Me.Label(7) = _Label_7
		Me.Label(6) = _Label_6
		Me.Label(5) = _Label_5
		Me.Label(4) = _Label_4
		Me.Label(3) = _Label_3
		Me.Label(2) = _Label_2
		Me.Label(1) = _Label_1
	End Sub
	Sub InitializeCommand1()
		Me.Command1(0) = _Command1_0
		Me.Command1(1) = _Command1_1
	End Sub
	Sub InitializeCommand()
		Me.Command(0) = _Command_0
		Me.Command(1) = _Command_1
	End Sub
#End Region 
End Class
