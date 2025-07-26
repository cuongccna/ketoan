<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmXuly
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
        InitializeTxt()
        InitializeLab()
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
    Public WithEvents _Txt_0 As System.Windows.Forms.TextBox
    Private WithEvents _Opt_1 As System.Windows.Forms.RadioButton
    Public WithEvents Label As System.Windows.Forms.Label
    Public Lab(1) As System.Windows.Forms.Label
    Public Command(1) As System.Windows.Forms.Button
    Public Txt(2) As System.Windows.Forms.TextBox
    Public Opt(3) As System.Windows.Forms.RadioButton
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me._Opt_2 = New System.Windows.Forms.RadioButton()
        Me._Txt_0 = New System.Windows.Forms.TextBox()
        Me._Opt_1 = New System.Windows.Forms.RadioButton()
        Me.Label = New System.Windows.Forms.Label()
        Me._Opt_0 = New System.Windows.Forms.RadioButton()
        Me._Txt_1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._LabelTen_0 = New System.Windows.Forms.Label()
        Me._LabelTen_1 = New System.Windows.Forms.Label()
        Me._Opt_3 = New System.Windows.Forms.RadioButton()
        Me._Txt_2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(394, 102)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(89, 25)
        Me._Command_1.TabIndex = 8
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        '
        '_Command_0
        '
        Me._Command_0.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Xu_ly
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(298, 102)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(89, 25)
        Me._Command_0.TabIndex = 7
        Me._Command_0.Tag = "Apply"
        Me._Command_0.Text = "&Thực hiện"
        '
        '_Opt_2
        '
        Me._Opt_2.BackColor = System.Drawing.Color.Transparent
        Me._Opt_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_2.Location = New System.Drawing.Point(8, 53)
        Me._Opt_2.Name = "_Opt_2"
        Me._Opt_2.Size = New System.Drawing.Size(110, 17)
        Me._Opt_2.TabIndex = 2
        Me._Opt_2.TabStop = True
        Me._Opt_2.Tag = "Change Account"
        Me._Opt_2.Text = "Đổi tài khoản"
        Me._Opt_2.UseVisualStyleBackColor = False
        '
        '_Txt_0
        '
        Me._Txt_0.AcceptsReturn = True
        Me._Txt_0.BackColor = System.Drawing.SystemColors.Window
        Me._Txt_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_0.Location = New System.Drawing.Point(158, 28)
        Me._Txt_0.MaxLength = 100
        Me._Txt_0.Name = "_Txt_0"
        Me._Txt_0.Size = New System.Drawing.Size(110, 20)
        Me._Txt_0.TabIndex = 4
        Me._Txt_0.Tag = "0"
        '
        '_Opt_1
        '
        Me._Opt_1.BackColor = System.Drawing.Color.Transparent
        Me._Opt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_1.Location = New System.Drawing.Point(8, 30)
        Me._Opt_1.Name = "_Opt_1"
        Me._Opt_1.Size = New System.Drawing.Size(91, 17)
        Me._Opt_1.TabIndex = 1
        Me._Opt_1.TabStop = True
        Me._Opt_1.Tag = "Change Material"
        Me._Opt_1.Text = "Đổi vật tư"
        Me._Opt_1.UseVisualStyleBackColor = False
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.Color.Transparent
        Me.Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label.Location = New System.Drawing.Point(158, 9)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(110, 17)
        Me.Label.TabIndex = 4
        Me.Label.Tag = "Customer code"
        Me.Label.Text = "Mã khách hàng"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me._Opt_0.Size = New System.Drawing.Size(119, 17)
        Me._Opt_0.TabIndex = 0
        Me._Opt_0.TabStop = True
        Me._Opt_0.Tag = "Change Customer"
        Me._Opt_0.Text = "Đổi khách hàng"
        Me._Opt_0.UseVisualStyleBackColor = False
        '
        '_Txt_1
        '
        Me._Txt_1.AcceptsReturn = True
        Me._Txt_1.BackColor = System.Drawing.SystemColors.Window
        Me._Txt_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_1.Location = New System.Drawing.Point(344, 28)
        Me._Txt_1.MaxLength = 100
        Me._Txt_1.Name = "_Txt_1"
        Me._Txt_1.Size = New System.Drawing.Size(110, 20)
        Me._Txt_1.TabIndex = 5
        Me._Txt_1.Tag = "0"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(344, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Tag = "Customer code"
        Me.Label1.Text = "Mã khách hàng"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(118, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Tag = "From                                                  to"
        Me.Label2.Text = "Từ                                                    sang"
        '
        '_LabelTen_0
        '
        Me._LabelTen_0.BackColor = System.Drawing.Color.Transparent
        Me._LabelTen_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LabelTen_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LabelTen_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LabelTen_0.Location = New System.Drawing.Point(124, 54)
        Me._LabelTen_0.Name = "_LabelTen_0"
        Me._LabelTen_0.Size = New System.Drawing.Size(175, 17)
        Me._LabelTen_0.TabIndex = 10
        Me._LabelTen_0.Tag = ""
        Me._LabelTen_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_LabelTen_1
        '
        Me._LabelTen_1.BackColor = System.Drawing.Color.Transparent
        Me._LabelTen_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LabelTen_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LabelTen_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LabelTen_1.Location = New System.Drawing.Point(308, 54)
        Me._LabelTen_1.Name = "_LabelTen_1"
        Me._LabelTen_1.Size = New System.Drawing.Size(175, 17)
        Me._LabelTen_1.TabIndex = 11
        Me._LabelTen_1.Tag = ""
        Me._LabelTen_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_Opt_3
        '
        Me._Opt_3.BackColor = System.Drawing.Color.Transparent
        Me._Opt_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Opt_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_3.Location = New System.Drawing.Point(8, 76)
        Me._Opt_3.Name = "_Opt_3"
        Me._Opt_3.Size = New System.Drawing.Size(110, 17)
        Me._Opt_3.TabIndex = 3
        Me._Opt_3.TabStop = True
        Me._Opt_3.Tag = "Change Account"
        Me._Opt_3.Text = "Đổi bằng lệnh"
        Me._Opt_3.UseVisualStyleBackColor = False
        '
        '_Txt_2
        '
        Me._Txt_2.AcceptsReturn = True
        Me._Txt_2.BackColor = System.Drawing.SystemColors.Window
        Me._Txt_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_2.Enabled = False
        Me._Txt_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_2.Location = New System.Drawing.Point(124, 76)
        Me._Txt_2.MaxLength = 100
        Me._Txt_2.Name = "_Txt_2"
        Me._Txt_2.Size = New System.Drawing.Size(359, 20)
        Me._Txt_2.TabIndex = 6
        '
        'FrmXuly
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(495, 139)
        Me.Controls.Add(Me._Txt_2)
        Me.Controls.Add(Me._Opt_3)
        Me.Controls.Add(Me._LabelTen_1)
        Me.Controls.Add(Me._LabelTen_0)
        Me.Controls.Add(Me._Txt_1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Opt_2)
        Me.Controls.Add(Me._Txt_0)
        Me.Controls.Add(Me._Opt_1)
        Me.Controls.Add(Me._Opt_0)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmXuly"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Operation"
        Me.Text = "Các thao tác xử lý (Các thao tác này thực hiện trên toàn bộ dữ liệu)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Sub InitializeOpt()
        Me.Opt(3) = _Opt_3
        Me.Opt(2) = _Opt_2
        Me.Opt(1) = _Opt_1
        Me.Opt(0) = _Opt_0
    End Sub
    Sub InitializeCommand()
        Me.Command(1) = _Command_1
        Me.Command(0) = _Command_0
    End Sub
    Sub InitializeTxt()
        Me.Txt(2) = _Txt_2
        Me.Txt(1) = _Txt_1
        Me.Txt(0) = _Txt_0
    End Sub
    Sub InitializeLab()
        Me.Lab(1) = _LabelTen_1
        Me.Lab(0) = _LabelTen_0
    End Sub
    Private WithEvents _Opt_0 As System.Windows.Forms.RadioButton
    Public WithEvents _Txt_1 As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents _LabelTen_0 As System.Windows.Forms.Label
    Public WithEvents _LabelTen_1 As System.Windows.Forms.Label
    Private WithEvents _Opt_3 As System.Windows.Forms.RadioButton
    Public WithEvents _Txt_2 As System.Windows.Forms.TextBox
#End Region
End Class
