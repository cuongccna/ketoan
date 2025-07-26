<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMNCongCu
    Inherits Form

#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        ' Init components
        InitializeComponent()

        InitializeCmd1()
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
    Private WithEvents _Cmd1_10 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_8 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_7 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_4 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_5 As System.Windows.Forms.Button
    Private WithEvents _Frame1_1 As System.Windows.Forms.GroupBox
    Private WithEvents _Cmd1_0 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_2 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_3 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_6 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_9 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_1 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_11 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_15 As System.Windows.Forms.Button
    Public Cmd1(16) As System.Windows.Forms.Button
    Public Frame1(1) As System.Windows.Forms.GroupBox
    Public Line12(1) As System.Windows.Forms.Label
    Public Line3(1) As System.Windows.Forms.Label
    Public Line8(1) As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMNCongCu))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Frame1_1 = New System.Windows.Forms.GroupBox()
        Me._Cmd1_10 = New System.Windows.Forms.Button()
        Me._Cmd1_8 = New System.Windows.Forms.Button()
        Me._Cmd1_7 = New System.Windows.Forms.Button()
        Me._Cmd1_4 = New System.Windows.Forms.Button()
        Me._Cmd1_5 = New System.Windows.Forms.Button()
        Me._Cmd1_2 = New System.Windows.Forms.Button()
        Me._Cmd1_3 = New System.Windows.Forms.Button()
        Me._Cmd1_6 = New System.Windows.Forms.Button()
        Me._Cmd1_1 = New System.Windows.Forms.Button()
        Me._Cmd1_11 = New System.Windows.Forms.Button()
        Me._Cmd1_0 = New System.Windows.Forms.Button()
        Me._Cmd1_9 = New System.Windows.Forms.Button()
        Me._Cmd1_15 = New System.Windows.Forms.Button()
        Me._Cmd1_12 = New System.Windows.Forms.Button()
        Me._Cmd1_13 = New System.Windows.Forms.Button()
        Me.LabelControl7 = New System.Windows.Forms.Label()
        Me.LabelControl9 = New System.Windows.Forms.Label()
        Me.LabelControl2 = New System.Windows.Forms.Label()
        Me.LabelControl1 = New System.Windows.Forms.Label()
        Me.LabelControl8 = New System.Windows.Forms.Label()
        Me.LabelControl3 = New System.Windows.Forms.Label()
        Me.LabelControl6 = New System.Windows.Forms.Label()
        Me.LabelControl5 = New System.Windows.Forms.Label()
        Me.LabelControl4 = New System.Windows.Forms.Label()
        Me.LabelControl10 = New System.Windows.Forms.Label()
        Me._Cmd1_14 = New System.Windows.Forms.Button()
        Me.LabelControl11 = New System.Windows.Forms.Label()
        Me._Cmd1_16 = New System.Windows.Forms.Button()
        Me.LabelControl12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        '_Frame1_1
        '
        Me._Frame1_1.BackColor = System.Drawing.Color.Transparent
        Me._Frame1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame1_1.ForeColor = System.Drawing.Color.Blue
        Me._Frame1_1.Location = New System.Drawing.Point(645, 215)
        Me._Frame1_1.Name = "_Frame1_1"
        Me._Frame1_1.Size = New System.Drawing.Size(45, 31)
        Me._Frame1_1.TabIndex = 14
        Me._Frame1_1.TabStop = False
        Me._Frame1_1.Tag = "Lists"
        Me._Frame1_1.Text = "Danh mục"
        Me._Frame1_1.Visible = False
        '
        '_Cmd1_10
        '
        Me._Cmd1_10.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_10.FlatAppearance.BorderSize = 0
        Me._Cmd1_10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cmd1_10.ForeColor = System.Drawing.Color.Blue
        Me._Cmd1_10.Image = CType(resources.GetObject("_Cmd1_10.Image"), System.Drawing.Image)
        Me._Cmd1_10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_10.Location = New System.Drawing.Point(338, 371)
        Me._Cmd1_10.Name = "_Cmd1_10"
        Me._Cmd1_10.Size = New System.Drawing.Size(111, 79)
        Me._Cmd1_10.TabIndex = 9
        Me._Cmd1_10.Tag = "Expenditure list"
        Me._Cmd1_10.Text = "Sửa giá trị chi phí"
        Me._Cmd1_10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_10.UseVisualStyleBackColor = False
        '
        '_Cmd1_8
        '
        Me._Cmd1_8.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_8.FlatAppearance.BorderSize = 0
        Me._Cmd1_8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cmd1_8.ForeColor = System.Drawing.Color.Blue
        Me._Cmd1_8.Image = CType(resources.GetObject("_Cmd1_8.Image"), System.Drawing.Image)
        Me._Cmd1_8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_8.Location = New System.Drawing.Point(188, 371)
        Me._Cmd1_8.Name = "_Cmd1_8"
        Me._Cmd1_8.Size = New System.Drawing.Size(111, 79)
        Me._Cmd1_8.TabIndex = 8
        Me._Cmd1_8.Tag = "Tools list"
        Me._Cmd1_8.Text = "Sửa giá trị công cụ"
        Me._Cmd1_8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_8.UseVisualStyleBackColor = False
        '
        '_Cmd1_7
        '
        Me._Cmd1_7.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_7.FlatAppearance.BorderSize = 0
        Me._Cmd1_7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cmd1_7.ForeColor = System.Drawing.Color.Blue
        Me._Cmd1_7.Image = CType(resources.GetObject("_Cmd1_7.Image"), System.Drawing.Image)
        Me._Cmd1_7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_7.Location = New System.Drawing.Point(30, 371)
        Me._Cmd1_7.Name = "_Cmd1_7"
        Me._Cmd1_7.Size = New System.Drawing.Size(111, 79)
        Me._Cmd1_7.TabIndex = 7
        Me._Cmd1_7.Tag = "Classification"
        Me._Cmd1_7.Text = "Phân loại dụng cụ"
        Me._Cmd1_7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_7.UseVisualStyleBackColor = False
        '
        '_Cmd1_4
        '
        Me._Cmd1_4.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_4.FlatAppearance.BorderSize = 0
        Me._Cmd1_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cmd1_4.ForeColor = System.Drawing.Color.Blue
        Me._Cmd1_4.Image = CType(resources.GetObject("_Cmd1_4.Image"), System.Drawing.Image)
        Me._Cmd1_4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_4.Location = New System.Drawing.Point(489, 371)
        Me._Cmd1_4.Name = "_Cmd1_4"
        Me._Cmd1_4.Size = New System.Drawing.Size(111, 79)
        Me._Cmd1_4.TabIndex = 10
        Me._Cmd1_4.Tag = "Management"
        Me._Cmd1_4.Text = "Đối tượng quản lý"
        Me._Cmd1_4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_4.UseVisualStyleBackColor = False
        '
        '_Cmd1_5
        '
        Me._Cmd1_5.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_5.FlatAppearance.BorderSize = 0
        Me._Cmd1_5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cmd1_5.ForeColor = System.Drawing.Color.Blue
        Me._Cmd1_5.Image = CType(resources.GetObject("_Cmd1_5.Image"), System.Drawing.Image)
        Me._Cmd1_5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_5.Location = New System.Drawing.Point(642, 371)
        Me._Cmd1_5.Name = "_Cmd1_5"
        Me._Cmd1_5.Size = New System.Drawing.Size(111, 79)
        Me._Cmd1_5.TabIndex = 11
        Me._Cmd1_5.Tag = "Set Account"
        Me._Cmd1_5.Text = "TK chi phí phân bổ"
        Me._Cmd1_5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_5.UseVisualStyleBackColor = False
        '
        '_Cmd1_2
        '
        Me._Cmd1_2.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_2.FlatAppearance.BorderSize = 0
        Me._Cmd1_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_2.Image = CType(resources.GetObject("_Cmd1_2.Image"), System.Drawing.Image)
        Me._Cmd1_2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_2.Location = New System.Drawing.Point(388, 176)
        Me._Cmd1_2.Name = "_Cmd1_2"
        Me._Cmd1_2.Size = New System.Drawing.Size(138, 46)
        Me._Cmd1_2.TabIndex = 5
        Me._Cmd1_2.TabStop = False
        Me._Cmd1_2.Tag = "Books tools"
        Me._Cmd1_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_2.UseVisualStyleBackColor = False
        '
        '_Cmd1_3
        '
        Me._Cmd1_3.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_3.FlatAppearance.BorderSize = 0
        Me._Cmd1_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_3.Image = CType(resources.GetObject("_Cmd1_3.Image"), System.Drawing.Image)
        Me._Cmd1_3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_3.Location = New System.Drawing.Point(24, 175)
        Me._Cmd1_3.Name = "_Cmd1_3"
        Me._Cmd1_3.Size = New System.Drawing.Size(137, 37)
        Me._Cmd1_3.TabIndex = 3
        Me._Cmd1_3.TabStop = False
        Me._Cmd1_3.Tag = "Enter Prepaid Expenditure"
        Me._Cmd1_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_3.UseVisualStyleBackColor = False
        '
        '_Cmd1_6
        '
        Me._Cmd1_6.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_6.FlatAppearance.BorderSize = 0
        Me._Cmd1_6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_6.Image = CType(resources.GetObject("_Cmd1_6.Image"), System.Drawing.Image)
        Me._Cmd1_6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_6.Location = New System.Drawing.Point(504, 282)
        Me._Cmd1_6.Name = "_Cmd1_6"
        Me._Cmd1_6.Size = New System.Drawing.Size(140, 39)
        Me._Cmd1_6.TabIndex = 4
        Me._Cmd1_6.TabStop = False
        Me._Cmd1_6.Tag = "Apportion"
        Me._Cmd1_6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_6.UseVisualStyleBackColor = False
        '
        '_Cmd1_1
        '
        Me._Cmd1_1.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_1.FlatAppearance.BorderSize = 0
        Me._Cmd1_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_1.Image = CType(resources.GetObject("_Cmd1_1.Image"), System.Drawing.Image)
        Me._Cmd1_1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_1.Location = New System.Drawing.Point(276, 51)
        Me._Cmd1_1.Name = "_Cmd1_1"
        Me._Cmd1_1.Size = New System.Drawing.Size(137, 38)
        Me._Cmd1_1.TabIndex = 2
        Me._Cmd1_1.TabStop = False
        Me._Cmd1_1.Tag = "Opening balance"
        Me._Cmd1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_1.UseVisualStyleBackColor = False
        '
        '_Cmd1_11
        '
        Me._Cmd1_11.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_11.FlatAppearance.BorderSize = 0
        Me._Cmd1_11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_11.Image = CType(resources.GetObject("_Cmd1_11.Image"), System.Drawing.Image)
        Me._Cmd1_11.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_11.Location = New System.Drawing.Point(276, 284)
        Me._Cmd1_11.Name = "_Cmd1_11"
        Me._Cmd1_11.Size = New System.Drawing.Size(137, 40)
        Me._Cmd1_11.TabIndex = 6
        Me._Cmd1_11.TabStop = False
        Me._Cmd1_11.Tag = "Voucher List"
        Me._Cmd1_11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_11.UseVisualStyleBackColor = False
        '
        '_Cmd1_0
        '
        Me._Cmd1_0.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_0.FlatAppearance.BorderSize = 0
        Me._Cmd1_0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_0.Image = CType(resources.GetObject("_Cmd1_0.Image"), System.Drawing.Image)
        Me._Cmd1_0.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_0.Location = New System.Drawing.Point(65, 268)
        Me._Cmd1_0.Name = "_Cmd1_0"
        Me._Cmd1_0.Size = New System.Drawing.Size(139, 47)
        Me._Cmd1_0.TabIndex = 1
        Me._Cmd1_0.TabStop = False
        Me._Cmd1_0.Tag = "Tools Increasing"
        Me._Cmd1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_0.UseVisualStyleBackColor = False
        '
        '_Cmd1_9
        '
        Me._Cmd1_9.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_9.FlatAppearance.BorderSize = 0
        Me._Cmd1_9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_9.Image = CType(resources.GetObject("_Cmd1_9.Image"), System.Drawing.Image)
        Me._Cmd1_9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_9.Location = New System.Drawing.Point(65, 83)
        Me._Cmd1_9.Name = "_Cmd1_9"
        Me._Cmd1_9.Size = New System.Drawing.Size(138, 43)
        Me._Cmd1_9.TabIndex = 0
        Me._Cmd1_9.TabStop = False
        Me._Cmd1_9.Tag = "Opening balance"
        Me._Cmd1_9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_9.UseVisualStyleBackColor = False
        '
        '_Cmd1_15
        '
        Me._Cmd1_15.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_15.FlatAppearance.BorderSize = 0
        Me._Cmd1_15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Cmd1_15.ForeColor = System.Drawing.Color.Blue
        Me._Cmd1_15.Image = CType(resources.GetObject("_Cmd1_15.Image"), System.Drawing.Image)
        Me._Cmd1_15.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_15.Location = New System.Drawing.Point(796, 371)
        Me._Cmd1_15.Name = "_Cmd1_15"
        Me._Cmd1_15.Size = New System.Drawing.Size(111, 79)
        Me._Cmd1_15.TabIndex = 12
        Me._Cmd1_15.Tag = "Return"
        Me._Cmd1_15.Text = "Trở &về"
        Me._Cmd1_15.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_15.UseVisualStyleBackColor = False
        '
        '_Cmd1_12
        '
        Me._Cmd1_12.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_12.FlatAppearance.BorderSize = 0
        Me._Cmd1_12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_12.Image = CType(resources.GetObject("_Cmd1_12.Image"), System.Drawing.Image)
        Me._Cmd1_12.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_12.Location = New System.Drawing.Point(706, 269)
        Me._Cmd1_12.Name = "_Cmd1_12"
        Me._Cmd1_12.Size = New System.Drawing.Size(137, 42)
        Me._Cmd1_12.TabIndex = 15
        Me._Cmd1_12.TabStop = False
        Me._Cmd1_12.Tag = "Voucher Adjusting"
        Me._Cmd1_12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_12.UseVisualStyleBackColor = False
        '
        '_Cmd1_13
        '
        Me._Cmd1_13.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_13.FlatAppearance.BorderSize = 0
        Me._Cmd1_13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_13.Image = CType(resources.GetObject("_Cmd1_13.Image"), System.Drawing.Image)
        Me._Cmd1_13.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_13.Location = New System.Drawing.Point(702, 90)
        Me._Cmd1_13.Name = "_Cmd1_13"
        Me._Cmd1_13.Size = New System.Drawing.Size(141, 40)
        Me._Cmd1_13.TabIndex = 16
        Me._Cmd1_13.TabStop = False
        Me._Cmd1_13.Tag = "Voucher List"
        Me._Cmd1_13.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_13.UseVisualStyleBackColor = False
        '
        'LabelControl7
        '
        Me.LabelControl7.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl7.Location = New System.Drawing.Point(703, 308)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(140, 28)
        Me.LabelControl7.TabIndex = 83
        Me.LabelControl7.Tag = "Voucher Adjusting, decrease"
        Me.LabelControl7.Text = "Chứng từ điều chỉnh,giảm"
        Me.LabelControl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl9
        '
        Me.LabelControl9.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl9.Location = New System.Drawing.Point(21, 215)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(140, 25)
        Me.LabelControl9.TabIndex = 91
        Me.LabelControl9.Tag = "Enter Costs"
        Me.LabelControl9.Text = "Chi phí mua"
        Me.LabelControl9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl2
        '
        Me.LabelControl2.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl2.Location = New System.Drawing.Point(69, 318)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(134, 13)
        Me.LabelControl2.TabIndex = 97
        Me.LabelControl2.Tag = "Tools Increasing"
        Me.LabelControl2.Text = "Tăng CCDC"
        Me.LabelControl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl1
        '
        Me.LabelControl1.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl1.Location = New System.Drawing.Point(62, 129)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(141, 17)
        Me.LabelControl1.TabIndex = 98
        Me.LabelControl1.Tag = "Opening balance Tools"
        Me.LabelControl1.Text = "CCDC đầu kỳ"
        Me.LabelControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl8
        '
        Me.LabelControl8.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl8.Location = New System.Drawing.Point(273, 92)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(129, 24)
        Me.LabelControl8.TabIndex = 99
        Me.LabelControl8.Tag = "Opening balance P.Ex"
        Me.LabelControl8.Text = "CPTT đầu kỳ"
        Me.LabelControl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl3
        '
        Me.LabelControl3.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl3.Location = New System.Drawing.Point(505, 324)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(139, 13)
        Me.LabelControl3.TabIndex = 100
        Me.LabelControl3.Tag = "Apportion"
        Me.LabelControl3.Text = "Phân bổ"
        Me.LabelControl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl6
        '
        Me.LabelControl6.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl6.Location = New System.Drawing.Point(276, 327)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(137, 18)
        Me.LabelControl6.TabIndex = 101
        Me.LabelControl6.Tag = "Tools Decreasing"
        Me.LabelControl6.Text = "Giảm CCDC"
        Me.LabelControl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl5
        '
        Me.LabelControl5.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl5.Location = New System.Drawing.Point(699, 133)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(144, 22)
        Me.LabelControl5.TabIndex = 102
        Me.LabelControl5.Tag = "P.Ex Decreasing"
        Me.LabelControl5.Text = "Giảm CPTT"
        Me.LabelControl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl4
        '
        Me.LabelControl4.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl4.Location = New System.Drawing.Point(385, 225)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(141, 13)
        Me.LabelControl4.TabIndex = 103
        Me.LabelControl4.Tag = "Reports"
        Me.LabelControl4.Text = "Sổ sách báo cáo"
        Me.LabelControl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl10
        '
        Me.LabelControl10.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl10.Location = New System.Drawing.Point(502, 94)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(143, 22)
        Me.LabelControl10.TabIndex = 105
        Me.LabelControl10.Tag = "P.Ex Increasing"
        Me.LabelControl10.Text = "Tăng CPTT"
        Me.LabelControl10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_Cmd1_14
        '
        Me._Cmd1_14.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_14.FlatAppearance.BorderSize = 0
        Me._Cmd1_14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_14.Image = CType(resources.GetObject("_Cmd1_14.Image"), System.Drawing.Image)
        Me._Cmd1_14.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_14.Location = New System.Drawing.Point(505, 53)
        Me._Cmd1_14.Name = "_Cmd1_14"
        Me._Cmd1_14.Size = New System.Drawing.Size(140, 38)
        Me._Cmd1_14.TabIndex = 104
        Me._Cmd1_14.TabStop = False
        Me._Cmd1_14.Tag = "Enter Prepaid Expenditure"
        Me._Cmd1_14.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_14.UseVisualStyleBackColor = False
        '
        'LabelControl11
        '
        Me.LabelControl11.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl11.Location = New System.Drawing.Point(766, 221)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(131, 19)
        Me.LabelControl11.TabIndex = 107
        Me.LabelControl11.Tag = "Voucher List"
        Me.LabelControl11.Text = "Tra cứu chứng từ"
        Me.LabelControl11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_Cmd1_16
        '
        Me._Cmd1_16.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_16.FlatAppearance.BorderSize = 0
        Me._Cmd1_16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_16.Image = CType(resources.GetObject("_Cmd1_16.Image"), System.Drawing.Image)
        Me._Cmd1_16.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me._Cmd1_16.Location = New System.Drawing.Point(766, 180)
        Me._Cmd1_16.Name = "_Cmd1_16"
        Me._Cmd1_16.Size = New System.Drawing.Size(131, 39)
        Me._Cmd1_16.TabIndex = 106
        Me._Cmd1_16.TabStop = False
        Me._Cmd1_16.Tag = "Voucher List"
        Me._Cmd1_16.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_16.UseVisualStyleBackColor = False
        '
        'LabelControl12
        '
        Me.LabelControl12.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl12.Location = New System.Drawing.Point(300, 11)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(345, 32)
        Me.LabelControl12.TabIndex = 109
        Me.LabelControl12.Tag = "TOOLS - PREPAID EXPENSES"
        Me.LabelControl12.Text = "CÔNG CỤ DỤNG CỤ - CHI PHÍ TRẢ TRƯỚC"
        Me.LabelControl12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmMNCongCu
        '
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(931, 472)
        Me.Controls.Add(Me._Cmd1_10)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me._Cmd1_8)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me._Cmd1_7)
        Me.Controls.Add(Me._Cmd1_4)
        Me.Controls.Add(Me._Cmd1_16)
        Me.Controls.Add(Me._Cmd1_5)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me._Cmd1_14)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me._Cmd1_13)
        Me.Controls.Add(Me._Cmd1_12)
        Me.Controls.Add(Me._Cmd1_11)
        Me.Controls.Add(Me._Cmd1_2)
        Me.Controls.Add(Me._Cmd1_0)
        Me.Controls.Add(Me._Cmd1_6)
        Me.Controls.Add(Me._Cmd1_3)
        Me.Controls.Add(Me._Cmd1_1)
        Me.Controls.Add(Me._Frame1_1)
        Me.Controls.Add(Me._Cmd1_15)
        Me.Controls.Add(Me._Cmd1_9)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMNCongCu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Tools - Prepaid expenses"
        Me.Text = " Công cụ dụng cụ - Chi phí trả trước"
        Me.ResumeLayout(False)

    End Sub

    Sub InitializeCmd1()
        Me.Cmd1(10) = _Cmd1_10
        Me.Cmd1(8) = _Cmd1_8
        Me.Cmd1(7) = _Cmd1_7
        Me.Cmd1(4) = _Cmd1_4
        Me.Cmd1(5) = _Cmd1_5
        Me.Cmd1(0) = _Cmd1_0
        Me.Cmd1(2) = _Cmd1_2
        Me.Cmd1(3) = _Cmd1_3
        Me.Cmd1(6) = _Cmd1_6
        Me.Cmd1(9) = _Cmd1_9
        Me.Cmd1(1) = _Cmd1_1
        Me.Cmd1(11) = _Cmd1_11
        Me.Cmd1(12) = _Cmd1_12
        Me.Cmd1(13) = _Cmd1_13
        Me.Cmd1(14) = _Cmd1_14
        Me.Cmd1(15) = _Cmd1_15
        Me.Cmd1(16) = _Cmd1_16
    End Sub
    Private WithEvents _Cmd1_12 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_13 As System.Windows.Forms.Button
    Friend WithEvents LabelControl7 As System.Windows.Forms.Label
    Friend WithEvents LabelControl9 As System.Windows.Forms.Label
    Friend WithEvents LabelControl2 As System.Windows.Forms.Label
    Friend WithEvents LabelControl1 As System.Windows.Forms.Label
    Friend WithEvents LabelControl8 As System.Windows.Forms.Label
    Friend WithEvents LabelControl3 As System.Windows.Forms.Label
    Friend WithEvents LabelControl6 As System.Windows.Forms.Label
    Friend WithEvents LabelControl5 As System.Windows.Forms.Label
    Friend WithEvents LabelControl4 As System.Windows.Forms.Label
    Friend WithEvents LabelControl10 As System.Windows.Forms.Label
    Private WithEvents _Cmd1_14 As System.Windows.Forms.Button
    Friend WithEvents LabelControl11 As System.Windows.Forms.Label
    Private WithEvents _Cmd1_16 As System.Windows.Forms.Button
    Friend WithEvents LabelControl12 As System.Windows.Forms.Label
#End Region
End Class
