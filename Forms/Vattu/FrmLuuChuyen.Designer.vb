<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLuuChuyen
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializetxtChuyen()
		InitializeLbTT()
		InitializeLabel()
		InitializeCommand1()
		InitializeCommand()
		InitializeCboVV()
		InitializeCboKho()
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
	Public WithEvents GrdChuyen  As ListviewEx.ListviewExt 
	Private WithEvents _txtChuyen_4 As System.Windows.Forms.TextBox
	Private WithEvents _txtChuyen_2 As System.Windows.Forms.TextBox
    Private WithEvents _Command_4 As System.Windows.Forms.Button
    Private WithEvents SimpleButton1 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command1_5 As System.Windows.Forms.Button
    Private WithEvents _CboVV_2 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboVV_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboVV_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _txtChuyen_9 As System.Windows.Forms.TextBox
    Public WithEvents CboDV As ComboBoxEx.ComboBoxExt
    Private WithEvents _txtChuyen_8 As System.Windows.Forms.TextBox
    Public WithEvents Cbo As ComboBoxEx.ComboBoxExt
    Private WithEvents _txtChuyen_7 As System.Windows.Forms.TextBox
    Private WithEvents _txtChuyen_6 As System.Windows.Forms.TextBox
    Private WithEvents _Command1_4 As System.Windows.Forms.Button
    Private WithEvents _txtChuyen_5 As System.Windows.Forms.TextBox
    Private WithEvents _Command1_3 As System.Windows.Forms.Button
    Private WithEvents _Command1_2 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Public WithEvents cmdct As System.Windows.Forms.Button
    Public WithEvents CboSohieu As ComboBoxEx.ComboBoxExt
    Private WithEvents _txtChuyen_3 As System.Windows.Forms.TextBox
    Private WithEvents _txtChuyen_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtChuyen_0 As System.Windows.Forms.TextBox
    Private WithEvents _CboKho_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboKho_0 As ComboBoxEx.ComboBoxExt
    Public WithEvents MedNgay As System.Windows.Forms.MaskedTextBox
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _LbTT_0 As System.Windows.Forms.Label
    Private WithEvents _LbTT_1 As System.Windows.Forms.Label
    Private WithEvents _LbTT_2 As System.Windows.Forms.Label
    Private WithEvents _Label_16 As System.Windows.Forms.Label
    Public WithEvents LbUser As System.Windows.Forms.Label
    Private WithEvents _Label_15 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Public WithEvents LbTien As System.Windows.Forms.Label
    Private WithEvents _Label_9 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Public CboKho(1) As ComboBoxEx.ComboBoxExt
    Public CboVV(2) As ComboBoxEx.ComboBoxExt
    Public Command(5) As System.Windows.Forms.Button
    Public Command1(5) As System.Windows.Forms.Button
    Public Label(16) As System.Windows.Forms.Label
    Public LbTT(2) As System.Windows.Forms.Label
    Public txtChuyen(16) As System.Windows.Forms.TextBox
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLuuChuyen))
        Me._txtChuyen_4 = New System.Windows.Forms.TextBox
        Me._txtChuyen_2 = New System.Windows.Forms.TextBox
        Me._Command_4 = New System.Windows.Forms.Button
        Me.SimpleButton1 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Command1_5 = New System.Windows.Forms.Button
        Me._CboVV_2 = New ComboBoxEx.ComboBoxExt
        Me._CboVV_0 = New ComboBoxEx.ComboBoxExt
        Me._CboVV_1 = New ComboBoxEx.ComboBoxExt
        Me._txtChuyen_9 = New System.Windows.Forms.TextBox
        Me.CboDV = New ComboBoxEx.ComboBoxExt
        Me._txtChuyen_8 = New System.Windows.Forms.TextBox
        Me.Cbo = New ComboBoxEx.ComboBoxExt
        Me._txtChuyen_7 = New System.Windows.Forms.TextBox
        Me._txtChuyen_6 = New System.Windows.Forms.TextBox
        Me._Command1_4 = New System.Windows.Forms.Button
        Me._txtChuyen_5 = New System.Windows.Forms.TextBox
        Me._Command1_3 = New System.Windows.Forms.Button
        Me._Command1_2 = New System.Windows.Forms.Button
        Me._Command1_1 = New System.Windows.Forms.Button
        Me._Command1_0 = New System.Windows.Forms.Button
        Me.cmdct = New System.Windows.Forms.Button
        Me.CboSohieu = New ComboBoxEx.ComboBoxExt
        Me._txtChuyen_3 = New System.Windows.Forms.TextBox
        Me._txtChuyen_1 = New System.Windows.Forms.TextBox
        Me._txtChuyen_0 = New System.Windows.Forms.TextBox
        Me._CboKho_1 = New ComboBoxEx.ComboBoxExt
        Me._CboKho_0 = New ComboBoxEx.ComboBoxExt
        Me.MedNgay = New System.Windows.Forms.MaskedTextBox
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._LbTT_0 = New System.Windows.Forms.Label
        Me._LbTT_1 = New System.Windows.Forms.Label
        Me._LbTT_2 = New System.Windows.Forms.Label
        Me._Label_16 = New System.Windows.Forms.Label
        Me.LbUser = New System.Windows.Forms.Label
        Me._Label_15 = New System.Windows.Forms.Label
        Me._Label_14 = New System.Windows.Forms.Label
        Me._Label_13 = New System.Windows.Forms.Label
        Me._Label_11 = New System.Windows.Forms.Label
        Me._Label_12 = New System.Windows.Forms.Label
        Me._Label_10 = New System.Windows.Forms.Label
        Me.LbTien = New System.Windows.Forms.Label
        Me._Label_9 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Label_5 = New System.Windows.Forms.Label
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me.GrdChuyen = New ListViewEx.ListviewExt
        Me._txtChuyen_10 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me._txtChuyen_12 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me._txtChuyen_13 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me._txtChuyen_15 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.MedNgayDL = New System.Windows.Forms.MaskedTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me._txtChuyen_16 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me._txtChuyen_11 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me._txtChuyen_14 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me._Command_5 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        '_txtChuyen_4
        '
        Me._txtChuyen_4.AcceptsReturn = True
        Me._txtChuyen_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_4.Location = New System.Drawing.Point(320, 471)
        Me._txtChuyen_4.MaxLength = 20
        Me._txtChuyen_4.Multiline = True
        Me._txtChuyen_4.Name = "_txtChuyen_4"
        Me._txtChuyen_4.Size = New System.Drawing.Size(65, 21)
        Me._txtChuyen_4.TabIndex = 19
        Me._txtChuyen_4.Tag = "0"
        Me._txtChuyen_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtChuyen_2
        '
        Me._txtChuyen_2.AcceptsReturn = True
        Me._txtChuyen_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_2.Location = New System.Drawing.Point(152, 471)
        Me._txtChuyen_2.MaxLength = 50
        Me._txtChuyen_2.Name = "_txtChuyen_2"
        Me._txtChuyen_2.Size = New System.Drawing.Size(121, 20)
        Me._txtChuyen_2.TabIndex = 16
        Me._txtChuyen_2.TabStop = False
        '
        '_Command_4
        '
        Me._Command_4.Image = Global.UNET.My.Resources.Resources.report16
        Me._Command_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_4.Location = New System.Drawing.Point(256, 501)
        Me._Command_4.Name = "_Command_4"
        Me._Command_4.Size = New System.Drawing.Size(73, 25)
        Me._Command_4.TabIndex = 26
        Me._Command_4.Tag = "Preview"
        Me._Command_4.Text = "&Xem"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SimpleButton1.Location = New System.Drawing.Point(177, 501)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(73, 25)
        Me.SimpleButton1.TabIndex = 25
        Me.SimpleButton1.Text = "&Barcode"
        Me.SimpleButton1.Visible = False
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(496, 501)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 28
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(576, 501)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 29
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(416, 501)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 24
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.add16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(336, 501)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 27
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        '
        '_Command1_5
        '
        Me._Command1_5.BackColor = System.Drawing.SystemColors.Control
        Me._Command1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_5.Location = New System.Drawing.Point(177, 501)
        Me._Command1_5.Name = "_Command1_5"
        Me._Command1_5.Size = New System.Drawing.Size(73, 25)
        Me._Command1_5.TabIndex = 48
        Me._Command1_5.TabStop = False
        Me._Command1_5.Tag = "&Print"
        Me._Command1_5.Text = "&Barcode"
        Me._Command1_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_5.UseVisualStyleBackColor = False
        Me._Command1_5.Visible = False
        '
        '_CboVV_2
        '
        Me._CboVV_2.BackColor = System.Drawing.SystemColors.Window
        Me._CboVV_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboVV_2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboVV_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboVV_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboVV_2.Location = New System.Drawing.Point(488, 141)
        Me._CboVV_2.Name = "_CboVV_2"
        Me._CboVV_2.Size = New System.Drawing.Size(145, 21)
        Me._CboVV_2.TabIndex = 42
        Me._CboVV_2.Visible = False
        '
        '_CboVV_0
        '
        Me._CboVV_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboVV_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboVV_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboVV_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboVV_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboVV_0.Location = New System.Drawing.Point(64, 141)
        Me._CboVV_0.Name = "_CboVV_0"
        Me._CboVV_0.Size = New System.Drawing.Size(145, 21)
        Me._CboVV_0.TabIndex = 44
        Me._CboVV_0.Visible = False
        '
        '_CboVV_1
        '
        Me._CboVV_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboVV_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboVV_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboVV_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboVV_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboVV_1.Location = New System.Drawing.Point(280, 141)
        Me._CboVV_1.Name = "_CboVV_1"
        Me._CboVV_1.Size = New System.Drawing.Size(145, 21)
        Me._CboVV_1.TabIndex = 43
        Me._CboVV_1.Visible = False
        '
        '_txtChuyen_9
        '
        Me._txtChuyen_9.AcceptsReturn = True
        Me._txtChuyen_9.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_9.Location = New System.Drawing.Point(631, 471)
        Me._txtChuyen_9.MaxLength = 20
        Me._txtChuyen_9.Multiline = True
        Me._txtChuyen_9.Name = "_txtChuyen_9"
        Me._txtChuyen_9.Size = New System.Drawing.Size(81, 20)
        Me._txtChuyen_9.TabIndex = 23
        Me._txtChuyen_9.TabStop = False
        Me._txtChuyen_9.Tag = "0"
        Me._txtChuyen_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._txtChuyen_9.Visible = False
        '
        'CboDV
        '
        Me.CboDV.BackColor = System.Drawing.SystemColors.Window
        Me.CboDV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboDV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDV.Location = New System.Drawing.Point(272, 471)
        Me.CboDV.Name = "CboDV"
        Me.CboDV.Size = New System.Drawing.Size(52, 21)
        Me.CboDV.TabIndex = 18
        Me.CboDV.Visible = False
        '
        '_txtChuyen_8
        '
        Me._txtChuyen_8.AcceptsReturn = True
        Me._txtChuyen_8.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_8.Location = New System.Drawing.Point(256, 10)
        Me._txtChuyen_8.MaxLength = 20
        Me._txtChuyen_8.Multiline = True
        Me._txtChuyen_8.Name = "_txtChuyen_8"
        Me._txtChuyen_8.Size = New System.Drawing.Size(65, 19)
        Me._txtChuyen_8.TabIndex = 1
        Me._txtChuyen_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._txtChuyen_8.Visible = False
        '
        'Cbo
        '
        Me.Cbo.BackColor = System.Drawing.SystemColors.Window
        Me.Cbo.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cbo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.Cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo.Location = New System.Drawing.Point(119, 10)
        Me.Cbo.Name = "Cbo"
        Me.Cbo.Size = New System.Drawing.Size(73, 21)
        Me.Cbo.TabIndex = 0
        '
        '_txtChuyen_7
        '
        Me._txtChuyen_7.AcceptsReturn = True
        Me._txtChuyen_7.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_7.Location = New System.Drawing.Point(552, 32)
        Me._txtChuyen_7.MaxLength = 150
        Me._txtChuyen_7.Name = "_txtChuyen_7"
        Me._txtChuyen_7.Size = New System.Drawing.Size(97, 20)
        Me._txtChuyen_7.TabIndex = 6
        Me._txtChuyen_7.Text = "..."
        '
        '_txtChuyen_6
        '
        Me._txtChuyen_6.AcceptsReturn = True
        Me._txtChuyen_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_6.Location = New System.Drawing.Point(568, 471)
        Me._txtChuyen_6.MaxLength = 20
        Me._txtChuyen_6.Name = "_txtChuyen_6"
        Me._txtChuyen_6.Size = New System.Drawing.Size(64, 20)
        Me._txtChuyen_6.TabIndex = 22
        Me._txtChuyen_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Command1_4
        '
        Me._Command1_4.BackColor = System.Drawing.Color.Silver
        Me._Command1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_4.Image = CType(resources.GetObject("_Command1_4.Image"), System.Drawing.Image)
        Me._Command1_4.Location = New System.Drawing.Point(256, 501)
        Me._Command1_4.Name = "_Command1_4"
        Me._Command1_4.Size = New System.Drawing.Size(73, 25)
        Me._Command1_4.TabIndex = 17
        Me._Command1_4.TabStop = False
        Me._Command1_4.Tag = "&Print"
        Me._Command1_4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_4.UseVisualStyleBackColor = False
        Me._Command1_4.Visible = False
        '
        '_txtChuyen_5
        '
        Me._txtChuyen_5.AcceptsReturn = True
        Me._txtChuyen_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_5.Location = New System.Drawing.Point(384, 471)
        Me._txtChuyen_5.MaxLength = 20
        Me._txtChuyen_5.Multiline = True
        Me._txtChuyen_5.Name = "_txtChuyen_5"
        Me._txtChuyen_5.Size = New System.Drawing.Size(81, 21)
        Me._txtChuyen_5.TabIndex = 20
        Me._txtChuyen_5.Tag = "0"
        Me._txtChuyen_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Command1_3
        '
        Me._Command1_3.BackColor = System.Drawing.Color.Silver
        Me._Command1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_3.Image = CType(resources.GetObject("_Command1_3.Image"), System.Drawing.Image)
        Me._Command1_3.Location = New System.Drawing.Point(576, 501)
        Me._Command1_3.Name = "_Command1_3"
        Me._Command1_3.Size = New System.Drawing.Size(73, 25)
        Me._Command1_3.TabIndex = 20
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
        Me._Command1_2.Location = New System.Drawing.Point(496, 501)
        Me._Command1_2.Name = "_Command1_2"
        Me._Command1_2.Size = New System.Drawing.Size(73, 25)
        Me._Command1_2.TabIndex = 21
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
        Me._Command1_1.Location = New System.Drawing.Point(416, 501)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(73, 25)
        Me._Command1_1.TabIndex = 18
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
        Me._Command1_0.Location = New System.Drawing.Point(336, 501)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(73, 25)
        Me._Command1_0.TabIndex = 19
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&Add"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        'cmdct
        '
        Me.cmdct.BackColor = System.Drawing.SystemColors.Control
        Me.cmdct.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdct.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdct.Image = Global.UNET.My.Resources.Resources.up16
        Me.cmdct.Location = New System.Drawing.Point(632, 473)
        Me.cmdct.Name = "cmdct"
        Me.cmdct.Size = New System.Drawing.Size(17, 19)
        Me.cmdct.TabIndex = 16
        Me.cmdct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdct.UseVisualStyleBackColor = False
        '
        'CboSohieu
        '
        Me.CboSohieu.BackColor = System.Drawing.SystemColors.Window
        Me.CboSohieu.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboSohieu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboSohieu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSohieu.Location = New System.Drawing.Point(119, 33)
        Me.CboSohieu.Name = "CboSohieu"
        Me.CboSohieu.Size = New System.Drawing.Size(73, 21)
        Me.CboSohieu.TabIndex = 3
        '
        '_txtChuyen_3
        '
        Me._txtChuyen_3.AcceptsReturn = True
        Me._txtChuyen_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_3.Location = New System.Drawing.Point(272, 472)
        Me._txtChuyen_3.MaxLength = 20
        Me._txtChuyen_3.Name = "_txtChuyen_3"
        Me._txtChuyen_3.Size = New System.Drawing.Size(49, 20)
        Me._txtChuyen_3.TabIndex = 17
        Me._txtChuyen_3.TabStop = False
        Me._txtChuyen_3.Tag = "0"
        '
        '_txtChuyen_1
        '
        Me._txtChuyen_1.AcceptsReturn = True
        Me._txtChuyen_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_1.Location = New System.Drawing.Point(72, 471)
        Me._txtChuyen_1.MaxLength = 20
        Me._txtChuyen_1.Name = "_txtChuyen_1"
        Me._txtChuyen_1.Size = New System.Drawing.Size(81, 20)
        Me._txtChuyen_1.TabIndex = 15
        '
        '_txtChuyen_0
        '
        Me._txtChuyen_0.AcceptsReturn = True
        Me._txtChuyen_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_0.Location = New System.Drawing.Point(8, 471)
        Me._txtChuyen_0.MaxLength = 20
        Me._txtChuyen_0.Name = "_txtChuyen_0"
        Me._txtChuyen_0.Size = New System.Drawing.Size(65, 20)
        Me._txtChuyen_0.TabIndex = 14
        '
        '_CboKho_1
        '
        Me._CboKho_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboKho_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboKho_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboKho_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboKho_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboKho_1.Location = New System.Drawing.Point(464, 471)
        Me._CboKho_1.Name = "_CboKho_1"
        Me._CboKho_1.Size = New System.Drawing.Size(108, 21)
        Me._CboKho_1.TabIndex = 21
        '
        '_CboKho_0
        '
        Me._CboKho_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboKho_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboKho_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboKho_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboKho_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboKho_0.Location = New System.Drawing.Point(396, 10)
        Me._CboKho_0.Name = "_CboKho_0"
        Me._CboKho_0.Size = New System.Drawing.Size(253, 21)
        Me._CboKho_0.TabIndex = 2
        '
        'MedNgay
        '
        Me.MedNgay.AllowPromptAsInput = False
        Me.MedNgay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedNgay.Location = New System.Drawing.Point(256, 32)
        Me.MedNgay.Name = "MedNgay"
        Me.MedNgay.Size = New System.Drawing.Size(65, 20)
        Me.MedNgay.TabIndex = 4
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.Black
        Me._Label_2.Location = New System.Drawing.Point(72, 181)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(249, 17)
        Me._Label_2.TabIndex = 34
        Me._Label_2.Tag = "Material"
        Me._Label_2.Text = "Vật tư"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.Color.Black
        Me._Label_6.Location = New System.Drawing.Point(320, 181)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(65, 33)
        Me._Label_6.TabIndex = 28
        Me._Label_6.Tag = "Quantity"
        Me._Label_6.Text = "Số lượng"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(384, 181)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(81, 33)
        Me._Label_7.TabIndex = 29
        Me._Label_7.Tag = "Amount"
        Me._Label_7.Text = "Thành tiền"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_LbTT_0
        '
        Me._LbTT_0.BackColor = System.Drawing.Color.Transparent
        Me._LbTT_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTT_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LbTT_0.Location = New System.Drawing.Point(8, 141)
        Me._LbTT_0.Name = "_LbTT_0"
        Me._LbTT_0.Size = New System.Drawing.Size(57, 17)
        Me._LbTT_0.TabIndex = 47
        Me._LbTT_0.Tag = "Index"
        Me._LbTT_0.Text = "Thông tin 1"
        Me._LbTT_0.Visible = False
        '
        '_LbTT_1
        '
        Me._LbTT_1.BackColor = System.Drawing.Color.Transparent
        Me._LbTT_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTT_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LbTT_1.Location = New System.Drawing.Point(217, 144)
        Me._LbTT_1.Name = "_LbTT_1"
        Me._LbTT_1.Size = New System.Drawing.Size(57, 17)
        Me._LbTT_1.TabIndex = 46
        Me._LbTT_1.Tag = "Index"
        Me._LbTT_1.Text = "Thông tin 2"
        Me._LbTT_1.Visible = False
        '
        '_LbTT_2
        '
        Me._LbTT_2.BackColor = System.Drawing.Color.Transparent
        Me._LbTT_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTT_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LbTT_2.Location = New System.Drawing.Point(432, 144)
        Me._LbTT_2.Name = "_LbTT_2"
        Me._LbTT_2.Size = New System.Drawing.Size(57, 17)
        Me._LbTT_2.TabIndex = 45
        Me._LbTT_2.Tag = "Index"
        Me._LbTT_2.Text = "Thông tin 3"
        Me._LbTT_2.Visible = False
        '
        '_Label_16
        '
        Me._Label_16.BackColor = System.Drawing.Color.Transparent
        Me._Label_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_16.Location = New System.Drawing.Point(8, 505)
        Me._Label_16.Name = "_Label_16"
        Me._Label_16.Size = New System.Drawing.Size(65, 17)
        Me._Label_16.TabIndex = 41
        Me._Label_16.Tag = "Input by"
        Me._Label_16.Text = "Người nhập"
        '
        'LbUser
        '
        Me.LbUser.BackColor = System.Drawing.Color.Transparent
        Me.LbUser.Cursor = System.Windows.Forms.Cursors.Default
        Me.LbUser.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUser.ForeColor = System.Drawing.Color.Teal
        Me.LbUser.Location = New System.Drawing.Point(72, 505)
        Me.LbUser.Name = "LbUser"
        Me.LbUser.Size = New System.Drawing.Size(99, 17)
        Me.LbUser.TabIndex = 40
        '
        '_Label_15
        '
        Me._Label_15.BackColor = System.Drawing.Color.Transparent
        Me._Label_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_15.Location = New System.Drawing.Point(201, 10)
        Me._Label_15.Name = "_Label_15"
        Me._Label_15.Size = New System.Drawing.Size(49, 17)
        Me._Label_15.TabIndex = 39
        Me._Label_15.Tag = "Ex. Rate"
        Me._Label_15.Text = "Tỷ giá"
        Me._Label_15.Visible = False
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.Color.Transparent
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_14.Location = New System.Drawing.Point(8, 10)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(49, 17)
        Me._Label_14.TabIndex = 38
        Me._Label_14.Tag = "Month"
        Me._Label_14.Text = "Tháng"
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.Transparent
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_13.Location = New System.Drawing.Point(493, 36)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(53, 17)
        Me._Label_13.TabIndex = 37
        Me._Label_13.Tag = "Notation"
        Me._Label_13.Text = "Ký hiệu"
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.Transparent
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_11.Location = New System.Drawing.Point(320, 165)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(65, 17)
        Me._Label_11.TabIndex = 32
        Me._Label_11.Tag = "Total"
        Me._Label_11.Text = "Tổng số tiền"
        Me._Label_11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_12
        '
        Me._Label_12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.Color.Black
        Me._Label_12.Location = New System.Drawing.Point(464, 181)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.Size = New System.Drawing.Size(105, 33)
        Me._Label_12.TabIndex = 36
        Me._Label_12.Tag = "Stock Import"
        Me._Label_12.Text = "Kho nhập"
        Me._Label_12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.Color.Black
        Me._Label_10.Location = New System.Drawing.Point(568, 181)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(64, 33)
        Me._Label_10.TabIndex = 35
        Me._Label_10.Tag = "Debit Account"
        Me._Label_10.Text = "Tài khoản ghi nợ"
        Me._Label_10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LbTien
        '
        Me.LbTien.BackColor = System.Drawing.Color.Transparent
        Me.LbTien.Cursor = System.Windows.Forms.Cursors.Default
        Me.LbTien.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTien.ForeColor = System.Drawing.Color.Blue
        Me.LbTien.Location = New System.Drawing.Point(381, 165)
        Me.LbTien.Name = "LbTien"
        Me.LbTien.Size = New System.Drawing.Size(81, 17)
        Me.LbTien.TabIndex = 33
        Me.LbTien.Text = "0"
        Me.LbTien.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_9
        '
        Me._Label_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.Color.Black
        Me._Label_9.Location = New System.Drawing.Point(8, 181)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.Size = New System.Drawing.Size(65, 33)
        Me._Label_9.TabIndex = 31
        Me._Label_9.Tag = "Account"
        Me._Label_9.Text = "   Số hiệu   Tài khoản"
        Me._Label_9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.Transparent
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_8.Location = New System.Drawing.Point(8, 32)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(49, 17)
        Me._Label_8.TabIndex = 30
        Me._Label_8.Tag = "V. Code"
        Me._Label_8.Text = "Số hiệu"
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.Color.Black
        Me._Label_5.Location = New System.Drawing.Point(272, 197)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(49, 17)
        Me._Label_5.TabIndex = 27
        Me._Label_5.Tag = "Unit"
        Me._Label_5.Text = "Đ.vị"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(152, 197)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(121, 17)
        Me._Label_4.TabIndex = 26
        Me._Label_4.Tag = "Description"
        Me._Label_4.Text = "Diễn giải"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.Black
        Me._Label_3.Location = New System.Drawing.Point(72, 197)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(81, 17)
        Me._Label_3.TabIndex = 25
        Me._Label_3.Tag = "Code"
        Me._Label_3.Text = "Số hiệu"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(333, 10)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(76, 17)
        Me._Label_1.TabIndex = 24
        Me._Label_1.Tag = "Stock Export"
        Me._Label_1.Text = "Kho Xuất"
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(201, 33)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(49, 17)
        Me._Label_0.TabIndex = 23
        Me._Label_0.Tag = "Date"
        Me._Label_0.Text = "Ngày"
        '
        'GrdChuyen
        '
        Me.GrdChuyen.AllowColumnResize = True
        Me.GrdChuyen.AllowMultiselect = False
        Me.GrdChuyen.AlternateBackground = System.Drawing.Color.DarkGreen
        Me.GrdChuyen.AlternatingColors = False
        Me.GrdChuyen.AutoHeight = True
        Me.GrdChuyen.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdChuyen.BackgroundStretchToFit = True
        Me.GrdChuyen.Col = 0
        Me.GrdChuyen.Cols = 0
        Me.GrdChuyen.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me.GrdChuyen.FullRowSelect = True
        Me.GrdChuyen.GridColor = System.Drawing.Color.LightGray
        Me.GrdChuyen.GridLines = ListViewEx.GLGridLines.gridBoth
        Me.GrdChuyen.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me.GrdChuyen.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me.GrdChuyen.HeaderHeight = 22
        Me.GrdChuyen.HeaderVisible = True
        Me.GrdChuyen.HeaderWordWrap = False
        Me.GrdChuyen.HotColumnTracking = False
        Me.GrdChuyen.HotItemTracking = False
        Me.GrdChuyen.HotTrackingColor = System.Drawing.Color.LightGray
        Me.GrdChuyen.HoverEvents = False
        Me.GrdChuyen.HoverTime = 1
        Me.GrdChuyen.ImageList = Nothing
        Me.GrdChuyen.ItemHeight = 18
        Me.GrdChuyen.ItemWordWrap = False
        Me.GrdChuyen.Location = New System.Drawing.Point(8, 213)
        Me.GrdChuyen.Name = "GrdChuyen"
        Me.GrdChuyen.Row = 0
        Me.GrdChuyen.Rows = 0
        Me.GrdChuyen.Selectable = True
        Me.GrdChuyen.SelectedTextColor = System.Drawing.Color.White
        Me.GrdChuyen.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.GrdChuyen.ShowBorder = True
        Me.GrdChuyen.ShowFocusRect = False
        Me.GrdChuyen.Size = New System.Drawing.Size(641, 260)
        Me.GrdChuyen.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdChuyen.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdChuyen.TabIndex = 10
        '
        '_txtChuyen_10
        '
        Me._txtChuyen_10.AcceptsReturn = True
        Me._txtChuyen_10.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_10.Location = New System.Drawing.Point(119, 56)
        Me._txtChuyen_10.MaxLength = 250
        Me._txtChuyen_10.Multiline = True
        Me._txtChuyen_10.Name = "_txtChuyen_10"
        Me._txtChuyen_10.Size = New System.Drawing.Size(73, 19)
        Me._txtChuyen_10.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 56
        Me.Label1.Tag = "Command code"
        Me.Label1.Text = "Lệnh điều động số"
        '
        '_txtChuyen_12
        '
        Me._txtChuyen_12.AcceptsReturn = True
        Me._txtChuyen_12.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_12.Location = New System.Drawing.Point(119, 77)
        Me._txtChuyen_12.MaxLength = 250
        Me._txtChuyen_12.Multiline = True
        Me._txtChuyen_12.Name = "_txtChuyen_12"
        Me._txtChuyen_12.Size = New System.Drawing.Size(530, 19)
        Me._txtChuyen_12.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 58
        Me.Label2.Tag = "About"
        Me.Label2.Text = "Về việc"
        '
        '_txtChuyen_13
        '
        Me._txtChuyen_13.AcceptsReturn = True
        Me._txtChuyen_13.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_13.Location = New System.Drawing.Point(119, 98)
        Me._txtChuyen_13.MaxLength = 250
        Me._txtChuyen_13.Multiline = True
        Me._txtChuyen_13.Name = "_txtChuyen_13"
        Me._txtChuyen_13.Size = New System.Drawing.Size(202, 19)
        Me._txtChuyen_13.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 60
        Me.Label3.Tag = "Transporters"
        Me.Label3.Text = "Người vận chuyển"
        '
        '_txtChuyen_15
        '
        Me._txtChuyen_15.AcceptsReturn = True
        Me._txtChuyen_15.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_15.Location = New System.Drawing.Point(119, 119)
        Me._txtChuyen_15.MaxLength = 250
        Me._txtChuyen_15.Multiline = True
        Me._txtChuyen_15.Name = "_txtChuyen_15"
        Me._txtChuyen_15.Size = New System.Drawing.Size(530, 19)
        Me._txtChuyen_15.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 62
        Me.Label4.Tag = "Facilities"
        Me.Label4.Text = "Phương tiện"
        '
        'MedNgayDL
        '
        Me.MedNgayDL.AllowPromptAsInput = False
        Me.MedNgayDL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedNgayDL.Location = New System.Drawing.Point(256, 55)
        Me.MedNgayDL.Name = "MedNgayDL"
        Me.MedNgayDL.Size = New System.Drawing.Size(65, 20)
        Me.MedNgayDL.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(201, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 64
        Me.Label5.Tag = "Date"
        Me.Label5.Text = "Ngày"
        '
        '_txtChuyen_16
        '
        Me._txtChuyen_16.AcceptsReturn = True
        Me._txtChuyen_16.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_16.Location = New System.Drawing.Point(396, 32)
        Me._txtChuyen_16.MaxLength = 150
        Me._txtChuyen_16.Name = "_txtChuyen_16"
        Me._txtChuyen_16.Size = New System.Drawing.Size(87, 20)
        Me._txtChuyen_16.TabIndex = 5
        Me._txtChuyen_16.Text = "..."
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(333, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 66
        Me.Label6.Tag = "Form"
        Me.Label6.Text = "Mẫu số"
        '
        '_txtChuyen_11
        '
        Me._txtChuyen_11.AcceptsReturn = True
        Me._txtChuyen_11.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_11.Location = New System.Drawing.Point(396, 55)
        Me._txtChuyen_11.MaxLength = 250
        Me._txtChuyen_11.Multiline = True
        Me._txtChuyen_11.Name = "_txtChuyen_11"
        Me._txtChuyen_11.Size = New System.Drawing.Size(253, 19)
        Me._txtChuyen_11.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(333, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 68
        Me.Label7.Tag = "Of"
        Me.Label7.Text = "Của"
        '
        '_txtChuyen_14
        '
        Me._txtChuyen_14.AcceptsReturn = True
        Me._txtChuyen_14.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_14.Location = New System.Drawing.Point(396, 99)
        Me._txtChuyen_14.MaxLength = 250
        Me._txtChuyen_14.Multiline = True
        Me._txtChuyen_14.Name = "_txtChuyen_14"
        Me._txtChuyen_14.Size = New System.Drawing.Size(253, 19)
        Me._txtChuyen_14.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(333, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 17)
        Me.Label8.TabIndex = 70
        Me.Label8.Tag = "Contract"
        Me.Label8.Text = "Hợp đồng"
        '
        '_Command_5
        '
        Me._Command_5.Location = New System.Drawing.Point(177, 501)
        Me._Command_5.Name = "_Command_5"
        Me._Command_5.Size = New System.Drawing.Size(73, 25)
        Me._Command_5.TabIndex = 25
        Me._Command_5.Text = "&Barcode"
        Me._Command_5.Visible = False
        '
        'FrmLuuChuyen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(659, 531)
        Me.Controls.Add(Me.GrdChuyen)
        Me.Controls.Add(Me._txtChuyen_0)
        Me.Controls.Add(Me._txtChuyen_1)
        Me.Controls.Add(Me._txtChuyen_2)
        Me.Controls.Add(Me.CboDV)
        Me.Controls.Add(Me._txtChuyen_4)
        Me.Controls.Add(Me._txtChuyen_5)
        Me.Controls.Add(Me._CboKho_1)
        Me.Controls.Add(Me.cmdct)
        Me.Controls.Add(Me._txtChuyen_6)
        Me.Controls.Add(Me._txtChuyen_14)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me._txtChuyen_11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me._txtChuyen_16)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MedNgayDL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me._txtChuyen_15)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me._txtChuyen_13)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me._txtChuyen_12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me._txtChuyen_10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me._Command_4)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command1_5)
        Me.Controls.Add(Me._CboVV_2)
        Me.Controls.Add(Me._CboVV_0)
        Me.Controls.Add(Me._CboVV_1)
        Me.Controls.Add(Me._txtChuyen_8)
        Me.Controls.Add(Me.Cbo)
        Me.Controls.Add(Me._txtChuyen_7)
        Me.Controls.Add(Me._Command1_4)
        Me.Controls.Add(Me._Command1_3)
        Me.Controls.Add(Me._Command1_2)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me.CboSohieu)
        Me.Controls.Add(Me._txtChuyen_3)
        Me.Controls.Add(Me._CboKho_0)
        Me.Controls.Add(Me.MedNgay)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._LbTT_0)
        Me.Controls.Add(Me._LbTT_1)
        Me.Controls.Add(Me._LbTT_2)
        Me.Controls.Add(Me._Label_16)
        Me.Controls.Add(Me.LbUser)
        Me.Controls.Add(Me._Label_15)
        Me.Controls.Add(Me._Label_14)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me._Label_11)
        Me.Controls.Add(Me._Label_12)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me.LbTien)
        Me.Controls.Add(Me._Label_9)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_5)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._txtChuyen_9)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(12, 52)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLuuChuyen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Inventory Internal Flow"
        Me.Text = "Lưu chuyển nội bộ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Sub InitializetxtChuyen()
        Me.txtChuyen(4) = _txtChuyen_4
        Me.txtChuyen(2) = _txtChuyen_2
        Me.txtChuyen(9) = _txtChuyen_9
        Me.txtChuyen(8) = _txtChuyen_8
        Me.txtChuyen(7) = _txtChuyen_7
        Me.txtChuyen(6) = _txtChuyen_6
        Me.txtChuyen(5) = _txtChuyen_5
        Me.txtChuyen(3) = _txtChuyen_3
        Me.txtChuyen(1) = _txtChuyen_1
        Me.txtChuyen(0) = _txtChuyen_0
        Me.txtChuyen(10) = _txtChuyen_10
        Me.txtChuyen(11) = _txtChuyen_11
        Me.txtChuyen(12) = _txtChuyen_12
        Me.txtChuyen(13) = _txtChuyen_13
        Me.txtChuyen(14) = _txtChuyen_14
        Me.txtChuyen(15) = _txtChuyen_15
        Me.txtChuyen(16) = _txtChuyen_16
    End Sub
    Sub InitializeLbTT()
        Me.LbTT(0) = _LbTT_0
        Me.LbTT(1) = _LbTT_1
        Me.LbTT(2) = _LbTT_2
    End Sub
    Sub InitializeLabel()
        Me.Label(2) = _Label_2
        Me.Label(6) = _Label_6
        Me.Label(7) = _Label_7
        Me.Label(16) = _Label_16
        Me.Label(15) = _Label_15
        Me.Label(14) = _Label_14
        Me.Label(13) = _Label_13
        Me.Label(11) = _Label_11
        Me.Label(12) = _Label_12
        Me.Label(10) = _Label_10
        Me.Label(9) = _Label_9
        Me.Label(8) = _Label_8
        Me.Label(5) = _Label_5
        Me.Label(4) = _Label_4
        Me.Label(3) = _Label_3
        Me.Label(1) = _Label_1
        Me.Label(0) = _Label_0
    End Sub
    Sub InitializeCommand1()
        Me.Command1(5) = _Command1_5
        Me.Command1(4) = _Command1_4
        Me.Command1(3) = _Command1_3
        Me.Command1(2) = _Command1_2
        Me.Command1(1) = _Command1_1
        Me.Command1(0) = _Command1_0
    End Sub
    Sub InitializeCommand()
        Me.Command(4) = _Command_4
        Me.Command(5) = SimpleButton1
        Me.Command(2) = _Command_2
        Me.Command(3) = _Command_3
        Me.Command(1) = _Command_1
        Me.Command(0) = _Command_0
    End Sub
    Sub InitializeCboVV()
        Me.CboVV(2) = _CboVV_2
        Me.CboVV(0) = _CboVV_0
        Me.CboVV(1) = _CboVV_1
    End Sub
    Sub InitializeCboKho()
        Me.CboKho(1) = _CboKho_1
        Me.CboKho(0) = _CboKho_0
    End Sub
    Private WithEvents _txtChuyen_10 As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents _txtChuyen_12 As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents _txtChuyen_13 As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents _txtChuyen_15 As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents MedNgayDL As System.Windows.Forms.MaskedTextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents _txtChuyen_16 As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents _txtChuyen_11 As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents _txtChuyen_14 As System.Windows.Forms.TextBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents _Command_5 As System.Windows.Forms.Button
#End Region 
End Class
