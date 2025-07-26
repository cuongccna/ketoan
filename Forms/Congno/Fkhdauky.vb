Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter

Partial Friend Class FKHDauKy
    Private _taikhoan As ClsTaikhoan = Nothing
    Private _ckh As clsKhachHang = Nothing
    Dim psw As String = String.Empty
    Dim oldSelectedValue As Integer
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FKHDauKy_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            'ColumnSetUp(GrdVT, 0, 940, 2)
            'ColumnSetUp(GrdVT, 1, 1300, 2)
            'ColumnSetUp(GrdVT, 2, 3100, 0)
            'ColumnSetUp(GrdVT, 3, 1300, 1)
            'ColumnSetUp(GrdVT, 4, 1300, 1)
            'ColumnSetUp(GrdVT, 5, 1250, 1)
            ColumnSetUp(GrdVT, 0, 950, 2)
            ColumnSetUp(GrdVT, 1, 1310, 2)
            ColumnSetUp(GrdVT, 2, 3110, 0)
            ColumnSetUp(GrdVT, 3, 1310, 4)
            ColumnSetUp(GrdVT, 4, 1310, 4)
            ColumnSetUp(GrdVT, 5, 1310, 4)
            ColumnSetUp(GrdVT, 6, 1, 0)
            ColumnSetUp(GrdVT, 7, 1, 0)
            Text = SetFormTitle(Text)
            Int_RecsetToCbo("SELECT DISTINCT MaSo As F2,SoHieu + ' - '  + TenPhanLoai As F1, SoHieu FROM PhanLoaiKhachHang WHERE PLCon=0 AND LEFT(SoHieu,1)<>'#' ORDER BY SoHieu", CboKho)

            If CboKho.Items.Count > 0 Then
                CboKho.SelectedIndex = 0
            End If
            'psw = Interaction.GetSetting(IniPath, "Environment", "InvPsw", )
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
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property ckh() As clsKhachHang
        Get
            If _ckh Is Nothing Then
                _ckh = New clsKhachHang()
            End If
            Return _ckh
        End Get
        Set(ByVal Value As clsKhachHang)
            _ckh = Value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboKho_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboKho.SelectedIndexChanged
        If oldSelectedValue <> CboKho.SelectedIndex Then
            oldSelectedValue = CboKho.SelectedIndex
            LietKeTonKho(CboKho.SelectedValue)
            txtTon(0).Focus()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdct_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdct.Click
        Dim st As String = String.Empty
        If CboKho.SelectedIndex < 0 Then
            ErrMsg(er_PhanLoai)
            Exit Sub
        End If
        If taikhoan.maso = 0 Or taikhoan.tkcon > 0 Then
            ErrMsg(er_SHTaiKhoan1)
            txtTon(0).Focus()
            Exit Sub
        End If
        If taikhoan.tk_id <> TKCNKH_ID And taikhoan.tk_id <> TKCNPT_ID Then
            ErrMsg(er_SHTKCN)
            txtTon(0).Focus()
            Exit Sub
        End If
        If ckh.MaSo = 0 Then
            ErrMsg(er_SHKhachHang)
            txtTon(1).Focus()
            Exit Sub
        End If
        For i As Integer = 0 To txtTon.Length - 1
            txtTon_Leave(txtTon(i), New EventArgs())
        Next
        Dim tien1 As Double = ConvertToDblSafe(txtTon(3).Text)
        Dim tien2 As Double = ConvertToDblSafe(txtTon(4).Text)
        Dim luong As Double = ConvertToDblSafe(txtTon(5).Text)
        If tien1 <> 0 And tien2 <> 0 Then
            MessageBox.Show(Ngonngu("Nhập dư nợ hoặc dư có!", "Enter debt or credit"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTon(3).Focus()
            Exit Sub
        End If
        Me.Cursor = Cursors.Default
        With GrdVT
            For i As Integer = 0 To .Rows - 1
                .Col = 6
                .Row = i
                If .CtlText.length = 0 Then Exit For
                If ConvertToDblSafe(.CtlText) = taikhoan.maso Then
                    .Col = 7
                    If ConvertToDblSafe(.CtlText) = ckh.MaSo Then
                        If psw.Length > 0 Then
                            If FrmPassword.GetPswX() <> psw Then GoTo XongDK
                        End If
                        GrdVT.RemoveItem(ConvertToDblSafe(i))
                        GrdVT.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}", _
                                          taikhoan.sohieu, _
                                          Chr(9), _
                                          ckh.SoHieu, _
                                          ckh.Ten, _
                                          Format(tien1, Mask_0), _
                                          Format(tien2, Mask_0), _
                                          Format(luong, Mask_2), _
                                          ConvertToStrSafe(taikhoan.maso), _
                                          ConvertToStrSafe(ckh.MaSo)), i)
                        ckh.GhiDauKy(taikhoan.maso, tien1, tien2, luong)
                        tongtien()
                        txtTon(0).Focus()
                        GoTo XongDK
                    End If
                End If
            Next
            .AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}", _
                         taikhoan.sohieu, _
                         Chr(9), _
                         ckh.SoHieu, _
                         ckh.Ten, _
                         Format(tien1, Mask_0), _
                         Format(tien2, Mask_0), _
                         Format(luong, Mask_2), _
                         ConvertToStrSafe(taikhoan.maso), _
                         ConvertToStrSafe(ckh.MaSo)), NewRowIndex(GrdVT, 0))
            ckh.GhiDauKy(taikhoan.maso, tien1, tien2, luong)
            .Row = (.Rows - 1)
            .Col = 0
            If .CtlText.length = 0 Then .RemoveItem(.Row)
            .Row = 0
            txtTon(0).Focus()
        End With
        tongtien()
        GoTo XongDK
XongDK:
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_0.Click, _Command_2.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Select Case Index
            Case 0
                Me.Close()
            Case 2
                With GrdVT
                    .Col = 6
                    If .CtlText.length = 0 Then Exit Sub
                    If ConvertToDblSafe(.CtlText) = taikhoan.maso Then
                        .Col = 7
                        If ConvertToDblSafe(.CtlText) = ckh.MaSo Then
                            If psw.Length > 0 Then
                                If FrmPassword.GetPswX() <> psw Then Exit Sub
                            End If
                            .RemoveItem(.Row)
                            ckh.GhiDauKy(taikhoan.maso, 0, 0, 0)
                            txtTon(3).Text = "0"
                            txtTon(4).Text = "0"
                            txtTon(5).Text = "0"
                            tongtien()
                            txtTon(0).Focus()
                            Exit Sub
                        End If
                    End If
                    For i As Integer = 0 To .Rows - 1
                        .Col = 6
                        .Row = i
                        If .CtlText.length = 0 Then Exit For
                        If ConvertToDblSafe(.CtlText) = taikhoan.maso Then
                            .Col = 7
                            If ConvertToDblSafe(.CtlText) = ckh.MaSo Then
                                If psw.Length > 0 Then
                                    If FrmPassword.GetPswX() <> psw Then Exit Sub
                                End If
                                .RemoveItem(ConvertToDblSafe(i))
                                ckh.GhiDauKy(taikhoan.maso, 0, 0, 0)
                                txtTon(3).Text = "0"
                                txtTon(4).Text = "0"
                                txtTon(5).Text = "0"
                                tongtien()
                                txtTon(0).Focus()
                                Exit For
                            End If
                        End If
                    Next
                End With
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FKHDauKy_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If ((Shift And 4) > 0 And eventArgs.KeyCode = Keys.V) Or eventArgs.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FKHDauKy_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        taikhoan = Nothing
        ckh = Nothing
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdVT_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdVT.DoubleClick
        With GrdVT
            .Col = 0
            If .CtlText.length = 0 Then Exit Sub
            For i As Integer = 0 To 5
                .Col = ConvertToDblSafe(i)
                txtTon(i).Text = .CtlText
            Next
            .Col = 0
            txtTon_Leave(txtTon(0), New EventArgs())
            txtTon_Leave(txtTon(1), New EventArgs())
            txtTon(0).Focus()
        End With
    End Sub
    '''' <summary>
    '''' 
    '''' </summary>
    '''' <param name="eventSender"></param>
    '''' <param name="eventArgs"></param>
    '''' <remarks></remarks>
    'Private Sub GrdVT_KeyPressEvent(ByVal eventSender As Object, ByVal eventArgs  As KeyPressEventArgs) Handles GrdVT.KeyPress 
    '     If eventArgs.KeyChar =  Chr(Keys.Enter) Then  GrdVT_DblClick(GrdVT, New EventArgs())
    'End Sub
    '''' <summary>
    '''' 
    '''' </summary>
    '''' <param name="eventSender"></param>
    '''' <param name="eventArgs"></param>
    '''' <remarks></remarks>
    'Private Sub GrdVT_KeyUpEvent(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles GrdVT.KeyUp
    '    If eventArgs.KeyCode = 37 Or eventArgs.KeyCode = 38 Or eventArgs.KeyCode = 39 Or eventArgs.KeyCode = 40 Then SetGridIndex(GrdVT, GrdVT.Row)
    'End Sub
    '''' <summary>
    '''' 
    '''' </summary>
    '''' <param name="eventSender"></param>
    '''' <param name="eventArgs"></param>
    '''' <remarks></remarks>
    'Private Sub GrdVT_MouseDownEvent(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles GrdVT.MouseDown 
    '    If eventArgs.Button = 2 Then
    '        SearchObj(1, , GrdVT, GrdVT.Col)
    '    End If
    'End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtTon_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtTon_4.Enter, _txtTon_5.Enter, _txtTon_3.Enter, _txtTon_2.Enter, _txtTon_1.Enter, _txtTon_0.Enter
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        txtTon(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtTon_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtTon_4.KeyPress, _txtTon_5.KeyPress, _txtTon_3.KeyPress, _txtTon_2.KeyPress, _txtTon_1.KeyPress, _txtTon_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        Select Case Index
            Case 0
                If KeyAscii = 13 Then
                    txtTon(0).Text = FrmTaikhoan.ChonTk(txtTon(0).Text)
                End If
            Case 1
                If KeyAscii = 13 Then
                    txtTon(1).Text = FrmKhachHang.ChonKhachHang(txtTon(1).Text, CboKho.SelectedValue, 1)
                End If
            Case 2
                KeyAscii = 0
            Case 3, 4, 5
                If KeyAscii = 13 Then
                    cmdct_Click(cmdct, New EventArgs())
                Else
                    KeyProcess(txtTon(Index), KeyAscii, False)
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
    Private Sub txtTon_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtTon_4.Leave, _txtTon_5.Leave, _txtTon_3.Leave, _txtTon_2.Leave, _txtTon_1.Leave, _txtTon_0.Leave
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        Select Case Index
            Case 0
                If Strings.Len(txtTon(0).Text) > 0 Then
                    taikhoan.InitTaikhoanSohieu(txtTon(0).Text)
                Else
                    taikhoan.InitTaikhoanMaSo(0)
                End If
            Case 1
                If Strings.Len(txtTon(1).Text) > 0 Then
                    ckh.InitKhachHangSohieu(txtTon(1).Text)
                Else
                    ckh.InitKhachHangMaSo(0)
                End If
                txtTon(2).Text = ckh.Ten
                txtTon(5).Enabled = (ckh.MaNT > 0)
                If ckh.MaNT = 0 Then txtTon(5).Text = "0"
            Case 3, 4
                txtTon(Index).Text = Format(txtTon(Index).Text, Mask_0)
                If ConvertToDblSafe(txtTon(Index).Text) <> 0 Then txtTon(7 - Index).Text = "0"
            Case 5
                txtTon(5).Text = Format(txtTon(5).Text, Mask_2)
        End Select
    End Sub
    ''' <summary>
    ''' Thủ tục liệt kê tồn kho
    ''' </summary>
    ''' <param name="mkho"></param>
    ''' <remarks></remarks>
    Private Sub LietKeTonKho(ByRef mkho As Integer)
        Me.Cursor = Cursors.WaitCursor
        ClearGrid(GrdVT, ConvertToDblSafe(GrdVT.Tag))
        Dim rs_ton As DataTable = ExecSQLReturnDT(String.Format("SELECT HethongTK.MaSo,HethongTK.Kieu,HethongTK.SoHieu AS SHTK,SoDuKhachHang.MaKhachHang,KhachHang.SoHieu,KhachHang.Ten, SoDuKhachHang.DuNo_0 AS DuNo,SoDuKhachHang.DuCo_0 AS DuCo,SoDuKhachHang.DuNT_0 AS DuNT  FROM ((SoDuKhachHang INNER JOIN KhachHang ON SoDuKhachHang.MaKhachHang = KhachHang.MaSo) INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo) INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo WHERE PhanLoaiKhachHang.MaSo = {0} AND (SoDuKhachHang.DuNo_0 <> 0 OR SoDuKhachHang.DuCo_0 <> 0) ORDER BY HethongTK.SoHieu DESC, KhachHang.SoHieu DESC", mkho))
        For Each rstonItem As DataRow In rs_ton.Rows
            GrdVT.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}", _
                              rstonItem("shtk"), _
                              Chr(9), _
                              rstonItem("SoHieu"), _
                              rstonItem("ten"), _
                              Format(rstonItem("duno"), Mask_0), _
                              Format(rstonItem("duco"), Mask_0), _
                              Format(rstonItem("dunt"), Mask_2), _
                              rstonItem("MaSo"), _
                              rstonItem("MaKhachHang")), 0)
        Next
        'GrdVT.Rows = iif(rs_ton.Rows.Count > ConvertToDblSafe(GrdVT.Tag), _
        '                 rs_ton.Rows.Count, _
        '                 ConvertToDblSafe(GrdVT.Tag))
        ''rs_ton.Close()
        rs_ton = Nothing
        GrdVT.Row = 0
        tongtien()
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub tongtien()
        Dim duno, duco As Double
        If CboKho.SelectedIndex >= 0 Then
            duno = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoDuKhachHang.DuNo_0) As F1, Sum(SoDuKhachHang.DuCo_0) As F2 FROM (SoDuKhachHang INNER JOIN KhachHang ON SoDuKhachHang.MaKhachHang=KhachHang.MaSo) INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo WHERE PhanLoaiKhachHang.MaSo ={0}", CboKho.SelectedValue), duco))
        End If
        LbTien(0).Text = Format(duno, Mask_0)
        LbTien(1).Text = Format(duco, Mask_0)
    End Sub

    Private Sub GrdVT_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdVT.KeyUp
        If e.KeyCode = Keys.Return Then
            With GrdVT
                .Col = 0
                If .CtlText.length = 0 Then Exit Sub
                For i As Integer = 0 To 5
                    .Col = ConvertToDblSafe(i)
                    txtTon(i).Text = .CtlText
                Next
                .Col = 0
                txtTon_Leave(txtTon(0), New EventArgs())
                txtTon_Leave(txtTon(1), New EventArgs())
                txtTon(0).Focus()
            End With
        End If
    End Sub
End Class
