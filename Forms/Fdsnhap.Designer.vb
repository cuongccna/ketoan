<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FDsNhap
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
''' <summary>
''' 
''' </summary>
''' <param name="eventSender"></param>
''' <param name="eventArgs"></param>
''' <remarks></remarks>
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
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Public WithEvents GrdCT As ListViewEx.ListviewExt
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Public WithEvents LbVattu As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Public Command(1) As System.Windows.Forms.Button
    Public Command1(1) As System.Windows.Forms.Button
    Public Label(7) As System.Windows.Forms.Label
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me._Label_7 = New System.Windows.Forms.Label()
        Me._Label_6 = New System.Windows.Forms.Label()
        Me.LbVattu = New System.Windows.Forms.Label()
        Me._Label_5 = New System.Windows.Forms.Label()
        Me._Label_4 = New System.Windows.Forms.Label()
        Me._Label_3 = New System.Windows.Forms.Label()
        Me._Label_2 = New System.Windows.Forms.Label()
        Me._Label_1 = New System.Windows.Forms.Label()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me.GrdCT = New ListViewEx.ListviewExt()
        Me.SuspendLayout()
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(648, 440)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 13
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        '
        '_Command_0
        '
        Me._Command_0.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Xu_ly
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(568, 440)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 12
        Me._Command_0.Tag = "Choose"
        Me._Command_0.Text = "&Chọn"
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(632, 32)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(89, 17)
        Me._Label_7.TabIndex = 11
        Me._Label_7.Tag = "Amount USD"
        Me._Label_7.Text = "Thành tiền USD"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_7.Visible = False
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.Color.Black
        Me._Label_6.Location = New System.Drawing.Point(456, 32)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(89, 17)
        Me._Label_6.TabIndex = 10
        Me._Label_6.Tag = "Unit price"
        Me._Label_6.Text = "Đơn giá"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LbVattu
        '
        Me.LbVattu.AutoSize = True
        Me.LbVattu.BackColor = System.Drawing.Color.Transparent
        Me.LbVattu.Cursor = System.Windows.Forms.Cursors.Default
        Me.LbVattu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbVattu.ForeColor = System.Drawing.Color.Blue
        Me.LbVattu.Location = New System.Drawing.Point(56, 8)
        Me.LbVattu.Name = "LbVattu"
        Me.LbVattu.Size = New System.Drawing.Size(25, 14)
        Me.LbVattu.TabIndex = 6
        Me.LbVattu.Tag = "Name"
        Me.LbVattu.Text = "Tên"
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.Transparent
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_5.Location = New System.Drawing.Point(8, 8)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(42, 17)
        Me._Label_5.TabIndex = 5
        Me._Label_5.Tag = "Material"
        Me._Label_5.Text = "Vật tư"
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(544, 32)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(89, 17)
        Me._Label_4.TabIndex = 4
        Me._Label_4.Tag = "Amount"
        Me._Label_4.Text = "Thành tiền"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.Black
        Me._Label_3.Location = New System.Drawing.Point(368, 32)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(89, 17)
        Me._Label_3.TabIndex = 3
        Me._Label_3.Tag = "Quantity"
        Me._Label_3.Text = "Số lượng"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.Black
        Me._Label_2.Location = New System.Drawing.Point(152, 32)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(217, 17)
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
        Me._Label_1.Location = New System.Drawing.Point(96, 32)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(57, 17)
        Me._Label_1.TabIndex = 1
        Me._Label_1.Tag = "Date"
        Me._Label_1.Text = "Ngày CT"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.Color.Black
        Me._Label_0.Location = New System.Drawing.Point(8, 32)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(89, 17)
        Me._Label_0.TabIndex = 0
        Me._Label_0.Tag = "Vouchers Code"
        Me._Label_0.Text = "Số CT"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GrdCT
        '
        Me.GrdCT.AllowColumnResize = True
        Me.GrdCT.AllowMultiselect = False
        Me.GrdCT.AlternateBackground = System.Drawing.Color.DarkGreen
        Me.GrdCT.AlternatingColors = False
        Me.GrdCT.AutoHeight = True
        Me.GrdCT.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdCT.BackgroundStretchToFit = True
        Me.GrdCT.Col = 0
        Me.GrdCT.Cols = 0
        Me.GrdCT.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me.GrdCT.FullRowSelect = True
        Me.GrdCT.GridColor = System.Drawing.Color.LightGray
        Me.GrdCT.GridLines = ListViewEx.GLGridLines.gridBoth
        Me.GrdCT.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me.GrdCT.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me.GrdCT.HeaderHeight = 22
        Me.GrdCT.HeaderVisible = True
        Me.GrdCT.HeaderWordWrap = False
        Me.GrdCT.HotColumnTracking = False
        Me.GrdCT.HotItemTracking = False
        Me.GrdCT.HotTrackingColor = System.Drawing.Color.LightGray
        Me.GrdCT.HoverEvents = False
        Me.GrdCT.HoverTime = 1
        Me.GrdCT.ImageList = Nothing
        Me.GrdCT.ItemHeight = 18
        Me.GrdCT.ItemWordWrap = False
        Me.GrdCT.Location = New System.Drawing.Point(8, 49)
        Me.GrdCT.Name = "GrdCT"
        Me.GrdCT.Row = 0
        Me.GrdCT.Rows = 0
        Me.GrdCT.Selectable = True
        Me.GrdCT.SelectedTextColor = System.Drawing.Color.White
        Me.GrdCT.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.GrdCT.ShowBorder = True
        Me.GrdCT.ShowFocusRect = False
        Me.GrdCT.Size = New System.Drawing.Size(713, 385)
        Me.GrdCT.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdCT.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdCT.TabIndex = 10
        '
        'FDsNhap
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(730, 472)
        Me.Controls.Add(Me.GrdCT)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me.LbVattu)
        Me.Controls.Add(Me._Label_5)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(83, 75)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FDsNhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Danh sách phiếu nhập vật tư chưa tính giá xuất"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializeLabel()
		Me.Label(7) = _Label_7
		Me.Label(6) = _Label_6
		Me.Label(5) = _Label_5
		Me.Label(4) = _Label_4
		Me.Label(3) = _Label_3
		Me.Label(2) = _Label_2
		Me.Label(1) = _Label_1
		Me.Label(0) = _Label_0
	End Sub
	Sub InitializeCommand1()
        'Me.Command1(0) = _Command1_0
        'Me.Command1(1) = _Command1_1
	End Sub
	Sub InitializeCommand()
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
#End Region 
End Class
