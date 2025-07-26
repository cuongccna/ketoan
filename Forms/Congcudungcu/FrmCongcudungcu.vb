Imports System
Imports System.Data
Imports System.Media
Imports UNET.Utility
Imports System.Windows.Forms
Imports System.ComponentModel
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmCongcudungcu
    Private _Congcudungcu As ClsCongcudungcu = Nothing
    Private Property Congcudungcu() As ClsCongcudungcu
        Get
            If _Congcudungcu Is Nothing Then
                _Congcudungcu = New ClsCongcudungcu()
            End If
            Return _Congcudungcu
        End Get
        Set(ByVal Value As ClsCongcudungcu)
            _Congcudungcu = Value
        End Set
    End Property
    Dim KhoiTao As Integer
    Dim pNhapdauky As Boolean
    Dim pNhapdauky1 As Boolean
    Dim psw As String = String.Empty
    Dim Ngay As Date
    '======================================================================================
    ' FORM
    '======================================================================================
    ' ACTIVATE : Đặt dòng trạng thái và thuộc tính MousePointer
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        pNhapdauky = (ConvertToDblSafe(Me.Tag) > 0)
        If Not pNhapdauky Then
            '        SetListIndex1 Combo(7), Month(Date)
            '        SetListIndex1 Combo(0), Month(Date)
            Application.DoEvents()
            Combo(7).Enabled = True
            Combo(0).Enabled = True
        Else
            SetListIndex(Combo(7), pThangDauKy)
            SetListIndex(Combo(0), pThangDauKy)
            Application.DoEvents()
            Combo(0).Visible = False
            Combo(2).Visible = False
            ' cu la : Text_Renamed(19).Visible = False
            Text_Renamed(19).Visible = True
            Label(14).Visible = False
            ' cu la : Label(33).Visible = False
            Label(33).Visible = True
            Label(0).Visible = False
            ' cu la : Label(34).Visible = False
            Label(34).Visible = True
            ' cu la : MedNgay.Visible = False
            MedNgay.Visible = True
            If Congcudungcu.ThangTang > 0 Or pNhapdauky1 Then
                Label(17).Visible = True
                Combo(7).Visible = True
                pNhapdauky1 = True
            Else
                Label(17).Visible = False
                Combo(7).Visible = False
                pNhapdauky1 = False
            End If
            If cuongdauky = 2 Then
                Label(17).Visible = True
                Combo(7).Visible = True
                pNhapdauky1 = True
                Congcudungcu.ThangTang = 1
            ElseIf cuongdauky = 1 Or cuongdauky = 3 Then
                Label(17).Visible = False
                Combo(7).Visible = False
                pNhapdauky1 = False
                Label(2).Visible = False
                Label(4).Visible = False
                Text_Renamed(4).Visible = False
                Text_Renamed(4).Text = "0"
            End If
        End If
        Dim dong, cot As Integer
        If FrmChungtu.Visible Then
            With FrmChungtu.GrdChungtu
                dong = .Row : cot = .Col
                .Row = 0 : .Col = 1
                If Strings.Left(.CtlText, 3) = "153" Then
                    If FrmChungtutonghop.CboThang.Items.Count > 0 And Combo(0).Items.Count > 0 Then
                        Combo(0).SelectedIndex = FrmChungtutonghop.CboThang.SelectedIndex
                        Combo(0).Enabled = False
                    Else
                        ' cap nhat ngay : 26/09/18
                        'Combo(0).Enabled = False 'mac dinh
                        Combo(0).Enabled = True
                    End If
                Else
                    Combo(0).Enabled = True
                End If
                .Row = dong : .Col = cot
            End With
        Else
            With FrmChungtutonghop.GrdChungtu
                dong = .Row : cot = .Col
                .Row = 0 : .Col = 1
                If Strings.Left(.CtlText, 3) = "153" Then
                    If FrmChungtutonghop.CboThang.Items.Count > 0 And Combo(0).Items.Count > 0 Then
                        Combo(0).SelectedIndex = FrmChungtutonghop.CboThang.SelectedIndex
                        Combo(0).Enabled = False
                    Else
                        Combo(0).Enabled = False
                    End If

                Else
                    Combo(0).Enabled = True
                End If
                .Row = dong : .Col = cot
            End With
        End If
        Khoaquyen()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="combo_box"></param>
    ''' <param name="ma_so"></param>
    ''' <remarks></remarks>
    Public Sub SetListIndex1(ByRef combo_box As Object, ByRef ma_so As Integer)
        Dim n As Integer
        If combo_box.ListCount = 0 Then Exit Sub
        Do Until (n = (combo_box.ListCount) - 1) Or (combo_box.ItemData(n) = ma_so)
            n += 1
        Loop
        combo_box.ListIndex = n
    End Sub
    ' KEYDOWN : Xử lý HotKey và Escape
    Private Sub FrmCongcudungcu_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
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
                End If
            End If
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    ' LOAD
    '     - Lấy danh sách các đối tượng quản lý, sử dụng, nước sản xuất và hệ thống phân loại
    '     - Khởi tạo môi trường nếu nhập mới
    '     - Lấy và hiển thị nội dung tài sản nếu đã có
    Private Sub FrmCongcudungcu_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load

        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            Dim Combo_NewIndex2 As Integer = -1
            'Dim chi_so As Integer
            pNhapdauky = (ConvertToDblSafe(Me.Tag) > 0)
            InitDateVars(MedNgay, Ngay)
            ' Lấy danh sách các đối tượng quan hệ
            Dim recset As DataTable
            Dim ktten As String = String.Empty
            If cuongdauky = 1 Then
                recset = ExecSQLReturnDT("SELECT SoHieu + '  ' + Ten AS F1, MaSo as F2 FROM LoaiCongcudungcu WHERE Cap = 1")
                Combo(1).Items.Clear()
                Combo(1).Items.ItemsBase.Clear()
                If recset.Rows.Count > 0 Then
                    For Each recsetItem As DataRow In recset.Rows
                        If Not IsDBNull(recsetItem("f1")) Then
                            Dim f1st As String = ConvertToStrSafe(recsetItem("f1"))
                            ktten = Strings.Right(f1st, f1st.Length - 3)

                            Combo(1).Items.Add(String.Format("{0}42{1}", Strings.Left(ktten, 1), Strings.Right(ktten, ktten.Length - 1)), ConvertToStrSafe(recsetItem("F2")))
                            'Combo(1).Items.Add(String.Format("{0}42{1}", Strings.Left(ktten, 1), Strings.Right(ktten, ktten.Length - 1)))
                            'VB6.SetItemData(Combo(1), Combo_NewIndex2, ConvertToStrSafe(recsetItem("F2")))										
                        End If
                    Next
                    If Combo(1).Items.Count > 0 Then Combo(1).SelectedIndex = 0
                End If
            Else
                Int_RecsetToCbo("SELECT SoHieu + '  ' + Ten AS F1, MaSo as F2 FROM LoaiCongcudungcu WHERE Cap = 1", Combo(1))
            End If
            Int_RecsetToCbo(String.Format("SELECT SoHieu + ' - ' + Ten AS F1, MaSo as F2 FROM HethongTK WHERE TK_ID2 = {0} AND TKCon = 0 ORDER BY SoHieu", TKCPSX_ID), Combo(5))
            AddMonthToCbo(Combo(7))
            AddMonthToCbo(Combo(0))
            ' Khởi tạo tài sản mới
            If pMaCongcudungcu = 0 Then
                ' Lấy danh sách các tháng có thể chọn
                ' Khởi tạo đối tượng Congcudungcu (Thủ tục này phải được gọi trước khi đặt tháng ngầm định)
                KhoiTaoCongcudungcu(False)
                ' Nếu nhập đầu kỳ thì đặt tháng ngầm định là tháng đầu kỳ, nếu tăng thì đặt bằng tháng tăng
                SetListIndex(Combo(7), IIf(pNhapdauky, pThangDauKy, pThangTacDong))
                SetListIndex(Combo(0), IIf(pNhapdauky, pThangDauKy, pThangTacDong))
                ' Khởi tạo môi trường
                Command(2).Visible = False
                Command(3).Visible = False
                Command(4).Visible = False
                ' Hiển thị các thông tin của tài sản đã có
            Else
                ' Lấy các thông tin trong dữ liệu. Quá trình hiển thị nội dung tài sản cần phải tránh các tác động
                ' do lấy và đặt thuộc tính ListIndex cho các ComboBox làm thay đổi thuộc tính phân loại đã có
                KhoiTao = True
                NoiDungCongcudungcu(pMaCongcudungcu, pThangTacDong)
                KhoiTao = False
                ' Lấy danh sách các tháng có thể chọn
                'Do While chi_so < Combo(7).Items.Count
                '    If Not InMonth(chi_so,iif(Congcudungcu.ThangTang = 0, pThangDauKy, Congcudungcu.ThangTang),iif(Congcudungcu.ThangGiam = 13, (iif(pThangDauKy > 1, pThangDauKy - 1, 12)), Congcudungcu.ThangGiam)) Then
                '        Combo(7).Items.RemoveAt(ConvertToDblSafe(chi_so))
                '    Else
                '        chi_so += 1
                '    End If
                'Loop
                'chi_so = 0
                '' Lấy danh sách các tháng có thể chọn
                'Do While chi_so < Combo(0).Items.Count
                '    If Not InMonth(chi_so,iif(Congcudungcu.ThangNhap = 0, pThangDauKy, Congcudungcu.ThangNhap),iif(Congcudungcu.ThangGiam = 13, (iif(pThangDauKy > 1, pThangDauKy - 1, 12)), Congcudungcu.ThangGiam)) Then
                '        Combo(0).Items.RemoveAt(ConvertToDblSafe(chi_so))
                '    Else
                '        chi_so += 1
                '    End If
                'Loop
                ' Đặt tháng ngầm định (sẽ dẫn đến việc hiển thị các thông số tương ứng)
                SetListIndex(Combo(7), pThangTacDong)
                SetListIndex(Combo(0), pThangTacDong)
                Application.DoEvents()
                ' Khởi tạo môi trường
                Command(3).Visible = False
                Command(4).Visible = False
            End If
            If pNN = 1 Then
                Me.Text = " Import Tool"
            Else
                Me.Text = " Nhập công cụ dụng cụ"
            End If
            If pMaCongcudungcu = 0 Then
                If cuongdauky = 1 Then
                    If pNN = 1 Then
                        Me.Text = " Enter Prepaid Expenses"
                    Else
                        Me.Text = " Nhập chi phí trả trước đầu kỳ"
                    End If
                Else
                    If cuongdauky = 2 Then
                        If pNN = 1 Then
                            Me.Text = " Beginning Import tool"
                        Else
                            Me.Text = " Nhập công cụ dụng cụ đầu kỳ"
                        End If
                    End If
                End If
            Else
                If cuongdauky = 3 Then
                    If pNN = 1 Then
                        Me.Text = " Edit Information In Prepaid Expense"
                    Else
                        Me.Text = " Sửa đổi chi tiết chi phí trả trước"
                    End If
                Else
                    If cuongdauky = 4 Then
                        If pNN = 1 Then
                            Me.Text = " Edit Information In Tool"
                        Else
                            Me.Text = " Sửa đổi chi tiết công cụ dụng cụ"
                        End If
                    End If
                End If
            End If
            pGhichungtu = 0
            Text = SetFormTitle(Text)
            psw = Interaction.GetSetting(IniPath, "Environment", "InvPsw", )
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
    Private Sub FrmCongcudungcu_MouseDown(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles MyBase.MouseDown
        Dim Button As Integer = ConvertToDblSafe(eventArgs.Button)
        Dim Shift As Integer = Control.ModifierKeys \ &H10000
        Dim X As Single = (eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        'If Button = 2097152 Then Ctx_mnpu.Show(Me, PointToClient(Cursor.Position).X, PointToClient(Cursor.Position).Y)
        If eventArgs.Button = MouseButtons.Right Then Ctx_mnpu.Show(Me, PointToClient(Cursor.Position).X, PointToClient(Cursor.Position).Y)
    End Sub
    ' UNLOAD : Xoá tham chiếu đến các Object đã khởi tạo
    Private Sub FrmCongcudungcu_Closed(ByVal eventSender As Object, ByVal eventArgs As CancelEventArgs) Handles MyBase.Closing
        If pNhapdauky Then
            If KiemTraSoLieuDauKy() = -1 Then
                eventArgs.Cancel = IIf(0, False, True)
                Exit Sub
            End If
            pNhapdauky = False
        End If
        Congcudungcu.ThongSo = Nothing
        Congcudungcu = Nothing
        pNhapdauky = False
        pNhapdauky1 = False
        MemoryHelper.ReleaseMemory()
    End Sub
    '======================================================================================
    ' command
    '     1. Ghi tài sản
    '           - kiểm tra
    '           - Ghi vào dữ liệu
    '           - Chuyển giá trị của tài sản vào biến chung GiaTri để ghi chứng từ
    '           - Ghi các dụng cụ phụ tùng kèm theo nếu có
    '           - Nếu nhập đầu kỳ thì tự động tạo chứng từ đầu kỳ. Nếu tăng trong kỳ thì cho nhập chứng từ tăng
    '           - Nếu không ghi lại chứng từ thì xoá tài sản vừa ghi.
    '     2. In hoặc xem thẻ tài sản
    '======================================================================================
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_4.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click, _Command_3.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Me.Cursor = Cursors.WaitCursor
        Dim rs, rs1 As DataTable
        Select Case Index
            Case 0 ' Ghi tài sản ........................................................................................................................................
                Text_Renamed_Leave(Text_Renamed(18), New EventArgs())
                If ConvertToDblSafe(GetSelectValue(String.Format("SELECT lock{0} as f1 FROM license", ConvertToDateSafe(MedNgay.Text).Month))) = 1 Then
                    If FrmPassword.GetPswX(String.Format("Dữ liệu tháng {0} đã bị khoá. Nhập mật khẩu ...", ConvertToDateSafe(MedNgay.Text).Month)) <> "MS" Then GoTo XongTS
                End If
                'thang nhap
                If Combo(0).Visible = True Then
                    If ConvertToDblSafe(GetSelectValue(String.Format("SELECT lock{0} as f1 FROM license", Combo(0).SelectedValue))) = 1 Then
                        If FrmPassword.GetPswX(String.Format("Dữ liệu tháng {0} đã bị khoá. Nhập mật khẩu ...", Combo(0).SelectedValue)) <> "MS" Then GoTo XongTS
                    End If
                End If

                'thang xuat
                If Combo(7).Visible = True Then
                    If ConvertToDblSafe(GetSelectValue(String.Format("SELECT lock{0} as f1 FROM license", Combo(7).SelectedValue))) = 1 Then
                        If FrmPassword.GetPswX(String.Format("Dữ liệu tháng {0} đã bị khoá. Nhập mật khẩu ...", Combo(7).SelectedValue)) <> "MS" Then GoTo XongTS
                    End If
                End If
                cuongccdcsoluong = ConvertToDblSafe(Text_Renamed(4).Text)
                If Congcudungcu.HopLe(pNhapdauky) = 0 Then
                    ' Thêm mới (tăng tài sản)
                    lenloai += 1
                    ReDim Preserve cuongccdcloai(lenloai)
                    cuongccdcloai(lenloai - 1) = Strings.Right(Timten("sohieu", ConvertToStrSafe(Congcudungcu.MaTaiKhoan), "maso", "Loaicongcudungcu"), 1) & "42"
                    If cuongccdcloai(lenloai - 1) = "142" Then cuongccdcloai(lenloai - 1) = "1421"
                    lenthang += 1
                    ReDim Preserve cuongccdcthang(lenthang)
                    cuongccdcthang(lenthang - 1) = ConvertToStrSafe(Combo(7).SelectedValue)
                    cuongccdcthang1 = ConvertToStrSafe(Combo(0).SelectedValue)
                    ngayChungTuPublic = ConvertToDateSafe(MedNgay.Text)
                    'If Not MedNgay.Visible Then Congcudungcu.NCT = Ngay
                    'van.nguyen 21-Nov -2011
                    If Not MedNgay.Visible Then Congcudungcu.NCT = ngayChungTuPublic
                    If pMaCongcudungcu = 0 Then
                        If pNhapdauky Then
                            Congcudungcu.NamSD = 1
                            Congcudungcu.NamSX = cuongccdcsoluong
                        Else
                            Congcudungcu.NamSD = 0
                            Congcudungcu.NamSX = 0
                        End If
                        If Combo(7).Items.Count > 0 Then
                            Congcudungcu.ThangTang = IIf(Combo(7).Visible, Combo(7).SelectedValue, 0)
                        End If

                        If Congcudungcu.ThemMoi(pNhapdauky) = 0 Then 'Chk.Value
                            If pNhapdauky And Not Combo(7).Visible Then ' cu la : If pNhapdauky And Not Combo(7).Visible Then
                                rs = ExecSQLReturnDT(String.Format("SELECT * FROM hethongtk WHERE left(sohieu,3)=N'{0}42' and tkcon=0 order by sohieu", (IIf(Combo(1).SelectedValue = 3, 2, Combo(1).SelectedValue))))
                                If rs.Rows.Count > 0 Then
                                    Dim rsItem As DataRow = rs.Rows(0)
                                    For i As Integer = 0 To 12
                                        ExecSQLNonQuery(String.Format("UPDATE hethongtk set duno_{0}=duno_{1}+{2} WHERE maso={3}", _
                                                            i, _
                                                            ConvertToStrSafe(i), _
                                                            ConvertToStrSafe(Congcudungcu.ThongSo.CL_TBS), _
                                                            IIf(Not IsDBNull(rsItem("MaSo")), ConvertToStrSafe(rsItem("MaSo")), "0")))
                                        If Strings.Left(ConvertToStrSafe(rsItem("SoHieu")), 3) = "142" Then
                                            ExecSQLNonQuery(String.Format("UPDATE hethongtk set duno_{0}={1}+{2} WHERE sohieu='142'", _
                                                                i, _
                                                                Timten(String.Format("duno_{0}", i), "1421", "sohieu", "hethongtk"), _
                                                                Timten(String.Format("duno_{0}", i), "1422", "sohieu", "hethongtk")))
                                        End If
                                    Next
                                End If
                            End If
                            cuongktluuccdc = 1
                            pMaCongcudungcu = Congcudungcu.MaSo
                            ' Chuyển giá trị của tài sản vừa ghi vào biến chung GiaTri để tạo và ghi chứng từ
                            ' (riêng lượng khấu hao sẽ không được ghi vào chứng từ tăng hoặc đầu kỳ )
                            With Congcudungcu.ThongSo
                                GiaTri.NG_NS = .NG_NS
                                GiaTri.NG_TBS = .NG_TBS
                                GiaTri.NG_CNK = .NG_CNK
                                GiaTri.NG_TD = .NG_TD
                                GiaTri.CL_NS = .CL_NS
                                GiaTri.CL_TBS = .CL_TBS
                                GiaTri.CL_CNK = .CL_CNK
                                GiaTri.CL_TD = .CL_TD
                            End With
                            ' Nếu nhập đầu kỳ thì tạo chứng từ đầu kỳ, nếu tăng trong kỳ thì tạo chứng từ tăng
                            If pNhapdauky Then
                                GhiChungTuDauKy()
                            Else
                                ' Thành lập dòng phát sinh
                                ThanhLapPhatSinhCCDC(NV_TANG, Congcudungcu.MaTaiKhoan)
                                pGhichungtu = 1
                                If FrmChungtutonghop.Visible Then
                                    SetListIndex(FrmChungtutonghop.CboThang, Combo(7).SelectedValue)
                                    SetListIndex(FrmChungtutonghop.CboThang, Combo(0).SelectedValue)
                                    FrmChungtutonghop.txt(0).Text = Text_Renamed(19).Text
                                    FrmChungtutonghop.MedNgay(0).Text = MedNgay.Text
                                    FrmChungtutonghop.MedNgay(1).Text = MedNgay.Text
                                    FrmChungtutonghop.txt(1).Text = Text_Renamed(1).Text
                                Else
                                    SetListIndex(FrmChungtu.CboThang, Combo(7).SelectedValue)
                                    SetListIndex(FrmChungtu.CboThang, Combo(0).SelectedValue)
                                    FrmChungtu.txt(0).Text = Text_Renamed(19).Text
                                    FrmChungtu.MedNgay(0).Text = MedNgay.Text
                                    FrmChungtu.MedNgay(1).Text = MedNgay.Text
                                    FrmChungtu.txt(1).Text = Text_Renamed(1).Text
                                End If
                                Me.Close()
                                Exit Sub
                            End If
                            pMaCongcudungcu = 0
                            pMaChungTu = 0
                            KhoiTaoCongcudungcu(True)
                        End If
                    Else
                        If psw.Length > 0 Then
                            If FrmPassword.GetPswX() <> psw Then GoTo XongTS
                        End If
                        Select Case Congcudungcu.SuaDoi(pNhapdauky)
                            Case 0
                                pMaCongcudungcu = 0
                                If Combo(7).Items.Count > 0 Then
                                    If Combo(7).SelectedValue = pThangDauKy Then SoDuTKTSCCDC()
                                End If

                                KiemTraVatTu()
                                If pNhapdauky And Not Combo(7).Visible Then
                                    rs = ExecSQLReturnDT(String.Format("SELECT * FROM hethongtk WHERE left(sohieu,3)=N'{0}42' and tkcon=0", (IIf(Combo(1).SelectedValue = 3, 2, Combo(1).SelectedValue))))
                                    Dim rsItem As DataRow = rs.Rows(0)
                                    If rs.Rows.Count > 0 Then
                                        rs1 = ExecSQLReturnDT(String.Format("SELECT Sum(NG_NS+NG_TBS+NG_CNK+NG_TD) AS TNG, Sum(CL_NS+CL_TBS+CL_CNK+CL_TD) AS TCL FROM CTCongcudungcu inner join congcudungcu on ctcongcudungcu.mats=congcudungcu.maso WHERE Thang{0} and mataikhoan={1} and congcudungcu.maloai={2}", _
                                                                  (IIf(Combo(7).Visible, ">0", "=0")), _
                                                                  ConvertToStrSafe(Congcudungcu.MaTaiKhoan), _
                                                                  ConvertToStrSafe(Congcudungcu.maloai)))
                                        Dim rs1Item As DataRow = rs1.Rows(0)
                                        For i As Integer = 0 To 12
                                            ExecSQLNonQuery(String.Format("UPDATE hethongtk set duno_{0}={1} WHERE maso={2}", _
                                                                i, _
                                                                ConvertToDblSafe(rs1Item("TCL")), _
                                                                (IIf(Not IsDBNull(rsItem("MaSo")), ConvertToStrSafe(rsItem("MaSo")), "0"))))
                                            If Strings.Left(ConvertToStrSafe(rsItem("SoHieu")), 3) = "142" Then
                                                ExecSQLNonQuery(String.Format("UPDATE hethongtk set duno_{0}={1}+{2} WHERE sohieu='142'", _
                                                                    i, _
                                                                    Timten(String.Format("duno_{0}", i), "1421", "sohieu", "hethongtk"), _
                                                                    Timten(String.Format("duno_{0}", i), "1422", "sohieu", "hethongtk")))
                                            End If
                                        Next
                                    End If
                                End If
                                SendKeys.Send("{Escape}")
                            Case -2, -3
                                MessageBox.Show(Ngonngu("Chú ý : sửa đổi lượng phân bổ và giá trị của một tài sản đã bị giảm hoặc đánh giá lại sẽ làm cho số liệu ghi trên chứng từ tương ứng không còn chính xác nữa. Xoá các chứng từ có liên quan đi và sau đó ghi lại nếu cần sửa đổi", _
                                                            "Note: Distribution and modification of the value of an asset has been reduced or reassessment would make the data recorded in the corresponding voucher no longer accurate. Delete the relevant voucher and then write back if you need to modify"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End Select
                    End If
                End If
            Case 1 ' Trở về ...................................................................................................................................................
                pMaCongcudungcu = 0
                SendKeys.Send("{Escape}")
            Case 3 ' In thẻ tài sản trong năm ...................................................................................................................
                TaoTheCongcudungcu(0, Combo(7).SelectedValue)
            Case 4 ' Xem trước thẻ tài sản trong năm ...................................................................................................
                TaoTheCongcudungcu(1, Combo(7).SelectedValue)
        End Select
XongTS:
        Me.Cursor = Cursors.Default
    End Sub
    '======================================================================================
    ' COMBO
    '======================================================================================
    Private Sub Combo_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Combo_0.SelectedIndexChanged, _Combo_7.SelectedIndexChanged, _Combo_5.SelectedIndexChanged, _Combo_2.SelectedIndexChanged, _Combo_1.SelectedIndexChanged
        Dim Index As Integer = Array.IndexOf(Combo, eventSender)
        Dim vis As Boolean
        Select Case Index
            Case 1 ' Tài khoản
                If Not (Combo(1).SelectedIndex = -1) Then
                    If Not KhoiTao Then Congcudungcu.MaTaiKhoan = Combo(1).SelectedValue
                    Int_RecsetToCbo(String.Format("SELECT SoHieu + '  ' + Ten AS F1, MaSo as F2 FROM LoaiCongcudungcu WHERE CapTren = {0}", Combo(1).SelectedValue), Combo(2))
                    If Combo(2).Items.Count = 0 Then
                        Congcudungcu.maloai = 0
                    Else
                        Combo(2).SelectedIndex = 0
                    End If
                Else
                    Congcudungcu.MaTaiKhoan = 0
                End If
            Case 2 ' Phân loại
                If Not (Combo(2).SelectedIndex = -1) Then
                    If Not KhoiTao Then Congcudungcu.maloai = Combo(2).SelectedValue
                Else
                    Congcudungcu.maloai = 0
                End If
            Case 5 ' Đối tượng sử dụng
                Congcudungcu.ThongSo.MaDTSD = IIf(Not (Combo(5).SelectedIndex = -1), Combo(5).SelectedValue, 0)
            Case 0, 7 ' Tháng
                ' Lấy tháng tăng của tài sản
                If pMaCongcudungcu = 0 Then
                    If pNhapdauky Then
                        Congcudungcu.ThangTang = 0
                        Congcudungcu.ThangNhap = 0
                    Else
                        Congcudungcu.ThangTang = Combo(7).SelectedValue
                        If Combo(0).SelectedIndex <> -1 Then Congcudungcu.ThangNhap = Combo(0).SelectedValue
                        pThangTacDong = Congcudungcu.ThangTang
                    End If
                    ' Hiển thị các thông số tương ứng
                Else
                    vis = (Congcudungcu.ThangTang = 0) And (pNghiepVu <> NV_TANG)
                    MedNgay.Enabled = vis
                    Text_Renamed(19).ReadOnly = Not vis
                    MedNgay.TabStop = vis
                    Text_Renamed(19).TabStop = vis
                    Congcudungcu.ThongSo.ChiDinh1(pMaCongcudungcu, Combo(7).SelectedValue)
                    With Congcudungcu.ThongSo
                        ' Nguyên giá
                        Text_Renamed(7).Text = Format(.NG_TBS, Mask_0)
                        ' Hao mòn
                        Text_Renamed(11).Text = Format(.NG_TBS - .CL_TBS, Mask_0)
                        ' khấu hao
                        Text_Renamed(15).Text = Format(.KH_TBS, Mask_0)
                        ' Giá trị còn lại
                        Label(27).Text = Format(.CL_TBS, Mask_0)
                        ' Tổng số
                        Label(19).Text = Format(.NG_NS + .NG_TBS + .NG_CNK + .NG_TD, Mask_0)
                        Label(20).Text = Format((.NG_NS - .CL_NS) + (.NG_TBS - .CL_TBS) + (.NG_CNK - .CL_CNK) + (.NG_TD - .CL_TD), Mask_0)
                        Label(21).Text = Format(.CL_NS + .CL_TBS + .CL_CNK + .CL_TD, Mask_0)
                        Label(22).Text = Format(.KH_NS + .KH_TBS + .KH_CNK + .KH_TD, Mask_0)
                        SetListIndex(Combo(5), .MaDTSD)
                    End With
                    ' Cho phép sửa nguyên giá và lượng phân bổ của công cụ dụng cụ vào tháng đầu kỳ
                    ' (với điều kiện công cụ dụng cụ được nhập đầu kỳ và chưa bị ghi chứng từ giảm)
                    If Combo(0).SelectedIndex <> -1 Then
                        If (((Combo(7).SelectedIndex = 0 And Combo(0).SelectedIndex = 0) Or (Combo(7).SelectedValue = Congcudungcu.ThangTang And Combo(0).SelectedValue = Congcudungcu.ThangNhap)) And Congcudungcu.ThangGiam = 13 And Not KhongDCCCDC(Congcudungcu.MaSo)) Or ((Combo(7).SelectedIndex = 0) And (Combo(0).SelectedIndex = 0)) Then
                            Text_Renamed(7).ReadOnly = False
                            Text_Renamed(11).ReadOnly = False
                            Text_Renamed(4).ReadOnly = False
                            Text_Renamed(18).ReadOnly = False
                            Text_Renamed(15).ReadOnly = False
                            Text_Renamed(1).ReadOnly = False
                            Text_Renamed(19).ReadOnly = False
                            Combo(1).DropDownStyle = ComboBoxStyle.DropDown ' C15 Unlock ComboBox
                            Combo(2).DropDownStyle = ComboBoxStyle.DropDown ' C15 Unlock ComboBox
                            Combo(5).DropDownStyle = ComboBoxStyle.DropDown ' C15 Unlock ComboBox
                        Else
                            Text_Renamed(7).ReadOnly = False
                            Text_Renamed(11).ReadOnly = False
                            Text_Renamed(4).ReadOnly = False
                            Text_Renamed(18).ReadOnly = False
                            Text_Renamed(15).ReadOnly = False
                            Text_Renamed(1).ReadOnly = False
                            Text_Renamed(19).ReadOnly = False
                            Combo(1).DropDownStyle = ComboBoxStyle.DropDownList ' C15 Lock ComboBox
                            Combo(2).DropDownStyle = ComboBoxStyle.DropDownList ' C15 Lock ComboBox
                            Combo(5).DropDownStyle = ComboBoxStyle.DropDownList ' C15 Lock ComboBox
                        End If
                    End If
                End If
                ' Không cho sửa lượng khấu hao nếu tài sản đã giảm trong năm
                If Congcudungcu.ThangGiam < 13 Then
                    Text_Renamed(15).ReadOnly = True
                    Text_Renamed(18).ReadOnly = True
                End If
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub mndd_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mndd_0.Click, _mndd_1.Click, _mndd_2.Click, _mndd_3.Click, _mndd_4.Click
        Dim Index As Integer = Array.IndexOf(mndd, eventSender)
        Select Case Index
            Case 1
                frmMain.mnts_Click(frmMain.mnts(5), New EventArgs())
                Int_RecsetToCbo("SELECT Ten AS F1, MaSo as F2 FROM TinhTrang ORDER BY Ten", Combo(5))
            Case 4
                FrmTaikhoan.Tag = "1"
                FrmTaikhoan.ShowDialog()
                Int_RecsetToCbo("SELECT SoHieu + ' - ' + Ten AS F1, MaSo as F2 FROM HethongTK" & " WHERE TK_ID2 = " & TKCPSX_ID & " AND TKCon = 0 ORDER BY SoHieu", Combo(5))
        End Select
    End Sub
    '======================================================================================
    ' TEXT
    '======================================================================================
    Private Sub Text_Renamed_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Text_4.Enter, _Text_1.Enter, _Text_15.Enter, _Text_7.Enter, _Text_11.Enter, _Text_18.Enter, _Text_19.Enter
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        Text_Renamed(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Text_Renamed_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _Text_4.KeyPress, _Text_1.KeyPress, _Text_15.KeyPress, _Text_7.KeyPress, _Text_11.KeyPress, _Text_18.KeyPress, _Text_19.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        If Index = 0 And (KeyAscii = 32 Or KeyAscii = 39 Or KeyAscii = 42) Then KeyAscii = 0
        If (Index >= 6 And Index <= 18 Or Index = 4) And Not Text_Renamed(Index).ReadOnly Then KeyProcess(Text_Renamed(Index), KeyAscii)
        If Index = 1 And KeyAscii = 13 Then
            cuongktccdc = 1
            cuongccdc = FrmVattu.ChonVattu(Text_Renamed(Index).Text, 0, 0, 0, 0, "153")
            lenma += 1
            ReDim Preserve cuongccdcma(lenma)
            cuongccdcma(lenma - 1) = cuongccdc
            Text_Renamed(Index).Text = Timten("tenvattu", cuongccdc, "sohieu", "vattu")
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
    Private Sub Text_Renamed_KeyUp(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles _Text_4.KeyUp, _Text_1.KeyUp, _Text_15.KeyUp, _Text_7.KeyUp, _Text_11.KeyUp, _Text_18.KeyUp, _Text_19.KeyUp
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        If Index = 1 Then
            If eventArgs.KeyCode <> Keys.Enter And Not Text_Renamed(Index).ReadOnly Then Text_Renamed(Index).Text = ""
        End If
    End Sub
    ' LostFocus
    Private Sub Text_Renamed_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Text_4.Leave, _Text_1.Leave, _Text_15.Leave, _Text_7.Leave, _Text_11.Leave, _Text_18.Leave, _Text_19.Leave
        Dim Err_DataTypeConvertion As Boolean = False
        Dim Index As Integer = Array.IndexOf(Text_Renamed, eventSender)
        Dim i, sn As Integer
        If Index >= 6 And Index <= 18 Then
            Text_Renamed(Index).Text = Format(Text_Renamed(Index).Text, Mask_0)
        End If
        If Strings.Len(Text_Renamed(Index).Text) = 0 Then
            Text_Renamed(Index).Text = IIf((Index < 3 Or Index = 5), "(...)", "0")
        End If
        Try
            Err_DataTypeConvertion = True
            Select Case Index
                Case 1 : Congcudungcu.ten = Text_Renamed(1).Text
                    Congcudungcu.SoHieu = cuongccdc
                    ' Nguyên giá
                Case 7 : Congcudungcu.ThongSo.NG_TBS = ConvertToDblSafe(Text_Renamed(7).Text)
                    ' Hao mòn
                Case 11 : Congcudungcu.ThongSo.HM_TBS = ConvertToDblSafe(Text_Renamed(11).Text)
                    ' khấu hao
                Case 15 : Congcudungcu.ThongSo.KH_TBS = ConvertToDblSafe(Text_Renamed(15).Text)
                Case 18
                    sn = ConvertToDblSafe(Text_Renamed(18).Text)
                    Congcudungcu.NamKH = sn
                    If sn > 0 And (Not Text_Renamed(18).ReadOnly) Then
                        i = 7
                        If ConvertToDblSafe(Label(20 + (IIf(i < 9, i, 10))).Text) > 0 Then
                            Text_Renamed(i + 8).Text = Format(RoundMoney(ConvertToDblSafe(Text_Renamed(i).Text) / sn), Mask_0)
                            Text_Renamed_Leave(Text_Renamed(i + 8), New EventArgs())
                        End If
                    End If
                Case 19 : Congcudungcu.shct = Text_Renamed(19).Text
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
            With Congcudungcu.ThongSo
                If Index > 5 And Index < 14 Or Index = 4 Then
                    If Index < 10 Then
                        Label(19).Text = Format(.NG_NS + .NG_TBS + .NG_CNK + .NG_TD, Mask_0)
                        Label(4).Text = Format(ConvertToDblSafe(Text_Renamed(4).Text), Mask_0)
                    Else
                        Label(20).Text = Format(.HM_NS + .HM_TBS + .HM_CNK + .HM_TD, Mask_0)
                    End If
                    .CL_NS = .NG_NS - .HM_NS
                    .CL_TBS = .NG_TBS - .HM_TBS
                    .CL_CNK = .NG_CNK - .HM_CNK
                    .CL_TD = .NG_TD - .HM_TD
                    Label(27).Text = Format(.CL_TBS, Mask_0)
                    Label(21).Text = Format(.CL_NS + .CL_TBS + .CL_CNK + .CL_TD, Mask_0)
                End If
                If Index > 13 Then Label(22).Text = Format(.KH_NS + .KH_TBS + .KH_CNK + .KH_TD, Mask_0)
                If _Text_18.Text <> Nothing And _Text_7.Text <> Nothing Then
                    _Text_15.Text = Format(.KH_NS + .KH_TBS + .KH_CNK + .KH_TD, Mask_0)
                End If
            End With

        Catch excep As System.Exception
            If Not Err_DataTypeConvertion Then
                Throw excep
            End If
            If Err_DataTypeConvertion Then
                Text_Renamed(Index).Focus()
            End If
        End Try
    End Sub
    '======================================================================================
    ' SUB KhoiTaoCongcudungcu
    '======================================================================================
    Private Sub KhoiTaoCongcudungcu(ByRef tiep_tuc As Boolean)
        Congcudungcu.Init() ' Khởi tạo đối tượng Congcudungcu
        Dim chi_so As Integer = 1
        Text_Renamed(chi_so).Text = ""
        chi_so = 4
        Text_Renamed(chi_so).Text = "0"
        chi_so = 7
        Text_Renamed(chi_so).Text = "0"
        chi_so = 11
        Text_Renamed(chi_so).Text = "0"
        chi_so = 15
        Text_Renamed(chi_so).Text = "0"
        chi_so = 4
        Label(chi_so).Text = "0"
        chi_so = 19
        Label(chi_so).Text = "0"
        chi_so = 20
        Label(chi_so).Text = "0"
        chi_so = 21
        Label(chi_so).Text = "0"
        chi_so = 22
        Label(chi_so).Text = "0"
        chi_so = 27
        Label(chi_so).Text = "0"
        chi_so = 5
        ' Combo(chi_so).SelectedIndex = -1
        If Not tiep_tuc Then ' Nếu là lần khởi tạo đầu tiên thì xoá
            'Combo(chi_so).SelectedIndex = -1
            For chi_so = 1 To 2 ' các Combo thuộc hệ thống phân loại
                Combo(chi_so).SelectedIndex = -1
            Next
        Else
            ' Nếu đang tiếp tục nhập tài sản thì tạo số hiệu mới, lấy
            '            TaoSoHieuCongcudungcu                        ' mã số của phân loại hiện tại và tháng tăng ngầm định
            If Combo(1).Items.Count > 0 Then
                Congcudungcu.MaTaiKhoan = Combo(1).SelectedValue
            End If

            Congcudungcu.maloai = Combo(2).SelectedValue
        End If
        Combo_SelectedIndexChanged(Combo(1), New EventArgs())
        Combo_SelectedIndexChanged(Combo(2), New EventArgs())
        Combo_SelectedIndexChanged(Combo(5), New EventArgs())
        Combo_SelectedIndexChanged(Combo(0), New EventArgs())
        Combo_SelectedIndexChanged(Combo(7), New EventArgs())
    End Sub
    '======================================================================================
    ' SUB NoiDungCongcudungcu : Lấy và hiển thị nội dung tài sản.
    '                                 Chú ý : Đặt thuộc tính ListIndex của các Combo thuộc hệ thống phân loại sẽ dẫn
    '                                               đến Events_Click tương ứng
    '                                               Nội dung các thông số sẽ được hiển thị trong Events_Click của Combo(7)
    '======================================================================================
    Private Sub NoiDungCongcudungcu(ByRef ma_ts As Integer, ByRef thang_cd As Integer)
        Congcudungcu.ChiDinh(ma_ts, thang_cd)
        Dim ml As Integer = Congcudungcu.maloai
        SetListIndex(Combo(1), Congcudungcu.MaTaiKhoan)
        SetListIndex(Combo(2), ml)
        Congcudungcu.maloai = ml
        Text_Renamed(1).Text = Congcudungcu.ten
        Text_Renamed(4).Text = ConvertToStrSafe(cuongccdcsoluong)
        Label(4).Text = ConvertToStrSafe(cuongccdcsoluong)
        Text_Renamed(18).Text = ConvertToStrSafe(Congcudungcu.NamKH)
        Text_Renamed(19).Text = Congcudungcu.shct
        Ngay = Congcudungcu.NCT
        MedNgay.Text = Format(Ngay, Mask_D)
    End Sub
    '======================================================================================
    ' SUB GhiChungTuDauKy : Tạo chứng từ riêng cho các tài sản nhập đầu kỳ.
    '                                      Chú ý : Tháng chứng từ được ghi bằng 0, mã loại và mã nhóm được đặt theo hằng
    '                                                     số DK_LOAI và DK_NHOM để phân biệt với các chứng từ khác.
    '                                                     Lượng khấu hao của chứng từ đầu kỳ luôn bằng 0.
    '======================================================================================
    Private Sub GhiChungTuDauKy()
        Dim SoHieu, sql, taikhoanco As String
        Dim rs As DataTable
        Dim ngayxuat As Date
        'If Congcudungcu.ThangTang > 0 Then
        sql = "UPDATE tonkho SET "
        For i As Integer = 0 To 12
            sql = String.Format("{0}Luong_{1}=luong_{1}+{2},tien_{1}=tien_{1}+{3},", _
                      sql, _
                      ConvertToStrSafe(i), _
                      ConvertToStrSafe(cuongccdcsoluong), _
                      CStr(GiaTri.NG_TBS))
        Next
        sql = String.Format("{0}  WHERE mavattu={1} and mataikhoan={2}", _
                  sql.Substring(0, sql.Length - 1), _
                  Timten("maso", cuongccdc, "sohieu", "vattu"), _
                  Timten("maso", Combo(1).Text.Substring(0, 4), "sohieu", "hethongtk"))
        Dim RecordsAffectedCount As Integer = ExecSQLNonQuery(sql)
        If RecordsAffectedCount = 0 Then
            sql = String.Format("INSERT INTO tonkho (MaSo,masokho,mataikhoan,mavattu,luong_0,tien_0) VALUES ({0},{1},{2},{3},{4},{5})", _
                      Lng_MaxValue("MaSo", "tonkho") + 1, _
                      ConvertToStrSafe(GetSelectValue("SELECT maso as f1 FROM khohang")), _
                      Timten("maso", Combo(1).Text.Substring(0, 4), "sohieu", "hethongtk"), _
                      Timten("maso", cuongccdc, "sohieu", "vattu"), _
                      ConvertToStrSafe(cuongccdcsoluong), _
                      CStr(GiaTri.NG_TBS))
            ExecSQLNonQuery(sql)
            '            FVTDauKy.GhiDauKy ConvertToStrSafe(GetSelectValue("SELECT maso as f1 FROM khohang")), timten("maso", Left(Combo(1).Text, 4), "sohieu", "hethongtk"), timten("maso", tuongccdc, "sohieu", "vattu"), ConvertToStrSafe(tuongccdcsoluong), cstr(GiaTri.NG_TBS), 0
        End If
        rs = ExecSQLReturnDT("SELECT  sohieu FROM    chungtu WHERE   sohieu LIKE 'XTCCDK%' ORDER BY sohieu DESC")
        If rs.Rows.Count = 0 Then
            SoHieu = "XTCCDK001"
        Else
            Dim rsItem As DataRow = rs.Rows(0)
            SoHieu = SHCtuMoi(ConvertToStrSafe(rsItem("SoHieu")))
        End If
        ngayxuat = DateSerial(ConvertToDblSafe(frmMain._LbCty_7.Text), Congcudungcu.ThangTang, 1)

        taikhoanco = Timten("maso", _
                         String.Format("{0}421", Strings.Right(Strings.Left(Combo(1).Text, 4), 1)), _
                         "sohieu", _
                         "hethongtk")
        If taikhoanco.Length = 0 Then
            taikhoanco = Timten("maso", String.Format("{0}42", Strings.Right(Strings.Left(Combo(1).Text, 4), 1)), "sohieu", "hethongtk")
        End If
        If taikhoanco.Length = 0 Then            
            Dim separators() As String = {" "}
            Dim result() As String
            result = Combo(1).Text.Split(separators, StringSplitOptions.RemoveEmptyEntries)
            If result.Length > 0 Then
                taikhoanco = Timten("maso", result(0), "sohieu", "hethongtk")
            Else
                taikhoanco = "-1"
            End If
        End If
        sql = String.Format("INSERT INTO Chungtu (MaCT, MaLoai, SoHieu, ThangCT, NgayCT, NgayGS, MaNguon, MaKho, DienGiai,MaTkNo, MaTkCo, SoPS, SoPS2No, SoPS2Co, MaTkTCNo, MaTkTCCo, MaVattu, GhiChu, CT_ID, MaDT, MaDT1, MaDT2, MaDT3,MaKH,CTGS,MaKHC,MaTP,DVT,[User_ID],MaNV,HanTT,SH1,T1,TLCK,CK) VALUES ({12},2, N'{1}',{2}, N'{3}', N'{3}',{4},{5},N'Xuất công cụ đầu kỳ',{6},{7},{8},0,'{9}',{6},{7},{10},'...',0,1,0,0,0,0,1,0,0,0,{11},0,0,'...',0,0,0)", _
                  Lng_MaxValue("mact", "chungtu") + 1, _
                  SoHieu, _
                  ConvertToStrSafe(Congcudungcu.ThangTang), _
                  Format(ngayxuat, Mask_DB), _
                  ConvertToStrSafe(GetSelectValue("SELECT maso as f1 FROM nguonnhapxuat")), _
                  ConvertToStrSafe(GetSelectValue("SELECT maso as f1 FROM khohang")), _
                  taikhoanco, _
                  Timten("maso", Combo(1).Text.Substring(0, 4), "sohieu", "hethongtk"), _
                  doidau(GiaTri.NG_TBS), _
                  ConvertToStrSafe(cuongccdcsoluong), _
                  Timten("maso", Congcudungcu.ten, "tenvattu", "vattu"), _
                  Timten("maso", ConvertToStrSafe(1111111111), "VT", "users"), _
                  Lng_MaxValue("Maso", "chungtu") + 1)
        ExecSQLNonQuery(sql)
        KiemTraVatTu()
        'End If
        With GiaTri
            sql = String.Format("INSERT INTO CTCongcudungcu (MaSo,MaCTKT, Thang, VaoSo, NgayGhi, DienGiai, MaLoai, MaTS, NG_NS, NG_TBS, NG_CNK, NG_TD, CL_NS, CL_TBS, CL_CNK, CL_TD) VALUES ({0},{1},{2},N'{3}',N'{3}',N'{4}',{5},{6},{7},{8},{9},{10},{11},{12},{13},{14})", _
                      Lng_MaxValue("MaSo", "CTCongcudungcu") + 1, _
                      ConvertToStrSafe(Lng_MaxValue("mact", "chungtu")), _
                      ConvertToStrSafe(Congcudungcu.ThangTang), _
                      Format(DateTime.Today, Mask_DB), _
                      (IIf(Congcudungcu.ThangTang > 0, "Công cụ dụng cụ đầu kỳ", "Chi phí đầu trả trước kỳ")), _
                      ConvertToStrSafe(DK_LOAI), _
                      ConvertToStrSafe(pMaCongcudungcu), _
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
    ' SUB TaoTheCongcudungcu
    '======================================================================================
    Private Sub TaoTheCongcudungcu(ByRef ket_xuat As Integer, ByRef thang As Integer)
        Dim trong_nam, luy_ke As Double
        Dim so_hieu, ngay_thang, dien_giai As String
        Me.Cursor = Cursors.WaitCursor
        HienThongBao("In thẻ tài sản", 1)
        With GiaTri
            ' Tính lượng hao mòn cho đến tại tháng hiện tại (có trính khấu hao tháng hiện tại)
            TinhGiaTriCongcudungcu(Congcudungcu.MaSo, thang, KH_CO)
            luy_ke = (.NG_NS - .CL_NS) + (.NG_TBS - .CL_TBS) + (.NG_CNK - .CL_CNK) + (.NG_TD - .CL_TD)
            ' Tính lượng hao mòn cho đến hết năm (có trính khấu hao tháng cuối năm)
            If Congcudungcu.ThangTang > 0 Then
                trong_nam = luy_ke
            Else
                TinhGiaTriCongcudungcu(Congcudungcu.MaSo, 0, KH_CO)
                trong_nam = luy_ke - ((.NG_NS - .CL_NS) + (.NG_TBS - .CL_TBS) + (.NG_CNK - .CL_CNK) + (.NG_TD - .CL_TD))
            End If
        End With
        ' Lấy chứng từ giảm (nếu có)
        Dim sql As String = String.Format("SELECT SoHieu, NgayGhi, DienGiai FROM CTCongcudungcu WHERE MaTS = {0} AND MaLoai = {1}", _
                                Congcudungcu.MaSo, _
                                ConvertToStrSafe(NV_GIAM))
        Dim rs_giam As DataTable = ExecSQLReturnDT(sql)
        If rs_giam.Rows.Count = 0 Then
            so_hieu = "....................."
            ngay_thang = "...................."
            dien_giai = ".............................................................."
        Else
            Dim rsgiamItem As DataRow = rs_giam.Rows(0)
            so_hieu = ConvertToStrSafe(rsgiamItem("SoHieu"))
            ngay_thang = ConvertToDateSafe(rsgiamItem("NgayGhi")).ToString("dd/MM/yy")
            dien_giai = ConvertToStrSafe(rsgiamItem("DienGiai"))
        End If
        ' Dữ liệu
        'SetSQL("TheTaiSan", String.Format("SELECT DISTINCT Congcudungcu.SoHieu AS SoHieuTS, Congcudungcu.Ten AS TenTS, Congcudungcu.NangLuc, QuocGia.Ten AS TenNuoc, Congcudungcu.NamSX, Congcudungcu.NamSD, CTCongcudungcu.SoHieu AS SoHieuCT, CTCongcudungcu.Thang, CTCongcudungcu.DienGiai, (CTCongcudungcu.NG_NS+CTCongcudungcu.NG_TBS+CTCongcudungcu.NG_CNK+CTCongcudungcu.NG_TD) AS TNG , CTCongcudungcu.NgayGhi FROM QuocGia RIGHT JOIN (Congcudungcu RIGHT JOIN CTCongcudungcu ON Congcudungcu.MaSo = CTCongcudungcu.MaTS) ON QuocGia.MaSo = Congcudungcu.MaNuoc WHERE Congcudungcu.MaSo = {0} ORDER BY CTCongcudungcu.NgayGhi", Congcudungcu.MaSo))
        Dim TheTaiSan As String = String.Format("SELECT DISTINCT Congcudungcu.SoHieu AS SoHieuTS, Congcudungcu.Ten AS TenTS, Congcudungcu.NangLuc, QuocGia.Ten AS TenNuoc, Congcudungcu.NamSX, Congcudungcu.NamSD, CTCongcudungcu.SoHieu AS SoHieuCT, CTCongcudungcu.Thang, CTCongcudungcu.DienGiai, (CTCongcudungcu.NG_NS+CTCongcudungcu.NG_TBS+CTCongcudungcu.NG_CNK+CTCongcudungcu.NG_TD) AS TNG , CTCongcudungcu.NgayGhi FROM QuocGia RIGHT JOIN (Congcudungcu RIGHT JOIN CTCongcudungcu ON Congcudungcu.MaSo = CTCongcudungcu.MaTS) ON QuocGia.MaSo = Congcudungcu.MaNuoc WHERE Congcudungcu.MaSo = {0} ORDER BY CTCongcudungcu.NgayGhi", Congcudungcu.MaSo)
        InTheCongcudungcu(ket_xuat, "THECCDC.rpt", TheTaiSan, Format(trong_nam, Mask_0), Format(luy_ke, Mask_0))
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ket_xuat"></param>
    ''' <param name="ten_file"></param>
    ''' <param name="Sql"></param>
    ''' <param name="ct_2"></param>
    ''' <param name="ct_3"></param>
    ''' <param name="ct_4"></param>
    ''' <remarks></remarks>
    Private Sub InTheCongcudungcu(ByRef ket_xuat As Integer, ByRef ten_file As String, ByVal Sql As String, Optional ByRef ct_2 As String = "", Optional ByRef ct_3 As String = "", Optional ByRef ct_4 As String = "")
        rptFrom.InitForm(ten_file, Sql, "QNhatky")
        ' Ket Xuất
        Select Case ket_xuat
            Case 0
                rptFrom.ReportDestination = 1
                rptFrom.ReportWindowTitle = "Thẻ công cụ dụng cụ"
            Case 1
                rptFrom.ReportDestination = 0
        End Select

        ' Tên File dữ liệu và báo cáo
        'frmMain.rpt.set_DataFiles(0, pDataPath)
        ' Công thức
        rptFrom.SetFormulas("TenCongTy", String.Format("'{0}'", pTenCty))
        rptFrom.SetFormulas("TenChiNhanh", String.Format("'{0}'", pTenCn))
        rptFrom.SetFormulas("TrongNam", String.Format("'{0}'", ct_3))
        rptFrom.SetFormulas("LuyKe", String.Format("'{0}'", ct_4))
        rptFrom.SetFormulas("TenBaoCao", "'Thẻ công cụ dụng cụ'")
        InBaoCaoRPT()
        SystemSounds.Beep.Play()
    End Sub
    '======================================================================================
    ' FUNCTION KiemTraSoLieuDauKy
    '======================================================================================
    Private Function KiemTraSoLieuDauKy() As Integer
        Dim result As Integer = 0
        Me.Cursor = Cursors.WaitCursor
        'van.nguyen 16-Nov-2011
        'Dim sql As String = String.Format("SELECT Sum(NG_NS+NG_TBS+NG_CNK+NG_TD) AS TNG, Sum(CL_NS+CL_TBS+CL_CNK+CL_TD) AS TCL FROM CTCongcudungcu inner join congcudungcu on ctcongcudungcu.mats=congcudungcu.maso WHERE namsd=1 and Thang{0}", (iif(Combo(7).Visible, ">0", "=0")))
        Dim sql As String = String.Format("SELECT isnull(Sum(NG_NS+NG_TBS+NG_CNK+NG_TD),0) AS TNG, isnull(Sum(CL_NS+CL_TBS+CL_CNK+CL_TD),0) AS TCL FROM CTCongcudungcu inner join congcudungcu on ctcongcudungcu.mats=congcudungcu.maso WHERE namsd=1 and Thang{0}", (IIf(Combo(7).Visible, ">0", "=0")))

        Dim rs_dauky As DataTable = ExecSQLReturnDT(sql)
        If rs_dauky.Rows.Count > 0 Then
            MessageBox.Show(String.Format("Số liệu đầu kỳ đã nhập:{0}  Tổng nguyên giá : {1}{0}  Tổng còn lại : {2}", _
                                Environment.NewLine, _
                                Format(rs_dauky.Rows(0).Item("TNG"), Mask_0), _
                                Format(rs_dauky.Rows(0).Item("TCL"), Mask_0)), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        
        If Combo(7).Visible Then
            SoDuTKTSCCDC(True)
        End If
        ''rs_dauky.Close()
        rs_dauky = Nothing
        Me.Cursor = Cursors.Default
        'Reset Các biến của công cụ dụng cụ vi không qua thao tác luu ở bảng chứng từ
        ResetDuLieu()
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
            Congcudungcu.NCT = Ngay
        Else
            MedNgay.Focus()
        End If
    End Sub
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(0).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
    End Sub
End Class
