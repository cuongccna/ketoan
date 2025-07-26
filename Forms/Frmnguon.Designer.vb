<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNguon
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializetxtNhap()
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
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button

    Private WithEvents _txtNhap_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtNhap_0 As System.Windows.Forms.TextBox
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Public Command(3) As System.Windows.Forms.Button
    Public Command1(3) As System.Windows.Forms.Button
    Public Label(1) As System.Windows.Forms.Label
    Public txtNhap(1) As System.Windows.Forms.TextBox
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._txtNhap_1 = New System.Windows.Forms.TextBox
        Me._txtNhap_0 = New System.Windows.Forms.TextBox
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me.GrdNT = New ListViewEx.ListviewExt
        Me.SuspendLayout()
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(299, 70)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 11
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(299, 101)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 12
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(299, 39)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 10
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.add16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(299, 8)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 9
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        '
        '_txtNhap_1
        '
        Me._txtNhap_1.AcceptsReturn = True
        Me._txtNhap_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_1.Location = New System.Drawing.Point(64, 199)
        Me._txtNhap_1.MaxLength = 50
        Me._txtNhap_1.Name = "_txtNhap_1"
        Me._txtNhap_1.Size = New System.Drawing.Size(229, 20)
        Me._txtNhap_1.TabIndex = 1
        Me._txtNhap_1.Text = "..."
        '
        '_txtNhap_0
        '
        Me._txtNhap_0.AcceptsReturn = True
        Me._txtNhap_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_0.Location = New System.Drawing.Point(8, 199)
        Me._txtNhap_0.MaxLength = 20
        Me._txtNhap_0.Name = "_txtNhap_0"
        Me._txtNhap_0.Size = New System.Drawing.Size(57, 20)
        Me._txtNhap_0.TabIndex = 0
        Me._txtNhap_0.Text = "..."
        Me._txtNhap_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(64, 8)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(229, 17)
        Me._Label_1.TabIndex = 7
        Me._Label_1.Tag = "Description"
        Me._Label_1.Text = "Diễn giải"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me._Label_0.Size = New System.Drawing.Size(57, 17)
        Me._Label_0.TabIndex = 6
        Me._Label_0.Tag = "Code"
        Me._Label_0.Text = "Số hiệu"
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
        Me.GrdNT.ControlStyle = ListViewEx.GLControlStyles.XP
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
        Me.GrdNT.Location = New System.Drawing.Point(8, 24)
        Me.GrdNT.Name = "GrdNT"
        Me.GrdNT.Row = 0
        Me.GrdNT.Rows = 0
        Me.GrdNT.Selectable = True
        Me.GrdNT.SelectedTextColor = System.Drawing.Color.White
        Me.GrdNT.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.GrdNT.ShowBorder = True
        Me.GrdNT.ShowFocusRect = False
        Me.GrdNT.Size = New System.Drawing.Size(285, 176)
        Me.GrdNT.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdNT.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdNT.TabIndex = 13
        '
        'FrmNguon
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(377, 227)
        Me.Controls.Add(Me.GrdNT)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._txtNhap_1)
        Me.Controls.Add(Me._txtNhap_0)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(127, 62)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNguon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "List of sources imports - exports"
        Me.Text = "Danh sách nguồn nhập xuất vật tư"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Sub InitializetxtNhap()
        Me.txtNhap(1) = _txtNhap_1
        Me.txtNhap(0) = _txtNhap_0
    End Sub
    Sub InitializeLabel()
        Me.Label(1) = _Label_1
        Me.Label(0) = _Label_0
    End Sub
    Sub InitializeCommand()
        Me.Command(2) = _Command_2
        Me.Command(3) = _Command_3
        Me.Command(1) = _Command_1
        Me.Command(0) = _Command_0
    End Sub
    Friend WithEvents GrdNT As ListviewEx.ListviewExt
#End Region
End Class
