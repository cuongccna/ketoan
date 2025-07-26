<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUser3
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeLabel()
		InitializeCommand()
		InitializeChk()
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
	Private WithEvents _Chk_8 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_7 As System.Windows.Forms.CheckBox
	Public WithEvents CboRight As ComboBoxEx.ComboBoxExt
	Public WithEvents txtNhap As System.Windows.Forms.TextBox
	Private WithEvents _Chk_0 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_1 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_2 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_3 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_4 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_5 As System.Windows.Forms.CheckBox
	Private WithEvents _Chk_6 As System.Windows.Forms.CheckBox
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command_4 As System.Windows.Forms.Button
    Public WithEvents GrdNT As ListviewEx.ListviewExt
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Public Chk(9) As System.Windows.Forms.CheckBox
    Public Command(4) As System.Windows.Forms.Button
    Public Label(11) As System.Windows.Forms.Label
    'Private listBoxComboBoxHelper1 As Artinsoft.VB6.Gui.ListControlHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Chk_8 = New System.Windows.Forms.CheckBox()
        Me._Chk_7 = New System.Windows.Forms.CheckBox()
        Me.CboRight = New ComboBoxEx.ComboBoxExt()
        Me.txtNhap = New System.Windows.Forms.TextBox()
        Me._Chk_0 = New System.Windows.Forms.CheckBox()
        Me._Chk_1 = New System.Windows.Forms.CheckBox()
        Me._Chk_2 = New System.Windows.Forms.CheckBox()
        Me._Chk_3 = New System.Windows.Forms.CheckBox()
        Me._Chk_4 = New System.Windows.Forms.CheckBox()
        Me._Chk_5 = New System.Windows.Forms.CheckBox()
        Me._Chk_6 = New System.Windows.Forms.CheckBox()
        Me._Command_3 = New System.Windows.Forms.Button()
        Me._Command_2 = New System.Windows.Forms.Button()
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me._Command_4 = New System.Windows.Forms.Button()
        Me._Label_11 = New System.Windows.Forms.Label()
        Me._Label_10 = New System.Windows.Forms.Label()
        Me._Label_7 = New System.Windows.Forms.Label()
        Me._Label_5 = New System.Windows.Forms.Label()
        Me._Label_4 = New System.Windows.Forms.Label()
        Me._Label_3 = New System.Windows.Forms.Label()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me._Label_1 = New System.Windows.Forms.Label()
        Me._Label_2 = New System.Windows.Forms.Label()
        Me._Label_6 = New System.Windows.Forms.Label()
        Me._Label_8 = New System.Windows.Forms.Label()
        Me.GrdNT = New ListViewEx.ListviewExt()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._Chk_9 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        '_Chk_8
        '
        Me._Chk_8.BackColor = System.Drawing.Color.Transparent
        Me._Chk_8.Checked = True
        Me._Chk_8.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Chk_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_8.Enabled = False
        Me._Chk_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_8.Location = New System.Drawing.Point(587, 188)
        Me._Chk_8.Name = "_Chk_8"
        Me._Chk_8.Size = New System.Drawing.Size(17, 17)
        Me._Chk_8.TabIndex = 10
        Me._Chk_8.UseVisualStyleBackColor = False
        '
        '_Chk_7
        '
        Me._Chk_7.BackColor = System.Drawing.Color.Transparent
        Me._Chk_7.Checked = True
        Me._Chk_7.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Chk_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_7.Enabled = False
        Me._Chk_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_7.Location = New System.Drawing.Point(537, 188)
        Me._Chk_7.Name = "_Chk_7"
        Me._Chk_7.Size = New System.Drawing.Size(17, 17)
        Me._Chk_7.TabIndex = 9
        Me._Chk_7.UseVisualStyleBackColor = False
        '
        'CboRight
        '
        Me.CboRight.BackColor = System.Drawing.SystemColors.Window
        Me.CboRight.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboRight.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboRight.DropDownWidth = 68
        Me.CboRight.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboRight.Location = New System.Drawing.Point(127, 184)
        Me.CboRight.Name = "CboRight"
        Me.CboRight.Size = New System.Drawing.Size(68, 21)
        Me.CboRight.TabIndex = 1
        '
        'txtNhap
        '
        Me.txtNhap.AcceptsReturn = True
        Me.txtNhap.BackColor = System.Drawing.SystemColors.Window
        Me.txtNhap.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNhap.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNhap.Location = New System.Drawing.Point(8, 184)
        Me.txtNhap.MaxLength = 50
        Me.txtNhap.Name = "txtNhap"
        Me.txtNhap.Size = New System.Drawing.Size(121, 20)
        Me.txtNhap.TabIndex = 0
        Me.txtNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_Chk_0
        '
        Me._Chk_0.BackColor = System.Drawing.Color.Transparent
        Me._Chk_0.Checked = True
        Me._Chk_0.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Chk_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_0.Location = New System.Drawing.Point(216, 188)
        Me._Chk_0.Name = "_Chk_0"
        Me._Chk_0.Size = New System.Drawing.Size(17, 17)
        Me._Chk_0.TabIndex = 2
        Me._Chk_0.UseVisualStyleBackColor = False
        '
        '_Chk_1
        '
        Me._Chk_1.BackColor = System.Drawing.Color.Transparent
        Me._Chk_1.Checked = True
        Me._Chk_1.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Chk_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_1.Enabled = False
        Me._Chk_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_1.Location = New System.Drawing.Point(264, 188)
        Me._Chk_1.Name = "_Chk_1"
        Me._Chk_1.Size = New System.Drawing.Size(17, 17)
        Me._Chk_1.TabIndex = 3
        Me._Chk_1.UseVisualStyleBackColor = False
        '
        '_Chk_2
        '
        Me._Chk_2.BackColor = System.Drawing.Color.Transparent
        Me._Chk_2.Checked = True
        Me._Chk_2.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Chk_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_2.Enabled = False
        Me._Chk_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_2.Location = New System.Drawing.Point(304, 188)
        Me._Chk_2.Name = "_Chk_2"
        Me._Chk_2.Size = New System.Drawing.Size(17, 17)
        Me._Chk_2.TabIndex = 4
        Me._Chk_2.UseVisualStyleBackColor = False
        '
        '_Chk_3
        '
        Me._Chk_3.BackColor = System.Drawing.Color.Transparent
        Me._Chk_3.Checked = True
        Me._Chk_3.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Chk_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_3.Enabled = False
        Me._Chk_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_3.Location = New System.Drawing.Point(344, 188)
        Me._Chk_3.Name = "_Chk_3"
        Me._Chk_3.Size = New System.Drawing.Size(17, 17)
        Me._Chk_3.TabIndex = 5
        Me._Chk_3.UseVisualStyleBackColor = False
        '
        '_Chk_4
        '
        Me._Chk_4.BackColor = System.Drawing.Color.Transparent
        Me._Chk_4.Checked = True
        Me._Chk_4.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Chk_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_4.Enabled = False
        Me._Chk_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_4.Location = New System.Drawing.Point(392, 188)
        Me._Chk_4.Name = "_Chk_4"
        Me._Chk_4.Size = New System.Drawing.Size(17, 17)
        Me._Chk_4.TabIndex = 6
        Me._Chk_4.UseVisualStyleBackColor = False
        '
        '_Chk_5
        '
        Me._Chk_5.BackColor = System.Drawing.Color.Transparent
        Me._Chk_5.Checked = True
        Me._Chk_5.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Chk_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_5.Enabled = False
        Me._Chk_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_5.Location = New System.Drawing.Point(432, 188)
        Me._Chk_5.Name = "_Chk_5"
        Me._Chk_5.Size = New System.Drawing.Size(17, 17)
        Me._Chk_5.TabIndex = 7
        Me._Chk_5.UseVisualStyleBackColor = False
        '
        '_Chk_6
        '
        Me._Chk_6.BackColor = System.Drawing.Color.Transparent
        Me._Chk_6.Checked = True
        Me._Chk_6.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Chk_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_6.Enabled = False
        Me._Chk_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_6.Location = New System.Drawing.Point(480, 188)
        Me._Chk_6.Name = "_Chk_6"
        Me._Chk_6.Size = New System.Drawing.Size(17, 17)
        Me._Chk_6.TabIndex = 8
        Me._Chk_6.UseVisualStyleBackColor = False
        '
        '_Command_3
        '
        Me._Command_3.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(694, 152)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 15
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_Command_2
        '
        Me._Command_2.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Xoa
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(694, 88)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 13
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Save
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(694, 56)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 12
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_0
        '
        Me._Command_0.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Add
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(694, 24)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 11
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        '
        '_Command_4
        '
        Me._Command_4.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Chi_tiet
        Me._Command_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_4.Location = New System.Drawing.Point(694, 120)
        Me._Command_4.Name = "_Command_4"
        Me._Command_4.Size = New System.Drawing.Size(73, 25)
        Me._Command_4.TabIndex = 14
        Me._Command_4.Tag = "Detail"
        Me._Command_4.Text = "&Chi tiết"
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.Color.Black
        Me._Label_11.Location = New System.Drawing.Point(568, 8)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(49, 17)
        Me._Label_11.TabIndex = 27
        Me._Label_11.Tag = "Reports"
        Me._Label_11.Text = "Báo cáo"
        Me._Label_11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.Color.Black
        Me._Label_10.Location = New System.Drawing.Point(512, 8)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(57, 17)
        Me._Label_10.TabIndex = 26
        Me._Label_10.Tag = "Price"
        Me._Label_10.Text = "Giá thành"
        Me._Label_10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(416, 8)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(41, 17)
        Me._Label_7.TabIndex = 25
        Me._Label_7.Tag = "Tools"
        Me._Label_7.Text = "CCDC"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.Color.Black
        Me._Label_5.Location = New System.Drawing.Point(328, 8)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(50, 17)
        Me._Label_5.TabIndex = 24
        Me._Label_5.Tag = "Debt"
        Me._Label_5.Text = "Công nợ"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(288, 8)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(43, 17)
        Me._Label_4.TabIndex = 23
        Me._Label_4.Tag = "Costs"
        Me._Label_4.Text = "Chi phí"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.Black
        Me._Label_3.Location = New System.Drawing.Point(248, 8)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(41, 17)
        Me._Label_3.TabIndex = 22
        Me._Label_3.Tag = "Material"
        Me._Label_3.Text = "Vật tư"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.Color.Black
        Me._Label_0.Location = New System.Drawing.Point(8, 8)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(121, 17)
        Me._Label_0.TabIndex = 21
        Me._Label_0.Tag = "User Name"
        Me._Label_0.Text = "Người sử dụng"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(128, 8)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(65, 17)
        Me._Label_1.TabIndex = 20
        Me._Label_1.Tag = "Rights"
        Me._Label_1.Text = "Quyền"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.Black
        Me._Label_2.Location = New System.Drawing.Point(192, 8)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(57, 17)
        Me._Label_2.TabIndex = 19
        Me._Label_2.Tag = "Common"
        Me._Label_2.Text = "Tổng hợp"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.Color.Black
        Me._Label_6.Location = New System.Drawing.Point(376, 8)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(41, 17)
        Me._Label_6.TabIndex = 18
        Me._Label_6.Tag = "Common"
        Me._Label_6.Text = "TSCĐ"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.Color.Black
        Me._Label_8.Location = New System.Drawing.Point(456, 8)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(57, 17)
        Me._Label_8.TabIndex = 17
        Me._Label_8.Tag = "L-SI"
        Me._Label_8.Text = "LĐ-BHXH"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GrdNT
        '
        Me.GrdNT.AllowColumnResize = True
        Me.GrdNT.AllowMultiselect = False
        Me.GrdNT.AlternateBackground = System.Drawing.Color.DarkGreen
        Me.GrdNT.AlternatingColors = False
        Me.GrdNT.AutoHeight = True
        Me.GrdNT.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdNT.BackgroundStretchToFit = True
        Me.GrdNT.Col = 0
        Me.GrdNT.Cols = 0
        Me.GrdNT.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me.GrdNT.FullRowSelect = True
        Me.GrdNT.GridColor = System.Drawing.Color.LightGray
        Me.GrdNT.GridLines = ListViewEx.GLGridLines.gridBoth
        Me.GrdNT.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me.GrdNT.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me.GrdNT.HeaderHeight = 22
        Me.GrdNT.HeaderVisible = True
        Me.GrdNT.HeaderWordWrap = False
        Me.GrdNT.HotColumnTracking = False
        Me.GrdNT.HotItemTracking = False
        Me.GrdNT.HotTrackingColor = System.Drawing.Color.LightGray
        Me.GrdNT.HoverEvents = False
        Me.GrdNT.HoverTime = 1
        Me.GrdNT.ImageList = Nothing
        Me.GrdNT.ItemHeight = 18
        Me.GrdNT.ItemWordWrap = False
        Me.GrdNT.Location = New System.Drawing.Point(8, 24)
        Me.GrdNT.Name = "GrdNT"
        Me.GrdNT.Row = 0
        Me.GrdNT.Rows = 0
        Me.GrdNT.Selectable = True
        Me.GrdNT.SelectedTextColor = System.Drawing.Color.White
        Me.GrdNT.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.GrdNT.ShowBorder = True
        Me.GrdNT.ShowFocusRect = False
        Me.GrdNT.Size = New System.Drawing.Size(677, 161)
        Me.GrdNT.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdNT.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdNT.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(616, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 28
        Me.Label1.Tag = "Invoice"
        Me.Label1.Text = "In HD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Chk_9
        '
        Me._Chk_9.BackColor = System.Drawing.Color.Transparent
        Me._Chk_9.Checked = True
        Me._Chk_9.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Chk_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_9.Enabled = False
        Me._Chk_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Chk_9.Location = New System.Drawing.Point(637, 188)
        Me._Chk_9.Name = "_Chk_9"
        Me._Chk_9.Size = New System.Drawing.Size(17, 17)
        Me._Chk_9.TabIndex = 29
        Me._Chk_9.UseVisualStyleBackColor = False
        '
        'FrmUser3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(772, 212)
        Me.Controls.Add(Me._Chk_9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrdNT)
        Me.Controls.Add(Me._Chk_8)
        Me.Controls.Add(Me._Chk_7)
        Me.Controls.Add(Me.CboRight)
        Me.Controls.Add(Me.txtNhap)
        Me.Controls.Add(Me._Chk_0)
        Me.Controls.Add(Me._Chk_1)
        Me.Controls.Add(Me._Chk_2)
        Me.Controls.Add(Me._Chk_3)
        Me.Controls.Add(Me._Chk_4)
        Me.Controls.Add(Me._Chk_5)
        Me.Controls.Add(Me._Chk_6)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command_4)
        Me.Controls.Add(Me._Label_11)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_5)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_8)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUser3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "User List "
        Me.Text = "Danh sách người sử dụng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializeLabel()
		Me.Label(11) = _Label_11
		Me.Label(10) = _Label_10
		Me.Label(7) = _Label_7
		Me.Label(5) = _Label_5
		Me.Label(4) = _Label_4
		Me.Label(3) = _Label_3
		Me.Label(0) = _Label_0
		Me.Label(1) = _Label_1
		Me.Label(2) = _Label_2
		Me.Label(6) = _Label_6
		Me.Label(8) = _Label_8
	End Sub
	Sub InitializeCommand()
		Me.Command(3) = _Command_3
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
		Me.Command(4) = _Command_4
	End Sub
	Sub InitializeChk()
        Me.Chk(0) = _Chk_0
		Me.Chk(1) = _Chk_1
		Me.Chk(2) = _Chk_2
		Me.Chk(3) = _Chk_3
		Me.Chk(4) = _Chk_4
		Me.Chk(5) = _Chk_5
        Me.Chk(6) = _Chk_6
        Me.Chk(7) = _Chk_7
        Me.Chk(8) = _Chk_8
        Me.Chk(9) = _Chk_9
    End Sub
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents _Chk_9 As System.Windows.Forms.CheckBox
#End Region 
End Class
