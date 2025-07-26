Imports System
Imports System.Data
Imports System.Text
Imports UNET.Utility
Imports System.Globalization
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Module modVattu
    ''' <summary>
    ''' Thủ tục tính lại tồn kho của một loại vật tư sau khi nhập xuất
    ''' </summary>
    ''' <param name="mkho"></param>
    ''' <param name="mtk"></param>
    ''' <param name="mvt"></param>
    ''' <param name="thang"></param>
    ''' <param name="loai"></param>
    ''' <param name="soluong"></param>
    ''' <param name="ThanhTien"></param>
    ''' <param name="ThanhTien2"></param>
    ''' <param name="kt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TinhTonKho(ByRef mkho As Integer, _
           ByRef mtk As Integer, _
           ByRef mvt As Integer, _
           ByRef thang As Integer, _
           ByRef loai As Integer, _
           ByRef soluong As Double, _
           ByRef ThanhTien As Double, _
           ByRef ThanhTien2 As Double, _
           Optional ByRef kt As Integer = 0) As Integer
        Dim result As Integer = 0
        Try
            Dim sql As String = String.Empty
            Dim j As Integer
            Dim rs As DataTable
            Dim stl As String = doidau(soluong)
            Dim th As String = ConvertToStrSafe(CThangDB2(thang))
            If kt <> 0 Then
                rs = ExecSQLReturnDT(String.Format("SELECT luong_nhap_{0},tien_nhap_{0},luong_xuat_{0},tien_xuat_{0} FROM tonkho WHERE MaSoKho={1} AND MaTaiKhoan={2} AND MaVatTu={3}", _
                                         th, _
                                         ConvertToStrSafe(mkho), _
                                         ConvertToStrSafe(mtk), _
                                         ConvertToStrSafe(mvt)))
                If rs.Rows.Count > 0 Then
                    Dim rsItem As DataRow = rs.Rows(0)
                    stl = doidau(soluong - ConvertToDblSafe(rsItem(IIf(loai < 0, 0, 2))))
                    ThanhTien -= ConvertToDblSafe(rsItem(IIf(loai < 0, 1, 3)))
                End If
            End If
            If loai < 0 Then
                sql = String.Format("UPDATE TonKho SET Luong_Nhap_{0} = Luong_Nhap_{0} + {1}, Tien_Nhap_{0} = Tien_Nhap_{0} + {2}{3}", _
                          th, _
                          stl, _
                          CStr(ThanhTien), _
                          (IIf(pGiaUSD > 0, String.Format(", USDTien_Nhap_{0} = USDTien_Nhap_{0} + {1}", th, CStr(ThanhTien2)), String.Empty)))
            Else
                sql = String.Format("UPDATE TonKho SET Luong_Xuat_{0} = Luong_Xuat_{0} + {1}, Tien_Xuat_{0} = Tien_Xuat_{0} + {2}{3}", _
                          th, _
                          stl, _
                          CStr(ThanhTien), _
                          (IIf(pGiaUSD > 0, String.Format(", USDTien_Xuat_{0} = USDTien_Xuat_{0} + {1}", th, CStr(ThanhTien2)), String.Empty)))
            End If
            If loai < 0 Then
                stl = String.Format(" + {0}", stl)
            Else
                stl = String.Format(" - {0}", stl)
            End If
            Dim stt As String = CStr(IIf(loai < 0, ThanhTien, -ThanhTien))
            Dim stt2 As String = CStr(IIf(loai < 0, ThanhTien2, -ThanhTien2))
            For i As Integer = CThangDB2(thang) To 12
                sql = String.Format("{0}, Luong_{1} = Luong_{1}{2}, Tien_{1} = Tien_{1} + {3}", _
                          sql, _
                          i, _
                          stl, _
                          stt)
                If pGiaUSD > 0 Then sql = String.Format("{0}, USDTien_{1} = USDTien_{1} + {2}", sql, i, stt2)
            Next
            result = ExecSQLNonQueryUpdateInsertDeleteQuery(String.Format("{0} WHERE MaSoKho={1} AND MaTaiKhoan={2} AND MaVatTu={3}", _
                                         sql, _
                                         ConvertToStrSafe(mkho), _
                                         ConvertToStrSafe(mtk), _
                                         ConvertToStrSafe(mvt)))
            If result = 0 Then
                j = CThangDB2(thang)
                sql = String.Format("INSERT INTO TonKho (MaSo,MaSoKho,MaTaiKhoan,MaVattu,Luong_{0}_{1},Tien_{0}_{1}{2}", _
                          (IIf(loai < 0, "Nhap", "Xuat")), _
                          ConvertToStrSafe(j), _
                          (IIf(pGiaUSD > 0, String.Format(",USDTien_{0}_{1}", (IIf(loai < 0, "Nhap", "Xuat")), ConvertToStrSafe(j)), String.Empty)))
                For i As Integer = j To 12
                    sql = String.Format("{0}, Luong_{1}, Tien_{1}{2}", _
                              sql, _
                              ConvertToStrSafe(i), _
                              (IIf(pGiaUSD > 0, String.Format(", USDTien_{0}", i), String.Empty)))
                Next
                sql = String.Format("{0}) VALUES ({1},{2},{3},{4},abs({5}),abs({6}){7}", _
                          sql, _
                          ConvertToStrSafe(Lng_MaxValue("MaSo", "TonKho") + 1), _
                          ConvertToStrSafe(mkho), _
                          ConvertToStrSafe(mtk), _
                          ConvertToStrSafe(mvt), _
                          stl, _
                          stt, _
                          (IIf(pGiaUSD > 0, String.Format(",abs({0})", stt2), String.Empty)))
                For i As Integer = j To 12
                    sql = String.Format("{0}, {1}, {2}{3}", _
                              sql, _
                              stl, _
                              stt, _
                              (IIf(pGiaUSD > 0, String.Format(",{0}", stt2), String.Empty)))
                Next
                sql = String.Format("{0})", sql)
                result = ExecSQLNonQuery(sql)
                ExecSQLNonQuery("update tonkho set Luong_0=0 where Luong_0 is null")
                ExecSQLNonQuery("update tonkho set Tien_0=0 where Tien_0 is null")
                ExecSQLNonQuery("update tonkho set Soxuat=0 where Soxuat is null")
                For i = 1 To 12
                    ExecSQLNonQuery("update tonkho set Luong_" + CStr(i) + "=0 where Luong_" + CStr(i) + " is null")
                    ExecSQLNonQuery("update tonkho set Tien_" + CStr(i) + "=0 where Tien_" + CStr(i) + " is null")
                    ExecSQLNonQuery("update tonkho set Luong_Nhap_" + CStr(i) + "=0 where Luong_Nhap_" + CStr(i) + " is null")
                    ExecSQLNonQuery("update tonkho set Tien_Nhap_" + CStr(i) + "=0 where Tien_Nhap_" + CStr(i) + " is null")
                    ExecSQLNonQuery("update tonkho set Luong_Xuat_" + CStr(i) + "=0 where Luong_Xuat_" + CStr(i) + " is null")
                    ExecSQLNonQuery("update tonkho set Tien_Xuat_" + CStr(i) + "=0 where Tien_Xuat_" + CStr(i) + " is null")
                Next
            End If
        Catch ex As Exception

            Throw New Exception(ex.Message)
            Return result
        Finally

        End Try
        Return result
    End Function

    'Tra ve so luong ton va thanh tien cua mot vat tu trong kho

    Public Function SoTonKho(ByRef thang As Integer, _
        ByRef mkho As Integer, _
        ByRef mtk As Integer, _
        ByRef mvt As Integer, _
        ByRef ThanhTien As Double, _
        ByRef tien2 As Double) As Double
        Dim result As Double = 0
        Try
            Dim sql As String = String.Format("SELECT SUM(Tien_{0}) AS F1,SUM(Luong_{1}) AS F2{2} FROM TonKho WHERE 1=1", _
                                CThangDB2(thang), _
                                ConvertToStrSafe(CThangDB2(thang)), _
                                (IIf(pGiaUSD > 0, String.Format(",SUM(USDTien_{0}) AS F3", CThangDB2(thang)), String.Empty)))
            'Dim sql AS String = String.Format("SELECT SUM(Tien_{0}) AS F1,SUM(Luong_{1}) AS F2{2} FROM TonKho WHERE (True)", _
            '                        CThangDB2(thang), _
            '                        ConvertToStrSafe(CThangDB2(thang)), _
            '                        (iif(pGiaUSD > 0, String.Format(",SUM(USDTien_{0}) AS F3", CThangDB2(thang)), String.Empty)))
            If mkho > 0 Then sql = String.Format("{0} AND MaSoKho={1}", sql, ConvertToStrSafe(mkho))
            If mtk > 0 Then sql = String.Format("{0} AND MaTaiKhoan={1}", sql, ConvertToStrSafe(mtk))
            If mvt > 0 Then sql = String.Format("{0} AND MaVattu={1}", sql, ConvertToStrSafe(mvt))
            ThanhTien = ConvertToDblSafe(GetSelectValue(sql, result, tien2))
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return result
        End Try
        
        Return result
    End Function
    Public Function SoTonKho_1(ByRef thang As Integer, _
ByRef mkho As Integer, _
ByRef mtk As Integer, _
ByRef mvt As Integer, _
ByRef ThanhTien As Double, _
ByRef tien2 As Double) As Double
        Dim result As Double = 0

        Try
            Dim sql As String = String.Format("SELECT SUM(Tien_{0}) AS F1,SUM(Luong_{1}) AS F2{2} FROM TonKho WHERE 1=1", _
                                CThangDB2(thang), _
                                ConvertToStrSafe(CThangDB2(thang)), _
                                (IIf(pGiaUSD > 0, String.Format(",SUM(USDTien_{0}) AS F3", CThangDB2(thang)), String.Empty)))
            'Dim sql AS String = String.Format("SELECT SUM(Tien_{0}) AS F1,SUM(Luong_{1}) AS F2{2} FROM TonKho WHERE (True)", _
            '                        CThangDB2(thang), _
            '                        ConvertToStrSafe(CThangDB2(thang)), _
            '                        (iif(pGiaUSD > 0, String.Format(",SUM(USDTien_{0}) AS F3", CThangDB2(thang)), String.Empty)))
            If mkho > 0 Then sql = String.Format("{0} AND MaSoKho={1}", sql, ConvertToStrSafe(mkho))
            If mtk > 0 Then sql = String.Format("{0} AND MaTaiKhoan={1}", sql, ConvertToStrSafe(mtk))
            If mvt > 0 Then sql = String.Format("{0} AND MaVattu={1}", sql, ConvertToStrSafe(mvt))
            result = ConvertToDblSafe(GetSelectValue(sql))
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return result
        End Try
        
        Return result
    End Function
    Public Function SoTonKho_2(ByRef thang As Integer, _
ByRef mkho As Integer, _
ByRef mtk As Integer, _
ByRef mvt As Integer, _
ByRef ThanhTien As Double, _
ByRef tien2 As Double) As Double
        Dim result As Double = 0
        Try
            Dim sql As String = String.Format("SELECT SUM(Tien_{0}) AS F2,SUM(Luong_{1}) AS F1{2} FROM TonKho WHERE 1=1", _
                                CThangDB2(thang), _
                                ConvertToStrSafe(CThangDB2(thang)), _
                                (IIf(pGiaUSD > 0, String.Format(",SUM(USDTien_{0}) AS F3", CThangDB2(thang)), String.Empty)))
            'Dim sql AS String = String.Format("SELECT SUM(Tien_{0}) AS F1,SUM(Luong_{1}) AS F2{2} FROM TonKho WHERE (True)", _
            '                        CThangDB2(thang), _
            '                        ConvertToStrSafe(CThangDB2(thang)), _
            '                        (iif(pGiaUSD > 0, String.Format(",SUM(USDTien_{0}) AS F3", CThangDB2(thang)), String.Empty)))
            If mkho > 0 Then sql = String.Format("{0} AND MaSoKho={1}", sql, ConvertToStrSafe(mkho))
            If mtk > 0 Then sql = String.Format("{0} AND MaTaiKhoan={1}", sql, ConvertToStrSafe(mtk))
            If mvt > 0 Then sql = String.Format("{0} AND MaVattu={1}", sql, ConvertToStrSafe(mvt))
            result = ConvertToDblSafe(GetSelectValue(sql))
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return result
        End Try
        
        Return result
    End Function

    'Public Function SoTonKhoN(ByRef Ngay As Date, ByRef mkho As Integer, ByRef mtk As Integer, ByRef mvt As Integer, ByRef ThanhTien As Double, ByRef tien2 As Double) As Double
    '    Dim result As Double = 0
    '    Dim luong, X As Double
    '    result = SoTonKho(0, mkho, mtk, mvt, ThanhTien, tien2)
    '    Dim sql As String = String.Format("SELECT Sum(t1.SoPS) AS F1,Sum(t1.SoPS2No) AS F2 FROM ChungTu t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE t2.sohieu LIKE '15%' AND t1.MaVattu={0} AND ((t1.MaLoai=13 OR t1.MaLoai=1){1} AND t1.NgayGS<=N'{2}'", _
    '                            mvt, _
    '                            (IIf(mkho > 0, " OR t1.MaLoai=4)", ")")), _
    '                            Format(cdate(Ngay), Mask_DB))
    '    If mkho > 0 Then sql = String.Format("{0} AND ((t1.MaKho={1} AND (t1.MaLoai=13 OR t1.MaLoai=1)) OR (t1.MaNguon={1} AND t1.MaLoai=4))", _
    '                               sql, _
    '                               ConvertToStrSafe(mkho))
    '    If mtk > 0 Then sql = String.Format("{0} AND t1.MaTKNo={1}", sql, ConvertToStrSafe(mtk))
    '    ThanhTien += ConvertToDblSafe(GetSelectValue(sql, luong, X))
    '    result += luong
    '    tien2 += X
    '    sql = String.Format("SELECT Sum(t1.SoPS) AS F1,Sum(t1.SoPS2Co) AS F2 FROM ChungTu t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE t2.sohieu LIKE '15%' AND t1.MaVattu={0} AND (t1.MaLoai=2{1} AND t1.NgayGS<=N'{2}'", _
    '              mvt, _
    '              (IIf(mkho > 0, " OR t1.MaLoai=4)", ")")), _
    '              Format(cdate(Ngay), Mask_DB))
    '    If mkho > 0 Then sql = String.Format("{0} AND (t1.MaKho={1})", sql, ConvertToStrSafe(mkho))
    '    If mtk > 0 Then sql = String.Format("{0} AND t1.MaTKCo={1}", sql, ConvertToStrSafe(mtk))
    '    ThanhTien = ConvertToDblSafe(ThanhTien - ConvertToDblSafe(GetSelectValue(sql, luong, X)))
    '    tien2 -= X
    '    Return result - luong
    'End Function
    Public Function SoTonKhoN(ByRef Ngay As Date, ByRef mkho As Integer, ByRef mtk As Integer, ByRef mvt As Integer, ByRef ThanhTien As Double, ByRef tien2 As Double) As Double
        Dim result As Double = 0
        Dim luong As Double = 0
        Dim X As Double = 0
        Try
            Dim sql As String = String.Format("SELECT Sum(t1.SoPS) AS F1,Sum(t1.SoPS2No) AS F2 FROM ChungTu t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE t2.sohieu LIKE '15%' AND t1.MaVattu={0} AND ((t1.MaLoai=13 OR t1.MaLoai=1){1} AND t1.NgayGS<=N'{2}'", _
                                mvt, _
                                (IIf(mkho > 0, " OR t1.MaLoai=4)", ")")), _
                                Format(CDate(Ngay), Mask_DB))
            If mkho > 0 Then sql = String.Format("{0} AND ((t1.MaKho={1} AND (t1.MaLoai=13 OR t1.MaLoai=1)) OR (t1.MaNguon={1} AND t1.MaLoai=4))", _
                                       sql, _
                                       ConvertToStrSafe(mkho))
            If mtk > 0 Then sql = String.Format("{0} AND t1.MaTKNo={1}", sql, ConvertToStrSafe(mtk))
            'ThanhTien += ConvertToDblSafe(GetSelectValue(sql, luong, X))
            ThanhTien += ConvertToDblSafe(GetSelectValue(sql, IIf(IsDBNull(luong), 0, luong), IIf(IsDBNull(X), 0, X)))
            result += luong
            tien2 += X
            sql = String.Format("SELECT Sum(t1.SoPS) AS F1,Sum(t1.SoPS2Co) AS F2 FROM ChungTu t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE t2.sohieu LIKE '15%' AND t1.MaVattu={0} AND (t1.MaLoai=2{1} AND t1.NgayGS<=N'{2}'", _
                      mvt, _
                      (IIf(mkho > 0, " OR t1.MaLoai=4)", ")")), _
                      Format(CDate(Ngay), Mask_DB))
            If mkho > 0 Then sql = String.Format("{0} AND (t1.MaKho={1})", sql, ConvertToStrSafe(mkho))
            If mtk > 0 Then sql = String.Format("{0} AND t1.MaTKCo={1}", sql, ConvertToStrSafe(mtk))
            ThanhTien = ConvertToDblSafe(ThanhTien - ConvertToDblSafe(GetSelectValue(sql, IIf(IsDBNull(luong), 0, luong), IIf(IsDBNull(X), 0, X))))
            'ThanhTien = ConvertToDblSafe(ThanhTien - ConvertToDblSafe(GetSelectValue(sql, luong, X)))
            'ThanhTien += ConvertToDblSafe(GetSelectValue(sql, IIf(IsDBNull(luong), 0, luong), IIf(IsDBNull(X), 0, X)))
            tien2 -= X
            result = SoTonKho(0, mkho, mtk, mvt, ThanhTien, tien2)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return result - luong
        End Try
        Return result - luong
    End Function
    ''' <summary>
    ''' Hàm trả về số hiệu mặc định của vật tư mới
    ''' </summary>
    ''' <param name="mpl"></param>
    ''' <param name="loai"></param>
    ''' <param name="PhanLoai"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoHieuVTMoi(ByRef mpl As Integer, Optional ByRef loai As Integer = 0, Optional ByRef PhanLoai As Integer = 0) As String
        Dim result As String = String.Empty
        Dim tail = String.Empty, sql As String = String.Empty
        Dim dai As Integer = 0, i As Integer = 0
        Try
            Select Case loai
                Case 0
                    sql = String.Format("SELECT Top 1 SoHieu FROM Vattu WHERE MaPhanLoai = {0} ORDER BY SoHieu DESC", mpl)
                Case 1
                    sql = String.Format("SELECT Top 1 SoHieu FROM TP154 WHERE MaPhanLoai = {0} ORDER BY SoHieu DESC", mpl)
                Case 2
                    sql = String.Format("SELECT Top 1 SoHieu FROM KhachHang WHERE MaPhanLoai = {0} ORDER BY SoHieu DESC", mpl)
                Case 3
                    sql = String.Format("SELECT Top 1 SoHieu FROM NhanVien WHERE MaPhanLoai = {0} ORDER BY SoHieu DESC", mpl)
                Case 4
                    sql = "SELECT Top 1 SoHieu FROM DoituongCT ORDER BY SoHieu DESC"
                Case 5
                    sql = "SELECT Top 1 SoHieu FROM chucvu ORDER BY SoHieu DESC"
                Case 6
                    sql = String.Format("SELECT Top 1 SoHieu FROM QuanlyNhanVien WHERE MaPhanLoai = {0} ORDER BY SoHieu DESC", mpl)
            End Select
            Dim rs_vt As DataTable = ExecSQLReturnDT(sql)


            If rs_vt.Rows.Count > 0 Then
                i = 1
                Dim rs_vtItem As DataRow = rs_vt.Rows(0)
                Dim sohieu As String = ConvertToStrSafe(rs_vtItem("SoHieu"))
                Do While IsNumeric(Strings.Right(sohieu, i)) And i <= sohieu.Length
                    dai = i
                    i += 1
                Loop
                If dai > 0 Then
                    Try
                        tail = ConvertToStrSafe(ConvertToDblSafe(Strings.Right(sohieu, dai)) + 1)
                    Catch
                    End Try
                    Do While tail.Length < dai
                        tail = String.Format("0{0}", tail)
                    Loop
                    'If sohieu.Length > dai Then
                    '    result = Strings.Left(sohieu, sohieu.Length - dai)
                    'End If
                    If tail.Length > dai Then
                        result = Strings.Left(sohieu, sohieu.Length - dai)
                    End If
                    result = result + tail
                    'van.nguyen 14-Nov-2011
                    'result = String.Format("{0}{1}{2}", _
                    '             (IIf(PhanLoai <> 0 And ConvertToDblSafe(Strings.Left(tail, 1)) <> PhanLoai, ConvertToStrSafe(PhanLoai), String.Empty)), _
                    '             result, _
                    '             tail)


                End If
            Else
                If loai = 6 Then
                    tail = GetSelectValue("select sohieu as f1 from phanloaiquanlynhanvien where maso=" + CStr(mpl))
                    If tail IsNot Nothing Then
                        If Len(tail) > 0 Then
                            result = CStr(Right(tail, 1)) + "001"
                        End If
                    End If
                End If
                If result Is Nothing Then result = "1001"
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return result
        End Try
        
        Return result
    End Function
    ''' <summary>
    ''' Thủ tục in thẻ kho
    ''' </summary>
    ''' <param name="mkho"></param>
    ''' <param name="mvt"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="thongbao"></param>
    ''' <param name="MN"></param>
    ''' <param name="tkdu"></param>
    ''' <param name="loaitk"></param>
    ''' <param name="nn"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InTheKho2(ByRef mkho As Integer, _
        ByRef mvt As Integer, _
        ByRef tdau As Integer, _
        ByRef tcuoi As Integer, _
        ByRef thongbao As Boolean, _
        ByRef MN As Integer, _
        Optional ByRef tkdu As String = "", _
        Optional ByRef loaitk As Integer = 0, _
        Optional ByRef nn As Integer = 0, _
        Optional ByRef rptin As Integer = 0) As Boolean

        Dim dkt As Double = 0, dkt2 As Double = 0
        Dim st As String = String.Empty
        Dim dv As String = String.Empty
        Dim sqll As New StringBuilder
        Dim DVT2 As Integer = 0
        Dim ps As Double = 0
        Try
            For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
                st = ConvertToStrSafe(i)
                sqll.AppendFormat(" + Luong_Nhap_{0} + Luong_Xuat_{0} + Tien_Nhap_{0} + Tien_Xuat_{0}", st)
            Next
            st = ConvertToStrSafe(CThangDB2(ThangTruoc(tdau)))
            Dim dkl As Double = ConvertToDblSafe(GetSelectValue(String.Format("SELECT isnull(SUM(Luong_{0}),0) AS F1, isnull(SUM(Tien_{0}),0) AS F2,{1} AS F3, isnull(SUM({2}),0) AS F4 FROM TonKho WHERE MaVattu = {3}{4}", _
                                                                    st, _
                                                                    (IIf(pGiaUSD > 0, String.Format("isnull(Sum(USDTien_{0}),0)", st), "0")), _
                                                                    sqll, _
                                                                    ConvertToStrSafe(mvt), _
                                                                    (IIf(mkho > 0, String.Format(" AND  MaSoKho = {0}", mkho), String.Empty))), dkt, dkt2, ps))
            If dkl = 0 And dkt = 0 And dkt2 = 0 And ps = 0 Then GoTo KhongPS
            Dim rs As DataTable
            Dim Luongam, tienam As Double
            Dim str = String.Empty, kt As String = String.Empty
            Dim QTheKho As String = String.Empty

            QTheKho = String.Format("SELECT ChungTu.SoHieu as [ChungTu.SoHieu], ChungTu.NgayCT, ChungTu.DienGiai{0}, ChungTu.MaLoai, ChungTu.SoPS, ChungTu.SoPS2No, ChungTu.SoPS2Co, ChungTu.MaTKTCNo, ChungTu.MaTKTCCo, HeThongTK.SoHieu as [HeThongTK.SoHieu], HeThongTK_1.SoHieu as [HeThongTK_1.SoHieu], ChungTu.GhiChu, ChungTu.MaKho, ChungTu.MaNguon,{1} AS PSUSD1, DonVi, TyLeQD, ChungTu.NgayGS FROM (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo) ON HeThongTK_1.MaSo = ChungTu.MaTKCo) LEFT JOIN DVTVattu ON ChungTu.DVT=DVTVattu.MaSo  WHERE (SoPS2No<>0 OR SoPS2Co<>0{2}) AND (HethongTK.TK_ID={3} OR HethongTK_1.TK_ID={3}) AND ((ChungTu.MaLoai =13 OR ChungTu.MaLoai =1 OR ChungTu.MaLoai =2 OR ChungTu.MaLoai =4) AND {4} AND (chungtu.MaVattu = {5}){6}) {7}{8} ", _
                                       (IIf(pNN > 0, "E", String.Empty)), _
                                       (IIf(pGiaUSD > 0, "ChungTu.PSUSD", "0")), _
                                       (IIf(loaitk = 0, " OR SoPS<>0 ", String.Empty)), _
                                       ConvertToStrSafe(TKVT_ID), _
                                       WThang("ThangCT", tdau, tcuoi), _
                                       ConvertToStrSafe(mvt), _
                                       (IIf(mkho > 0, String.Format(" AND (((chungtu.MaLoai=13 OR chungtu.MaLoai<4) AND chungtu.MaKho = {0}) OR (chungtu.MaLoai=4 AND (chungtu.MaKho = {1} OR chungtu.MaNguon = {1})))", mkho, ConvertToStrSafe(mkho)), String.Empty)), _
                                       (IIf(MN > 0, String.Format("AND ChungTu.MaLoai<>4 AND ChungTu.MaNguon={0}", MN), String.Empty)), _
                                       (IIf(tkdu.Length > 0, String.Format("AND (HethongTK.SoHieu LIKE '{0}%' OR HethongTK_1.SoHieu LIKE '{0}%')", tkdu), String.Empty)))
            '************************************ Kiểm tra âm hàng **********************************************
            rs = ExecSQLReturnDT(String.Format("SELECT ct.ngayct,ct.sohieu,ct.sops,ct.sops2no,ct.sops2co,CASE WHEN(ct.maloai=1 OR ct.maloai=4 OR ct.maloai=9 OR ct.maloai=13) THEN '0' ELSE '1' END + ct.sohieu AS NX,ct.ngaygs,ct.maso FROM ({0}) AS tk inner join chungtu ct on tk.[chungtu.sohieu]=ct.sohieu WHERE ct.mavattu={1} group by ct.ngaygs,ct.ngayct,ct.sohieu,ct.sops,ct.sops2no,ct.sops2co,CASE WHEN(ct.maloai=1 OR ct.maloai=4 OR ct.maloai=9 OR ct.maloai=13) THEN '0' ELSE '1' END +ct.sohieu,ct.maso ORDER BY ct.ngaygs,ct.ngayct,CASE WHEN(ct.maloai=1 OR ct.maloai=4 OR ct.maloai=9 OR ct.maloai=13) THEN '0' ELSE '1' END +ct.sohieu,ct.maso", _
                                     QTheKho, _
                                     mvt))
            Luongam = dkl
            tienam = dkt
            For Each rowItem As DataRow In rs.Rows
                Dim sohieu As String = ConvertToStrSafe(rowItem.Item("SoHieu")).Trim
                If Not kt.Equals(sohieu, StringComparison.InvariantCulture) Then
                    If ConvertToStrSafe(rowItem.Item("nx")).StartsWith("0") Then
                        Luongam += ConvertToDblSafe(rowItem.Item("SoPS2No"))
                        If Luongam <> 0 Then Luongam = ConvertToDblSafe(Format(Luongam, Mask_2))
                        tienam += ConvertToDblSafe(rowItem.Item("sops"))
                        If tienam <> 0 Then tienam = ConvertToDblSafe(Format(tienam, Mask_0))
                    Else
                        Luongam -= ConvertToDblSafe(rowItem.Item("SoPS2Co"))
                        If Luongam <> 0 Then Luongam = ConvertToDblSafe(Format(Luongam, Mask_2))
                        tienam -= ConvertToDblSafe(rowItem.Item("sops"))
                        If tienam <> 0 Then tienam = ConvertToDblSafe(Format(tienam, Mask_0))
                    End If
                    If Luongam < 0 Or tienam < 0 Or (Luongam = 0 And tienam <> 0) Or (Luongam <> 0 And tienam = 0) Then
                        str = String.Format("{0}{1}, ", str, sohieu)
                        kt = sohieu
                    End If
                End If
            Next
            If str <> "" Then
                If myUMessager.mQuestion(String.Format("Âm hàng tại chứng từ có số hiệu: {0}{1}Tiếp tục ?", Strings.Left(str, str.Length - 2), Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then GoTo KhongIn
            End If
            '************************************ Hết kiểm tra ****************************************************
            Dim rptFilename As String = String.Format("THEKHO{0}{1}{2}.RPT", _
                                                    (IIf(loaitk > 0, "2", String.Empty)), _
                                                    (IIf(loaitk = 0 And pGiaUSD > 0, "X", String.Empty)), _
                                                    (IIf(DVT2 > 0, "B", String.Empty)))

            rptFrom.InitForm(rptFilename, QTheKho, "QTheKho")

            rptFrom.ReportDestination = rptin
            rptFrom.SetFormulas("TenKho", String.Format("'{0}'", (IIf(mkho > 0, String.Format(Ngonngu("Kho: {0}", "Stock: {0}"), tenkho(mkho)), ("Tổng hợp các kho")))))
            rptFrom.SetFormulas("Thang", tdau)
            rptFrom.SetFormulas("ThangCuoi", tcuoi)
            rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
            rptFrom.SetFormulas("MaKho", mkho)
            sqll = New StringBuilder(TenVT(st, mvt, dv, DVT2))
            rptFrom.SetFormulas("TenVt", String.Format("'{0} - {1}{2}{3}'", st, sqll, Ngonngu(" - Đơn vị tính: ", " - Unit: "), dv))
            rptFrom.SetFormulas("DkLuong", dkl)
            rptFrom.SetFormulas("DkTien", dkt)
            If pGiaUSD > 0 And loaitk = 0 Then rptFrom.SetFormulas("DkTien2", dkt2)
            sqll = New StringBuilder(ConvertToStrSafe(GetSelectValue(String.Format("SELECT GhiChu AS F1 FROM Vattu WHERE MaSo={0}", mvt))))
            If sqll.ToString() <> "..." Then rptFrom.SetFormulas("GhiChu", String.Format("'{0}'", sqll))

            If DVT2 > 0 Then
                rptFrom.SetFormulas("TyLeQD", ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 TyLeQD AS F1 FROM DVTVattu WHERE MaVattu={0} ORDER BY MaSo", mvt))))
            End If
            RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
            Return True
KhongPS:
            If thongbao Then myUMessager.mInformation(Ngonngu("Vật tư không có tồn kho hoặc phát sinh !", "Material not in stock or arising !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
KhongIn:
            Return False
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
        Return False
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mkho"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InTheKho3(ByRef mkho As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer) As Boolean
        Dim result As Boolean = False
        Dim st As String = String.Empty
        Dim sqll As New StringBuilder
        Try
            For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
                st = ConvertToStrSafe(i)
                sqll.Append(String.Format(" + ABS(Luong_Nhap_{0}) + ABS(Luong_Xuat_{0}) + ABS(Tien_Nhap_{0}) + ABS(Tien_Xuat_{0}) + ABS(Luong_{1}) + ABS(Tien_{1})", _
                                st, _
                                ConvertToStrSafe(CThangDB2(ThangTruoc(tdau)))))
            Next
            ExecSQLNonQuery("DELETE FROM BKNhomPS")
            st = String.Format("SELECT DISTINCT 1 AS Loai, ChungTu.SoHieu, NgayCT, ChungTu.DienGiai,TK.Sohieu AS SHDU,SoPS2No,SoPS AS SoPSNo,0 AS SoPS2Co,0 AS SoPSCo,NgayGS,Vattu.SoHieu AS SHVT,MaCT,Chungtu.MaSo  FROM ((HeThongTK INNER JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo  WHERE (SoPS2No<>0 OR SoPS2Co<>0) AND (HethongTK.TK_ID={0}) AND ((ChungTu.MaLoai =13) OR(ChungTu.MaLoai =1) OR (ChungTu.MaLoai =4 AND ChungTu.MaNguon={1})) AND {2} UNION SELECT DISTINCT 2, ChungTu.SoHieu, NgayCT, ChungTu.DienGiai,TK.Sohieu,0,0,SoPS2Co,SoPS,NgayGS,Vattu.SoHieu,MaCT,Chungtu.MaSo  FROM ((HeThongTK INNER JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKCo) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKNo=TK.MaSo  WHERE (SoPS2No<>0 OR SoPS2Co<>0) AND (HethongTK.TK_ID={0}) AND (ChungTu.MaLoai =2 OR ChungTu.MaLoai =4) AND (ChungTu.MaKho={1}) AND {2} UNION SELECT DISTINCT 0, Vattu.SoHieu, CONVERT(DATETIME,('1/1/1980')) AS NgayCT, Vattu.TenVattu, Vattu.DonVi, Luong_{3}, Tien_{4},0,0, CONVERT(DATETIME,('1/1/1980')) AS NgayGS,Vattu.SoHieu,0,0  FROM TonKho INNER JOIN Vattu ON TonKho.MaVattu=Vattu.MaSo WHERE TonKho.MaSoKho={5} AND ({6}) <>0 UNION SELECT DISTINCT 3, Vattu.SoHieu, CONVERT(DATETIME,('1/1/1980')) AS NgayCT, Vattu.TenVattu, Vattu.DonVi, Luong_{7}, Tien_{8},0,0,CONVERT(DATETIME,('1/1/2030')) AS NgayGS,Vattu.SoHieu,0,0  FROM TonKho INNER JOIN Vattu ON TonKho.MaVattu=Vattu.MaSo WHERE TonKho.MaSoKho={5} AND ({6}) <>0", _
                        TKVT_ID, _
                        ConvertToStrSafe(mkho), _
                        WThang("ThangCT", tdau, tcuoi), _
                        CThangDB2(ThangTruoc(tdau)), _
                        ConvertToStrSafe(CThangDB2(ThangTruoc(tdau))), _
                        mkho, _
                        sqll, _
                        CThangDB2(tcuoi), _
                        ConvertToStrSafe(CThangDB2(tcuoi)))
            'SetSQL("Mientru", st)
            st = String.Format("INSERT INTO BKNhomPS (MaCT,SoHieu,Ngay,DienGiai,ShDu,SoPS2No,SoPSNo,SoPS2Co,SoPSCo,NgayGS,ShVT) SELECT Loai, SoHieu,NgayCT,DienGiai,ShDU,SoPS2No,SoPSNo,SoPS2Co,SoPSCo,NgayGS,SHVT  FROM ({0}) AS Mientru ORDER BY ShVT, NgayGS, Loai, MaCT", st)
            ExecSQLNonQuery(st)
            '********************************* Kiểm tra âm hàng ***********************************************
            Dim luong, tien As Double
            '    SET rs = ExecSQLReturnDT("SELECT * FROM BKNhomPS ORDER BY ShVT, NgayGS, MaCT")
            Dim rs As DataTable = ExecSQLReturnDT("SELECT mact,sops2no,sopsno,sopsco,sops2co,t1.sohieu,shvt,t3.sohieu AS loai FROM (BKNhomPS t1 inner join vattu t2 on t1.shvt=t2.sohieu) inner join phanloaivattu t3 on t2.maphanloai=t3.maso WHERE t3.sohieu<>'KM' ORDER BY ShVT, NgayGS, MaCT,SoPS2No DESC")
            st = ""
            For Each rowItem As DataRow In rs.Rows
                Dim MaCT As Integer = ConvertToDblSafe(rowItem("MaCT"))
                Select Case MaCT
                    Case 0
                        luong = ConvertToDblSafe(rowItem("SoPS2No"))
                        tien = ConvertToDblSafe(rowItem("sopsno"))
                        Exit Select
                    Case 3
                        luong += ConvertToDblSafe(rowItem("SoPS2No")) - ConvertToDblSafe(rowItem("SoPS2Co"))
                        tien += ConvertToDblSafe(rowItem("sopsno")) - ConvertToDblSafe(rowItem("sopsco"))
                        Exit Select
                End Select
                If luong <> 0 Then luong = ConvertToDblSafe(Format(luong, Mask_2))
                If tien <> 0 Then tien = ConvertToDblSafe(Format(tien, Mask_0))
                If luong < 0 Or tien < 0 Or (luong = 0 And tien <> 0) Or (luong <> 0 And tien = 0) Then
                    st = String.Format("{0}{1}({2}), ", _
                             st, _
                             ConvertToStrSafe(rowItem("SoHieu")), _
                             ConvertToStrSafe(rowItem("shvt")))
                End If
            Next
            If st <> "" Then
                If myUMessager.mQuestion(String.Format("Âm hàng tại chứng từ có số hiệu: {0}{1}Tiếp tục ?", Strings.Left(st, st.Length - 2), Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then Return result
            End If
            '********************************* Hết kiểm tra *****************************************************
            result = True
            rptFrom.InitForm("THEKHO3.RPT", "SELECT * FROM BKNhomPS", "BKNhomPS")
            rptFrom.SetFormulas("TenKho", String.Format("'{0}'", (IIf(mkho > 0, String.Format("Kho: {0}", tenkho(mkho)), ("Tổng hợp các kho")))))
            rptFrom.SetFormulas("Thang", tdau)
            rptFrom.SetFormulas("ThangCuoi", tcuoi)
            rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
            RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return result
        End Try
        
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mkho"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function tenkho(ByRef mkho As Integer) As String
        Try
            If mkho = 0 Then
                Return "Tổng hợp các kho"
            Else
                Return ConvertToStrSafe(GetSelectValue(String.Format("SELECT DISTINCT TenKho AS F1 FROM KhoHang WHERE MaSo = {0}", mkho)))
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return String.Empty
        End Try
        Return String.Empty
    End Function
    ''' <summary>
    ''' Hàm trả về mã số, tên phân loại từ số hiệu
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <param name="mpl"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TenPLVT(ByRef sh As String, ByRef mpl As Integer) As String
        Dim result As String = String.Empty
        Try
            Dim rs_tk As DataTable = ExecSQLReturnDT(String.Format("SELECT MaSo,TenPhanLoai FROM PhanLoaiVattu WHERE {0}", (IIf(mpl > 0, String.Format("MaSo={0}", mpl), String.Format("SoHieu=N'{0}'", sh)))))
            If rs_tk.Rows.Count > 0 Then
                mpl = ConvertToDblSafe(rs_tk.Rows(0)("MaSo"))
                result = ConvertToStrSafe(rs_tk.Rows(0)("TenPhanLoai"))
            Else
                mpl = 0
                result = String.Empty
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return String.Empty
        End Try        
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <param name="mpl"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Ten154(ByRef sh As String, ByRef mpl As Integer) As String
        Dim result As String = String.Empty
        Try
            Dim rs_tk As DataTable = ExecSQLReturnDT(String.Format("SELECT MaSo,TenVattu FROM TP154 WHERE SoHieu =N'{0}'", sh))
            If rs_tk.Rows.Count > 0 Then
                mpl = ConvertToDblSafe(rs_tk.Rows(0)("MaSo"))
                result = ConvertToStrSafe(rs_tk.Rows(0)("TenVattu"))
            Else
                mpl = 0
                result = String.Empty
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return result
        End Try        
        Return result
    End Function
    ''' <summary>
    ''' Hàm trả về mã số, tên VT từ số hiệu
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <param name="mvt"></param>
    ''' <param name="dv"></param>
    ''' <param name="DVT2"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TenVT(ByRef sh As String, ByRef mvt As Integer, ByRef dv As String, Optional ByRef DVT2 As Integer = 0) As String
        Dim result As String = String.Empty
        Try
            result = ConvertToStrSafe(GetSelectValue(String.Format("SELECT SoHieu AS F2, TenVattu AS F1, DonVi AS F3,Dvt2 AS F4 FROM Vattu WHERE {0}", (IIf(mvt > 0, "MaSo=" & mvt, "SoHieu like N'" & sh & "'"))), _
                                      sh, _
                                      dv, _
                                      DVT2))
            If mvt = 0 Then mvt = SoHieu2MaSo(sh, "Vattu")
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return result
        End Try
        
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <param name="mvt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TenTP(ByRef sh As String, ByRef mvt As Integer) As String
        Dim result As String = String.Empty
        Try
            result = ConvertToStrSafe(GetSelectValue(String.Format("SELECT SoHieu AS F2, TenVattu AS F1 FROM TP154 WHERE {0}", (IIf(mvt > 0, String.Format("MaSo={0}", mvt), String.Format("SoHieu=N'{0}'", sh)))), sh))
            If mvt = 0 Then mvt = SoHieu2MaSo(sh, "TP154")
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return result
        End Try
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mdv"></param>
    ''' <param name="TyLeQD"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TenDVT(ByRef mdv As Integer, Optional ByRef TyLeQD As Double = 0) As String
        Try
            Return ConvertToStrSafe(GetSelectValue(String.Format("SELECT DonVi AS F1, TyLeQD AS F2 FROM DVTVattu WHERE MaSo={0}", mdv)))
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return String.Empty
        End Try
        Return String.Empty
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ms"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TenNguon(ByRef ms As Integer) As String
        Try
            Return ConvertToStrSafe(GetSelectValue(String.Format("SELECT SoHieu+' - '+DienGiai AS F1 FROM NguonNhapXuat WHERE MaSo={0}", ms)))
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return String.Empty
        End Try
        Return String.Empty
    End Function
    ''' <summary>
    ''' Thủ tục tính số dư đầu kỳ của các tài khoản vật tư
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SoDuTKVT()
        Dim taikhoan As New ClsTaikhoan
        Dim sql As String = String.Empty
        Dim m As Integer = 0
        Try
            Dim rs_tk As DataTable = ExecSQLReturnDT("SELECT DISTINCT MaTaiKhoan,Sum(Tien_0) AS DuDk FROM TonKho GROUP BY MaTaiKhoan")
            For Each rowItem As DataRow In rs_tk.Rows
                Dim MaTK As Integer = ConvertToDblSafe(rowItem("MaTaiKhoan"))
                taikhoan.InitTaikhoanMaSo(MaTK)
                If ConvertToDblSafe(rowItem("DuDk")) > 0 Then
                    taikhoan.NoDauKy = ConvertToDblSafe(rowItem("DuDk"))
                    taikhoan.CoDauKy = 0
                Else
                    taikhoan.CoDauKy = ConvertToDblSafe(rowItem("DuDk"))
                    taikhoan.NoDauKy = 0
                End If
                taikhoan.CapNhatTk()
            Next
            If OutCost <> 0 Then
                sql = String.Format("SELECT ChungTu.MaSo,MaKho,MaTKCo,ChungTu.MaVattu,SoPS2Co FROM ({0}) LEFT JOIN VTDauNam ON ABS(ChungTu.CT_ID)-2000000000=VTDauNam.MaSo WHERE (MaLoai=2 OR MaLoai=4) AND ISNULL(VTDauNam.MaSo) AND ABS(ChungTu.CT_ID)>2000000000  AND TK_ID={1}", _
                          ChungTu2TKNC(1), _
                          ConvertToStrSafe(TKVT_ID))
                rs_tk = ExecSQLReturnDT(sql)
                For Each rowItem As DataRow In rs_tk.Rows
                    m = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM VTDauNam WHERE MaSoKho={0} AND MaTaiKhoan={1} AND MaVattu={2}", _
                                                            ConvertToDblSafe(rowItem("MaKho")), _
                                                            ConvertToDblSafe(rowItem("MaTkCo")), _
                                                            ConvertToDblSafe(rowItem("MaVattu")))))
                    If m > 0 Then
                        ExecSQLNonQuery(String.Format("UPDATE VTDauNam SET SoXuat=SoXuat+{0} WHERE MaSo={1}", _
                                            ConvertToDblSafe(rowItem("SoPS2Co")), _
                                            ConvertToStrSafe(m)))
                        ExecSQLNonQuery(String.Format("UPDATE ChungTu SET CT_ID={0} WHERE MaSo={1}", -(2000000000 - m), rs_tk("MaSo")))
                    End If
                Next
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mvt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetVAT(ByRef mvt As Integer) As Integer
        Try
            Dim sql As String = String.Format("SELECT VAT AS F1 FROM PhanLoaiVattu INNER JOIN Vattu ON PhanLoaiVattu.MaSo=Vattu.MaPhanLoai WHERE Vattu.MaSo={0}", mvt)
            Return ConvertToDblSafe(GetSelectValue(sql))
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return 0
        End Try
        Return 0
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mkho"></param>
    ''' <param name="mvt"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="thongbao"></param>
    ''' <param name="MN"></param>
    ''' <param name="tkdu"></param>
    ''' <param name="loaitk"></param>
    ''' <param name="nn"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InTheKho2N(ByRef mkho As Integer, _
        ByRef mvt As Integer, _
        ByRef ndau As Date, _
        ByRef ncuoi As Date, _
        ByRef thongbao As Boolean, _
        ByRef MN As Integer, _
        Optional ByRef tkdu As String = "", _
        Optional ByRef loaitk As Integer = 0, _
        Optional ByRef nn As Integer = 0) As Boolean
        Dim dkt As Double = 0, dkt2 As Double = 0
        Dim st = String.Empty
        Dim dv As String = String.Empty
        Dim DVT2 As Integer = 0
        Try
            Dim dkl As Double = SoTonKhoN(ndau.AddDays(-1), mkho, 0, mvt, dkt, dkt2)
            Dim QTheKho As String = String.Format("SELECT DISTINCT ChungTu.SoHieu as [ChungTu.SoHieu], ChungTu.NgayCT, ChungTu.DienGiai{0}, ChungTu.MaLoai, ChungTu.SoPS, ChungTu.SoPS2No, ChungTu.SoPS2Co, ChungTu.MaTKTCNo, ChungTu.MaTKTCCo, HeThongTK.SoHieu as [HeThongTK.SoHieu], HeThongTK_1.SoHieu [HeThongTK_1.SoHieu], ChungTu.GhiChu, ChungTu.MaKho, ChungTu.MaNguon,{1} AS PSUSD, DonVi, TyLeQD, ChungTu.NgayGS FROM (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo) ON HeThongTK_1.MaSo = ChungTu.MaTKCo) LEFT JOIN DVTVattu ON ChungTu.DVT=DVTVattu.MaSo  WHERE (SoPS2No<>0 OR SoPS2Co<>0{2}) AND (HethongTK.TK_ID={3} OR HethongTK_1.TK_ID={3}) AND ((ChungTu.MaLoai =1 OR ChungTu.MaLoai =2 OR ChungTu.MaLoai =4) AND {4} AND (chungtu.MaVattu = {5}){6}) {7}{8} ORDER BY ChungTu.NgayGS, ChungTu.MaCT", _
                                       (IIf(pNN > 0, "E", String.Empty)), _
                                       (IIf(pGiaUSD > 0, "PSUSD", "0")), _
                                       (IIf(loaitk = 0, " OR SoPS<>0 ", String.Empty)), _
                                       ConvertToStrSafe(TKVT_ID), _
                                       WNgay("NgayGS", ndau, ncuoi), _
                                       ConvertToStrSafe(mvt), _
                                       (IIf(mkho > 0, String.Format(" AND ((chungtu.MaLoai<4 AND chungtu.MaKho = {0}) OR (chungtu.MaLoai=4 AND (chungtu.MaKho = {1} OR chungtu.MaNguon = {1})))", mkho, ConvertToStrSafe(mkho)), String.Empty)), _
                                       (IIf(MN > 0, String.Format("AND ChungTu.MaLoai<>4 AND ChungTu.MaNguon={0}", MN), String.Empty)), _
                                       (IIf(tkdu.Length > 0, String.Format("AND (HethongTK.SoHieu LIKE '{0}%' OR HethongTK_1.SoHieu LIKE '{0}%')", tkdu), String.Empty)))

            Dim rptFilename = String.Format("THEKHO{0}{1}{2}.RPT", _
                                                 (IIf(loaitk > 0, "2", String.Empty)), _
                                                 (IIf(loaitk = 0 And pGiaUSD > 0, "X", String.Empty)), _
                                                 (IIf(DVT2 > 0, "B", String.Empty)))

            rptFrom.InitForm(rptFilename, QTheKho, "QTheKho")

            rptFrom.SetFormulas("TenKho", String.Format("'{0}'", (IIf(mkho > 0, String.Format("Kho: {0}", tenkho(mkho)), ("Tổng hợp các kho")))))
            rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianN(ndau, ncuoi, nn)))
            rptFrom.SetFormulas("MaKho", mkho)
            Dim sqll As String = TenVT(st, mvt, dv, DVT2)
            rptFrom.SetFormulas("TenVt", String.Format("'{0} - {1}{2}{3}'", _
                                                        st, _
                                                        sqll, _
                                                        " - Đơn vị tính: ", _
                                                        dv))
            rptFrom.SetFormulas("DkLuong", dkl)
            rptFrom.SetFormulas("DkTien", dkt)
            If pGiaUSD > 0 Then rptFrom.SetFormulas("DkTien2", dkt2)
            sqll = ConvertToStrSafe(GetSelectValue(String.Format("SELECT GhiChu AS F1 FROM Vattu WHERE MaSo={0}", mvt)))
            If sqll <> "..." Then rptFrom.SetFormulas("GhiChu", String.Format("'{0}'", sqll))

            If DVT2 > 0 Then
                rptFrom.SetFormulas("TyLeQD", ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 TyLeQD AS F1 FROM DVTVattu WHERE MaVattu={0} ORDER BY MaSo", mvt))))
            End If
            RptSetDate(ncuoi)
            Return True
            If thongbao Then myUMessager.mInformation(Ngonngu("Vật tư không có tồn kho hoặc phát sinh !", "Material not in stock or arising !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
        Return False
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="mvt"></param>
    ''' <param name="mtk"></param>
    ''' <param name="tkdu"></param>
    ''' <param name="l1"></param>
    ''' <param name="T"></param>
    ''' <param name="mkho"></param>
    ''' <remarks></remarks>
    Public Sub NhapTheoNguon(ByRef tdau As Integer, _
        ByRef tcuoi As Integer, _
        ByRef mvt As Integer, _
        ByRef mtk As Integer, _
        ByRef tkdu As String, _
        ByRef l1 As Double, _
        ByRef T As Double, _
        Optional ByRef mkho As Integer = 0)
        Try
            T = ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(SoPS) AS F1,SUM(SoPS2No) AS F2 FROM {0} WHERE {1} AND (ChungTu.MaLoai=1 OR chungtu.maloai=13) AND MaTKNo={2} AND MaVattu={3} AND HethongTK.SoHieu LIKE '{4}%'{5}", _
                                                ChungTu2TKNC(1), _
                                                WThang("ThangCT", tdau, tcuoi), _
                                                ConvertToStrSafe(mtk), _
                                                ConvertToStrSafe(mvt), _
                                                tkdu, _
                                                (IIf(mkho > 0, String.Format(" AND MaKho={0}", mkho), String.Empty))), l1))
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="mvt"></param>
    ''' <param name="mtk"></param>
    ''' <param name="tkdu"></param>
    ''' <param name="l1"></param>
    ''' <param name="T"></param>
    ''' <param name="mkho"></param>
    ''' <remarks></remarks>
    Public Sub XuatTheoNguon(ByRef tdau As Integer, _
        ByRef tcuoi As Integer, _
        ByRef mvt As Integer, _
        ByRef mtk As Integer, _
        ByRef tkdu As String, _
        ByRef l1 As Double, _
        ByRef T As Double, _
        Optional ByRef mkho As Integer = 0)
        Try
            T = ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(SoPS) AS F1,SUM(SoPS2Co) AS F2 FROM {0} WHERE {1} AND ChungTu.MaLoai=2 AND MaTKCo={2} AND MaVattu={3} AND HethongTK.SoHieu LIKE '{4}%'{5}", _
                                                ChungTu2TKNC(-1), _
                                                WThang("ThangCT", tdau, tcuoi), _
                                                ConvertToStrSafe(mtk), _
                                                ConvertToStrSafe(mvt), _
                                                tkdu, _
                                                (IIf(mkho > 0, String.Format(" AND MaKho={0}", mkho), String.Empty))), l1))
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mk"></param>
    ''' <param name="mtk"></param>
    ''' <param name="mvt"></param>
    ''' <param name="Ngay"></param>
    ''' <param name="soluong"></param>
    ''' <param name="tien2"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GiaXuatKho(ByRef mk As Integer, _
        ByRef mtk As Integer, _
        ByRef mvt As Integer, _
        ByRef Ngay As Date, _
        ByRef soluong As Double, _
        Optional ByRef tien2 As Double = 0) As Double
        Dim result As Double = 0
        Dim tien1 As Double = 0, luong As Double = 0, tien As Double = 0, t2 As Double = 0
        tien2 = 0
        Try
            If OutCost = 0 Then
                luong = SoTonKho(ThangTruoc(Ngay.Month), mk, mtk, mvt, tien, tien2)
                luong += SoNhapKho(mk, mtk, mvt, NgayDauThang(pNamTC, Ngay.Month), NgayCuoiThang(pNamTC, Ngay.Month), tien1, t2)
                tien += tien1
                tien2 += t2
                If luong > 0 Then
                    If luong = soluong Then
                        result = tien
                    Else
                        tien2 = (IIf(0.5 + Mask_N * tien2 * soluong / luong > 0, Math.Floor(0.5 + Mask_N * tien2 * soluong / luong), Math.Ceiling(0.5 + Mask_N * tien2 * soluong / luong))) / Mask_N
                        result = RoundMoney(tien * soluong / luong)
                    End If
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return 0
        End Try
        
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mk"></param>
    ''' <param name="mtk"></param>
    ''' <param name="mvt"></param>
    ''' <param name="thang"></param>
    ''' <param name="soluong"></param>
    ''' <param name="tien2"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GiaXuatKhoBQCK(ByRef mk As Integer, _
        ByRef mtk As Integer, _
        ByRef mvt As Integer, _
        ByRef thang As Integer, _
        ByRef soluong As Double, _
        Optional ByRef tien2 As Double = 0) As Double
        Dim result As Double = 0
        Dim tien1 As Double = 0, luong As Double = 0, tien As Double = 0, t2 As Double = 0
        tien2 = 0
        Try
            If OutCost = 0 Then
                luong = SoTonKho(ThangTruoc(thang), mk, mtk, mvt, tien, tien2)
                luong += SoNhapKhoThang(mk, mtk, mvt, thang, thang, tien1, t2)
                tien += tien1
                tien2 += t2
                If luong <> 0 Then
                    If luong = soluong Then
                        result = tien
                    Else
                        tien2 = (IIf(0.5 + Mask_N * tien2 * soluong / luong > 0, Math.Floor(0.5 + Mask_N * tien2 * soluong / luong), Math.Ceiling(0.5 + Mask_N * tien2 * soluong / luong))) / Mask_N
                        result = RoundMoney(tien * soluong / luong)
                    End If
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return result
        End Try
        
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mct"></param>
    ''' <param name="n"></param>
    ''' <param name="thang"></param>
    ''' <param name="xk"></param>
    ''' <param name="tp"></param>
    ''' <param name="ktra"></param>
    ''' <param name="tygia"></param>
    ''' <remarks></remarks>
    Public Sub GhiXuatNVL(ByRef mct As Integer, _
        ByRef n As Date, _
        ByRef thang As Integer, _
        ByRef xk As Integer, _
        ByRef tp As Cls154, _
        Optional ByRef ktra As Integer = 0, _
        Optional ByRef tygia As Double = 1)
        Dim rs, rs2 As DataTable
        Dim rstp, rsdd As DataTable
        Dim tien, tongtien As Double
        Dim mtk As Integer
        Dim phantram As String = String.Empty
        Dim ct As New ClsChungtu
        Dim MaCT As Integer
        Dim dgia, tcp As Double
        Dim thangdm, i As Integer
        Dim sh As String = String.Empty
        Dim luong, tyledd As Double
        Dim dem, kt As Integer
        Dim ps, TongSops As Double
        Dim n0 As Date = NgayDauThang(pNamTC, thang)
        Dim thangdm_dd As Integer, matp_dd As Long, TLHT As Integer, ms_dd As Long
        Try
            If xk <> 0 And ktra = 0 Then
                sh = String.Empty
                phantram = CStr(1 + FrmThanhPham.txtShTk(3).Text / 100)
                XoaCTTheoID(thang, 610000000 + mct, 0, n0, n)
                ExecSQLNonQuery(String.Format("UPDATE ThanhPham SET CPNVL=0 WHERE MaCT={0}", mct))
                Dim Mientru As String = String.Format("SELECT DISTINCT t1.MaSo,t1.SoHieu,t1.Ngay,t1.MaKhoNVL,t1.MaTKCP,t1.MaTKNC,t1.MaTKSX,t1.MaTP,(t1.SoLuong+t1.ddck-t1.dddk) AS soluong,t1.tyle,t1.dongia,t1.nvlpl AS giaban FROM ThanhPham t1 WHERE t1.MaCT={0}", mct)
                rs = ExecSQLReturnDT(Mientru)
                For Each rsItem As DataRow In rs.Rows
                    TongSops = 0
                    thangdm = thang + 1
                    dem = 0
                    While dem = 0 And thangdm > 0
                        thangdm -= 1
                        dem = ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(maso) AS f1 FROM dinhmuc WHERE manvl>0 AND MaTP={0} AND Thang={1}", _
                                                                  rsItem("MaTP"), _
                                                                  ConvertToStrSafe(thangdm))))
                    End While
                    If thangdm > 0 Then
                        phantram = ConvertToStrSafe(1 + ConvertToDblSafe(FrmThanhPham.txtShTk(3).Text) / 100)
                        rs2 = ExecSQLReturnDT(String.Format("SELECT DISTINCT MaNVL,Mientru.SoLuong*DinhMuc.soluong*{0} AS Luong,PL,Mientru.matp FROM (" & Mientru & ") as Mientru INNER JOIN DinhMuc ON Mientru.MaTP=DinhMuc.MaTP WHERE DinhMuc.Thang={1} AND MaNVL>0 AND (DinhMuc.SoLuong<>0 OR DinhMuc.Luong<>0) AND Mientru.MaSo={2}", _
                                                  phantram, _
                                                  ConvertToStrSafe(thangdm), _
                                                  rsItem("MaSo")))
                        For Each rs2Item As DataRow In rs2.Rows
                            rstp = ExecSQLReturnDT(String.Format("SELECT MaTaiKhoan AS F1 FROM TonKho WHERE MaSoKho={0} AND MaVattu={1}", _
                                                                          rsItem("MaKhoNVL"), _
                                                                          rs2Item("maNVL")))
                            tien = 0
                            For Each rs3Item As DataRow In rstp.Rows
                                mtk = rs3Item("f1")
                                luong = ConvertToDblSafe(rs2Item("luong")) * (IIf(rs2Item("pl") = "X", 100 / (100 - ConvertToDblSafe(rsItem("TyLe"))), 1))
                                tien = GiaXuatKho(rsItem("MaKhoNVL"), mtk, ConvertToDblSafe(rs2Item("maNVL")), ConvertToDateSafe(rsItem("Ngay")), luong)
                                If tien <> 0 Then Exit For
                            Next
                            If tien <> 0 Or luong <> 0 Then
                                If luong > 0 Then dgia = IIf(luong <> 0, tien / luong, 0) Else dgia = 0
                                tongtien += tien
                                If ConvertToIntSafe(GetSelectValue("select count(maso) as f1 from chungtu where mavattu=" + CStr(rs2Item("maNVL")) + " and sohieu like 'CPNVLTT" + CStr(tp.SoHieu) + CStr(rsItem("SoHieu")) + "'")) = 0 Then
                                    ct.InitChungtu(0, 2, "CPNVLTT" & tp.SoHieu + rsItem("SoHieu"), thang, rsItem("Ngay"), rsItem("Ngay"), 0, rsItem("MaKhoNVL"), ("Xuất nguyên vật liệu cho sản xuất"), rsItem("MaTKCP"), mtk, doidau(tien), 0, doidau(luong), rs2Item("maNVL"), "Tập hợp tự động", 0, DateTime.Today)
                                    ct.CT_ID = 610000000 + mct
                                    ct.MaTP = tp.MaSo
                                    If sh <> rsItem("SoHieu") Then
                                        sh = rsItem("SoHieu")
                                        MaCT = Lng_MaxValue("MaCT", "ChungTu") + 1
                                    End If
                                    ct.MaCT = MaCT
                                    If pTygia > 0 Then ct.tygia = tygia
                                    If ct.sops > 0 Or ct.SoPS2Co > 0 Then ct.GhiChungtuTH(0, 1)
                                Else
                                    GetSelectValue("update chungtu set sops=sops+" + doidau(tien) + ", sops2co=sops2co+" + doidau(luong) + " where mavattu=" + CStr(rs2Item("maNVL")) + " and sohieu like 'CPNVLTT" + CStr(tp.SoHieu) + CStr(rsItem("SoHieu")) + "' and mavattu=" + CStr(rs2Item("maNVL")))
                                End If
                                '*************************************************** Thành phẩm dở dang ************************************************
                                rstp = ExecSQLReturnDT(String.Format("SELECT * FROM thanhpham WHERE maso={0}", rsItem("MaSo")))
                                rsdd = ExecSQLReturnDT(String.Format("SELECT * FROM thanhphamdd WHERE makt like '{0}{1}' AND makhonvl={2} AND ngay=(SELECT max(ngay) FROM thanhphamdd WHERE makt={0}{1} AND ngay<=N'{3}' AND makhonvl={2})", _
                                                           rstp.Rows(0)("MaCT"), _
                                                           rstp.Rows(0)("MaTP"), _
                                                           rstp.Rows(0)("MaKhoNVL"), _
                                                           Format(CDate(rstp.Rows(0)("Ngay")), Mask_DB)))
                                kt = 0
                                If rsdd.Rows.Count > 0 Then
                                    If ConvertToDblSafe(rstp.Rows(0)("soluong")) + ConvertToDblSafe(rstp.Rows(0)("ddck")) > ConvertToDblSafe(rstp.Rows(0)("dddk")) _
                                    And ConvertToDblSafe(rstp.Rows(0)("soluong")) < ConvertToDblSafe(rstp.Rows(0)("dddk")) Then
                                        tyledd = ConvertToDblSafe(rstp.Rows(0)("soluong")) / (IIf(ConvertToDblSafe(rstp.Rows(0)("dddk")) = 0, 1, ConvertToDblSafe(rstp.Rows(0)("dddk"))))
                                        ExecSQLNonQuery(String.Format("UPDATE ThanhPhamDD SET CPNC=CPNC+{0}-{1},CPSXC=CPSXC+{2}-{3},CPNVL=CPNVL+{4} WHERE maso={5}", _
                                                            doidau(rsdd.Rows(0)("cpnc")), _
                                                            doidau(rstp.Rows(0)("cpnc")), _
                                                            doidau(rsdd.Rows(0)("cpsxc")), _
                                                            doidau(rstp.Rows(0)("cpsxc")), _
                                                            doidau(ConvertToDblSafe(rsdd.Rows(0)("CPNVL")) * (1 - tyledd)), _
                                                            rstp.Rows(0)("MaSo")))
                                    End If
                                End If
                                '*************************************************** Hết thành phẩm dở dang ********************************************
                                ps = ConvertToDblSafe(GetSelectValue(String.Format("SELECT ((ThanhPham.SoLuong+ThanhPham.ddck-ThanhPham.dddk)*DinhMuc.SoLuong*{0}*{1}*{2}) AS f1 FROM ThanhPham INNER JOIN DinhMuc ON ThanhPham.MaTP=DinhMuc.MaTP WHERE ThanhPham.MaSo={3} AND DinhMuc.Thang={4} AND MaNVL={5}", _
                                                                         (IIf(luong <> 0, String.Format("{0} /{1}", tien, luong), "0")), _
                                                                         phantram, _
                                                                         doidau(IIf(ConvertToStrSafe(rs2Item("pl")) = "X", 100 / (100 - ConvertToDblSafe(rsItem("TyLe"))), 1)), _
                                                                         rsItem("MaSo"), _
                                                                         thangdm, _
                                                                         rs2Item("maNVL"))))
                                TongSops += ps
                                ExecSQLNonQuery(String.Format("UPDATE ThanhPham SET CPNVL={0} WHERE ThanhPham.MaSo={1}", doidau(TongSops), rsItem("MaSo")))
                            End If
                            ExecSQLNonQuery(String.Format("UPDATE thanhpham SET giathanh=cpnvl+cpnc+cpsxc WHERE maso={0}", rsItem("MaSo")))
                        Next
                    End If
                    'Tru lai chi phi nguyen vat lieu cua chi phi do dang
                    matp_dd = GetSelectValue("select matp as f1, thang as f2, phantramck as f3, maso as f4 from thanhpham where mact=" + CStr(mct) + " and matp=" + CStr(rsItem("MaTP")) + " and phantramck > 0 and phantramck <= 100", thangdm_dd, TLHT, ms_dd)
                    thangdm_dd = thangdm_dd + 1
                    dem = 0
                    While dem = 0 And thangdm_dd > 0
                        thangdm_dd = thangdm_dd - 1
                        dem = GetSelectValue("select count(maso) as f1 from dinhmuc where manvl>0 and MaTP=" + CStr(matp_dd) + " AND Thang=" + CStr(thangdm_dd))
                    End While
                    If thangdm_dd > 0 Then
                        'Tru theo so luong
                        rs2 = ExecSQLReturnDT("SELECT DISTINCT dm.MaNVL,dd.SoLuong * dm.soluong * " + phantram + " AS Luong,PL,dd.matp FROM thanhphamdd dd INNER JOIN DinhMuc dm ON dd.MaTP=dm.MaTP WHERE dm.Thang=" + CStr(thangdm_dd) + " AND MaNVL>0 AND (dm.SoLuong<>0 or dm.Luong<>0) AND dd.MaSo=" + CStr(ms_dd))
                        For Each rs2Item As DataRow In rs2.Rows
                            mtk = GetSelectValue("SELECT MaTaiKhoan AS F1 FROM TonKho WHERE MaSoKho=" + CStr(rsItem("MaKhoNVL")) + " AND MaVattu=" + CStr(rs2Item("maNVL")))
                            If rs2Item("pl") = "X" Then
                                luong = ConvertToDblSafe(rs2Item("luong")) * 100 / (100 - ConvertToDblSafe(rsItem("TyLe")))
                            Else
                                luong = ConvertToDblSafe(rs2Item("luong"))
                            End If
                            tien = GiaXuatKho(CStr(rsItem("MaKhoNVL")), CStr(mtk), CStr(rs2Item("maNVL")), CDate(rsItem("Ngay")), CStr(luong))
                            If tien <> 0 Then
                                If luong <> 0 Then dgia = tien / luong Else dgia = 0
                                tongtien = tongtien - tien
                                ExecSQLNonQuery("update chungtu set sops=sops-" + doidau(tien) + ", sops2co=sops2co-" + doidau(luong) + " where sohieu like 'CPNVLTT" + CStr(tp.SoHieu) + CStr(rsItem("SoHieu")) + "' and mavattu=" + CStr(rs2Item("maNVL")))
                                ExecSQLNonQuery("UPDATE ThanhPham SET CPNVL=CPNVL-" + doidau(tien) + " where maso=" + CStr(rsItem("MaSo")))
                                ExecSQLNonQuery("update thanhpham set giathanh=cpnvl+cpnc+cpsxc+cpsxcn where maso=" + CStr(rsItem("MaSo")))
                            End If
                        Next
                        rs2 = New DataTable
                        'Cong them do dang theo phan tram dinh muc
                        rs2 = ExecSQLReturnDT("SELECT DISTINCT dm.MaNVL,dd.SoLuong * dm.soluong * " + phantram + " AS Luong,PL,dd.matp FROM thanhphamdd dd INNER JOIN DinhMuc dm ON dd.MaTP=dm.MaTP WHERE dm.Thang=" + CStr(thangdm_dd) + " AND MaNVL>0 AND (dm.SoLuong<>0 or dm.Luong<>0) AND dd.MaSo=" + CStr(ms_dd) + " and dm.TLHT<=" + CStr(TLHT))
                        For Each rs2Item As DataRow In rs2.Rows
                            mtk = GetSelectValue("SELECT MaTaiKhoan AS F1 FROM TonKho WHERE MaSoKho=" + CStr(rsItem("MaKhoNVL")) + " AND MaVattu=" + CStr(rs2Item("maNVL")))
                            If rs2Item("pl") = "X" Then
                                luong = ConvertToDblSafe(rs2Item("luong")) * 100 / (100 - ConvertToDblSafe(rsItem("TyLe")))
                            Else
                                luong = ConvertToDblSafe(rs2Item("luong"))
                            End If
                            tien = GiaXuatKho(CStr(rsItem("MaKhoNVL")), CStr(mtk), CStr(rs2Item("maNVL")), CDate(rsItem("Ngay")), CStr(luong))
                            If tien <> 0 Then
                                If luong <> 0 Then dgia = tien / luong Else dgia = 0
                                tongtien = tongtien + tien
                                ExecSQLNonQuery("update chungtu set sops=sops+" + doidau(tien) + ", sops2co=sops2co+" + doidau(luong) + " where sohieu like 'CPNVLTT" + CStr(tp.SoHieu) + CStr(rsItem("SoHieu")) + "' and mavattu=" + CStr(rs2Item("maNVL")))
                            End If
                        Next
                    End If
                    'Cong them do dang theo phan tram xuat thang truoc
                    tien = 0
                    tien = tien + GetSelectValue("select cpnvl as f1 from thanhphamdd where makt=" + CStr(mct) + (CStr(rsItem("MaTP"))))
                    ExecSQLNonQuery("UPDATE ThanhPham SET CPNVL=CPNVL+" + doidau(tien) + " where maso=" + CStr(rsItem("MaSo")))
                    ExecSQLNonQuery("update thanhpham set giathanh=cpnvl+cpnc+cpsxc+cpsxcn where maso=" + CStr(rsItem("MaSo")))
                    'Het tru lai chi phi nguyen vat lieu cua chi phi do dang
                    'Xuat them nguyen vat lieu cho thanh phan do dang ky truoc
                    matp_dd = GetSelectValue("select matp as f1, thang as f2, phantram as f3, maso as f4 from thanhphamdd where makt=" + CStr(mct) + CStr(rsItem("MaTP")) + " and phantram>0 and phantram<=100", thangdm_dd, TLHT, ms_dd)
                    thangdm_dd = thangdm_dd + 1
                    dem = 0
                    While dem = 0 And thangdm_dd > 0
                        thangdm_dd = thangdm_dd - 1
                        dem = GetSelectValue("select count(maso) as f1 from dinhmuc where manvl>0 and MaTP=" + CStr(matp_dd) + " AND Thang=" + CStr(thangdm_dd))
                    End While
                    If thangdm_dd > 0 Then
                        rs2 = New DataTable
                        rs2 = ExecSQLReturnDT("SELECT DISTINCT dm.MaNVL,dd.SoLuong * dm.soluong * " + phantram + " AS Luong,PL,dd.matp FROM thanhphamdd dd INNER JOIN DinhMuc dm ON dd.MaTP=dm.MaTP WHERE dm.Thang=" + CStr(thangdm_dd) + " AND MaNVL>0 AND (dm.SoLuong<>0 or dm.Luong<>0) AND dd.MaSo=" + CStr(ms_dd) + " and dm.TLHT>" + CStr(TLHT))
                        For Each rs2Item As DataRow In rs2.Rows
                            mtk = GetSelectValue("SELECT MaTaiKhoan AS F1 FROM TonKho WHERE MaSoKho=" + CStr(rsItem("MaKhoNVL")) + " AND MaVattu=" + CStr(rs2Item("maNVL")))
                            If rs2Item("pl") = "X" Then
                                luong = ConvertToDblSafe(rs2Item("luong")) * 100 / (100 - ConvertToDblSafe(rsItem("TyLe")))
                            Else
                                luong = ConvertToDblSafe(rs2Item("luong"))
                            End If
                            tien = GiaXuatKho(CStr(rsItem("MaKhoNVL")), CStr(mtk), CStr(rs2Item("maNVL")), CDate(rsItem("Ngay")), CStr(luong))
                            If tien <> 0 Then
                                If luong <> 0 Then dgia = tien / luong Else dgia = 0
                                tongtien = tongtien + tien
                                If ConvertToIntSafe(GetSelectValue("select count(maso) as f1 from chungtu where mavattu=" + CStr(rs2Item("maNVL")) + "and sohieu like 'CPNVLTT" + CStr(tp.SoHieu) + CStr(rsItem("SoHieu")) + "'")) = 0 Then
                                    ct.InitChungtu(0, 2, "CPNVLTT" + tp.SoHieu + rsItem("SoHieu"), thang, CDate(rsItem("Ngay")), CDate(rsItem("Ngay")), 0, rsItem("MaKhoNVL"), "Xuất nguyên vật liệu cho sản xuất", rsItem("MaTKCP"), mtk, doidau(tien), _
                                        0, luong, rs2Item("maNVL"), "Tập hợp tự động", 0, DateTime.Today)
                                    ct.CT_ID = 610000000 + mct
                                    ct.MaTP = tp.MaSo
                                    If sh <> rsItem("SoHieu") Then
                                        sh = rsItem("SoHieu")
                                        MaCT = Lng_MaxValue("MaCT", "ChungTu") + 1
                                    End If
                                    ct.MaCT = MaCT
                                    If pTygia > 0 Then ct.tygia = tygia
                                    If ct.sops > 0 Then ct.GhiChungtuTH(0, 1)
                                Else
                                    ExecSQLNonQuery("update chungtu set sops=sops+" + doidau(tien) + ", sops2co=sops2co+" + doidau(luong) + " where mavattu=" + CStr(rs2Item("maNVL")) + " and sohieu like 'CPNVLTT" + CStr(tp.SoHieu) + CStr(rsItem("SoHieu")) + "' and mavattu=" + CStr(rs2Item("maNVL")))
                                End If
                                ExecSQLNonQuery("UPDATE ThanhPham SET CPNVL=CPNVL+" + doidau(tien) + " where maso=" + CStr(rsItem("MaSo")))
                            End If
                            ExecSQLNonQuery("update thanhpham set giathanh=cpnvl+cpnc+cpsxc+cpsxcn where maso=" + CStr(rsItem("MaSo")))
                        Next
                    End If
                    'Het xuat them nguyen vat lieu cho thanh pham do dang ky truoc
                Next
            Else
                XoaCTTheoID(thang, 610000000 + mct, 0, n0, n, 2)
            End If
            '*********************************************** code cu **************************************************************
            sh = String.Empty
            rs = ExecSQLReturnDT(String.Format("SELECT DISTINCT SoHieu,Ngay,MaTKCP,MaTKSX,{0} AS Tien FROM ThanhPham WHERE CPNVL<>0 AND MaCT={1} GROUP BY SoHieu,Ngay,MaTKCP,MaTKSX", _
                                     RoundMoneySQL("Sum(CPNVL)"), _
                                     mct))
            Dim nvltt As Double
            For Each rsItem As DataRow In rs.Rows
                nvltt = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(sops) AS f1 FROM chungtu WHERE sohieu LIKE 'CPNVLTT{0}{1}' AND thangct={2}", _
                                                            tp.SoHieu, _
                                                            rsItem("SoHieu"), _
                                                            ConvertToStrSafe(thang))))
                ct.InitChungtu(0, _
                    3, _
                    String.Format("KCCPNVL{0}{1}", tp.SoHieu, rsItem("SoHieu")), _
                    thang, _
                    rsItem("Ngay"), _
                    rsItem("Ngay"), _
                    0, _
                    0, _
                    "Kết chuyển chi phí nguyên vật liệu trực tiếp", _
                    rsItem("MaTKSX"), _
                    rsItem("MaTKCP"), _
                    doidau(nvltt), _
                    0, _
                    0, _
                    0, _
                    "KC", _
                    0, DateTime.Today)
                ct.MaTP = tp.MaSo
                If sh <> rsItem("SoHieu") Then
                    sh = rsItem("SoHieu")
                    MaCT = Lng_MaxValue("MaCT", "ChungTu") + 1
                End If
                ct.MaCT = MaCT
                ct.CT_ID = 610000000 + mct
                If pTygia > 0 Then ct.tygia = tygia
                If ct.sops > 0 Then ct.GhiChungtuTH(0, 1)
            Next
            sh = String.Empty
            rs = ExecSQLReturnDT(String.Format("SELECT DISTINCT SoHieu,Ngay,MaTKNC,MaTKSX,MaTP,Sum(SoLuong) AS SL FROM ThanhPham WHERE MaCT={0} GROUP BY SoHieu,Ngay,MaTKNC,MaTKSX,MaTP", mct))
            For Each rsItem As DataRow In rs.Rows
                tien = RoundMoney(rsItem("sl") * ConvertToDblSafe(GetSelectValue(String.Format("SELECT  TOP 1 SoLuong AS F1 FROM DinhMuc WHERE MaNVL=0 AND MaTP={0} AND {1} ORDER BY {2} DESC", _
                                                                                     rsItem("MaTP"), _
                                                                                     WThang("Thang", 0, thang), _
                                                                                     SetMonthOrder("Thang")))))
                If tien <> 0 Then
                    ct.InitChungtu(0, _
                        3, _
                        String.Format("KCCPNC{0}{1}", thang, rsItem("SoHieu")), _
                        thang, _
                        rsItem("Ngay"), _
                        rsItem("Ngay"), _
                        0, _
                        0, _
                        "Kết chuyển chi phí nhân công trực tiếp", _
                        rsItem("MaTKSX"), _
                        rsItem("MaTKNC"), _
                        doidau(tien), _
                        0, _
                        0, _
                        0, _
                        "KC", _
                        0, DateTime.Today)
                    If sh <> rsItem("SoHieu") Then
                        sh = rsItem("SoHieu")
                        MaCT = Lng_MaxValue("MaCT", "ChungTu") + 1
                    End If
                    ct.MaCT = MaCT
                    ct.CT_ID = 610000000 + mct
                    If pTygia > 0 Then ct.tygia = tygia
                    If ct.sops > 0 Then ct.GhiChungtuTH(0, 1)
                End If
            Next
            Dim st As String = ConvertToStrSafe(CThangDB2(thang))
            MaCT = Lng_MaxValue("MaCT", "ChungTu") + 1
            mtk = ConvertToDblSafe(GetSelectValue("SELECT Top 1 MaSo AS F1 FROM HethongTK WHERE SoHieu LIKE '334%' AND TKCon=0"))
            rs = ExecSQLReturnDT(String.Format("SELECT MaSo,DuCo_{0} AS NC FROM HethongTK WHERE DuCo_{0}<>0 AND TKCon=0 AND SoHieu LIKE '622%'", st))
            For Each rsItem As DataRow In rs.Rows
                ct.InitChungtu(0, _
                    0, _
                    String.Format("CPNC{0}", thang), _
                    thang, _
                    n, _
                    n, _
                    0, _
                    0, _
                    "Chi phí nhân công trực tiếp", _
                    rsItem("MaSo"), _
                    mtk, _
                    doidau(rsItem("nC")), _
                    0, _
                    0, _
                    0, _
                    "KC tự động", _
                    0, DateTime.Today)
                ct.MaCT = MaCT
                ct.CT_ID = 610000000 + mct
                If pTygia > 0 Then ct.tygia = tygia
                If ct.sops > 0 Then ct.GhiChungtuTH(0, 1)
            Next
            MaCT = Lng_MaxValue("MaCT", "ChungTu") + 1
            rs = ExecSQLReturnDT(String.Format("SELECT MaSo,DuNo_{0}-DuCo_{0} AS Tien FROM HethongTK WHERE TKCon=0 AND SoHieu LIKE '627%'", st))
            rs2 = ExecSQLReturnDT(String.Format("SELECT MaTKSX FROM ThanhPham WHERE MaCT={0} GROUP BY MaTKSX", mct))
            If rs2.Rows.Count > 0 Then
                For Each rsItem As DataRow In rs.Rows
                    ct.InitChungtu(0, _
                    3, _
                    "KCCPSXC" & thang, _
                    thang, _
                    n, _
                    n, _
                    0, _
                    0, _
                    "Kết chuyển chi phí sản xuất chung", _
                    rs2.Rows(0)("MaTKSX"), _
                    rsItem("MaSo"), _
                    doidau(rsItem("tien")), _
                    0, _
                    0, _
                    0, _
                    "KC tự động", _
                    0, DateTime.Today)
                    ct.MaCT = MaCT
                    ct.CT_ID = 610000000 + mct
                    If pTygia > 0 Then ct.tygia = tygia
                    If ct.sops > 0 Then ct.GhiChungtuTH(0, 1)
                Next
            End If
            '************************************************** Hết code cu *************************************************
            If pDTTP = 0 Then
                tcp = PSTKCP("627", thang, thang)
                If ConvertToDblSafe(GetSelectValue(String.Format("SELECT CAST(0.5+Sum(CPSXC) AS INT) AS F1 FROM ThanhPham WHERE Thang={0}", thang))) <> tcp Then
                    tongtien = ConvertToDblSafe(GetSelectValue(String.Format("SELECT CAST(0.5+Sum(CPNC) AS INT) AS F1 FROM ThanhPham WHERE Thang={0}", thang)))
                    If tongtien > 0 Then
                        thangdm = thang + 1
                        While dem = 0 And thangdm > 0
                            thangdm -= 1
                            dem = ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(maso) AS f1 FROM dinhmuc WHERE manvl>0 AND MaTP={0} AND Thang={1}", _
                                                                      rs.Rows(0)("MaTP"), _
                                                                      ConvertToStrSafe(thangdm))))
                        End While
                        ExecSQLNonQuery(String.Format("UPDATE ThanhPham SET CPSXC=CPNC/{0} WHERE Thang={1}", doidau(tongtien), ConvertToStrSafe(thang)))
                        rs = ExecSQLReturnDT(String.Format("SELECT * FROM ThanhPham WHERE Thang={0} ORDER BY CPSXC", thang))
                        i = 0
                        tongtien = 0
                        For Each rsItem As DataRow In rs.Rows
                            i += 1
                            If i < thangdm Then
                                tien = IIf(0.5 + tcp * ConvertToDblSafe(rsItem("cpsxc")) > 0, Math.Floor(0.5 + tcp * ConvertToDblSafe(rsItem("cpsxc"))), Math.Ceiling(0.5 + tcp * ConvertToDblSafe(rsItem("cpsxc"))))
                                tongtien += tien
                            Else
                                tien = tcp - tongtien
                            End If
                            ExecSQLNonQuery(String.Format("UPDATE ThanhPham SET CPSXC={0} WHERE MaSo={1}", doidau(tien), rsItem("MaSo")))
                        Next
                    End If
                End If
            End If
            '************************************************ code cu *************************************************************
            MaCT = Lng_MaxValue("MaCT", "ChungTu") + 1
            rs = ExecSQLReturnDT(String.Format("SELECT MaSo,DuNo_{0}-DuCo_{0} AS Tien FROM HethongTK WHERE TKCon=0 AND SoHieu LIKE '622%'", st))
            rs2 = ExecSQLReturnDT(String.Format("SELECT MaTKSX FROM ThanhPham WHERE MaCT={0} GROUP BY MaTKSX", mct))
            If rs2.Rows.Count > 0 Then
                For Each rsItem As DataRow In rs.Rows
                    ct.InitChungtu(0, _
                        3, _
                        String.Format("KCCPNC{0}", thang), _
                        thang, _
                        n, _
                        n, _
                        0, _
                        0, _
                        "Kết chuyển chi phí nhân công", _
                        rs2.Rows(0)("MaTKSX"), _
                        rsItem("MaSo"), _
                        doidau(rsItem("tien")), _
                        0, _
                        0, _
                        0, _
                        "KC tự động", _
                        0, DateTime.Today)
                    ct.MaCT = MaCT
                    ct.CT_ID = 610000000 + mct
                    If pTygia > 0 Then ct.tygia = tygia
                    If ct.sops Then ct.GhiChungtuTH(0, 1)
                Next
            End If
            '************************************************ Hết code cu *********************************************************
            PBCPKhac("641", thang)
            PBCPKhac("642", thang)
            Dim CP621 As Object = 0
            Dim CP622 As Object = 0
            Dim CP627 As Double = 0
            Dim CP627N As Double = 0
            Dim rs4 As DataTable
            Dim Gtpl As Double
            Dim MaSo As Integer
            Dim TK As New ClsTaikhoan
            If ktra = 0 And pGiaHT = 0 Then
                sh = ""
                rs = ExecSQLReturnDT(String.Format("SELECT DISTINCT SoHieu,Ngay,MaTK,MaTP,MaKhoTP,MaTKSX,Sum(SoLuong) AS Luong,{0} AS Tien,tyle,plth FROM ThanhPham WHERE MaCT={1} GROUP BY SoHieu,Ngay,MaTK,MaTP,MaKhoTP,MaTKSX,tyle,plth", _
                                         RoundMoneySQL("Sum(CPNVL+CPNC+CPSXC+CPSXCN)"), _
                                         mct))
                For Each rsItem As DataRow In rs.Rows
                    If sh <> rsItem("SoHieu") Then
                        sh = rsItem("SoHieu")
                        MaCT = Lng_MaxValue("MaCT", "ChungTu") + 1
                    End If
                    ct.InitChungtu(0, _
                        1, _
                        String.Format("KCTP-{0}{1}{2}", thang, ConvertToStrSafe(tp.MaSo), sh), _
                        thang, _
                        n0, _
                        n0, _
                        0, _
                        rsItem("MaKhoTP"), _
                        "Kết chuyển thành phẩm hoàn thành", _
                        rsItem("MaTK"), _
                        0, _
                        doidau(rsItem("tien")), _
                        doidau(rsItem("luong")), _
                        0, _
                        rsItem("MaTP"), _
                        "KC tự động", _
                        0, DateTime.Today)
                    ct.MaCT = MaCT
                    ct.MaTP = tp.MaSo
                    ct.CT_ID = 610000000 + mct
                    If pTygia > 0 Then
                        ct.tygia = tygia
                    End If
                    If ConvertToDblSafe(rsItem("TyLe")) <> 0 And ConvertToStrSafe(rsItem("PLTH")) <> "..." And ConvertToStrSafe(rsItem("PLTH")) <> "" Then
                        Gtpl = ConvertToDblSafe(GetSelectValue(String.Format("SELECT soluong*tyle/(100-tyle)*dongia AS f1 FROM thanhpham WHERE matp={0} AND thang={1}", _
                                                                   rsItem("MaTP"), _
                                                                   thang)))
                        ct.sops -= Gtpl
                        ExecSQLNonQuery(String.Format("UPDATE thanhpham SET giathanh={0} WHERE matp={1} AND thang={2}", _
                                            doidau(ct.sops), _
                                            rsItem("MaTP"), _
                                            ConvertToStrSafe(thang)))
                        If ct.sops > 0 Then ct.GhiChungtuTH(0, 1)
                        ct.sops = Gtpl
                        ct.SoPS2No = ct.SoPS2No * ConvertToDblSafe(rsItem("TyLe")) / (100 - ConvertToDblSafe(rsItem("TyLe")))
                        ct.MaVattu = ConvertToDblSafe(Timten("maso", rsItem("PLTH"), "sohieu", "vattu"))
                        'thuc hien 1523
                        rs4 = ExecSQLReturnDT("SELECT SoHieu AS F1 FROM HeThongTK WHERE SoHieu LIKE '152%'")
                        If rs4.Rows.Count > 0 Then
                            TK.InitTaikhoanSohieu("1523")
                            If TK.maso > 0 Then GoTo KhongThem
                            TK.InitTaikhoanSohieu("152")
                            ExecSQLNonQuery(String.Format("INSERT INTO HethongTK (MaSo,SoHieu,Cap,Ten,Loai,Kieu,TkCha0,Tkcha1, MaTC,TK_ID) VALUES ({0},'1523',2, N'{1}',1,-1,{2},{3},{4},1000)", _
                                                Lng_MaxValue("Maso", "hethongtk") + 1, _
                                                "Phế liệu", _
                                                TK.maso, _
                                                TK.TkCha0, _
                                                ConvertToStrSafe(Lng_MaxValue("MaTC", "hethongtk") + 1)))
                        End If
KhongThem:
                        MaSo = ConvertToDblSafe((Timten("maso", "1523", "sohieu", "hethongtk")))
                        ct.tkno.maso = MaSo
                        ct.tkno.MaTC = MaSo
                    End If
                    If ct.sops > 0 Then ct.GhiChungtuTH(0, 1)
                    ExecSQLNonQuery(String.Format("UPDATE chungtu SET mathuchi=N'{0}' WHERE MaSo>= all(SELECT maso FROM chungtu)", phantram))
                Next
                FrmThanhPham.txtShTk(3).Text = "0"
                rs = ExecSQLReturnDT(String.Format("SELECT DISTINCT SoHieu,Ngay,MaTK,MaTP,MaKhoTP,MaTKSX,CPNVL,CPNC,CPSXC,CPSXCN,DDCK,soluong FROM ThanhPham WHERE MaCT={0} GROUP BY SoHieu,Ngay,MaTK,MaTP,MaKhoTP,MaTKSX,CPNVL,CPNC,CPSXC,CPSXCN,DDCK,soluong", mct))
                For Each rsItem As DataRow In rs.Rows
                    CP621 += ConvertToDblSafe(rsItem("CPNVL"))
                    CP622 += ConvertToDblSafe(rsItem("cpnc"))
                    CP627 += ConvertToDblSafe(rsItem("cpsxc"))
                    CP627N += ConvertToDblSafe(rsItem("cpsxcn"))
                Next
                rs2 = ExecSQLReturnDT("SELECT Maso FROM HethongTK WHERE SoHieu='1541'")
                ct.InitChungtu(0, _
                    1, _
                    String.Format("KCTP-{0}{1}{2}", thang, ConvertToStrSafe(tp.MaSo), sh), _
                    thang, _
                    n0, _
                    n0, _
                    0, _
                    1, _
                    "Kết chuyển thành phẩm hoàn thành", _
                    0, _
                    rs2.Rows(0)("MaSo"), _
                    doidau(CP621), _
                    0, _
                    0, _
                    0, _
                    "155", _
                    0, DateTime.Today)
                ct.MaCT = MaCT
                ct.MaTP = tp.MaSo
                ct.CT_ID = 610000000 + mct
                If pTygia > 0 Then ct.tygia = tygia
                If ct.sops > 0 Then ct.GhiChungtuTH(0, 1)
                rs2 = ExecSQLReturnDT("SELECT Maso FROM HethongTK WHERE SoHieu='1541'")
                ct.InitChungtu(0, _
                    1, _
                    String.Format("KCTP-{0}{1}{2}", thang, ConvertToStrSafe(tp.MaSo), sh), _
                    thang, _
                    n0, _
                    n0, _
                    0, _
                    1, _
                    "Kết chuyển thành phẩm hoàn thành", _
                    0, _
                    rs2.Rows(0)("MaSo"), _
                    doidau(CP622), _
                    0, _
                    0, _
                    0, _
                    "155", _
                    0, DateTime.Today)
                ct.MaCT = MaCT
                ct.MaTP = tp.MaSo
                ct.CT_ID = 610000000 + mct
                If pTygia > 0 Then ct.tygia = tygia
                If ct.sops > 0 Then ct.GhiChungtuTH(0, 1)
                rs2 = ExecSQLReturnDT("SELECT Maso FROM HethongTK WHERE SoHieu='1541'")
                ct.InitChungtu(0, _
                    1, _
                    String.Format("KCTP-{0}{1}{2}", thang, ConvertToStrSafe(tp.MaSo), sh), _
                    thang, _
                    n0, _
                    n0, _
                    0, _
                    1, _
                    "Kết chuyển thành phẩm hoàn thành", _
                    0, _
                    IIf(ConvertToStrSafe(rs2.Rows(0)("MaSo")) <> "", rs2.Rows(0)("MaSo"), 0), _
                    doidau(CP627 + CP627N), _
                    0, _
                    0, _
                    0, _
                    "155", _
                    0, DateTime.Today)
                ct.MaCT = MaCT
                ct.MaTP = tp.MaSo
                ct.CT_ID = 610000000 + mct
                If pTygia > 0 Then ct.tygia = tygia
                If ct.sops > 0 Then ct.GhiChungtuTH(0, 1)
                rs = ExecSQLReturnDT(String.Format("SELECT DISTINCT MaTP,Vattu.SoHieu FROM ThanhPham INNER JOIN Vattu ON ThanhPham.MaTP=Vattu.MaSo WHERE MaCT={0} GROUP BY MaTP,Vattu.SoHieu", mct))
                For Each rsItem As DataRow In rs.Rows
                    TinhGXK(thang, thang, rsItem("SoHieu"), "621", 1)
                Next
            End If
            ct = Nothing
            If ktra = 0 Then
                KiemTraVatTu()
                'KiemTraTaiKhoan()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="shtk"></param>
    ''' <param name="thang"></param>
    ''' <remarks></remarks>
    Private Sub PBCPKhac(ByRef shtk As String, ByRef thang As Integer)
        Dim dgia As Double = 0
        Try
            Dim st As String = ConvertToStrSafe(CThangDB2(thang))
            Dim sopb As Double = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(DuNo_{0}-DuCo_{0}) AS F1 FROM HethongTK WHERE TKCon=0 AND SoHieu LIKE '{1}%'", _
                                                                     st, _
                                                                     shtk)))
            Dim luongtp As Double = ConvertToDblSafe(GetSelectValue("SELECT Sum(SoLuong) AS F1 FROM ThanhPham WHERE Thang=" & thang))
            If luongtp <> 0 Then dgia = sopb / luongtp
            Select Case shtk
                Case "641"
                    ExecSQLNonQuery(String.Format("UPDATE ThanhPham SET CPBH=SoLuong*{0}", CStr(dgia)))
                Case "642"
                    ExecSQLNonQuery(String.Format("UPDATE ThanhPham SET CPQL=SoLuong*{0}", CStr(dgia)))
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mpl"></param>
    ''' <remarks></remarks>
    Public Sub DanhDiemVT(ByRef mpl As Integer)
        Try
            'Dim QChitiet As String = "SELECT DISTINCT PhanLoaiVattu.MaSo AS MPL3,PLCha AS PLCha3,PhanLoaiVattu.SoHieu AS SHPL3, PhanLoaiVattu.TenPhanLoai AS TenPL3, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, GiaBan1, GiaBan2, GiaBan3, DVTVattu.DonVi AS DVQD, DVTVattu.TyLeQD, DVTVattu.GiaBan FROM (PhanLoaiVattu INNER JOIN Vattu ON PhanLoaiVattu.MaSo = Vattu.MaPhanLoai) LEFT JOIN DVTVattu ON Vattu.MaSo=DVTVattu.MaVattu ORDER BY PhanLoaiVattu.SoHieu, Vattu.SoHieu, DVTVattu.DonVi"
            Dim QChitiet As String = "SELECT DISTINCT PhanLoaiVattu.MaSo AS MPL3,PLCha AS PLCha3,PhanLoaiVattu.SoHieu AS SHPL3, PhanLoaiVattu.TenPhanLoai AS TenPL3, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, GiaBan1, GiaBan2, GiaBan3, DVTVattu.DonVi AS DVQD, DVTVattu.TyLeQD, DVTVattu.GiaBan FROM (PhanLoaiVattu INNER JOIN Vattu ON PhanLoaiVattu.MaSo = Vattu.MaPhanLoai) LEFT JOIN DVTVattu ON Vattu.MaSo=DVTVattu.MaVattu"
            Dim QDuPhong As String = String.Format("SELECT QChitiet.*,PhanLoaiVattu.MaSo AS MPL2,PhanLoaiVattu.SoHieu AS SHPL2,TenPhanLoai AS TenPL2,PhanLoaiVattu.PLCha AS PLCha2 FROM ({0}) AS QChitiet LEFT JOIN PhanLoaiVattu ON QChitiet.PLCha3=PhanLoaiVattu.MaSo ", QChitiet)
            Dim QLuyKe As String = String.Format("SELECT QDuPhong.*,PhanLoaiVattu.SoHieu AS SHPL1,TenPhanLoai AS TenPL1 FROM ({0}) AS QDuPhong LEFT JOIN PhanLoaiVattu ON QDuPhong.PLCha2=PhanLoaiVattu.MaSo {1} ORDER BY QDuPhong.Sohieu", _
                                       QDuPhong, _
                                       (IIf(mpl > 0, String.Format("WHERE PhanLoaiVattu.MaSo={0} OR MPL3={1} OR MPL2={1}", _
                                                         mpl, _
                                                         mpl), String.Empty)))
            'SetSQL("QLuyKe", sql)
            rptFrom.InitForm("DDVT.RPT", QLuyKe, "QLuyKe")
            rptFrom.ReportWindowTitle = "Bảng danh điểm vật tư, hàng hoá"
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mct"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function KtraCTNhap(ByRef mct As Integer) As Boolean
        Dim result As Boolean = True
        Dim T As Double = 0, t2 As Double = 0
        Try
            Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT ThangCT,MaKho,MaTKNo,MaVattu FROM ChungTu WHERE (MaLoai=13 OR MaLoai=1) AND MaVattu>0 AND MaCT={0}", mct))
            For Each rsItem As DataRow In rs.Rows
                If SoTonKho(rsItem("ThangCT"), rsItem("MaKho"), rsItem("MaTkNo"), rsItem("MaVattu"), T, t2) <= 0 Then
                    result = False
                    Exit For
                End If
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return result
        End Try
        
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="shvt"></param>
    ''' <param name="tkno"></param>
    ''' <param name="ktra"></param>
    ''' <remarks></remarks>
    Public Sub TinhGXK(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef shvt As String, ByRef tkno As String, Optional ByRef ktra As Integer = 0)
        Dim tien As Double = 0, luong As Double = 0
        Dim sql As String = String.Empty
        Dim mv As Integer = 0, mk As Integer = 0, mt As Integer = 0
        Dim n As Date
        Dim tien2 As Double = 0, tienx As Double = 0, luongx As Double = 0, tienx2 As Double = 0
        Dim tmp As Double = 0, tmp2 As Double = 0
        Try
            ExecSQLNonQuery(String.Format("UPDATE Chungtu SET MaTKNo=MaTKCo,MaTKTCNo=MaTKTCCo WHERE chungtu.MaTKCo in ( Select chungtu.MaTKCo from {0}  WHERE MaLoai=4 AND HethongTK.Cap=0 AND HethongTK.Loai=0 AND TK.Loai>0)", ChungTu2TKNC(0)))
            'ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoPS=CAST(CASE WHEN SoPS>=0,0.5,-0.5)+SoPS), SoPS2Co=CAST(CASE WHEN SoPS2Co>=0 THEN 0.5 ELSE -0.5 END + SoPS2Co*{0} AS INT)/{1}", _
            '                    Mask_N, _
            '                    Mask_N))
            If OutCost > 0 Then Exit Sub
            If tkno.Length > 0 Then
                sql = String.Format("SELECT DISTINCT ChungTu.MaSo,NgayGS,MaCT,MaKho,MaVattu,SoPS,SoPS2Co{0} FROM ({1}) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo WHERE HethongTK.SoHieu LIKE '{2}%' AND (MaLoai=2 OR MaLoai=4) AND MaVattu>0 AND MaTKNo>0 AND TK.TK_ID={3} AND SoPS2Co>0 AND {4}{5} ORDER BY MaKho,MaVattu,NgayGS,ChungTu.MaCT", _
                          (IIf(pGiaUSD > 0, ",PSUSD", String.Empty)), _
                          ChungTu2TKNC(0), _
                          tkno, _
                          ConvertToStrSafe(TKVT_ID), _
                          WThang("ThangCT", tdau, tcuoi), _
                          (IIf(shvt.Length > 0, String.Format(" AND Vattu.SoHieu=N'{0}'", shvt), String.Empty)))
            Else
                sql = String.Format("SELECT DISTINCT ChungTu.MaSo,NgayGS,MaCT,MaKho,MaVattu,SoPS,SoPS2Co{0} FROM ({1}) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo WHERE (MaLoai=2 OR MaLoai=4) AND MaVattu>0 AND HethongTK.TK_ID={2} AND SoPS2Co>0 AND {3}{4} ORDER BY MaKho,MaVattu,NgayGS,ChungTu.MaCT", _
                          (IIf(pGiaUSD > 0, ",PSUSD", String.Empty)), _
                          ChungTu2TKNC(1), _
                          ConvertToStrSafe(TKVT_ID), _
                          WThang("ThangCT", tdau, tcuoi), _
                          (IIf(shvt.Length > 0, String.Format(" AND Vattu.SoHieu=N'{0}'", shvt), String.Empty)))
            End If
            Dim rs As DataTable = ExecSQLReturnDT(sql)
            For Each rsItem As DataRow In rs.Rows
                If mk <> ConvertToDblSafe(rsItem("MaKho")) Or mv <> ConvertToDblSafe(rsItem("MaVattu")) Then
                    n = ConvertToDateSafe(rsItem("NgayGS"))
                    mk = ConvertToDblSafe(rsItem("MaKho"))
                    mv = ConvertToDblSafe(rsItem("MaVattu"))
                    luong = SoTonKhoN(n.AddDays(-1), mk, 0, mv, tien, tien2)
                    luong += SoNhapKhoTrong1Ngay(mk, mt, mv, n, tmp, tmp2)
                    tien += tmp
                    tien2 += tmp2
                Else
                    If n <> ConvertToDateSafe(rsItem("NgayGS")) Then
                        If tkno.Length > 0 Then
                            luong = SoTonKhoN(DateAdd(DateInterval.Day, -1, ConvertToDateSafe(rsItem("NgayGS"))), _
                                        mk, _
                                        0, _
                                        mv, _
                                        tien, _
                                        tien2)
                        Else
                            luong += SoNhapKhoNgay(mk, mt, mv, n, rsItem("NgayGS"), tienx, tienx2)
                            tien += tienx
                            tien2 += tienx2
                        End If
                        n = rsItem("NgayGS")
                    End If
                End If
                If tien = 0 Then
                    tienx = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 SoPS AS F1,SoPS2Co AS F2 FROM ChungTu WHERE (MaLoai=2 OR MaLoai=4) AND MaKho={0} AND MaVattu={1} AND NgayGS<=N'{2}' AND MaCT<{3} AND SoPS<>0 AND SoPS2Co<>0 ORDER BY NgayGS DESC, MaCT DESC", _
                                                                mk, _
                                                                mv, _
                                                                Format(n, Mask_DB), _
                                                                rsItem("MaCT")), luongx))
                    If tienx = 0 Then
                        tienx = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 SoPS AS F1,SoPS2No AS F2 FROM ChungTu WHERE (((MaLoai=13 OR MaLoai=1) AND MaKho={0}) OR (MaLoai=4 AND MaNguon={1})) AND MaVattu={2} AND NgayGS>'{3}' AND SoPS<>0 AND SoPS2No<>0 ORDER BY NgayGS", _
                                                                    mk, _
                                                                    mk, _
                                                                    mv, _
                                                                    Format(n, Mask_DB)), luongx))
                    End If
                    If luongx <> 0 And luongx <> ConvertToDblSafe(rsItem("SoPS2Co")) Then tienx = RoundMoney(tienx * ConvertToDblSafe(rsItem("SoPS2Co")) / luongx)
                Else
                    luong = (IIf((IIf(luong >= 0, 0.5, -0.5)) + luong * Mask_N > 0, Math.Floor((IIf(luong >= 0, 0.5, -0.5)) + luong * Mask_N), Math.Ceiling((IIf(luong >= 0, 0.5, -0.5)) + luong * Mask_N))) / Mask_N
                    tienx = IIf(luong <> 0 And luong <> ConvertToDblSafe(rsItem("SoPS2Co")), RoundMoney(tien * ConvertToDblSafe(rsItem("SoPS2Co")) / luong), tien)
                End If
                tienx = Math.Abs(tienx)
                If tkno.Length = 0 Then
                    luong -= ConvertToDblSafe(rsItem("SoPS2Co"))
                    tien -= tienx
                End If
                If tienx <> ConvertToDblSafe(rsItem("sops")) Then ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoPS={0} WHERE MaSo={1}", CStr(tienx), rsItem("MaSo")))
                If pGiaUSD > 0 Then
                    If tien2 = 0 Then
                        tienx2 = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 PSUSD AS F1,SoPS2Co AS F2 FROM ChungTu WHERE (MaLoai=2 OR MaLoai=4) AND MaKho={0} AND MaVattu={1} AND NgayGS<=N'{2}' AND MaCT<{3} AND SoPS<>0 AND SoPS2Co<>0 ORDER BY NgayGS DESC, MaCT DESC", _
                                                                     mk, _
                                                                     mv, _
                                                                     Format(n, Mask_DB), _
                                                                     rsItem("MaCT")), luongx))
                        If tienx2 = 0 Then
                            tienx2 = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 PSUSD AS F1,SoPS2No AS F2 FROM ChungTu WHERE (((MaLoai=13 OR MaLoai=1) AND MaKho={0}) OR (MaLoai=4 AND MaNguon={1})) AND MaVattu={2} AND NgayGS>'{3}' AND SoPS<>0 AND SoPS2No<>0 ORDER BY NgayGS", _
                                                                         mk, _
                                                                         mk, _
                                                                         mv, _
                                                                         Format(CDate(n), Mask_DB)), luongx))
                        End If
                        If luongx <> 0 And luongx <> ConvertToDblSafe(rsItem("SoPS2Co")) Then tienx2 = (IIf(0.5 + Mask_N * tienx2 * ConvertToDblSafe(rsItem("SoPS2Co")) / luongx > 0, Math.Floor(0.5 + Mask_N * tienx2 * ConvertToDblSafe(rsItem("SoPS2Co")) / luongx), Math.Ceiling(0.5 + Mask_N * tienx2 * ConvertToDblSafe(rsItem("SoPS2Co")) / luongx))) / Mask_N
                    Else
                        luong = (IIf((IIf(luong >= 0, 0.5, -0.5)) + luong * Mask_N > 0, Math.Floor((IIf(luong >= 0, 0.5, -0.5)) + luong * Mask_N), Math.Ceiling((IIf(luong >= 0, 0.5, -0.5)) + luong * Mask_N))) / Mask_N
                        tienx2 = IIf(luong <> 0 And luong <> ConvertToDblSafe(rsItem("SoPS2Co")), (IIf(0.5 + Mask_N * tien2 * ConvertToDblSafe(rsItem("SoPS2Co")) / luong > 0, Math.Floor(0.5 + Mask_N * tien2 * ConvertToDblSafe(rsItem("SoPS2Co")) / luong), Math.Ceiling(0.5 + Mask_N * tien2 * ConvertToDblSafe(rsItem("SoPS2Co")) / luong))) / Mask_N, tien2)
                    End If
                    tienx2 = Math.Abs(tienx2)
                    If tkno.Length = 0 Then
                        luong -= ConvertToDblSafe(rsItem("SoPS2Co"))
                        tien2 -= tienx2
                    End If
                    If tienx2 <> rsItem("PSUSD") Then ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoPS={0} WHERE MaSo={1}", _
                                                                          doidau(tienx2), _
                                                                          rsItem("MaSo")))
                End If
            Next
            If mv > 0 And ktra = 0 Then
                KiemTraTaiKhoan(1)
                KiemTraVatTu(1)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <remarks></remarks>
    Public Sub TinhGNT(ByRef thang As Integer)
        Dim dongia As Double = 0, tien As Double = 0
        Dim tien515 As Double = 0, lech As Double = 0, tien635 As Double = 0, tienam As Double = 0
        Dim masoam As Integer = 0, madoino As Integer = 0, madoico As Integer = 0
        Try
            If ConvertToDblSafe(GetSelectValue("SELECT count(*) AS f1 FROM hethongtk WHERE sohieu='5152' OR sohieu='6352'")) < 2 Then
                myUMessager.mInformation(Ngonngu("Thiếu tài khoản 5152 hoặc 6352", "Missing account '5152' or '6352'"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            'Lamlai:
            Dim sql As String = String.Format("SELECT DISTINCT chungtu.makh,chungtu.matkco,chungtu.mact,Hethongtk.sohieu,hethongtk.mant,ChungTu.MaSo,NgayGS,SoPS,SoPS2No,SoPS2Co{0} FROM {1} WHERE MaLoai=0 AND MaVattu=0 AND Mant>0 AND SoPS2Co>0 AND ThangCT={2} ORDER BY NgayGS,ChungTu.MaCT", _
                                    (IIf(pGiaUSD > 0, ",PSUSD", String.Empty)), _
                                    ChungTu2TKNC(1), _
                                    thang)
            Dim rs As DataTable = ExecSQLReturnDT(sql)
            For Each rsItem As DataRow In rs.Rows
                '            '********************* Tính giá xuất bình quân di động *******************
                dongia = TyGiaBQNTDD(rsItem("SoHieu"), ConvertToDblSafe(rsItem("MaNT")), ConvertToDateSafe(rsItem("NgayGS")))
                tien = ConvertToDblSafe(rsItem("SoPS2Co")) * dongia
                lech = tien - ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(sops) AS f1 FROM chungtu WHERE mact={0} AND matkco={1}", _
                                                                  rsItem("MaCT"), _
                                                                  rsItem("MaTkCo"))))
                If lech <> 0 Then
                    tien635 = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sops AS f1 FROM {0} WHERE mact={1} AND LEFT(hethongtk.sohieu,3) = '635'", _
                                                                  ChungTu2TKNC(-1), _
                                                                  rsItem("MaCT"))))
                    tien515 = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sops AS f1 FROM {0} WHERE mact={1} AND LEFT(hethongtk.sohieu,3) = '515'", _
                                                                  ChungTu2TKNC(1), _
                                                                  rsItem("MaCT"))))
                    If tien635 <> 0 Then
                        ExecSQLNonQuery(String.Format("UPDATE {0} SET sops=[sops]+{1} WHERE mact={2} AND LEFT(hethongtk.sohieu,3) = '635'", _
                                            ChungTu2TKNC(-1), _
                                            lech, _
                                            rsItem("MaCT")))
                        tienam = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sops AS f1,chungtu.maso AS f2 FROM {0} WHERE mact={1} AND LEFT(hethongtk.sohieu,3) = '635'", _
                                                                     ChungTu2TKNC(-1), _
                                                                     rsItem("MaCT")), masoam))
                        If tienam < 0 Then
                            madoico = ConvertToDblSafe(GetSelectValue("SELECT maso AS f1 FROM hethongtk WHERE sohieu LIKE '5152%' AND cap>=all(SELECT cap FROM hethongtk WHERE sohieu LIKE '5152' OR sohieu LIKE '51521' OR sohieu LIKE '515211')"))
                            madoino = ConvertToDblSafe(GetSelectValue(String.Format("SELECT matkno AS f1 FROM {0} WHERE LEFT(hethongtk.sohieu,3) <> '635' AND mact={1}", ChungTu2TKNC(-1), rsItem("MaCT"))))
                            ExecSQLNonQuery(String.Format("UPDATE chungtu SET sops={0},matkco={1},matktcco={1},matkno={2},matktcno={2},makh={3} WHERE maso={4}", _
                                                Math.Abs(tienam), _
                                                madoico, _
                                                madoino, _
                                                rsItem("makh"), _
                                                ConvertToStrSafe(masoam)))
                            ExecSQLNonQuery(String.Format("UPDATE chungtu SET sops={0} WHERE maso={1}", _
                                                doidau(tien), _
                                                rsItem("MaSo")))
                        End If
                    Else
                        If tien515 <> 0 Then
                            ExecSQLNonQuery(String.Format("UPDATE {0} SET sops=[sops]-{1} WHERE mact={2} AND LEFT(hethongtk.sohieu,3) = '515'", _
                                                ChungTu2TKNC(1), _
                                                lech, _
                                                rsItem("MaCT")))
                            tienam = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sops AS f1,chungtu.maso AS f2 FROM {0} WHERE mact={1} AND LEFT(hethongtk.sohieu,3) = '515'", _
                                                                         ChungTu2TKNC(1), _
                                                                         rsItem("MaCT")), masoam))
                            If tienam < 0 Then
                                madoico = rsItem("MaTkCo")
                                madoino = ConvertToDblSafe((GetSelectValue("SELECT maso AS f1 FROM hethongtk WHERE sohieu LIKE '6352%' AND cap>=all(SELECT cap FROM hethongtk WHERE sohieu LIKE '6352' OR sohieu LIKE '63521' OR sohieu LIKE '635211')")))
                                ExecSQLNonQuery(String.Format("UPDATE chungtu SET sops={0},matkco={1},matktcco={1},matkno={2},matktcno={2} WHERE maso={3}", _
                                                    Math.Abs(tienam), _
                                                    madoico, _
                                                    madoino, _
                                                    masoam))
                                ExecSQLNonQuery(String.Format("UPDATE chungtu SET sops={0} WHERE maso={1}", _
                                                    doidau(tien + tienam), _
                                                    rsItem("MaSo")))
                            Else
                                ExecSQLNonQuery(String.Format("UPDATE chungtu SET sops={0} WHERE maso={1}", _
                                                    doidau(tien), _
                                                    rsItem("MaSo")))
                            End If
                        Else
                            ExecSQLNonQuery(String.Format("UPDATE chungtu SET sops={0} WHERE maso={1}", _
                                                doidau(tien), _
                                                rsItem("MaSo")))
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    'Function TyGiaBQNTCK(shtk AS String, mnt AS Long, ngay AS Date) AS Double
    '    Dim mtk AS Long, duno AS Double, duco AS Double, dunt AS Double, soluong AS Double, ngaycuoithangtruoc AS Date
    '
    '    mtk = GetSelectValue("SELECT MaSo AS F1 FROM HethongTK WHERE SoHieu='" + shtk + "' AND MaNT=" + ConvertToStrSafe(mnt))
    '    If mtk > 0 Then
    '        ngaycuoithangtruoc = NgayCuoiThang(Year(ngay), Month(ngay) - 1)
    '        SoDuTKNgay mtk, ngaycuoithangtruoc, duno, duco, dunt
    '        duno = duno + GetSelectValue("SELECT sum(sops)AS f1,sum(sops2no)AS f2 FROM " + ChungTu2TKNC(-1) + " WHERE HethongTK.SoHieu LIKE '" + shtk + "%' AND MaLoai=0 AND MaVattu=0 " + iif(mnt <> 0, " AND Mant=" + ConvertToStrSafe(mnt), " AND Mant>0") + " AND NgayGS > '" + Format(ngaycuoithangtruoc, Mask_DB) + "' AND NgayGS <= #" + Format(cdate(Ngay), Mask_DB) + "#", soluong)
    '        dunt = dunt + soluong
    '        If dunt <> 0 Then TyGiaBQNTCK = Abs((duno - duco) / dunt)
    '    End If
    'End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="shtk"></param>
    ''' <param name="mnt"></param>
    ''' <param name="Ngay"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function TyGiaBQNTDD(ByRef shtk As String, ByRef mnt As Integer, ByRef Ngay As Date) As Double
        Dim result As Double = 0
        Dim dunt As Double = 0, duno As Double = 0, duco As Double = 0, soluong As Double = 0
        Dim ngaycuoithangtruoc As Date
        Try
            Dim mtk As Integer = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM HethongTK WHERE SoHieu=N'{0}' AND MaNT={1}", _
                                                                 shtk, _
                                                                 mnt)))
            If mtk > 0 Then
                ngaycuoithangtruoc = NgayCuoiThang(Ngay.Year, Ngay.Month - 1)
                SoDuTKNgay(mtk, ngaycuoithangtruoc, duno, duco, dunt)
                '****************** Cộng nhập *****************************************
                duno += ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(sops)AS f1,sum(sops2no)AS f2 FROM {0} WHERE HethongTK.SoHieu LIKE '{1}%' AND MaLoai=0 AND MaVattu=0 {2} AND (NgayGS > '{3}' AND NgayGS <=N'{4}')", _
                                                            ChungTu2TKNC(-1), _
                                                            shtk, _
                                                            (IIf(mnt <> 0, String.Format(" AND Mant={0}", mnt), " AND Mant>0")), _
                                                            Format(ngaycuoithangtruoc, Mask_DB), _
                                                            Format(CDate(Ngay), Mask_DB)), soluong))
                dunt += soluong
                '****************** Trừ Xuất *****************************************
                duno = ConvertToDblSafe(duno - ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(sops)AS f1,sum(sops2co)AS f2 FROM {0} WHERE HethongTK.SoHieu LIKE '{1}%' AND MaLoai=0 AND MaVattu=0 {2} AND (NgayGS > '{3}' AND NgayGS <'{4}')", _
                                                                       ChungTu2TKNC(1), _
                                                                       shtk, _
                                                                       (IIf(mnt <> 0, String.Format(" AND Mant={0}", mnt), " AND Mant>0")), _
                                                                       Format(ngaycuoithangtruoc, Mask_DB), _
                                                                       Format(CDate(Ngay), Mask_DB)), soluong)))
                dunt -= soluong
                If dunt <> 0 Then result = Math.Abs((duno - duco) / dunt)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return result
        End Try        
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Ngay"></param>
    ''' <param name="mkho"></param>
    ''' <param name="mtk"></param>
    ''' <param name="mvt"></param>
    ''' <param name="ThanhTien"></param>
    ''' <param name="mct"></param>
    ''' <param name="tien2"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function SoTonKhoN2(ByRef Ngay As Date, _
        ByRef mkho As Integer, _
        ByRef mtk As Integer, _
        ByRef mvt As Integer, _
        ByRef ThanhTien As Double, _
        ByRef mct As Integer, _
        ByRef tien2 As Double) As Double
        Dim result As Double = 0
        Dim luong As Double = 0, X As Double = 0
        Try
            result = SoTonKho(0, mkho, mtk, mvt, ThanhTien, tien2)
            Dim sql As String = String.Format("SELECT Sum(SoPS) AS F1,Sum(SoPS2No) AS F2{0} FROM ChungTu WHERE MaVattu={1} AND ((MaLoai=13 OR MaLoai=1){2} AND NgayGS<=N'{3}' AND MaCT<{4}", _
                                    (IIf(pGiaUSD > 0, ",Sum(PSUSD) AS F3", String.Empty)), _
                                    ConvertToStrSafe(mvt), _
                                    (IIf(mkho > 0, " OR MaLoai=4)", ")")), _
                                    Format(CDate(Ngay), Mask_DB), _
                                    ConvertToStrSafe(mct))
            If mkho > 0 Then sql = String.Format("{0} AND ((MaKho={1} AND (MaLoai=1 OR MaLoai=13)) OR (MaNguon={1} AND MaLoai=4))", _
                                       sql, _
                                       ConvertToStrSafe(mkho))
            If mtk > 0 Then sql = String.Format("{0} AND MaTKNo={1}", sql, ConvertToStrSafe(mtk))
            ThanhTien += ConvertToDblSafe(GetSelectValue(sql, luong, tien2))
            result += luong
            sql = String.Format("SELECT Sum(SoPS) AS F1,Sum(SoPS2Co) AS F2{0} FROM ChungTu WHERE MaVattu={1} AND (MaLoai=2{2} AND NgayGS<'{3}' AND MaCT<{4}", _
                      (IIf(pGiaUSD > 0, ",Sum(PSUSD) AS F3", String.Empty)), _
                      ConvertToStrSafe(mvt), _
                      (IIf(mkho > 0, " OR MaLoai=4)", ")")), _
                      Format(CDate(Ngay), Mask_DB), _
                      ConvertToStrSafe(mct))
            If mkho > 0 Then sql = String.Format("{0} AND (MaKho={1})", sql, mkho)
            If mtk > 0 Then sql = String.Format("{0} AND MaTKCo={1}", sql, mtk)
            ThanhTien = ThanhTien - ConvertToDblSafe(GetSelectValue(sql, luong, X))
            tien2 -= X
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return result - luong
        End Try
        
        Return result - luong
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="f"></param>
    ''' <param name="m"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoCPPB(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef f As String, ByRef m As Integer) As Double
        Dim sql As String = String.Empty
        Try
            For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
                sql = String.Format("{0}+{1}{2}", sql, f, i)
            Next
            sql = String.Format("SELECT Sum({0}) AS F1 FROM TP154", sql)
            If m > 0 Then sql = String.Format("{0} WHERE MaSo={1}", sql, m)
            Return ConvertToDblSafe(GetSelectValue(sql))
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mkho"></param>
    ''' <param name="mtk"></param>
    ''' <param name="mvt"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="tien"></param>
    ''' <param name="tien2"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function SoNhapKho(ByRef mkho As Integer, ByRef mtk As Integer, ByRef mvt As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef tien As Double, ByRef tien2 As Double) As Double
        Dim luong As Double = 0
        Try
            Dim sql As String = String.Format("SELECT Sum(SoPS) AS F1,Sum(SoPS2No) AS F2{0} FROM ChungTu WHERE MaVattu={1} AND ((MaLoai=13 OR MaLoai=1){2} AND {3}", _
                                (IIf(pGiaUSD > 0, ",Sum(PSUSD) AS F3", String.Empty)), _
                                ConvertToStrSafe(mvt), _
                                (IIf(mkho > 0, " OR MaLoai=4)", ")")), _
                                WNgay("NgayGS", ndau, ncuoi))
            If mkho > 0 Then sql = String.Format("{0} AND ((MaKho={1} AND (MaLoai=13 OR MaLoai=1)) OR (MaNguon={1} AND MaLoai=4))", _
                                       sql, _
                                       ConvertToStrSafe(mkho))
            If mtk > 0 Then sql = String.Format("{0} AND MaTKNo={1}", _
                                      sql, _
                                      ConvertToStrSafe(mtk))
            tien = ConvertToDblSafe(GetSelectValue(sql, luong, tien2))
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return luong
        End Try        
        Return luong
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mkho"></param>
    ''' <param name="mtk"></param>
    ''' <param name="mvt"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="tien"></param>
    ''' <param name="tien2"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function SoNhapKhoNgay(ByRef mkho As Integer, ByRef mtk As Integer, ByRef mvt As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef tien As Double, ByRef tien2 As Double) As Double
        Dim luong As Double = 0
        Try
            Dim sql As String = String.Format("SELECT Sum(SoPS) AS F1,Sum(SoPS2No) AS F2{0} FROM ChungTu inner join hethongtk on chungtu.matkno=hethongtk.maso WHERE LEFT(hethongtk.sohieu,2)='15' AND MaVattu={1} AND (MaLoai=13 OR MaLoai=1{2} AND NgayGS>'{3}' AND NgayGS<=N'{4}'", _
                                (IIf(pGiaUSD > 0, ",Sum(PSUSD) AS F3", String.Empty)), _
                                mvt, _
                                (IIf(mkho > 0, " OR MaLoai=4)", ")")), _
                                Format(ndau, Mask_DB), _
                                Format(ncuoi, Mask_DB))
            If mkho > 0 Then sql = String.Format("{0} AND ((MaKho={1} AND (MaLoai=13 OR MaLoai=1)) OR (MaNguon={1} AND MaLoai=4))", _
                                       sql, _
                                       mkho)
            If mtk > 0 Then sql = String.Format("{0} AND MaTKNo={1}", _
                                      sql, _
                                      mtk)
            tien = ConvertToDblSafe(GetSelectValue(sql, luong, tien2))
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return luong
        End Try
        
        Return luong
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mkho"></param>
    ''' <param name="mtk"></param>
    ''' <param name="mvt"></param>
    ''' <param name="Ngay"></param>
    ''' <param name="tien"></param>
    ''' <param name="tien2"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function SoNhapKhoTrong1Ngay(ByRef mkho As Integer, _
        ByRef mtk As Integer, _
        ByRef mvt As Integer, _
        ByRef Ngay As Date, _
        ByRef tien As Double, _
        ByRef tien2 As Object) As Double
        Dim luong As Double = 0
        Try
            Dim sql As String = String.Format("SELECT Sum(SoPS) AS F1,Sum(SoPS2No) AS F2{0} FROM ChungTu inner join hethongtk on chungtu.matkno=hethongtk.maso WHERE LEFT(hethongtk.sohieu,2)='15' AND  MaVattu={1} AND ((MaLoai=13 OR MaLoai=1){2} AND NgayGS=N'{3}'", _
                                (IIf(pGiaUSD > 0, ",Sum(PSUSD) AS F3", String.Empty)), _
                                mvt, _
                                (IIf(mkho > 0, " OR MaLoai=4)", ")")), _
                                Format(CDate(Ngay), Mask_DB))
            If mkho > 0 Then sql = String.Format("{0} AND ((MaKho={1} AND (MaLoai=13 OR MaLoai=1)) OR (MaNguon={1} AND MaLoai=4))", _
                                       sql, _
                                       mkho)
            If mtk > 0 Then sql = String.Format("{0} AND MaTKNo={1}", _
                                      sql, _
                                      mtk)
            tien = ConvertToDblSafe(GetSelectValue(sql, luong, tien2))
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return luong
        End Try
        
        Return luong
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mkho"></param>
    ''' <param name="mtk"></param>
    ''' <param name="mvt"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="tien"></param>
    ''' <param name="tien2"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoNhapKhoThang(ByRef mkho As Integer, ByRef mtk As Integer, ByRef mvt As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef tien As Double, ByRef tien2 As Double) As Double
        Dim luong As Double = 0
        Try
            Dim sql As String = String.Format("SELECT Sum(SoPS) AS F1,Sum(SoPS2No) AS F2{0} FROM ChungTu WHERE MaVattu={1} AND (MaLoai=13 OR MaLoai=1{2} AND {3}", _
                                (IIf(pGiaUSD > 0, ",Sum(PSUSD) AS F3", String.Empty)), _
                                mvt, _
                                (IIf(mkho > 0, " OR MaLoai=4)", ")")), _
                                WThang("ThangCT", tdau, tcuoi))
            If mkho > 0 Then sql = String.Format("{0} AND ((MaKho={1} AND (MaLoai=1 OR MaLoai=13)) OR (MaNguon={1} AND MaLoai=4))", _
                                       sql, _
                                       mkho)
            If mtk > 0 Then sql = String.Format("{0} AND MaTKNo={1}", _
                                      sql, _
                                      mtk)
            tien = ConvertToDblSafe(GetSelectValue(sql, luong, tien2))
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return luong
        End Try
        
        Return luong
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mvt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DinhMucNC(ByRef mvt As Integer) As Double
        Try
            Return ConvertToDblSafe(GetSelectValue(String.Format("SELECT DinhMuc.Soluong AS F1 FROM DinhMuc WHERE DinhMuc.MaTP={0} AND MaNVL=0", mvt)))
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return 0
        End Try
        Return 0
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mvt"></param>
    ''' <param name="dvt"></param>
    ''' <param name="soluong"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function QuyDoiTheoDVT1(ByRef mvt As Integer, ByRef dvt As Integer, ByRef soluong As Double) As Double
        Dim TyLe As Double = 0
        Try
            If dvt = 0 Then
                Return soluong
            Else
                TyLe = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TyLeQD AS F1 FROM DVTVattu WHERE MaSo={0} AND MaVattu={1}", _
                                                           dvt, _
                                                           mvt)))
                If TyLe = 0 Then
                    Return soluong
                Else
                    Return (IIf(0.5 + Mask_N * soluong * TyLe > 0, Math.Floor(0.5 + Mask_N * soluong * TyLe), Math.Ceiling(0.5 + Mask_N * soluong * TyLe))) / Mask_N
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return soluong
        End Try
        Return soluong
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mvt"></param>
    ''' <param name="dvt"></param>
    ''' <param name="soluong"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function QuyDoiTheoDVT2(ByRef mvt As Integer, ByRef dvt As Integer, ByRef soluong As Double) As Double
        Dim TyLe As Double = 0
        Try
            If dvt = 0 Then
                Return soluong
            Else
                TyLe = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TyLeQD AS F1 FROM DVTVattu WHERE MaSo={0} AND MaVattu={1}", _
                                                           dvt, _
                                                           mvt)))
                If TyLe = 0 Then
                    Return soluong
                Else
                    Return (IIf(0.5 + Mask_N * soluong / TyLe > 0, Math.Floor(0.5 + Mask_N * soluong / TyLe), Math.Ceiling(0.5 + Mask_N * soluong / TyLe))) / Mask_N
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return soluong
        End Try
        Return soluong
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="TL"></param>
    ''' <param name="mvt"></param>
    ''' <param name="ktra"></param>
    ''' <remarks></remarks>
    Public Sub TinhGVBH(ByRef ndau As Date, _
        ByRef ncuoi As Date, _
        ByRef TL As Integer, _
        ByRef mvt As Integer, _
        Optional ByRef ktra As Integer = 0)
        Dim ct As New ClsChungtu
        Dim rs_ktra As DataTable
        Dim m, m1 As Integer
        Dim c As Integer
        Dim luong() As Double = {}, tien() As Double = {}
        Dim id() As Integer = {}
        Dim tien2() As Double = {}
        Try
            If OutCost <> 1 Then
                ExecSQLNonQuery(String.Format("UPDATE VTDauNam SET VTDauNam.SoXuat=0 WHERE (True) {0}", (IIf(mvt > 0, String.Format(" AND VTDauNam.MaVattu={0}", mvt), String.Empty))))
                ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoXuat=0 WHERE (True) {0}", (IIf(mvt > 0, String.Format(" AND MaVattu={0}", mvt), String.Empty))))
                'ExecSQLNonQuery(String.Format("DELETE FROM ChungTu WHERE MaLoai=2 AND RIGHT(SoHieu,2)='GV' AND SoPS=0 AND {0}{1}", _
                '                    WNgay("NgayGS", ndau, ncuoi), _
                '                    (IIf(mvt > 0, String.Format(" AND MaVattu={0}", mvt), String.Empty))))
                'If TL = System.Windows.Forms.DialogResult.Yes Then
                ExecSQLNonQuery(String.Format("DELETE FROM ChungTu WHERE MaLoai=2 AND RIGHT(SoHieu,2)='GV' AND {0}{1}", _
                                    WNgay("NgayGS", ndau, ncuoi), _
                                    (IIf(mvt > 0, String.Format(" AND MaVattu={0}", mvt), String.Empty))))
                'End If
                Dim Mientru As String = String.Format("SELECT DISTINCT ChungTu.MaSo,ChungTu.MaCT,ChungTu.NgayGS,ChungTu.SoHieu,ChungTu.MaKho,ChungTu.SoPS2Co,ChungTu.MaVattu,ChungTu.ThangCT FROM {0} WHERE (ChungTu.MaLoai=8 OR ChungTu.MaLoai=4 OR (ChungTu.MaLoai=2 AND RIGHT(ChungTu.SoHieu,2)<>'GV')) AND ChungTu.MaVattu>0 AND (TK_ID={1} OR ChungTu.MaLoai<>8) AND (Not HethongTK.SoHieu LIKE '5113%') AND {2}{3} ORDER BY ChungTu.NgayCT,ChungTu.MaCT", _
                                          ChungTu2TKNC(1), _
                                          TKDT_ID, _
                                          WNgay("ChungTu.NgayGS", ndau, ncuoi), _
                                          (IIf(mvt > 0, String.Format(" AND ChungTu.MaVattu={0}", mvt), String.Empty)))
                rs_ktra = ExecSQLReturnDT(Mientru)
                For Each rs_ktraItem As DataRow In rs_ktra.Rows
                    m1 = 0
                    ct.InitChungtu(rs_ktraItem("MaSo"), _
                        0, _
                        String.Empty, _
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
                        String.Empty, _
                        0, DateTime.Today)
                    If ct.maloai = 8 Then
                        If ct.sops = 0 Then
                            m1 = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaTK AS F1 FROM KhoHang WHERE MaSo={0}", ct.MaKho)))
                            If m1 > 0 Then ct.tkno.InitTaikhoanMaSo(m1)
                        End If
                        If m1 = 0 Then
                            m1 = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaTKGV AS F1 FROM KhoHang WHERE MaSo={0}", ct.MaKho)))
                            If m1 > 0 Then ct.tkno.InitTaikhoanMaSo(m1)
                        End If
                        If m1 = 0 Then ct.tkno.InitTaikhoanMaSo(ConvertToDblSafe(GetSelectValue("SELECT TOP 1 MaSo AS F1 FROM HethongTK WHERE SoHieu LIKE '632%' AND TKCon=0 ORDER BY SoHieu")))
                        If ct.tkno.maso = 0 Then Continue For
                        ct.SoHieu = String.Format("{0}GV", ct.SoHieu)
                        ct.maloai = 2
                        If CTGS_GV > 0 Then ct.CTGS = CTGS_GV
                        ct.User_ID = 0
                        ct.CT_ID = ConvertToDblSafe(500000000 + ConvertToDblSafe(rs_ktraItem("MaSo")))
                        If m <> ConvertToDblSafe(rs_ktraItem("MaCT")) Then
                            m = ConvertToDblSafe(rs_ktraItem("MaCT"))
                            m1 = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 MaCT AS F1 FROM ChungTu WHERE MaLoai=2 AND SoHieu=N'{0}'+'GV' AND NgayGS=N'{1}' ", _
                                                                     rs_ktraItem("SoHieu"), _
                                                                     Format(rs_ktraItem("NgayGS"), Mask_DB))))
                            If m1 = 0 Then m1 = Lng_MaxValue("MaCT", "ChungTu") + 1
                        End If
                        ct.MaCT = m1
                        m = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaTaiKhoan AS F1 FROM TonKho WHERE MaSoKho={0} AND MaVattu={1} AND Luong_{2}>0", _
                                                                ct.MaKho, _
                                                                ct.MaVattu, _
                                                                ct.thangct)))
                        If m = 0 Then m = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaTK AS F1 FROM PhanLoaiVattu INNER JOIN Vattu ON PhanLoaiVattu.MaSo=Vattu.MaPhanLoai WHERE Vattu.MaSo={0}", ct.MaVattu)))
                        ct.TkCo.InitTaikhoanMaSo(m)
                        If ct.TkCo.maso = 0 Then Continue For
                    Else
                        ExecSQLNonQuery(String.Format("DELETE FROM ChungTu WHERE MaSo={0}", ct.MaSo))
                    End If
                    Select Case OutCost
                        Case 0 : ct.sops = GiaXuatKho(ct.MaKho, ct.TkCo.maso, ct.MaVattu, ct.NgayGS, ct.SoPS2Co, ct.PSUSD)
                        Case 2 : c = GiaXuatKhoFIFO(ct.MaKho, ct.TkCo.maso, ct.MaVattu, ct.SoPS2Co, luong, tien, id, tien2)
                        Case 3 : c = GiaXuatKhoLIFO(ct.MaKho, ct.TkCo.maso, ct.MaVattu, ct.SoPS2Co, luong, tien, id, tien2)
                    End Select
                    If OutCost = 0 Then
                        ct.GhiChungtuTH(0, 1)
                    Else
                        For i As Integer = 1 To c
                            ct.SoPS2Co = luong(i)
                            ct.sops = tien(i)
                            If pGiaUSD > 0 Then ct.PSUSD = tien2(i)
                            ct.CT_ID = id(i)
                            ct.GhiChungtuTH(0, 1)
                        Next
                    End If
                Next
                If rs_ktra.Rows.Count > 0 And ktra = 0 Then
                    KiemTraTaiKhoan(1)
                    KiemTraVatTu(1)
                End If
            End If
            Erase luong
            Erase tien
            Erase tien2
            Erase id
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="TL"></param>
    ''' <param name="mvt"></param>
    ''' <param name="loai"></param>
    ''' <remarks></remarks>
    Public Sub TinhGVBHBQ(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef TL As Integer, ByRef mvt As Integer, ByRef loai As Integer)
        Dim m1 As Integer = 0, n1 As Integer = 0
        Dim sql As String = String.Empty
        Try
            If OutCost = 0 Then
                'ExecSQLNonQuery(String.Format("DELETE FROM ChungTu WHERE MaLoai=2 AND RIGHT(SoHieu,2)='GV' AND SoPS=0 AND {0}{1}", _
                '                    WThang("ThangCT", tdau, tcuoi), _
                '                    (IIf(mvt > 0, String.Format(" AND MaVattu={0}", mvt), String.Empty))))
                'If TL = System.Windows.Forms.DialogResult.Yes Then
                ExecSQLNonQuery(String.Format("DELETE FROM ChungTu WHERE MaLoai=2 AND RIGHT(SoHieu,2)='GV' AND {0}{1}", _
                                    WThang("ThangCT", tdau, tcuoi), _
                                    (IIf(mvt > 0, String.Format(" AND MaVattu={0}", mvt), String.Empty))))
                'End If
                m1 = ConvertToDblSafe(GetSelectValue("SELECT TOP 1 MaSo AS F1 FROM HethongTK WHERE SoHieu LIKE '632%' AND TKCon=0 ORDER BY SoHieu"))
                n1 = ConvertToDblSafe(GetSelectValue("SELECT TOP 1 MaSo AS F1 FROM HethongTK WHERE SoHieu LIKE '1561%' AND TKCon=0 ORDER BY SoHieu"))
                sql = String.Format("INSERT INTO Chungtu (MaCT, MaLoai, SoHieu, ThangCT, NgayCT, NgayGS, MaNguon, MaKho, DienGiai,{0}MaTkNo, MaTkCo, SoPS, SoPS2No, SoPS2Co,MaTKTCNo,MaTKTCCo, MaVattu, GhiChu, CT_ID, MaDT, MaDT1, MaDT2, MaDT3,MaKH,CTGS,MaKHC,MaTP,DVT,[User_ID],MaNV,HanTT,SH1,T1,TLCK,CK{1}{2}) SELECT DISTINCT (1000000+MaCT) as MaCT,2 as MaLoai,(ChungTu.SoHieu+'GV') as SoHieu,ThangCT,NgayCT,NgayGS,MaNguon,MaKho,DienGiai,{0} CASE WHEN(KhoHang.MaTKGV=0) THEN {3} ELSE KhoHang.MaTKGV END as MaTkNo, CASE WHEN(PhanLoaiVattu.MaTK=0) THEN {4} ELSE PhanLoaiVattu.MaTK END as MaTkCo, SoPS, SoPS2No, SoPS2Co,MaTKTCNo,MaTKTCCo, MaVattu, ChungTu.GhiChu, (ChungTu.MaSo+500000000) as CT_ID, MaDT, MaDT1, MaDT2, MaDT3,MaKH,CTGS,MaKHC,MaTP,DVT,[User_ID],MaNV,HanTT,SH1,T1,TLCK,ChungTu.CK{1}{2} FROM ((({5}) INNER JOIN KhoHang ON ChungTu.MaKho=KhoHang.MaSo) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN PhanLoaiVattu ON Vattu.MaPhanLoai=PhanLoaiVattu.MaSo WHERE MaLoai=8 AND MaVattu>0 AND TK_ID={6} AND (Not HethongTK.SoHieu LIKE '5113%') AND {7}{8} ORDER BY ChungTu.NgayCT", _
                          (IIf(pSongNgu, "DienGiaiE,", String.Empty)), _
                          (IIf(pTygia > 0, ",TyGia", String.Empty)), _
                          (IIf(pGiaUSD > 0, ",PSUSD", String.Empty)), _
                          ConvertToStrSafe(m1), _
                          ConvertToStrSafe(n1), _
                          ChungTu2TKNC(1), _
                          ConvertToStrSafe(TKDT_ID), _
                          WThang("ThangCT", tdau, tcuoi), _
                          (IIf(mvt > 0, String.Format(" AND MaVattu={0}", mvt), String.Empty)))
                ExecSQLNonQuery(sql)
                If loai = 1 Then
                    TinhGXKBQ(tdau, tcuoi, MaSo2SoHieu(mvt, "Vattu"), "632")
                Else
                    TinhGXK(tdau, tcuoi, MaSo2SoHieu(mvt, "Vattu"), "632")
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mtp"></param>
    ''' <param name="sl"></param>
    ''' <param name="mk"></param>
    ''' <param name="Ngay"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GiaNVLTheoDM(ByRef mtp As Long, ByRef sl As Double, ByRef mk As Long, ByRef Ngay As Date, Optional ByRef PhanTramDD As Integer = 0, Optional ByRef dk As Integer = 0) As Double
        Dim _giaNVLtheoDM As Double = 0
        Dim rs As DataTable, thangdm As Integer = 0, dem As Integer = 0
        Try
            thangdm = Month(Ngay) + 1
            While dem = 0 And thangdm > 0
                thangdm = thangdm - 1
                dem = ConvertToIntSafe(GetSelectValue("select count(maso) as f1 from dinhmuc where MaTP=" + CStr(mtp) + " AND Thang=" + CStr(thangdm)))
            End While

            rs = New DataTable
            If PhanTramDD = 0 And dk = 0 Then
                rs = ExecSQLReturnDT("SELECT MaNVL,SoLuong FROM DinhMuc WHERE MaNVL>0 AND MaTP=" + CStr(mtp) + " AND Thang=" + CStr(thangdm))
            Else
                If dk = 0 Then
                    rs = ExecSQLReturnDT("SELECT MaNVL,SoLuong FROM DinhMuc WHERE MaNVL>0 AND MaTP=" + CStr(mtp) + " AND Thang=" + CStr(thangdm) + " and TLHT<=" + CStr(PhanTramDD))
                Else
                    rs = ExecSQLReturnDT("SELECT MaNVL,SoLuong FROM DinhMuc WHERE MaNVL>0 AND MaTP=" + CStr(mtp) + " AND Thang=" + CStr(thangdm) + " and TLHT>" + CStr(PhanTramDD))
                End If
            End If
            For Each rsItem As DataRow In rs.Rows
                _giaNVLtheoDM = _giaNVLtheoDM + GiaXuatKho(mk, 0, rsItem("maNVL"), Ngay, sl * rsItem("soluong"))
            Next

            rs.Dispose()
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return _giaNVLtheoDM
        End Try
        Return _giaNVLtheoDM
    End Function

   
    Public Function GiaNCTheoDM(ByRef mtp As Integer, ByRef sl As Double, ByRef thang As Integer) As Double
        Dim dem As Integer = 0
        Dim thangdm As Integer = thang + 1
        Try
            While dem = 0 And thangdm > 0
                thangdm -= 1
                dem = ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(maso) AS f1 FROM dinhmuc WHERE MaTP={0} AND Thang={1}", _
                                                          mtp, _
                                                          thangdm)))
            End While
            Return RoundMoney(sl * ConvertToDblSafe(GetSelectValue(String.Format("SELECT SoLuong AS F1 FROM DinhMuc WHERE MaNVL=0 AND MaTP={0} AND Thang={1}", _
                                                                       mtp, _
                                                                       thangdm))))
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return 0
        End Try
        Return 0
    End Function
  
    Public Function SoPSCPTP(ByRef sh As String, ByRef m As Cls154, ByRef tcuoi As Integer) As Double
        Dim result As Double = 0, sql As String = String.Empty
        Dim sh1 = String.Empty, SoHieu As String = String.Empty
        Dim sops As Double = 0, sops627b As Double = 0, sops627a As Double = 0, TyLe As Double = 0
        Try
            If m.GiaThanhCK(ThangTruoc(tcuoi)) > 0 Then
                If FrmThanhPham.Visible And sh Like "622*" Then
                    sh1 = "627"
                    ' Tổng phát sinh nợ từ đầu năm đến hiện tại của lô sản xuất tham chiếu
                    sops627a = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                   ChungTu2TKNC(-1), _
                                                                   WThang("ThangCT", 0, tcuoi), _
                                                                   sh1, _
                                                                   (IIf(m.MaSo > 0, String.Format(" AND MaTP={0} AND LEFT(tp154.sohieu, 1)=N'{1}'", m.MaSo, Strings.Left(m.SoHieu, 1)), String.Empty)))))
                    ' Tổng phát sinh có từ đầu năm đến tháng trước đó của lô sản xuất tham chiếu
                    sops = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1,chungtu.sohieu AS f2 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE MaLoai<>3 AND {1} AND HethongTK.SoHieu LIKE '{2}%'{3} group by chungtu.sohieu", _
                                                               ChungTu2TKNC(1), _
                                                               WThang("ThangCT", 0, tcuoi - 1), _
                                                               sh1, _
                                                               (IIf(m.MaSo > 0, String.Format(" AND MaTP={0} AND LEFT(tp154.sohieu, 1)=N'{1}'", m.MaSo, Strings.Left(m.SoHieu, 1)), String.Empty))), SoHieu))
                    sops627a -= sops
                    sops627b = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%' AND tp154.sohieu='T{3}'", _
                                                                   ChungTu2TKNC(-1), _
                                                                   WThang("ThangCT", 0, tcuoi), _
                                                                   sh1, _
                                                                   ConvertToStrSafe(tcuoi))))
                    sops627b += ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%' AND LEFT(tp154.sohieu, 1)<>'T'", _
                                                                    ChungTu2TKNC(-1), _
                                                                    WThang("ThangCT", tcuoi, tcuoi), _
                                                                    sh1)))
                    TyLe = sops627a / (IIf(sops627b <> 0, sops627b, 1))
                    sops627a = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%' AND UPPER(tp154.sohieu)='CH'", _
                                                                   ChungTu2TKNC(-1), _
                                                                   WThang("ThangCT", tcuoi, tcuoi), _
                                                                   sh)))
                    sops627b = TyLe * sops627a
                    If m.SoHieu.StartsWith("T") Then
                        result = sops627b + ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                                ChungTu2TKNC(-1), _
                                                                                WThang("ThangCT", 0, tcuoi), _
                                                                                sh, _
                                                                                (IIf(m.MaSo > 0, String.Format(" AND MaTP={0}", m.MaSo), String.Empty)))))
                        Return ConvertToDblSafe(result - ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE MaLoai<>3 AND {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                                 ChungTu2TKNC(1), _
                                                                                 WThang("ThangCT", 0, tcuoi), _
                                                                                 sh, _
                                                                                 (IIf(m.MaSo > 0, String.Format(" AND MaTP={0}", m.MaSo), String.Empty))))))
                    Else
                        Return sops627b + ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                              ChungTu2TKNC(-1), _
                                                                              WThang("ThangCT", tcuoi, tcuoi), _
                                                                              sh, _
                                                                              (IIf(m.MaSo > 0, String.Format(" AND MaTP={0} AND tp154.sohieu=N'{1}'", m.MaSo, m.SoHieu), String.Empty)))))
                    End If
                Else
                    sql = String.Format("SELECT Sum(SoPS) AS F1 FROM {0} WHERE {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                 ChungTu2TKNC(-1), _
                                                                 WThang("ThangCT", 0, tcuoi), _
                                                                 sh, _
                                                                 (IIf(m.MaSo > 0, String.Format(" AND MaTP={0}", m.MaSo), String.Empty)))
                    result = ConvertToDblSafe(GetSelectValue(sql))
                    result = Math.Abs(ConvertToDblSafe(result - ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM {0} WHERE MaLoai<>3 AND {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                                        ChungTu2TKNC(1), _
                                                                                        WThang("ThangCT", 0, tcuoi), _
                                                                                        sh, _
                                                                                        (IIf(m.MaSo > 0, String.Format(" AND MaTP={0}", m.MaSo), String.Empty)))))))
                    Return result - sops
                End If
            Else
                If FrmThanhPham.Visible And sh Like "622*" Then
                    sh1 = "627"
                    sops627a = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                   ChungTu2TKNC(-1), _
                                                                   WThang("ThangCT", tcuoi, tcuoi), _
                                                                   sh1, _
                                                                   (IIf(m.MaSo > 0, String.Format(" AND MaTP={0} AND LEFT(tp154.sohieu, 1)=N'{1}'", m.MaSo, Strings.Left(m.SoHieu, 1)), String.Empty)))))
                    sops = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1,chungtu.sohieu AS f2 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE MaLoai<>3 AND {1} AND HethongTK.SoHieu LIKE '{2}%'{3} group by chungtu.sohieu", _
                                                               ChungTu2TKNC(1), _
                                                               WThang("ThangCT", tcuoi, tcuoi), _
                                                               sh1, _
                                                               (IIf(m.MaSo > 0, String.Format(" AND MaTP={0} AND LEFT(tp154.sohieu, 1)=N'{1}'", m.MaSo, Strings.Left(m.SoHieu, 1)), String.Empty))), SoHieu))
                    sops627a -= sops
                    sops627b = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%' AND tp154.sohieu='T{3}'", _
                                                                   ChungTu2TKNC(-1), _
                                                                   WThang("ThangCT", 0, tcuoi), _
                                                                   sh1, _
                                                                   ConvertToStrSafe(tcuoi))))
                    sops627b += ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%' AND LEFT(tp154.sohieu, 1)<>'T'", _
                                                                    ChungTu2TKNC(-1), _
                                                                    WThang("ThangCT", tcuoi, tcuoi), _
                                                                    sh1)))
                    TyLe = sops627a / (IIf(sops627b <> 0, sops627b, 1))
                    sops627a = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%' AND UPPER(tp154.sohieu)='CH'", _
                                                                   ChungTu2TKNC(-1), _
                                                                   WThang("ThangCT", tcuoi, tcuoi), _
                                                                   sh)))
                    sops627b = TyLe * sops627a
                    Return sops627b + ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                          ChungTu2TKNC(-1), _
                                                                          WThang("ThangCT", tcuoi, tcuoi), _
                                                                          sh, _
                                                                          (IIf(m.MaSo > 0, String.Format(" AND MaTP={0} AND tp154.sohieu=N'{1}'", m.MaSo, m.SoHieu), String.Empty)))))
                Else
                    result = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM {0} WHERE {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                 ChungTu2TKNC(-1), _
                                                                 WThang("ThangCT", tcuoi, tcuoi), _
                                                                 sh, _
                                                                 (IIf(m.MaSo > 0, String.Format(" AND MaTP={0}", m.MaSo), String.Empty)))))
                    result = Math.Abs(ConvertToDblSafe(result - ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM {0} WHERE MaLoai<>3 AND {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                                        ChungTu2TKNC(1), _
                                                                                        WThang("ThangCT", tcuoi, tcuoi), _
                                                                                        sh, _
                                                                                        (IIf(m.MaSo > 0, String.Format(" AND MaTP={0}", m.MaSo), String.Empty)))))))
                    Return result - sops
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <param name="m"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoPSCPTP_DM(ByRef sh As String, ByRef m As Cls154, ByRef tcuoi As Integer) As Double
        Dim result As Double = 0
        Dim sh1 As String = String.Empty
        Dim sops627b As Double = 0, sops627a As Double = 0, TyLe As Double = 0
        Try
            If m.GiaThanhCK(ThangTruoc(tcuoi)) > 0 Then
                If FrmThanhPham.Visible And sh Like "622*" Then
                    sh1 = "627"
                    sops627a = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                   ChungTu2TKNC(-1), _
                                                                   WThang("ThangCT", 0, tcuoi), _
                                                                   sh1, _
                                                                   (IIf(m.MaSo > 0, String.Format(" AND MaTP={0} AND LEFT(tp154.sohieu, 1)=N'{1}'", m.MaSo, Strings.Left(m.SoHieu, 1)), String.Empty)))))
                    sops627a = ConvertToDblSafe(sops627a - ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE MaLoai<>3 AND {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                                   ChungTu2TKNC(1), _
                                                                                   WThang("ThangCT", 0, tcuoi - 1), _
                                                                                   sh1, _
                                                                                   (IIf(m.MaSo > 0, String.Format(" AND MaTP={0} AND LEFT(tp154.sohieu, 1)=N'{1}'", m.MaSo, Strings.Left(m.SoHieu, 1)), String.Empty))))))
                    sops627b = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%' AND tp154.sohieu='T{3}'", _
                                                                   ChungTu2TKNC(-1), _
                                                                   WThang("ThangCT", 0, tcuoi), _
                                                                   sh1, _
                                                                   ConvertToStrSafe(tcuoi))))
                    sops627b += ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%' AND LEFT(tp154.sohieu, 1)<>'T'", _
                                                                    ChungTu2TKNC(-1), _
                                                                    WThang("ThangCT", tcuoi, tcuoi), _
                                                                    sh1)))
                    TyLe = sops627a / (IIf(sops627b <> 0, sops627b, 1))
                    sops627a = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%' AND UPPER(tp154.sohieu)='CH'", _
                                                                   ChungTu2TKNC(-1), _
                                                                   WThang("ThangCT", tcuoi, tcuoi), _
                                                                   sh)))
                    sops627b = TyLe * sops627a
                    If m.SoHieu.StartsWith("T") Then
                        result = sops627b + ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE (CT_ID < 610000000 OR CT_ID > 620000000) AND {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                                ChungTu2TKNC(-1), _
                                                                                WThang("ThangCT", 0, tcuoi), _
                                                                                sh, _
                                                                                (IIf(m.MaSo > 0, String.Format(" AND MaTP={0}", m.MaSo), String.Empty)))))
                        result = ConvertToDblSafe(result - ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE MaLoai<>3 AND {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                                   ChungTu2TKNC(1), _
                                                                                   WThang("ThangCT", 0, tcuoi), _
                                                                                   sh, _
                                                                                   (IIf(m.MaSo > 0, String.Format(" AND MaTP={0}", m.MaSo), String.Empty))))))
                    Else
                        result = sops627b + ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE (CT_ID < 610000000 OR CT_ID > 620000000) AND {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", ChungTu2TKNC(-1), WThang("ThangCT", tcuoi, tcuoi), sh, (IIf(m.MaSo > 0, " AND MaTP=" & m.MaSo & " AND tp154.sohieu='" & m.SoHieu & "'", String.Empty)))))
                    End If
                Else
                    result = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM {0} WHERE (CT_ID < 610000000 OR CT_ID > 620000000) AND {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                 ChungTu2TKNC(-1), _
                                                                 WThang("ThangCT", 0, tcuoi), _
                                                                 sh, _
                                                                 (IIf(m.MaSo > 0, String.Format(" AND MaTP={0}", m.MaSo), String.Empty)))))
                    result = ConvertToDblSafe(result - ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM {0} WHERE MaLoai<>3 AND {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                               ChungTu2TKNC(1), _
                                                                               WThang("ThangCT", 0, tcuoi), _
                                                                               sh, _
                                                                               (IIf(m.MaSo > 0, String.Format(" AND MaTP={0}", m.MaSo), String.Empty))))))
                End If
            Else
                If FrmThanhPham.Visible And sh Like "622*" Then
                    sh1 = "627"
                    sops627a = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                   ChungTu2TKNC(-1), _
                                                                   WThang("ThangCT", tcuoi, tcuoi), _
                                                                   sh1, _
                                                                   (IIf(m.MaSo > 0, String.Format(" AND MaTP={0} AND LEFT(tp154.sohieu, 1)=N'{1}'", m.MaSo, Strings.Left(m.SoHieu, 1)), String.Empty)))))
                    sops627a = ConvertToDblSafe(sops627a - ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE MaLoai<>3 AND {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                                   ChungTu2TKNC(1), _
                                                                                   WThang("ThangCT", tcuoi, tcuoi), _
                                                                                   sh1, _
                                                                                   (IIf(m.MaSo > 0, String.Format(" AND MaTP={0} AND LEFT(tp154.sohieu, 1)=N'{1}'", m.MaSo, Strings.Left(m.SoHieu, 1)), String.Empty))))))
                    sops627b = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%' AND tp154.sohieu='T{3}'", _
                                                                   ChungTu2TKNC(-1), _
                                                                   WThang("ThangCT", 0, tcuoi), _
                                                                   sh1, _
                                                                   ConvertToStrSafe(tcuoi))))
                    sops627b += ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%' AND LEFT(tp154.sohieu, 1)<>'T'", _
                                                                    ChungTu2TKNC(-1), _
                                                                    WThang("ThangCT", tcuoi, tcuoi), _
                                                                    sh1)))
                    TyLe = sops627a / (IIf(sops627b <> 0, sops627b, 1))
                    sops627a = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%' AND UPPER(tp154.sohieu)='CH'", _
                                                                   ChungTu2TKNC(-1), _
                                                                   WThang("ThangCT", tcuoi, tcuoi), _
                                                                   sh)))
                    sops627b = TyLe * sops627a
                    result = sops627b + ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE (CT_ID < 610000000 OR CT_ID > 620000000) AND {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                            ChungTu2TKNC(-1), _
                                                                            WThang("ThangCT", tcuoi, tcuoi), _
                                                                            sh, _
                                                                            (IIf(m.MaSo > 0, String.Format(" AND MaTP={0} AND tp154.sohieu=N'{1}'", m.MaSo, m.SoHieu), String.Empty)))))
                Else
                    result = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM {0} WHERE (CT_ID < 610000000 OR CT_ID > 620000000) AND {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                 ChungTu2TKNC(-1), _
                                                                 WThang("ThangCT", tcuoi, tcuoi), _
                                                                 sh, _
                                                                 (IIf(m.MaSo > 0, String.Format(" AND MaTP={0}", m.MaSo), String.Empty)))))
                    result = ConvertToDblSafe(result - ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM {0} WHERE MaLoai<>3 AND {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                               ChungTu2TKNC(1), _
                                                                               WThang("ThangCT", tcuoi, tcuoi), _
                                                                               sh, _
                                                                               (IIf(m.MaSo > 0, String.Format(" AND MaTP={0}", m.MaSo), String.Empty))))))
                End If
            End If
            If result < 0 And FrmThanhPham.Visible Then result = 0
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return result
        End Try
        
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mk1"></param>
    ''' <param name="mk2"></param>
    ''' <remarks></remarks>
    Public Sub ChuyenKho(ByRef mk1 As Integer, ByRef mk2 As Integer)
        Try
            Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT MaTaiKhoan,MaVattu,Luong_0,Tien_0 FROM TonKho WHERE (Luong_0<>0 OR Tien_0<>0) AND MaSoKho={0}", mk1))
            For Each rsItem As DataRow In rs.Rows
                Dim rowEffect As Integer = ExecSQLNonQueryUpdateInsertDeleteQuery(String.Format("UPDATE TonKho SET Luong_0=Luong_0+{0},Tien_0=Tien_0+{1} WHERE MaSoKho={2} AND MaTaiKhoan={3} AND MaVattu={4}", _
                                CStr(rsItem("Luong_0")), _
                                CStr(rsItem("Tien_0")), _
                                mk2, _
                                rsItem("MaTaiKhoan"), _
                                rsItem("MaVattu")))
                If rowEffect = 0 Then ExecSQLNonQuery(String.Format("UPDATE TonKho SET MaSoKho={0} WHERE MaSoKho={1} AND MaTaiKhoan={2} AND MaVattu={3}", _
                                                          mk2, _
                                                          mk1, _
                                                          rsItem("MaTaiKhoan"), _
                                                          rsItem("MaVattu")))
                If OutCost <> 0 Then
                    rowEffect = ExecSQLNonQueryUpdateInsertDeleteQuery(String.Format("UPDATE VTDauNam SET Luong_0=Luong_0+{0},Tien_0=Tien_0+{1} WHERE MaSoKho={2} AND MaTaiKhoan={3} AND MaVattu={4}", _
                                        CStr(rsItem("Luong_0")), _
                                        CStr(rsItem("Tien_0")), _
                                        mk2, _
                                        rsItem("MaTaiKhoan"), _
                                        rsItem("MaVattu")))
                    If rowEffect = 0 Then ExecSQLNonQuery(String.Format("UPDATE VTDauNam SET MaSoKho={0} WHERE MaSoKho={1} AND MaTaiKhoan={2} AND MaVattu={3}", _
                                                              mk2, _
                                                              mk1, _
                                                              rsItem("MaTaiKhoan"), _
                                                              rsItem("MaVattu")))
                End If
            Next
            ExecSQLNonQuery(String.Format("DELETE FROM TonKho WHERE MaSoKho={0}", mk1))
            If OutCost <> 0 Then ExecSQLNonQuery(String.Format("DELETE FROM VTDauNam WHERE MaSoKho={0}", mk1))
            ExecSQLNonQuery(String.Format("UPDATE ChungTu SET MaKho={0} WHERE (MaLoai=13 OR MaLoai=1 OR MaLoai=2) AND MaKho={1}", mk2, mk1))
            ExecSQLNonQuery(String.Format("UPDATE ChungTu SET MaNguon={0} WHERE (MaLoai=4) AND MaNguon={1}", mk2, mk1))
            KiemTraVatTu()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ms"></param>
    ''' <param name="thang"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DaTinhGiaThanh154(ByRef ms As Integer, ByRef thang As Integer) As Boolean
        Try
            Return ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 MaSo AS F1 FROM ThanhPham WHERE Ma154={0} AND Thang={1}", _
                                                   ms, _
                                                   thang))) > 0
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tp"></param>
    ''' <param name="thang"></param>
    ''' <param name="ktra"></param>
    ''' <remarks></remarks>
    Public Sub DieuChinhGiaThanh(ByRef tp As Cls154, ByRef thang As Integer, Optional ByRef ktra As Integer = 0)
        Dim xk As CheckState
        Dim cp1a As Double = 0, cp1 As Double = 0, tcp As Double = 0
        Dim tp1 As New Cls154
        If tp.MaSo = 0 Then
            Exit Sub
        End If
        Try
            If Not DaTinhGiaThanh154(tp.MaSo, thang) Then Exit Sub
            Dim sql As String = String.Format("SELECT * FROM ThanhPham WHERE Thang={0} AND Ma154={1} ORDER BY CPNVL", thang, tp.MaSo)
            Dim rs As DataTable = ExecSQLReturnDT(sql)
            Dim sodong As Double = rs.Rows.Count, n As Date
            If sodong > 0 Then
                xk = CType(rs.Rows(sodong - 1)("xk"), CheckState)
                n = ConvertToDateSafe(rs.Rows(sodong - 1)("Ngay"))
            End If
            ' Tinh lai cp NVL
            Dim CP As Double = tp.SoCPNVL(thang, thang) + tp.SoCPNVLPB(thang, thang)
            Dim cpcu As Double = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(CPNVL) AS F1 FROM ThanhPham WHERE Thang={0} AND Ma154={1}", _
                                                                     thang, _
                                                                     tp.MaSo)))
            If cpcu <> CP Then
                For i As Double = 1 To sodong - 1
                    If cpcu <> 0 Then
                        cp1 = RoundMoney(rs.Rows(i)("CPNVL") * CP / cpcu)
                        ExecSQLNonQuery(String.Format("UPDATE ThanhPham SET GiaThanh=GiaThanh-CPNVL+{0},CPNVL={0} WHERE MaSo={1}", _
                                            CStr(cp1), _
                                            rs.Rows(i)("MaSo")))
                        tcp += cp1
                    End If
                Next
                ' Dong cuoi
                ExecSQLNonQuery(String.Format("UPDATE ThanhPham SET GiaThanh=GiaThanh-CPNVL+{0},CPNVL={0} WHERE MaSo={1}", _
                                    CStr(CP - tcp), _
                                    rs.Rows(sodong - 1)("MaSo")))
            End If
            ExecSQLNonQuery(String.Format("UPDATE ThanhPham SET CPSXC=CPNVL/{0},GiaThanh=GiaThanh-CPNC-CPSXC WHERE Thang={1} AND Ma154={2}", _
                                CStr(IIf(CP <> 0, CP, 1)), _
                                thang, _
                                ConvertToStrSafe(tp.MaSo)))
            rs = ExecSQLReturnDT(sql)
            sodong = rs.Rows.Count
            ' Tinh lai cp nc
            tcp = 0
            Dim tcpa As Double = 0
            CP = tp.SoCPNC(thang, thang) + tp.SoCPNCPB(thang, thang)
            Dim cpa As Double = tp.SoCPSXC(thang, thang) + tp.SoCPSXCTT(thang, thang)
            For Each rsItem As DataRow In rs.Rows
                cp1 = RoundMoney(CP * ConvertToDblSafe(rsItem("cpsxc")))
                cp1a = RoundMoney(cpa * ConvertToDblSafe(rsItem("cpsxc")))
                ExecSQLNonQuery(String.Format("UPDATE ThanhPham SET GiaThanh=GiaThanh+{0},CPNC={1},CPSXC={2} WHERE MaSo={3}", _
                                    CStr(cp1 + cp1a), _
                                    CStr(cp1), _
                                    CStr(cp1a), _
                                    rsItem("MaSo")))
                tcp += cp1
                tcpa += cp1a
            Next
            ' Dong cuoi
            ExecSQLNonQuery(String.Format("UPDATE ThanhPham SET GiaThanh=GiaThanh+{0},CPNC={1},CPSXC={2} WHERE MaSo={3}", _
                                CStr(CP - tcp + cpa - tcpa), _
                                CStr(CP - tcp), _
                                CStr(cpa - tcpa), _
                                rs.Rows(sodong - 1)("MaSo")))
            GhiXuatNVL(ConvertToDblSafe(rs.Rows(sodong - 1)("MaCT")), n, thang, IIf(ktra = 0, 0, xk), tp, 1)
            Dim Mientru As String = sql
            rs = ExecSQLReturnDT(String.Format("SELECT ChungTu.MaTP FROM ChungTu INNER JOIN ({0}) AS Mientru ON ChungTu.MaVattu=Mientru.MaTP WHERE ChungTu.MaTP>0 AND ChungTu.MaLoai=2 AND ChungTu.ThangCT={1} AND CT_ID>610000000 GROUP BY ChungTu.MaTP", _
                                     Mientru, _
                                     thang))
            For Each rsItem As DataRow In rs.Rows
                tp1.InitTPMaSo(ConvertToDblSafe(rsItem("MaTP")))
                DieuChinhGiaThanh(tp1, thang, 1)
            Next
            If ktra = 0 Then
                TinhLaiGiaVonTP(tp, thang)
                KiemTraVatTu()
                KiemTraTaiKhoan()
                HienThongBao(String.Empty, 1)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Public Sub TinhLaiGiaThanhPham(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim tp As New Cls154
        Try
            Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT ThanhPham.* FROM ThanhPham WHERE {0}", WThang("Thang", tdau, tcuoi)))
            For Each rsItem As DataRow In rs.Rows
                tp.InitTPMaSo(ConvertToDblSafe(rsItem("Ma154")))
                DieuChinhGiaThanh(tp, ConvertToDblSafe(rsItem("thang")), 1)
            Next
            If rs.Rows.Count > 0 Then
                KiemTraVatTu()
                KiemTraTaiKhoan()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tp"></param>
    ''' <param name="thang"></param>
    ''' <remarks></remarks>
    Public Sub TinhLaiGiaVonTP(ByRef tp As Cls154, ByRef thang As Integer)
        If tp.MaSo = 0 Then Exit Sub
        Try
            Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT DISTINCT MaTP FROM ThanhPham WHERE Ma154={0} AND Thang={1} GROUP BY MaTP", _
                                                  tp.MaSo, _
                                                  thang))
            For Each rsItem As DataRow In rs.Rows
                TinhGVBH(NgayDauThang(pNamTC, thang), _
                    NgayCuoiThang(pNamTC, thang), _
                    System.Windows.Forms.DialogResult.Yes, _
                    ConvertToDblSafe(rsItem("MaTP")), _
                    1)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <param name="mtp"></param>
    ''' <param name="mtk"></param>
    ''' <param name="mvt"></param>
    ''' <param name="dgia"></param>
    ''' <param name="tien"></param>
    ''' <remarks></remarks>
    Public Sub DieuChinhGiaTP(ByRef thang As Integer, ByRef mtp As Integer, ByRef mtk As Integer, ByRef mvt As Integer, ByRef dgia As Double, ByRef tien As Double)
        Dim dg As Double = 0, T As Double = 0
        Dim m As Integer = 0
        If pGiaHT = 0 Then Exit Sub
        Try
            dg = IIf(dgia = 0, ConvertToDblSafe(GetSelectValue("SELECT GiaHT AS F1 FROM Vattu WHERE MaSo=" & mvt)), dgia)
            ExecSQLNonQuery(String.Format("UPDATE {0} SET SoPS=CAST(0.5+SoPS2No*{1} AS INT) WHERE ThangCT={2}{3} AND MaTKNo={4} AND MaVattu={5} AND HethongTK.SoHieu LIKE '{6}%'", _
                                ChungTu2TKNC(1), _
                                CStr(dg), _
                                thang, _
                                (IIf(mtp > 0, String.Format(" AND MaTP={0}", mtp), String.Empty)), _
                                mtk, _
                                mvt, _
                                ShTkSPDo))
            Dim Mientru As String = String.Format("SELECT MaCT FROM {0} WHERE (MaLoai=13 OR MaLoai=1) AND ThangCT={1} AND MaTKNo=0 AND HethongTK.SoHieu LIKE '{2}%' GROUP BY MaCT", _
                                         ChungTu2TKNC(1), _
                                         thang, _
                                         ShTkSPDo)
            Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT MaSo,ChungTu.MaCT,SoPS2No,SoPS FROM ChungTu INNER JOIN (" & Mientru & ") as Mientru ON ChungTu.MaCT=Mientru.MaCT WHERE MaTP={0} AND MaTKNo={1} AND MaVattu={2}", _
                                                      mtp, _
                                                      mtk, _
                                                      mvt))
            For Each rsItem As DataRow In rs.Rows
                T = RoundMoney(ConvertToDblSafe(rsItem("SoPS2No")) * dg)
                If T <> ConvertToDblSafe(rsItem("sops")) Then
                    ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoPS={0} WHERE MaSo={1}", _
                                        doidau(T), _
                                        ConvertToDblSafe(rsItem("MaSo"))))
                    ExecSQLNonQuery(String.Format("UPDATE {0} SET SoPS=SoPS+{1} WHERE MaTP={2} AND MaCT={3} AND HethongTK.SoHieu LIKE '{4}%'", _
                                        ChungTu2TKNC(1), _
                                        doidau(T - ConvertToDblSafe(rsItem("sops"))), _
                                        ConvertToStrSafe(mtp), _
                                        ConvertToDblSafe(rsItem("MaCT")), _
                                        ShTkSPDo))
                End If
            Next
            dg = ConvertToDblSafe(GetSelectValue("SELECT Sum(SoPS) AS F1,Max(CASE WHEN(MaTKNo>0 AND MaTKCo>0) THEN ChungTu.MaSo ELSE 0 END) AS F2 FROM ChungTu WHERE (MaLoai=13 OR MaLoai=1) AND MaTP=" & mtp & " AND MaTKNo=" & ConvertToStrSafe(mtk) & " AND MaVattu=" & ConvertToStrSafe(mvt) & " AND ThangCT=" & ConvertToStrSafe(thang), m))
            If dg <> tien Then ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoPS=SoPS+{0} WHERE MaSo={1}", _
                                                   doidau(tien - dg), _
                                                   m))
            TinhGXK(thang, thang, MaSo2SoHieu(mvt, "Vattu"), String.Empty, 1)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mtp"></param>
    ''' <remarks></remarks>
    Public Sub DatLaiGiaHT(ByRef mtp As Integer)
        If pGiaHT = 0 Then Exit Sub
        Try
            Dim rs As DataTable = ExecSQLReturnDT("SELECT * FROM ThanhPham WHERE MaSo=" & mtp)
            For Each rsItem As DataRow In rs.Rows
                DieuChinhGiaTP(ConvertToDblSafe(rsItem("thang")), _
                    ConvertToDblSafe(rsItem("Ma154")), _
                    ConvertToDblSafe(rsItem("MaTK")), _
                    ConvertToDblSafe(rsItem("MaTP")), _
                    0, _
                    0)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="shvt"></param>
    ''' <param name="tkno"></param>
    ''' <param name="ktra"></param>
    ''' <remarks></remarks>
    Public Sub TinhGXKFIFO(ByRef tdau As Integer, _
        ByRef tcuoi As Integer, _
        ByRef shvt As String, _
        ByRef tkno As String, _
        Optional ByRef ktra As Integer = 0)
        Dim sql As String = String.Empty
        Dim ps2 As Double = 0, ps As Double = 0, tien As Double = 0, luong As Double = 0, tien2 As Double = 0, soton As Double = 0
        Dim nx As Integer = 0
        Dim ms As Integer = 0, mv As Integer = 0, mk As Integer = 0, mt As Integer = 0, m As Integer = 0
        Dim ctu As New ClsChungtu
        If OutCost <> 2 Then Exit Sub
        Try
            If OutCost <> 0 Then
                If ConvertToDblSafe(GetSelectValue("SELECT Max(MaVattu) AS F1 FROM VTDauNam")) = 0 Then
                    ExecSQLNonQuery("INSERT INTO VTDauNam (MaSo,MaSoKho, MaTaiKhoan, MaVattu, Luong_0, Tien_0) SELECT MaSo,MaSoKho, MaTaiKhoan, MaVattu, Luong_0, Tien_0 FROM TonKho WHERE Luong_0<>0 OR Tien_0<>0")
                End If
            End If
            If tkno.Length > 0 Then
                sql = String.Format("SELECT DISTINCT ChungTu.MaSo,ThangCT,NgayGS,MaCT,MaKho,MaVattu,MaTKCo,SoPS,SoPS2Co,{0} AS SoPS2 FROM ({1}) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo WHERE HethongTK.SoHieu LIKE '{2}%' AND (MaLoai=2 OR MaLoai=4) AND MaVattu>0 AND MaTKNo>0 AND TK.TK_ID={3} AND {4}{5} ORDER BY MaKho,MaTKCo,MaVattu,ThangCT,NgayGS,ChungTu.MaCT,ChungTu.MaSo", _
                          (IIf(pGiaUSD > 0, "PSUSD", "0")), _
                          ChungTu2TKNC(0), _
                          tkno, _
                          ConvertToStrSafe(TKVT_ID), _
                          WThang("ThangCT", tdau, tcuoi), _
                          (IIf(shvt.Length > 0, String.Format(" AND Vattu.SoHieu=N'{0}'", shvt), String.Empty)))
            Else
                sql = String.Format("SELECT DISTINCT ChungTu.MaSo,ThangCT,NgayGS,MaCT,MaKho,MaVattu,MaTKCo,SoPS,SoPS2Co,{0} AS SoPS2 FROM ({1}) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo WHERE (MaLoai=2 OR MaLoai=4) AND MaVattu>0 AND HethongTK.TK_ID={2} AND {3}{4} ORDER BY MaKho,MaTKCo,MaVattu,ThangCT,NgayGS,ChungTu.MaCT,ChungTu.MaSo", _
                          (IIf(pGiaUSD > 0, "PSUSD", "0")), _
                          ChungTu2TKNC(1), _
                          ConvertToStrSafe(TKVT_ID), _
                          WThang("ThangCT", tdau, tcuoi), _
                          (IIf(shvt.Length > 0, String.Format(" AND Vattu.SoHieu=N'{0}'", shvt), String.Empty)))
            End If
            Dim rs As DataTable = ExecSQLReturnDT(sql)
            For Each rsItem As DataRow In rs.Rows
                If mk <> ConvertToDblSafe(rsItem("MaKho")) Or mt <> ConvertToDblSafe(rsItem("MaTkCo")) Or mv <> ConvertToDblSafe(rsItem("MaVattu")) Then
                    mk = ConvertToDblSafe(rsItem("MaKho"))
                    mt = ConvertToDblSafe(rsItem("MaTkCo"))
                    mv = ConvertToDblSafe(rsItem("MaVattu"))
                    soton = 0
                    ms = 0
                    luong = 0
                    tien = 0
                    ExecSQLNonQuery(String.Format("UPDATE VTDauNam SET SoXuat=0 WHERE MaSoKho={0} AND MaTaiKhoan={1} AND MaVattu={2}", _
                                        mk, _
                                        mt, _
                                        mv))
                    ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoXuat=0 WHERE (((MaLoai=13 OR MaLoai=1) AND MaKho={0}) OR (MaLoai=4 AND MaNguon={1})) AND MaTKNo={2} AND MaVattu={3}", _
                                        mk, _
                                        mk, _
                                        mt, _
                                        mv))
                End If
                If soton <= 0 Then
                    nx = 0
                    If rsItem("SoPS2Co") > 0 Then
                        luong = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 Luong_0 AS F1,Tien_0 AS F2,MaSo AS F3{0}, Luong_0-SoXuat AS F5 FROM VTDauNam WHERE MaSoKho={1} AND MaTaiKhoan={2} AND MaVattu={3} AND Luong_0>SoXuat ORDER BY MaSo", _
                                                                    (IIf(pGiaUSD > 0, ",USDTien_0 AS F4", String.Empty)), _
                                                                    mk, _
                                                                    mt, _
                                                                    mv), tien, ms, tien2, soton))
                        If luong <= 0 Then
                            nx = 1
                            luong = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 SoPS2No AS F1,SoPS AS F2,MaSo AS F3{0}, SoPS2No-SoXuat AS F5 FROM ChungTu WHERE (((MaLoai=13 OR MaLoai=1) AND MaKho={1}) OR (MaLoai=4 AND MaNguon={1})) AND MaTKNo={2} AND MaVattu={3} AND SoPS2No>SoXuat ORDER BY ThangCT, NgayGS, MaCT, MaSo", _
                                                                        (IIf(pGiaUSD > 0, ",PSUSD AS F4", String.Empty)), _
                                                                        mk, _
                                                                        mt, _
                                                                        mv), tien, ms, tien2, soton))
                        End If
                    Else
                        luong = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 Luong_0 AS F1,Tien_0 AS F2,MaSo AS F3{0}, Luong_0-SoXuat AS F5 FROM VTDauNam WHERE MaSoKho={1} AND MaTaiKhoan={2} AND MaVattu={3} AND Luong_0=0 AND SoXuat=0 ORDER BY MaSo", _
                                                                    (IIf(pGiaUSD > 0, ",USDTien_0 AS F4", String.Empty)), _
                                                                    mk, _
                                                                    mt, _
                                                                    mv), tien, ms, tien2, soton))
                        If tien <= 0 Then
                            nx = 1
                            luong = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 SoPS2No AS F1,SoPS AS F2,MaSo AS F3{0}, SoPS2No-SoXuat AS F5 FROM ChungTu WHERE (((MaLoai=13 OR MaLoai=1) AND MaKho={1}) OR (MaLoai=4 AND MaNguon={1})) AND MaTKNo={2} AND MaVattu={3} AND SoPS2No=0 AND SoXuat=0 ORDER BY ThangCT, NgayGS, MaCT, MaSo", _
                                                                        (IIf(pGiaUSD > 0, ",PSUSD AS F4", String.Empty)), _
                                                                        mk, _
                                                                        mt, _
                                                                        mv), tien, ms, tien2, soton))
                        End If
                    End If
                End If
                If (soton > 0 And luong > 0) Or (ConvertToDblSafe(rsItem("SoPS2Co")) = 0 And tien > 0) Then
                    m = ConvertToDblSafe(rsItem("MaSo"))
                    If ConvertToDblSafe(rsItem("SoPS2Co")) > soton Then
                        ctu.InitChungtu(m, 0, String.Empty, 0, DateTime.Today, DateTime.Today, 0, 0, "", 0, 0, 0, 0, 0, 0, "", 0, DateTime.Today)
                        ctu.SoPS2Co = ConvertToDblSafe(rsItem("SoPS2Co")) - soton
                        ctu.sops = 0
                        ctu.MaSo = 0
                        ctu.CT_ID = 0
                        ctu.GhiChungtu()
                        ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoPS2Co={0},SoPS=0 WHERE MaSo={1}", _
                                            doidau(soton), _
                                            m))
                        'UpgradeStubs.DAO_DBEngine.Idle(DBEngineHelper.Instance(Artinsoft.VB6.DB.AdoFactoryManager.GetFactory()))
                        'rs.Requery()
                        'rs.FindFirst(String.Format("MaSo={0}", m))
                        ' [C15_XetLai]
                    End If
                    If ConvertToDblSafe(rsItem("SoPS2Co")) > 0 Then
                        soton -= ConvertToDblSafe(rsItem("SoPS2Co"))
                        ps = RoundMoney(ConvertToDblSafe(rsItem("SoPS2Co")) * tien / luong)
                        ps2 = RoundMoney(ConvertToDblSafe(rsItem("SoPS2Co")) * tien2 / luong)
                    Else
                        ps = tien
                        ps2 = tien2
                    End If
                    ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoPS={0}, CT_ID=-{1}{2} WHERE MaSo={3}", _
                                        doidau(ps), _
                                        ConvertToStrSafe((IIf(nx = 0, 2000000000, 0)) + ms), _
                                        (IIf(pGiaUSD > 0, String.Format(",PSUSD={0}", CStr(ps2)), String.Empty)), _
                                        m))
                    If nx = 0 Then
                        ExecSQLNonQuery(String.Format("UPDATE VTDauNam SET SoXuat=SoXuat+{0} WHERE MaSo={1}", _
                                            doidau(IIf(rsItem("SoPS2Co") > 0, rsItem("SoPS2Co"), 1)), _
                                            ms))
                    Else
                        ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoXuat=SoXuat+{0} WHERE MaSo={1}", _
                                            doidau(IIf(rsItem("SoPS2Co") > 0, rsItem("SoPS2Co"), 1)), _
                                            ms))
                    End If
                    'UpgradeStubs.DAO_DBEngine.Idle(DBEngineHelper.Instance(Artinsoft.VB6.DB.AdoFactoryManager.GetFactory()))
                    ' [C15_XetLai]
                End If
            Next
            rs = Nothing
            ctu = Nothing
            If mv > 0 And ktra = 0 Then
                KiemTraTaiKhoan()
                KiemTraVatTu(1)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="shvt"></param>
    ''' <param name="tkno"></param>
    ''' <param name="ktra"></param>
    ''' <remarks></remarks>
    Public Sub TinhGXKDD(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef shvt As String, ByRef tkno As String, Optional ByRef ktra As Integer = 0)
        Dim sql As String = String.Empty
        Dim ps2 As Double = 0, ps As Double = 0, tien As Double = 0, luong As Double = 0, tien2 As Double = 0, soton As Double = 0
        Dim nx As Integer = 0
        Dim ms As Integer = 0, mv As Integer = 0, mk As Integer = 0, mt As Integer = 0, m As Integer = 0
        Dim ctu As New ClsChungtu
        If OutCost <> 1 Then Exit Sub
        Try
            ExecSQLNonQuery(String.Format("UPDATE (VTDauNam INNER JOIN HethongTK ON VTDauNam.MaTaiKhoan=HethongTK.MaSo) INNER JOIN Vattu ON VTDauNam.MaVattu=Vattu.MaSo SET SoXuat=0 WHERE HethongTK.SoHieu LIKE '{0}%'{1}", _
                            tkno, _
                            (IIf(shvt.Length > 0, String.Format(" AND Vattu.SoHieu=N'{0}'", shvt), String.Empty))))
            If tkno.Length > 0 Then
                sql = String.Format("SELECT ChungTu.MaSo,ThangCT, ChungTu.SoHieu, MaTKCo,MaVattu,SoPS2Co,SoPS,CT_ID FROM ({0}) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo WHERE (MaLoai=2 OR MaLoai=4) AND ABS(CT_ID)>2000000000 AND TK.TK_ID={1} AND HethongTK.SoHieu LIKE '{2}%'{3} ORDER BY ThangCT, ChungTu.SoHieu", _
                          ChungTu2TKNC(0), _
                          ConvertToStrSafe(TKVT_ID), _
                          tkno, _
                          (IIf(shvt.Length > 0, String.Format(" AND Vattu.SoHieu=N'{0}'", shvt), String.Empty)))
            Else
                sql = String.Format("SELECT ChungTu.MaSo,ThangCT, ChungTu.SoHieu, MaTKCo,MaVattu,SoPS2Co,SoPS,CT_ID FROM ({0}) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo WHERE (MaLoai=2 OR MaLoai=4) AND ABS(CT_ID)>2000000000 AND HethongTK.TK_ID={1}{2} ORDER BY ThangCT, ChungTu.SoHieu", _
                          ChungTu2TKNC(1), _
                          ConvertToStrSafe(TKVT_ID), _
                          (IIf(shvt.Length > 0, String.Format(" AND Vattu.SoHieu=N'{0}'", shvt), String.Empty)))
            End If
            Dim rs As DataTable = ExecSQLReturnDT(sql)
            For Each rsItem As DataRow In rs.Rows
                m = ConvertToDblSafe(Math.Abs(ConvertToDblSafe(rsItem("CT_ID"))) - 2000000000)
                Dim rowEffect As Integer = ExecSQLNonQuery(String.Format("UPDATE VTDauNam SET SoXuat=SoXuat+{0} WHERE MaVattu={1} AND MaSo={2} AND SoXuat+{0}>=Luong_0", _
                                    CStr(ConvertToDblSafe(rsItem("SoPS2Co"))), _
                                    ConvertToDblSafe(rsItem("MaVattu")), _
                                    ConvertToStrSafe(Math.Abs(rsItem("CT_ID")) - 2000000000)))
                If rowEffect = 0 Then ExecSQLNonQuery(String.Format("UPDATE ChungTu SET CT_ID=0 WHERE MaSo={0}", rsItem("MaSo")))
            Next
            ExecSQLNonQuery(String.Format("UPDATE ChungTu INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo SET ChungTu.SoXuat=0 WHERE ((MaLoai=13 OR MaLoai=1) OR MaLoai=4) AND TK_ID={0}", TKVT_ID))
            If tkno.Length > 0 Then
                sql = String.Format("SELECT ChungTu.MaSo,ThangCT, ChungTu.SoHieu, MaTKCo,MaVattu,SoPS2Co,SoPS,CT_ID FROM ({0}) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo WHERE (MaLoai=2 OR MaLoai=4) AND ABS(CT_ID)<2000000000 AND TK.TK_ID={1} AND HethongTK.SoHieu LIKE '{2}%'{3} ORDER BY ThangCT, ChungTu.SoHieu", _
                          ChungTu2TKNC(0), _
                          TKVT_ID, _
                          tkno, _
                          (IIf(shvt.Length > 0, String.Format(" AND Vattu.SoHieu=N'{0}'", shvt), String.Empty)))
            Else
                sql = String.Format("SELECT ChungTu.MaSo,ThangCT, ChungTu.SoHieu, MaTKCo,MaVattu,SoPS2Co,SoPS,CT_ID FROM ({0}) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo WHERE (MaLoai=2 OR MaLoai=4) AND ABS(CT_ID)<2000000000 AND HethongTK.TK_ID={1}{2} ORDER BY ThangCT, ChungTu.SoHieu", _
                          ChungTu2TKNC(1), _
                          TKVT_ID, _
                          (IIf(shvt.Length > 0, String.Format(" AND Vattu.SoHieu=N'{0}'", shvt), String.Empty)))
            End If
            rs = ExecSQLReturnDT(sql)
            For Each rsItem As DataRow In rs.Rows
                Dim effectCount As Integer = ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoXuat=SoXuat+{0} WHERE (MaLoai=13 OR MaLoai=1) OR MaLoai=4) AND MaVattu={1} AND MaSo={2} AND SoXuat+{0}>=SoPS2No", _
                                    doidau(ConvertToDblSafe(rsItem("SoPS2Co"))), _
                                    rsItem("MaVattu"), _
                                    ConvertToStrSafe(Math.Abs(ConvertToDblSafe(rsItem("CT_ID"))))))
                If effectCount = 0 Then ExecSQLNonQuery(String.Format("UPDATE ChungTu SET CT_ID=0 WHERE MaSo={0}", rsItem("MaSo")))
            Next
            If tkno.Length > 0 Then
                sql = String.Format("SELECT DISTINCT ChungTu.MaSo,NgayGS,MaCT,MaKho,MaVattu,MaTKCo,SoPS,SoPS2Co,{0} AS SoPS2 FROM ({1}) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo WHERE HethongTK.SoHieu LIKE '{2}%' AND (MaLoai=2 OR MaLoai=4) AND MaVattu>0 AND MaTKNo>0 AND TK.TK_ID={3} AND SoPS2Co>0 AND {4}{5} AND CT_ID=0 ORDER BY ThangCT,NgayGS,ChungTu.MaCT,MaKho,MaTKCo,MaVattu, ChungTu.MaSo", _
                          (IIf(pGiaUSD > 0, "PSUSD", "0")), _
                          ChungTu2TKNC(0), _
                          tkno, _
                          ConvertToStrSafe(TKVT_ID), _
                          WThang("ThangCT", tdau, tcuoi), _
                          (IIf(shvt.Length > 0, String.Format(" AND Vattu.SoHieu=N'{0}'", shvt), String.Empty)))
            Else
                sql = String.Format("SELECT DISTINCT ChungTu.MaSo,NgayGS,MaCT,MaKho,MaVattu,MaTKCo,SoPS,SoPS2Co,{0} AS SoPS2 FROM ({1}) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo WHERE (MaLoai=2 OR MaLoai=4) AND MaVattu>0 AND HethongTK.TK_ID={2} AND SoPS2Co>0 AND {3}{4} AND CT_ID=0 ORDER BY ThangCT,NgayGS,ChungTu.MaCT,MaKho,MaTKCo,MaVattu, ChungTu.MaSo", _
                          (IIf(pGiaUSD > 0, "PSUSD", "0")), _
                          ChungTu2TKNC(1), _
                          ConvertToStrSafe(TKVT_ID), _
                          WThang("ThangCT", tdau, tcuoi), _
                          (IIf(shvt.Length > 0, String.Format(" AND Vattu.SoHieu=N'{0}'", shvt), String.Empty)))
            End If
            rs = ExecSQLReturnDT(sql)
            For Each rsItem As DataRow In rs.Rows
                If mk <> ConvertToDblSafe(rsItem("MaKho")) Or mt <> ConvertToDblSafe(rsItem("MaTkCo")) Or mv <> ConvertToDblSafe(rsItem("MaVattu")) Then
                    mk = ConvertToDblSafe(rsItem("MaKho"))
                    mt = ConvertToDblSafe(rsItem("MaTkCo"))
                    mv = ConvertToDblSafe(rsItem("MaVattu"))
                    soton = 0
                    ms = 0
                    luong = 0
                    tien = 0
                End If
                If soton <= 0 Then
                    nx = 0
                    luong = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 Luong_0 AS F1,Tien_0 AS F2,MaSo AS F3{0}, Luong_0-SoXuat AS F5 FROM VTDauNam WHERE MaSoKho={1} AND MaTaiKhoan={2} AND MaVattu={3} AND Luong_0>SoXuat ORDER BY MaSo", _
                                                                (IIf(pGiaUSD > 0, ",USDTien_0 AS F4", String.Empty)), _
                                                                mk, _
                                                                mt, _
                                                                mv), tien, ms, tien2, soton))
                    If luong <= 0 Then
                        nx = 1
                        luong = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 SoPS2No AS F1,SoPS AS F2,MaSo AS F3{0}, SoPS2No-SoXuat AS F5 FROM ChungTu WHERE (((MaLoai=13 OR MaLoai=1) AND MaKho={1}) OR (MaLoai=4 AND MaNguon={1})) AND MaTKNo={2} AND MaVattu={3} AND SoPS2No>SoXuat ORDER BY ThangCT, NgayGS, MaCT, MaSo", _
                                                                    (IIf(pGiaUSD > 0, ",PSUSD AS F4", String.Empty)), _
                                                                    mk, _
                                                                    mt, _
                                                                    mv), tien, ms, tien2, soton))
                    End If
                End If
                If soton > 0 And luong > 0 Then
                    m = ConvertToDblSafe(rsItem("MaSo"))
                    If ConvertToDblSafe(rsItem("SoPS2Co")) > soton Then
                        ctu.InitChungtu(m, 0, "", 0, DateTime.Today, DateTime.Today, 0, 0, "", 0, 0, 0, 0, 0, 0, "", 0, DateTime.Today)
                        ctu.SoPS2Co = ConvertToDblSafe(rsItem("SoPS2Co")) - soton
                        ctu.sops = 0
                        ctu.MaSo = 0
                        ctu.CT_ID = 0
                        ctu.GhiChungtu()
                        ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoPS2Co={0},SoPS=0 WHERE MaSo={1}", _
                                            doidau(soton), _
                                            ConvertToStrSafe(m)))
                        'UpgradeStubs.DAO_DBEngine.Idle(DBEngineHelper.Instance(Artinsoft.VB6.DB.AdoFactoryManager.GetFactory()))
                        'rs.Requery()
                        'rs.FindFirst("MaSo=" & m)
                        ' [C15_XetLai]
                    End If
                    soton -= ConvertToDblSafe(rsItem("SoPS2Co"))
                    ps = RoundMoney(ConvertToDblSafe(rsItem("SoPS2Co")) * tien / luong)
                    ps2 = RoundMoney(ConvertToDblSafe(rsItem("SoPS2Co")) * tien2 / luong)
                    ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoPS={0}, CT_ID=-{1}{2} WHERE MaSo={3}", _
                                        doidau(ps), _
                                        (IIf(nx = 0, 2000000000, 0)) + ms, _
                                        (IIf(pGiaUSD > 0, ",PSUSD=" & doidau(ps2), String.Empty)), _
                                        m))
                    If nx = 0 Then
                        ExecSQLNonQuery(String.Format("UPDATE VTDauNam SET SoXuat=SoXuat+{0} WHERE MaSo={1}", _
                                            CStr(ConvertToDblSafe(rsItem("SoPS2Co"))), _
                                            ms))
                    Else
                        ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoXuat=SoXuat+{0} WHERE MaSo={1}", _
                                            doidau(ConvertToDblSafe(rsItem("SoPS2Co"))), _
                                            ms))
                    End If
                    'UpgradeStubs.DAO_DBEngine.Idle(DBEngineHelper.Instance(Artinsoft.VB6.DB.AdoFactoryManager.GetFactory()))
                    ' [C15_XetLai]
                End If
            Next
            rs = Nothing
            ctu = Nothing
            If mv > 0 And ktra = 0 Then
                KiemTraTaiKhoan()
                KiemTraVatTu(1)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mdv"></param>
    ''' <param name="hsqd"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GiaBanQD(ByRef mdv As Integer, ByRef hsqd As Double) As Double
        Try
            Return ConvertToDblSafe(GetSelectValue(String.Format("SELECT GiaBan AS F1, TyLeQD AS F2 FROM DVTVattu WHERE MaSo={0}", mdv), hsqd))
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mk"></param>
    ''' <param name="mt"></param>
    ''' <param name="mv"></param>
    ''' <param name="sl"></param>
    ''' <param name="soluong"></param>
    ''' <param name="tien"></param>
    ''' <param name="id"></param>
    ''' <param name="tien2"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GiaXuatKhoFIFO(ByRef mk As Integer, ByRef mt As Integer, ByRef mv As Integer, ByRef sl As Double, ByRef soluong() As Double, ByRef tien() As Double, ByRef id() As Integer, ByRef tien2() As Double) As Integer
        Dim rs As DataTable
        Dim slx As Double = 0
        Dim T As Double = 0
        Dim L As Double = 0
        Dim t2 As Double = 0
        Dim c As Integer = 0
        Try
            If OutCost <> 2 Then
                Return 0
                Exit Function
            End If

            If sl = 0 Then
                rs = ExecSQLReturnDT(String.Format("SELECT MaSo, Tien_0 AS Tien,{0} AS Tien2 FROM VTDauNam WHERE MaSoKho={1} AND MaTaiKhoan={2} AND MaVattu={3} AND Luong_0=0 AND SoXuat=0 ORDER BY MaSo", _
                                         (IIf(pGiaUSD > 0, "USDTien_0", "0")), _
                                         mk, _
                                         mt, _
                                         mv))
                For Each rsItem As DataRow In rs.Rows
                    c += 1
                    ReDim Preserve soluong(c - 1)
                    ReDim Preserve tien(c - 1)
                    ReDim Preserve tien2(c - 1)
                    ReDim Preserve id(c - 1)
                    soluong(c) = 0
                    tien(c) = ConvertToDblSafe(rsItem("tien"))
                    tien2(c) = ConvertToDblSafe(rsItem("tien2"))
                    id(c) = -(2000000000 + ConvertToDblSafe(rsItem("MaSo")))
                Next
                rs = ExecSQLReturnDT(String.Format("SELECT MaSo, SoPS AS Tien,{0} AS Tien2 FROM ChungTu WHERE (((MaLoai=13 OR MaLoai=1) AND MaKho={1}) OR (MaLoai=4 AND MaNguon={1})) AND MaTKNo={2} AND SoPS2No=0 AND SoXuat=0 AND MaVattu={3} ORDER BY NgayGS, MaCT, MaSo", _
                                         (IIf(pGiaUSD > 0, "PSUSD", "0")), _
                                         mk, _
                                         mt, _
                                         mv))
                For Each rsItem As DataRow In rs.Rows
                    c += 1
                    ReDim Preserve soluong(c - 1)
                    ReDim Preserve tien(c - 1)
                    ReDim Preserve tien2(c - 1)
                    ReDim Preserve id(c - 1)
                    soluong(c) = 0
                    tien(c) = ConvertToDblSafe(rsItem("tien"))
                    tien2(c) = ConvertToDblSafe(rsItem("tien2"))
                    id(c) = -ConvertToDblSafe(rsItem("MaSo"))
                Next
            Else
                slx = sl
                rs = ExecSQLReturnDT(String.Format("SELECT MaSo, Luong_0-SoXuat AS LuongTon, Luong_0 AS Luong,SoXuat,Tien_0 AS Tien,{0} AS Tien2 FROM VTDauNam WHERE MaSoKho={1} AND MaTaiKhoan={2} AND MaVattu={3} AND Luong_0<>0 AND Luong_0>SoXuat ORDER BY MaSo", _
                                         (IIf(pGiaUSD > 0, "USDTien_0", "0")), _
                                         mk, _
                                         mt, _
                                         mv))
                For Each rsItem As DataRow In rs.Rows
                    L = IIf(slx > ConvertToDblSafe(rsItem("luongton")), ConvertToDblSafe(rsItem("luongton")), slx)
                    T = RoundMoney(L * ConvertToDblSafe(rsItem("tien")) / ConvertToDblSafe(rsItem("luong")))
                    t2 = RoundMoney(L * ConvertToDblSafe(rsItem("tien2")) / ConvertToDblSafe(rsItem("luong")))
                    c += 1
                    ReDim Preserve soluong(c - 1)
                    ReDim Preserve tien(c - 1)
                    ReDim Preserve tien2(c - 1)
                    ReDim Preserve id(c - 1)
                    soluong(c) = L
                    tien(c) = T
                    tien2(c) = t2
                    id(c) = -(2000000000 + ConvertToDblSafe(rsItem("MaSo")))
                    slx -= L
                Next
                If Not (slx = 0) Then
                    rs = ExecSQLReturnDT(String.Format("SELECT MaSo, SoPS2No-SoXuat AS Luong,SoPS2No,SoPS AS Tien,{0} AS Tien2 FROM ChungTu WHERE (((MaLoai=13 OR MaLoai=1) AND MaKho={1}) OR (MaLoai=4 AND MaNguon={1})) AND MaTKNo={2} AND SoPS2No-SoXuat>0 AND MaVattu={3} ORDER BY NgayGS, MaCT, MaSo", _
                                             (IIf(pGiaUSD > 0, "PSUSD", "0")), _
                                             mk, _
                                             mt, _
                                             mv))
                    For Each rsItem As DataRow In rs.Rows
                        L = IIf(slx > ConvertToDblSafe(rsItem("luong")), ConvertToDblSafe(rsItem("luong")), slx)
                        T = RoundMoney(L * ConvertToDblSafe(rsItem("tien")) / ConvertToDblSafe(rsItem("SoPS2No")))
                        t2 = RoundMoney(L * ConvertToDblSafe(rsItem("tien2")) / ConvertToDblSafe(rsItem("SoPS2No")))
                        c += 1
                        ReDim Preserve soluong(c - 1)
                        ReDim Preserve tien(c - 1)
                        ReDim Preserve tien2(c - 1)
                        ReDim Preserve id(c - 1)
                        soluong(c) = L
                        tien(c) = T
                        tien2(c) = t2
                        id(c) = -ConvertToDblSafe(rsItem("MaSo"))
                        slx -= L
                    Next
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return c
        End Try
        
        Return c
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mk"></param>
    ''' <param name="mt"></param>
    ''' <param name="mv"></param>
    ''' <param name="sl"></param>
    ''' <param name="soluong"></param>
    ''' <param name="tien"></param>
    ''' <param name="id"></param>
    ''' <param name="tien2"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GiaXuatKhoLIFO(ByRef mk As Integer, ByRef mt As Integer, ByRef mv As Integer, ByRef sl As Double, ByRef soluong() As Double, ByRef tien() As Double, ByRef id() As Integer, ByRef tien2() As Double) As Integer
        Dim L As Double = 0
        Dim T As Double = 0
        Dim t2 As Double = 0
        Dim c As Integer = 0
        If OutCost <> 3 Or sl = 0 Then
            Return 0
            Exit Function
        End If
        Dim slx As Double = sl
        Try
            Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT MaSo, SoPS2No-SoXuat AS Luong, SoPS2No,SoPS AS Tien,{0} AS Tien2 FROM ChungTu WHERE (((MaLoai=13 OR MaLoai=1) AND MaKho={1}) OR (MaLoai=4 AND MaNguon={1})) AND MaTKNo={2} AND SoPS2No-SoXuat>0 AND MaVattu={3} ORDER BY NgayGS DESC, MaCT DESC, MaSo DESC", _
                                                  (IIf(pGiaUSD > 0, "PSUSD", "0")), _
                                                  mk, _
                                                  mt, _
                                                  mv))
            For Each rsItem As DataRow In rs.Rows
                L = IIf(slx > ConvertToDblSafe(rsItem("luong")), ConvertToDblSafe(rsItem("luong")), slx)
                T = RoundMoney(L * ConvertToDblSafe(rsItem("tien")) / ConvertToDblSafe(rsItem("SoPS2No")))
                t2 = RoundMoney(L * ConvertToDblSafe(rsItem("tien2")) / ConvertToDblSafe(rsItem("SoPS2No")))
                c += 1
                ReDim Preserve soluong(c - 1)
                ReDim Preserve tien(c - 1)
                ReDim Preserve tien2(c - 1)
                ReDim Preserve id(c - 1)
                soluong(c) = L
                tien(c) = T
                tien2(c) = t2
                id(c) = -ConvertToDblSafe(rsItem("MaSo"))
                slx -= L
            Next
            If Not (slx = 0) Then
                rs = ExecSQLReturnDT(String.Format("SELECT MaSo, Luong_0 AS Luong,Tien_0 AS Tien,{0} AS Tien2 FROM VTDauNam WHERE MaSoKho={1} AND MaTaiKhoan={2} AND MaVattu={3} AND Luong_0<>0 AND Luong_0>SoXuat ORDER BY MaSo DESC", _
                                         (IIf(pGiaUSD > 0, "USDTien_0", "0")), _
                                         mk, _
                                         mt, _
                                         mv))
                For Each rsItem As DataRow In rs.Rows
                    L = IIf(slx > ConvertToDblSafe(rsItem("luong")), ConvertToDblSafe(rsItem("luong")), slx)
                    T = RoundMoney(L * ConvertToDblSafe(rsItem("tien")) / ConvertToDblSafe(rsItem("luong")))
                    t2 = RoundMoney(L * ConvertToDblSafe(rsItem("tien2")) / ConvertToDblSafe(rsItem("luong")))
                    c += 1
                    ReDim Preserve soluong(c - 1)
                    ReDim Preserve tien(c - 1)
                    ReDim Preserve tien2(c - 1)
                    ReDim Preserve id(c - 1)
                    soluong(c) = L
                    tien(c) = T
                    tien2(c) = t2
                    id(c) = -(2000000000 + ConvertToDblSafe(rsItem("MaSo")))
                    slx -= L
                Next
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return c
        End Try
        
        Return c
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mk"></param>
    ''' <param name="mt"></param>
    ''' <param name="mv"></param>
    ''' <param name="sl"></param>
    ''' <param name="soluong"></param>
    ''' <param name="tien"></param>
    ''' <param name="id"></param>
    ''' <param name="tien2"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GiaXuatKhoDD(ByRef mk As Integer, ByRef mt As Integer, ByRef mv As Integer, ByRef sl As Double, ByRef soluong() As Double, ByRef tien() As Double, ByRef id() As Integer, ByRef tien2() As Double) As Integer
        Dim T As Double = 0
        Dim slx As Double = 0
        Dim L As Double = 0
        Dim t2 As Double = 0
        Dim vt As New ClsVattu
        Dim id1 As Integer = 0
        Dim c As Integer = 0
        If OutCost <> 1 Or sl = 0 Then
            Return 0
            Exit Function
        End If
        Try
            vt.InitVattuMaSo(mv)
            Do While (slx < sl)
                FDsNhap.Tag = ConvertToStrSafe(mv)
                id1 = FDsNhap.XuatDichDanh(13, String.Format("{0} - {1}{2}{3}", _
                                                               vt.sohieu, _
                                                               vt.TenVattu, _
                                                               " - Đ.v.t: ", _
                                                               vt.DonVi), mk, L, T, t2)
                If L > 0 Then
                    'slx = slx + L
                    If slx + L > sl Then
                        t2 = sl * t2 / L
                        T = sl * T / L
                        L = sl - slx
                    End If
                    slx += L
                    c += 1
                    ReDim Preserve soluong(c - 1)
                    ReDim Preserve tien(c - 1)
                    ReDim Preserve tien2(c - 1)
                    ReDim Preserve id(c - 1)
                    soluong(c) = L
                    tien(c) = T
                    tien2(c) = t2
                    id(c) = -(id1)
                End If
            Loop
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return c
        End Try
        
        Return c
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="kx"></param>
    ''' <param name="kn"></param>
    ''' <param name="mvt"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="tien"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function XuatTheoKho(ByRef kx As Integer, ByRef kn As Integer, ByRef mvt As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef tien As Double) As Double
        Try
            Return ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS2Co) AS F1, Sum(SoPS) AS F2 FROM ChungTu WHERE MaLoai=4 AND MaKho={0} AND MaNguon={1} AND MaVattu={2} AND {3}", _
                                                   kx, _
                                                   kn, _
                                                   mvt, _
                                                   WNgay("NgayGS", ndau, ncuoi)), tien))
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="shtk"></param>
    ''' <param name="kx"></param>
    ''' <param name="MN"></param>
    ''' <param name="mvt"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="tien"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function XuatBan(ByRef shtk As String, ByRef kx As Integer, ByRef MN As Integer, ByRef mvt As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef tien As Double) As Double
        Try
            Return ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS2Co) AS F1, Sum(SoPS) AS F2 FROM {0} WHERE MaLoai=2 AND MaKho={1} AND MaNguon={2} AND HethongTK.SoHieu LIKE '632%' AND TK.SoHieu LIKE '{3}%' AND MaVattu={4} AND {5}", _
                                                   ChungTu2TKNC(0), _
                                                   kx, _
                                                   MN, _
                                                   shtk, _
                                                   mvt, _
                                                   WNgay("NgayGS", ndau, ncuoi)), tien))
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoCPTT(ByRef sh As String, ByRef tdau As Integer, ByRef tcuoi As Integer) As Double
        Try
            Return ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM {0} WHERE MaTP>0 AND HethongTK.SoHieu LIKE '{1}%' AND {2}", _
                                                   ChungTu2TKNC(-1), _
                                                   sh, _
                                                   WThang("ThangCT", tdau, tcuoi))))
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mvt"></param>
    ''' <remarks></remarks>
    Public Sub XDTyLeQD(ByRef mvt As Integer)
        Try
            'ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
            ''ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Kq1) SELECT MaVattu,ConvertToStrSafe(MaVattu),(TyLeQD) AS TL FROM DVTVattu {0} GROUP BY MaVattu", (iif(mvt > 0, "WHERE MaVattu=" & mvt, String.Empty))))
            'ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Kq1) SELECT MaVattu,ConvertToStrSafe(MaVattu),TyLeQD AS TL FROM DVTVattu {0} GROUP BY MaVattu", (IIf(mvt > 0, "WHERE MaVattu=" & mvt, String.Empty))))
            'ExecSQLNonQuery("UPDATE Vattu INNER JOIN BaoCaoCP2 ON Vattu.MaSo=BaoCaoCP2.MaSo SET TyLeQD=Kq1")
            ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
            'ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Kq1) SELECT MaVattu,ConvertToStrSafe(MaVattu),(TyLeQD) AS TL FROM DVTVattu {0} GROUP BY MaVattu", (iif(mvt > 0, "WHERE MaVattu=" & mvt, String.Empty))))
            Dim str1 As String = String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Kq1) SELECT MaVattu,MaVattu,TyLeQD AS TL FROM DVTVattu {0} GROUP BY MaVattu,TyLeQD", (IIf(mvt > 0, "WHERE MaVattu=" & mvt, String.Empty)))
            ExecSQLNonQuery(str1)
            Dim str2 As String = String.Format("UPDATE Vattu SET TyLeQD= (select top 1 Kq1 from vattu INNER JOIN BaoCaoCP2 ON Vattu.MaSo=BaoCaoCP2.MaSo )")
            ExecSQLNonQuery(str2)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mk"></param>
    ''' <param name="mtk"></param>
    ''' <param name="mvt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoTonTheoChungTu(ByRef mk As Integer, ByRef mtk As Integer, ByRef mvt As Integer) As Double
        If OutCost = 0 Then
            Return 0
            Exit Function
        End If
        Dim sodu As Double = 0
        Try
            sodu = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS2No-SoXuat) AS F1 FROM ChungTu WHERE (((MaLoai=13 OR MaLoai=1) AND MaKho={0}) OR (MaLoai=4 AND MaNguon={1})) AND MaTKNo={2} AND MaVattu={3} AND SoPS2No>SoXuat", _
                                                                 mk, _
                                                                 ConvertToStrSafe(mk), _
                                                                 ConvertToStrSafe(mtk), _
                                                                 ConvertToStrSafe(mvt))))
            sodu += ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(Luong_0-SoXuat) AS F1 FROM VTDauNam WHERE MaSoKho={0} AND MaTaiKhoan={1} AND MaVattu={2} AND Luong_0>SoXuat", _
                                                        mk, _
                                                        ConvertToStrSafe(mtk), _
                                                        ConvertToStrSafe(mvt))))
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return sodu
        End Try
        
        Return sodu
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ktraxuatvattu()
        Dim rs As DataTable
        Dim tien As Double = 0
        Dim ps As Double = 0
        Dim ms As Integer = 0
        Dim sql As String = String.Empty
        Try
            Select Case OutCost
                Case 1
                    ExecSQLNonQuery("UPDATE VTDauNam SET SoXuat=0")
                    sql = "SELECT ChungTu.MaSo,MaKho,MaTKCo,MaVattu,SoPS2Co,CT_ID FROM ChungTu INNER JOIN HethongTK ON ChungTu.MaTKCo=HethongTK.MaSo WHERE ABS(CT_ID)>2000000000 AND (MaLoai=2 OR MaLoai=4) AND MaVattu>0 AND TK_ID=" & TKVT_ID
                    rs = ExecSQLReturnDT(sql)
                    For Each rsItem As DataRow In rs.Rows
                        ms = Math.Abs(ConvertToDblSafe(rsItem("CT_ID"))) - 2000000000
                        If ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM VTDauNam WHERE MaSo={0}", ms))) = 0 Then
                            ms = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 MaSo AS F1 FROM VTDauNam WHERE MaSoKho={0} AND MaTaiKhoan={1} AND MaVattu={2}", _
                                                                     rsItem("MaKho"), _
                                                                     rsItem("MaTkCo"), _
                                                                     rsItem("MaVattu"))))
                            If ms > 0 Then
                                ExecSQLNonQuery(String.Format("UPDATE VTDauNam SET SoXuat=SoXuat+{0} WHERE MaSo={1}", _
                                                    CStr(ConvertToDblSafe(rsItem("SoPS2Co"))), _
                                                    ms))
                                ExecSQLNonQuery(String.Format("UPDATE ChungTu SET CT_ID={0} WHERE MaSo={1}", _
                                                    -(2000000000 - ms), _
                                                    rsItem("MaSo")))
                            End If
                        Else
                            ExecSQLNonQuery(String.Format("UPDATE VTDauNam SET SoXuat=SoXuat+{0} WHERE MaSo={1}", _
                                                rsItem("SoPS2Co"), _
                                                ms))
                        End If
                    Next
                    Exit Select
                Case 2
                    rs = ExecSQLReturnDT("SELECT MaSoKho, MaTaiKhoan, MaVattu,Luong_12 AS SoDu FROM TonKho INNER JOIN HethongTK ON TonKho.MaTaiKhoan=HethongTK.MaSo")
                    For Each rsItem As DataRow In rs.Rows
                        If ConvertToDblSafe(rsItem("sodu")) <> SoTonTheoChungTu(ConvertToDblSafe(rsItem("MaSoKho")), ConvertToDblSafe(rsItem("MaTaiKhoan")), ConvertToDblSafe(rsItem("MaVattu"))) Then
                            ExecSQLNonQuery(String.Format("UPDATE VTDauNam SET SoXuat=Luong_0 WHERE MaSoKho={0} AND MaTaiKhoan={1} AND MaVattu={2}", _
                                                ConvertToDblSafe(rsItem("MaSoKho")), _
                                                ConvertToDblSafe(rsItem("MaTaiKhoan")), _
                                                ConvertToDblSafe(rsItem("MaVattu"))))
                            ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoXuat=SoPS2No WHERE (((MaLoai=13 OR MaLoai=1) AND MaKho={0}) OR (MaLoai=4 AND MaNguon={0})) AND MaTKNo={1} AND MaVattu={2}", _
                                                ConvertToDblSafe(rsItem("MaSoKho")), _
                                                ConvertToDblSafe(rsItem("MaTaiKhoan")), _
                                                ConvertToDblSafe(rsItem("MaVattu"))))
                            tien = 0
                            Do While tien < ConvertToDblSafe(rsItem("sodu"))
                                ms = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 MaSo AS F1,SoPS2No AS F2 FROM ChungTu WHERE (((MaLoai=13 OR MaLoai=1) AND MaKho={0}) OR (MaLoai=4 AND MaNguon={0})) AND MaTKNo={1} AND MaVattu={2} AND SoPS2No<=SoXuat AND SoPS2No>0 ORDER BY NgayGS DESC, MaCT DESC", _
                                                                         rsItem("MaSoKho"), _
                                                                         rsItem("MaTaiKhoan"), _
                                                                         rsItem("MaVattu")), ps))
                                If ms > 0 Then
                                    If ps > ConvertToDblSafe(rsItem("sodu")) - tien Then
                                        ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoXuat=SoPS2No-{0} WHERE MaSo={1}", _
                                                            doidau(ConvertToDblSafe(rsItem("sodu")) - tien), _
                                                            ConvertToStrSafe(ms)))
                                        tien = ConvertToDblSafe(rsItem("sodu"))
                                    Else
                                        ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoXuat=0 WHERE MaSo={0}", ms))
                                        tien += ps
                                    End If
                                Else
                                    ms = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 MaSo AS F1,Luong_0 AS F2 FROM VTDauNam WHERE MaSoKho={0} AND MaTaiKhoan={1} AND MaVattu={2} AND Luong_0<=SoXuat AND Luong_0<>0 ORDER BY NgayGS DESC, MaCT DESC", _
                                                                             ConvertToDblSafe(rsItem("MaSoKho")), _
                                                                             ConvertToDblSafe(rsItem("MaTaiKhoan")), _
                                                                             ConvertToDblSafe(rsItem("MaVattu"))), ps))
                                    If ms > 0 Then
                                        If ps > ConvertToDblSafe(rsItem("sodu")) - tien Then
                                            ExecSQLNonQuery(String.Format("UPDATE VTDauNam SET SoXuat=SoXuat-{0} WHERE MaSo={1}", _
                                                                doidau(ConvertToDblSafe(rsItem("sodu")) - tien), _
                                                                ConvertToStrSafe(ms)))
                                            tien = ConvertToDblSafe(rsItem("sodu"))
                                        Else
                                            ExecSQLNonQuery(String.Format("UPDATE VTDauNam SET SoXuat=Luong_0 WHERE MaSo={0}", ms))
                                            tien += ps
                                        End If
                                    Else
                                        Exit Do
                                    End If
                                End If
                            Loop
                        End If
                    Next
                    Exit Select
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mvt"></param>
    ''' <param name="mdv"></param>
    ''' <param name="tendv"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function KtraDVT(ByRef mvt As Integer, ByRef mdv As Integer, ByRef tendv As String) As Boolean
        Try
            Return ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1, DonVi AS F2 FROM DVTVattu WHERE MaSo={0} AND MaVattu={1}", _
                                                   mdv, _
                                                   ConvertToStrSafe(mvt)), tendv)) > 0
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <param name="shtk"></param>
    ''' <remarks></remarks>
    Public Sub TinhTonVT(ByRef thang As Integer, ByRef shtk As String)
        Try
            ExecSQLNonQuery("UPDATE Vattu SET L=0,T=0")
            Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT MaVattu, Sum(Luong_{0}) AS L, Sum(Tien_{1}) AS T FROM TonKho INNER JOIN HethongTK ON TonKho.MaTaiKhoan=HethongTK.MaSo WHERE HethongTK.SoHieu LIKE '{2}%' GROUP BY MaVattu", _
                                                      CThangDB2(thang), _
                                                      ConvertToStrSafe(CThangDB2(thang)), _
                                                      shtk))
            For Each rsItem As DataRow In rs.Rows
                ExecSQLNonQuery(String.Format("UPDATE Vattu SET L={0},T={1} WHERE MaSo={2}", _
                                    CStr(ConvertToDblSafe(rsItem("L"))), _
                                    CStr(ConvertToDblSafe(rsItem("T"))), _
                                    ConvertToDblSafe(rsItem("MaVattu"))))
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="shvt"></param>
    ''' <param name="tkno"></param>
    ''' <param name="ktra"></param>
    ''' <remarks></remarks>
    Public Sub TinhGXKBQ(ByRef tdau As Integer, _
        ByRef tcuoi As Integer, _
        ByRef shvt As String, _
        ByRef tkno As String, _
        Optional ByRef ktra As Integer = 0)
        Dim tien As Double = 0
        Dim luong As Double = 0
        Dim sql As String = String.Empty
        Dim mv As Integer = 0
        Dim mk As Integer = 0
        Dim mt As Integer = 0
        Dim thang As Integer = 0
        Dim n As Date
        Dim dgia As Double = 0
        Dim tien2 As Double = 0
        Dim tienx As Double = 0
        Dim tienx2 As Double = 0
        Dim dgia2 As Double = 0
        Dim soct As Integer = 0
        Dim Counter As Integer = 0
        If shvt = "0" Then shvt = ""
        Try
            ExecSQLNonQuery(String.Format("UPDATE ChungTu SET MaTKNo=MaTKCo,MaTKTCNo=MaTKTCCo WHERE ChungTu.MaTKNo in (select ChungTu.MaTKNo from {0} WHERE MaLoai=4 AND HethongTK.Cap=0 AND HethongTK.Loai=0 AND TK.Loai>0)", ChungTu2TKNC(0)))
            'ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoPS=CAST(CASE WHEN SoPS>=0 THEN 0.5 ELSE -0.5 END + SoPS AS INT), SoPS2Co=CAST(CASE WHEN SoPS2Co>=0 THEN 0.5 ELSE -0.5 END +SoPS2Co*{0} AS INT)/{1}", _
            '                    Mask_N, _
            '                    Mask_N))
            If OutCost > 0 Then Exit Sub
            If tkno.Length > 0 Then
                sql = String.Format("SELECT DISTINCT ChungTu.MaSo,ThangCT,NgayGS,MaCT,MaKho,MaVattu,MaTKCo,SoPS,SoPS2Co{0} FROM ({1}) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo WHERE HethongTK.SoHieu LIKE '{2}%' AND (MaLoai=2 OR MaLoai=4) AND MaVattu>0 AND MaTKNo>0 AND TK.TK_ID={3} AND SoPS2Co>0 AND {4}{5} ORDER BY MaKho,MaTKCo,MaVattu,ThangCT,NgayGS,ChungTu.MaCT", _
                          (IIf(pGiaUSD > 0, ",PSUSD", String.Empty)), _
                          ChungTu2TKNC(0), _
                          tkno, _
                          TKVT_ID, _
                          WThang("ThangCT", tdau, tcuoi), _
                          IIf(shvt.Length > 0, String.Format(" AND Vattu.SoHieu=N'{0}'", shvt), String.Empty))
            Else
                sql = String.Format("SELECT DISTINCT ChungTu.MaSo,ThangCT,NgayGS,MaCT,MaKho,MaVattu,MaTKCo,SoPS,SoPS2Co{0} FROM ({1}) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo WHERE (MaLoai=2 OR MaLoai=4) AND MaVattu>0 AND HethongTK.TK_ID={2} AND SoPS2Co>0 AND {3}{4} ORDER BY MaKho,MaTKCo,MaVattu,ThangCT,NgayGS,ChungTu.MaCT", _
                          (IIf(pGiaUSD > 0, ",PSUSD", String.Empty)), _
                          ChungTu2TKNC(1), _
                          TKVT_ID, _
                          WThang("ThangCT", tdau, tcuoi), _
                          IIf(shvt.Length > 0, String.Format(" AND Vattu.SoHieu=N'{0}'", shvt), String.Empty))
            End If
            Dim rs As DataTable = ExecSQLReturnDT(sql)
            soct = rs.Rows.Count
            For Each rsItem As DataRow In rs.Rows
                Counter += 1
                If mk <> ConvertToDblSafe(rsItem("MaKho")) Or mt <> ConvertToDblSafe(rsItem("MaTkCo")) Or mv <> ConvertToDblSafe(rsItem("MaVattu")) Or thang <> ConvertToDblSafe(rsItem("ThangCT")) Then
                    n = ConvertToDateSafe(rsItem("NgayGS"))
                    mk = ConvertToDblSafe(rsItem("MaKho"))
                    mt = ConvertToDblSafe(rsItem("MaTkCo"))
                    mv = ConvertToDblSafe(rsItem("MaVattu"))
                    thang = ConvertToDblSafe(rsItem("ThangCT"))
                    luong = SoTonKho(ThangTruoc(thang), mk, mt, mv, tien, tien2)
                    luong += SoNhapKhoThang(mk, mt, mv, thang, thang, tienx, tienx2)
                    tien += tienx
                    tien2 += tienx2
                    dgia = IIf(luong <> 0, Math.Abs(tien / luong), 0)
                    dgia2 = IIf(luong <> 0, Math.Abs(tien2 / luong), 0)
                End If
                If Math.Abs(luong - ConvertToDblSafe(rsItem("SoPS2Co"))) < (1 / Mask_N) Then
                    tienx = tien
                    luong = 0
                Else
                    luong -= ConvertToDblSafe(rsItem("SoPS2Co"))
                    tienx = RoundMoney(dgia * ConvertToDblSafe(rsItem("SoPS2Co")))
                End If
                tien -= tienx
                If tienx <> ConvertToDblSafe(rsItem("sops")) Then ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoPS={0} WHERE MaSo={1}", _
                                                                                      doidau(tienx), _
                                                                                      rsItem("MaSo")))
                If pGiaUSD > 0 Then
                    If luong - ConvertToDblSafe(rsItem("SoPS2Co")) < (1 / Mask_N) Then
                        tienx2 = tien2
                    Else
                        tienx2 = RoundMoney(dgia2 * ConvertToDblSafe(rsItem("SoPS2Co")))
                    End If
                    tien2 -= tienx2
                    If tienx2 <> ConvertToDblSafe(rsItem("PSUSD")) Then ExecSQLNonQuery(String.Format("UPDATE ChungTu SET PSUSD={0} WHERE MaSo={1}", _
                                                                                            doidau(tienx2), _
                                                                                            rsItem("MaSo")))
                End If
                If Counter Mod 100 = 0 Then HienThongBao(String.Format("Đã xử lý {0}% tổng số chứng từ", (IIf(100 * Counter / soct > 0, Math.Floor(100 * Counter / soct), Math.Ceiling(100 * Counter / soct)))), 1)
            Next
            If mv > 0 And ktra = 0 Then
                KiemTraTaiKhoan(1)
                KiemTraVatTu(1)
            End If
            HienThongBao("", 1)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub KtraCtuGV()
        Dim chiso As Integer = 0
        Try
            Dim QChungTuBanHang As String = "SELECT ChungTu.ThangCT, ChungTu.SoHieu, ChungTu.NgayCT, Sum(ChungTu.SoPS2Co) AS SumOfSoPS2Co, ChungTu.MaVattu, ChungTu.MaKho, Vattu.SoHieu, Vattu.TenVattu  FROM (ChungTu INNER JOIN HeThongTK ON ChungTu.MaTKCo = HeThongTK.MaSo) INNER JOIN Vattu ON ChungTu.MaVattu = Vattu.MaSo  WHERE (((chungtu.maloai) = 8) AND ((HeThongTK.tk_id) = 5000))  GROUP BY ChungTu.ThangCT, ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.MaVattu, ChungTu.MaKho, Vattu.SoHieu, Vattu.TenVattu, ChungTu.MaCT"
            Dim QChungTuGiaVon As String = "SELECT ChungTu.ThangCT, ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.MaKho, Sum(ChungTu.SoPS2Co) AS SumOfSoPS2Co, ChungTu.MaTKNo, ChungTu.MaVattu  FROM ChungTu INNER JOIN HeThongTK ON ChungTu.MaTKNo = HeThongTK.MaSo WHERE (((ChungTu.MaLoai)=2) AND ((HeThongTK.SoHieu) LIKE '632%')) GROUP BY ChungTu.MaCT, ChungTu.ThangCT, ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.MaKho, ChungTu.MaTKNo, ChungTu.MaVattu"
            Dim Mientru As String = String.Format("SELECT QChungTuBanHang.MaVattu FROM ({0}) AS QChungTuBanHang INNER JOIN ({1}) AS QChungtuGiaVon ON (QChungTuBanHang.ChungTu.SoHieu+'GV'=QChungTuGiaVon.SoHieu) AND (QChungTuBanHang.MaKho = QChungtuGiaVon.MaKho) AND (QChungTuBanHang.MaVattu = QChungtuGiaVon.MaVattu) AND (QChungTuBanHang.SumOfSoPS2Co<>QChungTuGiaVon.SumOfSoPS2Co) GROUP BY QChungTuBanHang.MaVattu", _
                                        QChungTuBanHang, _
                                        QChungTuGiaVon)
            Dim rs As DataTable = ExecSQLReturnDT(Mientru)
            Dim tongso As Integer = rs.Rows.Count
            For Each rsItem As DataRow In rs.Rows
                chiso += 1
                TinhGVBH(NgayDauThang(pNamTC, pThangDauKy), NgayCuoiNam(), 1, ConvertToDblSafe(rsItem("MaVattu"), 1))
                HienThongBao(String.Format("Đã xử lý {0} danh điểm vật tư, {1} % tổng số cần kiểm tra!", _
                                 chiso, _
                                 ConvertToStrSafe(IIf(100 * chiso / tongso > 0, Math.Floor(100 * chiso / tongso), Math.Ceiling(100 * chiso / tongso)))), 1)
            Next
            If rs.Rows.Count > 0 Then
                KiemTraTaiKhoan(1)
                KiemTraVatTu(1)
            End If
            HienThongBao("", 1)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="shvt"></param>
    ''' <param name="tkno"></param>
    ''' <param name="ktra"></param>
    ''' <remarks></remarks>
    Public Sub Backup_TinhGXK(ByRef tdau As Integer, _
        ByRef tcuoi As Integer, _
        ByRef shvt As String, _
        ByRef tkno As String, _
        Optional ByRef ktra As Integer = 0)
        Dim tien As Double = 0
        Dim luong As Double = 0
        Dim sql As String = String.Empty
        Dim mv As Integer = 0
        Dim mk As Integer = 0
        Dim mt As Integer = 0
        Dim n As Date
        Dim tien2 As Double = 0
        Dim tienx As Double = 0
        Dim luongx As Double = 0
        Dim tienx2 As Double = 0
        Try
            ExecSQLNonQuery(String.Format("UPDATE {0} SET MaTKNo=MaTKCo,MaTKTCNo=MaTKTCCo WHERE MaLoai=4 AND HethongTK.Cap=0 AND HethongTK.Loai=0 AND TK.Loai>0", ChungTu2TKNC(0)))
            'ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoPS=CAST(CASE WHEN SoPS>=0 THEN 0.5 ELSE -0.5 END + SoPS AS INT), SoPS2Co=CAST(CASE WHEN SoPS2Co>=0 THEN 0.5 ELSE -0.5 END + SoPS2Co*{0} AS INT)/{1}", _
            '                    Mask_N, _
            '                    Mask_N))
            If OutCost > 0 Then Exit Sub
            If tkno.Length > 0 Then
                sql = String.Format("SELECT DISTINCT ChungTu.MaSo,NgayGS,MaCT,MaKho,MaVattu,MaTKCo,SoPS,SoPS2Co{0} FROM ({1}) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo WHERE HethongTK.SoHieu LIKE '{2}%' AND (MaLoai=2 OR MaLoai=4) AND MaVattu>0 AND MaTKNo>0 AND TK.TK_ID={3} AND SoPS2Co>0 AND {4}{5} ORDER BY MaKho,MaTKCo,MaVattu,NgayGS,ChungTu.MaCT", _
                          (IIf(pGiaUSD > 0, ",PSUSD", String.Empty)), _
                          ChungTu2TKNC(0), _
                          tkno, _
                          ConvertToStrSafe(TKVT_ID), _
                          WThang("ThangCT", tdau, tcuoi), _
                          (IIf(shvt.Length > 0, String.Format(" AND Vattu.SoHieu=N'{0}'", shvt), String.Empty)))
            Else
                sql = String.Format("SELECT DISTINCT ChungTu.MaSo,NgayGS,MaCT,MaKho,MaVattu,MaTKCo,SoPS,SoPS2Co{0} FROM ({1}) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo WHERE (MaLoai=2 OR MaLoai=4) AND MaVattu>0 AND HethongTK.TK_ID={2} AND SoPS2Co>0 AND {3}{4} ORDER BY MaKho,MaTKCo,MaVattu,NgayGS,ChungTu.MaCT", _
                          (IIf(pGiaUSD > 0, ",PSUSD", String.Empty)), _
                          ChungTu2TKNC(1), _
                          ConvertToStrSafe(TKVT_ID), _
                          WThang("ThangCT", tdau, tcuoi), _
                          (IIf(shvt.Length > 0, String.Format(" AND Vattu.SoHieu=N'{0}'", shvt), String.Empty)))
            End If
            Dim rs As DataTable = ExecSQLReturnDT(sql)
            For Each rsItem As DataRow In rs.Rows
                If mk <> ConvertToDblSafe(rsItem("MaKho")) Or mt <> ConvertToDblSafe(rsItem("MaTkCo")) Or mv <> ConvertToDblSafe(rsItem("MaVattu")) Then
                    n = ConvertToDateSafe(rsItem("NgayGS"))
                    mk = ConvertToDblSafe(rsItem("MaKho"))
                    mt = ConvertToDblSafe(rsItem("MaTkCo"))
                    mv = ConvertToDblSafe(rsItem("MaVattu"))
                    luong = SoTonKhoN2(n, mk, mt, mv, tien, ConvertToDblSafe(rsItem("MaCT")), tien2)
                Else
                    If n <> ConvertToDateSafe(rsItem("NgayGS")) Then
                        If tkno.Length > 0 Then
                            luong = SoTonKhoN2(ConvertToDateSafe(rsItem("NgayGS")), mk, mt, mv, tien, ConvertToDblSafe(rsItem("MaCT")), tien2)
                        Else
                            luong += SoNhapKho(mk, mt, mv, n.AddDays(1), ConvertToDateSafe(rsItem("NgayGS")), tienx, tienx2)
                            tien += tienx
                            tien2 += tienx2
                        End If
                        n = ConvertToDateSafe(rsItem("NgayGS"))
                    End If
                End If
                If tien = 0 Then
                    tienx = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 SoPS AS F1,SoPS2Co AS F2 FROM ChungTu WHERE (MaLoai=2 OR MaLoai=4) AND MaKho={0} AND MaTKCo={1} AND MaVattu={2} AND NgayGS<=N'{3}' AND MaCT<{4}", _
                                                                mk, _
                                                                ConvertToStrSafe(mt), _
                                                                ConvertToStrSafe(mv), _
                                                                Format(n, Mask_DB), _
                                                                ConvertToDblSafe(String.Format("{0} AND SoPS<>0 AND SoPS2Co<>0 ORDER BY NgayGS DESC, MaCT DESC", rsItem("MaCT")), luongx))))
                    If tienx = 0 Then
                        tienx = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 SoPS AS F1,SoPS2No AS F2 FROM ChungTu WHERE (((MaLoai=13 OR MaLoai=1) AND MaKho={0}) OR (MaLoai=4 AND MaNguon={1})) AND MaTKNo={2} AND MaVattu={3} AND NgayGS>'{4}' AND SoPS<>0 AND SoPS2No<>0 ORDER BY NgayGS", _
                                                                    mk, _
                                                                    ConvertToStrSafe(mk), _
                                                                    ConvertToStrSafe(mt), _
                                                                    ConvertToStrSafe(mv), _
                                                                    Format(n, Mask_DB)), luongx))
                    End If
                    If luongx <> 0 And luongx <> ConvertToDblSafe(rsItem("SoPS2Co")) Then tienx = RoundMoney(tienx * ConvertToDblSafe(rsItem("SoPS2Co")) / luongx)
                Else
                    luong = (IIf((IIf(luong >= 0, 0.5, -0.5)) + luong * Mask_N > 0, Math.Floor((IIf(luong >= 0, 0.5, -0.5)) + luong * Mask_N), Math.Ceiling((IIf(luong >= 0, 0.5, -0.5)) + luong * Mask_N))) / Mask_N
                    tienx = IIf(luong <> 0 And luong <> ConvertToDblSafe(rsItem("SoPS2Co")), RoundMoney(tien * ConvertToDblSafe(rsItem("SoPS2Co")) / luong), tien)
                End If
                tienx = Math.Abs(tienx)
                If tkno.Length = 0 Then
                    luong -= ConvertToDblSafe(rsItem("SoPS2Co"))
                    tien -= tienx
                End If
                If tienx <> ConvertToDblSafe(rsItem("sops")) Then ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoPS={0} WHERE MaSo={1}", CStr(tienx), ConvertToDblSafe(rsItem("MaSo"))))
                If pGiaUSD > 0 Then
                    If tien2 = 0 Then
                        tienx2 = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 PSUSD AS F1,SoPS2Co AS F2 FROM ChungTu WHERE (MaLoai=2 OR MaLoai=4) AND MaKho={0} AND MaTKCo={1} AND MaVattu={2} AND NgayGS<=N'{3}' AND MaCT<{4} AND SoPS<>0 AND SoPS2Co<>0 ORDER BY NgayGS DESC, MaCT DESC", _
                                                                     mk, _
                                                                     ConvertToStrSafe(mt), _
                                                                     ConvertToStrSafe(mv), _
                                                                     Format(n, Mask_DB), _
                                                                     ConvertToDblSafe(rsItem("MaCT"))), luongx))
                        If tienx2 = 0 Then
                            tienx2 = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 PSUSD AS F1,SoPS2No AS F2 FROM ChungTu WHERE (((MaLoai=13 OR MaLoai=1) AND MaKho={0}) OR (MaLoai=4 AND MaNguon={1})) AND MaTKNo={2} AND MaVattu={3} AND NgayGS>'{4}' AND SoPS<>0 AND SoPS2No<>0 ORDER BY NgayGS", _
                                                                         mk, _
                                                                         ConvertToStrSafe(mk), _
                                                                         ConvertToStrSafe(mt), _
                                                                         ConvertToStrSafe(mv), _
                                                                         Format(n, Mask_DB)), luongx))
                        End If
                        If luongx <> 0 And luongx <> ConvertToDblSafe(rsItem("SoPS2Co")) Then tienx2 = (IIf(0.5 + Mask_N * tienx2 * ConvertToDblSafe(rsItem("SoPS2Co")) / luongx > 0, Math.Floor(0.5 + Mask_N * tienx2 * ConvertToDblSafe(rsItem("SoPS2Co")) / luongx), Math.Ceiling(0.5 + Mask_N * tienx2 * ConvertToDblSafe(rsItem("SoPS2Co")) / luongx))) / Mask_N
                    Else
                        luong = (IIf((IIf(luong >= 0, 0.5, -0.5)) + luong * Mask_N > 0, Math.Floor((IIf(luong >= 0, 0.5, -0.5)) + luong * Mask_N), Math.Ceiling((IIf(luong >= 0, 0.5, -0.5)) + luong * Mask_N))) / Mask_N
                        tienx2 = IIf(luong <> 0 And luong <> ConvertToDblSafe(rsItem("SoPS2Co")), (IIf(0.5 + Mask_N * tien2 * ConvertToDblSafe(rsItem("SoPS2Co")) / luong > 0, Math.Floor(0.5 + Mask_N * tien2 * ConvertToDblSafe(rsItem("SoPS2Co")) / luong), Math.Ceiling(0.5 + Mask_N * tien2 * ConvertToDblSafe(rsItem("SoPS2Co")) / luong))) / Mask_N, tien2)
                    End If
                    tienx2 = Math.Abs(tienx2)
                    If tkno.Length = 0 Then
                        luong -= ConvertToDblSafe(rsItem("SoPS2Co"))
                        tien2 -= tienx2
                    End If
                    If tienx2 <> ConvertToDblSafe(rsItem("PSUSD")) Then ExecSQLNonQuery(String.Format("UPDATE ChungTu SET SoPS={0} WHERE MaSo={1}", _
                                                                                            CStr(tienx2), _
                                                                                            ConvertToDblSafe(rsItem("MaSo"))))
                End If
            Next
            If mv > 0 And ktra = 0 Then
                KiemTraTaiKhoan(1)
                KiemTraVatTu(1)
            End If
            'Beep
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub ChuyennammoiThanhPhamDD()
        Dim rs1 As DataTable
        Try
            Dim rs As DataTable = ExecSQLReturnDT("SELECT matp,max(thang) AS thangdd FROM thanhphamdd group by matp")
            For Each rsItem As DataRow In rs.Rows
                rs1 = ExecSQLReturnDT(String.Format("SELECT * FROM thanhphamdd WHERE thang={0} AND matp={1}", rsItem("thangdd"), rsItem("MaTP")))
                If rs1.Rows.Count > 0 Then
                    Dim rs1RowItem As DataRow = rs1.Rows(0)
                    ExecSQLNonQuery(String.Format("INSERT INTO thanhpham(Maso, MaCT, Sohieu, Thang, Ngay, MakhoTP, MakhoNVL, MaTK, MaTP, SoLuong, MaTKCP, MaTKNC, MaTKSX, CPNVL, CPNC, CPSXC, CPBH, CPQL, MaTKKH, CPKH, Ma154, GiaThanh, XK, CPTC, PLTH, NVLPL, TyLe, DonGia, DDDK) VALUES({0},{1}, N'{2}',0, N'{3}',{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22}, N'{23}',{24},{25},{26},{27})", _
                                       ConvertToStrSafe(Lng_MaxValue("MaSo", "ThanhPham") + 1), _
                                       rs1RowItem("MaCT"), _
                                       rs1RowItem("SoHieu"), _
                                       CDate(rs1RowItem("Ngay").ToString()), _
                                       rs1RowItem("MaKhoTP"), _
                                       rs1RowItem("MaKhoNVL"), _
                                       rs1RowItem("MaTK"), _
                                       rs1RowItem("MaTP"), _
                                       rs1RowItem("soluong"), _
                                       rs1RowItem("MaTKCP"), _
                                       rs1RowItem("MaTKNC"), _
                                       rs1RowItem("MaTKSX"), _
                                       rs1RowItem("CPNVL"), _
                                       rs1RowItem("cpnc"), _
                                       rs1RowItem("cpsxc"), _
                                       rs1RowItem("cpbh"), _
                                       rs1RowItem("cpql"), _
                                       rs1RowItem("MaTKKH"), _
                                       rs1RowItem("cpkh"), _
                                       rs1RowItem("Ma154"), _
                                       rs1RowItem("GiaThanh"), _
                                       rs1RowItem("xk"), _
                                       rs1RowItem("cptc"), _
                                       rs1RowItem("PLTH"), _
                                       rs1RowItem("NVLPL"), _
                                       rs1RowItem("TyLe"), _
                                       rs1RowItem("dongia"), _
                                       rs1RowItem("makt")))
                End If
            Next
            rs = Nothing
            rs1 = Nothing
            ExecSQLNonQuery("DELETE FROM thanhphamdd")
            ExecSQLNonQuery("INSERT INTO thanhphamdd(Maso1,Maso, MaCT, Sohieu, Thang, Ngay, MakhoTP, MakhoNVL, MaTK, MaTP, SoLuong, MaTKCP, MaTKNC, MaTKSX, CPNVL, CPNC, CPSXC, CPBH, CPQL, MaTKKH, CPKH, Ma154, GiaThanh, XK, CPTC, PLTH, NVLPL, TyLe, DonGia, MaKT) " & " SELECT Maso,Maso, MaCT, Sohieu, Thang, Ngay, MakhoTP, MakhoNVL, MaTK, MaTP, SoLuong, MaTKCP, MaTKNC, MaTKSX, CPNVL, CPNC, CPSXC, CPBH, CPQL, MaTKKH, CPKH, Ma154, GiaThanh, XK, CPTC, PLTH, NVLPL, TyLe, DonGia, DDDK FROM ThanhPham")
            ExecSQLNonQuery("DELETE FROM thanhpham")
            ExecSQLNonQuery("UPDATE thanhphamdd SET maso=0,mact=0")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Lapbangke()
        Dim d2, d1 As Date
        Dim rs As DataTable
        Dim MaCT As Integer = 0
        Dim sh = String.Empty
        Dim kh As String = String.Empty
        Dim TyLe As Integer = 0
        Dim mact2 As Integer = 0
        Dim mact1 As Integer = 0
        Dim dem As Integer = 0
        Dim tienct As Double = 0
        Dim tienhd As Double = 0
        Dim rs1 As DataTable
        Try
            If myUMessager.mQuestion(Ngonngu("Tất cả các bảng kê lập trong ngày sẽ được tổng hợp thành một bảng kê?", "All lists made during the day will be imported into a list?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> System.Windows.Forms.DialogResult.Yes Then Exit Sub
            If Not GetDate2.GetDate(Ngonngu("Lập bảng kê các ngày", "Make a list of the day"), d1, d2) Then Exit Sub

            Dim tempDT As Date = d1
            'van.nguyen 19-Nov-2011
            If d1 > d2 Then
                d1 = d2
                d2 = tempDT
            End If

            For van As Long = 0 To (DateDiff(DateInterval.Day, d1, d2) - 1)
                Dim i As Date = DateAdd(DateInterval.Day, van, d1)

                rs = ExecSQLReturnDT(String.Format("SELECT distinct hoadon.thanhtien,hoadon.tyle,hoadon.maso,chungtu.mact,chungtu.sohieu,chungtu.ngayct,chungtu.ngaygs,hoadon.kyhieu FROM chungtu inner join hoadon on chungtu.maso=hoadon.maso WHERE hoadon.hdbl=1 AND hoadon.loai=1 AND chungtu.ngaygs=N'{0}' ORDER BY hoadon.tyle", Format(i, Mask_DB)))
                If rs.Rows.Count <> 0 And sh = "" Then
                    sh = rs.Rows(0)("SoHieu")
                    kh = rs.Rows(0)("KyHieu")
                End If
                TyLe = 0
                For Each rsItem As DataRow In rs.Rows
                    If ConvertToDblSafe(rsItem("TyLe")) <> TyLe Then
                        dem = 1
                        tienct = 0
                        tienhd = 0
                        TyLe = ConvertToDblSafe(rsItem("TyLe"))
                        sh = FrmGetStr.GetString(Ngonngu("Số hóa đơn", "Invoice number"), My.Application.Info.ProductName, ConvertToStrSafe(ConvertToDblSafe(sh) + 1))
                        If sh = "" Then Exit Sub
                        While ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(maso)AS f1 FROM chungtu WHERE sohieu=N'{0}'", sh))) > 0
                            myUMessager.mInformation(Ngonngu("Số hóa đơn", "Invoice number"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            sh = FrmGetStr.GetString(Ngonngu("Số hóa đơn", "Invoice number"), My.Application.Info.ProductName, ConvertToStrSafe(ConvertToDblSafe(sh) + 1))
                            If sh = "" Then Exit Sub
                        End While
                        kh = FrmGetStr.GetString(Ngonngu("Ký hiệu hóa đơn", "Notation"), My.Application.Info.ProductName, kh).ToUpper()
                        If kh = "" Then Exit Sub
                        mact1 = ConvertToDblSafe(GetSelectValue(String.Format("SELECT mact AS f1 FROM chungtu WHERE sohieu=N'{0}GV'", rsItem("SoHieu"))))
                        MaCT = ConvertToDblSafe(GetSelectValue(String.Format("SELECT mact AS f1 FROM chungtu WHERE sohieu=N'{0}'", rsItem("SoHieu"))))
                    End If
                    mact2 = ConvertToDblSafe(GetSelectValue(String.Format("SELECT mact AS f1 FROM chungtu WHERE sohieu=N'{0}", rsItem("SoHieu" + "GV'"))))
                    ExecSQLNonQuery(String.Format("UPDATE chungtu SET mact={0},sohieu=N'{1}GV' WHERE mact={2}", mact1, sh, mact2))
                    rs1 = ExecSQLReturnDT(String.Format("SELECT distinct hoadon.maso FROM chungtu inner join hoadon on chungtu.sohieu=hoadon.sohd WHERE hoadon.hdbl=1 AND hoadon.loai=1 AND chungtu.ngaygs=N'{0}' AND hoadon.tyle={1}", _
                                              Format(i, Mask_DB), _
                                              TyLe))
                    If rs1.Rows.Count > 1 Then
                        tienct += ConvertToDblSafe(Timten("sops", ConvertToDblSafe(rsItem("MaSo")), "maso", "chungtu"))
                        tienhd += ConvertToDblSafe(rsItem("ThanhTien"))
                        ExecSQLNonQuery(String.Format("DELETE FROM chungtu WHERE maso={0}", ConvertToDblSafe(rsItem("MaSo"))))
                        ExecSQLNonQuery(String.Format("DELETE FROM hoadon WHERE maso={0}", ConvertToDblSafe(rsItem("MaSo"))))
                    Else
                        ExecSQLNonQuery(String.Format("UPDATE chungtu SET sops=sops+{0} WHERE maso={1}", tienct, ConvertToDblSafe(rsItem("MaSo"))))
                        ExecSQLNonQuery(String.Format("UPDATE hoadon SET thanhtien=thanhtien+{0}, sohd=N'{1}' WHERE maso={2}", tienhd, sh, ConvertToDblSafe(rsItem("MaSo"))))
                    End If
                    ExecSQLNonQuery(String.Format("UPDATE chungtu SET mact={0},sohieu=N'{1}' WHERE mact={2}", MaCT, sh, ConvertToDblSafe(rsItem("MaCT"))))
                    dem += 1
                Next
            Next
            HienThongBao(Ngonngu("Xong lập bảng kê bán lẻ.", "Make a list of retailers."), 0)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
End Module
