Imports System
Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Media
Imports System.Drawing
Imports System.Diagnostics
Imports UNET.Utility
Imports System.Globalization
Imports System.Windows.Forms
Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter
Imports System.Runtime.InteropServices
Imports System.Threading

Partial Friend Class frmMain
    Dim ret As Boolean
    Dim pProcessEnable As Boolean
    Private Const MaxNamTC As Integer = 9
    Private Const OptLDBLoggedUsers As Integer = &H2S
    
    Private isInitializingComponent As Boolean
    Dim menu_thongke As New uThongKe()
    Dim menu_thongtin As New uThongTin()

    Sub New()
        MyBase.New()
        ' Init components
        isInitializingComponent = True
        InitializeComponent()
        isInitializingComponent = False
        InitializemnuHLP()
        InitializemnuChkGiaVon()
        Initializemnts()
        InitializemnXoa1()
        InitializemnXoa()
        InitializemnVT()
        InitializemnNam()
        InitializemnNV()
        InitializemnMR()
        InitializemnK1()
        InitializemnK()
        InitializemnHT()
        InitializemnCN()
        InitializemnBH()
        Initializehd()
        InitializeOptNN()
        InitializeMNVB()
        InitializeMNDLA()
        InitializeMNDL()
        InitializeLbCty()
        InitializeLb()
        InitializeLabel()
        InitializeFrame()
        InitializeChk()
        InitializeBBBG()
        'set icon
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
        ' This call is required by the Windows Form Designer.
        ' InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        ' them thao tac nhanh
        Dim menu_thaotacnhanh As New uThaoTacNhanh()
        menu_thaotacnhanh.Dock = DockStyle.Fill
        Me.Panel_Right_LamViec.Controls.Clear()
        Me.Panel_Right_LamViec.Controls.Add(menu_thaotacnhanh)

        'them menu vat tu hang hoa
        Dim menu_vattuhanghoa As New uVatTuHangHoa()
        menu_vattuhanghoa.Dock = DockStyle.Fill
        Me.Panel_LamViec.Controls.Clear()
        Me.Panel_LamViec.Controls.Add(menu_vattuhanghoa)

        'them bang thong ke        
        menu_thongke.Dock = DockStyle.Fill
        Me.Panel_contain.Controls.Clear()
        Me.Panel_contain.Controls.Add(menu_thongke)

        ' start licens
        clsActaxlicense.startACTaxLicense()
        ''''
        '' AUTO UPDATE
        ' only load files, etc. when NOT closing to install an update
        If Not AutomaticUpdaterACtax.ClosingForInstall Then
            ' load important files, etc.
            ' LoadFilesEtc()
        End If

    End Sub

    Private Sub Cmd1_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs)

        Try
            Dim Index As Integer = Array.IndexOf(Cmd1, eventSender)
            Select Case Index
                Case 0
                    FrmMNVatTu.ShowDialog()
                Case 1
                    FrmMNTaiSan.ShowDialog()
                Case 2
                    FrmMNCongCu.ShowDialog()
                Case 3
                    FrmMNTongHop.ShowDialog()
                Case 4
                    FrmMNGiaThanh.ShowDialog()
                Case 5
                    If pRpt = CheckState.Checked And User_Right = 1 Then
                        ErrMsg(er_KoSD)
                        Exit Sub
                    End If
                    FrmMNBaocao.ShowDialog()
                Case 6
                    FrmMNCongNo.ShowDialog()
                Case 7
                    FrmMNNhanVien.ShowDialog()
            End Select
            'Me.IsMdiContainer = False
            MemoryHelper.ReleaseMemory()
        Catch ex As Exception

        End Try

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs)
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Select Case Index
            Case 0
                If User_Right = 2 Then
                    NoRight(0)
                    Exit Sub
                End If
                If pSTOP = 1 Then
                    myUMessager.mWarning((pTenCty), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                pPhieu = 0
                FrmChungtu.ShowDialog()
                FrmChungtu = Nothing
            Case 1, 2
                If User_Right = 1 Then
                    NoRight(0)
                    Exit Sub
                End If
                FrmMNBaocao.ShowDialog()
            Case 3
                RunCT()
            Case 4
                If User_Right = 2 Then
                    NoRight(0)
                    Exit Sub
                End If
                pPhieu = 1
                FrmChungtu.ShowDialog()
                FrmChungtu = Nothing
        End Select
        HienThongBao("", 1)
    End Sub
    Sub TinhLaiGiaNgoaiTe()
        Dim i As Integer
        Dim st As String = FrmGetStr.GetString(Ngonngu("Tháng cần tính lại:", "May be re_calculated"), Ngonngu("Tính giá ngoại tệ", "Calculation of exchange"))

        If IsNumeric(st) Then i = ConvertToIntSafe(st)
        If i > 0 And i < 13 Then
            Me.Cursor = Cursors.WaitCursor
            If OutCost = 0 Then TinhGNT(i)
        End If
        HienThongBao("", 1)
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub hd_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _hd_0.Click, _hd_1.Click, _hd_2.Click, _hd_3.Click, _hd_4.Click, _hd_5.Click
        Dim Index As Integer = Array.IndexOf(hd, eventSender)
        Select Case Index
            Case 0
                FrmQuyetdinhapdunghoadontuin.ShowDialog()
            Case 1
                myUMessager.mInformation(Ngonngu("Vui lòng liên hệ với đại lý để nhận được mẫu hoá đơn!", "Please contact the dealer to get invoice form!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                FrmMauhoadon.ShowDialog()
            Case 2
                frmSLHoaDon.ShowDialog()
            Case 3
                FrmThongbaophathanhhoadon.ShowDialog()
            Case 4
                FrmQuanlydudunghoadon.ShowDialog()
            Case 5
                FrmMNBaocaobh.ShowDialog()
        End Select
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub MNDLA_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MNDLA_0.Click, _MNDLA_1.Click, _MNDLA_2.Click, _MNDLA_3.Click, _MNDLA_4.Click, _MNDLA_5.Click, _MNDLA_6.Click, _MNDLA_7.Click, _MNDLA_8.Click, _MNDLA_9.Click, _MNDLA_10.Click, _MNDLA_11.Click, _MNDLA_12.Click, _MNDLA_13.Click, _MNDLA_14.Click, _MNDLA_15.Click, _MNDLA_16.Click
        Dim Index As Integer = Array.IndexOf(MNDLA, eventSender)
        Dim sql As String = String.Empty
        Me.Cursor = Cursors.WaitCursor
        Select Case Index
            Case 0
                If Not STDetail Then
                    NoRight(1)
                    GoTo kt
                End If
                KiemTraVatTu()
            Case 1
                KiemTra142_242DauKy()
                HienThongBao(Ngonngu("Kiểm tra hệ thống tài khoản", "Checking system of accounts"), 1)
                KiemTraTaiKhoan()
            Case 2
                HienThongBao(Ngonngu("Kiểm tra xuất giá vốn", "Cost price Check-up"), 1)
                If KiemTraXuatGV() Then
                    myUMessager.mInformation(Ngonngu("Kiểm tra hoàn tất!", "Testing complete!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case 3
                If FrmPassword.GetPswX() = "MS" Then
                    HienThongBao(Ngonngu("Kiểm tra đối ứng", "Checking Corresponding"), 1)
                    KiemTraDuLieu()
                End If
            Case 5
                Tinhgiaxuatkho()
            Case 6
                TinhLaiGiaNgoaiTe()
            Case 7
                FrmKC.ShowDialog()
            Case 8
                FrmThKC.ShowDialog()
            Case 11
                If FrmPassword.GetPswX() = "MS" Then
                    sql = FrmGetStr.GetString(Ngonngu("Lệnh Xử lý:", "Command processor"), My.Application.Info.ProductName)
                    If sql.Length > 0 Then ExecSQLNonQuery(sql)
                End If
            Case 12
                If KtraMKAdmin() Then
                    '                If FrmGetStr.GetMK(LbCty(8).Caption) Then
                    If myUMessager.mQuestion(String.Format(Ngonngu("Bạn chắc chắn kết thúc năm {0} và chuyển sang năm mới ?", "Are you sure you want to end the year {0} and transferred the new year ?"), pNamTC), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> System.Windows.Forms.DialogResult.Yes Then GoTo kt
                    HienThongBao(Ngonngu("Chuyển số dư cuối kỳ ...  Xin vui lòng chờ !", "Ending balance trasfer... Please wait!"), 1)
                    ChuyenNamMoi()
                    LbCty(7).Text = ConvertToStrSafe(pNamTC)
                    LietKeNam()
                    '                End If
                End If
            Case 13
                If STDetail Then
                    FrmTongHop.ShowDialog()
                Else
                    NoRight(1)
                End If
            Case 14
                LayDuLieuNamTruoc()
            Case 16
                FrmPBCP.ShowDialog()
        End Select
kt:
        HienThongBao("Xong ...", 1)
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub MnuThoat_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MnuThoat.Click
        If (myUMessager.mQuestion(Ngonngu("Bạn có muốn thoát chương trình kế toán ACTax?", "Do you want exit application?"), Application.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub MNVB_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MNVB_0.Click, _MNVB_1.Click, _MNVB_2.Click, _MNVB_3.Click, _MNVB_4.Click
        Dim Index As Integer = Array.IndexOf(MNVB, eventSender)
        Select Case Index
            Case 0 : Openword("Vanban\qd15_btc.doc")
            Case 1 : Openword("Vanban\qd48_btc.doc")
            Case 2 : Openword("Vanban\tt60_btc.doc")
            Case 3 : Openword("Vanban\tt129_btc.doc")
            Case 4 : Openword("Vanban\tt130_btc.doc")
        End Select
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub mnXoa_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mnXoa_0.Click, _mnXoa_1.Click, _mnXoa_2.Click, _mnXoa_3.Click, _mnXoa_4.Click, _mnXoa_5.Click, _mnXoa_6.Click, _mnXoa_7.Click, _mnXoa_8.Click, _mnXoa_9.Click, _mnXoa_10.Click, _mnXoa_11.Click, _mnXoa_12.Click
        If User_Right <> 0 Then
            NoRight(0)
            Exit Sub
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Tinhgiaxuatkho()
        Dim st, TK As String
        Dim j, i, k As Integer
        Dim mv As Integer
        If OutCost <> 2 Then
            GetMonth.GetMonth("Tháng cần tính lại :", i, j)
            For k = i To j
                If ConvertToDblSafe(GetSelectValue(String.Format("SELECT lock{0} as f1 FROM license", k))) = 1 Then
                    If FrmPassword.GetPswX("Dữ liệu đã bị khoá. Nhập mật khẩu ...") <> "MS" Then
                        GoTo kt
                    Else
                        GoTo Tiep
                    End If
                End If
            Next
        End If
Tiep:
        Dim r As Integer
        Dim MaSo As Integer
        Dim nvl1, sl1, nc1, sxc1 As Double
        Dim rs As DataTable
        Dim nvl, sl, nC, sxc, no, co As Double
        Dim MaVattu As String = String.Empty
        Dim MaCT, ma1541, ma155, MaSoCT As Integer
        If i > 0 And i < 13 And j > 0 And j < 13 Then
            st = ""
            st = FrmGetStr.GetString(Ngonngu("Số hiệu vật tư cần tính lại (để trống nếu tính lại toàn bộ):", "Code of materials to be calculated (Blank if the entire):"), Ngonngu("Tính giá xuất kho", "Calculation of inventory"))
            Do While st.Length > 0
                mv = SoHieu2MaSo(st, "Vattu")
                If mv > 0 Then Exit Do
                st = FrmGetStr.GetString(Ngonngu("Số hiệu vật tư cần tính lại (để trống nếu tính lại toàn bộ):", "Code of materials to be calculated (Blank if the entire):"), Ngonngu("Tính giá xuất kho", "Calculation of inventory"))
            Loop
            TK = IIf(OutCost <> 2, FrmGetStr.GetString("Số hiệu tài khoản ghi nợ khi xuất kho cần tính lại (để trống nếu tính lại toàn bộ):", "Tính giá xuất kho", String.Empty), String.Empty)
            Me.Cursor = Cursors.WaitCursor
            If OutCost = 1 Then TinhGVBH(NgayDauThang(pNamTC, pThangDauKy), NgayCuoiNam(), 1, mv)
            If OutCost = 2 Then TinhGXKFIFO(i, j, st, TK)
            If OutCost = 0 Then
                k = ConvertToIntSafe(FrmGetStr.GetString(Ngonngu("Nhập số 1 để tính bình quân di động, số 2 để tính bình quân cuối kỳ ", "1 to enter the mobile average,2 to calculate the average final"), Ngonngu("Tính giá xuất kho", "Calculation of inventory")))
                If k < 1 Or k > 2 Then GoTo kt
thang:
                If i + r > j Then GoTo kt
                HienThongBao(String.Format(Ngonngu("Tính giá xuất kho tháng {0}{1} ...", "Month of inventory pricing {0}{1} ..."), i, r), 1)
                If k = 1 Then TinhGXK(i + r, i + r, st, TK)
                If k = 2 Then TinhGXKBQ(i + r, i + r, st, TK)
                r += 1
            End If
            ma1541 = ConvertToDblSafe(Timten("maso", "1541", "sohieu", "hethongtk"))
            ma155 = ConvertToDblSafe(Timten("maso", "155", "sohieu", "hethongtk"))
            no = LayCdt(True, i, j, 2, co)
            '********** Tính dở dang cuối kỳ  cộng vào có *********************
            rs = ExecSQLReturnDT("SELECT vt.maso,vt.sohieu,vt.tenvattu,tk.masokho FROM (vattu vt inner join dinhmuc dm on vt.maso=dm.matp)inner join tonkho tk on vt.maso=tk.mavattu group by vt.maso,vt.sohieu,vt.tenvattu,tk.masokho")
            For Each rsItem As DataRow In rs.Rows
                sl = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(SoLuong) as f1,sum(CPNC) as f2,sum(CPSXC) as f3,sum(CPNVL) as f4 FROM thanhphamdd WHERE matp={0} and makhonvl={1} and thang=(SELECT max(thang) FROM thanhphamdd WHERE matp={0} and thang<{2} and makhonvl={1}) group by thang", _
                                                                        rsItem("MaSo"), _
                                                                        rsItem("MaSoKho"), _
                                                                        i), nC, sxc, nvl))
                sl1 = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(SoLuong) as f1,sum(CPNC) as f2,sum(CPSXC) as f3,sum(CPNVL) as f4 FROM thanhphamdd WHERE matp={0} and makhonvl={1} and thang={2}", _
                                                          rsItem("MaSo"), _
                                                          rsItem("MaSoKho"), _
                                                          ConvertToStrSafe(i)), nc1, sxc1, nvl1))
                If sl1 <> 0 Then
                    co += nvl1
                Else
                    MaSo = ConvertToIntSafe(GetSelectValue(String.Format("SELECT maso as f1 FROM thanhphamdd WHERE matp={0} and makhonvl={1} and thang={2}", _
                                                               rsItem("MaSo"), _
                                                               rsItem("MaSoKho"), _
                                                               i)))
                    If sl <> 0 And MaSo = 0 Then co += nvl
                End If
            Next
            '********** Trừ có và dở dang cuối kỳ ********************************
            no -= co
            If no <> 0 Then
                ExecSQLNonQuery(String.Format("UPDATE chungtu set sops=[sops]+{0} WHERE sohieu like 'KCTP-%' and thangct={1} and matkco={2} and sops>=all(SELECT sops FROM chungtu WHERE sohieu like 'KCTP-%' and thangct={1} and matkco={2})", _
                                    no, _
                                    ConvertToStrSafe(j), _
                                    ConvertToStrSafe(ma1541)))
                MaCT = ConvertToIntSafe(GetSelectValue(String.Format("SELECT mact as f1,maso as f2,mavattu as f3 FROM chungtu WHERE sohieu like 'KCTP-%' and thangct={0} and matkco={1} and sops>=all(SELECT sops FROM chungtu WHERE sohieu like 'KCTP-%' and thangct={2} and matkco={1})", _
                                                           j, _
                                                           ConvertToStrSafe(ma1541), _
                                                           ConvertToStrSafe(j)), MaSoCT, MaVattu))
                ExecSQLNonQuery(String.Format("UPDATE chungtu set sops=[sops]+{0} WHERE maso<>{1} and mact={2} and sohieu like 'KCTP-%' and thangct={3} and matkno={4} and sops>=all(SELECT sops FROM chungtu WHERE maso<>{1} and mact={2} and sohieu like 'KCTP-%' and thangct={3} and matkno={4})", _
                                    no, _
                                    ConvertToStrSafe(MaSoCT), _
                                    ConvertToStrSafe(MaCT), _
                                    ConvertToStrSafe(j), _
                                    ConvertToStrSafe(ma155)))
                If ConvertToDblSafe(MaVattu) = 0 Then MaVattu = ConvertToStrSafe(GetSelectValue(String.Format("SELECT mavattu as f1 FROM chungtu WHERE maso<>{0} and mact={1} and sohieu like 'KCTP-%' and thangct={2} and matkno={3} and sops>=all(SELECT sops FROM chungtu WHERE maso<>{4} and mact={1} and sohieu like 'KCTP-%' and thangct={2} and matkno={3})", _
                                                                                                    MaSoCT, _
                                                                                                    ConvertToStrSafe(MaCT), _
                                                                                                    ConvertToStrSafe(j), _
                                                                                                    ConvertToStrSafe(ma155), _
                                                                                                    ConvertToStrSafe(MaSoCT))))
                ExecSQLNonQuery(String.Format("UPDATE chungtu set sops=[sops]+{0} WHERE sohieu like '%GV' and thangct={1} and matkco={2} and mavattu={3} and sops>=all(SELECT sops FROM chungtu WHERE sohieu like '%GV' and thangct={1} and mavattu={3} and matkco={2})", _
                                    no, _
                                    ConvertToStrSafe(j), _
                                    ConvertToStrSafe(ma155), _
                                    MaVattu))
            End If
            If OutCost = 0 Then GoTo thang
        End If
kt:
        HienThongBao("", 1)
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CTTimer_Tick(ByVal eventSender As Object, ByVal eventArgs As EventArgs)
        If pProcessEnable Then
            pProcessEnable = False
            XuLyChungtu()
            pProcessEnable = True
        End If
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SetQuyen()
        Cmd1(0).Enabled = KiemtraUser(1)
        Cmd1(1).Enabled = KiemtraUser(4)
        Cmd1(2).Enabled = KiemtraUser(5)
        Cmd1(3).Enabled = KiemtraUser(2)
        Cmd1(4).Enabled = KiemtraUser(7) And (Chk(1).CheckState = CheckState.Checked Or Chk(3).CheckState = CheckState.Checked)
        Cmd1(5).Enabled = KiemtraUser(8)
        Cmd1(6).Enabled = KiemtraUser(3)
        Cmd1(7).Enabled = KiemtraUser(6)
        Cmd1(8).Enabled = KiemtraUser(6)
    End Sub

    Public Sub SetQuyen1()
        'frmMain.TV_Menu1.Enabled = KiemtraUser(1)

        ''menu
        'frmMain.VatTuHangHoa.Enabled = KiemtraUser(1)
        'frmMain.ChiPhiTongHop.Enabled = KiemtraUser(2)
        'frmMain.CongNo.Enabled = KiemtraUser(3)
        'frmMain.TaiSanCoDinh.Enabled = KiemtraUser(4)
        'frmMain.Congcudungcu_ChiPhi.Enabled = KiemtraUser(5)
        'frmMain.Nhansu_TienLuong.Enabled = KiemtraUser(6)
        'frmMain.LaoDong_BHXH.Enabled = KiemtraUser(6)
        'frmMain.GiaThanh.Enabled = KiemtraUser(7)
        'frmMain.BC.Enabled = KiemtraUser(8)
        'frmMain.HoaDonTuIn.Enabled = KiemtraUser(9)

        'giao dien
        'frmMain.vat_tu_hang_hoa.Enabled = KiemtraUser(1)
        'frmMain.chi_phi_tong_hop.Enabled = KiemtraUser(2)
        'frmMain.cong_no.Enabled = KiemtraUser(3)
        'frmMain.tai_san_co_dinh.Enabled = KiemtraUser(4)
        'frmMain.cong_cu_dung_cu.Enabled = KiemtraUser(5)
        'frmMain.nhan_su_tien_luong.Enabled = KiemtraUser(6)
        'frmMain.lao_dong_bao_hiem.Enabled = KiemtraUser(6)
        'frmMain.gia_thanh_sx.Enabled = KiemtraUser(7)
        'frmMain.so_bao_cao.Enabled = KiemtraUser(8)
        'frmMain.hoa_don_tu_in.Enabled = KiemtraUser(9)

        'frmMain.vat_tu_hang_hoa_1.Enabled = KiemtraUser(1)
        'frmMain.vat_tu_hang_hoa_2.Enabled = KiemtraUser(1)
        'frmMain.chi_phi_tong_hop_1.Enabled = KiemtraUser(2)
        'frmMain.chi_phi_tong_hop_2.Enabled = KiemtraUser(2)
        'frmMain.cong_no_1.Enabled = KiemtraUser(3)
        'frmMain.cong_no_2.Enabled = KiemtraUser(3)
        'frmMain.tai_san_co_dinh_1.Enabled = KiemtraUser(4)
        'frmMain.tai_san_co_dinh_2.Enabled = KiemtraUser(4)
        'frmMain.cong_cu_dung_cu_1.Enabled = KiemtraUser(5)
        'frmMain.cong_cu_dung_cu_2.Enabled = KiemtraUser(5)
        'frmMain.nhan_su_tien_luong_1.Enabled = KiemtraUser(6)
        'frmMain.nhan_su_tien_luong_2.Enabled = KiemtraUser(6)
        'frmMain.lao_dong_bao_hiem_1.Enabled = KiemtraUser(6)
        'frmMain.lao_dong_bao_hiem_2.Enabled = KiemtraUser(6)
        'frmMain.gia_thanh_sx_1.Enabled = KiemtraUser(7)
        'frmMain.gia_thanh_sx_2.Enabled = KiemtraUser(7)
        'frmMain.so_bao_cao_1.Enabled = KiemtraUser(8)
        'frmMain.so_bao_cao_2.Enabled = KiemtraUser(8)
        'frmMain.hoa_don_tu_in_1.Enabled = KiemtraUser(9)
        'frmMain.hoa_don_tu_in_2.Enabled = KiemtraUser(9)

    End Sub

    Private Sub frmMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If (myUMessager.mQuestion(Ngonngu("Bạn có muốn thoát chương trình kế toán ACTax?", "Do you want exit application?"), Application.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Environment.Exit(0)
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub frmMain_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.N
                    Command(0).Focus()
                    ' Command_Click(Command(0), New EventArgs())
                Case Keys.C
                    Command(1).Focus()
                    'Command_Click(Command(1), New EventArgs())
                Case Keys.T
                    Command(2).Focus()
                    ' Command_Click(Command(2), New EventArgs())
            End Select
        End If
        If (Shift And 2) > 0 And eventArgs.KeyCode = Keys.Q Then
            XoaQuery()
        End If
        If (Shift And 2) > 0 And eventArgs.KeyCode = Keys.D Then
            Directory.SetCurrentDirectory(pCurDir & "DATA")
            Recycle(String.Format("K*_{0}.SAS", ConvertToStrSafe(LbCty(0).Tag)))
        End If
        If (Shift And 2) > 0 And eventArgs.KeyCode = Keys.F Then
            pKhongDau = 1 - pKhongDau
            SetFont(Me)
        End If
        If (Shift And 4) > 0 And (Shift And 2) > 0 And eventArgs.KeyCode = Keys.R Then
            If myUMessager.mQuestion(Ngonngu("Xoá tất cả liên kết?", "Delete all relations"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then DeleteRel()
        End If
        'If (Shift And 2) > 0 And Graphics.FromImage(Img.Image).GetHdc().ToInt32() <> 0 And pVersion = 1 Then
        '    SELECT Case  eventArgs.KeyCode
        '        Case Keys.Left : Img.Left -= 10
        '        Case Keys.Right : Img.Left += 10
        '        Case Keys.Up : Img.Top -= 10
        '        Case Keys.Down : Img.Top += 10
        '    End SELECT
        'End If
        'If (Shift And 1) > 0 And Graphics.FromImage(Img.Image).GetHdc().ToInt32() <> 0 And pVersion = 1 Then
        '    SELECT Case  eventArgs.KeyCode
        '        Case Keys.Left : Img.Width -= 10
        '        Case Keys.Right : Img.Width += 10
        '        Case Keys.Up : Img.Height -= 10
        '        Case Keys.Down : Img.Height += 10
        '    End SELECT
        'End If
        If (Shift And 4) > 0 And eventArgs.KeyCode = Keys.M Then
            'SetPsw(pDataPath, pPSW, "mi9032425su")
            'WSpace.Close()
            Environment.Exit(0)
        End If
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub InitForm()
        StationList()
        'Zip.Top = sbStatusBar.Top + 30
        Text = My.Application.Info.Title
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        StationList()
        'Zip.Top = sbStatusBar.Top + 30
        Text = My.Application.Info.Title
    End Sub


    Public Function checkExitform(ByVal name As String) As Boolean
        Dim check As Boolean = False
        For Each frm As Form In Me.MdiChildren
            If frm.Name = name Then
                check = True
                Exit For
            End If
        Next
        Return check
    End Function

    Public Sub ActiveChildrenForm(ByVal name As String)
        Dim check As Boolean = False
        For Each frm As Form In Me.MdiChildren
            If frm.Name = name Then
                frm.Activate()
                Exit For
            End If
        Next

    End Sub
    Private Sub ReloadMainForm()
        Me.Cursor = Cursors.WaitCursor
        Try
            If pVersion = 2 Then
                Label(19).Visible = False
            End If
            'infor database
            _ComputerName.Text = My.Computer.Name
            _DatabaseName.Text = SQLSERVERConnection.ConnectStringControls.Database
            _ServerName.Text = SQLSERVERConnection.ConnectStringControls.DataSource
            'end infor
            'infor username login
            _Username.Text = ClsUser.TenNSD
            SetUserRight()
            'end infor userlogin

            'init Information
            Me.mnhh.Visible = False
            Me.mnuHelp.Visible = False
            'end init

            HienThongBao(pDataPath, 2)
            KiemTraDuLieu()
            GetLicense()
            LietKeTep()

            Select Case pProcessMode
                Case 2 : pProcessEnable = True
                    Me.Text = String.Format("{0} - SERVER Application", Me.Text)
                    CTTimer.Enabled = True
                Case 1 : pProcessEnable = False
                    Me.Text = String.Format("{0} - CLIENT Application", Me.Text)
            End Select
            Mask_D = GetShortDateFormat()

            'reload bang thong ke 
            menu_thongke = New uThongKe()
            menu_thongke.Dock = DockStyle.Fill
            Me.Panel_contain.Controls.Clear()
            Me.Panel_contain.Controls.Add(menu_thongke)

            Me.Cursor = Cursors.Default
            MemoryHelper.ReleaseMemory()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MemoryHelper.ReleaseMemory()
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmMain_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Try
            'license
            'Dim dl = New DateTime(2019, 6, 15)

            'If DateTime.Now > dl Then
            '    myUMessager.mError("Bạn liên hệ 0987 939 605 để biết thêm thông tin, cảm ơn bạn.", "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Application.Exit()
            'End If

            If pVersion = 2 Then
                Label(19).Visible = False
            End If
            'infor database
            _ComputerName.Text = My.Computer.Name
            _DatabaseName.Text = SQLSERVERConnection.ConnectStringControls.Database
            _ServerName.Text = SQLSERVERConnection.ConnectStringControls.DataSource
            'end infor
            'infor username login
            _Username.Text = ClsUser.TenNSD
            SetUserRight()
            'end infor userlogin

            'init Information
            Me.mnhh.Visible = False
            Me.mnuHelp.Visible = False
            'end init

            HienThongBao(pDataPath, 2)
            GetLicense()
            LietKeTep()
            'kiem tra ngay thang
            Try
                If setMDSettings() = False Then
                    myUMessager.mError("Bạn cần thay đổi hệ thống ngày định dạng Việt Nam" & vbNewLine & "hệ thống ngày tháng cần 'dd/MM/yy' (ví dụ : " & IIf(Date.Now.Day.ToString.Length = 1, "0" & Date.Now.Day.ToString, Date.Now.Day.ToString) & "/" & IIf(Date.Now.Month.ToString.Length = 1, "0" & Date.Now.Month.ToString, Date.Now.Month.ToString) & "/" & Date.Now.Year.ToString.Substring(2, 2) & ")" & vbNewLine & "có thể ảnh hưởng tới dữ liệu chương trình.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception

            End Try
            'het kiem tra ngay thang
            Select Case pProcessMode
                Case 2 : pProcessEnable = True
                    Me.Text = String.Format("{0} - SERVER Application", Me.Text)
                    CTTimer.Enabled = True
                Case 1 : pProcessEnable = False
                    Me.Text = String.Format("{0} - CLIENT Application", Me.Text)
            End Select
            Mask_D = GetShortDateFormat()

            Me.Cursor = Cursors.Default
            MemoryHelper.ReleaseMemory()
            Me.Activate()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MemoryHelper.ReleaseMemory()
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub frmMain_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        Me.Cursor = Cursors.WaitCursor
        HienThongBao("Kết thúc chương trình kế toán!", 1)
        ApplicationCloseUp()
        Me.Cursor = Cursors.Default
        Environment.Exit(0)
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub mnBH_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mnBH_0.Click, _mnBH_1.Click, _mnBH_2.Click, _mnBH_3.Click, _mnBH_4.Click, _mnBH_5.Click, _mnBH_6.Click
        Dim Index As Integer = Array.IndexOf(mnBH, eventSender)
        Select Case Index

        End Select
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub mnCN_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mnCN_0.Click, _mnCN_1.Click, _mnCN_2.Click, _mnCN_3.Click, _mnCN_4.Click, _mnCN_5.Click, _mnCN_6.Click, _mnCN_7.Click, _mnCN_8.Click, _mnCN_9.Click, _mnCN_10.Click, _mnCN_11.Click, _mnCN_12.Click

        Try
            Dim Index As Integer = Array.IndexOf(mnCN, eventSender)
            If Index = 3 Or Index = 9 Then
                If Not KtraMKAdmin() Then Exit Sub
            End If
            Select Case Index
                Case 0
                    frmPhanLoaiVT.pl1 = "2"
                    frmPhanLoaiVT.ShowDialog()
                    frmPhanLoaiVT.pl1 = "0"
                Case 1
                    FrmKhachHang.ShowDialog()
                Case 3
                    If ChoDieuChinhDauKy() Then
                        If pCongNoHD = 0 Then
                            FKHDauKy.ShowDialog()
                        Else
                            FKHDauKy2.ShowDialog()
                        End If
                    End If
                Case 4
                    TinhLaiGiaNgoaiTe()
                Case 5
                    FrmHD.ShowDialog()
                Case 7
                    frmPhanLoaiVT.pl1 = "4"
                    frmPhanLoaiVT.ShowDialog()
                    frmPhanLoaiVT.pl1 = "0"
                Case 8
                    FrmNhanVien.ShowDialog()
                Case 10
                    If KtraMKAdmin() Then
                        FrmLS.ShowDialog()
                        'FrmCantrucongno.ShowDialog()
                    End If
                Case 12
                    If KtraMKAdmin() Then DatTKCN()
            End Select
            HienThongBao("", 1)
        Catch ex As Exception

        End Try

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub MNDL_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MNDL_0.Click, _MNDL_1.Click, _MNDL_2.Click, _MNDL_3.Click, _MNDL_4.Click, _MNDL_5.Click, _MNDL_6.Click, _MNDL_7.Click, _MNDL_9.Click, _MNDL_10.Click, _MNDL_11.Click, _MNDL_12.Click, _MNDL_13.Click, _MNDL_14.Click, _MNDL_15.Click, _MNDL_16.Click, _MNDL_17.Click, _MNDL_18.Click, _MNDL_19.Click, _MNDL_20.Click, _MNDL_21.Click, _MNDL_22.Click
        Dim sql As String = String.Empty
        Dim Index As Integer = Array.IndexOf(MNDL, eventSender)
        Me.Cursor = Cursors.WaitCursor
        Select Case Index
            Case 0
                If Not STDetail Then
                    NoRight(1)
                    GoTo kt
                End If
                KiemTraVatTu()
                Exit Select
            Case 1
                KiemTraTaiKhoan()
                Exit Select
            Case 3
                If FrmPassword.GetPswX() = "MS" Then
                    sql = FrmGetStr.GetString(Ngonngu("Lệnh xử lý:", "Command processor:"), My.Application.Info.ProductName)
                    If sql.Length > 0 Then ExecSQLNonQuery(sql)
                End If
                Exit Select
            Case 6
                If KtraMKAdmin() Then
                    If myUMessager.mQuestion(String.Format("Bạn chắc chắn kết thúc năm {0} và chuyển sang năm mới ?", pNamTC), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> System.Windows.Forms.DialogResult.Yes Then GoTo kt
                    HienThongBao("Chuyển số dư cuối kỳ ...  Xin vui lòng chờ !", 1)
                    ChuyenNamMoi()
                    LbCty(7).Text = ConvertToStrSafe(pNamTC)
                    LietKeNam()
                End If
                Exit Select
            Case 9
                FrmKC.ShowDialog()
                Exit Select
            Case 10
                FrmPBCP.ShowDialog()
            Case 11
                FrmThKC.ShowDialog()
                Exit Select
            Case 14
                FrmCTGS.ShowDialog()
                Exit Select
            Case 16
                sql = Interaction.GetSetting(IniPath, "LastYear", String.Format("IncTax{0}", pNamTC), "0")
                sql = Interaction.InputBox("Số điều chỉnh", _
                          String.Format("Thuế thu nhập doanh nghiệp {0}", (pNamTC - 1)), _
                          sql)
                ' Dim dbNumericTemp As Double
                If IsNumeric(sql) Then
                    Interaction.SaveSetting(IniPath, "LastYear", String.Format("IncTax{0}", pNamTC), sql)
                End If
                Exit Select
            Case 17
                LayDuLieuNamTruoc()
                Exit Select
            Case 19
                If KtraMKAdmin() Then
                    FrmE.ShowDialog()
                End If
                Exit Select
            Case 21
                If KtraMKAdmin() Then
                    sql = FrmDB.ChonTepLuu(Me.LbCty(8).Text, pNamTC)
                    If sql.Length > 0 Then
                        ApplicationCloseUp(1)
                    End If
                End If
                Exit Select
            Case 22
                KiemTraDuLieu()
                Exit Select
        End Select
kt:
        HienThongBao("Xong ...", 1)
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    'Public Sub ConnectionControl(Optional ByVal MustSelectDatabase As Boolean = True)
    '    ' Get default connection 
    '    Dim currentConnectionOK As Boolean = False
    '    While Not currentConnectionOK
    '        Dim ConnectionHlpr As New ConnectionHelper()
    '        ' Check default connection 
    '        currentConnectionOK = ConnectionHelper.CheckConnection(ConnectionHlpr.DataSource, ConnectionHlpr.Database, ConnectionHlpr.UserID, ConnectionHlpr.Password)

    '        If (Not currentConnectionOK) OrElse MustSelectDatabase Then
    '            If ConnectSQLSetting() = Windows.Forms.DialogResult.OK Then
    '                Call showRegisterCompany()
    '                Continue While
    '            End If
    '        Else
    '            Call showRegisterCompany()
    '        End If
    '        currentConnectionOK = True
    '    End While
    'End Sub
    ''' <summary>
    ''' Import license FROM SQL
    ''' </summary>
    ''' <remarks></remarks>
    'Public Function ConnectSQLSetting() As Windows.Forms.DialogResult

    '    Dim DialogResult As Windows.Forms.DialogResult
    '    Using iSQL_ConnectionDlg As New frmSqlConnection()
    '        iSQL_ConnectionDlg.SetTitle("Thiết lập kết nối CSDL")
    '        Dim ConnectionHlpr As New ConnectionHelper()
    '        iSQL_ConnectionDlg.Init(ConnectionHlpr.DataSource, ConnectionHlpr.IntegratedSecurity, ConnectionHlpr.UserID, ConnectionHlpr.Password, ConnectionHlpr.Database)
    '        DialogResult = iSQL_ConnectionDlg.ShowDialog
    '        If DialogResult <> Windows.Forms.DialogResult.Cancel Then
    '            If String.IsNullOrEmpty(iSQL_ConnectionDlg.ConnectionString) Then
    '                ' ShowConnectFailure()
    '            Else
    '                ConfigHelper.Save_DefaultDBConnectionSt(iSQL_ConnectionDlg.ConnectionString)
    '            End If
    '        End If
    '        Return DialogResult
    '    End Using
    '    GC.Collect()
    'End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub showRegisterCompany()
        Dim companyName As String = String.Empty
        Try

        Catch ex As Exception

        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub mnHT_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mnHT_0.Click, _mnHT_1.Click, _mnHT_2.Click, _mnHT_3.Click, _mnHT_4.Click, _mnHT_5.Click, _mnHT_6.Click, _mnHT_7.Click, _mnHT_8.Click, _mnHT_9.Click, _mnHT_10.Click, _mnHT_11.Click, _mnHT_12.Click, _mnHT_13.Click, _mnHT_14.Click, _mnHT_15.Click, _mnHT_16.Click, _mnHT_17.Click, _mnHT_18.Click, _mnHT_19.Click, _mnHT_20.Click, _mnHT_21.Click, _mnHT_22.Click, _mnHT_23.Click, _mnHT_24.Click, _mnHT_25.Click
        Try
            Dim Index As Integer = Array.IndexOf(mnHT, eventSender)
            Dim psw As String = String.Empty
            Dim fn As String = String.Empty

            If Index = 5 Or Index = 6 Or Index = 10 Then
                If Not KtraMKAdmin() Then Exit Sub
            End If
            Me.Cursor = Cursors.WaitCursor
            Dim dem, kt As Integer
            Dim sql As String = String.Empty
            Select Case Index
                Case 0 ' Mo tep
                    If (FrmSQLConnect.ShowDialog() <> Windows.Forms.DialogResult.OK) Then
                        Environment.Exit(0)
                    Else
                        Using loginFormDlg As New FrmLogin
                            loginFormDlg.ShowDialog()
                            If loginFormDlg.DialogResult = Windows.Forms.DialogResult.OK Then
                                ReloadMainForm()
                            Else
                                Environment.Exit(0)
                            End If
                        End Using
                        MemoryHelper.ReleaseMemory()
                    End If
                Case 1 ' xoa du lieu
                    FrmDeleteData.ShowDialog()
                    Exit Select
                Case 2 ' Tep mac dinh

                    Exit Select
                Case 3 ' Sao lưu dữ liệu
                    If (Sao_Luu_Du_Lieu(Environment.CurrentDirectory)) Then
                        myUMessager.mInformation(Ngonngu("Sao lưu dữ liệu thành công.", "Backup database complete."), Ngonngu("Sao lưu dữ liệu", "Backup database"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    Exit Select
                Case 4
                    ''psw = ChonTenTep("Chọn tệp dữ liệu nén", &H4, "*.SAS", 1)
                    ''If psw.Length = 0 Then GoTo kt
                    ''fn = ChonTenTep("Chọn tên tệp dữ liệu", &H4, "*.MDB", 2)
                    ''If fn.Length = 0 Then GoTo kt
                    ''GianTepNen(psw, fn)
                    ''CloseUp(1)
                    ' ''OpenDB(fn, 1)
                    ''GetLicense()
                    ''FrmMatkhau.ShowDialog()
                    ''FrmMatkhau = Nothing
                    ''SetUserRight()
                    Exit Select
                Case 5 ' đăng ký máy in
                    '******************************** Đặt máy in ******************************
                    Dim registerPrinter As New PrintDialog
                    registerPrinter.UseEXDialog = True
                    registerPrinter.ShowDialog()
                    Exit Select
                Case 7
                    FrmTaikhoan.Tag = "1"
                    FrmTaikhoan.ShowDialog()
                    Exit Select
                Case 9 ' Thong so đăng ký sử dụng
                    If User_Right = 0 Then
                        FrmOptions.ShowDialog()
                        GetLicense()
                    Else
                        NoRight(0)
                    End If
                    Exit Select
                Case 11 ' Danh sach user
                    If User_Right = 0 Then
                        FrmUser3.ShowDialog()
                    Else
                        NoRight(0)
                    End If
                    Exit Select
                Case 12 ' Dat mat khau
                    FrmMatkhau.Tag = "1"
                    FrmMatkhau.ShowDialog()
                    Exit Select
                Case 14
                    If FrmPassword.GetPswX() <> "MS" Then GoTo Xong
                    While Not FrmGetStr.GetMK(LbCty(8).Text, kt)
                        If kt = 1 Then GoTo Xong
                        dem += 1
                        If dem = 3 Then GoTo SaiMK
                    End While
                    CreateSLHoaDonTable()
                    SuaSLHoaDon()
                    CreateNhatkyTable()
                    '****************************** Lương ***************************************************************
                    Luongcan()
                    '****************************** Nhân viên ***********************************************************
                    Nhanviencan()
                    '****************************** Công cụ dụng cụ ***************************************************
                    Congcucan()
                    '**************************** Thuyết minh báo cáo tài chính **************************************
                    UpdateCSDL()
                    CreateDLNamTruocTable()
                    '***************************** Định mức vật tư *****************************************************
                    UpdateDinhmuc()
                    '****************************** Thành Phẩm ********************************************************
                    UpdateThanhpham()
                    CreateThanhphamDD()
                    UpdateBaoCaoCP2Table()
                    '****************************** Bảo hiểm xã hội, y tế thất nghiệp ********************************
                    BaoHiemCan()
                    '******************************************************************************************************
                    CreateBienbanbangiaoTable()
                    UpdateDoiTuongCTTable()
                    UpdateMaTC()
                    UpdateHethongtaikhoan()
                    '******************************************************************************************************
                    'OpenDB(pDataPath)
                    cuongCapnhatCSDL = 1
                    myUMessager.mInformation(Ngonngu("Cập nhật cơ sở dữ liệu thành công", "Update database successful"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GoTo kt
SaiMK:
                    If Not BangDaCo("ChungTu") Then
                        GoTo Loi
                    End If
                    If BangDaCo("ChungTuLuu") Then
                        ExecSQLNonQuery("DROP TABLE ChungTuLuu")
                    End If
                    Try
                        ExecSQLNonQuery("SP_RENAME 'ChungTu' ,'ChungTuLuu'")
                    Catch
                    End Try
Loi:
                    myUMessager.mError(String.Format("Hệ thống bị hỏng.{0}Vui lòng liên hệ với người cài đặt!{0}Để tìm cách giải quyết!", Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    GoTo kt
Xong:
                    myUMessager.mInformation(Ngonngu("Không cập nhật cơ sở dữ liệu", "Not update database"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 15
                    CapnhatCSDL()
                Case 16
                    sql = Me.ChonTenTep(Ngonngu("Chọn tệp dữ liệu mẫu (Lưu ý cần chạy kiểm tra số liệu trước khi thực hiện thao tác này)", "Selected form data file (Note: to check the data before performing this operation)"), &H4, "*.MDB", 1)
                    If sql.Length = 0 Then
                        HienThongBao(Ngonngu("Không chọn tệp dữ liệu mẫu !", "Not selected form data file !"), 1) : GoTo kt
                    End If
                    CopyTable(sql, "CDTS2004")
                    CopyTable(sql, "KQKD")
                    CopyTable(sql, "LCTT")
                    CopyTable(sql, "KQKDCT")
                    CopyTable(sql, "LoaiHoaDon")
                    CopyTable(sql, "Thongsoluong")
                    CopyTable(sql, "ttemp")
                    Exit Select
                Case 18 To 22
                    psw = mnHT(Index).Text
                    ''GoTo MoTep
                    Exit Select
                Case 24
                    FrmMatkhau.ShowDialog()
                    SetUserRight()
                    Exit Select
                Case 25
                    'If (myUMessager.mQuestion(Ngonngu("Bạn có muốn thoát chương trình kế toán ACTax?", "Do you want exit application?"), Application.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                    Me.Close()
                    'Exit Sub
                    'End If
            End Select
kt:
            HienThongBao("", 1)
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
    Public Sub mnK_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mnK_0.Click, _mnK_1.Click, _mnK_2.Click, _mnK_3.Click, _mnK_4.Click, _mnK_5.Click, _mnK_6.Click, _mnK_7.Click, _mnK_8.Click, _mnK_9.Click, _mnK_10.Click, _mnK_11.Click, _mnK_12.Click
        Dim Index As Integer = Array.IndexOf(mnK, eventSender)
        If User_Right <> 0 Then
            NoRight(0)
            Exit Sub
        End If
        Dim k As Integer = ConvertToIntSafe(GetSelectValue(String.Format("SELECT Lock{0} % 10 AS F1 FROM License", mnK(Index).Tag)))
        If myUMessager.mQuestion(String.Format("Cần {0}{1} ?", _
                                                   IIf(k = 0, "khoá", "cho nhập"), _
                                                   IIf(ConvertToDblSafe(mnK(Index).Tag) > 0, _
                                                   String.Format(" phát sinh tháng {0}", mnK(Index).Tag), _
                                                   " số dư đầu năm")), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> System.Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If
        If k <> 0 Then
            If FrmPassword.GetPswX("Dữ liệu đã bị khoá. Nhập mật khẩu ...") <> "MS" Then
                Exit Sub
            End If
        End If
        ExecSQLNonQuery(String.Format("UPDATE License SET Lock{0}=10*(Lock{0} % 10)+{1}", _
                            mnK(Index).Tag, _
                            1 - k))
        mnK(Index).Text = IIf(1 - k > 0, _
                              String.Format("{0}          x", mnK(Index).Text.Trim()), _
                              Strings.Left(mnK(Index).Text, Strings.Len(mnK(Index).Text) - 1))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub mnNam_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mnNam_0.Click, _mnNam_1.Click, _mnNam_2.Click, _mnNam_3.Click, _mnNam_4.Click, _mnNam_5.Click, _mnNam_6.Click, _mnNam_7.Click, _mnNam_8.Click, _mnNam_9.Click
        Dim Index As Integer = Array.IndexOf(mnNam, eventSender)
        Dim path As String = String.Empty
        Me.Cursor = Cursors.WaitCursor
        ApplicationCloseUp(1)
        If Index = 4 Then
            path = Interaction.GetSetting(IniPath, "Environment", "Path", String.Format("{0}DATA\NB.mdf", pCurDir))
        Else
            path = Interaction.GetSetting(IniPath, "LastYear", mnNam(Index).Text, String.Format("{0}DATA\NB.mdf", pCurDir))
        End If
        ''If OpenDB(path) <> 0 Then mnHT_Click(mnHT(0), New EventArgs())
        For i As Integer = 0 To 4
            mnNam(i).Checked = (i = Index)
        Next
        pNamTC = ConvertToIntSafe(mnNam(Index).Text)
        LbCty(7).Text = ConvertToStrSafe(pNamTC)
        MemoryHelper.ReleaseMemory()
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub mnNV_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mnNV_0.Click, _mnNV_1.Click, _mnNV_2.Click, _mnNV_3.Click, _mnNV_4.Click, _mnNV_5.Click, _mnNV_6.Click, _mnNV_7.Click, _mnNV_8.Click, _mnNV_9.Click, _mnNV_10.Click, _mnNV_11.Click, _mnNV_12.Click
        Dim Index As Integer = Array.IndexOf(mnNV, eventSender)
        Select Case Index
            Case 0
                frmPhanLoaiNV.Tag = "4"
                frmPhanLoaiNV.ShowDialog()
            Case 1
                FrmChucvu.ShowDialog()
            Case 3
                FrmQuanLyNhanVien.ShowDialog()
            Case 4
                FrmPhucap.ShowDialog()
            Case 5
                FrmChucdanh.ShowDialog()
            Case 7
                FrmChamcong.ShowDialog()
            Case 8
                FrmChamconggio.ShowDialog()
        End Select
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub mnts_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mnts_0.Click, _mnts_1.Click, _mnts_2.Click, _mnts_3.Click, _mnts_4.Click, _mnts_5.Click, _mnts_6.Click, _mnts_7.Click, _mnts_8.Click, _mnts_9.Click, _mnts_10.Click, _mnts_11.Click, _mnts_12.Click, _mnts_13.Click, _mnts_14.Click, _mnts_15.Click
        Dim Index As Integer = Array.IndexOf(mnts, eventSender)
        If (Not FADetail) Or User_Right = 2 Then
            NoRight(2)
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Select Case Index
            Case 0 ' Phan loai TS
                frmPhanLoai.Tag = "1"
                frmPhanLoai.ShowDialog()
                Exit Select
            Case 1 ' Phan loai ctu
                frmPhanLoai.Tag = "2"
                frmPhanLoai.ShowDialog()
                Exit Select
            Case 2 ' Phan loai Cong cu dung cu
                frmPhanLoai.Tag = "3"
                frmPhanLoai.ShowDialog()
                Exit Select
            Case 4 ' Nuoc sx
                FrmKho.Tag = "2"
                FrmKho.ShowDialog()
                Exit Select
            Case 5 ' Tinh trang SD
                FrmKho.Tag = "3"
                FrmKho.ShowDialog()
                Exit Select
            Case 6 ' DTQL
                FrmKho.Tag = "4"
                FrmKho.ShowDialog()
                Exit Select
            Case 8
                If FADetail Then
                    pNghiepVu = NV_KHONG
                    cuongdauky = 3
                    frmDSCCDC.ShowDialog()
                    cuongdauky = 0
                Else
                    NoRight(2)
                End If
                Exit Select
            Case 9
                If FADetail Then
                    pNghiepVu = NV_KHONG
                    cuongdauky = 4
                    frmDSCCDC.ShowDialog()
                    cuongdauky = 0
                Else
                    NoRight(2)
                End If
                Exit Select
            Case 11
                If ChoDieuChinhDauKy() Then
                    pNghiepVu = NV_TANG
                    frmTaiSan.Tag = "1"
                    frmTaiSan.ShowDialog()
                End If
                Exit Select
            Case 12 '142
                If ChoDieuChinhDauKy() Then
                    pNghiepVu = NV_TANG
                    cuongdauky = 1
                    FrmCongcudungcu.Tag = "1"
                    FrmCongcudungcu.ShowDialog()
                    cuongdauky = 0
                End If
                Exit Select
            Case 13 '153
                If ChoDieuChinhDauKy() Then
                    pNghiepVu = NV_TANG
                    cuongdauky = 2
                    FrmCongcudungcu.Tag = "1"
                    FrmCongcudungcu.ShowDialog()
                    cuongdauky = 0
                End If
                Exit Select
            Case 15
                If KtraMKAdmin() Then DatTKTS()
                Exit Select
        End Select
        HienThongBao("", 1)
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub mnuChkGiaVon_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mnuChkGiaVon_18.Click
        If KiemTraXuatGV() Then
            myUMessager.mInformation(Ngonngu("Kiểm tra hoàn tất!", "Complete test"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub mnuHLP_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mnuHLP_0.Click, _mnuHLP_1.Click, _mnuHLP_2.Click, _mnuHLP_3.Click, _mnuHLP_4.Click
        Dim Index As Integer = Array.IndexOf(mnuHLP, eventSender)
        Select Case Index
            Case 0
                Process.Start("https://ketoanunesco.com")
                'Openword("Vanban\huongdan.doc")
                Exit Select
            Case 2
                'Openword("Vanban\gioithieu.doc")
                Process.Start("https://ketoanunesco.com")
                Exit Select
            Case 4
                'Bản quyền
                'FrmAbout.ShowDialog(Me)
                Exit Select
        End Select
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub mnuNhanvien_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuNhanvien.Click
        UpdatePhuCapTable()
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub mnVT_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mnVT_0.Click, _mnVT_1.Click, _mnVT_2.Click, _mnVT_3.Click, _mnVT_4.Click, _mnVT_5.Click, _mnVT_6.Click, _mnVT_7.Click, _mnVT_8.Click, _mnVT_9.Click, _mnVT_10.Click, _mnVT_11.Click, _mnVT_12.Click, _mnVT_13.Click, _mnVT_14.Click, _mnVT_15.Click, _mnVT_16.Click, _mnVT_17.Click
        Dim Index As Integer = Array.IndexOf(mnVT, eventSender)
        Dim st, TK As String
        Dim j, i, k As Integer
        Dim d1, d2 As Date
        Dim mv As Integer
        If User_Right = 2 Then
            NoRight(0)
            Exit Sub
        End If
        If Not STDetail Then
            NoRight(1)
            Exit Sub
        End If
        If Index = 3 Or Index = 4 Or Index = 5 Or Index = 10 Or Index = 12 Then
            If Not KtraMKAdmin() Then Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim KTthangdau, KTthangcuoi As Integer
        Dim no, co As Double
        Dim MaVattu As String = String.Empty
        Dim MaCT, ma1541, ma155, MaSoCT As Integer
        Select Case Index
            Case 0
                frmPhanLoaiVT.pl1 = "1"
                frmPhanLoaiVT.ShowDialog()
                frmPhanLoaiVT.pl1 = "0"
                Exit Select
            Case 1
                FrmNguon.ShowDialog()
                Exit Select
            Case 3
                If ChoDieuChinhDauKy() Then
                    FVTDauKy.ShowDialog()
                End If
                Exit Select
            Case 4
                If OutCost <> 2 Then
                    st = FrmGetStr.GetString(Ngonngu("Tháng cần tính lại:", "May be re-calculated:"), Ngonngu("Tính giá xuất kho", "Calculation of inventory"))
                    Dim thangCanTinh As Integer = ConvertToIntSafe(st, 0)
                    If thangCanTinh > 0 And (thangCanTinh < 14) Then
                        If ConvertToDblSafe(GetSelectValue(String.Format("SELECT lock{0} as f1 FROM license", st))) = 1 Then
                            If FrmPassword.GetPswX(Ngonngu("Dữ liệu đã bị khoá. Nhập mật khẩu ...", "Locked data. Password ...")) <> "MS" Then GoTo kt
                        End If

                        If IsNumeric(st) Then
                            i = ConvertToIntSafe(st)
                            j = i
                        Else
                            i = (st.IndexOf("-"c) + 1)
                            If i > 0 Then
                                j = ConvertToIntSafe(Strings.Right(st, st.Length - i))
                                i = ConvertToIntSafe(Strings.Left(st, i - 1))
                            Else
                                i = ConvertToIntSafe(st)
                                j = i
                            End If
                        End If
                    Else
                        myUMessager.mError(String.Format("Giá trị tháng ""{0}""không hợp lệ, xin kiểm tra và thử lại", st), "Tính giá xuất kho", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    i = 1
                    j = 12
                End If
                If i > 0 And i < 13 And j > 0 And j < 13 Then
                    st = ""
                    st = FrmGetStr.GetString("Số hiệu vật tư cần tính lại (để trống nếu tính lại toàn bộ):", "Tính giá xuất kho")
                    Do While st.Length > 0
                        mv = SoHieu2MaSo(st, "Vattu")
                        If mv > 0 Then Exit Do
                        st = FrmGetStr.GetString("Số hiệu vật tư cần tính lại (để trống nếu tính lại toàn bộ):", "Tính giá xuất kho")
                    Loop
                    TK = IIf(OutCost <> 2, FrmGetStr.GetString("Số hiệu tài khoản ghi nợ khi xuất kho cần tính lại (để trống nếu tính lại toàn bộ):", "Tính giá xuất kho", String.Empty), String.Empty)
                    Me.Cursor = Cursors.WaitCursor
                    If OutCost = 0 Then
                        k = ConvertToIntSafe(FrmGetStr.GetString("Nhập số 1 để tính bình quân di động, số 2 để tính bình quân cuối kỳ ", "Tính lại giá xuất kho"))
                        If k < 1 Or k > 2 Then GoTo kt
                        If k = 1 Then TinhGXK(i, j, st, TK)
                        If k = 2 Then TinhGXKBQ(i, j, st, TK)
                    End If
                    If OutCost = 1 Then TinhGVBH(NgayDauThang(pNamTC, pThangDauKy), NgayCuoiNam(), 1, mv)
                    If OutCost = 2 Then TinhGXKFIFO(i, j, st, TK)
                    ma1541 = ConvertToDblSafe(Timten("maso", "1541", "sohieu", "hethongtk"))
                    ma155 = ConvertToDblSafe(Timten("maso", "155", "sohieu", "hethongtk"))
                    no = LayCdt(True, i, j, 2, co)
                    If no <> 0 Or co <> 0 Then
                        ExecSQLNonQuery(String.Format("UPDATE chungtu set sops=[sops]+{0}-{1} WHERE sohieu like 'KCTP-%' and thangct={2} and matkco={3} and sops>=all(SELECT sops FROM chungtu WHERE sohieu like 'KCTP-%' and thangct={2} and matkco={3})", _
                                            no, _
                                            ConvertToStrSafe(co), _
                                            ConvertToStrSafe(j), _
                                            ConvertToStrSafe(ma1541)))
                        MaCT = ConvertToIntSafe(GetSelectValue(String.Format("SELECT mact as f1,maso as f2,mavattu as f3 FROM chungtu WHERE sohieu like 'KCTP-%' and thangct={0} and matkco={1} and sops>=all(SELECT sops FROM chungtu WHERE sohieu like 'KCTP-%' and thangct={2} and matkco={1})", _
                                                                   j, _
                                                                   ConvertToStrSafe(ma1541), _
                                                                   ConvertToStrSafe(j)), MaSoCT, MaVattu))
                        ExecSQLNonQuery(String.Format("UPDATE chungtu set sops=[sops]+{0}-{1} WHERE maso<>{2} and mact={3} and sohieu like 'KCTP-%' and thangct={4} and matkno={5} and sops>=all(SELECT sops FROM chungtu WHERE maso<>{2} and mact={3} and sohieu like 'KCTP-%' and thangct={4} and matkno={5})", _
                                            no, _
                                            ConvertToStrSafe(co), _
                                            ConvertToStrSafe(MaSoCT), _
                                            ConvertToStrSafe(MaCT), _
                                            ConvertToStrSafe(j), _
                                            ConvertToStrSafe(ma155)))
                        If ConvertToDblSafe(MaVattu) = 0 Then MaVattu = ConvertToStrSafe(GetSelectValue(String.Format("SELECT mavattu as f1 FROM chungtu WHERE maso<>{0} and mact={1} and sohieu like 'KCTP-%' and thangct={2} and matkno={3} and sops>=all(SELECT sops FROM chungtu WHERE maso<>{4} and mact={1} and sohieu like 'KCTP-%' and thangct={2} and matkno={3})", _
                                                                                                            MaSoCT, _
                                                                                                            ConvertToStrSafe(MaCT), _
                                                                                                            ConvertToStrSafe(j), _
                                                                                                            ConvertToStrSafe(ma155), _
                                                                                                            ConvertToStrSafe(MaSoCT))))
                        ExecSQLNonQuery(String.Format("UPDATE chungtu set sops=[sops]+{0}-{1} WHERE sohieu like '%GV' and thangct={2} and matkco={3} and mavattu={4} and sops>=all(SELECT sops FROM chungtu WHERE sohieu like '%GV' and thangct={2} and mavattu={4} and matkco={3})", _
                                            no, _
                                            ConvertToStrSafe(co), _
                                            ConvertToStrSafe(j), _
                                            ConvertToStrSafe(ma155), _
                                            MaVattu))
                    End If
                End If
                Exit Select
            Case 5
                If OutCost = 2 Then
                    d1 = NgayDauThang(pNamTC, pThangDauKy)
                    d2 = NgayCuoiNam()
                Else
                    If Not GetDate2.GetDate(Ngonngu("Tính giá vốn bán hàng", "Calculating cost of sales"), d1, d2) Then Exit Sub
                End If
                KTthangdau = d1.Month : KTthangcuoi = d2.Month
                For i = KTthangdau To KTthangcuoi
                    If ConvertToDblSafe(GetSelectValue(String.Format("SELECT lock{0} as f1 FROM license", i))) = 1 Then
                        If FrmPassword.GetPswX(String.Format("Dữ liệu tháng {0} đã bị khoá. Nhập mật khẩu ...", i)) <> "MS" Then GoTo kt
                    End If
                Next
                i = MessageBox.Show(Ngonngu("Lập lại các chứng từ giá vốn đã tính ? (Nếu không thì chương trình chỉ lập các chứng từ giá vốn còn thiếu)", "Reset the cost voucher was calculated (otherwise the program only create cost voucher missing)"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                st = FrmGetStr.GetString(Ngonngu("Số hiệu vật tư cần tính lại (để trống nếu tính lại toàn bộ):", "Number of material to be caculated (Blank if necessary to calculate all):"), My.Application.Info.ProductName)
                Do While st.Length > 0
                    mv = SoHieu2MaSo(st, "Vattu")
                    If mv > 0 Then Exit Do
                    st = FrmGetStr.GetString(Ngonngu("Số hiệu vật tư cần tính lại (để trống nếu tính lại toàn bộ):", "Number of material to be caculated (Blank if necessary to calculate all):"), My.Application.Info.ProductName)
                Loop
                Me.Cursor = Cursors.WaitCursor
                If OutCost = 0 Then
                    k = ConvertToIntSafe(FrmGetStr.GetString(Ngonngu("Nhập số 1 để tính bình quân di động, số 2 để tính bình quân cuối kỳ (tính theo tháng)", "Enter 1 to calculate average mobile, enter 2 to calculate average final (calculate with months)"), My.Application.Info.ProductName))
                    If k < 1 And k > 2 Then GoTo kt
                    TinhGVBHBQ(d1.Month, d2.Month, i, mv, k)
                Else
                    TinhGVBH(d1, d2, i, mv)
                End If
                myUMessager.mInformation(Ngonngu("Tính giá vốn bán hàng hoàn thành!", "Calculate cost of sales completed!"), Ngonngu("Tính giá vốn bán hàng", "Calculating cost of sales"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Select
            Case 6
                FVTDauKy.Tag = "1"
                FVTDauKy.ShowDialog()
                Exit Select
            Case 7
                KiemKeN.ShowDialog()
                Exit Select
            Case 9
                frmPhanLoaiVT.pl1 = "3"
                frmPhanLoaiVT.ShowDialog()
                frmPhanLoaiVT.pl1 = "0"
                Exit Select
            Case 10
                FrmTP.ShowDialog()
                Exit Select
            Case 11
                Frm154Dauky.ShowDialog()
                Exit Select
            Case 12
                If KtraMKAdmin() Then DatTKDTTP()
                Exit Select
            Case 14
                If KtraMKAdmin() Then DatTKVT()
                Exit Select
            Case 16, 17
                CPGV.Tag = ConvertToStrSafe(Index - 16)
                CPGV.ShowDialog(Me)
                Application.DoEvents()
                Exit Select
        End Select
kt:
        HienThongBao("", 1)
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="saukc"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="cap"></param>
    ''' <param name="SoPhu"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LayCdt(ByRef saukc As Boolean, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef cap As Integer, Optional ByRef SoPhu As Double = 0) As Double
        Dim result As Double = 0
        Dim st As String = String.Empty
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        SoDuTKCN2(ThangTruoc(tdau))
        SoDuTKCN2(tcuoi)
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            If sqln.Length = 0 Then
                sqln.Append(String.Format("HethongTk.No_{0}", i))
            Else
                sqln.Append(String.Format(" + HethongTk.No_{0}", i))
            End If

            If sqlc.Length = 0 Then
                sqlc.Append(String.Format("HethongTk.Co_{0}", i))
            Else
                sqlc.Append(String.Format(" + HethongTk.Co_{0}", i))
            End If
        Next
        st = ConvertToStrSafe(CThangDB2(tcuoi))
        Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT DISTINCT HeThongTK.Cap,HeThongTK.SoHieu,  HeThongTK.Ten, HeThongTK.Kieu, HeThongTK.Loai, HeThongTK.DuNo_{0} As DkNo, HeThongTK.DuCo_{1} As DkCo, {2} As PsNo, {3} As PsCo, KC_N, KC_C, {4} As CkNo, {5} As CkCo FROM HeThongTK WHERE ((HeThongTK.MaTC = 0 Or HethongTK.MaTC = HethongTK.MaSo) OR (TK_ID3 % 10 >= 1)) And (HeThongTK.Loai > 0)  AND Cap<={6} AND (DuNo_{7}<>0 OR DuCo_{7}<>0 OR ({2})<>0 OR ({3})<>0) and sohieu='1541' order by hethongtk.loai,hethongtk.sohieu", _
                                                  CThangDB2(ThangTruoc(tdau)), _
                                                  ConvertToStrSafe(CThangDB2(ThangTruoc(tdau))), _
                                                  sqln, _
                                                  sqlc, _
                                                  (IIf(saukc, String.Format("HeThongTK.DuNo_{0}", st), "HethongTk.DuNo")), _
                                                  (IIf(saukc, String.Format("HeThongTK.DuCo_{0}", st), "HethongTk.DuCo")), _
                                                  ConvertToStrSafe(cap), _
                                                  st))
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            result = ConvertToIntSafe(rsItem("ckno"))
            SoPhu = ConvertToIntSafe(rsItem("ckco"))
        Else
            result = 0
            SoPhu = 0
        End If
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub mnXoa1_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mnXoa1_0.Click, _mnXoa1_1.Click, _mnXoa1_2.Click, _mnXoa1_3.Click, _mnXoa1_4.Click, _mnXoa1_5.Click, _mnXoa1_6.Click, _mnXoa1_7.Click, _mnXoa1_8.Click, _mnXoa1_9.Click, _mnXoa1_10.Click, _mnXoa1_11.Click, _mnXoa1_12.Click
        Dim Index As Integer = Array.IndexOf(mnXoa1, eventSender)
        If User_Right <> 0 Then
            NoRight(0)
            Exit Sub
        End If
        If FrmPassword.GetPswX() <> "MS" Then Exit Sub
        If ConvertToDblSafe((mnXoa(Index).Tag)) > 0 Then
            If myUMessager.mQuestion(String.Format("Bạn chắc chắn cần xóa phát sinh tháng {0} ?", mnXoa(Index).Tag), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                HienThongBao(String.Format("Xóa phát sinh tháng {0} ...  Xin vui lòng chờ !", mnXoa(Index).Tag), 1)
                XoaPSThang(Index)
            End If
        Else
            If myUMessager.mQuestion(Ngonngu("Bạn chắc chắn cần xóa số dư đầu năm?", "Are you sure you want to delete the beginning of the year?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                HienThongBao(Ngonngu("Xóa số dư đầu năm, xin vui lòng chờ !", "Deleting the beginning of the year, please waint !"), 1)
                XoaDK()
            End If
        End If
        HienThongBao("", 1)
        Me.Cursor = Cursors.Default
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub OptNN_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptNN_0.CheckedChanged, _OptNN_1.CheckedChanged
        If eventSender.Checked Then
            Dim Index As Integer = Array.IndexOf(OptNN, eventSender)
            If Index < 0 Then Exit Sub
            CloseItemList()
            pNN = Index
            SetFont(Me, 1)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub sbStatusBar_PanelClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _sbStatusBar_Panel1.Click, _ServerName.Click, _sbStatusBar_Panel3.Click, _sbStatusBar_Gio.Click
        ''Dim Panel As ToolStripStatusLabel = CType(eventSender, ToolStripStatusLabel)
        ''Dim path As String = String.Empty
        ''SELECT Case UpgradeStubs.MSComctlLib_IPanel.getIndex(Panel)
        ''    Case 2
        ''        Panel.Text = iif(Panel.Tag = 0, "Data File Size: " & Format(ConvertToIntSafe((New FileInfo(pDataPath)).Length) / 1024000, Mask_2) & " MB, Version: " & (iif(ConvertToDblSafe(UpgradeStubs.DAO_Database.getVersion(DBKetoan)) < 4, "97", "2010.1")), pDataPath)
        ''        Panel.Tag = 1 - Panel.Tag
        ''        StationList()
        ''    Case 3 : Panel.Text = iif(Panel.Tag = 0, Panel.ToolTipText, UserName)
        ''        Panel.Tag = 1 - Panel.Tag
        ''    Case 4 : path = Interaction.GetSetting(IniPath, "Environment", "BackUpPath", )
        ''        path = FrmGetStr.GetString("Thư mục lưu dữ liệu", My.Application.Info.ProductName, path)
        ''        Interaction.SaveSetting(IniPath, "Environment", "BackUpPath", path)
        ''End SELECT
    End Sub

    ''' thủ tục Cap nhat Cai Dat Khoi Tao Du Lieu

    Private Sub CapnhatCaiDatKhoiTaoDuLieu()
        Try
            ' thêm trường số lô trên bảng hoa đơn và thêm trường hạn dùng trên bảng hóa đơn
            If Not TruongDaCo("HoaDon", "SoLo") Or Not TruongDaCo("HoaDon", "HanDung") Then
                ExecSQLNonQuery(My.Settings.SQL_Update_HoaDon)
            End If            
            ' thêm bảng hóa đơn điện tử vietel
            If Not BangDaCo("HoaDonDienTuViettel") Then
                ExecSQLNonQuery(My.Settings.SQL_Create_Table_HDDT_Viettel)
            End If
        Catch ex As Exception
            myUMessager.mError(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' thủ tục kiểm tra dữ liệu
    Public Sub KiemTraDuLieu()
        Try
            ' thêm trường số lô trên bảng hoa đơn
            If Not TruongDaCo("HoaDon", "SoLo") Then
                ExecSQLNonQuery("alter table HoaDon add SoLo nvarchar(50) null")
            End If
            ' thêm trường hạn dùng trên bảng hóa đơn
            If Not TruongDaCo("HoaDon", "HanDung") Then
                ExecSQLNonQuery("alter table HoaDon add HanDung nvarchar(15) null")
            End If
            ' thêm bảng hóa đơn điện tử vietel
            If Not BangDaCo("HoaDonDienTuViettel") Then
                ExecSQLNonQuery(My.Settings.SQL_Create_Table_HDDT_Viettel)
            End If
        Catch ex As Exception
            myUMessager.mError(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Thủ tục lấy tên công ty và chi nhánh
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub GetLicense()
        Dim k As Integer
        CloseItemList()
        DEMO = 1
        Dim i As Integer = er_DBFile
        Try
            i = 0
            Dim rs_license As DataTable = ExecSQLReturnDT("SELECT * FROM License")
            If rs_license.Rows.Count > 0 Then
                Dim rsLicenseItem As DataRow = rs_license.Rows(0)
                i = ConvertToIntSafe(rsLicenseItem("Flag1")) Mod 100
                If i > 0 Then
                    If StationList() > i Then
                        i = er_Connection
                        Me.Close()
                        Exit Sub
                    End If
                End If
                pTenCty = ConvertToStrSafe(rsLicenseItem("TenCty"))
                pTenCn = ConvertToStrSafe(rsLicenseItem("tencn"))
                LbCty(2).Text = ConvertToStrSafe(rsLicenseItem("DiaChi"))
                pDiaChiCty = ConvertToStrSafe(rsLicenseItem("DiaChi"))
                LbCty(3).Text = ConvertToStrSafe(rsLicenseItem("Tel"))
                LbCty(4).Text = ConvertToStrSafe(rsLicenseItem("Fax"))
                LbCty(5).Text = ConvertToStrSafe(rsLicenseItem("TaiKhoanVN"))
                LbCty(6).Text = ConvertToStrSafe(rsLicenseItem("TaiKhoanNT"))
                pNamTC = ConvertToIntSafe(rsLicenseItem("NamTC"))
                pThangDauKy = ConvertToIntSafe(rsLicenseItem("thang"))
                LbCty(7).Text = ConvertToStrSafe(pNamTC)
                LbCty(8).Text = ConvertToStrSafe(rsLicenseItem("MaSoThue"))
                pBaoGia = (ConvertToIntSafe(rsLicenseItem("Flag1")) Mod 1000) \ 100
                pNVBH = (ConvertToIntSafe(rsLicenseItem("Flag1")) Mod 10000) \ 1000
                _mnCN_6.Visible = (pNVBH > 0)
                For j As Integer = 7 To 8
                    mnCN(j).Visible = (pNVBH > 0)
                Next
                Lb(0).Tag = "Model"
                SetFont(Me)
                i = (ConvertToIntSafe(rsLicenseItem("Flag1")) Mod 1000000000) \ 100000000
                Lb(0).Tag = i

                If (i < 3 Or i = 5) And pVersion = 0 Then
                    ExecSQLNonQuery("UPDATE License SET Flag1 = 400000000 + Flag1 Mod 100000000")
                End If
                Select Case i
                    Case 1 : Lb(1).Text = "Doanh nghiệp Nhà nước"
                        Lb(0).Text = "8.1.NN."
                        Exit Select
                    Case 2 : Lb(1).Text = "Cổ phần - Liên doanh"
                        Lb(0).Text = "8.1.CP."
                        Exit Select
                    Case 3 : Lb(1).Text = "Công ty TNHH"
                        Lb(0).Text = "2010.1"
                        Exit Select
                    Case 4 : Lb(1).Text = "Doanh nghiệp tư nhân"
                        Lb(0).Text = "8.1.TN."
                        Exit Select
                    Case 5 : Lb(1).Text = "Cơ sở đào tạo"
                        Lb(0).Text = "8.1.DT."
                        Exit Select
                    Case 6
                        Lb(1).Text = "Hành chính sự nghiệp"
                        Lb(0).Text = "8.1.HCSN."
                        Label(24).Visible = False
                        Label(25).Visible = False
                        Frame(1).Visible = False
                        Exit Select
                    Case Else
                        Lb(0).Text = "2.04"
                        Exit Select
                End Select
                If pVersion <> 3 Then
                    Lb(0).Text = String.Format("{0}{1}{2}{3}{4}", _
                                     Lb(0).Text, _
                                     IIf((ConvertToIntSafe(rsLicenseItem("Flag1")) Mod 100000000) \ 10000000 > 0, "1", "0"), _
                                     IIf((ConvertToIntSafe(rsLicenseItem("Flag1")) Mod 10000000) \ 1000000 > 0, "1", "0"), _
                                     IIf((ConvertToIntSafe(rsLicenseItem("Flag1")) Mod 1000000) \ 100000 > 0, "1", "0"), _
                                     IIf((ConvertToIntSafe(rsLicenseItem("Flag1")) Mod 100000) \ 10000 > 0, "1", "0"))
                End If
                Chk(0).CheckState = (ConvertToIntSafe(rsLicenseItem("Flag1")) Mod 100000000) \ 10000000
                Chk(1).CheckState = (ConvertToIntSafe(rsLicenseItem("Flag1")) Mod 10000000) \ 1000000
                Chk(2).CheckState = (ConvertToIntSafe(rsLicenseItem("Flag1")) Mod 1000000) \ 100000
                Chk(3).CheckState = (ConvertToIntSafe(rsLicenseItem("Flag1")) Mod 100000) \ 10000
                'vancuong edit 1/4/18 : set quyen cho cac button tren main
                'Cmd1(4).Enabled = Chk(1).CheckState = CheckState.Checked Or Chk(3).CheckState = CheckState.Checked
                'pThuChiNhapXuat = Chk(1).CheckState = CheckState.Checked Or Chk(3).CheckState = CheckState.Checked
                'het edit
                For j As Integer = 0 To 3
                    If j <> 2 Then Chk(j).Visible = Chk(j).CheckState = CheckState.Checked
                Next
                pTygia = IIf(ConvertToIntSafe(rsLicenseItem("tygia")) > 0, 1, 0)
                pHachToan = 1 - (ConvertToIntSafe(rsLicenseItem("RptOrder")) Mod 10)
                pRpt = (ConvertToIntSafe(rsLicenseItem("RptOrder")) Mod 100) \ 10
                OutCost = ConvertToStrSafe(rsLicenseItem("OutCost"))
                FCost = ConvertToStrSafe(rsLicenseItem("FixedOutCost"))
                STDetail = ConvertToStrSafe(rsLicenseItem("STDetail"))
                FADetail = ConvertToStrSafe(rsLicenseItem("FADetail"))
                KHDetail = ConvertToStrSafe(rsLicenseItem("HDV"))
                pGiaHT = ConvertToStrSafe(rsLicenseItem("GiaHT"))
                pGiaVon = (ConvertToIntSafe(rsLicenseItem("STDetail")) Mod 100) \ 10
                pDTTP = (ConvertToIntSafe(rsLicenseItem("STDetail")) Mod 1000) \ 100
                pDinhmuc = (ConvertToIntSafe(rsLicenseItem("STDetail")) Mod 10000) \ 1000
                pCongNoHD = (ConvertToIntSafe(rsLicenseItem("Lock0")) Mod 1000) \ 100
                pPQTK = (ConvertToIntSafe(rsLicenseItem("Lock0")) Mod 10000) \ 1000
                pGiaUSD = (ConvertToIntSafe(rsLicenseItem("Lock0")) Mod 100000) \ 10000
                pChietKhau = (ConvertToIntSafe(rsLicenseItem("Lock1")) Mod 100) \ 10
                pGiamgia = (ConvertToIntSafe(rsLicenseItem("Banhang")) Mod 1000000) \ 100000
                pKiemKeNgay = (ConvertToIntSafe(rsLicenseItem("Lock1")) Mod 1000) \ 100
                pNoiBo = (ConvertToIntSafe(rsLicenseItem("Lock1")) Mod 10000) \ 1000
                pSoVV = (ConvertToIntSafe(rsLicenseItem("Lock1")) Mod 100000) \ 10000
                pNhapKhau = (ConvertToIntSafe(rsLicenseItem("Lock2")) Mod 100) \ 10
                pBarCode = (ConvertToIntSafe(rsLicenseItem("Lock2")) Mod 1000) \ 100
                pNhapDoiTuong = (ConvertToIntSafe(rsLicenseItem("Lock2")) Mod 10000) \ 1000
                pTrungSoHieuKhacThang = (ConvertToIntSafe(rsLicenseItem("Lock2")) Mod 100000) \ 10000
                _mnVT_15.Visible = (pNhapKhau > 0)
                pTien = 0
                pTien = ConvertToIntSafe(rsLicenseItem("loaitien"))
                If pTien > 0 Then
                    Mask_0 = Mask_2
                    pTienStr = TenNT(pTien)
                Else
                    Mask_0 = "#,###"
                    Mask_2 = "#,##0.##"
                    pTienStr = "VND"
                End If
                CTGS_GV = ConvertToIntSafe(rsLicenseItem("CTGS_GV"))
                pFontName = ConvertToStrSafe(rsLicenseItem("FontName"))
                pFontSize = ConvertToIntSafe(rsLicenseItem("FontSize"))

                LbCty(10).Text = ConvertToStrSafe(rsLicenseItem("quan"))
                LbCty(11).Text = ConvertToStrSafe(rsLicenseItem("thanhpho"))
                LbCty(13).Text = String.Format("{0} - {1} - {2}", _
                                     rsLicenseItem("DiaChi"), _
                                     rsLicenseItem("quan"), _
                                     rsLicenseItem("thanhpho"))
                Me.LbCty(9).Text = ConvertToStrSafe(rsLicenseItem("email"))
                pSoKT = ConvertToIntSafe(rsLicenseItem("SoKT"))
                _MNDL_13.Visible = (pSoKT Mod 100 >= 10)
                MNDL(14).Visible = (pSoKT Mod 100 >= 10)
                MNDLA(16).Visible = (ConvertToIntSafe(rsLicenseItem("Flag1")) Mod 10000000) \ 1000000
                'tbToolBar.Items.Item("ThanhPham").Visible = (ConvertToIntSafe((rsLicenseItem("RptOrder"))) Mod 10000 >= 1000)
                'tbToolBar.Items.Item("ThanhPham2").Visible = (ConvertToIntSafe((rsLicenseItem("RptOrder"))) Mod 10000 >= 1000)
                pSongNgu = False
                pSongNgu = (pSoKT Mod 100000 >= 10000)
                pMaVach = CheckState.Unchecked
                pMaVach = ConvertToIntSafe((rsLicenseItem("mv"))) Mod 10
                pTyGiaBQ = 0
                pTyGiaBQ = IIf(ConvertToIntSafe((rsLicenseItem("mv"))) Mod 10000 >= 1000, 1, 0)
                'tbToolBar.Items.Item("TongHop").Visible = False
                'tbToolBar.Items.Item("TongHop").Visible = ConvertToIntSafe(rsLicenseItem("mv")) Mod 1000 >= 100
                DEMO = IIf((ConvertToIntSafe(rsLicenseItem("mv")) Mod 100000 >= 10000) And (ConvertToIntSafe(rsLicenseItem("MKUP")) = pRev), 0, 1)
                NgayDauThangMoi = ConvertToStrSafe(rsLicenseItem("NgayDauThang"))
                FontFlag = LoaiFont(pFontName)
                If (Not pSongNgu) And OptNN(1).Checked Then
                    OptNN(0).Checked = True
                End If
                mnVT(4).Visible = (OutCost = 0 Or OutCost = 1 Or OutCost = 2)
                mnVT(7).Visible = (pKiemKeNgay > 0)
                _mnVT_8.Visible = (pDTTP <> 0)
                For i = 9 To 11
                    mnVT(i).Visible = (pDTTP <> 0)
                Next
                MNDL(19).Visible = pSongNgu
                Dim sh As String = ConvertToStrSafe(GetSelectValue("SELECT App1Path AS F1 FROM License"))

                If DEMO = 0 And pVersion <> 2 Then
                    Me.Text = String.Format("{0}{1}", Me.Text, sh)

                    If Int_StrToCode(ConvertToStrSafe(rsLicenseItem("MaSoThue"))) <> ConvertToStrSafe(rsLicenseItem("MST_ID")) Or Int_StrToCode(pTenCty) <> ConvertToStrSafe(rsLicenseItem("TenCty_ID")) Or Int_StrToCode(pTenCn) <> ConvertToStrSafe(rsLicenseItem("tencn_id")) Then
                        'pTenCty = "Sao chép không bản quyền"
                        'pTenCn = "Sao chép không bản quyền"
                        'ExecSQLNonQuery("UPDATE License SET MST_ID=-1")
                        'pSTOP = 1
                    End If

                Else
                    Me.Text = String.Format("{0}{1}{2}", _
                                  Me.Text, _
                                  sh, _
                                  IIf(pVersion < 2, " - Training Version", " - Chương trình phối hợp đào tạo"))
                End If
                Me.Text = "ACTax " & System.String.Format(My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision, 0)
                If pVersion = 3 Then
                    Me.Text = String.Format("{0} - HCSN", Me.Text)
                    pVATV = "3113"
                    pSHPT = "3111"
                Else
                    pVATV = "133"
                    pSHPT = "131"
                End If
                LbCty(0).Tag = ConvertToStrSafe(rsLicenseItem("TenCty_ID"))
                LbCty(0).Text = pTenCty
                LbCty(1).Text = pTenCn
                Frame(0).Visible = pSongNgu
                mnXoa(0).Tag = "0"
                mnK(0).Tag = "0"
                mnK(0).Text = String.Format("{0}{1}", _
                                  mnK(0).Text, _
                                  IIf(ConvertToIntSafe(rsLicenseItem("Lock0")) Mod 10 > 0, "          x", String.Empty))
                For i = 1 To 12
                    k = CThangFR(i)
                    sh = IIf(ConvertToIntSafe(rsLicenseItem(String.Format("Lock{0}", i))) Mod 10 > 0, "          x", String.Empty)
                    mnXoa(i).Text = String.Format("{0}/{1}", _
                                        ConvertToStrSafe(k), _
                                        ConvertToStrSafe(pNamTC))
                    mnK(i).Text = String.Format("{0}/{1}{2}", _
                                      ConvertToStrSafe(k), _
                                      ConvertToStrSafe(pNamTC), _
                                      sh)
                    mnXoa(i).Tag = ConvertToStrSafe(k)
                    mnK(i).Tag = ConvertToStrSafe(k)
                Next
                LietKeNam()
                ' cập nhật cài đặt khởi tạo dữ liệu mới database
                CapnhatCaiDatKhoiTaoDuLieu()
            End If
            pCurDir = Path.GetFullPath(My.Application.Info.DirectoryPath)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="id"></param>
    ''' <remarks></remarks>
    Public Sub NoRight(ByRef id As Integer)
        Select Case id
            Case 0
                HienThongBao("Không có quyền truy cập!", 1)
                Exit Select
            Case 1
                HienThongBao("Không đăng ký theo dõi chi tiết vật tư!", 1)
                Exit Select
            Case 2
                HienThongBao("Không đăng ký theo dõi chi tiết TSCĐ!", 1)
                Exit Select
        End Select
        SystemSounds.Beep.Play()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LietKeNam()
        mnNam(MaxNamTC).Text = ConvertToStrSafe(pNamTC)
        mnNam(MaxNamTC).Checked = True
        If Not BangDaCo("NamTC") Then Exit Sub
        Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT * FROM NamTC WHERE Nam < {0} ORDER BY Nam DESC", pNamTC))
        Dim i As Integer = MaxNamTC
        For Each rsItem As DataRow In rs.Rows
            i -= 1
            If i <= 0 Then
                Exit For
            End If
            mnNam(i).Text = ConvertToStrSafe(rsItem("Nam"))
            mnNam(i).Visible = True
            mnNam(i).Tag = ConvertToStrSafe(rsItem("path"))
        Next
        Do While (i > 0)
            i -= 1
            mnNam(i).Visible = False
        Loop
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SetUserRight()
        Try
            For i As Integer = 0 To 3
                MNDLA(i).Enabled = (User_Right <> 2)
            Next
            For i As Integer = 5 To 9
                MNDLA(i).Enabled = (User_Right <> 2)
            Next
            For i As Integer = 11 To 14
                MNDLA(i).Enabled = (User_Right <> 2)
            Next
            'For i As Integer = 1 To 8
            '    tbToolBar.Items.Item(i).Enabled = (User_Right <> 2)
            'Next
            For i As Integer = 1 To 5
                mnHT(i).Enabled = (User_Right = 0)
            Next
            For i As Integer = 14 To 16 Step 2
                mnHT(i).Enabled = (User_Right = 0)
            Next
            mnHT(9).Enabled = (User_Right = 0)
            mnHT(11).Enabled = (User_Right = 0)
            MNDL(0).Enabled = (User_Right = 0)
            MNDL(1).Enabled = (User_Right = 0)
            MNDL(3).Enabled = (User_Right = 0)
            MNDL(4).Enabled = (User_Right = 0)
            MNDL(7).Enabled = (User_Right = 0)
            For i As Integer = 9 To 12
                MNDL(i).Enabled = (ConvertToIntSafe(Me.Tag) Mod 10 >= 1) Or (User_Right = 0)
            Next
            mnVatTu.Enabled = (ConvertToIntSafe(Me.Tag) Mod 100 >= 10) Or (ConvertToIntSafe(Me.Tag) Mod 1000 >= 100)
            ' moi them ngay 30/09/18 cuongnv : Or (ConvertToIntSafe(Me.Tag) Mod 100 >= 10)
            mnTSCD.Enabled = (ConvertToIntSafe(Me.Tag) Mod 1000 >= 100) Or (ConvertToIntSafe(Me.Tag) Mod 100 >= 10)
            MemoryHelper.ReleaseMemory()
        Catch ex As Exception
            MemoryHelper.ReleaseMemory()
            myUMessager.mError(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub DatTKCN()
        Dim TK As New ClsTaikhoan
        FrmGetStr.Tag = "2"
        Dim shtk As String = FrmGetStr.GetString("Số hiệu TK", "Đặt/Bỏ TK theo dõi chi tiết")
        If Not (shtk.Length = 0) Then
            TK.InitTaikhoanSohieu(shtk)
            If Not (TK.maso = 0) Then
                If TK.tk_id = TKVT_ID Or TK.tk_id = TSCD_ID Or TK.tk_id = KHTSCD_ID Or TK.tk_id = TKThue_ID Or TK.tk_id = TKDT_ID Then
                    Exit Sub
                End If
                If TK.TkCoPS(0, 0) Then
                    Me.Cursor = Cursors.WaitCursor
                    If TK.ChuyenChiTietSangDoiTuong() Then
                        myUMessager.mWarning(Ngonngu("Các chi tiết tài khoản đã được mã hoá thành đối tượng công nợ!", "The account details have been encode into the object of liabilities!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        myUMessager.mWarning(Ngonngu("Tài khoản không chuyển đổi được!", "Account can not convert!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                    Me.Cursor = Cursors.Default
                Else
                    If TK.tk_id = TKCNKH_ID Or TK.tk_id = TKCNPT_ID Then ExecSQLNonQuery(String.Format("DELETE from SoDuKhachHang  where SoDuKhachHang.MaSo in (select SoDuKhachHang.MaSo from SoDuKhachHang INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo WHERE HethongTK.SoHieu LIKE '{0}%')", TK.sohieu))
                    If TK.loai < 3 Then
                        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET TK_ID={0} WHERE SoHieu LIKE '{1}%'", _
                                            (IIf(TK.tk_id = TKCNKH_ID, "0", ConvertToStrSafe(TKCNKH_ID))), _
                                            TK.sohieu))
                    End If
                    If TK.loai > 2 Then
                        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET TK_ID={0} WHERE SoHieu LIKE '{1}%'", _
                                            (IIf(TK.tk_id = TKCNPT_ID, "0", ConvertToStrSafe(TKCNPT_ID))), _
                                            TK.sohieu))
                    End If
                End If
            End If
        End If
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub DatTKVT()
        Dim TK As New ClsTaikhoan
        FrmGetStr.Tag = "1"
        Dim shtk As String = FrmGetStr.GetString(Ngonngu("Số hiệu TK", "Account"), Ngonngu("Đặt/Bỏ TK theo dõi chi tiết", "Set up accounts to track details"))
        If shtk.Length = 0 Then Exit Sub
        TK.InitTaikhoanSohieu(shtk)
        If Not (TK.maso = 0) Then
            If TK.tk_id = TKCNKH_ID Or TK.tk_id = TKCNPT_ID Or TK.tk_id = TSCD_ID Or TK.tk_id = KHTSCD_ID Or TK.tk_id = TKThue_ID Or TK.tk_id = TKDT_ID Then Exit Sub
            If TK.TkCoPS(0, 0) Or TK.NoDauKy <> 0 Or TK.CoDauKy <> 0 Then
                myUMessager.mWarning(Ngonngu("Tài khoản có phát sinh hoặc đầu kỳ, không chuyển đổi được!", "Account can not convert!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If TK.tk_id = TKVT_ID Then ExecSQLNonQuery("DELETE TonKho FROM TonKho INNER JOIN HethongTK ON TonKho.MaTaiKhoan=HethongTK.MaSo WHERE HethongTK.SoHieu LIKE '" & TK.sohieu & "%'")
                ExecSQLNonQuery(String.Format("UPDATE HethongTK SET TK_ID={0} WHERE SoHieu LIKE '{1}%'", _
                                    (IIf(TK.tk_id = TKVT_ID, "0", ConvertToStrSafe(TKVT_ID))), _
                                    TK.sohieu))
            End If
        End If
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub DatTKDTTP()
        Dim TK As New ClsTaikhoan
        FrmGetStr.Tag = "4"
        Dim shtk As String = FrmGetStr.GetString(Ngonngu("Số hiệu TK", "Account"), Ngonngu("Đặt/Bỏ TK hạch toán doanh thu", "Setup account to track sales"))
        If Not (shtk.Length = 0) Then
            TK.InitTaikhoanSohieu(shtk)
            If Not (TK.maso = 0 Or Strings.Left(TK.sohieu, 2) <> "51") Then
                If TK.TkCoPS(0, 0) Then
                    myUMessager.mWarning(Ngonngu("Tài khoản có phát sinh, không chuyển đổi được!", "Account have arising, can not convert"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    ExecSQLNonQuery(String.Format("UPDATE HethongTK SET TK_ID2={0} WHERE SoHieu LIKE '{1}%'", _
                                        (IIf(TK.tk_id2 = TKDT_ID, "0", ConvertToStrSafe(TKDT_ID))), _
                                        TK.sohieu))
                End If
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RunCT()
        Dim pctpath As String = ConvertToStrSafe(GetSelectValue("SELECT App1Path AS F1 FROM License"))
        If FileSystem.Dir(pctpath, FileAttribute.Normal).Length > 0 Then
            Dim startInfo As ProcessStartInfo = New ProcessStartInfo(pctpath)
            startInfo.WindowStyle = ProcessWindowStyle.Normal
            Process.Start(startInfo)
        End If
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="title"></param>
    ''' <param name="f"></param>
    ''' <param name="mask"></param>
    ''' <param name="act"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ChonTenTep(ByRef title As String, ByRef f As Integer, ByRef mask As String, ByRef act As Integer) As String
        Dim result As String = String.Empty
        With dlgCommonDialogOpen
            .Title = title
            '.Flags = f
            .FileName = mask
            .DefaultExt = mask
            .Filter = String.Format("Tệp dữ liệu ({0})|{0}|Tất cả (*.*)|*.*", mask)
            On Error GoTo Xong
            Select Case act
                Case 1, 2, 3, 4
                    .ShowDialog()
                    Exit Select
            End Select
            On Error GoTo 0
            If Strings.Len(.FileName) = 0 Or Strings.Left(.FileName, 1) = "*" Then GoTo Xong
            If act = 2 Then
                If FileSystem.Dir(.FileName, FileAttribute.Normal).Length > 0 Then
                    If .FileName = pDataPath Then
                        myUMessager.mWarning(Ngonngu("Tệp dữ liệu đang mở !", "Can not open the data file !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        GoTo Xong
                    End If
                    If myUMessager.mQuestion(String.Format(Ngonngu("Tệp {0} đã tồn tại, tiếp tục ?", "File {0} already exists, continue ?"), .FileName), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then GoTo Xong
                    If Recycle(.FileName) <> 0 Then
                        myUMessager.mError(String.Format(Ngonngu("Không xoá được tệp {0} !", "Can not delete file {0} !"), dlgCommonDialogOpen.FileName), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        GoTo Xong
                    End If
                End If
            End If
            result = .FileName
        End With
Xong:
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function StationList() As Integer
        'Dim i As Integer = 0
        'Dim machineList As New StringBuilder("")
        'Dim accessMachineName As DataTable = ExecSQLReturnDT("SELECT SUSER_SNAME() AS userName, HOST_NAME() AS hostName")
        'For Each rsItem As DataRow In accessMachineName.Rows
        '    i += 1
        '    machineList.AppendFormat("{0}. {1} - {2}", i, rsItem("userName"), rsItem("hostName")).AppendLine()
        'Next
        'If accessMachineName.Rows.Count > 0 Then
        '    LbCty(12).Text = String.Format("Các máy trạm: {0}", machineList.ToString())
        'Else
        '    LbCty(12).Text = ""
        'End If
        LbCty(12).Text = String.Format("Các máy trạm: {0}", My.Computer.Name)
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LietKeTep()
        'Dim k As Integer
        'Dim fn As String = String.Empty
        'For i As Integer = 1 To 5
        '    fn = Interaction.GetSetting(IniPath, "RecentFiles", String.Format("File{0}", i), )
        '    If fn.Length > 0 And fn <> pDataPath Then
        '        mnHT(17 + i).Text = fn
        '        mnHT(17 + i).visible = True
        '        k += 1
        '    Else
        '        mnHT(17 + i).visible = False
        '    End If
        'Next
        'mnHT(23).visible = (k > 0)
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub XoaQuery()
        Dim q As String = Interaction.InputBox("Tên query cần xóa: ", My.Application.Info.ProductName)
        'If q.Length > 0 Then
        '    If QueryDaCo(q) Then
        '        UpgradeStubs.DAO_Database.getQueryDefs(DBKetoan).DELETE(q)
        '    End If
        'End If
        MemoryHelper.ReleaseMemory()
    End Sub
    'Private Sub 'FontSetUp()
    '    Add32Font("VNTIME.TTF")
    '    Add32Font("VNTIMEB.TTF")
    '    Add32Font("VNTIMEBI.TTF")
    '    Add32Font("VNTIMEI.TTF")
    '    Add32Font("VHTIME.TTF")
    '    Add32Font("VHTIMEB.TTF")
    '    Add32Font("VHTIMEBI.TTF")
    '    Add32Font("VHTIMEI.TTF")
    '    Add32Font("VTIMESN.TTF")
    '    Add32Font("VTIMESB.TTF")
    '    Add32Font("VTIMESBI.TTF")
    '    Add32Font("VTIMESI.TTF")
    'End Sub
    ''' <summary>
    ''' Kiem tra xem cac' chung tu "Ban Hang" co xuat gia von het chua
    ''' Chung tu "Ban Hang" co Maloai = 8
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function KiemTraXuatGV() As Boolean
        Dim result As Boolean = False
        Dim tmp As Integer
        Dim hdh As String = String.Empty
        result = True
        Dim sql As String = "SELECT DISTINCT ct.SoHieu FROM ChungTu ct left join hethongtk tkc on ct.matkco=tkc.maso WHERE ct.MaLoai=8 and (tkc.sohieu like '5111' or tkc.sohieu like '5112') GROUP BY ct.SoHieu"
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        For Each rsItem As DataRow In rs.Rows
            tmp = ConvertToIntSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) as F1 FROM ChungTu WHERE MaLoai=2 AND SoHieu Like '{0}GV' GROUP BY SoHieu", rsItem("SoHieu"))))
            If tmp = 0 Then
                hdh = ConvertToStrSafe(GetSelectValue(String.Format("SELECT TOP 1 KhachHang.SoHieu as F1 FROM (HoaDon INNER JOIN ChungTu ON HoaDon.MaSo=ChungTu.MaSo) LEFT JOIN KhachHang ON HoaDon.MaKhachHang=KhachHang.MaSo WHERE ChungTu.SoHieu=N'{0}'", rsItem("SoHieu"))))
                If hdh <> "H" Then
                    myUMessager.mInformation(String.Format("Chứng từ với số hiệu [{0}] chưa có (hoặc không đúng) Chứng từ xuất giá vốn. Hãy kiểm tra lại!", rsItem("SoHieu")), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    result = False
                    Exit For
                End If
            End If
        Next
        MemoryHelper.ReleaseMemory()
        Return result
    End Function



    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            _sbStatusBar_Gio.Text = DateTime.Now.ToShortTimeString
            _ngay.Text = Date.Now.ToShortDateString
        Catch ex As Exception

        End Try
    End Sub

    ' quan ly vat tu hang hoa menu
    Private Sub functionVatTuHangHoa(ByVal Index As Integer)
        Try
            Dim loai As Integer
            Select Case Index
                Case 0, 3, 4, 20, 21
                    loai = IIf(Index = 0 Or Index = 21, 1, IIf(Index = 3, 8, 2))
                    If Index = 0 Or Index = 21 Then
                        FrmChungtu.initOption = 1
                    ElseIf Index = 3 Then
                        'Bán hàng
                        FrmChungtu.initOption = 8
                    Else
                        'Xuất hàng
                        FrmChungtu.initOption = 2
                    End If
                    FrmChungtu.initOption = loai
                    FrmChungtu.ShowDialog()
                Case 1, 18
                    If Index = 1 Then
                        CPGV.Tag = "0"
                    Else
                        CPGV.Tag = "1"
                    End If
                    CPGV.ShowDialog()
                Case 2
                    If pRpt = CheckState.Checked And User_Right = 1 Then
                        ErrMsg(er_KoSD)
                        Exit Sub
                    End If
                    FrmSovattuhanghoa.ShowDialog()
                Case 5
                    If STDetail Then
                        FrmLuuChuyen.ShowDialog()
                    Else
                        NoRight(1)
                    End If
                Case 6
                    If Not STDetail Then
                        NoRight(1)
                        GoTo kt
                    End If
                    KiemTraVatTu()
                    HienThongBao("Xong ...", 1)
                    Exit Sub
                Case 7
                    FrmNguon.ShowDialog()
                Case 8
                    If STDetail Then
                        FrmKho.Tag = "1"
                        FrmKho.ShowDialog()
                    Else
                        NoRight(1)
                    End If
                Case 9
                    frmPhanLoaiVT.pl1 = "1"
                    frmPhanLoaiVT.ShowDialog()
                    frmPhanLoaiVT.pl1 = "0"
                Case 10
                    If ChoDieuChinhDauKy() Then
                        FVTDauKy.ShowDialog()
                    End If
                Case 11
                    If STDetail Then
                        FrmVattu.ShowDialog()
                    Else
                        NoRight(1)
                    End If
                Case 12
                    If STDetail Then
                        FrmDuphong.ShowDialog()
                    Else
                        NoRight(1)
                    End If
                Case 13 : If KtraMKAdmin() Then
                        DatTKVT()
                    Else
                        DatTKVT()
                    End If
                Case 14 : If KtraMKAdmin() Then
                        DatTKDTTP()
                    Else
                        DatTKDTTP()
                    End If
                Case 15 : FrmHD.ShowDialog()
                Case 16 : Me.Close() : Exit Sub
                Case 17 : Lapbangke()
                Case 19 : FrmHDnoidia.ShowDialog()
                Case 22
                    FrmChungtu.initOption = 0
                    'Chi phí nhập hàng
                    FrmChungtu.loai1.Tag = "0"
                    FrmChungtu.ShowDialog()
            End Select
kt:
            HienThongBao("...", 1)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Throw New Exception(ex.Message)
        End Try
    End Sub


    Function vatTuHangHoaMenu(ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) As Boolean
        Dim result As Boolean
        result = False
        Try
            If (e.Node.Name = "nVatTuDauKy") Then
                functionVatTuHangHoa(10)
                result = True
            ElseIf e.Node.Name = "nMuaHangtrongNuoc" Then
                functionVatTuHangHoa(0)
                result = True
            ElseIf e.Node.Name = "nNhapNoiDia" Then
                functionVatTuHangHoa(18)
                result = True
            ElseIf e.Node.Name = "nNhapKhau" Then
                functionVatTuHangHoa(1)
                result = True
            ElseIf e.Node.Name = "nBanHang" Then
                functionVatTuHangHoa(3)
                result = True
            ElseIf e.Node.Name = "nPhieuXuat" Then
                functionVatTuHangHoa(4)
                result = True
            ElseIf e.Node.Name = "nLuuChuyenNoiBo" Then
                functionVatTuHangHoa(5)
                result = True
            ElseIf e.Node.Name = "nLapBangKeBanLe" Then
                functionVatTuHangHoa(17)
                result = True
            ElseIf e.Node.Name = "nBaoCaoChiTiet" Then
                functionVatTuHangHoa(2)
                result = True
            ElseIf e.Node.Name = "nDMDanhSachVatTu" Then
                functionVatTuHangHoa(11)
                result = True
            ElseIf e.Node.Name = "nDMPhanLoaiVT" Then
                functionVatTuHangHoa(9)
                result = True
            ElseIf e.Node.Name = "nDMKenhPhanPhoi" Then
                functionVatTuHangHoa(7)
                result = True
            ElseIf e.Node.Name = "nDMDanhSachKho" Then
                functionVatTuHangHoa(8)
                result = True
            ElseIf e.Node.Name = "nDMChietTKVT" Then
                functionVatTuHangHoa(13)
                result = True
            ElseIf e.Node.Name = "nDMDuPhongGiamGia" Then
                functionVatTuHangHoa(12)
                result = True
            ElseIf e.Node.Name = "nDMChiTietTKDT" Then
                functionVatTuHangHoa(14)
                result = True
            ElseIf e.Node.Name = "nDMHopDongNhapKhau" Then
                functionVatTuHangHoa(15)
                result = True
            ElseIf e.Node.Name = "nDMHoaDonNoiDia" Then
                functionVatTuHangHoa(19)
                result = True
            Else
                result = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return result
    End Function

    'tai san co dinh
    Private Sub functionTaiSanCoDinh(ByVal Index As Integer)
        Try
            Cursor = Cursors.WaitCursor
            Select Case Index
                Case 0, 3, 5, 6
                    'FrmChungtu.OptLoai(IIf(Index = 0, 9, (IIf(Index = 3, 10, (IIf(Index = 5, 11, 12)))))).Checked = True
                    FrmChungtu.initOption = IIf(Index = 0, 9, (IIf(Index = 3, 10, (IIf(Index = 5, 11, 12)))))
                    If FrmChungtu.initOption <> 0 Then
                        If Index = 6 Then FrmChungtu.ct_MaKhoHang = 1
                        FrmChungtu.ShowDialog()
                        If Index = 6 Then FrmChungtu.ct_MaKhoHang = 0
                    End If
                    'FrmChungtu.initOption = 4
                    'FrmChungtu.Close()
                    'Me.ShowDialog()
                Case 1
                    FrmKho.Tag = "4"
                    FrmKho.ShowDialog()
                Case 2
                    If pRpt = CheckState.Checked And User_Right = 1 Then
                        ErrMsg(er_KoSD)
                        Exit Sub
                    End If
                    FrmSotaisan.ShowDialog()
                Case 4
                    If KtraMKAdmin() Then DatTKTS()
                Case 7
                    frmPhanLoai.Tag = "1"
                    frmPhanLoai.ShowDialog()
                Case 8
                    If FADetail Then
                        pNghiepVu = NV_KHONG
                        frmDSTaiSan.ShowDialog()
                    Else
                        NoRight(2)
                    End If
                Case 9
                    If ChoDieuChinhDauKy() Then
                        pNghiepVu = NV_TANG
                        frmTaiSan.Tag = "1"
                        frmTaiSan.lc = 1
                        frmTaiSan.ShowDialog()
                        frmTaiSan.lc = 0
                    End If
                Case 10
                    FrmKho.Tag = "2"
                    FrmKho.ShowDialog()
                Case 11
                    FrmChungtu.khoi_tao()
                    FrmChungtu.Nut.Tag = "1"
                    FrmDsCT.tscc = 1
                    FrmChungtu.flag = -1
                    FrmChungtu.loadluoi = 1
                    FrmChungtu.ShowDialog()
                    FrmChungtu.loadluoi = 0
                    FrmDsCT.tscc = 0
                Case 12
                    FrmKho.Tag = "3"
                    FrmKho.ShowDialog()
                Case 13
                    FrmChungtu.khoi_tao()
                    FrmChungtu.initOption = 0
                    'Chi phí nhập hàng
                    FrmChungtu.loai1.Tag = "0"
                    FrmChungtu.loadluoi = 1
                    FrmChungtu.ShowDialog()
                Case 14
                    FrmChungtu.initOption = 8
                    'Chứng từ giảm
                    FrmChungtu.loai1.Tag = 6
                    FrmChungtu.ShowDialog()
                Case 15
                    Me.Close() : Exit Sub
            End Select

            HienThongBao("...", 1)
            MemoryHelper.ReleaseMemory()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Function taiSanCoDinhMenu(ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) As Boolean
        Dim result As Boolean
        result = False
        Try
            If (e.Node.Name = "nTaiSanDauKy") Then
                functionTaiSanCoDinh(9)
                result = True
            ElseIf e.Node.Name = "nNhapTangTaiSan" Then
                functionTaiSanCoDinh(0)
                result = True
            ElseIf e.Node.Name = "nGiamTaisan" Then
                functionTaiSanCoDinh(3)
                result = True
            ElseIf e.Node.Name = "nDanhGiaLaiTaiSan" Then
                functionTaiSanCoDinh(5)
                result = True
            ElseIf e.Node.Name = "nKhauHao" Then
                functionTaiSanCoDinh(6)
                result = True
            ElseIf e.Node.Name = "nTraCuuCTTaiSan" Then
                functionTaiSanCoDinh(11)
                result = True
            ElseIf e.Node.Name = "nSoTaiSan" Then
                functionTaiSanCoDinh(2)
                result = True
            ElseIf e.Node.Name = "nDMPhanLoaiTaiSan" Then
                functionTaiSanCoDinh(7)
                result = True
            ElseIf e.Node.Name = "nDMSuaGiatriTS" Then
                functionTaiSanCoDinh(8)
                result = True
            ElseIf e.Node.Name = "nDMNuocSX" Then
                functionTaiSanCoDinh(10)
                result = True
            ElseIf e.Node.Name = "nDMTinhTrangSuDung" Then
                functionTaiSanCoDinh(12)
                result = True
            ElseIf e.Node.Name = "nDMDoiTuongQuanLy" Then
                functionTaiSanCoDinh(1)
                result = True
            ElseIf e.Node.Name = "nDMTKChiPhi" Then
                functionTaiSanCoDinh(4)
                result = True
            Else
                result = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return result
    End Function

    ' cong cu dung cu
    Private Sub functionCongCuDungCu(ByVal Index As Integer)
        Try
            Select Case Index
                Case 0, 6, 11, 13
                    FrmChungtu.khoi_tao()
                    FrmChungtu.initOption = IIf(Index = 0, 13, IIf(Index = 6, 14, 15))
                    If Index = 11 Then
                        cuongdauky = 6
                    ElseIf Index = 13 Then
                        cuongdauky = 7
                    End If
                    If FrmChungtu.initOption <> 0 Then
                        If Index = 6 Then FrmChungtu.ct_MaKhoHang = 1
                        FrmChungtu.loadluoi = 1
                        FrmChungtu.ShowDialog()
                        FrmChungtu.loadluoi = 0
                        If Index = 6 Then FrmChungtu.ct_MaKhoHang = 0
                    End If
                Case 1, 9
                    If ChoDieuChinhDauKy() Then
                        pNghiepVu = NV_TANG
                        cuongdauky = IIf(Index = 1, 1, 2)
                        FrmCongcudungcu.Tag = "1"
                        FrmCongcudungcu.ShowDialog()
                        cuongdauky = 0
                    End If
                Case 2
                    If pRpt = CheckState.Checked And User_Right = 1 Then
                        ErrMsg(er_KoSD)
                        Exit Sub
                    End If
                    FrmSocongcu.ShowDialog()
                Case 3, 14
                    FrmChungtu.khoi_tao()
                    FrmChungtu.initOption = 0
                    If Index = 14 Then
                        'Chứng từ chi phí trả trước
                        FrmChungtu.loai1.Tag = 7
                    End If
                    FrmChungtu.loadluoi = 1
                    FrmChungtu.ShowDialog()
                Case 4
                    FrmKho.Tag = "4"
                    FrmKho.ShowDialog()
                Case 5
                    If KtraMKAdmin() Then DatTKTS()
                Case 7
                    frmPhanLoai.Tag = "3"
                    frmPhanLoai.ShowDialog()
                Case 8, 10
                    If FADetail Then
                        pNghiepVu = NV_KHONG
                        cuongdauky = IIf(Index = 8, 4, 3)
                        frmDSCCDC.ShowDialog()
                        cuongdauky = 0
                    Else
                        NoRight(2)
                    End If
                Case 12
                    FrmChungtu.initOption = 8
                    'Chứng từ giảm
                    FrmChungtu.loai1.Tag = 6
                    FrmChungtu.ShowDialog()
                Case 15
                    Me.Close() : Exit Sub
                Case 16
                    FrmChungtu.khoi_tao()
                    FrmChungtu.loadluoi = 1
                    FrmChungtu.Nut.Tag = "1"
                    FrmDsCT.tscc = 2
                    FrmChungtu.loadluoi = 1
                    FrmChungtu.ShowDialog()
                    FrmChungtu.loadluoi = 0
                    FrmDsCT.tscc = 0
                    FrmChungtu.loadluoi = 0
            End Select

            HienThongBao("...", 1)
            Me.Cursor = Cursors.Default
            MemoryHelper.ReleaseMemory()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Function congCuDungCuMenu(ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) As Boolean
        Dim result As Boolean
        result = False
        Try
            If (e.Node.Name = "nCongCuDauKy") Then
                functionCongCuDungCu(9)
                result = True
            ElseIf e.Node.Name = "nNhapTangCongCu" Then
                functionCongCuDungCu(0)
                result = True
            ElseIf e.Node.Name = "nChiPhiTraTruocDauKy" Then
                functionCongCuDungCu(1)
                result = True
            ElseIf e.Node.Name = "nChiPhiTraTruoc" Then
                functionCongCuDungCu(3)
                result = True
            ElseIf e.Node.Name = "nPhanBo" Then
                functionCongCuDungCu(6)
                result = True
            ElseIf e.Node.Name = "nTraCuuCTCCDC" Then
                functionCongCuDungCu(16)
                result = True
            ElseIf e.Node.Name = "nSoCCDC" Then
                functionCongCuDungCu(2)
                result = True
            ElseIf e.Node.Name = "nDanhMucCCDC" Then
                result = False
            ElseIf e.Node.Name = "nDMPhanLoaiCCDC" Then
                functionCongCuDungCu(7)
                result = True
            ElseIf e.Node.Name = "nSuaGiaTriCCDC" Then
                functionCongCuDungCu(8)
                result = True
            ElseIf e.Node.Name = "nDMSuaGiaTriCP" Then
                functionCongCuDungCu(10)
                result = True
            ElseIf e.Node.Name = "nDoiTuongQuanLyCCDC" Then
                functionCongCuDungCu(4)
                result = True
            ElseIf e.Node.Name = "nDMTKChiPhiPB" Then
                functionCongCuDungCu(5)
                result = True
            Else
                result = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return result
    End Function

    'chi phi tong hop
    Private Sub functionChiPhiTongHop(ByVal Index As Integer)
        Try
            Cursor = Cursors.WaitCursor
            Select Case Index
                Case 0, 1
                    FrmChungtu.Nut.Tag = IIf(Index = 0, "1", "2")
                    If Index = 0 Then
                        FrmDsCT.tracu = True
                    Else
                        FrmChungtu.CmdDanhSach(0).Visible = False
                        FrmChungtu.CmdDanhSach(1).Visible = True
                    End If
                    'FrmChungtu.initOption = 0
                    FrmChungtu.ShowDialog()
                    If Index = 0 Then
                        FrmDsCT.tracu = False
                    Else
                        FrmChungtu.CmdDanhSach(0).Visible = True
                        FrmChungtu.CmdDanhSach(1).Visible = False
                    End If
                    Exit Select
                Case 2, 5, 6, 7
                    If Index = 2 Then
                        'Chi phi hoạt động kinh doanh
                        FrmChungtu.loai1.Tag = 2
                    ElseIf Index = 5 Then
                        'Thuế, phí và lệ phí
                        FrmChungtu.loai1.Tag = 3
                    ElseIf Index = 6 Then
                        'Ngân hàng
                        FrmChungtu.loai1.Tag = 4
                    Else
                        'Chi phí khác
                        FrmChungtu.loai1.Tag = 5
                    End If

                    FrmChungtu.initOption = 0
                    FrmChungtu.ShowDialog()
                    Exit Select
                Case 3
                    If pRpt = CheckState.Checked And User_Right = 1 Then
                        ErrMsg(er_KoSD)
                        Exit Sub
                    End If
                    FrmSochiphi.ShowDialog()
                    Exit Select
                Case 4
                    Me.Close()
                Case 8
                    FrmChungtutonghop.initOption = 0
                    FrmChungtutonghop.ShowDialog()
                    Exit Select
                Case 12
                    TinhLaiGiaNgoaiTe()
                    Exit Select
            End Select
            HienThongBao("...", 1)
            MemoryHelper.ReleaseMemory()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Function chiPhiTongTopMenu(ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) As Boolean
        Dim result As Boolean
        result = False
        Try
            If (e.Node.Name = "nNhapChiPhiTongHop") Then
                functionChiPhiTongHop(2)
                result = True
            ElseIf e.Node.Name = "nTimPhieuThuChi" Then
                functionChiPhiTongHop(1)
                result = True
            ElseIf e.Node.Name = "nTinhGiaXuatNgoaiTe" Then
                functionChiPhiTongHop(12)
                result = True
            ElseIf e.Node.Name = "nNhapChungTuTongHop" Then
                functionChiPhiTongHop(8)
                result = True
            ElseIf e.Node.Name = "nSoChiPhi" Then
                functionChiPhiTongHop(3)
                result = True
            Else
                result = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return result
    End Function

    'gia thanh
    Private Sub functionGiaThanh(ByVal Index As Integer)
        Try
            Me.Cursor = Cursors.WaitCursor
            Select Case Index
                Case 0
                    Frm154Dauky.ShowDialog()
                Case 1
                    If pRpt = CheckState.Checked And User_Right = 1 Then
                        ErrMsg(er_KoSD)
                    Else
                        FrmSogiathanh.ShowDialog()
                    End If
                Case 2
                    FrmVattu.TK = "155"
                    If FrmVattu.ChucNang = 0 Then FrmVattu.Command_ClickEvent(FrmVattu.Command(4), New EventArgs())
                    FrmVattu.ShowDialog()
                Case 3
                    FrmPBCP.ShowDialog()
                Case 7
                    frmPhanLoaiVT.pl1 = "3"
                    frmPhanLoaiVT.ShowDialog()
                    frmPhanLoaiVT.pl1 = "0"
                Case 8
                    FrmTP.ShowDialog()
                Case 14
                    If STDetail Then
                        FrmThanhPham.ShowDialog()
                    Else
                        NoRight(1)
                    End If
                Case 15
                    Me.Close()
                Case 16
                    Tinhgiaxuatkho()
            End Select
            Me.Cursor = Cursors.Default
            HienThongBao("...", 1)
            MemoryHelper.ReleaseMemory()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Function giaThanhMenu(ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) As Boolean
        Dim result As Boolean
        result = False
        Try
            If (e.Node.Name = "nDoGiangDauKy") Then
                functionGiaThanh(0)
                result = True
            ElseIf e.Node.Name = "nNhapkhothanhpham" Then
                functionGiaThanh(14)
                result = True
            ElseIf e.Node.Name = "nTinhLaiGiaTriXuatKho" Then
                functionGiaThanh(16)
                result = True
            ElseIf e.Node.Name = "nSoGiaThanh" Then
                functionGiaThanh(1)
                result = True
            ElseIf e.Node.Name = "nDMPhanLoaiLoSanXuat" Then
                functionGiaThanh(7)
                result = True
            ElseIf e.Node.Name = "nDMDSLoSanXuat" Then
                functionGiaThanh(8)
                result = True
            ElseIf e.Node.Name = "nDMDinhMucNVL" Then
                functionGiaThanh(2)
                result = True
            ElseIf e.Node.Name = "nDMPhanBoCPCTSP" Then
                functionGiaThanh(3)
                result = True
            Else
                result = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return result
    End Function

    'cong no
    Private Sub functionCongNo(ByVal Index As Integer)
        Try

            Select Case Index
                Case 0
                    frmPhanLoaiVT.pl1 = "2"
                    frmPhanLoaiVT.ShowDialog()
                    frmPhanLoaiVT.pl1 = "0"
                    Exit Select
                Case 1
                    FrmKhachHang.ShowDialog()
                    Exit Select
                Case 2
                    FrmCantrucongno.ShowDialog()
                    Exit Select
                Case 3
                    FrmNguyente.ShowDialog()
                    Exit Select
                Case 5
                    If KtraMKAdmin() Then
                        FrmLS.ShowDialog()
                    End If
                    Exit Select
                Case 6
                    If KtraMKAdmin() Then DatTKCN()
                    Exit Select
                Case 7
                    Me.Close()
                    Exit Select
                Case 8
                    If ChoDieuChinhDauKy() Then
                        If pCongNoHD = 0 Then
                            FKHDauKy.ShowDialog()
                        Else
                            FKHDauKy2.ShowDialog()
                        End If
                    End If
                    Exit Select
                Case 9
                    If pRpt = CheckState.Checked And User_Right = 1 Then
                        ErrMsg(er_KoSD)
                        Exit Sub
                    End If
                    FrmSoCongNo.ShowDialog()
                Case 10, 11, 12, 13
                    FrmChungtu.loai1.Tag = "1"
                    If Index = 10 Then
                        FrmChungtu.loaino.Tag = "0"
                    ElseIf Index = 11 Then
                        FrmChungtu.loaino.Tag = "1"
                    ElseIf Index = 12 Then
                        FrmChungtu.loaino.Tag = "3"
                    ElseIf Index = 13 Then
                        FrmChungtu.loaino.Tag = "2"
                    End If
                    FrmChungtu.initOption = 0
                    FrmChungtu.ShowDialog()
                    FrmChungtu.loai1.Tag = "0"
                    FrmChungtu.loaino.Tag = "0"
                    Exit Select
            End Select

            HienThongBao("", 1)
            Me.Cursor = Cursors.Default
            MemoryHelper.ReleaseMemory()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Function congNoMenu(ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) As Boolean
        Dim result As Boolean
        result = False
        Try
            If (e.Node.Name = "nCongNoDauKy") Then
                functionCongNo(8)
                result = True
            ElseIf e.Node.Name = "nThuNo" Then
                functionCongNo(10)
                result = True
            ElseIf e.Node.Name = "nTraNo" Then
                functionCongNo(11)
                result = True
            ElseIf e.Node.Name = "nBaoCaoCongNo" Then
                functionCongNo(9)
                result = True
            ElseIf e.Node.Name = "nDMPhanLoaiKhachHang" Then
                functionCongNo(0)
                result = True
            ElseIf e.Node.Name = "nDMDSKH" Then
                functionCongNo(1)
                result = True
            ElseIf e.Node.Name = "nDMTKCongNo" Then
                functionCongNo(6)
                result = True
            ElseIf e.Node.Name = "nDMLaiSuatCN" Then
                functionCongNo(5)
                result = True
            ElseIf e.Node.Name = "nDMNgoaiTeVaTyGia" Then
                functionCongNo(3)
                result = True
            Else
                result = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return result
    End Function

    'so ke toan
    Private Sub functionBaoCaoTongHop(ByVal Index As Integer)
        Try
            If pRpt = 1 And User_Right = 1 Then
                ErrMsg(er_KoSD)
                Exit Sub
            End If
            FrmMNBaocao.ShowDialog()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Function soKeToanMenu(ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) As Boolean
        Dim result As Boolean
        result = False
        Try
            If (e.Node.Name = "nBaoCaoTongHop") Then
                functionBaoCaoTongHop(0)
                result = True
            Else
                result = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return result
    End Function


    Private Sub TreeViewApp_NodeMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs)
        Try
            Me.Cursor = Cursors.WaitCursor
            If (e.Node.Name = "nVTHH" Or e.Node.Name = "nCCDC" _
                Or e.Node.Name = "nTaiSanCoDinh" _
                Or e.Node.Name = "nChiPhiTongHop" _
                Or e.Node.Name = "nGiaThanh" _
                Or e.Node.Name = "nCongNo" _
                Or e.Node.Name = "nSoKeToan" _
                Or e.Node.Name = "nDanhMuc" _
                Or e.Node.Name = "nDanhMucTSCD" _
                Or e.Node.Name = "nDanhMucCCDC" _
                Or e.Node.Name = "nDanhMucGiaThanh" _
                Or e.Node.Name = "nChiPhiTongHop" _
                Or e.Node.Name = "nDanhMucCongNo") Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            'vat tu hang hoa menu
            If vatTuHangHoaMenu(e) Then
                Me.Cursor = Cursors.Default
                HienThongBao("...", 1)
                Exit Sub
            ElseIf taiSanCoDinhMenu(e) Then
                Me.Cursor = Cursors.Default
                HienThongBao("...", 1)
                Exit Sub
            ElseIf congCuDungCuMenu(e) Then
                Me.Cursor = Cursors.Default
                HienThongBao("...", 1)
                Exit Sub
            ElseIf chiPhiTongTopMenu(e) Then
                Me.Cursor = Cursors.Default
                HienThongBao("...", 1)
                Exit Sub
            ElseIf giaThanhMenu(e) Then
                Me.Cursor = Cursors.Default
                HienThongBao("...", 1)
                Exit Sub
            ElseIf congNoMenu(e) Then
                Me.Cursor = Cursors.Default
                HienThongBao("...", 1)
                Exit Sub
            ElseIf soKeToanMenu(e) Then
                Me.Cursor = Cursors.Default
                HienThongBao("...", 1)
                Exit Sub
            Else
                Me.Cursor = Cursors.Default
                HienThongBao("...", 1)
                Exit Sub
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tbToolBar_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tbToolBar.ItemClicked
        Try
            Me.Cursor = Cursors.WaitCursor
            Select Case e.ClickedItem.Name
                Case "btnHeThongTaiKhoan"
                    FrmTaikhoan.Tag = "1"
                    FrmTaikhoan.ShowDialog()
                    Exit Select
                Case "btnNgoaiTeTyGia"
                    FrmNguyente.ShowDialog()
                    Exit Select
                Case "btnKhoHang"
                    If STDetail Then
                        FrmKho.Tag = "1"
                        FrmKho.ShowDialog()
                    Else
                        NoRight(1)
                    End If
                    Exit Select
                Case "btnDanhSachVatTuHangHoa"
                    If STDetail Then
                        FrmVattu.ShowDialog()
                    Else
                        NoRight(1)
                    End If
                Case "btnLuuChuyenNoiBo"
                    If STDetail Then
                        FrmLuuChuyen.ShowDialog()
                    Else
                        NoRight(1)
                    End If
                    Exit Select
                Case "btnDuPhongGiamGia"
                    If STDetail Then
                        FrmDuphong.ShowDialog()
                    Else
                        NoRight(1)
                    End If
                    Exit Select
                Case "btnTaiSanCoDinh"
                    If FADetail Then
                        pNghiepVu = NV_KHONG
                        frmDSTaiSan.ShowDialog()
                    Else
                        NoRight(2)
                    End If
                    Exit Select
                Case "btnDanhSachKhachhangCongNo"
                    If KHDetail Then
                        FrmKhachHang.ShowDialog()
                    End If
                    Exit Select
                Case "TongHop"
                    FrmTongHop.ShowDialog()
                    Exit Select
                Case "btnHuongDan"
                    mnuHLP_Click(mnuHLP(0), New EventArgs())
                Case "btnKetThucChuongTrinh"
                    Me.Close()
                    Exit Sub
                    Exit Select
                Case "ThanhPham"
                    If STDetail Then
                        FrmThanhPham.ShowDialog()
                    Else
                        NoRight(1)
                    End If
                    Exit Select
            End Select
            HienThongBao("...", 1)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MN_Sub_Viettel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MN_Sub_Viettel.Click, MN_Sub_VNPT.Click
        Try
            Dim Index As Integer = IIf(sender.Name = "MN_Sub_Viettel", 0, 1)

            Select Case Index
                Case 0 ' viettel
                    FrmEINVoiceViettel.ShowDialog()
                    Exit Select
                Case 1 ' vnpt

                    Exit Select
            End Select
        Catch ex As Exception
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub labThaoTacNhanh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labThaoTacNhanh.Click
        Try
            If Me.PanelRight.Width > 15 Then
                Me.PanelRight.Width = 15
                Me.Panel_Right_LamViec.Visible = False
                labThaoTacNhanh.Text = ""
                Me.labThaoTacNhanh.Image = My.Resources.list16
            Else
                Me.PanelRight.Width = 220
                Me.Panel_Right_LamViec.Visible = True
                labThaoTacNhanh.Text = "THAO TÁC NHANH"
                Me.labThaoTacNhanh.Image = My.Resources.ket_chuyen_so_lieu_16
            End If
        Catch ex As Exception

        End Try
    End Sub
    ''' Tai menu vattu hang hoa
    Private Sub btnMenu_VatTuHangHoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu_VatTuHangHoa.Click
        Try
            Me.Panel_LamViec.Controls.Clear()
            Dim ucontrol As New uVatTuHangHoa()
            ucontrol.Dock = DockStyle.Fill
            Me.Panel_LamViec.Controls.Add(ucontrol)
        Catch ex As Exception
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' Tai menu tai san co dinh
    Private Sub btnMenu_TaiSanCoDinh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu_TaiSanCoDinh.Click
        Try
            Me.Panel_LamViec.Controls.Clear()
            Dim ucontrol As New uTaiSanCoDinh()
            ucontrol.Dock = DockStyle.Fill
            Me.Panel_LamViec.Controls.Add(ucontrol)
        Catch ex As Exception
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' tai menu cong cu dung cu
    Private Sub btnMenu_CongCuDungCu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu_CongCuDungCu.Click
        Try
            Me.Panel_LamViec.Controls.Clear()
            Dim ucontrol As New uCongCuDungCu()
            ucontrol.Dock = DockStyle.Fill
            Me.Panel_LamViec.Controls.Add(ucontrol)
        Catch ex As Exception
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' tai chi phi tong hop
    Private Sub btnMenu_ChiPhiTongHop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu_ChiPhiTongHop.Click
        Try
            Me.Panel_LamViec.Controls.Clear()
            Dim ucontrol As New uChiPhiTongHop()
            ucontrol.Dock = DockStyle.Fill
            Me.Panel_LamViec.Controls.Add(ucontrol)
        Catch ex As Exception
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' tai gia thanh
    Private Sub btnMenu_GiaThanh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu_GiaThanh.Click
        Try
            Me.Panel_LamViec.Controls.Clear()
            Dim ucontrol As New uGiaThanh()
            ucontrol.Dock = DockStyle.Fill
            Me.Panel_LamViec.Controls.Add(ucontrol)
        Catch ex As Exception
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' tai cong no
    Private Sub btnMenu_CongNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu_CongNo.Click
        Try
            Me.Panel_LamViec.Controls.Clear()
            Dim ucontrol As New uCongNo()
            ucontrol.Dock = DockStyle.Fill
            Me.Panel_LamViec.Controls.Add(ucontrol)
        Catch ex As Exception
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel_thongKe_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_thongKe.LinkClicked
        Try
            Me.Cursor = Cursors.WaitCursor
            
            Me.Panel_contain.Controls.Clear()
            menu_thongke.Dock = DockStyle.Fill
            Me.Panel_contain.Controls.Add(menu_thongke)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel_ThongTin_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_ThongTin.LinkClicked
        Try
            Me.Cursor = Cursors.WaitCursor

            Me.Panel_contain.Controls.Clear()
            menu_thongtin.Dock = DockStyle.Fill
            Me.Panel_contain.Controls.Add(menu_thongtin)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel_KiemTraCapNhat_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_KiemTraCapNhat.LinkClicked
        Try
            AutomaticUpdaterACtax.ForceCheckForUpdate(True)
        Catch ex As Exception
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AutomaticUpdaterACtax_ClosingAborted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutomaticUpdaterACtax.ClosingAborted

    End Sub

    Private Sub MN_Sub_HDThue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MN_Sub_HDThue.Click
        Try
            FrmHoaDonThue.ShowDialog()
        Catch ex As Exception
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
