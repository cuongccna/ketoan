Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmQuanLyNhanVien
    Dim ThemMoi As Integer ' =1 neu them moi, -1 neu sua cu
    Private _onv As ClsQuanLyNhanVien = Nothing
    Dim lstSlIndex As Integer = -2
    Dim TenBang As String = String.Empty

    Property onv() As ClsQuanLyNhanVien
        Get
            If _onv Is Nothing Then
                _onv = New ClsQuanLyNhanVien()
            End If
            Return _onv
        End Get
        Set(ByVal Value As ClsQuanLyNhanVien)
            _onv = Value
        End Set
    End Property ' vat tu duoc tham chieu
    Dim doiloai As Integer ' =1 neu co thay doi loai vat tu dang sua doi
    Dim MaDaTim As Integer
    Dim Ngay As Date
    Dim Ngaycap As Date
    Dim Nghi As Date
    Dim Thaisan0 As Date
    Dim Thaisan1 As Date
    Dim The0 As Date
    Dim The1 As Date
    Dim kt As Integer
    Dim chi_so As Integer

    Private Sub FrmQuanLyNhanVien_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        'set icon
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
        ' Init form 
        Call FormInit()

        ThemMoi = 0
        doiloai = 0
        AddCboBacluong()
        Addcboluong()
        AddCbo()
        AddCboHD()

        Text = SetFormTitle(Ngonngu("Danh sách Nhân viên Công Ty", "List of Employees"))
        Int_RecsetToCbo("SELECT DISTINCT MaSo As F2,SoHieu + ' - '  + Ten As F1 FROM PhanLoaiQuanLyNhanVien WHERE maso not in (select captren from phanloaiquanlynhanvien) ORDER BY MaSo ,F1", CboLoai)

        For chi_so As Integer = 0 To 5
            AddMonthToCbo(CboThang(chi_so))
            If CboThang(chi_so).Items.Count > 0 Then CboThang(chi_so).SelectedIndex = DateTime.Now.Month - 1
        Next

        InitDateVars(MedNgay, Ngay)
        InitDateVars(MedNgaycap, Ngaycap)
        InitDateVars(Ngaynghi, Nghi)
        InitDateVars(Thaisan(0), Thaisan0)
        InitDateVars(Thaisan(1), Thaisan1)
        LstVt_SelectedIndexChanged(LstVt, New EventArgs())
        SetFont(Me)

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Tinhluongthang()
        Try
            If CboLuong.SelectedIndex = 0 Then
                txtVT(17).Text = Format(ConvertToDblSafe(timtenmax("HSB" & CboBacluong.Text, ConvertToStrSafe(CboChucvu.SelectedValue), "maso", "Chucvu")) * ConvertToDblSafe((GetSelectValue("SELECT lcb as f1 FROM license"))), Mask_0)
            Else
                If CboLuong.SelectedIndex = 1 Then
                    txtVT(17).Text = Format(ConvertToDblSafe(timtenmax("MLB" & CboBacluong.Text, ConvertToStrSafe(CboChucvu.SelectedValue), "maso", "Chucvu")), Mask_0)
                Else
                    If CboLuong.SelectedIndex = 2 Then
                        txtVT(17).Text = Format(ConvertToDblSafe(timtenmax("TVB" & CboBacluong.Text, ConvertToStrSafe(CboChucvu.SelectedValue), "maso", "Chucvu")), Mask_0)
                    Else
                        If CboLuong.SelectedIndex = 3 Then txtVT(17).Text = Format(ConvertToDblSafe(timtenmax("LNB" & CboBacluong.Text, ConvertToStrSafe(CboChucvu.SelectedValue), "maso", "Chucvu")), Mask_0)
                    End If
                End If
            End If
        Catch exc As System.Exception
            'Resume in On-Error-Resume-Next Block
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
        If KeyAscii = 13 And CboChucvu.Items.Count > 0 Then CboChucvu.SelectedIndex = FrmChucvu.ChonChucvu(Timten("sohieu", ConvertToStrSafe(CboChucvu.SelectedIndex + 1), "maso", "chucvu"))
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
            Int_RecsetToListbox(String.Format("SELECT MaSo As F2, SoHieu + ' - ' + Ten As F1 FROM QuanLyNhanVien WHERE MaPhanLoai={0} ORDER BY SoHieu", CboLoai.SelectedValue), LstVt)

            If LstVt.Items.Count > 0 Then
                LstVt.SelectedIndex = 0
            Else
                clearInfo()
            End If

            ThemMoi = 0
            doiloai = 0
            Me.Cursor = Cursors.Default
        Else
            doiloai = 1
        End If
        lstSlIndex = -2
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AddCbo()
        Cbo.Items.Add("Nam")
        Cbo.Items.Add("Nữ")
        Cbo.SelectedIndex = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AddCboHD()
        CboHD.Items.Add("Không thời hạn", 1)
        CboHD.Items.Add("Từ 12 - 36 tháng", 2)
        CboHD.Items.Add("Dưới 12 tháng", 3)
        CboHD.SelectedIndex = 0
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

        CboLuong.SelectedIndex = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AddCboBacluong()
        Dim CboBacluong_NewIndex As Integer = -1
        For i As Integer = 1 To 5
            CboBacluong_NewIndex = CboBacluong.Items.Add(ConvertToStrSafe(i), i)

        Next
        If CboBacluong.Items.Count > 0 Then CboBacluong.SelectedIndex = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboQuoctich_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboQuoctich.SelectedIndexChanged
        If CboQuoctich.Text = "Việt Nam" Then
            Frame3.Text = "CMND"
        Else
            If CboQuoctich.Text = "" Or CboQuoctich.Text = "..." Then
                Frame3.Text = "CMND(hộ chiếu)"
            Else
                Frame3.Text = "hộ chiếu"
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboQuoctich_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles CboQuoctich.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        If KeyAscii = 13 And CboQuoctich.Items.Count > 0 Then CboQuoctich.SelectedIndex = FrmKho.ChonKho(13, CboQuoctich.SelectedValue) - 1
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
    Private Sub Chk_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Chk.CheckStateChanged
        Ngaynghi.Visible = Chk.CheckState
        CboThang(1).Visible = Chk.CheckState = CheckState.Unchecked
        Label(27).Visible = Chk.CheckState = CheckState.Unchecked
        ChkGiam.Visible = (ChkThaisan.CheckState = CheckState.Checked Or Chk.CheckState = CheckState.Checked) And (ChkBaohiem.CheckState = CheckState.Unchecked Or ChkTangBH.CheckState = CheckState.Checked)
        '    ChkThaisan.Visible = Chk.Value = 0
        If Not ChkGiam.Visible Then
            ChkGiam.CheckState = CheckState.Unchecked
            LDThang.Visible = False
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub ChkBaohiem_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles ChkBaohiem.CheckStateChanged
        ChkGiam.Visible = (ChkThaisan.CheckState = CheckState.Checked Or Chk.CheckState = CheckState.Checked) And (ChkBaohiem.CheckState = CheckState.Unchecked Or ChkTangBH.CheckState = CheckState.Checked)
        If Not ChkGiam.Visible Then
            ChkGiam.CheckState = CheckState.Unchecked
            LDThang.Visible = False
        End If
        If ChkBaohiem.CheckState Then
            ChkTangBH.Visible = True
            CboThang(5).Visible = True
        Else
            ChkTangBH.CheckState = CheckState.Unchecked
            ChkTangBH.Visible = False
            CboThang(5).Visible = False
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub ChkGiam_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles ChkGiam.CheckStateChanged
        If ChkGiam.CheckState Then
            '        ChkGiam.Visible = True
            LDThang.Visible = True
            CboThang(1).Visible = Chk.CheckState = CheckState.Unchecked
            Label(27).Visible = Chk.CheckState = CheckState.Unchecked
            If Chk.CheckState = CheckState.Checked Then ChkThe.Visible = True
        Else
            ChkThe.CheckState = CheckState.Unchecked
            '        ChkGiam.Visible = False
            LDThang.Visible = False
            ChkThe.Visible = False
            Frame4.Visible = False
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub ChkTang_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles ChkTang.CheckStateChanged
        CboThang(2).Visible = ChkTang.CheckState
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub ChkTangBH_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles ChkTangBH.CheckStateChanged
        ChkGiam.Visible = (ChkThaisan.CheckState = CheckState.Checked Or Chk.CheckState = CheckState.Checked) And (ChkBaohiem.CheckState = CheckState.Unchecked Or ChkTangBH.CheckState = CheckState.Checked)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub ChkThaisan_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles ChkThaisan.CheckStateChanged
        ThaisanNgay.Visible = ChkThaisan.CheckState
        ChkGiam.Visible = (ChkThaisan.CheckState = CheckState.Checked Or Chk.CheckState = CheckState.Checked) And (ChkBaohiem.CheckState = CheckState.Unchecked Or ChkTangBH.CheckState = CheckState.Checked)
        '    Chk.Visible = ChkThaisan.Value = 0
        If Not ChkGiam.Visible Then
            ChkGiam.CheckState = CheckState.Unchecked : LDThang.Visible = False
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub ChkThe_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles ChkThe.CheckStateChanged
        If ChkThe.CheckState Then
            Frame4.Visible = True
            If CboThang(3).Items.Count > 0 Then CboThang(3).SelectedIndex = CboThang(0).SelectedIndex
            If CboThang(4).Items.Count > 0 Then CboThang(4).SelectedIndex = CboThang(0).SelectedIndex
        Else
            Frame4.Visible = False
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_0.Click, _Command_1.Click, _Command_2.Click, _Command_3.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim LstVt_NewIndex As Integer = -1
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
        Select Case Index
            Case 0
                txtVT(0).Text = SoHieuVTMoi(CboLoai.SelectedValue, 6, IIf(CboLoai.SelectedValue = 0, 0, CboLoai.SelectedValue - 1))
                For i = 1 To 15
                    If i <> 5 And i <> 10 Then txtVT(i).Text = "..."
                Next
                txtVT(0).Focus()
                Chk.CheckState = CheckState.Unchecked
                ChkTang.CheckState = CheckState.Unchecked
                ChkBaohiem.CheckState = CheckState.Unchecked
                ChkThaisan.CheckState = CheckState.Unchecked
                ThemMoi = 1
                Khoaquyen()
            Case 1
                Select Case ThemMoi
                    Case 1
                        If Not KiemTraSoLieu() Then GoTo XongVT
                        If onv.GhiNV() = 0 Then
                            Dim temp As String = String.Format("{0} - {1}", onv.SoHieu, onv.ten)
                            Dim newItemCate As New ValueDescriptionPair(onv.MaSo, temp)

                            LstVt_NewIndex = LstVt.Items.Add(newItemCate)
                            If LstVt.Items.Count > 0 Then LstVt.SelectedIndex = LstVt_NewIndex

                        Else
                            ErrMsg(er_SoHieu)
                            vt.InitNVSoHieu(txtVT(0).Text)
                            If vt.MaPhanLoai = CboLoai.SelectedIndex Then
                                SetListIndex(LstVt, vt.MaSo)
                            End If
                        End If
                        ThemMoi = 0
                    Case 0
                        Dim currentCate As ValueDescriptionPair
                        Dim temp As Integer = IIf(LstVt.SelectedIndex = -1, 0, LstVt.SelectedIndex)
                        If temp <> 0 Then
                            currentCate = CType(LstVt.Items(temp), ValueDescriptionPair)
                            If currentCate.Value < 0 Or Not KiemTraSoLieu() Then GoTo XongVT
                        End If
                        If Not KiemTraSoLieu() Then GoTo XongVT
                        If onv.SuaNV() = 0 Then
                            If doiloai = 1 Then
                                CboLoai_SelectedIndexChanged(CboLoai, New EventArgs())
                                doiloai = 0
                            Else
                                'VB6.SetItemString(LstVt, LstVt.SelectedIndex, onv.SoHieu & " - " & onv.ten)
                                currentCate = CType(LstVt.SelectedItem, ValueDescriptionPair)
                                If currentCate IsNot Nothing Then
                                    Dim newItemCate As New ValueDescriptionPair(currentCate.Value, String.Format("{0} - {1}", onv.SoHieu, onv.ten))
                                    LstVt.Items(LstVt.SelectedIndex) = newItemCate
                                End If
                            End If
                        Else
                            vt.InitNVSoHieu(txtVT(0).Text)
                            '                        ErrMsg er_SoHieu
                            If vt.MaPhanLoai = CboLoai.SelectedIndex Then SetListIndex(LstVt, vt.MaSo)
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
        '    Chk.Value = 0
        Int_RecsetToCbo("SELECT DISTINCT Ten As F1,maso as f2 FROM chucvu ORDER BY maso", CboChucvu)
        Int_RecsetToCbo("SELECT DISTINCT Ten As F1,maso as f2 FROM quocgia ORDER BY maso", CboQuoctich)
        Khoaquyen()
    End Sub
    ''' <summary>
    ''' Xu ly cac phim nong
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmQuanLyNhanVien_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.V
                    Command(3).Focus()
                    ' Command_ClickEvent(Command(3), New EventArgs())
                Case Keys.T
                    Command(0).Focus()
                    ' Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.X
                    Command(2).Focus()
                    ' Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.G
                    Command(1).Focus()
                    ' Command_ClickEvent(Command(1), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Command_ClickEvent(Command(3), New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmQuanLyNhanVien_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
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
        If lstSlIndex <> LstVt.SelectedIndex Then
            lstSlIndex = LstVt.SelectedIndex

            Try
                Dim index As Integer = 0
                Dim currentCate As ValueDescriptionPair
                currentCate = CType(LstVt.Items(lstSlIndex), ValueDescriptionPair)
                onv.InitNVMaSo(currentCate.Value)
                ShowChitiet(onv)
            Catch
                For i As Integer = 0 To 15
                    If i <> 5 And i <> 10 Then txtVT(i).Text = "..."
                Next
                txtVT(17).Text = ""
                If Cbo.Items.ItemsBase.Count > 0 Then Cbo.SelectedIndex = 0
                If CboBacluong.Items.ItemsBase.Count > 0 Then CboBacluong.SelectedIndex = 0
                If CboQuoctich.Items.ItemsBase.Count > 0 Then CboQuoctich.SelectedIndex = 0
                If CboChucvu.Items.ItemsBase.Count > 0 Then CboChucvu.SelectedIndex = 0
                txtVT(0).Focus()
            End Try
        End If
    End Sub
    ''' <summary>
    ''' Thu tuc hien thong tin chi tiet
    ''' </summary>
    ''' <param name="otk"></param>
    ''' <remarks></remarks>
    Private Sub ShowChitiet(ByRef otk As ClsQuanLyNhanVien)
        If LstVt.Items.Count > 0 Then
            txtVT(0).Text = onv.SoHieu
            txtVT(1).Text = onv.ten
            txtVT(2).Text = onv.CMND
            txtVT(3).Text = onv.Tel1
            txtVT(4).Text = onv.MST
            ChkBaohiem.CheckState = onv.Baohiem
            txtVT(6).Text = onv.DiaChiHoKhau
            txtVT(7).Text = Timten("ten", ConvertToStrSafe(onv.PhuongXahk), "maso", "Phuongxa")
            txtVT(8).Text = Timten("ten", ConvertToStrSafe(onv.QuanHuyenhk), "maso", "QuanHuyen")
            txtVT(9).Text = Timten("ten", ConvertToStrSafe(onv.TinhTPhk), "maso", "TinhTP")
            SetListIndex(CboQuoctich, onv.QuocGia)
            txtVT(11).Text = onv.DiaChiCuTru
            txtVT(12).Text = Timten("ten", ConvertToStrSafe(onv.PhuongXact), "maso", "Phuongxa")
            txtVT(13).Text = Timten("ten", ConvertToStrSafe(onv.QuanHuyenct), "maso", "QuanHuyen")
            txtVT(14).Text = Timten("ten", ConvertToStrSafe(onv.TinhTPct), "maso", "TinhTp")
            txtVT(15).Text = Timten("ten", ConvertToStrSafe(onv.NoiCap), "maso", "tinhtp")
            SetListIndex(CboChucvu, onv.MaChucvu)
            Cbo.Text = onv.Phai
            CboBacluong.Text = ConvertToStrSafe(onv.BacLuong)
            If CboThang(5).Items.Count > 0 Then CboThang(5).SelectedIndex = onv.ThangTangbh - 1
            Ngay = onv.NgaySinh
            MedNgay.Text = Format(Ngay, Mask_D)
            '    NgayApdung = onv.NgayApdung
            '    MedNgayApdung.Text = Format(NgayApdung, Mask_D)
            Ngaycap = onv.Ngaycap
            MedNgaycap.Text = Format(Ngaycap, Mask_D)
            If Cbo.Items.Count > 0 Then Cbo.SelectedIndex = IIf(onv.Phai = "Nam", 0, 1)
            If CboHD.Items.Count > 0 Then CboHD.SelectedIndex = onv.LoaiHD - 1
            If CboLuong.Items.Count > 0 Then CboLuong.SelectedIndex = onv.LoaiLuong - 1
            ChkThaisan.CheckState = onv.Thaisan
            Thaisan0 = onv.tungay
            Thaisan1 = onv.denngay
            Thaisan(0).Text = Format(Thaisan0, Mask_D)
            Thaisan(1).Text = Format(Thaisan1, Mask_D)
            ThaisanNgay.Visible = ChkThaisan.CheckState
            ChkTang.CheckState = onv.Tang
            ChkTangBH.CheckState = onv.Tangbh
            If CboThang(2).Items.Count > 0 Then CboThang(2).SelectedIndex = onv.ThangTang - 1
            CboThang(2).Visible = ChkTang.CheckState = CheckState.Checked
            Chk.CheckState = onv.Nghiviec
            Nghi = onv.Ngaynghi
            Ngaynghi.Text = Format(Nghi, Mask_D)
            Ngaynghi.Visible = Chk.CheckState = CheckState.Checked
            ChkGiam.CheckState = onv.Giamld
            If CboThang(0).Items.Count > 0 Then CboThang(0).SelectedIndex = onv.tuthang - 1
            If CboThang(1).Items.Count > 0 Then CboThang(1).SelectedIndex = onv.denthang - 1
            ChkThe.CheckState = onv.The
            If CboThang(3).Items.Count > 0 Then CboThang(3).SelectedIndex = onv.Tu - 1
            If CboThang(4).Items.Count > 0 Then CboThang(4).SelectedIndex = onv.Den - 1
            LDThang.Visible = ChkGiam.CheckState = CheckState.Checked
            If ChkThe.CheckState = CheckState.Checked Then
                Frame4.Visible = True
            Else
                ChkThe.Visible = Chk.CheckState = CheckState.Checked And ChkGiam.CheckState = CheckState.Checked And (ChkBaohiem.CheckState = CheckState.Unchecked Or ChkTangBH.CheckState = CheckState.Checked)
                Frame4.Visible = False
            End If
        Else
            clearInfo()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clearInfo()
        txtVT(0).Text = DefaultTextValue
        txtVT(1).Text = DefaultTextValue
        txtVT(2).Text = DefaultTextValue
        txtVT(3).Text = DefaultTextValue
        txtVT(4).Text = DefaultTextValue
        ChkBaohiem.CheckState = CheckState.Indeterminate
        txtVT(6).Text = DefaultTextValue
        txtVT(7).Text = DefaultTextValue
        txtVT(8).Text = DefaultTextValue
        txtVT(9).Text = DefaultTextValue
        CboQuoctich.SelectedIndex = -1

        txtVT(11).Text = DefaultTextValue
        txtVT(12).Text = DefaultTextValue
        txtVT(13).Text = DefaultTextValue
        txtVT(14).Text = DefaultTextValue
        txtVT(15).Text = DefaultTextValue

        CboChucvu.SelectedIndex = -1

        Cbo.Text = DefaultTextValue
        CboBacluong.Text = 0
        If CboThang(5).Items.Count > 0 Then
            CboThang(5).SelectedIndex = 0
        End If
        Ngay = onv.NgaySinh
        MedNgay.Text = Format(Ngay, Mask_D)

        Ngaycap = #1/1/1900#
        MedNgaycap.Text = Format(Ngaycap, Mask_D)
        If Cbo.Items.Count > 0 Then Cbo.SelectedIndex = 0
        'CboHD.SelectedIndex = onv.LoaiHD - 1
        'CboLuong.SelectedIndex = onv.LoaiLuong - 1
        ChkThaisan.CheckState = CheckState.Indeterminate
        Thaisan0 = #1/1/1900#
        Thaisan1 = #1/1/1900#
        Thaisan(0).Text = Format(Thaisan0, Mask_D)
        Thaisan(1).Text = Format(Thaisan1, Mask_D)
        ThaisanNgay.Visible = ChkThaisan.CheckState
        ChkTang.CheckState = CheckState.Indeterminate
        ChkTangBH.CheckState = CheckState.Indeterminate
        'CboThang(2).SelectedIndex = onv.ThangTang - 1
        CboThang(2).Visible = ChkTang.CheckState = CheckState.Checked
        Chk.CheckState = CheckState.Indeterminate
        'Nghi = = #1/1/1900#
        Ngaynghi.Text = Format(#1/1/1900#, Mask_D)
        Ngaynghi.Visible = Chk.CheckState = CheckState.Checked
        ChkGiam.CheckState = onv.Giamld
        'CboThang(0).SelectedIndex = onv.tuthang - 1
        'CboThang(1).SelectedIndex = onv.denthang - 1
        ChkThe.CheckState = CheckState.Indeterminate
        'CboThang(3).SelectedIndex = onv.Tu - 1
        'CboThang(4).SelectedIndex = onv.Den - 1
        LDThang.Visible = ChkGiam.CheckState = CheckState.Checked
        If ChkThe.CheckState = CheckState.Checked Then
            Frame4.Visible = True
        Else
            ChkThe.Visible = Chk.CheckState = CheckState.Checked And ChkGiam.CheckState = CheckState.Checked And (ChkBaohiem.CheckState = CheckState.Unchecked Or ChkTangBH.CheckState = CheckState.Checked)
            Frame4.Visible = False
        End If
    End Sub
    ''' <summary>
    ''' Thu tuc chon vat tu
    ''' </summary>
    ''' <param name="sh">So hieu vat tu can chon</param>
    ''' <returns>Tra ve so hieu vat tu duoc chon</returns>
    ''' <remarks></remarks>
    Public Function ChonNV(ByRef sh As String) As String
        Dim mpl As Integer
        Dim shtk As String = String.Empty
        Dim pos, j, i, Length As Integer
        If sh.Length > 0 Then
            shtk = String.Format("SELECT DISTINCT TOP 1 MaPhanLoai AS F1 FROM QuanLyNhanVien WHERE SoHieu LIKE '{0}%' ORDER BY MaPhanLoai", sh)
            mpl = ConvertToDblSafe(GetSelectValue(shtk))
            If mpl > 0 And CboLoai.SelectedIndex >= 0 Then
                If CboLoai.SelectedIndex <> mpl Then SetListIndex(CboLoai, mpl)
            End If
            i = 0
            j = LstVt.Items.Count - 1
            pos = 0
            Length = sh.Length
            Do While i <= j - 1
                pos = IIf(0.5 + (i + j) / 2 > 0, Math.Floor(0.5 + (i + j) / 2), Math.Ceiling(0.5 + (i + j) / 2))
                shtk = Strings.Left(VB6.GetItemString(LstVt, pos), Length)
                If sh = shtk Then
                    i = pos - 1
                    Do While (sh = Strings.Left(VB6.GetItemString(LstVt, i), Length)) And (i > 0)
                        i -= 1
                    Loop
                    pos = i + 1
                    Exit Do
                End If
                If sh > shtk Then
                    i = pos
                Else
                    If j = 1 Then
                        pos = 0
                        Exit Do
                    Else
                        If j = pos Then Exit Do
                        j = pos
                    End If
                End If
            Loop
            If LstVt.Items.Count > 0 Then LstVt.SelectedIndex = pos
        End If
        Me.Tag = "1"
        Try
            Me.ShowDialog()
        Catch
        End Try
        If onv.MaSo > 0 Then
            Return onv.SoHieu
        Else
            Return ""
        End If
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub LstVt_DoubleClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles LstVt.DoubleClick
        If ConvertToDblSafe(Me.Tag) = 1 Then Hide()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub LstVt_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles LstVt.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then LstVt_DoubleClick(LstVt, New EventArgs())
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
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
        With onv
            If ThemMoi = 1 Then .MaSo = 0
            .MaPhanLoai = CboLoai.SelectedValue
            .MaChucvu = CboChucvu.SelectedValue
            .SoHieu = txtVT(0).Text
            .ten = txtVT(1).Text
            .CMND = txtVT(2).Text
            .NoiCap = ConvertToDblSafe(Timten("maso", txtVT(15).Text, "ten", "tinhtp"))
            .Ngaycap = Ngaycap
            .NgaySinh = Ngay
            '    .NgayApdung = NgayApdung
            .Phai = Cbo.Text
            .LoaiHD = CboHD.SelectedValue
            .LoaiLuong = CboLuong.SelectedValue
            .Tel1 = txtVT(3).Text
            .MST = txtVT(4).Text
            .Baohiem = ChkBaohiem.CheckState
            .DiaChiHoKhau = txtVT(6).Text
            .PhuongXahk = ConvertToDblSafe(Timten("maso", txtVT(7).Text, "ten", "Phuongxa"))
            .QuanHuyenhk = ConvertToDblSafe(Timten("maso", txtVT(8).Text, "ten", "QuanHuyen"))
            .TinhTPhk = ConvertToDblSafe(Timten("maso", txtVT(9).Text, "ten", "tinhtp"))
            .QuocGia = CboQuoctich.SelectedValue
            .DiaChiCuTru = txtVT(11).Text
            .PhuongXact = ConvertToDblSafe(Timten("maso", txtVT(12).Text, "ten", "Phuongxa"))
            .QuanHuyenct = ConvertToDblSafe(Timten("maso", txtVT(13).Text, "ten", "QuanHuyen"))
            .TinhTPct = ConvertToDblSafe(Timten("maso", txtVT(14).Text, "ten", "tinhtp"))
            .BacLuong = ConvertToDblSafe(CboBacluong.Text)
            .Tang = ChkTang.CheckState
            .Tangbh = ChkTangBH.CheckState
            If .Tangbh = CheckState.Checked Then .ThangTangbh = CboThang(5).SelectedValue
            .Nghiviec = Chk.CheckState
            .Ngaynghi = Nghi
            .Thaisan = ChkThaisan.CheckState
            .tungay = Thaisan0
            .denngay = Thaisan1
            .Giamld = ChkGiam.CheckState
            .denthang = 0
            .tuthang = 0
            .ThangTang = 0
            .The = ChkThe.CheckState
            .Den = 0
            .Tu = 0
            If .Tang = CheckState.Checked Then .ThangTang = CboThang(2).SelectedValue
            If .Giamld = CheckState.Checked Then .tuthang = CboThang(0).SelectedValue
            If .Giamld = CheckState.Checked And .Thaisan = CheckState.Checked Then .denthang = CboThang(1).SelectedValue
            If .The = CheckState.Checked Then
                .Tu = CboThang(3).SelectedValue : .Den = CboThang(4).SelectedValue
            End If
            If ThemMoi = 1 And ConvertToDblSafe(.CMND) <> 0 And ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM QuanLyNhanVien WHERE CMND='{0}' AND MaSo<>{1}", .CMND, ConvertToStrSafe(.MaSo)))) > 0 Then
                If MessageBox.Show(Ngonngu("Số CMND bị trùng, cho phép nhập?", "ID card already exists, continue?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.No Then Return result
            End If
            '********************* KiĨm Số hiệu **************************
            If .SoHieu = "" Or .ten = "" Or .ten = "..." Or .SoHieu = "..." Then
                MessageBox.Show(Ngonngu("Thiếu số hiệu hoặc tên", "Lack of code or name"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information) : Return result
            End If
            If ThemMoi = 1 And ConvertToDblSafe(GetSelectValue(String.Format("SELECT maso as f1 FROM quanlynhanvien WHERE sohieu='{0}'", .SoHieu))) <> 0 Then
                MessageBox.Show(Ngonngu("Trùng số hiệu......!", "Code already exists...!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information) : Return result
            End If
            Tinhluongthang()
            rs = ExecSQLReturnDT(String.Format("SELECT * FROM chucvu WHERE maso={0}", CboChucvu.SelectedValue))
            n = CboLuong.SelectedIndex * 5 + 3
            'van.nguyen 13 Nov 2011
            If n > 0 Then
                If rs.Rows.Count > 0 Then
                    Dim rsItem As DataRow = rs.Rows(0)
                    For i As Integer = n To n + .BacLuong - 1
                        If rsItem(i) = 0 Then
                            MessageBox.Show(String.Format(Ngonngu("Chức vụ đã chọn chưa có lương theo loại hình này !{0}Vui lòng cập nhật thêm loại hình lương này vào chức vụ !", "Selected position is not paid in this form !{0}Please update more this kind of salary to the position"), Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : txtVT(17).Text = "" : Return result
                        End If
                    Next
                End If
            Else
                Return False
            End If
        End With
        Return True
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub LstVt_MouseDown(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles LstVt.MouseDown
        Dim Button As Integer = ConvertToDblSafe(eventArgs.Button)
        Dim Shift As Integer = Control.ModifierKeys \ &H10000
        Dim X As Single = (eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        Dim sh As String = String.Empty
        Dim m As Integer
        If eventArgs.Button = MouseButtons.Right And LstVt.SelectedIndex >= 0 And ThemMoi = 0 Then
            sh = FrmGetStr.GetString(String.Format("Chuyển {0} - {1} sang phân loại có số hiệu:", onv.SoHieu, onv.ten), My.Application.Info.ProductName)
            If sh.Length > 0 Then
                m = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM PhanLoaiQuanLyNhanVien WHERE SoHieu='{0}'", sh)))
                If m > 0 And m <> onv.MaPhanLoai Then
                    ExecSQLNonQuery(String.Format("UPDATE QuanLyNhanVien SET MaPhanLoai={0} WHERE MaSo = {1}", m, ConvertToStrSafe(onv.MaSo)))
                    ExecSQLNonQuery(String.Format("UPDATE Phucap SET MaPhanLoai={0} WHERE sohieunhanvien = N'{1}'", m, onv.SoHieu))
                    CboLoai_SelectedIndexChanged(CboLoai, New EventArgs())
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
    Private Sub SSCmdF_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles SSCmdF.Click
        If Strings.Len(txtF.Text) = 0 Then
            txtF.Focus()
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim sql As String = "SELECT DISTINCT Top 1 SoHieu AS F1 FROM QuanLyNhanVien WHERE MaSo>" & MaDaTim
        If SSOpt(0).Checked Then sql = String.Format("{0} AND SoHieu LIKE '{1}%'", sql, txtF.Text)
        If SSOpt(1).Checked Then sql = String.Format("{0} AND Ten LIKE '{1}%'", sql, txtF.Text)
        If SSOpt(2).Checked Then sql = String.Format("{0} AND CMND LIKE '{1}%'", sql, txtF.Text)
        sql = ConvertToStrSafe(GetSelectValue(sql))
        If sql <> "0" Then
            ChonNV(sql)
            MaDaTim = onv.MaSo
        Else
            MaDaTim = 0
        End If
        Me.Cursor = Cursors.Default
    End Sub
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
    Private Sub txtVT_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtVT_17.Enter, _txtVT_4.Enter, _txtVT_15.Enter, _txtVT_2.Enter, _txtVT_14.Enter, _txtVT_13.Enter, _txtVT_11.Enter, _txtVT_12.Enter, _txtVT_9.Enter, _txtVT_8.Enter, _txtVT_7.Enter, _txtVT_6.Enter, _txtVT_0.Enter, _txtVT_1.Enter, _txtVT_3.Enter
        Dim Index As Integer = Array.IndexOf(txtVT, eventSender)
        txtVT(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtVT_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtVT_17.KeyPress, _txtVT_4.KeyPress, _txtVT_15.KeyPress, _txtVT_2.KeyPress, _txtVT_14.KeyPress, _txtVT_13.KeyPress, _txtVT_11.KeyPress, _txtVT_12.KeyPress, _txtVT_9.KeyPress, _txtVT_8.KeyPress, _txtVT_7.KeyPress, _txtVT_6.KeyPress, _txtVT_0.KeyPress, _txtVT_1.KeyPress, _txtVT_3.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtVT, eventSender)
        Dim tentb As String = String.Empty
        Select Case Index
            Case 7, 12 : tentb = "Phuongxa"
            Case 8, 13 : tentb = "QuanHuyen"
            Case 9, 14, 15 : tentb = "tinhtp"
        End Select
        If (Index = 2 Or Index = 3 Or Index = 4) And (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 8 And KeyAscii <> 13 Then
            MessageBox.Show("Bạn chỉ được nhập số !", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            KeyAscii = 0
        End If

        If KeyAscii = 13 Then
            If Index = 7 Or Index = 8 Or Index = 9 Or Index = 15 Then
                txtVT(Index).Text = ConvertToStrSafe(FrmKho.ChonKho(IIf(Index = 10, 13, (IIf(Index = 15, 9, Index))), ConvertToDblSafe((Timten("maso", txtVT(Index).Text, "ten", tentb)))))
                txtVT(Index).Text = Timten("ten", txtVT(Index).Text, "maso", tentb)
            End If
            If Index = 12 Or Index = 13 Or Index = 14 Then
                txtVT(Index).Text = Timten("ten", ConvertToStrSafe(FrmKho.ChonKho(Index - 5, ConvertToDblSafe((Timten("maso", txtVT(Index).Text, "ten", tentb))))), "maso", tentb)
            End If
            If txtVT(Index).Text = "" Then txtVT(Index).Text = "..."
        Else
            If Index = 0 And (KeyAscii = 32 Or KeyAscii = 35 Or KeyAscii = 39 Or KeyAscii = 42) Then KeyAscii = 0
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
    Private Sub txtVT_KeyUp(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles _txtVT_17.KeyUp, _txtVT_4.KeyUp, _txtVT_15.KeyUp, _txtVT_2.KeyUp, _txtVT_14.KeyUp, _txtVT_13.KeyUp, _txtVT_11.KeyUp, _txtVT_12.KeyUp, _txtVT_9.KeyUp, _txtVT_8.KeyUp, _txtVT_7.KeyUp, _txtVT_6.KeyUp, _txtVT_0.KeyUp, _txtVT_1.KeyUp, _txtVT_3.KeyUp
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        Dim Index As Integer = Array.IndexOf(txtVT, eventSender)
        Select Case Index
            Case 7, 8, 9, 12, 13, 14, 15
                If eventArgs.KeyCode <> Keys.Enter And eventArgs.KeyCode <> Keys.Tab And eventArgs.KeyCode <> Keys.ShiftKey Then txtVT(Index).Text = ""
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtVT_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtVT_17.Leave, _txtVT_4.Leave, _txtVT_15.Leave, _txtVT_2.Leave, _txtVT_14.Leave, _txtVT_13.Leave, _txtVT_11.Leave, _txtVT_12.Leave, _txtVT_9.Leave, _txtVT_8.Leave, _txtVT_7.Leave, _txtVT_6.Leave, _txtVT_0.Leave, _txtVT_1.Leave, _txtVT_3.Leave
        Dim Index As Integer = Array.IndexOf(txtVT, eventSender)
        Dim ten As String = String.Empty
        If Strings.Len(txtVT(Index).Text) = 0 Then
            txtVT(Index).Text = "..."
        Else
            Select Case Index
                Case 0
                    txtVT(Index).Text = txtVT(Index).Text.ToUpper()
                    If ThemMoi = 1 And ConvertToDblSafe(GetSelectValue(String.Format("SELECT maso as f1 FROM quanlynhanvien WHERE sohieu='{0}'", txtVT(Index).Text))) <> 0 Then
                        ErrMsg(er_SoHieu)
                        txtVT(Index).Focus()
                        Exit Sub
                    End If
                Case 1
                    ten = txtVT(Index).Text
                    ten = ten.Trim().ToLower()
                    ten = Strings.Left(ten, 1).ToUpper() & Strings.Right(ten, ten.Length - 1)
                    For i As Integer = 1 To ten.Length - 1
                        If Strings.Mid(ten, i, 1) = " " And Strings.Mid(ten, i + 1, 1) = " " Then
                            ten = Strings.Left(ten, i) & Strings.Right(ten, ten.Length - i - 1) : i -= 1
                        End If
                        If Strings.Mid(ten, i, 1) = " " And Strings.Mid(ten, i + 1, 1) <> " " Then Mid(ten, i + 1, 1) = Strings.Mid(ten, i + 1, 1).ToUpper()
                    Next
                    txtVT(Index).Text = ten
                    If ThemMoi = 1 And ConvertToDblSafe(GetSelectValue(String.Format("SELECT maso as f1 FROM quanlynhanvien WHERE ten=N'{0}'", txtVT(Index).Text))) <> 0 Then
                        If MessageBox.Show(String.Format("Tên nhân viên bị trùng!{0}Cho phép nhập ...", Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
                            txtVT(Index).Focus()
                            Exit Sub
                        End If
                    End If
            End Select
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MedNgay.Enter
        MedNgay.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgaycap_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MedNgaycap.Enter
        MedNgaycap.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Ngaynghi_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Ngaynghi.Enter
        Ngaynghi.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Thaisan_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Thaisan_0.Enter, _Thaisan_1.Enter
        Dim Index As Integer = Array.IndexOf(Thaisan, eventSender)
        Thaisan(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MedNgay.Leave
        If Information.IsDate(MedNgay.Text) Then
            Ngay = ConvertToDateSafe(MedNgay.Text)
        Else
            MedNgay.Focus()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgaycap_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MedNgaycap.Leave
        If Information.IsDate(MedNgaycap.Text) Then
            Ngaycap = ConvertToDateSafe(MedNgaycap.Text)
        Else
            MedNgaycap.Focus()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Ngaynghi_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Ngaynghi.Leave
        If Information.IsDate(Ngaynghi.Text) Then
            Nghi = ConvertToDateSafe(Ngaynghi.Text)
        Else
            Ngaynghi.Focus()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Thaisan_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Thaisan_0.Leave, _Thaisan_1.Leave
        Dim Index As Integer = Array.IndexOf(Thaisan, eventSender)
        If Information.IsDate(Thaisan(Index).Text) Then
            If Index = 0 Then
                Thaisan0 = ConvertToDateSafe(Thaisan(Index).Text)
            Else
                Thaisan1 = ConvertToDateSafe(Thaisan(Index).Text)
            End If
        Else
            Thaisan(Index).Focus()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="uid"></param>
    ''' <remarks></remarks>
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(1).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        Command(2).Enabled = (User_Right <> 2 Or (UserID = uid))
    End Sub
End Class
