<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GetMonth
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeLabel()
		InitializeFrame()
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
	Private WithEvents _CboThang_1 As ComboBoxEx.ComboBoxExt
	Private WithEvents _CboThang_0 As ComboBoxEx.ComboBoxExt
	Private WithEvents _Label_0 As System.Windows.Forms.Label
	Private WithEvents _Label_17 As System.Windows.Forms.Label
	Private WithEvents _Frame_4 As System.Windows.Forms.Panel
	Public CboThang(1) As ComboBoxEx.ComboBoxExt
	Public Frame(4) As System.Windows.Forms.Panel
	Public Label(17) As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Frame_4 = New System.Windows.Forms.Panel()
        Me._CboThang_1 = New ComboBoxEx.ComboBoxExt()
        Me._CboThang_0 = New ComboBoxEx.ComboBoxExt()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me._Label_17 = New System.Windows.Forms.Label()
        Me._Frame_4.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Frame_4
        '
        Me._Frame_4.BackColor = System.Drawing.Color.Transparent
        Me._Frame_4.Controls.Add(Me._CboThang_1)
        Me._Frame_4.Controls.Add(Me._CboThang_0)
        Me._Frame_4.Controls.Add(Me._Label_0)
        Me._Frame_4.Controls.Add(Me._Label_17)
        Me._Frame_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Frame_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_4.Location = New System.Drawing.Point(0, 4)
        Me._Frame_4.Name = "_Frame_4"
        Me._Frame_4.Size = New System.Drawing.Size(273, 33)
        Me._Frame_4.TabIndex = 0
        Me._Frame_4.Text = "Sổ kế toán tổng hợp và báo cáo Tài chính"
        '
        '_CboThang_1
        '
        Me._CboThang_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_1.Location = New System.Drawing.Point(196, 6)
        Me._CboThang_1.Name = "_CboThang_1"
        Me._CboThang_1.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_1.TabIndex = 2
        '
        '_CboThang_0
        '
        Me._CboThang_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_0.Location = New System.Drawing.Point(60, 6)
        Me._CboThang_0.Name = "_CboThang_0"
        Me._CboThang_0.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_0.TabIndex = 1
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(3, 8)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(58, 17)
        Me._Label_0.TabIndex = 4
        Me._Label_0.Tag = "From"
        Me._Label_0.Text = " Từ tháng"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.Color.Transparent
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_17.Location = New System.Drawing.Point(139, 8)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(58, 17)
        Me._Label_17.TabIndex = 3
        Me._Label_17.Tag = "to"
        Me._Label_17.Text = "Đến tháng"
        Me._Label_17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GetMonth
        '
        'Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        ''Me.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ''Me.Appearance.Options.UseBackColor = True
        ''Me.Appearance.Options.UseFont = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(272, 37)
        Me.ControlBox = False
        Me.Controls.Add(Me._Frame_4)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(209, 222)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GetMonth"
        Me.ShowInTaskbar = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me._Frame_4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
	Sub InitializeLabel()
		Me.Label(0) = _Label_0
		Me.Label(17) = _Label_17
	End Sub
	Sub InitializeFrame()
		Me.Frame(4) = _Frame_4
	End Sub
	Sub InitializeCboThang()
		Me.CboThang(1) = _CboThang_1
		Me.CboThang(0) = _CboThang_0
	End Sub
#End Region 
End Class
