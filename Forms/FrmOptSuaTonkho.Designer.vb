<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOptSuaTonkho
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
        isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		InitializeOpt()
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
    Private WithEvents _Opt_2 As System.Windows.Forms.RadioButton
    Public WithEvents txtVT As System.Windows.Forms.TextBox
    Private WithEvents _Opt_1 As System.Windows.Forms.RadioButton
    Private WithEvents _Opt_0 As System.Windows.Forms.RadioButton
    Public WithEvents Label As System.Windows.Forms.Label
    Public Command(1) As System.Windows.Forms.Button
    Public Opt(2) As System.Windows.Forms.RadioButton
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Opt_2 = New System.Windows.Forms.RadioButton
        Me.txtVT = New System.Windows.Forms.TextBox
        Me._Opt_1 = New System.Windows.Forms.RadioButton
        Me._Opt_0 = New System.Windows.Forms.RadioButton
        Me.Label = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(104, 80)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(89, 25)
        Me._Command_1.TabIndex = 6
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.select16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(8, 80)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(89, 25)
        Me._Command_0.TabIndex = 5
        Me._Command_0.Tag = "Apply"
        Me._Command_0.Text = "&Thực hiện"
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
        Me._Opt_2.Tag = "Change Account"
        Me._Opt_2.Text = "Đổi tài khoản"
        Me._Opt_2.UseVisualStyleBackColor = False
        '
        'txtVT
        '
        Me.txtVT.AcceptsReturn = True
        Me.txtVT.BackColor = System.Drawing.SystemColors.Window
        Me.txtVT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVT.Location = New System.Drawing.Point(104, 32)
        Me.txtVT.MaxLength = 100
        Me.txtVT.Name = "txtVT"
        Me.txtVT.Size = New System.Drawing.Size(89, 20)
        Me.txtVT.TabIndex = 3
        Me.txtVT.Visible = False
        '
        '_Opt_1
        '
        Me._Opt_1.BackColor = System.Drawing.Color.Transparent
        Me._Opt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_1.Location = New System.Drawing.Point(8, 32)
        Me._Opt_1.Name = "_Opt_1"
        Me._Opt_1.Size = New System.Drawing.Size(96, 17)
        Me._Opt_1.TabIndex = 1
        Me._Opt_1.TabStop = True
        Me._Opt_1.Tag = "Change material"
        Me._Opt_1.Text = "Đổi vật tư"
        Me._Opt_1.UseVisualStyleBackColor = False
        '
        '_Opt_0
        '
        Me._Opt_0.BackColor = System.Drawing.Color.Transparent
        Me._Opt_0.Checked = True
        Me._Opt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_0.Location = New System.Drawing.Point(8, 8)
        Me._Opt_0.Name = "_Opt_0"
        Me._Opt_0.Size = New System.Drawing.Size(96, 17)
        Me._Opt_0.TabIndex = 0
        Me._Opt_0.TabStop = True
        Me._Opt_0.Tag = "Edit Voucher"
        Me._Opt_0.Text = "Sửa chứng từ"
        Me._Opt_0.UseVisualStyleBackColor = False
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.Color.Transparent
        Me.Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label.Location = New System.Drawing.Point(104, 16)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(89, 17)
        Me.Label.TabIndex = 4
        Me.Label.Tag = "Material code"
        Me.Label.Text = "Mã vật tư"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label.Visible = False
        '
        'FrmOptSuaTonkho
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(201, 113)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Opt_2)
        Me.Controls.Add(Me.txtVT)
        Me.Controls.Add(Me._Opt_1)
        Me.Controls.Add(Me._Opt_0)
        Me.Controls.Add(Me.Label)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOptSuaTonkho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Operation"
        Me.Text = "Các thao tác"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializeOpt()
		Me.Opt(2) = _Opt_2
		Me.Opt(1) = _Opt_1
		Me.Opt(0) = _Opt_0
	End Sub
	Sub InitializeCommand()
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
#End Region 
End Class
