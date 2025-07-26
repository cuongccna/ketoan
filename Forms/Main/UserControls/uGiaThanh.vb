Imports UNET.Utility
Imports UNET.DataAdapter

Public Class uGiaThanh

    ''' <summary>
    ''' Tinhgiaxuatkho
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub TinhgiaxuatkhoPublic()
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
    End Sub

    ''' <summary>
    ''' LayCdt
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
                        NoRightPublic(1)
                    End If
                Case 15
                Case 16
                    TinhgiaxuatkhoPublic()
            End Select
            Me.Cursor = Cursors.Default
            HienThongBao("...", 1)
            MemoryHelper.ReleaseMemory()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub myListview_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ListView_giathanh.MouseDown
        Me.Cursor = Cursors.WaitCursor
        Try
            If (e.Button = MouseButtons.Left) AndAlso (e.Clicks = 1) Then
                Dim htInfo As ListViewHitTestInfo = ListView_giathanh.HitTest(e.X, e.Y)
                If IsNothing(htInfo) Then
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
                If IsNothing(htInfo.Item) Then
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
                If IsNothing(htInfo.Item.Tag) Then
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
                ''' bat dau thuc hien
                Select Case htInfo.Item.Tag.ToString()
                    Case "tag_DoGiangDauKy"
                        functionGiaThanh(0)
                    Case "tag_Nhapkhothanhpham"
                        functionGiaThanh(14)
                    Case "tag_TinhLaiGiaTriXuatKho"
                        functionGiaThanh(16)
                    Case "tag_SoGiaThanh"
                        functionGiaThanh(1)
                    Case "tag_PhanLoaiLoSanXuat"
                        functionGiaThanh(7)
                    Case "tag_DSLoSanXuat"
                        functionGiaThanh(8)
                    Case "tag_DinhMucNVL"
                        functionGiaThanh(2)
                    Case "tag_PhanBoCPCTSP"
                        functionGiaThanh(3)
                End Select
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
