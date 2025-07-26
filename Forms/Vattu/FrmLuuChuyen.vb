Imports System
Imports System.IO
Imports System.Data
Imports UNET.Utility
Imports System.Diagnostics
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter

Partial Friend Class FrmLuuChuyen
    Dim Ngay As Date
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
    Private _taikhoan1 As ClsTaikhoan = Nothing
    Property taikhoan1() As ClsTaikhoan
        Get
            If _taikhoan1 Is Nothing Then
                _taikhoan1 = New ClsTaikhoan()
            End If
            Return _taikhoan1
        End Get
        Set(ByVal Value As ClsTaikhoan)
            _taikhoan1 = Value
        End Set
    End Property
    Private _vattu As ClsVattu = Nothing
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
    Dim MaNhap As Integer
    Dim flag As Integer
    Dim bcstop As Integer
    Public MaCT As Long, KyHieu As String, dieulenh As String, ngaydl As Date, cua As String, veviec As String, nguoivanchuyen As String, hopdong As String, phuongtien As String, MauSo As String

    Private Sub Cbo_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Cbo.SelectedIndexChanged
        'van.nguyen 15-Nov-2011
        Int_RecsetToCbo("SELECT DISTINCT MaCT As F2,SoHieu As F1 ,NgayCT FROM ChungTu  WHERE MaLoai=4 AND ThangCT=" & Cbo.SelectedValue & " GROUP BY MaCT, SoHieu, NgayCT ORDER BY sohieu", CboSohieu)
        If CboSohieu.Items.Count > 0 Then
            CboSohieu.SelectedIndex = 0
        End If
        XoaPhieuTrenManHinh()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboDV_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboDV.SelectedIndexChanged
        Dim tien, tien2 As Double
        If OutCost <> 0 Or vattu.MaSo = 0 Or vattu.Dvt2 = CheckState.Unchecked Then Exit Sub
        Dim dvt As Integer = Nothing
        If CboDV.Items.Count > 0 Then
            dvt = CboDV.SelectedValue
        End If
        Dim luong As Double = SoTonKho(Ngay.Month, CboKho(0).SelectedValue, taikhoan.maso, vattu.MaSo, tien, tien2)
        If dvt = 0 Then
            txtChuyen(4).Tag = ConvertToStrSafe(luong)
        Else
            txtChuyen(4).Tag = ConvertToStrSafe(QuyDoiTheoDVT2(vattu.MaSo, dvt, luong))
        End If
        txtChuyen(4).Text = Format(ConvertToStrSafe(txtChuyen(4).Tag), Mask_2)
    End Sub
    '====================================================================================================
    ' Chuẩn bị phiếu lưu chuyển
    '====================================================================================================
    Private Sub CboKho_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _CboKho_1.SelectedIndexChanged, _CboKho_0.SelectedIndexChanged
        Dim Index As Integer = Array.IndexOf(CboKho, eventSender)
        If Index = 0 Then
            ClearGrid(GrdChuyen, ConvertToDblSafe(GrdChuyen.Tag))
            If CboSohieu.SelectedIndex >= 0 Then
                'CboSohieu.SelectedIndex = -1
                CboSohieu.Text = ""
            End If
        End If
    End Sub

    Private Sub CboSohieu_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboSohieu.LostFocus
        Dim sql As String
        sql = String.Format("select count(maso) as f1 from chungtu where sohieu like '{0}'", CboSohieu.Text)
        If GetSelectValue(sql) > 0 And CboSohieu.SelectedIndex < 0 Then MessageBox.Show("Số chừng từ này đã tồn tại." & vbCrLf & "Vui lòng nhập số chứng từ khác!")
    End Sub
    '====================================================================================================
    ' Hiển thị phiếu được chọn
    '====================================================================================================
    Private Sub CboSohieu_SelectionChangeCommitted(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboSohieu.SelectionChangeCommitted
        Dim luong, tien As Double
        If CboSohieu.SelectedIndex < 0 Then Exit Sub
        ClearGrid(GrdChuyen, ConvertToDblSafe(GrdChuyen.Tag))
        XoaPhieuTrenManHinh()
        Dim rs_chungtu As DataTable = ExecSQLReturnDT("SELECT NgayCT,DienGiai,MaKho,MaNguon, MaTKNo, MaTKCo,TK.SoHieu AS SHTK,MaVattu,Vattu.SoHieu AS SHVT,TenVattu,DonVi,SoPS,SoPS2Co,CT_ID,HethongTK.SoHieu AS SHNo,[User_ID],DVT,TyGia" & (IIf(pGiaUSD > 0, ",PSUSD", String.Empty)) & ",MaDT1,MaDT2,MaDT3 FROM (" & ChungTu2TKNC(0) & ") INNER JOIN Vattu ON Chungtu.MaVattu=Vattu.MaSo" & " WHERE MaCT=" & CboSohieu.SelectedValue)
        If rs_chungtu.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim rs_chungtuItem As DataRow = rs_chungtu.Rows(0)

        Ngay = ConvertToDateSafe(rs_chungtuItem("NgayCT"))
        MedNgay.Text = Format(Ngay, Mask_D)
        txtChuyen(7).Text = rs_chungtuItem("DienGiai")
        SetListIndex(CboKho(0), rs_chungtuItem("MaKho"))
        LbUser.Text = TenUser(rs_chungtuItem("User_ID"))
        If pTygia > 0 Then txtChuyen(8).Text = Format(rs_chungtuItem("tygia"), Mask_0)

        Dim rs As DataTable
        rs = ExecSQLReturnDT("select KyHieu, DieuLenh, Ngay, Cua, Veviec, NguoiVanChuyen, HopDong, PhuongTien,MauSo from luuchuyen where mact=" + CStr(CboSohieu.SelectedValue))
        If rs.Rows.Count > 0 Then
            txtChuyen(10).Text = rs.Rows(0)("dieulenh")
            ngaydl = rs.Rows(0)("ngay")
            MedNgayDL.Text = Format(ngaydl, Mask_D)
            txtChuyen(11).Text = rs.Rows(0)("cua")
            txtChuyen(12).Text = rs.Rows(0)("veviec")
            txtChuyen(13).Text = rs.Rows(0)("nguoivanchuyen")
            txtChuyen(14).Text = rs.Rows(0)("hopdong")
            txtChuyen(15).Text = rs.Rows(0)("phuongtien")
            txtChuyen(16).Text = rs.Rows(0)("mauso")
        End If

        If pSoVV > 0 And ConvertToDblSafe(rs_chungtuItem("MaDT1")) > 0 Then SetListIndex(CboVV(0), rs_chungtuItem("MaDT1"))
        If pSoVV > 1 And ConvertToDblSafe(rs_chungtuItem("MaDT2")) > 0 Then SetListIndex(CboVV(1), rs_chungtuItem("MaDT2"))
        If pSoVV > 2 And ConvertToDblSafe(rs_chungtuItem("MaDT3")) > 0 Then SetListIndex(CboVV(2), rs_chungtuItem("MaDT3"))
        Dim rs_chungtuIndex As Integer = 0
        Do While rs_chungtuIndex < rs_chungtu.Rows.Count
            Dim rs_chungtuItem2 As DataRow = rs_chungtu.Rows(rs_chungtuIndex)
            rs_chungtuIndex += 1 ' C15 Rs LOOP CONTROL
            SetListIndex(CboKho(1), rs_chungtuItem2("MaNguon"))
            luong = IIf(ConvertToDblSafe(rs_chungtuItem2("MaVattu")) > 0 And ConvertToDblSafe(rs_chungtuItem2("dvt")) > 0, QuyDoiTheoDVT2(rs_chungtuItem2("MaVattu"), rs_chungtuItem2("dvt"), rs_chungtuItem2("SoPS2Co")), rs_chungtuItem2("SoPS2Co"))
            tien = IIf(pGiaUSD > 0, rs_chungtuItem2("TyGia"), 0)

            GrdChuyen.AddItem(ConvertToStrSafe(rs_chungtuItem2("shtk")) + Chr(9).ToString() + ConvertToStrSafe(rs_chungtuItem2("shvt")) + Chr(9).ToString() + ConvertToStrSafe(rs_chungtuItem2("TenVattu")) + Chr(9).ToString() + (IIf(ConvertToDblSafe(rs_chungtuItem2("dvt")) = 0, rs_chungtuItem2("DonVi"), ConvertToDblSafe(TenDVT(rs_chungtuItem2("dvt"))))) + Chr(9).ToString() + Format(luong, Mask_2) + Chr(9).ToString() + Format(rs_chungtuItem2("sops"), Mask_0) + Chr(9).ToString() + CboKho(1).Text + Chr(9).ToString() + ConvertToStrSafe(rs_chungtuItem2("shno")) + Chr(9).ToString() + ConvertToStrSafe(rs_chungtuItem2("MaTkCo")) + Chr(9).ToString() + ConvertToStrSafe(rs_chungtuItem2("MaVattu")) + Chr(9).ToString() + ConvertToStrSafe(rs_chungtuItem2("CT_ID")) + Chr(9).ToString() + ConvertToStrSafe(rs_chungtuItem2("MaNguon")) + Chr(9).ToString() + ConvertToStrSafe(rs_chungtuItem2("MaTkNo")) + Chr(9).ToString() + ConvertToStrSafe(rs_chungtuItem2("dvt")) + Chr(9).ToString() + Format(tien, Mask_2), 0)
            'rs_chungtu.MoveNext()
        Loop
        GrdChuyen.Rows = IIf(rs_chungtu.Rows.Count > ConvertToDblSafe(GrdChuyen.Tag), rs_chungtu.Rows.Count, ConvertToDblSafe(GrdChuyen.Tag))
        tongtien()
        ''rs_chungtu.Close()
        rs_chungtu = Nothing
        vattu.InitVattuMaSo(0)
        taikhoan.InitTaikhoanMaSo(0)
    End Sub
    '====================================================================================================
    ' Thêm, sửa, xóa phiếu lưu chuyển
    '====================================================================================================
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_4.Click, SimpleButton1.Click, _Command_2.Click, _Command_3.Click, _Command_1.Click, _Command_0.Click, _Command_5.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim CboSohieu_NewIndex As Integer = -1
        Dim Chungtu As New ClsChungtu
        Dim shvt, sh, tkno As String
        Dim tien2, ttien, ttien2 As Double
        Dim dvt As Integer
        Me.Cursor = Cursors.WaitCursor
        Dim rs_chungtu As DataTable
        Dim mk, mvt, mtk, mtk1 As Integer
        Dim luong, tien As Double
        Select Case Index
            Case 0
                XoaPhieuTrenManHinh()
                If CboSohieu.Visible Then CboSohieu.Focus()
                GrdChuyen.Row = 0
                Khoaquyen()
            Case 1
                If Not KiemTraPhieu() Then GoTo XongLC
                MaCT = Lng_MaxValue("MaCT", "ChungTu") + 1
                With GrdChuyen
                    For i As Integer = 0 To .Rows - 1
                        .Row = i
                        .Col = 8
                        If .CtlText.Length = 0 Then Exit For
                        mtk = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 9
                        mvt = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 11
                        mk = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 12
                        mtk1 = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 13
                        dvt = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 4
                        luong = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 5
                        tien = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 14
                        tien2 = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        If dvt > 0 Then luong = QuyDoiTheoDVT1(mvt, dvt, luong)
                        Chungtu.InitChungtu(0, _
                            4, _
                            CboSohieu.Text, _
                            Cbo.SelectedValue, _
                            Ngay, _
                            Ngay, _
                            mk, _
                            CboKho(0).SelectedValue, _
                            txtChuyen(7).Text, _
                            mtk1, _
                            mtk, _
                            tien, _
                            luong, _
                            luong, _
                            mvt, _
                            "...", _
                            1, DateTime.Today)

                        If pGiaUSD > 0 Then Chungtu.PSUSD = tien2
                        Chungtu.MaCT = MaCT
                        .Col = 10
                        Chungtu.CT_ID = -ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        If pTygia > 0 Then Chungtu.tygia = ConvertToDblSafe(txtChuyen(8).Text)
                        Chungtu.User_ID = UserID
                        Chungtu.dvt = dvt
                        If pSoVV > 0 And CboVV(0).SelectedIndex >= 0 Then Chungtu.MaDT1 = CboVV(0).SelectedIndex
                        If pSoVV > 1 And CboVV(1).SelectedIndex >= 0 Then Chungtu.MaDT2 = CboVV(1).SelectedIndex
                        If pSoVV > 2 And CboVV(2).SelectedIndex >= 0 Then Chungtu.MaDT3 = CboVV(2).SelectedIndex
                        Chungtu.GhiChungtu()
                    Next
                End With
                LayDuLieu()
                GhiLuuChuyen()
                sh = CboSohieu.Text
                Command_ClickEvent(Command(2), New EventArgs())
                CboSohieu.Items.Add(sh, MaCT)
            Case 2
                If CboSohieu.SelectedIndex >= 0 Then
                    rs_chungtu = ExecSQLReturnDT(String.Format("SELECT MaSo FROM ChungTu WHERE MaCT={0}", CboSohieu.SelectedValue))
                    Dim rs_chungtuIndex As Integer = 0
                    Do While rs_chungtuIndex < rs_chungtu.Rows.Count
                        Dim rs_chungtuItem As DataRow = rs_chungtu.Rows(rs_chungtuIndex)
                        rs_chungtuIndex += 1 ' C15 Rs LOOP CONTROL
                        Chungtu.InitChungtu(ConvertToIDSafe(rs_chungtuItem("MaSo")), _
                            0, _
                            "", _
                            0, _
                            Ngay, _
                            Ngay, _
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
                        Chungtu.XoaChungtu()
                    Loop
                    rs_chungtu = Nothing
                    CboSohieu.Items.ItemsBase.RemoveAt(ConvertToIntSafe(CboSohieu.SelectedIndex))
                End If
                XoaPhieuTrenManHinh()
                GrdChuyen.Row = 0
            Case 3
                Me.Close() : Exit Sub
            Case 4
                Dim lien As Integer, solien As Integer, mstcty As Double, sohoadon As Double, J As Integer
                lien = Interaction.GetSetting(IniPath, "Environment", "HD", 2)
                For solien = 1 To lien
                    rptFrom.InitForm("PHIEULC" + CStr(solien) + ".RPT", "SELECT * FROM License", "License")
                    SetRptInfo()
                    ExecSQLNonQuery("DELETE FROM PhieuNX")
                    With GrdChuyen
                        For i = 0 To .Rows - 1
                            .Row = i
                            .Col = 0
                            sh = .Items(.Row).SubItems(.Col).Text
                            If Len(sh) = 0 Then Exit For
                            J = 19 + i * 6
                            rptFrom.SetFormulas("stt" + CStr(i + 1), CStr(i + 1))
                            .Col = 1
                            J = J + 1
                            rptFrom.SetFormulas("sohieu" + CStr(i + 1), "'" + CStr(.Items(.Row).SubItems(.Col).Text) + "'")
                            shvt = .Items(.Row).SubItems(.Col).Text
                            .Col = 7
                            tkno = .Items(.Row).SubItems(.Col).Text
                            .Col = 4
                            J = J + 1
                            rptFrom.SetFormulas("soluong" + CStr(i + 1), ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text))
                            luong = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                            .Col = 5
                            J = J + 1
                            rptFrom.SetFormulas("thanhtien" + CStr(i + 1), ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text))
                            tien = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                            ttien = ttien + tien
                            .Col = 14
                            tien2 = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                            ttien2 = ttien2 + tien2
                            .Col = 6
                            ExecSQLNonQuery("INSERT INTO PhieuNX (MaSo,SoCT,DienGiaiCT,SoHieu,DienGiai,SoLuong,ThanhTien,ThanhTien2) VALUES (" + CStr(Lng_MaxValue("MaSo", "PhieuNX") + 1) + ",'" + sh + "','" + .Items(.Row).SubItems(.Col).Text _
                                + "','" + shvt + "','" + tkno + "'," + CStr(luong) + "," + CStr(tien) + "," + CStr(tien2) + ")")
                            .Col = 2
                            J = J + 1
                            rptFrom.SetFormulas("DienGiai" + CStr(i + 1), "'" + CStr(.Items(.Row).SubItems(.Col).Text) + "'")
                            .Col = 3
                            J = J + 1
                            rptFrom.SetFormulas("dvt" + CStr(i + 1), "'" + CStr(.Items(.Row).SubItems(.Col).Text) + "'")
                        Next
                    End With
                    rptFrom.SetFormulas("Kho", "'" + CboKho(0).Text + "'")
                    rptFrom.SetFormulas("SHPhieu", "'" + CboSohieu.Text + "'")
                    rptFrom.SetFormulas("Sotien", "'" + ToVNText(ttien) + " VND'")
                    rptFrom.SetFormulas("Ngay", "'" + Format(Ngay, Mask_DB) + "'")
                    rptFrom.SetFormulas("LyDo", "'" + txtChuyen(7).Text + "'")
                    rptFrom.SetFormulas("dieulenh", "'" + txtChuyen(10).Text + "'")
                    rptFrom.SetFormulas("ngaydl", "'" + Format(ngaydl, Mask_DB) + "'")
                    rptFrom.SetFormulas("cua", "'" + txtChuyen(11).Text + "'")
                    rptFrom.SetFormulas("veviec", "'" + txtChuyen(12).Text + "'")
                    rptFrom.SetFormulas("nguoivanchuyen", "'" + txtChuyen(13).Text + "'")
                    rptFrom.SetFormulas("hopdong", "'" + txtChuyen(14).Text + "'")
                    rptFrom.SetFormulas("phuongtien", "'" + txtChuyen(15).Text + "'")
                    rptFrom.SetFormulas("mauso", "'" + txtChuyen(16).Text + "'")
                    rptFrom.SetFormulas("Kho1", "'" + CboKho(1).Text + "'")
                    rptFrom.SetFormulas("Kyhieu", "'" + txtChuyen(7).Text + "'")

                    rptFrom.SetFormulas("DC1", String.Format("'{0} - {1} - {2}'", frmMain._LbCty_2.Text, frmMain._LbCty_10.Text, frmMain._LbCty_11.Text))
                    rptFrom.SetFormulas("Dienthoai", String.Format("'{0}'", frmMain._LbCty_3.Text))
                    rptFrom.SetFormulas("Fax", String.Format("'{0}'", frmMain._LbCty_4.Text))
                    rptFrom.SetFormulas("TaiKhoanTienViet", String.Format("'{0}'", FrmOptions.Text_Renamed(5).Text))

                    mstcty = frmMain._LbCty_8.Text.Substring(0, 10)
                    If CboSohieu.Text.Length > 6 Then
                        sohoadon = ConvertToDblSafe(CboSohieu.Text.Substring(CboSohieu.Text.Length - 6)) + 1000000
                        sohoadon = ConvertToDblSafe(MedNgay.Text.Substring(0, 2) + MedNgay.Text.Substring(4, 2) + MedNgay.Text.Substring(MedNgay.Text.Length - 2) + CStr(sohoadon).Substring(CStr(sohoadon).Length - 6))
                    End If
                    rptFrom.SetFormulas("mavach", "'" + CStr(mstcty + sohoadon) + "'")
                    InBaoCaoRPT()
                Next
            Case 5
                If CboKho(0).Items.Count = 1 Then GoTo XongLC
                If CboKho(1).SelectedIndex = CboKho(0).SelectedIndex Then
                    MessageBox.Show(Ngonngu("Chọn kho nhập", "Allow enter"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    CboKho(1).Focus()
                    GoTo XongLC
                End If
                LayXuatKho()
        End Select
XongLC:
        Chungtu = Nothing
        Me.Cursor = Cursors.Default
    End Sub

    Sub LayDuLieu()
        KyHieu = txtChuyen(7).Text
        dieulenh = txtChuyen(10).Text
        ngaydl = MedngayDL.Text
        cua = txtChuyen(11).Text
        veviec = txtChuyen(12).Text
        nguoivanchuyen = txtChuyen(13).Text
        hopdong = txtChuyen(14).Text
        phuongtien = txtChuyen(15).Text
        MauSo = txtChuyen(16).Text
    End Sub

    Sub GhiLuuChuyen()
        If GetSelectValue("select count(maso) as f1 from luuchuyen where mact=" + CStr(MaCT)) = 0 Then
            Dim sql As String = "INSERT INTO LuuChuyen (MaSo,MaCT, MauSo,  KyHieu, DieuLenh, Ngay, Cua, Veviec, NguoiVanChuyen, HopDong, PhuongTien) VALUES (" _
                + CStr(Lng_MaxValue("MaSo", "LuuChuyen") + 1) + "," + CStr(MaCT) + ",N'" + CStr(MauSo) + "',N'" + CStr(KyHieu) + "',N'" + CStr(dieulenh) + "','" + Format(CDate(ngaydl), Mask_DB) _
                + "',N'" + CStr(cua) + "',N'" + CStr(veviec) + "',N'" + CStr(nguoivanchuyen) + "',N'" + CStr(hopdong) + "',N'" + CStr(phuongtien) + "')"
            ExecSQLNonQuery(sql)
        End If
    End Sub

    '====================================================================================================
    ' Ghi chi tiết lưu chuyển
    '====================================================================================================
    Private Sub cmdct_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdct.Click
        Dim dvt As Integer
        If taikhoan.maso = 0 Or taikhoan.tk_id <> TKVT_ID Then ' Or (taikhoan.MaSo <> mtkc And mtkc > 0)
            txtChuyen(0).Focus()
            Exit Sub
        End If
        If taikhoan1.maso = 0 Or (Strings.Left(taikhoan1.sohieu, 1) <> "6") And taikhoan1.tk_id <> TKVT_ID Then ' Or (taikhoan.MaSo <> mtkc And mtkc > 0)
            txtChuyen(6).Focus()
            Exit Sub
        End If
        If CboKho(0).SelectedIndex < 0 Then Exit Sub
        If vattu.MaSo = 0 Then
            txtChuyen(1).Focus()
            Exit Sub
        End If
        If CboKho(1).SelectedIndex = CboKho(0).SelectedIndex And taikhoan1.tk_id = TKVT_ID Then
            CboKho(1).Focus()
            Exit Sub
        End If
        Dim luong As Double = ConvertToDblSafe(txtChuyen(4).Text)
        Dim tien2 As Double = ConvertToDblSafe(txtChuyen(9).Text)
        Dim tien As Double = RoundMoney(ConvertToDblSafe(txtChuyen(5).Text))
        If luong = 0 Then
            MessageBox.Show(Ngonngu("Hãy nhập số lượng cần lưu chuyển !", "Please enter the number of required movement !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtChuyen(4).Focus()
            Exit Sub
        End If
        If luong > ConvertToDblSafe((txtChuyen(4).Tag)) Then
            If MessageBox.Show(Ngonngu("Xuất quá lượng tồn kho, tiếp tục ?", "Existence of excess, continue ?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.No Then
                txtChuyen(4).Focus()
                Exit Sub
            End If
        End If
        If OutCost = 0 And vattu.Dvt2 > 0 Then
            dvt = CboDV.SelectedValue
        Else
            dvt = 0
        End If
        If Not (taikhoan.loai = 0 Or OutCost > 0) Then
            With GrdChuyen
                For i As Integer = 0 To .Rows - 1
                    .Col = 8
                    .Row = i
                    If .CtlText.length = 0 Then Exit For
                    If ConvertToDblSafe(.CtlText) = taikhoan.maso Then
                        .Col = 9
                        If ConvertToDblSafe(.CtlText) = vattu.MaSo Then
                            .Col = 11
                            If ConvertToDblSafe(.CtlText) = CboKho(1).SelectedValue Then
                                .Col = 12
                                If ConvertToDblSafe(.CtlText) = taikhoan1.maso Then
                                    .RemoveItem(ConvertToDblSafe(i))
                                    .AddItem(taikhoan.sohieu & Chr(9).ToString() & vattu.sohieu & Chr(9).ToString() & vattu.TenVattu & Chr(9).ToString() & (IIf(dvt = 0, vattu.DonVi, CboDV.Text)) & Chr(9).ToString() & Format(luong, Mask_2) & Chr(9).ToString() & Format(tien, Mask_0) & Chr(9).ToString() & CboKho(1).Text & Chr(9).ToString() & taikhoan1.sohieu & Chr(9).ToString() & ConvertToStrSafe(taikhoan.maso) & Chr(9).ToString() & ConvertToStrSafe(vattu.MaSo) & Chr(9).ToString() & ConvertToStrSafe(MaNhap) & Chr(9).ToString() & ConvertToStrSafe(CboKho(1).SelectedValue) & Chr(9).ToString() & ConvertToStrSafe(taikhoan1.maso) & Chr(9).ToString() & ConvertToStrSafe(dvt) & (IIf(pGiaUSD > 0, Chr(9).ToString() & Format(tien2, Mask_2), String.Empty)), i)
                                    GoTo abc
                                End If
                            End If
                        End If
                    End If
                Next
            End With
        End If
        GrdChuyen.AddItem(taikhoan.sohieu & Chr(9).ToString() & vattu.sohieu & Chr(9).ToString() & vattu.TenVattu & Chr(9).ToString() & (IIf(dvt = 0, vattu.DonVi, CboDV.Text)) & Chr(9).ToString() & Format(luong, Mask_2) & Chr(9).ToString() & Format(tien, Mask_0) & Chr(9).ToString() & CboKho(1).Text & Chr(9).ToString() & taikhoan1.sohieu & Chr(9).ToString() & ConvertToStrSafe(taikhoan.maso) & Chr(9).ToString() & ConvertToStrSafe(vattu.MaSo) & Chr(9).ToString() & ConvertToStrSafe(MaNhap) & Chr(9).ToString() & ConvertToStrSafe(CboKho(1).SelectedValue) & Chr(9).ToString() & ConvertToStrSafe(taikhoan1.maso) & Chr(9).ToString() & ConvertToStrSafe(dvt) & (IIf(pGiaUSD > 0, Chr(9).ToString() & Format(tien2, Mask_2), String.Empty)), NewRowIndex(GrdChuyen, 0))
        GrdChuyen.Row = ConvertToDblSafe(GrdChuyen.Rows - 1)
        GrdChuyen.Col = 5
        If Strings.Len(GrdChuyen.CtlText) = 0 Then GrdChuyen.RemoveItem(GrdChuyen.Row)
        GrdChuyen.Row = 0
        GrdChuyen.Col = 0
        tongtien()
abc:
        For i As Integer = 0 To 3
            txtChuyen(i).Text = ""
        Next
        vattu.InitVattuMaSo(0)
        taikhoan.InitTaikhoanMaSo(0)
        MaNhap = 0
        txtChuyen(0).Focus()
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Khoaquyen()
    End Sub
    '====================================================================================================
    ' Xử lý các phím nóng
    '====================================================================================================
    Private Sub FrmLuuChuyen_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
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
            End Select
            If i >= 0 Then
                If Command(i).Enabled Then
                    Command(i).Focus()
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
    '====================================================================================================
    ' Khởi tạo cửa sổ nhập
    '====================================================================================================
    Private Sub FrmLuuChuyen_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            CreateTableLuuChuyen()
            Call FormInit()

            ColumnSetUp(GrdChuyen, 0, 940, 0)
            ColumnSetUp(GrdChuyen, 1, 1180, 0)
            ColumnSetUp(GrdChuyen, 2, 1780, 0)
            ColumnSetUp(GrdChuyen, 3, 700, 0)
            ColumnSetUp(GrdChuyen, 4, 940, 4)
            ColumnSetUp(GrdChuyen, 5, 1180, 4)
            ColumnSetUp(GrdChuyen, 6, 1540, 4)
            ColumnSetUp(GrdChuyen, 7, 915, 4)
            'ColumnSetUp(GrdChuyen, 8, 1, 0)
            'ColumnSetUp(GrdChuyen, 9, 1, 0)
            'ColumnSetUp(GrdChuyen, 10, 1, 0)
            'ColumnSetUp(GrdChuyen, 11, 1, 0)
            'ColumnSetUp(GrdChuyen, 12, 1, 0)
            'ColumnSetUp(GrdChuyen, 13, 1, 0)
            'ColumnSetUp(GrdChuyen, 14, 1180, 1)
            InitDateVars(MedNgay, Ngay)
            InitDateVars(MedNgayDL, Ngay)
            Int_RecsetToCbo("SELECT MaSo As F2,TenKho As F1 FROM KhoHang ORDER BY TenKho", CboKho(0))
            Int_RecsetToCbo("SELECT MaSo As F2,TenKho As F1 FROM KhoHang ORDER BY TenKho", CboKho(1))
            If _CboKho_0.Items.Count > 0 Then _CboKho_0.SelectedIndex = 0
            AddMonthToCbo(Cbo)
            Command_ClickEvent(Command(0), New EventArgs())
            Text = SetFormTitle(Text)
            Label(15).Visible = (pTygia > 0)
            txtChuyen(8).Visible = (pTygia > 0)
            If pTygia > 0 Then txtChuyen(8).Text = Format(TyGiaCuoi(), Mask_0)
            LbUser.Text = UserName
            For chi_so As Integer = 1 To pSoVV
                LbTT(chi_so - 1).Visible = True
                CboVV(chi_so - 1).Visible = True
                Int_RecsetToCbo("SELECT MaSo As F2,DienGiai As F1 FROM DoituongCT" & chi_so & " ORDER BY DoituongCT" & ConvertToStrSafe(chi_so) & ".DienGiai", CboVV(chi_so - 1))
            Next
            Command(5).Visible = (pBarCode > 0 And CboKho(0).Items.Count > 1)
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
    Private Sub FrmLuuChuyen_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        taikhoan = Nothing
        taikhoan1 = Nothing
        vattu = Nothing
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdChuyen_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdChuyen.Click

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdChuyen_KeyPressEvent(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles GrdChuyen.KeyPress
        If eventArgs.KeyChar = Chr(Keys.Enter) Then GrdChuyen_ClickEvent(GrdChuyen, New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdChuyen_MouseDownEvent(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles GrdChuyen.MouseDown
        If eventArgs.Button = MouseButtons.Right Then
            SearchObj(1, , GrdChuyen, GrdChuyen.Col)
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
    '====================================================================================================
    ' Kiểm tra ngày lưu chuyển
    '====================================================================================================
    Private Sub MedNgay_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MedNgay.Leave
        Dim LoiNgayChuyen As Boolean = False
        Dim m As Integer = Ngay.Month
        Try
            LoiNgayChuyen = True
            Ngay = ConvertToDateSafe(MedNgay.Text)
            LoiNgayChuyen = False
            If Ngay.Month <> m Then
                m = Ngay.Month
                ClearGrid(GrdChuyen, ConvertToDblSafe(GrdChuyen.Tag))
                If CboSohieu.SelectedIndex >= 0 Then
                    'CboSohieu.SelectedIndex = -1
                    CboSohieu.Text = ""
                End If
            End If
        Catch excep As System.Exception
            If Not LoiNgayChuyen Then
                Throw excep
            End If
            If LoiNgayChuyen Then
                MedNgay.Focus()
            End If
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtChuyen_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtChuyen_4.Enter, _txtChuyen_2.Enter, _txtChuyen_9.Enter, _txtChuyen_8.Enter, _txtChuyen_7.Enter, _txtChuyen_6.Enter, _txtChuyen_5.Enter, _txtChuyen_3.Enter, _txtChuyen_1.Enter, _txtChuyen_0.Enter
        Dim Index As Integer = Array.IndexOf(txtChuyen, eventSender)
        txtChuyen(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtChuyen_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtChuyen_4.KeyPress, _txtChuyen_2.KeyPress, _txtChuyen_9.KeyPress, _txtChuyen_8.KeyPress, _txtChuyen_7.KeyPress, _txtChuyen_6.KeyPress, _txtChuyen_5.KeyPress, _txtChuyen_3.KeyPress, _txtChuyen_1.KeyPress, _txtChuyen_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtChuyen, eventSender)
        Select Case Index
            Case 0, 6
                If KeyAscii = 13 Then
                    flag = 1
                    Me.Cursor = Cursors.WaitCursor
                    txtChuyen(Index).Text = FrmTaikhoan.ChonTk(txtChuyen(Index).Text)
                    Me.Cursor = Cursors.Default
                    txtChuyen_Leave(txtChuyen(Index), New EventArgs())
                    If Index = 0 Then
                        txtChuyen(1).Focus()
                    Else
                        cmdct.Focus()
                    End If
                    flag = 0
                End If
            Case 1
                If KeyAscii = 13 Then
                    Me.Cursor = Cursors.WaitCursor
                    txtChuyen(1).Text = FrmVattu.ChonVattu(txtChuyen(1).Text)
                    Me.Cursor = Cursors.Default
                    txtChuyen(1).Focus()
                End If
            Case 2, 3
                KeyAscii = 0
            Case 4
                If KeyAscii = 13 Then
                    cmdct_Click(cmdct, New EventArgs())
                Else
                    KeyProcess(txtChuyen(Index), KeyAscii)
                End If
            Case 5
                If FCost And ConvertToDblSafe((txtChuyen(4).Tag)) <> 0 Then KeyAscii = 0 Else KeyProcess(txtChuyen(Index), KeyAscii)
            Case 8, 9
                KeyProcess(txtChuyen(Index), KeyAscii)
        End Select
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub

    Private Sub _txtChuyen_13_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _txtChuyen_13.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(e.KeyChar)
        If KeyAscii = 13 Then
            _txtChuyen_13.Text = Timten("ten", FrmNhanVien.ChonNV(_txtChuyen_13.Text), "SoHieu", "nhanvien")
            _txtChuyen_13.Focus()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtChuyen_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtChuyen_4.Leave, _txtChuyen_2.Leave, _txtChuyen_9.Leave, _txtChuyen_8.Leave, _txtChuyen_7.Leave, _txtChuyen_6.Leave, _txtChuyen_5.Leave, _txtChuyen_3.Leave, _txtChuyen_1.Leave, _txtChuyen_0.Leave, _txtChuyen_16.Leave, _txtChuyen_10.Leave, _txtChuyen_11.Leave, _txtChuyen_12.Leave, _txtChuyen_13.Leave, _txtChuyen_14.Leave, _txtChuyen_15.Leave
        Dim Index As Integer = Array.IndexOf(txtChuyen, eventSender)
        Dim luong, ThanhTien, tien2 As Double
        Select Case Index
            Case 0
                taikhoan.InitTaikhoanSohieu(txtChuyen(0).Text)
                If Strings.Len(txtChuyen(6).Text) = 0 Then
                    txtChuyen(6).Text = txtChuyen(0).Text
                    taikhoan.DanXuat(taikhoan1)
                End If
            Case 6
                taikhoan1.InitTaikhoanSohieu(txtChuyen(6).Text)
            Case 1
                CboDV.Visible = False
                If ConvertToDblSafe(FDsNhap.Tag) > 0 Or FrmVattu.Visible Or flag = 1 Then Exit Sub
                flag = 1
                vattu.InitVattuSohieu(txtChuyen(1).Text)
                txtChuyen(2).Text = vattu.TenVattu
                txtChuyen(3).Text = vattu.DonVi
                If Not (vattu.MaSo = 0) Then
                    If taikhoan.loai = 0 Or OutCost > 0 Then
                        FDsNhap.Tag = ConvertToStrSafe(vattu.MaSo)
                        MaNhap = FDsNhap.XuatDichDanh(Ngay.Month, vattu.sohieu & " - " & vattu.TenVattu & (" - Đ.v.t: ") & vattu.DonVi, CboKho(0).SelectedValue, luong, ThanhTien, tien2)
                        FDsNhap.Tag = "0"
                        If luong = 0 Then
                            luong = SoTonKho(Ngay.Month, CboKho(0).SelectedValue, taikhoan.maso, vattu.MaSo, ThanhTien, tien2)
                        End If
                        txtChuyen(4).Tag = ConvertToStrSafe(luong)
                        txtChuyen(5).Tag = ConvertToStrSafe(ThanhTien)
                        txtChuyen(9).Tag = ConvertToStrSafe(tien2)
                        txtChuyen(4).Text = Format(luong, Mask_2)
                        txtChuyen(5).Text = Format(ThanhTien, Mask_0)
                        txtChuyen(9).Text = Format(tien2, Mask_2)
                    Else
                        txtChuyen(4).Tag = ConvertToStrSafe(SoTonKho(Ngay.Month, CboKho(0).SelectedValue, taikhoan.maso, vattu.MaSo, ThanhTien, tien2))
                        txtChuyen(5).Tag = ConvertToStrSafe(ThanhTien)
                        txtChuyen(4).Text = Format(ConvertToStrSafe(txtChuyen(4).Tag), Mask_2)
                        txtChuyen(5).Text = Format(ThanhTien, Mask_0)
                        txtChuyen(9).Tag = ConvertToStrSafe(tien2)
                        txtChuyen(9).Text = Format(tien2, Mask_2)
                    End If
                    If OutCost = 0 And vattu.Dvt2 > 0 Then
                        Int_RecsetToCbo("SELECT MaSo AS F2, DonVi AS F1 FROM DVTVattu WHERE MaVattu=" & vattu.MaSo & " ORDER BY DonVi", CboDV)
                        CboDV.Items.Insert(0, vattu.DonVi)
                        If CboDV.Items.Count > 0 Then
                            CboDV.SelectedIndex = 0
                            CboDV.Visible = True
                            CboDV.Focus()
                        End If

                    Else
                        txtChuyen(4).Focus()
                    End If
                End If
                flag = 0
            Case 4
                If ConvertToDblSafe((txtChuyen(4).Tag)) <= 0 Then
                    Exit Sub
                End If
                If pGiaUSD > 0 Then
                    luong = (ConvertToDblSafe(txtChuyen(4).Text) * ConvertToDblSafe((txtChuyen(9).Tag))) / ConvertToDblSafe((txtChuyen(4).Tag))
                    txtChuyen(9).Text = Format(luong, Mask_2)
                    txtChuyen(5).Text = Format(luong * ConvertToDblSafe(txtChuyen(8).Text), Mask_0)
                Else
                    txtChuyen(5).Text = Format((ConvertToDblSafe(txtChuyen(4).Text) * ConvertToDblSafe((txtChuyen(5).Tag))) / ConvertToDblSafe((txtChuyen(4).Tag)), Mask_0)
                End If
            Case 7
                If Strings.Len(txtChuyen(7).Text) = 0 Then txtChuyen(7).Text = "..."
        End Select
        HienThongBao("", 1)
    End Sub
    '====================================================================================================
    ' Thủ tục kiểm tra phiếu lưu chuyển có hợp lệ ?
    '====================================================================================================
    Private Function KiemTraPhieu() As Boolean
        Dim result As Boolean = False
        If Strings.Len(txtChuyen(7).Text) = 0 Then txtChuyen(7).Text = "..."
        If Strings.Len(CboSohieu.Text) = 0 Then
            MessageBox.Show(Ngonngu("Thiếu số hiệu phiếu lưu chuyển !", "Missing number of movement votes"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CboSohieu.Focus()
            Return result
        End If
        If CboSohieu.SelectedIndex >= 0 Then
            If ConvertToDblSafe(GetSelectValue("SELECT DISTINCT Count(MaSo) AS F1 FROM ChungTu WHERE SoHieu like '" & CboSohieu.Text & "' AND MaCT<>" & ConvertToStrSafe(CboSohieu.SelectedValue))) > 0 Then
                ErrMsg(er_SHChTu)
                CboSohieu.Focus()
            End If
        End If
        If CboKho(0).SelectedIndex < 0 Then
            ErrMsg(er_KhoHang)
            CboKho(1).Focus()
            Return result
        End If
        GrdChuyen.Row = 0
        GrdChuyen.Col = 0
        If Strings.Len(GrdChuyen.CtlText) = 0 Then
            MessageBox.Show(Ngonngu("Hãy nhập chi tiết lưu chuyển !", "Enter information movement"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtChuyen(0).Focus()
            Return result
        End If
        If User_Right <> 0 Then
            If ConvertToDblSafe(GetSelectValue("SELECT Lock" & Cbo.SelectedValue & " % 10 AS F1 FROM License")) > 0 Then
                MessageBox.Show(Ngonngu("Tháng đã bị khoá không cho nhập số liệu!", "This month is closed, not imported"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return result
            End If
        End If
        Return True
    End Function
    '======================================================================================
    ' Thủ tục xóa phiếu trên màn hình
    '======================================================================================
    Private Sub XoaPhieuTrenManHinh()
        'CboSohieu.SelectedIndex = -1
        CboSohieu.Text = ""
        ClearGrid(GrdChuyen, ConvertToDblSafe(GrdChuyen.Tag))
        txtChuyen(0).Text = ""
        txtChuyen(1).Text = ""
        txtChuyen(2).Text = ""
        txtChuyen(3).Text = "0"
        txtChuyen(4).Text = "0"
        txtChuyen(5).Text = "0"
        txtChuyen(6).Text = ""
        txtChuyen(9).Text = ""

        txtChuyen(10).Text = ""
        txtChuyen(11).Text = ""
        txtChuyen(12).Text = ""
        txtChuyen(13).Text = ""
        txtChuyen(14).Text = ""
        txtChuyen(15).Text = ""

        LbTien.Text = ""
        vattu.InitVattuMaSo(0)
        taikhoan.InitTaikhoanMaSo(0)
        taikhoan1.InitTaikhoanMaSo(0)
        MaNhap = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function tongtien() As Double
        Dim result As Double = 0
        With GrdChuyen
            For i As Integer = 0 To .Rows - 1
                .Col = 0
                .Row = i
                If .CtlText.length = 0 Then Exit For
                .Col = 5
                result += ConvertToDblSafe(.CtlText)
            Next
        End With
        LbTien.Text = Format(result, Mask_0)
        Return result
    End Function
    Private Sub LayXuatKho()
        Dim id As Double
        Dim FileNum As Integer
        Dim BytesNeeded, Buffers, mtk, i, ms, mv As Integer
        Dim shtk = String.Empty, st = String.Empty, st2 As String = String.Empty
        Dim j As Integer
        Dim sl, luong, tien, T As Double
        Dim Buffer(32) As Byte
        If FileSystem.Dir(pCurDir & "DOWNLOAD.EXE", FileAttribute.Normal).Length = 0 Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        Directory.SetCurrentDirectory(Strings.Left(pCurDir, pCurDir.Length - 1))
        Recycle(pCurDir & "\temp\BARCODE.FIL")
        On Error GoTo E
        Dim startInfo As ProcessStartInfo = New ProcessStartInfo(pCurDir & "DOWNLOAD.EXE")
        startInfo.WindowStyle = ProcessWindowStyle.Maximized
        id = Process.Start(startInfo).Id
        On Error GoTo 0
        Do While bcstop = 0
            AppIdle(1000)
            i += 1
            If FileSystem.Dir(pCurDir & "\temp\BARCODE.FIL", FileAttribute.Normal).Length > 0 Or i > 10000 Then Exit Do
        Loop
        bcstop = 0
        If FileSystem.Dir(pCurDir & "\temp\BARCODE.FIL", FileAttribute.Normal).Length = 0 Then GoTo kt
        XoaPhieuTrenManHinh()
        FileNum = FileSystem.FreeFile()
        FileSystem.FileOpen(FileNum, pCurDir & "\temp\BARCODE.FIL", OpenMode.Binary)
        BytesNeeded = FileSystem.LOF(FileNum)
        Buffers = BytesNeeded \ 32
        For i = 0 To Buffers - 1
            FileSystem.FileGet(FileNum, Buffer, -1)
            If i = 0 Then
                st = ""
                For j = 0 To 9
                    st = st & Chr(Buffer(j)).ToString()
                Next
                If Information.IsDate(st) Then
                    Ngay = ConvertToDateSafe(st)
                    MedNgay.Text = Format(Ngay, Mask_D)
                End If
            End If
            st = ""
            j = 10
            Do While Buffer(j) <> 32 And j < 32
                If Buffer(j) <> 42 Then st = st & Chr(Buffer(j)).ToString()
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
                        shtk = ConvertToStrSafe(GetSelectValue("SELECT HethongTK.Sohieu AS F1 FROM TonKho INNER JOIN HethongTK ON TonKho.MaTaiKhoan=HethongTK.MaSo WHERE MaVattu=" & vattu.MaSo & " AND MaSoKho=" & ConvertToStrSafe(CboKho(0).SelectedValue)))
                        Do While SoHieu2MaSo(shtk, "HethongTK") = 0
                            shtk = FrmGetStr.GetString(Ngonngu("Số hiệu tài khoản ghi có:", "Credited to account number"), Ngonngu("Phiếu xuất kho", "Bill"))
                            If ConvertToDblSafe(GetSelectValue("SELECT TK_ID AS F1 FROM HethongTK WHERE TKCon=0 AND Sohieu='" & shtk & "'")) <> TKVT_ID Then shtk = "0"
                        Loop
                    End If
                    txtChuyen(0).Text = shtk
                    txtChuyen(6).Text = shtk
                    txtChuyen(1).Text = vattu.sohieu
                    txtChuyen_Leave(txtChuyen(0), New EventArgs())
                    txtChuyen_Leave(txtChuyen(6), New EventArgs())
                    txtChuyen_Leave(txtChuyen(1), New EventArgs())
                    txtChuyen(4).Text = Format(luong, Mask_2)
                    txtChuyen_Leave(txtChuyen(4), New EventArgs())
                    cmdct_Click(cmdct, New EventArgs())
                End If
            End If
        Next
        FileSystem.FileClose(FileNum)
        Me.Cursor = Cursors.Default
        Exit Sub
E:
        MessageBox.Show(Information.Err().Description, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
kt:
        Me.Cursor = Cursors.Default
    End Sub
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(1).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        Command(2).Enabled = (User_Right <> 2 Or (UserID = uid))
        If User_Right <> 0 Then
            If ConvertToDblSafe(GetSelectValue("SELECT Lock" & Cbo.SelectedValue & " % 10 AS F1 FROM License")) > 0 Then
                Command(1).Enabled = False
                Command(2).Enabled = False
            End If
        End If
    End Sub

    Private Sub GrdChuyen_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrdChuyen.DoubleClick
        'SendKeys.SendWait("{Home}")
        SetGridIndex(GrdChuyen, GrdChuyen.Row)
        With GrdChuyen
            .Col = 0
            If .CtlText.length = 0 Then Exit Sub
            txtChuyen(0).Text = .CtlText
            .Col = 1
            txtChuyen(1).Text = .CtlText
            txtChuyen_Leave(txtChuyen(0), New EventArgs())
            txtChuyen_Leave(txtChuyen(1), New EventArgs())
            .Col = 13
            If vattu.Dvt2 > 0 Then SetListIndex(CboDV, ConvertToDblSafe(.CtlText))
            For i As Integer = 2 To 5
                .Col = ConvertToDblSafe(i)
                txtChuyen(i).Text = .CtlText
            Next
            .Col = 14
            txtChuyen(9).Text = .CtlText
            .Col = 10
            MaNhap = ConvertToDblSafe(.CtlText)
            .Col = 11
            SetListIndex(CboKho(1), ConvertToDblSafe(.CtlText))
            .Col = 7
            taikhoan1.InitTaikhoanSohieu(.CtlText)
            txtChuyen(6).Text = .CtlText
            .RemoveItem(.Row)
            If .Rows < ConvertToDblSafe(.Tag) Then .Rows = ConvertToDblSafe(.Tag)
            .Col = 0
            tongtien()
            txtChuyen(0).Focus()
        End With
    End Sub
    Public Shared Ma_CT As String = ""
    Public Shared Ma_Kho As String = ""
    Public Shared Ma_kho_xuat As String = ""
    Public Shared DonGia As Double = 0
    Public Shared ThanhTien As Double = 0
    Public Shared SoHieu As String = ""
    Public Shared ngay_1 As String = ""
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        'FrmIN.loai_hd = 2
        'ngay_1 = MedNgay.Text
        'Ma_Kho = _CboKho_0.SelectedText
        'Ma_CT = CboSohieu.SelectedValue
        'SoHieu = CboSohieu.Text
        'Ma_kho_xuat = _CboKho_1.Text
        'LayDuLieu()
        'FrmIN.loai_ = 1
        'IF0005.ShowDialog()
        'FrmIN.loai_ = 0
    End Sub
End Class
