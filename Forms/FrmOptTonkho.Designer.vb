<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOptTonkho
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeOpt()
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
    Private WithEvents _Opt_3 As System.Windows.Forms.RadioButton
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Opt_2 As System.Windows.Forms.RadioButton
    Private WithEvents _Opt_1 As System.Windows.Forms.RadioButton
    Private WithEvents _Opt_0 As System.Windows.Forms.RadioButton
    Public Command(1) As System.Windows.Forms.Button
    Public Command1(1) As System.Windows.Forms.Button
    Public Opt(3) As System.Windows.Forms.RadioButton
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOptTonkho))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Opt_3 = New System.Windows.Forms.RadioButton
        Me._Command1_0 = New System.Windows.Forms.Button
        Me._Command1_1 = New System.Windows.Forms.Button
        Me._Opt_2 = New System.Windows.Forms.RadioButton
        Me._Opt_1 = New System.Windows.Forms.RadioButton
        Me._Opt_0 = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(112, 40)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 7
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.list16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(112, 8)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 6
        Me._Command_0.Tag = "Listed"
        Me._Command_0.Text = "&Liệt kê"
        '
        '_Opt_3
        '
        Me._Opt_3.BackColor = System.Drawing.Color.Transparent
        Me._Opt_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_3.Location = New System.Drawing.Point(8, 80)
        Me._Opt_3.Name = "_Opt_3"
        Me._Opt_3.Size = New System.Drawing.Size(102, 17)
        Me._Opt_3.TabIndex = 3
        Me._Opt_3.TabStop = True
        Me._Opt_3.Tag = "Correct beginning"
        Me._Opt_3.Text = "Sửa đầu kỳ"
        Me._Opt_3.UseVisualStyleBackColor = False
        '
        '_Command1_0
        '
        Me._Command1_0.BackColor = System.Drawing.Color.Silver
        Me._Command1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_0.Image = CType(resources.GetObject("_Command1_0.Image"), System.Drawing.Image)
        Me._Command1_0.Location = New System.Drawing.Point(112, 8)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(73, 25)
        Me._Command1_0.TabIndex = 4
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&List"
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
        Me._Command1_1.Location = New System.Drawing.Point(112, 40)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(73, 25)
        Me._Command1_1.TabIndex = 5
        Me._Command1_1.TabStop = False
        Me._Command1_1.Tag = "&Return"
        Me._Command1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_1.UseVisualStyleBackColor = False
        Me._Command1_1.Visible = False
        '
        '_Opt_2
        '
        Me._Opt_2.BackColor = System.Drawing.Color.Transparent
        Me._Opt_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_2.Location = New System.Drawing.Point(8, 56)
        Me._Opt_2.Name = "_Opt_2"
        Me._Opt_2.Size = New System.Drawing.Size(102, 17)
        Me._Opt_2.TabIndex = 2
        Me._Opt_2.TabStop = True
        Me._Opt_2.Tag = "Ledger"
        Me._Opt_2.Text = "Sổ chi tiết"
        Me._Opt_2.UseVisualStyleBackColor = False
        '
        '_Opt_1
        '
        Me._Opt_1.BackColor = System.Drawing.Color.Transparent
        Me._Opt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_1.Location = New System.Drawing.Point(8, 32)
        Me._Opt_1.Name = "_Opt_1"
        Me._Opt_1.Size = New System.Drawing.Size(102, 17)
        Me._Opt_1.TabIndex = 1
        Me._Opt_1.TabStop = True
        Me._Opt_1.Tag = "Export Voucher"
        Me._Opt_1.Text = "Chứng từ xuất"
        Me._Opt_1.UseVisualStyleBackColor = False
        '
        '_Opt_0
        '
        Me._Opt_0.BackColor = System.Drawing.Color.Transparent
        Me._Opt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_0.Location = New System.Drawing.Point(8, 8)
        Me._Opt_0.Name = "_Opt_0"
        Me._Opt_0.Size = New System.Drawing.Size(102, 17)
        Me._Opt_0.TabIndex = 0
        Me._Opt_0.TabStop = True
        Me._Opt_0.Tag = "Imports Voucher"
        Me._Opt_0.Text = "Chứng từ nhập"
        Me._Opt_0.UseVisualStyleBackColor = False
        '
        'FrmOptTonkho
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(194, 104)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Opt_3)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Opt_2)
        Me.Controls.Add(Me._Opt_1)
        Me.Controls.Add(Me._Opt_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOptTonkho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Operations"
        Me.Text = "Các thao tác"
        Me.ResumeLayout(False)

    End Sub
	Sub InitializeOpt()
		Me.Opt(3) = _Opt_3
		Me.Opt(2) = _Opt_2
		Me.Opt(1) = _Opt_1
		Me.Opt(0) = _Opt_0
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
