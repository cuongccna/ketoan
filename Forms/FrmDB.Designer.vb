<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDB
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializetxtMST()
		InitializeLstDB()
		InitializeLabel1()
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
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Command1_3 As System.Windows.Forms.Button
    Private WithEvents _txtMST_1 As System.Windows.Forms.TextBox
    Private WithEvents _Command1_2 As System.Windows.Forms.Button
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Private WithEvents _txtMST_0 As System.Windows.Forms.TextBox
    Private WithEvents _LstDB_1 As System.Windows.Forms.ListBox
    Private WithEvents _LstDB_0 As System.Windows.Forms.ListBox
    Private WithEvents _Label1_3 As System.Windows.Forms.Label
    Private WithEvents _Label1_2 As System.Windows.Forms.Label
    Private WithEvents _Label1_1 As System.Windows.Forms.Label
    Private WithEvents _Label1_0 As System.Windows.Forms.Label
    Public Command(3) As System.Windows.Forms.Button
    Public Command1(3) As System.Windows.Forms.Button
    Public Label1(3) As System.Windows.Forms.Label
    Public LstDB(1) As System.Windows.Forms.ListBox
    Public txtMST(1) As System.Windows.Forms.TextBox
    'Private listBoxHelper1 As Artinsoft.VB6.Gui.ListBoxHelper
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDB))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_3 = New System.Windows.Forms.Button()
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me._Command_2 = New System.Windows.Forms.Button()
        Me._Command1_1 = New System.Windows.Forms.Button()
        Me._Command1_3 = New System.Windows.Forms.Button()
        Me._txtMST_1 = New System.Windows.Forms.TextBox()
        Me._Command1_2 = New System.Windows.Forms.Button()
        Me._Command1_0 = New System.Windows.Forms.Button()
        Me._txtMST_0 = New System.Windows.Forms.TextBox()
        Me._LstDB_1 = New System.Windows.Forms.ListBox()
        Me._LstDB_0 = New System.Windows.Forms.ListBox()
        Me._Label1_3 = New System.Windows.Forms.Label()
        Me._Label1_2 = New System.Windows.Forms.Label()
        Me._Label1_1 = New System.Windows.Forms.Label()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        '_Command_3
        '
        Me._Command_3.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Mac_dinh
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(8, 288)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(161, 25)
        Me._Command_3.TabIndex = 7
        Me._Command_3.Text = "Đặt thành tệp mặc định"
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Preview
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(200, 288)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 5
        Me._Command_1.Text = "&Xem"
        '
        '_Command_0
        '
        Me._Command_0.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Liet_ke
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(280, 8)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 2
        Me._Command_0.Text = "&Liệt kê"
        '
        '_Command_2
        '
        Me._Command_2.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(280, 288)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 6
        Me._Command_2.Text = "Trở &về"
        '
        '_Command1_1
        '
        Me._Command1_1.BackColor = System.Drawing.Color.Silver
        Me._Command1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_1.Image = CType(resources.GetObject("_Command1_1.Image"), System.Drawing.Image)
        Me._Command1_1.Location = New System.Drawing.Point(200, 288)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(73, 25)
        Me._Command1_1.TabIndex = 9
        Me._Command1_1.TabStop = False
        Me._Command1_1.Tag = "&View"
        Me._Command1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_1.UseVisualStyleBackColor = False
        Me._Command1_1.Visible = False
        '
        '_Command1_3
        '
        Me._Command1_3.BackColor = System.Drawing.Color.Silver
        Me._Command1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_3.Location = New System.Drawing.Point(8, 288)
        Me._Command1_3.Name = "_Command1_3"
        Me._Command1_3.Size = New System.Drawing.Size(161, 25)
        Me._Command1_3.TabIndex = 11
        Me._Command1_3.TabStop = False
        Me._Command1_3.Tag = "&SELECT"
        Me._Command1_3.Text = "Đặt thành tệp mặc định"
        Me._Command1_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_3.UseVisualStyleBackColor = False
        Me._Command1_3.Visible = False
        '
        '_txtMST_1
        '
        Me._txtMST_1.AcceptsReturn = True
        Me._txtMST_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtMST_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtMST_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtMST_1.Location = New System.Drawing.Point(88, 32)
        Me._txtMST_1.MaxLength = 4
        Me._txtMST_1.Name = "_txtMST_1"
        Me._txtMST_1.Size = New System.Drawing.Size(81, 20)
        Me._txtMST_1.TabIndex = 1
        '
        '_Command1_2
        '
        Me._Command1_2.BackColor = System.Drawing.Color.Silver
        Me._Command1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_2.Image = CType(resources.GetObject("_Command1_2.Image"), System.Drawing.Image)
        Me._Command1_2.Location = New System.Drawing.Point(280, 288)
        Me._Command1_2.Name = "_Command1_2"
        Me._Command1_2.Size = New System.Drawing.Size(73, 25)
        Me._Command1_2.TabIndex = 10
        Me._Command1_2.TabStop = False
        Me._Command1_2.Tag = "&Return"
        Me._Command1_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_2.UseVisualStyleBackColor = False
        Me._Command1_2.Visible = False
        '
        '_Command1_0
        '
        Me._Command1_0.BackColor = System.Drawing.Color.Silver
        Me._Command1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_0.Image = CType(resources.GetObject("_Command1_0.Image"), System.Drawing.Image)
        Me._Command1_0.Location = New System.Drawing.Point(280, 8)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(73, 25)
        Me._Command1_0.TabIndex = 8
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&List"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        '_txtMST_0
        '
        Me._txtMST_0.AcceptsReturn = True
        Me._txtMST_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtMST_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtMST_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtMST_0.Location = New System.Drawing.Point(88, 8)
        Me._txtMST_0.MaxLength = 0
        Me._txtMST_0.Name = "_txtMST_0"
        Me._txtMST_0.Size = New System.Drawing.Size(185, 20)
        Me._txtMST_0.TabIndex = 0
        '
        '_LstDB_1
        '
        Me._LstDB_1.BackColor = System.Drawing.SystemColors.Window
        Me._LstDB_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LstDB_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LstDB_1.ItemHeight = 14
        Me._LstDB_1.Location = New System.Drawing.Point(104, 80)
        Me._LstDB_1.Name = "_LstDB_1"
        Me._LstDB_1.Size = New System.Drawing.Size(249, 186)
        Me._LstDB_1.TabIndex = 4
        '
        '_LstDB_0
        '
        Me._LstDB_0.BackColor = System.Drawing.SystemColors.Window
        Me._LstDB_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LstDB_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LstDB_0.ItemHeight = 14
        Me._LstDB_0.Location = New System.Drawing.Point(8, 80)
        Me._LstDB_0.Name = "_LstDB_0"
        Me._LstDB_0.Size = New System.Drawing.Size(89, 186)
        Me._LstDB_0.TabIndex = 3
        '
        '_Label1_3
        '
        Me._Label1_3.BackColor = System.Drawing.Color.Transparent
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_3.Location = New System.Drawing.Point(8, 32)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.Size = New System.Drawing.Size(81, 17)
        Me._Label1_3.TabIndex = 15
        Me._Label1_3.Text = "Năm tài chính"
        '
        '_Label1_2
        '
        Me._Label1_2.BackColor = System.Drawing.Color.Transparent
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(8, 8)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.Size = New System.Drawing.Size(65, 17)
        Me._Label1_2.TabIndex = 14
        Me._Label1_2.Text = "Mã số thuế"
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.Color.Transparent
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(104, 56)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.Size = New System.Drawing.Size(233, 17)
        Me._Label1_1.TabIndex = 13
        Me._Label1_1.Text = "Tên tệp"
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.Color.Transparent
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(8, 56)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.Size = New System.Drawing.Size(89, 17)
        Me._Label1_0.TabIndex = 12
        Me._Label1_0.Text = "Ngày lưu dữ liệu"
        '
        'FrmDB
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(361, 320)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Command1_3)
        Me.Controls.Add(Me._txtMST_1)
        Me.Controls.Add(Me._Command1_2)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me._txtMST_0)
        Me.Controls.Add(Me._LstDB_1)
        Me.Controls.Add(Me._LstDB_0)
        Me.Controls.Add(Me._Label1_3)
        Me.Controls.Add(Me._Label1_2)
        Me.Controls.Add(Me._Label1_1)
        Me.Controls.Add(Me._Label1_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(114, 112)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh sách tệp dữ liệu lưu trữ tự động"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializetxtMST()
		Me.txtMST(1) = _txtMST_1
		Me.txtMST(0) = _txtMST_0
	End Sub
	Sub InitializeLstDB()
		Me.LstDB(1) = _LstDB_1
		Me.LstDB(0) = _LstDB_0
	End Sub
	Sub InitializeLabel1()
		Me.Label1(3) = _Label1_3
		Me.Label1(2) = _Label1_2
		Me.Label1(1) = _Label1_1
		Me.Label1(0) = _Label1_0
	End Sub
	Sub InitializeCommand1()
		Me.Command1(1) = _Command1_1
		Me.Command1(3) = _Command1_3
		Me.Command1(2) = _Command1_2
		Me.Command1(0) = _Command1_0
	End Sub
	Sub InitializeCommand()
		Me.Command(3) = _Command_3
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
		Me.Command(2) = _Command_2
	End Sub
#End Region 
End Class
