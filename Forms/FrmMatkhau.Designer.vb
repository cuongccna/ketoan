<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMatkhau
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeLabel()
        InitializeCommand()
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
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    'Private WithEvents _Command_0 As System.Windows.Forms.Button
    Public WithEvents CboUser As ComboBoxEx.ComboBoxExt
    Public WithEvents txtPsw As System.Windows.Forms.TextBox
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Public Command(1) As System.Windows.Forms.Button
    Public Command1(1) As System.Windows.Forms.Button
    Public Label(1) As System.Windows.Forms.Label
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMatkhau))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_1 = New System.Windows.Forms.Button()
        Me.CboUser = New ComboBoxEx.ComboBoxExt()
        Me.txtPsw = New System.Windows.Forms.TextBox()
        Me._Label_1 = New System.Windows.Forms.Label()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        '_Command_1
        '
        Me._Command_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Command_1.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(208, 64)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(83, 23)
        Me._Command_1.TabIndex = 2
        Me._Command_1.Tag = "&Return"
        Me._Command_1.Text = "&Thoát"
        '
        'CboUser
        '
        Me.CboUser.BackColor = System.Drawing.SystemColors.Window
        Me.CboUser.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboUser.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboUser.Location = New System.Drawing.Point(91, 8)
        Me.CboUser.Name = "CboUser"
        Me.CboUser.Size = New System.Drawing.Size(200, 21)
        Me.CboUser.TabIndex = 0
        '
        'txtPsw
        '
        Me.txtPsw.AcceptsReturn = True
        Me.txtPsw.BackColor = System.Drawing.SystemColors.Window
        Me.txtPsw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPsw.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPsw.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtPsw.Location = New System.Drawing.Point(91, 35)
        Me.txtPsw.MaxLength = 15
        Me.txtPsw.Name = "txtPsw"
        Me.txtPsw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPsw.Size = New System.Drawing.Size(200, 20)
        Me.txtPsw.TabIndex = 5
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me._Label_1.Location = New System.Drawing.Point(6, 11)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(79, 16)
        Me._Label_1.TabIndex = 6
        Me._Label_1.Tag = "User Name"
        Me._Label_1.Text = "Người sử dụng"
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me._Label_0.Location = New System.Drawing.Point(6, 38)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(79, 16)
        Me._Label_0.TabIndex = 4
        Me._Label_0.Tag = "Password"
        Me._Label_0.Text = "Mật khẩu"
        '
        '_Command_0
        '
        Me._Command_0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Command_0.Image = CType(resources.GetObject("_Command_0.Image"), System.Drawing.Image)
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(91, 64)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(111, 23)
        Me._Command_0.TabIndex = 7
        Me._Command_0.Tag = "Login"
        Me._Command_0.Text = "Đăng &nhập"
        '
        'FrmMatkhau
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(298, 93)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me.CboUser)
        Me.Controls.Add(Me.txtPsw)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(311, 347)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMatkhau"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "0"
        Me.Text = "Kiểm tra mật khẩu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Sub InitializeLabel()
        Me.Label(1) = _Label_1
        Me.Label(0) = _Label_0
    End Sub

    Sub InitializeCommand()
        Me.Command(1) = _Command_1
        Me.Command(0) = _Command_0
    End Sub
    Friend WithEvents _Command_0 As System.Windows.Forms.Button
#End Region
End Class
