<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectBC
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
        isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		InitializeCommand1()
		InitializeCommand()
		InitializeBCLoai()
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
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Public WithEvents cboQuy As ComboBoxEx.ComboBoxExt
    Public WithEvents cboThang2 As ComboBoxEx.ComboBoxExt
    Public WithEvents cboThang1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _BCLoai_2 As System.Windows.Forms.RadioButton
    Private WithEvents _BCLoai_1 As System.Windows.Forms.RadioButton
    Private WithEvents _BCLoai_0 As System.Windows.Forms.RadioButton
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public BCLoai(2) As System.Windows.Forms.RadioButton
    Public Command(1) As System.Windows.Forms.Button
    Public Command1(1) As System.Windows.Forms.Button
    'Private listBoxComboBoxHelper1 As Artinsoft.VB6.Gui.ListControlHelper
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelectBC))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me._Command1_0 = New System.Windows.Forms.Button()
        Me._Command1_1 = New System.Windows.Forms.Button()
        Me.cboQuy = New ComboBoxEx.ComboBoxExt()
        Me.cboThang2 = New ComboBoxEx.ComboBoxExt()
        Me.cboThang1 = New ComboBoxEx.ComboBoxExt()
        Me._BCLoai_2 = New System.Windows.Forms.RadioButton()
        Me._BCLoai_1 = New System.Windows.Forms.RadioButton()
        Me._BCLoai_0 = New System.Windows.Forms.RadioButton()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(336, 69)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(89, 25)
        Me._Command_1.TabIndex = 13
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        '
        '_Command_0
        '
        Me._Command_0.Image = CType(resources.GetObject("_Command_0.Image"), System.Drawing.Image)
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(240, 69)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(89, 25)
        Me._Command_0.TabIndex = 12
        Me._Command_0.Tag = "Preview"
        Me._Command_0.Text = "&Xem"
        '
        '_Command1_0
        '
        Me._Command1_0.BackColor = System.Drawing.Color.Silver
        Me._Command1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_0.Image = CType(resources.GetObject("_Command1_0.Image"), System.Drawing.Image)
        Me._Command1_0.Location = New System.Drawing.Point(200, 115)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(89, 25)
        Me._Command1_0.TabIndex = 11
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&View"
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
        Me._Command1_1.Location = New System.Drawing.Point(320, 115)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(89, 25)
        Me._Command1_1.TabIndex = 10
        Me._Command1_1.TabStop = False
        Me._Command1_1.Tag = "&Return"
        Me._Command1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_1.UseVisualStyleBackColor = False
        Me._Command1_1.Visible = False
        '
        'cboQuy
        '
        Me.cboQuy.BackColor = System.Drawing.SystemColors.Window
        Me.cboQuy.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboQuy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboQuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuy.DropDownWidth = 29
        Me.cboQuy.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQuy.Location = New System.Drawing.Point(240, 20)
        Me.cboQuy.Name = "cboQuy"
        Me.cboQuy.Size = New System.Drawing.Size(57, 21)
        Me.cboQuy.TabIndex = 8
        Me.cboQuy.Visible = False
        '
        'cboThang2
        '
        Me.cboThang2.BackColor = System.Drawing.SystemColors.Window
        Me.cboThang2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboThang2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboThang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboThang2.DropDownWidth = 36
        Me.cboThang2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboThang2.Location = New System.Drawing.Point(368, 20)
        Me.cboThang2.Name = "cboThang2"
        Me.cboThang2.Size = New System.Drawing.Size(57, 21)
        Me.cboThang2.TabIndex = 6
        '
        'cboThang1
        '
        Me.cboThang1.BackColor = System.Drawing.SystemColors.Window
        Me.cboThang1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboThang1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboThang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboThang1.DropDownWidth = 36
        Me.cboThang1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboThang1.Location = New System.Drawing.Point(240, 20)
        Me.cboThang1.Name = "cboThang1"
        Me.cboThang1.Size = New System.Drawing.Size(57, 21)
        Me.cboThang1.TabIndex = 3
        '
        '_BCLoai_2
        '
        Me._BCLoai_2.BackColor = System.Drawing.Color.Transparent
        Me._BCLoai_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._BCLoai_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._BCLoai_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._BCLoai_2.Location = New System.Drawing.Point(24, 72)
        Me._BCLoai_2.Name = "_BCLoai_2"
        Me._BCLoai_2.Size = New System.Drawing.Size(137, 17)
        Me._BCLoai_2.TabIndex = 2
        Me._BCLoai_2.TabStop = True
        Me._BCLoai_2.Tag = "Year report"
        Me._BCLoai_2.Text = "Báo cáo Năm"
        Me._BCLoai_2.UseVisualStyleBackColor = False
        '
        '_BCLoai_1
        '
        Me._BCLoai_1.BackColor = System.Drawing.Color.Transparent
        Me._BCLoai_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._BCLoai_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._BCLoai_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._BCLoai_1.Location = New System.Drawing.Point(24, 48)
        Me._BCLoai_1.Name = "_BCLoai_1"
        Me._BCLoai_1.Size = New System.Drawing.Size(137, 17)
        Me._BCLoai_1.TabIndex = 1
        Me._BCLoai_1.TabStop = True
        Me._BCLoai_1.Tag = "Quarterly report"
        Me._BCLoai_1.Text = "Báo cáo Quý"
        Me._BCLoai_1.UseVisualStyleBackColor = False
        '
        '_BCLoai_0
        '
        Me._BCLoai_0.BackColor = System.Drawing.Color.Transparent
        Me._BCLoai_0.Checked = True
        Me._BCLoai_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._BCLoai_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._BCLoai_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._BCLoai_0.Location = New System.Drawing.Point(24, 24)
        Me._BCLoai_0.Name = "_BCLoai_0"
        Me._BCLoai_0.Size = New System.Drawing.Size(137, 17)
        Me._BCLoai_0.TabIndex = 0
        Me._BCLoai_0.TabStop = True
        Me._BCLoai_0.Tag = "Month report"
        Me._BCLoai_0.Text = "Báo cáo Tháng"
        Me._BCLoai_0.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.Transparent
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(161, 89)
        Me.Frame1.TabIndex = 4
        Me.Frame1.TabStop = False
        Me.Frame1.Tag = "Clas report"
        Me.Frame1.Text = "Loại báo cáo"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(179, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Tag = "Quarterly"
        Me.Label3.Text = "Quý"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(304, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Tag = "To"
        Me.Label2.Text = "Đến tháng"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(176, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Tag = "From"
        Me.Label1.Text = "Từ tháng"
        '
        'frmSelectBC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(434, 106)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me.cboQuy)
        Me.Controls.Add(Me.cboThang2)
        Me.Controls.Add(Me.cboThang1)
        Me.Controls.Add(Me._BCLoai_2)
        Me.Controls.Add(Me._BCLoai_1)
        Me.Controls.Add(Me._BCLoai_0)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelectBC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Invoice statement using"
        Me.Text = "Báo cáo hoá đơn sử dụng"
        Me.ResumeLayout(False)

    End Sub
	Sub InitializeCommand1()
		Me.Command1(0) = _Command1_0
		Me.Command1(1) = _Command1_1
	End Sub
	Sub InitializeCommand()
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
	Sub InitializeBCLoai()
		Me.BCLoai(2) = _BCLoai_2
		Me.BCLoai(1) = _BCLoai_1
		Me.BCLoai(0) = _BCLoai_0
	End Sub
#End Region 
End Class
