<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uThongKe
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer_top = New System.Windows.Forms.SplitContainer
        Me.SplitContainer_bottom = New System.Windows.Forms.SplitContainer
        Me.SplitContainer_SoLieuTongHop = New System.Windows.Forms.SplitContainer
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer_top.SuspendLayout()
        Me.SplitContainer_bottom.Panel2.SuspendLayout()
        Me.SplitContainer_bottom.SuspendLayout()
        Me.SplitContainer_SoLieuTongHop.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer_top)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer_bottom)
        Me.SplitContainer1.Size = New System.Drawing.Size(918, 521)
        Me.SplitContainer1.SplitterDistance = 240
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer_top
        '
        Me.SplitContainer_top.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_top.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_top.Name = "SplitContainer_top"
        Me.SplitContainer_top.Size = New System.Drawing.Size(918, 240)
        Me.SplitContainer_top.SplitterDistance = 432
        Me.SplitContainer_top.TabIndex = 0
        '
        'SplitContainer_bottom
        '
        Me.SplitContainer_bottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_bottom.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_bottom.Name = "SplitContainer_bottom"
        '
        'SplitContainer_bottom.Panel2
        '
        Me.SplitContainer_bottom.Panel2.Controls.Add(Me.SplitContainer_SoLieuTongHop)
        Me.SplitContainer_bottom.Size = New System.Drawing.Size(918, 277)
        Me.SplitContainer_bottom.SplitterDistance = 359
        Me.SplitContainer_bottom.TabIndex = 0
        '
        'SplitContainer_SoLieuTongHop
        '
        Me.SplitContainer_SoLieuTongHop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_SoLieuTongHop.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_SoLieuTongHop.Name = "SplitContainer_SoLieuTongHop"
        Me.SplitContainer_SoLieuTongHop.Size = New System.Drawing.Size(555, 277)
        Me.SplitContainer_SoLieuTongHop.SplitterDistance = 266
        Me.SplitContainer_SoLieuTongHop.TabIndex = 0
        '
        'uThongKe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "uThongKe"
        Me.Size = New System.Drawing.Size(918, 521)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer_top.ResumeLayout(False)
        Me.SplitContainer_bottom.Panel2.ResumeLayout(False)
        Me.SplitContainer_bottom.ResumeLayout(False)
        Me.SplitContainer_SoLieuTongHop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer_top As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer_bottom As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer_SoLieuTongHop As System.Windows.Forms.SplitContainer

End Class
