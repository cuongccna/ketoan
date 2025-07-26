Imports System
Imports System.Data.Common
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter

Partial Friend Class FrmKho

    Dim flag As Integer '=1 Neu nhap moi =0 Neu dang sua
    Dim tentb As String = String.Empty
    Dim TenFL As String = String.Empty
    Dim f1 As Integer
    Dim MaChon As Integer

    ''' <summary>
    ''' Thêm, Ghi, Xóa kho
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_4.Click, _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim LstKho_NewIndex As Integer = -1
        Dim i As Integer
        Dim tenkho As String = String.Empty
        Dim mk As Integer
        Select Case Index
            Case 0
                flag = 1
                txtTenkho.Text = ""
                txtTenkho.Focus()
            Case 1
                If Strings.Len(txtTenkho.Text) = 0 Then
                    txtTenkho.Focus()
                    Exit Sub
                End If
                Me.Cursor = Cursors.WaitCursor
                Select Case flag
                    Case 1
                       
                        If ExecSQLNonQuery("INSERT INTO " & tentb & " (MaSo, " & TenFL & ") VALUES (" & ConvertToStrSafe(Lng_MaxValue("MaSo", tentb) + 1) & ",N'" & txtTenkho.Text & "')") <> 0 Then GoTo XongKho
                        Dim temp As String = txtTenkho.Text
                        Dim newItemCate As New ValueDescriptionPair(Lng_MaxValue("MaSo", tentb), temp)

                        LstKho_NewIndex = LstKho.Items.Add(newItemCate)
                        If LstKho.Items.Count > 0 Then
                            LstKho.SelectedIndex = LstKho_NewIndex
                        End If
                        ' Else
                        '      Dim strSql As String

                        '      Dim temp As Integer = IIf(LstKho.SelectedIndex = -1, 0, LstKho.SelectedIndex)
                        '      currentCate = CType(LstKho.Items(temp), ValueDescriptionPair)
                        '      strSql = "UPDATE " & tentb & " SET " & TenFL & "=N'" & txtTenkho.Text & _
                        '"' WHERE MaSo=" & ConvertToStrSafe(currentCate.Value)
                        '      If LstKho.SelectedIndex < 0 Or _
                        '  txtTenkho.Text = VB6.GetItemString(LstKho, LstKho.SelectedIndex) Or _
                        '  ExecSQLNonQuery(strSql) <> 0 Then GoTo XongKho

                        '      currentCate = New ValueDescriptionPair(currentCate.Value, txtTenkho.Text)

                        '      LstKho.Items(LstKho.SelectedIndex) = currentCate
                        '      End If
                    Case 0
                        'van.nguyen 2-Dec-2011
                        Dim strSql As String, temp As Integer
                        Dim currentCate As ValueDescriptionPair
                        currentCate = Nothing
                        If LstKho.SelectedIndex >= 0 Then
                            currentCate = LstKho.SelectedItem
                            temp = IIf(currentCate Is Nothing, 0, currentCate.Value)
                        End If
                        If temp <> 0 Then
                            strSql = "UPDATE " & tentb & " SET " & TenFL & "=N'" & txtTenkho.Text & _
                                "' WHERE MaSo=" & ConvertToStrSafe(currentCate.Value)
                            If LstKho.SelectedIndex < 0 Or _
                        txtTenkho.Text = VB6.GetItemString(LstKho, LstKho.SelectedIndex) Or _
                        ExecSQLNonQuery(strSql) <> 0 Then GoTo XongKho

                            currentCate = New ValueDescriptionPair(currentCate.Value, txtTenkho.Text)

                            LstKho.Items(LstKho.SelectedIndex) = currentCate
                        Else
                            ExecSQLNonQuery("INSERT INTO " & tentb & " (MaSo, " & TenFL & ") VALUES (" & ConvertToStrSafe(Lng_MaxValue("MaSo", tentb) + 1) & ",N'" & txtTenkho.Text & "')")
                            Dim temp1 As String = txtTenkho.Text
                            Dim newItemCate As New ValueDescriptionPair(Lng_MaxValue("MaSo", tentb), temp1)

                            LstKho_NewIndex = LstKho.Items.Add(newItemCate)
                            If LstKho.Items.Count > 0 Then
                                LstKho.SelectedIndex = LstKho_NewIndex
                            End If
                        End If
                End Select
                LstKho.Focus()
            Case 2
                Select Case flag
                    Case 0
                        Dim currentCate As ValueDescriptionPair
                        Dim temp As Integer = IIf(LstKho.SelectedIndex = -1, 0, LstKho.SelectedIndex)
                        currentCate = CType(LstKho.Items(temp), ValueDescriptionPair)

                        i = currentCate.Value
                        If i < 0 Then GoTo XongKho
                        If f1 = 1 And ConvertToDblSafe(GetSelectValue("SELECT MaSo AS F1 FROM TonKho WHERE MaSoKho=" & i)) > 0 Then
                            tenkho = FrmGetStr.GetString(Ngonngu("Chuyển các phát sinh đã có sang kho", "Transfer have arisen to stock"), My.Application.Info.ProductName)
                            mk = ConvertToDblSafe(GetSelectValue("SELECT MaSo AS F1 FROM KhoHang WHERE TenKho='" & tenkho & "'"))
                            If mk = 0 Or mk = i Then GoTo XongKho
                            Me.Cursor = Cursors.WaitCursor
                            ChuyenKho(i, mk)
                        End If
                        If f1 = 5 And pNhapKhau > 0 Then
                            Dim str1 As String = String.Format("DELETE  FROM CPGVHD WHERE MaSo=" & i)
                            ExecSQLNonQuery(str1)
                        End If
                        Select Case f1
                            Case 7
                                If ConvertToDblSafe(GetSelectValue("SELECT TOP 1 maso AS F1 FROM QuanlyNhanvien WHERE phuongxahk=" & Timten("maso", LstKho.Text, "ten", "phuongxa") & " or phuongxact=" & Timten("maso", LstKho.Text, "ten", "phuongxa"))) = 0 Then
                                    If ExecSQLNonQuery("DELETE  FROM " & tentb & " WHERE MaSo=" & ConvertToStrSafe(i)) <> 0 Then GoTo XongKho
                                Else
                                    MessageBox.Show(Ngonngu("Đã có thông tin, không xoá !", "Have this information, do not delete !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    GoTo XongKho
                                End If
                            Case 8
                                'van.nguyen 16-Nov-2011
                                If ConvertToDblSafe(GetSelectValue("SELECT TOP 1 maso AS F1 FROM QuanlyNhanvien WHERE quanhuyenhk=" & Timten("maso", LstKho.Text, "ten", "QuanHuyen") & " or quanhuyenct=" & Timten("maso", LstKho.Text, "ten", "QuanHuyen"))) = 0 Then
                                    If ExecSQLNonQuery("DELETE  FROM " & tentb & " WHERE MaSo=" & ConvertToStrSafe(i)) <> 0 Then GoTo XongKho
                                Else
                                    MessageBox.Show(Ngonngu("Đã có thông tin, không xoá !", "Have this information, do not delete !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    GoTo XongKho
                                End If
                            Case 9
                                If ConvertToDblSafe(GetSelectValue("SELECT TOP 1 maso AS F1 FROM QuanlyNhanvien WHERE tinhtphk=" & Timten("maso", LstKho.Text, "ten", "tinhtp") & " or tinhtpct=" & Timten("maso", LstKho.Text, "ten", "tinhtp"))) = 0 Then
                                    If ExecSQLNonQuery("DELETE  FROM " & tentb & " WHERE MaSo=" & ConvertToStrSafe(i)) <> 0 Then GoTo XongKho
                                Else
                                    MessageBox.Show(Ngonngu("Đã có thông tin, không xoá !", "Have this information, do not delete !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    GoTo XongKho
                                End If
                            Case 13
                                If ConvertToDblSafe(GetSelectValue("SELECT TOP 1 maso AS F1 FROM QuanlyNhanvien WHERE quoctichhk=" & Timten("maso", LstKho.Text, "ten", "quocgia") & " or quoctichct=" & Timten("maso", LstKho.Text, "ten", "quocgia"))) = 0 Then
                                    If ExecSQLNonQuery("DELETE  FROM " & tentb & " WHERE MaSo=" & ConvertToStrSafe(i)) <> 0 Then GoTo XongKho
                                Else
                                    MessageBox.Show(Ngonngu("Đã có thông tin, không xoá !", "Have this information, do not delete !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    GoTo XongKho
                                End If
                            Case Else
                                Dim sql1 As String = "DELETE FROM " & tentb & " WHERE MaSo=" & ConvertToStrSafe(i)
                                If ExecSQLNonQuery(sql1) <> 0 Then GoTo XongKho
                        End Select
                        LstKho.Items.RemoveAt(ConvertToDblSafe(LstKho.SelectedIndex))
                        LstKho.Refresh()
                        If LstKho.Items.Count > 0 Then LstKho.SelectedIndex = 0
                    Case 1
                        flag = 0
                        LstKho_SelectedIndexChanged(LstKho, New EventArgs())
                End Select
            Case 3
                If f1 = 7 Or f1 = 8 Or f1 = 9 Or f1 = 13 Then
                    If LstKho.SelectedIndex < 0 Then Exit Sub
                    MaChon = LstKho.SelectedItem.value
                End If
                Me.Close()
            Case 4
                If LstKho.SelectedIndex < 0 Then Exit Sub
                MaChon = LstKho.SelectedItem.value
        End Select
XongKho:
        Me.Cursor = Cursors.Default
    End Sub
    '====================================================================================================
    ' Xử lý phím nóng
    '====================================================================================================
    Private Sub FrmKho_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Or eventArgs.KeyCode = Keys.Enter Then
            Select Case eventArgs.KeyCode
                Case Keys.V
                    Command(3).Focus()
                Case Keys.G
                    Command(1).Focus()
                Case Keys.T
                    Command(0).Focus()
                Case Keys.X
                    Command(2).Focus()
                Case Keys.C, Keys.Return
                    If f1 = 7 Or f1 = 8 Or f1 = 9 Or f1 = 13 Or f1 = 14 Then
                        Command(4).Focus()
                        Command_ClickEvent(Command(4), New EventArgs)
                        Me.Hide()
                    End If
            End Select
        End If
        If (Shift And 2) > 0 And eventArgs.KeyCode = Keys.F And LstKho.Items.Count > 0 Then
            SearchObj(0, LstKho)
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    '====================================================================================================
    ' Khởi tạo cửa sổ
    '====================================================================================================
    Private Sub FrmKho_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            flag = 0
            If ConvertToDblSafe(Me.Tag) > 0 Then
                f1 = ConvertToDblSafe(Me.Tag)
                Me.Tag = "0"
                Select Case f1
                    Case 1
                        If pNN = 0 Then Text = Ngonngu("Danh sách kho vật tư, hàng hoá", "Stock list")
                        tentb = "KhoHang"
                        TenFL = "TenKho"
                    Case 2
                        If pNN = 0 Then Text = Ngonngu("Danh sách nước sản xuất TSCĐ", "List of Assets production")
                        tentb = "QuocGia"
                        TenFL = "Ten"
                    Case 3
                        If pNN = 0 Then Text = Ngonngu("Tình trạng sử dụng TSCĐ", "The use of Assets")
                        tentb = "TinhTrang"
                        TenFL = "Ten"
                    Case 4
                        If pNN = 0 Then Text = Ngonngu("Danh sách đơn vị quản lý TSCĐ", "List Assets management unit")
                        tentb = "DTQLy"
                        TenFL = "Ten"
                    Case 5
                        If pNN = 0 Then Text = Ngonngu("Các vụ việc liên quan của chứng từ", "Cases related voucher")
                        tentb = "DoituongCT"
                        TenFL = "DienGiai"
                    Case 6
                        If pNN = 0 Then Text = Ngonngu("Đăng ký chứng từ ghi sổ", "Registration entries in the register")
                        tentb = "CTGhiSo"
                        TenFL = "SoHieu"
                        txtTenkho.MaxLength = 20
                    Case 10, 11, 12
                        If pNN = 0 Then Text = Ngonngu("Thông tin chứng từ ", "Information voucher") & f1 - 9
                        tentb = "DoituongCT" & f1 - 9
                        TenFL = "DienGiai"
                    Case 7
                        If pNN = 0 Then Text = Ngonngu("Danh sách Phường (xã)", "List of wards")
                        tentb = "phuongxa"
                        TenFL = "Ten"
                    Case 8
                        If pNN = 0 Then Text = Ngonngu("Danh sách Quận (huyện)", "List of districts")
                        tentb = "QuanHuyen"
                        TenFL = "Ten"
                    Case 9
                        If pNN = 0 Then Text = Ngonngu("Danh sách Tỉnh (TP)", "List of provinces")
                        tentb = "tinhtp"
                        TenFL = "Ten"
                    Case 13
                        If pNN = 0 Then Text = Ngonngu("Danh sách Quốc tịch", "List of National")
                        tentb = "quocgia"
                        TenFL = "Ten"
                End Select
                ''If pNN = 0 And pKhongDau > 0 Then Me.Text = ABCtoKDau(Me.Text)

                Int_RecsetToListbox("SELECT MaSo As F2," & TenFL & " As F1 FROM " & tentb & (IIf(f1 = 5, " WHERE MaSo > 1 AND MaKhachHang=0", String.Empty)) & (IIf(f1 = 6, " WHERE MaSo > 1", String.Empty)) & " ORDER BY " & TenFL, LstKho)
                If MaChon > 0 Then
                    Select Case f1
                        Case 10
                            Text = Text & " liên quan"
                            Me.Top = Screen.PrimaryScreen.Bounds.Height / 2
                            Me.Left = Screen.PrimaryScreen.Bounds.Width / 2
                            SetListIndex(LstKho, MaChon)
                        Case 13, 7, 8, 9
                            SetListIndex(LstKho, MaChon)
                    End Select
                End If
            End If
            Khoaquyen()
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
    Private Sub LstKho_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles LstKho.SelectedIndexChanged
        flag = 0
        txtTenkho.Text = VB6.GetItemString(LstKho, LstKho.SelectedIndex)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub LstKho_MouseDown(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles LstKho.MouseDown
        Dim Button As Integer = ConvertToDblSafe(eventArgs.Button)
        Dim Shift As Integer = Control.ModifierKeys \ &H10000
        Dim X As Single = (eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        Dim m As Integer
        Dim shtk As String = String.Empty
        Dim TK As ClsTaikhoan
        '  If Button = 2097152 And LstKho.SelectedIndex >= 0 And flag = 0 And f1 = 1 And pGiaVon > 0 Then
        If eventArgs.Button = MouseButtons.Right And LstKho.SelectedIndex >= 0 And flag = 0 And f1 = 1 And pGiaVon > 0 Then
            TK = New ClsTaikhoan()
            If LstKho.Items.Count > 0 Then
                m = LstKho.SelectedIndex
            End If

            shtk = ConvertToStrSafe(GetSelectValue("SELECT HethongTK.SoHieu AS F1 FROM KhoHang INNER JOIN HethongTK ON KhoHang.MaTKGV=HethongTK.MaSo WHERE KhoHang.MaSo=" & m))
            If shtk = "0" Then shtk = ""
            shtk = FrmGetStr.GetString(Ngonngu("Số hiệu tài khoản tính giá vốn tự động: ", "Account number calculated cost automatic: "), My.Application.Info.ProductName, shtk)
            TK.InitTaikhoanSohieu(shtk)
            If (TK.maso > 0 And TK.tkcon = 0 And TK.tk_id <> TKVT_ID And TK.tk_id <> TKDT_ID And TK.tk_id <> GTGTKT_ID And TK.tk_id <> GTGTPN_ID) Or (shtk.ToUpper() = "0") Then
                ExecSQLNonQuery("UPDATE KhoHang SET MaTKGV=" & TK.maso & " WHERE MaSo=" & ConvertToStrSafe(m))
            Else
                If shtk.Length > 0 Then ErrMsg(er_SHTaiKhoan1)
            End If
            shtk = ConvertToStrSafe(GetSelectValue("SELECT HethongTK.SoHieu AS F1 FROM KhoHang INNER JOIN HethongTK ON KhoHang.MaTK=HethongTK.MaSo WHERE KhoHang.MaSo=" & m))
            If shtk = "0" Then shtk = ""
            shtk = FrmGetStr.GetString(Ngonngu("Số hiệu tài khoản tính giá vốn tự động hàng khuyến mãi: ", "Account number calculated cost of automatic promotion: "), My.Application.Info.ProductName, shtk)
            TK.InitTaikhoanSohieu(shtk)
            If (TK.maso > 0 And TK.tkcon = 0 And TK.tk_id <> TKVT_ID And TK.tk_id <> TKDT_ID And TK.tk_id <> GTGTKT_ID And TK.tk_id <> GTGTPN_ID) Or (shtk.ToUpper() = "0") Then
                ExecSQLNonQuery("UPDATE KhoHang SET MaTK=" & TK.maso & " WHERE MaSo=" & ConvertToStrSafe(m))
            Else
                If shtk.Length > 0 Then ErrMsg(er_SHTaiKhoan1)
            End If
            TK = Nothing
        End If
        Dim f As FrmKho
        If eventArgs.Button = MouseButtons.Right And LstKho.SelectedIndex >= 0 And flag = 0 And f1 = 11 Then
            f = New FrmKho()
            m = ConvertToDblSafe(GetSelectValue("SELECT MaKhachHang AS F1 FROM DoituongCT2 WHERE MaSo=" & LstKho.SelectedIndex))
            m = f.ChonKho(10, m)
            If m > 0 Then ExecSQLNonQuery("UPDATE DoiTuongCT2 SET MaKhachHang=" & m & " WHERE MaSo=" & ConvertToStrSafe(LstKho.SelectedIndex))
            f = Nothing
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtTenkho_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtTenkho.Enter
        txtTenkho.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="mc"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ChonKho(ByRef id As Integer, ByRef mc As Integer) As Integer
        Dim result As Integer = 0
        Me.Tag = ConvertToStrSafe(id)
        If id <> 7 And id <> 8 And id <> 9 And id <> 13 And id <> 16 Then
            Command(4).Visible = True
            For i As Integer = 0 To 2
                Command(i).Visible = False
            Next
        End If
        MaChon = mc
        Me.ShowDialog()
        result = MaChon
        Int_RecsetToCbo("SELECT DISTINCT Ten As F1,maso as f2 FROM quocgia ORDER BY maso", FrmQuanLyNhanVien.CboQuoctich)
        Return result
    End Function
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(1).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        Command(2).Enabled = (User_Right <> 2 Or (UserID = uid))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmKho_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
