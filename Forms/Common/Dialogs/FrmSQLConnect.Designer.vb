<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSQLConnect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lab_MayChu = New System.Windows.Forms.Label
        Me.cmbMayChu = New System.Windows.Forms.ComboBox
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbKieuKetNoi = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPasswrod = New System.Windows.Forms.TextBox
        Me.btnKetNoi = New System.Windows.Forms.Button
        Me.btnHuy = New System.Windows.Forms.Button
        Me.btnGiupDo = New System.Windows.Forms.Button
        Me.labCosodulieu = New System.Windows.Forms.Label
        Me.cmbDatabaseList = New System.Windows.Forms.ComboBox
        Me.lab_data = New System.Windows.Forms.Label
        Me.labIP = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnTaoDuLieu = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lab_MayChu
        '
        Me.lab_MayChu.AutoSize = True
        Me.lab_MayChu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lab_MayChu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_MayChu.ForeColor = System.Drawing.Color.Blue
        Me.lab_MayChu.Location = New System.Drawing.Point(12, 16)
        Me.lab_MayChu.Name = "lab_MayChu"
        Me.lab_MayChu.Size = New System.Drawing.Size(112, 13)
        Me.lab_MayChu.TabIndex = 0
        Me.lab_MayChu.Text = "Tên máy chủ hoặc IP:"
        '
        'cmbMayChu
        '
        Me.cmbMayChu.FormattingEnabled = True
        Me.cmbMayChu.Location = New System.Drawing.Point(130, 13)
        Me.cmbMayChu.Name = "cmbMayChu"
        Me.cmbMayChu.Size = New System.Drawing.Size(222, 21)
        Me.cmbMayChu.TabIndex = 1
        Me.cmbMayChu.Text = "."
        '
        'txtUserName
        '
        Me.txtUserName.Enabled = False
        Me.txtUserName.Location = New System.Drawing.Point(155, 67)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(197, 20)
        Me.txtUserName.TabIndex = 5
        Me.txtUserName.Text = "sa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kiểu kết nối:"
        '
        'cmbKieuKetNoi
        '
        Me.cmbKieuKetNoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKieuKetNoi.FormattingEnabled = True
        Me.cmbKieuKetNoi.Items.AddRange(New Object() {"Chứng thực hệ thống", "Chứng thực SQL Server"})
        Me.cmbKieuKetNoi.Location = New System.Drawing.Point(130, 40)
        Me.cmbKieuKetNoi.Name = "cmbKieuKetNoi"
        Me.cmbKieuKetNoi.Size = New System.Drawing.Size(222, 21)
        Me.cmbKieuKetNoi.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(28, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tên đăng nhập:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(28, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mật khẩu:"
        '
        'txtPasswrod
        '
        Me.txtPasswrod.Enabled = False
        Me.txtPasswrod.Location = New System.Drawing.Point(155, 92)
        Me.txtPasswrod.Name = "txtPasswrod"
        Me.txtPasswrod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswrod.Size = New System.Drawing.Size(197, 20)
        Me.txtPasswrod.TabIndex = 7
        Me.txtPasswrod.Text = "123"
        '
        'btnKetNoi
        '
        Me.btnKetNoi.Image = Global.UNET.My.Resources.Resources.righticon
        Me.btnKetNoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKetNoi.Location = New System.Drawing.Point(152, 234)
        Me.btnKetNoi.Name = "btnKetNoi"
        Me.btnKetNoi.Size = New System.Drawing.Size(70, 23)
        Me.btnKetNoi.TabIndex = 10
        Me.btnKetNoi.Text = "Kết Nối"
        Me.btnKetNoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKetNoi.UseVisualStyleBackColor = True
        '
        'btnHuy
        '
        Me.btnHuy.Image = Global.UNET.My.Resources.Resources.delete16
        Me.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHuy.Location = New System.Drawing.Point(228, 234)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(70, 23)
        Me.btnHuy.TabIndex = 11
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'btnGiupDo
        '
        Me.btnGiupDo.Image = Global.UNET.My.Resources.Resources.list16
        Me.btnGiupDo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGiupDo.Location = New System.Drawing.Point(304, 234)
        Me.btnGiupDo.Name = "btnGiupDo"
        Me.btnGiupDo.Size = New System.Drawing.Size(70, 23)
        Me.btnGiupDo.TabIndex = 12
        Me.btnGiupDo.Text = "Trợ Giúp"
        Me.btnGiupDo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGiupDo.UseVisualStyleBackColor = True
        '
        'labCosodulieu
        '
        Me.labCosodulieu.AutoSize = True
        Me.labCosodulieu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labCosodulieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labCosodulieu.ForeColor = System.Drawing.Color.Blue
        Me.labCosodulieu.Location = New System.Drawing.Point(12, 22)
        Me.labCosodulieu.Name = "labCosodulieu"
        Me.labCosodulieu.Size = New System.Drawing.Size(71, 13)
        Me.labCosodulieu.TabIndex = 8
        Me.labCosodulieu.Text = "Cơ sở dữ liệu:"
        '
        'cmbDatabaseList
        '
        Me.cmbDatabaseList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDatabaseList.FormattingEnabled = True
        Me.cmbDatabaseList.Location = New System.Drawing.Point(130, 19)
        Me.cmbDatabaseList.Name = "cmbDatabaseList"
        Me.cmbDatabaseList.Size = New System.Drawing.Size(222, 21)
        Me.cmbDatabaseList.TabIndex = 9
        '
        'lab_data
        '
        Me.lab_data.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lab_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lab_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_data.ForeColor = System.Drawing.Color.Blue
        Me.lab_data.Image = Global.UNET.My.Resources.Resources.search16
        Me.lab_data.Location = New System.Drawing.Point(358, 19)
        Me.lab_data.Name = "lab_data"
        Me.lab_data.Size = New System.Drawing.Size(18, 21)
        Me.lab_data.TabIndex = 8
        '
        'labIP
        '
        Me.labIP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labIP.ForeColor = System.Drawing.Color.Blue
        Me.labIP.Image = Global.UNET.My.Resources.Resources.righticon
        Me.labIP.Location = New System.Drawing.Point(358, 13)
        Me.labIP.Name = "labIP"
        Me.labIP.Size = New System.Drawing.Size(16, 21)
        Me.labIP.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lab_MayChu)
        Me.GroupBox1.Controls.Add(Me.cmbMayChu)
        Me.GroupBox1.Controls.Add(Me.txtPasswrod)
        Me.GroupBox1.Controls.Add(Me.labIP)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.cmbKieuKetNoi)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 123)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Máy chủ"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.UNET.My.Resources.Resources.database
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(385, 50)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(60, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(208, 24)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Kết nối cơ sở dữ liệu."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbDatabaseList)
        Me.GroupBox2.Controls.Add(Me.labCosodulieu)
        Me.GroupBox2.Controls.Add(Me.lab_data)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 173)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(385, 55)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dữ liệu"
        '
        'btnTaoDuLieu
        '
        Me.btnTaoDuLieu.Image = Global.UNET.My.Resources.Resources.add16
        Me.btnTaoDuLieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTaoDuLieu.Location = New System.Drawing.Point(11, 234)
        Me.btnTaoDuLieu.Name = "btnTaoDuLieu"
        Me.btnTaoDuLieu.Size = New System.Drawing.Size(120, 23)
        Me.btnTaoDuLieu.TabIndex = 10
        Me.btnTaoDuLieu.Text = "Tạo Mới Dữ Liệu"
        Me.btnTaoDuLieu.UseVisualStyleBackColor = True
        '
        'FrmSQLConnect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 263)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGiupDo)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.btnTaoDuLieu)
        Me.Controls.Add(Me.btnKetNoi)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSQLConnect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kết nối tới cơ sở dữ liệu ..."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lab_MayChu As System.Windows.Forms.Label
    Friend WithEvents cmbMayChu As System.Windows.Forms.ComboBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbKieuKetNoi As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPasswrod As System.Windows.Forms.TextBox
    Friend WithEvents btnKetNoi As System.Windows.Forms.Button
    Friend WithEvents btnHuy As System.Windows.Forms.Button
    Friend WithEvents btnGiupDo As System.Windows.Forms.Button
    Friend WithEvents labCosodulieu As System.Windows.Forms.Label
    Friend WithEvents cmbDatabaseList As System.Windows.Forms.ComboBox
    Friend WithEvents lab_data As System.Windows.Forms.Label
    Friend WithEvents labIP As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTaoDuLieu As System.Windows.Forms.Button
End Class
