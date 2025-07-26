Imports System
Imports System.Text
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter
Imports System.Text.RegularExpressions
Imports DSBarCode.BarCodeCtrl


Partial Friend Class FrmVattu
    ''
    'Khoi tao Component
    ''
    Private isInitializingComponent As Boolean
    ''' <summary>
    ''' =1 nếu thêm mới, -1 nếu sửa cũ
    ''' </summary>
    ''' <remarks></remarks>
    Dim ThemMoi As Integer
    Private _vattu As ClsVattu = Nothing
    ''' <summary>
    ''' Vật tư được tham chiếu
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property vattu() As ClsVattu
        Get
            If _vattu Is Nothing Then
                _vattu = New ClsVattu()
            End If
            Return _vattu
        End Get
        Set(ByVal Value As ClsVattu)
            _vattu = Value
        End Set
    End Property
    Private _vt As ClsVattu = Nothing
    Property vt() As ClsVattu
        Get
            If _vt Is Nothing Then
                _vt = New ClsVattu()
            End If
            Return _vt
        End Get
        Set(ByVal Value As ClsVattu)
            _vt = Value
        End Set
    End Property
    Private _ts As clsTaiSan = Nothing
    Property ts() As clsTaiSan
        Get
            If _ts Is Nothing Then
                _ts = New clsTaiSan()
            End If
            Return _ts
        End Get
        Set(ByVal Value As clsTaiSan)
            _ts = Value
        End Set
    End Property
    ''' <summary>
    ''' =1 neu co thay doi loai vat tu dang sua doi
    ''' </summary>
    ''' <remarks></remarks>
    Dim doiloai As Integer
    Public ChucNang As Integer
    Public TK As String = String.Empty
    Dim MaDaTim As String
    Dim xT As Integer
    Dim xSH As String = String.Empty
    Dim tdau As Integer
    Dim tcuoi As Integer
    Dim KtLoadFocus As Integer
    Dim thang, dem As Integer
    Dim taikhoan As String = String.Empty
    ''' <summary>
    ''' Liet ke cac vat tu trong loai vat tu duoc chon
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CboLoai_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboLoai.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        Try
            If ThemMoi <> -1 Then
                Me.Cursor = Cursors.WaitCursor
                Int_RecsetToListbox(String.Format("SELECT MaSo As F2, SoHieu + Char(9) + TenVattu As F1 FROM Vattu WHERE MaPhanLoai={0} ORDER BY SoHieu", CboLoai.SelectedValue), LstVt)
                ThemMoi = 0
                doiloai = 0
                If LstVt.SelectedIndex < 0 Then
                    vattu.InitVattuMaSo(0)
                    ClearGrid(GrdNT(0), ConvertToDblSafe(GrdNT(0).Tag))
                End If
                Me.Cursor = Cursors.Default
            Else
                doiloai = 1
            End If
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
    Private Sub CboThang_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboThang.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim thang1, TM As Integer
            If pDinhmuc <> CheckState.Unchecked Then
                thang1 = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 Thang AS F1 FROM DinhMuc WHERE MaTP={0} AND {1} ORDER BY {2} DESC", _
                                                             vattu.MaSo, _
                                                             WThang("Thang", 0, CboThang.SelectedValue), _
                                                             SetMonthOrder("Thang"))))
                dem = ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(maso) as f1 FROM dinhmuc WHERE MaTP={0} AND Thang={1}", _
                                                          vattu.MaSo, _
                                                          ConvertToStrSafe(CboThang.SelectedValue))))
                If thang1 > 0 And thang1 <> CboThang.SelectedValue And Me.Visible And dem = 0 Then
                    TM = IIf(MessageBox.Show(String.Format("Thêm định mức mới áp dụng từ tháng {0} ?", CboThang.Text), _
                                 My.Application.Info.ProductName, _
                                 MessageBoxButtons.YesNo, _
                                 MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes, 1, 0)
                End If
            End If
            If TM = 1 Then
                ExecSQLNonQuery(String.Format("DELETE FROM dinhmuc WHERE MaTP={0} AND thang={1}", _
                                    vattu.MaSo, _
                                    ConvertToStrSafe(CboThang.SelectedValue)))
            End If
            LietKeDinhMuc(TM)
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
    Private Sub Chk_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            GrdNT(3).Enabled = Chk.CheckState > 0
            TxtVT(4).Enabled = Chk.CheckState > 0
            TxtVT(5).Enabled = Chk.CheckState > 0
            TxtVT(11).Enabled = Chk.CheckState > 0
            CmdChitiet(2).Enabled = Chk.CheckState > 0
            If ThemMoi = 1 And Chk.CheckState > 0 Then TxtVT(4).Focus()
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
    Private Sub ChkNhap_MouseUp(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles ChkNhap.MouseUp
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim Button As Integer = ConvertToDblSafe(eventArgs.Button)
            Dim Shift As Integer = Control.ModifierKeys \ &H10000
            Dim X As Single = (eventArgs.X)
            Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
            If ChkNhap.CheckState Then
                ChkNhap.Text = Ngonngu("Chứng từ xuất", "Exports Vouchers")
            Else
                ChkNhap.Text = Ngonngu("Chứng từ nhập", "Imports Vouchers")
            End If
            laythang()
            If vattu.sohieu <> "" Then
                LietKeTonKho(0, ConvertToDblSafe(Timten("maso", vattu.sohieu, "sohieu", "vattu")), tdau, tcuoi, True, ChkNhap.CheckState)
            Else
                ClearGrid(Grd, Grd.Rows)
            End If
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
    Sub laythang()
        Me.Cursor = Cursors.WaitCursor
        Try
            If CboThang1(1).SelectedIndex < CboThang1(0).SelectedIndex Then CboThang1(1).SelectedIndex = CboThang1(0).SelectedIndex
            If CboThang1(0).SelectedIndex < 0 Then

                AddMonthToCbo(CboThang1(0))
                AddMonthToCbo(CboThang1(1))
                CboThang1(0).SelectedIndex = 0
            End If

            tdau = CboThang1(0).SelectedValue
            tcuoi = CboThang1(1).SelectedValue
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Laythang1()
        Try
            CboThang1(1).SelectedIndex = CboThang1(0).SelectedIndex
            If CboThang1(1).SelectedIndex - 2 >= 0 Then
                CboThang1(0).SelectedIndex -= 2
            Else
                CboThang1(0).SelectedIndex = 0
            End If
            If CboThang1(0).SelectedIndex < 0 Then CboThang1(0).SelectedIndex = 0
            tdau = CboThang1(0).SelectedIndex
            tcuoi = CboThang1(1).SelectedIndex
        Catch ex As Exception
            '[Cuong Add]
            tdau = 1
            tcuoi = 3
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_4.Click, _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click, _Command_5.Click, _Command_6.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim Index As Integer = Array.IndexOf(Command, eventSender)
            Dim LstVt_NewIndex As Integer = -1
            Dim vt1 As New ClsVattu
            Dim i As Integer
            Dim dv As String = String.Empty
            Dim qd, gb As Double
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
                    TxtVT(0).Text = SoHieuVTMoi(CboLoai.SelectedValue)
                    TxtVT(1).Text = ""
                    TxtVT(13).Text = ""
                    txtTon(0).Text = "0"
                    txtTon(1).Text = "0"
                    ClearGrid(GrdNT(2), ConvertToDblSafe(GrdNT(2).Tag))
                    Chk.CheckState = CheckState.Unchecked
                    ClearGrid(GrdNT(3), ConvertToDblSafe(GrdNT(3).Tag))
                    TxtVT(0).Focus()
                    ThemMoi = 1
                    Khoaquyen()
                Case 1
                    Select Case ThemMoi
                        Case 1
                            If Not KiemTraSoLieu() Then GoTo XongVT
                            If vattu.KiemTraTonTaiSoHieuVatTu(TxtVT(0).Text) = True Then
                                MessageBox.Show(Ngonngu("Mã hàng đã tồn tại, bạn nhập mã hàng khác!", "Code ready exits in system, please chose Code orther!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                TxtVT(0).Focus()
                                TxtVT(0).SelectAll()
                                GoTo XongVT
                            End If
                            If vattu.GhiVattu() = 0 Then
                                If Chk.CheckState = CheckState.Checked Then
                                    With GrdNT(3)
                                        For i = 0 To .Rows - 1
                                            .Row = ConvertToDblSafe(i)
                                            .Col = 0
                                            dv = .CtlText
                                            If dv.Length = 0 Then Exit For
                                            .Col = 1
                                            qd = ConvertToDblSafe(.CtlText)
                                            .Col = 2
                                            gb = ConvertToDblSafe(.CtlText)
                                            ExecSQLNonQuery("INSERT INTO DVTVattu (MaSo,MaVattu,DonVi,TyleQD,GiaBan) VALUES (" & Lng_MaxValue("MaSo", "DVTVattu") + 1 & "," & ConvertToStrSafe(vattu.MaSo) & ",'" & dv & "'," & CStr(qd) & "," & CStr(gb) & ")")
                                        Next
                                    End With
                                End If
                                'van.nguyen 2-Dec-2011
                                Dim temp As String = String.Format("{0}{1}{2}", vattu.sohieu, Chr(9), vattu.TenVattu)
                                Dim newItemCate As New ValueDescriptionPair(vattu.MaSo, temp)

                                LstVt_NewIndex = LstVt.Items.Add(newItemCate)
                                LstVt.SelectedIndex = LstVt_NewIndex
                            Else
                                ErrMsg(er_PhanLoai)
                                vt1.InitVattuSohieu(TxtVT(0).Text)
                                If vt1.MaPhanLoai = CboLoai.SelectedIndex Then
                                    SetListIndex(LstVt, vt1.MaSo)
                                End If
                            End If
                            ThemMoi = 0
                        Case 0
                            If LstVt.SelectedIndex < 0 Or Not KiemTraSoLieu() Then GoTo XongVT
                            If vattu.SuaVT() = 0 Then
                                If doiloai = 1 Then
                                    CboLoai_SelectedIndexChanged(CboLoai, New EventArgs())
                                    doiloai = 0
                                Else
                                    Dim currentCate As ValueDescriptionPair

                                    currentCate = CType(LstVt.SelectedItem, ValueDescriptionPair)
                                    If currentCate IsNot Nothing Then
                                        Dim newItemCate As New ValueDescriptionPair(currentCate.Value, String.Format("{0}       {1}", vattu.sohieu, vattu.TenVattu))
                                        LstVt.Items(LstVt.SelectedIndex) = newItemCate
                                    End If
                                End If
                            Else
                                vt1.InitVattuSohieu(TxtVT(0).Text)
                                ErrMsg(er_SoHieu)
                                If vt1.MaPhanLoai = CboLoai.SelectedIndex Then SetListIndex(LstVt, vt1.MaSo)
                            End If
                            ThemMoi = 0
                    End Select
                    LstVt.Focus()
                Case 2
                    i = LstVt.SelectedIndex
                    If i < 0 Then GoTo XongVT
                    If vattu.XoaVT() = 0 Then
                        LstVt.Items.RemoveAt(ConvertToDblSafe(i))
                        If LstVt.Items.Count > 0 Then LstVt.SelectedIndex = i - 1
                    Else
                        ErrMsg(er_CoPS)
                    End If
                    LstVt.Focus()
                Case 3
                    If ChucNang = 1 Then Command_ClickEvent(Command(4), New EventArgs())
                    Hide()
                Case 4
                    ChucNang = 1 - ChucNang
                    Panel(0).Visible = (ChucNang = 0)
                    For i = 0 To 2
                        Command(i).Enabled = (ChucNang = 0)
                    Next
                    If LstVt.SelectedIndex >= 0 Then
                        LstVt_SelectedIndexChanged(LstVt, New EventArgs())
                    Else
                        vattu.InitVattuMaSo(0)
                        ClearGrid(GrdNT(0), ConvertToDblSafe(GrdNT(0).Tag))
                        ClearGrid(GrdNT(1), ConvertToDblSafe(GrdNT(1).Tag))
                    End If
                Case 5
                    NhapVattuVao()
                Case 6
                    XuatVattuRa()
            End Select
XongVT:
            vt1 = Nothing
            Me.Cursor = Cursors.Default
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try        
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Me.Cursor = Cursors.WaitCursor
        Try
            If ConvertToDblSafe(Me.Tag) < 0 Then
                SetListIndex(CboLoai, -ConvertToDblSafe(Me.Tag))
                Me.Tag = "0"
            End If

            If ThemMoi = 0 And ConvertToDblSafe(Me.Tag) = 1 And ChucNang = 0 Then LstVt.Focus()
            If xT = 1 Then
                If xSH <> "" Then SetListIndex(CboLoai, LayMaPhanLoai(xSH, "Vattu"))
                Command_ClickEvent(Command(0), New EventArgs())
                TxtVT(0).Text = xSH
            End If
            If Not FrmChungtu.OptLoai(13).Checked And CboLoai.Items.Count = 1 Then
                Int_RecsetToCbo("SELECT DISTINCT PhanLoaiVattu.MaSo As F2, PhanLoaiVattu.SoHieu + ' - '  + PhanLoaiVattu.TenPhanLoai As F1 FROM PhanLoaiVattu WHERE PLCon=0 ORDER BY PhanLoaiVattu.SoHieu", CboLoai)
            End If

            'If TK <> "" Then
            '    taikhoan = TK
            '    TK = "1"
            'End If

            'If taikhoan <> "" Then
            '    If CboLoai.Items.Count > 0 Then CboLoai.SelectedIndex = 0
            '    While CboLoai.SelectedIndex < CboLoai.Items.Count - 1 And Strings.Left(Timten("sohieu", Timten("matk", ConvertToStrSafe(CboLoai.SelectedIndex), "maso", "phanloaivattu"), "maso", "hethongtk"), 3) <> taikhoan
            '        CboLoai.SelectedIndex += 1
            '    End While
            'End If

            'If TK = "1" Then
            '    TK = ""
            '    taikhoan = ""
            'End If
            Laythang1()

            'Kiem tra Dinhmuc
            Panel(0).Visible = (ChucNang = 0)
            For i As Integer = 0 To 2
                Command(i).Enabled = (ChucNang = 0)
            Next

            If LstVt.SelectedIndex < 0 Then
                vattu.InitVattuMaSo(0)
                ClearGrid(GrdNT(0), ConvertToDblSafe(GrdNT(0).Tag))
                ClearGrid(GrdNT(1), ConvertToDblSafe(GrdNT(1).Tag))
            End If
            Khoaquyen()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    'Private Sub FrmVattu_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    '    If FrmMNGiaThanh.Visible And ChucNang = 0 Then Command_ClickEvent(Command(4), New EventArgs())
    '    If Me.Visible = True Then MessageBox.Show("tuong")
    'End Sub
    ''' <summary>
    ''' Xu ly cac phim nong
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FrmVattu_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        Me.Cursor = Cursors.WaitCursor
        Try
            'Dim KeyCode As Integer = eventArgs.KeyCode
            Dim Shift As Integer = eventArgs.KeyData \ &H10000
            If (Shift And 4) > 0 Then
                Select Case eventArgs.KeyCode
                    Case Keys.V
                        Command(3).Focus()
                        ' Command_ClickEvent(Command(3), New EventArgs())
                    Case Keys.T
                        If Not Command(0).Enabled Then Exit Sub
                        Command(0).Focus()
                        'Command_ClickEvent(Command(0), New EventArgs())
                    Case Keys.X
                        If Not Command(2).Enabled Then Exit Sub
                        Command(2).Focus()
                        'Command_ClickEvent(Command(2), New EventArgs())
                    Case Keys.G
                        If Not Command(1).Enabled Then Exit Sub
                        Command(1).Focus()
                        'Command_ClickEvent(Command(1), New EventArgs())
                    Case Keys.M
                        Command(4).Focus()
                        ' Command_ClickEvent(Command(4), New EventArgs())
                    Case Keys.N
                        Command(5).Focus()
                        ' Command_ClickEvent(Command(5), New EventArgs())
                    Case Keys.E
                        Command(6).Focus()
                        ' Command_ClickEvent(Command(6), New EventArgs())
                End Select
            End If
            If eventArgs.KeyCode = Keys.Escape Then
                If ChucNang = 1 Then Command_ClickEvent(Command(4), New EventArgs())
                Hide()
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    ''' <summary>
    ''' Khoi tao form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FrmVattu_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            ColumnSetUp(GrdNT(0), 0, 825, 0)
            ColumnSetUp(GrdNT(0), 1, 2030, 0)
            ColumnSetUp(GrdNT(0), 2, 590, 2)
            ColumnSetUp(GrdNT(0), 3, 1190, 4)
            ColumnSetUp(GrdNT(0), 4, 0, 4)
            ColumnSetUp(GrdNT(0), 5, 590, 4)
            ColumnSetUp(GrdNT(0), 6, 335, 2)
            ColumnSetUp(GrdNT(0), 7, 0, 0)
            ColumnSetUp(GrdNT(1), 0, 1430, 0)
            ColumnSetUp(GrdNT(1), 1, 2860, 0)
            ColumnSetUp(GrdNT(1), 2, 1295, 4)
            ColumnSetUp(GrdNT(2), 0, 1540, 0)
            ColumnSetUp(GrdNT(2), 1, 1415, 4)
            ColumnSetUp(GrdNT(2), 2, 1195, 4)
            ColumnSetUp(GrdNT(2), 3, 1475, 4)
            ColumnSetUp(GrdNT(3), 0, 1670, 2)
            ColumnSetUp(GrdNT(3), 1, 1790, 4)
            ColumnSetUp(GrdNT(3), 2, 2120, 4)
            ColumnSetUp(GrdNT(3), 3, 0, 0)
            ColumnSetUp(Grd, 0, 1190, 0)
            ColumnSetUp(Grd, 1, 800, 0)
            ColumnSetUp(Grd, 2, 1370, 4)
            Grd.Rows = 16
            Pic.Visible = (pBarCode > 0)
            TxtVT(3).Enabled = pGiaHT > 0
            ThemMoi = 0
            Text = SetFormTitle(Text)
            AddMonthToCbo(CboThang)
            AddMonthToCbo(CboThang1(0))
            AddMonthToCbo(CboThang1(1))
            If CboThang.Items.Count > 0 Then
                CboThang.SelectedIndex = pThangDauKy
            End If
            If FrmChungtu.tk = 0 And doiloai = 0 Then
                Int_RecsetToCbo("SELECT DISTINCT PhanLoaiVattu.MaSo As F2, PhanLoaiVattu.SoHieu + ' - '  + PhanLoaiVattu.TenPhanLoai As F1 FROM PhanLoaiVattu WHERE PLCon=0 ORDER BY F1", CboLoai)
                If CboLoai.Items.Count > 0 Then
                    CboLoai.SelectedIndex = 0
                End If
            Else
                doiloai = 0
            End If
            Label(28).Visible = (pDinhmuc <> CheckState.Unchecked)
            CboThang.Visible = (pDinhmuc <> CheckState.Unchecked)
            AddMonthToCbo(CboThang)
            If pDinhmuc = CheckState.Unchecked And CboThang.Items.Count > 0 Then CboThang.SelectedIndex = 0
            Label(31).Visible = pChietKhau > 0
            TxtVT(12).Visible = pChietKhau > 0
            Label(32).Visible = (pNhapKhau > 0)
            TxtVT(13).Visible = (pNhapKhau > 0)

            'Me.StartPosition = FormStartPosition.CenterScreen
            If pNN = 1 And Not Me.Text Like "Lists material and goods*" Then SetFont(Me)
            Me.Text = Ngonngu("Hệ thống danh điểm vật tư, hàng hoá", "Lists material and goods")
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
    Private Sub FrmVattu_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        Me.Cursor = Cursors.WaitCursor
        Try
            vattu = Nothing
            vt = Nothing
            ts = Nothing
            MemoryHelper.ReleaseMemory()
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
    Private Sub Grd_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            If MessageBox.Show(Ngonngu("Sửa chứng từ?", "Edit voucher?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                Grd.Col = 0 : FrmChungtu.Suatonkho(Grd.CtlText)
            End If
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
    Private Sub GrdNT_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim Index As Integer = Array.IndexOf(GrdNT, eventSender)
            Dim maNVL As Integer
            If Index = 0 Then
                With GrdNT(0)
                    If .CtlText.Length = 0 Or .Col <> 5 Then Exit Sub
                    If .CtlText <> "X" Then
                        .CtlText = "X"
                    Else
                        .CtlText = "-"
                    End If
                    .Col = 0
                    maNVL = ConvertToDblSafe(Timten("maso", .CtlText, "sohieu", "vattu"))
                    .Col = 5
                    ExecSQLNonQuery(String.Format("UPDATE DinhMuc SET PL=N'{0}'  WHERE MaTP={1} AND MaNVL={2} AND Thang={3}", .CtlText, ConvertToStrSafe(vattu.MaSo), ConvertToStrSafe(maNVL), ConvertToStrSafe(IIf(pDinhmuc <> CheckState.Unchecked, CboThang.SelectedIndex, 1))))
                    'OpenDB(pDataPath)
                End With
            End If
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
    Private Sub GrdNT_MouseDownEvent(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim Index As Integer = Array.IndexOf(GrdNT, eventSender)
            If Index = 0 And eventArgs.Button = MouseButtons.Right Then GrdNT_KeyPressEvent(GrdNT(0), New KeyPressEventArgs(Chr(Keys.H)))
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' Khoi tao vat tu duoc chon
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LstVt_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles LstVt.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim index As Integer = 0
            Dim currentCate As ValueDescriptionPair
            index = LstVt.SelectedIndex
            If index < 0 Then Exit Sub
            currentCate = CType(LstVt.Items(index), ValueDescriptionPair)

            vattu.InitVattuMaSo(currentCate.Value)
            Select Case ChucNang
                Case 0
                    ShowChitiet(vattu)
                    ThemMoi = 0
                Case 1
                    CboThang_SelectedIndexChanged(CboThang, New EventArgs())
            End Select
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    ''' <summary>
    ''' Thu tuc hien thong tin chi tiet
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ShowChitiet(ByRef vattu As ClsVattu)
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim dgia As Double
            TxtVT(0).Text = vattu.sohieu
            TxtVT(1).Text = vattu.TenVattu
            TxtVT(2).Text = vattu.DonVi
            TxtVT(3).Text = Format(vattu.GiaHT, Mask_5)
            TxtVT(6).Text = vattu.GhiChu
            TxtVT(7).Text = ConvertToStrSafe(vattu.VAT)
            TxtVT(8).Text = Format(vattu.GiaBan1, Mask_2)
            TxtVT(9).Text = Format(vattu.GiaBan2, Mask_2)
            TxtVT(10).Text = Format(vattu.GiaBan3, Mask_2)
            TxtVT(12).Text = Format(vattu.CK, Mask_2)
            TxtVT(13).Text = Format(vattu.ThueNK, Mask_2)
            txtTon(0).Text = Format(vattu.TonMin, Mask_2)
            txtTon(1).Text = Format(vattu.TonMax, Mask_2)

            If pBarCode > 0 Then TxtVT_TextChanged(TxtVT(0), New EventArgs())
            ClearGrid(GrdNT(3), ConvertToDblSafe(GrdNT(3).Tag))
            Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT * FROM DVTVattu WHERE MaVattu={0} ORDER BY DonVi DESC", vattu.MaSo))
            Dim rsIndex As Integer = 0
            Do While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                GrdNT(3).AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}", rsItem("DonVi"), Chr(9), Format(rsItem("TyLeQD"), Mask_2), Format(rsItem("giaban"), Mask_2), rsItem("MaSo")), 0)
            Loop
            Chk.CheckState = IIf(rs.Rows.Count > 0, 1, 0)

            ClearGrid(GrdNT(2), ConvertToDblSafe(GrdNT(2).Tag))
            Dim st As String = ConvertToStrSafe(CThangDB2(ThangCuoiNamTC()))
            rs = ExecSQLReturnDT(String.Format("SELECT TenKho,Sum(Luong_{0}) AS Luong, Sum(Tien_{0}) AS Tien FROM TonKho INNER JOIN KhoHang ON TonKho.MaSoKho=KhoHang.MaSo WHERE MaVattu={1} GROUP BY TenKho HAVING Sum(Luong_{0})<>0 OR Sum(Tien_{0})<>0 ORDER BY TenKho DESC", st, ConvertToStrSafe(vattu.MaSo)))
            rsIndex = 0
            Do While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                dgia = IIf(rsItem("luong") <> 0, rsItem("tien") / rsItem("luong"), 0)
                GrdNT(2).AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}", rsItem("tenkho"), Chr(9), Format(rsItem("luong"), Mask_2), Format(dgia, Mask_2), Format(rsItem("tien"), Mask_0)), 0)
            Loop
            rs = Nothing
            laythang()
            If vattu.sohieu <> "" Then
                LietKeTonKho(0, ConvertToDblSafe(Timten("maso", vattu.sohieu, "sohieu", "vattu")), tdau, tcuoi, True, ChkNhap.CheckState)
                Chk.Enabled = True
            Else
                ClearGrid(Grd, Grd.Rows)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    'Thu tuc chon vat tu
    ' sh: so hieu vat tu can chon
    ' Tra ve so hieu vat tu duoc chon

    Public Function ChonVattu(ByRef sh As String, Optional ByRef c As Integer = 0, Optional ByRef loai As Integer = 0, Optional ByRef nvl As Integer = 0, Optional ByRef dauky As Integer = 0, Optional ByRef taikhoanloai As String = "") As String
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim f As New FrmVattu
            Dim SoHieu As String = String.Empty
            Dim mpl As Integer, lantim As Integer, id_le As Integer
            Dim shtk As String = String.Empty
            Dim pos, j, i, Length As Integer
            If sh = "" Then taikhoan = taikhoanloai Else taikhoan = ""
            If loai = 1 Then
                ChkNhap.CheckState = CheckState.Unchecked
                ChkNhap_MouseUp(ChkNhap, New MouseEventArgs(MouseButtons.Left, 0, 10, 10, 0))
            End If
            If loai = 2 Or loai = 8 Then
                ChkNhap.CheckState = CheckState.Checked
                ChkNhap_MouseUp(ChkNhap, New MouseEventArgs(MouseButtons.Left, 0, 10, 10, 0))
            End If
            Dim a As String = "'"
            Me.Tag = "0"
            If CboLoai.Items.ItemsBase.Count = 0 Then Int_RecsetToCbo("SELECT DISTINCT PhanLoaiVattu.MaSo As F2, PhanLoaiVattu.SoHieu + ' - '  + PhanLoaiVattu.TenPhanLoai As F1 FROM PhanLoaiVattu WHERE PLCon=0 ORDER BY F1", CboLoai)
            If sh.Length > 0 And sh <> a Then
                shtk = String.Format("SELECT DISTINCT TOP 1 Vattu.MaPhanLoai AS F1 FROM Vattu WHERE SoHieu LIKE N'{0}%' ORDER BY F1", sh)
                mpl = ConvertToDblSafe(GetSelectValue(shtk))
                If mpl > 0 Then
                    If CboLoai.SelectedIndex <> mpl Then SetListIndex(CboLoai, mpl)
                End If
timlai:
                i = 0
                j = LstVt.Items.Count - 1
                pos = 0
                Length = sh.Length
                Do While i <= j
                    pos = (i + j) / 2
                    shtk = VB6.GetItemString(LstVt, pos)
                    If shtk.Length > Length Then shtk = shtk.Substring(0, Length)
                    If sh.ToUpper() = shtk.ToUpper() Then
                        i = pos - 1
                        If i > 0 Then
                            Do While (sh.ToUpper() = LstVt.Items(i).ToString.Substring(0, Length).ToUpper()) And (i > 0)
                                i -= 1
                            Loop
                        End If
                        pos = i + 1
                        GoTo Timduoc
                    End If
                    If UNItokdau(sh.ToUpper()) > UNItokdau(shtk.ToUpper()) Then
                        If i = pos Then
                            If id_le = 0 Then
                                id_le = 1
                                i = pos + 1
                            Else
                                id_le = 0
                                GoTo Boqua
                            End If
                        Else
                            i = pos
                        End If
                    Else
                        If j = pos Then
                            If id_le = 0 Then
                                id_le = 1
                                j = pos - 1
                            Else
                                id_le = 0
                                GoTo Boqua
                            End If
                        Else
                            j = pos
                        End If
                    End If
                Loop
Boqua:
                If lantim < CboLoai.Items.ItemsBase.Count Then
                    CboLoai.SelectedIndex = lantim
                    lantim = lantim + 1
                    GoTo timlai
                End If
Timduoc:
                If LstVt.Items.Count > 0 Then LstVt.SelectedIndex = pos
            End If
            Me.Tag = "1"
            If c <> 0 Then
                Me.Top += 240
                Me.Left += 580
                Command(4).Enabled = False
            End If
            Dim resume2 As Boolean = True
            Try
                If nvl = 1 Then
                    For T As Integer = 0 To CboLoai.Items.Count - 1
                        CboLoai.SelectedIndex = T
                        If CboLoai.Text.ToUpper().StartsWith("NVL") Or CboLoai.Text.ToUpper().StartsWith("NL") Then
                            Exit For
                        Else
                            CboLoai.SelectedIndex = 0
                        End If
                    Next
                End If
                If dauky > 0 And CboLoai.Items.Count > 0 Then CboLoai.Text = loai
                doiloai = 1
                Me.ShowDialog()
                GoTo Khongloi
Loi:
                SoHieu = f.ChonVattu(sh, c, loai, nvl)
                If SoHieu <> "" Then
                    Return SoHieu
                Else
                    Return String.Empty
                End If

Khongloi:
                resume2 = False
                If vattu.MaSo > 0 Then
                    Return vattu.sohieu
                Else
                    Return String.Empty
                End If
            Catch exc As System.Exception
                If Not resume2 Then
                    Throw exc
                End If
            End Try

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return String.Empty
    End Function
    Public Function ChonVattu1(ByRef sh As String, Optional ByRef c As Integer = 0, Optional ByRef loai As Integer = 0, Optional ByRef nvl As Integer = 0) As String
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim mpl As Integer
            Dim shtk As String = String.Empty
            Dim pos, j, i, Length As Integer
            If loai = 1 Then
                ChkNhap.CheckState = CheckState.Unchecked : ChkNhap_MouseUp(ChkNhap, New MouseEventArgs(MouseButtons.Left, 0, 10, 10, 0))
            End If
            If loai = 2 Or loai = 8 Then
                ChkNhap.CheckState = CheckState.Checked : ChkNhap_MouseUp(ChkNhap, New MouseEventArgs(MouseButtons.Left, 0, 10, 10, 0))
            End If
            Dim a As String = "'"
            If sh.Length > 0 And sh <> a Then
                shtk = "SELECT DISTINCT TOP 1 Vattu.MaPhanLoai AS F1 FROM Vattu WHERE SoHieu LIKE '" & sh & "%' ORDER BY SoHieu"
                mpl = ConvertToDblSafe(GetSelectValue(shtk))
                If mpl > 0 Then
                    If CboLoai.SelectedIndex <> mpl Then SetListIndex(CboLoai, mpl)
                End If
                i = 0
                j = LstVt.Items.Count - 1
                pos = 0
                Length = sh.Length
                Do While i <= j - 1
                    pos = IIf(0.5 + (i + j) / 2 > 0, Math.Floor(0.5 + (i + j) / 2), Math.Ceiling(0.5 + (i + j) / 2))
                    shtk = Strings.Left(VB6.GetItemString(LstVt, pos), Length)
                    If sh.ToUpper() = shtk.ToUpper() Then
                        i = pos - 1
                        Do While (sh.ToUpper() = Strings.Left(VB6.GetItemString(LstVt, i), Length).ToUpper()) And (i > 0)
                            i -= 1
                        Loop
                        pos = i + 1
                        Exit Do
                    End If
                    If sh.ToUpper() > shtk.ToUpper() Then
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
            Me.StartPosition = FormStartPosition.CenterScreen
            If c <> 0 Then
                Me.Top += 240
                Me.Left += 580
                Command(4).Enabled = False
            End If
            Try
                If nvl = 1 Then
                    For T As Integer = 0 To CboLoai.Items.Count - 1
                        CboLoai.SelectedIndex = T
                        If CboLoai.Text.ToUpper().StartsWith("NVL") Or CboLoai.Text.ToUpper().StartsWith("NL") Then
                            Exit For
                        Else
                            CboLoai.SelectedIndex = 0
                        End If
                    Next
                End If
                Me.ShowDialog()
            Catch exc As System.Exception
                'Resume in On-Error-Resume-Next Block
            End Try
            If vattu.MaSo > 0 Then
                Return vattu.sohieu
            Else
                Return ""
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return String.Empty
    End Function
    Private Sub LstVt_DoubleClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles LstVt.DoubleClick
        Me.Cursor = Cursors.WaitCursor
        Try
            If ConvertToDblSafe(Me.Tag) = 1 Then Hide()
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
    Private Sub LstVt_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles LstVt.KeyPress
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
            If KeyAscii = 13 Then LstVt_DoubleClick(LstVt, New EventArgs())
            If KeyAscii = 0 Then
                eventArgs.Handled = True
            End If
            'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    ''' <summary>
    ''' Thu tuc kiem tra va dua so lieu vao object
    ''' </summary>
    ''' <remarks></remarks>
    Private Function KiemTraSoLieu() As Boolean
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim result As Boolean = False
            If Strings.Len(TxtVT(0).Text) = 0 Then
                ErrMsg(er_SoHieu)
                TxtVT(0).Focus()
                Return result
            End If
            If Strings.Len(TxtVT(1).Text) = 0 Then
                ErrMsg(er_Ten)
                TxtVT(1).Focus()
                Return result
            End If
            If Strings.Len(TxtVT(2).Text) = 0 Then
                MessageBox.Show(Ngonngu("Thiếu đơn vị tính vật tư!", "Missing unit!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TxtVT(2).Focus()
                Return result
            End If
            
            With vattu
                If ThemMoi = 1 Then .MaSo = 0
                .MaPhanLoai = CboLoai.SelectedValue
                .sohieu = TxtVT(0).Text
                .TenVattu = TxtVT(1).Text
                .DonVi = TxtVT(2).Text
                .GiaHT = ConvertToDblSafe(TxtVT(3).Text)
                .TonMin = ConvertToDblSafe(txtTon(0).Text)
                .TonMax = ConvertToDblSafe(txtTon(1).Text)
                .TyLeQD = ConvertToDblSafe(TxtVT(5).Text)
                .VAT = ConvertToDblSafe(TxtVT(7).Text)
                .GiaBan1 = ConvertToDblSafe(TxtVT(8).Text)
                .GiaBan2 = ConvertToDblSafe(TxtVT(9).Text)
                .GiaBan3 = ConvertToDblSafe(TxtVT(10).Text)
                .CK = ConvertToDblSafe(TxtVT(12).Text)
                .Dvt2 = Chk.CheckState
                .DonVi2 = IIf(Strings.Len(TxtVT(4).Text) > 0, TxtVT(4).Text, "...")
                .GhiChu = IIf(Strings.Len(TxtVT(6).Text) > 0, TxtVT(6).Text, "...")
                If pNhapKhau > 0 Then .ThueNK = ConvertToDblSafe(TxtVT(13).Text)
            End With
            Return True
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function
    Private Sub LstVt_MouseDown(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles LstVt.MouseDown
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim sh = String.Empty, ten As String = String.Empty
            Dim m As Integer
            Dim flag As Integer
            Dim rs As DataTable
            If eventArgs.Button = MouseButtons.Right And LstVt.SelectedIndex >= 0 And ThemMoi = 0 Then
                If OutCost = 0 And ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM DVTVattu WHERE MaVattu={0}", vattu.MaSo))) = 0 Then
                    sh = FrmGetStr.GetString(String.Format("Chuyển {0} - {1} sang phân loại khác, hoặc gộp vào vật tư có số hiệu:", vattu.sohieu, vattu.TenVattu), My.Application.Info.ProductName)
                    flag = 1
                Else
                    sh = FrmGetStr.GetString(String.Format("Chuyển {0} - {1} sang phân loại có số hiệu:", vattu.sohieu, vattu.TenVattu), My.Application.Info.ProductName)
                End If
                If sh.Length > 0 Then
                    m = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM PhanLoaiVattu WHERE PLCon=0 AND SoHieu='{0}'", sh)))
                    If m > 0 And m <> vattu.MaPhanLoai Then
                        ExecSQLNonQuery(String.Format("UPDATE Vattu SET MaPhanLoai={0} WHERE MaSo = {1}", m, ConvertToStrSafe(vattu.MaSo)))
                        CboLoai_SelectedIndexChanged(CboLoai, New EventArgs())
                    End If
                    If m > 0 Or flag = 0 Then Exit Sub
                    m = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1, TenVattu AS F2 FROM Vattu WHERE SoHieu='{0}'", sh), ten))
                    If m > 0 And m <> vattu.MaSo Then
                        If MessageBox.Show(String.Format("Bạn đã chức chắn chuyển gộp vật tư {0} - {1} vào vật tư {2} - {3} ?", vattu.sohieu, vattu.TenVattu, sh, ten), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
                            Me.Cursor = Cursors.WaitCursor
                            ExecSQLNonQuery(String.Format("UPDATE ChungTu SET MaVattu={0} WHERE MaSo={1}", m, ConvertToStrSafe(vattu.MaSo)))
                            ExecSQLNonQuery(String.Format("UPDATE ChungTu2 SET MaVattu={0} WHERE MaSo={1}", m, ConvertToStrSafe(vattu.MaSo)))
                            ExecSQLNonQuery(String.Format("UPDATE ChungTuP SET MaVattu={0} WHERE MaSo={1}", m, ConvertToStrSafe(vattu.MaSo)))
                            rs = ExecSQLReturnDT(String.Format("SELECT MaSo, MaSoKho, MaTaiKhoan, Luong_0, Tien_0 FROM TonKho WHERE MaVattu={0} AND (Luong_0<>0 OR Tien_0<>0)", vattu.MaSo))
                            Dim rsIndex As Integer = 0
                            Do While rsIndex < rs.Rows.Count
                                Dim rsItem As DataRow = rs.Rows(rsIndex)
                                rsIndex += 1 ' C15 Rs LOOP CONTROL
                                Dim RecordsAffectedCount As Integer = ExecSQLNonQueryUpdateInsertDeleteQuery(String.Format("UPDATE TonKho SET Luong_0=Luong_0+{0},Tien_0=Tien_0+{1} WHERE MaVattu={2} AND MaSoKho={3} AND MaTaiKhoan={4}", CStr(rsItem("Luong_0")), CStr(rsItem("Tien_0")), ConvertToStrSafe(m), rsItem("MaSoKho"), rsItem("MaTaiKhoan")))
                                If RecordsAffectedCount = 0 Then ExecSQLNonQuery(String.Format("UPDATE TonKho SET MaVattu={0} WHERE MaVattu={1} AND MaSoKho={2} AND MaTaiKhoan={3}", m, ConvertToStrSafe(vattu.MaSo), rsItem("MaSoKho"), rsItem("MaTaiKhoan")))
                                ''rs.MoveNext()
                            Loop
                            ''rs.Close()
                            rs = Nothing
                            ExecSQLNonQuery(String.Format("DELETE FROM TonKho WHERE MaVattu={0}", vattu.MaSo))
                            vattu.XoaVT()
                            KiemTraVatTu()
                            CboLoai_SelectedIndexChanged(CboLoai, New EventArgs())
                            Me.Cursor = Cursors.Default
                        End If
                    End If
                End If
            End If
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
    Private Sub Pic_DoubleClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim i As Integer
            Dim st As String = String.Empty
            If pBarCode > 0 And vattu.MaSo > 0 Then
                st = FrmGetStr.GetString(Ngonngu("Số nhãn cần in", "Number of labels to be printed"), Ngonngu("In mã vạch", "Barcode printing"))
                i = ConvertToDblSafe(st)
                If i > 0 Then PrintBarCode(vattu, i)
            End If
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
    Private Sub SSCmdF_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles SSCmdF.Click
        Try
            If Strings.Len(txtF.Text) = 0 Then
                txtF.Focus()
                Exit Sub
            End If
            Me.Cursor = Cursors.WaitCursor
            Dim sql As String = String.Format("SELECT DISTINCT Top 1 SoHieu AS F1 FROM Vattu WHERE sohieu>'{0}' and maphanloai={1}", MaDaTim, CboLoai.SelectedValue)
            If SSOpt(0).Checked Then sql = String.Format("{0} AND SoHieu LIKE '%{1}%'", sql, txtF.Text)
            If SSOpt(1).Checked Then sql = String.Format("{0} AND TenVattu like  N'%{1}%'", sql, txtF.Text)
            sql = String.Format("{0} order by sohieu", sql)
            sql = ConvertToStrSafe(GetSelectValue(sql))
            If sql <> "0" Then
                ChonVattu(sql)
                MaDaTim = vattu.sohieu
            Else
                sql = String.Format("SELECT DISTINCT Top 1 SoHieu AS F1 FROM Vattu WHERE sohieu>'{0}'", MaDaTim, CboLoai.SelectedValue)
                If SSOpt(0).Checked Then sql = String.Format("{0} AND SoHieu LIKE '%{1}%'", sql, txtF.Text)
                If SSOpt(1).Checked Then sql = String.Format("{0} AND TenVattu like  N'%{1}%'", sql, txtF.Text)
                sql = String.Format("{0} order by sohieu", sql)
                sql = ConvertToStrSafe(GetSelectValue(sql))
                If sql <> "0" Then
                    ChonVattu(sql)
                    MaDaTim = vattu.sohieu
                Else
                    sql = String.Format("SELECT DISTINCT Top 1 SoHieu AS F1 FROM Vattu WHERE 1=1", MaDaTim, CboLoai.SelectedValue)
                    If SSOpt(0).Checked Then sql = String.Format("{0} AND SoHieu LIKE '%{1}%'", sql, txtF.Text)
                    If SSOpt(1).Checked Then sql = String.Format("{0} AND TenVattu like  N'%{1}%'", sql, txtF.Text)
                    sql = String.Format("{0} order by sohieu", sql)
                    sql = ConvertToStrSafe(GetSelectValue(sql))
                    If sql <> "0" Then
                        ChonVattu(sql)
                        MaDaTim = vattu.sohieu
                    Else
                        MaDaTim = ""
                    End If
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Throw New Exception("Lỗi tìm kiếm " + ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtF_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtF.Enter
        Me.Cursor = Cursors.WaitCursor
        Try
            txtF.SelectAll()
            MaDaTim = "A"
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
    Private Sub txtTyle_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtTyle.Leave
        Me.Cursor = Cursors.WaitCursor
        Try
            ExecSQLNonQuery((String.Format("UPDATE dinhmuc set tl={0} WHERE MaTP={1} AND Thang={2}", ConvertToDblSafe(txtTyle.Text), ConvertToStrSafe(vattu.MaSo), ConvertToStrSafe(IIf(pDinhmuc <> CheckState.Unchecked, CboThang.SelectedIndex, 1)))))
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
    Private Sub TxtVT_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(TxtVT, eventSender)
            If Index = 0 And pBarCode = 1 Then
                Pic.Image = Nothing
                BarCode(TxtVT(0).Text, Pic, 8, 400, 0, 0)
            End If
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
    Private Sub TxtVT_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim Index As Integer = Array.IndexOf(TxtVT, eventSender)
            TxtVT(Index).SelectAll()
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
    Private Sub txtTon_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtTon_2.Enter
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
            txtTon(Index).SelectAll()
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
    Private Sub txtTon_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtTon_2.KeyPress
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
            Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
            KeyProcess(txtTon(Index), KeyAscii)
            If KeyAscii = 0 Then
                eventArgs.Handled = True
            End If
            'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
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
    Private Sub txtTon_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtTon_2.Leave
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim Index As Integer = Array.IndexOf(txtTon, eventSender)
            txtTon(Index).Text = Format(txtTon(Index).Text, Mask_5)
            If Index = 2 And vattu.MaSo > 0 And ChucNang = 1 Then
                Dim RecordsAffectedCount As Integer = ExecSQLNonQueryUpdateInsertDeleteQuery(String.Format("UPDATE DinhMuc SET SoLuong={0} WHERE MaNVL=0 AND MaTP={1} AND Thang={2}", CStr(ConvertToDblSafe(txtTon(Index).Text)), ConvertToStrSafe(vattu.MaSo), ConvertToStrSafe(CboThang.SelectedValue)))
                If RecordsAffectedCount = 0 Then ExecSQLNonQuery(String.Format("INSERT INTO DinhMuc (MaSo,MaTP,MaNVL,SoLuong,Thang) VALUES ({0},{1},0,{2},{3})", Lng_MaxValue("MaSo", "DinhMuc") + 1, ConvertToStrSafe(vattu.MaSo), CStr(ConvertToDblSafe(txtTon(Index).Text)), ConvertToStrSafe(CboThang.SelectedValue)))
            End If
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
    Private Sub TxtVT_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
            Dim Index As Integer = Array.IndexOf(TxtVT, eventSender)
            Select Case Index
                Case 0
                    If KeyAscii = 32 Or KeyAscii = 39 Or KeyAscii = 42 Then KeyAscii = 0
                Case 3, 5, 7, 8, 9, 10, 13 : KeyProcess(TxtVT(Index), KeyAscii)
            End Select
            If KeyAscii = 0 Then
                eventArgs.Handled = True
            End If
            'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
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
    Private Sub TxtVT_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim Index As Integer = Array.IndexOf(TxtVT, eventSender)
            Select Case Index
                Case 0
                    TxtVT(0).Text = TxtVT(0).Text.ToUpper()
                Case 3
                    TxtVT(3).Text = Format(TxtVT(3).Text, Mask_5)
                Case 5, 7, 8, 9, 10, 13
                    TxtVT(Index).Text = Format(TxtVT(Index).Text, Mask_2)
            End Select
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
    Private Sub CmdChitiet_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _CmdChitiet_1.Click, _CmdChitiet_0.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim Index As Integer = Array.IndexOf(CmdChitiet, eventSender)
            Dim gia, luong, soluong, tlht As Double
            Dim pl As String = String.Empty
            If vattu.MaSo = 0 Then Exit Sub
            Dim i As Integer = IIf(pDinhmuc <> CheckState.Unchecked, CboThang.SelectedValue, 1)
            Select Case Index
                Case 0
                    If Not (vt.MaSo = 0) Then
                        luong = ConvertToDblSafe(txtNhap(7).Text)
                        tlht = ConvertToDblSafe(txtNhap(8).Text)
                        soluong = ConvertToDblSafe(txtNhap(3).Text)
                        pl = txtNhap(10).Text.ToUpper()
                        If pl = "" Then pl = "-"
                        If soluong <= 0 And luong <= 0 Then
                            txtNhap(3).Focus()
                            Exit Sub
                        End If
                        Dim RecordsAffectedCount As Integer = ExecSQLNonQueryUpdateInsertDeleteQuery(String.Format("UPDATE DinhMuc SET SoLuong={0},luong={1}  WHERE MaTP={2} AND MaNVL={3} AND Thang={4}", soluong, luong, ConvertToStrSafe(vattu.MaSo), ConvertToStrSafe(vt.MaSo), ConvertToStrSafe(i)))
                        If RecordsAffectedCount <= 0 Then
                            If ExecSQLNonQuery(String.Format("INSERT INTO DinhMuc (MaSo,MaTP,MaNVL,SoLuong,luong,Thang,PL,TL,dain,TLHT) VALUES ({0},{1},{2},{3},{4},{5}, N'{6}',{7},'',{8})", Lng_MaxValue("MaSo", "DinhMuc") + 1, ConvertToStrSafe(vattu.MaSo), ConvertToStrSafe(vt.MaSo), CStr(soluong), ConvertToStrSafe(luong), ConvertToStrSafe(i), pl, txtTyle.Text, ConvertToStrSafe(tlht))) = 0 Then
                                GrdNT(0).AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}", _
                                                     vt.sohieu, _
                                                     Chr(9), _
                                                     vt.TenVattu, _
                                                     vt.DonVi, _
                                                     Format(soluong, Mask_5), _
                                                     Format(luong, Mask_0), _
                                                     Format(tlht, Mask_0), _
                                                     pl, _
                                                     Lng_MaxValue("MaSo", "DinhMuc") + 1))
                            End If
                        End If
                        vt.InitVattuMaSo(0)
                        For i = 0 To 3
                            txtNhap(i).Text = ""
                        Next
                        txtNhap(7).Text = ""
                        txtNhap(8).Text = ""
                        txtNhap(10).Text = ""
                    End If
                    txtNhap(0).Focus()
                Case 1
                    If Not (ts.maso = 0) Then
                        luong = ConvertToDblSafe(txtNhap(6).Text)
                        If luong <= 0 Then
                            txtNhap(6).Focus()
                            Exit Sub
                        End If
                        Dim RecordsAffectedCount As Integer = ExecSQLNonQueryUpdateInsertDeleteQuery(String.Format("UPDATE DinhMuc SET SoLuong={0}  WHERE MaTP={1} AND MaNVL={2} AND Thang={3}", CStr(luong), ConvertToStrSafe(vattu.MaSo), ConvertToStrSafe(-ts.maso), ConvertToStrSafe(i)))
                        If RecordsAffectedCount > 0 Then
                            CboThang_SelectedIndexChanged(CboThang, New EventArgs())
                        Else
                            If ExecSQLNonQuery(String.Format("INSERT INTO DinhMuc (MaSo,MaTP,MaNVL,SoLuong,Thang,PL,dain) VALUES ({0},{1},{2},{3},{4},'','')", Lng_MaxValue("MaSo", "DinhMuc") + 1, ConvertToStrSafe(vattu.MaSo), ConvertToStrSafe(-ts.maso), CStr(luong), ConvertToStrSafe(i))) = 0 Then
                                GrdNT(1).AddItem(String.Format("{0}{1}{2}{1}{3}", _
                                                     ts.sohieu, _
                                                     Chr(9), _
                                                     ts.ten, _
                                                     Format(luong, Mask_5)), 0)
                            End If
                        End If
                        ts.KhoiTao()
                        For i = 4 To 6
                            txtNhap(i).Text = ""
                        Next
                    End If
                    txtNhap(4).Focus()
                Case 2
                    luong = ConvertToDblSafe(TxtVT(5).Text)
                    If vattu.MaSo = 0 Or luong = 0 Then Exit Sub
                    gia = ConvertToDblSafe(TxtVT(11).Text)
                    With GrdNT(3)
                        For i = 0 To .Rows - 1
                            .Row = ConvertToDblSafe(i)
                            .Col = 0
                            If .CtlText.Length = 0 Then Exit For
                            If .CtlText = TxtVT(4).Text Then
                                If ThemMoi = 0 Then
                                    .Col = 3
                                    ExecSQLNonQuery(String.Format("UPDATE DVTVattu SET TyleQD={0},GiaBan={1} WHERE MaSo={2}", CStr(luong), CStr(gia), .CtlText))
                                End If
                                .Col = 1
                                .CtlText = Format(luong, Mask_2)
                                .Col = 2
                                .CtlText = Format(gia, Mask_2)
                                Exit Sub
                            End If
                        Next
                        If ThemMoi = 0 Then
                            ExecSQLNonQuery(String.Format("INSERT INTO DVTVattu (MaSo,MaVattu,DonVi,TyleQD,GiaBan) VALUES ({0},{1},'{2}',{3},{4})", Lng_MaxValue("MaSo", "DVTVattu") + 1, ConvertToStrSafe(vattu.MaSo), TxtVT(4).Text, CStr(luong), CStr(gia)))
                            GrdNT(3).AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}", _
                                                 TxtVT(4).Text, _
                                                 Chr(9), _
                                                 Format(luong, Mask_2), _
                                                 Format(gia, Mask_2), _
                                                 ConvertToStrSafe(Lng_MaxValue("MaSo", "DVTVattu"))), 0)
                            vattu.KTraDVT2()
                        Else
                            GrdNT(3).AddItem(String.Format("{0}{1}{2}{1}{3}", _
                                                 TxtVT(4).Text, _
                                                 Chr(9), _
                                                 Format(luong, Mask_2), _
                                                 Format(gia, Mask_2)), 0)
                        End If
                    End With
                    TxtVT(4).Text = ""
                    TxtVT(5).Text = ""
                    TxtVT(11).Text = ""
                    TxtVT(4).Focus()
            End Select
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
    Private Sub GrdNT_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim Index As Integer = Array.IndexOf(GrdNT, eventSender)
            Dim ms As Integer
            Select Case Index
                Case 0
                    With GrdNT(0)
                        .Col = 0
                        If .CtlText.Length = 0 Then Exit Sub
                        vt.InitVattuSohieu(.CtlText)
                        ms = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM DinhMuc WHERE MaTP={0} AND MaNVL={1}", _
                                                                 vattu.MaSo, _
                                                                 ConvertToStrSafe(vt.MaSo))))
                        If ExecSQLNonQuery(String.Format("DELETE FROM DinhMuc WHERE MaTP={0} AND MaNVL={1} and thang={2}", _
                                               vattu.MaSo, _
                                               ConvertToStrSafe(vt.MaSo), _
                                               ConvertToStrSafe(CboThang.SelectedValue))) <> 0 Then
                            vt.InitVattuMaSo(0)
                            Exit Sub
                        End If
                        For i As Integer = 0 To 3
                            .Col = ConvertToDblSafe(i)
                            txtNhap(i).Text = .CtlText
                        Next
                        .Col = 4
                        txtNhap(7).Text = .CtlText
                        .Col = 5
                        txtNhap(10).Text = .CtlText
                        .RemoveItem(.Row)
                        If .Rows < ConvertToDblSafe(.Tag) Then .Rows = ConvertToDblSafe(.Tag)
                        vt.InitVattuSohieu(txtNhap(0).Text)
                        txtNhap(0).Focus()
                    End With
                Case 1
                    With GrdNT(1)
                        .Col = 0
                        If .CtlText.Length = 0 Then Exit Sub
                        ts.ChiDinhSH(.CtlText)
                        If ExecSQLNonQuery(String.Format("DELETE FROM DinhMuc WHERE MaTP={0} AND MaNVL={1}", _
                                               vattu.MaSo, _
                                               ConvertToStrSafe(-ts.maso))) <> 0 Then
                            ts.KhoiTao()
                            Exit Sub
                        End If
                        For i As Integer = 0 To 2
                            .Col = ConvertToDblSafe(i)
                            txtNhap(i + 4).Text = .CtlText
                        Next
                        .RemoveItem(.Row)
                        If .Rows < ConvertToDblSafe(.Tag) Then .Rows = ConvertToDblSafe(.Tag)
                        ts.ChiDinhSH(txtNhap(4).Text)
                        txtNhap(4).Focus()
                    End With
                Case 3
                    With GrdNT(3)
                        .Col = 0
                        If .CtlText.Length = 0 Then Exit Sub
                        If ThemMoi = 0 Then
                            TxtVT(4).Text = .CtlText
                            .Col = 1
                            TxtVT(5).Text = .CtlText
                            .Col = 2
                            TxtVT(11).Text = .CtlText
                            .Col = 3
                            If vattu.XoaDVT(ConvertToDblSafe(.CtlText)) Then
Xoa:
                                .RemoveItem(.Row)
                                If GrdNT(3).Rows < ConvertToDblSafe((GrdNT(3).Tag)) Then GrdNT(3).Rows = ConvertToDblSafe(ConvertToDblSafe((GrdNT(3).Tag)))
                            End If
                        Else
                            GoTo Xoa
                        End If
                        TxtVT(4).Focus()
                    End With
            End Select
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
    Private Sub GrdNT_KeyPressEvent(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim Index As Integer = Array.IndexOf(GrdNT, eventSender)
            Select Case eventArgs.KeyChar
                Case Chr(Keys.Enter)
                    GrdNT_DblClick(GrdNT(Index), New EventArgs())
            End Select
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
    Private Sub txtNhap_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtNhap_7.Enter, _txtNhap_6.Enter, _txtNhap_3.Enter, _txtNhap_2.Enter, _txtNhap_1.Enter, _txtNhap_0.Enter, _txtNhap_4.Enter, _txtNhap_5.Enter, _txtNhap_10.Enter
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim Index As Integer = Array.IndexOf(txtNhap, eventSender)
            txtNhap(Index).SelectAll()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    ''' <summary>
    ''' Hiển thị danh sách nguyên tệ
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LietKeDinhMuc(Optional ByRef ThemMoi As Integer = 0)
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim rs As DataTable
            Dim thang1, thang2 As Integer
            ClearGrid(GrdNT(0), ConvertToDblSafe(GrdNT(0).Tag))
            ClearGrid(GrdNT(1), ConvertToDblSafe(GrdNT(1).Tag))
            txtTon(2).Text = "0"
            If pDinhmuc <> CheckState.Unchecked Then
                thang1 = CboThang.SelectedValue  ' GetSelectValue("SELECT TOP 1 Thang AS F1 FROM DinhMuc WHERE MaTP=" + ConvertToStrSafe(vattu.maso) + " AND " + WThang("Thang", 0, CboThang.ItemData(CboThang.ListIndex)) + " ORDER BY " + SetMonthOrder("Thang") + " DESC"))
                If ThemMoi = 0 Then
                    While dem = 0 And thang1 > 0
                        thang1 -= 1
                        dem = ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(maso) as f1 FROM dinhmuc WHERE MaTP={0} AND Thang={1}", vattu.MaSo, ConvertToStrSafe(thang1))))
                    End While
                    If thang1 = 0 Then Exit Sub
                    SetListIndex(CboThang, CStr(thang1))
                Else
                    thang2 = thang1
                    dem = 0
                    While dem = 0 And thang2 > 0
                        thang2 -= 1
                        dem = ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(maso) as f1 FROM dinhmuc WHERE MaTP={0} AND Thang={1}", vattu.MaSo, ConvertToStrSafe(thang2))))
                    End While
                    rs = ExecSQLReturnDT(String.Format("SELECT dinhmuc.* FROM dinhmuc WHERE MaTP={0} AND Thang={1}", vattu.MaSo, ConvertToStrSafe(thang2)))
                    Dim rsIndex2 As Integer, sql As String, rsItem As DataRow
                    While rsIndex2 < rs.Rows.Count
                        rsItem = rs.Rows(rsIndex2)
                        rsIndex2 += 1
                        Try
                            sql = String.Format("INSERT into dinhmuc(maso,matp,manvl,soluong,thang,thanghl,pl,luong,tlht,tl,dain) values({0},{1},{2},{3},{4},{5},'{6}',{7},{8},{9},'')" _
                                                , Lng_MaxValue("maso", "dinhmuc") + 1, rsItem("MaTP"), rsItem("maNVL"), doidau(rsItem("soluong")), thang1, If(rsItem("thanghl").ToString = "", 0, rsItem("thanghl")), rsItem("pl"), _
                                                doidau(rsItem("luong")), rsItem("tlht"), rsItem("TL"))
                            ExecSQLNonQuery(sql)
                        Catch ex As Exception

                        Finally

                        End Try
                    End While
                End If
            Else
                thang1 = 1
            End If
            'ClearGrid(GrdNT(0), ConvertToDblSafe(GrdNT(0).Tag))
            'ClearGrid(GrdNT(1), ConvertToDblSafe(GrdNT(1).Tag))

            rs = ExecSQLReturnDT(String.Format("SELECT SoHieu,TenVattu,DonVi,SoLuong,MaNVL,PL,luong,tlht,TL,DinhMuc.MaSo as maso FROM DinhMuc INNER JOIN Vattu ON DinhMuc.MaNVL=Vattu.MaSo WHERE MaTP={0} AND Thang={1} ORDER BY SoHieu DESC", _
                                     vattu.MaSo, _
                                     ConvertToStrSafe(thang1)))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                txtTyle.Text = IIf(IsDBNull(rsItem("TL")), "0", rsItem("TL"))
            Else
                txtTyle.Text = "0"
            End If
            Dim rsIndex As Integer = 0
            ClearGrid(GrdNT(0), GrdNT(0).Items.Count)
            Do While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1
                GrdNT(0).AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}", _
                                     rsItem("SoHieu"), _
                                     Chr(9), _
                                     rsItem("TenVattu"), _
                                     rsItem("DonVi"), _
                                     Format(rsItem("soluong"), Mask_5), _
                                     Format(rsItem("luong"), Mask_0), _
                                     Format(rsItem("tlht"), Mask_0), _
                                     rsItem("pl"), _
                                     rsItem("maso")), 0)
            Loop
            GrdNT(0).Row = 0
            GrdNT(0).Col = 0
            txtTon(2).Text = Format((GetSelectValue(String.Format("SELECT SoLuong AS F1 FROM DinhMuc WHERE MaNVL=0 AND MaTP={0} And Thang = {1}", _
                                                        vattu.MaSo, _
                                                        ConvertToStrSafe(thang1)))), Mask_5)
            rs = ExecSQLReturnDT(String.Format("SELECT SoHieu,Ten,SoLuong FROM DinhMuc INNER JOIN TaiSan ON DinhMuc.MaNVL=-TaiSan.MaSo WHERE MaTP={0} AND Thang={1} ORDER BY SoHieu DESC", _
                                     vattu.MaSo, _
                                     ConvertToStrSafe(thang1)))
            rsIndex = 0
            Do While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                GrdNT(1).Col = GrdNT(1).Cols - 1
                GrdNT(1).CtlText = ConvertToStrSafe(rsItem("SoHieu"))
                GrdNT(1).Col = 0
                GrdNT(1).CtlText = ConvertToStrSafe(rsIndex + 1)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                GrdNT(1).AddItem(String.Format("{0}{1}{2}{1}{3}", _
                                     rsItem("SoHieu"), _
                                     Chr(9), _
                                     rsItem("ten"), _
                                     Format(rsItem("soluong"), Mask_5)), 0)
                ''rs.MoveNext()
            Loop
            GrdNT(1).Row = 0
            GrdNT(1).Col = 0
            ''rs.Close()
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
    Private Sub txtNhap_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtNhap_7.KeyPress, _txtNhap_6.KeyPress, _txtNhap_3.KeyPress, _txtNhap_2.KeyPress, _txtNhap_1.KeyPress, _txtNhap_0.KeyPress, _txtNhap_4.KeyPress, _txtNhap_5.KeyPress, _txtNhap_10.KeyPress
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
            Dim Index As Integer = Array.IndexOf(txtNhap, eventSender)
            Dim f As FrmVattu
            Select Case Index
                Case 0
                    If KeyAscii = ConvertToDblSafe(Keys.Return) Then
                        f = New FrmVattu()
                        KtLoadFocus = 1
                        txtNhap(0).Text = f.ChonVattu(txtNhap(0).Text, 1, 0, 1)
                        KtLoadFocus = 0
                        txtNhap(0).Focus()
                        f = Nothing
                    End If
                Case 3
                    If KeyAscii = 13 Then CmdChitiet_Click(CmdChitiet(0), New EventArgs()) Else KeyProcess(txtNhap(Index), KeyAscii)
                Case 6 : KeyProcess(txtNhap(Index), KeyAscii)
                Case 4
                    If KeyAscii = 13 Then
                        txtNhap(4).Text = frmDSTaiSan.ChonTaiSan(txtNhap(4).Text, 1, 12)
                        txtNhap(4).Focus()
                    End If
            End Select
            If KeyAscii = 0 Then
                eventArgs.Handled = True
            End If
            'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
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
    Private Sub txtNhap_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtNhap_7.Leave, _txtNhap_6.Leave, _txtNhap_3.Leave, _txtNhap_2.Leave, _txtNhap_1.Leave, _txtNhap_0.Leave, _txtNhap_4.Leave, _txtNhap_5.Leave, _txtNhap_10.Leave
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim Index As Integer = Array.IndexOf(txtNhap, eventSender)
            Dim Conlai As Integer
            Select Case Index
                Case 0
                    Conlai = ConvertToDblSafe(100 - ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(luong)as f1 FROM dinhmuc WHERE MaTP={0} AND Thang={1}", _
                                                                                        vattu.MaSo, _
                                                                                        ConvertToStrSafe(IIf(pDinhmuc <> CheckState.Unchecked, CboThang.SelectedValue, 1))))))
                    'If txtNhap(0).Text = "" And Conlai <> 0 And KtLoadFocus = 0 Then
                    '    If MessageBox.Show("Cho phép tổng tỷ lệ nhỏ hơn 100!", My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
                    '        txtNhap(0).Focus() : Exit Sub
                    '    End If
                    'End If
                    vt.InitVattuSohieu(txtNhap(0).Text)
                    txtNhap(1).Text = vt.TenVattu
                    txtNhap(2).Text = vt.DonVi
                    If vt.MaSo <> 0 Then txtNhap(7).Text = ConvertToStrSafe(Conlai)
                Case 3, 6
                    txtNhap(Index).Text = Format(txtNhap(Index).Text, Mask_5)
                Case 4
                    ts.ChiDinhSH(txtNhap(Index).Text)
                    txtNhap(5).Text = ts.ten
            End Select
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ThemVattu(ByRef sh As String) As String
        Me.Cursor = Cursors.WaitCursor
        Try
            If xT = 1 Then
                Return String.Empty
                Exit Function
            End If
            Me.Tag = "1"
            xT = 1
            xSH = sh
            Me.ShowDialog()
            xT = 0
            xSH = ""
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return vattu.sohieu
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mkho"></param>
    ''' <param name="mvt"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="thongbao"></param>
    ''' <param name="loai"></param>
    ''' <param name="nn"></param>
    ''' <remarks></remarks>
    Private Sub LietKeTonKho(ByRef mkho As Integer, ByRef mvt As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef thongbao As Boolean, Optional ByRef loai As Integer = 0, Optional ByRef nn As Integer = 0)
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim dkt, dkt2 As Double
            Dim rs As DataTable
            Dim sql, st As String
            Dim sqll As New StringBuilder
            Dim i As Integer
            Dim ps As Double
            For i = CThangDB2(tdau) To CThangDB2(tcuoi)
                If sqll.Length = 0 Then
                    sqll.Append(String.Format("Luong_Nhap_{0} + Luong_Xuat_{0} + Tien_Nhap_{0} + Tien_Xuat_{0}", i))
                Else
                    sqll.Append(String.Format(" + Luong_Nhap_{0} + Luong_Xuat_{0} + Tien_Nhap_{0} + Tien_Xuat_{0}", i))
                End If
            Next

            Dim qThang As Integer = CThangDB2(ThangTruoc(tdau))
            st = ConvertToStrSafe(IIf(qThang = 0, 1, qThang))
            Dim sql11 As String = String.Format("SELECT SUM(Luong_{0}) As F1, SUM(Tien_{0}) As F2,{1} As F3, SUM({2}) As F4 FROM TonKho WHERE MaVattu = {3}{4}", _
                                                                    st, _
                                                                    (IIf(pGiaUSD > 0, String.Format("Sum(USDTien_{0})", st), "0")), _
                                                                    sqll, _
                                                                    ConvertToStrSafe(mvt), _
                                                                    (IIf(mkho > 0, String.Format(" AND  MaSoKho = {0}", mkho), String.Empty)))
            Dim dkl As Double = ConvertToDblSafe(GetSelectValue(String.Format("SELECT isnull(SUM(Luong_{0}),0) As F1, isnull(SUM(Tien_{0}),0) As F2,{1} As F3, isnull(SUM({2}),0) As F4 FROM TonKho WHERE MaVattu = {3}{4}", _
                                                                    st, _
                                                                    (IIf(pGiaUSD > 0, String.Format("isnull(Sum(USDTien_{0}),0)", st), "0")), _
                                                                    sqll, _
                                                                    ConvertToStrSafe(mvt), _
                                                                    (IIf(mkho > 0, String.Format(" AND  MaSoKho = {0}", mkho), String.Empty))), dkt, dkt2, ps))
            If Not (dkl = 0 And dkt = 0 And dkt2 = 0 And ps = 0) Then
                If ps <> 0 Then
                    sql = String.Format("SELECT DISTINCT ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.DienGiai{0} as DienGiai, ChungTu.MaLoai, ChungTu.SoPS, ChungTu.SoPS2No, ChungTu.SoPS2Co, ChungTu.MaTKTCNo, ChungTu.MaTKTCCo, HeThongTK.SoHieu as SohieuTK, HeThongTK_1.SoHieu as SohieuTK1, ChungTu.GhiChu, ChungTu.MaKho, ChungTu.MaNguon,{1} AS PSUSD1, DonVi, TyLeQD, ChungTu.NgayGS,ct_id ,ChungTu.MaCT FROM (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo) ON HeThongTK_1.MaSo = ChungTu.MaTKCo) LEFT JOIN DVTVattu ON ChungTu.DVT=DVTVattu.MaSo  WHERE (SoPS2No<>0 OR SoPS2Co<>0 OR SoPS<>0) AND (HethongTK.TK_ID={2} OR HethongTK_1.TK_ID={3}) AND ((ChungTu.MaLoai =13 OR ChungTu.MaLoai =1 OR ChungTu.MaLoai =2 OR ChungTu.MaLoai =4) AND {4} And (chungtu.MaVattu = {5}){6})  ORDER BY ChungTu.NgayGS desc, ChungTu.MaCT desc", _
                              (IIf(pNN > 0, "E", String.Empty)), _
                              (IIf(pGiaUSD > 0, "ChungTu.PSUSD", "0")), _
                              TKVT_ID, _
                              ConvertToStrSafe(TKVT_ID), _
                              WThang("ThangCT", tdau, tcuoi), _
                              ConvertToStrSafe(mvt), _
                              (IIf(mkho > 0, String.Format(" And (((chungtu.MaLoai=13 or chungtu.MaLoai<4) And chungtu.MaKho = {0}) OR (chungtu.MaLoai=4 And (chungtu.MaKho = {1} OR chungtu.MaNguon = {1})))", _
                                                 mkho, _
                                                 ConvertToStrSafe(mkho)), String.Empty)))
                    rs = ExecSQLReturnDT(sql)
                    ClearGrid(Grd, Grd.Rows)
                    Dim ss, sr, dk As Double
                    If rs.Rows.Count > 0 Then
                        i = 1
                        Dim rsIndex As Integer = 0
                        While rsIndex < rs.Rows.Count
                            Dim rsItem As DataRow = rs.Rows(rsIndex)
                            rsIndex += 1
                            With Grd
                                Dim dgia As Double = Nothing
                                Dim sohieu As String, chuoi As String, ngay As String, str As String
                                If loai = 0 Then
                                    If (rsItem("maloai") = 1 Or rsItem("maloai") = 13) Or (rsItem("maloai") = 4 And (rsItem("MaKho") < 0 Or (rsItem("MaKho") = rsItem("MaNguon") And rsItem("MaKho") > 0))) Then
                                        sohieu = rsItem("SoHieu")
                                        sr = rsItem("sops")
                                        ss = rsItem("SoPS2No")
                                        If ss <> 0 And sr <> 0 Then
                                            dgia = Format(sr / ss, Mask_0)
                                        End If
                                        chuoi = rsItem("NgayCT").ToString
                                        ngay = chuoi.Split(" ")(0)
                                        str = String.Format("{0}{1}{2}{1}{3}", _
                                            rsItem("SoHieu"), _
                                            Chr(9), _
                                            ngay, _
                                            Format(dgia, Mask_0))
                                        Grd.AddItem(str, i)
                                        i = i + 1
                                    End If
                                Else
                                    If (rsItem("maloai") = 2) Or (rsItem("maloai") = 4 And (rsItem("MaKho") < 0 Or (rsItem("MaKho") = rsItem("MaNguon") And rsItem("MaKho") > 0))) Then
                                        dk = rsItem("CT_ID")
                                        sohieu = IIf(dk < 510000000 And dk > 500000000, Timten("sohieu", ConvertToStrSafe(dk - 500000000), "maso", "chungtu"), rsItem("SoHieu"))
                                        sr = IIf(dk < 510000000 And dk > 500000000, ConvertToDblSafe(Timten("sops", ConvertToStrSafe(dk - 500000000), "maso", "chungtu")), rsItem("sops"))
                                        ss = rsItem("SoPS2Co")
                                        If ss <> 0 And sr <> 0 Then
                                            dgia = Format(sr / ss, Mask_0)
                                        End If
                                        chuoi = rsItem("NgayCT").ToString
                                        ngay = chuoi.Split(" ")(0)
                                        str = String.Format("{0}{1}{2}{1}{3}", _
                                            sohieu, _
                                            Chr(9), _
                                            ngay, _
                                            Format(dgia, Mask_0))

                                        Grd.AddItem(str, i)
                                        i = i + 1
                                    End If
                                End If
                            End With
                        End While
                    End If
                    Exit Sub
                End If
            End If
            ClearGrid(Grd, Grd.Rows)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Me.Cursor = Cursors.WaitCursor
        Try
            If Command(1).Enabled Or Command(2).Enabled Then
                Command(1).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
                Command(2).Enabled = (User_Right <> 2 Or (UserID = uid))
                Chk.Enabled = False
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Throw New Exception(ex.Message)
        End Try
        
    End Sub

    Private Sub _GrdNT_0_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _GrdNT_0.DoubleClick
        Me.Cursor = Cursors.WaitCursor
        Try
            _GrdNT_0.Col = 0
            Dim ma As String = ""
            If _GrdNT_0.CtlText.Length > 0 Then
                ' DCPTung.MaSo = ConvertToDblSafe(_GrdNT_0)
                _GrdNT_0.Col = 0 : _txtNhap_0.Text = _GrdNT_0.CtlText
                _GrdNT_0.Col = 1 : _txtNhap_1.Text = _GrdNT_0.CtlText
                _GrdNT_0.Col = 2 : _txtNhap_2.Text = _GrdNT_0.CtlText
                _GrdNT_0.Col = 3 : _txtNhap_3.Text = _GrdNT_0.CtlText
                _GrdNT_0.Col = 4 : _txtNhap_7.Text = _GrdNT_0.CtlText
                _GrdNT_0.Col = 5 : _txtNhap_8.Text = _GrdNT_0.CtlText
                _GrdNT_0.Col = 6 : _txtNhap_10.Text = _GrdNT_0.CtlText
                _GrdNT_0.Col = 7 : ma = _GrdNT_0.CtlText
                Dim sql As String = "delete from DinhMuc where MaSo = '" & ma & "'"
                ExecSQLReturnDT(sql)
                _txtNhap_0.Focus()
                _GrdNT_0.RemoveItem(_GrdNT_0.Row)
                '_GrdNT_0.AddItem("")
                ' hienthi_luoi()
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    Private Sub hienthi_luoi()
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim thang1 As Integer = CboThang.SelectedValue
            Dim sql As String = String.Format("SELECT SoHieu,TenVattu,DonVi,SoLuong,MaNVL,PL,luong,TL FROM DinhMuc INNER JOIN Vattu ON DinhMuc.MaNVL=Vattu.MaSo WHERE MaTP={0} AND Thang={1} ORDER BY SoHieu DESC", _
                                    vattu.MaSo, _
                                    ConvertToStrSafe(thang1))
            Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT SoHieu,TenVattu,DonVi,SoLuong,MaNVL,PL,luong,TL,DinhMuc.MaSo as maso FROM DinhMuc INNER JOIN Vattu ON DinhMuc.MaNVL=Vattu.MaSo WHERE MaTP={0} AND Thang={1} ORDER BY SoHieu DESC", _
                                    vattu.MaSo, _
                                    ConvertToStrSafe(thang1)))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                txtTyle.Text = IIf(IsDBNull(rsItem("TL")), "0", rsItem("TL"))
            Else
                txtTyle.Text = "0"
            End If
            Dim rsIndex As Integer = 0
            Do While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                GrdNT(0).Col = GrdNT(0).Cols - 1
                GrdNT(0).CtlText = ConvertToStrSafe(rsItem("SoHieu"))
                GrdNT(0).Col = 0
                GrdNT(0).CtlText = ConvertToStrSafe(rsIndex + 1)
                GrdNT(0).AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}", _
                                     rsItem("SoHieu"), _
                                     Chr(9), _
                                     rsItem("TenVattu"), _
                                     rsItem("DonVi"), _
                                     Format(rsItem("soluong"), Mask_5), _
                                     Format(rsItem("luong"), Mask_0), _
                                     rsItem("pl"), _
                                     rsItem("MaSo")), 0)
                ''rs.MoveNext()
            Loop
            'GrdNT(0).Row = 0
            'GrdNT(0).Col = 0
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Throw New Exception(ex.Message)
        End Try
        
    End Sub

    Private Sub _GrdNT_1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _GrdNT_1.DoubleClick
        Me.Cursor = Cursors.WaitCursor
        Try
            _GrdNT_3.Col = 0
            Dim ma As String = ""
            Dim a As String = _GrdNT_3.FocusedItem.SubItems.Item(0).Text
            Dim a1 As String = _GrdNT_3.FocusedItem.SubItems.Item(1).Text
            Dim a2 As String = _GrdNT_3.FocusedItem.SubItems.Item(2).Text
            Dim a3 As Integer = _GrdNT_3.FocusedItem.SubItems.Item(3).Text
            If a.Length > 0 Then
                TxtVT(4).Text = a
                TxtVT(5).Text = a1
                TxtVT(11).Text = a2
                vattu.XoaDVT(ConvertToDblSafe(a3))
                _GrdNT_3.RemoveItem(_GrdNT_3.Row)
                TxtVT(4).Focus()
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub Grd_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grd.DoubleClick
        Me.Cursor = Cursors.WaitCursor
        Try
            FrmChungtu.khoi_tao()
            Dim result As DialogResult = MessageBox.Show("Bạn muốn sửa chứng từ.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                FrmChungtu.loadluoi = 1
                FrmChungtu.flag = 2
                Dim sh As String = Grd.FocusedItem.SubItems(0).Text
                FrmChungtu.Suatonkho(sh)
                ' FrmChungtu.flag = 0
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub _CmdChitiet_2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _CmdChitiet_2.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim gia, luong As Double
            Dim pl As String = String.Empty
            If vattu.MaSo = 0 Then Exit Sub
            Dim i As Integer = IIf(pDinhmuc <> CheckState.Unchecked, CboThang.SelectedValue, 1)
            luong = ConvertToDblSafe(TxtVT(5).Text)
            If vattu.MaSo = 0 Or luong = 0 Then Exit Sub
            gia = ConvertToDblSafe(TxtVT(11).Text)
            With GrdNT(3)
                For i = 0 To .Rows - 1
                    .Row = ConvertToDblSafe(i)
                    .Col = 0
                    If .CtlText.Length = 0 Then Exit For
                    If .CtlText = TxtVT(4).Text Then
                        If ThemMoi = 0 Then
                            .Col = 3
                            ExecSQLNonQuery(String.Format("UPDATE DVTVattu SET TyleQD={0},GiaBan={1} WHERE MaSo={2}", CStr(luong), CStr(gia), .CtlText))
                        End If
                        .Col = 1
                        .CtlText = Format(luong, Mask_2)
                        .Col = 2
                        .CtlText = Format(gia, Mask_2)
                        Exit Sub
                    End If
                Next
                If ThemMoi = 0 Then
                    ExecSQLNonQuery(String.Format("INSERT INTO DVTVattu (MaSo,MaVattu,DonVi,TyleQD,GiaBan) VALUES ({0},{1},'{2}',{3},{4})", Lng_MaxValue("MaSo", "DVTVattu") + 1, ConvertToStrSafe(vattu.MaSo), TxtVT(4).Text, CStr(luong), CStr(gia)))
                    GrdNT(3).AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}", _
                                         TxtVT(4).Text, _
                                         Chr(9), _
                                         Format(luong, Mask_2), _
                                         Format(gia, Mask_2), _
                                         ConvertToStrSafe(Lng_MaxValue("MaSo", "DVTVattu"))), 0)
                    vattu.KTraDVT2()
                Else
                    GrdNT(3).AddItem(String.Format("{0}{1}{2}{1}{3}", _
                                         TxtVT(4).Text, _
                                         Chr(9), _
                                         Format(luong, Mask_2), _
                                         Format(gia, Mask_2)), 0)
                End If
            End With
            TxtVT(4).Text = ""
            TxtVT(5).Text = ""
            TxtVT(11).Text = ""
            TxtVT(4).Focus()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub Chk_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk.CheckedChanged
        Me.Cursor = Cursors.WaitCursor
        Try
            If Chk.Checked = False Then
                TxtVT(4).Enabled = False
                TxtVT(5).Enabled = False
                TxtVT(11).Enabled = False
                _CmdChitiet_2.Enabled = False
            Else
                TxtVT(4).Enabled = True
                TxtVT(5).Enabled = True
                TxtVT(11).Enabled = True
                _CmdChitiet_2.Enabled = True
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub _GrdNT_3_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _GrdNT_3.DoubleClick
        Me.Cursor = Cursors.WaitCursor
        Try
            _GrdNT_3.Col = 0
            Dim ma As String = ""
            Dim a As String = _GrdNT_3.FocusedItem.SubItems.Item(0).Text
            Dim a1 As String = _GrdNT_3.FocusedItem.SubItems.Item(1).Text
            Dim a2 As String = _GrdNT_3.FocusedItem.SubItems.Item(2).Text
            Dim a3 As Integer = _GrdNT_3.FocusedItem.SubItems.Item(3).Text
            If a.Length > 0 Then
                TxtVT(4).Text = a
                TxtVT(5).Text = a1
                TxtVT(11).Text = a2
                vattu.XoaDVT(ConvertToDblSafe(a3))
                _GrdNT_3.RemoveItem(_GrdNT_3.Row)
                TxtVT(4).Focus()
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub _TxtVT_0_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles _TxtVT_0.LostFocus, _TxtVT_1.LostFocus, _TxtVT_2.LostFocus, _TxtVT_3.LostFocus, _TxtVT_4.LostFocus, _TxtVT_5.LostFocus, _TxtVT_6.LostFocus, _TxtVT_7.LostFocus, _TxtVT_8.LostFocus, _TxtVT_9.LostFocus, _TxtVT_10.LostFocus, _TxtVT_11.LostFocus, _TxtVT_12.LostFocus, _TxtVT_13.LostFocus
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim Index As Integer = Array.IndexOf(TxtVT, sender)
            Select Case Index
                Case 0
                    TxtVT(0).Text = UCase(TxtVT(0).Text)
                    If ContainsSpecialChars(TxtVT(0).Text) Then
                        myUMessager.mError(Ngonngu("Mã hàng hóa vật tư không nhập ký tự đặc biệt, dẫn đến dữ liệu có thể sẽ bị sai.", "Commodity goods codes do not enter special characters, resulting in data may be wrong."), Ngonngu("Mã hàng hóa vật tư", "Goods codes"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Case 3
                    TxtVT(3).Text = Format(TxtVT(3).Text, Mask_5)
                Case 5, 7, 8, 9, 10, 13
                    TxtVT(Index).Text = Format(TxtVT(Index).Text, Mask_2)
            End Select
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

End Class
