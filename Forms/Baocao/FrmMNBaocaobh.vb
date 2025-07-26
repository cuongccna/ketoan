Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter

Partial Friend Class FrmMNBaocaobh
    Dim baocao As Integer
    Dim Ngay(1) As Date
    Dim vatr As String = String.Empty
    Private Sub cmdtk_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _cmdtk_9.Click, _cmdtk_15.Click, _cmdtk_3.Click, _cmdtk_0.Click
        Dim Index As Integer = Array.IndexOf(cmdtk, eventSender)
        Me.Cursor = Cursors.WaitCursor
        txtShTk(Index).Text = FrmTaikhoan.ChonTk(txtShTk(Index).Text)
        Me.Cursor = Cursors.Default
        txtShTk(Index).Focus()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim mloai As Integer
        Dim taikhoan As New ClsTaikhoan
        Dim doiung As New ClsTaikhoan
        Dim k As Integer
        Dim mkho As Integer
        Dim rs_tk As DataTable
        If CboThang(1).Items.Count > 0 Then
            If CboThang(0).Enabled And CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
        End If

        Dim tdau As Integer = CboThang(0).SelectedValue
        Dim tcuoi As Integer = CboThang(1).SelectedValue
        Dim ten As String = String.Empty
        Cursor = Cursors.WaitCursor
        Select Case Index
            Case 0, 1
                rptFrom.ReportDestination = 1 'Index
                Me.Cursor = Cursors.WaitCursor
                GauGe.Value = 0
                If baocao = 61 Or baocao = 89 Then
                    If CboThang(0).Items.Count > 0 Then CboThang(0).SelectedIndex = 0
                    If CboThang(1).Items.Count > 0 Then CboThang(1).SelectedIndex = 11
                End If
                If OptTG(1).Checked Then
                    MedNgay(0).Text = Format(Ngay(0), Mask_D)
                    MedNgay(1).Text = Format(Ngay(1), Mask_D)
                End If
                SetRptInfo()
                rptFrom.ReportWindowTitle = OptBC(baocao).Text
                If ChkDu(15).CheckState = CheckState.Checked And Strings.Len(txtShTk(15).Text) > 0 Then
                    taikhoan.InitTaikhoanSohieu(txtShTk(15).Text)
                Else
                    taikhoan.InitTaikhoanMaSo(0)
                End If
                Select Case baocao
                    Case 0
                        If Not InNhatKy(tdau, tcuoi, IIf(ChkDu(1).CheckState, CboVV.SelectedIndex, 0), IIf(OptTG(1).Checked, 1, 0), Ngay(0), Ngay(1)) Then GoTo LoiBC
                    Case 1
                        tdau = (ConvertToDblSafe(cboQuy.Text) - 1) * 3 + 1
                        tcuoi = ConvertToDblSafe(cboQuy.Text) * 3
                        TaoBC(ConvertToDblSafe((tdau)), ConvertToDblSafe((tcuoi)), 2)
                        GoTo LoiBC
                    Case 9
                        TaoBC(1, 12, 3)
                        GoTo LoiBC
                    Case 2
                        If ChkDu(16).CheckState = CheckState.Checked Then
                            FrmBangke.ShowDialog()
                            GoTo LoiBC
                        Else
                            If Not InVATDauRa(tdau, tcuoi, CboTL.SelectedIndex, taikhoan) Then GoTo LoiBC
                        End If
                    Case 3
                        If ChkDu(16).CheckState = CheckState.Checked Then
                            FrmBangke.ShowDialog()
                            GoTo LoiBC
                        Else
                            If Not InVATDauVao2(tdau, tcuoi, CboTL.SelectedIndex, 1, taikhoan) Then GoTo LoiBC
                        End If
                    Case 4
                        InBCBH(GauGe, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1))
                    Case 5
                        InBCMH(GauGe, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1))
                    Case 8
                        InBCTT(GauGe, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1), ConvertToStrSafe(CboThuchi.SelectedValue))
                    Case 10
                        InBCCT(GauGe, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1), ConvertToStrSafe(CboThuchi.SelectedValue))
                    Case 6
                        ToKhaiVAT(tdau, tcuoi, taikhoan)
                    Case 7
                        THDoanhThuGiaVon(GauGe, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1), IIf(ChkDu(9).CheckState = CheckState.Checked, CboKho(1).SelectedIndex, 0), IIf(ChkDu(12).CheckState = CheckState.Checked, txtShTk(9).Text, String.Empty), ChkDu(13).CheckState)
                    Case 23
                        If CboKho(1).SelectedIndex < 0 Or CboKho(2).SelectedIndex < 0 Then Exit Sub
                        If OptDT(2).Checked Then
                            InTHDoanhThuVAT(IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1))
                        Else
                            InTHDoanhThu(IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1), IIf(OptDT(0).Checked, 0, 1), IIf(ChkDu(9).CheckState = CheckState.Checked, CboKho(1).SelectedIndex, 0), IIf(ChkDu(18).CheckState = CheckState.Checked, txtshkh(2).Text, String.Empty), IIf(ChkDu(17).CheckState = CheckState.Checked, ConvertToDblSafe(txtsh(0).Tag), 0), IIf(ChkDu(19).CheckState = CheckState.Checked, CboKho(2).SelectedIndex, 0), IIf(ChkDu(12).CheckState = CheckState.Checked, txtShTk(9).Text, String.Empty))
                        End If
                    Case 11, 12
                        If ConvertToDblSafe((txtShTk(0).Tag)) = 0 Then
                            txtShTk(0).Focus()
                            ErrMsg(er_SHTaiKhoan)
                            GoTo LoiBC
                        End If
                        taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(0).Tag))
                        doiung.InitTaikhoanMaSo(0)
                        If baocao = 11 Then
                            If Not InSocaiTk(taikhoan, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1), True, doiung.sohieu, 0, ChkDu(3).CheckState) Then GoTo LoiBC
                        Else
                            If Not InSoChitiet(taikhoan, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1), True, doiung.sohieu, 0, ChkDu(3).CheckState) Then GoTo LoiBC
                        End If
                    Case 16 : InKqkd(tdau, tcuoi, 0)
                    Case 19
                        If ChkDu(16).CheckState Then
                            FrmCandoi.Candoiluoi(tdau, tcuoi, CboCap.SelectedValue)
                            GoTo LoiBC
                        Else
                            InCdt(GauGe, True, tdau, tcuoi, CboCap.SelectedIndex + 1, Chk1.CheckState)
                        End If
                    Case 21
                        If Strings.Len(txtShTk(3).Text) = 0 Then
                            ErrMsg(er_SHTaiKhoan)
                            txtShTk(3).Focus()
                            GoTo LoiBC
                        End If
                        If Not BKChiTietRPT(GauGe, txtShTk(3).Text, NgayDauThang(pNamTC, tdau), NgayCuoiThang(pNamTC, tcuoi)) Then GoTo LoiBC
                End Select
a:
                If Not RptOK(rptFrom.ReportFilename, 0) Then
                    MessageBox.Show(Ngonngu("Mẫu báo cáo đã bị thay đổi!", "Change report form!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    GoTo LoiBC
                End If
                On Error GoTo Bad
                'frmMain.rpt.Action = 1
                On Error GoTo 0
                GoTo LoiBC
            Case 2
                Me.Close() : Exit Sub
            Case 3
                Select Case baocao
                    Case 2
                        InVATDauRa(tdau, tcuoi, CboTL.SelectedIndex, taikhoan)
                        OpenBook(String.Format("{0}RePorts\bangkebanra.xls", pCurDir))
                        CopyDataRa()
                        CloseBook(String.Format("{0}RePorts\bangkebanra.xls", pCurDir))
                        CallExcel("\temp\vatbanra.xls")
                    Case 3
                        InVATDauVao2(tdau, tcuoi, CboTL.SelectedIndex, 1, taikhoan)
                        OpenBook(String.Format("{0}RePorts\bangkemuavao.xls", pCurDir))
                        CopyDataVao()
                        CloseBook(String.Format("{0}RePorts\bangkemuavao.xls", pCurDir))
                        CallExcel("\temp\vatmuavao.xls")
                End Select
        End Select
        GoTo LoiBC
        ErrMsg(er_KoXem)
        GoTo LoiBC
Bad:
        'If Information.Err().Number = 20510 Then
        '    rptFrom.SetFormulas(52, String.Empty)
        '    rptFrom.SetFormulas(53, String.Empty)
        '    rptFrom.SetFormulas(54, String.Empty)
        '    GoTo a
        'End If
        MessageBox.Show(String.Format("Error {0}: {1}", _
                                Information.Err().Number, _
                                Information.Err().Description), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
LoiBC:
        HienThongBao(Me.Text, 1)
        GauGe.Value = GauGe.Maximum
        Me.Cursor = Cursors.Default
        rptFrom.ReportDestination = 1
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmMNBaocaobh_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.X
                    Command(0).Focus()
                    'Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.I
                    Command(1).Focus()
                    ' Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.V
                    Command(2).Focus()
                    ' Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.E
                    If Command(3).Enabled Then
                        Command(3).Focus()
                        'Command_ClickEvent(Command(3), New EventArgs())
                    End If
            End Select
        End If
        If (Shift And 2) > 0 And eventArgs.KeyCode = Keys.P Then
            frmMain.mnHT_Click(frmMain.mnHT, New EventArgs())
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmMNBaocaobh_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        OptBC_CheckedChanged(OptBC(1), New EventArgs())
        AddMonthToCbo(CboThang(0))
        AddMonthToCbo(CboThang(1))
        ' InitDateVars(MedNgay(0), Ngay(0))
        ' InitDateVars(MedNgay(1), Ngay(1))
        Int_RecsetToCbo("SELECT MaSo As F2,TenKho As F1 FROM KhoHang ORDER BY TenKho", CboKho(1))
        Int_RecsetToCbo("SELECT MaSo As F2,SoHieu + ' - ' + DienGiai As F1, Sohieu FROM NguonNhapXuat ORDER BY SoHieu", CboKho(2))
        Int_RecsetToCbo("SELECT  DoituongCT.MaSo AS F2 , CASE WHEN ( DoituongCT.MaKhachHang > 0 ) THEN KhachHang.Ten + ' - ' + DoituongCT.Sohieu + ' - ' ELSE '' END + DienGiai + CASE WHEN ( DoituongCT.MaKhachHang > 0 ) THEN ' - ' + CONVERT(NVARCHAR, NgayKy, 103) ELSE '' END AS F1,KhachHang.Ten FROM DoituongCT LEFT JOIN KhachHang ON DoituongCT.MaKhachHang = KhachHang.MaSo ORDER BY KhachHang.Ten , DoituongCT.SoHieu , DienGiai", CboVV)
        If CboTL.Items.Count > 0 Then CboTL.SelectedIndex = 1
        SetFont(Me)
        If cboQuy.Items.Count > 0 Then cboQuy.SelectedIndex = 0
        If CboCap.Items.Count > 6 Then CboCap.SelectedIndex = 5
        If CboThuchi.Items.Count > 0 Then CboThuchi.SelectedIndex = 0
        'If ConvertToDblSafe(((GetSelectValue("SELECT banhang AS f1 FROM license")))) Mod 10 > 0 Or FrmHoadontuin.Visible Then
        '    OptBC(0).Enabled = False
        '    OptBC(10).Enabled = False
        '    OptBC(16).Enabled = False
        '    OptBC(19).Enabled = False
        '    OptBC(21).Enabled = False
        '    OptBC(23).Enabled = False
        '    For chi_so As Integer = 2 To 8
        '        OptBC(chi_so).Enabled = False
        '    Next
        '    ChkDu(1).Enabled = False
        '    ChkDu(15).Enabled = False
        '    CboTL.Enabled = False
        '    CboVV.Enabled = False
        '    CboThuchi.Enabled = False
        '    Chk1.Enabled = False
        '    Label(3).Enabled = False
        '    CboCap.Enabled = False
        '    Label(2).Enabled = False
        '    LbTenTk(3).Enabled = False
        '    LbTenTk(15).Enabled = False
        '    txtShTk(3).Enabled = False
        '    txtShTk(15).Enabled = False
        '    cmdtk(3).Enabled = False
        '    cmdtk(15).Enabled = False
        '    If FrmHoadontuin.Visible Then
        '        OptBC(2).Visible = False
        '        OptBC(3).Visible = False
        '        Label(2).Visible = False
        '        CboTL.Visible = False
        '        Me.Height = 600
        '        Me.Width = 655
        '        Command(0).Top = 840
        '        Command(1).Top = 840
        '        Command(2).Top = 840
        '        Command(0).Left = 240
        '        Command(1).Left = 1440
        '        Command(2).Left = 2640
        '    End If
        'End If
        SetFont(Me)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_0.Enter, _MedNgay_1.Enter
        Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
        MedNgay(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_0.Leave, _MedNgay_1.Leave
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
    ''' <remarks></remarks>
    Private isInitializingComponent As Boolean
    Private Sub OptBC_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptBC_1.CheckedChanged, _OptBC_9.CheckedChanged, _OptBC_6.CheckedChanged, _OptBC_11.CheckedChanged, _OptBC_12.CheckedChanged, _OptBC_19.CheckedChanged, _OptBC_21.CheckedChanged, _OptBC_0.CheckedChanged, _OptBC_8.CheckedChanged, _OptBC_10.CheckedChanged, _OptBC_5.CheckedChanged, _OptBC_4.CheckedChanged, _OptBC_23.CheckedChanged, _OptBC_7.CheckedChanged, _OptBC_3.CheckedChanged, _OptBC_2.CheckedChanged, _OptBC_16.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(OptBC, eventSender)
            baocao = Index
            Command(3).Enabled = OptBC(2).Checked Or OptBC(3).Checked Or OptBC(19).Checked
            ChkDu(16).CheckState = CheckState.Unchecked
            ChkDu(16).Enabled = Command(3).Enabled
            ChkDu(13).Visible = (pChietKhau > 0 And (OptBC(7).Checked Or OptBC(23).Checked))
            OptTG(0).Enabled = True
            OptTG(1).Enabled = True
            If baocao = 7 Or baocao = 23 Then
                Frame2(5).Visible = True
            ElseIf baocao = 11 Or baocao = 12 Then
                If baocao = 11 Then OptTG(0).Enabled = False
                OptTG(1).Checked = True
                txtShTk(0).Text = ConvertToStrSafe(IIf(Index = 11, 1111, 112))
                txtShTk_Leave(txtShTk(0), New EventArgs())
            Else
                OptTG(1).Enabled = False
                Frame2(5).Visible = False
                OptTG(0).Checked = True
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="TL"></param>
    ''' <param name="TK"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function InVATDauRa(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef TL As Integer, ByRef TK As ClsTaikhoan) As Boolean
        Dim sql As String = String.Empty
        GauGe.Maximum = 1

        Dim QNhatky As String

        If TK.maso = 0 Then
            Select Case TL
                Case -3
                    QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu, CASE WHEN TK_ID={0} THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE HoaDon.Loai=1 AND HDBL=1 AND {2} AND KCT=0 AND (HoaDon.DC=0 OR HD=1) ORDER BY NgayPH", _
                                          GTGTPN_ID, _
                                          ChungTu2TKHD(2), _
                                          WThang("ThangCT", tdau, tcuoi))
                Case -2
                    QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu, CASE WHEN TK_ID={0} THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE HoaDon.Loai=1 AND {2} AND KCT=1 AND (HoaDon.DC=0 OR HD=1) ORDER BY NgayPH", _
                                          GTGTPN_ID, _
                                          ChungTu2TKHD(2), _
                                          WThang("ThangCT", tdau, tcuoi))
                Case -1
                    QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu, CASE WHEN TK_ID={0} THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE HoaDon.Loai=1 AND {2} AND (HoaDon.DC=0 OR HD=1) ORDER BY NgayPH", _
                                          GTGTPN_ID, _
                                          ChungTu2TKHD(2), _
                                          WThang("ThangCT", tdau, tcuoi))
                Case 30
                    QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu, CASE WHEN TK_ID={0} THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE HoaDon.Loai=1 AND (TyLe=5 OR TyLe=10) AND {2} AND KCT=0 AND (HoaDon.DC=0 OR HD=1) ORDER BY NgayPH", _
                                          GTGTPN_ID, _
                                          ChungTu2TKHD(2), _
                                          WThang("ThangCT", tdau, tcuoi))
                Case Else
                    QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu, CASE WHEN TK_ID={0} THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE HoaDon.Loai=1 AND TyLe={2} AND {3} AND KCT=0 AND (HoaDon.DC=0 OR HD=1) ORDER BY NgayPH", _
                                          GTGTPN_ID, _
                                          ChungTu2TKHD(2), _
                                          ConvertToStrSafe(TL), _
                                          WThang("ThangCT", tdau, tcuoi))
            End Select

        Else
            Select Case TL
                Case -3
                    QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu, CASE WHEN  TK_ID={0} THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE HoaDon.Loai=1 AND HDBL=1 AND {2} AND KCT=0 AND HethongTK.Sohieu LIKE '{3}%' AND (HoaDon.DC=0 OR HD=1) ORDER BY NgayPH", _
                                          GTGTPN_ID, _
                                          ChungTu2TKHD(2), _
                                          WThang("ThangCT", tdau, tcuoi), _
                                          TK.sohieu)
                Case -2
                    QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN   TK_ID={0} THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE HoaDon.Loai=1 AND {2} AND KCT=1 AND HethongTK.Sohieu LIKE '{3}%' AND (HoaDon.DC=0 OR HD=1) ORDER BY NgayPH", _
                                          GTGTPN_ID, _
                                          ChungTu2TKHD(2), _
                                          WThang("ThangCT", tdau, tcuoi), _
                                          TK.sohieu)
                Case -1
                    QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN   TK_ID={0} THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE HoaDon.Loai=1 AND {2} AND HethongTK.Sohieu LIKE '{3}%' AND (HoaDon.DC=0 OR HD=1) ORDER BY NgayPH", _
                                          GTGTPN_ID, _
                                          ChungTu2TKHD(2), _
                                          WThang("ThangCT", tdau, tcuoi), _
                                          TK.sohieu)
                Case 30
                    QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN    TK_ID={0} THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE HoaDon.Loai=1 AND (TyLe=5 OR TyLe=10) AND {2} AND KCT=0 AND HethongTK.Sohieu LIKE '{3}%' AND (HoaDon.DC=0 OR HD=1) ORDER BY NgayPH", _
                                          GTGTPN_ID, _
                                          ChungTu2TKHD(2), _
                                          WThang("ThangCT", tdau, tcuoi), _
                                          TK.sohieu)
                Case Else
                    QNhatky = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN   TK_ID={0} THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE HoaDon.Loai=1 AND TyLe={2} AND {3} AND KCT=0 AND HethongTK.Sohieu LIKE '{4}%' AND (HoaDon.DC=0 OR HD=1) ORDER BY NgayPH", _
                                          GTGTPN_ID, _
                                          ChungTu2TKHD(2), _
                                          ConvertToStrSafe(TL), _
                                          WThang("ThangCT", tdau, tcuoi), _
                                          TK.sohieu)
            End Select

        End If

        GauGe.Value = 1
        If ConvertToDblSafe(Interaction.GetSetting(IniPath, "Invoice", "ListDetail", "0")) = 1 Then
            Dim MienTru As String = String.Format("SELECT MaCT FROM {0} WHERE {1} AND HoaDon.Loai=1 GROUP BY MaCT", _
                                  ChungTu2TKHD(0), _
                                  WThang("ThangCT", tdau, tcuoi))
            Dim QCdt As String = String.Format("SELECT MaCT FROM ChungTu WHERE {0} AND MaVattu>0 AND MaLoai=8 GROUP BY MaCT HAVING Count(MaVattu)>1", WThang("ThangCT", tdau, tcuoi))
            Dim QDuPhong As String = String.Format("SELECT ChungTu.MaCT,TenVattu AS MH,SoPS2Co AS SL,SoPS AS TT FROM (((ChungTu INNER JOIN (" & MienTru & ") as MienTru ON ChungTu.MaCT=MienTru.MaCT) INNER JOIN HethongTK ON ChungTu.MaTKCo=HethongTK.MaSo) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN ({0}) AS QCdt ON ChungTu.MaCT=QCdt.MaCT WHERE TK_ID={1}", _
                                        QCdt, _
                                        TKDT_ID)
            Dim QChitiet As String = String.Format("SELECT QNhatKy.*,QDuPhong.* FROM ({0}) AS QNhatKy LEFT JOIN ({1}) AS QDuPhong ON QNhatKy.MaCT=QDuPhong.MaCT ORDER BY TyLe,NgayPH,SoHD", _
                                         QNhatky, _
                                         QDuPhong)

            rptFrom.InitForm("BANGKER6r.RPT", QChitiet, "QChitiet")
        Else
            rptFrom.InitForm("BANGKER.RPT", QNhatky, "QNhatky")
        End If

        If TK.maso = 0 Then
            rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))
        Else
            rptFrom.SetFormulas("TenCN", String.Format("'{0}'", TK.ten))
            rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", TK.GhiChu))
        End If

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        rptFrom.SetFormulas("MSThue", String.Format("'{0}'", frmMain._LbCty_8.Text))
        rptFrom.SetFormulas("TLKT", TL)
        rptFrom = rptFrom.copyReportObject(rptFrom)
        Dim reportMessage As String = rptFrom.DoReport()
        If String.IsNullOrEmpty(reportMessage) Then

        End If
        Return True
    End Function
    Private Function InVATDauVao2(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef TL As Integer, ByRef HD As Integer, ByRef TK As ClsTaikhoan) As Boolean
        Dim sql As String = String.Empty
        Dim Tk2 As New ClsTaikhoan
        Dim Fx As Integer = IIf(Strings.Left(frmMain._LbCty_8.Text, 2) = "35" Or Strings.Left(frmMain._LbCty_3.Text, 2) = "64", 35, 0)
        Tk2.InitTaikhoanSohieu("33312")
        If Tk2.tk_id = GTGTKT_ID Then
            sql = String.Format("DELETE HoaDon  FROM ((HoaDon INNER JOIN ChungTu ON HoaDon.MaSo=ChungTu.MaSo) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo  WHERE (HethongTK.SoHieu LIKE '{0}%') AND (TK.SoHieu LIKE '33312%'  OR ChungTu.GhiChu like '%33312%') AND HoaDon.Loai=-1", pVATV)
            ExecSQLNonQuery(sql)
        End If
        GauGe.Maximum = 1

        Dim QNhatKy As String

        If TK.maso = 0 Then
            Select Case TL
                Case -3
                    If Fx = 0 Then
                        QNhatKy = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM {0} WHERE Loai=-1 AND HD={1} AND {2} AND HDBL=1 AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ORDER BY NgayPH,MaCT", _
                                      ChungTu2TKHD(10), _
                                      ConvertToStrSafe(HD), _
                                      WThang("ThangCT", tdau, tcuoi))
                    Else
                        QNhatKy = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM {0} WHERE Loai=-1 AND {1} AND HDBL=1 AND KCT=1 AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ORDER BY NgayPH,MaCT", _
                                      ChungTu2TKHD(10), _
                                      WThang("ThangCT", tdau, tcuoi))
                    End If
                Case -2
                    QNhatKy = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM {0} WHERE Loai=-1 AND HD={1} AND {2} AND KCT=1 AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ORDER BY NgayPH,MaCT", _
                                  ChungTu2TKHD(10), _
                                  ConvertToStrSafe(HD), _
                                  WThang("ThangCT", tdau, tcuoi))
                Case -1
                    If Fx = 0 Then
                        QNhatKy = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM {0} WHERE Loai=-1 AND HD={1} AND {2} AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ORDER BY NgayPH,MaCT", _
                                      ChungTu2TKHD(10), _
                                      ConvertToStrSafe(HD), _
                                      WThang("ThangCT", tdau, tcuoi))
                    Else
                        QNhatKy = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM {0} WHERE Loai=-1 AND HD={1} AND {2} AND (HDBL=0 OR KCT=0) AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ORDER BY NgayPH,MaCT", _
                                      ChungTu2TKHD(10), _
                                      ConvertToStrSafe(HD), _
                                      WThang("ThangCT", tdau, tcuoi))
                    End If
                Case 30
                    QNhatKy = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM {0} WHERE Loai=-1 AND (TyLe=5 OR TyLe=10) AND HD={1} AND {2} AND KCT=0 AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ORDER BY NgayPH,MaCT", _
                                  ChungTu2TKHD(10), _
                                  ConvertToStrSafe(HD), _
                                  WThang("ThangCT", tdau, tcuoi))
                Case Else
                    QNhatKy = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM {0} WHERE Loai=-1 AND TyLe={1} AND HD={2} AND {3} AND KCT=0 AND HDBL=0 AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ORDER BY NgayPH,MaCT", _
                                  ChungTu2TKHD(10), _
                                  ConvertToStrSafe(TL), _
                                  ConvertToStrSafe(HD), _
                                  WThang("ThangCT", tdau, tcuoi))
            End Select

        Else
            Select Case TL
                Case -3
                    If Fx = 0 Then
                        QNhatKy = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HoaDon.Loai=-1 AND HD={1} AND {2} AND HethongTK.Sohieu LIKE '{3}%' AND HDBL=1 AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ORDER BY NgayPH,MaCT", _
                                      ChungTu2TKHD(10), _
                                      ConvertToStrSafe(HD), _
                                      WThang("ThangCT", tdau, tcuoi), _
                                      TK.sohieu)
                    Else
                        QNhatKy = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HoaDon.Loai=-1 AND {1} AND HethongTK.Sohieu LIKE '{2}%' AND HDBL=1 AND KCT=1 AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ORDER BY NgayPH,MaCT", _
                                      ChungTu2TKHD(10), _
                                      WThang("ThangCT", tdau, tcuoi), _
                                      TK.sohieu)
                    End If
                Case -2
                    QNhatKy = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HoaDon.Loai=-1 AND HD={1} AND {2} AND KCT=1 AND HethongTK.Sohieu LIKE '{3}%' AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ORDER BY NgayPH,MaCT", _
                                  ChungTu2TKHD(10), _
                                  ConvertToStrSafe(HD), _
                                  WThang("ThangCT", tdau, tcuoi), _
                                  TK.sohieu)
                Case -1
                    If Fx = 0 Then
                        QNhatKy = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HoaDon.Loai=-1 AND HD={1} AND {2} AND HethongTK.Sohieu LIKE '{3}%' AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ORDER BY NgayPH,MaCT", _
                                      ChungTu2TKHD(10), _
                                      ConvertToStrSafe(HD), _
                                      WThang("ThangCT", tdau, tcuoi), _
                                      TK.sohieu)
                    Else
                        QNhatKy = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HoaDon.Loai=-1 AND HD={1} AND {2} AND HethongTK.Sohieu LIKE '{3}%' AND (HDBL=0 OR KCT=0) AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ORDER BY NgayPH,MaCT", _
                                      ChungTu2TKHD(10), _
                                      ConvertToStrSafe(HD), _
                                      WThang("ThangCT", tdau, tcuoi), _
                                      TK.sohieu)
                    End If
                Case 30
                    QNhatKy = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HoaDon.Loai=-1 AND (TyLe=5 OR TyLe=10) AND HD={1} AND {2} AND KCT=0 AND HethongTK.Sohieu LIKE '{3}%' AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ORDER BY NgayPH,MaCT", _
                                  ChungTu2TKHD(10), _
                                  ConvertToStrSafe(HD), _
                                  WThang("ThangCT", tdau, tcuoi), _
                                  TK.sohieu)
                Case Else
                    QNhatKy = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HoaDon.Loai=-1 AND TyLe={1} AND HD={2} AND {3} AND KCT=0 AND HDBL=0 AND HethongTK.Sohieu LIKE '{4}%' AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ORDER BY NgayPH,MaCT", _
                                  ChungTu2TKHD(10), _
                                  ConvertToStrSafe(TL), _
                                  ConvertToStrSafe(HD), _
                                  WThang("ThangCT", tdau, tcuoi), _
                                  TK.sohieu)
            End Select

        End If
        GauGe.Value = 1
        If HD = 0 Then
            Dim MienTru As String = String.Format("SELECT MaCT FROM {0} WHERE {1} AND HoaDon.Loai=-1 GROUP BY MaCT", _
                                        ChungTu2TKHD(0), _
                                        WThang("ThangCT", tdau, tcuoi))
            Dim QCdt As String = String.Format("SELECT MaCT FROM ChungTu WHERE {0} AND MaVattu>0 AND (MaLoai=1 or MaLoai=13 or MaLoai=9) GROUP BY MaCT HAVING Count(MaVattu)>=1", WThang("ThangCT", tdau, tcuoi))
            Dim QDuPhong As String = String.Format("SELECT ChungTu.MaCT,TenVattu as MH,SoPS2No AS SL,SoPS AS TT,vattu.donvi as dvt,vattu.sohieu as shvt,chungtu.maso as maso1 FROM ((((ChungTu INNER JOIN ({0}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN ({1}) AS QCdt ON ChungTu.MaCT=QCdt.MaCT)inner join tonkho ton on vattu.maso=ton.mavattu WHERE (TK_ID={2} OR HethongTK.Loai=6)", _
                                         MienTru, _
                                         QCdt, _
                                         TKVT_ID)
            Dim QChitiet As String = String.Format("SELECT QNhatKy.*,QDuPhong.* FROM ({0}) AS QNhatKy LEFT JOIN ({1}) AS QDuPhong ON QNhatKy.MaCT=QDuPhong.MaCT ORDER BY NgayPH,SoHD,maso1", _
                                         QNhatKy, _
                                         QDuPhong)

            rptFrom.InitForm("BANGKEVKHD.RPT", QChitiet, "QChitiet")
        Else
            If (TL > 0 And TL < 5) Or TL = -3 Then
                rptFrom.InitForm("BANGKEV4.RPT", QNhatKy, "QNhatKy")
            Else
                If ConvertToDblSafe(Interaction.GetSetting(IniPath, "Invoice", "ListDetail", "0")) = 1 Then
                    Dim MienTru As String = String.Format("SELECT MaCT FROM {0} WHERE {1} AND HoaDon.Loai=-1 GROUP BY MaCT", _
                                                ChungTu2TKHD(0), _
                                                WThang("ThangCT", tdau, tcuoi))
                    Dim QCdt As String = String.Format("SELECT MaCT FROM ChungTu WHERE {0} AND MaVattu>0 AND MaLoai=1 GROUP BY MaCT HAVING Count(MaVattu)>1", WThang("ThangCT", tdau, tcuoi))
                    Dim QDuPhong As String = String.Format("SELECT ChungTu.MaCT,TenVattu,SoPS2No AS SL,SoPS AS TT FROM (((ChungTu INNER JOIN ({0}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN ({1}) AS QCdt ON ChungTu.MaCT=QCdt.MaCT WHERE (TK_ID={2} OR HethongTK.Loai=6)", _
                                                 MienTru, _
                                                 QCdt, _
                                                 TKVT_ID)
                    Dim QChitiet As String = String.Format("SELECT QNhatKy.*,TenVattu,SL,TT FROM QNhatKy LEFT JOIN ({0}) AS QDuPhong ON QNhatKy.MaCT=QDuPhong.MaCT ORDER BY TyLe,NgayPH,SoHD", QDuPhong)
                    rptFrom.InitForm("BANGKEV6.RPT", QChitiet, "QChitiet")
                Else
                    rptFrom.InitForm("BANGKEV2.RPT", QNhatKy, "QNhatKy")
                End If
            End If
        End If

        If TK.maso = 0 Then
            rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))
        Else
            rptFrom.SetFormulas("TenCN", String.Format("'{0}'", TK.ten))
            rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", TK.GhiChu))
        End If

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        rptFrom.SetFormulas("MSThue", String.Format("'{0}'", frmMain._LbCty_8.Text))
        rptFrom.SetFormulas("TLKT", TL)
        rptFrom = rptFrom.copyReportObject(rptFrom)
        Dim reportMessage As String = rptFrom.DoReport()
        If String.IsNullOrEmpty(reportMessage) Then

        End If
        Return True
    End Function
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
    Private Sub txtsh_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtsh_0.Enter
        Dim Index As Integer = Array.IndexOf(txtsh, eventSender)
        txtsh(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtsh_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtsh_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then cmd_ClickEvent(cmd(0), New EventArgs())
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
    Private Sub txtsh_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtsh_0.Leave
        Dim Index As Integer = Array.IndexOf(txtsh, eventSender)
        Dim ms As Integer
        lb(Index).Text = TenNV(txtsh(Index).Text, ms)
        txtsh(Index).Tag = ConvertToStrSafe(ms)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtshkh_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtshkh_2.Enter
        Dim Index As Integer = Array.IndexOf(txtshkh, eventSender)
        txtshkh(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtshkh_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtshkh_2.KeyPress
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
    Private Sub txtshkh_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtshkh_2.Leave
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
    Private Sub txtShTk_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShTk_0.Enter, _txtShTk_3.Enter, _txtShTk_9.Enter, _txtShTk_15.Enter
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        txtShTk(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtShTk_0.KeyPress, _txtShTk_3.KeyPress, _txtShTk_9.KeyPress, _txtShTk_15.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        If KeyAscii = 13 Then cmdtk_ClickEvent(cmdtk(Index), New EventArgs())
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
    Private Sub txtShTk_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShTk_0.Leave, _txtShTk_3.Leave, _txtShTk_9.Leave, _txtShTk_15.Leave
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        Dim mtk As Integer
        txtShTk(Index).Text = txtShTk(Index).Text.ToUpper()
        If Strings.Len(txtShTk(Index).Text) > 0 Then
            mtk = 0
            LbTenTk(Index).Text = tentk(txtShTk(Index).Text, mtk)
            txtShTk(Index).Tag = ConvertToStrSafe(mtk)
        Else
            LbTenTk(Index).Text = ""
            txtShTk(Index).Tag = "0"
        End If
        HienThongBao(Me.Text, 1)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <remarks></remarks>
    Private Sub InTHDoanhThuVAT(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date)
        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        Dim Mientru As String = String.Format("SELECT MaCT,KCT,TyLe FROM ChungTu INNER JOIN HoaDon ON ChungTu.MaSo=HoaDon.MaSo WHERE HoaDon.Loai=1 AND MaLoai=8 AND {0}", wsql)
        Dim QChitiet As String = String.Format("SELECT DISTINCT Vattu.SoHieu,TenVattu, DonVi,SUM(CASE WHEN TyLe=0 AND KCT=1 THEN SoPS ELSE 0 END) AS DKT, SUM(CASE WHEN TyLe=0 AND KCT=0 THEN SoPS ELSE 0 END) AS D0, SUM(CASE WHEN TyLe=5 THEN SoPS ELSE 0 END) AS D5, SUM(CASE WHEN TyLe=10 THEN SoPS ELSE 0 END) AS D10, SUM(CASE WHEN TyLe=5 THEN TyLe*SoPS/100 ELSE 0 END) AS T5, SUM(CASE WHEN TyLe=10 THEN TyLe*SoPS/100 ELSE 0 END) AS T10 FROM ((ChungTu LEFT JOIN Vattu ON ChungTu.MaVattu = Vattu.MaSo) INNER JOIN  ({0}) MienTru ON ChungTu.MaCT=MienTru.MaCT) INNER JOIN HethongTK ON ChungTu.MaTKCo=HethongTK.MaSo WHERE TK_ID={1} OR HethongTK.Loai=7 GROUP BY Vattu.SoHieu,TenVattu,DonVi", Mientru, TKDT_ID)

        rptFrom.InitForm("THDT4.RPT", QChitiet, "QChitiet")

        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi)))))
        RptSetDate(ncuoi)
        InBaoCaoRPT()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="loai"></param>
    ''' <param name="mkho"></param>
    ''' <param name="shkh"></param>
    ''' <param name="mnv"></param>
    ''' <param name="MN"></param>
    ''' <param name="shtk"></param>
    ''' <remarks></remarks>
    Private Sub InTHDoanhThu(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef loai As Integer, ByRef mkho As Integer, ByRef shkh As String, ByRef mnv As Integer, ByRef MN As Integer, Optional ByRef shtk As String = "")
        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        ExecSQLNonQuery("DELETE  FROM BaoCaoCP")
        ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP (MaSo,SoHieu,MaCha) SELECT ChungTu.MaSo,ConvertToStrSafe(ChungTu.MaSo),MaCT FROM {0} WHERE (TK_ID={1}) AND {2}{3}{4} GROUP BY ChungTu.MaSo, MaCT", _
                            ChungTu2TKNC(1), _
                            ConvertToStrSafe(TKDT_ID), _
                            wsql, _
                            (IIf(mkho > 0, String.Format(" AND MaKho={0}", mkho), String.Empty)), _
                            (IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty))))
        ExecSQLNonQuery("UPDATE BaoCaoCP INNER JOIN ChungTu ON BaoCaoCP.MaCha=ChungTu.MaCT SET BC_ID=MaKH WHERE MaKH>0")
        ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP INNER JOIN ({0}) ON BaoCaoCP.MaCha=ChungTu.MaCT SET BC_ID=MaKhachHang WHERE BC_ID=0", ChungTu2TKHD(0)))
        Dim sql As String = String.Format("SELECT DISTINCT Sum(ChungTu.SoPS) AS Tien, Sum(ChungTu.SoPS2Co) AS Luong, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, (KhachHang.SoHieu) AS SHKH,(KhachHang.Ten) AS Ten, (PhanLoaiVattu.PLCha) AS PLCha3, (PhanLoaiVattu.SoHieu) AS SHPL3, (PhanLoaiVattu.TenPhanLoai) AS TenPL3 FROM ((ChungTu LEFT JOIN (PhanLoaiVattu RIGHT JOIN Vattu ON PhanLoaiVattu.MaSo = Vattu.MaPhanLoai) ON ChungTu.MaVattu = Vattu.MaSo) INNER JOIN BaoCaoCP ON ChungTu.MaSo=BaoCaoCP.MaSo) LEFT JOIN KhachHang ON BaoCaoCP.BC_ID=KhachHang.MaSo WHERE  {0}{1}{2} GROUP BY {3}Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi", _
                               (String.Format("ChungTu.MaNV='{0}'", mnv)), _
                               (String.Format("AND ChungTu.MaNguon='{0}'", MN)), _
                               (String.Format("AND KhachHang.SoHieu='{0}'", shkh)), _
                               ("KhachHang.SoHieu,KhachHang.Ten,PhanLoaiVattu.PLCha,PhanLoaiVattu.SoHieu,PhanLoaiVattu.TenPhanLoai,"))
        Dim QChitiet As String
        Dim QDuPhong As String
        Dim QLuyKe As String

        QChitiet = sql
        sql = String.Format("SELECT QChitiet.*,PhanLoaiVattu.SoHieu AS SHPL2,TenPhanLoai AS TenPL2,PhanLoaiVattu.PLCha AS PLCha2 FROM ({0}) AS QChitiet LEFT JOIN PhanLoaiVattu ON QChitiet.PLCha3=PhanLoaiVattu.MaSo", QChitiet)

        QDuPhong = sql
        sql = String.Format("SELECT QDuPhong.*,PhanLoaiVattu.SoHieu AS SHPL1,TenPhanLoai AS TenPL1 FROM ({0}) AS QDuPhong LEFT JOIN PhanLoaiVattu ON QDuPhong.PLCha2=PhanLoaiVattu.MaSo ORDER BY QDuPhong.Sohieu", QDuPhong)

        QLuyKe = sql
        If loai = 0 Then
            rptFrom.InitForm("THDT1.RPT", QLuyKe, "QLuyKe")
        Else
            If shkh.Length > 0 Then
                QLuyKe = String.Format("SELECT * FROM " & QLuyKe & " WHERE SHKH = '{0}'", shkh)
            End If
            rptFrom.InitForm("THDT2.RPT", QLuyKe, "QLuyKe")
        End If
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi)))))

        If mkho > 0 Then rptFrom.SetFormulas("DG1", String.Format("'{0}'", tenkho(mkho)))
        If shkh.Length > 0 Then rptFrom.SetFormulas("DG2", String.Format("'{0}'", TenKH(shkh, 0)))
        If mnv > 0 Then rptFrom.SetFormulas("DG3", String.Format("'{0}'", TenNV("", mnv)))
        If MN > 0 Then rptFrom.SetFormulas("DG4", String.Format("'{0}'", TenNguon(MN)))
        If shtk.Length > 0 Then rptFrom.SetFormulas("DG3", String.Format("'TK: {0}'", shtk))
        RptSetDate(ncuoi)
        InBaoCaoRPT()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdkh_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _cmdkh_2.Click
        Dim Index As Integer = Array.IndexOf(cmdkh, eventSender)
        Me.Cursor = Cursors.WaitCursor
        txtshkh(Index).Text = FrmKhachHang.ChonKhachHang(txtshkh(Index).Text)
        Me.Cursor = Cursors.Default
        txtshkh(Index).Focus()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmd_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _cmd_0.Click
        Dim Index As Integer = Array.IndexOf(cmd, eventSender)
        txtsh(Index).Text = FrmNhanVien.ChonNV(txtsh(Index).Text)
        txtsh(Index).Focus()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thangdau"></param>
    ''' <param name="thangcuoi"></param>
    ''' <param name="loai"></param>
    ''' <param name="excel"></param>
    ''' <remarks></remarks>
    Private Sub TaoBC(ByRef thangdau As Integer, ByRef thangcuoi As Integer, ByRef loai As Integer, Optional ByRef excel As Integer = 0)
        UpdateSLHoaDon()
        Dim i As Object = thangdau
        Dim j As Integer = thangcuoi
        If (ConvertToDblSafe(i) > 0 And ConvertToDblSafe(i) < 13) And (j > 0 And j < 13) And (j >= ConvertToDblSafe(i)) Then
            TaoBCHoaDonQuy(ConvertToDblSafe(i), j)
            If excel = 0 Then InSLHoaDon(ConvertToDblSafe(i), j, loai)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="taikhoan"></param>
    ''' <remarks></remarks>
    Private Sub ToKhaiVAT(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef taikhoan As ClsTaikhoan)
        Dim sql As String = String.Empty
        Dim VV As Double
        Dim TK As New ClsTaikhoan
        Dim Fx As Integer = IIf(Strings.Left(frmMain._LbCty_8.Text, 2) = "35" Or Strings.Left(frmMain._LbCty_3.Text, 2) = "64", 35, 0)
        TK.InitTaikhoanSohieu("33312")
        If TK.tk_id = GTGTKT_ID Then
            sql = String.Format("DELETE HoaDon  FROM ((HoaDon INNER JOIN ChungTu ON HoaDon.MaSo=ChungTu.MaSo) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo  WHERE (HethongTK.SoHieu LIKE '{0}%') AND (TK.SoHieu LIKE '33312%'  OR ChungTu.GhiChu like '%33312%') AND HoaDon.Loai=-1", pVATV)
            ExecSQLNonQuery(sql)
        End If

        rptFrom.InitForm("TOKHAI.RPT", "SELECT * FROM License", "License")
        GauGe.Maximum = 6
        rptFrom.SetFormulas("Thang", tdau)
        rptFrom.SetFormulas("ThangCuoi", tcuoi)
        If taikhoan.maso = 0 Then
            rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))
        Else
            rptFrom.SetFormulas("TenCN", String.Format("'{0}'", taikhoan.ten))
            rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", taikhoan.GhiChu))
        End If
        rptFrom.SetFormulas("MSThue", String.Format("'{0}'", frmMain._LbCty_8.Text))
        rptFrom.SetFormulas("SoHieuTK", String.Format("'{0}'", vatr))
        rptFrom.SetFormulas("Quan", String.Format("'{0}'", frmMain._LbCty_10.Text))
        rptFrom.SetFormulas("QP", String.Format("'{0}'", frmMain._LbCty_11.Text))
        rptFrom.SetFormulas("Tel", String.Format("'{0}'", frmMain._LbCty_3.Text))
        rptFrom.SetFormulas("Fax", String.Format("'{0}'", frmMain._LbCty_4.Text))
        rptFrom.SetFormulas("Email", String.Format("'{0}'", frmMain._LbCty_9.Text))
        Dim shct As String = taikhoan.SHChiTiet()
        Dim vr As Double = ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(ThanhTien) AS F1 FROM {0} WHERE HoaDon.Loai=1 AND {1} AND KCT=1 AND DC=0 AND RIGHT(HethongTK.SoHieu,{2}) = '{3}'", _
                                                               ChungTu2TKHD(1), _
                                                               WThang("ThangCT", tdau, tcuoi), _
                                                               ConvertToStrSafe(shct.Length), _
                                                               shct)))
        rptFrom.SetFormulas("DTKCT", vr)
        GauGe.Value = 1
        rptFrom.SetFormulas("Vat0DT", ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(ThanhTien) AS F1,SUM(CASE WHEN TK_ID={0} THEN SoPS ELSE -SoPS END) AS F2 FROM {1} WHERE HoaDon.Loai=1 AND DC=0 AND {2} AND KCT=0 AND RIGHT(HethongTK.SoHieu,{3}) = '{4}' AND TyLe=0", _
                                                                                                   GTGTPN_ID, _
                                                                                                   ChungTu2TKHD(1), _
                                                                                                   WThang("ThangCT", tdau, tcuoi), _
                                                                                                   ConvertToStrSafe(shct.Length), _
                                                                                                   shct), VV)))
        rptFrom.SetFormulas("Vat0", VV)
        rptFrom.SetFormulas("Vat5DT", ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(ThanhTien) AS F1,SUM(CASE WHEN TK_ID={0} THEN SoPS ELSE -SoPS END) AS F2 FROM {1} WHERE HoaDon.Loai=1 AND DC=0 AND {2} AND KCT=0 AND RIGHT(HethongTK.SoHieu,{3}) = '{4}' AND TyLe=5", _
                                                                                                   GTGTPN_ID, _
                                                                                                   ChungTu2TKHD(1), _
                                                                                                   WThang("ThangCT", tdau, tcuoi), _
                                                                                                   ConvertToStrSafe(shct.Length), _
                                                                                                   shct), VV)))
        rptFrom.SetFormulas("Vat5", VV)
        rptFrom.SetFormulas("Vat10DT", ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(ThanhTien) AS F1,SUM(CASE WHEN TK_ID={0} THEN SoPS ELSE -SoPS END) AS F2 FROM {1} WHERE HoaDon.Loai=1 AND DC=0 AND {2} AND KCT=0 AND RIGHT(HethongTK.SoHieu,{3}) = '{4}' AND TyLe=10", _
                                                                                                    GTGTPN_ID, _
                                                                                                    ChungTu2TKHD(1), _
                                                                                                    WThang("ThangCT", tdau, tcuoi), _
                                                                                                    ConvertToStrSafe(shct.Length), _
                                                                                                    shct), VV)))
        rptFrom.SetFormulas("Vat10", VV)
        'Dieu chinh
        sql = String.Format("SELECT Sum(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=1 AND DC=1 AND {1} AND KCT=0 AND RIGHT(HethongTK.SoHieu,{2}) = '{3}'", _
                  ChungTu2TKHD(1), _
                  WThang("ThangCT", tdau, tcuoi), _
                  ConvertToStrSafe(shct.Length), _
                  shct)
        vr = ConvertToDblSafe(GetSelectValue(sql, VV))
        If VV >= 0 Then
            rptFrom.SetFormulas("RaT", vr)
            rptFrom.SetFormulas("RaTV", VV)
        Else
            rptFrom.SetFormulas("RaG", Math.Abs(vr))
            rptFrom.SetFormulas("RaGV", Math.Abs(VV))
        End If
        GauGe.Value = 2
        Dim kt As Double = 0 'SoNKChuaThue(tdau, tcuoi, shct)
        If shct.Length > 0 Then
            sql = String.Format("SELECT SUM(ThanhTien) AS F1 FROM {0} WHERE HoaDon.Loai=-1 AND HD=1 AND DC=0 AND KCT=0 AND {1} AND RIGHT(HethongTK.SoHieu,{2}) = '{3}'", _
                      ChungTu2TKHD(-1), _
                      WThang("ThangCT", tdau, tcuoi), _
                      ConvertToStrSafe(shct.Length), _
                      shct)
        Else
            sql = String.Format("SELECT SUM(ThanhTien) AS F1 FROM {0} WHERE HoaDon.Loai=-1 AND HD=1 AND DC=0 AND KCT=0 AND {1}", _
                      ChungTu2TKHD(0), _
                      WThang("ThangCT", tdau, tcuoi))
        End If
        Dim vvx As Double = ConvertToDblSafe(GetSelectValue(sql)) + kt
        rptFrom.SetFormulas("TongVaoV", vvx)
        If shct.Length > 0 Then
            sql = String.Format("SELECT SUM(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=-1 AND DC=0 AND {1} AND RIGHT(HethongTK.SoHieu,{2}) = '{3}'", _
                      ChungTu2TKHD(-1), _
                      WThang("ThangCT", tdau, tcuoi), _
                      ConvertToStrSafe(shct.Length), _
                      shct)
        Else
            sql = String.Format("SELECT SUM(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=-1 AND DC=0 AND {1}", _
                      ChungTu2TKHD(0), _
                      WThang("ThangCT", tdau, tcuoi))
        End If
        vvx = ConvertToDblSafe(GetSelectValue(sql, VV)) + kt
        rptFrom.SetFormulas("TongVao", vvx)
        sql = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE (HethongTK.SoHieu LIKE '142%' OR HethongTK.SoHieu LIKE '242%' OR HethongTK.SoHieu LIKE '6%') AND (TK.SoHieu LIKE '{1}%') AND RIGHT(TK.SoHieu,{2})='{3}' AND {4}", ChungTu2TKNC(0), pVATV, ConvertToStrSafe(shct.Length), shct, WThang("ThangCT", tdau, tcuoi))
        rptFrom.SetFormulas("TongVATV", ConvertToDblSafe(VV - ConvertToDblSafe(GetSelectValue(sql))))
        If TK.tk_id = GTGTKT_ID Then
            Dim MienTru As String = String.Format("SELECT MaCT FROM {0} WHERE (HethongTK.SoHieu LIKE '521%' OR HethongTK.SoHieu LIKE '531%') AND {1}", _
                                  ChungTu2TKNC(-1), _
                                  WThang("ThangCT", tdau, tcuoi))
            sql = String.Format("SELECT SUM(SoPS) AS F1 FROM ({0}) LEFT JOIN (" & MienTru & ") as MienTru ON ChungTu.MaCT=MienTru.MaCT  WHERE IsNull(MienTru.MaCT) AND (HethongTK.SoHieu LIKE '33312%') AND RIGHT(HethongTK.SoHieu,{1})='{2}' AND {3} AND (TK.SoHieu LIKE '11%' OR TK.SoHieu LIKE '136%')", _
                      ChungTu2TKNC(0), _
                      shct.Length, _
                      shct, _
                      WThang("ThangCT", tdau, tcuoi))
            rptFrom.SetFormulas("TongVATx", ConvertToDblSafe(VV - ConvertToDblSafe(GetSelectValue(sql))) + PSDu(pVATV, "33312", tdau, tcuoi, shct)) '- GetSelectValue(sql)
        Else
            rptFrom.SetFormulas("TongVATx", VV)
        End If
        GauGe.Value = 3
        'Dieu chinh
        If shct.Length > 0 Then
            sql = String.Format("SELECT SUM(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=-1 AND DC=1 AND {1} AND RIGHT(HethongTK.SoHieu,{2}) = '{3}'", _
                      ChungTu2TKHD(-1), _
                      WThang("ThangCT", tdau, tcuoi), _
                      ConvertToStrSafe(shct.Length), _
                      shct)
        Else
            sql = String.Format("SELECT SUM(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=-1 AND DC=1 AND {1}", _
                      ChungTu2TKHD(0), _
                      WThang("ThangCT", tdau, tcuoi))
        End If
        vvx = ConvertToDblSafe(GetSelectValue(sql, VV))
        If VV >= 0 Then
            rptFrom.SetFormulas("VaoT", vvx)
            rptFrom.SetFormulas("VaoTV", VV)
        Else
            rptFrom.SetFormulas("VaoG", Math.Abs(vvx))
            rptFrom.SetFormulas("VaoGV", Math.Abs(VV))
        End If
        ' Nhap khau
        If shct.Length > 0 Then
            sql = String.Format("SELECT SUM(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=-1 AND NK=1 AND {1} AND RIGHT(HethongTK.SoHieu,{2}) = '{3}'", _
                      ChungTu2TKHD(-1), _
                      WThang("ThangCT", tdau, tcuoi), _
                      ConvertToStrSafe(shct.Length), _
                      shct)
        Else
            sql = String.Format("SELECT SUM(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=-1 AND NK=1 AND {1}", _
                      ChungTu2TKHD(0), _
                      WThang("ThangCT", tdau, tcuoi))
        End If
        vvx = ConvertToDblSafe(GetSelectValue(sql, VV))
        rptFrom.SetFormulas("NK", vvx)
        rptFrom.SetFormulas("NKV", VV)
        ' Tai san
        If shct.Length > 0 Then
            sql = String.Format("SELECT SUM(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=-1 AND TS=1 AND {1} AND RIGHT(HethongTK.SoHieu,{2}) = '{3}'", _
                      ChungTu2TKHD(-1), _
                      WThang("ThangCT", tdau, tcuoi), _
                      ConvertToStrSafe(shct.Length), _
                      shct)
        Else
            sql = String.Format("SELECT SUM(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=-1 AND TS=1 AND {1}", _
                      ChungTu2TKHD(0), _
                      WThang("ThangCT", tdau, tcuoi))
        End If
        vvx = ConvertToDblSafe(GetSelectValue(sql, VV))
        rptFrom.SetFormulas("TS", vvx)
        rptFrom.SetFormulas("TSV", VV)
        kt = ConvertToDblSafe(DKToKhai(tdau, shct))
        If kt > 0 Then rptFrom.SetFormulas("KyTruoc", kt)
        sql = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE (TK.SoHieu LIKE '{1}112%' OR TK.SoHieu LIKE '{1}212%') AND RIGHT(TK.SoHieu,{2})='{3}' AND {4} AND (HethongTK.SoHieu LIKE '336%' OR HethongTK.SoHieu LIKE '11%' OR HethongTK.SoHieu LIKE '138%')", _
                  ChungTu2TKNC(0), _
                  pVATV, _
                  ConvertToStrSafe(shct.Length), _
                  shct, _
                  WThang("ThangCT", tdau, tcuoi))
        VV = ConvertToDblSafe(GetSelectValue(sql))
        rptFrom.SetFormulas("HoanTra", VV)
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom = rptFrom.copyReportObject(rptFrom)
        Dim reportMessage As String = rptFrom.DoReport()
        If String.IsNullOrEmpty(reportMessage) Then

        End If
        GauGe.Value = 4
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <param name="shct"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function DKToKhai(ByRef thang As Integer, ByRef shct As String) As Object
        Dim TK As ClsTaikhoan
        Dim dunt, duno, duco, X As Double
        Dim sql As String = String.Empty
        Dim tdau As Integer
        If thang = pThangDauKy Then
            TK = New ClsTaikhoan()
            TK.InitTaikhoanSohieu(pVATV, shct)
            TK.SoDuTK(0, duno, duco, dunt)
            duno -= duco
            TK.InitTaikhoanSohieu(vatr, shct)
            TK.SoDuTK(0, X, duco, dunt)
            '******************************************************* + X - duco ******************************************************************
            duno = duno
            TK = Nothing
        Else
            tdau = ThangTruoc(thang)
            duno = ConvertToDblSafe(DKToKhai(tdau, shct))
            If shct.Length > 0 Then
                sql = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE HoaDon.Loai=-1 AND {1} AND RIGHT(HethongTK.SoHieu,{2}) = '{3}'", _
                          ChungTu2TKHD(-1), _
                          WThang("ThangCT", tdau, tdau), _
                          ConvertToStrSafe(shct.Length), _
                          shct)
            Else
                sql = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE HoaDon.Loai=-1 AND {1}", _
                          ChungTu2TKHD(0), _
                          WThang("ThangCT", tdau, tdau))
            End If
            duno += ConvertToDblSafe(GetSelectValue(sql))
            ' Kiem tra dau ra co bi am thi bo sung
            If shct.Length > 0 Then
                sql = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE HoaDon.Loai=1 AND {1} AND RIGHT(HethongTK.SoHieu,{2}) = '{3}'", _
                          ChungTu2TKHD(1), _
                          WThang("ThangCT", tdau, tdau), _
                          ConvertToStrSafe(shct.Length), _
                          shct)
            Else
                sql = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE HoaDon.Loai=1 AND {1}", _
                          ChungTu2TKHD(0), _
                          WThang("ThangCT", tdau, tdau))
            End If
            X = ConvertToDblSafe(GetSelectValue(sql))
            If X < 0 Then duno += Math.Abs(X)
            sql = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE (HethongTK.SoHieu LIKE '142%' OR HethongTK.SoHieu LIKE '242%' OR HethongTK.SoHieu LIKE '6%') AND (TK.SoHieu LIKE '{1}%') AND RIGHT(TK.SoHieu,{2})='{3}' AND {4}", _
                      ChungTu2TKNC(0), _
                      pVATV, _
                      ConvertToStrSafe(shct.Length), _
                      shct, _
                      WThang("ThangCT", tdau, tdau))
            duno = ConvertToDblSafe(duno - ConvertToDblSafe(GetSelectValue(sql)))
            sql = String.Format("SELECT SUM(CASE WHEN TK_ID={0} THEN SoPS ELSE -SoPS END) AS F1 FROM {1} WHERE HoaDon.Loai=1 AND {2} AND KCT=0 AND RIGHT(HethongTK.SoHieu,{3}) = '{4}'", _
                      GTGTPN_ID, _
                      ChungTu2TKHD(1), _
                      WThang("ThangCT", tdau, tdau), _
                      ConvertToStrSafe(shct.Length), _
                      shct)
            duno = ConvertToDblSafe(duno - ConvertToDblSafe(GetSelectValue(sql)))
            sql = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE (TK.SoHieu LIKE '{1}112%' OR TK.SoHieu LIKE '{1}212%') AND RIGHT(TK.SoHieu,{2})='{3}' AND {4} AND (HethongTK.SoHieu LIKE '336%' OR HethongTK.SoHieu LIKE '11%' OR HethongTK.SoHieu LIKE '138%')", _
                      ChungTu2TKNC(0), _
                      pVATV, _
                      ConvertToStrSafe(shct.Length), _
                      shct, _
                      WThang("ThangCT", tdau, tdau))
            duno = ConvertToDblSafe(duno - ConvertToDblSafe(GetSelectValue(sql)))
        End If
        If duno < 0 Then duno = 0
        Return duno
    End Function
    Private Sub FrmMNBaocaobh_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
