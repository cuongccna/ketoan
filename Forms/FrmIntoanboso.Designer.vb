<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIntoanboso
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeOpt()
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
	Private WithEvents _Chk_9 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_8 As System.Windows.Forms.CheckBox
	Public WithEvents GauGe As System.Windows.Forms.ProgressBar
	Private WithEvents _Opt_1 As System.Windows.Forms.RadioButton
	Private WithEvents _Opt_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Private WithEvents _Chk_7 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_6 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_5 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_4 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_3 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_2 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_1 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_0 As System.Windows.Forms.CheckBox
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Public Chk(9) As System.Windows.Forms.CheckBox
    Public Command(1) As System.Windows.Forms.Button
    Public Opt(1) As System.Windows.Forms.RadioButton
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Chk_9 = New System.Windows.Forms.CheckBox()
        Me._Chk_8 = New System.Windows.Forms.CheckBox()
        Me.GauGe = New System.Windows.Forms.ProgressBar()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me._Opt_1 = New System.Windows.Forms.RadioButton()
        Me._Opt_0 = New System.Windows.Forms.RadioButton()
        Me._Chk_7 = New System.Windows.Forms.CheckBox()
        Me._Chk_6 = New System.Windows.Forms.CheckBox()
        Me._Chk_5 = New System.Windows.Forms.CheckBox()
        Me._Chk_4 = New System.Windows.Forms.CheckBox()
        Me._Chk_3 = New System.Windows.Forms.CheckBox()
        Me._Chk_2 = New System.Windows.Forms.CheckBox()
        Me._Chk_1 = New System.Windows.Forms.CheckBox()
        Me._Chk_0 = New System.Windows.Forms.CheckBox()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me._Command_1 = New System.Windows.Forms.Button()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Chk_9
        '
        Me._Chk_9.BackColor = System.Drawing.Color.Transparent
        Me._Chk_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_9.Location = New System.Drawing.Point(144, 8)
        Me._Chk_9.Name = "_Chk_9"
        Me._Chk_9.Size = New System.Drawing.Size(169, 17)
        Me._Chk_9.TabIndex = 6
        Me._Chk_9.Tag = "Employee payroll"
        Me._Chk_9.Text = "Bảng lương nhân viên"
        Me._Chk_9.UseVisualStyleBackColor = False
        '
        '_Chk_8
        '
        Me._Chk_8.BackColor = System.Drawing.Color.Transparent
        Me._Chk_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_8.Location = New System.Drawing.Point(8, 128)
        Me._Chk_8.Name = "_Chk_8"
        Me._Chk_8.Size = New System.Drawing.Size(135, 17)
        Me._Chk_8.TabIndex = 5
        Me._Chk_8.Tag = "Fluctuation of inventories"
        Me._Chk_8.Text = "Luỹ kế nhập xuất tồn"
        Me._Chk_8.UseVisualStyleBackColor = False
        '
        'GauGe
        '
        Me.GauGe.Location = New System.Drawing.Point(136, 160)
        Me.GauGe.Name = "GauGe"
        Me.GauGe.Size = New System.Drawing.Size(49, 17)
        Me.GauGe.TabIndex = 15
        Me.GauGe.Visible = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.Transparent
        Me.Frame1.Controls.Add(Me._Opt_1)
        Me.Frame1.Controls.Add(Me._Opt_0)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(144, 96)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(169, 48)
        Me.Frame1.TabIndex = 14
        Me.Frame1.TabStop = False
        '
        '_Opt_1
        '
        Me._Opt_1.BackColor = System.Drawing.Color.Transparent
        Me._Opt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_1.Enabled = False
        Me._Opt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_1.Location = New System.Drawing.Point(104, 16)
        Me._Opt_1.Name = "_Opt_1"
        Me._Opt_1.Size = New System.Drawing.Size(57, 17)
        Me._Opt_1.TabIndex = 11
        Me._Opt_1.TabStop = True
        Me._Opt_1.Tag = "Decision 15"
        Me._Opt_1.Text = "QĐ 15"
        Me._Opt_1.UseVisualStyleBackColor = False
        '
        '_Opt_0
        '
        Me._Opt_0.BackColor = System.Drawing.Color.Transparent
        Me._Opt_0.Checked = True
        Me._Opt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_0.Enabled = False
        Me._Opt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_0.Location = New System.Drawing.Point(16, 16)
        Me._Opt_0.Name = "_Opt_0"
        Me._Opt_0.Size = New System.Drawing.Size(57, 17)
        Me._Opt_0.TabIndex = 10
        Me._Opt_0.TabStop = True
        Me._Opt_0.Tag = "Decision 48"
        Me._Opt_0.Text = "QĐ 48"
        Me._Opt_0.UseVisualStyleBackColor = False
        '
        '_Chk_7
        '
        Me._Chk_7.BackColor = System.Drawing.Color.Transparent
        Me._Chk_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_7.Location = New System.Drawing.Point(8, 80)
        Me._Chk_7.Name = "_Chk_7"
        Me._Chk_7.Size = New System.Drawing.Size(121, 17)
        Me._Chk_7.TabIndex = 3
        Me._Chk_7.Tag = "Deposit book"
        Me._Chk_7.Text = "Sổ tiền gửi"
        Me._Chk_7.UseVisualStyleBackColor = False
        '
        '_Chk_6
        '
        Me._Chk_6.BackColor = System.Drawing.Color.Transparent
        Me._Chk_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_6.Location = New System.Drawing.Point(144, 56)
        Me._Chk_6.Name = "_Chk_6"
        Me._Chk_6.Size = New System.Drawing.Size(169, 17)
        Me._Chk_6.TabIndex = 8
        Me._Chk_6.Tag = "Tools Table"
        Me._Chk_6.Text = "Sổ công cụ dụng cụ"
        Me._Chk_6.UseVisualStyleBackColor = False
        '
        '_Chk_5
        '
        Me._Chk_5.BackColor = System.Drawing.Color.Transparent
        Me._Chk_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_5.Location = New System.Drawing.Point(144, 32)
        Me._Chk_5.Name = "_Chk_5"
        Me._Chk_5.Size = New System.Drawing.Size(169, 17)
        Me._Chk_5.TabIndex = 7
        Me._Chk_5.Tag = "Fixed Asset Table"
        Me._Chk_5.Text = "Sổ tài sản cố định"
        Me._Chk_5.UseVisualStyleBackColor = False
        '
        '_Chk_4
        '
        Me._Chk_4.BackColor = System.Drawing.Color.Transparent
        Me._Chk_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_4.Location = New System.Drawing.Point(8, 104)
        Me._Chk_4.Name = "_Chk_4"
        Me._Chk_4.Size = New System.Drawing.Size(121, 17)
        Me._Chk_4.TabIndex = 4
        Me._Chk_4.Tag = "Account balance"
        Me._Chk_4.Text = "Cân đối tài khoản"
        Me._Chk_4.UseVisualStyleBackColor = False
        '
        '_Chk_3
        '
        Me._Chk_3.BackColor = System.Drawing.Color.Transparent
        Me._Chk_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_3.Location = New System.Drawing.Point(144, 80)
        Me._Chk_3.Name = "_Chk_3"
        Me._Chk_3.Size = New System.Drawing.Size(177, 17)
        Me._Chk_3.TabIndex = 9
        Me._Chk_3.Tag = "Summary Production Expenses"
        Me._Chk_3.Text = "Chi phí sản xuất kinh doanh"
        Me._Chk_3.UseVisualStyleBackColor = False
        '
        '_Chk_2
        '
        Me._Chk_2.BackColor = System.Drawing.Color.Transparent
        Me._Chk_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_2.Location = New System.Drawing.Point(8, 32)
        Me._Chk_2.Name = "_Chk_2"
        Me._Chk_2.Size = New System.Drawing.Size(121, 17)
        Me._Chk_2.TabIndex = 1
        Me._Chk_2.Tag = "Ledger"
        Me._Chk_2.Text = "Sổ cái"
        Me._Chk_2.UseVisualStyleBackColor = False
        '
        '_Chk_1
        '
        Me._Chk_1.BackColor = System.Drawing.Color.Transparent
        Me._Chk_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_1.Location = New System.Drawing.Point(8, 56)
        Me._Chk_1.Name = "_Chk_1"
        Me._Chk_1.Size = New System.Drawing.Size(121, 17)
        Me._Chk_1.TabIndex = 2
        Me._Chk_1.Tag = "Cash book"
        Me._Chk_1.Text = "Sổ quỹ"
        Me._Chk_1.UseVisualStyleBackColor = False
        '
        '_Chk_0
        '
        Me._Chk_0.BackColor = System.Drawing.Color.Transparent
        Me._Chk_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_0.Location = New System.Drawing.Point(8, 8)
        Me._Chk_0.Name = "_Chk_0"
        Me._Chk_0.Size = New System.Drawing.Size(121, 17)
        Me._Chk_0.TabIndex = 0
        Me._Chk_0.Tag = "Journal Ledger"
        Me._Chk_0.Text = "Nhật ký chung"
        Me._Chk_0.UseVisualStyleBackColor = False
        '
        '_Command_0
        '
        Me._Command_0.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(192, 152)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(86, 25)
        Me._Command_0.TabIndex = 13
        Me._Command_0.Tag = "Return"
        Me._Command_0.Text = "Trở &về"
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Xu_ly
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(40, 152)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(89, 25)
        Me._Command_1.TabIndex = 12
        Me._Command_1.Tag = "Apply"
        Me._Command_1.Text = "&Thực hiện"
        '
        'FrmIntoanboso
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(321, 185)
        Me.Controls.Add(Me._Chk_9)
        Me.Controls.Add(Me._Chk_8)
        Me.Controls.Add(Me.GauGe)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me._Chk_7)
        Me.Controls.Add(Me._Chk_6)
        Me.Controls.Add(Me._Chk_5)
        Me.Controls.Add(Me._Chk_4)
        Me.Controls.Add(Me._Chk_3)
        Me.Controls.Add(Me._Chk_2)
        Me.Controls.Add(Me._Chk_1)
        Me.Controls.Add(Me._Chk_0)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command_1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmIntoanboso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Print all accounting"
        Me.Text = "In toàn bộ sổ kế toán"
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
	Sub InitializeOpt()
		Me.Opt(1) = _Opt_1
		Me.Opt(0) = _Opt_0
	End Sub
	Sub InitializeCommand()
		Me.Command(0) = _Command_0
		Me.Command(1) = _Command_1
	End Sub
	Sub InitializeChk()
		Me.Chk(9) = _Chk_9
		Me.Chk(8) = _Chk_8
		Me.Chk(7) = _Chk_7
		Me.Chk(6) = _Chk_6
		Me.Chk(5) = _Chk_5
		Me.Chk(4) = _Chk_4
		Me.Chk(3) = _Chk_3
		Me.Chk(2) = _Chk_2
		Me.Chk(1) = _Chk_1
		Me.Chk(0) = _Chk_0
	End Sub
#End Region 
End Class
