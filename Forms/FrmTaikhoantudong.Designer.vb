<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTaikhoantudong
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializetxtNhap()
		InitializeLbTK()
		InitializeLabel()
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
	Public WithEvents GrdNT  As ListviewEx.ListviewExt 
	Private WithEvents _txtNhap_1 As System.Windows.Forms.TextBox
	Private WithEvents _txtNhap_0 As System.Windows.Forms.TextBox
	Public WithEvents Tk2 As System.Windows.Forms.Label
	Public WithEvents Tk1 As System.Windows.Forms.Label
	Public WithEvents Tieude As System.Windows.Forms.Label
	Private WithEvents _LbTK_1 As System.Windows.Forms.Label
	Private WithEvents _LbTK_0 As System.Windows.Forms.Label
	Private WithEvents _Label_4 As System.Windows.Forms.Label
	Private WithEvents _Label_3 As System.Windows.Forms.Label
	Private WithEvents _Label_0 As System.Windows.Forms.Label
	Private WithEvents _Label_1 As System.Windows.Forms.Label
	Public Label(4) As System.Windows.Forms.Label
	Public LbTK(1) As System.Windows.Forms.Label
	Public txtNhap(1) As System.Windows.Forms.TextBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.CmdChitiet = New System.Windows.Forms.Button()
        Me._txtNhap_1 = New System.Windows.Forms.TextBox()
        Me._txtNhap_0 = New System.Windows.Forms.TextBox()
        Me.Tk2 = New System.Windows.Forms.Label()
        Me.Tk1 = New System.Windows.Forms.Label()
        Me.Tieude = New System.Windows.Forms.Label()
        Me._LbTK_1 = New System.Windows.Forms.Label()
        Me._LbTK_0 = New System.Windows.Forms.Label()
        Me._Label_4 = New System.Windows.Forms.Label()
        Me._Label_3 = New System.Windows.Forms.Label()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me._Label_1 = New System.Windows.Forms.Label()
        Me.GrdNT = New ListViewEx.ListviewExt()
        Me.SuspendLayout()
        '
        'CmdChitiet
        '
        Me.CmdChitiet.BackColor = System.Drawing.SystemColors.Control
        Me.CmdChitiet.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdChitiet.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdChitiet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdChitiet.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_addtogrid
        Me.CmdChitiet.Location = New System.Drawing.Point(535, 432)
        Me.CmdChitiet.Name = "CmdChitiet"
        Me.CmdChitiet.Size = New System.Drawing.Size(19, 21)
        Me.CmdChitiet.TabIndex = 9
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
        Me._txtNhap_1.Location = New System.Drawing.Point(272, 432)
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
        'Tk2
        '
        Me.Tk2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Tk2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tk2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tk2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tk2.ForeColor = System.Drawing.Color.Black
        Me.Tk2.Location = New System.Drawing.Point(272, 40)
        Me.Tk2.Name = "Tk2"
        Me.Tk2.Size = New System.Drawing.Size(263, 17)
        Me.Tk2.TabIndex = 12
        Me.Tk2.Tag = "Credit Account"
        Me.Tk2.Text = "Tài khoản có"
        Me.Tk2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Tk1
        '
        Me.Tk1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Tk1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tk1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tk1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tk1.ForeColor = System.Drawing.Color.Black
        Me.Tk1.Location = New System.Drawing.Point(8, 40)
        Me.Tk1.Name = "Tk1"
        Me.Tk1.Size = New System.Drawing.Size(265, 17)
        Me.Tk1.TabIndex = 11
        Me.Tk1.Tag = "Debt Account"
        Me.Tk1.Text = "Tài khoản nợ"
        Me.Tk1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Tieude
        '
        Me.Tieude.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Tieude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tieude.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tieude.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tieude.ForeColor = System.Drawing.Color.Black
        Me.Tieude.Location = New System.Drawing.Point(112, 8)
        Me.Tieude.Name = "Tieude"
        Me.Tieude.Size = New System.Drawing.Size(319, 25)
        Me.Tieude.TabIndex = 10
        Me.Tieude.Tag = "Registration Account"
        Me.Tieude.Text = "Đăng ký tài khoản"
        Me.Tieude.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_LbTK_1
        '
        Me._LbTK_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTK_1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTK_1.ForeColor = System.Drawing.Color.Blue
        Me._LbTK_1.Location = New System.Drawing.Point(360, 433)
        Me._LbTK_1.Name = "_LbTK_1"
        Me._LbTK_1.Size = New System.Drawing.Size(175, 19)
        Me._LbTK_1.TabIndex = 8
        Me._LbTK_1.Tag = "1"
        '
        '_LbTK_0
        '
        Me._LbTK_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTK_0.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTK_0.ForeColor = System.Drawing.Color.Blue
        Me._LbTK_0.Location = New System.Drawing.Point(97, 433)
        Me._LbTK_0.Name = "_LbTK_0"
        Me._LbTK_0.Size = New System.Drawing.Size(176, 19)
        Me._LbTK_0.TabIndex = 7
        Me._LbTK_0.Tag = "0"
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(272, 56)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(89, 17)
        Me._Label_4.TabIndex = 6
        Me._Label_4.Tag = "Account code"
        Me._Label_4.Text = "Mã tài khoản"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.Black
        Me._Label_3.Location = New System.Drawing.Point(360, 56)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(175, 17)
        Me._Label_3.TabIndex = 5
        Me._Label_3.Tag = "Description"
        Me._Label_3.Text = "Diễn giải"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me._Label_0.Tag = "Acount code"
        Me._Label_0.Text = "Mã tài khoản"
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
        Me._Label_1.Size = New System.Drawing.Size(177, 17)
        Me._Label_1.TabIndex = 3
        Me._Label_1.Tag = "Description"
        Me._Label_1.Text = "Diễn giải"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.GrdNT.Location = New System.Drawing.Point(8, 72)
        Me.GrdNT.Name = "GrdNT"
        Me.GrdNT.Row = 0
        Me.GrdNT.Rows = 0
        Me.GrdNT.Selectable = True
        Me.GrdNT.SelectedTextColor = System.Drawing.Color.White
        Me.GrdNT.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.GrdNT.ShowBorder = True
        Me.GrdNT.ShowFocusRect = False
        Me.GrdNT.Size = New System.Drawing.Size(545, 358)
        Me.GrdNT.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdNT.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdNT.TabIndex = 10
        '
        'FrmTaikhoantudong
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(561, 457)
        Me.Controls.Add(Me.GrdNT)
        Me.Controls.Add(Me.CmdChitiet)
        Me.Controls.Add(Me._txtNhap_1)
        Me.Controls.Add(Me._txtNhap_0)
        Me.Controls.Add(Me.Tk2)
        Me.Controls.Add(Me.Tk1)
        Me.Controls.Add(Me.Tieude)
        Me.Controls.Add(Me._LbTK_1)
        Me.Controls.Add(Me._LbTK_0)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(54, 75)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTaikhoantudong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Form Account"
        Me.Text = "Tài khoản mẫu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializetxtNhap()
		Me.txtNhap(1) = _txtNhap_1
		Me.txtNhap(0) = _txtNhap_0
	End Sub
	Sub InitializeLbTK()
		Me.LbTK(1) = _LbTK_1
		Me.LbTK(0) = _LbTK_0
	End Sub
	Sub InitializeLabel()
		Me.Label(4) = _Label_4
		Me.Label(3) = _Label_3
		Me.Label(0) = _Label_0
		Me.Label(1) = _Label_1
	End Sub
#End Region 
End Class
