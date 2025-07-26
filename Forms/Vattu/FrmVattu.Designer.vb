<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVattu
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
        isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		InitializetxtTon()
		InitializetxtNhap()
		InitializeTxtVT()
		InitializeSSOpt()
		InitializePanel()
		InitializeLine()
		InitializeLabel()
		InitializeGrdNT()
		InitializeFrame()
		InitializeCommand1()
		InitializeCommand()
		InitializeCmdChitiet()
		InitializeCboThang1()
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
    Public WithEvents SSCmdF As System.Windows.Forms.Button
    Private WithEvents _Command_4 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Public WithEvents Text1 As System.Windows.Forms.TextBox
    Private WithEvents _CboThang1_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboThang1_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Label_36 As System.Windows.Forms.Label
    Private WithEvents _Label_38 As System.Windows.Forms.Label
    Private WithEvents _Frame_4 As System.Windows.Forms.Panel
    Public WithEvents ChkNhap As System.Windows.Forms.CheckBox
    Private WithEvents _Label_34 As System.Windows.Forms.Label
    Private WithEvents _Label_33 As System.Windows.Forms.Label
    Private WithEvents _Label_35 As System.Windows.Forms.Label
    Private WithEvents _Label_37 As System.Windows.Forms.Label
    Public WithEvents Nhapxuat As System.Windows.Forms.Panel



    Private WithEvents _txtNhap_7 As System.Windows.Forms.TextBox
    Public WithEvents txtTyle As System.Windows.Forms.TextBox
    Private WithEvents _CmdChitiet_1 As System.Windows.Forms.Button
    Private WithEvents _txtNhap_6 As System.Windows.Forms.TextBox
    Private WithEvents _CmdChitiet_0 As System.Windows.Forms.Button
    Private WithEvents _txtNhap_3 As System.Windows.Forms.TextBox
    Private WithEvents _txtNhap_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtNhap_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtNhap_0 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtNhap_4 As System.Windows.Forms.TextBox
    Private WithEvents _txtNhap_5 As System.Windows.Forms.TextBox
    Public WithEvents CboThang As ComboBoxEx.ComboBoxExt
    Private WithEvents _txtNhap_10 As System.Windows.Forms.TextBox
    Private WithEvents _Label_39 As System.Windows.Forms.Label
    Private WithEvents _Line_14 As System.Windows.Forms.Label
    Private WithEvents _Label_45 As System.Windows.Forms.Label
    Private WithEvents _Label_46 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Private WithEvents _Label_15 As System.Windows.Forms.Label
    Private WithEvents _Label_18 As System.Windows.Forms.Label
    Private WithEvents _Label_19 As System.Windows.Forms.Label
    Private WithEvents _Line_11 As System.Windows.Forms.Label
    Private WithEvents _Label_23 As System.Windows.Forms.Label
    Private WithEvents _Label_20 As System.Windows.Forms.Label
    Private WithEvents _Label_21 As System.Windows.Forms.Label
    Private WithEvents _Label_22 As System.Windows.Forms.Label
    Private WithEvents _Label_16 As System.Windows.Forms.Label
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Private WithEvents _Label_28 As System.Windows.Forms.Label
    Private WithEvents _Label_43 As System.Windows.Forms.Label
    Private WithEvents _Panel_1 As System.Windows.Forms.Panel
    Private WithEvents _Command1_4 As System.Windows.Forms.Button
    Private WithEvents _Command1_3 As System.Windows.Forms.Button
    Private WithEvents _Command1_2 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Private WithEvents _SSOpt_1 As System.Windows.Forms.RadioButton
    Private WithEvents _SSOpt_0 As System.Windows.Forms.RadioButton
    Public WithEvents txtF As System.Windows.Forms.TextBox
    Public WithEvents CboLoai As ComboBoxEx.ComboBoxExt
    Public WithEvents LstVt As System.Windows.Forms.ListBox
    Private WithEvents _Command_5 As System.Windows.Forms.Button
    Private WithEvents _Command_6 As System.Windows.Forms.Button
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Public CboThang1(1) As ComboBoxEx.ComboBoxExt
    Public CmdChitiet(2) As System.Windows.Forms.Button
    Public Command(6) As System.Windows.Forms.Button
    Public Command1(4) As System.Windows.Forms.Button
    Public Frame(4) As System.Windows.Forms.Panel
    Public GrdNT(3) As ListViewEx.ListviewExt
    Public Label(46) As System.Windows.Forms.Label
    Public Line(14) As System.Windows.Forms.Label
    Public Panel(1) As System.Windows.Forms.Panel
    Public SSOpt(1) As System.Windows.Forms.RadioButton
    Public TxtVT(13) As System.Windows.Forms.TextBox
    Public txtNhap(10) As System.Windows.Forms.TextBox
    Public txtTon(2) As System.Windows.Forms.TextBox

    Private WithEvents _GrdNT_1 As ListViewEx.ListviewExt
    Private WithEvents _GrdNT_0 As ListViewEx.ListviewExt
    'Private listBoxHelper1 As Artinsoft.VB6.Gui.ListBoxHelper
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVattu))
        Me.SSCmdF = New System.Windows.Forms.Button
        Me._Command_4 = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me.Nhapxuat = New System.Windows.Forms.Panel
        Me.Grd = New ListViewEx.ListviewExt
        Me.Text1 = New System.Windows.Forms.TextBox
        Me._Frame_4 = New System.Windows.Forms.Panel
        Me._CboThang1_1 = New ComboBoxEx.ComboBoxExt
        Me._CboThang1_0 = New ComboBoxEx.ComboBoxExt
        Me._Label_36 = New System.Windows.Forms.Label
        Me._Label_38 = New System.Windows.Forms.Label
        Me.ChkNhap = New System.Windows.Forms.CheckBox
        Me._Label_34 = New System.Windows.Forms.Label
        Me._Label_33 = New System.Windows.Forms.Label
        Me._Label_35 = New System.Windows.Forms.Label
        Me._Label_37 = New System.Windows.Forms.Label
        Me._Panel_1 = New System.Windows.Forms.Panel
        Me._Panel_0 = New System.Windows.Forms.Panel
        Me._GrdNT_3 = New ListViewEx.ListviewExt
        Me._GrdNT_2 = New ListViewEx.ListviewExt
        Me._Label_27 = New System.Windows.Forms.Label
        Me._TxtVT_11 = New System.Windows.Forms.TextBox
        Me.Pic = New System.Windows.Forms.PictureBox
        Me._TxtVT_13 = New System.Windows.Forms.TextBox
        Me._TxtVT_12 = New System.Windows.Forms.TextBox
        Me._CmdChitiet_2 = New System.Windows.Forms.Button
        Me.Chk = New System.Windows.Forms.CheckBox
        Me._TxtVT_4 = New System.Windows.Forms.TextBox
        Me._TxtVT_5 = New System.Windows.Forms.TextBox
        Me._TxtVT_10 = New System.Windows.Forms.TextBox
        Me._TxtVT_9 = New System.Windows.Forms.TextBox
        Me._TxtVT_8 = New System.Windows.Forms.TextBox
        Me._TxtVT_7 = New System.Windows.Forms.TextBox
        Me._TxtVT_6 = New System.Windows.Forms.TextBox
        Me._TxtVT_3 = New System.Windows.Forms.TextBox
        Me._txtTon_1 = New System.Windows.Forms.TextBox
        Me._txtTon_0 = New System.Windows.Forms.TextBox
        Me._TxtVT_2 = New System.Windows.Forms.TextBox
        Me._TxtVT_1 = New System.Windows.Forms.TextBox
        Me._TxtVT_0 = New System.Windows.Forms.TextBox
        Me._Label_32 = New System.Windows.Forms.Label
        Me._Line_7 = New System.Windows.Forms.Label
        Me._Line_4 = New System.Windows.Forms.Label
        Me._Label_31 = New System.Windows.Forms.Label
        Me._Label_26 = New System.Windows.Forms.Label
        Me._Label_11 = New System.Windows.Forms.Label
        Me._Label_30 = New System.Windows.Forms.Label
        Me._Label_29 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Line_13 = New System.Windows.Forms.Label
        Me._Line_12 = New System.Windows.Forms.Label
        Me._Line_10 = New System.Windows.Forms.Label
        Me._Label_25 = New System.Windows.Forms.Label
        Me._Label_24 = New System.Windows.Forms.Label
        Me._Line_9 = New System.Windows.Forms.Label
        Me._Line_8 = New System.Windows.Forms.Label
        Me._Label_13 = New System.Windows.Forms.Label
        Me._Line_3 = New System.Windows.Forms.Label
        Me._Label_10 = New System.Windows.Forms.Label
        Me._Line_6 = New System.Windows.Forms.Label
        Me._Line_5 = New System.Windows.Forms.Label
        Me._Label_12 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Line_2 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Line_1 = New System.Windows.Forms.Label
        Me._Line_0 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._txtNhap_8 = New System.Windows.Forms.TextBox
        Me._GrdNT_0 = New ListViewEx.ListviewExt
        Me._txtNhap_7 = New System.Windows.Forms.TextBox
        Me._CmdChitiet_1 = New System.Windows.Forms.Button
        Me._txtNhap_6 = New System.Windows.Forms.TextBox
        Me._CmdChitiet_0 = New System.Windows.Forms.Button
        Me._txtNhap_3 = New System.Windows.Forms.TextBox
        Me._txtNhap_2 = New System.Windows.Forms.TextBox
        Me._txtNhap_1 = New System.Windows.Forms.TextBox
        Me._txtNhap_0 = New System.Windows.Forms.TextBox
        Me._txtTon_2 = New System.Windows.Forms.TextBox
        Me._txtNhap_4 = New System.Windows.Forms.TextBox
        Me._txtNhap_5 = New System.Windows.Forms.TextBox
        Me._txtNhap_10 = New System.Windows.Forms.TextBox
        Me._Label_39 = New System.Windows.Forms.Label
        Me._Line_14 = New System.Windows.Forms.Label
        Me._Label_45 = New System.Windows.Forms.Label
        Me._Label_14 = New System.Windows.Forms.Label
        Me._Label_15 = New System.Windows.Forms.Label
        Me._Label_19 = New System.Windows.Forms.Label
        Me._Line_11 = New System.Windows.Forms.Label
        Me._Label_23 = New System.Windows.Forms.Label
        Me._Label_20 = New System.Windows.Forms.Label
        Me._Label_21 = New System.Windows.Forms.Label
        Me._Label_22 = New System.Windows.Forms.Label
        Me._Label_16 = New System.Windows.Forms.Label
        Me._Label_17 = New System.Windows.Forms.Label
        Me._Label_43 = New System.Windows.Forms.Label
        Me._GrdNT_1 = New ListViewEx.ListviewExt
        Me._Label_28 = New System.Windows.Forms.Label
        Me.CboThang = New ComboBoxEx.ComboBoxExt
        Me.txtTyle = New System.Windows.Forms.TextBox
        Me._Label_46 = New System.Windows.Forms.Label
        Me._Label_18 = New System.Windows.Forms.Label
        Me._Command1_4 = New System.Windows.Forms.Button
        Me._Command1_3 = New System.Windows.Forms.Button
        Me._Command1_2 = New System.Windows.Forms.Button
        Me._Command1_1 = New System.Windows.Forms.Button
        Me._Command1_0 = New System.Windows.Forms.Button
        Me._SSOpt_1 = New System.Windows.Forms.RadioButton
        Me._SSOpt_0 = New System.Windows.Forms.RadioButton
        Me.txtF = New System.Windows.Forms.TextBox
        Me.CboLoai = New ComboBoxEx.ComboBoxExt
        Me.LstVt = New System.Windows.Forms.ListBox
        Me._Command_5 = New System.Windows.Forms.Button
        Me._Command_6 = New System.Windows.Forms.Button
        Me._Label_4 = New System.Windows.Forms.Label
        Me.Nhapxuat.SuspendLayout()
        Me._Frame_4.SuspendLayout()
        Me._Panel_1.SuspendLayout()
        Me._Panel_0.SuspendLayout()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SSCmdF
        '
        Me.SSCmdF.Image = Global.UNET.My.Resources.Resources.search3_16
        Me.SSCmdF.Location = New System.Drawing.Point(310, 442)
        Me.SSCmdF.Name = "SSCmdF"
        Me.SSCmdF.Size = New System.Drawing.Size(21, 20)
        Me.SSCmdF.TabIndex = 5
        '
        '_Command_4
        '
        Me._Command_4.Image = Global.UNET.My.Resources.Resources.tool16
        Me._Command_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_4.Location = New System.Drawing.Point(840, 440)
        Me._Command_4.Name = "_Command_4"
        Me._Command_4.Size = New System.Drawing.Size(89, 25)
        Me._Command_4.TabIndex = 43
        Me._Command_4.Tag = "Norms"
        Me._Command_4.Text = "Định &mức"
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(936, 440)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 44
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(760, 440)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 42
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(680, 440)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 41
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.add16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(600, 440)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 40
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        '
        'Nhapxuat
        '
        Me.Nhapxuat.BackColor = System.Drawing.SystemColors.Window
        Me.Nhapxuat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Nhapxuat.Controls.Add(Me.Grd)
        Me.Nhapxuat.Controls.Add(Me.Text1)
        Me.Nhapxuat.Controls.Add(Me._Frame_4)
        Me.Nhapxuat.Controls.Add(Me.ChkNhap)
        Me.Nhapxuat.Controls.Add(Me._Label_34)
        Me.Nhapxuat.Controls.Add(Me._Label_33)
        Me.Nhapxuat.Controls.Add(Me._Label_35)
        Me.Nhapxuat.Controls.Add(Me._Label_37)
        Me.Nhapxuat.Cursor = System.Windows.Forms.Cursors.Default
        Me.Nhapxuat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nhapxuat.Location = New System.Drawing.Point(768, 8)
        Me.Nhapxuat.Name = "Nhapxuat"
        Me.Nhapxuat.Size = New System.Drawing.Size(241, 429)
        Me.Nhapxuat.TabIndex = 62
        '
        'Grd
        '
        Me.Grd.AllowColumnResize = True
        Me.Grd.AllowMultiselect = False
        Me.Grd.AlternateBackground = System.Drawing.Color.DarkGreen
        Me.Grd.AlternatingColors = False
        Me.Grd.AutoHeight = True
        Me.Grd.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Grd.BackgroundStretchToFit = True
        Me.Grd.Col = 0
        Me.Grd.Cols = 0
        Me.Grd.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me.Grd.FullRowSelect = True
        Me.Grd.GridColor = System.Drawing.Color.LightGray
        Me.Grd.GridLines = ListViewEx.GLGridLines.gridHorizontal
        Me.Grd.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me.Grd.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me.Grd.HeaderHeight = 0
        Me.Grd.HeaderVisible = True
        Me.Grd.HeaderWordWrap = False
        Me.Grd.HotColumnTracking = False
        Me.Grd.HotItemTracking = False
        Me.Grd.HotTrackingColor = System.Drawing.Color.LightGray
        Me.Grd.HoverEvents = False
        Me.Grd.HoverTime = 1
        Me.Grd.ImageList = Nothing
        Me.Grd.ItemHeight = 18
        Me.Grd.ItemWordWrap = False
        Me.Grd.Location = New System.Drawing.Point(8, 96)
        Me.Grd.Name = "Grd"
        Me.Grd.Row = 0
        Me.Grd.Rows = 0
        Me.Grd.Selectable = True
        Me.Grd.SelectedTextColor = System.Drawing.Color.White
        Me.Grd.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.Grd.ShowBorder = True
        Me.Grd.ShowFocusRect = False
        Me.Grd.Size = New System.Drawing.Size(225, 325)
        Me.Grd.SortType = ListViewEx.SortTypes.InsertionSort
        Me.Grd.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.Grd.TabIndex = 75
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Text1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.ForeColor = System.Drawing.Color.Black
        Me.Text1.Location = New System.Drawing.Point(16, 65)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(57, 13)
        Me.Text1.TabIndex = 63
        '
        '_Frame_4
        '
        Me._Frame_4.BackColor = System.Drawing.Color.White
        Me._Frame_4.Controls.Add(Me._CboThang1_1)
        Me._Frame_4.Controls.Add(Me._CboThang1_0)
        Me._Frame_4.Controls.Add(Me._Label_36)
        Me._Frame_4.Controls.Add(Me._Label_38)
        Me._Frame_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Frame_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_4.Location = New System.Drawing.Point(87, 8)
        Me._Frame_4.Name = "_Frame_4"
        Me._Frame_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame_4.Size = New System.Drawing.Size(146, 49)
        Me._Frame_4.TabIndex = 66
        '
        '_CboThang1_1
        '
        Me._CboThang1_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang1_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang1_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang1_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._CboThang1_1.Location = New System.Drawing.Point(64, 24)
        Me._CboThang1_1.Name = "_CboThang1_1"
        Me._CboThang1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._CboThang1_1.Size = New System.Drawing.Size(73, 21)
        Me._CboThang1_1.TabIndex = 68
        '
        '_CboThang1_0
        '
        Me._CboThang1_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang1_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang1_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang1_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._CboThang1_0.Location = New System.Drawing.Point(64, 0)
        Me._CboThang1_0.Name = "_CboThang1_0"
        Me._CboThang1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._CboThang1_0.Size = New System.Drawing.Size(73, 21)
        Me._CboThang1_0.TabIndex = 67
        '
        '_Label_36
        '
        Me._Label_36.BackColor = System.Drawing.Color.White
        Me._Label_36.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_36.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_36.Location = New System.Drawing.Point(0, 0)
        Me._Label_36.Name = "_Label_36"
        Me._Label_36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_36.Size = New System.Drawing.Size(59, 17)
        Me._Label_36.TabIndex = 70
        Me._Label_36.Tag = "to"
        Me._Label_36.Text = "Từ tháng"
        Me._Label_36.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_38
        '
        Me._Label_38.BackColor = System.Drawing.Color.White
        Me._Label_38.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_38.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_38.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_38.Location = New System.Drawing.Point(0, 24)
        Me._Label_38.Name = "_Label_38"
        Me._Label_38.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_38.Size = New System.Drawing.Size(59, 17)
        Me._Label_38.TabIndex = 69
        Me._Label_38.Tag = "to"
        Me._Label_38.Text = "Đến tháng"
        Me._Label_38.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ChkNhap
        '
        Me.ChkNhap.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNhap.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkNhap.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNhap.ForeColor = System.Drawing.Color.Black
        Me.ChkNhap.Location = New System.Drawing.Point(56, 64)
        Me.ChkNhap.Name = "ChkNhap"
        Me.ChkNhap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkNhap.Size = New System.Drawing.Size(177, 16)
        Me.ChkNhap.TabIndex = 65
        Me.ChkNhap.Tag = "Imports Vouchers"
        Me.ChkNhap.Text = "Chứng từ Nhập"
        Me.ChkNhap.UseVisualStyleBackColor = False
        '
        '_Label_34
        '
        Me._Label_34.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_34.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_34.ForeColor = System.Drawing.Color.Black
        Me._Label_34.Location = New System.Drawing.Point(87, 80)
        Me._Label_34.Name = "_Label_34"
        Me._Label_34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_34.Size = New System.Drawing.Size(55, 17)
        Me._Label_34.TabIndex = 74
        Me._Label_34.Tag = "V. Date"
        Me._Label_34.Text = "Ngày"
        Me._Label_34.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_33
        '
        Me._Label_33.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_33.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_33.ForeColor = System.Drawing.Color.Black
        Me._Label_33.Location = New System.Drawing.Point(8, 80)
        Me._Label_33.Name = "_Label_33"
        Me._Label_33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_33.Size = New System.Drawing.Size(81, 17)
        Me._Label_33.TabIndex = 73
        Me._Label_33.Tag = "V. Code"
        Me._Label_33.Text = "Số chứng từ"
        Me._Label_33.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_35
        '
        Me._Label_35.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_35.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_35.ForeColor = System.Drawing.Color.Black
        Me._Label_35.Location = New System.Drawing.Point(140, 80)
        Me._Label_35.Name = "_Label_35"
        Me._Label_35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_35.Size = New System.Drawing.Size(93, 17)
        Me._Label_35.TabIndex = 72
        Me._Label_35.Tag = "Unit"
        Me._Label_35.Text = "Đơn giá"
        Me._Label_35.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_37
        '
        Me._Label_37.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_37.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_37.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_37.ForeColor = System.Drawing.Color.Black
        Me._Label_37.Location = New System.Drawing.Point(8, 64)
        Me._Label_37.Name = "_Label_37"
        Me._Label_37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_37.Size = New System.Drawing.Size(225, 17)
        Me._Label_37.TabIndex = 71
        Me._Label_37.Tag = "User Name"
        Me._Label_37.Text = "Chứng từ nhập"
        Me._Label_37.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Panel_1
        '
        Me._Panel_1.BackColor = System.Drawing.SystemColors.Window
        Me._Panel_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Panel_1.Controls.Add(Me._Panel_0)
        Me._Panel_1.Controls.Add(Me._txtNhap_8)
        Me._Panel_1.Controls.Add(Me._GrdNT_0)
        Me._Panel_1.Controls.Add(Me._txtNhap_7)
        Me._Panel_1.Controls.Add(Me._CmdChitiet_1)
        Me._Panel_1.Controls.Add(Me._txtNhap_6)
        Me._Panel_1.Controls.Add(Me._CmdChitiet_0)
        Me._Panel_1.Controls.Add(Me._txtNhap_3)
        Me._Panel_1.Controls.Add(Me._txtNhap_2)
        Me._Panel_1.Controls.Add(Me._txtNhap_1)
        Me._Panel_1.Controls.Add(Me._txtNhap_0)
        Me._Panel_1.Controls.Add(Me._txtTon_2)
        Me._Panel_1.Controls.Add(Me._txtNhap_4)
        Me._Panel_1.Controls.Add(Me._txtNhap_5)
        Me._Panel_1.Controls.Add(Me._txtNhap_10)
        Me._Panel_1.Controls.Add(Me._Label_39)
        Me._Panel_1.Controls.Add(Me._Line_14)
        Me._Panel_1.Controls.Add(Me._Label_45)
        Me._Panel_1.Controls.Add(Me._Label_14)
        Me._Panel_1.Controls.Add(Me._Label_15)
        Me._Panel_1.Controls.Add(Me._Label_19)
        Me._Panel_1.Controls.Add(Me._Line_11)
        Me._Panel_1.Controls.Add(Me._Label_23)
        Me._Panel_1.Controls.Add(Me._Label_20)
        Me._Panel_1.Controls.Add(Me._Label_21)
        Me._Panel_1.Controls.Add(Me._Label_22)
        Me._Panel_1.Controls.Add(Me._Label_16)
        Me._Panel_1.Controls.Add(Me._Label_17)
        Me._Panel_1.Controls.Add(Me._Label_43)
        Me._Panel_1.Controls.Add(Me._GrdNT_1)
        Me._Panel_1.Controls.Add(Me._Label_28)
        Me._Panel_1.Controls.Add(Me.CboThang)
        Me._Panel_1.Controls.Add(Me.txtTyle)
        Me._Panel_1.Controls.Add(Me._Label_46)
        Me._Panel_1.Location = New System.Drawing.Point(345, 8)
        Me._Panel_1.Name = "_Panel_1"
        Me._Panel_1.Size = New System.Drawing.Size(417, 429)
        Me._Panel_1.TabIndex = 75
        Me._Panel_1.Tag = "0"
        '
        '_Panel_0
        '
        Me._Panel_0.BackColor = System.Drawing.SystemColors.Window
        Me._Panel_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Panel_0.Controls.Add(Me._GrdNT_3)
        Me._Panel_0.Controls.Add(Me._GrdNT_2)
        Me._Panel_0.Controls.Add(Me._Label_27)
        Me._Panel_0.Controls.Add(Me._TxtVT_11)
        Me._Panel_0.Controls.Add(Me.Pic)
        Me._Panel_0.Controls.Add(Me._TxtVT_13)
        Me._Panel_0.Controls.Add(Me._TxtVT_12)
        Me._Panel_0.Controls.Add(Me._CmdChitiet_2)
        Me._Panel_0.Controls.Add(Me.Chk)
        Me._Panel_0.Controls.Add(Me._TxtVT_4)
        Me._Panel_0.Controls.Add(Me._TxtVT_5)
        Me._Panel_0.Controls.Add(Me._TxtVT_10)
        Me._Panel_0.Controls.Add(Me._TxtVT_9)
        Me._Panel_0.Controls.Add(Me._TxtVT_8)
        Me._Panel_0.Controls.Add(Me._TxtVT_7)
        Me._Panel_0.Controls.Add(Me._TxtVT_6)
        Me._Panel_0.Controls.Add(Me._TxtVT_3)
        Me._Panel_0.Controls.Add(Me._txtTon_1)
        Me._Panel_0.Controls.Add(Me._txtTon_0)
        Me._Panel_0.Controls.Add(Me._TxtVT_2)
        Me._Panel_0.Controls.Add(Me._TxtVT_1)
        Me._Panel_0.Controls.Add(Me._TxtVT_0)
        Me._Panel_0.Controls.Add(Me._Label_32)
        Me._Panel_0.Controls.Add(Me._Line_7)
        Me._Panel_0.Controls.Add(Me._Line_4)
        Me._Panel_0.Controls.Add(Me._Label_31)
        Me._Panel_0.Controls.Add(Me._Label_26)
        Me._Panel_0.Controls.Add(Me._Label_11)
        Me._Panel_0.Controls.Add(Me._Label_30)
        Me._Panel_0.Controls.Add(Me._Label_29)
        Me._Panel_0.Controls.Add(Me._Label_7)
        Me._Panel_0.Controls.Add(Me._Label_6)
        Me._Panel_0.Controls.Add(Me._Line_13)
        Me._Panel_0.Controls.Add(Me._Line_12)
        Me._Panel_0.Controls.Add(Me._Line_10)
        Me._Panel_0.Controls.Add(Me._Label_25)
        Me._Panel_0.Controls.Add(Me._Label_24)
        Me._Panel_0.Controls.Add(Me._Line_9)
        Me._Panel_0.Controls.Add(Me._Line_8)
        Me._Panel_0.Controls.Add(Me._Label_13)
        Me._Panel_0.Controls.Add(Me._Line_3)
        Me._Panel_0.Controls.Add(Me._Label_10)
        Me._Panel_0.Controls.Add(Me._Line_6)
        Me._Panel_0.Controls.Add(Me._Line_5)
        Me._Panel_0.Controls.Add(Me._Label_12)
        Me._Panel_0.Controls.Add(Me._Label_0)
        Me._Panel_0.Controls.Add(Me._Line_2)
        Me._Panel_0.Controls.Add(Me._Label_8)
        Me._Panel_0.Controls.Add(Me._Label_3)
        Me._Panel_0.Controls.Add(Me._Line_1)
        Me._Panel_0.Controls.Add(Me._Line_0)
        Me._Panel_0.Controls.Add(Me._Label_2)
        Me._Panel_0.Controls.Add(Me._Label_1)
        Me._Panel_0.Location = New System.Drawing.Point(-2, -2)
        Me._Panel_0.Name = "_Panel_0"
        Me._Panel_0.Size = New System.Drawing.Size(417, 429)
        Me._Panel_0.TabIndex = 76
        Me._Panel_0.Tag = "0"
        '
        '_GrdNT_3
        '
        Me._GrdNT_3.AllowColumnResize = True
        Me._GrdNT_3.AllowMultiselect = False
        Me._GrdNT_3.AlternateBackground = System.Drawing.Color.DarkGreen
        Me._GrdNT_3.AlternatingColors = False
        Me._GrdNT_3.AutoHeight = True
        Me._GrdNT_3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me._GrdNT_3.BackgroundStretchToFit = True
        Me._GrdNT_3.Col = 0
        Me._GrdNT_3.Cols = 0
        Me._GrdNT_3.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me._GrdNT_3.FullRowSelect = True
        Me._GrdNT_3.GridColor = System.Drawing.Color.LightGray
        Me._GrdNT_3.GridLines = ListViewEx.GLGridLines.gridHorizontal
        Me._GrdNT_3.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me._GrdNT_3.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me._GrdNT_3.HeaderHeight = 0
        Me._GrdNT_3.HeaderVisible = False
        Me._GrdNT_3.HeaderWordWrap = False
        Me._GrdNT_3.HotColumnTracking = False
        Me._GrdNT_3.HotItemTracking = False
        Me._GrdNT_3.HotTrackingColor = System.Drawing.Color.LightGray
        Me._GrdNT_3.HoverEvents = False
        Me._GrdNT_3.HoverTime = 1
        Me._GrdNT_3.ImageList = Nothing
        Me._GrdNT_3.ItemHeight = 18
        Me._GrdNT_3.ItemWordWrap = False
        Me._GrdNT_3.Location = New System.Drawing.Point(8, 184)
        Me._GrdNT_3.Name = "_GrdNT_3"
        Me._GrdNT_3.Row = 0
        Me._GrdNT_3.Rows = 0
        Me._GrdNT_3.Selectable = True
        Me._GrdNT_3.SelectedTextColor = System.Drawing.Color.White
        Me._GrdNT_3.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me._GrdNT_3.ShowBorder = True
        Me._GrdNT_3.ShowFocusRect = False
        Me._GrdNT_3.Size = New System.Drawing.Size(393, 60)
        Me._GrdNT_3.SortType = ListViewEx.SortTypes.InsertionSort
        Me._GrdNT_3.SuperFlatHeaderColor = System.Drawing.Color.White
        Me._GrdNT_3.TabIndex = 76
        '
        '_GrdNT_2
        '
        Me._GrdNT_2.AllowColumnResize = True
        Me._GrdNT_2.AllowMultiselect = False
        Me._GrdNT_2.AlternateBackground = System.Drawing.Color.DarkGreen
        Me._GrdNT_2.AlternatingColors = False
        Me._GrdNT_2.AutoHeight = True
        Me._GrdNT_2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me._GrdNT_2.BackgroundStretchToFit = True
        Me._GrdNT_2.Col = 0
        Me._GrdNT_2.Cols = 0
        Me._GrdNT_2.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me._GrdNT_2.FullRowSelect = True
        Me._GrdNT_2.GridColor = System.Drawing.Color.LightGray
        Me._GrdNT_2.GridLines = ListViewEx.GLGridLines.gridHorizontal
        Me._GrdNT_2.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me._GrdNT_2.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me._GrdNT_2.HeaderHeight = 0
        Me._GrdNT_2.HeaderVisible = False
        Me._GrdNT_2.HeaderWordWrap = False
        Me._GrdNT_2.HotColumnTracking = False
        Me._GrdNT_2.HotItemTracking = False
        Me._GrdNT_2.HotTrackingColor = System.Drawing.Color.LightGray
        Me._GrdNT_2.HoverEvents = False
        Me._GrdNT_2.HoverTime = 1
        Me._GrdNT_2.ImageList = Nothing
        Me._GrdNT_2.ItemHeight = 18
        Me._GrdNT_2.ItemWordWrap = False
        Me._GrdNT_2.Location = New System.Drawing.Point(8, 360)
        Me._GrdNT_2.Name = "_GrdNT_2"
        Me._GrdNT_2.Row = 0
        Me._GrdNT_2.Rows = 0
        Me._GrdNT_2.Selectable = True
        Me._GrdNT_2.SelectedTextColor = System.Drawing.Color.White
        Me._GrdNT_2.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me._GrdNT_2.ShowBorder = True
        Me._GrdNT_2.ShowFocusRect = False
        Me._GrdNT_2.Size = New System.Drawing.Size(397, 55)
        Me._GrdNT_2.SortType = ListViewEx.SortTypes.InsertionSort
        Me._GrdNT_2.SuperFlatHeaderColor = System.Drawing.Color.White
        Me._GrdNT_2.TabIndex = 78
        Me._GrdNT_2.Text = "-"
        '
        '_Label_27
        '
        Me._Label_27.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_27.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_27.ForeColor = System.Drawing.Color.Black
        Me._Label_27.Location = New System.Drawing.Point(240, 168)
        Me._Label_27.Name = "_Label_27"
        Me._Label_27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_27.Size = New System.Drawing.Size(161, 17)
        Me._Label_27.TabIndex = 56
        Me._Label_27.Tag = "U. Price"
        Me._Label_27.Text = "Đơn giá"
        Me._Label_27.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_TxtVT_11
        '
        Me._TxtVT_11.AcceptsReturn = True
        Me._TxtVT_11.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_11.Enabled = False
        Me._TxtVT_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_11.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TxtVT_11.Location = New System.Drawing.Point(240, 243)
        Me._TxtVT_11.MaxLength = 12
        Me._TxtVT_11.Multiline = True
        Me._TxtVT_11.Name = "_TxtVT_11"
        Me._TxtVT_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TxtVT_11.Size = New System.Drawing.Size(144, 19)
        Me._TxtVT_11.TabIndex = 19
        Me._TxtVT_11.Text = "0"
        Me._TxtVT_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Pic
        '
        Me.Pic.BackColor = System.Drawing.SystemColors.Window
        Me.Pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic.Cursor = System.Windows.Forms.Cursors.Default
        Me.Pic.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pic.Location = New System.Drawing.Point(347, 7)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(55, 27)
        Me.Pic.TabIndex = 59
        Me.Pic.TabStop = False
        Me.Pic.Visible = False
        '
        '_TxtVT_13
        '
        Me._TxtVT_13.AcceptsReturn = True
        Me._TxtVT_13.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_13.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_13.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TxtVT_13.Location = New System.Drawing.Point(344, 128)
        Me._TxtVT_13.MaxLength = 2
        Me._TxtVT_13.Name = "_TxtVT_13"
        Me._TxtVT_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TxtVT_13.Size = New System.Drawing.Size(57, 13)
        Me._TxtVT_13.TabIndex = 15
        Me._TxtVT_13.Text = "0"
        Me._TxtVT_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._TxtVT_13.Visible = False
        '
        '_TxtVT_12
        '
        Me._TxtVT_12.AcceptsReturn = True
        Me._TxtVT_12.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_12.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TxtVT_12.Location = New System.Drawing.Point(376, 104)
        Me._TxtVT_12.MaxLength = 2
        Me._TxtVT_12.Name = "_TxtVT_12"
        Me._TxtVT_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TxtVT_12.Size = New System.Drawing.Size(25, 13)
        Me._TxtVT_12.TabIndex = 14
        Me._TxtVT_12.Text = "0"
        Me._TxtVT_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_CmdChitiet_2
        '
        Me._CmdChitiet_2.BackColor = System.Drawing.SystemColors.Control
        Me._CmdChitiet_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._CmdChitiet_2.Enabled = False
        Me._CmdChitiet_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CmdChitiet_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CmdChitiet_2.Image = Global.UNET.My.Resources.Resources.up16
        Me._CmdChitiet_2.Location = New System.Drawing.Point(383, 243)
        Me._CmdChitiet_2.Name = "_CmdChitiet_2"
        Me._CmdChitiet_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._CmdChitiet_2.Size = New System.Drawing.Size(18, 18)
        Me._CmdChitiet_2.TabIndex = 20
        Me._CmdChitiet_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._CmdChitiet_2.UseVisualStyleBackColor = False
        '
        'Chk
        '
        Me.Chk.BackColor = System.Drawing.SystemColors.Window
        Me.Chk.Cursor = System.Windows.Forms.Cursors.Default
        Me.Chk.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Chk.Location = New System.Drawing.Point(8, 150)
        Me.Chk.Name = "Chk"
        Me.Chk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Chk.Size = New System.Drawing.Size(327, 17)
        Me.Chk.TabIndex = 16
        Me.Chk.Tag = "Conversion Units"
        Me.Chk.Text = "Các đơn vị tính chuyển đổi và tỷ lệ quy đổi so với đ.v.t cơ bản"
        Me.Chk.UseVisualStyleBackColor = False
        '
        '_TxtVT_4
        '
        Me._TxtVT_4.AcceptsReturn = True
        Me._TxtVT_4.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_4.Enabled = False
        Me._TxtVT_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TxtVT_4.Location = New System.Drawing.Point(8, 242)
        Me._TxtVT_4.MaxLength = 20
        Me._TxtVT_4.Name = "_TxtVT_4"
        Me._TxtVT_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TxtVT_4.Size = New System.Drawing.Size(113, 20)
        Me._TxtVT_4.TabIndex = 17
        '
        '_TxtVT_5
        '
        Me._TxtVT_5.AcceptsReturn = True
        Me._TxtVT_5.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_5.Enabled = False
        Me._TxtVT_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TxtVT_5.Location = New System.Drawing.Point(120, 243)
        Me._TxtVT_5.MaxLength = 12
        Me._TxtVT_5.Multiline = True
        Me._TxtVT_5.Name = "_TxtVT_5"
        Me._TxtVT_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TxtVT_5.Size = New System.Drawing.Size(121, 19)
        Me._TxtVT_5.TabIndex = 18
        Me._TxtVT_5.Text = "0"
        Me._TxtVT_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_TxtVT_10
        '
        Me._TxtVT_10.AcceptsReturn = True
        Me._TxtVT_10.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_10.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TxtVT_10.Location = New System.Drawing.Point(176, 104)
        Me._TxtVT_10.MaxLength = 20
        Me._TxtVT_10.Name = "_TxtVT_10"
        Me._TxtVT_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TxtVT_10.Size = New System.Drawing.Size(73, 13)
        Me._TxtVT_10.TabIndex = 12
        Me._TxtVT_10.Text = "0"
        Me._TxtVT_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_TxtVT_9
        '
        Me._TxtVT_9.AcceptsReturn = True
        Me._TxtVT_9.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TxtVT_9.Location = New System.Drawing.Point(96, 104)
        Me._TxtVT_9.MaxLength = 20
        Me._TxtVT_9.Name = "_TxtVT_9"
        Me._TxtVT_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TxtVT_9.Size = New System.Drawing.Size(73, 13)
        Me._TxtVT_9.TabIndex = 11
        Me._TxtVT_9.Text = "0"
        Me._TxtVT_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_TxtVT_8
        '
        Me._TxtVT_8.AcceptsReturn = True
        Me._TxtVT_8.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TxtVT_8.Location = New System.Drawing.Point(16, 104)
        Me._TxtVT_8.MaxLength = 20
        Me._TxtVT_8.Name = "_TxtVT_8"
        Me._TxtVT_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TxtVT_8.Size = New System.Drawing.Size(73, 13)
        Me._TxtVT_8.TabIndex = 10
        Me._TxtVT_8.Text = "0"
        Me._TxtVT_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_TxtVT_7
        '
        Me._TxtVT_7.AcceptsReturn = True
        Me._TxtVT_7.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TxtVT_7.Location = New System.Drawing.Point(344, 104)
        Me._TxtVT_7.MaxLength = 2
        Me._TxtVT_7.Name = "_TxtVT_7"
        Me._TxtVT_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TxtVT_7.Size = New System.Drawing.Size(17, 13)
        Me._TxtVT_7.TabIndex = 13
        Me._TxtVT_7.Text = "0"
        Me._TxtVT_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_TxtVT_6
        '
        Me._TxtVT_6.AcceptsReturn = True
        Me._TxtVT_6.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TxtVT_6.Location = New System.Drawing.Point(72, 304)
        Me._TxtVT_6.MaxLength = 50
        Me._TxtVT_6.Name = "_TxtVT_6"
        Me._TxtVT_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TxtVT_6.Size = New System.Drawing.Size(249, 13)
        Me._TxtVT_6.TabIndex = 23
        '
        '_TxtVT_3
        '
        Me._TxtVT_3.AcceptsReturn = True
        Me._TxtVT_3.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TxtVT_3.Location = New System.Drawing.Point(296, 64)
        Me._TxtVT_3.MaxLength = 20
        Me._TxtVT_3.Multiline = True
        Me._TxtVT_3.Name = "_TxtVT_3"
        Me._TxtVT_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TxtVT_3.Size = New System.Drawing.Size(105, 19)
        Me._TxtVT_3.TabIndex = 9
        Me._TxtVT_3.Text = "0"
        Me._TxtVT_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtTon_1
        '
        Me._txtTon_1.AcceptsReturn = True
        Me._txtTon_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtTon_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtTon_1.Location = New System.Drawing.Point(240, 280)
        Me._txtTon_1.MaxLength = 12
        Me._txtTon_1.Multiline = True
        Me._txtTon_1.Name = "_txtTon_1"
        Me._txtTon_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtTon_1.Size = New System.Drawing.Size(81, 19)
        Me._txtTon_1.TabIndex = 22
        Me._txtTon_1.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._txtTon_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtTon_0
        '
        Me._txtTon_0.AcceptsReturn = True
        Me._txtTon_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtTon_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtTon_0.Location = New System.Drawing.Point(120, 280)
        Me._txtTon_0.MaxLength = 12
        Me._txtTon_0.Multiline = True
        Me._txtTon_0.Name = "_txtTon_0"
        Me._txtTon_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtTon_0.Size = New System.Drawing.Size(73, 19)
        Me._txtTon_0.TabIndex = 21
        Me._txtTon_0.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._txtTon_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_TxtVT_2
        '
        Me._TxtVT_2.AcceptsReturn = True
        Me._TxtVT_2.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TxtVT_2.Location = New System.Drawing.Point(72, 64)
        Me._TxtVT_2.MaxLength = 12
        Me._TxtVT_2.Name = "_TxtVT_2"
        Me._TxtVT_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TxtVT_2.Size = New System.Drawing.Size(97, 13)
        Me._TxtVT_2.TabIndex = 8
        '
        '_TxtVT_1
        '
        Me._TxtVT_1.AcceptsReturn = True
        Me._TxtVT_1.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TxtVT_1.Location = New System.Drawing.Point(72, 40)
        Me._TxtVT_1.MaxLength = 250
        Me._TxtVT_1.Name = "_TxtVT_1"
        Me._TxtVT_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TxtVT_1.Size = New System.Drawing.Size(329, 13)
        Me._TxtVT_1.TabIndex = 7
        '
        '_TxtVT_0
        '
        Me._TxtVT_0.AcceptsReturn = True
        Me._TxtVT_0.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TxtVT_0.Location = New System.Drawing.Point(72, 16)
        Me._TxtVT_0.MaxLength = 20
        Me._TxtVT_0.Name = "_TxtVT_0"
        Me._TxtVT_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TxtVT_0.Size = New System.Drawing.Size(136, 13)
        Me._TxtVT_0.TabIndex = 6
        '
        '_Label_32
        '
        Me._Label_32.BackColor = System.Drawing.Color.White
        Me._Label_32.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_32.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_32.Location = New System.Drawing.Point(243, 128)
        Me._Label_32.Name = "_Label_32"
        Me._Label_32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_32.Size = New System.Drawing.Size(95, 17)
        Me._Label_32.TabIndex = 58
        Me._Label_32.Tag = "VAT Rate (%)"
        Me._Label_32.Text = "Tỷ lệ thuế NK (%)"
        Me._Label_32.Visible = False
        '
        '_Line_7
        '
        Me._Line_7.BackColor = System.Drawing.SystemColors.WindowText
        Me._Line_7.Enabled = False
        Me._Line_7.Location = New System.Drawing.Point(344, 147)
        Me._Line_7.Name = "_Line_7"
        Me._Line_7.Size = New System.Drawing.Size(56, 1)
        Me._Line_7.TabIndex = 60
        Me._Line_7.Visible = False
        '
        '_Line_4
        '
        Me._Line_4.BackColor = System.Drawing.SystemColors.WindowText
        Me._Line_4.Enabled = False
        Me._Line_4.Location = New System.Drawing.Point(376, 123)
        Me._Line_4.Name = "_Line_4"
        Me._Line_4.Size = New System.Drawing.Size(24, 1)
        Me._Line_4.TabIndex = 61
        '
        '_Label_31
        '
        Me._Label_31.BackColor = System.Drawing.Color.White
        Me._Label_31.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_31.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_31.Location = New System.Drawing.Point(351, 88)
        Me._Label_31.Name = "_Label_31"
        Me._Label_31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_31.Size = New System.Drawing.Size(50, 17)
        Me._Label_31.TabIndex = 57
        Me._Label_31.Tag = "VAT Rate (%)"
        Me._Label_31.Text = "CK (%)"
        Me._Label_31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_26
        '
        Me._Label_26.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_26.ForeColor = System.Drawing.Color.Black
        Me._Label_26.Location = New System.Drawing.Point(8, 168)
        Me._Label_26.Name = "_Label_26"
        Me._Label_26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_26.Size = New System.Drawing.Size(113, 17)
        Me._Label_26.TabIndex = 55
        Me._Label_26.Tag = "Unit"
        Me._Label_26.Text = "Đơn vị tính"
        Me._Label_26.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.Color.Black
        Me._Label_11.Location = New System.Drawing.Point(120, 168)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_11.Size = New System.Drawing.Size(121, 17)
        Me._Label_11.TabIndex = 54
        Me._Label_11.Tag = "Rate"
        Me._Label_11.Text = "Tỷ lệ QD"
        Me._Label_11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_30
        '
        Me._Label_30.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_30.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_30.ForeColor = System.Drawing.Color.Black
        Me._Label_30.Location = New System.Drawing.Point(288, 344)
        Me._Label_30.Name = "_Label_30"
        Me._Label_30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_30.Size = New System.Drawing.Size(117, 17)
        Me._Label_30.TabIndex = 53
        Me._Label_30.Tag = "Amount"
        Me._Label_30.Text = "Thành tiền"
        Me._Label_30.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_29
        '
        Me._Label_29.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_29.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_29.ForeColor = System.Drawing.Color.Black
        Me._Label_29.Location = New System.Drawing.Point(207, 344)
        Me._Label_29.Name = "_Label_29"
        Me._Label_29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_29.Size = New System.Drawing.Size(82, 17)
        Me._Label_29.TabIndex = 52
        Me._Label_29.Tag = "Unit Price"
        Me._Label_29.Text = "Đơn giá"
        Me._Label_29.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(112, 344)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_7.Size = New System.Drawing.Size(96, 17)
        Me._Label_7.TabIndex = 51
        Me._Label_7.Tag = "Quantity"
        Me._Label_7.Text = "Số lượng"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.Color.Black
        Me._Label_6.Location = New System.Drawing.Point(8, 344)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_6.Size = New System.Drawing.Size(105, 17)
        Me._Label_6.TabIndex = 50
        Me._Label_6.Tag = "Store"
        Me._Label_6.Text = "Kho"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Line_13
        '
        Me._Line_13.BackColor = System.Drawing.SystemColors.WindowText
        Me._Line_13.Enabled = False
        Me._Line_13.Location = New System.Drawing.Point(176, 128)
        Me._Line_13.Name = "_Line_13"
        Me._Line_13.Size = New System.Drawing.Size(72, 1)
        Me._Line_13.TabIndex = 62
        '
        '_Line_12
        '
        Me._Line_12.BackColor = System.Drawing.SystemColors.WindowText
        Me._Line_12.Enabled = False
        Me._Line_12.Location = New System.Drawing.Point(96, 128)
        Me._Line_12.Name = "_Line_12"
        Me._Line_12.Size = New System.Drawing.Size(72, 1)
        Me._Line_12.TabIndex = 63
        '
        '_Line_10
        '
        Me._Line_10.BackColor = System.Drawing.SystemColors.WindowText
        Me._Line_10.Enabled = False
        Me._Line_10.Location = New System.Drawing.Point(16, 128)
        Me._Line_10.Name = "_Line_10"
        Me._Line_10.Size = New System.Drawing.Size(72, 1)
        Me._Line_10.TabIndex = 64
        '
        '_Label_25
        '
        Me._Label_25.BackColor = System.Drawing.Color.White
        Me._Label_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_25.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_25.Location = New System.Drawing.Point(16, 88)
        Me._Label_25.Name = "_Label_25"
        Me._Label_25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_25.Size = New System.Drawing.Size(97, 17)
        Me._Label_25.TabIndex = 49
        Me._Label_25.Tag = "Sale Price"
        Me._Label_25.Text = "Các đơn giá bán"
        '
        '_Label_24
        '
        Me._Label_24.BackColor = System.Drawing.Color.White
        Me._Label_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_24.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_24.Location = New System.Drawing.Point(243, 88)
        Me._Label_24.Name = "_Label_24"
        Me._Label_24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_24.Size = New System.Drawing.Size(106, 17)
        Me._Label_24.TabIndex = 48
        Me._Label_24.Tag = "VAT Rate (%)"
        Me._Label_24.Text = "Tỷ lệ thuế VAT (%)"
        Me._Label_24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_Line_9
        '
        Me._Line_9.BackColor = System.Drawing.SystemColors.WindowText
        Me._Line_9.Enabled = False
        Me._Line_9.Location = New System.Drawing.Point(344, 123)
        Me._Line_9.Name = "_Line_9"
        Me._Line_9.Size = New System.Drawing.Size(16, 1)
        Me._Line_9.TabIndex = 65
        '
        '_Line_8
        '
        Me._Line_8.BackColor = System.Drawing.SystemColors.WindowText
        Me._Line_8.Enabled = False
        Me._Line_8.Location = New System.Drawing.Point(72, 323)
        Me._Line_8.Name = "_Line_8"
        Me._Line_8.Size = New System.Drawing.Size(248, 1)
        Me._Line_8.TabIndex = 66
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.White
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_13.Location = New System.Drawing.Point(16, 304)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_13.Size = New System.Drawing.Size(46, 17)
        Me._Label_13.TabIndex = 47
        Me._Label_13.Tag = "Notes"
        Me._Label_13.Text = "Ghi chú"
        '
        '_Line_3
        '
        Me._Line_3.BackColor = System.Drawing.SystemColors.WindowText
        Me._Line_3.Enabled = False
        Me._Line_3.Location = New System.Drawing.Point(256, 83)
        Me._Line_3.Name = "_Line_3"
        Me._Line_3.Size = New System.Drawing.Size(144, 1)
        Me._Line_3.TabIndex = 67
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.White
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_10.Location = New System.Drawing.Point(184, 64)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_10.Size = New System.Drawing.Size(65, 17)
        Me._Label_10.TabIndex = 46
        Me._Label_10.Tag = "P. Price"
        Me._Label_10.Text = "Giá HT"
        Me._Label_10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Line_6
        '
        Me._Line_6.BackColor = System.Drawing.SystemColors.WindowText
        Me._Line_6.Enabled = False
        Me._Line_6.Location = New System.Drawing.Point(240, 299)
        Me._Line_6.Name = "_Line_6"
        Me._Line_6.Size = New System.Drawing.Size(80, 1)
        Me._Line_6.TabIndex = 68
        '
        '_Line_5
        '
        Me._Line_5.BackColor = System.Drawing.SystemColors.WindowText
        Me._Line_5.Enabled = False
        Me._Line_5.Location = New System.Drawing.Point(120, 299)
        Me._Line_5.Name = "_Line_5"
        Me._Line_5.Size = New System.Drawing.Size(72, 1)
        Me._Line_5.TabIndex = 69
        '
        '_Label_12
        '
        Me._Label_12.BackColor = System.Drawing.Color.White
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_12.Location = New System.Drawing.Point(200, 280)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_12.Size = New System.Drawing.Size(40, 17)
        Me._Label_12.TabIndex = 35
        Me._Label_12.Tag = "Max"
        Me._Label_12.Text = "Tối đa"
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.White
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(16, 280)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_0.Size = New System.Drawing.Size(97, 17)
        Me._Label_0.TabIndex = 34
        Me._Label_0.Tag = "Minimum Stock"
        Me._Label_0.Text = "Tồn kho tối thiểu"
        '
        '_Line_2
        '
        Me._Line_2.BackColor = System.Drawing.SystemColors.WindowText
        Me._Line_2.Enabled = False
        Me._Line_2.Location = New System.Drawing.Point(72, 83)
        Me._Line_2.Name = "_Line_2"
        Me._Line_2.Size = New System.Drawing.Size(96, 1)
        Me._Line_2.TabIndex = 70
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.White
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_8.Location = New System.Drawing.Point(16, 328)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_8.Size = New System.Drawing.Size(97, 17)
        Me._Label_8.TabIndex = 33
        Me._Label_8.Tag = "Current Stock"
        Me._Label_8.Text = "Tồn kho hiện thời"
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.White
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_3.Location = New System.Drawing.Point(16, 64)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_3.Size = New System.Drawing.Size(39, 17)
        Me._Label_3.TabIndex = 32
        Me._Label_3.Tag = "Unit"
        Me._Label_3.Text = "Đơn vị"
        '
        '_Line_1
        '
        Me._Line_1.BackColor = System.Drawing.SystemColors.WindowText
        Me._Line_1.Enabled = False
        Me._Line_1.Location = New System.Drawing.Point(72, 59)
        Me._Line_1.Name = "_Line_1"
        Me._Line_1.Size = New System.Drawing.Size(328, 1)
        Me._Line_1.TabIndex = 71
        '
        '_Line_0
        '
        Me._Line_0.BackColor = System.Drawing.SystemColors.WindowText
        Me._Line_0.Enabled = False
        Me._Line_0.Location = New System.Drawing.Point(72, 35)
        Me._Line_0.Name = "_Line_0"
        Me._Line_0.Size = New System.Drawing.Size(328, 1)
        Me._Line_0.TabIndex = 72
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.White
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(16, 40)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_2.Size = New System.Drawing.Size(55, 17)
        Me._Label_2.TabIndex = 31
        Me._Label_2.Tag = "Name"
        Me._Label_2.Text = "Tên hàng"
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.White
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(16, 16)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_1.Size = New System.Drawing.Size(49, 17)
        Me._Label_1.TabIndex = 30
        Me._Label_1.Tag = "Code"
        Me._Label_1.Text = "Mã hàng"
        '
        '_txtNhap_8
        '
        Me._txtNhap_8.AcceptsReturn = True
        Me._txtNhap_8.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_8.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtNhap_8.Location = New System.Drawing.Point(320, 196)
        Me._txtNhap_8.MaxLength = 20
        Me._txtNhap_8.Name = "_txtNhap_8"
        Me._txtNhap_8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._txtNhap_8.Size = New System.Drawing.Size(41, 20)
        Me._txtNhap_8.TabIndex = 84
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
        Me._GrdNT_0.GridLines = ListViewEx.GLGridLines.gridHorizontal
        Me._GrdNT_0.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me._GrdNT_0.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me._GrdNT_0.HeaderHeight = 0
        Me._GrdNT_0.HeaderVisible = False
        Me._GrdNT_0.HeaderWordWrap = False
        Me._GrdNT_0.HotColumnTracking = False
        Me._GrdNT_0.HotItemTracking = False
        Me._GrdNT_0.HotTrackingColor = System.Drawing.Color.LightGray
        Me._GrdNT_0.HoverEvents = False
        Me._GrdNT_0.HoverTime = 1
        Me._GrdNT_0.ImageList = Nothing
        Me._GrdNT_0.ItemHeight = 18
        Me._GrdNT_0.ItemWordWrap = False
        Me._GrdNT_0.Location = New System.Drawing.Point(8, 96)
        Me._GrdNT_0.Name = "_GrdNT_0"
        Me._GrdNT_0.Row = 0
        Me._GrdNT_0.Rows = 0
        Me._GrdNT_0.Selectable = True
        Me._GrdNT_0.SelectedTextColor = System.Drawing.Color.White
        Me._GrdNT_0.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me._GrdNT_0.ShowBorder = True
        Me._GrdNT_0.ShowFocusRect = False
        Me._GrdNT_0.Size = New System.Drawing.Size(393, 101)
        Me._GrdNT_0.SortType = ListViewEx.SortTypes.InsertionSort
        Me._GrdNT_0.SuperFlatHeaderColor = System.Drawing.Color.White
        Me._GrdNT_0.TabIndex = 80
        '
        '_txtNhap_7
        '
        Me._txtNhap_7.AcceptsReturn = True
        Me._txtNhap_7.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_7.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtNhap_7.Location = New System.Drawing.Point(240, 222)
        Me._txtNhap_7.MaxLength = 20
        Me._txtNhap_7.Name = "_txtNhap_7"
        Me._txtNhap_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtNhap_7.Size = New System.Drawing.Size(121, 20)
        Me._txtNhap_7.TabIndex = 109
        Me._txtNhap_7.TabStop = False
        Me._txtNhap_7.Text = "Ty le % dinh muc"
        Me._txtNhap_7.Visible = False
        '
        '_CmdChitiet_1
        '
        Me._CmdChitiet_1.BackColor = System.Drawing.SystemColors.Control
        Me._CmdChitiet_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CmdChitiet_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CmdChitiet_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CmdChitiet_1.Location = New System.Drawing.Point(384, 369)
        Me._CmdChitiet_1.Name = "_CmdChitiet_1"
        Me._CmdChitiet_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._CmdChitiet_1.Size = New System.Drawing.Size(17, 22)
        Me._CmdChitiet_1.TabIndex = 89
        Me._CmdChitiet_1.Text = "*"
        Me._CmdChitiet_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._CmdChitiet_1.UseVisualStyleBackColor = False
        '
        '_txtNhap_6
        '
        Me._txtNhap_6.AcceptsReturn = True
        Me._txtNhap_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtNhap_6.Location = New System.Drawing.Point(296, 368)
        Me._txtNhap_6.MaxLength = 20
        Me._txtNhap_6.Name = "_txtNhap_6"
        Me._txtNhap_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtNhap_6.Size = New System.Drawing.Size(88, 22)
        Me._txtNhap_6.TabIndex = 88
        '
        '_CmdChitiet_0
        '
        Me._CmdChitiet_0.BackColor = System.Drawing.SystemColors.Control
        Me._CmdChitiet_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CmdChitiet_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CmdChitiet_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CmdChitiet_0.Location = New System.Drawing.Point(385, 196)
        Me._CmdChitiet_0.Name = "_CmdChitiet_0"
        Me._CmdChitiet_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._CmdChitiet_0.Size = New System.Drawing.Size(17, 21)
        Me._CmdChitiet_0.TabIndex = 86
        Me._CmdChitiet_0.Text = "*"
        Me._CmdChitiet_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._CmdChitiet_0.UseVisualStyleBackColor = False
        '
        '_txtNhap_3
        '
        Me._txtNhap_3.AcceptsReturn = True
        Me._txtNhap_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtNhap_3.Location = New System.Drawing.Point(240, 196)
        Me._txtNhap_3.MaxLength = 20
        Me._txtNhap_3.Name = "_txtNhap_3"
        Me._txtNhap_3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._txtNhap_3.Size = New System.Drawing.Size(81, 20)
        Me._txtNhap_3.TabIndex = 83
        '
        '_txtNhap_2
        '
        Me._txtNhap_2.AcceptsReturn = True
        Me._txtNhap_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtNhap_2.Location = New System.Drawing.Point(200, 196)
        Me._txtNhap_2.MaxLength = 20
        Me._txtNhap_2.Name = "_txtNhap_2"
        Me._txtNhap_2.ReadOnly = True
        Me._txtNhap_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtNhap_2.Size = New System.Drawing.Size(41, 20)
        Me._txtNhap_2.TabIndex = 82
        Me._txtNhap_2.TabStop = False
        '
        '_txtNhap_1
        '
        Me._txtNhap_1.AcceptsReturn = True
        Me._txtNhap_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtNhap_1.Location = New System.Drawing.Point(64, 196)
        Me._txtNhap_1.MaxLength = 50
        Me._txtNhap_1.Name = "_txtNhap_1"
        Me._txtNhap_1.ReadOnly = True
        Me._txtNhap_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtNhap_1.Size = New System.Drawing.Size(137, 20)
        Me._txtNhap_1.TabIndex = 81
        Me._txtNhap_1.TabStop = False
        '
        '_txtNhap_0
        '
        Me._txtNhap_0.AcceptsReturn = True
        Me._txtNhap_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_0.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtNhap_0.Location = New System.Drawing.Point(8, 196)
        Me._txtNhap_0.MaxLength = 20
        Me._txtNhap_0.Name = "_txtNhap_0"
        Me._txtNhap_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtNhap_0.Size = New System.Drawing.Size(57, 20)
        Me._txtNhap_0.TabIndex = 80
        '
        '_txtTon_2
        '
        Me._txtTon_2.AcceptsReturn = True
        Me._txtTon_2.BackColor = System.Drawing.Color.White
        Me._txtTon_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtTon_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtTon_2.Location = New System.Drawing.Point(184, 397)
        Me._txtTon_2.MaxLength = 12
        Me._txtTon_2.Multiline = True
        Me._txtTon_2.Name = "_txtTon_2"
        Me._txtTon_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtTon_2.Size = New System.Drawing.Size(177, 19)
        Me._txtTon_2.TabIndex = 79
        Me._txtTon_2.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._txtTon_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtNhap_4
        '
        Me._txtNhap_4.AcceptsReturn = True
        Me._txtNhap_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtNhap_4.Location = New System.Drawing.Point(8, 368)
        Me._txtNhap_4.MaxLength = 20
        Me._txtNhap_4.Name = "_txtNhap_4"
        Me._txtNhap_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtNhap_4.Size = New System.Drawing.Size(97, 22)
        Me._txtNhap_4.TabIndex = 78
        '
        '_txtNhap_5
        '
        Me._txtNhap_5.AcceptsReturn = True
        Me._txtNhap_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtNhap_5.Location = New System.Drawing.Point(104, 368)
        Me._txtNhap_5.MaxLength = 50
        Me._txtNhap_5.Name = "_txtNhap_5"
        Me._txtNhap_5.ReadOnly = True
        Me._txtNhap_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtNhap_5.Size = New System.Drawing.Size(193, 22)
        Me._txtNhap_5.TabIndex = 77
        Me._txtNhap_5.TabStop = False
        '
        '_txtNhap_10
        '
        Me._txtNhap_10.AcceptsReturn = True
        Me._txtNhap_10.BackColor = System.Drawing.SystemColors.Window
        Me._txtNhap_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtNhap_10.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtNhap_10.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtNhap_10.Location = New System.Drawing.Point(360, 196)
        Me._txtNhap_10.MaxLength = 50
        Me._txtNhap_10.Name = "_txtNhap_10"
        Me._txtNhap_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtNhap_10.Size = New System.Drawing.Size(25, 20)
        Me._txtNhap_10.TabIndex = 85
        '
        '_Label_39
        '
        Me._Label_39.BackColor = System.Drawing.Color.Teal
        Me._Label_39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_39.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_39.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_39.ForeColor = System.Drawing.Color.White
        Me._Label_39.Location = New System.Drawing.Point(320, 80)
        Me._Label_39.Name = "_Label_39"
        Me._Label_39.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_39.Size = New System.Drawing.Size(41, 17)
        Me._Label_39.TabIndex = 106
        Me._Label_39.Tag = "Unit"
        Me._Label_39.Text = "Tỷ lệ %"
        Me._Label_39.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Line_14
        '
        Me._Line_14.BackColor = System.Drawing.SystemColors.WindowText
        Me._Line_14.Enabled = False
        Me._Line_14.Location = New System.Drawing.Point(240, 75)
        Me._Line_14.Name = "_Line_14"
        Me._Line_14.Size = New System.Drawing.Size(32, 1)
        Me._Line_14.TabIndex = 107
        '
        '_Label_45
        '
        Me._Label_45.BackColor = System.Drawing.Color.White
        Me._Label_45.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_45.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_45.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_45.Location = New System.Drawing.Point(64, 56)
        Me._Label_45.Name = "_Label_45"
        Me._Label_45.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_45.Size = New System.Drawing.Size(97, 17)
        Me._Label_45.TabIndex = 105
        Me._Label_45.Tag = "Minimum Stock"
        Me._Label_45.Text = "Tỷ lệ NVL / Giá bán"
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.Color.Teal
        Me._Label_14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.Color.White
        Me._Label_14.Location = New System.Drawing.Point(240, 80)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_14.Size = New System.Drawing.Size(81, 17)
        Me._Label_14.TabIndex = 102
        Me._Label_14.Tag = "Quantity"
        Me._Label_14.Text = "Số lượng"
        Me._Label_14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_15
        '
        Me._Label_15.BackColor = System.Drawing.Color.Teal
        Me._Label_15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_15.ForeColor = System.Drawing.Color.White
        Me._Label_15.Location = New System.Drawing.Point(200, 80)
        Me._Label_15.Name = "_Label_15"
        Me._Label_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_15.Size = New System.Drawing.Size(41, 17)
        Me._Label_15.TabIndex = 101
        Me._Label_15.Tag = "Unit"
        Me._Label_15.Text = "Đ.v.t"
        Me._Label_15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_19
        '
        Me._Label_19.BackColor = System.Drawing.Color.White
        Me._Label_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_19.Location = New System.Drawing.Point(64, 400)
        Me._Label_19.Name = "_Label_19"
        Me._Label_19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_19.Size = New System.Drawing.Size(105, 17)
        Me._Label_19.TabIndex = 99
        Me._Label_19.Tag = "Norm of Labour"
        Me._Label_19.Text = "Định mức Nhân công"
        '
        '_Line_11
        '
        Me._Line_11.BackColor = System.Drawing.SystemColors.WindowText
        Me._Line_11.Enabled = False
        Me._Line_11.Location = New System.Drawing.Point(184, 416)
        Me._Line_11.Name = "_Line_11"
        Me._Line_11.Size = New System.Drawing.Size(176, 1)
        Me._Line_11.TabIndex = 108
        '
        '_Label_23
        '
        Me._Label_23.BackColor = System.Drawing.Color.Teal
        Me._Label_23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_23.ForeColor = System.Drawing.Color.White
        Me._Label_23.Location = New System.Drawing.Point(296, 256)
        Me._Label_23.Name = "_Label_23"
        Me._Label_23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_23.Size = New System.Drawing.Size(105, 17)
        Me._Label_23.TabIndex = 98
        Me._Label_23.Tag = "Rate"
        Me._Label_23.Text = "Hệ Số"
        Me._Label_23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_20
        '
        Me._Label_20.BackColor = System.Drawing.Color.White
        Me._Label_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_20.Location = New System.Drawing.Point(64, 232)
        Me._Label_20.Name = "_Label_20"
        Me._Label_20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_20.Size = New System.Drawing.Size(185, 17)
        Me._Label_20.TabIndex = 97
        Me._Label_20.Tag = "Rate of Depriciation"
        Me._Label_20.Text = "Hệ số phân bổ chi phí khấu hao TSCĐ"
        '
        '_Label_21
        '
        Me._Label_21.BackColor = System.Drawing.Color.Teal
        Me._Label_21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_21.ForeColor = System.Drawing.Color.White
        Me._Label_21.Location = New System.Drawing.Point(8, 256)
        Me._Label_21.Name = "_Label_21"
        Me._Label_21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_21.Size = New System.Drawing.Size(97, 17)
        Me._Label_21.TabIndex = 96
        Me._Label_21.Tag = "Code"
        Me._Label_21.Text = "Số hiệu"
        Me._Label_21.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_22
        '
        Me._Label_22.BackColor = System.Drawing.Color.Teal
        Me._Label_22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_22.ForeColor = System.Drawing.Color.White
        Me._Label_22.Location = New System.Drawing.Point(104, 256)
        Me._Label_22.Name = "_Label_22"
        Me._Label_22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_22.Size = New System.Drawing.Size(193, 17)
        Me._Label_22.TabIndex = 95
        Me._Label_22.Tag = "Description"
        Me._Label_22.Text = "Tên TSCĐ"
        Me._Label_22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_16
        '
        Me._Label_16.BackColor = System.Drawing.Color.Teal
        Me._Label_16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_16.ForeColor = System.Drawing.Color.White
        Me._Label_16.Location = New System.Drawing.Point(64, 80)
        Me._Label_16.Name = "_Label_16"
        Me._Label_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_16.Size = New System.Drawing.Size(137, 17)
        Me._Label_16.TabIndex = 94
        Me._Label_16.Tag = "Description"
        Me._Label_16.Text = "Tên Nguyên vật liệu"
        Me._Label_16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.Color.Teal
        Me._Label_17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.ForeColor = System.Drawing.Color.White
        Me._Label_17.Location = New System.Drawing.Point(8, 80)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_17.Size = New System.Drawing.Size(57, 17)
        Me._Label_17.TabIndex = 93
        Me._Label_17.Tag = "Code"
        Me._Label_17.Text = "Số hiệu"
        Me._Label_17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_43
        '
        Me._Label_43.BackColor = System.Drawing.Color.Teal
        Me._Label_43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_43.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_43.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_43.ForeColor = System.Drawing.Color.White
        Me._Label_43.Location = New System.Drawing.Point(360, 80)
        Me._Label_43.Name = "_Label_43"
        Me._Label_43.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_43.Size = New System.Drawing.Size(41, 17)
        Me._Label_43.TabIndex = 91
        Me._Label_43.Tag = "Unit"
        Me._Label_43.Text = "--> PL"
        Me._Label_43.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me._GrdNT_1.GridLines = ListViewEx.GLGridLines.gridHorizontal
        Me._GrdNT_1.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me._GrdNT_1.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me._GrdNT_1.HeaderHeight = 0
        Me._GrdNT_1.HeaderVisible = False
        Me._GrdNT_1.HeaderWordWrap = False
        Me._GrdNT_1.HotColumnTracking = False
        Me._GrdNT_1.HotItemTracking = False
        Me._GrdNT_1.HotTrackingColor = System.Drawing.Color.LightGray
        Me._GrdNT_1.HoverEvents = False
        Me._GrdNT_1.HoverTime = 1
        Me._GrdNT_1.ImageList = Nothing
        Me._GrdNT_1.ItemHeight = 18
        Me._GrdNT_1.ItemWordWrap = False
        Me._GrdNT_1.Location = New System.Drawing.Point(8, 267)
        Me._GrdNT_1.Name = "_GrdNT_1"
        Me._GrdNT_1.Row = 0
        Me._GrdNT_1.Rows = 0
        Me._GrdNT_1.Selectable = True
        Me._GrdNT_1.SelectedTextColor = System.Drawing.Color.White
        Me._GrdNT_1.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me._GrdNT_1.ShowBorder = True
        Me._GrdNT_1.ShowFocusRect = False
        Me._GrdNT_1.Size = New System.Drawing.Size(393, 102)
        Me._GrdNT_1.SortType = ListViewEx.SortTypes.InsertionSort
        Me._GrdNT_1.SuperFlatHeaderColor = System.Drawing.Color.White
        Me._GrdNT_1.TabIndex = 78
        '
        '_Label_28
        '
        Me._Label_28.BackColor = System.Drawing.Color.White
        Me._Label_28.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_28.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_28.Location = New System.Drawing.Point(64, 32)
        Me._Label_28.Name = "_Label_28"
        Me._Label_28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_28.Size = New System.Drawing.Size(137, 17)
        Me._Label_28.TabIndex = 92
        Me._Label_28.Tag = "Norm applied FROM month"
        Me._Label_28.Text = "Định mức áp dụng từ tháng"
        '
        'CboThang
        '
        Me.CboThang.BackColor = System.Drawing.SystemColors.Window
        Me.CboThang.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboThang.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboThang.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CboThang.Location = New System.Drawing.Point(240, 32)
        Me.CboThang.Name = "CboThang"
        Me.CboThang.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CboThang.Size = New System.Drawing.Size(73, 21)
        Me.CboThang.TabIndex = 76
        '
        'txtTyle
        '
        Me.txtTyle.AcceptsReturn = True
        Me.txtTyle.BackColor = System.Drawing.SystemColors.Window
        Me.txtTyle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTyle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTyle.Location = New System.Drawing.Point(240, 56)
        Me.txtTyle.MaxLength = 12
        Me.txtTyle.Multiline = True
        Me.txtTyle.Name = "txtTyle"
        Me.txtTyle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTyle.Size = New System.Drawing.Size(33, 19)
        Me.txtTyle.TabIndex = 103
        Me.txtTyle.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtTyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Label_46
        '
        Me._Label_46.BackColor = System.Drawing.Color.White
        Me._Label_46.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_46.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_46.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_46.Location = New System.Drawing.Point(280, 59)
        Me._Label_46.Name = "_Label_46"
        Me._Label_46.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_46.Size = New System.Drawing.Size(9, 17)
        Me._Label_46.TabIndex = 104
        Me._Label_46.Tag = "Minimum Stock"
        Me._Label_46.Text = "%"
        '
        '_Label_18
        '
        Me._Label_18.BackColor = System.Drawing.Color.White
        Me._Label_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_18.Location = New System.Drawing.Point(74, 362)
        Me._Label_18.Name = "_Label_18"
        Me._Label_18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_18.Size = New System.Drawing.Size(129, 17)
        Me._Label_18.TabIndex = 100
        Me._Label_18.Tag = "Norm of Material"
        Me._Label_18.Text = "Định mức Nguyên vật liệu"
        '
        '_Command1_4
        '
        Me._Command1_4.BackColor = System.Drawing.Color.Silver
        Me._Command1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_4.Location = New System.Drawing.Point(848, 440)
        Me._Command1_4.Name = "_Command1_4"
        Me._Command1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Command1_4.Size = New System.Drawing.Size(81, 25)
        Me._Command1_4.TabIndex = 25
        Me._Command1_4.TabStop = False
        Me._Command1_4.Tag = "&Norm"
        Me._Command1_4.Text = "Định &mức"
        Me._Command1_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_4.UseVisualStyleBackColor = False
        Me._Command1_4.Visible = False
        '
        '_Command1_3
        '
        Me._Command1_3.BackColor = System.Drawing.Color.Silver
        Me._Command1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_3.Image = CType(resources.GetObject("_Command1_3.Image"), System.Drawing.Image)
        Me._Command1_3.Location = New System.Drawing.Point(936, 440)
        Me._Command1_3.Name = "_Command1_3"
        Me._Command1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Command1_3.Size = New System.Drawing.Size(73, 25)
        Me._Command1_3.TabIndex = 27
        Me._Command1_3.TabStop = False
        Me._Command1_3.Tag = "&Return"
        Me._Command1_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_3.UseVisualStyleBackColor = False
        Me._Command1_3.Visible = False
        '
        '_Command1_2
        '
        Me._Command1_2.BackColor = System.Drawing.Color.Silver
        Me._Command1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_2.Image = CType(resources.GetObject("_Command1_2.Image"), System.Drawing.Image)
        Me._Command1_2.Location = New System.Drawing.Point(760, 440)
        Me._Command1_2.Name = "_Command1_2"
        Me._Command1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Command1_2.Size = New System.Drawing.Size(73, 25)
        Me._Command1_2.TabIndex = 28
        Me._Command1_2.TabStop = False
        Me._Command1_2.Tag = "&DELETE"
        Me._Command1_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_2.UseVisualStyleBackColor = False
        Me._Command1_2.Visible = False
        '
        '_Command1_1
        '
        Me._Command1_1.BackColor = System.Drawing.Color.Silver
        Me._Command1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_1.Image = CType(resources.GetObject("_Command1_1.Image"), System.Drawing.Image)
        Me._Command1_1.Location = New System.Drawing.Point(680, 440)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Command1_1.Size = New System.Drawing.Size(73, 25)
        Me._Command1_1.TabIndex = 24
        Me._Command1_1.TabStop = False
        Me._Command1_1.Tag = "&Save"
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
        Me._Command1_0.Location = New System.Drawing.Point(600, 440)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Command1_0.Size = New System.Drawing.Size(73, 25)
        Me._Command1_0.TabIndex = 26
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&Add"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        '_SSOpt_1
        '
        Me._SSOpt_1.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_1.Location = New System.Drawing.Point(72, 444)
        Me._SSOpt_1.Name = "_SSOpt_1"
        Me._SSOpt_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._SSOpt_1.Size = New System.Drawing.Size(62, 17)
        Me._SSOpt_1.TabIndex = 3
        Me._SSOpt_1.TabStop = True
        Me._SSOpt_1.Tag = "Desc."
        Me._SSOpt_1.Text = "Tên VT"
        Me._SSOpt_1.UseVisualStyleBackColor = False
        '
        '_SSOpt_0
        '
        Me._SSOpt_0.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_0.Checked = True
        Me._SSOpt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_0.Location = New System.Drawing.Point(8, 444)
        Me._SSOpt_0.Name = "_SSOpt_0"
        Me._SSOpt_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._SSOpt_0.Size = New System.Drawing.Size(62, 17)
        Me._SSOpt_0.TabIndex = 2
        Me._SSOpt_0.TabStop = True
        Me._SSOpt_0.Tag = "Code"
        Me._SSOpt_0.Text = "Số hiệu"
        Me._SSOpt_0.UseVisualStyleBackColor = False
        '
        'txtF
        '
        Me.txtF.AcceptsReturn = True
        Me.txtF.BackColor = System.Drawing.SystemColors.Window
        Me.txtF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtF.Location = New System.Drawing.Point(136, 442)
        Me.txtF.MaxLength = 0
        Me.txtF.Name = "txtF"
        Me.txtF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtF.Size = New System.Drawing.Size(173, 20)
        Me.txtF.TabIndex = 4
        '
        'CboLoai
        '
        Me.CboLoai.BackColor = System.Drawing.SystemColors.Window
        Me.CboLoai.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLoai.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLoai.ForeColor = System.Drawing.Color.Blue
        Me.CboLoai.Location = New System.Drawing.Point(8, 8)
        Me.CboLoai.Name = "CboLoai"
        Me.CboLoai.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CboLoai.Size = New System.Drawing.Size(321, 21)
        Me.CboLoai.TabIndex = 0
        '
        'LstVt
        '
        Me.LstVt.BackColor = System.Drawing.Color.White
        Me.LstVt.Cursor = System.Windows.Forms.Cursors.Default
        Me.LstVt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstVt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LstVt.ItemHeight = 14
        Me.LstVt.Location = New System.Drawing.Point(8, 36)
        Me.LstVt.Name = "LstVt"
        Me.LstVt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LstVt.Size = New System.Drawing.Size(321, 396)
        Me.LstVt.TabIndex = 1
        '
        '_Command_5
        '
        Me._Command_5.Image = Global.UNET.My.Resources.Resources.excel16
        Me._Command_5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_5.Location = New System.Drawing.Point(344, 440)
        Me._Command_5.Name = "_Command_5"
        Me._Command_5.Size = New System.Drawing.Size(121, 25)
        Me._Command_5.TabIndex = 38
        Me._Command_5.Tag = "Excel Import"
        Me._Command_5.Text = "&Nhập từ Excel"
        '
        '_Command_6
        '
        Me._Command_6.Image = Global.UNET.My.Resources.Resources.excel16
        Me._Command_6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_6.Location = New System.Drawing.Point(472, 440)
        Me._Command_6.Name = "_Command_6"
        Me._Command_6.Size = New System.Drawing.Size(121, 25)
        Me._Command_6.TabIndex = 39
        Me._Command_6.Tag = "Excel Export"
        Me._Command_6.Text = "Xuất ra &Excel"
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.SystemColors.Window
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Label_4.Location = New System.Drawing.Point(8, 40)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label_4.Size = New System.Drawing.Size(257, 337)
        Me._Label_4.TabIndex = 37
        '
        'FrmVattu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1015, 472)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me.SSCmdF)
        Me.Controls.Add(Me._Command_4)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command1_4)
        Me.Controls.Add(Me._Command1_3)
        Me.Controls.Add(Me._Command1_2)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me._SSOpt_1)
        Me.Controls.Add(Me._SSOpt_0)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me.CboLoai)
        Me.Controls.Add(Me.LstVt)
        Me.Controls.Add(Me._Command_5)
        Me.Controls.Add(Me._Command_6)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me.Nhapxuat)
        Me.Controls.Add(Me._Panel_1)
        Me.Controls.Add(Me._Label_18)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(23, 47)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmVattu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Hệ thống danh điểm vật tư, hàng hoá"
        Me.Nhapxuat.ResumeLayout(False)
        Me.Nhapxuat.PerformLayout()
        Me._Frame_4.ResumeLayout(False)
        Me._Panel_1.ResumeLayout(False)
        Me._Panel_1.PerformLayout()
        Me._Panel_0.ResumeLayout(False)
        Me._Panel_0.PerformLayout()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Sub InitializetxtTon()
        Me.txtTon(1) = _txtTon_1
        Me.txtTon(0) = _txtTon_0
        Me.txtTon(2) = _txtTon_2
    End Sub
    Sub InitializetxtNhap()
        Me.txtNhap(7) = _txtNhap_7
        Me.txtNhap(6) = _txtNhap_6
        Me.txtNhap(3) = _txtNhap_3
        Me.txtNhap(2) = _txtNhap_2
        Me.txtNhap(1) = _txtNhap_1
        Me.txtNhap(0) = _txtNhap_0
        Me.txtNhap(4) = _txtNhap_4
        Me.txtNhap(5) = _txtNhap_5
        Me.txtNhap(10) = _txtNhap_10
        Me.txtNhap(8) = _txtNhap_8
    End Sub
    Sub InitializeTxtVT()
        Me.TxtVT(11) = _TxtVT_11
        Me.TxtVT(13) = _TxtVT_13
        Me.TxtVT(12) = _TxtVT_12
        Me.TxtVT(4) = _TxtVT_4
        Me.TxtVT(5) = _TxtVT_5
        Me.TxtVT(10) = _TxtVT_10
        Me.TxtVT(9) = _TxtVT_9
        Me.TxtVT(8) = _TxtVT_8
        Me.TxtVT(7) = _TxtVT_7
        Me.TxtVT(6) = _TxtVT_6
        Me.TxtVT(3) = _TxtVT_3
        Me.TxtVT(2) = _TxtVT_2
        Me.TxtVT(1) = _TxtVT_1
        Me.TxtVT(0) = _TxtVT_0
    End Sub
    Sub InitializeSSOpt()
        Me.SSOpt(1) = _SSOpt_1
        Me.SSOpt(0) = _SSOpt_0
    End Sub
    Sub InitializePanel()
        Me.Panel(0) = _Panel_0
        Me.Panel(1) = _Panel_1
    End Sub
    Sub InitializeLine()
        Me.Line(7) = _Line_7
        Me.Line(4) = _Line_4
        Me.Line(13) = _Line_13
        Me.Line(12) = _Line_12
        Me.Line(10) = _Line_10
        Me.Line(9) = _Line_9
        Me.Line(8) = _Line_8
        Me.Line(3) = _Line_3
        Me.Line(6) = _Line_6
        Me.Line(5) = _Line_5
        Me.Line(2) = _Line_2
        Me.Line(1) = _Line_1
        Me.Line(0) = _Line_0
        Me.Line(14) = _Line_14
        Me.Line(11) = _Line_11
    End Sub
    Sub InitializeLabel()
        Me.Label(36) = _Label_36
        Me.Label(38) = _Label_38
        Me.Label(34) = _Label_34
        Me.Label(33) = _Label_33
        Me.Label(35) = _Label_35
        Me.Label(37) = _Label_37
        Me.Label(32) = _Label_32
        Me.Label(31) = _Label_31
        Me.Label(27) = _Label_27
        Me.Label(26) = _Label_26
        Me.Label(11) = _Label_11
        Me.Label(30) = _Label_30
        Me.Label(29) = _Label_29
        Me.Label(7) = _Label_7
        Me.Label(6) = _Label_6
        Me.Label(25) = _Label_25
        Me.Label(24) = _Label_24
        Me.Label(13) = _Label_13
        Me.Label(10) = _Label_10
        Me.Label(12) = _Label_12
        Me.Label(0) = _Label_0
        Me.Label(8) = _Label_8
        Me.Label(3) = _Label_3
        Me.Label(2) = _Label_2
        Me.Label(1) = _Label_1
        Me.Label(39) = _Label_39
        Me.Label(45) = _Label_45
        Me.Label(46) = _Label_46
        Me.Label(14) = _Label_14
        Me.Label(15) = _Label_15
        Me.Label(18) = _Label_18
        Me.Label(19) = _Label_19
        Me.Label(23) = _Label_23
        Me.Label(20) = _Label_20
        Me.Label(21) = _Label_21
        Me.Label(22) = _Label_22
        Me.Label(16) = _Label_16
        Me.Label(17) = _Label_17
        Me.Label(28) = _Label_28
        Me.Label(43) = _Label_43
        Me.Label(4) = _Label_4
        'Me.Label(9) = _Label_9
    End Sub
    Sub InitializeGrdNT()
        Me.GrdNT(2) = _GrdNT_2
        Me.GrdNT(3) = _GrdNT_3
        Me.GrdNT(1) = _GrdNT_1
        Me.GrdNT(0) = _GrdNT_0
    End Sub
    Sub InitializeFrame()
        Me.Frame(4) = _Frame_4
    End Sub
    Sub InitializeCommand1()
        Me.Command1(4) = _Command1_4
        Me.Command1(3) = _Command1_3
        Me.Command1(2) = _Command1_2
        Me.Command1(1) = _Command1_1
        Me.Command1(0) = _Command1_0
    End Sub
    Sub InitializeCommand()
        Me.Command(4) = _Command_4
        Me.Command(3) = _Command_3
        Me.Command(2) = _Command_2
        Me.Command(1) = _Command_1
        Me.Command(0) = _Command_0
        Me.Command(5) = _Command_5
        Me.Command(6) = _Command_6
    End Sub
    Sub InitializeCmdChitiet()
        Me.CmdChitiet(2) = _CmdChitiet_2
        Me.CmdChitiet(1) = _CmdChitiet_1
        Me.CmdChitiet(0) = _CmdChitiet_0
    End Sub
    Sub InitializeCboThang1()
        Me.CboThang1(1) = _CboThang1_1
        Me.CboThang1(0) = _CboThang1_0
    End Sub
    Public WithEvents Grd As ListViewEx.ListviewExt
    Private WithEvents _Panel_0 As System.Windows.Forms.Panel
    Private WithEvents _GrdNT_3 As ListViewEx.ListviewExt
    Private WithEvents _GrdNT_2 As ListViewEx.ListviewExt
    Private WithEvents _Label_27 As System.Windows.Forms.Label
    Private WithEvents _TxtVT_11 As System.Windows.Forms.TextBox
    Public WithEvents Pic As System.Windows.Forms.PictureBox
    Private WithEvents _TxtVT_13 As System.Windows.Forms.TextBox
    Private WithEvents _TxtVT_12 As System.Windows.Forms.TextBox
    Private WithEvents _CmdChitiet_2 As System.Windows.Forms.Button
    Public WithEvents Chk As System.Windows.Forms.CheckBox
    Private WithEvents _TxtVT_4 As System.Windows.Forms.TextBox
    Private WithEvents _TxtVT_5 As System.Windows.Forms.TextBox
    Private WithEvents _TxtVT_10 As System.Windows.Forms.TextBox
    Private WithEvents _TxtVT_9 As System.Windows.Forms.TextBox
    Private WithEvents _TxtVT_8 As System.Windows.Forms.TextBox
    Private WithEvents _TxtVT_7 As System.Windows.Forms.TextBox
    Private WithEvents _TxtVT_6 As System.Windows.Forms.TextBox
    Private WithEvents _TxtVT_3 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_0 As System.Windows.Forms.TextBox
    Private WithEvents _TxtVT_2 As System.Windows.Forms.TextBox
    Private WithEvents _TxtVT_1 As System.Windows.Forms.TextBox
    Private WithEvents _TxtVT_0 As System.Windows.Forms.TextBox
    Private WithEvents _Label_32 As System.Windows.Forms.Label
    Private WithEvents _Line_7 As System.Windows.Forms.Label
    Private WithEvents _Line_4 As System.Windows.Forms.Label
    Private WithEvents _Label_31 As System.Windows.Forms.Label
    Private WithEvents _Label_26 As System.Windows.Forms.Label
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Label_30 As System.Windows.Forms.Label
    Private WithEvents _Label_29 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Line_13 As System.Windows.Forms.Label
    Private WithEvents _Line_12 As System.Windows.Forms.Label
    Private WithEvents _Line_10 As System.Windows.Forms.Label
    Private WithEvents _Label_25 As System.Windows.Forms.Label
    Private WithEvents _Label_24 As System.Windows.Forms.Label
    Private WithEvents _Line_9 As System.Windows.Forms.Label
    Private WithEvents _Line_8 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _Line_3 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Line_6 As System.Windows.Forms.Label
    Private WithEvents _Line_5 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Line_2 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Line_1 As System.Windows.Forms.Label
    Private WithEvents _Line_0 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _txtNhap_8 As System.Windows.Forms.TextBox

#End Region
End Class
