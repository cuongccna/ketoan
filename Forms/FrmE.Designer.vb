<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmE
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
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
	Public WithEvents txt As System.Windows.Forms.TextBox
	Public WithEvents Lst As System.Windows.Forms.ListBox
	Public WithEvents Cbo As ComboBoxEx.ComboBoxExt
    'Private listBoxComboBoxHelper1 As Artinsoft.VB6.Gui.ListControlHelper
    'Private listBoxHelper1 As Artinsoft.VB6.Gui.ListBoxHelper
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt = New System.Windows.Forms.TextBox()
        Me.Lst = New System.Windows.Forms.ListBox()
        Me.Cbo = New ComboBoxEx.ComboBoxExt()
        Me.SuspendLayout()
        '
        'txt
        '
        Me.txt.AcceptsReturn = True
        Me.txt.BackColor = System.Drawing.SystemColors.Window
        Me.txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.Location = New System.Drawing.Point(8, 272)
        Me.txt.MaxLength = 0
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(409, 19)
        Me.txt.TabIndex = 2
        '
        'Lst
        '
        Me.Lst.BackColor = System.Drawing.SystemColors.Window
        Me.Lst.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst.Location = New System.Drawing.Point(8, 32)
        Me.Lst.Name = "Lst"
        Me.Lst.Size = New System.Drawing.Size(409, 238)
        Me.Lst.TabIndex = 1
        '
        'Cbo
        '
        Me.Cbo.BackColor = System.Drawing.SystemColors.Window
        Me.Cbo.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cbo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.Cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo.DropDownWidth = 169
        Me.Cbo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo.Location = New System.Drawing.Point(8, 8)
        Me.Cbo.Name = "Cbo"
        Me.Cbo.Size = New System.Drawing.Size(409, 21)
        Me.Cbo.TabIndex = 0
        '
        'FrmE
        '
        ' Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        'Me.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.Appearance.Options.UseBackColor = True
        'Me.Appearance.Options.UseFont = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 297)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.Lst)
        Me.Controls.Add(Me.Cbo)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(199, 112)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmE"
        Me.ShowInTaskbar = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Financial Report Description"
        Me.Text = "Diễn giải song ngữ"
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class
