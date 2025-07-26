<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhauHao
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
        isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		InitializeOption_Renamed()
		InitializeLine1()
		InitializeLabel()
		InitializeFrame()
		InitializeCommand1()
		InitializeCommand()
		InitializeCboThang()
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
	Private WithEvents _CboThang_0 As ComboBoxEx.ComboBoxExt
	Private WithEvents _CboThang_1 As ComboBoxEx.ComboBoxExt
	Private WithEvents _Label_0 As System.Windows.Forms.Label
	Private WithEvents _Label_1 As System.Windows.Forms.Label
	Private WithEvents _Frame_0 As System.Windows.Forms.GroupBox
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Option_3 As System.Windows.Forms.RadioButton
    Public WithEvents txt As System.Windows.Forms.TextBox
    Public WithEvents Gauge As System.Windows.Forms.ProgressBar
    Private WithEvents _Option_2 As System.Windows.Forms.RadioButton
    Private WithEvents _Option_1 As System.Windows.Forms.RadioButton
    Private WithEvents _Option_0 As System.Windows.Forms.RadioButton
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Line1_3 As System.Windows.Forms.Label
    Private WithEvents _Line1_2 As System.Windows.Forms.Label
    Private WithEvents _Line1_1 As System.Windows.Forms.Label
    Private WithEvents _Line1_0 As System.Windows.Forms.Label
    Public CboThang(1) As ComboBoxEx.ComboBoxExt
    Public Command(1) As System.Windows.Forms.Button
    Public Command1(1) As System.Windows.Forms.Button
    Public Frame(0) As System.Windows.Forms.GroupBox
    Public Label(2) As System.Windows.Forms.Label
    Public Line1(3) As System.Windows.Forms.Label
    Public Option_Renamed(3) As System.Windows.Forms.RadioButton
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKhauHao))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Frame_0 = New System.Windows.Forms.GroupBox
        Me._CboThang_0 = New ComboBoxEx.ComboBoxExt
        Me._CboThang_1 = New ComboBoxEx.ComboBoxExt
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Option_3 = New System.Windows.Forms.RadioButton
        Me.txt = New System.Windows.Forms.TextBox
        Me.Gauge = New System.Windows.Forms.ProgressBar
        Me._Option_2 = New System.Windows.Forms.RadioButton
        Me._Option_1 = New System.Windows.Forms.RadioButton
        Me._Option_0 = New System.Windows.Forms.RadioButton
        Me._Command1_1 = New System.Windows.Forms.Button
        Me._Command1_0 = New System.Windows.Forms.Button
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Line1_3 = New System.Windows.Forms.Label
        Me._Line1_2 = New System.Windows.Forms.Label
        Me._Line1_1 = New System.Windows.Forms.Label
        Me._Line1_0 = New System.Windows.Forms.Label
        Me._Frame_0.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Frame_0
        '
        Me._Frame_0.BackColor = System.Drawing.Color.Transparent
        Me._Frame_0.Controls.Add(Me._CboThang_0)
        Me._Frame_0.Controls.Add(Me._CboThang_1)
        Me._Frame_0.Controls.Add(Me._Label_0)
        Me._Frame_0.Controls.Add(Me._Label_1)
        Me._Frame_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_0.Location = New System.Drawing.Point(240, 0)
        Me._Frame_0.Name = "_Frame_0"
        Me._Frame_0.Size = New System.Drawing.Size(73, 97)
        Me._Frame_0.TabIndex = 11
        Me._Frame_0.TabStop = False
        '
        '_CboThang_0
        '
        Me._CboThang_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_0.Location = New System.Drawing.Point(0, 24)
        Me._CboThang_0.Name = "_CboThang_0"
        Me._CboThang_0.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_0.TabIndex = 13
        '
        '_CboThang_1
        '
        Me._CboThang_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_1.Location = New System.Drawing.Point(0, 64)
        Me._CboThang_1.Name = "_CboThang_1"
        Me._CboThang_1.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_1.TabIndex = 12
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(8, 8)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(58, 17)
        Me._Label_0.TabIndex = 15
        Me._Label_0.Tag = "FROM"
        Me._Label_0.Text = "Từ tháng"
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(8, 48)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(58, 17)
        Me._Label_1.TabIndex = 14
        Me._Label_1.Tag = "to"
        Me._Label_1.Text = "Đến tháng"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(240, 160)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 10
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(240, 128)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 9
        Me._Command_0.Tag = "Save"
        Me._Command_0.Text = "&Ghi"
        '
        '_Option_3
        '
        Me._Option_3.BackColor = System.Drawing.Color.Transparent
        Me._Option_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Option_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Option_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Option_3.Location = New System.Drawing.Point(24, 120)
        Me._Option_3.Name = "_Option_3"
        Me._Option_3.Size = New System.Drawing.Size(169, 17)
        Me._Option_3.TabIndex = 8
        Me._Option_3.TabStop = True
        Me._Option_3.Tag = "Fixed Asset FROM Finacial Credit"
        Me._Option_3.Text = "Bất động sản đầu tư"
        Me._Option_3.UseVisualStyleBackColor = False
        '
        'txt
        '
        Me.txt.AcceptsReturn = True
        Me.txt.BackColor = System.Drawing.SystemColors.Window
        Me.txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.Location = New System.Drawing.Point(152, 152)
        Me.txt.MaxLength = 0
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(65, 20)
        Me.txt.TabIndex = 3
        '
        'Gauge
        '
        Me.Gauge.Location = New System.Drawing.Point(240, 104)
        Me.Gauge.Name = "Gauge"
        Me.Gauge.Size = New System.Drawing.Size(73, 17)
        Me.Gauge.TabIndex = 6
        '
        '_Option_2
        '
        Me._Option_2.BackColor = System.Drawing.Color.Transparent
        Me._Option_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Option_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Option_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Option_2.Location = New System.Drawing.Point(24, 88)
        Me._Option_2.Name = "_Option_2"
        Me._Option_2.Size = New System.Drawing.Size(169, 17)
        Me._Option_2.TabIndex = 2
        Me._Option_2.TabStop = True
        Me._Option_2.Tag = "Fixed Asset FROM Finacial Credit"
        Me._Option_2.Text = "Tài sản cố định thuê tài chính"
        Me._Option_2.UseVisualStyleBackColor = False
        '
        '_Option_1
        '
        Me._Option_1.BackColor = System.Drawing.Color.Transparent
        Me._Option_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Option_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Option_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Option_1.Location = New System.Drawing.Point(24, 56)
        Me._Option_1.Name = "_Option_1"
        Me._Option_1.Size = New System.Drawing.Size(169, 17)
        Me._Option_1.TabIndex = 1
        Me._Option_1.TabStop = True
        Me._Option_1.Tag = "Intangible Fixed Asset"
        Me._Option_1.Text = "Tài sản cố định vô hình"
        Me._Option_1.UseVisualStyleBackColor = False
        '
        '_Option_0
        '
        Me._Option_0.BackColor = System.Drawing.Color.Transparent
        Me._Option_0.Checked = True
        Me._Option_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Option_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Option_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Option_0.Location = New System.Drawing.Point(24, 24)
        Me._Option_0.Name = "_Option_0"
        Me._Option_0.Size = New System.Drawing.Size(169, 17)
        Me._Option_0.TabIndex = 0
        Me._Option_0.TabStop = True
        Me._Option_0.Tag = "Fixed Asset"
        Me._Option_0.Text = "Tài sản cố định hữu hình"
        Me._Option_0.UseVisualStyleBackColor = False
        '
        '_Command1_1
        '
        Me._Command1_1.BackColor = System.Drawing.Color.Silver
        Me._Command1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_1.Image = CType(resources.GetObject("_Command1_1.Image"), System.Drawing.Image)
        Me._Command1_1.Location = New System.Drawing.Point(240, 160)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(73, 25)
        Me._Command1_1.TabIndex = 5
        Me._Command1_1.Tag = "&Return"
        Me._Command1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_1.UseVisualStyleBackColor = False
        '
        '_Command1_0
        '
        Me._Command1_0.BackColor = System.Drawing.Color.Silver
        Me._Command1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_0.Image = CType(resources.GetObject("_Command1_0.Image"), System.Drawing.Image)
        Me._Command1_0.Location = New System.Drawing.Point(240, 128)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(73, 25)
        Me._Command1_0.TabIndex = 4
        Me._Command1_0.Tag = "&Save"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.Transparent
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(41, 155)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(105, 17)
        Me._Label_2.TabIndex = 7
        Me._Label_2.Tag = "By Expense Account"
        Me._Label_2.Text = "Trích theo TK chi phí"
        '
        '_Line1_3
        '
        Me._Line1_3.BackColor = System.Drawing.SystemColors.Window
        Me._Line1_3.Enabled = False
        Me._Line1_3.Location = New System.Drawing.Point(232, 8)
        Me._Line1_3.Name = "_Line1_3"
        Me._Line1_3.Size = New System.Drawing.Size(1, 176)
        Me._Line1_3.TabIndex = 12
        '
        '_Line1_2
        '
        Me._Line1_2.Enabled = False
        Me._Line1_2.Location = New System.Drawing.Point(8, 8)
        Me._Line1_2.Name = "_Line1_2"
        Me._Line1_2.Size = New System.Drawing.Size(1, 176)
        Me._Line1_2.TabIndex = 13
        '
        '_Line1_1
        '
        Me._Line1_1.BackColor = System.Drawing.SystemColors.Window
        Me._Line1_1.Enabled = False
        Me._Line1_1.Location = New System.Drawing.Point(8, 184)
        Me._Line1_1.Name = "_Line1_1"
        Me._Line1_1.Size = New System.Drawing.Size(224, 1)
        Me._Line1_1.TabIndex = 14
        '
        '_Line1_0
        '
        Me._Line1_0.Enabled = False
        Me._Line1_0.Location = New System.Drawing.Point(8, 8)
        Me._Line1_0.Name = "_Line1_0"
        Me._Line1_0.Size = New System.Drawing.Size(224, 1)
        Me._Line1_0.TabIndex = 15
        '
        'frmKhauHao
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(321, 193)
        Me.Controls.Add(Me._Frame_0)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Option_3)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.Gauge)
        Me.Controls.Add(Me._Option_2)
        Me.Controls.Add(Me._Option_1)
        Me.Controls.Add(Me._Option_0)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Line1_3)
        Me.Controls.Add(Me._Line1_2)
        Me.Controls.Add(Me._Line1_1)
        Me.Controls.Add(Me._Line1_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(161, 175)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKhauHao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Depreciation"
        Me.Text = "Ghi chứng từ trích khấu hao"
        Me._Frame_0.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializeOption_Renamed()
		Me.Option_Renamed(3) = _Option_3
		Me.Option_Renamed(2) = _Option_2
		Me.Option_Renamed(1) = _Option_1
		Me.Option_Renamed(0) = _Option_0
	End Sub
	Sub InitializeLine1()
		Me.Line1(3) = _Line1_3
		Me.Line1(2) = _Line1_2
		Me.Line1(1) = _Line1_1
		Me.Line1(0) = _Line1_0
	End Sub
	Sub InitializeLabel()
		Me.Label(0) = _Label_0
		Me.Label(1) = _Label_1
		Me.Label(2) = _Label_2
	End Sub
	Sub InitializeFrame()
		Me.Frame(0) = _Frame_0
	End Sub
	Sub InitializeCommand1()
		Me.Command1(1) = _Command1_1
		Me.Command1(0) = _Command1_0
	End Sub
	Sub InitializeCommand()
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
	Sub InitializeCboThang()
		Me.CboThang(0) = _CboThang_0
		Me.CboThang(1) = _CboThang_1
	End Sub
#End Region 
End Class
