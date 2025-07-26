Imports System
Imports System.IO
Imports System.Data
Imports System.Text
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter
Imports Excel = Microsoft.Office.Interop.Excel


Partial Friend Class FrmSochiphi
    Dim baocao As Integer ' Chỉ số báo cáo được chọn
    Dim StopPrint As Boolean ' = True nếu ngừng in các danh sách báo cáo
    Dim Pdelay As Integer
    Dim Ngay(2) As Date
    Dim xlapp As New Excel.Application
    Dim xlsheet As Excel.Worksheet
    Dim KTT, NLB, GD As String
    Dim nn As Integer
    Private isInitializingComponent As Boolean
    ''' <summary>
    ''' Chọn số hiệu tài khoản
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdtk_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _cmdtk_0.Click, _cmdtk_1.Click, _cmdtk_2.Click, _cmdtk_3.Click, _cmdtk_5.Click, _cmdtk_8.Click, _cmdtk_6.Click
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
    Public Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim taikhoan As New ClsTaikhoan
        Dim doiung As New ClsTaikhoan
        Dim rs_tk As DataTable
        Dim tdau, tcuoi As Integer
        Dim mtk, MN As Integer
        Dim ten As String = String.Empty
        Select Case Index
            Case 0, 1
                If Not OptBC(baocao).TabStop Then Exit Sub
                Me.Cursor = Cursors.WaitCursor
                GauGe.Value = 0
                If CboThang(1).Items.Count > 0 Then
                    If CboThang(0).Enabled And CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
                End If

                If CboThang(0).Items.Count > 0 Then
                    tdau = CboThang(0).SelectedValue
                End If
                If CboThang(1).Items.Count > 0 Then
                    tcuoi = CboThang(1).SelectedValue
                End If

                Select Case baocao
                    Case 76
                        InCdt2(tdau, tcuoi, CboThang(2).SelectedIndex + 1, ChkDu(6).CheckState)
                    Case 75
                        If ConvertToDblSafe((txtShTk(8).Tag)) = 0 Then
                            MessageBox.Show(Ngonngu("Hãy nhập số hiệu chi tiết !", "Enter detail account !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtShTk(8).Focus()
                            GoTo LoiBC
                        End If
                        T(ConvertToDblSafe(txtShTk(8).Tag), IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(1), Ngay(2), CboThang(2).SelectedIndex + 1)
                    Case 69
                        If ConvertToDblSafe((txtShTk(8).Tag)) = 0 Then
                            If ConvertToDblSafe((txtShTk(2).Tag)) = 0 Then
                                txtShTk(8).Focus()
                                GoTo LoiBC
                            Else
                                taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(2).Tag))
                                If CboNT.SelectedIndex >= 0 Then
                                    MN = CboNT.SelectedIndex
                                    If MN = 0 Then MN = -1
                                Else
                                    MN = 0
                                End If
                            End If
                        Else
                            taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(8).Tag))
                            MN = 0
                        End If
                        BangKeTichSo(taikhoan, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(1), Ngay(2), ConvertToDblSafe(txtLS(0).Text), ConvertToDblSafe(txtLS(1).Text), MN)
                    Case 0
                        If ConvertToDblSafe((txtShTk(0).Tag)) = 0 Then
                            ErrMsg(er_SHTaiKhoan)
                            txtShTk(0).Focus()
                            GoTo LoiBC
                        End If
                        If ChkDu(0).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(5).Tag)) = 0 Then
                            txtShTk(5).Focus()
                            GoTo LoiBC
                        End If
                        If ChkDu(0).CheckState = CheckState.Checked Then
                            doiung.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(5).Tag))
                        Else
                            doiung.InitTaikhoanMaSo(0)
                        End If
                        taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(0).Tag))
                        If ChkDu(16).CheckState Then
                            FrmSochitiet.Hienthi(Me)
                            GoTo LoiBC
                        Else
                            If (taikhoan.MaTC = taikhoan.maso Or taikhoan.MaTC = 0) And Not ((taikhoan.sohieu Like "112*") And OptTG(1).Checked) Then
                                If Not InSocaiTk(taikhoan, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(1), Ngay(2), True, doiung.sohieu, 0, 0, nn) Then GoTo LoiBC
                            Else
                                If Not InSoChitiet(taikhoan, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(1), Ngay(2), True, doiung.sohieu, 0, 0, nn) Then GoTo LoiBC
                            End If
                        End If
                    Case 1
                        If Index = 0 Or OptTG(1).Checked Then GoTo KhongIn
                        If ConvertToDblSafe((txtShTk(1).Tag)) = 0 Then
                            ErrMsg(er_SHTaiKhoan)
                            txtShTk(1).Focus()
                            GoTo LoiBC
                        End If
                        taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(1).Tag))
                        If taikhoan.tkcon = 0 Or taikhoan.MaTC <> taikhoan.maso Then
                            MessageBox.Show(Ngonngu("Hãy chọn tài khoản Bộ Tài chính ban hành được mở chi tiết !", "Choose the financial - account is opened details !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            GoTo LoiBC
                        End If
                        rs_tk = ExecSQLReturnDT(String.Format("SELECT MaSo, SoHieu, Ten FROM HethongTK WHERE SoHieu LIKE '{0}%' AND TkCon=0 AND MaNT<=0 ORDER BY SoHieu DESC", taikhoan.sohieu))
                        StopPrint = False
                        rptFrom.ReportDestination = 0
                        GauGe.Maximum = 10
                        For Each rsItem As DataRow In rs_tk.Rows
                            If StopPrint Then
                                Exit For
                            End If
                            If rsItem("MaSo") IsNot Nothing Then
                                taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(rsItem("MaSo")))
                            End If

                            If InSoChitiet(taikhoan, tdau, tcuoi, Ngay(0), Ngay(1), False, "", 0, 0, nn) Then
                                HienThongBao(String.Format("{0} - {1}", _
                                                 ConvertToStrSafe(rsItem("SoHieu")), _
                                                 ConvertToStrSafe(rsItem("ten"))), 1)
                                AppIdle(Pdelay * 100)
                            End If
                            If GauGe.Value < GauGe.Maximum Then GauGe.Value += 1
                        Next
                        GoTo LoiBC
                    Case 2
                        If Index = 0 Then GoTo KhongIn
                        rs_tk = ExecSQLReturnDT(String.Format("SELECT DISTINCT MaSo, SoHieu, Ten FROM HethongTK WHERE Loai > 0 AND MaTC > 0 AND MaTC <> MaSo AND TkCon=0 AND MaNT<=0{0}{1} ORDER BY SoHieu", _
                                                    (IIf(Strings.Len(txtShCT(0).Text) > 0, String.Format(" AND SoHieu >=N'{0}'", txtShCT(0).Text), String.Empty)), _
                                                    (IIf(Strings.Len(txtShCT(1).Text) > 0, String.Format(" AND SoHieu <=N'{0}'", txtShCT(1).Text), String.Empty))))
                        StopPrint = False
                        rptFrom.ReportDestination = 0
                        GauGe.Maximum = 300
                        For Each rsItem As DataRow In rs_tk.Rows
                            If StopPrint Then
                                Exit For
                            End If
                            If rsItem("MaSo") IsNot Nothing Then
                                taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(rsItem("MaSo")))
                            End If

                            If InSoChitiet(taikhoan, tdau, tcuoi, Ngay(0), Ngay(1), False, "", 0, 0, nn) Then
                                HienThongBao(String.Format("{0} - {1}", _
                                                  ConvertToStrSafe(rsItem("SoHieu")), _
                                                  ConvertToStrSafe(rsItem("ten"))), 1)
                                AppIdle(Pdelay * 100)
                            End If
                            If GauGe.Value < GauGe.Maximum Then GauGe.Value += 1
                        Next
                        GoTo LoiBC
                    Case 3
                        If ChkDu(1).CheckState = CheckState.Checked Then
                            If ConvertToDblSafe((txtShTk(6).Tag)) = 0 Then
                                ErrMsg(er_SHTaiKhoan)
                                txtShTk(6).Focus()
                                GoTo LoiBC
                            End If
                            taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(6).Tag))
                        Else
                            taikhoan.InitTaikhoanMaSo(0)
                        End If
                        InBangThop(tdau, tcuoi, taikhoan, CboThang(2).SelectedIndex + 1, ChkDu(6).CheckState)
                    Case 4
                        If ConvertToDblSafe((txtShTk(2).Tag)) = 0 Then
                            ErrMsg(er_SHTaiKhoan)
                            txtShTk(2).Focus()
                            GoTo LoiBC
                        End If
                        If CboNT.SelectedIndex < 0 Then
                            MessageBox.Show(Ngonngu("Hãy chọn chi tiết thanh toán theo nguyên tệ !", "Choose the payment detail in d\the original currency !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtShTk(2).Focus()
                            GoTo LoiBC
                        End If
                        mtk = IIf(CboNT.SelectedIndex < 0, CboNT.SelectedIndex - 1, CboNT.SelectedIndex)
                        taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(MaTKNguyenTe(txtShTk(2).Text, mtk)))
                        If Not InSoChitietNT(taikhoan, _
                                   IIf(OptTG(0).Checked, tdau, 0), _
                                   IIf(OptTG(0).Checked, tcuoi, 0), _
                                   Ngay(1), _
                                   Ngay(2), _
                                   CboNT.SelectedIndex, _
                                   True) Then GoTo LoiBC
                    Case 5
                        If ConvertToDblSafe((txtShTk(3).Tag)) = 0 Then
                            ErrMsg(er_SHTaiKhoan)
                            txtShTk(3).Focus()
                            GoTo LoiBC
                        End If
                        If Index = 0 Then GoTo KhongIn
                        rs_tk = ExecSQLReturnDT(String.Format("SELECT MaSo, SoHieu, Ten, KyHieu FROM HethongTK INNER JOIN NguyenTe ON HethongTK.MaNT=NguyenTe.MaSo WHERE SoHieu LIKE '{0}%' AND TkCon=0 ORDER BY SoHieu", txtShTk(3).Text))
                        StopPrint = False
                        rptFrom.ReportDestination = 0
                        GauGe.Maximum = 10
                        For Each rsItem As DataRow In rs_tk.Rows
                            If StopPrint Then
                                Exit For
                            End If
                            HienThongBao(String.Format("{0} - {1} - {2}", _
                                                 ConvertToStrSafe(rsItem("SoHieu")), _
                                                 ConvertToStrSafe(rsItem("ten")), _
                                                 ConvertToStrSafe(rsItem("KyHieu"))), 1)
                            taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(rsItem("MaSo")))
                            If InSoChitietNT(taikhoan, tdau, tcuoi, Ngay(1), Ngay(2), CboNT.SelectedIndex, False) Then
                                HienThongBao(String.Format("{0} - {1}", _
                                            ConvertToStrSafe(rsItem("SoHieu")), _
                                            ConvertToStrSafe(rsItem("ten"))), 1)

                                AppIdle(Pdelay * 100)
                            End If
                            If GauGe.Value < GauGe.Maximum Then GauGe.Value += 1
                        Next
                        GoTo LoiBC
                    Case 6
                        If Index = 0 Then GoTo KhongIn
                        rs_tk = ExecSQLReturnDT("SELECT MaSo, SoHieu, Ten FROM HethongTK WHERE MaNT>0 ORDER BY SoHieu")
                        StopPrint = False
                        rptFrom.ReportDestination = 0
                        GauGe.Maximum = 10
                        For Each rsItem As DataRow In rs_tk.Rows
                            If StopPrint Then
                                Exit For
                            End If
                            If rsItem("MaSo") IsNot Nothing Then
                                taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(rsItem("MaSo")))
                            End If
                            If InSoChitietNT(taikhoan, tdau, tcuoi, Ngay(1), Ngay(2), CboNT.SelectedIndex, False) Then
                                HienThongBao(String.Format("{0} - {1}", _
                                            ConvertToStrSafe(rsItem("SoHieu")), _
                                            ConvertToStrSafe(rsItem("ten"))), 1)

                                AppIdle(Pdelay * 100)
                            End If
                            If GauGe.Value < GauGe.Maximum Then GauGe.Value += 1
                        Next
                        GoTo LoiBC
                    Case 7
                        InBangThopNT(tdau, tcuoi)
                    Case 8
                        InCdt(False, tdau, tcuoi, CboThang(2).SelectedIndex + 1, ChkDu(6).CheckState)
                    Case 9
                        If ChkDu(16).CheckState Then
                            tdau = CboThang(0).SelectedIndex
                            tcuoi = CboThang(1).SelectedIndex
                            FrmCandoi.Candoiluoi(tdau, tcuoi, CboThang(2).SelectedIndex)
                            GoTo LoiBC
                        Else
                            InCdt(True, tdau, tcuoi, CboThang(2).SelectedIndex + 1, ChkDu(6).CheckState)
                        End If
                    Case 32
                        If CboThang(2).Items.Count > 0 Then
                            InTK(CboThang(2).SelectedIndex + 1, tdau, tcuoi)
                        End If

                    Case 42
                        If ConvertToDblSafe(txtShTk(8).Tag) = 0 Then
                            ErrMsg(er_SHTaiKhoan)
                            txtShTk(8).Focus()
                            GoTo LoiBC
                        End If
                        If Not BKChiTiet(xlapp, _
                                   xlsheet, _
                                   txtShTk(8).Text, _
                                   IIf(OptTG(0).Checked, tdau, 0), _
                                   IIf(OptTG(0).Checked, tcuoi, 0), _
                                   Ngay(1), _
                                   Ngay(2)) Then GoTo LoiBC
                    Case 56
                        taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(8).Tag))
                        If taikhoan.maso = 0 Or (taikhoan.tk_id <> TKCNKH_ID And taikhoan.tk_id <> TKCNPT_ID) Then
                            THPSNhomTK(txtShTk(8).Text, tdau, tcuoi)
                        Else
                            THPSNhomCN(taikhoan, tdau, tcuoi)
                        End If
                End Select
                rptFrom.ReportDestination = Index
                If NLB.Length > 0 And NLB <> "..." Then rptFrom.SetFormulas("NLB", String.Format("'{0}'", NLB))
                If KTT.Length > 0 And KTT <> "..." Then rptFrom.SetFormulas("KTT", String.Format("'{0}'", KTT))
                If GD.Length > 0 And GD <> "..." Then rptFrom.SetFormulas("GD", String.Format("'{0}'", GD))
a:
                rptFrom.ReportWindowTitle = OptBC(baocao).Text
                InBaoCaoRPT()
                GoTo LoiBC
            Case 2
                Me.Close() : Exit Sub
            Case 3
                If CboThang(0).Items.Count > 0 Then
                    tdau = CboThang(0).SelectedValue
                End If
                If CboThang(1).Items.Count > 0 Then
                    tcuoi = CboThang(1).SelectedValue
                End If

                Select Case baocao
                    Case 0
                        If Not OptBC(baocao).TabStop Then Exit Sub
                        If pRpt = CheckState.Checked And (Not ChoXemBC(baocao, "C")) Then
                            ErrMsg(er_KoSD)
                            Exit Sub
                        End If
                        Me.Cursor = Cursors.WaitCursor
                        GauGe.Value = 0
                        If CboThang(1).Items.Count > 0 Then
                            If CboThang(0).Enabled And CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
                        End If

                        If baocao = 61 Or baocao = 89 Then
                            If CboThang(0).Items.Count > 0 Then
                                CboThang(0).SelectedIndex = 0
                            End If
                            If CboThang(1).Items.Count > 0 Then
                                CboThang(1).SelectedIndex = 11
                            End If

                        End If
                        If ConvertToDblSafe((txtShTk(0).Tag)) = 0 Then
                            ErrMsg(er_SHTaiKhoan)
                            txtShTk(0).Focus()
                            GoTo LoiBC
                        End If
                        If ChkDu(0).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(5).Tag)) = 0 Then
                            txtShTk(5).Focus()
                            GoTo LoiBC
                        End If
                        If ChkDu(0).CheckState = CheckState.Checked Then
                            doiung.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(5).Tag))
                        Else
                            doiung.InitTaikhoanMaSo(0)
                        End If
                        taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(0).Tag))
                        If (taikhoan.MaTC = taikhoan.maso Or taikhoan.MaTC = 0) And Not ((taikhoan.sohieu Like "112*") And OptTG(1).Checked) Then
                            ten = "\RePorts\Socai.xls"
                            title = "SỔ CÁI TÀI KHOẢN"
                            If Not InSocaiTk1(taikhoan, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(1), Ngay(2), True, doiung.sohieu, 0, 0, nn, 0, 0, 0, ten) Then GoTo LoiBC
                        End If
                    Case 9
                        XLQCDT(True, tdau, tcuoi, CboThang(2).SelectedIndex + 1, ChkDu(6).CheckState)
                End Select
        End Select
        GoTo LoiBC
KhongIn:
        ErrMsg(er_KoXem)
        GoTo LoiBC
Bad:
        If Information.Err().Number = 20510 Then GoTo a
        MessageBox.Show(String.Format("Error {0}: {1}", Information.Err().Number, Information.Err().Description), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
LoiBC:
        HienThongBao(Me.Text, 1)
        GauGe.Value = GauGe.Maximum
        taikhoan = Nothing
        doiung = Nothing
        rs_tk = Nothing
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub FormInit()
        HienThongBao(Me.Text, 1)
    End Sub

    ''' Xử lý phím nóng

    Private Sub FrmSochiphi_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.X
                    Command(0).Focus()
                    'Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.I
                    Command(1).Focus()
                    'Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.V
                    Command(2).Focus()
                    ' Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.E
                    If Command(3).Enabled Then
                        Command(3).Focus()
                        '  Command_ClickEvent(Command(3), New EventArgs())
                    End If
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
    ''' <summary>
    ''' Khởi tạo cửa sổ báo cáo
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmSochiphi_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            AddMonthToCbo(CboThang(0))
            AddMonthToCbo(CboThang(1))
            InitCap(CboThang(2), 1, 6, 5)
            If CboThang(2).Items.Count > 0 Then
                CboThang(2).SelectedIndex = CboThang(2).Items.Count - 1
            End If

            OptBC_CheckedChanged(OptBC(0), New EventArgs())
            Pdelay = ConvertToDblSafe(Interaction.GetSetting(IniPath, "Environment", "PrinterDelay", ConvertToStrSafe(10)))
            For chi_so As Integer = 1 To 2
                InitDateVars(MedNgay(chi_so), Ngay(chi_so))
            Next
            Text = SetFormTitle(Text)
            NLB = Interaction.GetSetting(IniPath, "Environment", "SReport1", String.Empty)
            KTT = Interaction.GetSetting(IniPath, "Environment", "SReport2", String.Empty)
            GD = Interaction.GetSetting(IniPath, "Environment", "SReport3", String.Empty)
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
    Private Sub FrmSochiphi_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
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
    Private Sub FTonghop_DoubleClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles FTonghop.DoubleClick
        FThuChi.Tag = ConvertToStrSafe(10)
        FThuChi.GetPhieu(NLB, KTT, GD, 0)
        Interaction.SaveSetting(IniPath, "Environment", "SReport1", NLB)
        Interaction.SaveSetting(IniPath, "Environment", "SReport2", KTT)
        Interaction.SaveSetting(IniPath, "Environment", "SReport3", GD)
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
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_1.Leave, _MedNgay_2.Leave
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
    Private Sub OptBC_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptBC_0.CheckedChanged, _OptBC_1.CheckedChanged, _OptBC_2.CheckedChanged, _OptBC_3.CheckedChanged, _OptBC_4.CheckedChanged, _OptBC_5.CheckedChanged, _OptBC_6.CheckedChanged, _OptBC_7.CheckedChanged, _OptBC_8.CheckedChanged, _OptBC_9.CheckedChanged, _OptBC_32.CheckedChanged, _OptBC_42.CheckedChanged, _OptBC_56.CheckedChanged, _OptBC_69.CheckedChanged, _OptBC_75.CheckedChanged, _OptBC_76.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(OptBC, eventSender)
            Command(3).Enabled = OptBC(0).Checked Or OptBC(9).Checked
            ChkDu(16).CheckState = CheckState.Unchecked
            Select Case Index
                Case 0, 9
                    ChkDu(16).Enabled = True
                Case Else
                    ChkDu(16).Enabled = False
            End Select
            Select Case Index
                Case 0, 42, 69, 75
                    OptTG(1).Enabled = True
                Case Else
                    OptTG_CheckedChanged(OptTG(0), New EventArgs())
                    OptTG(0).Checked = True
                    OptTG(1).Enabled = False
            End Select
            baocao = Index
            ChkDu(0).Visible = (Index = 0)
            txtShTk(5).Visible = (Index = 0)
            cmdtk(5).Visible = (Index = 0)
            LbTenTk(5).Visible = (Index = 0)
            If Index = 3 Then ChkDu(6).CheckState = CheckState.Unchecked
            Label(6).Visible = (Index = 2)
            txtShCT(1).Visible = (Index = 2)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub OptBC_MouseDown(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles _OptBC_0.MouseDown, _OptBC_1.MouseDown, _OptBC_2.MouseDown, _OptBC_3.MouseDown, _OptBC_4.MouseDown, _OptBC_5.MouseDown, _OptBC_6.MouseDown, _OptBC_7.MouseDown, _OptBC_8.MouseDown, _OptBC_9.MouseDown, _OptBC_32.MouseDown, _OptBC_42.MouseDown, _OptBC_56.MouseDown, _OptBC_69.MouseDown, _OptBC_75.MouseDown, _OptBC_76.MouseDown
        Dim Button As Integer = ConvertToDblSafe(eventArgs.Button)
        Dim Shift As Integer = Control.ModifierKeys \ &H10000
        Dim Index As Integer = Array.IndexOf(OptBC, eventSender)
        ' If pRpt = CheckState.Checked And Button = 2097152 And User_Right = 0 Then
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
    Private Sub OptTG_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptTG_1.CheckedChanged, _OptTG_0.CheckedChanged
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
    Private Sub txtLS_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtLS_1.Enter, _txtLS_0.Enter
        Dim Index As Integer = Array.IndexOf(txtLS, eventSender)
        txtLS(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtLS_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtLS_1.KeyPress, _txtLS_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtLS, eventSender)
        KeyProcess(txtLS(Index), KeyAscii)
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
    Private Sub txtShTk_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShTk_1.Enter, _txtShTk_0.Enter, _txtShTk_5.Enter, _txtShTk_6.Enter, _txtShTk_2.Enter, _txtShTk_3.Enter, _txtShTk_8.Enter
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        txtShTk(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtShTk_1.KeyPress, _txtShTk_0.KeyPress, _txtShTk_5.KeyPress, _txtShTk_6.KeyPress, _txtShTk_2.KeyPress, _txtShTk_3.KeyPress, _txtShTk_8.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        If KeyAscii = 13 Then cmdtk_ClickEvent(cmdtk(Index), New EventArgs())
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    ''' <summary>
    ''' Kiểm tra số hiệu tài khoản đã nhập
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShTk_1.Leave, _txtShTk_0.Leave, _txtShTk_5.Leave, _txtShTk_6.Leave, _txtShTk_2.Leave, _txtShTk_3.Leave, _txtShTk_8.Leave
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        Dim CboNT_NewIndex2 As Integer = -1
        txtShTk(Index).Text = txtShTk(Index).Text.ToUpper()
        Dim mtk As Integer = 0
        LbTenTk(Index).Text = tentk(txtShTk(Index).Text, mtk)
        txtShTk(Index).Tag = ConvertToStrSafe(mtk)
        If Index = 2 Then
            Int_RecsetToCbo(String.Format("SELECT HethongTK.MaNT As F2,NguyenTe.KyHieu As F1 FROM HethongTK INNER JOIN NguyenTe ON HethongTK.MaNT = NguyenTe.MaSo WHERE HethongTK.SoHieu =N'{0}' ORDER BY NguyenTe.KyHieu", txtShTk(2).Text), CboNT)
            If CboNT.Items.Count > 0 Then
                CboNT.Items.Insert(0, New ValueDescriptionPair(0, pTienStr))
            End If
            If CboNT.Items.Count = 2 Then
                CboNT.Items.Add(String.Format("{0}+{1}", VB6.GetItemString(CboNT, 0), VB6.Support.GetItemString(CboNT, 1)), -1)
            End If
        End If
        HienThongBao(Me.Text, 1)
    End Sub
    ''' <summary>
    ''' Thu tuc in bang tong hop so du chi tiet
    ''' </summary>
    ''' <param name="tdau">Thang in bao cao</param>
    ''' <param name="tcuoi"></param>
    ''' <param name="taikhoan"></param>
    ''' <param name="cap"></param>
    ''' <param name="ct"></param>
    ''' <remarks></remarks>
    Private Sub InBangThop(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef taikhoan As ClsTaikhoan, ByRef cap As Integer, ByRef ct As Integer)
        Dim st As String = String.Empty
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        Dim sqlcx As New StringBuilder
        Dim sqlnx As New StringBuilder
        GauGe.Maximum = 3
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
            If sqlnx.Length = 0 Then
                sqlnx.Append(String.Format("No_{0}", i))
            Else
                sqlnx.Append(String.Format(" + No_{0}", i))
            End If

            If sqlcx.Length = 0 Then
                sqlcx.Append(String.Format("Co_{0}", i))
            Else
                sqlcx.Append(String.Format(" + Co_{0}", i))
            End If
        Next
        GauGe.Value = 1
        st = ConvertToStrSafe(CThangDB2(tcuoi))
        Dim QTongHopCT As String
        If taikhoan.maso > 0 Then
            QTongHopCT = String.Format("SELECT DISTINCT SoHieu, (Cap) AS FirstOfCap, (Ten{0}) AS FirstOfTen, (Kieu) AS FirstOfKieu, (Loai) AS FirstOfLoai, case when max(MaTC) = max(MaSo) OR max(MaTC) = 0 then -1 else 0 end AS FirstOfChuanLa, (TKCon) AS FirstOfTKCon, (CapDuoi) AS CD, Sum(DuNo_{1}) AS DkNo, Sum(DuCo_{2}) AS DkCo, Sum({3}) AS PsNo, Sum({4}) AS PsCo, Sum({5}) AS PsNoX, Sum({6}) AS PsCoX, Sum(DuNo_{7}) AS CkNo, Sum(DuCo_{7}) AS CkCo FROM HeThongTK WHERE (Cap > {8} AND Cap<={9}) GROUP BY SoHieu,Cap,Ten,Kieu,Loai,tkcon,capduoi Having (((Loai)>0) AND (SoHieu LIKE '{10}%')) ORDER BY SoHieu", _
                             (IIf(pNN > 0, "E", String.Empty)), _
                             CThangDB2(ThangTruoc(tdau)), _
                             ConvertToStrSafe(CThangDB2(ThangTruoc(tdau))), _
                             sqln, _
                             sqlc, _
                             sqlnx, _
                             sqlcx, _
                             st, _
                             taikhoan.cap, _
                             ConvertToStrSafe(cap), _
                             (IIf(Not (taikhoan.sohieu Like "L*"), taikhoan.sohieu, Strings.Right(taikhoan.sohieu, 1))))
        Else
            QTongHopCT = String.Format("SELECT DISTINCT SoHieu, (Cap) AS FirstOfCap, (Ten{0}) AS FirstOfTen, (Kieu) AS FirstOfKieu, (Loai) AS FirstOfLoai, case when max(MaTC) = max(MaSo) OR max(MaTC) = 0 then -1 else 0 end AS FirstOfChuanLa, (TKCon) AS FirstOfTKCon, (CapDuoi) AS CD, Sum(DuNo_{1}) AS DkNo, Sum(DuCo_{2}) AS DkCo, Sum({3}) AS PsNo, Sum({4}) AS PsCo, Sum({5}) AS PsNoX, Sum({6}) AS PsCoX, Sum(HeThongTK.DuNo_{7}) AS CkNo, Sum(HeThongTK.DuCo_{7}) AS CkCo FROM HeThongTK WHERE  Cap<={8} GROUP BY SoHieu,Cap,Ten,Kieu,Loai,tkcon,capduoi Having (Loai)>0 AND (Cap > 0){9} ORDER BY SoHieu", _
                             (IIf(pnn > 0, "E", String.Empty)), _
                             CThangDB2(ThangTruoc(tdau)), _
                             ConvertToStrSafe(CThangDB2(ThangTruoc(tdau))), _
                             sqln, _
                             sqlc, _
                             sqlnx, _
                             sqlcx, _
                             st, _
                             cap, _
                             (IIf(ct = 0, String.Format(" AND (Sum(DuNo_{0})<>0 OR Sum(DuCo_{0})<>0 OR Sum({1})<>0 OR Sum({2})<>0 OR Sum({3})<>0 OR Sum({4})<>0)", _
                                              st, _
                                              sqln, _
                                              sqlc, _
                                              sqlnx, _
                                              sqlcx), String.Empty)))
        End If
        GauGe.Value = 2
        XDCapTK(IIf(taikhoan.maso > 0, taikhoan.sohieu, String.Empty))

        rptFrom.InitForm("THSDCT.RPT", QTongHopCT, "QTongHopCT")

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        If taikhoan.maso > 0 Then
            rptFrom.SetFormulas("TenBaoCao", String.Format("'{0}{1} - {2}'", _
                                                        ("Tài khoản: "), _
                                                        taikhoan.sohieu, _
                                                        (IIf(pnn > 0, taikhoan.TenE, taikhoan.ten))))
            rptFrom.SetFormulas("Cap", taikhoan.cap + 1)
        End If

        GauGe.Value = 3
    End Sub
    ''' <summary>
    ''' Thu tuc in bang can doi thu
    ''' </summary>
    ''' <param name="saukc"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="cap"></param>
    ''' <param name="ct"></param>
    ''' <remarks></remarks>
    Private Sub InCdt(ByRef saukc As Boolean, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef cap As Integer, ByRef ct As Integer)
        Dim st As String = String.Empty
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        GauGe.Maximum = 3
        SoDuTKCN2(ThangTruoc(tdau))
        SoDuTKCN2(tcuoi)
        If Not saukc Then XacdinhKC(tdau, tcuoi)
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            If sqln.Length = 0 Then
                sqln.Append(String.Format("HethongTk.No_{0}", i))
            Else
                sqln.Append(String.Format(" + HethongTk.No_{0}", i))
            End If

            If sqlc.Length = 0 Then
                sqlc.Append(String.Format("HethongTk.Co_{0}", i))
            Else
                sqlc.Append(String.Format(" + HethongTk.Co_{0}", i))
            End If
        Next
        st = ConvertToStrSafe(CThangDB2(tcuoi))
        GauGe.Value = 1
        Dim QCdt As String = String.Format("SELECT DISTINCT HeThongTK.SoHieu, HeThongTK.Cap, HeThongTK.Ten{0}, HeThongTK.Kieu, HeThongTK.Loai, HeThongTK.DuNo_{1} As DkNo, HeThongTK.DuCo_{2} As DkCo, {3} As PsNo, {4} As PsCo, KC_N, KC_C, {5} As CkNo, {6} As CkCo FROM HeThongTK WHERE ((HeThongTK.MaTC = 0 Or HethongTK.MaTC = HethongTK.MaSo) OR (TK_ID3 % 10 >= 1)) And (HeThongTK.Loai > 0)  AND Cap<={7}{8}", _
                                 (IIf(pnn > 0, "E", String.Empty)), _
                                 CThangDB2(ThangTruoc(tdau)), _
                                 ConvertToStrSafe(CThangDB2(ThangTruoc(tdau))), _
                                 sqln, _
                                 sqlc, _
                                 (IIf(saukc, "HeThongTK.DuNo_" & st, "HethongTk.DuNo")), _
                                 (IIf(saukc, "HeThongTK.DuCo_" & st, "HethongTk.DuCo")), _
                                 ConvertToStrSafe(cap), _
                                 (IIf(ct = 0, String.Format(" AND (DuNo_{0}<>0 OR DuCo_{0}<>0 OR ({1})<>0 OR ({2})<>0)", _
                                                  st, _
                                                  sqln, _
                                                  sqlc), String.Empty)))
        GauGe.Value = 2
        rptFrom.InitForm("CDT.RPT", QCdt, "QCdt")

        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        If saukc Then
            rptFrom.SetFormulas("SauKc", "'TRUE'")
        Else
            rptFrom.SetFormulas("SauKc", "'FALSE'")
        End If


        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        GauGe.Value = 3
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="taikhoan"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="loai"></param>
    ''' <param name="thongbao"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function InSoChitietNT(ByRef taikhoan As ClsTaikhoan, _
        ByRef tdau As Integer, _
        ByRef tcuoi As Integer, _
        ByRef ndau As Date, _
        ByRef ncuoi As Date, _
        ByRef loai As Integer, _
        ByRef thongbao As Boolean) As Boolean
        Dim result As Boolean = False
        Dim psn2, psn, dkc, dkn, dknt, psc, psc2 As Double
        Dim sqlw As String = String.Empty
        Dim ps As Boolean
        Dim m2 As Integer
        With taikhoan
            If tcuoi > 0 Then
                ps = .TkCoPS(tdau, tcuoi)
                If loai >= 0 Then
                    .SoDuTK(ThangTruoc(tdau), dkn, dkc, dknt, 1)
                Else
                    sqlw = ConvertToStrSafe(CThangDB2(ThangTruoc(tdau)))
                    dkn = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(DuNo_{0}) AS F1,Sum(DuCo_{0}) AS F2,Sum(DuNT_{0}) AS F3 FROM HethongTK WHERE SoHieu=N'{1}'", _
                                                              sqlw, _
                                                              .sohieu), dkc, dknt))
                    m2 = ConvertToDblSafe(MaTKNguyenTe(.sohieu, -1))
                    ps = ps Or (ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaCT AS F1 FROM ChungTu WHERE (MaTKNo={0} OR MaTKCo={1}) AND {2}", _
                                                                    m2, _
                                                                    ConvertToStrSafe(m2), _
                                                                    WThang("ThangCT", tdau, tcuoi)))) > 0)
                End If
                sqlw = WThang("ThangCT", tdau, tcuoi)
            Else
                ps = .TkCoPSN(ndau, ncuoi)
                If loai >= 0 Then
                    .SoDuNgay(ndau.AddDays(-1), dkn, dkc, dknt)
                Else
                    SoDuTKNgaySH(.sohieu, ndau.AddDays(-1), dkn, dkc, dknt)
                    m2 = ConvertToDblSafe(MaTKNguyenTe(.sohieu, -1))
                    ps = ps Or (ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaCT AS F1 FROM ChungTu WHERE (MaTKNo={0} OR MaTKCo={1}) AND {2}", _
                                                                    m2, _
                                                                    ConvertToStrSafe(m2), _
                                                                    WNgay("ThangCT", ndau, ncuoi)))) > 0)
                End If
                sqlw = WNgay("NgayGS", ndau, ncuoi)
            End If
            ' In bao cao
            If dkn <> 0 Or dkc <> 0 Or dknt <> 0 Or ps Then
                GauGe.Maximum = 3
                GauGe.Value = 1
                Dim QChitiet As String
                If ps Then
                    QChitiet = String.Format("SELECT DISTINCT ChungTu.MaCT, ChungTu.SoHieu, ChungTu.NgayCT as [NgayCT], ChungTu.NgayGS as [NgayGS], ChungTu.DienGiai{0}, ChungTu.SoPS, ChungTu.SoPS2No, ChungTu.SoPS2Co, ChungTu.GhiChu, HeThongTK.SoHieu as [HeThongTK.SoHieu], HeThongTK_1.SoHieu as [HeThongTK_1.SoHieu], ChungTu.MaTKNo, ChungTu.MaTKCo FROM HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo WHERE ((chungtu.MaTkNo = {1}) Or (chungtu.MaTkCo = {2}){3}) And {4} ORDER BY Chungtu.NgayGS, Chungtu.MaCT", _
                                           (IIf(pnn > 0, "E", String.Empty)), _
                                           taikhoan.maso, _
                                           ConvertToStrSafe(taikhoan.maso), _
                                           (IIf(m2 > 0, String.Format(" OR (chungtu.MaTkNo = {0}) Or (chungtu.MaTkCo = {1})", m2, ConvertToStrSafe(m2)), String.Empty)), _
                                           sqlw)
                Else
                    QChitiet = "SELECT DISTINCT 0 AS MaCT, '' AS [ChungTu.SoHieu], Null AS NgayCT, Null AS NgayGS, '' AS DienGiai, 0 AS SoPS, 0 AS SoPS2No, 0 AS SoPS2Co, '' AS GhiChu, '' AS [HeThongTK.SoHieu], '' AS [HeThongTK_1.SoHieu], 0 AS MaTKNo, 0 AS MaTKCo FROM ChungTu WHERE (chungtu.MaCT = 0)"
                End If
                GauGe.Value = 2
                If taikhoan.sohieu Like "112*" And tcuoi = 0 Then
                    rptFrom.InitForm("SOTGNT.RPT", QChitiet, "QChitiet")
                Else
                    rptFrom.InitForm("CTNGTE.RPT", QChitiet, "QChitiet")
                End If

                rptFrom.SetFormulas("MaTK", .maso)
                rptFrom.SetFormulas("MaTk2", m2)
                rptFrom.SetFormulas("NoDk", dkn - dkc)
                rptFrom.SetFormulas("NoDkNT", dknt)
                rptFrom.SetFormulas("Kieu", .kieu)
                result = True
                If CboNT.SelectedIndex < CboNT.Items.Count - 1 Then
                    psn = SoPSTKMaSo(taikhoan.maso, pThangDauKy, tcuoi, -1, psn2)
                    psc = SoPSTKMaSo(taikhoan.maso, pThangDauKy, tcuoi, 1, psc2)
                Else
                    psn = SoPSTK(taikhoan.sohieu, pThangDauKy, tcuoi, -1, psn2)
                    psc = SoPSTK(taikhoan.sohieu, pThangDauKy, tcuoi, 1, psc2)
                End If
                rptFrom.SetFormulas("NoLK", psn)
                rptFrom.SetFormulas("CoLK", psc)
                rptFrom.SetFormulas("NoLK2", psn2)
                rptFrom.SetFormulas("CoLK2", psc2)
                rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi, nn)))))
                RptSetDate(IIf(tdau > 0, NgayCuoiThang(pNamTC, tcuoi), ncuoi))
                If taikhoan.sohieu Like "112*" And tcuoi = 0 Then
                    rptFrom.SetFormulas("TenTK", String.Format("'{0}'", taikhoan.GhiChu))
                    rptFrom.SetFormulas("LTG", String.Format("': {0}{1}'", ("Loại tiền: "), CboNT.Text))
                Else
                    rptFrom.SetFormulas("TenTK", String.Format("'{0} - {1} - {2}'", .sohieu, .ten, TenNT(taikhoan.MaNT)))
                End If
                GauGe.Value = 3
            Else
                If thongbao Then ErrMsg(er_KoPS1)
                result = False
            End If
        End With
        Return result
    End Function
    ''' <summary>
    ''' Thu tuc in bang tong hop so du chi tiet nguyên tệ
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub InBangThopNT(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim st As String = String.Empty
        Dim sqlcnt As New StringBuilder
        Dim sqlnnt As New StringBuilder
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        GauGe.Maximum = 3
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            If sqln.Length = 0 Then
                sqln.Append(String.Format("HethongTk.No_{0}", i))
            Else
                sqln.Append(String.Format(" + HethongTk.No_{0}", i))
            End If

            If sqlc.Length = 0 Then
                sqlc.Append(String.Format("HethongTk.Co_{0}", i))
            Else
                sqlc.Append(String.Format(" + HethongTk.Co_{0}", i))
            End If

            If sqlnnt.Length = 0 Then
                sqlnnt.Append(String.Format("HethongTk.No_{0}_NT", i))
            Else
                sqlnnt.Append(String.Format(" + HethongTk.No_{0}_NT", i))
            End If

            If sqlcnt.Length = 0 Then
                sqlcnt.Append(String.Format("HethongTk.Co_{0}_NT", i))
            Else
                sqlcnt.Append(String.Format(" + HethongTk.Co_{0}_NT", i))
            End If
        Next
        GauGe.Value = 1
        st = ConvertToStrSafe(CThangDB2(tcuoi))
        Dim QTongHopCTNT As String = String.Format("SELECT DISTINCT HeThongTK.SoHieu, HeThongTK.Ten{0}, HeThongTK.MaNT, NguyenTe.KyHieu, HeThongTK.DuNo_{1} AS DkNo, HeThongTK.DuCo_{2} AS DkCo, HeThongTK.DuNT_{2} AS DkNT,{3} AS PsNo, {4} AS PsNoNT, {5} AS PsCo, {6} AS PsCoNT, HeThongTK.DuNo_{7} AS CkNo, HeThongTK.DuCo_{7} AS CkCo, HeThongTK.DuNT_{7} AS CkNT FROM NguyenTe RIGHT JOIN HeThongTK ON NguyenTe.MaSo = HeThongTK.MaNT WHERE ((HeThongTK.Loai > 0) And (HeThongTK.mant <> 0) And ({3}<>0 OR {5}<>0 OR HeThongTK.DuNo_{7}<>0 OR HeThongTK.DuCo_{7}<>0)) ORDER BY HeThongTK.SoHieu", _
                                   (IIf(pnn > 0, "E", String.Empty)), _
                                   CThangDB2(ThangTruoc(tdau)), _
                                   ConvertToStrSafe(CThangDB2(ThangTruoc(tdau))), _
                                   sqln, _
                                   sqlnnt, _
                                   sqlc, _
                                   sqlcnt, _
                                   st)
        GauGe.Value = 2

        rptFrom.InitForm("THSDCTNT.RPT", QTongHopCTNT, "QTongHopCTNT")

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="cap"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub InTK(ByRef cap As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim st As String = String.Empty
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        Dim sqlcx As New StringBuilder
        Dim sqlnx As New StringBuilder
        GauGe.Maximum = 3
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
            If sqlnx.Length = 0 Then
                sqlnx.Append(String.Format("No_{0}", i))
            Else
                sqlnx.Append(String.Format(" + No_{0}", i))
            End If

            If sqlcx.Length = 0 Then
                sqlcx.Append(String.Format("Co_{0}", i))
            Else
                sqlcx.Append(String.Format(" + Co_{0}", i))
            End If
        Next
        GauGe.Value = 1
        st = ConvertToStrSafe(CThangDB2(ThangTruoc(tdau)))
        Dim QTongHopCT As String = String.Format("SELECT DISTINCT SoHieu, (Cap) AS FirstOfCap, (Ten{0}) AS FirstOfTen, (Kieu) AS FirstOfKieu, (Loai) AS FirstOfLoai, case when max(MaTC) = max(MaSo) OR max(MaTC) = 0 then -1 else 0 end AS FirstOfChuanLa, (TKCon) AS FirstOfTKCon, (CapDuoi) AS CD, Sum(DuNo_{1}) AS DkNo, Sum(DuCo_{1}) AS DkCo, Sum({2}) AS PsNo, Sum({3}) AS PsCo, Sum({4}) AS PsNoX, Sum({5}) AS PsCoX, Sum(HeThongTK.DuNo_{6}) AS CkNo, Sum(HeThongTK.DuCo_{6}) AS CkCo FROM HeThongTK WHERE Cap<={7} GROUP BY SoHieu,Cap,Ten,Kieu,Loai,tkcon,capduoi Having ((((Loai))>0) AND ((((Cap > 0))) OR (((max(MaTC) > 0 AND max(MaTC) <> max(MaSo)))))) ORDER BY SoHieu", _
                                 (IIf(pnn > 0, "E", String.Empty)), _
                                 st, _
                                 sqln, _
                                 sqlc, _
                                 sqlnx, _
                                 sqlcx, _
                                 ConvertToStrSafe(CThangDB2(tcuoi)), _
                                 cap)
        GauGe.Value = 2
        XDCapTK("")
        rptFrom.InitForm("THSDCT.RPT", QTongHopCT, "QTongHopCT")
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub THPSNhomTK(ByRef sh As String, ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim taikhoan As New ClsTaikhoan
        Dim ckc, psc2, psc, dknt, dkn, dkc, psn, psn2, ckn, cknt As Double
        Dim rs_tk As DataTable
        Dim sql = String.Empty, s As String = String.Empty
        ExecSQLNonQuery("DELETE  FROM BKNhomPS")
        Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT DISTINCT MaSo FROM HethongTK WHERE SoHieu LIKE '{0}%' AND TKCon=0", sh))
        For Each rsMasterItem As DataRow In rs.Rows
            taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(rsMasterItem("MaSo")))
            taikhoan.SoDuTK(ThangTruoc(tdau), dkn, dkc, dknt)
            psn = 0
            psc = 0
            psn2 = 0
            psc2 = 0
            ExecSQLNonQuery(String.Format("INSERT INTO BKNhomPS ( MaCT,ShTK,SoPSNo,SoPSCo,DienGiai,SoPS2No,SoPS2Co) VALUES (-1, N'{1}',{2},{3}, N'{4}',{5},{6})", _
                                Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
                                taikhoan.sohieu, _
                                CStr(Math.Max(dkn - dkc, 0)), _
                                CStr(IIf(dkn - dkc < 0, dkc - dkn, 0)), _
                                (IIf(pnn > 0, taikhoan.TenE, taikhoan.ten)), _
                                CStr(IIf(dkn - dkc > 0, dknt, 0)), _
                                CStr(IIf(dkn - dkc < 0, dknt, 0))))
            sql = String.Format("SELECT DISTINCT ChungTu.MaCT,ChungTu.SoHieu,ChungTu.NgayCT,ChungTu.DienGiai{0} AS DG,ChungTu.SoPS, CASE WHEN (HethongTK.MaNT>0) THEN SoPS2No ELSE 0 END AS SoPS2N,CASE WHEN (HethongTK_1.MaNT>0) THEN SoPS2Co ELSE 0 END AS SoPS2C,HethongTK.SoHieu As SHNo, HethongTK_1.SoHieu As SHCo FROM HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK INNER JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo) ON HeThongTK_1.MaSo = ChungTu.MaTKCo WHERE (SoPS<>0 OR SoPS2No<>0 OR SoPS2Co<>0) AND (HeThongTK.SoHieu =N'{1}') AND {2} AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco)) ORDER BY ChungTu.NgayCT, ChungTu.MaCT", (IIf(pnn > 0, "E", String.Empty)), taikhoan.sohieu, WThang("ThangCT", tdau, tcuoi))
            rs_tk = ExecSQLReturnDT(sql)
            For Each rsItem As DataRow In rs_tk.Rows
                psn += ConvertToDblSafe(rsItem("sops"))
                psn2 += ConvertToDblSafe(rsItem("SoPS2N"))
                s = IIf(IsDBNull(rsItem("shco")), "...", ConvertToStrSafe(rsItem("shco")))
                ExecSQLNonQuery(String.Format("INSERT INTO BKNhomPS ( MaCT,ShTK,SoPSNo,Ngay,SoHieu,DienGiai,ShDu,SoPS2No) VALUES ({1}, N'{2}',{3}, N'{4}', N'{5}', N'{6}', N'{7}',{8})", _
                                    Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
                                    ConvertToStrSafe(rsItem("MaCT")), _
                                    taikhoan.sohieu, _
                                    CStr(ConvertToDblSafe(rsItem("sops"))), _
                                    Format(ConvertToDateSafe(rsItem("NgayCT")), Mask_DB), _
                                    rsItem("SoHieu"), _
                                    rsItem("dg"), _
                                    s, _
                                    CStr(ConvertToDblSafe(rsItem("SoPS2N")))))
            Next
            sql = String.Format("SELECT DISTINCT ChungTu.MaCT,ChungTu.SoHieu,ChungTu.NgayCT,ChungTu.DienGiai{0} AS DG,ChungTu.SoPS,CASE WHEN (HethongTK.MaNT>0) THEN SoPS2No ELSE 0 END AS SoPS2N,CASE WHEN (HethongTK_1.MaNT>0) THEN SoPS2Co ELSE 0 END AS SoPS2C,HethongTK.SoHieu As SHNo, HethongTK_1.SoHieu As SHCo FROM HeThongTK AS HeThongTK_1 INNER JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo) ON HeThongTK_1.MaSo = ChungTu.MaTKCo WHERE (SoPS<>0 OR SoPS2No<>0 OR SoPS2Co<>0) AND (HethongTK_1.SoHieu =N'{1}') AND {2} AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco)) ORDER BY ChungTu.NgayCT, ChungTu.MaCT", _
                      (IIf(pnn > 0, "E", String.Empty)), _
                      taikhoan.sohieu, _
                      WThang("ThangCT", tdau, tcuoi))
            rs_tk = ExecSQLReturnDT(sql)
            For Each rsItem As DataRow In rs_tk.Rows
                If rsItem("sops") IsNot Nothing Then
                    psc += ConvertToDblSafe(rsItem("sops"))
                End If
                If rsItem("SoPS2C") IsNot Nothing Then
                    psc2 += ConvertToDblSafe(rsItem("SoPS2C"))
                End If
                If rsItem("shno") IsNot Nothing Then
                    s = IIf(IsDBNull(rsItem("shno")), "...", ConvertToStrSafe(rsItem("shno")))
                End If

                ExecSQLNonQuery(String.Format("INSERT INTO BKNhomPS (MaCT,ShTK,SoPSCo,Ngay,SoHieu,DienGiai,ShDu,SoPS2Co) VALUES ({1}, N'{2}',{3}, N'{4}', N'{5}', N'{6}', N'{7}',{8})", _
                                    Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
                                    rsItem("MaCT"), _
                                    taikhoan.sohieu, _
                                    CStr(ConvertToDblSafe(rsItem("sops"))), _
                                    Format(rsItem("NgayCT"), Mask_DB), _
                                    rsItem("SoHieu"), _
                                    rsItem("dg"), _
                                    s, _
                                    CStr(ConvertToDblSafe(rsItem("SoPS2C")))))
            Next
            ckn = dkn - dkc + psn - psc
            If ckn > 0 Then
                ckc = 0
            Else
                ckc = -ckn
                ckn = 0
            End If
            cknt = IIf(ckn - ckc > 0, dknt + psn2 - psc2, dknt - psn2 + psc2)
            ExecSQLNonQuery(String.Format("INSERT INTO BKNhomPS (MaCT,ShTK,SoPSNo,SoPSCo,DienGiai,SoPS2No,SoPS2Co) VALUES (0, N'{1}',{2},{3}, N'{4}',{5},{6})", _
                                Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
                                taikhoan.sohieu, _
                                CStr(IIf(ckn - ckc > 0, ckn - dkc, 0)), _
                                CStr(IIf(ckn - ckc < 0, ckc - ckn, 0)), _
                                (IIf(pnn > 0, taikhoan.TenE, taikhoan.ten)), _
                                CStr(IIf(ckn - ckc > 0, cknt, 0)), _
                                CStr(IIf(ckn - ckc < 0, cknt, 0))))
            If dkn = 0 And dkc = 0 And psn = 0 And psc = 0 And psn2 = 0 And psc2 = 0 Then
                ExecSQLNonQuery(String.Format("DELETE  FROM BKNhomPS WHERE ShTK='{0}'", taikhoan.sohieu))
            End If
        Next

        rptFrom.InitForm("THPSCT.RPT", "SELECT * FROM BKNhomPS", "BKNhomPS")
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="taikhoan"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub THPSNhomCN(ByRef taikhoan As ClsTaikhoan, ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim kh As New clsKhachHang
        Dim psn2, psc2, ckc, psc, dknt, dkn, dkc, psn, ckn, cknt As Double
        Dim rs_tk As DataTable
        Dim sql= String.Empty, s As String = String.Empty

        ExecSQLNonQuery("DELETE  FROM BKNhomPS")
        Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT DISTINCT MaKhachHang,MaTaiKhoan FROM SoDuKhachHang INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo WHERE HethongTK.SoHieu LIKE '{0}%' GROUP BY MaTaiKhoan,MaKhachHang", taikhoan.sohieu))
        For Each rsItem As DataRow In rs.Rows
            kh.InitKhachHangMaSo(ConvertToDblSafe(rsItem("MaKhachHang")))
            kh.SoDuKH(ThangTruoc(tdau), dkn, dkc, dknt, ConvertToDblSafe(rsItem("MaTaiKhoan")))
            psn = 0
            psc = 0
            psn2 = 0
            psc2 = 0
            Dim rowEffectCount As Integer = ExecSQLNonQueryUpdateInsertDeleteQuery(String.Format("UPDATE BKNhomPS SET SoPSNo=SoPSNo+{0},SoPSCo=SoPSCo+{1},SoPS2No=SoPS2No+{2},SoPS2Co=SoPS2Co+{3} WHERE ShTK=N'{4}' AND MaCT=-1", _
                                                                CStr(Math.Max(dkn - dkc, 0)), _
                                                                CStr(Math.Max(dkc - dkn, 0)), _
                                                                CStr(IIf(dkn - dkc > 0, dknt, 0)), _
                                                                CStr(IIf(dkc - dkn > 0, dknt, 0)), _
                                                                kh.SoHieu))
            If rowEffectCount = 0 Then
                ExecSQLNonQuery(String.Format("INSERT INTO BKNhomPS (MaCT,ShTK,SoPSNo,SoPSCo,DienGiai,SoPS2No,SoPS2Co) VALUES (-1, N'{1}',{2},{3}, N'{4}',{5},{6})", _
                                    Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
                                    kh.SoHieu, _
                                    CStr(Math.Max(dkn - dkc, 0)), _
                                    CStr(Math.Max(dkc - dkn, 0)), _
                                    kh.Ten, _
                                    CStr(IIf(dkn - dkc > 0, dknt, 0)), _
                                    CStr(IIf(dkc - dkn > 0, dknt, 0))))
            End If
            sql = String.Format("SELECT DISTINCT ChungTu.MaCT,ChungTu.SoHieu,ChungTu.NgayCT,ChungTu.DienGiai{0} AS DG,ChungTu.SoPS,CASE WHEN ({1}>0) THEN SoPS2No ELSE 0 END AS SoPS2N,CASE WHEN ({1}>0) THEN SoPS2Co ELSE 0 END AS SoPS2C,HethongTK.SoHieu As SHNo, HethongTK_1.SoHieu As SHCo,MaKH FROM (HeThongTK INNER JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo) LEFT JOIN HethongTK AS HethongTK_1 ON ChungTu.MaTKCo=HethongTK_1.MaSo WHERE (MaTKNo={2}) AND (MaKH={3}) AND {4} AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco)) ORDER BY ChungTu.NgayCT, ChungTu.MaCT", _
                      (IIf(pnn > 0, "E", String.Empty)), _
                      kh.MaNT, _
                      rsItem("MaTaiKhoan"), _
                      rsItem("MaKhachHang"), _
                      WThang("ThangCT", tdau, tcuoi))
            rs_tk = ExecSQLReturnDT(sql)
            For Each rstkItem As DataRow In rs_tk.Rows
                If rsItem("sops") IsNot Nothing Then
                    psn += ConvertToDblSafe(rstkItem("sops"))
                End If
                If rsItem("SoPS2N") IsNot Nothing Then
                    psn2 += ConvertToDblSafe(rstkItem("SoPS2N"))
                End If
                If rsItem("shco") IsNot Nothing Then
                    s = IIf(IsDBNull(rstkItem("shco")), "...", ConvertToStrSafe(rstkItem("shco")))
                End If

                ExecSQLNonQuery(String.Format("INSERT INTO BKNhomPS (MaCT,ShTK,SoPSNo,Ngay,SoHieu,DienGiai,ShDu,SoPS2No) VALUES ({1}, N'{2}',{3}, N'{4}', N'{5}', N'{6}', N'{7}',{8})", _
                                    Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
                                    rstkItem("MaCT"), _
                                    kh.SoHieu, _
                                    CStr(ConvertToDblSafe(rstkItem("sops"))), _
                                    Format(rs_tk("NgayCT"), Mask_DB), _
                                    rstkItem("SoHieu"), _
                                    rstkItem("dg"), _
                                    s, _
                                    CStr(ConvertToDblSafe(rstkItem("SoPS2N")))))
            Next
            sql = String.Format("SELECT DISTINCT ChungTu.MaCT,ChungTu.SoHieu,ChungTu.NgayCT,ChungTu.DienGiai{0} AS DG,ChungTu.SoPS,CASE WHEN ({1}>0) THEN SoPS2No ELSE 0 END AS SoPS2N,CASE WHEN ({1}>0) THEN SoPS2Co ELSE 0 END AS SoPS2C,HethongTK.SoHieu As SHNo, HethongTK_1.SoHieu As SHCo,MaKHC FROM (HeThongTK AS HeThongTK_1 INNER JOIN ChungTu ON HeThongTK_1.MaSo = ChungTu.MaTKCo) LEFT JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE (MaTKCo={2}) AND (MaKHC={3}) AND {4} AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco)) ORDER BY ChungTu.NgayCT, ChungTu.MaCT", _
                      (IIf(pnn > 0, "E", String.Empty)), _
                      kh.MaNT, _
                      rsItem("MaTaiKhoan"), _
                      rsItem("MaKhachHang"), _
                      WThang("ThangCT", tdau, tcuoi))
            rs_tk = ExecSQLReturnDT(sql)
            For Each rstkItem As DataRow In rs_tk.Rows
                If rsItem("sops") IsNot Nothing Then
                    psc += ConvertToDblSafe(rstkItem("sops"))
                End If
                If rsItem("SoPS2C") IsNot Nothing Then
                    psc2 += ConvertToDblSafe(rstkItem("SoPS2C"))
                End If
                If rsItem("shno") IsNot Nothing Then
                    s = IIf(IsDBNull(rs_tk("shno")), "...", ConvertToStrSafe(rstkItem("shno")))
                End If

                ExecSQLNonQuery(String.Format("INSERT INTO BKNhomPS (MaCT,ShTK,SoPSCo,Ngay,SoHieu,DienGiai,ShDu,SoPS2Co) VALUES ({1}, N'{2}',{3}, N'{4}', N'{5}', N'{6}', N'{7}',{8})", _
                                    Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
                                    rstkItem("MaCT"), _
                                    kh.SoHieu, _
                                    CStr(ConvertToDblSafe(rstkItem("sops"))), _
                                    Format(rstkItem("NgayCT"), Mask_DB), _
                                    rstkItem("SoHieu"), _
                                    rstkItem("dg"), _
                                    s, _
                                    CStr(ConvertToDblSafe(rstkItem("SoPS2C")))))
            Next
            ckn = dkn - dkc + psn - psc
            If ckn > 0 Then
                ckc = 0
            Else
                ckc = -ckn
                ckn = 0
            End If
            cknt = IIf(ckc - ckn < 0, dknt + psn2 - psc2, dknt - psn2 + psc2)
            rowEffectCount = ExecSQLNonQueryUpdateInsertDeleteQuery(String.Format("UPDATE BKNhomPS SET SoPSNo=SoPSNo+{0},SoPSCo=SoPSCo+{1},SoPS2No=SoPS2No+{2},SoPS2Co=SoPS2Co+{3} WHERE ShTK=N'{4}' AND MaCT=0", _
                                                                  CStr(Math.Max(ckn - ckc, 0)), _
                                                                  CStr(Math.Max(ckc - ckn, 0)), _
                                                                  CStr(IIf(ckn - ckc > 0, cknt, 0)), _
                                                                  CStr(IIf(ckc - ckn > 0, cknt, 0)), _
                                                                  kh.SoHieu))
            If rowEffectCount = 0 Then
                ExecSQLNonQuery(String.Format("INSERT INTO BKNhomPS (MaCT,ShTK,SoPSNo,SoPSCo,DienGiai,SoPS2No,SoPS2Co) VALUES (0, N'{1}',{2},{3}, N'{4}',{5},{6})", _
                                    Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
                                    kh.SoHieu, _
                                    CStr(Math.Max(ckn - ckc, 0)), _
                                    CStr(Math.Max(ckc - ckn, 0)), _
                                    kh.Ten, _
                                    CStr(IIf(ckn - ckc > 0, cknt, 0)), _
                                    CStr(IIf(ckc - ckn > 0, cknt, 0))))
            End If
            If dkn = 0 And dkc = 0 And psn = 0 And psc = 0 And psn2 = 0 And psc2 = 0 Then
                ExecSQLNonQuery(String.Format("DELETE  FROM BKNhomPS WHERE ShTK=N'{0}'", kh.SoHieu))
            End If
        Next
        rptFrom.InitForm("THPSCT.RPT", "SELECT * FROM BKNhomPS", "BKNhomPS")

        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        rptFrom.SetFormulas("TK", String.Format("'{0} - {1}'", taikhoan.sohieu, (IIf(pnn > 0, taikhoan.TenE, taikhoan.ten))))
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmSochiphi_DoubleClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.DoubleClick
        FThuChi.Tag = ConvertToStrSafe(10)
        FThuChi.GetPhieu(NLB, KTT, GD, 0)
        Interaction.SaveSetting(IniPath, "Environment", "SReport1", NLB)
        Interaction.SaveSetting(IniPath, "Environment", "SReport2", KTT)
        Interaction.SaveSetting(IniPath, "Environment", "SReport3", GD)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="taikhoan"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="lsv"></param>
    ''' <param name="lsg"></param>
    ''' <param name="mnt"></param>
    ''' <remarks></remarks>
    Private Sub BangKeTichSo(ByRef taikhoan As ClsTaikhoan, _
        ByRef tdau As Integer, _
        ByRef tcuoi As Integer, _
        ByRef ndau As Date, _
        ByRef ncuoi As Date, _
        ByRef lsv As Double, _
        ByRef lsg As Double, _
        ByRef mnt As Integer)
        Dim n, n1 As Date
        Dim sql As String = String.Empty
        Dim sdc, sdn, nt As Double
        Dim TK As New ClsTaikhoan
        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        taikhoan.DanXuat(TK)
        If mnt <> 0 Then TK.LayMaNT(mnt)
        If mnt = 0 Then
            sql = String.Format("SELECT -1 AS LoaiPS,NgayCT,Sum(SoPS) AS PS FROM {0} WHERE {1} AND HethongTK.SoHieu LIKE '{2}%' GROUP BY NgayCT UNION SELECT 1 AS LoaiPS,NgayCT,Sum(SoPS) AS PS FROM {3} WHERE {1} AND HethongTK.SoHieu LIKE '{2}%' GROUP BY NgayCT", _
                      ChungTu2TKNC(-1), _
                      wsql, _
                      TK.sohieu, _
                      ChungTu2TKNC(1))
        Else
            sql = String.Format("SELECT -1 AS LoaiPS,NgayCT,Sum(CASE WHEN {0}>0 THEN SoPS2No ELSE SoPS END) AS PS FROM {1} WHERE {2} AND HethongTK.SoHieu LIKE '{3}%' GROUP BY NgayCT UNION SELECT 1 AS LoaiPS,NgayCT,Sum(CASE WHEN {0}>0 THE SoPS2Co ELSE SoPS END) AS PS FROM {4} WHERE {2} AND HethongTK.SoHieu LIKE '{3}%' GROUP BY NgayCT", _
                      mnt, _
                      ChungTu2TKNC(-1), _
                      wsql, _
                      TK.sohieu, _
                      ChungTu2TKNC(1))
        End If
        'SetSQL("MienTru", sql)
        Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT * FROM ({0}) AS MienTru ORDER BY NgayCT", sql))
        If tcuoi > 0 Then
            TK.SoDuTK(ThangTruoc(tdau), sdn, sdc, nt)
        Else
            TK.SoDuNgay(ndau.AddDays(-1), sdn, sdc, nt)
        End If
        If mnt > 0 Then
            If sdn > 0 Then sdn = nt
            If sdc > 0 Then sdc = nt
        End If
        ExecSQLNonQuery("DELETE  FROM BaoCaoCP2")
        n = IIf(tcuoi > 0, NgayDauThang(pNamTC, tdau), ndau)
        Dim ms As Integer = 1
        ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Kq3,Kq4,Ngay1) VALUES (1,'1',{0},{1}, N'{2}')", _
                            CStr(sdn), _
                            CStr(sdc), _
                            Format(n, Mask_DB)))
        For Each rsItem As DataRow In rs.Rows
            If rsItem("loaips") IsNot Nothing Then
                If ConvertToDblSafe(rsItem("loaips")) < 0 Then
                    If rsItem("ps") IsNot Nothing Then
                        sdn += ConvertToDblSafe(rsItem("ps"))
                    End If

                Else
                    If rsItem("ps") IsNot Nothing Then
                        sdc += ConvertToDblSafe(rsItem("ps"))
                    End If

                End If
            End If

            If sdn - sdc >= 0 Then
                sdn -= sdc
                sdc = 0
            Else
                sdc -= sdn
                sdn = 0
            End If
            If ConvertToDateSafe(rsItem("NgayCT")) <> n Then
                ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET Cap={0} WHERE MaSo={1}", _
                                    DateDiff(DateInterval.Day, n, ConvertToDateSafe(rsItem("NgayCT"))), _
                                    ConvertToStrSafe(ms)))
                If rsItem("NgayCT") IsNot Nothing Then
                    n = ConvertToDateSafe(rsItem("NgayCT"))
                End If

                ms += 1
                ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Kq1,Kq2,Kq3,Kq4,Ngay1) VALUES ({0}, N'{1}',{2},{3},{4},{5}, N'{6}')", _
                                    ms, _
                                    ms, _
                                    IIf(ConvertToDblSafe(rsItem("loaips")) < 0, CStr(ConvertToDblSafe(rsItem("ps"))), "0"), _
                                    IIf(ConvertToDblSafe(rsItem("loaips")) > 0, CStr(ConvertToDblSafe(rsItem("ps"))), "0"), _
                                    CStr(sdn), _
                                    CStr(sdc), _
                                    Format(n, Mask_DB)))
            Else
                ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET {0},Kq3={1},Kq4={2} WHERE MaSo={3}", _
                                    IIf(rsItem("loaips") < 0, _
                                         String.Format("Kq1=Kq1+{0}", CStr(ConvertToDblSafe(rsItem("ps")))), _
                                         String.Format("Kq2=Kq2+{0}", CStr(ConvertToDblSafe(rsItem("ps"))))), _
                                    CStr(sdn), _
                                    CStr(sdc), _
                                    ConvertToStrSafe(ms)))
            End If
        Next
        n1 = IIf(tcuoi > 0, NgayCuoiThang(pNamTC, tcuoi), ncuoi)
        If n <> n1 Then
            ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET Cap={0} WHERE MaSo={1}", _
                                (n1 - n).TotalDays + 1, _
                                ms))
        Else
            ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET Cap=1 WHERE MaSo={0}", ms))
        End If
        ExecSQLNonQuery("UPDATE BaoCaoCP2 SET Kq5=Kq3*Cap")
        ExecSQLNonQuery("DELETE  FROM BaoCaoCP2 WHERE Kq3=0 AND Kq4=0")
        rptFrom.InitForm(String.Format("{0}\REPORTS\BKTS{1}.RPT", pCurDir, (IIf(mnt > 0, "2", String.Empty))), "SELECT * FROM BaoCaoCP2", "BaoCaoCP2")

        rptFrom.ReportWindowTitle = "Bảng kê tích số"
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi, nn)))))
        rptFrom.SetFormulas("TaiKhoan", String.Format("'{0} - {1}{2}'", taikhoan.sohieu, taikhoan.ten, (IIf(mnt > 0, String.Format(" - {0}", TenNT(mnt)), String.Empty))))
        rptFrom.SetFormulas("LS", ConvertToDblSafe(Format(lsv, Mask_2)))
        rptFrom.SetFormulas("LSG", ConvertToDblSafe(Format(lsg, Mask_2)))
        RptSetDate(n1)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="cap"></param>
    ''' <param name="ct"></param>
    ''' <remarks></remarks>
    Private Sub InCdt2(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef cap As Integer, ByRef ct As Integer)
        Dim st As String = String.Empty
        Dim sqlcx As New StringBuilder
        Dim sqlnx As New StringBuilder
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        GauGe.Maximum = 3
        SoDuTKCN2(ThangTruoc(tdau))
        SoDuTKCN2(tcuoi)
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            st = ConvertToStrSafe(i)
            sqln.Append(String.Format(" + HethongTk.No_{0}", st))
            sqlc.Append(String.Format(" + HethongTk.Co_{0}", st))
        Next
        For i As Integer = 1 To CThangDB2(tcuoi)
            st = ConvertToStrSafe(i)
            sqlnx.Append(String.Format(" + HethongTk.No_{0}", st))
            sqlcx.Append(String.Format(" + HethongTk.Co_{0}", st))
        Next
        st = ConvertToStrSafe(CThangDB2(tcuoi))
        GauGe.Value = 1
        Dim QCdt As String = String.Format("SELECT DISTINCT HeThongTK.SoHieu, HeThongTK.Cap, HeThongTK.Ten{0}, HeThongTK.Kieu, HeThongTK.Loai, HeThongTK.DuNo_0 As DkNo, HeThongTK.DuCo_0 As DkCo, {1} As PsNo, {2} As PsCo, {3} As PsNoX, {4} As PsCoX, HeThongTK.DuNo_{5} As CkNo, HeThongTK.DuCo_{5} As CkCo FROM HeThongTK  WHERE ((HeThongTK.MaTC = 0 Or HeThongTK.MaTC = HeThongTK.MaSo) Or (TK_ID3 % 10 >= 1)) And (HeThongTK.loai > 0) And cap <= {6}{7}", _
                           (IIf(pnn > 0, "E", String.Empty)), _
                           sqln, _
                           sqlc, _
                           sqlnx, _
                           sqlcx, _
                           st, _
                           cap, _
                           (IIf(ct = 0, String.Format(" AND (DuNo_{0}<>0 OR DuCo_{0}<>0 OR ({1})<>0 OR ({2})<>0)", _
                                            st, _
                                            sqln, _
                                            sqlc), String.Empty)))
        GauGe.Value = 2

        rptFrom.InitForm("CDT2.RPT", QCdt, "QCdt")
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        GauGe.Value = 3
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="saukc"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="cap"></param>
    ''' <param name="ct"></param>
    ''' <remarks></remarks>
    Private Sub XLQCDT(ByRef saukc As Boolean, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef cap As Integer, ByRef ct As Integer)
        Dim rs As DataTable
        Dim i As Integer
        Dim shtk, shpl, st As String
        Dim sqlcx As New StringBuilder
        Dim sqlnx As New StringBuilder
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        Dim co As Boolean
        Dim ncuoi As Date = NgayCuoiThang(pNamTC, tcuoi)
        CloseBook(String.Format("{0}\REPORTS\QTTNDN.xls", pCurDir))
        On Error GoTo KetThuc
        xlapp = New Excel.Application()
        On Error GoTo Loimofile
        xlapp.Workbooks.Open(String.Format("{0}\REPORTS\QTTNDN.XLS", pCurDir))
        GoTo Tieptuc
Loimofile:
        File.Copy(String.Format("{0}\REPORTS\QTTNDN.XLS", pCurDir), String.Format("{0}\TEMP\QTTNDN.XLS", pCurDir))
        xlapp.Workbooks.Open(String.Format("{0}\TEMP\QTTNDN.XLS", pCurDir))
Tieptuc:
        On Error GoTo 0
        Dim kt As DialogResult
        Dim TenSheet As String = String.Empty
        kt = MessageBox.Show(String.Format(Ngonngu("Bảng cân đối năm trước chọn ... Yes{0}Bảng cân đối năm nay chọn ....... No", "The balance of the previous year choose ... Yes{0}The balance of the cuurent choose .......... No"), Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        Select Case kt
            Case System.Windows.Forms.DialogResult.Yes
                TenSheet = "namtruoc"
            Case System.Windows.Forms.DialogResult.No
                TenSheet = "namnay"
            Case System.Windows.Forms.DialogResult.Cancel
                GoTo KetThuc
        End Select
        For i = 1 To xlapp.Worksheets.Count
            If xlapp.Worksheets(i).Name.ToUpper() = TenSheet.ToUpper() Then
                co = True : Exit For
            End If
        Next
        If co Then
            xlsheet = xlapp.Worksheets(i)
        Else
            MessageBox.Show(String.Format(Ngonngu("Không có sheet ten '{0}' !{1}Vui lòng kiểm tra lại file Excel !", "Sheet name '{0}' does not exist !{1}Please, you check again file excel!"), TenSheet, Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GoTo KetThuc
        End If
        SoDuTKCN2(ThangTruoc(tdau))
        SoDuTKCN2(tcuoi)
        For i = CThangDB2(tdau) To CThangDB2(tcuoi)
            st = ConvertToStrSafe(i)
            sqln.Append(String.Format(" + HethongTk.No_{0}", st))
            sqlc.Append(String.Format(" + HethongTk.Co_{0}", st))
        Next
        For i = 1 To CThangDB2(tcuoi)
            st = ConvertToStrSafe(i)
            sqlnx.Append(String.Format(" + HethongTk.No_{0}", st))
            sqlcx.Append(String.Format(" + HethongTk.Co_{0}", st))
        Next
        st = ConvertToStrSafe(CThangDB2(tcuoi))
        Dim QCdt As String = String.Format("SELECT DISTINCT HeThongTK.SoHieu, HeThongTK.Cap, HeThongTK.Ten{0}, HeThongTK.Kieu, HeThongTK.Loai, HeThongTK.DuNo_{1} As DkNo, HeThongTK.DuCo_{2} As DkCo, {3} As PsNo, {4} As PsCo, KC_N, KC_C, {5} As CkNo, {6} As CkCo FROM HeThongTK WHERE ((HeThongTK.MaTC = 0 Or HethongTK.MaTC = HethongTK.MaSo) OR (TK_ID3 % 10 >= 1)) And (HeThongTK.Loai > 0)  AND Cap<={7}{8} order by hethongtk.loai,hethongtk.sohieu", _
                                (IIf(pNN > 0, "E", String.Empty)), _
                                CThangDB2(ThangTruoc(tdau)), _
                                ConvertToStrSafe(CThangDB2(ThangTruoc(tdau))), _
                                sqln, _
                                sqlc, _
                                (IIf(saukc, String.Format("HeThongTK.DuNo_{0}", st), "HethongTk.DuNo")), _
                                (IIf(saukc, String.Format("HeThongTK.DuCo_{0}", st), "HethongTk.DuCo")), _
                                ConvertToStrSafe(cap), _
                                (IIf(ct = 0, String.Format(" AND (DuNo_{0}<>0 OR DuCo_{0}<>0 OR ({1})<>0 OR ({2})<>0)", _
                                                 st, _
                                                 sqln, _
                                                 sqlc), String.Empty)))
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        i = 1
        rs = ExecSQLReturnDT(QCdt)
        GauGe.Maximum = rs.Rows.Count
        HienThongBao(String.Format("Xuất Excel cân đối số phát sinh '{0}' ...", TenSheet), 1)
        For Each rsItem As DataRow In rs.Rows
            If xlsheet.Cells(i, 2) IsNot Nothing Or xlsheet.Cells(i + 1, 2) IsNot Nothing Or xlsheet.Cells(i + 2, 2) IsNot Nothing Or xlsheet.Cells(i + 3, 2) IsNot Nothing Or xlsheet.Cells(i + 4, 2) IsNot Nothing Then
                Exit For
            End If
            For j As Integer = 2 To 9
                xlsheet.Cells(i, j) = String.Empty
                Select Case j
                    Case 2
                        If rsItem("cap") IsNot Nothing Then
                            If ConvertToDblSafe(rsItem("cap")) > 0 Then
                                xlsheet.Cells(i, j) = String.Format("'{0}{1}", ConvertToStrSafe(rsItem("cap")), ConvertToStrSafe(rsItem("SoHieu")))
                            End If
                        End If

                    Case 3
                        If rsItem("cap") IsNot Nothing Then
                            If ConvertToDblSafe(rsItem("cap")) > 0 Then
                                xlsheet.Cells(i, j) = String.Format("'{0}{1}", ConvertToDblSafe(rsItem("cap")), rsItem("ten"))
                            End If
                        End If

                    Case 4
                        If rsItem("SoHieu") IsNot Nothing Then
                            If Strings.Left(rsItem("SoHieu"), 3) = "131" Or Strings.Left(rsItem("SoHieu"), 3) = "331" Or Strings.Left(rsItem("SoHieu"), 3) = "138" Or Strings.Left(rsItem("SoHieu"), 3) = "338" Then
                                If rsItem("dkno") IsNot Nothing Then
                                    xlsheet.Cells(i, j) = rsItem("dkno")
                                End If

                            Else
                                If ConvertToDblSafe(rsItem("cap")) > 0 And rsItem("dkno") > rsItem("dkco") Then
                                    xlsheet.Cells(i, j) = ConvertToStrSafe(ConvertToDblSafe(rsItem("dkno")) - ConvertToDblSafe(rsItem("dkco")))
                                End If
                            End If
                        End If

                    Case 5

                        If Strings.Left(rsItem("SoHieu"), 3) = "131" Or Strings.Left(rsItem("SoHieu"), 3) = "331" Or Strings.Left(rsItem("SoHieu"), 3) = "138" Or Strings.Left(rsItem("SoHieu"), 3) = "338" Then
                            xlsheet.Cells(i, j) = rsItem("dkco")
                        Else
                            If rsItem("dkco") IsNot Nothing And rsItem("dkno") IsNot Nothing Then
                                If ConvertToDblSafe(rsItem("cap")) > 0 And rsItem("dkco") > rsItem("dkno") Then xlsheet.Cells(i, j) = ConvertToStrSafe(rsItem("dkco") - rsItem("dkno"))
                            End If

                        End If


                    Case 6
                        If rsItem("cap") IsNot Nothing And rsItem("psno") IsNot Nothing Then
                            If ConvertToDblSafe(rsItem("cap")) > 0 Then xlsheet.Cells(i, j) = ConvertToStrSafe(rsItem("psno"))
                        End If

                    Case 7
                        If rsItem("cap") IsNot Nothing And rsItem("psco") IsNot Nothing Then
                            If ConvertToDblSafe(rsItem("cap")) > 0 Then xlsheet.Cells(i, j) = ConvertToStrSafe(rsItem("psco"))
                        End If

                    Case 8
                        If rsItem("SoHieu") = "131" Or rsItem("SoHieu") = "331" Or rsItem("SoHieu") = "138" Or rsItem("SoHieu") = "338" Then
                            xlsheet.Cells(i, j) = ConvertToStrSafe(rsItem("ckno"))
                        Else
                            If rsItem("ckco") IsNot Nothing And rsItem("ckno") IsNot Nothing Then
                                If ConvertToDblSafe(rsItem("cap")) > 0 And rsItem("ckno") > rsItem("ckco") Then
                                    xlsheet.Cells(i, j) = ConvertToStrSafe(ConvertToDblSafe(rsItem("ckno")) - ConvertToDblSafe(rsItem("ckco")))
                                End If
                            End If

                        End If
                    Case 9
                        If rsItem("SoHieu") = "131" Or rsItem("SoHieu") = "331" Or rsItem("SoHieu") = "138" Or rsItem("SoHieu") = "338" Then
                            xlsheet.Cells(i, j) = ConvertToStrSafe(rsItem("ckco"))
                        Else
                            If rsItem("ckco") IsNot Nothing And rsItem("ckno") IsNot Nothing Then
                                If ConvertToDblSafe(rsItem("cap")) > 0 And rsItem("ckco") > rsItem("ckno") Then
                                    xlsheet.Cells(i, j) = ConvertToStrSafe(ConvertToDblSafe(rsItem("ckco")) - ConvertToDblSafe(rsItem("ckno")))
                                End If
                            End If


                        End If
                End Select
            Next
            i += 1
            GauGe.Value = i - 1
        Next
        Dim xlsheet1 As Excel.Worksheet
        Dim cuoikytruoc, daukynay As Double
        'Tìm tên sheet cần so sánh đầu kỳ năm nay và cuối kỳ năm trước
        If TenSheet = "namnay" Then
            daukynay = ConvertToDblSafe((xlsheet.Cells(1, 4)).Value) - ConvertToDblSafe((xlsheet.Cells(1, 5)).Value)
            TenSheet = "namtruoc"
        Else
            cuoikytruoc = ConvertToDblSafe((xlsheet.Cells(1, 8)).Value) - ConvertToDblSafe((xlsheet.Cells(1, 9)).Value)
            TenSheet = "namnay"
        End If
        If daukynay <> 0 Or cuoikytruoc <> 0 Then
            co = False
            For i = 1 To xlapp.Worksheets.Count
                If xlapp.Worksheets(i).Name.ToUpper() = TenSheet.ToUpper() Then
                    co = True
                    Exit For
                End If
            Next
            If co Then
                xlsheet1 = xlapp.Worksheets(i)
                If daukynay <> 0 Then
                    cuoikytruoc = xlsheet1.Cells(1, 8) - xlsheet1.Cells(1, 9)
                Else
                    daukynay = xlsheet1.Cells(1, 4) - xlsheet1.Cells(1, 5)
                End If
                If daukynay <> 0 And cuoikytruoc <> 0 And daukynay <> cuoikytruoc Then
                    MessageBox.Show(Ngonngu("Số đầu kỳ năm nay của tài khoản 111 khác cuối kỳ năm trước? ", "Beginning of year 111 account unlike last years ago?"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    HienThongBao(String.Format(Ngonngu("Xóa cân đối số phát sinh '{0}' ...", "Delete incurred balance '{0}' ..."), TenSheet), 1)
                    xlsheet1.Range("1:1", "300:1").EntireRow.Delete()
                End If
            Else
                MessageBox.Show(String.Format(Ngonngu("Không có sheet ten '{0}' !{1}Vui lòng kiểm tra lại file Excel !", "Sheet name '{0}' does not exist !{1}Please, you check again file excel!"), TenSheet, Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        xlapp.Workbooks.Open(String.Format("{0}\temp\QTTNDN.XLS", pCurDir))
        xlsheet = xlapp.Worksheets(1)
        GauGe.Value = 0
        On Error GoTo 0
        xlsheet.Cells(5, 1) = String.Format("[1] Kỳ tính Thuế: {0}", ThoiGianTheoThang(tdau, tcuoi))
        xlsheet.Cells(7, 1) = String.Format("[2] Mã số thuế: {0}", frmMain._LbCty_8.Text)
        xlsheet.Cells(8, 1) = String.Format("[3] Tên cơ sở kinh doanh: {0}", pTenCty)
        xlsheet.Cells(9, 1) = String.Format("[4] Địa chỉ: trụ sở: {0}", frmMain._LbCty_2.Text)
        xlsheet.Cells(10, 1) = String.Format("[5] Quận, huyện: {0}                 {1}{2}", frmMain._LbCty_10.Text, ("Tỉnh, thành phố: "), frmMain._LbCty_11.Text)
        xlsheet.Cells(11, 1) = String.Format("[7] Điện thoại: {0}                 Fax: {1}                 Email: {2}", frmMain._LbCty_3.Text, frmMain._LbCty_4.Text, frmMain._LbCty_9.Text)
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\QTTNDN.XLS")
        Exit Sub
KetThuc:
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mtk"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="cap"></param>
    ''' <remarks></remarks>
    Private Sub T(ByRef mtk As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef cap As Integer)
        Dim psn, dn, DC, psc As Double

        Dim tpsn, tpsc As Double
        Dim sh As String = String.Empty
        Dim shtk As String = MaSo2SoHieu(mtk, "HethongTK")
        ExecSQLNonQuery("DELETE  FROM BKNhomPS")
        If tdau > 0 Then
            SoDuTK(mtk, tdau - 1, dn, DC)
            tpsn = SoPSTK(shtk, tdau, tcuoi, -1)
            tpsc = SoPSTK(shtk, tdau, tcuoi, 1)
        Else
            SoDuTKNgay(mtk, ndau.AddDays(-1), dn, DC)
            SoPSTKN(shtk, ndau, ncuoi, tpsn, tpsc)
        End If
        ExecSQLNonQuery(String.Format("INSERT INTO BKNhomPS (MaCT,SoHieu,SoPSNo, SoPSCo) VALUES (0,'Dư đầu',{1},{2})", _
                            Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
                            dn, _
                            DC))
        dn -= DC
        Dim sqlw As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT TK.Sohieu,SUM(SoPS) AS PS FROM (ChungTu INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) INNER JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo WHERE HethongTK.Sohieu LIKE '{0}%' AND {1} AND (ChungTu.MaLoai<>4 OR MaTKNo<>MaTKCo) GROUP BY TK.Sohieu", _
                                                  shtk, _
                                                  sqlw))
        For Each rsItem As DataRow In rs.Rows
            For i As Integer = 1 To cap
                If rsItem("SoHieu") IsNot Nothing Then
                    sh = LaySHTKCapTren(ConvertToStrSafe(rsItem("SoHieu")), i)
                End If

                Dim rowEffectCount As Integer = ExecSQLNonQueryUpdateInsertDeleteQuery(String.Format("UPDATE BKNhomPS SET SoPSNo=SoPSNo+{0} WHERE MaCT=1 AND Sohieu=N'{1}{2}'", _
                                                                    CStr(ConvertToDblSafe(rsItem("ps"))), _
                                                                    Space(2 * (i - 1)), _
                                                                    sh))
                If rowEffectCount = 0 Then
                    ExecSQLNonQuery(String.Format("INSERT INTO BKNhomPS (MaCT,Sohieu,SoPSNo) VALUES (1, N'{1}{2}',{3})", _
                                        Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
                                        Space(2 * (i - 1)), _
                                        sh, _
                                        rsItem("ps")))
                End If
            Next
            If rsItem("ps") IsNot Nothing Then
                psn += ConvertToDblSafe(rsItem("ps"))
            End If

        Next
        If tpsn > psn Then
            ExecSQLNonQuery(String.Format("INSERT INTO BKNhomPS (MaCT,Sohieu,SoPSNo) VALUES (1,'xxx',{1})", _
                                Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
                                tpsn - psn))
        End If
        rs = ExecSQLReturnDT(String.Format("SELECT HethongTK.Sohieu,SUM(SoPS) AS PS FROM (ChungTu INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) INNER JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo WHERE TK.Sohieu LIKE '{0}%' AND {1} AND (ChungTu.MaLoai<>4 OR MaTKNo<>MaTKCo) GROUP BY HethongTK.Sohieu", _
                                 shtk, _
                                 sqlw))
        For Each rsItem As DataRow In rs.Rows
            For i As Integer = 1 To cap
                If rsItem("SoHieu") IsNot Nothing Then
                    sh = LaySHTKCapTren(ConvertToStrSafe(rsItem("SoHieu")), i)
                End If

                Dim rowEffectCount As Integer = ExecSQLNonQuery(String.Format("UPDATE BKNhomPS SET SHTK=SoHieu,SoPSCo=SoPSCo+{0} WHERE Sohieu=N'{1}{2}'", _
                                                                    rsItem("ps"), _
                                                                    Space(2 * (i - 1)), _
                                                                    sh))
                If rowEffectCount = 0 Then
                    ExecSQLNonQuery(String.Format("INSERT INTO BKNhomPS (MaCT,SoHieu,SHTK,SoPSCo) VALUES (1, N'{1}{2}', N'{1}{2}',{3})", _
                                        Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
                                        Space(2 * (i - 1)), _
                                        sh, _
                                        rsItem("ps")))
                End If
            Next
            If rsItem("ps") IsNot Nothing Then
                psc += ConvertToDblSafe(rsItem("ps"))
            End If

        Next
        If tpsc > psc Then
            ExecSQLNonQuery(String.Format("INSERT INTO BKNhomPS (MaCT,Sohieu,SoPSNo) VALUES (1,'xxx',{1})", _
                                Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
                                tpsc - psc))
        End If
        ExecSQLNonQuery(String.Format("INSERT INTO BKNhomPS (MaCT,SoHieu,SoPSNo, SoPSCo) VALUES (2,'Cộng PS',{1},{2})", _
                            Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
                            tpsn, _
                            tpsc))
        dn = dn + tpsn - tpsc
        ExecSQLNonQuery(String.Format("INSERT INTO BKNhomPS (MaCT,SoHieu,SoPSNo, SoPSCo) VALUES (3,'Dư cuối',{1},{2})", _
                            Lng_MaxValue("MaSo", "BKNhomPS") + 1, _
                            Math.Max(dn, 0), _
                            IIf(dn < 0, -dn, 0)))

        rptFrom.InitForm("T.RPT", "SELECT * FROM BKNhomPS", "BKNhomPS")

        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi, nn)))))
        rptFrom.SetFormulas("TK", String.Format("'TK: {0}'", shtk))
    End Sub
End Class
