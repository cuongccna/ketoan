Imports System
Imports System.Text
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmIntoanboso
    Dim tdau, th, nn, tcuoi As Integer
    Dim SoLieu(11) As Boolean

    Dim Mientru As String
    Dim SoDuDauCuoiKy As String
    Dim QChitiet As String
    Dim SoKhauHao As String
    Dim QNhatKy As String
    Dim QLuyKe As String
    Dim MienTru1 As String
    Dim Qsocai As String
    Dim QTongHopCT As String
    Dim QCdt As String
    Dim Qtinhluong As String
    Dim Dautanggiamcuoi As String
    Dim QDuPhong As String
    Dim QVAT As String


    Private Sub Chk_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Chk_9.CheckStateChanged, _Chk_8.CheckStateChanged, _Chk_7.CheckStateChanged, _Chk_6.CheckStateChanged, _Chk_5.CheckStateChanged, _Chk_4.CheckStateChanged, _Chk_3.CheckStateChanged, _Chk_2.CheckStateChanged, _Chk_1.CheckStateChanged, _Chk_0.CheckStateChanged
        If Chk(3).CheckState Then
            Opt(0).Enabled = True
            Opt(1).Enabled = True
        Else
            Opt(0).Enabled = False
            Opt(1).Enabled = False
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_0.Click, _Command_1.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        th = Index
        Hide()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmIntoanboso_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.T
                    Command(1).Focus()
                    'Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.V
                    Command(0).Focus()
                    ' Command_ClickEvent(Command(0), New EventArgs())
            End Select
        End If
        If (Shift And 2) > 0 And eventArgs.KeyCode = Keys.P Then
            frmMain.mnHT_Click(frmMain.mnHT, New EventArgs())
        End If
        If eventArgs.KeyCode = Keys.Escape Then
            th = 0 : Hide()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub thuchien()
        Dim Ngay(1) As Date
        Dim ten As String = String.Empty
        Dim taikhoan As New ClsTaikhoan
        Dim doiung As New ClsTaikhoan
        Dim tg As String = String.Empty
        GetMonth.GetMonth("In toàn bộ sổ kế toán:", tdau, tcuoi)
        If tdau + tcuoi = 0 Then GoTo Xong
        ShowDialog()
        rptFrom.ReportDestination = 0
        Dim a As String = String.Empty
        Dim kq1 As Boolean
        Dim rs_tk As DataTable
        Dim numberloop, thutudong As Integer
        Dim lan, StopPrint As Boolean
        If th Then
            Ngay(0) = DateSerial(pNamTC, 1, 1)
            Ngay(1) = DateSerial(pNamTC, 12, 31)
            '****************************************** Kiểm tra sổ quỹ ***********************************
            taikhoan.InitTaikhoanSohieu("111")
            If Not InSocaiTk(taikhoan, 0, 0, Ngay(0), Ngay(1), True, doiung.sohieu, 0, 0) Then GoTo Xong
            '****************************************** Kiểm tra luỹ kế ***********************************
            If Not KTAmHang(0, "0", 0, 1, 12) Then GoTo Xong
            '****************************************** Kiểm tra sổ tiền gửi ***********************************
            taikhoan.InitTaikhoanSohieu("112")
            doiung.InitTaikhoanMaSo(0)
            If Not KTAmNganHang(taikhoan, 0, 0, Ngay(0), Ngay(1), False, doiung.sohieu, 0) Then GoTo Xong
            For i As Integer = tdau To tcuoi
                Dim MienTruxx As String = "SELECT * FROM CTTaiSan WHERE (Thang=0 AND MaLoai=30)"
                Dim SoDuDauCuoiKyxx As String = String.Format("SELECT DISTINCT TaiSan.Ten AS TenTS, TaiSan.SoHieu AS SoHieuTS,NangLuc,TaiSan.GhiChu,ThangTang,NamSX,NamSD, LoaiTaiSan.SoHieu AS SoHieuTK, LoaiTaiSan.MaSo AS MaTK, LoaiTaiSan.Ten AS TenTK, HethongTK.SoHieu AS DTCP,DTQLy.Ten AS DTQL,ThongSo.NG_NS, ThongSo.NG_TBS, ThongSo.NG_CNK, ThongSo.NG_TD, ThongSo.CL_NS, ThongSo.CL_TBS, ThongSo.CL_CNK, ThongSo.CL_TD,ThongSo.KH_NS, ThongSo.KH_TBS, ThongSo.KH_CNK, ThongSo.KH_TD,LoaiTaiSan_1.SoHieu,LoaiTaiSan_1.Ten, (MienTru.NG_NS+MienTru.NG_TBS+MienTru.NG_TD+MienTru.NG_CNK-MienTru.CL_NS-MienTru.CL_TBS-MienTru.CL_TD-MienTru.CL_CNK) AS CLDK FROM (((LoaiTaiSan AS LoaiTaiSan_1 RIGHT JOIN ((LoaiTaiSan RIGHT JOIN TaiSan ON LoaiTaiSan.MaSo = TaiSan.Maloai) RIGHT JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS) ON LoaiTaiSan_1.MaSo=TaiSan.manhom) INNER JOIN DTQLy ON ThongSo.MaDTQL=DTQLy.MaSo) INNER JOIN HethongTK ON ThongSo.MaDTSD=HethongTK.MaSo) LEFT JOIN ({0}) AS MienTru ON TaiSan.MaSo=MienTru.MaTS WHERE ThongSo.Thang = {1} ORDER BY TaiSan.SoHieu", _
                                            MienTruxx, _
                                            ConvertToStrSafe(CThangDB2(i)))
                rptFrom.InitForm("SOTSCD.RPT", SoDuDauCuoiKyxx, "SoDuDauCuoiKy")
                ten = String.Format("Tháng {0}{1} - ", (IIf(i < 10, "0", String.Empty)), ConvertToStrSafe(i))
                If Chk(0).CheckState Then
                    SetRptInfo()
                    If InNhatKy(i, i, 0, 0, Ngay(0), Ngay(1), nn) Then
                        HienThongBao(String.Format("{0}{1}", ten, Chk(0).Text), 1)
                        rptFrom.ReportTitle = Chk(0).Text
                        InBaoCaoRPT()
                    End If
                End If
                If Chk(1).CheckState Or Chk(2).CheckState Or Chk(7).CheckState Then
                    doiung.InitTaikhoanMaSo(0)
                    Ngay(0) = DateSerial(pNamTC, i, 1)
                    Ngay(1) = NgayCuoiThang(pNamTC, i)
                    If Chk(7).CheckState Then
                        SetRptInfo()
                        taikhoan.InitTaikhoanSohieu("112")
                        If InSoChitiet(taikhoan, 0, 0, Ngay(0), Ngay(1), False, doiung.sohieu, 0) Then
                            HienThongBao(String.Format("{0}{1}", ten, Chk(7).Text), 1)
                            rptFrom.ReportTitle = Chk(7).Text
                            InBaoCaoRPT()
                        End If
                    End If
                    If Chk(1).CheckState Then
                        SetRptInfo()
                        taikhoan.InitTaikhoanSohieu("111")
                        If InSocaiTk(taikhoan, 0, 0, Ngay(0), Ngay(1), True, doiung.sohieu, 0, 0, 0, 0, 0, 0, 0, False, 1) Then
                            HienThongBao(String.Format("{0}{1}", ten, Chk(1).Text), 1)
                            rptFrom.ReportTitle = Chk(1).Text
                            InBaoCaoRPT()
                        End If
                    End If
                    If Chk(2).CheckState Then
                        SetRptInfo()
                        rs_tk = ExecSQLReturnDT("SELECT MaSo, SoHieu, Ten FROM HethongTK WHERE MaTC = MaSo AND Loai > 0 ORDER BY SoHieu")
                        StopPrint = False
                        numberloop = 1
                        thutudong = MessageBox.Show(Ngonngu("Có in thứ tự dòng theo nhật ký không?", "Do you print line with the diary?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        Dim rs_tkIndex As Integer = 0
                        Do While rs_tkIndex < rs_tk.Rows.Count
                            Dim rs_tkItem As DataRow = rs_tk.Rows(rs_tkIndex)
                            rs_tkIndex += 1 ' C15 Rs LOOP CONTROL And (Not StopPrint)
                            taikhoan.InitTaikhoanMaSo(rs_tkItem("MaSo"))
                            If (pSoKT Mod 10 >= 1) Or (pSoKT Mod 1000 >= 100) Then
                                kq1 = InSocaiTk(taikhoan, tdau, tcuoi, Ngay(0), Ngay(1), False, "", 0, 0, nn, 0, 0, 0, thutudong, lan)
                                lan = True
                            Else
                                kq1 = InSocaiTk2(taikhoan, tdau, tcuoi, False, "", 0, nn)
                            End If
                            a = Strings.Mid(rs_tkItem("SoHieu"), 4)
                            If kq1 And (a = "" Or (Strings.Left(rs_tkItem("SoHieu"), 3) = "333" And Strings.Mid(rs_tkItem("SoHieu"), 5) = "")) Then
                                HienThongBao(String.Format("{0}{1}", ten, (String.Format("{0} - {1}", ConvertToStrSafe(rs_tkItem("SoHieu")), rs_tkItem("ten")))), 1)
                                rptFrom.ReportTitle = Chk(2).Text
                                InBaoCaoRPT()
                            End If
                            'rs_tk.MoveNext()
                        Loop
                        lan = False
                        ''rs_tk.Close()
                        rs_tk = Nothing
                    End If
                End If
                If Chk(3).CheckState Then
                    SetRptInfo()
                    If Opt(0).Checked Then
                        If BKChiTietRPT(GauGe, "154", NgayDauThang(pNamTC, i), NgayCuoiThang(pNamTC, i)) Then
                            HienThongBao(String.Format("{0}{1}", ten, Chk(3).Text), 1) : rptFrom.ReportTitle = Chk(3).Text : InBaoCaoRPT()
                        End If
                        If BKChiTietRPT(GauGe, "142", NgayDauThang(pNamTC, i), NgayCuoiThang(pNamTC, i)) Then
                            HienThongBao(String.Format("{0}{1}", ten, Chk(3).Text), 1) : rptFrom.ReportTitle = Chk(3).Text : InBaoCaoRPT()
                        End If
                        If BKChiTietRPT(GauGe, "242", NgayDauThang(pNamTC, i), NgayCuoiThang(pNamTC, i)) Then
                            HienThongBao(String.Format("{0}{1}", ten, Chk(3).Text), 1) : rptFrom.ReportTitle = Chk(3).Text : InBaoCaoRPT()
                        End If
                        If BKChiTietRPT(GauGe, "631", NgayDauThang(pNamTC, i), NgayCuoiThang(pNamTC, i)) Then
                            HienThongBao(String.Format("{0}{1}", ten, Chk(3).Text), 1) : rptFrom.ReportTitle = Chk(3).Text : InBaoCaoRPT()
                        End If
                        If BKChiTietRPT(GauGe, "632", NgayDauThang(pNamTC, i), NgayCuoiThang(pNamTC, i)) Then
                            HienThongBao(String.Format("{0}{1}", ten, Chk(3).Text), 1) : rptFrom.ReportTitle = Chk(3).Text : InBaoCaoRPT()
                        End If
                        If BKChiTietRPT(GauGe, "642", NgayDauThang(pNamTC, i), NgayCuoiThang(pNamTC, i)) Then
                            HienThongBao(String.Format("{0}{1}", ten, Chk(3).Text), 1) : rptFrom.ReportTitle = Chk(3).Text : InBaoCaoRPT()
                        End If
                    ElseIf Opt(1).Checked Then
                        If BKChiTietRPT(GauGe, "154", NgayDauThang(pNamTC, i), NgayCuoiThang(pNamTC, i)) Then
                            HienThongBao(String.Format("{0}{1}", ten, Chk(3).Text), 1) : rptFrom.ReportTitle = Chk(3).Text : InBaoCaoRPT()
                        End If
                        If BKChiTietRPT(GauGe, "621", NgayDauThang(pNamTC, i), NgayCuoiThang(pNamTC, i)) Then
                            HienThongBao(String.Format("{0}{1}", ten, Chk(3).Text), 1) : rptFrom.ReportTitle = Chk(3).Text : InBaoCaoRPT()
                        End If
                        If BKChiTietRPT(GauGe, "622", NgayDauThang(pNamTC, i), NgayCuoiThang(pNamTC, i)) Then
                            HienThongBao(String.Format("{0}{1}", ten, Chk(3).Text), 1) : rptFrom.ReportTitle = Chk(3).Text : InBaoCaoRPT()
                        End If
                        If BKChiTietRPT(GauGe, "623", NgayDauThang(pNamTC, i), NgayCuoiThang(pNamTC, i)) Then
                            HienThongBao(String.Format("{0}{1}", ten, Chk(3).Text), 1) : rptFrom.ReportTitle = Chk(3).Text : InBaoCaoRPT()
                        End If
                        If BKChiTietRPT(GauGe, "627", NgayDauThang(pNamTC, i), NgayCuoiThang(pNamTC, i)) Then
                            HienThongBao(String.Format("{0}{1}", ten, Chk(3).Text), 1) : rptFrom.ReportTitle = Chk(3).Text : InBaoCaoRPT()
                        End If
                    End If
                End If
                If Chk(4).CheckState Then
                    SetRptInfo()
                    InTK(2, i, i, 0)
                    HienThongBao(String.Format("{0}{1}", ten, Chk(4).Text), 1)
                    rptFrom.ReportTitle = Chk(4).Text
                    InBaoCaoRPT()
                End If
                If Chk(5).CheckState Then
                    SetRptInfo()
                    HienThongBao(String.Format("{0}{1}", ten, Chk(6).Text), 1)
                    rptFrom.ReportTitle = Chk(6).Text
                    tg = ThoiGianTheoThang(i, i)
                    ' Chuẩn bị số liệu
                    HienThongBao("Cập nhật giá trị tài sản ...", 1)
                    For chi_so As Integer = i To i
                        If chi_so > 0 Then
                            If Not SoLieu(chi_so - 1) Then
                                Me.Cursor = Cursors.WaitCursor
                                CapNhatGiaTriTaiSan(chi_so, GauGe)
                                SoLieu(chi_so - 1) = True
                                Me.Cursor = Cursors.Default
                            End If
                        End If
                    Next
                    ' Tạo báo cáo
                    Dim MienTru As String = "SELECT * FROM CTTaiSan WHERE (Thang=0 AND MaLoai=30)"
                    Dim SoDuDauCuoiKy As String = String.Format("SELECT DISTINCT TaiSan.Ten AS TenTS, TaiSan.SoHieu AS SoHieuTS,NangLuc,TaiSan.GhiChu,ThangTang,NamSX,NamSD, LoaiTaiSan.SoHieu AS SoHieuTK, LoaiTaiSan.MaSo AS MaTK, LoaiTaiSan.Ten AS TenTK, HethongTK.SoHieu AS DTCP,DTQLy.Ten AS DTQL,ThongSo.NG_NS, ThongSo.NG_TBS, ThongSo.NG_CNK, ThongSo.NG_TD, ThongSo.CL_NS, ThongSo.CL_TBS, ThongSo.CL_CNK, ThongSo.CL_TD,ThongSo.KH_NS, ThongSo.KH_TBS, ThongSo.KH_CNK, ThongSo.KH_TD,LoaiTaiSan_1.SoHieu,LoaiTaiSan_1.Ten, (MienTru.NG_NS+MienTru.NG_TBS+MienTru.NG_TD+MienTru.NG_CNK-MienTru.CL_NS-MienTru.CL_TBS-MienTru.CL_TD-MienTru.CL_CNK) AS CLDK FROM (((LoaiTaiSan AS LoaiTaiSan_1 RIGHT JOIN ((LoaiTaiSan RIGHT JOIN TaiSan ON LoaiTaiSan.MaSo = TaiSan.Maloai) RIGHT JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS) ON LoaiTaiSan_1.MaSo=TaiSan.manhom) INNER JOIN DTQLy ON ThongSo.MaDTQL=DTQLy.MaSo) INNER JOIN HethongTK ON ThongSo.MaDTSD=HethongTK.MaSo) LEFT JOIN ({0}) AS MienTru ON TaiSan.MaSo=MienTru.MaTS WHERE {1} AND {2} AND ThongSo.Thang = {3} ORDER BY TaiSan.SoHieu", _
                                                MienTru, _
                                                WThang("ThangTang", 0, i), _
                                                WThang2("ThangGiam", i, 0), _
                                                ConvertToStrSafe(CThangDB2(i)))
                    ' Tên File dữ liệu và báo cáo
                    rptFrom.InitForm("SOTSCD.RPT", SoDuDauCuoiKy, "SoDuDauCuoiKy")
                    RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
                    ' Công thức
                    rptFrom.SetFormulas("TenBaoCao", "'Sổ tài sản cố định'")
                    rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", tg))
                    If ConvertToDblSafe(GetSelectValue("SELECT count(*)as f1 FROM sodudaucuoiky")) > 0 Then InBaoCaoRPT()
                End If
                If Chk(6).CheckState Then
                    SetRptInfo()
                    HienThongBao(String.Format("{0}{1}", ten, Chk(6).Text), 1)
                    rptFrom.ReportTitle = Chk(6).Text
                    tg = ThoiGianTheoThang(i, i)
                    ' Chuẩn bị số liệu
                    HienThongBao("Cập nhật giá trị công cụ dụng cụ ...", 1)
                    For chi_so As Integer = i To i
                        If chi_so > 0 Then
                            If Not SoLieu(chi_so - 1) Then
                                Me.Cursor = Cursors.WaitCursor
                                CapNhatGiaTriCongcudungcu(chi_so, GauGe)
                                SoLieu(chi_so - 1) = True
                                Me.Cursor = Cursors.Default
                            End If
                        End If
                    Next
                    ' Tạo báo cáo
                    Dim MienTru As String = "SELECT * FROM CTCongcudungcu WHERE (Thang=0 AND MaLoai=30)"
                    Dim MienTru1 As String = String.Format("SELECT DISTINCT Congcudungcu.Ten AS TenTS, Congcudungcu.SoHieu AS SoHieuTS,NangLuc,Congcudungcu.GhiChu,ThangTang,NamSX,NamSD, LoaiCongcudungcu.SoHieu AS SoHieuTK, LoaiCongcudungcu.MaSo AS MaTK, LoaiCongcudungcu.Ten AS TenTK, HethongTK.SoHieu AS DTCP,Thongso1.NG_NS, Thongso1.NG_TBS, Thongso1.NG_CNK, Thongso1.NG_TD, Thongso1.CL_NS, Thongso1.CL_TBS, Thongso1.CL_CNK, Thongso1.CL_TD,Thongso1.KH_NS, Thongso1.KH_TBS, Thongso1.KH_CNK, Thongso1.KH_TD,LoaiCongcudungcu_1.SoHieu,LoaiCongcudungcu_1.Ten, (MienTru.NG_NS+MienTru.NG_TBS+MienTru.NG_TD+MienTru.NG_CNK-MienTru.CL_NS-MienTru.CL_TBS-MienTru.CL_TD-MienTru.CL_CNK) AS CLDK,congcudungcu.shct,congcudungcu.nct FROM ((LoaiCongcudungcu AS LoaiCongcudungcu_1 RIGHT JOIN ((LoaiCongcudungcu RIGHT JOIN Congcudungcu ON LoaiCongcudungcu.MaSo = Congcudungcu.MaTaiKhoan) RIGHT JOIN Thongso1 ON Congcudungcu.MaSo = Thongso1.MaTS) ON LoaiCongcudungcu_1.MaSo=Congcudungcu.MaLoai) INNER JOIN HethongTK ON Thongso1.MaDTSD=HethongTK.MaSo) LEFT JOIN ({0}) MienTru ON Congcudungcu.MaSo=MienTru.MaTS WHERE {1} AND {2} AND Thongso1.Thang = {3} ORDER BY Congcudungcu.SoHieu", _
                                                 MienTru, _
                                                 WThang("ThangTang", 0, i), _
                                                 WThang2("ThangGiam", i, 0), _
                                                 ConvertToStrSafe(CThangDB2(i)))
                    Dim SoDuDauCuoiKy As String = String.Format("SELECT CASE WHEN mt.tents<>'' THEN mt.tents ELSE ct.DienGiai END as TenTS,mt.SoHieuTS,mt.NangLuc,mt.GhiChu,mt.ThangTang,mt.NamSX,mt.NamSD,mt.SoHieuTK,mt.MaTK,mt.TenTK,mt.DTCP,mt.NG_NS,mt.NG_TBS,mt.NG_CNK,mt.NG_TD,mt.CL_NS,mt.CL_TBS,mt.CL_CNK,mt.CL_TD,mt.KH_NS,mt.KH_TBS,mt.KH_CNK,mt.KH_TD,mt.SoHieu,mt.Ten,mt.CLDK,mt.shct,mt.nct FROM   ({0}) mientru1 mt left join chungtu ct on mt.shct=ct.sohieu GROUP BY  mt.SoHieuTS, mt.NangLuc, mt.GhiChu, mt.ThangTang, mt.NamSX, mt.NamSD, mt.SoHieuTK, mt.MaTK, mt.TenTK, mt.DTCP, mt.NG_NS, mt.NG_TBS, mt.NG_CNK, mt.NG_TD, mt.CL_NS, mt.CL_TBS, mt.CL_CNK, mt.CL_TD, mt.KH_NS, mt.KH_TBS, mt.KH_CNK, mt.KH_TD, mt.SoHieu, mt.Ten, mt.CLDK, mt.shct, mt.nct, CASE WHEN (mt.tents<>'') THEN mt.tents ELSE ct.DienGiai END", MienTru1)
                    ' Tên File dữ liệu và báo cáo
                    rptFrom.InitForm("SOTSCD.RPT", SoDuDauCuoiKy, "SoDuDauCuoiKy")

                    RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
                    ' Công thức
                    rptFrom.SetFormulas("TenBaoCao", "'Sổ công cụ dụng cụ'")
                    rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", tg))
                    If ConvertToDblSafe(GetSelectValue("SELECT count(*) as f1 FROM sodudaucuoiky")) > 0 Then InBaoCaoRPT()
                End If
                If Chk(8).CheckState Then
                    SetRptInfo()
                    HienThongBao(String.Format("{0}{1}", ten, Chk(8).Text), 1)
                    rptFrom.ReportTitle = Chk(8).Text
                    If InLuyKe(GauGe, 0, "", 0, i, i, True, 0, 0, False) Then InBaoCaoRPT()
                End If
                If Chk(9).CheckState Then
                    SetRptInfo()
                    HienThongBao(String.Format("{0}{1}", ten, Chk(9).Text), 1)
                    rptFrom.ReportTitle = Chk(9).Text
                    ' If Bangluong(i, i) Then InBaoCaoRPT()
                End If
            Next
        End If
Xong:
        rptFrom.ReportDestination = 1
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="cap"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ct"></param>
    ''' <remarks></remarks>
    Private Sub InTK(ByRef cap As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ct As Integer)
        Dim st As String = String.Empty
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        Dim sqlcx As New StringBuilder
        Dim sqlnx As New StringBuilder
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            If sqln.Length = 0 Then
                sqln.Append(String.Format("No_{0}", i))
            Else
                sqln.Append(String.Format(" + No_{0}", i))
            End If

            If sqlc.Length = 0 Then
                sqlc.Append(String.Format("Co_{0}", i))
            Else
                sqlc.Append(String.Format(" + Co_{0}", i))
            End If
        Next
        For i As Integer = 1 To CThangDB2(tcuoi)
            st = ConvertToStrSafe(i)
            sqlnx.Append(String.Format(" + No_{0}", st))
            sqlcx.Append(String.Format(" + Co_{0}", st))
        Next
        st = ConvertToStrSafe(CThangDB2(ThangTruoc(tdau)))
        'SetSQL("QTongHopCT", "SELECT DISTINCT SoHieu, (Cap) AS FirstOfCap, (Ten" & (iif(pnn > 0, "E", String.Empty)) & ") AS FirstOfTen, (Kieu) AS FirstOfKieu, (Loai) AS FirstOfLoai, (MaTC = MaSo OR MaTC = 0) AS FirstOfChuanLa, (TKCon) AS FirstOfTKCon, (CapDuoi) AS CD," & " Sum(DuNo_" & st & ") AS DkNo, Sum(DuCo_" & st & ") AS DkCo, Sum(" & sqln.ToString() & ") AS PsNo, Sum(" & sqlc.ToString() & ") AS PsCo, Sum(" & sqlnx.ToString() & ") AS PsNoX, Sum(" & sqlcx.ToString() & ") AS PsCoX, Sum(HeThongTK.DuNo_" & ConvertToStrSafe(CThangDB2(tcuoi)) & ") AS CkNo, Sum(HeThongTK.DuCo_" & ConvertToStrSafe(CThangDB2(tcuoi)) & ") AS CkCo" & " FROM HeThongTK WHERE Cap<=" & cap & (iif(ct = 0, " AND (DuNo_" & st & "<>0 OR DuCo_" & st & "<>0 OR (" & sqln.ToString() & ")<>0 OR (" & sqlc.ToString() & ")<>0)", String.Empty)) & " GROUP BY SoHieu Having ((((Loai))>0) AND ((((Cap > 0))) OR (((MaTC > 0 AND MaTC <> MaSo))))) ORDER BY SoHieu")

        Dim QTongHopCT As String = String.Format("SELECT DISTINCT SoHieu, (Cap) AS FirstOfCap, (Ten{0}) AS FirstOfTen, (Kieu) AS FirstOfKieu, (Loai) AS FirstOfLoai, (MaTC = MaSo OR MaTC = 0) AS FirstOfChuanLa, (TKCon) AS FirstOfTKCon, (CapDuoi) AS CD, Sum(DuNo_{1}) AS DkNo, Sum(DuCo_{1}) AS DkCo, Sum({2}) AS PsNo, Sum({3}) AS PsCo, Sum({4}) AS PsNoX, Sum({5}) AS PsCoX, Sum(HeThongTK.DuNo_{6}) AS CkNo, Sum(HeThongTK.DuCo_{6}) AS CkCo FROM HeThongTK WHERE Cap<={7}{8} GROUP BY SoHieu Having ((((Loai))>0) AND ((((Cap > 0))) OR (((MaTC > 0 AND MaTC <> MaSo))))) ORDER BY SoHieu", _
                                       (IIf(pnn > 0, "E", String.Empty)), _
                                       st, _
                                       sqln, _
                                       sqlc, _
                                       sqlnx, _
                                       sqlcx, _
                                       ConvertToStrSafe(CThangDB2(tcuoi)), _
                                       cap, _
                                       (IIf(ct = 0, String.Format(" AND (DuNo_{0}<>0 OR DuCo_{0}<>0 OR ({1})<>0 OR ({2})<>0)", st, sqln, sqlc), String.Empty)))

        XDCapTK("")

        rptFrom.InitForm("THSDCT.RPT", QTongHopCT, "QTongHopCT")

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
    End Sub
    Function KTAmHang(ByRef mkho As Integer, ByRef shtk As String, ByRef mloai As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer, Optional ByRef T As Boolean = True, Optional ByRef nn As Integer = 0) As Boolean
        Dim result As Boolean = False
        Dim sql, st As String
        Dim sqltx2 As New StringBuilder
        Dim sqltn2 As New StringBuilder
        Dim sqltx As New StringBuilder
        Dim sqltn As New StringBuilder
        Dim sqllx As New StringBuilder
        Dim sqlln As New StringBuilder
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            st = ConvertToStrSafe(i)
            sqlln.Append(" + TonKho.Luong_Nhap_" & st)
            sqllx.Append(" + TonKho.Luong_Xuat_" & st)
            sqltn.Append(" + TonKho.Tien_Nhap_" & st)
            sqltx.Append(" + TonKho.Tien_Xuat_" & st)
            sqltn2.Append(" + TonKho.USDTien_Nhap_" & st)
            sqltx2.Append(" + TonKho.USDTien_Xuat_" & st)
        Next
        st = ConvertToStrSafe(CThangDB2(tcuoi))
        XDTyLeQD(0)
        If mkho > 0 Then
            sql = "SELECT DISTINCT (HeThongTK.SoHieu) AS SHTK, (HeThongTK.Ten" & (IIf(pnn > 0, "E", String.Empty)) & ") AS TenTK, (PhanLoaiVattu.PLCha) AS PLCha3," & " (PhanLoaiVattu.SoHieu) AS SHPL3, (PhanLoaiVattu.TenPhanLoai) AS TenPL3, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, Sum(TonKho.Tien_" & CThangDB2(ThangTruoc(tdau)) & ") AS DkTien," & " Sum(TonKho.Luong_" & CThangDB2(ThangTruoc(tdau)) & ") AS DkLuong, Sum(" & sqltn.ToString() & ") AS TienNhap, Sum(" & sqlln.ToString() & ") AS LuongNhap, Sum(" & sqltx.ToString() & ") AS TienXuat," & " Sum(" & sqllx.ToString() & ") AS LuongXuat, Sum(TonKho.Luong_" & st & ") AS CkLuong, Sum(TonKho.Tien_" & st & ") AS CkTien" & (IIf(pGiaUSD > 0, ", Sum(TonKho.USDTien_" & CThangDB2(ThangTruoc(tdau)) & ") AS DkUSD, Sum(" & sqltn2.ToString() & ") AS TienNhapUSD, Sum(" & sqltx2.ToString() & ") AS TienXuatUSD, Sum(TonKho.USDTien_" & st & ") AS CkUSD", String.Empty)) & " FROM HeThongTK RIGHT JOIN ((PhanLoaiVattu RIGHT JOIN Vattu ON PhanLoaiVattu.MaSo = Vattu.MaPhanLoai) RIGHT JOIN TonKho ON Vattu.MaSo = TonKho.MaVatTu) ON HeThongTK.MaSo = TonKho.MaTaiKhoan" & " GROUP BY Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, HethongTK.SoHieu " & (IIf(mkho > 0, ", TonKho.MaSoKho", String.Empty)) & (IIf(mloai > 0, ", PhanLoaiVattu.SoHieu", String.Empty)) & " Having (Sum(TonKho.Luong_" & st & ")<>0 OR Sum(TonKho.Tien_" & st & ")<>0 OR SUM(" & sqlln.ToString() & ")<>0 OR SUM(" & sqltn.ToString() & ")<>0 OR SUM(" & sqllx.ToString() & ")<>0 OR SUM(" & sqltx.ToString() & ")<>0" & (IIf(pGiaUSD > 0, " OR Sum(TonKho.USDTien_" & st & ")<>0 OR SUM(" & sqltn2.ToString() & ")<>0 OR SUM(" & sqltx2.ToString() & ")<>0)", ")")) & (IIf(mkho <> 0, " AND TonKho.MaSoKho = " & mkho, String.Empty)) & (IIf(shtk.Length > 0, " AND HethongTK.SoHieu LIKE '" & shtk & "%'", String.Empty)) & (IIf(mloai <> 0, " AND PhanLoaiVattu.SoHieu LIKE '" & MaSo2SoHieu(mloai, "PhanLoaiVattu") & "%'", String.Empty)) & " ORDER BY Vattu.SoHieu"
        Else
            ExecSQLNonQuery("DELETE  FROM BaoCaoCP2")
            ExecSQLNonQuery("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,MaCha,BC_ID,MK,Kq1,Kq2) SELECT (MaSo),(ConvertToStrSafe(MaSo)),MaTKNo,MaVattu,MaKho,Sum(SoPS2No),Sum(SoPS) " & "FROM ChungTu WHERE MaLoai=4 AND MaTKNo=MaTKCo AND " & WThang("ThangCT", tdau, tcuoi) & " GROUP BY MaKho,MaTKNo,MaVattu")
            sql = "SELECT DISTINCT (HeThongTK.SoHieu) AS SHTK, (HeThongTK.Ten" & (IIf(pnn > 0, "E", String.Empty)) & ") AS TenTK, (PhanLoaiVattu.PLCha) AS PLCha3," & " (PhanLoaiVattu.SoHieu) AS SHPL3, (PhanLoaiVattu.TenPhanLoai) AS TenPL3, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, Sum(TonKho.Tien_" & CThangDB2(ThangTruoc(tdau)) & ") AS DkTien," & " Sum(TonKho.Luong_" & CThangDB2(ThangTruoc(tdau)) & ") AS DkLuong, Sum(" & sqltn.ToString() & "- CASE WHEN (isnull(Kq2)) THEN 0 ELSE Kq2 END) AS TienNhap, Sum(" & sqlln.ToString() & "- CASE WHEN (isnull(Kq1)) THEN 0 ELSE Kq1 END) AS LuongNhap, Sum(" & sqltx.ToString() & "- CASE WHEN (isnull(Kq2)) THEN 0 ELSE Kq2 END) AS TienXuat," & " Sum(" & sqllx.ToString() & "- CASE WHEN (isnull(Kq1)) THEN 0 ELSE Kq1 END) AS LuongXuat, Sum(TonKho.Luong_" & st & ") AS CkLuong, Sum(TonKho.Tien_" & st & ") AS CkTien" & (IIf(pGiaUSD > 0, ", Sum(TonKho.USDTien_" & CThangDB2(ThangTruoc(tdau)) & ") AS DkUSD, Sum(" & sqltn2.ToString() & ") AS TienNhapUSD, Sum(" & sqltx2.ToString() & ") AS TienXuatUSD, Sum(TonKho.USDTien_" & st & ") AS CkUSD", String.Empty)) & " FROM (HeThongTK RIGHT JOIN ((PhanLoaiVattu RIGHT JOIN Vattu ON PhanLoaiVattu.MaSo = Vattu.MaPhanLoai) RIGHT JOIN TonKho ON Vattu.MaSo = TonKho.MaVatTu) ON HeThongTK.MaSo = TonKho.MaTaiKhoan) LEFT JOIN BaoCaoCP2 ON TonKho.MaSoKho=BaoCaoCP2.MK AND TonKho.MaTaiKhoan=BaoCaoCP2.MaCha AND TonKho.MaVattu=BaoCaoCP2.BC_ID" & " GROUP BY Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, HethongTK.SoHieu " & (IIf(mloai > 0, ", PhanLoaiVattu.SoHieu", String.Empty)) & " Having Sum(TonKho.Luong_" & st & ")<>0 OR Sum(TonKho.Tien_" & st & ")<>0 OR SUM(" & sqlln.ToString() & ")<>0 OR SUM(" & sqltn.ToString() & ")<>0 OR SUM(" & sqllx.ToString() & ")<>0 OR SUM(" & sqltx.ToString() & ")<>0" & (IIf(pGiaUSD > 0, " OR Sum(TonKho.USDTien_" & st & ")<>0 OR SUM(" & sqltn2.ToString() & ")<>0 OR SUM(" & sqltx2.ToString() & ")<>0", String.Empty)) & (IIf(shtk.Length > 0, " AND HethongTK.SoHieu LIKE '" & shtk & "%'", String.Empty)) & (IIf(mloai <> 0, " AND PhanLoaiVattu.SoHieu LIKE '" & MaSo2SoHieu(mloai, "PhanLoaiVattu") & "%'", String.Empty)) & " ORDER BY Vattu.SoHieu"
        End If
        QChitiet = (sql)
        sql = "SELECT QChitiet.*,PhanLoaiVattu.SoHieu AS SHPL2,TenPhanLoai AS TenPL2,PhanLoaiVattu.PLCha AS PLCha2 FROM (" + QChitiet + ") AS  QChitiet LEFT JOIN PhanLoaiVattu ON QChitiet.PLCha3=PhanLoaiVattu.MaSo"
        QDuPhong = (sql)
        sql = "SELECT QDuPhong.*,PhanLoaiVattu.SoHieu AS SHPL1,TenPhanLoai AS TenPL1 FROM (" + QDuPhong + ") AS   QDuPhong  LEFT JOIN PhanLoaiVattu ON QDuPhong.PLCha2=PhanLoaiVattu.MaSo ORDER BY QDuPhong.Sohieu"
        QLuyKe = (sql)
        result = True
        '************************************ Kiểm tra âm hàng **********************************************
        Dim str As String = String.Empty
        Dim rs As DataTable = ExecSQLReturnDT("SELECT DISTINCT dkluong,ckluong,sohieu FROM (" + QLuyKe + ") AS    QLuyKe ORDER BY sohieu")
        Dim rsIndex As Integer = 0
        While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            If rsItem("dkluong") < 0 Or rsItem("ckluong") < 0 Then
                str = ConvertToDblSafe(str) + rsItem("SoHieu") + ", "
            End If
            ''rs.MoveNext()
        End While
        If str <> "" Then
            str = Strings.Left(str, str.Length - 2)
            If MessageBox.Show(Ngonngu("Âm hàng tại vật tư có số hiệu ", "Goods less then zero by ") & str & "!" & Environment.NewLine & Ngonngu("Tiếp tục ?", "Continue ?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.No Then result = False
        End If
        '************************************ Hết kiểm tra ****************************************************
        Return result
    End Function
    Public Function KTAmNganHang(ByRef taikhoan As ClsTaikhoan, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef thongbao As Boolean, ByRef doiung As String, ByRef VV As Integer, Optional ByRef loai As Integer = 0, Optional ByRef nn As Integer = 0, Optional ByRef mdt1 As Integer = 0, Optional ByRef mdt2 As Integer = 0, Optional ByRef mdt3 As Integer = 0) As Boolean
        Dim result As Boolean = False
        Dim dkc, dkn, dknt As Double
        Dim sql As String
        Dim ps As Boolean = taikhoan.TkCoPSN(ndau, ncuoi)
        Dim sqlw As String = WNgay("NgayGS", ndau, ncuoi)
        taikhoan.SoDuNgay(ndau.AddDays(-1), dkn, dkc, dknt)
        If Not (dkn = 0 And dkc = 0 And (Not ps)) Then
            ' In bao cao
            If ps Then
                sql = String.Format("((HethongTK_2.SoHieu LIKE '{0}%'{1}) Or (HethongTK_3.SoHieu LIKE '{0}%'{2}))", _
                          taikhoan.sohieu, _
                          (IIf(doiung.Length > 0, String.Format(" And HethongTK_3.SoHieu LIKE '{0}%'", doiung), String.Empty)), _
                          (IIf(doiung.Length > 0, String.Format(" And HethongTK_2.SoHieu LIKE '{0}%'", doiung), String.Empty)))
                QChitiet = "SELECT DISTINCT ChungTu.MaCT, ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai" & (IIf(pnn > 0, "E", String.Empty)) & ", ChungTu.SoPS, ChungTu.SoPS2No, ChungTu.SoPS2Co, ChungTu.GhiChu, HeThongTK.SoHieu, HeThongTK_1.SoHieu, ChungTu.MaTKNo, ChungTu.MaTKCo, HethongTK_2.SoHieu As SHNo, HethongTK_3.SoHieu As SHCo,ThangCT" & " FROM HeThongTK AS HeThongTK_3 RIGHT JOIN (HeThongTK AS HeThongTK_2 RIGHT JOIN (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo) ON HeThongTK_2.MaSo = ChungTu.MaTKNo) ON HeThongTK_3.MaSo = ChungTu.MaTKCo" & " WHERE SoPS<>0 AND (" & sqlw & " And (" & sql & "))" & (IIf(VV > 1, " AND (ChungTu.MaDT = " & VV & ")", String.Empty)) & (IIf(mdt1 > 0, " AND (ChungTu.MaDT1 = " & mdt1 & ")", String.Empty)) & (IIf(mdt2 > 0, " AND (ChungTu.MaDT2 = " & mdt2 & ")", String.Empty)) & IIf(mdt3 > 0, " AND (ChungTu.MaDT3 = " & mdt3 & ")", String.Empty) & " AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco))" & " ORDER BY ChungTu.NgayGS,chungtu.sops desc"
            Else
                QChitiet = ("SELECT DISTINCT 0 AS MaCT, '' AS SoHieu, Null AS NgayCT, Null AS NgayGS, '' AS DienGiai, 0 AS SoPS, 0 AS SoPS2No, 0 AS SoPS2Co, '' AS GhiChu, '' AS SoHieu0, '' AS SoHieu1, 0 AS MaTKNo, 0 AS MaTKCo, '' As SHNo, '' As SHCo, 0 AS ThangCT" & " FROM ChungTu WHERE (chungtu.MaCT = 0)")
            End If
            result = True
            '************************************ Kiểm tra âm hàng **********************************************
            Dim rs As DataTable
            Dim str As String = String.Empty
            Dim tienam As Double
            tienam = dkn - dkc
            rs = ExecSQLReturnDT("SELECT DISTINCT ngaygs,chungtu.sohieu,CASE WHEN ([QChitiet.SHNo] LIKE '112%') THEN  0-[QChitiet.SoPS] ELSE [QChitiet.SoPS] END as sx FROM (" + QChitiet + ") AS  QChitiet ORDER BY ngaygs, CASE WHEN ([QChitiet.SHNo] LIKE '112%') THEN 0-[QChitiet.SoPS] ELSE [QChitiet.SoPS] END")
            Dim rsIndex As Integer = 0
            While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                tienam -= rsItem("sx")
                If tienam < 0 Then
                    str = ConvertToDblSafe(str) + rsItem("SoHieu") + ", "
                End If
                ''rs.MoveNext()
            End While
            If str <> "" Then
                str = Strings.Left(str, str.Length - 2)
                If MessageBox.Show(Ngonngu("Âm tiền gửi tại chứng từ có số hiệu ", "Amount is less then zero by") & str & "!" & Environment.NewLine & Ngonngu("Tiếp tục ?", "Continue ?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.No Then result = False
            End If
            '************************************ Hết kiểm tra ****************************************************
            Return result
        End If
        Return False
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmIntoanboso_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            For chi_so As Integer = 1 To 12
                SoLieu(chi_so - 1) = False
            Next
            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmIntoanboso_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
