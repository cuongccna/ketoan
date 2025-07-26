<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOptTrichluong
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeCommand()
		InitializeChk()
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
	Private WithEvents _Chk_3 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_2 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_1 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_0 As System.Windows.Forms.CheckBox
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Public Chk(3) As System.Windows.Forms.CheckBox
    Public Command(1) As System.Windows.Forms.Button
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Chk_3 = New System.Windows.Forms.CheckBox()
        Me._Chk_2 = New System.Windows.Forms.CheckBox()
        Me._Chk_1 = New System.Windows.Forms.CheckBox()
        Me._Chk_0 = New System.Windows.Forms.CheckBox()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me._Command_1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        '_Chk_3
        '
        Me._Chk_3.BackColor = System.Drawing.Color.Transparent
        Me._Chk_3.Checked = True
        Me._Chk_3.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Chk_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_3.Location = New System.Drawing.Point(8, 80)
        Me._Chk_3.Name = "_Chk_3"
        Me._Chk_3.Size = New System.Drawing.Size(227, 17)
        Me._Chk_3.TabIndex = 3
        Me._Chk_3.Tag = "0"
        Me._Chk_3.Text = "Công trình"
        Me._Chk_3.UseVisualStyleBackColor = False
        Me._Chk_3.Visible = False
        '
        '_Chk_2
        '
        Me._Chk_2.BackColor = System.Drawing.Color.Transparent
        Me._Chk_2.Checked = True
        Me._Chk_2.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Chk_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_2.Location = New System.Drawing.Point(8, 56)
        Me._Chk_2.Name = "_Chk_2"
        Me._Chk_2.Size = New System.Drawing.Size(227, 17)
        Me._Chk_2.TabIndex = 2
        Me._Chk_2.Tag = "0"
        Me._Chk_2.Text = "Sản xuất"
        Me._Chk_2.UseVisualStyleBackColor = False
        Me._Chk_2.Visible = False
        '
        '_Chk_1
        '
        Me._Chk_1.BackColor = System.Drawing.Color.Transparent
        Me._Chk_1.Checked = True
        Me._Chk_1.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Chk_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_1.Location = New System.Drawing.Point(8, 32)
        Me._Chk_1.Name = "_Chk_1"
        Me._Chk_1.Size = New System.Drawing.Size(227, 17)
        Me._Chk_1.TabIndex = 1
        Me._Chk_1.Tag = "0"
        Me._Chk_1.Text = "Bàn hàng"
        Me._Chk_1.UseVisualStyleBackColor = False
        Me._Chk_1.Visible = False
        '
        '_Chk_0
        '
        Me._Chk_0.BackColor = System.Drawing.Color.Transparent
        Me._Chk_0.Checked = True
        Me._Chk_0.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Chk_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_0.Location = New System.Drawing.Point(8, 8)
        Me._Chk_0.Name = "_Chk_0"
        Me._Chk_0.Size = New System.Drawing.Size(227, 17)
        Me._Chk_0.TabIndex = 0
        Me._Chk_0.Tag = "0"
        Me._Chk_0.Text = "Văn phòng"
        Me._Chk_0.UseVisualStyleBackColor = False
        Me._Chk_0.Visible = False
        '
        '_Command_0
        '
        Me._Command_0.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(248, 40)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(89, 25)
        Me._Command_0.TabIndex = 5
        Me._Command_0.Tag = "Return"
        Me._Command_0.Text = "Trở &về"
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Xu_ly
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(248, 8)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(89, 25)
        Me._Command_1.TabIndex = 4
        Me._Command_1.Tag = "Apply"
        Me._Command_1.Text = "&Thực hiện"
        '
        'FrmOptTrichluong
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(349, 107)
        Me.Controls.Add(Me._Chk_3)
        Me.Controls.Add(Me._Chk_2)
        Me.Controls.Add(Me._Chk_1)
        Me.Controls.Add(Me._Chk_0)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command_1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOptTrichluong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Salary deductions for parts"
        Me.Text = "Bộ phận trích lương"
        Me.ResumeLayout(False)

    End Sub
	Sub InitializeCommand()
		Me.Command(0) = _Command_0
		Me.Command(1) = _Command_1
	End Sub
	Sub InitializeChk()
		Me.Chk(3) = _Chk_3
		Me.Chk(2) = _Chk_2
		Me.Chk(1) = _Chk_1
		Me.Chk(0) = _Chk_0
	End Sub
#End Region 
End Class
