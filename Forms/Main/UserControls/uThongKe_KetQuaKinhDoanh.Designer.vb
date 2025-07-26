<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uThongKe_KetQuaKinhDoanh
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
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.LinkLabel_lammoi = New System.Windows.Forms.LinkLabel
        Me.Label4 = New System.Windows.Forms.Label
        Me.ListView_KetQuaKinhDoanh = New System.Windows.Forms.ListView
        Me.Label_ThongBaoDuLieu = New System.Windows.Forms.Label
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel4.Controls.Add(Me.LinkLabel_lammoi)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Panel4.Size = New System.Drawing.Size(275, 23)
        Me.Panel4.TabIndex = 3
        '
        'LinkLabel_lammoi
        '
        Me.LinkLabel_lammoi.Dock = System.Windows.Forms.DockStyle.Right
        Me.LinkLabel_lammoi.Image = Global.UNET.My.Resources.Resources.chuyen_nam_moi_16
        Me.LinkLabel_lammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel_lammoi.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel_lammoi.Location = New System.Drawing.Point(200, 0)
        Me.LinkLabel_lammoi.Name = "LinkLabel_lammoi"
        Me.LinkLabel_lammoi.Size = New System.Drawing.Size(66, 23)
        Me.LinkLabel_lammoi.TabIndex = 1
        Me.LinkLabel_lammoi.TabStop = True
        Me.LinkLabel_lammoi.Text = "Làm mới"
        Me.LinkLabel_lammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Location = New System.Drawing.Point(9, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Số dư khách hàng"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListView_KetQuaKinhDoanh
        '
        Me.ListView_KetQuaKinhDoanh.AllowColumnReorder = True
        Me.ListView_KetQuaKinhDoanh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView_KetQuaKinhDoanh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView_KetQuaKinhDoanh.GridLines = True
        Me.ListView_KetQuaKinhDoanh.Location = New System.Drawing.Point(0, 225)
        Me.ListView_KetQuaKinhDoanh.MultiSelect = False
        Me.ListView_KetQuaKinhDoanh.Name = "ListView_KetQuaKinhDoanh"
        Me.ListView_KetQuaKinhDoanh.ShowItemToolTips = True
        Me.ListView_KetQuaKinhDoanh.Size = New System.Drawing.Size(275, 180)
        Me.ListView_KetQuaKinhDoanh.TabIndex = 5
        Me.ListView_KetQuaKinhDoanh.UseCompatibleStateImageBehavior = False
        '
        'Label_ThongBaoDuLieu
        '
        Me.Label_ThongBaoDuLieu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_ThongBaoDuLieu.Location = New System.Drawing.Point(0, 23)
        Me.Label_ThongBaoDuLieu.Name = "Label_ThongBaoDuLieu"
        Me.Label_ThongBaoDuLieu.Size = New System.Drawing.Size(275, 202)
        Me.Label_ThongBaoDuLieu.TabIndex = 6
        Me.Label_ThongBaoDuLieu.Text = "Không có dữ liệu thống kê."
        Me.Label_ThongBaoDuLieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uThongKe_KetQuaKinhDoanh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListView_KetQuaKinhDoanh)
        Me.Controls.Add(Me.Label_ThongBaoDuLieu)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "uThongKe_KetQuaKinhDoanh"
        Me.Size = New System.Drawing.Size(275, 405)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel_lammoi As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListView_KetQuaKinhDoanh As System.Windows.Forms.ListView
    Friend WithEvents Label_ThongBaoDuLieu As System.Windows.Forms.Label

End Class
