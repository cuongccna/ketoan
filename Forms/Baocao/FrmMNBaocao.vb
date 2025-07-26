Imports System
Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Drawing
Imports System.Diagnostics
Imports UNET.Utility
Imports System.Globalization
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter
Imports Excel = Microsoft.Office.Interop.Excel
Imports ComboBoxEx


Partial Friend Class FrmMNBaocao
    Private isInitializingComponent As Boolean
    Const w1 As Integer = 100
    'Dim StopPrint As Boolean ' = True nếu ngừng in các danh sách báo cáo
    Dim loai, baocao As Integer
    Dim vatr As String = String.Empty
    Dim Ngay(1) As Date
    Dim xlapp As Excel.Application
    Dim xlsheet As Excel.Worksheet
    Dim KTT, NLB, GD As String
    Dim nn, Pdelay As Integer
    Dim TenFile, TenBaoCao As String
    Dim DNTen, DNDiachi As String
    Dim SoLieu(11) As Boolean
    Private _taikhoan As ClsTaikhoan = Nothing
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


    ' FrmMNBaocao_Load

    Private chiso1 As Integer = -1
    Private chiso0 As Integer = -1
    Private Sub FrmMNBaocao_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            'Frame10(0).Visible = True

            'Frame10(0).Location = New Point(96, 8)
            'Frame10(1).Location = New Point(96, 8)
            'Frame10(2).Location = New Point(96, 8)
            'Frame10(3).Location = New Point(96, 8)
            'Frame10(4).Location = New Point(96, 8)

            'Frame10(1).Visible = False
            'Frame10(2).Visible = False
            'Frame10(3).Visible = False
            'Frame10(4).Visible = False

            AddMonthToCbo(CboThang(0))
            AddMonthToCbo(CboThang(1))

            If cboQuy.Items.Count > 0 Then
                cboQuy.SelectedIndex = 0
            End If

            InitDateVars(MedNgay(0), Ngay(0))
            InitDateVars(MedNgay(1), Ngay(1))
            Int_RecsetToCbo("SELECT MaSo As F2,SoHieu+ ' - '+DienGiai As F1 FROM CTGhiSo ORDER BY SoHieu", CTGS)
            Int_RecsetToCbo("SELECT MaSo As F2,TenKho As F1 FROM KhoHang ORDER BY TenKho", CboKho(1))
            Int_RecsetToCbo("SELECT MaSo As F2,SoHieu + ' - ' + DienGiai As F1 FROM NguonNhapXuat ORDER BY SoHieu", CboKho(2))
            Int_RecsetToCbo("SELECT DoituongCT.MaSo As F2,( CASE WHEN (DoituongCT.MaKhachHang>0) THEN KhachHang.Ten+' - '+DoituongCT.Sohieu+' - ' ELSE '' END +DienGiai+ CASE WHEN (DoituongCT.MaKhachHang>0) THEN ' - '+ convert(NVARCHAR(10),NgayKy,103) ELSE '' END ) As F1 FROM DoituongCT LEFT JOIN KhachHang ON DoituongCT.MaKhachHang=KhachHang.MaSo ORDER BY  KhachHang.Ten,DoituongCT.SoHieu,DienGiai", CboVV)
            Int_RecsetToCbo("SELECT MaSo As F2,TenKho As F1 FROM KhoHang ORDER BY TenKho", CboKho(0))
            Int_RecsetToCbo("SELECT MaSo As F2,SoHieu + ' - ' + DienGiai As F1 FROM NguonNhapXuat ORDER BY SoHieu", CboLoai(1))
            Int_RecsetToCbo("SELECT PhanLoaiVattu.MaSo As F2, (PhanLoaiVattu.SoHieu + ' - '+ PhanLoaiVattu.TenPhanLoai) As F1 FROM PhanLoaiVattu ORDER BY PhanLoaiVattu.SoHieu", CboLoai(0))
            nn = 0
            If IniPath <> "" Then
                Pdelay = ConvertToDblSafe(Interaction.GetSetting(IniPath, "Environment", "PrinterDelay", ConvertToStrSafe(10)))
            Else
                Pdelay = 0
            End If


            InitCap(CboCap, 1, 6, 5)
            'InitCap(CboCap2, 1, 6, 5)
            InitCap(cboQuy, 1, 4, )
            InitVAT(CboTL)
            InitThuChi()

            For chi_so As Integer = 1 To 12
                SoLieu(chi_so - 1) = False
            Next
            If CboTL.Items.Count > 0 Then
                CboTL.SelectedIndex = 1
            End If
            If CboThuchi.Items.Count > 0 Then
                CboThuchi.SelectedIndex = 0
            End If

            Cmd1_ClickEvent(Cmd1(0), New EventArgs())
            Cmd1(3).Enabled = (ConvertToDblSafe(GetSelectValue("SELECT Flag1 as f1 FROM license")) Mod 10000000) \ 1000000 = 1
            Cmd1(4).Enabled = (ConvertToDblSafe(GetSelectValue("SELECT Flag1 as f1 FROM license")) Mod 10000000) \ 1000000 = 1

            If chiso0 <> -1 And _CboThang_0.Items.Count > 0 Then
                _CboThang_0.SelectedIndex = chiso0
            End If
            If chiso1 <> -1 And _CboThang_1.Items.Count > 0 Then
                _CboThang_1.SelectedIndex = chiso1
            End If
            If (pNN = 1 And Not Me.Text Like "Reporting and accounting") Or pNN = 0 Then SetFont(Me)

            TabControl1.SelectedIndex = 0
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitThuChi()
        CboThuchi.Items.Clear()
        CboThuchi.Items.ItemsBase.Clear()
        CboThuchi.Items.Add(New ComboBoxItem(Ngonngu("TB", "All"), 0))
        CboThuchi.Items.Add(New ComboBoxItem(Ngonngu("Tiền mặt", "Cash"), 111))
        CboThuchi.Items.Add(New ComboBoxItem(Ngonngu("Tiền gửi ngân hàng", "Cash in bank"), 112))
        If CboThuchi.Items.Count > 0 Then CboThuchi.SelectedIndex = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property taikhoan() As ClsTaikhoan
        Get
            If _taikhoan Is Nothing Then
                _taikhoan = New ClsTaikhoan()
            End If
            Return _taikhoan
        End Get
        Set(ByVal Value As ClsTaikhoan)
            _taikhoan = Value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboTL_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboTL.SelectedIndexChanged
        OptTG(0).Checked = True
        If CboTL.SelectedIndex = CboTL.Items.Count - 1 And OptVAT(2).Checked Then
            OptTG(1).Enabled = True
        ElseIf OptVAT(2).Checked Then
            OptTG(1).Enabled = False
        End If
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
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Cmd1_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Cmd1_0.Click, _Cmd1_1.Click, _Cmd1_2.Click, _Cmd1_3.Click, _Cmd1_4.Click
        'Dim Index As Integer = Array.IndexOf(Cmd1, eventSender)
        'loai = Index
        'OptTG(0).Enabled = True
        'OptTG(1).Enabled = True
        'Label(0).Enabled = True
        'Label(1).Enabled = True
        'CboThang(0).Enabled = True
        'CboThang(1).Enabled = True
        'Select Case Index
        '    Case 0
        '        Frame10(0).Visible = True
        '        Frame10(1).Visible = False
        '        Frame10(2).Visible = False
        '        Frame10(3).Visible = False
        '        Frame10(4).Visible = False
        '        OptVAT(0).Checked = True
        '        OptVAT_CheckedChanged(OptVAT(0), New EventArgs())
        '        OptTG(0).Checked = True
        '        OptTG(1).Enabled = False
        '    Case 1
        '        Frame10(0).Visible = False
        '        Frame10(1).Visible = True
        '        Frame10(2).Visible = False
        '        Frame10(3).Visible = False
        '        Frame10(4).Visible = False
        '        OptQT(2).Checked = True
        '        OptQT_CheckedChanged(OptQT(2), New EventArgs())
        '        OptTG(0).Checked = True
        '        OptTG(1).Enabled = False
        '    Case 2
        '        Frame10(0).Visible = False
        '        Frame10(1).Visible = False
        '        Frame10(2).Visible = True
        '        Frame10(3).Visible = False
        '        Frame10(4).Visible = False
        '        OptSo(0).Checked = True
        '        OptSo_CheckedChanged(OptSo(0), New EventArgs())
        '        OptTG(0).Checked = True
        '    Case 3
        '        Frame10(0).Visible = False
        '        Frame10(1).Visible = False
        '        Frame10(2).Visible = False
        '        Frame10(3).Visible = True
        '        Frame10(4).Visible = False
        '        OptBCQT(0).Checked = True
        '        OptBCQT_CheckedChanged(OptBCQT(0), New EventArgs())
        '        OptTG(0).Checked = True
        '    Case 4
        '        Frame10(0).Visible = False
        '        Frame10(1).Visible = False
        '        Frame10(2).Visible = False
        '        Frame10(3).Visible = False
        '        Frame10(4).Visible = True
        '        OptCDT(0).Checked = True
        '        OptCDT_CheckedChanged(OptCDT(0), New EventArgs())
        '        OptTG(0).Checked = True
        'End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdkh_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _cmdkh_0.Click, _cmdkh_2.Click
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
    Private Sub cmdtk_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _cmdtk_8.Click, _cmdtk_10.Click, _cmdtk_1.Click, _cmdtk_0.Click, _cmdtk_4.Click, _cmdtk_2.Click, _cmdtk_3.Click, _cmdtk_9.Click, _cmdtk_5.Click, _cmdtk_7.Click, _cmdtk_11.Click, _cmdtk_15.Click, _cmdtk_14.Click
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
    Private Sub Cmdvt_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Cmdvt_2.Click, _Cmdvt_0.Click, _Cmdvt_1.Click
        Dim Index As Integer = Array.IndexOf(Cmdvt, eventSender)
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
    Private Sub FrmMNBaocao_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.X
                    Command(0).Focus()
                Case Keys.I
                    Command(1).Focus()
                Case Keys.V
                    Command(2).Focus()
                Case Keys.E
                    If Command(3).Enabled Then
                        Command(3).Focus()
                    End If
                Case Keys.S
                    Command(4).Focus()
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
        If eventArgs.KeyCode = Keys.Escape Then Me.Hide()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmMNBaocao_DoubleClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.DoubleClick
        FThuChi.Tag = ConvertToStrSafe(10)
        FThuChi.GetPhieu(NLB, KTT, GD, 0)
        Interaction.SaveSetting(IniPath, "Environment", "SReport1", NLB)
        Interaction.SaveSetting(IniPath, "Environment", "SReport2", KTT)
        Interaction.SaveSetting(IniPath, "Environment", "SReport3", GD)
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click, _Command_4.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim mloai As Integer
        Dim doiung As New ClsTaikhoan
        Dim k As Integer
        Dim mkho As Integer
        Dim rs_tk As DataTable
        If CboThang(1).Items.Count > 0 And CboThang(0).Items.Count > 0 Then
            If CboThang(0).Enabled And CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
        End If

        Dim tdau As Integer = CboThang(0).SelectedValue
        Dim tcuoi As Integer = CboThang(1).SelectedValue
        Dim kq1 As Boolean
        Dim a = String.Empty, tg = String.Empty, ten As String = String.Empty
        Dim numberloop, thutudong As Integer
        Dim lan As Boolean
        Cursor = Cursors.WaitCursor

        Select Case Index
            Case 0, 1
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

                Select Case loai
                    Case 0
                        rptFrom.ReportWindowTitle = OptVAT(baocao).Text
                        If ChkDu(15).CheckState = CheckState.Checked And Strings.Len(txtShTk(15).Text) > 0 Then
                            taikhoan.InitTaikhoanSohieu(txtShTk(15).Text)
                        Else
                            taikhoan.InitTaikhoanMaSo(0)
                        End If
                        Select Case baocao
                            Case 0
                                TaoBC(tdau, tcuoi, 1)
                                GoTo LoiBC
                            Case 1
                                tdau = (ConvertToDblSafe(cboQuy.Text) - 1) * 3 + 1 + pThangDauKy - 1
                                tcuoi = ConvertToDblSafe(cboQuy.Text) * 3 + pThangDauKy - 1
                                If tdau > 12 Then tdau = tdau - 12
                                If tcuoi > 12 Then tcuoi = tcuoi - 12
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
                                    If Chk(1).CheckState = CheckState.Unchecked Then
                                        If Not InVATDauRa(IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), CboTL.SelectedValue, taikhoan, Ngay(0), Ngay(1)) Then GoTo LoiBC
                                    Else
                                        InVATDauRaMV(tcuoi, ConvertToDblSafe((CboTL.SelectedValue)), taikhoan)
                                        GoTo LoiBC
                                    End If
                                End If
                            Case 3
                                If ChkDu(16).CheckState = CheckState.Checked Then
                                    FrmBangke.ShowDialog()
                                    GoTo LoiBC
                                Else
                                    If Chk(1).CheckState = CheckState.Unchecked Then
                                        If Not InVATDauVao2(tdau, tcuoi, CboTL.SelectedValue, 1, taikhoan) Then GoTo LoiBC
                                    Else
                                        InVATDauVaoMV(tcuoi, CboTL.SelectedValue, 1, taikhoan)
                                        GoTo LoiBC
                                    End If
                                End If
                            Case 4
                                If Not InVATDienNuoc(tdau, tcuoi, -1, 0, taikhoan) Then GoTo LoiBC
                            Case 5
                                If Not InVATDauVao2(tdau, tcuoi, -1, 0, taikhoan) Then GoTo LoiBC
                            Case 6
                                If Chk(1).CheckState = CheckState.Unchecked Then
                                    ToKhaiVAT(tdau, tcuoi, taikhoan)
                                Else
                                    ToKhaiVAT2(tcuoi, taikhoan)
                                    GoTo LoiBC
                                End If
                            Case 7 : InThueTTDB(tdau, tcuoi, CboTL.SelectedValue, taikhoan)
                            Case 8 : BangKeBanRa(tdau, tcuoi, taikhoan)
                            Case 10, 11 : InBKTheoTK(IIf(baocao = 10, -1, 1), tdau, tcuoi, txtShTk(11).Text, IIf(Chk(7).CheckState = CheckState.Checked, txtShTk(7).Text, String.Empty))
                            Case 12 : InThue(tdau, tcuoi)
                            Case 13 : InVAT(tdau, tcuoi)
                            Case 14 : QTDauVao(tdau, tcuoi)
                            Case 15 : QTDauRa()
                            Case 16 : GTGTCT()
                            Case 17 : InThuemonbai() : GoTo LoiBC
                            Case 18
                                If ChkDu(14).CheckState = CheckState.Checked And Strings.Len(txtShTk(14).Text) > 0 Then
                                    taikhoan.InitTaikhoanSohieu(txtShTk(14).Text)
                                Else
                                    taikhoan.InitTaikhoanMaSo(0)
                                End If
                                ToKhaiTTDB(tdau, tcuoi, taikhoan)
                            Case 19
                                FrmBbbg.ShowDialog() : GoTo LoiBC
                            Case 20
                                FrmXulykiemtra.ShowDialog() : GoTo LoiBC
                        End Select
                    Case 1
                        rptFrom.ReportWindowTitle = OptQT(baocao).Text
                        Select Case baocao
                            Case 1 : InQTTTN(tdau, tcuoi)
                            Case 2
                                FrmQTTNDN.ShowDialog()
                                GoTo LoiBC
                            Case 23
                                If CboKho(1).SelectedIndex < 0 Or CboKho(2).SelectedIndex < 0 Then Exit Sub
                                If OptDT(2).Checked Then
                                    InTHDoanhThuVAT(IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1))
                                Else
                                    InTHDoanhThu(IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1), IIf(OptDT(0).Checked, 0, 1), IIf(ChkDu(9).CheckState = CheckState.Checked, CboKho(1).SelectedValue, 0), IIf(ChkDu(18).CheckState = CheckState.Checked, txtshkh(2).Text, String.Empty), IIf(ChkDu(17).CheckState = CheckState.Checked, ConvertToDblSafe(txtsh(0).Tag), 0), IIf(ChkDu(19).CheckState = CheckState.Checked, CboKho(2).SelectedValue, 0), IIf(ChkDu(12).CheckState = CheckState.Checked, txtShTk(9).Text, String.Empty))
                                End If
                            Case 7
                                THDoanhThuGiaVon(GauGe, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1), IIf(ChkDu(9).CheckState = CheckState.Checked, CboKho(1).SelectedValue, 0), IIf(ChkDu(12).CheckState = CheckState.Checked, txtShTk(9).Text, String.Empty), ChkDu(13).CheckState)
                            Case 11
                                If Strings.Len(txtShTk(5).Text) = 0 Then
                                    txtShTk(5).Focus()
                                    GoTo LoiBC
                                End If
                                If Not InTongHopPhi(txtShTk(5).Text, tdau, tcuoi) Then GoTo LoiBC
                            Case 12 : If Not InTongHopHD(tdau, tcuoi) Then GoTo LoiBC
                            Case 14 : InCTKQKD(pThangDauKy, ThangCuoiNamTC())
                            Case 0 : InTKTCN()
                            Case 3 : InBCTCN()
                            Case 4 : TKQTTNCN()
                            Case 5 : BK05A()
                            Case 6 : BK05B()
                            Case 19
                                If ChkDu(16).CheckState Then
                                    tdau = CboThang(0).SelectedIndex
                                    tcuoi = CboThang(1).SelectedIndex
                                    FrmCandoi.Candoiluoi(tdau, tcuoi, CboCap.SelectedValue)
                                    GoTo LoiBC
                                Else
                                    InCdt(GauGe, True, tdau, tcuoi, CboCap.SelectedValue + 1, Chk1.CheckState)
                                End If
                            Case 20 : InTK(CboCap.SelectedValue + 1, tdau, tcuoi, Chk1.CheckState)
                            Case 21 : InQTThue(tdau, tcuoi)
                            Case 16 : InKqkd(tdau, tcuoi, nn)
                            Case 8 : InPLKQKD(tdau, tcuoi)
                            Case 15
                                rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))
                                InCdts(tdau, tcuoi, 0, nn)
                            Case 22 : BKNopThue(tdau, tcuoi)
                            Case 17
                                InLCTT2(tdau, tcuoi)
                            Case 18
                                InBCTC(tdau, tcuoi) : GoTo LoiBC
                        End Select
                    Case 2
                        rptFrom.ReportWindowTitle = OptSo(baocao).Text
                        Select Case baocao
                            Case 0
                                If Not InNhatKy(tdau, tcuoi, IIf(ChkDu(1).CheckState, CboVV.SelectedValue, 0), IIf(OptTG(1).Checked, 1, 0), Ngay(0), Ngay(1), nn) Then GoTo LoiBC
                            Case 1
                                InBCTT(GauGe, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1), ConvertToStrSafe(CboThuchi.SelectedValue))
                            Case 2
                                InBCCT(GauGe, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1), ConvertToStrSafe(CboThuchi.SelectedValue))
                            Case 3
                                InBCMH(GauGe, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1))
                            Case 4
                                InBCBH(GauGe, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1))
                            Case 5, 7, 9, 11, 19
                                If baocao = 5 And ChkDu(10).CheckState Then
                                    If Index = 0 Then
                                        ErrMsg(er_KoXem)
                                        GoTo LoiBC
                                    End If
                                    rs_tk = ExecSQLReturnDT("SELECT MaSo, SoHieu, Ten FROM HethongTK WHERE MaTC = MaSo AND Loai > 0 ORDER BY SoHieu")
                                    GauGe.Maximum = 200
                                    numberloop = 1
                                    thutudong = MessageBox.Show(Ngonngu("Có in thứ tự dòng theo nhật ký không?", "Printed in the log line?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                    For Each rs_tkItem As DataRow In rs_tk.Rows
                                        taikhoan.InitTaikhoanMaSo(ConvertToStrSafe(rs_tkItem("MaSo")))
                                        SetRptInfo()

                                        Dim soHieu As String = ConvertToStrSafe(rs_tkItem("SoHieu"))
                                        a = Strings.Mid(soHieu, 4)
                                        If (a = "" Or (Strings.Left(soHieu, 3) = "333" And Strings.Mid(soHieu, 5) = "")) Then
                                            If (pSoKT Mod 10 >= 1) Or (pSoKT Mod 1000 >= 100) Then
                                                lan = True
                                                kq1 = InSocaiTk(taikhoan, tdau, tcuoi, Ngay(0), Ngay(1), False, "", 0, ChkDu(3).CheckState, nn, 0, 0, 0, thutudong, lan)
                                            Else
                                                kq1 = InSocaiTk2(taikhoan, tdau, tcuoi, False, "", 0, nn)
                                            End If
                                            If kq1 Then
                                                HienThongBao(String.Format("{0} - {1}", soHieu, ConvertToStrSafe(rs_tkItem("ten"))), 1)
                                                rptFrom.ReportDestination = Index
                                                InBaoCaoRPT()
                                                AppIdle(Pdelay * 100)
                                            End If
                                        End If
                                        If GauGe.Value < GauGe.Maximum Then GauGe.Value += 1
                                    Next
                                    lan = False
                                    rs_tk = Nothing
                                    GoTo LoiBC
                                Else
                                    If ConvertToDblSafe((txtShTk(0).Tag)) = 0 Then
                                        txtShTk(0).Focus()
                                        ErrMsg(er_SHTaiKhoan)
                                        GoTo LoiBC
                                    End If
                                    taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(0).Tag))
                                    If ChkDu(0).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(1).Tag)) = 0 Then
                                        txtShTk(1).Focus()
                                        ErrMsg(er_SHTaiKhoan)
                                        GoTo LoiBC
                                    End If
                                    If ChkDu(0).CheckState = CheckState.Checked Then
                                        doiung.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(1).Tag))
                                    Else
                                        doiung.InitTaikhoanMaSo(0)
                                    End If
                                    If ChkDu(16).CheckState And baocao = 5 Then
                                        FrmSochitiet.Hienthi(Me)
                                        GoTo LoiBC
                                    Else
                                        If baocao <> 19 And (taikhoan.MaTC = taikhoan.maso Or taikhoan.MaTC = 0) And Not ((taikhoan.sohieu Like "112*") And OptTG(1).Checked) Then
                                            If baocao = 11 Then
                                                If Not InSocaiTkDU(taikhoan, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1), True, doiung.sohieu, 0, ChkDu(3).CheckState, nn) Then GoTo LoiBC
                                            Else
                                                If Not InSocaiTk(taikhoan, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1), True, doiung.sohieu, 0, ChkDu(3).CheckState, nn) Then GoTo LoiBC
                                            End If
                                        ElseIf baocao = 19 And (taikhoan.sohieu Like "311*" Or taikhoan.sohieu Like "315*" Or taikhoan.sohieu Like "341*") Then
                                            If Not InSoChitiet(taikhoan, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, 0, 0), Ngay(0), Ngay(1), True, doiung.sohieu, 0, ChkDu(3).CheckState, nn) Then GoTo LoiBC
                                        Else
                                            If Not InSoChitiet(taikhoan, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1), True, doiung.sohieu, 0, ChkDu(3).CheckState, nn) Then GoTo LoiBC
                                        End If
                                    End If
                                End If
                            Case 6
                                If ConvertToDblSafe((txtshkh(0).Tag)) = 0 Then
                                    ErrMsg(er_SHKhachHang)
                                    txtshkh(0).Focus()
                                    GoTo LoiBC
                                End If
                                If ChkDu(16).CheckState Then
                                    FrmSochitietKh.Hienthi(tdau, tcuoi, ConvertToStrSafe(txtshkh(0).Tag))
                                    GoTo LoiBC
                                Else
                                    taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaTaiKhoan AS F1 FROM SoDuKhachHang WHERE MaKhachHang={0}", ConvertToStrSafe(txtshkh(0).Tag)))))
                                    If Not InSoChitietCN(GauGe, taikhoan, ConvertToDblSafe(txtshkh(0).Tag), IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1), ChkDu(8).CheckState) Then GoTo LoiBC
                                End If
                            Case 8
                                If Not (Bangluongthang(tdau, tcuoi)) Then GoTo LoiBC
                            Case 12, 15
                                If CboKho(0).SelectedIndex < 0 Then
                                    ErrMsg(er_KhoHang)
                                    GoTo LoiBC
                                End If
                                If CboLoai(1).SelectedIndex < 0 Then
                                    ErrMsg(er_NguonNX)
                                    GoTo LoiBC
                                End If
                                If ChkDu(6).CheckState Then
                                    mkho = CboKho(0).SelectedValue
                                    If Index = 0 Then
                                        If InTheKho3(mkho, tdau, tcuoi) Then
                                            SetRptInfo()
                                            InBaoCaoRPT()
                                        End If
                                    Else
                                        rs_tk = ExecSQLReturnDT(String.Format("SELECT DISTINCT TonKho.MaVattu, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi FROM TonKho INNER JOIN Vattu ON TonKho.MaVattu=Vattu.MaSo WHERE TonKho.MaSoKho={0} ORDER BY Vattu.SoHieu", mkho))
                                        k = ConvertToDblSafe(FrmGetStr.GetString(Ngonngu("Nhập số 0 để in sổ chi tiết vật tư hàng hoá, số 2 để in thẻ kho", "0 to print receipt books detailing supplies and goods, 2 to be in stock"), Ngonngu("In toàn bộ", "Print all"), "0"))
                                        rptFrom.ReportDestination = 0

                                        GauGe.Maximum = 100
                                        For Each rs_tkItem As DataRow In rs_tk.Rows
                                            txtShVT(0).Text = ConvertToStrSafe(rs_tkItem("SoHieu"))
                                            LbTenVT(0).Text = ConvertToStrSafe(rs_tkItem("TenVattu"))
                                            txtShVT(0).Tag = ConvertToStrSafe(rs_tkItem("MaVattu"))
                                            SetRptInfo()
                                            If InTheKho2(mkho, _
                                                   ConvertToStrSafe(rs_tkItem("MaVattu")), _
                                                   tdau, _
                                                   tcuoi, _
                                                   False, _
                                                   IIf(ChkDu(4).CheckState = CheckState.Checked, CboLoai(1).SelectedValue, 0), _
                                                   "", _
                                                   k) Then
                                                HienThongBao(String.Format("{0} - {1}", ConvertToStrSafe(rs_tkItem("SoHieu")), ConvertToStrSafe(rs_tkItem("TenVattu"))), 1)
                                                SetRptInfo()
                                                InBaoCaoRPT()
                                                AppIdle(Pdelay * 100)
                                            End If
                                            If GauGe.Value < GauGe.Maximum Then GauGe.Value += 1
                                        Next
                                    End If
                                    GoTo LoiBC
                                Else
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
                                        FrmChitietThekho.LietKethekho(IIf(OptKho(0).Checked, CboKho(0).SelectedValue, 0), ConvertToDblSafe(txtShVT(0).Tag), IIf(OptTG(0).Checked, tdau, Ngay(0).ToOADate), IIf(OptTG(0).Checked, tcuoi, Ngay(1).ToOADate), True)
                                        GoTo LoiBC
                                    Else
                                        If OptTG(0).Checked Then
                                            If Not InTheKho2(IIf(OptKho(0).Checked, CboKho(0).SelectedValue, 0), _
                                                       ConvertToDblSafe(txtShVT(0).Tag), _
                                                       tdau, _
                                                       tcuoi, _
                                                       True, _
                                                       IIf(ChkDu(4).CheckState = CheckState.Checked, CboLoai(1).SelectedValue, 0), _
                                                       IIf(ChkDu(7).CheckState = CheckState.Checked And ConvertToDblSafe(txtShTk(10).Tag) > 0, txtShTk(10).Text, String.Empty), _
                                                       IIf(baocao = 15, 1, 0)) Then GoTo LoiBC
                                        Else
                                            If Not InTheKho2N(IIf(OptKho(0).Checked, CboKho(0).SelectedValue, 0), _
                                                       ConvertToDblSafe(txtShVT(0).Tag), _
                                                       Ngay(0), _
                                                       Ngay(1), _
                                                       True, _
                                                       IIf(ChkDu(4).CheckState = CheckState.Checked, CboLoai(1).SelectedValue, 0), _
                                                       IIf(ChkDu(7).CheckState = CheckState.Checked And ConvertToDblSafe(txtShTk(10).Tag) > 0, txtShTk(10).Text, String.Empty), _
                                                       IIf(baocao = 15, 1, 0)) Then GoTo LoiBC
                                        End If
                                    End If
                                End If
                            Case 13 To 16, 29
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
                                TaoBaoCao()
                                ' Tên File dữ liệu và báo cáo
                                If baocao = 29 Then
                                    rptFrom.InitForm(TenFile, SoKhauHao, "SoKhauHao")
                                Else
                                    rptFrom.InitForm(TenFile, SoDuDauCuoiKy, "SoDuDauCuoiKy")
                                End If
                                RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
                                ' Công thức
                                rptFrom.SetFormulas("TenBaoCao", String.Format("'{0}'", TenBaoCao))
                                rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", tg))
                            Case 20
                                If ConvertToDblSafe((txtShVT(1).Tag)) = 0 Then
                                    ErrMsg(er_SHVattu)
                                    txtShVT(1).Focus()
                                    GoTo LoiBC
                                End If
                                InCTDoanhThu2(IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1), ConvertToDblSafe(txtShVT(1).Tag))
                            Case 21
                                If Strings.Len(txtShTk(3).Text) = 0 Then
                                    ErrMsg(er_SHTaiKhoan)
                                    txtShTk(3).Focus()
                                    GoTo LoiBC
                                End If
                                If Not BKChiTietRPT(GauGe, txtShTk(3).Text, NgayDauThang(pNamTC, tdau), NgayCuoiThang(pNamTC, tcuoi)) Then GoTo LoiBC
                            Case 30, 31
                                If ChkDu(9).CheckState = CheckState.Checked And Strings.Len(txtShTk(9).Text) > 0 Then
                                    taikhoan.InitTaikhoanSohieu(txtShTk(9).Text)
                                Else
                                    taikhoan.InitTaikhoanMaSo(0)
                                End If
                                If baocao = 30 Then
                                    If Not InVATHoanLai(GauGe, tdau, tcuoi) Then GoTo LoiBC
                                Else
                                    If Not InVATMienGiam(GauGe, tdau, tcuoi) Then GoTo LoiBC
                                End If
                            Case 33
                                If CboKho(0).SelectedIndex < 0 Then
                                    ErrMsg(er_KhoHang)
                                    GoTo LoiBC
                                End If
                                If ChkDu(2).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(4).Tag)) = 0 Then
                                    ErrMsg(er_SHTKVT)
                                    txtShTk(4).Focus()
                                    GoTo LoiBC
                                End If
                                mkho = IIf(OptKho(0).Checked, CboKho(0).SelectedValue, 0)
                                mloai = IIf(ChkDu(5).CheckState = CheckState.Checked, CboLoai(0).SelectedValue, 0)
                                If OptTG(0).Checked Then
                                    InLuyKe(GauGe, _
                                        mkho, _
                                        IIf(ChkDu(2).CheckState = CheckState.Unchecked, "", txtShTk(4).Text), _
                                        mloai, _
                                        tdau, _
                                        tcuoi, _
                                        True, _
                                        1)
                                Else
                                    InLuyKeN(GauGe, _
                                        mkho, _
                                        IIf(ChkDu(2).CheckState = CheckState.Unchecked, "", txtShTk(4).Text), _
                                        mloai, _
                                        Ngay(0), _
                                        Ngay(1), _
                                        True, _
                                        1)
                                End If
                            Case 34
                                SoDangKyCT(tdau, tcuoi, IIf(OptTG(1).Checked, 1, 0), Ngay(0), Ngay(1))
                            Case 35
                                CTGhiSo(CTGS.SelectedValue, tdau, tcuoi, IIf(OptTG(1).Checked, 1, 0), Ngay(0), Ngay(1), IIf(ChkDu(1).CheckState, CboVV.SelectedValue, 0))
                        End Select
                    Case 3
                        rptFrom.ReportWindowTitle = OptBCQT(baocao).Text
                        Select Case baocao
                            Case 0
                                Baocao111(tcuoi)
                            Case 1
                                Baocao128(tcuoi)
                            Case 2
                                Baocao131(tcuoi)
                            Case 3
                                Baocao138(tcuoi)
                            Case 4
                                Baocao141(tcuoi)
                            Case 5
                                Baocao142(tdau, tcuoi)
                            Case 6
                                Baocao144(tcuoi)
                            Case 7
                                Baocao152(tcuoi)
                            Case 8
                                Baocao154(tcuoi)
                            Case 9
                                Baocao222(tcuoi)
                            Case 10
                                Baocao241(tdau, tcuoi)
                            Case 11
                                Baocao311(tcuoi)
                            Case 12
                                Baocao331(tcuoi)
                            Case 13
                                Baocao333(tdau, tcuoi)
                            Case 14
                                Baocao334(tdau, tcuoi)
                            Case 15
                                Baocao338(tdau, tcuoi)
                            Case 16
                                Baocao411(tdau, tcuoi)
                            Case 17
                                Baocao632(tdau, tcuoi)
                            Case 18
                                Baocao642(tdau, tcuoi)
                            Case 19
                                Baocao911(tdau, tcuoi)
                        End Select
                        GoTo LoiBC
                    Case 4
                        rptFrom.ReportWindowTitle = OptCDT(baocao).Text
                        taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(8).Tag))
                        Select Case baocao
                            Case 0
                                BKChiTiet2(xlapp, xlsheet, "642", Ngay(0), Ngay(1), ConvertToDblSafe(CboNK.SelectedValue) + 1, "Sổ chi phí Ban quản lý dự án", 1)
                                GoTo LoiBC
                            Case 1
                                If Not (KiemTraTK(taikhoan, "2412")) Then GoTo LoiBC
                                InChiPhiDT(tdau, tcuoi, taikhoan)
                            Case 2
                                If Not (KiemTraTK(taikhoan, "2412")) Then GoTo LoiBC
                                SoCPDauTuXD(taikhoan, Ngay(0), Ngay(1))
                                GoTo LoiBC
                            Case 3
                                If Not (KiemTraTK(taikhoan, "441") Or KiemTraTK(taikhoan, "3")) Then GoTo LoiBC
                                SoCTNguonVonDT(taikhoan, Ngay(0), Ngay(1))
                            Case 4
                                If Not KiemTraTK(taikhoan, "511") Then GoTo LoiBC
                                InCTDoanhThuCDT(Ngay(0), Ngay(1), ConvertToDblSafe(txtShTk(2).Tag), txtShTk(8).Text)
                            Case 5
                                If Not (KiemTraTK(taikhoan, "2412")) Then GoTo LoiBC
                                THQuyetToan(taikhoan)
                                GoTo LoiBC
                            Case 6
                                If Not (KiemTraTK(taikhoan, "2412")) Then GoTo LoiBC
                                ThucHienDauTu(taikhoan)
                                GoTo LoiBC
                            Case 7
                                If Not (KiemTraTK(taikhoan, "2412")) Then GoTo LoiBC
                                QuyetToanChiPhi(taikhoan)
                                GoTo LoiBC
                            Case 8
                                If Not (KiemTraTK(taikhoan, "2412")) Then GoTo LoiBC
                                DuyetQuyetToan(taikhoan)
                                GoTo LoiBC
                            Case 9
                                NguonVonDauTu(tdau, tcuoi)
                            Case 10
                                If Not (KiemTraTK(taikhoan, "2412", 3) Or KiemTraTK(taikhoan, "2412", 5) Or KiemTraTK(taikhoan, "2412", 7) Or KiemTraTK(taikhoan, "2412", 9)) Then GoTo LoiBC
                                ThucHienDauTu2(tdau, tcuoi, taikhoan)
                            Case 11
                                TMCDT(tdau, tcuoi)
                                GoTo LoiBC
                            Case 12
                                If Not (KiemTraTK(taikhoan, "2412")) Then GoTo LoiBC
                                ThucHienDauTu3(tdau, tcuoi, taikhoan)
                                GoTo LoiBC
                            Case 13
                                If Not (KiemTraTK(taikhoan, "2412")) Then GoTo LoiBC
                                TSBanGiao(tdau, tcuoi, taikhoan)
                                GoTo LoiBC
                            Case 14
                                If Not (KiemTraTK(taikhoan, "2412")) Then GoTo LoiBC
                                CongNo_Von(tdau, tcuoi, taikhoan)
                                GoTo LoiBC
                            Case 15
                                If Not (KiemTraTK(taikhoan, "2412")) Then GoTo LoiBC
                                QTDauTu(tdau, tcuoi, taikhoan)
                                GoTo LoiBC
                        End Select
                End Select
a:
                'rptFrom.ReportDestination = IIf(Index = 0, 0, IIf(Index = 1, 1, -1)) 'rptFrom.ReportDestination = IIf(Index = 0, 1, IIf(Index = 1, 0, -1))
                InBaoCaoRPT()
                On Error GoTo Bad

                On Error GoTo 0
                GoTo LoiBC
            Case 2
                Me.Hide() : Exit Sub
            Case 3
                Select Case loai
                    Case 0
                        If baocao = 0 Then
                            TaoBC(tdau, tcuoi, 1, 1)
                            OpenBook(String.Format("{0}\RePorts\BC26.xls", pCurDir))
                            CopyBC26(tdau, tcuoi)
                            CloseBook(String.Format("{0}\RePorts\BC26.xls", pCurDir))
                            CallExcel("\temp\BC26.xls")
                        ElseIf baocao = 2 Then
                            Dim qnk As String = String.Empty
                            InVATDauRa(tdau, tcuoi, CboTL.SelectedValue, taikhoan, , , qnk)
                            If ChkDu(20).CheckState = CheckState.Checked Then ten = "qm"
                            OpenBook(String.Format("{0}\RePorts\bangkebanra{1}.xls", pCurDir, ten))
                            CopyDataRa(ten, qnk)
                            CloseBook(String.Format("{0}\RePorts\bangkebanra{1}.xls", pCurDir, ten))
                            CallExcel(String.Format("\temp\vatbanra{0}.xls", ten))
                        ElseIf baocao = 3 Then
                            Dim qnk As String = String.Empty
                            InVATDauVao2(tdau, tcuoi, CboTL.SelectedValue, 1, taikhoan, qnk)
                            If ChkDu(20).CheckState = CheckState.Checked Then ten = "qm"
                            OpenBook(String.Format("{0}\RePorts\bangkemuavao{1}.xls", pCurDir, ten))
                            CopyDataVao(ten, qnk)
                            CloseBook(String.Format("{0}\RePorts\bangkemuavao{1}.xls", pCurDir, ten))
                            CallExcel(String.Format("\temp\vatmuavao{0}.xls", ten))
                        End If
                    Case 1
                        If baocao = 5 Then
                            BK05A()
                            Mientru = ("SELECT ten, mst, cmnd, sum(tongthunhap) as ttn, max(phuthuoc) as pt,max(sothang) as st,sum(tuthien+nhandao+khuyenhoc) as tt,sum(bhxh+bhyt+bhtn) as bh,sum(lkcn) as giam,sum(thuephainop) as n FROM (" + Qtinhluong + ") As Qtinhluong group by ten, mst, cmnd")
                            OpenBook(String.Format("{0}\RePorts\Bang_Ke_05AK.xls", pCurDir))
                            CopyData5A()
                            CloseBook(String.Format("{0}\RePorts\Bang_Ke_05AK.xls", pCurDir))
                            CallExcel("\TEMP\Bang_Ke_05AK.xls")
                        ElseIf baocao = 6 Then
                            BK05B()
                            Mientru = ("SELECT ten, mst, cmnd, sum(tongthunhap) as ttn,0 as giam,sum(nop) as n FROM (" + Qtinhluong + ") As Qtinhluong group by ten, mst, cmnd")
                            OpenBook(String.Format("{0}\RePorts\Bang_Ke_05BK.xls", pCurDir))
                            CopyData5B()
                            CloseBook(String.Format("{0}\TEMP\Bang_Ke_05BK.xls", pCurDir))
                            CallExcel("\TEMP\Bang_Ke_05BK.xls")
                        ElseIf baocao = 19 Then
                            XLQCDT(True, tdau, tcuoi, CboCap.SelectedValue + 1, Chk1.CheckState)
                        End If
                    Case 2
                        Select Case baocao
                            Case 0
                                ten = "\RePorts\Nhatky.xls"
                                title = "SỔ NHẬT KÝ CHUNG"
                                If Not InNhatKy1(ten, tdau, tcuoi, IIf(ChkDu(1).CheckState, CboVV.SelectedValue, 0), IIf(OptTG(1).Checked, 1, 0), Ngay(0), Ngay(1), 0, 0, 0, 0, 0, 0) Then GoTo LoiBC
                            Case 5, 7
                                If pRpt = CheckState.Checked And (Not ChoXemBC(baocao, "C")) Then
                                    ErrMsg(er_KoSD)
                                    Exit Sub
                                End If
                                Me.Cursor = Cursors.WaitCursor
                                GauGe.Value = 0
                                If ConvertToDblSafe((txtShTk(0).Tag)) = 0 Then
                                    ErrMsg(er_SHTaiKhoan)
                                    txtShTk(0).Focus()
                                    GoTo LoiBC
                                End If
                                If ChkDu(0).CheckState = CheckState.Checked Then
                                    doiung.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(5).Tag))
                                Else
                                    doiung.InitTaikhoanMaSo(0)
                                End If
                                taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(txtShTk(0).Tag))
                                If (taikhoan.MaTC = taikhoan.maso Or taikhoan.MaTC = 0) And Not ((taikhoan.sohieu Like "112%") And OptTG(1).Checked) Then
                                    If baocao = 5 Then
                                        ten = "\RePorts\Socai.xls"
                                        title = "SỔ CÁI TÀI KHOẢN"
                                        If Not InSocaiTk1(taikhoan, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1), True, doiung.sohieu, 0, 0, 0, 0, 0, 0, ten) Then GoTo LoiBC
                                    ElseIf baocao = 7 Then
                                        ten = "\RePorts\SoQuy.xls"
                                        title = "SỔ QUỸ TIỀN MẶT"
                                        If Not InSoQuy(taikhoan, IIf(OptTG(0).Checked, tdau, 0), IIf(OptTG(0).Checked, tcuoi, 0), Ngay(0), Ngay(1), True, doiung.sohieu, 0, 0, 0, 0, 0, 0, ten) Then GoTo LoiBC
                                    End If
                                End If
                        End Select
                End Select
            Case 4
                FrmIntoanboso.thuchien()
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
        MessageBox.Show(String.Format("Error {0}: {1}", Information.Err().Number, Information.Err().Description), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
LoiBC:
        If _CboThang_1.Items.Count > 0 Then
            chiso1 = _CboThang_1.SelectedIndex
        End If
        If _CboThang_0.Items.Count > 0 Then
            chiso0 = _CboThang_0.SelectedIndex
        End If
        HienThongBao(Me.Text, 1)
        GauGe.Value = GauGe.Maximum
        '    Set taikhoan = Nothing
        '    Set doiung = Nothing
        '    Set rs_tk = Nothing
        Me.Cursor = Cursors.Default
        'rptFrom.ReportDestination = 0
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub TaoBaoCao()
        Dim thg_dau, thg_cuoi As Integer
        If CboThang(0).Enabled Then thg_dau = CboThang(0).SelectedValue
        If CboThang(1).Enabled Then thg_cuoi = CboThang(1).SelectedValue
        Dim rs As DataTable
        Dim soluong As Integer
        Select Case baocao
            Case 13 ' Sổ TSCĐ
                Mientru = (String.Format("SELECT * FROM CTTaiSan WHERE {0} AND MaLoai=33", WThang("Thang", 0, thg_dau)))
                SoDuDauCuoiKy = (String.Format("SELECT DISTINCT TaiSan.Ten AS TenTS, TaiSan.SoHieu AS SoHieuTS,NangLuc,TaiSan.GhiChu,ThangTang,NamSX,NamSD, LoaiTaiSan.SoHieu AS SoHieuTK, LoaiTaiSan.MaSo AS MaTK, LoaiTaiSan.Ten AS TenTK,QuocGia.Ten AS NuocSX,(ThongSo.NG_NS+ThongSo.NG_TBS+ThongSo.NG_CNK+ThongSo.NG_TD) AS NG, (ThongSo.KH_NS+ThongSo.KH_TBS+ThongSo.KH_CNK+ThongSo.KH_TD) AS KH, TaiSan.SHCT AS SCT1,TaiSan.NCT AS NCT1,TaiSan.NCT AS NGS1, MienTru.SoHieu AS SCT2,MienTru.VaoSo AS NCT2,MienTru.DienGiai AS DG2, (MienTru.NG_NS+MienTru.NG_TBS+MienTru.NG_TD+MienTru.NG_CNK-MienTru.CL_NS-MienTru.CL_TBS-MienTru.CL_TD-MienTru.CL_CNK) AS SoDaKH,TaiSan.NamKH FROM (((LoaiTaiSan INNER JOIN TaiSan ON LoaiTaiSan.MaSo = TaiSan.Maloai) INNER JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS) INNER JOIN QuocGia ON TaiSan.MaNuoc=QuocGia.MaSo) LEFT JOIN (" + Mientru + ") AS MienTru ON TaiSan.MaSo=MienTru.MaTS WHERE {0} AND ((ThongSo.Thang = {1} AND {2}) OR (ThongSo.Thang = ThangGiam-1 AND {3})) ORDER BY TaiSan.SoHieu", _
                                            WThang("ThangTang", 0, thg_dau), _
                                            ConvertToStrSafe(CThangDB2(thg_dau)), _
                                            WThang2("ThangGiam", thg_dau, 0), _
                                            WThang("ThangGiam", 0, thg_dau)))
            Case 14 ' Sổ theo dõi TSCĐ sử dụng
                Mientru = (String.Format("SELECT * FROM CTTaiSan WHERE {0} AND MaLoai=33", WThang("Thang", 0, thg_dau)))
                SoDuDauCuoiKy = (String.Format("SELECT DISTINCT TaiSan.Ten AS TenTS, TaiSan.SoHieu AS SoHieuTS,NangLuc,TaiSan.GhiChu,ThangTang,NamSX,NamSD, LoaiTaiSan.SoHieu AS SoHieuTK, LoaiTaiSan.MaSo AS MaTK, LoaiTaiSan.Ten AS TenTK,QuocGia.Ten AS NuocSX,(ThongSo.NG_NS+ThongSo.NG_TBS+ThongSo.NG_CNK+ThongSo.NG_TD) AS NG, (ThongSo.KH_NS+ThongSo.KH_TBS+ThongSo.KH_CNK+ThongSo.KH_TD) AS KH, TaiSan.SHCT AS SCT1,TaiSan.NCT AS NCT1,TaiSan.NCT AS NGS1, MienTru.SoHieu AS SCT2,MienTru.VaoSo AS NCT2,MienTru.DienGiai AS DG2, (MienTru.NG_NS+MienTru.NG_TBS+MienTru.NG_TD+MienTru.NG_CNK-MienTru.CL_NS-MienTru.CL_TBS-MienTru.CL_TD-MienTru.CL_CNK) AS SoDaKH,TaiSan.NamKH FROM (((LoaiTaiSan INNER JOIN TaiSan ON LoaiTaiSan.MaSo = TaiSan.Maloai) INNER JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS) INNER JOIN QuocGia ON TaiSan.MaNuoc=QuocGia.MaSo) LEFT JOIN (" + Mientru + ") AS MienTru ON TaiSan.MaSo=MienTru.MaTS WHERE {0} AND ((ThongSo.Thang = {1} AND {2}) OR (ThongSo.Thang = ThangGiam-1 AND {3})) ", _
                                            WThang("ThangTang", 0, thg_dau), _
                                            ConvertToStrSafe(CThangDB2(thg_dau)), _
                                            WThang2("ThangGiam", thg_dau, 0), _
                                            WThang("ThangGiam", 0, thg_dau)))
                rptFrom.SetFormulas("QuanLy", String.Format("'{0}'", ConvertToStrSafe(GetSelectValue(String.Format("SELECT dtqly.ten as f1 FROM ((dtqly inner join thongso on dtqly.maso=thongso.madtql)inner join taisan on taisan.maso=thongso.mats) inner join ({0}) as sodudaucuoiky on taisan.sohieu=sodudaucuoiky.sohieuts", SoDuDauCuoiKy)))))
            Case 16 ' Sổ theo dõi CCDC sử dụng
                Mientru = (String.Format("SELECT DISTINCT Congcudungcu.maso as macc,congcudungcu.NamSX as sl1,Congcudungcu.Ten AS TenTS, Congcudungcu.SoHieu AS SoHieuTS,Congcudungcu.GhiChu,LoaiCongcudungcu.SoHieu AS SoHieuTK, LoaiCongcudungcu.MaSo AS MaTK, LoaiCongcudungcu.Ten AS TenTK,(ThongSo1.NG_NS+ThongSo1.NG_TBS+ThongSo1.NG_CNK+ThongSo1.NG_TD) AS NG, (ThongSo1.KH_NS+ThongSo1.KH_TBS+ThongSo1.KH_CNK+ThongSo1.KH_TD) AS KH, Congcudungcu.SHCT AS SCT1,Congcudungcu.NCT AS NCT1,Congcudungcu.NCT AS NGS1 FROM (LoaiCongcudungcu INNER JOIN Congcudungcu ON LoaiCongcudungcu.MaSo = Congcudungcu.Mataikhoan) INNER JOIN ThongSo1 ON Congcudungcu.MaSo = ThongSo1.MaTS WHERE {0} AND ((ThongSo1.Thang = {1} AND {2}) OR (ThongSo1.Thang = ThangGiam-1 AND {3})) ", _
                                      WThang("ThangTang", 0, thg_dau), _
                                      ConvertToStrSafe(CThangDB2(thg_dau)), _
                                      WThang2("ThangGiam", thg_dau, 0), _
                                      WThang("ThangGiam", 0, thg_dau)))
                rs = ExecSQLReturnDT("SELECT maso,sohieu FROM congcudungcu")
                ExecSQLNonQuery("DELETE  FROM BKNhomPS")
                For Each rsItem As DataRow In rs.Rows
                    soluong = ConvertToDblSafe(GetSelectValue(String.Format("SELECT chungtu.sops2co as f1 FROM chungtu,congcudungcu WHERE congcudungcu.maso={0} and congcudungcu.shct=left(chungtu.sohieu,len(chungtu.sohieu)-2) and congcudungcu.thangtang=chungtu.thangct and chungtu.maloai=2 and chungtu.mavattu={1} order by chungtu.maso", _
                                                                  rsItem("MaSo"), _
                                                                  Timten("maso", ConvertToStrSafe(rsItem("SoHieu")), "sohieu", "vattu"))))
                    If soluong > 0 Then ExecSQLNonQuery(String.Format("INSERT into BKNhomPS(shtk,mact,sopsno)values({1},{2},{3})", _
                                                            Lng_MaxValue("maso", "BKNhomPS") + 1, _
                                                            ConvertToStrSafe(Lng_MaxValue("maso", "BKNhomPS") + 1), _
                                                            rsItem("MaSo"), _
                                                            soluong))
                Next
                SoDuDauCuoiKy = ("SELECT mientru.*, bknhomps.sopsno as sl2 FROM (" & Mientru & ") as mientru left join bknhomps on mientru.macc=bknhomps.mact")
            Case 29 ' Thẻ TSCĐ
                QChitiet = (String.Format("SELECT * FROM CTTaiSan WHERE {0} AND MaLoai=33", WThang("Thang", 0, thg_dau)))
                Mientru = (String.Format("SELECT DISTINCT TaiSan.maso as masots,TaiSan.SoHieu AS SoHieuTS, TaiSan.Ten AS TenTS,quocgia.ten as nuoc,taisan.namsx as namsx,thongso.madtql as ql,taisan.namsd as namsd,taisan.nangluc as nangluc,taisan.shct,taisan.nct as ngayct, taisan.namkh as namkh, (ThongSo.KH_NS+ThongSo.KH_TBS+ThongSo.KH_CNK+ThongSo.KH_TD) AS KH, (ThongSo.CL_NS+ThongSo.CL_TBS+ThongSo.CL_CNK+ThongSo.CL_TD) AS CL, (QChitiet.NG_NS+QChitiet.NG_TBS+QChitiet.NG_TD+QChitiet.NG_CNK-QChitiet.CL_NS-QChitiet.CL_TBS-QChitiet.CL_TD-QChitiet.CL_CNK) AS SoDaKH FROM ((TaiSan inner join quocgia on taisan.manuoc=quocgia.maso) inner join ThongSo ON TaiSan.MaSo = ThongSo.MaTS) left join ({0}) AS QChitiet on taisan.maso=QChitiet.mats WHERE {1} AND {2} AND ThongSo.Thang >= {3} AND ThongSo.Thang <= {3}", _
                               QChitiet, _
                               WThang("ThangTang", 0, thg_dau), _
                               WThang("ThangGiam", thg_dau, 0), _
                               ConvertToStrSafe(CThangDB2(thg_dau))))
                SoDuDauCuoiKy = ("SELECT mientru.*,cttaisan.DienGiai as DienGiai,(cttaisan.NG_NS + cttaisan.NG_TBS + cttaisan.NG_CNK + cttaisan.NG_TD) AS NG,DTQLy.ten as tenql FROM ((" & Mientru & ")as mientru inner join cttaisan on mientru.masots=cttaisan.mats)inner join DTQLy on mientru.ql=DTQLy.maso WHERE cttaisan.ng_ns>=0 AND cttaisan.ng_tbs>=0 AND cttaisan.ng_cnk>=0 AND cttaisan.ng_td>=0")
                QNhatKy = ("SELECT Distinct SoDuDauCuoiKy.masots,cttaisan.ngayghi as ngaygiamts,cttaisan.DienGiai as lydogiamts,loaichungtu.ten as lydogiamts1,chungtu.sohieu as soctgiam FROM ((" & SoDuDauCuoiKy & ") as SoDuDauCuoiKy inner join (cttaisan inner join loaichungtu on cttaisan.manhom=loaichungtu.maso) on SoDuDauCuoiKy.masots=cttaisan.mats) inner join chungtu on chungtu.mact=cttaisan.mactkt WHERE cttaisan.ng_ns<0 or cttaisan.ng_tbs<0 or cttaisan.ng_cnk<0 or cttaisan.ng_td<0")
                SoKhauHao = (String.Format("SELECT SoDuDauCuoiKy.*,qnhatky.* FROM (" & SoDuDauCuoiKy & ") as SoDuDauCuoiKy left join ({0}) As QNhatKy on SoDuDauCuoiKy.masots=qnhatky.masots", QNhatKy))
        End Select
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub TinhSoLieuBaoCao()
        Dim thg_dau, thg_cuoi As Integer
        ' Xác định các tháng cần tính số liệu
        Select Case baocao
            Case 18
                thg_dau = CboThang(0).SelectedValue
                thg_cuoi = CboThang(1).SelectedValue
            Case Else : Exit Sub
        End Select
        ' Tính giá trị tài sản cho các tháng cần lấy số liệu
        HienThongBao("Cập nhật giá trị tài sản ...", 1)
        For chi_so As Integer = CThangDB2(thg_dau) To CThangDB2(thg_cuoi)
            If chi_so > 0 Then
                If Not SoLieu(chi_so - 1) Then
                    Me.Cursor = Cursors.WaitCursor
                    CapNhatGiaTriTaiSan(chi_so, GauGe)
                    SoLieu(chi_so - 1) = True
                    Me.Cursor = Cursors.Default
                End If
            End If
        Next
        HienThongBao("", 1)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Frame4_DoubleClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Frame4_0.DoubleClick
        FrmMNBaocao_DoubleClick(Me, New EventArgs())
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
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub OptInso_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs)
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(OptInso, eventSender)
            Dim thg_dau, thg_cuoi As Boolean
            baocao = Index
            Command(3).Enabled = False
            ChkDu(16).CheckState = CheckState.Unchecked
            ChkDu(16).Enabled = False
            OptTG(0).Enabled = True
            OptTG(1).Enabled = True
            OptTG(0).Checked = True
            Select Case Index
                Case 1, 3
                    OptTG(0).Enabled = False
                    OptTG(1).Checked = True
                    txtShTk(6).Text = ConvertToStrSafe(IIf(Index = 1, 1111, 112))
                    txtShTk_Leave(txtShTk(6), New EventArgs())
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
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub OptQT_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptQT_7.CheckedChanged, _OptQT_23.CheckedChanged, _OptQT_8.CheckedChanged, _OptQT_19.CheckedChanged, _OptQT_22.CheckedChanged, _OptQT_21.CheckedChanged, _OptQT_16.CheckedChanged, _OptQT_18.CheckedChanged, _OptQT_17.CheckedChanged, _OptQT_20.CheckedChanged, _OptQT_15.CheckedChanged, _OptQT_4.CheckedChanged, _OptQT_5.CheckedChanged, _OptQT_6.CheckedChanged, _OptQT_0.CheckedChanged, _OptQT_3.CheckedChanged, _OptQT_2.CheckedChanged, _OptQT_1.CheckedChanged, _OptQT_9.CheckedChanged, _OptQT_14.CheckedChanged, _OptQT_13.CheckedChanged, _OptQT_11.CheckedChanged, _OptQT_10.CheckedChanged, _OptQT_12.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(OptQT, eventSender)
            baocao = Index
            Command(3).Enabled = OptQT(5).Checked Or OptQT(6).Checked Or OptQT(19).Checked
            ChkDu(16).CheckState = CheckState.Unchecked
            ChkDu(16).Enabled = OptQT(19).Checked
            OptTG(1).Enabled = False
            Frame2(5).Visible = OptQT(7).Checked
            CboCap.Enabled = OptQT(19).Checked Or OptQT(20).Checked
            If baocao = 7 Or baocao = 23 Then
                Frame2(5).Visible = True
                ChkDu(13).Enabled = pChietKhau > 0
                OptTG(1).Enabled = True
                OptTG(0).Enabled = True
                Label(0).Enabled = True
                Label(1).Enabled = True
                CboThang(0).Enabled = True
                CboThang(1).Enabled = True
            ElseIf baocao = 0 Or baocao = 3 Or baocao = 4 Or baocao = 5 Or baocao = 6 Or baocao = 14 Then
                OptTG(0).Enabled = False
                Label(0).Enabled = False
                Label(1).Enabled = False
                CboThang(0).Enabled = False
                CboThang(1).Enabled = False
            Else
                OptTG(0).Checked = True
                OptTG(0).Enabled = True
                Label(0).Enabled = True
                Label(1).Enabled = True
                CboThang(0).Enabled = True
                CboThang(1).Enabled = True
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub OptSo_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptSo_34.CheckedChanged, _OptSo_35.CheckedChanged, _OptSo_15.CheckedChanged, _OptSo_33.CheckedChanged, _OptSo_31.CheckedChanged, _OptSo_30.CheckedChanged, _OptSo_29.CheckedChanged, _OptSo_21.CheckedChanged, _OptSo_20.CheckedChanged, _OptSo_19.CheckedChanged, _OptSo_16.CheckedChanged, _OptSo_14.CheckedChanged, _OptSo_13.CheckedChanged, _OptSo_12.CheckedChanged, _OptSo_9.CheckedChanged, _OptSo_7.CheckedChanged, _OptSo_5.CheckedChanged, _OptSo_4.CheckedChanged, _OptSo_3.CheckedChanged, _OptSo_2.CheckedChanged, _OptSo_1.CheckedChanged, _OptSo_0.CheckedChanged, _OptSo_6.CheckedChanged, _OptSo_8.CheckedChanged, _OptSo_11.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(OptSo, eventSender)
            Dim thg_dau, thg_cuoi As Boolean
            baocao = Index
            OptTG(0).Enabled = True
            OptTG(1).Enabled = True
            OptTG(0).Checked = True
            CboThuchi.Enabled = OptSo(1).Checked Or OptSo(2).Checked
            ChkDu(16).Enabled = OptSo(5).Checked Or OptSo(6).Checked Or OptSo(12).Checked
            Command(3).Enabled = OptSo(0).Checked Or OptSo(5).Checked Or OptSo(7).Checked
            ChkDu(10).Enabled = OptSo(5).Checked
            ChkDu(8).Enabled = OptSo(6).Checked
            ChkDu(6).Enabled = OptSo(12).Checked
            Select Case Index
                Case 0, 8, 10, 21
                    OptTG(1).Enabled = False
                    thg_dau = True : thg_cuoi = True
                Case 29
                    TenFile = "Thetaisan.rpt"
                    TenBaoCao = "Thẻ tài sản cố định"
                    OptTG(1).Enabled = False
                    thg_dau = True : thg_cuoi = False
                Case 7, 9, 11, 19
                    OptTG(0).Enabled = False
                    OptTG(1).Checked = True
                    txtShTk(0).Text = ConvertToStrSafe(IIf(Index = 7 Or Index = 11, 1111, (IIf(Index = 9, 112, 311))))
                    txtShTk_Leave(txtShTk(0), New EventArgs())
                Case 13
                    TenFile = "SOTSCD2.RPT"
                    TenBaoCao = "Sổ tài sản cố định"
                    OptTG(1).Enabled = False
                    thg_dau = True : thg_cuoi = False
                Case 14
                    TenFile = "SoTDTSCD.RPT"
                    TenBaoCao = "Sổ theo dõi tài sản cố định nơi sử dụng"
                    OptTG(1).Enabled = False
                    thg_dau = True : thg_cuoi = False
                Case 16
                    TenFile = "SoTDCCDC.rpt"
                    TenBaoCao = "Sổ theo dõi công cụ dụng cụ nơi sử dụng"
                    OptTG(1).Enabled = False
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

            If OptTG(0).Checked Then
                If _CboThang_0.SelectedIndex < 0 And _CboThang_0.Items.Count > 0 Then
                    _CboThang_0.SelectedIndex = 0
                End If
                If _CboThang_1.SelectedIndex < 0 And _CboThang_1.Items.Count > 0 Then
                    _CboThang_1.SelectedIndex = 0
                End If
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub OptVAT_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptVAT_19.CheckedChanged, _OptVAT_18.CheckedChanged, _OptVAT_17.CheckedChanged, _OptVAT_20.CheckedChanged, _OptVAT_9.CheckedChanged, _OptVAT_1.CheckedChanged, _OptVAT_0.CheckedChanged, _OptVAT_2.CheckedChanged, _OptVAT_3.CheckedChanged, _OptVAT_6.CheckedChanged, _OptVAT_5.CheckedChanged, _OptVAT_7.CheckedChanged, _OptVAT_8.CheckedChanged, _OptVAT_10.CheckedChanged, _OptVAT_11.CheckedChanged, _OptVAT_4.CheckedChanged, _OptVAT_12.CheckedChanged, _OptVAT_13.CheckedChanged, _OptVAT_15.CheckedChanged, _OptVAT_14.CheckedChanged, _OptVAT_16.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(OptVAT, eventSender)
            baocao = Index
            Command(3).Enabled = OptVAT(0).Checked Or OptVAT(2).Checked Or OptVAT(3).Checked
            ChkDu(16).CheckState = CheckState.Unchecked
            ChkDu(16).Enabled = OptVAT(2).Checked Or OptVAT(3).Checked
            cboQuy.Enabled = OptVAT(1).Checked
            OptTG(0).Checked = True
            OptTG(1).Enabled = False
            Select Case baocao
                Case 1, 9, 17
                    OptTG(0).Enabled = False
                    Label(0).Enabled = False
                    Label(1).Enabled = False
                    CboThang(0).Enabled = False
                    CboThang(1).Enabled = False
                Case Else
                    OptTG(0).Enabled = True
                    Label(0).Enabled = True
                    Label(1).Enabled = True
                    CboThang(0).Enabled = True
                    CboThang(1).Enabled = True
                    If baocao = 2 And CboTL.SelectedIndex = CboTL.Items.Count - 1 Then OptTG(1).Enabled = True
            End Select
        End If
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
    Private Sub txtshkh_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtshkh_0.Enter, _txtshkh_2.Enter
        Dim Index As Integer = Array.IndexOf(txtshkh, eventSender)
        txtshkh(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtshkh_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtshkh_0.KeyPress, _txtshkh_2.KeyPress
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
    Private Sub txtshkh_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtshkh_0.Leave, _txtshkh_2.Leave
        Dim Index As Integer = Array.IndexOf(txtshkh, eventSender)
        Dim mvt As Integer
        txtshkh(Index).Text = txtshkh(Index).Text.ToUpper()
        lbkh(Index).Text = TenKH(txtshkh(Index).Text, mvt)
        txtshkh(Index).Tag = ConvertToStrSafe(mvt)
    End Sub
    ''' <summary>
    ''' '
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShTk_8.Enter, _txtShTk_3.Enter, _txtShTk_2.Enter, _txtShTk_4.Enter, _txtShTk_10.Enter, _txtShTk_0.Enter, _txtShTk_1.Enter, _txtShTk_9.Enter, _txtShTk_5.Enter, _txtShTk_14.Enter, _txtShTk_15.Enter, _txtShTk_11.Enter, _txtShTk_7.Enter
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        txtShTk(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtShTk_8.KeyPress, _txtShTk_3.KeyPress, _txtShTk_2.KeyPress, _txtShTk_4.KeyPress, _txtShTk_10.KeyPress, _txtShTk_0.KeyPress, _txtShTk_1.KeyPress, _txtShTk_9.KeyPress, _txtShTk_5.KeyPress, _txtShTk_14.KeyPress, _txtShTk_15.KeyPress, _txtShTk_11.KeyPress, _txtShTk_7.KeyPress
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
    Private Sub txtShTk_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShTk_8.Leave, _txtShTk_3.Leave, _txtShTk_2.Leave, _txtShTk_4.Leave, _txtShTk_10.Leave, _txtShTk_0.Leave, _txtShTk_1.Leave, _txtShTk_9.Leave, _txtShTk_5.Leave, _txtShTk_14.Leave, _txtShTk_15.Leave, _txtShTk_11.Leave, _txtShTk_7.Leave
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
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShVT_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShVT_2.Enter, _txtShVT_1.Enter, _txtShVT_0.Enter
        Dim Index As Integer = Array.IndexOf(txtShVT, eventSender)
        txtShVT(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShVT_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtShVT_2.KeyPress, _txtShVT_1.KeyPress, _txtShVT_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtShVT, eventSender)
        If KeyAscii = 13 Then Cmdvt_ClickEvent(Cmdvt(Index), New EventArgs())
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
    Private Sub txtShVT_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShVT_2.Leave, _txtShVT_1.Leave, _txtShVT_0.Leave
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
    ''' <param name="taikhoan"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="thongbao"></param>
    ''' <param name="doiung"></param>
    ''' <param name="VV"></param>
    ''' <param name="loai"></param>
    ''' <param name="nn"></param>
    ''' <param name="mdt1"></param>
    ''' <param name="mdt2"></param>
    ''' <param name="mdt3"></param>
    ''' <param name="thutudong"></param>
    ''' <param name="lan"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function InSocaiTkDU(ByRef taikhoan As ClsTaikhoan, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef thongbao As Boolean, ByRef doiung As String, ByRef VV As Integer, ByRef loai As Integer, Optional ByRef nn As Integer = 0, Optional ByRef mdt1 As Integer = 0, Optional ByRef mdt2 As Integer = 0, Optional ByRef mdt3 As Integer = 0, Optional ByRef thutudong As Integer = 0, Optional ByRef lan As Boolean = False) As Boolean
        Dim result As Boolean = False
        Dim dkc, dkn, dknt As Double
        Dim ps As Boolean
        Dim sqlw As String = String.Empty
        Dim psn, psc As Double
        'Tạo số thứ tự
        Dim rs_nk As DataTable
        Dim sql As String = String.Empty
        Dim MaCT As Integer
        If tcuoi > 0 Then
            sqlw = WThang("ThangCT", tdau, tcuoi)
            RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        Else
            sqlw = WNgay("NgayGS", ndau, ncuoi)
            RptSetDate(ncuoi)
        End If
        Dim sh As String = String.Empty
        If Not (thutudong = 6 And lan) Then
            If tcuoi = 0 And loai = 0 Then thutudong = 7

            If rptFrom.ReportDestination = 1 And loai = 0 And tdau <> 0 And tcuoi <> 0 Then thutudong = MessageBox.Show(Ngonngu("Có in thứ tự dòng theo nhật ký không?", "Printed in the log line?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Not (thutudong = 7 Or loai <> 0) Then
                sql = String.Format("SELECT DISTINCT (ChungTu{0}.MaSo) AS MS,ChungTu{0}.MaCT, ChungTu{0}.SoHieu, ChungTu{0}.NgayCT, ChungTu{0}.NgayGS, ChungTu{0}.DienGiai, Sum(SoPS) AS SumOfSoPS, HeThongTK.SoHieu as sohieutk, HeThongTK.Ten{1}, -1 AS LoaiPS FROM {2} WHERE SoPS<>0 AND (MaTKTCNo) > 0 AND (((HeThongTK.loai) > 0) And ((chungtu{0}.maloai <> 4) or (chungtu{0}.maloai=4 and matkno<>matkco)) And {3}){4}{5}{6}{7} GROUP BY ChungTu{0}.MaCT, ChungTu{0}.SoHieu, ChungTu{0}.NgayCT, ChungTu{0}.NgayGS, ChungTu{0}.DienGiai, HeThongTK.SoHieu, HeThongTK.Ten{1} UNION SELECT DISTINCT (ChungTu{0}.MaSo) AS MS,ChungTu{0}.MaCT, ChungTu{0}.SoHieu, ChungTu{0}.NgayCT, ChungTu{0}.NgayGS, ChungTu{0}.DienGiai, Sum(SoPS) AS SumOfSoPS, HeThongTK.SoHieu, HeThongTK.Ten{1}, 1 AS LoaiPS FROM {8} WHERE SoPS<>0 AND (MaTKTCCo) > 0 AND (((HeThongTK.loai) > 0) And ((chungtu{0}.maloai <> 4) or (chungtu{0}.maloai=4 and matkno<>matkco)) And ({3})){4}{5}{6}{7} GROUP BY ChungTu{0}.MaCT, ChungTu{0}.SoHieu, ChungTu{0}.NgayCT, ChungTu{0}.NgayGS, ChungTu{0}.DienGiai, HeThongTK.SoHieu, HeThongTK.Ten{1}", sh, (IIf(pNN > 0, "E", String.Empty)), ChungTu2TKNC(-1), sqlw, (IIf(VV > 1, " AND (ChungTu" & sh & ".MaDT = " & ConvertToStrSafe(VV) & ")", String.Empty)), (IIf(mdt1 > 0, " AND (ChungTu" & sh & ".MaDT1 = " & ConvertToStrSafe(mdt1) & ")", String.Empty)), (IIf(mdt2 > 0, " AND (ChungTu" & sh & ".MaDT2 = " & ConvertToStrSafe(mdt2) & ")", String.Empty)), (IIf(mdt3 > 0, " AND (ChungTu" & sh & ".MaDT3 = " & ConvertToStrSafe(mdt3) & ")", String.Empty)), ChungTu2TKNC(1))
                Mientru = (sql)
                rs_nk = ExecSQLReturnDT("SELECT Mientru.* FROM (" & Mientru & ") as MienTru ORDER BY NgayGS,sohieu,sohieutk,loaips,sumofsops desc")
                If rs_nk.Rows.Count > 0 Then
                    ExecSQLNonQuery(("DELETE  FROM BKNhomPS"))
                End If
                For Each rsItem As DataRow In rs_nk.Rows
                    If MaCT <> ConvertToDblSafe(rsItem("MaCT")) Then
                        MaCT = ConvertToDblSafe(rsItem("MaCT"))
                        ExecSQLNonQuery(String.Format("INSERT into BKNhomPS(shtk,sohieu) values(N'{0}', N'{1}N')", _
                                             Lng_MaxValue("maso", "BKNhomPS") + 1, _
                                             rsItem("MaCT")))
                    End If
                    ExecSQLNonQuery(String.Format("INSERT into BKNhomPS(shtk,sohieu,sopsno,mact,ngay,sops2no,sopsco,DienGiai) values( N'{0}', N'{1}',{2},{1}, N'{3}',{4},{5}, N'{6}')", _
                                         Lng_MaxValue("maso", "BKNhomPS") + 1, _
                                         rsItem("MaCT"), _
                                         Lng_MaxValue("sopsno", "BKNhomPS") + 1, _
                                         Format(CDate(rsItem("NgayGS")), Mask_DB), _
                                         rsItem("loaips"), _
                                         rsItem("sumofsops"), _
                                         rsItem("sohieutk")))
                Next
                ExecSQLNonQuery(String.Format("UPDATE BKNhomPS set sopsco=0 WHERE left(DienGiai,{0}) =N'{1}'", taikhoan.sohieu.Length, taikhoan.sohieu))
            End If
        End If
        Dim tienam As Double
        Dim rs As DataTable
        Dim str As String = String.Empty
        With taikhoan
            If tcuoi > 0 Then
                ps = .TkCoPS(tdau, tcuoi)
                .SoDuTK(ThangTruoc(tdau), dkn, dkc, dknt)
            Else
                ps = .TkCoPSN(ndau, ncuoi)
                .SoDuNgay(ndau.AddDays(-1), dkn, dkc, dknt)
            End If
            ' In bao cao
            If dkn <> 0 Or dkc <> 0 Or ps Then
                If thutudong = 6 Then
                    MienTru1 = (String.Format("SELECT DISTINCT ChungTu.MaCT, ChungTu.ThangCT, ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0}, ChungTu.SoPS, ChungTu.{1} as GhiChu, HeThongTK.SoHieu, HeThongTK_1.SoHieu, ChungTu.MaTKTCNo, ChungTu.MaTKTCCo, {2}+ CONVERT(NVARCHAR(48), 10 + ChungTu.ThangCT) + ChungTu.SoHieu AS SH1 FROM HeThongTK AS HeThongTK_3 RIGHT JOIN (HeThongTK AS HeThongTK_2 RIGHT JOIN (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo) ON HeThongTK_2.MaSo = ChungTu.MaTKNo) ON HeThongTK_3.MaSo = ChungTu.MaTKCo WHERE SoPS<>0 AND ((HethongTK.SoHieu LIKE '{3}%'{4}) Or (HethongTK_1.SoHieu LIKE '{3}%'{5})) And {6}{7}{8}{9}{10} AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco)) ORDER BY chungtu.ThangCT,ChungTu.NgayGS,{11}+ConvertToStrSafe(10+ChungTu.ThangCT)+ChungTu.SoHieu", _
                                    IIf(pNN > 0, "", String.Empty), _
                                    IIf(tdau = 0 And tcuoi = 0, "mathuchi", "ghichu"), _
                                    IIf(.kieu < 0, String.Format("CASE WHEN (HethongTK.SoHieu LIKE '{0}%') THEN '0' ELSE '1'END", .sohieu), "CASE WHEN (HethongTK.SoHieu LIKE '" & .sohieu & "%') THEN '1' ELSE '0' END "), _
                                    taikhoan.sohieu, _
                                    IIf(doiung.Length = 0, "", String.Format(" And HethongTK_3.SoHieu LIKE '{0}%'", doiung)), _
                                    IIf(doiung.Length = 0, "", " And HethongTK_2.SoHieu LIKE '" & doiung & "%'"), _
                                    sqlw, _
                                    IIf(VV > 1, String.Format(" AND (ChungTu.MaDT = {0})", VV), String.Empty), _
                                    IIf(mdt1 > 0, String.Format(" AND (ChungTu.MaDT1 = {0})", mdt1), String.Empty), _
                                    IIf(mdt2 > 0, String.Format(" AND (ChungTu.MaDT2 = {0})", mdt2), String.Empty), _
                                    IIf(mdt3 > 0, String.Format(" AND (ChungTu.MaDT3 = {0})", mdt3), String.Empty), _
                                    IIf(.kieu < 0, String.Format("CASE WHEN (HethongTK.SoHieu LIKE '{0}%' THEN '0' ELSE '1' END", .sohieu), String.Format(" CASE WHEN (HethongTK.SoHieu LIKE '{0}%') THEN '1' ELSE '0' END ", .sohieu))))
                    QNhatKy = (String.Format("SELECT Mientru1.MaCT, Mientru1.ThangCT, Mientru1.ChungTu.SoHieu, Mientru1.NgayCT, Mientru1.NgayGS, Mientru1.DienGiai, Sum(Mientru1.SoPS) AS SoPS, Mientru1.GhiChu, Mientru1.HeThongTK.SoHieu, Mientru1.HeThongTK_1.SoHieu, Mientru1.MaTKTCNo, Mientru1.MaTKTCCo, Mientru1.SH1 FROM ({0}) As MienTru1 GROUP BY Mientru1.MaCT, Mientru1.ThangCT, Mientru1.ChungTu.SoHieu, Mientru1.NgayCT, Mientru1.NgayGS, Mientru1.DienGiai, Mientru1.GhiChu, Mientru1.HeThongTK.SoHieu, Mientru1.HeThongTK_1.SoHieu, Mientru1.MaTKTCNo, Mientru1.MaTKTCCo, Mientru1.SH1", MienTru1))
                    Qsocai = (String.Format("SELECT t1.*,t2.sopsno,t2.maso FROM ({0}) As QNhatKyt1 left join bknhomps t2 on t1.mact=t2.mact and t1.ngaygs=t2.ngay and (t1.hethongtk.sohieu=t2.DienGiai or t1.hethongtk_1.sohieu=t2.DienGiai) WHERE left(t2.DienGiai,len({1}))<>'{1}' or (matktcco=0 and left(t2.DienGiai,len({1}))='{1}') or (matktcno=0 and left(t2.DienGiai,len({1}))='{1}')", _
                                  QNhatKy, _
                                  taikhoan.sohieu))
                    rptFrom.SetFormulas("ThangCuoi", tcuoi)
                Else
                    Qsocai = (String.Format("SELECT DISTINCT ChungTu.MaCT, ChungTu.ThangCT, ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0}, ChungTu.SoPS, ChungTu.{1} as GhiChu, HeThongTK.SoHieu, HeThongTK_1.SoHieu, ChungTu.MaTKTCNo, ChungTu.MaTKTCCo, {2}+ CONVERT(NVARCHAR(48), 10+ChungTu.ThangCT)+ChungTu.SoHieu AS SH1 FROM HeThongTK AS HeThongTK_3 RIGHT JOIN (HeThongTK AS HeThongTK_2 RIGHT JOIN (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo) ON HeThongTK_2.MaSo = ChungTu.MaTKNo) ON HeThongTK_3.MaSo = ChungTu.MaTKCo WHERE SoPS<>0 AND ((HethongTK.SoHieu LIKE '{3}%'{4}) Or (HethongTK_1.SoHieu LIKE '{3}%'{5})) And {6}{7}{8}{9}{10} AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco)) ORDER BY ThangCT,ChungTu.NgayGS,{11}+ConvertToStrSafe(10+ChungTu.ThangCT)+ChungTu.SoHieu", _
                                  (IIf(pNN > 0, "", String.Empty)), _
                                  (IIf(tdau = 0 And tcuoi = 0, "mathuchi", "ghichu")), _
                                  (IIf(.kieu < 0, String.Format("CASE WHEN (HethongTK.SoHieu LIKE '{0}%') THEN '0' ELSE '1' END", .sohieu), String.Format("CASE WHEN (HethongTK.SoHieu LIKE '{0}%') THEN '1' ELSE '0' END ", .sohieu))), _
                                  taikhoan.sohieu, _
                                  (IIf(doiung.Length = 0, "", String.Format(" And HethongTK_3.SoHieu LIKE '{0}%'", doiung))), _
                                  (IIf(doiung.Length = 0, "", String.Format(" And HethongTK_2.SoHieu LIKE '{0}%'", doiung))), _
                                  sqlw, _
                                  (IIf(VV > 1, String.Format(" AND (ChungTu.MaDT = {0})", VV), String.Empty)), _
                                  (IIf(mdt1 > 0, String.Format(" AND (ChungTu.MaDT1 = {0})", mdt1), String.Empty)), _
                                  (IIf(mdt2 > 0, String.Format(" AND (ChungTu.MaDT2 = {0})", mdt2), String.Empty)), _
                                  (IIf(mdt3 > 0, String.Format(" AND (ChungTu.MaDT3 = {0})", mdt3), String.Empty)), _
                                  (IIf(.kieu < 0, String.Format("CASE WHEN (HethongTK.SoHieu LIKE '{0}%') THEN '0' ELSE '1' END ", .sohieu), String.Format("CASE WHEN (HethongTK.SoHieu LIKE '{0}%') THEN '1' ELSE '0' END ", .sohieu)))))
                End If

                If loai = 0 Then
                    If taikhoan.sohieu Like "112*" And tcuoi = 0 Then
                        rptFrom.InitForm("SOTG.RPT", Qsocai, "Qsocai")
                    Else
                        If taikhoan.sohieu Like "111*" And tcuoi = 0 Then
                            '************************************ Hết kiểm tra ****************************************************
                            rptFrom.InitForm("SOQUYDU.RPT", Qsocai, "Qsocai")
                            If Soquy = 1 Then rptFrom.InitForm("SOQUY1.RPT", Qsocai, "Qsocai")
                        Else
                            rptFrom.InitForm(IIf(thutudong = 6, "SOCAI.RPT", "SOCAI1.RPT"), Qsocai, "Qsocai")
                            rptFrom.SetFormulas("LastRow", ConvertToDblSafe(GetLastRow(Qsocai, "MaCT")))
                        End If
                    End If
                Else
                    If tdau = tcuoi Then
                        rptFrom.InitForm("SOCAI2.RPT", Qsocai, "Qsocai")
                    Else
                        rptFrom.InitForm("SOCAI3.RPT", Qsocai, "Qsocai")
                    End If
                End If
                rptFrom.SetFormulas("SoHieuTK", String.Format("'{0}'", .sohieu))
                rptFrom.SetFormulas("NoDk", dkn - dkc)
                '************************** Biến khởi đầu kiểm tra âm quỷ *****************************
                tienam = dkn - dkc
                '*******************************************************************************************
                rptFrom.SetFormulas("Kieu", .kieu)
                rptFrom.SetFormulas("TenTK", String.Format("'{0} - {1}{2}'", _
                                        .sohieu, _
                                        (IIf(pNN > 0, .TenE, .ten)), _
                                        (IIf(VV > 1, String.Format(" - VV: {0}", TenVV(VV)), String.Empty))))
                If tcuoi > 0 Then
                    rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
                    RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
                    psn = SoPSTK(taikhoan.sohieu, pThangDauKy, tcuoi, -1)
                    psc = SoPSTK(taikhoan.sohieu, pThangDauKy, tcuoi, 1)
                    If VV > 1 Then
                        taikhoan.SoDuTK(tcuoi, dkn, dkc, dknt)
                        rptFrom.SetFormulas("DuCk", IIf(taikhoan.kieu < 0, dkn - dkc, dkc - dkn))
                    End If
                Else
                    rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianN(ndau, ncuoi, nn)))
                    RptSetDate(ncuoi)
                    taikhoan.SoPhatSinhN(NgayDauThang(ncuoi.Year, pThangDauKy), ncuoi, psn, dkn, psc, dkc)
                    If VV > 1 Then
                        taikhoan.SoDuNgay(ncuoi, dkn, dkc, dknt)
                        rptFrom.SetFormulas("DuCk", IIf(taikhoan.kieu < 0, dkn - dkc, dkc - dkn))
                    End If
                End If
                rptFrom.SetFormulas("NoLK", psn)
                rptFrom.SetFormulas("CoLK", psc)
                result = True
                If loai = 0 Then
                    If taikhoan.sohieu Like "112*" And tcuoi = 0 Then

                    Else
                        If taikhoan.sohieu Like "111*" And tcuoi = 0 Then
                            '************************************ Kiểm tra âm hàng **********************************************
                            rs = ExecSQLReturnDT("SELECT DISTINCT chungtu.sohieu, MaCT, ThangCT, NgayCT, NgayGS, DienGiai, sum(SoPS) AS ps, sh1 FROM (" + Qsocai + ") As Qsocai GROUP BY chungtu.sohieu, MaCT, ThangCT, NgayCT, NgayGS, DienGiai, sh1 ORDER BY ngaygs,sh1")
                            For Each rsItem As DataRow In rs.Rows
                                If Strings.Left(ConvertToStrSafe(rsItem("sh1")), 1) = "0" Then
                                    tienam += ConvertToDblSafe(rsItem("ps"))
                                    If tienam <> 0 Then tienam = ConvertToDblSafe(Format(tienam, Mask_2))
                                Else
                                    tienam -= ConvertToDblSafe(rsItem("ps"))
                                    If tienam <> 0 Then tienam = ConvertToDblSafe(Format(tienam, Mask_2))
                                End If
                                If tienam < 0 Then
                                    str = String.Format("{0}{1}, ", _
                                              str, _
                                              rsItem("SoHieu"))
                                End If
                            Next
                            If str <> "" Then
                                If MessageBox.Show(String.Format("Âm tiền tại chứng từ có số hiệu: {0}{1}Tiếp tục ?", _
                                                           Strings.Left(str, str.Length - 2), _
                                                           Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                                    result = False
                                End If
                            End If
                            '************************************ Hết kiểm tra ****************************************************                           
                        End If
                    End If
                End If
            Else
                If thongbao Then MessageBox.Show(Ngonngu("Không có số đầu kỳ hoặc phát sinh !", "There are no beginning or arsing"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                result = False
            End If
        End With
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub InQTTTN(ByRef tdau As Integer, ByRef tcuoi As Integer)
        rptFrom.InitForm("TNDN.RPT", "SELECT * FROM License", "License")

        rptFrom.SetFormulas("tdau", tdau)
        rptFrom.SetFormulas("tcuoi", tcuoi)
        rptFrom.SetFormulas("thangdauky", pThangDauKy)
        rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))
        rptFrom.SetFormulas("Huyen", String.Format("'{0}'", frmMain._LbCty_10.Text))
        rptFrom.SetFormulas("Tinh", String.Format("'{0}'", frmMain._LbCty_11.Text))
        rptFrom.SetFormulas("DienThoai", String.Format("'{0}'", frmMain._LbCty_3.Text))
        rptFrom.SetFormulas("Fax", String.Format("'{0}'", frmMain._LbCty_4.Text))
        rptFrom.SetFormulas("Email", String.Format("'{0}'", frmMain._LbCty_9.Text))
        rptFrom.SetFormulas("Ma10", SoPSTK("511", tdau, tcuoi, 1) + SoPSTK("515", tdau, tcuoi, 1) + SoPSTK("711", tdau, tcuoi, 1) - SoPSTK("521", tdau, tcuoi, 1))
        rptFrom.SetFormulas("ma11", SoPSTK("632", tdau, tcuoi, 1) - SoPSTK("521", tdau, tcuoi, 1) + SoPSTK("64", tdau, tcuoi, 1))
        rptFrom.SetFormulas("Ma151", SoPSTK("421", tdau, tcuoi, 1))
        Dim TyLe As String = FrmGetStr.GetString(Ngonngu("Thuế suất Thuế TNDN (%)", "Corporate income tax rate (%)"), My.Application.Info.ProductName, ConvertToStrSafe(25))
        If IsNumeric(TyLe) Then
            rptFrom.SetFormulas("ma17", ConvertToDblSafe(TyLe))
        Else
            rptFrom.SetFormulas("ma17", 0)
        End If

        rptFrom.ReportWindowState = System.Windows.Forms.FormWindowState.Maximized
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub InQTTTN1(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim i, j As Integer
        Dim ps As Double
        Recycle(String.Format("{0}\temp\QTTNDN.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\REPORTS\QTTNDN.XLS", pCurDir), String.Format("{0}\TEMP\QTTNDN.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\QTTNDN.XLS", pCurDir))
        xlsheet = xlapp.Worksheets(1)
        On Error GoTo 0
        xlsheet.Cells(5, 1) = String.Format("{0}{1}", xlsheet.Cells(5, 1), ThoiGianTheoThang(tdau, tcuoi))
        xlsheet.Cells(7, 1) = String.Format("{0}{1}", (xlsheet.Cells(7, 1)), frmMain._LbCty_8.Text)
        xlsheet.Cells(8, 1) = String.Format("{0}{1}", (xlsheet.Cells(8, 1)), pTenCty)
        xlsheet.Cells(9, 1) = String.Format("{0}{1}", (xlsheet.Cells(9, 1)), frmMain._LbCty_2.Text)
        xlsheet.Cells(10, 1) = String.Format("{0}{1}Tỉnh, thành phố: {2}", (xlsheet.Cells(10, 1)), frmMain._LbCty_10.Text, frmMain._LbCty_11.Text)
        xlsheet.Cells(11, 1) = String.Format("{0}{1}                 Fax: {2}                 Email: {3}", _
                                   (xlsheet.Cells(11, 1)), _
                                   frmMain._LbCty_3.Text, _
                                   frmMain._LbCty_4.Text, _
                                   frmMain._LbCty_9.Text)
        For i = 15 To 120
            j = 7
            ps = 0
            Do While Strings.Len(xlsheet.Cells(i, j)) > 0
                If Strings.Len(xlsheet.Cells(i, 6)) > 0 Then
                    ps = ps + PSDu(xlsheet.Cells(i, 6), xlsheet.Cells(i, j), tdau, tcuoi) - PSDu(xlsheet.Cells(i, j), xlsheet.Cells(i, 6), tdau, tcuoi)
                Else
                    ps += SoPSTK(xlsheet.Cells(i, j), tdau, tcuoi, 1)
                End If
                xlsheet.Cells(i, 5) = ps
                j += 1
            Loop
        Next
        ps = SoDuTKSH("4211", ThangTruoc(tdau), -1)
        If ps > 0 Then xlsheet.Cells(i, 5) = ps
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        xlsheet = Nothing
        xlapp = Nothing
        CallExcel("\temp\QTTNDN.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="shtkcp"></param>
    ''' <param name="dg"></param>
    ''' <remarks></remarks>
    Private Sub InCTChiphi(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef shtkcp As String, ByRef dg As String)
        Dim sqlnx As New StringBuilder
        Dim sqln As New StringBuilder
        GauGe.Maximum = 3
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            If sqln.Length = 0 Then
                sqln.Append(String.Format("No_{0}", i))
            Else
                sqln.Append(String.Format(" + No_{0}", i))
            End If
        Next
        For i As Integer = 1 To CThangDB2(tcuoi)
            If sqlnx.Length = 0 Then
                sqlnx.Append(String.Format("No_{0}", i))
            Else
                sqlnx.Append(String.Format(" + No_{0}", i))
            End If
        Next
        GauGe.Value = 1
        ExecSQLNonQuery("UPDATE HethongTK SET KC_N = 0, KC_C = 0")
        Dim RsTk As DataTable = ExecSQLReturnDT(String.Format("SELECT DISTINCT HethongTK.MaSo, SUM(CASE WHEN({0}) THEN ChungTu.SoPS ELSE 0 END) AS GTru1, SUM(CASE WHEN({1}) THEN ChungTu.SoPS ELSE 0 END ) AS GTru2  FROM HethongTK INNER JOIN ChungTu ON HethongTK.MaSo = ChungTu.MaTkCo WHERE HethongTK.SoHieu LIKE '{2}%' AND ChungTu.MaLoai < 3 GROUP BY HethongTK.MaSo", _
                                                    WThang("ThangCT", tdau, tcuoi), _
                                                    WThang("ThangCT", 0, tcuoi), _
                                                    shtkcp))
        For Each rsTkItem As DataRow In RsTk.Rows
            ExecSQLNonQuery(String.Format("UPDATE HethongTK SET KC_N = {0}, KC_C = {1} WHERE MaSo = {2}", _
                                CStr(ConvertToDblSafe(rsTkItem("GTru1"))), _
                                CStr(ConvertToDblSafe(rsTkItem("GTru2"))), _
                                rsTkItem("MaSo")))
        Next
        RsTk = ExecSQLReturnDT(String.Format("SELECT DISTINCT HethongTK.MaSo, SUM(CASE WHEN ({0}) THEN ChungTu.SoPS ELSE 0 END) AS GTru1, SUM(CASE WHEN ({1}) THEN ChungTu.SoPS ELSE 0 END) AS GTru2  FROM (HethongTK INNER JOIN ChungTu ON HethongTK.MaSo = ChungTu.MaTkNo) INNER JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo WHERE HethongTK.SoHieu LIKE '{2}%' AND ChungTu.MaLoai = 3 AND LEFT(TK.SoHieu,1)='9' GROUP BY HethongTK.MaSo", _
                                   WThang("ThangCT", tdau, tcuoi), _
                                   WThang("ThangCT", 0, tcuoi), _
                                   shtkcp))
        For Each rsTkItem As DataRow In RsTk.Rows
            ExecSQLNonQuery(String.Format("UPDATE HethongTK SET KC_N = KC_N + {0}, KC_C = KC_C + {1} WHERE MaSo = {2}", _
                               CStr(ConvertToDblSafe(rsTkItem("GTru1"))), _
                                CStr(ConvertToDblSafe(rsTkItem("GTru2"))), _
                                rsTkItem("MaSo")))
        Next
        CongDonKC(False)
        QTongHopCT = (String.Format("SELECT DISTINCT SoHieu, (Cap) AS FirstOfCap, (Ten{0}) AS FirstOfTen, (Kieu) AS FirstOfKieu, (Loai) AS FirstOfLoai, (MaTC = MaSo) AS FirstOfChuanLa, (CapDuoi) AS CD, Sum({1} - KC_N) AS PsNo, Sum({2} - KC_C) AS PsNoX FROM HeThongTK GROUP BY SoHieu Having (SoHieu LIKE '{3}%' AND SoHieu <> '{3}')", (IIf(pNN > 0, "E", String.Empty)), sqln, sqlnx, shtkcp))
        GauGe.Value = 2
        rptFrom.InitForm("THCPQL.RPT", QTongHopCT, "QTongHopCT")

        XDCapTK(shtkcp)

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        rptFrom.SetFormulas("TenBaoCao", String.Format("'{0}'", dg))
        GauGe.Value = 3
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="shtk"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function InTongHopPhi(ByRef shtk As String, ByRef tdau As Integer, ByRef tcuoi As Integer) As Boolean
        Dim result As Boolean = False
        Dim i As Integer
        Dim st As New StringBuilder
        Dim sql As String = String.Format("SELECT DISTINCT TK.SoHieu AS SHC FROM {0} WHERE (HethongTK.SoHieu LIKE '{1}%') AND {2} AND SoPS<>0  GROUP BY TK.SoHieu HAVING Sum(ChungTu.SoPS)<>0", ChungTu2TKNC(10), shtk, WThang("ThangCT", tdau, tcuoi))
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        If rs.Rows.Count = 0 Then
            result = False
        Else
            st = New StringBuilder("Sum(")
            Dim isFirst As Boolean = True
            For i = CThangDB2(tdau) To CThangDB2(tcuoi)
                If isFirst Then
                    isFirst = False
                    st.Append(String.Format("HethongTK.No_{0}", i))
                Else
                    st.Append(String.Format("+HethongTK.No_{0}", i))
                End If
            Next
            st.Append(")<>0")
            sql = String.Format("SELECT DISTINCT HethongTK.SoHieu AS SHN,(HethongTK.Cap) AS CapCP,(HethongTK.TKCon) AS TKConCP,(HethongTK.Ten{0}) AS TenCP,TK.SoHieu AS SHC,Sum(ChungTu.SoPS) AS TPS FROM ((ChungTu INNER JOIN HethongTK AS TKN ON ChungTu.MaTKNo=TKN.MaSo) INNER JOIN HethongTK ON LEFT(TKN.SoHieu,Len(HethongTK.SoHieu)) = HethongTK.SoHieu) INNER JOIN HethongTK AS TK ON ChungTu.MaTKTCCo=TK.MaSo WHERE (HethongTK.SoHieu LIKE '{1}%') AND ((ChungTu.MaSo=null) OR ({2} AND SoPS<>0))  GROUP BY HethongTK.SoHieu,TK.SoHieu,HethongTK.Cap,HethongTK.TKCon,HethongTK.Ten,TK.SoHieu HAVING Sum(SoPS)<>0 OR (HethongTK.TKCon>0) AND {3}", _
                      IIf(pNN > 0, "E", String.Empty), _
                      shtk, _
                      WThang("ThangCT", tdau, tcuoi), _
                      st)
            Qsocai = (sql)
            rptFrom.InitForm("THCP.RPT", Qsocai, "Qsocai")

            For Each rsItem As DataRow In rs.Rows
                If i >= 10 Then
                    Exit For
                End If
                i += 1
                rptFrom.SetFormulas("TK" & CStr(i), rsItem("shc"))
            Next
            rptFrom.SetFormulas("SoHieuTK", String.Format("'{0}'", shtk))
            rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))

            RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
            result = True
        End If
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub ChiTietDoanhThu(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim st As String = String.Empty
        Dim sqlc As New StringBuilder
        Dim isFirst As Boolean = True
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            If isFirst Then
                isFirst = False
                sqlc.Append(String.Format("Co_{0}", i))
            Else
                sqlc.Append(String.Format("+Co_{0}", i))
            End If
        Next
        GauGe.Maximum = 2
        QTongHopCT = (String.Format("SELECT DISTINCT SoHieu, (Cap) AS FirstOfCap, (Ten{0}) AS FirstOfTen, (Kieu) AS FirstOfKieu, (Loai) AS FirstOfLoai, (MaTC = MaSo OR MaTC = 0) AS FirstOfChuanLa, Sum({1}) AS PsCo, (CapDuoi) AS CD FROM HeThongTK WHERE Cap>1 GROUP BY SoHieu Having (SoHieu LIKE '511%')", _
                          (IIf(pNN > 0, "E", String.Empty)), _
                          sqlc))
        GauGe.Value = 1
        rptFrom.InitForm("DOANHTHU.RPT", QTongHopCT, "QTongHopCT")

        XDCapTK("511")
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        rptFrom.SetFormulas("PSCo", SoPSTK("511", tdau, tcuoi, 1))
        GauGe.Value = 2
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub InCTKQKD(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim sql As String = String.Empty
        Dim kn As Double
        GauGe.Maximum = 4
        ExecSQLNonQuery("UPDATE KQKDCT SET KyNay = 0")
        Dim rs_lailo As DataTable = ExecSQLReturnDT("SELECT DISTINCT * FROM KQKDCT WHERE TKNo<>'0' AND TKCo<>'0' ORDER BY MaSo")
        For Each rsItem As DataRow In rs_lailo.Rows
            sql = String.Format("SELECT DISTINCT Sum(ChungTu.SoPS) AS F1 FROM (HeThongTK INNER JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo) INNER JOIN HeThongTK AS HeThongTK_1 ON ChungTu.MaTKCo = HeThongTK_1.MaSo WHERE HethongTK.SoHieu LIKE '{0}%' AND HethongTK_1.SoHieu LIKE '{1}%' AND {2}", _
                      rsItem("tkno"), _
                      rsItem("TkCo"), _
                      WThang("ThangCT", tdau, tcuoi))
            kn = ConvertToDblSafe(GetSelectValue(sql))
            sql = String.Format("SELECT DISTINCT Sum(ChungTu.SoPS) AS F1 FROM (HeThongTK INNER JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo) INNER JOIN HeThongTK AS HeThongTK_1 ON ChungTu.MaTKCo = HeThongTK_1.MaSo WHERE HethongTK_1.SoHieu LIKE '{0}%' AND HethongTK.SoHieu LIKE '{1}%' AND {2}", _
                      rsItem("tkno"), _
                      rsItem("TkCo"), _
                      WThang("ThangCT", tdau, tcuoi))
            kn = kn - ConvertToDblSafe(GetSelectValue(sql))
            If ConvertToDblSafe(rsItem("dau")) > 0 Then
                ExecSQLNonQuery(String.Format("UPDATE KQKDCT SET KyNay = {0} WHERE Ma={1}", _
                                    CStr(kn), _
                                    rsItem("ma")))
            Else
                ExecSQLNonQuery(String.Format("UPDATE KQKDCT SET KyNay = {0} WHERE Ma={1}", _
                                    CStr(-kn), _
                                    rsItem("ma")))
            End If
        Next
        GauGe.Value = 1
        rs_lailo = ExecSQLReturnDT("SELECT DISTINCT * FROM KQKDCT WHERE TKNo<>'0' AND TKCo='0' ORDER BY MaSo")
        For Each rsItem As DataRow In rs_lailo.Rows
            sql = String.Format("SELECT DISTINCT Sum(ChungTu.SoPS) AS F1 FROM HeThongTK INNER JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo WHERE HethongTK.SoHieu LIKE '{0}%' AND {1}", _
                      rsItem("tkno"), _
                      WThang("ThangCT", tdau, tcuoi))
            kn = ConvertToDblSafe(GetSelectValue(sql))
            If ConvertToDblSafe(rsItem("dau")) > 0 Then
                ExecSQLNonQuery(String.Format("UPDATE KQKDCT SET KyNay = {0} WHERE Ma={1}", _
                                    CStr(kn), _
                                    rsItem("ma")))
            Else
                ExecSQLNonQuery(String.Format("UPDATE KQKDCT SET KyNay = {0} WHERE Ma={1}", _
                                    CStr(-kn), _
                                    rsItem("ma")))
            End If
        Next
        rs_lailo = ExecSQLReturnDT("SELECT DISTINCT * FROM KQKDCT WHERE TKNo='0' AND TKCo<>'0' ORDER BY MaSo")
        For Each rsItem As DataRow In rs_lailo.Rows
            sql = String.Format("SELECT DISTINCT Sum(ChungTu.SoPS) AS F1 FROM HeThongTK INNER JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKCo WHERE HethongTK.SoHieu LIKE '{0}%' AND {1}", _
                      rsItem("TkCo"), _
                      WThang("ThangCT", tdau, tcuoi))
            kn = ConvertToDblSafe(GetSelectValue(sql))
            If ConvertToDblSafe(rsItem("dau")) > 0 Then
                ExecSQLNonQuery(String.Format("UPDATE KQKDCT SET KyNay = {0} WHERE Ma={1}", CStr(kn), rsItem("ma")))
            Else
                ExecSQLNonQuery(String.Format("UPDATE KQKDCT SET KyNay = {0} WHERE Ma={1}", CStr(-kn), rsItem("ma")))
            End If
        Next
        GauGe.Value = 2
        sql = "SELECT SUM(DuCo_0-DuNo_0) AS F1 FROM HethongTK WHERE SoHieu='4211'"
        kn = ConvertToDblSafe(GetSelectValue(sql))
        If kn < 0 Then ExecSQLNonQuery(String.Format("UPDATE KQKDCT SET KyNay= {0} WHERE MaSo=36", CStr(kn)))
        GauGe.Value = 1
        InKqkd(tdau, tcuoi, nn)
        kn = ConvertToDblSafe(GetSelectValue("SELECT Sum(KyNay) AS F1 FROM Kqkd WHERE MaSo=11 OR MaSo=24 OR MaSo=25 OR MaSo=22 OR MaSo=32"))
        kn = ConvertToDblSafe(kn - ConvertToDblSafe(GetSelectValue("SELECT Sum(KyNay) AS F1 FROM KqkdCT WHERE MaSo>=12 AND MaSo<20")))
        ExecSQLNonQuery(String.Format("UPDATE KQKDCT SET KyNay= {0} WHERE MaSo=20", CStr(kn)))
        ' Cong don
        rs_lailo = ExecSQLReturnDT("SELECT KyNay,MaSoCha FROM KQKDCT WHERE TongHop=0 And MaSoCha<>0 ORDER BY MaSo")
        For Each rsItem As DataRow In rs_lailo.Rows
            If ConvertToDblSafe(rsItem("masocha")) > 0 Then
                ExecSQLNonQuery(String.Format("UPDATE KQKDCT SET KyNay=KyNay+{0} WHERE MaSo={1}", _
                                    CStr(ConvertToDblSafe(rsItem("KyNay"))), _
                                    rsItem("masocha")))
            Else
                ExecSQLNonQuery(String.Format("UPDATE KQKDCT SET KyNay=KyNay-{0} WHERE MaSo={1}", _
                                    CStr(ConvertToDblSafe(rsItem("KyNay"))), _
                                    -ConvertToDblSafe(rsItem("masocha"))))
            End If
        Next
        rs_lailo = ExecSQLReturnDT("SELECT KyNay,MaSoCha FROM KQKDCT WHERE MaSo=16")
        If rs_lailo.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs_lailo.Rows(0)
            ExecSQLNonQuery(String.Format("UPDATE KQKDCT SET KyNay=KyNay+{0} WHERE MaSo=12", CStr(ConvertToDblSafe(rsItem("KyNay")))))
        End If
        rs_lailo = ExecSQLReturnDT("SELECT KyNay,MaSoCha FROM KQKDCT WHERE TongHop>0 And MaSoCha<>0 ORDER BY MaSo")
        For Each rsItem As DataRow In rs_lailo.Rows
            If ConvertToDblSafe(rsItem("masocha")) > 0 Then
                ExecSQLNonQuery(String.Format("UPDATE KQKDCT SET KyNay=KyNay+{0} WHERE MaSo={1}", _
                                    CStr(ConvertToDblSafe(rsItem("KyNay"))), _
                                    rsItem("masocha")))
            Else
                ExecSQLNonQuery(String.Format("UPDATE KQKDCT SET KyNay=KyNay-{0} WHERE MaSo={1}", _
                                    CStr(ConvertToDblSafe(rsItem("KyNay"))), _
                                    -ConvertToDblSafe(rsItem("masocha"))))
            End If
        Next
        GauGe.Value = 4
        rptFrom.InitForm("KQKDCT.RPT", "SELECT * FROM KQKDCT", "KQKDCT")

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("thang", pThangDauKy)
        rptFrom.SetFormulas("ThangCuoi", IIf(pThangDauKy = 1, 12, pThangDauKy - 1))
        rptFrom.SetFormulas("thangdauky", pThangDauKy)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub InPLKQKD(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim sql As String = String.Empty
        Dim kn As Double
        GauGe.Maximum = 2
        ExecSQLNonQuery("UPDATE PLKQKD SET sotien = 0")
        Dim rs_lailo As DataTable = ExecSQLReturnDT("SELECT DISTINCT sohieu,masopl FROM PLKQKD ORDER BY MaSoPL")
        For Each rsItem As DataRow In rs_lailo.Rows
            sql = String.Format("SELECT DISTINCT Sum(ChungTu.SoPS) AS F1 FROM HeThongTK INNER JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo WHERE HethongTK.SoHieu LIKE '{0}%' AND {1}", _
                      rsItem("SoHieu"), _
                      WThang("ThangCT", tdau, tcuoi))
            kn = ConvertToDblSafe(GetSelectValue(sql))
            If Strings.Left(ConvertToStrSafe(rsItem("SoHieu")), 3) = "635" Then
                sql = String.Format("SELECT DISTINCT Sum(ChungTu.SoPS) AS F1 FROM (HeThongTK INNER JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKCo ) inner join hethongtk t1 on chungtu.matkno=t1.maso WHERE t1.SoHieu LIKE '911%' AND HethongTK.SoHieu LIKE '{0}%' AND {1}", _
                          rsItem("SoHieu"), _
                          WThang("ThangCT", tdau, tcuoi))
                kn = ConvertToDblSafe(GetSelectValue(sql))
            End If
            ExecSQLNonQuery(String.Format("UPDATE PLKQKD SET sotien = {0} WHERE MaSoPL={1}", _
                                CStr(kn), _
                                rsItem("masopl")))
        Next
        GauGe.Value = 1
        ' Cong don
        rs_lailo = ExecSQLReturnDT("SELECT tkcha,sotien FROM PLKQKD WHERE tkcha>0 ORDER BY MaSopl")
        For Each rsItem As DataRow In rs_lailo.Rows
            If ConvertToDblSafe(rsItem("sotien")) > 0 Then
                ExecSQLNonQuery(String.Format("UPDATE PLKQKD SET sotien=sotien+{0} WHERE MaSopl={1}", _
                                    CStr(ConvertToDblSafe(rsItem("sotien"))), _
                                    rsItem("tkcha")))
            Else
                ExecSQLNonQuery(String.Format("UPDATE PLKQKD SET sotien=sotien-{0} WHERE MaSopl={1}", _
                                    CStr(ConvertToDblSafe(rsItem("sotien"))), _
                                    -ConvertToDblSafe(rsItem("tkcha"))))
            End If
        Next
        kn = ConvertToDblSafe(GetSelectValue("SELECT sotien as f1 FROM PLKQKD WHERE masopl=1"))
        kn = kn - ConvertToDblSafe(GetSelectValue("SELECT sotien as f1 FROM PLKQKD WHERE masopl=3"))
        kn += ConvertToDblSafe(GetSelectValue("SELECT sotien as f1 FROM PLKQKD WHERE masopl=8"))
        kn = kn - ConvertToDblSafe(GetSelectValue("SELECT sotien as f1 FROM PLKQKD WHERE masopl=9"))
        kn = kn - ConvertToDblSafe(GetSelectValue("SELECT sotien as f1 FROM PLKQKD WHERE masopl=13"))
        ExecSQLNonQuery(String.Format("UPDATE PLKQKD SET sotien={0} WHERE MaSopl=15", CStr(kn)))
        kn = ConvertToDblSafe(GetSelectValue("SELECT sotien as f1 FROM PLKQKD WHERE masopl=15"))
        kn += ConvertToDblSafe(GetSelectValue("SELECT sotien as f1 FROM PLKQKD WHERE masopl=18"))
        ExecSQLNonQuery(String.Format("UPDATE PLKQKD SET sotien={0} WHERE MaSopl=19", CStr(kn)))
        rs_lailo = Nothing
        GauGe.Value = 2
        rptFrom.InitForm("PLKQKD.RPT", "SELECT * FROM PLKQKD", "PLKQKD")

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        If tdau = pThangDauKy And tcuoi = ThangCuoiNamTC() Then
            rptFrom.SetFormulas("Nam", String.Format("'năm {0}'", pNamTC))
        Else
            If tdau = tcuoi Then
                rptFrom.SetFormulas("Nam", String.Format("'tháng {0}/{1}'", tdau, ConvertToStrSafe(pNamTC)))
            Else
                rptFrom.SetFormulas("Nam", String.Format("'từ {0}/{1} đến {2}/{1}'", tdau, ConvertToStrSafe(pNamTC), ConvertToStrSafe(tcuoi)))
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function InTongHopHD(ByRef tdau As Integer, ByRef tcuoi As Integer) As Boolean
        Dim result As Boolean = False
        Dim sql As String = String.Format("SELECT DISTINCT ChungTu.*,DoituongCT.*,HethongTK.SoHieu AS TKNo,TK.Sohieu AS TKCo,-1 AS ID,KhachHang.* FROM (((ChungTu INNER JOIN DoituongCT ON ChungTu.MaDT=DoituongCT.MaSo) LEFT JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo) INNER JOIN KhachHang ON DoituongCT.MaKhachHang=KhachHang.MaSo WHERE Not((TK.SoHieu LIKE '{0}%' OR TK.TK_ID={1})) AND ({2}) AND ChungTu.MaDT>1 UNION SELECT DISTINCT ChungTu.*,DoituongCT.*,HethongTK.SoHieu AS TKNo,TK.Sohieu AS TKCo,1 AS ID,KhachHang.* FROM (((ChungTu INNER JOIN DoituongCT ON ChungTu.MaDT=DoituongCT.MaSo) LEFT JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo) INNER JOIN KhachHang ON DoituongCT.MaKhachHang=KhachHang.MaSo WHERE {2} AND ((TK.SoHieu LIKE '{0}%' OR TK.TK_ID={1} OR ((HethongTK.SoHieu LIKE '11%') AND (Not TK.SoHieu LIKE '331%')))) AND MaDT>1", _
                                vatr, _
                                ConvertToStrSafe(TKDT_ID), _
                                WThang("ThangCT", tdau, tcuoi))
        QNhatKy = (sql)
        rptFrom.InitForm("BKHD.RPT", QNhatKy, "QNhatKy")
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        Return True
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InBCTCN()
        QChitiet = ("SELECT DISTINCT t1.ten,t1.ngaysinh,t1.phai,t1.cmnd,t1.ngaycap,t6.ten as noicap,t1.diachict,t2.ten as phuongxa,t3.ten as quanhuyen,t4.ten as tinhtp,t5.ten as quocgia FROM quocgia t5 inner join (tinhtp t4 inner join (quanhuyen t3 inner join (phuongxa t2 inner join (quanlynhanvien t1 inner join tinhtp t6 on t1.noicap=t6.maso) on t2.maso=t1.phuongxact) on t3.maso=t1.quanhuyenct) on t4.maso=t1.tinhtpct) on t5.maso=t1.quoctich")
        rptFrom.InitForm("DSTTNCN.RPT", QChitiet, "QChitiet")

        rptFrom.ReportWindowTitle = "Danh sách cá nhân đăng ký thuế thu nhập"
        rptFrom.SetFormulas("Dienthoai", String.Format("'{0}'", frmMain._LbCty_3.Text))
        rptFrom.SetFormulas("Email", String.Format("'{0}'", frmMain._LbCty_9.Text))
        rptFrom.SetFormulas("CQT", String.Format("'Chi cục thuế quận/huyện {0}'", frmMain._LbCty_10.Text))
        rptFrom.SetFormulas("TinhTP", String.Format("'{0}'", frmMain._LbCty_11.Text))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InTKTCN()
        QChitiet = ("SELECT DISTINCT t1.ten,t1.ngaysinh,t1.phai,t1.tel1,t1.cmnd,t1.ngaycap,t6.ten as noicap,t1.diachict,t1.diachihk,t2.ten as phuongxact,t3.ten as quanhuyenct,t4.ten as tinhtpct,t5.ten as quocgia,t7.ten as phuongxahk,t8.ten as quanhuyenhk,t9.ten as tinhtphk FROM quocgia t5 inner join (tinhtp t4 inner join (quanhuyen t3 inner join (phuongxa t2 inner join (tinhtp t6 inner join (phuongxa t7 inner join (quanhuyen t8 inner join (tinhtp t9 inner join quanlynhanvien t1 on t9.maso=t1.tinhtphk) on t8.maso=t1.quanhuyenhk) on t7.maso=t1.phuongxahk) on t6.maso=t1.noicap) on t2.maso=t1.phuongxact) on t3.maso=t1.quanhuyenct) on t4.maso=t1.tinhtpct) on t5.maso=t1.quoctich")
        rptFrom.InitForm("TKTTNCN.RPT", QChitiet, "QChitiet")

        rptFrom.ReportWindowTitle = "Tờ khai thuế thu nhập cá nhân"
        rptFrom.SetFormulas("CQT", String.Format("'Chi cục thuế quận/huyện {0}'", frmMain._LbCty_10.Text))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub TKQTTNCN()
        Dim rs As DataTable
        Dim phuthuoc As Integer
        For i As Integer = 1 To 12
            rs = ExecSQLReturnDT(String.Format("SELECT manv,maso FROM bangluong WHERE thang={0}", i))
            For Each rsItem As DataRow In rs.Rows
                phuthuoc = ConvertToDblSafe((GetSelectValue(String.Format("SELECT count(manv) as f1 FROM giacanh WHERE manv={0} and left(tuthang,2) <=N'{1}' and left(denthang,2)>=N'{1}'", _
                                                                                rsItem("MaNV"), _
                                                                                (IIf(i < 10, String.Format("0{0}", i), ConvertToStrSafe(i)))))))
                ExecSQLNonQuery(String.Format("UPDATE bangluong set phuthuoc={0} WHERE maso={1}", _
                                    phuthuoc, _
                                    rsItem("MaSo")))
            Next
        Next

        Qtinhluong = ("SELECT nv.ten,nv.mst,nv.cmnd,bl.manv,bl.thang,bl.tongthunhap,bl.phuthuoc,tt.tuthien,tt.nhandao,tt.khuyenhoc,bl.thuephainop as nop FROM quanlynhanvien nv inner join (bangluong bl left join tuthien tt on (bl.manv=tt.manv and bl.thang=tt.thang)) on nv.maso=bl.manv")
        rptFrom.InitForm("QTTNCN.RPT", Qtinhluong, "Qtinhluong")

        rptFrom.SetFormulas("Diachi", String.Format("'{0}'", frmMain._LbCty_2.Text))
        rptFrom.SetFormulas("DienThoai", String.Format("'{0}'", frmMain._LbCty_3.Text))
        rptFrom.SetFormulas("Fax", String.Format("'{0}'", frmMain._LbCty_4.Text))
        rptFrom.SetFormulas("Email", String.Format("'{0}'", frmMain._LbCty_9.Text))
        rptFrom.SetFormulas("Tinh", String.Format("'{0}'", frmMain._LbCty_11.Text))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(pThangDauKy, IIf(pThangDauKy > 1, pThangDauKy - 1, 12))))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub BK05A()
        rptFrom.SetFormulas("Tinh", String.Format("'{0}'", frmMain._LbCty_11.Text))
        Dim tuthien, thuepn, luongkcn As Double
        Dim rs As DataTable = ExecSQLReturnDT("SELECT (sum(tongthunhap) + sum(bhxh) + sum(bhyt) + sum(bhtn)) as tn,sum(sothang) as pt,manv,max(tncn) as tncn,max(giacanh) as giacanh FROM bangluong group by manv")

        For Each rsItem As DataRow In rs.Rows
            tuthien = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(tuthien+nhandao+khuyenhoc) as f1 FROM tuthien WHERE manv={0}", rsItem("MaNV"))))
            luongkcn = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(lkcn) as f1 FROM luongkcn WHERE manv={0}", rsItem("MaNV"))))
            thuepn = thuephainopnam(ConvertToDblSafe(rsItem("tn")), ConvertToBytSafe(rsItem("tncn")), ConvertToBytSafe(rsItem("giacanh")), ConvertToBytSafe(rsItem("pt")), tuthien + luongkcn)
            ExecSQLNonQuery(String.Format("UPDATE bangluong set thuephainop1={0} WHERE manv={1}", thuepn, rsItem("MaNV")))
        Next

        QChitiet = ("SELECT bl.manv,bl.thang,bl.tongthunhap,bl.bhxh,bl.bhyt,bl.bhtn,bl.phuthuoc,bl.sothang,bl.thuephainop,tt.tuthien,tt.nhandao,tt.khuyenhoc,cn.lkcn,bl.thuephainop1 FROM (bangluong bl left join tuthien tt on (bl.manv=tt.manv and bl.thang=tt.thang))left join luongkcn cn on (bl.manv=cn.manv and bl.thang=cn.thang)")
        Qtinhluong = (String.Format("SELECT nv.ten,nv.mst,nv.cmnd,mt.manv,mt.thang,mt.tongthunhap,mt.bhxh,mt.bhyt,mt.bhtn,mt.phuthuoc,mt.sothang,mt.thuephainop,mt.tuthien,mt.nhandao,mt.khuyenhoc,mt.lkcn,mt.thuephainop1 FROM quanlynhanvien nv inner join ({0}) AS mt on nv.maso=mt.manv WHERE loaihd=1 or loaihd=2", QChitiet))
        rptFrom.InitForm("BKTN.RPT", Qtinhluong, "Qtinhluong")
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(pThangDauKy, IIf(pThangDauKy > 1, pThangDauKy - 1, 12))))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub BK05B()
        Qtinhluong = ("SELECT nv.ten,nv.mst,nv.cmnd,bl.manv,bl.thang,bl.tongthunhap,bl.phuthuoc,tt.tuthien,tt.nhandao,tt.khuyenhoc,tt.nop FROM quanlynhanvien nv inner join (bangluong bl left join tuthien tt on (bl.manv=tt.manv and bl.thang=tt.thang)) on nv.maso=bl.manv WHERE loaihd=3")
        rptFrom.InitForm("BKTNCT.RPT", Qtinhluong, "Qtinhluong")

        rptFrom.SetFormulas("Tinh", String.Format("'{0}'", frmMain._LbCty_11.Text))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(pThangDauKy, IIf(pThangDauKy > 1, pThangDauKy - 1, 12))))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="TK"></param>
    ''' <remarks></remarks>
    Private Sub ToKhaiTTDB(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef TK As ClsTaikhoan)
        GauGe.Maximum = 2
        Mientru = (String.Format("SELECT MaCT, (TyLe) AS TL FROM (ChungTu INNER JOIN HoaDon ON ChungTu.MaSo=HoaDon.MaSo) INNER JOIN HethongTK ON ChungTu.MaTKCo=HethongTK.MaSo  WHERE HoaDon.Loai=2 AND {0} AND HethongTK.SoHieu LIKE '{1}%' GROUP BY MaCT, TyLe", _
                       WThang("ThangCT", tdau, tcuoi), _
                       TK.sohieu))
        QNhatKy = (String.Format("SELECT Vattu.SoHieu,TenVattu,DonVi,Sum(SoPS2Co) AS Luong,Sum(SoPS) AS Tien,(TL) AS TyLe  FROM ((ChungTu INNER JOIN (" & Mientru & ") as MienTru ON ChungTu.MaCT=MienTru.MaCT) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN HethongTK ON ChungTu.MaTKCo=HethongTK.MaSo WHERE TK_ID={0} GROUP BY Vattu.SoHieu,TenVattu,DonVi,TL", TKDT_ID))
        GauGe.Value = 1
        QChitiet = (String.Format("SELECT MaCT FROM {0} WHERE MaLoai=8 AND {1} AND TK_ID={2} GROUP BY MaCT", _
                        ChungTu2TKNC(-1), _
                        WThang("ThangCT", tdau, tcuoi), _
                        ConvertToStrSafe(TKDT_ID)))
        If ConvertToDblSafe(GetSelectValue(String.Format("SELECT QChitiet.MaCT AS F1 FROM (" & Mientru & ") as MienTru INNER JOIN ({0}) AS QChitiet ON MienTru.MaCT=QChitiet.MaCT", QChitiet))) > 0 Then
            rptFrom.InitForm("TOKHAIDB.RPT", QNhatKy, "QNhatKy")
        Else
            rptFrom.InitForm("TOKHAID2.RPT", QNhatKy, "QNhatKy")
        End If
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))
        rptFrom.SetFormulas("MSThue", String.Format("'{0}'", frmMain._LbCty_8.Text))
        Dim st As String = ConvertToStrSafe(CThangDB2(ThangTruoc(tdau)))
        rptFrom.SetFormulas("KT", ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(DuCo_{0}-DuNo_{0}) AS F1 FROM HethongTK WHERE TKCon=0 AND TK_ID={1} AND SoHieu LIKE '{2}%'", _
                                                                                                 st, _
                                                                                                 ConvertToStrSafe(TTDB_ID), _
                                                                                                 TK.sohieu))))
        Dim kn As Double = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(DuCo_{0}-DuNo_{1}) AS F1 FROM HethongTK WHERE TKCon=0 AND TK_ID={2} AND SoHieu LIKE '{3}%'", _
                                                               CThangDB2(tcuoi), _
                                                               ConvertToStrSafe(CThangDB2(tcuoi)), _
                                                               ConvertToStrSafe(TTDB_ID), _
                                                               TK.sohieu)))
        rptFrom.SetFormulas("KN", kn)
        rptFrom.SetFormulas("BC", String.Format("'{0} đồng'", ToVNText(kn)))
        rptFrom.SetFormulas("TThue", ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM (ChungTu INNER JOIN HoaDon ON ChungTu.MaSo=HoaDon.MaSo) INNER JOIN HethongTK ON ChungTu.MaTKCo=HethongTK.MaSo  WHERE HoaDon.Loai=2 AND {0} AND HethongTK.SoHieu LIKE '{1}%'", _
                                                                                                    WThang("ThangCT", tdau, tcuoi), _
                                                                                                    TK.sohieu))))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="saukc"></param>
    ''' <remarks></remarks>
    Private Sub InBCTC48(ByRef tdau As Integer, ByRef tcuoi As Integer, Optional ByRef saukc As Boolean = True)
        Dim st As String = String.Empty
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        Dim a, B As Double
        CreateChungTuTruocTable()
        CreateDLNamTruocTable()
        GauGe.Maximum = 3
        SoDuTKCN2(ThangTruoc(tdau))
        SoDuTKCN2(tcuoi)
        If Not saukc Then XacdinhKC(tdau, tcuoi)
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            If sqln.Length Then
                sqln.Append(String.Format("HethongTk.No_{0}", i))
            Else
                sqln.Append(String.Format(" +HethongTk.No_{0}", i))
            End If
        Next
        st = ConvertToStrSafe(CThangDB2(tcuoi))
        GauGe.Value = 1
        QCdt = (String.Format("SELECT DISTINCT HeThongTK.SoHieu, HeThongTK.Cap, HeThongTK.Ten{0}, HeThongTK.Kieu, HeThongTK.Loai, HeThongTK.DuNo_{1} As DkNo, HeThongTK.DuCo_{2} As DkCo, {3} As PsNo, {4} As PsCo, KC_N, KC_C, {5} As CkNo, {6} As CkCo FROM HeThongTK WHERE ((HeThongTK.MaTC = 0 Or HethongTK.MaTC = HethongTK.MaSo) OR (TK_ID3 % 10 >= 1)) And (HeThongTK.Loai > 0)", _
                    (IIf(pNN > 0, "E", String.Empty)), _
                    CThangDB2(ThangTruoc(tdau)), _
                    ConvertToStrSafe(CThangDB2(ThangTruoc(tdau))), _
                    sqln, _
                    sqlc, _
                    (IIf(saukc, String.Format("HeThongTK.DuNo_{0}", st), "HethongTk.DuNo")), _
                    (IIf(saukc, String.Format("HeThongTK.DuCo_{0}", st), "HethongTk.DuCo"))))

        rptFrom.InitForm("TMBCTC.RPT", "SELECT * FROM License", "License")

        GauGe.Value = 2
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        If saukc Then
            rptFrom.SetFormulas("SauKc = TRUE")
        Else
            rptFrom.SetFormulas("SauKc = FALSE")
        End If
        Dim sql As String = String.Format("SELECT ckno FROM ({0}) As QCdt WHERE sohieu='111'", QCdt)
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Tienmatcuoinam = {0}", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(6) = "" Then rptFrom.SetFormulas("Tienmatcuoinam = 0")
        sql = String.Format("SELECT dkno FROM ({0}) As QCdt WHERE sohieu='111'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Tienmatdaunam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(7) = "" Then rptFrom.SetFormulas("Tienmatdaunam = 0")
        sql = String.Format("SELECT ckno FROM ({0}) As QCdt WHERE sohieu='112'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Tienguicuoinam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(8) = "" Then rptFrom.SetFormulas("Tienguicuoinam= 0")
        sql = String.Format("SELECT dkno FROM ({0}) As QCdt WHERE sohieu='112'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Tienguidaunam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(9) = "" Then rptFrom.SetFormulas("Tienguidaunam = 0")
        sql = String.Format("SELECT dkno FROM ({0}) As QCdt WHERE sohieu='121'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Tuongduongtiendaunam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(10) = "" Then rptFrom.SetFormulas("Tuongduongtiendaunam = 0")
        sql = String.Format("SELECT ckno FROM ({0}) As QCdt WHERE sohieu='121'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Tuongduongtiencuoinam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(11) = "" Then rptFrom.SetFormulas("Tuongduongtiencuoinam = 0")
        sql = String.Format("SELECT dkno FROM ({0}) As QCdt WHERE sohieu='152'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Nguyenlieudaunam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(12) = "" Then rptFrom.SetFormulas("Nguyenlieudaunam = 0")
        sql = String.Format("SELECT ckno FROM ({0}) As QCdt WHERE sohieu='152'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Nguyenlieucuoinam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(13) = "" Then rptFrom.SetFormulas("Nguyenlieucuoinam = 0")
        sql = String.Format("SELECT dkno FROM ({0}) As QCdt WHERE sohieu='153'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Dungcudaunam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(14) = "" Then rptFrom.SetFormulas("Dungcudaunam = 0")
        sql = String.Format("SELECT ckno FROM ({0}) As QCdt WHERE sohieu='153'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Dungcucuoinam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(15) = "" Then rptFrom.SetFormulas("Dungcucuoinam = 0")
        sql = String.Format("SELECT dkno FROM ({0}) As QCdt WHERE sohieu='154'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Chiphidodangdaunam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(16) = "" Then rptFrom.SetFormulas("Chiphidodangdaunam = 0")
        sql = String.Format("SELECT ckno FROM ({0}) As QCdt WHERE sohieu='154'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Chiphidodangcuoinam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(17) = "" Then rptFrom.SetFormulas("Chiphidodangcuoinam = 0")
        sql = String.Format("SELECT dkno FROM ({0}) As QCdt WHERE sohieu='155'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Thanhphamdaunam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(18) = "" Then rptFrom.SetFormulas("Thanhphamdaunam = 0")
        sql = String.Format("SELECT ckno FROM ({0}) As QCdt WHERE sohieu='155'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Thanhphamcuoinam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(19) = "" Then rptFrom.SetFormulas("Thanhphamcuoinam = 0")
        sql = String.Format("SELECT dkno FROM ({0}) As QCdt WHERE sohieu='156'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Hanghoadaunam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(20) = "" Then rptFrom.SetFormulas("Hanghoadaunam = 0")
        sql = String.Format("SELECT ckno FROM ({0}) As QCdt WHERE sohieu='156'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Hanghoacuoinam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(21) = "" Then rptFrom.SetFormulas("Hanghoacuoinam = 0")
        sql = String.Format("SELECT dkno FROM ({0}) As QCdt WHERE sohieu='157'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Hangguidaunam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(22) = "" Then rptFrom.SetFormulas("Hangguidaunam = 0")
        sql = String.Format("SELECT ckno FROM ({0}) As QCdt WHERE sohieu='157'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Hangguicuoinam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(23) = "" Then rptFrom.SetFormulas("Hangguicuoinam = 0")
        '********************************** Tài sản cố định ***************************************
        Dautanggiamcuoi = ("SELECT DISTINCT loaichungtu.sohieu as loai,cttaisan.ng_ns+cttaisan.ng_tbs+cttaisan.ng_cnk+cttaisan.ng_td as sops,cttaisan.cl_ns+cttaisan.cl_tbs+cttaisan.cl_cnk+cttaisan.cl_td as sopscl,taisan.sohieu FROM (loaichungtu inner join cttaisan on cttaisan.maloai=loaichungtu.maso) inner join taisan on cttaisan.mats=taisan.maso")
        '********************************** Tài sản cố định hữu hình *****************************************
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='LDKY' and left(sohieu,5)='21111'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Nhacuadaunam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(24) = "" Then rptFrom.SetFormulas("Nhacuadaunam = 0")
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='LDKY' and left(sohieu,5)='21112'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Maymocdaunam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(25) = "" Then rptFrom.SetFormulas("Maymocdaunam = 0")
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='LDKY' and left(sohieu,5)='21113'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Phuongtiendaunam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(26) = "" Then rptFrom.SetFormulas("Phuongtiendaunam = 0")
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='LDKY' and left(sohieu,5)='21114'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("TSHHkhacdaunam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(27) = "" Then rptFrom.SetFormulas("TSHHkhacdaunam = 0")
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='TANG' and left(sohieu,5)='21111'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Nhacuatang", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(28) = "" Then rptFrom.SetFormulas("Nhacuatang = 0")
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='TANG' and left(sohieu,5)='21112'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Maymoctang", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(29) = "" Then rptFrom.SetFormulas("Maymoctang = 0")
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='TANG' and left(sohieu,5)='21113'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Phuongtientang", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(30) = "" Then rptFrom.SetFormulas("Phuongtientang = 0")
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='TANG' and left(sohieu,5)='21114'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("TSHHkhactang", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(31) = "" Then rptFrom.SetFormulas("TSHHkhactang = 0")
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='GIAM' and left(sohieu,5)='21111'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Nhacuagiam", 0 - ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(32) = "" Then rptFrom.SetFormulas("Nhacuagiam = 0")
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='GIAM' and left(sohieu,5)='21112'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Maymocgiam", 0 - ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(33) = "" Then rptFrom.SetFormulas("Maymocgiam = 0")
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='GIAM' and left(sohieu,5)='21113'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Phuongtiengiam", 0 - ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='GIAM' and left(sohieu,5)='21114'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("TSHHkhacgiam", 0 - ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        '****************************** Tài sản cố định vô hình **************************************
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='LDKY' and left(sohieu,5)='21131'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("SDdatdaunam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='LDKY' and left(sohieu,5)='21132'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Phathanhdaunam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='LDKY' and left(sohieu,5)='21133'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Banquyendaunam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='LDKY' and left(sohieu,5)='21134'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("TSVHkhacdaunam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='TANG' and left(sohieu,5)='21131'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("SDdattang", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='TANG' and left(sohieu,5)='21132'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Phathanhtang", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='TANG' and left(sohieu,5)='21133'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Banquyentang", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='TANG' and left(sohieu,5)='21134'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("TSVHkhactang", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='GIAM' and left(sohieu,5)='21131'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("SDdatgiam", 0 - ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='GIAM' and left(sohieu,5)='21132'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Phathanhgiam", 0 - ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='GIAM' and left(sohieu,5)='21133'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Banquyengiam", 0 - ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops) FROM ({0}) As Dautanggiamcuoi  WHERE loai='GIAM' and left(sohieu,5)='21134'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("TSVHkhacgiam", 0 - ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT dkno FROM ({0}) As QCdt WHERE sohieu='1211'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Chungkhoandau", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT ckno FROM ({0}) As QCdt WHERE sohieu='1211'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Chungkhoancuoi", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT dkno FROM ({0}) As QCdt WHERE sohieu='1218'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Taichinhngandau", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT ckno FROM ({0}) As QCdt WHERE sohieu='1218'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Taichinhngancuoi", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT dkno FROM ({0}) As QCdt WHERE sohieu='2212'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Lienketdau", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT ckno FROM ({0}) As QCdt WHERE sohieu='2212'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Lienketcuoi", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT dkno FROM ({0}) As QCdt WHERE sohieu='2218'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Taichinhdaidau", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT ckno FROM ({0}) As QCdt WHERE sohieu='2218'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Taichinhdaicuoi", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT dkno FROM ({0}) As QCdt WHERE sohieu='2211'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Dongkiemsoatdau", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT ckno FROM ({0}) As QCdt WHERE sohieu='2211'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Dongkiemsoatcuoi", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT dkco,dkno FROM ({0}) As QCdt WHERE sohieu='3331'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then a = ConvertToDblSafe(rs.Rows(0)(0))
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(1))) Then a -= ConvertToDblSafe(rs.Rows(0)(1))
        End If
        sql = String.Format("SELECT dkco,dkno FROM ({0}) As QCdt WHERE sohieu='1331'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then B = ConvertToDblSafe(rs.Rows(0)(1))
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(1))) Then B -= ConvertToDblSafe(rs.Rows(0)(0))
        End If
        If a <> 0 And B = 0 Then rptFrom.SetFormulas("Giatrigiatangdau ", a)
        If a <> 0 And B <> 0 Then rptFrom.SetFormulas("Giatrigiatangdau", a - B)
        If a = 0 And B = 0 Then rptFrom.SetFormulas("Giatrigiatangdau", 0)
        If a = 0 And B <> 0 Then rptFrom.SetFormulas("Giatrigiatangdau", 0 - B)
        a = 0
        B = 0
        sql = String.Format("SELECT ckco,ckno FROM ({0}) As QCdt WHERE sohieu='3331'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then a = ConvertToDblSafe(rs.Rows(0)(0))
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(1))) Then a -= ConvertToDblSafe(rs.Rows(0)(1))
        End If
        sql = String.Format("SELECT ckco,ckno FROM ({0}) As QCdt WHERE sohieu='1331'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then B = ConvertToDblSafe(rs.Rows(0)(1))
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(1))) Then B -= ConvertToDblSafe(rs.Rows(0)(0))
        End If
        If a <> 0 And B = 0 Then rptFrom.SetFormulas("Giatrigiatangcuoi", a)
        If a <> 0 And B <> 0 Then rptFrom.SetFormulas("Giatrigiatangcuoi", a - B)
        If a = 0 And B = 0 Then rptFrom.SetFormulas("Giatrigiatangcuoi", 0)
        If a = 0 And B <> 0 Then rptFrom.SetFormulas("Giatrigiatangcuoi", 0 - B)
        a = 0 : B = 0
        sql = String.Format("SELECT dkco,dkno FROM ({0}) As QCdt WHERE sohieu='3332'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Tieuthudacbietdau", ConvertToDblSafe(rs.Rows(0)(0)) - ConvertToDblSafe(rs.Rows(0)(1)))
        End If
        sql = String.Format("SELECT ckco,ckno FROM ({0}) As QCdt WHERE sohieu='3332'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Tieuthudacbietcuoi", ConvertToDblSafe(rs.Rows(0)(0)) - ConvertToDblSafe(rs.Rows(0)(1)))
        End If
        sql = String.Format("SELECT dkco,dkno FROM ({0}) As QCdt WHERE sohieu='3333'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Xuatnhapkhaudau", ConvertToDblSafe(rs.Rows(0)(0)) - ConvertToDblSafe(rs.Rows(0)(1)))
        End If
        sql = String.Format("SELECT ckco,ckno FROM ({0}) As QCdt WHERE sohieu='3333'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Xuatnhapkhaucuoi", ConvertToDblSafe(rs.Rows(0)(0)) - ConvertToDblSafe(rs.Rows(0)(1)))
        End If
        sql = String.Format("SELECT dkco,dkno FROM ({0}) As QCdt WHERE sohieu='3334'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Thunhapdoanhnghiepdau", ConvertToDblSafe(rs.Rows(0)(0)) - ConvertToDblSafe(rs.Rows(0)(1)))
        End If
        sql = String.Format("SELECT ckco,ckno FROM ({0}) As QCdt WHERE sohieu='3334'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Thunhapdoanhnghiepcuoi", ConvertToDblSafe(rs.Rows(0)(0)) - ConvertToDblSafe(rs.Rows(0)(1)))
        End If
        sql = String.Format("SELECT dkco,dkno FROM ({0}) As QCdt WHERE sohieu='3335'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Thunhapcanhandau", ConvertToDblSafe(rs.Rows(0)(0)) - ConvertToDblSafe(rs.Rows(0)(1)))
        End If
        sql = String.Format("SELECT ckco,ckno FROM ({0}) As QCdt WHERE sohieu='3335'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Thunhapcanhancuoi", ConvertToDblSafe(rs.Rows(0)(0)) - ConvertToDblSafe(rs.Rows(0)(1)))
        End If
        sql = String.Format("SELECT dkco,dkno FROM ({0}) As QCdt WHERE sohieu='3336'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Tainguyendau", ConvertToDblSafe(rs.Rows(0)(0)) - ConvertToDblSafe(rs.Rows(0)(1)))
        End If
        sql = String.Format("SELECT ckco,ckno FROM ({0}) As QCdt WHERE sohieu='3336'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Tainguyencuoi", ConvertToDblSafe(rs.Rows(0)(0)) - ConvertToDblSafe(rs.Rows(0)(1)))
        End If
        sql = String.Format("SELECT dkco,dkno FROM ({0}) As QCdt WHERE sohieu='3337'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Nhadatdau", ConvertToDblSafe(rs.Rows(0)(0)) - ConvertToDblSafe(rs.Rows(0)(1)))
        End If
        sql = String.Format("SELECT ckco,ckno FROM ({0}) As QCdt WHERE sohieu='3337'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Nhadatcuoi", ConvertToDblSafe(rs.Rows(0)(0)) - ConvertToDblSafe(rs.Rows(0)(1)))
        End If
        sql = String.Format("SELECT dkco,dkno FROM ({0}) As QCdt WHERE sohieu='3338'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Thuekhacdau", ConvertToDblSafe(rs.Rows(0)(0)) - ConvertToDblSafe(rs.Rows(0)(1)))
        End If
        sql = String.Format("SELECT ckco,ckno FROM ({0}) As QCdt WHERE sohieu='3338'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Thuekhaccuoi", ConvertToDblSafe(rs.Rows(0)(0)) - ConvertToDblSafe(rs.Rows(0)(1)))
        End If
        sql = String.Format("SELECT dkco,dkno FROM ({0}) As QCdt WHERE sohieu='3339'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Lephidau", ConvertToDblSafe(rs.Rows(0)(0)) - ConvertToDblSafe(rs.Rows(0)(1)))
        End If
        sql = String.Format("SELECT ckco,ckno FROM ({0}) As QCdt WHERE sohieu='3339'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Lephicuoi", ConvertToDblSafe(rs.Rows(0)(0)) - ConvertToDblSafe(rs.Rows(0)(1)))
        End If
        sql = String.Format("SELECT dkco-dkno FROM ({0}) As QCdt WHERE sohieu='4111'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Chusohuudau", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT psco FROM ({0}) As QCdt WHERE sohieu='4111'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Chusohuutang", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT psno FROM ({0}) As QCdt WHERE sohieu='4111'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Chusohuugiam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT ckco-ckno FROM ({0}) As QCdt WHERE sohieu='4111'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Chusohuucuoi", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT dkco-dkno FROM ({0}) As QCdt WHERE sohieu='4112'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Cophandau", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT psco FROM ({0}) As QCdt WHERE sohieu='4112'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Cophantang", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT psno FROM ({0}) As QCdt WHERE sohieu='4112'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Cophangiam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT ckco-ckno FROM ({0}) As QCdt WHERE sohieu='4112'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Cophancuoi", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT dkco-dkno FROM ({0}) As QCdt WHERE sohieu='3534'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("VonkhacCSHdau", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT psco FROM ({0}) As QCdt WHERE sohieu='3534'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("VonkhacCSHtang", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT psno FROM ({0}) As QCdt WHERE sohieu='3534'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("VonkhacCSHgiam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT ckco-ckno FROM ({0}) As QCdt WHERE sohieu='3534'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("VonkhacCSHcuoi", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT dkco-dkno FROM ({0}) As QCdt WHERE sohieu='419'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Cophieudau", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT psco FROM ({0}) As QCdt WHERE sohieu='419'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Cophieutang", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT psno FROM ({0}) As QCdt WHERE sohieu='419'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Cophieugiam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT ckco-ckno FROM ({0}) As QCdt WHERE sohieu='419'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Cophieucuoi", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT dkco-dkno FROM ({0}) As QCdt WHERE sohieu='413'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Tygiadau", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT psco FROM ({0}) As QCdt WHERE sohieu='413'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Tygiatang", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT psno FROM ({0}) As QCdt WHERE sohieu='413'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Tygiagiam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT ckco-ckno FROM ({0}) As QCdt WHERE sohieu='413'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Tygiacuoi", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT dkco-dkno FROM ({0}) As QCdt WHERE sohieu='353'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("QuyCSHdau", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT psco FROM ({0}) As QCdt WHERE sohieu='353'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("QuyCSHtang", ConvertToStrSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT psno FROM ({0}) As QCdt WHERE sohieu='353'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("QuyCSHgiam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT ckco-ckno FROM ({0}) As QCdt WHERE sohieu='353'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("QuyCSHcuoi", ConvertToStrSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT dkco-dkno FROM ({0}) As QCdt WHERE sohieu='421'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Chuaphanphoidau", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT psco FROM ({0}) As QCdt WHERE sohieu='421'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Chuaphanphoitang", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT psno FROM ({0}) As QCdt WHERE sohieu='421'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Chuaphanphoigiam", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT ckco-ckno FROM ({0}) As QCdt WHERE sohieu='421'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Chuaphanphoicuoi", ConvertToDblSafe(rs.Rows(0)(0)))
        Else
        End If
        sql = String.Format("SELECT sum(psco) FROM ({0}) As QCdt WHERE sohieu='5111' or sohieu='5112'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Banhangnay", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(108) = "" Then rptFrom.SetFormulas("Banhangnay = 0")
        sql = String.Format("SELECT psco FROM ({0}) As QCdt WHERE sohieu='5113'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Dichvunay", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT psco FROM ({0}) As QCdt WHERE sohieu='515'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Taichinhnay", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT psco FROM ({0}) As QCdt WHERE sohieu='5151'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Cotucnay", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT psco FROM ({0}) As QCdt WHERE sohieu='5152'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Dathuchiennay", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = "SELECT sum(t1.sops) FROM chungtu t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE left(t2.sohieu,3) = '152'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then a = ConvertToDblSafe(rs.Rows(0)(0))
        End If
        sql = "SELECT sum(t1.sops) FROM chungtu t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE left(t2.sohieu,3) = '156'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then B = rs.Rows(0)(0)
        End If
        sql = "SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso)inner join hethongtk t3 on t3.maso=t1.matkco WHERE left(t3.sohieu,3)='152' and (left(t2.sohieu,3)='111' or left(t2.sohieu,3)='112' or left(t2.sohieu,3)='131' or left(t2.sohieu,3)='141' or left(t2.sohieu,3)='331')"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Nguyenlieunay", a - ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(113) = "" Then rptFrom.SetFormulas("Nguyenlieunay =" & a)
        sql = "SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso)inner join hethongtk t3 on t3.maso=t1.matkco WHERE left(t3.sohieu,3)='156' and (left(t2.sohieu,3)='111' or left(t2.sohieu,3)='112' or left(t2.sohieu,3)='131' or left(t2.sohieu,3)='141' or left(t2.sohieu,3)='331')"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Hanghoanay", B - ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(39) = "" Then rptFrom.SetFormulas("Hanghoanay", B)
        a = 0
        B = 0
        sql = String.Format("SELECT psco FROM ({0}) As QCdt WHERE sohieu='334'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Nhancongnay", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT psco FROM ({0}) As QCdt WHERE sohieu='214'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Khauhaonay", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops) FROM chungtu t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE (matkno={0} or matkno={1}) and (left(t2.sohieu,3)='111' or left(t2.sohieu,3)='112' or left(t2.sohieu,3)='131' or left(t2.sohieu,3)='141' or left(t2.sohieu,3)='331')", Timten("maso", ConvertToStrSafe(6421), "sohieu", "hethongtk"), Timten("maso", ConvertToStrSafe(6422), "sohieu", "hethongtk"))
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Muangoainay", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(116) = "" Then rptFrom.SetFormulas("Muangoainay = 0")
        sql = String.Format("SELECT sum(psno) FROM ({0}) As QCdt WHERE sohieu='154' or sohieu='642'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Snay10", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(117) = "" Then rptFrom.SetFormulas("Snay10 = 0")
        sql = "SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE left(t2.sohieu,4)='5111' or left(t2.sohieu,4)='5112'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Banhangtruoc", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(118) = "" Then rptFrom.SetFormulas("Banhangtruoc = 0")
        sql = "SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE left(t2.sohieu,4)='5113'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Dichvutruoc", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = "SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE left(t2.sohieu,3)='515'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Taichinhtruoc", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = "SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE left(t2.sohieu,4)='5151'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Cotuctruoc", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = "SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE left(t2.sohieu,4)='5152'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Dathuchientruoc", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = "SELECT sum(t1.sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE left(t2.sohieu,3) = '152'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then a = ConvertToDblSafe(rs.Rows(0)(0))
        End If
        sql = "SELECT sum(t1.sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE left(t2.sohieu,3) = '156'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then B = rs.Rows(0)(0)
        End If
        sql = "SELECT sum(sops) FROM (chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso)inner join hethongtk t3 on t1.matkco=t3.maso WHERE left(t3.sohieu,3) = '152' and (left(t2.sohieu,3)='111' or left(t2.sohieu,3)='112' or left(t2.sohieu,3)='131' or left(t2.sohieu,3)='141' or left(t2.sohieu,3)='331')"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Nguyenlieutruoc", a - ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(123) = "" Then rptFrom.SetFormulas("Nguyenlieutruoc", a)
        sql = "SELECT sum(sops) FROM (chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso)inner join hethongtk t3 on t1.matkco=t3.maso WHERE left(t3.sohieu,3) = '156' and (left(t2.sohieu,3)='111' or left(t2.sohieu,3)='112' or left(t2.sohieu,3)='131' or left(t2.sohieu,3)='141' or left(t2.sohieu,3)='331')"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Hanghoatruoc", B - ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(150) = "" Then rptFrom.SetFormulas("Hanghoatruoc", B)
        a = 0 : B = 0
        sql = "SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE left(t2.sohieu,3)='334'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Nhancongtruoc", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = "SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE left(t2.sohieu,3)='214'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Khauhaotruoc", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE (matkno={0} or matkno={1}) and (left(t2.sohieu,3)='111' or left(t2.sohieu,3)='112' or left(t2.sohieu,3)='131' or left(t2.sohieu,3)='141' or left(t2.sohieu,3)='331')", Timten("maso", ConvertToStrSafe(6421), "sohieu", "hethongtk"), Timten("maso", ConvertToStrSafe(6422), "sohieu", "hethongtk"))
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Muangoaitruoc", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(126) = "" Then rptFrom.SetFormulas("Muangoaitruoc = 0")
        sql = "SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE left(t2.sohieu,3)='154' or left(sohieu,3)='642'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Struoc10", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(127) = "" Then rptFrom.SetFormulas("Struoc10 = 0")
        sql = String.Format("SELECT sum(sops) FROM chungtu t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE matkno={0} and left(t2.sohieu,3)='111'", Timten("maso", ConvertToStrSafe(13881), "sohieu", "hethongtk"))
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Khongkhautrunay", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(128) = "" Then rptFrom.SetFormulas("Khongkhautrunay = 0")
        sql = String.Format("SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE matkno={0} and left(t2.sohieu,3)='111'", Timten("maso", ConvertToStrSafe(13881), "sohieu", "hethongtk"))
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Khongkhautrutruoc", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(129) = "" Then rptFrom.SetFormulas("Khongkhautrutruoc = 0")
        sql = String.Format("SELECT dkno FROM ({0}) As QCdt WHERE sohieu='4212'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Solonay", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = "SELECT dkno FROM dlnamtruoc WHERE sohieutk='4212'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Solotruoc", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(psco) FROM ({0}) As QCdt WHERE sohieu='711' or sohieu='511' or sohieu='515'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then a = ConvertToDblSafe(rs.Rows(0)(0))
        End If
        sql = String.Format("SELECT sum(psno) FROM ({0}) As QCdt WHERE sohieu='521' or sohieu='632' or sohieu='635' or sohieu='642' or sohieu='811'", QCdt)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Loinhuantruocthuenay", a - ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(132) = "" Then rptFrom.SetFormulas("Loinhuantruocthuenay = 0")
        a = 0
        sql = "SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE left(t2.sohieu,3)='711' or left(t2.sohieu,3)='511' or left(t2.sohieu,3)='515'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then a = ConvertToDblSafe(rs.Rows(0)(0))
        End If
        sql = "SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE left(t2.sohieu,3)='521' or left(t2.sohieu,3)='632' or left(sohieu,3)='635' or left(t2.sohieu,3)='642' or left(t2.sohieu,3)='811'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("Loinhuantruocthuetruoc", a - ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        If rptFrom.GetFormulas(133) = "" Then rptFrom.SetFormulas("Loinhuantruocthuetruoc = 0")
        a = 0
        '*************** Tài sản cố định hữu hình ***********************
        sql = String.Format("SELECT sum(sops-sopscl) FROM ({0}) As Dautanggiamcuoi  WHERE left(sohieu,5)='21111' and loai='LDKY'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHNhacuadau", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops-sopscl) FROM ({0}) As Dautanggiamcuoi  WHERE left(sohieu,5)='21112' and loai='LDKY'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHMaymocdau", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops-sopscl) FROM ({0}) As Dautanggiamcuoi  WHERE left(sohieu,5)='21113' and loai='LDKY'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHPhuongtiendau", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops-sopscl) FROM ({0}) As Dautanggiamcuoi  WHERE left(sohieu,5)='21114' and loai='LDKY'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHTSHHkhacdau", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        '*********************** Tài sản cố định hữu hình ******************************
        sql = "SELECT min(thangct), max(thangct) FROM chungtu WHERE maloai=12"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then
                a = ConvertToDblSafe(rs.Rows(0)(0)) 'B = ConvertToDblSafe(rs.Rows(0)(1))
            End If
        End If
        SoDuDauCuoiKy = (String.Format("SELECT sum(kh_ns+kh_tbs+kh_cnk+kh_td) as khauhao,taisan.sohieu FROM taisan inner join thongso on taisan.maso=thongso.mats WHERE thang>={0} and thang<={1} and thang<={2} group by taisan.sohieu", a, ConvertToStrSafe(B), ConvertToStrSafe(tcuoi)))
        a = 0
        B = 0
        '*********************** Khấu hao tăng tài sản cố định hữu hình ******************************
        sql = "SELECT sum(khauhao) FROM SoDuDauCuoiKy WHERE left(sohieu,5)='21111'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHNhacuatang", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = "SELECT sum(khauhao) FROM SoDuDauCuoiKy WHERE left(sohieu,5)='21112'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHMaymoctang", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = "SELECT sum(khauhao) FROM SoDuDauCuoiKy WHERE left(sohieu,5)='21113'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHPhuongtientang", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = "SELECT sum(khauhao) FROM SoDuDauCuoiKy WHERE left(sohieu,5)='21114'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHTSHHkhactang", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        '*********************** Tài sản cố định vô hình ***************************
        sql = String.Format("SELECT sum(sops-sopscl) FROM ({0}) As Dautanggiamcuoi  WHERE left(sohieu,5)='21131' and loai='LDKY'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHSDdatdau", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops-sopscl) FROM ({0}) As Dautanggiamcuoi  WHERE left(sohieu,5)='21132' and loai='LDKY'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHPhathanhdau", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops-sopscl) FROM ({0}) As Dautanggiamcuoi  WHERE left(sohieu,5)='21133' and loai='LDKY'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHQuyendau", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops-sopscl) FROM ({0}) As Dautanggiamcuoi  WHERE left(sohieu,5)='21134' and loai='LDKY'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHTSVHkhacdau", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        '************************* Khấu hao tăng tài sản vô hình ****************************************
        sql = "SELECT sum(khauhao) FROM SoDuDauCuoiKy WHERE left(sohieu,5)='21131'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHSDdattang", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = "SELECT sum(khauhao) FROM SoDuDauCuoiKy WHERE left(sohieu,5)='21132'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHPhathanhtang", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = "SELECT sum(khauhao) FROM SoDuDauCuoiKy WHERE left(sohieu,5)='21133'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHQuyentang", ConvertToDblSafe(rs.Rows(0)(0)))
        End If
        sql = "SELECT sum(khauhao) FROM SoDuDauCuoiKy WHERE left(sohieu,5)='21134'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHTSVHkhactang = " & ConvertToStrSafe(rs.Rows(0)(0)))
        End If
        '**************************** Khấu hao giảm tài sản hữu hình *************************************
        sql = String.Format("SELECT sum(sops-sopscl) FROM ({0}) As Dautanggiamcuoi  WHERE left(sohieu,5)='21111' and left(loai,4)='GIAM'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHNhacuagiam", Math.Abs(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops-sopscl) FROM ({0}) As Dautanggiamcuoi  WHERE left(sohieu,5)='21112' and left(loai,4)='GIAM'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHMaymocgiam", Math.Abs(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops-sopscl) FROM ({0}) As Dautanggiamcuoi  WHERE left(sohieu,5)='21113' and left(loai,4)='GIAM'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHPhuongtiengiam", Math.Abs(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops-sopscl) FROM ({0}) As Dautanggiamcuoi  WHERE left(sohieu,5)='21114' and left(loai,4)='GIAM'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHTSHHkhacgiam", Math.Abs(rs.Rows(0)(0)))
        End If
        '**************************** Khấu hao giảm tài sản vô hình *************************************
        sql = String.Format("SELECT sum(sops-sopscl) FROM ({0}) As Dautanggiamcuoi  WHERE left(sohieu,5)='21131' and left(loai,4)='GIAM'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHSDdatgiam", Math.Abs(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops-sopscl) FROM ({0}) As Dautanggiamcuoi  WHERE left(sohieu,5)='21132' and left(loai,4)='GIAM'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHPhathanhgiam", Math.Abs(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops-sopscl) FROM ({0}) As Dautanggiamcuoi  WHERE left(sohieu,5)='21133' and left(loai,4)='GIAM'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHQuyengiam", Math.Abs(rs.Rows(0)(0)))
        End If
        sql = String.Format("SELECT sum(sops-sopscl) FROM ({0}) As Dautanggiamcuoi  WHERE left(sohieu,5)='21134' and left(loai,4)='GIAM'", Dautanggiamcuoi)
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then rptFrom.SetFormulas("KHTSVHkhacgiam", Math.Abs(rs.Rows(0)(0)))
        End If

        rptFrom.SetFormulas("Socongnhan", FrmGetStr.GetString(Ngonngu("Tổng số công nhân viên và người lao động: ", "Total number of employees and labor: "), My.Application.Info.ProductName))
        rptFrom.SetFormulas("DVTT", String.Format("'{0}'", FrmOptions.Combo(2).Text))
        rptFrom.SetFormulas("LVHD", String.Format("'{0}{1}{2}'", (IIf(frmMain.Chk(0).CheckState, Ngonngu("Thương mại -", "Commercial -"), String.Empty)), (IIf(frmMain.Chk(1).CheckState, Ngonngu(" Xây dựng -", " Construction -"), String.Empty)), (IIf(frmMain.Chk(3).CheckState, Ngonngu(" Sản xuất -", " Production -"), String.Empty))))
        rptFrom.SetFormulas("GTHTK", String.Format("'{0}{1}{2}{3}'", (IIf(FrmOptions.OptVT(0).Checked, Ngonngu(" Giá bình quân.", " Average"), String.Empty)), (IIf(FrmOptions.OptVT(1).Checked, Ngonngu(" Xuất đích danh.", "By name"), String.Empty)), (IIf(FrmOptions.OptVT(2).Checked, " FIFO.", String.Empty)), (IIf(FrmOptions.OptVT(3).Checked, " LIFO", String.Empty))))
        sql = "SELECT sum(sops) FROM chungtu t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE left(t2.sohieu,3)='155'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then
            End If
            a = ConvertToDblSafe(rs.Rows(0)(0))
        End If
        sql = "SELECT sum(sops) FROM chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE left(t2.sohieu,3)='155'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then B = rs.Rows(0)(0)
        End If
        If B <> 0 Then rptFrom.SetFormulas("Thamphamnay", ConvertToDblSafe((a / B)))
        If rptFrom.GetFormulas(163) = "" Then rptFrom.SetFormulas("Thamphamnay", 0)
        a = 0
        B = 0
        sql = "SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE left(t2.sohieu,3)='155'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then a = ConvertToDblSafe(rs.Rows(0)(0))
        End If
        sql = "SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE left(t2.sohieu,3)='155'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(ConvertToStrSafe(rs.Rows(0)(0))) Then B = rs.Rows(0)(0)
        End If
        If B <> 0 Then rptFrom.SetFormulas("Thamphamtruoc", ConvertToDblSafe((a / B)))
        If rptFrom.GetFormulas(164) = "" Then rptFrom.SetFormulas("Thamphamtruoc", 0)
        a = 0
        B = 0

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        GauGe.Value = 3
        Exit Sub
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="saukc"></param>
    ''' <remarks></remarks>
    Private Sub InBCTC(ByRef tdau As Integer, ByRef tcuoi As Integer, Optional ByRef saukc As Boolean = True)
        Dim j, Verx As Integer
        Dim ps, ps2 As Double
        Dim rs As DataTable
        Dim fn As String = String.Format("{0}\temp\{1}{2}{3}{4}{5}.XLS", _
                               pCurDir, _
                               (IIf(tdau < 10, "0", String.Empty)), _
                               ConvertToStrSafe(tdau), _
                               (IIf(tcuoi < 10, "0", String.Empty)), _
                               ConvertToStrSafe(tcuoi), _
                               ConvertToStrSafe(pNamTC Mod 100))
        If FileSystem.Dir(fn, FileAttribute.Normal).Length > 0 Then
            If MessageBox.Show(Ngonngu("Thuyết minh tài chính đã được lập, có cần lập lại ?", "Financial presentation has been established, making?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Error) = Windows.Forms.DialogResult.No Then
                GoTo MoTep
            Else
                Recycle(fn)
            End If
        End If
        'CreateChungTuTruocTable()
        'CreateDLNamTruocTable()
        On Error GoTo KetThuc
        pCurDir = Path.GetFullPath(My.Application.Info.DirectoryPath)
        File.Copy(String.Format("{0}\REPORTS\TMTC15.XLS", pCurDir), fn)
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(fn)
        xlsheet = xlapp.Worksheets(1)
        On Error GoTo 0
        xlsheet.Cells(1, 1) = pTenCty
        xlsheet.Cells(2, 1) = pMSTCty
        xlsheet.Cells(5, 1) = ThoiGianTheoThang(tdau, tcuoi)
        xlsheet.Cells(64, 7) = SoDuTKSH("111", tcuoi, -1)
        xlsheet.Cells(64, 8) = SoDuTKSH("111", ThangTruoc(tdau), -1)
        xlsheet.Cells(65, 7) = SoDuTKSH("112", tcuoi, -1)
        xlsheet.Cells(65, 8) = SoDuTKSH("112", ThangTruoc(tdau), -1)
        xlsheet.Cells(66, 7) = SoDuTKSH("113", tcuoi, -1)
        xlsheet.Cells(66, 8) = SoDuTKSH("113", ThangTruoc(tdau), -1)
        xlsheet.Cells(70, 7) = SoDuTKSH("121", tcuoi, -1)
        xlsheet.Cells(70, 8) = SoDuTKSH("121", ThangTruoc(tdau), -1)
        xlsheet.Cells(71, 7) = SoDuTKSH("128", tcuoi, -1)
        xlsheet.Cells(71, 8) = SoDuTKSH("128", ThangTruoc(tdau), -1)
        xlsheet.Cells(72, 7) = SoDuTKSH("129", tcuoi, -1)
        xlsheet.Cells(72, 8) = SoDuTKSH("129", ThangTruoc(tdau), -1)
        xlsheet.Cells(76, 7) = SoDuTKSH("1385", tcuoi, -1)
        xlsheet.Cells(76, 8) = SoDuTKSH("1385", ThangTruoc(tdau), -1)
        xlsheet.Cells(79, 7) = SoDuTKSH("1388", tcuoi, -1)
        xlsheet.Cells(79, 8) = SoDuTKSH("1388", ThangTruoc(tdau), -1)
        xlsheet.Cells(83, 7) = SoDuTKSH("151", tcuoi, -1)
        xlsheet.Cells(83, 8) = SoDuTKSH("151", ThangTruoc(tdau), -1)
        xlsheet.Cells(84, 7) = SoDuTKSH("152", tcuoi, -1)
        xlsheet.Cells(84, 8) = SoDuTKSH("152", ThangTruoc(tdau), -1)
        xlsheet.Cells(85, 7) = SoDuTKSH("153", tcuoi, -1)
        xlsheet.Cells(85, 8) = SoDuTKSH("153", ThangTruoc(tdau), -1)
        xlsheet.Cells(86, 7) = SoDuTKSH("154", tcuoi, -1)
        xlsheet.Cells(86, 8) = SoDuTKSH("154", ThangTruoc(tdau), -1)
        xlsheet.Cells(87, 7) = SoDuTKSH("155", tcuoi, -1)
        xlsheet.Cells(87, 8) = SoDuTKSH("155", ThangTruoc(tdau), -1)
        xlsheet.Cells(88, 7) = SoDuTKSH("1561", tcuoi, -1) + SoDuTKSH("1562", tcuoi, -1)
        xlsheet.Cells(88, 8) = SoDuTKSH("1561", ThangTruoc(tdau), -1) + SoDuTKSH("1562", ThangTruoc(tdau), -1)
        xlsheet.Cells(89, 7) = SoDuTKSH("157", tcuoi, -1)
        xlsheet.Cells(89, 8) = SoDuTKSH("157", ThangTruoc(tdau), -1)
        xlsheet.Cells(90, 7) = SoDuTKSH("158", tcuoi, -1)
        xlsheet.Cells(90, 8) = SoDuTKSH("158", ThangTruoc(tdau), -1)
        xlsheet.Cells(91, 7) = SoDuTKSH("1567", tcuoi, -1)
        xlsheet.Cells(91, 8) = SoDuTKSH("1567", ThangTruoc(tdau), -1)
        For i As Integer = 1 To 9
            xlsheet.Cells(97 + i, 7) = SoDuTKSH(String.Format("333{0}", i), tcuoi, -1)
            xlsheet.Cells(97 + i, 8) = SoDuTKSH(String.Format("333{0}", i), ThangTruoc(tdau), -1)
            xlsheet.Cells(244 + i, 7) = SoDuTKSH(String.Format("333{0}", i), tcuoi, 1)
            xlsheet.Cells(244 + i, 8) = SoDuTKSH(String.Format("333{0}", i), ThangTruoc(tdau), 1)
            If i < 9 Then
                xlsheet.Cells(263 + i, 7) = SoDuTKSH(String.Format("338{0}", i), tcuoi, 1)
                xlsheet.Cells(263 + i, 8) = SoDuTKSH(String.Format("338{0}", i), ThangTruoc(tdau), 1)
            End If
        Next
        xlsheet.Cells(110, 7) = SoDuTKSH("244", tcuoi, -1)
        xlsheet.Cells(110, 8) = SoDuTKSH("244", ThangTruoc(tdau), -1)
        For i As Integer = 1 To 6
            xlsheet.Cells(120, i + 1) = SoDuTKSH(String.Format("211{0}", (IIf(i = 6, 8, i))), ThangTruoc(tdau), -1)
            rs = ExecSQLReturnDT(String.Format("SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t3 on t1.matkco=t3.maso WHERE left(t2.sohieu,4)='211{0}' and (left(t3.sohieu,3)='111' or left(t3.sohieu,3)='112' or left(t3.sohieu,3)='331')", (IIf(i = 6, 8, i))))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(121, i + 1) = ConvertToStrSafe(rsItem(0))
            End If
            rs = ExecSQLReturnDT(String.Format("SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t3 on t1.matkco=t3.maso WHERE left(t2.sohieu,4)='211{0}' and left(t3.sohieu,3)='241'", (IIf(i = 6, 8, i))))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(122, i + 1) = ConvertToStrSafe(rsItem(0))
            End If
            rs = ExecSQLReturnDT(String.Format("SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t3 on t1.matkco=t3.maso WHERE left(t2.sohieu,4)='211{0}' and left(t3.sohieu,3)<>'111' and left(t3.sohieu,3)<>'112' and left(t3.sohieu,3)<>'331' and left(t3.sohieu,3)<>'241'", (IIf(i = 6, 8, i))))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(123, i + 1) = ConvertToStrSafe(rsItem(0))
            End If
            rs = ExecSQLReturnDT(String.Format("SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkco=t2.maso) inner join hethongtk t3 on t1.matkno=t3.maso WHERE left(t2.sohieu,4)='211{0}' and left(t3.sohieu,3)='217'", (IIf(i = 6, 8, i))))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(124, i + 1) = ConvertToStrSafe(rsItem(0))
            End If
            rs = ExecSQLReturnDT(String.Format("SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkco=t2.maso) inner join hethongtk t3 on t1.matkno=t3.maso WHERE left(t2.sohieu,4)='211{0}' and left(t3.sohieu,3)='811'", (IIf(i = 6, 8, i))))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(125, i + 1) = ConvertToStrSafe(rsItem(0))
            End If
            rs = ExecSQLReturnDT(String.Format("SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkco=t2.maso) inner join hethongtk t3 on t1.matkno=t3.maso WHERE left(t2.sohieu,4)='211{0}' and left(t3.sohieu,3)<>'217' and left(t3.sohieu,3)<>'811'", (IIf(i = 6, 8, i))))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(126, i + 1) = ConvertToStrSafe(rsItem(0))
            End If
            xlsheet.Cells(129, i + 1) = SoDuTKSH(String.Format("211{0}", (IIf(i = 6, 8, i))), ThangTruoc(tdau), 1)
            xlsheet.Cells(148, i + 1) = SoDuTKSH(String.Format("212{0}", (IIf(i = 6, 8, i))), ThangTruoc(tdau), -1)
            xlsheet.Cells(151, i + 1) = SoPSTK(String.Format("212{0}", (IIf(i = 6, 8, i))), tdau, tcuoi, -1)
            xlsheet.Cells(153, i + 1) = SoPSTK(String.Format("212{0}", (IIf(i = 6, 8, i))), tdau, tcuoi, 1)
            xlsheet.Cells(156, i + 1) = SoDuTKSH(String.Format("212{0}", (IIf(i = 6, 8, i))), ThangTruoc(tdau), 1)
        Next
        For i As Integer = 1 To 7
            xlsheet.Cells(173, i + 1) = SoDuTKSH(String.Format("213{0}", (IIf(i = 7, 8, i))), ThangTruoc(tdau), -1)
            xlsheet.Cells(177, i + 1) = SoPSTK(String.Format("213{0}", (IIf(i = 7, 8, i))), tdau, tcuoi, -1)
            xlsheet.Cells(179, i + 1) = SoPSTK(String.Format("213{0}", (IIf(i = 7, 8, i))), tdau, tcuoi, 1)
            xlsheet.Cells(182, i + 1) = SoDuTKSH(String.Format("213{0}", (IIf(i = 7, 8, i))), ThangTruoc(tdau), 1)
        Next
        xlsheet.Cells(131, 8) = SoPSTK("2141", tdau, tcuoi, 1)
        xlsheet.Cells(134, 8) = SoPSTK("2141", tdau, tcuoi, -1)
        xlsheet.Cells(159, 8) = SoPSTK("2142", tdau, tcuoi, 1)
        xlsheet.Cells(161, 8) = SoPSTK("2142", tdau, tcuoi, -1)
        xlsheet.Cells(184, 9) = SoPSTK("2143", tdau, tcuoi, 1)
        xlsheet.Cells(186, 9) = SoPSTK("2143", tdau, tcuoi, -1)
        xlsheet.Cells(196, 7) = SoDuTKSH("241", tcuoi, -1)
        xlsheet.Cells(196, 8) = SoDuTKSH("241", ThangTruoc(tdau), -1)
        xlsheet.Cells(204, 3) = SoDuTKSH("217", ThangTruoc(tdau), -1)
        xlsheet.Cells(204, 4) = SoPSTK("217", tdau, tcuoi, -1)
        xlsheet.Cells(204, 5) = SoPSTK("217", tdau, tcuoi, 1)
        xlsheet.Cells(204, 6) = SoDuTKSH("217", tcuoi, -1)
        xlsheet.Cells(209, 3) = SoDuTKSH("2147", ThangTruoc(tdau), 1)
        xlsheet.Cells(209, 4) = SoPSTK("217", tdau, tcuoi, 1)
        xlsheet.Cells(209, 5) = SoPSTK("217", tdau, tcuoi, -1)
        xlsheet.Cells(209, 6) = SoDuTKSH("217", tcuoi, 1)
        xlsheet.Cells(224, 7) = SoDuTKSH("2281", tcuoi, -1)
        xlsheet.Cells(224, 8) = SoDuTKSH("2281", ThangTruoc(tdau), -1)
        xlsheet.Cells(225, 7) = SoDuTKSH("2282", tcuoi, -1)
        xlsheet.Cells(225, 8) = SoDuTKSH("2282", ThangTruoc(tdau), -1)
        xlsheet.Cells(228, 7) = SoDuTKSH("2288", tcuoi, -1)
        xlsheet.Cells(228, 8) = SoDuTKSH("2288", ThangTruoc(tdau), -1)
        xlsheet.Cells(236, 7) = SoDuTKSH("242", tcuoi, -1)
        xlsheet.Cells(236, 8) = SoDuTKSH("242", ThangTruoc(tdau), -1)
        xlsheet.Cells(240, 7) = SoDuTKSH("311", tcuoi, 1)
        xlsheet.Cells(240, 8) = SoDuTKSH("311", ThangTruoc(tdau), 1)
        xlsheet.Cells(241, 7) = SoDuTKSH("315", tcuoi, 1)
        xlsheet.Cells(241, 8) = SoDuTKSH("315", ThangTruoc(tdau), 1)
        xlsheet.Cells(260, 7) = SoDuTKSH("335", tcuoi, 1)
        xlsheet.Cells(260, 8) = SoDuTKSH("335", ThangTruoc(tdau), 1)
        xlsheet.Cells(281, 7) = SoDuTKSH("341", tcuoi, 1)
        xlsheet.Cells(281, 8) = SoDuTKSH("341", ThangTruoc(tdau), 1)
        xlsheet.Cells(285, 7) = SoDuTKSH("342", tcuoi, 1)
        xlsheet.Cells(285, 8) = SoDuTKSH("342", ThangTruoc(tdau), 1)
        xlsheet.Cells(303, 7) = SoDuTKSH("243", tcuoi, -1)
        xlsheet.Cells(303, 8) = SoDuTKSH("243", ThangTruoc(tdau), -1)
        xlsheet.Cells(307, 7) = SoDuTKSH("347", tcuoi, 1)
        xlsheet.Cells(307, 8) = SoDuTKSH("347", ThangTruoc(tdau), 1)
        For i As Integer = 2 To 9
            xlsheet.Cells(314, i) = SoDuTKSH(xlsheet.Cells(312, i).value, ThangTruoc(tdau), 1)
            rs = ExecSQLReturnDT(String.Format("SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE left(t2.sohieu,{0})='{1}'", Strings.Len(xlsheet.Cells(312, i).value), xlsheet.Cells(312, i).value))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(315, i) = ConvertToStrSafe(rsItem(0))
            End If
            rs = ExecSQLReturnDT(String.Format("SELECT sum(sops) FROM (chungtutruoc t1 inner join hethongtk t2 on t1.matkco=t2.maso) inner join hethongtk t3 on t1.matkno=t3.maso WHERE left(t2.sohieu,{0})='{1}' and left(t3.sohieu,4)='4212'", Strings.Len(xlsheet.Cells(312, i).value), xlsheet.Cells(312, i).value))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(316, i) = ConvertToStrSafe(rsItem(0))
            End If
            rs = ExecSQLReturnDT(String.Format("SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE left(t2.sohieu,{0})='{1}'", Strings.Len(xlsheet.Cells(312, i).value), xlsheet.Cells(312, i).value))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(318, i) = ConvertToStrSafe(rsItem(0))
            End If
            rs = ExecSQLReturnDT("SELECT sum(sops) FROM (chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t3 on t1.matkco=t3.maso WHERE left(t2.sohieu," & Strings.Len(xlsheet.Cells(312, i).value) & ")='" & xlsheet.Cells(312, i).value & "' and left(t3.sohieu,4)='4212'")
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(319, i) = ConvertToStrSafe(rsItem(0))
            End If
            rs = ExecSQLReturnDT(String.Format("SELECT sum(sops) FROM chungtu t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE left(t2.sohieu,{0})='{1}'", Strings.Len(xlsheet.Cells(312, i).value), xlsheet.Cells(312, i).value))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(322, i) = ConvertToStrSafe(rsItem(0))
            End If
            rs = ExecSQLReturnDT("SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkco=t2.maso) inner join hethongtk t3 on t1.matkno=t3.maso WHERE left(t2.sohieu," & Strings.Len(xlsheet.Cells(312, i).value) & ")='" & xlsheet.Cells(312, i).value & "' and left(t3.sohieu,4)='4212'")
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(323, i) = ConvertToStrSafe(rsItem(0))
            End If
            rs = ExecSQLReturnDT(String.Format("SELECT sum(sops) FROM chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE left(t2.sohieu,{0})='{1}'", Strings.Len(xlsheet.Cells(312, i).value), xlsheet.Cells(312, i).value))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(325, i) = ConvertToStrSafe(rsItem(0))
            End If
            rs = ExecSQLReturnDT(String.Format("SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t3 on t1.matkco=t3.maso WHERE left(t2.sohieu,{0})='{1}' and left(t3.sohieu,4)='4212'", Strings.Len(xlsheet.Cells(312, i).value), xlsheet.Cells(312, i).value))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(326, i) = ConvertToStrSafe(rsItem(0))
            End If
        Next
        xlsheet.Cells(331, 7) = SoDuTKSH("347", tcuoi, 1)
        xlsheet.Cells(331, 8) = SoDuTKSH("347", ThangTruoc(tdau), 1)
        xlsheet.Cells(386, 7) = SoPSTK("511", tdau, tcuoi, 1)
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE left(t2.sohieu,3)='511'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(386, 8) = ConvertToStrSafe(rsItem(0))
        End If
        xlsheet.Cells(388, 7) = SoPSTK("5111", tdau, tcuoi, 1) + SoPSTK("5112", tdau, tcuoi, 1)
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE (left(t2.sohieu,4)='5111' or left(t2.sohieu,4)='5112')")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(388, 8) = ConvertToStrSafe(rsItem(0))
        End If
        xlsheet.Cells(389, 7) = SoPSTK("5113", tdau, tcuoi, 1)
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE left(t2.sohieu,4)='5113'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(389, 8) = ConvertToStrSafe(rsItem(0))
        End If
        xlsheet.Cells(396, 7) = SoPSTK("521", tdau, tcuoi, -1)
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE left(t2.sohieu,3)='521'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(396, 8) = ConvertToStrSafe(rsItem(0))
        End If
        xlsheet.Cells(397, 7) = SoPSTK("532", tdau, tcuoi, -1)
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE left(t2.sohieu,3)='532'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(397, 8) = ConvertToStrSafe(rsItem(0))
        End If
        xlsheet.Cells(398, 7) = SoPSTK("531", tdau, tcuoi, -1)
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE left(t2.sohieu,3)='531'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(398, 8) = ConvertToStrSafe(rsItem(0))
        End If
        xlsheet.Cells(400, 7) = SoPSTK("3332", tdau, tcuoi, -1)
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE left(t2.sohieu,4)='3332'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(400, 8) = ConvertToStrSafe(rsItem(0))
        End If
        xlsheet.Cells(401, 7) = SoPSTK("3333", tdau, tcuoi, -1)
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE left(t2.sohieu,4)='3333'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(401, 8) = ConvertToStrSafe(rsItem(0))
        End If
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t3 on t1.matkco=t3.maso WHERE left(t2.sohieu,3)='632' and (left(t3.sohieu,4)='1561' or left(t3.sohieu,4)='1562')")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(409, 7) = ConvertToStrSafe(rsItem(0))
        End If
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM (chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t3 on t1.matkco=t3.maso WHERE left(t2.sohieu,3)='632' and (left(t3.sohieu,4)='1561' or left(t3.sohieu,4)='1562')")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(409, 8) = ConvertToStrSafe(rsItem(0))
        End If
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t3 on t1.matkco=t3.maso WHERE left(t2.sohieu,3)='632' and left(t3.sohieu,3)='155'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(410, 7) = ConvertToStrSafe(rsItem(0))
        End If
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM (chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t3 on t1.matkco=t3.maso WHERE left(t2.sohieu,3)='632' and left(t3.sohieu,3)='155'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(410, 8) = ConvertToStrSafe(rsItem(0))
        End If
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t3 on t1.matkco=t3.maso WHERE left(t2.sohieu,3)='632' and left(t3.sohieu,3)<>'155' and left(t3.sohieu,4)<>'1561' and left(t3.sohieu,4)<>'1562' and left(t3.sohieu,4)<>'1567'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(411, 7) = ConvertToStrSafe(rsItem(0))
        End If
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM (chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t3 on t1.matkco=t3.maso WHERE left(t2.sohieu,3)='632' and left(t3.sohieu,3)<>'155' and left(t3.sohieu,4)<>'1561' and left(t3.sohieu,4)<>'1562' and left(t3.sohieu,4)<>'1567'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(411, 8) = ConvertToStrSafe(rsItem(0))
        End If
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t3 on t1.matkco=t3.maso WHERE left(t2.sohieu,3)='632' and left(t3.sohieu,4)='1567'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(412, 7) = ConvertToStrSafe(rsItem(0))
        End If
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM (chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t3 on t1.matkco=t3.maso WHERE left(t2.sohieu,3)='632' and left(t3.sohieu,4)='1567'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(412, 8) = ConvertToStrSafe(rsItem(0))
        End If
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t3 on t1.matkco=t3.maso WHERE left(t2.sohieu,3)='632' and left(t3.sohieu,4)='1381'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(414, 7) = ConvertToStrSafe(rsItem(0))
        End If
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM (chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t3 on t1.matkco=t3.maso WHERE left(t2.sohieu,3)='632' and left(t3.sohieu,4)='1381'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(414, 8) = ConvertToStrSafe(rsItem(0))
        End If
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t3 on t1.matkco=t3.maso WHERE left(t2.sohieu,3)='632' and left(t3.sohieu,3)='159'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(416, 7) = ConvertToStrSafe(rsItem(0))
        End If
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM (chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t3 on t1.matkco=t3.maso WHERE left(t2.sohieu,3)='632' and left(t3.sohieu,3)='159'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(416, 8) = ConvertToStrSafe(rsItem(0))
        End If
        xlsheet.Cells(428, 7) = SoPSTK("515", tdau, tcuoi, 1)
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE left(t2.sohieu,3)='515'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(428, 8) = ConvertToStrSafe(rsItem(0))
        End If
        xlsheet.Cells(439, 7) = SoPSTK("635", tdau, tcuoi, -1)
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE left(t2.sohieu,3)='635'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(439, 8) = ConvertToStrSafe(rsItem(0))
        End If
        xlsheet.Cells(455, 7) = SoPSTK("621", tdau, tcuoi, -1) + SoPSTK("6272", tdau, tcuoi, -1) + SoPSTK("6273", tdau, tcuoi, -1)
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE (left(t2.sohieu,3)='621' or left(t2.sohieu,4)='6272' or left(t2.sohieu,4)='6273')")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(455, 8) = ConvertToStrSafe(rsItem(0))
        End If
        xlsheet.Cells(456, 7) = SoPSTK("622", tdau, tcuoi, -1) + SoPSTK("6271", tdau, tcuoi, -1)
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE (left(t2.sohieu,3)='622' or left(t2.sohieu,4)='6271')")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(456, 8) = ConvertToStrSafe(rsItem(0))
        End If
        xlsheet.Cells(457, 7) = SoPSTK("6274", tdau, tcuoi, -1)
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE left(t2.sohieu,4)='6274'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(457, 8) = ConvertToStrSafe(rsItem(0))
        End If
        xlsheet.Cells(458, 7) = SoPSTK("6277", tdau, tcuoi, -1)
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE left(t2.sohieu,4)='6277'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(458, 8) = ConvertToStrSafe(rsItem(0))
        End If
        xlsheet.Cells(459, 7) = SoPSTK("6278", tdau, tcuoi, -1)
        rs = ExecSQLReturnDT("SELECT sum(sops) FROM chungtutruoc t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE left(t2.sohieu,4)='6278'")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then xlsheet.Cells(459, 8) = ConvertToStrSafe(rsItem(0))
        End If
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        xlsheet = Nothing
        xlapp = Nothing
MoTep:
        CallExcel(String.Format("\temp\{0}{1}{2}{3}{4}.XLS", _
                      (IIf(tdau < 10, "0", String.Empty)), _
                      ConvertToStrSafe(tdau), _
                      (IIf(tcuoi < 10, "0", String.Empty)), _
                      ConvertToStrSafe(tcuoi), _
                      ConvertToStrSafe(pNamTC Mod 100)))
KetThuc:
    End Sub
    'Private Sub InLCTT2(ByRef tdau As Integer, ByRef tcuoi As Integer)
    '    Dim sql As String = String.Empty
    '    Dim kt, kn, a, maso As Double
    '    GauGe.Maximum = 4
    '    ExecSQLNonQuery("UPDATE LCTT SET KyTruoc = 0, KyNay = 0")
    '    Dim rs_lailo As DataTable = ExecSQLReturnDT("SELECT DISTINCT * FROM LCTT WHERE TKNo<>'0' AND TKCo<>'0' ORDER BY MaSo")
    '    For Each rsItem As DataRow In rs_lailo.Rows
    '        sql = String.Format("SELECT DISTINCT Sum(CASE WHEN {0} THEN ChungTu.SoPS ELSE 0 END) AS F1, Sum(CASE WHEN ({1}) THEN ChungTu.SoPS ELSE 0 END) AS F2 FROM (HeThongTK INNER JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo) INNER JOIN HeThongTK AS HeThongTK_1 ON ChungTu.MaTKCo = HeThongTK_1.MaSo WHERE HethongTK.SoHieu LIKE '{2}%' AND HethongTK_1.SoHieu LIKE '{3}%' AND {4}", _
    '                  WThang2("ThangCT", 0, tdau), _
    '                  WThang("ThangCT", tdau, 0), _
    '                  rsItem("tkno"), _
    '                  rsItem("TkCo"), _
    '                  WThang("ThangCT", 0, tcuoi))
    '        kt = ConvertToDblSafe(GetSelectValue(sql, kn))
    '        If ConvertToDblSafe(rsItem("dau")) > 0 Then
    '            ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc={0}, KyNay = {1} WHERE Ma={2}", _
    '                                CStr(kt), _
    '                                CStr(kn), _
    '                                rsItem("ma")))
    '        Else
    '            ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc={0}, KyNay = {1} WHERE Ma={2}", _
    '                                CStr(-kt), _
    '                                CStr(-kn), _
    '                                rsItem("ma")))
    '        End If
    '    Next
    '    GauGe.Value = 2

    '    maso = 3
    '    rs_lailo = ExecSQLReturnDT("SELECT DISTINCT * FROM LCTT WHERE MaSo=" + CStr(maso))
    '    a = 0
    '    For Each rsItem As DataRow In rs_lailo.Rows
    '        a = a - SoPSTK(rsItem("tkno"), tdau, tcuoi, 1)
    '    Next
    '    ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyNay = {0} WHERE MaSo=" + CStr(maso), CStr(a)))
    '    ' maso = 5
    '    kn = SoPSTK("511", tdau, tcuoi, 1) - SoPSTK("521", tdau, tcuoi, 1)
    '    kn = kn - SoPSTK("632", tdau, tcuoi, 1) + SoPSTK("5213", tdau, tcuoi, 1) + SoPSTK("515", tdau, tcuoi, 1)
    '    kn = kn - SoPSTK("635", tdau, tcuoi, 1) - SoPSTK("64", tdau, tcuoi, 1)
    '    kn = kn + SoPSTK("711", tdau, tcuoi, 1) - SoPSTK("811", tdau, tcuoi, 1)
    '    SoDuTK(ConvertToDblSafe(Timten("maso", "4211", "sohieu", "hethongtk")), 0, a, kt)
    '    If a > kn Then a = kn
    '    If a < 0 Then a = 0
    '    a = (kn - a) * 0.25
    '    If a < 0 Then a = 0
    '    a = a * 0.3
    '    kn = a - SoPSTK("3334", tdau, tcuoi, -1)
    '    ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyNay = {0} WHERE MaSo=5", CStr(kn)))
    '    ' maso = 7
    '    kt = -SoPSTK("333", pThangDauKy, ThangTruoc(tdau), -1) + SoPSTK("3334", pThangDauKy, ThangTruoc(tdau), 1) + SoPSTK("133", pThangDauKy, ThangTruoc(tdau), 1)
    '    kn = -SoPSTK("333", tdau, tcuoi, -1) + SoPSTK("3334", tdau, tcuoi, 1) + SoPSTK("133", tdau, tcuoi, 1)
    '    ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc={0}, KyNay = {1} WHERE MaSo=7", CStr(kt), CStr(kn)))
    '    ' maso = 1
    '    SoDuTK(ConvertToDblSafe(Timten("maso", "131", "sohieu", "HethongTk")), 0, kt, a)
    '    SoDuTK(ConvertToDblSafe(Timten("maso", "131", "sohieu", "HethongTk")), tcuoi, kn, a)
    '    kn = SoPSTK("511", tdau, tcuoi, 1) - SoPSTK("521", tdau, tcuoi, 1) - SoPSTK("531", tdau, tcuoi, 1) + SoPSTK("33311", tdau, tcuoi, 1) - kn + kt
    '    kt = SoPSTK("511", pThangDauKy, ThangTruoc(tdau), 1) - SoPSTK("521", pThangDauKy, ThangTruoc(tdau), 1) - SoPSTK("531", pThangDauKy, ThangTruoc(tdau), 1) + SoPSTK("33311", pThangDauKy, ThangTruoc(tdau), 1) - kt
    '    ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc={0}, KyNay={1} WHERE MaSo=1", CStr(kt), CStr(kn)))
    '    ' maso = 6
    '    kt = SoPSTK("133112", pThangDauKy, ThangTruoc(tdau), 1) + SoPSTK("133212", pThangDauKy, ThangTruoc(tdau), 1) + SoPSTK("244", pThangDauKy, ThangTruoc(tdau), -1)
    '    kn = SoPSTK("133112", tdau, tcuoi, 1) + SoPSTK("133212", tdau, tcuoi, 1) + SoPSTK("244", tdau, tcuoi, -1)
    '    ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc={0}, KyNay = {1} WHERE MaSo=6", CStr(kt), CStr(kn)))
    '    maso = 21
    '    rs_lailo = ExecSQLReturnDT("SELECT DISTINCT * FROM LCTT WHERE MaSo=" + CStr(maso))
    '    a = 0
    '    For Each rsItem As DataRow In rs_lailo.Rows
    '        a = a - SoPSTK(rsItem("tkno"), tdau, tcuoi, -1)
    '    Next
    '    ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyNay = {0} WHERE MaSo=" + CStr(maso), CStr(a)))

    '    ' maso = 60
    '    sql = String.Format("SELECT SUM(DuNo_{0}-DuCo_{1}) AS F1,SUM(DuNo_0-DuCo_0) AS F2 FROM HethongTK WHERE SoHieu='111' OR SoHieu='112'", CThangDB2(ThangTruoc(tdau)), ConvertToStrSafe(CThangDB2(ThangTruoc(tdau))))
    '    kn = ConvertToDblSafe(GetSelectValue(sql, kt))
    '    ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc = {0}, KyNay = {1} WHERE MaSo=60", CStr(IIf(tdau > pThangDauKy, kt, 0)), CStr(kn)))
    '    ' maso = 31
    '    ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyNay = {0} WHERE MaSo=31", CStr(SoPSTK("411", tdau, tcuoi, 1))))
    '    ' maso = 2
    '    kt = -(SoDuTKSH("111", 0, -1) + SoDuTKSH("112", 0, -1) + SoDuTKSH("113", 0, -1)) + ConvertToDblSafe(GetSelectValue("SELECT Sum(KyTruoc) AS F1 FROM LCTT WHERE MaSo=1 OR MaSo=3 OR MaSo=4 OR MaSo=5 OR MaSo=6 OR MaSo=7 OR MaSo=21 OR MaSo=22 OR MaSo=23 OR MaSo=24 OR MaSo=25 OR MaSo=26 OR MaSo=27 OR MaSo=31 OR MaSo=32 OR MaSo=33 OR MaSo=34 OR MaSo=35 OR MaSo=36"))
    '    kn = (SoDuTKSH("111", 0, -1) + SoDuTKSH("112", 0, -1) + SoDuTKSH("113", 0, -1)) - (SoDuTKSH("111", tcuoi, -1) + SoDuTKSH("112", tcuoi, -1) + SoDuTKSH("113", tcuoi, -1)) + ConvertToDblSafe(GetSelectValue("SELECT Sum(KyNay) AS F1 FROM LCTT WHERE MaSo=1 OR MaSo=3 OR MaSo=4 OR MaSo=5 OR MaSo=6 OR MaSo=7 OR MaSo=21 OR MaSo=22 OR MaSo=23 OR MaSo=24 OR MaSo=25 OR MaSo=26 OR MaSo=27 OR MaSo=31 OR MaSo=32 OR MaSo=33 OR MaSo=34 OR MaSo=35 OR MaSo=36"))
    '    ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc={0}, KyNay = {1} WHERE MaSo=2", CStr(-kt), CStr(-kn)))
    '    GauGe.Value = 3
    '    ' Cong don
    '    rs_lailo = ExecSQLReturnDT("SELECT KyTruoc,KyNay,MaSoCha,Dau FROM LCTT WHERE TongHop=0 And MaSoCha<>0 ORDER BY MaSoCha,MaSo")
    '    Dim macha As Integer = 0
    '    For Each rsItem As DataRow In rs_lailo.Rows
    '        If macha <> Math.Abs(rsItem("masocha")) Then
    '            macha = Math.Abs(rsItem("masocha"))
    '            ExecSQLNonQuery("update lctt set kytruoc=0, kynay=0 where maso = " + CStr(macha))
    '        End If
    '        ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc=KyTruoc+{0},KyNay=KyNay+{1} WHERE MaSo={2}", _
    '                            CStr(ConvertToDblSafe(rsItem("kytruoc"))), _
    '                            CStr(ConvertToDblSafe(rsItem("kynay"))), _
    '                            rsItem("masocha")))
    '    Next
    '    rs_lailo = Nothing
    '    kn = GetSelectValue("select sum(kynay) as f1, sum(kytruoc) as f2 from LCTT where masocha=50", kt)
    '    ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc={0},KyNay={1} WHERE MaSo=50", _
    '                    CStr(kt), _
    '                    CStr(kn)))
    '    kn = GetSelectValue("select sum(kynay) as f1, sum(kytruoc) as f2 from LCTT where masocha=70", kt)
    '    ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc={0},KyNay={1} WHERE MaSo=70", _
    '                    CStr(kt), _
    '                    CStr(kn)))
    '    GauGe.Value = 4

    '    rptFrom.InitForm("LCTT.RPT", "SELECT * FROM LCTT", "LCTT")

    '    RptSetDate(NgayCuoiThang(pNamTC, tcuoi))

    '    rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
    '    rptFrom.SetFormulas("Thang", tdau)
    'End Sub

    Private Function LayDieuKienTaiKhoan(ByVal dsTaiKhoan As String, Optional ByVal httk As String = "") As String
        Dim res As String = String.Empty
        Try
            Dim array As String() = dsTaiKhoan.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            If (array.Length > 0) Then

                For index As Integer = 0 To array.Length - 1
                    If index = 0 Then
                        If httk <> String.Empty Then
                            res = res & String.Format(" HeThongTK_1.SoHieu LIKE '{0}%' ", array(index))
                        Else
                            res = res & String.Format(" HethongTK.SoHieu LIKE '{0}%' ", array(index))
                        End If

                    Else
                        If httk <> String.Empty Then
                            res = res & String.Format(" OR HeThongTK_1.SoHieu LIKE '{0}%' ", array(index))
                        Else
                            res = res & String.Format(" OR HethongTK.SoHieu LIKE '{0}%' ", array(index))
                        End If

                    End If
                Next
                Return " (" & res & ") "
            End If
        Catch ex As Exception
            Return String.Empty
        End Try
        Return String.Empty
    End Function

    Private Sub InLCTT2(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim sql As String = String.Empty
        Dim kt, kn As Double
        GauGe.Maximum = 4
        ExecSQLNonQuery("UPDATE LCTT SET KyTruoc = 0, KyNay = 0")
        Dim rs_lailo As DataTable = ExecSQLReturnDT("SELECT DISTINCT * FROM LCTT WHERE TKNo<>'0' AND TKCo<>'0' ORDER BY MaSo")
        For Each rsItem As DataRow In rs_lailo.Rows
            sql = String.Format("SELECT DISTINCT Sum(CASE WHEN {0} THEN ChungTu.SoPS ELSE 0 END) AS F1, Sum(CASE WHEN ({1}) THEN ChungTu.SoPS ELSE 0 END) AS F2 FROM (HeThongTK INNER JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo) INNER JOIN HeThongTK AS HeThongTK_1 ON ChungTu.MaTKCo = HeThongTK_1.MaSo WHERE {2} AND {3} AND {4}", _
                      WThang2("ThangCT", 0, tdau), _
                      WThang("ThangCT", tdau, tcuoi), _
                      LayDieuKienTaiKhoan(rsItem("tkno")), _
                      LayDieuKienTaiKhoan(rsItem("TkCo"), "HeThongTK_1"), _
                      WThang("ThangCT", 0, tcuoi))
            kt = ConvertToDblSafe(GetSelectValue(sql, kn))
            
            If ConvertToDblSafe(rsItem("dau")) > 0 Then
                ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc={0}, KyNay = {1} WHERE Ma={2}", _
                                    CStr(kt), _
                                    CStr(kn), _
                                    rsItem("ma")))
            Else
                ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc={0}, KyNay = {1} WHERE Ma={2}", _
                                    CStr(-kt), _
                                    CStr(-kn), _
                                    rsItem("ma")))
            End If
        Next
        GauGe.Value = 2
        ' maso = 2
        If tdau = pThangDauKy Then
            kt = (SoDuTKSH("111", 0, -1) + SoDuTKSH("112", 0, -1))
            ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc=KyTruoc+{0} WHERE MaSo=2 and ma >= all (SELECT Ma FROM LCTT WHERE MaSo=2)", CStr(kt)))
        End If
        GauGe.Value = 3
        ' Cong don
        rs_lailo = ExecSQLReturnDT("SELECT KyTruoc,KyNay,MaSoCha,Dau FROM LCTT WHERE TongHop=0 And MaSoCha<>0 ORDER BY MaSoCha,MaSo")
        Dim macha As Integer = 0
        For Each rsItem As DataRow In rs_lailo.Rows
            If macha <> Math.Abs(rsItem("masocha")) Then
                macha = Math.Abs(rsItem("masocha"))
                ExecSQLNonQuery("update lctt set kytruoc=0, kynay=0 where maso = " + CStr(macha))
            End If
            ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc=KyTruoc+{0},KyNay=KyNay+{1} WHERE MaSo={2}", _
                                CStr(ConvertToDblSafe(rsItem("kytruoc"))), _
                                CStr(ConvertToDblSafe(rsItem("kynay"))), _
                                rsItem("masocha")))
        Next
        rs_lailo = Nothing
        kn = GetSelectValue("select sum(kynay) as f1, sum(kytruoc) as f2 from LCTT where masocha=50", kt)
        ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc={0},KyNay={1} WHERE MaSo=50", _
                        CStr(kt), _
                        CStr(kn)))

        If tdau <> pThangDauKy Then
            kt = (SoDuTKSH("111", 0, -1) + SoDuTKSH("112", 0, -1))
            ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc={0} WHERE MaSo=60", CStr(kt)))
        End If
        ExecSQLNonQuery("UPDATE LCTT SET KyNay=" & GetSelectValue("SELECT sum(KyTruoc) as f1 FROM LCTT WHERE MaSo=20 OR MaSo=30 Or MaSo=40 Or MaSo=60 Or MaSo=61") & " WHERE MaSo=60")

        kn = GetSelectValue("select sum(kynay) as f1, sum(kytruoc) as f2 from LCTT where masocha=70", kt)
        ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc={0},KyNay={1} WHERE MaSo=70", _
                        CStr(kt), _
                        CStr(kn)))
        GauGe.Value = 4

        rptFrom.InitForm("LCTT.RPT", "SELECT * FROM LCTT", "LCTT")

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))

        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        rptFrom.SetFormulas("Thang", tdau)
    End Sub


    ''' luu chuyen tien te  thong tu 200
    ''' 29-3-19

    Private Sub InLCTT_TT200(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim sql As String = String.Empty
        Dim kt, kn As Double
        GauGe.Maximum = 4
        ExecSQLNonQuery("UPDATE LCTT SET KyTruoc = 0, KyNay = 0")
        Dim rs_lailo As DataTable = ExecSQLReturnDT("SELECT DISTINCT * FROM LCTT WHERE TKNo<>'0' AND TKCo<>'0' ORDER BY MaSo")
        For Each rsItem As DataRow In rs_lailo.Rows
            sql = String.Format("SELECT DISTINCT Sum(CASE WHEN {0} THEN ChungTu.SoPS ELSE 0 END) AS F1, Sum(CASE WHEN ({1}) THEN ChungTu.SoPS ELSE 0 END) AS F2 FROM (HeThongTK INNER JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo) INNER JOIN HeThongTK AS HeThongTK_1 ON ChungTu.MaTKCo = HeThongTK_1.MaSo WHERE HethongTK.SoHieu LIKE '{2}%' AND HethongTK_1.SoHieu LIKE '{3}%' AND {4}", _
                      WThang2("ThangCT", 0, tdau), _
                      WThang("ThangCT", tdau, tcuoi), _
                      rsItem("tkno"), _
                      rsItem("TkCo"), _
                      WThang("ThangCT", 0, tcuoi))
            kt = ConvertToDblSafe(GetSelectValue(sql, kn))
            If ConvertToDblSafe(rsItem("dau")) > 0 Then
                ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc={0}, KyNay = {1} WHERE Ma={2}", _
                                    CStr(kt), _
                                    CStr(kn), _
                                    rsItem("ma")))
            Else
                ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc={0}, KyNay = {1} WHERE Ma={2}", _
                                    CStr(-kt), _
                                    CStr(-kn), _
                                    rsItem("ma")))
            End If
        Next
        GauGe.Value = 2
        ' maso = 2
        If tdau = pThangDauKy Then
            kt = (SoDuTKSH("111", 0, -1) + SoDuTKSH("112", 0, -1))
            ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc=KyTruoc+{0} WHERE MaSo=2 and ma >= all (SELECT Ma FROM LCTT WHERE MaSo=2)", CStr(kt)))
        End If
        GauGe.Value = 3
        ' Cong don
        rs_lailo = ExecSQLReturnDT("SELECT KyTruoc,KyNay,MaSoCha,Dau FROM LCTT WHERE TongHop=0 And MaSoCha<>0 ORDER BY MaSoCha,MaSo")
        Dim macha As Integer = 0
        For Each rsItem As DataRow In rs_lailo.Rows
            If macha <> Math.Abs(rsItem("masocha")) Then
                macha = Math.Abs(rsItem("masocha"))
                ExecSQLNonQuery("update lctt set kytruoc=0, kynay=0 where maso = " + CStr(macha))
            End If
            ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc=KyTruoc+{0},KyNay=KyNay+{1} WHERE MaSo={2}", _
                                CStr(ConvertToDblSafe(rsItem("kytruoc"))), _
                                CStr(ConvertToDblSafe(rsItem("kynay"))), _
                                rsItem("masocha")))
        Next
        rs_lailo = Nothing
        kn = GetSelectValue("select sum(kynay) as f1, sum(kytruoc) as f2 from LCTT where masocha=50", kt)
        ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc={0},KyNay={1} WHERE MaSo=50", _
                        CStr(kt), _
                        CStr(kn)))

        If tdau <> pThangDauKy Then
            kt = (SoDuTKSH("111", 0, -1) + SoDuTKSH("112", 0, -1))
            ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc={0} WHERE MaSo=60", CStr(kt)))
        End If
        ExecSQLNonQuery("UPDATE LCTT SET KyNay=" & GetSelectValue("SELECT sum(KyTruoc) as f1 FROM LCTT WHERE MaSo=20 OR MaSo=30 Or MaSo=40 Or MaSo=60 Or MaSo=61") & " WHERE MaSo=60")

        kn = GetSelectValue("select sum(kynay) as f1, sum(kytruoc) as f2 from LCTT where masocha=70", kt)
        ExecSQLNonQuery(String.Format("UPDATE LCTT SET KyTruoc={0},KyNay={1} WHERE MaSo=70", _
                        CStr(kt), _
                        CStr(kn)))
        GauGe.Value = 4

        rptFrom.InitForm("LCTT.RPT", "SELECT * FROM LCTT", "LCTT")

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))

        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        rptFrom.SetFormulas("Thang", tdau)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub InQTThue(ByRef tdau As Integer, ByRef tcuoi As Integer)
        InThue(tdau, tcuoi)
        rptFrom.InitForm("XTHUE.RPT", "SELECT * FROM Thue", "Thue")

        rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))
        rptFrom.SetFormulas("MST", String.Format("'{0}'", frmMain._LbCty_8.Text))
        rptFrom.SetFormulas("Tel", String.Format("'{0}'", frmMain._LbCty_3.Text))
        rptFrom.SetFormulas("Fax", String.Format("'{0}'", frmMain._LbCty_4.Text))

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
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
        QTongHopCT = (String.Format("SELECT DISTINCT SoHieu, (Cap) AS FirstOfCap, (Ten{0}) AS FirstOfTen, (Kieu) AS FirstOfKieu, (Loai) AS FirstOfLoai, CASE WHEN (MaTC = MaSo OR MaTC = 0) THEN -1 ELSE 0 END AS FirstOfChuanLa, (TKCon) AS FirstOfTKCon, (CapDuoi) AS CD, Sum(DuNo_{1}) AS DkNo, Sum(DuCo_{1}) AS DkCo, Sum({2}) AS PsNo, Sum({3}) AS PsCo, Sum({4}) AS PsNoX, Sum({5}) AS PsCoX, Sum(HeThongTK.DuNo_{6}) AS CkNo, Sum(HeThongTK.DuCo_{6}) AS CkCo FROM HeThongTK WHERE Cap<={7}{8} GROUP BY SoHieu ,ten{0} ,loai ,kieu ,TKCon ,CapDuoi ,cap ,matc ,maso HAVING ((((Loai))>0) AND ((((Cap > 0))) OR (((MaTC > 0 AND MaTC <> MaSo))))) ORDER BY SoHieu", _
                                 (IIf(pNN > 0, "E", String.Empty)), _
                                 st, _
                                 sqln, _
                                 sqlc, _
                                 sqlnx, _
                                 sqlcx, _
                                 ConvertToStrSafe(CThangDB2(tcuoi)), _
                                 cap, _
                                 (IIf(ct = 0, String.Format(" AND (DuNo_{0}<>0 OR DuCo_{0}<>0 OR ({1})<>0 OR ({2})<>0)", st, sqln, sqlc), String.Empty))))
        GauGe.Value = 2
        XDCapTK("")
        rptFrom.InitForm("THSDCT.RPT", QTongHopCT, "QTongHopCT")
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub BKNopThue(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim sql As String = String.Format("SELECT ThangCT,LEFT(HethongTK.SoHieu,4) AS Thue,Sum(SoPS) AS NopThue FROM {0} WHERE HethongTK.SoHieu LIKE '333%' AND (TK.SoHieu LIKE '11%' OR TK.SoHieu LIKE '336%' OR TK.SoHieu LIKE '331%') AND {1} GROUP BY ThangCT,LEFT(HethongTK.SoHieu,4)", ChungTu2TKNC(0), WThang("ThangCT", tdau, tcuoi))
        Mientru = (sql)
        rptFrom.InitForm("NOPTHUE.RPT", Mientru, "Mientru")
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))
        rptFrom.SetFormulas("MST", String.Format("'{0}'", frmMain._LbCty_8.Text))
        rptFrom.SetFormulas("Tel", String.Format("'{0}'", frmMain._LbCty_3.Text))
        rptFrom.SetFormulas("Fax", String.Format("'{0}'", frmMain._LbCty_4.Text))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub InThue(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim rs As DataTable
        Dim i As Integer
        Dim th As String = String.Empty
        Dim mtk As Integer
        Dim a, B, danoplk, danop, dkc, NOP, noplk, dn As Double
        UpdateThueTable()
        Dim rs_thue As DataTable = ExecSQLReturnDT("SELECT MaSo,Ten FROM HethongTK WHERE SoHieu LIKE '3338%' AND Cap=3")
        For Each rsItem As DataRow In rs_thue.Rows
            i += 1
            ExecSQLNonQuery(String.Format("INSERT INTO Thue (MaSo,DienGiai,MaTK,TongHop) VALUES ({0},'  {1}',{2},1)", _
                                20 + i, _
                                rsItem("ten"), _
                                rsItem("MaSo")))
        Next
        rs_thue = ExecSQLReturnDT("SELECT DISTINCT Thue.MaSo As MaThue, Thue.MaTk, Thue.KyTruocSang,  Thue.KyNay, Thue.DaNop, Thue.TongHop, HeThongTK.* FROM Thue LEFT JOIN HeThongTK ON Thue.MaTk = HeThongTK.MaSo WHERE (Thue.MaTk>0)")
        Dim rowToProcess As Integer = 0
        Dim rs_thueItem As DataRow = rs_thue.Rows(0)
        If rs_thue.Rows.Count > 0 Then
            rowToProcess = rs_thue.Rows.Count - 1
            GauGe.Maximum = IIf(0.5 + 1.5 * rs_thue.Rows.Count > 0, _
                                Math.Floor(0.5 + 1.5 * rs_thue.Rows.Count), _
                                Math.Ceiling(0.5 + 1.5 * rs_thue.Rows.Count))
        End If
        For j As Integer = rowToProcess To rs_thue.Rows.Count - 1
            Dim rsThueItemX As DataRow = rs_thue.Rows(j)
            If Not IsDBNull(rsThueItemX("SoHieu")) Then
                dn = dn + ConvertToDblSafe(rs_thueItem("DuCo_0")) - ConvertToDblSafe(rsThueItemX("DuNo_0"))
                th = ConvertToStrSafe(ThangTruoc(tdau))
                dkc = rsThueItemX(String.Format("DuCo_{0}", th)) - ConvertToDblSafe(rsThueItemX(String.Format("DuNo_{0}", th))) - IIf(Strings.Left(rsThueItemX("SoHieu"), 4) = "3331", ConvertToDblSafe(Timten(String.Format("duno_{0}", th), "133", "sohieu", "hethongtk")), 0)
                noplk = rsThueItemX(String.Format("DuCo_{0}", th))
                danoplk = rsThueItemX(String.Format("DuNo_{0}", th))
                NOP = 0
                danop = IIf(Strings.Left(rsThueItemX("SoHieu"), 4) = "3331", ConvertToDblSafe(Timten("duco_0", "133", "sohieu", "hethongtk")), 0)
                For i = CThangDB2(tdau) To CThangDB2(tcuoi)
                    th = ConvertToStrSafe(i)
                    NOP = NOP + rsThueItemX(String.Format("Co_{0}", th)) - (IIf(Strings.Left(rsThueItemX("SoHieu"), 4) = "3331", ConvertToDblSafe(Timten(String.Format("no_{0}", th), "133", "sohieu", "hethongtk")), 0))
                    danop = danop + rsThueItemX("No_" & th) - (IIf(Strings.Left(rsThueItemX("SoHieu"), 4) = "3331", ConvertToDblSafe(Timten("co_" & th, "133", "sohieu", "hethongtk")), 0))
                    noplk += rsThueItemX("Co_" & th)
                    danoplk += rsThueItemX("No_" & th)
                Next
                ExecSQLNonQuery(String.Format("UPDATE Thue SET KyTruocSang = {0}, KyNay = {1}, DaNop = {2}, LuyKePN = {3}, LuyKeDN = {4} WHERE MaSo={5}", CStr(dkc), CStr(NOP), CStr(danop), CStr(noplk), CStr(danoplk), rsThueItemX("MaThue")))
                If Strings.Left(rsThueItemX("SoHieu"), 5) = "33311" Then
                    NOP = PSDu("11", pVATV, tdau, tcuoi, "", 1)
                    danop = SoPSTK("333112", tdau, tcuoi, 1)
                    ExecSQLNonQuery(String.Format("UPDATE Thue SET DaHoan = {0}, MienGiam = {1} WHERE MaSo={2}", CStr(NOP), CStr(danop), rsThueItemX("MaThue")))
                End If
                If Strings.Left(rsThueItemX("SoHieu"), 5) = "33312" Then
                    danop = SoPSTK("333122", tdau, tcuoi, 1)
                    ExecSQLNonQuery(String.Format("UPDATE Thue SET MienGiam = {0} WHERE MaSo={1}", CStr(danop), rsThueItemX("MaThue")))
                End If
            Else
                ExecSQLNonQuery(String.Format("UPDATE Thue SET KyTruocSang = 0, KyNay = 0, DaNop = 0, LuyKePN = 0, LuyKeDN = 0 WHERE MaSo={0}", rsThueItemX("MaThue")))
            End If
            GauGe.Value += 1
        Next
        If pNamTC > 2000 Then
            NOP = -PSDu("33311", pVATV, tdau, tcuoi)
            noplk = -PSDu("33311", pVATV, pThangDauKy, tcuoi)
            dkc = ConvertToDblSafe(GetSelectValue(String.Format("SELECT DuCo_{0}-DuNo_{1} AS F1 FROM HethongTK WHERE SoHieu='33311'", CThangDB2(ThangTruoc(tdau)), ConvertToStrSafe(CThangDB2(ThangTruoc(tdau))))))
            NOP += ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END) AS F1 FROM {1} WHERE HoaDon.Loai=1 AND {2}", GTGTPN_ID, ChungTu2TKHD(1), WThang("ThangCT", tdau, tcuoi))))
            noplk += ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END) AS F1 FROM {1} WHERE HoaDon.Loai=1 AND {2}", GTGTPN_ID, ChungTu2TKHD(1), WThang("ThangCT", pThangDauKy, tcuoi))))
            rs_thue = ExecSQLReturnDT(String.Format("SELECT * FROM HethongTK WHERE SoHieu='{0}'", pVATV))
            dkc -= ConvertToDblSafe(rs_thueItem(String.Format("DuNo_{0}", CThangDB2(ThangTruoc(tdau)))))
            If dkc < 0 Then dkc = 0
            danop = ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(CASE WHEN {0} THEN SoPS ELSE 0 END) AS F1, SUM(SoPS) AS F2 FROM {1} WHERE {2} AND HethongTK.SoHieu LIKE '33311%' AND (TK.SoHieu LIKE '11%') AND MaLoai<>8", _
                                                        WThang("ThangCT", tdau, 0), _
                                                        ChungTu2TKNC(0), _
                                                        WThang("ThangCT", 0, tcuoi)), danoplk))
            If NOP < 0 Then
                NOP = 0
                danop = dkc
            End If
            If noplk < 0 Then
                noplk = 0
                danoplk = dkc
            End If
            ExecSQLNonQuery(String.Format("UPDATE Thue SET KyTruocSang = KyTruocSang+{0}, KyNay = KyNay+{1}, DaNop = DaNop+{2}, LuyKePN = LuyKePN+{3}, LuyKeDN = LuyKeDN+{4} WHERE MATK={5}", _
                                CStr(dkc), _
                                CStr(NOP), _
                                CStr(danop), _
                                CStr(noplk), _
                                CStr(danoplk), _
                                Timten("maso", ConvertToStrSafe(3331), "sohieu", "hethongtk")))
        End If
        ' Cộng dồn
        rs_thue = ExecSQLReturnDT("SELECT Ma FROM Thue WHERE Tonghop=0")
        For Each rsItem As DataRow In rs_thue.Rows
            rs = ExecSQLReturnDT(String.Format("SELECT SUM(KyTruocSang) as SoKyTruoc,SUM(KyNay) as SoKyNay,SUM(DaNop) as SoDaNop,SUM(LuyKePN) as SoPhaiNop,SUM(LuyKeDN) as SoLKDN FROM Thue WHERE Tonghop = {0}", rsItem("ma")))
            ExecSQLNonQuery(String.Format("UPDATE Thue SET KyTruocSang = {0}, KyNay = {1}, DaNop = {2}, LuyKePN = {3}, LuyKeDN = {4} WHERE Ma={5}", _
                                rs.Rows(0)("SoKyTruoc"), _
                                rs.Rows(0)("SoKyNay"), _
                                rs.Rows(0)("SoDaNop"), _
                                rs.Rows(0)("SoPhaiNop"), _
                                rs.Rows(0)("SoLKDN"), _
                                rsItem("ma")))
            GauGe.Value += 1
        Next
        ''rs_thue.Close()
        tentk(Interaction.GetSetting(IniPath, "TAX", "TNDN", "3334"), mtk)
        SoDuTK(mtk, 0, danop, NOP)
        rptFrom.InitForm("THUE.RPT", "SELECT * FROM Thue", "Thue")

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThueNT", dn)
        rptFrom.SetFormulas("ThueTNNT", NOP - danop)
        Dim sql As String = "SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t4 on t1.matkco=t4.maso  WHERE left(t2.sohieu,3)='811' and left(t4.sohieu,4)='3334'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then rptFrom.SetFormulas("ttp1", rs.Rows(0)(0))
        End If
        sql = "SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t4 on t1.matkco=t4.maso  WHERE left(t2.sohieu,3)='811' and left(t4.sohieu,4)='3331'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then rptFrom.SetFormulas("ttp2", rs.Rows(0)(0))
        End If
        sql = "SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t4 on t1.matkco=t4.maso  WHERE left(t2.sohieu,3)='811' and left(t4.sohieu,4)='3339'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then rptFrom.SetFormulas("ttp3", rs.Rows(0)(0))
        End If
        sql = "SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t4 on t1.matkco=t4.maso  WHERE left(t2.sohieu,3)='811' and left(t4.sohieu,4)='3338'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then rptFrom.SetFormulas("ttp4", rs.Rows(0)(0))
        End If
        sql = "SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso) inner join hethongtk t4 on t1.matkco=t4.maso  WHERE left(t2.sohieu,3)='811' and left(t4.sohieu,4)='3335'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then rptFrom.SetFormulas("ttp7", rs.Rows(0)(0))
        End If
        sql = "SELECT sum(sops) FROM chungtu t1 inner join hethongtk t2 on t1.matkco=t2.maso  WHERE left(t2.sohieu,4)='3331'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then a = rs.Rows(0)(0)
        End If
        sql = "SELECT sum(sops) FROM chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso  WHERE left(t2.sohieu,3)='133'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then B = rs.Rows(0)(0)
        End If
        rptFrom.SetFormulas("TGTGT", a - B)
        a = 0
        B = 0
        sql = "SELECT sum(sops) FROM (chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso)inner join hethongtk t3 on t1.matkco=t3.maso  WHERE left(t2.sohieu,4)='3343' and left(t3.sohieu,3)='821'"
        rs = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If ConvertToStrSafe(rs.Rows(0)(0)) <> "" Then rptFrom.SetFormulas("TTNDN", rs.Rows(0)(0))
        End If
        rs_thue = Nothing
        rs = Nothing
        GauGe.Value = GauGe.Maximum
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="TL"></param>
    ''' <param name="TK"></param>
    ''' <param name="ngay0"></param>
    ''' <param name="ngay1"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function InVATDauRa(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef TL As Integer, ByRef TK As ClsTaikhoan, Optional ByRef ngay0 As Date = #1/1/1990#, Optional ByRef ngay1 As Date = #1/1/1990#, Optional ByRef qnk As String = "") As Boolean
        Dim sql As String = String.Empty
        GauGe.Maximum = 1
        If TK.maso = 0 Then
            Select Case TL
                Case -3
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieu,KyHieuMau,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE HoaDon.Loai=1 AND HDBL=1 AND {2} AND KCT=0 AND (HoaDon.DC=0 OR HD=1) ", _
                                   GTGTPN_ID, _
                                   ChungTu2TKHD(2), _
                                   (IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ngay0, ngay1)))))
                Case -2
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieu,KyHieuMau,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE HoaDon.Loai=1 AND {2} AND KCT=1 AND (HoaDon.DC=0 OR HD=1) ", _
                                   GTGTPN_ID, _
                                   ChungTu2TKHD(2), _
                                   (IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ngay0, ngay1)))))
                Case -1
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieu,KyHieuMau,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE HoaDon.Loai=1 AND {2} AND (HoaDon.DC=0 OR HD=1) ", _
                                   GTGTPN_ID, _
                                   ChungTu2TKHD(2), _
                                   (IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ngay0, ngay1)))))
                Case 30
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieuKyHieuMau,,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE HoaDon.Loai=1 AND (TyLe=5 OR TyLe=10) AND {2} AND KCT=0 AND (HoaDon.DC=0 OR HD=1) ", _
                                   GTGTPN_ID, _
                                   ChungTu2TKHD(2), _
                                   (IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ngay0, ngay1)))))
                Case Else
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieu,KyHieuMau,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE HoaDon.Loai=1 AND TyLe={2} AND {3} AND KCT=0 AND (HoaDon.DC=0 OR HD=1) ", _
                                   GTGTPN_ID, _
                                   ChungTu2TKHD(2), _
                                   ConvertToStrSafe(TL), _
                                   (IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ngay0, ngay1)))))
            End Select
            rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))
        Else
            Select Case TL
                Case -3
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE HoaDon.Loai=1 AND HDBL=1 AND {2} AND KCT=0 AND HethongTK.Sohieu LIKE '{3}%' AND (HoaDon.DC=0 OR HD=1) ", _
                                   GTGTPN_ID, _
                                   ChungTu2TKHD(2), _
                                   (IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ngay0, ngay1))), _
                                   TK.sohieu))
                Case -2
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE HoaDon.Loai=1 AND {2} AND KCT=1 AND HethongTK.Sohieu LIKE '{3}%' AND (HoaDon.DC=0 OR HD=1) ", _
                                   GTGTPN_ID, _
                                   ChungTu2TKHD(2), _
                                   (IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ngay0, ngay1))), _
                                   TK.sohieu))
                Case -1
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE HoaDon.Loai=1 AND {2} AND HethongTK.Sohieu LIKE '{3}%' AND (HoaDon.DC=0 OR HD=1) ", _
                                   GTGTPN_ID, _
                                   ChungTu2TKHD(2), _
                                   (IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ngay0, ngay1))), _
                                   TK.sohieu))
                Case 30
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE HoaDon.Loai=1 AND (TyLe=5 OR TyLe=10) AND {2} AND KCT=0 AND HethongTK.Sohieu LIKE '{3}%' AND (HoaDon.DC=0 OR HD=1) ", _
                                   GTGTPN_ID, _
                                   ChungTu2TKHD(2), _
                                   (IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ngay0, ngay1))), _
                                   TK.sohieu))
                Case Else
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS [SoPS],KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,KCT FROM {1} WHERE HoaDon.Loai=1 AND TyLe={2} AND {3} AND KCT=0 AND HethongTK.Sohieu LIKE '{4}%' AND (HoaDon.DC=0 OR HD=1) ", _
                                   GTGTPN_ID, _
                                   ChungTu2TKHD(2), _
                                   ConvertToStrSafe(TL), _
                                   (IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ngay0, ngay1))), _
                                   TK.sohieu))
            End Select

        End If
        GauGe.Value = 1
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        Dim rs As DataTable
        Dim tongtien As Double
        If ConvertToDblSafe(Interaction.GetSetting(IniPath, "Invoice", "ListDetail", "0")) = 1 Then
            Mientru = (String.Format("SELECT MaCT FROM {0} WHERE {1} AND HoaDon.Loai=1 GROUP BY MaCT", _
                           ChungTu2TKHD(0), _
                           WThang("ThangCT", tdau, tcuoi)))
            QCdt = (String.Format("SELECT MaCT FROM ChungTu WHERE {0} AND MaVattu>0 AND MaLoai=8 GROUP BY MaCT HAVING Count(MaVattu)>1", WThang("ThangCT", tdau, tcuoi)))
            QDuPhong = (String.Format("SELECT ChungTu.MaCT,TenVattu AS MH,SoPS2Co AS SL,SoPS AS TT FROM (((ChungTu INNER JOIN (" & Mientru & ") as MienTru ON ChungTu.MaCT=MienTru.MaCT) INNER JOIN HethongTK ON ChungTu.MaTKCo=HethongTK.MaSo) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN ({0}) As QCdt ON ChungTu.MaCT=QCdt.MaCT WHERE TK_ID={1}", _
                            QCdt, _
                            TKDT_ID))
            QChitiet = (String.Format("SELECT QNhatKy.*,QDuPhong.* FROM ({0}) As QNhatKy LEFT JOIN ({1}) As QDuPhong ON QNhatKy.MaCT=QDuPhong.MaCT ORDER BY TyLe,NgayPH,SoHD", _
                            QNhatKy, _
                            QDuPhong))
            rptFrom.InitForm("BANGKER6r.RPT", QChitiet, "QChitiet")
        ElseIf TL = -3 Then
            ExecSQLNonQuery("DELETE  FROM  phieunx")
            Mientru = ("SELECT ct.ngaygs,ct.mact,vt.tenvattu,vt.donvi,ct.sops2co,ct.sops,ct.sohieu,vt.sohieu as sohieuvt FROM chungtu ct  inner join vattu vt on ct.mavattu=vt.maso")
            rs = ExecSQLReturnDT(String.Format("SELECT '...','...','...',mt.tenvattu,mt.sops2co,mt.sops,'...',mt.donvi,0,nk.tyle,0,0,0,'...' FROM (" & Mientru & ") as mientru mt inner join ({0}) As QNhatKynk on mt.mact=nk.mact WHERE true{1}", _
                                     QNhatKy, _
                                     (IIf(tcuoi = 0, String.Format(" and {0}", WNgay("mt.ngaygs", ngay0, ngay1)), String.Empty))))
            For Each rsItem As DataRow In rs.Rows
                ExecSQLNonQuery(String.Format("INSERT INTO phieunx VALUES({0}, N'{1}', N'{2}', N'{3}', N'{4}',{5},{6}, N'{7}', N'{8}',{9},{10},{11},{12},{13}, N'{14}')", _
                                    Lng_MaxValue("Maso", "phieunx") + 1, _
                                    rsItem(0), _
                                    rsItem(1), _
                                    rsItem(2), _
                                    rsItem(3), _
                                    rsItem(4), _
                                    rsItem(5), _
                                    rsItem(6), _
                                    rsItem(7), _
                                    rsItem(8), _
                                    rsItem(9), _
                                    rsItem(10), _
                                    rsItem(11), _
                                    rsItem(12), _
                                    rsItem(13)))
                tongtien += Math.Round(ConvertToDblSafe(rsItem("sops")) * (1 + ConvertToDblSafe(rsItem("TyLe")) / 100), 0)
            Next
            rptFrom.InitForm("BKBL.RPT", "SELECT * FROM phieunx", "phieunx")
            rptFrom.SetFormulas("sotien", String.Format("'{0} đồng'", ToVNText(tongtien)))
            rptFrom.SetFormulas("TenNN", String.Format("'{0}'", FrmGetStr.GetString(Ngonngu("Họ tên người bán hàng:", "Seller full name"), My.Application.Info.ProductName, String.Format(Ngonngu("NHÂN VIÊN {0}", "Employees"), frmMain._LbCty_0.Text))))
            rptFrom.SetFormulas("DiachiNN", String.Format("'{0}'", FrmGetStr.GetString(Ngonngu("Địa chỉ nơi bán hàng:", "Address sales"), My.Application.Info.ProductName, String.Format("{0} - {1} - {2}", frmMain._LbCty_2.Text, frmMain._LbCty_10.Text, frmMain._LbCty_11.Text))))
            If tcuoi = 0 Then RptSetDate(ngay1)
        Else
            rptFrom.InitForm("BANGKER.RPT", QNhatKy & " ORDER BY NgayPH, SoHD ", "QNhatKy")
        End If
        qnk = QNhatKy
        If TK.maso > 0 Then
            rptFrom.SetFormulas("TenCn", String.Format("'{0}'", TK.ten))
            rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", TK.GhiChu))
        End If

        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        rptFrom.SetFormulas("MSThue", String.Format("'{0}'", frmMain._LbCty_8.Text))
        rptFrom.SetFormulas("TLKT", TL)
        Return True
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <param name="TL"></param>
    ''' <param name="TK"></param>
    ''' <remarks></remarks>
    Private Sub InVATDauRaMV(ByRef thang As Integer, ByRef TL As Integer, ByRef TK As ClsTaikhoan)
        Dim prg As Integer
        Dim i As Integer
        Dim sql As String = String.Empty
        Dim mvpath As String = KiemTraMaVach(1, String.Format("{0}\Program Files\P2D\P2D.exe", CurrentDrive()))
        If FileSystem.Dir(mvpath, FileAttribute.Normal).Length = 0 Then Exit Sub
        If TK.maso = 0 Then
            Select Case TL
                Case -3
                    sql = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS Thue,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT FROM {1} WHERE HoaDon.Loai=1 AND HDBL=1 AND ThangCT={2} AND KCT=0 AND HoaDon.DC=0 ORDER BY NgayPH", _
                              GTGTPN_ID, _
                              ChungTu2TKHD(2), _
                              ConvertToStrSafe(thang))
                Case -2
                    sql = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS Thue,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT FROM {1} WHERE HoaDon.Loai=1 AND ThangCT={2} AND KCT=1 AND HoaDon.DC=0 ORDER BY NgayPH", GTGTPN_ID, ChungTu2TKHD(2), ConvertToStrSafe(thang))
                Case -1
                    sql = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS Thue,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT FROM {1} WHERE HoaDon.Loai=1 AND ThangCT={2} AND HoaDon.DC=0 ORDER BY NgayPH", _
                              GTGTPN_ID, _
                              ChungTu2TKHD(2), _
                              ConvertToStrSafe(thang))
                Case 30
                    sql = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS Thue,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT FROM {1} WHERE HoaDon.Loai=1 AND (TyLe=5 OR TyLe=10) AND ThangCT={2} AND KCT=0 AND HoaDon.DC=0 ORDER BY NgayPH", _
                              GTGTPN_ID, _
                              ChungTu2TKHD(2), _
                              ConvertToStrSafe(thang))
                Case Else
                    sql = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS Thue,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT FROM {1} WHERE HoaDon.Loai=1 AND TyLe={2} AND ThangCT={3} AND KCT=0 AND HoaDon.DC=0 ORDER BY NgayPH", _
                              GTGTPN_ID, _
                              ChungTu2TKHD(2), _
                              ConvertToStrSafe(TL), _
                              ConvertToStrSafe(thang))
            End Select
        Else
            Select Case TL
                Case -3
                    sql = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS Thue,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT FROM {1} WHERE HoaDon.Loai=1 AND HDBL=1 AND ThangCT={2} AND KCT=0 AND HethongTK.Sohieu LIKE '{3}%' AND HoaDon.DC=0 ORDER BY NgayPH", _
                              GTGTPN_ID, _
                              ChungTu2TKHD(2), _
                              ConvertToStrSafe(thang), _
                              TK.sohieu)
                Case -2
                    sql = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS Thue,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT FROM {1} WHERE HoaDon.Loai=1 AND ThangCT={2} AND KCT=1 AND HethongTK.Sohieu LIKE '{3}%' AND HoaDon.DC=0 ORDER BY NgayPH", _
                              GTGTPN_ID, _
                              ChungTu2TKHD(2), _
                              ConvertToStrSafe(thang), _
                              TK.sohieu)
                Case -1
                    sql = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS Thue,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT FROM {1} WHERE HoaDon.Loai=1 AND ThangCT={2} AND HethongTK.Sohieu LIKE '{3}%' AND HoaDon.DC=0 ORDER BY NgayPH", _
                              GTGTPN_ID, _
                              ChungTu2TKHD(2), _
                              ConvertToStrSafe(thang), _
                              TK.sohieu)
                Case 30
                    sql = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS Thue,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT FROM {1} WHERE HoaDon.Loai=1 AND (TyLe=5 OR TyLe=10) AND ThangCT={2} AND KCT=0 AND HethongTK.Sohieu LIKE '{3}%' AND HoaDon.DC=0 ORDER BY NgayPH", _
                              GTGTPN_ID, _
                              ChungTu2TKHD(2), _
                              ConvertToStrSafe(thang), _
                              TK.sohieu)
                Case Else
                    sql = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS Thue,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT FROM {1} WHERE HoaDon.Loai=1 AND TyLe={2} AND ThangCT={3} AND KCT=0 AND HethongTK.Sohieu LIKE '{4}%' AND HoaDon.DC=0 ORDER BY NgayPH", _
                              GTGTPN_ID, _
                              ChungTu2TKHD(2), _
                              ConvertToStrSafe(TL), _
                              ConvertToStrSafe(thang), _
                              TK.sohieu)
            End Select
        End If
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        If Not (rs.Rows.Count = 0) Then
            Recycle(String.Format("{0}\temp\BKVAT2.XLS", pCurDir))
            On Error GoTo KetThuc
            File.Copy(String.Format("{0}Data\Test02.xls", Strings.Left(mvpath, mvpath.Length - 7)), pCurDir & "BKVAT2.XLS")
            xlapp = New Excel.Application()
            xlapp.Workbooks.Open(String.Format("{0}BKVAT2.XLS", pCurDir))
            xlsheet = xlapp.Worksheets(1)
            On Error GoTo 0
            xlsheet.Cells(1, 2) = thang
            xlsheet.Cells(2, 2) = IIf(thang < pThangDauKy, pNamTC + 1, pNamTC)
            For i = 5 To 16
                For j As Integer = 1 To 12
                    xlsheet.Cells(i, j) = ""
                Next
            Next
            i = 4
            For Each rsItem As DataRow In rs.Rows
                i += 1
                xlsheet.Cells(i, 1) = ConvertToStrSafe(rsItem("MauSo"))
                xlsheet.Cells(i, 2) = ConvertToStrSafe(rsItem("KyHieu"))
                xlsheet.Cells(i, 3) = ConvertToStrSafe(rsItem("sohd"))
                xlsheet.Cells(i, 4) = FormatDate(ConvertToDateSafe(rsItem("NgayPH")))
                xlsheet.Cells(i, 5) = ConvertToStrSafe(rsItem("ten"))
                xlsheet.Cells(i, 6) = ConvertToStrSafe(rsItem("MST"))
                xlsheet.Cells(i, 7) = ConvertToStrSafe(rsItem("MatHang"))
                xlsheet.Cells(i, 8) = ConvertToStrSafe(rsItem("ThanhTien"))
                xlsheet.Cells(i, 9) = ConvertToStrSafe(rsItem("TyLe"))
                xlsheet.Cells(i, 10) = ConvertToStrSafe(rsItem("Thue"))
            Next
            xlsheet.Cells(i + 2, 2) = "END OF FILE"
            xlapp.Workbooks(1).Save()
            xlapp.Workbooks.Close()
            xlsheet = Nothing
            xlapp = Nothing
            Dim startInfo As ProcessStartInfo = New ProcessStartInfo(mvpath)
            startInfo.WindowStyle = ProcessWindowStyle.Normal
            prg = ConvertToDblSafe(Process.Start(startInfo).Id)
            If prg = 0 Then Exit Sub
            Interaction.AppActivate(ConvertToStrSafe(prg))
            AppIdle(w1)
            SendKeys.Send("{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}~")
            AppIdle(w1)
            SendKeys.Send("{F8}{TAB}~")
            AppIdle(w1)
            SendKeys.Send(String.Format("{0}BKVAT2.XLS", pCurDir))
            AppIdle(w1)
            SendKeys.Send("~{TAB}~~")
        End If
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <param name="TL"></param>
    ''' <param name="hd"></param>
    ''' <param name="TK"></param>
    ''' <remarks></remarks>
    Private Sub InVATDauVaoMV(ByRef thang As Integer, ByRef TL As Integer, ByRef hd As Integer, ByRef TK As ClsTaikhoan)
        Dim prg As Integer
        Dim i As Integer
        Dim sql, fname As String
        Dim Tk2 As New ClsTaikhoan
        Dim dgia As Double
        Dim mvpath As String = KiemTraMaVach(1, CurrentDrive() & "\Program Files\P2D\P2D.EXE")
        If FileSystem.Dir(mvpath, FileAttribute.Normal).Length = 0 Then Exit Sub
        Tk2.InitTaikhoanSohieu("33312")
        If Tk2.tk_id = GTGTKT_ID Then
            sql = String.Format("DELETE HoaDon  FROM ((HoaDon INNER JOIN ChungTu ON HoaDon.MaSo=ChungTu.MaSo) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo  WHERE (HethongTK.SoHieu LIKE '{0}%') AND (TK.SoHieu LIKE '33312%'  OR ChungTu.GhiChu like '%33312%') AND HoaDon.Loai=-1", pVATV)
            ExecSQLNonQuery(sql)
        End If
        If TK.maso = 0 Then
            Select Case TL
                Case -3
                    sql = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo FROM {0} WHERE Loai=-1 AND HD={1} AND ThangCT={2} AND HDBL=1 AND HoaDon.DC=0 ORDER BY NgayPH,MaCT", _
                              ChungTu2TKHD(10), _
                              ConvertToStrSafe(hd), _
                              ConvertToStrSafe(thang))
                Case -2
                    sql = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo FROM {0} WHERE Loai=-1 AND HD={1} AND ThangCT={2} AND KCT=1 AND HoaDon.DC=0 ORDER BY NgayPH,MaCT", _
                              ChungTu2TKHD(10), _
                              ConvertToStrSafe(hd), _
                              ConvertToStrSafe(thang))
                Case -1
                    sql = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo FROM {0} WHERE Loai=-1 AND HD={1} AND ThangCT={2} AND HoaDon.DC=0 ORDER BY NgayPH,MaCT", _
                              ChungTu2TKHD(10), _
                              ConvertToStrSafe(hd), _
                              ConvertToStrSafe(thang))
                Case 30
                    sql = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo FROM {0} WHERE Loai=-1 AND (TyLe=5 OR TyLe=10) AND HD={1} AND ThangCT={2} AND KCT=0 AND HoaDon.DC=0 ORDER BY NgayPH,MaCT", _
                              ChungTu2TKHD(10), _
                              ConvertToStrSafe(hd), _
                              ConvertToStrSafe(thang))
                Case Else
                    sql = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo FROM {0} WHERE Loai=-1 AND TyLe={1} AND HD={2} AND ThangCT={3} AND KCT=0 AND HDBL=0 AND HoaDon.DC=0 ORDER BY NgayPH,MaCT", _
                              ChungTu2TKHD(10), _
                              ConvertToStrSafe(TL), _
                              ConvertToStrSafe(hd), _
                              ConvertToStrSafe(thang))
            End Select
        Else
            Select Case TL
                Case -3
                    sql = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HoaDon.Loai=-1 AND HD={1} AND ThangCT={2} AND HDBL=1 AND HethongTK.Sohieu LIKE '{3}%' AND HoaDon.DC=0 ORDER BY NgayPH,MaCT", _
                              ChungTu2TKHD(10), _
                              ConvertToStrSafe(hd), _
                              ConvertToStrSafe(thang), _
                              TK.sohieu)
                Case -2
                    sql = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HoaDon.Loai=-1 AND HD={1} AND ThangCT={2} AND KCT=1 AND HethongTK.Sohieu LIKE '{3}%' AND HoaDon.DC=0 ORDER BY NgayPH,MaCT", _
                              ChungTu2TKHD(10), _
                              ConvertToStrSafe(hd), _
                              ConvertToStrSafe(thang), _
                              TK.sohieu)
                Case -1
                    sql = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HoaDon.Loai=-1 AND HD={1} AND ThangCT={2} AND HethongTK.Sohieu LIKE '{3}%' AND HoaDon.DC=0 ORDER BY NgayPH,MaCT", _
                              ChungTu2TKHD(10), _
                              ConvertToStrSafe(hd), _
                              ConvertToStrSafe(thang), _
                              TK.sohieu)
                Case 30
                    sql = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HoaDon.Loai=-1 AND (TyLe=5 OR TyLe=10) AND HD={1} AND ThangCT={2} AND KCT=0 AND HethongTK.Sohieu LIKE '{3}%' AND HoaDon.DC=0 ORDER BY NgayPH,MaCT", _
                              ChungTu2TKHD(10), _
                              ConvertToStrSafe(hd), _
                              ConvertToStrSafe(thang), _
                              TK.sohieu)
                Case Else
                    sql = String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HoaDon.Loai=-1 AND TyLe={1} AND HD={2} AND ThangCT={3} AND KCT=0 AND HDBL=0 AND HethongTK.Sohieu LIKE '{4}%' AND HoaDon.DC=0 ORDER BY NgayPH,MaCT", _
                              ChungTu2TKHD(10), _
                              ConvertToStrSafe(TL), _
                              ConvertToStrSafe(hd), _
                              ConvertToStrSafe(thang), _
                              TK.sohieu)
            End Select
        End If
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        If Not (rs.Rows.Count = 0) Then
            If hd = 0 Then
                fname = "TEST04.XLS"
                sql = "Bảng kê 04/GTGT"
            Else
                If (TL > 0 And TL < 5) Or TL = -3 Then
                    fname = "TEST05.XLS"
                    sql = "Bảng kê 05/GTGT"
                Else
                    fname = "TEST03.XLS"
                    sql = "Bảng kê 03/GTGT"
                End If
            End If
            Recycle(String.Format("{0}\temp\BKVATV.XLS", pCurDir))
            On Error GoTo KetThuc
            File.Copy(String.Format("{0}Data\{1}", Strings.Left(mvpath, mvpath.Length - 7), fname), String.Format("{0}BKVATV.XLS", pCurDir))
            xlapp = New Excel.Application()
            xlapp.Workbooks.Open(pCurDir & "BKVATV.XLS")
            xlsheet = xlapp.Worksheets(1)
            On Error GoTo 0
            xlsheet.Cells(1, 2) = thang
            xlsheet.Cells(2, 2) = IIf(thang < pThangDauKy, pNamTC + 1, pNamTC)
            For i = 5 To 60
                For j As Integer = 1 To 12
                    xlsheet.Cells(i, j) = ""
                Next
            Next
            i = 4
            For Each rsItem As DataRow In rs.Rows
                i += 1
                Select Case fname
                    Case "TEST03.XLS"
                        xlsheet.Cells(i, 1) = ConvertToStrSafe(rsItem("MauSo"))
                        xlsheet.Cells(i, 2) = ConvertToStrSafe(rsItem("KyHieu"))
                        xlsheet.Cells(i, 3) = ConvertToStrSafe(rsItem("sohd"))
                        xlsheet.Cells(i, 4) = FormatDate(ConvertToDateSafe(rsItem("NgayPH")))
                        xlsheet.Cells(i, 5) = ConvertToStrSafe(rsItem("ten"))
                        xlsheet.Cells(i, 6) = ConvertToStrSafe(rsItem("MST"))
                        xlsheet.Cells(i, 7) = ConvertToStrSafe(rsItem("MatHang"))
                        xlsheet.Cells(i, 8) = ConvertToStrSafe(rsItem("ThanhTien"))
                        xlsheet.Cells(i, 9) = ConvertToStrSafe(rsItem("TyLe"))
                        xlsheet.Cells(i, 10) = ConvertToStrSafe(rsItem("sops"))
                    Case "TEST04.XLS"
                        dgia = IIf(ConvertToDblSafe(rsItem("soluong")) <> 0, (IIf(0.5 + Mask_N * ConvertToDblSafe(rsItem("ThangTien")) / ConvertToDblSafe(rsItem("soluong")) > 0, Math.Floor(0.5 + Mask_N * ConvertToDblSafe(rsItem("ThangTien")) / ConvertToDblSafe(rsItem("soluong"))), Math.Ceiling(0.5 + Mask_N * ConvertToDblSafe(rsItem("ThangTien")) / ConvertToDblSafe(rsItem("soluong"))))) / Mask_N, 0)
                        xlsheet.Cells(i, 1) = FormatDate(ConvertToDateSafe(rsItem("NgayPH")))
                        xlsheet.Cells(i, 2) = ConvertToStrSafe(rsItem("ten"))
                        xlsheet.Cells(i, 3) = ConvertToStrSafe(rsItem("MST"))
                        xlsheet.Cells(i, 4) = ConvertToStrSafe(rsItem("MatHang"))
                        xlsheet.Cells(i, 5) = ConvertToStrSafe(rsItem("soluong"))
                        xlsheet.Cells(i, 6) = dgia
                        xlsheet.Cells(i, 7) = ConvertToStrSafe(rsItem("ThanhTien"))
                    Case "TEST05.XLS"
                        xlsheet.Cells(i, 1) = ConvertToStrSafe(rsItem("MauSo"))
                        xlsheet.Cells(i, 2) = ConvertToStrSafe(rsItem("KyHieu"))
                        xlsheet.Cells(i, 3) = ConvertToStrSafe(rsItem("sohd"))
                        xlsheet.Cells(i, 4) = FormatDate(ConvertToDateSafe(rsItem("NgayPH")))
                        xlsheet.Cells(i, 5) = ConvertToStrSafe(rsItem("ten"))
                        xlsheet.Cells(i, 6) = ConvertToStrSafe(rsItem("MST"))
                        xlsheet.Cells(i, 7) = ConvertToStrSafe(rsItem("ThanhTien"))
                End Select
            Next
            xlsheet.Cells(i + 2, 2) = "END OF FILE"
            xlapp.Workbooks(1).Save()
            xlapp.Workbooks.Close()
            xlsheet = Nothing
            xlapp = Nothing
            Dim startInfo As ProcessStartInfo = New ProcessStartInfo(mvpath)
            startInfo.WindowStyle = ProcessWindowStyle.Normal
            prg = ConvertToDblSafe(Process.Start(startInfo).Id)
            If prg = 0 Then Exit Sub
            Interaction.AppActivate(ConvertToStrSafe(prg))
            AppIdle(w1)
            SendKeys.Send(String.Format("{{TAB}}{{TAB}}{{TAB}}{{TAB}}{{TAB}}{{TAB}}{0}{{TAB}}~", sql))
            AppIdle(w1)
            SendKeys.Send("{F8}{TAB}~")
            AppIdle(w1)
            SendKeys.Send(pCurDir & "BKVATV.XLS")
            AppIdle(w1)
            SendKeys.Send("~{TAB}~~")
        End If
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="TL"></param>
    ''' <param name="hd"></param>
    ''' <param name="TK"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function InVATDienNuoc(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef TL As Integer, ByRef hd As Integer, ByRef TK As ClsTaikhoan) As Boolean
        Dim sql As String = String.Empty
        Dim Tk2 As New ClsTaikhoan
        Dim Fx As Integer = IIf(Strings.Left(frmMain._LbCty_8.Text, 2) = "35" Or Strings.Left(frmMain._LbCty_3.Text, 2) = "64", 35, 0)
        Tk2.InitTaikhoanSohieu("33312")
        If Tk2.tk_id = GTGTKT_ID Then
            sql = String.Format("DELETE HoaDon  FROM ((HoaDon INNER JOIN ChungTu ON HoaDon.MaSo=ChungTu.MaSo) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo  WHERE (HethongTK.SoHieu LIKE '{0}%') AND (TK.SoHieu LIKE '33312%'  OR CHARINDEX(ChungTu.GhiChu,'33312')>0) AND HoaDon.Loai=-1", pVATV)
            ExecSQLNonQuery(sql)
        End If
        GauGe.Maximum = 1
        If TK.maso = 0 Then
            Select Case TL
                Case -3
                    If Fx = 0 Then
                        QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,Mathuchi FROM {0} WHERE HD={1} AND {2} AND HDBL=1 AND HoaDon.DN=1 ", _
                                       ChungTu2TKHD(10), _
                                       ConvertToStrSafe(hd), _
                                       WThang("ThangCT", tdau, tcuoi)))
                    Else
                        QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,Mathuchi FROM {0} WHERE {1} AND HDBL=1 AND KCT=1 AND HoaDon.DN=1 ", _
                                       ChungTu2TKHD(10), _
                                       WThang("ThangCT", tdau, tcuoi)))
                    End If
                Case -2
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,Mathuchi FROM {0} WHERE HD={1} AND {2} AND KCT=1 AND HoaDon.DN=1 ", _
                                   ChungTu2TKHD(10), _
                                   ConvertToStrSafe(hd), _
                                   WThang("ThangCT", tdau, tcuoi)))
                Case -1
                    If Fx = 0 Then
                        QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,Mathuchi FROM {0} WHERE HD={1} AND {2} AND HoaDon.DN=1 ", _
                                       ChungTu2TKHD(10), _
                                       ConvertToStrSafe(hd), _
                                       WThang("ThangCT", tdau, tcuoi)))
                    Else
                        QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,Mathuchi FROM {0} WHERE HD={1} AND {2} AND (HDBL=0 OR KCT=0) AND HoaDon.DN=1 ", _
                                       ChungTu2TKHD(10), _
                                       ConvertToStrSafe(hd), _
                                       WThang("ThangCT", tdau, tcuoi)))
                    End If
                Case 30
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,Mathuchi FROM {0} WHERE (TyLe=5 OR TyLe=10) AND HD={1} AND {2} AND KCT=0 AND HoaDon.DN=1 ", _
                                   ChungTu2TKHD(10), _
                                   ConvertToStrSafe(hd), _
                                   WThang("ThangCT", tdau, tcuoi)))
                Case Else
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,Mathuchi FROM {0} WHERE TyLe={1} AND HD={2} AND {3} AND KCT=0 AND HDBL=0 AND HoaDon.DN=1 ", _
                                   ChungTu2TKHD(10), _
                                   ConvertToStrSafe(TL), _
                                   ConvertToStrSafe(hd), _
                                   WThang("ThangCT", tdau, tcuoi)))
            End Select
        Else
            Select Case TL
                Case -3
                    If Fx = 0 Then
                        QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,Mathuchi FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HD={1} AND {2} AND HethongTK.Sohieu LIKE '{3}%' AND HDBL=1 AND HoaDon.DN=1 ", _
                                       ChungTu2TKHD(10), _
                                       ConvertToStrSafe(hd), _
                                       WThang("ThangCT", tdau, tcuoi), _
                                       TK.sohieu))
                    Else
                        QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,Mathuchi FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE {1} AND HethongTK.Sohieu LIKE '{2}%' AND HDBL=1 AND KCT=1 AND HoaDon.DN=1 ", _
                                       ChungTu2TKHD(10), _
                                       WThang("ThangCT", tdau, tcuoi), _
                                       TK.sohieu))
                    End If
                Case -2
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,Mathuchi FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HD={1} AND {2} AND KCT=1 AND HethongTK.Sohieu LIKE '{3}%' AND HoaDon.DN=1 ", _
                                   ChungTu2TKHD(10), _
                                   ConvertToStrSafe(hd), _
                                   WThang("ThangCT", tdau, tcuoi), _
                                   TK.sohieu))
                Case -1
                    If Fx = 0 Then
                        QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,Mathuchi FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HD={1} AND {2} AND HethongTK.Sohieu LIKE '{3}%' AND HoaDon.DN=1 ", _
                                       ChungTu2TKHD(10), _
                                       ConvertToStrSafe(hd), _
                                       WThang("ThangCT", tdau, tcuoi), _
                                       TK.sohieu))
                    Else
                        QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,Mathuchi FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HD={1} AND {2} AND HethongTK.Sohieu LIKE '{3}%' AND (HDBL=0 OR KCT=0) AND HoaDon.DN=1 ", _
                                       ChungTu2TKHD(10), _
                                       ConvertToStrSafe(hd), _
                                       WThang("ThangCT", tdau, tcuoi), _
                                       TK.sohieu))
                    End If
                Case 30
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,Mathuchi FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE (TyLe=5 OR TyLe=10) AND HD={1} AND {2} AND KCT=0 AND HethongTK.Sohieu LIKE '{3}%' AND HoaDon.DN=1 ", _
                                   ChungTu2TKHD(10), _
                                   ConvertToStrSafe(hd), _
                                   WThang("ThangCT", tdau, tcuoi), _
                                   TK.sohieu))
                Case Else
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,Mathuchi FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE TyLe={1} AND HD={2} AND {3} AND KCT=0 AND HDBL=0 AND HethongTK.Sohieu LIKE '{4}%' AND HoaDon.DN=1 ", _
                                   ChungTu2TKHD(10), _
                                   ConvertToStrSafe(TL), _
                                   ConvertToStrSafe(hd), _
                                   WThang("ThangCT", tdau, tcuoi), _
                                   TK.sohieu))
            End Select
        End If
        GauGe.Value = 1
        Mientru = (String.Format("SELECT MaCT FROM {0} WHERE {1} AND HoaDon.Loai=-1 GROUP BY MaCT", _
                       ChungTu2TKHD(0), _
                       WThang("ThangCT", tdau, tcuoi)))
        QCdt = (String.Format("SELECT MaCT FROM ChungTu WHERE {0} AND MaVattu>0 AND (MaLoai=1 or MaLoai=13 or MaLoai=9) GROUP BY MaCT HAVING Count(MaVattu)>=1", WThang("ThangCT", tdau, tcuoi)))
        QDuPhong = (String.Format("SELECT ChungTu.MaCT,TenVattu as MH,SoPS2No AS SL,SoPS AS TT,vattu.donvi as dvt,vattu.sohieu as shvt,chungtu.maso as maso1 FROM ((((ChungTu INNER JOIN (" & Mientru & ")as MienTru ON ChungTu.MaCT=MienTru.MaCT) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN ({0}) As QCdt ON ChungTu.MaCT=QCdt.MaCT)inner join tonkho ton on vattu.maso=ton.mavattu WHERE (TK_ID={1} OR HethongTK.Loai=6)", _
                        QCdt, _
                        TKVT_ID))
        QChitiet = (String.Format("SELECT QNhatKy.*,QDuPhong.* FROM ({0}) As QNhatky LEFT JOIN ({1}) As QDuPhong ON QNhatKy.MaCT=QDuPhong.MaCT ORDER BY NgayPH,SoHD,maso1", _
                        QNhatKy, _
                        QDuPhong))
        rptFrom.InitForm("BANGKEVDN.RPT", QChitiet, "QChitiet")

        If TK.maso > 0 Then
            rptFrom.SetFormulas("TenCn", String.Format("'{0}'", TK.ten))
            rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", TK.GhiChu))
        Else
            rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))
        End If

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        rptFrom.SetFormulas("MSThue", String.Format("'{0}'", frmMain._LbCty_8.Text))
        DNTen = FrmGetStr.GetString(Ngonngu("Người phụ trách thu mua:", "Shoppers:"), My.Application.Info.ProductName, DNTen)
        rptFrom.SetFormulas("DNten", String.Format("'{0}'", DNTen))
        DNDiachi = FrmGetStr.GetString(Ngonngu("Địa chỉ nơi tổ chức thu mua:", "Shipping address"), My.Application.Info.ProductName, DNDiachi)
        rptFrom.SetFormulas("DNdiachi", String.Format("'{0}'", DNDiachi))
        Return True
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="TL"></param>
    ''' <param name="hd"></param>
    ''' <param name="TK"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function InVATDauVao2(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef TL As Integer, ByRef hd As Integer, ByRef TK As ClsTaikhoan, Optional ByRef SNK As String = "") As Boolean
        Dim sql As String = String.Empty
        Dim Tk2 As New ClsTaikhoan
        Dim Fx As Integer = IIf(Strings.Left(frmMain._LbCty_8.Text, 2) = "35" Or Strings.Left(frmMain._LbCty_3.Text, 2) = "64", 35, 0)
        Tk2.InitTaikhoanSohieu("33312")
        If Tk2.tk_id = GTGTKT_ID Then
            sql = String.Format("DELETE HoaDon  FROM ((HoaDon INNER JOIN ChungTu ON HoaDon.MaSo=ChungTu.MaSo) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo  WHERE (HethongTK.SoHieu LIKE '{0}%') AND (TK.SoHieu LIKE '33312%'  OR CHARINDEX(ChungTu.GhiChu,'33312')>0) AND HoaDon.Loai=-1", pVATV)
            ExecSQLNonQuery(sql)
        End If
        GauGe.Maximum = 1
        If TK.maso = 0 Then
            Select Case TL
                Case -3
                    If Fx = 0 Then
                        QNhatKy = (String.Format("SELECT DISTINCT KyHieu,KyHieuMau,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,ChungTu.MaThuChi FROM {0} WHERE Loai=-1 AND HD={1} AND {2} AND HDBL=1 AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ", _
                                       ChungTu2TKHD(10), _
                                       ConvertToStrSafe(hd), _
                                       WThang("ThangCT", tdau, tcuoi)))
                    Else
                        QNhatKy = (String.Format("SELECT DISTINCT KyHieu,KyHieuMau,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,ChungTu.MaThuChi FROM {0} WHERE Loai=-1 AND {1} AND HDBL=1 AND KCT=1 AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ", _
                                       ChungTu2TKHD(10), _
                                       WThang("ThangCT", tdau, tcuoi)))
                    End If
                Case -2
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieu,KyHieuMau,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,ChungTu.MaThuChi FROM {0} WHERE Loai=-1 AND HD={1} AND {2} AND KCT=1 AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ", _
                                   ChungTu2TKHD(10), _
                                   ConvertToStrSafe(hd), _
                                   WThang("ThangCT", tdau, tcuoi)))
                Case -1
                    If Fx = 0 Then
                        QNhatKy = (String.Format("SELECT DISTINCT KyHieu,KyHieuMau,SoHD,NgayPH,NgayCT,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,ChungTu.MaThuChi FROM {0} WHERE Loai=-1 AND HD={1} AND {2} AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ", _
                                       ChungTu2TKHD(10), _
                                       ConvertToStrSafe(hd), _
                                       WThang("ThangCT", tdau, tcuoi)))
                    Else
                        QNhatKy = (String.Format("SELECT DISTINCT KyHieu,KyHieuMau,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,ChungTu.MaThuChi FROM {0} WHERE Loai=-1 AND HD={1} AND {2} AND (HDBL=0 OR KCT=0) AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ", _
                                       ChungTu2TKHD(10), _
                                       ConvertToStrSafe(hd), _
                                       WThang("ThangCT", tdau, tcuoi)))
                    End If
                Case 30
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieu,KyHieuMau,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,ChungTu.MaThuChi FROM {0} WHERE Loai=-1 AND (TyLe=5 OR TyLe=10) AND HD={1} AND {2} AND KCT=0 AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ", _
                                   ChungTu2TKHD(10), _
                                   ConvertToStrSafe(hd), _
                                   WThang("ThangCT", tdau, tcuoi)))
                Case Else
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieu,KyHieuMau,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,ChungTu.MaThuChi FROM {0} WHERE Loai=-1 AND TyLe={1} AND HD={2} AND {3} AND KCT=0 AND HDBL=0 AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ", _
                                   ChungTu2TKHD(10), _
                                   ConvertToStrSafe(TL), _
                                   ConvertToStrSafe(hd), _
                                   WThang("ThangCT", tdau, tcuoi)))
            End Select
        Else
            Select Case TL
                Case -3
                    If Fx = 0 Then
                        QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,ChungTu.MaThuChi FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HoaDon.Loai=-1 AND HD={1} AND {2} AND HethongTK.Sohieu LIKE '{3}%' AND HDBL=1 AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ", _
                                       ChungTu2TKHD(10), _
                                       ConvertToStrSafe(hd), _
                                       WThang("ThangCT", tdau, tcuoi), _
                                       TK.sohieu))
                    Else
                        QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,ChungTu.MaThuChi FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HoaDon.Loai=-1 AND {1} AND HethongTK.Sohieu LIKE '{2}%' AND HDBL=1 AND KCT=1 AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ", _
                                       ChungTu2TKHD(10), _
                                       WThang("ThangCT", tdau, tcuoi), _
                                       TK.sohieu))
                    End If
                Case -2
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,ChungTu.MaThuChi FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HoaDon.Loai=-1 AND HD={1} AND {2} AND KCT=1 AND HethongTK.Sohieu LIKE '{3}%' AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ", _
                                   ChungTu2TKHD(10), _
                                   ConvertToStrSafe(hd), _
                                   WThang("ThangCT", tdau, tcuoi), _
                                   TK.sohieu))
                Case -1
                    If Fx = 0 Then
                        QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,ChungTu.MaThuChi FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HoaDon.Loai=-1 AND HD={1} AND {2} AND HethongTK.Sohieu LIKE '{3}%' AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ", _
                                       ChungTu2TKHD(10), _
                                       ConvertToStrSafe(hd), _
                                       WThang("ThangCT", tdau, tcuoi), _
                                       TK.sohieu))
                    Else
                        QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,ChungTu.MaThuChi FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HoaDon.Loai=-1 AND HD={1} AND {2} AND HethongTK.Sohieu LIKE '{3}%' AND (HDBL=0 OR KCT=0) AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ", _
                                       ChungTu2TKHD(10), _
                                       ConvertToStrSafe(hd), _
                                       WThang("ThangCT", tdau, tcuoi), _
                                       TK.sohieu))
                    End If
                Case 30
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,ChungTu.MaThuChi FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HoaDon.Loai=-1 AND (TyLe=5 OR TyLe=10) AND HD={1} AND {2} AND KCT=0 AND HethongTK.Sohieu LIKE '{3}%' AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ", _
                                   ChungTu2TKHD(10), _
                                   ConvertToStrSafe(hd), _
                                   WThang("ThangCT", tdau, tcuoi), _
                                   TK.sohieu))
                Case Else
                    QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,ChungTu.MaThuChi FROM ({0}) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo WHERE HoaDon.Loai=-1 AND TyLe={1} AND HD={2} AND {3} AND KCT=0 AND HDBL=0 AND HethongTK.Sohieu LIKE '{4}%' AND ((HoaDon.DC=0 and HoaDon.DN=0) OR HD=1) ", ChungTu2TKHD(10), ConvertToStrSafe(TL), ConvertToStrSafe(hd), WThang("ThangCT", tdau, tcuoi), TK.sohieu))
            End Select
        End If
        GauGe.Value = 1
        If hd = 0 Then
            Mientru = (String.Format("SELECT MaCT FROM {0} WHERE {1} AND HoaDon.Loai=-1 GROUP BY MaCT", ChungTu2TKHD(0), WThang("ThangCT", tdau, tcuoi)))
            QCdt = (String.Format("SELECT MaCT FROM ChungTu WHERE {0} AND MaVattu>0 AND (MaLoai=1 or MaLoai=13 or MaLoai=9) GROUP BY MaCT HAVING Count(MaVattu)>=1", WThang("ThangCT", tdau, tcuoi)))
            QDuPhong = (String.Format("SELECT ChungTu.MaCT,TenVattu as MH,SoPS2No AS SL,SoPS AS TT,vattu.donvi as dvt,vattu.sohieu as shvt,chungtu.maso as maso1 FROM ((((ChungTu INNER JOIN (" & Mientru & ")as MienTru ON ChungTu.MaCT=MienTru.MaCT) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN ({0}) As QCdt ON ChungTu.MaCT=QCdt.MaCT)inner join tonkho ton on vattu.maso=ton.mavattu WHERE (TK_ID={1} OR HethongTK.Loai=6)", QCdt, TKVT_ID))
            QChitiet = (String.Format("SELECT QNhatKy.*,QDuPhong.* FROM ({0}) As QNhatky LEFT JOIN ({1}) As QDuPhong ON QNhatKy.MaCT=QDuPhong.MaCT ORDER BY NgayPH,SoHD,maso1", QNhatKy, QDuPhong))
            rptFrom.InitForm("BANGKEVKHD.RPT", QChitiet, "QChitiet")

            DNTen = FrmGetStr.GetString(Ngonngu("Người phụ trách thu mua:", "Shoppers:"), My.Application.Info.ProductName, DNTen)
            rptFrom.SetFormulas("KHDten", String.Format("'{0}'", DNTen))
            DNDiachi = FrmGetStr.GetString(Ngonngu("Địa chỉ nơi tổ chức thu mua:", "Shipping address"), My.Application.Info.ProductName, DNDiachi)
            rptFrom.SetFormulas("KHDdiachi", String.Format("'{0}'", DNDiachi))
        Else
            If (TL > 0 And TL < 5) Or TL = -3 Then
                rptFrom.InitForm("BANGKEV4.RPT", QNhatKy & " ORDER BY NgayPH ", "QNhatKy")
            Else
                If ConvertToDblSafe(Interaction.GetSetting(IniPath, "Invoice", "ListDetail", "0")) = 1 Then
                    Mientru = (String.Format("SELECT MaCT FROM {0} WHERE {1} AND HoaDon.Loai=-1 GROUP BY MaCT", ChungTu2TKHD(0), WThang("ThangCT", tdau, tcuoi)))
                    QCdt = (String.Format("SELECT MaCT FROM ChungTu WHERE {0} AND MaVattu>0 AND MaLoai=1 GROUP BY MaCT HAVING Count(MaVattu)>1", WThang("ThangCT", tdau, tcuoi)))
                    QDuPhong = (String.Format("SELECT ChungTu.MaCT,TenVattu,SoPS2No AS SL,SoPS AS TT FROM (((ChungTu INNER JOIN (" & Mientru & ") as MienTru ON ChungTu.MaCT=MienTru.MaCT) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN ({0}) As QCdt ON ChungTu.MaCT=QCdt.MaCT WHERE (TK_ID={1} OR HethongTK.Loai=6)", QCdt, TKVT_ID))
                    QChitiet = (String.Format("SELECT QNhatKy.*,TenVattu,SL,TT FROM ({0}) As QNhatky LEFT JOIN ({1}) As QDuPhong ON QNhatKy.MaCT=QDuPhong.MaCT ORDER BY TyLe,NgayPH,SoHD", QNhatKy, QDuPhong))
                    rptFrom.InitForm("BANGKEV6.RPT", QChitiet , "QChitiet")
                Else
                    rptFrom.InitForm("BANGKEV2.RPT", QNhatKy & " ORDER BY NgayPH, SoHD ", "QNhatKy")
                End If
            End If
        End If
        SNK = QNhatKy
        If TK.maso = 0 Then
            rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))
        Else
            rptFrom.SetFormulas("TenCn", String.Format("'{0}'", TK.ten))
            rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", TK.GhiChu))
        End If

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        rptFrom.SetFormulas("MSThue", String.Format("'{0}'", frmMain._LbCty_8.Text))
        rptFrom.SetFormulas("TLKT", TL)
        Return True
    End Function
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
            sql = String.Format("DELETE HoaDon  FROM ((HoaDon INNER JOIN ChungTu ON HoaDon.MaSo=ChungTu.MaSo) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo  WHERE (HethongTK.SoHieu LIKE '{0}%') AND (TK.SoHieu LIKE '33312%'  OR CHARINDEX(ChungTu.GhiChu,'33312')>0) AND HoaDon.Loai=-1", pVATV)
            ExecSQLNonQuery(sql)
        End If
        rptFrom.InitForm("TOKHAI.RPT", "SELECT * FROM License", "License")

        GauGe.Maximum = 6
        rptFrom.SetFormulas("Thang", tdau)
        rptFrom.SetFormulas("ThangCuoi", tcuoi)
        rptFrom.SetFormulas("ThangNay", pThangDauKy)
        If taikhoan.maso = 0 Then
            rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))
        Else
            rptFrom.SetFormulas("TenCn", String.Format("'{0}'", taikhoan.ten))
            rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", taikhoan.GhiChu))
        End If
        rptFrom.SetFormulas("MSThue", String.Format("'{0}'", frmMain._LbCty_8.Text))
        rptFrom.SetFormulas("SohieuTK", String.Format("'{0}'", vatr))
        rptFrom.SetFormulas("Quan", String.Format("'{0}'", frmMain._LbCty_10.Text))
        rptFrom.SetFormulas("TP", String.Format("'{0}'", frmMain._LbCty_11.Text))
        rptFrom.SetFormulas("Tel", String.Format("'{0}'", frmMain._LbCty_3.Text))
        rptFrom.SetFormulas("Fax", String.Format("'{0}'", frmMain._LbCty_4.Text))
        rptFrom.SetFormulas("Email", String.Format("'{0}'", frmMain._LbCty_9.Text))
        Dim shct As String = taikhoan.SHChiTiet()
        Dim vr As Double = ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(ThanhTien) AS F1 FROM {0} WHERE HoaDon.Loai=1 AND {1} AND KCT=1 AND DC=0 AND RIGHT(HethongTK.SoHieu,{2}) = '{3}'", ChungTu2TKHD(1), WThang("ThangCT", tdau, tcuoi), ConvertToStrSafe(shct.Length), shct)))
        rptFrom.SetFormulas("DTKCT", vr)
        GauGe.Value = 1
        rptFrom.SetFormulas("Vat0DT", ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(ThanhTien) AS F1,SUM(CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END) AS F2 FROM {1} WHERE HoaDon.Loai=1 AND DC=0 AND {2} AND KCT=0 AND RIGHT(HethongTK.SoHieu,{3}) = '{4}' AND TyLe=0", GTGTPN_ID, ChungTu2TKHD(1), WThang("ThangCT", tdau, tcuoi), ConvertToStrSafe(shct.Length), shct), VV)))
        rptFrom.SetFormulas("Vat0", VV)
        rptFrom.SetFormulas("Vat5DT", ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(ThanhTien) AS F1,SUM(CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END) AS F2 FROM {1} WHERE HoaDon.Loai=1 AND DC=0 AND {2} AND KCT=0 AND RIGHT(HethongTK.SoHieu,{3}) = '{4}' AND TyLe=5", GTGTPN_ID, ChungTu2TKHD(1), WThang("ThangCT", tdau, tcuoi), ConvertToStrSafe(shct.Length), shct), VV)))
        rptFrom.SetFormulas("Vat5", VV)
        rptFrom.SetFormulas("Vat10DT", ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(ThanhTien) AS F1,SUM(CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END) AS F2 FROM {1} WHERE HoaDon.Loai=1 AND DC=0 AND {2} AND KCT=0 AND RIGHT(HethongTK.SoHieu,{3}) = '{4}' AND TyLe=10", GTGTPN_ID, ChungTu2TKHD(1), WThang("ThangCT", tdau, tcuoi), ConvertToStrSafe(shct.Length), shct), VV)))
        rptFrom.SetFormulas("Vat10", VV)
        'Dieu chinh
        sql = String.Format("SELECT Sum(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=1 AND DC=1 AND {1} AND KCT=0 AND RIGHT(HethongTK.SoHieu,{2}) = '{3}'", ChungTu2TKHD(1), WThang("ThangCT", tdau, tcuoi), ConvertToStrSafe(shct.Length), shct)
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
            sql = String.Format("SELECT SUM(ThanhTien) AS F1 FROM {0} WHERE HoaDon.Loai=-1 AND HD=1 AND DC=0 AND KCT=0 AND {1} AND RIGHT(HethongTK.SoHieu,{2}) = '{3}'", ChungTu2TKHD(-1), WThang("ThangCT", tdau, tcuoi), ConvertToStrSafe(shct.Length), shct)
        Else
            sql = String.Format("SELECT SUM(ThanhTien) AS F1 FROM {0} WHERE HoaDon.Loai=-1 AND HD=1 AND DC=0 AND KCT=0 AND {1}", ChungTu2TKHD(0), WThang("ThangCT", tdau, tcuoi))
        End If
        Dim vvx As Double = ConvertToDblSafe(GetSelectValue(sql)) + kt
        rptFrom.SetFormulas("TongVaoV", vvx)
        If shct.Length > 0 Then
            sql = String.Format("SELECT SUM(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=-1 AND DC=0 AND {1} AND RIGHT(HethongTK.SoHieu,{2}) = '{3}'", ChungTu2TKHD(-1), WThang("ThangCT", tdau, tcuoi), ConvertToStrSafe(shct.Length), shct)
        Else
            sql = String.Format("SELECT SUM(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=-1 AND DC=0 AND {1}", ChungTu2TKHD(0), WThang("ThangCT", tdau, tcuoi))
        End If
        vvx = ConvertToDblSafe(GetSelectValue(sql, VV)) + kt
        rptFrom.SetFormulas("TongVao", vvx)
        sql = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE (HethongTK.SoHieu LIKE '142%' OR HethongTK.SoHieu LIKE '242%' OR HethongTK.SoHieu LIKE '6%') AND (TK.SoHieu LIKE '{1}%') AND RIGHT(TK.SoHieu,{2})='{3}' AND {4}", ChungTu2TKNC(0), pVATV, ConvertToStrSafe(shct.Length), shct, WThang("ThangCT", tdau, tcuoi))
        rptFrom.SetFormulas("TongVATV", ConvertToDblSafe(VV - ConvertToDblSafe(GetSelectValue(sql))))
        If TK.tk_id = GTGTKT_ID Then
            Mientru = (String.Format("SELECT MaCT FROM {0} WHERE (HethongTK.SoHieu LIKE '521%' OR HethongTK.SoHieu LIKE '531%') AND {1}", ChungTu2TKNC(-1), WThang("ThangCT", tdau, tcuoi)))
            sql = String.Format("SELECT SUM(SoPS) AS F1 FROM ({0}) LEFT JOIN ({1}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT  WHERE (MienTru.MaCT=null) AND (HethongTK.SoHieu LIKE '33312%') AND RIGHT(HethongTK.SoHieu,{2})='{3}' AND {4} AND (TK.SoHieu LIKE '11%' OR TK.SoHieu LIKE '136%')", ChungTu2TKNC(0), Mientru, shct.Length, shct, WThang("ThangCT", tdau, tcuoi))
            rptFrom.SetFormulas("TongVATx", ConvertToDblSafe(VV - GetSelectValue(sql)) + PSDu(pVATV, "33312", tdau, tcuoi, shct))
        Else
            rptFrom.SetFormulas("TongVATx=" & CStr(VV))
        End If
        GauGe.Value = 3
        'Dieu chinh
        If shct.Length > 0 Then
            sql = String.Format("SELECT SUM(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=-1 AND DC=1 AND {1} AND RIGHT(HethongTK.SoHieu,{2}) = '{3}'", ChungTu2TKHD(-1), WThang("ThangCT", tdau, tcuoi), ConvertToStrSafe(shct.Length), shct)
        Else
            sql = String.Format("SELECT SUM(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=-1 AND DC=1 AND {1}", ChungTu2TKHD(0), WThang("ThangCT", tdau, tcuoi))
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
            sql = String.Format("SELECT SUM(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=-1 AND NK=1 AND {1} AND RIGHT(HethongTK.SoHieu,{2}) = '{3}'", ChungTu2TKHD(-1), WThang("ThangCT", tdau, tcuoi), ConvertToStrSafe(shct.Length), shct)
        Else
            sql = String.Format("SELECT SUM(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=-1 AND NK=1 AND {1}", ChungTu2TKHD(0), WThang("ThangCT", tdau, tcuoi))
        End If
        vvx = ConvertToDblSafe(GetSelectValue(sql, VV))
        rptFrom.SetFormulas("NK=" & CStr(vvx))
        rptFrom.SetFormulas("NKV=" & CStr(VV))
        ' Tai san
        If shct.Length > 0 Then
            sql = String.Format("SELECT SUM(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=-1 AND TS=1 AND {1} AND RIGHT(HethongTK.SoHieu,{2}) = '{3}'", ChungTu2TKHD(-1), WThang("ThangCT", tdau, tcuoi), ConvertToStrSafe(shct.Length), shct)
        Else
            sql = String.Format("SELECT SUM(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=-1 AND TS=1 AND {1}", ChungTu2TKHD(0), WThang("ThangCT", tdau, tcuoi))
        End If
        vvx = ConvertToDblSafe(GetSelectValue(sql, VV))
        rptFrom.SetFormulas("TS=" & CStr(vvx))
        rptFrom.SetFormulas("TSV=" & CStr(VV))
        kt = ConvertToDblSafe(DKToKhai(tdau, shct))
        If kt > 0 Then rptFrom.SetFormulas("KyTruoc", kt)
        sql = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE (TK.SoHieu LIKE '{1}112%' OR TK.SoHieu LIKE '{1}212%') AND RIGHT(TK.SoHieu,{2})='{3}' AND {4} AND (HethongTK.SoHieu LIKE '336%' OR HethongTK.SoHieu LIKE '11%' OR HethongTK.SoHieu LIKE '138%')", ChungTu2TKNC(0), pVATV, ConvertToStrSafe(shct.Length), shct, WThang("ThangCT", tdau, tcuoi))
        VV = ConvertToDblSafe(GetSelectValue(sql))
        rptFrom.SetFormulas("HoanTra", VV)
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        GauGe.Value = 4
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <param name="taikhoan"></param>
    ''' <remarks></remarks>
    Private Sub ToKhaiVAT2(ByRef thang As Integer, ByRef taikhoan As ClsTaikhoan)
        Dim prg As Integer
        Dim TK As New ClsTaikhoan
        Dim f1 As Integer = 0
        Dim mvpath As String = KiemTraMaVach(2, CurrentDrive() & "\Program Files\HTKK130\Project\HTKK.exe")
        If Not (FileSystem.Dir(mvpath, FileAttribute.Normal).Length = 0 Or mvpath.Length = 0) Then
            Dim startInfo As ProcessStartInfo = New ProcessStartInfo(mvpath)
            startInfo.WindowStyle = ProcessWindowStyle.Normal
            prg = ConvertToDblSafe(Process.Start(startInfo).Id)

        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="loai"></param>
    ''' <param name="dd"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function KiemTraMaVach(ByRef loai As Integer, ByRef dd As String) As String
        Dim result As String = String.Empty
        Dim st As String = Interaction.GetSetting(IniPath, "VAT", String.Format("{0}_MV{1}", GetFileName(pDataPath), ConvertToStrSafe(loai)), )
        Try
            If st.Length = 0 Or FileSystem.Dir(st, FileAttribute.Normal).Length = 0 Then
                st = FrmGetStr.GetString(Ngonngu("Đường dẫn chương trình mã vạch:", "Program path barcode"), My.Application.Info.ProductName, dd)
                If FileSystem.Dir(st, FileAttribute.Normal).Length > 0 Then
                    Interaction.SaveSetting(IniPath, "VAT", String.Format("{0}_MV{1}", GetFileName(pDataPath), ConvertToStrSafe(loai)), st)
                    result = st
                End If
            Else
                result = st
            End If
        Catch
        End Try
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="TL"></param>
    ''' <param name="TK"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function InThueTTDB(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef TL As Integer, ByRef TK As ClsTaikhoan) As Boolean
        Dim sql As String = String.Empty
        GauGe.Maximum = 1
        Select Case TL
            Case -2
                QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS Thue,KhachHang.DiaChi,TyLe,GiaTT FROM {1} WHERE hoadon.hd=1 and HoaDon.Loai=2 AND {2} AND KCT=1 AND HethongTK.SoHieu LIKE '{3}%'ORDER BY NgayPH", TTDB_ID, ChungTu2TKHD(2), WThang("ThangCT", tdau, tcuoi), TK.sohieu))
            Case -1
                QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS Thue,KhachHang.DiaChi,TyLe,GiaTT FROM {1} WHERE hoadon.hd=1 and HoaDon.Loai=2 AND {2} AND HethongTK.SoHieu LIKE '{3}%' ORDER BY NgayPH", TTDB_ID, ChungTu2TKHD(2), WThang("ThangCT", tdau, tcuoi), TK.sohieu))
            Case 30
                QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS Thue,KhachHang.DiaChi,TyLe,GiaTT FROM {1} WHERE hoadon.hd=1 and HoaDon.Loai=2 AND (TyLe=5 OR TyLe=10) AND {2} AND KCT=0 AND HethongTK.SoHieu LIKE '{3}%' ORDER BY NgayPH", TTDB_ID, ChungTu2TKHD(2), WThang("ThangCT", tdau, tcuoi), TK.sohieu))
            Case Else
                QNhatKy = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END AS Thue,KhachHang.DiaChi,TyLe,GiaTT FROM {1} WHERE hoadon.hd=1 and HoaDon.Loai=2 AND TyLe={2} AND {3} AND KCT=0 AND HethongTK.SoHieu LIKE '{4}%' ORDER BY NgayPH", TTDB_ID, ChungTu2TKHD(2), ConvertToStrSafe(TL), WThang("ThangCT", tdau, tcuoi), TK.sohieu))
        End Select
        GauGe.Value = 1
        rptFrom.InitForm("BANGKER2.RPT", QNhatKy, "QNhatKy")

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))
        rptFrom.SetFormulas("MSThue", String.Format("'{0}'", frmMain._LbCty_8.Text))
        rptFrom.SetFormulas("TLKT", TL)
        Return True
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="TK"></param>
    ''' <remarks></remarks>
    Private Sub BangKeBanRa(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef TK As ClsTaikhoan)
        GauGe.Maximum = 1
        Mientru = (String.Format("SELECT MaCT FROM {0} WHERE TK_ID={1} AND HethongTK.SoHieu LIKE '{2}%' AND {3} GROUP BY MaCT", ChungTu2TKNC(1), ConvertToStrSafe(TTDB_ID), TK.sohieu, WThang("ThangCT", tdau, tcuoi)))
        QNhatKy = (String.Format("SELECT ChungTu.SoHieu,NgayCT,Vattu.TenVattu,SoPS2Co,SoPS FROM ((ChungTu INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN HethongTK ON ChungTu.MaTKCo=HethongTK.MaSo) INNER JOIN ({0}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT  WHERE TK_ID={1}", Mientru, TKDT_ID))
        rptFrom.InitForm("BANGKER3.RPT", QNhatKy, "QNhatKy")

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))
        rptFrom.SetFormulas("MSThue", String.Format("'{0}'", frmMain._LbCty_8.Text))
        GauGe.Value = 1
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="loai"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="shtk"></param>
    ''' <param name="shdu"></param>
    ''' <remarks></remarks>
    Private Sub InBKTheoTK(ByRef loai As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef shtk As String, ByRef shdu As String)
        Dim sql As String = String.Empty
        GauGe.Maximum = 1
        Mientru = (String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,KhachHang.Ten,KhachHang.MST,ChungTu.SoHieu,SoPS,KhachHang.DiaChi,(Thanhtien*TyLe/100) as thue,TyLe,HTTT,MauSo,MaCT,HoaDon.MaSo,KCT,HethongTK.SoHieu AS TKDU FROM ({0}) LEFT JOIN HethongTK ON ChungTu.MaTK{1}=HethongTK.MaSo WHERE HoaDon.Loai={2} AND {3} ", ChungTu2TKHD(10), (IIf(loai < 0, "No", "Co")), ConvertToStrSafe(loai), WThang("ThangCT", tdau, tcuoi)))
        QChitiet = (String.Format("SELECT DISTINCT MaCT FROM ChungTu INNER JOIN HethongTK ON ChungTu.MaTK{0}=HethongTK.MaSo WHERE {1} AND HethongTK.SoHieu LIKE '{2}%' GROUP BY MaCT", (IIf(loai < 0, "No", "Co")), WThang("ThangCT", tdau, tcuoi), shtk))
        QCdt = (String.Format("SELECT DISTINCT MaCT FROM ChungTu INNER JOIN HethongTK ON ChungTu.MaTK{0}=HethongTK.MaSo WHERE {1} AND HethongTK.SoHieu LIKE '{2}%' GROUP BY MaCT", (IIf(loai < 0, "Co", "No")), WThang("ThangCT", tdau, tcuoi), shdu))
        QNhatKy = (String.Format("SELECT MienTru.* FROM ({0}) AS MienTru INNER JOIN ({1}) AS QChitiet ON MienTru.MaCT=QChitiet.MaCT INNER JOIN ({2}) As QCdt ON MienTru.MaCT=QCdt.MaCT ORDER BY NgayPH,MienTru.MaCT", Mientru, QChitiet, QCdt))
        GauGe.Value = 1
        rptFrom.InitForm(String.Format("BANGKE{0}7.RPT", (IIf(loai < 0, "V", "R"))), QNhatKy, "QNhatKy")

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("thang", tdau)
        rptFrom.SetFormulas("ThangCuoi", tcuoi)
        If loai < 0 Then
            rptFrom.SetFormulas("tenbaocao", pThangDauKy)
        Else
            rptFrom.SetFormulas("thoigian", pThangDauKy)
        End If
        rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))
        rptFrom.SetFormulas("MSThue", String.Format("'{0}'", frmMain._LbCty_8.Text))
        rptFrom.SetFormulas("TK", String.Format("'{0}{1}'", (IIf(shtk.Length > 0, String.Format("Tài khoản: {0}", shtk), String.Empty)), (IIf(shdu.Length > 0, String.Format(" - Đối ứng: {0}", shdu), String.Empty))))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub InVAT(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim TK As New ClsTaikhoan
        Dim X, lk1, dk, duno, duco, Y As Double
        GauGe.Maximum = 10
        ExecSQLNonQuery("UPDATE VAT SET KyNay = 0,LuyKe=0")

        TK.InitTaikhoanSohieu(pVATV)
        TK.SoDuTK(ThangTruoc(tdau), duno, duco, X)
        Dim kn As Double = duno - duco
        TK.SoDuTK(0, duno, duco, X)
        Dim lk As Double = duno - duco
        TK.InitTaikhoanSohieu(vatr)
        TK.SoDuTK(ThangTruoc(tdau), duno, duco, X)
        kn = kn + duno - duco
        TK.SoDuTK(0, duno, duco, X)
        lk = lk + duno - duco
        Dim lk2 As Double = -kn
        ExecSQLNonQuery(String.Format("UPDATE VAT SET KyNay = {0},LuyKe = {1} WHERE MaSo = '10'", CStr(Math.Max(kn, 0)), CStr(Math.Max(lk, 0))))
        ExecSQLNonQuery(String.Format("UPDATE VAT SET KyNay = {0},LuyKe = {1} WHERE MaSo = '40'", CStr(IIf(kn < 0, -kn, 0)), CStr(IIf(lk < 0, -lk, 0))))
        VATHoanLai(tdau, tcuoi, dk, duno, lk1, duco, X)
        ExecSQLNonQuery(String.Format("UPDATE VAT SET KyNay = {0} WHERE MaSo = '20'", CStr(dk)))
        ExecSQLNonQuery(String.Format("UPDATE VAT SET KyNay = {0}, LuyKe = {1} WHERE MaSo = '21'", CStr(duno), CStr(lk1)))
        ExecSQLNonQuery(String.Format("UPDATE VAT SET KyNay = {0}, LuyKe = {1} WHERE MaSo = '22'", CStr(duco), CStr(X)))
        ExecSQLNonQuery(String.Format("UPDATE VAT SET KyNay = {0} WHERE MaSo = '23'", CStr(dk + duno - duco)))
        VATMienGiam(tdau, tcuoi, dk, duno, lk1, duco, X)
        ExecSQLNonQuery(String.Format("UPDATE VAT SET KyNay = {0} WHERE MaSo = '30'", CStr(dk)))
        ExecSQLNonQuery(String.Format("UPDATE VAT SET KyNay = {0}, LuyKe = {1} WHERE MaSo = '31'", CStr(duno), CStr(lk1)))
        ExecSQLNonQuery(String.Format("UPDATE VAT SET KyNay = {0}, LuyKe = {1} WHERE MaSo = '32'", CStr(duco), CStr(X)))
        ExecSQLNonQuery(String.Format("UPDATE VAT SET KyNay = {0} WHERE MaSo = '33'", CStr(dk + duno - duco)))
        GauGe.Value = 1
        Mientru = (String.Format("SELECT MaCT FROM {0} WHERE (HethongTK.SoHieu LIKE '521%' OR HethongTK.SoHieu LIKE '531%' OR HethongTK.SoHieu LIKE '532%') AND {1}", ChungTu2TKNC(-1), WThang("ThangCT", 0, tcuoi)))
        Dim sql As String = String.Format("SELECT SUM(CASE WHEN ({0}) THEN CASE WHEN (TK_ID={1}) THEN SoPS ELSE -SoPS END ELSE 0 END ) AS F1, SUM(CASE WHEN (TK_ID={1}) THEN SoPS ELSE -SoPS END ) AS F2 FROM ({2}) LEFT JOIN ({3}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT WHERE MienTru.MaCT=null AND HoaDon.Loai=1 AND {4} AND KCT=0 AND DC=0", WThang("ThangCT", tdau, 0), ConvertToStrSafe(GTGTPN_ID), ChungTu2TKHD(1), Mientru, WThang("ThangCT", 0, tcuoi))
        kn = ConvertToDblSafe(GetSelectValue(sql, lk))
        ExecSQLNonQuery(String.Format("UPDATE VAT SET KyNay = {0},LuyKe = {1} WHERE MaSo = '41'", CStr(kn), CStr(lk)))
        lk2 += kn
        If TK.tk_id = GTGTKT_ID Then
            sql = String.Format("SELECT SUM(CASE WHEN ({0}) THEN SoPS ELSE 0 END) AS F1,SUM(SoPS) AS F2 FROM ({1}) LEFT JOIN ({2}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT  WHERE IsNull(MienTru.MaCT) AND (HethongTK.SoHieu LIKE '33312%') AND {3} AND (TK.SoHieu LIKE '11%' OR TK.SoHieu LIKE '136%')", WThang("ThangCT", tdau, 0), ChungTu2TKNC(0), Mientru, WThang("ThangCT", 0, tcuoi))
            X = ConvertToDblSafe(ConvertToDblSafe(GetSelectValue(sql, Y)) - PSDu(pVATV, "33312", tdau, tcuoi))
            Y -= PSDu(pVATV, "33312", pThangDauKy, tcuoi)
        Else
            X = 0
            Y = 0
        End If
        sql = String.Format("SELECT SUM(CASE WHEN ({0}) THEN SoPS ELSE 0 END) AS F1,SUM(SoPS) AS F2 FROM {1} WHERE HoaDon.Loai=-1 AND {2}", WThang("ThangCT", tdau, 0), ChungTu2TKHD(0), WThang("ThangCT", 0, tcuoi))
        kn = ConvertToDblSafe(GetSelectValue(sql, lk))
        ExecSQLNonQuery(String.Format("UPDATE VAT SET KyNay = {0},LuyKe = {1} WHERE MaSo = '11'", CStr(kn - X), CStr(lk - Y)))
        lk2 -= (kn - X)
        sql = String.Format("SELECT SUM(CASE WHEN ({0}) THEN SoPS ELSE 0 END) AS F1,SUM(SoPS) AS F2 FROM {1} WHERE (HethongTK.SoHieu LIKE '142%' OR HethongTK.SoHieu LIKE '242%' OR HethongTK.SoHieu LIKE '6%' OR HethongTK.SoHieu LIKE '421%') AND (TK.SoHieu LIKE '{2}%') AND {3}", WThang("ThangCT", tdau, 0), ChungTu2TKNC(0), pVATV, WThang("ThangCT", 0, tcuoi))
        kn = ConvertToDblSafe(GetSelectValue(sql, lk))
        ExecSQLNonQuery(String.Format("UPDATE VAT SET KyNay = {0},LuyKe = {1} WHERE MaSo = '16'", CStr(kn), CStr(lk)))
        Dim CK As Double = kn
        Dim cklk As Double = lk
        sql = String.Format("SELECT SUM(CASE WHEN ({0}) THEN SoPS ELSE 0 END) AS F1,SUM(SoPS) AS F2 FROM {1} WHERE (HethongTK.SoHieu LIKE '3331%') AND (TK.SoHieu LIKE '{2}%') AND {3}", WThang("ThangCT", tdau, 0), ChungTu2TKNC(0), pVATV, WThang("ThangCT", 0, tcuoi))
        kn = ConvertToDblSafe(GetSelectValue(sql, lk))
        ExecSQLNonQuery(String.Format("UPDATE VAT SET KyNay = {0},LuyKe = {1} WHERE MaSo = '13' OR MaSo = '42'", CStr(kn), CStr(lk)))
        CK += kn
        cklk += lk
        sql = String.Format("SELECT SUM(CASE WHEN ({0}) THEN SoPS ELSE 0 END) AS F1,SUM(SoPS) AS F2 FROM {1} WHERE (HethongTK.SoHieu LIKE '11%' OR HethongTK.SoHieu LIKE '138%') AND (TK.SoHieu LIKE '{2}112%' OR TK.SoHieu LIKE '{2}212%') AND {3}", WThang("ThangCT", tdau, 0), ChungTu2TKNC(0), pVATV, WThang("ThangCT", 0, tcuoi))
        kn = ConvertToDblSafe(GetSelectValue(sql, lk))
        ExecSQLNonQuery(String.Format("UPDATE VAT SET KyNay = {0},LuyKe = {1} WHERE MaSo = '14'", CStr(kn), CStr(lk)))
        CK += kn
        cklk += lk
        sql = String.Format("SELECT SUM(CASE WHEN ({0}) THEN SoPS ELSE 0 END) AS F1,SUM(SoPS) AS F2 FROM {1} WHERE (TK.SoHieu LIKE '133111%') AND (HethongTK.SoHieu LIKE '331%' OR HethongTK.SoHieu LIKE '111%') AND {2}", WThang("ThangCT", tdau, 0), ChungTu2TKNC(0), WThang("ThangCT", 0, tcuoi))
        kn = ConvertToDblSafe(GetSelectValue(sql, lk))
        ExecSQLNonQuery(String.Format("UPDATE VAT SET KyNay = {0},LuyKe = {1} WHERE MaSo = '15'", CStr(kn), CStr(lk)))
        CK += kn
        cklk += lk
        ExecSQLNonQuery(String.Format("UPDATE VAT SET KyNay = {0},LuyKe = {1} WHERE MaSo = '12'", CStr(CK), CStr(cklk)))
        sql = String.Format("SELECT SUM(CASE WHEN ({0}) THEN SoPS ELSE 0 END) AS F1,SUM(SoPS) AS F2 FROM {1} WHERE (HethongTK.SoHieu LIKE '3331%') AND (TK.SoHieu LIKE '{2}%' OR TK.SoHieu LIKE '111%') AND {3}", WThang("ThangCT", tdau, 0), ChungTu2TKNC(0), pSHPT, WThang("ThangCT", 0, tcuoi))
        kn = ConvertToDblSafe(GetSelectValue(sql, lk))
        ExecSQLNonQuery(String.Format("UPDATE VAT SET KyNay = {0},LuyKe = {1} WHERE MaSo = '43'", CStr(kn), CStr(lk)))
        lk2 -= lk
        sql = String.Format("SELECT SUM(CASE WHEN ({0}) THEN SoPS ELSE 0 END) AS F1,SUM(SoPS) AS F2 FROM ({1}) LEFT JOIN ({2}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT WHERE MienTru.MaCT=null AND (HethongTK.SoHieu LIKE '33311%') AND (TK.SoHieu LIKE '11%') AND {3}", WThang("ThangCT", tdau, 0), ChungTu2TKNC(0), Mientru, WThang("ThangCT", 0, tcuoi))
        kn = ConvertToDblSafe(GetSelectValue(sql, lk))
        ExecSQLNonQuery(String.Format("UPDATE VAT SET KyNay = {0},LuyKe = {1} WHERE MaSo = '45'", CStr(kn), CStr(lk)))
        lk2 -= kn
        If lk2 >= 0 Then
            ExecSQLNonQuery(String.Format("UPDATE VAT SET KyNay = {0},LuyKe = {0} WHERE MaSo = '46'", CStr(lk2)))
        Else
            ExecSQLNonQuery(String.Format("UPDATE VAT SET KyNay = {0},LuyKe = {0} WHERE MaSo = '17'", CStr(-lk2)))
        End If
        sql = String.Format("SELECT VAT.MaSo, (VAT.DienGiai{0}) AS FirstOfDienGiai, (VAT.TongHop) AS FirstOfTongHop, Sum(VAT.KyNay) AS SumOfKyNay, Sum(VAT.LuyKe) AS SumOfLuyKe FROM VAT GROUP BY VAT.MaSo, VAT.DienGiai{0}, VAT.TongHop", (IIf(pNN > 0, "", String.Empty)))
        QVAT = (sql)
        TK = Nothing

        rptFrom.InitForm("VAT.RPT", QVAT, "QVAT")
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub QTDauVao(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim v As Double
        rptFrom.InitForm("QTV.RPT", "SELECT * FROM License", "License")

        rptFrom.SetFormulas("Diachi", String.Format("'{0}'", frmMain._LbCty_2.Text))
        rptFrom.SetFormulas("MSThue", String.Format("'{0}'", frmMain._LbCty_8.Text))

        Dim d As Double = ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=-1 AND TyLe=3 AND KCT=0 AND {1}", ChungTu2TKHD(0), WThang("ThangCT", tdau, tcuoi)), v))
        rptFrom.SetFormulas("D3", d)
        rptFrom.SetFormulas("V3", v)
        d = ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=-1 AND TyLe=5 AND KCT=0 AND {1}", ChungTu2TKHD(0), WThang("ThangCT", tdau, tcuoi)), v))
        rptFrom.SetFormulas("D5", d)
        rptFrom.SetFormulas("V5", v)
        d = ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=-1 AND TyLe=10 AND KCT=0 AND {1}", ChungTu2TKHD(0), WThang("ThangCT", tdau, tcuoi)), v))
        rptFrom.SetFormulas("D10", d)
        rptFrom.SetFormulas("V10", v)
        d = ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(ThanhTien) AS F1,SUM(SoPS) AS F2 FROM {0} WHERE HoaDon.Loai=-1 AND TyLe=2 AND KCT=0 AND {1}", ChungTu2TKHD(0), WThang("ThangCT", tdau, tcuoi)), v))
        rptFrom.SetFormulas("D2", d)
        rptFrom.SetFormulas("V2", v)
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub QTDauRa()
        Dim tien, Thue As Double
        rptFrom.InitForm("QTVR.RPT", "SELECT * FROM License", "License")

        SetRptInfo()
        rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))
        rptFrom.SetFormulas("MSThue", String.Format("'{0}'", frmMain._LbCty_8.Text))

        For i As Integer = 1 To 12
            '***** Đầu ra*****
            tien = ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(ThanhTien) AS F1 FROM {0} WHERE SoPS=0 AND ThangCT={1} AND HoaDon.Loai=1 AND KCT=1", ChungTu2TKHD(1), ConvertToStrSafe(i))))
            tien += ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(ThanhTien) AS F1,SUM(CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END) AS F2 FROM {1} WHERE SoPS=0 AND ThangCT={2} AND HoaDon.Loai=1 AND TyLe=0 AND KCT=0", GTGTPN_ID, ChungTu2TKHD(1), ConvertToStrSafe(i))))
            rptFrom.SetFormulas("ra0" + CStr(i), tien)
            tien = ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(ThanhTien) AS F1,SUM(CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END) AS F2 FROM {1} WHERE ThangCT={2} AND HoaDon.Loai=1 AND TyLe=5 AND KCT=0", GTGTPN_ID, ChungTu2TKHD(1), ConvertToStrSafe(i)), Thue))
            rptFrom.SetFormulas("ra5" + CStr(i), tien)
            rptFrom.SetFormulas("rathue5" + CStr(i), Thue)
            tien = ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(ThanhTien) AS F1,SUM(CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END) AS F2 FROM {1} WHERE ThangCT={2} AND HoaDon.Loai=1 AND TyLe=10 AND KCT=0", GTGTPN_ID, ChungTu2TKHD(1), ConvertToStrSafe(i)), Thue))
            rptFrom.SetFormulas("ra10" + CStr(i), tien)
            rptFrom.SetFormulas("rathue10" + CStr(i), Thue)
            '***** Đầu vào*****
            tien = ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(ThanhTien) AS F1 FROM {0} WHERE SoPS=0 AND ThangCT={1} AND HoaDon.Loai=-1 AND KCT=1", ChungTu2TKHD(-1), ConvertToStrSafe(i))))
            tien += ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(ThanhTien) AS F1,SUM(CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END) AS F2 FROM {1} WHERE SoPS=0 AND ThangCT={2} AND HoaDon.Loai=-1 AND TyLe=0 AND KCT=0", GTGTPN_ID, ChungTu2TKHD(-1), ConvertToStrSafe(i))))
            rptFrom.SetFormulas("vao0" + CStr(i), tien)
            tien = ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(ThanhTien) AS F1,SUM(CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END) AS F2 FROM {1} WHERE ThangCT={2} AND HoaDon.Loai=-1 AND TyLe=5 AND KCT=0", GTGTPN_ID, ChungTu2TKHD(-1), ConvertToStrSafe(i)), Thue))
            rptFrom.SetFormulas("vao5" + CStr(i), tien)
            rptFrom.SetFormulas("vaothue5" + CStr(i), Math.Abs(Thue))
            tien = ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(ThanhTien) AS F1,SUM(CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END) AS F2 FROM {1} WHERE ThangCT={2} AND HoaDon.Loai=-1 AND TyLe=10 AND KCT=0", GTGTPN_ID, ChungTu2TKHD(-1), ConvertToStrSafe(i)), Thue))
            rptFrom.SetFormulas("vao10" + CStr(i), tien)
            rptFrom.SetFormulas("vaothue10" + CStr(i), Math.Abs(Thue))
        Next
        rptFrom.SetFormulas("thang", pThangDauKy)
        rptFrom.SetFormulas("ThangCuoi", IIf(pThangDauKy = 1, 12, pThangDauKy - 1))
        rptFrom.SetFormulas("thangdauky", pThangDauKy)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GTGTCT()
        Dim kq As Double
        rptFrom.InitForm("THUE2.RPT", "SELECT * FROM License", "License")

        For i As Integer = 1 To 12
            rptFrom.SetFormulas("R" & CStr(i), SoPSTK("3331", i, i, 1))
            kq = SoPSTK(pVATV, i, i, -1)
            rptFrom.SetFormulas("V" & CStr(i), kq)
            rptFrom.SetFormulas("K" & CStr(i), kq - PSDu("6", pVATV, i, i))
            rptFrom.SetFormulas("H" & CStr(i), PSDu("11", String.Format("{0}112", pVATV), i, i) + PSDu("11", String.Format("{0}212", pVATV), i, i))
            rptFrom.SetFormulas("N" & CStr(i), PSDu("33311", "11", i, i))
        Next
        rptFrom.SetFormulas("thang", pThangDauKy)
        rptFrom.SetFormulas("ThangCuoi", IIf(pThangDauKy = 1, 12, pThangDauKy - 1))
        rptFrom.SetFormulas("thangdauky", pThangDauKy)
        rptFrom.SetFormulas("SoDN", SoDuTKSH("3331", 0) - SoDuTKSH(pVATV, 0))
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
                sql = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE HoaDon.Loai=-1 AND {1} AND RIGHT(HethongTK.SoHieu,{2}) = '{3}'", ChungTu2TKHD(-1), WThang("ThangCT", tdau, tdau), ConvertToStrSafe(shct.Length), shct)
            Else
                sql = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE HoaDon.Loai=-1 AND {1}", ChungTu2TKHD(0), WThang("ThangCT", tdau, tdau))
            End If
            duno += ConvertToDblSafe(GetSelectValue(sql))
            ' Kiem tra dau ra co bi am thi bo sung
            If shct.Length > 0 Then
                sql = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE HoaDon.Loai=1 AND {1} AND RIGHT(HethongTK.SoHieu,{2}) = '{3}'", ChungTu2TKHD(1), WThang("ThangCT", tdau, tdau), ConvertToStrSafe(shct.Length), shct)
            Else
                sql = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE HoaDon.Loai=1 AND {1}", ChungTu2TKHD(0), WThang("ThangCT", tdau, tdau))
            End If
            X = ConvertToDblSafe(GetSelectValue(sql))
            If X < 0 Then duno += Math.Abs(X)
            sql = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE (HethongTK.SoHieu LIKE '142%' OR HethongTK.SoHieu LIKE '242%' OR HethongTK.SoHieu LIKE '6%') AND (TK.SoHieu LIKE '{1}%') AND RIGHT(TK.SoHieu,{2})='{3}' AND {4}", ChungTu2TKNC(0), pVATV, ConvertToStrSafe(shct.Length), shct, WThang("ThangCT", tdau, tdau))
            duno = ConvertToDblSafe(duno - ConvertToDblSafe(GetSelectValue(sql)))
            sql = String.Format("SELECT SUM(CASE WHEN (TK_ID={0}) THEN SoPS ELSE -SoPS END) AS F1 FROM {1} WHERE HoaDon.Loai=1 AND {2} AND KCT=0 AND RIGHT(HethongTK.SoHieu,{3}) = '{4}'", GTGTPN_ID, ChungTu2TKHD(1), WThang("ThangCT", tdau, tdau), ConvertToStrSafe(shct.Length), shct)
            duno = ConvertToDblSafe(duno - ConvertToDblSafe(GetSelectValue(sql)))
            sql = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE (TK.SoHieu LIKE '{1}112%' OR TK.SoHieu LIKE '{1}212%') AND RIGHT(TK.SoHieu,{2})='{3}' AND {4} AND (HethongTK.SoHieu LIKE '336%' OR HethongTK.SoHieu LIKE '11%' OR HethongTK.SoHieu LIKE '138%')", ChungTu2TKNC(0), pVATV, ConvertToStrSafe(shct.Length), shct, WThang("ThangCT", tdau, tdau))
            duno = ConvertToDblSafe(duno - ConvertToDblSafe(GetSelectValue(sql)))
        End If
        If duno < 0 Then duno = 0
        Return duno
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="dk"></param>
    ''' <param name="hoanlai"></param>
    ''' <param name="lkhl"></param>
    ''' <param name="dahoanlai"></param>
    ''' <param name="lkdhl"></param>
    ''' <remarks></remarks>
    Private Sub VATHoanLai(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef dk As Double, ByRef hoanlai As Double, ByRef lkhl As Double, ByRef dahoanlai As Double, ByRef lkdhl As Double)
        Dim taikhoan As New ClsTaikhoan
        Dim psn, dkc, dkn, dknt, psc As Double
        Dim shtkhl1 As String = Interaction.GetSetting(IniPath, "VAT", "TK_HOANLAI", String.Format("{0}112", pVATV))
        Dim shtkhl2 As String = Interaction.GetSetting(IniPath, "VAT", "TK_HOANLAI", String.Format("{0}212", pVATV))
        taikhoan.InitTaikhoanSohieu(shtkhl1)
        taikhoan.SoDuTK(ThangTruoc(tdau), dkn, dkc, dknt)
        dk = dkn - dkc
        taikhoan.SoPhatSinh(tdau, tcuoi, psn, psc)
        hoanlai = psn
        dahoanlai = psc
        taikhoan.SoPhatSinh(pThangDauKy, tcuoi, psn, psc)
        lkhl = psn
        lkdhl = psc
        taikhoan.InitTaikhoanSohieu(shtkhl2)
        taikhoan.SoDuTK(ThangTruoc(tdau), dkn, dkc, dknt)
        dk = dk + dkn - dkc
        taikhoan.SoPhatSinh(tdau, tcuoi, psn, psc)
        hoanlai += psn
        dahoanlai += psc
        taikhoan.SoPhatSinh(pThangDauKy, tcuoi, psn, psc)
        lkhl += psn
        lkdhl += psc
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="dk"></param>
    ''' <param name="GIAM"></param>
    ''' <param name="lkg"></param>
    ''' <param name="dagiam"></param>
    ''' <param name="lkdg"></param>
    ''' <remarks></remarks>
    Private Sub VATMienGiam(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef dk As Double, ByRef GIAM As Double, ByRef lkg As Double, ByRef dagiam As Double, ByRef lkdg As Double)
        Dim taikhoan As New ClsTaikhoan
        Dim dkc, dkn, dknt As Double
        Dim shtkmg1 As String = Interaction.GetSetting(IniPath, "VAT", "TK_DAURA", "333111")
        Dim shtkmg2 As String = Interaction.GetSetting(IniPath, "VAT", "TK_NK", "333121")
        Dim shtkdg1 As String = Interaction.GetSetting(IniPath, "VAT", "TK_GIAM", "333112")
        Dim shtkdg2 As String = Interaction.GetSetting(IniPath, "VAT", "TK_NKGIAM", "333122")
        Dim shtktntc As String = Interaction.GetSetting(IniPath, "VAT", "TK_TNTC", "721")
        taikhoan.InitTaikhoanSohieu(shtkdg1)
        taikhoan.SoDuTK(ThangTruoc(tdau), dkn, dkc, dknt)
        dk = dkc - dkn
        taikhoan.InitTaikhoanSohieu(shtkdg2)
        taikhoan.SoDuTK(ThangTruoc(tdau), dkn, dkc, dknt)
        dk = dk + dkc - dkn
        Dim sql As String = String.Format("SELECT DISTINCT Sum(CASE WHEN ({0}) THEN ChungTu.SoPS ELSE 0 END ) As F1, Sum(ChungTu.SoPS) As F2 FROM HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo WHERE ((HethongTK.SoHieu LIKE '{1}%' AND HethongTK_1.SoHieu LIKE '{2}%') Or (HethongTK.SoHieu LIKE '{3}%' AND HethongTK_1.SoHieu LIKE '{4}%')) And {5}", WThang("ThangCT", tdau, 0), shtkmg1, shtkdg1, shtkmg2, shtkdg2, WThang("ThangCT", 0, tcuoi))
        GIAM = ConvertToDblSafe(GetSelectValue(sql, lkg))
        sql = String.Format("SELECT DISTINCT Sum(CASE WHEN ({0}) THEN ChungTu.SoPS ELSE 0 END ) As F1, Sum(ChungTu.SoPS) AS F2 FROM HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo WHERE ((HethongTK.SoHieu LIKE '{1}%' OR HethongTK.SoHieu LIKE '{2}%') AND (HethongTK_1.SoHieu LIKE '{3}%')) And {4}", WThang("ThangCT", tdau, 0), shtkdg1, shtkdg2, shtktntc, WThang("ThangCT", 0, tcuoi))
        dagiam = ConvertToDblSafe(GetSelectValue(sql, lkdg))
    End Sub
    ''' <summary>
    ''' Thu nhập cá nhân 5A
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CopyData5A()
        Dim curSheet As Excel.Worksheet
        Select Case Information.Err().Number
            Case Is < 0
                Conversion.ErrorToString(5)
            Case 1
                Exit Sub
        End Select
        Dim RowIdx As Integer = 5
        Recycle(String.Format("{0}\TEMP\Bang_Ke_05AK.xls", pCurDir))
        With Excel_Global.ActiveWorkbook
            curSheet = Excel_Global.Worksheets(1)
            RowIdx = PrintSQL("SELECT T.ten, T.mst, T.cmnd, T.ttn, T.pt, T.st, T.tt, T.bh, T.giam, T.n FROM (" & Mientru & ") AS T order by T.ten", curSheet, RowIdx, 2)
            curSheet.SaveAs(String.Format("{0}\TEMP\Bang_Ke_05AK.xls", pCurDir))
            CloseBook(String.Format("{0}\TEMP\Bang_Ke_05AK.xls", pCurDir))
        End With
    End Sub
    ''' <summary>
    ''' Thu nhập cá nhân 5B
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CopyData5B()
        Dim curSheet As Excel.Worksheet
        Select Case Information.Err().Number
            Case Is < 0
                Conversion.ErrorToString(5)
            Case 1
                Exit Sub
        End Select
        Dim RowIdx As Integer = 3
        Recycle(String.Format("{0}\TEMP\Bang_Ke_05BK.xls", pCurDir))
        With Excel_Global.ActiveWorkbook
            curSheet = Excel_Global.Worksheets(1)

            RowIdx = PrintSQL("SELECT T.ten, T.mst, T.cmnd, T.ttn, T.giam, T.n FROM (" & Mientru & ") AS T order by T.ten", curSheet, RowIdx, 2)
            curSheet.SaveAs(pCurDir & "\TEMP\Bang_Ke_05BK.xls")
            CloseBook(pCurDir & "\TEMP\Bang_Ke_05BK.xls")
        End With
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
        CloseBook(String.Format("{0}\temp\QTTNDN.xls", pCurDir))
        On Error GoTo KetThuc
        xlapp = New Excel.Application()
        On Error GoTo Loimofile
        xlapp.Workbooks.Open(String.Format("{0}\temp\QTTNDN.XLS", pCurDir))
        GoTo Tieptuc
Loimofile:
        File.Copy(String.Format("{0}\REPORTS\QTTNDN.XLS", pCurDir), String.Format("{0}\TEMP\QTTNDN.XLS", pCurDir))
        xlapp.Workbooks.Open(String.Format("{0}\TEMP\QTTNDN.XLS", pCurDir))
Tieptuc:
        On Error GoTo 0
        Dim kt As DialogResult
        Dim TenSheet As String = String.Empty
        kt = MessageBox.Show(String.Format("Bảng cân đối năm trước chọn.. Yes{0}Bảng cân đối năm nay chọn.. No", Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
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
            MessageBox.Show(String.Format("Không có sheet ten '{0}' !{1}Vui lòng kiểm tra lại file Excel !", TenSheet, Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GoTo KetThuc
        End If
        SoDuTKCN2(ThangTruoc(tdau))
        SoDuTKCN2(tcuoi)
        For i = CThangDB2(tdau) To CThangDB2(tcuoi)
            If sqln.Length Then
                sqln.Append(String.Format(" + HethongTk.No_{0}", i))
            Else
                sqln.Append(String.Format("HethongTk.No_{0}", i))
            End If
            If sqlc.Length Then
                sqlc.Append(String.Format(" + HethongTk.Co_{0}", i))
            Else
                sqlc.Append(String.Format("HethongTk.Co_{0}", i))
            End If
        Next
        For i = 1 To CThangDB2(tcuoi)
            If sqlnx.Length Then
                sqlnx.Append(String.Format(" + HethongTk.No_{0}", i))
            Else
                sqlnx.Append(String.Format("HethongTk.No_{0}", i))
            End If
            If sqlcx.Length Then
                sqlcx.Append(String.Format(" + HethongTk.Co_{0}", i))
            Else
                sqlcx.Append(String.Format("HethongTk.Co_{0}", i))
            End If
        Next
        st = ConvertToStrSafe(CThangDB2(tcuoi))
        QCdt = String.Format("SELECT DISTINCT HeThongTK.SoHieu, HeThongTK.Cap, HeThongTK.Ten{0}, HeThongTK.Kieu, HeThongTK.Loai, HeThongTK.DuNo_{1} As DkNo, HeThongTK.DuCo_{2} As DkCo, {3} As PsNo, {4} As PsCo, KC_N, KC_C, {5} As CkNo, {6} As CkCo FROM HeThongTK WHERE ((HeThongTK.MaTC = 0 Or HethongTK.MaTC = HethongTK.MaSo) OR (TK_ID3 % 10 >= 1)) And (HeThongTK.Loai > 0)  AND Cap<={7}{8} order by hethongtk.loai,hethongtk.sohieu", (IIf(pNN > 0, "E", String.Empty)), CThangDB2(ThangTruoc(tdau)), ConvertToStrSafe(CThangDB2(ThangTruoc(tdau))), sqln, sqlc, (IIf(saukc, "HeThongTK.DuNo_" & st, "HethongTk.DuNo")), (IIf(saukc, "HeThongTK.DuCo_" & st, "HethongTk.DuCo")), ConvertToStrSafe(cap), (IIf(ct = 0, " AND (DuNo_" & st & "<>0 OR DuCo_" & st & "<>0 OR (" & sqln.ToString() & ")<>0 OR (" & sqlc.ToString() & ")<>0)", String.Empty)))
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rs = ExecSQLReturnDT(QCdt)
        i = 1
        GauGe.Maximum = rs.Rows.Count
        HienThongBao(String.Format("Xuất Excel cân đối số phát sinh '{0}' ...", TenSheet), 1)
        For Each rsItem As DataRow In rs.Rows
            For j As Integer = 2 To 9
                xlsheet.Cells(i, j) = ""
                If rs.Rows.Count > 0 Then
                    Select Case j
                        Case 2
                            If ConvertToDblSafe(rsItem("cap")) > 0 Then xlsheet.Cells(i, j) = Space(ConvertToDblSafe(rsItem("cap"))) + ConvertToStrSafe(rsItem("SoHieu"))
                        Case 3
                            If ConvertToDblSafe(rsItem("cap")) > 0 Then
                                xlsheet.Cells(i, j) = Space(ConvertToDblSafe(rsItem("cap"))) + ConvertToStrSafe(rsItem("ten" + IIf(pNN > 0, "E", String.Empty)))
                            End If
                        Case 4
                            If Strings.Left(ConvertToStrSafe(rsItem("SoHieu")), 3) = "131" Or Strings.Left(ConvertToStrSafe(rsItem("SoHieu")), 3) = "331" Or Strings.Left(ConvertToStrSafe(rsItem("SoHieu")), 3) = "138" Or Strings.Left(ConvertToStrSafe(rsItem("SoHieu")), 3) = "338" Then
                                xlsheet.Cells(i, j) = ConvertToDblSafe(rsItem("dkno"))
                            Else
                                If ConvertToDblSafe(rsItem("cap")) > 0 And ConvertToDblSafe(rsItem("dkno")) > ConvertToDblSafe(rsItem("dkco")) Then xlsheet.Cells(i, j) = ConvertToStrSafe(ConvertToDblSafe(rsItem("dkno")) - ConvertToDblSafe(rsItem("dkco")))
                            End If
                        Case 5
                            If Strings.Left(ConvertToStrSafe(rsItem("SoHieu")), 3) = "131" Or Strings.Left(ConvertToStrSafe(rsItem("SoHieu")), 3) = "331" Or Strings.Left(ConvertToStrSafe(rsItem("SoHieu")), 3) = "138" Or Strings.Left(ConvertToStrSafe(rsItem("SoHieu")), 3) = "338" Then
                                xlsheet.Cells(i, j) = ConvertToDblSafe(rsItem("dkco"))
                            Else
                                If ConvertToDblSafe(rsItem("cap")) > 0 And ConvertToDblSafe(rsItem("dkco")) > ConvertToDblSafe(rsItem("dkno")) Then xlsheet.Cells(i, j) = ConvertToStrSafe(ConvertToDblSafe(rsItem("dkco")) - ConvertToDblSafe(rsItem("dkno")))
                            End If
                        Case 6
                            If ConvertToDblSafe(rsItem("cap")) > 0 Then xlsheet.Cells(i, j) = ConvertToDblSafe(rsItem("psno"))
                        Case 7
                            If ConvertToDblSafe(rsItem("cap")) > 0 Then xlsheet.Cells(i, j) = ConvertToDblSafe(rsItem("psco"))
                        Case 8
                            If ConvertToStrSafe(rsItem("SoHieu")) = "131" Or ConvertToStrSafe(rsItem("SoHieu")) = "331" Or ConvertToStrSafe(rsItem("SoHieu")) = "138" Or ConvertToStrSafe(rsItem("SoHieu")) = "338" Then
                                xlsheet.Cells(i, j) = ConvertToDblSafe(rsItem("ckno"))
                            Else
                                If ConvertToDblSafe(rsItem("cap")) > 0 And ConvertToDblSafe(rsItem("ckno")) > ConvertToDblSafe(rsItem("ckco")) Then xlsheet.Cells(i, j) = ConvertToStrSafe(ConvertToDblSafe(rsItem("ckno")) - ConvertToDblSafe(rsItem("ckco")))
                            End If
                        Case 9
                            If ConvertToStrSafe(rsItem("SoHieu")) = "131" Or ConvertToStrSafe(rsItem("SoHieu")) = "331" Or ConvertToStrSafe(rsItem("SoHieu")) = "138" Or ConvertToStrSafe(rsItem("SoHieu")) = "338" Then
                                xlsheet.Cells(i, j) = ConvertToDblSafe(rsItem("ckco"))
                            Else
                                If ConvertToDblSafe(rsItem("cap")) > 0 And ConvertToDblSafe(rsItem("ckco")) > ConvertToDblSafe(rsItem("ckno")) Then xlsheet.Cells(i, j) = ConvertToStrSafe(ConvertToDblSafe(rsItem("ckco")) - ConvertToDblSafe(rsItem("ckno")))
                            End If
                    End Select
                End If
            Next
            i += 1
            GauGe.Value = i - 1
        Next
        While ConvertToStrSafe(xlsheet.Cells(i, 2)._Default) <> "" Or ConvertToStrSafe(xlsheet.Cells(i + 1, 2)._Default) <> "" Or ConvertToStrSafe(xlsheet.Cells(i + 2, 2)._Default) <> "" Or ConvertToStrSafe(xlsheet.Cells(i + 3, 2)._Default) <> "" Or ConvertToStrSafe(xlsheet.Cells(i + 4, 2)._Default) <> ""
            For j As Integer = 2 To 9
                xlsheet.Cells(i, j) = ""
            Next
            i += 1
        End While

        rs = Nothing
        Dim xlsheet1 As New Excel.Worksheet
        Dim cuoikytruoc, daukynay As Double
        'Tìm tên sheet cần so sánh đầu kỳ năm nay và cuối kỳ năm trước
        If TenSheet = "namnay" Then
            daukynay = ConvertToDblSafe(xlsheet.Cells(1, 4).Value2 - xlsheet.Cells(1, 5).Value2)
            TenSheet = "namtruoc"
        Else
            cuoikytruoc = ConvertToDblSafe(xlsheet.Cells(1, 8).Value2 - xlsheet.Cells(1, 9).Value2)
            TenSheet = "namnay"
        End If
        If daukynay <> 0 Or cuoikytruoc <> 0 Then
            co = False
            For i = 1 To xlapp.Worksheets.Count
                If xlapp.Worksheets(i).Name.ToUpper() = TenSheet.ToUpper() Then
                    co = True : Exit For
                End If
            Next
            If co Then
                xlsheet1 = xlapp.Worksheets(i)
            Else
                MessageBox.Show(String.Format("Không có sheet ten '{0}' !{1}Vui lòng kiểm tra lại file Excel !", _
                                        TenSheet, _
                                        Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            If daukynay <> 0 Then
                cuoikytruoc = xlsheet1.Cells(1, 8).value - xlsheet1.Cells(1, 9).value
            Else
                daukynay = xlsheet1.Cells(1, 4).value - xlsheet1.Cells(1, 5).value
            End If
            If daukynay <> 0 And cuoikytruoc <> 0 And daukynay <> cuoikytruoc Then
                If MessageBox.Show(Ngonngu("Số đầu kỳ năm nay của tài khoản 111 khác cuối kỳ năm trước? ", "This year's beginning balance of the account '111' not like last year ago"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    HienThongBao(String.Format("Xóa cân đối số phát sinh '{0}' ...", TenSheet), 1)
                    xlsheet1.Range("1:1", "300:1").EntireRow.Clear()
                End If
            End If
        End If
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        xlapp.Workbooks.Open(String.Format("{0}\temp\QTTNDN.XLS", pCurDir))
        xlsheet = xlapp.Worksheets(1)
        GauGe.Value = 0
        On Error GoTo 0
        xlsheet.Cells(5, 1) = String.Format("[1]kỳ tính Thuế : {0}", ThoiGianTheoThang(tdau, tcuoi))
        xlsheet.Cells(7, 1) = String.Format("[2]Mã số thuế : {0}", frmMain._LbCty_8.Text)
        xlsheet.Cells(8, 1) = String.Format("[3] Tên cơ sở kinh doanh: {0}", pTenCty)
        xlsheet.Cells(9, 1) = String.Format("[4] Địa chỉ: trụ sở: {0}", frmMain._LbCty_2.Text)
        xlsheet.Cells(10, 1) = String.Format("[5] Quận, huyện: {0}                 {1}{2}", frmMain._LbCty_10.Text, ("Tỉnh, thành phố: "), frmMain._LbCty_11.Text)
        xlsheet.Cells(11, 1) = String.Format("[7] Điện thoại:   {0}                 Fax: {1}                 Email: {2}", _
                                   frmMain._LbCty_3.Text, _
                                   frmMain._LbCty_4.Text, _
                                   frmMain._LbCty_9.Text)
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
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <remarks></remarks>
    Private Sub InTHDoanhThuVAT(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date)
        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        Mientru = (String.Format("SELECT MaCT,KCT,TyLe FROM ChungTu INNER JOIN HoaDon ON ChungTu.MaSo=HoaDon.MaSo WHERE HoaDon.Loai=1 AND MaLoai=8 AND {0}", wsql))
        QChitiet = (String.Format("SELECT DISTINCT Vattu.SoHieu,TenVattu, DonVi,SUM(CASE WHEN (TyLe=0 AND KCT=1) THEN SoPS ELSE 0 END ) AS DKT, SUM(CASE WHEN (TyLe=0 AND KCT=0) THEN SoPS ELSE 0 END ) AS D0, SUM(CASE WHEN (TyLe=5) THEN SoPS ELSE 0 END) AS D5, SUM(CASE WHEN (TyLe=10) THEN SoPS ELSE 0 END) AS D10, SUM(CASE WHEN(TyLe=5) THEN TyLe*SoPS/100 ELSE 0 END) AS T5, SUM(CASE WHEN (TyLe=10) THEN TyLe*SoPS/100 ELSE 0 END) AS T10 FROM ((ChungTu LEFT JOIN Vattu ON ChungTu.MaVattu = Vattu.MaSo) INNER JOIN ({0}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT) INNER JOIN HethongTK ON ChungTu.MaTKCo=HethongTK.MaSo WHERE TK_ID={1} OR HethongTK.Loai=7 GROUP BY Vattu.SoHieu,TenVattu,DonVi", Mientru, TKDT_ID))
        rptFrom.InitForm("THDT4.RPT", QChitiet, "QChitiet")

        rptFrom.SetFormulas("ThoiGian", Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi, nn)))))
        RptSetDate(ncuoi)
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
        Dim wsql As String, sql As String
        wsql = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        ExecSQLNonQuery("DELETE  FROM BaoCaoCP")
        sql = String.Format("INSERT INTO BaoCaoCP (MaSo,SoHieu,MaCha) SELECT ChungTu.MaSo,ChungTu.MaSo,MaCT FROM {0} WHERE (TK_ID={1}) AND {2}{3}{4} GROUP BY ChungTu.MaSo, MaCT", _
                            ChungTu2TKNC(1), _
                            ConvertToStrSafe(TKDT_ID), _
                            wsql, _
                            IIf(mkho > 0, String.Format(" AND MaKho={0}", mkho), String.Empty), _
                            IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty))
        ExecSQLNonQuery(sql)
        ExecSQLNonQuery("UPDATE BaoCaoCP set BC_ID=(select max(makh) from ChungTu where BaoCaoCP.MaCha=ChungTu.MaCT and MaKH>0)")
        sql = String.Format("UPDATE BaoCaoCP set bc_id= (select max(makhachhang) from {0} where BaoCaoCP.MaCha=ChungTu.MaCT) Where BC_ID=0 or BC_ID is null", ChungTu2TKHD(0))
        ExecSQLNonQuery(sql)
        sql = String.Format("SELECT DISTINCT Sum(ChungTu.SoPS) AS Tien, Sum(ChungTu.SoPS2Co) AS Luong, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, (KhachHang.SoHieu) AS SHKH,(KhachHang.Ten) AS Ten, (PhanLoaiVattu.PLCha) AS PLCha3, (PhanLoaiVattu.SoHieu) AS SHPL3, (PhanLoaiVattu.TenPhanLoai) AS TenPL3 FROM ((ChungTu LEFT JOIN (PhanLoaiVattu RIGHT JOIN Vattu ON PhanLoaiVattu.MaSo = Vattu.MaPhanLoai) ON ChungTu.MaVattu = Vattu.MaSo) INNER JOIN BaoCaoCP ON ChungTu.MaSo=BaoCaoCP.MaSo) LEFT JOIN KhachHang ON BaoCaoCP.BC_ID=KhachHang.MaSo WHERE (1=1) {0}{1}{2} GROUP BY {3}Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi,KhachHang.SoHieu,KhachHang.Ten,PhanLoaiVattu.PLCha,PhanLoaiVattu.SoHieu,PhanLoaiVattu.TenPhanLoai", (IIf(mnv > 0, "AND ChungTu.MaNV=" & mnv, String.Empty)), (IIf(MN > 0, "AND ChungTu.MaNguon=" & MN, String.Empty)), (IIf(shkh.Length > 0, "AND KhachHang.SoHieu='" & shkh & "'", String.Empty)), (IIf(loai <> 0, "KhachHang.SoHieu,KhachHang.Ten,", String.Empty)))
        QChitiet = sql
        sql = String.Format("SELECT QChitiet.*,PhanLoaiVattu.SoHieu AS SHPL2,TenPhanLoai AS TenPL2,PhanLoaiVattu.PLCha AS PLCha2 FROM ({0}) AS QChitiet LEFT JOIN PhanLoaiVattu ON QChitiet.PLCha3=PhanLoaiVattu.MaSo", QChitiet)
        QDuPhong = sql
        sql = String.Format("SELECT QDuPhong.*,PhanLoaiVattu.SoHieu AS SHPL1,TenPhanLoai AS TenPL1 FROM ({0}) As QDuPhong LEFT JOIN PhanLoaiVattu ON QDuPhong.PLCha2=PhanLoaiVattu.MaSo ORDER BY QDuPhong.Sohieu", QDuPhong)
        QLuyKe = sql

        If loai = 0 Then
            rptFrom.InitForm("THDT1.RPT", QLuyKe, "QLuyKe")
        Else
            If shkh.Length > 0 Then
                QLuyKe = (String.Format("SELECT * FROM " & QLuyKe & " WHERE SHKH =N'{0}'", shkh))
            End If
            rptFrom.InitForm("THDT2.RPT", QLuyKe, "QLuyKe")
        End If

        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi, nn)))))

        If mkho > 0 Then rptFrom.SetFormulas("DG1", String.Format("'{0}'", tenkho(mkho)))
        If shkh.Length > 0 Then rptFrom.SetFormulas("DG2", String.Format("'{0}'", TenKH(shkh, 0)))
        If mnv > 0 Then rptFrom.SetFormulas("DG3", String.Format("'{0}'", TenNV("", mnv)))
        If MN > 0 Then rptFrom.SetFormulas("DG4", String.Format("'{0}'", TenNguon(MN)))
        If shtk.Length > 0 Then rptFrom.SetFormulas("DG3", String.Format("'TK: {0}'", shtk))
        RptSetDate(ncuoi)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub Baocao111(ByRef tcuoi As Integer)
        Dim duno, duco As Double
        Dim rs As DataTable
        Dim i, k As Integer
        Dim ncuoi As Date = NgayCuoiThang(pNamTC, tcuoi)
        Recycle(String.Format("{0}\TEMP\111.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\{1}REPORTS\111.XLS", pCurDir, Ngonngu("", "E")), String.Format("{0}\TEMP\111.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\TEMP\111.XLS", pCurDir))
        On Error GoTo 0
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(4, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        SoDuTK(ConvertToDblSafe(GetSelectValue("SELECT MaSo AS F1 FROM HethongTK WHERE Sohieu='1111'")), tcuoi, duno, duco)
        xlsheet.Cells(7, 4) = duno - duco
        xlsheet = xlapp.Worksheets(2)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(4, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        xlsheet.Cells(9, 7) = duno - duco
        rs = ExecSQLReturnDT(String.Format("SELECT MaSo, SoHieu, Ten" + Ngonngu("", "E") + ", GhiChu, DuNo_{0}-DuCo_{1} AS SoDu FROM HethongTK WHERE SoHieu LIKE '1121%' AND TKCon=0 AND Cap>2 ORDER BY SoHieu", CThangDB2(tcuoi), ConvertToStrSafe(CThangDB2(tcuoi))))
        For Each rsItem As DataRow In rs.Rows
            i += 1
            If i > 1 Then
                xlapp.Worksheets.Add(xlapp.Sheets(2 + i), , 1)
                xlsheet = xlapp.Worksheets(2 + i)
                xlsheet.Range("A1", "H20").PasteSpecial()
            Else
                xlsheet = xlapp.Worksheets(3)
            End If
            xlsheet.Cells(5, 3) = rsItem("ten" + Ngonngu("", "E"))
            xlsheet.Cells(6, 3) = rsItem("GhiChu")
            xlsheet.Cells(8, 5) = rsItem("sodu")
            xlsheet.Range("A1", "H20").Copy()
        Next
        k = 3 + i
        i = 0
        rs = ExecSQLReturnDT(String.Format("SELECT HethongTK.MaSo, SoHieu, Ten" + Ngonngu("", "E") + ", GhiChu, KyHieu, DuNo_{0}-DuCo_{1} AS SoDu,DuNT_{1} AS DuNT FROM HethongTK INNER JOIN NguyenTe ON HethongTK.MaNT=NguyenTe.MaSo  WHERE SoHieu LIKE '1122%' AND TKCon=0 AND Cap>2 ORDER BY SoHieu", _
                                 CThangDB2(tcuoi), _
                                 ConvertToStrSafe(CThangDB2(tcuoi))))
        For Each rsItem As DataRow In rs.Rows
            i += 1
            If i > 1 Then
                xlapp.Worksheets.Add(xlapp.Sheets(k - 1 + i), , 1)
                xlsheet = xlapp.Worksheets(k - 1 + i)
                xlsheet.Range("A1", "H23").PasteSpecial()
                xlsheet.Cells(4, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
            Else
                xlsheet = xlapp.Worksheets(k)
            End If
            xlsheet.Cells(6, 3) = rsItem("ten" + Ngonngu("", "E"))
            xlsheet.Cells(7, 3) = rsItem("GhiChu")
            xlsheet.Cells(12, 3) = rsItem("KyHieu")
            xlsheet.Cells(12, 7) = rsItem("sodu")
            xlsheet.Cells(12, 4) = rsItem("dunt")
            xlsheet.Range("A1", "H23").Copy()
        Next
        rs = Nothing
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\111.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub Baocao128(ByRef tcuoi As Integer)
        Dim ncuoi As Date = NgayCuoiThang(pNamTC, tcuoi)
        Recycle(String.Format("{0}\temp\128.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\{1}REPORTS\128.XLS", pCurDir, Ngonngu("", "E")), String.Format("{0}\TEMP\128.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\TEMP\128.XLS", pCurDir))
        On Error GoTo 0
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        SheetSoDu(xlsheet, "128", 1, tcuoi, 1, 2, 4, 7, 7, 7, ncuoi)
        xlsheet = xlapp.Worksheets(2)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        SheetSoDu(xlsheet, "129", 1, tcuoi, 1, 2, 3, 4, 7, 4, ncuoi)
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\128.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub Baocao131(ByRef tcuoi As Integer)
        Dim ncuoi As Date = NgayCuoiThang(pNamTC, tcuoi)
        Recycle(String.Format("{0}\TEMP\131.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\{1}REPORTS\131.XLS", pCurDir, Ngonngu("", "E")), pCurDir & "\TEMP\131.XLS")
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\TEMP\131.XLS", pCurDir))
        On Error GoTo 0
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        SheetSoDu(xlsheet, "1311", 3, tcuoi, 1, 2, 4, 0, 7, 8, ncuoi)
        xlsheet = xlapp.Worksheets(2)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        SheetSoDu(xlsheet, "1312", 3, tcuoi, 1, 2, 4, 0, 7, 5, ncuoi)
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\131.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub Baocao331(ByRef tcuoi As Integer)
        Dim ncuoi As Date = NgayCuoiThang(pNamTC, tcuoi)
        Recycle(String.Format("{0}\TEMP\331.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\{1}REPORTS\331.XLS", pCurDir, Ngonngu("", "E")), String.Format("{0}\TEMP\331.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\TEMP\331.XLS", pCurDir))
        On Error GoTo 0
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = Ngonngu("Đến ngày :", "To date:") & Format(ncuoi, Mask_D)
        SheetSoDu(xlsheet, "3311", 3, tcuoi, 1, 2, 4, 0, 7, 5, ncuoi)
        xlsheet = xlapp.Worksheets(2)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        SheetSoDu(xlsheet, "3312", 3, tcuoi, 1, 2, 4, 0, 7, 7, ncuoi)
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\331.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub Baocao138(ByRef tcuoi As Integer)
        Dim ncuoi As Date = NgayCuoiThang(pNamTC, tcuoi)
        Recycle(String.Format("{0}\TEMP\138.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\{1}REPORTS\138.XLS", pCurDir, Ngonngu("", "E")), String.Format("{0}\TEMP\138.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(pCurDir & "\TEMP\138.XLS")
        On Error GoTo 0
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        SheetSoDu(xlsheet, "1381", 3, tcuoi, 1, 2, 4, 3, 7, 5, ncuoi)
        xlsheet = xlapp.Worksheets(2)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        SheetSoDu(xlsheet, "1388", 3, tcuoi, 1, 2, 4, 5, 7, 8, ncuoi)
        xlsheet = xlapp.Worksheets(3)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        SheetSoDu(xlsheet, "139", 2, tcuoi, 1, 2, 3, 4, 7, 4, ncuoi)
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\138.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub Baocao141(ByRef tcuoi As Integer)
        Dim ncuoi As Date = NgayCuoiThang(pNamTC, tcuoi)
        Recycle(String.Format("{0}\TEMP\141.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\{1}REPORTS\141.XLS", pCurDir, Ngonngu("", "E")), String.Format("{0}\TEMP\141.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(pCurDir & "\TEMP\141.XLS")
        On Error GoTo 0
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_DB))
        SheetSoDu(xlsheet, "141", 2, tcuoi, 1, 2, 4, 3, 7, 8, ncuoi)
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\141.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub Baocao142(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim rs As DataTable
        Dim i As Integer
        Dim TK As New ClsTaikhoan
        Dim st As String = String.Empty
        Dim sqlcx As New StringBuilder
        Dim sqlnx As New StringBuilder
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        Dim duco, duno, dunt As Double
        Dim ncuoi As Date = NgayCuoiThang(pNamTC, tcuoi)
        Recycle(String.Format("{0}\TEMP\142.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\{1}REPORTS\142.XLS", pCurDir, Ngonngu("", "E")), String.Format("{0}\TEMP\142.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\TEMP\142.XLS", pCurDir))
        On Error GoTo 0
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(4, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        For i = CThangDB2(tdau) To CThangDB2(tcuoi)
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
        For i = 1 To tcuoi
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
        i = 0
        rs = ExecSQLReturnDT(String.Format("SELECT SoHieu, Cap, Ten" + Ngonngu("", "E") + ", GhiChu, Sum(DuNo_{0}-DuCo_{1}) AS DuDK, Sum({2}) AS PSN, Sum({3}) AS PSC, Sum({4}) AS PSNx, Sum({5}) AS PSCx, Sum(DuNo_{6}-DuCo_{6}) AS DuCK FROM HethongTK WHERE SoHieu LIKE '142%' AND Cap>1 GROUP BY SoHieu, Cap, Ten" + Ngonngu("", "E") + ", GhiChu ORDER BY SoHieu", _
                                 CThangDB2(ThangTruoc(tcuoi)), _
                                 ConvertToStrSafe(CThangDB2(ThangTruoc(tcuoi))), _
                                 sqln, _
                                 sqlc, _
                                 sqlnx, _
                                 sqlcx, _
                                 ConvertToStrSafe(CThangDB2(tcuoi))))
        For Each rsItem As DataRow In rs.Rows
            i += 1
            xlsheet.Cells(7 + i, 1) = ConvertToStrSafe(i)
            xlsheet.Cells(7 + i, 2) = String.Format("{0}{1}", Space(2 * (ConvertToDblSafe(rsItem("cap")) - 1)), ConvertToStrSafe(rsItem("ten" + Ngonngu("", "E"))))
            xlsheet.Cells(7 + i, 3) = ConvertToStrSafe(rsItem("DuDk"))
            xlsheet.Cells(7 + i, 4) = ConvertToStrSafe(rsItem("psn"))
            xlsheet.Cells(7 + i, 5) = ConvertToStrSafe(rsItem("psc"))
            xlsheet.Cells(7 + i, 6) = ConvertToStrSafe(rsItem("psnx"))
            xlsheet.Cells(7 + i, 7) = ConvertToStrSafe(rsItem("pscx"))
            xlsheet.Cells(7 + i, 8) = ConvertToStrSafe(rsItem("DuCK"))
        Next
        If i > 0 Then
            TK.InitTaikhoanSohieu(ConvertToStrSafe(142))
            TK.SoDuTK(ThangTruoc(tdau), duno, duco, dunt)
            xlsheet.Cells(8 + i, 2) = Ngonngu("Tổng cộng", "Total")
            xlsheet.Cells(8 + i, 3) = duno - duco
            TK.SoPhatSinh(tdau, tcuoi, duno, duco)
            xlsheet.Cells(8 + i, 4) = duno
            xlsheet.Cells(8 + i, 5) = duco
            TK.SoPhatSinh(pThangDauKy, tcuoi, duno, duco)
            xlsheet.Cells(8 + i, 6) = duno
            xlsheet.Cells(8 + i, 7) = duco
            TK.SoDuTK(tcuoi, duno, duco, dunt)
            xlsheet.Cells(8 + i, 8) = duno - duco
            xlsheet.Range(String.Format("A{0}", 8 + i), String.Format("H{0}", 8 + i)).Font.Bold = True
        End If
        rs = Nothing
        With xlsheet.Range("A6", String.Format("H{0}", 8 + i))
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders.Weight = Excel.XlBorderWeight.xlThin
            Dim tempRefParam As Object = .Borders.Color
            tempRefParam = Color.FromArgb(0, 0, 0)
            Dim tempRefParam2 As Object = .RowHeight
            tempRefParam2 = 18
            Dim tempRefParam3 As Object = .VerticalAlignment
            tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
        End With
        XLSFooter(xlsheet, 10 + i, 8, NgayCuoiThang(pNamTC, tcuoi))
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\142.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub Baocao144(ByRef tcuoi As Integer)
        Dim ncuoi As Date = NgayCuoiThang(pNamTC, tcuoi)
        Recycle(pCurDir & "\TEMP\144.XLS")
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\{1}REPORTS\144.XLS", pCurDir, Ngonngu("", "E")), String.Format("{0}\TEMP\144.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\TEMP\144.XLS", pCurDir))
        On Error GoTo 0
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        SheetSoDu(xlsheet, "144", 2, tcuoi, 1, 2, 3, 4, 8, 4, ncuoi)
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\144.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub Baocao152(ByRef tcuoi As Integer)
        Dim rs, rs2 As DataTable
        Dim j, i, k As Integer
        Dim shpl = String.Empty, shtk = String.Empty, kh As String = String.Empty
        Dim ncuoi As Date = NgayCuoiThang(pNamTC, tcuoi)
        Recycle(String.Format("{0}\temp\152.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\{1}REPORTS\152.XLS", pCurDir, Ngonngu("", "E")), String.Format("{0}\temp\152.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\152.XLS", pCurDir))
        On Error GoTo 0
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(3, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        rs = ExecSQLReturnDT(String.Format("SELECT DISTINCT HethongTK.SoHieu AS SHTK, PhanLoaiVattu.SoHieu AS SHPL, HethongTK.Ten" + Ngonngu("", "E") + ", PhanLoaiVattu.TenPhanLoai, KhoHang.TenKho, Sum(Tien_{0}) AS SoDu FROM (((TonKho INNER JOIN HethongTK ON TonKho.MaTaiKhoan=HethongTK.MaSo) INNER JOIN KhoHang ON TonKho.MaSoKho=KhoHang.MaSo) INNER JOIN Vattu ON TonKho.MaVattu=Vattu.MaSo) INNER JOIN PhanLoaiVattu ON Vattu.MaPhanLoai=PhanLoaiVattu.MaSo WHERE (HethongTK.SoHieu LIKE '152%' OR HethongTK.SoHieu LIKE '153%' OR HethongTK.SoHieu LIKE '155%' OR HethongTK.SoHieu LIKE '156%') GROUP BY HethongTK.SoHieu, PhanLoaiVattu.SoHieu, HethongTK.Ten" + Ngonngu("", "E") + ", PhanLoaiVattu.TenPhanLoai, KhoHang.TenKho HAVING Sum(Tien_{1})<>0", CThangDB2(tcuoi), ConvertToStrSafe(CThangDB2(tcuoi))))
        For Each rsItem As DataRow In rs.Rows
            i += 1
            If shtk <> ConvertToStrSafe(rsItem("shtk")) Then
                shtk = ConvertToStrSafe(rsItem("shtk"))
                xlsheet.Cells(7 + i, 2) = ConvertToStrSafe(rsItem("ten" + Ngonngu("", "E")))
                xlsheet.Range(String.Format("A{0}", 7 + i), String.Format("N{0}", 7 + i)).Font.Bold = True
                Continue For
            End If
            If shpl <> ConvertToStrSafe(rsItem("shpl")) Then
                shpl = ConvertToStrSafe(rsItem("shpl"))
                xlsheet.Cells(7 + i, 2) = ConvertToStrSafe(rsItem("TenPhanLoai"))
                xlsheet.Range(String.Format("A{0}", 7 + i), String.Format("N{0}", 7 + i)).Font.Bold = True
                xlsheet.Range(String.Format("A{0}", 7 + i), String.Format("N{0}", 7 + i)).Font.Italic = True
                Continue For
            End If
            xlsheet.Cells(7 + i, 1) = ConvertToStrSafe(i)
            xlsheet.Cells(7 + i, 2) = ConvertToStrSafe(rsItem("tenkho"))
            xlsheet.Cells(7 + i, 3) = ConvertToStrSafe(rsItem("sodu"))
        Next
        rs = Nothing
        With xlsheet.Range("A5", String.Format("N{0}", 7 + i))
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders.Weight = Excel.XlBorderWeight.xlThin
            Dim tempRefParam As Object = .Borders.Color
            tempRefParam = Color.FromArgb(0, 0, 0)
            Dim tempRefParam2 As Object = .RowHeight
            tempRefParam2 = 18
            Dim tempRefParam3 As Object = .VerticalAlignment
            tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
            .Font.Name = pFontName
        End With
        XLSFooter(xlsheet, 10 + i, 14, NgayCuoiThang(pNamTC, tcuoi))
        i = 0
        shtk = ""
        shpl = ""
        xlsheet = xlapp.Worksheets(2)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(3, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        rs = ExecSQLReturnDT("SELECT DISTINCT HethongTK.SoHieu AS SHTK, PhanLoaiVattu.SoHieu AS SHPL, HethongTK.Ten" + Ngonngu("", "E") + ", TenPhanLoai, KhoHang.TenKho, Vattu.SoHieu, TenVattu, DonVi, (Tien_" & CThangDB2(tcuoi) & ") AS Tien, (Luong_" & ConvertToStrSafe(CThangDB2(tcuoi)) & ") AS Luong FROM (((TonKho INNER JOIN HethongTK ON TonKho.MaTaiKhoan=HethongTK.MaSo) INNER JOIN KhoHang ON TonKho.MaSoKho=KhoHang.MaSo) INNER JOIN Vattu ON TonKho.MaVattu=Vattu.MaSo) INNER JOIN PhanLoaiVattu ON Vattu.MaPhanLoai=PhanLoaiVattu.MaSo WHERE (HethongTK.SoHieu LIKE '152%' OR HethongTK.SoHieu LIKE '153%' OR HethongTK.SoHieu LIKE '155%' OR HethongTK.SoHieu LIKE '156%') AND (Tien_" & ConvertToStrSafe(CThangDB2(tcuoi)) & "<>0 OR Luong_" & ConvertToStrSafe(CThangDB2(tcuoi)) & "<>0) ORDER BY HethongTK.SoHieu, PhanLoaiVattu.SoHieu, KhoHang.TenKho, Vattu.SoHieu")
        For Each rsItem As DataRow In rs.Rows
            i += 1
            If shtk <> ConvertToStrSafe(rsItem("shtk")) Then
                shtk = ConvertToStrSafe(rsItem("shtk"))
                xlsheet.Cells(7 + i, 2) = ConvertToStrSafe(rsItem("ten" + Ngonngu("", "E")))
                xlsheet.Range(String.Format("A{0}", 7 + i), String.Format("N{0}", 7 + i)).Font.Bold = True
                Continue For
            End If
            If shpl <> ConvertToStrSafe(rsItem("shpl")) Then
                shpl = ConvertToStrSafe(rsItem("shpl"))
                xlsheet.Cells(7 + i, 2) = ConvertToStrSafe(rsItem("TenPhanLoai"))
                xlsheet.Range(String.Format("A{0}", 7 + i), String.Format("N{0}", 7 + i)).Font.Bold = True
                xlsheet.Range(String.Format("A{0}", 7 + i), String.Format("N{0}", 7 + i)).Font.Italic = True
                Continue For
            End If
            If kh <> ConvertToStrSafe(rsItem("tenkho")) Then
                kh = ConvertToStrSafe(rsItem("tenkho"))
                xlsheet.Cells(7 + i, 2) = ConvertToStrSafe(rsItem("tenkho"))
                xlsheet.Range(String.Format("A{0}", 7 + i), String.Format("N{0}", 7 + i)).Font.Italic = True
                Continue For
            End If
            xlsheet.Cells(7 + i, 1) = ConvertToStrSafe(i)
            xlsheet.Cells(7 + i, 2) = ConvertToStrSafe(rsItem("TenVattu"))
            xlsheet.Cells(7 + i, 3) = ConvertToStrSafe(rsItem("SoHieu"))
            xlsheet.Cells(7 + i, 4) = ConvertToStrSafe(rsItem("DonVi"))
            xlsheet.Cells(7 + i, 5) = ConvertToStrSafe(rsItem("luong"))
            xlsheet.Cells(7 + i, 6) = ConvertToStrSafe(rsItem("tien"))
        Next
        With xlsheet.Range("A5", String.Format("X{0}", (7 + i)))
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders.Weight = Excel.XlBorderWeight.xlThin
            Dim tempRefParam4 As Object = .Borders.Color
            tempRefParam4 = Color.FromArgb(0, 0, 0)
            Dim tempRefParam5 As Object = .RowHeight
            tempRefParam5 = 18
            Dim tempRefParam6 As Object = .VerticalAlignment
            tempRefParam6 = Excel.XlVAlign.xlVAlignCenter
            .Font.Name = pFontName
        End With
        XLSFooter(xlsheet, 10 + i, 24, NgayCuoiThang(pNamTC, tcuoi))
        i = 0
        xlsheet = xlapp.Worksheets(3)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(3, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        rs = ExecSQLReturnDT("SELECT DISTINCT KhoHang.MaSo, TenKho FROM (TonKho INNER JOIN KhoHang ON TonKho.MaSoKho=KhoHang.MaSo) INNER JOIN HethongTK ON TonKho.MaTaiKhoan=HethongTK.MaSo WHERE (HethongTK.SoHieu LIKE '152%' OR HethongTK.SoHieu LIKE '153%' OR HethongTK.SoHieu LIKE '155%' OR HethongTK.SoHieu LIKE '156%') AND (Tien_" & CThangDB2(tcuoi) & "<>0 OR Luong_" & ConvertToStrSafe(CThangDB2(tcuoi)) & "<>0)ORDER BY TenKho")
        For Each rsItem As DataRow In rs.Rows
            i += 1
            j = 0
            shtk = ""
            If i > 1 Then
                xlapp.Worksheets.Add(xlapp.Sheets(2 + i), , 1)
                xlsheet = xlapp.Worksheets(2 + i)
                xlsheet.Range("A1", "T7").PasteSpecial()
            Else
                xlsheet = xlapp.Worksheets(3)
            End If
            xlsheet.Cells(4, 1) = String.Format(Ngonngu("Kho : {0}", "Stock : {0}"), ConvertToStrSafe(rsItem("tenkho")))
            rs2 = ExecSQLReturnDT(String.Format("SELECT DISTINCT HethongTK.SoHieu AS SHTK, HethongTK.Ten" + Ngonngu("", "E") + ", Vattu.SoHieu, TenVattu, DonVi, Tien_{0} AS Tien, Luong_{0} AS Luong FROM (TonKho INNER JOIN HethongTK ON TonKho.MaTaiKhoan=HethongTK.MaSo) INNER JOIN Vattu ON TonKho.MaVattu=Vattu.MaSo WHERE (HethongTK.SoHieu LIKE '152%' OR HethongTK.SoHieu LIKE '153%' OR HethongTK.SoHieu LIKE '155%' OR HethongTK.SoHieu LIKE '156%') AND (Tien_{0}<>0 OR Luong_{0}<>0) AND MaSoKho={1} ORDER BY HethongTK.SoHieu, Vattu.SoHieu", _
                                      CThangDB2(tcuoi), _
                                      ConvertToStrSafe(rsItem("MaSo"))))
            For Each rs2Item As DataRow In rs2.Rows
                j += 1
                If shtk <> ConvertToStrSafe(rs2Item("shtk")) Then
                    shtk = ConvertToStrSafe(rs2Item("shtk"))
                    xlsheet.Cells(7 + j, 2) = ConvertToStrSafe(rs2Item("ten" + Ngonngu("", "E")))
                    xlsheet.Range(String.Format("A{0}", 7 + j), String.Format("T{0}", 7 + j)).Font.Bold = True
                    Continue For
                End If
                xlsheet.Cells(7 + j, 1) = ConvertToStrSafe(j)
                xlsheet.Cells(7 + j, 2) = ConvertToStrSafe(rs2Item("TenVattu"))
                xlsheet.Cells(7 + j, 3) = ConvertToStrSafe(rs2Item("SoHieu"))
                xlsheet.Cells(7 + j, 4) = ConvertToStrSafe(rs2Item("DonVi"))
                xlsheet.Cells(7 + j, 5) = ConvertToStrSafe(rs2Item("luong"))
                xlsheet.Cells(7 + j, 6) = ConvertToStrSafe(rs2Item("tien"))
            Next
            With xlsheet.Range("A5", String.Format("T{0}", 7 + j))
                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                .Borders.Weight = Excel.XlBorderWeight.xlThin
                Dim tempRefParam7 As Object = .Borders.Color
                tempRefParam7 = Color.FromArgb(0, 0, 0)
                Dim tempRefParam8 As Object = .RowHeight
                tempRefParam8 = 18
                Dim tempRefParam9 As Object = .VerticalAlignment
                tempRefParam9 = Excel.XlVAlign.xlVAlignCenter
                .Font.Name = pFontName
            End With
            XLSFooter(xlsheet, 10 + j, 20, NgayCuoiThang(pNamTC, tcuoi))
            xlsheet.Range("A1", "T7").Copy()
        Next
        k = 3 + i
        i = 0
        rs = ExecSQLReturnDT(String.Format("SELECT DISTINCT KhoHang.MaSo AS MKho,TenKho,HethongTK.MaSo,HethongTK.SoHieu,Ten" + Ngonngu("", "E") + " FROM (TonKho INNER JOIN KhoHang ON TonKho.MaSoKho=KhoHang.MaSo) INNER JOIN HethongTK ON TonKho.MaTaiKhoan=HethongTK.MaSo WHERE (HethongTK.SoHieu LIKE '152%' OR HethongTK.SoHieu LIKE '153%' OR HethongTK.SoHieu LIKE '155%' OR HethongTK.SoHieu LIKE '156%') AND (Tien_{0}<>0 OR Luong_{1}<>0) GROUP BY TenKho,HethongTK.SoHieu,Ten" + Ngonngu("", "e") + ",KhoHang.MaSo,HethongTK.MaSo ORDER BY TenKho,HethongTK.SoHieu", _
                                 CThangDB2(tcuoi), _
                                 ConvertToStrSafe(CThangDB2(tcuoi))))
        For Each rsItem As DataRow In rs.Rows
            i += 1
            If i > 1 Then
                xlapp.Worksheets.Add(xlapp.Sheets(k + i - 2), , 1)
                xlsheet = xlapp.Worksheets(k + i - 2)
                xlsheet.Range("A1", "Y8").PasteSpecial()
            Else
                xlsheet = xlapp.Worksheets(k)
            End If
            xlsheet.Cells(4, 1) = String.Format(Ngonngu("Kho: {0}", "Stock: {0}"), ConvertToStrSafe(rsItem("tenkho")))
            xlsheet.Cells(5, 1) = String.Format(Ngonngu("Số hiệu tài khoản: {0} - Tên tài khoản: {1}", "Account code: {0} - Account name: {1}"), _
                                      ConvertToStrSafe(rsItem("SoHieu")), _
                                      ConvertToStrSafe(rsItem("ten" + Ngonngu("", "E"))))
            j = 0
            rs2 = ExecSQLReturnDT(String.Format("SELECT DISTINCT Vattu.SoHieu, TenVattu, DonVi, Tien_{0} AS Tien, Luong_{0} AS Luong FROM TonKho INNER JOIN Vattu ON TonKho.MaVattu=Vattu.MaSo WHERE (Tien_{0}<>0 OR Luong_{0}<>0) AND MaSoKho={1} AND MaTaiKhoan={2} ORDER BY Vattu.SoHieu", _
                                      CThangDB2(tcuoi), _
                                      ConvertToStrSafe(rsItem("mkho")), _
                                      ConvertToStrSafe(rsItem("MaSo"))))
            For Each rs2Item As DataRow In rs2.Rows
                j += 1
                xlsheet.Cells(8 + j, 1) = ConvertToStrSafe(j)
                xlsheet.Cells(8 + j, 2) = ConvertToStrSafe(rs2Item("TenVattu"))
                xlsheet.Cells(8 + j, 3) = ConvertToStrSafe(rs2Item("SoHieu"))
                xlsheet.Cells(8 + j, 4) = ConvertToStrSafe(rs2Item("DonVi"))
                xlsheet.Cells(8 + j, 6) = ConvertToStrSafe(rs2Item("luong"))
                xlsheet.Cells(8 + j, 7) = ConvertToStrSafe(rs2Item("tien"))
            Next
            With xlsheet.Range("A6", String.Format("Y{0}", 8 + j))
                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                .Borders.Weight = Excel.XlBorderWeight.xlThin
                Dim tempRefParam10 As Object = .Borders.Color
                tempRefParam10 = Color.FromArgb(0, 0, 0)
                Dim tempRefParam11 As Object = .RowHeight
                tempRefParam11 = 18
                Dim tempRefParam12 As Object = .VerticalAlignment
                tempRefParam12 = Excel.XlVAlign.xlVAlignCenter
                .Font.Name = pFontName
            End With
            XLSFooter(xlsheet, 10 + j, 25, NgayCuoiThang(pNamTC, tcuoi))
            xlsheet.Range("A1", "Y8").Copy()
        Next
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\152.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub Baocao154(ByRef tcuoi As Integer)
        Dim rs As DataTable
        Dim i, j As Integer, qchitiet As String = String.Empty
        Dim shpl As String = String.Empty
        Dim ncuoi As Date = NgayCuoiThang(pNamTC, tcuoi)
        Recycle(String.Format("{0}\temp\154.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\{1}REPORTS\154.XLS", pCurDir, Ngonngu("", "E")), String.Format("{0}\temp\154.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\154.XLS", pCurDir))
        On Error GoTo 0
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(3, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        InChiPhi3(pThangDauKy, tcuoi, 0, qchitiet)
        rs = ExecSQLReturnDT(qchitiet)
        Dim k As Integer = 0
        While k <= (rs.Rows.Count - 1)
            Dim rsItem As DataRow = rs.Rows(k)
            Dim shplx As String = ConvertToStrSafe(rsItem("shpl"))
            i += 1
            If shpl = shplx Then
                j += 1
                xlsheet.Cells(7 + i, 1) = ConvertToStrSafe(j)
                xlsheet.Cells(7 + i, 2) = ConvertToStrSafe(rsItem("TenVattu"))
                xlsheet.Cells(7 + i, 12) = ConvertToStrSafe(rsItem("CK1"))
                k += 1
            Else
                shpl = shplx
                xlsheet.Cells(7 + i, 2) = ConvertToStrSafe(rsItem("TenPhanLoai"))
                xlsheet.Range(String.Format("B{0}", 7 + i)).Font.Bold = True
            End If
        End While
        With xlsheet.Range("A6", String.Format("L{0}", 7 + i))
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders.Weight = Excel.XlBorderWeight.xlThin
            Dim tempRefParam As Object = .Borders.Color
            tempRefParam = Color.FromArgb(0, 0, 0)
            Dim tempRefParam2 As Object = .RowHeight
            tempRefParam2 = 18
            Dim tempRefParam3 As Object = .VerticalAlignment
            tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
        End With
        XLSFooter(xlsheet, 10 + i, 8, NgayCuoiThang(pNamTC, tcuoi))
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\154.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub Baocao222(ByRef tcuoi As Integer)
        Dim ncuoi As Date = NgayCuoiThang(pNamTC, tcuoi)
        Recycle(String.Format("{0}\temp\222.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\{1}REPORTS\222.XLS", pCurDir, Ngonngu("", "E")), String.Format("{0}\temp\222.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\222.XLS", pCurDir))
        On Error GoTo 0
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = "Đến ngày :" & Format(ncuoi, Mask_DB)
        SheetSoDu(xlsheet, "222", 2, tcuoi, 1, 2, 5, 6, 7, 6, ncuoi)
        xlsheet = xlapp.Worksheets(2)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        SheetSoDu(xlsheet, "228", 2, tcuoi, 1, 2, 4, 7, 7, 7, ncuoi)
        xlsheet = xlapp.Worksheets(3)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        SheetSoDu(xlsheet, "229", 2, tcuoi, 1, 2, 3, 4, 7, 4, ncuoi)
        xlsheet = xlapp.Worksheets(4)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        SheetSoDu(xlsheet, "244", 2, tcuoi, 1, 2, 3, 4, 8, 4, ncuoi)
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\222.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub Baocao241(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim rs As DataTable
        Dim i, j As Integer
        Dim sqlcx As New StringBuilder
        Dim sqlnx As New StringBuilder
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        Dim TK As New ClsTaikhoan
        Dim ncuoi As Date = NgayCuoiThang(pNamTC, tcuoi)
        Recycle(String.Format("{0}\temp\241.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\{1}REPORTS\241.XLS", pCurDir, Ngonngu("", "E")), String.Format("{0}\temp\241.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\241.XLS", pCurDir))
        On Error GoTo 0
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(4, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        For i = CThangDB2(tdau) To CThangDB2(tcuoi)
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
        For i = 1 To tcuoi
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
        i = 0
        rs = ExecSQLReturnDT(String.Format("SELECT SoHieu, Cap, Ten" + Ngonngu("", "e") + ", GhiChu, Sum(DuNo_0-DuCo_0) AS DuDK,Sum({0}) AS PSN,Sum({1}) AS PSC,Sum({2}) AS PSNx,Sum({3}) AS PSCx,Sum(DuNo_{4}-DuCo_{4}) AS DuCK  FROM HethongTK WHERE SoHieu LIKE '241%' AND Cap>1 AND (DuNo_0-DuCo_0<>0 OR {2}<>0 OR {3}<>0) GROUP BY SoHieu, Cap, Ten" + Ngonngu("", "e") + ", GhiChu ORDER BY SoHieu", sqln, sqlc, sqlnx, sqlcx, ConvertToStrSafe(CThangDB2(tcuoi))))
        For Each rsItem As DataRow In rs.Rows
            i += 1
            TK.InitTaikhoanSohieu(ConvertToStrSafe(rsItem("SoHieu")))
            xlsheet.Cells(10 + i, 2) = String.Format("{0}{1}", Space(2 * (ConvertToDblSafe(rsItem("cap")) - 1)), ConvertToStrSafe(rsItem("ten" + Ngonngu("", "e"))))
            xlsheet.Cells(10 + i, 3) = ConvertToStrSafe(rsItem("DuDk"))
            xlsheet.Cells(10 + i, 4) = ConvertToStrSafe(rsItem("psn"))
            xlsheet.Cells(10 + i, 5) = ConvertToStrSafe(rsItem("psnx"))
            xlsheet.Cells(10 + i, 6) = TK.PSTuKhoiCong(ncuoi, -1)
            xlsheet.Cells(10 + i, 7) = ConvertToStrSafe(rsItem("psc"))
            xlsheet.Cells(10 + i, 8) = ConvertToStrSafe(rsItem("pscx"))
            xlsheet.Cells(10 + i, 9) = TK.PSTuKhoiCong(ncuoi, 1)
            xlsheet.Cells(10 + i, 11) = ConvertToStrSafe(rsItem("DuCK"))
            Select Case ConvertToDblSafe(rsItem("cap"))
                Case 2, 3
                    xlsheet.Range(String.Format("A{0}", 10 + i), String.Format("K{0}", 10 + i)).Font.Bold = True
                    j = 0
                Case 4
                    xlsheet.Range(String.Format("A{0}", 10 + i), String.Format("K{0}", 10 + i)).Font.Bold = True
                    xlsheet.Range(String.Format("A{0}", 10 + i), String.Format("K{0}", 10 + i)).Font.Italic = True
                    j += 1
                    xlsheet.Cells(10 + i, 1) = ConvertToStrSafe(j)
            End Select
        Next
        If i > 0 Then
            With xlsheet.Range("A10", String.Format("K{0}", 10 + i))
                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                .Borders.Weight = Excel.XlBorderWeight.xlThin
                Dim tempRefParam As Object = .Borders.Color
                tempRefParam = Color.FromArgb(0, 0, 0)
                Dim tempRefParam2 As Object = .RowHeight
                tempRefParam2 = 18
                Dim tempRefParam3 As Object = .VerticalAlignment
                tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
            End With
        End If
        XLSFooter(xlsheet, 12 + i, 11, NgayCuoiThang(pNamTC, tcuoi))
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\241.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub Baocao311(ByRef tcuoi As Integer)
        Dim rs As DataTable
        Dim i, j As Integer
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        Dim ncuoi As Date = NgayCuoiThang(pNamTC, tcuoi)
        Recycle(String.Format("{0}\temp\311.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\{1}REPORTS\311.XLS", pCurDir, Ngonngu("", "E")), String.Format("{0}\temp\311.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\311.XLS", pCurDir))
        On Error GoTo 0
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        SheetSoDu(xlsheet, "311", 2, tcuoi, 1, 2, 3, 6, 7, 6, ncuoi)
        xlsheet = xlapp.Worksheets(2)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        SheetSoDu(xlsheet, "315", 2, tcuoi, 1, 2, 3, 5, 7, 5, ncuoi)
        For i = 1 To CThangDB2(tcuoi)
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
        i = 0
        j = 0
        xlsheet = xlapp.Worksheets(3)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        rs = ExecSQLReturnDT(String.Format("SELECT SoHieu, Cap, Ten, GhiChu, Sum(DuCo_0-DuNo_0) AS DN, Sum({0}) AS PSN, Sum({1}) AS PSC, Sum(DuCo_{2}-DuNo_{2}) AS SoDu FROM HethongTK WHERE SoHieu LIKE '341%' AND Cap>1 GROUP BY SoHieu, Cap, Ten, GhiChu ORDER BY SoHieu", sqln, sqlc, ConvertToStrSafe(CThangDB2(tcuoi))))
        For Each rsItem As DataRow In rs.Rows
            i += 1
            If ConvertToDblSafe(rsItem("cap")) = 2 Then
                xlsheet.Range(String.Format("A{0}", 9 + i), String.Format("O{0}", 9 + i)).Font.Bold = True
                j = 0
            Else
                j += 1
                xlsheet.Cells(9 + i, 1) = ConvertToStrSafe(j)
            End If
            xlsheet.Cells(9 + i, 2) = String.Format("{0}{1}", Space(2 * (ConvertToDblSafe(rsItem("cap")) - 1)), ConvertToStrSafe(rsItem("ten")))
            xlsheet.Cells(9 + i, 6) = ConvertToStrSafe(rsItem("dn"))
            xlsheet.Cells(9 + i, 7) = ConvertToStrSafe(rsItem("psc"))
            xlsheet.Cells(9 + i, 10) = ConvertToStrSafe(rsItem("psn"))
            xlsheet.Cells(9 + i, 15) = ConvertToStrSafe(rsItem("sodu"))
        Next
        With xlsheet.Range("A9", "O" & 10 + i)
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders.Weight = Excel.XlBorderWeight.xlThin
            Dim tempRefParam As Object = .Borders.Color
            tempRefParam = Color.FromArgb(0, 0, 0)
            Dim tempRefParam2 As Object = .RowHeight
            tempRefParam2 = 18
            Dim tempRefParam3 As Object = .VerticalAlignment
            tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
        End With
        XLSFooter(xlsheet, 12 + i, 15, NgayCuoiThang(pNamTC, tcuoi))
        xlsheet = xlapp.Worksheets(4)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        SheetSoDu(xlsheet, "342", 2, tcuoi, 1, 2, 5, 7, 7, 7, ncuoi)
        xlsheet = xlapp.Worksheets(5)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        SheetSoDu(xlsheet, "344", 2, tcuoi, 1, 2, 4, 5, 7, 5, ncuoi)
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\311.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub Baocao333(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim rs As DataTable
        Dim j, i As Integer
        Dim sqlcx As New StringBuilder
        Dim sqlnx As New StringBuilder
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        Dim kq As Double
        Dim ncuoi As Date = NgayCuoiThang(pNamTC, tcuoi)
        Recycle(String.Format("{0}\temp\333.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\{1}REPORTS\333.XLS", pCurDir, Ngonngu("", "E")), String.Format("{0}\temp\333.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\333.XLS", pCurDir))
        On Error GoTo 0
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(4, 1) = ThoiGianTheoThang(tdau, tcuoi)
        For i = CThangDB2(tdau) To CThangDB2(tcuoi)
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
        For i = 1 To tcuoi
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
        i = 0
        rs = ExecSQLReturnDT(String.Format("SELECT SoHieu, Cap, Ten" + Ngonngu("", "e") + ", GhiChu, Sum(DuCo_0-DuNo_0) AS DuDK,Sum({0}) AS PSN,Sum({1}) AS PSC,Sum({2}) AS PSNx,Sum({3}) AS PSCx,Sum(DuCo_{4}-DuNo_{4}) AS DuCK  FROM HethongTK WHERE ((SoHieu LIKE '333%' AND Cap=2) OR (SoHieu LIKE '333111%' AND Cap=5 AND TKCon=0)) AND (DuCo_0-DuNo_0<>0 OR {2}<>0 OR {3}<>0) GROUP BY SoHieu, Cap, Ten" + Ngonngu("", "e") + ", GhiChu ORDER BY SoHieu", sqln, sqlc, sqlnx, sqlcx, ConvertToStrSafe(CThangDB2(tcuoi))))
        Dim rsIndex As Integer = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            i += 1
            If rsItem("cap") = 2 Then
                j += 1
                xlsheet.Cells(9 + i, 1) = ConvertToStrSafe(j)
                xlsheet.Range(String.Format("A{0}", 9 + i), String.Format("H{0}", 9 + i)).Font.Bold = True
                For k As Integer = 3 To 8
                    If xlsheet.Range(String.Format("{0}9", XLSCol(k))).Formula = "" Then
                        xlsheet.Range(String.Format("{0}9", XLSCol(k))).Formula = String.Format("={0}{1}", XLSCol(k), ConvertToStrSafe(9 + i)) 'Excel Fomular
                    Else
                        xlsheet.Range(String.Format("{0}9", XLSCol(k))).Formula = String.Format("{0}+{1}{2}", (xlsheet.Range(String.Format("{0}9", XLSCol(k))).Formula), XLSCol(k), ConvertToStrSafe(9 + i)) 'Excel Fomular
                    End If
                Next
            End If
            xlsheet.Cells(9 + i, 2) = String.Format("{0}{1}", Space(2 * (ConvertToDblSafe(rsItem("cap")) - 1)), ConvertToStrSafe(rsItem("ten" + Ngonngu("", "e"))))
            xlsheet.Cells(9 + i, 3) = rsItem("DuDk")
            xlsheet.Cells(9 + i, 8) = rsItem("DuCK")
            If Strings.Left(rsItem("SoHieu"), 4) = "3331" Then
                xlsheet.Cells(9 + i, 4) = PhaiNopVAT(tdau, tcuoi, rsItem("SoHieu"), kq)
                xlsheet.Cells(9 + i, 6) = kq
                xlsheet.Cells(9 + i, 5) = PhaiNopVAT(pThangDauKy, tcuoi, rsItem("SoHieu"), kq)
                xlsheet.Cells(9 + i, 7) = kq
            Else
                xlsheet.Cells(9 + i, 4) = rsItem("psc")
                xlsheet.Cells(9 + i, 5) = rsItem("pscx")
                xlsheet.Cells(9 + i, 6) = rsItem("psn")
                xlsheet.Cells(9 + i, 7) = rsItem("psnx")
            End If
            ''rs.MoveNext()
        Loop
        i = 0
        j = 0
        rs = ExecSQLReturnDT(String.Format("SELECT SoHieu, Cap, Ten" + Ngonngu("", "e") + ", GhiChu, Sum(DuCo_0-DuNo_0) AS DuDK,Sum({0}) AS PSN,Sum({1}) AS PSC,Sum({2}) AS PSNx,Sum({3}) AS PSCx,Sum(DuCo_{4}-DuNo_{4}) AS DuCK  FROM HethongTK WHERE ((SoHieu LIKE '3383%') OR (SoHieu LIKE '3384%')) AND (DuCo_0-DuNo_0<>0 OR {2}<>0 OR {3}<>0) GROUP BY SoHieu, Cap, Ten" + Ngonngu("", "e") + ", GhiChu ORDER BY SoHieu", sqln, sqlc, sqlnx, sqlcx, ConvertToStrSafe(CThangDB2(tcuoi))))
        rsIndex = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            i += 1
            If rsItem("cap") = 2 Then
                j += 1
                xlsheet.Cells(30 + i, 1) = ConvertToStrSafe(j)
                xlsheet.Range(String.Format("A{0}", 30 + i), String.Format("H{0}", 30 + i)).Font.Bold = True
                For k As Integer = 3 To 8
                    If xlsheet.Range(String.Format("{0}30", XLSCol(k))).Formula = "" Then
                        xlsheet.Range(String.Format("{0}30", XLSCol(k))).Formula = String.Format("={0}{1}", XLSCol(k), ConvertToStrSafe(30 + i)) 'Excel Fomular
                    Else
                        xlsheet.Range(String.Format("{0}30", XLSCol(k))).Formula = String.Format("{0}+{1}{2}", (xlsheet.Range(String.Format("{0}30", XLSCol(k))).Formula), XLSCol(k), ConvertToStrSafe(30 + i)) 'Excel Fomular
                    End If
                Next
            End If
            xlsheet.Cells(30 + i, 2) = String.Format("{0}{1}", Space(2 * (ConvertToDblSafe(rsItem("cap")) - 1)), ConvertToStrSafe(rsItem("ten" + Ngonngu("", "e"))))
            xlsheet.Cells(30 + i, 3) = rsItem("DuDk")
            xlsheet.Cells(30 + i, 4) = rsItem("psc")
            xlsheet.Cells(30 + i, 5) = rsItem("pscx")
            xlsheet.Cells(30 + i, 6) = rsItem("psn")
            xlsheet.Cells(30 + i, 7) = rsItem("psnx")
            xlsheet.Cells(30 + i, 8) = rsItem("DuCK")
            ''rs.MoveNext()
        Loop
        ''rs.Close()
        xlsheet.Cells(50, 3) = SoPSTK("3331", tdau, tcuoi, 1)
        kq = SoPSTK(pVATV, tdau, tcuoi, -1)
        xlsheet.Cells(51, 3) = kq
        If PSDu("3331", pVATV, tdau, tcuoi) > 0 Then
            xlsheet.Cells(52, 3) = PSDu("3331", pVATV, tdau, tcuoi)
        Else
            kq -= PSDu("6", pVATV, tdau, tcuoi)
            xlsheet.Cells(52, 3) = kq
        End If
        xlsheet.Cells(50, 4) = SoPSTK("3331", pThangDauKy, tcuoi, 1)
        kq = SoPSTK(pVATV, pThangDauKy, tcuoi, -1)
        xlsheet.Cells(51, 4) = kq
        If PSDu("3331", pVATV, pThangDauKy, tcuoi) > 0 Then
            xlsheet.Cells(52, 4) = PSDu("3331", pVATV, pThangDauKy, tcuoi)
        Else
            kq -= PSDu("6", pVATV, pThangDauKy, tcuoi)
            xlsheet.Cells(52, 4) = kq
        End If
        xlsheet = xlapp.Worksheets(2)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(4, 1) = ThoiGianTheoThang(tdau, tcuoi)
        i = 0
        j = 0
        sqln = New StringBuilder("")
        rs = ExecSQLReturnDT(String.Format("SELECT HethongTK.SoHieu AS SH, HethongTK.Ten" + Ngonngu("", "e") + ",ChungTu.SoHieu,ChungTu.NgayCT, SoPS FROM (ChungTu INNER JOIN HethongTK ON ChungTu.MaTKTCNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo WHERE {0} AND HethongTK.SoHieu LIKE '333%' AND (TK.SoHieu LIKE '111%' OR TK.SoHieu LIKE '112%') ORDER BY HethongTK.SoHieu, ChungTu.NgayCT, ChungTu.SoHieu", WThang("ThangCT", tdau, tcuoi)))
        'Dim rsIndex As Integer = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            i += 1
            If sqln.ToString() <> rsItem("sh") Then
                j += 1
                sqln = New StringBuilder(ConvertToStrSafe(rsItem("sh")))
                xlsheet.Cells(7 + i, 1) = ConvertToStrSafe(j)
            End If
            xlsheet.Cells(7 + i, 2) = rsItem("ten" + Ngonngu("", "e"))
            xlsheet.Cells(7 + i, 3) = rsItem("SoHieu")
            xlsheet.Cells(7 + i, 4) = rsItem("NgayCT")
            xlsheet.Cells(7 + i, 5) = rsItem("sops")
            ''rs.MoveNext()
        Loop
        xlsheet.Range(String.Format("A{0}", 9 + i), String.Format("AE{0}", 9 + i)).Font.Bold = True
        xlsheet.Cells(9 + i, 2) = Ngonngu("Tổng cộng", "Total")
        xlsheet.Range("E" & 9 + i).Formula = String.Format("=SUM(E7:E{0})", 8 + i) 'Excel Fomular
        With xlsheet.Range("A5", String.Format("F{0}", 10 + i))
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders.Weight = Excel.XlBorderWeight.xlThin
            Dim tempRefParam As Object = .Borders.Color
            tempRefParam = Color.FromArgb(0, 0, 0)
            Dim tempRefParam2 As Object = .RowHeight
            tempRefParam2 = 18
            Dim tempRefParam3 As Object = .VerticalAlignment
            tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
        End With
        XLSFooter(xlsheet, 12 + i, 6, NgayCuoiThang(pNamTC, tcuoi))
        rs = Nothing
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\333.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub Baocao334(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim TK As New ClsTaikhoan
        Dim DC, dn, nt As Double
        Recycle(String.Format("{0}\temp\334.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\{1}REPORTS\334.XLS", pCurDir, Ngonngu("", "E")), String.Format("{0}\temp\334.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\334.XLS", pCurDir))
        On Error GoTo 0
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(4, 1) = ThoiGianTheoThang(tdau, tcuoi)
        xlsheet.Cells(16, 4) = PSDu("", "334", tdau, tcuoi)
        xlsheet.Cells(16, 5) = PSDu("", "334", pThangDauKy, tcuoi)
        xlsheet.Cells(17, 4) = PSDu("", "3383", tdau, tcuoi)
        xlsheet.Cells(17, 5) = PSDu("", "3383", pThangDauKy, tcuoi)
        xlsheet = xlapp.Worksheets(2)
        TK.InitTaikhoanSohieu("3383")
        TK.SoDuTK(ThangTruoc(tdau), dn, DC, nt)
        xlsheet.Cells(8, 3) = DC - dn
        TK.SoPhatSinh(tdau, tcuoi, dn, DC)
        xlsheet.Cells(10, 3) = DC
        xlsheet.Cells(17, 3) = dn
        TK.InitTaikhoanSohieu("3384")
        TK.SoDuTK(ThangTruoc(tdau), dn, DC, nt)
        xlsheet.Cells(8, 4) = DC - dn
        TK.SoPhatSinh(tdau, tcuoi, dn, DC)
        xlsheet.Cells(10, 4) = DC
        xlsheet.Cells(17, 4) = dn
        TK.InitTaikhoanSohieu("3382")
        TK.SoDuTK(ThangTruoc(tdau), dn, DC, nt)
        xlsheet.Cells(8, 5) = DC - dn
        TK.SoPhatSinh(tdau, tcuoi, dn, DC)
        xlsheet.Cells(10, 5) = DC
        xlsheet.Cells(17, 5) = dn
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\334.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub Baocao338(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim rs As DataTable
        Dim i, j As Integer
        Dim kq As Double
        Dim sqlcx As New StringBuilder
        Dim sqlnx As New StringBuilder
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        Dim T(5) As Double
        Dim ncuoi As Date = NgayCuoiThang(pNamTC, tcuoi)
        Recycle(String.Format("{0}\temp\338.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\{1}REPORTS\338.XLS", pCurDir, Ngonngu("", "E")), String.Format("{0}\temp\338.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\338.XLS", pCurDir))
        On Error GoTo 0
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        SheetSoDu(xlsheet, "337", 2, tcuoi, 1, 2, 3, 4, 7, 4, ncuoi)
        xlsheet = xlapp.Worksheets(2)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        SheetSoDu(xlsheet, "338", 2, tcuoi, 1, 2, 3, 4, 7, 4, ncuoi)
        xlsheet = xlapp.Worksheets(4)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = String.Format(Ngonngu("Đến ngày :{0}", "To date:{0}"), Format(ncuoi, Mask_D))
        SheetSoDu(xlsheet, "3381", 3, tcuoi, 1, 2, 4, 5, 7, 5, ncuoi)
        For i = CThangDB2(tdau) To CThangDB2(tcuoi)
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
        For i = 1 To tcuoi
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
        i = 0
        j = 0
        xlsheet = xlapp.Worksheets(3)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(4, 1) = ThoiGianTheoThang(tdau, tcuoi)
        rs = ExecSQLReturnDT(String.Format("SELECT SoHieu, Cap, Ten" + Ngonngu("", "e") + ", GhiChu, Sum(DuCo_0-DuNo_0) AS DuDK, Sum({0}) AS PSN, Sum({1}) AS PSC, Sum({2}) AS PSNx, Sum({3}) AS PSCx, Sum(DuCo_{4}-DuNo_{4}) AS DuCK  FROM HethongTK WHERE (SoHieu LIKE '335%' AND Cap>1) AND (DuCo_0-DuNo_0<>0 OR {2}<>0 OR {3}<>0) GROUP BY SoHieu, Cap, Ten" + Ngonngu("", "e") + ", GhiChu ORDER BY SoHieu", sqln, sqlc, sqlnx, sqlcx, ConvertToStrSafe(CThangDB2(tcuoi))))
        Dim rsIndex As Integer = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            i += 1
            If rsItem("cap") = 2 Then
                j += 1
                xlsheet.Cells(9 + i, 1) = ConvertToStrSafe(j)
                xlsheet.Range(String.Format("A{0}", 9 + i), String.Format("H{0}", 9 + i)).Font.Bold = True
                T(0) += rsItem("DuDk")
                T(1) += rsItem("psn")
                T(2) += rsItem("psc")
                T(3) += rsItem("psnx")
                T(4) += rsItem("pscx")
                T(5) += rsItem("DuCK")
            End If
            xlsheet.Cells(9 + i, 2) = String.Format("{0}{1}", Space(2 * (ConvertToDblSafe(rsItem("cap")) - 1)), ConvertToStrSafe(rsItem("ten")))
            xlsheet.Cells(9 + i, 3) = rsItem("DuDk")
            xlsheet.Cells(9 + i, 8) = rsItem("DuCK")
            xlsheet.Cells(9 + i, 4) = rsItem("psn")
            xlsheet.Cells(9 + i, 5) = rsItem("psc")
            xlsheet.Cells(9 + i, 6) = rsItem("psnx")
            xlsheet.Cells(9 + i, 7) = rsItem("pscx")
            ''rs.MoveNext()
        Loop
        xlsheet.Range(String.Format("A{0}", 9 + i), String.Format("H{0}", 9 + i)).Font.Bold = True
        xlsheet.Cells(10 + i, 2) = Ngonngu("Tổng cộng", "Total")
        For j = 1 To 6
            xlsheet.Cells(10 + i, j + 2) = T(j - 1)
        Next
        With xlsheet.Range("A6", "H" & 10 + i)
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders.Weight = Excel.XlBorderWeight.xlThin
            Dim tempRefParam As Object = .Borders.Color
            tempRefParam = Color.FromArgb(0, 0, 0)
            Dim tempRefParam2 As Object = .RowHeight
            tempRefParam2 = 18
            Dim tempRefParam3 As Object = .VerticalAlignment
            tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
        End With
        XLSFooter(xlsheet, 12 + i, 8, NgayCuoiThang(pNamTC, tcuoi))
        ''rs.Close()
        rs = Nothing
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\338.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub Baocao411(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim TK As New ClsTaikhoan
        Dim ckc, ckn, cknt As Double
        Dim ncuoi As Date = NgayCuoiThang(pNamTC, tcuoi)
        Recycle(String.Format("{0}\temp\411.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\{1}REPORTS\411.XLS", pCurDir, Ngonngu("", "E")), String.Format("{0}\temp\411.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\411.XLS", pCurDir))
        On Error GoTo 0
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(2, 1) = ThoiGianTheoThang(tdau, tcuoi)
        For i As Integer = 1 To 2
            TK.InitTaikhoanSohieu(String.Format("41110{0}", i))
            TK.SoDuTK(ThangTruoc(tdau), ckn, ckc, cknt)
            xlsheet.Cells(7 + i, 4) = ckc - ckn
            TK.SoPhatSinh(tdau, tcuoi, ckn, ckc)
            xlsheet.Cells(11 + i, 4) = ckc
            xlsheet.Cells(15 + i, 4) = ckn
            TK.SoDuTK(0, ckn, ckc, cknt)
            xlsheet.Cells(7 + i, 9) = ckc - ckn
            TK.SoPhatSinh(pThangDauKy, tcuoi, ckn, ckc)
            xlsheet.Cells(11 + i, 9) = ckc
            xlsheet.Cells(15 + i, 9) = ckn
        Next
        For i As Integer = 1 To 2
            TK.InitTaikhoanSohieu(String.Format("41120{0}", i))
            TK.SoDuTK(ThangTruoc(tdau), ckn, ckc, cknt)
            xlsheet.Cells(7 + i, 5) = ckc - ckn
            TK.SoPhatSinh(tdau, tcuoi, ckn, ckc)
            xlsheet.Cells(11 + i, 5) = ckc
            xlsheet.Cells(15 + i, 5) = ckn
            TK.SoDuTK(0, ckn, ckc, cknt)
            xlsheet.Cells(7 + i, 10) = ckc - ckn
            TK.SoPhatSinh(pThangDauKy, tcuoi, ckn, ckc)
            xlsheet.Cells(11 + i, 10) = ckc
            xlsheet.Cells(15 + i, 10) = ckn
        Next
        xlsheet = xlapp.Worksheets(4)
        xlsheet.Cells(2, 1) = ThoiGianTheoThang(tdau, tcuoi)
        TK.InitTaikhoanSohieu("441")
        TK.SoDuTK(ThangTruoc(tdau), ckn, ckc, cknt)
        xlsheet.Cells(7, 3) = ckc - ckn
        TK.SoPhatSinh(tdau, tcuoi, ckn, ckc)
        xlsheet.Cells(8, 3) = ckc
        xlsheet.Cells(16, 3) = ckn
        TK.SoDuTK(0, ckn, ckc, cknt)
        xlsheet.Cells(7, 8) = ckc - ckn
        TK.SoPhatSinh(tdau, tcuoi, ckn, ckc)
        xlsheet.Cells(8, 8) = ckc
        xlsheet.Cells(16, 8) = ckn
        xlsheet = xlapp.Worksheets(5)
        xlsheet.Cells(5, 1) = ThoiGianTheoThang(tdau, tcuoi)
        TK.InitTaikhoanSohieu("414")
        TK.SoDuTK(ThangTruoc(tdau), ckn, ckc, cknt)
        xlsheet.Cells(10, 4) = ckc - ckn
        TK.SoPhatSinh(tdau, tcuoi, ckn, ckc)
        xlsheet.Cells(12, 4) = ckc
        xlsheet.Cells(18, 4) = ckn
        TK.SoDuTK(0, ckn, ckc, cknt)
        xlsheet.Cells(10, 5) = ckc - ckn
        TK.SoPhatSinh(tdau, tcuoi, ckn, ckc)
        xlsheet.Cells(12, 5) = ckc
        xlsheet.Cells(18, 5) = ckn
        TK.InitTaikhoanSohieu("415")
        TK.SoDuTK(ThangTruoc(tdau), ckn, ckc, cknt)
        xlsheet.Cells(27, 4) = ckc - ckn
        TK.SoPhatSinh(tdau, tcuoi, ckn, ckc)
        xlsheet.Cells(29, 4) = ckc
        xlsheet.Cells(35, 4) = ckn
        TK.SoDuTK(0, ckn, ckc, cknt)
        xlsheet.Cells(27, 5) = ckc - ckn
        TK.SoPhatSinh(tdau, tcuoi, ckn, ckc)
        xlsheet.Cells(29, 5) = ckc
        xlsheet.Cells(35, 5) = ckn
        TK.InitTaikhoanSohieu("416")
        TK.SoDuTK(ThangTruoc(tdau), ckn, ckc, cknt)
        xlsheet.Cells(46, 4) = ckc - ckn
        TK.SoPhatSinh(tdau, tcuoi, ckn, ckc)
        xlsheet.Cells(48, 4) = ckc
        xlsheet.Cells(53, 4) = ckn
        TK.SoDuTK(0, ckn, ckc, cknt)
        xlsheet.Cells(46, 5) = ckc - ckn
        TK.SoPhatSinh(tdau, tcuoi, ckn, ckc)
        xlsheet.Cells(48, 5) = ckc
        xlsheet.Cells(53, 5) = ckn
        TK.InitTaikhoanSohieu("3531")
        TK.SoDuTK(ThangTruoc(tdau), ckn, ckc, cknt)
        xlsheet.Cells(62, 4) = ckc - ckn
        TK.SoPhatSinh(tdau, tcuoi, ckn, ckc)
        xlsheet.Cells(64, 4) = ckc
        xlsheet.Cells(70, 4) = ckn
        TK.SoDuTK(0, ckn, ckc, cknt)
        xlsheet.Cells(62, 5) = ckc - ckn
        TK.SoPhatSinh(tdau, tcuoi, ckn, ckc)
        xlsheet.Cells(64, 5) = ckc
        xlsheet.Cells(70, 5) = ckn
        TK.InitTaikhoanSohieu("3532")
        TK.SoDuTK(ThangTruoc(tdau), ckn, ckc, cknt)
        xlsheet.Cells(79, 4) = ckc - ckn
        TK.SoPhatSinh(tdau, tcuoi, ckn, ckc)
        xlsheet.Cells(81, 4) = ckc
        xlsheet.Cells(86, 4) = ckn
        TK.SoDuTK(0, ckn, ckc, cknt)
        xlsheet.Cells(79, 5) = ckc - ckn
        TK.SoPhatSinh(tdau, tcuoi, ckn, ckc)
        xlsheet.Cells(81, 5) = ckc
        xlsheet.Cells(86, 5) = ckn
        TK.InitTaikhoanSohieu("451")
        TK.SoDuTK(ThangTruoc(tdau), ckn, ckc, cknt)
        xlsheet.Cells(100, 4) = ckc - ckn
        TK.SoPhatSinh(tdau, tcuoi, ckn, ckc)
        xlsheet.Cells(102, 4) = ckc
        xlsheet.Cells(107, 4) = ckn
        TK.SoDuTK(0, ckn, ckc, cknt)
        xlsheet.Cells(100, 5) = ckc - ckn
        TK.SoPhatSinh(tdau, tcuoi, ckn, ckc)
        xlsheet.Cells(102, 5) = ckc
        xlsheet.Cells(107, 5) = ckn
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\411.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub Baocao632(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Recycle(String.Format("{0}\temp\632.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\{1}REPORTS\632.XLS", pCurDir, Ngonngu("", "E")), String.Format("{0}\temp\632.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\632.XLS", pCurDir))
        On Error GoTo 0
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = ThoiGianTheoThang(tdau, tcuoi)
        xlsheet = xlapp.Worksheets(2)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = ThoiGianTheoThang(tdau, tcuoi)
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\632.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub Baocao642(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim rs As DataTable
        Dim i, j As Integer
        Dim ncuoi As Date
        Dim sqlnx As New StringBuilder
        Dim sqln As New StringBuilder
        Dim kq1, kq2 As Double
        Recycle(String.Format("{0}\temp\642.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\{1}REPORTS\642.XLS", pCurDir, Ngonngu("", "E")), String.Format("{0}\temp\642.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\642.XLS", pCurDir))
        On Error GoTo 0
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(4, 1) = ThoiGianTheoThang(tdau, tcuoi)
        For i = CThangDB2(tdau) To CThangDB2(tcuoi)
            If sqln.Length = 0 Then
                sqln.Append(String.Format("No_{0}", i))
            Else
                sqln.Append(String.Format(" + No_{0}", i))
            End If
        Next
        For i = 1 To tcuoi
            If sqlnx.Length = 0 Then
                sqlnx.Append(String.Format("No_{0}", i))
            Else
                sqlnx.Append(String.Format(" + No_{0}", i))
            End If
        Next
        i = 0
        rs = ExecSQLReturnDT(String.Format("SELECT SoHieu, Cap, Ten" + Ngonngu("", "e") + ", GhiChu, Sum({0}) AS PSN,Sum({1}) AS PSNx  FROM HethongTK WHERE SoHieu LIKE '642%' AND Cap>1 AND ({1}<>0) GROUP BY SoHieu, Cap, Ten" + Ngonngu("", "e") + ", GhiChu ORDER BY SoHieu", sqln, sqlnx))
        Dim rsIndex As Integer = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            i += 1
            If rsItem("cap") = 2 Then
                xlsheet.Range(String.Format("A{0}", 11 + i), String.Format("I{0}", 11 + i)).Font.Bold = True
                j += 1
                xlsheet.Cells(11 + i, 1) = ConvertToStrSafe(j)
                kq1 += rsItem("psn")
                kq2 += rsItem("psnx")
            End If
            xlsheet.Cells(11 + i, 2) = String.Format("{0}{1}", Space(2 * (ConvertToDblSafe(rsItem("cap")) - 1)), ConvertToStrSafe(rsItem("ten" + Ngonngu("", "e"))))
            xlsheet.Cells(11 + i, 6) = rsItem("psn")
            xlsheet.Cells(11 + i, 8) = rsItem("psnx")
            ''rs.MoveNext()
        Loop
        xlsheet.Range(String.Format("A{0}", 12 + i), String.Format("I{0}", 12 + i)).Font.Bold = True
        xlsheet.Cells(12 + i, 2) = Ngonngu("Tổng cộng", "Total")
        xlsheet.Cells(12 + i, 6) = kq1
        xlsheet.Cells(12 + i, 8) = kq2
        If i > 0 Then
            With xlsheet.Range("A9", String.Format("I{0}", 12 + i))
                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                .Borders.Weight = Excel.XlBorderWeight.xlThin
                Dim tempRefParam As Object = .Borders.Color
                tempRefParam = Color.FromArgb(0, 0, 0)
                Dim tempRefParam2 As Object = .RowHeight
                tempRefParam2 = 18
                Dim tempRefParam3 As Object = .VerticalAlignment
                tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
            End With
        End If
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\642.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub Baocao911(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim ps As Double
        Recycle(String.Format("{0}\temp\911.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\{1}REPORTS\911.XLS", pCurDir, Ngonngu("", "E")), String.Format("{0}\temp\911.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\911.XLS", pCurDir))
        On Error GoTo 0
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(5, 1) = ThoiGianTheoThang(tdau, tcuoi)
        InCdts(pThangDauKy, tcuoi, 0)
        ps = ConvertToDblSafe(GetSelectValue("SELECT Sum(CuoiKy) AS F1 FROM Cdts WHERE MaSo=100 OR MaSo=200"))
        If ps > 0 Then
            xlsheet.Cells(10, 4) = 100 * ConvertToDblSafe(GetSelectValue("SELECT Sum(CuoiKy) AS F1 FROM Cdts WHERE MaSo=200")) / ps
            xlsheet.Cells(10, 5) = (xlsheet.Cells(10, 4))
        End If
        InKqkd(tdau, tcuoi, 0)
        ps = SoPSTK("511", tdau, tcuoi, 1)
        ps = ps + ConvertToDblSafe(GetSelectValue("SELECT Sum(KyNay) AS F1 FROM Kqkd WHERE MaSo=21")) + ConvertToDblSafe(GetSelectValue("SELECT Sum(KyNay) AS F1 FROM Kqkd WHERE MaSo=31"))
        If ps <> 0 Then xlsheet.Cells(13, 4) = 100 * ConvertToDblSafe(GetSelectValue("SELECT Sum(KyNay) AS F1 FROM Kqkd WHERE MaSo=50")) / ps
        InKqkd(pThangDauKy, tcuoi, 0)
        ps = SoPSTK("511", pThangDauKy, tcuoi, 1)
        ps = ps + ConvertToDblSafe(GetSelectValue("SELECT Sum(KyNay) AS F1 FROM Kqkd WHERE MaSo=21")) + ConvertToDblSafe(GetSelectValue("SELECT Sum(KyNay) AS F1 FROM Kqkd WHERE MaSo=31"))
        If ps <> 0 Then xlsheet.Cells(13, 5) = 100 * ConvertToDblSafe(GetSelectValue("SELECT Sum(KyNay) AS F1 FROM Kqkd WHERE MaSo=50")) / ps
        ps = ConvertToDblSafe(GetSelectValue("SELECT Sum(CuoiKy) AS F1 FROM Cdts WHERE MaSo=300"))
        If ps > 0 Then xlsheet.Cells(19, 4) = ConvertToDblSafe(GetSelectValue("SELECT Sum(CuoiKy) AS F1 FROM Cdts WHERE MaSo=100 OR MaSo=200")) / ps
        ps = ConvertToDblSafe(GetSelectValue("SELECT Sum(CuoiKy) AS F1 FROM Cdts WHERE MaSo=310"))
        If ps > 0 Then xlsheet.Cells(22, 4) = ConvertToDblSafe(GetSelectValue("SELECT Sum(CuoiKy) AS F1 FROM Cdts WHERE MaSo=110 OR MaSo=120")) / ps
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\911.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="xlsheet"></param>
    ''' <param name="shtk"></param>
    ''' <param name="captk"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="tt_col"></param>
    ''' <param name="ten_col"></param>
    ''' <param name="sd_col"></param>
    ''' <param name="gc_col"></param>
    ''' <param name="fix_row"></param>
    ''' <param name="fix_col"></param>
    ''' <param name="n"></param>
    ''' <remarks></remarks>
    Private Sub SheetSoDu(ByRef xlsheet As Excel.Worksheet, ByRef shtk As String, ByRef captk As Integer, ByRef tcuoi As Integer, ByRef tt_col As Integer, ByRef ten_col As Integer, ByRef sd_col As Integer, ByRef gc_col As Integer, ByRef fix_row As Integer, ByRef fix_col As Integer, ByRef n As Date)
        Dim j, i, k As Integer
        Dim T As Double
        Dim rs, rs2 As DataTable
        Dim mpl As Integer
        Dim id As Integer = GetTK_ID(shtk, 0, k)
        If id <> TKCNKH_ID And id <> TKCNPT_ID Then
            rs = ExecSQLReturnDT(String.Format("SELECT MaSo, SoHieu, Cap, Ten, TKCon, TK_ID, GhiChu, (DuNo_{0}-DuCo_{1}) AS SoDu FROM HethongTK WHERE SoHieu LIKE '{2}%' AND Cap>={3} ORDER BY SoHieu", _
                                     CThangDB2(tcuoi), _
                                     ConvertToStrSafe(CThangDB2(tcuoi)), _
                                     shtk, _
                                     ConvertToStrSafe(captk)))
            Dim rsIndex As Integer = 0
            Do While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                i += 1
                If rsItem("cap") = captk Then
                    j += 1
                    xlsheet.Cells(fix_row + i, 1) = ConvertToStrSafe(j)
                    xlsheet.Range(String.Format("A{0}", fix_row + i), String.Format("G{0}", fix_row + i)).Font.Bold = True
                    T += IIf(k <= 0, rsItem("sodu"), -rsItem("sodu"))
                End If
                If ten_col > 0 Then
                    xlsheet.Cells(fix_row + i, ten_col) = String.Format("{0}{1}", Space(2 * (ConvertToDblSafe(rsItem("cap")) - 1)), ConvertToStrSafe(rsItem("ten")))
                    If gc_col > 0 Then xlsheet.Cells(fix_row + i, gc_col) = rsItem("GhiChu")
                    If sd_col > 0 Then
                        xlsheet.Cells(fix_row + i, sd_col) = IIf(k <= 0, rsItem("sodu"), (-rsItem("sodu")))
                    End If
                    If (rsItem("tk_id") = TKCNKH_ID Or rsItem("tk_id") = TKCNPT_ID) And rsItem("tkcon") = 0 Then
                        rs2 = ExecSQLReturnDT(String.Format("SELECT SoHieu, Ten, (DuNo_{0}-DuCo_{1}) AS SoDu FROM KhachHang INNER JOIN SoDuKhachHang ON KhachHang.MaSo=SoDuKhachHang.MaKhachHang WHERE MaTaiKhoan={2} AND (DuNo_{1}-DuCo_{1})<>0 ORDER BY SoHieu", CThangDB2(tcuoi), ConvertToStrSafe(CThangDB2(tcuoi)), rsItem("MaSo")))
                        Dim rs2Index As Integer = 0
                        Do While rs2Index < rs2.Rows.Count
                            Dim rs2Item As DataRow = rs2.Rows(rs2Index)
                            rs2Index += 1 ' C15 Rs LOOP CONTROL
                            i += 1
                            If ten_col > 0 Then
                                xlsheet.Cells(fix_row + i, ten_col) = String.Format("{0}{1}", ConvertToStrSafe(2 * (rsItem("cap") - 1)), rs2("ten"))
                                If sd_col > 0 Then
                                    xlsheet.Cells(fix_row + i, sd_col) = IIf(k <= 0, rs2("sodu"), -rsItem("sodu"))
                                End If
                            End If
                            'rs2.MoveNext()
                        Loop
                        'rs2.Close()
                    End If
                End If
                ''rs.MoveNext()
            Loop
            xlsheet.Cells(fix_row + 1 + i, sd_col) = T
        Else
            rs = ExecSQLReturnDT(String.Format("SELECT DISTINCT MaPhanLoai, PhanLoaiKhachHang.TenPhanLoai, KhachHang.SoHieu, KhachHang.Ten, SoDuKhachHang.DuNo_{0}-SoDuKhachHang.DuCo_{1} AS SoDu,KhachHang.GhiChu FROM ((SoDuKhachHang INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo) INNER JOIN KhachHang ON SoDuKhachHang.MaKhachHang=KhachHang.MaSo) INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo WHERE HethongTK.SoHieu LIKE '{2}%' ORDER BY PhanLoaiKhachHang.SoHieu,KhachHang.SoHieu", _
                                     CThangDB2(tcuoi), _
                                     ConvertToStrSafe(CThangDB2(tcuoi)), _
                                     shtk))
            Dim rsIndex As Integer = 0
            Do While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                i += 1
                If mpl = rsItem("MaPhanLoai") Then
                    j += 1
                    If tt_col > 0 Then xlsheet.Cells(fix_row + i, tt_col) = ConvertToStrSafe(j)
                    If ten_col > 0 Then xlsheet.Cells(fix_row + i, ten_col) = rsItem("ten")
                    If gc_col > 0 Then xlsheet.Cells(fix_row + i, gc_col) = rsItem("GhiChu")
                    If sd_col > 0 Then
                        xlsheet.Cells(fix_row + i, sd_col) = IIf(k <= 0, rsItem("sodu"), (-rsItem("sodu")))
                    End If
                    ''rs.MoveNext()
                Else
                    mpl = rsItem("MaPhanLoai")
                    xlsheet.Cells(fix_row + i, 2) = rsItem("TenPhanLoai")
                    xlsheet.Range("B" & fix_row + i).Font.Bold = True
                End If
            Loop
            If i > 0 Then xlsheet.Range(String.Format("{0}{1}", _
                                            XLSCol(sd_col), _
                                            ConvertToStrSafe(fix_row + 1 + i))).Formula = String.Format("=SUM({0}{1}:{0}{2})", _
                                                                                              XLSCol(sd_col), _
                                                                                              ConvertToStrSafe(fix_row + 1), _
                                                                                              ConvertToStrSafe(fix_row + i)) 'Excel Fomular
        End If
        If i > 0 Then
            xlsheet.Cells(fix_row + 1 + i, 2) = "Tổng cộng"
            xlsheet.Range(String.Format("A{0}", fix_row + 1 + i), String.Format("{0}{1}", XLSCol(fix_col), ConvertToStrSafe(fix_row + 1 + i))).Font.Bold = True
            With xlsheet.Range(String.Format("A{0}", fix_row + 1), String.Format("{0}{1}", XLSCol(fix_col), ConvertToStrSafe(fix_row + 1 + i)))
                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                .Borders.Weight = Excel.XlBorderWeight.xlThin
                Dim tempRefParam As Object = .Borders.Color
                tempRefParam = Color.FromArgb(0, 0, 0)
                Dim tempRefParam2 As Object = .RowHeight
                tempRefParam2 = 18
                Dim tempRefParam3 As Object = .VerticalAlignment
                tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
            End With
        End If
        XLSFooter(xlsheet, fix_row + 2 + i, fix_col, n)
        ''rs.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="xlsheet"></param>
    ''' <param name="shtk"></param>
    ''' <param name="captk"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="tt_col"></param>
    ''' <param name="ten_col"></param>
    ''' <param name="sd_col"></param>
    ''' <param name="gc_col"></param>
    ''' <param name="fix_row"></param>
    ''' <param name="fix_col"></param>
    ''' <param name="n"></param>
    ''' <remarks></remarks>
    Private Sub SheetSoDu2(ByRef xlsheet As Excel.Worksheet, ByRef shtk As String, ByRef captk As Integer, ByRef tcuoi As Integer, ByRef tt_col As Integer, ByRef ten_col As Integer, ByRef sd_col As Integer, ByRef gc_col As Integer, ByRef fix_row As Integer, ByRef fix_col As Integer, ByRef n As Date)
        Dim k, i, j, K1 As Integer
        Dim T As Double
        Dim mpl As Integer
        Dim id As Integer = GetTK_ID(shtk, 0, K1)
        Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT DISTINCT MaKhachHang, KhachHang.SoHieu, KhachHang.Ten, HethongTK.Ten AS TenTK, (SoDuKhachHang.DuNo_{0}-SoDuKhachHang.DuCo_{1}) AS SoDu FROM (SoDuKhachHang INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo) INNER JOIN KhachHang ON SoDuKhachHang.MaKhachHang=KhachHang.MaSo WHERE HethongTK.SoHieu LIKE '{2}%' ORDER BY KhachHang.SoHieu,HethongTK.SoHieu", _
                                                  CThangDB2(tcuoi), _
                                                  ConvertToStrSafe(CThangDB2(tcuoi)), _
                                                  shtk))
        Dim rsIndex As Integer = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            i += 1
            If mpl = rsItem("MaKhachHang") Then
                j += 1
                If tt_col > 0 Then xlsheet.Cells(fix_row + i, tt_col) = ConvertToStrSafe(j)
                If ten_col > 0 Then xlsheet.Cells(fix_row + i, ten_col) = rsItem("tentk")
                If sd_col > 0 Then
                    xlsheet.Cells(fix_row + i, sd_col) = IIf(K1 <= 0, rsItem("sodu"), (-rsItem("sodu")))
                End If
                T += (IIf(K1 <= 0, rsItem("sodu"), -rsItem("sodu")))
                ''rs.MoveNext()
            Else
                If k > 0 Then
                    xlsheet.Range(String.Format("{0}{1}", XLSCol(sd_col), ConvertToStrSafe(k))).Formula = String.Format("=SUM({0}{1}:{0}{2})", XLSCol(sd_col), ConvertToStrSafe(k + 1), ConvertToStrSafe(fix_row + i - 1)) 'Excel Fomular
                    xlsheet.Range(String.Format("{0}{1}", XLSCol(sd_col), ConvertToStrSafe(k))).Font.Bold = True
                End If
                k = fix_row + i
                j = 0
                mpl = rsItem("MaKhachHang")
                xlsheet.Cells(fix_row + i, 2) = rsItem("ten")
                xlsheet.Range(String.Format("B{0}", fix_row + i)).Font.Bold = True
            End If
        Loop
        i += 1
        j = 0
        rs = ExecSQLReturnDT(String.Format("SELECT MaSo, SoHieu, Cap, Ten, TKCon, TK_ID, GhiChu, (DuNo_{0}-DuCo_{1}) AS SoDu FROM HethongTK WHERE SoHieu LIKE '{2}%' AND Cap>={3} AND (TK_ID<>{4} AND TK_ID<>{5}) ORDER BY SoHieu", _
                                 CThangDB2(tcuoi), _
                                 ConvertToStrSafe(CThangDB2(tcuoi)), _
                                 shtk, _
                                 ConvertToStrSafe(captk), _
                                 ConvertToStrSafe(TKCNKH_ID), _
                                 ConvertToStrSafe(TKCNPT_ID)))
        rsIndex = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            i += 1
            If rsItem("cap") = captk Then
                j += 1
                xlsheet.Cells(fix_row + i, 1) = ConvertToStrSafe(j)
                xlsheet.Range(String.Format("A{0}", fix_row + i), String.Format("G{0}", fix_row + i)).Font.Bold = True
                T += (IIf(K1 <= 0, rsItem("sodu"), -rsItem("sodu")))
            End If
            If ten_col > 0 Then
                xlsheet.Cells(fix_row + i, ten_col) = String.Format("{0}{1}", _
                                                          Space(2 * (ConvertToDblSafe(rsItem("cap")) - 1)), _
                                                          ConvertToStrSafe(rsItem("ten")))
                If gc_col > 0 Then xlsheet.Cells(fix_row + i, gc_col) = rsItem("GhiChu")
                If sd_col > 0 Then
                    xlsheet.Cells(fix_row + i, sd_col) = IIf(K1 <= 0, rsItem("sodu"), (-rsItem("sodu")))
                End If
            End If
            ''rs.MoveNext()
        Loop
        If i > 0 Then
            xlsheet.Cells(fix_row + 1 + i, sd_col) = T
            xlsheet.Cells(fix_row + 1 + i, 2) = "Tổng cộng"
            xlsheet.Range(String.Format("A{0}", fix_row + 1 + i), String.Format("{0}{1}", XLSCol(fix_col), ConvertToStrSafe(fix_row + 1 + i))).Font.Bold = True
            With xlsheet.Range(String.Format("A{0}", fix_row + 1), String.Format("{0}{1}", XLSCol(fix_col), ConvertToStrSafe(fix_row + 1 + i)))
                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                .Borders.Weight = Excel.XlBorderWeight.xlThin
                Dim tempRefParam As Object = .Borders.Color
                tempRefParam = Color.FromArgb(0, 0, 0)
                Dim tempRefParam2 As Object = .RowHeight
                tempRefParam2 = 18
                Dim tempRefParam3 As Object = .VerticalAlignment
                tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
            End With
        End If
        XLSFooter(xlsheet, fix_row + 2 + i, fix_col, n)
        ''rs.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ctk"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <remarks></remarks>
    Private Sub SoCPDauTuXD(ByRef ctk As ClsTaikhoan, ByRef ndau As Date, ByRef ncuoi As Date)
        Dim rs As DataTable
        Dim sql As String = String.Empty
        Dim i As Integer
        Dim psnt1, psn, psc, psnt2 As Double
        Dim j As Integer
        Recycle(String.Format("{0}\temp\CTPS3.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}REPORTS\CTPS3.XLS", pCurDir), String.Format("{0}\temp\CTPS3.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\CTPS3.XLS", pCurDir))
        xlsheet = xlapp.Worksheets(1)
        On Error GoTo 0
        xlsheet.Cells(1, 1) = pTenCty
        xlsheet.Cells(2, 1) = pTenCn
        xlsheet.Cells(4, 1) = String.Format("Từ ngày {0} đến ngày {1}", Format(ndau, Mask_DB), Format(ncuoi, Mask_DB))
        xlsheet.Cells(5, 1) = String.Format("Dự án: {0}", ctk.TenDA)
        xlsheet.Cells(6, 1) = String.Format("Công trình: {0}", ctk.ten)
        xlsheet.Cells(7, 1) = String.Format("Ngày khởi công: {0} - Ngày hoàn thành: {1}", Format(ctk.NgayKC, Mask_DB), Format(ctk.NgayHT, Mask_DB))
        xlsheet.Cells(8, 1) = String.Format("Dự toán: {0}", Format(ctk.DuToan, Mask_0))
        ctk.SoDuNgay(ndau.AddDays(-1), psn, psc, psnt1)
        xlsheet.Cells(13, 6) = psn
        GauGe.Value = 1
        sql = "SELECT DISTINCT NgayGS,NgayCT,HethongTK.SoHieu AS SHN,TK.SoHieu AS SHC, ChungTu.SoHieu,DienGiai,SoPS FROM (ChungTu INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) INNER JOIN HethongTK AS TK ON ChungTu.MaTKTCCo=TK.MaSo" & " WHERE (HethongTK.SoHieu LIKE '" & taikhoan.sohieu & "%') AND " & WNgay("NgayGS", ndau, ncuoi) & " AND SoPS<>0 ORDER BY NgayGS"
        rs = ExecSQLReturnDT(sql)
        j = 0
        Dim rsIndex As Integer = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            j += 1
            xlsheet.Cells(13 + j, 1) = Format(rsItem("NgayGS"), Mask_D)
            xlsheet.Cells(13 + j, 2) = rsItem("SoHieu")
            xlsheet.Cells(13 + j, 3) = Format(rsItem("NgayCT"), Mask_D)
            xlsheet.Cells(13 + j, 4) = rsItem("DienGiai")
            xlsheet.Cells(13 + j, 5) = rsItem("shc")
            xlsheet.Cells(13 + j, 6) = rsItem("sops")
            sql = ctk.ShCapDuoi(rsItem("SHN"))
            If sql <> "" Then sql = Strings.Right(sql, 1)
            Dim dbNumericTemp As Double
            If IsNumeric(sql) Then
                i = ConvertToDblSafe(sql)
                Select Case i
                    Case 1, 2
                        xlsheet.Cells(13 + j, 6 + i) = rsItem("sops")
                    Case 3
                        xlsheet.Cells(13 + j, 12) = rsItem("sops")
                End Select
            End If
            ''rs.MoveNext()
        Loop
        ''rs.Close()
        rs = Nothing
        GauGe.Value = 2
        If j > 0 Then
            For i = 6 To 12
                xlsheet.Range(String.Format("{0}{1}", XLSCol(i), ConvertToStrSafe(14 + j))).Formula = String.Format("=SUM({0}14:{0}{1})", XLSCol(i), ConvertToStrSafe(13 + j)) 'Excel Fomular
            Next
        End If
        xlsheet.Cells(14 + j, 4) = "Cộng phát sinh trong kỳ"
        xlsheet.Cells(15 + j, 4) = "Luỹ kế phát sinh từ đầu năm"
        xlsheet.Cells(16 + j, 4) = "Luỹ kế phát sinh từ khởi công"
        ctk.SoPhatSinhN(NgayDauThang(ncuoi.Year, pThangDauKy), ncuoi, psn, psnt1, psc, psnt2)
        xlsheet.Cells(15 + j, 6) = psn
        xlsheet.Cells(16 + j, 6) = ctk.PSTuKhoiCong(ncuoi, -1)
        With xlsheet.Range("A10", String.Format("M{0}", 16 + j))
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders.Weight = Excel.XlBorderWeight.xlThin
            Dim tempRefParam As Object = .Borders.Color
            tempRefParam = Color.FromArgb(0, 0, 0)
            Dim tempRefParam2 As Object = .RowHeight
            tempRefParam2 = 18
            .Font.Size = 8
            Dim tempRefParam3 As Object = .VerticalAlignment
            tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
        End With
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\CTPS3.XLS")
KetThuc:
        ctk = Nothing
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="taikhoan"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <remarks></remarks>
    Private Sub SoCTNguonVonDT(ByRef taikhoan As ClsTaikhoan, ByRef ndau As Date, ByRef ncuoi As Date)
        InSocaiTk(taikhoan, 0, 0, ndau, ncuoi, False, "", 0, 0)
        ExecSQLNonQuery(QChitiet)
        ExecSQLNonQuery(Qsocai)

        rptFrom.InitForm("VONDT.RPT", Qsocai, "Qsocai")
        GauGe.Value = 1
        rptFrom.SetFormulas("LKN", taikhoan.PSTuKhoiCong(ncuoi, -1))
        rptFrom.SetFormulas("LKC", taikhoan.PSTuKhoiCong(ncuoi, 1))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="taikhoan"></param>
    ''' <param name="shtk"></param>
    ''' <param name="cap"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function KiemTraTK(ByRef taikhoan As ClsTaikhoan, Optional ByRef shtk As String = "241", Optional ByRef cap As Integer = 0) As Boolean
        If taikhoan.sohieu.Substring(0, shtk.Length) <> shtk Then
            txtShTk(0).Focus()
            Return False
        Else
            Return IIf(cap > 0, taikhoan.cap = cap, True)
        End If
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="taikhoan"></param>
    ''' <remarks></remarks>
    Private Sub THQuyetToan(ByRef taikhoan As ClsTaikhoan)
        Dim TK As New ClsTaikhoan
        Recycle(String.Format("{0}\temp\THQTDT.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}REPORTS\THQTDT.XLS", pCurDir), String.Format("{0}\temp\THQTDT.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\THQTDT.XLS", pCurDir))
        xlsheet = xlapp.Worksheets(1)
        On Error GoTo 0
        xlsheet.Cells(4, 4) = taikhoan.TenDA
        xlsheet.Cells(5, 4) = taikhoan.ten
        xlsheet.Cells(6, 4) = pTenCty
        xlsheet.Cells(9, 4) = taikhoan.DiaDiem
        xlsheet.Cells(11, 4) = taikhoan.DuToan
        xlsheet.Cells(12, 4) = taikhoan.NgayKC
        xlsheet.Cells(13, 4) = taikhoan.NgayHT
        xlsheet.Cells(24, 3) = taikhoan.Von1
        xlsheet.Cells(25, 3) = taikhoan.Von2
        xlsheet.Cells(28, 3) = taikhoan.Von3
        GauGe.Value = 1
        For i As Integer = 1 To 4
            TK.InitTaikhoanSohieuCT(taikhoan.sohieu, ConvertToStrSafe(i), taikhoan.cap + 1)
            If TK.maso > 0 Then
                xlsheet.Cells(35 + i, 4) = TK.DuToan
                xlsheet.Cells(35 + i, 5) = TK.PSTuKhoiCong(NgayCuoiNam(), -1)
            End If
        Next
        For i As Integer = 1 To 4
            TK.InitTaikhoanSohieuCT(taikhoan.sohieu, ConvertToStrSafe(i), taikhoan.cap + 1)
            If TK.maso > 0 Then
                xlsheet.Cells(46 + i, 3) = TK.PSTuKhoiCong(NgayCuoiNam(), -1)
            End If
        Next
        GauGe.Value = 2
        xlsheet.Cells(65, 3) = taikhoan.PSTuKhoiCong(NgayCuoiNam(), -1)
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\THQTDT.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="taikhoan"></param>
    ''' <remarks></remarks>
    Private Sub ThucHienDauTu(ByRef taikhoan As ClsTaikhoan)
        Dim TK As New ClsTaikhoan
        Dim j, i, namdau As Integer
        Dim psn, psc As Double
        Recycle(String.Format("{0}\temp\THDT.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}REPORTS\THDT.XLS", pCurDir), String.Format("{0}\temp\THDT.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\THDT.XLS", pCurDir))
        xlsheet = xlapp.Worksheets(1)
        On Error GoTo 0
        xlsheet.Cells(4, 4) = taikhoan.TenDA
        xlsheet.Cells(5, 4) = taikhoan.ten
        xlsheet.Cells(6, 4) = pTenCty
        xlsheet.Cells(9, 4) = taikhoan.DiaDiem
        xlsheet.Cells(11, 4) = taikhoan.DuToan
        xlsheet.Cells(12, 4) = taikhoan.NgayKC
        xlsheet.Cells(13, 4) = taikhoan.NgayHT
        i = pNamTC - 1
        Do While TruongDaCo("HethongTK", String.Format("PSNLK{0}", i))
            namdau = i
            i -= 1
        Loop
        GauGe.Value = 1
        If namdau = 0 Then namdau = pNamTC
        If namdau > 0 Then
            For i = namdau To pNamTC - 1
                j += 1
                xlsheet.Cells(17 + j, 1) = j
                xlsheet.Cells(17 + j, 2) = i
                xlsheet.Cells(17 + j, 4) = taikhoan.PSLKNam(i, -1)
                For k As Integer = 1 To 3
                    TK.InitTaikhoanSohieuCT(taikhoan.sohieu, ConvertToStrSafe(k), taikhoan.cap + 1)
                    If TK.maso > 0 Then xlsheet.Cells(17 + j, 4 + k) = taikhoan.PSLKNam(i, -1)
                Next
            Next
            If namdau = pNamTC Then
                j += 1
                xlsheet.Cells(17 + j, 1) = j
                xlsheet.Cells(17 + j, 2) = String.Format("Trước {0}", pNamTC)
                xlsheet.Cells(17 + j, 4) = taikhoan.PSNLK
                For k As Integer = 1 To 3
                    TK.InitTaikhoanSohieuCT(taikhoan.sohieu, ConvertToStrSafe(k), taikhoan.cap + 1)
                    If TK.maso > 0 Then
                        xlsheet.Cells(17 + j, 4 + k) = TK.PSNLK
                    End If
                Next
            End If
            j += 1
            xlsheet.Cells(17 + j, 1) = j
            xlsheet.Cells(17 + j, 2) = pNamTC
            taikhoan.SoPhatSinh(0, 0, psn, psc)
            xlsheet.Cells(17 + j, 4) = psn
            For k As Integer = 1 To 3
                TK.InitTaikhoanSohieuCT(taikhoan.sohieu, ConvertToStrSafe(k), taikhoan.cap + 1)
                If TK.maso > 0 Then
                    TK.SoPhatSinh(0, 0, psn, psc)
                    xlsheet.Cells(17 + j, 4 + k) = psn
                End If
            Next
        End If
        GauGe.Value = 2
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\THDT.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="taikhoan"></param>
    ''' <remarks></remarks>
    Private Sub QuyetToanChiPhi(ByRef taikhoan As ClsTaikhoan)
        Dim TK As New ClsTaikhoan
        Dim i, cap As Integer
        Dim rs As DataTable
        Dim shtk As String = String.Empty
        Recycle(String.Format("{0}\temp\QTCP.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}REPORTS\QTCP.XLS", pCurDir), String.Format("{0}\temp\QTCP.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(pCurDir & "\temp\QTCP.XLS")
        xlsheet = xlapp.Worksheets(1)
        On Error GoTo 0
        xlsheet.Cells(4, 4) = taikhoan.TenDA
        xlsheet.Cells(5, 4) = taikhoan.ten
        xlsheet.Cells(6, 4) = pTenCty
        xlsheet.Cells(9, 4) = taikhoan.DiaDiem
        xlsheet.Cells(11, 4) = taikhoan.DuToan
        xlsheet.Cells(12, 4) = taikhoan.NgayKC
        xlsheet.Cells(13, 4) = taikhoan.NgayHT
        GauGe.Value = 1
        i += 1
        xlsheet.Cells(17 + i, 1) = taikhoan.ten
        xlsheet.Cells(17 + i, 2) = taikhoan.DuToan
        xlsheet.Cells(17 + i, 3) = taikhoan.PSTuKhoiCong(NgayCuoiNam(), -1)
        shtk = taikhoan.sohieu
        cap = taikhoan.cap + 1
        For k As Integer = 1 To 3
            TK.InitTaikhoanSohieuCT(shtk, ConvertToStrSafe(k), cap)
            If TK.maso > 0 Then
                xlsheet.Cells(17 + i, 3 + k) = TK.PSTuKhoiCong(NgayCuoiNam(), -1)
            End If
        Next
        rs = Nothing
        GauGe.Value = 2
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\QTCP.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="taikhoan"></param>
    ''' <remarks></remarks>
    Private Sub DuyetQuyetToan(ByRef taikhoan As ClsTaikhoan)
        Dim TK As New ClsTaikhoan
        Dim i As Integer
        Recycle(String.Format("{0}\temp\DuyetQT.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}REPORTS\DuyetQT.XLS", pCurDir), pCurDir & "\temp\DuyetQT.XLS")
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(pCurDir & "\temp\DuyetQT.XLS")
        xlsheet = xlapp.Worksheets(1)
        On Error GoTo 0
        xlsheet.Cells(7, 4) = taikhoan.TenDA
        xlsheet.Cells(8, 4) = taikhoan.ten
        xlsheet.Cells(9, 4) = pTenCty
        xlsheet.Cells(12, 4) = taikhoan.DiaDiem
        xlsheet.Cells(14, 4) = taikhoan.DuToan
        xlsheet.Cells(15, 4) = taikhoan.NgayKC
        xlsheet.Cells(16, 4) = taikhoan.NgayHT
        xlsheet.Cells(23, 2) = taikhoan.Von1
        xlsheet.Cells(25, 2) = taikhoan.Von2
        xlsheet.Cells(27, 2) = taikhoan.Von3
        xlsheet.Cells(52, 2) = taikhoan.Von1
        xlsheet.Cells(54, 2) = taikhoan.Von2
        xlsheet.Cells(56, 2) = taikhoan.Von3
        GauGe.Value = 1
        For k As Integer = 1 To 3
            TK.InitTaikhoanSohieuCT(taikhoan.sohieu, ConvertToStrSafe(k), taikhoan.cap + 1)
            If TK.maso > 0 Then
                xlsheet.Cells(32 + k, 2) = TK.DuToan
                xlsheet.Cells(32 + k, 3) = TK.PSTuKhoiCong(NgayCuoiNam(), -1)
            End If
        Next
        xlsheet.Cells(44, 2) = taikhoan.PSTuKhoiCong(NgayCuoiNam(), -1)
        xlsheet.Cells(59, 2) = SoDuTKSH(pSHPT, ThangCuoiNamTC(), -1)
        xlsheet.Cells(60, 2) = SoDuTKSH("331", ThangCuoiNamTC(), 1)
        GauGe.Value = 2
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\DuyetQT.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Public Sub NguonVonDauTu(ByRef tdau As Integer, ByRef tcuoi As Integer)
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
        QTongHopCT = (String.Format("SELECT DISTINCT SoHieu, (Cap) AS FirstOfCap, (Ten) AS FirstOfTen, (Kieu) AS FirstOfKieu, (Loai) AS FirstOfLoai, (MaTC = MaSo OR MaTC = 0) AS FirstOfChuanLa, (TKCon) AS FirstOfTKCon, (CapDuoi) AS CD, Sum(DuNo_{0}) AS DkNo, Sum(DuCo_{1}) AS DkCo, Sum({2}) AS PsNo, Sum({3}) AS PsCo, Sum({4}) AS PsNoX, Sum({5}) AS PsCoX, Sum(HeThongTK.DuNo_{6}) AS CkNo, Sum(HeThongTK.DuCo_{6}) AS CkCo, SUM(PSNLK+{4}) AS LKN, SUM(PSCLK+{5}) AS LKC FROM HeThongTK WHERE Cap>1 AND (SoHieu LIKE '341%' OR SoHieu LIKE '441%') GROUP BY SoHieu HAVING (Sum(DuNo_{6})<>0 OR Sum(DuCo_{6})<>0 OR Sum({2})<>0 OR Sum({3})<>0 OR Sum({4})<>0 OR Sum({5})<>0) ORDER BY SoHieu", _
                          CThangDB2(ThangTruoc(tdau)), _
                          ConvertToStrSafe(CThangDB2(ThangTruoc(tdau))), _
                          sqln, _
                          sqlc, _
                          sqlnx, _
                          sqlcx, _
                          st))
        GauGe.Value = 2
        XDCapTK("341")
        XDCapTK("441")
        rptFrom.InitForm("NVONDT.RPT", QTongHopCT, "QTongHopCT")
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="taikhoan"></param>
    ''' <remarks></remarks>
    Public Sub ThucHienDauTu2(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef taikhoan As ClsTaikhoan)
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
        QTongHopCT = (String.Format("SELECT DISTINCT SoHieu, (Cap) AS FirstOfCap, (Ten) AS FirstOfTen, (Kieu) AS FirstOfKieu, (Loai) AS FirstOfLoai, (MaTC = MaSo OR MaTC = 0) AS FirstOfChuanLa, (TKCon) AS FirstOfTKCon, (CapDuoi) AS CD, Sum(DuNo_{0}) AS DkNo, Sum(DuCo_{1}) AS DkCo, Sum({2}) AS PsNo, Sum({3}) AS PsCo, Sum({4}) AS PsNoX, Sum({5}) AS PsCoX, Sum(HeThongTK.DuNo_{6}) AS CkNo, Sum(HeThongTK.DuCo_{6}) AS CkCo, SUM(PSNLK+{4}) AS LKN, SUM(PSCLK+{5}) AS LKC FROM HeThongTK WHERE SoHieu LIKE '{7}%' AND Cap>{8} GROUP BY SoHieu HAVING (Sum(DuNo_{6})<>0 OR Sum(DuCo_{6})<>0 OR Sum({2})<>0 OR Sum({3})<>0 OR Sum({4})<>0 OR Sum({5})<>0) ORDER BY SoHieu", _
                          CThangDB2(ThangTruoc(tdau)), _
                          ConvertToStrSafe(CThangDB2(ThangTruoc(tdau))), _
                          sqln, _
                          sqlc, _
                          sqlnx, _
                          sqlcx, _
                          st, _
                          taikhoan.sohieu, _
                          ConvertToStrSafe(taikhoan.cap)))
        GauGe.Value = 2
        XDCapTK("2412")
        rptFrom.InitForm("THDAUTU.RPT", QTongHopCT, "QTongHopCT")
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        rptFrom.SetFormulas("DienGiai", String.Format("'{0}'", taikhoan.ten))
        rptFrom.SetFormulas("Cap", taikhoan.cap + 1)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub TMCDT(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim i As Integer
        Dim rs As DataTable
        Dim sqlx As New StringBuilder
        Dim sql As New StringBuilder
        Recycle(String.Format("{0}\temp\TMCDT.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}REPORTS\TMCDT.XLS", pCurDir), String.Format("{0}\temp\TMCDT.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(pCurDir & "\temp\TMCDT.XLS")
        xlsheet = xlapp.Worksheets(1)
        On Error GoTo 0
        xlsheet.Cells(1, 1) = pTenCty
        xlsheet.Cells(2, 1) = pTenCn
        xlsheet.Cells(4, 1) = ThoiGianTheoThang(tdau, tcuoi)
        sql = New StringBuilder("")
        sqlx = New StringBuilder("")
        For i = CThangDB2(tdau) To CThangDB2(tcuoi)
            sql.Append(String.Format("+Co_{0}", i))
        Next
        For i = 1 To CThangDB2(tcuoi)
            sqlx.Append(String.Format("+Co_{0}", i))
        Next
        i = 0
        rs = ExecSQLReturnDT(String.Format("SELECT Ten,Sum({0}) AS KN, Sum({1}) AS LK FROM HethongTK WHERE SoHieu LIKE '511%' AND TKCon=0 GROUP BY SoHieu, Ten HAVING Sum({1})<>0", _
                                 sql, _
                                 sqlx))
        Dim rsIndex As Integer = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            i += 1
            xlsheet.Cells(23 + i, 1) = rsItem("ten")
            xlsheet.Cells(23 + i, 2) = rsItem("kn")
            xlsheet.Cells(23 + i, 3) = rsItem("lk")
            ''rs.MoveNext()
        Loop
        sql = New StringBuilder("")
        sqlx = New StringBuilder("")
        For i = CThangDB2(tdau) To CThangDB2(tcuoi)
            sql.Append(String.Format("+No_{0}", i))
        Next
        For i = 1 To CThangDB2(tcuoi)
            sqlx.Append(String.Format("+No_{0}", i))
        Next
        i = 0
        rs = ExecSQLReturnDT(String.Format("SELECT Ten,Sum({0}) AS KN, Sum({1}) AS LK FROM HethongTK WHERE SoHieu LIKE '6%' AND TKCon=0 GROUP BY SoHieu, Ten HAVING Sum({1})<>0", _
                                 sql, _
                                 sqlx))
        rsIndex = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            i += 1
            xlsheet.Cells(34 + i, 1) = rsItem("ten")
            xlsheet.Cells(34 + i, 2) = rsItem("kn")
            xlsheet.Cells(34 + i, 3) = rsItem("lk")
            ''rs.MoveNext()
        Loop
        ''rs.Close()
        rs = Nothing
        xlsheet.Cells(74, 2) = SoDuTKSH("2112", ThangTruoc(tdau))
        xlsheet.Cells(74, 3) = SoDuTKSH("2113", ThangTruoc(tdau))
        xlsheet.Cells(74, 4) = SoDuTKSH("2114", ThangTruoc(tdau))
        xlsheet.Cells(74, 5) = SoDuTKSH("2115", ThangTruoc(tdau))
        xlsheet.Cells(74, 6) = SoDuTKSH("2116", ThangTruoc(tdau))
        xlsheet.Cells(74, 7) = SoDuTKSH("2118", ThangTruoc(tdau))
        xlsheet.Cells(75, 2) = SoPSTK("2112", tdau, tcuoi, -1)
        xlsheet.Cells(75, 3) = SoPSTK("2113", tdau, tcuoi, -1)
        xlsheet.Cells(75, 4) = SoPSTK("2114", tdau, tcuoi, -1)
        xlsheet.Cells(75, 5) = SoPSTK("2115", tdau, tcuoi, -1)
        xlsheet.Cells(75, 6) = SoPSTK("2116", tdau, tcuoi, -1)
        xlsheet.Cells(75, 7) = SoPSTK("2118", tdau, tcuoi, -1)
        xlsheet.Cells(76, 2) = SoPSTK("2112", tdau, tcuoi, 1)
        xlsheet.Cells(76, 3) = SoPSTK("2113", tdau, tcuoi, 1)
        xlsheet.Cells(76, 4) = SoPSTK("2114", tdau, tcuoi, 1)
        xlsheet.Cells(76, 5) = SoPSTK("2115", tdau, tcuoi, 1)
        xlsheet.Cells(76, 6) = SoPSTK("2116", tdau, tcuoi, 1)
        xlsheet.Cells(76, 7) = SoPSTK("2118", tdau, tcuoi, 1)
        xlsheet.Cells(79, 2) = GTHaoMon("2112", ThangTruoc(tdau))
        xlsheet.Cells(79, 3) = GTHaoMon("2113", ThangTruoc(tdau))
        xlsheet.Cells(79, 4) = GTHaoMon("2114", ThangTruoc(tdau))
        xlsheet.Cells(79, 5) = GTHaoMon("2115", ThangTruoc(tdau))
        xlsheet.Cells(79, 6) = GTHaoMon("2116", ThangTruoc(tdau))
        xlsheet.Cells(79, 7) = GTHaoMon("2118", ThangTruoc(tdau))
        xlsheet.Cells(80, 2) = SoKHTS("2112", tdau, tcuoi)
        xlsheet.Cells(80, 3) = SoKHTS("2113", tdau, tcuoi)
        xlsheet.Cells(80, 4) = SoKHTS("2114", tdau, tcuoi)
        xlsheet.Cells(80, 5) = SoKHTS("2115", tdau, tcuoi)
        xlsheet.Cells(80, 6) = SoKHTS("2116", tdau, tcuoi)
        xlsheet.Cells(80, 7) = SoKHTS("2118", tdau, tcuoi)
        xlsheet.Cells(82, 2) = GTHaoMon("2112", tcuoi)
        xlsheet.Cells(82, 3) = GTHaoMon("2113", tcuoi)
        xlsheet.Cells(82, 4) = GTHaoMon("2114", tcuoi)
        xlsheet.Cells(82, 5) = GTHaoMon("2115", tcuoi)
        xlsheet.Cells(82, 6) = GTHaoMon("2116", tcuoi)
        xlsheet.Cells(82, 7) = GTHaoMon("2118", tcuoi)
        GauGe.Value = 2
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\TMCDT.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="taikhoan"></param>
    ''' <remarks></remarks>
    Private Sub ThucHienDauTu3(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef taikhoan As ClsTaikhoan)
        Dim i, k As Integer
        Dim shct As String = String.Empty
        Dim rs As DataTable
        Dim sqlx As New StringBuilder
        Dim sql As New StringBuilder
        Dim s As Array = Array.CreateInstance(GetType(Double), New Integer() {14}, New Integer() {2})
        Recycle(String.Format("{0}\temp\THDTCT.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}REPORTS\THDTCT.XLS", pCurDir), String.Format("{0}\temp\THDTCT.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\THDTCT.XLS", pCurDir))
        xlsheet = xlapp.Worksheets(1)
        On Error GoTo 0
        xlsheet.Cells(1, 1) = pTenCty
        xlsheet.Cells(2, 1) = pTenCn
        xlsheet.Cells(4, 1) = ThoiGianTheoThang(tdau, tcuoi)
        For i = CThangDB2(tdau) To CThangDB2(tcuoi)
            sql.Append(String.Format("+No_{0}", i))
        Next
        For i = 1 To CThangDB2(tcuoi)
            sqlx.Append(String.Format("+No_{0}", i))
        Next
        i = 0
        rs = ExecSQLReturnDT(String.Format("SELECT Sohieu,Cap,Ten,DuToan,({0}) AS KN, ({1}) AS LK,(PSNLK+{1}) AS LK2 FROM HethongTK WHERE SoHieu LIKE '{2}%' AND Cap>{3} AND (PSNLK+{1}<>0 OR DuToan<>0) ORDER BY SoHieu", sql, sqlx, taikhoan.sohieu, ConvertToStrSafe(taikhoan.cap))) 'AND (Cap=3 OR Cap=5 OR Cap=7 OR Cap=9)
        Dim rsIndex As Integer = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            i += 1
            xlsheet.Cells(9 + i, 1) = ConvertToDblSafe(New String(" "c, 2 * (rsItem("cap") - taikhoan.cap))) + rsItem("ten")
            xlsheet.Cells(9 + i, 2) = rsItem("DuToan")
            shct = taikhoan.ShCapDuoi(rsItem("SoHieu"))
            If shct <> "" Then shct = Strings.Right(shct, 1)
            Dim dbNumericTemp As Double
            If IsNumeric(shct) Then
                k = ConvertToDblSafe(shct)
                xlsheet.Cells(9 + i, 3 + k) = rsItem("kn")
                xlsheet.Cells(9 + i, 7 + k) = rsItem("lk")
                xlsheet.Cells(9 + i, 11 + k) = rsItem("lk2")
                If rsItem("cap") = taikhoan.cap + 1 Then
                    s.SetValue(s.GetValue(2) + rsItem("DuToan"), 2)
                    s.SetValue(s.GetValue(3 + k) + rsItem("kn"), 3 + k)
                    s.SetValue(s.GetValue(7 + k) + rsItem("lk"), 7 + k)
                    s.SetValue(s.GetValue(11 + k) + rsItem("lk2"), 11 + k)
                    s.SetValue(s.GetValue(4) + s.GetValue(5) + s.GetValue(6), 7)
                    s.SetValue(s.GetValue(8) + s.GetValue(9) + s.GetValue(10), 11)
                    s.SetValue(s.GetValue(12) + s.GetValue(13) + s.GetValue(14), 15)
                End If
            End If
            xlsheet.Range(String.Format("G{0}", 9 + i)).Formula = String.Format("=SUM(D{0}:F{1})", 9 + i, ConvertToStrSafe(9 + i)) 'Excel Fomular
            xlsheet.Range(String.Format("K{0}", 9 + i)).Formula = String.Format("=SUM(H{0}:J{1})", 9 + i, ConvertToStrSafe(9 + i)) 'Excel Fomular
            xlsheet.Range(String.Format("O{0}", 9 + i)).Formula = String.Format("=SUM(L{0}:N{1})", 9 + i, ConvertToStrSafe(9 + i)) 'Excel Fomular
            ''rs.MoveNext()
        Loop
        ''rs.Close()
        rs = Nothing
        xlsheet.Cells(10 + i, 1) = ("Tổng cộng")
        If i > 0 Then
            For k = 2 To 15
                xlsheet.Cells(10 + i, k) = s.GetValue(k)
            Next
        End If
        GauGe.Value = 2
        With xlsheet.Range("A8", String.Format("O{0}", 10 + i))
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders.Weight = Excel.XlBorderWeight.xlThin
            Dim tempRefParam As Object = .Borders.Color
            tempRefParam = Color.FromArgb(0, 0, 0)
            Dim tempRefParam2 As Object = .RowHeight
            tempRefParam2 = 18
            .Font.Size = 8
            Dim tempRefParam3 As Object = .VerticalAlignment
            tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
        End With
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\THDTCT.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="taikhoan"></param>
    ''' <remarks></remarks>
    Public Sub InChiPhiDT(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef taikhoan As ClsTaikhoan)
        Dim st As String = String.Empty
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        Dim sqlcx As New StringBuilder
        Dim sqlnx As New StringBuilder
        Dim TK As New ClsTaikhoan
        TK.InitTaikhoanSohieuCT(taikhoan.sohieu, "3", taikhoan.cap + 1)
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
        QTongHopCT = (String.Format("SELECT DISTINCT SoHieu, (Cap) AS FirstOfCap, (Ten) AS FirstOfTen, (Kieu) AS FirstOfKieu, (Loai) AS FirstOfLoai, (MaTC = MaSo OR MaTC = 0) AS FirstOfChuanLa, (TKCon) AS FirstOfTKCon, (CapDuoi) AS CD, Sum(DuNo_{0}) AS DkNo, Sum(DuCo_{1}) AS DkCo, Sum({2}) AS PsNo, Sum({3}) AS PsCo, Sum({4}) AS PsNoX, Sum({5}) AS PsCoX, Sum(HeThongTK.DuNo_{6}) AS CkNo, Sum(HeThongTK.DuCo_{6}) AS CkCo, SUM(PSNLK+{4}) AS LKN, SUM(PSCLK+{5}) AS LKC FROM HeThongTK WHERE SoHieu LIKE '{7}%' AND Cap>{8} GROUP BY SoHieu HAVING (Sum(DuNo_{6})<>0 OR Sum(DuCo_{6})<>0 OR Sum({2})<>0 OR Sum({3})<>0 OR Sum({4})<>0 OR Sum({5})<>0) ORDER BY SoHieu", _
                          CThangDB2(ThangTruoc(tdau)), _
                          ConvertToStrSafe(CThangDB2(ThangTruoc(tdau))), _
                          sqln, _
                          sqlc, _
                          sqlnx, _
                          sqlcx, _
                          st, _
                          TK.sohieu, _
                          ConvertToStrSafe(TK.cap)))
        GauGe.Value = 2
        XDCapTK(TK.sohieu)
        rptFrom.InitForm("CPK_CDT.RPT", QTongHopCT, "QTongHopCT")
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        rptFrom.SetFormulas("DienGiai", String.Format("'{0}'", taikhoan.ten))
        rptFrom.SetFormulas("Cap", TK.cap + 1)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="taikhoan"></param>
    ''' <remarks></remarks>
    Private Sub TSBanGiao(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef taikhoan As ClsTaikhoan)
        Recycle(String.Format("{0}\temp\THDTCT.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}REPORTS\TSCD_LD.XLS", pCurDir), pCurDir & "\temp\THDTCT.XLS")
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\THDTCT.XLS", pCurDir))
        xlsheet = xlapp.Worksheets(1)
        On Error GoTo 0
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\TSCD_LD.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="taikhoan"></param>
    ''' <remarks></remarks>
    Private Sub CongNo_Von(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef taikhoan As ClsTaikhoan)
        Recycle(String.Format("{0}\temp\CN_DA.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}REPORTS\CN_DA.XLS", pCurDir), String.Format("{0}\temp\CN_DA.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\CN_DA.XLS", pCurDir))
        xlsheet = xlapp.Worksheets(2)
        xlsheet.Cells(4, 4) = taikhoan.TenDA
        xlsheet.Cells(6, 4) = pTenCty
        On Error GoTo 0
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\CN_DA.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="taikhoan"></param>
    ''' <remarks></remarks>
    Private Sub QTDauTu(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef taikhoan As ClsTaikhoan)
        Recycle(String.Format("{0}\temp\QTDT.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}REPORTS\QTDT.XLS", pCurDir), String.Format("{0}\temp\QTDT.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(pCurDir & "\temp\QTDT.XLS")
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(4, 4) = taikhoan.TenDA
        On Error GoTo 0
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\QTDT.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="mvt"></param>
    ''' <param name="shtk"></param>
    ''' <remarks></remarks>
    Private Sub InCTDoanhThuCDT(ByRef ndau As Date, ByRef ncuoi As Date, ByRef mvt As Integer, Optional ByRef shtk As String = "")
        Dim st = String.Empty
        Dim dv As String = String.Empty
        Dim sql As String = String.Format("SELECT DISTINCT ChungTu.MaCT,ChungTu.SoHieu, NgayCT, NgayGS, ChungTu.DienGiai, ChungTu.SoPS, ChungTu.SoPS2Co, HethongTK.SoHieu AS TKDU  FROM (ChungTu INNER JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo) LEFT JOIN HethongTK ON ChungTu.MaTKNo = HethongTK.MaSo WHERE {0} AND TK.TK_ID={1} AND MaVattu={2}{3}", _
                                WNgay("NgayGS", ndau, ncuoi), _
                                ConvertToStrSafe(TKDT_ID), _
                                ConvertToStrSafe(mvt), _
                                (IIf(shtk <> "", String.Format(" AND TK.SoHieu LIKE '{0}%'", shtk), String.Empty)))
        sql = String.Format("{0} UNION SELECT DISTINCT ChungTu.MaCT,ChungTu.SoHieu, NgayCT, NgayGS, ChungTu.DienGiai, ChungTu.SoPS, ChungTu.SoPS2No, TK.SoHieu AS TKDU  FROM (ChungTu INNER JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo) LEFT JOIN HethongTK ON ChungTu.MaTKNo = HethongTK.MaSo WHERE {1} AND HethongTK.TK_ID={2} AND TK.TK_ID={3} AND MaVattu={4}{5}", sql, WNgay("NgayGS", ndau, ncuoi), ConvertToStrSafe(TKDT_ID), ConvertToStrSafe(TKGT_ID), ConvertToStrSafe(mvt), (IIf(shtk <> "", String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty)))
        QChitiet = (sql)
        rptFrom.ReportWindowTitle = "Sổ chi tiết doanh thu"
        rptFrom.InitForm("CTDT3.RPT", QChitiet, "QChitiet")

        rptFrom.SetFormulas("ThoiGian", String.Format("'Từ ngày {0:dd/MM/yy} đến {1:dd/MM/yy}'", ndau, ncuoi))
        sql = String.Format("SELECT Sum(SoPS) AS F1 FROM {0} WHERE MaLoai=2 AND HethongTK.SoHieu LIKE '632%' AND MaVattu={1} AND {2}", ChungTu2TKNC(-2), ConvertToStrSafe(mvt), WNgay("NgayGS", ndau, ncuoi))
        rptFrom.SetFormulas("GV", ConvertToDblSafe(GetSelectValue(sql)))
        sql = TenVT(st, mvt, dv)
        rptFrom.SetFormulas("TenVt", String.Format("'{0} - {1}{2}{3}'", st, sql, (" - Đơn vị tính: "), dv))
        RptSetDate(ncuoi)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="xlapp"></param>
    ''' <param name="xlsheet"></param>
    ''' <param name="TK"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="cap"></param>
    ''' <param name="dg"></param>
    ''' <param name="loaibc"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function BKChiTiet2(ByRef xlapp As Excel.Application, ByRef xlsheet As Excel.Worksheet, ByRef TK As String, ByRef ndau As Date, ByRef ncuoi As Date, ByRef cap As Integer, Optional ByRef dg As String = "", Optional ByRef loaibc As Integer = 0) As Boolean
        Dim i As Integer
        Dim ctk As New ClsTaikhoan
        Dim psnt1, psn, psc, psnt2 As Double
        Dim j As Integer
        XDSoHieuCap(cap)
        ' Lay danh sach tai khoan tai chinh
        Dim sql As String = "SELECT DISTINCT BaoCaoCP.SoHieu AS SHN FROM (ChungTu INNER JOIN HethongTK ON ChungTu.MaTKNo = HethongTK.MaSo) LEFT JOIN BaoCaoCP ON HethongTK.SoHieu LIKE BaoCaoCP.SoHieu+'%'" & " WHERE (HethongTK.SoHieu LIKE '" & TK & "%') AND " & WNgay("NgayGS", ndau, ncuoi) & " AND SoPS<>0 GROUP BY BaoCaoCP.SoHieu"
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        Recycle(String.Format("{0}\temp\CTPS2.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}REPORTS\CTPS2.XLS", pCurDir), pCurDir & "\temp\CTPS2.XLS")
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\CTPS2.XLS", pCurDir))
        xlsheet = xlapp.Worksheets(1)
        On Error GoTo 0
        xlsheet.Cells(1, 1) = pTenCty
        xlsheet.Cells(2, 1) = pTenCn
        If dg <> "" Then
            xlsheet.Cells(3, 1) = dg
        Else
            xlsheet.Cells(3, 1) = (xlsheet.Cells(3, 1))
        End If
        xlsheet.Cells(4, 1) = String.Format("Từ ngày {0} đến ngày {1}", Format(ndau, Mask_DB), Format(ncuoi, Mask_DB))
        If Not (rs.Rows.Count = 0) Then
            Dim rsIndex As Integer = 0
            Do While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                i += 1
                xlsheet.Cells(7, 5 + i) = rsItem("SHN")
                ''rs.MoveNext()
            Loop
            xlsheet.Cells(6, 6 + i) = "Ghi chú"
            xlsheet.Range("F6", String.Format("{0}6", XLSCol(5 + i))).MergeCells = True
            xlsheet.Range(XLSCol(6 + i) & "6", XLSCol(6 + i) & "7").MergeCells = True
            sql = String.Format("SELECT DISTINCT NgayGS,NgayCT,BaoCaoCP.SoHieu AS SHN,LEFT(TK.SoHieu,4) AS SHC, ChungTu.SoHieu,DienGiai,SoPS FROM ({0}) LEFT JOIN BaoCaoCP ON HethongTK.SoHieu LIKE BaoCaoCP.SoHieu+'%' WHERE (HethongTK.SoHieu LIKE '{1}%') AND {2} AND SoPS<>0 ORDER BY NgayGS", _
                      ChungTu2TKNC(0), _
                      TK, _
                      WNgay("NgayGS", ndau, ncuoi))
            rs = ExecSQLReturnDT(sql)
            j = 0
            rsIndex = 0
            Do While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                j += 1
                xlsheet.Cells(7 + j, 1) = Format(rsItem("NgayGS"), Mask_D)
                xlsheet.Cells(7 + j, 2) = rsItem("SoHieu")
                xlsheet.Cells(7 + j, 3) = Format(rsItem("NgayCT"), Mask_D)
                xlsheet.Cells(7 + j, 4) = rsItem("DienGiai")
                xlsheet.Cells(7 + j, 5) = rsItem("sops")
                For k As Integer = 1 To i
                    If xlsheet.Cells(7, 5 + k) = rsItem("SHN") Then
                        xlsheet.Cells(7 + j, 5 + k) = rsItem("sops")
                        Exit For
                    End If
                Next
                ''rs.MoveNext()
            Loop
            For k As Integer = 0 To i
                xlsheet.Range(String.Format("{0}{1}", XLSCol(5 + k), ConvertToStrSafe(8 + j))).Formula = String.Format("=SUM({0}8:{0}{1})", XLSCol(5 + k), ConvertToStrSafe(7 + j)) 'Excel Fomular
            Next
            xlsheet.Cells(8 + j, 4) = "Cộng phát sinh trong kỳ"
        End If
        ctk.InitTaikhoanSohieu(TK)
        Select Case loaibc
            Case 1
                xlsheet.Cells(9 + j, 4) = "Luỹ kế phát sinh từ đầu năm"
                xlsheet.Cells(10 + j, 4) = "Luỹ kế phát sinh từ khởi công"
                ctk.SoPhatSinhN(NgayDauThang(pNamTC, pThangDauKy), ncuoi, psn, psnt1, psc, psnt2)
                xlsheet.Cells(9 + j, 5) = psn
                xlsheet.Cells(10 + j, 5) = ctk.PSTuKhoiCong(ncuoi, -1)
            Case 2
                xlsheet.Cells(9 + j, 4) = "Chi phí đã phân bổ"
                xlsheet.Cells(10 + j, 4) = "Chi phí chưa phân bổ"
                xlsheet.Cells(9 + j, 5) = ctk.CPDaPhanBo(ndau, ncuoi, "241")
                xlsheet.Cells(10 + j, 5) = xlsheet.Cells(8 + j, 5) - xlsheet.Cells(9 + j, 5)
        End Select
        With xlsheet.Range("A6", String.Format("{0}{1}", XLSCol(6 + i), ConvertToStrSafe(8 + j)))
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders.Weight = Excel.XlBorderWeight.xlThin
            Dim tempRefParam As Object = .Borders.Color
            tempRefParam = Color.FromArgb(0, 0, 0)
            Dim tempRefParam2 As Object = .RowHeight
            tempRefParam2 = 18
            .Font.Size = 8
            Dim tempRefParam3 As Object = .VerticalAlignment
            tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
        End With
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\CTPS2.XLS")
KetThuc:
        ''rs.Close()
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub OptCDT_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptCDT_15.CheckedChanged, _OptCDT_14.CheckedChanged, _OptCDT_13.CheckedChanged, _OptCDT_12.CheckedChanged, _OptCDT_11.CheckedChanged, _OptCDT_10.CheckedChanged, _OptCDT_9.CheckedChanged, _OptCDT_8.CheckedChanged, _OptCDT_7.CheckedChanged, _OptCDT_6.CheckedChanged, _OptCDT_5.CheckedChanged, _OptCDT_4.CheckedChanged, _OptCDT_3.CheckedChanged, _OptCDT_2.CheckedChanged, _OptCDT_1.CheckedChanged, _OptCDT_0.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(OptCDT, eventSender)
            baocao = Index
            Select Case baocao
                Case 0, 2, 3, 4
                    OptTG(0).Enabled = True
                    OptTG(1).Enabled = True
                Case 5, 6, 7, 8
                    OptTG(0).Enabled = False
                    OptTG(1).Enabled = False
                Case 1, 9, 10, 11, 12, 13
                    OptTG(0).Enabled = True
                    OptTG(0).Checked = True
                    OptTG(1).Enabled = False
            End Select
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub OptBCQT_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptBCQT_0.CheckedChanged, _OptBCQT_1.CheckedChanged, _OptBCQT_2.CheckedChanged, _OptBCQT_12.CheckedChanged, _OptBCQT_3.CheckedChanged, _OptBCQT_4.CheckedChanged, _OptBCQT_5.CheckedChanged, _OptBCQT_6.CheckedChanged, _OptBCQT_7.CheckedChanged, _OptBCQT_8.CheckedChanged, _OptBCQT_9.CheckedChanged, _OptBCQT_10.CheckedChanged, _OptBCQT_11.CheckedChanged, _OptBCQT_13.CheckedChanged, _OptBCQT_14.CheckedChanged, _OptBCQT_15.CheckedChanged, _OptBCQT_16.CheckedChanged, _OptBCQT_17.CheckedChanged, _OptBCQT_18.CheckedChanged, _OptBCQT_19.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(OptBCQT, eventSender)
            baocao = Index
        End If
    End Sub

    Private Sub FrmMNBaocao_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        xlapp = Nothing
        xlsheet = Nothing
        taikhoan = Nothing
        MemoryHelper.ReleaseMemory()
    End Sub

    Function CTGhiSo(ByRef mgs As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef dktg As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef VV As Integer) As Boolean

        Try
            Dim sqlw As String = WThang("ThangCT", tdau, tcuoi)
            QNhatKy = String.Format("SELECT ChungTu.MaCT AS M, (ChungTu.ThangCT) AS T, ChungTu.SoHieu AS SH, ChungTu.NgayCT AS NCT, ChungTu.NgayGS AS NGS, (ChungTu.DienGiai) AS DG, HeThongTK.SoHieu AS TKNo,(HethongTK.Ten) AS TNo, HeThongTK_1.SoHieu AS TKCo,(HethongTK_1.Ten) AS TCo, Sum(ChungTu.SoPS) AS PS FROM (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo) LEFT JOIN HeThongTK AS HeThongTK_1 ON ChungTu.MaTKCo = HeThongTK_1.MaSo WHERE SoPS<>0 AND ((chungtu.maloai <> 4) OR (chungtu.maloai=4 AND matkno<>matkco)) AND {0} AND CTGS={1} AND ((chungtu.matkno=0) OR HethongTK.Loai>0) AND ((chungtu.matkco=0) OR HethongTK_1.Loai>0) {2} GROUP BY MaCT,ThangCT,ChungTu.SoHieu, NgayCT,NgayGS,ChungTu.DienGiai,HeThongTK.SoHieu,HeThongTK_1.SoHieu,HeThongTK.ten,HeThongTK_1.ten ORDER BY NgayCT, ChungTu.SoHieu", _
                                   sqlw, _
                                   ConvertToStrSafe(mgs), _
                                   (IIf(VV > 1, String.Format(" AND ChungTu.MaDT={0}", VV), String.Empty)))
            rptFrom.InitForm("CTGHISO.RPT", QNhatKy, "QNhatKy")

            If dktg = 0 Then
                sqlw = WThang("ThangCT", tdau, tcuoi)
                rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
                RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
            Else
                sqlw = WNgay("NgayGS", ndau, ncuoi)
                rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianN(ndau, ncuoi)))
                RptSetDate(ncuoi)
            End If

            rptFrom.SetFormulas("DG", String.Format("'{0}'", GetSelectValue(String.Format("SELECT SoHieu+' - '+DienGiai AS F1 FROM CTGhiSo WHERE MaSo={0}", CTGS.SelectedValue))))
            rptFrom.SetFormulas("DG2", String.Format("'{0}'", TenVV(VV)))
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Sub _ChkDu_6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _ChkDu_6.CheckedChanged

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Try
            Dim Index As Integer = TabControl1.SelectedIndex
            loai = Index
            OptTG(0).Enabled = True
            OptTG(1).Enabled = True
            Label(0).Enabled = True
            Label(1).Enabled = True
            CboThang(0).Enabled = True
            CboThang(1).Enabled = True
            Select Case Index
                Case 0 ' Thue GTGT
                    OptVAT(0).Checked = True
                    OptVAT_CheckedChanged(OptVAT(0), New EventArgs())
                    OptTG(0).Checked = True
                    OptTG(1).Enabled = False                    
                Case 1 ' Thue       
                    OptQT(2).Checked = True
                    OptQT_CheckedChanged(OptQT(2), New EventArgs())
                    OptTG(0).Checked = True
                    OptTG(1).Enabled = False
                Case 2 'So ke toan
                    OptSo(0).Checked = True
                    OptSo_CheckedChanged(OptSo(0), New EventArgs())
                    OptTG(0).Checked = True                    
                Case 3 ' Quan tri
                    OptBCQT(0).Checked = True
                    OptBCQT_CheckedChanged(OptBCQT(0), New EventArgs())
                    OptTG(0).Checked = True
                Case 4 ' Chu dau tu                    
                    OptCDT(0).Checked = True
                    OptCDT_CheckedChanged(OptCDT(0), New EventArgs())
                    OptTG(0).Checked = True
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
