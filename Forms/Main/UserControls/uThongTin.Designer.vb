<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uThongTin
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblLicenseType = New System.Windows.Forms.Label
        Me.labLicense = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblProductName = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblProductKey = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblProductID = New System.Windows.Forms.Label
        Me.LinkLabel_copy1 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel_copy = New System.Windows.Forms.LinkLabel
        Me.LinkLabel_thongTinGiayPhep = New System.Windows.Forms.LinkLabel
        Me.LinkLabel_DangKy = New System.Windows.Forms.LinkLabel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.UHuongDanSuDung1 = New UNET.uHuongDanSuDung
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(943, 142)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "THÔNG TIN / HỖ TRỢ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Image = Global.UNET.My.Resources.Resources.posiable
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(157, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "       Kỹ thuật"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Image = Global.UNET.My.Resources.Resources.email
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(157, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "       cuong.vhcc@gmail.com"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Image = Global.UNET.My.Resources.Resources.tel
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(157, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "       0987 939 605"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Image = Global.UNET.My.Resources.Resources.select16
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(157, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "       Văn Cường."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UNET.My.Resources.Resources.contact1
        Me.PictureBox1.Location = New System.Drawing.Point(51, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblLicenseType)
        Me.GroupBox2.Controls.Add(Me.labLicense)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblProductName)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.lblProductKey)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lblProductID)
        Me.GroupBox2.Controls.Add(Me.LinkLabel_copy1)
        Me.GroupBox2.Controls.Add(Me.LinkLabel_copy)
        Me.GroupBox2.Controls.Add(Me.LinkLabel_thongTinGiayPhep)
        Me.GroupBox2.Controls.Add(Me.LinkLabel_DangKy)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(943, 211)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BẢN QUYỀN / GIẤY PHÉP SỬ DỤNG"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.UNET.My.Resources.Resources.license
        Me.PictureBox3.Location = New System.Drawing.Point(51, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Image = Global.UNET.My.Resources.Resources.tinh_lai_gia_xuat_ngoai_te_16
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Location = New System.Drawing.Point(96, 135)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 15)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "       Loại giấy phép :"
        '
        'lblLicenseType
        '
        Me.lblLicenseType.AutoSize = True
        Me.lblLicenseType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLicenseType.ForeColor = System.Drawing.Color.Black
        Me.lblLicenseType.Location = New System.Drawing.Point(216, 135)
        Me.lblLicenseType.Name = "lblLicenseType"
        Me.lblLicenseType.Size = New System.Drawing.Size(16, 15)
        Me.lblLicenseType.TabIndex = 1
        Me.lblLicenseType.Text = "..."
        '
        'labLicense
        '
        Me.labLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labLicense.ForeColor = System.Drawing.Color.Green
        Me.labLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.labLicense.Location = New System.Drawing.Point(446, 19)
        Me.labLicense.Name = "labLicense"
        Me.labLicense.Size = New System.Drawing.Size(147, 27)
        Me.labLicense.TabIndex = 1
        Me.labLicense.Text = "LICENSED"
        Me.labLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Location = New System.Drawing.Point(96, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(344, 27)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "PHẦN MỀM KẾ TOÁN ACTAX VER 2.0"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label13.Location = New System.Drawing.Point(106, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(172, 15)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Bản quyền thuộc về AC PLUS ."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Image = Global.UNET.My.Resources.Resources.register_password_16
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(96, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "       Mã sản phẩm :"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.ForeColor = System.Drawing.Color.Black
        Me.lblProductName.Location = New System.Drawing.Point(216, 66)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(62, 15)
        Me.lblProductName.TabIndex = 1
        Me.lblProductName.Text = "ACTax 2.0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Image = Global.UNET.My.Resources.Resources.register_password_16
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label15.Location = New System.Drawing.Point(96, 109)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 15)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "       Mã kích hoạt :"
        '
        'lblProductKey
        '
        Me.lblProductKey.BackColor = System.Drawing.SystemColors.Info
        Me.lblProductKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductKey.ForeColor = System.Drawing.Color.Black
        Me.lblProductKey.Location = New System.Drawing.Point(216, 109)
        Me.lblProductKey.Name = "lblProductKey"
        Me.lblProductKey.Size = New System.Drawing.Size(285, 15)
        Me.lblProductKey.TabIndex = 1
        Me.lblProductKey.Text = "..."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Image = Global.UNET.My.Resources.Resources.nuocsanxuat_16
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.Location = New System.Drawing.Point(96, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 15)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "       Tên sản phẩm : "
        '
        'lblProductID
        '
        Me.lblProductID.BackColor = System.Drawing.SystemColors.Info
        Me.lblProductID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductID.ForeColor = System.Drawing.Color.Black
        Me.lblProductID.Location = New System.Drawing.Point(216, 86)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(285, 15)
        Me.lblProductID.TabIndex = 1
        Me.lblProductID.Text = "..."
        '
        'LinkLabel_copy1
        '
        Me.LinkLabel_copy1.AutoSize = True
        Me.LinkLabel_copy1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel_copy1.Location = New System.Drawing.Point(507, 111)
        Me.LinkLabel_copy1.Name = "LinkLabel_copy1"
        Me.LinkLabel_copy1.Size = New System.Drawing.Size(30, 13)
        Me.LinkLabel_copy1.TabIndex = 0
        Me.LinkLabel_copy1.TabStop = True
        Me.LinkLabel_copy1.Text = "copy"
        '
        'LinkLabel_copy
        '
        Me.LinkLabel_copy.AutoSize = True
        Me.LinkLabel_copy.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel_copy.Location = New System.Drawing.Point(507, 88)
        Me.LinkLabel_copy.Name = "LinkLabel_copy"
        Me.LinkLabel_copy.Size = New System.Drawing.Size(30, 13)
        Me.LinkLabel_copy.TabIndex = 0
        Me.LinkLabel_copy.TabStop = True
        Me.LinkLabel_copy.Text = "copy"
        '
        'LinkLabel_thongTinGiayPhep
        '
        Me.LinkLabel_thongTinGiayPhep.AutoSize = True
        Me.LinkLabel_thongTinGiayPhep.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel_thongTinGiayPhep.Location = New System.Drawing.Point(200, 165)
        Me.LinkLabel_thongTinGiayPhep.Name = "LinkLabel_thongTinGiayPhep"
        Me.LinkLabel_thongTinGiayPhep.Size = New System.Drawing.Size(116, 13)
        Me.LinkLabel_thongTinGiayPhep.TabIndex = 0
        Me.LinkLabel_thongTinGiayPhep.TabStop = True
        Me.LinkLabel_thongTinGiayPhep.Text = "Thông tin về giấy phép"
        '
        'LinkLabel_DangKy
        '
        Me.LinkLabel_DangKy.AutoSize = True
        Me.LinkLabel_DangKy.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel_DangKy.Location = New System.Drawing.Point(96, 165)
        Me.LinkLabel_DangKy.Name = "LinkLabel_DangKy"
        Me.LinkLabel_DangKy.Size = New System.Drawing.Size(88, 13)
        Me.LinkLabel_DangKy.TabIndex = 0
        Me.LinkLabel_DangKy.TabStop = True
        Me.LinkLabel_DangKy.Text = "Đăng ký sử dụng"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.UHuongDanSuDung1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(0, 353)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(943, 183)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "HƯỚNG DẪN SỬ DỤNG"
        '
        'UHuongDanSuDung1
        '
        Me.UHuongDanSuDung1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UHuongDanSuDung1.Location = New System.Drawing.Point(3, 16)
        Me.UHuongDanSuDung1.Name = "UHuongDanSuDung1"
        Me.UHuongDanSuDung1.Size = New System.Drawing.Size(937, 164)
        Me.UHuongDanSuDung1.TabIndex = 3
        '
        'uThongTin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "uThongTin"
        Me.Size = New System.Drawing.Size(943, 536)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLicenseType As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents lblProductID As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_thongTinGiayPhep As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_DangKy As System.Windows.Forms.LinkLabel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblProductKey As System.Windows.Forms.Label
    Friend WithEvents labLicense As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_copy1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_copy As System.Windows.Forms.LinkLabel
    Friend WithEvents UHuongDanSuDung1 As UNET.uHuongDanSuDung

End Class
