<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uThongKe_doanhthu_chiphi
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim StripLine1 As System.Windows.Forms.DataVisualization.Charting.StripLine = New System.Windows.Forms.DataVisualization.Charting.StripLine
        Dim StripLine2 As System.Windows.Forms.DataVisualization.Charting.StripLine = New System.Windows.Forms.DataVisualization.Charting.StripLine
        Dim StripLine3 As System.Windows.Forms.DataVisualization.Charting.StripLine = New System.Windows.Forms.DataVisualization.Charting.StripLine
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.LinkLabel_lammoi = New System.Windows.Forms.LinkLabel
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Chart_Doanhthu_chiphi = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.Label_ThongBaoDuLieu = New System.Windows.Forms.Label
        Me.Panel5.SuspendLayout()
        CType(Me.Chart_Doanhthu_chiphi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel5.Controls.Add(Me.LinkLabel_lammoi)
        Me.Panel5.Controls.Add(Me.LinkLabel5)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Panel5.Size = New System.Drawing.Size(429, 23)
        Me.Panel5.TabIndex = 2
        '
        'LinkLabel_lammoi
        '
        Me.LinkLabel_lammoi.Dock = System.Windows.Forms.DockStyle.Right
        Me.LinkLabel_lammoi.Image = Global.UNET.My.Resources.Resources.chuyen_nam_moi_16
        Me.LinkLabel_lammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel_lammoi.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel_lammoi.Location = New System.Drawing.Point(288, 0)
        Me.LinkLabel_lammoi.Name = "LinkLabel_lammoi"
        Me.LinkLabel_lammoi.Size = New System.Drawing.Size(66, 23)
        Me.LinkLabel_lammoi.TabIndex = 2
        Me.LinkLabel_lammoi.TabStop = True
        Me.LinkLabel_lammoi.Text = "Làm mới"
        Me.LinkLabel_lammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LinkLabel5
        '
        Me.LinkLabel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.LinkLabel5.Image = Global.UNET.My.Resources.Resources.tinh_lai_gia_xuat_kho_16
        Me.LinkLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel5.Location = New System.Drawing.Point(354, 0)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(66, 23)
        Me.LinkLabel5.TabIndex = 1
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Cấu hình"
        Me.LinkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LinkLabel5.Visible = False
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Location = New System.Drawing.Point(9, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Doanh thu và chi phí"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Chart_Doanhthu_chiphi
        '
        ChartArea1.AlignmentOrientation = CType((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical Or System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal), System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)
        ChartArea1.AxisX.StripLines.Add(StripLine1)
        ChartArea1.AxisX.StripLines.Add(StripLine2)
        ChartArea1.AxisX.StripLines.Add(StripLine3)
        ChartArea1.Name = "ChartArea1"
        Me.Chart_Doanhthu_chiphi.ChartAreas.Add(ChartArea1)
        Me.Chart_Doanhthu_chiphi.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart_Doanhthu_chiphi.Legends.Add(Legend1)
        Me.Chart_Doanhthu_chiphi.Location = New System.Drawing.Point(0, 240)
        Me.Chart_Doanhthu_chiphi.Name = "Chart_Doanhthu_chiphi"
        Me.Chart_Doanhthu_chiphi.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series1.ChartArea = "ChartArea1"
        Series1.CustomProperties = "PieLabelStyle=Outside"
        Series1.Legend = "Legend1"
        Series1.LegendText = "Doanh Thu"
        Series1.Name = "PSDT"
        Series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.LegendText = "Chi Phí"
        Series2.Name = "PSCP"
        Series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Me.Chart_Doanhthu_chiphi.Series.Add(Series1)
        Me.Chart_Doanhthu_chiphi.Series.Add(Series2)
        Me.Chart_Doanhthu_chiphi.Size = New System.Drawing.Size(429, 191)
        Me.Chart_Doanhthu_chiphi.TabIndex = 3
        '
        'Label_ThongBaoDuLieu
        '
        Me.Label_ThongBaoDuLieu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_ThongBaoDuLieu.Location = New System.Drawing.Point(0, 23)
        Me.Label_ThongBaoDuLieu.Name = "Label_ThongBaoDuLieu"
        Me.Label_ThongBaoDuLieu.Size = New System.Drawing.Size(429, 217)
        Me.Label_ThongBaoDuLieu.TabIndex = 4
        Me.Label_ThongBaoDuLieu.Text = "Không có dữ liệu thống kê."
        Me.Label_ThongBaoDuLieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uThongKe_doanhthu_chiphi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Chart_Doanhthu_chiphi)
        Me.Controls.Add(Me.Label_ThongBaoDuLieu)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "uThongKe_doanhthu_chiphi"
        Me.Size = New System.Drawing.Size(429, 431)
        Me.Panel5.ResumeLayout(False)
        CType(Me.Chart_Doanhthu_chiphi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Chart_Doanhthu_chiphi As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents LinkLabel_lammoi As System.Windows.Forms.LinkLabel
    Friend WithEvents Label_ThongBaoDuLieu As System.Windows.Forms.Label

End Class
