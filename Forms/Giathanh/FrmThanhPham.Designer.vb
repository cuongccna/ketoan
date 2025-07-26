<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmThanhPham
    Inherits Form

    Public formInitDone As Boolean = False

#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        ' Init components
        InitializeComponent()
        InitializetxtShTk()
        InitializetxtChuyen()
        Initializecmdtk1()
        Initializecmdtk()
        InitializeMNCon()
        InitializeLbTenTk()
        InitializeLbGia()
        InitializeLabel()
        InitializeCommand()
        InitializeCboKho()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Ctx_MN_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Ctx_MN.Opening
        Dim list As System.Collections.Generic.List(Of System.Windows.Forms.ToolStripItem) = New System.Collections.Generic.List(Of System.Windows.Forms.ToolStripItem)()
        Ctx_MN.Items.Clear()
        'We are moving the submenus FROM original menu to the context menu before displaying it
        For Each item As System.Windows.Forms.ToolStripItem In MN.DropDownItems
            list.Add(item)
        Next item
        For Each item As System.Windows.Forms.ToolStripItem In list
            Ctx_MN.Items.Add(item)
        Next item
        e.Cancel = False
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Ctx_MN_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosingEventArgs) Handles Ctx_MN.Closing
        Dim list As System.Collections.Generic.List(Of System.Windows.Forms.ToolStripItem) = New System.Collections.Generic.List(Of System.Windows.Forms.ToolStripItem)()
        'We are moving the submenus the context menu back to the original menu after displaying
        For Each item As System.Windows.Forms.ToolStripItem In Ctx_MN.Items
            list.Add(item)
        Next item
        For Each item As System.Windows.Forms.ToolStripItem In list
            MN.DropDownItems.Add(item)
        Next item
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
    Private WithEvents _MNCon_0 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents MN As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
    Public WithEvents cmdct As System.Windows.Forms.Button
    Public WithEvents Grd As ListViewEx.ListviewExt
    Private WithEvents _txtChuyen_16 As System.Windows.Forms.TextBox
    Private WithEvents _cmdtk_2 As System.Windows.Forms.Button
    Private WithEvents _cmdtk_1 As System.Windows.Forms.Button
    Private WithEvents _cmdtk_0 As System.Windows.Forms.Button
    Public WithEvents cmdtp As System.Windows.Forms.Button
    Private WithEvents _Command_4 As System.Windows.Forms.Button
    Private WithEvents _Command_5 As System.Windows.Forms.Button
    Private WithEvents _Command_6 As System.Windows.Forms.Button
    Public WithEvents Xem As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _txtChuyen_15 As System.Windows.Forms.TextBox
    Private WithEvents _txtChuyen_14 As System.Windows.Forms.TextBox
    Private WithEvents _txtChuyen_8 As System.Windows.Forms.TextBox
    Private WithEvents _txtChuyen_13 As System.Windows.Forms.TextBox
    Private WithEvents _txtChuyen_12 As System.Windows.Forms.TextBox
    Private WithEvents _txtChuyen_11 As System.Windows.Forms.TextBox
    Private WithEvents _txtChuyen_10 As System.Windows.Forms.TextBox
    Private WithEvents _txtChuyen_9 As System.Windows.Forms.TextBox
    Private WithEvents _txtShTk_3 As System.Windows.Forms.TextBox
    Public WithEvents TTXSX As System.Windows.Forms.TextBox
    Public WithEvents TXTNC As System.Windows.Forms.TextBox
    Public WithEvents TXTNVL As System.Windows.Forms.TextBox
    Private WithEvents _txtChuyen_5 As System.Windows.Forms.TextBox
    Private WithEvents _txtChuyen_4 As System.Windows.Forms.TextBox
    Private WithEvents _txtChuyen_6 As System.Windows.Forms.TextBox
    Private WithEvents _txtChuyen_1 As System.Windows.Forms.TextBox
    Public WithEvents XEM1 As System.Windows.Forms.Button
    Private WithEvents _txtChuyen_7 As System.Windows.Forms.TextBox
    Private WithEvents _txtShTk_0 As System.Windows.Forms.TextBox
    Public WithEvents TxtCT As System.Windows.Forms.TextBox
    Public WithEvents cmdtp1 As System.Windows.Forms.Button
    Public WithEvents Chk As System.Windows.Forms.CheckBox
    Private WithEvents _cmdtk1_2 As System.Windows.Forms.Button
    Private WithEvents _txtShTk_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtShTk_1 As System.Windows.Forms.TextBox
    Private WithEvents _cmdtk1_1 As System.Windows.Forms.Button
    Private WithEvents _cmdtk1_0 As System.Windows.Forms.Button
    Public WithEvents CboThang As ComboBoxEx.ComboBoxExt
    Public WithEvents CboSohieu As ComboBoxEx.ComboBoxExt
    Private WithEvents _txtChuyen_2 As System.Windows.Forms.TextBox
    Private WithEvents _txtChuyen_0 As System.Windows.Forms.TextBox
    Private WithEvents _CboKho_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboKho_0 As ComboBoxEx.ComboBoxExt
    Public WithEvents MedNgay As System.Windows.Forms.MaskedTextBox
    Private WithEvents _txtChuyen_3 As System.Windows.Forms.TextBox
    Private WithEvents _Command_7 As System.Windows.Forms.Button
    Private WithEvents _Label_32 As System.Windows.Forms.Label
    Private WithEvents _Label_31 As System.Windows.Forms.Label
    Private WithEvents _Label_30 As System.Windows.Forms.Label
    Private WithEvents _Label_29 As System.Windows.Forms.Label
    Private WithEvents _Label_28 As System.Windows.Forms.Label
    Private WithEvents _Label_27 As System.Windows.Forms.Label
    Private WithEvents _Label_26 As System.Windows.Forms.Label
    Private WithEvents _Label_25 As System.Windows.Forms.Label
    Private WithEvents _Label_24 As System.Windows.Forms.Label
    Private WithEvents _Label_22 As System.Windows.Forms.Label
    Private WithEvents _Label_23 As System.Windows.Forms.Label
    Private WithEvents _Label_21 As System.Windows.Forms.Label
    Private WithEvents _Label_20 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents _Label_19 As System.Windows.Forms.Label
    Private WithEvents _Label_18 As System.Windows.Forms.Label
    Private WithEvents _Label_17 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Public WithEvents LbCT As System.Windows.Forms.Label
    Private WithEvents _Label_9 As System.Windows.Forms.Label
    Private WithEvents _LbGia_2 As System.Windows.Forms.Label
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _LbGia_1 As System.Windows.Forms.Label
    Private WithEvents _LbGia_0 As System.Windows.Forms.Label
    Private WithEvents _Label_16 As System.Windows.Forms.Label
    Private WithEvents _Label_15 As System.Windows.Forms.Label
    Private WithEvents _Label_14 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_2 As System.Windows.Forms.Label
    Private WithEvents _Label_12 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_1 As System.Windows.Forms.Label
    Private WithEvents _LbTenTk_0 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Public CboKho(1) As ComboBoxEx.ComboBoxExt
    Public Command(8) As System.Windows.Forms.Button
    Public Label(32) As System.Windows.Forms.Label
    Public LbGia(3) As System.Windows.Forms.Label
    Public LbTenTk(2) As System.Windows.Forms.Label
    Public MNCon(0) As System.Windows.Forms.ToolStripMenuItem
    Public cmdtk(2) As System.Windows.Forms.Button
    Public cmdtk1(2) As System.Windows.Forms.Button
    Public txtChuyen(16) As System.Windows.Forms.TextBox
    Public txtShTk(3) As System.Windows.Forms.TextBox
    Public WithEvents Ctx_MN As System.Windows.Forms.ContextMenuStrip
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmThanhPham))
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip
        Me.MN = New System.Windows.Forms.ToolStripMenuItem
        Me._MNCon_0 = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdct = New System.Windows.Forms.Button
        Me._txtChuyen_16 = New System.Windows.Forms.TextBox
        Me._Command_4 = New System.Windows.Forms.Button
        Me.Xem = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Command_0 = New System.Windows.Forms.Button
        Me._txtChuyen_15 = New System.Windows.Forms.TextBox
        Me._txtChuyen_14 = New System.Windows.Forms.TextBox
        Me._txtChuyen_8 = New System.Windows.Forms.TextBox
        Me._txtChuyen_13 = New System.Windows.Forms.TextBox
        Me._txtChuyen_12 = New System.Windows.Forms.TextBox
        Me._txtChuyen_11 = New System.Windows.Forms.TextBox
        Me._txtChuyen_10 = New System.Windows.Forms.TextBox
        Me._txtChuyen_9 = New System.Windows.Forms.TextBox
        Me._txtShTk_3 = New System.Windows.Forms.TextBox
        Me.TTXSX = New System.Windows.Forms.TextBox
        Me.TXTNC = New System.Windows.Forms.TextBox
        Me.TXTNVL = New System.Windows.Forms.TextBox
        Me._txtChuyen_5 = New System.Windows.Forms.TextBox
        Me._txtChuyen_4 = New System.Windows.Forms.TextBox
        Me._txtChuyen_6 = New System.Windows.Forms.TextBox
        Me._txtChuyen_1 = New System.Windows.Forms.TextBox
        Me.XEM1 = New System.Windows.Forms.Button
        Me._txtChuyen_7 = New System.Windows.Forms.TextBox
        Me._txtShTk_0 = New System.Windows.Forms.TextBox
        Me.TxtCT = New System.Windows.Forms.TextBox
        Me.Chk = New System.Windows.Forms.CheckBox
        Me._txtShTk_2 = New System.Windows.Forms.TextBox
        Me._txtShTk_1 = New System.Windows.Forms.TextBox
        Me.CboThang = New ComboBoxEx.ComboBoxExt
        Me.CboSohieu = New ComboBoxEx.ComboBoxExt
        Me._txtChuyen_2 = New System.Windows.Forms.TextBox
        Me._txtChuyen_0 = New System.Windows.Forms.TextBox
        Me._CboKho_1 = New ComboBoxEx.ComboBoxExt
        Me._CboKho_0 = New ComboBoxEx.ComboBoxExt
        Me.MedNgay = New System.Windows.Forms.MaskedTextBox
        Me._txtChuyen_3 = New System.Windows.Forms.TextBox
        Me._Label_32 = New System.Windows.Forms.Label
        Me._Label_31 = New System.Windows.Forms.Label
        Me._Label_30 = New System.Windows.Forms.Label
        Me._Label_29 = New System.Windows.Forms.Label
        Me._Label_28 = New System.Windows.Forms.Label
        Me._Label_27 = New System.Windows.Forms.Label
        Me._Label_26 = New System.Windows.Forms.Label
        Me._Label_25 = New System.Windows.Forms.Label
        Me._Label_24 = New System.Windows.Forms.Label
        Me._Label_22 = New System.Windows.Forms.Label
        Me._Label_23 = New System.Windows.Forms.Label
        Me._Label_21 = New System.Windows.Forms.Label
        Me._Label_20 = New System.Windows.Forms.Label
        Me._Label_3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me._Label_19 = New System.Windows.Forms.Label
        Me._Label_18 = New System.Windows.Forms.Label
        Me._Label_17 = New System.Windows.Forms.Label
        Me._Label_4 = New System.Windows.Forms.Label
        Me._Label_13 = New System.Windows.Forms.Label
        Me.LbCT = New System.Windows.Forms.Label
        Me._Label_9 = New System.Windows.Forms.Label
        Me._LbGia_2 = New System.Windows.Forms.Label
        Me._Label_11 = New System.Windows.Forms.Label
        Me._LbGia_1 = New System.Windows.Forms.Label
        Me._LbGia_0 = New System.Windows.Forms.Label
        Me._Label_16 = New System.Windows.Forms.Label
        Me._Label_15 = New System.Windows.Forms.Label
        Me._Label_14 = New System.Windows.Forms.Label
        Me._LbTenTk_2 = New System.Windows.Forms.Label
        Me._Label_12 = New System.Windows.Forms.Label
        Me._LbTenTk_1 = New System.Windows.Forms.Label
        Me._LbTenTk_0 = New System.Windows.Forms.Label
        Me._Label_7 = New System.Windows.Forms.Label
        Me._Label_10 = New System.Windows.Forms.Label
        Me._Label_8 = New System.Windows.Forms.Label
        Me._Label_6 = New System.Windows.Forms.Label
        Me._Label_2 = New System.Windows.Forms.Label
        Me._Label_1 = New System.Windows.Forms.Label
        Me._Label_0 = New System.Windows.Forms.Label
        Me._Label_5 = New System.Windows.Forms.Label
        Me._cmdtk_2 = New System.Windows.Forms.Button
        Me._cmdtk_1 = New System.Windows.Forms.Button
        Me._cmdtk_0 = New System.Windows.Forms.Button
        Me.cmdtp = New System.Windows.Forms.Button
        Me._Command_5 = New System.Windows.Forms.Button
        Me._Command_6 = New System.Windows.Forms.Button
        Me.cmdtp1 = New System.Windows.Forms.Button
        Me._cmdtk1_2 = New System.Windows.Forms.Button
        Me._cmdtk1_1 = New System.Windows.Forms.Button
        Me._cmdtk1_0 = New System.Windows.Forms.Button
        Me._Command_7 = New System.Windows.Forms.Button
        Me.Grd = New ListViewEx.ListviewExt
        Me._LbGia_3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbodd = New ComboBoxEx.ComboBoxExt
        Me._Command_8 = New System.Windows.Forms.Button
        Me.MainMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MN})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(1025, 24)
        Me.MainMenu1.TabIndex = 102
        Me.MainMenu1.Visible = False
        '
        'MN
        '
        Me.MN.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._MNCon_0})
        Me.MN.Name = "MN"
        Me.MN.Size = New System.Drawing.Size(46, 20)
        Me.MN.Text = "Menu"
        '
        '_MNCon_0
        '
        Me._MNCon_0.Name = "_MNCon_0"
        Me._MNCon_0.Size = New System.Drawing.Size(119, 22)
        Me._MNCon_0.Text = "Định mức"
        '
        'cmdct
        '
        Me.cmdct.BackColor = System.Drawing.SystemColors.Control
        Me.cmdct.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdct.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdct.Image = Global.UNET.My.Resources.Resources.up16
        Me.cmdct.Location = New System.Drawing.Point(1005, 552)
        Me.cmdct.Name = "cmdct"
        Me.cmdct.Size = New System.Drawing.Size(17, 20)
        Me.cmdct.TabIndex = 33
        Me.cmdct.Tag = "-1"
        Me.cmdct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdct.UseVisualStyleBackColor = False
        '
        '_txtChuyen_16
        '
        Me._txtChuyen_16.AcceptsReturn = True
        Me._txtChuyen_16.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_16.Location = New System.Drawing.Point(924, 552)
        Me._txtChuyen_16.MaxLength = 20
        Me._txtChuyen_16.Name = "_txtChuyen_16"
        Me._txtChuyen_16.Size = New System.Drawing.Size(40, 20)
        Me._txtChuyen_16.TabIndex = 31
        Me._txtChuyen_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Command_4
        '
        Me._Command_4.Image = Global.UNET.My.Resources.Resources.report16
        Me._Command_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_4.Location = New System.Drawing.Point(611, 576)
        Me._Command_4.Name = "_Command_4"
        Me._Command_4.Size = New System.Drawing.Size(81, 25)
        Me._Command_4.TabIndex = 39
        Me._Command_4.Tag = "Preview Unf."
        Me._Command_4.Text = "Xem &DD"
        '
        'Xem
        '
        Me.Xem.Image = Global.UNET.My.Resources.Resources.report16
        Me.Xem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Xem.Location = New System.Drawing.Point(531, 576)
        Me.Xem.Name = "Xem"
        Me.Xem.Size = New System.Drawing.Size(73, 25)
        Me.Xem.TabIndex = 38
        Me.Xem.Tag = "Preview"
        Me.Xem.Text = "&Xem"
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(859, 576)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 41
        Me._Command_2.Tag = "Delete"
        Me._Command_2.Text = "&Xoá"
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(939, 576)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 42
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(779, 576)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 34
        Me._Command_1.Tag = "Save"
        Me._Command_1.Text = "&Ghi"
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.add16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(699, 576)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 40
        Me._Command_0.Tag = "Add"
        Me._Command_0.Text = "&Thêm"
        '
        '_txtChuyen_15
        '
        Me._txtChuyen_15.AcceptsReturn = True
        Me._txtChuyen_15.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_15.Location = New System.Drawing.Point(895, 552)
        Me._txtChuyen_15.MaxLength = 20
        Me._txtChuyen_15.Name = "_txtChuyen_15"
        Me._txtChuyen_15.ReadOnly = True
        Me._txtChuyen_15.Size = New System.Drawing.Size(30, 20)
        Me._txtChuyen_15.TabIndex = 30
        Me._txtChuyen_15.TabStop = False
        Me._txtChuyen_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtChuyen_14
        '
        Me._txtChuyen_14.AcceptsReturn = True
        Me._txtChuyen_14.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_14.Location = New System.Drawing.Point(856, 552)
        Me._txtChuyen_14.MaxLength = 20
        Me._txtChuyen_14.Name = "_txtChuyen_14"
        Me._txtChuyen_14.ReadOnly = True
        Me._txtChuyen_14.Size = New System.Drawing.Size(40, 20)
        Me._txtChuyen_14.TabIndex = 29
        Me._txtChuyen_14.TabStop = False
        Me._txtChuyen_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtChuyen_8
        '
        Me._txtChuyen_8.AcceptsReturn = True
        Me._txtChuyen_8.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_8.Location = New System.Drawing.Point(792, 552)
        Me._txtChuyen_8.MaxLength = 20
        Me._txtChuyen_8.Name = "_txtChuyen_8"
        Me._txtChuyen_8.ReadOnly = True
        Me._txtChuyen_8.Size = New System.Drawing.Size(65, 20)
        Me._txtChuyen_8.TabIndex = 28
        Me._txtChuyen_8.TabStop = False
        Me._txtChuyen_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtChuyen_13
        '
        Me._txtChuyen_13.AcceptsReturn = True
        Me._txtChuyen_13.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_13.Location = New System.Drawing.Point(728, 552)
        Me._txtChuyen_13.MaxLength = 20
        Me._txtChuyen_13.Name = "_txtChuyen_13"
        Me._txtChuyen_13.ReadOnly = True
        Me._txtChuyen_13.Size = New System.Drawing.Size(65, 20)
        Me._txtChuyen_13.TabIndex = 27
        Me._txtChuyen_13.TabStop = False
        Me._txtChuyen_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtChuyen_12
        '
        Me._txtChuyen_12.AcceptsReturn = True
        Me._txtChuyen_12.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_12.Location = New System.Drawing.Point(680, 552)
        Me._txtChuyen_12.MaxLength = 20
        Me._txtChuyen_12.Name = "_txtChuyen_12"
        Me._txtChuyen_12.ReadOnly = True
        Me._txtChuyen_12.Size = New System.Drawing.Size(49, 20)
        Me._txtChuyen_12.TabIndex = 26
        Me._txtChuyen_12.TabStop = False
        Me._txtChuyen_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtChuyen_11
        '
        Me._txtChuyen_11.AcceptsReturn = True
        Me._txtChuyen_11.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_11.Location = New System.Drawing.Point(624, 552)
        Me._txtChuyen_11.MaxLength = 20
        Me._txtChuyen_11.Name = "_txtChuyen_11"
        Me._txtChuyen_11.Size = New System.Drawing.Size(57, 20)
        Me._txtChuyen_11.TabIndex = 25
        Me._txtChuyen_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtChuyen_10
        '
        Me._txtChuyen_10.AcceptsReturn = True
        Me._txtChuyen_10.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_10.Location = New System.Drawing.Point(600, 552)
        Me._txtChuyen_10.MaxLength = 20
        Me._txtChuyen_10.Name = "_txtChuyen_10"
        Me._txtChuyen_10.Size = New System.Drawing.Size(25, 20)
        Me._txtChuyen_10.TabIndex = 24
        Me._txtChuyen_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtChuyen_9
        '
        Me._txtChuyen_9.AcceptsReturn = True
        Me._txtChuyen_9.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_9.Location = New System.Drawing.Point(547, 552)
        Me._txtChuyen_9.MaxLength = 20
        Me._txtChuyen_9.Name = "_txtChuyen_9"
        Me._txtChuyen_9.Size = New System.Drawing.Size(54, 20)
        Me._txtChuyen_9.TabIndex = 23
        '
        '_txtShTk_3
        '
        Me._txtShTk_3.AcceptsReturn = True
        Me._txtShTk_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_3.Location = New System.Drawing.Point(603, 88)
        Me._txtShTk_3.MaxLength = 12
        Me._txtShTk_3.Name = "_txtShTk_3"
        Me._txtShTk_3.Size = New System.Drawing.Size(25, 20)
        Me._txtShTk_3.TabIndex = 8
        Me._txtShTk_3.Tag = "0"
        Me._txtShTk_3.Text = "0"
        Me._txtShTk_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TTXSX
        '
        Me.TTXSX.AcceptsReturn = True
        Me.TTXSX.BackColor = System.Drawing.SystemColors.Window
        Me.TTXSX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TTXSX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TTXSX.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTXSX.Location = New System.Drawing.Point(942, 208)
        Me.TTXSX.MaxLength = 20
        Me.TTXSX.Multiline = True
        Me.TTXSX.Name = "TTXSX"
        Me.TTXSX.ReadOnly = True
        Me.TTXSX.Size = New System.Drawing.Size(81, 19)
        Me.TTXSX.TabIndex = 44
        Me.TTXSX.TabStop = False
        Me.TTXSX.Tag = "0"
        Me.TTXSX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TTXSX.Visible = False
        '
        'TXTNC
        '
        Me.TXTNC.AcceptsReturn = True
        Me.TXTNC.BackColor = System.Drawing.SystemColors.Window
        Me.TXTNC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTNC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTNC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNC.Location = New System.Drawing.Point(875, 208)
        Me.TXTNC.MaxLength = 20
        Me.TXTNC.Multiline = True
        Me.TXTNC.Name = "TXTNC"
        Me.TXTNC.ReadOnly = True
        Me.TXTNC.Size = New System.Drawing.Size(68, 19)
        Me.TXTNC.TabIndex = 43
        Me.TXTNC.TabStop = False
        Me.TXTNC.Tag = "0"
        Me.TXTNC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TXTNC.Visible = False
        '
        'TXTNVL
        '
        Me.TXTNVL.AcceptsReturn = True
        Me.TXTNVL.BackColor = System.Drawing.SystemColors.Window
        Me.TXTNVL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTNVL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTNVL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNVL.Location = New System.Drawing.Point(787, 208)
        Me.TXTNVL.MaxLength = 20
        Me.TXTNVL.Multiline = True
        Me.TXTNVL.Name = "TXTNVL"
        Me.TXTNVL.ReadOnly = True
        Me.TXTNVL.Size = New System.Drawing.Size(89, 19)
        Me.TXTNVL.TabIndex = 42
        Me.TXTNVL.TabStop = False
        Me.TXTNVL.Tag = "0"
        Me.TXTNVL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TXTNVL.Visible = False
        '
        '_txtChuyen_5
        '
        Me._txtChuyen_5.AcceptsReturn = True
        Me._txtChuyen_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_5.Location = New System.Drawing.Point(395, 552)
        Me._txtChuyen_5.MaxLength = 20
        Me._txtChuyen_5.Name = "_txtChuyen_5"
        Me._txtChuyen_5.ReadOnly = True
        Me._txtChuyen_5.Size = New System.Drawing.Size(76, 20)
        Me._txtChuyen_5.TabIndex = 21
        Me._txtChuyen_5.TabStop = False
        Me._txtChuyen_5.Tag = "0"
        Me._txtChuyen_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtChuyen_4
        '
        Me._txtChuyen_4.AcceptsReturn = True
        Me._txtChuyen_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_4.Location = New System.Drawing.Point(323, 552)
        Me._txtChuyen_4.MaxLength = 20
        Me._txtChuyen_4.Name = "_txtChuyen_4"
        Me._txtChuyen_4.Size = New System.Drawing.Size(73, 20)
        Me._txtChuyen_4.TabIndex = 20
        Me._txtChuyen_4.Tag = "0"
        Me._txtChuyen_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtChuyen_6
        '
        Me._txtChuyen_6.AcceptsReturn = True
        Me._txtChuyen_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_6.Location = New System.Drawing.Point(470, 552)
        Me._txtChuyen_6.MaxLength = 20
        Me._txtChuyen_6.Name = "_txtChuyen_6"
        Me._txtChuyen_6.ReadOnly = True
        Me._txtChuyen_6.Size = New System.Drawing.Size(78, 20)
        Me._txtChuyen_6.TabIndex = 22
        Me._txtChuyen_6.Tag = "0"
        Me._txtChuyen_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtChuyen_1
        '
        Me._txtChuyen_1.AcceptsReturn = True
        Me._txtChuyen_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_1.Location = New System.Drawing.Point(27, 552)
        Me._txtChuyen_1.MaxLength = 20
        Me._txtChuyen_1.Name = "_txtChuyen_1"
        Me._txtChuyen_1.Size = New System.Drawing.Size(65, 20)
        Me._txtChuyen_1.TabIndex = 17
        '
        'XEM1
        '
        Me.XEM1.BackColor = System.Drawing.Color.Silver
        Me.XEM1.Cursor = System.Windows.Forms.Cursors.Default
        Me.XEM1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XEM1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.XEM1.Location = New System.Drawing.Point(531, 576)
        Me.XEM1.Name = "XEM1"
        Me.XEM1.Size = New System.Drawing.Size(73, 25)
        Me.XEM1.TabIndex = 36
        Me.XEM1.TabStop = False
        Me.XEM1.Text = "XEM"
        Me.XEM1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.XEM1.UseVisualStyleBackColor = False
        Me.XEM1.Visible = False
        '
        '_txtChuyen_7
        '
        Me._txtChuyen_7.AcceptsReturn = True
        Me._txtChuyen_7.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_7.Location = New System.Drawing.Point(603, 112)
        Me._txtChuyen_7.MaxLength = 20
        Me._txtChuyen_7.Multiline = True
        Me._txtChuyen_7.Name = "_txtChuyen_7"
        Me._txtChuyen_7.ReadOnly = True
        Me._txtChuyen_7.Size = New System.Drawing.Size(153, 19)
        Me._txtChuyen_7.TabIndex = 9
        Me._txtChuyen_7.TabStop = False
        Me._txtChuyen_7.Tag = "0"
        Me._txtChuyen_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._txtChuyen_7.Visible = False
        '
        '_txtShTk_0
        '
        Me._txtShTk_0.AcceptsReturn = True
        Me._txtShTk_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_0.Location = New System.Drawing.Point(107, 163)
        Me._txtShTk_0.MaxLength = 12
        Me._txtShTk_0.Name = "_txtShTk_0"
        Me._txtShTk_0.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_0.TabIndex = 10
        Me._txtShTk_0.Tag = "0"
        '
        'TxtCT
        '
        Me.TxtCT.AcceptsReturn = True
        Me.TxtCT.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCT.Location = New System.Drawing.Point(67, 56)
        Me.TxtCT.MaxLength = 20
        Me.TxtCT.Name = "TxtCT"
        Me.TxtCT.Size = New System.Drawing.Size(129, 20)
        Me.TxtCT.TabIndex = 3
        Me.TxtCT.Tag = "0"
        '
        'Chk
        '
        Me.Chk.BackColor = System.Drawing.Color.Transparent
        Me.Chk.Checked = True
        Me.Chk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk.Location = New System.Drawing.Point(439, 60)
        Me.Chk.Name = "Chk"
        Me.Chk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Chk.Size = New System.Drawing.Size(147, 17)
        Me.Chk.TabIndex = 5
        Me.Chk.Tag = "Export Material FROM"
        Me.Chk.Text = "Tự động xuất NVL từ kho"
        Me.Chk.UseVisualStyleBackColor = False
        '
        '_txtShTk_2
        '
        Me._txtShTk_2.AcceptsReturn = True
        Me._txtShTk_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_2.Location = New System.Drawing.Point(107, 208)
        Me._txtShTk_2.MaxLength = 12
        Me._txtShTk_2.Name = "_txtShTk_2"
        Me._txtShTk_2.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_2.TabIndex = 14
        Me._txtShTk_2.Tag = "0"
        '
        '_txtShTk_1
        '
        Me._txtShTk_1.AcceptsReturn = True
        Me._txtShTk_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtShTk_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtShTk_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtShTk_1.Location = New System.Drawing.Point(107, 185)
        Me._txtShTk_1.MaxLength = 12
        Me._txtShTk_1.Name = "_txtShTk_1"
        Me._txtShTk_1.Size = New System.Drawing.Size(89, 20)
        Me._txtShTk_1.TabIndex = 12
        Me._txtShTk_1.Tag = "0"
        '
        'CboThang
        '
        Me.CboThang.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboThang.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboThang.Location = New System.Drawing.Point(67, 32)
        Me.CboThang.Name = "CboThang"
        Me.CboThang.Size = New System.Drawing.Size(129, 21)
        Me.CboThang.TabIndex = 0
        '
        'CboSohieu
        '
        Me.CboSohieu.BackColor = System.Drawing.SystemColors.Window
        Me.CboSohieu.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboSohieu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboSohieu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSohieu.Location = New System.Drawing.Point(603, 32)
        Me.CboSohieu.Name = "CboSohieu"
        Me.CboSohieu.Size = New System.Drawing.Size(153, 21)
        Me.CboSohieu.TabIndex = 2
        '
        '_txtChuyen_2
        '
        Me._txtChuyen_2.AcceptsReturn = True
        Me._txtChuyen_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_2.Location = New System.Drawing.Point(91, 552)
        Me._txtChuyen_2.MaxLength = 50
        Me._txtChuyen_2.Name = "_txtChuyen_2"
        Me._txtChuyen_2.ReadOnly = True
        Me._txtChuyen_2.Size = New System.Drawing.Size(189, 20)
        Me._txtChuyen_2.TabIndex = 18
        Me._txtChuyen_2.TabStop = False
        '
        '_txtChuyen_0
        '
        Me._txtChuyen_0.AcceptsReturn = True
        Me._txtChuyen_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_0.Location = New System.Drawing.Point(3, 552)
        Me._txtChuyen_0.MaxLength = 20
        Me._txtChuyen_0.Name = "_txtChuyen_0"
        Me._txtChuyen_0.Size = New System.Drawing.Size(25, 20)
        Me._txtChuyen_0.TabIndex = 16
        Me._txtChuyen_0.Text = "155"
        '
        '_CboKho_1
        '
        Me._CboKho_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboKho_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboKho_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboKho_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboKho_1.Enabled = False
        Me._CboKho_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboKho_1.Location = New System.Drawing.Point(603, 59)
        Me._CboKho_1.Name = "_CboKho_1"
        Me._CboKho_1.Size = New System.Drawing.Size(153, 21)
        Me._CboKho_1.TabIndex = 6
        '
        '_CboKho_0
        '
        Me._CboKho_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboKho_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboKho_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboKho_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboKho_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboKho_0.Location = New System.Drawing.Point(67, 80)
        Me._CboKho_0.Name = "_CboKho_0"
        Me._CboKho_0.Size = New System.Drawing.Size(129, 21)
        Me._CboKho_0.TabIndex = 7
        '
        'MedNgay
        '
        Me.MedNgay.AllowPromptAsInput = False
        Me.MedNgay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedNgay.Location = New System.Drawing.Point(383, 31)
        Me.MedNgay.Name = "MedNgay"
        Me.MedNgay.Size = New System.Drawing.Size(65, 20)
        Me.MedNgay.TabIndex = 1
        '
        '_txtChuyen_3
        '
        Me._txtChuyen_3.AcceptsReturn = True
        Me._txtChuyen_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtChuyen_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtChuyen_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtChuyen_3.Location = New System.Drawing.Point(279, 552)
        Me._txtChuyen_3.MaxLength = 20
        Me._txtChuyen_3.Name = "_txtChuyen_3"
        Me._txtChuyen_3.ReadOnly = True
        Me._txtChuyen_3.Size = New System.Drawing.Size(45, 20)
        Me._txtChuyen_3.TabIndex = 19
        Me._txtChuyen_3.TabStop = False
        Me._txtChuyen_3.Tag = "0"
        '
        '_Label_32
        '
        Me._Label_32.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_32.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_32.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._Label_32.Location = New System.Drawing.Point(963, 256)
        Me._Label_32.Name = "_Label_32"
        Me._Label_32.Size = New System.Drawing.Size(58, 17)
        Me._Label_32.TabIndex = 100
        Me._Label_32.Tag = ""
        Me._Label_32.Text = "%"
        Me._Label_32.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_31
        '
        Me._Label_31.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_31.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._Label_31.Location = New System.Drawing.Point(895, 256)
        Me._Label_31.Name = "_Label_31"
        Me._Label_31.Size = New System.Drawing.Size(30, 17)
        Me._Label_31.TabIndex = 99
        Me._Label_31.Tag = ""
        Me._Label_31.Text = "%"
        Me._Label_31.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_30
        '
        Me._Label_30.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_30.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._Label_30.Location = New System.Drawing.Point(924, 256)
        Me._Label_30.Name = "_Label_30"
        Me._Label_30.Size = New System.Drawing.Size(41, 17)
        Me._Label_30.TabIndex = 85
        Me._Label_30.Tag = "Quantity"
        Me._Label_30.Text = "Lượng"
        Me._Label_30.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_29
        '
        Me._Label_29.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_29.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._Label_29.Location = New System.Drawing.Point(856, 256)
        Me._Label_29.Name = "_Label_29"
        Me._Label_29.Size = New System.Drawing.Size(41, 17)
        Me._Label_29.TabIndex = 84
        Me._Label_29.Tag = "Quantity"
        Me._Label_29.Text = "Lượng"
        Me._Label_29.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_28
        '
        Me._Label_28.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_28.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._Label_28.Location = New System.Drawing.Point(856, 240)
        Me._Label_28.Name = "_Label_28"
        Me._Label_28.Size = New System.Drawing.Size(69, 17)
        Me._Label_28.TabIndex = 83
        Me._Label_28.Tag = "Beginning"
        Me._Label_28.Text = "DD đầu kỳ"
        Me._Label_28.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_27
        '
        Me._Label_27.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_27.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._Label_27.Location = New System.Drawing.Point(728, 240)
        Me._Label_27.Name = "_Label_27"
        Me._Label_27.Size = New System.Drawing.Size(65, 33)
        Me._Label_27.TabIndex = 82
        Me._Label_27.Tag = "Amount"
        Me._Label_27.Text = "Giá trị PL"
        Me._Label_27.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_26
        '
        Me._Label_26.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._Label_26.Location = New System.Drawing.Point(680, 240)
        Me._Label_26.Name = "_Label_26"
        Me._Label_26.Size = New System.Drawing.Size(49, 33)
        Me._Label_26.TabIndex = 81
        Me._Label_26.Tag = "Crap quantity"
        Me._Label_26.Text = "Lượng PL"
        Me._Label_26.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_25
        '
        Me._Label_25.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._Label_25.Location = New System.Drawing.Point(624, 240)
        Me._Label_25.Name = "_Label_25"
        Me._Label_25.Size = New System.Drawing.Size(57, 33)
        Me._Label_25.TabIndex = 80
        Me._Label_25.Tag = "Crap unit price"
        Me._Label_25.Text = "Đ.Giá PL"
        Me._Label_25.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_24
        '
        Me._Label_24.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._Label_24.Location = New System.Drawing.Point(600, 240)
        Me._Label_24.Name = "_Label_24"
        Me._Label_24.Size = New System.Drawing.Size(25, 33)
        Me._Label_24.TabIndex = 79
        Me._Label_24.Tag = "Rate"
        Me._Label_24.Text = "Tỷ Lệ %"
        Me._Label_24.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_22
        '
        Me._Label_22.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._Label_22.Location = New System.Drawing.Point(792, 240)
        Me._Label_22.Name = "_Label_22"
        Me._Label_22.Size = New System.Drawing.Size(65, 33)
        Me._Label_22.TabIndex = 78
        Me._Label_22.Tag = "Price"
        Me._Label_22.Text = "Giá bán TP"
        Me._Label_22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_23
        '
        Me._Label_23.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._Label_23.Location = New System.Drawing.Point(547, 240)
        Me._Label_23.Name = "_Label_23"
        Me._Label_23.Size = New System.Drawing.Size(54, 33)
        Me._Label_23.TabIndex = 77
        Me._Label_23.Tag = "Crap recovery"
        Me._Label_23.Text = "PLTH"
        Me._Label_23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_21
        '
        Me._Label_21.BackColor = System.Drawing.Color.Transparent
        Me._Label_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_21.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_21.Location = New System.Drawing.Point(635, 88)
        Me._Label_21.Name = "_Label_21"
        Me._Label_21.Size = New System.Drawing.Size(17, 17)
        Me._Label_21.TabIndex = 76
        Me._Label_21.Tag = "P. Cost Acc."
        Me._Label_21.Text = "%"
        '
        '_Label_20
        '
        Me._Label_20.BackColor = System.Drawing.Color.Transparent
        Me._Label_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_20.Location = New System.Drawing.Point(496, 89)
        Me._Label_20.Name = "_Label_20"
        Me._Label_20.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Label_20.Size = New System.Drawing.Size(89, 17)
        Me._Label_20.TabIndex = 75
        Me._Label_20.Tag = "Gradations"
        Me._Label_20.Text = "Tỷ lệ hao hụt"
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._Label_3.Location = New System.Drawing.Point(27, 240)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(65, 33)
        Me._Label_3.TabIndex = 73
        Me._Label_3.Tag = "Code"
        Me._Label_3.Text = "Thành phẩm"
        Me._Label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(875, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Chi phí Nhân công"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(939, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 71
        Me.Label1.Tag = "Amount"
        Me.Label1.Text = "Chi phí sản xuất"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Visible = False
        '
        '_Label_19
        '
        Me._Label_19.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_19.ForeColor = System.Drawing.Color.Black
        Me._Label_19.Location = New System.Drawing.Point(787, 184)
        Me._Label_19.Name = "_Label_19"
        Me._Label_19.Size = New System.Drawing.Size(89, 17)
        Me._Label_19.TabIndex = 70
        Me._Label_19.Tag = "Amount"
        Me._Label_19.Text = "Chi phí NVL"
        Me._Label_19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Label_19.Visible = False
        '
        '_Label_18
        '
        Me._Label_18.BackColor = System.Drawing.Color.Transparent
        Me._Label_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_18.Location = New System.Drawing.Point(547, 113)
        Me._Label_18.Name = "_Label_18"
        Me._Label_18.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Label_18.Size = New System.Drawing.Size(38, 17)
        Me._Label_18.TabIndex = 69
        Me._Label_18.Tag = "Ex. Rate"
        Me._Label_18.Text = "Tỷ giá"
        Me._Label_18.Visible = False
        '
        '_Label_17
        '
        Me._Label_17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._Label_17.Location = New System.Drawing.Point(397, 240)
        Me._Label_17.Name = "_Label_17"
        Me._Label_17.Size = New System.Drawing.Size(76, 33)
        Me._Label_17.TabIndex = 68
        Me._Label_17.Tag = "Unit price"
        Me._Label_17.Text = "Đơn giá"
        Me._Label_17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._Label_4.Location = New System.Drawing.Point(91, 240)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(190, 33)
        Me._Label_4.TabIndex = 47
        Me._Label_4.Tag = "Description"
        Me._Label_4.Text = "Diễn giải"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.Transparent
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_13.Location = New System.Drawing.Point(11, 58)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(49, 17)
        Me._Label_13.TabIndex = 67
        Me._Label_13.Tag = "Portion"
        Me._Label_13.Text = "Lô hàng"
        '
        'LbCT
        '
        Me.LbCT.BackColor = System.Drawing.Color.Transparent
        Me.LbCT.Cursor = System.Windows.Forms.Cursors.Default
        Me.LbCT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCT.ForeColor = System.Drawing.Color.Blue
        Me.LbCT.Location = New System.Drawing.Point(235, 59)
        Me.LbCT.Name = "LbCT"
        Me.LbCT.Size = New System.Drawing.Size(209, 25)
        Me.LbCT.TabIndex = 66
        Me.LbCT.Tag = "1"
        '
        '_Label_9
        '
        Me._Label_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._Label_9.Location = New System.Drawing.Point(3, 240)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.Size = New System.Drawing.Size(25, 33)
        Me._Label_9.TabIndex = 51
        Me._Label_9.Tag = "Account"
        Me._Label_9.Text = "Mã TK"
        Me._Label_9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_LbGia_2
        '
        Me._LbGia_2.BackColor = System.Drawing.Color.Transparent
        Me._LbGia_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbGia_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbGia_2.ForeColor = System.Drawing.Color.Blue
        Me._LbGia_2.Location = New System.Drawing.Point(380, 115)
        Me._LbGia_2.Name = "_LbGia_2"
        Me._LbGia_2.Size = New System.Drawing.Size(117, 17)
        Me._LbGia_2.TabIndex = 65
        Me._LbGia_2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.Transparent
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_11.Location = New System.Drawing.Point(235, 112)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(139, 17)
        Me._Label_11.TabIndex = 64
        Me._Label_11.Tag = "General Expenses"
        Me._Label_11.Text = "CP SX chung"
        '
        '_LbGia_1
        '
        Me._LbGia_1.BackColor = System.Drawing.Color.Transparent
        Me._LbGia_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbGia_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbGia_1.ForeColor = System.Drawing.Color.Blue
        Me._LbGia_1.Location = New System.Drawing.Point(107, 134)
        Me._LbGia_1.Name = "_LbGia_1"
        Me._LbGia_1.Size = New System.Drawing.Size(117, 17)
        Me._LbGia_1.TabIndex = 62
        Me._LbGia_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbGia_0
        '
        Me._LbGia_0.BackColor = System.Drawing.Color.Transparent
        Me._LbGia_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbGia_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbGia_0.ForeColor = System.Drawing.Color.Blue
        Me._LbGia_0.Location = New System.Drawing.Point(107, 112)
        Me._LbGia_0.Name = "_LbGia_0"
        Me._LbGia_0.Size = New System.Drawing.Size(117, 17)
        Me._LbGia_0.TabIndex = 61
        Me._LbGia_0.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_16
        '
        Me._Label_16.BackColor = System.Drawing.Color.Transparent
        Me._Label_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_16.Location = New System.Drawing.Point(11, 134)
        Me._Label_16.Name = "_Label_16"
        Me._Label_16.Size = New System.Drawing.Size(121, 17)
        Me._Label_16.TabIndex = 60
        Me._Label_16.Tag = "Labour Expenses"
        Me._Label_16.Text = "CP Nhân công"
        '
        '_Label_15
        '
        Me._Label_15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._Label_15.Location = New System.Drawing.Point(472, 240)
        Me._Label_15.Name = "_Label_15"
        Me._Label_15.Size = New System.Drawing.Size(78, 33)
        Me._Label_15.TabIndex = 59
        Me._Label_15.Tag = "Amount"
        Me._Label_15.Text = "Giá thành"
        Me._Label_15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_14
        '
        Me._Label_14.BackColor = System.Drawing.Color.Transparent
        Me._Label_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_14.Location = New System.Drawing.Point(11, 112)
        Me._Label_14.Name = "_Label_14"
        Me._Label_14.Size = New System.Drawing.Size(97, 17)
        Me._Label_14.TabIndex = 58
        Me._Label_14.Tag = "Material Expenses"
        Me._Label_14.Text = "CP NVL"
        '
        '_LbTenTk_2
        '
        Me._LbTenTk_2.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_2.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_2.Location = New System.Drawing.Point(235, 208)
        Me._LbTenTk_2.Name = "_LbTenTk_2"
        Me._LbTenTk_2.Size = New System.Drawing.Size(369, 17)
        Me._LbTenTk_2.TabIndex = 57
        Me._LbTenTk_2.Tag = "1"
        '
        '_Label_12
        '
        Me._Label_12.BackColor = System.Drawing.Color.Transparent
        Me._Label_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_12.Location = New System.Drawing.Point(11, 208)
        Me._Label_12.Name = "_Label_12"
        Me._Label_12.Size = New System.Drawing.Size(89, 17)
        Me._Label_12.TabIndex = 56
        Me._Label_12.Tag = "Labour Acc."
        Me._Label_12.Text = "TK chi phí NC"
        '
        '_LbTenTk_1
        '
        Me._LbTenTk_1.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_1.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_1.Location = New System.Drawing.Point(235, 185)
        Me._LbTenTk_1.Name = "_LbTenTk_1"
        Me._LbTenTk_1.Size = New System.Drawing.Size(369, 17)
        Me._LbTenTk_1.TabIndex = 55
        Me._LbTenTk_1.Tag = "1"
        '
        '_LbTenTk_0
        '
        Me._LbTenTk_0.BackColor = System.Drawing.Color.Transparent
        Me._LbTenTk_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTenTk_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbTenTk_0.ForeColor = System.Drawing.Color.Blue
        Me._LbTenTk_0.Location = New System.Drawing.Point(235, 163)
        Me._LbTenTk_0.Name = "_LbTenTk_0"
        Me._LbTenTk_0.Size = New System.Drawing.Size(369, 17)
        Me._LbTenTk_0.TabIndex = 54
        Me._LbTenTk_0.Tag = "1"
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.Transparent
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_7.Location = New System.Drawing.Point(11, 187)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(89, 17)
        Me._Label_7.TabIndex = 53
        Me._Label_7.Tag = "Material Acc."
        Me._Label_7.Text = "TK chi phí NVL"
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.Transparent
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_10.Location = New System.Drawing.Point(11, 168)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(89, 17)
        Me._Label_10.TabIndex = 52
        Me._Label_10.Tag = "P. Cost Acc."
        Me._Label_10.Text = "TK chi phí SXKD"
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.Transparent
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_8.Location = New System.Drawing.Point(528, 40)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(57, 17)
        Me._Label_8.TabIndex = 49
        Me._Label_8.Tag = "Code"
        Me._Label_8.Text = "Số hiệu"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._Label_6.Location = New System.Drawing.Point(323, 240)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(77, 33)
        Me._Label_6.TabIndex = 48
        Me._Label_6.Tag = "Quantity"
        Me._Label_6.Text = "Số lượng"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.Transparent
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_2.Location = New System.Drawing.Point(11, 34)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(49, 17)
        Me._Label_2.TabIndex = 46
        Me._Label_2.Tag = "Month"
        Me._Label_2.Text = "Tháng"
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(11, 80)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(49, 17)
        Me._Label_1.TabIndex = 45
        Me._Label_1.Tag = "Pro. Store"
        Me._Label_1.Text = "Kho TP"
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(344, 34)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(39, 17)
        Me._Label_0.TabIndex = 41
        Me._Label_0.Tag = "Date"
        Me._Label_0.Text = "Ngày"
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._Label_5.Location = New System.Drawing.Point(280, 240)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(45, 33)
        Me._Label_5.TabIndex = 74
        Me._Label_5.Tag = "Unit"
        Me._Label_5.Text = "Đ.v.t"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_cmdtk_2
        '
        Me._cmdtk_2.Image = CType(resources.GetObject("_cmdtk_2.Image"), System.Drawing.Image)
        Me._cmdtk_2.Location = New System.Drawing.Point(202, 208)
        Me._cmdtk_2.Name = "_cmdtk_2"
        Me._cmdtk_2.Size = New System.Drawing.Size(22, 21)
        Me._cmdtk_2.TabIndex = 15
        '
        '_cmdtk_1
        '
        Me._cmdtk_1.Image = CType(resources.GetObject("_cmdtk_1.Image"), System.Drawing.Image)
        Me._cmdtk_1.Location = New System.Drawing.Point(202, 185)
        Me._cmdtk_1.Name = "_cmdtk_1"
        Me._cmdtk_1.Size = New System.Drawing.Size(22, 21)
        Me._cmdtk_1.TabIndex = 13
        '
        '_cmdtk_0
        '
        Me._cmdtk_0.Image = CType(resources.GetObject("_cmdtk_0.Image"), System.Drawing.Image)
        Me._cmdtk_0.Location = New System.Drawing.Point(202, 162)
        Me._cmdtk_0.Name = "_cmdtk_0"
        Me._cmdtk_0.Size = New System.Drawing.Size(22, 21)
        Me._cmdtk_0.TabIndex = 11
        '
        'cmdtp
        '
        Me.cmdtp.Image = CType(resources.GetObject("cmdtp.Image"), System.Drawing.Image)
        Me.cmdtp.Location = New System.Drawing.Point(202, 54)
        Me.cmdtp.Name = "cmdtp"
        Me.cmdtp.Size = New System.Drawing.Size(22, 21)
        Me.cmdtp.TabIndex = 4
        '
        '_Command_5
        '
        Me._Command_5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_5.Location = New System.Drawing.Point(443, 576)
        Me._Command_5.Name = "_Command_5"
        Me._Command_5.Size = New System.Drawing.Size(81, 25)
        Me._Command_5.TabIndex = 37
        Me._Command_5.Tag = "Materials"
        Me._Command_5.Text = "&NVL TT"
        '
        '_Command_6
        '
        Me._Command_6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_6.Location = New System.Drawing.Point(355, 576)
        Me._Command_6.Name = "_Command_6"
        Me._Command_6.Size = New System.Drawing.Size(81, 25)
        Me._Command_6.TabIndex = 36
        Me._Command_6.Tag = "Cost tag"
        Me._Command_6.Text = "T&hẻ GT"
        '
        'cmdtp1
        '
        Me.cmdtp1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdtp1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdtp1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdtp1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdtp1.Image = CType(resources.GetObject("cmdtp1.Image"), System.Drawing.Image)
        Me.cmdtp1.Location = New System.Drawing.Point(1052, 83)
        Me.cmdtp1.Name = "cmdtp1"
        Me.cmdtp1.Size = New System.Drawing.Size(25, 25)
        Me.cmdtp1.TabIndex = 4
        Me.cmdtp1.TabStop = False
        Me.cmdtp1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdtp1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdtp1.UseVisualStyleBackColor = False
        Me.cmdtp1.Visible = False
        '
        '_cmdtk1_2
        '
        Me._cmdtk1_2.BackColor = System.Drawing.SystemColors.Control
        Me._cmdtk1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdtk1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdtk1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdtk1_2.Image = CType(resources.GetObject("_cmdtk1_2.Image"), System.Drawing.Image)
        Me._cmdtk1_2.Location = New System.Drawing.Point(1052, 237)
        Me._cmdtk1_2.Name = "_cmdtk1_2"
        Me._cmdtk1_2.Size = New System.Drawing.Size(25, 25)
        Me._cmdtk1_2.TabIndex = 15
        Me._cmdtk1_2.TabStop = False
        Me._cmdtk1_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdtk1_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._cmdtk1_2.UseVisualStyleBackColor = False
        Me._cmdtk1_2.Visible = False
        '
        '_cmdtk1_1
        '
        Me._cmdtk1_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdtk1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdtk1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdtk1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdtk1_1.Image = CType(resources.GetObject("_cmdtk1_1.Image"), System.Drawing.Image)
        Me._cmdtk1_1.Location = New System.Drawing.Point(1052, 213)
        Me._cmdtk1_1.Name = "_cmdtk1_1"
        Me._cmdtk1_1.Size = New System.Drawing.Size(25, 25)
        Me._cmdtk1_1.TabIndex = 13
        Me._cmdtk1_1.TabStop = False
        Me._cmdtk1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdtk1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._cmdtk1_1.UseVisualStyleBackColor = False
        Me._cmdtk1_1.Visible = False
        '
        '_cmdtk1_0
        '
        Me._cmdtk1_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdtk1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdtk1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdtk1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdtk1_0.Image = CType(resources.GetObject("_cmdtk1_0.Image"), System.Drawing.Image)
        Me._cmdtk1_0.Location = New System.Drawing.Point(1055, 189)
        Me._cmdtk1_0.Name = "_cmdtk1_0"
        Me._cmdtk1_0.Size = New System.Drawing.Size(17, 25)
        Me._cmdtk1_0.TabIndex = 11
        Me._cmdtk1_0.TabStop = False
        Me._cmdtk1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdtk1_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._cmdtk1_0.UseVisualStyleBackColor = False
        Me._cmdtk1_0.Visible = False
        '
        '_Command_7
        '
        Me._Command_7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_7.Location = New System.Drawing.Point(259, 576)
        Me._Command_7.Name = "_Command_7"
        Me._Command_7.Size = New System.Drawing.Size(89, 25)
        Me._Command_7.TabIndex = 35
        Me._Command_7.Tag = "Norms"
        Me._Command_7.Text = "Định &mức"
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
        Me.Grd.Location = New System.Drawing.Point(3, 272)
        Me.Grd.Name = "Grd"
        Me.Grd.Row = 0
        Me.Grd.Rows = 0
        Me.Grd.Selectable = True
        Me.Grd.SelectedTextColor = System.Drawing.Color.White
        Me.Grd.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.Grd.ShowBorder = True
        Me.Grd.ShowFocusRect = False
        Me.Grd.Size = New System.Drawing.Size(1018, 282)
        Me.Grd.SortType = ListViewEx.SortTypes.InsertionSort
        Me.Grd.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.Grd.TabIndex = 10
        '
        '_LbGia_3
        '
        Me._LbGia_3.BackColor = System.Drawing.Color.Transparent
        Me._LbGia_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbGia_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbGia_3.ForeColor = System.Drawing.Color.Blue
        Me._LbGia_3.Location = New System.Drawing.Point(380, 132)
        Me._LbGia_3.Name = "_LbGia_3"
        Me._LbGia_3.Size = New System.Drawing.Size(117, 17)
        Me._LbGia_3.TabIndex = 104
        Me._LbGia_3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(235, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 17)
        Me.Label4.TabIndex = 103
        Me.Label4.Tag = "General Expenses group"
        Me.Label4.Text = "CP SX chung nhóm"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(924, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 105
        Me.Label3.Tag = "End"
        Me.Label3.Text = "DD cuối kỳ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbodd
        '
        Me.cbodd.BackColor = System.Drawing.SystemColors.Window
        Me.cbodd.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbodd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbodd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbodd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodd.Location = New System.Drawing.Point(963, 551)
        Me.cbodd.Name = "cbodd"
        Me.cbodd.Size = New System.Drawing.Size(43, 21)
        Me.cbodd.TabIndex = 32
        '
        '_Command_8
        '
        Me._Command_8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_8.Location = New System.Drawing.Point(172, 576)
        Me._Command_8.Name = "_Command_8"
        Me._Command_8.Size = New System.Drawing.Size(81, 25)
        Me._Command_8.TabIndex = 106
        Me._Command_8.Tag = "Common"
        Me._Command_8.Text = "Tổng hợp"
        '
        'FrmThanhPham
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1025, 607)
        Me.Controls.Add(Me._Command_8)
        Me.Controls.Add(Me.Grd)
        Me.Controls.Add(Me._txtChuyen_0)
        Me.Controls.Add(Me._txtChuyen_1)
        Me.Controls.Add(Me._txtChuyen_2)
        Me.Controls.Add(Me._txtChuyen_3)
        Me.Controls.Add(Me._txtChuyen_4)
        Me.Controls.Add(Me._txtChuyen_5)
        Me.Controls.Add(Me._txtChuyen_6)
        Me.Controls.Add(Me._txtChuyen_9)
        Me.Controls.Add(Me._txtChuyen_10)
        Me.Controls.Add(Me._txtChuyen_11)
        Me.Controls.Add(Me._txtChuyen_12)
        Me.Controls.Add(Me._txtChuyen_13)
        Me.Controls.Add(Me._txtChuyen_8)
        Me.Controls.Add(Me._txtChuyen_14)
        Me.Controls.Add(Me._txtChuyen_15)
        Me.Controls.Add(Me._txtChuyen_16)
        Me.Controls.Add(Me.cbodd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me._LbGia_3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdct)
        Me.Controls.Add(Me._cmdtk_2)
        Me.Controls.Add(Me._cmdtk_1)
        Me.Controls.Add(Me._cmdtk_0)
        Me.Controls.Add(Me.cmdtp)
        Me.Controls.Add(Me._Command_4)
        Me.Controls.Add(Me._Command_5)
        Me.Controls.Add(Me._Command_6)
        Me.Controls.Add(Me.Xem)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._txtShTk_3)
        Me.Controls.Add(Me.TTXSX)
        Me.Controls.Add(Me.TXTNC)
        Me.Controls.Add(Me.TXTNVL)
        Me.Controls.Add(Me.XEM1)
        Me.Controls.Add(Me._txtChuyen_7)
        Me.Controls.Add(Me._txtShTk_0)
        Me.Controls.Add(Me.TxtCT)
        Me.Controls.Add(Me.cmdtp1)
        Me.Controls.Add(Me.Chk)
        Me.Controls.Add(Me._cmdtk1_2)
        Me.Controls.Add(Me._txtShTk_2)
        Me.Controls.Add(Me._txtShTk_1)
        Me.Controls.Add(Me._cmdtk1_1)
        Me.Controls.Add(Me._cmdtk1_0)
        Me.Controls.Add(Me.CboThang)
        Me.Controls.Add(Me.CboSohieu)
        Me.Controls.Add(Me._CboKho_1)
        Me.Controls.Add(Me._CboKho_0)
        Me.Controls.Add(Me.MedNgay)
        Me.Controls.Add(Me._Command_7)
        Me.Controls.Add(Me._Label_32)
        Me.Controls.Add(Me._Label_31)
        Me.Controls.Add(Me._Label_30)
        Me.Controls.Add(Me._Label_29)
        Me.Controls.Add(Me._Label_28)
        Me.Controls.Add(Me._Label_27)
        Me.Controls.Add(Me._Label_26)
        Me.Controls.Add(Me._Label_25)
        Me.Controls.Add(Me._Label_24)
        Me.Controls.Add(Me._Label_22)
        Me.Controls.Add(Me._Label_23)
        Me.Controls.Add(Me._Label_21)
        Me.Controls.Add(Me._Label_20)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me._Label_19)
        Me.Controls.Add(Me._Label_18)
        Me.Controls.Add(Me._Label_17)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_13)
        Me.Controls.Add(Me.LbCT)
        Me.Controls.Add(Me._Label_9)
        Me.Controls.Add(Me._LbGia_2)
        Me.Controls.Add(Me._Label_11)
        Me.Controls.Add(Me._LbGia_1)
        Me.Controls.Add(Me._LbGia_0)
        Me.Controls.Add(Me._Label_16)
        Me.Controls.Add(Me._Label_15)
        Me.Controls.Add(Me._Label_14)
        Me.Controls.Add(Me._LbTenTk_2)
        Me.Controls.Add(Me._Label_12)
        Me.Controls.Add(Me._LbTenTk_1)
        Me.Controls.Add(Me._LbTenTk_0)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_0)
        Me.Controls.Add(Me._Label_5)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(55, 31)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmThanhPham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Finished Good Voucher"
        Me.Text = "Kết chuyển thành phẩm"
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Sub InitializetxtShTk()
        Me.txtShTk(3) = _txtShTk_3
        Me.txtShTk(0) = _txtShTk_0
        Me.txtShTk(2) = _txtShTk_2
        Me.txtShTk(1) = _txtShTk_1
    End Sub
    Sub InitializetxtChuyen()
        Me.txtChuyen(16) = _txtChuyen_16
        Me.txtChuyen(15) = _txtChuyen_15
        Me.txtChuyen(14) = _txtChuyen_14
        Me.txtChuyen(8) = _txtChuyen_8
        Me.txtChuyen(13) = _txtChuyen_13
        Me.txtChuyen(12) = _txtChuyen_12
        Me.txtChuyen(11) = _txtChuyen_11
        Me.txtChuyen(10) = _txtChuyen_10
        Me.txtChuyen(9) = _txtChuyen_9
        Me.txtChuyen(5) = _txtChuyen_5
        Me.txtChuyen(4) = _txtChuyen_4
        Me.txtChuyen(6) = _txtChuyen_6
        Me.txtChuyen(1) = _txtChuyen_1
        Me.txtChuyen(7) = _txtChuyen_7
        Me.txtChuyen(2) = _txtChuyen_2
        Me.txtChuyen(0) = _txtChuyen_0
        Me.txtChuyen(3) = _txtChuyen_3
    End Sub
    Sub Initializecmdtk1()
        Me.cmdtk1(2) = _cmdtk1_2
        Me.cmdtk1(1) = _cmdtk1_1
        Me.cmdtk1(0) = _cmdtk1_0
    End Sub
    Sub Initializecmdtk()
        Me.cmdtk(2) = _cmdtk_2
        Me.cmdtk(1) = _cmdtk_1
        Me.cmdtk(0) = _cmdtk_0
    End Sub
    Sub InitializeMNCon()
        Me.MNCon(0) = _MNCon_0
    End Sub
    Sub InitializeLbTenTk()
        Me.LbTenTk(2) = _LbTenTk_2
        Me.LbTenTk(1) = _LbTenTk_1
        Me.LbTenTk(0) = _LbTenTk_0
    End Sub
    Sub InitializeLbGia()
        Me.LbGia(3) = _LbGia_3
        Me.LbGia(2) = _LbGia_2
        Me.LbGia(1) = _LbGia_1
        Me.LbGia(0) = _LbGia_0
    End Sub
    Sub InitializeLabel()
        Me.Label(32) = _Label_32
        Me.Label(31) = _Label_31
        Me.Label(30) = _Label_30
        Me.Label(29) = _Label_29
        Me.Label(28) = _Label_28
        Me.Label(27) = _Label_27
        Me.Label(26) = _Label_26
        Me.Label(25) = _Label_25
        Me.Label(24) = _Label_24
        Me.Label(22) = _Label_22
        Me.Label(23) = _Label_23
        Me.Label(21) = _Label_21
        Me.Label(20) = _Label_20
        Me.Label(3) = _Label_3
        Me.Label(19) = _Label_19
        Me.Label(18) = _Label_18
        Me.Label(17) = _Label_17
        Me.Label(4) = _Label_4
        Me.Label(13) = _Label_13
        Me.Label(9) = _Label_9
        Me.Label(11) = _Label_11
        Me.Label(16) = _Label_16
        Me.Label(15) = _Label_15
        Me.Label(14) = _Label_14
        Me.Label(12) = _Label_12
        Me.Label(7) = _Label_7
        Me.Label(10) = _Label_10
        Me.Label(8) = _Label_8
        Me.Label(6) = _Label_6
        Me.Label(2) = _Label_2
        Me.Label(1) = _Label_1
        Me.Label(0) = _Label_0
        Me.Label(5) = _Label_5
    End Sub
    Sub InitializeCommand()
        Me.Command(4) = _Command_4
        Me.Command(5) = _Command_5
        Me.Command(6) = _Command_6
        Me.Command(2) = _Command_2
        Me.Command(3) = _Command_3
        Me.Command(1) = _Command_1
        Me.Command(0) = _Command_0
        Me.Command(7) = _Command_7
        Me.Command(8) = _Command_8
    End Sub
    Sub InitializeCboKho()
        Me.CboKho(1) = _CboKho_1
        Me.CboKho(0) = _CboKho_0
    End Sub
    Private WithEvents _LbGia_3 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents cbodd As ComboBoxEx.ComboBoxExt
    Private WithEvents _Command_8 As System.Windows.Forms.Button
#End Region
End Class
