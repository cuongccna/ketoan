<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHD
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializetxtNhap()
		InitializeMedNgay()
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
    Public WithEvents GrdNT As ListViewEx.ListviewExt
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _txtNhap_6 As System.Windows.Forms.TextBox
    Private WithEvents _txtNhap_5 As System.Windows.Forms.TextBox
    Private WithEvents _txtNhap_4 As System.Windows.Forms.TextBox
    Private WithEvents _txtNhap_3 As System.Windows.Forms.TextBox
    Private WithEvents _txtNhap_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtNhap_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtNhap_0 As System.Windows.Forms.TextBox
    Private WithEvents _MedNgay_0 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _MedNgay_1 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Public Command(3) As System.Windows.Forms.Button
    Public Command1(3) As System.Windows.Forms.Button
    Public Label(8) As System.Windows.Forms.Label
    Public MedNgay(1) As System.Windows.Forms.MaskedTextBox
    Public txtNhap(6) As System.Windows.Forms.TextBox
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._txtNhap_6 = New System.Windows.Forms.TextBox
        Me._txtNhap_5 = New System.Windows.Forms.TextBox
        Me._txtNhap_4 = New System.Windows.Forms.TextBox
        Me._txtNhap_3 = New System.Windows.Forms.TextBox
        Me._txtNhap_2 = New System.Windows.Forms.TextBox
        Me._txtNhap_1 = New System.Windows.Forms.TextBox
        Me._txtNhap_0 = New System.Windows.Forms.TextBox
        Me._MedNgay_0 = New System.Windows.Forms.MaskedTextBox
        Me._MedNgay_1 = New System.Windows.Forms.MaskedTextBox
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Label_5 = New System.Windows.Forms.Label
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me.GrdNT = New ListViewEx.ListviewExt
        Me._OptNhapKhau_ = New System.Windows.Forms.RadioButton
        Me._OptNoiDia_ = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(721, 436)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 26
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(641, 436)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 25
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(561, 436)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 24
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.add16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(481, 436)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 23
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        '
        '_txtNhap_6
        '
        Me._txtNhap_6.AcceptsReturn = True
        Me._txtNhap_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_6.Location = New System.Drawing.Point(728, 404)
        Me._txtNhap_6.MaxLength = 2
        Me._txtNhap_6.Multiline = True
        Me._txtNhap_6.Name = "_txtNhap_6"
        Me._txtNhap_6.Size = New System.Drawing.Size(47, 20)
        Me._txtNhap_6.TabIndex = 8
        Me._txtNhap_6.Tag = "0"
        Me._txtNhap_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtNhap_5
        '
        Me._txtNhap_5.AcceptsReturn = True
        Me._txtNhap_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_5.Location = New System.Drawing.Point(592, 404)
        Me._txtNhap_5.MaxLength = 20
        Me._txtNhap_5.Name = "_txtNhap_5"
        Me._txtNhap_5.Size = New System.Drawing.Size(73, 20)
        Me._txtNhap_5.TabIndex = 6
        Me._txtNhap_5.Tag = "0"
        Me._txtNhap_5.Text = "..."
        '
        '_txtNhap_4
        '
        Me._txtNhap_4.AcceptsReturn = True
        Me._txtNhap_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_4.Location = New System.Drawing.Point(480, 404)
        Me._txtNhap_4.MaxLength = 20
        Me._txtNhap_4.Multiline = True
        Me._txtNhap_4.Name = "_txtNhap_4"
        Me._txtNhap_4.Size = New System.Drawing.Size(113, 20)
        Me._txtNhap_4.TabIndex = 5
        Me._txtNhap_4.Tag = "0"
        Me._txtNhap_4.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._txtNhap_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtNhap_3
        '
        Me._txtNhap_3.AcceptsReturn = True
        Me._txtNhap_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_3.Location = New System.Drawing.Point(352, 404)
        Me._txtNhap_3.MaxLength = 50
        Me._txtNhap_3.Name = "_txtNhap_3"
        Me._txtNhap_3.ReadOnly = True
        Me._txtNhap_3.Size = New System.Drawing.Size(129, 20)
        Me._txtNhap_3.TabIndex = 4
        Me._txtNhap_3.TabStop = False
        Me._txtNhap_3.Tag = "0"
        Me._txtNhap_3.Text = "..."
        '
        '_txtNhap_2
        '
        Me._txtNhap_2.AcceptsReturn = True
        Me._txtNhap_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_2.Location = New System.Drawing.Point(280, 404)
        Me._txtNhap_2.MaxLength = 20
        Me._txtNhap_2.Name = "_txtNhap_2"
        Me._txtNhap_2.Size = New System.Drawing.Size(73, 20)
        Me._txtNhap_2.TabIndex = 3
        Me._txtNhap_2.Tag = "0"
        Me._txtNhap_2.Text = "..."
        '
        '_txtNhap_1
        '
        Me._txtNhap_1.AcceptsReturn = True
        Me._txtNhap_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_1.Location = New System.Drawing.Point(152, 404)
        Me._txtNhap_1.MaxLength = 50
        Me._txtNhap_1.Name = "_txtNhap_1"
        Me._txtNhap_1.Size = New System.Drawing.Size(129, 20)
        Me._txtNhap_1.TabIndex = 2
        Me._txtNhap_1.Text = "..."
        '
        '_txtNhap_0
        '
        Me._txtNhap_0.AcceptsReturn = True
        Me._txtNhap_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_0.Location = New System.Drawing.Point(8, 404)
        Me._txtNhap_0.MaxLength = 20
        Me._txtNhap_0.Name = "_txtNhap_0"
        Me._txtNhap_0.Size = New System.Drawing.Size(89, 20)
        Me._txtNhap_0.TabIndex = 0
        Me._txtNhap_0.Text = "..."
        '
        '_MedNgay_0
        '
        Me._MedNgay_0.AllowPromptAsInput = False
        Me._MedNgay_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_0.Location = New System.Drawing.Point(96, 404)
        Me._MedNgay_0.Mask = "00/00/0000"
        Me._MedNgay_0.Name = "_MedNgay_0"
        Me._MedNgay_0.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_0.TabIndex = 1
        '
        '_MedNgay_1
        '
        Me._MedNgay_1.AllowPromptAsInput = False
        Me._MedNgay_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_1.Location = New System.Drawing.Point(664, 404)
        Me._MedNgay_1.Mask = "00/00/0000"
        Me._MedNgay_1.Name = "_MedNgay_1"
        Me._MedNgay_1.Size = New System.Drawing.Size(65, 20)
        Me._MedNgay_1.TabIndex = 7
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.Color.Black
        Me._Label_8.Location = New System.Drawing.Point(728, 8)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(66, 17)
        Me._Label_8.TabIndex = 22
        Me._Label_8.Tag = "Month"
        Me._Label_8.Text = "Tháng nhập"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(664, 8)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(65, 17)
        Me._Label_7.TabIndex = 21
        Me._Label_7.Tag = "Date"
        Me._Label_7.Text = "Ngày ký HD"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.Color.Black
        Me._Label_6.Location = New System.Drawing.Point(352, 8)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(129, 17)
        Me._Label_6.TabIndex = 20
        Me._Label_6.Tag = "Name"
        Me._Label_6.Text = "Tên đơn vị ký HĐ"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.Color.Black
        Me._Label_5.Location = New System.Drawing.Point(592, 8)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(73, 17)
        Me._Label_5.TabIndex = 19
        Me._Label_5.Tag = "Notes"
        Me._Label_5.Text = "Ghi chú"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(480, 8)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(113, 17)
        Me._Label_4.TabIndex = 18
        Me._Label_4.Tag = "Value"
        Me._Label_4.Text = "Giá trị HĐ"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me._Label_3.Size = New System.Drawing.Size(73, 17)
        Me._Label_3.TabIndex = 17
        Me._Label_3.Tag = "Company"
        Me._Label_3.Text = "Đơn vị ký HĐ"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.Black
        Me._Label_2.Location = New System.Drawing.Point(152, 8)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(129, 17)
        Me._Label_2.TabIndex = 16
        Me._Label_2.Tag = "Contract code"
        Me._Label_2.Text = "Số hợp đồng"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(96, 8)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(57, 17)
        Me._Label_1.TabIndex = 14
        Me._Label_1.Tag = "Date"
        Me._Label_1.Text = "Ngày TK"
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
        Me._Label_0.Size = New System.Drawing.Size(89, 17)
        Me._Label_0.TabIndex = 13
        Me._Label_0.Tag = "Contract Code"
        Me._Label_0.Text = "Số hiệu tờ khai"
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
        Me.GrdNT.Location = New System.Drawing.Point(8, 24)
        Me.GrdNT.Name = "GrdNT"
        Me.GrdNT.Row = 0
        Me.GrdNT.Rows = 0
        Me.GrdNT.Selectable = True
        Me.GrdNT.SelectedTextColor = System.Drawing.Color.White
        Me.GrdNT.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.GrdNT.ShowBorder = True
        Me.GrdNT.ShowFocusRect = False
        Me.GrdNT.Size = New System.Drawing.Size(786, 382)
        Me.GrdNT.SortType = ListViewEx.SortTypes.InsertionSort
        Me.GrdNT.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.GrdNT.TabIndex = 10
        '
        '_OptNhapKhau_
        '
        Me._OptNhapKhau_.BackColor = System.Drawing.Color.Transparent
        Me._OptNhapKhau_.Checked = True
        Me._OptNhapKhau_.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptNhapKhau_.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptNhapKhau_.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptNhapKhau_.Location = New System.Drawing.Point(12, 426)
        Me._OptNhapKhau_.Name = "_OptNhapKhau_"
        Me._OptNhapKhau_.Size = New System.Drawing.Size(81, 17)
        Me._OptNhapKhau_.TabIndex = 27
        Me._OptNhapKhau_.TabStop = True
        Me._OptNhapKhau_.Tag = "Imports"
        Me._OptNhapKhau_.Text = "Nhập khẩu"
        Me._OptNhapKhau_.UseVisualStyleBackColor = False
        '
        '_OptNoiDia_
        '
        Me._OptNoiDia_.BackColor = System.Drawing.Color.Transparent
        Me._OptNoiDia_.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptNoiDia_.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptNoiDia_.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptNoiDia_.Location = New System.Drawing.Point(12, 444)
        Me._OptNoiDia_.Name = "_OptNoiDia_"
        Me._OptNoiDia_.Size = New System.Drawing.Size(81, 17)
        Me._OptNoiDia_.TabIndex = 28
        Me._OptNoiDia_.Tag = "Domestic"
        Me._OptNoiDia_.Text = "Nội địa"
        Me._OptNoiDia_.UseVisualStyleBackColor = False
        '
        'FrmHD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(800, 468)
        Me.Controls.Add(Me.GrdNT)
        Me.Controls.Add(Me._txtNhap_0)
        Me.Controls.Add(Me._MedNgay_0)
        Me.Controls.Add(Me._txtNhap_1)
        Me.Controls.Add(Me._txtNhap_2)
        Me.Controls.Add(Me._txtNhap_3)
        Me.Controls.Add(Me._txtNhap_4)
        Me.Controls.Add(Me._txtNhap_5)
        Me.Controls.Add(Me._MedNgay_1)
        Me.Controls.Add(Me._txtNhap_6)
        Me.Controls.Add(Me._OptNoiDia_)
        Me.Controls.Add(Me._OptNhapKhau_)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_5)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(4, 70)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmHD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Contract List"
        Me.Text = "Danh sách Hợp đồng kinh tế"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Sub InitializetxtNhap()
        Me.txtNhap(6) = _txtNhap_6
        Me.txtNhap(5) = _txtNhap_5
        Me.txtNhap(4) = _txtNhap_4
        Me.txtNhap(3) = _txtNhap_3
        Me.txtNhap(2) = _txtNhap_2
        Me.txtNhap(1) = _txtNhap_1
        Me.txtNhap(0) = _txtNhap_0
    End Sub
    Sub InitializeMedNgay()
        Me.MedNgay(0) = _MedNgay_0
        Me.MedNgay(1) = _MedNgay_1
    End Sub
    Sub InitializeLabel()
        Me.Label(8) = _Label_8
        Me.Label(7) = _Label_7
        Me.Label(6) = _Label_6
        Me.Label(5) = _Label_5
        Me.Label(4) = _Label_4
        Me.Label(3) = _Label_3
        Me.Label(2) = _Label_2
        Me.Label(1) = _Label_1
        Me.Label(0) = _Label_0
    End Sub    
    Sub InitializeCommand()
        Me.Command(3) = _Command_3
        Me.Command(2) = _Command_2
        Me.Command(1) = _Command_1
        Me.Command(0) = _Command_0
    End Sub
    Private WithEvents _OptNhapKhau_ As System.Windows.Forms.RadioButton
    Private WithEvents _OptNoiDia_ As System.Windows.Forms.RadioButton
#End Region
End Class
