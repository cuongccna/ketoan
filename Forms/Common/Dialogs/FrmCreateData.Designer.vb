<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCreateData
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
        Me.components = New System.ComponentModel.Container
        Me.TabControl_CreateDatabase = New System.Windows.Forms.TabControl
        Me.tabpage_batDau = New System.Windows.Forms.TabPage
        Me.btnTiepTheo = New System.Windows.Forms.Button
        Me.txtTenDuLieu = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage_TienTrinhThucHien = New System.Windows.Forms.TabPage
        Me.btnThucHien = New System.Windows.Forms.Button
        Me.ProgressBar_TienTrinh = New System.Windows.Forms.ProgressBar
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TabPage_KetThucTienTrinh = New System.Windows.Forms.TabPage
        Me.btnBatDauSuDung = New System.Windows.Forms.Button
        Me.labSuccess_desc = New System.Windows.Forms.Label
        Me.labSuccess = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl_CreateDatabase.SuspendLayout()
        Me.tabpage_batDau.SuspendLayout()
        Me.TabPage_TienTrinhThucHien.SuspendLayout()
        Me.TabPage_KetThucTienTrinh.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl_CreateDatabase
        '
        Me.TabControl_CreateDatabase.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl_CreateDatabase.Controls.Add(Me.tabpage_batDau)
        Me.TabControl_CreateDatabase.Controls.Add(Me.TabPage_TienTrinhThucHien)
        Me.TabControl_CreateDatabase.Controls.Add(Me.TabPage_KetThucTienTrinh)
        Me.TabControl_CreateDatabase.Location = New System.Drawing.Point(2, 2)
        Me.TabControl_CreateDatabase.Multiline = True
        Me.TabControl_CreateDatabase.Name = "TabControl_CreateDatabase"
        Me.TabControl_CreateDatabase.SelectedIndex = 0
        Me.TabControl_CreateDatabase.Size = New System.Drawing.Size(439, 173)
        Me.TabControl_CreateDatabase.TabIndex = 0
        '
        'tabpage_batDau
        '
        Me.tabpage_batDau.Controls.Add(Me.btnTiepTheo)
        Me.tabpage_batDau.Controls.Add(Me.txtTenDuLieu)
        Me.tabpage_batDau.Controls.Add(Me.Label4)
        Me.tabpage_batDau.Controls.Add(Me.Label3)
        Me.tabpage_batDau.Controls.Add(Me.Label2)
        Me.tabpage_batDau.Controls.Add(Me.Label1)
        Me.tabpage_batDau.Location = New System.Drawing.Point(4, 4)
        Me.tabpage_batDau.Name = "tabpage_batDau"
        Me.tabpage_batDau.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_batDau.Size = New System.Drawing.Size(431, 147)
        Me.tabpage_batDau.TabIndex = 3
        Me.tabpage_batDau.Text = "Bắt đầu"
        Me.tabpage_batDau.UseVisualStyleBackColor = True
        '
        'btnTiepTheo
        '
        Me.btnTiepTheo.Location = New System.Drawing.Point(250, 86)
        Me.btnTiepTheo.Name = "btnTiepTheo"
        Me.btnTiepTheo.Size = New System.Drawing.Size(75, 23)
        Me.btnTiepTheo.TabIndex = 4
        Me.btnTiepTheo.Tag = "Next"
        Me.btnTiepTheo.Text = "Tiếp theo."
        Me.btnTiepTheo.UseVisualStyleBackColor = True
        '
        'txtTenDuLieu
        '
        Me.txtTenDuLieu.Location = New System.Drawing.Point(159, 60)
        Me.txtTenDuLieu.Name = "txtTenDuLieu"
        Me.txtTenDuLieu.Size = New System.Drawing.Size(166, 20)
        Me.txtTenDuLieu.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(7, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(417, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "(*) bắt buộc nhập, Tên dữ liệu không được có khoảng trắng và ký tự đặc biệt."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Tag = "Name data (*)"
        Me.Label3.Text = "Tên dữ liệu (*)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Tag = "Please correct information to create data."
        Me.Label2.Text = "Nhập thông tin chính xác để tạo dữ liệu."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Tag = "Winzar create new data."
        Me.Label1.Text = "Trình tạo cơ sở dữ liệu mới ."
        '
        'TabPage_TienTrinhThucHien
        '
        Me.TabPage_TienTrinhThucHien.Controls.Add(Me.btnThucHien)
        Me.TabPage_TienTrinhThucHien.Controls.Add(Me.ProgressBar_TienTrinh)
        Me.TabPage_TienTrinhThucHien.Controls.Add(Me.Label5)
        Me.TabPage_TienTrinhThucHien.Controls.Add(Me.Label6)
        Me.TabPage_TienTrinhThucHien.Location = New System.Drawing.Point(4, 4)
        Me.TabPage_TienTrinhThucHien.Name = "TabPage_TienTrinhThucHien"
        Me.TabPage_TienTrinhThucHien.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_TienTrinhThucHien.Size = New System.Drawing.Size(431, 147)
        Me.TabPage_TienTrinhThucHien.TabIndex = 1
        Me.TabPage_TienTrinhThucHien.Text = "Quá trình tạo dữ liệu"
        Me.TabPage_TienTrinhThucHien.UseVisualStyleBackColor = True
        '
        'btnThucHien
        '
        Me.btnThucHien.Location = New System.Drawing.Point(317, 97)
        Me.btnThucHien.Name = "btnThucHien"
        Me.btnThucHien.Size = New System.Drawing.Size(75, 23)
        Me.btnThucHien.TabIndex = 3
        Me.btnThucHien.Text = "Thực hiện."
        Me.btnThucHien.UseVisualStyleBackColor = True
        '
        'ProgressBar_TienTrinh
        '
        Me.ProgressBar_TienTrinh.Location = New System.Drawing.Point(32, 68)
        Me.ProgressBar_TienTrinh.Name = "ProgressBar_TienTrinh"
        Me.ProgressBar_TienTrinh.Size = New System.Drawing.Size(360, 23)
        Me.ProgressBar_TienTrinh.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(269, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Làm ơn chờ dữ liệu được tạo thành công !"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tiến trình tạo dữ liệu."
        '
        'TabPage_KetThucTienTrinh
        '
        Me.TabPage_KetThucTienTrinh.Controls.Add(Me.btnBatDauSuDung)
        Me.TabPage_KetThucTienTrinh.Controls.Add(Me.labSuccess_desc)
        Me.TabPage_KetThucTienTrinh.Controls.Add(Me.labSuccess)
        Me.TabPage_KetThucTienTrinh.Location = New System.Drawing.Point(4, 4)
        Me.TabPage_KetThucTienTrinh.Name = "TabPage_KetThucTienTrinh"
        Me.TabPage_KetThucTienTrinh.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_KetThucTienTrinh.Size = New System.Drawing.Size(431, 147)
        Me.TabPage_KetThucTienTrinh.TabIndex = 2
        Me.TabPage_KetThucTienTrinh.Text = "Kết thúc quá trình tạo dữ liệu"
        Me.TabPage_KetThucTienTrinh.UseVisualStyleBackColor = True
        '
        'btnBatDauSuDung
        '
        Me.btnBatDauSuDung.Location = New System.Drawing.Point(334, 105)
        Me.btnBatDauSuDung.Name = "btnBatDauSuDung"
        Me.btnBatDauSuDung.Size = New System.Drawing.Size(75, 23)
        Me.btnBatDauSuDung.TabIndex = 5
        Me.btnBatDauSuDung.Text = "Kết Thúc."
        Me.btnBatDauSuDung.UseVisualStyleBackColor = True
        '
        'labSuccess_desc
        '
        Me.labSuccess_desc.AutoSize = True
        Me.labSuccess_desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labSuccess_desc.Location = New System.Drawing.Point(27, 30)
        Me.labSuccess_desc.Name = "labSuccess_desc"
        Me.labSuccess_desc.Size = New System.Drawing.Size(356, 60)
        Me.labSuccess_desc.TabIndex = 4
        Me.labSuccess_desc.Text = "Để cập nhật thông tin công ty :Tên công ty ,mã số thuế , địa chỉ ..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vui lòng và" & _
            "o Menu : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """ Hệ Thống"" -> ""Đăng Ký Sử Dụng"" để cập nhật" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "thông tin ."
        '
        'labSuccess
        '
        Me.labSuccess.AutoSize = True
        Me.labSuccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labSuccess.Location = New System.Drawing.Point(6, 3)
        Me.labSuccess.Name = "labSuccess"
        Me.labSuccess.Size = New System.Drawing.Size(277, 20)
        Me.labSuccess.TabIndex = 3
        Me.labSuccess.Text = "Quá trình tạo dữ liệu thành công !"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmCreateData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 153)
        Me.Controls.Add(Me.TabControl_CreateDatabase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCreateData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Create new data"
        Me.Text = "Tạo mới dữ liệu."
        Me.TabControl_CreateDatabase.ResumeLayout(False)
        Me.tabpage_batDau.ResumeLayout(False)
        Me.tabpage_batDau.PerformLayout()
        Me.TabPage_TienTrinhThucHien.ResumeLayout(False)
        Me.TabPage_TienTrinhThucHien.PerformLayout()
        Me.TabPage_KetThucTienTrinh.ResumeLayout(False)
        Me.TabPage_KetThucTienTrinh.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage_TienTrinhThucHien As System.Windows.Forms.TabPage
    Friend WithEvents TabControl_CreateDatabase As System.Windows.Forms.TabControl
    Friend WithEvents tabpage_batDau As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage_KetThucTienTrinh As System.Windows.Forms.TabPage
    Friend WithEvents txtTenDuLieu As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnTiepTheo As System.Windows.Forms.Button
    Friend WithEvents btnThucHien As System.Windows.Forms.Button
    Friend WithEvents ProgressBar_TienTrinh As System.Windows.Forms.ProgressBar
    Friend WithEvents labSuccess_desc As System.Windows.Forms.Label
    Friend WithEvents labSuccess As System.Windows.Forms.Label
    Friend WithEvents btnBatDauSuDung As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
