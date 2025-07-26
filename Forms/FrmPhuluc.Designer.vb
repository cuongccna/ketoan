<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPhuluc
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializetxtVT()
		InitializeLine()
		InitializeLabel1()
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
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _txtVT_5 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_9 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_6 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_7 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_8 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_4 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_3 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_0 As System.Windows.Forms.TextBox
    Public WithEvents cboQuy As ComboBoxEx.ComboBoxExt
    Private WithEvents _Command1_3 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Command1_2 As System.Windows.Forms.Button
    Public WithEvents MedNgay As System.Windows.Forms.MaskedTextBox
    Private WithEvents _Line_7 As System.Windows.Forms.Label
    Private WithEvents _Line_6 As System.Windows.Forms.Label
    Private WithEvents _Label1_15 As System.Windows.Forms.Label
    Private WithEvents _Label1_14 As System.Windows.Forms.Label
    Private WithEvents _Label1_13 As System.Windows.Forms.Label
    Private WithEvents _Label1_12 As System.Windows.Forms.Label
    Private WithEvents _Line_5 As System.Windows.Forms.Label
    Private WithEvents _Line_4 As System.Windows.Forms.Label
    Private WithEvents _Line_3 As System.Windows.Forms.Label
    Private WithEvents _Label1_11 As System.Windows.Forms.Label
    Private WithEvents _Line_2 As System.Windows.Forms.Label
    Private WithEvents _Label1_10 As System.Windows.Forms.Label
    Private WithEvents _Line_1 As System.Windows.Forms.Label
    Private WithEvents _Label1_9 As System.Windows.Forms.Label
    Private WithEvents _Label1_8 As System.Windows.Forms.Label
    Private WithEvents _Label1_7 As System.Windows.Forms.Label
    Private WithEvents _Label1_6 As System.Windows.Forms.Label
    Private WithEvents _Line_0 As System.Windows.Forms.Label
    Private WithEvents _Label1_5 As System.Windows.Forms.Label
    Private WithEvents _Label1_4 As System.Windows.Forms.Label
    Private WithEvents _Label1_3 As System.Windows.Forms.Label
    Private WithEvents _Label1_1 As System.Windows.Forms.Label
    Private WithEvents _Label1_2 As System.Windows.Forms.Label
    Private WithEvents _Label1_0 As System.Windows.Forms.Label
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Public Command(3) As System.Windows.Forms.Button
    Public Command1(3) As System.Windows.Forms.Button
    Public Label(17) As System.Windows.Forms.Label
    Public Label1(15) As System.Windows.Forms.Label
    Public Line(7) As System.Windows.Forms.Label
    Public txtVT(9) As System.Windows.Forms.TextBox
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'Private listBoxComboBoxHelper1 As Artinsoft.VB6.Gui.ListControlHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPhuluc))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_3 = New System.Windows.Forms.Button()
        Me._Command_2 = New System.Windows.Forms.Button()
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._txtVT_5 = New System.Windows.Forms.TextBox()
        Me._txtVT_9 = New System.Windows.Forms.TextBox()
        Me._txtVT_6 = New System.Windows.Forms.TextBox()
        Me._txtVT_7 = New System.Windows.Forms.TextBox()
        Me._txtVT_8 = New System.Windows.Forms.TextBox()
        Me._txtVT_2 = New System.Windows.Forms.TextBox()
        Me._txtVT_1 = New System.Windows.Forms.TextBox()
        Me._txtVT_4 = New System.Windows.Forms.TextBox()
        Me._txtVT_3 = New System.Windows.Forms.TextBox()
        Me._txtVT_0 = New System.Windows.Forms.TextBox()
        Me.cboQuy = New ComboBoxEx.ComboBoxExt()
        Me._Command1_3 = New System.Windows.Forms.Button()
        Me._Command1_1 = New System.Windows.Forms.Button()
        Me._Command1_2 = New System.Windows.Forms.Button()
        Me.MedNgay = New System.Windows.Forms.MaskedTextBox()
        Me._Line_7 = New System.Windows.Forms.Label()
        Me._Line_6 = New System.Windows.Forms.Label()
        Me._Label1_15 = New System.Windows.Forms.Label()
        Me._Label1_14 = New System.Windows.Forms.Label()
        Me._Label1_13 = New System.Windows.Forms.Label()
        Me._Label1_12 = New System.Windows.Forms.Label()
        Me._Line_5 = New System.Windows.Forms.Label()
        Me._Line_4 = New System.Windows.Forms.Label()
        Me._Line_3 = New System.Windows.Forms.Label()
        Me._Label1_11 = New System.Windows.Forms.Label()
        Me._Line_2 = New System.Windows.Forms.Label()
        Me._Label1_10 = New System.Windows.Forms.Label()
        Me._Line_1 = New System.Windows.Forms.Label()
        Me._Label1_9 = New System.Windows.Forms.Label()
        Me._Label1_8 = New System.Windows.Forms.Label()
        Me._Label1_7 = New System.Windows.Forms.Label()
        Me._Label1_6 = New System.Windows.Forms.Label()
        Me._Line_0 = New System.Windows.Forms.Label()
        Me._Label1_5 = New System.Windows.Forms.Label()
        Me._Label1_4 = New System.Windows.Forms.Label()
        Me._Label1_3 = New System.Windows.Forms.Label()
        Me._Label1_1 = New System.Windows.Forms.Label()
        Me._Label1_2 = New System.Windows.Forms.Label()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me._Label_17 = New System.Windows.Forms.Label()
        Me._Label_5 = New System.Windows.Forms.Label()
        Me._Label_4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        '_Command_3
        '
        Me._Command_3.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(464, 688)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 34
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_Command_2
        '
        Me._Command_2.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Print
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(384, 688)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 35
        Me._Command_2.Tag = "Print"
        Me._Command_2.Text = "&In"
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Preview
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(304, 688)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 36
        Me._Command_1.Tag = "Preview"
        Me._Command_1.Text = "&Xem"
        '
        '_txtVT_5
        '
        Me._txtVT_5.AcceptsReturn = True
        Me._txtVT_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._txtVT_5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_5.Location = New System.Drawing.Point(288, 256)
        Me._txtVT_5.MaxLength = 100
        Me._txtVT_5.Name = "_txtVT_5"
        Me._txtVT_5.Size = New System.Drawing.Size(233, 19)
        Me._txtVT_5.TabIndex = 4
        Me._txtVT_5.Text = "0"
        '
        '_txtVT_9
        '
        Me._txtVT_9.AcceptsReturn = True
        Me._txtVT_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._txtVT_9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_9.Location = New System.Drawing.Point(168, 640)
        Me._txtVT_9.MaxLength = 100
        Me._txtVT_9.Name = "_txtVT_9"
        Me._txtVT_9.Size = New System.Drawing.Size(353, 19)
        Me._txtVT_9.TabIndex = 11
        Me._txtVT_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtVT_6
        '
        Me._txtVT_6.AcceptsReturn = True
        Me._txtVT_6.BackColor = System.Drawing.Color.LightCyan
        Me._txtVT_6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_6.Location = New System.Drawing.Point(351, 512)
        Me._txtVT_6.MaxLength = 2
        Me._txtVT_6.Name = "_txtVT_6"
        Me._txtVT_6.Size = New System.Drawing.Size(17, 19)
        Me._txtVT_6.TabIndex = 8
        Me._txtVT_6.Text = "00"
        Me._txtVT_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtVT_7
        '
        Me._txtVT_7.AcceptsReturn = True
        Me._txtVT_7.BackColor = System.Drawing.Color.LightCyan
        Me._txtVT_7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_7.Location = New System.Drawing.Point(407, 512)
        Me._txtVT_7.MaxLength = 2
        Me._txtVT_7.Name = "_txtVT_7"
        Me._txtVT_7.Size = New System.Drawing.Size(17, 19)
        Me._txtVT_7.TabIndex = 9
        Me._txtVT_7.Text = "00"
        Me._txtVT_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtVT_8
        '
        Me._txtVT_8.AcceptsReturn = True
        Me._txtVT_8.BackColor = System.Drawing.Color.LightCyan
        Me._txtVT_8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_8.Location = New System.Drawing.Point(459, 512)
        Me._txtVT_8.MaxLength = 4
        Me._txtVT_8.Name = "_txtVT_8"
        Me._txtVT_8.Size = New System.Drawing.Size(33, 19)
        Me._txtVT_8.TabIndex = 10
        Me._txtVT_8.Text = "0000"
        '
        '_txtVT_2
        '
        Me._txtVT_2.AcceptsReturn = True
        Me._txtVT_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._txtVT_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_2.Location = New System.Drawing.Point(104, 216)
        Me._txtVT_2.MaxLength = 100
        Me._txtVT_2.Name = "_txtVT_2"
        Me._txtVT_2.Size = New System.Drawing.Size(417, 19)
        Me._txtVT_2.TabIndex = 3
        Me._txtVT_2.Text = "..."
        '
        '_txtVT_1
        '
        Me._txtVT_1.AcceptsReturn = True
        Me._txtVT_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._txtVT_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_1.Location = New System.Drawing.Point(144, 192)
        Me._txtVT_1.MaxLength = 100
        Me._txtVT_1.Name = "_txtVT_1"
        Me._txtVT_1.Size = New System.Drawing.Size(377, 19)
        Me._txtVT_1.TabIndex = 2
        Me._txtVT_1.Text = "..."
        '
        '_txtVT_4
        '
        Me._txtVT_4.AcceptsReturn = True
        Me._txtVT_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._txtVT_4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_4.Location = New System.Drawing.Point(136, 400)
        Me._txtVT_4.MaxLength = 100
        Me._txtVT_4.Name = "_txtVT_4"
        Me._txtVT_4.Size = New System.Drawing.Size(385, 19)
        Me._txtVT_4.TabIndex = 6
        Me._txtVT_4.Text = "0"
        '
        '_txtVT_3
        '
        Me._txtVT_3.AcceptsReturn = True
        Me._txtVT_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me._txtVT_3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_3.Location = New System.Drawing.Point(288, 320)
        Me._txtVT_3.MaxLength = 100
        Me._txtVT_3.Name = "_txtVT_3"
        Me._txtVT_3.Size = New System.Drawing.Size(233, 19)
        Me._txtVT_3.TabIndex = 5
        Me._txtVT_3.Text = "0"
        '
        '_txtVT_0
        '
        Me._txtVT_0.AcceptsReturn = True
        Me._txtVT_0.BackColor = System.Drawing.Color.LightCyan
        Me._txtVT_0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_0.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_0.Location = New System.Drawing.Point(460, 151)
        Me._txtVT_0.MaxLength = 4
        Me._txtVT_0.Name = "_txtVT_0"
        Me._txtVT_0.Size = New System.Drawing.Size(33, 19)
        Me._txtVT_0.TabIndex = 1
        Me._txtVT_0.Text = "0000"
        '
        'cboQuy
        '
        Me.cboQuy.BackColor = System.Drawing.Color.LightCyan
        Me.cboQuy.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboQuy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboQuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuy.DropDownWidth = 31
        Me.cboQuy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQuy.Location = New System.Drawing.Point(379, 150)
        Me.cboQuy.Name = "cboQuy"
        Me.cboQuy.Size = New System.Drawing.Size(33, 23)
        Me.cboQuy.TabIndex = 0
        '
        '_Command1_3
        '
        Me._Command1_3.BackColor = System.Drawing.Color.Silver
        Me._Command1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_3.Image = CType(resources.GetObject("_Command1_3.Image"), System.Drawing.Image)
        Me._Command1_3.Location = New System.Drawing.Point(464, 688)
        Me._Command1_3.Name = "_Command1_3"
        Me._Command1_3.Size = New System.Drawing.Size(73, 25)
        Me._Command1_3.TabIndex = 14
        Me._Command1_3.TabStop = False
        Me._Command1_3.Tag = "&Return"
        Me._Command1_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_3.UseVisualStyleBackColor = False
        Me._Command1_3.Visible = False
        '
        '_Command1_1
        '
        Me._Command1_1.BackColor = System.Drawing.Color.Silver
        Me._Command1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_1.Image = CType(resources.GetObject("_Command1_1.Image"), System.Drawing.Image)
        Me._Command1_1.Location = New System.Drawing.Point(304, 688)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(73, 25)
        Me._Command1_1.TabIndex = 12
        Me._Command1_1.TabStop = False
        Me._Command1_1.Tag = "&View"
        Me._Command1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_1.UseVisualStyleBackColor = False
        Me._Command1_1.Visible = False
        '
        '_Command1_2
        '
        Me._Command1_2.BackColor = System.Drawing.Color.Silver
        Me._Command1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_2.Image = CType(resources.GetObject("_Command1_2.Image"), System.Drawing.Image)
        Me._Command1_2.Location = New System.Drawing.Point(384, 688)
        Me._Command1_2.Name = "_Command1_2"
        Me._Command1_2.Size = New System.Drawing.Size(73, 25)
        Me._Command1_2.TabIndex = 13
        Me._Command1_2.TabStop = False
        Me._Command1_2.Tag = "&Print"
        Me._Command1_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_2.UseVisualStyleBackColor = False
        Me._Command1_2.Visible = False
        '
        'MedNgay
        '
        Me.MedNgay.AllowPromptAsInput = False
        Me.MedNgay.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.MedNgay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MedNgay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedNgay.Location = New System.Drawing.Point(16, 460)
        Me.MedNgay.Name = "MedNgay"
        Me.MedNgay.Size = New System.Drawing.Size(81, 19)
        Me.MedNgay.TabIndex = 7
        '
        '_Line_7
        '
        Me._Line_7.Enabled = False
        Me._Line_7.Location = New System.Drawing.Point(288, 277)
        Me._Line_7.Name = "_Line_7"
        Me._Line_7.Size = New System.Drawing.Size(232, 1)
        Me._Line_7.TabIndex = 37
        '
        '_Line_6
        '
        Me._Line_6.Enabled = False
        Me._Line_6.Location = New System.Drawing.Point(168, 661)
        Me._Line_6.Name = "_Line_6"
        Me._Line_6.Size = New System.Drawing.Size(352, 1)
        Me._Line_6.TabIndex = 38
        '
        '_Label1_15
        '
        Me._Label1_15.BackColor = System.Drawing.Color.White
        Me._Label1_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_15.Location = New System.Drawing.Point(184, 600)
        Me._Label1_15.Name = "_Label1_15"
        Me._Label1_15.Size = New System.Drawing.Size(337, 25)
        Me._Label1_15.TabIndex = 33
        Me._Label1_15.Tag = "(Stamp, Sign & Full name)"
        Me._Label1_15.Text = "Ký tên, đóng dấu (ghi rõ họ tên và chức vụ)"
        Me._Label1_15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_14
        '
        Me._Label1_14.BackColor = System.Drawing.Color.White
        Me._Label1_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_14.Location = New System.Drawing.Point(168, 568)
        Me._Label1_14.Name = "_Label1_14"
        Me._Label1_14.Size = New System.Drawing.Size(353, 25)
        Me._Label1_14.TabIndex = 32
        Me._Label1_14.Tag = "LEGAL REPRESENTATIVE OF TAX PAYER"
        Me._Label1_14.Text = "ĐẠI DIỆN HỢP PHÁP CỦA NGƯỜI NỘP THUẾ"
        Me._Label1_14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_13
        '
        Me._Label1_13.BackColor = System.Drawing.Color.White
        Me._Label1_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_13.Location = New System.Drawing.Point(168, 544)
        Me._Label1_13.Name = "_Label1_13"
        Me._Label1_13.Size = New System.Drawing.Size(353, 25)
        Me._Label1_13.TabIndex = 31
        Me._Label1_13.Tag = "TAX PAYER OR"
        Me._Label1_13.Text = "NGƯỜI NỘP THUẾ HOẶC"
        Me._Label1_13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_12
        '
        Me._Label1_12.BackColor = System.Drawing.Color.White
        Me._Label1_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_12.Location = New System.Drawing.Point(168, 512)
        Me._Label1_12.Name = "_Label1_12"
        Me._Label1_12.Size = New System.Drawing.Size(353, 25)
        Me._Label1_12.TabIndex = 30
        Me._Label1_12.Tag = "Ho Chi Minh City,day      month     year"
        Me._Label1_12.Text = "TP.Hồ Chí Minh, ngày      tháng      năm      "
        Me._Label1_12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Line_5
        '
        Me._Line_5.Enabled = False
        Me._Line_5.Location = New System.Drawing.Point(104, 237)
        Me._Line_5.Name = "_Line_5"
        Me._Line_5.Size = New System.Drawing.Size(416, 1)
        Me._Line_5.TabIndex = 39
        '
        '_Line_4
        '
        Me._Line_4.Enabled = False
        Me._Line_4.Location = New System.Drawing.Point(144, 213)
        Me._Line_4.Name = "_Line_4"
        Me._Line_4.Size = New System.Drawing.Size(376, 1)
        Me._Line_4.TabIndex = 40
        '
        '_Line_3
        '
        Me._Line_3.Enabled = False
        Me._Line_3.Location = New System.Drawing.Point(16, 481)
        Me._Line_3.Name = "_Line_3"
        Me._Line_3.Size = New System.Drawing.Size(80, 1)
        Me._Line_3.TabIndex = 41
        '
        '_Label1_11
        '
        Me._Label1_11.BackColor = System.Drawing.Color.White
        Me._Label1_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_11.Location = New System.Drawing.Point(16, 440)
        Me._Label1_11.Name = "_Label1_11"
        Me._Label1_11.Size = New System.Drawing.Size(505, 25)
        Me._Label1_11.TabIndex = 29
        Me._Label1_11.Tag = "II/ Due of payment is extended under with Circular No.03/2009/TT-BTC : "
        Me._Label1_11.Text = "II/ Thời hạn nộp thuế được gia hạn theo Thông tư số 03/2009/TT-BTC:"
        '
        '_Line_2
        '
        Me._Line_2.Enabled = False
        Me._Line_2.Location = New System.Drawing.Point(136, 421)
        Me._Line_2.Name = "_Line_2"
        Me._Line_2.Size = New System.Drawing.Size(384, 1)
        Me._Line_2.TabIndex = 42
        '
        '_Label1_10
        '
        Me._Label1_10.BackColor = System.Drawing.Color.White
        Me._Label1_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_10.Location = New System.Drawing.Point(16, 360)
        Me._Label1_10.Name = "_Label1_10"
        Me._Label1_10.Size = New System.Drawing.Size(505, 65)
        Me._Label1_10.TabIndex = 28
        Me._Label1_10.Tag = "- Business income tax payable in the period =  Business income tax payable in pre" & _
            "vious after deducted the business income tax  is exempted under with the law (if" & _
            " any) x 70% ="
        Me._Label1_10.Text = "- Thuế TNDN còn phải nộp trong kỳ = thuế TNDN phải nộp trong kỳ sau khi trừ đi số" & _
            " thuế thuế TNDN được miễn giảm theo quy định của Luật (nếu có) x 70% ="
        '
        '_Line_1
        '
        Me._Line_1.Enabled = False
        Me._Line_1.Location = New System.Drawing.Point(288, 341)
        Me._Line_1.Name = "_Line_1"
        Me._Line_1.Size = New System.Drawing.Size(232, 1)
        Me._Line_1.TabIndex = 43
        '
        '_Label1_9
        '
        Me._Label1_9.BackColor = System.Drawing.Color.White
        Me._Label1_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_9.Location = New System.Drawing.Point(16, 280)
        Me._Label1_9.Name = "_Label1_9"
        Me._Label1_9.Size = New System.Drawing.Size(505, 65)
        Me._Label1_9.TabIndex = 27
        Me._Label1_9.Tag = "- Business income tax is reduced unders with Circular No.30/2008 = business incom" & _
            "e tax payable in previous period when deducted the business income tax is exemte" & _
            "d  under with law (if any) x 30% ="
        Me._Label1_9.Text = "- Thuế TNDN được giảm theo Nghị quyết CP số 30/2008 = thuế TNDN phải nộp trong kỳ" & _
            " sau khi đã trừ đi số thuế thuế TNDN được miễn giảm theo quy định của Luật (nếu " & _
            "có) x 30% ="
        '
        '_Label1_8
        '
        Me._Label1_8.BackColor = System.Drawing.Color.White
        Me._Label1_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_8.Location = New System.Drawing.Point(16, 256)
        Me._Label1_8.Name = "_Label1_8"
        Me._Label1_8.Size = New System.Drawing.Size(505, 25)
        Me._Label1_8.TabIndex = 26
        Me._Label1_8.Tag = "I/ Business income tax is reduced with rate 30% :"
        Me._Label1_8.Text = "I/ Số thuế TNDN được giảm 30%:"
        '
        '_Label1_7
        '
        Me._Label1_7.BackColor = System.Drawing.Color.White
        Me._Label1_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_7.Location = New System.Drawing.Point(16, 216)
        Me._Label1_7.Name = "_Label1_7"
        Me._Label1_7.Size = New System.Drawing.Size(81, 25)
        Me._Label1_7.TabIndex = 25
        Me._Label1_7.Tag = "Tax code :"
        Me._Label1_7.Text = "Mã số thuế:"
        '
        '_Label1_6
        '
        Me._Label1_6.BackColor = System.Drawing.Color.White
        Me._Label1_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_6.Location = New System.Drawing.Point(16, 192)
        Me._Label1_6.Name = "_Label1_6"
        Me._Label1_6.Size = New System.Drawing.Size(129, 25)
        Me._Label1_6.TabIndex = 24
        Me._Label1_6.Tag = "Enterprise name :"
        Me._Label1_6.Text = "Tên doanh nghiệp:"
        '
        '_Line_0
        '
        Me._Line_0.Enabled = False
        Me._Line_0.Location = New System.Drawing.Point(464, 172)
        Me._Line_0.Name = "_Line_0"
        Me._Line_0.Size = New System.Drawing.Size(32, 1)
        Me._Line_0.TabIndex = 44
        '
        '_Label1_5
        '
        Me._Label1_5.BackColor = System.Drawing.Color.White
        Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_5.Location = New System.Drawing.Point(16, 152)
        Me._Label1_5.Name = "_Label1_5"
        Me._Label1_5.Size = New System.Drawing.Size(505, 25)
        Me._Label1_5.TabIndex = 23
        Me._Label1_5.Tag = "TOGETHER WITH INC-TAX RETURN:           YEAR"
        Me._Label1_5.Text = "KÈM THEO TỜ KHAI THUẾ TNDN QUÝ:         NĂM"
        Me._Label1_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_4
        '
        Me._Label1_4.BackColor = System.Drawing.Color.White
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_4.Location = New System.Drawing.Point(16, 128)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.Size = New System.Drawing.Size(505, 25)
        Me._Label1_4.TabIndex = 22
        Me._Label1_4.Tag = "UNDER CIRCULAR NO. 03/2009/TT-BTC"
        Me._Label1_4.Text = "THÔNG TƯ SỐ 03/2009/TT-BTC"
        Me._Label1_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_3
        '
        Me._Label1_3.BackColor = System.Drawing.Color.White
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_3.Location = New System.Drawing.Point(16, 104)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.Size = New System.Drawing.Size(505, 25)
        Me._Label1_3.TabIndex = 21
        Me._Label1_3.Tag = "DETERMINING THE CORPORATE INCOME TAX REDUCTION AND EXTENSION "
        Me._Label1_3.Text = "XÁC ĐỊNH SỐ THUẾ TNDN ĐƯỢC GIẢM VÀ GIA HẠN THEO"
        Me._Label1_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.Color.White
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(16, 40)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.Size = New System.Drawing.Size(505, 25)
        Me._Label1_1.TabIndex = 19
        Me._Label1_1.Tag = "(Accompanied with Document No. 2987/CT-TTHT"
        Me._Label1_1.Text = "(Ban hành kèm theo văn bản số 2987/CT-TTHT"
        Me._Label1_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_2
        '
        Me._Label1_2.BackColor = System.Drawing.Color.White
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(16, 64)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.Size = New System.Drawing.Size(505, 25)
        Me._Label1_2.TabIndex = 20
        Me._Label1_2.Tag = "day 22 month 04 year 2009"
        Me._Label1_2.Text = "ngày 22 tháng 04 năm 2009)"
        Me._Label1_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.Color.White
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(16, 16)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.Size = New System.Drawing.Size(505, 25)
        Me._Label1_0.TabIndex = 15
        Me._Label1_0.Tag = "APPENDIX"
        Me._Label1_0.Text = "PHỤ LỤC"
        Me._Label1_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.Color.White
        Me._Label_17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.Location = New System.Drawing.Point(8, 8)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(521, 665)
        Me._Label_17.TabIndex = 16
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.White
        Me._Label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.Location = New System.Drawing.Point(12, 12)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(521, 665)
        Me._Label_5.TabIndex = 17
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.White
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.Location = New System.Drawing.Point(16, 16)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(521, 665)
        Me._Label_4.TabIndex = 18
        '
        'FrmPhuluc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 721)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._txtVT_5)
        Me.Controls.Add(Me._txtVT_9)
        Me.Controls.Add(Me._txtVT_6)
        Me.Controls.Add(Me._txtVT_7)
        Me.Controls.Add(Me._txtVT_8)
        Me.Controls.Add(Me._txtVT_2)
        Me.Controls.Add(Me._txtVT_1)
        Me.Controls.Add(Me._txtVT_4)
        Me.Controls.Add(Me._txtVT_3)
        Me.Controls.Add(Me._txtVT_0)
        Me.Controls.Add(Me.cboQuy)
        Me.Controls.Add(Me._Command1_3)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Command1_2)
        Me.Controls.Add(Me.MedNgay)
        Me.Controls.Add(Me._Line_7)
        Me.Controls.Add(Me._Line_6)
        Me.Controls.Add(Me._Label1_15)
        Me.Controls.Add(Me._Label1_14)
        Me.Controls.Add(Me._Label1_13)
        Me.Controls.Add(Me._Label1_12)
        Me.Controls.Add(Me._Line_5)
        Me.Controls.Add(Me._Line_4)
        Me.Controls.Add(Me._Line_3)
        Me.Controls.Add(Me._Label1_11)
        Me.Controls.Add(Me._Line_2)
        Me.Controls.Add(Me._Label1_10)
        Me.Controls.Add(Me._Line_1)
        Me.Controls.Add(Me._Label1_9)
        Me.Controls.Add(Me._Label1_8)
        Me.Controls.Add(Me._Label1_7)
        Me.Controls.Add(Me._Label1_6)
        Me.Controls.Add(Me._Line_0)
        Me.Controls.Add(Me._Label1_5)
        Me.Controls.Add(Me._Label1_4)
        Me.Controls.Add(Me._Label1_3)
        Me.Controls.Add(Me._Label1_1)
        Me.Controls.Add(Me._Label1_2)
        Me.Controls.Add(Me._Label1_0)
        Me.Controls.Add(Me._Label_17)
        Me.Controls.Add(Me._Label_5)
        Me.Controls.Add(Me._Label_4)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPhuluc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Appendix"
        Me.Text = "Phụ lục"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializetxtVT()
		Me.txtVT(5) = _txtVT_5
		Me.txtVT(9) = _txtVT_9
		Me.txtVT(6) = _txtVT_6
		Me.txtVT(7) = _txtVT_7
		Me.txtVT(8) = _txtVT_8
		Me.txtVT(2) = _txtVT_2
		Me.txtVT(1) = _txtVT_1
		Me.txtVT(4) = _txtVT_4
		Me.txtVT(3) = _txtVT_3
		Me.txtVT(0) = _txtVT_0
	End Sub
	Sub InitializeLine()
		Me.Line(7) = _Line_7
		Me.Line(6) = _Line_6
		Me.Line(5) = _Line_5
		Me.Line(4) = _Line_4
		Me.Line(3) = _Line_3
		Me.Line(2) = _Line_2
		Me.Line(1) = _Line_1
		Me.Line(0) = _Line_0
	End Sub
	Sub InitializeLabel1()
		Me.Label1(15) = _Label1_15
		Me.Label1(14) = _Label1_14
		Me.Label1(13) = _Label1_13
		Me.Label1(12) = _Label1_12
		Me.Label1(11) = _Label1_11
		Me.Label1(10) = _Label1_10
		Me.Label1(9) = _Label1_9
		Me.Label1(8) = _Label1_8
		Me.Label1(7) = _Label1_7
		Me.Label1(6) = _Label1_6
		Me.Label1(5) = _Label1_5
		Me.Label1(4) = _Label1_4
		Me.Label1(3) = _Label1_3
		Me.Label1(1) = _Label1_1
		Me.Label1(2) = _Label1_2
		Me.Label1(0) = _Label1_0
	End Sub
	Sub InitializeLabel()
		Me.Label(17) = _Label_17
		Me.Label(5) = _Label_5
		Me.Label(4) = _Label_4
	End Sub
	Sub InitializeCommand1()
		Me.Command1(3) = _Command1_3
		Me.Command1(1) = _Command1_1
		Me.Command1(2) = _Command1_2
	End Sub
	Sub InitializeCommand()
		Me.Command(3) = _Command_3
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
	End Sub
#End Region 
End Class
