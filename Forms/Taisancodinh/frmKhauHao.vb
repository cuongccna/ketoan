Imports System
Imports System.Data
Imports System.Media
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class frmKhauHao

    Dim LoaiKhauHao As Integer
    ' Key Down
    Private Sub frmKhauHao_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.G
                    Command(0).Focus()
                    'Command_ClickEvent(Command(0), New EventArgs())
                    Exit Select
                Case Keys.V
                    Command(1).Focus()
                    'Command_ClickEvent(Command(1), New EventArgs())
                    Exit Select
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then
            Me.Close()
            Me.Finalize()
        End If
        Khoaquyen()
    End Sub
    ' Load
    Private Sub frmKhauHao_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            Text = SetFormTitle(Text)
            AddMonthToCbo(CboThang(0))
            AddMonthToCbo(CboThang(1))
            Option_Renamed_CheckedChanged(Option_Renamed(0), New EventArgs())
            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try        
    End Sub
    '======================================================================================
    ' FUNCTION TrichKhauHao
    '======================================================================================
    Private Function TrichKhauHao() As Integer
        Dim result As Integer = 0
        Dim sql = String.Empty, shct As String = String.Empty
        Dim chi_so As Integer
        Dim tong_ps As Double
        Me.Cursor = Cursors.WaitCursor
        Dim thg As Integer = CThangDB2(CboThang(0).SelectedValue)
        Dim thgcuoi As Integer = CThangDB2(CboThang(1).SelectedValue)
        Select Case LoaiKhauHao
            Case 0 ' Khấu hao tài sản cố định hữu hình
                sql = String.Format("SELECT DISTINCT TKCha0,Sum(ThongSo.KH_NS+ThongSo.KH_TBS+ThongSo.KH_CNK+ ThongSo.KH_TD) AS TKH, HethongTK.SoHieu FROM HethongTK RIGHT JOIN ((LoaiTaiSan RIGHT JOIN TaiSan ON LoaiTaiSan.MaSo = TaiSan.MaTaiKhoan) RIGHT JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS) ON HethongTK.MaSo = ThongSo.MaDTSD WHERE HethongTK.SoHieu LIKE '{0}%' AND ThongSo.Thang >= {1} AND ThongSo.Thang <= {2} AND LoaiTaiSan.SoHieu like '__1%' GROUP BY HethongTK.SoHieu,TKCha0", _
                          txt.Text, _
                          ConvertToStrSafe(thg), _
                          ConvertToStrSafe(thgcuoi))
                thg = 1
            Case 1 ' Khấu hao tài sản cố định vô hình
                sql = String.Format("SELECT DISTINCT TKCha0,Sum(ThongSo.KH_NS+ThongSo.KH_TBS+ThongSo.KH_CNK+ ThongSo.KH_TD) AS TKH, HethongTK.SoHieu FROM HethongTK RIGHT JOIN ((LoaiTaiSan RIGHT JOIN TaiSan ON LoaiTaiSan.MaSo = TaiSan.MaTaiKhoan) RIGHT JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS) ON HethongTK.MaSo = ThongSo.MaDTSD WHERE HethongTK.SoHieu LIKE '{0}%' AND ThongSo.Thang >={1} AND ThongSo.Thang <= {2} AND LoaiTaiSan.SoHieu like '__3%' GROUP BY HethongTK.SoHieu,TKCha0", _
                          txt.Text, _
                          ConvertToStrSafe(thg), _
                          ConvertToStrSafe(thgcuoi))
                thg = 3
            Case 2 ' Khấu hao tài sản cố định thuê tài chính
                sql = String.Format("SELECT DISTINCT TKCha0,Sum(ThongSo.KH_NS+ThongSo.KH_TBS+ThongSo.KH_CNK+ ThongSo.KH_TD) AS TKH, HethongTK.SoHieu FROM HethongTK RIGHT JOIN ((LoaiTaiSan RIGHT JOIN TaiSan ON LoaiTaiSan.MaSo = TaiSan.MaTaiKhoan) RIGHT JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS) ON HethongTK.MaSo = ThongSo.MaDTSD WHERE HethongTK.SoHieu LIKE '{0}%' AND ThongSo.Thang >={1} AND ThongSo.Thang <= {2} AND LoaiTaiSan.SoHieu like '__2%' GROUP BY HethongTK.SoHieu,TKCha0", _
                          txt.Text, _
                          ConvertToStrSafe(thg), _
                          ConvertToStrSafe(thgcuoi))
                thg = 2
            Case 3
                sql = String.Format("SELECT DISTINCT TKCha0,Sum(ThongSo.KH_NS+ThongSo.KH_TBS+ThongSo.KH_CNK+ ThongSo.KH_TD) AS TKH, HethongTK.SoHieu FROM HethongTK RIGHT JOIN ((LoaiTaiSan RIGHT JOIN TaiSan ON LoaiTaiSan.MaSo = TaiSan.MaTaiKhoan) RIGHT JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS) ON HethongTK.MaSo = ThongSo.MaDTSD WHERE HethongTK.SoHieu LIKE '{0}%' AND ThongSo.Thang >= {1} AND ThongSo.Thang <= {2} AND LoaiTaiSan.SoHieu like '__7%' GROUP BY HethongTK.SoHieu,TKCha0", _
                          txt.Text, _
                          ConvertToStrSafe(thg), _
                          ConvertToStrSafe(thgcuoi))
                thg = 7
        End Select
        Dim rs_khauhao As DataTable = ExecSQLReturnDT(sql)
        Try
            parSoPS = rs_khauhao.Rows.Count
            result = rs_khauhao.Rows.Count
            ReDim arPhatSinh(parSoPS)
            ' Các dòng phát sinh đối ứng của tài khoản chi phí khấu hao
            For Each rsKhauhaoItem As DataRow In rs_khauhao.Rows
                Dim Sohieu As String = ConvertToStrSafe(rsKhauhaoItem("SoHieu"))
                If ConvertToDblSafe(rsKhauhaoItem("TKH")) <> 0 Then
                    arPhatSinh(chi_so).TK_SoHieu = Sohieu
                    arPhatSinh(chi_so).PS_Loai = -1
                    arPhatSinh(chi_so).PS_SoLg = ConvertToDblSafe(rsKhauhaoItem("TKH"))
                    If pDTTP <> 0 Then
                        shct = Sohieu.Substring(Sohieu.Length - ConvertToDblSafe(GetSelectValue("SELECT SoHieu AS F1 FROM HethongTK WHERE MaSo=" & rsKhauhaoItem("TkCha0").ToString)).ToString.Length)
                        If SoHieu2MaSo(shct, "TP154") > 0 Then arPhatSinh(chi_so).ShTP = shct
                    End If
                    tong_ps += ConvertToDblSafe(rsKhauhaoItem("TKH"))
                    chi_so += 1
                End If
            Next
            ' Dòng phát sinh tổng cộng của tài sản
            arPhatSinh(chi_so).TK_SoHieu = String.Format("214{0}", thg)
            arPhatSinh(chi_so).PS_Loai = 1
            arPhatSinh(chi_so).PS_SoLg = tong_ps
            result = parSoPS
        Catch
        Finally
            rs_khauhao = Nothing
            Me.Cursor = Cursors.Default
        End Try
        Return result
    End Function
    '======================================================================================
    ' command
    '======================================================================================
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim tdau, tcuoi As Integer
        Me.Cursor = Cursors.WaitCursor
        Select Case Index
            Case 0
                If CboThang(1).Items.Count > 0 Then
                    If CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then
                        CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
                    End If
                End If

                tdau = CboThang(0).SelectedValue
                tcuoi = CboThang(1).SelectedValue
                '                  If ThangDaKhauHao(tdau, tcuoi, FrmChungtu.CboNguon(0).ItemData(LoaiKhauHao), txt.Text) Then
                '                        frmthongbao.thongbaomoi "Chứng từ khấu hao tháng " + ConvertToStrSafe(tcuoi) + " sẽ được thay bằng chứng từ mới!", vbInformation, App.ProductName
                '                  End If
                ' Chuẩn bị các biến trao đổi dữ liệu
                HienThongBao("Cập nhật giá trị tài sản ...", 1)
                For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
                    ' Cập nhật giá trị tài sản cho tháng cần trích khấu hao
                    CapNhatGiaTriTaiSan(i, Gauge)
                    Gauge.Value = 0
                Next
                ' Thành lập các dòng phát sinh
                If Not (TrichKhauHao() = 0) Then
                    If FrmMNTaiSan.Visible Then
                        Thongtin(FrmChungtu, tdau, tcuoi)
                    Else
                        Thongtin(FrmChungtutonghop, tdau, tcuoi)
                    End If
                Else
                    SystemSounds.Beep.Play()
                    myUMessager.mError("Không có tài sản nào !", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                pThangTacDong = 0
            Case 1
                SendKeys.Send("{Escape}")
        End Select
        Me.Cursor = Cursors.Default
    End Sub

    Sub Thongtin(ByRef frm As FrmChungtu, ByRef tdau As Integer, ByRef tcuoi As Integer)
        With frm
            If .CboNguon(0).Items.Count > 0 Then
                .CboNguon(0).SelectedIndex = IIf(LoaiKhauHao <> 0, 3 - LoaiKhauHao, 0)
                .CboNguon(0).Tag = arPhatSinh(0).TK_SoHieu
            Else
                .CboNguon(0).SelectedIndex = -1
                .CboNguon(0).Tag = -1
            End If
            
            SetListIndex(.CboThang, tcuoi)
            .txt(0).Text = String.Format("KHTS{0}{1}{2}", _
                               (IIf(LoaiKhauHao = 0, "HH", (IIf(LoaiKhauHao = 1, "VH", "TC")))), _
                               (IIf(tcuoi < 10, "0", String.Empty)), _
                               ConvertToStrSafe(tcuoi))
            .txt(1).Text = String.Format("Trích khấu hao TSCĐ tháng {0}{1}", _
                               (IIf(tcuoi < 10, "0", String.Empty)), _
                               ConvertToStrSafe(tcuoi))
            .MedNgay(0).Text = DateSerial(pNamTC, tcuoi, DayofMonth1(tcuoi, pNamTC))
            .MedNgay(1).Text = .MedNgay(0).Text
            .Tag = ConvertToStrSafe(tdau)
            pGhichungtu = 1
            Me.Close()
        End With
    End Sub

    Sub Thongtin(ByRef frm As FrmChungtutonghop, ByRef tdau As Integer, ByRef tcuoi As Integer)
        With frm
            If .CboNguon(0).Items.Count > 0 Then.CboNguon(0).SelectedIndex = IIf(LoaiKhauHao <> 0, 3 - LoaiKhauHao, 0)
            .CboNguon(0).Tag = arPhatSinh(0).TK_SoHieu
            SetListIndex(.CboThang, tcuoi)
            .txt(0).Text = String.Format("KHTS{0}{1}{2}", _
                                (IIf(LoaiKhauHao = 0, "HH", (IIf(LoaiKhauHao = 1, "VH", "TC")))), _
                                (IIf(tcuoi < 10, "0", String.Empty)), _
                                ConvertToStrSafe(tcuoi))
            .txt(1).Text = String.Format("Trích khấu hao TSCĐ tháng {0}{1}", _
                                (IIf(tcuoi < 10, "0", String.Empty)), _
                                ConvertToStrSafe(tcuoi))
            .MedNgay(0).Text = DateSerial(pNamTC, tcuoi, DayofMonth1(tcuoi, pNamTC))
            .MedNgay(1).Text = .MedNgay(0).Text
            .Tag = ConvertToStrSafe(tdau)
            pGhichungtu = 1
            Me.Close() : Exit Sub
        End With
    End Sub
    '======================================================================================
    ' Option
    '======================================================================================
    Private isInitializingComponent As Boolean
    Private Sub Option_Renamed_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Option_3.CheckedChanged, _Option_2.CheckedChanged, _Option_1.CheckedChanged, _Option_0.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(Option_Renamed, eventSender)
            LoaiKhauHao = Index
        End If
    End Sub
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(0).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        If User_Right <> 0 Then
            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT Lock{0} %  10 AS F1 FROM License", CboThang(0).SelectedValue))) > 0 Then
                Command(0).Enabled = False
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub frmKhauHao_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
