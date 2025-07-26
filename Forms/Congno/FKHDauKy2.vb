Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FKHDauKy2

    Private _taikhoan As ClsTaikhoan = Nothing
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
    Private _ckh As clsKhachHang = Nothing
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
    Dim psw As String = String.Empty
    Private Sub CboKho_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboKho.SelectedIndexChanged
        LietKeTonKho(CboKho.SelectedValue)
        txtTon(0).Focus()
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
            myUMessager.mError(Ngonngu("Hãy đăng ký danh sách khách hàng!", "Register customer list!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If taikhoan.maso = 0 Then
            myUMessager.mError(Ngonngu("Hãy nhập số hiệu tài khoản!", "Enter account"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTon(0).Focus()
            Exit Sub
        End If
        If taikhoan.tkcon > 0 Then
            myUMessager.mError(Ngonngu("Hãy nhập số hiệu tài khoản chi tiết!", "Enter detail account!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTon(0).Focus()
            Exit Sub
        End If
        If taikhoan.tk_id <> TKCNKH_ID And taikhoan.tk_id <> TKCNPT_ID Then
            myUMessager.mError(Ngonngu("Hãy nhập tài khoản công nợ!", "Enter debt account!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTon(0).Focus()
            Exit Sub
        End If
        If ckh.MaSo = 0 Then
            myUMessager.mError(Ngonngu("Hãy nhập số hiệu khách hàng!", "Enter customer!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
            myUMessager.mError(Ngonngu("Nhập dư nợ hoặc dư có!", "Enter debt or credit!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTon(3).Focus()
            Exit Sub
        End If
        Me.Cursor = Cursors.Default
        With GrdVT
            ExecSQLNonQuery(String.Format("INSERT INTO CNDauNam (MaSo,MaTaiKhoan,MaKhachHang,DuNo_0,DuCo_0,DuNT_0,HanTT) VALUES ({0},{1},{2},{3},{4},{5},{6})", _
                                Lng_MaxValue("MaSo", "CNDauNam") + 1, _
                                ConvertToStrSafe(taikhoan.maso), _
                                ConvertToStrSafe(ckh.MaSo), _
                                CStr(tien1), _
                                ConvertToStrSafe(tien2), _
                                ConvertToStrSafe(luong), _
                                ConvertToStrSafe(ConvertToDblSafe(txtTon(6).Text))))
            .AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}", _
                         taikhoan.sohieu, _
                         Chr(9), _
                         ckh.SoHieu, _
                         ckh.Ten, _
                         Format(tien1, Mask_0), _
                         Format(tien2, Mask_0), _
                         Format(luong, Mask_2), _
                         ConvertToStrSafe(ConvertToDblSafe(txtTon(6).Text)), _
                         ConvertToStrSafe(taikhoan.maso), _
                         ConvertToStrSafe(ckh.MaSo)), NewRowIndex(GrdVT, 0))
            ckh.GhiDauKy2(taikhoan.maso)
            .Row = (.Rows - 1)
            .Col = 0
            If .CtlText = "" Then .RemoveItem(.Row)
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
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Command.Click
        Me.Close()
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        HienThongBao(Text, 1)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FKHDauKy2_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift = 4 And eventArgs.KeyCode = Keys.V) Or eventArgs.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FKHDauKy2_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            ColumnSetUp(GrdVT, 0, 1310, 0)
            ColumnSetUp(GrdVT, 1, 1310, 0)
            ColumnSetUp(GrdVT, 2, 2030, 0)
            ColumnSetUp(GrdVT, 3, 1310, 4)
            ColumnSetUp(GrdVT, 4, 1330, 4)
            ColumnSetUp(GrdVT, 5, 1300, 4)
            ColumnSetUp(GrdVT, 6, 660, 2)
            ColumnSetUp(GrdVT, 7, 1, 0)
            ColumnSetUp(GrdVT, 8, 1, 0)
            Text = SetFormTitle(Text)
            Int_RecsetToCbo("SELECT DISTINCT MaSo As F2,SoHieu + ' - '  + TenPhanLoai As F1, SoHieu FROM PhanLoaiKhachHang WHERE PLCon=0 AND LEFT(SoHieu,1)<>'#' ORDER BY SoHieu", CboKho)
            psw = Interaction.GetSetting(IniPath, "Environment", "InvPsw", )
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
    Private Sub FKHDauKy2_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
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
        Dim ms As Integer
        With GrdVT
            .Col = 0
            If .CtlText = "" Then Exit Sub
            For i As Integer = 0 To 2
                .Col = ConvertToDblSafe(i)
                txtTon(i).Text = .CtlText
            Next
            For i As Integer = 3 To 6
                .Col = ConvertToDblSafe(i)
                txtTon(i).Text = .CtlText
            Next
            .Col = 0
            txtTon_Leave(txtTon(0), New EventArgs())
            txtTon_Leave(txtTon(1), New EventArgs())
            ms = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 MaSo AS F1 FROM CNDauNam WHERE MaTaiKhoan={0} AND MaKhachHang={1} AND DuNo_0={2} AND (HanTT={3} OR HanTT=0)", _
                                                     taikhoan.maso, _
                                                     ConvertToStrSafe(ckh.MaSo), _
                                                     CStr(ConvertToDblSafe(txtTon(3).Text)), _
                                                     ConvertToStrSafe(ConvertToDblSafe(txtTon(6).Text)))))
            If ms > 0 Then ExecSQLNonQuery(String.Format("DELETE FROM CNDauNam WHERE MaSo={0}", ms))
            ckh.GhiDauKy2(taikhoan.maso)
            .RemoveItem(.Row)
            If .Rows < ConvertToDblSafe(.Tag) Then .Rows = ConvertToDblSafe(.Tag)
            txtTon(0).Focus()
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdVT_KeyPressEvent(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles GrdVT.KeyPress
        If eventArgs.KeyChar = Chr(Keys.Enter) Then GrdVT_DblClick(GrdVT, New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdVT_KeyUpEvent(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles GrdVT.KeyUp
        If eventArgs.KeyCode = 37 Or eventArgs.KeyCode = 38 Or eventArgs.KeyCode = 39 Or eventArgs.KeyCode = 40 Then SetGridIndex(GrdVT, GrdVT.Row)
        If eventArgs.KeyCode = Keys.Return Then
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
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdVT_MouseDownEvent(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles GrdVT.MouseDown
        If eventArgs.Button = MouseButtons.Right Then
            SearchObj(1, , GrdVT, GrdVT.Col)
        End If
    End Sub

    'Private Sub OsenXPButton1_Click()
    '
    'End Sub

    Private Sub txtTon_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtTon_6.Enter, _txtTon_4.Enter, _txtTon_5.Enter, _txtTon_3.Enter, _txtTon_2.Enter, _txtTon_1.Enter, _txtTon_0.Enter
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        txtTon(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtTon_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtTon_6.KeyPress, _txtTon_4.KeyPress, _txtTon_5.KeyPress, _txtTon_3.KeyPress, _txtTon_2.KeyPress, _txtTon_1.KeyPress, _txtTon_0.KeyPress
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
            Case 3, 4, 5, 6
                If KeyAscii = 13 Then
                    txtTon_Leave(txtTon(3), New EventArgs())
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
    Private Sub txtTon_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtTon_6.Leave, _txtTon_4.Leave, _txtTon_5.Leave, _txtTon_3.Leave, _txtTon_2.Leave, _txtTon_1.Leave, _txtTon_0.Leave
        Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
        'Dim luong As Double
        Select Case Index
            Case 0
                If txtTon(0).Text <> "" Then
                    taikhoan.InitTaikhoanSohieu(txtTon(0).Text)
                    txtTon(6).Enabled = (taikhoan.tk_id = TKCNKH_ID Or taikhoan.tk_id = TKCNPT_ID)
                Else
                    taikhoan.InitTaikhoanMaSo(0)
                    txtTon(6).Enabled = False
                End If
            Case 1
                If txtTon(1).Text <> "" Then
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
    '======================================================================================
    ' Thủ tục liệt kê tồn kho
    '======================================================================================
    Private Sub LietKeTonKho(ByRef mkho As Integer)
        Me.Cursor = Cursors.WaitCursor
        ClearGrid(GrdVT, ConvertToDblSafe(GrdVT.Tag))
        Dim rs_ton As DataTable = ExecSQLReturnDT(String.Format("SELECT HethongTK.MaSo,HethongTK.Kieu,HethongTK.SoHieu AS SHTK,CNDauNam.MaKhachHang,KhachHang.SoHieu,KhachHang.Ten, CNDauNam.DuNo_0 AS DuNo,CNDauNam.DuCo_0 AS DuCo,CNDauNam.DuNT_0 AS DuNT,HanTT  FROM ((CNDauNam INNER JOIN KhachHang ON CNDauNam.MaKhachHang = KhachHang.MaSo) INNER JOIN HethongTK ON CNDauNam.MaTaiKhoan=HethongTK.MaSo) INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo WHERE PhanLoaiKhachHang.SoHieu LIKE '{0}' AND (CNDauNam.DuNo_0 <> 0 OR CNDauNam.DuCo_0 <> 0) ORDER BY HethongTK.SoHieu DESC, KhachHang.SoHieu DESC", MaSo2SoHieu(mkho, "PhanLoaiKhachHang")))
        Dim rs_tonIndex As Integer = 0
        Do While rs_tonIndex < rs_ton.Rows.Count
            Dim rs_tonItem As DataRow = rs_ton.Rows(rs_tonIndex)
            rs_tonIndex += 1 ' C15 Rs LOOP CONTROL
            'GrdVT.AddItem(ConvertToStrSafe(rs_tonItem("shtk")) + Chr(9).ToString() + ConvertToStrSafe(rs_tonItem("SoHieu")) + Chr(9).ToString() + ConvertToStrSafe(rs_tonItem("ten")) + Chr(9).ToString() + Format(rs_tonItem("duno"), Mask_0) + Chr(9).ToString() + Format(rs_tonItem("duco"), Mask_0) + Chr(9).ToString() + Format(rs_tonItem("dunt"), Mask_2) + Chr(9).ToString() + ConvertToStrSafe(rs_tonItem("HanTT")) + Chr(9).ToString() + ConvertToStrSafe(rs_tonItem("MaSo")) + Chr(9).ToString() + rs_tonItem("MaKhachHang"), 0)
            'rs_ton.MoveNext()
            Dim tam As String = String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}", _
                                             ConvertToStrSafe(rs_tonItem("shtk")), _
                                             Chr(9), _
                                             ConvertToStrSafe(rs_tonItem("SoHieu")), _
                                             ConvertToStrSafe(rs_tonItem("ten")), _
                                             Format(rs_tonItem("duno"), Mask_0), _
                                             Format(rs_tonItem("duco"), Mask_0), _
                                             Format(rs_tonItem("dunt"), Mask_2), _
                                             ConvertToStrSafe(rs_tonItem("HanTT")), _
                                             ConvertToStrSafe(rs_tonItem("MaSo")), _
                                             rs_tonItem("MaKhachHang"))
            GrdVT.AddItem(tam)
        Loop
        GrdVT.Rows = IIf(rs_ton.Rows.Count > ConvertToDblSafe(GrdVT.Tag), rs_ton.Rows.Count, ConvertToDblSafe(GrdVT.Tag))
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
        'Dim duno, duco As Double
        'If CboKho.SelectedIndex >= 0 Then
        '    'duno = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoDuKhachHang.DuNo_0) As F1, Sum(SoDuKhachHang.DuCo_0) As F2 FROM (SoDuKhachHang INNER JOIN KhachHang ON SoDuKhachHang.MaKhachHang=KhachHang.MaSo) INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo WHERE PhanLoaiKhachHang.SoHieu LIKE '{0}'", MaSo2SoHieu(CboKho.SelectedValue, "PhanLoaiKhachHang")), duco))
        '    'duco = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoDuKhachHang.DuNo_0) As F2, Sum(SoDuKhachHang.DuCo_0) As F1 FROM (SoDuKhachHang INNER JOIN KhachHang ON SoDuKhachHang.MaKhachHang=KhachHang.MaSo) INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo WHERE PhanLoaiKhachHang.SoHieu LIKE '{0}'", MaSo2SoHieu(CboKho.SelectedValue, "PhanLoaiKhachHang")), duno))
        '    duno = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(cndaunam.DuNo_0) As F1, Sum(cndaunam.DuCo_0) As F2 FROM ((CNDauNam INNER JOIN KhachHang ON CNDauNam.MaKhachHang = KhachHang.MaSo) ) INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo WHERE PhanLoaiKhachHang.SoHieu LIKE '{0}' AND (CNDauNam.DuNo_0 <> 0 OR CNDauNam.DuCo_0 <> 0) ", MaSo2SoHieu(CboKho.SelectedValue, "PhanLoaiKhachHang")), duco))
        '    duco = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(cndaunam.DuCo_0) As F1, Sum(cndaunam.DuNo_0) As F2 FROM ((CNDauNam INNER JOIN KhachHang ON CNDauNam.MaKhachHang = KhachHang.MaSo) ) INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo WHERE PhanLoaiKhachHang.SoHieu LIKE '{0}' AND (CNDauNam.DuNo_0 <> 0 OR CNDauNam.DuCo_0 <> 0) ", MaSo2SoHieu(CboKho.SelectedValue, "PhanLoaiKhachHang")), duno))
        'End If
        'LbTien(0).Text = Format(duno, Mask_0)
        'LbTien(1).Text = Format(duco, Mask_0)
        Dim duno, duco As Double
        If CboKho.SelectedIndex >= 0 Then
            duno = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoDuKhachHang.DuNo_0) As F1, Sum(SoDuKhachHang.DuCo_0) As F2 FROM (SoDuKhachHang INNER JOIN KhachHang ON SoDuKhachHang.MaKhachHang=KhachHang.MaSo) INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo WHERE PhanLoaiKhachHang.MaSo ={0}", CboKho.SelectedValue), duco))
        End If
        LbTien(0).Text = Format(duno, Mask_0)
        LbTien(1).Text = Format(duco, Mask_0)
    End Sub
End Class
