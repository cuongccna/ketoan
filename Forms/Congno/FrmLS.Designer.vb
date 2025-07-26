<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLS
    Inherits System.Windows.Forms.Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
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
    Public WithEvents CmdTK As System.Windows.Forms.Button
    Public WithEvents cmdkh As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Public WithEvents txtshkh As System.Windows.Forms.TextBox
    Public WithEvents cmdkh1 As System.Windows.Forms.Button
    Public WithEvents Lst As System.Windows.Forms.ListBox
    Public WithEvents CboNT As ComboBoxEx.ComboBoxExt
    Public WithEvents txtShTk As System.Windows.Forms.TextBox
    Public WithEvents CmdTK1 As System.Windows.Forms.Button
    Public WithEvents GrdNT As ListViewEx.ListviewExt
    Private WithEvents _Command1_3 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Public WithEvents txtNhap As System.Windows.Forms.TextBox
    Public WithEvents MedNgay As System.Windows.Forms.MaskedTextBox
    Private WithEvents _Command1_2 As System.Windows.Forms.Button
    Public WithEvents lbkh As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Public WithEvents LbTenTk As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Public Command(3) As System.Windows.Forms.Button
    Public Command1(3) As System.Windows.Forms.Button
    Public Label(4) As System.Windows.Forms.Label
    'Private listBoxHelper1 As Artinsoft.VB6.Gui.ListBoxHelper
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLS))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdkh1 = New System.Windows.Forms.Button
        Me.CmdTK1 = New System.Windows.Forms.Button
        Me.CmdTK = New System.Windows.Forms.Button
        Me.cmdkh = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me.txtshkh = New System.Windows.Forms.TextBox
        Me.Lst = New System.Windows.Forms.ListBox
        Me.CboNT = New ComboBoxEx.ComboBoxExt
        Me.txtShTk = New System.Windows.Forms.TextBox
        Me._Command1_3 = New System.Windows.Forms.Button
        Me._Command1_1 = New System.Windows.Forms.Button
        Me._Command1_0 = New System.Windows.Forms.Button
        Me.txtNhap = New System.Windows.Forms.TextBox
        Me.MedNgay = New System.Windows.Forms.MaskedTextBox
        Me._Command1_2 = New System.Windows.Forms.Button
        Me.lbkh = New System.Windows.Forms.Label
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me.LbTenTk = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me.GrdNT = New ListViewEx.ListviewExt
        Me.SuspendLayout()
        '
        'cmdkh1
        '
        Me.cmdkh1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdkh1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdkh1.Enabled = False
        Me.cmdkh1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdkh1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdkh1.Image = CType(resources.GetObject("cmdkh1.Image"), System.Drawing.Image)
        Me.cmdkh1.Location = New System.Drawing.Point(160, 55)
        Me.cmdkh1.Name = "cmdkh1"
        Me.cmdkh1.Size = New System.Drawing.Size(22, 23)
        Me.cmdkh1.TabIndex = 4
        Me.cmdkh1.TabStop = False
        Me.cmdkh1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdkh1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTipMain.SetToolTip(Me.cmdkh1, "Danh điểm vật tư")
        Me.cmdkh1.UseVisualStyleBackColor = False
        Me.cmdkh1.Visible = False
        '
        'CmdTK1
        '
        Me.CmdTK1.BackColor = System.Drawing.SystemColors.Control
        Me.CmdTK1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdTK1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdTK1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdTK1.Image = CType(resources.GetObject("CmdTK1.Image"), System.Drawing.Image)
        Me.CmdTK1.Location = New System.Drawing.Point(160, 7)
        Me.CmdTK1.Name = "CmdTK1"
        Me.CmdTK1.Size = New System.Drawing.Size(22, 23)
        Me.CmdTK1.TabIndex = 1
        Me.CmdTK1.TabStop = False
        Me.CmdTK1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdTK1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTipMain.SetToolTip(Me.CmdTK1, "Hệ thống tài khoản")
        Me.CmdTK1.UseVisualStyleBackColor = False
        Me.CmdTK1.Visible = False
        '
        'CmdTK
        '
        Me.CmdTK.Image = CType(resources.GetObject("CmdTK.Image"), System.Drawing.Image)
        Me.CmdTK.Location = New System.Drawing.Point(158, 8)
        Me.CmdTK.Name = "CmdTK"
        Me.CmdTK.Size = New System.Drawing.Size(24, 21)
        Me.CmdTK.TabIndex = 25
        '
        'cmdkh
        '
        Me.cmdkh.Image = CType(resources.GetObject("cmdkh.Image"), System.Drawing.Image)
        Me.cmdkh.Location = New System.Drawing.Point(158, 56)
        Me.cmdkh.Name = "cmdkh"
        Me.cmdkh.Size = New System.Drawing.Size(24, 21)
        Me.cmdkh.TabIndex = 24
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(184, 224)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 23
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(184, 192)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 22
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(184, 160)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 21
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.add16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(184, 128)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 20
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        '
        'txtshkh
        '
        Me.txtshkh.AcceptsReturn = True
        Me.txtshkh.BackColor = System.Drawing.SystemColors.Window
        Me.txtshkh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtshkh.Enabled = False
        Me.txtshkh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtshkh.Location = New System.Drawing.Point(64, 56)
        Me.txtshkh.MaxLength = 20
        Me.txtshkh.Name = "txtshkh"
        Me.txtshkh.Size = New System.Drawing.Size(89, 20)
        Me.txtshkh.TabIndex = 3
        Me.txtshkh.Tag = "0"
        '
        'Lst
        '
        Me.Lst.BackColor = System.Drawing.SystemColors.Window
        Me.Lst.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst.ItemHeight = 14
        Me.Lst.Location = New System.Drawing.Point(8, 304)
        Me.Lst.Name = "Lst"
        Me.Lst.Size = New System.Drawing.Size(249, 186)
        Me.Lst.TabIndex = 16
        '
        'CboNT
        '
        Me.CboNT.BackColor = System.Drawing.SystemColors.Window
        Me.CboNT.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboNT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboNT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboNT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboNT.Location = New System.Drawing.Point(192, 8)
        Me.CboNT.Name = "CboNT"
        Me.CboNT.Size = New System.Drawing.Size(65, 21)
        Me.CboNT.TabIndex = 2
        '
        'txtShTk
        '
        Me.txtShTk.AcceptsReturn = True
        Me.txtShTk.BackColor = System.Drawing.SystemColors.Window
        Me.txtShTk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShTk.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShTk.Location = New System.Drawing.Point(64, 8)
        Me.txtShTk.MaxLength = 12
        Me.txtShTk.Name = "txtShTk"
        Me.txtShTk.Size = New System.Drawing.Size(89, 20)
        Me.txtShTk.TabIndex = 0
        Me.txtShTk.Tag = "0"
        '
        '_Command1_3
        '
        Me._Command1_3.BackColor = System.Drawing.Color.Silver
        Me._Command1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_3.Image = CType(resources.GetObject("_Command1_3.Image"), System.Drawing.Image)
        Me._Command1_3.Location = New System.Drawing.Point(184, 224)
        Me._Command1_3.Name = "_Command1_3"
        Me._Command1_3.Size = New System.Drawing.Size(73, 25)
        Me._Command1_3.TabIndex = 10
        Me._Command1_3.TabStop = False
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
        Me._Command1_1.Location = New System.Drawing.Point(184, 160)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(73, 25)
        Me._Command1_1.TabIndex = 8
        Me._Command1_1.TabStop = False
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
        Me._Command1_0.Location = New System.Drawing.Point(184, 128)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(73, 25)
        Me._Command1_0.TabIndex = 5
        Me._Command1_0.TabStop = False
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        'txtNhap
        '
        Me.txtNhap.AcceptsReturn = True
        Me.txtNhap.BackColor = System.Drawing.SystemColors.Window
        Me.txtNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNhap.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNhap.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNhap.Location = New System.Drawing.Point(64, 248)
        Me.txtNhap.MaxLength = 20
        Me.txtNhap.Name = "txtNhap"
        Me.txtNhap.Size = New System.Drawing.Size(96, 20)
        Me.txtNhap.TabIndex = 7
        Me.txtNhap.Text = "0"
        Me.txtNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MedNgay
        '
        Me.MedNgay.AllowPromptAsInput = False
        Me.MedNgay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedNgay.Location = New System.Drawing.Point(8, 248)
        Me.MedNgay.Name = "MedNgay"
        Me.MedNgay.Size = New System.Drawing.Size(57, 20)
        Me.MedNgay.TabIndex = 6
        '
        '_Command1_2
        '
        Me._Command1_2.BackColor = System.Drawing.Color.Silver
        Me._Command1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_2.Image = CType(resources.GetObject("_Command1_2.Image"), System.Drawing.Image)
        Me._Command1_2.Location = New System.Drawing.Point(184, 192)
        Me._Command1_2.Name = "_Command1_2"
        Me._Command1_2.Size = New System.Drawing.Size(73, 25)
        Me._Command1_2.TabIndex = 9
        Me._Command1_2.TabStop = False
        Me._Command1_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_2.UseVisualStyleBackColor = False
        Me._Command1_2.Visible = False
        '
        'lbkh
        '
        Me.lbkh.BackColor = System.Drawing.Color.Transparent
        Me.lbkh.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbkh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbkh.ForeColor = System.Drawing.Color.Blue
        Me.lbkh.Location = New System.Drawing.Point(64, 80)
        Me.lbkh.Name = "lbkh"
        Me.lbkh.Size = New System.Drawing.Size(185, 17)
        Me.lbkh.TabIndex = 19
        Me.lbkh.Tag = "1"
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.Transparent
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_4.Location = New System.Drawing.Point(8, 56)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(57, 17)
        Me._Label_4.TabIndex = 18
        Me._Label_4.Tag = "Object"
        Me._Label_4.Text = "Đối tượng"
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.Transparent
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_3.Location = New System.Drawing.Point(8, 280)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(241, 17)
        Me._Label_3.TabIndex = 17
        Me._Label_3.Tag = "Details follow-up ienterest rate and current interest rates"
        Me._Label_3.Text = "Chi tiết có theo dõi lãi suất và lãi suất hiện thời"
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.Transparent
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(8, 8)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(57, 17)
        Me._Label_2.TabIndex = 15
        Me._Label_2.Tag = "Acount"
        Me._Label_2.Text = "Tài khoản"
        '
        'LbTenTk
        '
        Me.LbTenTk.BackColor = System.Drawing.Color.Transparent
        Me.LbTenTk.Cursor = System.Windows.Forms.Cursors.Default
        Me.LbTenTk.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTenTk.ForeColor = System.Drawing.Color.Blue
        Me.LbTenTk.Location = New System.Drawing.Point(64, 32)
        Me.LbTenTk.Name = "LbTenTk"
        Me.LbTenTk.Size = New System.Drawing.Size(193, 17)
        Me.LbTenTk.TabIndex = 14
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Silver
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(64, 112)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(96, 17)
        Me._Label_1.TabIndex = 13
        Me._Label_1.Tag = "Rate % month"
        Me._Label_1.Text = "Lãi suất % tháng"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Silver
        Me._Label_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.Color.Black
        Me._Label_0.Location = New System.Drawing.Point(8, 112)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(57, 17)
        Me._Label_0.TabIndex = 12
        Me._Label_0.Tag = "From"
        Me._Label_0.Text = "Từ ngày"
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
        Me.GrdNT.Location = New System.Drawing.Point(8, 128)
        Me.GrdNT.Name = "GrdNT"
        Me.GrdNT.Row = 0
        Me.GrdNT.Rows = 0
        Me.GrdNT.Selectable = True
        Me.GrdNT.SelectedTextColor = System.Drawing.Color.White
        Me.GrdNT.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.GrdNT.ShowBorder = True
        Me.GrdNT.ShowFocusRect = False
        Me.GrdNT.Size = New System.Drawing.Size(170, 121)
        Me.GrdNT.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdNT.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdNT.TabIndex = 10
        '
        'FrmLS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(264, 509)
        Me.Controls.Add(Me.GrdNT)
        Me.Controls.Add(Me.CmdTK)
        Me.Controls.Add(Me.cmdkh)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me.txtshkh)
        Me.Controls.Add(Me.cmdkh1)
        Me.Controls.Add(Me.Lst)
        Me.Controls.Add(Me.CboNT)
        Me.Controls.Add(Me.txtShTk)
        Me.Controls.Add(Me.CmdTK1)
        Me.Controls.Add(Me._Command1_3)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me.txtNhap)
        Me.Controls.Add(Me.MedNgay)
        Me.Controls.Add(Me._Command1_2)
        Me.Controls.Add(Me.lbkh)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me.LbTenTk)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(245, 63)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Interest Rate Table"
        Me.Text = "Bảng lãi suất"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializeLabel()
		Me.Label(4) = _Label_4
		Me.Label(3) = _Label_3
		Me.Label(2) = _Label_2
		Me.Label(1) = _Label_1
		Me.Label(0) = _Label_0
	End Sub
	Sub InitializeCommand1()
		Me.Command1(3) = _Command1_3
		Me.Command1(1) = _Command1_1
		Me.Command1(0) = _Command1_0
		Me.Command1(2) = _Command1_2
	End Sub
	Sub InitializeCommand()
		Me.Command(3) = _Command_3
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
#End Region 
End Class
