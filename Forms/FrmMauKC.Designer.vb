<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMauKC
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializetxtNhap()
		InitializeTK()
		InitializeLbTK()
		InitializeLabel()
		InitializeGrdNT()
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
	Public WithEvents CmdChitiet As System.Windows.Forms.Button
	Private WithEvents _GrdNT_1  As ListviewEx.ListviewExt 
	Private WithEvents _GrdNT_0  As ListviewEx.ListviewExt 
	Private WithEvents _txtNhap_1 As System.Windows.Forms.TextBox
	Private WithEvents _txtNhap_0 As System.Windows.Forms.TextBox
	Private WithEvents _TK_2 As System.Windows.Forms.Label
	Private WithEvents _LbTK_1 As System.Windows.Forms.Label
	Private WithEvents _LbTK_0 As System.Windows.Forms.Label
	Private WithEvents _Label_6 As System.Windows.Forms.Label
	Private WithEvents _TK_1 As System.Windows.Forms.Label
	Private WithEvents _Label_4 As System.Windows.Forms.Label
	Private WithEvents _Label_3 As System.Windows.Forms.Label
	Private WithEvents _TK_0 As System.Windows.Forms.Label
	Private WithEvents _Label_0 As System.Windows.Forms.Label
	Private WithEvents _Label_1 As System.Windows.Forms.Label
	Public GrdNT(1)  As ListviewEx.ListviewExt 
	Public Label(6) As System.Windows.Forms.Label
	Public LbTK(1) As System.Windows.Forms.Label
	Public TK(2) As System.Windows.Forms.Label
	Public txtNhap(1) As System.Windows.Forms.TextBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.CmdChitiet = New System.Windows.Forms.Button
        Me._txtNhap_1 = New System.Windows.Forms.TextBox
        Me._txtNhap_0 = New System.Windows.Forms.TextBox
        Me._TK_2 = New System.Windows.Forms.Label
        Me._LbTK_1 = New System.Windows.Forms.Label
        Me._LbTK_0 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._TK_1 = New System.Windows.Forms.Label
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._TK_0 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._GrdNT_0 = New ListViewEx.ListviewExt
        Me._GrdNT_1 = New ListViewEx.ListviewExt
        Me.SuspendLayout()
        '
        'CmdChitiet
        '
        Me.CmdChitiet.BackColor = System.Drawing.SystemColors.Control
        Me.CmdChitiet.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdChitiet.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdChitiet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdChitiet.Image = Global.UNET.My.Resources.Resources.up16
        Me.CmdChitiet.Location = New System.Drawing.Point(632, 432)
        Me.CmdChitiet.Name = "CmdChitiet"
        Me.CmdChitiet.Size = New System.Drawing.Size(17, 21)
        Me.CmdChitiet.TabIndex = 2
        Me.CmdChitiet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTipMain.SetToolTip(Me.CmdChitiet, "Ghi phát sinh")
        Me.CmdChitiet.UseVisualStyleBackColor = False
        '
        '_txtNhap_1
        '
        Me._txtNhap_1.AcceptsReturn = True
        Me._txtNhap_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_1.Location = New System.Drawing.Point(368, 432)
        Me._txtNhap_1.MaxLength = 20
        Me._txtNhap_1.Name = "_txtNhap_1"
        Me._txtNhap_1.Size = New System.Drawing.Size(89, 20)
        Me._txtNhap_1.TabIndex = 1
        Me._txtNhap_1.Tag = "0"
        Me._txtNhap_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtNhap_0
        '
        Me._txtNhap_0.AcceptsReturn = True
        Me._txtNhap_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_0.Location = New System.Drawing.Point(8, 432)
        Me._txtNhap_0.MaxLength = 20
        Me._txtNhap_0.Name = "_txtNhap_0"
        Me._txtNhap_0.Size = New System.Drawing.Size(89, 20)
        Me._txtNhap_0.TabIndex = 0
        Me._txtNhap_0.Tag = "0"
        Me._txtNhap_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_TK_2
        '
        Me._TK_2.BackColor = System.Drawing.Color.Transparent
        Me._TK_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._TK_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TK_2.ForeColor = System.Drawing.Color.Blue
        Me._TK_2.Location = New System.Drawing.Point(8, 8)
        Me._TK_2.Name = "_TK_2"
        Me._TK_2.Size = New System.Drawing.Size(641, 17)
        Me._TK_2.TabIndex = 14
        Me._TK_2.Tag = "1"
        Me._TK_2.Text = "TK1"
        '
        '_LbTK_1
        '
        Me._LbTK_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTK_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTK_1.ForeColor = System.Drawing.Color.Blue
        Me._LbTK_1.Location = New System.Drawing.Point(464, 432)
        Me._LbTK_1.Name = "_LbTK_1"
        Me._LbTK_1.Size = New System.Drawing.Size(166, 20)
        Me._LbTK_1.TabIndex = 12
        Me._LbTK_1.Tag = "1"
        '
        '_LbTK_0
        '
        Me._LbTK_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTK_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTK_0.ForeColor = System.Drawing.Color.Blue
        Me._LbTK_0.Location = New System.Drawing.Point(104, 432)
        Me._LbTK_0.Name = "_LbTK_0"
        Me._LbTK_0.Size = New System.Drawing.Size(185, 20)
        Me._LbTK_0.TabIndex = 11
        Me._LbTK_0.Tag = "0"
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.PaleGreen
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Wingdings", 40.0!, System.Drawing.FontStyle.Bold)
        Me._Label_6.ForeColor = System.Drawing.Color.Red
        Me._Label_6.Image = Global.UNET.My.Resources.Resources.forward
        Me._Label_6.Location = New System.Drawing.Point(294, 213)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(67, 56)
        Me._Label_6.TabIndex = 10
        '
        '_TK_1
        '
        Me._TK_1.BackColor = System.Drawing.Color.Transparent
        Me._TK_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._TK_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TK_1.ForeColor = System.Drawing.Color.Blue
        Me._TK_1.Location = New System.Drawing.Point(368, 32)
        Me._TK_1.Name = "_TK_1"
        Me._TK_1.Size = New System.Drawing.Size(281, 17)
        Me._TK_1.TabIndex = 9
        Me._TK_1.Tag = "1"
        Me._TK_1.Text = "TK1"
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(368, 56)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(89, 17)
        Me._Label_4.TabIndex = 8
        Me._Label_4.Tag = "Detail"
        Me._Label_4.Text = "Chi tiết"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.Black
        Me._Label_3.Location = New System.Drawing.Point(456, 56)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(175, 17)
        Me._Label_3.TabIndex = 7
        Me._Label_3.Tag = "Desciption"
        Me._Label_3.Text = "Diễn giải"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_TK_0
        '
        Me._TK_0.BackColor = System.Drawing.Color.Transparent
        Me._TK_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._TK_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TK_0.ForeColor = System.Drawing.Color.Blue
        Me._TK_0.Location = New System.Drawing.Point(8, 32)
        Me._TK_0.Name = "_TK_0"
        Me._TK_0.Size = New System.Drawing.Size(353, 17)
        Me._TK_0.TabIndex = 5
        Me._TK_0.Tag = "1"
        Me._TK_0.Text = "TK1"
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.Color.Black
        Me._Label_0.Location = New System.Drawing.Point(8, 56)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(89, 17)
        Me._Label_0.TabIndex = 4
        Me._Label_0.Tag = "Detail"
        Me._Label_0.Text = "Chi tiết"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(96, 56)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(176, 17)
        Me._Label_1.TabIndex = 3
        Me._Label_1.Tag = "Desciption"
        Me._Label_1.Text = "Diễn giải"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_GrdNT_0
        '
        Me._GrdNT_0.AllowColumnResize = True
        Me._GrdNT_0.AllowMultiselect = False
        Me._GrdNT_0.AlternateBackground = System.Drawing.Color.DarkGreen
        Me._GrdNT_0.AlternatingColors = False
        Me._GrdNT_0.AutoHeight = True
        Me._GrdNT_0.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me._GrdNT_0.BackgroundStretchToFit = True
        Me._GrdNT_0.Col = 0
        Me._GrdNT_0.Cols = 0
        Me._GrdNT_0.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me._GrdNT_0.FullRowSelect = True
        Me._GrdNT_0.GridColor = System.Drawing.Color.LightGray
        Me._GrdNT_0.GridLines = ListViewEx.GLGridLines.gridBoth
        Me._GrdNT_0.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me._GrdNT_0.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me._GrdNT_0.HeaderHeight = 22
        Me._GrdNT_0.HeaderVisible = True
        Me._GrdNT_0.HeaderWordWrap = False
        Me._GrdNT_0.HotColumnTracking = False
        Me._GrdNT_0.HotItemTracking = False
        Me._GrdNT_0.HotTrackingColor = System.Drawing.Color.LightGray
        Me._GrdNT_0.HoverEvents = False
        Me._GrdNT_0.HoverTime = 1
        Me._GrdNT_0.ImageList = Nothing
        Me._GrdNT_0.ItemHeight = 18
        Me._GrdNT_0.ItemWordWrap = False
        Me._GrdNT_0.Location = New System.Drawing.Point(8, 72)
        Me._GrdNT_0.Name = "_GrdNT_0"
        Me._GrdNT_0.Row = 0
        Me._GrdNT_0.Rows = 0
        Me._GrdNT_0.Selectable = True
        Me._GrdNT_0.SelectedTextColor = System.Drawing.Color.White
        Me._GrdNT_0.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me._GrdNT_0.ShowBorder = True
        Me._GrdNT_0.ShowFocusRect = False
        Me._GrdNT_0.Size = New System.Drawing.Size(281, 360)
        Me._GrdNT_0.SortType = ListViewEx.SortTypes.InsertionSort
        Me._GrdNT_0.SuperFlatHeaderColor = System.Drawing.Color.White
        Me._GrdNT_0.TabIndex = 10
        '
        '_GrdNT_1
        '
        Me._GrdNT_1.AllowColumnResize = True
        Me._GrdNT_1.AllowMultiselect = False
        Me._GrdNT_1.AlternateBackground = System.Drawing.Color.DarkGreen
        Me._GrdNT_1.AlternatingColors = False
        Me._GrdNT_1.AutoHeight = True
        Me._GrdNT_1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me._GrdNT_1.BackgroundStretchToFit = True
        Me._GrdNT_1.Col = 0
        Me._GrdNT_1.Cols = 0
        Me._GrdNT_1.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me._GrdNT_1.FullRowSelect = True
        Me._GrdNT_1.GridColor = System.Drawing.Color.LightGray
        Me._GrdNT_1.GridLines = ListViewEx.GLGridLines.gridBoth
        Me._GrdNT_1.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me._GrdNT_1.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me._GrdNT_1.HeaderHeight = 22
        Me._GrdNT_1.HeaderVisible = True
        Me._GrdNT_1.HeaderWordWrap = False
        Me._GrdNT_1.HotColumnTracking = False
        Me._GrdNT_1.HotItemTracking = False
        Me._GrdNT_1.HotTrackingColor = System.Drawing.Color.LightGray
        Me._GrdNT_1.HoverEvents = False
        Me._GrdNT_1.HoverTime = 1
        Me._GrdNT_1.ImageList = Nothing
        Me._GrdNT_1.ItemHeight = 18
        Me._GrdNT_1.ItemWordWrap = False
        Me._GrdNT_1.Location = New System.Drawing.Point(368, 72)
        Me._GrdNT_1.Name = "_GrdNT_1"
        Me._GrdNT_1.Row = 0
        Me._GrdNT_1.Rows = 0
        Me._GrdNT_1.Selectable = True
        Me._GrdNT_1.SelectedTextColor = System.Drawing.Color.White
        Me._GrdNT_1.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me._GrdNT_1.ShowBorder = True
        Me._GrdNT_1.ShowFocusRect = False
        Me._GrdNT_1.Size = New System.Drawing.Size(281, 361)
        Me._GrdNT_1.SortType = ListViewEx.SortTypes.InsertionSort
        Me._GrdNT_1.SuperFlatHeaderColor = System.Drawing.Color.White
        Me._GrdNT_1.TabIndex = 10
        '
        'FrmMauKC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(658, 460)
        Me.Controls.Add(Me._GrdNT_0)
        Me.Controls.Add(Me._GrdNT_1)
        Me.Controls.Add(Me.CmdChitiet)
        Me.Controls.Add(Me._txtNhap_1)
        Me.Controls.Add(Me._txtNhap_0)
        Me.Controls.Add(Me._TK_2)
        Me.Controls.Add(Me._LbTK_1)
        Me.Controls.Add(Me._LbTK_0)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._TK_1)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._TK_0)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(54, 75)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMauKC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Nội dung chứng từ kết chuyển"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializetxtNhap()
		Me.txtNhap(1) = _txtNhap_1
		Me.txtNhap(0) = _txtNhap_0
	End Sub
	Sub InitializeTK()
		Me.TK(2) = _TK_2
		Me.TK(1) = _TK_1
		Me.TK(0) = _TK_0
	End Sub
	Sub InitializeLbTK()
		Me.LbTK(1) = _LbTK_1
		Me.LbTK(0) = _LbTK_0
	End Sub
	Sub InitializeLabel()
		Me.Label(6) = _Label_6
		Me.Label(4) = _Label_4
		Me.Label(3) = _Label_3
		Me.Label(0) = _Label_0
		Me.Label(1) = _Label_1
	End Sub
	Sub InitializeGrdNT()
		Me.GrdNT(1) = _GrdNT_1
		Me.GrdNT(0) = _GrdNT_0
	End Sub
#End Region 
End Class
