<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChucvu
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializetxtVT()
		InitializeSSOpt()
		InitializeLine()
		InitializeLabel()
		InitializeFrame2()
		InitializeCommand()
		InitializeChkLoai()
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
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _ChkLoai_4 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkLoai_3 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkLoai_2 As System.Windows.Forms.CheckBox
    Private WithEvents _ChkLoai_1 As System.Windows.Forms.CheckBox
    Private WithEvents _txtVT_17 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_18 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_19 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_20 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_21 As System.Windows.Forms.TextBox
    Private WithEvents _Line_17 As System.Windows.Forms.Label
    Private WithEvents _Line_18 As System.Windows.Forms.Label
    Private WithEvents _Line_19 As System.Windows.Forms.Label
    Private WithEvents _Line_20 As System.Windows.Forms.Label
    Private WithEvents _Line_21 As System.Windows.Forms.Label
    Private WithEvents _Frame2_4 As System.Windows.Forms.Panel
    Private WithEvents _txtVT_12 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_13 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_14 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_15 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_16 As System.Windows.Forms.TextBox
    Private WithEvents _Line_16 As System.Windows.Forms.Label
    Private WithEvents _Line_15 As System.Windows.Forms.Label
    Private WithEvents _Line_14 As System.Windows.Forms.Label
    Private WithEvents _Line_13 As System.Windows.Forms.Label
    Private WithEvents _Line_12 As System.Windows.Forms.Label
    Private WithEvents _Frame2_3 As System.Windows.Forms.Panel
    Private WithEvents _txtVT_11 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_10 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_9 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_8 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_7 As System.Windows.Forms.TextBox
    Private WithEvents _Line_7 As System.Windows.Forms.Label
    Private WithEvents _Line_8 As System.Windows.Forms.Label
    Private WithEvents _Line_9 As System.Windows.Forms.Label
    Private WithEvents _Line_10 As System.Windows.Forms.Label
    Private WithEvents _Line_11 As System.Windows.Forms.Label
    Private WithEvents _Frame2_2 As System.Windows.Forms.Panel
    Private WithEvents _txtVT_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_3 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_4 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_5 As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_6 As System.Windows.Forms.TextBox
    Private WithEvents _Line_1 As System.Windows.Forms.Label
    Private WithEvents _Line_3 As System.Windows.Forms.Label
    Private WithEvents _Line_4 As System.Windows.Forms.Label
    Private WithEvents _Line_5 As System.Windows.Forms.Label
    Private WithEvents _Line_6 As System.Windows.Forms.Label
    Private WithEvents _Frame2_1 As System.Windows.Forms.Panel
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Private WithEvents _txtVT_1 As System.Windows.Forms.TextBox
    Public WithEvents txtF As System.Windows.Forms.TextBox
    Private WithEvents _txtVT_0 As System.Windows.Forms.TextBox
    Private WithEvents _SSOpt_1 As System.Windows.Forms.RadioButton
    Private WithEvents _SSOpt_0 As System.Windows.Forms.RadioButton
    Public WithEvents LstVt As System.Windows.Forms.ListBox
    Private WithEvents _Line_2 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Line_0 As System.Windows.Forms.Label
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Public ChkLoai(4) As System.Windows.Forms.CheckBox
    Public Command(3) As System.Windows.Forms.Button
    Public Command1(3) As System.Windows.Forms.Button
    Public Frame2(4) As System.Windows.Forms.Panel
    Public Label(17) As System.Windows.Forms.Label
    Public Line(21) As System.Windows.Forms.Label
    Public SSOpt(1) As System.Windows.Forms.RadioButton
    Public txtVT(21) As System.Windows.Forms.TextBox
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
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me._ChkLoai_4 = New System.Windows.Forms.CheckBox
        Me._ChkLoai_3 = New System.Windows.Forms.CheckBox
        Me._ChkLoai_2 = New System.Windows.Forms.CheckBox
        Me._ChkLoai_1 = New System.Windows.Forms.CheckBox
        Me._Frame2_4 = New System.Windows.Forms.Panel
        Me._txtVT_17 = New System.Windows.Forms.TextBox
        Me._txtVT_18 = New System.Windows.Forms.TextBox
        Me._txtVT_19 = New System.Windows.Forms.TextBox
        Me._txtVT_20 = New System.Windows.Forms.TextBox
        Me._txtVT_21 = New System.Windows.Forms.TextBox
        Me._Line_17 = New System.Windows.Forms.Label
        Me._Line_18 = New System.Windows.Forms.Label
        Me._Line_19 = New System.Windows.Forms.Label
        Me._Line_20 = New System.Windows.Forms.Label
        Me._Line_21 = New System.Windows.Forms.Label
        Me._Frame2_3 = New System.Windows.Forms.Panel
        Me._txtVT_12 = New System.Windows.Forms.TextBox
        Me._txtVT_13 = New System.Windows.Forms.TextBox
        Me._txtVT_14 = New System.Windows.Forms.TextBox
        Me._txtVT_15 = New System.Windows.Forms.TextBox
        Me._txtVT_16 = New System.Windows.Forms.TextBox
        Me._Line_16 = New System.Windows.Forms.Label
        Me._Line_15 = New System.Windows.Forms.Label
        Me._Line_14 = New System.Windows.Forms.Label
        Me._Line_13 = New System.Windows.Forms.Label
        Me._Line_12 = New System.Windows.Forms.Label
        Me._Frame2_2 = New System.Windows.Forms.Panel
        Me._txtVT_11 = New System.Windows.Forms.TextBox
        Me._txtVT_10 = New System.Windows.Forms.TextBox
        Me._txtVT_9 = New System.Windows.Forms.TextBox
        Me._txtVT_8 = New System.Windows.Forms.TextBox
        Me._txtVT_7 = New System.Windows.Forms.TextBox
        Me._Line_7 = New System.Windows.Forms.Label
        Me._Line_8 = New System.Windows.Forms.Label
        Me._Line_9 = New System.Windows.Forms.Label
        Me._Line_10 = New System.Windows.Forms.Label
        Me._Line_11 = New System.Windows.Forms.Label
        Me._Frame2_1 = New System.Windows.Forms.Panel
        Me._txtVT_2 = New System.Windows.Forms.TextBox
        Me._txtVT_3 = New System.Windows.Forms.TextBox
        Me._txtVT_4 = New System.Windows.Forms.TextBox
        Me._txtVT_5 = New System.Windows.Forms.TextBox
        Me._txtVT_6 = New System.Windows.Forms.TextBox
        Me._Line_1 = New System.Windows.Forms.Label
        Me._Line_3 = New System.Windows.Forms.Label
        Me._Line_4 = New System.Windows.Forms.Label
        Me._Line_5 = New System.Windows.Forms.Label
        Me._Line_6 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._txtVT_1 = New System.Windows.Forms.TextBox
        Me.txtF = New System.Windows.Forms.TextBox
        Me._txtVT_0 = New System.Windows.Forms.TextBox
        Me._SSOpt_1 = New System.Windows.Forms.RadioButton
        Me._SSOpt_0 = New System.Windows.Forms.RadioButton
        Me.LstVt = New System.Windows.Forms.ListBox
        Me._Line_2 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Line_0 = New System.Windows.Forms.Label
        Me._Label_17 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Frame1.SuspendLayout()
        Me._Frame2_4.SuspendLayout()
        Me._Frame2_3.SuspendLayout()
        Me._Frame2_2.SuspendLayout()
        Me._Frame2_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SSCmdF
        '
        Me.SSCmdF.Image = Global.UNET.My.Resources.Resources.search3_16
        Me.SSCmdF.Location = New System.Drawing.Point(295, 446)
        Me.SSCmdF.Name = "SSCmdF"
        Me.SSCmdF.Size = New System.Drawing.Size(20, 20)
        Me.SSCmdF.TabIndex = 34
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(576, 443)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 26)
        Me._Command_3.TabIndex = 55
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(498, 443)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 26)
        Me._Command_2.TabIndex = 54
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(419, 443)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 26)
        Me._Command_1.TabIndex = 53
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.add16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(340, 443)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 26)
        Me._Command_0.TabIndex = 52
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Window
        Me.Frame1.Controls.Add(Me._ChkLoai_4)
        Me.Frame1.Controls.Add(Me._ChkLoai_3)
        Me.Frame1.Controls.Add(Me._ChkLoai_2)
        Me.Frame1.Controls.Add(Me._ChkLoai_1)
        Me.Frame1.Controls.Add(Me._Frame2_4)
        Me.Frame1.Controls.Add(Me._Frame2_3)
        Me.Frame1.Controls.Add(Me._Frame2_2)
        Me.Frame1.Controls.Add(Me._Frame2_1)
        Me.Frame1.Controls.Add(Me._Label_8)
        Me.Frame1.Controls.Add(Me._Label_7)
        Me.Frame1.Controls.Add(Me._Label_6)
        Me.Frame1.Controls.Add(Me._Label_3)
        Me.Frame1.Controls.Add(Me._Label_2)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(216, 80)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(417, 337)
        Me.Frame1.TabIndex = 42
        Me.Frame1.TabStop = False
        Me.Frame1.Tag = "Salary"
        Me.Frame1.Text = "Tiền lương "
        '
        '_ChkLoai_4
        '
        Me._ChkLoai_4.BackColor = System.Drawing.Color.White
        Me._ChkLoai_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkLoai_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkLoai_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkLoai_4.Location = New System.Drawing.Point(320, 21)
        Me._ChkLoai_4.Name = "_ChkLoai_4"
        Me._ChkLoai_4.Size = New System.Drawing.Size(77, 17)
        Me._ChkLoai_4.TabIndex = 21
        Me._ChkLoai_4.Tag = "Day"
        Me._ChkLoai_4.Text = "Ngày"
        Me._ChkLoai_4.UseVisualStyleBackColor = False
        '
        '_ChkLoai_3
        '
        Me._ChkLoai_3.BackColor = System.Drawing.Color.White
        Me._ChkLoai_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkLoai_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkLoai_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkLoai_3.Location = New System.Drawing.Point(232, 21)
        Me._ChkLoai_3.Name = "_ChkLoai_3"
        Me._ChkLoai_3.Size = New System.Drawing.Size(79, 17)
        Me._ChkLoai_3.TabIndex = 15
        Me._ChkLoai_3.Tag = "Seasonal"
        Me._ChkLoai_3.Text = "Thời Vụ"
        Me._ChkLoai_3.UseVisualStyleBackColor = False
        '
        '_ChkLoai_2
        '
        Me._ChkLoai_2.BackColor = System.Drawing.Color.White
        Me._ChkLoai_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkLoai_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkLoai_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkLoai_2.Location = New System.Drawing.Point(145, 21)
        Me._ChkLoai_2.Name = "_ChkLoai_2"
        Me._ChkLoai_2.Size = New System.Drawing.Size(79, 17)
        Me._ChkLoai_2.TabIndex = 9
        Me._ChkLoai_2.Tag = "Month"
        Me._ChkLoai_2.Text = "Tháng"
        Me._ChkLoai_2.UseVisualStyleBackColor = False
        '
        '_ChkLoai_1
        '
        Me._ChkLoai_1.BackColor = System.Drawing.Color.White
        Me._ChkLoai_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._ChkLoai_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ChkLoai_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._ChkLoai_1.Location = New System.Drawing.Point(52, 21)
        Me._ChkLoai_1.Name = "_ChkLoai_1"
        Me._ChkLoai_1.Size = New System.Drawing.Size(89, 17)
        Me._ChkLoai_1.TabIndex = 3
        Me._ChkLoai_1.Tag = "Coefficient"
        Me._ChkLoai_1.Text = "Hệ Số"
        Me._ChkLoai_1.UseVisualStyleBackColor = False
        '
        '_Frame2_4
        '
        Me._Frame2_4.BackColor = System.Drawing.SystemColors.Window
        Me._Frame2_4.Controls.Add(Me._txtVT_17)
        Me._Frame2_4.Controls.Add(Me._txtVT_18)
        Me._Frame2_4.Controls.Add(Me._txtVT_19)
        Me._Frame2_4.Controls.Add(Me._txtVT_20)
        Me._Frame2_4.Controls.Add(Me._txtVT_21)
        Me._Frame2_4.Controls.Add(Me._Line_17)
        Me._Frame2_4.Controls.Add(Me._Line_18)
        Me._Frame2_4.Controls.Add(Me._Line_19)
        Me._Frame2_4.Controls.Add(Me._Line_20)
        Me._Frame2_4.Controls.Add(Me._Line_21)
        Me._Frame2_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Frame2_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame2_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame2_4.Location = New System.Drawing.Point(316, 32)
        Me._Frame2_4.Name = "_Frame2_4"
        Me._Frame2_4.Size = New System.Drawing.Size(89, 129)
        Me._Frame2_4.TabIndex = 51
        '
        '_txtVT_17
        '
        Me._txtVT_17.AcceptsReturn = True
        Me._txtVT_17.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_17.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_17.Location = New System.Drawing.Point(8, 8)
        Me._txtVT_17.MaxLength = 20
        Me._txtVT_17.Name = "_txtVT_17"
        Me._txtVT_17.Size = New System.Drawing.Size(73, 13)
        Me._txtVT_17.TabIndex = 22
        Me._txtVT_17.Text = "..."
        Me._txtVT_17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_18
        '
        Me._txtVT_18.AcceptsReturn = True
        Me._txtVT_18.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_18.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_18.Location = New System.Drawing.Point(8, 32)
        Me._txtVT_18.MaxLength = 20
        Me._txtVT_18.Name = "_txtVT_18"
        Me._txtVT_18.Size = New System.Drawing.Size(73, 13)
        Me._txtVT_18.TabIndex = 23
        Me._txtVT_18.Text = "..."
        Me._txtVT_18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_19
        '
        Me._txtVT_19.AcceptsReturn = True
        Me._txtVT_19.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_19.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_19.Location = New System.Drawing.Point(8, 56)
        Me._txtVT_19.MaxLength = 20
        Me._txtVT_19.Name = "_txtVT_19"
        Me._txtVT_19.Size = New System.Drawing.Size(73, 13)
        Me._txtVT_19.TabIndex = 24
        Me._txtVT_19.Text = "..."
        Me._txtVT_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_20
        '
        Me._txtVT_20.AcceptsReturn = True
        Me._txtVT_20.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_20.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_20.Location = New System.Drawing.Point(8, 80)
        Me._txtVT_20.MaxLength = 20
        Me._txtVT_20.Name = "_txtVT_20"
        Me._txtVT_20.Size = New System.Drawing.Size(73, 13)
        Me._txtVT_20.TabIndex = 25
        Me._txtVT_20.Text = "..."
        Me._txtVT_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_21
        '
        Me._txtVT_21.AcceptsReturn = True
        Me._txtVT_21.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_21.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_21.Location = New System.Drawing.Point(8, 104)
        Me._txtVT_21.MaxLength = 20
        Me._txtVT_21.Name = "_txtVT_21"
        Me._txtVT_21.Size = New System.Drawing.Size(73, 13)
        Me._txtVT_21.TabIndex = 26
        Me._txtVT_21.Text = "..."
        Me._txtVT_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Line_17
        '
        Me._Line_17.Enabled = False
        Me._Line_17.Location = New System.Drawing.Point(4, 13)
        Me._Line_17.Name = "_Line_17"
        Me._Line_17.Size = New System.Drawing.Size(35, 1)
        Me._Line_17.TabIndex = 27
        '
        '_Line_18
        '
        Me._Line_18.Enabled = False
        Me._Line_18.Location = New System.Drawing.Point(4, 23)
        Me._Line_18.Name = "_Line_18"
        Me._Line_18.Size = New System.Drawing.Size(35, 1)
        Me._Line_18.TabIndex = 28
        '
        '_Line_19
        '
        Me._Line_19.Enabled = False
        Me._Line_19.Location = New System.Drawing.Point(4, 34)
        Me._Line_19.Name = "_Line_19"
        Me._Line_19.Size = New System.Drawing.Size(35, 1)
        Me._Line_19.TabIndex = 29
        '
        '_Line_20
        '
        Me._Line_20.Enabled = False
        Me._Line_20.Location = New System.Drawing.Point(9, 45)
        Me._Line_20.Name = "_Line_20"
        Me._Line_20.Size = New System.Drawing.Size(35, 1)
        Me._Line_20.TabIndex = 30
        '
        '_Line_21
        '
        Me._Line_21.Enabled = False
        Me._Line_21.Location = New System.Drawing.Point(4, 56)
        Me._Line_21.Name = "_Line_21"
        Me._Line_21.Size = New System.Drawing.Size(35, 1)
        Me._Line_21.TabIndex = 31
        '
        '_Frame2_3
        '
        Me._Frame2_3.BackColor = System.Drawing.SystemColors.Window
        Me._Frame2_3.Controls.Add(Me._txtVT_12)
        Me._Frame2_3.Controls.Add(Me._txtVT_13)
        Me._Frame2_3.Controls.Add(Me._txtVT_14)
        Me._Frame2_3.Controls.Add(Me._txtVT_15)
        Me._Frame2_3.Controls.Add(Me._txtVT_16)
        Me._Frame2_3.Controls.Add(Me._Line_16)
        Me._Frame2_3.Controls.Add(Me._Line_15)
        Me._Frame2_3.Controls.Add(Me._Line_14)
        Me._Frame2_3.Controls.Add(Me._Line_13)
        Me._Frame2_3.Controls.Add(Me._Line_12)
        Me._Frame2_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Frame2_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame2_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame2_3.Location = New System.Drawing.Point(228, 32)
        Me._Frame2_3.Name = "_Frame2_3"
        Me._Frame2_3.Size = New System.Drawing.Size(89, 129)
        Me._Frame2_3.TabIndex = 50
        '
        '_txtVT_12
        '
        Me._txtVT_12.AcceptsReturn = True
        Me._txtVT_12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_12.Location = New System.Drawing.Point(8, 8)
        Me._txtVT_12.MaxLength = 20
        Me._txtVT_12.Name = "_txtVT_12"
        Me._txtVT_12.Size = New System.Drawing.Size(73, 13)
        Me._txtVT_12.TabIndex = 16
        Me._txtVT_12.Text = "..."
        Me._txtVT_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_13
        '
        Me._txtVT_13.AcceptsReturn = True
        Me._txtVT_13.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_13.Location = New System.Drawing.Point(8, 32)
        Me._txtVT_13.MaxLength = 20
        Me._txtVT_13.Name = "_txtVT_13"
        Me._txtVT_13.Size = New System.Drawing.Size(73, 13)
        Me._txtVT_13.TabIndex = 17
        Me._txtVT_13.Text = "..."
        Me._txtVT_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_14
        '
        Me._txtVT_14.AcceptsReturn = True
        Me._txtVT_14.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_14.Location = New System.Drawing.Point(8, 56)
        Me._txtVT_14.MaxLength = 20
        Me._txtVT_14.Name = "_txtVT_14"
        Me._txtVT_14.Size = New System.Drawing.Size(73, 13)
        Me._txtVT_14.TabIndex = 18
        Me._txtVT_14.Text = "..."
        Me._txtVT_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_15
        '
        Me._txtVT_15.AcceptsReturn = True
        Me._txtVT_15.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_15.Location = New System.Drawing.Point(8, 80)
        Me._txtVT_15.MaxLength = 20
        Me._txtVT_15.Name = "_txtVT_15"
        Me._txtVT_15.Size = New System.Drawing.Size(73, 13)
        Me._txtVT_15.TabIndex = 19
        Me._txtVT_15.Text = "..."
        Me._txtVT_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_16
        '
        Me._txtVT_16.AcceptsReturn = True
        Me._txtVT_16.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_16.Location = New System.Drawing.Point(8, 104)
        Me._txtVT_16.MaxLength = 20
        Me._txtVT_16.Name = "_txtVT_16"
        Me._txtVT_16.Size = New System.Drawing.Size(73, 13)
        Me._txtVT_16.TabIndex = 20
        Me._txtVT_16.Text = "..."
        Me._txtVT_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Line_16
        '
        Me._Line_16.Enabled = False
        Me._Line_16.Location = New System.Drawing.Point(4, 13)
        Me._Line_16.Name = "_Line_16"
        Me._Line_16.Size = New System.Drawing.Size(35, 1)
        Me._Line_16.TabIndex = 21
        '
        '_Line_15
        '
        Me._Line_15.Enabled = False
        Me._Line_15.Location = New System.Drawing.Point(4, 23)
        Me._Line_15.Name = "_Line_15"
        Me._Line_15.Size = New System.Drawing.Size(35, 1)
        Me._Line_15.TabIndex = 22
        '
        '_Line_14
        '
        Me._Line_14.Enabled = False
        Me._Line_14.Location = New System.Drawing.Point(4, 34)
        Me._Line_14.Name = "_Line_14"
        Me._Line_14.Size = New System.Drawing.Size(35, 1)
        Me._Line_14.TabIndex = 23
        '
        '_Line_13
        '
        Me._Line_13.Enabled = False
        Me._Line_13.Location = New System.Drawing.Point(4, 45)
        Me._Line_13.Name = "_Line_13"
        Me._Line_13.Size = New System.Drawing.Size(35, 1)
        Me._Line_13.TabIndex = 24
        '
        '_Line_12
        '
        Me._Line_12.Enabled = False
        Me._Line_12.Location = New System.Drawing.Point(4, 56)
        Me._Line_12.Name = "_Line_12"
        Me._Line_12.Size = New System.Drawing.Size(35, 1)
        Me._Line_12.TabIndex = 25
        '
        '_Frame2_2
        '
        Me._Frame2_2.BackColor = System.Drawing.SystemColors.Window
        Me._Frame2_2.Controls.Add(Me._txtVT_11)
        Me._Frame2_2.Controls.Add(Me._txtVT_10)
        Me._Frame2_2.Controls.Add(Me._txtVT_9)
        Me._Frame2_2.Controls.Add(Me._txtVT_8)
        Me._Frame2_2.Controls.Add(Me._txtVT_7)
        Me._Frame2_2.Controls.Add(Me._Line_7)
        Me._Frame2_2.Controls.Add(Me._Line_8)
        Me._Frame2_2.Controls.Add(Me._Line_9)
        Me._Frame2_2.Controls.Add(Me._Line_10)
        Me._Frame2_2.Controls.Add(Me._Line_11)
        Me._Frame2_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Frame2_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame2_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame2_2.Location = New System.Drawing.Point(140, 32)
        Me._Frame2_2.Name = "_Frame2_2"
        Me._Frame2_2.Size = New System.Drawing.Size(89, 129)
        Me._Frame2_2.TabIndex = 49
        '
        '_txtVT_11
        '
        Me._txtVT_11.AcceptsReturn = True
        Me._txtVT_11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_11.Location = New System.Drawing.Point(8, 104)
        Me._txtVT_11.MaxLength = 20
        Me._txtVT_11.Name = "_txtVT_11"
        Me._txtVT_11.Size = New System.Drawing.Size(73, 13)
        Me._txtVT_11.TabIndex = 14
        Me._txtVT_11.Text = "..."
        Me._txtVT_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_10
        '
        Me._txtVT_10.AcceptsReturn = True
        Me._txtVT_10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_10.Location = New System.Drawing.Point(8, 80)
        Me._txtVT_10.MaxLength = 20
        Me._txtVT_10.Name = "_txtVT_10"
        Me._txtVT_10.Size = New System.Drawing.Size(73, 13)
        Me._txtVT_10.TabIndex = 13
        Me._txtVT_10.Text = "..."
        Me._txtVT_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_9
        '
        Me._txtVT_9.AcceptsReturn = True
        Me._txtVT_9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_9.Location = New System.Drawing.Point(8, 56)
        Me._txtVT_9.MaxLength = 20
        Me._txtVT_9.Name = "_txtVT_9"
        Me._txtVT_9.Size = New System.Drawing.Size(73, 13)
        Me._txtVT_9.TabIndex = 12
        Me._txtVT_9.Text = "..."
        Me._txtVT_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_8
        '
        Me._txtVT_8.AcceptsReturn = True
        Me._txtVT_8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_8.Location = New System.Drawing.Point(8, 32)
        Me._txtVT_8.MaxLength = 20
        Me._txtVT_8.Name = "_txtVT_8"
        Me._txtVT_8.Size = New System.Drawing.Size(73, 13)
        Me._txtVT_8.TabIndex = 11
        Me._txtVT_8.Text = "..."
        Me._txtVT_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_7
        '
        Me._txtVT_7.AcceptsReturn = True
        Me._txtVT_7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_7.Location = New System.Drawing.Point(8, 8)
        Me._txtVT_7.MaxLength = 20
        Me._txtVT_7.Name = "_txtVT_7"
        Me._txtVT_7.Size = New System.Drawing.Size(73, 13)
        Me._txtVT_7.TabIndex = 10
        Me._txtVT_7.Text = "..."
        Me._txtVT_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Line_7
        '
        Me._Line_7.Enabled = False
        Me._Line_7.Location = New System.Drawing.Point(4, 56)
        Me._Line_7.Name = "_Line_7"
        Me._Line_7.Size = New System.Drawing.Size(35, 1)
        Me._Line_7.TabIndex = 15
        '
        '_Line_8
        '
        Me._Line_8.Enabled = False
        Me._Line_8.Location = New System.Drawing.Point(4, 45)
        Me._Line_8.Name = "_Line_8"
        Me._Line_8.Size = New System.Drawing.Size(35, 1)
        Me._Line_8.TabIndex = 16
        '
        '_Line_9
        '
        Me._Line_9.Enabled = False
        Me._Line_9.Location = New System.Drawing.Point(4, 34)
        Me._Line_9.Name = "_Line_9"
        Me._Line_9.Size = New System.Drawing.Size(35, 1)
        Me._Line_9.TabIndex = 17
        '
        '_Line_10
        '
        Me._Line_10.Enabled = False
        Me._Line_10.Location = New System.Drawing.Point(4, 23)
        Me._Line_10.Name = "_Line_10"
        Me._Line_10.Size = New System.Drawing.Size(35, 1)
        Me._Line_10.TabIndex = 18
        '
        '_Line_11
        '
        Me._Line_11.Enabled = False
        Me._Line_11.Location = New System.Drawing.Point(4, 13)
        Me._Line_11.Name = "_Line_11"
        Me._Line_11.Size = New System.Drawing.Size(35, 1)
        Me._Line_11.TabIndex = 19
        '
        '_Frame2_1
        '
        Me._Frame2_1.BackColor = System.Drawing.SystemColors.Window
        Me._Frame2_1.Controls.Add(Me._txtVT_2)
        Me._Frame2_1.Controls.Add(Me._txtVT_3)
        Me._Frame2_1.Controls.Add(Me._txtVT_4)
        Me._Frame2_1.Controls.Add(Me._txtVT_5)
        Me._Frame2_1.Controls.Add(Me._txtVT_6)
        Me._Frame2_1.Controls.Add(Me._Line_1)
        Me._Frame2_1.Controls.Add(Me._Line_3)
        Me._Frame2_1.Controls.Add(Me._Line_4)
        Me._Frame2_1.Controls.Add(Me._Line_5)
        Me._Frame2_1.Controls.Add(Me._Line_6)
        Me._Frame2_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Frame2_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame2_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame2_1.Location = New System.Drawing.Point(52, 32)
        Me._Frame2_1.Name = "_Frame2_1"
        Me._Frame2_1.Size = New System.Drawing.Size(89, 129)
        Me._Frame2_1.TabIndex = 48
        '
        '_txtVT_2
        '
        Me._txtVT_2.AcceptsReturn = True
        Me._txtVT_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_2.Location = New System.Drawing.Point(8, 8)
        Me._txtVT_2.MaxLength = 20
        Me._txtVT_2.Name = "_txtVT_2"
        Me._txtVT_2.Size = New System.Drawing.Size(73, 13)
        Me._txtVT_2.TabIndex = 4
        Me._txtVT_2.Text = "..."
        Me._txtVT_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_3
        '
        Me._txtVT_3.AcceptsReturn = True
        Me._txtVT_3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_3.Location = New System.Drawing.Point(8, 32)
        Me._txtVT_3.MaxLength = 20
        Me._txtVT_3.Name = "_txtVT_3"
        Me._txtVT_3.Size = New System.Drawing.Size(73, 13)
        Me._txtVT_3.TabIndex = 5
        Me._txtVT_3.Text = "..."
        Me._txtVT_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_4
        '
        Me._txtVT_4.AcceptsReturn = True
        Me._txtVT_4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_4.Location = New System.Drawing.Point(8, 56)
        Me._txtVT_4.MaxLength = 20
        Me._txtVT_4.Name = "_txtVT_4"
        Me._txtVT_4.Size = New System.Drawing.Size(73, 13)
        Me._txtVT_4.TabIndex = 6
        Me._txtVT_4.Text = "..."
        Me._txtVT_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_5
        '
        Me._txtVT_5.AcceptsReturn = True
        Me._txtVT_5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_5.Location = New System.Drawing.Point(8, 80)
        Me._txtVT_5.MaxLength = 20
        Me._txtVT_5.Name = "_txtVT_5"
        Me._txtVT_5.Size = New System.Drawing.Size(73, 13)
        Me._txtVT_5.TabIndex = 7
        Me._txtVT_5.Text = "..."
        Me._txtVT_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtVT_6
        '
        Me._txtVT_6.AcceptsReturn = True
        Me._txtVT_6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_6.Location = New System.Drawing.Point(8, 104)
        Me._txtVT_6.MaxLength = 20
        Me._txtVT_6.Name = "_txtVT_6"
        Me._txtVT_6.Size = New System.Drawing.Size(73, 13)
        Me._txtVT_6.TabIndex = 8
        Me._txtVT_6.Text = "..."
        Me._txtVT_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Line_1
        '
        Me._Line_1.Enabled = False
        Me._Line_1.Location = New System.Drawing.Point(4, 13)
        Me._Line_1.Name = "_Line_1"
        Me._Line_1.Size = New System.Drawing.Size(35, 1)
        Me._Line_1.TabIndex = 9
        '
        '_Line_3
        '
        Me._Line_3.Enabled = False
        Me._Line_3.Location = New System.Drawing.Point(4, 23)
        Me._Line_3.Name = "_Line_3"
        Me._Line_3.Size = New System.Drawing.Size(75, 1)
        Me._Line_3.TabIndex = 10
        '
        '_Line_4
        '
        Me._Line_4.Enabled = False
        Me._Line_4.Location = New System.Drawing.Point(4, 34)
        Me._Line_4.Name = "_Line_4"
        Me._Line_4.Size = New System.Drawing.Size(35, 1)
        Me._Line_4.TabIndex = 11
        '
        '_Line_5
        '
        Me._Line_5.Enabled = False
        Me._Line_5.Location = New System.Drawing.Point(4, 45)
        Me._Line_5.Name = "_Line_5"
        Me._Line_5.Size = New System.Drawing.Size(35, 1)
        Me._Line_5.TabIndex = 12
        '
        '_Line_6
        '
        Me._Line_6.Enabled = False
        Me._Line_6.Location = New System.Drawing.Point(4, 56)
        Me._Line_6.Name = "_Line_6"
        Me._Line_6.Size = New System.Drawing.Size(35, 1)
        Me._Line_6.TabIndex = 13
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.White
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_8.Location = New System.Drawing.Point(6, 136)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(44, 17)
        Me._Label_8.TabIndex = 47
        Me._Label_8.Tag = "Level V"
        Me._Label_8.Text = "Bậc V"
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.White
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_7.Location = New System.Drawing.Point(6, 112)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(44, 17)
        Me._Label_7.TabIndex = 46
        Me._Label_7.Tag = "Level IV"
        Me._Label_7.Text = "Bậc IV"
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.White
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_6.Location = New System.Drawing.Point(6, 88)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(44, 17)
        Me._Label_6.TabIndex = 45
        Me._Label_6.Tag = "Level III"
        Me._Label_6.Text = "Bậc III"
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.White
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_3.Location = New System.Drawing.Point(6, 64)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(44, 17)
        Me._Label_3.TabIndex = 44
        Me._Label_3.Tag = "Level II"
        Me._Label_3.Text = "Bậc II"
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.White
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(6, 40)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(44, 17)
        Me._Label_2.TabIndex = 43
        Me._Label_2.Tag = "Level I"
        Me._Label_2.Text = "Bậc I"
        '
        '_txtVT_1
        '
        Me._txtVT_1.AcceptsReturn = True
        Me._txtVT_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_1.Location = New System.Drawing.Point(272, 48)
        Me._txtVT_1.MaxLength = 100
        Me._txtVT_1.Name = "_txtVT_1"
        Me._txtVT_1.Size = New System.Drawing.Size(349, 13)
        Me._txtVT_1.TabIndex = 2
        Me._txtVT_1.Text = "..."
        '
        'txtF
        '
        Me.txtF.AcceptsReturn = True
        Me.txtF.BackColor = System.Drawing.SystemColors.Window
        Me.txtF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF.Location = New System.Drawing.Point(148, 446)
        Me.txtF.MaxLength = 0
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(145, 20)
        Me.txtF.TabIndex = 33
        '
        '_txtVT_0
        '
        Me._txtVT_0.AcceptsReturn = True
        Me._txtVT_0.BackColor = System.Drawing.Color.White
        Me._txtVT_0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._txtVT_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtVT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtVT_0.Location = New System.Drawing.Point(272, 24)
        Me._txtVT_0.MaxLength = 20
        Me._txtVT_0.Name = "_txtVT_0"
        Me._txtVT_0.Size = New System.Drawing.Size(137, 13)
        Me._txtVT_0.TabIndex = 1
        Me._txtVT_0.Text = "..."
        '
        '_SSOpt_1
        '
        Me._SSOpt_1.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_1.Location = New System.Drawing.Point(80, 448)
        Me._SSOpt_1.Name = "_SSOpt_1"
        Me._SSOpt_1.Size = New System.Drawing.Size(65, 17)
        Me._SSOpt_1.TabIndex = 32
        Me._SSOpt_1.TabStop = True
        Me._SSOpt_1.Tag = "Name"
        Me._SSOpt_1.Text = "Tên"
        Me._SSOpt_1.UseVisualStyleBackColor = False
        '
        '_SSOpt_0
        '
        Me._SSOpt_0.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_0.Location = New System.Drawing.Point(8, 448)
        Me._SSOpt_0.Name = "_SSOpt_0"
        Me._SSOpt_0.Size = New System.Drawing.Size(65, 17)
        Me._SSOpt_0.TabIndex = 31
        Me._SSOpt_0.TabStop = True
        Me._SSOpt_0.Tag = "Code"
        Me._SSOpt_0.Text = "Số hiệu"
        Me._SSOpt_0.UseVisualStyleBackColor = False
        '
        'LstVt
        '
        Me.LstVt.BackColor = System.Drawing.SystemColors.Window
        Me.LstVt.Cursor = System.Windows.Forms.Cursors.Default
        Me.LstVt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstVt.ItemHeight = 14
        Me.LstVt.Location = New System.Drawing.Point(8, 8)
        Me.LstVt.Name = "LstVt"
        Me.LstVt.Size = New System.Drawing.Size(193, 424)
        Me.LstVt.TabIndex = 0
        '
        '_Line_2
        '
        Me._Line_2.Enabled = False
        Me._Line_2.Location = New System.Drawing.Point(273, 36)
        Me._Line_2.Name = "_Line_2"
        Me._Line_2.Size = New System.Drawing.Size(69, 1)
        Me._Line_2.TabIndex = 56
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.White
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(216, 48)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(50, 17)
        Me._Label_0.TabIndex = 41
        Me._Label_0.Tag = "Name"
        Me._Label_0.Text = "Tên CV"
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.White
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(216, 24)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(50, 17)
        Me._Label_1.TabIndex = 40
        Me._Label_1.Tag = "Code"
        Me._Label_1.Text = "Mã CV"
        '
        '_Line_0
        '
        Me._Line_0.Enabled = False
        Me._Line_0.Location = New System.Drawing.Point(130, 20)
        Me._Line_0.Name = "_Line_0"
        Me._Line_0.Size = New System.Drawing.Size(35, 1)
        Me._Line_0.TabIndex = 57
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.SystemColors.Window
        Me._Label_17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.Location = New System.Drawing.Point(208, 9)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(441, 423)
        Me._Label_17.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(273, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 1)
        Me.Label1.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(273, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(349, 1)
        Me.Label2.TabIndex = 59
        '
        'FrmChucvu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(657, 477)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SSCmdF)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me._txtVT_1)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me._txtVT_0)
        Me.Controls.Add(Me._SSOpt_1)
        Me.Controls.Add(Me._SSOpt_0)
        Me.Controls.Add(Me.LstVt)
        Me.Controls.Add(Me._Line_2)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Line_0)
        Me.Controls.Add(Me._Label_17)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(72, 67)
        Me.MaximizeBox = False
        Me.Name = "FrmChucvu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "List of position"
        Me.Text = "Danh sách chức vụ"
        Me.Frame1.ResumeLayout(False)
        Me._Frame2_4.ResumeLayout(False)
        Me._Frame2_4.PerformLayout()
        Me._Frame2_3.ResumeLayout(False)
        Me._Frame2_3.PerformLayout()
        Me._Frame2_2.ResumeLayout(False)
        Me._Frame2_2.PerformLayout()
        Me._Frame2_1.ResumeLayout(False)
        Me._Frame2_1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializetxtVT()
		Me.txtVT(17) = _txtVT_17
		Me.txtVT(18) = _txtVT_18
		Me.txtVT(19) = _txtVT_19
		Me.txtVT(20) = _txtVT_20
		Me.txtVT(21) = _txtVT_21
		Me.txtVT(12) = _txtVT_12
		Me.txtVT(13) = _txtVT_13
		Me.txtVT(14) = _txtVT_14
		Me.txtVT(15) = _txtVT_15
		Me.txtVT(16) = _txtVT_16
		Me.txtVT(11) = _txtVT_11
		Me.txtVT(10) = _txtVT_10
		Me.txtVT(9) = _txtVT_9
		Me.txtVT(8) = _txtVT_8
		Me.txtVT(7) = _txtVT_7
		Me.txtVT(2) = _txtVT_2
		Me.txtVT(3) = _txtVT_3
		Me.txtVT(4) = _txtVT_4
		Me.txtVT(5) = _txtVT_5
		Me.txtVT(6) = _txtVT_6
		Me.txtVT(1) = _txtVT_1
		Me.txtVT(0) = _txtVT_0
	End Sub
	Sub InitializeSSOpt()
		Me.SSOpt(1) = _SSOpt_1
		Me.SSOpt(0) = _SSOpt_0
	End Sub
	Sub InitializeLine()
		Me.Line(17) = _Line_17
		Me.Line(18) = _Line_18
		Me.Line(19) = _Line_19
		Me.Line(20) = _Line_20
		Me.Line(21) = _Line_21
		Me.Line(16) = _Line_16
		Me.Line(15) = _Line_15
		Me.Line(14) = _Line_14
		Me.Line(13) = _Line_13
		Me.Line(12) = _Line_12
		Me.Line(7) = _Line_7
		Me.Line(8) = _Line_8
		Me.Line(9) = _Line_9
		Me.Line(10) = _Line_10
		Me.Line(11) = _Line_11
		Me.Line(1) = _Line_1
		Me.Line(3) = _Line_3
		Me.Line(4) = _Line_4
		Me.Line(5) = _Line_5
		Me.Line(6) = _Line_6
		Me.Line(2) = _Line_2
		Me.Line(0) = _Line_0
	End Sub
	Sub InitializeLabel()
		Me.Label(8) = _Label_8
		Me.Label(7) = _Label_7
		Me.Label(6) = _Label_6
		Me.Label(3) = _Label_3
		Me.Label(2) = _Label_2
		Me.Label(0) = _Label_0
		Me.Label(1) = _Label_1
		Me.Label(17) = _Label_17
        'Me.Label(5) = _Label_5
        'Me.Label(4) = _Label_4
        'Me.Label(9) = _Label_9
	End Sub
	Sub InitializeFrame2()
		Me.Frame2(4) = _Frame2_4
		Me.Frame2(3) = _Frame2_3
		Me.Frame2(2) = _Frame2_2
		Me.Frame2(1) = _Frame2_1
	End Sub
	Sub InitializeCommand()
		Me.Command(3) = _Command_3
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
	Sub InitializeChkLoai()
		Me.ChkLoai(4) = _ChkLoai_4
		Me.ChkLoai(3) = _ChkLoai_3
		Me.ChkLoai(2) = _ChkLoai_2
		Me.ChkLoai(1) = _ChkLoai_1
    End Sub
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
#End Region 
End Class
