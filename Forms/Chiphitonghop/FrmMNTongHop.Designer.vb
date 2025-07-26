<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMNTongHop
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeCmd1()
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
    Private WithEvents _Cmd1_8 As System.Windows.Forms.Button
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Private WithEvents _Cmd1_0 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_1 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_2 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_3 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_12 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_4 As System.Windows.Forms.Button
    Public Cmd1(12) As System.Windows.Forms.Button
    Public Line1(5) As System.Windows.Forms.Label
    Public Line7(3) As System.Windows.Forms.Label
    Public Line8(6) As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMNTongHop))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me._Cmd1_8 = New System.Windows.Forms.Button()
        Me._Cmd1_0 = New System.Windows.Forms.Button()
        Me._Cmd1_1 = New System.Windows.Forms.Button()
        Me._Cmd1_3 = New System.Windows.Forms.Button()
        Me._Cmd1_12 = New System.Windows.Forms.Button()
        Me._Cmd1_2 = New System.Windows.Forms.Button()
        Me._Cmd1_4 = New System.Windows.Forms.Button()
        Me._Cmd1_7 = New System.Windows.Forms.Button()
        Me._Cmd1_5 = New System.Windows.Forms.Button()
        Me._Cmd1_6 = New System.Windows.Forms.Button()
        Me.LabelControl1 = New System.Windows.Forms.Label()
        Me.LabelControl2 = New System.Windows.Forms.Label()
        Me.LabelControl3 = New System.Windows.Forms.Label()
        Me.LabelControl4 = New System.Windows.Forms.Label()
        Me.LabelControl5 = New System.Windows.Forms.Label()
        Me.LabelControl6 = New System.Windows.Forms.Label()
        Me.LabelControl7 = New System.Windows.Forms.Label()
        Me.LabelControl8 = New System.Windows.Forms.Label()
        Me.LabelControl12 = New System.Windows.Forms.Label()
        Me.Frame3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.Transparent
        Me.Frame3.Controls.Add(Me._Cmd1_8)
        Me.Frame3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.Color.Blue
        Me.Frame3.Location = New System.Drawing.Point(22, 360)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Size = New System.Drawing.Size(266, 111)
        Me.Frame3.TabIndex = 13
        Me.Frame3.TabStop = False
        Me.Frame3.Tag = ""
        Me.Frame3.Visible = False
        '
        '_Cmd1_8
        '
        Me._Cmd1_8.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_8.FlatAppearance.BorderSize = 0
        Me._Cmd1_8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cmd1_8.ForeColor = System.Drawing.Color.Blue
        Me._Cmd1_8.Image = CType(resources.GetObject("_Cmd1_8.Image"), System.Drawing.Image)
        Me._Cmd1_8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_8.Location = New System.Drawing.Point(14, 13)
        Me._Cmd1_8.Name = "_Cmd1_8"
        Me._Cmd1_8.Size = New System.Drawing.Size(215, 90)
        Me._Cmd1_8.TabIndex = 5
        Me._Cmd1_8.Tag = "Input records with old  interface"
        Me._Cmd1_8.Text = "Nhập chi phí tổng hợp"
        Me._Cmd1_8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_8.UseVisualStyleBackColor = False
        '
        '_Cmd1_0
        '
        Me._Cmd1_0.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_0.FlatAppearance.BorderSize = 0
        Me._Cmd1_0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_0.Image = CType(resources.GetObject("_Cmd1_0.Image"), System.Drawing.Image)
        Me._Cmd1_0.Location = New System.Drawing.Point(647, 267)
        Me._Cmd1_0.Name = "_Cmd1_0"
        Me._Cmd1_0.Size = New System.Drawing.Size(131, 39)
        Me._Cmd1_0.TabIndex = 1
        Me._Cmd1_0.Tag = ""
        Me._Cmd1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_0.UseVisualStyleBackColor = False
        '
        '_Cmd1_1
        '
        Me._Cmd1_1.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_1.FlatAppearance.BorderSize = 0
        Me._Cmd1_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_1.Image = CType(resources.GetObject("_Cmd1_1.Image"), System.Drawing.Image)
        Me._Cmd1_1.Location = New System.Drawing.Point(217, 66)
        Me._Cmd1_1.Name = "_Cmd1_1"
        Me._Cmd1_1.Size = New System.Drawing.Size(127, 41)
        Me._Cmd1_1.TabIndex = 2
        Me._Cmd1_1.Tag = ""
        Me._Cmd1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_1.UseVisualStyleBackColor = False
        '
        '_Cmd1_3
        '
        Me._Cmd1_3.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_3.FlatAppearance.BorderSize = 0
        Me._Cmd1_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_3.Image = CType(resources.GetObject("_Cmd1_3.Image"), System.Drawing.Image)
        Me._Cmd1_3.Location = New System.Drawing.Point(398, 156)
        Me._Cmd1_3.Name = "_Cmd1_3"
        Me._Cmd1_3.Size = New System.Drawing.Size(133, 44)
        Me._Cmd1_3.TabIndex = 3
        Me._Cmd1_3.Tag = ""
        Me._Cmd1_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_3.UseVisualStyleBackColor = False
        '
        '_Cmd1_12
        '
        Me._Cmd1_12.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_12.FlatAppearance.BorderSize = 0
        Me._Cmd1_12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_12.Image = CType(resources.GetObject("_Cmd1_12.Image"), System.Drawing.Image)
        Me._Cmd1_12.Location = New System.Drawing.Point(587, 65)
        Me._Cmd1_12.Name = "_Cmd1_12"
        Me._Cmd1_12.Size = New System.Drawing.Size(131, 41)
        Me._Cmd1_12.TabIndex = 4
        Me._Cmd1_12.Tag = ""
        Me._Cmd1_12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_12.UseVisualStyleBackColor = False
        '
        '_Cmd1_2
        '
        Me._Cmd1_2.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_2.FlatAppearance.BorderSize = 0
        Me._Cmd1_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_2.Image = CType(resources.GetObject("_Cmd1_2.Image"), System.Drawing.Image)
        Me._Cmd1_2.Location = New System.Drawing.Point(31, 156)
        Me._Cmd1_2.Name = "_Cmd1_2"
        Me._Cmd1_2.Size = New System.Drawing.Size(132, 41)
        Me._Cmd1_2.TabIndex = 0
        Me._Cmd1_2.Tag = ""
        Me._Cmd1_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_2.UseVisualStyleBackColor = False
        '
        '_Cmd1_4
        '
        Me._Cmd1_4.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_4.FlatAppearance.BorderSize = 0
        Me._Cmd1_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cmd1_4.ForeColor = System.Drawing.Color.Blue
        Me._Cmd1_4.Image = CType(resources.GetObject("_Cmd1_4.Image"), System.Drawing.Image)
        Me._Cmd1_4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_4.Location = New System.Drawing.Point(745, 379)
        Me._Cmd1_4.Name = "_Cmd1_4"
        Me._Cmd1_4.Size = New System.Drawing.Size(124, 84)
        Me._Cmd1_4.TabIndex = 10
        Me._Cmd1_4.Tag = "Return"
        Me._Cmd1_4.Text = "Trở &về"
        Me._Cmd1_4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_4.UseVisualStyleBackColor = False
        '
        '_Cmd1_7
        '
        Me._Cmd1_7.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_7.FlatAppearance.BorderSize = 0
        Me._Cmd1_7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_7.Image = CType(resources.GetObject("_Cmd1_7.Image"), System.Drawing.Image)
        Me._Cmd1_7.Location = New System.Drawing.Point(739, 159)
        Me._Cmd1_7.Name = "_Cmd1_7"
        Me._Cmd1_7.Size = New System.Drawing.Size(133, 43)
        Me._Cmd1_7.TabIndex = 14
        Me._Cmd1_7.Tag = ""
        Me._Cmd1_7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_7.UseVisualStyleBackColor = False
        '
        '_Cmd1_5
        '
        Me._Cmd1_5.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_5.FlatAppearance.BorderSize = 0
        Me._Cmd1_5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_5.Image = CType(resources.GetObject("_Cmd1_5.Image"), System.Drawing.Image)
        Me._Cmd1_5.Location = New System.Drawing.Point(146, 267)
        Me._Cmd1_5.Name = "_Cmd1_5"
        Me._Cmd1_5.Size = New System.Drawing.Size(132, 40)
        Me._Cmd1_5.TabIndex = 15
        Me._Cmd1_5.Tag = ""
        Me._Cmd1_5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_5.UseVisualStyleBackColor = False
        '
        '_Cmd1_6
        '
        Me._Cmd1_6.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_6.FlatAppearance.BorderSize = 0
        Me._Cmd1_6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_6.Image = CType(resources.GetObject("_Cmd1_6.Image"), System.Drawing.Image)
        Me._Cmd1_6.Location = New System.Drawing.Point(398, 281)
        Me._Cmd1_6.Name = "_Cmd1_6"
        Me._Cmd1_6.Size = New System.Drawing.Size(133, 42)
        Me._Cmd1_6.TabIndex = 16
        Me._Cmd1_6.Tag = ""
        Me._Cmd1_6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_6.UseVisualStyleBackColor = False
        '
        'LabelControl1
        '
        Me.LabelControl1.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl1.Location = New System.Drawing.Point(33, 200)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(130, 13)
        Me.LabelControl1.TabIndex = 92
        Me.LabelControl1.Tag = "Operating costs"
        Me.LabelControl1.Text = "Chi phí hoạt động"
        Me.LabelControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl2
        '
        Me.LabelControl2.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl2.Location = New System.Drawing.Point(214, 110)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(130, 16)
        Me.LabelControl2.TabIndex = 93
        Me.LabelControl2.Tag = "Cash Voucher List"
        Me.LabelControl2.Text = "Lập phiếu thu chi"
        Me.LabelControl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl3
        '
        Me.LabelControl3.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl3.Location = New System.Drawing.Point(584, 106)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(134, 20)
        Me.LabelControl3.TabIndex = 94
        Me.LabelControl3.Tag = "Recalculate f-currency"
        Me.LabelControl3.Text = "Tính lại giá xuất ngoại tệ"
        Me.LabelControl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl4
        '
        Me.LabelControl4.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl4.Location = New System.Drawing.Point(644, 309)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(134, 20)
        Me.LabelControl4.TabIndex = 95
        Me.LabelControl4.Tag = "Voucher List"
        Me.LabelControl4.Text = "Tra cứu chứng từ"
        Me.LabelControl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl5
        '
        Me.LabelControl5.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl5.Location = New System.Drawing.Point(147, 310)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(131, 19)
        Me.LabelControl5.TabIndex = 96
        Me.LabelControl5.Tag = "Taxes, charges and fees"
        Me.LabelControl5.Text = "Thuế, phí và lệ phí"
        Me.LabelControl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl6
        '
        Me.LabelControl6.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl6.Location = New System.Drawing.Point(396, 326)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(135, 19)
        Me.LabelControl6.TabIndex = 97
        Me.LabelControl6.Tag = "Bank account"
        Me.LabelControl6.Text = "Tài khoản ngân hàng"
        Me.LabelControl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl7
        '
        Me.LabelControl7.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl7.Location = New System.Drawing.Point(736, 205)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(136, 19)
        Me.LabelControl7.TabIndex = 98
        Me.LabelControl7.Tag = "Other costs"
        Me.LabelControl7.Text = "Thu chi khác"
        Me.LabelControl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl8
        '
        Me.LabelControl8.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl8.Location = New System.Drawing.Point(399, 203)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(132, 21)
        Me.LabelControl8.TabIndex = 99
        Me.LabelControl8.Tag = "Reports"
        Me.LabelControl8.Text = "Sổ sách báo cáo"
        Me.LabelControl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl12
        '
        Me.LabelControl12.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl12.Location = New System.Drawing.Point(290, 9)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(335, 32)
        Me.LabelControl12.TabIndex = 110
        Me.LabelControl12.Tag = "COMMON"
        Me.LabelControl12.Text = "CHI PHÍ TỔNG HỢP"
        Me.LabelControl12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmMNTongHop
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(908, 483)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me._Cmd1_6)
        Me.Controls.Add(Me._Cmd1_5)
        Me.Controls.Add(Me._Cmd1_7)
        Me.Controls.Add(Me._Cmd1_12)
        Me.Controls.Add(Me._Cmd1_3)
        Me.Controls.Add(Me._Cmd1_0)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me._Cmd1_1)
        Me.Controls.Add(Me._Cmd1_2)
        Me.Controls.Add(Me._Cmd1_4)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMNTongHop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Common"
        Me.Text = "Chi phí tổng hợp"
        Me.Frame3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Sub InitializeCmd1()
        Me.Cmd1(8) = _Cmd1_8
        Me.Cmd1(0) = _Cmd1_0
        Me.Cmd1(1) = _Cmd1_1
        Me.Cmd1(2) = _Cmd1_2
        Me.Cmd1(3) = _Cmd1_3
        Me.Cmd1(12) = _Cmd1_12
        Me.Cmd1(4) = _Cmd1_4
        Me.Cmd1(5) = _Cmd1_5
        Me.Cmd1(6) = _Cmd1_6
        Me.Cmd1(7) = _Cmd1_7
    End Sub
    Private WithEvents _Cmd1_7 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_5 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_6 As System.Windows.Forms.Button
    Friend WithEvents LabelControl1 As System.Windows.Forms.Label
    Friend WithEvents LabelControl2 As System.Windows.Forms.Label
    Friend WithEvents LabelControl3 As System.Windows.Forms.Label
    Friend WithEvents LabelControl4 As System.Windows.Forms.Label
    Friend WithEvents LabelControl5 As System.Windows.Forms.Label
    Friend WithEvents LabelControl6 As System.Windows.Forms.Label
    Friend WithEvents LabelControl7 As System.Windows.Forms.Label
    Friend WithEvents LabelControl8 As System.Windows.Forms.Label
    Friend WithEvents LabelControl12 As System.Windows.Forms.Label
#End Region 
End Class
