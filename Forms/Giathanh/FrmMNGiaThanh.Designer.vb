<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMNGiaThanh
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
    Private WithEvents _Cmd1_7 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_8 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_2 As System.Windows.Forms.Button
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Private WithEvents _Cmd1_14 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_16 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_0 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_1 As System.Windows.Forms.Button
    Private WithEvents _Cmd1_15 As System.Windows.Forms.Button
    Public Cmd1(16) As System.Windows.Forms.Button
    Public Frame1(1) As System.Windows.Forms.GroupBox
    Public Line1(4) As System.Windows.Forms.Label
    Public Line7(4) As System.Windows.Forms.Label
    Public Line8(4) As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMNGiaThanh))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me._Cmd1_7 = New System.Windows.Forms.Button
        Me._Cmd1_8 = New System.Windows.Forms.Button
        Me._Cmd1_2 = New System.Windows.Forms.Button
        Me._Cmd1_14 = New System.Windows.Forms.Button
        Me._Cmd1_16 = New System.Windows.Forms.Button
        Me._Cmd1_0 = New System.Windows.Forms.Button
        Me._Cmd1_1 = New System.Windows.Forms.Button
        Me._Cmd1_15 = New System.Windows.Forms.Button
        Me.LabelControl6 = New System.Windows.Forms.Label
        Me.LabelControl1 = New System.Windows.Forms.Label
        Me.LabelControl2 = New System.Windows.Forms.Label
        Me.LabelControl3 = New System.Windows.Forms.Label
        Me.LabelControl4 = New System.Windows.Forms.Label
        Me.LabelControl12 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.Transparent
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.Color.Blue
        Me.Frame2.Location = New System.Drawing.Point(514, 67)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(50, 46)
        Me.Frame2.TabIndex = 9
        Me.Frame2.TabStop = False
        Me.Frame2.Tag = "Lists"
        Me.Frame2.Text = "Danh mục"
        Me.Frame2.Visible = False
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
        Me._Cmd1_7.Location = New System.Drawing.Point(25, 359)
        Me._Cmd1_7.Name = "_Cmd1_7"
        Me._Cmd1_7.Size = New System.Drawing.Size(113, 78)
        Me._Cmd1_7.TabIndex = 4
        Me._Cmd1_7.Tag = "Classification"
        Me._Cmd1_7.Text = " Phân loại lô sản xuất"
        Me._Cmd1_7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_7.UseVisualStyleBackColor = False
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
        Me._Cmd1_8.Location = New System.Drawing.Point(165, 359)
        Me._Cmd1_8.Name = "_Cmd1_8"
        Me._Cmd1_8.Size = New System.Drawing.Size(113, 78)
        Me._Cmd1_8.TabIndex = 5
        Me._Cmd1_8.Tag = "List of plots"
        Me._Cmd1_8.Text = " Danh sách lô sản xuất"
        Me._Cmd1_8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_8.UseVisualStyleBackColor = False
        '
        '_Cmd1_2
        '
        Me._Cmd1_2.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_2.FlatAppearance.BorderSize = 0
        Me._Cmd1_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_2.Image = CType(resources.GetObject("_Cmd1_2.Image"), System.Drawing.Image)
        Me._Cmd1_2.Location = New System.Drawing.Point(634, 80)
        Me._Cmd1_2.Name = "_Cmd1_2"
        Me._Cmd1_2.Size = New System.Drawing.Size(123, 43)
        Me._Cmd1_2.TabIndex = 6
        Me._Cmd1_2.TabStop = False
        Me._Cmd1_2.Tag = ""
        Me._Cmd1_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_2.UseVisualStyleBackColor = False
        '
        '_Cmd1_14
        '
        Me._Cmd1_14.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_14.FlatAppearance.BorderSize = 0
        Me._Cmd1_14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_14.Image = CType(resources.GetObject("_Cmd1_14.Image"), System.Drawing.Image)
        Me._Cmd1_14.Location = New System.Drawing.Point(69, 267)
        Me._Cmd1_14.Name = "_Cmd1_14"
        Me._Cmd1_14.Size = New System.Drawing.Size(120, 41)
        Me._Cmd1_14.TabIndex = 1
        Me._Cmd1_14.TabStop = False
        Me._Cmd1_14.Tag = ""
        Me._Cmd1_14.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_14.UseVisualStyleBackColor = False
        '
        '_Cmd1_16
        '
        Me._Cmd1_16.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_16.FlatAppearance.BorderSize = 0
        Me._Cmd1_16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_16.Image = CType(resources.GetObject("_Cmd1_16.Image"), System.Drawing.Image)
        Me._Cmd1_16.Location = New System.Drawing.Point(634, 267)
        Me._Cmd1_16.Name = "_Cmd1_16"
        Me._Cmd1_16.Size = New System.Drawing.Size(123, 45)
        Me._Cmd1_16.TabIndex = 3
        Me._Cmd1_16.TabStop = False
        Me._Cmd1_16.Tag = ""
        Me._Cmd1_16.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_16.UseVisualStyleBackColor = False
        '
        '_Cmd1_0
        '
        Me._Cmd1_0.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_0.FlatAppearance.BorderSize = 0
        Me._Cmd1_0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_0.Image = CType(resources.GetObject("_Cmd1_0.Image"), System.Drawing.Image)
        Me._Cmd1_0.Location = New System.Drawing.Point(69, 80)
        Me._Cmd1_0.Name = "_Cmd1_0"
        Me._Cmd1_0.Size = New System.Drawing.Size(120, 43)
        Me._Cmd1_0.TabIndex = 0
        Me._Cmd1_0.TabStop = False
        Me._Cmd1_0.Tag = ""
        Me._Cmd1_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_0.UseVisualStyleBackColor = False
        '
        '_Cmd1_1
        '
        Me._Cmd1_1.BackColor = System.Drawing.Color.Transparent
        Me._Cmd1_1.FlatAppearance.BorderSize = 0
        Me._Cmd1_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me._Cmd1_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cmd1_1.Image = CType(resources.GetObject("_Cmd1_1.Image"), System.Drawing.Image)
        Me._Cmd1_1.Location = New System.Drawing.Point(351, 170)
        Me._Cmd1_1.Name = "_Cmd1_1"
        Me._Cmd1_1.Size = New System.Drawing.Size(120, 47)
        Me._Cmd1_1.TabIndex = 2
        Me._Cmd1_1.TabStop = False
        Me._Cmd1_1.Tag = ""
        Me._Cmd1_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_1.UseVisualStyleBackColor = False
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
        Me._Cmd1_15.Location = New System.Drawing.Point(695, 359)
        Me._Cmd1_15.Name = "_Cmd1_15"
        Me._Cmd1_15.Size = New System.Drawing.Size(108, 78)
        Me._Cmd1_15.TabIndex = 7
        Me._Cmd1_15.Tag = "Return"
        Me._Cmd1_15.Text = "Trở &về"
        Me._Cmd1_15.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Cmd1_15.UseVisualStyleBackColor = False
        '
        'LabelControl6
        '
        Me.LabelControl6.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl6.Location = New System.Drawing.Point(66, 124)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(123, 20)
        Me.LabelControl6.TabIndex = 106
        Me.LabelControl6.Tag = "Opening balance"
        Me.LabelControl6.Text = "Dở dang đầu kỳ"
        Me.LabelControl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl1
        '
        Me.LabelControl1.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl1.Location = New System.Drawing.Point(634, 123)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(123, 21)
        Me.LabelControl1.TabIndex = 107
        Me.LabelControl1.Tag = "Production norm"
        Me.LabelControl1.Text = "Định mức thành phẩm"
        Me.LabelControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl2
        '
        Me.LabelControl2.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl2.Location = New System.Drawing.Point(66, 311)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(123, 17)
        Me.LabelControl2.TabIndex = 108
        Me.LabelControl2.Tag = "Finished products"
        Me.LabelControl2.Text = "Nhập kho thành phẩm"
        Me.LabelControl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl3
        '
        Me.LabelControl3.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl3.Location = New System.Drawing.Point(634, 313)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(123, 13)
        Me.LabelControl3.TabIndex = 109
        Me.LabelControl3.Tag = "Recalculate material"
        Me.LabelControl3.Text = "Cập nhật giá xuất kho"
        Me.LabelControl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl4
        '
        Me.LabelControl4.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelControl4.Location = New System.Drawing.Point(348, 218)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(123, 13)
        Me.LabelControl4.TabIndex = 110
        Me.LabelControl4.Tag = "Reports"
        Me.LabelControl4.Text = "Sổ sách báo cáo"
        Me.LabelControl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl12
        '
        Me.LabelControl12.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl12.Location = New System.Drawing.Point(248, 9)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(326, 32)
        Me.LabelControl12.TabIndex = 112
        Me.LabelControl12.Tag = "COST PRICE"
        Me.LabelControl12.Text = "GIÁ THÀNH"
        Me.LabelControl12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmMNGiaThanh
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(830, 460)
        Me.Controls.Add(Me._Cmd1_7)
        Me.Controls.Add(Me._Cmd1_8)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me._Cmd1_1)
        Me.Controls.Add(Me._Cmd1_16)
        Me.Controls.Add(Me._Cmd1_2)
        Me.Controls.Add(Me._Cmd1_14)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me._Cmd1_0)
        Me.Controls.Add(Me._Cmd1_15)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMNGiaThanh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Cost price"
        Me.Text = "Giá thành"
        Me.ResumeLayout(False)

    End Sub
    Sub InitializeCmd1()
        Me.Cmd1(7) = _Cmd1_7
        Me.Cmd1(8) = _Cmd1_8
        Me.Cmd1(2) = _Cmd1_2
        Me.Cmd1(14) = _Cmd1_14
        Me.Cmd1(16) = _Cmd1_16
        Me.Cmd1(0) = _Cmd1_0
        Me.Cmd1(1) = _Cmd1_1
        Me.Cmd1(15) = _Cmd1_15
    End Sub
    Friend WithEvents LabelControl6 As System.Windows.Forms.Label
    Friend WithEvents LabelControl1 As System.Windows.Forms.Label
    Friend WithEvents LabelControl2 As System.Windows.Forms.Label
    Friend WithEvents LabelControl3 As System.Windows.Forms.Label
    Friend WithEvents LabelControl4 As System.Windows.Forms.Label
    Friend WithEvents LabelControl12 As System.Windows.Forms.Label
#End Region
End Class
