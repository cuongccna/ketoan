<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKho
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeCommand()
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
    Private WithEvents _Command_4 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command1_4 As System.Windows.Forms.Button
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Public WithEvents LstKho As System.Windows.Forms.ListBox
    Public WithEvents txtTenkho As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public Command(4) As System.Windows.Forms.Button
    Public Command1(4) As System.Windows.Forms.Button
    'Private listBoxHelper1 As Artinsoft.VB6.Gui.ListBoxHelper
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKho))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_4 = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Command1_4 = New System.Windows.Forms.Button
        Me._Command1_0 = New System.Windows.Forms.Button
        Me.LstKho = New System.Windows.Forms.ListBox
        Me.txtTenkho = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        '_Command_4
        '
        Me._Command_4.Image = Global.UNET.My.Resources.Resources.select16
        Me._Command_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_4.Location = New System.Drawing.Point(200, 9)
        Me._Command_4.Name = "_Command_4"
        Me._Command_4.Size = New System.Drawing.Size(73, 25)
        Me._Command_4.TabIndex = 12
        Me._Command_4.Tag = "Choose"
        Me._Command_4.Text = "&Chọn"
        Me._Command_4.Visible = False
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(200, 102)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 11
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(200, 71)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 10
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(200, 40)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 9
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.add16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(200, 8)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 8
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        '
        '_Command1_4
        '
        Me._Command1_4.BackColor = System.Drawing.Color.Silver
        Me._Command1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_4.Image = CType(resources.GetObject("_Command1_4.Image"), System.Drawing.Image)
        Me._Command1_4.Location = New System.Drawing.Point(200, 8)
        Me._Command1_4.Name = "_Command1_4"
        Me._Command1_4.Size = New System.Drawing.Size(73, 25)
        Me._Command1_4.TabIndex = 6
        Me._Command1_4.TabStop = False
        Me._Command1_4.Tag = "&SELECT"
        Me._Command1_4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_4.UseVisualStyleBackColor = False
        Me._Command1_4.Visible = False
        '
        '_Command1_0
        '
        Me._Command1_0.BackColor = System.Drawing.Color.Silver
        Me._Command1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_0.Image = CType(resources.GetObject("_Command1_0.Image"), System.Drawing.Image)
        Me._Command1_0.Location = New System.Drawing.Point(200, 8)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(73, 25)
        Me._Command1_0.TabIndex = 2
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&Add"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        'LstKho
        '
        Me.LstKho.BackColor = System.Drawing.SystemColors.Window
        Me.LstKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstKho.Cursor = System.Windows.Forms.Cursors.Default
        Me.LstKho.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstKho.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LstKho.ItemHeight = 14
        Me.LstKho.Location = New System.Drawing.Point(8, 8)
        Me.LstKho.Name = "LstKho"
        Me.LstKho.Size = New System.Drawing.Size(185, 142)
        Me.LstKho.Sorted = True
        Me.LstKho.TabIndex = 0
        '
        'txtTenkho
        '
        Me.txtTenkho.AcceptsReturn = True
        Me.txtTenkho.BackColor = System.Drawing.SystemColors.Window
        Me.txtTenkho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTenkho.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTenkho.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenkho.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTenkho.Location = New System.Drawing.Point(8, 149)
        Me.txtTenkho.MaxLength = 50
        Me.txtTenkho.Name = "txtTenkho"
        Me.txtTenkho.Size = New System.Drawing.Size(185, 20)
        Me.txtTenkho.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(200, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 30)
        Me.Label1.TabIndex = 7
        Me.Label1.Tag = "Press Ctrl-F to seach"
        Me.Label1.Text = "Bấm Ctrl-F để tìm kiếm"
        Me.Label1.Visible = False
        '
        'FrmKho
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(281, 177)
        Me.Controls.Add(Me.txtTenkho)
        Me.Controls.Add(Me._Command_4)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command1_4)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me.LstKho)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(278, 163)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmKho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "List of Items"
        Me.Text = "Kho vật tư, thành phẩm, đại lý..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	
	Sub InitializeCommand()
		Me.Command(4) = _Command_4
		Me.Command(3) = _Command_3
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
#End Region 
End Class
