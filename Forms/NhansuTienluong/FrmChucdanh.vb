Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmChucdanh
    Dim ThemMoi As Integer ' =1 neu them moi, -1 neu sua cu
    Private _onv As ClsChucDanh = Nothing
    Dim currentSelectIndex As Integer = -2

    Property onv() As ClsChucDanh
        Get
            If _onv Is Nothing Then
                _onv = New ClsChucDanh()
            End If
            Return _onv
        End Get
        Set(ByVal Value As ClsChucDanh)
            _onv = Value
        End Set
    End Property ' vat tu duoc tham chieu
    Dim doiloai As Integer ' =1 neu co thay doi loai vat tu dang sua doi
    Dim MaDaTim As Integer
    Dim NgayApdung As Date
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Tinhluongthang()
        Try
            If CboLuong.SelectedIndex = 0 Then
                txtVT(17).Text = Format(ConvertToDblSafe(timtenmax(String.Format("HSB{0}", CboBacluong.Text), ConvertToStrSafe(CboChucvu.SelectedValue), "maso", "Chucvu")) * ConvertToDblSafe((GetSelectValue("SELECT lcb as f1 FROM license"))), Mask_0)
            Else
                If CboLuong.SelectedIndex = 1 Then
                    txtVT(17).Text = Format(ConvertToDblSafe(timtenmax(String.Format("MLB{0}", CboBacluong.Text), ConvertToStrSafe(CboChucvu.SelectedValue), "maso", "Chucvu")), Mask_0)
                Else
                    If CboLuong.SelectedIndex = 2 Then
                        txtVT(17).Text = Format(ConvertToDblSafe(timtenmax(String.Format("TVB{0}", CboBacluong.Text), ConvertToStrSafe(CboChucvu.SelectedValue), "maso", "Chucvu")), Mask_0)
                    Else
                        If CboLuong.SelectedIndex = 3 Then txtVT(17).Text = Format(ConvertToDblSafe(timtenmax(String.Format("LNB{0}", CboBacluong.Text), ConvertToStrSafe(CboChucvu.SelectedValue), "maso", "Chucvu")), Mask_0)
                    End If
                End If
            End If
        Catch exc As System.Exception
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboChucvu_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles CboChucvu.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        If CboChucvu.Items.Count > 0 Then If KeyAscii = 13 Then CboChucvu.SelectedIndex = FrmChucvu.ChonChucvu(Timten("sohieu", ConvertToStrSafe(CboChucvu.SelectedIndex + 1), "maso", "chucvu"))
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
    Private Sub CboLuong_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboLuong.SelectedIndexChanged
        Tinhluongthang()
        If CboLuong.Items.Count > 0 Then Label(25).Text = IIf(CboLuong.SelectedIndex = 3, "Ngày", "Tháng")
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboBacluong_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboBacluong.SelectedIndexChanged
        Tinhluongthang()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboChucvu_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboChucvu.SelectedIndexChanged
        Tinhluongthang()
    End Sub
    ''' <summary>
    ''' Liet ke cac vat tu trong loai vat tu duoc chon
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboLoai_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboLoai.SelectedIndexChanged
        If ThemMoi <> -1 Then
            Me.Cursor = Cursors.WaitCursor
            Dim sql As String = String.Format("SELECT t1.MaSo As F2, t2.SoHieu + ' - ' + t2.Ten As F1 FROM Chucdanh t1 inner join quanlynhanvien t2 on t1.nhanvien=t2.sohieu WHERE (nam<{0} or (t1.nam={0} and t1.thang<={1})) and t2.MaPhanLoai={2} ORDER BY t2.sohieu,t1.nam desc,t1.thang desc", _
                                    IIf(CboThang.SelectedValue < pThangDauKy, ConvertToIntSafe(frmMain._LbCty_7.Text) + 1, frmMain._LbCty_7.Text), _
                                    ConvertToStrSafe(CboThang.SelectedValue), _
                                    IIf(ConvertToStrSafe(CboLoai.SelectedValue) = String.Empty, -1, ConvertToStrSafe(CboLoai.SelectedValue)))
            Int_RecsetToListbox(sql, LstVt)
            ThemMoi = 0
            doiloai = 0
            currentSelectIndex = -2
            Me.Cursor = Cursors.Default
        Else
            doiloai = 1
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Addcboluong()
        Dim CboLuong_NewIndex As Integer = -1
        CboLuong.Items.Add("Lương hệ số", 1)
        CboLuong.Items.Add("Lương tháng", 2)
        CboLuong.Items.Add("Lương thời vụ", 3)
        CboLuong.Items.Add("Lương ngày", 4)
        If CboLuong.Items.Count > 0 Then CboLuong.SelectedIndex = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AddCboBacluong()
        Dim CboBacluong_NewIndex As Integer = -1
        For i As Integer = 1 To 5
            CboBacluong.Items.Add(ConvertToStrSafe(i), i)
        Next
        If CboBacluong.Items.Count > 0 Then CboBacluong.SelectedIndex = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboThang_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboThang.SelectedIndexChanged
        Dim vitri As Integer = LstVt.SelectedIndex
        Try
            CboLoai_SelectedIndexChanged(CboLoai, New EventArgs())
        Catch
        End Try
        If vitri < LstVt.Items.Count And LstVt.Items.Count > 0 Then LstVt.SelectedIndex = vitri
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_4.Click, _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim vt As New ClsQuanLyNhanVien
        Dim i As Integer
        If (User_Right = 2) And (Index < 3) Then
            HienThongBao("Không có quyền truy cập!", 1)
            GoTo XongVT
        End If
        Me.Cursor = Cursors.WaitCursor
        If Index < 3 Then
            If CboLoai.SelectedIndex < 0 Then
                ErrMsg(er_PhanLoai)
                GoTo XongVT
            End If
        End If
        'Dim rs As DataTable
        Dim Ngay As Date
        Select Case Index
            Case 0
                CboThang.Focus()
                ThemMoi = 1
                MedNgayApdung.Text = FormatDate(DateSerial(pNamTC, CboThang.SelectedValue, 1))
                NgayApdung = ConvertToDateSafe(MedNgayApdung.Text)
                Khoaquyen()
            Case 1
                Select Case ThemMoi
                    Case 1
                        If Not KiemTraSoLieu() Then GoTo XongVT
                        If onv.GhiNV() = 0 Then
                            CboThang_SelectedIndexChanged(CboThang, New EventArgs())
                        Else
                            ErrMsg(er_SoHieu)
                            vt.InitNVSoHieu(Timten("sohieu", txtVT(1).Text, "ten", "quanlynhanvien"))
                            If vt.MaPhanLoai = CboLoai.SelectedValue Then
                                SetListIndex(LstVt, vt.MaSo)
                            End If
                        End If
                        ThemMoi = 0
                    Case 0
                        Dim currentCate As ValueDescriptionPair
                        Dim temp As Integer = IIf(LstVt.SelectedIndex = -1, 0, LstVt.SelectedIndex)
                        currentCate = CType(LstVt.Items(temp), ValueDescriptionPair)


                        If currentCate.Value < 0 Or Not KiemTraSoLieu() Then GoTo XongVT
                        If onv.SuaNV() = 0 Then
                            If doiloai = 1 Then
                                CboLoai_SelectedIndexChanged(CboLoai, New EventArgs())
                                doiloai = 0
                            Else
                                'VB6.SetItemString(LstVt, LstVt.SelectedIndex, String.Format("{0} - {1}", onv.Nhanvien, Timten("ten", onv.Nhanvien, "sohieu", "quanlynhanvien")))
                                currentCate = CType(LstVt.SelectedItem, ValueDescriptionPair)
                                Dim newItemCate As New ValueDescriptionPair(currentCate.Value, String.Format("{0} - {1}", onv.Nhanvien, Timten("ten", onv.Nhanvien, "sohieu", "quanlynhanvien")))
                                LstVt.Items(LstVt.SelectedIndex) = newItemCate
                            End If
                        Else
                            vt.InitNVSoHieu(txtVT(0).Text)
                            ErrMsg(er_SoHieu)
                            If vt.MaPhanLoai = CboLoai.SelectedValue Then SetListIndex(LstVt, vt.MaSo)
                        End If
                End Select
                LstVt.Focus()
            Case 2
                i = LstVt.SelectedIndex
                If i < 0 Then GoTo XongVT
                If onv.XoaNV() = 0 Then
                    LstVt.Items.RemoveAt(ConvertToDblSafe(i))
                    If LstVt.Items.Count > 0 Then LstVt.SelectedIndex = i - 1
                Else
                    ErrMsg(er_CoPS1)
                End If
                LstVt.Focus()
                CboLoai_SelectedIndexChanged(CboLoai, New EventArgs())
                LstVt_SelectedIndexChanged(LstVt, New EventArgs())
            Case 3
                Me.Close() : Exit Sub
            Case 4
                Ngay = ConvertToDateSafe((GetSelectValue(String.Format("SELECT min(ngayapdung) as f1 FROM Chucdanh WHERE nhanvien=N'{0}'", onv.Nhanvien))))
                i = DateTime.FromOADate((DateSerial(pNamTC, 12, 31) - Ngay).TotalDays).Month
                i = IIf(i >= 12, 100, i * 100 / 12)
                txtVT(0).Text = ConvertToStrSafe(i)
        End Select
XongVT:
        vt = Nothing
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        If ConvertToDblSafe(Me.Tag) < 0 Then
            SetListIndex(CboLoai, -ConvertToDblSafe(Me.Tag))
            Me.Tag = "0"
        End If
        If ThemMoi = 0 And ConvertToDblSafe(Me.Tag) = 1 Then LstVt.Focus()
        LstVt_SelectedIndexChanged(LstVt, New EventArgs())
        Khoaquyen()
    End Sub
    ''' <summary>
    ''' Xu ly cac phim nong
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmChucdanh_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case KeyCode
                Case Keys.V
                    Command(3).Focus()
                    Command_ClickEvent(Command(3), New EventArgs())
                Case Keys.D
                    Command(0).Focus()
                    Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.X
                    Command(2).Focus()
                    Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.G
                    Command(1).Focus()
                    Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.C
                    Command(4).Focus()
                    Command_ClickEvent(Command(4), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Command_ClickEvent(Command(3), New EventArgs())
    End Sub
    ''' <summary>
    ''' Khoi tao form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmChucdanh_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        'set icon
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
        ' Init form 
        Call FormInit()

        Dim X As Integer
        Dim rs As DataTable
        If Not TruongDaCo("Chucdanh", "thang13") Then
            ExecSQLNonQuery("alter table Chucdanh add thang13 integer null")
            rs = ExecSQLReturnDT("SELECT nhanvien,min(ngayapdung) as ngay FROM Chucdanh group by nhanvien")
            For Each rsItem As DataRow In rs.Rows
                X = Math.Abs(DateDiff(DateInterval.Month, DateSerial(pNamTC, 12, 31), ConvertToDateSafe(rsItem("Ngay"))))
                X = IIf(X >= 12, 100, X * 100 / 12)
                ExecSQLNonQuery(String.Format("UPDATE Chucdanh set thang13={0} WHERE nhanvien=N'{1}'", _
                                    X, _
                                    rsItem("Nhanvien")))
            Next
        End If
        AddMonthToCbo(CboThang)
        If CboThang.Items.Count > 0 Then
            CboThang.SelectedIndex = Today.Month - 1
        End If
        ThemMoi = 0
        doiloai = 0
        Int_RecsetToCbo("SELECT DISTINCT Ten As F1,maso as f2 FROM chucvu ORDER BY maso", CboChucvu)
        AddCboBacluong()
        Addcboluong()
        Text = SetFormTitle(Text)
        Int_RecsetToCbo("SELECT DISTINCT MaSo As F2,SoHieu + ' - '  + Ten As F1, SoHieu FROM PhanLoaiQuanLyNhanVien WHERE maso not in (select captren from phanloaiquanlynhanvien) ORDER BY MaSo ,SoHieu", CboLoai)
        InitDateVars(MedNgayApdung, NgayApdung)

        If CboLoai.Items.Count > 0 Then CboLoai.SelectedIndex = 0

        SetFont(Me)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmChucdanh_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        onv = Nothing
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' Khoi tao vat tu duoc chon
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub LstVt_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles LstVt.SelectedIndexChanged
        currentSelectIndex = LstVt.SelectedIndex
        Try
            Dim currentCate As ValueDescriptionPair
            If LstVt.SelectedIndex >= 0 Then
                Dim index As Integer = IIf(LstVt.SelectedIndex = -1, 0, LstVt.SelectedIndex)
                currentCate = CType(LstVt.Items(index), ValueDescriptionPair)
                onv.InitMaSo(currentCate.Value)
                ShowChitiet(onv)
                If CboThang.SelectedIndex = -1 And CboThang.Items.Count > 0 Then
                    CboThang.SelectedIndex = Today.Month - 1
                End If
            End If
        Catch
            txtVT(1).Text = "..."
            txtVT(17).Text = ""
            If CboBacluong.Items.Count > 0 Then CboBacluong.SelectedIndex = 0
            txtVT(1).Focus()
        End Try
    End Sub
    ''' <summary>
    ''' Thu tuc hien thong tin chi tiet
    ''' </summary>
    ''' <param name="otk"></param>
    ''' <remarks></remarks>
    Private Sub ShowChitiet(ByRef otk As ClsChucDanh)
        txtVT(1).Text = Timten("ten", onv.Nhanvien, "sohieu", "quanlynhanvien")
        txtVT(0).Text = ConvertToStrSafe(onv.thang13)
        CboBacluong.Text = ConvertToStrSafe(onv.BacLuong)
        SetListIndex(CboChucvu, onv.chucvu)
        NgayApdung = onv.NgayApdung
        MedNgayApdung.Text = Format(NgayApdung, Mask_D)
        If CboLuong.Items.Count > 0 Then CboLuong.SelectedIndex = onv.LoaiLuong - 1
    End Sub
    ''' <summary>
    ''' Thu tuc kiem tra va dua so lieu vao object
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function KiemTraSoLieu() As Boolean
        Dim result As Boolean = False
        Dim n As Integer
        Dim rs As DataTable
        Try
            'van.nguyen 20-Nov-2011
            Dim currentCate As ValueDescriptionPair
            Dim index As Integer = IIf(LstVt.SelectedIndex = -1, 0, LstVt.SelectedIndex)
            currentCate = CType(LstVt.Items(index), ValueDescriptionPair)

            With onv
                If ThemMoi = 1 Then .maso = 0
                .chucvu = CboChucvu.SelectedValue
                .Nhanvien = Timten("Nhanvien", ConvertToStrSafe(currentCate.Value), "Maso", "Chucdanh")
                .NgayApdung = NgayApdung
                If CboLuong.Items.Count > 0 Then .LoaiLuong = CboLuong.SelectedValue
                .BacLuong = ConvertToDblSafe(CboBacluong.Text)
                .thang = NgayApdung.Month
                .thang13 = ConvertToDblSafe(txtVT(0).Text)

                .Nam = NgayApdung.Year
                Tinhluongthang()
                rs = ExecSQLReturnDT(String.Format("SELECT * FROM chucvu WHERE maso={0}", CboChucvu.SelectedValue))
                n = CboLuong.SelectedIndex * 5 + 3
                If rs.Rows.Count > 0 Then
                    Dim rsItem As DataRow = rs.Rows(0)
                    For i As Integer = n To n + .BacLuong - 1
                        If ConvertToDblSafe(rsItem(i)) = 0 Then
                            MessageBox.Show(String.Format("Chức vụ đã chọn chưa có lương theo loại hình này !{0}Vui lòng cập nhật thêm loại hình lương này vào chức vụ !", Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtVT(17).Text = ""
                            Return result
                        End If
                    Next
                End If
            End With
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtF_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtF.Enter
        txtF.SelectAll()
        MaDaTim = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtVT_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtVT_0.Enter, _txtVT_17.Enter, _txtVT_1.Enter
        Dim Index As Integer = Array.IndexOf(txtVT, eventSender)
        txtVT(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgayApdung_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MedNgayApdung.Enter
        MedNgayApdung.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgayApdung_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MedNgayApdung.Leave
        If Information.IsDate(MedNgayApdung.Text) Then
            NgayApdung = ConvertToDateSafe(MedNgayApdung.Text)
        Else
            MedNgayApdung.Focus()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtVT_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtVT_0.KeyPress, _txtVT_17.KeyPress, _txtVT_1.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtVT, eventSender)
        If KeyAscii = 13 And Index = 1 Then
            txtVT(Index).Text = Timten("ten", FrmQuanLyNhanVien.ChonNV(Timten("sohieu", txtVT(Index).Text, "ten", "quanlynhanvien")), "sohieu", "quanlynhanvien")
        End If
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="uid"></param>
    ''' <remarks></remarks>
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(1).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        Command(2).Enabled = (User_Right <> 2 Or (UserID = uid))
        If User_Right <> 0 Then
            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT Lock{0} % 10 AS F1 FROM License", CboThang.SelectedValue))) > 0 Then
                Command(1).Enabled = False
                Command(2).Enabled = False
            End If
        End If
    End Sub
End Class
