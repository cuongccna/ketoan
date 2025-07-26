<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDeleteData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDeleteData))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbDanhSachDulieu = New System.Windows.Forms.ComboBox
        Me.btnThucHien = New System.Windows.Forms.Button
        Me.btnDong = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chọn dữ liệu để xóa."
        '
        'cmbDanhSachDulieu
        '
        Me.cmbDanhSachDulieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDanhSachDulieu.FormattingEnabled = True
        Me.cmbDanhSachDulieu.Location = New System.Drawing.Point(15, 21)
        Me.cmbDanhSachDulieu.Name = "cmbDanhSachDulieu"
        Me.cmbDanhSachDulieu.Size = New System.Drawing.Size(255, 26)
        Me.cmbDanhSachDulieu.TabIndex = 1
        '
        'btnThucHien
        '
        Me.btnThucHien.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThucHien.Image = Global.UNET.My.Resources.Resources.select16
        Me.btnThucHien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThucHien.Location = New System.Drawing.Point(80, 53)
        Me.btnThucHien.Name = "btnThucHien"
        Me.btnThucHien.Size = New System.Drawing.Size(101, 30)
        Me.btnThucHien.TabIndex = 2
        Me.btnThucHien.Text = "&Thực Hiện"
        Me.btnThucHien.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThucHien.UseVisualStyleBackColor = True
        '
        'btnDong
        '
        Me.btnDong.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDong.Image = Global.UNET.My.Resources.Resources.delete16
        Me.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDong.Location = New System.Drawing.Point(187, 53)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(83, 30)
        Me.btnDong.TabIndex = 3
        Me.btnDong.Text = "Đón&g"
        Me.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'FrmDeleteData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 90)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnThucHien)
        Me.Controls.Add(Me.cmbDanhSachDulieu)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDeleteData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Xóa dữ liệu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbDanhSachDulieu As System.Windows.Forms.ComboBox
    Friend WithEvents btnThucHien As System.Windows.Forms.Button
    Friend WithEvents btnDong As System.Windows.Forms.Button
End Class
