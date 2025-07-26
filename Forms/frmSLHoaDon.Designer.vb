<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSLHoaDon
    Inherits Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        ' Init components
		InitializeComponent()
		InitializeText_Renamed()
		InitializeLabel1()
		InitializeCommand()
		InitializeCmdDanhSach()
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
    Private WithEvents _Command_0 As System.Windows.Forms.Button
    Private WithEvents _Command_2 As System.Windows.Forms.Button
    Public WithEvents ChkMat As System.Windows.Forms.CheckBox
    Private WithEvents _Text_7 As System.Windows.Forms.TextBox
    Private WithEvents _Command_3 As System.Windows.Forms.Button
    Private WithEvents _Command_1 As System.Windows.Forms.Button
    Private WithEvents _Text_6 As System.Windows.Forms.TextBox
    Private WithEvents _Text_4 As System.Windows.Forms.TextBox
    Public WithEvents Chk As System.Windows.Forms.CheckBox
    Private WithEvents _Text_5 As System.Windows.Forms.TextBox
    Public WithEvents cboLoai As ComboBoxEx.ComboBoxExt
    Public WithEvents ListHD As System.Windows.Forms.ListBox
    Private WithEvents _Text_3 As System.Windows.Forms.TextBox
    Private WithEvents _Text_2 As System.Windows.Forms.TextBox
    Private WithEvents _Text_1 As System.Windows.Forms.TextBox
    Private WithEvents _Text_0 As System.Windows.Forms.TextBox
    Private WithEvents _CmdDanhSach_0 As System.Windows.Forms.Button
    Private WithEvents _Label1_7 As System.Windows.Forms.Label
    Private WithEvents _Label1_5 As System.Windows.Forms.Label
    Private WithEvents _Label1_4 As System.Windows.Forms.Label
    Private WithEvents _Label1_3 As System.Windows.Forms.Label
    Private WithEvents _Label1_2 As System.Windows.Forms.Label
    Private WithEvents _Label1_1 As System.Windows.Forms.Label
    Private WithEvents _Label1_0 As System.Windows.Forms.Label
    Public CmdDanhSach(0) As System.Windows.Forms.Button
    Public Command(3) As System.Windows.Forms.Button
    Public Label1(7) As System.Windows.Forms.Label
    Public Text_Renamed(7) As System.Windows.Forms.TextBox
    'Private listBoxHelper1 As Artinsoft.VB6.Gui.ListBoxHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSLHoaDon))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._Command_0 = New System.Windows.Forms.Button
        Me._Command_2 = New System.Windows.Forms.Button
        Me.ChkMat = New System.Windows.Forms.CheckBox
        Me._Text_7 = New System.Windows.Forms.TextBox
        Me._Command_3 = New System.Windows.Forms.Button
        Me._Command_1 = New System.Windows.Forms.Button
        Me._Text_6 = New System.Windows.Forms.TextBox
        Me._Text_4 = New System.Windows.Forms.TextBox
        Me.Chk = New System.Windows.Forms.CheckBox
        Me._Text_5 = New System.Windows.Forms.TextBox
        Me.cboLoai = New ComboBoxEx.ComboBoxExt
        Me.ListHD = New System.Windows.Forms.ListBox
        Me._Text_3 = New System.Windows.Forms.TextBox
        Me._Text_2 = New System.Windows.Forms.TextBox
        Me._Text_1 = New System.Windows.Forms.TextBox
        Me._Text_0 = New System.Windows.Forms.TextBox
        Me._CmdDanhSach_0 = New System.Windows.Forms.Button
        Me._Label1_7 = New System.Windows.Forms.Label
        Me._Label1_5 = New System.Windows.Forms.Label
        Me._Label1_4 = New System.Windows.Forms.Label
        Me._Label1_3 = New System.Windows.Forms.Label
        Me._Label1_2 = New System.Windows.Forms.Label
        Me._Label1_1 = New System.Windows.Forms.Label
        Me._Label1_0 = New System.Windows.Forms.Label
        Me.LabelControl28 = New System.Windows.Forms.Label
        Me.rb_dien = New System.Windows.Forms.RadioButton
        Me.rb_dat = New System.Windows.Forms.RadioButton
        Me.rb_tu = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        '_Command_0
        '
        Me._Command_0.Image = Global.UNET.My.Resources.Resources.save16
        Me._Command_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_0.Location = New System.Drawing.Point(367, 148)
        Me._Command_0.Name = "_Command_0"
        Me._Command_0.Size = New System.Drawing.Size(73, 25)
        Me._Command_0.TabIndex = 17
        Me._Command_0.Tag = "Save"
        Me._Command_0.Text = "&Ghi"
        Me._Command_0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_2
        '
        Me._Command_2.Image = Global.UNET.My.Resources.Resources.add16
        Me._Command_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_2.Location = New System.Drawing.Point(287, 148)
        Me._Command_2.Name = "_Command_2"
        Me._Command_2.Size = New System.Drawing.Size(73, 25)
        Me._Command_2.TabIndex = 16
        Me._Command_2.Tag = "Add"
        Me._Command_2.Text = "&Thêm"
        Me._Command_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChkMat
        '
        Me.ChkMat.BackColor = System.Drawing.Color.Transparent
        Me.ChkMat.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkMat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkMat.Location = New System.Drawing.Point(7, 153)
        Me.ChkMat.Name = "ChkMat"
        Me.ChkMat.Size = New System.Drawing.Size(118, 17)
        Me.ChkMat.TabIndex = 10
        Me.ChkMat.Tag = "Invoice number loss"
        Me.ChkMat.Text = "Số hoá đơn mất"
        Me.ChkMat.UseVisualStyleBackColor = False
        Me.ChkMat.Visible = False
        '
        '_Text_7
        '
        Me._Text_7.Location = New System.Drawing.Point(127, 177)
        Me._Text_7.MaxLength = 0
        Me._Text_7.Name = "_Text_7"
        Me._Text_7.Size = New System.Drawing.Size(158, 20)
        Me._Text_7.TabIndex = 12
        Me._Text_7.Visible = False
        '
        '_Command_3
        '
        Me._Command_3.Image = Global.UNET.My.Resources.Resources.return16
        Me._Command_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_3.Location = New System.Drawing.Point(527, 148)
        Me._Command_3.Name = "_Command_3"
        Me._Command_3.Size = New System.Drawing.Size(73, 25)
        Me._Command_3.TabIndex = 19
        Me._Command_3.Tag = "Return"
        Me._Command_3.Text = "Trở &về"
        Me._Command_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Command_1
        '
        Me._Command_1.Image = Global.UNET.My.Resources.Resources.delete16
        Me._Command_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Command_1.Location = New System.Drawing.Point(447, 148)
        Me._Command_1.Name = "_Command_1"
        Me._Command_1.Size = New System.Drawing.Size(73, 25)
        Me._Command_1.TabIndex = 18
        Me._Command_1.Tag = "Delete"
        Me._Command_1.Text = "&Xoá"
        Me._Command_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_Text_6
        '
        Me._Text_6.Location = New System.Drawing.Point(127, 225)
        Me._Text_6.MaxLength = 0
        Me._Text_6.Name = "_Text_6"
        Me._Text_6.Size = New System.Drawing.Size(158, 20)
        Me._Text_6.TabIndex = 15
        Me._Text_6.Visible = False
        '
        '_Text_4
        '
        Me._Text_4.Location = New System.Drawing.Point(127, 201)
        Me._Text_4.MaxLength = 0
        Me._Text_4.Name = "_Text_4"
        Me._Text_4.Size = New System.Drawing.Size(158, 20)
        Me._Text_4.TabIndex = 14
        Me._Text_4.Visible = False
        '
        'Chk
        '
        Me.Chk.BackColor = System.Drawing.Color.Transparent
        Me.Chk.Cursor = System.Windows.Forms.Cursors.Default
        Me.Chk.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk.Location = New System.Drawing.Point(7, 201)
        Me.Chk.Name = "Chk"
        Me.Chk.Size = New System.Drawing.Size(118, 17)
        Me.Chk.TabIndex = 13
        Me.Chk.Tag = "Canceled Invoice number "
        Me.Chk.Text = "Số hoá đơn huỷ"
        Me.Chk.UseVisualStyleBackColor = False
        Me.Chk.Visible = False
        '
        '_Text_5
        '
        Me._Text_5.Location = New System.Drawing.Point(127, 153)
        Me._Text_5.MaxLength = 0
        Me._Text_5.Name = "_Text_5"
        Me._Text_5.Size = New System.Drawing.Size(158, 20)
        Me._Text_5.TabIndex = 11
        Me._Text_5.Visible = False
        '
        'cboLoai
        '
        Me.cboLoai.BackColor = System.Drawing.SystemColors.Window
        Me.cboLoai.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLoai.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLoai.Location = New System.Drawing.Point(128, 4)
        Me.cboLoai.Name = "cboLoai"
        Me.cboLoai.Size = New System.Drawing.Size(441, 21)
        Me.cboLoai.TabIndex = 1
        '
        'ListHD
        '
        Me.ListHD.BackColor = System.Drawing.SystemColors.Window
        Me.ListHD.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListHD.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListHD.ItemHeight = 14
        Me.ListHD.Location = New System.Drawing.Point(291, 32)
        Me.ListHD.Name = "ListHD"
        Me.ListHD.Size = New System.Drawing.Size(310, 102)
        Me.ListHD.TabIndex = 0
        Me.ListHD.TabStop = False
        '
        '_Text_3
        '
        Me._Text_3.Location = New System.Drawing.Point(127, 129)
        Me._Text_3.MaxLength = 0
        Me._Text_3.Name = "_Text_3"
        Me._Text_3.Size = New System.Drawing.Size(158, 20)
        Me._Text_3.TabIndex = 9
        '
        '_Text_2
        '
        Me._Text_2.Location = New System.Drawing.Point(127, 105)
        Me._Text_2.MaxLength = 0
        Me._Text_2.Name = "_Text_2"
        Me._Text_2.Size = New System.Drawing.Size(158, 20)
        Me._Text_2.TabIndex = 8
        '
        '_Text_1
        '
        Me._Text_1.Location = New System.Drawing.Point(127, 81)
        Me._Text_1.MaxLength = 0
        Me._Text_1.Name = "_Text_1"
        Me._Text_1.Size = New System.Drawing.Size(158, 20)
        Me._Text_1.TabIndex = 7
        '
        '_Text_0
        '
        Me._Text_0.Location = New System.Drawing.Point(227, 32)
        Me._Text_0.MaxLength = 0
        Me._Text_0.Name = "_Text_0"
        Me._Text_0.ReadOnly = True
        Me._Text_0.Size = New System.Drawing.Size(58, 20)
        Me._Text_0.TabIndex = 3
        '
        '_CmdDanhSach_0
        '
        Me._CmdDanhSach_0.Image = Global.UNET.My.Resources.Resources.search3_16
        Me._CmdDanhSach_0.Location = New System.Drawing.Point(576, 4)
        Me._CmdDanhSach_0.Name = "_CmdDanhSach_0"
        Me._CmdDanhSach_0.Size = New System.Drawing.Size(24, 23)
        Me._CmdDanhSach_0.TabIndex = 2
        '
        '_Label1_7
        '
        Me._Label1_7.BackColor = System.Drawing.Color.Transparent
        Me._Label1_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_7.Location = New System.Drawing.Point(7, 225)
        Me._Label1_7.Name = "_Label1_7"
        Me._Label1_7.Size = New System.Drawing.Size(113, 17)
        Me._Label1_7.TabIndex = 23
        Me._Label1_7.Tag = "Canceled month"
        Me._Label1_7.Text = "Tháng huỷ"
        Me._Label1_7.Visible = False
        '
        '_Label1_5
        '
        Me._Label1_5.BackColor = System.Drawing.Color.Transparent
        Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_5.Location = New System.Drawing.Point(7, 177)
        Me._Label1_5.Name = "_Label1_5"
        Me._Label1_5.Size = New System.Drawing.Size(113, 17)
        Me._Label1_5.TabIndex = 22
        Me._Label1_5.Tag = "Loss month"
        Me._Label1_5.Text = "Tháng mất"
        Me._Label1_5.Visible = False
        '
        '_Label1_4
        '
        Me._Label1_4.BackColor = System.Drawing.Color.Transparent
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_4.Location = New System.Drawing.Point(8, 8)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.Size = New System.Drawing.Size(113, 17)
        Me._Label1_4.TabIndex = 21
        Me._Label1_4.Tag = "Form"
        Me._Label1_4.Text = "Mẫu số"
        '
        '_Label1_3
        '
        Me._Label1_3.BackColor = System.Drawing.Color.Transparent
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_3.Location = New System.Drawing.Point(7, 129)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.Size = New System.Drawing.Size(113, 17)
        Me._Label1_3.TabIndex = 20
        Me._Label1_3.Tag = "Month"
        Me._Label1_3.Text = "Tháng nhập"
        '
        '_Label1_2
        '
        Me._Label1_2.BackColor = System.Drawing.Color.Transparent
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(7, 105)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.Size = New System.Drawing.Size(113, 17)
        Me._Label1_2.TabIndex = 19
        Me._Label1_2.Tag = "Quantity"
        Me._Label1_2.Text = "Số lượng"
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.Color.Transparent
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(7, 81)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.Size = New System.Drawing.Size(113, 17)
        Me._Label1_1.TabIndex = 18
        Me._Label1_1.Tag = "From"
        Me._Label1_1.Text = "Số hoá đơn đầu"
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.Color.Transparent
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(8, 32)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.Size = New System.Drawing.Size(113, 17)
        Me._Label1_0.TabIndex = 17
        Me._Label1_0.Tag = "Notation"
        Me._Label1_0.Text = "Ký hiệu"
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(11, 60)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl28.TabIndex = 107
        Me.LabelControl28.Tag = "Type "
        Me.LabelControl28.Text = "Kiểu hóa đơn"
        '
        'rb_dien
        '
        Me.rb_dien.AutoSize = True
        Me.rb_dien.Location = New System.Drawing.Point(230, 59)
        Me.rb_dien.Name = "rb_dien"
        Me.rb_dien.Size = New System.Drawing.Size(59, 17)
        Me.rb_dien.TabIndex = 6
        Me.rb_dien.Text = "Điện tử"
        Me.rb_dien.UseVisualStyleBackColor = True
        '
        'rb_dat
        '
        Me.rb_dat.AutoSize = True
        Me.rb_dat.Location = New System.Drawing.Point(178, 58)
        Me.rb_dat.Name = "rb_dat"
        Me.rb_dat.Size = New System.Drawing.Size(53, 17)
        Me.rb_dat.TabIndex = 5
        Me.rb_dat.Text = "Đặt in"
        Me.rb_dat.UseVisualStyleBackColor = True
        '
        'rb_tu
        '
        Me.rb_tu.AutoSize = True
        Me.rb_tu.Checked = True
        Me.rb_tu.Location = New System.Drawing.Point(128, 58)
        Me.rb_tu.Name = "rb_tu"
        Me.rb_tu.Size = New System.Drawing.Size(49, 17)
        Me.rb_tu.TabIndex = 4
        Me.rb_tu.TabStop = True
        Me.rb_tu.Text = "Tự in"
        Me.rb_tu.UseVisualStyleBackColor = True
        '
        'frmSLHoaDon
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(609, 249)
        Me.Controls.Add(Me.LabelControl28)
        Me.Controls.Add(Me.rb_dien)
        Me.Controls.Add(Me.rb_dat)
        Me.Controls.Add(Me.rb_tu)
        Me.Controls.Add(Me._Command_0)
        Me.Controls.Add(Me._Command_2)
        Me.Controls.Add(Me.ChkMat)
        Me.Controls.Add(Me._Text_7)
        Me.Controls.Add(Me._Command_3)
        Me.Controls.Add(Me._Command_1)
        Me.Controls.Add(Me._Text_6)
        Me.Controls.Add(Me._Text_4)
        Me.Controls.Add(Me.Chk)
        Me.Controls.Add(Me._Text_5)
        Me.Controls.Add(Me.cboLoai)
        Me.Controls.Add(Me.ListHD)
        Me.Controls.Add(Me._Text_3)
        Me.Controls.Add(Me._Text_2)
        Me.Controls.Add(Me._Text_1)
        Me.Controls.Add(Me._Text_0)
        Me.Controls.Add(Me._CmdDanhSach_0)
        Me.Controls.Add(Me._Label1_7)
        Me.Controls.Add(Me._Label1_5)
        Me.Controls.Add(Me._Label1_4)
        Me.Controls.Add(Me._Label1_3)
        Me.Controls.Add(Me._Label1_2)
        Me.Controls.Add(Me._Label1_1)
        Me.Controls.Add(Me._Label1_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSLHoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Registration invoice"
        Me.Text = "Đăng ký hoá Đơn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Sub InitializeText_Renamed()
        Me.Text_Renamed(7) = _Text_7
        Me.Text_Renamed(6) = _Text_6
        Me.Text_Renamed(4) = _Text_4
        Me.Text_Renamed(5) = _Text_5
        Me.Text_Renamed(3) = _Text_3
        Me.Text_Renamed(2) = _Text_2
        Me.Text_Renamed(1) = _Text_1
        Me.Text_Renamed(0) = _Text_0
    End Sub
    Sub InitializeLabel1()
        Me.Label1(7) = _Label1_7
        Me.Label1(5) = _Label1_5
        Me.Label1(4) = _Label1_4
        Me.Label1(3) = _Label1_3
        Me.Label1(2) = _Label1_2
        Me.Label1(1) = _Label1_1
        Me.Label1(0) = _Label1_0
    End Sub
    Sub InitializeCommand()
        Me.Command(0) = _Command_0
        Me.Command(2) = _Command_2
        Me.Command(3) = _Command_3
        Me.Command(1) = _Command_1
    End Sub
    Sub InitializeCmdDanhSach()
        Me.CmdDanhSach(0) = _CmdDanhSach_0
    End Sub
    'Friend WithEvents lue_loai_hd As DevExpress.XtraEditors.LookUpEdit
    'Friend WithEvents sp_nam As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl28 As System.Windows.Forms.Label
    Friend WithEvents rb_dien As System.Windows.Forms.RadioButton
    Friend WithEvents rb_dat As System.Windows.Forms.RadioButton
    Friend WithEvents rb_tu As System.Windows.Forms.RadioButton
#End Region
End Class
