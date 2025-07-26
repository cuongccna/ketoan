<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBacthuemonbai
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeTxtThue()
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
	Public WithEvents GrdThue  As ListviewEx.ListviewExt 
	Private WithEvents _TxtThue_2 As System.Windows.Forms.TextBox
	Private WithEvents _TxtThue_1 As System.Windows.Forms.TextBox
	Private WithEvents _TxtThue_0 As System.Windows.Forms.TextBox
	Private WithEvents _Label_0 As System.Windows.Forms.Label
	Private WithEvents _Label_1 As System.Windows.Forms.Label
	Private WithEvents _Label_2 As System.Windows.Forms.Label
	Public Label(2) As System.Windows.Forms.Label
	Public TxtThue(2) As System.Windows.Forms.TextBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBacthuemonbai))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._TxtThue_2 = New System.Windows.Forms.TextBox()
        Me._TxtThue_1 = New System.Windows.Forms.TextBox()
        Me._TxtThue_0 = New System.Windows.Forms.TextBox()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me._Label_1 = New System.Windows.Forms.Label()
        Me._Label_2 = New System.Windows.Forms.Label()
        Me.GrdThue = New ListViewEx.ListviewExt()
        Me.SuspendLayout()
        '
        '_TxtThue_2
        '
        Me._TxtThue_2.AcceptsReturn = True
        Me._TxtThue_2.BackColor = System.Drawing.SystemColors.Window
        Me._TxtThue_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtThue_2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtThue_2.Location = New System.Drawing.Point(216, 136)
        Me._TxtThue_2.MaxLength = 0
        Me._TxtThue_2.Name = "_TxtThue_2"
        Me._TxtThue_2.Size = New System.Drawing.Size(145, 22)
        Me._TxtThue_2.TabIndex = 2
        Me._TxtThue_2.Text = "0"
        Me._TxtThue_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_TxtThue_1
        '
        Me._TxtThue_1.AcceptsReturn = True
        Me._TxtThue_1.BackColor = System.Drawing.SystemColors.Window
        Me._TxtThue_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtThue_1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtThue_1.Location = New System.Drawing.Point(72, 136)
        Me._TxtThue_1.MaxLength = 0
        Me._TxtThue_1.Name = "_TxtThue_1"
        Me._TxtThue_1.Size = New System.Drawing.Size(145, 22)
        Me._TxtThue_1.TabIndex = 1
        Me._TxtThue_1.Text = "0"
        Me._TxtThue_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_TxtThue_0
        '
        Me._TxtThue_0.AcceptsReturn = True
        Me._TxtThue_0.BackColor = System.Drawing.SystemColors.Window
        Me._TxtThue_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtThue_0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtThue_0.Location = New System.Drawing.Point(8, 136)
        Me._TxtThue_0.MaxLength = 0
        Me._TxtThue_0.Name = "_TxtThue_0"
        Me._TxtThue_0.Size = New System.Drawing.Size(65, 22)
        Me._TxtThue_0.TabIndex = 0
        Me._TxtThue_0.Text = "0"
        Me._TxtThue_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me._Label_0.Size = New System.Drawing.Size(65, 17)
        Me._Label_0.TabIndex = 6
        Me._Label_0.Tag = "Level"
        Me._Label_0.Text = "Bậc"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(72, 8)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(145, 17)
        Me._Label_1.TabIndex = 5
        Me._Label_1.Tag = "Registered Capital"
        Me._Label_1.Text = "Vốn đăng ký"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.Black
        Me._Label_2.Location = New System.Drawing.Point(216, 8)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(145, 17)
        Me._Label_2.TabIndex = 4
        Me._Label_2.Tag = "Amount"
        Me._Label_2.Text = "Mức thuế môn bài cả năm"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GrdThue
        '
        Me.GrdThue.AllowColumnResize = True
        Me.GrdThue.AllowMultiselect = False
        Me.GrdThue.AlternateBackground = System.Drawing.Color.DarkGreen
        Me.GrdThue.AlternatingColors = False
        Me.GrdThue.AutoHeight = True
        Me.GrdThue.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdThue.BackgroundStretchToFit = True
        Me.GrdThue.Col = 0
        Me.GrdThue.Cols = 0
        Me.GrdThue.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me.GrdThue.FullRowSelect = True
        Me.GrdThue.GridColor = System.Drawing.Color.LightGray
        Me.GrdThue.GridLines = ListViewEx.GLGridLines.gridBoth
        Me.GrdThue.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me.GrdThue.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me.GrdThue.HeaderHeight = 22
        Me.GrdThue.HeaderVisible = True
        Me.GrdThue.HeaderWordWrap = False
        Me.GrdThue.HotColumnTracking = False
        Me.GrdThue.HotItemTracking = False
        Me.GrdThue.HotTrackingColor = System.Drawing.Color.LightGray
        Me.GrdThue.HoverEvents = False
        Me.GrdThue.HoverTime = 1
        Me.GrdThue.ImageList = Nothing
        Me.GrdThue.ItemHeight = 18
        Me.GrdThue.ItemWordWrap = False
        Me.GrdThue.Location = New System.Drawing.Point(8, 24)
        Me.GrdThue.Name = "GrdThue"
        Me.GrdThue.Row = 0
        Me.GrdThue.Rows = 0
        Me.GrdThue.Selectable = True
        Me.GrdThue.SelectedTextColor = System.Drawing.Color.White
        Me.GrdThue.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.GrdThue.ShowBorder = True
        Me.GrdThue.ShowFocusRect = False
        Me.GrdThue.Size = New System.Drawing.Size(353, 113)
        Me.GrdThue.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdThue.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdThue.TabIndex = 10
        '
        'FrmBacthuemonbai
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(368, 162)
        Me.Controls.Add(Me.GrdThue)
        Me.Controls.Add(Me._TxtThue_2)
        Me.Controls.Add(Me._TxtThue_1)
        Me.Controls.Add(Me._TxtThue_0)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBacthuemonbai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Level of excise tax"
        Me.Text = "Bậc thuế môn bài"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializeTxtThue()
		Me.TxtThue(2) = _TxtThue_2
		Me.TxtThue(1) = _TxtThue_1
		Me.TxtThue(0) = _TxtThue_0
	End Sub
	Sub InitializeLabel()
		Me.Label(0) = _Label_0
		Me.Label(1) = _Label_1
		Me.Label(2) = _Label_2
	End Sub
#End Region 
End Class
