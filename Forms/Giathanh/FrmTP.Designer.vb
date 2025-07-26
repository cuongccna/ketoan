<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTP
    Inherits Form

#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        ' Init components
        InitializeComponent()
        InitializetxtShTk()
        Initializecmdtk1()
        Initializecmdtk()
        InitializeTxtVT()
        InitializeSSOpt()
        InitializeLine()
        InitializeLbTenTk()
        InitializeLbCP()
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
    Private WithEvents _cmdtk_0 As System.Windows.Forms.Button
    Public WithEvents SSCmdF As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _txtShTk_0 As System.Windows.Forms.TextBox
    Private WithEvents _cmdtk1_0 As System.Windows.Forms.Button
    Public WithEvents CboThang As ComboBoxEx.ComboBoxExt
    Private WithEvents _TxtVT_0 As System.Windows.Forms.TextBox
    Private WithEvents _TxtVT_1 As System.Windows.Forms.TextBox
    Private WithEvents _TxtVT_2 As System.Windows.Forms.TextBox
    Private WithEvents _TxtVT_3 As System.Windows.Forms.TextBox
    Private WithEvents _TxtVT_4 As System.Windows.Forms.TextBox
    Private WithEvents _Command1_3 As System.Windows.Forms.Button
    Private WithEvents _Command1_2 As System.Windows.Forms.Button
    Private WithEvents _Command1_1 As System.Windows.Forms.Button
    Private WithEvents _Command1_0 As System.Windows.Forms.Button
    Public WithEvents SSCmdF1 As System.Windows.Forms.Button
    Private WithEvents _SSOpt_1 As System.Windows.Forms.RadioButton
    Private WithEvents _SSOpt_0 As System.Windows.Forms.RadioButton
    Public WithEvents txtF As System.Windows.Forms.TextBox
    Public WithEvents CboLoai As ComboBoxEx.ComboBoxExt
    Public WithEvents LstVt As System.Windows.Forms.ListBox
    Private WithEvents _LbTenTk_0 As System.Windows.Forms.Label
    Private WithEvents _Label_16 As System.Windows.Forms.Label
    Private WithEvents _Label_15 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Line_0 As System.Windows.Forms.Label
    Private WithEvents _Line_1 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Line_2 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _Line_8 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _LbCP_0 As System.Windows.Forms.Label
    Private WithEvents _LbCP_1 As System.Windows.Forms.Label
    Private WithEvents _LbCP_2 As System.Windows.Forms.Label
    Private WithEvents _LbCP_3 As System.Windows.Forms.Label
    Private WithEvents _LbCP_4 As System.Windows.Forms.Label
    Private WithEvents _LbCP_5 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _Line_3 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Public Command(3) As System.Windows.Forms.Button
    Public Command1(3) As System.Windows.Forms.Button
    Public Label(16) As System.Windows.Forms.Label
    Public LbCP(5) As System.Windows.Forms.Label
    Public LbTenTk(0) As System.Windows.Forms.Label
    Public Line(8) As System.Windows.Forms.Label
    Public SSOpt(1) As System.Windows.Forms.RadioButton
    Public TxtVT(4) As System.Windows.Forms.TextBox
    Public cmdtk(0) As System.Windows.Forms.Button
    Public cmdtk1(0) As System.Windows.Forms.Button
    Public txtShTk(0) As System.Windows.Forms.TextBox
    'Private listBoxHelper1 As Artinsoft.VB6.Gui.ListBoxHelper
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTP))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._cmdtk_0 = New System.Windows.Forms.Button
        Me.SSCmdF = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me._txtShTk_0 = New System.Windows.Forms.TextBox
        Me._cmdtk1_0 = New System.Windows.Forms.Button
        Me.CboThang = New ComboBoxEx.ComboBoxExt
        Me._TxtVT_0 = New System.Windows.Forms.TextBox
        Me._TxtVT_1 = New System.Windows.Forms.TextBox
        Me._TxtVT_2 = New System.Windows.Forms.TextBox
        Me._TxtVT_3 = New System.Windows.Forms.TextBox
        Me._TxtVT_4 = New System.Windows.Forms.TextBox
        Me._Command1_3 = New System.Windows.Forms.Button
        Me._Command1_2 = New System.Windows.Forms.Button
        Me._Command1_1 = New System.Windows.Forms.Button
        Me._Command1_0 = New System.Windows.Forms.Button
        Me.SSCmdF1 = New System.Windows.Forms.Button
        Me._SSOpt_1 = New System.Windows.Forms.RadioButton
        Me._SSOpt_0 = New System.Windows.Forms.RadioButton
        Me.txtF = New System.Windows.Forms.TextBox
        Me.CboLoai = New ComboBoxEx.ComboBoxExt
        Me.LstVt = New System.Windows.Forms.ListBox
        Me._LbTenTk_0 = New System.Windows.Forms.Label
        Me._Label_16 = New System.Windows.Forms.Label
        Me._Label_15 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Line_0 = New System.Windows.Forms.Label
        Me._Line_1 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Line_2 = New System.Windows.Forms.Label
        Me._Label_13 = New System.Windows.Forms.Label
        Me._Line_8 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Label_10 = New System.Windows.Forms.Label
        Me._Label_11 = New System.Windows.Forms.Label
        Me._LbCP_0 = New System.Windows.Forms.Label
        Me._LbCP_1 = New System.Windows.Forms.Label
        Me._LbCP_2 = New System.Windows.Forms.Label
        Me._LbCP_3 = New System.Windows.Forms.Label
        Me._LbCP_4 = New System.Windows.Forms.Label
        Me._LbCP_5 = New System.Windows.Forms.Label
        Me._Label_12 = New System.Windows.Forms.Label
        Me._Line_3 = New System.Windows.Forms.Label
        Me._Label_14 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        '_cmdtk_0
        '
        Me._cmdtk_0.Image = Global.UNET.My.Resources.Resources.search3_16
        Me._cmdtk_0.Location = New System.Drawing.Point(511, 128)
        Me._cmdtk_0.Name = "_cmdtk_0"
        Me._cmdtk_0.Size = New System.Drawing.Size(23, 22)
        Me._cmdtk_0.TabIndex = 47
        '
        'SSCmdF
        '
        Me.SSCmdF.Image = Global.UNET.My.Resources.Resources.search16
        Me.SSCmdF.Location = New System.Drawing.Point(304, 448)
        Me.SSCmdF.Name = "SSCmdF"
        Me.SSCmdF.Size = New System.Drawing.Size(17, 19)
        Me.SSCmdF.TabIndex = 42
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.add16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(336, 440)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 43
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(416, 440)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 44
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(496, 440)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 45
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(576, 440)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 46
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_txtShTk_0
        '
        Me._txtShTk_0.AcceptsReturn = True
        Me._txtShTk_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_0.Location = New System.Drawing.Point(416, 128)
        Me._txtShTk_0.MaxLength = 12
        Me._txtShTk_0.Name = "_txtShTk_0"
        Me._txtShTk_0.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_0.TabIndex = 6
        Me._txtShTk_0.Tag = "0"
        Me._txtShTk_0.Text = "154"
        '
        '_cmdtk1_0
        '
        Me._cmdtk1_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdtk1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdtk1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdtk1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdtk1_0.Image = CType(resources.GetObject("_cmdtk1_0.Image"), System.Drawing.Image)
        Me._cmdtk1_0.Location = New System.Drawing.Point(661, 128)
        Me._cmdtk1_0.Name = "_cmdtk1_0"
        Me._cmdtk1_0.Size = New System.Drawing.Size(25, 25)
        Me._cmdtk1_0.TabIndex = 7
        Me._cmdtk1_0.TabStop = False
        Me._cmdtk1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdtk1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._cmdtk1_0.UseVisualStyleBackColor = False
        Me._cmdtk1_0.Visible = False
        '
        'CboThang
        '
        Me.CboThang.BackColor = System.Drawing.SystemColors.Window
        Me.CboThang.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboThang.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboThang.Location = New System.Drawing.Point(552, 176)
        Me.CboThang.Name = "CboThang"
        Me.CboThang.Size = New System.Drawing.Size(73, 21)
        Me.CboThang.TabIndex = 39
        '
        '_TxtVT_0
        '
        Me._TxtVT_0.AcceptsReturn = True
        Me._TxtVT_0.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_0.Location = New System.Drawing.Point(416, 24)
        Me._TxtVT_0.MaxLength = 20
        Me._TxtVT_0.Name = "_TxtVT_0"
        Me._TxtVT_0.Size = New System.Drawing.Size(129, 13)
        Me._TxtVT_0.TabIndex = 2
        '
        '_TxtVT_1
        '
        Me._TxtVT_1.AcceptsReturn = True
        Me._TxtVT_1.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_1.Location = New System.Drawing.Point(416, 48)
        Me._TxtVT_1.MaxLength = 50
        Me._TxtVT_1.Name = "_TxtVT_1"
        Me._TxtVT_1.Size = New System.Drawing.Size(209, 13)
        Me._TxtVT_1.TabIndex = 3
        '
        '_TxtVT_2
        '
        Me._TxtVT_2.AcceptsReturn = True
        Me._TxtVT_2.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_2.Location = New System.Drawing.Point(416, 72)
        Me._TxtVT_2.MaxLength = 12
        Me._TxtVT_2.Name = "_TxtVT_2"
        Me._TxtVT_2.Size = New System.Drawing.Size(129, 13)
        Me._TxtVT_2.TabIndex = 4
        '
        '_TxtVT_3
        '
        Me._TxtVT_3.AcceptsReturn = True
        Me._TxtVT_3.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_3.Location = New System.Drawing.Point(416, 96)
        Me._TxtVT_3.MaxLength = 50
        Me._TxtVT_3.Name = "_TxtVT_3"
        Me._TxtVT_3.Size = New System.Drawing.Size(209, 13)
        Me._TxtVT_3.TabIndex = 5
        '
        '_TxtVT_4
        '
        Me._TxtVT_4.AcceptsReturn = True
        Me._TxtVT_4.BackColor = System.Drawing.SystemColors.Window
        Me._TxtVT_4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._TxtVT_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TxtVT_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtVT_4.Location = New System.Drawing.Point(528, 208)
        Me._TxtVT_4.MaxLength = 20
        Me._TxtVT_4.Name = "_TxtVT_4"
        Me._TxtVT_4.Size = New System.Drawing.Size(97, 13)
        Me._TxtVT_4.TabIndex = 8
        Me._TxtVT_4.Text = "0"
        Me._TxtVT_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Command1_3
        '
        Me._Command1_3.BackColor = System.Drawing.Color.Silver
        Me._Command1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Command1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Command1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Command1_3.Image = CType(resources.GetObject("_Command1_3.Image"), System.Drawing.Image)
        Me._Command1_3.Location = New System.Drawing.Point(576, 440)
        Me._Command1_3.Name = "_Command1_3"
        Me._Command1_3.Size = New System.Drawing.Size(73, 25)
        Me._Command1_3.TabIndex = 19
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
        Me._Command1_2.Location = New System.Drawing.Point(496, 440)
        Me._Command1_2.Name = "_Command1_2"
        Me._Command1_2.Size = New System.Drawing.Size(73, 25)
        Me._Command1_2.TabIndex = 18
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
        Me._Command1_1.Location = New System.Drawing.Point(416, 440)
        Me._Command1_1.Name = "_Command1_1"
        Me._Command1_1.Size = New System.Drawing.Size(73, 25)
        Me._Command1_1.TabIndex = 17
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
        Me._Command1_0.Location = New System.Drawing.Point(336, 440)
        Me._Command1_0.Name = "_Command1_0"
        Me._Command1_0.Size = New System.Drawing.Size(73, 25)
        Me._Command1_0.TabIndex = 16
        Me._Command1_0.TabStop = False
        Me._Command1_0.Tag = "&Add"
        Me._Command1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Command1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Command1_0.UseVisualStyleBackColor = False
        Me._Command1_0.Visible = False
        '
        'SSCmdF1
        '
        Me.SSCmdF1.BackColor = System.Drawing.SystemColors.Control
        Me.SSCmdF1.Cursor = System.Windows.Forms.Cursors.Default
        Me.SSCmdF1.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.SSCmdF1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SSCmdF1.Location = New System.Drawing.Point(304, 448)
        Me.SSCmdF1.Name = "SSCmdF1"
        Me.SSCmdF1.Size = New System.Drawing.Size(17, 19)
        Me.SSCmdF1.TabIndex = 15
        Me.SSCmdF1.TabStop = False
        Me.SSCmdF1.Text = "ư"
        Me.SSCmdF1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SSCmdF1.UseVisualStyleBackColor = False
        Me.SSCmdF1.Visible = False
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
        Me._SSOpt_1.TabIndex = 14
        Me._SSOpt_1.TabStop = True
        Me._SSOpt_1.Tag = "Description"
        Me._SSOpt_1.Text = "Tên TP"
        Me._SSOpt_1.UseVisualStyleBackColor = False
        '
        '_SSOpt_0
        '
        Me._SSOpt_0.BackColor = System.Drawing.Color.Transparent
        Me._SSOpt_0.Checked = True
        Me._SSOpt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._SSOpt_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SSOpt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SSOpt_0.Location = New System.Drawing.Point(8, 448)
        Me._SSOpt_0.Name = "_SSOpt_0"
        Me._SSOpt_0.Size = New System.Drawing.Size(65, 17)
        Me._SSOpt_0.TabIndex = 13
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
        Me.txtF.Location = New System.Drawing.Point(152, 448)
        Me.txtF.MaxLength = 0
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(145, 20)
        Me.txtF.TabIndex = 12
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
        Me.CboLoai.Size = New System.Drawing.Size(313, 21)
        Me.CboLoai.TabIndex = 0
        '
        'LstVt
        '
        Me.LstVt.BackColor = System.Drawing.SystemColors.Window
        Me.LstVt.Cursor = System.Windows.Forms.Cursors.Default
        Me.LstVt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstVt.ItemHeight = 14
        Me.LstVt.Location = New System.Drawing.Point(8, 32)
        Me.LstVt.Name = "LstVt"
        Me.LstVt.Size = New System.Drawing.Size(313, 396)
        Me.LstVt.TabIndex = 1
        '
        '_LbTenTk_0
        '
        Me._LbTenTk_0.BackColor = System.Drawing.SystemColors.Window
        Me._LbTenTk_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_0.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_0.Location = New System.Drawing.Point(416, 152)
        Me._LbTenTk_0.Name = "_LbTenTk_0"
        Me._LbTenTk_0.Size = New System.Drawing.Size(217, 17)
        Me._LbTenTk_0.TabIndex = 41
        Me._LbTenTk_0.Tag = "1"
        '
        '_Label_16
        '
        Me._Label_16.BackColor = System.Drawing.Color.White
        Me._Label_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_16.Location = New System.Drawing.Point(352, 128)
        Me._Label_16.Name = "_Label_16"
        Me._Label_16.Size = New System.Drawing.Size(69, 17)
        Me._Label_16.TabIndex = 40
        Me._Label_16.Tag = "Account"
        Me._Label_16.Text = "Tài khoản"
        '
        '_Label_15
        '
        Me._Label_15.BackColor = System.Drawing.Color.White
        Me._Label_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_15.Location = New System.Drawing.Point(502, 178)
        Me._Label_15.Name = "_Label_15"
        Me._Label_15.Size = New System.Drawing.Size(54, 17)
        Me._Label_15.TabIndex = 38
        Me._Label_15.Tag = "Month"
        Me._Label_15.Text = "Tháng"
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.White
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(352, 31)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(53, 17)
        Me._Label_1.TabIndex = 37
        Me._Label_1.Tag = "Code"
        Me._Label_1.Text = "Số hiệu"
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.White
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(352, 55)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(53, 17)
        Me._Label_2.TabIndex = 36
        Me._Label_2.Tag = "Desc."
        Me._Label_2.Text = "Tên"
        '
        '_Line_0
        '
        Me._Line_0.Enabled = False
        Me._Line_0.Location = New System.Drawing.Point(416, 43)
        Me._Line_0.Name = "_Line_0"
        Me._Line_0.Size = New System.Drawing.Size(128, 1)
        Me._Line_0.TabIndex = 48
        '
        '_Line_1
        '
        Me._Line_1.Enabled = False
        Me._Line_1.Location = New System.Drawing.Point(416, 67)
        Me._Line_1.Name = "_Line_1"
        Me._Line_1.Size = New System.Drawing.Size(208, 1)
        Me._Line_1.TabIndex = 49
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.White
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_3.Location = New System.Drawing.Point(352, 79)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(45, 17)
        Me._Label_3.TabIndex = 35
        Me._Label_3.Tag = "Unit"
        Me._Label_3.Text = "Đơn vị"
        '
        '_Line_2
        '
        Me._Line_2.Enabled = False
        Me._Line_2.Location = New System.Drawing.Point(416, 91)
        Me._Line_2.Name = "_Line_2"
        Me._Line_2.Size = New System.Drawing.Size(128, 1)
        Me._Line_2.TabIndex = 50
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.White
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_13.Location = New System.Drawing.Point(352, 103)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(53, 17)
        Me._Label_13.TabIndex = 34
        Me._Label_13.Tag = "Notes"
        Me._Label_13.Text = "Ghi chú"
        '
        '_Line_8
        '
        Me._Line_8.Enabled = False
        Me._Line_8.Location = New System.Drawing.Point(416, 115)
        Me._Line_8.Name = "_Line_8"
        Me._Line_8.Size = New System.Drawing.Size(208, 1)
        Me._Line_8.TabIndex = 51
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.White
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(352, 240)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(169, 17)
        Me._Label_0.TabIndex = 33
        Me._Label_0.Tag = "Material Expenses"
        Me._Label_0.Text = "Chi phí nguyên vật liệu trực tiếp"
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.White
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_6.Location = New System.Drawing.Point(352, 272)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(137, 17)
        Me._Label_6.TabIndex = 32
        Me._Label_6.Tag = "Labour Expenses"
        Me._Label_6.Text = "Chi phí Nhân công trực tiếp"
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.White
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_7.Location = New System.Drawing.Point(352, 304)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(137, 17)
        Me._Label_7.TabIndex = 31
        Me._Label_7.Tag = "Machine Expenses"
        Me._Label_7.Text = "Chi phí Máy thi công"
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.White
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_8.Location = New System.Drawing.Point(352, 336)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(137, 17)
        Me._Label_8.TabIndex = 30
        Me._Label_8.Tag = "Depreciation"
        Me._Label_8.Text = "Chi phí Khấu hao TSCĐ"
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.White
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_10.Location = New System.Drawing.Point(352, 368)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(137, 17)
        Me._Label_10.TabIndex = 29
        Me._Label_10.Tag = "General Expenses"
        Me._Label_10.Text = "Chi phí sản xuất chung"
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.White
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_11.Location = New System.Drawing.Point(352, 400)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(137, 17)
        Me._Label_11.TabIndex = 28
        Me._Label_11.Tag = "Product Cost"
        Me._Label_11.Text = "Giá thành"
        '
        '_LbCP_0
        '
        Me._LbCP_0.BackColor = System.Drawing.Color.White
        Me._LbCP_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbCP_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbCP_0.ForeColor = System.Drawing.Color.Blue
        Me._LbCP_0.Location = New System.Drawing.Point(536, 240)
        Me._LbCP_0.Name = "_LbCP_0"
        Me._LbCP_0.Size = New System.Drawing.Size(89, 17)
        Me._LbCP_0.TabIndex = 27
        Me._LbCP_0.Text = "0"
        Me._LbCP_0.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbCP_1
        '
        Me._LbCP_1.BackColor = System.Drawing.Color.White
        Me._LbCP_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbCP_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbCP_1.ForeColor = System.Drawing.Color.Blue
        Me._LbCP_1.Location = New System.Drawing.Point(536, 272)
        Me._LbCP_1.Name = "_LbCP_1"
        Me._LbCP_1.Size = New System.Drawing.Size(89, 17)
        Me._LbCP_1.TabIndex = 26
        Me._LbCP_1.Text = "0"
        Me._LbCP_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbCP_2
        '
        Me._LbCP_2.BackColor = System.Drawing.Color.White
        Me._LbCP_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbCP_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbCP_2.ForeColor = System.Drawing.Color.Blue
        Me._LbCP_2.Location = New System.Drawing.Point(536, 304)
        Me._LbCP_2.Name = "_LbCP_2"
        Me._LbCP_2.Size = New System.Drawing.Size(89, 17)
        Me._LbCP_2.TabIndex = 25
        Me._LbCP_2.Text = "0"
        Me._LbCP_2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbCP_3
        '
        Me._LbCP_3.BackColor = System.Drawing.Color.White
        Me._LbCP_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbCP_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbCP_3.ForeColor = System.Drawing.Color.Blue
        Me._LbCP_3.Location = New System.Drawing.Point(536, 336)
        Me._LbCP_3.Name = "_LbCP_3"
        Me._LbCP_3.Size = New System.Drawing.Size(89, 17)
        Me._LbCP_3.TabIndex = 24
        Me._LbCP_3.Text = "0"
        Me._LbCP_3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbCP_4
        '
        Me._LbCP_4.BackColor = System.Drawing.Color.White
        Me._LbCP_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbCP_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbCP_4.ForeColor = System.Drawing.Color.Blue
        Me._LbCP_4.Location = New System.Drawing.Point(536, 368)
        Me._LbCP_4.Name = "_LbCP_4"
        Me._LbCP_4.Size = New System.Drawing.Size(89, 17)
        Me._LbCP_4.TabIndex = 23
        Me._LbCP_4.Text = "0"
        Me._LbCP_4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbCP_5
        '
        Me._LbCP_5.BackColor = System.Drawing.Color.White
        Me._LbCP_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbCP_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbCP_5.ForeColor = System.Drawing.Color.Blue
        Me._LbCP_5.Location = New System.Drawing.Point(536, 400)
        Me._LbCP_5.Name = "_LbCP_5"
        Me._LbCP_5.Size = New System.Drawing.Size(89, 17)
        Me._LbCP_5.TabIndex = 22
        Me._LbCP_5.Text = "0"
        Me._LbCP_5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_12
        '
        Me._Label_12.BackColor = System.Drawing.Color.White
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_12.Location = New System.Drawing.Point(352, 209)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.Size = New System.Drawing.Size(137, 17)
        Me._Label_12.TabIndex = 21
        Me._Label_12.Tag = "Opening Balance"
        Me._Label_12.Text = "Dở dang đầu kỳ"
        '
        '_Line_3
        '
        Me._Line_3.Enabled = False
        Me._Line_3.Location = New System.Drawing.Point(528, 227)
        Me._Line_3.Name = "_Line_3"
        Me._Line_3.Size = New System.Drawing.Size(96, 1)
        Me._Line_3.TabIndex = 52
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.SystemColors.Window
        Me._Label_14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.Location = New System.Drawing.Point(328, 8)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(321, 420)
        Me._Label_14.TabIndex = 20
        '
        'FrmTP
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(657, 472)
        Me.Controls.Add(Me._cmdtk_0)
        Me.Controls.Add(Me.SSCmdF)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._txtShTk_0)
        Me.Controls.Add(Me._cmdtk1_0)
        Me.Controls.Add(Me.CboThang)
        Me.Controls.Add(Me._TxtVT_0)
        Me.Controls.Add(Me._TxtVT_1)
        Me.Controls.Add(Me._TxtVT_2)
        Me.Controls.Add(Me._TxtVT_3)
        Me.Controls.Add(Me._TxtVT_4)
        Me.Controls.Add(Me._Command1_3)
        Me.Controls.Add(Me._Command1_2)
        Me.Controls.Add(Me._Command1_1)
        Me.Controls.Add(Me._Command1_0)
        Me.Controls.Add(Me.SSCmdF1)
        Me.Controls.Add(Me._SSOpt_1)
        Me.Controls.Add(Me._SSOpt_0)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me.CboLoai)
        Me.Controls.Add(Me.LstVt)
        Me.Controls.Add(Me._LbTenTk_0)
        Me.Controls.Add(Me._Label_16)
        Me.Controls.Add(Me._Label_15)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Line_0)
        Me.Controls.Add(Me._Line_1)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Line_2)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me._Line_8)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Label_11)
        Me.Controls.Add(Me._LbCP_0)
        Me.Controls.Add(Me._LbCP_1)
        Me.Controls.Add(Me._LbCP_2)
        Me.Controls.Add(Me._LbCP_3)
        Me.Controls.Add(Me._LbCP_4)
        Me.Controls.Add(Me._LbCP_5)
        Me.Controls.Add(Me._Label_12)
        Me.Controls.Add(Me._Line_3)
        Me.Controls.Add(Me._Label_14)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(34, 58)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "List of projects and products"
        Me.Text = "Hệ thống danh điểm công trình, sản phẩm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Sub InitializetxtShTk()
        Me.txtShTk(0) = _txtShTk_0
    End Sub
    Sub Initializecmdtk1()
        Me.cmdtk1(0) = _cmdtk1_0
    End Sub
    Sub Initializecmdtk()
        Me.cmdtk(0) = _cmdtk_0
    End Sub
    Sub InitializeTxtVT()
        Me.TxtVT(0) = _TxtVT_0
        Me.TxtVT(1) = _TxtVT_1
        Me.TxtVT(2) = _TxtVT_2
        Me.TxtVT(3) = _TxtVT_3
        Me.TxtVT(4) = _TxtVT_4
    End Sub
    Sub InitializeSSOpt()
        Me.SSOpt(1) = _SSOpt_1
        Me.SSOpt(0) = _SSOpt_0
    End Sub
    Sub InitializeLine()
        Me.Line(0) = _Line_0
        Me.Line(1) = _Line_1
        Me.Line(2) = _Line_2
        Me.Line(8) = _Line_8
        Me.Line(3) = _Line_3
    End Sub
    Sub InitializeLbTenTk()
        Me.LbTenTk(0) = _LbTenTk_0
    End Sub
    Sub InitializeLbCP()
        Me.LbCP(0) = _LbCP_0
        Me.LbCP(1) = _LbCP_1
        Me.LbCP(2) = _LbCP_2
        Me.LbCP(3) = _LbCP_3
        Me.LbCP(4) = _LbCP_4
        Me.LbCP(5) = _LbCP_5
    End Sub
    Sub InitializeLabel()
        Me.Label(16) = _Label_16
        Me.Label(15) = _Label_15
        Me.Label(1) = _Label_1
        Me.Label(2) = _Label_2
        Me.Label(3) = _Label_3
        Me.Label(13) = _Label_13
        Me.Label(0) = _Label_0
        Me.Label(6) = _Label_6
        Me.Label(7) = _Label_7
        Me.Label(8) = _Label_8
        Me.Label(10) = _Label_10
        Me.Label(11) = _Label_11
        Me.Label(12) = _Label_12
        Me.Label(14) = _Label_14
        'Me.Label(5) = _Label_5
        'Me.Label(4) = _Label_4
        'Me.Label(9) = _Label_9
    End Sub
    Sub InitializeCommand1()
        Me.Command1(3) = _Command1_3
        Me.Command1(2) = _Command1_2
        Me.Command1(1) = _Command1_1
        Me.Command1(0) = _Command1_0
    End Sub
    Sub InitializeCommand()
        Me.Command(0) = _Command_0
        Me.Command(1) = _Command_1
        Me.Command(2) = _Command_2
        Me.Command(3) = _Command_3
    End Sub
#End Region
End Class
