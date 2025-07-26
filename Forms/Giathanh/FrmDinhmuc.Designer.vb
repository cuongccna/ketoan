<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDinhmuc
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
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
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Public WithEvents GrdChungtu As ListviewEx.ListviewExt
    Public WithEvents Xem As System.Windows.Forms.Button
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Public WithEvents LbSoCT As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Public Command(0) As System.Windows.Forms.Button
    Public Label(13) As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me._Command_0 = New System.Windows.Forms.Button
        Me.Xem = New System.Windows.Forms.Button
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_13 = New System.Windows.Forms.Label
        Me.LbSoCT = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me.GrdChungtu = New ListViewEx.ListviewExt
        Me.SuspendLayout()
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(464, 458)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 7
        Me._Command_0.Tag = "Return"
        Me._Command_0.Text = "Trở &về"
        '
        'Xem
        '
        Me.Xem.Image = Global.UNET.My.Resources.Resources.report16
        Me.Xem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Xem.Location = New System.Drawing.Point(384, 458)
        Me.Xem.Name = "Xem"
        Me.Xem.Size = New System.Drawing.Size(73, 25)
        Me.Xem.TabIndex = 9
        Me.Xem.Tag = "Preview"
        Me.Xem.Text = "&Xem"
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(448, 0)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(89, 17)
        Me._Label_4.TabIndex = 8
        Me._Label_4.Tag = "Quantity"
        Me._Label_4.Text = "Số lượng"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.Color.Black
        Me._Label_0.Location = New System.Drawing.Point(344, 0)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(65, 17)
        Me._Label_0.TabIndex = 6
        Me._Label_0.Tag = "Unit"
        Me._Label_0.Text = "Đơn vị tính"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.SystemColors.Control
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_13.Location = New System.Drawing.Point(8, 459)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(89, 17)
        Me._Label_13.TabIndex = 5
        Me._Label_13.Tag = "Total"
        Me._Label_13.Text = "Số thành phẩm"
        '
        'LbSoCT
        '
        Me.LbSoCT.BackColor = System.Drawing.SystemColors.Control
        Me.LbSoCT.Cursor = System.Windows.Forms.Cursors.Default
        Me.LbSoCT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSoCT.ForeColor = System.Drawing.Color.Blue
        Me.LbSoCT.Location = New System.Drawing.Point(96, 459)
        Me.LbSoCT.Name = "LbSoCT"
        Me.LbSoCT.Size = New System.Drawing.Size(33, 17)
        Me.LbSoCT.TabIndex = 4
        Me.LbSoCT.Text = "0"
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.Black
        Me._Label_3.Location = New System.Drawing.Point(408, 0)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(41, 17)
        Me._Label_3.TabIndex = 3
        Me._Label_3.Tag = "Month"
        Me._Label_3.Text = "Tháng"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.Black
        Me._Label_2.Location = New System.Drawing.Point(88, 0)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(257, 17)
        Me._Label_2.TabIndex = 2
        Me._Label_2.Tag = "Description"
        Me._Label_2.Text = "Diễn giải"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(8, 0)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(81, 17)
        Me._Label_1.TabIndex = 1
        Me._Label_1.Tag = "Code"
        Me._Label_1.Text = "Số hiệu"
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
        Me.GrdChungtu.Location = New System.Drawing.Point(8, 16)
        Me.GrdChungtu.Name = "GrdChungtu"
        Me.GrdChungtu.Row = 0
        Me.GrdChungtu.Rows = 0
        Me.GrdChungtu.Selectable = True
        Me.GrdChungtu.SelectedTextColor = System.Drawing.Color.White
        Me.GrdChungtu.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.GrdChungtu.ShowBorder = True
        Me.GrdChungtu.ShowFocusRect = False
        Me.GrdChungtu.Size = New System.Drawing.Size(529, 436)
        Me.GrdChungtu.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdChungtu.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdChungtu.TabIndex = 10
        '
        'FrmDinhmuc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 488)
        Me.Controls.Add(Me.GrdChungtu)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me.Xem)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me.LbSoCT)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(79, 36)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDinhmuc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Norm of finished goods invoiced"
        Me.Text = "Định mức thành phẩm theo hóa đơn"
        Me.ResumeLayout(False)

    End Sub
	Sub InitializeLabel()
		Me.Label(4) = _Label_4
		Me.Label(0) = _Label_0
		Me.Label(13) = _Label_13
		Me.Label(3) = _Label_3
		Me.Label(2) = _Label_2
		Me.Label(1) = _Label_1
	End Sub
	Sub InitializeCommand()
		Me.Command(0) = _Command_0
	End Sub
#End Region 
End Class
