<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDSCCDC
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeLabel()
		InitializeCommand1()
		InitializeCommand()
		InitializeCombo()
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
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Private WithEvents _Combo_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Combo_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Combo_3 As ComboBoxEx.ComboBoxExt
    Public WithEvents Grid As ListviewEx.ListviewExt
    Private WithEvents _Command1_2 As System.Windows.Forms.Button
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Label_9 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Public Combo(3) As ComboBoxEx.ComboBoxExt
    Public Command(2) As System.Windows.Forms.Button
    Public Command1(2) As System.Windows.Forms.Button
    Public Label(10) As System.Windows.Forms.Label
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDSCCDC))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Command1_1 = New System.Windows.Forms.Button
        Me._Command1_0 = New System.Windows.Forms.Button
        Me._Combo_1 = New ComboBoxEx.ComboBoxExt
        Me._Combo_0 = New ComboBoxEx.ComboBoxExt
        Me._Combo_3 = New ComboBoxEx.ComboBoxExt
        Me._Command1_2 = New System.Windows.Forms.Button
        Me._Label_10 = New System.Windows.Forms.Label
        Me._Label_9 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_5 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me.Grid = New ListViewEx.ListviewExt
        Me.SuspendLayout()
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(400, 440)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 19
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(560, 440)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 18
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.select16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(480, 440)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 17
        Me._Command_0.Tag = "Choose"
        Me._Command_0.Text = "&Chọn"
        '
        '_Command1_1
        '
        Me._Command1_1.BackColor = System.Drawing.Color.Silver
        Me._Command1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_1.Image = CType(resources.GetObject("_Command1_1.Image"), System.Drawing.Image)
        Me._Command1_1.Location = New System.Drawing.Point(560, 440)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(73, 25)
        Me._Command1_1.TabIndex = 5
        Me._Command1_1.TabStop = False
        Me._Command1_1.Tag = "&Return"
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
        Me._Command1_0.Location = New System.Drawing.Point(480, 440)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(73, 25)
        Me._Command1_0.TabIndex = 4
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&SELECT"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        '_Combo_1
        '
        Me._Combo_1.BackColor = System.Drawing.SystemColors.Window
        Me._Combo_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_1.Location = New System.Drawing.Point(352, 40)
        Me._Combo_1.Name = "_Combo_1"
        Me._Combo_1.Size = New System.Drawing.Size(281, 21)
        Me._Combo_1.TabIndex = 2
        '
        '_Combo_0
        '
        Me._Combo_0.BackColor = System.Drawing.SystemColors.Window
        Me._Combo_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_0.Location = New System.Drawing.Point(352, 8)
        Me._Combo_0.Name = "_Combo_0"
        Me._Combo_0.Size = New System.Drawing.Size(281, 21)
        Me._Combo_0.TabIndex = 1
        '
        '_Combo_3
        '
        Me._Combo_3.BackColor = System.Drawing.SystemColors.Window
        Me._Combo_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Combo_3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Combo_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Combo_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Combo_3.Location = New System.Drawing.Point(56, 5)
        Me._Combo_3.Name = "_Combo_3"
        Me._Combo_3.Size = New System.Drawing.Size(73, 21)
        Me._Combo_3.TabIndex = 0
        '
        '_Command1_2
        '
        Me._Command1_2.BackColor = System.Drawing.Color.Silver
        Me._Command1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_2.Image = CType(resources.GetObject("_Command1_2.Image"), System.Drawing.Image)
        Me._Command1_2.Location = New System.Drawing.Point(400, 440)
        Me._Command1_2.Name = "_Command1_2"
        Me._Command1_2.Size = New System.Drawing.Size(73, 25)
        Me._Command1_2.TabIndex = 6
        Me._Command1_2.TabStop = False
        Me._Command1_2.Tag = "&DELETE"
        Me._Command1_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_2.UseVisualStyleBackColor = False
        Me._Command1_2.Visible = False
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.Color.Black
        Me._Label_10.Location = New System.Drawing.Point(504, 72)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(41, 17)
        Me._Label_10.TabIndex = 16
        Me._Label_10.Tag = "Month"
        Me._Label_10.Text = "Kỳ PB"
        Me._Label_10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_9
        '
        Me._Label_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.Color.Black
        Me._Label_9.Location = New System.Drawing.Point(544, 72)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.Size = New System.Drawing.Size(87, 17)
        Me._Label_9.TabIndex = 15
        Me._Label_9.Tag = "Allocation"
        Me._Label_9.Text = "Mức PB"
        Me._Label_9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.Color.Black
        Me._Label_8.Location = New System.Drawing.Point(416, 72)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(89, 17)
        Me._Label_8.TabIndex = 14
        Me._Label_8.Tag = "Rest Value"
        Me._Label_8.Text = "Còn lại"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(328, 72)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(89, 17)
        Me._Label_7.TabIndex = 13
        Me._Label_7.Tag = "Original Value"
        Me._Label_7.Text = "Nguyên giá"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.Color.Black
        Me._Label_6.Location = New System.Drawing.Point(258, 72)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(71, 17)
        Me._Label_6.TabIndex = 12
        Me._Label_6.Tag = "Inc. Date"
        Me._Label_6.Text = "Ngày tăng"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(8, 72)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(89, 17)
        Me._Label_1.TabIndex = 11
        Me._Label_1.Tag = "Code"
        Me._Label_1.Text = "Số hiệu"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(96, 72)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(163, 17)
        Me._Label_4.TabIndex = 10
        Me._Label_4.Tag = "Name"
        Me._Label_4.Text = "Tên"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.Color.Black
        Me._Label_0.Location = New System.Drawing.Point(275, 42)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(70, 17)
        Me._Label_0.TabIndex = 9
        Me._Label_0.Tag = "Class:"
        Me._Label_0.Text = "Loại :"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.Transparent
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.Color.Black
        Me._Label_5.Location = New System.Drawing.Point(272, 10)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(73, 17)
        Me._Label_5.TabIndex = 8
        Me._Label_5.Tag = "Account :"
        Me._Label_5.Text = "Tài khoản :"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.Transparent
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.Black
        Me._Label_3.Location = New System.Drawing.Point(8, 5)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(41, 17)
        Me._Label_3.TabIndex = 7
        Me._Label_3.Tag = "Month"
        Me._Label_3.Text = "Tháng :"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Grid
        '
        Me.Grid.AllowColumnResize = True
        Me.Grid.AllowMultiselect = False
        Me.Grid.AlternateBackground = System.Drawing.Color.DarkGreen
        Me.Grid.AlternatingColors = False
        Me.Grid.AutoHeight = True
        Me.Grid.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Grid.BackgroundStretchToFit = True
        Me.Grid.Col = 0
        Me.Grid.Cols = 0
        Me.Grid.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me.Grid.FullRowSelect = True
        Me.Grid.GridColor = System.Drawing.Color.LightGray
        Me.Grid.GridLines = ListViewEx.GLGridLines.gridBoth
        Me.Grid.GridLineStyle = ListViewEx.GLGridLineStyles.gridNone
        Me.Grid.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me.Grid.HeaderHeight = 0
        Me.Grid.HeaderVisible = False
        Me.Grid.HeaderWordWrap = False
        Me.Grid.HotColumnTracking = False
        Me.Grid.HotItemTracking = False
        Me.Grid.HotTrackingColor = System.Drawing.Color.LightGray
        Me.Grid.HoverEvents = False
        Me.Grid.HoverTime = 1
        Me.Grid.ImageList = Nothing
        Me.Grid.ItemHeight = 18
        Me.Grid.ItemWordWrap = False
        Me.Grid.Location = New System.Drawing.Point(8, 88)
        Me.Grid.Name = "Grid"
        Me.Grid.Row = 0
        Me.Grid.Rows = 0
        Me.Grid.Selectable = True
        Me.Grid.SelectedTextColor = System.Drawing.Color.White
        Me.Grid.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.Grid.ShowBorder = True
        Me.Grid.ShowFocusRect = False
        Me.Grid.Size = New System.Drawing.Size(623, 346)
        Me.Grid.SortType = ListViewEx.SortTypes.InsertionSort
        Me.Grid.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.Grid.TabIndex = 10
        '
        'frmDSCCDC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(641, 472)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me._Combo_1)
        Me.Controls.Add(Me._Combo_0)
        Me.Controls.Add(Me._Combo_3)
        Me.Controls.Add(Me._Command1_2)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Label_9)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_5)
        Me.Controls.Add(Me._Label_3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(4, 37)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDSCCDC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Danh công cụ dụng cụ"
        Me.ResumeLayout(False)

    End Sub
	Sub InitializeLabel()
		Me.Label(10) = _Label_10
		Me.Label(9) = _Label_9
		Me.Label(8) = _Label_8
		Me.Label(7) = _Label_7
		Me.Label(6) = _Label_6
		Me.Label(1) = _Label_1
		Me.Label(4) = _Label_4
		Me.Label(0) = _Label_0
		Me.Label(5) = _Label_5
		Me.Label(3) = _Label_3
	End Sub
	Sub InitializeCommand1()
		Me.Command1(1) = _Command1_1
		Me.Command1(0) = _Command1_0
		Me.Command1(2) = _Command1_2
	End Sub
	Sub InitializeCommand()
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
	Sub InitializeCombo()
		Me.Combo(1) = _Combo_1
		Me.Combo(0) = _Combo_0
		Me.Combo(3) = _Combo_3
	End Sub
#End Region 
End Class
