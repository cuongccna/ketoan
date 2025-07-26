<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMNHoadontuin
    Inherits Form

#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        ' Init components
        InitializeComponent()
        InitializeCommand()
        InitializeCmd1()
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
    Private WithEvents _Cmd1_0 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_1 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_2 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_3 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_4 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_5 As System.Windows.Forms.Button
    Public Cmd1(5) As System.Windows.Forms.Button
    Public Command(2) As System.Windows.Forms.Button
    Public Label(17) As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMNHoadontuin))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Cmd1_0 = New System.Windows.Forms.Button()
        Me._Cmd1_1 = New System.Windows.Forms.Button()
        Me._Cmd1_2 = New System.Windows.Forms.Button()
        Me._Cmd1_3 = New System.Windows.Forms.Button()
        Me._Cmd1_4 = New System.Windows.Forms.Button()
        Me._Cmd1_5 = New System.Windows.Forms.Button()
        Me.SimpleButton1 = New System.Windows.Forms.Button()
        Me.sb_in = New System.Windows.Forms.Button()
        Me.SimpleButton2 = New System.Windows.Forms.Button()
        Me.SimpleButton3 = New System.Windows.Forms.Button()
        'Me.LabelControl6 = New System.Windows.Forms.Label()
        'Me.LabelControl1 = New System.Windows.Forms.Label()
        'Me.LabelControl2 = New System.Windows.Forms.Label()
        'Me.LabelControl3 = New System.Windows.Forms.Label()
        'Me.LabelControl4 = New System.Windows.Forms.Label()
        'Me.LabelControl5 = New System.Windows.Forms.Label()
        'Me.LabelControl7 = New System.Windows.Forms.Label()
        'Me.LabelControl8 = New System.Windows.Forms.Label()
        'Me.LabelControl9 = New System.Windows.Forms.Label()
        'Me.LabelControl12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        '_Cmd1_0
        '
        'Me._Cmd1_0.AllowFocus = False
        'Me._Cmd1_0.Appearance.BackColor = System.Drawing.Color.Transparent
        'Me._Cmd1_0.Appearance.Options.UseBackColor = True
        'Me._Cmd1_0.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._Cmd1_0.Image = CType(resources.GetObject("_Cmd1_0.Image"), System.Drawing.Image)
        'Me._Cmd1_0.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me._Cmd1_0.Location = New System.Drawing.Point(30, 94)
        Me._Cmd1_0.Name = "_Cmd1_0"
        Me._Cmd1_0.Size = New System.Drawing.Size(80, 80)
        Me._Cmd1_0.TabIndex = 0
        Me._Cmd1_0.TabStop = False
        Me._Cmd1_0.Tag = "Decide using auto printting invoice"
        Me._Cmd1_0.Text = "Quyết định sử dụng hoá đơn tự in"
        '
        '_Cmd1_1
        '
        'Me._Cmd1_1.AllowFocus = False
        'Me._Cmd1_1.Appearance.BackColor = System.Drawing.Color.Transparent
        'Me._Cmd1_1.Appearance.Options.UseBackColor = True
        'Me._Cmd1_1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._Cmd1_1.Image = CType(resources.GetObject("_Cmd1_1.Image"), System.Drawing.Image)
        'Me._Cmd1_1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me._Cmd1_1.Location = New System.Drawing.Point(180, 94)
        Me._Cmd1_1.Name = "_Cmd1_1"
        Me._Cmd1_1.Size = New System.Drawing.Size(80, 80)
        Me._Cmd1_1.TabIndex = 1
        Me._Cmd1_1.TabStop = False
        Me._Cmd1_1.Tag = "Make the invoice"
        Me._Cmd1_1.Text = "Khởi tạo mẫu hoá đơn"
        '
        '_Cmd1_2
        '
        'Me._Cmd1_2.AllowFocus = False
        'Me._Cmd1_2.Appearance.BackColor = System.Drawing.Color.Transparent
        'Me._Cmd1_2.Appearance.Options.UseBackColor = True
        'Me._Cmd1_2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._Cmd1_2.Image = CType(resources.GetObject("_Cmd1_2.Image"), System.Drawing.Image)
        'Me._Cmd1_2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me._Cmd1_2.Location = New System.Drawing.Point(353, 435)
        Me._Cmd1_2.Name = "_Cmd1_2"
        Me._Cmd1_2.Size = New System.Drawing.Size(80, 80)
        Me._Cmd1_2.TabIndex = 3
        Me._Cmd1_2.TabStop = False
        Me._Cmd1_2.Tag = "Announcement of issue"
        Me._Cmd1_2.Text = "Thông báo phát hành hoá đơn "
        '
        '_Cmd1_3
        '
        'Me._Cmd1_3.AllowFocus = False
        'Me._Cmd1_3.Appearance.BackColor = System.Drawing.Color.Transparent
        'Me._Cmd1_3.Appearance.Options.UseBackColor = True
        'Me._Cmd1_3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._Cmd1_3.Image = CType(resources.GetObject("_Cmd1_3.Image"), System.Drawing.Image)
        'Me._Cmd1_3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me._Cmd1_3.Location = New System.Drawing.Point(644, 94)
        Me._Cmd1_3.Name = "_Cmd1_3"
        Me._Cmd1_3.Size = New System.Drawing.Size(80, 80)
        Me._Cmd1_3.TabIndex = 4
        Me._Cmd1_3.TabStop = False
        Me._Cmd1_3.Tag = "Manage the invoice"
        Me._Cmd1_3.Text = "Quản lý sử dụng hoá đơn"
        '
        '_Cmd1_4
        '
        'Me._Cmd1_4.AllowFocus = False
        'Me._Cmd1_4.Appearance.BackColor = System.Drawing.Color.Transparent
        'Me._Cmd1_4.Appearance.Options.UseBackColor = True
        'Me._Cmd1_4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._Cmd1_4.Image = CType(resources.GetObject("_Cmd1_4.Image"), System.Drawing.Image)
        'Me._Cmd1_4.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me._Cmd1_4.Location = New System.Drawing.Point(644, 435)
        Me._Cmd1_4.Name = "_Cmd1_4"
        Me._Cmd1_4.Size = New System.Drawing.Size(80, 80)
        Me._Cmd1_4.TabIndex = 5
        Me._Cmd1_4.TabStop = False
        Me._Cmd1_4.Tag = "Reports of using invoice"
        Me._Cmd1_4.Text = "Báo cáo hoá đơn sử dụng "
        '
        '_Cmd1_5
        '
        'Me._Cmd1_5.AllowFocus = False
        'Me._Cmd1_5.Appearance.BackColor = System.Drawing.Color.Transparent
        'Me._Cmd1_5.Appearance.Options.UseBackColor = True
        'Me._Cmd1_5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me._Cmd1_5.Image = CType(resources.GetObject("_Cmd1_5.Image"), System.Drawing.Image)
        'Me._Cmd1_5.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me._Cmd1_5.Location = New System.Drawing.Point(353, 94)
        Me._Cmd1_5.Name = "_Cmd1_5"
        Me._Cmd1_5.Size = New System.Drawing.Size(80, 80)
        Me._Cmd1_5.TabIndex = 2
        Me._Cmd1_5.TabStop = False
        Me._Cmd1_5.Tag = "Register using invoice"
        Me._Cmd1_5.Text = "Đăng ký hoá đơn sử dụng"
        '
        'SimpleButton1
        '
        'Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.Transparent
        'Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        'Me.SimpleButton1.Appearance.Options.UseBackColor = True
        'Me.SimpleButton1.Appearance.Options.UseForeColor = True
        'Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton1.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me.SimpleButton1.Location = New System.Drawing.Point(740, 529)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(141, 25)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Tag = "Return"
        Me.SimpleButton1.Text = "Trở &về"
        '
        'sb_in
        '
        'Me.sb_in.AllowFocus = False
        'Me.sb_in.Appearance.BackColor = System.Drawing.Color.Transparent
        'Me.sb_in.Appearance.Options.UseBackColor = True
        'Me.sb_in.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.sb_in.Image = CType(resources.GetObject("sb_in.Image"), System.Drawing.Image)
        'Me.sb_in.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.sb_in.Location = New System.Drawing.Point(466, 263)
        Me.sb_in.Name = "sb_in"
        Me.sb_in.Size = New System.Drawing.Size(80, 80)
        Me.sb_in.TabIndex = 1
        Me.sb_in.TabStop = False
        Me.sb_in.Tag = "Print invoice"
        Me.sb_in.Text = "In hóa đơn"
        '
        'SimpleButton2
        '
        'Me.SimpleButton2.AllowFocus = False
        'Me.SimpleButton2.Appearance.BackColor = System.Drawing.Color.Transparent
        'Me.SimpleButton2.Appearance.Options.UseBackColor = True
        'Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        'Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(180, 435)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 80)
        Me.SimpleButton2.TabIndex = 6
        Me.SimpleButton2.TabStop = False
        Me.SimpleButton2.Tag = "Communicate to publish for invoice"
        Me.SimpleButton2.Text = "Thông báo phát hành hoá đơn "
        '
        'SimpleButton3
        '
        'Me.SimpleButton3.AllowFocus = False
        'Me.SimpleButton3.Appearance.BackColor = System.Drawing.Color.Transparent
        'Me.SimpleButton3.Appearance.Options.UseBackColor = True
        'Me.SimpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        'Me.SimpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton3.Location = New System.Drawing.Point(30, 435)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(80, 80)
        Me.SimpleButton3.TabIndex = 7
        Me.SimpleButton3.TabStop = False
        Me.SimpleButton3.Tag = "Communicate to publish for invoice"
        Me.SimpleButton3.Text = "Thông báo phát hành hoá đơn "
        '
        'LabelControl6
        '
        'Me.LabelControl6.Appearance.BackColor = System.Drawing.Color.Transparent
        'Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        'Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        'Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        'Me.LabelControl6.Cursor = System.Windows.Forms.Cursors.Hand
        ''Me.LabelControl6.Location = New System.Drawing.Point(1, 176)
        'Me.LabelControl6.Name = "LabelControl6"
        'Me.LabelControl6.Size = New System.Drawing.Size(153, 27)
        'Me.LabelControl6.TabIndex = 107
        'Me.LabelControl6.Tag = "Using auto printing invoice"
        'Me.LabelControl6.Text = "Quyết định sử dụng" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hóa đơn tự in"
        '
        'LabelControl1
        '
        'Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        'Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        'Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        'Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        'Me.LabelControl1.Cursor = System.Windows.Forms.Cursors.Hand
        'Me.LabelControl1.Location = New System.Drawing.Point(160, 176)
        'Me.LabelControl1.Name = "LabelControl1"
        'Me.LabelControl1.Size = New System.Drawing.Size(121, 27)
        'Me.LabelControl1.TabIndex = 108
        'Me.LabelControl1.Tag = "Make the invoice"
        'Me.LabelControl1.Text = "Khởi tạo mẫu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hóa đơn"
        '
        'LabelControl2
        '
        'Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.Transparent
        'Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        'Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        'Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        'Me.LabelControl2.Cursor = System.Windows.Forms.Cursors.Hand
        'Me.LabelControl2.Location = New System.Drawing.Point(332, 176)
        'Me.LabelControl2.Name = "LabelControl2"
        'Me.LabelControl2.Size = New System.Drawing.Size(123, 27)
        'Me.LabelControl2.TabIndex = 109
        'Me.LabelControl2.Tag = "Register using invoice"
        'Me.LabelControl2.Text = "Đăng ký hóa đơn" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sử dụng"
        '
        'LabelControl3
        '
        'Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.Transparent
        'Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        'Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        'Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        'Me.LabelControl3.Cursor = System.Windows.Forms.Cursors.Hand
        'Me.LabelControl3.Location = New System.Drawing.Point(628, 176)
        'Me.LabelControl3.Name = "LabelControl3"
        'Me.LabelControl3.Size = New System.Drawing.Size(112, 27)
        'Me.LabelControl3.TabIndex = 110
        'Me.LabelControl3.Tag = "Manage the invoice"
        'Me.LabelControl3.Text = "Quản lý sử dụng" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hóa đơn"
        '
        'LabelControl4
        '
        'Me.LabelControl4.Appearance.BackColor = System.Drawing.Color.Transparent
        'Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        'Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        'Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        'Me.LabelControl4.Cursor = System.Windows.Forms.Cursors.Hand
        'Me.LabelControl4.Location = New System.Drawing.Point(634, 517)
        'Me.LabelControl4.Name = "LabelControl4"
        'Me.LabelControl4.Size = New System.Drawing.Size(100, 13)
        'Me.LabelControl4.TabIndex = 111
        'Me.LabelControl4.Tag = "Reports"
        'Me.LabelControl4.Text = "Báo cáo hóa đơn" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelControl5
        '
        'Me.LabelControl5.Appearance.BackColor = System.Drawing.Color.Transparent
        'Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        'Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        ''Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        'Me.LabelControl5.Cursor = System.Windows.Forms.Cursors.Hand
        'Me.LabelControl5.Location = New System.Drawing.Point(320, 517)
        'Me.LabelControl5.Name = "LabelControl5"
        'Me.LabelControl5.Size = New System.Drawing.Size(148, 27)
        'Me.LabelControl5.TabIndex = 112
        'Me.LabelControl5.Tag = "Announcement of issue"
        'Me.LabelControl5.Text = "Thông báo phát hành" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hóa đơn"
        '
        'LabelControl7
        '
        'Me.LabelControl7.Appearance.BackColor = System.Drawing.Color.Transparent
        'Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        'Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        'Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        'Me.LabelControl7.Cursor = System.Windows.Forms.Cursors.Hand
        'Me.LabelControl7.Location = New System.Drawing.Point(1, 517)
        'Me.LabelControl7.Name = "LabelControl7"
        'Me.LabelControl7.Size = New System.Drawing.Size(138, 27)
        'Me.LabelControl7.TabIndex = 113
        'Me.LabelControl7.Tag = "Printing contract invoice"
        'Me.LabelControl7.Text = "Hóa đơn đặt in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ký hợp đồng"
        '
        'LabelControl8
        '
        'Me.LabelControl8.Appearance.BackColor = System.Drawing.Color.Transparent
        'Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        'Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        'Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        'Me.LabelControl8.Cursor = System.Windows.Forms.Cursors.Hand
        'Me.LabelControl8.Location = New System.Drawing.Point(151, 517)
        'Me.LabelControl8.Name = "LabelControl8"
        'Me.LabelControl8.Size = New System.Drawing.Size(137, 27)
        'Me.LabelControl8.TabIndex = 114
        'Me.LabelControl8.Tag = "Adjusting Invoice form"
        'Me.LabelControl8.Text = "Điều chỉnh mẫu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hóa đơn"
        '
        'LabelControl9
        '
        'Me.LabelControl9.Appearance.BackColor = System.Drawing.Color.Transparent
        'Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        'Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        ''Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        'Me.LabelControl9.Cursor = System.Windows.Forms.Cursors.Hand
        'Me.LabelControl9.Location = New System.Drawing.Point(456, 345)
        'Me.LabelControl9.Name = "LabelControl9"
        'Me.LabelControl9.Size = New System.Drawing.Size(100, 13)
        'Me.LabelControl9.TabIndex = 115
        'Me.LabelControl9.Tag = "Print Invoice"
        'Me.LabelControl9.Text = "Xuất hóa đơn"
        '
        'LabelControl12
        '
        'Me.LabelControl12.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(231, Byte), Integer))
        'Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.Blue
        'Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        'Me.LabelControl12.Cursor = System.Windows.Forms.Cursors.Hand
        'Me.LabelControl12.Location = New System.Drawing.Point(67, 9)
        'Me.LabelControl12.Name = "LabelControl12"
        'Me.LabelControl12.Size = New System.Drawing.Size(824, 32)
        'Me.LabelControl12.TabIndex = 117
        'Me.LabelControl12.Tag = "MANAGETHE INVOICE"
        'Me.LabelControl12.Text = "HÓA ĐƠN TỰ IN"
        ''
        'FrmMNHoadontuin
        '
        'Me.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.Appearance.Options.UseFont = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        'Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        'Me.BackgroundImageStore = CType(resources.GetObject("$this.BackgroundImageStore"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(891, 566)
        'Me.Controls.Add(Me.LabelControl12)
        'Me.Controls.Add(Me.LabelControl9)
        'Me.Controls.Add(Me.LabelControl8)
        'Me.Controls.Add(Me.LabelControl7)
        'Me.Controls.Add(Me.LabelControl5)
        'Me.Controls.Add(Me.LabelControl4)
        'Me.Controls.Add(Me.LabelControl3)
        'Me.Controls.Add(Me.LabelControl2)
        'Me.Controls.Add(Me.LabelControl1)
        'Me.Controls.Add(Me.LabelControl6)
        'Me.Controls.Add(Me.SimpleButton3)
        'Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me._Cmd1_4)
        Me.Controls.Add(Me._Cmd1_3)
        Me.Controls.Add(Me._Cmd1_2)
        Me.Controls.Add(Me.sb_in)
        Me.Controls.Add(Me._Cmd1_1)
        Me.Controls.Add(Me._Cmd1_0)
        Me.Controls.Add(Me._Cmd1_5)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMNHoadontuin"
        Me.ShowInTaskbar = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Manage the invoice"
        Me.Text = "Quản lý hoá đơn tự in"
        Me.ResumeLayout(False)

    End Sub
    Sub InitializeCommand()
        '  Me.Command(2) = _Command_2
    End Sub
    Sub InitializeCmd1()
        Me.Cmd1(0) = _Cmd1_0
        Me.Cmd1(1) = _Cmd1_1
        Me.Cmd1(2) = _Cmd1_2
        Me.Cmd1(3) = _Cmd1_3
        Me.Cmd1(4) = _Cmd1_4
        Me.Cmd1(5) = _Cmd1_5
    End Sub
    Private WithEvents SimpleButton1 As System.Windows.Forms.Button
    Friend WithEvents sb_in As System.Windows.Forms.Button
    Private WithEvents SimpleButton2 As System.Windows.Forms.Button
    Private WithEvents SimpleButton3 As System.Windows.Forms.Button
    Friend WithEvents LabelControl6 As System.Windows.Forms.Label
    Friend WithEvents LabelControl1 As System.Windows.Forms.Label
    Friend WithEvents LabelControl2 As System.Windows.Forms.Label
    Friend WithEvents LabelControl3 As System.Windows.Forms.Label
    Friend WithEvents LabelControl4 As System.Windows.Forms.Label
    Friend WithEvents LabelControl5 As System.Windows.Forms.Label
    Friend WithEvents LabelControl7 As System.Windows.Forms.Label
    Friend WithEvents LabelControl8 As System.Windows.Forms.Label
    Friend WithEvents LabelControl9 As System.Windows.Forms.Label
    Friend WithEvents LabelControl12 As System.Windows.Forms.Label
#End Region
End Class
