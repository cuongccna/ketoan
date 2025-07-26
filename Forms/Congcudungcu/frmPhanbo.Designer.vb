<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhanbo
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
		InitializeCommand1()
		InitializeCommand()
		InitializeCombo()
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
    Private WithEvents _Combo_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Option_1 As System.Windows.Forms.RadioButton
    Private WithEvents _Option_0 As System.Windows.Forms.RadioButton
    Public WithEvents Gauge As System.Windows.Forms.ProgressBar
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Line1_3 As System.Windows.Forms.Label
    Private WithEvents _Line1_2 As System.Windows.Forms.Label
    Private WithEvents _Line1_1 As System.Windows.Forms.Label
    Private WithEvents _Line1_0 As System.Windows.Forms.Label
    Public Combo(1) As ComboBoxEx.ComboBoxExt
    Public Command(1) As System.Windows.Forms.Button
    Public Command1(1) As System.Windows.Forms.Button
    Public Label(1) As System.Windows.Forms.Label
    Public Line1(3) As System.Windows.Forms.Label
    Public Option_Renamed(1) As System.Windows.Forms.RadioButton
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhanbo))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Combo_0 = New ComboBoxEx.ComboBoxExt
        Me._Command1_0 = New System.Windows.Forms.Button
        Me._Command1_1 = New System.Windows.Forms.Button
        Me._Combo_1 = New ComboBoxEx.ComboBoxExt
        Me._Option_1 = New System.Windows.Forms.RadioButton
        Me._Option_0 = New System.Windows.Forms.RadioButton
        Me.Gauge = New System.Windows.Forms.ProgressBar
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Line1_3 = New System.Windows.Forms.Label
        Me._Line1_2 = New System.Windows.Forms.Label
        Me._Line1_1 = New System.Windows.Forms.Label
        Me._Line1_0 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(160, 152)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(81, 25)
        Me._Command_1.TabIndex = 9
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(48, 152)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(81, 25)
        Me._Command_0.TabIndex = 10
        Me._Command_0.Tag = "Save"
        Me._Command_0.Text = "&Ghi"
        '
        '_Combo_0
        '
        Me._Combo_0.BackColor = System.Drawing.SystemColors.Window
        Me._Combo_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_0.Location = New System.Drawing.Point(64, 96)
        Me._Combo_0.Name = "_Combo_0"
        Me._Combo_0.Size = New System.Drawing.Size(73, 21)
        Me._Combo_0.TabIndex = 2
        '
        '_Command1_0
        '
        Me._Command1_0.BackColor = System.Drawing.Color.Silver
        Me._Command1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_0.Image = CType(resources.GetObject("_Command1_0.Image"), System.Drawing.Image)
        Me._Command1_0.Location = New System.Drawing.Point(48, 152)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(81, 25)
        Me._Command1_0.TabIndex = 4
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
        Me._Command1_1.Location = New System.Drawing.Point(160, 152)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(81, 25)
        Me._Command1_1.TabIndex = 5
        Me._Command1_1.TabStop = False
        Me._Command1_1.Tag = "&Return"
        Me._Command1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_1.UseVisualStyleBackColor = False
        Me._Command1_1.Visible = False
        '
        '_Combo_1
        '
        Me._Combo_1.BackColor = System.Drawing.SystemColors.Window
        Me._Combo_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_1.Location = New System.Drawing.Point(208, 96)
        Me._Combo_1.Name = "_Combo_1"
        Me._Combo_1.Size = New System.Drawing.Size(73, 21)
        Me._Combo_1.TabIndex = 3
        '
        '_Option_1
        '
        Me._Option_1.BackColor = System.Drawing.Color.Transparent
        Me._Option_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Option_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Option_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Option_1.Location = New System.Drawing.Point(16, 56)
        Me._Option_1.Name = "_Option_1"
        Me._Option_1.Size = New System.Drawing.Size(253, 17)
        Me._Option_1.TabIndex = 1
        Me._Option_1.TabStop = True
        Me._Option_1.Tag = "Distribution of long-term preaid expenses"
        Me._Option_1.Text = "Phân bổ công cụ dụng cụ dài hạn"
        Me._Option_1.UseVisualStyleBackColor = False
        '
        '_Option_0
        '
        Me._Option_0.BackColor = System.Drawing.Color.Transparent
        Me._Option_0.Checked = True
        Me._Option_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Option_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Option_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Option_0.Location = New System.Drawing.Point(16, 24)
        Me._Option_0.Name = "_Option_0"
        Me._Option_0.Size = New System.Drawing.Size(253, 17)
        Me._Option_0.TabIndex = 0
        Me._Option_0.TabStop = True
        Me._Option_0.Tag = "Distribution of short-term preaid expenses"
        Me._Option_0.Text = "Phân bổ công cụ dụng cụ ngắn hạn"
        Me._Option_0.UseVisualStyleBackColor = False
        '
        'Gauge
        '
        Me.Gauge.Location = New System.Drawing.Point(16, 128)
        Me.Gauge.Name = "Gauge"
        Me.Gauge.Size = New System.Drawing.Size(257, 17)
        Me.Gauge.TabIndex = 8
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(8, 100)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(51, 17)
        Me._Label_0.TabIndex = 7
        Me._Label_0.Tag = "From"
        Me._Label_0.Text = "Từ tháng"
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(144, 100)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(57, 17)
        Me._Label_1.TabIndex = 6
        Me._Label_1.Tag = "to"
        Me._Label_1.Text = "Đến tháng"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Line1_3
        '
        Me._Line1_3.BackColor = System.Drawing.SystemColors.Window
        Me._Line1_3.Enabled = False
        Me._Line1_3.Location = New System.Drawing.Point(280, 8)
        Me._Line1_3.Name = "_Line1_3"
        Me._Line1_3.Size = New System.Drawing.Size(1, 80)
        Me._Line1_3.TabIndex = 11
        '
        '_Line1_2
        '
        Me._Line1_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._Line1_2.Enabled = False
        Me._Line1_2.Location = New System.Drawing.Point(8, 8)
        Me._Line1_2.Name = "_Line1_2"
        Me._Line1_2.Size = New System.Drawing.Size(1, 81)
        Me._Line1_2.TabIndex = 12
        '
        '_Line1_1
        '
        Me._Line1_1.BackColor = System.Drawing.SystemColors.Window
        Me._Line1_1.Enabled = False
        Me._Line1_1.Location = New System.Drawing.Point(8, 88)
        Me._Line1_1.Name = "_Line1_1"
        Me._Line1_1.Size = New System.Drawing.Size(272, 1)
        Me._Line1_1.TabIndex = 13
        '
        '_Line1_0
        '
        Me._Line1_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._Line1_0.Enabled = False
        Me._Line1_0.Location = New System.Drawing.Point(8, 8)
        Me._Line1_0.Name = "_Line1_0"
        Me._Line1_0.Size = New System.Drawing.Size(272, 1)
        Me._Line1_0.TabIndex = 14
        '
        'frmPhanbo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(290, 186)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Combo_0)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Combo_1)
        Me.Controls.Add(Me._Option_1)
        Me.Controls.Add(Me._Option_0)
        Me.Controls.Add(Me.Gauge)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Line1_3)
        Me.Controls.Add(Me._Line1_2)
        Me.Controls.Add(Me._Line1_1)
        Me.Controls.Add(Me._Line1_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(161, 175)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPhanbo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Allocation"
        Me.Text = "Ghi chứng từ trích phân bổ"
        Me.ResumeLayout(False)

    End Sub
	Sub InitializeOption_Renamed()
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
	End Sub
	Sub InitializeCommand1()
		Me.Command1(0) = _Command1_0
		Me.Command1(1) = _Command1_1
	End Sub
	Sub InitializeCommand()
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
	Sub InitializeCombo()
		Me.Combo(0) = _Combo_0
		Me.Combo(1) = _Combo_1
    End Sub
    Private WithEvents _Combo_1 As ComboBoxEx.ComboBoxExt
#End Region 
End Class
