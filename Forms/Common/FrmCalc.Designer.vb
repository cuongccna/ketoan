<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalc
    Inherits Form

#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        ' Init components
        InitializeComponent()
        InitializeLabel()
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
    Private WithEvents _Button_27 As System.Windows.Forms.Button
    Private WithEvents _Button_26 As System.Windows.Forms.Button
    Private WithEvents _Button_25 As System.Windows.Forms.Button
    Private WithEvents _Button_24 As System.Windows.Forms.Button
    Private WithEvents _Button_23 As System.Windows.Forms.Button
    Private WithEvents _Button_22 As System.Windows.Forms.Button
    Private WithEvents _Button_21 As System.Windows.Forms.Button
    Private WithEvents _Button_20 As System.Windows.Forms.Button
    Private WithEvents _Button_19 As System.Windows.Forms.Button
    Private WithEvents _Button_18 As System.Windows.Forms.Button
    Private WithEvents _Button_17 As System.Windows.Forms.Button
    Private WithEvents _Button_16 As System.Windows.Forms.Button
    Private WithEvents _Button_15 As System.Windows.Forms.Button
    Private WithEvents _Button_14 As System.Windows.Forms.Button
    Private WithEvents _Button_13 As System.Windows.Forms.Button
    Private WithEvents _Button_12 As System.Windows.Forms.Button
    Private WithEvents _Button_11 As System.Windows.Forms.Button
    Private WithEvents _Button_10 As System.Windows.Forms.Button
    Private WithEvents _Button_9 As System.Windows.Forms.Button
    Private WithEvents _Button_8 As System.Windows.Forms.Button
    Private WithEvents _Button_7 As System.Windows.Forms.Button
    Private WithEvents _Button_6 As System.Windows.Forms.Button
    Private WithEvents _Button_5 As System.Windows.Forms.Button
    Private WithEvents _Button_4 As System.Windows.Forms.Button
    Private WithEvents _Button_3 As System.Windows.Forms.Button
    Private WithEvents _Button_2 As System.Windows.Forms.Button
    Private WithEvents _Button_1 As System.Windows.Forms.Button
    Private WithEvents _Button_0 As System.Windows.Forms.Button
    Public Label(27) As System.Windows.Forms.Button
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCalc))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Button_26 = New System.Windows.Forms.Button()
        Me._Button_25 = New System.Windows.Forms.Button()
        Me._Button_24 = New System.Windows.Forms.Button()
        Me._Button_23 = New System.Windows.Forms.Button()
        Me._Button_22 = New System.Windows.Forms.Button()
        Me._Button_21 = New System.Windows.Forms.Button()
        Me._Button_18 = New System.Windows.Forms.Button()
        Me._Button_17 = New System.Windows.Forms.Button()
        Me._Button_16 = New System.Windows.Forms.Button()
        Me._Button_10 = New System.Windows.Forms.Button()
        Me._Button_27 = New System.Windows.Forms.Button()
        Me._Button_20 = New System.Windows.Forms.Button()
        Me._Button_19 = New System.Windows.Forms.Button()
        Me._Button_15 = New System.Windows.Forms.Button()
        Me._Button_14 = New System.Windows.Forms.Button()
        Me._Button_13 = New System.Windows.Forms.Button()
        Me._Button_12 = New System.Windows.Forms.Button()
        Me._Button_11 = New System.Windows.Forms.Button()
        Me._Button_9 = New System.Windows.Forms.Button()
        Me._Button_8 = New System.Windows.Forms.Button()
        Me._Button_7 = New System.Windows.Forms.Button()
        Me._Button_6 = New System.Windows.Forms.Button()
        Me._Button_5 = New System.Windows.Forms.Button()
        Me._Button_4 = New System.Windows.Forms.Button()
        Me._Button_3 = New System.Windows.Forms.Button()
        Me._Button_2 = New System.Windows.Forms.Button()
        Me._Button_1 = New System.Windows.Forms.Button()
        Me._Button_0 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.kq = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Button_26
        '
        Me._Button_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_26.Location = New System.Drawing.Point(9, 189)
        Me._Button_26.Name = "_Button_26"
        Me._Button_26.Size = New System.Drawing.Size(39, 26)
        Me._Button_26.TabIndex = 26
        Me._Button_26.TabStop = False
        Me._Button_26.Text = "M+"
        Me.ToolTipMain.SetToolTip(Me._Button_26, "P")
        '
        '_Button_25
        '
        Me._Button_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_25.Location = New System.Drawing.Point(9, 157)
        Me._Button_25.Name = "_Button_25"
        Me._Button_25.Size = New System.Drawing.Size(39, 26)
        Me._Button_25.TabIndex = 25
        Me._Button_25.TabStop = False
        Me._Button_25.Text = "MS"
        Me.ToolTipMain.SetToolTip(Me._Button_25, "M")
        '
        '_Button_24
        '
        Me._Button_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_24.Location = New System.Drawing.Point(9, 125)
        Me._Button_24.Name = "_Button_24"
        Me._Button_24.Size = New System.Drawing.Size(39, 26)
        Me._Button_24.TabIndex = 24
        Me._Button_24.TabStop = False
        Me._Button_24.Text = "MR"
        Me.ToolTipMain.SetToolTip(Me._Button_24, "R")
        '
        '_Button_23
        '
        Me._Button_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_23.Location = New System.Drawing.Point(9, 93)
        Me._Button_23.Name = "_Button_23"
        Me._Button_23.Size = New System.Drawing.Size(39, 26)
        Me._Button_23.TabIndex = 23
        Me._Button_23.TabStop = False
        Me._Button_23.Text = "MC"
        Me.ToolTipMain.SetToolTip(Me._Button_23, "C")
        '
        '_Button_22
        '
        Me._Button_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_22.Location = New System.Drawing.Point(234, 61)
        Me._Button_22.Name = "_Button_22"
        Me._Button_22.Size = New System.Drawing.Size(39, 26)
        Me._Button_22.TabIndex = 22
        Me._Button_22.TabStop = False
        Me._Button_22.Text = "C"
        Me.ToolTipMain.SetToolTip(Me._Button_22, "F12")
        '
        '_Button_21
        '
        Me._Button_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_21.Location = New System.Drawing.Point(189, 61)
        Me._Button_21.Name = "_Button_21"
        Me._Button_21.Size = New System.Drawing.Size(39, 26)
        Me._Button_21.TabIndex = 21
        Me._Button_21.TabStop = False
        Me._Button_21.Text = "CE"
        Me.ToolTipMain.SetToolTip(Me._Button_21, "Del")
        '
        '_Button_18
        '
        Me._Button_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_18.Location = New System.Drawing.Point(234, 157)
        Me._Button_18.Name = "_Button_18"
        Me._Button_18.Size = New System.Drawing.Size(39, 26)
        Me._Button_18.TabIndex = 18
        Me._Button_18.TabStop = False
        Me._Button_18.Text = "1/x"
        Me.ToolTipMain.SetToolTip(Me._Button_18, "End")
        '
        '_Button_17
        '
        Me._Button_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_17.Location = New System.Drawing.Point(234, 125)
        Me._Button_17.Name = "_Button_17"
        Me._Button_17.Size = New System.Drawing.Size(39, 26)
        Me._Button_17.TabIndex = 17
        Me._Button_17.TabStop = False
        Me._Button_17.Text = "%"
        Me.ToolTipMain.SetToolTip(Me._Button_17, "\")
        '
        '_Button_16
        '
        Me._Button_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_16.Location = New System.Drawing.Point(234, 93)
        Me._Button_16.Name = "_Button_16"
        Me._Button_16.Size = New System.Drawing.Size(39, 26)
        Me._Button_16.TabIndex = 16
        Me._Button_16.TabStop = False
        Me._Button_16.Text = "sqrt"
        Me.ToolTipMain.SetToolTip(Me._Button_16, "Home")
        '
        '_Button_10
        '
        Me._Button_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_10.Location = New System.Drawing.Point(99, 189)
        Me._Button_10.Name = "_Button_10"
        Me._Button_10.Size = New System.Drawing.Size(39, 26)
        Me._Button_10.TabIndex = 10
        Me._Button_10.TabStop = False
        Me._Button_10.Text = "+/-"
        Me.ToolTipMain.SetToolTip(Me._Button_10, "PageUp / PageDown")
        '
        '_Button_27
        '
        Me._Button_27.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_27.Enabled = False
        Me._Button_27.Location = New System.Drawing.Point(99, 61)
        Me._Button_27.Name = "_Button_27"
        Me._Button_27.Size = New System.Drawing.Size(39, 26)
        Me._Button_27.TabIndex = 27
        Me._Button_27.TabStop = False
        '
        '_Button_20
        '
        Me._Button_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_20.Location = New System.Drawing.Point(144, 61)
        Me._Button_20.Name = "_Button_20"
        Me._Button_20.Size = New System.Drawing.Size(39, 26)
        Me._Button_20.TabIndex = 20
        Me._Button_20.TabStop = False
        Me._Button_20.Text = "Back"
        '
        '_Button_19
        '
        Me._Button_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_19.Location = New System.Drawing.Point(234, 189)
        Me._Button_19.Name = "_Button_19"
        Me._Button_19.Size = New System.Drawing.Size(39, 26)
        Me._Button_19.TabIndex = 19
        Me._Button_19.TabStop = False
        Me._Button_19.Text = "="
        '
        '_Button_15
        '
        Me._Button_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_15.Location = New System.Drawing.Point(189, 189)
        Me._Button_15.Name = "_Button_15"
        Me._Button_15.Size = New System.Drawing.Size(39, 26)
        Me._Button_15.TabIndex = 15
        Me._Button_15.TabStop = False
        Me._Button_15.Text = "+"
        '
        '_Button_14
        '
        Me._Button_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_14.Location = New System.Drawing.Point(189, 157)
        Me._Button_14.Name = "_Button_14"
        Me._Button_14.Size = New System.Drawing.Size(39, 26)
        Me._Button_14.TabIndex = 14
        Me._Button_14.TabStop = False
        Me._Button_14.Text = "-"
        '
        '_Button_13
        '
        Me._Button_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_13.Location = New System.Drawing.Point(189, 125)
        Me._Button_13.Name = "_Button_13"
        Me._Button_13.Size = New System.Drawing.Size(39, 26)
        Me._Button_13.TabIndex = 13
        Me._Button_13.TabStop = False
        Me._Button_13.Text = "*"
        '
        '_Button_12
        '
        Me._Button_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_12.Location = New System.Drawing.Point(189, 93)
        Me._Button_12.Name = "_Button_12"
        Me._Button_12.Size = New System.Drawing.Size(39, 26)
        Me._Button_12.TabIndex = 12
        Me._Button_12.TabStop = False
        Me._Button_12.Text = "/"
        '
        '_Button_11
        '
        Me._Button_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_11.Location = New System.Drawing.Point(144, 189)
        Me._Button_11.Name = "_Button_11"
        Me._Button_11.Size = New System.Drawing.Size(39, 26)
        Me._Button_11.TabIndex = 11
        Me._Button_11.TabStop = False
        Me._Button_11.Text = "."
        '
        '_Button_9
        '
        Me._Button_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_9.Location = New System.Drawing.Point(144, 93)
        Me._Button_9.Name = "_Button_9"
        Me._Button_9.Size = New System.Drawing.Size(39, 26)
        Me._Button_9.TabIndex = 9
        Me._Button_9.TabStop = False
        Me._Button_9.Text = "9"
        '
        '_Button_8
        '
        Me._Button_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_8.Location = New System.Drawing.Point(99, 93)
        Me._Button_8.Name = "_Button_8"
        Me._Button_8.Size = New System.Drawing.Size(39, 26)
        Me._Button_8.TabIndex = 8
        Me._Button_8.TabStop = False
        Me._Button_8.Text = "8"
        '
        '_Button_7
        '
        Me._Button_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_7.Location = New System.Drawing.Point(54, 93)
        Me._Button_7.Name = "_Button_7"
        Me._Button_7.Size = New System.Drawing.Size(39, 26)
        Me._Button_7.TabIndex = 7
        Me._Button_7.TabStop = False
        Me._Button_7.Text = "7"
        '
        '_Button_6
        '
        Me._Button_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_6.Location = New System.Drawing.Point(144, 125)
        Me._Button_6.Name = "_Button_6"
        Me._Button_6.Size = New System.Drawing.Size(39, 26)
        Me._Button_6.TabIndex = 6
        Me._Button_6.TabStop = False
        Me._Button_6.Text = "6"
        '
        '_Button_5
        '
        Me._Button_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_5.Location = New System.Drawing.Point(99, 125)
        Me._Button_5.Name = "_Button_5"
        Me._Button_5.Size = New System.Drawing.Size(39, 26)
        Me._Button_5.TabIndex = 5
        Me._Button_5.TabStop = False
        Me._Button_5.Text = "5"
        '
        '_Button_4
        '
        Me._Button_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_4.Location = New System.Drawing.Point(54, 125)
        Me._Button_4.Name = "_Button_4"
        Me._Button_4.Size = New System.Drawing.Size(39, 26)
        Me._Button_4.TabIndex = 4
        Me._Button_4.TabStop = False
        Me._Button_4.Text = "4"
        '
        '_Button_3
        '
        Me._Button_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_3.Location = New System.Drawing.Point(144, 157)
        Me._Button_3.Name = "_Button_3"
        Me._Button_3.Size = New System.Drawing.Size(39, 26)
        Me._Button_3.TabIndex = 3
        Me._Button_3.TabStop = False
        Me._Button_3.Text = "3"
        '
        '_Button_2
        '
        Me._Button_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_2.Location = New System.Drawing.Point(99, 157)
        Me._Button_2.Name = "_Button_2"
        Me._Button_2.Size = New System.Drawing.Size(39, 26)
        Me._Button_2.TabIndex = 2
        Me._Button_2.TabStop = False
        Me._Button_2.Text = "2"
        '
        '_Button_1
        '
        Me._Button_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_1.Location = New System.Drawing.Point(54, 157)
        Me._Button_1.Name = "_Button_1"
        Me._Button_1.Size = New System.Drawing.Size(39, 26)
        Me._Button_1.TabIndex = 1
        Me._Button_1.TabStop = False
        Me._Button_1.Text = "1"
        '
        '_Button_0
        '
        Me._Button_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_0.Location = New System.Drawing.Point(54, 189)
        Me._Button_0.Name = "_Button_0"
        Me._Button_0.Size = New System.Drawing.Size(39, 26)
        Me._Button_0.TabIndex = 0
        Me._Button_0.TabStop = False
        Me._Button_0.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Nothing 'Global.NVC.My.Resources.Resources.Text_bg6
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.kq)
        Me.Panel1.Location = New System.Drawing.Point(9, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 36)
        Me.Panel1.TabIndex = 29
        '
        'kq
        '
        Me.kq.BackColor = System.Drawing.Color.Transparent
        Me.kq.Cursor = System.Windows.Forms.Cursors.Default
        Me.kq.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kq.ForeColor = System.Drawing.Color.Black
        Me.kq.Location = New System.Drawing.Point(-1, 2)
        Me.kq.Name = "kq"
        Me.kq.Size = New System.Drawing.Size(264, 28)
        Me.kq.TabIndex = 30
        Me.kq.Text = "0"
        Me.kq.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FrmCalc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(283, 224)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me._Button_27)
        Me.Controls.Add(Me._Button_26)
        Me.Controls.Add(Me._Button_25)
        Me.Controls.Add(Me._Button_24)
        Me.Controls.Add(Me._Button_23)
        Me.Controls.Add(Me._Button_22)
        Me.Controls.Add(Me._Button_21)
        Me.Controls.Add(Me._Button_20)
        Me.Controls.Add(Me._Button_19)
        Me.Controls.Add(Me._Button_18)
        Me.Controls.Add(Me._Button_17)
        Me.Controls.Add(Me._Button_16)
        Me.Controls.Add(Me._Button_15)
        Me.Controls.Add(Me._Button_14)
        Me.Controls.Add(Me._Button_13)
        Me.Controls.Add(Me._Button_12)
        Me.Controls.Add(Me._Button_11)
        Me.Controls.Add(Me._Button_10)
        Me.Controls.Add(Me._Button_9)
        Me.Controls.Add(Me._Button_8)
        Me.Controls.Add(Me._Button_7)
        Me.Controls.Add(Me._Button_6)
        Me.Controls.Add(Me._Button_5)
        Me.Controls.Add(Me._Button_4)
        Me.Controls.Add(Me._Button_3)
        Me.Controls.Add(Me._Button_2)
        Me.Controls.Add(Me._Button_1)
        Me.Controls.Add(Me._Button_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(270, 232)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCalc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Calculator"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Sub InitializeLabel()
        Me.Label(27) = _Button_27
        Me.Label(26) = _Button_26
        Me.Label(25) = _Button_25
        Me.Label(24) = _Button_24
        Me.Label(23) = _Button_23
        Me.Label(22) = _Button_22
        Me.Label(21) = _Button_21
        Me.Label(20) = _Button_20
        Me.Label(19) = _Button_19
        Me.Label(18) = _Button_18
        Me.Label(17) = _Button_17
        Me.Label(16) = _Button_16
        Me.Label(15) = _Button_15
        Me.Label(14) = _Button_14
        Me.Label(13) = _Button_13
        Me.Label(12) = _Button_12
        Me.Label(11) = _Button_11
        Me.Label(10) = _Button_10
        Me.Label(9) = _Button_9
        Me.Label(8) = _Button_8
        Me.Label(7) = _Button_7
        Me.Label(6) = _Button_6
        Me.Label(5) = _Button_5
        Me.Label(4) = _Button_4
        Me.Label(3) = _Button_3
        Me.Label(2) = _Button_2
        Me.Label(1) = _Button_1
        Me.Label(0) = _Button_0
    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents kq As System.Windows.Forms.Label
#End Region
End Class
