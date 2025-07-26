Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmHDnoidia
    Dim Ngay(1) As Date
    Dim ThemMoi As Integer
    Private _okh As clsKhachHang = Nothing
    Property okh() As clsKhachHang
        Get
            If _okh Is Nothing Then
                _okh = New clsKhachHang()
            End If
            Return _okh
        End Get
        Set(ByVal Value As clsKhachHang)
            _okh = Value
        End Set
    End Property
    Dim SohieuHD As String = String.Empty
    Dim Chon As Integer
    Dim dem As Integer
    '====================================================================================================
    ' Thêm, Ghi, Xóa nguyên tệ
    '====================================================================================================
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Select Case Index
            Case 0
                ThemMoi = 1
                For i As Integer = 1 To 3
                    txtNhap(i).Text = "..."
                Next
                txtNhap(5).Text = "..."
                okh.InitKhachHangMaSo(0)
                txtNhap(0).Text = SoHieuVTMoi(0, 4)
                txtNhap(0).Focus()
                Khoaquyen()
            Case 1
                If okh.MaSo = 0 Then
                    txtNhap(2).Focus()
                    Exit Sub
                End If
                Select Case ThemMoi
                    Case 0
                        GrdNT.Col = 0
                        If Strings.Len(GrdNT.CtlText) = 0 Then Exit Sub
                        If ExecSQLNonQuery("UPDATE DoituongCT SET SoHieu='" & txtNhap(0).Text & "',DienGiai='..." & txtNhap(0).Text & "',NgayKy='" & FormatDate(Ngay(0), Mask_DB) & "',Thang=" & txtNhap(6).Text & ",MaKhachHang=" & ConvertToStrSafe(okh.MaSo) & ",TriGia=" & CStr(ConvertToDblSafe(txtNhap(4).Text)) & ",GhiChu='" & txtNhap(5).Text & "',NgayTH='" & FormatDate(Ngay(1), Mask_DB) & "' WHERE SoHieu='" & GrdNT.CtlText & "'") <> 0 Then Exit Sub
                        GrdNT.CtlText = txtNhap(0).Text
                        GrdNT.Col = 1
                        GrdNT.CtlText = MedNgay(0).Text
                        GrdNT.Col = 7
                        GrdNT.CtlText = MedNgay(1).Text
                        GrdNT.Col = 8
                        GrdNT.CtlText = txtNhap(6).Text
                        For i As Integer = 2 To 6
                            GrdNT.Col = ConvertToDblSafe(i)
                            GrdNT.CtlText = txtNhap(i - 1).Text
                        Next
                    Case 1
                        'Dim strSql As String = "INSERT INTO DoituongCT (MaSo,SoHieu,DienGiai,NgayKy,MaKhachHang,TriGia,GhiChu,NgayTH,Thang) VALUES (" & Lng_MaxValue("MaSo", "DoituongCT") + 1 & ",'" & txtNhap(0).Text & "','" & txtNhap(1).Text & "','" & Format(Ngay(0), Mask_DB) & "'," & ConvertToStrSafe(okh.MaSo) & "," & cstr(ConvertToDblSafe(txtNhap(4).Text)) & ",'" & txtNhap(5).Text & "','" & Format(Ngay(1), Mask_DB) & "'," & txtNhap(6).Text & ")"
                        Dim strSql As String = String.Format("INSERT INTO DoituongCT (MaSo,SoHieu,DienGiai,NgayKy,MaKhachHang,TriGia,GhiChu,NgayTH,Thang)VALUES ({0}, N'{1}', N'{2}',{3},{4},{5}, N'{6}',{7},{8})", _
                                                             Lng_MaxValue("MaSo", "DoituongCT") + 1, _
                                                             txtNhap(0).Text, _
                                                             "..." & txtNhap(0).Text, _
                                                              "convert(nvarchar(10), '" & FormatDate(Ngay(0), Mask_DB) & "',103)", _
                                                             ConvertToStrSafe(okh.MaSo), _
                                                             CStr(ConvertToDblSafe(txtNhap(4).Text)), _
                                                             txtNhap(5).Text, _
                                                             "convert(nvarchar(10), '" & FormatDate(Ngay(1), Mask_DB) & "',103)", _
                                                             txtNhap(6).Text)
                        If ExecSQLNonQuery(strSql) <> 0 Then Exit Sub
                        GrdNT.AddItem(txtNhap(0).Text & Chr(9).ToString() & Format(Ngay(0), Mask_D) & Chr(9).ToString() & txtNhap(1).Text & Chr(9).ToString() & txtNhap(2).Text & Chr(9).ToString() & txtNhap(3).Text & Chr(9).ToString() & txtNhap(4).Text & Chr(9).ToString() & txtNhap(5).Text & Chr(9).ToString() & Format(Ngay(1), Mask_D) & Chr(9).ToString() & txtNhap(6).Text, InsertGridRow(GrdNT, 0, txtNhap(0).Text))
                        ThemMoi = 0
                        GrdNT.Row = ConvertToDblSafe(GrdNT.Rows - 1)
                        GrdNT.Col = 0
                        If Strings.Len(GrdNT.CtlText) = 0 Then GrdNT.RemoveItem(GrdNT.Row)
                        GrdNT.Row = 0
                End Select
                Command_ClickEvent(Command(0), New EventArgs())
            Case 2
                GrdNT.Col = 0
                If Strings.Len(GrdNT.CtlText) = 0 Then Exit Sub
                If pNhapKhau > 0 Then
                    If ConvertToDblSafe(GetSelectValue("SELECT CPGVHD.MaSo AS F1 FROM CPGVHD INNER JOIN DoiTuongCT ON CPGVHD.MaDT=DoituongCT.MaSo WHERE DoituongCT.SoHieu='" & GrdNT.CtlText & "'")) > 0 Then
                        If MessageBox.Show(Ngonngu("Đã có phát sinh, tiếp tục ?", "Have arisen, continue ?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.No Then Exit Sub
                        ExecSQLNonQuery("DELETE CPGVHD.* FROM CPGVHD INNER JOIN DoiTuongCT ON CPGVHD.MaDT=DoituongCT.MaSo WHERE DoituongCT.SoHieu='" & GrdNT.CtlText & "'")
                    End If
                End If
                If ExecSQLNonQuery("DELETE FROM DoituongCT WHERE SoHieu='" & GrdNT.CtlText & "'") <> 0 Then Exit Sub
                GrdNT.RemoveItem(GrdNT.Row)
                'van.nguyen 19-Nov-2011
                GrdNT.Refresh()
                If GrdNT.Rows < ConvertToDblSafe(GrdNT.Tag) Then GrdNT.Rows = ConvertToDblSafe(GrdNT.Tag)
            Case 3
                Me.Close()
        End Select
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Khoaquyen()
    End Sub
    '====================================================================================================
    ' Xử lý phím nóng
    '====================================================================================================
    Private Sub FrmHDnoidia_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.T
                    Command(0).Focus()
                    'Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.G
                    Command(1).Focus()
                    ' Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.X
                    Command(2).Focus()
                    ' Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.V
                    Command(3).Focus()
                    ' Command_ClickEvent(Command(3), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    '====================================================================================================
    ' Khởi tạo cửa sổ
    '====================================================================================================
    Private Sub FrmHDnoidia_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            UpdateDoiTuongCTTable()
            ColumnSetUp(GrdNT, 0, 1300, 0)
            ColumnSetUp(GrdNT, 1, 820, 2)
            ColumnSetUp(GrdNT, 2, 1, 0)
            ColumnSetUp(GrdNT, 3, 1420, 0)
            ColumnSetUp(GrdNT, 4, 2620, 0)
            ColumnSetUp(GrdNT, 5, 1, 1)
            ColumnSetUp(GrdNT, 6, 1, 0)
            ColumnSetUp(GrdNT, 7, 1, 2)
            ColumnSetUp(GrdNT, 8, 675, 2)
            For i As Integer = 0 To 1
                InitDateVars(MedNgay(i), Ngay(i))
                Ngay(i) = ConvertToDateSafe(MedNgay(i).Text)

            Next
            Text = SetFormTitle(Text)
            LietKeNgte()
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
    Private Sub FrmHDnoidia_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        okh = Nothing
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdNT_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdNT.Click
        'SendKeys.SendWait("{Home}")
        dem += 1
        Dim dong As Integer = IIf(dem = 1, timdong(GrdNT, SohieuHD), GrdNT.Row)
        SetGridIndex(GrdNT, dong)
        With GrdNT
            .Col = 0
            SohieuHD = GrdNT.CtlText
            If .CtlText.length = 0 Then Exit Sub
            txtNhap(0).Text = .CtlText
            For i As Integer = 2 To 6
                .Col = ConvertToDblSafe(i)
                txtNhap(i - 1).Text = .CtlText
            Next
            .Col = 8
            txtNhap(6).Text = .CtlText
            okh.InitKhachHangSohieu(txtNhap(2).Text)
            .Col = 1
            On Error Resume Next
            MedNgay(0).Text = .CtlText
            .Col = 7
            MedNgay(1).Text = .CtlText
            For i As Integer = 0 To 1
                MedNgay_Leave(MedNgay(i), New EventArgs())
            Next
            On Error GoTo 0
            ThemMoi = 0
        End With
        txtNhap(0).Focus()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdNT_KeyPressEvent(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles GrdNT.KeyPress
        SendKeys.SendWait("{Home}")
        SetGridIndex(GrdNT, GrdNT.Row)
        If eventArgs.KeyChar = Chr(Keys.Enter) Then GrdNT_ClickEvent(GrdNT, New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdNT_MouseDownEvent(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles GrdNT.MouseDown
        If eventArgs.Button = MouseButtons.Right Then
            SearchObj(1, , GrdNT, GrdNT.Col)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtNhap_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtNhap_1.Enter, _txtNhap_4.Enter, _txtNhap_5.Enter, _txtNhap_6.Enter, _txtNhap_3.Enter, _txtNhap_2.Enter, _txtNhap_0.Enter
        Dim Index As Integer = Array.IndexOf(txtNhap, eventSender)
        txtNhap(Index).SelectAll()
    End Sub
    '====================================================================================================
    ' Hiển thị danh sách nguyên tệ
    '====================================================================================================
    Private Sub LietKeNgte()
        Dim sh, ten As String
        Dim nt As Integer
        'van.nguyen 14-Nov-2011
        'Dim rs_ngte As DataTable = ExecSQLReturnDT("SELECT DoituongCT.*,KhachHang.SoHieu AS SHKH,KhachHang.Ten AS TenKH,KhachHang.MaNT AS NT FROM DoituongCT LEFT JOIN KhachHang ON DoituongCT.MaKhachHang=KhachHang.MaSo WHERE DoituongCT.MaKhachHang>0 AND DoituongCT.MaSo>1 and doituongct.DienGiai='...' ORDER BY DoituongCT.SoHieu DESC,KhachHang.Ten DESC,DienGiai DESC")
        Dim rs_ngte As DataTable = ExecSQLReturnDT("SELECT DoituongCT.*,KhachHang.SoHieu AS SHKH,KhachHang.Ten AS TenKH,KhachHang.MaNT AS NT FROM DoituongCT LEFT JOIN KhachHang ON DoituongCT.MaKhachHang=KhachHang.MaSo WHERE DoituongCT.MaKhachHang>0 AND DoituongCT.MaSo>0 and doituongct.DienGiai like '...%' ORDER BY DoituongCT.SoHieu DESC,KhachHang.Ten DESC,DienGiai DESC")

        'For Each rsngteItem As DataRow In rs_ngte.Rows
        '    sh = IIf(IsDBNull(rsngteItem("shkh")), "...", ConvertToStrSafe(rsngteItem("shkh")))
        '    ten = IIf(IsDBNull(rsngteItem("TenKH")), "...", ConvertToStrSafe(rsngteItem("TenKH")))
        '    nt = IIf(IsDBNull(rsngteItem("nt")), 0, ConvertToDblSafe(rsngteItem("nt")))
        '    GrdNT.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}", _
        '                      rsngteItem("SoHieu"), _
        '                      Chr(9), _
        '                      Format(ConvertToDateSafe(rsngteItem("Ngayky")), Mask_D), _
        '                      rsngteItem("DienGiai"), _
        '                      sh, _
        '                      ten, _
        '                      Format(ConvertToDblSafe(rsngteItem("TriGia")), IIf(nt > 0, Mask_2, Mask_0)), _
        '                      rsngteItem("GhiChu"), _
        '                      Format(ConvertToDateSafe(rsngteItem("NgayTH")), Mask_D), _
        '                      IIf(Not IsDBNull(rsngteItem("thang")), ConvertToStrSafe(rsngteItem("thang")), "0")), 0)
        'Next
        For Each rsngteItem As DataRow In rs_ngte.Rows
            sh = IIf(IsDBNull(rsngteItem("shkh")), "...", ConvertToStrSafe(rsngteItem("shkh")))
            ten = IIf(IsDBNull(rsngteItem("TenKH")), "...", ConvertToStrSafe(rsngteItem("TenKH")))
            nt = IIf(IsDBNull(rsngteItem("nt")), 0, ConvertToDblSafe(rsngteItem("nt")))
            GrdNT.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}", _
                              rsngteItem("SoHieu"), _
                              Chr(9), _
                              Format(ConvertToDateSafe(rsngteItem("Ngayky")), Mask_D), _
                              rsngteItem("DienGiai"), _
                              sh, _
                              ten, _
                              Format(ConvertToDblSafe(rsngteItem("TriGia")), IIf(nt > 0, Mask_2, Mask_0)), _
                              rsngteItem("GhiChu"), _
                              Format(ConvertToDateSafe(rsngteItem("NgayTH")), Mask_D), _
                              IIf(Not IsDBNull(rsngteItem("thang")), ConvertToStrSafe(rsngteItem("thang")), "0")), 0)
        Next
        GrdNT.Rows = IIf(rs_ngte.Rows.Count > ConvertToDblSafe(GrdNT.Tag), rs_ngte.Rows.Count, ConvertToDblSafe(GrdNT.Tag))
        GrdNT.Row = 0
        GrdNT.Col = 0
        GrdNT_ClickEvent(GrdNT, New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtNhap_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtNhap_1.KeyPress, _txtNhap_4.KeyPress, _txtNhap_5.KeyPress, _txtNhap_6.KeyPress, _txtNhap_3.KeyPress, _txtNhap_2.KeyPress, _txtNhap_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtNhap, eventSender)
        Select Case Index
            Case 0
                If KeyAscii = 32 Or KeyAscii = 35 Or KeyAscii = 39 Or KeyAscii = 42 Then KeyAscii = 0
                If Chon = 1 And KeyAscii = 13 Then Me.Close()
            Case 4 : KeyProcess(txtNhap(Index), KeyAscii)
            Case 2
                If KeyAscii = ConvertToDblSafe(Keys.Return) Then
                    Me.Cursor = Cursors.WaitCursor
                    txtNhap(Index).Text = FrmKhachHang.ChonKhachHang(txtNhap(Index).Text)
                    Me.Cursor = Cursors.Default
                    txtNhap_Leave(txtNhap(Index), New EventArgs())
                End If
        End Select
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
    Private Sub txtNhap_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtNhap_1.Leave, _txtNhap_4.Leave, _txtNhap_5.Leave, _txtNhap_6.Leave, _txtNhap_3.Leave, _txtNhap_2.Leave, _txtNhap_0.Leave
        Dim Index As Integer = Array.IndexOf(txtNhap, eventSender)
        Select Case Index
            Case 4
                If okh.MaNT > 0 Then
                    txtNhap(4).Text = Format(txtNhap(4).Text, Mask_2)
                Else
                    txtNhap(4).Text = Format(txtNhap(4).Text, Mask_0)
                End If
            Case 1, 3, 5
                If Strings.Len(txtNhap(Index).Text) = 0 Then txtNhap(Index).Text = "..."
            Case 2
                If Strings.Len(txtNhap(Index).Text) = 0 Then
                    txtNhap(Index).Text = "..."
                    okh.InitKhachHangMaSo(0)
                Else
                    okh.InitKhachHangSohieu(txtNhap(Index).Text)
                    txtNhap(3).Text = okh.Ten
                End If
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_1.Enter, _MedNgay_0.Enter
        Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
        MedNgay(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_1.Leave, _MedNgay_0.Leave
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
    ''' <param name="sh"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ChonHD(ByRef sh As String) As String
        Dim result As String = String.Empty
        Chon = 1
        SohieuHD = sh
        Me.ShowDialog()
        result = SohieuHD
        Chon = 0
        dem = 0
        Return result
    End Function
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(1).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        Command(2).Enabled = (User_Right <> 2 Or (UserID = uid))
    End Sub
End Class
