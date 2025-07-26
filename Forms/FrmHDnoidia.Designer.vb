<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHDnoidia
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializetxtNhap()
		InitializeMedNgay()
		InitializeLabel()
		InitializeCommand1()
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
	Private WithEvents _txtNhap_1 As System.Windows.Forms.TextBox
	Private WithEvents _txtNhap_4 As System.Windows.Forms.TextBox
	Private WithEvents _txtNhap_5 As System.Windows.Forms.TextBox
	Private WithEvents _MedNgay_1 As System.Windows.Forms.MaskedTextBox
	Private WithEvents _Label_2 As System.Windows.Forms.Label
	Private WithEvents _Label_4 As System.Windows.Forms.Label
	Private WithEvents _Label_5 As System.Windows.Forms.Label
	Private WithEvents _Label_7 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents GrdNT  As ListviewEx.ListviewExt 
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _txtNhap_6 As System.Windows.Forms.TextBox
    Private WithEvents _txtNhap_3 As System.Windows.Forms.TextBox
    Private WithEvents _txtNhap_2 As System.Windows.Forms.TextBox
    Private WithEvents _Command1_3 As System.Windows.Forms.Button
    Private WithEvents _Command1_2 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Private WithEvents _txtNhap_0 As System.Windows.Forms.TextBox
    Private WithEvents _MedNgay_0 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Public Command(3) As System.Windows.Forms.Button
    Public Command1(3) As System.Windows.Forms.Button
    Public Label(8) As System.Windows.Forms.Label
    Public MedNgay(1) As System.Windows.Forms.MaskedTextBox
    Public txtNhap(6) As System.Windows.Forms.TextBox
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHDnoidia))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me._txtNhap_1 = New System.Windows.Forms.TextBox
        Me._txtNhap_4 = New System.Windows.Forms.TextBox
        Me._txtNhap_5 = New System.Windows.Forms.TextBox
        Me._MedNgay_1 = New System.Windows.Forms.MaskedTextBox
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Label_5 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._txtNhap_6 = New System.Windows.Forms.TextBox
        Me._txtNhap_3 = New System.Windows.Forms.TextBox
        Me._txtNhap_2 = New System.Windows.Forms.TextBox
        Me._Command1_3 = New System.Windows.Forms.Button
        Me._Command1_2 = New System.Windows.Forms.Button
        Me._Command1_1 = New System.Windows.Forms.Button
        Me._Command1_0 = New System.Windows.Forms.Button
        Me._txtNhap_0 = New System.Windows.Forms.TextBox
        Me._MedNgay_0 = New System.Windows.Forms.MaskedTextBox
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me.GrdNT = New ListViewEx.ListviewExt
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me._txtNhap_1)
        Me.Frame1.Controls.Add(Me._txtNhap_4)
        Me.Frame1.Controls.Add(Me._txtNhap_5)
        Me.Frame1.Controls.Add(Me._MedNgay_1)
        Me.Frame1.Controls.Add(Me._Label_2)
        Me.Frame1.Controls.Add(Me._Label_4)
        Me.Frame1.Controls.Add(Me._Label_5)
        Me.Frame1.Controls.Add(Me._Label_7)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 432)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(73, 25)
        Me.Frame1.TabIndex = 19
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Frame1"
        Me.Frame1.Visible = False
        '
        '_txtNhap_1
        '
        Me._txtNhap_1.AcceptsReturn = True
        Me._txtNhap_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_1.Location = New System.Drawing.Point(0, 32)
        Me._txtNhap_1.MaxLength = 50
        Me._txtNhap_1.Name = "_txtNhap_1"
        Me._txtNhap_1.Size = New System.Drawing.Size(129, 20)
        Me._txtNhap_1.TabIndex = 22
        Me._txtNhap_1.Text = "..."
        Me._txtNhap_1.Visible = False
        '
        '_txtNhap_4
        '
        Me._txtNhap_4.AcceptsReturn = True
        Me._txtNhap_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_4.Location = New System.Drawing.Point(136, 32)
        Me._txtNhap_4.MaxLength = 20
        Me._txtNhap_4.Multiline = True
        Me._txtNhap_4.Name = "_txtNhap_4"
        Me._txtNhap_4.Size = New System.Drawing.Size(113, 19)
        Me._txtNhap_4.TabIndex = 21
        Me._txtNhap_4.Tag = "0"
        Me._txtNhap_4.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._txtNhap_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._txtNhap_4.Visible = False
        '
        '_txtNhap_5
        '
        Me._txtNhap_5.AcceptsReturn = True
        Me._txtNhap_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_5.Location = New System.Drawing.Point(256, 32)
        Me._txtNhap_5.MaxLength = 20
        Me._txtNhap_5.Name = "_txtNhap_5"
        Me._txtNhap_5.Size = New System.Drawing.Size(73, 20)
        Me._txtNhap_5.TabIndex = 20
        Me._txtNhap_5.Tag = "0"
        Me._txtNhap_5.Text = "..."
        Me._txtNhap_5.Visible = False
        '
        '_MedNgay_1
        '
        Me._MedNgay_1.AllowPromptAsInput = False
        Me._MedNgay_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_1.Location = New System.Drawing.Point(336, 32)
        Me._MedNgay_1.Mask = "00/00/0000"
        Me._MedNgay_1.Name = "_MedNgay_1"
        Me._MedNgay_1.Size = New System.Drawing.Size(65, 20)
        Me._MedNgay_1.TabIndex = 23
        Me._MedNgay_1.Visible = False
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.Teal
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.White
        Me._Label_2.Location = New System.Drawing.Point(0, 16)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(129, 17)
        Me._Label_2.TabIndex = 27
        Me._Label_2.Tag = "Description"
        Me._Label_2.Text = "Số hợp đồng"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_2.Visible = False
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.Teal
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.White
        Me._Label_4.Location = New System.Drawing.Point(136, 16)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(113, 17)
        Me._Label_4.TabIndex = 26
        Me._Label_4.Tag = "Value"
        Me._Label_4.Text = "Giá trị HĐ"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_4.Visible = False
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.Teal
        Me._Label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.Color.White
        Me._Label_5.Location = New System.Drawing.Point(256, 16)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(73, 17)
        Me._Label_5.TabIndex = 25
        Me._Label_5.Tag = "Notes"
        Me._Label_5.Text = "Ghi chú"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_5.Visible = False
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.Teal
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.White
        Me._Label_7.Location = New System.Drawing.Point(336, 16)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(65, 17)
        Me._Label_7.TabIndex = 24
        Me._Label_7.Tag = "Date"
        Me._Label_7.Text = "Ngày ký HD"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_7.Visible = False
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(417, 432)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 18
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &vể"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(337, 432)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 17
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(257, 432)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 16
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.add16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(177, 432)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 15
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        '
        '_txtNhap_6
        '
        Me._txtNhap_6.AcceptsReturn = True
        Me._txtNhap_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_6.Location = New System.Drawing.Point(424, 405)
        Me._txtNhap_6.MaxLength = 2
        Me._txtNhap_6.Multiline = True
        Me._txtNhap_6.Name = "_txtNhap_6"
        Me._txtNhap_6.Size = New System.Drawing.Size(47, 19)
        Me._txtNhap_6.TabIndex = 4
        Me._txtNhap_6.Tag = "0"
        Me._txtNhap_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtNhap_3
        '
        Me._txtNhap_3.AcceptsReturn = True
        Me._txtNhap_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_3.Location = New System.Drawing.Point(248, 404)
        Me._txtNhap_3.MaxLength = 50
        Me._txtNhap_3.Name = "_txtNhap_3"
        Me._txtNhap_3.ReadOnly = True
        Me._txtNhap_3.Size = New System.Drawing.Size(177, 20)
        Me._txtNhap_3.TabIndex = 3
        Me._txtNhap_3.TabStop = False
        Me._txtNhap_3.Tag = "0"
        Me._txtNhap_3.Text = "..."
        '
        '_txtNhap_2
        '
        Me._txtNhap_2.AcceptsReturn = True
        Me._txtNhap_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_2.Location = New System.Drawing.Point(152, 404)
        Me._txtNhap_2.MaxLength = 20
        Me._txtNhap_2.Name = "_txtNhap_2"
        Me._txtNhap_2.Size = New System.Drawing.Size(97, 20)
        Me._txtNhap_2.TabIndex = 2
        Me._txtNhap_2.Tag = "0"
        Me._txtNhap_2.Text = "..."
        '
        '_Command1_3
        '
        Me._Command1_3.BackColor = System.Drawing.Color.Silver
        Me._Command1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_3.Image = CType(resources.GetObject("_Command1_3.Image"), System.Drawing.Image)
        Me._Command1_3.Location = New System.Drawing.Point(416, 432)
        Me._Command1_3.Name = "_Command1_3"
        Me._Command1_3.Size = New System.Drawing.Size(73, 25)
        Me._Command1_3.TabIndex = 7
        Me._Command1_3.TabStop = False
        Me._Command1_3.Tag = "&Return"
        Me._Command1_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_3.UseVisualStyleBackColor = False
        Me._Command1_3.Visible = False
        '
        '_Command1_2
        '
        Me._Command1_2.BackColor = System.Drawing.Color.Silver
        Me._Command1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_2.Image = CType(resources.GetObject("_Command1_2.Image"), System.Drawing.Image)
        Me._Command1_2.Location = New System.Drawing.Point(336, 432)
        Me._Command1_2.Name = "_Command1_2"
        Me._Command1_2.Size = New System.Drawing.Size(73, 25)
        Me._Command1_2.TabIndex = 8
        Me._Command1_2.TabStop = False
        Me._Command1_2.Tag = "&DELETE"
        Me._Command1_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_2.UseVisualStyleBackColor = False
        Me._Command1_2.Visible = False
        '
        '_Command1_1
        '
        Me._Command1_1.BackColor = System.Drawing.Color.Silver
        Me._Command1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_1.Image = CType(resources.GetObject("_Command1_1.Image"), System.Drawing.Image)
        Me._Command1_1.Location = New System.Drawing.Point(256, 432)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(73, 25)
        Me._Command1_1.TabIndex = 5
        Me._Command1_1.TabStop = False
        Me._Command1_1.Tag = "&Save"
        Me._Command1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_1.UseVisualStyleBackColor = False
        Me._Command1_1.Visible = False
        '
        '_Command1_0
        '
        Me._Command1_0.BackColor = System.Drawing.Color.Silver
        Me._Command1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_0.Image = CType(resources.GetObject("_Command1_0.Image"), System.Drawing.Image)
        Me._Command1_0.Location = New System.Drawing.Point(176, 432)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(73, 25)
        Me._Command1_0.TabIndex = 6
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&Add"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        '_txtNhap_0
        '
        Me._txtNhap_0.AcceptsReturn = True
        Me._txtNhap_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_0.Location = New System.Drawing.Point(8, 404)
        Me._txtNhap_0.MaxLength = 20
        Me._txtNhap_0.Name = "_txtNhap_0"
        Me._txtNhap_0.Size = New System.Drawing.Size(89, 20)
        Me._txtNhap_0.TabIndex = 0
        Me._txtNhap_0.Text = "..."
        '
        '_MedNgay_0
        '
        Me._MedNgay_0.AllowPromptAsInput = False
        Me._MedNgay_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_0.Location = New System.Drawing.Point(96, 404)
        Me._MedNgay_0.Mask = "00/00/0000"
        Me._MedNgay_0.Name = "_MedNgay_0"
        Me._MedNgay_0.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_0.TabIndex = 1
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.Color.Black
        Me._Label_8.Location = New System.Drawing.Point(424, 8)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(65, 17)
        Me._Label_8.TabIndex = 14
        Me._Label_8.Tag = "Month"
        Me._Label_8.Text = "Tháng nhập"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.Color.Black
        Me._Label_6.Location = New System.Drawing.Point(248, 8)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(177, 17)
        Me._Label_6.TabIndex = 13
        Me._Label_6.Tag = "Name"
        Me._Label_6.Text = "Tên Khách hàng"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.Black
        Me._Label_3.Location = New System.Drawing.Point(152, 8)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(97, 17)
        Me._Label_3.TabIndex = 12
        Me._Label_3.Tag = "Company"
        Me._Label_3.Text = "Mã KH"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(96, 8)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(57, 17)
        Me._Label_1.TabIndex = 10
        Me._Label_1.Tag = "Date"
        Me._Label_1.Text = "Ngày HD"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me._Label_0.Size = New System.Drawing.Size(89, 17)
        Me._Label_0.TabIndex = 9
        Me._Label_0.Tag = "Contract Code"
        Me._Label_0.Text = "Số hoá đơn"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.GrdNT.Size = New System.Drawing.Size(481, 382)
        Me.GrdNT.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdNT.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdNT.TabIndex = 10
        '
        'FrmHDnoidia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(498, 464)
        Me.Controls.Add(Me.GrdNT)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._txtNhap_6)
        Me.Controls.Add(Me._txtNhap_3)
        Me.Controls.Add(Me._txtNhap_2)
        Me.Controls.Add(Me._Command1_3)
        Me.Controls.Add(Me._Command1_2)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me._txtNhap_0)
        Me.Controls.Add(Me._MedNgay_0)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(4, 70)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmHDnoidia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Contract List"
        Me.Text = "Danh sách Hợp đồng kinh tế"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializetxtNhap()
		Me.txtNhap(1) = _txtNhap_1
		Me.txtNhap(4) = _txtNhap_4
		Me.txtNhap(5) = _txtNhap_5
		Me.txtNhap(6) = _txtNhap_6
		Me.txtNhap(3) = _txtNhap_3
		Me.txtNhap(2) = _txtNhap_2
		Me.txtNhap(0) = _txtNhap_0
	End Sub
	Sub InitializeMedNgay()
		Me.MedNgay(1) = _MedNgay_1
		Me.MedNgay(0) = _MedNgay_0
	End Sub
	Sub InitializeLabel()
		Me.Label(2) = _Label_2
		Me.Label(4) = _Label_4
		Me.Label(5) = _Label_5
		Me.Label(7) = _Label_7
		Me.Label(8) = _Label_8
		Me.Label(6) = _Label_6
		Me.Label(3) = _Label_3
		Me.Label(1) = _Label_1
		Me.Label(0) = _Label_0
	End Sub
	Sub InitializeCommand1()
		Me.Command1(3) = _Command1_3
		Me.Command1(2) = _Command1_2
		Me.Command1(1) = _Command1_1
		Me.Command1(0) = _Command1_0
	End Sub
	Sub InitializeCommand()
		Me.Command(3) = _Command_3
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
#End Region 
End Class
