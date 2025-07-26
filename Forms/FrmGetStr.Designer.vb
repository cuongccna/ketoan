<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGetStr
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeLabel()
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
	Public WithEvents List As System.Windows.Forms.ListBox
	Public WithEvents Text_Renamed As System.Windows.Forms.TextBox
	Private WithEvents _Label_1 As System.Windows.Forms.Label
	Private WithEvents _Label_0 As System.Windows.Forms.Label
	Public Label(1) As System.Windows.Forms.Label
    'Private listBoxHelper1 As Artinsoft.VB6.Gui.ListBoxHelper
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGetStr))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.List = New System.Windows.Forms.ListBox()
        Me.Text_Renamed = New System.Windows.Forms.TextBox()
        Me._Label_1 = New System.Windows.Forms.Label()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'List
        '
        Me.List.BackColor = System.Drawing.SystemColors.Window
        Me.List.Cursor = System.Windows.Forms.Cursors.Default
        Me.List.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List.Location = New System.Drawing.Point(7, 88)
        Me.List.Name = "List"
        Me.List.Size = New System.Drawing.Size(481, 108)
        Me.List.TabIndex = 3
        '
        'Text_Renamed
        '
        Me.Text_Renamed.AcceptsReturn = True
        Me.Text_Renamed.BackColor = System.Drawing.SystemColors.Window
        Me.Text_Renamed.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text_Renamed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Renamed.Location = New System.Drawing.Point(7, 32)
        Me.Text_Renamed.MaxLength = 0
        Me.Text_Renamed.Name = "Text_Renamed"
        Me.Text_Renamed.Size = New System.Drawing.Size(481, 20)
        Me.Text_Renamed.TabIndex = 1
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(7, 64)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(481, 17)
        Me._Label_1.TabIndex = 2
        Me._Label_1.Tag = "Account have track details"
        Me._Label_1.Text = "Tài khoản có theo dõi chi tiết"
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(7, 8)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(481, 17)
        Me._Label_0.TabIndex = 0
        '
        'FrmGetStr
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(495, 208)
        Me.Controls.Add(Me.List)
        Me.Controls.Add(Me.Text_Renamed)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(162, 284)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGetStr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializeLabel()
		Me.Label(1) = _Label_1
		Me.Label(0) = _Label_0
	End Sub
#End Region 
End Class
