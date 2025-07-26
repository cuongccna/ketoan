<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmXulykiemtra
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeTxt()
		InitializeLabel()
		InitializeCommand()
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
	Public WithEvents CboNam As ComboBoxEx.ComboBoxExt
	Private WithEvents _Txt_10 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_11 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_0 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_6 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_2 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_9 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_8 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_7 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_5 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_4 As System.Windows.Forms.TextBox
	Private WithEvents _Txt_3 As System.Windows.Forms.TextBox
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Label_10 As System.Windows.Forms.Label
    Private WithEvents _Label_9 As System.Windows.Forms.Label
    Private WithEvents _Label_3 As System.Windows.Forms.Label
    Private WithEvents _Label_8 As System.Windows.Forms.Label
    Private WithEvents _Label_5 As System.Windows.Forms.Label
    Private WithEvents _Label_4 As System.Windows.Forms.Label
    Private WithEvents _Label_7 As System.Windows.Forms.Label
    Private WithEvents _Label_6 As System.Windows.Forms.Label
    Private WithEvents _Label_32 As System.Windows.Forms.Label
    Private WithEvents _Label_2 As System.Windows.Forms.Label
    Private WithEvents _Label_1 As System.Windows.Forms.Label
    Private WithEvents _Label_0 As System.Windows.Forms.Label
    Public Command(3) As System.Windows.Forms.Button
    Public Label(32) As System.Windows.Forms.Label
    Public Txt(11) As System.Windows.Forms.TextBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.CboNam = New ComboBoxEx.ComboBoxExt()
        Me._Txt_10 = New System.Windows.Forms.TextBox()
        Me._Txt_11 = New System.Windows.Forms.TextBox()
        Me._Txt_0 = New System.Windows.Forms.TextBox()
        Me._Txt_6 = New System.Windows.Forms.TextBox()
        Me._Txt_2 = New System.Windows.Forms.TextBox()
        Me._Txt_9 = New System.Windows.Forms.TextBox()
        Me._Txt_8 = New System.Windows.Forms.TextBox()
        Me._Txt_7 = New System.Windows.Forms.TextBox()
        Me._Txt_5 = New System.Windows.Forms.TextBox()
        Me._Txt_4 = New System.Windows.Forms.TextBox()
        Me._Txt_3 = New System.Windows.Forms.TextBox()
        Me._Command_3 = New System.Windows.Forms.Button()
        Me._Command_2 = New System.Windows.Forms.Button()
        Me._Command_1 = New System.Windows.Forms.Button()
        Me._Command_0 = New System.Windows.Forms.Button()
        Me._Label_10 = New System.Windows.Forms.Label()
        Me._Label_9 = New System.Windows.Forms.Label()
        Me._Label_3 = New System.Windows.Forms.Label()
        Me._Label_8 = New System.Windows.Forms.Label()
        Me._Label_5 = New System.Windows.Forms.Label()
        Me._Label_4 = New System.Windows.Forms.Label()
        Me._Label_7 = New System.Windows.Forms.Label()
        Me._Label_6 = New System.Windows.Forms.Label()
        Me._Label_32 = New System.Windows.Forms.Label()
        Me._Label_2 = New System.Windows.Forms.Label()
        Me._Label_1 = New System.Windows.Forms.Label()
        Me._Label_0 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CboNam
        '
        Me.CboNam.BackColor = System.Drawing.SystemColors.Window
        Me.CboNam.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboNam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboNam.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboNam.Location = New System.Drawing.Point(338, 30)
        Me.CboNam.Name = "CboNam"
        Me.CboNam.Size = New System.Drawing.Size(73, 21)
        Me.CboNam.TabIndex = 23
        '
        '_Txt_10
        '
        Me._Txt_10.AcceptsReturn = True
        Me._Txt_10.BackColor = System.Drawing.SystemColors.Window
        Me._Txt_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_10.Location = New System.Drawing.Point(40, 512)
        Me._Txt_10.MaxLength = 255
        Me._Txt_10.Name = "_Txt_10"
        Me._Txt_10.Size = New System.Drawing.Size(225, 22)
        Me._Txt_10.TabIndex = 9
        Me._Txt_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_Txt_11
        '
        Me._Txt_11.AcceptsReturn = True
        Me._Txt_11.BackColor = System.Drawing.SystemColors.Window
        Me._Txt_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_11.Location = New System.Drawing.Point(336, 512)
        Me._Txt_11.MaxLength = 255
        Me._Txt_11.Name = "_Txt_11"
        Me._Txt_11.Size = New System.Drawing.Size(225, 22)
        Me._Txt_11.TabIndex = 10
        Me._Txt_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_Txt_0
        '
        Me._Txt_0.AcceptsReturn = True
        Me._Txt_0.BackColor = System.Drawing.SystemColors.Window
        Me._Txt_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_0.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_0.Location = New System.Drawing.Point(256, 32)
        Me._Txt_0.MaxLength = 255
        Me._Txt_0.Name = "_Txt_0"
        Me._Txt_0.Size = New System.Drawing.Size(41, 22)
        Me._Txt_0.TabIndex = 0
        Me._Txt_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_Txt_6
        '
        Me._Txt_6.AcceptsReturn = True
        Me._Txt_6.BackColor = System.Drawing.SystemColors.Window
        Me._Txt_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_6.Location = New System.Drawing.Point(96, 280)
        Me._Txt_6.MaxLength = 255
        Me._Txt_6.Name = "_Txt_6"
        Me._Txt_6.Size = New System.Drawing.Size(225, 22)
        Me._Txt_6.TabIndex = 5
        Me._Txt_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_Txt_2
        '
        Me._Txt_2.AcceptsReturn = True
        Me._Txt_2.BackColor = System.Drawing.SystemColors.Window
        Me._Txt_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_2.Location = New System.Drawing.Point(96, 64)
        Me._Txt_2.MaxLength = 255
        Me._Txt_2.Name = "_Txt_2"
        Me._Txt_2.Size = New System.Drawing.Size(225, 22)
        Me._Txt_2.TabIndex = 1
        Me._Txt_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_Txt_9
        '
        Me._Txt_9.AcceptsReturn = True
        Me._Txt_9.BackColor = System.Drawing.SystemColors.Window
        Me._Txt_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_9.Location = New System.Drawing.Point(456, 320)
        Me._Txt_9.MaxLength = 254
        Me._Txt_9.Multiline = True
        Me._Txt_9.Name = "_Txt_9"
        Me._Txt_9.Size = New System.Drawing.Size(137, 161)
        Me._Txt_9.TabIndex = 8
        Me._Txt_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_Txt_8
        '
        Me._Txt_8.AcceptsReturn = True
        Me._Txt_8.BackColor = System.Drawing.SystemColors.Window
        Me._Txt_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_8.Location = New System.Drawing.Point(232, 320)
        Me._Txt_8.MaxLength = 254
        Me._Txt_8.Multiline = True
        Me._Txt_8.Name = "_Txt_8"
        Me._Txt_8.Size = New System.Drawing.Size(225, 161)
        Me._Txt_8.TabIndex = 7
        '
        '_Txt_7
        '
        Me._Txt_7.AcceptsReturn = True
        Me._Txt_7.BackColor = System.Drawing.SystemColors.Window
        Me._Txt_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_7.Location = New System.Drawing.Point(8, 320)
        Me._Txt_7.MaxLength = 254
        Me._Txt_7.Multiline = True
        Me._Txt_7.Name = "_Txt_7"
        Me._Txt_7.Size = New System.Drawing.Size(225, 161)
        Me._Txt_7.TabIndex = 6
        '
        '_Txt_5
        '
        Me._Txt_5.AcceptsReturn = True
        Me._Txt_5.BackColor = System.Drawing.SystemColors.Window
        Me._Txt_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_5.Location = New System.Drawing.Point(456, 104)
        Me._Txt_5.MaxLength = 254
        Me._Txt_5.Multiline = True
        Me._Txt_5.Name = "_Txt_5"
        Me._Txt_5.Size = New System.Drawing.Size(137, 161)
        Me._Txt_5.TabIndex = 4
        Me._Txt_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_Txt_4
        '
        Me._Txt_4.AcceptsReturn = True
        Me._Txt_4.BackColor = System.Drawing.SystemColors.Window
        Me._Txt_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_4.Location = New System.Drawing.Point(232, 104)
        Me._Txt_4.MaxLength = 254
        Me._Txt_4.Multiline = True
        Me._Txt_4.Name = "_Txt_4"
        Me._Txt_4.Size = New System.Drawing.Size(225, 161)
        Me._Txt_4.TabIndex = 3
        '
        '_Txt_3
        '
        Me._Txt_3.AcceptsReturn = True
        Me._Txt_3.BackColor = System.Drawing.SystemColors.Window
        Me._Txt_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Txt_3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Txt_3.Location = New System.Drawing.Point(8, 104)
        Me._Txt_3.MaxLength = 254
        Me._Txt_3.Multiline = True
        Me._Txt_3.Name = "_Txt_3"
        Me._Txt_3.Size = New System.Drawing.Size(225, 161)
        Me._Txt_3.TabIndex = 2
        '
        '_Command_3
        '
        Me._Command_3.Image = Nothing 'nothing 'Global.NVC.My.Resources.Resources._16x16_Home
        Me._Command_3.Location = New System.Drawing.Point(520, 544)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 24
        Me._Command_3.Text = "Trở &về"
        '
        '_Command_2
        '
        Me._Command_2.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Print
        Me._Command_2.Location = New System.Drawing.Point(440, 544)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 25
        Me._Command_2.Text = "&In"
        '
        '_Command_1
        '
        Me._Command_1.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Preview
        Me._Command_1.Location = New System.Drawing.Point(360, 544)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 26
        Me._Command_1.Text = "&Xem"
        '
        '_Command_0
        '
        Me._Command_0.Image = Nothing 'Global.NVC.My.Resources.Resources._16x16_Save
        Me._Command_0.Location = New System.Drawing.Point(280, 544)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 27
        Me._Command_0.Text = "&Ghi"
        '
        '_Label_10
        '
        Me._Label_10.BackColor = System.Drawing.Color.Transparent
        Me._Label_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_10.Location = New System.Drawing.Point(40, 496)
        Me._Label_10.Name = "_Label_10"
        Me._Label_10.Size = New System.Drawing.Size(225, 17)
        Me._Label_10.TabIndex = 22
        Me._Label_10.Text = "Người giao"
        Me._Label_10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_9
        '
        Me._Label_9.BackColor = System.Drawing.Color.Transparent
        Me._Label_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_9.Location = New System.Drawing.Point(336, 496)
        Me._Label_9.Name = "_Label_9"
        Me._Label_9.Size = New System.Drawing.Size(225, 17)
        Me._Label_9.TabIndex = 21
        Me._Label_9.Text = "Người nhận"
        Me._Label_9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_3
        '
        Me._Label_3.BackColor = System.Drawing.Color.Transparent
        Me._Label_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_3.Location = New System.Drawing.Point(216, 32)
        Me._Label_3.Name = "_Label_3"
        Me._Label_3.Size = New System.Drawing.Size(120, 17)
        Me._Label_3.TabIndex = 20
        Me._Label_3.Text = "Tháng                   năm"
        '
        '_Label_8
        '
        Me._Label_8.BackColor = System.Drawing.Color.Teal
        Me._Label_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_8.ForeColor = System.Drawing.Color.White
        Me._Label_8.Location = New System.Drawing.Point(456, 304)
        Me._Label_8.Name = "_Label_8"
        Me._Label_8.Size = New System.Drawing.Size(137, 17)
        Me._Label_8.TabIndex = 19
        Me._Label_8.Tag = "Code"
        Me._Label_8.Text = "Thời gian hoàn thành"
        Me._Label_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_5
        '
        Me._Label_5.BackColor = System.Drawing.Color.Teal
        Me._Label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_5.ForeColor = System.Drawing.Color.White
        Me._Label_5.Location = New System.Drawing.Point(232, 304)
        Me._Label_5.Name = "_Label_5"
        Me._Label_5.Size = New System.Drawing.Size(225, 17)
        Me._Label_5.TabIndex = 18
        Me._Label_5.Tag = "Code"
        Me._Label_5.Text = "Lý do"
        Me._Label_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_4
        '
        Me._Label_4.BackColor = System.Drawing.Color.Teal
        Me._Label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_4.ForeColor = System.Drawing.Color.White
        Me._Label_4.Location = New System.Drawing.Point(8, 304)
        Me._Label_4.Name = "_Label_4"
        Me._Label_4.Size = New System.Drawing.Size(225, 17)
        Me._Label_4.TabIndex = 17
        Me._Label_4.Tag = "Code"
        Me._Label_4.Text = "Nội dung xử lý làm lại (bổ sung)"
        Me._Label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_7
        '
        Me._Label_7.BackColor = System.Drawing.Color.Teal
        Me._Label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_7.ForeColor = System.Drawing.Color.White
        Me._Label_7.Location = New System.Drawing.Point(456, 88)
        Me._Label_7.Name = "_Label_7"
        Me._Label_7.Size = New System.Drawing.Size(137, 17)
        Me._Label_7.TabIndex = 16
        Me._Label_7.Tag = "Code"
        Me._Label_7.Text = "Thời gian hoàn thành"
        Me._Label_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_6
        '
        Me._Label_6.BackColor = System.Drawing.Color.Teal
        Me._Label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_6.ForeColor = System.Drawing.Color.White
        Me._Label_6.Location = New System.Drawing.Point(232, 88)
        Me._Label_6.Name = "_Label_6"
        Me._Label_6.Size = New System.Drawing.Size(225, 17)
        Me._Label_6.TabIndex = 15
        Me._Label_6.Tag = "Code"
        Me._Label_6.Text = "Lý do"
        Me._Label_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_32
        '
        Me._Label_32.BackColor = System.Drawing.Color.Teal
        Me._Label_32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Label_32.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_32.ForeColor = System.Drawing.Color.White
        Me._Label_32.Location = New System.Drawing.Point(8, 88)
        Me._Label_32.Name = "_Label_32"
        Me._Label_32.Size = New System.Drawing.Size(225, 17)
        Me._Label_32.TabIndex = 14
        Me._Label_32.Tag = "Code"
        Me._Label_32.Text = "Nội dung chưa hoàn thành"
        Me._Label_32.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_2
        '
        Me._Label_2.BackColor = System.Drawing.Color.Teal
        Me._Label_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me._Label_2.Location = New System.Drawing.Point(144, 8)
        Me._Label_2.Name = "_Label_2"
        Me._Label_2.Size = New System.Drawing.Size(313, 17)
        Me._Label_2.TabIndex = 13
        Me._Label_2.Text = "Biên bản bàn giao công việc"
        Me._Label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label_1
        '
        Me._Label_1.BackColor = System.Drawing.Color.Transparent
        Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_1.Location = New System.Drawing.Point(8, 280)
        Me._Label_1.Name = "_Label_1"
        Me._Label_1.Size = New System.Drawing.Size(81, 17)
        Me._Label_1.TabIndex = 12
        Me._Label_1.Text = "Người kiểm tra :"
        '
        '_Label_0
        '
        Me._Label_0.BackColor = System.Drawing.Color.Transparent
        Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label_0.Location = New System.Drawing.Point(8, 64)
        Me._Label_0.Name = "_Label_0"
        Me._Label_0.Size = New System.Drawing.Size(65, 17)
        Me._Label_0.TabIndex = 11
        Me._Label_0.Text = "Người xử lý :"
        '
        'FrmXulykiemtra
        '
        'Me.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.Appearance.Options.UseFont = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(601, 576)
        Me.Controls.Add(Me.CboNam)
        Me.Controls.Add(Me._Txt_10)
        Me.Controls.Add(Me._Txt_11)
        Me.Controls.Add(Me._Txt_0)
        Me.Controls.Add(Me._Txt_6)
        Me.Controls.Add(Me._Txt_2)
        Me.Controls.Add(Me._Txt_9)
        Me.Controls.Add(Me._Txt_8)
        Me.Controls.Add(Me._Txt_7)
        Me.Controls.Add(Me._Txt_5)
        Me.Controls.Add(Me._Txt_4)
        Me.Controls.Add(Me._Txt_3)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Label_10)
        Me.Controls.Add(Me._Label_9)
        Me.Controls.Add(Me._Label_3)
        Me.Controls.Add(Me._Label_8)
        Me.Controls.Add(Me._Label_5)
        Me.Controls.Add(Me._Label_4)
        Me.Controls.Add(Me._Label_7)
        Me.Controls.Add(Me._Label_6)
        Me.Controls.Add(Me._Label_32)
        Me.Controls.Add(Me._Label_2)
        Me.Controls.Add(Me._Label_1)
        Me.Controls.Add(Me._Label_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = Nothing 'Global.NVC.My.Resources.Resources.CAppIcon
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmXulykiemtra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Biên bản bàn giao (xử lý - kiểm tra)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Sub InitializeTxt()
		Me.Txt(10) = _Txt_10
		Me.Txt(11) = _Txt_11
		Me.Txt(0) = _Txt_0
		Me.Txt(6) = _Txt_6
		Me.Txt(2) = _Txt_2
		Me.Txt(9) = _Txt_9
		Me.Txt(8) = _Txt_8
		Me.Txt(7) = _Txt_7
		Me.Txt(5) = _Txt_5
		Me.Txt(4) = _Txt_4
		Me.Txt(3) = _Txt_3
	End Sub
	Sub InitializeLabel()
		Me.Label(10) = _Label_10
		Me.Label(9) = _Label_9
		Me.Label(3) = _Label_3
		Me.Label(8) = _Label_8
		Me.Label(5) = _Label_5
		Me.Label(4) = _Label_4
		Me.Label(7) = _Label_7
		Me.Label(6) = _Label_6
		Me.Label(32) = _Label_32
		Me.Label(2) = _Label_2
		Me.Label(1) = _Label_1
		Me.Label(0) = _Label_0
	End Sub
	Sub InitializeCommand()
		Me.Command(3) = _Command_3
		Me.Command(2) = _Command_2
		Me.Command(1) = _Command_1
		Me.Command(0) = _Command_0
	End Sub
#End Region 
End Class
