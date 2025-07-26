<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uThongKe_DoanhThuSanPham
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim StripLine4 As System.Windows.Forms.DataVisualization.Charting.StripLine = New System.Windows.Forms.DataVisualization.Charting.StripLine
        Dim StripLine5 As System.Windows.Forms.DataVisualization.Charting.StripLine = New System.Windows.Forms.DataVisualization.Charting.StripLine
        Dim StripLine6 As System.Windows.Forms.DataVisualization.Charting.StripLine = New System.Windows.Forms.DataVisualization.Charting.StripLine
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LinkLabel_LamMoi = New System.Windows.Forms.LinkLabel
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.Label_ThongBaoKhongCoDuLieu = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.LinkLabel_LamMoi)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Panel1.Size = New System.Drawing.Size(380, 23)
        Me.Panel1.TabIndex = 1
        '
        'LinkLabel_LamMoi
        '
        Me.LinkLabel_LamMoi.Dock = System.Windows.Forms.DockStyle.Right
        Me.LinkLabel_LamMoi.Image = Global.UNET.My.Resources.Resources.chuyen_nam_moi_16
        Me.LinkLabel_LamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel_LamMoi.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel_LamMoi.Location = New System.Drawing.Point(239, 0)
        Me.LinkLabel_LamMoi.Name = "LinkLabel_LamMoi"
        Me.LinkLabel_LamMoi.Size = New System.Drawing.Size(66, 23)
        Me.LinkLabel_LamMoi.TabIndex = 3
        Me.LinkLabel_LamMoi.TabStop = True
        Me.LinkLabel_LamMoi.Text = "Làm mới"
        Me.LinkLabel_LamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.LinkLabel1.Image = Global.UNET.My.Resources.Resources.tinh_lai_gia_xuat_kho_16
        Me.LinkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.Location = New System.Drawing.Point(305, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(66, 23)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Cấu hình"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LinkLabel1.Visible = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(9, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Doanh thu theo sản phẩm ( TOP 10 )"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Chart1
        '
        ChartArea2.AxisX.StripLines.Add(StripLine4)
        ChartArea2.AxisX.StripLines.Add(StripLine5)
        ChartArea2.AxisX.StripLines.Add(StripLine6)
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(0, 240)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.CustomProperties = "PieLabelStyle=Outside"
        Series2.IsValueShownAsLabel = True
        Series2.Legend = "Legend1"
        Series2.LegendText = "#LABEL"
        Series2.LegendToolTip = "#LEGENDTEXT"
        Series2.Name = "DoanhThuSanPham"
        Series2.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(380, 120)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Text = "Chart1"
        '
        'Label_ThongBaoKhongCoDuLieu
        '
        Me.Label_ThongBaoKhongCoDuLieu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_ThongBaoKhongCoDuLieu.Location = New System.Drawing.Point(0, 23)
        Me.Label_ThongBaoKhongCoDuLieu.Name = "Label_ThongBaoKhongCoDuLieu"
        Me.Label_ThongBaoKhongCoDuLieu.Size = New System.Drawing.Size(380, 217)
        Me.Label_ThongBaoKhongCoDuLieu.TabIndex = 3
        Me.Label_ThongBaoKhongCoDuLieu.Text = "Không có dữ liệu thống kê ."
        Me.Label_ThongBaoKhongCoDuLieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uThongKe_DoanhThuSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label_ThongBaoKhongCoDuLieu)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "uThongKe_DoanhThuSanPham"
        Me.Size = New System.Drawing.Size(380, 360)
        Me.Panel1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents LinkLabel_LamMoi As System.Windows.Forms.LinkLabel
    Friend WithEvents Label_ThongBaoKhongCoDuLieu As System.Windows.Forms.Label

End Class
