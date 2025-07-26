<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLuongKCN
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeLbTxt()
		InitializeLabel()
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
	Public WithEvents cmdct As System.Windows.Forms.Button
	Public WithEvents GrdVT  As ListviewEx.ListviewExt 
	Public WithEvents txt As System.Windows.Forms.TextBox
	Public WithEvents CboThang As ComboBoxEx.ComboBoxExt
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _LbTxt_0 As System.Windows.Forms.Label
    Private WithEvents _LbTxt_1 As System.Windows.Forms.Label
    Private WithEvents _LbTxt_2 As System.Windows.Forms.Label
    Private WithEvents _LbTxt_3 As System.Windows.Forms.Label
    Public Command(2) As System.Windows.Forms.Button
    Public Label(12) As System.Windows.Forms.Label
    Public LbTxt(3) As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLuongKCN))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdct = New System.Windows.Forms.Button()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.CboThang = New ComboBoxEx.ComboBoxExt()
        Me._Command_2 = New System.Windows.Forms.Button()
        Me._Label_3 = New System.Windows.Forms.Label()
        Me._Label_7 = New System.Windows.Forms.Label()
        Me._Label_8 = New System.Windows.Forms.Label()
        Me._Label_6 = New System.Windows.Forms.Label()
        Me._Label_10 = New System.Windows.Forms.Label()
        Me._Label_11 = New System.Windows.Forms.Label()
        Me._Label_12 = New System.Windows.Forms.Label()
        Me._LbTxt_0 = New System.Windows.Forms.Label()
        Me._LbTxt_1 = New System.Windows.Forms.Label()
        Me._LbTxt_2 = New System.Windows.Forms.Label()
        Me._LbTxt_3 = New System.Windows.Forms.Label()
        Me.GrdVT = New ListViewEx.ListviewExt()
        Me.SuspendLayout()
        '
        'cmdct
        '
        Me.cmdct.BackColor = System.Drawing.SystemColors.Control
        Me.cmdct.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdct.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdct.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_addtogrid
        Me.cmdct.Location = New System.Drawing.Point(529, 296)
        Me.cmdct.Name = "cmdct"
        Me.cmdct.Size = New System.Drawing.Size(18, 21)
        Me.cmdct.TabIndex = 3
        Me.cmdct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdct.UseVisualStyleBackColor = False
        '
        'txt
        '
        Me.txt.AcceptsReturn = True
        Me.txt.BackColor = System.Drawing.SystemColors.Window
        Me.txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.ForeColor = System.Drawing.Color.Blue
        Me.txt.Location = New System.Drawing.Point(448, 296)
        Me.txt.MaxLength = 100
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(81, 21)
        Me.txt.TabIndex = 2
        Me.txt.Text = "0"
        Me.txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CboThang
        '
        Me.CboThang.BackColor = System.Drawing.SystemColors.Window
        Me.CboThang.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboThang.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboThang.Location = New System.Drawing.Point(248, 32)
        Me.CboThang.Name = "CboThang"
        Me.CboThang.Size = New System.Drawing.Size(73, 21)
        Me.CboThang.TabIndex = 0
        '
        '_Command_2
        '
        Me._Command_2.Image = CType(resources.GetObject("_Command_2.Image"), System.Drawing.Image)
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(448, 328)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(99, 25)
        Me._Command_2.TabIndex = 4
        Me._Command_2.Tag = "Return"
        Me._Command_2.Text = "Trở &về"
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.Silver
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.Black
        Me._Label_3.Location = New System.Drawing.Point(448, 64)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(81, 33)
        Me._Label_3.TabIndex = 15
        Me._Label_3.Tag = "Industrial salary"
        Me._Label_3.Text = "Lương KCN"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.Silver
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(8, 64)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(153, 33)
        Me._Label_7.TabIndex = 14
        Me._Label_7.Tag = "Full name"
        Me._Label_7.Text = "Họ và tên"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.Silver
        Me._Label_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.Color.Black
        Me._Label_8.Location = New System.Drawing.Point(368, 64)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(81, 33)
        Me._Label_8.TabIndex = 13
        Me._Label_8.Tag = "Taxable income"
        Me._Label_8.Text = "Thu nhập chịu thuế"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.Silver
        Me._Label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.Color.Black
        Me._Label_6.Location = New System.Drawing.Point(256, 64)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(113, 33)
        Me._Label_6.TabIndex = 12
        Me._Label_6.Tag = "ID card / Passport"
        Me._Label_6.Text = "         Số CMND/        hộ chiếu"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.Silver
        Me._Label_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.Color.Black
        Me._Label_10.Location = New System.Drawing.Point(160, 64)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(97, 33)
        Me._Label_10.TabIndex = 11
        Me._Label_10.Tag = "Tax code"
        Me._Label_10.Text = "Mã số thuế"
        Me._Label_10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.Silver
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.Color.Black
        Me._Label_11.Location = New System.Drawing.Point(128, 8)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(289, 20)
        Me._Label_11.TabIndex = 10
        Me._Label_11.Tag = "Industrial salary"
        Me._Label_11.Text = "Bảng lương khu công nghiệp"
        Me._Label_11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_12
        '
        Me._Label_12.BackColor = System.Drawing.Color.Transparent
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_12.Location = New System.Drawing.Point(205, 34)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.Size = New System.Drawing.Size(38, 17)
        Me._Label_12.TabIndex = 9
        Me._Label_12.Tag = "Month"
        Me._Label_12.Text = "Tháng"
        Me._Label_12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_LbTxt_0
        '
        Me._LbTxt_0.BackColor = System.Drawing.SystemColors.Window
        Me._LbTxt_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbTxt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTxt_0.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTxt_0.Location = New System.Drawing.Point(8, 296)
        Me._LbTxt_0.Name = "_LbTxt_0"
        Me._LbTxt_0.Size = New System.Drawing.Size(153, 21)
        Me._LbTxt_0.TabIndex = 8
        '
        '_LbTxt_1
        '
        Me._LbTxt_1.BackColor = System.Drawing.SystemColors.Window
        Me._LbTxt_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbTxt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTxt_1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTxt_1.Location = New System.Drawing.Point(160, 296)
        Me._LbTxt_1.Name = "_LbTxt_1"
        Me._LbTxt_1.Size = New System.Drawing.Size(97, 21)
        Me._LbTxt_1.TabIndex = 7
        Me._LbTxt_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbTxt_2
        '
        Me._LbTxt_2.BackColor = System.Drawing.SystemColors.Window
        Me._LbTxt_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbTxt_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTxt_2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTxt_2.Location = New System.Drawing.Point(256, 296)
        Me._LbTxt_2.Name = "_LbTxt_2"
        Me._LbTxt_2.Size = New System.Drawing.Size(113, 21)
        Me._LbTxt_2.TabIndex = 6
        Me._LbTxt_2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbTxt_3
        '
        Me._LbTxt_3.BackColor = System.Drawing.SystemColors.Window
        Me._LbTxt_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbTxt_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTxt_3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTxt_3.Location = New System.Drawing.Point(368, 296)
        Me._LbTxt_3.Name = "_LbTxt_3"
        Me._LbTxt_3.Size = New System.Drawing.Size(81, 21)
        Me._LbTxt_3.TabIndex = 5
        Me._LbTxt_3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GrdVT
        '
        Me.GrdVT.AllowColumnResize = True
        Me.GrdVT.AllowMultiselect = False
        Me.GrdVT.AlternateBackground = System.Drawing.Color.DarkGreen
        Me.GrdVT.AlternatingColors = False
        Me.GrdVT.AutoHeight = True
        Me.GrdVT.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdVT.BackgroundStretchToFit = True
        Me.GrdVT.Col = 0
        Me.GrdVT.Cols = 0
        Me.GrdVT.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me.GrdVT.FullRowSelect = True
        Me.GrdVT.GridColor = System.Drawing.Color.LightGray
        Me.GrdVT.GridLines = ListViewEx.GLGridLines.gridBoth
        Me.GrdVT.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me.GrdVT.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me.GrdVT.HeaderHeight = 22
        Me.GrdVT.HeaderVisible = True
        Me.GrdVT.HeaderWordWrap = False
        Me.GrdVT.HotColumnTracking = False
        Me.GrdVT.HotItemTracking = False
        Me.GrdVT.HotTrackingColor = System.Drawing.Color.LightGray
        Me.GrdVT.HoverEvents = False
        Me.GrdVT.HoverTime = 1
        Me.GrdVT.ImageList = Nothing
        Me.GrdVT.ItemHeight = 18
        Me.GrdVT.ItemWordWrap = False
        Me.GrdVT.Location = New System.Drawing.Point(8, 96)
        Me.GrdVT.Name = "GrdVT"
        Me.GrdVT.Row = 0
        Me.GrdVT.Rows = 0
        Me.GrdVT.Selectable = True
        Me.GrdVT.SelectedTextColor = System.Drawing.Color.White
        Me.GrdVT.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.GrdVT.ShowBorder = True
        Me.GrdVT.ShowFocusRect = False
        Me.GrdVT.Size = New System.Drawing.Size(539, 201)
        Me.GrdVT.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdVT.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdVT.TabIndex = 10
        '
        'FrmLuongKCN
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(555, 361)
        Me.Controls.Add(Me.GrdVT)
        Me.Controls.Add(Me.cmdct)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.CboThang)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Label_11)
        Me.Controls.Add(Me._Label_12)
        Me.Controls.Add(Me._LbTxt_0)
        Me.Controls.Add(Me._LbTxt_1)
        Me.Controls.Add(Me._LbTxt_2)
        Me.Controls.Add(Me._LbTxt_3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLuongKCN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Industrial salary"
        Me.Text = "Lương khu công nhgiệp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializeLbTxt()
		Me.LbTxt(0) = _LbTxt_0
		Me.LbTxt(1) = _LbTxt_1
		Me.LbTxt(2) = _LbTxt_2
		Me.LbTxt(3) = _LbTxt_3
	End Sub
	Sub InitializeLabel()
		Me.Label(3) = _Label_3
		Me.Label(7) = _Label_7
		Me.Label(8) = _Label_8
		Me.Label(6) = _Label_6
		Me.Label(10) = _Label_10
		Me.Label(11) = _Label_11
		Me.Label(12) = _Label_12
	End Sub
	Sub InitializeCommand()
		Me.Command(2) = _Command_2
	End Sub
#End Region 
End Class
