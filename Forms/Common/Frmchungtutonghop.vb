Imports System
Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Media
Imports UNET.Utility
Imports System.Diagnostics
Imports System.Globalization
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter
Imports Microsoft.VisualBasic.Compatibility.VB6

Partial Friend Class FrmChungtutonghop
    Const TM As String = "111"
    Const NH As String = "112"
#Region "Khai báo"
    Public Shared ten_mua_hang As String = ""
    Public tuongkho As Integer
    Public MaSoCT As Integer
    Public Shared MaCT As String = ""
    Dim Ngay(1) As Date ' Ngày chứng từ
    Public Shared loaict As Integer ' Loại chứng từ
    Private _taikhoan As ClsTaikhoan = Nothing
    Private isInitializingComponent As Boolean

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
    End Property ' Tài khoản đang nhập phát sinh
    Private _vattu As ClsVattu = Nothing
    Public Property vattu() As ClsVattu
        Get
            If _vattu Is Nothing Then
                _vattu = New ClsVattu()
            End If
            Return _vattu
        End Get
        Set(ByVal Value As ClsVattu)
            _vattu = Value
        End Set
    End Property ' Vật tư đang được nhập phát sinh
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
    Private _tp As Cls154 = Nothing
    Property tp() As Cls154
        Get
            If _tp Is Nothing Then
                _tp = New Cls154()
            End If
            Return _tp
        End Get
        Set(ByVal Value As Cls154)
            _tp = Value
        End Set
    End Property
    Dim MaNhap As Integer
    Dim nhieunoco As Boolean
    Dim VTEnable As Boolean
    Dim KhongNhapTS As Boolean
    Dim SetLoaiEnable As Boolean
    Dim shct As String = String.Empty
    Dim xddu As Boolean
    Dim unc3, unc1, DiaChiBH, DiaChiNX, ctgoc, tentc, diachitc, TenNX, TenBH, MSTBH, unc2, mathuchi As String
    Dim MaKHBH As Integer
    Dim HanTT As Date
    Dim hd() As modHoadon.tpHoaDon = Nothing
    Dim hdcount As Integer
    Dim Ppunc, Ppthu, Ppchi, Phd As Integer
    Dim pVAT2, pVAT1, vBH As Integer
    Dim P_1, LC As Integer
    Dim MaTS(9) As Integer
    Dim tscount As Integer
    Dim pMaBG As Integer
    Dim pGhi As Integer
    Dim pRate As Double
    Dim bcstop As Integer
    Dim actax_soct As String = String.Empty
    Dim actax_masokh As String = String.Empty
    Dim actax_sohieukh As String = String.Empty
    Dim actax_diachi As String = String.Empty
    Dim actax_loai As Integer
    Dim MST As String = String.Empty
    Dim sokyphanbo As Integer
    Dim KTno As String = String.Empty
    Dim KTco As String = String.Empty
    Dim NoGoiCo As Integer
    Public initOption As Integer = -1
#End Region
    ''' set tab order index
    Private Sub setTabOrderIndex()
        Try
            CboThang.TabIndex = 0    'thang
            'ChkDanhgialai.TabIndex = 1   'danh gia lai
            Chk.TabIndex = 2 'bao gia
            _CboNguon_0.TabIndex = 3 'phan loai
            _MedNgay_0.TabIndex = 4 '(ngayCT)
            _MedNgay_1.TabIndex = 5  'ngay gi so
            _CboNguon_3.TabIndex = 6 'CT ghi so
            _txtchungtu_7.TabIndex = 7   'ty gia
            _txt_0.TabIndex = 8  'so chung tu
            _CmdDanhSach_0.TabIndex = 9  'tim chung tu
            _CmdDanhSach_1.TabIndex = 10  'tim chung tu TH
            _txt_4.TabIndex = 11  'phieu nhap/xuat
            _CboNguon_1.TabIndex = 12 'kho hang
            _txt_1.TabIndex = 13  'dien giai
            _txt_3.TabIndex = 14  'nhan vien ban hang
            _CboNguon_2.TabIndex = 15 'hop dong
            ChkTudong.TabIndex = 16   'tu dong nhap tai khoan
            CmdThemTK.TabIndex = 17   'them tai khoan
            _txt_2.TabIndex = 18  'tieng anh dien giai
            _CboVV_0.TabIndex = 19    'thong tin 1
            _CboVV_1.TabIndex = 20    'thong tin 2
            _CboVV_2.TabIndex = 21    'thong tin 3
            _txt_5.TabIndex = 22  'khach hang
            _txtchungtu_0.TabIndex = 23   'so hieu tai khoan
            _CboNT_3.TabIndex = 24    'dien dai1
            _txtchungtu_1.TabIndex = 25   'dien giai 2
            SSCmdV.TabIndex = 26  'xem in, hoac tai khoan
            _txtchungtu_2.TabIndex = 27   'ma so
            _CboNT_2.TabIndex = 28    'don vi tinh
            _txtchungtu_3.TabIndex = 29   'so luong
            _txtchungtu_11.TabIndex = 30  'phat sinh USD
            CboDoituong.TabIndex = 31  'doi tuong            
            _CboNT_1.TabIndex = 32    'don gia  
            _txtchungtu_4.TabIndex = 33 ' don gia            
            _txtchungtu_5.TabIndex = 34  'phat sinh no
            _txtchungtu_6.TabIndex = 35  'phat sinh co
            _txtchungtu_9.TabIndex = 36   'chiet khau
            _txtchungtu_10.TabIndex = 37 'tien chiet khau
            _txtchungtu_8.TabIndex = 38   'han thanh toan
            '_MedNgay_2.TabIndex = 39  'tinh tu ngay
            CmdChitiet.TabIndex = 40  'button chi tiet
            chkXT.TabIndex = 41  'xuat thang
            ChkHNT.TabIndex = 42 'tao phieu nhap thang
            _txtsh_0.TabIndex = 43    'ghi tai khoan
            _cmd_0.TabIndex = 44      'ghi no tai khoan button
            _txtsh_1.TabIndex = 45   'doi tuong
            _cmd_1.TabIndex = 46      'doi tuong button
            _Command_1.TabIndex = 47 'button ghi
            _Command_0.TabIndex = 48 'button them
            _Command_2.TabIndex = 49 'button xoa
            _Command_4.TabIndex = 50 'button xem in
            _Command_5.TabIndex = 51 'button dang ky hoa don
            _CmdPhieu_0.TabIndex = 52 'button 1 phieu TC
            _CmdPhieu_1.TabIndex = 53 'button 2 hoa don
            _CmdPhieu_2.TabIndex = 54 'button UNC
            CmdBC.TabIndex = 55    'button barcode
            _Command_3.TabIndex = 56 'button Thoat

            _OptLoai_0.TabIndex = 57  'tong hop option
            _OptLoai_4.TabIndex = 58 '(Reset)
            _OptLoai_1.TabIndex = 59 'nhap vat tu
            _OptLoai_9.TabIndex = 60 'tang tai san co dinh
            _OptLoai_13.TabIndex = 61 'tang ccdc
            _OptLoai_2.TabIndex = 62  'xuat vat tu
            _OptLoai_10.TabIndex = 63 'giam tscd
            _OptLoai_15.TabIndex = 64 'giam ccdc
            _OptLoai_8.TabIndex = 65 'ban hang
            _OptLoai_11.TabIndex = 66 'danh gia lai ta san
            '_OptLoai_16.TabIndex = 67 'danh gia lai ccdc
            _OptLoai_3.TabIndex = 68 'ket chuyen
            _OptLoai_12.TabIndex = 69 'khau hao tai san
            _OptLoai_14.TabIndex = 70 'phan bo ccdc
        Catch ex As Exception
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CboCo_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboCo.SelectedIndexChanged
        If OptNhap(2).Checked Then
            If loaict = 1 Or (loaict = 0 And (ConvertToDblSafe(loai1.Tag) = 0 Or ConvertToDblSafe(loaino.Tag) = 1)) Or loaict = 9 Or loaict = 13 Then
                txtchungtu(5).Enabled = False
                txtchungtu(6).Enabled = True
                txtchungtu(6).Text = ConvertToStrSafe(Math.Abs(SoPSConLai()))
            ElseIf loaict = 8 Or loaict = 2 Or (loaict = 0 And ConvertToDblSafe(loai1.Tag) = 1 And ConvertToDblSafe(loaino.Tag) = 0) Then
                txtchungtu(5).Enabled = True
                txtchungtu(5).Text = ConvertToStrSafe(Math.Abs(SoPSConLai()))
                txtchungtu(6).Enabled = False
            End If
            txtchungtu(0).Text = MaSo2SoHieu(ConvertToDblSafe((CboCo.SelectedValue)), "hethongtk")
            If CboCo.Items.Count > 0 Then
                If CboCo.SelectedIndex = CboCo.Items.Count - 1 Then
                    txtchungtu(0).Focus()
                Else
                    Taikhoantien()
                End If
            End If

        End If
        If CboCo.Items.Count > 0 Then
            KTco = MaSo2SoHieu(ConvertToDblSafe((CboCo.SelectedValue)), "hethongtk")
        End If
    End Sub

    Private Sub CboNo_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboNo.SelectedIndexChanged
        Dim TK As New ClsTaikhoan
        Dim Tk1 As New ClsTaikhoan
        If OptNhap(0).Checked Then
            If loaict = 1 Or (loaict = 0 And (ConvertToDblSafe(loai1.Tag) = 0 Or ConvertToDblSafe(loaino.Tag) = 1)) Then
                txtchungtu(5).Enabled = True
                txtchungtu(6).Enabled = False
            ElseIf loaict = 8 Or loaict = 2 Or (loaict = 0 And ConvertToDblSafe(loai1.Tag) = 1 And ConvertToDblSafe(loaino.Tag) = 0) Then
                txtchungtu(5).Enabled = False
                txtchungtu(6).Enabled = True
            End If
            If CboNo.Items.Count > 0 Then
                NoGoiCo = CboNo.SelectedValue
                txtchungtu(0).Text = MaSo2SoHieu(ConvertToDblSafe((CboNo.SelectedValue)), "hethongtk")
            End If

        ElseIf OptNhap(1).Checked Then
            If loaict = 1 Or (loaict = 0 And (ConvertToDblSafe(loai1.Tag) = 0 Or ConvertToDblSafe(loaino.Tag) = 1)) Or loaict = 9 Or loaict = 13 Then
                txtchungtu(5).Enabled = True
                txtchungtu(6).Enabled = False
            ElseIf loaict = 8 Or (loaict = 0 And ConvertToDblSafe(loai1.Tag) = 1 And ConvertToDblSafe(loaino.Tag) = 0) Then
                txtchungtu(5).Enabled = False
                txtchungtu(6).Enabled = True
            End If
            If loaict = 1 Or (loaict = 0 And (ConvertToDblSafe(loai1.Tag) = 0 Or ConvertToDblSafe(loaino.Tag) = 1)) Or loaict = 9 Or loaict = 13 Then
                TK.InitTaikhoanSohieu("133")
            ElseIf loaict = 8 Or (loaict = 0 And ConvertToDblSafe(loai1.Tag) = 1 And ConvertToDblSafe(loaino.Tag) = 0) Then
                TK.InitTaikhoanSohieu("333")
            End If
            Tk1.InitTaikhoanMaSo(TKChitiet(ConvertToDblSafe((TK.maso))))
            While TK.sohieu <> Tk1.sohieu
                TK.InitTaikhoanMaSo(ConvertToDblSafe((Tk1.maso)))
                Tk1.InitTaikhoanMaSo(TKChitiet(ConvertToDblSafe((TK.maso))))
            End While
            txtchungtu(0).Text = TK.sohieu
            txtchungtu(2).Text = Strings.Left(CboNo.Text, Strings.Len(CboNo.Text) - 1)
            _txtchungtu_LostFocus(txtchungtu(ConvertToDblSafe("0")), New EventArgs())
        End If
        If OptNhap(0).Checked Then
            If CboNo.Items.Count > 0 Then
                If CboNo.SelectedIndex = CboNo.Items.Count - 1 Then
                    txtchungtu(0).Focus()
                Else
                    Taikhoantien()
                End If
            End If

        Else
            _txtchungtu_LostFocus(txtchungtu(ConvertToDblSafe("0")), New EventArgs())
        End If
        If OptNhap(0).Checked And loaict = 0 Then
            If CboNo.Items.Count > 0 Then
                KTno = MaSo2SoHieu(ConvertToDblSafe((CboNo.SelectedValue)), "hethongtk")
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Taikhoantien()
        _txtchungtu_LostFocus(txtchungtu(ConvertToDblSafe("0")), New EventArgs())
        If txtchungtu(2).Enabled Then
            txtchungtu(2).Focus()
        Else
            If txtchungtu(5).Enabled Then
                txtchungtu(5).Focus()
            Else
                txtchungtu(6).Focus()
            End If
        End If
        '    If timten("loai", txtchungtu(0).Text, "sohieu", "hethongtk") = 1 And timten("tk_id", txtchungtu(0).Text, "sohieu", "hethongtk") = 0 Then
        '        If loaict = 1 Then
        '            RFocus txtchungtu(6)
        '        ElseIf loaict = 8 Then
        '            RFocus txtchungtu(5)
        '        ElseIf loaict = 0 Then
        '            If OptNhap(0).Value = True Then
        '                RFocus txtchungtu(5)
        '            Else
        '                RFocus txtchungtu(6)
        '            End If
        '        End If
        '    End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboNT_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _CboNT_3.SelectedIndexChanged, _CboNT_2.SelectedIndexChanged, _CboNT_1.SelectedIndexChanged, _CboNT_0.SelectedIndexChanged
        Dim Index As Integer = Array.IndexOf(CboNT, eventSender)
        Dim tien, hsqd, gia, luong, tien2 As Double
        Select Case Index
            Case 0
                If CboNT(0).SelectedIndex = 0 Then
                    txtchungtu(2).Tag = "0"
                    txtchungtu(3).Text = "0"
                    txtchungtu(3).Enabled = False
                    txtchungtu(4).Text = "0"
                Else
                    txtchungtu(2).Tag = "1"
                    txtchungtu(3).Enabled = True
                    txtchungtu(4).Enabled = True
                    If pTyGiaBQ = 0 Then
                        txtchungtu(4).Text = Format(TyGiaNT(CboNT(0).SelectedValue), Mask_0)
                    Else
                        txtchungtu(4).Text = Format(TyGiaBQ(taikhoan.sohieu, CboNT(0).SelectedValue, Ngay(0)), Mask_0)
                    End If
                End If
            Case 1
                txtchungtu(4).Text = CboNT(1).Text
                _txtchungtu_LostFocus(txtchungtu(4), New EventArgs())
            Case 2
                If vattu.MaSo > 0 Then
                    txtchungtu(1).Text = String.Format("{0} - {1}{2}", vattu.TenVattu, ("Đ.v.t: "), CboNT(2).Text)
                    gia = GiaBanQD(CboNT(2).SelectedValue, hsqd)
                    If hsqd = 0 Then hsqd = 1
                    'If OutCost = 0 Then
                    luong = SoTonKho(CboThang.SelectedValue, CboNT(1).SelectedValue, 0, vattu.MaSo, tien, tien2)
                    luong /= hsqd
                    txtchungtu(3).Text = Format(luong, Mask_2)
                    txtchungtu(3).Tag = ConvertToStrSafe(luong)
                    txtchungtu(6).Text = Format(tien, Mask_0)
                    If pGiaUSD > 0 Then txtchungtu(11).Text = Format(tien2, Mask_2)
                    txtchungtu(6).Tag = ConvertToStrSafe(tien)
                    txtchungtu(5).Tag = ConvertToStrSafe(tien2)
                    If luong <> 0 Then
                        If pGiaUSD > 0 Then
                            txtchungtu(4).Text = Format((IIf(0.5 + Mask_N * tien2 / luong > 0, Math.Floor(0.5 + Mask_N * tien2 / luong), Math.Ceiling(0.5 + Mask_N * tien2 / luong))) / Mask_N, Mask_2)
                        Else
                            txtchungtu(4).Text = Format((IIf(0.5 + Mask_N * tien / luong > 0, Math.Floor(0.5 + Mask_N * tien / luong), Math.Ceiling(0.5 + Mask_N * tien / luong))) / Mask_N, Mask_2)
                        End If
                    End If
                    'End If
                    If CboNT(2).SelectedIndex > 0 Then
                        If gia > 0 Then
                            txtchungtu(4).Text = Format(gia, Mask_2)
                            CboNT(1).Text = txtchungtu(4).Text
                        Else
                            If luong <> 0 Then gia = tien / luong
                            If gia > 0 Then
                                txtchungtu(4).Text = Format(gia, Mask_2)
                                CboNT(1).Text = txtchungtu(4).Text
                            End If
                        End If
                    Else
                        If CboNT(1).Items.Count > 0 Then CboNT(1).SelectedIndex = 0
                    End If
                    HienThongBao(String.Format("Số lượng tồn kho: {0} - Thành tiền: {1}", txtchungtu(3).Text, Format(ConvertToStrSafe(txtchungtu(6).Tag), Mask_0)), 1)
                End If
            Case 3
                If CboNT(3).SelectedIndex > 0 Then
                    If ConvertToDblSafe((CboNT(3).Tag)) = 1 Then
                        txtchungtu(2).Text = MaSo2SoHieu(CboNT(3).SelectedValue, "Vattu")
                    Else
                        txtchungtu(2).Text = MaSo2SoHieu(CboNT(3).SelectedValue, "KhachHang")
                    End If
                    _txtchungtu_LostFocus(txtchungtu(2), New EventArgs())
                End If
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboNguon_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _CboNguon_3.SelectedIndexChanged, _CboNguon_2.SelectedIndexChanged, _CboNguon_1.SelectedIndexChanged, _CboNguon_0.SelectedIndexChanged
        Dim Index As Integer = Array.IndexOf(CboNguon, eventSender)
        Select Case Index
            Case 1
                If loaict = 2 Then
                    MaSoCT = 0
                    ClearGrid(GrdChungtu, ConvertToDblSafe(GrdChungtu.Tag))
                    If vattu.MaSo > 0 Then _txtchungtu_LostFocus(txtchungtu(2), New EventArgs())
                End If
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboNT_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _CboNT_3.KeyPress, _CboNT_2.KeyPress, _CboNT_1.KeyPress, _CboNT_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(CboNT, eventSender)
        If Index = 3 Then
            Select Case KeyAscii
                Case 13
                    CboNT_Leave(CboNT(3), New EventArgs())
                Case 32
                    LaySohieuDoiTuong2(ConvertToDblSafe(CboNT(3).Tag), CboNT(3).Text)
                    KeyAscii = 0
            End Select
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
    Private Sub CboNT_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _CboNT_3.Leave, _CboNT_2.Leave, _CboNT_1.Leave, _CboNT_0.Leave
        Dim Index As Integer = Array.IndexOf(CboNT, eventSender)
        Dim sh As String = String.Empty
        Select Case Index
            Case 1
                txtchungtu(4).Text = CboNT(1).Text
                _txtchungtu_LostFocus(txtchungtu(4), New EventArgs())
            Case 3
                If CboNT(3).SelectedIndex < 0 Then SetListIndex2(CboNT(3), CboNT(3).Text)
                If CboNT(3).SelectedIndex >= 0 Then
                    txtchungtu(2).Text = ConvertToStrSafe(GetSelectValue(String.Format("SELECT SoHieu AS F1 FROM {0} WHERE MaSo={1}", (IIf(ConvertToDblSafe((CboNT(3).Tag)) = 1, "Vattu", "KhachHang")), ConvertToStrSafe(CboNT(3).SelectedValue))))
                    _txtchungtu_LostFocus(txtchungtu(2), New EventArgs())
                Else
                    If CboNT(3).Text <> "" Then
                        Select Case ConvertToStrSafe(CboNT(3).Tag)
                            Case "1"
                                sh = FrmVattu.ThemVattu(CboNT(3).Text)
                            Case "2"
                                sh = FrmKhachHang.ThemKhachHang(CboNT(3).Text)
                        End Select
                        CboNT(3).Text = sh
                        LaySohieuDoiTuong2(ConvertToDblSafe(CboNT(3).Tag), CboNT(3).Text)
                    End If
                End If
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboThang_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboThang.SelectedIndexChanged
        If loaict = 2 Or loaict = 6 Then
            ClearGrid(GrdChungtu, ConvertToDblSafe(GrdChungtu.Tag))
            MaSoCT = 0
            If vattu.MaSo > 0 Then _txtchungtu_LostFocus(txtchungtu(2), New EventArgs())
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboVV_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _CboVV_2.SelectedIndexChanged, _CboVV_1.SelectedIndexChanged, _CboVV_0.SelectedIndexChanged
        Dim Index As Integer = Array.IndexOf(CboVV, eventSender)
        If Index = 0 Then CboVVClick(CboVV(0), CboVV(1))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Chk_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Chk.CheckStateChanged
        txt_Leave(txt(0), New EventArgs())
        CmdPhieu(1).Text = IIf(Chk.CheckState = CheckState.Checked, Ngonngu("&2 Báo giá", "&2 Quotes"), Ngonngu("&2 Hoá đơn", "&2 Invoice"))
        CmdPhieu(1).Tag = ConvertToStrSafe(Chk.CheckState)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub ChkDoiTuong_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles ChkDoiTuong.CheckStateChanged
        CboDoituong.Visible = ChkDoiTuong.CheckState = CheckState.Checked
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub ChkHNT_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles ChkHNT.CheckStateChanged
        If ChkHNT.CheckState Then
            CboThang1.Visible = True
            chkXT.CheckState = CheckState.Unchecked
            chkXT.Visible = False
        Else
            chkXT.Visible = True
            CboThang1.Visible = False
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub NhapCbo()
        If Not (_OptLoai_9.Checked Or _OptLoai_13.Checked) Then
            For i As Integer = 0 To 2
                If OptNhap(i).Checked Then
                    OptNhap_CheckedChanged(OptNhap(i), New EventArgs()) : Exit For
                End If
            Next
        Else
            For i As Integer = 1 To 2
                If OptNhap(i).Checked Then
                    OptNhap_CheckedChanged(OptNhap(i), New EventArgs()) : Exit For
                End If
            Next
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub ChkTudong_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles ChkTudong.CheckStateChanged
        OptNhap(2).Text = "Thanh toán"
        If ChkTudong.CheckState = CheckState.Checked Then
            If _OptLoai_1.Checked Then
                Label(26).Text = "Phát sinh nợ"
                Label(27).Text = "Phát sinh có"
                OptNhap(0).Text = "Hàng nhập"
                FNhap.Visible = True
                OptNhap(0).Checked = True
                NhapCbo()
                FNhap.Refresh()
            ElseIf _OptLoai_8.Checked Then
                Label(26).Text = "Phát sinh có"
                Label(27).Text = "Phát sinh nợ"
                OptNhap(0).Text = "Hàng bán"
                FNhap.Visible = True
                OptNhap(0).Checked = True
                NhapCbo()
                FNhap.Refresh()
            ElseIf _OptLoai_2.Checked Then
                Label(26).Text = "Phát sinh có"
                Label(27).Text = "Phát sinh nợ"
                OptNhap(0).Text = "Hàng xuất"
                FNhap.Visible = True
                OptNhap(0).Checked = True
                NhapCbo()
                FNhap.Refresh()
            ElseIf _OptLoai_0.Checked Then
                Label(26).Text = "Phát sinh nợ"
                Label(27).Text = "Phát sinh có"
                OptNhap(0).Text = "Công nợ"
                If ConvertToDblSafe(loai1.Tag) = 0 Then
                    OptNhap(0).Text = "Chi phí"
                ElseIf ConvertToDblSafe(loaino.Tag) = 0 Then
                    Label(26).Text = "Phát sinh có"
                    Label(27).Text = "Phát sinh nợ"
                    OptNhap(2).Text = "Thu Nợ"
                Else
                    OptNhap(2).Text = "Trả nợ"
                End If
                FNhap.Visible = True
                OptNhap(0).Checked = True
                NhapCbo()
                FNhap.Refresh()
            ElseIf _OptLoai_9.Checked Or _OptLoai_13.Checked Then
                Label(26).Text = "Phát sinh nợ"
                Label(27).Text = "Phát sinh có"
                OptNhap(0).Visible = False
                FNhap.Visible = True
                OptNhap(1).Checked = True
                NhapCbo()
                FNhap.Refresh()
            Else
                FNhap.Visible = False
            End If
        Else
            FNhap.Visible = False
            txtchungtu(5).Enabled = True
            txtchungtu(6).Enabled = True
        End If
        CmdThemTK.Visible = FNhap.Visible
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub chkXT_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles chkXT.CheckStateChanged
        Frame.Visible = (chkXT.CheckState = CheckState.Checked)
        If chkXT.CheckState = CheckState.Checked Then
            ChkHNT.CheckState = CheckState.Unchecked
            ChkHNT.Visible = False
        Else
            ChkHNT.Visible = True
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmd_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _cmd_0.Click, _cmd_1.Click
        Dim Index As Integer = Array.IndexOf(cmd, eventSender)
        Select Case Index
            Case 0
                FrmTaikhoan.initOption = txtsh(0).Text
                txtsh(0).Text = FrmTaikhoan.ChonTk(txtsh(0).Text)
                txtsh(0).Focus()
            Case 1
                If ConvertToDblSafe((cmd(0).Tag)) = 1 Then
                    txtsh(1).Text = FrmKhachHang.ChonKhachHang(txtsh(1).Text)
                    txtsh(1).Focus()
                ElseIf ConvertToDblSafe((cmd(0).Tag)) = 2 Then
                    txtsh(1).Text = FrmTP.ChonTP(txtsh(1).Text)
                    txtsh(1).Focus()
                ElseIf ConvertToDblSafe((cmd(0).Tag)) = 3 Then
                    FrmTaikhoan.initOption = txtsh(1).Text
                    txtsh(1).Text = FrmTaikhoan.ChonTk(txtsh(1).Text)
                    txtsh(1).Focus()
                End If
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CmdBC_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CmdBC.Click
        LayXuatKho(loaict)
    End Sub
    ''' <summary>
    ''' Ghi dòng phát sinh vào Grid
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub CmdChitiet_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CmdChitiet.Click
        Dim tien, no, co, tien1 As Double
        Dim i As Integer
        Dim shnt As String = String.Empty
        Dim m As Integer
        Dim c, n, X As Double
        Dim ctgg As Boolean
        Dim dvt As Integer
        Dim sott As Integer
        Dim mct1(0) As Integer
        Dim tien1x(0) As Double
        Dim msk As String = IIf(taikhoan.sohieu Like "007*", Mask_2, Mask_0)
        Dim thang As Integer = Nothing
        If CboThang.Items.Count > 0 Then
            thang = CboThang.SelectedValue
        End If
        Dim nt As Double = ConvertToDblSafe(txtchungtu(3).Text)
        If taikhoan.sohieu Like "007*" And pTien = 0 Then
            no = IIf(ConvertToDblSafe(txtchungtu(5).Text) > 0, Math.Floor(ConvertToDblSafe(txtchungtu(5).Text)), Math.Ceiling(ConvertToDblSafe(txtchungtu(5).Text)))
            co = IIf(ConvertToDblSafe(txtchungtu(6).Text) > 0, Math.Floor(ConvertToDblSafe(txtchungtu(6).Text)), Math.Ceiling(ConvertToDblSafe(txtchungtu(6).Text)))
        Else
            no = ConvertToDblSafe(txtchungtu(5).Text)
            co = ConvertToDblSafe(txtchungtu(6).Text)
        End If
        If taikhoan.maso = 0 Or taikhoan.tkcon > 0 Then
            ErrMsg(er_SHTaiKhoan1)
            txtchungtu(0).Focus()
            Exit Sub
        End If
        If pPQTK > 0 Then
            If Not taikhoan.ChoNhap() Then
                myUMessager.mError(Ngonngu("Chưa đăng ký người sử dụng cho tài khoản này!", "Uregistered users for this account"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtchungtu(0).Focus()
                GoTo kt
            End If
        End If
        If cuongktluuccdc = 0 Then
            If (loaict <> 1 And loaict <> 2 And loaict <> 4) And (taikhoan.tk_id = TKVT_ID) And STDetail Then
                myUMessager.mError(Ngonngu("Không nhập trực tiếp phát sinh cho tài khoản vật tư, hàng hóa. Hãy vào phân hệ vật tư hàng hóa !", "Not enter directly incurred for the account of material and goods. Go to the module material and goods !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtchungtu(0).Focus()
                Exit Sub
            End If
        End If
        If (loaict = 1) And (taikhoan.tk_id = TKVT_ID) And (co <> 0) And txtchungtu(0).Text <> "157" Then
            myUMessager.mError(Ngonngu("Ghi phát sinh nợ khi nhập vật tư !", "Remember the debt incurred when importing materials !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtchungtu(5).Focus()
            Exit Sub
        End If
        If pDTTP <> 0 And (taikhoan.sohieu Like "1541*" Or taikhoan.sohieu Like "1542*" Or taikhoan.sohieu Like "1543*" Or taikhoan.sohieu Like "627*") And (tp.MaSo = 0) Then
            tp.InitTPSohieu(FrmGetStr.GetString(Ngonngu("Nhập mã công trình sản phẩm (nếu có)?", "Enter product code works (if any)"), My.Application.Info.ProductName))
            txtchungtu(2).Text = tp.SoHieu
            _txtchungtu_LostFocus(txtchungtu(2), New EventArgs())
            '        If MessageBox.Show("Không có mã số công trình, tiếp tục?", App.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbNo Then
            '            RFocus txtchungtu(2)
            '            Exit Sub
            '        End If
        End If
        If pDTTP <> 0 And (taikhoan.sohieu Like "621*" Or taikhoan.sohieu Like "622*" Or taikhoan.sohieu Like "623*" Or taikhoan.sohieu Like "627*") And (tp.MaSo > 0) Then
            If tp.SoDT(pThangDauKy, thang) > 0 And tp.GiaThanhCK(thang) = 0 And tp.ChiPhiTP(thang) > 0 Then
                If myUMessager.mQuestion(Ngonngu("Công trình hoặc sản phẩm đã kết chuyển giá thành, tiếp tục?", "The product works or forward prices, continue?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.No Then
                    txtchungtu(5).Focus()
                    Exit Sub
                End If
            End If
        End If
        If (loaict = 2) And (taikhoan.tk_id = TKVT_ID) And (no <> 0) And (vattu.MaSo > 0) And txtchungtu(0).Text <> "157" Then
            myUMessager.mError(Ngonngu("Ghi phát sinh có khi xuất vật tư !", "Remember the credit incurred when importing materials"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtchungtu(6).Focus()
            Exit Sub
        End If
        If (loaict = 1 Or loaict = 2) And (taikhoan.tk_id = TKVT_ID And vattu.MaSo = 0) And STDetail Then
            ErrMsg(er_SHVattu)
            txtchungtu(2).Focus()
            Exit Sub
        End If
        If (taikhoan.tk_id = TKCNKH_ID Or taikhoan.tk_id = TKCNPT_ID) And ckh.MaSo = 0 And KHDetail Then
            ErrMsg(er_SHKhachHang)
            txtchungtu(2).Focus()
            Exit Sub
        End If
        If (loaict = 2 Or loaict = 8) And (vattu.MaSo > 0) And (co >= 0) And (nt > ConvertToDblSafe((txtchungtu(3).Tag))) And STDetail And taikhoan.sohieu Like "5113*" And Chk.CheckState = CheckState.Unchecked And Me.Visible Then
            If FrmOptions.Check(39).CheckState Then
                myUMessager.mWarning(Ngonngu("Đã xuất quá lượng tồn! Tiếp tục ?", "Goods exceeds the number of survival! Continue?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                txtchungtu(3).Focus()
                Exit Sub
            Else
                If myUMessager.mQuestion(Ngonngu("Đã xuất quá lượng tồn! Tiếp tục ?", "Goods exceeds the number of survival! Continue?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> System.Windows.Forms.DialogResult.Yes Then
                    txtchungtu(3).Focus()
                    Exit Sub
                End If
            End If
        End If
        If (loaict = 2) And (taikhoan.tk_id = TKVT_ID) And (ConvertToDblSafe((txtchungtu(3).Tag)) = 0 And ConvertToDblSafe((txtchungtu(6).Tag)) = 0) And (nt = 0) And STDetail Then
            If myUMessager.mQuestion(Ngonngu("Vật tư không có tồn kho! Tiếp tục ?", "No inventory material! Continue?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> System.Windows.Forms.DialogResult.Yes Then
                txtchungtu(2).Focus()
                Exit Sub
            End If
        End If
        If (loaict = 1 Or loaict = 2) And (taikhoan.tk_id = TKVT_ID) And (vattu.TonMin > 0 Or vattu.TonMax > 0) And STDetail Then
            If (loaict = 1) And (vattu.TonMax > 0) And (ConvertToDblSafe((txtchungtu(3).Tag)) + nt > vattu.TonMax) Then
                If myUMessager.mQuestion(Ngonngu("Đã nhập quá lượng tồn kho tối đa cho phép! Tiếp tục ?", "Goods execeeds the maximum number exists! Continue?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> System.Windows.Forms.DialogResult.Yes Then
                    txtchungtu(3).Focus()
                    Exit Sub
                End If
            End If
            If (loaict = 2) And (vattu.TonMin > 0) And (ConvertToDblSafe((txtchungtu(3).Tag)) - nt < vattu.TonMin) Then
                If myUMessager.mQuestion(Ngonngu("Đã nhập quá lượng tồn kho tối thiểu cho phép! Tiếp tục ?", "Goods execeeds the minimum number exists! Continue?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> System.Windows.Forms.DialogResult.Yes Then
                    txtchungtu(3).Focus()
                    Exit Sub
                End If
            End If
        End If
        If pVAT2 > 0 And loaict = 8 And vattu.MaSo > 0 And vBH > 0 And vattu.VAT > 0 And vBH <> vattu.VAT Then
            If myUMessager.mQuestion(Ngonngu("Mặt hàng không cùng thuế suất VAT! Tiếp tục ?", "Goods are not the same VAT rate! Continue?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> System.Windows.Forms.DialogResult.Yes Then
                txtchungtu(2).Focus()
                Exit Sub
            End If
        End If
        If KhongNhapTS And FADetail And (taikhoan.tk_id = TSCD_ID Or taikhoan.tk_id = KHTSCD_ID) Then
            myUMessager.mInformation(Ngonngu("Không nhập trực tiếp phát sinh vào tài khoản TSCĐ !", "Not enter directly into account arises. Goto the fixed assets module!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtchungtu(0).Focus()
            Exit Sub
        End If
        If taikhoan.MaNT <> 0 And CboNT(0).SelectedIndex >= 0 Then
            shnt = CboNT(0).Text
            taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(MaTKNguyenTe(taikhoan.sohieu, CboNT(0).SelectedValue)))
        Else
            shnt = txtchungtu(2).Text
        End If
        ' Kiểm tra chi tiết đã có phát sinh ?
        If taikhoan.tk_id <> TSCD_ID And taikhoan.tk_id <> TKDT_ID And taikhoan.tk_id <> GTGTKT_ID And taikhoan.tk_id <> GTGTPN_ID And tp.MaSo = 0 Then
            With GrdChungtu
                For i = 0 To .Rows - 1
                    .Row = i
                    .Col = 8
                    If .Items(.Row).SubItems(.Col).Text.length = 0 Then Exit For
                    If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = taikhoan.maso And Not (taikhoan.sohieu Like "1422*") And Not (taikhoan.sohieu Like "1423*") Then
                        .Col = 18
                        If (vattu.MaSo = 0 And ckh.MaSo = 0) And (ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) < 0) And taikhoan.loai <> 6 And cuongccdc.Length = 0 Then
                            myUMessager.mError(Ngonngu("Chi tiết đã có phát sinh trong chứng từ !", "Details have arisen in the voucher !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtchungtu(0).Focus()
                            Exit Sub
                        End If
                    End If
                Next
            End With
        End If
        If (no = 0 And taikhoan.tk_id <> GTGTKT_ID And taikhoan.tk_id <> TKVT_ID) And (co = 0 And taikhoan.tk_id <> GTGTPN_ID And taikhoan.tk_id <> TKVT_ID And taikhoan.tk_id <> TKDT_ID And taikhoan.sohieu Like "33332*") Then
            myUMessager.mError(Ngonngu("Thiếu số phát sinh !", "Lack of arising !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtchungtu(5).Focus()
            Exit Sub
        End If
        If no <> 0 And co <> 0 Then
            myUMessager.mError(Ngonngu("Chỉ ghi phát sinh nợ hoặc có !", "Record debts incurred or credit arising !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtchungtu(5).Focus()
            Exit Sub
        End If
        taikhoan.KtraPhatsinh(thang, IIf(no > 0, no, co), IIf(no > 0, -1, 1))
        If co > 0 And ((taikhoan.sohieu.Substring(0, TM.Length) = TM) Or (taikhoan.sohieu.Substring(0, NH.Length) = NH)) Then
            taikhoan.SoDuNgay(Ngay(0), n, c, X)
            If n - c < co Then
                If myUMessager.mQuestion(Ngonngu("Chi vượt số dư! Tiếp tục ?", "Overspent balance! Continue ?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> System.Windows.Forms.DialogResult.Yes Then
                    txtchungtu(6).Focus()
                    Exit Sub
                End If
            End If
        End If
        If (taikhoan.tk_id = TKCNKH_ID Or taikhoan.tk_id = TKCNPT_ID) And ckh.MaSo > 0 And Strings.Left(ckh.SoHieu, 1) = "#" Then
            myUMessager.mWarning(Ngonngu("Không nhập phát sinh cho khách vãng lai!", "Entry not arise for visitors!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtchungtu(2).Focus()
            Exit Sub
        End If
        If ckh.MaSo > 0 And ((no > 0 And taikhoan.tk_id = TKCNKH_ID) Or (co > 0 And taikhoan.tk_id = TKCNPT_ID)) Then
            Label(22).Enabled = True
            txtchungtu(8).Enabled = True
        End If
        If ckh.MaSo > 0 And no > 0 And ckh.DuMax > 0 And taikhoan.tk_id = TKCNKH_ID Then
            ckh.SoDuKH(ThangCuoiNamTC(), n, c, X)
            If n - c + no > ckh.DuMax Then
                If MessageBox.Show(Ngonngu("Vượt quá hạn mức số dư! Tiếp tục ?", "exceed the balance! Continue ?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) <> System.Windows.Forms.DialogResult.Yes Then
                    txtchungtu(5).Focus()
                    Exit Sub
                End If
            End If
        End If
        Dim MaTkNo As Integer
        If taikhoan.sohieu.Substring(0, TM.Length) = TM Then
            If co > 0 Then FThuChi.Tag = "1"
            If MaSoCT = 0 And hdcount >= 0 And tentc = "..." Then
                tentc = hd(0).TenKH
                diachitc = hd(0).DiaChiKH
            Else
                MaTkNo = ConvertToDblSafe((Timten("maso", "133111", "sohieu", "hethongtk")))
                If MaTkNo = 0 Then MaTkNo = ConvertToDblSafe((Timten("maso", "13311", "sohieu", "hethongtk")))
                If MaTkNo = 0 Then MaTkNo = ConvertToDblSafe((Timten("maso", "1331", "sohieu", "hethongtk")))
                ckh.InitKhachHangMaSo(ConvertToDblSafe(Timten("makhachhang", ConvertToStrSafe(GetSelectValue(String.Format("select maso as f1 from chungtu where mact={0} and matkno={1}", _
                                                                                                                 MaSoCT, _
                                                                                                                 ConvertToStrSafe(MaTkNo)))), "maso", "hoadon")))
                If ckh.MaSo <> 0 Then
                    tentc = ckh.Ten
                    diachitc = ckh.DiaChi
                    MaKHBH = ckh.MaSo
                End If
            End If
            If ctgoc <> Nothing Then
                ctgoc = Me.txt(0).Text
            Else
                If ctgoc.Length = 0 Or ctgoc = "..." Then ctgoc = Me.txt(0).Text
            End If
            FThuChi.GetPhieu(tentc, diachitc, ctgoc, MaKHBH, , , False, False, False, False, False, False, 0, ConvertToDblSafe((MaSoCT)), ConvertToDblSafe((ConvertToDblSafe(txtchungtu(5).Text))), ConvertToDblSafe((CboThang.SelectedValue)), mathuchi)
            CmdPhieu(0).Visible = True
        End If
        If taikhoan.sohieu.Substring(0, NH.Length) = NH Then
            If co > 0 Then FThuChi.Tag = "1"
            If MaSoCT = 0 And hdcount >= 0 And tentc = "..." Then
                tentc = hd(0).TenKH
                diachitc = hd(0).DiaChiKH
            End If
            FThuChi.GetPhieu(tentc, diachitc, ctgoc, MaKHBH)
            CmdPhieu(3).Visible = True
        End If
        If (taikhoan.sohieu.Substring(0, NH.Length) = NH Or taikhoan.tk_id2 = ConvertToDblSafe(NH)) And co > 0 Then
            FThuChi.Tag = "2"
            If MaSoCT = 0 And hdcount >= 0 And unc1 = "..." Then
                unc1 = hd(0).TenKH
            End If
            FThuChi.GetPhieu(unc1, unc2, unc3, MaKHBH)
            CmdPhieu(2).Tag = taikhoan.sohieu
            CmdPhieu(2).Visible = True
        End If
        ctgg = CTGiamGia()
        If (taikhoan.tk_id = TKVT_ID Or taikhoan.tk_id = TKDT_ID Or taikhoan.tk_id = TSCD_ID Or taikhoan.tk_id = TKGT_ID) Then
            CmdPhieu(1).Visible = True
            CmdPhieu(1).Enabled = (GetSelectValue("select VT as f1 from users where maso=" + CStr(UserID)) Mod 10000000000) \ 1000000000 = 1
        End If
        Dim dong, cot As Integer
        If ((taikhoan.tk_id = GTGTKT_ID And no <> 0) Or ((taikhoan.tk_id = GTGTPN_ID Or taikhoan.tk_id = TTDB_ID) And co <> 0) Or ((taikhoan.tk_id = GTGTKT_ID Or taikhoan.tk_id = GTGTPN_ID) And no = 0 And co = 0) Or (ctgg And no <> 0 And taikhoan.tk_id = GTGTPN_ID)) And pNoiBo = CheckState.Unchecked Then
            stuHoadon.TyLe = ConvertToDblSafe(txtchungtu(2).Text)
            If stuHoadon.MaSo = 0 Then
                If ConvertToDblSafe(CmdChitiet.Tag) >= 0 Then
                    stuHoadon.loai = IIf(taikhoan.tk_id = GTGTKT_ID Or taikhoan.sohieu Like "33312*", -1, (IIf(taikhoan.tk_id = TTDB_ID, 2, 1)))
                Else
                    If hdcount >= 0 And stuHoadon.MaKhachHang = 0 Then
                        stuHoadon.MaKhachHang = hd(hdcount).MaKhachHang
                        stuHoadon.MauSo = hd(hdcount).MauSo
                        stuHoadon.KyHieu = hd(hdcount).KyHieu
                        stuHoadon.sohd = hd(hdcount).sohd
                        stuHoadon.NgayPH = hd(hdcount).NgayPH
                        stuHoadon.tygia = hd(hdcount).tygia
                    Else
                        If taikhoan.tk_id = GTGTPN_ID Then
                            stuHoadon.MauSo = ConvertToStrSafe(GetSelectValue("SELECT TOP 1 MauSo AS F1, NgayPH FROM HoaDon WHERE Loai=1 ORDER BY NgayPH DESC"))
                            stuHoadon.KyHieu = ConvertToStrSafe(GetSelectValue("SELECT TOP 1 KyHieu AS F1, NgayPH FROM HoaDon WHERE Loai=1 ORDER BY NgayPH DESC"))
                        End If
                    End If
                    stuHoadon.sohd = txt(0).Text
                    If loaict = 0 Then
                        stuHoadon.MatHang = txt(1).Text
                    Else
                        Try
                            If Not CPGV.Visible Then
                                dong = GrdChungtu.Row
                                cot = GrdChungtu.Col
                                GrdChungtu.Row = 0
                                GrdChungtu.Col = 2
                                If GrdChungtu.Rows > 0 Then stuHoadon.MatHang = GrdChungtu.Items(GrdChungtu.Row).SubItems(GrdChungtu.Col).Text
                                GrdChungtu.Row = dong
                                GrdChungtu.Col = cot
                            Else
                                dong = CPGV.Grd.Row
                                cot = CPGV.Grd.Col
                                CPGV.Grd.Row = 0
                                CPGV.Grd.Col = 1
                                stuHoadon.MatHang = CPGV.Grd.Items(CPGV.Grd.Row).SubItems(CPGV.Grd.Col).Text
                                CPGV.Grd.Row = dong
                                CPGV.Grd.Col = cot
                            End If
                        Catch

                        End Try
                    End If
                    If stuHoadon.TyLe > 0 Then
                        tien = IIf(taikhoan.tk_id = GTGTKT_ID, (no - co), (co - no))
                        If taikhoan.tk_id = GTGTKT_ID Or taikhoan.tk_id = GTGTPN_ID Then
                            If stuHoadon.TyLe > 0 And stuHoadon.TyLe < 5 Then
                                tien = 100 * tien / stuHoadon.TyLe - tien
                            Else
                                tien = 100 * tien / stuHoadon.TyLe
                            End If
                            tien = RoundMoney(tien)
                            tien1 = GiaTriTruocThue()
                            If (pTien = 0 And Math.Abs(tien - tien1) < 1000) Or (pTien > 0 And Math.Abs(tien - tien1) < 0.1) Then
                                stuHoadon.ThanhTien = GiaTriTruocThue()
                            Else
                                stuHoadon.ThanhTien = tien
                            End If
                        Else
                            tien1 = GiaTriTruocThue()
                            stuHoadon.ThanhTien = tien1 - tien
                        End If
                    Else
                        stuHoadon.ThanhTien = GiaTriTruocThue()
                    End If
                    If CPGV.Visible Then stuHoadon.ThanhTien -= ConvertToDblSafe(CPGV.CP.Text)
                    stuHoadon.NgayPH = Ngay(0)
                    stuHoadon.MaSo = hdcount + 1
                    If taikhoan.tk_id = TTDB_ID Then FVAT.Tag = ConvertToStrSafe(tien1)
                    stuHoadon.loai = IIf(taikhoan.tk_id = GTGTKT_ID Or taikhoan.sohieu Like "33312*", -1, (IIf(taikhoan.tk_id = TTDB_ID, 2, 1)))
                    stuHoadon.NK = IIf(stuHoadon.loai = -1 And (CoPSTK("33312") Or taikhoan.sohieu Like "33312*"), 1, 0)
                    stuHoadon.ts = IIf(stuHoadon.loai = -1 And loaict = 9, 1, 0)
                    If pTygia > 0 Then stuHoadon.tygia = ConvertToDblSafe(txtchungtu(7).Text)
                End If
                If loaict = 8 Then
                    If txtchungtu(2).Text <> "" Then
                        If ConvertToDblSafe(txtchungtu(2).Text) = 10 Then
                            stuHoadon.HTTT = "4"
                        ElseIf ConvertToDblSafe(txtchungtu(2).Text) = 5 Then
                            stuHoadon.HTTT = "3"
                        ElseIf ConvertToDblSafe(txtchungtu(2).Text) = 0 Then
                            stuHoadon.HTTT = "2"
                        End If
                    End If
                ElseIf loaict = 1 Or loaict = 0 Or loaict = 9 Or loaict = 13 Then
                    stuHoadon.HTTT = "1"
                End If
                FVAT.GetPhieu(taikhoan.tk_id = TTDB_ID)
                If stuHoadon.MaKhachHang = 0 And KHDetail Then Exit Sub
                If ctgg And stuHoadon.ThanhTien > 0 And (Not CoPSTK("511", 1)) Then stuHoadon.ThanhTien = -stuHoadon.ThanhTien
                hdcount += 1
                ReDim Preserve hd(hdcount)
                CopyHD(stuHoadon, hd(hdcount))
                stuHoadon.MaSo = 0
                i = hdcount
            Else
                FVAT.GetPhieu(taikhoan.tk_id = TTDB_ID)
                If KHDetail And stuHoadon.MaKhachHang = 0 Then Exit Sub
                i = 0
                If hdcount >= 0 Then
                    Do While hd(i).MaSo <> stuHoadon.MaSo
                        i += 1
                        If i >= hdcount Then Exit Do
                    Loop
                Else
                    i = 0
                End If
                If i >= hdcount Then
                    hdcount += 1
                    ReDim Preserve hd(hdcount)
                End If
                CopyHD(stuHoadon, hd(i))
                hd(i).loai = IIf(taikhoan.tk_id = GTGTKT_ID Or taikhoan.sohieu Like "33312*", -1, (IIf(taikhoan.tk_id = TTDB_ID, 2, 1)))
            End If
            If stuHoadon.MaKhachHang <> 0 Then
                ckh.InitKhachHangMaSo(stuHoadon.MaKhachHang)
                TenBH = ckh.Ten
                DiaChiBH = ckh.DiaChi
                MSTBH = ckh.mst
                MaKHBH = stuHoadon.MaKhachHang
                ckh.InitKhachHangMaSo(0)
            End If
            XoaHD()
        Else
            If ((loaict = 2 And (Strings.Left(txtchungtu(0).Text, 3) = "142" Or Strings.Left(txtchungtu(0).Text, 3) = "242")) Or loaict = 0) And txt(1).Text = "..." Then txt(1).Text = txtchungtu(1).Text
            i = -1
        End If
        If taikhoan.tk_id = TKCNKH_ID Or taikhoan.tk_id = TKCNPT_ID Then
            m = ckh.MaSo
        Else
            m = 0
        End If
        If (loaict = 1 Or loaict = 2 Or loaict = 7 Or loaict = 8) And vattu.Dvt2 > 0 And vattu.MaSo > 0 Then
            If CboNT(2).Items.Count > 0 Then
                dvt = CboNT(2).SelectedValue
            End If

        Else
            dvt = 0
        End If
        Dim luongx() As Double = {}, tienx() As Double = {}
        Dim id() As Integer = {}
        Dim cx As Integer
        Dim tienx2() As Double = {}
        If loaict = 2 And taikhoan.loai > 0 And (OutCost = 2 Or OutCost = 3) And taikhoan.tk_id = TKVT_ID And vattu.MaSo > 0 Then
            If OutCost = 2 Then
                cx = GiaXuatKhoFIFO(CboNT(1).SelectedValue, taikhoan.maso, vattu.MaSo, nt, luongx, tienx, id, tienx2)
            Else
                cx = GiaXuatKhoLIFO(CboNT(1).SelectedValue, taikhoan.maso, vattu.MaSo, nt, luongx, tienx, id, tienx2)
            End If
            For i = 1 To cx
                X = IIf(luongx(i) <> 0, tienx(i) / luongx(i), 0)
                GrdChungtu.AddItem(String.Format("{0}{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}{0}{11}{0}{12}{0}{0}{0}{0}{0}-1{0}{0}{0}{0}{0}{0}{13}", _
                                       Chr(9), _
                                       txtchungtu(0).Text, _
                                       txtchungtu(1).Text, _
                                       shnt, _
                                       Format(luongx(i), Mask_2), _
                                       (IIf(luongx(i) <> 0, Format(X, Mask_2), String.Empty)), _
                                       Format(tienx(i), msk), _
                                       ConvertToStrSafe(taikhoan.maso), _
                                       ConvertToStrSafe(vattu.MaSo), _
                                       (IIf(taikhoan.loai > 0, "0", "1")), _
                                       ConvertToStrSafe(taikhoan.MaTC), _
                                       ConvertToStrSafe(id(i)), _
                                       ConvertToStrSafe(taikhoan.tk_id), _
                                       Format(tienx2(i), Mask_2)), NewRowIndex(GrdChungtu, 1))
            Next
            Erase luongx
            Erase tienx
            Erase tienx2
            Erase id
            GoTo kt
        End If
        If pCongNoHD > 0 Then
            If (taikhoan.tk_id = TKCNKH_ID And taikhoan.kieu < 0) Or (taikhoan.tk_id = TKCNPT_ID And taikhoan.kieu > 0) Then
                sott = 0
                If co <> 0 And taikhoan.tk_id = TKCNKH_ID Then
                    FDsHD.Tag = ConvertToStrSafe(ckh.MaSo)
                    FDsHD.ThanhToanDichDanh(taikhoan.maso, ckh.Ten, co, 0, mct1, tien1x, sott)
                End If
                If no <> 0 And taikhoan.tk_id = TKCNPT_ID Then
                    FDsHD.Tag = ConvertToStrSafe(ckh.MaSo)
                    FDsHD.ThanhToanDichDanh(taikhoan.maso, ckh.Ten, no, 1, mct1, tien1x, sott)
                End If
                If sott = 1 Then MaNhap = mct1(1)
                If sott > 1 Then
                    For i = 1 To sott
                        GrdChungtu.AddItem(String.Format("{0}{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}0{0}{9}{0}{10}{0}{11}{0}{12}{0}{0}{0}{0}{13}{0}{14}{0}{0}{15}{0}0{0}{0}0", _
                                               Chr(9), _
                                               txtchungtu(0).Text, _
                                               txtchungtu(1).Text, _
                                               shnt, _
                                               (IIf(nt <> 0, Format(nt, Mask_2), String.Empty)), _
                                               (IIf(nt <> 0, txtchungtu(4).Text, String.Empty)), _
                                               (IIf(taikhoan.tk_id = TKCNPT_ID, Format(tien1x(i), msk), String.Empty)), _
                                               (IIf(taikhoan.tk_id = TKCNKH_ID, Format(tien1x(i), msk), String.Empty)), _
                                               ConvertToStrSafe(taikhoan.maso), _
                                               (IIf(taikhoan.loai > 0, "0", "1")), _
                                               ConvertToStrSafe(taikhoan.MaTC), _
                                               ConvertToStrSafe(mct1(i)), _
                                               ConvertToStrSafe(taikhoan.tk_id), _
                                               ConvertToStrSafe(IIf(taikhoan.tk_id = TKCNPT_ID, m, 0)), _
                                               "-1", _
                                               ConvertToStrSafe(IIf(taikhoan.tk_id = TKCNKH_ID, m, 0))), NewRowIndex(GrdChungtu, 1))
                    Next
                    GoTo a
                End If
            End If
        End If
        If MaNhap = 0 And pFunction = 10 And pCT_ID > 0 Then
            MaNhap = pCT_ID
        End If

        'Phan in hoa don
        'Dim sodong As Integer
        'For i = 0 To GrdChungtu.Row
        '    sodong += 1
        'Next
        'Dim sql As String = "select MAX(dong) as dong from MAUHOADON"
        'Dim dt As DataTable = ExecSQLReturnDT(sql)
        'Dim a As String = dt.Rows(0)("dong").ToString
        'If a <> "" Then
        '    If vattu.MaSo > 0 And sodong >= CInt(a) Then
        '        If MessageBox.Show("Bạn đã nhập quá số lượng hàng cho phép trên một hóa đơn ! Tiếp tục ?", My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> System.Windows.Forms.DialogResult.Yes Then
        '            txtchungtu(1).Text = ""
        '            txtchungtu(0).Text = ""
        '            txtchungtu(2).Text = ""
        '            txtchungtu(3).Text = ""
        '            txtchungtu(4).Text = ""
        '            txtchungtu(5).Text = ""
        '            txtchungtu(6).Text = ""
        '            txtchungtu(0).Focus()

        '            Exit Sub
        '        End If
        '        GrdChungtu.AddItem(String.Format("{0}{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}{0}{11}{0}{12}{0}{13}{0}{0}{0}{0}{14}{0}{15}{0}{0}{16}{0}{17}{0}{0}{18}{0}{19}{0}{20}{0}{21}", _
        '                       Chr(9), _
        '                       txtchungtu(0).Text, _
        '                       txtchungtu(1).Text, _
        '                       shnt, _
        '                       (IIf(nt <> 0, Format(nt, Mask_2), "")), _
        '                       (IIf(nt <> 0, txtchungtu(4).Text, "")), _
        '                       Format(no, msk), _
        '                       Format(co, msk), _
        '                       ConvertToStrSafe(taikhoan.maso), _
        '                       ConvertToStrSafe(vattu.MaSo), _
        '                       (IIf(taikhoan.loai > 0, "0", "1")), _
        '                       ConvertToStrSafe(taikhoan.MaTC), _
        '                       ConvertToStrSafe(MaNhap), _
        '                       ConvertToStrSafe(taikhoan.tk_id), _
        '                       cstr(IIf(no <> 0, m, 0)), _
        '                       ConvertToStrSafe(i), _
        '                       cstr(IIf(co <> 0, m, 0)), _
        '                       ConvertToStrSafe(tp.MaSo), _
        '                       ConvertToStrSafe(dvt), _
        '                       Format(ConvertToDblSafe(txtchungtu(11).Text), Mask_2), _
        '                       Format(ConvertToDblSafe(txtchungtu(9).Text), IIf(ConvertToDblSafe(IIf(txtchungtu(9).Text = "", 0, txtchungtu(9)) * 100) Mod 100 <> 0, Mask_2, Mask_0)), _
        '                       Format(ConvertToDblSafe(txtchungtu(10).Text), Mask_0)), IIf((loaict = 0 Or loaict = 1) And txtchungtu(2).Text.Length = 0 And Strings.Left(txtchungtu(0).Text, 3) = "133" And Not CPGV.Visible, 0, (IIf(ConvertToDblSafe(CmdChitiet.Tag) < 0, NewRowIndex(GrdChungtu, 1), ConvertToStrSafe(CmdChitiet.Tag)))))
        '    Else
        GrdChungtu.AddItem(String.Format("{0}{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}{0}{11}{0}{12}{0}{13}{0}{0}{0}{0}{14}{0}{15}{0}{0}{16}{0}{17}{0}{0}{18}{0}{19}{0}{20}{0}{21}", _
                       Chr(9), _
                       txtchungtu(0).Text, _
                       txtchungtu(1).Text, _
                       shnt, _
                       (IIf(nt <> 0, Format(nt, Mask_2), "")), _
                       (IIf(nt <> 0, txtchungtu(4).Text, "")), _
                       Format(no, msk), _
                       Format(co, msk), _
                       ConvertToStrSafe(taikhoan.maso), _
                       ConvertToStrSafe(vattu.MaSo), _
                       (IIf(taikhoan.loai > 0, "0", "1")), _
                       ConvertToStrSafe(taikhoan.MaTC), _
                       ConvertToStrSafe(MaNhap), _
                       ConvertToStrSafe(taikhoan.tk_id), _
                       CStr(IIf(no <> 0, m, 0)), _
                       ConvertToStrSafe(i), _
                       CStr(IIf(co <> 0, m, 0)), _
                       ConvertToStrSafe(tp.MaSo), _
                       ConvertToStrSafe(dvt), _
                       Format(ConvertToDblSafe(txtchungtu(11).Text), Mask_2), _
                       Format(ConvertToDblSafe(txtchungtu(9).Text), IIf(ConvertToDblSafe(IIf(txtchungtu(9).Text = "", 0, txtchungtu(9).Text) * 100) Mod 100 <> 0, Mask_2, Mask_0)), _
                       Format(ConvertToDblSafe(txtchungtu(10).Text), Mask_0)), IIf((loaict = 0 Or loaict = 1) And txtchungtu(2).Text.Length = 0 And Strings.Left(txtchungtu(0).Text, 3) = "133" And Not CPGV.Visible, 0, (IIf(ConvertToDblSafe(CmdChitiet.Tag) < 0, NewRowIndex(GrdChungtu, 1), ConvertToStrSafe(CmdChitiet.Tag)))))
        '    End If
        'Else
        '    If MessageBox.Show("                 Bạn chưa khởi tạo mẫu hóa đơn." + vbLf + " Vui lòng khỏi tạo mẫu hóa đơn trước khi thực hiện chức năng này.", My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> System.Windows.Forms.DialogResult.No Then
        '        IF0005.ShowDialog()
        '        Exit Sub
        '    Else
        '        Exit Sub
        '    End If
        'End If        

a:
        GrdChungtu.Row = ConvertToDblSafe(GrdChungtu.Rows - 1)
        GrdChungtu.Col = 1
        If Strings.Len(GrdChungtu.Items(GrdChungtu.Row).SubItems(GrdChungtu.Col).Text) = 0 Then GrdChungtu.RemoveItem(GrdChungtu.Row)
kt:
        GrdChungtu.Row = 0
        CmdChitiet.Tag = -1
        If (loaict = 1 Or loaict = 2) Then vattu.InitVattuMaSo(0)
        If loaict = 2 Or loaict = 8 Then
            xddu = SetDoiUng(1)
            If Not xddu Then xddu = SetDoiUng()
        Else
            xddu = SetDoiUng()
            If Not xddu Then xddu = SetDoiUng(1)
        End If
        If ckh.MaSo > 0 Then
            DiaChiNX = ckh.DiaChi
            TenBH = ckh.Ten
            DiaChiBH = ckh.DiaChi
            MSTBH = ckh.mst
            MaKHBH = ckh.MaSo
        End If
        If pVAT2 > 0 And loaict = 8 And vattu.MaSo > 0 And vattu.VAT > 0 Then vBH = vattu.VAT
        NhapDongMoi(taikhoan.sohieu)
        Erase mct1
        Erase tien1x
        Kiemtrachiphi()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CmdPhieu_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _CmdPhieu_0.Click, _CmdPhieu_1.Click, _CmdPhieu_2.Click, _CmdPhieu_3.Click
        Dim Index As Integer = Array.IndexOf(CmdPhieu, eventSender)
        Dim xxx As String = String.Empty
        Dim sotien As String = String.Empty
        Dim mv As String = String.Empty
        Dim sodu, i, k, lp As Integer
        Dim v As Double
        Dim ms As Integer
        Dim luong, tien, ttien, tienNT As Double
        Dim TkCo As New StringBuilder
        Dim tkno As New StringBuilder
        Dim TK As New ClsTaikhoan
        Dim ts As clsTaiSan
        Dim HTTT = String.Empty, shtk As String = String.Empty
        Dim TL As Integer
        Dim v521, Thue, v338, X As Double
        Dim vt As New ClsVattu
        Dim dnt, dn, DC, CK As Double
        Dim lanin, somh, stt As Integer
        Dim tp As New Cls154
        Dim loaitien As String = String.Empty
        Dim dv1 As String = String.Empty
        Dim ten1 As String = String.Empty
        Dim NDD As String = String.Empty
        Dim sohieu1 As String = String.Empty
        Dim banin, tenreport As Integer
        Dim sohieuphieu As String = String.Empty
        Dim xanhnoidia, hong, Den, tim, xanh As Boolean
        Dim loaiin As Integer    'hddain,
        Dim taikhoankh As String = String.Empty
        Dim dienthoaikh As String = String.Empty
        'Dim rs As DataTable

        Dim ReportFilename As String = String.Empty

        'If loaict = 8 Then
        '    If Den Then
        '        ReportFilename = String.Format("HOADONND1{0}.RPT", tenreport)
        '    End If
        '    If tim Then
        '        ReportFilename = String.Format("HOADONND2{0}.RPT", tenreport)
        '    End If
        '    If xanh Then
        '        ReportFilename = String.Format("HOADONXK2{0}.RPT", tenreport)
        '    End If
        '    If hong Then
        '        ReportFilename = String.Format("HOADONXK1{0}.RPT", tenreport)
        '    End If
        '    If xanhnoidia Then
        '        ReportFilename = String.Format("HOADONND3{0}.RPT", tenreport)
        '    End If
        '    rptFrom.InitForm(ReportFilename, "SELECT * FROM License", "License")
        'End If

        Select Case Index
            Case 0, 3
                shtk = IIf(Index = 0, TM, NH)
                lp = LoaiPhieuThuChi(shtk)
                tienNT = 0
                Dim ttno As Integer = 0
                Dim ttco As Integer = 0
                If lp < 0 Then
                    ReportFilename = IIf(Index = 0, "PHIEUTHU.RPT", "THUNH.RPT")
                    rptFrom.InitForm(ReportFilename, "SELECT * FROM BaoCaoCP2", "BaoCaoCP2")

                    With GrdChungtu
                        For i = 0 To .Rows - 1
                            .Row = i
                            .Col = 1
                            xxx = .Items(.Row).SubItems(.Col).Text
                            If xxx.Length = 0 Then Exit For
                            .Col = 6
                            v = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                            If v <> 0 Then
                                If Strings.Left(xxx, shtk.Length) = shtk Then ttien += v
                                .Col = 4
                                X = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) <> 0 And Strings.Left(xxx, shtk.Length) = shtk Then
                                    tienNT += X
                                    .Col = 3
                                    loaitien = .Items(.Row).SubItems(.Col).Text
                                End If
                                rptFrom.SetFormulas("TKNo" & CStr(stt), xxx)
                                rptFrom.SetFormulas("PSNo" & CStr(stt), v)
                                stt += 1
                            Else
                                .Col = 7
                                tien = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                If tien <> 0 Then
                                    .Col = 1
                                    xxx = .Items(.Row).SubItems(.Col).Text
                                    For k = 0 To i - 1
                                        .Row = ConvertToDblSafe(k)
                                        If .Items(.Row).SubItems(.Col).Text = xxx Then
                                            .Col = 19
                                            If IsNumeric(.Items(.Row).SubItems(.Col).Text) Then
                                                ttno = 0
                                                ttco = 0
                                                While ttno < stt
                                                    ttno = ttno + 1
                                                    If Replace(rptFrom.GetFormulas("TKNo" & CStr(ttno)), "'", "") = xxx Then GoTo Timduoc
                                                End While
                                                While ttco < sodu
                                                    ttco = ttco + 1
                                                    If Replace(rptFrom.GetFormulas("TKCo" & CStr(ttco)), "'", "") = xxx Then GoTo Timduoc
                                                End While
Timduoc:
                                                If ttno > 0 Then
                                                    sotien = rptFrom.GetFormulas("PSNO" + CStr(ttno))
                                                    rptFrom.SetFormulas("PSNO" + CStr(ttno), sotien + tien)
                                                ElseIf ttco > 0 Then
                                                    sotien = rptFrom.GetFormulas("PSCO" + CStr(ttco))
                                                    rptFrom.SetFormulas("PSCO" + CStr(ttco), sotien + tien)
                                                End If
                                                GoTo A1
                                            Else
                                                GoTo B1
                                            End If
                                        End If
                                    Next
B1:
                                    .Row = i
                                    sodu += 1
                                    rptFrom.SetFormulas("TKCo" & CStr(sodu), xxx)
                                    rptFrom.SetFormulas("PSCo" & CStr(sodu), tien)
                                    .Col = 19
                                    .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(sodu)
A1:
                                End If
                            End If
                        Next
                    End With
                Else
C1:
                    ReportFilename = IIf(Index = 0, "PHIEUCHI.RPT", "CHINH.RPT")
                    rptFrom.InitForm(ReportFilename, "SELECT * FROM BaoCaoCP2", "BaoCaoCP2")

                    ttien = 0
                    With GrdChungtu
                        For i = 0 To .Rows - 1
                            .Row = i
                            .Col = 1
                            xxx = .Items(.Row).SubItems(.Col).Text
                            If xxx.Length = 0 Then Exit For
                            .Col = 7
                            X = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                            If X <> 0 Then
                                If Strings.Left(xxx, shtk.Length) = shtk Then ttien += X
                                rptFrom.SetFormulas("TKCo" & CStr(stt), xxx)
                                rptFrom.SetFormulas("PSCo" & CStr(stt), X)
                                stt += 1
                                .Col = 4
                                X = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) <> 0 Then
                                    tienNT += X
                                    .Col = 3
                                    loaitien = .Items(.Row).SubItems(.Col).Text
                                End If
                            Else
                                .Col = 6
                                tien = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                If tien <> 0 Then
                                    .Col = 1
                                    xxx = .Items(.Row).SubItems(.Col).Text
                                    For k = 0 To i - 1
                                        .Row = ConvertToDblSafe(k)
                                        If .Items(.Row).SubItems(.Col).Text = xxx Then
                                            .Col = 19
                                            If IsNumeric(.Items(.Row).SubItems(.Col).Text) Then
                                                ttco = 0
                                                ttno = 0
                                                While ttno < sodu
                                                    ttno = ttno + 1
                                                    If Replace(rptFrom.GetFormulas("TKNo" & CStr(ttno)), "'", "") = xxx Then GoTo Timduoc1
                                                End While
                                                While ttco < stt
                                                    ttco = ttco + 1
                                                    If rptFrom.GetFormulas("TKCo" & CStr(ttco)) = xxx Then GoTo Timduoc1
                                                End While
Timduoc1:
                                                If ttno > 0 Then
                                                    sotien = rptFrom.GetFormulas("PSNO" + CStr(ttno))
                                                    rptFrom.SetFormulas("PSNO" + CStr(ttno), sotien + tien)
                                                ElseIf ttco > 0 Then
                                                    sotien = rptFrom.GetFormulas("PSCO" + CStr(ttco))
                                                    rptFrom.SetFormulas("PSCO" + CStr(ttco), sotien + tien)
                                                End If
                                            Else
                                                GoTo c
                                            End If
                                            GoTo B
                                        End If
                                    Next
c:
                                    .Row = i
                                    sodu += 1
                                    rptFrom.SetFormulas("TKNo" & CStr(sodu), xxx)
                                    rptFrom.SetFormulas("PSNo" & CStr(sodu), tien)
                                    .Col = 19
                                    .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(sodu)
B:
                                End If
                            End If
                        Next
                    End With
                End If
                If tienNT > 0 Then
                    sotien = String.Format("{0}{1}", _
                                 ToVNText(IIf(Math.Abs(tienNT) > 0, Math.Floor(Math.Abs(tienNT)), Math.Ceiling(Math.Abs(tienNT)))), _
                                 (IIf(loaitien.ToUpper() = "USD", " dollars ", String.Format(" {0} ", loaitien))))
                    If tienNT - (IIf(tienNT > 0, Math.Floor(tienNT), Math.Ceiling(tienNT))) > 0 Then sotien = String.Format("{0} và {1} cents", sotien, ToVNText(IIf(0.5 + 100 * (tienNT - (IIf(tienNT > 0, Math.Floor(tienNT), Math.Ceiling(tienNT)))) > 0, Math.Floor(0.5 + 100 * (tienNT - (IIf(tienNT > 0, Math.Floor(tienNT), Math.Ceiling(tienNT))))), Math.Ceiling(0.5 + 100 * (tienNT - (IIf(tienNT > 0, Math.Floor(tienNT), Math.Ceiling(tienNT))))))))
                    rptFrom.SetFormulas("LoaiT", String.Format("'{0},'", loaitien))
                    rptFrom.SetFormulas("X", tienNT)
                Else
                    sotien = String.Format("{0} đồng", ToVNText(Math.Abs(ttien)))
                    rptFrom.SetFormulas("x", ttien)
                End If
                ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
                For i = 1 To IIf(lp < 0, Ppthu, Ppchi)
                    ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten) SELECT {0}, N'{1}',DiaChi FROM License", i, ConvertToStrSafe(i)))
                Next
                If ReportFilename = "PHIEUTHU.RPT" Or ReportFilename = "PHIEUCHI.RPT" Then
                    rptFrom.SetFormulas("SoPhieu", String.Format("'{0}'", mathuchi))
                Else
                    rptFrom.SetFormulas("SoPhieu", String.Format("'{0}'", LaySH(txt(0).Text, 1)))
                End If
                If ctgoc.Length = 0 Or ctgoc = "..." Then
                    ctgoc = Me.txt(0).Text
                    ckh.InitKhachHangMaSo(ConvertToDblSafe(Timten("makhachhang", (GetSelectValue(String.Format("SELECT maso as f1 FROM chungtu WHERE mact={0} and matkno={1}", MaSoCT, Timten("maso", "133111", "sohieu", "hethongtk")))), "maso", "hoadon")))
                    tentc = ckh.Ten
                    diachitc = ckh.DiaChi
                    If ckh.MaSo = 0 Then
                        tentc = (GetSelectValue(String.Format("SELECT khachhang.ten AS F1,khachhang.maso as f2 FROM khachhang inner join chungtu on chungtu.makhc=khachhang.maso WHERE chungtu.sohieu=N'{0}'", ctgoc), MaKHBH))
                        diachitc = (GetSelectValue(String.Format("SELECT khachhang.diachi AS F1 FROM khachhang inner join chungtu on chungtu.makhc=khachhang.maso WHERE chungtu.sohieu=N'{0}'", ctgoc)))
                    End If
                End If
                rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", diachitc))
                rptFrom.SetFormulas("CTGoc", String.Format("'{0}'", ctgoc))
                rptFrom.SetFormulas("DiaChiDN", String.Format("'{0} - {1} - {2}'", frmMain._LbCty_2.Text, frmMain._LbCty_10.Text, frmMain._LbCty_11.Text))
                rptFrom.SetFormulas("TelDNS", String.Format("'{0}'", frmMain._LbCty_3.Text))
                rptFrom.SetFormulas("Ngay", String.Format(Ngonngu("Ngày :{0}", "Date:{0}"), Format(Ngay(1), Mask_DR)))
                rptFrom.SetFormulas("BangChu", String.Format("'{0}'", sotien))
                rptFrom.SetFormulas("TenNV", String.Format("'{0}'", tentc))
                rptFrom.SetFormulas("LyDo", String.Format("'{0}'", txt(1).Text))
                i = LaySohieuDoiTuong(xxx)
                If i > 1 Then
                    rptFrom.SetFormulas("TenKH", String.Format("'{0}'", xxx))
                Else
                    If i < 1 Then
                        If hdcount >= 0 Then
                            ms = hd(hdcount).MaKhachHang
                        Else
                            ms = MaKHBH
                            If ms = 0 Then ms = LayMaKH(IIf(lp = 0, -1, 1))
                        End If
                        If ms > 0 Then
                            rptFrom.SetFormulas("TenKH", String.Format("'{0}'", TenKH(xxx, ms)))
                            rptFrom.SetFormulas("MaSoKH", String.Format("'{0}'", (IIf(Strings.Left(xxx, 1) = "#", "...", xxx))))
                        End If
                    End If
                    If i = 1 Then
                        rptFrom.SetFormulas("TenKH", String.Format("'{0}'", TenKH(xxx, 0)))
                        rptFrom.SetFormulas("MsSoKH", String.Format("'{0}'", xxx))
                    End If
                End If
            Case 1
                If Not (rptFrom.ReportDestination = 0) Then SetSPNX()
                v = 0
                sodu = 0
                TL = -1
                Thue = 0
                ExecSQLNonQuery("DELETE FROM PhieuNX")
                With GrdChungtu
                    For i = 0 To .Rows - 1
                        .Row = i
                        .Col = 1
                        If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit For
                        TK.InitTaikhoanSohieu(.Items(.Row).SubItems(.Col).Text)
                        If (loaict = 9 Or loaict = 10) And TK.tk_id = TSCD_ID Then
                            .Col = IIf(loaict = 9, 6, 7)
                            tien = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                            ttien += tien
                            ts = New clsTaiSan()
                            If pMaTaiSan > 0 Then
                                ts.ChiDinh(pMaTaiSan, 0)
                            Else
                                .Col = 3
                                ts.ChiDinh(SoHieu2MaSo(.Items(.Row).SubItems(.Col).Text, "TaiSan"), 0)
                            End If
                            ExecSQLNonQuery(String.Format("INSERT INTO PhieuNX (MaSo, SoCT,DienGiaiCT,SoHieu,DienGiai,SoLuong,ThanhTien) VALUES ({0},N'{1}',N'{2}',N'{3}',N'{4}',1,{5})", _
                                                Lng_MaxValue("MaSo", "PhieuNX") + 1, _
                                                LaySH(txt(0).Text, 2), _
                                                txt(1).Text, _
                                                ts.sohieu, _
                                                ts.ten, _
                                                tien))
                            ts = Nothing
                        End If
                        If TK.tk_id = TKDT_ID Or TK.tk_id = TKVT_ID Then
                            If loaict = 1 Or TK.tk_id = TKGT_ID Then
                                If (tkno.ToString().IndexOf(TK.sohieu) + 1) = 0 Then tkno.Append(String.Format("{0}{1}", (IIf(tkno.ToString().Length > 0, ", ", "")), TK.sohieu))
                            Else
                                If (TkCo.ToString().IndexOf(TK.sohieu) + 1) = 0 Then TkCo.Append(String.Format("{0}{1}", (IIf(TkCo.ToString().Length > 0, ", ", "")), TK.sohieu))
                            End If
                            .Col = 3
                            If .Items(.Row).SubItems(.Col).Text.Length > 0 Or TK.sohieu Like "5113*" Then
                                sodu = 1
                                ten1 = Timten("tenvattu", .Items(.Row).SubItems(.Col).Text, "sohieu", "vattu")
                                dv1 = Timten("donvi", .Items(.Row).SubItems(.Col).Text, "sohieu", "vattu")
                                sohieu1 = .Items(.Row).SubItems(.Col).Text
                                If Len(ten1) = 0 Then
                                    ten1 = hd(hdcount).MatHang
                                    dv1 = ""
                                    sohieu1 = TK.sohieu
                                End If
                                If TK.tk_id2 = TKDT_ID Then
                                    tp.InitTPSohieu(.Items(.Row).SubItems(.Col).Text)
                                    If Not (mv = tp.DonVi) Then mv = dv1
                                Else
                                    vt.InitVattuSohieu(.Items(.Row).SubItems(.Col).Text)
                                    .Col = 23
                                    If Not KtraDVT(vt.MaSo, ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text), mv) And (loaict = 1 Or loaict = 2 Or loaict = 7 Or loaict = 8) Then
                                        If Not (mv = vt.DonVi) Then mv = dv1
                                    End If
                                    If vt.MaSo > 0 Then XDTyLeQD(vt.MaSo)
                                End If
                                .Col = 4
                                luong = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                .Col = 24
                                tienNT = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                .Col = 26
                                X = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                CK += X
                                .Col = IIf(loaict = 1 Or TK.tk_id = TKGT_ID, 6, 7)
                                tien = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                If loaict = 8 Then tien = Math.Abs(tien)
                                ttien += tien
                                .Col = 5
                                tienNT = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                actax_soct = Timten("mact", CStr(ConvertToDblSafe(Timten("ct_id", MaSoCT, "mact", "chungtu")) - 500000000), "MaSo", "chungtu")
                                sohieuphieu = GetSelectValue("select chungtu.maso as f1 from " & ChungTu2TKNC(0) & " where " & IIf(actax_soct <> String.Empty, " chungtu.mact = " & actax_soct & " and ", "") & " (hethongtk.sohieu like '133%' or tk.sohieu like '333%')")
                                actax_masokh = ConvertToStrSafe(ConvertToDblSafe(Timten("makh", actax_soct, "mact", "chungtulq"))) 'GetSelectValue("SELECT makh FROM chungtulq WHERE mact=" + ConvertToStrSafe(tuongsoct) + " and makh>0")
                                If ConvertToDblSafe(actax_masokh) = 0 Then actax_masokh = ConvertToStrSafe(ConvertToDblSafe(Timten("makhachhang", sohieuphieu, "SoHD", "HoaDon")))
                                actax_sohieukh = (GetSelectValue(String.Format("SELECT sohieu as f1,diachi as f2,daidien as f3 FROM khachhang WHERE maso={0}", actax_masokh), _
                                                        actax_diachi, _
                                                        NDD))
                                If Not TruongDaCo("PhieuNX", "SoHieuNX") Then
                                    ExecSQLNonQuery("alter table PhieuNX add SoHieuNX char(20) null")
                                End If
                                Dim DVT2 As String, tyle2 As Double
                                .Col = 23
                                If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) > 0 Then
                                    DVT2 = GetSelectValue("select donvi as f1, tyleqd as f2 from dvtvattu where maso =" + CStr(.Items(.Row).SubItems(.Col).Text), tyle2)
                                    ExecSQLNonQuery(String.Format("INSERT INTO PhieuNX (MaSo, SoCT,SoHieuNX,DienGiaiCT,SoHieu,DienGiai,SoLuong,ThanhTien,DVT,DonGia,TyLe,Thue,ThanhTien2,CK) VALUES ({0},N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',{6},{7},N'{8}',{9},{10},{11},{9},{12})", _
                                                        Lng_MaxValue("MaSo", "PhieuNX") + 1, _
                                                        LaySH(txt(0).Text, 2), _
                                                        Timten("manhapxuat", ConvertToStrSafe(MaSoCT), "mact", "chungtu"), _
                                                        txt(1).Text, _
                                                        (IIf((IIf(vt.MaSo > 0, vt.sohieu, tp.SoHieu)) = "", sohieu1, (IIf(vt.MaSo > 0, vt.sohieu, tp.SoHieu)))), _
                                                        (IIf(ten1 = "", "...", ten1)), _
                                                        doidau(luong), _
                                                        doidau(tien), _
                                                        (IIf(DVT2 = "", "...", DVT2)), _
                                                        doidau(tienNT), _
                                                        ConvertToStrSafe(TL), _
                                                        doidau(Thue), _
                                                        doidau(X)))
                                Else
                                    ExecSQLNonQuery(String.Format("INSERT INTO PhieuNX (MaSo, SoCT,SoHieuNX,DienGiaiCT,SoHieu,DienGiai,SoLuong,ThanhTien,DVT,DonGia,TyLe,Thue,ThanhTien2,CK) VALUES ({0},N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',{6},{7},N'{8}',{9},{10},{11},{9},{12})", _
                                                        Lng_MaxValue("MaSo", "PhieuNX") + 1, _
                                                        LaySH(txt(0).Text, 2), _
                                                        Timten("manhapxuat", ConvertToStrSafe(MaSoCT), "mact", "chungtu"), _
                                                        txt(1).Text, _
                                                        (IIf((IIf(vt.MaSo > 0, vt.sohieu, tp.SoHieu)) = "", sohieu1, (IIf(vt.MaSo > 0, vt.sohieu, tp.SoHieu)))), _
                                                        (IIf(ten1 = "", "...", ten1)), _
                                                        CStr(luong), _
                                                        CStr(tien), _
                                                        (IIf(dv1 = "", "...", dv1)), _
                                                        CStr(tienNT), _
                                                        ConvertToStrSafe(TL), _
                                                        CStr(Thue), _
                                                        CStr(X)))
                                End If
                                somh += 1
                            Else
                                If TK.tk_id = TKDT_ID Then
                                    .Col = 7
                                    tienNT += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                End If
                            End If
                        Else
                            If loaict <> 8 Then
                                .Col = 6
                                luong = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                If luong <> 0 And TK.tk_id = GTGTKT_ID Then v += luong
                                If luong <> 0 And (tkno.ToString().IndexOf(TK.sohieu) + 1) = 0 Then tkno.Append(String.Format("{0}{1}", (IIf(tkno.ToString().Length > 0, ", ", "")), TK.sohieu))
                                .Col = 7
                                luong = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                If luong <> 0 And TK.tk_id = GTGTPN_ID Then v += luong
                                If luong <> 0 And (TkCo.ToString().IndexOf(TK.sohieu) + 1) = 0 Then TkCo.Append(String.Format("{0}{1}", (IIf(TkCo.ToString().Length > 0, ", ", "")), TK.sohieu))
                                If TK.tk_id <> TKVT_ID And (TK.sohieu Like "138*" Or TK.sohieu Like "338*") Then
                                    .Col = 6
                                    v338 += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                End If
                            Else
                                If TK.tk_id = GTGTPN_ID Then
                                    .Col = 19
                                    TkCo = New StringBuilder(.Items(.Row).SubItems(.Col).Text)
                                    .Col = 7
                                    Thue = Math.Abs(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text))
                                    .Col = 6
                                    Thue += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                    v += Thue
                                    .Col = 3
                                    TL = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                    .Col = 18
                                    k = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                    If k >= 0 And k <= hdcount Then
                                        If hd(ConvertToDblSafe((.Items(.Row).SubItems(.Col).Text))).KCT = 1 Then TL = -1
                                    End If
                                End If
                                If TK.tk_id <> TKDT_ID And (TK.sohieu Like "138*" Or TK.sohieu Like "338*") Then
                                    .Col = 7
                                    v338 += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                End If
                            End If
                        End If
                    Next
                End With

                Select Case loaict
                    Case 1, 2
                        If P_1 = 0 Then
                            TenNX = FrmGetStr.GetString(Ngonngu("Tên người giao nhận:", "Forwarding names"), Ngonngu("Phiếu nhập xuất", "import and export bills"), IIf(MaSoCT > 0, TenNX, ""))
                            DiaChiNX = FrmGetStr.GetString(Ngonngu("Địa chỉ người giao nhận:", "Forwarding address"), Ngonngu("Phiếu nhập xuất", "import and export bills"), IIf(MaSoCT > 0, DiaChiNX, ""))
                        End If

                        hdcount = 0
                        ReDim Preserve hd(hdcount)
                        If loaict = 2 Then intHDMaso(hd(0), sohieuphieu)
                        If Timten("NLTS", sohieuphieu, "sohd", "HoaDon") = "1" Then
                            If Not (loaict = 1 And FileSystem.Dir(String.Format("{0}\REPORTS\PHIEUNXNS.RPT", pCurDir), FileAttribute.Normal).Length > 0) Then GoTo Loi_TenRePort

                            If rptFrom.ReportDestination <> 0 Then
                                If MessageBox.Show(Ngonngu("Phiếu nhập hàng nông, lâm, thuỷ sản?", "Bill of agriculture, foresttry, fisheries?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then GoTo Loi_TenRePort
                            End If
                            rptFrom.InitForm("PHIEUNXNS.RPT", "SELECT * FROM PhieuNX", "PhieuNX")
                            rptFrom.SetFormulas("Ngay", String.Format("'Ngày {0} tháng {1} năm {2}'", DateAndTime.Day(Ngay(1)), ConvertToStrSafe(Ngay(1).Month), ConvertToStrSafe(Ngay(1).Year)))
                            rptFrom.SetFormulas("DiaChiCty", String.Format("'{0} - {1} - {2}'", frmMain._LbCty_2.Text, frmMain._LbCty_10.Text, frmMain._LbCty_11.Text))
                            rptFrom.SetFormulas("CMND", String.Format("'{0}'", MST))
                            rptFrom.SetFormulas("TenNN", String.Format("'{0}'", FrmGetStr.GetString(Ngonngu("Họ tên người bán hàng:", "Seller full name"), My.Application.Info.ProductName, String.Format("NHÂN VIÊN {0}", frmMain._LbCty_0.Text))))
                        Else
Loi_TenRePort:
                            If loaict = 1 And FileSystem.Dir(String.Format("{0}\REPORTS\PHIEUNX.RPT", pCurDir), FileAttribute.Normal).Length > 0 Then ReportFilename = "PHIEUNX.RPT"
                            If loaict = 2 And CoPSTK("62") And FileSystem.Dir(String.Format("{0}\REPORTS\PHIEUX62.RPT", pCurDir), FileAttribute.Normal).Length > 0 Then ReportFilename = "PHIEUX62.RPT"
                            If loaict = 2 And CoPSTK("64") And FileSystem.Dir(String.Format("{0}\REPORTS\PHIEUX64.RPT", pCurDir), FileAttribute.Normal).Length > 0 Then ReportFilename = "PHIEUX64.RPT"
                            If Strings.Len(ReportFilename) = 0 Then ReportFilename = "PHIEUNX.RPT"
                            rptFrom.InitForm(ReportFilename, "SELECT * FROM PhieuNX", "PhieuNX")
                            rptFrom.SetFormulas("Ngay", Format(Ngay(1), Mask_DR))
                        End If

                        rptFrom.SetFormulas("NCC", String.Format("'{0}'", (IIf(loaict = 1, Ngonngu("Đơn vị cung cấp:", "Providing unit:"), Ngonngu("Đơn vị nhận hàng:", "Get unit")))))
                        If hdcount >= 0 Then
                            If loaict = 1 Or loaict = 2 Then
                                If hdcount > 0 Then
                                    rptFrom.SetFormulas("TyLe", Ngonngu("'Thuế GTGT:'", "'VAT :'"))
                                Else
                                    rptFrom.SetFormulas("TyLe", String.Format(Ngonngu("'Thuế GTGT ({0}%):'", "'VAT {0}%:'"), hd(hdcount).TyLe))
                                End If
                                rptFrom.SetFormulas("HoaDon", String.Format(Ngonngu("'Hoá đơn : {0} - Ký Hiệu : {1} - Ngày : {2}'", "'Invoice : {0} - Notation : {1} - Date : {2}'"), _
                                                                    hd(hdcount).sohd, _
                                                                    hd(hdcount).KyHieu, _
                                                                    String.Format(hd(hdcount).NgayPH, Mask_DB)))
                            ElseIf loaict = 8 And xxx = "BKBL" Then
                                rptFrom.SetFormulas("TyLe", hd(hdcount).TyLe)
                            End If
                            ms = hd(hdcount).MaKhachHang
                        Else
                            ms = LayMaKH(IIf(loaict = 1, 1, -1))
                        End If
                        If ms = 0 Then ms = LayMaKH(IIf(loaict = 1, 1, -1))
                        If ms = 0 Then ms = MaKHBH

                        rptFrom.SetFormulas("Kho", String.Format("'{0}'", CboNguon(1).Text))
                        rptFrom.SetFormulas("TKno", String.Format("'{0}'", tkno))
                        rptFrom.SetFormulas("TKco", String.Format("'{0}'", TkCo))
                        rptFrom.SetFormulas("Sotien", String.Format("'{0} đồng'", ToVNText(ttien + v + v338)))
                        rptFrom.SetFormulas("LoaiCT", loaict)
                        rptFrom.SetFormulas("sohieudoi", txt(4).Text)
                        If ms > 0 Then
                            rptFrom.SetFormulas("TenKH", String.Format("'{0}'", TenKH(xxx, ms, mv)))
                            rptFrom.SetFormulas("MaKH", String.Format("'{0}'", xxx))
                            rptFrom.SetFormulas("DiaChiKH", String.Format("'{0}'", ConvertToStrSafe(GetSelectValue(String.Format("SELECT diachi as f1,mst as f2 FROM khachhang WHERE sohieu like N'{0}'", xxx), MST))))
                        Else
                            rptFrom.SetFormulas("TenKH", String.Format("'{0}'", Timten("ten", actax_masokh, "maso", "khachhang")))
                            rptFrom.SetFormulas("MaKH", String.Format("'{0}'", Timten("sohieu", actax_masokh, "maso", "khachhang")))
                            rptFrom.SetFormulas("DiaChiKH", String.Format("'{0}'", actax_diachi))
                        End If
                        rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", DiaChiNX))
                        rptFrom.SetFormulas("TenNN", String.Format("'{0}'", TenNX))
                        If v <> 0 Then rptFrom.SetFormulas("VAT", v)
                        If v338 <> 0 Then rptFrom.SetFormulas("P", v338)
                    Case 0, 7, 8
                        If banin = 0 Then
                            If hdcount >= 0 Then
                                rptFrom.SetFormulas("TyLe", hd(hdcount).TyLe)
                                rptFrom.SetFormulas("SoHD", String.Format("'{0}'", hd(hdcount).sohd))
                                ms = hd(hdcount).MaKhachHang
                                HTTT = hd(hdcount).HTTT
                                rptFrom.SetFormulas("TyGia", hd(hdcount).tygia)
                                CoPSTK("", 1, X)
                                CoPSTK("11", -1, luong)
                                SoDuKHNgay(ms, Ngay(0), dn, DC, dnt)
                                rptFrom.SetFormulas("DuDK", IIf(MaSoCT > 0, dn - DC - X + luong, dn - DC))
                                rptFrom.SetFormulas("PS", X)
                                rptFrom.SetFormulas("11", luong)
                                rptFrom.SetFormulas("NDD", String.Format("'{0}'", NDD))
                            Else
                                ms = LayMaKH(IIf(loaict = 1, 1, -1))
                                If ms = 0 Then ms = Timten("makh", CStr(ctgoc), "soctgoc", "chungtulq")
                            End If
                            If P_1 = 0 Then
                                FThuChi.Tag = ConvertToStrSafe(3)
                                xxx = ""
                                'loaiin: 1 đặt tin, 2 tự in hoặc điện tử, 3 phiếu giao hàng
                                If hdcount >= 0 Then loaiin = IIf(hd(hdcount).KyHieu.EndsWith("P") = True, 1, IIf(hd(hdcount).KyHieu.EndsWith("T") = True Or hd(hdcount).KyHieu.EndsWith("E") = True, 2, 3))
                                FThuChi.GetPhieu(TenBH, _
                                    DiaChiBH, _
                                    "...", _
                                    0, _
                                    HanTT, _
                                    xxx, _
                                    Den, _
                                    tim, _
                                    hong, _
                                    xanh, _
                                    xanhnoidia, _
                                    True, _
                                    loaiin, _
                                    0, _
                                    0, _
                                    0, , _
                                    tenreport)
                                If loaiin = 3 Then
                                    ReportFilename = "phieugh.rpt"
                                    rptFrom.ReportWindowTitle = ReportFilename
                                    rptFrom.InitForm(ReportFilename, "SELECT * FROM PhieuNX", "PhieuNX")
                                    rptFrom.SetFormulas("No", String.Format("'{0}'", tkno))
                                    rptFrom.SetFormulas("Co", String.Format("'{0}'", TkCo))
                                ElseIf loaiin = 1 Then
                                    ReportFilename = IIf(Chk.CheckState = CheckState.Unchecked, String.Format("HOADON{0}{1}.RPT", (IIf(pGiaUSD > 0, "X", "")), (IIf(somh > 8, "2", ""))), String.Format("BAOGIA{0}.RPT", (IIf(pGiaUSD > 0, "X", ""))))
                                    rptFrom.ReportWindowTitle = ReportFilename
                                    rptFrom.InitForm(ReportFilename, "SELECT * FROM PhieuNX", "PhieuNX")
                                ElseIf loaiin = 2 Then
                                    'FrmIN.ShowDialog()
                                    'Exit Sub
                                End If
                                rptFrom.SetFormulas("Ngay", Format(CDate(Ngay(1)), Mask_DR))
                                'If tuin And hdcount >= 0 Then
                                '    If Den Then
                                '        hddain = ConvertToDblSafe(GetSelectValue(String.Format("SELECT den as f1 FROM hoadon WHERE maso={0}", hd(hdcount).MaSo)))
                                '        If hddain = 1 Then
                                '            rptFrom.SetFormulas("den", 1)
                                '        Else
                                '            ExecSQLNonQuery(String.Format("UPDATE hoadon set den=1 WHERE maso={0}", hd(hdcount).MaSo))
                                '            rptFrom.SetFormulas("den", 0)
                                '        End If
                                '    End If
                                '    If tim Then
                                '        hddain = ConvertToDblSafe(GetSelectValue(String.Format("SELECT tim as f1 FROM hoadon WHERE maso={0}", hd(hdcount).MaSo)))
                                '        If hddain = 1 Then
                                '            rptFrom.SetFormulas("tim", 1)
                                '        Else
                                '            ExecSQLNonQuery(String.Format("UPDATE hoadon set tim=1 WHERE maso={0}", hd(hdcount).MaSo))
                                '            rptFrom.SetFormulas("tim", 0)
                                '        End If
                                '    End If
                                '    If hong Then
                                '        hddain = ConvertToDblSafe(GetSelectValue(String.Format("SELECT hong as f1 FROM hoadon WHERE maso={0}", hd(hdcount).MaSo)))
                                '        If hddain = 1 Then
                                '            rptFrom.SetFormulas("hong", 1)
                                '        Else
                                '            ExecSQLNonQuery(String.Format("UPDATE hoadon set hong=1 WHERE maso={0}", hd(hdcount).MaSo))
                                '            rptFrom.SetFormulas("hong", 0)
                                '        End If
                                '    End If
                                '    If xanh Then
                                '        hddain = ConvertToDblSafe(GetSelectValue(String.Format("SELECT xanh as f1 FROM hoadon WHERE maso={0}", hd(hdcount).MaSo)))
                                '        If hddain = 1 Then
                                '            rptFrom.SetFormulas("xanh", 1)
                                '        Else
                                '            ExecSQLNonQuery(String.Format("UPDATE hoadon set xanh=1 WHERE maso={0}", hd(hdcount).MaSo))
                                '            rptFrom.SetFormulas("xanh", 0)
                                '        End If
                                '    End If
                                '    If xanhnoidia Then
                                '        hddain = ConvertToDblSafe(GetSelectValue(String.Format("SELECT xanhnoidia as f1 FROM hoadon WHERE maso={0}", hd(hdcount).MaSo)))
                                '        If hddain = 1 Then
                                '            rptFrom.SetFormulas("xanhnoidia", 1)
                                '        Else
                                '            ExecSQLNonQuery(String.Format("UPDATE hoadon set xanhnoidia=1 WHERE maso={0}", hd(hdcount).MaSo))
                                '            rptFrom.SetFormulas("xanhnoidia", 0)
                                '        End If
                                '    End If
                                '    '                            Else
                                '    '                                hddain = GetSelectValue("SELECT dain as f1 FROM hoadon WHERE maso=" + ConvertToStrSafe(HD(hdcount).MaSo))
                                '    '                                If hddain = 1 Then
                                '    '                                    frmMain.rpt.Formulas(40) = "den=1"
                                '    '                                Else
                                '    '                                    ExecuteSQL5 "UPDATE hoadon set dain=1 WHERE maso=" + ConvertToStrSafe(HD(hdcount).MaSo)
                                '    '                                    frmMain.rpt.Formulas(40) = "den=0"
                                '    '                                End If
                                'End If
                                If xxx.Length > 0 And xxx <> "..." Then rptFrom.SetFormulas("SoDH", String.Format("'{0}'", xxx))
                            End If

                            Dim demno As Integer = 1
                            Dim demco As Integer = 1
                            With GrdChungtu
                                For i = 0 To .Items.Count - 1
                                    .Row = i
                                    .Col = 6
                                    If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) > 0 Then
                                        .Col = 1
                                        rptFrom.SetFormulas("no" + CStr(demno), "'" + CStr(.Items(.Row).SubItems(.Col).Text) + "'")
                                        demno = demno + 1
                                    Else
                                        .Col = 7
                                        If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) > 0 Then
                                            .Col = 1
                                            rptFrom.SetFormulas("co" + CStr(demco), "'" + CStr(.Items(.Row).SubItems(.Col).Text) + "'")
                                            demco = demco + 1
                                        End If
                                    End If
                                Next
                            End With

                            If ms > 0 Then
                                Dim tenkh1 As String = String.Empty, DiaChiKH As String = String.Empty, faxkh As String = String.Empty, emailkh As String = String.Empty, daidienkh As String = String.Empty, chucvukh As String = String.Empty
                                tenkh1 = GetSelectValue("select ten as f1,diachi as f2, fax as f3, email as f4, daidien as f5, ghichu as f6,tel as f7,taikhoan as f8 from khachhang where maso = " + CStr(ms), DiaChiKH, faxkh, emailkh, daidienkh, chucvukh, dienthoaikh, taikhoankh)
                                rptFrom.SetFormulas("TenKH", CStr(tenkh1))
                                rptFrom.SetFormulas("DiachiKH", CStr(DiaChiKH))
                                If Index = 4 Then
                                    rptFrom.SetFormulas("daidienkh", CStr(daidienkh))
                                    rptFrom.SetFormulas("SoNgayTT", CStr(txtchungtu(8).Text))
                                    rptFrom.SetFormulas("faxkh", CStr(faxkh))
                                    rptFrom.SetFormulas("emailkh", CStr(emailkh))
                                    rptFrom.SetFormulas("chucvukh", CStr(chucvukh))
                                End If
                                'If xxx Like "#*" Then rptFrom.SetFormulas("TenKH", "") : rptFrom.SetFormulas("MaKH", "")
                            End If

                            If pNVBH > 0 Then rptFrom.SetFormulas("nvbh", String.Format("'{0}'", LBNV.Text))
                            rptFrom.SetFormulas("DC1", String.Format("'{0} - {1} - {2}'", frmMain._LbCty_2.Text, frmMain._LbCty_10.Text, frmMain._LbCty_11.Text))
                            rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", DiaChiBH))
                            rptFrom.SetFormulas("MS2", String.Format("'{0}'", MSTBH))
                            rptFrom.SetFormulas("TenNN", String.Format("'{0}'", TenBH))
                            rptFrom.SetFormulas("Kho", String.Format("'{0}'", CboNguon(1).Text))
                            If HanTT.Year > 1900 Then
                                rptFrom.SetFormulas("HanTT", String.Format("'{0}'", String.Format(HanTT, Mask_DB)))
                            End If
                            CoPSTK("521", -1, v521)
                            If sodu = 0 Then
                                ExecSQLNonQuery(String.Format("INSERT INTO PhieuNX (MaSo,SoCT,DienGiaiCT,SoHieu,DienGiai,SoLuong,ThanhTien) VALUES ({0}, N'{1}', N'{2}','...', N'{2}',0,{3})", _
                                                    Lng_MaxValue("MaSo", "PhieuNX") + 1, _
                                                    LaySH(txt(0).Text, 2), _
                                                    txt(1).Text, _
                                                    doidau(tienNT)))
                            End If
                            rptFrom.SetFormulas("SoTien", String.Format("'{0} đồng'", ToVNText(ttien + v + v338 - v521)))
                            If v <> 0 Then rptFrom.SetFormulas("VAT", v)
                            If v338 <> 0 Then rptFrom.SetFormulas("P", v338)
                            rptFrom.SetFormulas("CK", (IIf(v521 <> 0, v521, ConvertToDblSafe(GetSelectValue("SELECT SUM (CK) as f1 FROM phieunx")))))
                            If pGiaUSD > 0 Then rptFrom.SetFormulas("TyGia", pRate)
                            CoPSTK("51", 1, ttien)
                            If ttien < 0 Then rptFrom.SetFormulas("GhiChu", String.Format("'{0}'", txt(1).Text))
                            rptFrom.SetFormulas("HTTT", String.Format("{0}", Thanhtoan()))
                            rptFrom.SetFormulas("Dienthoai", String.Format("'{0}'", frmMain._LbCty_3.Text))
                            rptFrom.SetFormulas("Fax", String.Format("'{0}'", frmMain._LbCty_4.Text))
                            If hdcount >= 0 Then
                                rptFrom.SetFormulas("MauSo", String.Format("N'{0}'", (GetSelectValue(String.Format("SELECT lhd.sohieu as f1 FROM loaihoadon lhd inner join slhoadon hd on lhd.maso=hd.loaihd WHERE hd.kyhieu='{0}' and hd.sohddau<={1} and hd.sohddau+hd.soluong>={1}", _
                                                                                                                hd(hdcount).KyHieu, _
                                                                                                                ConvertToDblSafe(hd(hdcount).sohd))))))
                                rptFrom.SetFormulas("KyHieu", String.Format("'{0}'", hd(hdcount).KyHieu))
                            End If
                            rptFrom.SetFormulas("TaiKhoanTienViet", String.Format("'{0}'", FrmOptions.Text_Renamed(5).Text))
                            rptFrom.SetFormulas("TaikhoanNgoaiTe", String.Format("'{0}'", FrmOptions.Text_Renamed(6).Text))
                            taikhoankh = (GetSelectValue(String.Format("SELECT taikhoan as f1, tel as f2 FROM khachhang WHERE sohieu like N'{0}'", xxx), dienthoaikh))
                            rptFrom.SetFormulas("TaiKhoan", String.Format("'{0}'", taikhoankh))
                            ' Hoá đơn tự in
                            'If tuin And hdcount >= 0 Then
                            '    rptFrom.SetFormulas("Ngay", String.Format("'{0}'", Format(Ngay(1), Mask_DB)))
                            '    rptFrom.SetFormulas("Banin", Phd)
                            '    rptFrom.SetFormulas("Email", String.Format("'{0}'", frmMain._LbCty_9.Text))
                            '    rptFrom.SetFormulas("SoHopDong", String.Format("'{0}'", hd(hdcount).sohopdong))
                            '    rptFrom.SetFormulas("NgayHopDong", String.Format("'{0}'", ConvertToStrSafe(hd(hdcount).Ngayhopdong)))
                            '    rptFrom.SetFormulas("DiaDiemGiaoHang", String.Format("'{0}'", hd(hdcount).diadiemgiaohang))
                            '    rptFrom.SetFormulas("DiaDiemBanHang", String.Format("'{0}'", hd(hdcount).diadiemnhanhang))
                            '    rptFrom.SetFormulas("SoVanDon", String.Format("'{0}'", hd(hdcount).sovandon))
                            '    rptFrom.SetFormulas("SoConTaiNer", String.Format("'{0}'", hd(hdcount).socontainer))
                            '    rptFrom.SetFormulas("TenVanChuyen", String.Format("'{0}'", hd(hdcount).tenvanchuyen))
                            '    rptFrom.SetFormulas("DienThoaikh", String.Format("'{0}'", dienthoaikh))
                            '    rs = ExecSQLReturnDT("SELECT DienGiai, dvt, soluong,thanhtien FROM phieunx")
                            '    i = 1
                            '    Dim rsIndex As Integer = 0
                            '    While rsIndex < rs.Rows.Count
                            '        Dim rsItem As DataRow = rs.Rows(rsIndex)
                            '        rsIndex += 1 ' C15 Rs LOOP CONTROL
                            '        rptFrom.SetFormulas("DienGiai" & CStr(i), String.Format("'{0}'", rsItem("DienGiai")))
                            '        rptFrom.SetFormulas("DVT" & CStr(i), String.Format("'{0}'", rsItem("dvt")))
                            '        rptFrom.SetFormulas("soluong" & CStr(i), rsItem("soluong"))
                            '        rptFrom.SetFormulas("thanhtien" & CStr(i), rsItem("ThanhTien"))
                            '        i += 1
                            '        ''rs.MoveNext()
                            '    End While
                            'End If
                        End If
                        '                    Them12dong
                        '                    banin = banin + 1
                        '                    If banin < Phd Then GoTo Thembanin
                        ' Hết hoá đơn tự in
                    Case 9, 10
                        If P_1 = 0 Then TenNX = FrmGetStr.GetString(Ngonngu("Tên người giao nhận:", "Forwarding names"), Ngonngu("Phiếu nhập xuất", "Import and export bills"), IIf(MaSoCT > 0, TenNX, ""))
                        ms = LayMaKH(IIf(loaict = 9, 1, -1))
                        If hdcount >= 0 Then
                            If loaict = 9 Then rptFrom.SetFormulas("TyLe", String.Format(Ngonngu("'Thuế GTGT ({0}%):'", "'VAT ({0}%:)'"), hd(hdcount).TyLe))
                            If ms = 0 Then ms = hd(hdcount).MaKhachHang
                        End If
                        If ms > 0 Then
                            rptFrom.SetFormulas("TenKH", String.Format("'{0}'", TenKH(xxx, ms)))
                            rptFrom.SetFormulas("MaKH", String.Format("'{0}'", xxx))
                        End If
                        rptFrom.InitForm("PHIEUTS.RPT", "SELECT * FROM PhieuNX", "PhieuNX")

                        rptFrom.SetFormulas("Kho", String.Format("'{0}'", CboNguon(0).Text))
                        rptFrom.SetFormulas("TKNo", String.Format("'{0}'", tkno))
                        rptFrom.SetFormulas("TKCo", String.Format("'{0}'", TkCo))
                        rptFrom.SetFormulas("SoTien", String.Format(Ngonngu("'{0} đồng'", "'{0} VND'"), ToVNText(ttien + v)))
                        rptFrom.SetFormulas("TenNN", String.Format("'{0}'", TenNX))
                        rptFrom.SetFormulas("LoaiCT", loaict)
                        rptFrom.SetFormulas("VAT", v)
                        rptFrom.SetFormulas("Ngay", Format(Ngay(1), Mask_DR))
                End Select
            Case 2
                ttien = 0
                k = 0
                With GrdChungtu
                    For i = 0 To .Rows - 1
                        .Row = i
                        .Col = 1
                        If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit For
                        If .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(CmdPhieu(2).Tag) Then
                            TK.InitTaikhoanSohieu(.Items(.Row).SubItems(.Col).Text)
                            .Col = 3
                            If .Items(.Row).SubItems(.Col).Text.Length > 0 Then
                                mv = .Items(.Row).SubItems(.Col).Text
                                .Col = 4
                                ttien = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                k = 1
                            Else
                                .Col = 7
                                ttien += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                            End If
                        End If
                    Next
                End With
                If k = 0 Then
                    sotien = ToVNText(ttien)
                    xxx = String.Format("SELECT 1 AS [1], N'{0}' AS Ngay, N'{1}' AS TenNV, N'{2}' AS LyDo, N'{3} đồng' AS SoTien,{4} AS XTien FROM License", _
                              Format(Ngay(0), Mask_DB), _
                              unc1, _
                              txt(1).Text, _
                              sotien, _
                              CStr(Math.Abs(ttien)))
                    For i = 2 To Ppunc
                        xxx = String.Format("{0} UNION SELECT {1} AS [1], N'{2}' AS Ngay, N'{3}' AS TenNV, N'{4}' AS LyDo, N'{5} đồng' AS SoTien,{6} AS XTien FROM License", _
                                  xxx, _
                                  ConvertToStrSafe(i), _
                                  Format(Ngay(0), Mask_DB), _
                                  unc1, _
                                  txt(1).Text, _
                                  sotien, _
                                  CStr(Math.Abs(ttien)))
                    Next

                    rptFrom.InitForm("UNC.RPT", xxx, "QNhatky")
                Else
                    sotien = String.Format("{0} {1}", ToVNText(IIf(ttien > 0, Math.Floor(ttien), Math.Ceiling(ttien))), mv)
                    If ttien - (IIf(ttien > 0, Math.Floor(ttien), Math.Ceiling(ttien))) > 0 Then sotien = String.Format("{0} và {1} cents", sotien, ToVNText(IIf(0.5 + 100 * (ttien - (IIf(ttien > 0, Math.Floor(ttien), Math.Ceiling(ttien)))) > 0, Math.Floor(0.5 + 100 * (ttien - (IIf(ttien > 0, Math.Floor(ttien), Math.Ceiling(ttien))))), Math.Ceiling(0.5 + 100 * (ttien - (IIf(ttien > 0, Math.Floor(ttien), Math.Ceiling(ttien))))))))
                    xxx = String.Format("SELECT 1 AS [1], N'{0}' AS Ngay, N'{1}' AS TenNV, N'{2}' AS LyDo, N'{3}' AS SoTien,{4} AS XTien FROM License", Format(Ngay(0), Mask_DB), unc1, txt(1).Text, sotien, CStr(Math.Abs(ttien)))
                    For i = 2 To Ppunc
                        xxx = String.Format("{0} UNION SELECT {1} AS [1], N'{2}' AS Ngay, N'{3}' AS TenNV, N'{4}' AS LyDo, N'{5}' AS SoTien,{6} AS XTien FROM License", xxx, ConvertToStrSafe(i), Format(Ngay(0), Mask_DB), unc1, txt(1).Text, sotien, CStr(Math.Abs(ttien)))
                    Next
                    rptFrom.InitForm("UNC2.RPT", xxx, "QNhatky")
                    rptFrom.SetFormulas("LoaiT", String.Format("'{0}'", mv))
                End If
                'SetSQL("QNhatKy", xxx)

                rptFrom.SetFormulas("SoPhieu", String.Format("'{0}'", LaySH(txt(0).Text, 1)))
                rptFrom.SetFormulas("SoTK", String.Format("'{0}'", unc2))
                xxx = LaySH(unc3, 1, "-")
                If xxx.Length = 0 Then xxx = unc3
                rptFrom.SetFormulas("NH", String.Format("'{0}'", xxx))
                rptFrom.SetFormulas("SoTK2", String.Format("'{0}'", TK.GhiChu))
                rptFrom.SetFormulas("NH2", String.Format("'{0}'", TK.ten))
                xxx = LaySH(unc3, 2, "-")
                If xxx.Length > 0 Then rptFrom.SetFormulas("TP", String.Format("'{0}'", xxx))
        End Select
        'If loaict = 8 Then
        '    '            If Not tuin Then GoTo Inhoadon
        '    '            'If Den Then
        '    '            '    'ReportFilename = String.Format("HOADONND1{0}.RPT", tenreport)
        '    '            '    rptFrom.ReportWindowTitle = rptFrom.ReportFilename
        '    '            '    InBaoCaoRPT(pNN)
        '    '            'End If
        '    '            'If tim Then
        '    '            '    'ReportFilename = String.Format("HOADONND2{0}.RPT", tenreport)
        '    '            '    rptFrom.ReportWindowTitle = rptFrom.ReportFilename
        '    '            '    InBaoCaoRPT(pNN)
        '    '            'End If
        '    '            'If xanh Then
        '    '            '    'ReportFilename = String.Format("HOADONXK2{0}.RPT", tenreport)
        '    '            '    rptFrom.ReportWindowTitle = rptFrom.ReportFilename
        '    '            '    InBaoCaoRPT(pNN)
        '    '            'End If
        '    '            'If hong Then
        '    '            '    'ReportFilename = String.Format("HOADONXK1{0}.RPT", tenreport)
        '    '            '    rptFrom.ReportWindowTitle = rptFrom.ReportFilename
        '    '            '    InBaoCaoRPT(pNN)
        '    '            'End If
        '    '            'If xanhnoidia Then
        '    '            '    'ReportFilename = String.Format("HOADONND3{0}.RPT", tenreport)
        '    '            '    rptFrom.ReportWindowTitle = rptFrom.ReportFilename
        '    '            '    InBaoCaoRPT(pNN)
        '    '            'End If

        '    '            ReportFilename = "phieugh.RPT"
        '    '            rptFrom.ReportFilename = pCurDir & "\phieugh.RPT"
        '    '            rptFrom.InitForm(ReportFilename, "SELECT * FROM PhieuNX", "PhieuNX")
        '    '            rptFrom.ReportWindowTitle = rptFrom.ReportFilename
        '    '            rptFrom.SetFormulas("Ngay", Format(Ngay(1), Mask_D).ToString)
        '    'rptFrom.SetFormulas("nvbh", String.Format("'{0}'", TenBH))
        '    '            If ms > 0 Then
        '    '                Dim tenkh1 As String, DiaChiKH As String, faxkh As String, emailkh As String, daidienkh As String, chucvukh As String
        '    '                tenkh1 = GetSelectValue("select ten as f1,diachi as f2, fax as f3, email as f4, daidien as f5, ghichu as f6,tel as f7,taikhoan as f8 from khachhang where maso = " + CStr(ms), DiaChiKH, faxkh, emailkh, daidienkh, chucvukh, dienthoaikh, taikhoankh)
        '    '                rptFrom.SetFormulas("TenKH", CStr(tenkh1))
        '    '                rptFrom.SetFormulas("DiachiKH", CStr(DiaChiKH))
        '    '                If Index = 4 Then
        '    '                    rptFrom.SetFormulas("daidienkh", CStr(daidienkh))
        '    '                    rptFrom.SetFormulas("SoNgayTT", CStr(txtchungtu(8).Text))
        '    '                    rptFrom.SetFormulas("faxkh", CStr(faxkh))
        '    '                    rptFrom.SetFormulas("emailkh", CStr(emailkh))
        '    '                    rptFrom.SetFormulas("chucvukh", CStr(chucvukh))
        '    '                End If
        '    '            End If
        '    '            InBaoCaoRPT(pNN)
        '    '        Else
        '    'Inhoadon:
        '    '            rptFrom.InitForm(ReportFilename, "SELECT * FROM PhieuNX", "PhieuNX")
        '    '            rptFrom.SetFormulas("Ngay", Format(Ngay(1), Mask_D).ToString)
        '    '            If ms > 0 Then
        '    '                Dim tenkh1 As String, DiaChiKH As String, faxkh As String, emailkh As String, daidienkh As String, chucvukh As String
        '    '                tenkh1 = GetSelectValue("select ten as f1,diachi as f2, fax as f3, email as f4, daidien as f5, ghichu as f6,tel as f7,taikhoan as f8 from khachhang where maso = " + CStr(ms), DiaChiKH, faxkh, emailkh, daidienkh, chucvukh, dienthoaikh, taikhoankh)
        '    '                rptFrom.SetFormulas("TenKH", CStr(tenkh1))
        '    '                rptFrom.SetFormulas("DiachiKH", CStr(DiaChiKH))
        '    '                rptFrom.SetFormulas("DC1", String.Format("'{0} - {1} - {2}'", frmMain._LbCty_2.Text, frmMain._LbCty_10.Text, frmMain._LbCty_11.Text))
        '    '                rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", DiaChiBH))
        '    '                rptFrom.SetFormulas("MS2", String.Format("'{0}'", MSTBH))
        '    '                rptFrom.SetFormulas("TenNN", String.Format("'{0}'", TenBH))
        '    '                rptFrom.SetFormulas("Kho", String.Format("'{0}'", CboNguon(1).Text))
        '    '                If Index = 4 Then
        '    '                    rptFrom.SetFormulas("daidienkh", CStr(daidienkh))
        '    '                    rptFrom.SetFormulas("SoNgayTT", CStr(txtchungtu(8).Text))
        '    '                    rptFrom.SetFormulas("faxkh", CStr(faxkh))
        '    '                    rptFrom.SetFormulas("emailkh", CStr(emailkh))
        '    '                    rptFrom.SetFormulas("chucvukh", CStr(chucvukh))
        '    '                End If
        '    '            End If
        '    '            rptFrom.ReportWindowTitle = ReportFilename
        '    'InBaoCaoRPT()
        'Else
        '    ' If Index = 4 Then frmMain.rpt.ReportFileName = "Thoathuan.RPT"
        '    InBaoCaoRPT()
        'End If
        InBaoCaoRPT()
        If (Index = 0 Or Index = 3) And lanin = 0 Then
            lanin += 1
            lp = IIf(lp < 0, 1, -1)
            If CoPSTK(shtk, lp, X) Then
                tienNT = 0
                sodu = 0
                GoTo C1
            End If
        End If
        TK = Nothing
        vt = Nothing
        tp = Nothing
    End Sub

    Function Thanhtoan() As String
        Dim result As String = String.Empty
        result = "0"
        With GrdChungtu
            .Col = 1
            For i As Integer = 0 To .Rows - 1
                .Row = i
                If Strings.Left(.Items(.Row).SubItems(.Col).Text, 3) = "111" Then
                    result = "111"
                    Exit For
                ElseIf Strings.Left(.Items(.Row).SubItems(.Col).Text, 3) = "131" Then
                    result = "131"
                    Exit For
                ElseIf Strings.Left(.Items(.Row).SubItems(.Col).Text, 3) = "112" Then
                    result = "112"
                    Exit For
                End If
            Next
        End With
        Return result
    End Function
    Private Sub CmdThemTK_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CmdThemTK.Click
        FrmTaikhoantudong.loai = loaict
        FrmTaikhoantudong.loai1 = ConvertToDblSafe(loai1.Tag)
        FrmTaikhoantudong.loaino = ConvertToDblSafe(loaino.Tag)
        FrmTaikhoantudong.ShowDialog()
    End Sub
    '====================================================================================================
    ' Các chức năng thêm, ghi, xóa
    '====================================================================================================
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_0.Click, _Command_1.Click, _Command_2.Click, _Command_3.Click, _Command_4.Click, _Command_5.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim Chungtu As New ClsChungtu
        Dim mtc, mvt, mtk, mtk2, mtc2 As Integer
        Dim psnt, sops, psnt2 As Double
        Dim MaCT, MaTP As Integer
        Dim GhiChu, sh As String
        Dim mhdx, loai, j As Integer
        Dim bg As Boolean
        Dim rs_chungtu As DataTable
        Dim i As Integer
        Dim ctdx, MN, mk, m As Integer
        Dim sql As String = String.Empty
        Dim X As New ClsTaikhoan
        Dim thang As Integer
        Dim shcc As String = String.Empty
        Dim mscc As Integer
        Dim Hoi As Boolean
        Me.Cursor = Cursors.WaitCursor
        Dim ten As New StringBuilder
        Dim rs_mats As DataTable
        Dim NTmaso, NTi As Integer
        Dim NTct As New ClsChungtu
        Dim mact1, masohd, MaKhachHang As Integer
        Dim ct As New ClsChungtu
        Dim rs1Item As DataTable
        Dim SoHieu As String = String.Empty
        Dim ngay1 As Date
        Dim MaCTCC As Double
        Dim sohieucongcu As String = String.Empty
        Dim rsccxoa As DataTable
        Dim dong, cot As Integer
        Dim co2, co1, co3 As Integer
        Dim Grdtext As String

        Ngay(0) = IIf(Ngay(0) = "#12:00:00 AM#", ConvertToDateSafe(MedNgay(0).Text), Ngay(0))
        Ngay(1) = IIf(Ngay(1) = "#12:00:00 AM#", ConvertToDateSafe(MedNgay(1).Text), Ngay(1))

        Select Case Index
            Case 0
                Text = Setcaption()
                MaSoCT = 0
                Command_ClickEvent(Command(2), New EventArgs())
                If shct.Length > 0 Then txt(0).Text = SHCtuMoi(shct)
                ResetDuLieu()
                If loaict = 1 Then
                    txt(1).Text = Ngonngu("Nhập hàng ", "Imported goods ")
                ElseIf loaict = 8 Then
                    txt(1).Text = Ngonngu("Bán hàng ", "Sales ")
                End If
                txt(0).Focus()
            Case 1
                'Kiểm tra tạo chứng từ thuế nhập khẩu
                co3 = MaSoCT
                With GrdChungtu
                    .Rows = (.Rows + 1)
                    co1 = 0 : co2 = 0
                    Dim bien As String = ""
                    For i = 0 To GrdChungtu.Rows - 1
                        bien = .Items(i).SubItems(1).Text
                        If bien Like "111*" OrElse bien Like "112*" Then co1 = 1
                        If bien Like "333121*" Then co2 = 1
                        If co1 = 1 And co2 = 1 Then Exit For
                    Next
                    'While .Items(.Row).SubItems(.Col).Text.Length <> 0
                    '    If strings.left(.Items(.Row).SubItems(.Col).Text, 3) = "111" OrElse strings.left(.Items(.Row).SubItems(.Col).Text, 3) = "112" Then co1 = 1
                    '    If strings.left(.Items(.Row).SubItems(.Col).Text, 6) = "333121" Then co2 = 1
                    '    .Row = (.Row + 1)
                    '    If co1 = 1 And co2 = 1 Then .Row = (.Row - 1)
                    'End While
                End With
                'Kiểm tra tạo chứng từ nhập tháng trước
                If ChkHNT.Visible And ChkHNT.CheckState = CheckState.Checked And loaict = 1 Then
                    With GrdChungtu
                        dong = .Row : cot = .Col
                        .Row = 0 : .Col = 1
                        Dim bien3 As String = ""
                        If GrdChungtu.Rows > 0 Then
                            bien3 = .Items(.Row).SubItems(1).Text
                        End If
                        ' bien3 = .Items(.Row).SubItems(1).Text
                        For i = 0 To GrdChungtu.Rows - 1
                            If bien3.Length <> 0 Then
                                If .Items(.Row).SubItems(.Col).Text Like "331*" Then
                                    MessageBox.Show(Ngonngu("Không tạo được chứng từ nhập khi có công nợ !", "Can not create coucher enter upon the debt !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information) : GoTo XongCT
                                End If
                            End If
                            bien3 = .Items(i).SubItems(1).Text
                        Next
                        .Row = dong : .Col = cot
                    End With
                End If
                'Kiểm tra khoá dữ liệu trong tháng
                If MaSoCT > 0 Then
                    thang = ConvertToDblSafe(GetSelectValue(String.Format("SELECT thangct as f1 FROM ChungTu WHERE MaCT={0}", MaSoCT)))
                    If ConvertToDblSafe(Strings.Right((GetSelectValue(String.Format("SELECT lock{0} as f1 FROM license", thang))), 1)) = 1 Then
                        If FrmPassword.GetPswX("Dữ liệu đã bị khoá. Nhập mật khẩu ...") <> "MS" Then GoTo XongCT
                    End If
                Else
                    If ConvertToDblSafe(Strings.Right((GetSelectValue(String.Format("SELECT lock{0} as f1 FROM license", CboThang.SelectedValue))), 1)) = 1 Then
                        If FrmPassword.GetPswX("Dữ liệu đã bị khoá. Nhập mật khẩu ...") <> "MS" Then GoTo XongCT
                    End If
                End If
                If Not KiemTraChungtu() Then
                    Hoi = True : GoTo XongCT
                End If
                LockDB()
                If MaSoCT > 0 Then
                    If pPhieu = 0 And pMaBG = 0 Then
                        rs_chungtu = ExecSQLReturnDT(String.Format("SELECT MaSo FROM ChungTu WHERE MaCT={0}", MaSoCT))
                        If loaict = 2 Then
                            With GrdChungtu
                                dong = .Row : cot = .Col
                                .Col = 1
                                i = 0
                                .Row = i
                                Dim bien2 As String = ""
                                If GrdChungtu.Rows > 0 Then
                                    bien2 = .Items(.Row).SubItems(1).Text
                                End If
                                ' bien2 = .Items(.Row).SubItems(1).Text
                                For i2 = 0 To GrdChungtu.Rows - 1
                                    If bien2 <> "" Then
                                        If .Items(.Row).SubItems(.Col).Text Like "1421*" Or .Items(.Row).SubItems(.Col).Text Like "242*" Then
                                            sohieucongcu = Timten("sohieu", ConvertToStrSafe(MaSoCT), "mact", "chungtu")
                                            If sohieucongcu.Length > 2 And sohieucongcu.EndsWith("XT") Then MaCTCC = ConvertToDblSafe(Timten("mact", Strings.Left(sohieucongcu, sohieucongcu.Length - 2), "sohieu", "Chungtu"))
                                            mscc = ConvertToDblSafe((GetSelectValue(String.Format("SELECT cc.maso as f1,namkh as f2 FROM congcudungcu cc inner join ctcongcudungcu ctcc on cc.shct=ctcc.sohieu WHERE ctcc.mactkt={0}", MaCTCC), sokyphanbo)))
                                            If mscc <> 0 Then
                                                ExecSQLNonQuery(String.Format("DELETE  FROM thongso1 WHERE mats={0}", mscc))
                                            End If
                                            ExecSQLNonQuery(String.Format("DELETE  FROM congcudungcu WHERE maso={0}", mscc))
                                            ExecSQLNonQuery(String.Format("DELETE  FROM ctcongcudungcu WHERE mats={0}", mscc))
                                            GoTo DaXoa1
                                        End If
                                    End If
                                    bien2 = GrdChungtu.Items(i2).SubItems(1).Text
                                Next
                                'While .Items(.Row).SubItems(.Col).Text <> ""
                                '    .Row = i
                                '    If Strings.Left(.Items(.Row).SubItems(.Col).Text, 4) = "1421" Or Strings.Left(.Items(.Row).SubItems(.Col).Text, 3) = "242" Then
                                '        sohieucongcu = Timten("sohieu", ConvertToStrSafe(MaSoCT), "mact", "chungtu")
                                '        If sohieucongcu.Length > 2 And sohieucongcu.EndsWith("XT") Then MaCTCC = ConvertToDblSafe(Timten("mact", Strings.Left(sohieucongcu, sohieucongcu.Length - 2), "sohieu", "Chungtu"))
                                '        mscc = ConvertToDblSafe((GetSelectValue(String.Format("SELECT cc.maso as f1,namkh as f2 FROM congcudungcu cc inner join ctcongcudungcu ctcc on cc.shct=ctcc.sohieu WHERE ctcc.mactkt={0}", MaCTCC), sokyphanbo)))
                                '        If mscc <> 0 Then
                                '            ExecSQLNonQuery(String.Format("DELETE  FROM thongso1 WHERE mats={0}", mscc))
                                '        End If
                                '        ExecSQLNonQuery(String.Format("DELETE  FROM congcudungcu WHERE maso={0}", mscc))
                                '        ExecSQLNonQuery(String.Format("DELETE  FROM ctcongcudungcu WHERE mats={0}", mscc))
                                '        GoTo DaXoa1
                                '    End If
                                '    i += 1
                                'End While
DaXoa1:
                                .Row = dong : .Col = cot
                            End With
                        End If
                        Dim rs_chungtuIndex As Integer = 0
                        Do While rs_chungtuIndex < rs_chungtu.Rows.Count
                            Dim rs_chungtuItem As DataRow = rs_chungtu.Rows(rs_chungtuIndex)
                            rs_chungtuIndex += 1 ' C15 Rs LOOP CONTROL
                            Chungtu.InitChungtu(rs_chungtuItem("MaSo"), _
                                0, _
                                "", _
                                0, _
                                Ngay(0), _
                                Ngay(1), _
                                0, _
                                0, _
                                "", _
                                0, _
                                0, _
                                0, _
                                0, _
                                0, _
                                0, _
                                "", _
                                0, DateTime.Today)
                            ExecSQLNonQuery("update chungtu set soxuat=soxuat-" + CStr(Chungtu.SoPS2Co) + " where maso=" + CStr(Chungtu.CT_ID))
                            ExecSQLNonQuery("update chungtu set soxuat=soxuat-" + CStr(Chungtu.sops) + " where mact=" + CStr(Chungtu.CT_ID) + " and soxuat>0")
                            Chungtu.XoaChungtu()
                            'rs_chungtu.MoveNext()
                        Loop
                        ''rs_chungtu.Close()
                        rs_chungtu = Nothing
                    Else
                        XoaPhieu(MaSoCT)
                    End If
                    If loaict = 9 Then SuaChungtuTS(MaSoCT)
                    If loaict = 13 Then SuaChungtuCCDC(MaSoCT)
                    MaCT = MaSoCT
                    MaSoCT = 0
                Else
                    MaCT = Lng_MaxValue("MaCT", String.Format("ChungTu{0}", (IIf((pBaoGia = 1 And Chk.CheckState = CheckState.Checked) Or (pPhieu > 0), "P", "")))) + 1
                End If
                bg = (IIf(SoPSConLai() * Mask_N > 0, Math.Floor(SoPSConLai() * Mask_N), Math.Ceiling(SoPSConLai() * Mask_N))) <> 0 And loaict = 7
                mhdx = -1
                'Tạo diễn giải nhập hàng và bán hàng
                ten = New StringBuilder(txt(1).Text.Trim())
                If (ten.ToString().ToLower().Trim Like Ngonngu("bán hàng", "sales") Or ten.ToString().ToLower().Trim Like Ngonngu("nhập hàng", "imported goods")) And (loaict = 1 Or loaict = 8) Then
                    With GrdChungtu
                        For i = 0 To .Rows - 1
                            .Row = i : .Col = 1
                            If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit For
                            If .Items(.Row).SubItems(.Col).Text Like "1311*" Or .Items(.Row).SubItems(.Col).Text Like "3311*" Then
                                .Col = 3
                                ten.Append(String.Format(" - {0}", Timten("ten", .Items(.Row).SubItems(.Col).Text, "sohieu", "khachhang")))
                                Exit For
                            Else
                                If .Items(.Row).SubItems(.Col).Text Like "1111*" Then
                                    ten.Append(String.Format(" - {0}", Timten("ten", ConvertToStrSafe(MaKHBH), "maso", "khachhang")))
                                    Exit For
                                End If
                            End If
                        Next
                    End With
                End If
                txt(1).Text = ten.ToString()
                With GrdChungtu
                    For i = 0 To .Rows - 1
                        .Row = i
                        sql = .Items(.Row).SubItems(1).Text
                        If .Items(.Row).SubItems(8).Text.Length = 0 Then Exit For
                        mtk = ConvertToDblSafe(.Items(.Row).SubItems(8).Text)
                        MaTP = ConvertToDblSafe(.Items(.Row).SubItems(21).Text)
                        MN = ConvertToDblSafe(.Items(.Row).SubItems(9).Text)
                        If sql Like "155*" Or .Items(.Row).SubItems(14).Text.Length > 0 Or ((pHachToan = 0 Or MN > 0 Or bg) And Not xddu) Or (((sql Like "3331*") Or (sql Like pVATV & "*")) And (.Items(.Row).SubItems(14).Text.Length > 0 Or loaict = 8)) Then
                            mtc = ConvertToDblSafe(.Items(.Row).SubItems(11).Text)
                            mvt = ConvertToDblSafe(.Items(.Row).SubItems(9).Text)
                            If mvt = 0 And (Not nhieunoco) Then
                                mvt = ConvertToDblSafe(.Items(.Row).SubItems(15).Text)
                            End If
                            psnt = ConvertToDblSafe(.Items(.Row).SubItems(4).Text)
                            sops = ConvertToDblSafe(.Items(.Row).SubItems(6).Text)
                            If sops = 0 Then
                                loai = 1
                                sops = ConvertToDblSafe(.Items(.Row).SubItems(7).Text)
                                If sops = 0 Then
                                    If (sql Like pVATV & "*" Or (sql Like "15*") And loaict = 1) Then loai = -1
                                End If
                            Else
                                loai = -1
                            End If
                            If nhieunoco Then
                                GhiChu = .Items(.Row).SubItems(14).Text
                                mtk2 = 0
                                mtc2 = 0
                            Else
                                GhiChu = "..."
                                mtc2 = ConvertToDblSafe((.Items(.Row).SubItems(14).Text))
                                If mtc2 = -1 Then
                                    MessageBox.Show(Ngonngu("Không xác định được đối ứng !", "Not determine the reciprocal !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    GoTo XongCT
                                End If

                                mtk2 = ConvertToDblSafe(.Items(.Row).SubItems(13).Text)
                                If loaict = 1 And (Timten("sohieu", ConvertToStrSafe(mtk2), "maso", "HethongTK")) Like "155*" Then mtk2 = 0
                                psnt2 = ConvertToDblSafe(.Items(.Row).SubItems(16).Text)
                            End If
                            MN = IIf(loaict = 1 Or loaict = 2 Or loaict = 7 Or loaict = 8 Or loaict = 13, CboNguon(0).SelectedValue, 0)
                            mk = IIf(loaict = 1 Or loaict = 2 Or loaict = 7 Or loaict = 8 Or loaict = 13, CboNguon(1).SelectedValue, 0)
                            Dim nguon As Integer = 0
                            If CboNguon(2).Items.Count > 0 Then
                                nguon = CboNguon(2).SelectedValue
                            End If
                            If loai < 0 Then
                                Chungtu.InitChungtu(0, _
                                    loaict, _
                                    txt(0).Text, _
                                    CboThang.SelectedValue, _
                                    Ngay(0), _
                                    Ngay(1), _
                                    MN, _
                                    mk, _
                                    txt(1).Text, _
                                    mtk, _
                                    mtk2, _
                                    sops, _
                                    psnt, _
                                    psnt2, _
                                    mvt, _
                                    GhiChu, _
                                    nguon, DateTime.Today)
                            Else
                                Chungtu.InitChungtu(0, _
                                    loaict, _
                                    txt(0).Text, _
                                    CboThang.SelectedValue, _
                                    Ngay(0), _
                                    Ngay(1), _
                                    MN, _
                                    mk, _
                                    txt(1).Text, _
                                    mtk2, _
                                    mtk, _
                                    sops, _
                                    psnt2, _
                                    psnt, _
                                    mvt, _
                                    GhiChu, _
                                    nguon, DateTime.Today)
                            End If
                            Chungtu.MaCT = MaCT
                        Else
                            If ConvertToDblSafe(.Items(.Row).SubItems(10).Text) = 1 Or bg Then
                                MaTP = ConvertToDblSafe(.Items(.Row).SubItems(21).Text)
                                mtc = ConvertToDblSafe(.Items(.Row).SubItems(11).Text)
                                mvt = ConvertToDblSafe(.Items(.Row).SubItems(9).Text)
                                psnt = ConvertToDblSafe(.Items(.Row).SubItems(4).Text)
                                sops = ConvertToDblSafe(.Items(.Row).SubItems(6).Text)
                                If sops = 0 Then
                                    loai = 1
                                    sops = ConvertToDblSafe(.Items(.Row).SubItems(7).Text)
                                Else
                                    loai = -1
                                End If
                                MN = IIf(loaict = 1 Or loaict = 2 Or loaict = 7 Or loaict = 8 Or loaict = 13, VB6.GetItemData(CboNguon(0), CboNguon(0).SelectedIndex), 0)
                                mk = IIf(loaict = 1 Or loaict = 2 Or loaict = 7 Or loaict = 8 Or loaict = 13, VB6.GetItemData(CboNguon(1), CboNguon(1).SelectedIndex), 0)
                                'Ngay(0) = IIf(Ngay(0) = "#12:00:00 AM#", MedNgay(0).Text, Ngay(0))
                                'Ngay(1) = IIf(Ngay(1) = "#12:00:00 AM#", MedNgay(1).Text, Ngay(1))
                                If loai < 0 Then
                                    Chungtu.InitChungtu(0, _
                                        loaict, _
                                        txt(0).Text, _
                                        CboThang.SelectedValue, _
                                        Ngay(0), _
                                        Ngay(1), _
                                        MN, _
                                        mk, _
                                        txt(1).Text, _
                                        mtk, _
                                        0, _
                                        sops, _
                                        psnt, _
                                        0, _
                                        mvt, _
                                        "...", _
                                        CboNguon(2).SelectedValue, DateTime.Today)
                                Else
                                    Chungtu.InitChungtu(0, _
                                        loaict, _
                                        txt(0).Text, _
                                        CboThang.SelectedValue, _
                                        Ngay(0), _
                                        Ngay(1), _
                                        MN, _
                                        mk, _
                                        txt(1).Text, _
                                        0, _
                                        mtk, _
                                        sops, _
                                        0, _
                                        psnt, _
                                        mvt, _
                                        "...", _
                                        CboNguon(2).SelectedValue, DateTime.Today)
                                End If
                                Chungtu.MaCT = MaCT
                            Else
                                Chungtu.MaCT = 0
                            End If
                        End If
                        If Chungtu.MaCT > 0 Then
                            Chungtu.CT_ID = ConvertToDblSafe(.Items(.Row).SubItems(12).Text)
                            If (mvt > 0 And loaict = 2) Or (Chungtu.TkCo.tk_id = TKCNKH_ID) Or (Chungtu.tkno.tk_id = TKCNPT_ID) Then Chungtu.CT_ID = CInt(-Math.Abs(Chungtu.CT_ID))
                            Chungtu.makh = ConvertToDblSafe(.Items(.Row).SubItems(17).Text)
                            Chungtu.MaKHC = ConvertToDblSafe(.Items(.Row).SubItems(20).Text)
                            Chungtu.CTGS = IIf(CboNguon(3).SelectedValue.ToString = "", 0, CboNguon(3).SelectedValue)
                            Chungtu.MaTP = MaTP
                            m = ConvertToDblSafe(.Items(.Row).SubItems(23).Text)
                            If mvt > 0 And m > 0 Then
                                If KtraDVT(mvt, m, sql) Then
                                    If Chungtu.tkno.tk_id = TKVT_ID And loaict = 1 Then
                                        Chungtu.SoPS2No = QuyDoiTheoDVT1(mvt, m, Chungtu.SoPS2No)
                                    End If
                                    If ((Chungtu.TkCo.tk_id = TKDT_ID Or Chungtu.TkCo.tk_id = TKGT_ID) And loaict = 8) Or (Chungtu.TkCo.tk_id = TKVT_ID And loaict = 2) Then
                                        Chungtu.SoPS2Co = QuyDoiTheoDVT1(mvt, m, Chungtu.SoPS2Co)
                                    End If
                                    If (loaict = 1 Or loaict = 2 Or loaict = 7 Or loaict = 8) And Chungtu.MaVattu > 0 Then Chungtu.dvt = m
                                End If
                            End If
                            Chungtu.User_ID = UserID
                            If pCongNoHD > 0 Then Chungtu.HanTT = ConvertToDblSafe(txtchungtu(8).Text)
                            If pSongNgu Then Chungtu.DienGiaiE = txt(2).Text
                            If pGiaUSD > 0 And (loaict = 1 Or loaict = 2 Or loaict = 8) And mvt > 0 Then
                                Chungtu.PSUSD = ConvertToDblSafe(.Items(.Row).SubItems(24).Text)
                            End If
                            If pTygia > 0 Then Chungtu.tygia = ConvertToDblSafe(txtchungtu(7).Text)
                            If loaict = 8 And pNVBH > 0 Then Chungtu.MaNV = ConvertToDblSafe((txt(3).Tag))
                            If loaict = 8 And Chk.CheckState = CheckState.Checked Then Chungtu.maloai = 7
                            If loaict = 7 And Chk.CheckState = CheckState.Unchecked Then Chungtu.maloai = 8
                            If loaict = 8 And (Chungtu.tkno.tk_id = TKGT_ID And Chungtu.MaVattu = 0) Then
                                Chungtu.TLCK = ConvertToDblSafe(.Items(.Row).SubItems(3).Text)
                            End If
                            If (loaict = 8) And Chungtu.MaVattu > 0 Then
                                Chungtu.TLCK = ConvertToDblSafe(.Items(.Row).SubItems(25).Text)
                                Chungtu.CK = ConvertToDblSafe(.Items(.Row).SubItems(26).Text)
                            End If
                            If pSoVV > 0 And CboVV(0).SelectedIndex >= 0 Then Chungtu.MaDT1 = CboVV(0).SelectedValue
                            If pSoVV > 1 And CboVV(1).SelectedIndex >= 0 Then Chungtu.MaDT2 = CboVV(1).SelectedValue
                            If pSoVV > 2 And CboVV(2).SelectedIndex >= 0 Then Chungtu.MaDT3 = CboVV(2).SelectedValue
                            If (Chungtu.tkno.sohieu Like "153*" And loaict = 1 And chkXT.CheckState = CheckState.Checked) Or (((Chungtu.TkCo.sohieu Like "15*" And loaict = 2) Or loaict = 0) And (Chungtu.tkno.sohieu Like "1421*" Or Chungtu.tkno.sohieu Like "242*")) Then
                                GhiChungtuCCDC(MaCT, Chungtu)
                            End If
                            dong = .Row : cot = .Col
                            .Col = 1
                            If Mahopdong <> 0 Then
                                .Row = dong
                                If (.Items(.Row).SubItems(.Col).Text Like "1422*" Or .Items(.Row).SubItems(.Col).Text Like "1423*") And (loaict = 1 Or loaict = 0) Then
                                    .Col = 3 : Mahopdong = ConvertToDblSafe((Timten("maso", .Items(.Row).SubItems(.Col).Text, "sohieu", "doituongct")))
                                End If
                            Else
                                .Row = 0
                                For ii = 0 To GrdChungtu.Rows - 1
                                    If Mahopdong = 0 And .Items(.Row).SubItems(.Col).Text <> "" Then
                                        If (.Items(.Row).SubItems(.Col).Text Like "1422*" Or .Items(.Row).SubItems(.Col).Text Like "1423*") And (loaict = 1 Or loaict = 0) Then
                                            .Col = 3 : Mahopdong = ConvertToDblSafe((Timten("maso", .Items(.Row).SubItems(.Col).Text, "sohieu", "doituongct")))
                                        End If
                                        .Row = (.Row + 1)
                                    End If
                                Next
                                'While Mahopdong = 0 And .Items(.Row).SubItems(.Col).Text <> ""
                                '    If (strings.left(.Items(.Row).SubItems(.Col).Text, 4) = "1422" Or strings.left(.Items(.Row).SubItems(.Col).Text, 4) = "1423") And (loaict = 1 Or loaict = 0) Then
                                '        .Col = 3 : Mahopdong = ConvertToDblSafe((Timten("maso", .Items(.Row).SubItems(.Col).Text, "sohieu", "doituongct")))
                                '    End If
                                '    .Row = (.Row + 1)
                                'End While
                            End If
                            .Row = dong : .Col = cot
                            Chungtu.mathuchi = mathuchi
                            If Chungtu.GhiChungtu(pPhieu) <> 0 Then GoTo XongCT
                            If pPhieu = 0 And loaict <> 7 Then
                                If mvt > 0 And loaict = 1 Then
                                    .Col = 22
                                    Dim dbNumericTemp As Double
                                    If IsNumeric(.Items(.Row).SubItems(.Col).Text) Then
                                        ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoXuat={0} WHERE MaSo={1}", CStr(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)), ConvertToStrSafe(Chungtu.MaSo)))
                                    End If
                                End If
                            End If
                            .Col = 18
                            If .Items(.Row).SubItems(.Col).Text.Length > 0 Then
                                j = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                If mhdx <> j And j <= hdcount Then
                                    mhdx = j
                                    If mhdx >= 0 Then
                                        LayHoaDon(hd, j)
                                        stuHoadon.MaSo = Chungtu.MaSo
                                        GhiHoaDon(IIf((loaict = 7) Or pPhieu > 0, 1, 0))
                                    End If
                                End If
                            End If
                            If chkXT.CheckState = CheckState.Checked And pPhieu = 0 Then Chungtu.XuatThang(ConvertToDblSafe((txtsh(0).Tag)), ConvertToDblSafe((txtsh(1).Tag)))
                        End If
                    Next
                    Chungtu.MaCT = MaCT
                    If CmdPhieu(0).Visible Or CmdPhieu(3).Visible Then Chungtu.GhiThongtinCT(0, tentc, diachitc, ctgoc, MaKHBH, IIf(pPhieu > 0 Or loaict = 7, 1, 0))
                    If CmdPhieu(1).Visible And loaict <> 7 And loaict <> 8 Then Chungtu.GhiThongtinCT(1, TenNX, DiaChiNX, "...", IIf(Chungtu.makh > 0, Chungtu.makh, Chungtu.MaKHC), IIf(pPhieu > 0 Or loaict = 7, 1, 0))
                    If CmdPhieu(1).Visible And (loaict = 7 Or loaict = 8) Then Chungtu.GhiThongtinCT(2, TenBH, DiaChiBH, String.Format(HanTT, Mask_D), 0, IIf(pPhieu > 0 Or loaict = 7, 1, 0))
                    If CmdPhieu(2).Visible Then Chungtu.GhiThongtinCT(3, unc1, unc2, unc3, 0, IIf(pPhieu > 0 Or loaict = 7, 1, 0))
                    shct = Chungtu.SoHieu
                End With
                If loaict = 9 Or loaict = 10 Or loaict = 11 Or loaict = 12 Then GhiChungtuTS(MaCT)
                If loaict = 13 Or loaict = 14 Then GhiChungtuCCDC(MaCT)
                If loaict = 8 And pBaoGia > 0 And pMaBG > 0 And Chk.CheckState = CheckState.Unchecked Then XoaPhieu(pMaBG)
                UnlockDB()
                XoaPhieuTrenManHinh()
                If loaict <> 9 And loaict <> 13 And shct.Length > 0 Then txt(0).Text = SHCtuMoi(shct)
                txt(0).Focus()

                If ChkHNT.Visible And ChkHNT.CheckState = CheckState.Checked And loaict = 1 Then
                    masohd = ConvertToDblSafe(GetSelectValue(String.Format("SELECT chungtu.maso as f1 FROM chungtu inner join hethongtk on chungtu.matkno=hethongtk.maso WHERE chungtu.mact={0} and hethongtk.sohieu like '133111'", MaCT)))
                    MaKhachHang = ConvertToDblSafe(GetSelectValue(String.Format("SELECT makhachhang as f1 FROM hoadon WHERE maso={0}", masohd)))
                    If MaKhachHang = 0 Then MaKhachHang = ConvertToDblSafe(GetSelectValue(String.Format("SELECT makh as f1 FROM chungtulq WHERE mact={0}", MaCT)))
                    Dim rs1 As DataTable = ExecSQLReturnDT(String.Format("SELECT t1.ngayct FROM chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE t1.mact={0} and t2.sohieu like'15%'", MaCT))
                    Dim rs1Item3 As DataRow = rs1.Rows(0)
                    SoHieu = String.Format("PN{0}{1}{2}{3}01", _
                                 (IIf(CboThang1.SelectedValue < 10, "0", "")), _
                                 ConvertToStrSafe(CboThang1.SelectedValue), _
                                 (IIf(DateAndTime.Day(rs1Item3("NgayCT")) < 10, "0", "")), _
                                 ConvertToStrSafe(DateAndTime.Day(rs1Item3("NgayCT"))))
                    While ConvertToDblSafe(GetSelectValue(String.Format("SELECT maso as f1 FROM chungtu WHERE sohieu=N'{0}'", SoHieu))) <> 0
                        SoHieu = SHCtuMoi(SoHieu)
                    End While
                    Dim NgayCT As Date = ConvertToDateSafe(rs1Item3("NgayCT"))
                    ngay1 = DateAndTime.DateSerial(NgayCT.Year, CboThang1.SelectedValue, NgayCT.Day)
                    ExecSQLNonQuery(String.Format("UPDATE chungtu SET thangct={0}, ngayct='{1}', ngaygs='{1}', sohieu=N'{2}', makhc={3}, matkco={4}, matktcco={4} WHERE mact={5} AND matkno in ( SELECT t2.MaSo FROM dbo.HeThongTK t2 WHERE t2.sohieu LIKE '15%')", _
                                        CboThang1.SelectedValue, _
                                        Format(ngay1, Mask_DB), _
                                        SoHieu, _
                                        ConvertToStrSafe(MaKhachHang), _
                                        Timten("Maso", taikhoanconnhat("3311"), "Sohieu", "HeThongTK"), _
                                        ConvertToStrSafe(MaCT)))
                    mact1 = Lng_MaxValue("mact", "chungtu") + 1
                    ExecSQLNonQuery((String.Format("UPDATE chungtu SET maloai = 0, DienGiai = 'Thanh toán tiền hàng - {0}', mact = {1} WHERE mact = {2} AND matkno in ( SELECT t2.MaSo  FROM dbo.HeThongTK t2  WHERE t2.sohieu LIKE '133%' )", SoHieu, ConvertToStrSafe(mact1), ConvertToStrSafe(MaCT))))
                    ct.InitChungtu(ConvertToDblSafe(Timten("maso", ConvertToStrSafe(mact1), "mact", "chungtu")), _
                        0, _
                        "", _
                        0, _
                        DateTime.Today, _
                        DateTime.Today, _
                        0, _
                        0, _
                        "", _
                        0, _
                        0, _
                        0, _
                        0, _
                        0, _
                        0, _
                        "", _
                        0, DateTime.Today)
                    ct.tkno.InitTaikhoanSohieu(ConvertToDblSafe(taikhoanconnhat("3311")))
                    ct.makh = MaKhachHang
                    ct.sops = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(sops)as f1 FROM chungtu WHERE mact={0}", MaCT)))
                    ct.GhiChungtu()
                    ChkHNT.CheckState = CheckState.Unchecked
                End If
                If (pPhieu = 0 And pGhi > 0) Or tuongkho = 1 Then
                    txt(0).Text = "..." : Me.Hide()
                End If
                ResetDuLieu()
                If loaict = 1 Then
                    txt(1).Text = Ngonngu("Nhập hàng ", "Imported goods ")
                ElseIf loaict = 8 Then
                    txt(1).Text = Ngonngu("Bán hàng ", "Sales ")
                End If
                If co1 = 1 And co2 = 1 Then
                    NTmaso = ConvertToDblSafe(GetSelectValue(String.Format("SELECT t1.maso as f1 FROM chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE t1.mact={0} and left(t2.sohieu,6)='333121'", MaCT)))
                    NTct.InitChungtu(NTmaso, _
                        0, _
                        "", _
                        0, _
                        DateTime.Today, _
                        DateTime.Today, _
                        0, _
                        0, _
                        "", _
                        0, _
                        0, _
                        0, _
                        0, _
                        0, _
                        0, _
                        "", _
                        0, DateTime.Today)
                    NTct.TkCo.InitTaikhoanMaSo(NTct.tkno.maso)
                    NTct.tkno.InitTaikhoanSohieu("133112")
                    NTct.MaCT = Lng_MaxValue("mact", "chungtu") + 1
                    NTct.SoHieu = String.Format("{0}T", NTct.SoHieu)
                    For NTi = 1 To NTct.DienGiai.Length
                        If Strings.Mid(NTct.DienGiai, NTi, 1) = " " Then Exit For
                    Next
                    If NTi < NTct.DienGiai.Length Then NTct.DienGiai = Strings.Right(NTct.DienGiai, NTct.DienGiai.Length - NTi)
                    NTct.maloai = 0
                    If co3 <> 0 Then
                        ExecSQLNonQuery((String.Format("DELETE  FROM chungtu WHERE sohieu=N'{0}'", NTct.SoHieu)))
                    End If
                    NTct.GhiChungtu()
                End If
            Case 2
                If MaSoCT > 0 Then
                    thang = ConvertToDblSafe(GetSelectValue(String.Format("SELECT thangct as f1 FROM ChungTu WHERE MaCT={0}", MaSoCT)))
                    If ConvertToDblSafe(GetSelectValue(String.Format("SELECT lock{0} as f1 FROM license", thang))) = 1 Then
                        If FrmPassword.GetPswX("Dữ liệu đã bị khoá. Nhập mật khẩu ...") <> "MS" Then GoTo XongCT
                    End If
                    If loaict = 1 And chkXT.CheckState = CheckState.Unchecked Then
                        If Not XoaCTOK(MaSoCT) Then
                            MessageBox.Show(Ngonngu("Vật tư nhập đã xuất hết, không xoá chứng từ!", "All materials were exported, not delete the voucher!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            GoTo XongCT
                        End If
                    End If
                    If MessageBox.Show(Ngonngu("Bạn đã chắc chắn xóa chứng từ này ?", "Are you sure you want to delete this voucher?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
                        If loaict = 0 Or loaict = 2 Then
                            With GrdChungtu
                                dong = .Row : cot = .Col
                                .Col = 1
                                i = 0
                                While .Items(.Row).SubItems(.Col).Text <> "" And i < .Rows
                                    .Row = i
                                    If .Items(.Row).SubItems(.Col).Text Like "1421*" Or .Items(.Row).SubItems(.Col).Text Like "242*" Then
                                        shcc = "" : mscc = 0
                                        mscc = ConvertToDblSafe((GetSelectValue(String.Format("SELECT cc.maso as f1,cc.shct as f2 FROM congcudungcu cc inner join ctcongcudungcu ctcc on cc.shct=ctcc.sohieu WHERE ctcc.mactkt={0}", MaSoCT), shcc)))
                                        If mscc <> 0 Then
                                            ExecSQLNonQuery(String.Format("DELETE  FROM thongso1 WHERE mats={0}", mscc))
                                        End If
                                        ExecSQLNonQuery(String.Format("DELETE  FROM congcudungcu WHERE shct=N'{0}'", shcc))
                                        ExecSQLNonQuery(String.Format("DELETE  FROM ctcongcudungcu WHERE mactkt={0}", MaSoCT))
                                        GoTo DaXoa
                                    End If
                                    i += 1
                                End While
DaXoa:
                                .Row = dong : .Col = cot
                            End With
                        End If
                        If pPhieu > 0 Or pMaBG > 0 Then
                            XoaPhieu(MaSoCT)
                        Else
                            If loaict = 9 Then XoaChungtuTS(loaict, MaSoCT)
                            If loaict = 13 Then XoaChungtuCCDC(loaict, MaSoCT)
                            LockDB()
                            rs_chungtu = ExecSQLReturnDT(String.Format("SELECT MaLoai, MaSo, SoPS2Co, MaVattu FROM ChungTu WHERE MaCT={0}", MaSoCT))
                            If loaict <> 9 And loaict <> 13 Then
                                Dim rs_chungtuItem As DataRow = rs_chungtu.Rows(0)
                                If ConvertToStrSafe(rs_chungtuItem("maloai")) = 1 And OutCost > 0 Then
                                    Dim rs_chungtuIndex2 As Integer = 0
                                    Do While rs_chungtuIndex2 < rs_chungtu.Rows.Count
                                        rs_chungtuItem = rs_chungtu.Rows(rs_chungtuIndex2)
                                        rs_chungtuIndex2 += 1 ' C15 Rs LOOP CONTROL
                                        If ConvertToDblSafe(rs_chungtuItem("MaVattu")) > 0 And ConvertToDblSafe(rs_chungtuItem("SoPS2Co")) > 0 Then
                                            rs_chungtu = Nothing
                                            MessageBox.Show(Ngonngu("Chứng từ nhập đã tính giá xuất, không xóa !", "Voucher were calculated exports cost, not deleted"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                            GoTo XongCT
                                        End If
                                    Loop
                                End If
                            End If
                            Dim rs_chungtuIndex As Integer = 0
                            Do While rs_chungtuIndex < rs_chungtu.Rows.Count
                                Dim rs_chungtuItem As DataRow = rs_chungtu.Rows(rs_chungtuIndex)
                                rs_chungtuIndex += 1 ' C15 Rs LOOP CONTROL
                                Chungtu.InitChungtu(rs_chungtuItem("MaSo"), _
                                    0, _
                                    "", _
                                    0, _
                                    Ngay(0), _
                                    Ngay(1), _
                                    0, _
                                    0, _
                                    "", _
                                    0, _
                                    0, _
                                    0, _
                                    0, _
                                    0, _
                                    0, _
                                    "", _
                                    0, DateTime.Today)
                                If loaict = 2 And Chungtu.SoHieu.EndsWith("XT") Then
                                    Dim Mientru As String = String.Format("SELECT mats FROM ctcongcudungcu t1 inner join chungtu t2 on t1.mactkt=t2.mact WHERE t2.sohieu+'XT'=N'{0}' group by mats", Chungtu.SoHieu)
                                    rs_mats = ExecSQLReturnDT(String.Format("SELECT mats as f1 FROM congcudungcu t1 inner join (" & Mientru & ") as Mientru t2 on t1.maso=t2.mats WHERE t1.thangtang={0}", Chungtu.thangct))
                                    Dim rs_matsIndex As Integer = 0
                                    While rs_matsIndex < rs_mats.Rows.Count
                                        Dim rs_matsItem As DataRow = rs_mats.Rows(rs_matsIndex)
                                        rs_matsIndex += 1 ' C15 Rs LOOP CONTROL
                                        If Not Convert.IsDBNull(rs_mats("f1")) Then
                                            If Timten("tenvattu", ConvertToStrSafe(Chungtu.MaVattu), "maso", "vattu") = Timten("ten", rs_matsItem("f1"), "maso", "congcudungcu") Then
                                                ExecSQLNonQuery((String.Format("DELETE  FROM thongso1 WHERE mats={0}", rs_matsItem("f1"))))
                                            End If
                                        End If
                                        'rs_mats.MoveNext()
                                    End While
                                End If
                                ExecSQLNonQuery("update chungtu set soxuat=soxuat-" + CStr(Chungtu.SoPS2Co) + " where maso=" + CStr(Chungtu.CT_ID))
                                ExecSQLNonQuery("update chungtu set soxuat=soxuat-" + CStr(Chungtu.sops) + " where mact=" + CStr(Chungtu.CT_ID) + " and soxuat>0")
                                Chungtu.XoaChungtu()
                                'rs_chungtu.MoveNext()
                            Loop
                            ''rs_chungtu.Close()
                            rs_chungtu = Nothing
                            UnlockDB()
                        End If
                    Else
                        GoTo XongCT
                    End If
                    MaSoCT = 0
                End If
                XoaPhieuTrenManHinh()
                GrdChungtu.Row = 0
                If loaict > 8 Then OptLoai(0).Checked = True
                txt(0).Focus()
                If pPhieu = 0 And pGhi > 0 Or tuongkho = 1 Then Me.Hide()
            Case 3
                Me.Close() : Exit Sub
            Case 4
                If Not KiemTraChungtu() Then GoTo XongCT
                ExecSQLNonQuery("DELETE  FROM BaoCaoCP")
                With GrdChungtu
                    sql = ""
                    For i = 0 To .Rows - 1
                        .Row = i
                        .Col = 1
                        If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit For
                        X.InitTaikhoanSohieu(.Items(.Row).SubItems(.Col).Text)
                        .Col = 6
                        sops = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        If sops <> 0 Then
                            mk = -1
                        Else
                            .Col = 7
                            sops = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                            mk = 1
                        End If
                        If sops <> 0 Then
                            sql = String.Format("INSERT INTO BaoCaoCP (MaSo,SoHieu,Ten,Cap, Kq1) VALUES ({0}, N'{1}', N'{2}'+' - '+N'{3}',{4},{5})", _
                                      i, _
                                      ConvertToStrSafe(i), _
                                      X.sohieu, _
                                      X.ten, _
                                      ConvertToStrSafe(mk), _
                                      doidau(sops))
                            ExecSQLNonQuery(sql)
                        End If
                    Next
                End With

                rptFrom.InitForm("CHUNGTU.RPT", "SELECT * FROM BaocaoCP", "BaocaoCP")

                rptFrom.SetFormulas("SoCT", String.Format("'{0}'", txt(0).Text))
                rptFrom.SetFormulas("NgayCT", String.Format("'{0}'", String.Format(Ngay(0), Mask_DB)))
                rptFrom.SetFormulas("NgayGS", String.Format("'{0}'", String.Format(Ngay(1), Mask_DB)))
                rptFrom.SetFormulas("DienGiai", String.Format("'{0}'", txt(1).Text))
                InBaoCaoRPT()
            Case 5
                If Not BangDaCo("SLHoaDon") Then
                    CreateSLHoaDonTable()
                End If

                SuaSLHoaDon()
                On Error GoTo kt
                frmSLHoaDon.ShowDialog()
        End Select
XongCT:
        Me.Cursor = Cursors.Default
kt:
        Chungtu = Nothing
        X = Nothing
        Kiemtrachiphi()
        Mahopdong = 0
        If Not Hoi And Index = 1 And (loaict = 13 Or loaict = 9 Or loaict = 10) Then
            If loaict = 13 Then
                If MessageBox.Show(Ngonngu("Nhập tiếp chứng từ công cụ cụng cụ", "Continue to enter voucher Tools"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then OptLoai_CheckedChanged(OptLoai(13), New EventArgs()) Else Hide()
            ElseIf loaict = 9 Then
                If MessageBox.Show(Ngonngu("Nhập tiếp chứng từ tài sản cố định", "Continue to enter voucher Assets"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then OptLoai_CheckedChanged(OptLoai(9), New EventArgs()) Else Hide()
            Else
                If MessageBox.Show(Ngonngu("Nhập tiếp chứng từ tài sản cố định", "Continue to enter voucher Assets"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then OptLoai_CheckedChanged(OptLoai(10), New EventArgs()) Else Hide()
            End If
        End If
    End Sub
    ''' <summary>
    ''' Hiển thị cửa sổ danh sách chứng từ và hiển thị chứng từ được chọn
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub CmdDanhSach_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _CmdDanhSach_0.Click, _CmdDanhSach_1.Click
        Dim Index As Integer = Array.IndexOf(CmdDanhSach, eventSender)
        Dim p As Integer
        Dim ma As String = String.Empty
ChonCT:
        Select Case Index
            Case 0
                MaSoCT = FrmDsCTTonghop.ChonCT(p)
            Case 1
                p = pPhieu
                MaSoCT = FrmDsTC.ChonCT()
        End Select
        If MaSoCT > 0 Then
            Me.Refresh()
            Me.Cursor = Cursors.WaitCursor
            If HienPhieuTrenManHinh(p) < 0 Then GoTo ChonCT
        End If
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Dim iIndex As Integer = 0
        Dim Objects() As Object

        iIndex = 0
        Objects = New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"}
        For Each objItem As Object In Objects
            _CboNT_0.Items.Add(objItem.ToString, 0)
            _CboNT_1.Items.Add(objItem.ToString, 0)
            _CboNT_2.Items.Add(objItem.ToString, 0)
            _CboNT_3.Items.Add(objItem.ToString, 0)
            iIndex += 1
        Next

        If pFunction = 10 Then
            pFunction = 0
            txt(0).Focus()
        End If
        HienThongBao(Me.Text, 1)
        If ConvertToDblSafe(Nut.Tag) = 1 Then
            Nut.Tag = "0"
            CmdDanhSach_ClickEvent(CmdDanhSach(0), New EventArgs())
        Else
            If ConvertToDblSafe(Nut.Tag) = 2 Then
                Nut.Tag = "0"
                CmdDanhSach_ClickEvent(CmdDanhSach(1), New EventArgs())
            End If
        End If
        Select Case loaict
            Case 9, 10, 12, 13, 14
                txtchungtu(0).Focus()
        End Select
        KiemtraUser()
        For i As Integer = 19 To 21
            mndd(i).Available = (pNVBH > 0)
        Next
    End Sub
    ''' <summary>
    ''' Xử lý các phím nóng
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmChungtutonghop_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        Dim i As Integer
        If (Shift And 4) > 0 Then
            i = -1
            Select Case eventArgs.KeyCode
                Case Keys.T : i = 0
                Case Keys.G : i = 1
                Case Keys.X : i = 2
                Case Keys.V : i = 3
                Case Keys.I : i = 4
                Case Keys.L
                    If _mnIn_5.Available Then mnIn_Click(_mnIn_5, New EventArgs())
            End Select
            If i >= 0 Then
                If Command(i).Enabled Then
                    Command(i).Focus()
                    'Command_ClickEvent(Command(i), New EventArgs())
                End If
            End If
        End If
        If (Shift And 2) > 0 And eventArgs.KeyCode = Keys.P Then
            frmMain.mnHT_Click(frmMain.mnHT, New EventArgs())
        End If
        If eventArgs.KeyCode = Keys.Escape Then
            bcstop = 1
            Me.Close()
        End If
    End Sub
    ''' <summary>
    ''' Khởi tạo cửa sổ nhập
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmChungtutonghop_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()
            setTabOrderIndex()
            ColumnSetUp(GrdChungtu, 0, 350, 2)
            ColumnSetUp(GrdChungtu, 1, 1060, 2)
            ColumnSetUp(GrdChungtu, 2, 3230, 0)
            ColumnSetUp(GrdChungtu, 3, 1300, 2)
            ColumnSetUp(GrdChungtu, 4, 1070, 4)
            ColumnSetUp(GrdChungtu, 5, 1300, 4)
            ColumnSetUp(GrdChungtu, 6, 1790, 4)
            ColumnSetUp(GrdChungtu, 7, 1835, 4)
            ColumnSetUp(GrdChungtu, 8, 1, 0) ' Cột chứa mã TK
            ColumnSetUp(GrdChungtu, 9, 1, 0) ' Cột chứa mã VT
            ColumnSetUp(GrdChungtu, 10, 1, 0) ' "0" nếu trong bảng, "1" nếu ngoài bảng
            ColumnSetUp(GrdChungtu, 11, 1, 0) ' Mã TKTC
            ColumnSetUp(GrdChungtu, 12, 1, 0) ' Mã phiếu nhập
            ColumnSetUp(GrdChungtu, 13, 1, 0) ' Mã TK chi tiết đối ứng
            ColumnSetUp(GrdChungtu, 14, 1, 0) ' Mã TKTC doi ung
            ColumnSetUp(GrdChungtu, 15, 1, 0) ' Mã vật tư
            ColumnSetUp(GrdChungtu, 16, 1, 0) ' Số lượng
            ColumnSetUp(GrdChungtu, 17, 1, 0) ' MaKH No
            ColumnSetUp(GrdChungtu, 18, 1, 0) ' Ghi chu
            ColumnSetUp(GrdChungtu, 19, 1, 0) ' Ghi chu
            ColumnSetUp(GrdChungtu, 20, 1, 0) ' MaKHCo
            ColumnSetUp(GrdChungtu, 21, 1, 0) ' Ghi chu
            ColumnSetUp(GrdChungtu, 22, 1, 0) ' Ghi chu
            ColumnSetUp(GrdChungtu, 23, 1, 0) ' Đ.v.t
            ColumnSetUp(GrdChungtu, 24, 1, 0) ' price by usd
            ColumnSetUp(GrdChungtu, 25, 750, 4)
            ColumnSetUp(GrdChungtu, 26, 950, 4)

            AddMonthToCbo(CboThang)
            AddMonthToCbo(CboThang1)

            If CboThang.Items.Count > 0 Then
                CboThang.SelectedIndex = CThangDB(Today.Month - 1)
            End If
            If CboThang1.Items.Count > 0 Then
                CboThang1.SelectedIndex = CThangDB(Today.Month - 1)
            End If
            For chi_so As Integer = 0 To 1
                InitDateVars(MedNgay(chi_so), Ngay(chi_so))
            Next
            SetLoaiEnable = True
            '    SetLoaiChungtu 0
            MaSoCT = 0
            ' Liệt kê danh sách kho hàng
            If STDetail Then Int_RecsetToCbo("SELECT MaSo As F2,TenKho As F1 FROM KhoHang ORDER BY TenKho", CboNguon(1))
            If User_Right <> 1 Then
a:
                Int_RecsetToCbo("SELECT MaSo As F2, SoHieu + ' - ' + DienGiai As F1, SoHieu FROM CTGhiSo ORDER BY SoHieu", CboNguon(3))
            Else
                Int_RecsetToCbo(String.Format("SELECT MaSo As F2,SoHieu As F1, SoHieu FROM CTGhiSo INNER JOIN User2 ON CTGhiSo.MaSo=User2.CTGS WHERE User2.[User]={0} ORDER BY SoHieu", UserID), CboNguon(3))
                If CboNguon(3).Items.Count = 0 Then GoTo a
            End If
            Int_RecsetToCbo("SELECT DoituongCT.MaSo As F2,(CASE WHEN (DoituongCT.MaKhachHang>0) THEN KhachHang.Ten+' - '+DoituongCT.Sohieu+' - ' ELSE '' END + DienGiai) As F1, KhachHang.Ten,DoituongCT.SoHieu,DienGiai FROM DoituongCT LEFT JOIN KhachHang ON DoituongCT.MaKhachHang=KhachHang.MaSo ORDER BY  KhachHang.Ten,DoituongCT.SoHieu,DienGiai", CboNguon(2))

            VTEnable = True
            _OptLoai_1.Enabled = STDetail
            _OptLoai_2.Enabled = STDetail
            _OptLoai_8.Enabled = STDetail
            _OptLoai_9.Enabled = FADetail
            _OptLoai_10.Enabled = FADetail
            _OptLoai_11.Enabled = FADetail
            _OptLoai_12.Enabled = FADetail
            _OptLoai_13.Enabled = FADetail
            _OptLoai_14.Enabled = FADetail
            KhongNhapTS = True

            pVAT1 = ConvertToDblSafe(Interaction.GetSetting(IniPath, "Invoice", "VAT1", "0"))
            pVAT2 = ConvertToDblSafe(Interaction.GetSetting(IniPath, "Invoice", "VATCheck", "0"))
            Ppthu = ConvertToDblSafe(Interaction.GetSetting(IniPath, "Environment", "DInvoice", "2"))
            Ppchi = ConvertToDblSafe(Interaction.GetSetting(IniPath, "Environment", "CInvoice", "2"))
            Ppunc = ConvertToDblSafe(Interaction.GetSetting(IniPath, "Environment", "UNC", "2"))
            Phd = ConvertToDblSafe(Interaction.GetSetting(IniPath, "Environment", "HD", "2"))

            hdcount = -1
            Label(15).Visible = (pSoKT Mod 100 >= 10)
            CboNguon(3).Visible = (pSoKT Mod 100 >= 10)
            _mndd_8.Available = (pSoKT Mod 100 >= 10)
            'Label(16).Visible = pSongNgu
            'txt(2).Visible = pSongNgu
            Label(17).Visible = (pTygia > 0)
            txtchungtu(7).Visible = (pTygia > 0)
            pRate = TyGiaNT(0)
            txtchungtu(7).Text = Format(pRate, Mask_2)
            'If pGiaUSD = 0  Then pRate = 1
            Command(1).Enabled = ChoNhapTiep()
            If pPhieu > 0 Then Me.Text = IIf(pNN = 0, "Nhập phiếu", "Template Voucher")
            If pThuChiNhapXuat Then
                If pPhieu = 1 Then
                    _OptLoai_3.Enabled = False
                    For chi_so As Integer = 9 To 14
                        OptLoai(chi_so).Enabled = False
                    Next
                Else
                    For chi_so As Integer = 0 To 2
                        CmdPhieu(chi_so).Enabled = False
                    Next
                End If
            End If
            txtchungtu(8).Visible = (pCongNoHD > 0)
            Label(22).Visible = (pCongNoHD > 0)
            '    If pNVBH = 0 Then txt(1).Width = 8655
            _mnIn_6.Available = (pSoVV > 0)
            For chi_so As Integer = 1 To pSoVV
                LbTT(chi_so - 1).Visible = True
                CboVV(chi_so - 1).Visible = True
                mnIn(6 + chi_so).Available = True
                Int_RecsetToCbo(String.Format("SELECT MaSo As F2,DienGiai As F1, DoituongCT{1}.DienGiai FROM DoituongCT{0} ORDER BY DoituongCT{1}.DienGiai", _
                                    chi_so, _
                                    ConvertToStrSafe(chi_so)), CboVV(chi_so - 1))
            Next

            If initOption > -1 Then
                OptLoai(initOption).Checked = True
            End If
            ResetDuLieu()
            SetFont(Me)
            SetFontToolTip()
            SetFontBar()
        Catch ex As Exception
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub SetFontToolTip()
        Dim s As String
        If pNN = 1 Then
            With Me
                For i = 0 To .Controls.Count - 1
                    If TypeOf .Controls(i) Is RadioButton Then
                        s = ToolTipMain.GetToolTip(.Controls(i))
                        If s.Length > 0 And IsNumeric(.Controls(i).Tag) And Not TypeOf .Controls(i) Is TextBox Then
                            s = ToolTipMain.GetToolTip(.Controls(i))
                            ToolTipMain.SetToolTip(.Controls(i), .Controls(i).Text)
                            .Controls(i).Text = s
                        End If
                    End If
                Next
            End With
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmChungtutonghop_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        If pNghiepVu = NV_TANG Then
            For i As Integer = 0 To tscount
                XoaTaiSan(MaTS(i))
            Next
        End If
        Ngay(0) = DateTime.Today
        Ngay(1) = DateTime.Today
        pGhichungtu = 0
        pNghiepVu = 0
        pMaTaiSan = 0
        pMaCongcudungcu = 0
        taikhoan = Nothing
        vattu = Nothing
        ckh = Nothing
        tp = Nothing
        Erase hd
        Try
            FrmDsCTTonghop.Close()
            FrmDsTC.Close()
        Catch exc As System.Exception
        End Try
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdChungtu_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdChungtu.DoubleClick
        Dim r As Integer
        With GrdChungtu
            .Col = 1
            r = .Row
            If .Items(.Row).SubItems(.Col).Text Is Nothing Then Exit Sub
            CmdChitiet.Tag = ConvertToStrSafe(.Row)
            taikhoan.InitTaikhoanSohieu(.Items(.Row).SubItems(.Col).Text)
            If FADetail And (taikhoan.tk_id = TSCD_ID Or taikhoan.tk_id = KHTSCD_ID Or (Strings.Left(.Items(.Row).SubItems(.Col).Text, 3)) = "153") And _OptLoai_13.Checked Then Exit Sub
            For i As Integer = 0 To 6
                .Col = ConvertToDblSafe(i + 1)
                txtchungtu(i).Text = .Items(.Row).SubItems(.Col).Text
            Next
            If taikhoan.tk_id = GTGTKT_ID Or taikhoan.tk_id = GTGTPN_ID Or taikhoan.tk_id = TTDB_ID Then
                .Col = 18
                If IsNumeric(.Items(.Row).SubItems(.Col).Text) Then
                    LayHoaDon(hd, ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text))
                    stuHoadon.MaSo = 0
                End If
            End If
            _txtchungtu_LostFocus(txtchungtu(2), New EventArgs())
            .Col = 23
            If loaict = 1 And ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) > 0 And CboNT(2).Items.Count > 1 Then CboNT(2).SelectedIndex = 1
            If loaict = 8 And pChietKhau > 0 Then
                .Col = 25
                txtchungtu(9).Text = .Items(.Row).SubItems(.Col).Text
                .Col = 26
                txtchungtu(10).Text = .Items(.Row).SubItems(.Col).Text
            End If
            If pGiaUSD > 0 Then
                .Col = 24
                txtchungtu(11).Text = .Items(.Row).SubItems(.Col).Text
            End If
            .Row = ConvertToDblSafe(r)
            .RemoveItem(.Row)
            If .Rows < ConvertToDblSafe(.Tag) Then .Rows = ConvertToDblSafe(.Tag)
            If loaict = 2 Or loaict = 8 Then
                xddu = SetDoiUng(1)
                If Not xddu Then xddu = SetDoiUng()
            Else
                xddu = SetDoiUng()
                If Not xddu Then xddu = SetDoiUng(1)
            End If
        End With
        txtchungtu(0).Focus()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdChungtu_KeyPressEvent(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles GrdChungtu.KeyPress
        If eventArgs.KeyChar = Chr(Keys.Enter) Then GrdChungtu_DblClick(GrdChungtu, New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdChungtu_MouseDownEvent(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles GrdChungtu.MouseDown
        If eventArgs.Button = MouseButtons.Right Then
            SearchObj(1, , GrdChungtu, GrdChungtu.Col)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Kiemtrachiphi()
        Dim dong1, dong, i, cot, cot1, MaDT As Integer
        With GrdChungtu
            dong = .Row : cot = .Col
            .Col = 1 : .Row = 0
            i = 1
            While i <= .Rows
                If .Items(.Row).SubItems(.Col).Text.Length > 0 Then
                    If (.Items(.Row).SubItems(.Col).Text Like "1421*" Or .Items(.Row).SubItems(.Col).Text Like "242*") And (OptLoai(0).Checked Or OptLoai(2).Checked) Then
                        Int_RecsetToCbo(String.Format("SELECT SoHieu + ' - ' + Ten AS F1, MaSo as F2 FROM HethongTK WHERE TK_ID2 = {0} AND TKCon = 0 ORDER BY SoHieu", TKCPSX_ID), CboDoituong)
                        ChkDoiTuong.Visible = True : CboDoituong.Visible = True
                        If txt(0).Text.Length >= 3 Then
                            If ConvertToDblSafe(Timten("namkh", txt(0).Text, "shct", "congcudungcu")) Or (ConvertToDblSafe(Timten("namkh", txt(0).Text.Substring(0, txt(0).Text.Length - 2), "shct", "congcudungcu")) And txt(0).Text.ToUpper().EndsWith("XT")) Or (ConvertToDblSafe(Timten("namkh", txt(0).Text.Substring(0, txt(0).Text.Length - 3), "shct", "congcudungcu")) And txt(0).Text.ToUpper() Like "XT*") Then
                                ChkDoiTuong.CheckState = CheckState.Checked
                            Else
                                ChkDoiTuong.CheckState = CheckState.Unchecked
                            End If
                            dong1 = .Row : cot1 = .Col
                            If .Row > 0 Then .Row = ConvertToDblSafe(.Row - 1)
                            .Col = 3
                            MaDT = ConvertToDblSafe(GetSelectValue(String.Format("SELECT madtsd as f1 FROM thongso1 ts inner join congcudungcu cc on ts.mats=cc.maso WHERE cc.sohieu=N'{0}' and (cc.shct=N'{1}' or (cc.shct=N'{2}' and N'{3}'='XT') or (cc.shct=N'{4}' and N'{5}'like'XT%'))", _
                                                                       .Items(.Row).SubItems(.Col).Text, _
                                                                       txt(0).Text, _
                                                                       txt(0).Text.Substring(0, txt(0).Text.Length - 2), _
                                                                       txt(0).Text.Substring(txt(0).Text.Length - 2, 2).ToUpper(), _
                                                                       txt(0).Text.Substring(0, txt(0).Text.Length - 3), _
                                                                       txt(0).Text.Substring(txt(0).Text.Length - 3, 3).ToUpper())))
                            While CboDoituong.SelectedIndex < CboDoituong.Items.Count - 1 And CboDoituong.SelectedValue <> MaDT
                                CboDoituong.SelectedIndex += 1
                            End While
                        Else
                            If ConvertToDblSafe(Timten("namkh", txt(0).Text, "shct", "congcudungcu")) Then
                                ChkDoiTuong.CheckState = CheckState.Checked
                            Else
                                ChkDoiTuong.CheckState = CheckState.Unchecked
                            End If
                            dong1 = .Row : cot1 = .Col
                            .Row = ConvertToDblSafe(.Rows - 1) : .Col = 3
                            MaDT = ConvertToDblSafe(GetSelectValue(String.Format("SELECT madtsd as f1 FROM thongso1 ts inner join congcudungcu cc on ts.mats=cc.maso WHERE cc.sohieu=N'{0}' and cc.shct=N'{1}'", _
                                                                       .Items(.Row).SubItems(.Col).Text, _
                                                                       txt(0).Text)))
                            While CboDoituong.SelectedIndex < CboDoituong.Items.Count - 1 And CboDoituong.SelectedValue <> MaDT
                                CboDoituong.SelectedIndex += 1
                            End While
                        End If
                        Exit Sub
                    End If
                End If
                .Row = i
                i += 1
            End While
            ChkDoiTuong.Visible = False : CboDoituong.Visible = False
            .Row = dong : .Col = cot
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub MedNgay_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_0.Enter, _MedNgay_1.Enter
        Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
        MedNgay(Index).SelectAll()
    End Sub

    Public Sub MedNgay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles _MedNgay_0.GotFocus, _MedNgay_1.GotFocus
        Dim Index As Integer = Array.IndexOf(MedNgay, sender)
        MedNgay(Index).SelectAll()
    End Sub

    Public Sub MedNgay_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_0.Leave, _MedNgay_1.Leave
        Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
        Dim ngayx As Date
        If Information.IsDate(MedNgay(Index).Text) Then
            ngayx = ConvertToDateSafe(MedNgay(Index).Text)
            'If ngayx.Year <> pNamTC Then MessageBox.Show("Ngày chứng từ khác năm tài chính !", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Ngay(Index) = ngayx
            If Index = 0 Then
                MedNgay(1).Text = ngayx
            End If
            If Index = 0 Then
                If ConvertToDateSafe(MedNgay(0).Text).Month < CboThang.SelectedValue Then
                    MedNgay(1).Text = ConvertToStrSafe(DateAndTime.DateSerial(pNamTC, CboThang.SelectedValue, 1))
                Else
                    MedNgay(1).Text = MedNgay(0).Text
                End If
                Ngay(1) = Ngay(0)
                If NgayDauThangMoi > 0 Then
                    If CboThang.Items.Count > 0 Then
                        CboThang.SelectedIndex = IIf(DateAndTime.Day(Ngay(0)) >= NgayDauThangMoi And Ngay(0).Month < 12, Ngay(1).Month, Ngay(1).Month - 1)
                    End If
                End If
            End If
        Else
            MedNgay(Index).Focus()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub mnIn_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mnIn_0.Click, _mnIn_1.Click, _mnIn_2.Click, _mnIn_3.Click, _mnIn_4.Click, _mnIn_5.Click, _mnIn_6.Click, _mnIn_7.Click, _mnIn_8.Click, _mnIn_9.Click
        Dim Index As Integer = Array.IndexOf(mnIn, eventSender)
        Cursor = Cursors.WaitCursor
        Select Case Index
            Case 2, 3
                SetSPNX()
                InNX(Index - 1)
            Case 4
                InNNS()
            Case 5
                Try
                    _txtchungtu_LostFocus(txtchungtu(2), New EventArgs())
                Catch
                End Try
                DonGiaNhap(vattu.MaSo)
            Case 7, 8, 9
                FrmKho.Tag = ConvertToStrSafe(Index + 3)
                FrmKho.ShowDialog()
                Int_RecsetToCbo(String.Format("SELECT MaSo As F2, DienGiai As F1, DoituongCT{1}.DienGiai FROM DoituongCT{0} ORDER BY DoituongCT{1}.DienGiai", Index - 6, ConvertToStrSafe(Index - 6)), CboVV(Index - 7))
        End Select
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub mnpc_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mnpc_0.Click, _mnpc_1.Click
        Dim Index As Integer = Array.IndexOf(mnpc, eventSender)
        SetSPTC()
        Select Case Index
            Case 0
                cuongthuchi = 2
                FrmSothu.ShowDialog()
                cuongthuchi = 0
            Case 1
                InTC(1)
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub mnpt_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mnpt_0.Click, _mnpt_1.Click
        Dim Index As Integer = Array.IndexOf(mnpt, eventSender)
        SetSPTC()
        Select Case Index
            Case 0
                cuongthuchi = 1
                FrmSothu.ShowDialog()
                cuongthuchi = 0
            Case 1
                InTC(0)
        End Select
    End Sub
    ''' <summary>
    ''' Đặt chế độ nhập cho loại phiếu tương ứng
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub OptLoai_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptLoai_14.CheckedChanged, _OptLoai_13.CheckedChanged, _OptLoai_8.CheckedChanged, _OptLoai_11.CheckedChanged, _OptLoai_10.CheckedChanged, _OptLoai_9.CheckedChanged, _OptLoai_0.CheckedChanged, _OptLoai_1.CheckedChanged, _OptLoai_2.CheckedChanged, _OptLoai_3.CheckedChanged, _OptLoai_12.CheckedChanged, _OptLoai_4.CheckedChanged, _OptLoai_15.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(OptLoai, eventSender)
            SetLoaiChungtu(Index)
            Kiemtrachiphi()
            Text = Setcaption()
            ChkTudong.CheckState = CheckState.Unchecked
            OptNhap(1).Visible = Not _OptLoai_2.Checked
            If _OptLoai_1.Checked Or _OptLoai_8.Checked Or _OptLoai_0.Checked Or _OptLoai_2.Checked Or _OptLoai_9.Checked Or _OptLoai_13.Checked Then
                ChkTudong.Visible = True
                If CPGV.Visible Then
                    ChkHNT.Visible = False : GoTo Bochk
                End If
            Else
Bochk:
                ChkTudong.Visible = False
            End If
            If ConvertToDblSafe(GetSelectValue("select giatheokhach  as f1 from license")) = 1 And _OptLoai_8.Checked Then
                Label(29).Visible = True
                txt(5).Visible = True
                LBKH.Visible = True
            Else
                Label(29).Visible = False
                txt(5).Visible = False
                LBKH.Visible = False
            End If
            If _OptLoai_1.Checked Or _OptLoai_2.Checked Then
                Label(28).Visible = True
                txt(4).Visible = True
            Else
                Label(28).Visible = False
                txt(4).Visible = False
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Setcaption() As String
        Dim result As String = String.Empty
        Command(5).Visible = False
        If OptLoai(0).Checked Then
            If ConvertToDblSafe((loai1.Tag)) = 0 Then
                result = Ngonngu("Chứng từ chi phí", "Voucher costs")
            ElseIf ConvertToDblSafe((loaino.Tag)) = 0 Then
                result = Ngonngu("Chứng từ thu nợ", "Debt receipts")
            Else
                result = Ngonngu("Chứng từ trả nợ", "Repayment")
            End If
        ElseIf OptLoai(1).Checked Then
            If CPGV.Visible Then
                result = Ngonngu("Hoá đơn hàng nhập khẩu", "Import invoice")
            Else
                result = Ngonngu("Hóa đơn mua hàng (Phiếu nhập hàng)", "Purchase invoice (Imports goods Bills)")
            End If
        ElseIf OptLoai(2).Checked Then
            result = Ngonngu("Phiếu xuất hàng", "Export bills")
        ElseIf OptLoai(3).Checked Then
            result = Ngonngu("Chứng từ kết chuyển", "Transferred voucher")
        ElseIf OptLoai(8).Checked Then
            result = Ngonngu("Hóa đơn bán hàng", "Sales invoice")
            Command(5).Visible = True
        ElseIf OptLoai(9).Checked Then
            result = Ngonngu("Chứng từ tăng tài sản cố định", "Assets icreasing")
        ElseIf OptLoai(10).Checked Then
            result = Ngonngu("Chứng từ giảm tài sản cố định", "Assets decreasing")
        ElseIf OptLoai(11).Checked Then
            result = Ngonngu("Đánh giá lại tài sản cố định", "Assets Revaluation")
        ElseIf OptLoai(12).Checked Then
            result = Ngonngu("Chứng từ khấu hao tài sản cố định", "Depreciation")
        ElseIf OptLoai(13).Checked Then
            result = Ngonngu("Chứng từ tăng công cụ dụng cụ", "Tools increasing")
        ElseIf OptLoai(14).Checked Then
            result = Ngonngu("Chứng từ phân bổ công cụ dụng cụ", "Allocation")
        End If
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub OptNhap_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptNhap_1.CheckedChanged, _OptNhap_0.CheckedChanged, _OptNhap_2.CheckedChanged
        Dim QChitiet As String
        Dim Mientru As String
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(OptNhap, eventSender)
            Dim CboNo_NewIndex As Integer = -1
            Dim rs As DataTable
            If Index = 1 Then
                CboNo.Items.Clear()
                CboNo.Items.ItemsBase.Clear()

                CboNo.Items.Add("0%", 1)
                CboNo.Items.Add("5%", 2)
                CboNo.Items.Add("10%", 0)

                CboNo.SelectedIndex = 0
            ElseIf loaict = 1 Then
                Select Case Index
                    Case 0
                        If ConvertToDblSafe(GetSelectValue("SELECT count(maso) AS F1 FROM taikhoantudong WHERE loai=" & loaict)) = 0 Then
                            QChitiet = "SELECT MaSo as tk1, sohieu FROM hethongtk WHERE tkcon=0 and (sohieu like '156%' or sohieu like '152%' or sohieu like '153%') "
                            Mientru = "SELECT MaSo as tk2, sohieu FROM hethongtk WHERE tkcon=0 and (sohieu like '1111%' or sohieu like '1121%' or sohieu like '331%') "
                            rs = ExecSQLReturnDT(String.Format("select QChitiet.tk1, mientru.tk2 from ({0}) AS QChitiet, ({1}) AS mientru", _
                                                     QChitiet, _
                                                     Mientru))
                            For Each rsItem As DataRow In rs.Rows
                                ExecSQLNonQuery(String.Format("insert into taikhoantudong(maso,tk1,tk2,loai,loai1,loaino)values({0},{1},{2},{3},0,0)", _
                                                    Lng_MaxValue("maso", " taikhoantudong") + 1, _
                                                    rsItem("Tk1"), _
                                                    rsItem("Tk2"), _
                                                    loaict))
                            Next
                            QChitiet = "SELECT MaSo as tk1, sohieu FROM hethongtk WHERE tkcon=0 and sohieu like '155%' "
                            Mientru = "SELECT MaSo as tk2, sohieu FROM hethongtk WHERE tkcon=0 and (sohieu like '154%' and left(sohieu,4) <> '154D' and left(sohieu,4) <> '154d' or sohieu like '1111%') "
                            rs = ExecSQLReturnDT(String.Format("select QChitiet.tk1, mientru.tk2 from ({0}) AS QChitiet, ({1}) AS mientru", _
                                                  QChitiet, _
                                                  Mientru))
                            For Each rsItem As DataRow In rs.Rows
                                ExecSQLNonQuery(String.Format("insert into taikhoantudong(maso,tk1,tk2,loai,loai1,loaino)values({0},{1},{2},{3},0,0)", _
                                                    Lng_MaxValue("maso", "taikhoantudong") + 1, _
                                                    rsItem("Tk1"), _
                                                    rsItem("Tk2"), _
                                                    loaict))
                            Next
                        End If
                        Int_RecsetToCbo1(String.Format("SELECT distinct tk.SoHieu + '  ' + tk.Ten AS F1, tk.MaSo as F2 FROM hethongtk tk inner join taikhoantudong tktd on tk.maso=tktd.tk1 WHERE tktd.loai = {0}", loaict), CboNo)
                    Case 2
                        Int_RecsetToCbo1(String.Format("SELECT distinct tk.SoHieu + '  ' + tk.Ten AS F1, tk.MaSo as F2 FROM hethongtk tk inner join taikhoantudong tktd on tk.maso=tktd.tk2 WHERE tktd.loai = {0} and tktd.tk1={1}", _
                                             loaict, _
                                             ConvertToStrSafe(NoGoiCo)), CboCo)
                End Select
            ElseIf loaict = 2 Then
                Select Case Index
                    Case 0
                        If ConvertToDblSafe(GetSelectValue("SELECT count(maso) AS F1 FROM taikhoantudong WHERE loai=" & loaict)) = 0 Then
                            QChitiet = "SELECT MaSo as tk1, sohieu FROM hethongtk WHERE tkcon=0 and sohieu like '152%' "
                            Mientru = "SELECT MaSo as tk2, sohieu FROM hethongtk WHERE tkcon=0 and (sohieu like '1541%' or sohieu like '1543%' or sohieu like '632%' or sohieu like '1421%' or sohieu like '242%' or sohieu like '642%') "
                            rs = ExecSQLReturnDT(String.Format("select QChitiet.tk1, mientru.tk2 from ({0}) AS QChitiet, ({1}) AS mientru", QChitiet, Mientru))
                            For Each rsItem As DataRow In rs.Rows
                                ExecSQLNonQuery(String.Format("insert into taikhoantudong(maso,tk1,tk2,loai,loai1,loaino)values({0},{1},{2},{3},0,0)", _
                                                    Lng_MaxValue("maso", "taikhoantudong") + 1, _
                                                    rsItem("Tk1"), _
                                                    rsItem("Tk2"), _
                                                    loaict))
                            Next
                            QChitiet = "SELECT MaSo as tk1, sohieu FROM hethongtk WHERE tkcon=0 and sohieu like '155%' "
                            Mientru = "SELECT MaSo as tk2, sohieu FROM hethongtk WHERE tkcon=0 and (sohieu like '632%' or sohieu like '1541%' or sohieu like '1543%' or sohieu like '642%') "
                            rs = ExecSQLReturnDT(String.Format("select QChitiet.tk1, mientru.tk2 from ({0}) AS QChitiet, ({1}) AS mientru", _
                                                   QChitiet, _
                                                   Mientru))
                            For Each rsItem As DataRow In rs.Rows
                                ExecSQLNonQuery(String.Format("insert into taikhoantudong(maso,tk1,tk2,loai,loai1,loaino)values({0},{1},{2},{3},0,0)", _
                                                    Lng_MaxValue("maso", "taikhoantudong") + 1, _
                                                    rsItem("Tk1"), _
                                                    rsItem("Tk2"), _
                                                    loaict))
                            Next
                            QChitiet = "SELECT MaSo as tk1, sohieu FROM hethongtk WHERE tkcon=0 and sohieu like '156%' "
                            Mientru = "SELECT MaSo as tk2, sohieu FROM hethongtk WHERE tkcon=0 and sohieu like '632%' "
                            rs = ExecSQLReturnDT(String.Format("select QChitiet.tk1, mientru.tk2 from ({0}) AS QChitiet, ({1}) AS mientru", _
                                                     QChitiet, _
                                                     Mientru))
                            For Each rsItem As DataRow In rs.Rows
                                ExecSQLNonQuery(String.Format("insert into taikhoantudong(maso,tk1,tk2,loai,loai1,loaino)values({0},{1},{2},{3},0,0)", _
                                                    Lng_MaxValue("maso", "taikhoantudong") + 1, _
                                                    rsItem("Tk1"), _
                                                    rsItem("Tk2"), _
                                                    loaict))
                            Next
                            QChitiet = "SELECT MaSo as tk1, sohieu FROM hethongtk WHERE tkcon=0 and sohieu like '153%' "
                            Mientru = "SELECT MaSo as tk2, sohieu FROM hethongtk WHERE tkcon=0 and sohieu like '1543%' "
                            rs = ExecSQLReturnDT(String.Format("select QChitiet.tk1, mientru.tk2 from ({0}) AS QChitiet, ({1}) AS mientru", _
                                                     QChitiet, _
                                                     Mientru))
                            For Each rsItem As DataRow In rs.Rows
                                ExecSQLNonQuery(String.Format("insert into taikhoantudong(maso,tk1,tk2,loai,loai1,loaino)values({0},{1},{2},{3},0,0)", _
                                                    Lng_MaxValue("maso", "taikhoantudong") + 1, _
                                                    rsItem("Tk1"), _
                                                    rsItem("Tk2"), _
                                                    loaict))
                            Next
                            QChitiet = "SELECT MaSo as tk1, sohieu FROM hethongtk WHERE tkcon=0 and sohieu like '153%' "
                            Mientru = "SELECT MaSo as tk2, sohieu FROM hethongtk WHERE tkcon=0 and sohieu like '642%' "
                            rs = ExecSQLReturnDT(String.Format("select QChitiet.tk1, mientru.tk2 from ({0}) AS QChitiet, ({1}) AS mientru", _
                                                     QChitiet, _
                                                     Mientru))
                            For Each rsItem As DataRow In rs.Rows
                                ExecSQLNonQuery(String.Format("insert into taikhoantudong(maso,tk1,tk2,loai,loai1,loaino)values({0},{1},{2},{3},0,0)", _
                                                    Lng_MaxValue("maso", " taikhoantudong") + 1, _
                                                    rsItem("Tk1"), _
                                                    rsItem("Tk2"), _
                                                    loaict))
                            Next
                            ExecSQLNonQuery(String.Format("insert into taikhoantudong(maso,tk1,tk2,loai,loai1,loaino)values({0},{1},{2},{3},0,0)", _
                                                Lng_MaxValue("maso", "taikhoantudong") + 1, _
                                                ConvertToStrSafe(SoHieu2MaSo("1531", "hethongtk")), _
                                                ConvertToStrSafe(SoHieu2MaSo("1421", "hethongtk")), _
                                                loaict))
                            ExecSQLNonQuery(String.Format("insert into taikhoantudong(maso,tk1,tk2,loai,loai1,loaino)values({0},{1},{2},{3},0,0)", _
                                                Lng_MaxValue("maso", "taikhoantudong") + 1, _
                                                ConvertToStrSafe(SoHieu2MaSo("1532", "hethongtk")), _
                                                ConvertToStrSafe(SoHieu2MaSo("242", "hethongtk")), _
                                                loaict))
                        End If
                        Int_RecsetToCbo1(String.Format("SELECT distinct tk.SoHieu + '  ' + tk.Ten AS F1, tk.MaSo as F2 FROM hethongtk tk inner join taikhoantudong tktd on tk.maso=tktd.tk1 WHERE tktd.loai = {0}", loaict), CboNo)
                    Case 2
                        If CboNo.Items.Count > 0 Then Int_RecsetToCbo1(String.Format("SELECT distinct tk.SoHieu + '  ' + tk.Ten AS F1, tk.MaSo as F2 FROM hethongtk tk inner join taikhoantudong tktd on tk.maso=tktd.tk2 WHERE tktd.loai = {0} and tktd.tk1={1}", _
                                                                           loaict, _
                                                                           ConvertToStrSafe(NoGoiCo)), CboCo)
                End Select
            ElseIf loaict = 8 Then
                Select Case Index
                    Case 0
                        If ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(maso) AS F1 FROM taikhoantudong WHERE loai={0}", loaict))) = 0 Then
                            QChitiet = "SELECT MaSo as tk1, sohieu FROM hethongtk WHERE tkcon=0 and sohieu like '511%' "
                            Mientru = "SELECT MaSo as tk2, sohieu FROM hethongtk WHERE tkcon=0 and (sohieu like '1111%' or sohieu like '1121%' or sohieu like '131%') "
                            rs = ExecSQLReturnDT(String.Format("select QChitiet.tk1, mientru.tk2 from ({0}) AS QChitiet, ({1}) AS mientru", _
                                                     QChitiet, _
                                                     Mientru))
                            For Each rsItem As DataRow In rs.Rows
                                ExecSQLNonQuery(String.Format("insert into taikhoantudong(maso,tk1,tk2,loai,loai1,loaino)values({0},{1},{2},{3},0,0)", _
                                                    Lng_MaxValue("maso", " taikhoantudong") + 1, _
                                                    rsItem("Tk1"), _
                                                    rsItem("Tk2"), _
                                                    loaict))
                            Next
                        End If
                        Int_RecsetToCbo1(String.Format("SELECT distinct tk.SoHieu + '  ' + tk.Ten AS F1, tk.MaSo as F2 FROM hethongtk tk inner join taikhoantudong tktd on tk.maso=tktd.tk1 WHERE tktd.loai = {0}", loaict), CboNo)
                    Case 2
                        Int_RecsetToCbo1(String.Format("SELECT distinct tk.SoHieu + '  ' + tk.Ten AS F1, tk.MaSo as F2 FROM hethongtk tk inner join taikhoantudong tktd on tk.maso=tktd.tk2 WHERE tktd.loai = {0} and tktd.tk1={1}", _
                                             loaict, _
                                             ConvertToStrSafe(NoGoiCo)), CboCo)
                End Select
            ElseIf loaict = 0 Then
                Select Case Index
                    Case 0
                        If ConvertToDblSafe(loai1.Tag) = 0 Then
                            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(maso) AS F1 FROM taikhoantudong WHERE loai={0} and loai1=0", loaict))) = 0 Then
                                QChitiet = "SELECT MaSo as tk1, sohieu FROM hethongtk WHERE tkcon=0 and sohieu like '6422%'"
                                Mientru = "SELECT MaSo as tk2, sohieu FROM hethongtk WHERE tkcon=0 and sohieu like '3339%'"
                                rs = ExecSQLReturnDT(String.Format("select QChitiet.tk1, mientru.tk2 from ({0}) AS QChitiet, ({1}) AS mientru", _
                                                         QChitiet, _
                                                         Mientru))
                                For Each rsItem As DataRow In rs.Rows
                                    ExecSQLNonQuery(String.Format("insert into taikhoantudong(maso,tk1,tk2,loai,loai1,loaino)values({0},{1},{2},{3},0,0)", _
                                                        Lng_MaxValue("maso", "taikhoantudong") + 1, _
                                                        rsItem("Tk1"), _
                                                        rsItem("Tk2"), _
                                                        loaict))
                                Next
                                QChitiet = "SELECT MaSo as tk1, sohieu FROM hethongtk WHERE tkcon=0 and (sohieu like '142%' or sohieu like '242%' or sohieu like '1543%') "
                                Mientru = "SELECT MaSo as tk2, sohieu FROM hethongtk WHERE tkcon=0 and (sohieu like '1111%' or sohieu like '1121%' or sohieu like '331%') "
                                rs = ExecSQLReturnDT(String.Format("select QChitiet.tk1, mientru.tk2 from ({0}) AS QChitiet, ({1}) AS mientru", _
                                                         QChitiet, _
                                                         Mientru))
                                For Each rsItem As DataRow In rs.Rows
                                    ExecSQLNonQuery(String.Format("insert into taikhoantudong(maso,tk1,tk2,loai,loai1,loaino)values({0},{1},{2},{3},0,0)", _
                                                        Lng_MaxValue("maso", "taikhoantudong") + 1, _
                                                        rsItem("Tk1"), _
                                                        rsItem("Tk2"), _
                                                        loaict))
                                Next
                                QChitiet = "SELECT MaSo as tk1, sohieu FROM hethongtk WHERE tkcon=0 and sohieu like '1111%' "
                                Mientru = "SELECT MaSo as tk2, sohieu FROM hethongtk WHERE tkcon=0 and (sohieu like '1121%' or sohieu like '411%') "
                                rs = ExecSQLReturnDT(String.Format("select QChitiet.tk1, mientru.tk2 from ({0}) AS QChitiet, ({1}) AS mientru", _
                                                         QChitiet, _
                                                         Mientru))
                                For Each rsItem As DataRow In rs.Rows
                                    ExecSQLNonQuery(String.Format("insert into taikhoantudong(maso,tk1,tk2,loai,loai1,loaino)values({0},{1},{2},{3},0,0)", _
                                                        Lng_MaxValue("maso", "taikhoantudong") + 1, _
                                                        rsItem("Tk1"), _
                                                        rsItem("Tk2"), _
                                                        loaict))
                                Next
                                QChitiet = "SELECT MaSo as tk1, sohieu FROM hethongtk WHERE tkcon=0 and sohieu like '1121%' "
                                Mientru = "SELECT MaSo as tk2, sohieu FROM hethongtk WHERE tkcon=0 and (sohieu like '1111%' or sohieu like '411%' or sohieu like '515%') "
                                rs = ExecSQLReturnDT(String.Format("select QChitiet.tk1, mientru.tk2 from ({0}) AS QChitiet, ({1}) AS mientru", _
                                                         QChitiet, _
                                                         Mientru))
                                For Each rsItem As DataRow In rs.Rows
                                    ExecSQLNonQuery(String.Format("insert into taikhoantudong(maso,tk1,tk2,loai,loai1,loaino)values({0},{1},{2},{3},0,0)", _
                                                        Lng_MaxValue("maso", "taikhoantudong") + 1, _
                                                        rsItem("Tk1"), _
                                                        rsItem("Tk2"), _
                                                        loaict))
                                Next
                                QChitiet = "SELECT MaSo as tk1, sohieu FROM hethongtk WHERE tkcon=0 and (sohieu like '33311%' and left(sohieu,6) <> '333112' or sohieu like '33332%' or sohieu like '3334%' or sohieu like '3338%' or sohieu like '3339%' or sohieu like '642%') "
                                Mientru = "SELECT MaSo as tk2, sohieu FROM hethongtk WHERE tkcon=0 and sohieu like '1111%' "
                                rs = ExecSQLReturnDT(String.Format("select QChitiet.tk1, mientru.tk2 from ({0}) AS QChitiet, ({1}) AS mientru", _
                                                         QChitiet, _
                                                         Mientru))
                                For Each rsItem As DataRow In rs.Rows
                                    ExecSQLNonQuery(String.Format("insert into taikhoantudong(maso,tk1,tk2,loai,loai1,loaino)values({0},{1},{2},{3},0,0)", _
                                                        Lng_MaxValue("maso", "taikhoantudong") + 1, _
                                                        rsItem("Tk1"), _
                                                        rsItem("Tk2"), _
                                                        loaict))
                                Next
                            End If
                            Int_RecsetToCbo1(String.Format("SELECT distinct tk.SoHieu + '  ' + tk.Ten AS F1, tk.MaSo as F2 FROM hethongtk tk inner join taikhoantudong tktd on tk.maso=tktd.tk1 WHERE tktd.loai = {0} and tktd.loai1 = {1} and tktd.loaino = {2}{3}", _
                                                 loaict, _
                                                 ConvertToStrSafe(loai1.Tag), _
                                                 ConvertToStrSafe(loaino.Tag), _
                                                 (IIf(ConvertToDblSafe(loai1.Tag) = 0 And FrmMNCongCu.Visible, " and (left(tk.sohieu,4)='1421' or left(tk.sohieu,3)='242')", String.Empty))), CboNo)

                        Else
                            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(maso) AS F1 FROM taikhoantudong WHERE loai={0} and loai1=1", loaict))) = 0 Then
                                Mientru = "SELECT MaSo as tk1, sohieu FROM hethongtk WHERE tkcon=0 and sohieu like '131%' "
                                QChitiet = "SELECT MaSo as tk2, sohieu FROM hethongtk WHERE tkcon=0 and (sohieu like '1111%' or sohieu like '1121%') "
                                rs = ExecSQLReturnDT(String.Format("select QChitiet.tk1, mientru.tk2 from ({0}) AS QChitiet, ({1}) AS mientru", _
                                                         QChitiet, _
                                                         Mientru))
                                For Each rsItem As DataRow In rs.Rows
                                    ExecSQLNonQuery(String.Format("insert into taikhoantudong(maso,tk1,tk2,loai,loai1,loaino)values({0},{1},{2},{3},1,0)", _
                                                        Lng_MaxValue("maso", "taikhoantudong") + 1, _
                                                        rsItem("Tk1"), _
                                                        rsItem("Tk2"), _
                                                        loaict))
                                Next
                                QChitiet = "SELECT MaSo as tk1, sohieu FROM hethongtk WHERE tkcon=0 and sohieu like '331%' "
                                Mientru = "SELECT MaSo as tk2, sohieu FROM hethongtk WHERE tkcon=0 and sohieu like '131%' "
                                rs = ExecSQLReturnDT(String.Format("select QChitiet.tk1, mientru.tk2 from ({0}) AS QChitiet, ({1}) AS mientru", _
                                                         QChitiet, _
                                                         Mientru))
                                For Each rsItem As DataRow In rs.Rows
                                    ExecSQLNonQuery(String.Format("insert into taikhoantudong(maso,tk1,tk2,loai,loai1,loaino)values({0},{1},{2},{3},1,0)", _
                                                        Lng_MaxValue("maso", "taikhoantudong") + 1, _
                                                        rsItem("Tk2"), _
                                                        rsItem("Tk1"), _
                                                        loaict))
                                    ExecSQLNonQuery(String.Format("insert into taikhoantudong(maso,tk1,tk2,loai,loai1,loaino)values({0},{1},{2},{3},1,1)", _
                                                        Lng_MaxValue("maso", "taikhoantudong") + 1, _
                                                        rsItem("Tk1"), _
                                                        rsItem("Tk2"), _
                                                        loaict))
                                Next
                                rs = ExecSQLReturnDT("select qcdt.tk1,QChitiet.tk2 from qcdt,QChitiet")
                                For Each rsItem As DataRow In rs.Rows
                                    ExecSQLNonQuery(String.Format("insert into taikhoantudong(maso,tk1,tk2,loai,loai1,loaino)values({0},{1},{2},{3},1,1)", _
                                                        Lng_MaxValue("maso", "taikhoantudong") + 1, _
                                                        rsItem("Tk1"), _
                                                        rsItem("Tk2"), _
                                                        loaict))
                                Next
                            End If
                            Int_RecsetToCbo1(String.Format("SELECT distinct tk.SoHieu + '  ' + tk.Ten AS F1, tk.MaSo as F2 FROM hethongtk tk inner join taikhoantudong tktd on tk.maso=tktd.tk1 WHERE tktd.loai = {0} and tktd.loai1 = {1} and tktd.loaino={2}", _
                                                 loaict, _
                                                 ConvertToStrSafe(loai1.Tag), _
                                                 ConvertToStrSafe(loaino.Tag)), CboNo)
                        End If
                    Case 2
                        Int_RecsetToCbo1(String.Format("SELECT distinct tk.SoHieu + '  ' + tk.Ten AS F1, tk.MaSo as F2 FROM hethongtk tk inner join taikhoantudong tktd on tk.maso=tktd.tk2 WHERE tktd.loai = {0} and tktd.tk1={1} and tktd.loai1 = {2} and tktd.loaino={3}", _
                                             loaict, _
                                             ConvertToStrSafe(NoGoiCo), _
                                             ConvertToStrSafe(loai1.Tag), _
                                             ConvertToStrSafe(loaino.Tag)), CboCo)
                End Select
            ElseIf loaict = 9 Or loaict = 13 Then
                If ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(maso) AS F1 FROM taikhoantudong WHERE loai={0}", loaict))) = 0 Then
                    QChitiet = "SELECT MaSo as tk1, sohieu FROM hethongtk WHERE tkcon=0 and (sohieu like '133%') "
                    Mientru = "SELECT MaSo as tk2, sohieu FROM hethongtk WHERE tkcon=0 and (sohieu like '1111%' or sohieu like '1121%' or sohieu like '331%' or sohieu like '142%' or sohieu like '3338%') "
                    rs = ExecSQLReturnDT(String.Format("select QChitiet.tk1, mientru.tk2 from ({0}) AS QChitiet, ({1}) AS mientru", _
                                             QChitiet, _
                                             Mientru))
                    For Each rsItem As DataRow In rs.Rows
                        ExecSQLNonQuery(String.Format("insert into taikhoantudong(maso,tk1,tk2,loai,loai1,loaino)values({0},{1},{2},{3},0,0)", _
                                            Lng_MaxValue("maso", " taikhoantudong") + 1, _
                                            rsItem("Tk1"), _
                                            rsItem("Tk2"), _
                                            loaict))
                    Next
                End If
                Int_RecsetToCbo1(String.Format("SELECT distinct tk.SoHieu + '  ' + tk.Ten AS F1, tk.MaSo as F2 FROM hethongtk tk inner join taikhoantudong tktd on tk.maso=tktd.tk2 WHERE tktd.loai = {0}", loaict), CboCo)
            End If
            If Index = 0 Or Index = 1 Then
                CboNo.Enabled = True
                CboCo.Enabled = False
            Else
                CboNo.Enabled = False
                CboCo.Enabled = True
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub SSCmdV_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles SSCmdV.Click
        Me.Cursor = Cursors.WaitCursor
        Dim CoIn As Boolean = False
        If vattu.MaSo > 0 Then
            CoIn = InTheKho2(CboNT(1).SelectedValue, vattu.MaSo, CboThang.SelectedValue, CboThang.SelectedValue, True, 0, "", 0, pNN)
        Else
            If taikhoan.maso > 0 Then
                If pPQTK > 0 And User_Right <> 0 Then
                    If Not taikhoan.ChoNhap() Then GoTo kt
                End If
                If taikhoan.maso = taikhoan.MaTC Or taikhoan.MaTC = 0 Then
                    CoIn = InSocaiTk(taikhoan, CboThang.SelectedValue, CboThang.SelectedValue, Ngay(0), Ngay(1), True, "", 0, 0, pNN)
                Else
                    CoIn = InSoChitiet(taikhoan, CboThang.SelectedValue, CboThang.SelectedValue, Ngay(0), Ngay(1), True, "", 0, 0, pNN)
                End If
            End If
        End If
        If CoIn Then InBaoCaoRPT()
kt:
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txt_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txt_5.Enter, _txt_4.Enter, _txt_3.Enter, _txt_2.Enter, _txt_0.Enter, _txt_1.Enter
        Dim Index As Integer = Array.IndexOf(txt, eventSender)
        Dim manx As String = String.Empty
        Dim stt As Integer
        If Index = 4 And (txt(4).Text = "..." Or txt(4).Text = "" Or txt(4).Text = "0") Then
            stt = CboThang.SelectedValue
            manx = ConvertToStrSafe(GetSelectValue(String.Format("select max(manhapxuat) as f1 from chungtu where manhapxuat like 'P{0}{1}{2}%'", _
                                                       (IIf(loaict = 1, "N", "X")), _
                                                       (IIf(stt < 10, "0", String.Empty)), _
                                                       ConvertToStrSafe(stt))))
            If manx.Length = 7 Then
                stt = ConvertToDblSafe(Strings.Right(manx, 3)) + 1
                manx = String.Format("{0}{1}{2}", _
                           Strings.Left(manx, 4), _
                           (IIf(stt < 10, "00", (IIf(stt < 10, "0", String.Empty)))), _
                           ConvertToStrSafe(stt))
            Else
                manx = String.Format("P{0}{1}{2}001", _
                           (IIf(loaict = 1, "N", "X")), _
                           (IIf(stt < 10, "0", String.Empty)), _
                           ConvertToStrSafe(stt))
            End If
            txt(4).Text = manx
        End If
        txt(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="stt1"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function TaomaNX(ByRef stt1 As Integer) As String
        Dim result As String = String.Empty
        Dim thangct As Integer = CboThang.SelectedValue
        If loaict = 1 Then
            result = String.Format("PN{0}{1}{2}{3}", _
                         (IIf(thangct < 10, "0", String.Empty)), _
                         ConvertToStrSafe(thangct), _
                         (IIf(stt1 >= 100, "", (IIf(stt1 >= 10, "0", "00")))), _
                         ConvertToStrSafe(stt1))
        ElseIf loaict = 2 Then
            result = String.Format("PX{0}{1}{2}{3}", _
                         (IIf(thangct < 10, "0", String.Empty)), _
                         ConvertToStrSafe(thangct), _
                         (IIf(stt1 >= 100, "", (IIf(stt1 >= 10, "0", "00")))), _
                         ConvertToStrSafe(stt1))
        End If
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txt_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txt_5.KeyPress, _txt_4.KeyPress, _txt_3.KeyPress, _txt_2.KeyPress, _txt_0.KeyPress, _txt_1.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txt, eventSender)
        Select Case Index
            Case 0
                If KeyAscii = 32 Or KeyAscii = 39 Or KeyAscii = 42 Then KeyAscii = 0
            Case 3
                If KeyAscii = 13 Then
                    txt(3).Text = FrmNhanVien.ChonNV(txt(3).Text)
                    txt(3).Focus()
                End If
            Case 5
                If KeyAscii = 13 Then
                    txt(5).Text = FrmKhachHang.ChonKhachHang(txt(5).Text)
                    txt(5).Focus()
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
    Private Sub txt_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txt_5.Leave, _txt_4.Leave, _txt_3.Leave, _txt_2.Leave, _txt_0.Leave, _txt_1.Leave
        Dim Index As Integer = Array.IndexOf(txt, eventSender)
        Dim L As Integer
        Dim sh As String = String.Empty
        Select Case Index
            Case 0
                txt(0).Text = txt(0).Text.ToUpper()
                If txt(Index).Text.Length = 0 Then
                    txt(Index).Text = "..."
                Else
                    sh = IIf(Chk.CheckState = CheckState.Checked, "P", String.Empty)
                    L = Strings.Len(txt(0).Text)
                    If loaict = 8 Then
                        Dim i As Integer
                        For i = 1 To 7 - L
                            txt(0).Text = "0" + txt(0).Text
                        Next
                    End If
                    If Index = 0 And L > 0 And MaSoCT = 0 Then

                        If Not IsNumeric(txt(0).Text) Then
                            Dim sql As String = String.Format("SELECT top 1 (SoHieu) AS F1 FROM ChungTu{0} WHERE Len(SoHieu)>{1} AND IsNumeric(Right(SoHieu,Len(SoHieu)-{1}))=1 AND SoHieu LIKE N'{2}%' AND ThangCT={3} ORDER BY SoHieu DESC", _
                                                       sh, _
                                                       ConvertToStrSafe(L), _
                                                       txt(0).Text, _
                                                       ConvertToStrSafe(CboThang.SelectedValue))
                            shct = (GetSelectValue(sql))
                            If shct <> "0" Then txt(0).Text = SHCtuMoi(shct)
                        End If
                    End If
                    If Index = 0 And txt(0).Text <> "..." And MaSoCT = 0 Then
                        Dim ngay1 As DateTime
                        If ConvertToDblSafe(GetSelectValue(String.Format("SELECT DISTINCT Count(MaSo) AS F1,ngayct as f2 FROM ChungTu{0} WHERE SoHieu = N'{1}' AND MaCT<>{2}{3}{4} group by ngayct", _
                                                               sh, _
                                                               txt(0).Text, _
                                                               ConvertToStrSafe(MaSoCT), _
                                                               (IIf(pTrungSoHieuKhacThang = 0, "", String.Format(" AND ThangCT={0}", CboThang.SelectedValue))), _
                                                               " AND MaLoai=" + CStr(loaict)), ngay1)) > 0 Then
                            MessageBox.Show("Số hiệu chứng từ đã tồn tại ngày " & Format(CDate(ngay1), Mask_D))
                        End If
                    End If
                End If
            Case 3
                LBNV.Text = TenNV(txt(3).Text, L)
                txt(Index).Tag = ConvertToStrSafe(L)
            Case 4
                txt(Index).Text = txt(Index).Text.ToUpper()
            Case 5
                LBKH.Text = TenKH(txt(5).Text, L)
                txt(Index).Tag = ConvertToStrSafe(L)
        End Select
        MaCT = _txt_0.Text
    End Sub

    Public Sub _txtchungtu_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles _txtchungtu_0.LostFocus, _txtchungtu_11.LostFocus, _txtchungtu_10.LostFocus, _txtchungtu_9.LostFocus, _txtchungtu_8.LostFocus, _txtchungtu_7.LostFocus, _txtchungtu_6.LostFocus, _txtchungtu_5.LostFocus, _txtchungtu_4.LostFocus, _txtchungtu_3.LostFocus, _txtchungtu_2.LostFocus, _txtchungtu_1.LostFocus
        Dim Index As Integer = Array.IndexOf(txtchungtu, sender)
        Dim v, luong, tien, tien2 As Double
        Dim j As Integer
        Dim sh As String = String.Empty
        Dim psnt As Boolean
        Dim tygia, nt As Double
        Dim m As String = String.Empty

        'If Not currentTextValue(Index).Equals(txtchungtu(Index).Text.Trim, StringComparison.InvariantCulture) Then
        'currentTextValue(Index) = txtchungtu(Index).Text.Trim

        Select Case Index
            Case 0 ' So hieu tai khoan
                taikhoan.InitTaikhoanSohieu(txtchungtu(0).Text)
                txtchungtu(1).Text = IIf(pNN = 0, taikhoan.ten, taikhoan.TenE)
                If (taikhoan.tk_id = TTDB_ID) Or (taikhoan.tk_id = GTGTKT_ID) Or (taikhoan.tk_id = GTGTPN_ID) Or (taikhoan.tk_id = TKCNKH_ID) Or (taikhoan.tk_id = TKCNPT_ID) Then
                    If ((taikhoan.tk_id = TKCNKH_ID) Or (taikhoan.tk_id = TKCNPT_ID)) And hdcount >= 0 Then
                        ckh.InitKhachHangMaSo(hd(hdcount).MaKhachHang)
                        txtchungtu(2).Text = ckh.SoHieu
                    End If
                    CboNT(0).Visible = False
                    txtchungtu(4).Enabled = False
                    txtchungtu(3).Enabled = False
                    CboNT(3).Visible = False
                    If ((taikhoan.tk_id = TKCNKH_ID) Or (taikhoan.tk_id = TKCNPT_ID)) And (Not KHDetail) Then
                        txtchungtu(2).Enabled = False
                    Else
                        If pNhapDoiTuong > 0 And ((taikhoan.tk_id = TKCNKH_ID) Or (taikhoan.tk_id = TKCNPT_ID)) Then
                            txtchungtu(2).Enabled = False
                            CboNT(3).Visible = True
                            LaySohieuDoiTuong2(2, "")
                            If hdcount >= 0 Then
                                CboNT(3).Text = String.Format("{0} - {1}", ckh.SoHieu, ckh.Ten)
                            End If
                        Else
                            txtchungtu(2).Enabled = True
                            txtchungtu(2).Focus()
                        End If
                    End If
                Else
                    txtchungtu(4).Enabled = False
                    txtchungtu(2).Enabled = False
                    CboNT(3).Visible = False
                    If taikhoan.maso > 0 Then
                        If (taikhoan.tk_id <> TKVT_ID And taikhoan.tk_id <> TKDT_ID And taikhoan.tk_id <> TKGT_ID) Or (Not STDetail) Or (taikhoan.tk_id = TKDT_ID And loaict <> 8) Or (taikhoan.tk_id = TKVT_ID And loaict <> 1 And loaict <> 2 And loaict <> 8) Then
                            txtchungtu(2).Tag = ConvertToStrSafe(IIf(taikhoan.MaNT > 0, 1, 0))
                            txtchungtu(2).Text = ""
                            If taikhoan.MaNT = 0 Then
                                CboNT(0).Visible = False
                                txtchungtu(3).Text = "0"
                                txtchungtu(3).Enabled = False
                                CboNT(1).Visible = False
                            Else
                                Int_RecsetToCbo(String.Format("SELECT NguyenTe.MaSo As F2, NguyenTe.KyHieu As F1 FROM NguyenTe INNER JOIN HethongTK ON NguyenTe.MaSo = HethongTK.MaNT WHERE HethongTK.SoHieu = N'{0}' ORDER BY NguyenTe.KyHieu", taikhoan.sohieu), CboNT(0))
                                CboNT(0).Items.Insert(0, pTienStr)
                                'VB6.SetItemData(CboNT(0), 0, 0)
                                If CboNT(0).Items.Count > 0 Then
                                    CboNT(0).SelectedIndex = 0
                                    CboNT(0).Visible = True
                                End If

                                txtchungtu(4).Enabled = True
                                CboNT(0).Focus()
                            End If
                            txtchungtu(3).Text = "0"
                        Else
                            CboNT(0).Visible = False
                            If (taikhoan.tk_id = TKVT_ID Or taikhoan.tk_id = TKDT_ID Or taikhoan.tk_id = TKGT_ID) And (loaict = 1 Or loaict = 2 Or loaict = 7 Or loaict = 8) Then
                                If pNhapDoiTuong > 0 Then
                                    txtchungtu(2).Enabled = False
                                    CboNT(3).Visible = True
                                    LaySohieuDoiTuong2(1, "")
                                Else
                                    txtchungtu(2).Enabled = True
                                End If
                                txtchungtu(3).Enabled = True
                            Else
                                txtchungtu(2).Enabled = False
                                txtchungtu(3).Enabled = False
                            End If
                            CboNT(1).Visible = loaict = 1 Or loaict = 8
                            txtchungtu(2).Focus()
                        End If
                    Else
                        txtchungtu(2).Enabled = False
                        txtchungtu(3).Enabled = False
                    End If
                End If
                If taikhoan.sohieu.Length > 0 Then
                    If (pDTTP <> 0 And (loaict <> 3 And (((loaict = 0 Or loaict = 1) And (taikhoan.sohieu Like "1422*" Or taikhoan.sohieu Like "1423*")) Or taikhoan.sohieu Like "64*" Or taikhoan.sohieu Like "621*" Or taikhoan.sohieu Like "622*" Or taikhoan.sohieu Like "623*" Or taikhoan.sohieu Like "627*" Or taikhoan.sohieu Like "154*" Or taikhoan.sohieu Like "911*"))) Or (loaict = 8 And taikhoan.sohieu Like "521*") Then
                        txtchungtu(2).Enabled = True
                        txtchungtu(2).Focus()
                    End If
                End If
                Exit Select
            Case 2 ' So hieu vat tu, nguyen te
                Label(12).Visible = False
                CboNT(2).Visible = False
                CboNT(1).Visible = False
                txtchungtu(4).Enabled = False
                If pDTTP <> 0 And (loaict <> 3 And ((taikhoan.sohieu Like "51*" And taikhoan.tk_id2 = TKDT_ID) Or taikhoan.sohieu Like "64*" Or taikhoan.sohieu Like "621*" Or taikhoan.sohieu Like "622*" Or taikhoan.sohieu Like "623*" Or taikhoan.sohieu Like "627*" Or taikhoan.sohieu Like "154*" Or taikhoan.sohieu Like "911*")) And Strings.Len(txtchungtu(2).Text) > 0 Then
                    tp.InitTPSohieu(txtchungtu(2).Text)
                    txtchungtu(1).Text = tp.TenVattu
                    If taikhoan.sohieu Like "154*" And tp.MaSo > 0 Then
                        If CboThang.Items.Count > 0 Then
                            tien = tp.GiaThanhCK(CboThang.SelectedValue)
                        End If

                        If tien <> 0 Then
                            txtchungtu(5).Text = ""
                            txtchungtu(6).Text = Format(tien, Mask_0)
                        End If
                    End If
                Else
                    tp.InitTPMaSo(0)
                End If
                If (taikhoan.tk_id = TKCNKH_ID) Or (taikhoan.tk_id = TKCNPT_ID) Then
                    ckh.InitKhachHangSohieu(txtchungtu(2).Text)
                    txtchungtu(1).Text = ckh.Ten
                    txtchungtu(3).Enabled = (ckh.MaNT > 0)
                    txtchungtu(2).Tag = ConvertToStrSafe(IIf(ckh.MaNT > 0, 1, 0))
                    If ckh.MaNT = 0 Then
                        txtchungtu(3).Text = "0"
                    Else
                        txtchungtu(4).Enabled = True
                        txtchungtu(4).Text = Format(TyGiaNT(ckh.MaNT), Mask_0)
                        txtchungtu(3).Focus()
                    End If
                End If
                If (((loaict = 1 Or loaict = 2 Or loaict = 8) And (taikhoan.tk_id = TKVT_ID)) Or ((loaict = 7 Or loaict = 8) And (taikhoan.tk_id = TKDT_ID Or taikhoan.tk_id = TKGT_ID))) And STDetail And VTEnable And tp.MaSo = 0 Then
                    vattu.InitVattuSohieu(txtchungtu(2).Text)
                    If vattu.MaSo > 0 Then
                        VTEnable = False
                        Label(25).Visible = (pGiaUSD > 0) And (loaict = 1 Or loaict = 2 Or loaict = 8)
                        txtchungtu(11).Visible = (pGiaUSD > 0) And (loaict = 1 Or loaict = 2 Or loaict = 8)
                        If (taikhoan.loai = 0 Or (OutCost > 0 And OutCost <> 2)) And loaict = 2 Then
                            FDsNhap.Tag = ConvertToStrSafe(vattu.MaSo)
                            MaNhap = FDsNhap.XuatDichDanh(CboThang.SelectedValue, String.Format("{0} - {1} - Đ.v.t: {2}", _
                                                                                                                 vattu.sohieu, _
                                                                                                                 vattu.TenVattu, _
                                                                                                                 vattu.DonVi), CboNguon(1).SelectedValue, luong, tien)
                            If luong = 0 Then
                                luong = SoTonKho(CboThang.SelectedValue, _
                                            CboNguon(1).SelectedValue, _
                                            taikhoan.maso, _
                                            vattu.MaSo, _
                                            tien, _
                                            tien2)
                            End If
                            txtchungtu(3).Tag = ConvertToStrSafe(luong)
                            txtchungtu(5).Tag = ConvertToStrSafe(tien2)
                            txtchungtu(6).Tag = ConvertToStrSafe(tien)
                            txtchungtu(3).Text = Format(luong, Mask_2)
                            txtchungtu(6).Text = Format(tien, Mask_0)
                            If pGiaUSD > 0 Then txtchungtu(11).Text = Format(tien2, Mask_2)
                            If luong <> 0 Then
                                txtchungtu(4).Text = Format((IIf(0.5 + Mask_N * tien / luong > 0, Math.Floor(0.5 + Mask_N * tien / luong), Math.Ceiling(0.5 + Mask_N * tien / luong))) / Mask_N, Mask_2)
                            End If
                            HienThongBao(String.Format("Số lượng tồn kho: {0} - Thành tiền: {1}", _
                                             txtchungtu(3).Text, _
                                             txtchungtu(6).Text), 1)
                        Else
                            If loaict <> 8 Then
                                luong = SoTonKho(CboThang.SelectedValue, CboNguon(1).SelectedValue, taikhoan.maso, vattu.MaSo, tien, tien2)
                            Else
                                luong = SoTonKho(CboThang.SelectedValue, CboNguon(1).SelectedValue, 0, vattu.MaSo, tien, tien2)
                            End If
                            txtchungtu(3).Text = Format(luong, Mask_2)
                            If loaict = 1 Then
                                txtchungtu(5).Text = Format(tien, Mask_0)
                            Else
                                txtchungtu(3).Tag = ConvertToStrSafe(luong)
                                txtchungtu(6).Text = Format(tien, Mask_0)
                            End If
                            If pGiaUSD > 0 Then txtchungtu(11).Text = Format(tien2, Mask_2)
                            txtchungtu(6).Tag = ConvertToStrSafe(tien)
                            txtchungtu(5).Tag = ConvertToStrSafe(tien2)
                            If luong <> 0 Then
                                If pGiaUSD > 0 Then
                                    txtchungtu(4).Text = Format((IIf(0.5 + Mask_N * tien2 / luong > 0, Math.Floor(0.5 + Mask_N * tien2 / luong), Math.Ceiling(0.5 + Mask_N * tien2 / luong))) / Mask_N, Mask_2)
                                Else
                                    txtchungtu(4).Text = Format((IIf(0.5 + Mask_N * tien / luong > 0, Math.Floor(0.5 + Mask_N * tien / luong), Math.Ceiling(0.5 + Mask_N * tien / luong))) / Mask_N, Mask_2)
                                End If
                            End If
                        End If
                        If loaict = 8 And (vattu.GiaBan1 > 0 Or vattu.GiaBan2 > 0 Or vattu.GiaBan3 > 0) Then
                            LayGiaBan()
                        Else
                            If luong <> 0 Then
                                If pGiaUSD > 0 Then
                                    txtchungtu(4).Text = Format((IIf(0.5 + Mask_N * tien2 / luong > 0, Math.Floor(0.5 + Mask_N * tien2 / luong), Math.Ceiling(0.5 + Mask_N * tien2 / luong))) / Mask_N, Mask_2)
                                Else
                                    txtchungtu(4).Text = Format((IIf(0.5 + Mask_N * tien / (luong * (IIf(pGiaUSD > 0, pRate, 1))) > 0, Math.Floor(0.5 + Mask_N * tien / (luong * (IIf(pGiaUSD > 0, pRate, 1)))), Math.Ceiling(0.5 + Mask_N * tien / (luong * (IIf(pGiaUSD > 0, pRate, 1)))))) / Mask_N, Mask_2)
                                End If
                            End If
                        End If
                        If loaict = 1 And pGiaHT > 0 And vattu.GiaHT > 0 And taikhoan.sohieu.Substring(0, ShTkTP.Length) = ShTkTP Then
                            txtchungtu(4).Text = Format(vattu.GiaHT, Mask_2)
                        End If
                        HienThongBao(String.Format("Số lượng tồn kho: {0} - Thành tiền: {1}", txtchungtu(3).Text, Format(ConvertToStrSafe(txtchungtu(6).Tag), Mask_0)), 1)
                        txtchungtu(1).Text = vattu.TenVattu
                        txtchungtu(2).Tag = "1"
                        txtchungtu(3).Focus()
                        VTEnable = True
                    End If
                End If
                With GrdChungtu
                    tien = 0
                    luong = 0
                    If taikhoan.tk_id = GTGTKT_ID Then
                        Try
                            j = Math.Abs(ConvertToDblSafe(txtchungtu(2).Text))
                        Catch
                        End Try
                        If j = 0 Then
                            txtchungtu(5).Text = "0"
                            txtchungtu(6).Text = "0"
                            Exit Sub
                        End If
                        If ConvertToDblSafe(txtchungtu(5).Text) = 0 Then
                            If j > 0 And j < 5 And Not txtchungtu(2).Text.EndsWith("-") Then txtchungtu(2).Text = String.Format("{0}-", txtchungtu(2).Text)
                            For i As Integer = 0 To .Rows - 1
                                .Row = i
                                .Col = 1
                                sh = .Items(.Row).SubItems(.Col).Text
                                If sh.Length = 0 Then Exit For
                                If Strings.Left(sh, pVATV.Length) = pVATV Then Exit For
                                .Col = 6
                                If txtchungtu(2).Text.EndsWith("-") And Strings.Left(sh, 3) <> "211" Then
                                    tien = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                    If j > 0 And j < 5 Then
                                        v = tien * j / 100
                                    Else
                                        v = tien * j / (100 + j)
                                    End If
                                    v = RoundMoney(v)
                                    .Items(.Row).SubItems(.Col).Text = Format(tien - v, Mask_0)
                                    luong += v
                                Else
                                    tien += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                End If
                                If sh Like "338*" Then
                                    .Col = 7
                                    tien -= ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                End If
                            Next
                            If Not txtchungtu(2).Text.EndsWith("-") Then
                                luong = RoundMoney(tien * j / 100)
                            Else
                                txtchungtu(2).Text = ConvertToStrSafe(j)
                            End If
                            txtchungtu(5).Text = Format(luong, Mask_0)
                            txtchungtu(6).Text = "0"
                        End If
                    End If
                    If taikhoan.tk_id = GTGTPN_ID Or taikhoan.tk_id = TTDB_ID Then
                        If ConvertToDblSafe(txtchungtu(2).Text) = 0 Then
                            txtchungtu(5).Text = "0"
                            txtchungtu(6).Text = "0"
                            Exit Sub
                        End If
                        Try
                            j = Math.Abs(ConvertToDblSafe(txtchungtu(2).Text))
                        Catch
                        End Try
                        For i As Integer = 0 To .Rows - 1
                            .Row = i
                            .Col = 1
                            sh = .Items(.Row).SubItems(.Col).Text
                            If sh.Length = 0 Then Exit For
                            If sh Like "3331*" And taikhoan.tk_id = GTGTPN_ID Then Exit For
                            If Strings.Left(sh, 2) <> "11" And Strings.Left(sh, 4) <> "3331" And Strings.Left(sh, 3) <> "521" Then
                                .Col = 7
                                If Not txtchungtu(2).Text.EndsWith("-") And pVAT1 > 0 And taikhoan.tk_id = GTGTPN_ID Then txtchungtu(2).Text = txtchungtu(2).Text & "-"
                                If txtchungtu(2).Text.EndsWith("-") And taikhoan.tk_id = GTGTPN_ID Then
                                    tien = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                    If j > 0 And j < 5 Then
                                        v = tien * j / 100
                                    Else
                                        v = tien * j / (100 + j)
                                    End If
                                    v = RoundMoney(v)
                                    .Items(.Row).SubItems(.Col).Text = Format(tien - v, Mask_0)
                                    luong += v
                                Else
                                    If loaict = 1 Then .Col = 6
                                    tien += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                End If
                            End If
                            If Strings.Left(sh, pSHPT.Length) <> pSHPT And Strings.Left(sh, 2) <> "11" Then
                                .Col = 6
                                tien -= ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                            End If
                        Next
                        If taikhoan.tk_id = GTGTPN_ID Then
                            If Not txtchungtu(2).Text.EndsWith("-") Then
                                luong = RoundMoney(tien * j / 100)
                            Else
                                txtchungtu(2).Text = ConvertToStrSafe(j)
                            End If
                        Else
                            luong = RoundMoney(tien * j / (j + 100))
                        End If
                        If luong >= 0 Then
                            txtchungtu(6).Text = Format(luong, Mask_0)
                            txtchungtu(5).Text = "0"
                        Else
                            txtchungtu(5).Text = Format(-luong, Mask_0)
                            txtchungtu(6).Text = "0"
                        End If
                        If luong <> 0 Then
                            txtchungtu(6).Focus()
                        End If
                    End If
                End With
                If loaict = 8 And taikhoan.sohieu Like "521*" Then
                    luong = ConvertToDblSafe(txtchungtu(2).Text)
                    If luong > 0 And luong < 100 Then
                        txtchungtu(5).Text = Format(RoundMoney(GiaTriTruocThue() * luong / 100), Mask_0)
                    Else
                        txtchungtu(5).Text = Format(SoChietKhau(), Mask_0)
                    End If
                End If
                If (loaict = 1 Or loaict = 2 Or loaict = 7 Or loaict = 8) And vattu.MaSo > 0 And vattu.Dvt2 > 0 Then
                    Label(12).Visible = True
                    CboNT(2).Visible = True
                    Int_RecsetToCbo(String.Format("SELECT MaSo AS F2, DonVi AS F1 FROM DVTVattu WHERE MaVattu={0} ORDER BY DonVi", vattu.MaSo), CboNT(2))
                    CboNT(2).Items.Insert(0, vattu.DonVi)
                    If CboNT(2).Items.Count > 0 Then
                        CboNT(2).SelectedIndex = 0
                    End If

                    CboNT(2).Focus()
                End If
                txtchungtu(9).Text = ""
                txtchungtu(10).Text = ""
                txtchungtu(4).Enabled = ((loaict = 1 Or loaict = 7 Or loaict = 8) And (vattu.MaSo > 0)) Or (ckh.MaNT > 0)
                If loaict = 8 And vattu.MaSo > 0 And vattu.CK > 0 And pChietKhau > 0 Then
                    txtchungtu(9).Text = Format(vattu.CK, IIf(ConvertToDblSafe(vattu.CK * 100) Mod 100 <> 0, Mask_2, Mask_0))
                    TinhCKCT()
                End If
                Exit Select
            Case 3 ' So luong
                txtchungtu(3).Text = Format(txtchungtu(3).Text, Mask_2)
                If (loaict = 2 Or loaict = 7 Or loaict = 8) And vattu.MaSo > 0 Then
                    luong = ConvertToDblSafe(txtchungtu(3).Text)
                    txtchungtu(5).Text = "0"
                    If loaict = 2 Then
                        If luong <> ConvertToDblSafe((txtchungtu(3).Tag)) And ConvertToDblSafe((txtchungtu(3).Tag)) <> 0 Then
                            txtchungtu(6).Text = Format((luong * ConvertToDblSafe((txtchungtu(6).Tag))) / ConvertToDblSafe((txtchungtu(3).Tag)), Mask_0)
                            If pGiaUSD > 0 Then txtchungtu(11).Text = Format((luong * ConvertToDblSafe((txtchungtu(5).Tag))) / ConvertToDblSafe((txtchungtu(3).Tag)), Mask_2)
                        Else
                            txtchungtu(6).Text = Format(ConvertToStrSafe(txtchungtu(6).Tag), Mask_0)
                            If pGiaUSD > 0 Then txtchungtu(11).Text = Format(ConvertToStrSafe(txtchungtu(5).Tag), Mask_2)
                        End If
                    Else
                        If pGiaUSD > 0 Then txtchungtu(11).Text = Format(luong * ConvertToDblSafe(txtchungtu(4).Text), Mask_2)
                        txtchungtu(6).Text = Format(luong * ConvertToDblSafe(txtchungtu(4).Text) * (IIf(pGiaUSD > 0, pRate, 1)), Mask_0)
                    End If
                End If
                If (taikhoan.MaNT <> 0 And CboNT(0).SelectedIndex > 0) Or ckh.MaNT > 0 Then
                    luong = ConvertToDblSafe(txtchungtu(3).Text)
                    If ConvertToDblSafe(txtchungtu(4).Text) <> 0 Then
                        If SoPSConLai() < 0 Then
                            txtchungtu(5).Text = Format(luong * ConvertToDblSafe(txtchungtu(4).Text), Mask_0)
                        Else
                            txtchungtu(6).Text = Format(luong * ConvertToDblSafe(txtchungtu(4).Text), Mask_0)
                        End If
                    End If
                End If
                If loaict = 8 And vattu.MaSo > 0 Then TinhCKCT()
                If loaict = 1 And vattu.MaSo > 0 Then TinhCKMV()
                Exit Select
            Case 4, 5, 6 ' PS No, Co
                If taikhoan.sohieu <> "" Then
                    m = IIf(taikhoan.sohieu Like "007*", Mask_2, Mask_0)
                End If

                If Index = 4 Then
                    txtchungtu(Index).Text = Format(txtchungtu(Index).Text, Mask_2)
                Else
                    txtchungtu(Index).Text = Format(ConvertToDblSafe(txtchungtu(Index).Text), m)
                End If
                If Index = 5 Or Index = 6 Then
                    If ConvertToDblSafe(txtchungtu(Index).Text) <> 0 Then txtchungtu(11 - Index).Text = "0"
                End If
                psnt = (CboNT(0).Visible And CboNT(0).SelectedIndex > 0) Or ckh.MaNT > 0
                If ((loaict = 1 Or loaict = 7 Or loaict = 8) And (vattu.MaSo > 0)) Or psnt Then
                    luong = ConvertToDblSafe(txtchungtu(3).Text)
                    Select Case Index
                        Case 5
                            If loaict = 1 Or psnt Then
                                If luong > 0 And ConvertToDblSafe(txtchungtu(5).Text) <> 0 Then
                                    If loaict = 1 Or pTien = 0 Then
                                        tygia = ConvertToDblSafe(txtchungtu(5).Text) / luong
                                    Else
                                        tygia = luong / ConvertToDblSafe(txtchungtu(5).Text)
                                    End If
                                    If pGiaUSD > 0 And pRate > 0 Then
                                        txtchungtu(4).Text = Format(tygia / pRate, Mask_2)
                                    Else
                                        txtchungtu(4).Text = Format(tygia, Mask_2)
                                    End If
                                    If psnt Then
                                        If ckh.MaNT > 0 Then
                                            CapNhatTyGia(ckh.MaNT, tygia)
                                        Else
                                            CapNhatTyGia(CboNT(0).SelectedValue, tygia)
                                        End If
                                    End If
                                End If
                            End If
                        Case 6
                            If loaict = 7 Or loaict = 8 Or psnt Then
                                If luong > 0 And ConvertToDblSafe(txtchungtu(6).Text) <> 0 Then
                                    If loaict = 7 Or loaict = 8 Or pTien = 0 Then
                                        tygia = ConvertToDblSafe(txtchungtu(6).Text) / luong
                                        If loaict = 8 And pGiaUSD > 0 Then tygia /= pRate
                                    Else
                                        If ConvertToDblSafe(txtchungtu(5).Text) <> 0 Then tygia = luong / ConvertToDblSafe(txtchungtu(5).Text)
                                    End If
                                    txtchungtu(4).Text = Format(tygia, Mask_2)
                                    If psnt Then
                                        If ckh.MaNT > 0 Then
                                            CapNhatTyGia(ckh.MaNT, tygia)
                                        Else
                                            CapNhatTyGia(CboNT(0).SelectedValue, tygia)
                                        End If
                                    End If
                                End If
                            End If
                        Case 4
                            tygia = ConvertToDblSafe(txtchungtu(4).Text)
                            If psnt Then
                                tien = SoPSConLai()
                                nt = DoiRaTien(luong, tygia)
                                If tien < 0 Or (tien = 0 And taikhoan.loai < 0) Then
                                    txtchungtu(5).Text = Format(nt, Mask_0)
                                Else
                                    txtchungtu(6).Text = Format(nt, Mask_0)
                                End If
                                If ckh.MaNT > 0 Then
                                    CapNhatTyGia(ckh.MaNT, tygia)
                                Else
                                    CapNhatTyGia(CboNT(0).SelectedValue, tygia)
                                End If
                            Else
                                If loaict = 1 Or taikhoan.tk_id = TKGT_ID Then
                                    If luong > 0 Then
                                        If luong = ConvertToDblSafe((txtchungtu(3).Tag)) Then
                                            txtchungtu(4).Text = Format(ConvertToStrSafe(txtchungtu(6).Tag), Mask_0)
                                        Else
                                            txtchungtu(5).Text = Format(tygia * luong * (IIf(pGiaUSD > 0, pRate, 1)), Mask_0)
                                            If pGiaUSD > 0 Then txtchungtu(11).Text = Format(tygia * luong, Mask_2)
                                        End If
                                    Else
                                        txtchungtu(5).Text = txtchungtu(4).Text
                                    End If
                                Else
                                    If luong > 0 Then
                                        If pGiaUSD > 0 Then txtchungtu(11).Text = Format(tygia * luong, Mask_2)
                                        txtchungtu(6).Text = Format(tygia * luong * (IIf(pGiaUSD > 0, pRate, 1)), Mask_0)
                                        If ConvertToDblSafe(txtchungtu(6).Text) <> 0 Then txtchungtu(5).Text = "0"
                                    Else
                                        If pGiaUSD > 0 Then
                                            txtchungtu(6).Text = Format(ConvertToDblSafe(txtchungtu(4).Text) * pRate, Mask_0)
                                        Else
                                            txtchungtu(6).Text = txtchungtu(4).Text
                                        End If
                                    End If
                                End If
                            End If
                    End Select
                End If
                If (loaict = 7 Or loaict = 8) And vattu.MaSo > 0 Then TinhCKCT()
                If loaict = 1 And vattu.MaSo > 0 Then TinhCKMV()
                Exit Select
            Case 7
                If pTygia > 0 Then pRate = ConvertToDblSafe(txtchungtu(7).Text)
                txtchungtu(Index).Text = Format(txtchungtu(Index).Text, Mask_2)
                Exit Select
            Case 9, 13
                txtchungtu(Index).Text = Format(txtchungtu(Index).Text, Mask_2)
                If loaict = 8 And vattu.MaSo > 0 Then TinhCKCT()
                If loaict = 1 And vattu.MaSo > 0 Then TinhCKMV()
                Exit Select
            Case 10
                txtchungtu(Index).Text = Format(txtchungtu(Index).Text, Mask_0)
                Exit Select
        End Select
        'End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtchungtu_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtchungtu_11.TextChanged, _txtchungtu_10.TextChanged, _txtchungtu_9.TextChanged, _txtchungtu_8.TextChanged, _txtchungtu_7.TextChanged, _txtchungtu_6.TextChanged, _txtchungtu_5.TextChanged, _txtchungtu_4.TextChanged, _txtchungtu_3.TextChanged, _txtchungtu_2.TextChanged, _txtchungtu_0.TextChanged, _txtchungtu_1.TextChanged
        If isInitializingComponent Then
            Exit Sub
        End If
        Dim Index As Integer = Array.IndexOf(txtchungtu, eventSender)
        If Index = 0 Then
            If Strings.Left(txtchungtu(0).Text, 3) = "131" Or Strings.Left(txtchungtu(0).Text, 3) = "331" Then
                Label(7).Text = "Mã khách hàng"
            ElseIf Strings.Left(txtchungtu(0).Text, 3) = "133" Or Strings.Left(txtchungtu(0).Text, 3) = "333" Then
                Label(7).Text = "Thuế suất (%)"
            ElseIf Strings.Left(txtchungtu(0).Text, 2) = "15" Then
                Label(7).Text = "Mã hàng"
            ElseIf Strings.Left(txtchungtu(0).Text, 4) = "1422" Then
                Label(7).Text = "Mã hợp đồng"
            Else
                Label(7).Text = "Mã số"
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtchungtu_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtchungtu_11.Enter, _txtchungtu_10.Enter, _txtchungtu_9.Enter, _txtchungtu_8.Enter, _txtchungtu_7.Enter, _txtchungtu_6.Enter, _txtchungtu_5.Enter, _txtchungtu_4.Enter, _txtchungtu_3.Enter, _txtchungtu_2.Enter, _txtchungtu_0.Enter, _txtchungtu_1.Enter
        Dim Index As Integer = Array.IndexOf(txtchungtu, eventSender)
        '*************************************************************
        If Index = 4 And _OptLoai_8.Checked And ConvertToDblSafe(GetSelectValue("select giatheokhach  as f1 from license")) = 1 Then
            If (txtchungtu(0).Text = "5111" Or txtchungtu(0).Text = "5112") And txtchungtu(2).Text <> "" Then
                hh = txtchungtu(2).Text
            End If
            kh = txt(5).Text
            txtchungtu(Index).Text = ConvertToStrSafe(GetSelectValue(String.Format("select giaban as f1 from giavtkh where sohieukh=N'{0}' and sohieuvt=N'{1}'", _
                                                                         kh, _
                                                                         hh)))
        End If
        '*************************************************************
        txtchungtu(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' Xử lý phím bấm trên các ô nhập
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtchungtu_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtchungtu_11.KeyPress, _txtchungtu_10.KeyPress, _txtchungtu_9.KeyPress, _txtchungtu_8.KeyPress, _txtchungtu_7.KeyPress, _txtchungtu_6.KeyPress, _txtchungtu_5.KeyPress, _txtchungtu_4.KeyPress, _txtchungtu_3.KeyPress, _txtchungtu_2.KeyPress, _txtchungtu_0.KeyPress, _txtchungtu_1.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtchungtu, eventSender)
        Dim taikhoanloai As String
        Select Case Index
            Case 0
                If KeyAscii = ConvertToDblSafe(Keys.Return) Then
                    Me.Cursor = Cursors.WaitCursor
                    FrmTaikhoan.initOption = txtchungtu(0).Text
                    txtchungtu(0).Text = FrmTaikhoan.ChonTk(txtchungtu(0).Text)
                    Me.Cursor = Cursors.Default
                    _txtchungtu_LostFocus(txtchungtu(0), New EventArgs())
                End If
            Case 1
                KeyAscii = 0
                SystemSounds.Beep.Play()
            Case 2
                If loaict = 8 Then
                    taikhoanloai = txtchungtu(0).Text
                    If taikhoanloai = "5111" Then
                        taikhoanloai = "156"
                    ElseIf taikhoanloai = "5112" Then
                        taikhoanloai = ConvertToStrSafe(155)
                    End If
                    taikhoanloai = Strings.Left(taikhoanloai, 3)
                Else
                    taikhoanloai = Strings.Left(txtchungtu(0).Text, 3)
                End If
                If (((taikhoan.tk_id = TKCNKH_ID Or taikhoan.tk_id = TKCNPT_ID) And KHDetail) Or (((taikhoan.tk_id = TKVT_ID And (loaict = 1 Or loaict = 2 Or loaict = 7 Or loaict = 8)) Or ((taikhoan.tk_id = TKDT_ID Or taikhoan.tk_id = TKGT_ID) And (loaict = 7 Or loaict = 8) And taikhoan.tk_id2 <> TKDT_ID)) And STDetail)) And (KeyAscii = ConvertToDblSafe(Keys.Return)) Then
                    Me.Cursor = Cursors.WaitCursor
                    VTEnable = False
                    If taikhoan.tk_id <> TKCNKH_ID And taikhoan.tk_id <> TKCNPT_ID Then
                        FrmChungtu.tk = 1
                        txtchungtu(2).Text = FrmVattu.ChonVattu(txtchungtu(2).Text, 0, actax_loai, 0, 0, taikhoanloai)
                    Else
                        FrmChungtu.tk = 1
                        txtchungtu(2).Text = FrmKhachHang.ChonKhachHang(txtchungtu(2).Text)
                    End If
                    Me.Cursor = Cursors.Default
                    _txtchungtu_LostFocus(txtchungtu(2), New EventArgs())
                    VTEnable = True
                Else
                    If pDTTP <> 0 And (loaict <> 3 And (((loaict = 0 Or loaict = 1) And (taikhoan.sohieu Like "1422*" Or taikhoan.sohieu Like "1423*")) Or taikhoan.sohieu Like "64*" Or taikhoan.sohieu Like "621*" Or taikhoan.sohieu Like "622*" Or taikhoan.sohieu Like "623*" Or taikhoan.sohieu Like "627*" Or taikhoan.sohieu Like "154*" Or taikhoan.sohieu Like "911*" Or taikhoan.tk_id2 = TKDT_ID)) Then
                        If KeyAscii = ConvertToDblSafe(Keys.Return) Then
                            If taikhoan.sohieu Like "1422*" Then
                                txtchungtu(2).Text = FrmHD.ChonHD(txtchungtu(2).Text)
                            ElseIf taikhoan.sohieu Like "1423*" Then
                                txtchungtu(2).Text = FrmHDnoidia.ChonHD(txtchungtu(2).Text)
                            Else
                                txtchungtu(2).Text = FrmTP.ChonTP(txtchungtu(2).Text)
                            End If
                        End If
                    Else
                        If (taikhoan.tk_id = GTGTKT_ID Or taikhoan.tk_id = GTGTPN_ID Or taikhoan.tk_id = TTDB_ID) Then KeyProcess(txtchungtu(Index), KeyAscii, True)
                        If ((loaict <> 1 And loaict <> 2 And loaict <> 7 And loaict <> 8) Or (Not STDetail)) And Not ((taikhoan.tk_id = GTGTKT_ID) Or (taikhoan.tk_id = GTGTPN_ID) Or (taikhoan.tk_id = TTDB_ID)) And ((taikhoan.tk_id <> TKCNKH_ID And taikhoan.tk_id <> TKCNPT_ID) Or Not KHDetail) Then KeyAscii = 0
                    End If
                End If
            Case 3, 4
                If ConvertToDblSafe((txtchungtu(2).Tag)) = 1 Then KeyProcess(txtchungtu(Index), KeyAscii, True) Else KeyAscii = 0
            Case 5
                If KeyAscii = ConvertToDblSafe(Keys.Return) Then CmdChitiet_Click(CmdChitiet, New EventArgs()) Else KeyProcess(txtchungtu(Index), KeyAscii, True)
            Case 6
                If KeyAscii = ConvertToDblSafe(Keys.Return) Then
                    CmdChitiet_Click(CmdChitiet, New EventArgs())
                Else
                    If loaict = 2 And vattu.MaSo > 0 And FCost Then
                        If ConvertToDblSafe(txtchungtu(3).Text) <> 0 Then
                            KeyAscii = 0
                        Else
                            KeyProcess(txtchungtu(Index), KeyAscii)
                        End If
                    Else
                        KeyProcess(txtchungtu(Index), KeyAscii, True)
                    End If
                End If
            Case 7, 8
                KeyProcess(txtchungtu(Index), KeyAscii)
            Case 9, 10, 11, 13
                If KeyAscii = ConvertToDblSafe(Keys.Return) Then
                    CmdChitiet_Click(CmdChitiet, New EventArgs())
                Else
                    KeyProcess(txtchungtu(Index), KeyAscii)
                End If
        End Select
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    ''' <summary>
    ''' Kiểm tra dữ liệu nhập tại các ô nhập
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub _txtchungtu_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtchungtu_11.Leave, _txtchungtu_10.Leave, _txtchungtu_9.Leave, _txtchungtu_8.Leave, _txtchungtu_7.Leave, _txtchungtu_6.Leave, _txtchungtu_5.Leave, _txtchungtu_4.Leave, _txtchungtu_3.Leave, _txtchungtu_2.Leave, _txtchungtu_0.Leave, _txtchungtu_1.Leave
        'Dim Index As Integer = Array.IndexOf(txtchungtu, eventSender)
        'Dim v, luong, tien, tien2 As Double
        'Dim j As Integer
        'Dim sh As String = String.Empty
        'Dim psnt As Boolean
        'Dim tygia, nt As Double
        'Dim m As String = String.Empty
        'Select Case Index
        '    Case 0 ' So hieu tai khoan
        '        taikhoan.InitTaikhoanSohieu(txtchungtu(0).Text)
        '        txtchungtu(1).Text = IIf(pNN = 0, taikhoan.ten, taikhoan.TenE)
        '        If (taikhoan.tk_id = TTDB_ID) Or (taikhoan.tk_id = GTGTKT_ID) Or (taikhoan.tk_id = GTGTPN_ID) Or (taikhoan.tk_id = TKCNKH_ID) Or (taikhoan.tk_id = TKCNPT_ID) Then
        '            If ((taikhoan.tk_id = TKCNKH_ID) Or (taikhoan.tk_id = TKCNPT_ID)) And hdcount >= 0 Then
        '                ckh.InitKhachHangMaSo(hd(hdcount).MaKhachHang)
        '                txtchungtu(2).Text = ckh.SoHieu
        '            End If
        '            CboNT(0).Visible = False
        '            txtchungtu(4).Enabled = False
        '            txtchungtu(3).Enabled = False
        '            CboNT(3).Visible = False
        '            If ((taikhoan.tk_id = TKCNKH_ID) Or (taikhoan.tk_id = TKCNPT_ID)) And (Not KHDetail) Then
        '                txtchungtu(2).Enabled = False
        '            Else
        '                If pNhapDoiTuong > 0 And ((taikhoan.tk_id = TKCNKH_ID) Or (taikhoan.tk_id = TKCNPT_ID)) Then
        '                    txtchungtu(2).Enabled = False
        '                    CboNT(3).Visible = True
        '                    LaySohieuDoiTuong2(2, String.Empty)
        '                    If hdcount >= 0 Then
        '                        CboNT(3).Text = String.Format("{0} - {1}", ckh.SoHieu, ckh.Ten)
        '                    End If
        '                Else
        '                    txtchungtu(2).Enabled = True
        '                    txtchungtu(2).Focus()
        '                End If
        '            End If
        '        Else
        '            txtchungtu(4).Enabled = False
        '            txtchungtu(2).Enabled = False
        '            CboNT(3).Visible = False
        '            If taikhoan.maso > 0 Then
        '                If (taikhoan.tk_id <> TKVT_ID And taikhoan.tk_id <> TKDT_ID And taikhoan.tk_id <> TKGT_ID) Or (Not STDetail) Or (taikhoan.tk_id = TKDT_ID And loaict <> 8) Or (taikhoan.tk_id = TKVT_ID And loaict <> 1 And loaict <> 2 And loaict <> 8) Then
        '                    txtchungtu(2).Tag = ConvertToStrSafe(IIf(taikhoan.MaNT > 0, 1, 0))
        '                    txtchungtu(2).Text = ""
        '                    If taikhoan.MaNT = 0 Then
        '                        CboNT(0).Visible = False
        '                        txtchungtu(3).Text = "0"
        '                        txtchungtu(3).Enabled = False
        '                        CboNT(1).Visible = False
        '                    Else
        '                        Int_RecsetToCbo(String.Format("SELECT NguyenTe.MaSo As F2, NguyenTe.KyHieu As F1 FROM NguyenTe INNER JOIN HethongTK ON NguyenTe.MaSo = HethongTK.MaNT WHERE HethongTK.SoHieu =N'{0}' ORDER BY NguyenTe.KyHieu", taikhoan.sohieu), CboNT(0))
        '                        CboNT(0).Items.Insert(0, pTienStr)
        '                        VB6.SetItemData(CboNT(0), 0, 0)
        '                        CboNT(0).SelectedIndex = 0
        '                        CboNT(0).Visible = True
        '                        txtchungtu(4).Enabled = True
        '                        CboNT(0).Focus()
        '                    End If
        '                    txtchungtu(3).Text = "0"
        '                Else
        '                    CboNT(0).Visible = False
        '                    If (taikhoan.tk_id = TKVT_ID Or taikhoan.tk_id = TKDT_ID Or taikhoan.tk_id = TKGT_ID) And (loaict = 1 Or loaict = 2 Or loaict = 7 Or loaict = 8) Then
        '                        If pNhapDoiTuong > 0 Then
        '                            txtchungtu(2).Enabled = False
        '                            CboNT(3).Visible = True
        '                            LaySohieuDoiTuong2(1, String.Empty)
        '                        Else
        '                            txtchungtu(2).Enabled = True
        '                        End If
        '                        txtchungtu(3).Enabled = True
        '                    Else
        '                        txtchungtu(2).Enabled = False
        '                        txtchungtu(3).Enabled = False
        '                    End If
        '                    CboNT(1).Visible = loaict = 1 Or loaict = 8
        '                    txtchungtu(2).Focus()
        '                End If
        '            Else
        '                txtchungtu(2).Enabled = False
        '                txtchungtu(3).Enabled = False
        '            End If
        '        End If
        '        If (pDTTP <> 0 And (loaict <> 3 And (((loaict = 0 Or loaict = 1) And (taikhoan.sohieu.Substring(0, 4) = "1422" Or taikhoan.sohieu.Substring(0, 4) = "1423")) Or taikhoan.sohieu.Substring(0, 2) = "64" Or taikhoan.sohieu.Substring(0, 3) = "621" Or taikhoan.sohieu.Substring(0, 3) = "622" Or taikhoan.sohieu.Substring(0, 3) = "623" Or taikhoan.sohieu.Substring(0, 3) = "627" Or taikhoan.sohieu.Substring(0, 3) = "154" Or taikhoan.sohieu.Substring(0, 3) = "911"))) Or (loaict = 8 And taikhoan.sohieu.Substring(0, 3) = "521") Then
        '            txtchungtu(2).Enabled = True
        '            txtchungtu(2).Focus()
        '        End If
        '    Case 2 ' So hieu vat tu, nguyen te
        '        Label(12).Visible = False
        '        CboNT(2).Visible = False
        '        CboNT(1).Visible = False
        '        txtchungtu(4).Enabled = False
        '        If pDTTP <> 0 And (loaict <> 3 And ((taikhoan.sohieu.Substring(0, 2) = "51" And taikhoan.tk_id2 = TKDT_ID) Or taikhoan.sohieu.Substring(0, 2) = "64" Or taikhoan.sohieu.Substring(0, 3) = "621" Or taikhoan.sohieu.Substring(0, 3) = "622" Or taikhoan.sohieu.Substring(0, 3) = "623" Or taikhoan.sohieu.Substring(0, 3) = "627" Or taikhoan.sohieu.Substring(0, 3) = "154" Or taikhoan.sohieu.Substring(0, 3) = "911")) And txtchungtu(2).Text.Length > 0 Then
        '            tp.InitTPSohieu(txtchungtu(2).Text)
        '            txtchungtu(1).Text = tp.TenVattu
        '            If taikhoan.sohieu.Substring(0, 3) = "154" And tp.MaSo > 0 Then
        '                tien = tp.GiaThanhCK(CboThang.SelectedValue)
        '                If tien <> 0 Then
        '                    txtchungtu(5).Text = ""
        '                    txtchungtu(6).Text = Format(tien, Mask_0)
        '                End If
        '            End If
        '        Else
        '            tp.InitTPMaSo(0)
        '        End If
        '        If (taikhoan.tk_id = TKCNKH_ID) Or (taikhoan.tk_id = TKCNPT_ID) Then
        '            ckh.InitKhachHangSohieu(txtchungtu(2).Text)
        '            txtchungtu(1).Text = ckh.Ten
        '            txtchungtu(3).Enabled = (ckh.MaNT > 0)
        '            txtchungtu(2).Tag = ConvertToStrSafe(IIf(ckh.MaNT > 0, 1, 0))
        '            If ckh.MaNT = 0 Then
        '                txtchungtu(3).Text = "0"
        '            Else
        '                txtchungtu(4).Enabled = True
        '                txtchungtu(4).Text = Format(TyGiaNT(ckh.MaNT), Mask_0)
        '                txtchungtu(3).Focus()
        '            End If
        '        End If
        '        If (((loaict = 1 Or loaict = 2 Or loaict = 8) And (taikhoan.tk_id = TKVT_ID)) Or ((loaict = 7 Or loaict = 8) And (taikhoan.tk_id = TKDT_ID Or taikhoan.tk_id = TKGT_ID))) And STDetail And VTEnable And tp.MaSo = 0 Then
        '            vattu.InitVattuSohieu(txtchungtu(2).Text)
        '            If vattu.MaSo > 0 Then
        '                VTEnable = False
        '                Label(25).Visible = (pGiaUSD > 0) And (loaict = 1 Or loaict = 2 Or loaict = 8)
        '                txtchungtu(11).Visible = (pGiaUSD > 0) And (loaict = 1 Or loaict = 2 Or loaict = 8)
        '                If (taikhoan.loai = 0 Or (OutCost > 0 And OutCost <> 2)) And loaict = 2 Then
        '                    FDsNhap.Tag = ConvertToStrSafe(vattu.MaSo)
        '                    MaNhap = FDsNhap.XuatDichDanh(CboThang.SelectedIndex, String.Format("{0} - {1}{2}{3}", _
        '                                                                              vattu.sohieu, _
        '                                                                              vattu.TenVattu, _
        '                                                                              (" - Đ.v.t: "), _
        '                                                                              vattu.DonVi), CboNT(1).SelectedIndex, luong, tien)
        '                    If luong = 0 Then
        '                        luong = SoTonKho(CboThang.SelectedIndex, CboNT(1).SelectedIndex, taikhoan.maso, vattu.MaSo, tien, tien2)
        '                    End If
        '                    txtchungtu(3).Tag = ConvertToStrSafe(luong)
        '                    txtchungtu(5).Tag = ConvertToStrSafe(tien2)
        '                    txtchungtu(6).Tag = ConvertToStrSafe(tien)
        '                    txtchungtu(3).Text = Format(luong, Mask_2)
        '                    txtchungtu(6).Text = Format(tien, Mask_0)
        '                    If pGiaUSD > 0 Then txtchungtu(11).Text = Format(tien2, Mask_2)
        '                    If luong <> 0 Then
        '                        txtchungtu(4).Text = Format((IIf(0.5 + Mask_N * tien / luong > 0, Math.Floor(0.5 + Mask_N * tien / luong), Math.Ceiling(0.5 + Mask_N * tien / luong))) / Mask_N, Mask_2)
        '                    End If
        '                    HienThongBao(String.Format("Số lượng tồn kho: {0} - Thành tiền: {1}", _
        '                                     txtchungtu(3).Text, _
        '                                     txtchungtu(6).Text), 1)
        '                Else
        '                    If loaict <> 8 Then
        '                        luong = SoTonKho(CboThang.SelectedIndex, CboNT(1).SelectedIndex, taikhoan.maso, vattu.MaSo, tien, tien2)
        '                    Else
        '                        luong = SoTonKho(CboThang.SelectedIndex, CboNT(1).SelectedIndex, 0, vattu.MaSo, tien, tien2)
        '                    End If
        '                    txtchungtu(3).Text = Format(luong, Mask_2)
        '                    If loaict = 1 Then
        '                        txtchungtu(5).Text = Format(tien, Mask_0)
        '                    Else
        '                        txtchungtu(3).Tag = ConvertToStrSafe(luong)
        '                        txtchungtu(6).Text = Format(tien, Mask_0)
        '                    End If
        '                    If pGiaUSD > 0 Then txtchungtu(11).Text = Format(tien2, Mask_2)
        '                    txtchungtu(6).Tag = ConvertToStrSafe(tien)
        '                    txtchungtu(5).Tag = ConvertToStrSafe(tien2)
        '                    If luong <> 0 Then
        '                        If pGiaUSD > 0 Then
        '                            txtchungtu(4).Text = Format((IIf(0.5 + Mask_N * tien2 / luong > 0, Math.Floor(0.5 + Mask_N * tien2 / luong), Math.Ceiling(0.5 + Mask_N * tien2 / luong))) / Mask_N, Mask_2)
        '                        Else
        '                            txtchungtu(4).Text = Format((IIf(0.5 + Mask_N * tien / luong > 0, Math.Floor(0.5 + Mask_N * tien / luong), Math.Ceiling(0.5 + Mask_N * tien / luong))) / Mask_N, Mask_2)
        '                        End If
        '                    End If
        '                End If
        '                If loaict = 8 And (vattu.GiaBan1 > 0 Or vattu.GiaBan2 > 0 Or vattu.GiaBan3 > 0) Then
        '                    LayGiaBan()
        '                Else
        '                    If luong <> 0 Then
        '                        If pGiaUSD > 0 Then
        '                            txtchungtu(4).Text = Format((IIf(0.5 + Mask_N * tien2 / luong > 0, Math.Floor(0.5 + Mask_N * tien2 / luong), Math.Ceiling(0.5 + Mask_N * tien2 / luong))) / Mask_N, Mask_2)
        '                        Else
        '                            txtchungtu(4).Text = Format((IIf(0.5 + Mask_N * tien / (luong * (IIf(pGiaUSD > 0, pRate, 1))) > 0, Math.Floor(0.5 + Mask_N * tien / (luong * (IIf(pGiaUSD > 0, pRate, 1)))), Math.Ceiling(0.5 + Mask_N * tien / (luong * (IIf(pGiaUSD > 0, pRate, 1)))))) / Mask_N, Mask_2)
        '                        End If
        '                    End If
        '                End If
        '                If loaict = 1 And pGiaHT > 0 And vattu.GiaHT > 0 And taikhoan.sohieu.Substring(0, ShTkTP.Length) = ShTkTP Then
        '                    txtchungtu(4).Text = Format(vattu.GiaHT, Mask_2)
        '                End If
        '                HienThongBao(String.Format("Số lượng tồn kho: {0} - Thành tiền: {1}", _
        '                                 txtchungtu(3).Text, _
        '                                 Format(ConvertToStrSafe(txtchungtu(6).Tag), Mask_0)), 1)
        '                txtchungtu(1).Text = vattu.TenVattu
        '                txtchungtu(2).Tag = "1"
        '                txtchungtu(3).Focus()
        '                VTEnable = True
        '            End If
        '        End If
        '        With GrdChungtu
        '            tien = 0
        '            luong = 0
        '            If taikhoan.tk_id = GTGTKT_ID Then
        '                Try
        '                    j = Math.Abs(ConvertToDblSafe(txtchungtu(2).Text))
        '                Catch
        '                End Try
        '                If j = 0 Then
        '                    txtchungtu(5).Text = "0"
        '                    txtchungtu(6).Text = "0"
        '                    Exit Sub
        '                End If
        '                If ConvertToDblSafe(txtchungtu(5).Text) = 0 Then
        '                    If j > 0 And j < 5 And Not txtchungtu(2).Text.EndsWith("-") Then txtchungtu(2).Text = txtchungtu(2).Text & "-"
        '                    For i As Integer = 0 To .Rows - 1
        '                        .Row = i
        '                        .Col = 1
        '                        sh = .Items(.Row).SubItems(.Col).Text
        '                        If sh.Length = 0 Then Exit For
        '                        If Strings.Left(sh, pVATV.Length) = pVATV Then Exit For
        '                        .Col = 6
        '                        If txtchungtu(2).Text.EndsWith("-") And Strings.Left(sh, 3) <> "211" Then
        '                            tien = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
        '                            If j > 0 And j < 5 Then
        '                                v = tien * j / 100
        '                            Else
        '                                v = tien * j / (100 + j)
        '                            End If
        '                            v = RoundMoney(v)
        '                            .Items(.Row).SubItems(.Col).Text = Format(tien - v, Mask_0)
        '                            luong += v
        '                        Else
        '                            tien += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
        '                        End If
        '                        If Strings.Left(sh, 3) = "338" Then
        '                            .Col = 7
        '                            tien -= ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
        '                        End If
        '                    Next
        '                    If Not txtchungtu(2).Text.EndsWith("-") Then
        '                        luong = RoundMoney(tien * j / 100)
        '                    Else
        '                        txtchungtu(2).Text = ConvertToStrSafe(j)
        '                    End If
        '                    txtchungtu(5).Text = Format(luong, Mask_0)
        '                    txtchungtu(6).Text = "0"
        '                End If
        '            End If
        '            If taikhoan.tk_id = GTGTPN_ID Or taikhoan.tk_id = TTDB_ID Then
        '                If ConvertToDblSafe(txtchungtu(2).Text) = 0 Then
        '                    txtchungtu(5).Text = "0"
        '                    txtchungtu(6).Text = "0"
        '                    Exit Sub
        '                End If
        '                Try
        '                    j = Math.Abs(ConvertToDblSafe(txtchungtu(2).Text))
        '                Catch
        '                End Try
        '                For i As Integer = 0 To .Rows - 1
        '                    .Row = i
        '                    .Col = 1
        '                    sh = .Items(.Row).SubItems(.Col).Text
        '                    If sh.Length = 0 Then Exit For
        '                    If Strings.Left(sh, 4) = "3331" And taikhoan.tk_id = GTGTPN_ID Then Exit For
        '                    If Strings.Left(sh, 2) <> "11" And Strings.Left(sh, 4) <> "3331" And Strings.Left(sh, 3) <> "521" Then
        '                        .Col = 7
        '                        If Not txtchungtu(2).Text.EndsWith("-") And pVAT1 > 0 And taikhoan.tk_id = GTGTPN_ID Then txtchungtu(2).Text = txtchungtu(2).Text & "-"
        '                        If txtchungtu(2).Text.EndsWith("-") And taikhoan.tk_id = GTGTPN_ID Then
        '                            tien = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
        '                            If j > 0 And j < 5 Then
        '                                v = tien * j / 100
        '                            Else
        '                                v = tien * j / (100 + j)
        '                            End If
        '                            v = RoundMoney(v)
        '                            .Items(.Row).SubItems(.Col).Text = Format(tien - v, Mask_0)
        '                            luong += v
        '                        Else
        '                            If loaict = 1 Then .Col = 6
        '                            tien += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
        '                        End If
        '                    End If
        '                    If Strings.Left(sh, pSHPT.Length) <> pSHPT And Strings.Left(sh, 2) <> "11" Then
        '                        .Col = 6
        '                        tien -= ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
        '                    End If
        '                Next
        '                If taikhoan.tk_id = GTGTPN_ID Then
        '                    If Not txtchungtu(2).Text.EndsWith("-") Then
        '                        luong = RoundMoney(tien * j / 100)
        '                    Else
        '                        txtchungtu(2).Text = ConvertToStrSafe(j)
        '                    End If
        '                Else
        '                    luong = RoundMoney(tien * j / (j + 100))
        '                End If
        '                If luong >= 0 Then
        '                    txtchungtu(6).Text = Format(luong, Mask_0)
        '                    txtchungtu(5).Text = "0"
        '                Else
        '                    txtchungtu(5).Text = Format(-luong, Mask_0)
        '                    txtchungtu(6).Text = "0"
        '                End If
        '                If luong <> 0 Then
        '                    txtchungtu(6).Focus()
        '                End If
        '            End If
        '        End With
        '        If loaict = 8 And taikhoan.sohieu.Substring(0, 3) = "521" Then
        '            luong = ConvertToDblSafe(txtchungtu(2).Text)
        '            If luong > 0 And luong < 100 Then
        '                txtchungtu(5).Text = Format(RoundMoney(GiaTriTruocThue() * luong / 100), Mask_0)
        '            Else
        '                txtchungtu(5).Text = Format(SoChietKhau(), Mask_0)
        '            End If
        '        End If
        '        If (loaict = 1 Or loaict = 2 Or loaict = 7 Or loaict = 8) And vattu.MaSo > 0 And vattu.Dvt2 > 0 Then
        '            Label(12).Visible = True
        '            CboNT(2).Visible = True
        '            Int_RecsetToCbo(String.Format("SELECT MaSo AS F2, DonVi AS F1 FROM DVTVattu WHERE MaVattu={0} ORDER BY DonVi", vattu.MaSo), CboNT(2))
        '            CboNT(2).Items.Insert(0, vattu.DonVi)
        '            CboNT(2).SelectedIndex = 0
        '            CboNT(2).Focus()
        '        End If
        '        txtchungtu(9).Text = ""
        '        txtchungtu(10).Text = ""
        '        txtchungtu(4).Enabled = ((loaict = 1 Or loaict = 7 Or loaict = 8) And (vattu.MaSo > 0)) Or (ckh.MaNT > 0)
        '        If loaict = 8 And vattu.MaSo > 0 And vattu.CK > 0 And pChietKhau > 0 Then
        '            txtchungtu(9).Text = Format(vattu.CK, IIf(ConvertToDblSafe(vattu.CK * 100) Mod 100 <> 0, Mask_2, Mask_0))
        '            TinhCKCT()
        '        End If
        '    Case 3 ' So luong
        '        txtchungtu(3).Text = Format(txtchungtu(3).Text, Mask_2)
        '        If (loaict = 2 Or loaict = 7 Or loaict = 8) And vattu.MaSo > 0 Then
        '            luong = ConvertToDblSafe(txtchungtu(3).Text)
        '            txtchungtu(5).Text = "0"
        '            If loaict = 2 Then
        '                If luong <> ConvertToDblSafe((txtchungtu(3).Tag)) And ConvertToDblSafe((txtchungtu(3).Tag)) <> 0 Then
        '                    txtchungtu(6).Text = Format((luong * ConvertToDblSafe((txtchungtu(6).Tag))) / ConvertToDblSafe((txtchungtu(3).Tag)), Mask_0)
        '                    If pGiaUSD > 0 Then txtchungtu(11).Text = Format((luong * ConvertToDblSafe((txtchungtu(5).Tag))) / ConvertToDblSafe((txtchungtu(3).Tag)), Mask_2)
        '                Else
        '                    txtchungtu(6).Text = Format(ConvertToStrSafe(txtchungtu(6).Tag), Mask_0)
        '                    If pGiaUSD > 0 Then txtchungtu(11).Text = Format(ConvertToStrSafe(txtchungtu(5).Tag), Mask_2)
        '                End If
        '            Else
        '                If pGiaUSD > 0 Then txtchungtu(11).Text = Format(luong * ConvertToDblSafe(txtchungtu(4).Text), Mask_2)
        '                txtchungtu(6).Text = Format(luong * ConvertToDblSafe(txtchungtu(4).Text) * (IIf(pGiaUSD > 0, pRate, 1)), Mask_0)
        '            End If
        '        End If
        '        If (taikhoan.MaNT <> 0 And CboNT(0).SelectedIndex > 0) Or ckh.MaNT > 0 Then
        '            luong = ConvertToDblSafe(txtchungtu(3).Text)
        '            If ConvertToDblSafe(txtchungtu(4).Text) <> 0 Then
        '                If SoPSConLai() < 0 Then
        '                    txtchungtu(5).Text = Format(luong * ConvertToDblSafe(txtchungtu(4).Text), Mask_0)
        '                Else
        '                    txtchungtu(6).Text = Format(luong * ConvertToDblSafe(txtchungtu(4).Text), Mask_0)
        '                End If
        '            End If
        '        End If
        '        If loaict = 8 And vattu.MaSo > 0 Then TinhCKCT()
        '    Case 4, 5, 6 ' PS No, Co
        '        m = IIf(taikhoan.sohieu.Substring(0, 3) = "007", Mask_2, Mask_0)
        '        If Index = 4 Then
        '            txtchungtu(Index).Text = Format(txtchungtu(Index).Text, Mask_2)
        '        Else
        '            txtchungtu(Index).Text = Format(ConvertToDblSafe(txtchungtu(Index).Text), m)
        '        End If
        '        If Index = 5 Or Index = 6 Then
        '            If ConvertToDblSafe(txtchungtu(Index).Text) <> 0 Then txtchungtu(11 - Index).Text = "0"
        '        End If
        '        psnt = (CboNT(0).Visible And CboNT(0).SelectedIndex > 0) Or ckh.MaNT > 0
        '        If ((loaict = 1 Or loaict = 7 Or loaict = 8) And (vattu.MaSo > 0)) Or psnt Then
        '            luong = ConvertToDblSafe(txtchungtu(3).Text)
        '            Select Case Index
        '                Case 5
        '                    If loaict = 1 Or psnt Then
        '                        If luong > 0 And ConvertToDblSafe(txtchungtu(5).Text) <> 0 Then
        '                            If loaict = 1 Or pTien = 0 Then
        '                                tygia = ConvertToDblSafe(txtchungtu(5).Text) / luong
        '                            Else
        '                                tygia = luong / ConvertToDblSafe(txtchungtu(5).Text)
        '                            End If
        '                            If pGiaUSD > 0 And pRate > 0 Then
        '                                txtchungtu(4).Text = Format(tygia / pRate, Mask_2)
        '                            Else
        '                                txtchungtu(4).Text = Format(tygia, Mask_2)
        '                            End If
        '                            If psnt Then
        '                                If ckh.MaNT > 0 Then
        '                                    CapNhatTyGia(ckh.MaNT, tygia)
        '                                Else
        '                                    CapNhatTyGia(CboNT(0).SelectedIndex, tygia)
        '                                End If
        '                            End If
        '                        End If
        '                    End If
        '                Case 6
        '                    If loaict = 7 Or loaict = 8 Or psnt Then
        '                        If luong > 0 And ConvertToDblSafe(txtchungtu(6).Text) <> 0 Then
        '                            If loaict = 7 Or loaict = 8 Or pTien = 0 Then
        '                                tygia = ConvertToDblSafe(txtchungtu(6).Text) / luong
        '                                If loaict = 8 And pGiaUSD > 0 Then tygia /= pRate
        '                            Else
        '                                If ConvertToDblSafe(txtchungtu(5).Text) <> 0 Then tygia = luong / ConvertToDblSafe(txtchungtu(5).Text)
        '                            End If
        '                            txtchungtu(4).Text = Format(tygia, Mask_2)
        '                            If psnt Then
        '                                If ckh.MaNT > 0 Then
        '                                    CapNhatTyGia(ckh.MaNT, tygia)
        '                                Else
        '                                    CapNhatTyGia(CboNT(0).SelectedIndex, tygia)
        '                                End If
        '                            End If
        '                        End If
        '                    End If
        '                Case 4
        '                    tygia = ConvertToDblSafe(txtchungtu(4).Text)
        '                    If psnt Then
        '                        tien = SoPSConLai()
        '                        nt = DoiRaTien(luong, tygia)
        '                        If tien < 0 Or (tien = 0 And taikhoan.loai < 0) Then
        '                            txtchungtu(5).Text = Format(nt, Mask_0)
        '                        Else
        '                            txtchungtu(6).Text = Format(nt, Mask_0)
        '                        End If
        '                        If ckh.MaNT > 0 Then
        '                            CapNhatTyGia(ckh.MaNT, tygia)
        '                        Else
        '                            CapNhatTyGia(CboNT(0).SelectedIndex, tygia)
        '                        End If
        '                    Else
        '                        If loaict = 1 Or taikhoan.tk_id = TKGT_ID Then
        '                            If luong > 0 Then
        '                                If luong = ConvertToDblSafe((txtchungtu(3).Tag)) Then
        '                                    txtchungtu(4).Text = Format(ConvertToStrSafe(txtchungtu(6).Tag), Mask_0)
        '                                Else
        '                                    txtchungtu(5).Text = Format(tygia * luong * (IIf(pGiaUSD > 0, pRate, 1)), Mask_0)
        '                                    If pGiaUSD > 0 Then txtchungtu(11).Text = Format(tygia * luong, Mask_2)
        '                                End If
        '                            Else
        '                                txtchungtu(5).Text = txtchungtu(4).Text
        '                            End If
        '                        Else
        '                            If luong > 0 Then
        '                                If pGiaUSD > 0 Then txtchungtu(11).Text = Format(tygia * luong, Mask_2)
        '                                txtchungtu(6).Text = Format(tygia * luong * (IIf(pGiaUSD > 0, pRate, 1)), Mask_0)
        '                                If ConvertToDblSafe(txtchungtu(6).Text) <> 0 Then txtchungtu(5).Text = "0"
        '                            Else
        '                                If pGiaUSD > 0 Then
        '                                    txtchungtu(6).Text = Format(ConvertToDblSafe(txtchungtu(4).Text) * pRate, Mask_0)
        '                                Else
        '                                    txtchungtu(6).Text = txtchungtu(4).Text
        '                                End If
        '                            End If
        '                        End If
        '                    End If
        '            End Select
        '        End If
        '        If (loaict = 7 Or loaict = 8) And vattu.MaSo > 0 Then TinhCKCT()
        '    Case 7
        '        If pTygia > 0 Then pRate = ConvertToDblSafe(txtchungtu(7).Text)
        '        txtchungtu(Index).Text = Format(txtchungtu(Index).Text, Mask_2)
        '    Case 9, 13
        '        txtchungtu(Index).Text = Format(txtchungtu(Index).Text, Mask_2)
        '        If loaict = 8 And vattu.MaSo > 0 Then TinhCKCT()
        '    Case 10
        '        txtchungtu(Index).Text = Format(txtchungtu(Index).Text, Mask_0)
        'End Select
    End Sub
    ''' <summary>
    ''' Đặt chế độ nhập cho loại chứng từ
    ''' </summary>
    ''' <param name="loai"></param>
    ''' <remarks></remarks>
    Public Sub SetLoaiChungtu(ByRef loai As Integer)
        actax_loai = loai
        If Not SetLoaiEnable Then Exit Sub
        Me.Cursor = Cursors.WaitCursor

        Me.Width = IIf((loai = 8 And pChietKhau > 0) Or (loai = 1 And pGiamgia > 0), 953, 834) 'cũ : me.widt
        'GrdChungtu.Width = VB6.TwipsToPixelsX(IIf((loai = 8 And pChietKhau > 0) Or (loai = 1 And pGiamgia > 0), 13995, 12335))
        'GrdChungtu.Width = IIf((loai = 8 And pChietKhau > 0) Or (loai = 1 And pGiamgia > 0), GrdChungtu.Width, 805)
        GrdChungtu.AutoScrollOffset.Offset(New Point(IIf((loai = 8 And pChietKhau > 0) Or (loai = 1 And pGiamgia > 0), GrdChungtu.Width, 805), GrdChungtu.Height))
        'If VB6.PixelsToTwipsX(CmdChitiet.Left) <> (IIf((loai = 8 And pChietKhau > 0) Or (loai = 1 And pGiamgia > 0), 13840, 12175)) Then CmdChitiet.Left = VB6.TwipsToPixelsX(IIf((loai = 8 And pChietKhau > 0) Or (loai = 1 And pGiamgia > 0), 13840, 12175))
        CmdChitiet.Location = New Point(IIf((loai = 8 And pChietKhau > 0) Or (loai = 1 And pGiamgia > 0), 924, 811), 564) 'cũ : 606

        Label(23).Visible = (loai = 8 And pChietKhau > 0) Or (loai = 1 And pGiamgia > 0)
        txtchungtu(9).Visible = (loai = 8 And pChietKhau > 0) Or (loai = 1 And pGiamgia > 0)

        'Me.Width = VB6.TwipsToPixelsX(IIf(loai = 8 And pChietKhau > 0, 14280, 12650))
        'GrdChungtu.Width = VB6.TwipsToPixelsX(IIf(loai = 8 And pChietKhau > 0, 13995, 12335))
        'If (CmdChitiet.Left) <> (IIf(loai = 8 And pChietKhau > 0, 13840, 12175)) Then CmdChitiet.Left = VB6.TwipsToPixelsX(IIf(loai = 8 And pChietKhau > 0, 13840, 12175))
        'Label(23).Visible = (loai = 8 And pChietKhau > 0)
        'txtchungtu(9).Visible = (loai = 8 And pChietKhau > 0)
        WCenter(Me)
        Dim vis As Boolean = (loai = 1 Or loai = 2 Or loai = 7 Or loai = 8 Or loai = 13) And STDetail
        LbKho(1).Visible = vis Or (loai > 8)
        LbKho(1).Text = IIf(loai = 1 Or loai = 2 Or loai = 7 Or loai = 8, "Kênh phân phối", "Phân loại")
        LbKho(0).Visible = vis
        CboNguon(0).Visible = vis Or (loai > 8)
        CboNguon(1).Visible = vis
        _mnIn_5.Available = vis Or (loai > 8)
        If loai > 8 Then
            Int_RecsetToCbo(String.Format("SELECT MaSo As F2, SoHieu + ' - ' + Ten As F1 FROM LoaiChungTu WHERE (Cap = 2) AND (CapTren = {0}) ORDER BY SoHieu", ConvertToStrSafe(OptLoai(loai).Tag)), CboNguon(0))
        End If
        txtchungtu(2).Tag = ConvertToStrSafe(IIf(loai = 1 Or loai = 2, 1, 0))
        XoaPhieuTrenManHinh()
        chkXT.Visible = (loai = 1) And pDTTP <> 0
        ChkHNT.CheckState = CheckState.Unchecked
        ChkHNT.Visible = (loai = 1) And pDTTP <> 0
        vis = (loai = 7 Or loai = 8) And (pBaoGia = 1) And ((pThuChiNhapXuat And pPhieu = 1) Or (Not pThuChiNhapXuat And pPhieu = 0)) ' vancuong edit 1/4/18
        Chk.Visible = vis
        Chk.CheckState = CheckState.Unchecked
        pMaBG = 0
        vis = ((loai = 7 Or loai = 8) And pNVBH = 1)
        Label(21).Visible = vis
        txt(3).Visible = vis
        LBNV.Visible = vis
        CmdBC.Visible = (pBarCode > 0) And (loai = 2 Or loai = 8)
        Dim rs As DataTable
        Dim sohd As Double
        Select Case loai
            Case 1, 2, 7, 8
                Int_RecsetToCbo("SELECT MaSo As F2, SoHieu + ' - ' + DienGiai As F1, SoHieu FROM NguonNhapXuat ORDER BY SoHieu", CboNguon(0))
                If CboNguon(1).Items.Count = 0 And STDetail Then
                    ErrMsg(er_KhoHang)
                    Me.Close()
                    FrmKho.Tag = "1"
                    FrmKho.ShowDialog()
                    Exit Sub
                End If
                If CboNguon(0).Items.Count = 0 And STDetail Then
                    ErrMsg(er_NguonNX)
                    Me.Close()
                    FrmNguon.ShowDialog()
                    Exit Sub
                End If
                If loai = 1 Then
                    chkXT.CheckState = CheckState.Unchecked
                    chkXT_CheckStateChanged(chkXT, New EventArgs())
                End If
                Select Case loai
                    Case 1, 2
                        CmdPhieu(1).Text = Ngonngu("&2 Phiếu NX", "&2 Bill I/E")
                        If loai = 1 Then txt(1).Text = Ngonngu("Nhập hàng ", "Imported goods ")
                    Case 7 : CmdPhieu(1).Text = Ngonngu("&2 Báo giá", "&2 Quotes")
                    Case 8
                        CmdPhieu(1).Text = Ngonngu("&2 Hoá đơn", "&2 Invoice")
                        txt(1).Text = Ngonngu("Bán hàng ", "Sales ")
                        rs = ExecSQLReturnDT("select sohddau, soluong, kyhieu from slhoadon order by thangnhap,sohddau")
                        For Each rsItem As DataRow In rs.Rows
                            sohd = ConvertToDblSafe(GetSelectValue(String.Format("select count (maso) as f1 from hoadon where loai=1 and kyhieu like '{0}' and CONVERT(INT,sohd) >= {1} and CONVERT(INT,sohd) <= {1}{2}", _
                                                                       rsItem("KyHieu"), _
                                                                       rsItem("SoHDDau"), _
                                                                       rsItem("soluong"))))
                            If sohd < ConvertToDblSafe(rsItem("soluong")) Then
                                txt(0).Text = ConvertToStrSafe(ConvertToDblSafe(rsItem("SoHDDau")) + sohd)
                                Exit For
                            End If
                        Next
                        If txt(0).Text = "..." Or txt(0).Text = "" Then
                            ' mới thay đổi : 11-2-19
                            'MessageBox.Show(Ngonngu("Vui lòng nhập hoá đơn trước khi bán hàng", "Please enter your bill beforre selling"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txt(0).Focus()
                        End If
                    Case 9, 10, 13 : CmdPhieu(1).Text = Ngonngu("&2 Phiếu TG", "&2 Bill TG")
                End Select
            Case 9, 13
                If loai = 13 Then
                    Int_RecsetToCbo("SELECT MaSo As F2,SoHieu + ' - ' + DienGiai As F1 FROM NguonNhapXuat ORDER BY SoHieu", CboNguon(0))
                    If CboNguon(1).Items.Count = 0 And STDetail Then
                        ErrMsg(er_KhoHang)
                        Me.Close()
                        FrmKho.Tag = "1"
                        FrmKho.ShowDialog()
                        If CboThang.Items.Count > 0 Then
                            CboThang.SelectedIndex = ConvertToDblSafe(cuongccdcthang1)
                        End If

                        MedNgay(0).Text = FormatDate(ngayChungTuPublic)
                        Exit Sub
                    End If
                    If CboNguon(0).Items.Count = 0 And STDetail Then
                        ErrMsg(er_NguonNX)
                        Me.Close()
                        FrmNguon.ShowDialog()
                        Exit Sub
                    End If
                End If
                If MaSoCT = 0 Then
TTS:
                    pNghiepVu = NV_TANG
                    If loai = 9 Then
                        frmTaiSan.ShowDialog()
                    Else
                        pMaCongcudungcu = 0
                        FrmCongcudungcu.Tag = "0"
                        FrmCongcudungcu.ShowDialog()
                    End If
                    If pMaCongcudungcu > 0 Or pMaTaiSan > 0 Then
                        Ngay(0) = ConvertToDateSafe(MedNgay(0).Text)
                        Ngay(1) = ConvertToDateSafe(MedNgay(1).Text)
                    Else
                        XoaPhieuTrenManHinh()
                    End If
                End If
            Case 10
                If MaSoCT = 0 Then
                    pNghiepVu = NV_GIAM
                    frmDSTaiSan.ShowDialog()
                End If
            Case 11
                If MaSoCT = 0 Then
                    pNghiepVu = NV_DGLAI
                    frmDSTaiSan.ShowDialog()
                End If
            Case 12
                If MaSoCT = 0 Then
                    pNghiepVu = NV_TKHAO
                    frmKhauHao.ShowDialog()
                End If
            Case 14
                If MaSoCT = 0 Then
                    pNghiepVu = NV_TKHAO
                    frmPhanbo.ShowDialog()
                End If
            Case 15
                If MaSoCT = 0 Then
                    pNghiepVu = NV_GIAM
                    frmDSCCDC.ShowDialog()
                End If
        End Select
        If (loai = 12 Or loai = 14) And (pGhichungtu = 1 Or MaSoCT > 0) Then
            MedNgay_Leave(MedNgay(0), New EventArgs())
            MedNgay_Leave(MedNgay(1), New EventArgs())
        End If
        If loai > 8 And (pGhichungtu = 1 Or MaSoCT > 0) Then
            For i As Integer = 0 To 14
                If (i < 4 Or i > 7) And (i <> loai) Then OptLoai(i).Enabled = False
            Next
            CboThang.Enabled = False
            If pGhichungtu = 1 Then
                hienctts()
                tscount += 1
                If loai = 9 And MaSoCT = 0 And tscount < 9 Then
                    MaTS(tscount) = pMaTaiSan
                    If MessageBox.Show(Ngonngu("Nhập bổ sung tài sản cùng chứng từ?", "Enter more additional assets to voucher?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                        pMaTaiSan = 0
                        GoTo TTS
                    End If
                Else
                    If loai = 13 And tscount < 9 Then
                        MaTS(tscount) = pMaCongcudungcu
                        If MessageBox.Show(Ngonngu("Nhập bổ sung công cụ dụng cụ cùng chứng từ?", "Enter more additional tools to voucher?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                            pMaCongcudungcu = 0
                            GoTo TTS
                        End If
                    End If
                End If
            End If
        Else
            If loaict > 8 Or (loai > 8 And pGhichungtu = 0) Then
                SetLoaiEnable = False
                _OptLoai_0.Checked = True
                _OptLoai_0.Focus()
                _OptLoai_0.Enabled = True
                _OptLoai_3.Enabled = True
                _OptLoai_1.Enabled = STDetail
                _OptLoai_2.Enabled = STDetail
                _OptLoai_8.Enabled = STDetail
                _OptLoai_9.Enabled = FADetail
                _OptLoai_10.Enabled = FADetail
                _OptLoai_11.Enabled = FADetail
                _OptLoai_12.Enabled = FADetail
                _OptLoai_13.Enabled = FADetail
                _OptLoai_14.Enabled = FADetail
                CboThang.Enabled = True
                SetLoaiEnable = True
            End If
        End If
        vBH = 0
        If initOption = -1 Then MaSoCT = 0
        loaict = IIf((loai >= 8 And pGhichungtu = 1) Or (loai < 9), loai, 0)
        txt_Leave(txt(0), New EventArgs)
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' Thủ tục xóa nội dung phiếu trên cửa sổ
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub XoaPhieuTrenManHinh()
        If pNghiepVu = NV_TANG Then
            For i As Integer = 0 To tscount
                XoaTaiSan(MaTS(i))
            Next
        End If
        pGhichungtu = 0
        pNghiepVu = 0
        pMaTaiSan = 0
        ClearText(Me)
        ClearGrid(GrdChungtu, ConvertToDblSafe(GrdChungtu.Tag))
        taikhoan.InitTaikhoanMaSo(0)
        vattu.InitVattuMaSo(0)
        ckh.InitKhachHangMaSo(0)
        txtchungtu(0).Tag = "0"
        txtchungtu(2).Tag = "0"
        For i As Integer = 3 To 6
            txtchungtu(i).Text = ""
        Next
        LbUser.Text = ClsUser.TenNSD
        CboNT(1).Visible = False
        txt(4).Text = "..."
        For i As Integer = 0 To 2
            txt(i).Text = "..."
            CmdPhieu(i).Visible = False
        Next
        If CboNguon(2).Items.Count > 0 Then CboNguon(2).SelectedIndex = 0
        nhieunoco = False
        Label(12).Visible = False
        CboNT(2).Visible = False
        tentc = "..."
        diachitc = "..."
        ctgoc = "..."
        TenNX = "..."
        DiaChiNX = "..."
        TenBH = "..."
        DiaChiBH = "..."
        MSTBH = "..."
        MaKHBH = 0
        HanTT = #1/1/1900#
        Erase hd
        hdcount = -1
        tscount = -1
        XoaHD()
        vBH = 0
        If loaict = 1 Then
            chkXT.CheckState = CheckState.Unchecked
            chkXT_CheckStateChanged(chkXT, New EventArgs())
        End If
        CmdChitiet.Tag = -1
        Command(1).Enabled = ChoNhapTiep()
        Command(2).Enabled = True
        Label(22).Enabled = False
        txtchungtu(8).Enabled = False
        Chk.CheckState = CheckState.Unchecked
        pMaBG = 0
        txtchungtu(7).Text = Format(pRate, Mask_2)
        Label(25).Visible = False
        txtchungtu(11).Visible = False
        CboNT(3).Visible = False
        txt(5).Text = ""
        LBKH.Text = ""
    End Sub
    ''' <summary>
    ''' Thủ tục hiển thị nội dung phiếu trên màn hình
    ''' </summary>
    ''' <param name="p"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function HienPhieuTrenManHinh(ByRef p As Integer) As Integer
        Dim result As Integer = 0
        Dim sodong As Integer
        Dim ps As Double
        Dim ThemDong As Boolean
        Dim mts, mct, uid, mk, ms, mvt, mtp As Integer
        Dim TL As Integer
        Dim dgia, psnt, luong As Double
        Dim st As String = String.Empty
        Dim ma As Integer = MaSoCT
        Dim DienGiai As String = String.Empty
        Dim sh As String = IIf(p > 0, "P", "")
        Dim rs_chungtu As DataTable = ExecSQLReturnDT(String.Format("SELECT ChungTu{0}.*,HoaDon{0}.MaKhachHang,HoaDon{0}.Loai AS LoaiHD,KyHieu,HoaDon{0}.SoHD AS SHD,HoaDon{0}.Sohopdong,HoaDon{0}.ngayhopdong,HoaDon{0}.diadiemgiaohang,HoaDon{0}.diadiemnhanhang,HoaDon{0}.sovandon,HoaDon{0}.socontainer,HoaDon{0}.tenvanchuyen,HoaDon{0}.den,HoaDon{0}.tim,HoaDon{0}.hong,HoaDon{0}.xanh,HoaDon{0}.xanhnoidia,NgayPH,MatHang,Soluong,Thanhtien,Tyle,HD,KCT,NK,TS,HoaDon{0}.DC,HTTT,MauSo,KhachHang.Ten,KhachHang.DiaChi,KhachHang.MST,HDBL,NLTS,DN,HoaDon{0}.TyGia AS TG  FROM (ChungTu{0} LEFT JOIN HoaDon{0} ON ChungTu{0}.MaSo=HoaDon{0}.MaSo) LEFT JOIN KhachHang ON ChungTu{0}.MaKH=KhachHang.MaSo WHERE Chungtu{0}.MaCT={1}{2} ORDER BY Chungtu{0}.MaSo DESC", _
                                                          sh, _
                                                          ConvertToStrSafe(MaSoCT), _
                                                          (IIf(pProcessMode = 1, " AND XuLy<2", ""))))
        If rs_chungtu.Rows.Count = 0 Then
            MessageBox.Show(Ngonngu("Phiếu đã bị xoá!", "Bill have been deleted"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            result = -1
            GoTo KetThuc
        End If
        If rs_chungtu.Rows.Count > 0 Then
            Dim rs_chungtuItem As DataRow = rs_chungtu.Rows(0)
            If rs_chungtuItem("NgayCT").ToString = "" And rs_chungtuItem("NgayGS").ToString = "" Then
                MessageBox.Show("Sai ngày chứng từ hoặc ngày ghi sổ!")
                Me.Cursor = Cursors.Default
                Return result
            End If
            OptLoai(IIf(ConvertToStrSafe(rs_chungtuItem("maloai")) <> 7, rs_chungtuItem("maloai"), 8)).Checked = True
            If loaict = 2 Then OptLoai(IIf(ConvertToStrSafe(rs_chungtuItem("maloai")) <> 7, rs_chungtuItem("maloai"), 8)).Checked = True
            XoaPhieuTrenManHinh()
            txt(4).Text = rs_chungtuItem("manhapxuat").ToString
            mathuchi = rs_chungtuItem("mathuchi").ToString
            MaCT = rs_chungtuItem("mact")
            If rs_chungtuItem("maloai").ToString <> "" Then
                loaict = rs_chungtuItem("maloai")
            End If
            If rs_chungtuItem("thangct").ToString <> "" Then
                SetListIndex(CboThang, rs_chungtuItem("thangct"))
            End If
            Chk.CheckState = IIf(ConvertToStrSafe(rs_chungtuItem("maloai")) = 7, 1, 0)
            pMaBG = IIf(ConvertToStrSafe(rs_chungtuItem("maloai")) = 7, ma, 0)
            If rs_chungtuItem("NgayCT").ToString <> "" Then
                Ngay(0) = rs_chungtuItem("NgayCT")
            End If
            If rs_chungtuItem("NgayGS").ToString <> "" Then
                Ngay(1) = rs_chungtuItem("NgayGS")
            End If

            MedNgay(0).Text = String.Format(Ngay(0), Mask_D)
            MedNgay(1).Text = String.Format(Ngay(1), Mask_D)
            If rs_chungtuItem("SoHieu").ToString <> "" Then
                txt(0).Text = rs_chungtuItem("SoHieu")
            Else
                txt(0).Text = ""
            End If
            If rs_chungtuItem("DienGiai").ToString <> "" Then
                txt(1).Text = rs_chungtuItem("DienGiai")
            Else
                txt(1).Text = ""
            End If

            If txt(5).Visible Then
                If rs_chungtuItem("MaKhachHang").ToString.Length > 0 Then txt(5).Text = MaSo2SoHieu(ConvertToDblSafe(rs_chungtuItem("MaKhachHang")), "khachhang")
            End If
            txt_Leave(txt(5), New EventArgs())
            If pSongNgu Then
                If rs_chungtuItem("DienGiaiE").ToString <> "" Then
                    txt(2).Text = rs_chungtuItem("DienGiaiE")
                Else
                    txt(2).Text = "..."
                End If
            End If
            SetListIndex(CboNguon(3), rs_chungtuItem("CTGS"))
            If rs_chungtuItem("User_ID").ToString <> "" Then
                uid = rs_chungtuItem("User_ID")
            End If

            LbUser.Text = TenUser(uid)
            If (loaict = 7 Or loaict = 8) And pNVBH > 0 Then
                If rs_chungtuItem("MaNV").ToString <> "" Then
                    LBNV.Text = TenNV(sh, rs_chungtuItem("MaNV"))
                Else
                    LBNV.Text = ""
                End If

                txt(3).Text = sh
                txt(3).Tag = rs_chungtuItem("MaNV")
            End If
            If (ConvertToStrSafe(rs_chungtuItem("maloai")) = 1 Or ConvertToStrSafe(rs_chungtuItem("maloai")) = 2 Or ConvertToStrSafe(rs_chungtuItem("maloai")) = 7 Or ConvertToStrSafe(rs_chungtuItem("maloai")) = 8) And STDetail Then
                If rs_chungtuItem("MaNguon").ToString <> "" Then
                    SetListIndex(CboNguon(0), rs_chungtuItem("MaNguon"))
                End If
                If rs_chungtuItem("MaKho").ToString <> "" Then
                    SetListIndex(CboNguon(1), rs_chungtuItem("MaKho"))
                End If

            End If
            If pTygia > 0 Then txtchungtu(7).Text = Format(rs_chungtuItem("tygia"), Mask_2)
            If pGiaUSD > 0 Then pRate = rs_chungtuItem("tygia")
            Dim rsts As DataTable
            If (ConvertToStrSafe(rs_chungtuItem("maloai")) > 8) And FADetail And ConvertToStrSafe(rs_chungtuItem("maloai")) <> 13 Then
                rsts = ExecSQLReturnDT(String.Format("SELECT DISTINCT TOP 1 MaNhom FROM CTTaiSan WHERE MaCTKT = {0}", ma))
                Dim rstsItem As DataRow = Nothing
                If rsts.Rows.Count > 0 Then
                    rstsItem = rsts.Rows(0)
                End If
                If rsts.Rows.Count > 0 Then SetListIndex(CboNguon(0), rstsItem("MaNhom"))
                'rsts.Close()
                rsts = Nothing
            End If
            If rs_chungtuItem("MaDT").ToString <> "" Then
                SetListIndex(CboNguon(2), rs_chungtuItem("MaDT"))
            End If

            sodong = -1
            LayThongtinCT(rs_chungtuItem("MaCT"), 0, tentc, diachitc, ctgoc, MaKHBH, p)
            LayThongtinCT(rs_chungtuItem("MaCT"), 1, TenNX, DiaChiNX, , , p)
            LayThongtinCT(rs_chungtuItem("MaCT"), 2, TenBH, DiaChiBH, sh, , p)
            LayThongtinCT(rs_chungtuItem("MaCT"), 3, unc1, unc2, unc3, , p)

            Dim shDate As Date = ConvertToDateSafe(sh)
            HanTT = #1/1/1900#
            If shDate.Year >= pNamTC - 1 Then
                HanTT = shDate
            End If

            sh = ""
            If pCongNoHD > 0 Then txtchungtu(8).Text = rs_chungtuItem("HanTT")
            If pSoVV > 0 And ConvertToDblSafe(rs_chungtuItem("MaDT1")) > 0 Then SetListIndex(CboVV(0), rs_chungtuItem("MaDT1"))
            If pSoVV > 1 And ConvertToDblSafe(rs_chungtuItem("MaDT2")) > 0 Then SetListIndex(CboVV(1), rs_chungtuItem("MaDT2"))
            If pSoVV > 2 And ConvertToDblSafe(rs_chungtuItem("MaDT3")) > 0 Then SetListIndex(CboVV(2), rs_chungtuItem("MaDT3"))
            Dim soluongno, phatsinhno As Double
            Dim rs_chungtuIndex As Integer = 0
            Dim co As Integer = 0
            Dim dem As Integer = 0
            Do While rs_chungtuIndex < rs_chungtu.Rows.Count
                rs_chungtuItem = rs_chungtu.Rows(rs_chungtuIndex)
                rs_chungtuIndex += 1 ' C15 Rs LOOP CONTROL
                If ConvertToStrSafe(rs_chungtuItem("MaTkNo")) <> 0 Then
                    taikhoan.InitTaikhoanMaSo(rs_chungtuItem("MaTkNo"))
                    If (taikhoan.tk_id = GTGTKT_ID) Or (taikhoan.tk_id = GTGTPN_ID) Then
                        hdcount += 1
                        ReDim Preserve hd(hdcount)
                        With hd(hdcount)
                            .MaSo = rs_chungtuItem("MaSo")
                            If Not Convert.IsDBNull(rs_chungtuItem("MaKhachHang")) Then
                                If rs_chungtuItem("MaKhachHang").ToString <> "" Then
                                    .MaKhachHang = rs_chungtuItem("MaKhachHang")
                                End If
                                If rs_chungtuItem("LoaiHD").ToString <> "" Then
                                    .loai = rs_chungtuItem("LoaiHD")
                                End If
                                If rs_chungtuItem("KyHieu").ToString <> "" Then
                                    .KyHieu = rs_chungtuItem("KyHieu")
                                Else
                                    .KyHieu = Nothing
                                End If
                                If rs_chungtuItem("shd").ToString <> "" Then
                                    .sohd = rs_chungtuItem("shd")
                                Else
                                    .sohd = Nothing
                                End If

                                .NgayPH = IIf(Not Convert.IsDBNull(rs_chungtuItem("NgayPH")), rs_chungtuItem("NgayPH"), rs_chungtuItem("NgayGS"))
                                If rs_chungtuItem("MatHang").ToString <> "" Then
                                    .MatHang = rs_chungtuItem("MatHang")
                                Else
                                    .MatHang = Nothing
                                End If
                                If rs_chungtuItem("soluong").ToString <> "" Then
                                    .soluong = rs_chungtuItem("soluong")
                                End If
                                If rs_chungtuItem("ThanhTien").ToString <> "" Then
                                    .ThanhTien = rs_chungtuItem("ThanhTien")
                                End If
                                If rs_chungtuItem("TyLe").ToString <> "" Then
                                    .TyLe = rs_chungtuItem("TyLe")
                                End If
                                If rs_chungtuItem("hd").ToString <> "" Then
                                    .HD = rs_chungtuItem("hd")
                                End If
                                If rs_chungtuItem("KCT").ToString <> "" Then
                                    .KCT = rs_chungtuItem("KCT")
                                End If
                                If rs_chungtuItem("HTTT").ToString <> "" Then
                                    .HTTT = rs_chungtuItem("HTTT")
                                Else
                                    .HTTT = Nothing
                                End If
                                If rs_chungtuItem("MauSo").ToString <> "" Then
                                    .MauSo = rs_chungtuItem("MauSo")
                                Else
                                    .MauSo = Nothing
                                End If
                                If rs_chungtuItem("HDBL").ToString <> "" Then
                                    .HDBL = rs_chungtuItem("HDBL")
                                End If
                                If rs_chungtuItem("NLTS").ToString <> "" Then
                                    .NLTS = rs_chungtuItem("NLTS")
                                End If
                                If rs_chungtuItem("dn").ToString <> "" Then
                                    .dn = rs_chungtuItem("dn")
                                End If
                                If rs_chungtuItem("NK").ToString <> "" Then
                                    .NK = rs_chungtuItem("NK")
                                End If
                                If rs_chungtuItem("ts").ToString <> "" Then
                                    .ts = rs_chungtuItem("ts")
                                End If
                                If rs_chungtuItem("DC").ToString <> "" Then
                                    .DC = rs_chungtuItem("DC")
                                End If
                                If rs_chungtuItem("tg").ToString <> "" Then
                                    .tygia = rs_chungtuItem("tg")
                                End If
                                If rs_chungtuItem("sohopdong").ToString <> "" Then
                                    .sohopdong = rs_chungtuItem("sohopdong")
                                Else
                                    .sohopdong = Nothing
                                End If
                                If rs_chungtuItem("Ngayhopdong").ToString <> "" Then
                                    .Ngayhopdong = rs_chungtuItem("Ngayhopdong")
                                End If
                                If rs_chungtuItem("diadiemgiaohang").ToString <> "" Then
                                    .diadiemgiaohang = rs_chungtuItem("diadiemgiaohang")
                                Else
                                    .diadiemgiaohang = Nothing
                                End If
                                If rs_chungtuItem("diadiemnhanhang").ToString <> "" Then
                                    .diadiemnhanhang = rs_chungtuItem("diadiemnhanhang")
                                Else
                                    .diadiemnhanhang = Nothing
                                End If
                                If rs_chungtuItem("sovandon").ToString <> "" Then
                                    .sovandon = rs_chungtuItem("sovandon")
                                Else
                                    .sovandon = Nothing
                                End If
                                If rs_chungtuItem("socontainer").ToString <> "" Then
                                    .socontainer = rs_chungtuItem("socontainer")
                                Else
                                    .socontainer = Nothing
                                End If
                                If rs_chungtuItem("tenvanchuyen").ToString <> "" Then
                                    .tenvanchuyen = rs_chungtuItem("tenvanchuyen")
                                Else
                                    .tenvanchuyen = Nothing
                                End If
                                If rs_chungtuItem("Den").ToString <> "" Then
                                    .Den = rs_chungtuItem("Den")
                                End If
                                If rs_chungtuItem("tim").ToString <> "" Then
                                    .tim = rs_chungtuItem("tim")
                                End If
                                If rs_chungtuItem("hong").ToString <> "" Then
                                    .hong = rs_chungtuItem("hong")
                                End If
                                If rs_chungtuItem("xanh").ToString <> "" Then
                                    .xanh = rs_chungtuItem("xanh")
                                End If
                                If rs_chungtuItem("xanhnoidia").ToString <> "" Then
                                    .xanhnoidia = rs_chungtuItem("xanhnoidia")
                                End If

                            End If
                            TL = .TyLe
                            If Not KHDetail Then
                                If Not Convert.IsDBNull(rs_chungtuItem("ten")) Then .TenKH = rs_chungtuItem("ten")
                                If Not Convert.IsDBNull(rs_chungtuItem("DiaChi")) Then .DiaChiKH = rs_chungtuItem("DiaChi")
                                If Not Convert.IsDBNull(rs_chungtuItem("MST")) Then .MSTKH = rs_chungtuItem("MST")
                            End If
                        End With
                        If rs_chungtuItem("MaKhachHang").ToString <> "" Then
                            ms = IIf(Not Convert.IsDBNull(rs_chungtuItem("MaKhachHang")), hdcount, -1)
                        End If

                    Else
                        TL = 0
                        ms = -1
                    End If
                    If ConvertToStrSafe(rs_chungtuItem("sops")) <> 0 Or taikhoan.tk_id = GTGTKT_ID Or taikhoan.tk_id = GTGTPN_ID Or taikhoan.tk_id = TTDB_ID Or taikhoan.tk_id = TKVT_ID Or ((taikhoan.tk_id = TKCNKH_ID Or taikhoan.tk_id = TKCNPT_ID) And ConvertToDblSafe(rs_chungtuItem("MaKHC")) > 0) Then
                        If Not CmdPhieu(0).Visible Then CmdPhieu(0).Visible = (taikhoan.sohieu.Substring(0, TM.Length) = TM)
                        If Not CmdPhieu(1).Visible Then
                            CmdPhieu(1).Visible = (taikhoan.tk_id = TKVT_ID Or taikhoan.tk_id = TKDT_ID Or taikhoan.tk_id = TSCD_ID)
                            CmdPhieu(1).Enabled = (GetSelectValue("select VT as f1 from users where maso=" + CStr(UserID)) Mod 10000000000) \ 1000000000 = 1
                        End If
                        If Not CmdPhieu(3).Visible Then CmdPhieu(3).Visible = (taikhoan.sohieu.Substring(0, NH.Length) = NH)
                        If (((taikhoan.tk_id <> TKVT_ID) Or (Not STDetail)) And (taikhoan.tk_id <> GTGTKT_ID) And (taikhoan.tk_id <> TKDT_ID) And (taikhoan.tk_id <> TKGT_ID) And (taikhoan.tk_id <> TSCD_ID)) And (ConvertToDblSafe(rs_chungtuItem("MaTP")) = 0 Or taikhoan.tk_id = TKCNKH_ID Or taikhoan.tk_id = TKCNPT_ID) Then ' And taikhoan.TK_ID <> TKCNKH_ID And taikhoan.TK_ID <> TKCNPT_ID
                            ThemDong = Not PSDaCo(taikhoan, -1, rs_chungtuItem("sops"), rs_chungtuItem("SoPS2No"), rs_chungtuItem("makh"), rs_chungtuItem("MaVattu"))
                        ElseIf (loaict = 9 Or loaict = 11) And taikhoan.tk_id = TSCD_ID Then
                            Dim mts1 = GetSelectValue("SELECT max(MaTS) AS F1 FROM CTTaiSan WHERE MaTS>0 AND MaTS<" + CStr(mts) + " AND MaCTKT=" + CStr(rs_chungtuItem("mact")) + " AND (ABS(NG_NS+NG_TBS+NG_TD+NG_CNK)=" + CStr(rs_chungtuItem("sops")) + " OR ABS(CL_NS+CL_TBS+CL_TD+CL_CNK)=" + CStr(rs_chungtuItem("sops")) + ")")
                            If mts1 = 0 Then mts1 = GetSelectValue("SELECT max(MaTS) AS F1 FROM CTTaiSan WHERE MaTS>0 AND MaCTKT=" + CStr(rs_chungtuItem("mact")) + " AND (ABS(NG_NS+NG_TBS+NG_TD+NG_CNK)=" + CStr(rs_chungtuItem("sops")) + " OR ABS(CL_NS+CL_TBS+CL_TD+CL_CNK)=" + CStr(rs_chungtuItem("sops")) + ")")
                            If mts1 > 0 Then
                                ThemDong = True
                            Else
                                ThemDong = Not PSDaCo(taikhoan, -1, rs_chungtuItem("sops"), rs_chungtuItem("SoPS2No"), rs_chungtuItem("makh"), rs_chungtuItem("MaVattu"), mts, rs_chungtuItem("mact"))
                            End If
                        Else
                            ThemDong = True
                        End If
                        If ThemDong Then
                            sodong += 1
                            DienGiai = ""
                            If (taikhoan.tk_id = TKVT_ID Or taikhoan.tk_id = TKDT_ID Or taikhoan.tk_id = TKGT_ID) And (ConvertToDblSafe(rs_chungtuItem("MaVattu")) > 0) Then
                                If chkXT.CheckState = CheckState.Unchecked And pDTTP <> 0 Then
                                    sh = (GetSelectValue(String.Format("SELECT HethongTK.SoHieu AS F1,(CASE WHEN (MaTP>0) THEN MaTP ELSE MaKH END) AS F2 FROM {0} WHERE CT_ID=900000000+{1}", _
                                                             ChungTu2TKNC(-1), _
                                                             rs_chungtuItem("MaSo")), mct))
                                    If sh <> "0" And loaict <> 13 Then
                                        chkXT.CheckState = CheckState.Checked
                                        chkXT_CheckStateChanged(chkXT, New EventArgs())
                                        txtsh(0).Text = sh
                                        txtsh_Leave(txtsh(0), New EventArgs())
                                        If ConvertToDblSafe((cmd(0).Tag)) = 1 And mct > 0 Then
                                            txtsh(1).Text = MaSo2SoHieu(mct, "KhachHang")
                                            txtsh_Leave(txtsh(1), New EventArgs())
                                        ElseIf ConvertToDblSafe((cmd(0).Tag)) = 2 And mct > 0 Then
                                            txtsh(1).Text = MaSo2SoHieu(mct, "TP154")
                                            txtsh_Leave(txtsh(1), New EventArgs())
                                        ElseIf ConvertToDblSafe((cmd(0).Tag)) = 3 And mct > 0 Then
                                            txtsh(1).Text = MaSo2SoHieu(mct, "hethongtk")
                                            txtsh_Leave(txtsh(1), New EventArgs())
                                        End If
                                    End If
                                End If
                                If rs_chungtuItem("MaVattu").ToString <> "" Then
                                    vattu.InitVattuMaSo(rs_chungtuItem("MaVattu"))
                                End If

                                sh = vattu.sohieu
                                DienGiai = vattu.TenVattu
                                DienGiai = String.Format("{0}{1}", _
                                               vattu.TenVattu, _
                                               (IIf((loaict = 1 Or loaict = 2 Or loaict = 8) And KtraDVT(vattu.MaSo, rs_chungtuItem("dvt"), st), " - " & ("Đ.v.t: ") & st, "")))
                            Else
                                vattu.InitVattuMaSo(0)
                                If (taikhoan.tk_id = TKCNKH_ID Or taikhoan.tk_id = TKCNPT_ID) And (ConvertToDblSafe(rs_chungtuItem("makh")) > 0) Then
                                    ckh.InitKhachHangMaSo(rs_chungtuItem("makh"))
                                    sh = ckh.SoHieu
                                    DienGiai = ckh.Ten
                                Else
                                    ckh.InitKhachHangMaSo(0)
                                    sh = IIf(taikhoan.MaNT > 0, SoHieuNT(taikhoan.MaNT), (IIf(TL > 0, ConvertToStrSafe(TL), "")))
                                    DienGiai = IIf(pNN = 0, taikhoan.ten, taikhoan.TenE)
                                End If
                            End If
                            If ConvertToStrSafe(rs_chungtuItem("MaTP")) <> 0 And (taikhoan.tk_id <> TKVT_ID) And ckh.MaSo = 0 And (taikhoan.loai = 6 Or taikhoan.sohieu Like "154*" Or taikhoan.sohieu Like "911*") Then
                                tp.InitTPMaSo(rs_chungtuItem("MaTP"))
                                sh = tp.SoHieu
                                DienGiai = tp.TenVattu
                            End If
                            If (loaict = 9 Or loaict = 11) And taikhoan.tk_id = TSCD_ID Then
                                mts = ConvertToDblSafe(GetSelectValue(String.Format("SELECT max(MaTS) AS F1 FROM CTTaiSan WHERE MaTS>0 AND MaTS<{0} AND MaCTKT={1} AND (ABS(NG_NS+NG_TBS+NG_TD+NG_CNK)={2} OR ABS(CL_NS+CL_TBS+CL_TD+CL_CNK)={2})", _
                                                                          mts, _
                                                                          ConvertToStrSafe(rs_chungtuItem("MaCT")), _
                                                                          CStr(rs_chungtuItem("sops")))))
                                If mts = 0 Then
                                    mts = ConvertToDblSafe(GetSelectValue(String.Format("SELECT max(MaTS) AS F1 FROM CTTaiSan WHERE MaTS>0 AND MaCTKT={1} AND (ABS(NG_NS+NG_TBS+NG_TD+NG_CNK)={2} OR ABS(CL_NS+CL_TBS+CL_TD+CL_CNK)={2})", _
                                                                          mts, _
                                                                          ConvertToStrSafe(rs_chungtuItem("MaCT")), _
                                                                          CStr(rs_chungtuItem("sops")))))
                                End If
                                If mts > 0 Then
                                    sh = MaSo2SoHieu(mts, "TaiSan")
                                    DienGiai = TenTS("", mts)
                                End If
                            End If
                            If (loaict = 13) And taikhoan.tk_id = TSCD_ID Then
                                mts = ConvertToDblSafe(GetSelectValue(String.Format("SELECT max(MaTS) AS F1 FROM CTcongcudungcu WHERE MaTS>0 AND MaTS<{0} AND MaCTKT={1} AND (ABS(NG_NS+NG_TBS+NG_TD+NG_CNK)={2} OR ABS(CL_NS+CL_TBS+CL_TD+CL_CNK)={2})", _
                                                                          mts, _
                                                                          ConvertToStrSafe(rs_chungtuItem("MaCT")), _
                                                                          CStr(rs_chungtuItem("sops")))))
                                If mts = 0 Then
                                    mts = ConvertToDblSafe(GetSelectValue(String.Format("SELECT max(MaTS) AS F1 FROM CTcongcudungcu WHERE MaTS>0 AND MaCTKT={1} AND (ABS(NG_NS+NG_TBS+NG_TD+NG_CNK)={2} OR ABS(CL_NS+CL_TBS+CL_TD+CL_CNK)={2})", _
                                                                              mts, _
                                                                              ConvertToStrSafe(rs_chungtuItem("MaCT")), _
                                                                              CStr(rs_chungtuItem("sops")))))
                                End If
                                If mts > 0 Then
                                    sh = MaSo2SoHieu(mts, "Congcudungcu")
                                    DienGiai = TenTS("", mts)
                                End If
                            End If
                            If (taikhoan.sohieu Like "1422*" Or taikhoan.sohieu Like "1423*") And (loaict = 1 Or loaict = 0) Then sh = Timten("sohieu", rs_chungtuItem("MaVattu"), "maso", "doituongct")
                            If DienGiai.Length = 0 Then DienGiai = IIf(pNN = 0, taikhoan.ten, taikhoan.TenE)
                            If taikhoan.tk_id <> GTGTKT_ID And taikhoan.tk_id <> GTGTPN_ID And taikhoan.tk_id <> TKCNKH_ID And taikhoan.tk_id <> TKCNPT_ID And taikhoan.tk_id <> TKDT_ID And taikhoan.tk_id <> TSCD_ID Then
                                With GrdChungtu
                                    For i As Integer = 0 To .Rows - 1
                                        .Row = i
                                        .Col = 8
                                        If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit For
                                        If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = taikhoan.maso Then
                                            .Col = 17
                                            mk = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                            .Col = 21
                                            mtp = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                            .Col = 9
                                            mvt = IIf((tp.MaSo = mtp And taikhoan.tk_id = TKVT_ID) Or taikhoan.sohieu Like "1422*" Or taikhoan.sohieu Like "1423*", ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text), 0)
                                            .Col = 4
                                            luong = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                            If tp.MaSo = mtp And vattu.MaSo = mvt And ckh.MaSo = mk And (ConvertToDblSafe(rs_chungtuItem("SoPS2No")) = 0 Or luong = 0) Then
                                                .Items(.Row).SubItems(.Col).Text = Format(ConvertToStrSafe(rs_chungtuItem("SoPS2No")) + luong, Mask_2)
                                                'Them don gia
                                                soluongno = ConvertToStrSafe(rs_chungtuItem("SoPS2No")) + luong
                                                .Col = 6
                                                .Items(.Row).SubItems(.Col).Text = Format(ConvertToStrSafe(rs_chungtuItem("sops")) + ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text), Mask_0)
                                                phatsinhno = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                                .Col = 5
                                                If soluongno <> 0 Then .Items(.Row).SubItems(.Col).Text = Format(phatsinhno / (IIf(soluongno <> 0, soluongno, 1)), Mask_2)
                                                GoTo kt1
                                            End If
                                        End If
                                    Next
                                End With
                            End If
                            psnt = IIf((loaict = 1 Or loaict = 2 Or loaict = 7 Or loaict = 8) And vattu.MaSo > 0 And ConvertToDblSafe(rs_chungtuItem("dvt")) > 0, QuyDoiTheoDVT2(vattu.MaSo, rs_chungtuItem("dvt"), rs_chungtuItem("SoPS2No")), rs_chungtuItem("SoPS2No"))
                            luong = IIf(taikhoan.tk_id = TKVT_ID Or taikhoan.tk_id = TKDT_ID Or taikhoan.MaNT > 0 Or ckh.MaNT > 0, psnt, 0)
                            dgia = IIf(luong <> 0, (IIf(0.5 + Mask_N * ConvertToStrSafe(rs_chungtuItem("sops")) / luong > 0, Math.Floor(0.5 + Mask_N * ConvertToStrSafe(rs_chungtuItem("sops")) / luong), Math.Ceiling(0.5 + Mask_N * ConvertToStrSafe(rs_chungtuItem("sops")) / luong))) / Mask_N, 0)
                            If (loaict = 1 Or loaict = 2 Or loaict = 8) And pGiaUSD > 0 And pRate > 0 And ConvertToDblSafe(rs_chungtuItem("MaVattu")) > 0 Then
                                ps = rs_chungtuItem("PSUSD")
                            Else
                                ps = 0
                            End If

                            GrdChungtu.AddItem(String.Format("{0}{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{0}{7}{0}{8}{0}{9}{0}{10}{0}{11}{0}{0}{0}{0}{0}{12}{0}{13}{0}{0}{14}{0}{15}{0}{16}{0}{17}{0}{18}{0}{19}{0}{20}", _
                                                    grdColSeperete, _
                                                    taikhoan.sohieu, _
                                                    DienGiai, _
                                                    sh, _
                                                    (IIf(luong <> 0, Format(luong, Mask_2), "")), _
                                                    (IIf(dgia <> 0, Format(dgia, Mask_2), "")), _
                                                    Format(rs_chungtuItem("sops"), Mask_0), _
                                                    ConvertToStrSafe(taikhoan.maso), _
                                                    ConvertToStrSafe(rs_chungtuItem("MaVattu")), _
                                                    (IIf(taikhoan.loai > 0, "0", "1")), _
                                                    (taikhoan.MaTC), _
                                                    (Math.Abs(rs_chungtuItem("CT_ID"))), _
                                                    (rs_chungtuItem("makh")), _
                                                    (ms), _
                                                    (rs_chungtuItem("MaKHC")), _
                                                    (rs_chungtuItem("MaTP")), _
                                                    Format(rs_chungtuItem("SoXuat"), Mask_2), _
                                                    (rs_chungtuItem("dvt")), _
                                                    Format(ps, Mask_2), _
                                                    If(loaict = 1, Format(rs_chungtuItem("TLCK"), Mask_2), ""), _
                                                    If(loaict = 1, Format(rs_chungtuItem("CK"), Mask_0), "")), 0)
kt1:
                        End If
                    End If
                End If
                If ConvertToStrSafe(rs_chungtuItem("MaTkCo")) <> 0 Then
                    taikhoan.InitTaikhoanMaSo(rs_chungtuItem("MaTkCo"))
                    If (taikhoan.tk_id = GTGTPN_ID Or taikhoan.tk_id = TTDB_ID) Or (taikhoan.tk_id = GTGTKT_ID And ConvertToDblSafe(rs_chungtuItem("sops")) = 0) Then
                        hdcount += 1
                        ReDim Preserve hd(hdcount)
                        With hd(hdcount)
                            If rs_chungtuItem("MaSo").ToString <> "" Then
                                .MaSo = rs_chungtuItem("MaSo")
                            End If

                            If Not Convert.IsDBNull(rs_chungtuItem("MaKhachHang")) Then
                                If rs_chungtuItem("MaKhachHang").ToString <> "" Then
                                    .MaKhachHang = rs_chungtuItem("MaKhachHang")
                                End If
                                If rs_chungtuItem("LoaiHD").ToString <> "" Then
                                    .loai = rs_chungtuItem("LoaiHD")
                                End If
                                If rs_chungtuItem("KyHieu").ToString <> "" Then
                                    .KyHieu = rs_chungtuItem("KyHieu")
                                Else
                                    .KyHieu = Nothing
                                End If

                                .sohd = rs_chungtuItem("shd")
                                .NgayPH = IIf(Not Convert.IsDBNull(rs_chungtuItem("NgayPH")), rs_chungtuItem("NgayPH"), rs_chungtuItem("NgayGS"))
                                .MatHang = rs_chungtuItem("MatHang")
                                If rs_chungtuItem("soluong").ToString <> "" Then
                                    .soluong = rs_chungtuItem("soluong")
                                End If
                                If rs_chungtuItem("ThanhTien").ToString <> "" Then
                                    .ThanhTien = rs_chungtuItem("ThanhTien")
                                End If
                                If rs_chungtuItem("TyLe").ToString <> "" Then
                                    .TyLe = rs_chungtuItem("TyLe")
                                End If
                                If rs_chungtuItem("hd").ToString <> "" Then
                                    .HD = rs_chungtuItem("hd")
                                End If
                                If rs_chungtuItem("KCT").ToString <> "" Then
                                    .KCT = rs_chungtuItem("KCT")
                                End If
                                If rs_chungtuItem("HTTT").ToString <> "" Then
                                    .HTTT = rs_chungtuItem("HTTT")
                                End If
                                If rs_chungtuItem("MauSo").ToString <> "" Then
                                    .MauSo = rs_chungtuItem("MauSo")
                                End If
                                If rs_chungtuItem("HDBL").ToString <> "" Then
                                    .HDBL = rs_chungtuItem("HDBL")
                                End If
                                If rs_chungtuItem("NLTS").ToString <> "" Then
                                    .NLTS = rs_chungtuItem("NLTS")
                                End If
                                If rs_chungtuItem("dn").ToString <> "" Then
                                    .dn = rs_chungtuItem("dn")
                                End If
                                If rs_chungtuItem("NK").ToString <> "" Then
                                    .NK = rs_chungtuItem("NK")
                                End If
                                If rs_chungtuItem("ts").ToString <> "" Then
                                    .ts = rs_chungtuItem("ts")
                                End If
                                If rs_chungtuItem("DC").ToString <> "" Then
                                    .DC = rs_chungtuItem("DC")
                                End If
                                If rs_chungtuItem("tg").ToString <> "" Then
                                    .tygia = rs_chungtuItem("tg")
                                End If
                                If rs_chungtuItem("sohopdong").ToString <> "" Then
                                    .sohopdong = rs_chungtuItem("sohopdong")
                                End If

                                If rs_chungtuItem("Ngayhopdong").ToString <> "" Then
                                    .Ngayhopdong = rs_chungtuItem("Ngayhopdong")
                                End If

                                If rs_chungtuItem("diadiemgiaohang").ToString <> "" Then
                                    .diadiemgiaohang = rs_chungtuItem("diadiemgiaohang")
                                End If

                                If rs_chungtuItem("diadiemnhanhang").ToString <> "" Then
                                    .diadiemnhanhang = rs_chungtuItem("diadiemnhanhang")
                                End If

                                If rs_chungtuItem("sovandon").ToString <> "" Then
                                    .sovandon = rs_chungtuItem("sovandon")
                                End If

                                If rs_chungtuItem("socontainer").ToString <> "" Then
                                    .socontainer = rs_chungtuItem("socontainer")
                                End If

                                If rs_chungtuItem("tenvanchuyen").ToString <> "" Then
                                    .tenvanchuyen = rs_chungtuItem("tenvanchuyen")
                                End If
                                If rs_chungtuItem("Den").ToString <> "" Then
                                    .Den = rs_chungtuItem("Den")
                                End If
                                If rs_chungtuItem("tim").ToString <> "" Then
                                    .tim = rs_chungtuItem("tim")
                                End If
                                If rs_chungtuItem("hong").ToString <> "" Then
                                    .hong = rs_chungtuItem("hong")
                                End If
                                If rs_chungtuItem("xanh").ToString <> "" Then
                                    .xanh = rs_chungtuItem("xanh")
                                End If
                                If rs_chungtuItem("xanhnoidia").ToString <> "" Then
                                    .xanhnoidia = rs_chungtuItem("xanhnoidia")
                                End If

                            End If
                            TL = .TyLe
                            If Not KHDetail Then
                                If Not Convert.IsDBNull(rs_chungtuItem("ten")) Then .TenKH = rs_chungtuItem("ten")
                                If Not Convert.IsDBNull(rs_chungtuItem("DiaChi")) Then .DiaChiKH = rs_chungtuItem("DiaChi")
                                If Not Convert.IsDBNull(rs_chungtuItem("MST")) Then .MSTKH = rs_chungtuItem("MST")
                            End If
                            If .MaKhachHang <> 0 Then
                                ckh.InitKhachHangMaSo(.MaKhachHang)
                                TenBH = ckh.Ten
                                DiaChiBH = ckh.DiaChi
                                MSTBH = ckh.mst
                                MaKHBH = ckh.MaSo
                                ckh.InitKhachHangMaSo(0)
                            End If
                        End With
                        If rs_chungtuItem("MaKhachHang").ToString <> "" Then
                            ms = IIf(Not Convert.IsDBNull(rs_chungtuItem("MaKhachHang")), hdcount, -1)
                        End If

                    Else
                        TL = 0
                        ms = -1
                    End If
                    If ConvertToStrSafe(rs_chungtuItem("sops")) <> 0 Or taikhoan.tk_id = TKDT_ID Or taikhoan.tk_id = GTGTKT_ID Or taikhoan.tk_id = GTGTPN_ID Or taikhoan.tk_id = TTDB_ID Or taikhoan.tk_id = TKVT_ID Or ((taikhoan.tk_id = TKCNKH_ID Or taikhoan.tk_id = TKCNPT_ID) And ConvertToDblSafe(rs_chungtuItem("MaKHC")) > 0) Then
                        If Not CmdPhieu(0).Visible Then CmdPhieu(0).Visible = (taikhoan.sohieu.ToString() Like TM + "*")
                        If Not CmdPhieu(1).Visible Then
                            CmdPhieu(1).Visible = (taikhoan.tk_id = TKVT_ID Or taikhoan.tk_id = TKDT_ID Or taikhoan.tk_id = TSCD_ID)
                            CmdPhieu(1).Enabled = (GetSelectValue("select VT as f1 from users where maso=" + CStr(UserID)) Mod 10000000000) \ 1000000000 = 1
                        End If
                        If Not CmdPhieu(2).Visible Then CmdPhieu(2).Visible = (taikhoan.sohieu.ToString() Like NH + "*" Or taikhoan.tk_id2 = ConvertToDblSafe(NH))
                        CmdPhieu(2).Tag = taikhoan.sohieu
                        If Not CmdPhieu(3).Visible Then CmdPhieu(3).Visible = (taikhoan.sohieu.ToString Like NH + "*")
                        If (loaict = 8 And taikhoan.tk_id = 5000 And rs_chungtuItem("SoPS2Co") = 0) Or ((taikhoan.tk_id <> TKVT_ID And taikhoan.tk_id <> TKDT_ID) Or (Not STDetail)) And (taikhoan.tk_id <> TKDT_ID) And (taikhoan.tk_id <> GTGTPN_ID) And (taikhoan.tk_id <> TTDB_ID) And (ConvertToDblSafe(rs_chungtuItem("MaTP")) = 0 Or taikhoan.tk_id = TKCNKH_ID Or taikhoan.tk_id = TKCNPT_ID Or taikhoan.sohieu Like "111*") Then ' And taikhoan.TK_ID <> TKCNKH_ID And taikhoan.TK_ID <> TKCNPT_ID
                            ThemDong = Not PSDaCo(taikhoan, 1, rs_chungtuItem("sops"), rs_chungtuItem("SoPS2Co"), rs_chungtuItem("MaKHC"))
                        Else
                            ThemDong = True
                        End If
                        If ThemDong Then
                            sodong += 1
                            If (taikhoan.tk_id = TKVT_ID Or taikhoan.tk_id = TKDT_ID) And (ConvertToDblSafe(rs_chungtuItem("MaVattu")) > 0) Then
                                If rs_chungtuItem("MaVattu").ToString <> "" Then
                                    vattu.InitVattuMaSo(rs_chungtuItem("MaVattu"))
                                End If

                                sh = vattu.sohieu
                                DienGiai = vattu.TenVattu & (IIf((loaict = 1 Or loaict = 2 Or loaict = 8) And KtraDVT(vattu.MaSo, rs_chungtuItem("dvt"), st), " - " & ("Đ.v.t: ") & st, ""))
                            Else
                                vattu.InitVattuMaSo(0)
                                If (taikhoan.tk_id = TKCNKH_ID Or taikhoan.tk_id = TKCNPT_ID) And (ConvertToDblSafe(rs_chungtuItem("MaKHC")) > 0) Then
                                    If rs_chungtuItem("MaKHC").ToString <> "" Then
                                        ckh.InitKhachHangMaSo(rs_chungtuItem("MaKHC"))
                                    End If

                                    sh = ckh.SoHieu
                                    DienGiai = ckh.Ten
                                Else
                                    ckh.InitKhachHangMaSo(0)
                                    sh = IIf(taikhoan.MaNT > 0, SoHieuNT(taikhoan.MaNT), (IIf(TL > 0, ConvertToStrSafe(TL), "")))
                                    DienGiai = IIf(pNN = 0, taikhoan.ten, taikhoan.TenE)
                                End If
                            End If
                            If rs_chungtuItem("MaTP").ToString <> "" Then
                                If ConvertToStrSafe(rs_chungtuItem("MaTP")) <> 0 And (taikhoan.tk_id <> TKVT_ID) And ckh.MaSo = 0 And (taikhoan.tk_id2 = TKDT_ID Or taikhoan.loai = 6 Or taikhoan.sohieu Like "154*") Then

                                    tp.InitTPMaSo(rs_chungtuItem("MaTP"))


                                    sh = tp.SoHieu
                                    DienGiai = tp.TenVattu
                                End If
                            End If

                            If (loaict = 10 Or loaict = 11) And taikhoan.tk_id = TSCD_ID Then
                                mts = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaTS AS F1 FROM CTTaiSan WHERE MaTS>0 AND MaTS<>{0} AND MaCTKT={1} AND ABS(CL_NS+CL_TBS+CL_TD+CL_CNK)={2}", _
                                                                          mts, _
                                                                          ConvertToStrSafe(rs_chungtuItem("MaCT")), _
                                                                          CStr(rs_chungtuItem("sops")))))
                                If mts > 0 Then
                                    sh = MaSo2SoHieu(mts, "TaiSan")
                                    DienGiai = TenTS("", mts)
                                End If
                            End If
                            If DienGiai.Length = 0 Then DienGiai = IIf(pNN = 0, taikhoan.ten, taikhoan.TenE)
                            If taikhoan.tk_id <> GTGTKT_ID And taikhoan.tk_id <> GTGTPN_ID And taikhoan.tk_id <> TKCNKH_ID And taikhoan.tk_id <> TKCNPT_ID And taikhoan.tk_id <> TKVT_ID And taikhoan.tk_id <> TKDT_ID Then '  And (taikhoan.tk_id <> TKDT_ID Or rs_chungtu!sops <> 0)
                                With GrdChungtu
                                    For i As Integer = 0 To .Rows - 1
                                        .Row = i
                                        .Col = 8
                                        If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit For
                                        If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = taikhoan.maso Then
                                            .Col = 20
                                            mk = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                            .Col = 21
                                            mtp = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                            .Col = 9
                                            mvt = IIf((tp.MaSo = mtp And taikhoan.tk_id = TKVT_ID) Or (taikhoan.tk_id = TKDT_ID And ConvertToStrSafe(rs_chungtuItem("sops")) <> 0), ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text), 0)
                                            If tp.MaSo = mtp And vattu.MaSo = mvt And ckh.MaSo = mk Then
                                                .Col = 7
                                                ps = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                                If ps <> 0 Then
                                                    .Items(.Row).SubItems(.Col).Text = Format(ConvertToDblSafe(rs_chungtuItem("sops")) + ps, Mask_0)
                                                    .Col = 4
                                                    .Items(.Row).SubItems(.Col).Text = Format(ConvertToDblSafe(rs_chungtuItem("SoPS2Co")) + ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text), Mask_0)
                                                    GoTo KT2
                                                End If
                                            End If
                                        End If
                                    Next
                                End With
                            End If
                            psnt = IIf((loaict = 1 Or loaict = 2 Or loaict = 7 Or loaict = 8) And vattu.MaSo > 0 And ConvertToDblSafe(rs_chungtuItem("dvt")) > 0, QuyDoiTheoDVT2(vattu.MaSo, rs_chungtuItem("dvt"), rs_chungtuItem("SoPS2Co")), rs_chungtuItem("SoPS2Co"))
                            luong = IIf(taikhoan.tk_id = TKVT_ID Or taikhoan.tk_id = TKDT_ID Or taikhoan.MaNT > 0 Or ckh.MaNT > 0, psnt, 0)
                            dgia = IIf(luong <> 0, (IIf(0.5 + Mask_N * ConvertToStrSafe(rs_chungtuItem("sops")) / luong > 0, Math.Floor(0.5 + Mask_N * ConvertToStrSafe(rs_chungtuItem("sops")) / luong), Math.Ceiling(0.5 + Mask_N * ConvertToStrSafe(rs_chungtuItem("sops")) / luong))) / Mask_N, 0)
                            If (loaict = 1 Or loaict = 2 Or loaict = 8) And pGiaUSD > 0 And pRate > 0 And ConvertToDblSafe(rs_chungtuItem("MaVattu")) > 0 Then
                                If rs_chungtuItem("PSUSD").ToString <> "" Then
                                    ps = rs_chungtuItem("PSUSD")
                                End If

                            Else
                                ps = 0
                            End If
                            If loaict <> 13 Or ConvertToStrSafe(rs_chungtuItem("sops")) <> 0 Or luong <> 0 Then
                                GrdChungtu.AddItem(String.Format("{0}{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}{0}{11}{0}{0}{0}{0}{0}{12}{0}{13}{0}{0}{14}{0}{15}{0}{16}{0}{17}{0}{18}{0}{19}{0}{20}", _
                                                  grdColSeperete, _
                                                  taikhoan.sohieu, _
                                                  DienGiai, _
                                                  sh, _
                                                  (IIf(luong <> 0, Format(luong, Mask_2), "")), _
                                                  (IIf(dgia <> 0, Format(dgia, Mask_2), "")), _
                                                  Format(rs_chungtuItem("sops"), Mask_0), _
                                                  (taikhoan.maso), _
                                                  (rs_chungtuItem("MaVattu")), _
                                                  (IIf(taikhoan.loai > 0, "0", "1")), _
                                                  ConvertToStrSafe(taikhoan.MaTC), _
                                                  (Math.Abs(rs_chungtuItem("CT_ID"))), _
                                                  (rs_chungtuItem("makh")), _
                                                  (ms), _
                                                  (rs_chungtuItem("MaKHC")), _
                                                  (rs_chungtuItem("MaTP")), _
                                                  Format(rs_chungtuItem("SoXuat"), Mask_2), _
                                                  (rs_chungtuItem("dvt")), _
                                                  Format(ps, Mask_2), _
                                                  If(loaict <> 1, Format(rs_chungtuItem("TLCK"), Mask_2), ""), _
                                                  If(loaict <> 1, Format(rs_chungtuItem("CK"), Mask_0), "")), 0)

                            End If
KT2:
                        End If
                    End If
                End If
                vattu.InitVattuMaSo(0)
                ckh.InitKhachHangMaSo(0)
                tp.InitTPMaSo(0)
                'rs_chungtu.MoveNext()
            Loop

            dem = 0
            GrdChungtu.Rows = IIf(sodong >= ConvertToDblSafe((GrdChungtu.Tag)), ConvertToDblSafe(sodong + 1), ConvertToDblSafe(ConvertToDblSafe((GrdChungtu.Tag))))
            MaSoCT = ma
            If loaict = 2 Or loaict = 8 Then
                xddu = SetDoiUng(1)
                If Not xddu Then xddu = SetDoiUng()
            Else
                xddu = SetDoiUng()
                If Not xddu Then xddu = SetDoiUng(1)
            End If
            GrdChungtu.Row = 0
            Khoaquyen(uid)
            NhapDongMoi("")
            txt(0).Focus()
KetThuc:
            ''rs_chungtu.Close()
            rs_chungtu = Nothing
            Kiemtrachiphi()
            kiemtrachktudong()
            Setcaptionhienphieu()
        End If
        Return result
    End Function

    Sub Setcaptionhienphieu()
        If CboNguon(2).SelectedIndex > 0 Then
            Text = "Sửa đổi nội dung - Hoá đơn hàng nhập khẩu"
        Else
            Text = String.Format("Sửa đổi nội dung - {0}", Setcaption())
        End If
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub kiemtrachktudong()
        If CboNguon(2).SelectedIndex > 0 Then
            ChkTudong.Visible = False : ChkHNT.Visible = False
        End If
        Dim dong, cot As Integer
        Dim co1, co, co2 As Boolean
        With GrdChungtu
            dong = .Row : cot = .Col
            .Row = 0 : .Col = 1
            If .Rows > 0 Then
                Try
                    While .Items(.Row).SubItems(.Col).Text <> "" And .Row < .Rows - 1
                        If Strings.Left(.Items(.Row).SubItems(.Col).Text, 3) = "331" Then co = True
                        If Strings.Left(.Items(.Row).SubItems(.Col).Text, 3) = "131" Then co1 = True
                        If Strings.Left(.Items(.Row).SubItems(.Col).Text, 3) = "142" Or Strings.Left(.Items(.Row).SubItems(.Col).Text, 3) = "242" Or Strings.Left(.Items(.Row).SubItems(.Col).Text, 3) = "1543" Then co2 = True
                        .Row = (.Row + 1)
                    End While
                Catch
                End Try
            End If
            .Row = dong : .Col = cot
            loai1.Tag = "0" : loaino.Tag = "0"
            If co And Not co2 Then
                loai1.Tag = "1" : loaino.Tag = "1"
            Else
                If co1 Then
                    loai1.Tag = "1" : loaino.Tag = "0"
                End If
            End If
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="uid"></param>
    ''' <remarks></remarks>
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(1).Enabled = ChoNhapTiep() And (User_Right = 0 Or (UserID = uid))
        Command(2).Enabled = (User_Right = 0 Or (UserID = uid))
        Command(5).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        CmdPhieu(0).Enabled = True
        CmdPhieu(1).Enabled = True
        CmdPhieu(2).Enabled = True
        CmdPhieu(3).Enabled = True
        CmdBC.Enabled = True
        If User_Right <> 0 Then
            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT Lock{0} % 10 AS F1 FROM License", CboThang.SelectedValue))) > 0 _
                Or GetSelectValue("select [Status] as f1 from hoadon inner join chungtu on hoadon.maso=chungtu.maso where mact = " & CStr(MaSoCT)) Then
                Command(1).Enabled = False
                Command(2).Enabled = False
                Command(5).Enabled = False
                CmdPhieu(0).Enabled = False
                CmdPhieu(1).Enabled = False
                CmdPhieu(2).Enabled = False
                CmdPhieu(3).Enabled = False
                CmdBC.Enabled = False
            End If
        End If
    End Sub
    ''' <summary>
    ''' Nhập dòng phát sinh mới
    ''' </summary>
    ''' <param name="shtk"></param>
    ''' <remarks></remarks>
    Private Sub NhapDongMoi(ByRef shtk As String)
        If pCongNoHD > 0 And ((taikhoan.tk_id = TKCNKH_ID And ConvertToDblSafe(txtchungtu(5).Text) > 0) Or (taikhoan.tk_id = TKCNPT_ID And ConvertToDblSafe(txtchungtu(6).Text) > 0)) Then
            txtchungtu(8).Focus()
        Else
            txtchungtu(0).Focus()
        End If
        CboNT(0).Visible = False
        txtchungtu(0).Tag = ConvertToStrSafe(0)
        txtchungtu(0).Text = shtk
        txtchungtu(1).Text = ""
        txtchungtu(2).Text = ""
        txtchungtu(3).Text = "0"
        txtchungtu(3).Tag = ConvertToStrSafe(0)
        txtchungtu(5).Tag = ConvertToStrSafe(0)
        txtchungtu(6).Tag = ConvertToStrSafe(0)
        txtchungtu(9).Text = ""
        txtchungtu(10).Text = ""
        taikhoan.InitTaikhoanMaSo(0)
        vattu.InitVattuMaSo(0)
        ckh.InitKhachHangMaSo(0)
        tp.InitTPMaSo(0)
        If loaict = 1 And STDetail Then txtchungtu(6).Text = "0"
        Dim ps As Double = SoPSConLai()
        If ps < 0 Then
            txtchungtu(5).Text = Format(-ps, Mask_0)
            txtchungtu(6).Text = "0"
        Else
            txtchungtu(6).Text = Format(ps, Mask_0)
            txtchungtu(5).Text = "0"
        End If
        MaNhap = 0
        txtchungtu(4).Enabled = False
        CboNT(1).Visible = False
        CboNT(2).Visible = False
        Label(25).Visible = False
        txtchungtu(11).Visible = False
        CboNT(3).Visible = False
    End Sub
    ''' <summary>
    ''' Hàm trả về số phát sinh chênh lệch tính theo số PS nợ
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoPSConLai() As Double
        Dim ps As Double
        Dim tong As Double = 0
        With GrdChungtu
            For i As Integer = 0 To .Rows - 1
                .Row = i
                .Col = 1
                If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit For
                .Col = 10
                If .Items(.Row).SubItems(.Col).Text = "0" Then
                    ps = ConvertToDblSafe(.Items(.Row).SubItems(6).Text)
                    tong += ps
                    ps = ConvertToDblSafe(.Items(.Row).SubItems(7).Text)
                    tong -= ps
                End If
            Next
        End With
        Return tong
    End Function
    ''' <summary>
    ''' Hàm trả kiểm tra dữ liệu nhập
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function KiemTraChungtu() As Boolean
        Dim result As Boolean = False
        Dim sodu, sodu2 As Double
        Dim st As String = String.Empty
        If txt(0).Text.Length = 0 Or txt(0).Text = "..." Then
            txt(0).Text = "..." : MessageBox.Show(Ngonngu("Chưa nhập số hoá đơn!", "No enter invoice number!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt(0).Focus()
            Return result
        End If
        If (loaict = 1 Or loaict = 2 Or loaict = 8) And (CboNguon(0).SelectedIndex < 0 Or CboNguon(1).SelectedIndex < 0) Then
            ErrMsg(er_NguonNX)
            CboNguon(0).Focus()
            Return result
        End If
        GrdChungtu.Row = 0
        GrdChungtu.Col = 1
        If GrdChungtu.Items(GrdChungtu.Row).SubItems(GrdChungtu.Col).Text.Length = 0 Then
            txtchungtu(0).Focus()
            Return result
        End If
        If pHachToan <> 0 And (IIf(SoPSConLai() * Mask_N > 0, Math.Floor(SoPSConLai() * Mask_N), Math.Ceiling(SoPSConLai() * Mask_N))) <> 0 And ((loaict <> 8 And loaict <> 7) Or Chk.CheckState = CheckState.Unchecked) Then
            If Not PSTuDong(SoPSConLai()) Then
                MessageBox.Show(Ngonngu("Số phát sinh nợ có chưa cân bằng !", "Sum in debt, credit is no balance"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtchungtu(0).Focus()
                Return result
            End If
        End If
        If loaict = 3 And nhieunoco Then
            MessageBox.Show(Ngonngu("Không nhập chứng từ kết chuyển nhiều nợ, nhiều có !", "Not enter voucher transferred many debt, many credit !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtchungtu(0).Focus()
            Return result
        End If
        If loaict = 8 And (Not (CoPSTK("5", 0) Or CoPSTK("33", 0))) Then
            MessageBox.Show(Ngonngu("Chứng từ bán hàng không có tài khoản doanh thu !", "Sales vouchers without income accounts !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return result
        End If
        If loaict = 3 And (Not (CoPSTK("9") Or CoPSTK("8") Or CoPSTK("7") Or CoPSTK("6") Or CoPSTK("5") Or CoPSTK("142") Or CoPSTK("421") Or CoPSTK(pVATV))) Then
            MessageBox.Show(Ngonngu("Chỉ nhập chứng từ kết chuyển trong phân loại chứng từ này!", "Enter only the transfer voucher in this category!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return result
        End If
        If User_Right <> 0 Then
            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT Lock{0} % 10 AS F1 FROM License", CboThang.SelectedValue))) > 0 Then
                MessageBox.Show(Ngonngu("Tháng đã bị khoá không cho nhập số liệu!", "This month is closed, do not enter!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return result
            End If
        End If
        If ConvertToDblSafe(GetSelectValue("SELECT TOP 1 MaCT AS F1 FROM ChungTu WHERE MaLoai=3 AND CT_ID>300000000 AND CT_ID<310000000 AND ThangCT=" & CboThang.SelectedIndex)) > 0 Then
            st = ConvertToStrSafe(CThangDB2(CboThang.SelectedIndex))
            sodu = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(CASE WHEN Loai=1 OR Loai=2 THEN DuNo_{0}-DuCo_{0} ELSE 0 END) AS F1,Sum(CASE WHEN Loai=3 OR Loai=4 THEN DuNo_{0}-DuCo_{0} ELSE 0 END) AS F2 FROM HethongTK WHERE Cap=0", st), sodu2))
            If sodu = sodu2 Then
                If MessageBox.Show(Ngonngu("Tháng đã kết chuyển, cho nhập chứng từ?", "This month forward, continue to enter voucher?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.No Then Return result
            End If
        End If
        If chkXT.CheckState = CheckState.Checked Then
            If ConvertToDblSafe((txtsh(0).Tag)) = 0 Then
                txtsh(0).Focus()
                Return result
            End If
            If ConvertToDblSafe((cmd(0).Tag)) = 1 And ConvertToDblSafe((txtsh(1).Tag)) = 0 Then
                txtsh(1).Focus()
                Return result
            End If
        End If
        Return True
    End Function
    ''' <summary>
    ''' Thu tuc xac dinh TK Tai chinh doi ung
    ''' </summary>
    ''' <param name="dr"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function SetDoiUng(Optional ByRef dr As Integer = 0) As Boolean
        Dim j, sodong As Integer
        Dim sodon As Double
        Dim chuyenvt, chuyen As Boolean
        Dim i As Integer
        Dim X As Double
        Dim TK = String.Empty, Tk1 As String = String.Empty
        Dim id As Integer
        Dim kq As Boolean = False
        Dim sono As Integer = 0
        Dim soco As Integer = 0
        Dim sonox As Integer = 0
        Dim socox As Integer = 0
        ' Nhận các dòng phát sinh
        Dim shtk As String = String.Empty
        Dim TkCo As New StringBuilder
        Dim tkno As New StringBuilder
        Dim mtcno As Integer
        With GrdChungtu
            Dim mtk(.Rows - 1) As Integer, mtktc(.Rows - 1) As Integer
            Dim loaips(.Rows - 1) As Integer
            Dim mvt(.Rows - 1) As Integer
            Dim sops(.Rows - 1) As Double, sopsvt(.Rows - 1) As Double, SoPS2(.Rows - 1) As Double
            Dim nb(.Rows - 1) As Integer
            Dim mkh(.Rows - 1) As Integer, mkhc(.Rows - 1) As Integer, mhd(.Rows - 1) As Integer, mtp(.Rows - 1) As Integer, dvt(.Rows - 1) As Integer, cid(.Rows - 1) As Integer
            Dim CK1(.Rows - 1) As Double, ck2(.Rows - 1) As Double
            sodong = -1
            For i = 0 To .Rows - 1
                .Row = i
                .Col = 8
                If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit For
                sodong += 1
                mtk(i) = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Items(.Row).SubItems(0).Text = ConvertToStrSafe(i + 1)
                .Col = 1
                TK = .Items(.Row).SubItems(.Col).Text
                .Col = 11
                mtktc(i) = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 12
                cid(i) = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                If cuongccdc.Length <> 0 Then
                    mvt(i) = ConvertToDblSafe(Timten("maso", cuongccdc, "sohieu", "vattu"))
                Else
                    .Col = 9
                    mvt(i) = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                End If
                .Col = 24
                SoPS2(i) = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 25
                If (loaict <> 8 And loaict <> 1) Or mvt(i) = 0 Then .Items(.Row).SubItems(.Col).Text = ""
                CK1(i) = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 26
                If ((loaict <> 8 And loaict <> 1) Or mvt(i) = 0) And TK <> "3331" Then .Items(.Row).SubItems(.Col).Text = ""
                ck2(i) = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 17
                mkh(i) = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 20
                mkhc(i) = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                If TK Like "6*" Or TK Like "154*" Or TK Like "51*" Or TK Like "91*" Then
                    .Col = 21
                    mtp(i) = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                Else
                    .Col = 21
                    .Items(.Row).SubItems(.Col).Text = ""
                End If
                .Col = 3
                If mvt(i) > 0 And .Items(.Row).SubItems(.Col).Text.Length > 0 Then
                    If ConvertToDblSafe(GetSelectValue(String.Format("SELECT DVTVattu.MaSo as f1 FROM DVTVattu INNER JOIN Vattu ON DVTVattu.MaVattu=Vattu.MaSo WHERE Vattu.SoHieu=N'{0}'", .Items(.Row).SubItems(.Col).Text))) > 0 Then
                        .Col = 23
                        dvt(i) = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                    End If
                End If
                If TK.Substring(0, pVATV.Length) = pVATV Or TK Like "3331*" Or TK Like "3332*" Then
                    .Col = 18
                    mhd(i) = ConvertToDblSafe((.Items(.Row).SubItems(.Col).Text))
                Else
                    mhd(i) = -1
                End If
                .Col = 4
                sopsvt(i) = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 6
                sops(i) = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 7
                X = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 10
                nb(i) = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                If sops(i) <> 0 Or (sops(i) = 0 And X = 0 And (TK.Substring(0, pVATV.Length) = pVATV Or ((TK Like "15*") Or (TK Like "33312*")) And loaict = 1)) Then
a:
                    loaips(i) = -1
                    sonox += 1
                    If (nb(i) = 0) And (Not MaDaCo(mtktc(i), -1, mtktc, loaips, sodong - 1)) Then sono += 1
                Else
                    .Col = 7
                    sops(i) = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                    If sops(i) = 0 And (TK.Substring(0, pVATV.Length) = pVATV Or (TK Like "15*") And loaict = 1) Then GoTo a
                    loaips(i) = 1
                    socox += 1
                    If (nb(i) = 0) And (Not MaDaCo(mtktc(i), 1, mtktc, loaips, sodong - 1)) Then soco += 1
                End If
                For j = 13 To 16
                    .Col = ConvertToDblSafe(j)
                    .Items(.Row).SubItems(.Col).Text = ""
                Next
            Next
            GoTo DEF
            ' Xác định đối ứng
            If sono > 1 And soco > 1 Then
abc:
                tkno = New StringBuilder("")
                TkCo = New StringBuilder("")
                nhieunoco = True
                For i = 0 To sodong
                    If nb(i) = 0 And loaips(i) = -1 Then
                        shtk = MaSo2SoHieu(mtktc(i), "HethongTK")
                        If (tkno.ToString().IndexOf(shtk) + 1) = 0 Then tkno.Append(String.Format("{0},", shtk))
                    End If
                    If nb(i) = 0 And loaips(i) = 1 Then
                        shtk = MaSo2SoHieu(mtktc(i), "HethongTK")
                        If (TkCo.ToString().IndexOf(shtk) + 1) = 0 Then TkCo.Append(String.Format("{0},", shtk))
                    End If
                Next
                .Col = 14
                For i = 0 To sodong
                    .Row = i
                    If nb(i) = 0 Then
                        .Items(.Row).SubItems(.Col).Text = IIf(loaips(i) = -1, TkCo.ToString(), tkno.ToString())
                    End If
                Next
            Else
DEF:
                nhieunoco = False
                If sono = 0 Or soco = 0 Then GoTo kt
                If sonox > 1 And socox > 1 Then
                    i = IIf(dr = 0, 0, sodong)
                    Do While IIf(dr = 0, i <= sodong, i >= 0)
                        If nb(i) = 0 Then
                            .Row = i
                            .Col = 1
                            TK = .Items(.Row).SubItems(.Col).Text
                            .Col = 14
                            If .Items(.Row).SubItems(.Col).Text.Length = 0 Then
                                sodon = 0
                                chuyen = mvt(i) <> 0 Or sopsvt(i) <> 0
                                chuyenvt = True
                                j = IIf(dr = 0, 0, sodong)
                                Do While IIf(dr = 0, j <= sodong, j >= 0)
                                    .Row = ConvertToDblSafe(j)
                                    If nb(j) = 0 And (loaips(j) <> loaips(i) Or sops(j) = 0) And sops(j) <= sops(i) - sodon And .Items(.Row).SubItems(.Col).Text.Length = 0 Then
                                        If chuyen Then
                                            .Col = 16
                                            If chuyenvt Then
                                                .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(sopsvt(i))
                                                .Col = 24
                                                .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(SoPS2(i))
                                            End If
                                            If mvt(i) = 0 Then
                                                chuyen = False
                                            Else
                                                chuyenvt = False
                                            End If
                                            .Col = 15
                                            .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(mvt(i))
                                            If dvt(i) > 0 Then
                                                .Col = 23
                                                .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(dvt(i))
                                            End If
                                        End If
                                        .Col = 17
                                        If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = 0 And mkh(i) > 0 Then
                                            .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(mkh(i))
                                        Else
                                            If mkh(i) > 0 And mkh(i) <> ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) Then GoTo abc
                                        End If
                                        .Col = 12
                                        If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = 0 Then .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(cid(i))
                                        .Col = 25
                                        If loaict = 8 And mvt(i) > 0 And ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = 0 Then
                                            .Items(.Row).SubItems(.Col).Text = Format(CK1(i), Mask_2)
                                            .Col = 26
                                            .Items(.Row).SubItems(.Col).Text = Format(ck2(i), Mask_0)
                                        End If
                                        .Col = 20 ' KH
                                        If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = 0 And mkhc(i) > 0 Then
                                            .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(mkhc(i))
                                        Else
                                            If mkhc(i) > 0 And mkhc(i) <> ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) Then GoTo abc
                                        End If
                                        .Col = 1
                                        Tk1 = .Items(.Row).SubItems(.Col).Text
                                        .Col = 18
                                        If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) < 0 And mhd(i) >= 0 And (TK.Substring(0, pVATV.Length) = pVATV Or TK Like "3331*" Or TK Like "3332*" Or Strings.Left(Tk1, 3) = pVATV Or Tk1 Like "3331*" Or Tk1 Like "3332*") Then
                                            .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(mhd(i))
                                        Else
                                            If mhd(i) >= 0 And mhd(i) <> ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) And ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) >= 0 Then GoTo abc
                                        End If
                                        .Col = 13
                                        .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(mtk(i))
                                        If mtp(i) > 0 Then
                                            .Col = 21
                                            If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = 0 Then .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(mtp(i))
                                        End If
                                        .Col = 14
                                        .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(mtktc(i))
                                        sodon += sops(j)
                                        If j > 0 Then
                                            If sodon >= sops(i) And sops(j - 1) <> 0 Then Exit Do
                                        Else
                                            If sodon >= sops(i) Then Exit Do
                                        End If
                                    End If
                                    j += (IIf(dr = 0, 1, -1))
                                Loop
                                If sodon < sops(i) And sodon <> 0 Then GoTo abc
                            End If
                        End If
                        i += (IIf(dr = 0, 1, -1))
                    Loop
                Else
                    If sonox = 1 Then
                        i = IIf(dr = 0, 0, sodong)
                        Do While IIf(dr = 0, i <= sodong, i >= 0)
                            .Row = i
                            .Col = 1
                            TK = .Items(.Row).SubItems(.Col).Text
                            .Col = 14
                            If nb(i) = 0 And loaips(i) < 0 Then
                                mtcno = mtktc(i)
                                .Items(.Row).SubItems(.Col).Text = ""
                                chuyen = mvt(i) <> 0 Or sopsvt(i) <> 0
                                chuyenvt = True
                                j = IIf(dr = 0, 0, sodong)
                                Do While IIf(dr = 0, j <= sodong, j >= 0)
                                    .Row = ConvertToDblSafe(j)
                                    If nb(j) = 0 And loaips(j) > 0 Then
                                        If chuyen And (sops(j) <> 0) Then
                                            .Col = 16
                                            If chuyenvt Then
                                                .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(sopsvt(i))
                                                .Col = 24
                                                .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(SoPS2(i))
                                            End If
                                            If mvt(i) = 0 Then
                                                chuyen = False
                                            Else
                                                chuyenvt = False
                                            End If
                                            .Col = 15
                                            .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(mvt(i))
                                            If dvt(i) > 0 Then
                                                .Col = 23
                                                .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(dvt(i))
                                            End If
                                        End If
                                        .Col = 13
                                        .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(mtk(i))
                                        .Col = 14
                                        .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(mtcno)
                                        .Col = 17
                                        If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = 0 And mkh(i) > 0 Then
A2:
                                            .Col = 17
                                            .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(mkh(i))
                                        Else
                                            If mkh(i) > 0 And mkh(i) <> ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) Then
                                                .Col = 1
                                                id = GetTK_ID(.Items(.Row).SubItems(.Col).Text, 0)
                                                If id <> TKCNKH_ID And id <> TKCNPT_ID Then GoTo A2
                                                GoTo abc
                                            End If
                                        End If
                                        .Col = 12
                                        If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = 0 Then .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(cid(i))
                                        .Col = 25
                                        If loaict = 8 And mvt(i) > 0 And ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = 0 Then
                                            .Items(.Row).SubItems(.Col).Text = Format(CK1(i), Mask_2)
                                            .Col = 26
                                            .Items(.Row).SubItems(.Col).Text = Format(ck2(i), Mask_0)
                                        End If
                                        .Col = 20
                                        If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = 0 And mkhc(i) > 0 Then
                                            .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(mkhc(i))
                                        Else
                                            If mkhc(i) > 0 And mkhc(i) <> ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) Then GoTo abc
                                        End If
                                        If mtp(i) > 0 Then
                                            .Col = 21
                                            If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = 0 Then .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(mtp(i))
                                        End If
                                        .Col = 1
                                        Tk1 = .Items(.Row).SubItems(.Col).Text
                                        .Col = 18
                                        If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) < 0 And mhd(i) >= 0 And (TK.Substring(0, pVATV.Length) = pVATV Or TK Like "3331*" Or TK Like "3332*" Or Strings.Left(Tk1, pVATV.Length) = pVATV Or Tk1 Like "3331*" Or Tk1 Like "3332*") Then ' And (Left(TK, len(PVATV)) = PVATV Or Left(TK, 4) = "3331")
                                            .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(mhd(i))
                                        Else
                                            If mhd(i) >= 0 And mhd(i) <> ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) And ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) >= 0 Then GoTo abc
                                        End If
                                    End If
                                    j += (IIf(dr = 0, 1, -1))
                                Loop
                                Exit Do
                            End If
                            i += (IIf(dr = 0, 1, -1))
                        Loop
                    Else
                        i = IIf(dr = 0, 0, sodong)
                        Do While IIf(dr = 0, i <= sodong, i >= 0)
                            .Row = i
                            .Col = 1
                            TK = .Items(.Row).SubItems(.Col).Text
                            .Col = 14
                            If nb(i) = 0 And loaips(i) > 0 Then
                                mtcno = mtktc(i)
                                .Items(.Row).SubItems(.Col).Text = ""
                                chuyen = mvt(i) <> 0 Or sopsvt(i) <> 0
                                j = IIf(dr = 0, 0, sodong)
                                Do While IIf(dr = 0, j <= sodong, j >= 0)
                                    .Row = ConvertToDblSafe(j)
                                    If nb(j) = 0 And loaips(j) < 0 Then
                                        If chuyen And (sops(j) <> 0) Then
                                            .Col = 16
                                            .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(sopsvt(i))
                                            .Col = 24
                                            .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(SoPS2(i))
                                            chuyen = False
                                        End If
                                        .Col = 15
                                        .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(mvt(i))
                                        If dvt(i) > 0 Then
                                            .Col = 23
                                            .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(dvt(i))
                                        End If
                                        .Col = 13
                                        .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(mtk(i))
                                        .Col = 14
                                        .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(mtcno)
                                        If mtp(i) > 0 Then
                                            .Col = 21
                                            If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = 0 Then .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(mtp(i))
                                        End If
                                        .Col = 17
                                        If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = 0 And mkh(i) > 0 Then
A1:
                                            .Col = 17
                                            .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(mkh(i))
                                        Else
                                            If mkh(i) > 0 And mkh(i) <> ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) Then
                                                .Col = 1
                                                id = GetTK_ID(.Items(.Row).SubItems(.Col).Text, 0)
                                                If id <> TKCNKH_ID And id <> TKCNPT_ID Then GoTo A1
                                                GoTo abc
                                            End If
                                        End If
                                        .Col = 12
                                        If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = 0 Then .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(cid(i))
                                        .Col = 25
                                        If loaict = 8 And mvt(i) > 0 And ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = 0 Then
                                            .Items(.Row).SubItems(.Col).Text = Format(CK1(i), Mask_2)
                                            .Col = 26
                                            .Items(.Row).SubItems(.Col).Text = Format(ck2(i), Mask_0)
                                        End If
                                        .Col = 20
                                        If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = 0 And mkhc(i) > 0 Then
                                            .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(mkhc(i))
                                        Else
                                            If mkhc(i) > 0 And mkhc(i) <> ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) Then GoTo abc
                                        End If
                                        .Col = 1
                                        TK = .Items(.Row).SubItems(.Col).Text
                                        .Col = 18
                                        If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) < 0 And mhd(i) >= 0 And (TK.Substring(0, pVATV.Length) = pVATV Or TK Like "3331*" Or TK Like "3332*" Or Strings.Left(Tk1, pVATV.Length) = pVATV Or Tk1 Like "3331*" Or Tk1 Like "3332*") Then
                                            .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(mhd(i))
                                        Else
                                            If mhd(i) >= 0 And mhd(i) <> ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) And ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) >= 0 Then GoTo abc
                                        End If
                                    End If
                                    j += (IIf(dr = 0, 1, -1))
                                Loop
                                Exit Do
                            End If
                            i += (IIf(dr = 0, 1, -1))
                        Loop
                    End If
                End If
                kq = True
            End If
kt:
            Erase mtk
            Erase mtktc
            Erase loaips
            Erase mvt
            Erase sopsvt
            Erase nb
            Erase sops
            Erase SoPS2
            Erase mkh
            Erase mkhc
            Erase mhd
            Erase mtp
            Erase dvt
            Erase cid
            Erase CK1
            Erase ck2
        End With
        Return kq
    End Function
    ''' <summary>
    ''' Hàm kiểm tra mã số đã có trong cột của Grid
    ''' </summary>
    ''' <param name="MaSo"></param>
    ''' <param name="ps"></param>
    ''' <param name="BangMa"></param>
    ''' <param name="loaips"></param>
    ''' <param name="sodong"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function MaDaCo(ByRef MaSo As Integer, ByRef ps As Integer, ByRef BangMa() As Integer, ByRef loaips() As Integer, ByRef sodong As Integer) As Boolean
        For i As Integer = 0 To sodong
            If BangMa(i) = MaSo And ps = loaips(i) Then
                Return True
            End If
        Next
        Return False
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub hienctts()
        KhongNhapTS = False
        For i As Integer = 0 To parSoPS
            If arPhatSinh(i).PS_SoLg <> 0 Then
                If arPhatSinh(i).TK_SoHieu = "211" Or arPhatSinh(i).TK_SoHieu = "213" Then
                    txtchungtu(0).Text = arPhatSinh(i).TS_SoHieu.ToString.Substring(0, 4)
                Else
                    txtchungtu(0).Text = arPhatSinh(i).TK_SoHieu
                End If
                _txtchungtu_LostFocus(txtchungtu(0), New EventArgs())
                If arPhatSinh(i).TS_SoHieu IsNot Nothing Then
                    If arPhatSinh(i).TS_SoHieu.Length > 0 Then
                        txtchungtu(2).Text = arPhatSinh(i).TS_SoHieu
                        txtchungtu(1).Text = TenTS(arPhatSinh(i).TS_SoHieu, 0)
                    End If
                End If

                If cuongccdc.Length > 0 And OptLoai(13).Checked Then
                    txtchungtu(2).Text = cuongccdc
                    txtchungtu(1).Text = Timten("tenvattu", cuongccdc, "sohieu", "vattu")
                    txtchungtu(3).Text = ConvertToStrSafe(cuongccdcsoluong)
                End If
                If arPhatSinh(i).ShTP IsNot Nothing Then
                    If pDTTP <> 0 And arPhatSinh(i).ShTP.Length > 0 Then
                        txtchungtu(2).Text = arPhatSinh(i).ShTP
                        _txtchungtu_LostFocus(txtchungtu(2), New EventArgs())
                    End If
                End If

                If arPhatSinh(i).PS_Loai = -1 Then
                    txtchungtu(5).Text = Format(arPhatSinh(i).PS_SoLg, Mask_0)
                    If cuongccdc.Length > 0 And ConvertToDblSafe(txtchungtu(3).Text) > 0 Then
                        txtchungtu(4).Text = IIf(ConvertToDblSafe(txtchungtu(3).Text) = 0, ConvertToStrSafe(0), Format(ConvertToDblSafe(txtchungtu(5).Text) / ConvertToDblSafe(txtchungtu(3).Text), Mask_0))
                    End If
                    txtchungtu(6).Text = "0"
                Else
                    txtchungtu(6).Text = Format(arPhatSinh(i).PS_SoLg, Mask_0)
                    txtchungtu(5).Text = "0"
                End If
                CmdChitiet_Click(CmdChitiet, New EventArgs())
            End If
        Next
        KhongNhapTS = True
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="MaCTKT"></param>
    ''' <remarks></remarks>
    Private Sub GhiChungtuTS(ByRef MaCTKT As Integer)
        Dim sql As String = String.Empty
        Select Case pNghiepVu
            Case NV_TANG
                For i As Integer = 0 To tscount
                    TinhGiaTriTaiSan(MaTS(i), pThangTacDong, KH_KHONG)
                    sql = String.Format("INSERT INTO CTTaiSan (MaSo, SoHieu, Thang, VaoSo, NgayGhi, DienGiai, MaLoai, MaNhom, MaTS, NG_NS, NG_TBS, NG_CNK, NG_TD, CL_NS, CL_TBS, CL_CNK, CL_TD, MaCTKT{0}) VALUES ({1}, N'{2}',{3}, N'{4}', N'{5}', N'{6}',{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18}{19})", _
                              (IIf(pSongNgu And Strings.Len(txt(2).Text) > 0, ",DienGiaiE", String.Empty)), _
                              ConvertToStrSafe(Lng_MaxValue("MaSo", "CTTaiSan") + 1), _
                              txt(0).Text, _
                              ConvertToStrSafe(CboThang.SelectedValue), _
                             Format(Ngay(0), Mask_DB), _
                             Format(Ngay(1), Mask_DB), _
                              txt(1).Text, _
                              ConvertToStrSafe(OptLoai(loaict).Tag), _
                              ConvertToStrSafe(CboNT(0).SelectedValue), _
                              ConvertToStrSafe(MaTS(i)), _
                              doidau(GiaTri.NG_NS), _
                              doidau(GiaTri.NG_TBS), _
                              doidau(GiaTri.NG_CNK), _
                              doidau(GiaTri.NG_TD), _
                              doidau(GiaTri.CL_NS), _
                              doidau(GiaTri.CL_TBS), _
                              doidau(GiaTri.CL_CNK), _
                              doidau(GiaTri.CL_TD), _
                              ConvertToStrSafe(MaCTKT), _
                              (IIf(pSongNgu And Strings.Len(txt(2).Text) > 0, String.Format(", N'{0}'", txt(2).Text), String.Empty)))
                    ExecSQLNonQuery(sql)
                    sql = String.Format("UPDATE TaiSan SET SHCT=N'{0}',NCT=N'{1}' WHERE MaSo={2}", _
                              txt(0).Text, _
                             Format(Ngay(0), Mask_DB), _
                              ConvertToStrSafe(MaTS(i)))
                    ExecSQLNonQuery(sql)
                Next
            Case NV_GIAM
                TacDongGiamTaiSan(pMaTaiSan, CboThang.SelectedIndex, TD_GIAM)
            Case NV_DGLAI
            Case NV_TKHAO
                XoaChungTuKhauHao(txt(0).Text, _
                    ConvertToDblSafe(Me.Tag), _
                    CboThang.SelectedIndex, _
                    CboNT(0).SelectedIndex, _
                    MaCTKT, _
                    ConvertToStrSafe(CboNguon(0).Tag))
        End Select
        If pNghiepVu > 0 And pNghiepVu <> NV_TANG Then
            sql = String.Format("INSERT INTO CTTaiSan (MaSo, SoHieu, Thang, VaoSo, NgayGhi, DienGiai, MaLoai, MaNhom, MaTS, NG_NS, NG_TBS, NG_CNK, NG_TD, CL_NS, CL_TBS, CL_CNK, CL_TD, MaCTKT{0})VALUES ({1}, N'{2}',{3}, N'{4}', N'{5}', N'{6}',{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18}{19})", _
                      (IIf(pSongNgu And Strings.Len(txt(2).Text) > 0, ",DienGiaiE", String.Empty)), _
                      ConvertToStrSafe(Lng_MaxValue("MaSo", "CTTaiSan") + 1), _
                      txt(0).Text, _
                      ConvertToStrSafe(CboThang.SelectedValue), _
                     Format(Ngay(0), Mask_DB), _
                     Format(Ngay(1), Mask_DB), _
                      txt(1).Text, _
                      ConvertToStrSafe(OptLoai(loaict).Tag), _
                      ConvertToStrSafe(CboNT(0).SelectedValue), _
                      ConvertToStrSafe(pMaTaiSan), _
                      CStr(GiaTri.NG_NS), _
                      CStr(GiaTri.NG_TBS), _
                      CStr(GiaTri.NG_CNK), _
                      CStr(GiaTri.NG_TD), _
                      CStr(GiaTri.CL_NS), _
                      CStr(GiaTri.CL_TBS), _
                      CStr(GiaTri.CL_CNK), _
                      CStr(GiaTri.CL_TD), _
                      ConvertToStrSafe(MaCTKT), _
                      (IIf(pSongNgu And Strings.Len(txt(2).Text) > 0, String.Format(", N'{0}'", txt(2).Text), String.Empty)))
            ExecSQLNonQuery(sql)
            If pNghiepVu = NV_DGLAI Then DieuChinhKH(pMaTaiSan, CboThang.SelectedValue)
        End If
        pGhichungtu = 0
        pMaTaiSan = 0
        tscount = -1
        '    _OptLoai_0.Value = True
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="MaCTKT"></param>
    ''' <remarks></remarks>
    Private Sub SuaChungtuTS(ByRef MaCTKT As Integer)
        Dim sql As String = String.Format("UPDATE CTTaiSan SET SoHieu =N'{0}', Thang = {1}, VaoSo =N'{2}', NgayGhi =N'{3}', DienGiai =N'{4}', MaLoai = {5}, MaNhom = {6}{7} WHERE CTTaiSan.MaCTKT = {8}", _
                                txt(0).Text, _
                                ConvertToStrSafe(CboThang.SelectedValue), _
                               Format(Ngay(0), Mask_DB), _
                               Format(Ngay(1), Mask_DB), _
                                txt(1).Text, _
                                ConvertToStrSafe(OptLoai(loaict).Tag), _
                                ConvertToStrSafe(CboNT(0).SelectedValue), _
                                (IIf(pSongNgu, String.Format(",DienGiaiE=N'{0}'", txt(2).Text), String.Empty)), _
                                ConvertToStrSafe(MaCTKT))
        ExecSQLNonQuery(sql)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="MaCTKT"></param>
    ''' <remarks></remarks>
    Private Sub SuaChungtuCCDC(ByRef MaCTKT As Integer)
        Dim sql As String = String.Format("UPDATE CTCongcudungcu SET SoHieu =N'{0}',Thang = {1}, VaoSo =N'{2}', NgayGhi =N'{3}', DienGiai =N'{4}', MaLoai = {5}{6} WHERE CTCongcudungcu.MaCTKT = {7}", _
                                txt(0).Text, _
                                ConvertToStrSafe(CboThang.SelectedValue), _
                               Format(Ngay(0), Mask_DB), _
                               Format(Ngay(1), Mask_DB), _
                                txt(1).Text, _
                                ConvertToStrSafe(OptLoai(loaict).Tag), _
                                (IIf(pSongNgu, String.Format(",DienGiaiE=N'{0}'", txt(2).Text), String.Empty)), _
                                ConvertToStrSafe(MaCTKT))
        ExecSQLNonQuery(sql)
    End Sub
    ''' <summary>
    ''' Ham tra ve dong va loai ps cua tai khoan trong grid chung tu
    ''' </summary>
    ''' <param name="taikhoan"></param>
    ''' <param name="loaips"></param>
    ''' <param name="sops"></param>
    ''' <param name="sopsnt"></param>
    ''' <param name="mkh"></param>
    ''' <param name="mvt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function PSDaCo(ByRef taikhoan As ClsTaikhoan, ByRef loaips As Integer, ByRef sops As Double, ByRef sopsnt As Double, ByRef mkh As Integer, Optional ByRef mvt As Integer = 0, Optional ByRef mts As Integer = 0, Optional ByVal mact As Integer = 0) As Boolean
        Dim result As Boolean = False
        Dim ps, tien As Double
        'If (loaips = 1 And taikhoan.sohieu Like "131*") Or (loaips = -1 And taikhoan.sohieu Like "331*") Then Return result
        With GrdChungtu
            For i As Integer = 0 To .Rows - 1
                .Col = 8
                .Row = i
                If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit For
                If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = taikhoan.maso Then
                    If mkh > 0 Then
                        .Col = IIf(loaips = -1, 17, 20)
                        If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) <> mkh Then GoTo a
                        .Col = IIf(loaips = -1, 6, 7)
                        If ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) = 0 Then GoTo a
                    End If
                    .Col = 3
                    If Not (taikhoan.sohieu Like "1422*" Or taikhoan.sohieu Like "1423*") Then ' Or .Items(.Row).SubItems(.Col).Text = Timten("sohieu", ConvertToStrSafe(mvt), "maso", "doituongct") Then
                        .Col = IIf(loaips = -1, 6, 7)
                        ps = sops + ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Items(.Row).SubItems(.Col).Text = Format(ps, Mask_0)
                        If taikhoan.MaNT > 0 Or KHMaNT(mkh) > 0 Then ' Or KHMaNT(mkh) > 0
                            .Col = 4
                            ps = sopsnt
                            ps += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                            .Items(.Row).SubItems(.Col).Text = IIf(ps <> 0, Format(ps, Mask_2), "")
                            If ps <> 0 Then
                                .Col = 6
                                tien = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                If tien = 0 Then
                                    .Col = 7
                                    tien = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                End If
                                .Col = 5
                                .Items(.Row).SubItems(.Col).Text = Format(tien / ps, Mask_2)
                            End If
                        End If
                        .Col = 3
                        If taikhoan.tk_id = 2000 And .Text = "" Then
                            .Col = IIf(loaips = -1, 6, 7)
                            mts = GetSelectValue("SELECT max(MaTS) AS F1 FROM CTTaiSan WHERE MaTS>0 AND MaTS<" + CStr(mts) + " AND MaCTKT=" + CStr(mact) + " AND (ABS(NG_NS+NG_TBS+NG_TD+NG_CNK)=" + CStr(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)) + " OR ABS(CL_NS+CL_TBS+CL_TD+CL_CNK)=" + CStr(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)) + ")")
                            If mts = 0 Then mts = GetSelectValue("SELECT max(MaTS) AS F1 FROM CTTaiSan WHERE MaTS>0 AND MaCTKT=" + CStr(mact) + " AND (ABS(NG_NS+NG_TBS+NG_TD+NG_CNK)=" + CStr(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)) + " OR ABS(CL_NS+CL_TBS+CL_TD+CL_CNK)=" + CStr(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)) + ")")
                            If mts > 0 Then
                                .Col = 3
                                .Items(.Row).SubItems(.Col).Text = MaSo2SoHieu(mts, "TaiSan")
                                .Col = 2
                                .Items(.Row).SubItems(.Col).Text = TenTS("", mts)
                            End If
                        End If
                        result = True
                    End If
                End If
a:
            Next
        End With
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub mndd_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mndd_0.Click, _mndd_1.Click, _mndd_2.Click, _mndd_3.Click, _mndd_4.Click, _mndd_5.Click, _mndd_6.Click, _mndd_7.Click, _mndd_8.Click, _mndd_9.Click, _mndd_10.Click, _mndd_11.Click, _mndd_12.Click, _mndd_13.Click, _mndd_14.Click, _mndd_15.Click, _mndd_16.Click, _mndd_17.Click, _mndd_18.Click, _mndd_19.Click, _mndd_20.Click, _mndd_21.Click, _mndd_22.Click, _mndd_23.Click, _mndd_24.Click
        Dim Index As Integer = Array.IndexOf(mndd, eventSender)
        Select Case Index
            Case 0 ' PLVT
                frmMain.mnVT_Click(frmMain.mnVT, New EventArgs())
            Case 1 ' PLTS
                frmMain.mnts_Click(frmMain.mnts, New EventArgs())
            Case 2 ' PLTS
                If KHDetail Then
                    frmMain.mnCN_Click(frmMain.mnCN, New EventArgs())
                End If
            Case 4 ' DDTK
                FrmTaikhoan.Tag = "1"
                FrmTaikhoan.ShowDialog()
            Case 5 ' DDVT
                If STDetail Then
                    FrmVattu.ShowDialog()
                End If
            Case 6 ' DDTS
                If KHDetail Then
                    pNghiepVu = NV_KHONG
                    frmDSTaiSan.ShowDialog()
                End If
            Case 7 ' DDTS
                If FADetail Then
                    FrmKhachHang.ShowDialog()
                End If
            Case 8
                FrmKho.Tag = "6"
                FrmKho.ShowDialog()
            Case 9
                'Load FrmKho
                FrmKho.Tag = "5"
                FrmKho.ShowDialog()
                Int_RecsetToCbo("SELECT DoituongCT.MaSo As F2,(DienGiai+ CASE WHEN DoituongCT.MaKhachHang>0 THEN ' - HĐ: '+DoituongCT.SoHieu+' - Ký ngày: '+ CONVERT(NVARCHAR, NgayKy, 103) ELSE '' END) As F1 FROM DoituongCT LEFT JOIN KhachHang ON DoituongCT.MaKhachHang=KhachHang.MaSo ORDER BY DienGiai", CboNguon(2))
            Case 10 ' SDCT
                FrmHD.ShowDialog()
                Int_RecsetToCbo("SELECT DoituongCT.MaSo As F2,(DienGiai+ CASE WHEN DoituongCT.MaKhachHang>0 THEN ' - HĐ: '+DoituongCT.SoHieu+' - Ký ngày: '+ CONVERT(NVARCHAR, NgayKy, 103) ELSE '' END) As F1 FROM DoituongCT LEFT JOIN KhachHang ON DoituongCT.MaKhachHang=KhachHang.MaSo ORDER BY DienGiai", CboNguon(2))
            Case 12 ' BCCT
                If User_Right = 3 Then Exit Sub
                FrmMNBaocao.ShowDialog()
            Case 13
                If pRpt = CheckState.Checked And User_Right = 1 Then
                    ErrMsg(er_KoSD)
                    Exit Sub
                End If
                FrmSochiphi.ShowDialog()
            Case 14
                If pRpt = CheckState.Checked And User_Right = 1 Then
                    ErrMsg(er_KoSD)
                    Exit Sub
                End If
                FrmSovattuhanghoa.ShowDialog()
            Case 15
                If pRpt = CheckState.Checked And User_Right = 1 Then
                    ErrMsg(er_KoSD)
                    Exit Sub
                End If
                FrmSoCongNo.ShowDialog()
            Case 18
                CmdDanhSach_ClickEvent(CmdDanhSach(0), New EventArgs())
            Case 19 ' BCTH
                FrmDU.ShowDialog()
                FrmDU = Nothing
            Case 20
                InDSCtu()
            Case 21
                InNhatKy1()
            Case 23
                frmPhanLoaiVT.pl1 = "4"
                frmPhanLoaiVT.ShowDialog()
                frmPhanLoaiVT.pl1 = "0"
            Case 24
                FrmNhanVien.ShowDialog()
        End Select
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub KiemtraUser()
        Dim frmMainTag As Integer = ConvertToDblSafe(frmMain.Tag)
        If User_Right <> 0 And frmMainTag Mod 100000000 < 11111111 Then
            _mndd_13.Enabled = False
            _mndd_15.Enabled = False
        End If

        _mndd_12.Enabled = (frmMainTag Mod 1000000000 >= 100000000 And User_Right <> 1)
        _mndd_17.Enabled = (frmMainTag Mod 1000000000 >= 100000000 And User_Right <> 1)
        _mndd_18.Enabled = (frmMainTag Mod 1000000000 >= 100000000 And User_Right <> 1)
        _mndd_0.Enabled = frmMainTag Mod 100000000 >= 10000000 Or frmMainTag Mod 100 >= 10
        _mndd_1.Enabled = frmMainTag Mod 100000000 >= 10000000 Or frmMainTag Mod 100000 >= 10000
        _mndd_5.Enabled = frmMainTag Mod 100000000 >= 10000000 Or frmMainTag Mod 100 >= 10
        _mndd_6.Enabled = frmMainTag Mod 100000000 >= 10000000 Or frmMainTag Mod 100000 >= 10000
        _mndd_2.Enabled = frmMainTag Mod 10000 >= 1000
        _mndd_7.Enabled = frmMainTag Mod 10000 >= 1000
        '_OptLoai_3.Enabled = frmMainTag Mod 100000000 >= 10000000
        '_OptLoai_1.Enabled = frmMainTag Mod 100000000 >= 10000000
        '_OptLoai_2.Enabled = frmMainTag Mod 100000000 >= 10000000
        '_OptLoai_9.Enabled = frmMainTag Mod 100000 >= 10000
        '_OptLoai_10.Enabled = frmMainTag Mod 100000 >= 10000
        '_OptLoai_11.Enabled = frmMainTag Mod 100000 >= 10000
        '_OptLoai_12.Enabled = frmMainTag Mod 100000 >= 10000
        '_OptLoai_13.Enabled = frmMainTag Mod 1000000 >= 100000
        '_OptLoai_14.Enabled = frmMainTag Mod 1000000 >= 100000
        '_OptLoai_8.Enabled = frmMainTag Mod 100000000 >= 10000000
        OptLoai(3).Enabled = (frmMain.Tag Mod 10 >= 1)

        OptLoai(0).Enabled = (frmMain.Tag Mod 1000 >= 100) Or (frmMain.Tag Mod 10000 >= 1000) Or (frmMain.Tag Mod 10000000 >= 1000000)

        OptLoai(1).Enabled = (frmMain.Tag Mod 100 >= 10) Or (frmMain.Tag Mod 100000000 >= 10000000)
        OptLoai(2).Enabled = (frmMain.Tag Mod 100 >= 10) Or (frmMain.Tag Mod 100000000 >= 10000000)
        OptLoai(8).Enabled = (frmMain.Tag Mod 100 >= 10)

        OptLoai(9).Enabled = (frmMain.Tag Mod 100000 >= 10000)
        OptLoai(10).Enabled = (frmMain.Tag Mod 100000 >= 10000)
        OptLoai(11).Enabled = (frmMain.Tag Mod 100000 >= 10000)
        OptLoai(12).Enabled = (frmMain.Tag Mod 100000 >= 10000)

        OptLoai(13).Enabled = (frmMain.Tag Mod 1000000 >= 100000)
        OptLoai(14).Enabled = (frmMain.Tag Mod 1000000 >= 100000)
#If DEBUG Then
        ' Only in develpope enviroment
        _mndd_12.Enabled = True
        _mndd_17.Enabled = True
        _mndd_18.Enabled = True
        _mndd_0.Enabled = True
        _mndd_1.Enabled = True
        _mndd_5.Enabled = True
        _mndd_6.Enabled = True
        _mndd_2.Enabled = True
        _mndd_7.Enabled = True
        _OptLoai_3.Enabled = True
        _OptLoai_1.Enabled = True
        _OptLoai_2.Enabled = True
        _OptLoai_9.Enabled = True
        _OptLoai_10.Enabled = True
        _OptLoai_11.Enabled = True
        _OptLoai_12.Enabled = True
        _OptLoai_13.Enabled = True
        _OptLoai_14.Enabled = True
        _OptLoai_8.Enabled = True
#End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ps"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function PSTuDong(ByRef ps As Double) As Boolean
        Dim result As Boolean = False
        If ps > 0 Then
            txtchungtu(5).Text = "0"
            txtchungtu(6).Text = Format(ps, Mask_0)
        Else
            txtchungtu(6).Text = "0"
            txtchungtu(5).Text = Format(-ps, Mask_0)
        End If
        Dim sql As String = String.Format("SELECT SHTK As F1 FROM SHChungTu WHERE SoHieu=N'{0}'", Strings.Left(txt(0).Text, SHCT_Len))
        Dim sh As String = ConvertToStrSafe(GetSelectValue(sql))
        If sh.Length < 3 Then Return result
        txtchungtu(0).Text = sh
        _txtchungtu_LostFocus(txtchungtu(0), New EventArgs())
        CmdChitiet_Click(CmdChitiet, New EventArgs())
        Return SoPSConLai() = 0
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InDSCtu()
        Dim d1, d2 As Date
        If Not GetDate2.GetDate("Danh sách chứng từ theo ngày", d1, d2) Then Exit Sub
        Dim sql As String = String.Format("SELECT ChungTu.MaCT AS M, ChungTu.ThangCT AS T, ChungTu.SoHieu AS SH, ChungTu.NgayCT AS NCT, ChungTu.NgayGS AS NGS, ChungTu.DienGiai AS DG, HeThongTK.SoHieu AS TKNo,HethongTK.Ten AS TNo, HeThongTK_1.SoHieu AS TKCo,HethongTK_1.Ten AS TCo, ChungTu.SoPS AS PS FROM (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo) LEFT JOIN HeThongTK AS HeThongTK_1 ON ChungTu.MaTKCo = HeThongTK_1.MaSo WHERE {0}", WNgay("NgayGS", d1, d2))
        rptFrom.InitForm("CHUNGTU2.RPT", sql, "QNhatky")

        RptSetDate(d2)
        InBaoCaoRPT()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InNhatKy1()
        Dim d1, d2 As Date
        If Not GetDate2.GetDate("Sổ nhật ký theo ngày", d1, d2) Then Exit Sub
        If InNhatKy(0, 0, 0, 1, d1, d2, 0, pPhieu) Then InBaoCaoRPT()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LoaiPhieuThuChi(ByRef sh As String) As Integer
        Dim result As Integer = 0
        With GrdChungtu
            For i As Integer = 0 To .Rows - 1
                .Col = 1
                .Row = i
                If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Return result
                If .Items(.Row).SubItems(.Col).Text Like sh & "*" Then
                    .Col = 6
                    If result > -1 Then result = IIf(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) > 0, -1, 1)
                End If
            Next
        End With
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GiaTriTruocThue() As Double
        Dim tien As Double
        With GrdChungtu
            tien = 0
            If taikhoan.tk_id = GTGTKT_ID Then
                For i As Integer = 0 To .Rows - 1
                    .Row = i
                    .Col = 1
                    If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit For
                    If Strings.Left(.Items(.Row).SubItems(.Col).Text, pVATV.Length) = pVATV Then Exit For
                    .Col = 6
                    tien += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                Next
            End If
            If taikhoan.tk_id = GTGTPN_ID Or taikhoan.tk_id = TTDB_ID Or taikhoan.sohieu Like "521*" Then
                For i As Integer = 0 To .Rows - 1
                    .Row = i
                    .Col = 1
                    If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit For
                    If Strings.Left(.Items(.Row).SubItems(.Col).Text, 4) = "3331" And taikhoan.tk_id = GTGTPN_ID Then Exit For
                    If Strings.Left(.Items(.Row).SubItems(.Col).Text, 2) <> "11" And Strings.Left(.Items(.Row).SubItems(.Col).Text, 4) <> "3331" Then
                        .Col = IIf((taikhoan.tk_id = TTDB_ID And loaict = 1) Or .Items(.Row).SubItems(.Col).Text Like "521*", 6, 7)
                        tien += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) * IIf(.Items(.Row).SubItems(1).Text Like "521*", -1, 1)
                    End If
                Next
            End If
        End With
        Return tien
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="loaips"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LayMaKH(ByRef loaips As Integer) As Integer
        Dim result As Integer = 0
        With GrdChungtu
            For i As Integer = 0 To .Rows - 1
                .Row = i
                .Col = 1
                If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Return result
                .Col = IIf(loaips < 0, 17, 20)
                result = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                If result > 0 Then Return result
            Next
        End With
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CTGiamGia() As Boolean
        Return CoPSTK("521") Or CoPSTK("531") Or CoPSTK("532")
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="loai"></param>
    ''' <remarks></remarks>
    Private Sub InTC(ByRef loai As Integer)
        Dim d1, d2 As Date
        If Not GetDate2.GetDate(String.Format("In từng phiếu {0} theo ngày", (IIf(loai = 0, "thu", "chi"))), d1, d2) Then Exit Sub
        Dim sql As String = String.Format("SELECT MaCT,NgayGS FROM HeThongTK INNER JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTK{0}o WHERE {1} AND HethongTK.SoHieu LIKE '1111%' GROUP BY manhapxuat,MaCT,NgayGS", _
                                (IIf(loai = 0, "N", "C")), _
                                WNgay("NgayGS", d1, d2))
        rptFrom.ReportDestination = 0
        P_1 = 1
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        For Each rsItem As DataRow In rs.Rows
            MaSoCT = ConvertToDblSafe(rsItem("MaCT"))
            HienPhieuTrenManHinh(0)
            CmdPhieu_ClickEvent(CmdPhieu(0), New EventArgs())
        Next
        Command_ClickEvent(Command(0), New EventArgs())
        rptFrom.ReportDestination = 1
        P_1 = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="loai"></param>
    ''' <remarks></remarks>
    Private Sub InNX(ByRef loai As Integer)
        Dim d1, d2 As Date
        If Not GetDate2.GetDate(String.Format("In từng phiếu {0} theo ngày", (IIf(loai = 1, "nhập", "xuất"))), d1, d2) Then Exit Sub
        Dim sql As String = String.Format("SELECT MaCT FROM ChungTu WHERE MaLoai={0} AND {1} AND MaVattu>0 GROUP BY manhapxuat,MaCT", loai, WNgay("NgayGS", d1, d2))
        rptFrom.ReportDestination = 0
        P_1 = 1
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        For Each rsItem As DataRow In rs.Rows
            MaSoCT = ConvertToDblSafe(rsItem("MaCT"))
            HienPhieuTrenManHinh(0)
            CmdPhieu_ClickEvent(CmdPhieu(1), New EventArgs())
        Next
        Command_ClickEvent(Command(0), New EventArgs())
        rptFrom.ReportDestination = 1
        P_1 = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InNNS()
        Dim d1, d2 As Date
        If Not GetDate2.GetDate("In từng phiếu nhập nông sản theo ngày", d1, d2) Then Exit Sub
        Dim sql As String = String.Format("SELECT ct.MaCT FROM ChungTu ct inner join HoaDon hd on ct.sohieu=hd.sohd WHERE ct.MaLoai=1 AND hd.nlts=1 AND {0} AND MaVattu>0 GROUP BY ct.MaCT", WNgay("ct.NgayGS", d1, d2))
        rptFrom.ReportDestination = 0
        P_1 = 1
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        For Each rsItem As DataRow In rs.Rows
            MaSoCT = ConvertToDblSafe(rsItem("MaCT"))
            HienPhieuTrenManHinh(0)
            CmdPhieu_ClickEvent(CmdPhieu(1), New EventArgs())
        Next
        Command_ClickEvent(Command(0), New EventArgs())
        rptFrom.ReportDestination = 1
        P_1 = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mvt"></param>
    ''' <remarks></remarks>
    Private Sub DonGiaNhap(ByRef mvt As Integer)
        Dim MienTru As String = String.Format("SELECT NgayCT,MaVattu,SoPS,SoPS2No FROM ChungTu WHERE ChungTu.MaLoai=1 AND SoPS>0 AND SoPS2No>0 AND MaVattu{0} ORDER BY NgayCT DESC", (IIf(mvt > 0, String.Format("={0}", mvt), ">0")))
        Dim sql As String = String.Format("SELECT SoHieu,DonVi,TenVattu, NgayCT AS Ngay,SoPS/SoPS2No AS DonGia FROM ({0}) AS MienTru INNER JOIN Vattu On MienTru.MaVattu=Vattu.MaSo GROUP BY SoHieu,DonVi,TenVattu", MienTru)

        rptFrom.InitForm("DONGIA.RPT", sql, "QLuyke")

        rptFrom.ReportWindowTitle = "Bảng đơn giá nhập kho mới nhất"
        rptFrom.ReportDestination = 1
        Me.Cursor = Cursors.Default
        InBaoCaoRPT()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LayGiaBan()
        If loaict <> 8 Then Exit Sub
        CboNT(1).Items.Clear()
        CboNT(1).Items.ItemsBase.Clear()
        With vattu
            If .MaSo = 0 Then GoTo kt
            If .GiaBan1 > 0 Then CboNT(1).Items.Add(Format(.GiaBan1, Mask_2))
            If .GiaBan2 > 0 Then CboNT(1).Items.Add(Format(.GiaBan2, Mask_2))
            If .GiaBan3 > 0 Then CboNT(1).Items.Add(Format(.GiaBan3, Mask_2))
        End With
kt:
        CboNT(1).Visible = (CboNT(1).Items.Count > 0)
        If CboNT(1).Items.Count > 0 Then CboNT(1).SelectedIndex = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="shtk"></param>
    ''' <param name="loaips"></param>
    ''' <param name="tien"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CoPSTK(ByRef shtk As String, Optional ByRef loaips As Integer = 0, Optional ByRef tien As Double = 0) As Boolean
        Dim result As Boolean = False
        tien = 0
        With GrdChungtu
            For i As Integer = 0 To .Rows - 1
                .Row = i
                .Col = 1
                If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit For
                If Strings.Left(.Items(.Row).SubItems(.Col).Text, shtk.Length) = shtk Then
                    Select Case loaips
                        Case -1
                            GrdChungtu.Col = 6
                            tien += ConvertToDblSafe(GrdChungtu.Items(.Row).SubItems(.Col).Text)
                            If tien <> 0 Then result = True
                        Case 0
                            result = True
                            Exit For
                        Case 1
                            GrdChungtu.Col = 7
                            tien += ConvertToDblSafe(GrdChungtu.Items(.Row).SubItems(.Col).Text)
                            If tien <> 0 Then result = True
                    End Select
                End If
            Next
        End With
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtsh_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtsh_1.Enter, _txtsh_0.Enter
        Dim Index As Integer = Array.IndexOf(txtsh, eventSender)
        txtsh(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtsh_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtsh_1.KeyPress, _txtsh_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtsh, eventSender)
        If KeyAscii = 13 Then cmd_ClickEvent(cmd(Index), New EventArgs())
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
    Private Sub txtsh_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtsh_1.Leave, _txtsh_0.Leave
        Dim Index As Integer = Array.IndexOf(txtsh, eventSender)
        Dim vis As Boolean
        Dim tkxt As ClsTaikhoan
        Dim khxt As clsKhachHang
        Dim tpxt As Cls154
        Select Case Index
            Case 0
                tkxt = New ClsTaikhoan()
                tkxt.InitTaikhoanSohieu(txtsh(0).Text)
                txtsh(0).Tag = ConvertToStrSafe(IIf(tkxt.maso > 0 And tkxt.tkcon = 0, tkxt.maso, 0))
                lb(0).Text = tkxt.ten
                vis = (Strings.Left(tkxt.sohieu, 3) = "242" Or Strings.Left(tkxt.sohieu, 4) = "1421" Or Strings.Left(tkxt.sohieu, 3) = "154" Or tkxt.tk_id = TKCNKH_ID Or tkxt.tk_id = TKCNPT_ID Or (tkxt.loai = 6 And pDTTP <> 0))
                Label(19).Enabled = vis
                txtsh(1).Enabled = vis
                lb(1).Enabled = vis
                cmd(1).Enabled = vis
                cmd(0).Tag = ConvertToStrSafe(IIf(tkxt.tk_id = TKCNKH_ID Or tkxt.tk_id = TKCNPT_ID, 1, (IIf((tkxt.loai = 6 And pDTTP <> 0) Or Strings.Left(tkxt.sohieu, 3) = "154", 2, (IIf(Strings.Left(tkxt.sohieu, 3) = "242" Or Strings.Left(tkxt.sohieu, 4) = "1421", 3, 0))))))
                tkxt = Nothing
            Case 1
                If ConvertToDblSafe((cmd(0).Tag)) = 1 Then
                    khxt = New clsKhachHang()
                    khxt.InitKhachHangSohieu(txtsh(1).Text)
                    txtsh(1).Tag = ConvertToStrSafe(khxt.MaSo)
                    lb(1).Text = khxt.Ten
                    khxt = Nothing
                ElseIf ConvertToDblSafe((cmd(0).Tag)) = 2 Then
                    tpxt = New Cls154()
                    tpxt.InitTPSohieu(txtsh(1).Text)
                    txtsh(1).Tag = ConvertToStrSafe(tpxt.MaSo)
                    lb(1).Text = tpxt.TenVattu
                    tpxt = Nothing
                ElseIf ConvertToDblSafe((cmd(0).Tag)) = 3 Then
                    tkxt = New ClsTaikhoan()
                    tkxt.InitTaikhoanSohieu(txtsh(1).Text)
                    txtsh(1).Tag = ConvertToStrSafe(tkxt.maso)
                    lb(1).Text = tkxt.ten
                    tkxt = Nothing
                End If
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mct"></param>
    ''' <remarks></remarks>
    Public Sub VaoSoNK(ByRef mct As Integer)
        pGhi = 1
        Dim xphieu As Integer = pPhieu
        pPhieu = 0
        MaSoCT = mct
        HienPhieuTrenManHinh(1)
        '    CmdDanhSach(0).Enabled = False
        '    CmdDanhSach(1).Enabled = False
        Me.ShowDialog()
        If MaSoCT = 0 Then XoaPhieu(mct)
        pPhieu = xphieu
        pGhi = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function SoChietKhau() As Double
        Dim CK As Double
        With GrdChungtu
            For i As Integer = 0 To .Rows - 1
                .Row = i
                .Col = 1
                If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit For
                If Strings.Left(.Items(.Row).SubItems(.Col).Text, 3) = "511" Then
                    .Col = 26
                    CK += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                End If
            Next
        End With
        Return CK
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub TinhCKCT()
        Dim CK As Double = RoundMoney(ConvertToDblSafe(txtchungtu(6).Text) * ConvertToDblSafe(txtchungtu(9).Text) / 100)
        txtchungtu(10).Text = Format(CK, Mask_0)
    End Sub

    Private Sub TinhCKMV()
        Dim CK As Double = RoundMoney(ConvertToDblSafe(txtchungtu(5).Text) * ConvertToDblSafe(txtchungtu(9).Text) / 100)
        txtchungtu(10).Text = Format(CK, Mask_0)
        CK = RoundMoney(ConvertToDblSafe(txtchungtu(5).Text) - ConvertToDblSafe(txtchungtu(10).Text))
        txtchungtu(5).Text = Format(CK, Mask_0)
        If txtchungtu(3).Text = "0" Then
            txtchungtu(4).Text = 0
        Else
            CK = RoundMoney(ConvertToDblSafe(txtchungtu(5).Text) / ConvertToDblSafe(txtchungtu(3).Text))
            txtchungtu(4).Text = Format(CK, Mask_0)
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="dg"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LaySohieuDoiTuong(ByRef dg As String) As Integer
        Dim result As Integer = 0
        Dim k As Integer
        Dim id As Integer
        dg = ""
        With GrdChungtu
            For i As Integer = 0 To .Rows - 1
                .Row = i
                .Col = 1
                If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit For
                id = GetTK_ID(.Items(.Row).SubItems(.Col).Text, 0)
                If id = TKCNKH_ID Or id = TKCNPT_ID Then
                    k += 1
                    .Col = 3
                    If .Items(.Row).SubItems(.Col).Text.Length > 0 Then dg = String.Format("{0} - {1}", dg, .Items(.Row).SubItems(.Col).Text)
                End If
            Next
            If k > 0 Then dg = Strings.Right(dg, dg.Length - 3)
            result = k
        End With
        Return result
    End Function
    Private Sub LaySohieuDoiTuong2(ByRef loaidt As Integer, ByRef sh As String)
        Select Case loaidt
            Case 1
                Int_RecsetToCbo(String.Format("SELECT DISTINCT MaSo AS F2, SoHieu + ' - ' + TenVattu AS F1, SoHieu FROM Vattu WHERE SoHieu LIKE '{0}%' ORDER BY SoHieu", sh), CboNT(3), 1)
            Case 2
                Int_RecsetToCbo(String.Format("SELECT DISTINCT MaSo AS F2, SoHieu + ' - ' + Ten AS F1, SoHieu FROM KhachHang WHERE SoHieu LIKE '{0}%' AND LEFT(SoHieu,1)<>'#' ORDER BY SoHieu", sh), CboNT(3), 1)
        End Select
        Me.Refresh()
        CboNT(3).Tag = ConvertToStrSafe(loaidt)
        CboNT(3).Focus()
        SendKeys.Send("{F4}")
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ml"></param>
    ''' <remarks></remarks>
    Private Sub LayXuatKho(ByRef ml As Integer)
        Dim id As Double
        Dim FileNum As Integer
        Dim BytesNeeded, Buffers, mtk, i, ms, mv As Integer
        Dim shtk = String.Empty, st = String.Empty, st2 As String = String.Empty
        Dim j As Integer
        Dim sl, luong, tien, T As Double
        Dim Buffer(32) As Byte
        If FileSystem.Dir(String.Format("{0}DOWNLOAD.EXE", pCurDir), FileAttribute.Normal).Length = 0 Then Exit Sub
        Directory.SetCurrentDirectory(Strings.Left(pCurDir, pCurDir.Length - 1))
        Recycle(String.Format("{0}\temp\BARCODE.FIL", pCurDir))
        On Error GoTo E
        Dim startInfo As ProcessStartInfo = New ProcessStartInfo(String.Format("{0}DOWNLOAD.EXE", pCurDir))
        startInfo.WindowStyle = ProcessWindowStyle.Maximized
        id = Process.Start(startInfo).Id
        On Error GoTo 0
        Do While bcstop = 0
            AppIdle(1000)
            i += 1
            If FileSystem.Dir(String.Format("{0}\temp\BARCODE.FIL", pCurDir), FileAttribute.Normal).Length > 0 Or i > 10000 Then Exit Do
        Loop
        bcstop = 0
        If FileSystem.Dir(String.Format("{0}\temp\BARCODE.FIL", pCurDir), FileAttribute.Normal).Length = 0 Then GoTo kt
        Me.Cursor = Cursors.WaitCursor
        XoaPhieuTrenManHinh()
        FileNum = FileSystem.FreeFile()
        FileSystem.FileOpen(FileNum, String.Format("{0}\temp\BARCODE.FIL", pCurDir), OpenMode.Binary)
        BytesNeeded = FileSystem.LOF(FileNum)
        Buffers = BytesNeeded \ 32
        For i = 0 To Buffers - 1
            FileSystem.FileGet(FileNum, Buffer, -1)
            If i = 0 Then
                st = ""
                For j = 0 To 9
                    st = String.Format("{0}{1}", st, Chr(Buffer(j)))
                Next
                If Information.IsDate(st) Then
                    Ngay(0) = ConvertToDateSafe(st)
                    Ngay(1) = Ngay(0)
                    MedNgay(0).Text = String.Format(Ngay(0), Mask_D)
                    MedNgay(1).Text = String.Format(Ngay(1), Mask_D)
                End If
            End If
            st = ""
            j = 10
            Do While Buffer(j) <> 32 And j < 32
                If Buffer(j) <> 42 Then st = String.Format("{0}{1}", st, Chr(Buffer(j)))
                j += 1
            Loop
            st2 = ""
            j = 26
            Do While Buffer(j) <> 32 And j < 32
                st2 = st2 & Chr(Buffer(j)).ToString()
                j += 1
            Loop
            luong = ConvertToDblSafe(st2)
            If pBarCode = 1 Then
                vattu.InitVattuSohieu(st)
                If vattu.MaSo > 0 Then
                    If shtk.Length = 0 Then
                        If ml = 2 Then
                            shtk = ConvertToStrSafe(GetSelectValue(String.Format("SELECT HethongTK.Sohieu AS F1 FROM TonKho INNER JOIN HethongTK ON TonKho.MaTaiKhoan=HethongTK.MaSo WHERE MaVattu={0} AND MaSoKho={1}", _
                                                                       vattu.MaSo, _
                                                                       ConvertToStrSafe(CboNT(1).SelectedValue))))
                            Do While SoHieu2MaSo(shtk, "HethongTK") = 0
                                shtk = FrmGetStr.GetString(Ngonngu("Số hiệu tài khoản ghi có:", "Credited to the account number"), Ngonngu("Phiếu xuất kho", "Bills"))
                                If ConvertToDblSafe(GetSelectValue(String.Format("SELECT TK_ID AS F1 FROM HethongTK WHERE TKCon=0 AND Sohieu=N'{0}'", shtk))) <> TKVT_ID Then shtk = "0"
                            Loop
                        End If
                        If ml = 8 Then
                            shtk = ConvertToStrSafe(GetSelectValue("SELECT HethongTK.Sohieu AS F1 FROM ChungTu INNER JOIN HethongTK ON ChungTu.MaTKCo=HethongTK.MaSo WHERE MaLoai=8 AND MaVattu=" & vattu.MaSo))
                            Do While SoHieu2MaSo(shtk, "HethongTK") = 0
                                shtk = FrmGetStr.GetString(Ngonngu("Số hiệu tài khoản ghi doanh thu:", "Account number of record sales"), Ngonngu("Hoá đơn bán hàng", "Invoice of sale"))
                                If ConvertToDblSafe(GetSelectValue(String.Format("SELECT TK_ID AS F1 FROM HethongTK WHERE TKCon=0 AND Sohieu=N'{0}'", shtk))) <> TKDT_ID Then shtk = "0"
                            Loop
                        End If
                    End If
                    Me.txtchungtu(0).Text = shtk
                    Me.txtchungtu(2).Text = vattu.sohieu
                    Me._txtchungtu_LostFocus(txtchungtu(0), Nothing)
                    Me._txtchungtu_LostFocus(txtchungtu(2), Nothing)
                    Me.txtchungtu(3).Text = Format(luong, Mask_2)
                    Me.txtchungtu(5).Text = ""
                    If ml = 2 Then Me._txtchungtu_LostFocus(txtchungtu(3), Nothing)
                    If ml = 8 Then Me.txtchungtu(6).Text = Format(IIf(0.5 + luong * vattu.GiaBan1 > 0, Math.Floor(0.5 + luong * vattu.GiaBan1), Math.Ceiling(0.5 + luong * vattu.GiaBan1)), Mask_2)
                    Me.CmdChitiet_Click(CmdChitiet, Nothing)
                End If
            End If
        Next
        FileSystem.FileClose(FileNum)
        Recycle(pCurDir & "\temp\BARCODE1.FIL")
        FileSystem.Rename(String.Format("{0}\temp\BARCODE.FIL", pCurDir), String.Format("{0}\temp\BARCODE1.FIL", pCurDir))
        Recycle(pCurDir & "\temp\BARCODE.FIL")
        Me.Cursor = Cursors.Default
        Exit Sub
E:
        MessageBox.Show(Information.Err().Description, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
kt:
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="MaCTKT"></param>
    ''' <param name="Chungtu"></param>
    ''' <remarks></remarks>
    Private Sub GhiChungtuCCDC(ByVal MaCTKT As Integer, Optional ByRef Chungtu As ClsChungtu = Nothing)
        Dim sql As String = String.Empty
        Select Case pNghiepVu
            Case NV_TANG
                indexthang = 0
                For i As Integer = 0 To tscount
                    TinhGiaTriCongcudungcu(MaTS(i), ConvertToDblSafe(cuongccdcthang(indexthang)), KH_KHONG)
                    sql = String.Format("INSERT INTO CTCongcudungcu (MaSo, SoHieu, Thang, VaoSo, NgayGhi, DienGiai, MaLoai, MaNhom, MaTS, NG_NS, NG_TBS, NG_CNK, NG_TD, CL_NS, CL_TBS, CL_CNK, CL_TD, MaCTKT{0}) VALUES ({1}, N'{2}',{3}, N'{4}', N'{5}', N'{6}',{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18}{19})", _
                              (IIf(pSongNgu And Strings.Len(txt(2).Text) > 0, ",DienGiaiE", String.Empty)), _
                              ConvertToStrSafe(Lng_MaxValue("MaSo", "CTCongcudungcu") + 1), _
                              txt(0).Text, _
                              ConvertToStrSafe(CboThang.SelectedValue), _
                             Format(Ngay(0), Mask_DB), _
                             Format(Ngay(1), Mask_DB), _
                              txt(1).Text, _
                              ConvertToStrSafe(OptLoai(loaict).Tag), _
                              ConvertToStrSafe(CboNT(0).SelectedValue), _
                              ConvertToStrSafe(MaTS(i)), _
                              doidau(GiaTri.NG_NS), _
                              doidau(GiaTri.NG_TBS), _
                              doidau(GiaTri.NG_CNK), _
                              doidau(GiaTri.NG_TD), _
                              doidau(GiaTri.CL_NS), _
                              doidau(GiaTri.CL_TBS), _
                              doidau(GiaTri.CL_CNK), _
                              doidau(GiaTri.CL_TD), _
                              ConvertToStrSafe(MaCTKT), _
                              (IIf(pSongNgu And Strings.Len(txt(2).Text) > 0, String.Format(",'{0}'", txt(2).Text), String.Empty)))
                    ExecSQLNonQuery(sql)
                    sql = String.Format("UPDATE Congcudungcu SET SHCT=N'{0}',NCT=N'{1}' WHERE MaSo={2}", _
                              txt(0).Text, _
                             Format(Ngay(0), Mask_DB), _
                              ConvertToStrSafe(MaTS(i)))
                    ExecSQLNonQuery(sql)
                    indexthang += 1
                Next
            Case NV_GIAM
                TacDongGiamCongcudungcu(pMaCongcudungcu, CboThang.SelectedIndex, TD_GIAM)
            Case NV_DGLAI
            Case NV_TKHAO
                XoaChungTuPhanBo(txt(0).Text, _
                    ConvertToDblSafe(Me.Tag), _
                    CboThang.SelectedIndex, _
                    CboNT(0).SelectedIndex, _
                    MaCTKT, _
                    ConvertToStrSafe(CboNguon(0).Tag))
        End Select
        If pNghiepVu > 0 And pNghiepVu <> NV_TANG Then
            sql = String.Format("INSERT INTO CTCongcudungcu (MaSo, SoHieu, Thang, VaoSo, NgayGhi, DienGiai, MaLoai, MaNhom, MaTS, NG_NS, NG_TBS, NG_CNK, NG_TD, CL_NS, CL_TBS, CL_CNK, CL_TD, MaCTKT{0})VALUES ({1}, N'{2}',{3}, N'{4}', N'{5}', N'{6}',{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18}{19})", _
                      (IIf(pSongNgu And Strings.Len(txt(2).Text) > 0, ",DienGiaiE", String.Empty)), _
                      ConvertToStrSafe(Lng_MaxValue("MaSo", "CTCongcudungcu") + 1), _
                      txt(0).Text, _
                      ConvertToStrSafe(CboThang.SelectedValue), _
                     Format(Ngay(0), Mask_DB), _
                     Format(Ngay(1), Mask_DB), _
                      txt(1).Text, _
                      ConvertToStrSafe(OptLoai(loaict).Tag), _
                      ConvertToStrSafe(CboNT(0).SelectedValue), _
                      ConvertToStrSafe(pMaCongcudungcu), _
                      doidau(GiaTri.NG_NS), _
                      doidau(GiaTri.NG_TBS), _
                      doidau(GiaTri.NG_CNK), _
                      doidau(GiaTri.NG_TD), _
                      doidau(GiaTri.CL_NS), _
                      doidau(GiaTri.CL_TBS), _
                      doidau(GiaTri.CL_CNK), _
                      doidau(GiaTri.CL_TD), _
                      ConvertToStrSafe(MaCTKT), _
                      (IIf(pSongNgu And Strings.Len(txt(2).Text) > 0, String.Format(", N'{0}'", txt(2).Text), String.Empty)))
            ExecSQLNonQuery(sql)
            If pNghiepVu = NV_DGLAI Then DieuChinhPB(pMaCongcudungcu, CboThang.SelectedValue)
        End If
        Try
            Dim masocongcu As Integer
            Dim SoHieu As String = String.Empty
            If (Strings.Left(Chungtu.tkno.sohieu, 3) = "153" And loaict = 1 And chkXT.CheckState = CheckState.Checked) Or (((Strings.Left(Chungtu.TkCo.sohieu, 2) = "15" And loaict = 2) Or loaict = 0) And (Strings.Left(Chungtu.tkno.sohieu, 4) = "1421" Or Strings.Left(Chungtu.tkno.sohieu, 3) = "242")) Then
                SoHieu = txt(0).Text
                If Chungtu.CT_ID <> 0 Then
                    If SoHieu.Length > 2 And SoHieu.EndsWith("XT") Then SoHieu = Strings.Left(SoHieu, SoHieu.Length - 2)
                    MaCTKT = ConvertToDblSafe(Timten("mact", SoHieu, "sohieu", "chungtu"))
                End If
                masocongcu = ConvertToDblSafe(Timten("maso", SoHieu, "shct", "congcudungcu"))
                If masocongcu <> 0 And (loaict = 0 Or Chungtu.CT_ID = 0) Then
                    ExecSQLNonQuery(String.Format("DELETE  FROM thongso1 where mats={0}", masocongcu))
                    sokyphanbo = ConvertToDblSafe(GetSelectValue(String.Format("select namkh as f1 from congcudungcu where shct=N'{0}'", SoHieu)))
                    ExecSQLNonQuery(String.Format("DELETE  FROM congcudungcu where shct=N'{0}'", SoHieu))
                    ExecSQLNonQuery(String.Format("DELETE  FROM ctcongcudungcu where sohieu=N'{0}'", SoHieu))
                End If
                If Me.chkXT.CheckState = CheckState.Checked Or Me.ChkDoiTuong.CheckState = CheckState.Checked Then
                    Chungtu.NamKH = Math.Abs(ConvertToDblSafe(FrmGetStr.GetString(Ngonngu("Số kỳ phân bổ (nếu bỏ trống thì mặc định = 12):", "Number allocation (if left blank, the Default = 12):"), My.Application.Info.ProductName, ConvertToStrSafe(IIf(sokyphanbo <> 0, sokyphanbo, 12)))))
                    sokyphanbo = 0
                    If Chungtu.NamKH = 0 Then Chungtu.NamKH = 12
                    sql = String.Format("INSERT INTO CTCongcudungcu (MaSo, SoHieu, Thang, VaoSo, NgayGhi, DienGiai, MaLoai, MaNhom, MaTS, NG_NS, NG_TBS, NG_CNK, NG_TD, CL_NS, CL_TBS, CL_CNK, CL_TD, MaCTKT{0})VALUES ({1}, N'{2}',{3}, N'{4}', N'{5}', N'{6}',32,{7},{8},0,{9},0,0,0,{9},0,0,{10}{11})", _
                              (IIf(pSongNgu And Strings.Len(txt(2).Text) > 0, ",DienGiaiE", String.Empty)), _
                              ConvertToStrSafe(Lng_MaxValue("MaSo", "CTCongcudungcu") + 1), _
                              SoHieu, _
                              ConvertToStrSafe(CboThang.SelectedValue), _
                              Format(Ngay(0), Mask_DB), _
                              Format(Ngay(1), Mask_DB), _
                              txt(1).Text, _
                              ConvertToStrSafe(GetSelectValue("select maso as f1 from nguonnhapxuat where maso>0")), _
                              ConvertToStrSafe(Lng_MaxValue("MaSo", "Congcudungcu") + 1), _
                              doidau(Chungtu.sops), _
                              ConvertToStrSafe(MaCTKT), _
                              (IIf(pSongNgu And Strings.Len(txt(2).Text) > 0, String.Format(", N'{0}'", txt(2).Text), String.Empty)))
                    ExecSQLNonQuery(sql)
                End If
            Else
                '        SetLoaiChungtu 0
            End If
        Catch
        End Try
        pGhichungtu = 0
        pMaCongcudungcu = 0
        tscount = -1
        '    _OptLoai_0.Value = True
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="SoHieu"></param>
    ''' <remarks></remarks>
    Public Sub Suatonkho(ByRef SoHieu As String)
        Dim p As Integer
        Dim a As Integer = ConvertToDblSafe((Timten("mact", SoHieu, "sohieu", "chungtu")))
        If a > 0 Then
            Me.Refresh()
            Me.Cursor = Cursors.WaitCursor
            MaSoCT = a
            If HienPhieuTrenManHinh(p) >= 0 Then
                Me.Cursor = Cursors.Default
                tuongkho = 1
                On Error GoTo Loi
                Me.ShowDialog()
                GoTo Khongloi
Loi:
                MessageBox.Show(String.Format("Vui lòng thoát cửa sổ Chứng từ{0}Vào cửa sổ Báo cáo chi tiết để thực hiện thao tác này", Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
Khongloi:
                tuongkho = 0
            End If
        End If
    End Sub
End Class
