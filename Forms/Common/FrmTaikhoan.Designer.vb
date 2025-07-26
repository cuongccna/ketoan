<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTaikhoan
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializetxtDuNT()
		InitializetxtDu()
		Initializetxt()
		InitializeSSOpt()
		InitializeMedNgay()
		InitializeLine1()
		InitializeLine()
		InitializeLabel()
		InitializeGrdNT()
		InitializeFrame()
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
    Private WithEvents _Command_5 As System.Windows.Forms.Button
    Private WithEvents _Command_4 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _txt_6 As System.Windows.Forms.TextBox
    Private WithEvents _txt_4 As System.Windows.Forms.TextBox
    Private WithEvents _txt_5 As System.Windows.Forms.TextBox
    Private WithEvents _txtDu_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtDu_3 As System.Windows.Forms.TextBox
    Private WithEvents _txtDu_4 As System.Windows.Forms.TextBox
    Private WithEvents _txtDu_5 As System.Windows.Forms.TextBox
    Private WithEvents _MedNgay_0 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _MedNgay_1 As System.Windows.Forms.MaskedTextBox
    Private WithEvents _Label_25 As System.Windows.Forms.Label
    Private WithEvents _Line_5 As System.Windows.Forms.Label
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Private WithEvents _Line_6 As System.Windows.Forms.Label
    Private WithEvents _Label_18 As System.Windows.Forms.Label
    Private WithEvents _Line_7 As System.Windows.Forms.Label
    Private WithEvents _Label_19 As System.Windows.Forms.Label
    Private WithEvents _Line_8 As System.Windows.Forms.Label
    Private WithEvents _Label_20 As System.Windows.Forms.Label
    Private WithEvents _Label_21 As System.Windows.Forms.Label
    Private WithEvents _Label_22 As System.Windows.Forms.Label
    Private WithEvents _Label_23 As System.Windows.Forms.Label
    Private WithEvents _Label_24 As System.Windows.Forms.Label
    Private WithEvents _Line_9 As System.Windows.Forms.Label
    Private WithEvents _Line_10 As System.Windows.Forms.Label
    Private WithEvents _Line_11 As System.Windows.Forms.Label
    Private WithEvents _Frame_1 As System.Windows.Forms.GroupBox
    Private WithEvents _txtDu_6 As System.Windows.Forms.TextBox
    Private WithEvents _txt_3 As System.Windows.Forms.TextBox
    Public WithEvents CboNT As ComboBoxEx.ComboBoxExt
    Private WithEvents _SSOpt_1 As System.Windows.Forms.RadioButton
    Private WithEvents _SSOpt_0 As System.Windows.Forms.RadioButton
    Private WithEvents _Frame_0 As System.Windows.Forms.GroupBox
    Private WithEvents _txt_0 As System.Windows.Forms.TextBox
    Private WithEvents _txt_1 As System.Windows.Forms.TextBox
    Public WithEvents OptNo As System.Windows.Forms.RadioButton
    Public WithEvents OptCo As System.Windows.Forms.RadioButton
    Public WithEvents ChkBtc As System.Windows.Forms.CheckBox
    Private WithEvents _txtDu_0 As System.Windows.Forms.TextBox
    Private WithEvents _txtDu_1 As System.Windows.Forms.TextBox
    Public WithEvents CmdNT As System.Windows.Forms.Button
    Public WithEvents ChkDT As System.Windows.Forms.CheckBox
    Private WithEvents _txt_2 As System.Windows.Forms.TextBox
    Public WithEvents txtF As System.Windows.Forms.TextBox
    Public WithEvents CboLoai As ComboBoxEx.ComboBoxExt
    Private WithEvents _GrdNT_0 As ListViewEx.ListviewExt
    Private WithEvents _GrdNT_1 As ListViewEx.ListviewExt
    'Public WithEvents OtlTk As MSOutl.Outline
    Private WithEvents _Label_26 As System.Windows.Forms.Label
    Private WithEvents _Line_12 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Line1_5 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Line1_0 As System.Windows.Forms.Label
    Private WithEvents _Line1_1 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_9 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Line1_2 As System.Windows.Forms.Label
    Private WithEvents _Line1_3 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_16 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Private WithEvents _Line1_4 As System.Windows.Forms.Label
    Private WithEvents _Label_15 As System.Windows.Forms.Label
    Public Command(5) As System.Windows.Forms.Button
    Public Command1(4) As System.Windows.Forms.Button
    Public Frame(1) As System.Windows.Forms.GroupBox
    Public GrdNT(1) As ListViewEx.ListviewExt
    Public Label(26) As System.Windows.Forms.Label
    Public Line(12) As System.Windows.Forms.Label
    Public Line1(5) As System.Windows.Forms.Label
    Public MedNgay(1) As System.Windows.Forms.MaskedTextBox
    Public SSOpt(1) As System.Windows.Forms.RadioButton
    Public txt(6) As System.Windows.Forms.TextBox
    Public txtDu(6) As System.Windows.Forms.TextBox
    Public txtDuNT(2) As System.Windows.Forms.TextBox
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTaikhoan))
        Me._Command_5 = New System.Windows.Forms.Button
        Me._Command_4 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Frame_1 = New System.Windows.Forms.GroupBox
        Me._txt_6 = New System.Windows.Forms.TextBox
        Me._txt_4 = New System.Windows.Forms.TextBox
        Me._txt_5 = New System.Windows.Forms.TextBox
        Me._txtDu_2 = New System.Windows.Forms.TextBox
        Me._txtDu_3 = New System.Windows.Forms.TextBox
        Me._txtDu_4 = New System.Windows.Forms.TextBox
        Me._txtDu_5 = New System.Windows.Forms.TextBox
        Me._MedNgay_0 = New System.Windows.Forms.MaskedTextBox
        Me._MedNgay_1 = New System.Windows.Forms.MaskedTextBox
        Me._Label_25 = New System.Windows.Forms.Label
        Me._Line_5 = New System.Windows.Forms.Label
        Me._Label_17 = New System.Windows.Forms.Label
        Me._Line_6 = New System.Windows.Forms.Label
        Me._Label_18 = New System.Windows.Forms.Label
        Me._Line_7 = New System.Windows.Forms.Label
        Me._Label_19 = New System.Windows.Forms.Label
        Me._Line_8 = New System.Windows.Forms.Label
        Me._Label_20 = New System.Windows.Forms.Label
        Me._Label_21 = New System.Windows.Forms.Label
        Me._Label_22 = New System.Windows.Forms.Label
        Me._Label_23 = New System.Windows.Forms.Label
        Me._Label_24 = New System.Windows.Forms.Label
        Me._Line_9 = New System.Windows.Forms.Label
        Me._Line_10 = New System.Windows.Forms.Label
        Me._Line_11 = New System.Windows.Forms.Label
        Me._txtDu_6 = New System.Windows.Forms.TextBox
        Me._txt_3 = New System.Windows.Forms.TextBox
        Me.CboNT = New ComboBoxEx.ComboBoxExt
        Me._Frame_0 = New System.Windows.Forms.GroupBox
        Me._SSOpt_1 = New System.Windows.Forms.RadioButton
        Me._SSOpt_0 = New System.Windows.Forms.RadioButton
        Me._txt_0 = New System.Windows.Forms.TextBox
        Me._txt_1 = New System.Windows.Forms.TextBox
        Me.OptNo = New System.Windows.Forms.RadioButton
        Me.OptCo = New System.Windows.Forms.RadioButton
        Me.ChkBtc = New System.Windows.Forms.CheckBox
        Me._txtDu_0 = New System.Windows.Forms.TextBox
        Me._txtDu_1 = New System.Windows.Forms.TextBox
        Me.CmdNT = New System.Windows.Forms.Button
        Me.ChkDT = New System.Windows.Forms.CheckBox
        Me._txt_2 = New System.Windows.Forms.TextBox
        Me.txtF = New System.Windows.Forms.TextBox
        Me.CboLoai = New ComboBoxEx.ComboBoxExt
        Me._Label_26 = New System.Windows.Forms.Label
        Me._Line_12 = New System.Windows.Forms.Label
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Label_5 = New System.Windows.Forms.Label
        Me._Line1_5 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Line1_0 = New System.Windows.Forms.Label
        Me._Line1_1 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_9 = New System.Windows.Forms.Label
        Me._Label_10 = New System.Windows.Forms.Label
        Me._Line1_2 = New System.Windows.Forms.Label
        Me._Line1_3 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Label_16 = New System.Windows.Forms.Label
        Me._Label_14 = New System.Windows.Forms.Label
        Me._Line1_4 = New System.Windows.Forms.Label
        Me._Label_15 = New System.Windows.Forms.Label
        Me.trvHTTK = New System.Windows.Forms.TreeView
        Me.ImageList_HTTK = New System.Windows.Forms.ImageList(Me.components)
        Me._GrdNT_0 = New ListViewEx.ListviewExt
        Me._GrdNT_1 = New ListViewEx.ListviewExt
        Me._txtDuNT_0 = New System.Windows.Forms.TextBox
        Me._txtDuNT_1 = New System.Windows.Forms.TextBox
        Me._txtDuNT_2 = New System.Windows.Forms.TextBox
        Me._Frame_1.SuspendLayout()
        Me._Frame_0.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Command_5
        '
        Me._Command_5.Image = Global.UNET.My.Resources.Resources.search2_16
        Me._Command_5.Location = New System.Drawing.Point(296, 444)
        Me._Command_5.Name = "_Command_5"
        Me._Command_5.Size = New System.Drawing.Size(25, 25)
        Me._Command_5.TabIndex = 25
        '
        '_Command_4
        '
        Me._Command_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_4.Location = New System.Drawing.Point(541, 164)
        Me._Command_4.Name = "_Command_4"
        Me._Command_4.Size = New System.Drawing.Size(93, 25)
        Me._Command_4.TabIndex = 70
        Me._Command_4.Tag = "Details"
        Me._Command_4.Text = "&Chi tiết CT"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(496, 442)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 22
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(576, 442)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 24
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(416, 442)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 18
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.add16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(336, 442)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 19
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        '
        '_Frame_1
        '
        Me._Frame_1.BackColor = System.Drawing.SystemColors.Window
        Me._Frame_1.Controls.Add(Me._txt_6)
        Me._Frame_1.Controls.Add(Me._txt_4)
        Me._Frame_1.Controls.Add(Me._txt_5)
        Me._Frame_1.Controls.Add(Me._txtDu_2)
        Me._Frame_1.Controls.Add(Me._txtDu_3)
        Me._Frame_1.Controls.Add(Me._txtDu_4)
        Me._Frame_1.Controls.Add(Me._txtDu_5)
        Me._Frame_1.Controls.Add(Me._MedNgay_0)
        Me._Frame_1.Controls.Add(Me._MedNgay_1)
        Me._Frame_1.Controls.Add(Me._Label_25)
        Me._Frame_1.Controls.Add(Me._Line_5)
        Me._Frame_1.Controls.Add(Me._Label_17)
        Me._Frame_1.Controls.Add(Me._Line_6)
        Me._Frame_1.Controls.Add(Me._Label_18)
        Me._Frame_1.Controls.Add(Me._Line_7)
        Me._Frame_1.Controls.Add(Me._Label_19)
        Me._Frame_1.Controls.Add(Me._Line_8)
        Me._Frame_1.Controls.Add(Me._Label_20)
        Me._Frame_1.Controls.Add(Me._Label_21)
        Me._Frame_1.Controls.Add(Me._Label_22)
        Me._Frame_1.Controls.Add(Me._Label_23)
        Me._Frame_1.Controls.Add(Me._Label_24)
        Me._Frame_1.Controls.Add(Me._Line_9)
        Me._Frame_1.Controls.Add(Me._Line_10)
        Me._Frame_1.Controls.Add(Me._Line_11)
        Me._Frame_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_1.Location = New System.Drawing.Point(335, 192)
        Me._Frame_1.Name = "_Frame_1"
        Me._Frame_1.Size = New System.Drawing.Size(299, 225)
        Me._Frame_1.TabIndex = 51
        Me._Frame_1.TabStop = False
        Me._Frame_1.Text = "Thông tin công trình, hạng mục"
        Me._Frame_1.Visible = False
        '
        '_txt_6
        '
        Me._txt_6.AcceptsReturn = True
        Me._txt_6.BackColor = System.Drawing.SystemColors.Window
        Me._txt_6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txt_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_6.Location = New System.Drawing.Point(64, 16)
        Me._txt_6.MaxLength = 50
        Me._txt_6.Name = "_txt_6"
        Me._txt_6.Size = New System.Drawing.Size(225, 13)
        Me._txt_6.TabIndex = 52
        '
        '_txt_4
        '
        Me._txt_4.AcceptsReturn = True
        Me._txt_4.BackColor = System.Drawing.SystemColors.Window
        Me._txt_4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txt_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_4.Location = New System.Drawing.Point(64, 40)
        Me._txt_4.MaxLength = 2
        Me._txt_4.Name = "_txt_4"
        Me._txt_4.Size = New System.Drawing.Size(25, 13)
        Me._txt_4.TabIndex = 53
        '
        '_txt_5
        '
        Me._txt_5.AcceptsReturn = True
        Me._txt_5.BackColor = System.Drawing.SystemColors.Window
        Me._txt_5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txt_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_5.Location = New System.Drawing.Point(64, 64)
        Me._txt_5.MaxLength = 50
        Me._txt_5.Name = "_txt_5"
        Me._txt_5.Size = New System.Drawing.Size(225, 13)
        Me._txt_5.TabIndex = 55
        '
        '_txtDu_2
        '
        Me._txtDu_2.AcceptsReturn = True
        Me._txtDu_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtDu_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtDu_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtDu_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtDu_2.ForeColor = System.Drawing.Color.Blue
        Me._txtDu_2.Location = New System.Drawing.Point(176, 40)
        Me._txtDu_2.MaxLength = 20
        Me._txtDu_2.Multiline = True
        Me._txtDu_2.Name = "_txtDu_2"
        Me._txtDu_2.Size = New System.Drawing.Size(113, 19)
        Me._txtDu_2.TabIndex = 54
        Me._txtDu_2.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._txtDu_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtDu_3
        '
        Me._txtDu_3.AcceptsReturn = True
        Me._txtDu_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtDu_3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtDu_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtDu_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtDu_3.ForeColor = System.Drawing.Color.Blue
        Me._txtDu_3.Location = New System.Drawing.Point(64, 96)
        Me._txtDu_3.MaxLength = 20
        Me._txtDu_3.Multiline = True
        Me._txtDu_3.Name = "_txtDu_3"
        Me._txtDu_3.Size = New System.Drawing.Size(97, 19)
        Me._txtDu_3.TabIndex = 56
        Me._txtDu_3.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._txtDu_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtDu_4
        '
        Me._txtDu_4.AcceptsReturn = True
        Me._txtDu_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtDu_4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtDu_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtDu_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtDu_4.ForeColor = System.Drawing.Color.Blue
        Me._txtDu_4.Location = New System.Drawing.Point(64, 120)
        Me._txtDu_4.MaxLength = 20
        Me._txtDu_4.Multiline = True
        Me._txtDu_4.Name = "_txtDu_4"
        Me._txtDu_4.Size = New System.Drawing.Size(97, 19)
        Me._txtDu_4.TabIndex = 57
        Me._txtDu_4.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._txtDu_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtDu_5
        '
        Me._txtDu_5.AcceptsReturn = True
        Me._txtDu_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtDu_5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtDu_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtDu_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtDu_5.ForeColor = System.Drawing.Color.Blue
        Me._txtDu_5.Location = New System.Drawing.Point(64, 144)
        Me._txtDu_5.MaxLength = 20
        Me._txtDu_5.Multiline = True
        Me._txtDu_5.Name = "_txtDu_5"
        Me._txtDu_5.Size = New System.Drawing.Size(97, 19)
        Me._txtDu_5.TabIndex = 58
        Me._txtDu_5.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._txtDu_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_MedNgay_0
        '
        Me._MedNgay_0.AllowPromptAsInput = False
        Me._MedNgay_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_0.Location = New System.Drawing.Point(224, 120)
        Me._MedNgay_0.Mask = "00/00/0000"
        Me._MedNgay_0.Name = "_MedNgay_0"
        Me._MedNgay_0.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_0.TabIndex = 59
        '
        '_MedNgay_1
        '
        Me._MedNgay_1.AllowPromptAsInput = False
        Me._MedNgay_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MedNgay_1.Location = New System.Drawing.Point(224, 144)
        Me._MedNgay_1.Mask = "00/00/0000"
        Me._MedNgay_1.Name = "_MedNgay_1"
        Me._MedNgay_1.Size = New System.Drawing.Size(57, 20)
        Me._MedNgay_1.TabIndex = 60
        '
        '_Label_25
        '
        Me._Label_25.BackColor = System.Drawing.Color.White
        Me._Label_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_25.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_25.Location = New System.Drawing.Point(8, 16)
        Me._Label_25.Name = "_Label_25"
        Me._Label_25.Size = New System.Drawing.Size(47, 17)
        Me._Label_25.TabIndex = 69
        Me._Label_25.Text = "Tên DA"
        '
        '_Line_5
        '
        Me._Line_5.Enabled = False
        Me._Line_5.Location = New System.Drawing.Point(64, 35)
        Me._Line_5.Name = "_Line_5"
        Me._Line_5.Size = New System.Drawing.Size(224, 1)
        Me._Line_5.TabIndex = 70
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.Color.White
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_17.Location = New System.Drawing.Point(8, 40)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(55, 17)
        Me._Label_17.TabIndex = 68
        Me._Label_17.Text = "Nhóm DA"
        '
        '_Line_6
        '
        Me._Line_6.Enabled = False
        Me._Line_6.Location = New System.Drawing.Point(64, 59)
        Me._Line_6.Name = "_Line_6"
        Me._Line_6.Size = New System.Drawing.Size(24, 1)
        Me._Line_6.TabIndex = 71
        '
        '_Label_18
        '
        Me._Label_18.BackColor = System.Drawing.Color.White
        Me._Label_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_18.Location = New System.Drawing.Point(8, 64)
        Me._Label_18.Name = "_Label_18"
        Me._Label_18.Size = New System.Drawing.Size(55, 17)
        Me._Label_18.TabIndex = 67
        Me._Label_18.Text = "Địa điểm"
        '
        '_Line_7
        '
        Me._Line_7.Enabled = False
        Me._Line_7.Location = New System.Drawing.Point(64, 83)
        Me._Line_7.Name = "_Line_7"
        Me._Line_7.Size = New System.Drawing.Size(224, 1)
        Me._Line_7.TabIndex = 72
        '
        '_Label_19
        '
        Me._Label_19.BackColor = System.Drawing.Color.White
        Me._Label_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_19.Location = New System.Drawing.Point(128, 40)
        Me._Label_19.Name = "_Label_19"
        Me._Label_19.Size = New System.Drawing.Size(49, 17)
        Me._Label_19.TabIndex = 66
        Me._Label_19.Text = "Dự toán"
        '
        '_Line_8
        '
        Me._Line_8.Enabled = False
        Me._Line_8.Location = New System.Drawing.Point(176, 59)
        Me._Line_8.Name = "_Line_8"
        Me._Line_8.Size = New System.Drawing.Size(112, 1)
        Me._Line_8.TabIndex = 73
        '
        '_Label_20
        '
        Me._Label_20.BackColor = System.Drawing.Color.White
        Me._Label_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_20.Location = New System.Drawing.Point(8, 96)
        Me._Label_20.Name = "_Label_20"
        Me._Label_20.Size = New System.Drawing.Size(47, 17)
        Me._Label_20.TabIndex = 65
        Me._Label_20.Text = "Vốn NS"
        '
        '_Label_21
        '
        Me._Label_21.BackColor = System.Drawing.Color.White
        Me._Label_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_21.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_21.Location = New System.Drawing.Point(8, 120)
        Me._Label_21.Name = "_Label_21"
        Me._Label_21.Size = New System.Drawing.Size(47, 17)
        Me._Label_21.TabIndex = 64
        Me._Label_21.Text = "Vốn vay"
        '
        '_Label_22
        '
        Me._Label_22.BackColor = System.Drawing.Color.White
        Me._Label_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_22.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_22.Location = New System.Drawing.Point(8, 144)
        Me._Label_22.Name = "_Label_22"
        Me._Label_22.Size = New System.Drawing.Size(55, 17)
        Me._Label_22.TabIndex = 63
        Me._Label_22.Text = "Vốn khác"
        '
        '_Label_23
        '
        Me._Label_23.BackColor = System.Drawing.Color.White
        Me._Label_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_23.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_23.Location = New System.Drawing.Point(168, 120)
        Me._Label_23.Name = "_Label_23"
        Me._Label_23.Size = New System.Drawing.Size(51, 17)
        Me._Label_23.TabIndex = 62
        Me._Label_23.Text = "Ngày KC"
        '
        '_Label_24
        '
        Me._Label_24.BackColor = System.Drawing.Color.White
        Me._Label_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_24.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_24.Location = New System.Drawing.Point(168, 144)
        Me._Label_24.Name = "_Label_24"
        Me._Label_24.Size = New System.Drawing.Size(51, 17)
        Me._Label_24.TabIndex = 61
        Me._Label_24.Text = "Ngày HT"
        '
        '_Line_9
        '
        Me._Line_9.Enabled = False
        Me._Line_9.Location = New System.Drawing.Point(64, 115)
        Me._Line_9.Name = "_Line_9"
        Me._Line_9.Size = New System.Drawing.Size(96, 1)
        Me._Line_9.TabIndex = 74
        '
        '_Line_10
        '
        Me._Line_10.Enabled = False
        Me._Line_10.Location = New System.Drawing.Point(64, 139)
        Me._Line_10.Name = "_Line_10"
        Me._Line_10.Size = New System.Drawing.Size(96, 1)
        Me._Line_10.TabIndex = 75
        '
        '_Line_11
        '
        Me._Line_11.Enabled = False
        Me._Line_11.Location = New System.Drawing.Point(64, 163)
        Me._Line_11.Name = "_Line_11"
        Me._Line_11.Size = New System.Drawing.Size(96, 1)
        Me._Line_11.TabIndex = 76
        '
        '_txtDu_6
        '
        Me._txtDu_6.AcceptsReturn = True
        Me._txtDu_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtDu_6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtDu_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtDu_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtDu_6.ForeColor = System.Drawing.Color.Blue
        Me._txtDu_6.Location = New System.Drawing.Point(456, 352)
        Me._txtDu_6.MaxLength = 20
        Me._txtDu_6.Multiline = True
        Me._txtDu_6.Name = "_txtDu_6"
        Me._txtDu_6.Size = New System.Drawing.Size(105, 13)
        Me._txtDu_6.TabIndex = 16
        Me._txtDu_6.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._txtDu_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._txtDu_6.Visible = False
        '
        '_txt_3
        '
        Me._txt_3.AcceptsReturn = True
        Me._txt_3.BackColor = System.Drawing.SystemColors.Window
        Me._txt_3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txt_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_3.Location = New System.Drawing.Point(384, 68)
        Me._txt_3.MaxLength = 60
        Me._txt_3.Name = "_txt_3"
        Me._txt_3.Size = New System.Drawing.Size(249, 13)
        Me._txt_3.TabIndex = 5
        Me._txt_3.Visible = False
        '
        'CboNT
        '
        Me.CboNT.BackColor = System.Drawing.SystemColors.Window
        Me.CboNT.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboNT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboNT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboNT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboNT.Location = New System.Drawing.Point(336, 254)
        Me.CboNT.Name = "CboNT"
        Me.CboNT.Size = New System.Drawing.Size(57, 21)
        Me.CboNT.TabIndex = 11
        '
        '_Frame_0
        '
        Me._Frame_0.BackColor = System.Drawing.Color.Transparent
        Me._Frame_0.Controls.Add(Me._SSOpt_1)
        Me._Frame_0.Controls.Add(Me._SSOpt_0)
        Me._Frame_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame_0.Location = New System.Drawing.Point(8, 439)
        Me._Frame_0.Name = "_Frame_0"
        Me._Frame_0.Size = New System.Drawing.Size(177, 30)
        Me._Frame_0.TabIndex = 49
        Me._Frame_0.TabStop = False
        '
        '_SSOpt_1
        '
        Me._SSOpt_1.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_1.Location = New System.Drawing.Point(88, 8)
        Me._SSOpt_1.Name = "_SSOpt_1"
        Me._SSOpt_1.Size = New System.Drawing.Size(81, 17)
        Me._SSOpt_1.TabIndex = 32
        Me._SSOpt_1.TabStop = True
        Me._SSOpt_1.Tag = "Description"
        Me._SSOpt_1.Text = "Tên TK"
        Me._SSOpt_1.UseVisualStyleBackColor = False
        '
        '_SSOpt_0
        '
        Me._SSOpt_0.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_0.Checked = True
        Me._SSOpt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_0.Location = New System.Drawing.Point(8, 8)
        Me._SSOpt_0.Name = "_SSOpt_0"
        Me._SSOpt_0.Size = New System.Drawing.Size(73, 17)
        Me._SSOpt_0.TabIndex = 31
        Me._SSOpt_0.TabStop = True
        Me._SSOpt_0.Tag = "Code"
        Me._SSOpt_0.Text = "Số hiệu"
        Me._SSOpt_0.UseVisualStyleBackColor = False
        '
        '_txt_0
        '
        Me._txt_0.AcceptsReturn = True
        Me._txt_0.BackColor = System.Drawing.SystemColors.Window
        Me._txt_0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txt_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_0.Location = New System.Drawing.Point(384, 20)
        Me._txt_0.MaxLength = 20
        Me._txt_0.Name = "_txt_0"
        Me._txt_0.Size = New System.Drawing.Size(89, 13)
        Me._txt_0.TabIndex = 3
        '
        '_txt_1
        '
        Me._txt_1.AcceptsReturn = True
        Me._txt_1.BackColor = System.Drawing.SystemColors.Window
        Me._txt_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txt_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_1.Location = New System.Drawing.Point(384, 44)
        Me._txt_1.MaxLength = 60
        Me._txt_1.Name = "_txt_1"
        Me._txt_1.Size = New System.Drawing.Size(249, 13)
        Me._txt_1.TabIndex = 4
        '
        'OptNo
        '
        Me.OptNo.BackColor = System.Drawing.SystemColors.Window
        Me.OptNo.Checked = True
        Me.OptNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptNo.Location = New System.Drawing.Point(384, 96)
        Me.OptNo.Name = "OptNo"
        Me.OptNo.Size = New System.Drawing.Size(57, 17)
        Me.OptNo.TabIndex = 6
        Me.OptNo.TabStop = True
        Me.OptNo.Tag = "Debit"
        Me.OptNo.Text = "Nợ"
        Me.OptNo.UseVisualStyleBackColor = False
        '
        'OptCo
        '
        Me.OptCo.BackColor = System.Drawing.SystemColors.Window
        Me.OptCo.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptCo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptCo.Location = New System.Drawing.Point(448, 96)
        Me.OptCo.Name = "OptCo"
        Me.OptCo.Size = New System.Drawing.Size(49, 17)
        Me.OptCo.TabIndex = 7
        Me.OptCo.TabStop = True
        Me.OptCo.Tag = "Credit"
        Me.OptCo.Text = "Có"
        Me.OptCo.UseVisualStyleBackColor = False
        '
        'ChkBtc
        '
        Me.ChkBtc.BackColor = System.Drawing.SystemColors.Window
        Me.ChkBtc.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkBtc.Enabled = False
        Me.ChkBtc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBtc.Location = New System.Drawing.Point(504, 22)
        Me.ChkBtc.Name = "ChkBtc"
        Me.ChkBtc.Size = New System.Drawing.Size(129, 17)
        Me.ChkBtc.TabIndex = 3
        Me.ChkBtc.TabStop = False
        Me.ChkBtc.Tag = "Regulated by MF"
        Me.ChkBtc.Text = "Bộ tài chính quy định"
        Me.ChkBtc.UseVisualStyleBackColor = False
        '
        '_txtDu_0
        '
        Me._txtDu_0.AcceptsReturn = True
        Me._txtDu_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtDu_0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtDu_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtDu_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtDu_0.ForeColor = System.Drawing.Color.Blue
        Me._txtDu_0.Location = New System.Drawing.Point(424, 120)
        Me._txtDu_0.MaxLength = 15
        Me._txtDu_0.Multiline = True
        Me._txtDu_0.Name = "_txtDu_0"
        Me._txtDu_0.Size = New System.Drawing.Size(89, 19)
        Me._txtDu_0.TabIndex = 9
        Me._txtDu_0.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._txtDu_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtDu_1
        '
        Me._txtDu_1.AcceptsReturn = True
        Me._txtDu_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtDu_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtDu_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtDu_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtDu_1.ForeColor = System.Drawing.Color.Blue
        Me._txtDu_1.Location = New System.Drawing.Point(424, 144)
        Me._txtDu_1.MaxLength = 15
        Me._txtDu_1.Multiline = True
        Me._txtDu_1.Name = "_txtDu_1"
        Me._txtDu_1.Size = New System.Drawing.Size(89, 19)
        Me._txtDu_1.TabIndex = 10
        Me._txtDu_1.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._txtDu_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CmdNT
        '
        Me.CmdNT.BackColor = System.Drawing.SystemColors.Control
        Me.CmdNT.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdNT.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.CmdNT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdNT.Image = Global.UNET.My.Resources.Resources.up16
        Me.CmdNT.Location = New System.Drawing.Point(615, 255)
        Me.CmdNT.Name = "CmdNT"
        Me.CmdNT.Size = New System.Drawing.Size(18, 20)
        Me.CmdNT.TabIndex = 15
        Me.CmdNT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdNT.UseVisualStyleBackColor = False
        '
        'ChkDT
        '
        Me.ChkDT.BackColor = System.Drawing.SystemColors.Window
        Me.ChkDT.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkDT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDT.Location = New System.Drawing.Point(504, 96)
        Me.ChkDT.Name = "ChkDT"
        Me.ChkDT.Size = New System.Drawing.Size(113, 17)
        Me.ChkDT.TabIndex = 8
        Me.ChkDT.Tag = "Detailed"
        Me.ChkDT.Text = "Theo dõi chi tiết"
        Me.ChkDT.UseVisualStyleBackColor = False
        Me.ChkDT.Visible = False
        '
        '_txt_2
        '
        Me._txt_2.AcceptsReturn = True
        Me._txt_2.BackColor = System.Drawing.SystemColors.Window
        Me._txt_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txt_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txt_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txt_2.Location = New System.Drawing.Point(384, 384)
        Me._txt_2.MaxLength = 50
        Me._txt_2.Name = "_txt_2"
        Me._txt_2.Size = New System.Drawing.Size(249, 13)
        Me._txt_2.TabIndex = 17
        '
        'txtF
        '
        Me.txtF.AcceptsReturn = True
        Me.txtF.BackColor = System.Drawing.SystemColors.Window
        Me.txtF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF.Location = New System.Drawing.Point(186, 447)
        Me.txtF.MaxLength = 0
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(110, 20)
        Me.txtF.TabIndex = 33
        '
        'CboLoai
        '
        Me.CboLoai.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLoai.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLoai.ForeColor = System.Drawing.Color.Blue
        Me.CboLoai.Location = New System.Drawing.Point(8, 8)
        Me.CboLoai.Name = "CboLoai"
        Me.CboLoai.Size = New System.Drawing.Size(313, 21)
        Me.CboLoai.TabIndex = 0
        '
        '_Label_26
        '
        Me._Label_26.BackColor = System.Drawing.Color.White
        Me._Label_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_26.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_26.Location = New System.Drawing.Point(336, 352)
        Me._Label_26.Name = "_Label_26"
        Me._Label_26.Size = New System.Drawing.Size(121, 17)
        Me._Label_26.TabIndex = 72
        Me._Label_26.Text = "CP luỹ kế đến đầu năm"
        Me._Label_26.Visible = False
        '
        '_Line_12
        '
        Me._Line_12.Enabled = False
        Me._Line_12.Location = New System.Drawing.Point(456, 368)
        Me._Line_12.Name = "_Line_12"
        Me._Line_12.Size = New System.Drawing.Size(104, 1)
        Me._Line_12.TabIndex = 73
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(336, 192)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(49, 17)
        Me._Label_4.TabIndex = 40
        Me._Label_4.Tag = "Curr."
        Me._Label_4.Text = "Ng.tệ"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.Color.Black
        Me._Label_5.Location = New System.Drawing.Point(384, 192)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(81, 17)
        Me._Label_5.TabIndex = 39
        Me._Label_5.Tag = "Debit"
        Me._Label_5.Text = "Nợ"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Line1_5
        '
        Me._Line1_5.Enabled = False
        Me._Line1_5.Location = New System.Drawing.Point(384, 83)
        Me._Line1_5.Name = "_Line1_5"
        Me._Line1_5.Size = New System.Drawing.Size(248, 1)
        Me._Line1_5.TabIndex = 74
        Me._Line1_5.Visible = False
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.White
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_8.Location = New System.Drawing.Point(336, 70)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(42, 17)
        Me._Label_8.TabIndex = 50
        Me._Label_8.Text = "Desc."
        Me._Label_8.Visible = False
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.White
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(336, 22)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(52, 17)
        Me._Label_1.TabIndex = 48
        Me._Label_1.Tag = "Code"
        Me._Label_1.Text = "Số hiệu"
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.White
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(336, 46)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(50, 17)
        Me._Label_2.TabIndex = 47
        Me._Label_2.Tag = "Desc (V)"
        Me._Label_2.Text = "Tên"
        '
        '_Line1_0
        '
        Me._Line1_0.Enabled = False
        Me._Line1_0.Location = New System.Drawing.Point(384, 35)
        Me._Line1_0.Name = "_Line1_0"
        Me._Line1_0.Size = New System.Drawing.Size(88, 1)
        Me._Line1_0.TabIndex = 75
        '
        '_Line1_1
        '
        Me._Line1_1.Enabled = False
        Me._Line1_1.Location = New System.Drawing.Point(384, 59)
        Me._Line1_1.Name = "_Line1_1"
        Me._Line1_1.Size = New System.Drawing.Size(248, 1)
        Me._Line1_1.TabIndex = 76
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.White
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_3.Location = New System.Drawing.Point(336, 96)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(33, 17)
        Me._Label_3.TabIndex = 46
        Me._Label_3.Tag = "Type"
        Me._Label_3.Text = "Kiểu"
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(464, 192)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(81, 17)
        Me._Label_7.TabIndex = 45
        Me._Label_7.Tag = "Credit"
        Me._Label_7.Text = "Có"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.Color.Black
        Me._Label_0.Location = New System.Drawing.Point(544, 192)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(72, 17)
        Me._Label_0.TabIndex = 44
        Me._Label_0.Tag = "F. Currency"
        Me._Label_0.Text = "Lượng NT"
        Me._Label_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_9
        '
        Me._Label_9.BackColor = System.Drawing.Color.White
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_9.Location = New System.Drawing.Point(336, 128)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.Size = New System.Drawing.Size(81, 17)
        Me._Label_9.TabIndex = 43
        Me._Label_9.Tag = "Min Balance"
        Me._Label_9.Text = "Số dư tối thiểu"
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.White
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_10.Location = New System.Drawing.Point(336, 152)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(81, 17)
        Me._Label_10.TabIndex = 42
        Me._Label_10.Tag = "Max Balance"
        Me._Label_10.Text = "Số dư tối đa"
        '
        '_Line1_2
        '
        Me._Line1_2.Enabled = False
        Me._Line1_2.Location = New System.Drawing.Point(424, 139)
        Me._Line1_2.Name = "_Line1_2"
        Me._Line1_2.Size = New System.Drawing.Size(88, 1)
        Me._Line1_2.TabIndex = 77
        '
        '_Line1_3
        '
        Me._Line1_3.Enabled = False
        Me._Line1_3.Location = New System.Drawing.Point(424, 163)
        Me._Line1_3.Name = "_Line1_3"
        Me._Line1_3.Size = New System.Drawing.Size(88, 1)
        Me._Line1_3.TabIndex = 78
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.White
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_6.Location = New System.Drawing.Point(336, 176)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(89, 17)
        Me._Label_6.TabIndex = 41
        Me._Label_6.Tag = "Opening Balance"
        Me._Label_6.Text = "Số dư đầu kỳ"
        '
        '_Label_16
        '
        Me._Label_16.BackColor = System.Drawing.Color.White
        Me._Label_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_16.Location = New System.Drawing.Point(336, 280)
        Me._Label_16.Name = "_Label_16"
        Me._Label_16.Size = New System.Drawing.Size(105, 17)
        Me._Label_16.TabIndex = 38
        Me._Label_16.Tag = "Closing Balance"
        Me._Label_16.Text = "Số dư hiện thời"
        '
        '_Label_14
        '
        Me._Label_14.AutoSize = True
        Me._Label_14.BackColor = System.Drawing.Color.White
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_14.Location = New System.Drawing.Point(336, 384)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(44, 14)
        Me._Label_14.TabIndex = 37
        Me._Label_14.Tag = "Notes"
        Me._Label_14.Text = "Ghi chú"
        '
        '_Line1_4
        '
        Me._Line1_4.Enabled = False
        Me._Line1_4.Location = New System.Drawing.Point(384, 411)
        Me._Line1_4.Name = "_Line1_4"
        Me._Line1_4.Size = New System.Drawing.Size(248, 1)
        Me._Line1_4.TabIndex = 79
        '
        '_Label_15
        '
        Me._Label_15.BackColor = System.Drawing.SystemColors.Window
        Me._Label_15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_15.Location = New System.Drawing.Point(327, 8)
        Me._Label_15.Name = "_Label_15"
        Me._Label_15.Size = New System.Drawing.Size(322, 425)
        Me._Label_15.TabIndex = 34
        '
        'trvHTTK
        '
        Me.trvHTTK.FullRowSelect = True
        Me.trvHTTK.HideSelection = False
        Me.trvHTTK.ImageIndex = 0
        Me.trvHTTK.ImageList = Me.ImageList_HTTK
        Me.trvHTTK.Location = New System.Drawing.Point(8, 27)
        Me.trvHTTK.Name = "trvHTTK"
        Me.trvHTTK.SelectedImageIndex = 1
        Me.trvHTTK.ShowNodeToolTips = True
        Me.trvHTTK.Size = New System.Drawing.Size(313, 406)
        Me.trvHTTK.TabIndex = 1
        '
        'ImageList_HTTK
        '
        Me.ImageList_HTTK.ImageStream = CType(resources.GetObject("ImageList_HTTK.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_HTTK.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_HTTK.Images.SetKeyName(0, "icons8-folder-16.png")
        Me.ImageList_HTTK.Images.SetKeyName(1, "icons8-open-16.png")
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
        Me._GrdNT_0.GridLines = ListViewEx.GLGridLines.gridBoth
        Me._GrdNT_0.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me._GrdNT_0.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me._GrdNT_0.HeaderHeight = 22
        Me._GrdNT_0.HeaderVisible = True
        Me._GrdNT_0.HeaderWordWrap = False
        Me._GrdNT_0.HotColumnTracking = False
        Me._GrdNT_0.HotItemTracking = False
        Me._GrdNT_0.HotTrackingColor = System.Drawing.Color.LightGray
        Me._GrdNT_0.HoverEvents = False
        Me._GrdNT_0.HoverTime = 1
        Me._GrdNT_0.ImageList = Nothing
        Me._GrdNT_0.ItemHeight = 18
        Me._GrdNT_0.ItemWordWrap = False
        Me._GrdNT_0.Location = New System.Drawing.Point(336, 208)
        Me._GrdNT_0.Name = "_GrdNT_0"
        Me._GrdNT_0.Row = 0
        Me._GrdNT_0.Rows = 0
        Me._GrdNT_0.Selectable = True
        Me._GrdNT_0.SelectedTextColor = System.Drawing.Color.White
        Me._GrdNT_0.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me._GrdNT_0.ShowBorder = True
        Me._GrdNT_0.ShowFocusRect = False
        Me._GrdNT_0.Size = New System.Drawing.Size(297, 49)
        Me._GrdNT_0.SortType = ListViewEx.SortTypes.InsertionSort
        Me._GrdNT_0.SuperFlatHeaderColor = System.Drawing.Color.White
        Me._GrdNT_0.TabIndex = 10
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
        Me._GrdNT_1.GridLines = ListViewEx.GLGridLines.gridBoth
        Me._GrdNT_1.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me._GrdNT_1.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me._GrdNT_1.HeaderHeight = 22
        Me._GrdNT_1.HeaderVisible = True
        Me._GrdNT_1.HeaderWordWrap = False
        Me._GrdNT_1.HotColumnTracking = False
        Me._GrdNT_1.HotItemTracking = False
        Me._GrdNT_1.HotTrackingColor = System.Drawing.Color.LightGray
        Me._GrdNT_1.HoverEvents = False
        Me._GrdNT_1.HoverTime = 1
        Me._GrdNT_1.ImageList = Nothing
        Me._GrdNT_1.ItemHeight = 18
        Me._GrdNT_1.ItemWordWrap = False
        Me._GrdNT_1.Location = New System.Drawing.Point(334, 300)
        Me._GrdNT_1.Name = "_GrdNT_1"
        Me._GrdNT_1.Row = 0
        Me._GrdNT_1.Rows = 0
        Me._GrdNT_1.Selectable = True
        Me._GrdNT_1.SelectedTextColor = System.Drawing.Color.White
        Me._GrdNT_1.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me._GrdNT_1.ShowBorder = True
        Me._GrdNT_1.ShowFocusRect = False
        Me._GrdNT_1.Size = New System.Drawing.Size(297, 58)
        Me._GrdNT_1.SortType = ListViewEx.SortTypes.InsertionSort
        Me._GrdNT_1.SuperFlatHeaderColor = System.Drawing.Color.White
        Me._GrdNT_1.TabIndex = 10
        '
        '_txtDuNT_0
        '
        Me._txtDuNT_0.AcceptsReturn = True
        Me._txtDuNT_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtDuNT_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtDuNT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtDuNT_0.Location = New System.Drawing.Point(392, 256)
        Me._txtDuNT_0.MaxLength = 0
        Me._txtDuNT_0.Multiline = True
        Me._txtDuNT_0.Name = "_txtDuNT_0"
        Me._txtDuNT_0.Size = New System.Drawing.Size(72, 19)
        Me._txtDuNT_0.TabIndex = 80
        Me._txtDuNT_0.Text = "0"
        Me._txtDuNT_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtDuNT_1
        '
        Me._txtDuNT_1.AcceptsReturn = True
        Me._txtDuNT_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtDuNT_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtDuNT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtDuNT_1.Location = New System.Drawing.Point(463, 256)
        Me._txtDuNT_1.MaxLength = 0
        Me._txtDuNT_1.Multiline = True
        Me._txtDuNT_1.Name = "_txtDuNT_1"
        Me._txtDuNT_1.Size = New System.Drawing.Size(79, 19)
        Me._txtDuNT_1.TabIndex = 81
        Me._txtDuNT_1.Text = "0"
        Me._txtDuNT_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtDuNT_2
        '
        Me._txtDuNT_2.AcceptsReturn = True
        Me._txtDuNT_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtDuNT_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtDuNT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtDuNT_2.Location = New System.Drawing.Point(541, 256)
        Me._txtDuNT_2.MaxLength = 0
        Me._txtDuNT_2.Multiline = True
        Me._txtDuNT_2.Name = "_txtDuNT_2"
        Me._txtDuNT_2.Size = New System.Drawing.Size(74, 19)
        Me._txtDuNT_2.TabIndex = 82
        Me._txtDuNT_2.Text = "0"
        Me._txtDuNT_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmTaikhoan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(657, 472)
        Me.Controls.Add(Me._txtDuNT_2)
        Me.Controls.Add(Me._txtDuNT_1)
        Me.Controls.Add(Me._txtDuNT_0)
        Me.Controls.Add(Me.trvHTTK)
        Me.Controls.Add(Me._GrdNT_0)
        Me.Controls.Add(Me._GrdNT_1)
        Me.Controls.Add(Me._Command_5)
        Me.Controls.Add(Me._Command_4)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._txtDu_6)
        Me.Controls.Add(Me._txt_3)
        Me.Controls.Add(Me.CboNT)
        Me.Controls.Add(Me._Frame_0)
        Me.Controls.Add(Me._txt_0)
        Me.Controls.Add(Me._txt_1)
        Me.Controls.Add(Me.OptNo)
        Me.Controls.Add(Me.OptCo)
        Me.Controls.Add(Me.ChkBtc)
        Me.Controls.Add(Me._txtDu_0)
        Me.Controls.Add(Me._txtDu_1)
        Me.Controls.Add(Me.CmdNT)
        Me.Controls.Add(Me.ChkDT)
        Me.Controls.Add(Me._txt_2)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me.CboLoai)
        Me.Controls.Add(Me._Label_26)
        Me.Controls.Add(Me._Line_12)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_5)
        Me.Controls.Add(Me._Line1_5)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Line1_0)
        Me.Controls.Add(Me._Line1_1)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_9)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Line1_2)
        Me.Controls.Add(Me._Line1_3)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_16)
        Me.Controls.Add(Me._Label_14)
        Me.Controls.Add(Me._Line1_4)
        Me.Controls.Add(Me._Frame_1)
        Me.Controls.Add(Me._Label_15)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(6, 31)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTaikhoan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Hệ thống tài khoản"
        Me._Frame_1.ResumeLayout(False)
        Me._Frame_1.PerformLayout()
        Me._Frame_0.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Sub InitializetxtDuNT()
        Me.txtDuNT(0) = _txtDuNT_0
        Me.txtDuNT(1) = _txtDuNT_1
        Me.txtDuNT(2) = _txtDuNT_2
    End Sub
    Sub InitializetxtDu()
        Me.txtDu(2) = _txtDu_2
        Me.txtDu(3) = _txtDu_3
        Me.txtDu(4) = _txtDu_4
        Me.txtDu(5) = _txtDu_5
        Me.txtDu(6) = _txtDu_6
        Me.txtDu(0) = _txtDu_0
        Me.txtDu(1) = _txtDu_1
    End Sub
    Sub Initializetxt()
        Me.txt(6) = _txt_6
        Me.txt(4) = _txt_4
        Me.txt(5) = _txt_5
        Me.txt(3) = _txt_3
        Me.txt(0) = _txt_0
        Me.txt(1) = _txt_1
        Me.txt(2) = _txt_2
    End Sub
    Sub InitializeSSOpt()
        Me.SSOpt(1) = _SSOpt_1
        Me.SSOpt(0) = _SSOpt_0
    End Sub
    Sub InitializeMedNgay()
        Me.MedNgay(0) = _MedNgay_0
        Me.MedNgay(1) = _MedNgay_1
    End Sub
    Sub InitializeLine1()
        Me.Line1(5) = _Line1_5
        Me.Line1(0) = _Line1_0
        Me.Line1(1) = _Line1_1
        Me.Line1(2) = _Line1_2
        Me.Line1(3) = _Line1_3
        Me.Line1(4) = _Line1_4
    End Sub
    Sub InitializeLine()
        Me.Line(5) = _Line_5
        Me.Line(6) = _Line_6
        Me.Line(7) = _Line_7
        Me.Line(8) = _Line_8
        Me.Line(9) = _Line_9
        Me.Line(10) = _Line_10
        Me.Line(11) = _Line_11
        Me.Line(12) = _Line_12
    End Sub
    Sub InitializeLabel()
        Me.Label(25) = _Label_25
        Me.Label(17) = _Label_17
        Me.Label(18) = _Label_18
        Me.Label(19) = _Label_19
        Me.Label(20) = _Label_20
        Me.Label(21) = _Label_21
        Me.Label(22) = _Label_22
        Me.Label(23) = _Label_23
        Me.Label(24) = _Label_24
        Me.Label(26) = _Label_26
        Me.Label(4) = _Label_4
        Me.Label(5) = _Label_5
        Me.Label(8) = _Label_8
        Me.Label(1) = _Label_1
        Me.Label(2) = _Label_2
        Me.Label(3) = _Label_3
        Me.Label(7) = _Label_7
        Me.Label(0) = _Label_0
        Me.Label(9) = _Label_9
        Me.Label(10) = _Label_10
        Me.Label(6) = _Label_6
        Me.Label(16) = _Label_16
        Me.Label(14) = _Label_14
        Me.Label(15) = _Label_15
        'Me.Label(12) = _Label_12
        'Me.Label(11) = _Label_11
        'Me.Label(13) = _Label_13
    End Sub
    Sub InitializeGrdNT()
        Me.GrdNT(0) = _GrdNT_0
        Me.GrdNT(1) = _GrdNT_1
    End Sub
    Sub InitializeFrame()
        Me.Frame(1) = _Frame_1
        Me.Frame(0) = _Frame_0
    End Sub
    Sub InitializeCommand()
        Me.Command(5) = _Command_5
        Me.Command(4) = _Command_4
        Me.Command(2) = _Command_2
        Me.Command(3) = _Command_3
        Me.Command(1) = _Command_1
        Me.Command(0) = _Command_0
    End Sub
    Friend WithEvents trvHTTK As System.Windows.Forms.TreeView
    Private WithEvents _txtDuNT_0 As System.Windows.Forms.TextBox
    Private WithEvents _txtDuNT_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtDuNT_2 As System.Windows.Forms.TextBox
    Friend WithEvents ImageList_HTTK As System.Windows.Forms.ImageList
#End Region 
End Class
