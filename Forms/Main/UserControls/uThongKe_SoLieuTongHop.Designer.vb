<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uThongKe_SoLieuTongHop
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
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LinkLabel_lammoi = New System.Windows.Forms.LinkLabel
        Me.Label3 = New System.Windows.Forms.Label
        Me.ListView_SoLieuTongHop = New System.Windows.Forms.ListView
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.LinkLabel_lammoi)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Panel3.Size = New System.Drawing.Size(338, 23)
        Me.Panel3.TabIndex = 3
        '
        'LinkLabel_lammoi
        '
        Me.LinkLabel_lammoi.Dock = System.Windows.Forms.DockStyle.Right
        Me.LinkLabel_lammoi.Image = Global.UNET.My.Resources.Resources.chuyen_nam_moi_16
        Me.LinkLabel_lammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel_lammoi.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel_lammoi.Location = New System.Drawing.Point(263, 0)
        Me.LinkLabel_lammoi.Name = "LinkLabel_lammoi"
        Me.LinkLabel_lammoi.Size = New System.Drawing.Size(66, 23)
        Me.LinkLabel_lammoi.TabIndex = 1
        Me.LinkLabel_lammoi.TabStop = True
        Me.LinkLabel_lammoi.Text = "Làm mới"
        Me.LinkLabel_lammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Location = New System.Drawing.Point(9, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Số liệu tổng hợp"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListView_SoLieuTongHop
        '
        Me.ListView_SoLieuTongHop.AllowColumnReorder = True
        Me.ListView_SoLieuTongHop.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView_SoLieuTongHop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView_SoLieuTongHop.GridLines = True
        Me.ListView_SoLieuTongHop.Location = New System.Drawing.Point(0, 23)
        Me.ListView_SoLieuTongHop.MultiSelect = False
        Me.ListView_SoLieuTongHop.Name = "ListView_SoLieuTongHop"
        Me.ListView_SoLieuTongHop.ShowItemToolTips = True
        Me.ListView_SoLieuTongHop.Size = New System.Drawing.Size(338, 334)
        Me.ListView_SoLieuTongHop.TabIndex = 5
        Me.ListView_SoLieuTongHop.UseCompatibleStateImageBehavior = False
        '
        'uThongKe_SoLieuTongHop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListView_SoLieuTongHop)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "uThongKe_SoLieuTongHop"
        Me.Size = New System.Drawing.Size(338, 357)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel_lammoi As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListView_SoLieuTongHop As System.Windows.Forms.ListView

End Class
