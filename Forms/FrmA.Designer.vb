<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmA
    Inherits Form

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
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Public WithEvents Chk As System.Windows.Forms.CheckBox
    Private WithEvents _Command1_2 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Public WithEvents GrdChungtu As ListViewEx.ListviewExt
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents LbThang As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Public WithEvents LbSoCT As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Public Command(2) As System.Windows.Forms.Button
    Public Command1(2) As System.Windows.Forms.Button
    Public Label(13) As System.Windows.Forms.Label
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmA))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command1_2 = New System.Windows.Forms.Button()
        Me._Command1_1 = New System.Windows.Forms.Button()
        Me._Command_2 = New System.Windows.Forms.Button()
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me.Chk = New System.Windows.Forms.CheckBox()
        Me._Command1_0 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbThang = New System.Windows.Forms.Label()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me._Label_13 = New System.Windows.Forms.Label()
        Me.LbSoCT = New System.Windows.Forms.Label()
        Me._Label_7 = New System.Windows.Forms.Label()
        Me._Label_4 = New System.Windows.Forms.Label()
        Me._Label_3 = New System.Windows.Forms.Label()
        Me._Label_2 = New System.Windows.Forms.Label()
        Me._Label_1 = New System.Windows.Forms.Label()
        Me.GrdChungtu = New ListViewEx.ListviewExt()
        Me.SuspendLayout()
        '
        '_Command1_2
        '
        Me._Command1_2.BackColor = System.Drawing.Color.Silver
        Me._Command1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_2.Location = New System.Drawing.Point(496, 496)
        Me._Command1_2.Name = "_Command1_2"
        Me._Command1_2.Size = New System.Drawing.Size(73, 25)
        Me._Command1_2.TabIndex = 2
        Me._Command1_2.TabStop = False
        Me._Command1_2.Text = "&Thực hiƯn"
        Me._Command1_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTipMain.SetToolTip(Me._Command1_2, "Xem báo cáo")
        Me._Command1_2.UseVisualStyleBackColor = False
        Me._Command1_2.Visible = False
        '
        '_Command1_1
        '
        Me._Command1_1.BackColor = System.Drawing.Color.Silver
        Me._Command1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_1.Location = New System.Drawing.Point(496, 496)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(73, 25)
        Me._Command1_1.TabIndex = 1
        Me._Command1_1.TabStop = False
        Me._Command1_1.Text = "Vào &sổ"
        Me._Command1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTipMain.SetToolTip(Me._Command1_1, "Xem báo cáo")
        Me._Command1_1.UseVisualStyleBackColor = False
        Me._Command1_1.Visible = False
        '
        '_Command_2
        '
        Me._Command_2.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Xu_ly
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(480, 496)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(89, 25)
        Me._Command_2.TabIndex = 17
        Me._Command_2.Tag = "Apply"
        Me._Command_2.Text = "&Thực hiện"
        '
        '_Command_1
        '
        Me._Command_1.Location = New System.Drawing.Point(496, 496)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 16
        '
        '_Command_0
        '
        Me._Command_0.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(576, 496)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 15
        Me._Command_0.Tag = "Return"
        Me._Command_0.Text = "Trở &về"
        '
        'Chk
        '
        Me.Chk.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Chk.Cursor = System.Windows.Forms.Cursors.Default
        Me.Chk.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk.ForeColor = System.Drawing.Color.Black
        Me.Chk.Location = New System.Drawing.Point(568, 32)
        Me.Chk.Name = "Chk"
        Me.Chk.Size = New System.Drawing.Size(81, 17)
        Me.Chk.TabIndex = 14
        Me.Chk.Tag = "Choose all"
        Me.Chk.Text = "Chọn tất cả"
        Me.Chk.UseVisualStyleBackColor = False
        '
        '_Command1_0
        '
        Me._Command1_0.BackColor = System.Drawing.Color.Silver
        Me._Command1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_0.Image = CType(resources.GetObject("_Command1_0.Image"), System.Drawing.Image)
        Me._Command1_0.Location = New System.Drawing.Point(576, 496)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(73, 25)
        Me._Command1_0.TabIndex = 3
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&Return"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(456, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 17)
        Me.Label1.TabIndex = 13
        '
        'LbThang
        '
        Me.LbThang.BackColor = System.Drawing.Color.Transparent
        Me.LbThang.Cursor = System.Windows.Forms.Cursors.Default
        Me.LbThang.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbThang.ForeColor = System.Drawing.Color.Blue
        Me.LbThang.Location = New System.Drawing.Point(8, 8)
        Me.LbThang.Name = "LbThang"
        Me.LbThang.Size = New System.Drawing.Size(217, 17)
        Me.LbThang.TabIndex = 12
        Me.LbThang.Text = "0"
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Teal
        Me._Label_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.Color.White
        Me._Label_0.Location = New System.Drawing.Point(568, 32)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(65, 17)
        Me._Label_0.TabIndex = 11
        Me._Label_0.Tag = "B. Date"
        Me._Label_0.Text = "Vào sổ"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_13
        '
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_13.Location = New System.Drawing.Point(8, 504)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(73, 17)
        Me._Label_13.TabIndex = 10
        Me._Label_13.Tag = "Total"
        Me._Label_13.Text = "Số chứng từ"
        '
        'LbSoCT
        '
        Me.LbSoCT.Cursor = System.Windows.Forms.Cursors.Default
        Me.LbSoCT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSoCT.ForeColor = System.Drawing.Color.Blue
        Me.LbSoCT.Location = New System.Drawing.Point(88, 504)
        Me.LbSoCT.Name = "LbSoCT"
        Me.LbSoCT.Size = New System.Drawing.Size(33, 17)
        Me.LbSoCT.TabIndex = 9
        Me.LbSoCT.Text = "0"
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(480, 32)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(89, 17)
        Me._Label_7.TabIndex = 8
        Me._Label_7.Tag = "Amount"
        Me._Label_7.Text = "Tổng Phát sinh"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(224, 32)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(257, 17)
        Me._Label_4.TabIndex = 7
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
        Me._Label_3.Location = New System.Drawing.Point(160, 32)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(65, 17)
        Me._Label_3.TabIndex = 6
        Me._Label_3.Tag = "B. Date"
        Me._Label_3.Text = "Ngày GS"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.Black
        Me._Label_2.Location = New System.Drawing.Point(96, 32)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(65, 17)
        Me._Label_2.TabIndex = 5
        Me._Label_2.Tag = "V. Date"
        Me._Label_2.Text = "Ngày CT"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(8, 32)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(89, 17)
        Me._Label_1.TabIndex = 4
        Me._Label_1.Tag = "Voucher Code"
        Me._Label_1.Text = "Số CT"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GrdChungtu
        '
        Me.GrdChungtu.AllowColumnResize = True
        Me.GrdChungtu.AllowMultiselect = False
        Me.GrdChungtu.AlternateBackground = System.Drawing.Color.DarkGreen
        Me.GrdChungtu.AlternatingColors = False
        Me.GrdChungtu.AutoHeight = True
        Me.GrdChungtu.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdChungtu.BackgroundStretchToFit = True
        Me.GrdChungtu.Col = 0
        Me.GrdChungtu.Cols = 0
        Me.GrdChungtu.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me.GrdChungtu.FullRowSelect = True
        Me.GrdChungtu.GridColor = System.Drawing.Color.LightGray
        Me.GrdChungtu.GridLines = ListViewEx.GLGridLines.gridBoth
        Me.GrdChungtu.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me.GrdChungtu.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me.GrdChungtu.HeaderHeight = 22
        Me.GrdChungtu.HeaderVisible = True
        Me.GrdChungtu.HeaderWordWrap = False
        Me.GrdChungtu.HotColumnTracking = False
        Me.GrdChungtu.HotItemTracking = False
        Me.GrdChungtu.HotTrackingColor = System.Drawing.Color.LightGray
        Me.GrdChungtu.HoverEvents = False
        Me.GrdChungtu.HoverTime = 1
        Me.GrdChungtu.ImageList = Nothing
        Me.GrdChungtu.ItemHeight = 18
        Me.GrdChungtu.ItemWordWrap = False
        Me.GrdChungtu.Location = New System.Drawing.Point(8, 48)
        Me.GrdChungtu.Name = "GrdChungtu"
        Me.GrdChungtu.Row = 0
        Me.GrdChungtu.Rows = 0
        Me.GrdChungtu.Selectable = True
        Me.GrdChungtu.SelectedTextColor = System.Drawing.Color.White
        Me.GrdChungtu.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.GrdChungtu.ShowBorder = True
        Me.GrdChungtu.ShowFocusRect = False
        Me.GrdChungtu.Size = New System.Drawing.Size(641, 442)
        Me.GrdChungtu.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdChungtu.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdChungtu.TabIndex = 10
        '
        'FrmA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(657, 529)
        Me.Controls.Add(Me.GrdChungtu)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me.Chk)
        Me.Controls.Add(Me._Command1_2)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbThang)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me.LbSoCT)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(79, 36)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Voucher List"
        Me.Text = "Danh sách chứng từ"
        Me.ResumeLayout(False)

    End Sub
	Sub InitializeLabel()
		Me.Label(0) = _Label_0
		Me.Label(13) = _Label_13
		Me.Label(7) = _Label_7
		Me.Label(4) = _Label_4
		Me.Label(3) = _Label_3
		Me.Label(2) = _Label_2
		Me.Label(1) = _Label_1
	End Sub
	Sub InitializeCommand1()
		Me.Command1(2) = _Command1_2
		Me.Command1(1) = _Command1_1
		Me.Command1(0) = _Command1_0
	End Sub
	Sub InitializeCommand()
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
#End Region 
End Class
