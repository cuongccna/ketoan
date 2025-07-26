Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Globalization
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmThanhPham
    Dim formLoaded As Boolean = False
    Dim ThangHt As String
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
    Private _m As Cls154 = Nothing
    Property m() As Cls154
        Get
            If _m Is Nothing Then
                _m = New Cls154()
            End If
            Return _m
        End Get
        Set(ByVal Value As Cls154)
            _m = Value
        End Set
    End Property
    Dim f1 As Integer
    Dim shct As String = String.Empty
    Dim flag As Integer
    Dim ktra As Integer
    Dim nvldk, ncdk, ddck, dddk, sxcdk, tiendk As Double
    Dim MaSo As Integer

    ''' <summary>
    ''' Chuẩn bị phiếu lưu chuyển
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboKho_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _CboKho_1.SelectedIndexChanged, _CboKho_0.SelectedIndexChanged
        Dim Index As Integer = Array.IndexOf(CboKho, eventSender)
        If Index = 0 Then
            ClearGrid(Grd, ConvertToDblSafe(Grd.Tag))
            If CboSohieu.SelectedIndex >= 0 Then
                'CboSohieu.SelectedIndex = -1
                CboSohieu.Text = ""
            End If
        End If
    End Sub

    ' Hiển thị phiếu được chọn

    Private Sub CboSohieu_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboSohieu.SelectedValueChanged
        Dim rs As DataTable, i As Integer, tt As Double, dgia As Double, k As Integer
        Dim nvl As Double, nC As Double, sxc As Double, sxcn As Double
        Dim soluong As Double, Gtpl As Double

        If CboSohieu.SelectedIndex < 0 Or flag = 1 Then Exit Sub
        flag = 1
        k = CboSohieu.SelectedIndex
        ClearGrid(Grd, Grd.tag)

        rs = New DataTable
        rs = ExecSQLReturnDT("SELECT ThanhPham.*,Vattu.SoHieu AS SHVT,TenVattu,DonVi,HethongTK.SoHieu AS SHTK FROM (ThanhPham INNER JOIN Vattu ON ThanhPham.MaTP=Vattu.MaSo) INNER JOIN HethongTK ON ThanhPham.MaTK=HethongTK.MaSo WHERE ThanhPham.SoHieu='" + CboSohieu.Text + "' AND Thang=" + CStr(CboThang.SelectedValue) + " order by matp")
        If rs.Rows.Count = 0 Then GoTo kt
        SetListIndex(CboThang, rs.Rows(0)("thang"))
        SetListIndex(CboKho(0), rs.Rows(0)("MaKhoTP"))
        SetListIndex(CboKho(1), rs.Rows(0)("MaKhoNVL"))
        txtShTk(0).Tag = rs.Rows(0)("MaTKSX")
        txtShTk(1).Tag = rs.Rows(0)("MaTKCP")
        txtShTk(2).Tag = rs.Rows(0)("MaTKNC")
        If rs.Rows(0)("Ma154") > 0 Then
            m.InitTPMaSo(rs.Rows(0)("Ma154"))
            TxtCT.Text = m.SoHieu
            LbCT.Text = m.TenVattu
        End If
        For i = 0 To 2
            taikhoan.InitTaikhoanMaSo(txtShTk(i).tag)
            txtShTk(i).Text = taikhoan.SoHieu
            LbTenTk(i).Text = taikhoan.ten
        Next
        Ngay = rs.Rows(0)("Ngay")
        MedNgay.Text = Format(Ngay, Mask_D)
        Chk.Checked = rs.Rows(0)("xk") = 1
        Dim phantram As Double
        phantram = ConvertToDblSafe(Timten("mathuchi", CStr(rs.Rows(0)("MaCT") + 610000000), "ct_id", "chungtu"))
        On Error GoTo Loi
        If rs.Rows.Count > 0 Then txtShTk(3).Text = IIf(phantram <> 1 And phantram <> 0, phantram * 100 - 100, 0)
Loi:
        For Each rsitem As DataRow In rs.Rows
            tt = IIf(pDTTP = 0 And pGiaHT = 0, rsitem("CPNVL") + rsitem("cpnc") + rsitem("cpsxc"), rsitem("GiaThanh"))
            If rsitem("soluong") <> 0 Then dgia = Fix(0.5 + Mask_N * tt / rsitem("soluong")) / Mask_N Else dgia = 0
            soluong = IIf(Len(rsitem("TyLe")) <> 0, rsitem("soluong") * rsitem("TyLe") / (100 - rsitem("TyLe")), 0)
            Grd.AddItem(rsitem("shtk") + Chr(9) + rsitem("shvt") + Chr(9) + rsitem("TenVattu") + Chr(9) + rsitem("DonVi") + Chr(9) + Format(rsitem("soluong"), Mask_2) + Chr(9) + Format(dgia, Mask_2) + Chr(9) + Format(tt, Mask_0) + Chr(9) + CStr(rsitem("MaTK")) + Chr(9) + CStr(rsitem("MaTP")) + Chr(9) + CStr(rsitem("CPNVL")) + Chr(9) + CStr(rsitem("cpnc")) + Chr(9) + CStr(rsitem("cpsxc")) _
            + Chr(9) + IIf(Len(rsitem("PLTH")) <> 0, rsitem("PLTH"), "") + Chr(9) + Format(rsitem("TyLe"), Mask_0) + Chr(9) + Format(rsitem("dongia"), Mask_2) + Chr(9) + Format(soluong, Mask_2) + Chr(9) + Format(rsitem("dongia") * soluong, Mask_2) + Chr(9) + Format(rsitem("NVLPL"), Mask_0) + Chr(9) + Format(rsitem("dddk"), Mask_2) + Chr(9) + Format(rsitem("phantramdk"), Mask_0) + Chr(9) + Format(rsitem("ddck"), Mask_2) + Chr(9) + Format(rsitem("phantramck"), Mask_0) + Chr(9) + CStr(rsitem("MaPhanLoai")) + Chr(9) + CStr(GetSelectValue("select sum(cpsxcn)as f1 from thanhpham where thang=" + CStr(rsitem("thang")) + " and maphanloai=" + CStr(rsitem("MaPhanLoai")))) + Chr(9) + Format(rsitem("cpsxcn"), Mask_2), 0)
            nvl = nvl + rsitem("CPNVL")
            nC = nC + rsitem("cpnc")
            sxc = sxc + rsitem("cpsxc")
            sxcn = sxcn + rsitem("cpsxcn")
        Next

        vattu.InitVattuMaSo(0)
        taikhoan.InitTaikhoanSohieu(txtChuyen(0).Text)
kt:
        LbGia(0).Text = Format(nvl, Mask_0)
        LbGia(1).Text = Format(nC, Mask_0)
        LbGia(2).Text = Format(sxc, Mask_0)
        LbGia(3).Text = Format(sxcn, Mask_0)
        CboSohieu.SelectedIndex = k
        flag = 0
        Command(8).Enabled = True
    End Sub

    Private Sub CboSohieu_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboSohieu.Leave
        Dim L As Integer
        If CboSohieu.SelectedIndex < 0 Then
            CboSohieu.Text = CboSohieu.Text.ToUpper()
            If Strings.Len(CboSohieu.Text) > 0 Then
                L = Strings.Len(CboSohieu.Text)
                If L > 0 Then
                    If Not IsNumeric(CboSohieu.Text) Then
                        shct = ConvertToStrSafe(GetSelectValue(String.Format("SELECT TOP 1 SoHieu AS F1 FROM ThanhPham WHERE Len(SoHieu)>{0} AND IsNumeric(Right(SoHieu,Len(SoHieu)-{1})) AND SoHieu LIKE'{2}%' AND Thang={3} ORDER BY SoHieu DESC", _
                                                                   L, _
                                                                   ConvertToStrSafe(L), _
                                                                   CboSohieu.Text, _
                                                                   ConvertToStrSafe(CboThang.SelectedValue))))
                        If shct <> "0" Then CboSohieu.Text = SHCtuMoi(shct)
                    End If
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
    Private Sub Chk_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Chk.CheckStateChanged
        If Chk.Checked = True Then
            _CboKho_1.Enabled = True
        Else
            _CboKho_1.Enabled = False
        End If
    End Sub
    ''' <summary>
    ''' Thêm, sửa, xóa phiếu lưu chuyển
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_4.Click, _Command_5.Click, _Command_6.Click, _Command_2.Click, _Command_3.Click, _Command_1.Click, _Command_0.Click, _Command_7.Click, _Command_8.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim CboSohieu_NewIndex As Integer = -1
        Dim Chungtu As New ClsChungtu
        Dim sh As String = String.Empty
        Dim DaNhap As Integer
        Dim m1 As New Cls154
        Dim mvt, MaCT, mtk As Integer
        Dim i As Integer
        Dim luong, tien, sxc, nvl, nC, dgia As Double
        Dim n As Date
        Dim PLTH As String = String.Empty
        Dim TL, NVLPL, dongia As Double
        Dim makt, maktct As String
        Dim laymasocttren, laymaktcttren As Integer
        Dim sua As Boolean
        Dim phantramdk, phantramck As Double
        Me.Cursor = Cursors.WaitCursor
        Dim thang As Integer = CboThang.SelectedValue
        Ngay = ConvertToDateSafe(MedNgay.Text)
        Dim MaPhanLoai As Integer, sxcn As Double
        Dim sxcndk As Double, NVLPhanTram As Double
        Dim rs As DataTable

        Select Case Index
            Case 0
                XoaPhieuTrenManHinh()
                Grd.Row = 0
                Command_ClickEvent(CboThang, New EventArgs())
                If pGiaHT > 0 Then
                    mtk = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM ThanhPham WHERE Thang={0} AND Ma154={1}", _
                                                              thang, _
                                                              ConvertToStrSafe(m.MaSo))))
                    If mtk > 0 Then
                        SetListIndex(CboSohieu, mtk)
                    Else
                        LietKeTP()
                    End If
                Else
                    If shct.Length > 0 Then CboSohieu.Text = SHCtuMoi(shct)
                    CboSohieu.Focus()
                End If
                Khoaquyen()
            Case 1
                Me.Refresh()
                If Not KiemTraPhieu() Then GoTo XongLC
                sh = CboSohieu.Text
                makt = ""
                maktct = ""
                If CboSohieu.SelectedIndex >= 0 Then
                    sua = True
                    i = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 Thang AS F1,Ma154 AS F2 FROM ThanhPham WHERE MaCT={0}", CboSohieu.SelectedValue), mtk))
                    n = ConvertToDateSafe(GetSelectValue(String.Format("SELECT TOP 1 Ngay AS F1 FROM ThanhPham WHERE MaCT={0}", CboSohieu.SelectedValue)))

                    ExecSQLNonQuery(String.Format("UPDATE ThanhPhamDD set makt=0 WHERE left(makt,len({0}))={1} and ngay=(SELECT max(ngay) FROM thanhphamdd WHERE left(makt,len({1}))={1} and ngay<='{2}')", _
                                        CboSohieu.SelectedValue, _
                                        ConvertToStrSafe(CboSohieu.SelectedValue), _
                                        Format(Ngay, Mask_DB)))

                    Dim s As Integer = ExecSQLNonQuery(String.Format("DELETE  FROM ThanhPham WHERE MaCT={0}", CboSohieu.SelectedValue))
                    makt = ConvertToStrSafe(GetSelectValue(String.Format("SELECT makt as f1,mact as f2 FROM thanhphamdd WHERE MaCT={0}", CboSohieu.SelectedValue), maktct))
                    ExecSQLNonQuery(String.Format("DELETE  FROM ThanhPhamDD WHERE MaCT={0}", CboSohieu.SelectedValue))
                    XoaCTTheoID(i, 610000000 + CboSohieu.SelectedValue, 0, n, n)
                    CboSohieu.Items.ItemsBase.RemoveAt(ConvertToDblSafe(CboSohieu.SelectedIndex))
                Else
                    n = Ngay
                End If
                Dim flag As Integer = 0
                If Chk.Checked = True Then
                    flag = 1
                Else
                    flag = 0
                End If
                f1 = 1
                CboThang_SelectedValueChanged(CboThang, New EventArgs())
                themchiphinhomvaoLabel(thang)
                f1 = 0
                GiaBQ(ConvertToDblSafe((ConvertToDblSafe(maktct))))
                If ConvertToDblSafe(maktct) > 0 Then
                    MaCT = ConvertToDblSafe(maktct)
                Else
                    MaCT = Lng_MaxValue("MaCT", "ThanhPham") + 1
                End If
                With Grd
                    For i = 0 To .Rows - 1
                        .Row = i
                        .Col = 7
                        If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit For
                        mtk = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 8
                        mvt = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 4
                        luong = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 6
                        tien = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 9
                        nvl = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 10
                        nC = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 11
                        sxc = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 22
                        MaPhanLoai = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 24
                        sxcn = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 12
                        PLTH = .Items(.Row).SubItems(.Col).Text
                        .Col = 17
                        NVLPL = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 13
                        TL = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 14
                        dongia = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 20
                        ddck = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 21
                        phantramck = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        .Col = 26
                        NVLPhanTram = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                        dddk = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(SoLuong) as f1,sum(CPNC) as f2,sum(CPSXC) as f3,sum(CPNVL) as f4,sum(giathanh) as f5,sum(phantram) as f6,sum(CPSXCN) as f7 FROM thanhphamdd WHERE makt = {0}{1} group by ngay", _
                                                                   maktct, _
                                                                   ConvertToStrSafe(mvt)), ncdk, sxcdk, nvldk, tiendk, phantramdk, sxcndk))
                        If dddk = 0 Then dddk = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(SoLuong) as f1,sum(CPNC) as f2,sum(CPSXC) as f3,sum(CPNVL) as f4,sum(giathanh) as f5,sum(phantram) as f6,sum(CPSXCN) as f7 FROM thanhphamdd WHERE {0} makt=0 and matp={1} and makhonvl={2} and ngay=(SELECT max(ngay) FROM thanhphamdd WHERE {0} makt=0 and matp={1} and ngay<='{3}' and makhonvl={2}) group by mact order by mact desc", _
                                                                                    (IIf(ConvertToDblSafe(maktct) > 0, String.Format("mact<{0} and", maktct), String.Empty)), _
                                                                                    ConvertToStrSafe(mvt), _
                                                                                    ConvertToStrSafe(CboKho(1).SelectedValue), _
                                                                                    Format(CDate(Ngay), Mask_DB)), ncdk, sxcdk, nvldk, tiendk, phantramdk, sxcndk))
                        If sua Then
                            If dddk = 0 Then dddk = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(SoLuong) as f1,sum(CPNC) as f2,sum(CPSXC) as f3,sum(CPNVL) as f4,sum(giathanh) as f5,sum(phantram) as f6,sum(CPSXCN) as f7 FROM thanhphamdd WHERE makt=0 and matp={0} and makhonvl={1} and ngay=(SELECT max(ngay) FROM thanhphamdd WHERE makt=0 and matp={2} and ngay<'{3}' and makhonvl={1}) group by mact order by mact", _
                                                                                        mvt, _
                                                                                        ConvertToStrSafe(CboKho(1).SelectedValue), _
                                                                                        ConvertToStrSafe(mvt), _
                                                                                        Format(CDate(Ngay), Mask_DB)), ncdk, sxcdk, nvldk, tiendk, phantramdk, sxcndk))
                            If dddk = 0 Then dddk = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(SoLuong) as f1,sum(CPNC) as f2,sum(CPSXC) as f3,sum(CPNVL) as f4,sum(giathanh) as f5,sum(phantram) as f6,sum(CPSXCN) as f7 FROM thanhphamdd WHERE sohieu<='{0}' and makt=0 and matp={1} and makhonvl={2} and ngay=(SELECT max(ngay) FROM thanhphamdd WHERE makt=0 and matp={1} and ngay<='{3}' and makhonvl={2}) group by mact order by mact", _
                                                                                        CboSohieu.Text, _
                                                                                        ConvertToStrSafe(mvt), _
                                                                                        ConvertToStrSafe(CboKho(1).SelectedValue), _
                                                                                        Format(CDate(Ngay), Mask_DB)), ncdk, sxcdk, nvldk, tiendk, phantramdk, sxcndk))
                        Else
                            If dddk = 0 Then dddk = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(SoLuong) as f1,sum(CPNC) as f2,sum(CPSXC) as f3,sum(CPNVL) as f4,sum(giathanh) as f5,sum(phantram) as f6,sum(CPSXCN) as f7 FROM thanhphamdd WHERE matp={0} and makhonvl={1} and ngay=(SELECT max(ngay) FROM thanhphamdd WHERE matp={2} and ngay<='{3}' and makhonvl={1}) group by mact order by mact desc", _
                                                                                        mvt, _
                                                                                        ConvertToStrSafe(CboKho(1).SelectedValue), _
                                                                                        ConvertToStrSafe(mvt), _
                                                                                        Format(CDate(Ngay), Mask_DB)), ncdk, sxcdk, nvldk, tiendk, phantramdk, sxcndk))
                        End If
                        If luong + ddck < dddk Then
                            MessageBox.Show(Ngonngu("Số lượng nhập trong tháng + số lượng cuối kỳ < số lượng đầu kỳ", "Quantity enter of month + Quantity final < Quantity beginning"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If MaCT > 0 Then
                                ExecSQLNonQuery(String.Format("UPDATE ThanhPhamDD set makt=0 WHERE left(makt,len({0}))={1} and ngay=(SELECT max(ngay) FROM thanhphamdd WHERE left(makt,len({1}))={1} and ngay<='{2}')", MaCT, ConvertToStrSafe(MaCT), Format(Ngay, Mask_DB)))
                                ExecSQLNonQuery(String.Format("DELETE  FROM ThanhPham WHERE MaCT={0}", MaCT))
                                ExecSQLNonQuery(String.Format("DELETE  FROM ThanhPhamDD WHERE MaCT={0}", MaCT))
                            End If
                            GoTo XongLC
                        End If
                        laymaktcttren = 0
                        If dddk >= 0 Then
                            Dim RecordsAffectedCount As Integer = ExecSQLNonQueryUpdateInsertDeleteQuery((String.Format("UPDATE thanhphamdd set makt={0}{1} WHERE {2} makt=0 and matp={1} and makhonvl={3} and ngay=(SELECT max(ngay) FROM thanhphamdd WHERE {2} makt=0 and matp={1} and makhonvl={3} and ngay<='{4}')", _
                                                                                         MaCT, _
                                                                                         ConvertToStrSafe(mvt), _
                                                                                         (IIf(ConvertToDblSafe(maktct) > 0, String.Format("mact<{0} and", maktct), String.Empty)), _
                                                                                         ConvertToStrSafe(CboKho(1).SelectedValue), _
                                                                                         Format(CDate(Ngay), Mask_DB))))
                            If RecordsAffectedCount <= 0 And Not sua Then
                                laymasocttren = ConvertToDblSafe(GetSelectValue(String.Format("SELECT maso1 as f1,makt as f2 FROM thanhphamdd WHERE matp={0} and makhonvl={1} and ngay=(SELECT max(ngay) FROM thanhphamdd WHERE matp={2} and makhonvl={1} and ngay<='{3}') order by ngay desc", _
                                                                                    mvt, _
                                                                                    ConvertToStrSafe(CboKho(1).SelectedValue), _
                                                                                    ConvertToStrSafe(mvt), _
                                                                                    Format(CDate(Ngay), Mask_DB)), laymaktcttren))
                                ExecSQLNonQuery(String.Format("UPDATE thanhphamdd set makt={0}{1} WHERE maso1={2}", _
                                                    MaCT, _
                                                    ConvertToStrSafe(mvt), _
                                                    ConvertToStrSafe(laymasocttren)))
                                If ConvertToStrSafe(laymaktcttren).Length > 1 Then
                                    ExecSQLNonQuery(String.Format("UPDATE thanhpham set dddk={0} WHERE mact={1} and matp={2}", _
                                                        ddck, _
                                                        Strings.Left(ConvertToStrSafe(laymaktcttren), ConvertToStrSafe(laymaktcttren).Length - ConvertToStrSafe(mvt).Length), _
                                                        ConvertToStrSafe(mvt)))
                                End If
                            Else
                                Dim a As Integer = ExecSQLNonQuery((String.Format("UPDATE thanhphamdd set makt={0}{1} WHERE sohieu<'{2}' and makt=0 and matp={1} and makhonvl={3} and ngay=(SELECT max(ngay) FROM thanhphamdd WHERE makt=0 and matp={1} and makhonvl={3} and ngay<='{4}')", _
                                                     MaCT, _
                                                     ConvertToStrSafe(mvt), _
                                                     CboSohieu.Text, _
                                                     ConvertToStrSafe(CboKho(1).SelectedValue), _
                                                     Format(CDate(Ngay), Mask_DB))))
                            End If
                        End If
                        If TruongDaCo("ThanhPham", "NVLPL") Then
                            ExecSQLNonQuery("alter table ThanhPham alter column NVLPL  Money NULL")
                        Else
                            MessageBox.Show(Ngonngu("Vui lòng cập nhật cơ sở dữ liệu!", "Please update database!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        dgia = IIf(luong <> 0, tien / luong, 0)
                        Dim haohut As Double = (1 + txtShTk(3).Text / 100)
                        Dim str As String = "INSERT INTO ThanhPhamDD (MaSo,MaCT,Thang,SoHieu,Ngay,MaKhoTP,MaKhoNVL,MaTK,MaTP,SoLuong,MaTKCP,MaTKNC,MaTKSX,Ma154,GiaThanh,CPNVL,CPNC,CPSXC,XK,PLTH,NVLPL,Tyle,Dongia,makt,phantram,maphanloai,cpsxcn) VALUES (" + CStr(Lng_MaxValue("MaSo", "ThanhPham") + 1) + "," + CStr(MaCT) + "," + CStr(thang) _
                                + ",'" + sh + "','" + Format(Ngay, Mask_DB) + "'," + CStr(CboKho(0).SelectedValue) + "," + CStr(CboKho(1).SelectedValue) _
                                + "," + CStr(mtk) + "," + CStr(mvt) + "," + doidau(ddck) + "," + CStr(txtShTk(1).Tag) + "," + CStr(txtShTk(2).Tag) + "," + CStr(txtShTk(0).Tag) + "," + CStr(m.MaSo) + "," + doidau(tien) + "," + doidau(NVLPhanTram * haohut) + "," + doidau(nC * NVLPhanTram / IIf(nvl + nvldk > 0, nvl + nvldk, 1)) + "," + doidau(sxc * NVLPhanTram / IIf(nvl + nvldk > 0, nvl + nvldk, 1)) + "," + CStr(IIf(Chk.Checked = True, 1, 0)) + ",'" + PLTH + "'," + doidau(NVLPL) + "," + doidau(TL) + "," + doidau(dongia) + "," + CStr(IIf(ConvertToDblSafe(makt) > 0 And dddk > 0, ConvertToDblSafe(makt), laymaktcttren)) + "," + doidau(phantramck) + "," + CStr(MaPhanLoai) + "," + doidau(sxcndk) + ")"
                        ExecSQLNonQuery(str)
                        str = "INSERT INTO ThanhPham (MaSo,MaCT,Thang,SoHieu,Ngay,MaKhoTP,MaKhoNVL,MaTK,MaTP,SoLuong,MaTKCP,MaTKNC,MaTKSX,Ma154,GiaThanh,CPNVL,CPNC,CPSXC,XK,PLTH,NVLPL,Tyle,Dongia,dddk,ddck,phantramdk,phantramck,maphanloai,cpsxcn) VALUES (" + CStr(Lng_MaxValue("MaSo", "ThanhPham") + 1) + "," + CStr(MaCT) + "," + CStr(thang) _
                            + ",'" + sh + "','" + Format(Ngay, Mask_DB) + "'," + CStr(CboKho(0).SelectedValue) + "," + CStr(CboKho(1).SelectedValue) _
                            + "," + CStr(mtk) + "," + CStr(mvt) + "," + doidau(luong) + "," + CStr(txtShTk(1).Tag) + "," + CStr(txtShTk(2).Tag) + "," + CStr(txtShTk(0).Tag) + "," + CStr(m.MaSo) + "," + doidau(tien) + "," + doidau(nvl) + "," + doidau(nC + ncdk - (nC * NVLPhanTram / IIf(nvl + nvldk > 0, nvl + nvldk, 1))) + "," + doidau(sxc + sxcdk - (sxc * NVLPhanTram / IIf(nvl + nvldk > 0, nvl + nvldk, 1))) + "," + CStr(IIf(Chk.Checked = True, 1, 0)) + ",'" + PLTH + "'," + doidau(NVLPL) + "," + doidau(TL) + "," + doidau(dongia) + "," + doidau(dddk) + "," + doidau(ddck) + "," + doidau(phantramdk) + "," + doidau(phantramck) + "," + CStr(MaPhanLoai) + "," + doidau(sxcn) + ")"
                        ExecSQLNonQuery(str)
                        If pGiaHT > 0 Then DieuChinhGiaTP(thang, m.MaSo, mtk, mvt, dgia, tien)
                    Next
                End With

                CboSohieu.Items.Add(sh, MaCT)

                m.DanXuat(m1)
                shct = Chungtu.SoHieu
                Command_ClickEvent(Command(0), New EventArgs())
                DaNhap = 1
            Case 2
                If CboSohieu.SelectedIndex >= 0 Then
                    MaCT = CboSohieu.SelectedValue
                    If pGiaHT > 0 Then DatLaiGiaHT(MaCT)
                    ExecSQLNonQuery(String.Format("DELETE FROM ThanhPham WHERE MaCT={0}", MaCT))
                    makt = ConvertToStrSafe(GetSelectValue(String.Format("SELECT makt as f1 FROM thanhphamdd WHERE mact={0}", MaCT)))
                    ExecSQLNonQuery(String.Format("UPDATE ThanhPhamDD set makt={0} WHERE left(makt,len({1}))={1} and ngay=(SELECT max(ngay) FROM thanhphamdd WHERE left(makt,len({1}))={1} and ngay<='{2}')", _
                                        makt, _
                                        ConvertToStrSafe(MaCT), _
                                        Format(CDate(Ngay), Mask_DB)))
                    ExecSQLNonQuery(String.Format("DELETE FROM ThanhPhamDD WHERE MaCT={0}", MaCT))
                    CboSohieu.Items.ItemsBase.RemoveAt(ConvertToDblSafe(CboSohieu.SelectedIndex))
                    DaNhap = 1
                End If
                m.DanXuat(m1)
                XoaPhieuTrenManHinh()
                Grd.Row = 0
            Case 3
                Me.Close()
                Exit Sub
            Case 4
                XemDD()
            Case 5
                InNVL()
            Case 6
                UpdateBaoCaoCP2Table()
                TheGiaThanh()
            Case 7
                Command(7).Tag = "1"
                FrmDinhmuc.ShowDialog()
            Case 8
                Command(8).Enabled = False
                MaPhanLoai = GetSelectValue("select maso as f1 from tp154 where sohieu='THTP'")
                rs = New DataTable
                rs = ExecSQLReturnDT("select mact from chungtu where matp=" + CStr(MaPhanLoai) + " group by mact")
                For Each rsitem As DataRow In rs.Rows
                    ExecSQLNonQuery("update chungtu set matp=" + CStr(MaPhanLoai) + " where mact=" + CStr(rsitem("MaCT")))
                Next
                rs = New DataTable
                rs = ExecSQLReturnDT("select vt.sohieu,sum(ct.sops2no) as soluong from chungtu ct inner join vattu vt on ct.mavattu=vt.maso where matp=" + CStr(MaPhanLoai) + " and thangct=" + CStr(thang) + " group by vt.sohieu")
                For Each rsitem As DataRow In rs.Rows
                    txtChuyen(1).Text = rsitem("SoHieu")
                    txtChuyen_Leave(txtChuyen(1), New EventArgs)
                    txtChuyen(4).Text = rsitem("soluong")
                    txtChuyen_Leave(txtChuyen(4), New EventArgs)
                    cmdct_Click(cmdct, New EventArgs)
                Next
        End Select
        If DaNhap = 1 And (pGiaHT = 0 Or pDTTP = 0) Then
            GhiXuatNVL(MaCT, Ngay, thang, Chk.CheckState, m1, 0, ConvertToDblSafe(txtChuyen(7).Text))
            UpdateCPNVLTT(ConvertToDblSafe(timtenmax("mact", "2", "maloai", "chungtu")))
            If m1.MaSo <= 0 Then TinhLaiGiaVonTP(m1, thang)
            DaNhap = 0
        End If
        If DaNhap = 1 And pGiaHT > 0 And ktra = 0 Then
            KiemTraVatTu()
            KiemTraTaiKhoan()
        End If
        'Cap nhat cac phieu thanh pham chi tiet
        If Index = 1 And Command(8).Enabled = False Then
            If MessageBox.Show("Phân bổ phiếu nhập thành phẩm tổng hợp." + vbCrLf + "Sang phiếu nhập chi tiết (Yes/No)?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Command(8).Enabled = True
                Dim rs1 As DataTable
                MaPhanLoai = GetSelectValue("select maso as f1 from tp154 where sohieu='THTP'")
                rs = New DataTable
                rs = ExecSQLReturnDT("select sops2no as soluong,sops as tien,mavattu,ct_id from chungtu where maloai=1 and mavattu<>0 and matp=" + CStr(m1.MaSo))
                For Each rsitem As DataRow In rs.Rows
                    If rsitem("soluong") <> 0 Then
                        ExecSQLNonQuery("update chungtu set sops=" + CStr(rsitem("tien") / rsitem("soluong")) + "*sops2no where maloai=1 and thangct=" + CStr(thang) + " and mavattu=" + CStr(rsitem("MaVattu")) + " and matp=" + CStr(MaPhanLoai))
                    Else
                        ExecSQLNonQuery("update chungtu set sops=" + CStr(rsitem("tien") / 1) + "*sops2no where maloai=1 and thangct=" + CStr(thang) + " and mavattu=" + CStr(rsitem("MaVattu")) + " and matp=" + CStr(MaPhanLoai))
                    End If
                    rs1 = ExecSQLReturnDT("select mact,sops from chungtu where maloai=1 and matkco=0 and thangct=" + CStr(thang) + " and mavattu=" + CStr(rsitem("MaVattu")) + " and matp=" + CStr(MaPhanLoai))
                    For Each rs1item As DataRow In rs1.Rows
                        ExecSQLNonQuery("update chungtu set sops=" + CStr(rs1item("sops")) + " where matkno=0 and mact=" + CStr(rs1item("MaCT")))
                    Next
                Next
                If MessageBox.Show("Xóa phiếu nhập thành phẩm tổng hợp (Yes/No)?", My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    ExecSQLNonQuery("delete from chungtu where matp<>" + CStr(MaPhanLoai) + " and mact=" + CStr(GetSelectValue("select mact as f1 from chungtu where maloai=1 and mavattu<>0 and matp=" + CStr(m1.MaSo))))
                End If
            End If
        End If
        KiemTraTaiKhoan()
        'Het cap nhat cac phieu thanh pham chi tiet
XongLC:
        m1 = Nothing
        Chungtu = Nothing
        Me.Cursor = Cursors.Default
        If pGiaHT > 0 And Index = 1 And ktra = 0 Then MessageBox.Show(Ngonngu("Đã tính xong giá thành!", "Complete the process!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    ''' <summary>
    ''' Ghi chi tiết lưu chuyển
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdct_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdct.Click
        Dim luong As Double, i As Integer, dgia As Double, tien As Double
        Dim PLTH As String, TyLe As Double, dongia As Double, soluong As Double, Gtpl As Double
        Dim LuongNVL As Double, TienNVL As Double, TienNVL2 As Double, TienNVLN As Double, TienNVL2N As Double
        Dim rs As DataTable, ddck As Double, dddk As Double, phantramdk As Double, phantramck As Double
        Dim thang As Integer

        thang = CboThang.SelectedValue
        If (taikhoan.maso = 0 Or taikhoan.tk_id <> TKVT_ID) Then
            txtChuyen(0).Focus()
            Exit Sub
        End If

        If vattu.MaSo = 0 Then
            txtChuyen(1).Focus()
            Exit Sub
        End If

        luong = GetSelectValue("select maso as f1 from tp154 where sohieu='THTP'")
        soluong = ConvertToDblSafe(GetSelectValue("select sum(ct.sops2no) as f1 from chungtu ct inner join vattu vt on ct.mavattu=vt.maso where mavattu=" + CStr(vattu.MaSo) + " and matp=" + CStr(luong) + " and thangct=" + CStr(thang) + " group by vt.sohieu"))
        luong = ConvertToDblSafe(txtChuyen(4).Text)
        If luong <> soluong And Command(8).Enabled = False Then
            If MessageBox.Show("Số lượng thành phẩm nhập kho <> tổng số lượng nhập thanh phẩm chi tiết." + vbCrLf + "TiÕp tôc nhËp thµnh phÈm.", My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
                txtChuyen(4).Focus()
                Exit Sub
            End If
        End If
        PLTH = txtChuyen(9).Text
        TyLe = ConvertToDblSafe(txtChuyen(10).Text)
        dongia = ConvertToDblSafe(txtChuyen(11).Text)
        soluong = luong * TyLe / (100 - TyLe)
        Gtpl = soluong * dongia
        ddck = ConvertToDblSafe(txtChuyen(16).Text)
        phantramck = ConvertToDblSafe(cbodd.Text)
        dddk = 0
        If Not BangDaCo("thanhphamdd") Then
            MessageBox.Show("Chưa có bảng thành phẩm dỡ dang." + vbCrLf + "Vui lòng cập nhật lại cơ sở dữ liệu!", My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            GoTo LoiSoLuong
        Else
            If CboSohieu.SelectedIndex >= 0 Then dddk = GetSelectValue("select sum(soluong) as f1,sum(phantram) as f2 from thanhphamdd where matp=" + CStr(vattu.MaSo) + " and makt=" + CStr(CboSohieu.SelectedValue) + CStr(vattu.MaSo) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay=(select max(ngay) from thanhphamdd where matp=" + CStr(vattu.MaSo) + " and makt=" + CStr(CboSohieu.SelectedValue) + CStr(vattu.MaSo) + " and ngay<='" + Format(Ngay, Mask_DB) + "' and makhonvl=" + CStr(CboKho(1).SelectedValue) + ") group by mact order by mact", phantramdk)
            If dddk = 0 Then dddk = GetSelectValue("select sum(soluong) as f1,sum(phantram) as f2 from thanhphamdd where sohieu<'" + CStr(CboSohieu.Text) + "' and matp=" + CStr(vattu.MaSo) + " and makt=0 and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay=(select max(ngay) from thanhphamdd where matp=" + CStr(vattu.MaSo) + " and makt=0 and ngay<='" + Format(Ngay, Mask_DB) + "' and makhonvl=" + CStr(CboKho(1).SelectedValue) + ") group by mact order by mact desc", phantramdk)
            If GetSelectValue("select count(maso) as f1 from thanhpham where sohieu='" + CStr(CboSohieu.Text) + "'") = 0 Then
                If dddk = 0 Then dddk = GetSelectValue("select sum(soluong) as f1,sum(phantram) as f2 from thanhphamdd where matp=" + CStr(vattu.MaSo) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay=(select max(ngay) from thanhphamdd where matp=" + CStr(vattu.MaSo) + " and ngay='" + Format(Ngay, Mask_DB) + "' and makhonvl=" + CStr(CboKho(1).SelectedValue) + ") group by mact order by mact desc", phantramdk)
                If dddk = 0 Then dddk = GetSelectValue("select sum(soluong) as f1,sum(phantram) as f2 from thanhphamdd where matp=" + CStr(vattu.MaSo) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay=(select max(ngay) from thanhphamdd where matp=" + CStr(vattu.MaSo) + " and ngay<'" + Format(Ngay, Mask_DB) + "' and makhonvl=" + CStr(CboKho(1).SelectedValue) + ") group by mact order by mact desc", phantramdk)
            End If
        End If
        If luong < dddk Then MessageBox.Show("Số lượng thành phẩm nhập kho < số lượng thành phẩm cuối kỳ!" + vbCrLf + "Vui lòng nhập lại thành phẩm có số hiệu " + CStr(txtChuyen(1).Text), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) : GoTo LoiSoLuong
        Dim giaban As Double
        giaban = GetSelectValue("select sum(sops)/iif(sum(sops2co)<>0,sum(sops2co),1)as f1 from chungtu inner join hethongtk on chungtu.matkco=hethongtk.maso where thangct=" + CStr(CboThang.SelectedValue) + " and maloai=8 and hethongtk.sohieu like'511*' and mavattu=" + CStr(vattu.MaSo))
        If giaban = 0 Then giaban = GetSelectValue("select sum(sops)/iif(sum(sops2co)<>0,sum(sops2co),1)as f1 from chungtu inner join hethongtk on chungtu.matkco=hethongtk.maso where thangct<" + CStr(CboThang.SelectedValue) + " and maloai=8 and hethongtk.sohieu like'511*' and mavattu=" + CStr(vattu.MaSo))
        If pGiaHT = 0 Then
            With Grd
                For i = 0 To .Rows - 1
                    .Col = 7
                    .Row = i
                    If ConvertToIntSafe(.Items(.Row).SubItems(.Col).Text) = taikhoan.maso Then
                        .Col = 8
                        If ConvertToIntSafe(.Items(.Row).SubItems(.Col).Text) = vattu.MaSo Then
                            .AddItem(taikhoan.sohieu + Chr(9) + vattu.sohieu + Chr(9) + vattu.TenVattu + Chr(9) + vattu.DonVi + Chr(9) _
                                + Format(luong, Mask_2) + Chr(9) + "0" + Chr(9) + "0" + Chr(9) + CStr(taikhoan.maso) + Chr(9) + CStr(vattu.MaSo) _
                                + Chr(9) + Chr(9) + Chr(9) + Chr(9) + CStr(PLTH) + Chr(9) + Format(TyLe, Mask_0) + Chr(9) + Format(dongia, Mask_0) + Chr(9) + Format(soluong, Mask_2) + Chr(9) + Format(Gtpl, Mask_2) + Chr(9) + Format(giaban, Mask_0) + Chr(9) + Format(dddk, Mask_2) + Chr(9) + Format(phantramdk, Mask_0) + Chr(9) + Format(ddck, Mask_2) + Chr(9) + Format(phantramck, Mask_0))
                            GoTo abc
                        End If
                    End If
                Next
            End With
            rs = ExecSQLReturnDT("select t1.maso,t1.soluong,t1.luong,t1.manvl,t2.masokho,t2.mataikhoan,t1.TL from dinhmuc t1 inner join tonkho t2 on t1.manvl=t2.mavattu where t1.matp=" + Timten("maso", txtChuyen(1).Text, "sohieu", "vattu") + " and t1.thang<=" + CStr(thang))
            For Each rsitem As DataRow In rs.Rows
                LuongNVL = SoTonKho(thang - 1, rsitem("MaSoKho"), rsitem("MaTaiKhoan"), rsitem("maNVL"), TienNVL, TienNVL2)
                LuongNVL = LuongNVL + SoNhapKhoThang(rsitem("MaSoKho"), rsitem("MaTaiKhoan"), rsitem("maNVL"), CStr(thang), CStr(thang), TienNVLN, TienNVL2N)
                TienNVL = TienNVL + TienNVLN
                If rsitem("soluong") = 0 Then
                    ExecSQLNonQuery("update dinhmuc set soluong=" + CStr(ConvertToDblSafe((rsitem("TL")) / 100) * (ConvertToDblSafe(rsitem("luong")) / 100) * giaban * LuongNVL / IIf(TienNVL <> 0, TienNVL, 1)) + " where maso=" + CStr(rsitem("MaSo")))
                End If
            Next
            Dim maloaitp As Integer, sxcn As Double
            maloaitp = GetSelectValue("select maphanloai as f1 from vattu where sohieu='" + CStr(vattu.sohieu) + "'")
            If GetSelectValue("select count(maso)as f1 from tp154 where maphanloai1=" + CStr(maloaitp)) = 0 Then maloaitp = 0
            Grd.AddItem(taikhoan.sohieu + Chr(9) + vattu.sohieu + Chr(9) + vattu.TenVattu + Chr(9) + vattu.DonVi + Chr(9) + Format(luong, Mask_2) + Chr(9) + "0" + Chr(9) + "0" + Chr(9) + CStr(taikhoan.maso) + Chr(9) + CStr(vattu.MaSo) _
                + Chr(9) + Chr(9) + Chr(9) + Chr(9) + CStr(PLTH) + Chr(9) + Format(TyLe, Mask_0) + Chr(9) + Format(dongia, Mask_0) + Chr(9) + Format(soluong, Mask_2) + Chr(9) + Format(Gtpl, Mask_2) + Chr(9) + Format(giaban, Mask_0) _
                + Chr(9) + Format(dddk, Mask_2) + Chr(9) + Format(phantramdk, Mask_0) + Chr(9) + Format(ddck, Mask_2) + Chr(9) + Format(phantramck, Mask_0) + Chr(9) + CStr(maloaitp))
            Hienthichiphinhom(thang, maloaitp, 1, sxcn)
            Grd.Items(Grd.Row).SubItems(23).Text = sxcn

            Grd.Row = Grd.Rows - 1
            Grd.Col = 7
            If Len(Grd.Items(Grd.Row).SubItems(Grd.Col).Text) = 0 Then Grd.RemoveItem(Grd.Row)
            Grd.Row = 0
            Grd.Col = 0

            GiaBQ()

abc:
            For i = 1 To 3
                txtChuyen(i).Text = ""
            Next
            For i = 4 To 6
                txtChuyen(i).Text = "0"
            Next
            txtChuyen(8).Text = 0
            txtChuyen(9).Text = ""
            For i = 10 To 16
                txtChuyen(i).Text = 0
            Next
            cbodd.Text = 0
            vattu.InitVattuMaSo(0)
            taikhoan.InitTaikhoanSohieu(txtChuyen(0).Text)
            txtChuyen(1).Focus()
        Else
            If cmdct.Tag < 0 Then Exit Sub
            tien = ConvertToDblSafe(txtChuyen(6).Text)
            If luong <> 0 Then dgia = tien / luong Else dgia = 0
            With Grd
                .Row = cmdct.Tag
                .Col = 5
                .Items(.Row).SubItems(.Col).Text = Format(dgia, Mask_2)
                .Col = 6
                .Items(.Row).SubItems(.Col).Text = Format(tien, Mask_0)
                If .Row < .Rows - 1 Then .Row = cmdct.Tag + 1
                Grd_DblClick(Grd, New EventArgs)
            End With
        End If
LoiSoLuong:
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Khoaquyen()
    End Sub
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
    ''' <summary>
    ''' Xử lý các phím nóng
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmThanhPham_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.T
                    Command(0).Focus()
                    ' Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.G
                    Command(1).Focus()
                    ' Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.X
                    Command(2).Focus()
                    ' Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.V
                    Command(3).Focus()
                    ' Command_ClickEvent(Command(3), New EventArgs())
                Case Keys.D
                    Command(4).Focus()
                    ' Command_ClickEvent(Command(4), New EventArgs())
                Case Keys.N
                    Command(5).Focus()
                    ' Command_ClickEvent(Command(5), New EventArgs())
                Case Keys.H
                    Command(6).Focus()
                    '  Command_ClickEvent(Command(6), New EventArgs())
                Case Keys.E
                    Xem.Focus()
                    ' Xem_ClickEvent(Xem, New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    ''' <summary>
    ''' Khởi tạo cửa sổ nhập
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmThanhPham_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            ColumnSetUp(Grd, 0, 420, 0)
            ColumnSetUp(Grd, 1, 950, 0)
            ColumnSetUp(Grd, 2, 2810, 0)
            ColumnSetUp(Grd, 3, 650, 0)
            ColumnSetUp(Grd, 4, 1070, 4)
            ColumnSetUp(Grd, 5, 1115, 4)
            ColumnSetUp(Grd, 6, 1145, 4)
            ColumnSetUp(Grd, 7, 1, 0) ' MaTK
            ColumnSetUp(Grd, 8, 1, 0) ' MaTP
            ColumnSetUp(Grd, 9, 1, 0)
            ColumnSetUp(Grd, 10, 1, 0)
            ColumnSetUp(Grd, 11, 1, 0)
            ColumnSetUp(Grd, 12, 710, 4)
            ColumnSetUp(Grd, 13, 350, 4)
            ColumnSetUp(Grd, 14, 830, 4)
            ColumnSetUp(Grd, 15, 710, 4)
            ColumnSetUp(Grd, 16, 950, 4)
            ColumnSetUp(Grd, 17, 950, 4)
            ColumnSetUp(Grd, 18, 695, 4)
            ColumnSetUp(Grd, 19, 532, 4)
            ColumnSetUp(Grd, 20, 610, 4)
            ColumnSetUp(Grd, 21, 605, 4)
            ColumnSetUp(Grd, 22, 1, 4)
            ColumnSetUp(Grd, 23, 1, 4)
            ColumnSetUp(Grd, 24, 1, 4)
            ColumnSetUp(Grd, 25, 1, 4)
            ColumnSetUp(Grd, 26, 1, 4)

            AddMonthToCbo(CboThang)

            InitDateVars(MedNgay, Ngay)
            Int_RecsetToCbo("SELECT MaSo As F2,TenKho As F1 FROM KhoHang ORDER BY TenKho", CboKho(0))
            Int_RecsetToCbo("SELECT MaSo As F2,TenKho As F1 FROM KhoHang ORDER BY TenKho", CboKho(1))
            If _CboKho_0.Items.Count > 0 Then
                _CboKho_0.SelectedIndex = 0
            End If
            If _CboKho_1.Items.Count > 0 Then
                _CboKho_1.SelectedIndex = 0
            End If
            Text = SetFormTitle(Text)
            txtShTk(0).Text = taikhoanconnhat("154")
            txtShTk(1).Text = taikhoanconnhat("621")
            txtShTk(2).Text = taikhoanconnhat("622")

            For i As Integer = 0 To 2
                txtShTk_Leave(txtShTk(i), New EventArgs())
            Next

            CboKho(1).Enabled = (Chk.CheckState = CheckState.Checked)
            Chk.CheckState = (GetSelectValue("SELECT TOP 1 XK AS F1 FROM ThanhPham ORDER BY Ngay DESC"))
            Label(13).Visible = (pDTTP <> 0)
            TxtCT.Visible = (pDTTP <> 0)
            cmdtp.Visible = (pDTTP <> 0)
            Label(18).Visible = (pTygia > 0)
            txtChuyen(7).Visible = (pTygia > 0)
            If pTygia > 0 Then txtChuyen(7).Text = Format(TyGiaCuoi(), Mask_0)
            If pGiaHT > 0 Then
                txtChuyen(4).ReadOnly = True
                txtChuyen(5).ReadOnly = False
                txtChuyen(6).ReadOnly = False
            End If
            formLoaded = True
            CboThang_SelectedValueChanged(CboThang, New EventArgs())
            txtChuyen_Leave(txtChuyen(0), New EventArgs())
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
    Private Sub FrmThanhPham_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        IniPath = FileSystem.Dir(My.Application.Info.DirectoryPath, FileAttribute.Directory)
        Interaction.SaveSetting(IniPath, "Stock", "AutoOut", ConvertToStrSafe(Chk.CheckState))
        taikhoan = Nothing
        vattu = Nothing
        m = Nothing
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Grd_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Grd.DoubleClick
        Dim i As Integer
        SetGridIndex(Grd, Grd.Row)
        If Grd.Row >= Grd.Rows Then Exit Sub
        With Grd
            .Col = 0
            If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit Sub
            txtChuyen(0).Text = .Items(.Row).SubItems(.Col).Text
            .Col = 7
            taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text))
            .Col = 8
            vattu.InitVattuMaSo(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text))
            For i = 1 To 4
                .Col = ConvertToDblSafe(i)
                txtChuyen(i).Text = .Items(.Row).SubItems(.Col).Text
            Next
            For i = 12 To 16
                .Col = ConvertToDblSafe(i)
                txtChuyen(i - 3).Text = .Items(.Row).SubItems(.Col).Text
            Next
            .Col = ConvertToDblSafe(i)
            txtChuyen(8).Text = .Items(.Row).SubItems(.Col).Text
            For i = 18 To 20
                .Col = ConvertToDblSafe(i)
                txtChuyen(i - 4).Text = .Items(.Row).SubItems(.Col).Text
            Next
            .Col = 21
            cbodd.Text = .Text
            .Col = 22
            Hienthichiphinhom(CboThang.SelectedValue, ConvertToIntSafe(.Items(.Row).SubItems(.Col).Text), -1)
            If pGiaHT = 0 Then
                .RemoveItem(.Row)
                If .Rows < ConvertToDblSafe(.Tag) Then .Rows = ConvertToDblSafe(.Tag)
                GiaBQ()
                txtChuyen(1).Focus()
            Else
                cmdct.Tag = ConvertToStrSafe(.Row)
                txtChuyen(5).Focus()
            End If
            .Col = 0
        End With
    End Sub

    Sub Hienthichiphinhom(ByVal thang As Integer, ByVal maloaitp As Integer, Optional ByVal loai As Integer = 1, Optional ByRef tien As Double = 0)
        Dim masonhom As Integer
        If KTCPNhom(Grd.Row, 22, loai) Then
            If m.MaSo <> 0 Then
                masonhom = ConvertToDblSafe(GetSelectValue("select maso as f1 from tp154 where maphanloai1=" + CStr(maloaitp)))
                If masonhom > 0 Then
                    tien = GetSelectValue("SELECT Sum(SoPS) AS F1 FROM " + ChungTu2TKNC(-1) + " WHERE " + WThang("ThangCT", thang, thang) + " AND HethongTK.SoHieu LIKE '627%' AND MaTP=" + CStr(masonhom))
                    LbGia(3).Text = Format(ConvertToDblSafe(LbGia(3).Text) + loai * tien, Mask_0)
                End If
            End If
        End If
        If ConvertToDblSafe(LbGia(3).Text) < 0 Then LbGia(3).Text = 0
    End Sub

    Function KTCPNhom(ByVal dong As Integer, ByVal cot As Integer, Optional ByVal loai As Integer = 1) As Boolean
        Dim i As Integer, tmp As Integer, d As Integer, c As Integer
        If dong = 0 And loai > 0 Then Return True
        tmp = ConvertToIntSafe(Luoi(Grd, dong, cot))
        If tmp = 0 Then Return False
        For i = dong - 1 To 0 Step -1
            If tmp = ConvertToIntSafe(Luoi(Grd, i, cot)) Then Return False
        Next
        If loai < 0 Then
            d = Grd.Row : c = Grd.Col
            For i = dong + 1 To Grd.Rows - 1
                Grd.Row = i
                If ConvertToDblSafe(Luoi(Grd, i, 0)) = 0 Then Exit For
                If tmp = ConvertToIntSafe(Luoi(Grd, i, cot)) Then Grd.Row = d : Grd.Col = c : Return False
            Next
            Grd.Row = d : Grd.Col = c
        End If
        Return True
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Grd_KeyPressEvent(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles Grd.KeyPress
        If eventArgs.KeyChar = Chr(Keys.Enter) Then Grd_DblClick(Grd, New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Grd_KeyUpEvent(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles Grd.KeyUp
        If eventArgs.KeyCode = 37 Or eventArgs.KeyCode = 38 Or eventArgs.KeyCode = 39 Or eventArgs.KeyCode = 40 Then SetGridIndex(Grd, Grd.Row)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Grd_MouseDownEvent(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles Grd.MouseDown
        If eventArgs.Button = MouseButtons.Right Then
            Ctx_MN = New System.Windows.Forms.ContextMenuStrip
            Ctx_MN.Show(Me, New Point((Cursor.Position).X, (Cursor.Position).Y - 90))
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
    ''' Kiểm tra ngày lưu chuyển
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MedNgay.Leave
        Dim LoiNgayChuyen As Boolean = False
        Dim m As Integer = Ngay.Month
        Try
            LoiNgayChuyen = True
            Ngay = ConvertToDateSafe(MedNgay.Text)
            If Ngay.Month <> CboThang.SelectedValue Then MessageBox.Show(Ngonngu("Ngày sản xuất không giống tháng sản xuất!", "Production date non-month"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoiNgayChuyen = False
            If Ngay.Month <> m Then
                m = Ngay.Month
                ClearGrid(Grd, ConvertToDblSafe(Grd.Tag))
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
    Public Sub MNCon_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MNCon_0.Click
        Dim Index As Integer = Array.IndexOf(MNCon, eventSender)
        If Index = 0 Then
            Command(7).Tag = "0"
            FrmSogiathanh.FrmSogiathanh_Load(FrmSogiathanh, New EventArgs)
            FrmSogiathanh.OptBC(54).Checked = True
            FrmSogiathanh.Command_ClickEvent(FrmSogiathanh.Command(0), New EventArgs())
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtChuyen_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtChuyen_16.Enter, _txtChuyen_15.Enter, _txtChuyen_14.Enter, _txtChuyen_8.Enter, _txtChuyen_13.Enter, _txtChuyen_12.Enter, _txtChuyen_11.Enter, _txtChuyen_10.Enter, _txtChuyen_9.Enter, _txtChuyen_5.Enter, _txtChuyen_4.Enter, _txtChuyen_6.Enter, _txtChuyen_1.Enter, _txtChuyen_7.Enter, _txtChuyen_2.Enter, _txtChuyen_0.Enter, _txtChuyen_3.Enter
        Dim Index As Integer = Array.IndexOf(txtChuyen, eventSender)
        txtChuyen(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtChuyen_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtChuyen_16.KeyPress, _txtChuyen_15.KeyPress, _txtChuyen_14.KeyPress, _txtChuyen_8.KeyPress, _txtChuyen_13.KeyPress, _txtChuyen_12.KeyPress, _txtChuyen_11.KeyPress, _txtChuyen_10.KeyPress, _txtChuyen_9.KeyPress, _txtChuyen_5.KeyPress, _txtChuyen_4.KeyPress, _txtChuyen_6.KeyPress, _txtChuyen_1.KeyPress, _txtChuyen_7.KeyPress, _txtChuyen_2.KeyPress, _txtChuyen_0.KeyPress, _txtChuyen_3.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtChuyen, eventSender)
        Select Case Index
            Case 0
                If KeyAscii = 13 Then
                    Me.Cursor = Cursors.WaitCursor
                    txtChuyen(0).Text = FrmTaikhoan.ChonTk(txtChuyen(0).Text)
                    Me.Cursor = Cursors.Default
                    txtChuyen(0).Focus()
                End If
            Case 1, 9
                If KeyAscii = 13 Then
                    Me.Cursor = Cursors.WaitCursor
                    txtChuyen(Index).Text = FrmVattu.ChonVattu(txtChuyen(Index).Text, 0, 0, 0, 0, "155")
                    Me.Cursor = Cursors.Default
                    txtChuyen(Index).Focus()
                End If
            Case 4, 7, 10, 11
                If KeyAscii = 13 Then
                    cmdct_Click(cmdct, New EventArgs())
                Else
                    KeyProcess(txtChuyen(Index), KeyAscii)
                End If
            Case 5, 6
                KeyProcess(txtChuyen(Index), KeyAscii)
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
    Private Sub txtChuyen_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtChuyen_16.Leave, _txtChuyen_15.Leave, _txtChuyen_14.Leave, _txtChuyen_8.Leave, _txtChuyen_13.Leave, _txtChuyen_12.Leave, _txtChuyen_11.Leave, _txtChuyen_10.Leave, _txtChuyen_9.Leave, _txtChuyen_5.Leave, _txtChuyen_4.Leave, _txtChuyen_6.Leave, _txtChuyen_1.Leave, _txtChuyen_7.Leave, _txtChuyen_2.Leave, _txtChuyen_0.Leave, _txtChuyen_3.Leave
        Dim Index As Integer = Array.IndexOf(txtChuyen, eventSender)
        Dim luong, dgia As Double
        Select Case Index
            Case 0
                taikhoan.InitTaikhoanSohieu(txtChuyen(0).Text)
            Case 1
                vattu.InitVattuSohieu(txtChuyen(1).Text)
                txtChuyen(2).Text = vattu.TenVattu
                txtChuyen(3).Text = vattu.DonVi
                If vattu.MaSo > 0 Then Int_RecsetToCbo0("SELECT TLHT As F1 FROM DinhMuc where TLHT>0 and matp=" + CStr(vattu.MaSo) + " group by TLHT ORDER BY TLHT", cbodd)
            Case 4
                txtChuyen(4).Text = Format(txtChuyen(4).Text, Mask_2)
            Case 5
                txtChuyen(6).Text = Format(ConvertToDblSafe(txtChuyen(4).Text) * ConvertToDblSafe(txtChuyen(5).Text), Mask_0)
            Case 6
                luong = ConvertToDblSafe(txtChuyen(4).Text)
                dgia = IIf(luong > 0, ConvertToDblSafe(txtChuyen(6).Text) / luong, 0)
                txtChuyen(5).Text = Format(dgia, Mask_2)
        End Select
    End Sub

    ''' <summary>
    ''' Thủ tục kiểm tra phiếu lưu chuyển có hợp lệ ?
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function KiemTraPhieu() As Boolean
        Dim result As Boolean = False
        If Strings.Len(CboSohieu.Text) = 0 Then
            ErrMsg(er_SoHieu)
            CboSohieu.Focus()
            Return result
        End If
        If CboKho(0).SelectedIndex < 0 Then
            ErrMsg(er_KhoHang)
            CboKho(1).Focus()
            Return result
        End If
        Grd.Row = 0
        Grd.Col = 0
        If Strings.Len(Grd.Items(Grd.Row).SubItems(Grd.Col).Text) = 0 Then
            MessageBox.Show(Ngonngu("Hãy nhập chi tiết bảng kê !", "Enter inventory details !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtChuyen(0).Focus()
            Return result
        End If
        If Strings.Left(txtShTk(0).Text, 4) <> "1541" Or ConvertToDblSafe((txtShTk(0).Tag)) = 0 Then
            txtShTk(0).Focus()
            Return result
        End If
        If Strings.Left(txtShTk(1).Text, 3) <> "621" Or ConvertToDblSafe((txtShTk(1).Tag)) = 0 Then
            txtShTk(1).Focus()
            Return result
        End If
        If Strings.Left(txtShTk(2).Text, 3) <> "622" Or ConvertToDblSafe((txtShTk(2).Tag)) = 0 Then
            txtShTk(2).Focus()
            Return result
        End If
        If pDTTP <> 0 And m.MaSo = 0 Then
            TxtCT.Focus()
            Return result
        End If
        If User_Right <> 0 Then
            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT Lock{0} % 10 AS F1 FROM License", CboThang.SelectedValue))) > 0 Then
                MessageBox.Show(Ngonngu("Tháng đã bị khoá không cho nhập số liệu!", "Month has been locked, no data is entered!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return result
            End If
        End If
        Return True
    End Function
    ''' <summary>
    ''' Thủ tục xóa phiếu trên màn hình
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub XoaPhieuTrenManHinh()
        CboSohieu.Text = ""
        ClearGrid(Grd, ConvertToDblSafe(Grd.Tag))
        For i As Integer = 1 To 3
            txtChuyen(i).Text = ""
        Next
        For i As Integer = 4 To 6
            txtChuyen(i).Text = "0"
        Next
        txtChuyen(8).Text = "0"
        txtChuyen(9).Text = ""
        For i As Integer = 10 To 16
            txtChuyen(i).Text = "0"
        Next
        If pGiaHT = 0 Then
            TxtCT.Text = ""
            TxtCT_Leave(TxtCT, New EventArgs())
        End If
        If f1 = 0 Then
            For i As Integer = 0 To 3
                LbGia(i).Text = ""
            Next
        End If
        vattu.InitVattuMaSo(0)
        taikhoan.InitTaikhoanSohieu(txtChuyen(0).Text)
        cmdct.Tag = "-1"
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShTk_3.Enter, _txtShTk_0.Enter, _txtShTk_2.Enter, _txtShTk_1.Enter
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        txtShTk(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtShTk_3.KeyPress, _txtShTk_0.KeyPress, _txtShTk_2.KeyPress, _txtShTk_1.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        If KeyAscii = 13 Then cmdtk_ClickEvent(cmdtk(Index), New EventArgs())
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    ''' <summary>
    ''' Kiểm tra số hiệu tài khoản đã nhập
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShTk_3.Leave, _txtShTk_0.Leave, _txtShTk_2.Leave, _txtShTk_1.Leave
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        If Index = 3 Then
            txtShTk(Index).Text = ConvertToStrSafe(Math.Round(ConvertToDblSafe(txtShTk(Index).Text), 0)) : Exit Sub
        End If
        Dim mtk As Integer = 0
        LbTenTk(Index).Text = tentk(txtShTk(Index).Text, mtk)
        txtShTk(Index).Tag = ConvertToStrSafe(mtk)
        If ConvertToDblSafe(GetSelectValue(String.Format("SELECT TKCon AS F1 FROM HethongTK WHERE MaSo={0}", mtk))) > 0 Then txtShTk(Index).Tag = "0"
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdtk_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _cmdtk_2.Click, _cmdtk_1.Click, _cmdtk_0.Click
        Dim Index As Integer = Array.IndexOf(cmdtk, eventSender)
        Me.Cursor = Cursors.WaitCursor
        txtShTk(Index).Text = FrmTaikhoan.ChonTk(txtShTk(Index).Text)
        txtShTk(Index).Focus()
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="MaCT"></param>
    ''' <remarks></remarks>
    Private Sub GiaBQ(Optional ByVal MaCT As Long = 0)
        Dim i As Integer, luong As Double, r As Integer, luong1 As Double, mvt As Long, k As Integer
        Dim nvl As Double, nC As Double, nvl1 As Double, nc1 As Double, CP As Double, cp1 As Double, tcp As Double, cpdd As Double
        Dim n2 As Double, v2 As Double, thang As Integer, luongdk As Double
        Dim NVLPhanTram As Double, SoLuongPhanTram As Double, NVLdauky As Double

        thang = CboThang.SelectedValue
        Ngay = MedNgay.Text
        If pGiaHT > 0 And Chk.Checked = True Then Exit Sub
        themchiphinhom()
        With Grd
            r = -1
            For i = 0 To .Rows - 1
                r = i
                .Row = i
                .Col = 0
                .Col = 8
                mvt = ConvertToIntSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 4
                luong1 = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 20
                SoLuongPhanTram = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                luongdk = 0
                If MaCT > 0 Then
                    luongdk = GetSelectValue("select sum(SoLuong) as f1,sum(cpnvl) as f2 from thanhphamdd where mact<" + CStr(MaCT) + " and makt=0 and matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay=(select max(ngay) from thanhphamdd where mact<" + CStr(MaCT) + " and makt=0 and matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay<='" + Format(Ngay, Mask_DB) + "') group by mact", NVLdauky)
                    If luongdk = 0 Then luongdk = GetSelectValue("select sum(SoLuong) as f1,sum(cpnvl) as f2 from thanhphamdd where makt=0 and matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay=(select max(ngay) from thanhphamdd where makt=0 and matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay<'" + Format(Ngay, Mask_DB) + "') group by mact", NVLdauky)
                    If luongdk = 0 Then luongdk = GetSelectValue("select sum(SoLuong) as f1,sum(cpnvl) as f2 from thanhphamdd where sohieu<'" + CStr(CboSohieu.Text) + "' and makt=0 and matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay='" + Format(Ngay, Mask_DB) + "'", NVLdauky)
                Else
                    If luongdk = 0 Then luongdk = GetSelectValue("select sum(SoLuong) as f1,sum(cpnvl) as f2 from thanhphamdd where sohieu<'" + CStr(CboSohieu.Text) + "' and matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay=(select max(ngay) from thanhphamdd where matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay<='" + Format(Ngay, Mask_DB) + "') group by mact order by mact desc", NVLdauky)
                End If
                luong1 = luong1 - luongdk
                luong = luong + luong1
                If Chk.Checked = True Then
                    nvl1 = GiaNVLTheoDM(mvt, luong1, CboKho(1).SelectedValue, Ngay)
                    .Col = 21
                    NVLPhanTram = GiaNVLTheoDM(mvt, SoLuongPhanTram, CboKho(1).SelectedValue, Ngay, ConvertToIntSafe(.Items(.Row).SubItems(.Col).Text))
                    .Col = 19
                    nvl1 = nvl1 + NVLPhanTram + GiaNVLTheoDM(mvt, luongdk, CboKho(1).SelectedValue, Ngay, ConvertToIntSafe(.Items(.Row).SubItems(.Col).Text), 1)
                End If
                nc1 = GiaNCTheoDM(mvt, luong1, CboThang.SelectedValue)
                If nc1 > 0 Then k = 1
                nvl = nvl + nvl1 + NVLdauky
                nC = nC + nc1
                .Col = 9
                .Items(.Row).SubItems(.Col).Text = Format(nvl1, Mask_0)
                .Col = 10
                .Items(.Row).SubItems(.Col).Text = Format(nc1, Mask_0)
                .Col = 11
                .Items(.Row).SubItems(.Col).Text = "0"
                .Col = 24
                .Items(.Row).SubItems(.Col).Text = "0"
                .Col = 25
                .Items(.Row).SubItems(.Col).Text = "0"
                .Col = 26
                .Items(.Row).SubItems(.Col).Text = NVLPhanTram
                .Col = 6
                .Items(.Row).SubItems(.Col).Text = Format(nvl1 + nc1, Mask_0)
            Next
            CP = 0

            If m.MaSo > 0 Then
                v2 = SoPSCPTP_DM("621", m, CboThang.SelectedValue) + m.SoCPNVLPB(CboThang.SelectedValue, CboThang.SelectedValue)
                n2 = SoPSCPTP_DM("622", m, CboThang.SelectedValue) + m.SoCPNCPB(CboThang.SelectedValue, CboThang.SelectedValue)
            Else
                If k = 0 Then n2 = ConvertToDblSafe(LbGia(1).Text) Else n2 = 0
            End If

            tcp = v2
            If r >= 0 And tcp <> 0 Then
                For i = 0 To r - 1
                    .Row = i
                    .Col = 4
                    luong1 = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                    .Col = 8
                    mvt = ConvertToIntSafe(.Items(.Row).SubItems(.Col).Text)
                    .Col = 20
                    If MaCT > 0 Then
                        luongdk = GetSelectValue("select sum(SoLuong) as f1 from thanhphamdd where mact<" + CStr(MaCT) + " and makt=0 and matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay=(select max(ngay) from thanhphamdd where mact<" + CStr(MaCT) + " and makt=0 and matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay<='" + Format(Ngay, Mask_DB) + "') group by mact")
                        If luongdk = 0 Then luongdk = GetSelectValue("select sum(SoLuong) as f1 from thanhphamdd where makt=0 and matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay=(select max(ngay) from thanhphamdd where makt=0 and matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay<'" + Format(Ngay, Mask_DB) + "') group by mact")
                        If luongdk = 0 Then luongdk = GetSelectValue("select sum(SoLuong) as f1 from thanhphamdd where sohieu<'" + CStr(CboSohieu.Text) + "' and makt=0 and matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay='" + Format(Ngay, Mask_DB) + "' group by mact")
                    Else
                        If luongdk = 0 Then luongdk = GetSelectValue("select sum(SoLuong) as f1 from thanhphamdd where matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay=(select max(ngay) from thanhphamdd where matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay<='" + Format(Ngay, Mask_DB) + "') group by mact order by mact desc")
                    End If
                    luong1 = luong1 + ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) - luongdk
                    If luong <> 0 Then cp1 = RoundMoney(tcp * luong1 / luong) Else cp1 = 0
                    .Col = 6
                    .Items(.Row).SubItems(.Col).Text = Format(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) + cp1, Mask_0)
                    .Col = 9
                    .Items(.Row).SubItems(.Col).Text = Format(cp1, Mask_0)
                    CP = CP + cp1
                Next
                .Row = r
                .Col = 6
                .Items(.Row).SubItems(.Col).Text = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) + tcp - CP
                .Col = 9
                .Items(.Row).SubItems(.Col).Text = Format(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) + tcp - CP, Mask_0)
            End If

            ' Phan bo NC
            CP = 0
            tcp = n2
            If r >= 0 And tcp <> 0 Then
                For i = 0 To r - 1
                    .Row = i
                    .Col = 9
                    nvl1 = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                    .Col = 8
                    mvt = CStr(.Items(.Row).SubItems(.Col).Text)
                    nvl1 = nvl1 + GetSelectValue("select sum(cpnvl) as f1 from thanhphamdd where mact<" + CStr(MaCT) + " and makt=0 and matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay=(select max(ngay) from thanhphamdd where mact<" + CStr(MaCT) + " and makt=0 and matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay<='" + Format(Ngay, Mask_DB) + "') group by mact")
                    If nvl <> 0 Then cp1 = RoundMoney(tcp * nvl1 / nvl) Else cp1 = 0
                    CP = CP + cp1
                    .Col = 6
                    .Items(.Row).SubItems(.Col).Text = Format(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) + cp1, Mask_0)
                    .Col = 10
                    .Items(.Row).SubItems(.Col).Text = Format(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) + cp1, Mask_0)
                Next
                .Row = r
                .Col = 6
                .Items(.Row).SubItems(.Col).Text = Format(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) + tcp - CP - cpdd, Mask_0)
                .Col = 10
                .Items(.Row).SubItems(.Col).Text = Format(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) + tcp - CP - cpdd, Mask_0)
            End If


            nvl = nvl + v2
            nC = nC + n2
            LbGia(0).Text = Format(nvl, Mask_0)
            LbGia(1).Text = Format(nC, Mask_0)

            ' Phan bo CP chung
            tcp = ConvertToDblSafe(LbGia(2).Text)
            CP = 0
            cpdd = 0
            If r >= 0 And nvl <> 0 And tcp <> 0 Then
                For i = 0 To r - 1
                    .Row = i
                    .Col = 9
                    nvl1 = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                    .Col = 8
                    mvt = CStr(.Items(.Row).SubItems(.Col).Text)
                    nvl1 = nvl1 + GetSelectValue("select sum(cpnvl) as f1 from thanhphamdd where mact<" + CStr(MaCT) + " and makt=0 and matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay=(select max(ngay) from thanhphamdd where mact<" + CStr(MaCT) + " and makt=0 and matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay<='" + Format(Ngay, Mask_DB) + "') group by mact")
                    If nvl <> 0 Then cp1 = RoundMoney(tcp * nvl1 / nvl) Else cp1 = 0
                    CP = CP + cp1
                    .Col = 6
                    .Items(.Row).SubItems(.Col).Text = Format(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) + cp1, Mask_0)
                    .Col = 11
                    .Items(.Row).SubItems(.Col).Text = Format(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) + cp1, Mask_0)
                Next
                .Row = r
                .Col = 6
                .Items(.Row).SubItems(.Col).Text = Format(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) + tcp - CP - cpdd, Mask_0)
                .Col = 11
                .Items(.Row).SubItems(.Col).Text = Format(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) + tcp - CP - cpdd, Mask_0)
            End If

            ' Phan bo CP nhom
            tcp = ConvertToDblSafe(LbGia(3).Text)
            CP = 0
            If r >= 0 And nvl <> 0 And tcp <> 0 Then
                Dim j As Integer, tmp As Integer
                nvl = 0
                For i = 0 To r
                    nvl = 0
                    If ConvertToDblSafe(Luoi(Grd, i, 22)) > 0 And ConvertToDblSafe(Luoi(Grd, i, 25)) = 0 Then
                        tmp = ConvertToDblSafe(Luoi(Grd, i, 22))
                        tcp = ConvertToDblSafe(Luoi(Grd, i, 23))
                        For j = i To r
                            If tmp = ConvertToDblSafe(Luoi(Grd, j, 22)) Then
                                nvl = nvl + GetSelectValue("select sum(cpnvl) as f1 from thanhphamdd where mact<" + CStr(MaCT) + " and makt=0 and matp=" + CStr(Luoi(Grd, j, 8)) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay=(select max(ngay) from thanhphamdd where mact<" + CStr(MaCT) + " and makt=0 and matp=" + CStr(Luoi(Grd, j, 8)) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay<='" + Format(Ngay, Mask_DB) + "') group by mact")
                                nvl = nvl + ConvertToDblSafe(Luoi(Grd, j, 9)) + ConvertToDblSafe(Luoi(Grd, j, 26))
                                .Row = j : .Col = 25 : .Items(.Row).SubItems(.Col).Text = 1
                            End If
                        Next
                        cpdd = 0
                        For j = i To r
                            If ConvertToDblSafe(Luoi(Grd, j, 22)) = tmp Then
                                .Row = j
                                .Col = 9
                                nvl1 = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                                nvl1 = nvl1 + GetSelectValue("select sum(cpnvl) as f1 from thanhphamdd where mact<" + CStr(MaCT) + " and makt=0 and matp=" + CStr(Luoi(Grd, j, 8)) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay=(select max(ngay) from thanhphamdd where mact<" + CStr(MaCT) + " and makt=0 and matp=" + CStr(Luoi(Grd, j, 8)) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay<='" + Format(Ngay, Mask_DB) + "') group by mact")
                                If nvl <> 0 Then cp1 = RoundMoney(tcp * nvl1 / nvl) Else cp1 = 0
                                CP = CP + cp1
                                .Col = 6
                                .Items(.Row).SubItems(.Col).Text = Format(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) + cp1, Mask_0)
                                .Col = 24
                                .Items(.Row).SubItems(.Col).Text = Format(ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) + cp1, Mask_0)
                            End If
                        Next
                    End If
                Next
            End If

            'Do dang
            For i = 0 To .Rows - 1
                .Row = i
                .Col = 0
                If Len(.Items(.Row).SubItems(.Col).Text) = 0 Then Exit For
                .Col = 4
                luong1 = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 8
                mvt = ConvertToIntSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 20
                If MaCT > 0 Then
                    luongdk = GetSelectValue("select sum(SoLuong) as f1 from thanhphamdd where mact<" + CStr(MaCT) + " and makt=0 and matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay=(select max(ngay) from thanhphamdd where mact<" + CStr(MaCT) + " and makt=0 and matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay<='" + Format(Ngay, Mask_DB) + "') group by mact")
                    If luongdk = 0 Then luongdk = GetSelectValue("select sum(SoLuong) as f1 from thanhphamdd where makt=0 and matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay=(select max(ngay) from thanhphamdd where makt=0 and matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay<'" + Format(Ngay, Mask_DB) + "') group by mact")
                    If luongdk = 0 Then luongdk = GetSelectValue("select sum(SoLuong) as f1 from thanhphamdd where sohieu<'" + CStr(CboSohieu.Text) + "' and makt=0 and matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay='" + Format(Ngay, Mask_DB) + "' group by mact")
                Else
                    If luongdk = 0 Then luongdk = GetSelectValue("select sum(SoLuong) as f1 from thanhphamdd where matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay=(select max(ngay) from thanhphamdd where matp=" + CStr(mvt) + " and makhonvl=" + CStr(CboKho(1).SelectedValue) + " and ngay<='" + Format(Ngay, Mask_DB) + "') group by mact order by mact desc")
                End If
                luong1 = luong1 + ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text) - luongdk
                If luong1 <> 0 Then
                    .Col = 6
                    CP = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                    .Col = 5
                    .Items(.Row).SubItems(.Col).Text = Format(CP / luong1, Mask_2)
                End If
            Next
        End With
    End Sub

    Private Sub TxtCT_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles TxtCT.Enter
        TxtCT.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TxtCT_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles TxtCT.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then
            TxtCT.Text = FrmTP.ChonTP(TxtCT.Text)
            TxtCT.Focus()
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
    Private Sub TxtCT_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles TxtCT.Leave
        If pDTTP = 0 Then Exit Sub
        m.InitTPSohieu(TxtCT.Text)
        LbCT.Text = m.TenVattu
        TxtCT.Text = m.SoHieu
        f1 = 1
        CboThang_SelectedValueChanged(CboThang, New EventArgs())
        f1 = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdtp_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdtp.Click
        Cursor = Cursors.WaitCursor
        TxtCT.Text = FrmTP.ChonTP(TxtCT.Text)
        TxtCT_Leave(TxtCT, New EventArgs)
        Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InNVL()
        Dim i As Integer
        Dim sl As Double
        Dim mvt As Integer
        Dim thangdm As String = String.Empty
        Dim cot, dem As Integer
        ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
        ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten,Kq1,Kq2)  SELECT MaVattu, Vattu.SoHieu, Vattu.TenVattu, Sum(SoPS2Co), Sum(SoPS)  FROM ({0}) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo WHERE HethongTK.SoHieu LIKE '621%' AND ChungTu.MaLoai=2 AND ThangCT={1}{2} GROUP BY MaVattu, Vattu.SoHieu, Vattu.TenVattu", _
                            ChungTu2TKNC(-1), _
                            CboThang.SelectedValue, _
                            (IIf(m.MaSo > 0, String.Format(" AND ChungTu.MaTP={0}", m.MaSo), String.Empty))))
        For i = 1 To 20
            ExecSQLNonQuery("UPDATE BaoCaoCP2 set kq" + CStr(i) + "=0 where kq" + CStr(i) + " is null")
        Next
        Dim sql As String = String.Format("SELECT MaVattu, Sum(SoPS2Co) AS SL, Sum(SoPS) AS TT FROM {0} WHERE HethongTK.SoHieu LIKE '621%' AND ChungTu.MaLoai=1 AND ThangCT={1}{2} GROUP BY MaVattu", _
                                ChungTu2TKNC(1), _
                                CboThang.SelectedValue, _
                                (IIf(m.MaSo > 0, String.Format(" AND ChungTu.MaTP={0}", m.MaSo), String.Empty)))
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        Dim rsIndex As Integer = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET Kq1=Kq1-{0},Kq2=Kq2-{1} WHERE MaSo={2}", _
                                CStr(rsItem("sl")), _
                                CStr(rsItem("tt")), _
                                rsItem("MaVattu")))
        Loop
        With Grd
            For i = 0 To .Rows - 1
                .Row = i
                .Col = 8
                If Not IsNumeric(.Items(.Row).SubItems(.Col).Text) Then Exit For
                mvt = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                thangdm = ConvertToStrSafe(CboThang.SelectedValue + 1)
                dem = 0
                While dem = 0 And ConvertToDblSafe(thangdm) > 0
                    thangdm = ConvertToStrSafe(ConvertToDblSafe(thangdm) - 1)
                    dem = ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(maso) as f1 FROM dinhmuc WHERE manvl>0 and MaTP={0} AND Thang={1}", mvt, thangdm)))
                End While

                .Col = 4
                sl = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 18
                sl -= ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 20
                sl += ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                rs = ExecSQLReturnDT(String.Format("SELECT MaNVL, SoLuong, SoHieu,TenVattu,PL FROM DinhMuc INNER JOIN Vattu ON DinhMuc.MaNVL=Vattu.MaSo WHERE MaTP={0} AND Thang={1}", _
                                         mvt, _
                                         thangdm))
                rsIndex = 0
                Do While rsIndex < rs.Rows.Count
                    Dim rsItem As DataRow = rs.Rows(rsIndex)
                    rsIndex += 1 ' C15 Rs LOOP CONTROL
                    Dim RecordsAffectedCount As Integer
                    If rsItem("pl") = "X" Then
                        cot = .Col
                        .Col = 13
                        RecordsAffectedCount = ExecSQLNonQueryUpdateInsertDeleteQuery(String.Format("UPDATE BaoCaoCP2 SET Kq3=Kq3+{0} WHERE MaSo={1}", _
                                                                     CStr(sl * rsItem("soluong") * 100 / (100 - ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)) * (100 + ConvertToDblSafe(txtShTk(3).Text)) / 100), _
                                                                     rsItem("maNVL")))
                        .Col = cot
                    Else
                        RecordsAffectedCount = ExecSQLNonQueryUpdateInsertDeleteQuery(String.Format("UPDATE BaoCaoCP2 SET Kq3=Kq3+{0} WHERE MaSo={1}", _
                                                                     CStr(sl * rsItem("soluong") * (100 + ConvertToDblSafe(txtShTk(3).Text)) / 100), _
                                                                     rsItem("maNVL")))
                    End If
                    If RecordsAffectedCount = 0 Then
                        ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten,Kq3) VALUES ({0},'{1}',N'{2}',{3})", _
                                            rsItem("maNVL"), _
                                            rsItem("SoHieu"), _
                                            rsItem("TenVattu"), _
                                            CStr(sl * rsItem("soluong"))))
                        For j As Integer = 1 To 20
                            ExecSQLNonQuery("UPDATE BaoCaoCP2 set kq" + CStr(j) + "=0 where kq" + CStr(j) + " is null")
                        Next
                    End If
                Loop
            Next
        End With
        rs = Nothing
        rptFrom.InitForm("NVLTT.RPT", "SELECT * FROM BaoCaoCP2 ORDER BY SoHieu", "QNhatky")

        SetRptInfo()
        i = CboThang.SelectedValue
        RptSetDate(NgayCuoiThang(pNamTC, i))
        rptFrom.SetFormulas("Thang", i)
        rptFrom.SetFormulas("ThangCuoi", i)
        If m.MaSo > 0 Then rptFrom.SetFormulas("DG", String.Format("'{0} - {1}'", m.SoHieu, m.TenVattu))
        rptFrom.ReportWindowTitle = "Chi tiết chi phí nguyên vật liệu trực tiếp"
        rptFrom.ReportDestination = 1
        Me.Cursor = Cursors.Default
        InBaoCaoRPT()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LietKeTP()
        Dim sql As String = String.Format("SELECT MaTKNo, MaVattu, Sum(SoPS2No) AS SL, Vattu.SoHieu, Vattu.TenVattu, DonVi, HethongTK.SoHieu AS SHTK  FROM ({0}) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo  WHERE ThangCT={1} AND HethongTK.SoHieu LIKE '{2}%' AND MaTP={3} GROUP BY MaTKNo, MaVattu, Vattu.SoHieu, Vattu.TenVattu, DonVi, HethongTK.SoHieu ORDER BY HethongTK.SoHieu DESC, Vattu.SoHieu DESC", _
                                ChungTu2TKNC(-1), _
                                CboThang.SelectedValue, _
                                ShTkTP, _
                                ConvertToStrSafe(m.MaSo))
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        Dim rsIndex As Integer = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL


            Grd.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{1}{1}{6}{1}{7}", _
                            rsItem("shtk"), _
                            Chr(9), _
                            rsItem("SoHieu"), _
                            rsItem("TenVattu"), _
                            rsItem("DonVi"), _
                            Format(rsItem("sl"), Mask_2), _
                            rsItem("MaTkNo"), _
                            rsItem("MaVattu")), 0)
            ''rs.MoveNext()
        Loop
        ''rs.Close()
        rs = Nothing
        Grd.Row = 0
        If Chk.CheckState > 0 Then GiaBQ()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Xem_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Xem.Click
        Dim i As Integer, sh As String, ten As String, sl As Double, nvl As Double, nC As Double
        Dim sxc As Double, sxcn As Double, Tnvl As Double

        Me.Cursor = Cursors.WaitCursor
        ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
        With Grd
            For i = 0 To .Rows - 1
                .Row = i
                .Col = 1
                sh = .Items(.Row).SubItems(.Col).Text
                .Col = 2
                ten = .Items(.Row).SubItems(.Col).Text
                .Col = 4
                sl = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 9
                nvl = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                Tnvl = Tnvl + nvl
                .Col = 10
                nC = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 11
                sxc = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 24
                sxcn = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 12
                If .Items(.Row).SubItems(.Col).Text <> "" And .Items(.Row).SubItems(.Col).Text <> "..." Then
                    .Col = 16
                    nvl = nvl - ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                    Tnvl = Tnvl - ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                End If
                ExecSQLNonQuery("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten, Kq1,Kq2,Kq3,Kq4) VALUES (" + CStr(IIf(i = 0, 0, Lng_MaxValue("maso", "baocaocp2") + 1)) + ",'" + sh + "',N'" + ten + "'," + CStr(sl) + "," + CStr(nvl) + "," + CStr(nC) + "," + CStr(sxc + sxcn) + ")")
                .Col = 12
                If .Items(.Row).SubItems(.Col).Text <> "" And .Text <> "..." Then
                    sh = .Items(.Row).SubItems(.Col).Text
                    ten = Timten("tenvattu", .Items(.Row).SubItems(.Col).Text, "sohieu", "vattu")
                    .Col = 15
                    sl = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                    .Col = 16
                    nvl = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                    Tnvl = Tnvl + nvl
                    ExecSQLNonQuery("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten, Kq1,Kq2) VALUES (" + CStr(Lng_MaxValue("maso", "baocaocp2") + 1) + ",'" + sh + "',N'" + ten + "'," + CStr(sl) + "," + CStr(nvl) + ")")
                End If
            Next
        End With
        For i = 1 To 20
            ExecSQLNonQuery("UPDATE BaoCaoCP2 set kq" + CStr(i) + "=0 where kq" + CStr(i) + " is null")
        Next

        rptFrom.InitForm("GTCT.RPT", "SELECT * FROM BaoCaoCP2", "QNhatky")
        SetRptInfo()
        i = CboThang.SelectedValue
        RptSetDate(NgayCuoiThang(pNamTC, i))
        rptFrom.SetFormulas("Thang", i)
        rptFrom.SetFormulas("CPNVL", Tnvl)
        rptFrom.SetFormulas("ThangCuoi", i)

        rptFrom.ReportWindowTitle = "Giá thành thành phẩm hoàn thành trong kỳ"
        Me.Cursor = Cursors.WaitCursor
        InBaoCaoRPT()
    End Sub
    Sub TheGiaThanh()
        Dim i As Integer, sh As String, ten As String, sl As Double, nvl As Double, nC As Double, sxc As Double, sxcn As Double, Tnvl As Double
        Dim rs As DataTable, rsdk As DataTable, rsck As DataTable
        Dim Ma154 As Integer, khts As Double

        Ma154 = ConvertToIntSafe(Timten("maso", TxtCT.Text, "sohieu", "tp154"))
        Me.Cursor = Cursors.WaitCursor
        Ngay = MedNgay.Text
        ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
        With Grd
            For i = 0 To .Rows - 1
                .Row = i
                .Col = 1
                sh = .Items(.Row).SubItems(.Col).Text
                .Col = 2
                ten = .Items(.Row).SubItems(.Col).Text
                .Col = 4
                sl = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 9
                nvl = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                Tnvl = Tnvl + nvl
                .Col = 10
                nC = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 11
                sxc = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 24
                sxcn = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                .Col = 12
                If .Items(.Row).SubItems(.Col).Text <> "" And .Items(.Row).SubItems(.Col).Text <> "..." Then
                    .Col = 16
                    nvl = nvl - ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                    Tnvl = Tnvl - ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                End If
                rs = New DataTable
                rs = ExecSQLReturnDT("select * from thanhpham where mact=" + CStr(CboSohieu.SelectedValue) + " and ngay='" + Format(CDate(Ngay), Mask_DB) + "' and ma154=" + CStr(Ma154) + " and matp=" + Timten("maso", sh, "sohieu", "vattu"))
                If rs.Rows.Count > 0 Then
                    rsdk = New DataTable
                    rsdk = ExecSQLReturnDT("select * from thanhphamdd where mact<" + CStr(CboSohieu.SelectedValue) + " and ngay<='" + Format(Ngay, Mask_DB) + "' and matp=" + Timten("maso", sh, "sohieu", "vattu") + " and makt=" + CStr(rs.Rows(0)("MaCT")) + CStr(rs.Rows(0)("MaTP")))
                    rsck = New DataTable
                    rsck = ExecSQLReturnDT("select * from thanhphamdd where mact=" + CStr(CboSohieu.SelectedValue) + " and ngay='" + Format(Ngay, Mask_DB) + "' and ma154=" + CStr(Ma154) + " and matp=" + Timten("maso", sh, "sohieu", "vattu"))
                    If rsck.Rows.Count > 0 And rsdk.Rows.Count > 0 Then
                        ExecSQLNonQuery("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten, Kq1,Kq2,Kq3,Kq4,Kq5,Kq6,Kq7,Kq8,Kq9,Kq10,Kq11,Kq12) VALUES (" + CStr(IIf(i = 0, 0, Lng_MaxValue("maso", "baocaocp2") + 1)) + ",'" + sh + "',N'" + ten + "'," + CStr(sl) + "," + CStr(nvl) + "," + CStr(nC) + "," + CStr(sxc + sxcn) + "," + CStr(rsck.Rows(0)("soluong")) + "," + CStr(rsck.Rows(0)("CPNVL")) + "," + CStr(rsck.Rows(0)("cpnc")) + "," + CStr(rsck.Rows(0)("cpsxc") + rsck.Rows(0)("cpsxcn")) + "," + CStr(rsdk.Rows(0)("soluong")) + "," + CStr(rsdk.Rows(0)("CPNVL")) + "," + CStr(rsdk.Rows(0)("cpnc")) + "," + CStr(rsdk.Rows(0)("cpsxc") + rsdk.Rows(0)("cpsxcn")) + ")")
                    Else
                        If rsck.Rows.Count > 0 Then
                            ExecSQLNonQuery("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten, Kq1,Kq2,Kq3,Kq4,Kq5,Kq6,Kq7,Kq8) VALUES (" + CStr(IIf(i = 0, 0, Lng_MaxValue("maso", "baocaocp2") + 1)) + ",'" + sh + "',N'" + ten + "'," + CStr(sl) + "," + CStr(nvl) + "," + CStr(nC) + "," + CStr(sxc + sxcn) + "," + CStr(rsck.Rows(0)("soluong")) + "," + CStr(rsck.Rows(0)("CPNVL")) + "," + CStr(rsck.Rows(0)("cpnc")) + "," + CStr(rsck.Rows(0)("cpsxc") + rsck.Rows(0)("cpsxcn")) + ")")
                        Else
                            If rsdk.Rows.Count > 0 Then
                                ExecSQLNonQuery("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten, Kq1,Kq2,Kq3,Kq4,Kq9,Kq10,Kq11,Kq12) VALUES (" + CStr(IIf(i = 0, 0, Lng_MaxValue("maso", "baocaocp2") + 1)) + ",'" + sh + "',N'" + ten + "'," + CStr(sl) + "," + CStr(nvl) + "," + CStr(nC) + "," + CStr(sxc + sxcn) + "," + CStr(rsdk.Rows(0)("soluong")) + "," + CStr(rsdk.Rows(0)("CPNVL")) + "," + CStr(rsdk.Rows(0)("cpnc")) + "," + CStr(rsdk.Rows(0)("cpsxc") + rsdk.Rows(0)("cpsxcn")) + ")")
                            Else
                                ExecSQLNonQuery("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten, Kq1,Kq2,Kq3,Kq4) VALUES (" + CStr(IIf(i = 0, 0, Lng_MaxValue("maso", "baocaocp2") + 1)) + ",'" + sh + "',N'" + ten + "'," + CStr(sl) + "," + CStr(nvl) + "," + CStr(nC) + "," + CStr(sxc + sxcn) + ")")
                            End If
                        End If
                    End If
                Else
                    ExecSQLNonQuery("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten, Kq1,Kq2,Kq3,Kq4) VALUES (" + CStr(IIf(i = 0, 0, Lng_MaxValue("maso", "baocaocp2") + 1)) + ",'" + sh + "',N'" + ten + "'," + CStr(sl) + "," + CStr(nvl) + "," + CStr(nC) + "," + CStr(sxc + sxcn) + ")")
                End If
                .Col = 12
                If .Items(.Row).SubItems(.Col).Text <> "" And .Items(.Row).SubItems(.Col).Text <> "..." Then
                    sh = .Items(.Row).SubItems(.Col).Text
                    ten = Timten("tenvattu", .Items(.Row).SubItems(.Col).Text, "sohieu", "vattu")
                    .Col = 15
                    sl = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                    .Col = 16
                    nvl = ConvertToDblSafe(.Items(.Row).SubItems(.Col).Text)
                    Tnvl = Tnvl + nvl
                    ExecSQLNonQuery("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten, Kq1,Kq2) VALUES (" + CStr(Lng_MaxValue("maso", "baocaocp2") + 1) + ",'" + sh + "',N'" + ten + "'," + CStr(sl) + "," + CStr(nvl) + ")")
                End If
            Next
        End With
        For i = 1 To 20
            ExecSQLNonQuery("UPDATE BaoCaoCP2 set kq" + CStr(i) + "=0 where kq" + CStr(i) + " is null")
        Next
        rptFrom.InitForm("TGT.RPT", "SELECT * FROM BaoCaoCP2", "QNhatky")
        SetRptInfo()
        i = CboThang.SelectedValue
        RptSetDate(NgayCuoiThang(pNamTC, i))
        rptFrom.SetFormulas("Thang", i)
        rptFrom.SetFormulas("ThangCuoi", i)
        rptFrom.SetFormulas("CPNVL", Tnvl)
        rptFrom.SetFormulas("6271", PSTKCP("6271", i, i, m.MaSo))
        rptFrom.SetFormulas("6272", PSTKCP("6272", i, i, m.MaSo))
        rptFrom.SetFormulas("6273", PSTKCP("6273", i, i, m.MaSo))
        rptFrom.SetFormulas("6274", PSTKCP("6274", i, i, m.MaSo))
        rptFrom.SetFormulas("6277", PSTKCP("6277", i, i, m.MaSo))
        rptFrom.SetFormulas("6278", PSTKCP("6278", i, i, m.MaSo))
        khts = ExecSQLNonQuery("select sum(sops)as f1 from chungtu inner join hethongtk on chungtu.matkno=hethongtk.maso where chungtu.matp=" + CStr(Ma154) + " and maloai=12 and hethongtk.sohieu='627'")
        If m.MaSo > 0 Then rptFrom.SetFormulas("DG", "'" + m.SoHieu + " - " + m.TenVattu + "'")
        rptFrom.SetFormulas("lohang", "'" + TxtCT.Text + " - " + Timten("tenvattu", TxtCT.Text, "sohieu", "tp154") + "'")

        rptFrom.ReportWindowTitle = "Thẻ giá thành sản phẩm dịch vụ"
        Me.Cursor = Cursors.Default
        InBaoCaoRPT()
    End Sub

    Sub XemDD()
        Dim rs As DataTable, sl As Double, nC As Double, nvl As Double, sxc As Double
        Dim thang As Integer, sl1 As Double, nc1 As Double, nvl1 As Double, sxc1 As Double
        Dim MaSo As Long, MaCT As Long, sxcn As Double, sxcn1 As Double

        Me.Cursor = Cursors.WaitCursor
        thang = CboThang.SelectedValue
        rs = New DataTable
        rs = ExecSQLReturnDT("select vt.maso,vt.sohieu,vt.tenvattu,tk.masokho from (vattu vt inner join dinhmuc dm on vt.maso=dm.matp)inner join tonkho tk on vt.maso=tk.mavattu where tk.masokho=" + CStr(CboKho(1).SelectedValue) + " group by vt.maso,vt.sohieu,vt.tenvattu,tk.masokho order by vt.maso")
        If rs.Rows.Count = 0 Then Exit Sub
        ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
        If CboSohieu.Items.ItemsBase.Count = 0 Or CboSohieu.SelectedIndex < 0 Then Exit Sub
        MaCT = CboSohieu.SelectedValue
        For Each rsitem As DataRow In rs.Rows
            Dim abc As String
            abc = rsitem("TenVattu")
            sl = GetSelectValue("select max(SoLuong) as f1,max(CPNC) as f2,max(CPSXC) as f3,max(CPSXCN) as f4,max(CPNVL) as f5 from thanhphamdd where mact<" + CStr(MaCT) + " and matp=" + CStr(rsitem("MaSo")) + " and makhonvl=" + CStr(rsitem("MaSoKho")) + " and ngay=(select max(ngay) from thanhphamdd where mact<" + CStr(MaCT) + " and matp=" + CStr(rsitem("MaSo")) + " and ngay<='" + Format(Ngay, Mask_DB) + "' and makhonvl=" + CStr(rsitem("MaSoKho")) + ") group by ngay", nC, sxc, sxcn, nvl)
            If sl <> 0 Or nC <> 0 Or sxc <> 0 Or sxcn <> 0 Or nvl <> 0 Then ExecSQLNonQuery("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten, Kq1,Kq2,Kq3,Kq4) VALUES (" + CStr(Lng_MaxValue("maso", "baocaocp2") + 1) + ",'" + rsitem("SoHieu") + "',N'" + rsitem("TenVattu") + "'," + CStr(sl) + "," + CStr(nvl) + "," + CStr(nC) + "," + CStr(sxc) + ")")
            sl1 = GetSelectValue("select sum(SoLuong) as f1,sum(CPNC) as f2,sum(CPSXC) as f3,sum(CPSXCN) as f4,sum(CPNVL) as f5 from thanhphamdd where mact=" + CStr(MaCT) + " and matp=" + CStr(rsitem("MaSo")) + " and makhonvl=" + CStr(rsitem("MaSoKho")) + " and ngay='" + Format(CDate(Ngay), Mask_DB) + "'", nc1, sxc1, sxcn1, nvl1)
            If sl1 <> 0 Then
                ExecSQLNonQuery("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten, Kq1,Kq2,Kq3,Kq4,Kq5) VALUES (" + CStr(Lng_MaxValue("maso", "baocaocp2") + 1) + ",'" + rsitem("SoHieu") + ".',N'" + rsitem("TenVattu") + "'," + CStr(sl1) + "," + CStr(nvl1) + "," + CStr(nc1) + "," + CStr(sxc1 + sxcn1) + ",1)")
            Else
                MaSo = GetSelectValue("select maso as f1 from thanhphamdd where mact=" + CStr(MaCT) + " and matp=" + CStr(rsitem("MaSo")) + " and makhonvl=" + CStr(rsitem("MaSoKho")) + " and ngay='" + Format(Ngay, Mask_DB) + "'")
                If sl <> 0 And MaSo = 0 Then ExecSQLNonQuery("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten, Kq1,Kq2,Kq3,Kq4,Kq5) VALUES (" + CStr(Lng_MaxValue("maso", "baocaocp2") + 1) + ",'" + rsitem("SoHieu") + ".',N'" + rsitem("TenVattu") + "'," + CStr(sl) + "," + CStr(nvl) + "," + CStr(nC) + "," + CStr(sxc + sxcn) + ",1)")
            End If
        Next
        For i = 1 To 20
            ExecSQLNonQuery("UPDATE BaoCaoCP2 set kq" + CStr(i) + "=0 where kq" + CStr(i) + " is null")
        Next
        rptFrom.InitForm("GTCTDD.RPT", "SELECT * FROM BaoCaoCP2", "QNhatky")
        SetRptInfo()
        RptSetDate(NgayCuoiThang(pNamTC, thang))
        rptFrom.SetFormulas("Thang", thang)
        rptFrom.SetFormulas("ThangCuoi", thang)

        rptFrom.ReportWindowTitle = "Thành phẩm dở dang"
        Me.Cursor = Cursors.Default
        InBaoCaoRPT()
    End Sub

    Sub themchiphinhom()
        Dim i As Integer, j As Integer, loai As Integer, tien As Double
        With Grd
            For i = 0 To .Rows - 1
                If Luoi(Grd, i, 0) = "" Then Exit For
                If loai = ConvertToDblSafe(Luoi(Grd, i, 22)) Then GoTo Boqua
                loai = ConvertToDblSafe(Luoi(Grd, i, 22))
                tien = ConvertToDblSafe(Luoi(Grd, i, 23))
                If tien > 0 And loai > 0 Then
                    For j = i + 1 To .Rows - 1
                        If Luoi(Grd, j, 0) = "" Then Exit For
                        If loai = ConvertToDblSafe(Luoi(Grd, j, 22)) Then .Row = j : .Col = 23 : .Items(.Row).SubItems(.Col).Text = tien
                    Next
                End If
Boqua:
            Next
        End With
    End Sub

    Sub themchiphinhomvaoLabel(ByVal thang As Integer)
        Dim i As Integer, j As Integer, loai As Integer, tien As Double, tong As Double
        With Grd
            For i = 0 To .Rows - 1
                If Luoi(Grd, i, 0) = "" Then Exit For
                If loai = ConvertToDblSafe(Luoi(Grd, i, 22)) Or ConvertToDblSafe(Luoi(Grd, i, 22)) = 0 Then GoTo Boqua
                loai = ConvertToDblSafe(Luoi(Grd, i, 22))
                tien = GetSelectValue("select sops as f1 from chungtu where thangct=" + CStr(thang) + " and matp=" + CStr(GetSelectValue("select maso as f1 from tp154 where maphanloai1=" + CStr(Luoi(Grd, i, 22)))))
                If tien > 0 And loai > 0 Then
                    For j = i - 1 To 0 Step -1
                        If loai = ConvertToDblSafe(Luoi(Grd, j, 22)) Then Exit For
                    Next
                    If j = -1 Then tong = tong + tien
                    .Col = 23 : .Row = i
                    .Text = tien
                End If
Boqua:
            Next
        End With
        LbGia(3).Text = Format(tong, Mask_0)
    End Sub

    Private Sub CboThang_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboThang.SelectedValueChanged
        If m.MaSo = 0 Then
            If Chk.CheckState = CheckState.Unchecked Then LbGia(0).Text = Format(SoDuTKSH(txtShTk(1).Text, CboThang.SelectedValue), Mask_0)
            LbGia(1).Text = Format(SoDuTKSH(IIf(Strings.Len(txtShTk(2).Text) = 0, "622", txtShTk(2).Text), CboThang.SelectedValue), Mask_0)
            LbGia(2).Text = Format(SoDuTKSH("627", CboThang.SelectedValue), Mask_0)
        Else
            LbGia(0).Text = Format(SoPSCPTP(txtShTk(1).Text, m, CboThang.SelectedValue) + m.SoCPNVLPB(CboThang.SelectedValue, CboThang.SelectedValue), Mask_0)
            LbGia(1).Text = Format(SoPSCPTP(txtShTk(2).Text, m, CboThang.SelectedValue) + m.SoCPNCPB(CboThang.SelectedValue, CboThang.SelectedValue), Mask_0)
            LbGia(2).Text = Format(SoPSCPTP("627", m, CboThang.SelectedValue) + m.SoCPSXC(CboThang.SelectedValue, CboThang.SelectedValue), Mask_0)
        End If
        LbGia(3).Text = ""
        If f1 = 1 Then Exit Sub
        f1 = 1

        Int_RecsetToCbo(String.Format("SELECT MaCT As F2,SoHieu As F1 FROM ThanhPham WHERE Thang={0} GROUP BY SoHieu,MaCT", CboThang.SelectedValue), _
            CboSohieu, _
            -1)
        XoaPhieuTrenManHinh()
        f1 = 0
    End Sub

End Class
