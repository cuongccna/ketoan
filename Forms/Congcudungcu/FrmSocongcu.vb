Imports System
Imports System.Data.Common
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmSocongcu
    Dim baocao As Integer
    Dim TenFile, TenBaoCao As String
    Dim SoLieu(11) As Boolean
    Dim chi_so As Integer

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_2.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim tdau, tcuoi As Integer
        Dim tg As String = String.Empty
        Select Case Index
            Case 0
                Me.Cursor = Cursors.Default
                GauGe.Value = 0
                If CboThang(1).Items.Count > 0 Then
                    If CboThang(0).Enabled And CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
                End If

                If baocao = 89 Then
                    If CboThang(0).Items.Count > 0 Then CboThang(0).SelectedIndex = 0
                    If CboThang(1).Items.Count > 0 Then CboThang(1).SelectedIndex = 11
                End If
                tdau = CboThang(0).SelectedValue
                tcuoi = CboThang(1).SelectedValue

                Select Case baocao
                    Case 89, 90
                        If CboThang(0).Enabled And CboThang(1).Enabled Then
                            tg = ThoiGianTheoThang(tdau, tcuoi)
                        Else
                            If CboThang(0).Enabled Then
                                tcuoi = tdau
                            Else
                                tdau = tcuoi
                            End If
                            tg = ThoiGianTheoThang(tdau, tdau)
                        End If
                        ' Chuẩn bị số liệu
                        TinhSoLieuBaoCao()
                        ' Tạo báo cáo
                        Dim rptData() As String = TaoBaoCao3()
                        rptFrom.InitForm(TenFile, rptData(0), rptData(1))

                        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
                        ' Công thức
                        rptFrom.SetFormulas("TenBaoCao", String.Format("'{0}'", TenBaoCao))
                        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", tg))
                End Select
                If Not RptOK(rptFrom.ReportFilename, 0) Then
                    MessageBox.Show(Ngonngu("Mẫu báo cáo đã bị thay đổi!", "Change report form!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    GoTo LoiBC
                End If
                rptFrom.ReportWindowTitle = OptBC(baocao).Text
                rptFrom.ReportWindowState = System.Windows.Forms.FormWindowState.Maximized
                InBaoCaoRPT()
                On Error GoTo LoiBC
                'frmMain.rpt.Action = 1
            Case 2
                Me.Close() : Exit Sub
                Exit Sub
        End Select
LoiBC:
        HienThongBao(Me.Text, 1)
        GauGe.Value = GauGe.Maximum
        Me.Cursor = Cursors.Default
        If _CboThang_1.Items.Count > 0 Then
            chiso1 = _CboThang_1.SelectedIndex
        End If
        If _CboThang_0.Items.Count > 0 Then
            chiso0 = _CboThang_0.SelectedIndex
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmSocongcu_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.X
                    Command(0).Focus()
                    ' Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.V
                    Command(2).Focus()
                    ' Command_ClickEvent(Command(2), New EventArgs())
            End Select
        End If
        If (Shift And 2) > 0 And eventArgs.KeyCode = Keys.P Then
            frmMain.mnHT_Click(frmMain.mnHT, New EventArgs())
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private chiso1 As Integer = -1
    Private chiso0 As Integer = -1
    Private Sub FrmSocongcu_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            OptBC_CheckedChanged(OptBC(89), New EventArgs())
            AddMonthToCbo(CboThang(0))
            AddMonthToCbo(CboThang(1))
            For chi_so As Integer = 1 To 12
                SoLieu(chi_so - 1) = False
            Next
            Text = SetFormTitle(Text)
            SetFont(Me)
            If chiso0 <> -1 And _CboThang_0.Items.Count > 0 Then
                _CboThang_0.SelectedIndex = chiso0
            End If
            If chiso1 <> -1 And _CboThang_1.Items.Count > 0 Then
                _CboThang_1.SelectedIndex = chiso1
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private isInitializingComponent As Boolean

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub OptBC_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptBC_89.CheckedChanged, _OptBC_90.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(OptBC, eventSender)
            Dim thg_dau, thg_cuoi As Boolean
            baocao = Index
            Select Case Index
                Case 89
                    TenFile = "PHANBO.RPT"
                    TenBaoCao = "Sổ phân bổ chi tiết"
                    thg_dau = True : thg_cuoi = True
                Case 90
                    TenFile = "SOCCDC.RPT"
                    TenBaoCao = "Sổ công cụ dụng cụ"
                    thg_dau = True : thg_cuoi = False
                Case Else
                    thg_dau = True : thg_cuoi = True
            End Select
            If thg_dau Then
                Label(0).Enabled = True
                CboThang(0).Enabled = True
            Else
                Label(0).Enabled = False
                CboThang(0).Enabled = False
            End If
            If thg_cuoi Then
                Label(1).Enabled = True
                CboThang(1).Enabled = True
            Else
                Label(1).Enabled = False
                CboThang(1).Enabled = False
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Function TaoBaoCao3() As String()
        Dim thg_dau, thg_cuoi As Integer
        If CboThang(0).Enabled Then thg_dau = CboThang(0).SelectedValue
        If CboThang(1).Enabled Then thg_cuoi = CboThang(1).SelectedValue

        Dim returnTablename As String = String.Empty
        Dim returnSQL As String = String.Empty

        Select Case baocao
            Case 89 ' Sổ phân bổ
                Dim SoKhauHao142_153 As String = String.Format("SELECT DISTINCT Congcudungcu.maso as MaSoTS,Congcudungcu.SoHieu AS SoHieuTS, max(Congcudungcu.Ten) AS TenTS, max(LoaiCongcudungcu.SoHieu) AS SoHieuTK, max(LoaiCongcudungcu.MaSo) AS MaTK, max(LoaiCongcudungcu.Ten) AS TenTK, max(Congcudungcu.NamKH) AS SoNamKH,(max(NG_NS)+max(NG_TBS)+max(NG_CNK)+max(NG_TD)) AS NG,(min(CL_NS)+min(CL_TBS)+min(CL_CNK)+min(CL_TD)) AS CL, max(LoaiCongcudungcu_1.SoHieu) AS SHLoai, max(LoaiCongcudungcu_1.Ten) AS TenLoai, Max(CASE WHEN Thang=1 AND ThangGiam>={0} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH1, Max(CASE WHEN Thang=2 AND ThangGiam>={1} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH2, Max(CASE WHEN Thang=3 AND ThangGiam>={2} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH3, Max(CASE WHEN Thang=4 AND ThangGiam>={3} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH4, Max(CASE WHEN Thang=5 AND ThangGiam>={4} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH5, Max(CASE WHEN Thang=6 AND ThangGiam>={5} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH6, Max(CASE WHEN Thang=7 AND ThangGiam>={6} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH7, Max(CASE WHEN Thang=8 AND ThangGiam>={7} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH8, Max(CASE WHEN Thang=9 AND ThangGiam>={8} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH9, Max(CASE WHEN Thang=10 AND ThangGiam>={9} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH10, Max(CASE WHEN Thang=11 AND ThangGiam>={10} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH11, Max(CASE WHEN Thang=12 AND ThangGiam>={11} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH12 FROM LoaiCongcudungcu AS LoaiCongcudungcu_1 RIGHT JOIN ((LoaiCongcudungcu RIGHT JOIN Congcudungcu ON LoaiCongcudungcu.MaSo = Congcudungcu.MaTaiKhoan) RIGHT JOIN (ThongSo1 inner join chungtu on thongso1.thang=chungtu.thangct and thongso1.madtsd=chungtu.matktcno) ON Congcudungcu.MaSo = ThongSo1.MaTS) ON LoaiCongcudungcu_1.MaSo=Congcudungcu.MaLoai WHERE chungtu.maloai=14 GROUP BY Congcudungcu.maso, Congcudungcu.SoHieu, Congcudungcu.MaTaiKhoan, Congcudungcu.MaLoai", _
                                                    CThangFR(1), _
                                                    CThangFR(2), _
                                                    CThangFR(3), _
                                                    CThangFR(4), _
                                                    CThangFR(5), _
                                                    CThangFR(6), _
                                                    CThangFR(7), _
                                                    CThangFR(8), _
                                                    CThangFR(9), _
                                                    CThangFR(10), _
                                                    CThangFR(11), _
                                                    CThangFR(12))
                'Dim Sodudaunam142_153 As String = "SELECT DISTINCT Congcudungcu.Maso AS MaSoTS, (CASE WHEN kh_ns+kh_tbs+kh_cnk+kh_td=0 and (cl_ns+cl_tbs+cl_cnk+cl_td)<(ng_ns+ng_tbs+ng_cnk+ng_td) THEN cl_ns+cl_tbs+cl_cnk+cl_td ELSE 0 END)as daunam " & "FROM LoaiCongcudungcu AS LoaiCongcudungcu_1 RIGHT JOIN ((LoaiCongcudungcu RIGHT JOIN Congcudungcu ON LoaiCongcudungcu.MaSo = Congcudungcu.MaTaiKhoan) " & "RIGHT JOIN ThongSo1 ON Congcudungcu.MaSo = ThongSo1.MaTS) ON LoaiCongcudungcu_1.MaSo=Congcudungcu.MaLoai " & "WHERE thang=0 GROUP BY Congcudungcu.maso,Congcudungcu.SoHieu, Congcudungcu.MaTaiKhoan, Congcudungcu.MaLoai" ' [Must care]
                Dim Sodudaunam142_153 As String = "SELECT DISTINCT Congcudungcu.Maso AS MaSoTS, CASE WHEN kh_ns+kh_tbs+kh_cnk+kh_td=0 and (cl_ns+cl_tbs+cl_cnk+cl_td)<(ng_ns+ng_tbs+ng_cnk+ng_td) THEN cl_ns+cl_tbs+cl_cnk+cl_td ELSE 0 END as daunam " & "FROM LoaiCongcudungcu AS LoaiCongcudungcu_1 RIGHT JOIN ((LoaiCongcudungcu RIGHT JOIN Congcudungcu ON LoaiCongcudungcu.MaSo = Congcudungcu.MaTaiKhoan) " & "RIGHT JOIN ThongSo1 ON Congcudungcu.MaSo = ThongSo1.MaTS) ON LoaiCongcudungcu_1.MaSo=Congcudungcu.MaLoai " & "WHERE thang=0 GROUP BY Congcudungcu.maso,Congcudungcu.SoHieu,Congcudungcu.MaTaiKhoan, Congcudungcu.MaLoai, ThongSo1.kh_ns, ThongSo1.kh_cnk, ThongSo1.kh_td,ThongSo1.cl_ns, ThongSo1.cl_tbs, ThongSo1.cl_cnk, ThongSo1.cl_td, ThongSo1.ng_ns,ThongSo1.ng_tbs, ThongSo1.ng_cnk, ThongSo1.ng_td, ThongSo1.cl_ns, ThongSo1.cl_tbs,ThongSo1.cl_cnk, ThongSo1.cl_td, ThongSo1.kh_tbs" ' [Must care]
                returnSQL = String.Format("SELECT DISTINCT sokhauhao142_153.MaSoTS,sokhauhao142_153.SoHieuTS,sokhauhao142_153.TenTS,sokhauhao142_153.SoHieuTK,sokhauhao142_153.MaTK,sokhauhao142_153.TenTK,sokhauhao142_153.SoNamKH,sokhauhao142_153.NG,sokhauhao142_153.CL,sokhauhao142_153.SHLoai,sokhauhao142_153.TenLoai,sokhauhao142_153.KH1,sokhauhao142_153.KH2,sokhauhao142_153.KH3,sokhauhao142_153.KH4,sokhauhao142_153.KH5,sokhauhao142_153.KH6, sokhauhao142_153.KH7,sokhauhao142_153.KH8,sokhauhao142_153.KH9,sokhauhao142_153.KH10,sokhauhao142_153.KH11,sokhauhao142_153.KH12,sodudaunam142_153.MaSoTS,sodudaunam142_153.daunam FROM ({0}) As sokhauhao142_153 left join ({1}) As sodudaunam142_153 on sokhauhao142_153.masots=sodudaunam142_153.masots group by sokhauhao142_153.MaSoTS,sokhauhao142_153.SoHieuTS,sokhauhao142_153.TenTS,sokhauhao142_153.SoHieuTK,sokhauhao142_153.MaTK,sokhauhao142_153.TenTK,sokhauhao142_153.SoNamKH,sokhauhao142_153.NG,sokhauhao142_153.CL,sokhauhao142_153.SHLoai,sokhauhao142_153.TenLoai,sokhauhao142_153.KH1,sokhauhao142_153.KH2,sokhauhao142_153.KH3,sokhauhao142_153.KH4,sokhauhao142_153.KH5,sokhauhao142_153.KH6, sokhauhao142_153.KH7,sokhauhao142_153.KH8,sokhauhao142_153.KH9,sokhauhao142_153.KH10,sokhauhao142_153.KH11,sokhauhao142_153.KH12,sodudaunam142_153.MaSoTS,sodudaunam142_153.daunam ", SoKhauHao142_153, Sodudaunam142_153)
                returnTablename = "SoKhauHao"
            Case 90 ' Sổ CCDC
                Dim MienTru As String = "SELECT * FROM CTCongcudungcu WHERE (Thang=0 AND MaLoai=30)"
                Dim Mientru1 As String = String.Format("SELECT DISTINCT Congcudungcu.Ten AS TenTS, Congcudungcu.SoHieu AS SoHieuTS,NangLuc,Congcudungcu.GhiChu,ThangTang,NamSX,NamSD, LoaiCongcudungcu.SoHieu AS SoHieuTK, LoaiCongcudungcu.MaSo AS MaTK, LoaiCongcudungcu.Ten AS TenTK, HethongTK.SoHieu AS DTCP,Thongso1.NG_NS, Thongso1.NG_TBS, Thongso1.NG_CNK, Thongso1.NG_TD, Thongso1.CL_NS, Thongso1.CL_TBS, Thongso1.CL_CNK, Thongso1.CL_TD,Thongso1.KH_NS, Thongso1.KH_TBS, Thongso1.KH_CNK, Thongso1.KH_TD,LoaiCongcudungcu_1.SoHieu,LoaiCongcudungcu_1.Ten, (MienTru.NG_NS+MienTru.NG_TBS+MienTru.NG_TD+MienTru.NG_CNK-MienTru.CL_NS-MienTru.CL_TBS-MienTru.CL_TD-MienTru.CL_CNK) AS CLDK,congcudungcu.shct,congcudungcu.nct FROM ((LoaiCongcudungcu AS LoaiCongcudungcu_1 RIGHT JOIN ((LoaiCongcudungcu RIGHT JOIN Congcudungcu ON LoaiCongcudungcu.MaSo = Congcudungcu.MaTaiKhoan) RIGHT JOIN Thongso1 ON Congcudungcu.MaSo = Thongso1.MaTS) ON LoaiCongcudungcu_1.MaSo=Congcudungcu.MaLoai) INNER JOIN HethongTK ON Thongso1.MaDTSD=HethongTK.MaSo) LEFT JOIN ({0}) AS MienTru ON Congcudungcu.MaSo=MienTru.MaTS WHERE {1} AND {2} AND Thongso1.Thang = {3} ", _
                                       MienTru, _
                                       WThang("ThangTang", 0, thg_dau), _
                                       "1 = 1", _
                                       ConvertToStrSafe(CThangDB2(thg_dau)))
                returnSQL = String.Format("SELECT  CASE WHEN (mientru1.tents<>'') THEN mientru1.tents ELSE ct.DienGiai END as TenTS,mientru1.SoHieuTS,mientru1.NangLuc,mientru1.GhiChu,mientru1.ThangTang,mientru1.NamSX,mientru1.NamSD,mientru1.SoHieuTK,mientru1.MaTK,mientru1.TenTK,mientru1.DTCP,mientru1.NG_NS,mientru1.NG_TBS,mientru1.NG_CNK,mientru1.NG_TD,mientru1.CL_NS,mientru1.CL_TBS,mientru1.CL_CNK,mientru1.CL_TD,mientru1.KH_NS,mientru1.KH_TBS,mientru1.KH_CNK,mientru1.KH_TD,mientru1.SoHieu,mientru1.Ten,mientru1.CLDK,mientru1.shct,mientru1.nct FROM ({0}) AS mientru1 left join chungtu ct on mientru1.shct=ct.sohieu GROUP BY  mientru1.SoHieuTS, mientru1.NangLuc, mientru1.GhiChu, mientru1.ThangTang, mientru1.NamSX, mientru1.NamSD, mientru1.SoHieuTK, mientru1.MaTK, mientru1.TenTK, mientru1.DTCP, mientru1.NG_NS, mientru1.NG_TBS, mientru1.NG_CNK, mientru1.NG_TD, mientru1.CL_NS, mientru1.CL_TBS, mientru1.CL_CNK, mientru1.CL_TD, mientru1.KH_NS, mientru1.KH_TBS, mientru1.KH_CNK, mientru1.KH_TD, mientru1.SoHieu, mientru1.Ten, mientru1.CLDK, mientru1.shct, mientru1.nct,CASE WHEN (mientru1.tents<>'') THEN mientru1.tents ELSE ct.DienGiai END", Mientru1)
                returnTablename = "SoDuDauCuoiKy"
        End Select
        Return New String() {returnSQL, returnTablename}
    End Function
    Private Sub TinhSoLieuBaoCao()
        Dim thg_dau, thg_cuoi As Integer
        ' Xác định các tháng cần tính số liệu
        Select Case baocao
            Case 89, 90
                thg_dau = CboThang(0).SelectedValue
                thg_cuoi = CboThang(1).SelectedValue
            Case Else : Exit Sub
        End Select
        If baocao = 89 Or baocao = 90 Then
            ' Tính giá trị tài sản cho các tháng cần lấy số liệu
            HienThongBao("Cập nhật giá trị công cụ dụng cụ ...", 1)
            For chi_so As Integer = CThangDB2(thg_dau) To CThangDB2(thg_cuoi)
                If chi_so > 0 Then
                    If Not SoLieu(chi_so - 1) Then
                        Me.Cursor = Cursors.WaitCursor
                        CapNhatGiaTriCongcudungcu(chi_so, GauGe)
                        SoLieu(chi_so - 1) = True
                        Me.Cursor = Cursors.Default
                    End If
                End If
            Next
        End If
        HienThongBao("", 1)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmSocongcu_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub

End Class
