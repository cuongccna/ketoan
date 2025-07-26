<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTangGiam
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeText_Renamed()
		InitializeLine1()
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
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Text_0 As System.Windows.Forms.TextBox
    Private WithEvents _Text_1 As System.Windows.Forms.TextBox
    Private WithEvents _Text_2 As System.Windows.Forms.TextBox
    Private WithEvents _Text_3 As System.Windows.Forms.TextBox
    Private WithEvents _Text_4 As System.Windows.Forms.TextBox
    Private WithEvents _Text_5 As System.Windows.Forms.TextBox
    Private WithEvents _Text_6 As System.Windows.Forms.TextBox
    Private WithEvents _Text_7 As System.Windows.Forms.TextBox
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Line1_3 As System.Windows.Forms.Label
    Private WithEvents _Line1_2 As System.Windows.Forms.Label
    Private WithEvents _Line1_1 As System.Windows.Forms.Label
    Private WithEvents _Line1_0 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_9 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Private WithEvents _Label_15 As System.Windows.Forms.Label
    Private WithEvents _Label_16 As System.Windows.Forms.Label
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Private WithEvents _Label_22 As System.Windows.Forms.Label
    Private WithEvents _Label_23 As System.Windows.Forms.Label
    Private WithEvents _Label_30 As System.Windows.Forms.Label
    Private WithEvents _Label_31 As System.Windows.Forms.Label
    Private WithEvents _Label_32 As System.Windows.Forms.Label
    Private WithEvents _Label_33 As System.Windows.Forms.Label
    Private WithEvents _Label_37 As System.Windows.Forms.Label
    Private WithEvents _Label_38 As System.Windows.Forms.Label
    Private WithEvents _Label_39 As System.Windows.Forms.Label
    Private WithEvents _Label_40 As System.Windows.Forms.Label
    Private WithEvents _Label_41 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_24 As System.Windows.Forms.Label
    Private WithEvents _Label_35 As System.Windows.Forms.Label
    Private WithEvents _Label_42 As System.Windows.Forms.Label
    Private WithEvents _Label_43 As System.Windows.Forms.Label
    Private WithEvents _Label_18 As System.Windows.Forms.Label
    Private WithEvents _Label_19 As System.Windows.Forms.Label
    Private WithEvents _Label_20 As System.Windows.Forms.Label
    Private WithEvents _Label_21 As System.Windows.Forms.Label
    Public Command(1) As System.Windows.Forms.Button
    Public Command1(1) As System.Windows.Forms.Button
    Public Label(43) As System.Windows.Forms.Label
    Public Line1(3) As System.Windows.Forms.Label
    Public Text_Renamed(7) As System.Windows.Forms.TextBox
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTangGiam))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me._Text_0 = New System.Windows.Forms.TextBox()
        Me._Text_1 = New System.Windows.Forms.TextBox()
        Me._Text_2 = New System.Windows.Forms.TextBox()
        Me._Text_3 = New System.Windows.Forms.TextBox()
        Me._Text_4 = New System.Windows.Forms.TextBox()
        Me._Text_5 = New System.Windows.Forms.TextBox()
        Me._Text_6 = New System.Windows.Forms.TextBox()
        Me._Text_7 = New System.Windows.Forms.TextBox()
        Me._Command1_0 = New System.Windows.Forms.Button()
        Me._Command1_1 = New System.Windows.Forms.Button()
        Me._Line1_3 = New System.Windows.Forms.Label()
        Me._Line1_2 = New System.Windows.Forms.Label()
        Me._Line1_1 = New System.Windows.Forms.Label()
        Me._Line1_0 = New System.Windows.Forms.Label()
        Me._Label_2 = New System.Windows.Forms.Label()
        Me._Label_3 = New System.Windows.Forms.Label()
        Me._Label_4 = New System.Windows.Forms.Label()
        Me._Label_5 = New System.Windows.Forms.Label()
        Me._Label_6 = New System.Windows.Forms.Label()
        Me._Label_7 = New System.Windows.Forms.Label()
        Me._Label_8 = New System.Windows.Forms.Label()
        Me._Label_9 = New System.Windows.Forms.Label()
        Me._Label_10 = New System.Windows.Forms.Label()
        Me._Label_11 = New System.Windows.Forms.Label()
        Me._Label_12 = New System.Windows.Forms.Label()
        Me._Label_13 = New System.Windows.Forms.Label()
        Me._Label_14 = New System.Windows.Forms.Label()
        Me._Label_15 = New System.Windows.Forms.Label()
        Me._Label_16 = New System.Windows.Forms.Label()
        Me._Label_17 = New System.Windows.Forms.Label()
        Me._Label_22 = New System.Windows.Forms.Label()
        Me._Label_23 = New System.Windows.Forms.Label()
        Me._Label_30 = New System.Windows.Forms.Label()
        Me._Label_31 = New System.Windows.Forms.Label()
        Me._Label_32 = New System.Windows.Forms.Label()
        Me._Label_33 = New System.Windows.Forms.Label()
        Me._Label_37 = New System.Windows.Forms.Label()
        Me._Label_38 = New System.Windows.Forms.Label()
        Me._Label_39 = New System.Windows.Forms.Label()
        Me._Label_40 = New System.Windows.Forms.Label()
        Me._Label_41 = New System.Windows.Forms.Label()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me._Label_1 = New System.Windows.Forms.Label()
        Me._Label_24 = New System.Windows.Forms.Label()
        Me._Label_35 = New System.Windows.Forms.Label()
        Me._Label_42 = New System.Windows.Forms.Label()
        Me._Label_43 = New System.Windows.Forms.Label()
        Me._Label_18 = New System.Windows.Forms.Label()
        Me._Label_19 = New System.Windows.Forms.Label()
        Me._Label_20 = New System.Windows.Forms.Label()
        Me._Label_21 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(328, 40)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(81, 25)
        Me._Command_1.TabIndex = 9
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        '
        '_Command_0
        '
        Me._Command_0.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Save
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(328, 8)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(81, 25)
        Me._Command_0.TabIndex = 8
        Me._Command_0.Tag = "Save"
        Me._Command_0.Text = "&Ghi"
        '
        '_Text_0
        '
        Me._Text_0.Location = New System.Drawing.Point(216, 40)
        Me._Text_0.MaxLength = 15
        Me._Text_0.Multiline = True
        Me._Text_0.Name = "_Text_0"
        Me._Text_0.Size = New System.Drawing.Size(89, 21)
        Me._Text_0.TabIndex = 0
        Me._Text_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Text_1
        '
        Me._Text_1.Location = New System.Drawing.Point(216, 64)
        Me._Text_1.MaxLength = 15
        Me._Text_1.Multiline = True
        Me._Text_1.Name = "_Text_1"
        Me._Text_1.Size = New System.Drawing.Size(89, 21)
        Me._Text_1.TabIndex = 1
        Me._Text_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Text_2
        '
        Me._Text_2.Location = New System.Drawing.Point(216, 88)
        Me._Text_2.MaxLength = 15
        Me._Text_2.Multiline = True
        Me._Text_2.Name = "_Text_2"
        Me._Text_2.Size = New System.Drawing.Size(89, 21)
        Me._Text_2.TabIndex = 2
        Me._Text_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Text_3
        '
        Me._Text_3.Location = New System.Drawing.Point(216, 112)
        Me._Text_3.MaxLength = 15
        Me._Text_3.Multiline = True
        Me._Text_3.Name = "_Text_3"
        Me._Text_3.Size = New System.Drawing.Size(89, 21)
        Me._Text_3.TabIndex = 3
        Me._Text_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Text_4
        '
        Me._Text_4.Location = New System.Drawing.Point(216, 168)
        Me._Text_4.MaxLength = 15
        Me._Text_4.Multiline = True
        Me._Text_4.Name = "_Text_4"
        Me._Text_4.Size = New System.Drawing.Size(89, 21)
        Me._Text_4.TabIndex = 4
        Me._Text_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Text_5
        '
        Me._Text_5.Location = New System.Drawing.Point(216, 192)
        Me._Text_5.MaxLength = 15
        Me._Text_5.Multiline = True
        Me._Text_5.Name = "_Text_5"
        Me._Text_5.Size = New System.Drawing.Size(89, 21)
        Me._Text_5.TabIndex = 5
        Me._Text_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Text_6
        '
        Me._Text_6.Location = New System.Drawing.Point(216, 216)
        Me._Text_6.MaxLength = 15
        Me._Text_6.Multiline = True
        Me._Text_6.Name = "_Text_6"
        Me._Text_6.Size = New System.Drawing.Size(89, 21)
        Me._Text_6.TabIndex = 6
        Me._Text_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Text_7
        '
        Me._Text_7.Location = New System.Drawing.Point(216, 240)
        Me._Text_7.MaxLength = 15
        Me._Text_7.Multiline = True
        Me._Text_7.Name = "_Text_7"
        Me._Text_7.Size = New System.Drawing.Size(89, 21)
        Me._Text_7.TabIndex = 7
        Me._Text_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Command1_0
        '
        Me._Command1_0.BackColor = System.Drawing.Color.Silver
        Me._Command1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_0.Image = CType(resources.GetObject("_Command1_0.Image"), System.Drawing.Image)
        Me._Command1_0.Location = New System.Drawing.Point(328, 8)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(81, 25)
        Me._Command1_0.TabIndex = 10
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&Save"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        '_Command1_1
        '
        Me._Command1_1.BackColor = System.Drawing.Color.Silver
        Me._Command1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_1.Image = CType(resources.GetObject("_Command1_1.Image"), System.Drawing.Image)
        Me._Command1_1.Location = New System.Drawing.Point(328, 40)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(81, 25)
        Me._Command1_1.TabIndex = 11
        Me._Command1_1.TabStop = False
        Me._Command1_1.Tag = "&Return"
        Me._Command1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_1.UseVisualStyleBackColor = False
        Me._Command1_1.Visible = False
        '
        '_Line1_3
        '
        Me._Line1_3.BackColor = System.Drawing.Color.White
        Me._Line1_3.Enabled = False
        Me._Line1_3.Location = New System.Drawing.Point(320, 8)
        Me._Line1_3.Name = "_Line1_3"
        Me._Line1_3.Size = New System.Drawing.Size(1, 384)
        Me._Line1_3.TabIndex = 12
        '
        '_Line1_2
        '
        Me._Line1_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._Line1_2.Enabled = False
        Me._Line1_2.Location = New System.Drawing.Point(8, 8)
        Me._Line1_2.Name = "_Line1_2"
        Me._Line1_2.Size = New System.Drawing.Size(1, 384)
        Me._Line1_2.TabIndex = 13
        '
        '_Line1_1
        '
        Me._Line1_1.BackColor = System.Drawing.Color.White
        Me._Line1_1.Enabled = False
        Me._Line1_1.Location = New System.Drawing.Point(8, 392)
        Me._Line1_1.Name = "_Line1_1"
        Me._Line1_1.Size = New System.Drawing.Size(312, 1)
        Me._Line1_1.TabIndex = 14
        '
        '_Line1_0
        '
        Me._Line1_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._Line1_0.Enabled = False
        Me._Line1_0.ForeColor = System.Drawing.Color.Cyan
        Me._Line1_0.Location = New System.Drawing.Point(8, 8)
        Me._Line1_0.Name = "_Line1_0"
        Me._Line1_0.Size = New System.Drawing.Size(312, 1)
        Me._Line1_0.TabIndex = 15
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.Transparent
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(16, 40)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(89, 17)
        Me._Label_2.TabIndex = 48
        Me._Label_2.Tag = "Budget:"
        Me._Label_2.Text = "Ngân sách :"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.Transparent
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_3.Location = New System.Drawing.Point(16, 64)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(89, 17)
        Me._Label_3.TabIndex = 47
        Me._Label_3.Tag = "Capital:"
        Me._Label_3.Text = "Tự bổ sung :"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.Transparent
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_4.Location = New System.Drawing.Point(16, 88)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(89, 17)
        Me._Label_4.TabIndex = 46
        Me._Label_4.Tag = "Others:"
        Me._Label_4.Text = "Các nguồn khác :"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.Transparent
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_5.Location = New System.Drawing.Point(16, 296)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(89, 17)
        Me._Label_5.TabIndex = 45
        Me._Label_5.Tag = "Budget:"
        Me._Label_5.Text = "Ngân sách :"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.Transparent
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_6.Location = New System.Drawing.Point(16, 320)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(89, 17)
        Me._Label_6.TabIndex = 44
        Me._Label_6.Tag = "Capital:"
        Me._Label_6.Text = "Tự bổ sung :"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.Transparent
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_7.Location = New System.Drawing.Point(16, 344)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(89, 17)
        Me._Label_7.TabIndex = 43
        Me._Label_7.Tag = "Others:"
        Me._Label_7.Text = "Các nguồn khác :"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.Transparent
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.Color.Navy
        Me._Label_8.Location = New System.Drawing.Point(112, 16)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(89, 17)
        Me._Label_8.TabIndex = 42
        Me._Label_8.Text = "0,0"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_9
        '
        Me._Label_9.BackColor = System.Drawing.Color.Transparent
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.Color.Navy
        Me._Label_9.Location = New System.Drawing.Point(120, 40)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.Size = New System.Drawing.Size(81, 17)
        Me._Label_9.TabIndex = 41
        Me._Label_9.Text = "0,0"
        Me._Label_9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.Transparent
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.Color.Navy
        Me._Label_10.Location = New System.Drawing.Point(120, 64)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(81, 17)
        Me._Label_10.TabIndex = 40
        Me._Label_10.Text = "0,0"
        Me._Label_10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.Transparent
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.Color.Navy
        Me._Label_11.Location = New System.Drawing.Point(120, 88)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(81, 17)
        Me._Label_11.TabIndex = 39
        Me._Label_11.Text = "0,0"
        Me._Label_11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_12
        '
        Me._Label_12.BackColor = System.Drawing.Color.Transparent
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.Color.Navy
        Me._Label_12.Location = New System.Drawing.Point(112, 144)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.Size = New System.Drawing.Size(89, 17)
        Me._Label_12.TabIndex = 38
        Me._Label_12.Text = "0,0"
        Me._Label_12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.Transparent
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.Color.Navy
        Me._Label_13.Location = New System.Drawing.Point(120, 168)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(81, 17)
        Me._Label_13.TabIndex = 37
        Me._Label_13.Text = "0,0"
        Me._Label_13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.Color.Transparent
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.Color.Navy
        Me._Label_14.Location = New System.Drawing.Point(120, 192)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(81, 17)
        Me._Label_14.TabIndex = 36
        Me._Label_14.Text = "0,0"
        Me._Label_14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_15
        '
        Me._Label_15.BackColor = System.Drawing.Color.Transparent
        Me._Label_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_15.ForeColor = System.Drawing.Color.Navy
        Me._Label_15.Location = New System.Drawing.Point(120, 216)
        Me._Label_15.Name = "_Label_15"
        Me._Label_15.Size = New System.Drawing.Size(81, 17)
        Me._Label_15.TabIndex = 35
        Me._Label_15.Text = "0,0"
        Me._Label_15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_16
        '
        Me._Label_16.BackColor = System.Drawing.Color.Transparent
        Me._Label_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_16.ForeColor = System.Drawing.Color.Black
        Me._Label_16.Location = New System.Drawing.Point(216, 16)
        Me._Label_16.Name = "_Label_16"
        Me._Label_16.Size = New System.Drawing.Size(89, 17)
        Me._Label_16.TabIndex = 34
        Me._Label_16.Text = "0,0"
        Me._Label_16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.Color.Transparent
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.ForeColor = System.Drawing.Color.Black
        Me._Label_17.Location = New System.Drawing.Point(216, 144)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(89, 17)
        Me._Label_17.TabIndex = 33
        Me._Label_17.Text = "0,0"
        Me._Label_17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_22
        '
        Me._Label_22.BackColor = System.Drawing.Color.Transparent
        Me._Label_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_22.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_22.Location = New System.Drawing.Point(16, 112)
        Me._Label_22.Name = "_Label_22"
        Me._Label_22.Size = New System.Drawing.Size(89, 17)
        Me._Label_22.TabIndex = 32
        Me._Label_22.Tag = "Credit:"
        Me._Label_22.Text = "Tín dụng :"
        Me._Label_22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_23
        '
        Me._Label_23.BackColor = System.Drawing.Color.Transparent
        Me._Label_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_23.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_23.Location = New System.Drawing.Point(16, 368)
        Me._Label_23.Name = "_Label_23"
        Me._Label_23.Size = New System.Drawing.Size(89, 17)
        Me._Label_23.TabIndex = 31
        Me._Label_23.Tag = "Credit:"
        Me._Label_23.Text = "Tín dụng :"
        Me._Label_23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_30
        '
        Me._Label_30.BackColor = System.Drawing.Color.Transparent
        Me._Label_30.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_30.ForeColor = System.Drawing.Color.Navy
        Me._Label_30.Location = New System.Drawing.Point(120, 344)
        Me._Label_30.Name = "_Label_30"
        Me._Label_30.Size = New System.Drawing.Size(81, 17)
        Me._Label_30.TabIndex = 30
        Me._Label_30.Text = "0,0"
        Me._Label_30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_31
        '
        Me._Label_31.BackColor = System.Drawing.Color.Transparent
        Me._Label_31.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_31.ForeColor = System.Drawing.Color.Navy
        Me._Label_31.Location = New System.Drawing.Point(120, 320)
        Me._Label_31.Name = "_Label_31"
        Me._Label_31.Size = New System.Drawing.Size(81, 17)
        Me._Label_31.TabIndex = 29
        Me._Label_31.Text = "0,0"
        Me._Label_31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_32
        '
        Me._Label_32.BackColor = System.Drawing.Color.Transparent
        Me._Label_32.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_32.ForeColor = System.Drawing.Color.Navy
        Me._Label_32.Location = New System.Drawing.Point(120, 296)
        Me._Label_32.Name = "_Label_32"
        Me._Label_32.Size = New System.Drawing.Size(81, 17)
        Me._Label_32.TabIndex = 28
        Me._Label_32.Text = "0,0"
        Me._Label_32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_33
        '
        Me._Label_33.BackColor = System.Drawing.Color.Transparent
        Me._Label_33.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_33.ForeColor = System.Drawing.Color.Navy
        Me._Label_33.Location = New System.Drawing.Point(112, 272)
        Me._Label_33.Name = "_Label_33"
        Me._Label_33.Size = New System.Drawing.Size(89, 17)
        Me._Label_33.TabIndex = 27
        Me._Label_33.Text = "0,0"
        Me._Label_33.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_37
        '
        Me._Label_37.BackColor = System.Drawing.Color.Transparent
        Me._Label_37.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_37.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_37.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_37.Location = New System.Drawing.Point(16, 272)
        Me._Label_37.Name = "_Label_37"
        Me._Label_37.Size = New System.Drawing.Size(81, 17)
        Me._Label_37.TabIndex = 26
        Me._Label_37.Tag = "Residual value"
        Me._Label_37.Text = "Giá trị còn lại"
        Me._Label_37.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_38
        '
        Me._Label_38.BackColor = System.Drawing.Color.Transparent
        Me._Label_38.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_38.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_38.ForeColor = System.Drawing.Color.Black
        Me._Label_38.Location = New System.Drawing.Point(224, 344)
        Me._Label_38.Name = "_Label_38"
        Me._Label_38.Size = New System.Drawing.Size(81, 17)
        Me._Label_38.TabIndex = 25
        Me._Label_38.Text = "0,0"
        Me._Label_38.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_39
        '
        Me._Label_39.BackColor = System.Drawing.Color.Transparent
        Me._Label_39.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_39.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_39.ForeColor = System.Drawing.Color.Black
        Me._Label_39.Location = New System.Drawing.Point(224, 320)
        Me._Label_39.Name = "_Label_39"
        Me._Label_39.Size = New System.Drawing.Size(81, 17)
        Me._Label_39.TabIndex = 24
        Me._Label_39.Text = "0,0"
        Me._Label_39.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_40
        '
        Me._Label_40.BackColor = System.Drawing.Color.Transparent
        Me._Label_40.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_40.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_40.ForeColor = System.Drawing.Color.Black
        Me._Label_40.Location = New System.Drawing.Point(224, 296)
        Me._Label_40.Name = "_Label_40"
        Me._Label_40.Size = New System.Drawing.Size(81, 17)
        Me._Label_40.TabIndex = 23
        Me._Label_40.Text = "0,0"
        Me._Label_40.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_41
        '
        Me._Label_41.BackColor = System.Drawing.Color.Transparent
        Me._Label_41.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_41.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_41.ForeColor = System.Drawing.Color.Black
        Me._Label_41.Location = New System.Drawing.Point(216, 272)
        Me._Label_41.Name = "_Label_41"
        Me._Label_41.Size = New System.Drawing.Size(89, 17)
        Me._Label_41.TabIndex = 22
        Me._Label_41.Text = "0,0"
        Me._Label_41.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(16, 16)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(81, 17)
        Me._Label_0.TabIndex = 21
        Me._Label_0.Tag = "Original Cost:"
        Me._Label_0.Text = "Nguyên giá"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(16, 144)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(81, 17)
        Me._Label_1.TabIndex = 20
        Me._Label_1.Tag = "Deperciation"
        Me._Label_1.Text = "Hao mòn"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_24
        '
        Me._Label_24.BackColor = System.Drawing.Color.Transparent
        Me._Label_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_24.ForeColor = System.Drawing.Color.Navy
        Me._Label_24.Location = New System.Drawing.Point(120, 368)
        Me._Label_24.Name = "_Label_24"
        Me._Label_24.Size = New System.Drawing.Size(81, 17)
        Me._Label_24.TabIndex = 19
        Me._Label_24.Text = "0,0"
        Me._Label_24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_35
        '
        Me._Label_35.BackColor = System.Drawing.Color.Transparent
        Me._Label_35.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_35.ForeColor = System.Drawing.Color.Black
        Me._Label_35.Location = New System.Drawing.Point(224, 368)
        Me._Label_35.Name = "_Label_35"
        Me._Label_35.Size = New System.Drawing.Size(81, 17)
        Me._Label_35.TabIndex = 18
        Me._Label_35.Text = "0,0"
        Me._Label_35.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_42
        '
        Me._Label_42.BackColor = System.Drawing.Color.Transparent
        Me._Label_42.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_42.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_42.ForeColor = System.Drawing.Color.Navy
        Me._Label_42.Location = New System.Drawing.Point(120, 112)
        Me._Label_42.Name = "_Label_42"
        Me._Label_42.Size = New System.Drawing.Size(81, 17)
        Me._Label_42.TabIndex = 17
        Me._Label_42.Text = "0,0"
        Me._Label_42.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_43
        '
        Me._Label_43.BackColor = System.Drawing.Color.Transparent
        Me._Label_43.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_43.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_43.ForeColor = System.Drawing.Color.Navy
        Me._Label_43.Location = New System.Drawing.Point(120, 240)
        Me._Label_43.Name = "_Label_43"
        Me._Label_43.Size = New System.Drawing.Size(81, 17)
        Me._Label_43.TabIndex = 16
        Me._Label_43.Text = "0,0"
        Me._Label_43.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_18
        '
        Me._Label_18.BackColor = System.Drawing.Color.Transparent
        Me._Label_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_18.Location = New System.Drawing.Point(16, 240)
        Me._Label_18.Name = "_Label_18"
        Me._Label_18.Size = New System.Drawing.Size(89, 17)
        Me._Label_18.TabIndex = 15
        Me._Label_18.Tag = "Credit:"
        Me._Label_18.Text = "Tín dụng :"
        Me._Label_18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_19
        '
        Me._Label_19.BackColor = System.Drawing.Color.Transparent
        Me._Label_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_19.Location = New System.Drawing.Point(16, 216)
        Me._Label_19.Name = "_Label_19"
        Me._Label_19.Size = New System.Drawing.Size(89, 17)
        Me._Label_19.TabIndex = 14
        Me._Label_19.Tag = "Others:"
        Me._Label_19.Text = "Các nguồn khác :"
        Me._Label_19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_20
        '
        Me._Label_20.BackColor = System.Drawing.Color.Transparent
        Me._Label_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_20.Location = New System.Drawing.Point(16, 192)
        Me._Label_20.Name = "_Label_20"
        Me._Label_20.Size = New System.Drawing.Size(89, 17)
        Me._Label_20.TabIndex = 13
        Me._Label_20.Tag = "Capital:"
        Me._Label_20.Text = "Tự bổ sung :"
        Me._Label_20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_21
        '
        Me._Label_21.BackColor = System.Drawing.Color.Transparent
        Me._Label_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_21.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_21.Location = New System.Drawing.Point(16, 168)
        Me._Label_21.Name = "_Label_21"
        Me._Label_21.Size = New System.Drawing.Size(89, 17)
        Me._Label_21.TabIndex = 12
        Me._Label_21.Tag = "Budget:"
        Me._Label_21.Text = "Ngân sách :"
        Me._Label_21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmTangGiam
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(417, 401)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Text_0)
        Me.Controls.Add(Me._Text_1)
        Me.Controls.Add(Me._Text_2)
        Me.Controls.Add(Me._Text_3)
        Me.Controls.Add(Me._Text_4)
        Me.Controls.Add(Me._Text_5)
        Me.Controls.Add(Me._Text_6)
        Me.Controls.Add(Me._Text_7)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Line1_3)
        Me.Controls.Add(Me._Line1_2)
        Me.Controls.Add(Me._Line1_1)
        Me.Controls.Add(Me._Line1_0)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_5)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_9)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Label_11)
        Me.Controls.Add(Me._Label_12)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me._Label_14)
        Me.Controls.Add(Me._Label_15)
        Me.Controls.Add(Me._Label_16)
        Me.Controls.Add(Me._Label_17)
        Me.Controls.Add(Me._Label_22)
        Me.Controls.Add(Me._Label_23)
        Me.Controls.Add(Me._Label_30)
        Me.Controls.Add(Me._Label_31)
        Me.Controls.Add(Me._Label_32)
        Me.Controls.Add(Me._Label_33)
        Me.Controls.Add(Me._Label_37)
        Me.Controls.Add(Me._Label_38)
        Me.Controls.Add(Me._Label_39)
        Me.Controls.Add(Me._Label_40)
        Me.Controls.Add(Me._Label_41)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_24)
        Me.Controls.Add(Me._Label_35)
        Me.Controls.Add(Me._Label_42)
        Me.Controls.Add(Me._Label_43)
        Me.Controls.Add(Me._Label_18)
        Me.Controls.Add(Me._Label_19)
        Me.Controls.Add(Me._Label_20)
        Me.Controls.Add(Me._Label_21)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(106, 47)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTangGiam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Fixed Assets Increasing - Decreasing"
        Me.Text = "Giá trị điều chỉnh"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializeText_Renamed()
		Me.Text_Renamed(0) = _Text_0
		Me.Text_Renamed(1) = _Text_1
		Me.Text_Renamed(2) = _Text_2
		Me.Text_Renamed(3) = _Text_3
		Me.Text_Renamed(4) = _Text_4
		Me.Text_Renamed(5) = _Text_5
		Me.Text_Renamed(6) = _Text_6
		Me.Text_Renamed(7) = _Text_7
	End Sub
	Sub InitializeLine1()
		Me.Line1(3) = _Line1_3
		Me.Line1(2) = _Line1_2
		Me.Line1(1) = _Line1_1
		Me.Line1(0) = _Line1_0
	End Sub
	Sub InitializeLabel()
		Me.Label(2) = _Label_2
		Me.Label(3) = _Label_3
		Me.Label(4) = _Label_4
		Me.Label(5) = _Label_5
		Me.Label(6) = _Label_6
		Me.Label(7) = _Label_7
		Me.Label(8) = _Label_8
		Me.Label(9) = _Label_9
		Me.Label(10) = _Label_10
		Me.Label(11) = _Label_11
		Me.Label(12) = _Label_12
		Me.Label(13) = _Label_13
		Me.Label(14) = _Label_14
		Me.Label(15) = _Label_15
		Me.Label(16) = _Label_16
		Me.Label(17) = _Label_17
		Me.Label(22) = _Label_22
		Me.Label(23) = _Label_23
		Me.Label(30) = _Label_30
		Me.Label(31) = _Label_31
		Me.Label(32) = _Label_32
		Me.Label(33) = _Label_33
		Me.Label(37) = _Label_37
		Me.Label(38) = _Label_38
		Me.Label(39) = _Label_39
		Me.Label(40) = _Label_40
		Me.Label(41) = _Label_41
		Me.Label(0) = _Label_0
		Me.Label(1) = _Label_1
		Me.Label(24) = _Label_24
		Me.Label(35) = _Label_35
		Me.Label(42) = _Label_42
		Me.Label(43) = _Label_43
		Me.Label(18) = _Label_18
		Me.Label(19) = _Label_19
		Me.Label(20) = _Label_20
		Me.Label(21) = _Label_21
	End Sub
	Sub InitializeCommand1()
		Me.Command1(0) = _Command1_0
		Me.Command1(1) = _Command1_1
	End Sub
	Sub InitializeCommand()
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
#End Region 
End Class
