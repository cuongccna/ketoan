<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChuY
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeTxtChuY()
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
    Public WithEvents cmdOK As System.Windows.Forms.Button
    Private WithEvents _TxtChuY_1 As System.Windows.Forms.TextBox
    Private WithEvents _TxtChuY_0 As System.Windows.Forms.TextBox
    Public WithEvents cmdOK1 As System.Windows.Forms.Button
    Public WithEvents lbl As System.Windows.Forms.Label
    Public TxtChuY(1) As System.Windows.Forms.TextBox
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChuY))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdOK = New System.Windows.Forms.Button()
        Me._TxtChuY_1 = New System.Windows.Forms.TextBox()
        Me._TxtChuY_0 = New System.Windows.Forms.TextBox()
        Me.cmdOK1 = New System.Windows.Forms.Button()
        Me.lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdOK
        '
        Me.cmdOK.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me.cmdOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdOK.Location = New System.Drawing.Point(304, 240)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(73, 25)
        Me.cmdOK.TabIndex = 4
        Me.cmdOK.Text = "Trở &về"
        '
        '_TxtChuY_1
        '
        Me._TxtChuY_1.AcceptsReturn = True
        Me._TxtChuY_1.BackColor = System.Drawing.SystemColors.Window
        Me._TxtChuY_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtChuY_1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtChuY_1.Location = New System.Drawing.Point(0, 128)
        Me._TxtChuY_1.MaxLength = 255
        Me._TxtChuY_1.Multiline = True
        Me._TxtChuY_1.Name = "_TxtChuY_1"
        Me._TxtChuY_1.Size = New System.Drawing.Size(385, 97)
        Me._TxtChuY_1.TabIndex = 3
        Me._TxtChuY_1.Text = "Không" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        '_TxtChuY_0
        '
        Me._TxtChuY_0.AcceptsReturn = True
        Me._TxtChuY_0.BackColor = System.Drawing.SystemColors.Window
        Me._TxtChuY_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtChuY_0.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtChuY_0.Location = New System.Drawing.Point(0, 16)
        Me._TxtChuY_0.MaxLength = 255
        Me._TxtChuY_0.Multiline = True
        Me._TxtChuY_0.Name = "_TxtChuY_0"
        Me._TxtChuY_0.Size = New System.Drawing.Size(385, 97)
        Me._TxtChuY_0.TabIndex = 2
        Me._TxtChuY_0.Text = "Không" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmdOK1
        '
        Me.cmdOK1.BackColor = System.Drawing.Color.Silver
        Me.cmdOK1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK1.Image = CType(resources.GetObject("cmdOK1.Image"), System.Drawing.Image)
        Me.cmdOK1.Location = New System.Drawing.Point(304, 240)
        Me.cmdOK1.Name = "cmdOK1"
        Me.cmdOK1.Size = New System.Drawing.Size(73, 25)
        Me.cmdOK1.TabIndex = 1
        Me.cmdOK1.TabStop = False
        Me.cmdOK1.Tag = "&Return"
        Me.cmdOK1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdOK1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdOK1.UseVisualStyleBackColor = False
        Me.cmdOK1.Visible = False
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.BackColor = System.Drawing.Color.Transparent
        Me.lbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.Blue
        Me.lbl.Location = New System.Drawing.Point(80, 336)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(359, 13)
        Me.lbl.TabIndex = 0
        Me.lbl.Text = "Email: misuco_hcm@email.viettel.vn       misucohcm@gmail.com"
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmChuY
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(385, 273)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me._TxtChuY_1)
        Me.Controls.Add(Me._TxtChuY_0)
        Me.Controls.Add(Me.cmdOK1)
        Me.Controls.Add(Me.lbl)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(134, 116)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChuY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chú ý"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializeTxtChuY()
		Me.TxtChuY(1) = _TxtChuY_1
		Me.TxtChuY(0) = _TxtChuY_0
	End Sub
#End Region 
End Class
