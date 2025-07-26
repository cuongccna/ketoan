<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMauhoadon
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
        isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		Initializeopt1()
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
	Public WithEvents Picture1 As System.Windows.Forms.PictureBox
	Private WithEvents _opt1_0 As System.Windows.Forms.RadioButton
	Private WithEvents _opt1_1 As System.Windows.Forms.RadioButton
	Private WithEvents _opt1_2 As System.Windows.Forms.RadioButton
	Private WithEvents _opt1_3 As System.Windows.Forms.RadioButton
	Private WithEvents _opt1_4 As System.Windows.Forms.RadioButton
	Private WithEvents _opt1_5 As System.Windows.Forms.RadioButton
	Private WithEvents _opt1_6 As System.Windows.Forms.RadioButton
	Private WithEvents _opt1_7 As System.Windows.Forms.RadioButton
	Private WithEvents _opt1_8 As System.Windows.Forms.RadioButton
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Public Command(2) As System.Windows.Forms.Button
    Public Label(17) As System.Windows.Forms.Label
    Public opt1(8) As System.Windows.Forms.RadioButton
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMauhoadon))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.Picture1 = New System.Windows.Forms.PictureBox()
        Me._opt1_0 = New System.Windows.Forms.RadioButton()
        Me._opt1_1 = New System.Windows.Forms.RadioButton()
        Me._opt1_2 = New System.Windows.Forms.RadioButton()
        Me._opt1_3 = New System.Windows.Forms.RadioButton()
        Me._opt1_4 = New System.Windows.Forms.RadioButton()
        Me._opt1_5 = New System.Windows.Forms.RadioButton()
        Me._opt1_6 = New System.Windows.Forms.RadioButton()
        Me._opt1_7 = New System.Windows.Forms.RadioButton()
        Me._opt1_8 = New System.Windows.Forms.RadioButton()
        Me._Command_2 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me._Label_2 = New System.Windows.Forms.Label()
        Me._Label_1 = New System.Windows.Forms.Label()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me._Label_17 = New System.Windows.Forms.Label()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.SystemColors.Control
        Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture1.Image = CType(resources.GetObject("Picture1.Image"), System.Drawing.Image)
        Me.Picture1.Location = New System.Drawing.Point(0, 40)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.Size = New System.Drawing.Size(321, 449)
        Me.Picture1.TabIndex = 14
        Me.Picture1.TabStop = False
        '
        '_opt1_0
        '
        Me._opt1_0.BackColor = System.Drawing.Color.Transparent
        Me._opt1_0.Checked = True
        Me._opt1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._opt1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._opt1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._opt1_0.Location = New System.Drawing.Point(360, 64)
        Me._opt1_0.Name = "_opt1_0"
        Me._opt1_0.Size = New System.Drawing.Size(97, 17)
        Me._opt1_0.TabIndex = 0
        Me._opt1_0.TabStop = True
        Me._opt1_0.Text = "Mẫu 1"
        Me._opt1_0.UseVisualStyleBackColor = False
        '
        '_opt1_1
        '
        Me._opt1_1.BackColor = System.Drawing.Color.Transparent
        Me._opt1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._opt1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._opt1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._opt1_1.Location = New System.Drawing.Point(360, 88)
        Me._opt1_1.Name = "_opt1_1"
        Me._opt1_1.Size = New System.Drawing.Size(97, 17)
        Me._opt1_1.TabIndex = 1
        Me._opt1_1.TabStop = True
        Me._opt1_1.Text = "Mẫu 2"
        Me._opt1_1.UseVisualStyleBackColor = False
        '
        '_opt1_2
        '
        Me._opt1_2.BackColor = System.Drawing.Color.Transparent
        Me._opt1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._opt1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._opt1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._opt1_2.Location = New System.Drawing.Point(360, 112)
        Me._opt1_2.Name = "_opt1_2"
        Me._opt1_2.Size = New System.Drawing.Size(97, 21)
        Me._opt1_2.TabIndex = 2
        Me._opt1_2.TabStop = True
        Me._opt1_2.Text = "Mẫu 3"
        Me._opt1_2.UseVisualStyleBackColor = False
        '
        '_opt1_3
        '
        Me._opt1_3.BackColor = System.Drawing.Color.Transparent
        Me._opt1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._opt1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._opt1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._opt1_3.Location = New System.Drawing.Point(360, 136)
        Me._opt1_3.Name = "_opt1_3"
        Me._opt1_3.Size = New System.Drawing.Size(97, 21)
        Me._opt1_3.TabIndex = 3
        Me._opt1_3.TabStop = True
        Me._opt1_3.Text = "Mẫu 4"
        Me._opt1_3.UseVisualStyleBackColor = False
        '
        '_opt1_4
        '
        Me._opt1_4.BackColor = System.Drawing.Color.Transparent
        Me._opt1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._opt1_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._opt1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._opt1_4.Location = New System.Drawing.Point(360, 176)
        Me._opt1_4.Name = "_opt1_4"
        Me._opt1_4.Size = New System.Drawing.Size(97, 21)
        Me._opt1_4.TabIndex = 4
        Me._opt1_4.TabStop = True
        Me._opt1_4.Text = "Mẫu 1"
        Me._opt1_4.UseVisualStyleBackColor = False
        '
        '_opt1_5
        '
        Me._opt1_5.BackColor = System.Drawing.Color.Transparent
        Me._opt1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._opt1_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._opt1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._opt1_5.Location = New System.Drawing.Point(360, 200)
        Me._opt1_5.Name = "_opt1_5"
        Me._opt1_5.Size = New System.Drawing.Size(97, 21)
        Me._opt1_5.TabIndex = 5
        Me._opt1_5.TabStop = True
        Me._opt1_5.Text = "Mẫu 2"
        Me._opt1_5.UseVisualStyleBackColor = False
        '
        '_opt1_6
        '
        Me._opt1_6.BackColor = System.Drawing.Color.Transparent
        Me._opt1_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._opt1_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._opt1_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._opt1_6.Location = New System.Drawing.Point(360, 248)
        Me._opt1_6.Name = "_opt1_6"
        Me._opt1_6.Size = New System.Drawing.Size(97, 17)
        Me._opt1_6.TabIndex = 6
        Me._opt1_6.TabStop = True
        Me._opt1_6.Text = "Mẫu 1"
        Me._opt1_6.UseVisualStyleBackColor = False
        '
        '_opt1_7
        '
        Me._opt1_7.BackColor = System.Drawing.Color.Transparent
        Me._opt1_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._opt1_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._opt1_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._opt1_7.Location = New System.Drawing.Point(360, 272)
        Me._opt1_7.Name = "_opt1_7"
        Me._opt1_7.Size = New System.Drawing.Size(97, 17)
        Me._opt1_7.TabIndex = 7
        Me._opt1_7.TabStop = True
        Me._opt1_7.Text = "Mẫu 2"
        Me._opt1_7.UseVisualStyleBackColor = False
        '
        '_opt1_8
        '
        Me._opt1_8.BackColor = System.Drawing.Color.Transparent
        Me._opt1_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._opt1_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._opt1_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._opt1_8.Location = New System.Drawing.Point(360, 296)
        Me._opt1_8.Name = "_opt1_8"
        Me._opt1_8.Size = New System.Drawing.Size(97, 17)
        Me._opt1_8.TabIndex = 8
        Me._opt1_8.TabStop = True
        Me._opt1_8.Text = "Mẫu 2"
        Me._opt1_8.UseVisualStyleBackColor = False
        '
        '_Command_2
        '
        Me._Command_2.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(400, 464)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(81, 25)
        Me._Command_2.TabIndex = 9
        Me._Command_2.Text = "Trở &về"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Silver
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.Transparent
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(344, 224)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(129, 20)
        Me._Label_2.TabIndex = 13
        Me._Label_2.Tag = "Code"
        Me._Label_2.Text = "Phiếu Xuất kho"
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(344, 160)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(142, 20)
        Me._Label_1.TabIndex = 12
        Me._Label_1.Tag = "Code"
        Me._Label_1.Text = "Hoá đơn GTGT xuất khẩu"
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(344, 40)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(153, 20)
        Me._Label_0.TabIndex = 11
        Me._Label_0.Tag = "Code"
        Me._Label_0.Text = "Hoá đơn GTGT (01GTKT)"
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.ForeColor = System.Drawing.Color.Black
        Me._Label_17.Location = New System.Drawing.Point(8, 8)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(321, 20)
        Me._Label_17.TabIndex = 10
        Me._Label_17.Tag = "Code"
        Me._Label_17.Text = "Mẫu hoá đơn"
        Me._Label_17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmMauhoadon
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(489, 497)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me._opt1_0)
        Me.Controls.Add(Me._opt1_1)
        Me.Controls.Add(Me._opt1_2)
        Me.Controls.Add(Me._opt1_3)
        Me.Controls.Add(Me._opt1_4)
        Me.Controls.Add(Me._opt1_5)
        Me.Controls.Add(Me._opt1_6)
        Me.Controls.Add(Me._opt1_7)
        Me.Controls.Add(Me._opt1_8)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_17)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMauhoadon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mẫu hoá đơn"
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
	Sub Initializeopt1()
		Me.opt1(0) = _opt1_0
		Me.opt1(1) = _opt1_1
		Me.opt1(2) = _opt1_2
		Me.opt1(3) = _opt1_3
		Me.opt1(4) = _opt1_4
		Me.opt1(5) = _opt1_5
		Me.opt1(6) = _opt1_6
		Me.opt1(7) = _opt1_7
		Me.opt1(8) = _opt1_8
	End Sub
	Sub InitializeLabel()
		Me.Label(2) = _Label_2
		Me.Label(1) = _Label_1
		Me.Label(0) = _Label_0
		Me.Label(17) = _Label_17
	End Sub
	Sub InitializeCommand()
		Me.Command(2) = _Command_2
	End Sub
#End Region 
End Class
