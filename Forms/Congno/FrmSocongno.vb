Imports System
Imports System.Text
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter
Imports Excel = Microsoft.Office.Interop.Excel

Partial Friend Class FrmSoCongNo

    Dim baocao As Integer ' Chỉ số báo cáo được chọn
    Dim StopPrint As Boolean ' = True nếu ngừng in các danh sách báo cáo
    Dim Pdelay As Integer
    Dim Ngay(2) As Date
    Dim KTT, NLB, GD As String
    Dim nn As Integer
    Private isInitializingComponent As Boolean

    Private Sub cmdkh_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _cmdkh_0.Click
        Dim Index As Integer = Array.IndexOf(cmdkh, eventSender)
        Me.Cursor = Cursors.WaitCursor
        txtshkh(Index).Text = FrmKhachHang.ChonKhachHang(txtshkh(Index).Text)
        Me.Cursor = Cursors.Default
        txtshkh(Index).Focus()
    End Sub
    ''' <summary>
    ''' Chọn số hiệu tài khoản
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdtk_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _cmdtk_7.Click
        Dim Index As Integer = Array.IndexOf(cmdtk, eventSender)
        Me.Cursor = Cursors.WaitCursor
        txtShTk(Index).Text = FrmTaikhoan.ChonTk(txtShTk(Index).Text)
        txtShTk(Index).Focus()
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' Xem, In hoặc kết thúc
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_1.Click, _Command_0.Click, _Command_3.Click, _Command_2.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim taikhoan As New ClsTaikhoan
        Dim rs_tk As DataTable
        Dim tdau, tcuoi As Integer
        Dim n1 As Date

        Me.Cursor = Cursors.WaitCursor
        GauGe.Value = 0
        If CboThang(1).Items.Count > 0 Then
            If CboThang(0).Enabled And CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
        End If

        If baocao = 61 Or baocao = 89 Or baocao = 64 Then
            If CboThang(0).Items.Count > 0 Then CboThang(0).SelectedIndex = 0
            If CboThang(1).Items.Count > 0 Then CboThang(1).SelectedIndex = 11
        End If
        tdau = CboThang(0).SelectedValue
        tcuoi = CboThang(1).SelectedValue
        Select Case Index
            Case 0, 1
                Select Case baocao
                    Case 80
                        InCTKhuyenMai(IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(1), Ngay(2), ConvertToDblSafe(txtshkh(0).Tag), ConvertToDblSafe(txtShVT(1).Tag))
                    Case 38
                        If ConvertToDblSafe((txtShVT(1).Tag)) = 0 Then
                            ErrMsg(er_SHVattu)
                            txtShVT(1).Focus()
                            GoTo LoiBC
                        End If
                        CTDoanhThuGiaVon(IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(1), Ngay(2), ConvertToDblSafe(txtShVT(1).Tag))
                    Case 39
                        If CboKH.SelectedIndex < 0 Then Exit Sub
                        InCTDoanhThu(IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(1), Ngay(2), ConvertToDblSafe(txtshkh(0).Tag), ConvertToDblSafe(txtShVT(1).Tag), IIf(Opt(2).Checked, CboKH.SelectedIndex, 0))
                    Case 64
                        If Opt(3).Checked And ConvertToDblSafe((txtShTk(7).Tag)) > 0 Then taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(7).Tag)) Else taikhoan.InitTaikhoanMaSo(0)
                        n1 = IIf(OptTG(0).Checked, NgayCuoiThang(pNamTC, tcuoi), Ngay(2))
                        DuPhongPhaiThu(NgayDauThang(pNamTC, pThangDauKy), n1, taikhoan, IIf(Opt(2).Checked, CboKH.SelectedIndex, 0))
                    Case 53
                        If CboKH.SelectedIndex < 0 Then Exit Sub
                        InCTDoanhThu4(IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(1), Ngay(2), ConvertToDblSafe(txtshkh(0).Tag), ConvertToDblSafe(txtShVT(1).Tag), IIf(Opt(2).Checked, CboKH.SelectedIndex, 0))
                    Case 66
                        If ConvertToDblSafe((txtShVT(1).Tag)) = 0 Then
                            ErrMsg(er_SHVattu)
                            txtShVT(1).Focus()
                            GoTo LoiBC
                        End If
                        InCTDoanhThu2(IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(1), Ngay(2), ConvertToDblSafe(txtShVT(1).Tag))
                    Case 83
                        If ConvertToDblSafe((txtshkh(0).Tag)) = 0 Then
                            MessageBox.Show(Ngonngu("Hãy nhập số hiệu chi tiết công nợ!", "Enter debt details!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtshkh(0).Focus()
                            GoTo LoiBC
                        End If
                        If OptTG(0).Checked Then
                            BangKeTichSo2(txtShTk(7).Text, ConvertToDblSafe(txtshkh(0).Tag), NgayDauThang(pNamTC, tdau), NgayCuoiThang(pNamTC, tcuoi))
                        Else
                            BangKeTichSo2(txtShTk(7).Text, ConvertToDblSafe(txtshkh(0).Tag), Ngay(1), Ngay(2))
                        End If
                    Case 84
                        If CboKH.SelectedIndex < 0 Then GoTo LoiBC
                        If OptTG(0).Checked Then
                            InBangThopCN(tdau, tcuoi, IIf(Opt(3).Checked And ConvertToDblSafe((txtShTk(7).Tag)) > 0, txtShTk(7).Text, String.Empty), IIf(Opt(2).Checked, CboKH.SelectedIndex, 0), ChkDu(14).CheckState, 1)
                        Else
                            InBangThopCNN(Ngay(1), Ngay(2), IIf(Opt(3).Checked And ConvertToDblSafe((txtShTk(7).Tag)) > 0, txtShTk(7).Text, String.Empty), IIf(Opt(2).Checked, CboKH.SelectedIndex, 0), 1)
                        End If
                    Case 78
                        If txtShTk(7).Text = "" Then txtShTk(7).Text = "511"
                        taikhoan.InitTaikhoanSohieu(txtShTk(7).Text)
                        If taikhoan.tk_id <> TKDT_ID Then
                            txtShTk(7).Focus()
                            GoTo LoiBC
                        End If
                        If Not SoChiTiet3(txtShTk(7).Text, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(1), Ngay(2)) Then GoTo LoiBC
                    Case 72
                        If Opt(3).Checked And ConvertToDblSafe((txtShTk(7).Tag)) > 0 Then taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(7).Tag)) Else taikhoan.InitTaikhoanMaSo(0)
                        n1 = IIf(OptTG(0).Checked, NgayCuoiThang(pNamTC, tcuoi), Ngay(2))
                        InBangThopCN_HN(NgayDauThang(pNamTC, pThangDauKy), n1, taikhoan, IIf(Opt(2).Checked, CboKH.SelectedIndex, 0))
                    Case 73
                        If ConvertToDblSafe((txtshkh(0).Tag)) = 0 Then
                            MessageBox.Show(Ngonngu("Hãy nhập số hiệu chi tiết công nợ!", "Enter debt details"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtshkh(0).Focus()
                            GoTo LoiBC
                        End If
                        If Opt(3).Checked And ConvertToDblSafe((txtShTk(7).Tag)) > 0 Then taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(7).Tag)) Else taikhoan.InitTaikhoanMaSo(0)
                        n1 = IIf(OptTG(0).Checked, NgayCuoiThang(pNamTC, tcuoi), Ngay(2))
                        InChitietCN_HN(ConvertToDblSafe(txtshkh(0).Tag), NgayDauThang(pNamTC, pThangDauKy), n1, taikhoan)
                    Case 67
                        If CboKH.SelectedIndex < 0 Then GoTo LoiBC
                        InCongNoQuaHanMuc(tdau, IIf(Opt(3).Checked And ConvertToDblSafe((txtShTk(7).Tag)) > 0, txtShTk(7).Text, String.Empty), IIf(Opt(2).Checked, CboKH.SelectedIndex, 0))
                    Case 17
                        Ngay(0) = ConvertToDateSafe(_MedNgay_0.Text)
                        If CboKH.SelectedIndex < 0 Or Not InCTNoQuaHan(Ngay(0), ConvertToDblSafe(txtHan.Text), IIf(Opt(2).Checked, CboKH.SelectedIndex, 0)) Then GoTo LoiBC
                    Case 35
                        If CboKH.SelectedIndex < 0 Then GoTo LoiBC
                        If ChkDu(16).CheckState Then
                            FrmSoducongno.Hienthi(IIf(Opt(3).Checked, 0, 1), IIf(Opt(3).Checked, txtShTk(7).Text, CboKH.Text), tdau, tcuoi)
                            GoTo LoiBC
                        Else
                            If OptTG(0).Checked Then
                                InBangThopCN(tdau, tcuoi, IIf(Opt(3).Checked And ConvertToDblSafe((txtShTk(7).Tag)) > 0, txtShTk(7).Text, String.Empty), IIf(Opt(2).Checked, CboKH.SelectedIndex, 0), ChkDu(5).CheckState)
                            Else
                                InBangThopCNN(Ngay(1), Ngay(2), IIf(Opt(3).Checked And ConvertToDblSafe((txtShTk(7).Tag)) > 0, txtShTk(7).Text, String.Empty), IIf(Opt(2).Checked, CboKH.SelectedIndex, 0))
                            End If
                        End If
                    Case 36
                        If ConvertToDblSafe((txtshkh(0).Tag)) = 0 Then
                            ErrMsg(er_SHKhachHang)
                            txtshkh(0).Focus()
                            GoTo LoiBC
                        End If
                        If ChkDu(16).CheckState Then
                            FrmSochitietKh.Hienthi(tdau, tcuoi, ConvertToStrSafe(txtshkh(0).Tag))
                            GoTo LoiBC
                        Else
                            If ConvertToDblSafe((txtShTk(7).Tag)) = 0 Then
                                taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(GetSelectValue("SELECT MaTaiKhoan AS F1 FROM SoDuKhachHang WHERE MaKhachHang=" & ConvertToStrSafe(txtshkh(0).Tag))))
                                If taikhoan.maso > 0 Then
                                    txtShTk(7).Tag = ConvertToStrSafe(taikhoan.maso)
                                    txtShTk(7).Text = taikhoan.sohieu
                                    LbTenTk(7).Text = taikhoan.ten
                                Else
                                    ErrMsg(er_KoPS1)
                                    txtShTk(7).Focus()
                                    GoTo LoiBC
                                End If
                            Else
                                taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(7).Tag))
                            End If
                            If Not InSoChitietCN(taikhoan, ConvertToDblSafe(txtshkh(0).Tag), IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(1), Ngay(2)) Then GoTo LoiBC
                        End If
                    Case 62
                        If Index = 0 Then GoTo KhongIn
                        If ConvertToDblSafe((txtShTk(7).Tag)) = 0 Then
                            ErrMsg(er_SHTaiKhoan)
                            txtShTk(7).Focus()
                            GoTo LoiBC
                        Else
                            taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(7).Tag))
                        End If
                        rs_tk = ExecSQLReturnDT(String.Format("SELECT DISTINCT KhachHang.MaSo,KhachHang.SoHieu,KhachHang.Ten FROM (SoDuKhachHang INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo) INNER JOIN KhachHang ON SoDuKhachHang.MaKhachHang=KhachHang.MaSo WHERE HethongTK.SoHieu LIKE '{0}%' GROUP BY KhachHang.SoHieu,KhachHang.Ten,KhachHang.MaSo", taikhoan.sohieu))
                        StopPrint = False
                        GauGe.Maximum = 50
                        rptFrom.ReportDestination = 0
                        Dim rs_tkIndex As Integer = 0
                        Do While rs_tkIndex < rs_tk.Rows.Count
                            Dim rs_tkItem As DataRow = rs_tk.Rows(rs_tkIndex)
                            rs_tkIndex += 1 ' C15 Rs LOOP CONTROL And (Not StopPrint)
                            If InSoChitietCN(taikhoan, rs_tkItem("MaSo"), tdau, tcuoi, Ngay(1), Ngay(2)) Then
                                HienThongBao((String.Format("{0} - {1}", ConvertToStrSafe(rs_tkItem("SoHieu")), rs_tkItem("ten"))), 1)
                                InBaoCaoRPT()
                                For i As Integer = 1 To Pdelay * 100
                                    Application.DoEvents()
                                Next
                            End If
                            If GauGe.Value < GauGe.Maximum Then GauGe.Value += 1
                        Loop
                        GoTo LoiBC
                    Case 70
                        If Index = 0 Then GoTo KhongIn
                        rs_tk = ExecSQLReturnDT(String.Format("SELECT DISTINCT KhachHang.MaSo,KhachHang.SoHieu,KhachHang.Ten FROM (SoDuKhachHang INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo) INNER JOIN KhachHang ON SoDuKhachHang.MaKhachHang=KhachHang.MaSo WHERE HethongTK.SoHieu LIKE '{0}%' GROUP BY KhachHang.MaSo,KhachHang.SoHieu,KhachHang.Ten", txtShTk(7).Text))
                        StopPrint = False
                        If rs_tk.Rows.Count > 0 Then
                            GauGe.Maximum = rs_tk.Rows.Count
                            GauGe.Value = 0
                        End If
                        rptFrom.ReportDestination = 0
                        Dim rs_tkIndex As Integer = 0
                        Do While rs_tkIndex < rs_tk.Rows.Count
                            Dim rs_tkItem As DataRow = rs_tk.Rows(rs_tkIndex)
                            rs_tkIndex += 1 ' C15 Rs LOOP CONTROL And (Not StopPrint)
                            If THPSNhomCN2(ConvertToDblSafe(txtshkh(0).Tag), tdau, tcuoi) Then
                                HienThongBao((String.Format("{0} - {1}", ConvertToStrSafe(rs_tkItem("SoHieu")), rs_tkItem("ten"))), 1)
                                InBaoCaoRPT()
                                For i As Integer = 1 To Pdelay * 100
                                    Application.DoEvents()
                                Next
                            End If
                            GauGe.Value += 1
                        Loop
                        rs_tk = Nothing
                        GoTo LoiBC
                    Case 63
                        If Index = 0 Then GoTo KhongIn
                        taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(7).Tag))
                        rs_tk = ExecSQLReturnDT("SELECT DISTINCT KhachHang.MaSo,SoHieu,Ten FROM SoDuKhachHang INNER JOIN KhachHang ON SoDuKhachHang.MaKhachHang=KhachHang.MaSo GROUP BY SoHieu,Ten,KhachHang.MaSo")
                        StopPrint = False
                        GauGe.Maximum = 100
                        Dim rs_tkIndex As Integer = 0
                        Do While rs_tkIndex < rs_tk.Rows.Count
                            Dim rs_tkItem As DataRow = rs_tk.Rows(rs_tkIndex)
                            rs_tkIndex += 1 ' C15 Rs LOOP CONTROL And (Not StopPrint)
                            If DoiChieuCN(IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(1), Ngay(2), rs_tkItem("MaSo"), taikhoan, 1) Then
                                HienThongBao((String.Format("{0} - {1}", ConvertToStrSafe(rs_tkItem("SoHieu")), rs_tkItem("ten"))), 1)
                                InBaoCaoRPT()
                                AppIdle(Pdelay * 100)
                            End If
                            If GauGe.Value < GauGe.Maximum Then GauGe.Value += 1
                            'rs_tk.MoveNext()
                        Loop
                        ''rs_tk.Close()
                        GoTo LoiBC
                    Case 57
                        If ConvertToDblSafe((txtshkh(0).Tag)) = 0 Then
                            ErrMsg(er_SHKhachHang)
                            txtshkh(0).Focus()
                            GoTo LoiBC
                        End If
                        If Not THPSNhomCN2(ConvertToDblSafe(txtshkh(0).Tag), tdau, tcuoi) Then GoTo LoiBC
                    Case 49, 82, 91
                        If ConvertToDblSafe((txtshkh(0).Tag)) = 0 Then
                            ErrMsg(er_SHKhachHang)
                            txtshkh(0).Focus()
                            GoTo LoiBC
                        End If
                        taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(7).Tag))
                        If Not DoiChieuCN(IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(1), Ngay(2), ConvertToDblSafe(txtshkh(0).Tag), taikhoan, IIf(baocao = 49, 1, (IIf(baocao = 82, 0, 2)))) Then GoTo LoiBC
                    Case 40
                        KeHopDongV(tdau, tcuoi, ConvertToDblSafe(txtshkh(0).Tag), CboHD.SelectedValue)
                    Case 41
                        KeHopDongR(tdau, tcuoi, ConvertToDblSafe(txtshkh(0).Tag), CboHD.SelectedValue)
                    Case 58
                        If CboKH.SelectedIndex < 0 Then GoTo LoiBC
                        BangCDCno(tdau, tcuoi, IIf(Opt(2).Checked, CboKH.SelectedIndex, 0))
                End Select
                rptFrom.ReportDestination = Index
                If NLB.Length > 0 And NLB <> "..." Then rptFrom.SetFormulas("NLB", String.Format("'{0}'", NLB))
                If KTT.Length > 0 And KTT <> "..." Then rptFrom.SetFormulas("KTT", String.Format("'{0}'", KTT))
                If GD.Length > 0 And GD <> "..." Then rptFrom.SetFormulas("GD", String.Format("'{0}'", GD))
a:
                If Not RptOK(rptFrom.ReportFilename, nn) Then
                    MessageBox.Show(Ngonngu("Mẫu báo cáo đã bị thay đổi!", "Report form has been changed!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    GoTo LoiBC
                End If
                rptFrom.ReportWindowTitle = OptBC(baocao).Text
                rptFrom.ReportWindowState = System.Windows.Forms.FormWindowState.Maximized
                InBaoCaoRPT()
                On Error GoTo Bad
                'frmMain.rpt.Action = 1
                On Error GoTo 0
                GoTo LoiBC
            Case 2
                Hide()
            Case 3
                Dim TenFileExcel As String = String.Empty, Qchitiet As String = String.Empty
                Select Case baocao
                    Case 49, 82, 91
                        If txtshkh(0).Tag = 0 Then
                            ErrMsg(er_SHKhachHang)
                            txtshkh(0).Focus()
                            GoTo LoiBC
                        End If
                        taikhoan.InitTaikhoanMaSo(txtShTk(7).Tag)
                        If DoiChieuCN(IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(1), Ngay(2), txtshkh(0).Tag, taikhoan, IIf(baocao = 49, 1, IIf(baocao = 82, 0, 2)), Qchitiet) Then
                            HienThongBao(taikhoan.sohieu + " - " + taikhoan.ten, 1)
                            OpenBook(pCurDir + "\RePorts\DoiChieuCongNo.xls")
                            If tdau <> tcuoi Then
                                TenFileExcel = "\temp\" + CStr(tdau) + "_" + CStr(tcuoi) + "DoiChieuCongNo.xls"
                            Else
                                TenFileExcel = "\temp\" + CStr(tdau) + "DoiChieuCongNo.xls"
                            End If
                            ExcelDoiChieuCN(tdau, tcuoi, TenFileExcel, IIf(baocao = 49, 1, IIf(baocao = 82, 0, 2)), txtshkh(0).Tag, taikhoan, Qchitiet)
                            CloseBook(pCurDir + "\RePorts\DoiChieuCongNo.xls")
                            CallExcel(TenFileExcel)
                        End If
                    Case 70
                        rs_tk = ExecSQLReturnDT("SELECT DISTINCT KhachHang.MaSo,KhachHang.SoHieu,KhachHang.Ten FROM (SoDuKhachHang INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo) INNER JOIN KhachHang ON SoDuKhachHang.MaKhachHang=KhachHang.MaSo WHERE HethongTK.SoHieu LIKE '" + txtShTk(7).Text + "%' GROUP BY KhachHang.MaSo,KhachHang.SoHieu,KhachHang.Ten")
                        If rs_tk.Rows.Count > 0 Then GauGe.Maximum = rs_tk.Rows.Count
                        If THPSNhomCN2Excel(tdau, tcuoi) Then
                            HienThongBao(CStr(rs_tk.Rows(0)("SoHieu")) + " - " + rs_tk.Rows(0)("ten"), 1)
                            OpenBook(pCurDir + "\RePorts\congno.xls")
                            If tdau <> tcuoi Then
                                TenFileExcel = "\temp\" + CStr(tdau) + "_" + CStr(tcuoi) + "congno.xls"
                            Else
                                TenFileExcel = "\temp\" + CStr(tdau) + "congno.xls"
                            End If
                            Copycongno(tdau, tcuoi, TenFileExcel)
                            CloseBook(pCurDir + "\RePorts\congno.xls")
                            CallExcel(TenFileExcel)
                        End If
                        rs_tk = Nothing
                        rs_tk = Nothing
                End Select
        End Select
        GoTo LoiBC
KhongIn:
        ErrMsg(er_KoXem)
        GoTo LoiBC
Bad:
        MessageBox.Show(String.Format("Error {0}: {1}", Information.Err().Number, Information.Err().Description), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
LoiBC:
        HienThongBao(Me.Text, 1)
        GauGe.Value = GauGe.Maximum
        taikhoan = Nothing
        rs_tk = Nothing
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
    ''' <param name="source"></param>
    ''' <param name="X"></param>
    ''' <param name="Y"></param>
    ''' <remarks></remarks>
    Private Sub FCongno_DragDrop(ByRef source As Control, ByRef X As Single, ByRef Y As Single)
        FThuChi.Tag = ConvertToStrSafe(10)
        FThuChi.GetPhieu(NLB, KTT, GD, 0)
        Interaction.SaveSetting(IniPath, "Environment", "SReport1", NLB)
        Interaction.SaveSetting(IniPath, "Environment", "SReport2", KTT)
        Interaction.SaveSetting(IniPath, "Environment", "SReport3", GD)
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        HienThongBao(Me.Text, 1)
    End Sub
    ''' <summary>
    ''' Xử lý phím nóng
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmSoCongNo_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.X
                    Command(0).Focus()
                    '  Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.I
                    Command(1).Focus()
                    '  Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.V
                    Command(2).Focus()
                    '  Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.H
                    If ChkDu(16).Enabled Then
                        ChkDu(16).Focus()
                        ChkDu(16).CheckState = IIf(ChkDu(16).CheckState = CheckState.Checked, CheckState.Unchecked, CheckState.Checked)
                    End If
            End Select
        End If
        If (Shift And 2) > 0 And eventArgs.KeyCode = Keys.P Then
            frmMain.mnHT_Click(frmMain.mnHT, New EventArgs())
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    ' Khởi tạo cửa sổ báo cáo

    Private chiso1 As Integer = -1
    Private chiso0 As Integer = -1
    Private Sub FrmSoCongNo_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            AddMonthToCbo(CboThang(0))
            AddMonthToCbo(CboThang(1))
            'Int_RecsetToCbo("SELECT DISTINCT MaSo As F2,SoHieu + ' - '  + TenPhanLoai As F1 FROM PhanLoaiKhachHang WHERE PLCon=0 AND LEFT(SoHieu,1)<>'#' ORDER BY SoHieu", CboKH)
            'van.nguyen 18-Nov-2011
            Int_RecsetToCbo("SELECT DISTINCT MaSo As F2,SoHieu + ' - '  + TenPhanLoai As F1 FROM PhanLoaiKhachHang WHERE PLCon=0 AND LEFT(SoHieu,1)<>'#' ORDER BY MaSo, F1", CboKH)

            OptBC_CheckedChanged(OptBC(17), New EventArgs())
            Pdelay = ConvertToDblSafe(Interaction.GetSetting(IniPath, "Environment", "PrinterDelay", ConvertToStrSafe(10)))
            For chi_so As Integer = 0 To 2
                InitDateVars(MedNgay(chi_so), Ngay(chi_so))
            Next
            Text = SetFormTitle(Text)
            OptBC(35).Enabled = KHDetail
            OptBC(36).Enabled = KHDetail
            txtshkh(0).Enabled = KHDetail
            cmdkh(0).Enabled = KHDetail
            Int_RecsetToCbo("SELECT DoituongCT.MaSo As F2,Case When DoituongCT.MaKhachHang>0 then KhachHang.Ten+' - '+DoituongCT.Sohieu+' - ' ELSE '' END + DienGiai+ Case When DoituongCT.MaKhachHang>0 then ' - Ký ngày: ' + convert(varchar,NgayKy,3)  ELSE '' END As F1 FROM DoituongCT LEFT JOIN KhachHang ON DoituongCT.MaKhachHang=KhachHang.MaSo ORDER BY  KhachHang.Ten,DoituongCT.SoHieu,DienGiai", CboHD)
            NLB = Interaction.GetSetting(IniPath, "Environment", "SReport1", String.Empty)
            KTT = Interaction.GetSetting(IniPath, "Environment", "SReport2", String.Empty)
            GD = Interaction.GetSetting(IniPath, "Environment", "SReport3", String.Empty)
            OptBC(72).Visible = (pCongNoHD > 0)
            OptBC(73).Visible = (pCongNoHD > 0)
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
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmSoCongNo_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        StopPrint = True
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_1.Enter, _MedNgay_2.Enter, _MedNgay_0.Enter
        Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
        MedNgay(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_1.Leave, _MedNgay_2.Leave, _MedNgay_0.Leave
        Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
        If Information.IsDate(MedNgay(Index).Text) Then
            Ngay(Index) = ConvertToDateSafe(MedNgay(Index).Text)
        Else
            MedNgay(Index).Focus()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub OptBC_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptBC_80.CheckedChanged, _OptBC_53.CheckedChanged, _OptBC_66.CheckedChanged, _OptBC_39.CheckedChanged, _OptBC_38.CheckedChanged, _OptBC_35.CheckedChanged, _OptBC_91.CheckedChanged, _OptBC_84.CheckedChanged, _OptBC_83.CheckedChanged, _OptBC_82.CheckedChanged, _OptBC_78.CheckedChanged, _OptBC_72.CheckedChanged, _OptBC_73.CheckedChanged, _OptBC_70.CheckedChanged, _OptBC_67.CheckedChanged, _OptBC_63.CheckedChanged, _OptBC_62.CheckedChanged, _OptBC_58.CheckedChanged, _OptBC_57.CheckedChanged, _OptBC_49.CheckedChanged, _OptBC_41.CheckedChanged, _OptBC_40.CheckedChanged, _OptBC_36.CheckedChanged, _OptBC_17.CheckedChanged, _OptBC_64.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(OptBC, eventSender)
            'Dim thg_dau, thg_cuoi As Boolean
            ChkDu(16).CheckState = CheckState.Unchecked
            Select Case Index
                Case 35, 36
                    ChkDu(16).Enabled = True
                Case Else
                    ChkDu(16).Enabled = False
            End Select
            Select Case Index
                Case 64
                    OptTG(0).Enabled = False
                    OptTG(1).Enabled = False
                Case 35, 36, 49, 63, 72, 73, 78, 82, 83
                    OptTG(1).Enabled = True
                Case Else
                    OptTG_CheckedChanged(OptTG(0), New EventArgs())
                    OptTG(0).Checked = True
                    OptTG(1).Enabled = False
            End Select
            Command(3).Enabled = (OptBC(70).Checked = True) Or (OptBC(49).Checked = True) Or (OptBC(82).Checked = True) Or (OptBC(91).Checked = True)
            baocao = Index
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub OptBC_MouseDown(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles _OptBC_80.MouseDown, _OptBC_53.MouseDown, _OptBC_66.MouseDown, _OptBC_39.MouseDown, _OptBC_38.MouseDown, _OptBC_35.MouseDown, _OptBC_91.MouseDown, _OptBC_84.MouseDown, _OptBC_83.MouseDown, _OptBC_82.MouseDown, _OptBC_78.MouseDown, _OptBC_72.MouseDown, _OptBC_73.MouseDown, _OptBC_70.MouseDown, _OptBC_67.MouseDown, _OptBC_63.MouseDown, _OptBC_62.MouseDown, _OptBC_58.MouseDown, _OptBC_57.MouseDown, _OptBC_49.MouseDown, _OptBC_41.MouseDown, _OptBC_40.MouseDown, _OptBC_36.MouseDown, _OptBC_17.MouseDown
        Dim Button As Integer = ConvertToDblSafe(eventArgs.Button)
        Dim Shift As Integer = Control.ModifierKeys \ &H10000
        Dim X As Single = (eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        Dim Index As Integer = Array.IndexOf(OptBC, eventSender)
        If pRpt = CheckState.Checked And eventArgs.Button = MouseButtons.Right And User_Right = 0 Then
            FU1.QuyenBCChitiet(Index, OptBC(Index).Text)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub OptTG_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptTG_0.CheckedChanged, _OptTG_1.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(OptTG, eventSender)
            Frame(1 - Index).Visible = False
            Frame(Index).Visible = True
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtHan_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtHan.Enter
        txtHan.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtHan_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles txtHan.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        KeyProcess(txtHan, KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtshkh_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtshkh_0.Enter
        Dim Index As Integer = Array.IndexOf(txtshkh, eventSender)
        txtshkh(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtshkh_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtshkh_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtshkh, eventSender)
        If KeyAscii = 13 Then cmdkh_ClickEvent(cmdkh(Index), New EventArgs())
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtshkh_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtshkh_0.Leave
        Dim Index As Integer = Array.IndexOf(txtshkh, eventSender)
        Dim mvt As Integer
        txtshkh(Index).Text = txtshkh(Index).Text.ToUpper()
        lbkh(Index).Text = TenKH(txtshkh(Index).Text, mvt)
        txtshkh(Index).Tag = ConvertToStrSafe(mvt)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShTk_7.Enter
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        txtShTk(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtShTk_7.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        If KeyAscii = 13 Then cmdtk_ClickEvent(cmdtk(Index), New EventArgs())
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    ''' <summary>
    '''  Kiểm tra số hiệu tài khoản đã nhập
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShTk_7.Leave
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        txtShTk(Index).Text = txtShTk(Index).Text.ToUpper()
        Dim mtk As Integer = 0
        LbTenTk(Index).Text = tentk(txtShTk(Index).Text, mtk)
        txtShTk(Index).Tag = ConvertToStrSafe(mtk)
        HienThongBao(Me.Text, 1)
    End Sub
    ''' <summary>
    ''' Thủ tục in sổ chi tiết các chi tiết nợ quá hạn
    ''' </summary>
    ''' <param name="ngayh"></param>
    ''' <param name="songay"></param>
    ''' <param name="mpl"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function InCTNoQuaHan(ByRef ngayh As Date, ByRef songay As Integer, ByRef mpl As Integer) As Boolean
        Dim result As Boolean = False
        Dim rs_ct As DataTable
        Dim X, duno, duco, Y As Double
        Dim st As String = String.Empty
        Dim dk As Boolean
        ExecSQLNonQuery("DELETE FROM BaoCaoCP")
        Dim i As Integer = CThangDB2(ngayh.Month)
        Dim STR As String = String.Format("SELECT DISTINCT KhachHang.MaSo,KhachHang.SoHieu,KhachHang.Ten  FROM ((KhachHang INNER JOIN SoDuKhachHang ON KhachHang.MaSo=SoDuKhachHang.MaKhachHang) INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo) INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo  WHERE TK_ID={0} AND (SoDuKhachHang.DuNo_{1}>0 OR SoDuKhachHang.No_{2}>0) {3} ORDER BY KhachHang.SoHieu DESC", _
                                                     TKCNKH_ID, _
                                                     ConvertToStrSafe(i - 1), _
                                                     ConvertToStrSafe(i), _
                                                     (IIf(mpl > 0, String.Format(" AND PhanLoaiKhachHang.SoHieu LIKE '{0}%'", MaSo2SoHieu(mpl, "PhanLoaiKhachHang")), String.Empty)))
        Dim rs_tk As DataTable = ExecSQLReturnDT(STR)
        If rs_tk.Rows.Count > 0 Then
            ' rs_tk.MoveLast()
            GauGe.Maximum = rs_tk.Rows.Count
        End If
        i = 0
        For Each rs_tkItem As DataRow In rs_tk.Rows
            If (StopPrint) Then
                Exit For
            End If
            HienThongBao(String.Format("{0} - {1}", ConvertToStrSafe(rs_tkItem("SoHieu")), rs_tkItem("ten")), 1)
            SoDuKHNgay(rs_tkItem("MaSo"), ngayh, duno, duco, X)
            duco = duno - duco
            SoDuKHNgay(rs_tkItem("MaSo"), DateSerial(ngayh.Year, ngayh.Month, ngayh.Day - songay - 1), duno, X, Y)
            duno -= X
            Dim TAM As String = String.Format("SELECT DISTINCT Sum(ChungTu.SoPS) As SoThu FROM {0}WHERE (TK_ID={1}) AND (MaKHC = {2}) AND {3}", _
                                        ChungTu2TKNC(1), _
                                        TKCNKH_ID, _
                                        ConvertToStrSafe(rs_tkItem("MaSo")), _
                                        WNgay("NgayGS", DateSerial(ngayh.Year, ngayh.Month, ngayh.Day - songay), ngayh))
            rs_ct = ExecSQLReturnDT(TAM)
            Dim rs_ctItem0 As DataRow
            If rs_ct.Rows.Count <> 0 Then
                rs_ctItem0 = rs_ct.Rows(0)
                If Not IsDBNull(rs_ctItem0("SoThu")) Then duno -= rs_ctItem0("SoThu")
            End If


            X = 0
            If duno > 0 Or duco > 0 Then
                dk = True
                rs_ct = ExecSQLReturnDT(String.Format("SELECT DISTINCT ChungTu.* FROM {0}WHERE (TK_ID={1}) AND (MaKH = {2}) AND (NgayCT <= '{3}') ORDER BY NgayCT DESC", _
                                            ChungTu2TKNC(-1), _
                                            TKCNKH_ID, _
                                            ConvertToStrSafe(rs_tkItem("MaSo")), _
                                            Format(ngayh, Mask_DB)))
                If rs_ct.Rows.Count > 0 Then
                    For Each rs_ctItem As DataRow In rs_ct.Rows
                        If duno <= 0 And (Not dk Or duco <= 0) Then
                            Exit For
                        End If
                        If DateSerial(CDate(rs_ctItem("NgayCT")).Year, CDate(rs_ctItem("NgayCT")).Month, CDate(rs_ctItem("NgayCT")).Day + songay) < ngayh Then
                            i += 1
                            If ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP (MaSo, SoHieu, MaCha, BC_ID, Kq1, Kq2) VALUES ({0},N'{1}', {2},{3},{4},{5})", _
                                                   i, _
                                                   ConvertToStrSafe(i), _
                                                   ConvertToStrSafe(rs_tkItem("MaSo")), _
                                                   ConvertToStrSafe(rs_ctItem("MaSo")), _
                                                   CStr(IIf(duno > rs_ctItem("sops"), rs_ctItem("sops"), duno)), _
                                                   CStr(IIf(dk, duco, 0)))) Then GoTo KhongIn
                            dk = False
                            duno -= rs_ctItem("sops")
                        Else
                            If dk Or duco - X > 0 Then
                                i += 1
                                If ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP (MaSo, SoHieu, MaCha, BC_ID, Kq1, Kq2) VALUES ({0},N'{1}', {2},{3}, 0,{4})", _
                                                       i, _
                                                       ConvertToStrSafe(i), _
                                                       ConvertToStrSafe(rs_tkItem("MaSo")), _
                                                       ConvertToStrSafe(rs_ctItem("MaSo")), _
                                                       CStr(IIf(dk, duco, 0)))) Then GoTo KhongIn
                                dk = False
                                X += rs_ctItem("sops")
                            End If
                        End If
                        'rs_ct.MoveNext()
                    Next
                    If duno > 0 Or (dk And duco > 0) Then
                        i += 1
                        If ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP (MaSo, SoHieu, MaCha, BC_ID, Kq1, Kq2) VALUES ({0},N'{1}', {2}, -1,{3},{4})", _
                                               i, _
                                               ConvertToStrSafe(i), _
                                               ConvertToStrSafe(rs_tkItem("MaSo")), _
                                               CStr(duno), _
                                               CStr(IIf(dk, duco, 0)))) Then GoTo KhongIn
                        dk = False
                    End If
                Else
                    i += 1
                    If ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP (MaSo, SoHieu, MaCha, BC_ID, Kq1, Kq2) VALUES ({0},N'{1}', {2}, -1,{3},{4})", _
                                           i, _
                                           ConvertToStrSafe(i), _
                                           ConvertToStrSafe(rs_tkItem("MaSo")), _
                                           CStr(duno), _
                                           CStr(IIf(dk, duco, 0)))) Then GoTo KhongIn
                    dk = False
                End If
            End If
            'rs_tk.MovePrevious()
            GauGe.Value += 1
        Next
        HienThongBao(Me.Text, 1)
        If i > 0 Then
            result = True
            Dim QChitiet As String = "SELECT DISTINCT KhachHang.MaSo, KhachHang.SoHieu as [KhachHang.SoHieu], KhachHang.Ten, ChungTu.ThangCT, ChungTu.SoHieu as [ChungTu.SoHieu], ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai, ChungTu.SoPS, ChungTu.SoPS2Co, BaoCaoCP.Kq1, BaoCaoCP.Kq2, HeThongTK_1.SoHieu as [HeThongTK_1.SoHieu], BaoCaoCP.BC_ID FROM ((KhachHang INNER JOIN BaoCaoCP ON KhachHang.MaSo = BaoCaoCP.MaCha) LEFT JOIN ChungTu ON BaoCaoCP.BC_ID = ChungTu.MaSo) LEFT JOIN HeThongTK AS HeThongTK_1 ON ChungTu.MaTKTCCo = HeThongTK_1.MaSo ORDER BY KhachHang.SoHieu, NgayCT"
            rptFrom.InitForm("CNQH.RPT", QChitiet, "QChitiet")
            RptSetDate(ngayh)
            rptFrom.SetFormulas("ThoiGian", String.Format("'Tính đến ngày {0:dd/MM/yy} với thời hạn {1} ngày {2}'", ngayh, ConvertToStrSafe(songay), (IIf(mpl > 0, " - " & CboKH.Text, String.Empty))))
            rptFrom.SetFormulas("NgayHan", String.Format("Date({0},{1},{2})", ngayh.Year, ConvertToDblSafe(ngayh.Month), ConvertToDblSafe(DateAndTime.Day(ngayh))))
        Else
            result = False
            MessageBox.Show(Ngonngu("Không có nợ quá hạn !", "Not overdue debt!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        ''rs_tk.Close()
        rs_tk = Nothing
        Try
            ''rs_ct.Close()
            rs_ct = Nothing
        Catch exc As System.Exception
            'Resume in On-Error-Resume-Next Block
        End Try
        Return result
KhongIn:
        HienThongBao(Me.Text, 1)
        ErrMsg(er_RWait)
        Return result
    End Function
    Private Sub InBangThopCN(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef shtk As String, ByRef mpl As Integer, ByRef loai As Integer, Optional ByRef th As Integer = 0)
        Dim st As String = String.Empty
        Dim sqlc2 As New StringBuilder
        Dim sqln2 As New StringBuilder
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        Dim sqlcx2 As New StringBuilder
        Dim sqlnx2 As New StringBuilder
        Dim sqlcx As New StringBuilder
        Dim sqlnx As New StringBuilder
        GauGe.Maximum = 3
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            If sqln.Length = 0 Then
                sqln.Append(String.Format("SoDuKhachHang.No_{0}", i))
            Else
                sqln.Append(String.Format(" + SoDuKhachHang.No_{0}", i))
            End If
            If sqlc.Length = 0 Then
                sqlc.Append(String.Format("SoDuKhachHang.Co_{0}", i))
            Else
                sqlc.Append(String.Format(" + SoDuKhachHang.Co_{0}", i))
            End If

            If sqln2.Length = 0 Then
                sqln2.Append(String.Format("SoDuKhachHang.No_{0}_NT", i))
            Else
                sqln2.Append(String.Format(" + SoDuKhachHang.No_{0}_NT", i))
            End If
            If sqlc2.Length = 0 Then
                sqlc2.Append(String.Format("SoDuKhachHang.Co_{0}_NT", i))
            Else
                sqlc2.Append(String.Format(" + SoDuKhachHang.Co_{0}_NT", i))
            End If
        Next
        For i As Integer = 1 To tcuoi
            If sqlnx.Length = 0 Then
                sqlnx.Append(String.Format("SoDuKhachHang.No_{0}", i))
            Else
                sqlnx.Append(String.Format(" + SoDuKhachHang.No_{0}", i))
            End If
            If sqlcx.Length = 0 Then
                sqlcx.Append(String.Format("SoDuKhachHang.Co_{0}", i))
            Else
                sqlcx.Append(String.Format(" + SoDuKhachHang.Co_{0}", i))
            End If

            If sqlnx2.Length = 0 Then
                sqlnx2.Append(String.Format("SoDuKhachHang.No_{0}_NT", i))
            Else
                sqlnx2.Append(String.Format(" + SoDuKhachHang.No_{0}_NT", i))
            End If
            If sqlcx2.Length = 0 Then
                sqlcx2.Append(String.Format("SoDuKhachHang.Co_{0}_NT", i))
            Else
                sqlcx2.Append(String.Format(" + SoDuKhachHang.Co_{0}_NT", i))
            End If
        Next
        GauGe.Value = 1
        st = ConvertToStrSafe(CThangDB2(ThangTruoc(tdau)))
        Dim QChitiet As String = String.Format("SELECT DISTINCT KhachHang.SoHieu, KhachHang.Ten, PhanLoaiKhachHang.SoHieu AS SHPL, TenPhanLoai,KyHieu, Sum(SoDuKhachHang.DuNo_{0}) AS DkNo, Sum(SoDuKhachHang.DuCo_{0}) AS DkCo, Sum(SoDuKhachHang.DuNT_{0}) AS DkNT, Sum({1}) AS PsNo, Sum({2}) AS PsNo2, Sum({3}) AS PsCo, Sum({4}) AS PsCo2, Sum({5}) AS PsNoX, Sum({6}) AS PsNoX2, Sum({7}) AS PsCoX, Sum({8}) AS PsCoX2, Sum(SoDuKhachHang.DuNo_{9}) AS CkNo, Sum(SoDuKhachHang.DuCo_{9}) AS CkCo, Sum(SoDuKhachHang.DuNT_{9}) AS CkNT,PhanLoaiKhachHang.PLCha FROM (((KhachHang INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo) INNER JOIN SoDuKhachHang ON KhachHang.MaSo=SoDuKhachHang.MaKhachHang) INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo) LEFT JOIN NguyenTe ON KhachHang.MaNT=NguyenTe.MaSo  WHERE (SoDuKhachHang.DuNo_{0}<>0 OR SoDuKhachHang.DuCo_{0}<>0 OR ({5}) <>0 OR ({7}) <>0){10}{11}{12} AND LEFT(KhachHang.SoHieu,1)<>'' GROUP BY PhanLoaiKhachHang.Sohieu,KhachHang.SoHieu,KhachHang.Ten,TenPhanLoai,KyHieu,PLCha", _
                               st, _
                               sqln, _
                               sqln2, _
                               sqlc, _
                               sqlc2, _
                               sqlnx, _
                               sqlnx2, _
                               sqlcx, _
                               sqlcx2, _
                               ConvertToStrSafe(tcuoi), _
                               (IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty)), _
                               (IIf(mpl > 0, String.Format(" AND MaPhanLoai={0}", mpl), String.Empty)), _
                               (IIf(loai > 0, " AND KhachHang.MaNT>0", String.Empty)))
        Dim QSoCai As String = String.Format("SELECT QChitiet.*, PhanLoaiKhachHang.SoHieu AS SH2,PhanLoaiKhachHang.TenPhanLoai AS TenPhanLoai2,PhanLoaiKhachHang.PLCha AS PLCha2 FROM ({0}) AS QChitiet LEFT JOIN PhanLoaiKhachHang ON QChitiet.PLCha=PhanLoaiKhachHang.MaSo", QChitiet)
        Dim QTongHopCT As String = String.Format("SELECT QSoCai.*, PhanLoaiKhachHang.SoHieu AS SH1,PhanLoaiKhachHang.TenPhanLoai AS TenPhanLoai1 FROM ({0}) AS QSoCai LEFT JOIN PhanLoaiKhachHang ON QSoCai.PLCha2=PhanLoaiKhachHang.MaSo", QSoCai)
        GauGe.Value = 2

        If loai = 0 Then
            rptFrom.InitForm(String.Format("THSDCN{0}.RPT", (IIf(th <> 0, "1", String.Empty))), QTongHopCT, "QTongHopCT")
        Else
            rptFrom.InitForm("THSDCN2.RPT", QTongHopCT, "QTongHopCT")
        End If
        rptFrom.SetFormulas("Thoigian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        If shtk.Length > 0 Then
            rptFrom.SetFormulas("TenBaoCao", String.Format("'{0}{1} - {2}'", ("Tài khoản: "), shtk, LbTenTk(7).Text))
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="mkh"></param>
    ''' <param name="mhd"></param>
    ''' <remarks></remarks>
    Private Sub KeHopDongV(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef mkh As Integer, ByRef mhd As Integer)
        Dim sql As String = String.Empty
        If mkh = 0 Then
            sql = String.Format("SELECT DISTINCT ChungTu.*,DoituongCT.*,HethongTK.SoHieu AS TKNo,TK.Sohieu AS TKCo,-1 AS ID,KhachHang.MaNT FROM (((ChungTu INNER JOIN DoituongCT ON ChungTu.MaDT=DoituongCT.MaSo) LEFT JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo) LEFT JOIN KhachHang ON DoituongCT.MaKhachHang=KhachHang.MaSo WHERE Not((TK.SoHieu LIKE '3331%' OR TK.TK_ID={0})) AND {1} AND (ChungTu.maloai=1 or ChungTu.maloai=9 or ChungTu.maloai=13) AND ChungTu.MaDT>1{2}", TKDT_ID, WThang("ThangCT", tdau, tcuoi), (IIf(mhd > 1, " AND ChungTu.MaDT=" & mhd, String.Empty))) ' " OR HethongTK.SoHieu LIKE '111%' OR HethongTK.SoHieu LIKE '112%'
        Else
            ExecSQLNonQuery("DELETE  FROM BaoCaoCP")
            ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP (MaSo,SoHieu,MaCha) SELECT ChungTu.MaSo,ConvertToStrSafe(ChungTu.MaSo),MaCT FROM (ChungTu LEFT JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo  WHERE {0} AND Not(TK.SoHieu LIKE '3331%' OR TK.TK_ID={1}) AND MaDT>1{2}", _
                                WThang("ThangCT", tdau, tcuoi), _
                                ConvertToStrSafe(TKDT_ID), _
                                (IIf(mhd > 1, String.Format(" AND MaDT={0}", mhd), String.Empty)))) '" OR HethongTK.SoHieu LIKE '111%' OR HethongTK.SoHieu LIKE '112%'
            ExecSQLNonQuery("UPDATE BaoCaoCP INNER JOIN ChungTu ON BaoCaoCP.MaCha=ChungTu.MaCT SET BC_ID= CASE WHEN (MaKH>0) THEN MaKH ELSE MaKHC END WHERE MaKH>0 OR MaKHC>0")
            ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP INNER JOIN ({0}) ON BaoCaoCP.MaCha=ChungTu.MaCT SET BC_ID=MaKhachHang WHERE BC_ID=0", ChungTu2TKHD(0)))
            sql = String.Format("SELECT DISTINCT ChungTu.*,DoituongCT.*,HethongTK.SoHieu AS TKNo,TK.Sohieu AS TKCo,-1 AS ID,KhachHang.MaNT FROM ((((ChungTu INNER JOIN DoituongCT ON ChungTu.MaDT=DoituongCT.MaSo) LEFT JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo) INNER JOIN BaoCaoCP ON ChungTu.MaCT=BaoCaoCP.MaCha) LEFT JOIN KhachHang ON DoituongCT.MaKhachHang=KhachHang.MaSo WHERE BC_ID={0} AND ChungTu.MaDT>1{1}", _
                      mkh, _
                      (IIf(mhd > 1, String.Format(" AND ChungTu.MaDT={0}", mhd), String.Empty)))
            rptFrom.SetFormulas("TenKH", String.Format("'{0} - {1}'", txtshkh(0).Text, lbkh(0).Text))
        End If
        'SetSQL("QNhatKy", sql)
        rptFrom.InitForm("DSHD.RPT", sql, "QNhatKy")
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="mkh"></param>
    ''' <param name="mhd"></param>
    ''' <remarks></remarks>
    Private Sub KeHopDongR(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef mkh As Integer, ByRef mhd As Integer)
        Dim sql As String = String.Empty
        If mkh = 0 Then
            sql = String.Format("SELECT DISTINCT ChungTu.*,DoituongCT.*,HethongTK.SoHieu AS TKNo,TK.Sohieu AS TKCo,1 AS ID,KhachHang.MaNT FROM (((ChungTu INNER JOIN DoituongCT ON ChungTu.MaDT=DoituongCT.MaSo) LEFT JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo) LEFT JOIN KhachHang ON DoituongCT.MaKhachHang=KhachHang.MaSo WHERE {0} AND ((TK.SoHieu LIKE '3331%' OR TK.TK_ID={1} OR ((HethongTK.SoHieu LIKE '11%') AND (Not TK.SoHieu LIKE '331%')))) AND MaDT>1{2}", _
                      WThang("ThangCT", tdau, tcuoi), _
                      ConvertToStrSafe(TKDT_ID), _
                      (IIf(mhd > 1, String.Format(" AND MaDT={0}", mhd), String.Empty)))
        Else
            ExecSQLNonQuery("DELETE  FROM BaoCaoCP")
            ExecSQLNonQuery("INSERT INTO BaoCaoCP (MaSo,SoHieu,MaCha) SELECT ChungTu.MaSo,ConvertToStrSafe(ChungTu.MaSo),MaCT FROM (ChungTu LEFT JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo " & " WHERE " & WThang("ThangCT", tdau, tcuoi) & " AND (TK.SoHieu LIKE '3331%' OR TK.TK_ID=" & ConvertToStrSafe(TKDT_ID) & " OR ((HethongTK.SoHieu LIKE '11%')  AND (Not TK.SoHieu LIKE '331%'))) AND MaDT>1" & (IIf(mhd > 1, " AND MaDT=" & mhd, String.Empty)))
            ExecSQLNonQuery("UPDATE BaoCaoCP INNER JOIN ChungTu ON BaoCaoCP.MaCha=ChungTu.MaCT SET BC_ID=BC_ID= CASE WHEN (MaKH>0) THEN MaKH ELSE MaKHC END WHERE MaKH>0 OR MaKHC>0")
            ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP INNER JOIN ({0}) ON BaoCaoCP.MaCha=ChungTu.MaCT SET BC_ID=MaKhachHang WHERE BC_ID=0", ChungTu2TKHD(0)))
            sql = "SELECT DISTINCT ChungTu.*,DoituongCT.*,HethongTK.SoHieu AS TKNo,TK.Sohieu AS TKCo,1 AS ID,KhachHang.MaNT FROM ((((ChungTu INNER JOIN DoituongCT ON ChungTu.MaDT=DoituongCT.MaSo) LEFT JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo) INNER JOIN BaoCaoCP ON ChungTu.MaCT=BaoCaoCP.MaCha) LEFT JOIN KhachHang ON DoituongCT.MaKhachHang=KhachHang.MaSo" & " WHERE (BC_ID=" & mkh & ") AND (TK.SoHieu LIKE '3331%' OR TK.TK_ID=" & ConvertToStrSafe(TKDT_ID) & " OR HethongTK.SoHieu LIKE '11%') AND MaDT>1" & (IIf(mhd > 1, " AND MaDT=" & mhd, String.Empty))
            rptFrom.SetFormulas("TenKH", String.Format("'{0} - {1}'", txtshkh(0).Text, lbkh(0).Text))
        End If
        rptFrom.InitForm("DSHD.RPT", sql, "QNhatKy")
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="taikhoan"></param>
    ''' <param name="mcn"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InSoChitietCN(ByRef taikhoan As ClsTaikhoan, ByRef mcn As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date) As Boolean
        Dim dknt, dkn, dkc, X As Double
        Dim sqlw As String = String.Empty
        Dim cn As New clsKhachHang
        Dim i As Integer
        cn.InitKhachHangMaSo(mcn)
        If tcuoi > 0 Then
            cn.SoDuKH(ThangTruoc(tdau), dkn, dkc, dknt, IIf(taikhoan.tkcon = 0, taikhoan.maso, 0), IIf(taikhoan.tkcon > 0, taikhoan.sohieu, String.Empty))
            sqlw = WThang("ThangCT", tdau, tcuoi)
        Else
            SoDuKHNgay(cn.MaSo, ndau.AddDays(-1), dkn, dkc, dknt, IIf(taikhoan.tkcon = 0, taikhoan.maso, 0), IIf(taikhoan.tkcon > 0, taikhoan.sohieu, String.Empty))
            sqlw = WNgay("NgayGS", ndau, ncuoi)
        End If
        Dim sql As String = String.Format("((HethongTK_2.SoHieu LIKE '{0}%') Or (HethongTK_3.SoHieu LIKE '{0}%')) AND (MaKH={1} OR MaKHC={1})", _
                                taikhoan.sohieu, _
                                ConvertToStrSafe(mcn))
        Dim QChitiet As String
        If cn.MaNT = 0 Then
            QChitiet = String.Format("SELECT ChungTu.MaCT, ChungTu.SoHieu as [ChungTu.SoHieu], ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0}, ChungTu.SoPS, ChungTu.SoPS2No, ChungTu.SoPS2Co, ChungTu.GhiChu, HeThongTK.SoHieu as [HeThongTK.SoHieu], HeThongTK_1.SoHieu as [HeThongTK_1.SoHieu], ChungTu.MaTKNo, ChungTu.MaTKCo, HethongTK_2.SoHieu As SHNo, HethongTK_3.SoHieu As SHCo, MaKH,MaKHC, ThangCT FROM HeThongTK AS HeThongTK_3 RIGHT JOIN (HeThongTK AS HeThongTK_2 RIGHT JOIN (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo) ON HeThongTK_2.MaSo = ChungTu.MaTKNo) ON HeThongTK_3.MaSo = ChungTu.MaTKCo WHERE (SoPS<>0 OR SoPS2No<>0 OR SoPS2Co<>0) AND ({1} And ({2})) AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco)) ORDER BY ChungTu.NgayGS, ChungTu.MaCT", _
                                        (IIf(pnn > 0, "E", String.Empty)), _
                                        sqlw, _
                                        sql)
            i = GetRowNumber(QChitiet)
            If i = 0 And dkn = 0 And dkc = 0 Then GoTo KhongIn
            rptFrom.InitForm("CTTKCN.RPT", QChitiet, "QChitiet")
            rptFrom.SetFormulas("SoHieuTK", String.Format("'{0}'", taikhoan.sohieu))
            rptFrom.SetFormulas("MaCN", cn.MaSo)
        Else
            If (taikhoan.kieu < 0 And dkc > dkn) Or (taikhoan.kieu > 0 And dkc < dkn) Then dknt = -dknt
            QChitiet = "SELECT DISTINCT ChungTu.MaCT, ChungTu.SoHieu as [ChungTu.SoHieu], ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai" & (IIf(pnn > 0, "E", String.Empty)) & ", ChungTu.SoPS, ChungTu.SoPS2No, ChungTu.SoPS2Co, ChungTu.GhiChu, HeThongTK.SoHieu as [HeThongTK.SoHieu], HeThongTK_1.SoHieu as [HeThongTK_1.SoHieu], ChungTu.MaTKNo, ChungTu.MaTKCo, MaKH, MaKHC " & " FROM HeThongTK AS HeThongTK_3 RIGHT JOIN (HeThongTK AS HeThongTK_2 RIGHT JOIN (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo) ON HeThongTK_2.MaSo = ChungTu.MaTKNo) ON HeThongTK_3.MaSo = ChungTu.MaTKCo" & " WHERE (SoPS<>0 OR SoPS2No<>0 OR SoPS2Co<>0) AND (MaKH=" & mcn & " OR MaKHC=" & ConvertToStrSafe(mcn) & ") AND " & sqlw & " AND " & sql & " ORDER BY Chungtu.NgayGS, Chungtu.MaCT"
            i = GetRowNumber(QChitiet)
            If i = 0 And dkn = 0 And dkc = 0 Then GoTo KhongIn

            GauGe.Value = 2

            rptFrom.InitForm("CTTKCNNT.RPT", QChitiet, "QChitiet")
            rptFrom.SetFormulas("MaTK", taikhoan.maso)
            rptFrom.SetFormulas("NoDkNT", dknt)
            rptFrom.SetFormulas("MaCN", cn.MaSo)
        End If
        rptFrom.SetFormulas("NoDk", dkn - dkc)
        rptFrom.SetFormulas("Kieu", taikhoan.kieu)
        If tcuoi > 0 Then
            RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
            cn.SoPhatSinh(pThangDauKy, tcuoi, dkn, dkc, dknt, dknt, taikhoan.maso)
        Else
            RptSetDate(ncuoi)
            SoPhatSinhN(cn.MaSo, NgayDauThang(pNamTC, pThangDauKy), ncuoi, dkn, dkc, dknt, X, taikhoan.maso)
        End If
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi, nn)))))
        rptFrom.SetFormulas("NoLK", dkn)
        rptFrom.SetFormulas("CoLK", dkc)
        rptFrom.SetFormulas("TenTK", String.Format("'TK: {0} - {1}: {2}'", taikhoan.sohieu, cn.SoHieu, (IIf(pnn > 0, cn.TenE, cn.Ten))))
        If pCongNoHD > 0 And taikhoan.tk_id = TKCNKH_ID Then
            sql = cn.HDChuaTT(Math.Max(tcuoi, 0), ncuoi, taikhoan.sohieu, cn.MaSo)
            If sql.Length > 0 Then rptFrom.SetFormulas("HDTT", String.Format("'{0}'", sql))
        End If
        Return True
KhongIn:
        Return False
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="mkh"></param>
    ''' <param name="TK"></param>
    ''' <param name="ct"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function DoiChieuCN(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef mkh As Integer, ByRef TK As ClsTaikhoan, ByRef ct As Integer, Optional ByRef Qchitiet As String = "") As Boolean
        Dim result As Boolean = False
        Dim sqlw2 = String.Empty, sql = String.Empty, sqlw1 = String.Empty, shtk As String = String.Empty
        Dim X, dn, DC, Y As Double
        Dim loai As Integer
        Dim kh As New clsKhachHang
        Dim rs, rs1 As DataTable
        Dim TToanTK As Double
        kh.InitKhachHangMaSo(mkh)

        Dim MienTru As String
        Dim QDuPhong As String

        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        result = True
        If TK.maso = 0 Then
            loai = ConvertToDblSafe(GetSelectValue("SELECT Kieu AS F1,SoHieu AS F2 FROM HethongTK INNER JOIN SoDuKhachHang On HethongTK.MaSo=SoDuKhachHang.MaTaiKhoan WHERE MaKhachHang=" & mkh, shtk))
            If shtk Like "141*" Then
                TK.InitTaikhoanSohieu(shtk)
                GoTo AAA
            End If
            If tdau > 0 Then
                kh.SoDuKH(ThangTruoc(tdau), dn, DC, X)
            Else
                SoDuKHNgay(mkh, ndau.AddDays(-1), dn, DC, X, 0)
            End If
        Else
AAA:
            loai = TK.kieu
            If tdau > 0 Then
                kh.SoDuKH(ThangTruoc(tdau), dn, DC, X, 0, TK.sohieu)
            Else
                SoDuKHNgay(mkh, ndau.AddDays(-1), dn, DC, X, IIf(TK.tkcon = 0, TK.maso, 0), IIf(TK.tkcon > 0, TK.sohieu, "0"))
            End If
            sqlw1 = String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", TK.sohieu)
            sqlw2 = String.Format(" AND TK.SoHieu LIKE '{0}%'", TK.sohieu)
        End If
        Dim QNhatKy As String = String.Format("SELECT MaCT,Sum( CASE WHEN (MaTKNo>0) THEN SoPS ELSE 0 END) AS TPS FROM ChungTu WHERE {0} GROUP BY MaCT", wsql)
        If loai > 0 Or TK.sohieu Like "141*" Then
            MienTru = String.Format("SELECT chungtu.MaCT FROM {0} WHERE MaKHC={1} AND {2}{3} GROUP BY MaCT", _
                                        ChungTu2TKNC(1), _
                                        ConvertToStrSafe(mkh), _
                                        wsql, _
                                        sqlw1)
            QDuPhong = String.Format("SELECT MaCT FROM {0} WHERE MaKH={1} AND {2}{3} GROUP BY MaCT", _
                                         ChungTu2TKNC(-1), _
                                         ConvertToStrSafe(mkh), _
                                         wsql, _
                                         sqlw1)
            sql = String.Format("SELECT DISTINCT 1 AS Loai,chungtu.NgayCT,ChungTu.SoHieu AS SHCT,CASE WHEN (MaVattu>0) THEN Vattu.SoHieu ELSE HethongTK.SoHieu END AS SoHieu,case when mavattu>0 then TenVattu else '...' end as [TenVatTu],case when mavattu>0 then donvi else '...' end as [donvi],Sum(SoPS2No) AS Luong,Sum(SoPS) AS Tien,chungtu.DienGiai{0},max(ChungTu.MaSo) AS MaSo, CASE WHEN (HethongTK.Loai=1 OR HethongTK.Loai=6) AND HethongTK.TK_ID<>{1} THEN {2} ELSE TK_ID END {3} FROM (({4}) LEFT JOIN  Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN ({5}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT WHERE (TK_ID={6} OR TK_ID={1} OR HethongTK.SoHieu LIKE '138%' OR HethongTK.SoHieu LIKE '338%' OR ((HethongTK.Loai=1 OR HethongTK.Loai=6) AND MaKHC={7})) GROUP BY chungtu.NgayCT,ChungTu.SoHieu,CASE WHEN (MaVattu>0) THEN Vattu.SoHieu ELSE HethongTK.SoHieu END, case when mavattu>0 then TenVattu else '...' end ,case when mavattu>0 then donvi else '...' end,chungtu.DienGiai{0},CASE WHEN (HethongTK.Loai=1 OR HethongTK.Loai=6) AND HethongTK.TK_ID<>{1} THEN {2} ELSE TK_ID END ", _
                      (IIf(pNN > 0, String.Empty, String.Empty)), _
                      ConvertToStrSafe(GTGTKT_ID), _
                      ConvertToStrSafe(TKVT_ID), _
                      (IIf(ct = 2, "as aa", "as TK_ID")), _
                      ChungTu2TKNC(-1), _
                      MienTru, _
                      TKVT_ID, _
                      ConvertToStrSafe(mkh))

            sql = String.Format("{0} UNION SELECT DISTINCT 1 AS Loai,chungtu.NgayCT,ChungTu.SoHieu AS SHCT,'TSCD' AS SH,ChungTu.DienGiai,'...' AS Dvt,1 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM ({2}) INNER JOIN ({3}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT WHERE (TK_ID={4})", _
                      sql, _
                      (IIf(pNN > 0, String.Empty, String.Empty)), _
                      ChungTu2TKNC(-1), _
                      MienTru, _
                      TSCD_ID)
            sql = String.Format("{0} UNION SELECT DISTINCT 1 AS Loai,chungtu.NgayCT,ChungTu.SoHieu AS SHCT,'' AS SH,ChungTu.DienGiai,'...' AS Dvt,0 AS Luong,SoPS-TPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,TK_ID FROM ({2}) INNER JOIN ({3}) AS QNhatKy ON ChungTu.MaCT=QNhatKy.MaCT WHERE MaTKNo=0 AND MaKHC={4} AND SoPS<>TPS AND MaLoai=1 AND (ChungTu.GhiChu like '138%') AND {5}{6}", _
                      sql, _
                      (IIf(pNN > 0, String.Empty, String.Empty)), _
                      ChungTu2TKNC(1), _
                      QNhatKy, _
                      mkh, _
                      wsql, _
                      sqlw1)

            sql = sql + " UNION SELECT 1 AS Loai,chungtu.NgayCT,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,HethongTK.ten AS TenVT,'' AS Dvt,0 AS Luong,0-SoPS AS Tien,chungtu.DienGiai,ChungTu.MaSo,0 AS TK_ID FROM ((" + ChungTu2TKNC(1) + ") INNER JOIN (" & MienTru & ") as MienTru ON ChungTu.MaCT=MienTru.MaCT)" _
            & " WHERE (HethongTK.SoHieu LIKE '711%') AND MaTKNo=0"

            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.NgayCT,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM {2} WHERE (TK.SoHieu LIKE '11%' OR TK.SoHieu LIKE '141%' OR TK.SoHieu LIKE '{3}%' OR TK.SoHieu LIKE '311%' OR TK.SoHieu LIKE '336%' OR TK.SoHieu LIKE '15%'  OR TK.SoHieu LIKE '515%'  OR TK.SoHieu LIKE '511%'  OR TK.SoHieu LIKE '711%' OR TK.SoHieu LIKE '3331%' OR TK.SoHieu LIKE '{4}%' OR TK.SoHieu LIKE '413%' OR TK.Loai=6) AND MaKH={5} AND {6}{7}", _
                      sql, _
                      (IIf(pNN > 0, String.Empty, String.Empty)), _
                      ChungTu2TKNC(0), _
                      pSHPT, _
                      pVATV, _
                      ConvertToStrSafe(mkh), _
                      wsql, _
                      sqlw1)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.NgayCT,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai,ChungTu.MaSo,0 AS TK_ID FROM ({1}) INNER JOIN ({2}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT WHERE (HethongTK.SoHieu LIKE '11%' OR HethongTK.SoHieu LIKE '136%') AND MaTKNo=0", _
                      sql, _
                      ChungTu2TKNC(1), _
                      MienTru)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.NgayCT,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM {2} WHERE MaKHC=MaKH AND MaKH={3} AND TK_ID={4} AND {5}{6}", _
                      sql, _
                      (IIf(pNN > 0, String.Empty, String.Empty)), _
                      ChungTu2TKNC(-1), _
                      mkh, _
                      ConvertToStrSafe(TKCNPT_ID), _
                      wsql, _
                      sqlw1)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.NgayCT,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM ({2}) INNER JOIN ({3}) AS QDuPhong ON ChungTu.MaCT=QDuPhong.MaCT WHERE (HethongTK.SoHieu LIKE '635%' AND TK.SoHieu LIKE '11%'){4}", _
                      sql, _
                      (IIf(pNN > 0, String.Empty, String.Empty)), _
                      ChungTu2TKNC(0), _
                      QDuPhong, _
                      sqlw1)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.NgayCT,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM ({2}) INNER JOIN ({3}) AS QDuPhong ON ChungTu.MaCT=QDuPhong.MaCT WHERE (HethongTK.SoHieu LIKE '331%' AND TK.SoHieu LIKE '144%'){4}", _
                      sql, _
                      (IIf(pNN > 0, String.Empty, String.Empty)), _
                      ChungTu2TKNC(0), _
                      QDuPhong, _
                      sqlw1)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.NgayCT,ChungTu.SoHieu AS SHCT,TK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM ({2}) INNER JOIN ({3}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT WHERE (HethongTK.SoHieu LIKE '152%' AND TK.SoHieu LIKE '11%'){4}", _
                      sql, _
                      (IIf(pNN > 0, String.Empty, String.Empty)), _
                      ChungTu2TKNC(0), _
                      MienTru, _
                      sqlw1)
            If ct = 2 Then
                Dim Mientru1 As String = sql
                rs = ExecSQLReturnDT(String.Format("SELECT t2.*,t1.aa,t1.tien FROM ({0}) As t1 inner join chungtu t2 on t1.maso=t2.maso WHERE t1.loai=1", sql))
                ExecSQLNonQuery("DELETE  FROM BKNhomPS")
                Dim rsIndex As Integer = 0
                While rsIndex < rs.Rows.Count
                    Dim rsItem As DataRow = rs.Rows(rsIndex)
                    rsIndex += 1 ' C15 Rs LOOP CONTROL
                    ExecSQLNonQuery(String.Format("INSERT into BKNhomPS(shtk,mact,sohieu,DienGiai,sopsno,sops2no,ngay,sopsco) values('{1}',{2},'{3}',N'{4}',{5},{6},'{7}',{8})", _
                                        Lng_MaxValue("maso", "BKNhomPS") + 1, _
                                        rsItem("MaSo"), _
                                        rsItem("MaCT"), _
                                        rsItem("SoHieu"), _
                                        rsItem("DienGiai"), _
                                        rsItem("tien"), _
                                        rsItem("SoXuat"), _
                                        Format(CDate(rsItem("NgayCT")), Mask_DB), _
                                        rsItem("AA")))
                    rs1 = ExecSQLReturnDT("SELECT sohieu,mact,ngayct FROM chungtu WHERE ct_id=" & rsItem("MaCT"))
                    Dim rs1Index As Integer = 0
                    While rs1Index < rs1.Rows.Count
                        Dim rs1Item As DataRow = rs1.Rows(rs1Index)
                        rs1Index += 1 ' C15 Rs LOOP CONTROL
                        ExecSQLNonQuery(String.Format("UPDATE BKNhomPS set shdu='{0}',ngaygs='{1}' WHERE shtk='{2}'", _
                                            rs1Item("SoHieu"), _
                                            Format(CDate(rs1Item("NgayCT")), Mask_DB), _
                                            rsItem("MaSo")))
                        'rs1.MoveNext()
                    End While
                    ''rs.MoveNext()
                End While
                X = ConvertToDblSafe(GetSelectValue("SELECT Sum(sopsno)-sum(sops2No) AS F1,Sum(ABS(sopsno-sops2No)) AS F2 FROM BKNhomPS", Y))
                sql = ""
                For i As Integer = tdau To tcuoi
                    sql = String.Format("{0}+no_{1}", sql, ConvertToStrSafe(i))
                Next
                sql = Strings.Right(sql, sql.Length - 1)
                TToanTK = ConvertToDblSafe(GetSelectValue(String.Format("SELECT {0} as f1 FROM sodukhachhang WHERE makhachhang={1}", _
                                                              sql, _
                                                              ConvertToStrSafe(mkh))))
                TToanTK = ConvertToDblSafe(TToanTK - ConvertToDblSafe(GetSelectValue("SELECT sum(sops2no) as f1 FROM BKNhomPS")))
                rptFrom.InitForm(String.Format("DCCN{0}.RPT", IIf(ct = 0, "2", IIf(ct = 2, "1", String.Empty))), "Select * from BKNhomPS", "BKNhomPS")
                rptFrom.SetFormulas("TToanTK", TToanTK)
                rptFrom.SetFormulas("ThanhTienX", String.Format("'{0} đồng'", ToVNText(dn - DC + X - TToanTK)))
            Else
                rptFrom.InitForm(String.Format("DCCN{0}.RPT", IIf(ct = 0, "2", IIf(ct = 2, "1", String.Empty))), sql, "QChitiet")
                X = ConvertToDblSafe(GetSelectValue("SELECT Sum(CASE WHEN Loai=1 THEN Tien ELSE -Tien END) AS F1,Sum(ABS(Tien)) AS F2 FROM (" & sql & ") as QChitiet", Y))
                rptFrom.SetFormulas("ThanhTienX", String.Format("'{0} đồng'", ToVNText(DC - dn + X)))
            End If
            rptFrom.SetFormulas("TenTK", String.Format("'{0}{1} - {2}'", Ngonngu("Bên cung cấp: ", "Providers: "), kh.SoHieu, kh.Ten))
            rptFrom.SetFormulas("SoDu", DC - dn)
            If DC = 0 And dn = 0 And Y = 0 And ct <> 2 Then GoTo z
        Else
z:
            MienTru = String.Format("SELECT MaCT FROM {0} WHERE (MaLoai=8 OR MaLoai=0) AND MaKH={1} AND {2}{3} GROUP BY MaCT", ChungTu2TKNC(-1), ConvertToStrSafe(mkh), wsql, sqlw1)
            QDuPhong = String.Format("SELECT MaCT FROM {0} WHERE MaKHC={1} AND {2}{3} GROUP BY MaCT", ChungTu2TKNC(1), ConvertToStrSafe(mkh), wsql, sqlw1)
            sql = "SELECT DISTINCT 1 AS Loai,chungtu.ngayct,ChungTu.SoHieu AS SHCT,CASE WHEN (MaVattu>0) THEN Vattu.SoHieu ELSE HethongTK.SoHieu END AS SoHieu,TenVattu,DonVi,SoPS2Co AS Luong,SoPS AS Tien,chungtu.DienGiai" & (IIf(pNN > 0, String.Empty, String.Empty)) & ",ChungTu.MaSo,TK_ID FROM ((" & ChungTu2TKNC(1) & ") LEFT JOIN  Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN (" + MienTru + ") AS MienTru ON ChungTu.MaCT=MienTru.MaCT" & " WHERE TK_ID=" & TKDT_ID & " OR TK_ID=" & ConvertToStrSafe(TKTNBT_ID) & " OR TK_ID=" & ConvertToStrSafe(GTGTPN_ID) & " OR HethongTK.Loai=7 OR HethongTK.SoHieu LIKE '138%' OR HethongTK.SoHieu LIKE '338%'"
            sql = String.Format("{0} UNION SELECT 1 AS Loai,chungtu.ngayct,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM {2} WHERE MaKHC<>MaKH AND MaKH={3} AND TK_ID={4} AND MaTKTCNo=MaTKTCCo AND {5}{6}", sql, (IIf(pNN > 0, String.Empty, String.Empty)), ChungTu2TKNC(-1), mkh, ConvertToStrSafe(TKCNKH_ID), wsql, sqlw1)
            sql = String.Format("{0} UNION SELECT 1 AS Loai,chungtu.ngayct,ChungTu.SoHieu AS SHCT,'~' AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,-SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,TK_ID FROM ({2}) INNER JOIN ({3}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT WHERE HethongTK.SoHieu LIKE '521%' AND {4}{5}", sql, (IIf(pNN > 0, String.Empty, String.Empty)), ChungTu2TKNC(-1), MienTru, wsql, sqlw1)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.ngayct,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM {2} WHERE (HethongTK.SoHieu LIKE '11%' OR HethongTK.SoHieu LIKE '15%' OR HethongTK.SoHieu LIKE '{3}%' OR HethongTK.SoHieu LIKE '3331%' OR HethongTK.SoHieu LIKE '136%' OR HethongTK.SoHieu LIKE '138%' OR HethongTK.SoHieu LIKE '336%' OR HethongTK.SoHieu LIKE '338%' OR HethongTK.SoHieu LIKE '331%' OR HethongTK.SoHieu LIKE '413%' OR HethongTK.Loai=5 OR HethongTK.Loai=6) AND MaKHC={4} AND {5}{6}", sql, (IIf(pNN > 0, String.Empty, String.Empty)), ChungTu2TKNC(0), pVATV, ConvertToStrSafe(mkh), wsql, sqlw2)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.ngayct,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM ({2}) INNER JOIN ({3}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT WHERE (HethongTK.SoHieu LIKE '11%' OR HethongTK.SoHieu LIKE '15%' OR HethongTK.SoHieu LIKE '136%' OR HethongTK.SoHieu LIKE '138%' OR HethongTK.SoHieu LIKE '336%' OR HethongTK.SoHieu LIKE '338%') AND MaTKCo=0", sql, (IIf(pNN > 0, String.Empty, String.Empty)), ChungTu2TKNC(-1), MienTru)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.ngayct,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM {2} WHERE MaKHC=MaKH AND MaKH={3} AND HethongTK.TK_ID={4} AND {5}{6}", sql, (IIf(pNN > 0, String.Empty, String.Empty)), ChungTu2TKNC(0), mkh, ConvertToStrSafe(TKCNPT_ID), wsql, sqlw2)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.ngayct,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM {2} WHERE MaKHC<>MaKH AND MaKHC={3} AND TK_ID={4} AND MaTKTCNo=MaTKTCCo AND {5}{6}", sql, (IIf(pNN > 0, String.Empty, String.Empty)), ChungTu2TKNC(-1), mkh, ConvertToStrSafe(TKCNKH_ID), wsql, sqlw1)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.ngayct,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM ({2}) INNER JOIN ({3}) AS QDuPhong ON ChungTu.MaCT=QDuPhong.MaCT WHERE (HethongTK.SoHieu LIKE '11%' AND TK.SoHieu LIKE '515%'){4}", sql, (IIf(pNN > 0, String.Empty, String.Empty)), ChungTu2TKNC(0), QDuPhong, sqlw1)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.ngayct,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,-SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM ({2}) INNER JOIN ({3}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT WHERE TK.SoHieu LIKE '11%' AND MaKH={4} AND HethongTK.TK_ID={5}{6}", sql, (IIf(pNN > 0, String.Empty, String.Empty)), ChungTu2TKNC(0), MienTru, mkh, ConvertToStrSafe(TKCNKH_ID), sqlw1)

            If ct = 2 Then
                rs = ExecSQLReturnDT(String.Format("SELECT t2.*,mientru1.tk_id,mientru1.tien FROM ({0}) AS mientru1 inner join chungtu t2 on mientru1.maso=t2.maso WHERE mientru1.loai=1", sql))
                ExecSQLNonQuery(("DELETE  FROM BKNhomPS"))
                Dim rsIndex As Integer = 0
                While rsIndex < rs.Rows.Count
                    Dim rsItem As DataRow = rs.Rows(rsIndex)
                    rsIndex += 1 ' C15 Rs LOOP CONTROL
                    ExecSQLNonQuery((String.Format("INSERT into BKNhomPS(shtk,mact,sohieu,DienGiai,sopsno,sops2no,ngay,sopsco) values('{1}',{2},'{3}',N'{4}',{5},{6},'{7}',{8})", Lng_MaxValue("maso", "BKNhomPS") + 1, rsItem("MaSo"), rsItem("MaCT"), rsItem("SoHieu"), rsItem("DienGiai"), rsItem("tien"), rsItem("SoXuat"), Format(CDate(rsItem("NgayCT")), Mask_DB), rsItem("tk_id"))))
                    rs1 = ExecSQLReturnDT(String.Format("SELECT sohieu,mact,ngayct FROM chungtu WHERE ct_id={0}", rsItem("MaCT")))
                    Dim rs1Index As Integer = 0
                    While rs1Index < rs1.Rows.Count
                        Dim rs1Item As DataRow = rs1.Rows(rs1Index)
                        rs1Index += 1 ' C15 Rs LOOP CONTROL
                        ExecSQLNonQuery((String.Format("UPDATE BKNhomPS set shdu='{0}',ngaygs='{1}' WHERE shtk='{2}'", rs1Item("SoHieu"), Format(CDate(rs1Item("NgayCT")), Mask_DB), rsItem("MaSo"))))
                    End While
                End While
                X = ConvertToDblSafe(GetSelectValue("SELECT Sum(sopsno)-sum(sops2No) AS F1,Sum(ABS(sopsno-sops2No)) AS F2 FROM BKNhomPS", Y))
                sql = ""
                For i As Integer = tdau To tcuoi
                    sql = String.Format("{0}+co_{1}", sql, ConvertToStrSafe(i))
                Next
                If sql <> "" Then sql = Strings.Right(sql, sql.Length - 1)
                TToanTK = ConvertToDblSafe(GetSelectValue(String.Format("SELECT {0} as f1 FROM sodukhachhang WHERE makhachhang={1}", sql, ConvertToStrSafe(mkh))))
                TToanTK = ConvertToDblSafe(TToanTK - ConvertToDblSafe(GetSelectValue("SELECT sum(sops2no) as f1 FROM BKNhomPS")))

                rptFrom.InitForm("DCCN1.RPT", "SELECT * FROM BKNhomPS", "BKNhomPS")

                rptFrom.SetFormulas("TToanTK", TToanTK)
                rptFrom.SetFormulas("ThanhTienX", String.Format("'{0} đồng'", ToVNText(dn - DC + X - TToanTK)))
            Else
                rptFrom.InitForm(String.Format("DCCN{0}.RPT", IIf(ct = 0, "2", IIf(ct = 2, "1", String.Empty))), sql, "QChitiet")
                X = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(CASE WHEN Loai=1 THEN Tien ELSE -Tien END) AS F1,Sum(ABS(Tien)) AS F2 FROM ({0}) as QChitiet", sql), Y))
                rptFrom.SetFormulas("ThanhTienX", String.Format("'{0} đồng'", ToVNText(dn - DC + X)))
            End If
            rptFrom.SetFormulas("TenTK", String.Format("'{0}{1} - {2}'", Ngonngu("Bên nhận hàng: ", "Consignee: "), kh.SoHieu, kh.Ten))
            rptFrom.SetFormulas("SoDu", dn - DC)
            If DC = 0 And dn = 0 And Y = 0 Then GoTo KhongIn
        End If
        If X = 0 And DC = 0 And dn = 0 And Y = 0 Then
            Qchitiet = "SELECT DISTINCT 1 AS Loai,NgayCT,'...' AS SHCT,'...' AS SH,'...' AS TenVattu,'...' AS DonVi,0 AS Luong,0 AS Tien,'...',0,0 FROM ChungTu WHERE MaCT=0"
            rptFrom.InitForm(String.Format("DCCN{0}.RPT", IIf(ct = 0, "2", IIf(ct = 2, "1", String.Empty))), QChitiet, "QChitiet")
        End If
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi, nn)))))

        RptSetDate(ncuoi)
        Qchitiet = sql
        Return result
KhongIn:
        Return False
    End Function

    Private Sub InBangThopCNN(ByRef ndau As Date, ByRef ncuoi As Date, ByRef shtk As String, ByRef mpl As Integer, Optional ByRef th As Integer = 0)
        Dim X, ckn, psc, psn, dkno, dkco, psnx, pscx, ckc, Y As Double
        GauGe.Maximum = 3
        ExecSQLNonQuery("DELETE  FROM BaoCaoCP")
        ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP (MaSo,SoHieu,MaCha,BC_ID) SELECT MaTaiKhoan*100000+MaKhachHang AS MS,ConvertToStrSafe(MaTaiKhoan*100000+MaKhachHang) AS SH,MaTaiKhoan,MaKhachHang FROM (SoDuKhachHang INNER JOIN KhachHang ON SoDuKhachHang.MaKhachHang=KhachHang.MaSo) INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo  WHERE LEFT(KhachHang.SoHieu,1)<>'#'{0}{1}", _
                            (IIf(shtk.Length > 0, " AND HethongTK.SoHieu LIKE '" & shtk & "%'", String.Empty)), _
                            (IIf(mpl > 0, " AND MaPhanLoai=" & mpl, String.Empty))))
        Dim rs As DataTable = ExecSQLReturnDT("BaoCaoCP")
        GauGe.Value = 1
        Dim rsIndex As Integer = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            SoDuKHNgay(rsItem("BC_ID"), ndau.AddDays(-1), dkno, dkco, X, rsItem("macha"))
            SoPhatSinhN(rsItem("BC_ID"), ndau, ncuoi, psn, psc, X, Y, rsItem("macha"))
            SoPhatSinhN(rsItem("BC_ID"), NgayDauThang(pNamTC, pThangDauKy), ncuoi, psnx, pscx, X, Y, rsItem("macha"))
            SoDuKHNgay(rsItem("BC_ID"), ncuoi, ckn, ckc, X, rsItem("macha"))
            ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP SET Kq1={0},Kq2={1},Kq3={2},Kq4={3},Kq5={4},Kq6={5},Kq7={6},Kq8={7} WHERE MaSo={8}", CStr(dkno), CStr(dkco), CStr(psn), CStr(psnx), CStr(psc), CStr(pscx), CStr(ckn), CStr(ckc), rsItem("MaSo")))
            ''rs.MoveNext()
        Loop
        ExecSQLNonQuery("DELETE  FROM BaoCaoCP WHERE Kq1=0 AND Kq2=0 AND Kq4=0 AND Kq6=0")
        'QTongHopCT
        Dim QChitiet As String = String.Format("SELECT DISTINCT KhachHang.SoHieu, KhachHang.Ten, PhanLoaiKhachHang.SoHieu AS SHPL, TenPhanLoai,KyHieu, Kq1 AS DkNo, Kq2 AS DkCo, 0 AS DkNT, Kq3 AS PsNo, 0 AS PsNo2, Kq5 AS PsCo, 0 AS PsCo2, Kq4 AS PsNoX, 0 AS PsNoX2, Kq6 AS PsCoX, 0 AS PsCoX2, Kq7 AS CkNo, Kq8 AS CkCo, 0 AS CkNT,PhanLoaiKhachHang.PLCha FROM ((KhachHang INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo) INNER JOIN BaoCaoCP ON KhachHang.MaSo=BaoCaoCP.BC_ID) LEFT JOIN NguyenTe ON KhachHang.MaNT=NguyenTe.MaSo  ORDER BY PhanLoaiKhachHang.Sohieu,KhachHang.SoHieu")
        Dim QSoCai As String = String.Format("SELECT QChitiet.*, PhanLoaiKhachHang.SoHieu AS SH2,PhanLoaiKhachHang.TenPhanLoai AS TenPhanLoai2,PhanLoaiKhachHang.PLCha AS PLCha2 FROM ({0}) AS QChitiet LEFT JOIN PhanLoaiKhachHang ON QChitiet.PLCha=PhanLoaiKhachHang.MaSo", QChitiet)
        Dim QTongHopCT As String = String.Format("SELECT QSoCai.*, PhanLoaiKhachHang.SoHieu AS SH1,PhanLoaiKhachHang.TenPhanLoai AS TenPhanLoai1 FROM ({0}) AS QSoCai LEFT JOIN PhanLoaiKhachHang ON QSoCai.PLCha2=PhanLoaiKhachHang.MaSo", QSoCai)
        GauGe.Value = 2
        rptFrom.InitForm(String.Format("THSDCN{0}.RPT", IIf(th <> 0, "1", String.Empty)), QTongHopCT, "QTongHopCT")
        RptSetDate(ncuoi)
        If shtk.Length > 0 Then
            rptFrom.SetFormulas("TenBaoCao", String.Format("'{0}{1} - {2}'", "Tài khoản: ", shtk, LbTenTk(7).Text))
        End If
        rptFrom.SetFormulas("Thoigian", String.Format("'{0}'", ThoiGianN(ndau, ncuoi, nn)))
        GauGe.Value = 3
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="mpl"></param>
    ''' <remarks></remarks>
    Public Sub BangCDCno(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef mpl As Integer)
        Dim st As String = String.Empty
        Dim sqlc2 As New StringBuilder
        Dim sqln2 As New StringBuilder
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        Dim sqlcx2 As New StringBuilder
        Dim sqlnx2 As New StringBuilder
        Dim sqlcx As New StringBuilder
        Dim sqlnx As New StringBuilder
        GauGe.Maximum = 3
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            If sqln.Length = 0 Then
                sqln.Append(String.Format("SoDuKhachHang.No_{0}", i))
            Else
                sqln.Append(String.Format(" + SoDuKhachHang.No_{0}", i))
            End If
            If sqlc.Length = 0 Then
                sqlc.Append(String.Format("SoDuKhachHang.Co_{0}", i))
            Else
                sqlc.Append(String.Format(" + SoDuKhachHang.Co_{0}", i))
            End If

            If sqln2.Length = 0 Then
                sqln2.Append(String.Format("SoDuKhachHang.No_{0}_NT", i))
            Else
                sqln2.Append(String.Format(" + SoDuKhachHang.No_{0}_NT", i))
            End If
            If sqlc2.Length = 0 Then
                sqlc2.Append(String.Format("SoDuKhachHang.Co_{0}_NT", i))
            Else
                sqlc2.Append(String.Format(" + SoDuKhachHang.Co_{0}_NT", i))
            End If
        Next
        For i As Integer = 1 To CThangDB2(tcuoi)
            If sqlnx.Length = 0 Then
                sqlnx.Append(String.Format("SoDuKhachHang.No_{0}", i))
            Else
                sqlnx.Append(String.Format(" + SoDuKhachHang.No_{0}", i))
            End If
            If sqlcx.Length = 0 Then
                sqlcx.Append(String.Format("SoDuKhachHang.Co_{0}", i))
            Else
                sqlcx.Append(String.Format(" + SoDuKhachHang.Co_{0}", i))
            End If

            If sqlnx2.Length = 0 Then
                sqlnx2.Append(String.Format("SoDuKhachHang.No_{0}_NT", i))
            Else
                sqlnx2.Append(String.Format(" + SoDuKhachHang.No_{0}_NT", i))
            End If
            If sqlcx2.Length = 0 Then
                sqlcx2.Append(String.Format("SoDuKhachHang.Co_{0}_NT", i))
            Else
                sqlcx2.Append(String.Format(" + SoDuKhachHang.Co_{0}_NT", i))
            End If
        Next
        GauGe.Value = 1
        st = ConvertToStrSafe(CThangDB2(ThangTruoc(tdau)))
        'Dim QChitiet As String = String.Format("SELECT DISTINCT KhachHang.SoHieu, KhachHang.Ten, PhanLoaiKhachHang.SoHieu AS SHPL, TenPhanLoai,KyHieu, SoDuKhachHang.DuNo_{0} AS DkNo, SoDuKhachHang.DuCo_{0} AS DkCo, SoDuKhachHang.DuNT_{0} AS DkNT, ({1}) AS PsNo, ({2}) AS PsNo2, ({3}) AS PsCo, ({4}) AS PsCo2, ({5}) AS PsNoX, ({6}) AS PsNoX2, ({7}) AS PsCoX, ({8}) AS PsCoX2, SoDuKhachHang.DuNo_{9} AS CkNo, SoDuKhachHang.DuCo_{9} AS CkCo, SoDuKhachHang.DuNT_{9} AS CkNT,PhanLoaiKhachHang.PLCha,HethongTK.SoHieu AS SHTK,HethongTK.Ten AS TenTK FROM (((KhachHang INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo) INNER JOIN SoDuKhachHang ON KhachHang.MaSo=SoDuKhachHang.MaKhachHang) LEFT JOIN NguyenTe ON KhachHang.MaNT=NguyenTe.MaSo) INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo  WHERE (SoDuKhachHang.DuNo_{0}<>0 OR SoDuKhachHang.DuCo_{0}<>0 OR ({5}) <>0 OR ({7}) <>0){10} AND LEFT(KhachHang.SoHieu,1)<>'#' ORDER BY PhanLoaiKhachHang.Sohieu,KhachHang.SoHieu", st, sqln, sqln2, sqlc, sqlc2, sqlnx, sqlnx2, sqlcx, sqlcx2, ConvertToStrSafe(CThangDB2(tcuoi)), (IIf(mpl > 0, " AND MaPhanLoai=" & mpl, String.Empty)))
        Dim QChitiet As String = String.Format("SELECT DISTINCT KhachHang.SoHieu, KhachHang.Ten, PhanLoaiKhachHang.SoHieu AS SHPL, TenPhanLoai,KyHieu, SoDuKhachHang.DuNo_{0} AS DkNo, SoDuKhachHang.DuCo_{0} AS DkCo, SoDuKhachHang.DuNT_{0} AS DkNT, ({1}) AS PsNo, ({2}) AS PsNo2, ({3}) AS PsCo, ({4}) AS PsCo2, ({5}) AS PsNoX, ({6}) AS PsNoX2, ({7}) AS PsCoX, ({8}) AS PsCoX2, SoDuKhachHang.DuNo_{9} AS CkNo, SoDuKhachHang.DuCo_{9} AS CkCo, SoDuKhachHang.DuNT_{9} AS CkNT,PhanLoaiKhachHang.PLCha,HethongTK.SoHieu AS SHTK,HethongTK.Ten AS TenTK FROM (((KhachHang INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo) INNER JOIN SoDuKhachHang ON KhachHang.MaSo=SoDuKhachHang.MaKhachHang) LEFT JOIN NguyenTe ON KhachHang.MaNT=NguyenTe.MaSo) INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo  WHERE (SoDuKhachHang.DuNo_{0}<>0 OR SoDuKhachHang.DuCo_{0}<>0 OR ({5}) <>0 OR ({7}) <>0){10} AND LEFT(KhachHang.SoHieu,1)<>'#' ", st, sqln, sqln2, sqlc, sqlc2, sqlnx, sqlnx2, sqlcx, sqlcx2, ConvertToStrSafe(CThangDB2(tcuoi)), (IIf(mpl > 0, " AND MaPhanLoai=" & mpl, String.Empty)))
        Dim QSoCai As String = String.Format("SELECT QChitiet.*, PhanLoaiKhachHang.SoHieu AS SH2,PhanLoaiKhachHang.TenPhanLoai AS TenPhanLoai2,PhanLoaiKhachHang.PLCha AS PLCha2 FROM ({0}) AS QChitiet LEFT JOIN PhanLoaiKhachHang ON QChitiet.PLCha=PhanLoaiKhachHang.MaSo", QChitiet)
        Dim QTongHopCT As String = String.Format("SELECT QSoCai.*, PhanLoaiKhachHang.SoHieu AS SH1,PhanLoaiKhachHang.TenPhanLoai AS TenPhanLoai1 FROM ({0}) AS QSoCai LEFT JOIN PhanLoaiKhachHang ON QSoCai.PLCha2=PhanLoaiKhachHang.MaSo", QSoCai)
        GauGe.Value = 2
        rptFrom.InitForm("THSDCNT.RPT", QTongHopCT, "QTongHopCT")
        rptFrom.SetFormulas("Thoigian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
    End Sub

    'Private Function THPSNhomCN2(ByRef ms As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer) As Boolean
    '    Dim result As Boolean = False
    '    Dim taikhoan As New ClsTaikhoan
    '    Dim psn2, psc2 As Double
    '    Dim kh As New clsKhachHang
    '    Dim ckc, psc, dknt, dkn, dkc, psn, ckn, cknt As Double
    '    Dim rs_tk As DataTable
    '    Dim sql, s As String
    '    'Dim inso As Boolean
    '    'Dim i, j As Integer
    '    kh.InitKhachHangMaSo(ms)
    '    ExecSQLNonQuery("DELETE  FROM BKNhomPS")
    '    Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT DISTINCT MaTaiKhoan FROM SoDuKhachHang WHERE MaKhachHang={0} GROUP BY MaTaiKhoan", ms))
    '    Dim rsIndex As Integer = 0
    '    Do While rsIndex < rs.Rows.Count
    '        Dim rsItem As DataRow = rs.Rows(rsIndex)
    '        rsIndex += 1 ' C15 Rs LOOP CONTROL
    '        taikhoan.InitTaikhoanMaSo(rsItem("MaTaiKhoan"))
    '        kh.SoDuKH(ThangTruoc(tdau), dkn, dkc, dknt, rsItem("MaTaiKhoan"))
    '        psn = 0
    '        psc = 0
    '        psn2 = 0
    '        psc2 = 0
    '        ExecSQLNonQuery(String.Format("INSERT INTO BKNhomPS (MaSo,MaCT,ShTK,SoPSNo,SoPSCo,DienGiai,SoPS2No,SoPS2Co) VALUES ({0},-1,'{1}',{2},{3},'{4}',{5},{6})", _
    '                            Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
    '                            taikhoan.sohieu, _
    '                            cstr(Math.Max(dkn - dkc, 0)), _
    '                            cstr(Math.Max(dkc - dkn, 0)), _
    '                            (IIf(pnn > 0, taikhoan.TenE, taikhoan.ten)), _
    '                            cstr(IIf(dkn - dkc > 0, dknt, 0)), _
    '                            cstr(IIf(dkc - dkn > 0, dknt, 0))))
    '        sql = String.Format("SELECT DISTINCT ChungTu.MaCT,ChungTu.SoHieu,ChungTu.NgayCT,ChungTu.DienGiai{0} AS DG,ChungTu.SoPS,CASE WHEN ({1}>0) THEN SoPS2No ELSE 0 END AS SoPS2N,CASE WHEN ({1}>0) THEN SoPS2Co ELSE 0 END AS SoPS2C,HethongTK.SoHieu As SHNo, HethongTK_1.SoHieu As SHCo,MaKH FROM HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK INNER JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo) ON HeThongTK_1.MaSo = ChungTu.MaTKCo WHERE (MaTKNo={2}) AND (MaKH={3}) AND {4} AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco)) ORDER BY ChungTu.NgayCT, ChungTu.MaCT", _
    '                  (IIf(pnn > 0, "E", String.Empty)), _
    '                  ConvertToStrSafe(kh.MaNT), _
    '                  rsItem("MaTaiKhoan"), _
    '                  ConvertToStrSafe(kh.MaSo), _
    '                  WThang("ThangCT", tdau, tcuoi))
    '        rs_tk = ExecSQLReturnDT(sql)
    '        Dim rs_tkIndex As Integer = 0
    '        Do While rs_tkIndex < rs_tk.Rows.Count
    '            Dim rs_tkItem As DataRow = rs_tk.Rows(rs_tkIndex)
    '            rs_tkIndex += 1 ' C15 Rs LOOP CONTROL
    '            psn += rs_tkItem("sops")
    '            psn2 += rs_tkItem("SoPS2N")
    '            s = IIf(IsDBNull(rs_tkItem("shco")), "...", rs_tkItem("shco"))

    '            ExecSQLNonQuery(String.Format("INSERT INTO BKNhomPS (MaSo,MaCT,ShTK,SoPSNo,Ngay,SoHieu,DienGiai,ShDu,SoPS2No) VALUES ({0},{1},'{2}',{3},'{4}','{5}','{6}','{7}',{8})", _
    '                                Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
    '                                ConvertToStrSafe(rsItem("MaCT")), _
    '                                taikhoan.sohieu, _
    '                                cstr(rs_tkItem("sops")), _
    '                                Format(rs_tkItem("NgayCT"), Mask_DB), _
    '                                ConvertToStrSafe(rsItem("SoHieu")), _
    '                                ConvertToStrSafe(rsItem("dg")), _
    '                                s, _
    '                                cstr(rs_tkItem("SoPS2N"))))
    '            'rs_tk.MoveNext()
    '        Loop
    '        sql = "SELECT DISTINCT ChungTu.MaCT,ChungTu.SoHieu,ChungTu.NgayCT,ChungTu.DienGiai" & (IIf(pnn > 0, "E", String.Empty)) & " AS DG,ChungTu.SoPS,CASE WHEN (" & ConvertToStrSafe(kh.MaNT) & ">0) THEN SoPS2No ELSE 0 END AS SoPS2N, CASE WHEN (" & ConvertToStrSafe(kh.MaNT) & ">0) THEN SoPS2Co ELSE 0 END AS SoPS2C,HethongTK.SoHieu As SHNo, HethongTK_1.SoHieu As SHCo,MaKH,MaKHC" & " FROM HeThongTK AS HeThongTK_1 INNER JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo) ON HeThongTK_1.MaSo = ChungTu.MaTKCo" & " WHERE (MaTKCo=" & rsItem("MaTaiKhoan") & ") AND (MaKHC=" & ConvertToStrSafe(kh.MaSo) & ") AND " & WThang("ThangCT", tdau, tcuoi) & " AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco)) ORDER BY ChungTu.NgayCT, ChungTu.MaCT"
    '        rs_tk = ExecSQLReturnDT(sql)
    '        rs_tkIndex = 0
    '        Do While rs_tkIndex < rs_tk.Rows.Count
    '            Dim rs_tkItem As DataRow = rs_tk.Rows(rs_tkIndex)
    '            rs_tkIndex += 1 ' C15 Rs LOOP CONTROL
    '            psc += rs_tkItem("sops")
    '            psc2 += rs_tkItem("SoPS2C")
    '            s = IIf(IsDBNull(rs_tkItem("shno")), "...", rs_tkItem("shno"))

    '            ExecSQLNonQuery(ConvertToDblSafe(String.Format("INSERT INTO BKNhomPS (MaSo,MaCT,ShTK,SoPSCo,Ngay,SoHieu,DienGiai,ShDu,SoPS2Co) VALUES ({0},{1},'{2}',{3},'{4}','", _
    '                                     Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
    '                                     ConvertToStrSafe(rsItem("MaCT")), _
    '                                     taikhoan.sohieu, _
    '                                     cstr(rs_tkItem("sops")), _
    '                                     Format(rs_tkItem("NgayCT"), Mask_DB))) + ConvertToStrSafe(rsItem("SoHieu")) + "','" + ConvertToStrSafe(rsItem("dg")) + "','" + s + "'," + cstr(rs_tkItem("SoPS2C")) + ")")
    '            'rs_tk.MoveNext()
    '        Loop
    '        ckn = dkn - dkc + psn - psc
    '        If ckn > 0 Then
    '            ckc = 0
    '        Else
    '            ckc = -ckn
    '            ckn = 0
    '        End If
    '        cknt = IIf(ckc - ckn < 0, dknt + psn2 - psc2, dknt - psn2 + psc2)
    '        ExecSQLNonQuery(String.Format("INSERT INTO BKNhomPS (MaSo,MaCT,ShTK,SoPSNo,SoPSCo,DienGiai,SoPS2No,SoPS2Co) VALUES ({0},0,'{1}',{2},{3},'{4}',{5},{6})", _
    '                            Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
    '                            taikhoan.sohieu, _
    '                            cstr(Math.Max(ckn - ckc, 0)), _
    '                            cstr(Math.Max(ckc - ckn, 0)), _
    '                            (IIf(pnn > 0, taikhoan.TenE, taikhoan.ten)), _
    '                            cstr(IIf(ckn - ckc > 0, cknt, 0)), _
    '                            cstr(IIf(ckc - ckn > 0, cknt, 0))))
    '        If dkn = 0 And dkc = 0 And psn = 0 And psc = 0 And psn2 = 0 And psc2 = 0 Then ExecSQLNonQuery("DELETE  FROM BKNhomPS WHERE ShTK='" & kh.SoHieu & "'")
    '        ''rs.MoveNext()
    '    Loop
    '    result = (rs.Rows.Count > 0)
    '    ''rs.Close()
    '    rs = Nothing
    '    rptFrom.InitForm("THPSCT.RPT", "SELECT * FROM BKNhomPS", "BKNhomPS")
    '    rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", thoigiantheothang(tdau, tcuoi, nn)))
    '    rptFrom.SetFormulas("TK", String.Format("'{0} - {1}'", kh.SoHieu, kh.Ten))
    '    rptFrom.SetFormulas("TenBaoCao='Sổ chi tiết đối tượng thanh toán'")
    '    RptSetDate(NgayCuoiThang(pNamTC, tcuoi), nn)
    '    Return result
    'End Function
    Private Function THPSNhomCN2(ByRef ms As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer) As Boolean
        Dim result As Boolean = False
        Dim taikhoan As New ClsTaikhoan
        Dim psn2, psc2 As Double
        Dim kh As New clsKhachHang
        Dim ckc, psc, dknt, dkn, dkc, psn, ckn, cknt As Double
        Dim rs_tk As DataTable
        Dim sql, s As String
        'Dim inso As Boolean
        'Dim i, j As Integer
        kh.InitKhachHangMaSo(ms)
        ExecSQLNonQuery("DELETE  FROM BKNhomPS")
        Dim TAM As String = String.Format("SELECT DISTINCT MaTaiKhoan FROM SoDuKhachHang WHERE MaKhachHang={0} GROUP BY MaTaiKhoan", ms)
        Dim rs As DataTable = ExecSQLReturnDT(TAM)
        Dim rsIndex As Integer = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            taikhoan.InitTaikhoanMaSo(rsItem("MaTaiKhoan"))
            kh.SoDuKH(ThangTruoc(tdau), dkn, dkc, dknt, rsItem("MaTaiKhoan"))
            psn = 0
            psc = 0
            psn2 = 0
            psc2 = 0
            Dim TAM1 As String = String.Format("INSERT INTO BKNhomPS (MaCT,ShTK,SoPSNo,SoPSCo,DienGiai,SoPS2No,SoPS2Co) VALUES (-1,'{1}',{2},{3},N'{4}',{5},{6})", _
                                Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
                                taikhoan.sohieu, _
                                CStr(Math.Max(dkn - dkc, 0)), _
                                CStr(Math.Max(dkc - dkn, 0)), _
                                (IIf(pnn > 0, taikhoan.TenE, taikhoan.ten)), _
                                CStr(IIf(dkn - dkc > 0, dknt, 0)), _
                                CStr(IIf(dkc - dkn > 0, dknt, 0)))
            ExecSQLNonQuery(TAM1)
            sql = String.Format("SELECT DISTINCT ChungTu.MaCT,ChungTu.SoHieu,ChungTu.NgayCT,ChungTu.DienGiai{0} AS DG,ChungTu.SoPS,CASE WHEN ({1}>0) THEN SoPS2No ELSE 0 END AS SoPS2N,CASE WHEN ({1}>0) THEN SoPS2Co ELSE 0 END AS SoPS2C,HethongTK.SoHieu As SHNo, HethongTK_1.SoHieu As SHCo,MaKH FROM HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK INNER JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo) ON HeThongTK_1.MaSo = ChungTu.MaTKCo WHERE (MaTKNo={2}) AND (MaKH={3}) AND {4} AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco)) ORDER BY ChungTu.NgayCT, ChungTu.MaCT", _
                      (IIf(pnn > 0, "E", String.Empty)), _
                      ConvertToStrSafe(kh.MaNT), _
                      rsItem("MaTaiKhoan"), _
                      ConvertToStrSafe(kh.MaSo), _
                      WThang("ThangCT", tdau, tcuoi))
            rs_tk = ExecSQLReturnDT(sql)
            Dim rs_tkIndex As Integer = 0
            Do While rs_tkIndex < rs_tk.Rows.Count
                Dim rs_tkItem As DataRow = rs_tk.Rows(rs_tkIndex)
                rs_tkIndex += 1 ' C15 Rs LOOP CONTROL
                psn += rs_tkItem("sops")
                psn2 += rs_tkItem("SoPS2N")
                s = IIf(IsDBNull(rs_tkItem("shco")), "...", rs_tkItem("shco"))

                Dim TAM2 As String = (String.Format("INSERT INTO BKNhomPS (MaCT,ShTK,SoPSNo,Ngay,SoHieu,DienGiai,ShDu,SoPS2No) VALUES ({1},'{2}',{3},'{4}','{5}',N'{6}','{7}',{8})", _
                                    Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
                                    ConvertToStrSafe(rs_tkItem("MaCT")), _
                                    taikhoan.sohieu, _
                                    rs_tkItem("sops"), _
                                    Format(CDate(rs_tkItem("NgayCT")), Mask_DB), _
                                    ConvertToStrSafe(rs_tkItem("SoHieu")), _
                                    ConvertToStrSafe(rs_tkItem("dg")), _
                                    s, _
                                    CStr(rs_tkItem("SoPS2N"))))
                ExecSQLNonQuery(TAM2)
                'rs_tk.MoveNext()
            Loop
            sql = "SELECT DISTINCT ChungTu.MaCT,ChungTu.SoHieu,ChungTu.NgayCT,ChungTu.DienGiai" & (IIf(pnn > 0, "E", String.Empty)) & " AS DG,ChungTu.SoPS,CASE WHEN (" & ConvertToStrSafe(kh.MaNT) & ">0) THEN SoPS2No ELSE 0 END AS SoPS2N, CASE WHEN (" & ConvertToStrSafe(kh.MaNT) & ">0) THEN SoPS2Co ELSE 0 END AS SoPS2C,HethongTK.SoHieu As SHNo, HethongTK_1.SoHieu As SHCo,MaKH,MaKHC FROM HeThongTK AS HeThongTK_1 INNER JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo) ON HeThongTK_1.MaSo = ChungTu.MaTKCo" & " WHERE (MaTKCo=" & rsItem("MaTaiKhoan") & ") AND (MaKHC=" & ConvertToStrSafe(kh.MaSo) & ") AND " & WThang("ThangCT", tdau, tcuoi) & " AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco)) ORDER BY ChungTu.NgayCT, ChungTu.MaCT"
            rs_tk = ExecSQLReturnDT(sql)
            rs_tkIndex = 0
            Do While rs_tkIndex < rs_tk.Rows.Count
                Dim rs_tkItem As DataRow = rs_tk.Rows(rs_tkIndex)
                rs_tkIndex += 1 ' C15 Rs LOOP CONTROL
                psc += rs_tkItem("sops")
                psc2 += rs_tkItem("SoPS2C")
                s = IIf(IsDBNull(rs_tkItem("shno")), "...", rs_tkItem("shno"))
                sql = String.Format("INSERT INTO BKNhomPS (MaCT,ShTK,SoPSCo,Ngay,SoHieu,DienGiai,ShDu,SoPS2Co) VALUES ({1},'{2}',{3},'{4}','", _
                                         Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
                                         ConvertToStrSafe(rs_tkItem("MaCT")), _
                                         taikhoan.sohieu, _
                                         rs_tkItem("sops"), _
                                         Format(CDate(rs_tkItem("NgayCT")), Mask_DB)) + ConvertToStrSafe(rs_tkItem("SoHieu")) + "','" + ConvertToStrSafe(rs_tkItem("dg")) + "','" + s + "'," + CStr(rs_tkItem("SoPS2C")) + ")"
                ExecSQLNonQuery(sql)
                'rs_tk.MoveNext()
            Loop
            ckn = dkn - dkc + psn - psc
            If ckn > 0 Then
                ckc = 0
            Else
                ckc = -ckn
                ckn = 0
            End If
            cknt = IIf(ckc - ckn < 0, dknt + psn2 - psc2, dknt - psn2 + psc2)
            Dim TAM3 As String = (String.Format("INSERT INTO BKNhomPS (MaCT,ShTK,SoPSNo,SoPSCo,DienGiai,SoPS2No,SoPS2Co) VALUES (0,'{1}',{2},{3},N'{4}',{5},{6})", _
                                Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
                                taikhoan.sohieu, _
                                CStr(Math.Max(ckn - ckc, 0)), _
                                CStr(Math.Max(ckc - ckn, 0)), _
                                (IIf(pnn > 0, taikhoan.TenE, taikhoan.ten)), _
                                CStr(IIf(ckn - ckc > 0, cknt, 0)), _
                                CStr(IIf(ckc - ckn > 0, cknt, 0))))
            ExecSQLNonQuery(TAM3)
            If dkn = 0 And dkc = 0 And psn = 0 And psc = 0 And psn2 = 0 And psc2 = 0 Then ExecSQLNonQuery("DELETE  FROM BKNhomPS WHERE ShTK='" & kh.SoHieu & "'")
            ''rs.MoveNext()
        Loop
        result = (rs.Rows.Count > 0)
        ''rs.Close()
        rs = Nothing
        rptFrom.InitForm("THPSCT.RPT", "SELECT * FROM BKNhomPS", "BKNhomPS")
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        rptFrom.SetFormulas("TK", String.Format("'{0} - {1}'", kh.SoHieu, kh.Ten))
        rptFrom.SetFormulas("TenBaoCao='Sổ chi tiết đối tượng thanh toán'")
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        Return result
    End Function
    Private Sub FrmSoCongNo_DoubleClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.DoubleClick
        FThuChi.Tag = ConvertToStrSafe(10)
        FThuChi.GetPhieu(NLB, KTT, GD, 0)
        Interaction.SaveSetting(IniPath, "Environment", "SReport1", NLB)
        Interaction.SaveSetting(IniPath, "Environment", "SReport2", KTT)
        Interaction.SaveSetting(IniPath, "Environment", "SReport3", GD)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <param name="shtk"></param>
    ''' <param name="mpl"></param>
    ''' <remarks></remarks>
    Private Sub InCongNoQuaHanMuc(ByRef thang As Integer, ByRef shtk As String, ByRef mpl As Integer)
        Dim st As String = ConvertToStrSafe(CThangDB2(thang))
        Dim QChitiet As String = String.Format("SELECT DISTINCT KhachHang.SoHieu, KhachHang.Ten, PhanLoaiKhachHang.SoHieu AS SHPL, TenPhanLoai,KyHieu, Sum(SoDuKhachHang.DuNo_{0}) AS CkNo, Sum(SoDuKhachHang.DuCo_{0}) AS CkCo, Sum(SoDuKhachHang.DuNT_{0}) AS CkNT,PhanLoaiKhachHang.PLCha, (HethongTK.Kieu) AS LoaiNo, (KhachHang.DuMax) AS HM FROM (((KhachHang INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo) INNER JOIN SoDuKhachHang ON KhachHang.MaSo=SoDuKhachHang.MaKhachHang) INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo) LEFT JOIN NguyenTe ON KhachHang.MaNT=NguyenTe.MaSo  WHERE  KhachHang.DuMax>0 AND LEFT(KhachHang.SoHieu,1)<>'#' {1}{2} AND ((HethongTK.Kieu<0 AND (SoDuKhachHang.DuNo_{0}-SoDuKhachHang.DuCo_{0})>KhachHang.DuMax) OR (HethongTK.Kieu>0 AND (SoDuKhachHang.DuCo_{0}-SoDuKhachHang.DuNo_{0})>KhachHang.DuMax)) GROUP BY HethongTK.MaSo,PhanLoaiKhachHang.Sohieu,KhachHang.SoHieu,KhachHang.Ten,TenPhanLoai,KyHieu,PLCha,HeThongTK.Kieu,KhachHang.DuMax", _
                                     st, _
                                     (IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty)), _
                                     (IIf(mpl > 0, String.Format(" AND MaPhanLoai={0}", mpl), String.Empty)))
        Dim QSoCai As String = String.Format("SELECT QChitiet.*, PhanLoaiKhachHang.SoHieu AS SH2,PhanLoaiKhachHang.TenPhanLoai AS TenPhanLoai2,PhanLoaiKhachHang.PLCha AS PLCha2 FROM ({0}) AS QChitiet LEFT JOIN PhanLoaiKhachHang ON QChitiet.PLCha=PhanLoaiKhachHang.MaSo", QChitiet)
        Dim QTongHopCT As String = String.Format("SELECT QSoCai.*, PhanLoaiKhachHang.SoHieu AS SH1,PhanLoaiKhachHang.TenPhanLoai AS TenPhanLoai1 FROM ({0}) AS QSoCai LEFT JOIN PhanLoaiKhachHang ON QSoCai.PLCha2=PhanLoaiKhachHang.MaSo", QSoCai)
        GauGe.Value = 2

        rptFrom.InitForm("SDCNQH.RPT", QTongHopCT, "QTongHopCT")
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(thang, thang)))
        RptSetDate(NgayCuoiThang(pNamTC, thang))
        If shtk.Length > 0 Then
            rptFrom.SetFormulas("TenBaoCao", String.Format("'Tài khoản: {0} - {1}'", shtk, LbTenTk(7).Text))
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="taikhoan"></param>
    ''' <param name="mpl"></param>
    ''' <remarks></remarks>
    Private Sub InBangThopCN_HN(ByRef ndau As Date, ByRef ncuoi As Date, ByRef taikhoan As ClsTaikhoan, ByRef mpl As Integer)
        Dim sql As String = String.Empty
        Dim TK As New ClsTaikhoan
        TinhCongNo(ncuoi, taikhoan, 0)
        Dim MienTru As String
        Dim QCdt As String
        If taikhoan.tk_id = TKCNPT_ID Then
            MienTru = String.Format("SELECT MaCT FROM ChungTu2  WHERE MaKHC>0 AND NgayGS>='{0}' AND NgayGS<='{1}' GROUP BY MaCT", Format(ndau, Mask_DB), Format(ncuoi, Mask_DB))
            QCdt = String.Format("SELECT MaKHC AS MaKH, HanTT AS HTT, NgayCT, Sum(SoPS-SoXuat) AS DuNo FROM (ChungTu2 INNER JOIN HethongTK ON ChungTu2.MaTKCo=HethongTK.MaSo) INNER JOIN ({0}) AS MienTru ON ChungTu2.MaCT=MienTru.MaCT WHERE HethongTK.Kieu>0 AND HethongTK.SoHieu LIKE '{1}%' GROUP BY MaKHC, HanTT, NgayCT  HAVING Sum(SoPS-SoXuat)>0  UNION SELECT MaKhachHang,HanTT AS HTT, ('01/01/1980') AS NgayCT,Sum(CNDauNam2.DuCo_0-SoXuat) AS DuNo FROM CNDauNam2 INNER JOIN HethongTK ON CNDauNam2.MaTaiKhoan=HethongTK.MaSo  WHERE HethongTK.Kieu>0 AND HethongTK.SoHieu LIKE '{1}%' AND CNDauNam2.DuCo_0-SoXuat>0 GROUP BY MaKhachHang, HanTT", MienTru, taikhoan.sohieu)
        Else
            MienTru = String.Format("SELECT MaCT FROM ChungTu2 WHERE MaKH>0 AND NgayGS>='{0}' AND NgayGS<='{1}' GROUP BY MaCT", Format(ndau, Mask_DB), Format(ncuoi, Mask_DB))
            QCdt = String.Format("SELECT MaKH, HanTT AS HTT, NgayCT, Sum(SoPS-SoXuat) AS DuNo FROM (ChungTu2 INNER JOIN HethongTK ON ChungTu2.MaTKNo=HethongTK.MaSo) INNER JOIN ({0}) AS MienTru ON ChungTu2.MaCT=MienTru.MaCT WHERE HethongTK.Kieu<0 AND HethongTK.SoHieu LIKE '{1}%' GROUP BY MaKH, HanTT, NgayCT HAVING Sum(SoPS-SoXuat)>0  UNION SELECT MaKhachHang,HanTT AS HTT, '01/01/1980' AS NgayCT,Sum(CNDauNam2.DuNo_0-SoXuat) AS DuNo FROM CNDauNam2 INNER JOIN HethongTK ON CNDauNam2.MaTaiKhoan=HethongTK.MaSo  WHERE HethongTK.Kieu<0 AND HethongTK.SoHieu LIKE '{1}%' AND CNDauNam2.DuNo_0-SoXuat>0 GROUP BY MaKhachHang, HanTT", MienTru, taikhoan.sohieu)
        End If

        Dim QChitiet As String = String.Format("SELECT DISTINCT KhachHang.SoHieu, KhachHang.Ten, PhanLoaiKhachHang.SoHieu AS SHPL, TenPhanLoai, QCdt.NgayCT, HTT, DuNo, PhanLoaiKhachHang.PLCha FROM (KhachHang INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo) INNER JOIN (" & QCdt & ") as QCdt ON KhachHang.MaSo=QCdt.MaKH  WHERE (1=1) {0} GROUP BY PhanLoaiKhachHang.Sohieu,KhachHang.SoHieu,KhachHang.Ten,TenPhanLoai,PLCha,NgayCT,HTT,DuNo", (IIf(mpl > 0, " AND MaPhanLoai=" & mpl, String.Empty)))
        Dim QSoCai As String = String.Format("SELECT QChitiet.*, PhanLoaiKhachHang.SoHieu AS SH2,PhanLoaiKhachHang.TenPhanLoai AS TenPhanLoai2,PhanLoaiKhachHang.PLCha AS PLCha2 FROM ({0}) AS QChitiet LEFT JOIN PhanLoaiKhachHang ON QChitiet.PLCha=PhanLoaiKhachHang.MaSo", QChitiet)
        Dim QTongHopCT As String = String.Format("SELECT QSoCai.*, PhanLoaiKhachHang.SoHieu AS SH1,PhanLoaiKhachHang.TenPhanLoai AS TenPhanLoai1 FROM ({0}) AS QSoCai LEFT JOIN PhanLoaiKhachHang ON QSoCai.PLCha2=PhanLoaiKhachHang.MaSo", QSoCai)

        rptFrom.InitForm("THSDCN5.RPT", QTongHopCT, "QTongHopCT")
        rptFrom.SetFormulas("ThoiGian", String.Format("'Từ ngày {0} đến ngày {1}'", Format(ndau, Mask_DB), Format(ncuoi, Mask_DB)))
        rptFrom.SetFormulas("Ngay1", String.Format("Date({0},{1},{2})", ncuoi.Year, ConvertToStrSafe(ncuoi.Month), ConvertToStrSafe(DateAndTime.Day(ncuoi))))
        RptSetDate(ncuoi)
        If taikhoan.sohieu <> "" Then
            rptFrom.SetFormulas("TenBaoCao", String.Format("'Tài khoản: {0} - {1}'", taikhoan.sohieu, LbTenTk(7).Text))
        End If
    End Sub

    Private Sub DuPhongPhaiThu(ByRef ndau As Date, ByRef ncuoi As Date, ByRef taikhoan As ClsTaikhoan, ByRef mpl As Integer)
        Dim sql As String = String.Empty
        Dim TK As New ClsTaikhoan
        TinhCongNo(ncuoi, taikhoan, 0)
        Dim MienTru As String
        Dim QCdt As String
        If taikhoan.tk_id = TKCNPT_ID Then
            MienTru = String.Format("SELECT MaCT FROM ChungTu2  WHERE MaKHC>0 AND NgayGS>='{0}' AND NgayGS<='{1}' GROUP BY MaCT", Format(ndau, Mask_DB), Format(ncuoi, Mask_DB))
            QCdt = String.Format("SELECT MaKHC AS MaKH, HanTT AS HTT, NgayCT, Sum(SoPS-SoXuat) AS DuNo, NgayNo FROM (ChungTu2 INNER JOIN HethongTK ON ChungTu2.MaTKCo=HethongTK.MaSo) INNER JOIN ({0}) AS MienTru ON ChungTu2.MaCT=MienTru.MaCT WHERE HethongTK.Kieu>0 AND HethongTK.SoHieu LIKE '{1}%' GROUP BY MaKHC, HanTT, NgayCT, NgayNo  HAVING Sum(SoPS-SoXuat)>0  UNION SELECT MaKhachHang,HanTT AS HTT, '01/01/1980' AS NgayCT,Sum(CNDauNam2.DuCo_0-SoXuat) AS DuNo, '01/01/1980' AS NgayNo FROM CNDauNam2 INNER JOIN HethongTK ON CNDauNam2.MaTaiKhoan=HethongTK.MaSo  WHERE HethongTK.Kieu>0 AND HethongTK.SoHieu LIKE '{1}%' AND CNDauNam2.DuCo_0-SoXuat>0 GROUP BY MaKhachHang, HanTT", MienTru, taikhoan.sohieu)
        Else
            MienTru = String.Format("SELECT MaCT FROM ChungTu2 WHERE MaKH>0 AND NgayGS>='{0}' AND NgayGS<='{1}' GROUP BY MaCT", Format(ndau, Mask_DB), Format(ncuoi, Mask_DB))
            QCdt = String.Format("SELECT MaKH, HanTT AS HTT, NgayCT, Sum(SoPS-SoXuat) AS DuNo, NgayNo FROM (ChungTu2 INNER JOIN HethongTK ON ChungTu2.MaTKNo=HethongTK.MaSo) INNER JOIN ({0}) AS MienTru ON ChungTu2.MaCT=MienTru.MaCT WHERE HethongTK.Kieu<0 AND HethongTK.SoHieu LIKE '{1}%' GROUP BY MaKH, HanTT, NgayCT,NgayNo HAVING Sum(SoPS-SoXuat)>0  UNION SELECT MaKhachHang,HanTT AS HTT, '01/01/1980' AS NgayCT,Sum(CNDauNam2.DuNo_0-SoXuat) AS DuNo, '01/01/1980' AS NgayNo FROM CNDauNam2 INNER JOIN HethongTK ON CNDauNam2.MaTaiKhoan=HethongTK.MaSo  WHERE HethongTK.Kieu<0 AND HethongTK.SoHieu LIKE '{1}%' AND CNDauNam2.DuNo_0-SoXuat>0 GROUP BY MaKhachHang, HanTT", MienTru, taikhoan.sohieu)
        End If

        Dim QChitiet As String = String.Format("SELECT DISTINCT KhachHang.SoHieu, KhachHang.Ten, PhanLoaiKhachHang.SoHieu AS SHPL, TenPhanLoai, QCdt.NgayCT, HTT, DuNo, PhanLoaiKhachHang.PLCha,NgayNo FROM (KhachHang INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo) INNER JOIN (" & QCdt & ") as QCdt ON KhachHang.MaSo=QCdt.MaKH  WHERE (1=1) {0} GROUP BY PhanLoaiKhachHang.Sohieu,KhachHang.SoHieu,KhachHang.Ten,TenPhanLoai,PLCha,NgayCT,HTT,DuNo,NgayNo", (IIf(mpl > 0, " AND MaPhanLoai=" & mpl, String.Empty)))
        Dim QSoCai As String = String.Format("SELECT QChitiet.*, PhanLoaiKhachHang.SoHieu AS SH2,PhanLoaiKhachHang.TenPhanLoai AS TenPhanLoai2,PhanLoaiKhachHang.PLCha AS PLCha2 FROM ({0}) AS QChitiet LEFT JOIN PhanLoaiKhachHang ON QChitiet.PLCha=PhanLoaiKhachHang.MaSo", QChitiet)
        Dim QTongHopCT As String = String.Format("SELECT QSoCai.*, PhanLoaiKhachHang.SoHieu AS SH1,PhanLoaiKhachHang.TenPhanLoai AS TenPhanLoai1 FROM ({0}) AS QSoCai LEFT JOIN PhanLoaiKhachHang ON QSoCai.PLCha2=PhanLoaiKhachHang.MaSo", QSoCai)

        rptFrom.InitForm("DuPhongNoPhaiThu.RPT", QTongHopCT, "QTongHopCT")
        rptFrom.SetFormulas("Thangdau", ndau.Month)
        rptFrom.SetFormulas("Thangcuoi", ncuoi.Month)
        rptFrom.SetFormulas("ThoiGian", String.Format("'Từ ngày {0} đến ngày {1}'", Format(ndau, Mask_DB), Format(ncuoi, Mask_DB)))
        rptFrom.SetFormulas("Ngay1", String.Format("{0:dd/MM/yyyy}", ncuoi))
        RptSetDate(ncuoi)
        If taikhoan.sohieu <> "" Then
            rptFrom.SetFormulas("TenBaoCao", String.Format("'Tài khoản: {0} - {1}'", taikhoan.sohieu, LbTenTk(7).Text))
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mcn"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="taikhoan"></param>
    ''' <remarks></remarks>
    Private Sub InChitietCN_HN(ByRef mcn As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef taikhoan As ClsTaikhoan)
        Dim sql As String = String.Empty
        TinhCongNo(ncuoi, taikhoan, mcn)
        Dim MienTru As String
        Dim QCdt As String
        If taikhoan.tk_id = TKCNPT_ID Then
            MienTru = String.Format("SELECT MaCT FROM ChungTu2 WHERE MaKHC={0} AND NgayGS>='{1}' AND NgayGS<='{2}' GROUP BY MaCT", _
                          mcn, _
                          Format(ndau, Mask_DB), _
                          Format(ncuoi, Mask_DB))
            QCdt = String.Format("SELECT ChungTu2.SoHieu, NgayCT, DienGiai, (HanTT) AS HTT, Sum(SoPS-SoXuat) AS DuNo FROM (ChungTu2 INNER JOIN HethongTK ON ChungTu2.MaTKCo=HethongTK.MaSo) INNER JOIN ({0}) AS MienTru ON ChungTu2.MaCT=MienTru.MaCT WHERE HethongTK.Kieu>0 AND HethongTK.SoHieu LIKE '{1}%' GROUP BY ChungTu2.SoHieu, NgayCT, DienGiai HAVING Sum(SoPS-SoXuat)>0 UNION SELECT 'DK' AS SH, '01/01/1980' AS NgayCT, '{2}',HanTT AS HTT,(CNDauNam2.DuCo_0-SoXuat) AS DuNo FROM CNDauNam2 INNER JOIN HethongTK ON CNDauNam2.MaTaiKhoan=HethongTK.MaSo  WHERE HethongTK.Kieu>0 AND HethongTK.SoHieu LIKE '{1}%' AND CNDauNam2.DuCo_0-SoXuat>0 AND MaKhachHang={3}", _
                       MienTru, _
                       taikhoan.sohieu, _
                       ("Nợ đầu năm"), _
                       ConvertToStrSafe(mcn))
        Else
            MienTru = String.Format("SELECT MaCT FROM ChungTu2 WHERE MaKH={0} AND NgayGS>='{1}' AND NgayGS<='{2}' GROUP BY MaCT", _
                          mcn, _
                          Format(ndau, Mask_DB), _
                          Format(ncuoi, Mask_DB))
            QCdt = String.Format("SELECT ChungTu2.SoHieu, NgayCT, DienGiai, (HanTT) AS HTT, Sum(SoPS-SoXuat) AS DuNo FROM (ChungTu2 INNER JOIN HethongTK ON ChungTu2.MaTKNo=HethongTK.MaSo) INNER JOIN ({0}) AS MienTru ON ChungTu2.MaCT=MienTru.MaCT WHERE HethongTK.Kieu<0 AND HethongTK.SoHieu LIKE '{1}%' GROUP BY ChungTu2.SoHieu,ChungTu2.HanTT, NgayCT, DienGiai HAVING Sum(SoPS-SoXuat)>0 UNION SELECT 'DK' AS SH, '01/01/1980' AS NgayCT, '{2}',HanTT AS HTT,(CNDauNam2.DuNo_0-SoXuat) AS DuNo FROM CNDauNam2 INNER JOIN HethongTK ON CNDauNam2.MaTaiKhoan=HethongTK.MaSo  WHERE HethongTK.Kieu<0 AND HethongTK.SoHieu LIKE '{1}%' AND CNDauNam2.DuNo_0-SoXuat>0 AND MaKhachHang={3}", _
                       MienTru, _
                       taikhoan.sohieu, _
                       ("Nợ đầu năm"), _
                       ConvertToStrSafe(mcn))
        End If
        QCdt = String.Format("SELECT * FROM ({0}) AS QCdt ORDER BY NgayCT", QCdt)
        rptFrom.InitForm("CTCN5.RPT", QCdt, "QTongHopCT")
        rptFrom.SetFormulas("ThoiGian", String.Format("'Từ ngày {0} đến ngày {1}'", Format(ndau, Mask_DB), Format(ncuoi, Mask_DB)))
        rptFrom.SetFormulas("Ngay1", String.Format("'{0:dd/MM/yyyy}'", ncuoi))
        RptSetDate(ncuoi)
        If taikhoan.sohieu <> "" Then
            rptFrom.SetFormulas("TenBaoCao", String.Format("'Tài khoản: {0} - {1}'", taikhoan.sohieu, taikhoan.ten))
        End If
        rptFrom.SetFormulas("DG", String.Format("'{0}: {1}'", MaSo2SoHieu(mcn, "KhachHang"), TenKH("", mcn)))
    End Sub

    Private Sub TinhCongNo(ByRef ncuoi As Date, ByRef TK As ClsTaikhoan, ByRef mkh As Integer)
        Dim m As Integer
        XoaBang("ChungTu2")
        CopyTable2("ChungTu", "ChungTu2")
        KtraCongNo()
        ExecSQLNonQuery("DELETE  FROM CNDauNam2")
        ExecSQLNonQuery(String.Format("INSERT INTO CNDauNam2 SELECT CNDauNam.* FROM CNDauNam INNER JOIN HethongTK ON CNDauNam.MaTaiKhoan=HethongTK.MaSo WHERE (1=1) {0}{1}", (IIf(TK.maso > 0, " AND HethongTK.SoHieu LIKE '" & TK.sohieu & "%'", String.Empty)), (IIf(mkh > 0, " AND MaKhachHang=" & mkh, String.Empty))))
        ExecSQLNonQuery(String.Format("INSERT INTO ChungTu2 SELECT ChungTu.* FROM ChungTu INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE (TK_ID={0} OR TK_ID={1}) AND NgayGS<='{2}'{3}{4}", TKCNKH_ID, ConvertToStrSafe(TKCNPT_ID), Format(ncuoi, Mask_DB), (IIf(mkh > 0, " AND (MaKH=" & mkh & " OR MaKHC=" & ConvertToStrSafe(mkh) & ")", String.Empty)), (IIf(TK.maso > 0, " AND HethongTK.SoHieu LIKE '" & TK.sohieu & "%'", String.Empty))))
        ExecSQLNonQuery(String.Format("INSERT INTO ChungTu2 SELECT ChungTu.* FROM (ChungTu INNER JOIN HethongTK ON ChungTu.MaTKCo=HethongTK.MaSo) LEFT JOIN ChungTu2 ON ChungTu.MaSo=ChungTu2.MaSo WHERE ChungTu2.MaSo is null AND (TK_ID={0} OR TK_ID={1}) AND ChungTu.NgayGS<='{2}'{3}{4}", TKCNKH_ID, ConvertToStrSafe(TKCNPT_ID), Format(ncuoi, Mask_DB), (IIf(mkh > 0, " AND (ChungTu.MaKH=" & mkh & " OR ChungTu.MaKHC=" & ConvertToStrSafe(mkh) & ")", String.Empty)), (IIf(TK.maso > 0, " AND HethongTK.SoHieu LIKE '" & TK.sohieu & "%'", String.Empty))))
        ExecSQLNonQuery("UPDATE CNDauNam2 SET SoXuat=0")
        Dim sql As String = String.Format("SELECT ChungTu2.MaSo,MaTKNo,MaKH,SoPS,CT_ID FROM ChungTu2 INNER JOIN HethongTK ON ChungTu2.MaTKNo=HethongTK.MaSo WHERE ABS(CT_ID)>2000000000 AND TK_ID={0}{1}{2}", TKCNPT_ID, (IIf(TK.maso > 0, " AND HethongTK.SoHieu LIKE '" & TK.sohieu & "%'", String.Empty)), (IIf(mkh > 0, " AND MaKH=" & mkh, String.Empty)))
        Dim rs_ktra As DataTable = ExecSQLReturnDT(sql)
        Dim rs_ktraIndex As Integer = 0
        Do While rs_ktraIndex < rs_ktra.Rows.Count
            Dim rs_ktraItem As DataRow = rs_ktra.Rows(rs_ktraIndex)
            rs_ktraIndex += 1 ' C15 Rs LOOP CONTROL
            m = ConvertToDblSafe(Math.Abs(rs_ktraItem("CT_ID")) - 2000000000)
            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM CNDauNam2 WHERE MaSo={0}", m))) = 0 Then
                m = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM CNDauNam2 WHERE MaTaiKhoan={0} AND MaKhachHang={1} ORDER BY HanTT DESC", ConvertToStrSafe(rs_ktraItem("MaTkNo")), ConvertToStrSafe(rs_ktraItem("makh")))))
                If m > 0 Then
                    ExecSQLNonQuery(String.Format("UPDATE CNDauNam2 SET SoXuat=SoXuat+{0} WHERE MaSo={1}", ConvertToStrSafe(rs_ktraItem("sops")), ConvertToStrSafe(m)))
                    ExecSQLNonQuery(String.Format("UPDATE ChungTu2 SET CT_ID={0} WHERE MaSo={1}", -(2000000000 - m), rs_ktraItem("MaSo")))
                End If
            Else
                ExecSQLNonQuery(String.Format("UPDATE CNDauNam2 SET SoXuat=SoXuat+{0} WHERE MaSo={1}", ConvertToStrSafe(rs_ktraItem("sops")), ConvertToStrSafe(m)))
            End If
            'rs_ktra.MoveNext()
        Loop
        sql = String.Format("SELECT ChungTu2.MaSo,MaTKCo,MaKHC,SoPS,CT_ID FROM ChungTu2 INNER JOIN HethongTK ON ChungTu2.MaTKCo=HethongTK.MaSo WHERE ABS(CT_ID)>2000000000 AND TK_ID={0}{1}{2}", _
                  TKCNKH_ID, _
                  (IIf(TK.maso > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", TK.sohieu), String.Empty)), _
                  (IIf(mkh > 0, String.Format(" AND MaKHC={0}", mkh), String.Empty)))
        rs_ktra = ExecSQLReturnDT(sql)
        rs_ktraIndex = 0
        Do While rs_ktraIndex < rs_ktra.Rows.Count
            Dim rs_ktraItem As DataRow = rs_ktra.Rows(rs_ktraIndex)
            rs_ktraIndex += 1 ' C15 Rs LOOP CONTROL
            m = ConvertToDblSafe(Math.Abs(rs_ktraItem("CT_ID")) - 2000000000)
            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM CNDauNam2 WHERE MaSo={0}", m))) = 0 Then
                m = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM CNDauNam2 WHERE MaTaiKhoan={0} AND MaKhachHang={1} ORDER BY HanTT DESC", ConvertToStrSafe(rs_ktraItem("MaTkCo")), ConvertToStrSafe(rs_ktraItem("MaKHC")))))
                If m > 0 Then
                    ExecSQLNonQuery(String.Format("UPDATE CNDauNam2 SET SoXuat=SoXuat+{0} WHERE MaSo={1}", ConvertToStrSafe(rs_ktraItem("sops")), ConvertToStrSafe(m)))
                    ExecSQLNonQuery(String.Format("UPDATE ChungTu2 SET CT_ID={0} WHERE MaSo={1}", -(2000000000 - m), rs_ktraItem("MaSo")))
                End If
            Else
                ExecSQLNonQuery(String.Format("UPDATE CNDauNam2 SET SoXuat=SoXuat+{0} WHERE MaSo={1}", ConvertToStrSafe(rs_ktraItem("sops")), ConvertToStrSafe(m)))
            End If
            'rs_ktra.MoveNext()
        Loop
        ExecSQLNonQuery(String.Format("UPDATE ChungTu2 SET ChungTu2.SoXuat=0 WHERE  ChungTu2.MaTKNo in (select ct2.MaTKNo from ChungTu2 as ct2 INNER JOIN HethongTK ON ct2.MaTKNo=HethongTK.MaSo and TK_ID={0} {1} {2} )", TKCNKH_ID, (IIf(TK.maso > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", TK.sohieu), String.Empty)), (IIf(mkh > 0, " AND MaKH=" & mkh, String.Empty))))
        sql = String.Format("SELECT ChungTu2.MaSo,SoPS,CT_ID FROM ChungTu2 INNER JOIN HethongTK ON ChungTu2.MaTKCo=HethongTK.MaSo WHERE ABS(CT_ID)>0 AND TK_ID={0}{1}{2}", TKCNKH_ID, (IIf(TK.maso > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", TK.sohieu), String.Empty)), (IIf(mkh > 0, " AND MaKHC=" & mkh, String.Empty)))
        rs_ktra = ExecSQLReturnDT(sql)
        rs_ktraIndex = 0
        Do While rs_ktraIndex < rs_ktra.Rows.Count
            Dim rs_ktraItem As DataRow = rs_ktra.Rows(rs_ktraIndex)
            rs_ktraIndex += 1 ' C15 Rs LOOP CONTROL
            m = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 ChungTu.MaSo AS F1 FROM ChungTu INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE TK_ID={0} AND MaCT={1}", TKCNKH_ID, ConvertToStrSafe(Math.Abs(rs_ktraItem("CT_ID"))))))
            ExecSQLNonQuery(String.Format("UPDATE ChungTu2 SET SoXuat=SoXuat+{0} WHERE MaSo={1}", ConvertToStrSafe(rs_ktraItem("sops")), ConvertToStrSafe(m)))
            'rs_ktra.MoveNext()
        Loop
        ExecSQLNonQuery(String.Format("UPDATE ChungTu2 SET ChungTu2.SoXuat=0 WHERE ChungTu2.MaTKCo in (select ct2.MaTKCo from ChungTu2 as ct2 INNER JOIN HethongTK ON ct2.MaTKCo=HethongTK.MaSo where TK_ID={0}{1}{2})", TKCNPT_ID, (IIf(TK.maso > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", TK.sohieu), String.Empty)), (IIf(mkh > 0, " AND MaKHC=" & mkh, String.Empty))))
        sql = String.Format("SELECT ChungTu2.MaSo,SoPS,CT_ID FROM ChungTu2 INNER JOIN HethongTK ON ChungTu2.MaTKNo=HethongTK.MaSo WHERE ABS(CT_ID)>0 AND TK_ID={0}{1}{2}", TKCNPT_ID, (IIf(TK.maso > 0, " AND HethongTK.SoHieu LIKE '" & TK.sohieu & "%'", String.Empty)), (IIf(mkh > 0, " AND MaKH=" & mkh, String.Empty)))
        rs_ktra = ExecSQLReturnDT(sql)
        rs_ktraIndex = 0
        Do While rs_ktraIndex < rs_ktra.Rows.Count
            Dim rs_ktraItem As DataRow = rs_ktra.Rows(rs_ktraIndex)
            rs_ktraIndex += 1 ' C15 Rs LOOP CONTROL
            m = ConvertToDblSafe(GetSelectValue("SELECT TOP 1 ChungTu.MaSo AS F1 FROM ChungTu INNER JOIN HethongTK ON ChungTu.MaTKCo=HethongTK.MaSo WHERE TK_ID=" & TKCNPT_ID & " AND MaCT=" & ConvertToStrSafe(Math.Abs(rs_ktraItem("CT_ID")))))
            ExecSQLNonQuery(String.Format("UPDATE ChungTu2 SET SoXuat=SoXuat+{0} WHERE MaSo={1}", ConvertToStrSafe(rs_ktraItem("sops")), ConvertToStrSafe(m)))
            'rs_ktra.MoveNext()
        Loop
        ''rs_ktra.Close()
    End Sub

    Private Function SoChiTiet3(ByRef TK As String, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date) As Boolean
        Dim result As Boolean = False
        Dim i As Integer
        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        Dim sql As String = String.Format("SELECT DISTINCT LEFT(HethongTK.SoHieu,3) AS SH FROM (ChungTu INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) INNER JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo WHERE TK.SoHieu LIKE '{0}%' AND TK.TK_ID={1} AND {2}  GROUP BY LEFT(HethongTK.SoHieu,3)", TK, ConvertToStrSafe(TKDT_ID), wsql)

        'rptFrom.InitForm("CHITIET3.RPT", sql, "QSoCai")

        Dim rs As DataTable = ExecSQLReturnDT(sql)
        If Not (rs.Rows.Count = 0) Then
            Dim rsIndex As Integer = 0
            sql = String.Format("SELECT DISTINCT LEFT(HethongTK.SoHieu,3) AS SH,ChungTu.SoHieu,NgayCT,DienGiai,SoPS,SoPS2Co,TenVattu, DonVi,Vattu.SoHieu AS SHVT FROM ((ChungTu INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) INNER JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo) INNER JOIN Vattu ON ChungTu.Mavattu=Vattu.MaSo WHERE TK.SoHieu LIKE '{0}%' AND TK.TK_ID={1} AND {2}  ORDER BY LEFT(HethongTK.SoHieu,3)", TK, ConvertToStrSafe(TKDT_ID), wsql)
            rptFrom.InitForm("CHITIET3.RPT", sql, "QSoCai")
            Do While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL And i < 5
                i += 1
                rptFrom.SetFormulas("TK" & CStr(i), String.Format("'{0}'", rsItem("sh")))
                ''rs.MoveNext()
            Loop
            rptFrom.SetFormulas("SoHieuTK", String.Format("'{0}'", TK))
            rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi, nn)))))
            RptSetDate(ncuoi)
            rptFrom.ReportWindowTitle = "Sổ chi tiết số 3"
            ''rs.Close()
            rs = Nothing
            Return True
        End If
        ''rs.Close()
        Return result
    End Function
    Private Sub InCTKhuyenMai(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef mkh As Integer, ByRef mvt As Integer)
        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        Dim sql As String = String.Format("SELECT DISTINCT ChungTu.NgayCT, ChungTu.SoHieu,ChungTu.MaLoai as [LoaiKM], ChungTu.SoPS, ChungTu.SoPS2Co, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, KhachHang.SoHieu AS SHKH, KhachHang.Ten FROM ((ChungTu INNER JOIN Vattu ON ChungTu.MaVattu = Vattu.MaSo) INNER JOIN HethongTK ON ChungTu.MaTKCo=HethongTK.MaSo) LEFT JOIN KhachHang ON ChungTu.MaKH=KhachHang.MaSo WHERE SoPS=0 AND TK_ID={0} AND {1}{2}{3} ORDER BY ChungTu.NgayCT, ChungTu.SoHieu", _
                                TKDT_ID, _
                                wsql, _
                                (IIf(mkh > 0, String.Format(" AND MaKH={0}", mkh), String.Empty)), _
                                (IIf(mvt > 0, String.Format(" AND MaVattu={0}", mvt), String.Empty)))
        'SetSQL("QChitiet", sql)
        rptFrom.InitForm("CTCK.RPT", sql, "QChitiet")

        rptFrom.ReportWindowTitle = "Tổng hợp chiết khấu bán hàng"
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi, nn)))))
        If mkh > 0 Then rptFrom.SetFormulas("DG", String.Format("'KH: {0} - {1}'", MaSo2SoHieu(mkh, "KhachHang"), TenKH("", mkh)))

        RptSetDate(IIf(tdau > 0, NgayCuoiThang(pNamTC, tcuoi), ncuoi))
    End Sub


    'Private Sub CTDoanhThuGiaVon(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef mvt As Integer)
    '    Dim vt As New ClsVattu
    '    Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
    '    vt.InitVattuMaSo(mvt)
    '    GauGe.Maximum = 3
    '    ExecSQLNonQuery("DELETE  FROM BaoCaoCP")
    '    ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP (MaSo,MaCha,SoHieu,Ten, Cap) SELECT DISTINCT ChungTu.MaSo,MaCT,ConvertToStrSafe(ChungTu.MaSo),ChungTu.SoHieu, ThangCT FROM {0} WHERE TK_ID={1} AND {2} AND MaVattu={3}", ChungTu2TKNC(1), TKDT_ID, wsql, ConvertToStrSafe(mvt)))
    '    GauGe.Value = 1
    '    Dim rs As DataTable = ExecSQLReturnDT("SELECT * FROM BaoCaoCP")
    '    Dim rsIndex As Integer = 0
    '    Do While rsIndex < rs.Rows.Count
    '        Dim rsItem As DataRow = rs.Rows(rsIndex)
    '        rsIndex += 1 ' C15 Rs LOOP CONTROL

    '        ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP SET Kq1={0} WHERE MaSo={1}", _
    '                            cstr(ConvertToDblSafe(GetSelectValue(String.Format("SELECT SoPS AS F1 FROM {0} WHERE HethongTK.SoHieu LIKE '632%' AND MaVattu={1} AND ChungTu.SoHieu = '{2}GV' AND ThangCT={3} AND {4}", _
    '                                                                       ChungTu2TKNC(-2), _
    '                                                                       ConvertToStrSafe(mvt), _
    '                                                                       rsItem("ten"), _
    '                                                                       rsItem("cap"), _
    '                                                                       wsql)))), _
    '                            rsItem("MaSo")))
    '        ''rs.MoveNext()
    '    Loop
    '    ''rs.Close()
    '    rs = Nothing
    '    GauGe.Value = 2
    '    Dim QLuyKe As String = "SELECT ChungTu.SoHieu,NgayCT,DienGiai,SoPS2Co,SoPS,Kq1 FROM ChungTu INNER JOIN BaoCaoCP ON ChungTu.MaSo=BaoCaoCP.MaSo"
    '    rptFrom.InitForm("GiaVon2.RPT", QLuyKe, "QLuyKe")

    '    rptFrom.SetFormulas(String.Format("ThoiGian='{0}'", (IIf(tdau > 0, thoigiantheothang(tdau, tcuoi, nn), ThoiGianN(ndau, ncuoi, nn)))))
    '    rptFrom.SetFormulas(String.Format("Vattu='{0} - {1} - Đơn vị tính: {2}'", vt.sohieu, vt.TenVattu, vt.DonVi))

    '    RptSetDate(IIf(tdau > 0, NgayCuoiThang(pNamTC, tcuoi), ncuoi), nn)
    'End Sub

    Private Sub CTDoanhThuGiaVon(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef mvt As Integer)
        Dim vt As New ClsVattu
        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        vt.InitVattuMaSo(mvt)
        GauGe.Maximum = 3
        ExecSQLNonQuery("DELETE FROM BaoCaoCP")
        Dim TAM As String = String.Format("INSERT INTO BaoCaoCP (MaSo,MaCha,SoHieu,Ten,Cap,kq2) SELECT DISTINCT ChungTu.MaSo,MaCT,ChungTu.MaSo,ChungTu.SoHieu,ThangCT,SOPS2CO FROM {0} WHERE TK_ID={1} AND {2} AND MaVattu={3}", ChungTu2TKNC(1), TKDT_ID, wsql, ConvertToStrSafe(mvt))
        ExecSQLNonQuery(TAM)
        GauGe.Value = 1
        Dim rs As DataTable = ExecSQLReturnDT("SELECT * FROM BaoCaoCP")
        Dim rsIndex As Integer = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            Dim TAM1 As String = String.Format("UPDATE BaoCaoCP SET Kq1={0} WHERE MaSo={1}", _
                                CStr(ConvertToDblSafe(GetSelectValue(String.Format("SELECT SoPS AS F1 FROM {0} WHERE HethongTK.SoHieu LIKE '632%' AND MaVattu={1} AND ChungTu.SoHieu = '{2}GV' AND ThangCT={3} AND ChungTu.SOPS2CO={4} AND {5}", _
                                                                        ChungTu2TKNC(-2), _
                                                                        ConvertToStrSafe(mvt), _
                                                                        rsItem("ten"), _
                                                                        rsItem("cap"), _
                                                                        rsItem("kq2"), _
                                                                        wsql)))), _
                                                                        rsItem("MaSo"))
            ExecSQLNonQuery(TAM1)
            ''rs.MoveNext()
        Loop
        ''rs.Close()
        rs = Nothing
        GauGe.Value = 2
        Dim QLuyKe As String = "SELECT ChungTu.SoHieu,NgayCT,DienGiai,SoPS2Co,SoPS,Kq1 FROM ChungTu INNER JOIN BaoCaoCP ON ChungTu.MaSo=BaoCaoCP.MaSo"
        rptFrom.InitForm("GiaVon2.RPT", QLuyKe, "QLuyKe")

        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi, nn)))))
        rptFrom.SetFormulas("VatTu", String.Format("'{0} - {1} - Đơn vị tính: {2}'", vt.sohieu, vt.TenVattu, vt.DonVi))

        RptSetDate(IIf(tdau > 0, NgayCuoiThang(pNamTC, tcuoi), ncuoi))
    End Sub

    'Private Sub InCTDoanhThu(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef mkh As Integer, ByRef mvt As Integer, ByRef mpl As Integer)
    '    Dim sql As String = String.Empty
    '    Dim DC, dn, nt As Double
    '    Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
    '    ExecSQLNonQuery("DELETE  FROM BaoCaoCP")
    '    ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP (MaSo,SoHieu,MaCha,CoCon) SELECT ChungTu.MaSo,ConvertToStrSafe(ChungTu.MaSo),MaCT,CASE WHEN (TK_ID={0}) THEN 0 ELSE 1 END FROM {1} WHERE (TK_ID={2} OR (TK_ID={3} AND SoPS<>0)) AND {4}{5}", TKDT_ID, ChungTu2TKNC(1), ConvertToStrSafe(TKDT_ID), ConvertToStrSafe(GTGTPN_ID), wsql, (IIf(mvt > 0, String.Format(" AND MaVattu={0}", mvt), String.Empty))))
    '    ExecSQLNonQuery("UPDATE BaoCaoCP INNER JOIN ChungTu ON BaoCaoCP.MaCha=ChungTu.MaCT SET BC_ID=MaKH WHERE MaKH>0")
    '    ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP INNER JOIN ({0}) ON BaoCaoCP.MaCha=ChungTu.MaCT SET BC_ID=MaKhachHang WHERE BC_ID=0", ChungTu2TKHD(0)))
    '    If mpl > 0 Then
    '        ExecSQLNonQuery(String.Format("DELETE BaoCaoCP.* FROM BaoCaoCP INNER JOIN KhachHang ON BaoCaoCP.BC_ID=KhachHang.MaSo WHERE MaPhanLoai<>{0}", mpl))
    '        rptFrom.SetFormulas(String.Format("PLKH='{0}'", CboKH.Text))
    '    End If
    '    If mkh > 0 Then
    '        ExecSQLNonQuery("DELETE  FROM BaoCaoCP WHERE BC_ID<>" & mkh)
    '        sql = ""
    '        rptFrom.SetFormulas(String.Format("TenKH='{0}'", TenKH(sql, mkh)))
    '        rptFrom.SetFormulas(String.Format("MaSoKH='{0}'", sql))
    '        If tdau > 0 Then
    '            SoDuKH(mkh, ThangTruoc(tdau), dn, DC, nt, 0, pSHPT)
    '        Else
    '            SoDuKHNgay(mkh, ndau.AddDays(-1), dn, DC, nt, 0, pSHPT)
    '        End If
    '        rptFrom.SetFormulas(String.Format("NoDK={0}", cstr(dn - DC)))
    '    End If
    '    sql = String.Format("SELECT DISTINCT ChungTu.MaSo,ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.DienGiai{0}, ChungTu.SoPS, ChungTu.SoPS2Co, HeThongTK.SoHieu AS SHTK, Vattu.SoHieu AS SHVT, Vattu.TenVattu, Vattu.DonVi,ChungTu.MaKH, KhachHang.SoHieu AS SHKH,KhachHang.Ten,BaoCaoCP.CoCon, 0 AS TTN, ChungTu.MaCT FROM (((ChungTu LEFT JOIN HethongTK ON ChungTu.MaTKNo = HethongTK.MaSo) LEFT JOIN Vattu ON ChungTu.MaVattu = Vattu.MaSo) INNER JOIN BaoCaoCP ON ChungTu.MaSo=BaoCaoCP.MaSo) LEFT JOIN KhachHang ON BaoCaoCP.BC_ID=KhachHang.MaSo WHERE TK_ID={1}{2}", (IIf(pnn > 0, "E", String.Empty)), ConvertToStrSafe(TKCNKH_ID), (IIf(mkh > 0, " AND BC_ID=" & mkh, String.Empty)))
    '    sql = String.Format("{0} UNION SELECT DISTINCT ChungTu.MaSo,ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.DienGiai{1}, ChungTu.SoPS, ChungTu.SoPS2Co, HeThongTK.SoHieu AS SHTK, Vattu.SoHieu AS SHVT, Vattu.TenVattu, Vattu.DonVi,ChungTu.MaKH, '' AS SHKH,'' AS Ten,CASE WHEN (TK.TK_ID={2}) THEN 0 ELSE 1 END AS CoCon, 1 AS TTN, ChungTu.MaCT FROM ((({3}) INNER JOIN BaoCaoCP ON ChungTu.MaCT=BaoCaoCP.MaCha) LEFT JOIN Vattu ON ChungTu.MaVattu = Vattu.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo WHERE (HethongTK.SoHieu LIKE '11%' OR HethongTK.SoHieu LIKE '53%') {4}", sql, (IIf(pnn > 0, "E", String.Empty)), ConvertToStrSafe(TKDT_ID), ChungTu2TKNC(-1), (IIf(mkh > 0, String.Format(" AND BC_ID={0}", mkh), String.Empty)))
    '    sql = String.Format("{0} UNION SELECT DISTINCT ChungTu.MaSo,ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.DienGiai{1}, ChungTu.SoPS, ChungTu.SoPS2Co, HeThongTK.SoHieu AS SHTK, '' AS SHVT, '' AS TenVattu, '' AS DonVi,ChungTu.MaKH, KhachHang.SoHieu AS SHKH,KhachHang.Ten,2 AS CoCon, 1 AS TTN, ChungTu.MaCT FROM ((({2}) INNER JOIN KhachHang ON ChungTu.MaKHC=KhachHang.MaSo) INNER JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo) LEFT JOIN BaoCaoCP ON ChungTu.MaCT=BaoCaoCP.MaCha WHERE {3} AND IsNull(BaoCaoCP.MaCha) AND (HethongTK.SoHieu LIKE '11%' OR HethongTK.SoHieu LIKE '331%' OR HethongTK.SoHieu LIKE '531%') {4} AND TK.SoHieu LIKE '{5}%'", sql, (IIf(pnn > 0, "E", String.Empty)), ChungTu2TKNC(-1), wsql, (IIf(mkh > 0, String.Format(" AND MaKHC={0}", mkh), String.Empty)), pSHPT)
    '    ' SetSQL("MienTru", sql)
    '    Dim QNhatKy As String = String.Format("SELECT ChungTu.MaCT, HoaDon.SoHD FROM {0} WHERE {1} GROUP BY ChungTu.MaCT, HoaDon.SoHD", ChungTu2TKHD(0), wsql)
    '    Dim QChitiet As String = String.Format("SELECT MienTru.*,QNhatKy.SoHD FROM ({0}) As MienTru LEFT JOIN ({1}) AS QNhatKy ON MienTru.MaCT=QNhatKy.MaCT ORDER BY NgayCT,SoHieu,CoCon", sql, QNhatKy)
    '    rptFrom.InitForm("CTDT.RPT", QChitiet, "QChitiet")
    '    rptFrom.SetFormulas(String.Format("ThoiGian = IF PageNumber() = 1 THEN '{0}'", (IIf(tdau > 0, thoigiantheothang(tdau, tcuoi, nn), ThoiGianN(ndau, ncuoi, nn)))))
    '    RptSetDate(ncuoi, nn)
    'End Sub
    Private Sub InCTDoanhThu(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef mkh As Integer, ByRef mvt As Integer, ByRef mpl As Integer)
        Dim sql As String = String.Empty
        Dim DC, dn, nt As Double
        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        ExecSQLNonQuery("DELETE  FROM BaoCaoCP")
        Dim tam As String = String.Format("INSERT INTO BaoCaoCP (MaSo,SoHieu,MaCha,CoCon) SELECT ChungTu.MaSo,ChungTu.MaSo,MaCT,CASE WHEN (TK_ID={0}) THEN 0 ELSE 1 END FROM {1} WHERE (TK_ID={2} OR (TK_ID={3} AND SoPS<>0)) AND {4}{5}", TKDT_ID, ChungTu2TKNC(1), ConvertToStrSafe(TKDT_ID), ConvertToStrSafe(GTGTPN_ID), wsql, (IIf(mvt > 0, String.Format(" AND MaVattu={0}", mvt), String.Empty)))
        ExecSQLNonQuery(tam)
        Dim tam1 As String = String.Format("UPDATE BaoCaoCP SET BC_ID=(select top 1 MaKH from BaoCaoCP  INNER JOIN ChungTu ON BaoCaoCP.MaCha=ChungTu.MaCT WHERE MaKH>0)")
        ExecSQLNonQuery(tam1)
        Dim tam2 As String = String.Format("UPDATE BaoCaoCP SET BC_ID= (select top 1 MaKhachHang from BAOCAOCP INNER JOIN ({0}) ON BaoCaoCP.MaCha=ChungTu.MaCT ) WHERE BC_ID=0", ChungTu2TKHD(0))
        ExecSQLNonQuery(tam2)
        If mpl > 0 Then
            ExecSQLNonQuery(String.Format("DELETE FROM BaoCaoCP where BaoCaoCP.BC_ID in (select BaoCaoCP.BC_ID from  BaoCaoCP INNER JOIN KhachHang ON BaoCaoCP.BC_ID=KhachHang.MaSo WHERE MaPhanLoai<>{0})", mpl))
            rptFrom.SetFormulas("PLKH", String.Format("'{0}'", CboKH.Text))
        End If
        If mkh > 0 Then
            Dim tam3 As String = String.Format("DELETE  FROM BaoCaoCP WHERE BC_ID<>" & mkh)
            ExecSQLNonQuery(tam3)
            sql = ""
            rptFrom.SetFormulas("TenKH", String.Format("'{0}'", TenKH(sql, mkh)))
            rptFrom.SetFormulas("MaSoKH", String.Format("'{0}'", sql))
            If tdau > 0 Then
                SoDuKH(mkh, ThangTruoc(tdau), dn, DC, nt, 0, pSHPT)
            Else
                SoDuKHNgay(mkh, ndau.AddDays(-1), dn, DC, nt, 0, pSHPT)
            End If
            rptFrom.SetFormulas("NoDK", dn - DC)
        End If
        sql = String.Format("SELECT DISTINCT ChungTu.MaSo,ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.DienGiai{0}, ChungTu.SoPS, ChungTu.SoPS2Co, HeThongTK.SoHieu AS SHTK, Vattu.SoHieu AS SHVT, Vattu.TenVattu, Vattu.DonVi,ChungTu.MaKH, KhachHang.SoHieu AS SHKH,KhachHang.Ten,BaoCaoCP.CoCon, 0 AS TTN, ChungTu.MaCT FROM (((ChungTu LEFT JOIN HethongTK ON ChungTu.MaTKNo = HethongTK.MaSo) LEFT JOIN Vattu ON ChungTu.MaVattu = Vattu.MaSo) INNER JOIN BaoCaoCP ON ChungTu.MaSo=BaoCaoCP.MaSo) LEFT JOIN KhachHang ON BaoCaoCP.BC_ID=KhachHang.MaSo WHERE TK_ID={1}{2}", (IIf(pnn > 0, "E", String.Empty)), ConvertToStrSafe(TKCNKH_ID), (IIf(mkh > 0, " AND BC_ID=" & mkh, String.Empty)))
        sql = String.Format("{0} UNION SELECT DISTINCT ChungTu.MaSo,ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.DienGiai{1}, ChungTu.SoPS, ChungTu.SoPS2Co, HeThongTK.SoHieu AS SHTK, Vattu.SoHieu AS SHVT, Vattu.TenVattu, Vattu.DonVi,ChungTu.MaKH, '' AS SHKH,'' AS Ten,CASE WHEN (TK.TK_ID={2}) THEN 0 ELSE 1 END AS CoCon, 1 AS TTN, ChungTu.MaCT FROM ((({3}) INNER JOIN BaoCaoCP ON ChungTu.MaCT=BaoCaoCP.MaCha) LEFT JOIN Vattu ON ChungTu.MaVattu = Vattu.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo WHERE (HethongTK.SoHieu LIKE '11%' OR HethongTK.SoHieu LIKE '53%') {4}", sql, (IIf(pnn > 0, "E", String.Empty)), ConvertToStrSafe(TKDT_ID), ChungTu2TKNC(-1), (IIf(mkh > 0, String.Format(" AND BC_ID={0}", mkh), String.Empty)))
        sql = String.Format("{0} UNION SELECT DISTINCT ChungTu.MaSo,ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.DienGiai{1}, ChungTu.SoPS, ChungTu.SoPS2Co, HeThongTK.SoHieu AS SHTK, '' AS SHVT, '' AS TenVattu, '' AS DonVi,ChungTu.MaKH, KhachHang.SoHieu AS SHKH,KhachHang.Ten,2 AS CoCon, 1 AS TTN, ChungTu.MaCT FROM ((({2}) INNER JOIN KhachHang ON ChungTu.MaKHC=KhachHang.MaSo) INNER JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo) LEFT JOIN BaoCaoCP ON ChungTu.MaCT=BaoCaoCP.MaCha WHERE {3} AND (BaoCaoCP.MaCha=NULL) AND (HethongTK.SoHieu LIKE '11%' OR HethongTK.SoHieu LIKE '331%' OR HethongTK.SoHieu LIKE '531%') {4} AND TK.SoHieu LIKE '{5}%'", sql, (IIf(pnn > 0, "E", String.Empty)), ChungTu2TKNC(-1), wsql, (IIf(mkh > 0, String.Format(" AND MaKHC={0}", mkh), String.Empty)), pSHPT)
        ' SetSQL("MienTru", sql)
        Dim QNhatKy As String = String.Format("SELECT ChungTu.MaCT, HoaDon.SoHD FROM {0} WHERE {1} GROUP BY ChungTu.MaCT, HoaDon.SoHD", ChungTu2TKHD(0), wsql)
        Dim QChitiet As String = String.Format("SELECT MienTru.*,QNhatKy.SoHD FROM ({0}) As MienTru LEFT JOIN ({1}) AS QNhatKy ON MienTru.MaCT=QNhatKy.MaCT ORDER BY NgayCT,SoHieu,CoCon", sql, QNhatKy)
        rptFrom.InitForm("CTDT.RPT", QChitiet, "QChitiet")
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi, nn)))))
        RptSetDate(ncuoi)
    End Sub

    'Private Sub InCTDoanhThu4(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef mkh As Integer, ByRef mvt As Integer, ByRef mkho As Integer)
    '    Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
    '    ExecSQLNonQuery("DELETE  FROM BaoCaoCP")
    '    ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP (MaSo,SoHieu,MaCha,CoCon) SELECT ChungTu.MaSo,ConvertToStrSafe(ChungTu.MaSo),MaCT,CASE WHEN (TK_ID={0}) THEN 0 ELSE 1 END FROM {1} WHERE (TK_ID={2} OR TK_ID={3}) AND {4}{5}{6}", TKDT_ID, ChungTu2TKNC(1), ConvertToStrSafe(TKDT_ID), ConvertToStrSafe(GTGTPN_ID), wsql, (IIf(mvt > 0, " AND MaVattu=" & mvt, String.Empty)), (IIf(mkho > 0, " AND MaKho=" & mkho, String.Empty))))
    '    ExecSQLNonQuery("UPDATE BaoCaoCP INNER JOIN ChungTu ON BaoCaoCP.MaCha=ChungTu.MaCT SET BC_ID=MaKH WHERE MaKH>0")
    '    ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP INNER JOIN ({0}) ON BaoCaoCP.MaCha=ChungTu.MaCT SET BC_ID=MaKhachHang WHERE BC_ID=0", ChungTu2TKHD(0)))
    '    Dim sql As String = String.Format("SELECT DISTINCT ChungTu.MaSo,ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.DienGiai, ChungTu.SoPS, ChungTu.SoPS2Co, HeThongTK.SoHieu, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi,ChungTu.MaKH, KhachHang.SoHieu,KhachHang.Ten,BaoCaoCP.CoCon, ChungTu.MaCT FROM (((ChungTu LEFT JOIN HethongTK ON ChungTu.MaTKNo = HethongTK.MaSo) LEFT JOIN Vattu ON ChungTu.MaVattu = Vattu.MaSo) INNER JOIN BaoCaoCP ON ChungTu.MaSo=BaoCaoCP.MaSo) LEFT JOIN KhachHang ON BaoCaoCP.BC_ID=KhachHang.MaSo{0} ORDER BY ChungTu.NgayGS, ChungTu.MaCT", (IIf(mkh > 0, " WHERE BC_ID=" & mkh, String.Empty)))

    '    Dim MienTru As String = String.Format("SELECT ChungTu.MaCT, HoaDon.SoHD FROM {0} WHERE {1} GROUP BY ChungTu.MaCT, HoaDon.SoHD", ChungTu2TKHD(0), wsql)
    '    Dim QChitiet As String = String.Format("SELECT QNhatKy.*,MienTru.SoHD FROM ({0}) AS QNhatKy LEFT JOIN ({1}) AS MienTru ON QNhatKy.MaCT=MienTru.MaCT ORDER BY NgayCT, QNhatKy.ChungTu.SoHieu", sql, MienTru)
    '    rptFrom.InitForm("CTDT4.RPT", QChitiet, "QChitiet")

    '    rptFrom.SetFormulas(String.Format("ThoiGian = IF PageNumber() = 1 THEN '{0}'", (IIf(tdau > 0, thoigiantheothang(tdau, tcuoi, nn), ThoiGianN(ndau, ncuoi, nn)))))
    '    RptSetDate(ncuoi)
    'End Sub
    Private Sub InCTDoanhThu4(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef mkh As Integer, ByRef mvt As Integer, ByRef mkho As Integer)
        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        ExecSQLNonQuery("DELETE  FROM BaoCaoCP")
        Dim tam As String = String.Format("INSERT INTO BaoCaoCP (MaSo,SoHieu,MaCha,CoCon) SELECT ChungTu.MaSo,ChungTu.MaSo,MaCT,CASE WHEN (TK_ID={0}) THEN 0 ELSE 1 END FROM {1} WHERE (TK_ID={2} OR TK_ID={3}) AND {4}{5}{6}", TKDT_ID, ChungTu2TKNC(1), ConvertToStrSafe(TKDT_ID), ConvertToStrSafe(GTGTPN_ID), wsql, (IIf(mvt > 0, " AND MaVattu=" & mvt, String.Empty)), (IIf(mkho > 0, " AND MaKho=" & mkho, String.Empty)))
        ExecSQLNonQuery(tam)
        'Dim tam2 As String = String.Format("UPDATE BaoCaoCP INNER JOIN ChungTu ON BaoCaoCP.MaCha=ChungTu.MaCT SET BC_ID=MaKH WHERE MaKH>0")
        Dim tam2 As String = String.Format("UPDATE BaoCaoCP SET BC_ID=(select top 1 MaKH from BAOCAOCP INNER JOIN ChungTu ON BaoCaoCP.MaCha=ChungTu.MaCT  WHERE MaKH>0)")
        ExecSQLNonQuery(tam2)
        'Dim tam3 As String = (String.Format("UPDATE BaoCaoCP INNER JOIN ({0}) ON BaoCaoCP.MaCha=ChungTu.MaCT SET BC_ID=MaKhachHang WHERE BC_ID=0", ChungTu2TKHD(0)))
        Dim tam3 As String = (String.Format("UPDATE BaoCaoCP SET BC_ID=(SELECT TOP 1 MaKhachHang FROM BAOCAOCP INNER JOIN ({0}) ON BaoCaoCP.MaCha=ChungTu.MaCT WHERE BC_ID=0)", ChungTu2TKHD(0)))
        ExecSQLNonQuery(tam3)
        Dim sql As String = String.Format("SELECT DISTINCT ChungTu.MaSo,ChungTu.SoHieu as [ChungTu.SoHieu], ChungTu.NgayCT, ChungTu.DienGiai, ChungTu.SoPS, ChungTu.SoPS2Co, HeThongTK.SoHieu as [HeThongTK.SoHieu], Vattu.SoHieu as [Vattu.SoHieu], Vattu.TenVattu, Vattu.DonVi,ChungTu.MaKH, KhachHang.SoHieu as [KhachHang.SoHieu],KhachHang.Ten,BaoCaoCP.CoCon, ChungTu.MaCT FROM (((ChungTu LEFT JOIN HethongTK ON ChungTu.MaTKNo = HethongTK.MaSo) LEFT JOIN Vattu ON ChungTu.MaVattu = Vattu.MaSo) INNER JOIN BaoCaoCP ON ChungTu.MaSo=BaoCaoCP.MaSo) LEFT JOIN KhachHang ON BaoCaoCP.BC_ID=KhachHang.MaSo{0}", (IIf(mkh > 0, " WHERE BC_ID=" & mkh, String.Empty)))

        Dim MienTru As String = String.Format("SELECT ChungTu.MaCT, HoaDon.SoHD FROM {0} WHERE {1} GROUP BY ChungTu.MaCT, HoaDon.SoHD", ChungTu2TKHD(0), wsql)
        Dim QChitiet As String = String.Format("SELECT QNhatKy.*,MienTru.SoHD FROM ({0}) AS QNhatKy LEFT JOIN ({1}) AS MienTru ON QNhatKy.MaCT=MienTru.MaCT ORDER BY NgayCT, QNhatKy.[ChungTu.SoHieu]", sql, MienTru)
        rptFrom.InitForm("CTDT4.RPT", QChitiet, "QChitiet")

        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi, nn)))))
        RptSetDate(ncuoi)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="mvt"></param>
    ''' <remarks></remarks>
    Private Sub InCTDoanhThu2(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef mvt As Integer)
        Dim st As String = String.Empty
        Dim dv As String = String.Empty
        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        Dim sql As String = String.Format("SELECT DISTINCT ChungTu.MaSo,ChungTu.SoHieu, NgayCT, NgayGS, ChungTu.DienGiai{0}, ChungTu.SoPS, ChungTu.SoPS2Co, HethongTK.SoHieu AS TKDU  FROM (ChungTu INNER JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo) LEFT JOIN HethongTK ON ChungTu.MaTKNo = HethongTK.MaSo WHERE {1} AND TK.TK_ID={2} AND MaVattu={3}", (IIf(pnn > 0, "E", String.Empty)), wsql, ConvertToStrSafe(TKDT_ID), ConvertToStrSafe(mvt))
        sql = String.Format("{0} UNION SELECT DISTINCT ChungTu.MaSo,ChungTu.SoHieu, NgayCT, NgayGS, ChungTu.DienGiai{1}, ChungTu.SoPS, ChungTu.SoPS2No, TK.SoHieu AS TKDU  FROM (ChungTu INNER JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo) LEFT JOIN HethongTK ON ChungTu.MaTKNo = HethongTK.MaSo WHERE {2} AND HethongTK.TK_ID={3} AND TK.TK_ID={4} AND MaVattu={5}", sql, (IIf(pnn > 0, "E", String.Empty)), wsql, ConvertToStrSafe(TKDT_ID), ConvertToStrSafe(TKGT_ID), ConvertToStrSafe(mvt))

        rptFrom.InitForm("CTDT3.RPT", sql, "QChitiet")
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi, nn)))))
        sql = String.Format("SELECT Sum(SoPS) AS F1 FROM {0} WHERE MaLoai=2 AND HethongTK.SoHieu LIKE '632%' AND MaVattu={1} AND {2}", ChungTu2TKNC(-2), ConvertToStrSafe(mvt), wsql)
        rptFrom.SetFormulas("GV", ConvertToDblSafe(GetSelectValue(sql)))
        sql = TenVT(st, mvt, dv)
        rptFrom.SetFormulas("TenVT", String.Format("'{0} - {1}{2}{3}'", st, sql, (" - Đơn vị tính: "), dv))
        RptSetDate(ncuoi)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShVT_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShVT_1.Enter
        Dim Index As Integer = Array.IndexOf(txtShVT, eventSender)
        txtShVT(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShVT_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtShVT_1.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtShVT, eventSender)
        If KeyAscii = 13 Then cmdvt_ClickEvent(cmdvt(Index), New EventArgs())
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShVT_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShVT_1.Leave
        Dim Index As Integer = Array.IndexOf(txtShVT, eventSender)
        Dim mvt As Integer
        Dim dv As String = String.Empty
        txtShVT(Index).Text = txtShVT(Index).Text.ToUpper()
        LbTenVT(Index).Text = TenVT(txtShVT(Index).Text, mvt, dv)
        txtShVT(Index).Tag = ConvertToStrSafe(mvt)
        HienThongBao(Me.Text, 1)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdvt_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _cmdvt_1.Click
        Dim Index As Integer = Array.IndexOf(cmdvt, eventSender)
        Me.Cursor = Cursors.WaitCursor
        txtShVT(Index).Text = FrmVattu.ChonVattu(txtShVT(Index).Text)
        Me.Cursor = Cursors.Default
        txtShVT(Index).Focus()
    End Sub

    Private Sub ExcelDoiChieuCN(ByVal tdau As Integer, ByVal tcuoi As Integer, ByVal ten As String, ByVal ct As Integer, ByVal makh As Long, ByVal TK As ClsTaikhoan, Optional ByRef Qchitiet As String = "")

        Dim curSheet As Excel.Worksheet, trang As Integer, kh As New clsKhachHang

        Try
            Kill(pCurDir + ten)
        Catch
        End Try
        Try
            With Excel_Global.ActiveWorkbook
                trang = IIf(ct = 1, 1, IIf(ct = 0, 2, 3))
                curSheet = Excel_Global.Worksheets(trang)

                curSheet.Cells(1, 1) = pTenCty
                curSheet.Cells(2, 1) = "'" + CStr(pTenCn)
                If tdau = tcuoi Then
                    curSheet.Cells(4, 1) = "Tháng " + CStr(tdau) + " năm " + CStr(pNamTC)
                Else
                    curSheet.Cells(4, 1) = "Từ tháng  " + CStr(tdau) + " đến tháng " + CStr(tcuoi) + " năm " + CStr(pNamTC)
                End If
                kh.InitKhachHangMaSo(makh)
                curSheet.Cells(5, 1) = CStr(curSheet.Cells(5, 1).Value) + CStr(kh.SoHieu) + " - " + CStr(kh.Ten)

                Dim dong As Long, dongdau As Long, PSCongNo As Double, PSThanhToan As Double
                If trang = 1 Then
                    dong = PrintSQLDoiChieuCN("select shct,ngayct,DienGiai,donvi,luong,loai,tien,tk_id,tenvattu,sohieu from (" + Qchitiet + ") as qchitiet where loai=1 order by loai,ngayct,shct,luong", curSheet, 7, 1, Qchitiet)
                    curSheet.Cells(dong, 9).Formula = "=SUM(" + XLSCol(CStr(9)) + "7:" + XLSCol(CStr(9)) + CStr(dong - 1) + ")"
                    PSCongNo = curSheet.Cells(dong, 9).Value
                    dongdau = dong + 3
                    dong = PrintSQLDoiChieuCN("select shct,ngayct,DienGiai,donvi,luong,loai,tien,tk_id,tenvattu,sohieu from (" + Qchitiet + ") as qchitiet where loai=2 order by loai,ngayct,shct,luong", curSheet, dong + 3, 1, Qchitiet)
                    curSheet.Cells(dong, 9).Formula = "=SUM(" + XLSCol(CStr(9)) + CStr(dongdau) + ":" + XLSCol(CStr(9)) + CStr(dong - 1) + ")"
                    PSThanhToan = curSheet.Cells(dong, 9).Value
                ElseIf trang = 2 Then
                    dong = PrintSQLDoiChieuCN1("select shct,ngayct,DienGiai,donvi,luong,loai,tien,tk_id,tenvattu,sohieu from (" + Qchitiet + ") as qchitiet where loai=1 order by loai,ngayct,shct,luong", curSheet, 7, 1, Qchitiet)
                    curSheet.Cells(dong, 4).Formula = "=SUM(" + XLSCol(CStr(4)) + "7:" + XLSCol(CStr(4)) + CStr(dong - 1) + ")"
                    curSheet.Cells(dong, 5).Formula = "=SUM(" + XLSCol(CStr(5)) + "7:" + XLSCol(CStr(5)) + CStr(dong - 1) + ")"
                    curSheet.Cells(dong, 6).Formula = "=SUM(" + XLSCol(CStr(6)) + "7:" + XLSCol(CStr(6)) + CStr(dong - 1) + ")"
                    PSCongNo = curSheet.Cells(dong, 6).Value
                    dongdau = dong + 3
                    dong = PrintSQLDoiChieuCN1("select shct,ngayct,DienGiai,donvi,luong,loai,tien,tk_id,tenvattu,sohieu from (" + Qchitiet + ") as qchitiet where loai=2 order by loai,ngayct,shct,luong", curSheet, dong + 3, 1, Qchitiet)
                    curSheet.Cells(dong, 4).Formula = "=SUM(" + XLSCol(CStr(4)) + CStr(dongdau) + ":" + XLSCol(CStr(4)) + CStr(dong - 1) + ")"
                    curSheet.Cells(dong, 5).Formula = "=SUM(" + XLSCol(CStr(5)) + CStr(dongdau) + ":" + XLSCol(CStr(5)) + CStr(dong - 1) + ")"
                    curSheet.Cells(dong, 6).Formula = "=SUM(" + XLSCol(CStr(6)) + CStr(dongdau) + ":" + XLSCol(CStr(6)) + CStr(dong - 1) + ")"
                    PSThanhToan = curSheet.Cells(dong, 6).Value
                Else
                    dong = PrintSQLDoiChieuCN2("select sohieu,ngay,DienGiai,sopsno,sopsco,mact,shdu,ngaygs,sops2no from bknhomps order by ngay,sohieu", curSheet, 8, 1)
                    curSheet.Cells(dong, 6).Formula = "=SUM(" + XLSCol(CStr(6)) + "8:" + XLSCol(CStr(6)) + CStr(dong - 1) + ")"
                    PSCongNo = curSheet.Cells(dong, 6).Value
                    curSheet.Cells(dong, 9).Formula = "=SUM(" + XLSCol(CStr(9)) + "7:" + XLSCol(CStr(9)) + CStr(dong - 1) + ")"
                    PSThanhToan = curSheet.Cells(dong, 9).Value
                End If
                Dim dauky As Double, dn As Double, DC As Double, dunt As Double, shtk As String = String.Empty, loai As Integer
                If TK.maso = 0 Then
                    loai = GetSelectValue("SELECT Kieu AS F1,SoHieu AS F2 FROM HethongTK INNER JOIN SoDuKhachHang On HethongTK.MaSo=SoDuKhachHang.MaTaiKhoan WHERE MaKhachHang=" + CStr(makh), shtk)
                    If shtk Like "141*" Then
                        TK.InitTaikhoanSohieu(shtk)
                        GoTo AAA
                    End If
                    kh.SoDuKH(ThangTruoc(tdau), dn, DC, dunt)
                Else
AAA:
                    loai = TK.kieu
                    kh.SoDuKH(ThangTruoc(tdau), dn, DC, dunt, 0, TK.sohieu)
                End If

                dauky = dn - DC
                curSheet.Cells(dong + 2, 3).Value = dauky
                curSheet.Cells(dong + 3, 3).Value = PSCongNo
                curSheet.Cells(dong + 4, 3).Value = PSThanhToan
                PSCongNo = dauky + PSCongNo - PSThanhToan
                curSheet.Cells(dong + 5, 3).Value = PSCongNo
                curSheet.Cells(dong + 6, 3).Value = ToVNText(PSCongNo) + " đồng"
                If trang = 3 Then
                    curSheet.Cells(7, 4).Value = dauky
                    curSheet.Cells(7, 6).Value = dauky
                    dn = GetSelectValue("SELECT Sum(sopsno)-sum(sops2No) AS F1,Sum(ABS(sopsno-sops2No)) AS F2 FROM BKNhomPS", DC)
                    shtk = ""
                    For i = tdau To tcuoi
                        shtk = shtk + "+no_" + CStr(i)
                    Next
                    shtk = shtk.Substring(1, Len(shtk) - 1)
                    dauky = GetSelectValue("select " + shtk + " as f1 from sodukhachhang where makhachhang=" + CStr(makh))
                    dauky = dauky - GetSelectValue("select sum(sops2no) as f1 from BKNhomPS")
                    curSheet.Cells(7, 9).Value = dauky
                    curSheet.Cells(dong + 4, 3).Value = PSThanhToan + dauky
                    curSheet.Cells(dong + 5, 3).Value = PSCongNo - dauky
                    curSheet.Cells(dong + 6, 3).Value = ToVNText(PSCongNo - dauky) + " đồng"
                End If

                If trang = 1 Then
                    curSheet.Cells(dong + 7, 7).Value = "Ngày " + CStr(NgayCuoiThang(pNamTC, tcuoi).Day) + " tháng " + CStr(tcuoi) + " năm " + CStr(pNamTC)
                ElseIf trang = 2 Then
                    curSheet.Cells(dong + 7, 4).Value = "Ngày " + CStr(NgayCuoiThang(pNamTC, tcuoi).Day) + " tháng " + CStr(tcuoi) + " năm " + CStr(pNamTC)
                End If

                curSheet.SaveAs(pCurDir + ten)
                CloseBook(pCurDir + ten)
            End With
        Catch
        End Try
    End Sub
End Class
