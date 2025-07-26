<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDCPTung
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeText_Renamed()
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
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Text_0 As System.Windows.Forms.TextBox
    Private WithEvents _Text_1 As System.Windows.Forms.TextBox
    Private WithEvents _Text_2 As System.Windows.Forms.TextBox
    Private WithEvents _Text_3 As System.Windows.Forms.TextBox
    Private WithEvents _Command1_2 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Public WithEvents Grid As ListviewEx.ListviewExt
    Private WithEvents _Command1_3 As System.Windows.Forms.Button
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Public Command(3) As System.Windows.Forms.Button
    Public Command1(3) As System.Windows.Forms.Button
    Public Label(3) As System.Windows.Forms.Label
    Public Text_Renamed(3) As System.Windows.Forms.TextBox
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDCPTung))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Text_0 = New System.Windows.Forms.TextBox
        Me._Text_1 = New System.Windows.Forms.TextBox
        Me._Text_2 = New System.Windows.Forms.TextBox
        Me._Text_3 = New System.Windows.Forms.TextBox
        Me._Command1_2 = New System.Windows.Forms.Button
        Me._Command1_1 = New System.Windows.Forms.Button
        Me._Command1_0 = New System.Windows.Forms.Button
        Me._Command1_3 = New System.Windows.Forms.Button
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me.Grid = New ListViewEx.ListviewExt
        Me.SuspendLayout()
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(384, 120)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 8
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(384, 88)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 7
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(384, 56)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 6
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.add16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(384, 24)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 5
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        '
        '_Text_0
        '
        Me._Text_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Text_0.Location = New System.Drawing.Point(8, 203)
        Me._Text_0.MaxLength = 0
        Me._Text_0.Name = "_Text_0"
        Me._Text_0.Size = New System.Drawing.Size(161, 20)
        Me._Text_0.TabIndex = 1
        '
        '_Text_1
        '
        Me._Text_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Text_1.Location = New System.Drawing.Point(168, 203)
        Me._Text_1.MaxLength = 0
        Me._Text_1.Name = "_Text_1"
        Me._Text_1.Size = New System.Drawing.Size(57, 20)
        Me._Text_1.TabIndex = 2
        '
        '_Text_2
        '
        Me._Text_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Text_2.Location = New System.Drawing.Point(224, 204)
        Me._Text_2.MaxLength = 0
        Me._Text_2.Multiline = True
        Me._Text_2.Name = "_Text_2"
        Me._Text_2.Size = New System.Drawing.Size(57, 19)
        Me._Text_2.TabIndex = 3
        Me._Text_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Text_3
        '
        Me._Text_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Text_3.Location = New System.Drawing.Point(280, 204)
        Me._Text_3.MaxLength = 0
        Me._Text_3.Multiline = True
        Me._Text_3.Name = "_Text_3"
        Me._Text_3.Size = New System.Drawing.Size(97, 19)
        Me._Text_3.TabIndex = 4
        Me._Text_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Command1_2
        '
        Me._Command1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Command1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_2.Image = CType(resources.GetObject("_Command1_2.Image"), System.Drawing.Image)
        Me._Command1_2.Location = New System.Drawing.Point(384, 88)
        Me._Command1_2.Name = "_Command1_2"
        Me._Command1_2.Size = New System.Drawing.Size(73, 25)
        Me._Command1_2.TabIndex = 7
        Me._Command1_2.TabStop = False
        Me._Command1_2.Tag = "&DELETE"
        Me._Command1_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_2.UseVisualStyleBackColor = False
        Me._Command1_2.Visible = False
        '
        '_Command1_1
        '
        Me._Command1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Command1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_1.Image = CType(resources.GetObject("_Command1_1.Image"), System.Drawing.Image)
        Me._Command1_1.Location = New System.Drawing.Point(384, 56)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(73, 25)
        Me._Command1_1.TabIndex = 6
        Me._Command1_1.TabStop = False
        Me._Command1_1.Tag = "&Save"
        Me._Command1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_1.UseVisualStyleBackColor = False
        Me._Command1_1.Visible = False
        '
        '_Command1_0
        '
        Me._Command1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Command1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_0.Image = CType(resources.GetObject("_Command1_0.Image"), System.Drawing.Image)
        Me._Command1_0.Location = New System.Drawing.Point(384, 24)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(73, 25)
        Me._Command1_0.TabIndex = 5
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&Add"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        '_Command1_3
        '
        Me._Command1_3.BackColor = System.Drawing.SystemColors.Control
        Me._Command1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_3.Image = CType(resources.GetObject("_Command1_3.Image"), System.Drawing.Image)
        Me._Command1_3.Location = New System.Drawing.Point(384, 120)
        Me._Command1_3.Name = "_Command1_3"
        Me._Command1_3.Size = New System.Drawing.Size(73, 25)
        Me._Command1_3.TabIndex = 8
        Me._Command1_3.TabStop = False
        Me._Command1_3.Tag = "&Return"
        Me._Command1_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_3.UseVisualStyleBackColor = False
        Me._Command1_3.Visible = False
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
        Me._Label_0.Size = New System.Drawing.Size(161, 17)
        Me._Label_0.TabIndex = 12
        Me._Label_0.Tag = "Name"
        Me._Label_0.Text = "Tên"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(168, 8)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(57, 17)
        Me._Label_1.TabIndex = 11
        Me._Label_1.Tag = "Unit"
        Me._Label_1.Text = "Đơn vị"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.Black
        Me._Label_2.Location = New System.Drawing.Point(224, 8)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(57, 17)
        Me._Label_2.TabIndex = 10
        Me._Label_2.Tag = "Quantity"
        Me._Label_2.Text = "Số lượng"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.Black
        Me._Label_3.Location = New System.Drawing.Point(280, 8)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(97, 17)
        Me._Label_3.TabIndex = 9
        Me._Label_3.Tag = "Amount"
        Me._Label_3.Text = "Giá trị"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.Grid.GridLines = ListViewEx.GLGridLines.gridHorizontal
        Me.Grid.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
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
        Me.Grid.Location = New System.Drawing.Point(8, 24)
        Me.Grid.Name = "Grid"
        Me.Grid.Row = 0
        Me.Grid.Rows = 0
        Me.Grid.Selectable = True
        Me.Grid.SelectedTextColor = System.Drawing.Color.White
        Me.Grid.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.Grid.ShowBorder = True
        Me.Grid.ShowFocusRect = False
        Me.Grid.Size = New System.Drawing.Size(369, 181)
        Me.Grid.SortType = ListViewEx.SortTypes.InsertionSort
        Me.Grid.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.Grid.TabIndex = 0
        '
        'frmDCPTung
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(465, 230)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Text_0)
        Me.Controls.Add(Me._Text_1)
        Me.Controls.Add(Me._Text_2)
        Me.Controls.Add(Me._Text_3)
        Me.Controls.Add(Me._Command1_2)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me._Command1_3)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(65, 137)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDCPTung"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Equipment List"
        Me.Text = "Dụng cụ, phụ tùng kèm theo tài sản"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializeText_Renamed()
		Me.Text_Renamed(0) = _Text_0
		Me.Text_Renamed(1) = _Text_1
		Me.Text_Renamed(2) = _Text_2
		Me.Text_Renamed(3) = _Text_3
	End Sub
	Sub InitializeLabel()
		Me.Label(0) = _Label_0
		Me.Label(1) = _Label_1
		Me.Label(2) = _Label_2
		Me.Label(3) = _Label_3
	End Sub
	Sub InitializeCommand1()
		Me.Command1(2) = _Command1_2
		Me.Command1(1) = _Command1_1
		Me.Command1(0) = _Command1_0
		Me.Command1(3) = _Command1_3
	End Sub
	Sub InitializeCommand()
		Me.Command(3) = _Command_3
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
#End Region 
End Class
