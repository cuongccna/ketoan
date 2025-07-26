<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUMessager
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
        Me.btnNo = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnYes = New System.Windows.Forms.Button
        Me.txtNoiDung = New System.Windows.Forms.RichTextBox
        Me.lab_TB = New System.Windows.Forms.Label
        Me.lab_TieuDe = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNo
        '
        Me.btnNo.FlatAppearance.BorderSize = 0
        Me.btnNo.Location = New System.Drawing.Point(287, 7)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(75, 23)
        Me.btnNo.TabIndex = 12
        Me.btnNo.Text = "&Không"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.Location = New System.Drawing.Point(287, 7)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 13
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnYes
        '
        Me.btnYes.FlatAppearance.BorderSize = 0
        Me.btnYes.Location = New System.Drawing.Point(206, 7)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(75, 23)
        Me.btnYes.TabIndex = 14
        Me.btnYes.Text = "&Có"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'txtNoiDung
        '
        Me.txtNoiDung.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNoiDung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoiDung.Location = New System.Drawing.Point(12, 39)
        Me.txtNoiDung.Name = "txtNoiDung"
        Me.txtNoiDung.ReadOnly = True
        Me.txtNoiDung.Size = New System.Drawing.Size(365, 73)
        Me.txtNoiDung.TabIndex = 11
        Me.txtNoiDung.Text = "..."
        '
        'lab_TB
        '
        Me.lab_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_TB.Image = Global.UNET.My.Resources.Resources.errorMessager
        Me.lab_TB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lab_TB.Location = New System.Drawing.Point(1, 2)
        Me.lab_TB.Name = "lab_TB"
        Me.lab_TB.Size = New System.Drawing.Size(35, 35)
        Me.lab_TB.TabIndex = 9
        Me.lab_TB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lab_TieuDe
        '
        Me.lab_TieuDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_TieuDe.Location = New System.Drawing.Point(45, 4)
        Me.lab_TieuDe.Name = "lab_TieuDe"
        Me.lab_TieuDe.Size = New System.Drawing.Size(332, 33)
        Me.lab_TieuDe.TabIndex = 10
        Me.lab_TieuDe.Text = "Tiêu đề"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnNo)
        Me.Panel1.Controls.Add(Me.btnYes)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Location = New System.Drawing.Point(0, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(390, 41)
        Me.Panel1.TabIndex = 15
        '
        'FrmUMessager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 157)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtNoiDung)
        Me.Controls.Add(Me.lab_TB)
        Me.Controls.Add(Me.lab_TieuDe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "FrmUMessager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnOK As System.Windows.Forms.Button
    Public WithEvents txtNoiDung As System.Windows.Forms.RichTextBox
    Public WithEvents lab_TB As System.Windows.Forms.Label
    Public WithEvents lab_TieuDe As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents btnNo As System.Windows.Forms.Button
    Public WithEvents btnYes As System.Windows.Forms.Button
End Class
