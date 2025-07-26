<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCantrucongno
    Inherits Form

#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        ' Init components
        InitializeComponent()
        InitializeCommand()
        InitializeCboThang()
        InitializeGrdview()
        InitializeChk()
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
    Public Command(3) As System.Windows.Forms.Button
    Public CboThang(1) As ComboBoxEx.ComboBoxExt
    Public Grdview(1) As ListViewEx.ListviewExt
    Public chk(1) As System.Windows.Forms.CheckBox
    'Private listBoxHelper1 As Artinsoft.VB6.Gui.ListBoxHelper
    'Private commandButtonHelper1 As Artinsoft.VB6.Gui.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCantrucongno))
        Me._Label_11 = New System.Windows.Forms.Label()
        Me._Frame_0 = New System.Windows.Forms.GroupBox()
        Me.Cantru = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Chk1 = New System.Windows.Forms.CheckBox()
        Me.dauky131 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tien131 = New System.Windows.Forms.Label()
        Me._Label_13 = New System.Windows.Forms.Label()
        Me.thanhtoan131 = New System.Windows.Forms.Label()
        Me.conlai131 = New System.Windows.Forms.Label()
        Me.Grd = New ListViewEx.ListviewExt()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._Label_4 = New System.Windows.Forms.Label()
        Me._Label_7 = New System.Windows.Forms.Label()
        Me._Label_2 = New System.Windows.Forms.Label()
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.conlai331 = New System.Windows.Forms.Label()
        Me.Chk2 = New System.Windows.Forms.CheckBox()
        Me.dauky331 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tien331 = New System.Windows.Forms.Label()
        Me.thanhtoan331 = New System.Windows.Forms.Label()
        Me.Grd1 = New ListViewEx.ListviewExt()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me._Command_2 = New System.Windows.Forms.Button()
        Me._Command_3 = New System.Windows.Forms.Button()
        Me.txtshkh = New System.Windows.Forms.TextBox()
        Me.cmdkh = New System.Windows.Forms.Button()
        Me.lbkh = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me._CboThang_1 = New ComboBoxEx.ComboBoxExt()
        Me._CboThang_0 = New ComboBoxEx.ComboBoxExt()
        Me._Label_1 = New System.Windows.Forms.Label()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me._Frame_0.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Label_11
        '
        Me._Label_11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_11.ForeColor = System.Drawing.Color.Black
        Me._Label_11.Location = New System.Drawing.Point(258, 13)
        Me._Label_11.Name = "_Label_11"
        Me._Label_11.Size = New System.Drawing.Size(500, 20)
        Me._Label_11.TabIndex = 11
        Me._Label_11.Tag = "Industrial salary"
        Me._Label_11.Text = "BẢNG CẤN TRỪ CÔNG NỢ"
        Me._Label_11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Frame_0
        '
        Me._Frame_0.BackColor = System.Drawing.Color.Transparent
        Me._Frame_0.Controls.Add(Me.Cantru)
        Me._Frame_0.Controls.Add(Me.Label4)
        Me._Frame_0.Controls.Add(Me.Chk1)
        Me._Frame_0.Controls.Add(Me.dauky131)
        Me._Frame_0.Controls.Add(Me.Label3)
        Me._Frame_0.Controls.Add(Me.Label2)
        Me._Frame_0.Controls.Add(Me.tien131)
        Me._Frame_0.Controls.Add(Me._Label_13)
        Me._Frame_0.Controls.Add(Me.thanhtoan131)
        Me._Frame_0.Controls.Add(Me.conlai131)
        Me._Frame_0.Controls.Add(Me.Grd)
        Me._Frame_0.Controls.Add(Me.Label1)
        Me._Frame_0.Controls.Add(Me._Label_4)
        Me._Frame_0.Controls.Add(Me._Label_7)
        Me._Frame_0.Controls.Add(Me._Label_2)
        Me._Frame_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_0.ForeColor = System.Drawing.Color.Blue
        Me._Frame_0.Location = New System.Drawing.Point(12, 111)
        Me._Frame_0.Name = "_Frame_0"
        Me._Frame_0.Size = New System.Drawing.Size(526, 505)
        Me._Frame_0.TabIndex = 142
        Me._Frame_0.TabStop = False
        Me._Frame_0.Text = "Phát sinh tài khoản 131"
        '
        'Cantru
        '
        Me.Cantru.BackColor = System.Drawing.Color.Transparent
        Me.Cantru.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cantru.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantru.ForeColor = System.Drawing.Color.Blue
        Me.Cantru.Location = New System.Drawing.Point(373, 465)
        Me.Cantru.Name = "Cantru"
        Me.Cantru.Size = New System.Drawing.Size(144, 17)
        Me.Cantru.TabIndex = 29
        Me.Cantru.Text = "0"
        Me.Cantru.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(457, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 28
        Me.Label4.Tag = "Debt"
        Me.Label4.Text = "Cấn trừ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Chk1
        '
        Me.Chk1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Chk1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Chk1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk1.ForeColor = System.Drawing.Color.Black
        Me.Chk1.Location = New System.Drawing.Point(376, 16)
        Me.Chk1.Name = "Chk1"
        Me.Chk1.Size = New System.Drawing.Size(81, 17)
        Me.Chk1.TabIndex = 27
        Me.Chk1.Tag = "Choose all"
        Me.Chk1.Text = "Chọn tất cả"
        Me.Chk1.UseVisualStyleBackColor = False
        '
        'dauky131
        '
        Me.dauky131.BackColor = System.Drawing.Color.Transparent
        Me.dauky131.Cursor = System.Windows.Forms.Cursors.Default
        Me.dauky131.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dauky131.ForeColor = System.Drawing.Color.Blue
        Me.dauky131.Location = New System.Drawing.Point(75, 465)
        Me.dauky131.Name = "dauky131"
        Me.dauky131.Size = New System.Drawing.Size(89, 17)
        Me.dauky131.TabIndex = 26
        Me.dauky131.Text = "0"
        Me.dauky131.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(173, 466)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Tag = "Total"
        Me.Label3.Text = "Tổng cộng"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(3, 466)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Tag = "Beginning Balance"
        Me.Label2.Text = "Tồn đầu kỳ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tien131
        '
        Me.tien131.BackColor = System.Drawing.Color.Transparent
        Me.tien131.Cursor = System.Windows.Forms.Cursors.Default
        Me.tien131.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tien131.ForeColor = System.Drawing.Color.Blue
        Me.tien131.Location = New System.Drawing.Point(231, 465)
        Me.tien131.Name = "tien131"
        Me.tien131.Size = New System.Drawing.Size(73, 17)
        Me.tien131.TabIndex = 23
        Me.tien131.Text = "0"
        Me.tien131.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Label_13
        '
        Me._Label_13.BackColor = System.Drawing.Color.Transparent
        Me._Label_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_13.Location = New System.Drawing.Point(3, 483)
        Me._Label_13.Name = "_Label_13"
        Me._Label_13.Size = New System.Drawing.Size(65, 17)
        Me._Label_13.TabIndex = 22
        Me._Label_13.Tag = "Total"
        Me._Label_13.Text = "Tổng còn lại"
        '
        'thanhtoan131
        '
        Me.thanhtoan131.BackColor = System.Drawing.Color.Transparent
        Me.thanhtoan131.Cursor = System.Windows.Forms.Cursors.Default
        Me.thanhtoan131.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thanhtoan131.ForeColor = System.Drawing.Color.Blue
        Me.thanhtoan131.Location = New System.Drawing.Point(300, 465)
        Me.thanhtoan131.Name = "thanhtoan131"
        Me.thanhtoan131.Size = New System.Drawing.Size(73, 17)
        Me.thanhtoan131.TabIndex = 22
        Me.thanhtoan131.Text = "0"
        Me.thanhtoan131.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'conlai131
        '
        Me.conlai131.BackColor = System.Drawing.Color.Transparent
        Me.conlai131.Cursor = System.Windows.Forms.Cursors.Default
        Me.conlai131.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conlai131.ForeColor = System.Drawing.Color.Blue
        Me.conlai131.Location = New System.Drawing.Point(77, 483)
        Me.conlai131.Name = "conlai131"
        Me.conlai131.Size = New System.Drawing.Size(114, 17)
        Me.conlai131.TabIndex = 21
        Me.conlai131.Text = "0"
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
        Me.Grd.HeaderHeight = 22
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
        Me.Grd.Location = New System.Drawing.Point(6, 32)
        Me.Grd.Name = "Grd"
        Me.Grd.Row = 0
        Me.Grd.Rows = 0
        Me.Grd.Selectable = True
        Me.Grd.SelectedTextColor = System.Drawing.Color.White
        Me.Grd.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.Grd.ShowBorder = True
        Me.Grd.ShowFocusRect = False
        Me.Grd.Size = New System.Drawing.Size(514, 431)
        Me.Grd.SortType = ListViewEx.SortTypes.InsertionSort
        Me.Grd.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.Grd.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(306, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Tag = "Debt"
        Me.Label1.Text = "Thanh toán"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.Black
        Me._Label_4.Location = New System.Drawing.Point(237, 16)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(70, 17)
        Me._Label_4.TabIndex = 18
        Me._Label_4.Tag = "Debt"
        Me._Label_4.Text = "Số phát sinh"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.Black
        Me._Label_7.Location = New System.Drawing.Point(6, 16)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(73, 17)
        Me._Label_7.TabIndex = 17
        Me._Label_7.Tag = "Account"
        Me._Label_7.Text = "Hóa đơn"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._Label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.Color.Black
        Me._Label_2.Location = New System.Drawing.Point(78, 16)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(160, 17)
        Me._Label_2.TabIndex = 11
        Me._Label_2.Tag = "Name Account"
        Me._Label_2.Text = "Diễn giải"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(930, 80)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(78, 25)
        Me._Command_1.TabIndex = 144
        Me._Command_1.Tag = "Return"
        Me._Command_1.Text = "Trở &về"
        '
        '_Command_0
        '
        Me._Command_0.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Liet_ke
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(850, 80)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(78, 25)
        Me._Command_0.TabIndex = 145
        Me._Command_0.Tag = "Apply"
        Me._Command_0.Text = "&Thực hiện"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.conlai331)
        Me.GroupBox1.Controls.Add(Me.Chk2)
        Me.GroupBox1.Controls.Add(Me.dauky331)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.tien331)
        Me.GroupBox1.Controls.Add(Me.thanhtoan331)
        Me.GroupBox1.Controls.Add(Me.Grd1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(544, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 505)
        Me.GroupBox1.TabIndex = 146
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Phát sinh tài khoản 331"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(3, 483)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 32
        Me.Label5.Tag = "Total"
        Me.Label5.Text = "Tổng còn lại"
        '
        'conlai331
        '
        Me.conlai331.BackColor = System.Drawing.Color.Transparent
        Me.conlai331.Cursor = System.Windows.Forms.Cursors.Default
        Me.conlai331.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conlai331.ForeColor = System.Drawing.Color.Blue
        Me.conlai331.Location = New System.Drawing.Point(77, 483)
        Me.conlai331.Name = "conlai331"
        Me.conlai331.Size = New System.Drawing.Size(114, 17)
        Me.conlai331.TabIndex = 31
        Me.conlai331.Text = "0"
        '
        'Chk2
        '
        Me.Chk2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Chk2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Chk2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk2.ForeColor = System.Drawing.Color.Black
        Me.Chk2.Location = New System.Drawing.Point(376, 16)
        Me.Chk2.Name = "Chk2"
        Me.Chk2.Size = New System.Drawing.Size(81, 17)
        Me.Chk2.TabIndex = 30
        Me.Chk2.Tag = "Choose all"
        Me.Chk2.Text = "Chọn tất cả"
        Me.Chk2.UseVisualStyleBackColor = False
        '
        'dauky331
        '
        Me.dauky331.BackColor = System.Drawing.Color.Transparent
        Me.dauky331.Cursor = System.Windows.Forms.Cursors.Default
        Me.dauky331.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dauky331.ForeColor = System.Drawing.Color.Blue
        Me.dauky331.Location = New System.Drawing.Point(75, 465)
        Me.dauky331.Name = "dauky331"
        Me.dauky331.Size = New System.Drawing.Size(88, 17)
        Me.dauky331.TabIndex = 29
        Me.dauky331.Text = "0"
        Me.dauky331.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(169, 466)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 17)
        Me.Label11.TabIndex = 28
        Me.Label11.Tag = "Total"
        Me.Label11.Text = "Tổng cộng"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(3, 466)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 17)
        Me.Label12.TabIndex = 27
        Me.Label12.Tag = "Beginning Balance"
        Me.Label12.Text = "Tồn đầu kỳ"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tien331
        '
        Me.tien331.BackColor = System.Drawing.Color.Transparent
        Me.tien331.Cursor = System.Windows.Forms.Cursors.Default
        Me.tien331.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tien331.ForeColor = System.Drawing.Color.Blue
        Me.tien331.Location = New System.Drawing.Point(231, 465)
        Me.tien331.Name = "tien331"
        Me.tien331.Size = New System.Drawing.Size(71, 17)
        Me.tien331.TabIndex = 23
        Me.tien331.Text = "0"
        Me.tien331.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'thanhtoan331
        '
        Me.thanhtoan331.BackColor = System.Drawing.Color.Transparent
        Me.thanhtoan331.Cursor = System.Windows.Forms.Cursors.Default
        Me.thanhtoan331.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thanhtoan331.ForeColor = System.Drawing.Color.Blue
        Me.thanhtoan331.Location = New System.Drawing.Point(300, 465)
        Me.thanhtoan331.Name = "thanhtoan331"
        Me.thanhtoan331.Size = New System.Drawing.Size(73, 17)
        Me.thanhtoan331.TabIndex = 22
        Me.thanhtoan331.Text = "0"
        Me.thanhtoan331.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Grd1
        '
        Me.Grd1.AllowColumnResize = True
        Me.Grd1.AllowMultiselect = False
        Me.Grd1.AlternateBackground = System.Drawing.Color.DarkGreen
        Me.Grd1.AlternatingColors = False
        Me.Grd1.AutoHeight = True
        Me.Grd1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Grd1.BackgroundStretchToFit = True
        Me.Grd1.Col = 0
        Me.Grd1.Cols = 0
        Me.Grd1.ControlStyle = ListViewEx.GLControlStyles.Normal
        Me.Grd1.FullRowSelect = True
        Me.Grd1.GridColor = System.Drawing.Color.LightGray
        Me.Grd1.GridLines = ListViewEx.GLGridLines.gridBoth
        Me.Grd1.GridLineStyle = ListViewEx.GLGridLineStyles.gridSolid
        Me.Grd1.GridTypes = ListViewEx.GLGridTypes.gridOnExists
        Me.Grd1.HeaderHeight = 22
        Me.Grd1.HeaderVisible = True
        Me.Grd1.HeaderWordWrap = False
        Me.Grd1.HotColumnTracking = False
        Me.Grd1.HotItemTracking = False
        Me.Grd1.HotTrackingColor = System.Drawing.Color.LightGray
        Me.Grd1.HoverEvents = False
        Me.Grd1.HoverTime = 1
        Me.Grd1.ImageList = Nothing
        Me.Grd1.ItemHeight = 18
        Me.Grd1.ItemWordWrap = False
        Me.Grd1.Location = New System.Drawing.Point(6, 32)
        Me.Grd1.Name = "Grd1"
        Me.Grd1.Row = 0
        Me.Grd1.Rows = 0
        Me.Grd1.Selectable = True
        Me.Grd1.SelectedTextColor = System.Drawing.Color.White
        Me.Grd1.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.Grd1.ShowBorder = True
        Me.Grd1.ShowFocusRect = False
        Me.Grd1.Size = New System.Drawing.Size(451, 431)
        Me.Grd1.SortType = ListViewEx.SortTypes.InsertionSort
        Me.Grd1.SuperFlatHeaderColor = System.Drawing.Color.White
        Me.Grd1.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(306, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Tag = "Debt"
        Me.Label6.Text = "Thanh toán"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(237, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Tag = "Debt"
        Me.Label7.Text = "Số phát sinh"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Tag = "Account"
        Me.Label8.Text = "Hóa đơn"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(78, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 17)
        Me.Label9.TabIndex = 11
        Me.Label9.Tag = "Name Account"
        Me.Label9.Text = "Diễn giải"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Command_2
        '
        Me._Command_2.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Liet_ke
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(771, 80)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(78, 25)
        Me._Command_2.TabIndex = 147
        Me._Command_2.Tag = "Preview"
        Me._Command_2.Text = "&Xem In"
        '
        '_Command_3
        '
        Me._Command_3.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Liet_ke
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(692, 80)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(78, 25)
        Me._Command_3.TabIndex = 148
        Me._Command_3.Tag = "Listed"
        Me._Command_3.Text = "&Liệt kê"
        '
        'txtshkh
        '
        Me.txtshkh.AcceptsReturn = True
        Me.txtshkh.BackColor = System.Drawing.SystemColors.Window
        Me.txtshkh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtshkh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtshkh.Location = New System.Drawing.Point(100, 85)
        Me.txtshkh.MaxLength = 20
        Me.txtshkh.Name = "txtshkh"
        Me.txtshkh.Size = New System.Drawing.Size(97, 20)
        Me.txtshkh.TabIndex = 149
        Me.txtshkh.Tag = "0"
        '
        'cmdkh
        '
        Me.cmdkh.Image = CType(resources.GetObject("cmdkh.Image"), System.Drawing.Image)
        Me.cmdkh.Location = New System.Drawing.Point(204, 85)
        Me.cmdkh.Name = "cmdkh"
        Me.cmdkh.Size = New System.Drawing.Size(23, 22)
        Me.cmdkh.TabIndex = 150
        '
        'lbkh
        '
        Me.lbkh.BackColor = System.Drawing.Color.Transparent
        Me.lbkh.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbkh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbkh.ForeColor = System.Drawing.Color.Blue
        Me.lbkh.Location = New System.Drawing.Point(236, 85)
        Me.lbkh.Name = "lbkh"
        Me.lbkh.Size = New System.Drawing.Size(233, 17)
        Me.lbkh.TabIndex = 151
        Me.lbkh.Tag = "1"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(22, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 17)
        Me.Label10.TabIndex = 152
        Me.Label10.Tag = ""
        Me.Label10.Text = "Khách hàng"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me._CboThang_1)
        Me.GroupBox2.Controls.Add(Me._CboThang_0)
        Me.GroupBox2.Controls.Add(Me._Label_1)
        Me.GroupBox2.Controls.Add(Me._Label_0)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(25, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(275, 43)
        Me.GroupBox2.TabIndex = 153
        Me.GroupBox2.TabStop = False
        '
        '_CboThang_1
        '
        Me._CboThang_1.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_1.Location = New System.Drawing.Point(195, 13)
        Me._CboThang_1.Name = "_CboThang_1"
        Me._CboThang_1.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_1.TabIndex = 34
        '
        '_CboThang_0
        '
        Me._CboThang_0.BackColor = System.Drawing.SystemColors.Window
        Me._CboThang_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CboThang_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me._CboThang_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._CboThang_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CboThang_0.Location = New System.Drawing.Point(66, 13)
        Me._CboThang_0.Name = "_CboThang_0"
        Me._CboThang_0.Size = New System.Drawing.Size(73, 21)
        Me._CboThang_0.TabIndex = 33
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(145, 16)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(52, 17)
        Me._Label_1.TabIndex = 51
        Me._Label_1.Tag = "to"
        Me._Label_1.Text = "Đến tháng"
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(8, 16)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(52, 17)
        Me._Label_0.TabIndex = 50
        Me._Label_0.Tag = "From"
        Me._Label_0.Text = "Từ tháng"
        '
        'FrmCantrucongno
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1018, 625)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtshkh)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdkh)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me.lbkh)
        Me.Controls.Add(Me._Frame_0)
        Me.Controls.Add(Me._Label_11)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(245, 63)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCantrucongno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Interest Rate Table"
        Me.Text = "Biên bản cấn trừ công nợ"
        Me._Frame_0.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Sub InitializeCommand()
        Me.Command(3) = _Command_3
        Me.Command(2) = _Command_2
        Me.Command(1) = _Command_1
        Me.Command(0) = _Command_0
    End Sub
    Sub InitializeGrdview()
        Me.Grdview(0) = Grd
        Me.Grdview(1) = Grd1
    End Sub
    Sub InitializeChk()
        Me.chk(0) = Chk1
        Me.chk(1) = Chk2
    End Sub
    Sub InitializeCboThang()
        Me.CboThang(1) = _CboThang_1
        Me.CboThang(0) = _CboThang_0
    End Sub
    Private WithEvents _Label_11 As System.Windows.Forms.Label
    Private WithEvents _Frame_0 As System.Windows.Forms.GroupBox
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Public WithEvents Grd As ListViewEx.ListviewExt
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Public WithEvents tien131 As System.Windows.Forms.Label
    Public WithEvents thanhtoan131 As System.Windows.Forms.Label
    Private WithEvents _Label_13 As System.Windows.Forms.Label
    Public WithEvents conlai131 As System.Windows.Forms.Label
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents tien331 As System.Windows.Forms.Label
    Public WithEvents thanhtoan331 As System.Windows.Forms.Label
    Public WithEvents Grd1 As ListViewEx.ListviewExt
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents txtshkh As System.Windows.Forms.TextBox
    Private WithEvents cmdkh As System.Windows.Forms.Button
    Private WithEvents lbkh As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents _CboThang_1 As ComboBoxEx.ComboBoxExt
    Private WithEvents _CboThang_0 As ComboBoxEx.ComboBoxExt
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents dauky131 As System.Windows.Forms.Label
    Public WithEvents dauky331 As System.Windows.Forms.Label
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Chk1 As System.Windows.Forms.CheckBox
    Public WithEvents Chk2 As System.Windows.Forms.CheckBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Cantru As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents conlai331 As System.Windows.Forms.Label
#End Region
End Class
