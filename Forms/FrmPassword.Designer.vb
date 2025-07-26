<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPassword
    Inherits Form

#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        ' Init components
        InitializeComponent()
    End Sub
''' <summary>
''' 
''' </summary>
''' <param name="eventSender"></param>
''' <param name="eventArgs"></param>
''' <remarks></remarks>
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
    Public WithEvents txtPsw As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
     Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtPsw = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPsw
        '
        Me.txtPsw.AcceptsReturn = True
        Me.txtPsw.BackColor = System.Drawing.SystemColors.Window
        Me.txtPsw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPsw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPsw.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPsw.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtPsw.Location = New System.Drawing.Point(76, 4)
        Me.txtPsw.MaxLength = 30
        Me.txtPsw.Name = "txtPsw"
        Me.txtPsw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPsw.Size = New System.Drawing.Size(137, 20)
        Me.txtPsw.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Tag = "Password"
        Me.Label1.Text = "Mật khẩu"
        '
        'FrmPassword
        '
        ' Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        'Me.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.Appearance.Options.UseBackColor = True
        'Me.Appearance.Options.UseFont = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(224, 28)
        Me.Controls.Add(Me.txtPsw)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(382, 340)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPassword"
        Me.ShowInTaskbar = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Password"
        Me.Text = "Mật khẩu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
End Class
