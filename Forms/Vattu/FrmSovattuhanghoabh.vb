Imports System
Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing
Imports System.Diagnostics
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter
Imports Excel = Microsoft.Office.Interop.Excel


Partial Friend Class FrmSovattuhanghoabh
    Private isInitializingComponent As Boolean
    Dim baocao As Integer
    Dim StopPrint As Boolean
    Dim Ngay(2) As Date
    Dim Pdelay, nn As Integer
    Dim xlapp As Excel.Application
    Dim xlsheet As Excel.Worksheet
    Private Sub CmdAdd_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CmdAdd.Click
        FrmBCVT.ShowDialog()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdCT_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _cmdCT_1.Click
        Dim Index As Integer = Array.IndexOf(cmdCT, eventSender)
        txtCT(Index).Text = FrmTP.ChonTP(txtCT(Index).Text)
        txtCT_Leave(txtCT(Index), New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdtk_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _cmdtk_10.Click, _cmdtk_11.Click, _cmdtk_4.Click
        Dim Index As Integer = Array.IndexOf(cmdtk, eventSender)
        Me.Cursor = Cursors.WaitCursor
        txtShTk(Index).Text = FrmTaikhoan.ChonTk(txtShTk(Index).Text)
        txtShTk(Index).Focus()
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdvt_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _cmdvt_0.Click
        Dim Index As Integer = Array.IndexOf(cmdvt, eventSender)
        Me.Cursor = Cursors.WaitCursor
        txtShVT(Index).Text = FrmVattu.ChonVattu(txtShVT(Index).Text)
        Me.Cursor = Cursors.Default
        txtShVT(Index).Focus()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmSovattuhanghoabh_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.X
                    Command(0).Focus()
                    ' Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.I
                    Command(1).Focus()
                    ' Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.V
                    Command(2).Focus()
                    ' Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.E
                    If Command(3).Enabled Then
                        Command(3).Focus()
                        '  Command_ClickEvent(Command(3), New EventArgs())
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
    Public Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim taikhoan As New ClsTaikhoan
        Dim doiung As New ClsTaikhoan
        Dim rs_tk As DataTable
        Dim tdau, tcuoi As Integer
        Dim n1 As Date
        Dim mloai, mkho, mtk, MN As Integer
        Dim i As Integer
        Dim mdt3, mdt1, mdt2, mdt As Integer
        Dim k As Integer
        Select Case Index
            Case 0, 1
                Me.Cursor = Cursors.WaitCursor
                GauGe.Value = 0
                If CboThang(0).Items.Count > 0 Then
                    If CboThang(0).Enabled And CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
                End If

                tdau = CboThang(0).SelectedIndex
                tcuoi = CboThang(1).SelectedIndex
                Ngay(1) = ConvertToDateSafe(MedNgay(1).Text)
                Ngay(2) = ConvertToDateSafe(MedNgay(2).Text)
                SetRptInfo()
                Select Case baocao
                    Case 74
                        If CboKho(0).SelectedIndex < 0 Then
                            ErrMsg(er_KhoHang)
                            GoTo LoiBC
                        End If
                        mkho = IIf(OptKho(0).Checked, CboKho(0).SelectedIndex, 0)
                        mloai = IIf(ChkDu(3).CheckState = CheckState.Checked, CboLoai(0).SelectedIndex, 0)
                        BKSanLuong(mkho, mloai, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(1), Ngay(2), IIf(ChkDu(2).CheckState = CheckState.Checked And Strings.Len(txtShTk(4).Text) > 0, txtShTk(4).Text, "155"))
                        GoTo LoiBC
                    Case 43
                        If CboKho(0).Items.Count > 0 Then Baocao152(IIf(OptKho(0).Checked, CboKho(0).SelectedIndex, 0), tcuoi)
                        GoTo LoiBC
                    Case 12, 64
                        If CboKho(0).SelectedIndex < 0 Then
                            ErrMsg(er_KhoHang)
                            GoTo LoiBC
                        End If
                        If CboLoai(1).SelectedIndex < 0 Then
                            ErrMsg(er_NguonNX)
                            GoTo LoiBC
                        End If
                        If ConvertToDblSafe((txtShVT(0).Tag)) = 0 Then
                            ErrMsg(er_SHVattu)
                            txtShVT(0).Focus()
                            GoTo LoiBC
                        End If
                        If ChkDu(7).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(10).Tag)) = 0 Then
                            ErrMsg(er_SHTaiKhoan)
                            txtShVT(10).Focus()
                            GoTo LoiBC
                        End If
                        If ChkDu(16).CheckState Then
                            FrmChitietThekho.LietKethekho(IIf(OptKho(0).Checked, CboKho(0).SelectedIndex, 0), ConvertToDblSafe(txtShVT(0).Tag), IIf(OptTG(0).Checked, tdau, Ngay(1).ToOADate), IIf(OptTG(0).Checked, tcuoi, Ngay(2).ToOADate), True)
                            GoTo LoiBC
                        Else
                            If OptTG(0).Checked Then
                                If Not InTheKho2(IIf(OptKho(0).Checked, CboKho(0).SelectedIndex, 0), ConvertToDblSafe(txtShVT(0).Tag), tdau, tcuoi, True, IIf(ChkDu(4).CheckState = CheckState.Checked, CboLoai(1).SelectedIndex, 0), IIf(ChkDu(7).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(10).Tag)) > 0, txtShTk(10).Text, String.Empty), IIf(baocao = 64, 1, 0)) Then GoTo LoiBC
                            Else
                                If Not InTheKho2N(IIf(OptKho(0).Checked, CboKho(0).SelectedIndex, 0), ConvertToDblSafe(txtShVT(0).Tag), Ngay(1), Ngay(2), True, IIf(ChkDu(4).CheckState = CheckState.Checked, CboLoai(1).SelectedIndex, 0), IIf(ChkDu(7).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(10).Tag)) > 0, txtShTk(10).Text, String.Empty), IIf(baocao = 64, 1, 0)) Then GoTo LoiBC
                            End If
                        End If
                    Case 13
                        If CboKho(0).SelectedIndex < 0 Then
                            ErrMsg(er_KhoHang)
                            GoTo LoiBC
                        End If
                        If CboLoai(1).SelectedIndex < 0 Then
                            ErrMsg(er_NguonNX)
                            GoTo LoiBC
                        End If
                        StopPrint = False
                        mkho = CboKho(0).SelectedIndex
                        If Index = 0 Then
                            If InTheKho3(mkho, tdau, tcuoi) Then InBaoCaoRPT()
                        Else
                            rs_tk = ExecSQLReturnDT(String.Format("SELECT DISTINCT TonKho.MaVattu, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi FROM TonKho INNER JOIN Vattu ON TonKho.MaVattu=Vattu.MaSo WHERE TonKho.MaSoKho={0} ORDER BY Vattu.SoHieu", mkho))
                            k = ConvertToDblSafe(FrmGetStr.GetString(Ngonngu("Nhập số 0 để in sổ chi tiết vật tư hàng hoá, số 2 để in thẻ kho", "0 to print receipt books detailing supplies and goods, 2 to be in stock"), Ngonngu("In toàn bộ", "Print all"), "0"))
                            rptFrom.ReportDestination = 0
                            GauGe.Maximum = 100
                            For Each rsItem As DataRow In rs_tk.Rows
                                txtShVT(0).Text = ConvertToStrSafe(rsItem("SoHieu"))
                                LbTenVT(0).Text = ConvertToStrSafe(rsItem("TenVattu"))
                                txtShVT(0).Tag = ConvertToStrSafe(rsItem("MaVattu"))
                                SetRptInfo()
                                If InTheKho2(mkho, _
                                       ConvertToStrSafe(rsItem("MaVattu")), _
                                       tdau, _
                                       tcuoi, _
                                       False, _
                                       IIf(ChkDu(4).CheckState = CheckState.Checked, CboLoai(1).SelectedIndex, 0), _
                                       "", _
                                       k) Then
                                    HienThongBao(String.Format("{0} - {1}", rsItem("SoHieu"), rsItem("TenVattu")), 1)
                                    InBaoCaoRPT()
                                    AppIdle(Pdelay * 100)
                                End If
                                If GauGe.Value < GauGe.Maximum Then GauGe.Value += 1
                            Next
                        End If
                        GoTo LoiBC
                    Case 14, 65
                        If CboKho(0).SelectedIndex < 0 Then
                            ErrMsg(er_KhoHang)
                            GoTo LoiBC
                        End If
                        If ChkDu(2).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(4).Tag)) = 0 Then
                            ErrMsg(er_SHTKVT)
                            txtShTk(4).Focus()
                            GoTo LoiBC
                        End If
                        mkho = IIf(OptKho(0).Checked, CboKho(0).SelectedIndex, 0)
                        mloai = IIf(ChkDu(3).CheckState = CheckState.Checked, CboLoai(0).SelectedIndex, 0)
                        If baocao = 14 And ChkDu(16).CheckState Then
                            FrmTonkho.Hienthiluoi(Me)
                            GoTo LoiBC
                        Else
                            If OptTG(0).Checked Then
                                InLuyKe(GauGe, _
                                    mkho, _
                                    IIf(ChkDu(2).CheckState = CheckState.Unchecked, "", txtShTk(4).Text), _
                                    mloai, _
                                    tdau, _
                                    tcuoi, _
                                    True, _
                                    IIf(baocao = 65, 1, 0))
                            Else
                                InLuyKeN(GauGe, _
                                    mkho, _
                                    IIf(ChkDu(2).CheckState = CheckState.Unchecked, "", txtShTk(4).Text), _
                                    mloai, _
                                    Ngay(1), _
                                    Ngay(2), _
                                    True, _
                                    IIf(baocao = 65, 1, 0))
                            End If
                        End If
                    Case 46
                        If CboKho(0).SelectedIndex < 0 Then
                            ErrMsg(er_KhoHang)
                            GoTo LoiBC
                        End If
                        If ChkDu(2).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(4).Tag)) = 0 Then
                            ErrMsg(er_SHTKVT)
                            txtShTk(4).Focus()
                            GoTo LoiBC
                        End If
                        mkho = IIf(OptKho(0).Checked, CboKho(0).SelectedIndex, 0)
                        mtk = IIf(ChkDu(2).CheckState = CheckState.Unchecked, 0, ConvertToDblSafe(txtShTk(4).Tag))
                        mloai = IIf(ChkDu(3).CheckState = CheckState.Checked, CboLoai(0).SelectedIndex, 0)
                        InLuyKeX(mkho, mtk, mloai, tdau, tcuoi)
                        GoTo LoiBC
                    Case 52
                        If CboKho(0).SelectedIndex < 0 Then
                            ErrMsg(er_KhoHang)
                            GoTo LoiBC
                        End If
                        InLCNoiBo(CboKho(0).SelectedIndex, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(1), Ngay(2))
                        GoTo LoiBC
                    Case 47, 48
                        If CboKho(0).SelectedIndex < 0 Then
                            ErrMsg(er_KhoHang)
                            GoTo LoiBC
                        End If
                        If ChkDu(2).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(4).Tag)) = 0 Then
                            ErrMsg(er_SHTKVT)
                            txtShTk(4).Focus()
                            GoTo LoiBC
                        End If
                        mkho = IIf(OptKho(0).Checked, CboKho(0).SelectedIndex, 0)
                        mtk = IIf(ChkDu(2).CheckState = CheckState.Unchecked, 0, ConvertToDblSafe(txtShTk(4).Tag))
                        mloai = IIf(ChkDu(3).CheckState = CheckState.Checked, CboLoai(0).SelectedIndex, 0)
                        If OptTG(0).Checked Then
                            InLuyKeHM(GauGe, mkho, mtk, mloai, NgayCuoiThang(pNamTC, tcuoi), IIf(baocao = 47, -1, 1))
                        Else
                            InLuyKeHM(GauGe, mkho, mtk, mloai, Ngay(2), IIf(baocao = 47, -1, 1))
                        End If
                    Case 15, 16
                        If CboKho(0).SelectedIndex < 0 Then
                            ErrMsg(er_KhoHang)
                            GoTo LoiBC
                        End If
                        If ChkDu(2).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(4).Tag)) = 0 Then
                            ErrMsg(er_SHTKVT)
                            txtShTk(4).Focus()
                            GoTo LoiBC
                        End If
                        mkho = IIf(OptKho(0).Checked, CboKho(0).SelectedIndex, 0)
                        mtk = IIf(ChkDu(2).CheckState = CheckState.Unchecked, 0, ConvertToDblSafe(txtShTk(4).Tag))
                        mloai = IIf(ChkDu(3).CheckState = CheckState.Checked, CboLoai(0).SelectedIndex, 0)
                        MN = IIf(ChkDu(4).CheckState = CheckState.Checked, CboLoai(1).SelectedIndex, 0)
                        InNguonNhapXuat(GauGe, mkho, mtk, mloai, MN, tdau, tcuoi, IIf(baocao = 15, -1, 1), IIf(OptTG(1).Checked, 1, 0), Ngay(1), Ngay(2))
                    Case 44
                        If ConvertToDblSafe((txtShTk(11).Tag)) = 0 Then
                            ErrMsg(er_SHTaiKhoan)
                            txtShTk(11).Focus()
                            GoTo LoiBC
                        End If
                        mkho = IIf(OptKho(0).Checked, CboKho(0).SelectedIndex, 0)
                        mtk = IIf(ChkDu(2).CheckState = CheckState.Unchecked, 0, ConvertToDblSafe(txtShTk(4).Tag))
                        mloai = IIf(ChkDu(3).CheckState = CheckState.Checked, CboLoai(0).SelectedIndex, 0)
                        InTHXuatKho(IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(1), Ngay(2), mkho, mtk, mloai, txtShTk(11).Text)
                    Case 60, 77
                        If ConvertToDblSafe((txtCT(1).Tag)) = 0 Then
                            ErrMsg(er_SHThanhPham)
                            txtCT(1).Focus()
                            GoTo LoiBC
                        End If
                        mkho = IIf(OptKho(0).Checked, CboKho(0).SelectedIndex, 0)
                        mtk = IIf(ChkDu(2).CheckState = CheckState.Unchecked, 0, ConvertToDblSafe(txtShTk(4).Tag))
                        mloai = IIf(ChkDu(3).CheckState = CheckState.Checked, CboLoai(0).SelectedIndex, 0)
                        InTHXuatKhoDT(IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(1), Ngay(2), mkho, mtk, mloai, ConvertToDblSafe(txtCT(1).Tag), IIf(baocao = 60, 0, 1))
                    Case 55
                        mtk = IIf(ChkDu(2).CheckState = CheckState.Unchecked, 0, ConvertToDblSafe(txtShTk(4).Tag))
                        mloai = IIf(ChkDu(3).CheckState = CheckState.Checked, CboLoai(0).SelectedIndex, 0)
                        InBangKeTon(IIf(OptTG(0).Checked, tcuoi, 0), Ngay(2), mtk, mloai)
                        GoTo LoiBC
                End Select
                rptFrom.ReportDestination = Index
a:
                If Not RptOK(rptFrom.ReportFilename, nn) Then
                    MessageBox.Show(Ngonngu("Mẫu báo cáo đã bị thay đổi!", "Report form has been changed"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    GoTo LoiBC
                End If
                rptFrom.ReportWindowTitle = OptBC(baocao).Text

                InBaoCaoRPT()
                On Error GoTo Bad
                'frmMain.rpt.Action = 1
                On Error GoTo 0
                GoTo LoiBC
            Case 2
                Me.Close() : Exit Sub
            Case 3
                tdau = CboThang(0).SelectedIndex
                tcuoi = CboThang(1).SelectedIndex
                Select Case baocao
                    Case 14
                        If CboKho(0).SelectedIndex < 0 Then
                            ErrMsg(er_KhoHang)
                            GoTo LoiBC
                        End If
                        If ChkDu(2).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(4).Tag)) = 0 Then
                            ErrMsg(er_SHTKVT)
                            txtShTk(4).Focus()
                            GoTo LoiBC
                        End If
                        mkho = IIf(OptKho(0).Checked, CboKho(0).SelectedIndex, 0)
                        mloai = IIf(ChkDu(3).CheckState = CheckState.Checked, CboLoai(0).SelectedIndex, 0)
                        XuatExcelLuyKe(GauGe, mkho, mloai, tdau, tcuoi)
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
        MessageBox.Show(String.Format("Error {0}: {1}", Information.Err().Number, Information.Err().Description), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
LoiBC:
        HienThongBao(Me.Text, 1)
        GauGe.Value = GauGe.Maximum
        taikhoan = Nothing
        doiung = Nothing
        rs_tk = Nothing
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmSovattuhanghoabh_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            OptBC_CheckedChanged(OptBC(12), New EventArgs())
            AddMonthToCbo(CboThang(0))
            AddMonthToCbo(CboThang(1))
            InitDateVars(MedNgay(1), Ngay(1))
            InitDateVars(MedNgay(2), Ngay(2))
            Int_RecsetToCbo("SELECT MaSo As F2,TenKho As F1 FROM KhoHang ORDER BY TenKho", CboKho(0))
            Int_RecsetToCbo(String.Format("SELECT PhanLoaiVattu.MaSo As F2, (PhanLoaiVattu.SoHieu + ' - '+ PhanLoaiVattu.TenPhanLoai) As F1 FROM PhanLoaiVattu ORDER BY PhanLoaiVattu.SoHieu"), CboLoai(0))
            Int_RecsetToCbo("SELECT MaSo As F2,SoHieu + ' - ' + DienGiai As F1 FROM NguonNhapXuat ORDER BY SoHieu", CboLoai(1))
            Text = SetFormTitle(Text)
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
    Private Sub FrmSovattuhanghoabh_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        StopPrint = True
        xlapp = Nothing
        xlsheet = Nothing
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_1.Enter, _MedNgay_2.Enter
        Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
        MedNgay(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
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
    Private Sub txtCT_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtCT_1.Enter
        Dim Index As Integer = Array.IndexOf(txtCT, eventSender)
        txtCT(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtCT_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtCT_1.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtCT, eventSender)
        If KeyAscii = 13 Then
            txtCT(Index).Text = FrmTP.ChonTP(txtCT(Index).Text)
            txtCT(Index).Focus()
        End If
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
    Private Sub txtCT_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtCT_1.Leave
        Dim Index As Integer = Array.IndexOf(txtCT, eventSender)
        Dim m As Integer
        txtCT(Index).Text = txtCT(Index).Text.ToUpper()
        LbCT(Index).Text = ConvertToStrSafe(GetSelectValue(String.Format("SELECT TenVattu AS F1,MaSo AS F2 FROM TP154 WHERE SoHieu='{0}'", txtCT(Index).Text), m))
        txtCT(Index).Tag = ConvertToStrSafe(m)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShVT_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShVT_0.Enter
        Dim Index As Integer = Array.IndexOf(txtShVT, eventSender)
        txtShVT(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShVT_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtShVT_0.KeyPress
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
    Private Sub txtShVT_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShVT_0.Leave
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
    Private Sub txtShTk_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShTk_10.Enter, _txtShTk_4.Enter, _txtShTk_11.Enter
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        txtShTk(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtShTk_10.KeyPress, _txtShTk_4.KeyPress, _txtShTk_11.KeyPress
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
    Private Sub txtShTk_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShTk_10.Leave, _txtShTk_4.Leave, _txtShTk_11.Leave
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        txtShTk(Index).Text = txtShTk(Index).Text.ToUpper()
        Dim mtk As Integer = 0
        LbTenTk(Index).Text = tentk(txtShTk(Index).Text, mtk)
        txtShTk(Index).Tag = ConvertToStrSafe(mtk)
        HienThongBao(Me.Text, 1)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub OptBC_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptBC_12.CheckedChanged, _OptBC_13.CheckedChanged, _OptBC_14.CheckedChanged, _OptBC_15.CheckedChanged, _OptBC_16.CheckedChanged, _OptBC_44.CheckedChanged, _OptBC_46.CheckedChanged, _OptBC_47.CheckedChanged, _OptBC_48.CheckedChanged, _OptBC_52.CheckedChanged, _OptBC_55.CheckedChanged, _OptBC_60.CheckedChanged, _OptBC_64.CheckedChanged, _OptBC_65.CheckedChanged, _OptBC_43.CheckedChanged, _OptBC_74.CheckedChanged, _OptBC_77.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(OptBC, eventSender)

            Command(3).Enabled = OptBC(14).Checked
            ChkDu(16).CheckState = CheckState.Unchecked
            Select Case Index
                Case 12, 14, 64
                    ChkDu(16).Enabled = True
                Case Else
                    ChkDu(16).Enabled = False
            End Select
            Select Case Index
                Case 12, 14, 15, 16, 43, 44, 46, 47, 48, 52, 55, 60, 74, 77
                    OptTG(1).Enabled = True
                Case Else
                    OptTG_CheckedChanged(OptTG(0), New EventArgs())
                    OptTG(0).Checked = True
                    OptTG(1).Enabled = False
            End Select
            baocao = Index
            Label(0).Enabled = True
            CboThang(0).Enabled = True
            Label(1).Enabled = True
            CboThang(1).Enabled = True
        End If
    End Sub
    Sub Baocao152(ByRef mkho As Integer, ByRef tcuoi As Integer)
        Dim rs As DataTable
        Dim j As Integer
        Dim shtk As String = String.Empty
        Dim ncuoi As Date = NgayCuoiThang(pNamTC, tcuoi)
        Recycle(String.Format("{0}\temp\KIEMKE.XLS", pCurDir))
        Try
            File.Copy(String.Format("{0}REPORTS\KIEMKE.XLS", pCurDir), String.Format("{0}\temp\KIEMKE.XLS", pCurDir))
            xlapp = New Excel.Application()
            xlapp.Workbooks.Open(String.Format("{0}\temp\KIEMKE.XLS", pCurDir))
        Catch ex As Exception
        End Try
        Try
            xlsheet = xlapp.Worksheets(1)
            xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
            xlsheet.Cells(3, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_DB))
            xlsheet.Cells(4, 1) = String.Format("Kho :{0}", tenkho(mkho))
            rs = ExecSQLReturnDT(String.Format("SELECT DISTINCT HethongTK.SoHieu AS SHTK, HethongTK.Ten, Vattu.SoHieu, TenVattu, DonVi, (Tien_{0}) AS Tien, (Luong_{1}) AS Luong FROM (TonKho INNER JOIN HethongTK ON TonKho.MaTaiKhoan=HethongTK.MaSo) INNER JOIN Vattu ON TonKho.MaVattu=Vattu.MaSo WHERE (HethongTK.SoHieu LIKE '152%' OR HethongTK.SoHieu LIKE '153%' OR HethongTK.SoHieu LIKE '155%' OR HethongTK.SoHieu LIKE '156%') AND (Tien_{1}<>0 OR Luong_{1}<>0) AND MaSoKho={2} ORDER BY HethongTK.SoHieu, Vattu.SoHieu", _
                                     CThangDB2(tcuoi), _
                                     ConvertToStrSafe(CThangDB2(tcuoi)), _
                                     ConvertToStrSafe(mkho)))
            For Each rsItem As DataRow In rs.Rows
                j += 1
                If shtk <> ConvertToStrSafe(rsItem("shtk")) Then
                    shtk = ConvertToStrSafe(rsItem("shtk"))
                    xlsheet.Cells(7 + j, 2) = ConvertToStrSafe(rsItem("ten"))
                    xlsheet.Range(String.Format("A{0}", (7 + j)), String.Format("T{0}", (7 + j))).Font.Bold = True
                    Continue For
                End If
                xlsheet.Cells(7 + j, 1) = ConvertToStrSafe(j - 1)
                xlsheet.Cells(7 + j, 2) = ConvertToStrSafe(rsItem("TenVattu"))
                xlsheet.Cells(7 + j, 3) = ConvertToStrSafe(rsItem("SoHieu"))
                xlsheet.Cells(7 + j, 4) = ConvertToStrSafe(rsItem("DonVi"))
                xlsheet.Cells(7 + j, 5) = ConvertToStrSafe(rsItem("luong"))
                xlsheet.Cells(7 + j, 6) = ConvertToStrSafe(rsItem("tien"))
            Next
            With xlsheet.Range("A5", String.Format("T{0}", (7 + j)))
                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                .Borders.Weight = Excel.XlBorderWeight.xlThin
                Dim tempRefParam As Object = .Borders.Color
                tempRefParam = Color.FromArgb(0, 0, 0)
                Dim tempRefParam2 As Object = .RowHeight
                tempRefParam2 = 18
                Dim tempRefParam3 As Object = .VerticalAlignment
                tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
            End With
            XLSFooter(xlsheet, 10 + j, 20, NgayCuoiThang(pNamTC, tcuoi))
            xlapp.Workbooks(1).Save()
            xlapp.Workbooks.Close()
            CallExcel("\temp\KIEMKE.XLS")
        Catch
        End Try
    End Sub
    Sub InLCNoiBo(ByRef mkho As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date)
        Dim sokho, sovt As Integer
        Dim sh1 As String = String.Empty
        Dim T As Double
        Dim st As String = String.Empty
        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        Dim sql As String = String.Format("SELECT DISTINCT MaNguon FROM ChungTu WHERE MaLoai=4 AND MaKho={0} AND {1} GROUP BY MaNguon", _
                                mkho, _
                                wsql)
        Dim i As Integer = 0
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            GauGe.Maximum = 5
            Recycle(String.Format("{0}\temp\LCNoiBo.XLS", pCurDir))
            Try
                File.Copy(String.Format("{0}REPORTS\LCNoiBo.XLS", pCurDir), String.Format("{0}\temp\LCNoiBo.XLS", pCurDir))
                xlapp = New Excel.Application()
                xlapp.Workbooks.Open(String.Format("{0}\temp\LCNoiBo.XLS", pCurDir))
                xlsheet = xlapp.Worksheets(1)
            Catch ex As Exception
                Exit Sub
            End Try
            Try
                xlsheet.Cells(1, 1) = pTenCty
                xlsheet.Cells(2, 1) = pTenCn
                xlsheet.Cells(3, 1) = CboKho(0).Text
                xlsheet.Cells(5, 1) = ThoiGianN(ndau, ncuoi, nn)
                For Each rsItem As DataRow In rs.Rows
                    i += 1
                    xlsheet.Cells(7, 5 + 2 * i) = ConvertToStrSafe(rsItem("MaNguon"))
                    xlsheet.Cells(8, 5 + 2 * i) = "Lượng"
                    xlsheet.Cells(8, 6 + 2 * i) = "Tiền"
                    xlsheet.Range(String.Format("{0}7", XLSCol(5 + 2 * i)), String.Format("{0}7", XLSCol(6 + 2 * i))).MergeCells = True
                Next
                sokho = i
                GauGe.Value = 2
                sql = String.Format("SELECT DISTINCT MaVattu FROM ChungTu WHERE MaLoai=4 AND MaKho={0} AND {1} GROUP BY MaVattu", _
                          mkho, _
                          wsql)
                i = 0
                rs = ExecSQLReturnDT(sql)
                For Each rsItem As DataRow In rs.Rows
                    i += 1
                    xlsheet.Cells(8 + i, 2) = ConvertToStrSafe(rsItem("MaVattu"))
                Next
                sovt = i
                xlsheet.Cells(sovt + 9, 2) = "Tổng cộng"
                GauGe.Value = 3
                For i = 1 To sovt
                    sh1 = ""
                    st = ""
                    For j As Integer = 1 To sokho
                        xlsheet.Cells(8 + i, 5 + 2 * j) = Format(ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(SoPS2Co) AS F1,Sum(SoPS) AS F2 FROM ChungTu WHERE MaLoai=4 AND MaKho={0} AND {1} AND MaNguon={2} AND MaVattu={3}", _
                                                                                     mkho, _
                                                                                     wsql, _
                                                                                     xlsheet.Cells(7, 5 + 2 * j), _
                                                                                     xlsheet.Cells(8 + i, 2)), T)), Mask_2)
                        xlsheet.Cells(8 + i, 6 + 2 * j) = CStr(T)
                        sh1 = String.Format("{0}+{1}{2}", sh1, XLSCol(5 + 2 * j), ConvertToStrSafe(8 + i))
                        st = String.Format("{0}+{1}{2}", st, XLSCol(6 + 2 * j), ConvertToStrSafe(8 + i))
                    Next
                    xlsheet.Range(String.Format("E{0}", (8 + i))).Formula = String.Format("={0}" = sh1) 'Excel Fomular
                    xlsheet.Range(String.Format("F{0}", (8 + i))).Formula = String.Format("={0}" = st) 'Excel Fomular
                    sh1 = ""
                    xlsheet.Cells(8 + i, 1) = ConvertToStrSafe(i)
                    xlsheet.Cells(8 + i, 2) = TenVT(sh1, ConvertToDblSafe((xlsheet.Cells(8 + i, 2))), st)
                    xlsheet.Cells(8 + i, 3) = sh1
                    xlsheet.Cells(8 + i, 4) = st
                Next
                GauGe.Value = 4
                For i = 1 To sokho
                    xlsheet.Range(String.Format("{0}{1}", XLSCol(6 + 2 * i), ConvertToStrSafe(sovt + 9))).Formula = String.Format("=SUM({0}9:{0}{1})" = _
                                                                                                                        XLSCol(6 + 2 * i), _
                                                                                                                        sovt + 8) 'Excel Fomular
                    xlsheet.Cells(7, 5 + 2 * i) = tenkho(ConvertToDblSafe((xlsheet.Cells(7, 5 + 2 * i))))
                Next
                xlsheet.Range(String.Format("F{0}", (sovt + 9))).Formula = String.Format("=SUM(F9:F{0})" = (sovt + 8)) 'Excel Fomular
                With xlsheet.Range("A7", String.Format("{0}{1}", XLSCol(2 * sokho + 6), ConvertToStrSafe(sovt + 9)))
                    .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    .Borders.Weight = Excel.XlBorderWeight.xlThin
                    Dim tempRefParam As Object = .Borders.Color
                    tempRefParam = Color.FromArgb(0, 0, 0)
                    Dim tempRefParam2 As Object = .RowHeight
                    tempRefParam2 = 18
                    .Font.Size = 6
                    Dim tempRefParam3 As Object = .VerticalAlignment
                    tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
                End With
                xlapp.Workbooks(1).Save()
                xlapp.Workbooks.Close()
                xlsheet = Nothing
                xlapp = Nothing
                GauGe.Value = 3
                CallExcel("\temp\LCNoiBo.XLS")
            Catch ex As Exception
            End Try
        End If
    End Sub
    Sub BKSanLuong(ByRef mk As Integer, ByRef mloai As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef shtk As String)
        Dim rs As DataTable
        Dim pl3 = String.Empty, pl1 = String.Empty, pl2 = String.Empty, wsql As String = String.Empty
        Dim somn, tt, r, sokho As Integer
        Dim lx, luong, tien, tx As Double
        Dim mkho(0) As Integer, MN(0) As Integer
        Dim xlsheet2, xlsheet3 As Excel.Worksheet
        Recycle(String.Format("{0}\temp\SANLUONG.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}REPORTS\SANLUONG.XLS", pCurDir), String.Format("{0}\temp\SANLUONG.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\SANLUONG.XLS", pCurDir))
        xlsheet = xlapp.Worksheets(1)
        xlsheet2 = xlapp.Worksheets(2)
        xlsheet3 = xlapp.Worksheets(3)
        wsql = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        On Error GoTo 0
        xlsheet.Cells(1, 1) = pTenCty
        xlsheet.Cells(2, 1) = pTenCn
        If mk > 0 Then
            xlsheet.Cells(3, 1) = tenkho(mk)
            xlsheet2.Cells(3, 1) = (xlsheet.Cells(3, 1))
            xlsheet3.Cells(3, 1) = (xlsheet.Cells(3, 1))
        End If
        xlsheet.Cells(5, 1) = IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi, nn))
        xlsheet2.Cells(5, 1) = (xlsheet.Cells(5, 1))
        xlsheet3.Cells(5, 1) = (xlsheet.Cells(5, 1))
        If mk > 0 Then
            rs = ExecSQLReturnDT(String.Format("SELECT TenKho, KhoHang.MaSo FROM  ({0}) INNER JOIN KhoHang ON ChungTu.MaNguon=KhoHang.MaSo WHERE MaLoai=4 AND HethongTK.SoHieu LIKE '{1}%' AND {2}{3} GROUP BY TenKho, KhoHang.MaSo", _
                                     ChungTu2TKNC(1), _
                                     shtk, _
                                     wsql, _
                                     (IIf(mk > 0, String.Format(" AND MaKho={0}", mk), String.Empty))))
            For Each rsItem As DataRow In rs.Rows
                sokho += 1
                xlsheet.Range(String.Format("{0}8", XLSCol(11 + 2 * sokho)), String.Format("{0}8", XLSCol(12 + 2 * sokho))).MergeCells = True
                xlsheet.Cells(8, 11 + 2 * sokho) = ConvertToStrSafe(rsItem("tenkho"))
                xlsheet2.Cells(8, 8 + sokho) = ConvertToStrSafe(rsItem("tenkho"))
                xlsheet3.Cells(8, 8 + sokho) = ConvertToStrSafe(rsItem("tenkho"))
                xlsheet.Cells(9, 11 + 2 * sokho) = "Lượng"
                xlsheet.Cells(9, 12 + 2 * sokho) = "Tiền"
                ReDim Preserve mkho(sokho - 1)
                mkho(sokho - 1) = ConvertToDblSafe(rsItem("MaSo"))
            Next
            If sokho > 0 Then
                xlsheet.Range("M7", String.Format("{0}7", XLSCol(12 + 2 * sokho))).MergeCells = True
            End If
            If sokho > 1 Then
                xlsheet2.Range("I7", String.Format("{0}7", XLSCol(8 + sokho))).MergeCells = True
                xlsheet3.Range("I7", String.Format("{0}7", XLSCol(8 + sokho))).MergeCells = True
            End If
        End If
        rs = ExecSQLReturnDT(String.Format("SELECT NguonNhapXuat.DienGiai, NguonNhapXuat.MaSo FROM NguonNhapXuat INNER JOIN ChungTu ON NguonNhapXuat.MaSo=ChungTu.MaNguon WHERE ChungTu.MaLoai=8 AND {0}{1} GROUP BY NguonNhapXuat.DienGiai, NguonNhapXuat.MaSo", _
                                 wsql, _
                                 (IIf(mk > 0, String.Format(" AND MaKho={0}", mk), String.Empty))))
        For Each rsItem As DataRow In rs.Rows
            somn += 1
            xlsheet.Range(String.Format("{0}8", XLSCol(11 + 2 * sokho + 2 * somn)), String.Format("{0}8", XLSCol(12 + 2 * sokho + 2 * somn))).MergeCells = True
            xlsheet.Cells(8, 11 + 2 * sokho + 2 * somn) = ConvertToStrSafe(rsItem("DienGiai"))
            xlsheet.Cells(9, 11 + 2 * sokho + 2 * somn) = "Lượng"
            xlsheet.Cells(9, 12 + 2 * sokho + 2 * somn) = "Tiền"
            xlsheet2.Cells(8, 8 + sokho + somn) = ConvertToStrSafe(rsItem("DienGiai"))
            xlsheet3.Cells(8, 8 + sokho + somn) = ConvertToStrSafe(rsItem("DienGiai"))
            ReDim Preserve MN(somn - 1)
            MN(somn - 1) = ConvertToDblSafe(rsItem("MaSo"))
        Next
        If somn > 0 Then xlsheet.Range(String.Format("{0}7", XLSCol(13 + 2 * sokho)), String.Format("{0}7", XLSCol(12 + 2 * sokho + 2 * somn))).MergeCells = True
        If somn > 1 Then
            xlsheet2.Range(String.Format("{0}7", XLSCol(9 + sokho)), String.Format("{0}7", XLSCol(8 + sokho + somn))).MergeCells = True
            xlsheet3.Range(String.Format("{0}7", XLSCol(9 + sokho)), String.Format("{0}7", XLSCol(8 + sokho + somn))).MergeCells = True
        End If
        xlsheet.Cells(7, 13 + 2 * sokho) = "Xuất bán theo kênh phân phối"
        xlsheet2.Cells(7, 9 + sokho) = xlsheet.Cells(7, 13 + 2 * sokho)
        xlsheet3.Cells(7, 9 + sokho) = xlsheet.Cells(7, 13 + 2 * sokho)
        r = 10
        InLuyKeN(GauGe, mk, shtk, mloai, ndau, ncuoi)
        rs = ExecSQLReturnDT("SELECT * FROM QLuyKe ORDER BY SHPL1, SHPL2, SHPL3, SoHieu")
        For Each rsItem As DataRow In rs.Rows
            If Not IsDBNull(rsItem("SHPL1")) Then
                If pl1 <> ConvertToStrSafe(rsItem("SHPL1")) Then
                    pl1 = ConvertToStrSafe(rsItem("SHPL1"))
                    r += 1
                    xlsheet.Cells(r, 2) = ConvertToStrSafe(rsItem("TenPL1"))
                    xlsheet.Cells(r, 3) = ConvertToStrSafe(rsItem("SHPL1"))
                    xlsheet.Range(String.Format("A{0}", r), String.Format("{0}{1}", XLSCol(18 + 2 * sokho), r)).Font.Bold = True
                    xlsheet2.Cells(r, 2) = ConvertToStrSafe(rsItem("TenPL1"))
                    xlsheet2.Cells(r, 3) = ConvertToStrSafe(rsItem("SHPL1"))
                    xlsheet2.Range(String.Format("A{0}", r), String.Format("{0}{1}", XLSCol(18 + 2 * sokho), r)).Font.Bold = True
                    xlsheet3.Cells(r, 2) = ConvertToStrSafe(rsItem("TenPL1"))
                    xlsheet3.Cells(r, 3) = ConvertToStrSafe(rsItem("SHPL1"))
                    xlsheet3.Range(String.Format("A{0}", r), String.Format("{0}{1}", XLSCol(18 + 2 * sokho), r)).Font.Bold = True
                End If
            End If
            If Not IsDBNull(ConvertToStrSafe(rsItem("SHPL2"))) Then
                If pl2 <> ConvertToStrSafe(rsItem("SHPL2")) Then
                    pl2 = ConvertToStrSafe(rsItem("SHPL2"))
                    r += 1
                    xlsheet.Cells(r, 2) = ConvertToStrSafe(rsItem("TenPL2"))
                    xlsheet.Cells(r, 3) = ConvertToStrSafe(rsItem("SHPL2"))
                    xlsheet.Range(String.Format("A{0}", r), String.Format("{0}{1}", XLSCol(18 + 2 * sokho), r)).Font.Bold = True
                    xlsheet.Range(String.Format("A{0}", r), String.Format("{0}{1}", XLSCol(18 + 2 * sokho), r)).Font.Italic = True
                    xlsheet2.Cells(r, 2) = ConvertToStrSafe(rsItem("TenPL2"))
                    xlsheet2.Cells(r, 3) = ConvertToStrSafe(rsItem("SHPL2"))
                    xlsheet2.Range(String.Format("A{0}", r), String.Format("{0}{1}", XLSCol(18 + 2 * sokho), r)).Font.Bold = True
                    xlsheet2.Range(String.Format("A{0}", r), String.Format("{0}{1}", XLSCol(18 + 2 * sokho), r)).Font.Italic = True
                    xlsheet3.Cells(r, 2) = ConvertToStrSafe(rsItem("TenPL2"))
                    xlsheet3.Cells(r, 3) = ConvertToStrSafe(rsItem("SHPL2"))
                    xlsheet3.Range(String.Format("A{0}", r), String.Format("{0}{1}", XLSCol(18 + 2 * sokho), r)).Font.Bold = True
                    xlsheet3.Range(String.Format("A{0}", r), String.Format("{0}{1}", XLSCol(18 + 2 * sokho), r)).Font.Italic = True
                End If
            End If
            If Not IsDBNull(ConvertToStrSafe(rsItem("SHPL3"))) Then
                If pl3 <> ConvertToStrSafe(rsItem("SHPL3")) Then
                    pl3 = ConvertToStrSafe(rsItem("SHPL3"))
                    r += 1
                    xlsheet.Cells(r, 2) = ConvertToStrSafe(rsItem("TenPL3"))
                    xlsheet.Cells(r, 3) = ConvertToStrSafe(rsItem("SHPL3"))
                    xlsheet.Range(String.Format("A{0}", r), String.Format("{0}{1}", XLSCol(18 + 2 * sokho), r)).Font.Bold = True
                    xlsheet.Range(String.Format("A{0}", r), String.Format("{0}{1}", XLSCol(18 + 2 * sokho), r)).Font.Italic = True
                    xlsheet2.Cells(r, 2) = ConvertToStrSafe(rsItem("TenPL3"))
                    xlsheet2.Cells(r, 3) = ConvertToStrSafe(rsItem("SHPL3"))
                    xlsheet2.Range(String.Format("A{0}", r), String.Format("{0}{1}", XLSCol(18 + 2 * sokho), r)).Font.Bold = True
                    xlsheet2.Range(String.Format("A{0}", r), String.Format("{0}{1}", XLSCol(18 + 2 * sokho), r)).Font.Italic = True
                    xlsheet3.Cells(r, 2) = ConvertToStrSafe(rsItem("TenPL3"))
                    xlsheet3.Cells(r, 3) = ConvertToStrSafe(rsItem("SHPL3"))
                    xlsheet3.Range(String.Format("A{0}", r), String.Format("{0}{1}", XLSCol(18 + 2 * sokho), r)).Font.Bold = True
                    xlsheet3.Range(String.Format("A{0}", r), String.Format("{0}{1}", XLSCol(18 + 2 * sokho), r)).Font.Italic = True
                End If
            End If
            tt += 1
            r += 1
            xlsheet.Cells(r, 1) = ConvertToStrSafe(tt)
            xlsheet.Cells(r, 2) = ConvertToStrSafe(rsItem("TenVattu"))
            xlsheet.Cells(r, 3) = ConvertToStrSafe(rsItem("SoHieu"))
            xlsheet.Cells(r, 4) = ConvertToStrSafe(rsItem("DonVi"))
            xlsheet2.Cells(r, 1) = ConvertToStrSafe(tt)
            xlsheet2.Cells(r, 2) = ConvertToStrSafe(rsItem("TenVattu"))
            xlsheet2.Cells(r, 3) = ConvertToStrSafe(rsItem("SoHieu"))
            xlsheet2.Cells(r, 4) = ConvertToStrSafe(rsItem("DonVi"))
            xlsheet3.Cells(r, 1) = ConvertToStrSafe(tt)
            xlsheet3.Cells(r, 2) = ConvertToStrSafe(rsItem("TenVattu"))
            xlsheet3.Cells(r, 3) = ConvertToStrSafe(rsItem("SoHieu"))
            xlsheet3.Cells(r, 4) = ConvertToStrSafe(rsItem("DonVi"))
            xlsheet.Cells(r, 5) = ConvertToStrSafe(rsItem("dkluong"))
            xlsheet.Cells(r, 6) = ConvertToStrSafe(rsItem("dktien"))
            xlsheet.Cells(r, 7) = ConvertToStrSafe(rsItem("luongnhap"))
            xlsheet.Cells(r, 8) = ConvertToStrSafe(rsItem("tiennhap"))
            xlsheet.Cells(r, 9) = ConvertToStrSafe(rsItem("luongxuat"))
            xlsheet.Cells(r, 10) = ConvertToStrSafe(rsItem("tienxuat"))
            xlsheet.Cells(r, 11) = ConvertToStrSafe(rsItem("ckluong"))
            xlsheet.Cells(r, 12) = ConvertToStrSafe(rsItem("CKTien"))
            xlsheet2.Cells(r, 5) = ConvertToStrSafe(rsItem("dkluong"))
            xlsheet3.Cells(r, 5) = ConvertToStrSafe(rsItem("dktien"))
            xlsheet2.Cells(r, 6) = ConvertToStrSafe(rsItem("luongnhap"))
            xlsheet3.Cells(r, 6) = ConvertToStrSafe(rsItem("tiennhap"))
            xlsheet2.Cells(r, 7) = ConvertToStrSafe(rsItem("luongxuat"))
            xlsheet3.Cells(r, 7) = ConvertToStrSafe(rsItem("tienxuat"))
            xlsheet2.Cells(r, 8) = ConvertToStrSafe(rsItem("ckluong"))
            xlsheet3.Cells(r, 8) = ConvertToStrSafe(rsItem("CKTien"))
            lx = 0
            tx = 0
            If mk > 0 Then
                For i As Integer = 1 To sokho
                    luong = XuatTheoKho(mk, mkho(i - 1), ConvertToStrSafe(rsItem("mvt")), ndau, ncuoi, tien)
                    xlsheet.Cells(r, 11 + 2 * i) = luong
                    xlsheet.Cells(r, 12 + 2 * i) = tien
                    xlsheet2.Cells(r, 8 + i) = luong
                    xlsheet3.Cells(r, 8 + i) = tien
                    lx += luong
                    tx += tien
                Next
            End If
            For i As Integer = 1 To somn
                luong = XuatBan(shtk, mk, MN(i - 1), ConvertToStrSafe(rsItem("mvt")), ndau, ncuoi, tien)
                xlsheet.Cells(r, 11 + 2 * sokho + 2 * i) = luong
                xlsheet.Cells(r, 12 + 2 * sokho + 2 * i) = tien
                xlsheet2.Cells(r, 8 + sokho + i) = luong
                xlsheet3.Cells(r, 8 + sokho + i) = tien
                lx += luong
                tx += tien
            Next
        Next
        If r > 1 Then
            xlsheet.Cells(r + 1, 2) = "Tổng cộng"
            xlsheet2.Cells(r + 1, 2) = (xlsheet.Cells(r + 1, 2))
            xlsheet3.Cells(r + 1, 2) = (xlsheet.Cells(r + 1, 2))
            For i As Integer = 6 To 12 + 2 * sokho + 2 * somn
                xlsheet.Range(String.Format("{0}{1}", XLSCol(i), ConvertToStrSafe(r + 1))).Formula = String.Format("=Sum({0}10:{0}{1})" = XLSCol(i), ConvertToStrSafe(r)) 'Excel Fomular
            Next
            For i As Integer = 5 To 8 + sokho + somn
                xlsheet2.Range(String.Format("{0}{1}", XLSCol(i), r + 1)).Formula = String.Format("=Sum({0}10:{0}{1})", XLSCol(i), ConvertToStrSafe(r)) 'Excel Fomular
                xlsheet3.Range(String.Format("{0}{1}", XLSCol(i), r + 1)).Formula = String.Format("=Sum({0}10:{0}{1})", XLSCol(i), ConvertToStrSafe(r)) 'Excel Fomular
            Next
        End If
        With xlsheet.Range("A7", String.Format("{0}{1}", XLSCol(12 + 2 * sokho + 2 * somn), ConvertToStrSafe(r + 1)))
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders.Weight = Excel.XlBorderWeight.xlThin
            Dim tempRefParam As Object = .Borders.Color
            tempRefParam = Color.FromArgb(0, 0, 0)
            Dim tempRefParam2 As Object = .RowHeight
            tempRefParam2 = 18
            Dim tempRefParam3 As Object = .VerticalAlignment
            tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
        End With
        With xlsheet2.Range("A7", String.Format("{0}{1}", XLSCol(8 + sokho + somn), ConvertToStrSafe(r + 1)))
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders.Weight = Excel.XlBorderWeight.xlThin
            Dim tempRefParam4 As Object = .Borders.Color
            tempRefParam4 = Color.FromArgb(0, 0, 0)
            Dim tempRefParam5 As Object = .RowHeight
            tempRefParam5 = 18
            Dim tempRefParam6 As Object = .VerticalAlignment
            tempRefParam6 = Excel.XlVAlign.xlVAlignCenter
        End With
        With xlsheet3.Range("A7", String.Format("{0}{1}", XLSCol(8 + sokho + somn), ConvertToStrSafe(r + 1)))
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders.Weight = Excel.XlBorderWeight.xlThin
            Dim tempRefParam7 As Object = .Borders.Color
            tempRefParam7 = Color.FromArgb(0, 0, 0)
            Dim tempRefParam8 As Object = .RowHeight
            tempRefParam8 = 18
            Dim tempRefParam9 As Object = .VerticalAlignment
            tempRefParam9 = Excel.XlVAlign.xlVAlignCenter
        End With
        rs = Nothing
        xlsheet.Range("A1", String.Format("{0}{1}", XLSCol(12 + 2 * sokho + 2 * somn), ConvertToStrSafe(r + 1))).Copy()
        xlapp.Worksheets.Add(xlapp.Sheets(4), , 1)
        xlsheet = xlapp.Worksheets(4)
        xlsheet.Range("A1", String.Format("{0}{1}", XLSCol(12 + 2 * sokho + 2 * somn), ConvertToStrSafe(r + 1))).PasteSpecial()
        xlsheet.Cells(4, 1) = "Phiếu xuất thành phẩm"
        xlsheet.Range("E1", String.Format("H{0}", r + 1)).Delete()
        xlsheet.Range("K1", String.Format("L{0}", r + 1)).Delete()
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        xlsheet2 = Nothing
        xlsheet3 = Nothing
        CallExcel("\temp\SANLUONG.XLS")
KetThuc:
        Erase mkho
        Erase MN
    End Sub
    Sub InBangKeTon(ByRef tcuoi As Integer, ByRef Ngay As Date, ByRef mtk As Integer, ByRef mloai As Integer)
        Dim sokho, sovt As Integer
        Dim sh1 As String = String.Empty
        Dim T As Double
        Dim st As String = String.Empty
        Dim wsql As String = IIf(tcuoi > 0, WThang("ThangCT", 0, tcuoi), WNgay("NgayGS", #1/1/1980#, Ngay))
        ExecSQLNonQuery("DELETE FROM BaoCaoCP")
        GauGe.Maximum = 3
        ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP (MaSo,SoHieu,MaCha,BC_ID,Kq1,Kq2,Ten) SELECT (TonKho.MaSo),ConvertToStrSafe((TonKho.MaSo)),MaSoKho,MaVattu,Sum(Luong_0),Sum(Tien_0),Vattu.SoHieu FROM (TonKho INNER JOIN Vattu ON TonKho.MaVattu=Vattu.MaSo) INNER JOIN PhanLoaiVattu ON Vattu.MaPhanLoai=PhanLoaiVattu.MaSo WHERE (True) {0}{1} GROUP BY MaSoKho,Vattu.SoHieu,MaVattu", (IIf(mtk > 0, " AND MaTaiKhoan=" & mtk, String.Empty)), (IIf(mloai > 0, " AND PhanLoaiVattu.SoHieu LIKE '" & MaSo2SoHieu(mloai, "PhanLoaiVattu") & "%'", String.Empty))))
        ' Tinh dau ky
        ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
        ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,MaCha,BC_ID,Kq1,Kq2) SELECT (ChungTu.MaSo),ConvertToStrSafe((ChungTu.MaSo)),CASE WHEN (MaLoai=1) THEN MaKho ELSE MaNguon END,MaVattu,Sum(SoPS2No),Sum(SoPS) FROM ({0}) INNER JOIN BaoCaoCP ON ChungTu.MaVattu=BaoCaoCP.BC_ID AND ((ChungTu.MaKho=BaoCaoCP.MaCha AND MaLoai=1) OR (ChungTu.MaNguon=BaoCaoCP.MaCha AND MaLoai=4))  WHERE (MaLoai=1 OR MaLoai=4) AND TK_ID={1} AND {2}{3} GROUP BY  CASE WHEN (MaLoai=1) THEN MaKho ELSE MaNguon END,MaVattu", ChungTu2TKNC(-1), TKVT_ID, wsql, (IIf(mtk > 0, " AND MaTKNo=" & mtk, String.Empty))))
        ExecSQLNonQuery("UPDATE BaoCaoCP INNER JOIN BaoCaoCP2 ON BaoCaoCP.MaCha=BaoCaoCP2.MaCha AND BaoCaoCP.BC_ID=BaoCaoCP2.BC_ID SET BaoCaoCP.Kq1=BaoCaoCP.Kq1+BaoCaoCP2.Kq1,BaoCaoCP.Kq2=BaoCaoCP.Kq2+BaoCaoCP2.Kq2")
        ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
        ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,MaCha,BC_ID,Kq1,Kq2) SELECT (ChungTu.MaSo),ConvertToStrSafe((ChungTu.MaSo)),MaKho,MaVattu,Sum(SoPS2Co),Sum(SoPS) FROM ({0}) INNER JOIN BaoCaoCP ON ChungTu.MaKho=BaoCaoCP.MaCha AND ChungTu.MaVattu=BaoCaoCP.BC_ID  WHERE (MaLoai=2 OR MaLoai=4) AND TK_ID={1} AND {2}{3} GROUP BY MaKho,MaVattu", ChungTu2TKNC(1), TKVT_ID, wsql, (IIf(mtk > 0, " AND MaTKCo=" & mtk, String.Empty))))
        ExecSQLNonQuery("UPDATE BaoCaoCP INNER JOIN BaoCaoCP2 ON BaoCaoCP.MaCha=BaoCaoCP2.MaCha AND BaoCaoCP.BC_ID=BaoCaoCP2.BC_ID SET BaoCaoCP.Kq1=BaoCaoCP.Kq1-BaoCaoCP2.Kq1,BaoCaoCP.Kq2=BaoCaoCP.Kq2-BaoCaoCP2.Kq2")
        ExecSQLNonQuery("DELETE FROM BaoCaoCP WHERE Kq1=0 AND Kq2=0")
        Dim sql As String = "SELECT DISTINCT MaCha FROM BaoCaoCP GROUP BY MaCha"
        Dim i As Integer = 0
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        If Not (rs.Rows.Count = 0) Then
            GauGe.Maximum = 5
            Recycle(String.Format("{0}\temp\LCNoiBo.XLS", pCurDir))
            Try
                File.Copy(String.Format("{0}REPORTS\LCNoiBo.XLS", pCurDir), String.Format("{0}\temp\LCNoiBo.XLS", pCurDir))
                xlapp = New Excel.Application()
                xlapp.Workbooks.Open(String.Format("{0}\temp\LCNoiBo.XLS", pCurDir))
                xlsheet = xlapp.Worksheets(1)
            Catch
                Exit Sub
            End Try
            Try
                xlsheet.Cells(1, 1) = pTenCty
                xlsheet.Cells(2, 1) = pTenCn
                xlsheet.Cells(4, 1) = "Bảng tổng hợp tồn kho"
                xlsheet.Cells(5, 1) = IIf(tcuoi > 0, ThoiGianN(NgayCuoiThang(pNamTC, tcuoi), NgayCuoiThang(pNamTC, tcuoi), nn), ThoiGianN(Ngay, Ngay, nn))
                xlsheet.Cells(7, 5) = "Tổng tồn kho"
                For Each rsItem As DataRow In rs.Rows
                    i += 1
                    xlsheet.Cells(7, 5 + 2 * i) = ConvertToStrSafe(rsItem("macha"))
                    xlsheet.Cells(8, 5 + 2 * i) = "Lượng"
                    xlsheet.Cells(8, 6 + 2 * i) = "Tiền"
                    xlsheet.Range(String.Format("{0}7", XLSCol(5 + 2 * i)), String.Format("{0}7", XLSCol(6 + 2 * i))).MergeCells = True
                Next
                sokho = i
                GauGe.Value = 2
                sql = "SELECT DISTINCT BC_ID,Ten FROM BaoCaoCP GROUP BY BC_ID,Ten ORDER BY Ten"
                i = 0
                rs = ExecSQLReturnDT(sql)
                For Each rsItem As DataRow In rs.Rows
                    i += 1
                    xlsheet.Cells(8 + i, 2) = ConvertToStrSafe(rsItem("BC_ID"))
                Next
                sovt = i
                xlsheet.Cells(sovt + 9, 2) = "Tổng cộng"
                GauGe.Value = 3
                For i = 1 To sovt
                    sh1 = ""
                    st = ""
                    For j As Integer = 1 To sokho
                        xlsheet.Cells(8 + i, 5 + 2 * j) = Format(ConvertToDblSafe(GetSelectValue("SELECT Kq1 AS F1,Kq2 AS F2 FROM BaoCaoCP WHERE MaCha=" & xlsheet.Cells(7, 5 + 2 * j) & " AND BC_ID=" & xlsheet.Cells(8 + i, 2), T)), Mask_2)
                        xlsheet.Cells(8 + i, 6 + 2 * j) = CStr(T)
                        sh1 = String.Format("{0}+{1}{2}", _
                                  sh1, _
                                  XLSCol(5 + 2 * j), _
                                  8 + i)
                        st = String.Format("{0}+{1}{2}", _
                                 st, _
                                 XLSCol(6 + 2 * j), _
                                 8 + i)
                    Next
                    xlsheet.Range(String.Format("E{0}", (8 + i))).Formula = String.Format("={0}" = sh1) 'Excel Fomular
                    xlsheet.Range(String.Format("F{0}", (8 + i))).Formula = String.Format("={0}" = st) 'Excel Fomular
                    sh1 = ""
                    xlsheet.Cells(8 + i, 1) = ConvertToStrSafe(i)
                    xlsheet.Cells(8 + i, 2) = TenVT(sh1, ConvertToDblSafe(xlsheet.Cells(8 + i, 2)), st)
                    xlsheet.Cells(8 + i, 3) = sh1
                    xlsheet.Cells(8 + i, 4) = st
                Next
                GauGe.Value = 4
                For i = 1 To sokho
                    xlsheet.Range(String.Format("{0}{1}", XLSCol(6 + 2 * i), (sovt + 9))).Formula = String.Format("=SUM({0}9:{0}{1})" = _
                                                                                                        XLSCol(6 + 2 * i), _
                                                                                                        sovt + 8) 'Excel Fomular
                    xlsheet.Cells(7, 5 + 2 * i) = tenkho(ConvertToDblSafe((xlsheet.Cells(7, 5 + 2 * i))))
                Next
                xlsheet.Range(String.Format("F{0}", (sovt + 9))).Formula = String.Format("=SUM(F9:F{0})" = sovt + 8) 'Excel Fomular
                With xlsheet.Range("A7", String.Format("{0}{1}", XLSCol(2 * sokho + 6), (sovt + 9)))
                    .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    .Borders.Weight = Excel.XlBorderWeight.xlThin
                    Dim tempRefParam As Object = .Borders.Color
                    tempRefParam = Color.FromArgb(0, 0, 0)
                    Dim tempRefParam2 As Object = .RowHeight
                    tempRefParam2 = 18
                    .Font.Size = 6
                    Dim tempRefParam3 As Object = .VerticalAlignment
                    tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
                End With
                xlapp.Workbooks(1).Save()
                xlapp.Workbooks.Close()
                xlsheet = Nothing
                xlapp = Nothing
                GauGe.Value = 3
                CallExcel("\temp\LCNoiBo.XLS")
            Catch
            End Try
        End If
    End Sub
    Sub InLuyKeX(ByRef mkho As Integer, ByRef mtk As Integer, ByRef mloai As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim sql, st As String
        Dim sqltx As New StringBuilder
        Dim sqltn As New StringBuilder
        Dim sqllx As New StringBuilder
        Dim sqlln As New StringBuilder
        Dim i As Integer
        Dim rs As DataTable
        Dim tx, T, l1, lx As Double
        Dim j As Integer
        Recycle(String.Format("{0}\temp\LUYKE.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}REPORTS\LUYKE.XLS", pCurDir), String.Format("{0}\temp\LUYKE.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\LUYKE.XLS", pCurDir))
        xlsheet = xlapp.Worksheets(1)
        On Error GoTo 0
        xlsheet.Cells(1, 1) = pTenCty
        xlsheet.Cells(2, 1) = pTenCn
        If mkho > 0 Then xlsheet.Cells(3, 1) = CboKho(0).Text
        xlsheet.Cells(5, 1) = ThoiGianTheoThang(tdau, tcuoi)
        GauGe.Maximum = 3
        For i = CThangDB2(tdau) To CThangDB2(tcuoi)
            If sqlln.Length = 0 Then
                sqlln.Append(String.Format("TonKho.Luong_Nhap_{0}", i))
            Else
                sqlln.Append(String.Format(" + TonKho.Luong_Nhap_{0}", i))
            End If

            If sqllx.Length = 0 Then
                sqllx.Append(String.Format("TonKho.Luong_Xuat_{0}", i))
            Else
                sqllx.Append(String.Format(" + TonKho.Luong_Xuat_{0}", i))
            End If

            If sqltn.Length = 0 Then
                sqltn.Append(String.Format("TonKho.TonKho.Tien_Nhap_{0}", i))
            Else
                sqltn.Append(String.Format(" + TonKho.TonKho.Tien_Nhap_{0}", i))
            End If

            If sqltx.Length = 0 Then
                sqltx.Append(String.Format("TonKho.TonKho.Tien_Xuat_{0}", i))
            Else
                sqltx.Append(String.Format(" + TonKho.TonKho.Tien_Xuat_{0}", i))
            End If
        Next
        GauGe.Value = 1
        st = ConvertToStrSafe(CThangDB2(ThangTruoc(tdau)))
        sql = String.Format("SELECT DISTINCT HeThongTK.MaSo AS MSTK, HeThongTK.SoHieu, HeThongTK.Ten, PhanLoaiVattu.MaSo, PhanLoaiVattu.SoHieu, PhanLoaiVattu.TenPhanLoai, Vattu.MaSo AS MSVT, Vattu.SoHieu AS SHVT, Vattu.TenVattu, Vattu.DonVi, Vattu.DonVi2, Vattu.Dvt2, Sum(TonKho.Tien_{0}) AS DkTien, Sum(TonKho.Luong_{0}) AS DkLuong, Sum({1}) AS TienNhap, Sum({2}) AS LuongNhap, Sum({3}) AS TienXuat, Sum({4}) AS LuongXuat, Sum(TonKho.Luong_{5}) AS CkLuong, Sum(TonKho.Tien_{5}) AS CkTien FROM HeThongTK RIGHT JOIN ((PhanLoaiVattu RIGHT JOIN Vattu ON PhanLoaiVattu.MaSo = Vattu.MaPhanLoai) RIGHT JOIN TonKho ON Vattu.MaSo = TonKho.MaVatTu) ON HeThongTK.MaSo = TonKho.MaTaiKhoan GROUP BY HeThongTK.MaSo, HeThongTK.SoHieu, HeThongTK.Ten, PhanLoaiVattu.MaSo, PhanLoaiVattu.SoHieu, PhanLoaiVattu.TenPhanLoai, Vattu.MaSo, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi2,Vattu.DonVi,Vattu.Dvt2 {6} Having (Sum(TonKho.Luong_{7})<>0 OR Sum(TonKho.Tien_{7})<>0 OR SUM({2})<>0 OR SUM({1})<>0 OR SUM({4})<>0 OR SUM({3})<>0){8}{9}{10} ORDER BY HeThongTK.SoHieu, PhanLoaiVattu.SoHieu, Vattu.SoHieu", _
                  st, _
                  sqltn, _
                  sqlln, _
                  sqltx, _
                  sqllx, _
                  CThangDB2(tcuoi), _
                  IIf(mkho > 0, ", TonKho.MaSoKho", String.Empty), _
                  CThangDB2(ThangTruoc(tdau)), _
                  IIf(mkho <> 0, String.Format(" AND TonKho.MaSoKho = {0}", mkho), String.Empty), _
                  IIf(mtk <> 0, String.Format(" AND HethongTK.MaSo = {0}", mtk), String.Empty), _
                  IIf(mloai <> 0, _
                      String.Format(" AND PhanLoaiVattu.SoHieu LIKE '{0}%'", MaSo2SoHieu(mloai, "PhanLoaiVattu")), _
                      String.Empty))
        i = 0
        rs = ExecSQLReturnDT(sql)
        For Each rsItem As DataRow In rs.Rows
            i += 1
            xlsheet.Cells(i + 9, 1) = ConvertToStrSafe(i)
            xlsheet.Cells(i + 9, 2) = ConvertToStrSafe(rsItem("TenVattu"))
            xlsheet.Cells(i + 9, 3) = ConvertToStrSafe(rsItem("shvt"))
            xlsheet.Cells(i + 9, 4) = ConvertToStrSafe(rsItem("DonVi"))
            If ConvertToDblSafe(rsItem("dkluong")) <> 0 Then xlsheet.Cells(i + 9, 5) = ConvertToStrSafe(rsItem("dkluong"))
            If ConvertToDblSafe(rsItem("dktien")) <> 0 Then xlsheet.Cells(i + 9, 6) = ConvertToStrSafe(rsItem("dktien"))
            If ConvertToDblSafe(rsItem("luongnhap")) <> 0 Then xlsheet.Cells(i + 9, 13) = ConvertToStrSafe(rsItem("luongnhap"))
            If ConvertToDblSafe(rsItem("tiennhap")) <> 0 Then xlsheet.Cells(i + 9, 14) = ConvertToStrSafe(rsItem("tiennhap"))
            If ConvertToDblSafe(rsItem("luongxuat")) <> 0 Then xlsheet.Cells(i + 9, 23) = ConvertToStrSafe(rsItem("luongxuat"))
            If ConvertToDblSafe(rsItem("tienxuat")) <> 0 Then xlsheet.Cells(i + 9, 24) = ConvertToStrSafe(rsItem("tienxuat"))
            If ConvertToDblSafe(rsItem("ckluong")) <> 0 Then xlsheet.Cells(i + 9, 25) = ConvertToStrSafe(rsItem("ckluong"))
            If ConvertToDblSafe(rsItem("CKTien")) <> 0 Then xlsheet.Cells(i + 9, 26) = ConvertToStrSafe(rsItem("CKTien"))
            NhapTheoNguon(tdau, _
                tcuoi, _
                ConvertToDblSafe(rsItem("MSVT")), _
                ConvertToDblSafe(rsItem("MSTK")), _
                "331", _
                lx, _
                tx, _
                mkho)
            NhapTheoNguon(tdau, _
                tcuoi, _
                ConvertToDblSafe(rsItem("MSVT")), _
                ConvertToDblSafe(rsItem("MSTK")), _
                "11", _
                l1, _
                T, _
                mkho)
            lx += l1
            tx += T
            If lx <> 0 Then xlsheet.Cells(i + 9, 7) = lx
            If tx <> 0 Then xlsheet.Cells(i + 9, 8) = tx
            NhapTheoNguon(tdau, _
                tcuoi, _
                ConvertToDblSafe(rsItem("MSVT")), _
                ConvertToDblSafe(rsItem("MSTK")), _
                "136", _
                lx, _
                tx, _
                mkho)
            NhapTheoNguon(tdau, _
                tcuoi, _
                ConvertToDblSafe(rsItem("MSVT")), _
                ConvertToDblSafe(rsItem("MSTK")), _
                "336", _
                l1, _
                T, _
                mkho)
            lx += l1
            tx += T
            NhapTheoNguon(tdau, _
                tcuoi, _
                ConvertToDblSafe(rsItem("MSVT")), _
                ConvertToDblSafe(rsItem("MSTK")), _
                "138", _
                l1, _
                T, _
                mkho)
            lx += l1
            tx += T
            NhapTheoNguon(tdau, _
                tcuoi, _
                ConvertToDblSafe(rsItem("MSVT")), _
                ConvertToDblSafe(rsItem("MSTK")), _
                "338", _
                l1, _
                T, _
                mkho)
            lx += l1
            tx += T
            NhapTheoNguon(tdau, _
                tcuoi, _
                ConvertToDblSafe(rsItem("MSVT")), _
                ConvertToDblSafe(rsItem("MSTK")), _
                "154", _
                l1, _
                T, _
                mkho)
            lx += l1
            tx += T
            NhapTheoNguon(tdau, _
                tcuoi, _
                ConvertToDblSafe(rsItem("MSVT")), _
                ConvertToDblSafe(rsItem("MSTK")), _
                "152", _
                l1, _
                T, _
                mkho)
            lx += l1
            tx += T
            NhapTheoNguon(tdau, _
                tcuoi, _
                ConvertToDblSafe(rsItem("MSVT")), _
                ConvertToDblSafe(rsItem("MSTK")), _
                "155", _
                l1, _
                T, _
                mkho)
            lx += l1
            tx += T
            If lx <> 0 Then xlsheet.Cells(i + 9, 9) = lx
            If tx <> 0 Then xlsheet.Cells(i + 9, 10) = tx
            XuatTheoNguon(tdau, _
                tcuoi, _
                ConvertToDblSafe(rsItem("MSVT")), _
                ConvertToDblSafe(rsItem("MSTK")), _
                "621", _
                lx, _
                tx, _
                mkho)
            XuatTheoNguon(tdau, _
                tcuoi, _
                ConvertToDblSafe(rsItem("MSVT")), _
                ConvertToDblSafe(rsItem("MSTK")), _
                "627", _
                l1, _
                T, _
                mkho)
            lx += l1
            tx += T
            If lx <> 0 Then xlsheet.Cells(i + 9, 15) = lx
            If tx <> 0 Then xlsheet.Cells(i + 9, 16) = tx
            XuatTheoNguon(tdau, _
                tcuoi, _
                ConvertToDblSafe(rsItem("MSVT")), _
                ConvertToDblSafe(rsItem("MSTK")), _
                "632", _
                lx, _
                tx, _
                mkho)
            If lx <> 0 Then xlsheet.Cells(i + 9, 17) = lx
            If tx <> 0 Then xlsheet.Cells(i + 9, 18) = tx
            XuatTheoNguon(tdau, _
                tcuoi, _
                ConvertToDblSafe(rsItem("MSVT")), _
                ConvertToDblSafe(rsItem("MSTK")), _
                "154", _
                lx, _
                tx, _
                mkho)
            If lx <> 0 Then xlsheet.Cells(i + 9, 19) = lx
            If tx <> 0 Then xlsheet.Cells(i + 9, 20) = tx
            xlsheet.Range(String.Format("K{0}", (i + 9))).Formula = String.Format("=M{0}-G{0}-I{0}" = (i + 9)) 'Excel Fomular
            xlsheet.Range(String.Format("L{0}", (i + 9))).Formula = String.Format("=N{0}-H{0}-J{0}" = (i + 9)) 'Excel Fomular
            xlsheet.Range(String.Format("U{0}", (i + 9))).Formula = String.Format("=W{0}-O{0}-Q{0}-S{0}" = (i + 9)) 'Excel Fomular
            xlsheet.Range(String.Format("V{0}", (i + 9))).Formula = String.Format("=X{0}-P{0}-R{0}-T{0}" = (i + 9)) 'Excel Fomular
        Next
        GauGe.Value = 2
        xlsheet.Cells(i + 10, 2) = "Tổng cộng"
        xlsheet.Range(String.Format("F{0}", (i + 10))).Formula = String.Format("=SUM(F10:F{0})" = (i + 9)) 'Excel Fomular
        xlsheet.Range(String.Format("G{0}", (i + 10))).Formula = String.Format("=SUM(G10:G{0})" = (i + 9)) 'Excel Fomular
        xlsheet.Range(String.Format("H{0}", (i + 10))).Formula = String.Format("=SUM(H10:H{0})" = (i + 9)) 'Excel Fomular
        xlsheet.Range(String.Format("I{0}", (i + 10))).Formula = String.Format("=SUM(I10:I{0})" = (i + 9)) 'Excel Fomular
        xlsheet.Range(String.Format("J{0}", (i + 10))).Formula = String.Format("=SUM(J10:J{0})" = (i + 9)) 'Excel Fomular
        xlsheet.Range(String.Format("K{0}", (i + 10))).Formula = String.Format("=SUM(K10:K{0})" = (i + 9)) 'Excel Fomular
        xlsheet.Range(String.Format("L{0}", (i + 10))).Formula = String.Format("=SUM(L10:L{0})" = (i + 9)) 'Excel Fomular
        xlsheet.Range(String.Format("M{0}", (i + 10))).Formula = String.Format("=SUM(M10:M{0})" = (i + 9)) 'Excel Fomular
        xlsheet.Range(String.Format("N{0}", (i + 10))).Formula = String.Format("=SUM(N10:N{0})" = (i + 9)) 'Excel Fomular
        xlsheet.Range(String.Format("O{0}", (i + 10))).Formula = String.Format("=SUM(O10:O{0})" = (i + 9)) 'Excel Fomular
        xlsheet.Range(String.Format("P{0}", (i + 10))).Formula = String.Format("=SUM(P10:P{0})" = (i + 9)) 'Excel Fomular
        xlsheet.Range(String.Format("Q{0}", (i + 10))).Formula = String.Format("=SUM(Q10:Q{0})" = (i + 9)) 'Excel Fomular
        xlsheet.Range(String.Format("R{0}", (i + 10))).Formula = String.Format("=SUM(R10:R{0})" = (i + 9)) 'Excel Fomular
        xlsheet.Range(String.Format("S{0}", (i + 10))).Formula = String.Format("=SUM(S10:S{0})" = (i + 9)) 'Excel Fomular
        xlsheet.Range(String.Format("T{0}", (i + 10))).Formula = String.Format("=SUM(T10:T{0})" = (i + 9)) 'Excel Fomular
        xlsheet.Range(String.Format("U{0}", (i + 10))).Formula = String.Format("=SUM(U10:U{0})" = (i + 9)) 'Excel Fomular
        xlsheet.Range(String.Format("V{0}", (i + 10))).Formula = String.Format("=SUM(V10:V{0})" = (i + 9)) 'Excel Fomular
        xlsheet.Range(String.Format("W{0}", (i + 10))).Formula = String.Format("=SUM(W10:W{0})" = (i + 9)) 'Excel Fomular
        xlsheet.Range(String.Format("X{0}", (i + 10))).Formula = String.Format("=SUM(X10:X{0})" = (i + 9)) 'Excel Fomular
        xlsheet.Range(String.Format("Y{0}", (i + 10))).Formula = String.Format("=SUM(Y10:Y{0})" = (i + 9)) 'Excel Fomular
        xlsheet.Range(String.Format("Z{0}", (i + 10))).Formula = String.Format("=SUM(Z10:Z{0})" = (i + 9)) 'Excel Fomular
        With xlsheet.Range("A7", String.Format("Z{0}", (i + 10)))
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders.Weight = Excel.XlBorderWeight.xlThin
            Dim tempRefParam As Object = .Borders.Color
            tempRefParam = Color.FromArgb(0, 0, 0)
            Dim tempRefParam2 As Object = .RowHeight
            tempRefParam2 = 18
            .Font.Size = 6
            Dim tempRefParam3 As Object = .VerticalAlignment
            tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
        End With
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        xlsheet = Nothing
        xlapp = Nothing
        GauGe.Value = 3
        CallExcel("\temp\LUYKE.XLS")
KetThuc:
    End Sub
    Sub XuatExcelLuyKe(ByRef GauGe As ProgressBar, ByRef mkho As Integer, ByRef mloai As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer, Optional ByRef ten As String = "")
        Dim sql, st As String
        Dim sqltx2 As New StringBuilder
        Dim sqltn2 As New StringBuilder
        Dim sqltx As New StringBuilder
        Dim sqltn As New StringBuilder
        Dim sqllx As New StringBuilder
        Dim sqlln As New StringBuilder

        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            st = ConvertToStrSafe(i)
            sqlln.Append(String.Format(" + TonKho.Luong_Nhap_{0}", st))
            sqllx.Append(String.Format(" + TonKho.Luong_Xuat_{0}", st))
            sqltn.Append(String.Format(" + TonKho.Tien_Nhap_{0}", st))
            sqltx.Append(String.Format(" + TonKho.Tien_Xuat_{0}", st))
            sqltn2.Append(String.Format(" + TonKho.USDTien_Nhap_{0}", st))
            sqltx2.Append(String.Format(" + TonKho.USDTien_Xuat_{0}", st))
        Next
        st = ConvertToStrSafe(CThangDB2(tcuoi))
        XDTyLeQD(0)
        If mkho > 0 Then
            sql = String.Format("SELECT DISTINCT Vattu.TenVattu, Vattu.DonVi, Vattu.SoHieu, Sum(TonKho.Luong_{0}) AS DkLuong, Sum(TonKho.Tien_{0}) AS DkTien, Sum({1}) AS LuongNhap, Sum({2}) AS TienNhap, Sum({3}) AS LuongXuat, Sum({4}) AS TienXuat, Sum(TonKho.Luong_{5}) AS CkLuong{6}, HeThongTK.SoHieu AS SHTK, HeThongTK.Ten  AS TenTK, Sum(TonKho.Tien_{5}) AS CkTien FROM HeThongTK RIGHT JOIN ((PhanLoaiVattu RIGHT JOIN Vattu ON PhanLoaiVattu.MaSo = Vattu.MaPhanLoai) RIGHT JOIN TonKho ON Vattu.MaSo = TonKho.MaVatTu) ON HeThongTK.MaSo = TonKho.MaTaiKhoan GROUP BY Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, HethongTK.SoHieu{7}{8} Having (Sum(TonKho.Luong_{5})<>0 OR Sum(TonKho.Tien_{5})<>0 OR SUM({1})<>0 OR SUM({2})<>0 OR SUM({3})<>0 OR SUM({4})<>0{9}{10}{11}{12} ORDER BY Vattu.SoHieu", _
                               CThangDB2(ThangTruoc(tdau)), _
                               sqlln, _
                               sqltn, _
                               sqllx, _
                               sqltx, _
                               st, _
                               (IIf(pGiaUSD > 0, String.Format(", Sum(TonKho.USDTien_{0}) AS DkUSD, Sum({1}) AS TienNhapUSD, Sum({2}) AS TienXuatUSD, Sum(TonKho.USDTien_{3}) AS CkUSD", CThangDB2(ThangTruoc(tdau)), sqltn2, sqltx2, st), String.Empty)), _
                               (IIf(mkho > 0, ", TonKho.MaSoKho", String.Empty)), _
                               (IIf(mloai > 0, ", PhanLoaiVattu.SoHieu", String.Empty)), _
                               (IIf(pGiaUSD > 0, String.Format(" OR Sum(TonKho.USDTien_{0})<>0 OR SUM({1})<>0 OR SUM({2})<>0)", st, sqltn2, sqltx2), ")")), _
                               (IIf(mkho <> 0, String.Format(" AND TonKho.MaSoKho = {0}", mkho), String.Empty)), _
                               (IIf(mloai <> 0, String.Format(" AND PhanLoaiVattu.SoHieu LIKE '{0}%'", MaSo2SoHieu(mloai, "PhanLoaiVattu")), String.Empty)), _
                               (IIf(ten <> "", String.Format(" and vattu.tenvattu like '%{0}%'", ten.ToUpper()), String.Empty)))
        Else
            MessageBox.Show(Ngonngu("Công ty này không có kho hàng", "Missing storage"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        OpenBook(String.Format("{0}RePorts\Luyke.xls", pCurDir))
        Select Case Information.Err().Number
            Case Is < 0
                Conversion.ErrorToString(5)
            Case 1
                GoTo Loi
        End Select
        Process.Start(String.Format("cmd /c ""del {0}Luyke.xls", pCurDir))
        Dim curSheet As Excel.Worksheet = Excel_Global.Worksheets(1)
        curSheet.Cells(1, 1) = pTenCty
        curSheet.Cells(2, 1) = String.Format("MST: {0}", frmMain._LbCty_8.Text)
        curSheet.Cells(3, 1) = String.Format("Kho: {0}", CboKho(0).Text)
        sql = "SELECT tenvattu,donvi,sohieu,dkluong,dktien,luongnhap,tiennhap,luongxuat,tienxuat,dkluong+luongnhap-luongxuat as luongton,CASE WHEN (dkluong+luongnhap-luongxuat>0 THEN (dktien+tiennhap-tienxuat)/(dkluong+luongnhap-luongxuat) ELSE 0 END,dktien+tiennhap-tienxuat as tienton,shtk,tentk FROM (" & sql & ") as qluyke group by shtk,tentk,tenvattu,donvi,sohieu,dkluong,dktien,luongnhap,tiennhap,luongxuat,tienxuat"
        PrintSQLLuyKe(GauGe, sql, curSheet, 7, 2, tdau, tcuoi)
        curSheet.SaveAs(String.Format("{0}\temp\Luyke.xls", pCurDir))
        CloseBook(String.Format("{0}\temp\Luyke.xls", pCurDir))
Loi:
        CloseBook(String.Format("{0}RePorts\Luyke.xls", pCurDir))
        CallExcel("\temp\Luyke.xls")
        FileSystem.FileClose()
    End Sub
    Function PrintSQLLuyKe(ByRef GauGe As ProgressBar, ByRef sql As String, ByVal curSheet As Excel.Worksheet, ByVal RowIdx As Integer, ByRef StartCol As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer) As Integer
        Dim dong As Integer
        Dim Dieukien As String = String.Empty
        Dim tiennhap, dktien, tienxuat, ttn, ttdk, tldk, tln, ttt, ttx, tlx, tlt As Double
        Dim ngaybc As Date
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        GauGe.Maximum = rs.Rows.Count
        GauGe.Value = 0
        If tdau = tcuoi Then
            curSheet.Cells(3, 3).Value = String.Format("Tháng {0}/{1}", tcuoi, ConvertToStrSafe(pNamTC))
        Else
            curSheet.Cells(3, 3).Value = String.Format("Từ tháng {0}/{1} đến tháng {2}/{1}", tdau, ConvertToStrSafe(pNamTC), ConvertToStrSafe(tcuoi))
        End If
        If rs.Rows.Count > 0 Then
            If rs.Rows.Count > 1 Then
                curSheet.Range(String.Format("{0}:{1}", ConvertToStrSafe(RowIdx + 1), ConvertToStrSafe(RowIdx + rs.Rows.Count - 2 + 1))).EntireRow.Insert()
            End If
            For i As Integer = 0 To rs.Rows.Count - 1
                Dim rsItem As DataRow = rs.Rows(i)
                GauGe.Value += 1
                If Dieukien <> ConvertToDblSafe(rsItem("shtk")) Then
                    If dong > 0 Then
                        If i > 0 Then
                            rsItem = rs.Rows(i - 1)
                        End If
                        curSheet.Cells(dong, 2).Value = ConvertToStrSafe(rsItem("tentk"))
                        curSheet.Cells(dong, 4).Value = ConvertToStrSafe(rsItem("shtk"))
                        curSheet.Cells(dong, 6).Value = dktien
                        curSheet.Cells(dong, 8).Value = tiennhap
                        curSheet.Cells(dong, 10).Value = tienxuat
                        curSheet.Cells(dong, 13).Value = dktien + tiennhap - tienxuat
                        dktien = 0
                        tiennhap = 0
                        tienxuat = 0
                        rsItem = rs.Rows(i)
                    End If
                    Dieukien = ConvertToBoolSafe(rsItem("shtk"))
                    curSheet.Range(String.Format("{0}:{0}", ConvertToStrSafe(RowIdx + 1))).EntireRow.Insert()
                    dong = RowIdx
                    RowIdx += 1
                End If
                curSheet.Cells(RowIdx, 1).Value = ConvertToStrSafe(ConvertToDblSafe(IIf(curSheet.Cells(RowIdx - 1, 1).Value > 0, _
                                                                                        curSheet.Cells(RowIdx - 1, 1).Value, _
                                                                                        curSheet.Cells(RowIdx - 2, 1).Value)) + 1)
                dktien += ConvertToDblSafe(rsItem("dktien"))
                tiennhap += ConvertToDblSafe(rsItem("tiennhap"))
                tienxuat += ConvertToDblSafe(rsItem("tienxuat"))
                ttdk += ConvertToDblSafe(rsItem("dktien"))
                tldk += ConvertToDblSafe(rsItem("dkluong"))
                ttn += ConvertToDblSafe(rsItem("tiennhap"))
                tln += ConvertToDblSafe(rsItem("luongnhap"))
                ttx += ConvertToDblSafe(rsItem("tienxuat"))
                tlx += ConvertToDblSafe(rsItem("luongxuat"))
                ttt += ConvertToDblSafe(rsItem("tienton"))
                tlt += ConvertToDblSafe(rsItem("luongton"))
                For FieldCnt As Integer = 0 To rs.Rows.Count - 3
                    curSheet.Cells(RowIdx = FieldCnt + StartCol).Value = rsItem(FieldCnt)
                Next FieldCnt
                RowIdx += 1
            Next
            If dong > 0 Then
                Dim rsItem As DataRow
                If rs.Rows.Count > 1 Then
                    rsItem = rs.Rows(rs.Rows.Count - 2)
                Else
                    rsItem = rs.Rows(0)
                End If
                curSheet.Cells(dong = 2).Value = ConvertToStrSafe(rsItem("tentk"))
                curSheet.Cells(dong = 4).Value = ConvertToStrSafe(rsItem("shtk"))
                curSheet.Cells(dong = 6).Value = dktien
                curSheet.Cells(dong = 8).Value = tiennhap
                curSheet.Cells(dong = 10).Value = tienxuat
                curSheet.Cells(dong = 13).Value = dktien + tiennhap - tienxuat
                curSheet.Cells(RowIdx = 5).Value = tldk
                curSheet.Cells(RowIdx = 6).Value = ttdk
                curSheet.Cells(RowIdx = 7).Value = tln
                curSheet.Cells(RowIdx = 8).Value = ttn
                curSheet.Cells(RowIdx = 9).Value = tlx
                curSheet.Cells(RowIdx = 10).Value = ttx
                curSheet.Cells(RowIdx = 11).Value = tlt
                curSheet.Cells(RowIdx = 13).Value = ttt
                ngaybc = NgayCuoiThang(pNamTC, tcuoi)
                curSheet.Cells(RowIdx + 2 = 7).Value = String.Format("Ngày {0} tháng {1} năm {2}", _
                                                           ngaybc.Day, _
                                                           tcuoi, _
                                                           pNamTC)
            End If
        End If
        Return RowIdx
    End Function
    Sub InNguonNhapXuat(ByRef GauGe As ProgressBar, ByRef mkho As Integer, ByRef mtk As Integer, ByRef mloai As Integer, ByRef MN As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef loai As Integer, ByRef dktg As Integer, ByRef ndau As Date, ByRef ncuoi As Date)
        GauGe.Maximum = 2
        Dim sql As String = String.Format("SELECT DISTINCT Chungtu.MaLoai,MaKho,MaNguon,NguonNhapXuat.MaSo, Vattu.MaSo, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, NguonNhapXuat.SoHieu, NguonNhapXuat.DienGiai, ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.DienGiai, ChungTu.SoPS2No, ChungTu.SoPS2Co, ChungTu.SoPS FROM PhanLoaiVattu RIGHT JOIN (NguonNhapXuat RIGHT JOIN (Vattu INNER JOIN ChungTu ON Vattu.MaSo = ChungTu.MaVattu) ON NguonNhapXuat.MaSo = ChungTu.MaNguon) ON PhanLoaiVattu.MaSo = Vattu.MaPhanLoai WHERE (({0}) AND {1}{2}{3}{4}{5})", (IIf(loai = -1, "ChungTu.MaLoai =1 OR ChungTu.MaLoai =4", "ChungTu.MaLoai =2 OR ChungTu.MaLoai =4")), (IIf(loai = -1, "MaTKNo>0", "MaTKCo>0")), (IIf(mkho <> 0, (IIf(loai = -1, " AND ((Chungtu.MaKho = " & mkho & " AND ChungTu.MaLoai=1) OR (MaNguon=" & ConvertToStrSafe(mkho) & " AND Chungtu.MaLoai=4)", " AND (Chungtu.MaKho = " & mkho)) & ")", String.Empty)), (IIf(mtk <> 0, " AND (" & (IIf(loai = -1, "MaTKNo", "MaTKCo")) & " = " & ConvertToStrSafe(mtk) & ")", String.Empty)), (IIf(MN > 0, " AND (MaNguon=" & MN & ")", String.Empty)), (IIf(mloai > 0, " AND (PhanLoaiVattu.SoHieu LIKE '" & MaSo2SoHieu(mloai, "PhanLoaiVattu") & "%')", String.Empty)))
        If dktg = 0 Then
            sql = String.Format("{0} AND {1}", sql, WThang("ThangCT", tdau, tcuoi))
            rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        Else
            sql = String.Format("{0} AND {1}", sql, WNgay("NgayGS", ndau, ncuoi))
            rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianN(ndau, ncuoi, nn)))
        End If
        sql = String.Format("{0} ORDER BY NguonNhapXuat.SoHieu, Vattu.SoHieu", sql)
        rptFrom.InitForm("NguonNX.RPT", sql, "QNguonNhapXuat")

        GauGe.Value = 1
        rptFrom.SetFormulas("TenKho", String.Format(Ngonngu("'Kho: {0}'", "'Stock: {0}'"), tenkho(mkho)))
        rptFrom.SetFormulas("MaLoai", loai)

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
    End Sub
    Sub InTHXuatKho(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef mkho As Integer, ByRef mtk As Integer, ByRef mloai As Integer, ByRef tkdu As String)
        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        Dim sql As String = String.Format("SELECT DISTINCT Vattu.SoHieu,TenVattu,DonVi,Sum(SoPS2Co) AS Luong,Sum(SoPS) AS Tien FROM ({0}) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo WHERE (ChungTu.MaLoai=2 OR (ChungTu.MaLoai=4 AND MaTKNo<>MaTKCo)) AND {1} AND HethongTK.SoHieu LIKE '{2}%'{3}{4}{5} GROUP BY Vattu.SoHieu,TenVattu,DonVi", ChungTu2TKNC(-1), wsql, tkdu, (IIf(mkho > 0, " AND MaKho=" & mkho, String.Empty)), (IIf(mtk <> 0, " AND MaTKCo = " & mtk, String.Empty)), (IIf(mloai <> 0, " AND MaPhanLoai = " & mloai, String.Empty)))
        sql = String.Format("{0} UNION SELECT DISTINCT Vattu.SoHieu,TenVattu,DonVi,-Sum(SoPS2No) AS Luong,-Sum(SoPS) AS Tien FROM ({1}) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo WHERE (ChungTu.MaLoai=1 OR (ChungTu.MaLoai=4 AND MaTKNo<>MaTKCo)) AND {2} AND HethongTK.SoHieu LIKE '{3}%'{4}{5}{6} GROUP BY Vattu.SoHieu,TenVattu,DonVi", sql, ChungTu2TKNC(1), wsql, tkdu, (IIf(mkho > 0, " AND ((MaKho=" & mkho & " AND MaLoai=1) OR (MaNguon=" & ConvertToStrSafe(mkho) & " AND MaLoai=4))", String.Empty)), (IIf(mtk <> 0, " AND MaTKNo = " & mtk, String.Empty)), (IIf(mloai <> 0, " AND MaPhanLoai = " & mloai, String.Empty)))

        rptFrom.InitForm("LUYKE2.RPT", sql, "QLuyKe")

        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi, nn)))))
        rptFrom.SetFormulas("TKDU", String.Format("'{0}{1} - {2}'", ("Tài khoản đối ứng: "), tkdu, LbTenTk(11).Text))

        RptSetDate(ncuoi)
    End Sub
    Sub InTHXuatKhoDT(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef mkho As Integer, ByRef mtk As Integer, ByRef mloai As Integer, ByRef tkdu As Integer, ByRef xT As Integer)
        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        Dim sql As String = String.Format("SELECT DISTINCT Vattu.SoHieu,TenVattu,DonVi,Sum(SoPS2Co) AS Luong,Sum(SoPS) AS Tien FROM ChungTu INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo WHERE (ChungTu.MaLoai=2 OR (ChungTu.MaLoai=4 AND MaTKNo<>MaTKCo)) AND {0} AND MaTP ={1}{2}{3}{4}{5} GROUP BY Vattu.SoHieu,TenVattu,DonVi", wsql, ConvertToStrSafe(tkdu), (IIf(mkho > 0, " AND MaKho=" & mkho, String.Empty)), (IIf(mtk <> 0, " AND MaTKCo = " & mtk, String.Empty)), (IIf(mloai <> 0, " AND MaPhanLoai = " & mloai, String.Empty)), (IIf(xT > 0, " AND CT_ID>900000000", String.Empty)))
        sql = String.Format("{0} UNION SELECT DISTINCT Vattu.SoHieu,TenVattu,DonVi,-Sum(SoPS2No) AS Luong,-Sum(SoPS) AS Tien FROM ChungTu INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo WHERE (ChungTu.MaLoai=1 OR (ChungTu.MaLoai=4 AND MaTKNo<>MaTKCo)) AND {1} AND MaTP ={2}{3}{4}{5}{6} GROUP BY Vattu.SoHieu,TenVattu,DonVi", sql, wsql, ConvertToStrSafe(tkdu), (IIf(mkho > 0, " AND ((MaKho=" & mkho & " AND MaLoai=1) OR (MaNguon=" & ConvertToStrSafe(mkho) & " AND MaLoai=4))", String.Empty)), (IIf(mtk <> 0, " AND MaTKNo = " & mtk, String.Empty)), (IIf(mloai <> 0, " AND MaPhanLoai = " & mloai, String.Empty)), (IIf(xT > 0, " AND CT_ID>900000000", String.Empty)))

        rptFrom.InitForm("LUYKE2.RPT", sql, "QLuyKe")

        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi, nn)))))
        rptFrom.SetFormulas("TKDU", String.Format("'Xuất cho đối tượng: {0} - {1}'", txtCT(1).Text, LbCT(1).Text))
        If xT > 0 Then rptFrom.SetFormulas("TenBaoCao", "IF PageNumber()=1 THEN 'Bảng kê nhập xuất thẳng'")

        RptSetDate(ncuoi)
    End Sub
    Sub InLuyKeHM(ByRef GauGe As ProgressBar, ByRef mkho As Integer, ByRef mtk As Integer, ByRef mloai As Integer, ByRef ncuoi As Date, ByRef loaihm As Integer)
        Dim dkl, dkt, dkt2 As Double
        ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
        GauGe.Maximum = 3
        ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,MaCha,BC_ID,MK,Kq7,Kq8) SELECT TonKho.MaSo,ConvertToStrSafe(TonKho.MaSo),MaTaiKhoan,MaVattu,MaSoKho,TonMin,TonMax FROM TonKho INNER JOIN Vattu ON TonKho.MaVattu=Vattu.MaSo WHERE {0}{1}{2}{3}", _
                            (IIf(loaihm < 0, " TonMin>0", " TonMax>0")), _
                            (IIf(mkho > 0, String.Format(" AND MaSoKho={0}", mkho), String.Empty)), _
                            (IIf(mtk > 0, String.Format(" AND MaTaiKhoan={0}", mtk), String.Empty)), _
                            (IIf(mloai > 0, String.Format(" AND MaPhanLoai={0}", mloai), String.Empty))))
        Dim rs As DataTable = ExecSQLReturnDT("SELECT * FROM BaoCaoCP2")
        For Each rsItem As DataRow In rs.Rows
            dkl = SoTonKhoN(ncuoi, _
                      ConvertToDblSafe(rsItem("mk")), _
                      ConvertToDblSafe(rsItem("macha")), _
                      ConvertToDblSafe(rsItem("BC_ID")), _
                      dkt, _
                      dkt2)
            If loaihm < 0 And dkl < ConvertToDblSafe(rsItem("Kq7")) Then
                ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET CoCon=1 WHERE MaSo={0}", rsItem("MaSo")))
            End If
            If loaihm > 0 And dkl > ConvertToDblSafe(rsItem("Kq8")) Then
                ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET CoCon=1 WHERE MaSo={0}", rsItem("MaSo")))
            End If
            ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET Kq1={0} WHERE MaSo={1}", _
                                CStr(dkl), _
                                rsItem("MaSo")))
        Next
        ExecSQLNonQuery("DELETE FROM BaoCaoCP2 WHERE CoCon=0")
        GauGe.Value = 1
        Dim sql As String = String.Format("SELECT DISTINCT PhanLoaiVattu.SoHieu, PhanLoaiVattu.TenPhanLoai, Vattu.SoHieu, Vattu.TenVattu,Vattu.TonMin,Vattu.TonMax, Kq1, Kq7,Kq8 FROM (HeThongTK RIGHT JOIN ((PhanLoaiVattu RIGHT JOIN Vattu ON PhanLoaiVattu.MaSo = Vattu.MaPhanLoai) RIGHT JOIN TonKho ON Vattu.MaSo = TonKho.MaVatTu) ON HeThongTK.MaSo = TonKho.MaTaiKhoan) INNER JOIN BaoCaoCP2 ON TonKho.MaSoKho=BaoCaoCP2.MK AND TonKho.MaTaiKhoan=BaoCaoCP2.MaCha AND TonKho.MaVattu=BaoCaoCP2.BC_ID WHERE (TRUE){0}{1}{2} ORDER BY HeThongTK.SoHieu, PhanLoaiVattu.SoHieu, Vattu.SoHieu", _
                                (IIf(mkho <> 0, String.Format(" And TonKho.MaSoKho = {0}", mkho), String.Empty)), _
                                (IIf(mtk <> 0, String.Format(" And HethongTK.MaSo = {0}", mtk), String.Empty)), _
                                (IIf(mloai <> 0, String.Format(" AND PhanLoaiVattu.SoHieu LIKE '{0}%'", MaSo2SoHieu(mloai, "PhanLoaiVattu")), String.Empty)))

        rptFrom.InitForm("LUYKEL1.RPT", sql, "QLuyKe")

        GauGe.Value = 2
        rptFrom.SetFormulas("TenKho", String.Format(Ngonngu("'Kho: {0}'", "'Stock: {0}'"), tenkho(mkho)))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianN(ncuoi, ncuoi, nn)))

        RptSetDate(ncuoi)
    End Sub
End Class
