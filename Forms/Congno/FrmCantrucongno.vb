Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Globalization
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmCantrucongno
    Dim ct131 As String, ct331 As String
    Private Sub Command_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Command_0.Click, _Command_1.Click, _Command_2.Click, _Command_3.Click
        Dim Index As Integer = Array.IndexOf(Command, sender)
        Dim tdau, tcuoi As Integer

        Select Case Index
            Case 1
                'đóng form
                Close()
            Case 2
                'xem in
            Case 0
                'thực hiện
                With FrmChungtu
                    .khoi_tao()
                    .loai1.Tag = "1"
                    .loaino.Tag = "1"
                    Dim setloaict As Boolean = .SetLoaiEnable
                    .SetLoaiEnable = True
                    .OptLoai(0).Checked = True
                    .SetLoaiEnable = setloaict
                    If ConvertToDblSafe(conlai131.Text) > ConvertToDblSafe(conlai331.Text) Then
                        .CboThang.SelectedIndex = CboThang(1).SelectedIndex
                        .txt(0).Text = "CTCN" & IIf(CboThang(1).SelectedValue < 10, "0", "") & CboThang(1).SelectedValue.ToString & "001"
                        .MedNgay(0).Text = NgayCuoiThang(pNamTC, CboThang(1).SelectedValue)
                        .MedNgay(1).Text = NgayCuoiThang(pNamTC, CboThang(1).SelectedValue)
                        .txt(0).Text = SHCtuMoi(.txt(0).Text)
                        .txt(1).Text = "Cấn trừ công nợ của khách hàng " & Timten("ten", txtshkh.Text, "sohieu", "khachhang") & " với những hóa đơn: " & ct131 & " và: " & ct331

                        .txtchungtu(0).Text = taikhoanconnhat("131")
                        ._txtchungtu_LostFocus(.txtchungtu(0), New EventArgs)
                        .txtchungtu(2).Text = txtshkh.Text
                        ._txtchungtu_LostFocus(.txtchungtu(2), New EventArgs)
                        .txtchungtu(6).Text = ConvertToDblSafe(Cantru.Text)
                        ._txtchungtu_LostFocus(.txtchungtu(6), New EventArgs)
                        .CmdChitiet_Click(.CmdChitiet, New EventArgs)

                        .txtchungtu(0).Text = taikhoanconnhat("331")
                        ._txtchungtu_LostFocus(.txtchungtu(0), New EventArgs)
                        .txtchungtu(2).Text = txtshkh.Text
                        ._txtchungtu_LostFocus(.txtchungtu(2), New EventArgs)
                        .txtchungtu(5).Text = ConvertToDblSafe(Cantru.Text)
                        ._txtchungtu_LostFocus(.txtchungtu(5), New EventArgs)
                        .CmdChitiet_Click(.CmdChitiet, New EventArgs)
                    End If
                    .ShowDialog()
                    .loai1.Tag = "0"
                    .loaino.Tag = "0"
                End With
            Case (3)
                'liệt kê
                If CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
                tdau = CboThang(0).SelectedValue
                tcuoi = CboThang(1).SelectedValue

                If ConvertToDblSafe(txtshkh.Tag) = 0 Then
                    ErrMsg(er_SHKhachHang)
                    txtshkh.Focus()
                    Exit Sub
                End If

                Dim tk As New ClsTaikhoan
                Dim tien, thanhtoan, dauky As Double

                ColumnSetUp(Grd, 0, 1050, ContentAlignment.MiddleLeft)
                ColumnSetUp(Grd, 1, 2500, ContentAlignment.MiddleLeft)
                ColumnSetUp(Grd, 2, 1000, ContentAlignment.MiddleRight)
                ColumnSetUp(Grd, 3, 1000, ContentAlignment.MiddleRight)
                ColumnSetUp(Grd, 4, 300, ContentAlignment.MiddleCenter)
                ColumnSetUp(Grd, 5, 1800, ContentAlignment.MiddleRight)

                tk.InitTaikhoanSohieu("131")
                DoiChieuCN(tdau, tcuoi, ConvertToDblSafe(txtshkh.Tag), tk, Grdview(0), dauky, tien, thanhtoan)
                dauky131.Text = Format(dauky, Mask_0)
                tien131.Text = Format(tien, Mask_0)
                thanhtoan131.Text = Format(thanhtoan, Mask_0)
                conlai131.Text = dauky + tien - thanhtoan

                tk.InitTaikhoanSohieu("331")
                DoiChieuCN(tdau, tcuoi, ConvertToDblSafe(txtshkh.Tag), tk, Grdview(1), dauky, tien, thanhtoan)
                dauky331.Text = Format(dauky, Mask_0)
                tien331.Text = Format(tien, Mask_0)
                thanhtoan331.Text = Format(thanhtoan, Mask_0)
                conlai331.Text = Format(dauky - tien + thanhtoan, Mask_0)
        End Select
    End Sub

    Private Sub Chk_MouseUp(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles Chk1.MouseUp, Chk2.MouseUp
        Dim Index As Integer = Array.IndexOf(chk, eventSender)
        Dim Button As Integer = ConvertToDblSafe(eventArgs.Button)
        Dim Shift As Integer = Control.ModifierKeys \ &H10000
        Dim X As Single = (eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        Dim i As Integer
        With Grdview(Index)
            .Col = 4
            .Row = 0
            If chk(Index).CheckState Then
                chk(Index).Text = Ngonngu("Huỷ tất cả", "Cancel all")
                While i < .Rows
                    .Items(.Row).SubItems(.Col).Text = "X"
                    If Index = 0 Then .Items(.Row).SubItems(5).Text = Format(ConvertToDblSafe(.Items(.Row).SubItems(2).Text) - ConvertToDblSafe(.Items(.Row).SubItems(3).Text), Mask_0)
                    i += 1
                    Grdview(0).Row = i
                End While
            Else
                chk(Index).Text = Ngonngu("Chọn tất cả", "Choose all")
                While i < .Rows
                    .Items(.Row).SubItems(.Col).Text = "-"
                    If Index = 0 Then .Items(.Row).SubItems(5).Text = 0
                    i += 1
                    .Row = i
                End While
            End If
        End With

        Dim tong As Double = 0
        If (Index = 0) Then
            With Grdview(0)
                ct131 = ""
                i = 0
                .Row = 0
                While i < .Rows
                    If .Items(.Row).SubItems(4).Text = "X" Then
                        tong += ConvertToDblSafe(.Items(.Row).SubItems(5).Text)
                        If ct131 = "" Then
                            ct131 = .Items(.Row).SubItems(0).Text
                        Else
                            ct131 = ct131 & ", " & .Items(.Row).SubItems(0).Text
                        End If
                    End If
                    i += 1
                End While
            End With
            Cantru.Text = Format(tong, Mask_0)
        End If
        With Grdview(1)
            ct331 = ""
            i = 0
            .Row = 0
            While i < .Rows
                If .Items(.Row).SubItems(4).Text = "X" Then
                    If ct331 = "" Then
                        ct331 = .Items(.Row).SubItems(0).Text
                    Else
                        ct331 = ct331 & ", " & .Items(.Row).SubItems(0).Text
                    End If
                End If
                i += 1
            End While
        End With
    End Sub

    Private Sub DoiChieuCN(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef mkh As Integer, ByVal TK As ClsTaikhoan, ByVal list As ListViewEx.ListviewExt, ByRef dauky As Double, ByRef tien As Double, ByRef thanhtoan As Double)
        Dim sqlw2, sql, sqlw1 As String
        Dim X, dn, DC As Double
        Dim loai, i As Integer
        Dim kh As New clsKhachHang
        Dim rs, rs1 As DataTable
        kh.InitKhachHangMaSo(mkh)

        Dim MienTru As String
        Dim QDuPhong As String
        Dim wsql As String = WThang("ThangCT", tdau, tcuoi)

        loai = TK.kieu
        kh.SoDuKH(ThangTruoc(tdau), dn, DC, X, 0, TK.sohieu)
        sqlw1 = String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", TK.sohieu)
        sqlw2 = String.Format(" AND TK.SoHieu LIKE '{0}%'", TK.sohieu)

        Dim QNhatKy As String = String.Format("SELECT MaCT,Sum( CASE WHEN (MaTKNo>0) THEN SoPS ELSE 0 END) AS TPS FROM ChungTu WHERE {0} GROUP BY MaCT", wsql)
        If loai > 0 Then
            MienTru = String.Format("SELECT chungtu.MaCT FROM {0} WHERE MaKHC={1} AND {2}{3} GROUP BY MaCT", _
                                        ChungTu2TKNC(1), _
                                        ConvertToStrSafe(mkh), _
                                        wsql, _
                                        sqlw1)
            QDuPhong = String.Format("SELECT MaCT FROM {0} WHERE MaKH={1} AND {2}{3} GROUP BY MaCT", _
                                            ChungTu2TKNC(-1), _
                                            ConvertToStrSafe(mkh), _
                                            wsql, _
                                            sqlw1)
            sql = String.Format("SELECT DISTINCT 1 AS Loai,chungtu.NgayCT,ChungTu.SoHieu AS SHCT,CASE WHEN (MaVattu>0) THEN Vattu.SoHieu ELSE HethongTK.SoHieu END AS SoHieu,case when mavattu>0 then TenVattu else '...' end as [TenVatTu],case when mavattu>0 then donvi else '...' end as [donvi],Sum(SoPS2No) AS Luong,Sum(SoPS) AS Tien,chungtu.DienGiai{0},max(ChungTu.MaSo) AS MaSo, CASE WHEN (HethongTK.Loai=1 OR HethongTK.Loai=6) AND HethongTK.TK_ID<>{1} THEN {2} ELSE TK_ID END as TK_ID FROM (({3}) LEFT JOIN  Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN ({4}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT WHERE (TK_ID={5} OR TK_ID={1} OR HethongTK.SoHieu LIKE '138%' OR HethongTK.SoHieu LIKE '338%' OR ((HethongTK.Loai=1 OR HethongTK.Loai=6) AND MaKHC={6})) GROUP BY chungtu.NgayCT,ChungTu.SoHieu,CASE WHEN (MaVattu>0) THEN Vattu.SoHieu ELSE HethongTK.SoHieu END, case when mavattu>0 then TenVattu else '...' end ,case when mavattu>0 then donvi else '...' end,chungtu.DienGiai{0},CASE WHEN (HethongTK.Loai=1 OR HethongTK.Loai=6) AND HethongTK.TK_ID<>{1} THEN {2} ELSE TK_ID END ", _
                        (IIf(pNN > 0, String.Empty, String.Empty)), _
                        ConvertToStrSafe(GTGTKT_ID), _
                        ConvertToStrSafe(TKVT_ID), _
                        ChungTu2TKNC(-1), _
                        MienTru, _
                        TKVT_ID, _
                        ConvertToStrSafe(mkh))

            sql = String.Format("{0} UNION SELECT DISTINCT 1 AS Loai,chungtu.NgayCT,ChungTu.SoHieu AS SHCT,'TSCD' AS SH,ChungTu.DienGiai,'...' AS Dvt,1 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM ({2}) INNER JOIN ({3}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT WHERE (TK_ID={4})", _
                        sql, _
                        (IIf(pNN > 0, String.Empty, String.Empty)), _
                        ChungTu2TKNC(-1), _
                        MienTru, _
                        TSCD_ID)
            sql = String.Format("{0} UNION SELECT DISTINCT 1 AS Loai,chungtu.NgayCT,ChungTu.SoHieu AS SHCT,'' AS SH,ChungTu.DienGiai,'...' AS Dvt,0 AS Luong,SoPS-TPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,TK_ID FROM ({2}) INNER JOIN ({3}) AS QNhatKy ON ChungTu.MaCT=QNhatKy.MaCT WHERE MaTKNo=0 AND MaKHC={4} AND SoPS<>TPS AND MaLoai=1 AND (ChungTu.GhiChu like '138%') AND {5}{6}", _
                        sql, _
                        (IIf(pNN > 0, String.Empty, String.Empty)), _
                        ChungTu2TKNC(1), _
                        QNhatKy, _
                        mkh, _
                        wsql, _
                        sqlw1)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.NgayCT,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM {2} WHERE (TK.SoHieu LIKE '11%' OR TK.SoHieu LIKE '141%' OR TK.SoHieu LIKE '{3}%' OR TK.SoHieu LIKE '311%' OR TK.SoHieu LIKE '336%' OR TK.SoHieu LIKE '15%'  OR TK.SoHieu LIKE '515%'  OR TK.SoHieu LIKE '511%'  OR TK.SoHieu LIKE '711%' OR TK.SoHieu LIKE '3331%' OR TK.SoHieu LIKE '{4}%' OR TK.SoHieu LIKE '413%' OR TK.Loai=6) AND MaKH={5} AND {6}{7}", _
                        sql, _
                        (IIf(pNN > 0, String.Empty, String.Empty)), _
                        ChungTu2TKNC(0), _
                        pSHPT, _
                        pVATV, _
                        ConvertToStrSafe(mkh), _
                        wsql, _
                        sqlw1)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.NgayCT,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai,ChungTu.MaSo,0 AS TK_ID FROM ({1}) INNER JOIN ({2}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT WHERE (HethongTK.SoHieu LIKE '11%' OR HethongTK.SoHieu LIKE '136%') AND MaTKNo=0", _
                        sql, _
                        ChungTu2TKNC(1), _
                        MienTru)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.NgayCT,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM {2} WHERE MaKHC=MaKH AND MaKH={3} AND TK_ID={4} AND {5}{6}", _
                        sql, _
                        (IIf(pNN > 0, String.Empty, String.Empty)), _
                        ChungTu2TKNC(-1), _
                        mkh, _
                        ConvertToStrSafe(TKCNPT_ID), _
                        wsql, _
                        sqlw1)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.NgayCT,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM ({2}) INNER JOIN ({3}) AS QDuPhong ON ChungTu.MaCT=QDuPhong.MaCT WHERE (HethongTK.SoHieu LIKE '635%' AND TK.SoHieu LIKE '11%'){4}", _
                        sql, _
                        (IIf(pNN > 0, String.Empty, String.Empty)), _
                        ChungTu2TKNC(0), _
                        QDuPhong, _
                        sqlw1)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.NgayCT,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM ({2}) INNER JOIN ({3}) AS QDuPhong ON ChungTu.MaCT=QDuPhong.MaCT WHERE (HethongTK.SoHieu LIKE '331%' AND TK.SoHieu LIKE '144%'){4}", _
                        sql, _
                        (IIf(pNN > 0, String.Empty, String.Empty)), _
                        ChungTu2TKNC(0), _
                        QDuPhong, _
                        sqlw1)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.NgayCT,ChungTu.SoHieu AS SHCT,TK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM ({2}) INNER JOIN ({3}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT WHERE (HethongTK.SoHieu LIKE '152%' AND TK.SoHieu LIKE '11%'){4}", _
                        sql, _
                        (IIf(pNN > 0, String.Empty, String.Empty)), _
                        ChungTu2TKNC(0), _
                        MienTru, _
                        sqlw1)

            rs = ExecSQLReturnDT(String.Format("SELECT t2.*,t1.TK_ID,t1.tien FROM ({0}) As t1 inner join chungtu t2 on t1.maso=t2.maso WHERE t1.loai=1", sql))
            ExecSQLNonQuery("DELETE FROM BKNhomPS")
            Dim rsIndex As Integer = 0
            While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                ExecSQLNonQuery(String.Format("INSERT into BKNhomPS(shtk,mact,sohieu,DienGiai,sopsno,sops2no,ngay,sopsco) values('{1}',{2},'{3}',N'{4}',{5},{6},'{7}',{8})", _
                                    Lng_MaxValue("maso", "BKNhomPS") + 1, _
                                    rsItem("MaSo"), _
                                    rsItem("MaCT"), _
                                    rsItem("SoHieu"), _
                                    rsItem("DienGiai"), _
                                    rsItem("tien"), _
                                    rsItem("SoXuat"), _
                                    Format(CDate(rsItem("NgayCT")), Mask_DB), _
                                    rsItem("TK_ID")))
                rs1 = ExecSQLReturnDT("SELECT sohieu,mact,ngayct FROM chungtu WHERE ct_id=" & rsItem("MaCT"))
                Dim rs1Index As Integer = 0
                While rs1Index < rs1.Rows.Count
                    Dim rs1Item As DataRow = rs1.Rows(rs1Index)
                    rs1Index += 1 ' C15 Rs LOOP CONTROL
                    ExecSQLNonQuery(String.Format("UPDATE BKNhomPS set shdu='{0}',ngaygs='{1}' WHERE shtk='{2}'", _
                                        rs1Item("SoHieu"), _
                                        Format(CDate(rs1Item("NgayCT")), Mask_DB), _
                                        rsItem("MaSo")))
                End While
            End While
            'X = ConvertToDblSafe(GetSelectValue("SELECT Sum(sopsno)-sum(sops2No) AS F1,Sum(ABS(sopsno-sops2No)) AS F2 FROM BKNhomPS", Y))
            'sql = ""
            'For i = tdau To tcuoi
            '    sql = String.Format("{0}+no_{1}", sql, ConvertToStrSafe(i))
            'Next
            'sql = Strings.Right(sql, sql.Length - 1)
            'TToanTK = ConvertToDblSafe(GetSelectValue(String.Format("SELECT {0} as f1 FROM sodukhachhang WHERE makhachhang={1}", _
            '                                                sql, _
            '                                                ConvertToStrSafe(mkh))))
            'TToanTK = ConvertToDblSafe(TToanTK - ConvertToDblSafe(GetSelectValue("SELECT sum(sops2no) as f1 FROM BKNhomPS")))

            'rptFrom.SetFormulas("TToanTK", TToanTK)
            'rptFrom.SetFormulas("ThanhTienX", String.Format("'{0} đồng'", ToVNText(dn - DC + X - TToanTK)))

            'rptFrom.SetFormulas("TenTK", String.Format("'{0}{1} - {2}'", Ngonngu("Bên cung cấp: ", "Providers: "), kh.SoHieu, kh.Ten))
            dauky = DC - dn
        Else
            MienTru = String.Format("SELECT MaCT FROM {0} WHERE (MaLoai=8 OR MaLoai=0) AND MaKH={1} AND {2}{3} GROUP BY MaCT", ChungTu2TKNC(-1), ConvertToStrSafe(mkh), wsql, sqlw1)
            QDuPhong = String.Format("SELECT MaCT FROM {0} WHERE MaKHC={1} AND {2}{3} GROUP BY MaCT", ChungTu2TKNC(1), ConvertToStrSafe(mkh), wsql, sqlw1)
            sql = "SELECT DISTINCT 1 AS Loai,chungtu.ngayct,ChungTu.SoHieu AS SHCT,CASE WHEN (MaVattu>0) THEN Vattu.SoHieu ELSE HethongTK.SoHieu END AS SoHieu,TenVattu,DonVi,SoPS2Co AS Luong,SoPS AS Tien,chungtu.DienGiai" & (IIf(pNN > 0, String.Empty, String.Empty)) & ",ChungTu.MaSo,TK_ID FROM ((" & ChungTu2TKNC(1) & ") LEFT JOIN  Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN (" + MienTru + ") AS MienTru ON ChungTu.MaCT=MienTru.MaCT" & " WHERE TK_ID=" & TKDT_ID & " OR TK_ID=" & ConvertToStrSafe(TKTNBT_ID) & " OR TK_ID=" & ConvertToStrSafe(GTGTPN_ID) & " OR HethongTK.Loai=7 OR HethongTK.SoHieu LIKE '138%' OR HethongTK.SoHieu LIKE '338%'"
            sql = String.Format("{0} UNION SELECT 1 AS Loai,chungtu.ngayct,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM {2} WHERE MaKHC<>MaKH AND MaKH={3} AND TK_ID={4} AND MaTKTCNo=MaTKTCCo AND {5}{6}", sql, (IIf(pNN > 0, String.Empty, String.Empty)), ChungTu2TKNC(-1), mkh, ConvertToStrSafe(TKCNKH_ID), wsql, sqlw1)
            sql = String.Format("{0} UNION SELECT 1 AS Loai,chungtu.ngayct,ChungTu.SoHieu AS SHCT,'~' AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,-SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,TK_ID FROM ({2}) INNER JOIN ({3}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT WHERE HethongTK.SoHieu LIKE '521%' AND {4}{5}", sql, (IIf(pNN > 0, String.Empty, String.Empty)), ChungTu2TKNC(-1), MienTru, wsql, sqlw1)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.ngayct,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM {2} WHERE (HethongTK.SoHieu LIKE '11%' OR HethongTK.SoHieu LIKE '15%' OR HethongTK.SoHieu LIKE '{3}%' OR HethongTK.SoHieu LIKE '3331%' OR HethongTK.SoHieu LIKE '136%' OR HethongTK.SoHieu LIKE '138%' OR HethongTK.SoHieu LIKE '336%' OR HethongTK.SoHieu LIKE '338%' OR HethongTK.SoHieu LIKE '331%' OR HethongTK.SoHieu LIKE '413%' OR HethongTK.Loai=5 OR HethongTK.Loai=6) AND MaKHC={4} AND {5}{6}", sql, (IIf(pNN > 0, String.Empty, String.Empty)), ChungTu2TKNC(0), pVATV, ConvertToStrSafe(mkh), wsql, sqlw2)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.ngayct,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM ({2}) INNER JOIN ({3}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT WHERE (HethongTK.SoHieu LIKE '11%' OR HethongTK.SoHieu LIKE '15%' OR HethongTK.SoHieu LIKE '136%' OR HethongTK.SoHieu LIKE '138%' OR HethongTK.SoHieu LIKE '336%' OR HethongTK.SoHieu LIKE '338%') AND MaTKCo=0", sql, (IIf(pNN > 0, String.Empty, String.Empty)), ChungTu2TKNC(-1), MienTru)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.ngayct,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM {2} WHERE MaKHC=MaKH AND MaKH={3} AND HethongTK.TK_ID={4} AND {5}{6}", sql, (IIf(pNN > 0, String.Empty, String.Empty)), ChungTu2TKNC(0), mkh, ConvertToStrSafe(TKCNPT_ID), wsql, sqlw2)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.ngayct,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM {2} WHERE MaKHC<>MaKH AND MaKHC={3} AND TK_ID={4} AND MaTKTCNo=MaTKTCCo AND {5}{6}", sql, (IIf(pNN > 0, String.Empty, String.Empty)), ChungTu2TKNC(-1), mkh, ConvertToStrSafe(TKCNKH_ID), wsql, sqlw1)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.ngayct,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM ({2}) INNER JOIN ({3}) AS QDuPhong ON ChungTu.MaCT=QDuPhong.MaCT WHERE (HethongTK.SoHieu LIKE '11%' AND TK.SoHieu LIKE '515%'){4}", sql, (IIf(pNN > 0, String.Empty, String.Empty)), ChungTu2TKNC(0), QDuPhong, sqlw1)
            sql = String.Format("{0} UNION SELECT 2 AS Loai,chungtu.ngayct,ChungTu.SoHieu AS SHCT,HethongTK.SoHieu AS SH,'...' AS TenVT,'...' AS Dvt,0 AS Luong,-SoPS AS Tien,chungtu.DienGiai{1},ChungTu.MaSo,0 AS TK_ID FROM ({2}) INNER JOIN ({3}) AS MienTru ON ChungTu.MaCT=MienTru.MaCT WHERE TK.SoHieu LIKE '11%' AND MaKH={4} AND HethongTK.TK_ID={5}{6}", sql, (IIf(pNN > 0, String.Empty, String.Empty)), ChungTu2TKNC(0), MienTru, mkh, ConvertToStrSafe(TKCNKH_ID), sqlw1)

            rs = ExecSQLReturnDT(String.Format("SELECT t2.*,t1.tk_id,t1.tien FROM ({0}) AS t1 inner join chungtu t2 on t1.maso=t2.maso WHERE t1.loai=1", sql))
            ExecSQLNonQuery(("DELETE  FROM BKNhomPS"))
            Dim rsIndex As Integer = 0
            While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                ExecSQLNonQuery((String.Format("INSERT into BKNhomPS(shtk,mact,sohieu,DienGiai,sopsno,sops2no,ngay,sopsco) values('{1}',{2},'{3}',N'{4}',{5},{6},'{7}',{8})", Lng_MaxValue("maso", "BKNhomPS") + 1, rsItem("MaSo"), rsItem("MaCT"), rsItem("SoHieu"), rsItem("DienGiai"), rsItem("tien"), rsItem("SoXuat"), Format(CDate(rsItem("NgayCT")), Mask_DB), rsItem("tk_id"))))
                rs1 = ExecSQLReturnDT(String.Format("SELECT sohieu,mact,ngayct FROM chungtu WHERE ct_id={0}", rsItem("MaCT")))
                Dim rs1Index As Integer = 0
                While rs1Index < rs1.Rows.Count
                    Dim rs1Item As DataRow = rs1.Rows(rs1Index)
                    rs1Index += 1 ' C15 Rs LOOP CONTROL
                    ExecSQLNonQuery((String.Format("UPDATE BKNhomPS set shdu='{0}',ngaygs='{1}' WHERE shtk='{2}'", rs1Item("SoHieu"), Format(CDate(rs1Item("NgayCT")), Mask_DB), rsItem("MaSo"))))
                End While
            End While
            'X = ConvertToDblSafe(GetSelectValue("SELECT Sum(sopsno)-sum(sops2No) AS F1,Sum(ABS(sopsno-sops2No)) AS F2 FROM BKNhomPS", Y))
            'sql = ""
            'For i = tdau To tcuoi
            '    sql = String.Format("{0}+co_{1}", sql, ConvertToStrSafe(i))
            'Next
            'If sql <> "" Then sql = Strings.Right(sql, sql.Length - 1)
            'TToanTK = ConvertToDblSafe(GetSelectValue(String.Format("SELECT {0} as f1 FROM sodukhachhang WHERE makhachhang={1}", sql, ConvertToStrSafe(mkh))))
            'TToanTK = ConvertToDblSafe(TToanTK - ConvertToDblSafe(GetSelectValue("SELECT sum(sops2no) as f1 FROM BKNhomPS")))

            'rptFrom.InitForm("DCCN1.RPT", "SELECT * FROM BKNhomPS", "BKNhomPS")

            'rptFrom.SetFormulas("TToanTK", TToanTK)
            'rptFrom.SetFormulas("ThanhTienX", String.Format("'{0} đồng'", ToVNText(dn - DC + X - TToanTK)))

            'rptFrom.SetFormulas("TenTK", String.Format("'{0}{1} - {2}'", Ngonngu("Bên nhận hàng: ", "Consignee: "), kh.SoHieu, kh.Ten))
            dauky = dn - DC
        End If
        rs = ExecSQLReturnDT("select max(sohieu), max(DienGiai), sum(sopsno), sum(sops2no) from BKNhomPS group by sohieu, sohieu")
        i = 0

        ClearGrid(list, list.Rows)
        tien = 0 : thanhtoan = 0
        For Each rsitem As DataRow In rs.Rows
            With list
                If list.Name = "Grd" Then
                    .AddItem(String.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}", Chr(9), rsitem(0).ToString, rsitem(1).ToString, Format(rsitem(2).ToString, Mask_0), Format(rsitem(3).ToString, Mask_0), "-", "0"))
                Else
                    .AddItem(String.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}", Chr(9), rsitem(0).ToString, rsitem(1).ToString, Format(rsitem(2).ToString, Mask_0), Format(rsitem(3).ToString, Mask_0), "-"))
                End If
                tien += ConvertToDblSafe(rsitem(2).ToString)
                thanhtoan += ConvertToDblSafe(rsitem(3).ToString)
            End With
        Next
    End Sub

    Private Sub _txtshkh_0_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtshkh.Enter
        txtshkh.SelectAll()
    End Sub

    Private Sub txtshkh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtshkh.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(e.KeyChar)
        If KeyAscii = 13 Then cmdkh_Click(cmdkh, New EventArgs())
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtshkh_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtshkh.Leave
        Dim mvt As Integer
        txtshkh.Text = txtshkh.Text.ToUpper()
        lbkh.Text = TenKH(txtshkh.Text, mvt)
        txtshkh.Tag = ConvertToStrSafe(mvt)
    End Sub

    Private Sub cmdkh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdkh.Click
        Me.Cursor = Cursors.WaitCursor
        txtshkh.Text = FrmKhachHang.ChonKhachHang(txtshkh.Text)
        Me.Cursor = Cursors.Default
        txtshkh.Focus()
    End Sub

    Dim co As Integer

    Private Sub FrmCantrucongno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Escape Then Close()
    End Sub
    Private Sub FrmCantrucongno_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Khoitao()
        AddMonthToCbo(CboThang(0))
        AddMonthToCbo(CboThang(1))
        SetFont(Me)
    End Sub

    Private Sub Khoitao()
        If co = 0 Then
            co = 1
            ColumnSetUp(Grdview(0), 0, 1050, ContentAlignment.MiddleLeft)
            ColumnSetUp(Grdview(0), 1, 2500, ContentAlignment.MiddleLeft)
            ColumnSetUp(Grdview(0), 2, 1000, ContentAlignment.MiddleRight)
            ColumnSetUp(Grdview(0), 3, 1000, ContentAlignment.MiddleRight)
            ColumnSetUp(Grdview(0), 4, 300, ContentAlignment.MiddleCenter)
            ColumnSetUp(Grdview(0), 5, 1800, ContentAlignment.MiddleRight)

            ColumnSetUp(Grdview(1), 0, 1050, ContentAlignment.MiddleLeft)
            ColumnSetUp(Grdview(1), 1, 2500, ContentAlignment.MiddleLeft)
            ColumnSetUp(Grdview(1), 2, 1000, ContentAlignment.MiddleRight)
            ColumnSetUp(Grdview(1), 3, 1000, ContentAlignment.MiddleRight)
            ColumnSetUp(Grdview(1), 4, 300, ContentAlignment.MiddleCenter)
        End If
    End Sub

    Private Sub Grd_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grd.DoubleClick, Grd1.DoubleClick
        Dim Index As Integer = Array.IndexOf(Grdview, sender)
        If Grdview(Index).Items(Grdview(Index).Row).SubItems(0).Text <> " " Then
            If MessageBox.Show(Ngonngu("Sửa chứng từ?", "Edit voucher ?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                FrmChungtu.Suatonkho(Grdview(Index).Items(Grdview(Index).Row).SubItems(0).Text)
                Command_Click(Command(3), New EventArgs())
            End If
        End If
    End Sub

    Private Sub Grd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grd.Click, Grd1.Click
        Dim Index As Integer = Array.IndexOf(Grdview, sender)
        Dim even As System.Windows.Forms.MouseEventArgs = e
        If even.Button = Windows.Forms.MouseButtons.Left Then
            With Grdview(Index)
                .Col = 4
                If .Items(.Row).SubItems(.Col).Text.Length = 0 Then Exit Sub
                If .Items(.Row).SubItems(.Col).Text = "X" Then
                    .Items(.Row).SubItems(.Col).Text = "-"
                    If Index = 0 Then .Items(.Row).SubItems(5).Text = 0
                    chk(Index).CheckState = CheckState.Unchecked
                    chk(Index).Text = "Chọn tất cả"
                Else
                    .Items(.Row).SubItems(.Col).Text = "X"
                    If Index = 0 Then .Items(.Row).SubItems(5).Text = Format(ConvertToDblSafe(.Items(.Row).SubItems(2).Text) - ConvertToDblSafe(.Items(.Row).SubItems(3).Text), Mask_0)
                End If
            End With
        ElseIf Index = 0 Then
            Grdview(Index).Items(Grdview(Index).Row).SubItems(5).Text = Format(InputBox("Nhập giá trị cấn trừ cần thay đổi:", My.Application.Info.ProductName, ConvertToDblSafe(Grdview(Index).Items(Grdview(Index).Row).SubItems(5).Text)), Mask_0)
        End If
        Dim tong As Double = 0
        Dim i As Integer
        If (Index = 0) Then
            With Grdview(0)
                ct131 = ""
                i = 0
                .Row = 0
                While i < .Rows
                    If .Items(.Row).SubItems(4).Text = "X" Then
                        tong += ConvertToDblSafe(.Items(.Row).SubItems(5).Text)
                        If ct131 = "" Then
                            ct131 = .Items(.Row).SubItems(0).Text
                        Else
                            ct131 = ct131 & ", " & .Items(.Row).SubItems(0).Text
                        End If
                    End If
                    i += 1
                End While
            End With
            Cantru.Text = Format(tong, Mask_0)
        End If
        With Grdview(1)
            ct331 = ""
            i = 0
            .Row = 0
            While i < .Rows
                If .Items(.Row).SubItems(4).Text = "X" Then
                    If ct331 = "" Then
                        ct331 = .Items(.Row).SubItems(0).Text
                    Else
                        ct331 = ct331 & ", " & .Items(.Row).SubItems(0).Text
                    End If
                End If
                i += 1
            End While
        End With
    End Sub
End Class
