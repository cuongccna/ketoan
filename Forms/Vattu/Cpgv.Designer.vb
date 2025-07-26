<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CPGV
    Inherits Form

#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        ' Init components
        InitializeComponent()
        InitializetxtTon()
        InitializetxtShTk()
        InitializeOptPB()
        InitializeLbTenTk()
        InitializeLabel()
        InitializeCommand()
        InitializeCmdTK()
        InitializeCbo()
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
    Private WithEvents _txtShTk_3 As System.Windows.Forms.TextBox
    Public WithEvents cmdCT As System.Windows.Forms.Button
    Private WithEvents _CmdTK_0 As System.Windows.Forms.Button
    Private WithEvents _CmdTK_1 As System.Windows.Forms.Button
    Private WithEvents _CmdTK_2 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_4 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Public WithEvents CmdHD As System.Windows.Forms.Button
    Private WithEvents _OptPB_1 As System.Windows.Forms.RadioButton
    Private WithEvents _OptPB_0 As System.Windows.Forms.RadioButton
    Private WithEvents _txtTon_12 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_11 As System.Windows.Forms.TextBox
    Private WithEvents _txtShTk_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtShTk_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtShTk_0 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_9 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_8 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_7 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_6 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_5 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_4 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_3 As System.Windows.Forms.TextBox
    Private WithEvents _Cbo_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _txtTon_14 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_10 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_1 As System.Windows.Forms.TextBox
    Private WithEvents _txtTon_0 As System.Windows.Forms.TextBox
    Private WithEvents _Cbo_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CmdTK_3 As System.Windows.Forms.Button
    Private WithEvents _Label_27 As System.Windows.Forms.Label
    Private WithEvents _Label_26 As System.Windows.Forms.Label
    Private WithEvents _Label_25 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_3 As System.Windows.Forms.Label
    Private WithEvents _Label_16 As System.Windows.Forms.Label
    Private WithEvents _Label_24 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Label_9 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_20 As System.Windows.Forms.Label
    Private WithEvents _Label_19 As System.Windows.Forms.Label
    Private WithEvents _Label_18 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_2 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_1 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_0 As System.Windows.Forms.Label
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Private WithEvents _Label_15 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Public WithEvents LbThue As System.Windows.Forms.Label
    Public WithEvents CP As System.Windows.Forms.Label
    Public WithEvents LbThuedb As System.Windows.Forms.Label
    Public Cbo(1) As ComboBoxEx.ComboBoxExt
    Public CboVV(2) As ComboBoxEx.ComboBoxExt
    Public CmdTK(5) As System.Windows.Forms.Button
    Public Command(4) As System.Windows.Forms.Button
    Public Label(29) As System.Windows.Forms.Label
    Public LbTT(2) As System.Windows.Forms.Label
    Public LbTenTk(5) As System.Windows.Forms.Label
    Public OptPB(1) As System.Windows.Forms.RadioButton
    Public txtShTk(5) As System.Windows.Forms.TextBox
    Public txtTon(14) As System.Windows.Forms.TextBox
    Public WithEvents Grd As ListViewEx.ListviewExt
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CPGV))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._txtShTk_3 = New System.Windows.Forms.TextBox
        Me.cmdCT = New System.Windows.Forms.Button
        Me._OptPB_1 = New System.Windows.Forms.RadioButton
        Me._OptPB_0 = New System.Windows.Forms.RadioButton
        Me._txtTon_12 = New System.Windows.Forms.TextBox
        Me._txtTon_11 = New System.Windows.Forms.TextBox
        Me._txtShTk_2 = New System.Windows.Forms.TextBox
        Me._txtShTk_1 = New System.Windows.Forms.TextBox
        Me._txtShTk_0 = New System.Windows.Forms.TextBox
        Me._txtTon_9 = New System.Windows.Forms.TextBox
        Me._txtTon_8 = New System.Windows.Forms.TextBox
        Me._txtTon_7 = New System.Windows.Forms.TextBox
        Me._txtTon_6 = New System.Windows.Forms.TextBox
        Me._txtTon_5 = New System.Windows.Forms.TextBox
        Me._txtTon_4 = New System.Windows.Forms.TextBox
        Me._txtTon_3 = New System.Windows.Forms.TextBox
        Me._Cbo_0 = New ComboBoxEx.ComboBoxExt
        Me._txtTon_14 = New System.Windows.Forms.TextBox
        Me._txtTon_10 = New System.Windows.Forms.TextBox
        Me._txtTon_2 = New System.Windows.Forms.TextBox
        Me._txtTon_1 = New System.Windows.Forms.TextBox
        Me._txtTon_0 = New System.Windows.Forms.TextBox
        Me._Cbo_1 = New ComboBoxEx.ComboBoxExt
        Me._Label_27 = New System.Windows.Forms.Label
        Me._Label_26 = New System.Windows.Forms.Label
        Me._Label_25 = New System.Windows.Forms.Label
        Me._LbTenTk_3 = New System.Windows.Forms.Label
        Me._Label_16 = New System.Windows.Forms.Label
        Me._Label_24 = New System.Windows.Forms.Label
        Me._Label_13 = New System.Windows.Forms.Label
        Me._Label_12 = New System.Windows.Forms.Label
        Me._Label_11 = New System.Windows.Forms.Label
        Me._Label_9 = New System.Windows.Forms.Label
        Me._Label_5 = New System.Windows.Forms.Label
        Me._Label_20 = New System.Windows.Forms.Label
        Me._Label_19 = New System.Windows.Forms.Label
        Me._Label_18 = New System.Windows.Forms.Label
        Me._LbTenTk_2 = New System.Windows.Forms.Label
        Me._LbTenTk_1 = New System.Windows.Forms.Label
        Me._LbTenTk_0 = New System.Windows.Forms.Label
        Me._Label_17 = New System.Windows.Forms.Label
        Me._Label_15 = New System.Windows.Forms.Label
        Me._Label_10 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me.LbThue = New System.Windows.Forms.Label
        Me.CP = New System.Windows.Forms.Label
        Me.LbThuedb = New System.Windows.Forms.Label
        Me._CmdTK_0 = New System.Windows.Forms.Button
        Me._CmdTK_1 = New System.Windows.Forms.Button
        Me._CmdTK_2 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_4 = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me.CmdHD = New System.Windows.Forms.Button
        Me._CmdTK_3 = New System.Windows.Forms.Button
        Me.Grd = New ListViewEx.ListviewExt
        Me._CmdTK_4 = New System.Windows.Forms.Button
        Me._txtShTk_4 = New System.Windows.Forms.TextBox
        Me._Label_28 = New System.Windows.Forms.Label
        Me._LbTenTk_4 = New System.Windows.Forms.Label
        Me._CmdTK_5 = New System.Windows.Forms.Button
        Me._txtShTk_5 = New System.Windows.Forms.TextBox
        Me._Label_29 = New System.Windows.Forms.Label
        Me._LbTenTk_5 = New System.Windows.Forms.Label
        Me.TxtThueSuat = New System.Windows.Forms.TextBox
        Me.LBThueSuat = New System.Windows.Forms.Label
        Me._OptNoiDia_ = New System.Windows.Forms.RadioButton
        Me._OptNhapKhau_ = New System.Windows.Forms.RadioButton
        Me.FNhap = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.FNhap.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_txtShTk_3
        '
        Me._txtShTk_3.AcceptsReturn = True
        Me._txtShTk_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_3.Location = New System.Drawing.Point(639, 363)
        Me._txtShTk_3.MaxLength = 12
        Me._txtShTk_3.Name = "_txtShTk_3"
        Me._txtShTk_3.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_3.TabIndex = 33
        Me._txtShTk_3.Tag = "0"
        Me._txtShTk_3.Text = "3332"
        '
        'cmdCT
        '
        Me.cmdCT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCT.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCT.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCT.Image = Global.UNET.My.Resources.Resources.up16
        Me.cmdCT.Location = New System.Drawing.Point(991, 295)
        Me.cmdCT.Name = "cmdCT"
        Me.cmdCT.Size = New System.Drawing.Size(19, 21)
        Me.cmdCT.TabIndex = 20
        Me.cmdCT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdCT.UseVisualStyleBackColor = False
        '
        '_OptPB_1
        '
        Me._OptPB_1.BackColor = System.Drawing.Color.Transparent
        Me._OptPB_1.Checked = True
        Me._OptPB_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptPB_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptPB_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptPB_1.Location = New System.Drawing.Point(94, 7)
        Me._OptPB_1.Name = "_OptPB_1"
        Me._OptPB_1.Size = New System.Drawing.Size(65, 17)
        Me._OptPB_1.TabIndex = 5
        Me._OptPB_1.TabStop = True
        Me._OptPB_1.Tag = "Amount"
        Me._OptPB_1.Text = "Giá trị"
        Me._OptPB_1.UseVisualStyleBackColor = False
        '
        '_OptPB_0
        '
        Me._OptPB_0.BackColor = System.Drawing.Color.Transparent
        Me._OptPB_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptPB_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptPB_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptPB_0.Location = New System.Drawing.Point(6, 7)
        Me._OptPB_0.Name = "_OptPB_0"
        Me._OptPB_0.Size = New System.Drawing.Size(82, 17)
        Me._OptPB_0.TabIndex = 4
        Me._OptPB_0.TabStop = True
        Me._OptPB_0.Tag = "Quantily"
        Me._OptPB_0.Text = "Số lượng"
        Me._OptPB_0.UseVisualStyleBackColor = False
        '
        '_txtTon_12
        '
        Me._txtTon_12.AcceptsReturn = True
        Me._txtTon_12.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_12.Location = New System.Drawing.Point(808, 296)
        Me._txtTon_12.MaxLength = 20
        Me._txtTon_12.Name = "_txtTon_12"
        Me._txtTon_12.Size = New System.Drawing.Size(89, 20)
        Me._txtTon_12.TabIndex = 18
        Me._txtTon_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtTon_11
        '
        Me._txtTon_11.AcceptsReturn = True
        Me._txtTon_11.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_11.Location = New System.Drawing.Point(784, 296)
        Me._txtTon_11.MaxLength = 20
        Me._txtTon_11.Name = "_txtTon_11"
        Me._txtTon_11.Size = New System.Drawing.Size(25, 20)
        Me._txtTon_11.TabIndex = 17
        Me._txtTon_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtShTk_2
        '
        Me._txtShTk_2.AcceptsReturn = True
        Me._txtShTk_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_2.Location = New System.Drawing.Point(144, 387)
        Me._txtShTk_2.MaxLength = 12
        Me._txtShTk_2.Name = "_txtShTk_2"
        Me._txtShTk_2.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_2.TabIndex = 28
        Me._txtShTk_2.Tag = "0"
        Me._txtShTk_2.Text = "1422"
        '
        '_txtShTk_1
        '
        Me._txtShTk_1.AcceptsReturn = True
        Me._txtShTk_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_1.Location = New System.Drawing.Point(639, 387)
        Me._txtShTk_1.MaxLength = 12
        Me._txtShTk_1.Name = "_txtShTk_1"
        Me._txtShTk_1.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_1.TabIndex = 35
        Me._txtShTk_1.Tag = "0"
        Me._txtShTk_1.Text = "33332"
        '
        '_txtShTk_0
        '
        Me._txtShTk_0.AcceptsReturn = True
        Me._txtShTk_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_0.Location = New System.Drawing.Point(144, 363)
        Me._txtShTk_0.MaxLength = 12
        Me._txtShTk_0.Name = "_txtShTk_0"
        Me._txtShTk_0.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_0.TabIndex = 26
        Me._txtShTk_0.Tag = "0"
        Me._txtShTk_0.Text = "1521"
        '
        '_txtTon_9
        '
        Me._txtTon_9.AcceptsReturn = True
        Me._txtTon_9.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_9.Location = New System.Drawing.Point(696, 296)
        Me._txtTon_9.MaxLength = 20
        Me._txtTon_9.Name = "_txtTon_9"
        Me._txtTon_9.Size = New System.Drawing.Size(89, 20)
        Me._txtTon_9.TabIndex = 16
        '
        '_txtTon_8
        '
        Me._txtTon_8.AcceptsReturn = True
        Me._txtTon_8.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_8.Location = New System.Drawing.Point(672, 296)
        Me._txtTon_8.MaxLength = 20
        Me._txtTon_8.Name = "_txtTon_8"
        Me._txtTon_8.Size = New System.Drawing.Size(25, 20)
        Me._txtTon_8.TabIndex = 15
        Me._txtTon_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtTon_7
        '
        Me._txtTon_7.AcceptsReturn = True
        Me._txtTon_7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._txtTon_7.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_7.Location = New System.Drawing.Point(544, 296)
        Me._txtTon_7.MaxLength = 20
        Me._txtTon_7.Name = "_txtTon_7"
        Me._txtTon_7.Size = New System.Drawing.Size(129, 20)
        Me._txtTon_7.TabIndex = 14
        Me._txtTon_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtTon_6
        '
        Me._txtTon_6.AcceptsReturn = True
        Me._txtTon_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_6.Location = New System.Drawing.Point(440, 296)
        Me._txtTon_6.MaxLength = 20
        Me._txtTon_6.Name = "_txtTon_6"
        Me._txtTon_6.Size = New System.Drawing.Size(105, 20)
        Me._txtTon_6.TabIndex = 13
        Me._txtTon_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtTon_5
        '
        Me._txtTon_5.AcceptsReturn = True
        Me._txtTon_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_5.Location = New System.Drawing.Point(320, 296)
        Me._txtTon_5.MaxLength = 20
        Me._txtTon_5.Name = "_txtTon_5"
        Me._txtTon_5.Size = New System.Drawing.Size(57, 20)
        Me._txtTon_5.TabIndex = 11
        Me._txtTon_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtTon_4
        '
        Me._txtTon_4.AcceptsReturn = True
        Me._txtTon_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_4.Location = New System.Drawing.Point(376, 296)
        Me._txtTon_4.MaxLength = 20
        Me._txtTon_4.Name = "_txtTon_4"
        Me._txtTon_4.Size = New System.Drawing.Size(65, 20)
        Me._txtTon_4.TabIndex = 12
        Me._txtTon_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtTon_3
        '
        Me._txtTon_3.AcceptsReturn = True
        Me._txtTon_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_3.Location = New System.Drawing.Point(304, 296)
        Me._txtTon_3.MaxLength = 20
        Me._txtTon_3.Name = "_txtTon_3"
        Me._txtTon_3.Size = New System.Drawing.Size(17, 20)
        Me._txtTon_3.TabIndex = 10
        '
        '_Cbo_0
        '
        Me._Cbo_0.BackColor = System.Drawing.SystemColors.Window
        Me._Cbo_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Cbo_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Cbo_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Cbo_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cbo_0.Location = New System.Drawing.Point(96, 4)
        Me._Cbo_0.Name = "_Cbo_0"
        Me._Cbo_0.Size = New System.Drawing.Size(73, 21)
        Me._Cbo_0.TabIndex = 0
        '
        '_txtTon_14
        '
        Me._txtTon_14.AcceptsReturn = True
        Me._txtTon_14.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_14.Location = New System.Drawing.Point(416, 8)
        Me._txtTon_14.MaxLength = 20
        Me._txtTon_14.Multiline = True
        Me._txtTon_14.Name = "_txtTon_14"
        Me._txtTon_14.Size = New System.Drawing.Size(81, 19)
        Me._txtTon_14.TabIndex = 1
        Me._txtTon_14.Text = "0"
        Me._txtTon_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtTon_10
        '
        Me._txtTon_10.AcceptsReturn = True
        Me._txtTon_10.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_10.Location = New System.Drawing.Point(896, 296)
        Me._txtTon_10.MaxLength = 20
        Me._txtTon_10.Name = "_txtTon_10"
        Me._txtTon_10.ReadOnly = True
        Me._txtTon_10.Size = New System.Drawing.Size(95, 20)
        Me._txtTon_10.TabIndex = 19
        Me._txtTon_10.TabStop = False
        Me._txtTon_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtTon_2
        '
        Me._txtTon_2.AcceptsReturn = True
        Me._txtTon_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_2.Location = New System.Drawing.Point(256, 296)
        Me._txtTon_2.MaxLength = 20
        Me._txtTon_2.Name = "_txtTon_2"
        Me._txtTon_2.ReadOnly = True
        Me._txtTon_2.Size = New System.Drawing.Size(49, 20)
        Me._txtTon_2.TabIndex = 9
        Me._txtTon_2.TabStop = False
        '
        '_txtTon_1
        '
        Me._txtTon_1.AcceptsReturn = True
        Me._txtTon_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_1.Location = New System.Drawing.Point(88, 296)
        Me._txtTon_1.MaxLength = 50
        Me._txtTon_1.Name = "_txtTon_1"
        Me._txtTon_1.ReadOnly = True
        Me._txtTon_1.Size = New System.Drawing.Size(169, 20)
        Me._txtTon_1.TabIndex = 8
        Me._txtTon_1.TabStop = False
        '
        '_txtTon_0
        '
        Me._txtTon_0.AcceptsReturn = True
        Me._txtTon_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtTon_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtTon_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtTon_0.Location = New System.Drawing.Point(8, 296)
        Me._txtTon_0.MaxLength = 20
        Me._txtTon_0.Name = "_txtTon_0"
        Me._txtTon_0.Size = New System.Drawing.Size(81, 20)
        Me._txtTon_0.TabIndex = 7
        Me._txtTon_0.Tag = "-1"
        '
        '_Cbo_1
        '
        Me._Cbo_1.BackColor = System.Drawing.SystemColors.Window
        Me._Cbo_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Cbo_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._Cbo_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Cbo_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cbo_1.Location = New System.Drawing.Point(96, 35)
        Me._Cbo_1.Name = "_Cbo_1"
        Me._Cbo_1.Size = New System.Drawing.Size(177, 21)
        Me._Cbo_1.TabIndex = 2
        '
        '_Label_27
        '
        Me._Label_27.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_27.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_27.ForeColor = System.Drawing.Color.Black
        Me._Label_27.Location = New System.Drawing.Point(784, 64)
        Me._Label_27.Name = "_Label_27"
        Me._Label_27.Size = New System.Drawing.Size(113, 17)
        Me._Label_27.TabIndex = 69
        Me._Label_27.Tag = "Excise tax"
        Me._Label_27.Text = "Thuế tiêu thụ ĐB"
        Me._Label_27.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_26
        '
        Me._Label_26.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_26.ForeColor = System.Drawing.Color.Black
        Me._Label_26.Location = New System.Drawing.Point(784, 80)
        Me._Label_26.Name = "_Label_26"
        Me._Label_26.Size = New System.Drawing.Size(25, 17)
        Me._Label_26.TabIndex = 68
        Me._Label_26.Text = "%"
        Me._Label_26.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_25
        '
        Me._Label_25.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_25.ForeColor = System.Drawing.Color.Black
        Me._Label_25.Location = New System.Drawing.Point(808, 80)
        Me._Label_25.Name = "_Label_25"
        Me._Label_25.Size = New System.Drawing.Size(89, 17)
        Me._Label_25.TabIndex = 67
        Me._Label_25.Tag = "Amount"
        Me._Label_25.Text = "Số tiền"
        Me._Label_25.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_LbTenTk_3
        '
        Me._LbTenTk_3.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_3.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_3.Location = New System.Drawing.Point(767, 363)
        Me._LbTenTk_3.Name = "_LbTenTk_3"
        Me._LbTenTk_3.Size = New System.Drawing.Size(225, 17)
        Me._LbTenTk_3.TabIndex = 66
        Me._LbTenTk_3.Tag = "1"
        '
        '_Label_16
        '
        Me._Label_16.BackColor = System.Drawing.Color.Transparent
        Me._Label_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_16.Location = New System.Drawing.Point(503, 363)
        Me._Label_16.Name = "_Label_16"
        Me._Label_16.Size = New System.Drawing.Size(129, 17)
        Me._Label_16.TabIndex = 65
        Me._Label_16.Tag = "Account of Excise tax "
        Me._Label_16.Text = "Thuế tiêu thụ đặc biệt"
        '
        '_Label_24
        '
        Me._Label_24.BackColor = System.Drawing.Color.Transparent
        Me._Label_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_24.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_24.Location = New System.Drawing.Point(320, 35)
        Me._Label_24.Name = "_Label_24"
        Me._Label_24.Size = New System.Drawing.Size(73, 17)
        Me._Label_24.TabIndex = 64
        Me._Label_24.Tag = "Allocated by"
        Me._Label_24.Text = "Phân bổ theo"
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.Color.Black
        Me._Label_13.Location = New System.Drawing.Point(896, 64)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(95, 33)
        Me._Label_13.TabIndex = 39
        Me._Label_13.Tag = "Cost"
        Me._Label_13.Text = "Chi phí"
        Me._Label_13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_12
        '
        Me._Label_12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.Color.Black
        Me._Label_12.Location = New System.Drawing.Point(696, 80)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.Size = New System.Drawing.Size(89, 17)
        Me._Label_12.TabIndex = 38
        Me._Label_12.Tag = "Amount"
        Me._Label_12.Text = "Số tiền"
        Me._Label_12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.Color.Black
        Me._Label_11.Location = New System.Drawing.Point(672, 80)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(25, 17)
        Me._Label_11.TabIndex = 37
        Me._Label_11.Text = "%"
        Me._Label_11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_9
        '
        Me._Label_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.Color.Black
        Me._Label_9.Location = New System.Drawing.Point(672, 64)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.Size = New System.Drawing.Size(113, 17)
        Me._Label_9.TabIndex = 35
        Me._Label_9.Tag = "Import tax"
        Me._Label_9.Text = "Thuế nhập khẩu"
        Me._Label_9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.Color.Black
        Me._Label_5.Location = New System.Drawing.Point(544, 64)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(129, 33)
        Me._Label_5.TabIndex = 31
        Me._Label_5.Tag = "Amount VND"
        Me._Label_5.Text = "Thành tiền VND"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_20
        '
        Me._Label_20.BackColor = System.Drawing.Color.Transparent
        Me._Label_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_20.Location = New System.Drawing.Point(8, 387)
        Me._Label_20.Name = "_Label_20"
        Me._Label_20.Size = New System.Drawing.Size(129, 17)
        Me._Label_20.TabIndex = 57
        Me._Label_20.Tag = "Cost account"
        Me._Label_20.Text = "Chi phí khác"
        '
        '_Label_19
        '
        Me._Label_19.BackColor = System.Drawing.Color.Transparent
        Me._Label_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_19.Location = New System.Drawing.Point(503, 387)
        Me._Label_19.Name = "_Label_19"
        Me._Label_19.Size = New System.Drawing.Size(129, 17)
        Me._Label_19.TabIndex = 56
        Me._Label_19.Tag = "Account of Import tax"
        Me._Label_19.Text = "Thuế nhập khẩu"
        '
        '_Label_18
        '
        Me._Label_18.BackColor = System.Drawing.Color.Transparent
        Me._Label_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_18.Location = New System.Drawing.Point(8, 363)
        Me._Label_18.Name = "_Label_18"
        Me._Label_18.Size = New System.Drawing.Size(135, 17)
        Me._Label_18.TabIndex = 55
        Me._Label_18.Tag = "Goods account"
        Me._Label_18.Text = "Tài khoản ghi nợ hàng hoá"
        '
        '_LbTenTk_2
        '
        Me._LbTenTk_2.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_2.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_2.Location = New System.Drawing.Point(272, 387)
        Me._LbTenTk_2.Name = "_LbTenTk_2"
        Me._LbTenTk_2.Size = New System.Drawing.Size(225, 17)
        Me._LbTenTk_2.TabIndex = 54
        Me._LbTenTk_2.Tag = "1"
        '
        '_LbTenTk_1
        '
        Me._LbTenTk_1.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_1.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_1.Location = New System.Drawing.Point(767, 387)
        Me._LbTenTk_1.Name = "_LbTenTk_1"
        Me._LbTenTk_1.Size = New System.Drawing.Size(225, 17)
        Me._LbTenTk_1.TabIndex = 53
        Me._LbTenTk_1.Tag = "1"
        '
        '_LbTenTk_0
        '
        Me._LbTenTk_0.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_0.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_0.Location = New System.Drawing.Point(272, 363)
        Me._LbTenTk_0.Name = "_LbTenTk_0"
        Me._LbTenTk_0.Size = New System.Drawing.Size(225, 17)
        Me._LbTenTk_0.TabIndex = 52
        Me._LbTenTk_0.Tag = "1"
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.ForeColor = System.Drawing.Color.Black
        Me._Label_17.Location = New System.Drawing.Point(304, 64)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(17, 33)
        Me._Label_17.TabIndex = 43
        Me._Label_17.Tag = "bill"
        Me._Label_17.Text = "PN"
        Me._Label_17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_15
        '
        Me._Label_15.BackColor = System.Drawing.Color.Transparent
        Me._Label_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_15.Location = New System.Drawing.Point(16, 8)
        Me._Label_15.Name = "_Label_15"
        Me._Label_15.Size = New System.Drawing.Size(50, 17)
        Me._Label_15.TabIndex = 40
        Me._Label_15.Tag = "Month"
        Me._Label_15.Text = "Tháng"
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.Color.Black
        Me._Label_10.Location = New System.Drawing.Point(8, 64)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(297, 17)
        Me._Label_10.TabIndex = 36
        Me._Label_10.Tag = "Material"
        Me._Label_10.Text = "Vật tư"
        Me._Label_10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.Color.Black
        Me._Label_8.Location = New System.Drawing.Point(440, 64)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(105, 33)
        Me._Label_8.TabIndex = 34
        Me._Label_8.Tag = "Amount of foreign currency"
        Me._Label_8.Text = "Thành tiền NT"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(376, 64)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(65, 33)
        Me._Label_7.TabIndex = 33
        Me._Label_7.Tag = "Unit of exchange"
        Me._Label_7.Text = "Đơn giá ngoại tệ"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.Transparent
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_6.Location = New System.Drawing.Point(320, 8)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(89, 17)
        Me._Label_6.TabIndex = 32
        Me._Label_6.Tag = "Tax rate"
        Me._Label_6.Text = "Tỷ giá tính thuế"
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(320, 64)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(57, 33)
        Me._Label_4.TabIndex = 30
        Me._Label_4.Tag = "Quantity"
        Me._Label_4.Text = "Số lượng"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.Color.Black
        Me._Label_3.Location = New System.Drawing.Point(256, 80)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(49, 17)
        Me._Label_3.TabIndex = 29
        Me._Label_3.Tag = "Unit"
        Me._Label_3.Text = "Đ.v.t"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.Black
        Me._Label_2.Location = New System.Drawing.Point(88, 80)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(169, 17)
        Me._Label_2.TabIndex = 28
        Me._Label_2.Tag = "Name"
        Me._Label_2.Text = "Tên vật tư"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.Color.Black
        Me._Label_1.Location = New System.Drawing.Point(8, 80)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(81, 17)
        Me._Label_1.TabIndex = 27
        Me._Label_1.Tag = "Code"
        Me._Label_1.Text = "Số hiệu"
        Me._Label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(16, 35)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(79, 17)
        Me._Label_0.TabIndex = 26
        Me._Label_0.Tag = "Contract code"
        Me._Label_0.Text = "Số hiệu tờ khai"
        '
        'LbThue
        '
        Me.LbThue.BackColor = System.Drawing.Color.Transparent
        Me.LbThue.Cursor = System.Windows.Forms.Cursors.Default
        Me.LbThue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbThue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LbThue.Location = New System.Drawing.Point(672, 48)
        Me.LbThue.Name = "LbThue"
        Me.LbThue.Size = New System.Drawing.Size(105, 17)
        Me.LbThue.TabIndex = 42
        Me.LbThue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CP
        '
        Me.CP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CP.BackColor = System.Drawing.Color.Transparent
        Me.CP.Cursor = System.Windows.Forms.Cursors.Default
        Me.CP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CP.ForeColor = System.Drawing.Color.Blue
        Me.CP.Location = New System.Drawing.Point(896, 48)
        Me.CP.Name = "CP"
        Me.CP.Size = New System.Drawing.Size(89, 17)
        Me.CP.TabIndex = 41
        Me.CP.Text = "0"
        Me.CP.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LbThuedb
        '
        Me.LbThuedb.BackColor = System.Drawing.Color.Transparent
        Me.LbThuedb.Cursor = System.Windows.Forms.Cursors.Default
        Me.LbThuedb.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbThuedb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LbThuedb.Location = New System.Drawing.Point(784, 48)
        Me.LbThuedb.Name = "LbThuedb"
        Me.LbThuedb.Size = New System.Drawing.Size(105, 17)
        Me.LbThuedb.TabIndex = 70
        Me.LbThuedb.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_CmdTK_0
        '
        Me._CmdTK_0.Image = CType(resources.GetObject("_CmdTK_0.Image"), System.Drawing.Image)
        Me._CmdTK_0.Location = New System.Drawing.Point(238, 362)
        Me._CmdTK_0.Name = "_CmdTK_0"
        Me._CmdTK_0.Size = New System.Drawing.Size(24, 22)
        Me._CmdTK_0.TabIndex = 27
        '
        '_CmdTK_1
        '
        Me._CmdTK_1.Image = CType(resources.GetObject("_CmdTK_1.Image"), System.Drawing.Image)
        Me._CmdTK_1.Location = New System.Drawing.Point(733, 386)
        Me._CmdTK_1.Name = "_CmdTK_1"
        Me._CmdTK_1.Size = New System.Drawing.Size(24, 22)
        Me._CmdTK_1.TabIndex = 36
        '
        '_CmdTK_2
        '
        Me._CmdTK_2.Image = CType(resources.GetObject("_CmdTK_2.Image"), System.Drawing.Image)
        Me._CmdTK_2.Location = New System.Drawing.Point(238, 386)
        Me._CmdTK_2.Name = "_CmdTK_2"
        Me._CmdTK_2.Size = New System.Drawing.Size(24, 22)
        Me._CmdTK_2.TabIndex = 29
        '
        '_Command_0
        '
        Me._Command_0.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(936, 328)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 25
        Me._Command_0.Tag = "Return"
        Me._Command_0.Text = "Trở &về"
        '
        '_Command_1
        '
        Me._Command_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.report16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(776, 328)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 23
        Me._Command_1.Tag = "Preview"
        Me._Command_1.Text = "&Xem"
        '
        '_Command_2
        '
        Me._Command_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.print16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(856, 328)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 24
        Me._Command_2.Tag = "Print"
        Me._Command_2.Text = "&In"
        '
        '_Command_4
        '
        Me._Command_4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Command_4.Image = Global.UNET.My.Resources.Resources.tool16
        Me._Command_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_4.Location = New System.Drawing.Point(696, 328)
        Me._Command_4.Name = "_Command_4"
        Me._Command_4.Size = New System.Drawing.Size(73, 25)
        Me._Command_4.TabIndex = 22
        Me._Command_4.Tag = "Processing"
        Me._Command_4.Text = "Xử &lý"
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.tool16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(557, 328)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(133, 25)
        Me._Command_3.TabIndex = 21
        Me._Command_3.Tag = "Allocation"
        Me._Command_3.Text = "&Phân bổ tự động"
        '
        'CmdHD
        '
        Me.CmdHD.Image = Global.UNET.My.Resources.Resources.search2_16
        Me.CmdHD.Location = New System.Drawing.Point(277, 35)
        Me.CmdHD.Name = "CmdHD"
        Me.CmdHD.Size = New System.Drawing.Size(24, 22)
        Me.CmdHD.TabIndex = 3
        '
        '_CmdTK_3
        '
        Me._CmdTK_3.Image = CType(resources.GetObject("_CmdTK_3.Image"), System.Drawing.Image)
        Me._CmdTK_3.Location = New System.Drawing.Point(733, 362)
        Me._CmdTK_3.Name = "_CmdTK_3"
        Me._CmdTK_3.Size = New System.Drawing.Size(24, 22)
        Me._CmdTK_3.TabIndex = 34
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
        Me.Grd.GridLines = ListViewEx.GLGridLines.gridBoth
        Me.Grd.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me.Grd.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me.Grd.HeaderHeight = 0
        Me.Grd.HeaderVisible = False
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
        Me.Grd.Size = New System.Drawing.Size(1002, 202)
        Me.Grd.SortType = ListViewEx.SortTypes.InsertionSort
        Me.Grd.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.Grd.TabIndex = 6
        '
        '_CmdTK_4
        '
        Me._CmdTK_4.Image = CType(resources.GetObject("_CmdTK_4.Image"), System.Drawing.Image)
        Me._CmdTK_4.Location = New System.Drawing.Point(238, 410)
        Me._CmdTK_4.Name = "_CmdTK_4"
        Me._CmdTK_4.Size = New System.Drawing.Size(24, 22)
        Me._CmdTK_4.TabIndex = 31
        '
        '_txtShTk_4
        '
        Me._txtShTk_4.AcceptsReturn = True
        Me._txtShTk_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_4.Location = New System.Drawing.Point(144, 411)
        Me._txtShTk_4.MaxLength = 12
        Me._txtShTk_4.Name = "_txtShTk_4"
        Me._txtShTk_4.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_4.TabIndex = 30
        Me._txtShTk_4.Tag = "0"
        Me._txtShTk_4.Text = "133121"
        '
        '_Label_28
        '
        Me._Label_28.BackColor = System.Drawing.Color.Transparent
        Me._Label_28.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_28.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_28.Location = New System.Drawing.Point(8, 411)
        Me._Label_28.Name = "_Label_28"
        Me._Label_28.Size = New System.Drawing.Size(129, 17)
        Me._Label_28.TabIndex = 74
        Me._Label_28.Tag = "VAT account"
        Me._Label_28.Text = "Thuế GTGT "
        '
        '_LbTenTk_4
        '
        Me._LbTenTk_4.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_4.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_4.Location = New System.Drawing.Point(272, 414)
        Me._LbTenTk_4.Name = "_LbTenTk_4"
        Me._LbTenTk_4.Size = New System.Drawing.Size(225, 17)
        Me._LbTenTk_4.TabIndex = 73
        Me._LbTenTk_4.Tag = "1"
        '
        '_CmdTK_5
        '
        Me._CmdTK_5.Image = CType(resources.GetObject("_CmdTK_5.Image"), System.Drawing.Image)
        Me._CmdTK_5.Location = New System.Drawing.Point(733, 410)
        Me._CmdTK_5.Name = "_CmdTK_5"
        Me._CmdTK_5.Size = New System.Drawing.Size(24, 22)
        Me._CmdTK_5.TabIndex = 38
        '
        '_txtShTk_5
        '
        Me._txtShTk_5.AcceptsReturn = True
        Me._txtShTk_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_5.Location = New System.Drawing.Point(639, 411)
        Me._txtShTk_5.MaxLength = 12
        Me._txtShTk_5.Name = "_txtShTk_5"
        Me._txtShTk_5.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_5.TabIndex = 37
        Me._txtShTk_5.Tag = "0"
        Me._txtShTk_5.Text = "333121"
        '
        '_Label_29
        '
        Me._Label_29.BackColor = System.Drawing.Color.Transparent
        Me._Label_29.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_29.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_29.Location = New System.Drawing.Point(503, 411)
        Me._Label_29.Name = "_Label_29"
        Me._Label_29.Size = New System.Drawing.Size(129, 17)
        Me._Label_29.TabIndex = 78
        Me._Label_29.Tag = "Account of import VAT "
        Me._Label_29.Text = "Thuế GTGT nhập khẩu"
        '
        '_LbTenTk_5
        '
        Me._LbTenTk_5.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_5.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_5.Location = New System.Drawing.Point(767, 411)
        Me._LbTenTk_5.Name = "_LbTenTk_5"
        Me._LbTenTk_5.Size = New System.Drawing.Size(225, 17)
        Me._LbTenTk_5.TabIndex = 77
        Me._LbTenTk_5.Tag = "1"
        '
        'TxtThueSuat
        '
        Me.TxtThueSuat.AcceptsReturn = True
        Me.TxtThueSuat.BackColor = System.Drawing.SystemColors.Window
        Me.TxtThueSuat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtThueSuat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtThueSuat.Location = New System.Drawing.Point(144, 435)
        Me.TxtThueSuat.MaxLength = 12
        Me.TxtThueSuat.Name = "TxtThueSuat"
        Me.TxtThueSuat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtThueSuat.Size = New System.Drawing.Size(89, 20)
        Me.TxtThueSuat.TabIndex = 32
        Me.TxtThueSuat.Tag = "0"
        Me.TxtThueSuat.Text = "10"
        '
        'LBThueSuat
        '
        Me.LBThueSuat.BackColor = System.Drawing.Color.Transparent
        Me.LBThueSuat.Cursor = System.Windows.Forms.Cursors.Default
        Me.LBThueSuat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBThueSuat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBThueSuat.Location = New System.Drawing.Point(8, 435)
        Me.LBThueSuat.Name = "LBThueSuat"
        Me.LBThueSuat.Size = New System.Drawing.Size(129, 17)
        Me.LBThueSuat.TabIndex = 80
        Me.LBThueSuat.Tag = "Rate"
        Me.LBThueSuat.Text = "Thuế suất (%)"
        '
        '_OptNoiDia_
        '
        Me._OptNoiDia_.BackColor = System.Drawing.Color.Transparent
        Me._OptNoiDia_.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptNoiDia_.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptNoiDia_.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptNoiDia_.Location = New System.Drawing.Point(6, 25)
        Me._OptNoiDia_.Name = "_OptNoiDia_"
        Me._OptNoiDia_.Size = New System.Drawing.Size(81, 17)
        Me._OptNoiDia_.TabIndex = 82
        Me._OptNoiDia_.Tag = "Domestic"
        Me._OptNoiDia_.Text = "Nội địa"
        Me._OptNoiDia_.UseVisualStyleBackColor = False
        '
        '_OptNhapKhau_
        '
        Me._OptNhapKhau_.BackColor = System.Drawing.Color.Transparent
        Me._OptNhapKhau_.Checked = True
        Me._OptNhapKhau_.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptNhapKhau_.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._OptNhapKhau_.ForeColor = System.Drawing.SystemColors.ControlText
        Me._OptNhapKhau_.Location = New System.Drawing.Point(6, 7)
        Me._OptNhapKhau_.Name = "_OptNhapKhau_"
        Me._OptNhapKhau_.Size = New System.Drawing.Size(81, 17)
        Me._OptNhapKhau_.TabIndex = 81
        Me._OptNhapKhau_.TabStop = True
        Me._OptNhapKhau_.Tag = "Imports"
        Me._OptNhapKhau_.Text = "Nhập khẩu"
        Me._OptNhapKhau_.UseVisualStyleBackColor = False
        '
        'FNhap
        '
        Me.FNhap.BackColor = System.Drawing.Color.Transparent
        Me.FNhap.Controls.Add(Me._OptPB_0)
        Me.FNhap.Controls.Add(Me._OptPB_1)
        Me.FNhap.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNhap.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FNhap.Location = New System.Drawing.Point(416, 29)
        Me.FNhap.Name = "FNhap"
        Me.FNhap.Size = New System.Drawing.Size(165, 27)
        Me.FNhap.TabIndex = 116
        Me.FNhap.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me._OptNhapKhau_)
        Me.GroupBox1.Controls.Add(Me._OptNoiDia_)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(8, 316)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(114, 45)
        Me.GroupBox1.TabIndex = 117
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'CPGV
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1018, 465)
        Me.Controls.Add(Me.Grd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FNhap)
        Me.Controls.Add(Me._txtTon_0)
        Me.Controls.Add(Me._txtTon_1)
        Me.Controls.Add(Me._txtTon_2)
        Me.Controls.Add(Me._txtTon_3)
        Me.Controls.Add(Me._txtTon_5)
        Me.Controls.Add(Me._txtTon_4)
        Me.Controls.Add(Me._txtTon_6)
        Me.Controls.Add(Me._txtTon_7)
        Me.Controls.Add(Me._txtTon_8)
        Me.Controls.Add(Me._txtTon_9)
        Me.Controls.Add(Me._txtTon_11)
        Me.Controls.Add(Me._txtTon_12)
        Me.Controls.Add(Me._txtTon_10)
        Me.Controls.Add(Me.cmdCT)
        Me.Controls.Add(Me.LBThueSuat)
        Me.Controls.Add(Me.TxtThueSuat)
        Me.Controls.Add(Me._CmdTK_5)
        Me.Controls.Add(Me._txtShTk_5)
        Me.Controls.Add(Me._Label_29)
        Me.Controls.Add(Me._LbTenTk_5)
        Me.Controls.Add(Me._CmdTK_4)
        Me.Controls.Add(Me._txtShTk_4)
        Me.Controls.Add(Me._Label_28)
        Me.Controls.Add(Me._LbTenTk_4)
        Me.Controls.Add(Me._txtShTk_3)
        Me.Controls.Add(Me._CmdTK_0)
        Me.Controls.Add(Me._CmdTK_1)
        Me.Controls.Add(Me._CmdTK_2)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_4)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me.CmdHD)
        Me.Controls.Add(Me._txtShTk_2)
        Me.Controls.Add(Me._txtShTk_1)
        Me.Controls.Add(Me._txtShTk_0)
        Me.Controls.Add(Me._Cbo_0)
        Me.Controls.Add(Me._txtTon_14)
        Me.Controls.Add(Me._Cbo_1)
        Me.Controls.Add(Me._CmdTK_3)
        Me.Controls.Add(Me._Label_27)
        Me.Controls.Add(Me._Label_26)
        Me.Controls.Add(Me._Label_25)
        Me.Controls.Add(Me._LbTenTk_3)
        Me.Controls.Add(Me._Label_16)
        Me.Controls.Add(Me._Label_24)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me._Label_12)
        Me.Controls.Add(Me._Label_11)
        Me.Controls.Add(Me._Label_9)
        Me.Controls.Add(Me._Label_5)
        Me.Controls.Add(Me._Label_20)
        Me.Controls.Add(Me._Label_19)
        Me.Controls.Add(Me._Label_18)
        Me.Controls.Add(Me._LbTenTk_2)
        Me.Controls.Add(Me._LbTenTk_1)
        Me.Controls.Add(Me._LbTenTk_0)
        Me.Controls.Add(Me._Label_17)
        Me.Controls.Add(Me._Label_15)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me.LbThue)
        Me.Controls.Add(Me.CP)
        Me.Controls.Add(Me.LbThuedb)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(9, 68)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CPGV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Giá vốn hàng nhập kho"
        Me.FNhap.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Sub InitializetxtTon()
        Me.txtTon(12) = _txtTon_12
        Me.txtTon(11) = _txtTon_11
        Me.txtTon(9) = _txtTon_9
        Me.txtTon(8) = _txtTon_8
        Me.txtTon(7) = _txtTon_7
        Me.txtTon(6) = _txtTon_6
        Me.txtTon(5) = _txtTon_5
        Me.txtTon(4) = _txtTon_4
        Me.txtTon(3) = _txtTon_3
        Me.txtTon(14) = _txtTon_14
        Me.txtTon(10) = _txtTon_10
        Me.txtTon(2) = _txtTon_2
        Me.txtTon(1) = _txtTon_1
        Me.txtTon(0) = _txtTon_0
    End Sub
    Sub InitializetxtShTk()
        Me.txtShTk(5) = _txtShTk_5
        Me.txtShTk(4) = _txtShTk_4
        Me.txtShTk(3) = _txtShTk_3
        Me.txtShTk(2) = _txtShTk_2
        Me.txtShTk(1) = _txtShTk_1
        Me.txtShTk(0) = _txtShTk_0
    End Sub
    Sub InitializeOptPB()
        Me.OptPB(1) = _OptPB_1
        Me.OptPB(0) = _OptPB_0
    End Sub
    Sub InitializeLbTenTk()
        Me.LbTenTk(5) = _LbTenTk_5
        Me.LbTenTk(4) = _LbTenTk_4
        Me.LbTenTk(3) = _LbTenTk_3
        Me.LbTenTk(2) = _LbTenTk_2
        Me.LbTenTk(1) = _LbTenTk_1
        Me.LbTenTk(0) = _LbTenTk_0
    End Sub
    Sub InitializeLabel()
        Me.Label(29) = _Label_29
        Me.Label(28) = _Label_28
        Me.Label(27) = _Label_27
        Me.Label(26) = _Label_26
        Me.Label(25) = _Label_25
        Me.Label(16) = _Label_16
        Me.Label(24) = _Label_24
        Me.Label(13) = _Label_13
        Me.Label(12) = _Label_12
        Me.Label(11) = _Label_11
        Me.Label(9) = _Label_9
        Me.Label(5) = _Label_5
        Me.Label(20) = _Label_20
        Me.Label(19) = _Label_19
        Me.Label(18) = _Label_18
        Me.Label(17) = _Label_17
        Me.Label(15) = _Label_15
        Me.Label(10) = _Label_10
        Me.Label(8) = _Label_8
        Me.Label(7) = _Label_7
        Me.Label(6) = _Label_6
        Me.Label(4) = _Label_4
        Me.Label(3) = _Label_3
        Me.Label(2) = _Label_2
        Me.Label(1) = _Label_1
        Me.Label(0) = _Label_0
    End Sub
    Sub InitializeCommand()
        Me.Command(0) = _Command_0
        Me.Command(1) = _Command_1
        Me.Command(2) = _Command_2
        Me.Command(4) = _Command_4
        Me.Command(3) = _Command_3
    End Sub
    Sub InitializeCmdTK()
        Me.CmdTK(0) = _CmdTK_0
        Me.CmdTK(1) = _CmdTK_1
        Me.CmdTK(2) = _CmdTK_2
        Me.CmdTK(3) = _CmdTK_3
        Me.CmdTK(4) = _CmdTK_4
        Me.CmdTK(5) = _CmdTK_5
    End Sub
    Sub InitializeCbo()
        Me.Cbo(0) = _Cbo_0
        Me.Cbo(1) = _Cbo_1
    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents _CmdTK_4 As System.Windows.Forms.Button
    Private WithEvents _txtShTk_4 As System.Windows.Forms.TextBox
    Private WithEvents _Label_28 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_4 As System.Windows.Forms.Label
    Private WithEvents _CmdTK_5 As System.Windows.Forms.Button
    Private WithEvents _txtShTk_5 As System.Windows.Forms.TextBox
    Private WithEvents _Label_29 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_5 As System.Windows.Forms.Label
    Private WithEvents TxtThueSuat As System.Windows.Forms.TextBox
    Private WithEvents LBThueSuat As System.Windows.Forms.Label
    Private WithEvents _OptNoiDia_ As System.Windows.Forms.RadioButton
    Private WithEvents _OptNhapKhau_ As System.Windows.Forms.RadioButton
    Public WithEvents FNhap As System.Windows.Forms.GroupBox
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
#End Region
End Class
