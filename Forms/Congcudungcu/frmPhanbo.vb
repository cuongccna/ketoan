Imports System
Imports System.Data
Imports System.Media
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter

Partial Friend Class frmPhanbo

    Dim LoaiKhauHao As Integer
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Khoaquyen()
    End Sub
    ' Key Down
    Private Sub frmPhanbo_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.G
                    Command(0).Focus()
                    ' Command_ClickEvent(Command(0), New EventArgs())
                    Exit Select
                Case Keys.V
                    Command(1).Focus()
                    ' Command_ClickEvent(Command(1), New EventArgs())
                    Exit Select
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then
            Me.Hide()
            Me.Finalize()
        End If
    End Sub

    Private chiso1 As Integer = -1
    Private chiso0 As Integer = -1
    ' Load
    Private Sub frmPhanbo_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            Text = SetFormTitle(Text)
            AddMonthToCbo(Combo(0))
            AddMonthToCbo(Combo(1))
            LoaiKhauHao = 0
            If chiso0 <> -1 And Combo(0).Items.Count > 0 Then
                Combo(0).SelectedIndex = chiso0
            End If
            If chiso1 <> -1 And Combo(1).Items.Count > 0 Then
                Combo(1).SelectedIndex = chiso1
            End If
            If Option_Renamed(1).Checked Then Option_Renamed_CheckedChanged(Option_Renamed(1), New EventArgs)
            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    '======================================================================================
    ' FUNCTION TrichPhanBo
    '======================================================================================
    Private Function TrichPhanBo() As Integer
        Dim result As Integer = 0
        Dim sql = String.Empty, shct As String = String.Empty
        Dim chi_so As Integer
        Dim tong_ps As Double
        Me.Cursor = Cursors.WaitCursor
        Dim thg As Integer = CThangDB2(Combo(0).SelectedValue)
        Dim thgcuoi As Integer = CThangDB2(Combo(1).SelectedValue)
        Select Case LoaiKhauHao
            Case 0 ' Chi phí trả trước ngắn hạn
                sql = String.Format("SELECT DISTINCT TKCha0,Sum(ThongSo1.KH_NS+ThongSo1.KH_TBS+Thongso1.KH_CNK+ Thongso1.KH_TD) AS TKH, HethongTK.SoHieu FROM HethongTK RIGHT JOIN ((LoaiCongcudungcu RIGHT JOIN Congcudungcu ON LoaiCongcudungcu.MaSo = Congcudungcu.MaTaiKhoan) RIGHT JOIN Thongso1 ON Congcudungcu.MaSo = Thongso1.MaTS) ON HethongTK.MaSo = Thongso1.MaDTSD WHERE Thongso1.Thang >= {0} AND Thongso1.Thang <= {1} AND right(LoaiCongcudungcu.SoHieu,1) = '1' GROUP BY HethongTK.SoHieu,TKCha0", _
                          thg, _
                          ConvertToStrSafe(thgcuoi))
                thg = 1
            Case 1 ' Chi phí trả trước dài hạn
                sql = String.Format("SELECT DISTINCT TKCha0,Sum(ThongSo1.KH_NS+ThongSo1.KH_TBS+Thongso1.KH_CNK+ Thongso1.KH_TD) AS TKH, HethongTK.SoHieu FROM HethongTK RIGHT JOIN ((LoaiCongcudungcu RIGHT JOIN Congcudungcu ON LoaiCongcudungcu.MaSo = Congcudungcu.MaTaiKhoan) RIGHT JOIN Thongso1 ON Congcudungcu.MaSo = Thongso1.MaTS) ON HethongTK.MaSo = Thongso1.MaDTSD WHERE Thongso1.Thang >= {0} AND Thongso1.Thang <= {1} AND right(LoaiCongcudungcu.SoHieu,1) = '2' GROUP BY HethongTK.SoHieu,TKCha0", _
                          thg, _
                          ConvertToStrSafe(thgcuoi))
                thg = 2
        End Select
        ' Khấu hao công cụ dụng cụ hữu hình
        Dim rs_PhanBo As DataTable = ExecSQLReturnDT(sql)
        Try
            parSoPS = rs_PhanBo.Rows.Count
            ReDim arPhatSinh(parSoPS)
            ' Các dòng phát sinh đối ứng của tài khoản chi phí khấu hao
            For Each rsItem As DataRow In rs_PhanBo.Rows
                If (ConvertToDblSafe(rsItem("TKH")) <> 0) Then
                    Dim Sohieu As String = ConvertToStrSafe(rsItem("SoHieu"))
                    arPhatSinh(chi_so).TK_SoHieu = Sohieu
                    arPhatSinh(chi_so).PS_Loai = -1
                    arPhatSinh(chi_so).PS_SoLg = ConvertToDblSafe(rsItem("TKH"))
                    If pDTTP <> 0 Then
                        shct = Strings.Right(Sohieu, Sohieu.Length - ConvertToStrSafe(GetSelectValue(String.Format("SELECT SoHieu AS F1 FROM HethongTK WHERE MaSo={0}", rsItem("TkCha0")))).Length)
                        If SoHieu2MaSo(shct, "TP154") > 0 And Strings.Left(Sohieu, 3) = "154" Then
                            arPhatSinh(chi_so).ShTP = shct
                        End If
                    End If
                    tong_ps += ConvertToDblSafe(rsItem("TKH"))
                    chi_so += 1
                End If
            Next
            ' Dòng phát sinh tổng cộng của công cụ dụng cụ
            arPhatSinh(chi_so).TK_SoHieu = String.Format("{0}42", ConvertToStrSafe(thg))
            If arPhatSinh(chi_so).TK_SoHieu = "142" Then
                If ConvertToDblSafe(Timten("maso", "1421", "sohieu", "hethongtk")) = 0 Then
                    UpdateLoaicongcudungcu()
                End If
                arPhatSinh(chi_so).TK_SoHieu = "1421"
            End If
            arPhatSinh(chi_so).PS_Loai = 1
            arPhatSinh(chi_so).PS_SoLg = tong_ps
            result = parSoPS
        Catch
        Finally
            rs_PhanBo = Nothing
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
                cuongktphanbo = 1
                cuongktphanbo1 = 1
                If Combo(1).Items.Count > 0 Then If Combo(1).SelectedIndex < Combo(0).SelectedIndex Then Combo(1).SelectedIndex = Combo(0).SelectedIndex
                tdau = Combo(0).SelectedValue
                tcuoi = Combo(1).SelectedValue
                ' Chuẩn bị các biến trao đổi dữ liệu
                HienThongBao("Cập nhật giá trị công cụ dụng cụ ...", 1)
                For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
                    ' Cập nhật giá trị công cụ dụng cụ cho tháng cần trích khấu hao
                    CapNhatGiaTriCongcudungcu(i, Gauge)
                    Gauge.Value = 0
                Next
                ' Thành lập các dòng phát sinh
                If Not (TrichPhanBo() = 0) Then
                    If FrmMNCongCu.Visible Then
                        Thongtin(FrmChungtu, tdau, tcuoi)
                    Else
                        'van cung edit ngay 23-3-19
                        ' cu : Thongtin(FrmChungtutonghop, tdau, tcuoi)
                        Thongtin(FrmChungtu, tdau, tcuoi)
                    End If
                Else
                    SystemSounds.Beep.Play()
                    MessageBox.Show(Ngonngu("Không có công cụ dụng cụ nào !", "Tool does not exist !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                pThangTacDong = 0
            Case 1
                SendKeys.Send("{Escape}")
        End Select
        If Combo(1).Items.Count > 0 Then
            chiso1 = Combo(1).SelectedIndex
        End If
        If Combo(0).Items.Count > 0 Then
            chiso0 = Combo(0).SelectedIndex
        End If
        Me.Cursor = Cursors.Default
    End Sub
    Sub Thongtin(ByRef frm As FrmChungtu, ByRef tdau As Integer, ByRef tcuoi As Integer)
        With frm
            'Int_RecsetToCbo(String.Format("SELECT MaSo As F2,SoHieu + ' - ' + Ten As F1 FROM LoaiChungTu WHERE (Cap = 2) AND (CapTren = {0}) ORDER BY SoHieu", ConvertToStrSafe(OptLoai(loai).Tag)), .CboNguon(0))
            If .CboNguon(0).Items.Count > 0 Then
                .CboNguon(0).SelectedIndex = IIf(LoaiKhauHao <> 0, 2 - LoaiKhauHao, 0)
            End If
            '.CboNguon(0).SelectedIndex = IIf(LoaiKhauHao <> 0, 2 - LoaiKhauHao, 0)
            .CboNguon(0).Tag = arPhatSinh(0).TK_SoHieu
            SetListIndex(.CboThang, tcuoi)
            .txt(0).Text = String.Format("PBCP{0}{1}{2}", _
                               (IIf(LoaiKhauHao = 0, "NH", "DH")), _
                               (IIf(tcuoi < 10, "0", String.Empty)), _
                               ConvertToStrSafe(tcuoi))
            .txt(1).Text = String.Format("Phân bổ chi phí trả trước {0} tháng {1}{2}", _
                               (IIf(LoaiKhauHao = 0, "ngắn hạn", "dài hạn")), _
                               (IIf(tcuoi < 10, "0", String.Empty)), _
                               ConvertToStrSafe(tcuoi))
            Try
                .MedNgay(0).Text = DateSerial(pNamTC, tcuoi, DayofMonth1(tcuoi, pNamTC))
                .MedNgay(1).Text = .MedNgay(0).Text
            Catch ex As Exception
            End Try
            .Tag = ConvertToStrSafe(tdau)
            pGhichungtu = 1
            Me.Hide()
        End With
    End Sub
    Sub Thongtin(ByRef frm As FrmChungtutonghop, ByRef tdau As Integer, ByRef tcuoi As Integer)
        With frm
            If .CboNguon(0).Items.Count > 0 Then
                .CboNguon(0).SelectedIndex = IIf(LoaiKhauHao <> 0, 2 - LoaiKhauHao, 0)
            End If
            '.CboNguon(0).SelectedIndex = IIf(LoaiKhauHao <> 0, 2 - LoaiKhauHao, 0)
            .CboNguon(0).Tag = arPhatSinh(0).TK_SoHieu
            SetListIndex(.CboThang, tcuoi)
            .txt(0).Text = String.Format("PBCP{0}{1}{2}", _
                               (IIf(LoaiKhauHao = 0, "NH", "DH")), _
                               (IIf(tcuoi < 10, "0", String.Empty)), _
                               ConvertToStrSafe(tcuoi))
            .txt(1).Text = String.Format("Phân bổ chi phí trả trước {0} tháng {1}{2}", _
                               (IIf(LoaiKhauHao = 0, "ngắn hạn", "dài hạn")), _
                               (IIf(tcuoi < 10, "0", String.Empty)), _
                               ConvertToStrSafe(tcuoi))
            Try
                .MedNgay(0).Text = DateSerial(pNamTC, tcuoi, DayofMonth1(tcuoi, pNamTC))
                .MedNgay(1).Text = .MedNgay(0).Text
            Catch ex As Exception
            End Try
            .Tag = ConvertToStrSafe(tdau)
            pGhichungtu = 1
            Me.Hide() : Exit Sub
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private isInitializingComponent As Boolean
    Private Sub Option_Renamed_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Option_1.CheckedChanged, _Option_0.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(Option_Renamed, eventSender)
            LoaiKhauHao = Index
        End If
    End Sub
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(1).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        If User_Right <> 0 Then
            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT Lock{0} % 10 AS F1 FROM License", Combo(0).SelectedValue))) > 0 Then
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
    Private Sub frmPhanbo_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
