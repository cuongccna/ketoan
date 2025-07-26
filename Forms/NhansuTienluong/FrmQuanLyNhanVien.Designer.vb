<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuanLyNhanVien
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializetxtVT()
		InitializeThaisan()
		InitializeSSOpt()
		InitializeLine()
		InitializeLabel()
		InitializeCommand()
		InitializeCboThang()
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
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _CboThang_5 As ComboBoxEx.ComboBoxExt
    Public WithEvents ChkTangBH As System.Windows.Forms.CheckBox
    Private WithEvents _CboThang_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboThang_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Label_27 As System.Windows.Forms.Label
    Public WithEvents LDThang As System.Windows.Forms.Panel
    Private WithEvents _CboThang_4 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboThang_3 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Label_29 As System.Windows.Forms.Label
    Public WithEvents Frame4 As System.Windows.Forms.Panel
    Public WithEvents ChkThe As System.Windows.Forms.CheckBox
    Private WithEvents _CboThang_2 As ComboBoxEx.ComboBoxExt
    Public WithEvents ChkTang As System.Windows.Forms.CheckBox
    Public WithEvents ChkGiam As System.Windows.Forms.CheckBox
    Public WithEvents CboQuoctich As ComboBoxEx.ComboBoxExt
    Public WithEvents CboChucvu As ComboBoxEx.ComboBoxExt
    Public WithEvents CboLuong As ComboBoxEx.ComboBoxExt
    Public WithEvents CboHD As ComboBoxEx.ComboBoxExt
    Public WithEvents Ngaynghi As System.Windows.Forms.MaskedTextBox
    Private WithEvents _Thaisan_0 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _Thaisan_1 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _Label_26 As System.Windows.Forms.Label
    Public WithEvents ThaisanNgay As System.Windows.Forms.Panel
    Public WithEvents ChkThaisan As System.Windows.Forms.CheckBox
    Public WithEvents Chk As System.Windows.Forms.CheckBox
    Public WithEvents CboBacluong As ComboBoxEx.ComboBoxExt
    Private WithEvents _txtVT_17 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_4 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_15 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_2 As System.Windows.Forms.TextBox
    Public WithEvents MedNgaycap As System.Windows.Forms.MaskedTextBox
    Private WithEvents _Line_5 As System.Windows.Forms.Label
    Private WithEvents _Label_28 As System.Windows.Forms.Label
    Private WithEvents _Line_16 As System.Windows.Forms.Label
    Private WithEvents _Label_23 As System.Windows.Forms.Label
    Private WithEvents _Label_22 As System.Windows.Forms.Label
    Private WithEvents _Line_3 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Private WithEvents _txtVT_14 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_13 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_11 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_12 As System.Windows.Forms.TextBox
    Private WithEvents _Line_14 As System.Windows.Forms.Label
    Private WithEvents _Label_20 As System.Windows.Forms.Label
    Private WithEvents _Line_13 As System.Windows.Forms.Label
    Private WithEvents _Label_19 As System.Windows.Forms.Label
    Private WithEvents _Line_11 As System.Windows.Forms.Label
    Private WithEvents _Label_16 As System.Windows.Forms.Label
    Private WithEvents _Line_8 As System.Windows.Forms.Label
    Private WithEvents _Label_15 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Private WithEvents _txtVT_9 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_8 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_7 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_6 As System.Windows.Forms.TextBox
    Private WithEvents _Line_10 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Line_2 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _Line_6 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Line_9 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Cbo As ComboBoxEx.ComboBoxExt
    Public WithEvents txtF As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_0 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_3 As System.Windows.Forms.TextBox
    Private WithEvents _SSOpt_2 As System.Windows.Forms.RadioButton
    Private WithEvents _SSOpt_1 As System.Windows.Forms.RadioButton
    Private WithEvents _SSOpt_0 As System.Windows.Forms.RadioButton
    Public WithEvents CboLoai As ComboBoxEx.ComboBoxExt
    Public WithEvents LstVt As System.Windows.Forms.ListBox
    Public WithEvents MedNgay As System.Windows.Forms.MaskedTextBox
    Public WithEvents ChkBaohiem As System.Windows.Forms.CheckBox
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Label_25 As System.Windows.Forms.Label
    Private WithEvents _Label_21 As System.Windows.Forms.Label
    Private WithEvents _Line_15 As System.Windows.Forms.Label
    Private WithEvents _Label_18 As System.Windows.Forms.Label
    Private WithEvents _Line_12 As System.Windows.Forms.Label
    Private WithEvents _Label_24 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Line_0 As System.Windows.Forms.Label
    Private WithEvents _Line_1 As System.Windows.Forms.Label
    Private WithEvents _Line_4 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Public CboThang(5) As ComboBoxEx.ComboBoxExt
    Public Command(3) As System.Windows.Forms.Button
    Public Command1(3) As System.Windows.Forms.Button
    Public Label(29) As System.Windows.Forms.Label
    Public Line(16) As System.Windows.Forms.Label
    Public SSOpt(2) As System.Windows.Forms.RadioButton
    Public Thaisan(1) As System.Windows.Forms.MaskedTextBox
    Public txtVT(17) As System.Windows.Forms.TextBox
    'Private listBoxHelper1 As Artinsoft.VB6.Gui.ListBoxHelper
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.SSCmdF = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me._CboThang_5 = New ComboBoxEx.ComboBoxExt
        Me.ChkTangBH = New System.Windows.Forms.CheckBox
        Me.LDThang = New System.Windows.Forms.Panel
        Me._CboThang_0 = New ComboBoxEx.ComboBoxExt
        Me._CboThang_1 = New ComboBoxEx.ComboBoxExt
        Me._Label_27 = New System.Windows.Forms.Label
        Me.Frame4 = New System.Windows.Forms.Panel
        Me._CboThang_4 = New ComboBoxEx.ComboBoxExt
        Me._CboThang_3 = New ComboBoxEx.ComboBoxExt
        Me._Label_29 = New System.Windows.Forms.Label
        Me.ChkThe = New System.Windows.Forms.CheckBox
        Me._CboThang_2 = New ComboBoxEx.ComboBoxExt
        Me.ChkTang = New System.Windows.Forms.CheckBox
        Me.ChkGiam = New System.Windows.Forms.CheckBox
        Me.CboQuoctich = New ComboBoxEx.ComboBoxExt
        Me.CboChucvu = New ComboBoxEx.ComboBoxExt
        Me.CboLuong = New ComboBoxEx.ComboBoxExt
        Me.CboHD = New ComboBoxEx.ComboBoxExt
        Me.Ngaynghi = New System.Windows.Forms.MaskedTextBox
        Me.ThaisanNgay = New System.Windows.Forms.Panel
        Me._Thaisan_0 = New System.Windows.Forms.MaskedTextBox
        Me._Thaisan_1 = New System.Windows.Forms.MaskedTextBox
        Me._Label_26 = New System.Windows.Forms.Label
        Me.ChkThaisan = New System.Windows.Forms.CheckBox
        Me.Chk = New System.Windows.Forms.CheckBox
        Me.CboBacluong = New ComboBoxEx.ComboBoxExt
        Me._txtVT_17 = New System.Windows.Forms.TextBox
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me._txtVT_4 = New System.Windows.Forms.TextBox
        Me._txtVT_15 = New System.Windows.Forms.TextBox
        Me._txtVT_2 = New System.Windows.Forms.TextBox
        Me.MedNgaycap = New System.Windows.Forms.MaskedTextBox
        Me._Line_5 = New System.Windows.Forms.Label
        Me._Label_28 = New System.Windows.Forms.Label
        Me._Line_16 = New System.Windows.Forms.Label
        Me._Label_23 = New System.Windows.Forms.Label
        Me._Label_22 = New System.Windows.Forms.Label
        Me._Line_3 = New System.Windows.Forms.Label
        Me._Label_10 = New System.Windows.Forms.Label
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me._txtVT_14 = New System.Windows.Forms.TextBox
        Me._txtVT_13 = New System.Windows.Forms.TextBox
        Me._txtVT_11 = New System.Windows.Forms.TextBox
        Me._txtVT_12 = New System.Windows.Forms.TextBox
        Me._Line_14 = New System.Windows.Forms.Label
        Me._Label_20 = New System.Windows.Forms.Label
        Me._Line_13 = New System.Windows.Forms.Label
        Me._Label_19 = New System.Windows.Forms.Label
        Me._Line_11 = New System.Windows.Forms.Label
        Me._Label_16 = New System.Windows.Forms.Label
        Me._Line_8 = New System.Windows.Forms.Label
        Me._Label_15 = New System.Windows.Forms.Label
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me._txtVT_9 = New System.Windows.Forms.TextBox
        Me._txtVT_8 = New System.Windows.Forms.TextBox
        Me._txtVT_7 = New System.Windows.Forms.TextBox
        Me._txtVT_6 = New System.Windows.Forms.TextBox
        Me._Line_10 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Line_2 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Label_12 = New System.Windows.Forms.Label
        Me._Line_6 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Line_9 = New System.Windows.Forms.Label
        Me.Cbo = New ComboBoxEx.ComboBoxExt
        Me.txtF = New System.Windows.Forms.TextBox
        Me._txtVT_0 = New System.Windows.Forms.TextBox
        Me._txtVT_1 = New System.Windows.Forms.TextBox
        Me._txtVT_3 = New System.Windows.Forms.TextBox
        Me._SSOpt_2 = New System.Windows.Forms.RadioButton
        Me._SSOpt_1 = New System.Windows.Forms.RadioButton
        Me._SSOpt_0 = New System.Windows.Forms.RadioButton
        Me.CboLoai = New ComboBoxEx.ComboBoxExt
        Me.LstVt = New System.Windows.Forms.ListBox
        Me.MedNgay = New System.Windows.Forms.MaskedTextBox
        Me.ChkBaohiem = New System.Windows.Forms.CheckBox
        Me._Label_11 = New System.Windows.Forms.Label
        Me._Label_25 = New System.Windows.Forms.Label
        Me._Label_21 = New System.Windows.Forms.Label
        Me._Line_15 = New System.Windows.Forms.Label
        Me._Label_18 = New System.Windows.Forms.Label
        Me._Line_12 = New System.Windows.Forms.Label
        Me._Label_24 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Line_0 = New System.Windows.Forms.Label
        Me._Line_1 = New System.Windows.Forms.Label
        Me._Line_4 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_13 = New System.Windows.Forms.Label
        Me._Label_14 = New System.Windows.Forms.Label
        Me._Label_17 = New System.Windows.Forms.Label
        Me.LDThang.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.ThaisanNgay.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SSCmdF
        '
        Me.SSCmdF.Image = Global.UNET.My.Resources.Resources.search3_16
        Me.SSCmdF.Location = New System.Drawing.Point(302, 488)
        Me.SSCmdF.Name = "SSCmdF"
        Me.SSCmdF.Size = New System.Drawing.Size(24, 19)
        Me.SSCmdF.TabIndex = 48
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.add16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(391, 486)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 42
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(471, 486)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 41
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(551, 486)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 43
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(629, 486)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 49
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_CboThang_5
        '
        Me._CboThang_5.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_5.Location = New System.Drawing.Point(344, 144)
        Me._CboThang_5.Name = "_CboThang_5"
        Me._CboThang_5.Size = New System.Drawing.Size(69, 21)
        Me._CboThang_5.TabIndex = 30
        Me._CboThang_5.Visible = False
        '
        'ChkTangBH
        '
        Me.ChkTangBH.BackColor = System.Drawing.Color.White
        Me.ChkTangBH.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkTangBH.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkTangBH.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkTangBH.Location = New System.Drawing.Point(272, 144)
        Me.ChkTangBH.Name = "ChkTangBH"
        Me.ChkTangBH.Size = New System.Drawing.Size(75, 17)
        Me.ChkTangBH.TabIndex = 29
        Me.ChkTangBH.Tag = "Insurance"
        Me.ChkTangBH.Text = "Tăng BH"
        Me.ChkTangBH.UseVisualStyleBackColor = False
        Me.ChkTangBH.Visible = False
        '
        'LDThang
        '
        Me.LDThang.BackColor = System.Drawing.SystemColors.Window
        Me.LDThang.Controls.Add(Me._CboThang_0)
        Me.LDThang.Controls.Add(Me._CboThang_1)
        Me.LDThang.Controls.Add(Me._Label_27)
        Me.LDThang.Cursor = System.Windows.Forms.Cursors.Default
        Me.LDThang.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDThang.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LDThang.Location = New System.Drawing.Point(520, 192)
        Me.LDThang.Name = "LDThang"
        Me.LDThang.Size = New System.Drawing.Size(161, 25)
        Me.LDThang.TabIndex = 80
        Me.LDThang.Visible = False
        '
        '_CboThang_0
        '
        Me._CboThang_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_0.Location = New System.Drawing.Point(0, 0)
        Me._CboThang_0.Name = "_CboThang_0"
        Me._CboThang_0.Size = New System.Drawing.Size(69, 21)
        Me._CboThang_0.TabIndex = 0
        '
        '_CboThang_1
        '
        Me._CboThang_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_1.Location = New System.Drawing.Point(92, 0)
        Me._CboThang_1.Name = "_CboThang_1"
        Me._CboThang_1.Size = New System.Drawing.Size(69, 21)
        Me._CboThang_1.TabIndex = 0
        '
        '_Label_27
        '
        Me._Label_27.BackColor = System.Drawing.Color.White
        Me._Label_27.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_27.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_27.Location = New System.Drawing.Point(66, 0)
        Me._Label_27.Name = "_Label_27"
        Me._Label_27.Size = New System.Drawing.Size(28, 17)
        Me._Label_27.TabIndex = 1
        Me._Label_27.Tag = "to"
        Me._Label_27.Text = "đến"
        Me._Label_27.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Window
        Me.Frame4.Controls.Add(Me._CboThang_4)
        Me.Frame4.Controls.Add(Me._CboThang_3)
        Me.Frame4.Controls.Add(Me._Label_29)
        Me.Frame4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(520, 168)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(161, 25)
        Me.Frame4.TabIndex = 82
        Me.Frame4.Visible = False
        '
        '_CboThang_4
        '
        Me._CboThang_4.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_4.Location = New System.Drawing.Point(92, 0)
        Me._CboThang_4.Name = "_CboThang_4"
        Me._CboThang_4.Size = New System.Drawing.Size(69, 21)
        Me._CboThang_4.TabIndex = 2
        '
        '_CboThang_3
        '
        Me._CboThang_3.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_3.Location = New System.Drawing.Point(0, 0)
        Me._CboThang_3.Name = "_CboThang_3"
        Me._CboThang_3.Size = New System.Drawing.Size(69, 21)
        Me._CboThang_3.TabIndex = 0
        '
        '_Label_29
        '
        Me._Label_29.BackColor = System.Drawing.Color.White
        Me._Label_29.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_29.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_29.Location = New System.Drawing.Point(66, 0)
        Me._Label_29.Name = "_Label_29"
        Me._Label_29.Size = New System.Drawing.Size(28, 17)
        Me._Label_29.TabIndex = 1
        Me._Label_29.Tag = "to"
        Me._Label_29.Text = "đến"
        Me._Label_29.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ChkThe
        '
        Me.ChkThe.BackColor = System.Drawing.Color.White
        Me.ChkThe.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkThe.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkThe.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkThe.Location = New System.Drawing.Point(480, 168)
        Me.ChkThe.Name = "ChkThe"
        Me.ChkThe.Size = New System.Drawing.Size(65, 17)
        Me.ChkThe.TabIndex = 34
        Me.ChkThe.Tag = "Card"
        Me.ChkThe.Text = "Thẻ"
        Me.ChkThe.UseVisualStyleBackColor = False
        Me.ChkThe.Visible = False
        '
        '_CboThang_2
        '
        Me._CboThang_2.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_2.Location = New System.Drawing.Point(344, 192)
        Me._CboThang_2.Name = "_CboThang_2"
        Me._CboThang_2.Size = New System.Drawing.Size(69, 21)
        Me._CboThang_2.TabIndex = 36
        Me._CboThang_2.Visible = False
        '
        'ChkTang
        '
        Me.ChkTang.BackColor = System.Drawing.Color.White
        Me.ChkTang.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkTang.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkTang.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkTang.Location = New System.Drawing.Point(272, 192)
        Me.ChkTang.Name = "ChkTang"
        Me.ChkTang.Size = New System.Drawing.Size(70, 17)
        Me.ChkTang.TabIndex = 35
        Me.ChkTang.Tag = "Labor"
        Me.ChkTang.Text = "Tăng LĐ"
        Me.ChkTang.UseVisualStyleBackColor = False
        '
        'ChkGiam
        '
        Me.ChkGiam.BackColor = System.Drawing.Color.White
        Me.ChkGiam.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkGiam.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkGiam.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkGiam.Location = New System.Drawing.Point(419, 192)
        Me.ChkGiam.Name = "ChkGiam"
        Me.ChkGiam.Size = New System.Drawing.Size(97, 17)
        Me.ChkGiam.TabIndex = 37
        Me.ChkGiam.Tag = "Reduce labor"
        Me.ChkGiam.Text = "Giảm LĐ"
        Me.ChkGiam.UseVisualStyleBackColor = False
        Me.ChkGiam.Visible = False
        '
        'CboQuoctich
        '
        Me.CboQuoctich.BackColor = System.Drawing.SystemColors.Window
        Me.CboQuoctich.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboQuoctich.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboQuoctich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboQuoctich.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboQuoctich.Location = New System.Drawing.Point(328, 96)
        Me.CboQuoctich.Name = "CboQuoctich"
        Me.CboQuoctich.Size = New System.Drawing.Size(113, 21)
        Me.CboQuoctich.TabIndex = 18
        '
        'CboChucvu
        '
        Me.CboChucvu.BackColor = System.Drawing.SystemColors.Window
        Me.CboChucvu.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboChucvu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboChucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboChucvu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboChucvu.Location = New System.Drawing.Point(328, 36)
        Me.CboChucvu.Name = "CboChucvu"
        Me.CboChucvu.Size = New System.Drawing.Size(113, 21)
        Me.CboChucvu.TabIndex = 8
        '
        'CboLuong
        '
        Me.CboLuong.BackColor = System.Drawing.SystemColors.Window
        Me.CboLuong.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboLuong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLuong.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLuong.Location = New System.Drawing.Point(544, 68)
        Me.CboLuong.Name = "CboLuong"
        Me.CboLuong.Size = New System.Drawing.Size(129, 21)
        Me.CboLuong.TabIndex = 16
        '
        'CboHD
        '
        Me.CboHD.BackColor = System.Drawing.SystemColors.Window
        Me.CboHD.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboHD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboHD.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboHD.Location = New System.Drawing.Point(544, 40)
        Me.CboHD.Name = "CboHD"
        Me.CboHD.Size = New System.Drawing.Size(129, 21)
        Me.CboHD.TabIndex = 10
        '
        'Ngaynghi
        '
        Me.Ngaynghi.AllowPromptAsInput = False
        Me.Ngaynghi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ngaynghi.Location = New System.Drawing.Point(412, 168)
        Me.Ngaynghi.Name = "Ngaynghi"
        Me.Ngaynghi.Size = New System.Drawing.Size(57, 20)
        Me.Ngaynghi.TabIndex = 33
        '
        'ThaisanNgay
        '
        Me.ThaisanNgay.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ThaisanNgay.Controls.Add(Me._Thaisan_0)
        Me.ThaisanNgay.Controls.Add(Me._Thaisan_1)
        Me.ThaisanNgay.Controls.Add(Me._Label_26)
        Me.ThaisanNgay.Cursor = System.Windows.Forms.Cursors.Default
        Me.ThaisanNgay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThaisanNgay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ThaisanNgay.Location = New System.Drawing.Point(532, 171)
        Me.ThaisanNgay.Name = "ThaisanNgay"
        Me.ThaisanNgay.Size = New System.Drawing.Size(137, 25)
        Me.ThaisanNgay.TabIndex = 77
        Me.ThaisanNgay.Visible = False
        '
        '_Thaisan_0
        '
        Me._Thaisan_0.AllowPromptAsInput = False
        Me._Thaisan_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Thaisan_0.Location = New System.Drawing.Point(0, 0)
        Me._Thaisan_0.Name = "_Thaisan_0"
        Me._Thaisan_0.Size = New System.Drawing.Size(57, 20)
        Me._Thaisan_0.TabIndex = 0
        '
        '_Thaisan_1
        '
        Me._Thaisan_1.AllowPromptAsInput = False
        Me._Thaisan_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Thaisan_1.Location = New System.Drawing.Point(80, 0)
        Me._Thaisan_1.Name = "_Thaisan_1"
        Me._Thaisan_1.Size = New System.Drawing.Size(57, 20)
        Me._Thaisan_1.TabIndex = 1
        '
        '_Label_26
        '
        Me._Label_26.BackColor = System.Drawing.Color.White
        Me._Label_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_26.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_26.Location = New System.Drawing.Point(56, 0)
        Me._Label_26.Name = "_Label_26"
        Me._Label_26.Size = New System.Drawing.Size(25, 17)
        Me._Label_26.TabIndex = 2
        Me._Label_26.Tag = "to"
        Me._Label_26.Text = "đến"
        Me._Label_26.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ChkThaisan
        '
        Me.ChkThaisan.BackColor = System.Drawing.Color.White
        Me.ChkThaisan.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkThaisan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkThaisan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkThaisan.Location = New System.Drawing.Point(480, 168)
        Me.ChkThaisan.Name = "ChkThaisan"
        Me.ChkThaisan.Size = New System.Drawing.Size(69, 17)
        Me.ChkThaisan.TabIndex = 20
        Me.ChkThaisan.Tag = "Maternity"
        Me.ChkThaisan.Text = "Thai sản"
        Me.ChkThaisan.UseVisualStyleBackColor = False
        '
        'Chk
        '
        Me.Chk.BackColor = System.Drawing.Color.White
        Me.Chk.Cursor = System.Windows.Forms.Cursors.Default
        Me.Chk.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk.Location = New System.Drawing.Point(344, 168)
        Me.Chk.Name = "Chk"
        Me.Chk.Size = New System.Drawing.Size(73, 17)
        Me.Chk.TabIndex = 32
        Me.Chk.Tag = "Off Work"
        Me.Chk.Text = "Nghỉ việc"
        Me.Chk.UseVisualStyleBackColor = False
        '
        'CboBacluong
        '
        Me.CboBacluong.BackColor = System.Drawing.SystemColors.Window
        Me.CboBacluong.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboBacluong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboBacluong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBacluong.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboBacluong.Location = New System.Drawing.Point(544, 96)
        Me.CboBacluong.Name = "CboBacluong"
        Me.CboBacluong.Size = New System.Drawing.Size(33, 21)
        Me.CboBacluong.TabIndex = 20
        '
        '_txtVT_17
        '
        Me._txtVT_17.AcceptsReturn = True
        Me._txtVT_17.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_17.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_17.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_17.Location = New System.Drawing.Point(573, 99)
        Me._txtVT_17.MaxLength = 100
        Me._txtVT_17.Name = "_txtVT_17"
        Me._txtVT_17.ReadOnly = True
        Me._txtVT_17.Size = New System.Drawing.Size(61, 13)
        Me._txtVT_17.TabIndex = 21
        Me._txtVT_17.TabStop = False
        Me._txtVT_17.Text = "0"
        Me._txtVT_17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Window
        Me.Frame3.Controls.Add(Me._txtVT_4)
        Me.Frame3.Controls.Add(Me._txtVT_15)
        Me.Frame3.Controls.Add(Me._txtVT_2)
        Me.Frame3.Controls.Add(Me.MedNgaycap)
        Me.Frame3.Controls.Add(Me._Line_5)
        Me.Frame3.Controls.Add(Me._Label_28)
        Me.Frame3.Controls.Add(Me._Line_16)
        Me.Frame3.Controls.Add(Me._Label_23)
        Me.Frame3.Controls.Add(Me._Label_22)
        Me.Frame3.Controls.Add(Me._Line_3)
        Me.Frame3.Controls.Add(Me._Label_10)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(264, 216)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Size = New System.Drawing.Size(417, 81)
        Me.Frame3.TabIndex = 38
        Me.Frame3.TabStop = False
        Me.Frame3.Tag = "ID card (Possport)"
        Me.Frame3.Text = "CMND(hộ chiếu)"
        '
        '_txtVT_4
        '
        Me._txtVT_4.AcceptsReturn = True
        Me._txtVT_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_4.Location = New System.Drawing.Point(280, 16)
        Me._txtVT_4.MaxLength = 20
        Me._txtVT_4.Name = "_txtVT_4"
        Me._txtVT_4.Size = New System.Drawing.Size(129, 13)
        Me._txtVT_4.TabIndex = 3
        Me._txtVT_4.Text = "..."
        '
        '_txtVT_15
        '
        Me._txtVT_15.AcceptsReturn = True
        Me._txtVT_15.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_15.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_15.Location = New System.Drawing.Point(280, 47)
        Me._txtVT_15.MaxLength = 100
        Me._txtVT_15.Name = "_txtVT_15"
        Me._txtVT_15.Size = New System.Drawing.Size(129, 13)
        Me._txtVT_15.TabIndex = 9
        Me._txtVT_15.Text = "..."
        '
        '_txtVT_2
        '
        Me._txtVT_2.AcceptsReturn = True
        Me._txtVT_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_2.Location = New System.Drawing.Point(64, 16)
        Me._txtVT_2.MaxLength = 20
        Me._txtVT_2.Name = "_txtVT_2"
        Me._txtVT_2.Size = New System.Drawing.Size(145, 13)
        Me._txtVT_2.TabIndex = 1
        Me._txtVT_2.Text = "..."
        '
        'MedNgaycap
        '
        Me.MedNgaycap.AllowPromptAsInput = False
        Me.MedNgaycap.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedNgaycap.Location = New System.Drawing.Point(64, 47)
        Me.MedNgaycap.Name = "MedNgaycap"
        Me.MedNgaycap.Size = New System.Drawing.Size(89, 20)
        Me.MedNgaycap.TabIndex = 6
        '
        '_Line_5
        '
        Me._Line_5.Enabled = False
        Me._Line_5.Location = New System.Drawing.Point(280, 35)
        Me._Line_5.Name = "_Line_5"
        Me._Line_5.Size = New System.Drawing.Size(128, 1)
        Me._Line_5.TabIndex = 8
        '
        '_Label_28
        '
        Me._Label_28.BackColor = System.Drawing.Color.White
        Me._Label_28.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_28.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_28.Location = New System.Drawing.Point(216, 16)
        Me._Label_28.Name = "_Label_28"
        Me._Label_28.Size = New System.Drawing.Size(63, 17)
        Me._Label_28.TabIndex = 2
        Me._Label_28.Tag = "Tax code"
        Me._Label_28.Text = "Mã số thuế"
        '
        '_Line_16
        '
        Me._Line_16.Enabled = False
        Me._Line_16.Location = New System.Drawing.Point(280, 62)
        Me._Line_16.Name = "_Line_16"
        Me._Line_16.Size = New System.Drawing.Size(128, 1)
        Me._Line_16.TabIndex = 10
        '
        '_Label_23
        '
        Me._Label_23.BackColor = System.Drawing.Color.White
        Me._Label_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_23.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_23.Location = New System.Drawing.Point(216, 48)
        Me._Label_23.Name = "_Label_23"
        Me._Label_23.Size = New System.Drawing.Size(47, 17)
        Me._Label_23.TabIndex = 7
        Me._Label_23.Tag = "At"
        Me._Label_23.Text = "Nơi cấp"
        '
        '_Label_22
        '
        Me._Label_22.BackColor = System.Drawing.Color.White
        Me._Label_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_22.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_22.Location = New System.Drawing.Point(8, 48)
        Me._Label_22.Name = "_Label_22"
        Me._Label_22.Size = New System.Drawing.Size(56, 17)
        Me._Label_22.TabIndex = 4
        Me._Label_22.Tag = "Date"
        Me._Label_22.Text = "Ngày cấp"
        '
        '_Line_3
        '
        Me._Line_3.Enabled = False
        Me._Line_3.Location = New System.Drawing.Point(64, 35)
        Me._Line_3.Name = "_Line_3"
        Me._Line_3.Size = New System.Drawing.Size(144, 1)
        Me._Line_3.TabIndex = 5
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.White
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_10.Location = New System.Drawing.Point(8, 20)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(56, 17)
        Me._Label_10.TabIndex = 0
        Me._Label_10.Tag = "ID"
        Me._Label_10.Text = "Số"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Window
        Me.Frame2.Controls.Add(Me._txtVT_14)
        Me.Frame2.Controls.Add(Me._txtVT_13)
        Me.Frame2.Controls.Add(Me._txtVT_11)
        Me.Frame2.Controls.Add(Me._txtVT_12)
        Me.Frame2.Controls.Add(Me._Line_14)
        Me.Frame2.Controls.Add(Me._Label_20)
        Me.Frame2.Controls.Add(Me._Line_13)
        Me.Frame2.Controls.Add(Me._Label_19)
        Me.Frame2.Controls.Add(Me._Line_11)
        Me.Frame2.Controls.Add(Me._Label_16)
        Me.Frame2.Controls.Add(Me._Line_8)
        Me.Frame2.Controls.Add(Me._Label_15)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(264, 376)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(417, 81)
        Me.Frame2.TabIndex = 40
        Me.Frame2.TabStop = False
        Me.Frame2.Tag = "Residence"
        Me.Frame2.Text = "Nơi cư trú "
        '
        '_txtVT_14
        '
        Me._txtVT_14.AcceptsReturn = True
        Me._txtVT_14.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_14.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_14.Location = New System.Drawing.Point(64, 48)
        Me._txtVT_14.MaxLength = 100
        Me._txtVT_14.Name = "_txtVT_14"
        Me._txtVT_14.Size = New System.Drawing.Size(145, 13)
        Me._txtVT_14.TabIndex = 6
        Me._txtVT_14.Text = "..."
        '
        '_txtVT_13
        '
        Me._txtVT_13.AcceptsReturn = True
        Me._txtVT_13.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_13.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_13.Location = New System.Drawing.Point(286, 48)
        Me._txtVT_13.MaxLength = 100
        Me._txtVT_13.Name = "_txtVT_13"
        Me._txtVT_13.Size = New System.Drawing.Size(125, 13)
        Me._txtVT_13.TabIndex = 10
        Me._txtVT_13.Text = "..."
        '
        '_txtVT_11
        '
        Me._txtVT_11.AcceptsReturn = True
        Me._txtVT_11.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_11.Location = New System.Drawing.Point(64, 16)
        Me._txtVT_11.MaxLength = 100
        Me._txtVT_11.Name = "_txtVT_11"
        Me._txtVT_11.Size = New System.Drawing.Size(145, 13)
        Me._txtVT_11.TabIndex = 1
        Me._txtVT_11.Text = "..."
        '
        '_txtVT_12
        '
        Me._txtVT_12.AcceptsReturn = True
        Me._txtVT_12.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_12.Location = New System.Drawing.Point(285, 20)
        Me._txtVT_12.MaxLength = 100
        Me._txtVT_12.Name = "_txtVT_12"
        Me._txtVT_12.Size = New System.Drawing.Size(126, 13)
        Me._txtVT_12.TabIndex = 3
        Me._txtVT_12.Text = "..."
        '
        '_Line_14
        '
        Me._Line_14.Enabled = False
        Me._Line_14.Location = New System.Drawing.Point(64, 67)
        Me._Line_14.Name = "_Line_14"
        Me._Line_14.Size = New System.Drawing.Size(144, 1)
        Me._Line_14.TabIndex = 7
        '
        '_Label_20
        '
        Me._Label_20.BackColor = System.Drawing.Color.White
        Me._Label_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_20.Location = New System.Drawing.Point(8, 48)
        Me._Label_20.Name = "_Label_20"
        Me._Label_20.Size = New System.Drawing.Size(57, 17)
        Me._Label_20.TabIndex = 4
        Me._Label_20.Tag = "Province"
        Me._Label_20.Text = "Tỉnh(TP)"
        '
        '_Line_13
        '
        Me._Line_13.Enabled = False
        Me._Line_13.Location = New System.Drawing.Point(280, 67)
        Me._Line_13.Name = "_Line_13"
        Me._Line_13.Size = New System.Drawing.Size(128, 1)
        Me._Line_13.TabIndex = 11
        '
        '_Label_19
        '
        Me._Label_19.BackColor = System.Drawing.Color.White
        Me._Label_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_19.Location = New System.Drawing.Point(216, 48)
        Me._Label_19.Name = "_Label_19"
        Me._Label_19.Size = New System.Drawing.Size(113, 19)
        Me._Label_19.TabIndex = 8
        Me._Label_19.Tag = "District"
        Me._Label_19.Text = "Quận(huyện)"
        '
        '_Line_11
        '
        Me._Line_11.Enabled = False
        Me._Line_11.Location = New System.Drawing.Point(64, 35)
        Me._Line_11.Name = "_Line_11"
        Me._Line_11.Size = New System.Drawing.Size(144, 1)
        Me._Line_11.TabIndex = 5
        '
        '_Label_16
        '
        Me._Label_16.BackColor = System.Drawing.Color.White
        Me._Label_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_16.Location = New System.Drawing.Point(8, 16)
        Me._Label_16.Name = "_Label_16"
        Me._Label_16.Size = New System.Drawing.Size(57, 33)
        Me._Label_16.TabIndex = 0
        Me._Label_16.Tag = "Number, street"
        Me._Label_16.Text = "Số nhà,  tên đường"
        '
        '_Line_8
        '
        Me._Line_8.Enabled = False
        Me._Line_8.Location = New System.Drawing.Point(280, 43)
        Me._Line_8.Name = "_Line_8"
        Me._Line_8.Size = New System.Drawing.Size(128, 1)
        Me._Line_8.TabIndex = 9
        '
        '_Label_15
        '
        Me._Label_15.BackColor = System.Drawing.Color.White
        Me._Label_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_15.Location = New System.Drawing.Point(219, 19)
        Me._Label_15.Name = "_Label_15"
        Me._Label_15.Size = New System.Drawing.Size(80, 18)
        Me._Label_15.TabIndex = 2
        Me._Label_15.Tag = "Ward"
        Me._Label_15.Text = "Phường(xã)"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Window
        Me.Frame1.Controls.Add(Me._txtVT_9)
        Me.Frame1.Controls.Add(Me._txtVT_8)
        Me.Frame1.Controls.Add(Me._txtVT_7)
        Me.Frame1.Controls.Add(Me._txtVT_6)
        Me.Frame1.Controls.Add(Me._Line_10)
        Me.Frame1.Controls.Add(Me._Label_7)
        Me.Frame1.Controls.Add(Me._Line_2)
        Me.Frame1.Controls.Add(Me._Label_3)
        Me.Frame1.Controls.Add(Me._Label_12)
        Me.Frame1.Controls.Add(Me._Line_6)
        Me.Frame1.Controls.Add(Me._Label_6)
        Me.Frame1.Controls.Add(Me._Line_9)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(264, 296)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(417, 81)
        Me.Frame1.TabIndex = 39
        Me.Frame1.TabStop = False
        Me.Frame1.Tag = "Household"
        Me.Frame1.Text = "Hộ khẩu"
        '
        '_txtVT_9
        '
        Me._txtVT_9.AcceptsReturn = True
        Me._txtVT_9.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_9.Location = New System.Drawing.Point(64, 48)
        Me._txtVT_9.MaxLength = 100
        Me._txtVT_9.Name = "_txtVT_9"
        Me._txtVT_9.Size = New System.Drawing.Size(145, 13)
        Me._txtVT_9.TabIndex = 8
        Me._txtVT_9.Text = "..."
        '
        '_txtVT_8
        '
        Me._txtVT_8.AcceptsReturn = True
        Me._txtVT_8.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_8.Location = New System.Drawing.Point(287, 48)
        Me._txtVT_8.MaxLength = 100
        Me._txtVT_8.Name = "_txtVT_8"
        Me._txtVT_8.Size = New System.Drawing.Size(124, 13)
        Me._txtVT_8.TabIndex = 0
        Me._txtVT_8.Text = "..."
        '
        '_txtVT_7
        '
        Me._txtVT_7.AcceptsReturn = True
        Me._txtVT_7.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_7.Location = New System.Drawing.Point(283, 16)
        Me._txtVT_7.MaxLength = 100
        Me._txtVT_7.Name = "_txtVT_7"
        Me._txtVT_7.Size = New System.Drawing.Size(127, 13)
        Me._txtVT_7.TabIndex = 5
        Me._txtVT_7.Text = "..."
        '
        '_txtVT_6
        '
        Me._txtVT_6.AcceptsReturn = True
        Me._txtVT_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_6.Location = New System.Drawing.Point(64, 16)
        Me._txtVT_6.MaxLength = 100
        Me._txtVT_6.Name = "_txtVT_6"
        Me._txtVT_6.Size = New System.Drawing.Size(145, 13)
        Me._txtVT_6.TabIndex = 1
        Me._txtVT_6.Text = "..."
        '
        '_Line_10
        '
        Me._Line_10.Enabled = False
        Me._Line_10.Location = New System.Drawing.Point(64, 67)
        Me._Line_10.Name = "_Line_10"
        Me._Line_10.Size = New System.Drawing.Size(144, 1)
        Me._Line_10.TabIndex = 9
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.White
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_7.Location = New System.Drawing.Point(8, 48)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(57, 17)
        Me._Label_7.TabIndex = 6
        Me._Label_7.Tag = "Province"
        Me._Label_7.Text = "Tỉnh(TP)"
        '
        '_Line_2
        '
        Me._Line_2.Enabled = False
        Me._Line_2.Location = New System.Drawing.Point(280, 67)
        Me._Line_2.Name = "_Line_2"
        Me._Line_2.Size = New System.Drawing.Size(128, 1)
        Me._Line_2.TabIndex = 1
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.White
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_3.Location = New System.Drawing.Point(214, 48)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(111, 19)
        Me._Label_3.TabIndex = 10
        Me._Label_3.Tag = "District"
        Me._Label_3.Text = "Quận(huyện)"
        '
        '_Label_12
        '
        Me._Label_12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Label_12.BackColor = System.Drawing.Color.White
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_12.Location = New System.Drawing.Point(219, 16)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.Size = New System.Drawing.Size(118, 19)
        Me._Label_12.TabIndex = 4
        Me._Label_12.Tag = "Ward"
        Me._Label_12.Text = "Phường(xã)"
        '
        '_Line_6
        '
        Me._Line_6.Enabled = False
        Me._Line_6.Location = New System.Drawing.Point(280, 35)
        Me._Line_6.Name = "_Line_6"
        Me._Line_6.Size = New System.Drawing.Size(128, 1)
        Me._Line_6.TabIndex = 11
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.White
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_6.Location = New System.Drawing.Point(8, 16)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(60, 33)
        Me._Label_6.TabIndex = 0
        Me._Label_6.Tag = "Number, street"
        Me._Label_6.Text = "Số nhà,  tên đường"
        '
        '_Line_9
        '
        Me._Line_9.Enabled = False
        Me._Line_9.Location = New System.Drawing.Point(64, 35)
        Me._Line_9.Name = "_Line_9"
        Me._Line_9.Size = New System.Drawing.Size(144, 1)
        Me._Line_9.TabIndex = 7
        '
        'Cbo
        '
        Me.Cbo.BackColor = System.Drawing.SystemColors.Window
        Me.Cbo.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cbo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.Cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo.Location = New System.Drawing.Point(544, 124)
        Me.Cbo.Name = "Cbo"
        Me.Cbo.Size = New System.Drawing.Size(129, 21)
        Me.Cbo.TabIndex = 28
        '
        'txtF
        '
        Me.txtF.AcceptsReturn = True
        Me.txtF.BackColor = System.Drawing.SystemColors.Window
        Me.txtF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF.Location = New System.Drawing.Point(208, 487)
        Me.txtF.MaxLength = 0
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(89, 20)
        Me.txtF.TabIndex = 47
        '
        '_txtVT_0
        '
        Me._txtVT_0.AcceptsReturn = True
        Me._txtVT_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_0.Location = New System.Drawing.Point(328, 16)
        Me._txtVT_0.MaxLength = 20
        Me._txtVT_0.Name = "_txtVT_0"
        Me._txtVT_0.Size = New System.Drawing.Size(113, 13)
        Me._txtVT_0.TabIndex = 4
        Me._txtVT_0.Text = "..."
        '
        '_txtVT_1
        '
        Me._txtVT_1.AcceptsReturn = True
        Me._txtVT_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_1.Location = New System.Drawing.Point(544, 16)
        Me._txtVT_1.MaxLength = 100
        Me._txtVT_1.Name = "_txtVT_1"
        Me._txtVT_1.Size = New System.Drawing.Size(129, 13)
        Me._txtVT_1.TabIndex = 6
        Me._txtVT_1.Text = "..."
        '
        '_txtVT_3
        '
        Me._txtVT_3.AcceptsReturn = True
        Me._txtVT_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtVT_3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_3.Location = New System.Drawing.Point(328, 120)
        Me._txtVT_3.MaxLength = 20
        Me._txtVT_3.Name = "_txtVT_3"
        Me._txtVT_3.Size = New System.Drawing.Size(113, 13)
        Me._txtVT_3.TabIndex = 25
        Me._txtVT_3.Text = "..."
        '
        '_SSOpt_2
        '
        Me._SSOpt_2.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_2.Location = New System.Drawing.Point(136, 487)
        Me._SSOpt_2.Name = "_SSOpt_2"
        Me._SSOpt_2.Size = New System.Drawing.Size(66, 21)
        Me._SSOpt_2.TabIndex = 46
        Me._SSOpt_2.TabStop = True
        Me._SSOpt_2.Tag = "Id card"
        Me._SSOpt_2.Text = "CMND"
        Me._SSOpt_2.UseVisualStyleBackColor = False
        '
        '_SSOpt_1
        '
        Me._SSOpt_1.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_1.Location = New System.Drawing.Point(80, 487)
        Me._SSOpt_1.Name = "_SSOpt_1"
        Me._SSOpt_1.Size = New System.Drawing.Size(57, 21)
        Me._SSOpt_1.TabIndex = 45
        Me._SSOpt_1.TabStop = True
        Me._SSOpt_1.Tag = "Name"
        Me._SSOpt_1.Text = "Tên "
        Me._SSOpt_1.UseVisualStyleBackColor = False
        '
        '_SSOpt_0
        '
        Me._SSOpt_0.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_0.Checked = True
        Me._SSOpt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_0.Location = New System.Drawing.Point(8, 487)
        Me._SSOpt_0.Name = "_SSOpt_0"
        Me._SSOpt_0.Size = New System.Drawing.Size(65, 21)
        Me._SSOpt_0.TabIndex = 44
        Me._SSOpt_0.TabStop = True
        Me._SSOpt_0.Tag = "Code"
        Me._SSOpt_0.Text = "Số hiệu"
        Me._SSOpt_0.UseVisualStyleBackColor = False
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
        Me.CboLoai.Size = New System.Drawing.Size(244, 21)
        Me.CboLoai.TabIndex = 0
        '
        'LstVt
        '
        Me.LstVt.BackColor = System.Drawing.SystemColors.Window
        Me.LstVt.Cursor = System.Windows.Forms.Cursors.Default
        Me.LstVt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstVt.ItemHeight = 14
        Me.LstVt.Location = New System.Drawing.Point(8, 35)
        Me.LstVt.Name = "LstVt"
        Me.LstVt.Size = New System.Drawing.Size(244, 438)
        Me.LstVt.TabIndex = 1
        '
        'MedNgay
        '
        Me.MedNgay.AllowPromptAsInput = False
        Me.MedNgay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedNgay.Location = New System.Drawing.Point(328, 70)
        Me.MedNgay.Name = "MedNgay"
        Me.MedNgay.Size = New System.Drawing.Size(112, 20)
        Me.MedNgay.TabIndex = 14
        '
        'ChkBaohiem
        '
        Me.ChkBaohiem.BackColor = System.Drawing.Color.White
        Me.ChkBaohiem.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkBaohiem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBaohiem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkBaohiem.Location = New System.Drawing.Point(272, 168)
        Me.ChkBaohiem.Name = "ChkBaohiem"
        Me.ChkBaohiem.Size = New System.Drawing.Size(84, 17)
        Me.ChkBaohiem.TabIndex = 31
        Me.ChkBaohiem.Tag = "Not SI"
        Me.ChkBaohiem.Text = "Không BH"
        Me.ChkBaohiem.UseVisualStyleBackColor = False
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.White
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_11.Location = New System.Drawing.Point(480, 40)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(57, 17)
        Me._Label_11.TabIndex = 9
        Me._Label_11.Tag = "Contract"
        Me._Label_11.Text = "Loại HĐ"
        '
        '_Label_25
        '
        Me._Label_25.BackColor = System.Drawing.Color.White
        Me._Label_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_25.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_25.Location = New System.Drawing.Point(636, 100)
        Me._Label_25.Name = "_Label_25"
        Me._Label_25.Size = New System.Drawing.Size(48, 20)
        Me._Label_25.TabIndex = 22
        Me._Label_25.Tag = "Month"
        Me._Label_25.Text = "Tháng"
        '
        '_Label_21
        '
        Me._Label_21.BackColor = System.Drawing.Color.White
        Me._Label_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_21.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_21.Location = New System.Drawing.Point(480, 96)
        Me._Label_21.Name = "_Label_21"
        Me._Label_21.Size = New System.Drawing.Size(57, 17)
        Me._Label_21.TabIndex = 19
        Me._Label_21.Tag = "Level"
        Me._Label_21.Text = "Bậc lương"
        '
        '_Line_15
        '
        Me._Line_15.Enabled = False
        Me._Line_15.Location = New System.Drawing.Point(328, 59)
        Me._Line_15.Name = "_Line_15"
        Me._Line_15.Size = New System.Drawing.Size(112, 1)
        Me._Line_15.TabIndex = 13
        '
        '_Label_18
        '
        Me._Label_18.BackColor = System.Drawing.Color.White
        Me._Label_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_18.Location = New System.Drawing.Point(272, 40)
        Me._Label_18.Name = "_Label_18"
        Me._Label_18.Size = New System.Drawing.Size(57, 17)
        Me._Label_18.TabIndex = 7
        Me._Label_18.Tag = "Position"
        Me._Label_18.Text = "Chức vụ"
        '
        '_Line_12
        '
        Me._Line_12.Enabled = False
        Me._Line_12.Location = New System.Drawing.Point(328, 115)
        Me._Line_12.Name = "_Line_12"
        Me._Line_12.Size = New System.Drawing.Size(112, 1)
        Me._Line_12.TabIndex = 24
        '
        '_Label_24
        '
        Me._Label_24.BackColor = System.Drawing.Color.White
        Me._Label_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_24.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_24.Location = New System.Drawing.Point(272, 96)
        Me._Label_24.Name = "_Label_24"
        Me._Label_24.Size = New System.Drawing.Size(60, 17)
        Me._Label_24.TabIndex = 17
        Me._Label_24.Tag = "Nationality"
        Me._Label_24.Text = "Quốc tịch"
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.White
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_8.Location = New System.Drawing.Point(480, 124)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(30, 17)
        Me._Label_8.TabIndex = 27
        Me._Label_8.Tag = "Sex"
        Me._Label_8.Text = "Phái"
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.White
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(272, 16)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(41, 17)
        Me._Label_1.TabIndex = 3
        Me._Label_1.Tag = "Code"
        Me._Label_1.Text = "Mã NV"
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.White
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(480, 16)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(49, 17)
        Me._Label_2.TabIndex = 5
        Me._Label_2.Tag = "Name"
        Me._Label_2.Text = "Tên NV"
        '
        '_Line_0
        '
        Me._Line_0.Enabled = False
        Me._Line_0.Location = New System.Drawing.Point(328, 35)
        Me._Line_0.Name = "_Line_0"
        Me._Line_0.Size = New System.Drawing.Size(112, 1)
        Me._Line_0.TabIndex = 9
        '
        '_Line_1
        '
        Me._Line_1.Enabled = False
        Me._Line_1.Location = New System.Drawing.Point(544, 35)
        Me._Line_1.Name = "_Line_1"
        Me._Line_1.Size = New System.Drawing.Size(128, 1)
        Me._Line_1.TabIndex = 11
        '
        '_Line_4
        '
        Me._Line_4.Enabled = False
        Me._Line_4.Location = New System.Drawing.Point(328, 139)
        Me._Line_4.Name = "_Line_4"
        Me._Line_4.Size = New System.Drawing.Size(112, 1)
        Me._Line_4.TabIndex = 26
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.White
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(272, 120)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(55, 17)
        Me._Label_0.TabIndex = 23
        Me._Label_0.Tag = "Tel"
        Me._Label_0.Text = "Điện thoại"
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.White
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_13.Location = New System.Drawing.Point(480, 68)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(68, 17)
        Me._Label_13.TabIndex = 15
        Me._Label_13.Tag = "Salary class"
        Me._Label_13.Text = "Loại lương"
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.Color.White
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_14.Location = New System.Drawing.Point(272, 72)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(54, 17)
        Me._Label_14.TabIndex = 12
        Me._Label_14.Tag = "Birth Date"
        Me._Label_14.Text = "Ngày sinh"
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.SystemColors.Window
        Me._Label_17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.Location = New System.Drawing.Point(258, 6)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(444, 467)
        Me._Label_17.TabIndex = 2
        '
        'FrmQuanLyNhanVien
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(712, 521)
        Me.Controls.Add(Me.SSCmdF)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._CboThang_5)
        Me.Controls.Add(Me.ChkTangBH)
        Me.Controls.Add(Me.LDThang)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.ChkThe)
        Me.Controls.Add(Me._CboThang_2)
        Me.Controls.Add(Me.ChkTang)
        Me.Controls.Add(Me.ChkGiam)
        Me.Controls.Add(Me.CboQuoctich)
        Me.Controls.Add(Me.CboChucvu)
        Me.Controls.Add(Me.CboLuong)
        Me.Controls.Add(Me.CboHD)
        Me.Controls.Add(Me.Ngaynghi)
        Me.Controls.Add(Me.ThaisanNgay)
        Me.Controls.Add(Me.ChkThaisan)
        Me.Controls.Add(Me.Chk)
        Me.Controls.Add(Me.CboBacluong)
        Me.Controls.Add(Me._txtVT_17)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Cbo)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me._txtVT_0)
        Me.Controls.Add(Me._txtVT_1)
        Me.Controls.Add(Me._txtVT_3)
        Me.Controls.Add(Me._SSOpt_2)
        Me.Controls.Add(Me._SSOpt_1)
        Me.Controls.Add(Me._SSOpt_0)
        Me.Controls.Add(Me.CboLoai)
        Me.Controls.Add(Me.LstVt)
        Me.Controls.Add(Me.MedNgay)
        Me.Controls.Add(Me.ChkBaohiem)
        Me.Controls.Add(Me._Label_11)
        Me.Controls.Add(Me._Label_25)
        Me.Controls.Add(Me._Label_21)
        Me.Controls.Add(Me._Line_15)
        Me.Controls.Add(Me._Label_18)
        Me.Controls.Add(Me._Line_12)
        Me.Controls.Add(Me._Label_24)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Line_0)
        Me.Controls.Add(Me._Line_1)
        Me.Controls.Add(Me._Line_4)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me._Label_14)
        Me.Controls.Add(Me._Label_17)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(72, 67)
        Me.MaximizeBox = False
        Me.Name = "FrmQuanLyNhanVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "List of Employees"
        Me.Text = "Danh sách Nhân viên Công Ty"
        Me.LDThang.ResumeLayout(False)
        Me.Frame4.ResumeLayout(False)
        Me.ThaisanNgay.ResumeLayout(False)
        Me.ThaisanNgay.PerformLayout()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializetxtVT()
		Me.txtVT(17) = _txtVT_17
		Me.txtVT(4) = _txtVT_4
		Me.txtVT(15) = _txtVT_15
		Me.txtVT(2) = _txtVT_2
		Me.txtVT(14) = _txtVT_14
		Me.txtVT(13) = _txtVT_13
		Me.txtVT(11) = _txtVT_11
		Me.txtVT(12) = _txtVT_12
		Me.txtVT(9) = _txtVT_9
		Me.txtVT(8) = _txtVT_8
		Me.txtVT(7) = _txtVT_7
		Me.txtVT(6) = _txtVT_6
		Me.txtVT(0) = _txtVT_0
		Me.txtVT(1) = _txtVT_1
		Me.txtVT(3) = _txtVT_3
	End Sub
	Sub InitializeThaisan()
		Me.Thaisan(0) = _Thaisan_0
		Me.Thaisan(1) = _Thaisan_1
	End Sub
	Sub InitializeSSOpt()
		Me.SSOpt(2) = _SSOpt_2
		Me.SSOpt(1) = _SSOpt_1
		Me.SSOpt(0) = _SSOpt_0
	End Sub
	Sub InitializeLine()
		Me.Line(5) = _Line_5
		Me.Line(16) = _Line_16
		Me.Line(3) = _Line_3
		Me.Line(14) = _Line_14
		Me.Line(13) = _Line_13
		Me.Line(11) = _Line_11
		Me.Line(8) = _Line_8
		Me.Line(10) = _Line_10
		Me.Line(2) = _Line_2
		Me.Line(6) = _Line_6
		Me.Line(9) = _Line_9
		Me.Line(15) = _Line_15
		Me.Line(12) = _Line_12
		Me.Line(0) = _Line_0
		Me.Line(1) = _Line_1
		Me.Line(4) = _Line_4
	End Sub
	Sub InitializeLabel()
		Me.Label(27) = _Label_27
		Me.Label(29) = _Label_29
		Me.Label(26) = _Label_26
		Me.Label(28) = _Label_28
		Me.Label(23) = _Label_23
		Me.Label(22) = _Label_22
		Me.Label(10) = _Label_10
		Me.Label(20) = _Label_20
		Me.Label(19) = _Label_19
		Me.Label(16) = _Label_16
		Me.Label(15) = _Label_15
		Me.Label(7) = _Label_7
		Me.Label(3) = _Label_3
		Me.Label(12) = _Label_12
		Me.Label(6) = _Label_6
		Me.Label(11) = _Label_11
		Me.Label(25) = _Label_25
		Me.Label(21) = _Label_21
		Me.Label(18) = _Label_18
		Me.Label(24) = _Label_24
		Me.Label(8) = _Label_8
		Me.Label(1) = _Label_1
		Me.Label(2) = _Label_2
		Me.Label(0) = _Label_0
		Me.Label(13) = _Label_13
		Me.Label(14) = _Label_14
		Me.Label(17) = _Label_17
        'Me.Label(5) = _Label_5
        'Me.Label(4) = _Label_4
        'Me.Label(9) = _Label_9
	End Sub
	Sub InitializeCommand()
		Me.Command(0) = _Command_0
		Me.Command(1) = _Command_1
		Me.Command(2) = _Command_2
		Me.Command(3) = _Command_3
	End Sub
	Sub InitializeCboThang()
		Me.CboThang(5) = _CboThang_5
		Me.CboThang(0) = _CboThang_0
		Me.CboThang(1) = _CboThang_1
		Me.CboThang(4) = _CboThang_4
		Me.CboThang(3) = _CboThang_3
		Me.CboThang(2) = _CboThang_2
	End Sub
#End Region 
End Class
