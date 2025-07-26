<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSocongcu
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
        isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		InitializeOptBC()
		InitializeLabel()
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
	Private WithEvents _OptBC_89 As System.Windows.Forms.RadioButton
	Private WithEvents _OptBC_90 As System.Windows.Forms.RadioButton
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Public WithEvents GauGe As System.Windows.Forms.ProgressBar
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Public CboThang(1) As ComboBoxEx.ComboBoxExt
    Public Command(2) As System.Windows.Forms.Button
    Public Label(1) As System.Windows.Forms.Label
    Public OptBC(90) As System.Windows.Forms.RadioButton
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSocongcu))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._CboThang_0 = New ComboBoxEx.ComboBoxExt
        Me._CboThang_1 = New ComboBoxEx.ComboBoxExt
        Me._OptBC_89 = New System.Windows.Forms.RadioButton
        Me._OptBC_90 = New System.Windows.Forms.RadioButton
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me.GauGe = New System.Windows.Forms.ProgressBar
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        '_CboThang_0
        '
        Me._CboThang_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_0.Location = New System.Drawing.Point(64, 8)
        Me._CboThang_0.Name = "_CboThang_0"
        Me._CboThang_0.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_0.TabIndex = 0
        '
        '_CboThang_1
        '
        Me._CboThang_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_1.Location = New System.Drawing.Point(200, 8)
        Me._CboThang_1.Name = "_CboThang_1"
        Me._CboThang_1.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_1.TabIndex = 1
        '
        '_OptBC_89
        '
        Me._OptBC_89.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_89.Checked = True
        Me._OptBC_89.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_89.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_89.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_89.Location = New System.Drawing.Point(8, 36)
        Me._OptBC_89.Name = "_OptBC_89"
        Me._OptBC_89.Size = New System.Drawing.Size(137, 17)
        Me._OptBC_89.TabIndex = 2
        Me._OptBC_89.TabStop = True
        Me._OptBC_89.Tag = "Allocation Details"
        Me._OptBC_89.Text = "Sổ phân bổ chi tiết"
        Me._OptBC_89.UseVisualStyleBackColor = False
        '
        '_OptBC_90
        '
        Me._OptBC_90.BackColor = System.Drawing.Color.Transparent
        Me._OptBC_90.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptBC_90.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptBC_90.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptBC_90.Location = New System.Drawing.Point(144, 36)
        Me._OptBC_90.Name = "_OptBC_90"
        Me._OptBC_90.Size = New System.Drawing.Size(137, 17)
        Me._OptBC_90.TabIndex = 3
        Me._OptBC_90.TabStop = True
        Me._OptBC_90.Tag = "Reporting Tools"
        Me._OptBC_90.Text = "Sổ công cụ dụng cụ"
        Me._OptBC_90.UseVisualStyleBackColor = False
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(200, 60)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 5
        Me._Command_2.Tag = "Return"
        Me._Command_2.Text = "Trở &về"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.report16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(120, 60)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 4
        Me._Command_0.Tag = "Preview"
        Me._Command_0.Text = "&Xem"
        '
        'GauGe
        '
        Me.GauGe.Location = New System.Drawing.Point(8, 68)
        Me.GauGe.Name = "GauGe"
        Me.GauGe.Size = New System.Drawing.Size(105, 17)
        Me.GauGe.TabIndex = 6
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(8, 12)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(58, 17)
        Me._Label_0.TabIndex = 8
        Me._Label_0.Tag = "From"
        Me._Label_0.Text = "Từ tháng"
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(144, 12)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(58, 17)
        Me._Label_1.TabIndex = 7
        Me._Label_1.Tag = "to"
        Me._Label_1.Text = "Đến tháng"
        '
        'FrmSocongcu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(281, 92)
        Me.Controls.Add(Me._CboThang_0)
        Me.Controls.Add(Me._CboThang_1)
        Me.Controls.Add(Me._OptBC_89)
        Me.Controls.Add(Me._OptBC_90)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me.GauGe)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSocongcu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Reporting tools"
        Me.Text = "Sổ công cụ dụng cụ"
        Me.ResumeLayout(False)

    End Sub
	Sub InitializeOptBC()
		Me.OptBC(89) = _OptBC_89
		Me.OptBC(90) = _OptBC_90
	End Sub
	Sub InitializeLabel()
		Me.Label(0) = _Label_0
		Me.Label(1) = _Label_1
	End Sub
	Sub InitializeCommand()
		Me.Command(2) = _Command_2
		Me.Command(0) = _Command_0
	End Sub
	Sub InitializeCboThang()
		Me.CboThang(0) = _CboThang_0
		Me.CboThang(1) = _CboThang_1
	End Sub
#End Region 
End Class
