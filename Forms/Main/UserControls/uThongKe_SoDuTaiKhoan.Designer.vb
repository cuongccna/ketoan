<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uThongKe_SoDuTaiKhoan
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LinkLabel_lammoi = New System.Windows.Forms.LinkLabel
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.Label2 = New System.Windows.Forms.Label
        Me.ListView_SoDuTaiKhoan = New System.Windows.Forms.ListView
        Me.Label_ThongBaoDuLieu = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.LinkLabel_lammoi)
        Me.Panel2.Controls.Add(Me.LinkLabel2)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Panel2.Size = New System.Drawing.Size(384, 23)
        Me.Panel2.TabIndex = 3
        '
        'LinkLabel_lammoi
        '
        Me.LinkLabel_lammoi.Dock = System.Windows.Forms.DockStyle.Right
        Me.LinkLabel_lammoi.Image = Global.UNET.My.Resources.Resources.chuyen_nam_moi_16
        Me.LinkLabel_lammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel_lammoi.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel_lammoi.Location = New System.Drawing.Point(243, 0)
        Me.LinkLabel_lammoi.Name = "LinkLabel_lammoi"
        Me.LinkLabel_lammoi.Size = New System.Drawing.Size(66, 23)
        Me.LinkLabel_lammoi.TabIndex = 2
        Me.LinkLabel_lammoi.TabStop = True
        Me.LinkLabel_lammoi.Text = "Làm mới"
        Me.LinkLabel_lammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.LinkLabel2.Image = Global.UNET.My.Resources.Resources.tinh_lai_gia_xuat_kho_16
        Me.LinkLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.Location = New System.Drawing.Point(309, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(66, 23)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Cấu hình"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LinkLabel2.Visible = False
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(9, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Số dư tài khoản"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListView_SoDuTaiKhoan
        '
        Me.ListView_SoDuTaiKhoan.AllowColumnReorder = True
        Me.ListView_SoDuTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView_SoDuTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView_SoDuTaiKhoan.GridLines = True
        Me.ListView_SoDuTaiKhoan.Location = New System.Drawing.Point(0, 202)
        Me.ListView_SoDuTaiKhoan.MultiSelect = False
        Me.ListView_SoDuTaiKhoan.Name = "ListView_SoDuTaiKhoan"
        Me.ListView_SoDuTaiKhoan.ShowItemToolTips = True
        Me.ListView_SoDuTaiKhoan.Size = New System.Drawing.Size(384, 123)
        Me.ListView_SoDuTaiKhoan.TabIndex = 4
        Me.ListView_SoDuTaiKhoan.UseCompatibleStateImageBehavior = False
        '
        'Label_ThongBaoDuLieu
        '
        Me.Label_ThongBaoDuLieu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_ThongBaoDuLieu.Location = New System.Drawing.Point(0, 23)
        Me.Label_ThongBaoDuLieu.Name = "Label_ThongBaoDuLieu"
        Me.Label_ThongBaoDuLieu.Size = New System.Drawing.Size(384, 179)
        Me.Label_ThongBaoDuLieu.TabIndex = 5
        Me.Label_ThongBaoDuLieu.Text = "Không có dữ liệu thống kê."
        Me.Label_ThongBaoDuLieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uThongKe_SoDuTaiKhoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListView_SoDuTaiKhoan)
        Me.Controls.Add(Me.Label_ThongBaoDuLieu)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "uThongKe_SoDuTaiKhoan"
        Me.Size = New System.Drawing.Size(384, 325)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListView_SoDuTaiKhoan As System.Windows.Forms.ListView
    Friend WithEvents LinkLabel_lammoi As System.Windows.Forms.LinkLabel
    Friend WithEvents Label_ThongBaoDuLieu As System.Windows.Forms.Label

End Class
