Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter

Partial Friend Class frmTaiSan
    Private _TaiSan As clsTaiSan = Nothing
    Private CurrentSelectedIndex() As Integer = New Integer() {-2, -2, -2, -2, -2, -2, -2, -2}
    Public lc As Integer = 0

    Private Property TaiSan() As clsTaiSan
        Get
            If _TaiSan Is Nothing Then
                _TaiSan = New clsTaiSan()
            End If
            Return _TaiSan
        End Get
        Set(ByVal Value As clsTaiSan)
            _TaiSan = Value
        End Set
    End Property
    Dim KhoiTao As Integer
    Dim pNhapdauky As Boolean
    Dim psw As String = String.Empty
    Dim Ngay As Date
    Dim Chonthang As Boolean = False

    ''' <summary>
    '''Init form 
    '''Đặt dòng trạng thái và thuộc tính MousePointer
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        pNhapdauky = (ConvertToDblSafe(Me.Tag) > 0)
        Dim dong, cot As Integer
        If Not pNhapdauky Then
            Application.DoEvents()
            Combo(7).Enabled = True
            Chk.Visible = (pNghiepVu = NV_TANG)
            If FrmChungtu.Visible Then
                With FrmChungtu.GrdChungtu
                    dong = .Row : cot = .Col
                    .Row = 0 : .Col = 1
                    If Strings.Left(.CtlText, 3) = "211" Then
                        If Combo(7).Items.Count > 0 Then Combo(7).SelectedIndex = FrmChungtu.CboThang.SelectedIndex
                        Combo(7).Enabled = False
                    Else
                        Combo(7).Enabled = True
                    End If
                    .Row = dong : .Col = cot
                End With
            Else
                With FrmChungtutonghop.GrdChungtu
                    dong = .Row : cot = .Col
                    .Row = 0 : .Col = 1
                    If Strings.Left(.CtlText, 3) = "211" Then
                        If Combo(7).Items.Count > 0 Then Combo(7).SelectedIndex = FrmChungtutonghop.CboThang.SelectedIndex
                        Combo(7).Enabled = False
                    Else
                        Combo(7).Enabled = True
                    End If
                    .Row = dong : .Col = cot
                End With
            End If
        Else
            SetListIndex(Combo(7), pThangDauKy)
            Application.DoEvents()
            Combo(7).Enabled = False
        End If
        Khoaquyen()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmTaiSan_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If pNhapdauky Then
            If KiemTraSoLieuDauKy() = -1 Then
                e.Cancel = IIf(0, False, True)
                Exit Sub
            End If
            pNhapdauky = False
        End If
        TaiSan.ThongSo = Nothing
        TaiSan = Nothing
        MemoryHelper.ReleaseMemory()
    End Sub

    Public flag = True
    Private Sub frmTaiSan_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        Dim i As Integer
        If (Shift And 4) > 0 Then
            i = -1
            Select Case eventArgs.KeyCode
                Case Keys.G : i = 0
                Case Keys.V : i = 1
                Case Keys.P : i = 2
                Case Keys.X : i = 3
                Case Keys.I : i = 4
            End Select
            If i >= 0 Then
                If Command(i).Enabled Then
                    Command(i).Focus()
                    Application.DoEvents()
                    Command_ClickEvent(Command(i), New EventArgs())
                    flag = False
                End If
            End If

        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    ' - Lấy danh sách các đối tượng quản lý, sử dụng, nước sản xuất và hệ thống phân loại
    ' - Khởi tạo môi trường nếu nhập mới
    '  - Lấy và hiển thị nội dung tài sản nếu đã có

    Private Sub frmTaiSan_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            Dim chi_so As Integer
            InitDateVars(MedNgay, Ngay)
            ' Lấy danh sách các đối tượng quan hệ
            Int_RecsetToCbo("SELECT Ten AS F1, MaSo as F2 FROM QuocGia ORDER BY Ten", Combo(0))
            Int_RecsetToCbo("SELECT SoHieu + '  ' + Ten AS F1, MaSo as F2 FROM LoaiTaiSan WHERE Cap = 1 order by sohieu", Combo(1))
            Int_RecsetToCbo("SELECT Ten AS F1, MaSo as F2 FROM DTQly ORDER BY Ten", Combo(4))
            Int_RecsetToCbo(String.Format("SELECT SoHieu + ' - ' + Ten AS F1, MaSo as F2 FROM HethongTK WHERE TK_ID2 = {0} AND TKCon = 0 ORDER BY SoHieu", TKCPSX_ID), Combo(5))
            Int_RecsetToCbo("SELECT Ten AS F1, MaSo as F2 FROM TinhTrang ORDER BY Ten", Combo(6))

            AddMonthToCbo(Combo(7))

            ' Khởi tạo tài sản mới
            If pMaTaiSan = 0 Then
                ' Lấy danh sách các tháng có thể chọn
                ' Khởi tạo đối tượng TaiSan (Thủ tục này phải được gọi trước khi đặt tháng ngầm định)
                KhoiTaoTaiSan(False)
                ' Nếu nhập đầu kỳ thì đặt tháng ngầm định là tháng đầu kỳ, nếu tăng thì đặt bằng tháng tăng
                SetListIndex(Combo(7), IIf(pNhapdauky, pThangDauKy, pThangTacDong))
                ' Khởi tạo môi trường
                Command(2).Visible = False
                Command(3).Visible = False
                Command(4).Visible = False
                Label(12).Text = "Hao mòn :"
                Label(16).Text = "Khấu hao / tháng :"
                ' Hiển thị các thông tin của tài sản đã có
            Else
                ' Lấy các thông tin trong dữ liệu. Quá trình hiển thị nội dung tài sản cần phải tránh các tác động
                ' do lấy và đặt thuộc tính ListIndex cho các ComboBox làm thay đổi thuộc tính phân loại đã có
                KhoiTao = True
                NoiDungTaiSan(pMaTaiSan, pThangTacDong)
                KhoiTao = False
                ' Lấy danh sách các tháng có thể chọn
                Do While chi_so < Combo(7).Items.Count
                    If Not InMonth(chi_so, IIf(TaiSan.ThangTang = 0, pThangDauKy, TaiSan.ThangTang), IIf(TaiSan.ThangGiam = 13, (IIf(pThangDauKy > 1, pThangDauKy - 1, 12)), TaiSan.ThangGiam)) Then
                        If (ConvertToDblSafe(chi_so) <> 0) Then
                            Combo(7).Items.RemoveAt(ConvertToDblSafe(chi_so))
                        End If
                        chi_so += 1
                    Else
                        chi_so += 1
                    End If
                Loop
                ' Đặt tháng ngầm định (sẽ dẫn đến việc hiển thị các thông số tương ứng)
                SetListIndex(Combo(7), pThangTacDong)
                Application.DoEvents()
                ' Khởi tạo môi trường
                Command(2).Visible = True
                Command(3).Visible = True
                Command(4).Visible = True
                Label(12).Text = Ngonngu("Tổng hao mòn :", "Total depreciation :")
                Label(16).Text = Ngonngu("Mức khấu hao tháng :", "Monthly depreciation rate")
            End If
            If pMaTaiSan = 0 Then
                Me.Text = Ngonngu(" Nhập tài sản mới", " Enter new Asset")
            Else
                Me.Text = Ngonngu(" Sửa đổi chi tiết tài sản", " Edit property details")
            End If
            pGhichungtu = 0
            Text = String.Format("{0} - {1}", Text, ConvertToStrSafe(pNamTC))
            psw = Interaction.GetSetting(IniPath, "Environment", "InvPsw", )
            If lc = 1 Then
                If _Combo_0.Items.Count > 0 Then
                    _Combo_0.SelectedIndex = -1
                End If
                If _Combo_4.Items.Count > 0 Then
                    _Combo_4.SelectedIndex = -1
                End If
                If _Combo_5.Items.Count > 0 Then
                    _Combo_5.SelectedIndex = -1
                End If
                If _Combo_6.Items.Count > 0 Then
                    _Combo_6.SelectedIndex = -1
                End If
            End If
            SetFont(Me)
            SetFontBar()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try        
    End Sub
    Private Sub SetFontBar()
        If pNN = 1 Then
            Dim s As String
            With MainMenu1
                For i = 0 To .Items.Count - 1
                    s = .Items(i).Tag
                    If s Is Nothing Then s = ""
                    If s.Length > 0 And Not IsNumeric(s) Then
                        .Items(i).Tag = .Items(i).Text
                        .Items(i).Text = s
                    End If
                    SetFontMenu(.Items(i))
                Next
            End With
        End If
    End Sub
    Private Sub SetFontMenu(ByVal menucon As System.Windows.Forms.ToolStripMenuItem)
        Dim s As String
        With menucon
            If .DropDownItems.Count = 0 Then
                Exit Sub
            Else
                For i = 0 To .DropDownItems.Count - 1
                    s = .DropDownItems(i).Tag
                    If s Is Nothing Then s = ""
                    If s.Length > 0 And Not IsNumeric(s) Then
                        .DropDownItems(i).Tag = .DropDownItems(i).Text
                        .DropDownItems(i).Text = s
                        SetFontMenu(.DropDownItems(i))
                    End If
                Next
            End If
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub frmTaiSan_MouseDown(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles MyBase.MouseDown
        Dim Button As Integer = ConvertToDblSafe(eventArgs.Button)
        Dim Shift As Integer = Control.ModifierKeys \ &H10000
        Dim X As Single = (eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        If eventArgs.Button = MouseButtons.Right Then Ctx_mnPU.Show(Me, PointToClient(Cursor.Position).X, PointToClient(Cursor.Position).Y)
    End Sub
    ''' <summary>
    ''' Xoá tham chiếu đến các Object đã khởi tạo
    '''  1. Ghi tài sản
    '''           - kiểm tra
    '''           - Ghi vào dữ liệu
    '''           - Chuyển giá trị của tài sản vào biến chung GiaTri để ghi chứng từ
    '''           - Ghi các dụng cụ phụ tùng kèm theo nếu có
    '''          - Nếu nhập đầu kỳ thì tự động tạo chứng từ đầu kỳ. Nếu tăng trong kỳ thì cho nhập chứng từ tăng
    '''           - Nếu không ghi lại chứng từ thì xoá tài sản vừa ghi.
    '''     2. In hoặc xem thẻ tài sản
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_4.Click, _Command_2.Click, _Command_3.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Me.Cursor = Cursors.WaitCursor
        Try
            If flag = True Then
                Select Case Index
                    Case 0 ' Ghi tài sản ............................................................................................................................................
                        If TaiSan.HopLe() = 0 Then
                            ' Thêm mới (tăng tài sản)
                            If pMaTaiSan = 0 Then
                                If TaiSan.ThemMoi(Chk.CheckState) = 0 Then
                                    pMaTaiSan = TaiSan.maso
                                    ' Chuyển giá trị của tài sản vừa ghi vào biến chung GiaTri để tạo và ghi chứng từ
                                    ' (riêng lượng khấu hao sẽ không được ghi vào chứng từ tăng hoặc đầu kỳ )
                                    With TaiSan.ThongSo
                                        GiaTri.NG_NS = .NG_NS
                                        GiaTri.NG_TBS = .NG_TBS
                                        GiaTri.NG_CNK = .NG_CNK
                                        GiaTri.NG_TD = .NG_TD
                                        GiaTri.CL_NS = .CL_NS
                                        GiaTri.CL_TBS = .CL_TBS
                                        GiaTri.CL_CNK = .CL_CNK
                                        GiaTri.CL_TD = .CL_TD
                                    End With
                                    ' Nhập các dụng cụ phụ tùng kèm theo tài sản
                                    If System.Windows.Forms.DialogResult.Yes = myUMessager.mQuestion(Ngonngu("Tài sản có các dụng cụ, phụ tùng kèm theo ?", "Assets of tools, spare parts together with ?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                                        frmDCPTung.ShowDialog()
                                        Me.Refresh()
                                    End If
                                    ' Nếu nhập đầu kỳ thì tạo chứng từ đầu kỳ, nếu tăng trong kỳ thì tạo chứng từ tăng
                                    If pNhapdauky Then
                                        GhiChungTuDauKy()
                                    Else
                                        ' Thành lập dòng phát sinh
                                        ThanhLapPhatSinh(NV_TANG, TaiSan.MaTaiKhoan)
                                        ' Ghi chứng từ
                                        pGhichungtu = 1
                                        If FrmChungtutonghop.Visible Then
                                            SetListIndex(FrmChungtutonghop.CboThang, Combo(7).SelectedValue)
                                            FrmChungtutonghop.txt(0).Text = Text_Renamed(19).Text
                                            FrmChungtutonghop.MedNgay(0).Text = MedNgay.Text
                                            FrmChungtutonghop.MedNgay(1).Text = MedNgay.Text
                                            FrmChungtutonghop.txt(1).Text = Text_Renamed(1).Text
                                        Else
                                            SetListIndex(FrmChungtu.CboThang, Combo(7).SelectedValue)
                                            FrmChungtu.txt(0).Text = Text_Renamed(19).Text
                                            FrmChungtu.MedNgay(0).Text = MedNgay.Text
                                            FrmChungtu.MedNgay(1).Text = MedNgay.Text
                                            FrmChungtu.txt(1).Text = Text_Renamed(1).Text
                                        End If
                                        Me.Close()
                                        Exit Sub
                                    End If
                                    pMaTaiSan = 0
                                    pMaChungTu = 0
                                    KhoiTaoTaiSan(True)
                                End If
                                ' Sửa đổi (không có nghiệp vụ nào kèm theo)
                            Else
                                If psw.Length > 0 Then
                                    If FrmPassword.GetPswX() <> psw Then GoTo XongTS
                                End If
                                Select Case TaiSan.SuaDoi()
                                    Case 0
                                        pMaTaiSan = 0
                                        If Combo(7).SelectedValue = pThangDauKy Then SoDuTKTS()
                                        'SendKeys.Send("{Escape}")
                                    Case -2, -3
                                        myUMessager.mWarning(String.Format("Chú ý : sửa đổi lượng khấu hao và giá trị của một tài sản đã bị giảm hoặc đánh giá lại sẽ làm cho số liệu ghi trên chứng từ tương ứng không còn chính xác nữa. Xoá các chứng từ có liên quan đi và sau đó ghi lại nếu cần sửa đổi"), _
                                            My.Application.Info.ProductName, _
                                            MessageBoxButtons.OK, _
                                            MessageBoxIcon.Warning)
                                End Select
                            End If
                            Combo(0).SelectedIndex = -1
                            Combo(4).SelectedIndex = -1
                            Combo(5).SelectedIndex = -1
                            Combo(6).SelectedIndex = -1
                        End If
                    Case 1 ' Trở về ...................................................................................................................................................
                        pMaTaiSan = 0
                        'SendKeys.Send("{Escape}")
                        Me.Close()
                    Case 2 ' Danh sách dụng cụ phụ tùng kèm theo .....................................................................................
                        frmDCPTung.ShowDialog()
                    Case 3 ' In thẻ tài sản trong năm ...................................................................................................................
                        TaoTheTaiSan(0, Combo(7).SelectedValue)
                    Case 4 ' Xem trước thẻ tài sản trong năm ...................................................................................................
                        TaoTheTaiSan(1, Combo(7).SelectedValue)
                End Select
XongTS:
                Me.Cursor = Cursors.Default
            Else
                flag = True
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, "Tài sản", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Combo_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Combo_1.SelectedIndexChanged, _Combo_2.SelectedIndexChanged, _Combo_3.SelectedIndexChanged, _Combo_0.SelectedIndexChanged, _Combo_5.SelectedIndexChanged, _Combo_4.SelectedIndexChanged, _Combo_6.SelectedIndexChanged, _Combo_7.SelectedIndexChanged
        Dim Index As Integer = Array.IndexOf(Combo, eventSender)
        Dim vis As Boolean

        Select Case Index
            Case 0 ' Nước sản xuất
                TaiSan.MaNuoc = IIf(Not (Combo(0).SelectedIndex = -1), Combo(0).SelectedValue, 0)
                Exit Select
            Case 1 ' Tài khoản
                If Not (Combo(1).SelectedIndex = -1) Then
                    If Not KhoiTao Then TaiSan.MaTaiKhoan = Combo(1).SelectedValue
                    Int_RecsetToCbo(String.Format("SELECT SoHieu + '  ' + Ten AS F1, MaSo as F2 FROM LoaiTaiSan WHERE CapTren = {0} order by sohieu", Combo(1).SelectedValue), Combo(2))
                    If Combo(2).Items.ItemsBase.Count = 0 Then
                        TaiSan.maloai = 0
                        TaiSan.MaNhom = 0
                        Combo(3).Items.Clear()
                        Combo(3).Items.ItemsBase.Clear()
                        Combo(3).Text = ""
                        TaoSoHieuTaiSan()
                    Else
                        If Combo(2).Items.ItemsBase.Count > 0 Then Combo(2).SelectedIndex = 0
                    End If
                    CurrentSelectedIndex = New Integer() {-2, Combo(1).SelectedIndex, -2, -2, -2, -2, -2, -2}
                Else
                    TaiSan.MaTaiKhoan = 0
                End If
            Case 2 ' Phân loại
                If Not (Combo(2).SelectedIndex = -1) Then
                    If Not KhoiTao Then TaiSan.maloai = Combo(2).SelectedValue
                    Int_RecsetToCbo(String.Format("SELECT SoHieu + '  ' + Ten AS F1, MaSo as F2 FROM LoaiTaiSan WHERE CapTren = {0} ORDER BY sohieu", Combo(2).SelectedValue), Combo(3))
                    If Combo(3).Items.ItemsBase.Count = 0 Then
                        TaiSan.MaNhom = 0
                        TaoSoHieuTaiSan()
                    End If
                Else
                    TaiSan.maloai = 0
                End If
            Case 3 ' Phân nhóm
                If Not (Combo(3).SelectedIndex = -1) Then
                    If Not KhoiTao Then TaiSan.MaNhom = Combo(3).SelectedValue
                    TaoSoHieuTaiSan()
                Else
                    TaiSan.MaNhom = 0
                End If
            Case 4 ' Đối tượng quản lý
                TaiSan.ThongSo.MaDTQL = IIf(Not (Combo(4).SelectedIndex = -1), Combo(4).SelectedValue, 0)
            Case 5 ' Đối tượng sử dụng
                TaiSan.ThongSo.MaDTSD = IIf(Not (Combo(5).SelectedIndex = -1), Combo(5).SelectedValue, 0)
            Case 6 ' Tình trạng sử dụng
                TaiSan.ThongSo.MaTTSD = IIf(Not (Combo(6).SelectedIndex = -1), Combo(6).SelectedValue, 0)
            Case 7 ' Tháng
                ' Lấy tháng tăng của tài sản
                If pMaTaiSan = 0 Then
                    If pNhapdauky Then
                        TaiSan.ThangTang = 0
                    Else
                        TaiSan.ThangTang = Combo(7).SelectedValue
                        pThangTacDong = TaiSan.ThangTang
                    End If
                    ' Hiển thị các thông số tương ứng
                Else
                    vis = (TaiSan.ThangTang = 0) And (pNghiepVu <> NV_TANG)
                    MedNgay.Enabled = vis
                    Text_Renamed(19).ReadOnly = Not vis
                    MedNgay.TabStop = vis
                    Text_Renamed(19).TabStop = vis
                    TaiSan.ThongSo.ChiDinh(pMaTaiSan, Combo(7).SelectedValue)
                    With TaiSan.ThongSo
                        ' Nguyên giá
                        Text_Renamed(6).Text = Format(.NG_NS, Mask_0)
                        Text_Renamed(7).Text = Format(.NG_TBS, Mask_0)
                        Text_Renamed(8).Text = Format(.NG_CNK, Mask_0)
                        Text_Renamed(9).Text = Format(.NG_TD, Mask_0)
                        ' Hao mòn
                        Text_Renamed(10).Text = Format(.NG_NS - .CL_NS, Mask_0)
                        Text_Renamed(11).Text = Format(.NG_TBS - .CL_TBS, Mask_0)
                        Text_Renamed(12).Text = Format(.NG_CNK - .CL_CNK, Mask_0)
                        Text_Renamed(13).Text = Format(.NG_TD - .CL_TD, Mask_0)
                        ' khấu hao
                        Text_Renamed(14).Text = Format(.KH_NS, Mask_0)
                        Text_Renamed(15).Text = Format(.KH_TBS, Mask_0)
                        Text_Renamed(16).Text = Format(.KH_CNK, Mask_0)
                        Text_Renamed(17).Text = Format(.KH_TD, Mask_0)
                        ' Giá trị còn lại
                        Label(26).Text = Format(.CL_NS, Mask_0)
                        Label(27).Text = Format(.CL_TBS, Mask_0)
                        Label(28).Text = Format(.CL_CNK, Mask_0)
                        Label(30).Text = Format(.CL_TD, Mask_0)
                        ' Tổng số
                        Label(19).Text = Format(.NG_NS + .NG_TBS + .NG_CNK + .NG_TD, Mask_0)
                        Label(20).Text = Format((.NG_NS - .CL_NS) + (.NG_TBS - .CL_TBS) + (.NG_CNK - .CL_CNK) + (.NG_TD - .CL_TD), Mask_0)
                        Label(21).Text = Format(.CL_NS + .CL_TBS + .CL_CNK + .CL_TD, Mask_0)
                        Label(22).Text = Format(.KH_NS + .KH_TBS + .KH_CNK + .KH_TD, Mask_0)
                        SetListIndex(Combo(4), .MaDTQL)
                        SetListIndex(Combo(5), .MaDTSD)
                        SetListIndex(Combo(6), .MaTTSD)
                    End With
                    ' Cho phép sửa nguyên giá và lượng hao mòn của tài sản vào tháng đầu kỳ
                    ' (với điều kiện tài sản được nhập đầu kỳ và chưa bị ghi chứng từ giảm)
                    If ((Combo(7).SelectedIndex = 0 Or Combo(7).SelectedValue = TaiSan.ThangTang) And TaiSan.ThangGiam = 13 And Not KhongDC(TaiSan.maso)) Or (Combo(7).SelectedIndex = 0) Then
                        Text_Renamed(6).ReadOnly = False
                        Text_Renamed(7).ReadOnly = False
                        Text_Renamed(8).ReadOnly = False
                        Text_Renamed(9).ReadOnly = False
                        Text_Renamed(10).ReadOnly = False
                        Text_Renamed(11).ReadOnly = False
                        Text_Renamed(12).ReadOnly = False
                        Text_Renamed(13).ReadOnly = False
                        Text_Renamed(0).ReadOnly = False
                        Text_Renamed(19).ReadOnly = False
                        Text_Renamed(1).ReadOnly = False
                        Text_Renamed(2).ReadOnly = False
                        Text_Renamed(3).ReadOnly = False
                        Text_Renamed(4).ReadOnly = False
                        Text_Renamed(5).ReadOnly = False
                        Text_Renamed(18).ReadOnly = False
                        Text_Renamed(15).ReadOnly = False
                        Text_Renamed(7).ReadOnly = False
                        Text_Renamed(11).ReadOnly = False
                        Combo(1).DropDownStyle = ComboBoxStyle.DropDown ' C15 Unlock ComboBox
                        Combo(2).DropDownStyle = ComboBoxStyle.DropDown ' C15 Unlock ComboBox
                        Combo(3).DropDownStyle = ComboBoxStyle.DropDown ' C15 Unlock ComboBox
                        Combo(0).DropDownStyle = ComboBoxStyle.DropDown ' C15 Unlock ComboBox
                        Combo(6).DropDownStyle = ComboBoxStyle.DropDown ' C15 Unlock ComboBox
                        Combo(4).DropDownStyle = ComboBoxStyle.DropDown ' C15 Unlock ComboBox
                        Combo(5).DropDownStyle = ComboBoxStyle.DropDown ' C15 Unlock ComboBox
                        MedNgay.Enabled = True
                        Chk.Enabled = True
                    Else
                        Text_Renamed(6).ReadOnly = True
                        Text_Renamed(7).ReadOnly = True
                        Text_Renamed(8).ReadOnly = True
                        Text_Renamed(9).ReadOnly = True
                        Text_Renamed(10).ReadOnly = True
                        Text_Renamed(11).ReadOnly = True
                        Text_Renamed(12).ReadOnly = True
                        Text_Renamed(13).ReadOnly = True
                        Text_Renamed(0).ReadOnly = True
                        Text_Renamed(19).ReadOnly = True
                        Text_Renamed(1).ReadOnly = True
                        Text_Renamed(2).ReadOnly = True
                        Text_Renamed(3).ReadOnly = True
                        Text_Renamed(4).ReadOnly = True
                        Text_Renamed(5).ReadOnly = True
                        Text_Renamed(18).ReadOnly = True
                        Text_Renamed(15).ReadOnly = True
                        Text_Renamed(7).ReadOnly = True
                        Text_Renamed(11).ReadOnly = True
                        Combo(1).DropDownStyle = ComboBoxStyle.DropDownList ' C15 Lock ComboBox
                        Combo(2).DropDownStyle = ComboBoxStyle.DropDownList ' C15 Lock ComboBox
                        Combo(3).DropDownStyle = ComboBoxStyle.DropDownList ' C15 Lock ComboBox
                        Combo(0).DropDownStyle = ComboBoxStyle.DropDownList ' C15 Lock ComboBox
                        Combo(6).DropDownStyle = ComboBoxStyle.DropDownList ' C15 Lock ComboBox
                        Combo(4).DropDownStyle = ComboBoxStyle.DropDownList ' C15 Lock ComboBox
                        Combo(5).DropDownStyle = ComboBoxStyle.DropDownList ' C15 Lock ComboBox
                        MedNgay.Enabled = False
                        Chk.Enabled = False
                    End If
                End If
                ' Không cho sửa lượng khấu hao nếu tài sản đã giảm trong năm
                If TaiSan.ThangGiam < 13 Then
                    Text_Renamed(14).ReadOnly = True
                    Text_Renamed(15).ReadOnly = True
                    Text_Renamed(16).ReadOnly = True
                    Text_Renamed(17).ReadOnly = True
                    Text_Renamed(18).ReadOnly = True
                    Text_Renamed(0).ReadOnly = True
                    Text_Renamed(19).ReadOnly = True
                    Text_Renamed(1).ReadOnly = True
                    Text_Renamed(2).ReadOnly = True
                    Text_Renamed(3).ReadOnly = True
                    Text_Renamed(4).ReadOnly = True
                    Text_Renamed(5).ReadOnly = True
                    Text_Renamed(18).ReadOnly = True
                    Text_Renamed(15).ReadOnly = True
                    Text_Renamed(7).ReadOnly = True
                    Text_Renamed(11).ReadOnly = True
                    Combo(1).DropDownStyle = ComboBoxStyle.DropDownList ' C15 Lock ComboBox
                    Combo(2).DropDownStyle = ComboBoxStyle.DropDownList ' C15 Lock ComboBox
                    Combo(3).DropDownStyle = ComboBoxStyle.DropDownList ' C15 Lock ComboBox
                    Combo(0).DropDownStyle = ComboBoxStyle.DropDownList ' C15 Lock ComboBox
                    Combo(6).DropDownStyle = ComboBoxStyle.DropDownList ' C15 Lock ComboBox
                    Combo(4).DropDownStyle = ComboBoxStyle.DropDownList ' C15 Lock ComboBox
                    Combo(5).DropDownStyle = ComboBoxStyle.DropDownList ' C15 Lock ComboBox
                    MedNgay.Enabled = False
                    Chk.Enabled = False
                Else
                    Text_Renamed(14).ReadOnly = False
                    Text_Renamed(15).ReadOnly = False
                    Text_Renamed(16).ReadOnly = False
                    Text_Renamed(17).ReadOnly = False
                    Text_Renamed(18).ReadOnly = False
                    Text_Renamed(0).ReadOnly = False
                    Text_Renamed(19).ReadOnly = False
                    Text_Renamed(1).ReadOnly = False
                    Text_Renamed(2).ReadOnly = False
                    Text_Renamed(3).ReadOnly = False
                    Text_Renamed(4).ReadOnly = False
                    Text_Renamed(5).ReadOnly = False
                    Text_Renamed(7).ReadOnly = False
                    Text_Renamed(11).ReadOnly = False
                    Text_Renamed(18).ReadOnly = False
                    Text_Renamed(15).ReadOnly = False
                    Combo(1).DropDownStyle = ComboBoxStyle.DropDown ' C15 Unlock ComboBox
                    Combo(2).DropDownStyle = ComboBoxStyle.DropDown ' C15 Unlock ComboBox
                    Combo(3).DropDownStyle = ComboBoxStyle.DropDown ' C15 Unlock ComboBox
                    Combo(0).DropDownStyle = ComboBoxStyle.DropDown ' C15 Unlock ComboBox
                    Combo(6).DropDownStyle = ComboBoxStyle.DropDown ' C15 Unlock ComboBox
                    Combo(4).DropDownStyle = ComboBoxStyle.DropDown ' C15 Unlock ComboBox
                    Combo(5).DropDownStyle = ComboBoxStyle.DropDown ' C15 Unlock ComboBox
                    MedNgay.Enabled = True
                    Chk.Enabled = True
                End If
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub mnDD_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mnDD_0.Click, _mnDD_1.Click, _mnDD_2.Click, _mnDD_3.Click, _mnDD_4.Click
        Dim Index As Integer = Array.IndexOf(mnDD, eventSender)
        Select Case Index
            Case 0
                frmMain.mnts_Click(frmMain.mnts(4), New EventArgs())
                Int_RecsetToCbo("SELECT Ten AS F1, MaSo as F2 FROM QuocGia ORDER BY Ten", Combo(0))
            Case 1
                frmMain.mnts_Click(frmMain.mnts(5), New EventArgs())
                Int_RecsetToCbo("SELECT Ten AS F1, MaSo as F2 FROM TinhTrang ORDER BY Ten", Combo(6))
            Case 2
                frmMain.mnts_Click(frmMain.mnts(6), New EventArgs())
                Int_RecsetToCbo("SELECT Ten AS F1, MaSo as F2 FROM DTQly ORDER BY Ten", Combo(4))
            Case 4
                FrmTaikhoan.Tag = "1"
                FrmTaikhoan.ShowDialog()
                Int_RecsetToCbo(String.Format("SELECT SoHieu + ' - ' + Ten AS F1, MaSo as F2 FROM HethongTK WHERE TK_ID2 = {0} AND TKCon = 0 ORDER BY SoHieu", TKCPSX_ID), Combo(5))
        End Select
    End Sub
    '======================================================================================
    ' TEXT
    '======================================================================================
    ' GotFocus
    Private Sub Text_Renamed_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Text_19.Enter, _Text_18.Enter, _Text_14.Enter, _Text_13.Enter, _Text_12.Enter, _Text_11.Enter, _Text_10.Enter, _Text_9.Enter, _Text_8.Enter, _Text_7.Enter, _Text_6.Enter, _Text_15.Enter, _Text_16.Enter, _Text_17.Enter, _Text_3.Enter, _Text_2.Enter, _Text_1.Enter, _Text_0.Enter, _Text_4.Enter, _Text_5.Enter
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        Text_Renamed(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Text_Renamed_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _Text_19.KeyPress, _Text_18.KeyPress, _Text_14.KeyPress, _Text_13.KeyPress, _Text_12.KeyPress, _Text_11.KeyPress, _Text_10.KeyPress, _Text_9.KeyPress, _Text_8.KeyPress, _Text_7.KeyPress, _Text_6.KeyPress, _Text_15.KeyPress, _Text_16.KeyPress, _Text_17.KeyPress, _Text_3.KeyPress, _Text_2.KeyPress, _Text_1.KeyPress, _Text_0.KeyPress, _Text_4.KeyPress, _Text_5.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        If Index = 0 And (KeyAscii = 32 Or KeyAscii = 39 Or KeyAscii = 42) Then KeyAscii = 0
        If Index >= 6 And Index <= 18 Then KeyProcess(Text_Renamed(Index), KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    ' LostFocus
    Private Sub Text_Renamed_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Text_19.Leave, _Text_18.Leave, _Text_14.Leave, _Text_13.Leave, _Text_12.Leave, _Text_11.Leave, _Text_10.Leave, _Text_9.Leave, _Text_8.Leave, _Text_7.Leave, _Text_6.Leave, _Text_15.Leave, _Text_16.Leave, _Text_17.Leave, _Text_3.Leave, _Text_2.Leave, _Text_1.Leave, _Text_0.Leave, _Text_4.Leave, _Text_5.Leave
        Dim Err_DataTypeConvertion As Boolean = False
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        Dim sn As Integer
        If Index >= 6 And Index <= 18 Then
            Text_Renamed(Index).Text = Format(Text_Renamed(Index).Text, Mask_0)
        End If
        If Strings.Len(Text_Renamed(Index).Text) = 0 Then
            Text_Renamed(Index).Text = IIf((Index < 3 Or Index = 5), "(...)", "0")
        End If
        Try
            Err_DataTypeConvertion = True
            Select Case Index
                Case 0 : TaiSan.sohieu = Text_Renamed(0).Text
                Case 1 : TaiSan.ten = Text_Renamed(1).Text
                Case 2 : TaiSan.NangLuc = Text_Renamed(2).Text
                Case 3 : TaiSan.NamSX = ConvertToDblSafe(Text_Renamed(3).Text)
                Case 4 : TaiSan.NamSD = ConvertToDblSafe(Text_Renamed(4).Text)
                Case 5
                    TaiSan.GhiChu = Text_Renamed(5).Text
                    If lc = 1 Then
                        If _Text_5.Text <> Nothing Then
                            If _Combo_0.Items.Count > 0 Then
                                _Combo_0.SelectedIndex = 0
                            End If
                        End If
                    End If
                    ' Nguyên giá
                Case 6 : TaiSan.ThongSo.NG_NS = ConvertToDblSafe(Text_Renamed(6).Text)
                Case 7 : TaiSan.ThongSo.NG_TBS = ConvertToDblSafe(Text_Renamed(7).Text)
                Case 8 : TaiSan.ThongSo.NG_CNK = ConvertToDblSafe(Text_Renamed(8).Text)
                Case 9 : TaiSan.ThongSo.NG_TD = ConvertToDblSafe(Text_Renamed(9).Text)
                    ' Hao mòn
                Case 10 : TaiSan.ThongSo.HM_NS = ConvertToDblSafe(Text_Renamed(10).Text)
                Case 11 : TaiSan.ThongSo.HM_TBS = ConvertToDblSafe(Text_Renamed(11).Text)
                Case 12 : TaiSan.ThongSo.HM_CNK = ConvertToDblSafe(Text_Renamed(12).Text)
                Case 13 : TaiSan.ThongSo.HM_TD = ConvertToDblSafe(Text_Renamed(13).Text)
                    ' khấu hao
                Case 14 : TaiSan.ThongSo.KH_NS = ConvertToDblSafe(Text_Renamed(14).Text)
                Case 15 : TaiSan.ThongSo.KH_TBS = ConvertToDblSafe(Text_Renamed(15).Text)
                Case 16 : TaiSan.ThongSo.KH_CNK = ConvertToDblSafe(Text_Renamed(16).Text)
                Case 17 : TaiSan.ThongSo.KH_TD = ConvertToDblSafe(Text_Renamed(17).Text)
                Case 18
                    sn = ConvertToDblSafe(Text_Renamed(18).Text)
                    TaiSan.NamKH = sn
                    If sn > 0 And (Not Text_Renamed(18).ReadOnly) Then
                        For i As Integer = 6 To 9
                            If ConvertToDblSafe(Label(20 + (IIf(i < 9, i, 10))).Text) > 0 Then
                                Text_Renamed(i + 8).Text = Format(RoundMoney(ConvertToDblSafe(Text_Renamed(i).Text) / (sn * 12)), Mask_0)
                                Text_Renamed_Leave(Text_Renamed(i + 8), New EventArgs())
                            End If
                        Next
                    End If
                Case 19 : TaiSan.shct = Text_Renamed(19).Text
            End Select
            If Index > 5 And Index < 10 Then
                If ConvertToDblSafe(Text_Renamed(Index).Text) = 0 Then
                    Text_Renamed(Index + 4).Text = "0"
                    Text_Renamed(Index + 8).Text = "0"
                    Text_Renamed_Leave(Text_Renamed(Index + 4), New EventArgs())
                    Text_Renamed_Leave(Text_Renamed(Index + 8), New EventArgs())
                    Text_Renamed(Index + 4).Enabled = False
                    Text_Renamed(Index + 8).Enabled = False
                Else
                    Text_Renamed(Index + 4).Enabled = True
                    Text_Renamed(Index + 8).Enabled = True
                End If
            End If
            Err_DataTypeConvertion = False
            ' Tính giá trị còn lại và các tổng số
            With TaiSan.ThongSo
                If Index > 5 And Index < 14 Then
                    If Index < 10 Then
                        Label(19).Text = Format(.NG_NS + .NG_TBS + .NG_CNK + .NG_TD, Mask_0)
                    Else
                        Label(20).Text = Format(.HM_NS + .HM_TBS + .HM_CNK + .HM_TD, Mask_0)
                    End If
                    .CL_NS = .NG_NS - .HM_NS
                    .CL_TBS = .NG_TBS - .HM_TBS
                    .CL_CNK = .NG_CNK - .HM_CNK
                    .CL_TD = .NG_TD - .HM_TD
                    Label(26).Text = Format(.CL_NS, Mask_0)
                    Label(27).Text = Format(.CL_TBS, Mask_0)
                    Label(28).Text = Format(.CL_CNK, Mask_0)
                    Label(30).Text = Format(.CL_TD, Mask_0)
                    Label(21).Text = Format(.CL_NS + .CL_TBS + .CL_CNK + .CL_TD, Mask_0)
                End If
                If Index > 13 Then Label(22).Text = Format(.KH_NS + .KH_TBS + .KH_CNK + .KH_TD, Mask_0)
            End With
        Catch excep As System.Exception
            If Not Err_DataTypeConvertion Then
                Throw excep
            End If
            If Err_DataTypeConvertion Then
                Text_Renamed(Index).Focus()
            End If
        End Try


        'If _Text_18.Text <> Nothing And _Text_7.Text <> Nothing Then
        '    Dim kq As Double = ConvertToDblSafe(_Text_7.Text) / (ConvertToDblSafe(_Text_18.Text) * 12)
        '    _Text_15.Text = Format(kq, Mask_0)
        '    Label(22).Text = Format(kq, Mask_0)
        'End If
    End Sub
    '======================================================================================
    ' SUB KhoiTaoTaiSan
    '======================================================================================
    Private Sub KhoiTaoTaiSan(ByRef tiep_tuc As Boolean)
        TaiSan.KhoiTao() ' Khởi tạo đối tượng TaiSan
        For chi_so As Integer = 0 To 5 ' Xoá các TextBox
            Text_Renamed(chi_so).Text = ""
        Next
        For chi_so As Integer = 6 To 17 ' Xoá các TextBox
            Text_Renamed(chi_so).Text = "0"
        Next
        For chi_so As Integer = 19 To 30 ' Xoá các Label
            If (chi_so >= 19 And chi_so <= 22) Or (chi_so >= 26 And chi_so <= 28) Or chi_so = 30 Then Label(chi_so).Text = "0"
        Next
        'Combo(0).SelectedIndex = -1 ' Xoá các Combo không thuộc hệ thống phân loại
        'For chi_so As Integer = 4 To 6
        '    Combo(chi_so).SelectedIndex = -1
        'Next
        If Not tiep_tuc Then ' Nếu là lần khởi tạo đầu tiên thì xoá
            For chi_so As Integer = 1 To 3 ' các Combo thuộc hệ thống phân loại
                Combo(chi_so).SelectedIndex = -1
            Next
        Else
            ' Nếu đang tiếp tục nhập tài sản thì tạo số hiệu mới, lấy
            TaoSoHieuTaiSan() ' mã số của phân loại hiện tại và tháng tăng ngầm định
            TaiSan.MaTaiKhoan = Combo(1).SelectedValue
            If Combo(2).Items.ItemsBase.Count > 0 Then
                TaiSan.maloai = Combo(2).SelectedValue
            Else
                TaiSan.maloai = 0
            End If
            If Combo(3).Items.Count > 0 Then
                TaiSan.MaNhom = Combo(3).SelectedValue
            Else
                TaiSan.MaNhom = 0
            End If
            '            Combo_Click (7)
            Text_Renamed(0).Focus()
        End If
        Chonthang = True
        Combo_SelectedIndexChanged(Combo(7), New EventArgs())
        Chonthang = False
    End Sub
    '======================================================================================
    ' SUB NoiDungTaiSan : Lấy và hiển thị nội dung tài sản.
    '                                 Chú ý : Đặt thuộc tính ListIndex của các Combo thuộc hệ thống phân loại sẽ dẫn
    '                                               đến Events_Click tương ứng
    '                                               Nội dung các thông số sẽ được hiển thị trong Events_Click của Combo(7)
    '======================================================================================
    Private Sub NoiDungTaiSan(ByRef ma_ts As Integer, ByRef thang_cd As Integer)
        TaiSan.ChiDinh(ma_ts, thang_cd)
        Dim ml As Integer = TaiSan.maloai
        Dim MN As Integer = TaiSan.MaNhom
        SetListIndex(Combo(0), TaiSan.MaNuoc)
        SetListIndex(Combo(1), TaiSan.MaTaiKhoan)
        SetListIndex(Combo(2), ml)
        SetListIndex(Combo(3), MN)
        TaiSan.maloai = ml
        TaiSan.MaNhom = MN
        Text_Renamed(0).Text = TaiSan.sohieu
        Text_Renamed(1).Text = TaiSan.ten
        Text_Renamed(2).Text = TaiSan.NangLuc
        Text_Renamed(3).Text = ConvertToStrSafe(TaiSan.NamSX)
        Text_Renamed(4).Text = ConvertToStrSafe(TaiSan.NamSD)
        Text_Renamed(5).Text = TaiSan.GhiChu
        Text_Renamed(18).Text = ConvertToStrSafe(TaiSan.NamKH)
        Text_Renamed(19).Text = TaiSan.shct
        Ngay = TaiSan.NCT
        MedNgay.Text = Format(Ngay, Mask_D)
    End Sub
    '========================================================================================================
    ' SUB TaoSoHieuTaiSan
    '========================================================================================================
    Private Sub TaoSoHieuTaiSan()
        Dim ms As Integer
        If Combo(3).Items.ItemsBase.Count > 0 Then
            ms = Combo(3).SelectedValue
        ElseIf Combo(2).Items.ItemsBase.Count > 0 Then
            ms = Combo(2).SelectedValue
        Else
            ms = Combo(1).SelectedValue
        End If
        Dim sql As String = String.Format("SELECT SoHieu AS F1 FROM LoaiTaiSan WHERE MaSo = {0}", ms)
        Text_Renamed(0).Text = String.Format("{0}-", ConvertToStrSafe(GetSelectValue(sql)))
    End Sub
    '======================================================================================
    ' SUB GhiChungTuDauKy : Tạo chứng từ riêng cho các tài sản nhập đầu kỳ.
    '                                      Chú ý : Tháng chứng từ được ghi bằng 0, mã loại và mã nhóm được đặt theo hằng
    '                                                     số DK_LOAI và DK_NHOM để phân biệt với các chứng từ khác.
    '                                                     Lượng khấu hao của chứng từ đầu kỳ luôn bằng 0.
    '======================================================================================
    Private Sub GhiChungTuDauKy()
        Dim sql As String = String.Empty
        With GiaTri
            sql = String.Format("INSERT INTO CTTaiSan (MaSo,MaCTKT, SoHieu, Thang, VaoSo, NgayGhi, DienGiai, MaLoai, MaNhom, MaTS, NG_NS, NG_TBS, NG_CNK, NG_TD, CL_NS, CL_TBS, CL_CNK, CL_TD) VALUES ({0},0, '{1}', 0,'{2}','{2}',N'Tài sản đầu kỳ',{3},{4},{5},N'{6}',{7},{8},{9},{10},{11},{12},{13})", _
                      Lng_MaxValue("MaSo", "CTTaiSan") + 1, _
                      TaiSan.sohieu, _
                      Format(DateTime.Today, Mask_DB), _
                      ConvertToStrSafe(DK_LOAI), _
                      ConvertToStrSafe(DK_NHOM), _
                      ConvertToStrSafe(pMaTaiSan), _
                      CStr(.NG_NS), _
                      CStr(.NG_TBS), _
                      CStr(.NG_CNK), _
                      CStr(.NG_TD), _
                      CStr(.CL_NS), _
                      CStr(.CL_TBS), _
                      CStr(.CL_CNK), _
                      CStr(.CL_TD))
        End With
        ExecSQLNonQuery(sql)
    End Sub
    '======================================================================================
    ' SUB TaoTheTaiSan
    '======================================================================================
    Private Sub TaoTheTaiSan(ByRef ket_xuat As Integer, ByRef thang As Integer)
        Dim trong_nam, luy_ke As Double
        Dim so_hieu, ngay_thang, dien_giai As String
        Me.Cursor = Cursors.WaitCursor
        HienThongBao("In thẻ tài sản", 1)
        With GiaTri
            ' Tính lượng hao mòn cho đến tại tháng hiện tại (có trính khấu hao tháng hiện tại)
            TinhGiaTriTaiSan(TaiSan.maso, thang, KH_CO)
            luy_ke = (.NG_NS - .CL_NS) + (.NG_TBS - .CL_TBS) + (.NG_CNK - .CL_CNK) + (.NG_TD - .CL_TD)
            ' Tính lượng hao mòn cho đến hết năm (có trính khấu hao tháng cuối năm)
            If TaiSan.ThangTang > 0 Then
                trong_nam = luy_ke
            Else
                TinhGiaTriTaiSan(TaiSan.maso, 0, KH_CO)
                trong_nam = luy_ke - ((.NG_NS - .CL_NS) + (.NG_TBS - .CL_TBS) + (.NG_CNK - .CL_CNK) + (.NG_TD - .CL_TD))
            End If
        End With
        ' Lấy chứng từ giảm (nếu có)
        Dim sql As String = String.Format("SELECT SoHieu, NgayGhi, DienGiai FROM CTTaiSan WHERE MaTS = {0} AND MaLoai = {1}", TaiSan.maso, ConvertToStrSafe(NV_GIAM))
        Dim rs_giam As DataTable = ExecSQLReturnDT(sql)
        If rs_giam.Rows.Count = 0 Then
            so_hieu = "....................."
            ngay_thang = "...................."
            dien_giai = ".............................................................."
        Else
            Dim rs_giamItem As DataRow = rs_giam.Rows(0)
            so_hieu = rs_giamItem("SoHieu")
            ngay_thang = ConvertToDateSafe(rs_giamItem("NgayGhi"))
            dien_giai = rs_giamItem("DienGiai")
        End If
        ''rs_giam.Close()
        rs_giam = Nothing
        ' Dữ liệu
        Dim TheTaiSan As String = String.Format("SELECT TaiSan.SoHieu AS SoHieuTS, TaiSan.Ten AS TenTS, TaiSan.NangLuc, QuocGia.Ten AS TenNuoc, TaiSan.NamSX, TaiSan.NamSD, CTTaiSan.SoHieu AS SoHieuCT, CTTaiSan.Thang, CTTaiSan.DienGiai, (CTTaiSan.NG_NS+CTTaiSan.NG_TBS+CTTaiSan.NG_CNK+CTTaiSan.NG_TD) AS TNG FROM QuocGia RIGHT JOIN (TaiSan RIGHT JOIN CTTaiSan ON TaiSan.MaSo = CTTaiSan.MaTS) ON QuocGia.MaSo = TaiSan.MaNuoc WHERE TaiSan.MaSo = {0} ORDER BY TaiSan.SoHieu,TaiSan.Ten,TaiSan.NangLuc,QuocGia.Ten,TaiSan.NamSX,TaiSan.NamSD,CTTaiSan.SoHieu,CTTaiSan.Thang,CTTaiSan.DienGiai,CTTaiSan.NgayGhi,TNG", TaiSan.maso)
        Dim ThePhu As String = String.Format("SELECT DISTINCT DCPTung.Ten, DCPTung.DonVi, DCPTung.SoLuong, DCPTung.GiaThanh FROM DCPTung WHERE DCPTung.MaTS = {0} ORDER BY DCPTung.Ten", TaiSan.maso)
        InTheTaiSan(ket_xuat, "the1.rpt", TheTaiSan, "TheTaiSan", VB6.GetItemString(Combo(4), Combo(4).SelectedIndex), Format(trong_nam, Mask_0), Format(luy_ke, Mask_0))
        InTheTaiSan(ket_xuat, "the2.rpt", ThePhu, "ThePhu", so_hieu, ngay_thang, dien_giai)
        Me.Cursor = Cursors.Default
    End Sub
    '======================================================================================
    ' SUB InTheTaiSan
    '======================================================================================
    Private Sub InTheTaiSan(ByRef ket_xuat As Integer, ByRef ten_file As String, ByVal reportQuery As String, ByVal reportTableName As String, ByRef ct_2 As String, ByRef ct_3 As String, ByRef ct_4 As String)
        rptFrom.InitForm(ten_file, reportQuery, reportTableName)

        ' Ket Xuất
        Select Case ket_xuat
            Case 0
                rptFrom.ReportDestination = 1
                rptFrom.ReportWindowTitle = "Thẻ tài sản cố định"
            Case 1
                rptFrom.ReportDestination = 0
        End Select
        ' Tên File dữ liệu và báo cáo
        SetRptInfo()
        'frmMain.rpt.set_DataFiles(0, pDataPath)

        ' Công thức
        rptFrom.SetFormulas("TenCongTy", String.Format("'{0}'", pTenCty))
        rptFrom.SetFormulas("TenChiNhanh", String.Format("'{0}'", pTenCn))
        If ten_file = "the1.rpt" Then
            rptFrom.SetFormulas("QuanLy", String.Format("'{0}'", ct_2))
            rptFrom.SetFormulas("TrongNam", String.Format("'{0}'", ct_3))
            rptFrom.SetFormulas("LuyKe", String.Format("'{0}'", ct_4))
            rptFrom.SetFormulas("TenBaoCao", "'Thẻ tài sản cố định'")
        Else
            rptFrom.SetFormulas("SoCT", String.Format("'{0}'", ct_2))
            rptFrom.SetFormulas("NgayThang", String.Format("'{0}'", ct_3))
            rptFrom.SetFormulas("LyDo", String.Format("= '{0}'", ct_4))
            rptFrom.SetFormulas("TenBaoCao", String.Empty)
        End If
        ' In báo cáo
        InBaoCaoRPT()
        Exit Sub
        SystemSounds.Beep.Play()
    End Sub
    '======================================================================================
    ' FUNCTION KiemTraSoLieuDauKy
    '======================================================================================
    Private Function KiemTraSoLieuDauKy() As Integer
        Dim result As Integer = 0
        Me.Cursor = Cursors.WaitCursor
        Dim sql As String = "SELECT Sum(NG_NS+NG_TBS+NG_CNK+NG_TD) AS TNG, Sum(CL_NS+CL_TBS+CL_CNK+CL_TD) AS TCL FROM CTTaiSan WHERE Thang=0"
        Dim rs_dauky As DataTable = ExecSQLReturnDT(sql)
        If rs_dauky.Rows.Count > 0 Then
            Dim rs_daukyItem As DataRow = rs_dauky.Rows(0)
            myUMessager.mInformation(String.Format("Số liệu đầu kỳ đã nhập:{0}  Tổng nguyên giá : {1}{0}  Tổng còn lại : {2}", _
                                    Environment.NewLine, _
                                    Format(rs_daukyItem("TNG"), Mask_0), _
                                    Format(rs_daukyItem("TCL"), Mask_0)), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            SoDuTKTS()
            ''rs_dauky.Close()
        End If
        rs_dauky = Nothing
        Me.Cursor = Cursors.Default
        Return result
    End Function
    Private Sub MedNgay_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MedNgay.Enter
        MedNgay.SelectAll()
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
            TaiSan.NCT = Ngay
        Else
            MedNgay.Focus()
        End If
    End Sub
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(0).Enabled = ChoNhapTiep() And (User_Right <> 2 Or UserID = uid)
    End Sub

    
    Private Sub _Combo_0_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Combo_0.Leave
        If _Combo_6.Items.Count > 0 And lc = 1 Then
            _Combo_6.SelectedIndex = 0
        End If
    End Sub

    Private Sub _Combo_6_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Combo_6.Leave
        If _Combo_4.Items.Count > 0 And lc = 1 Then
            _Combo_4.SelectedIndex = 0
        End If
    End Sub

    Private Sub _Combo_4_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Combo_4.Leave
        If _Combo_5.Items.Count > 0 And lc = 1 Then
            _Combo_5.SelectedIndex = 0
        End If
    End Sub

    Private Sub _Combo_0_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Combo_0.TextChanged
        TaiSan.MaNuoc = IIf(Not (Combo(0).SelectedIndex = -1), Combo(0).SelectedValue, 0)
    End Sub

    Private Sub _Combo_6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Combo_6.TextChanged
        TaiSan.ThongSo.MaTTSD = IIf(Not (Combo(6).SelectedIndex = -1), Combo(6).SelectedValue, 0)
    End Sub

    Private Sub _Combo_4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Combo_4.TextChanged
        TaiSan.ThongSo.MaDTQL = IIf(Not (Combo(4).SelectedIndex = -1), Combo(4).SelectedValue, 0)
    End Sub

    Private Sub _Combo_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Combo_5.TextChanged
        TaiSan.ThongSo.MaDTSD = IIf(Not (Combo(5).SelectedIndex = -1), Combo(5).SelectedValue, 0)
    End Sub

    Private Sub _Text_15_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Text_15.TextChanged

    End Sub
End Class
