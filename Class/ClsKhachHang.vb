Imports System
Imports System.Text
Imports UNET.Utility
Imports System.Windows.Forms
Imports UNET.DataAdapter


Public Class clsKhachHang
    Public MaSo As Integer
    Public MaPhanLoai As Integer
    Public SoHieu As String = String.Empty
    Public Ten As String = String.Empty
    Public TenE As String = String.Empty
    Public DiaChi As String = String.Empty
    Public mst As String = String.Empty
    Public Tel As String = String.Empty
    Public Fax As String = String.Empty
    Public email As String = String.Empty
    Public DaiDien As String = String.Empty
    Public taikhoan As String = String.Empty
    Public DuMax As Double
    Public GhiChu As String = String.Empty
    Public MaNT As Integer



    ''' Kiểm tra số hiệu khách hàng
    Public Function KiemTraSoHieuKhachHang(ByVal _soHieu As String) As Boolean
        Try
            Dim result As Boolean = False
            result = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Count(MaSo) AS F1 FROM KhachHang WHERE SoHieu = '{0}'", _soHieu))) > 0
            Return result
        Catch ex As Exception
            Return False
        End Try
    End Function



    ''' <summary>
    ''' Thu tuc khoi tao object tu ma so
    ''' </summary>
    ''' <param name="mkh">Ma so can tham chieu (=0 neu moi)</param>
    ''' <remarks></remarks>
    Public Sub InitKhachHangMaSo(ByVal mkh As Integer)
        Dim rs_vattu As DataTable
        MaSo = 0
        MaPhanLoai = 0
        SoHieu = "..."
        Ten = "..."
        TenE = "..."
        DiaChi = "..."
        mst = "..."
        Tel = "..."
        Fax = "..."
        email = "..."
        DuMax = 0
        DaiDien = "..."
        taikhoan = "..."
        GhiChu = "..."
        MaNT = 0
        If mkh > 0 Then
            rs_vattu = ExecSQLReturnDT(String.Format("SELECT * FROM KhachHang WHERE MaSo={0}", mkh))
            If rs_vattu.Rows.Count > 0 Then
                Try
                    With rs_vattu.Rows(0)
                        ''van.nguyen 14-Nov-2011
                        'MaSo = ConvertToDblSafe(.Item("MaSo").Value)
                        'MaPhanLoai = ConvertToDblSafe(.Item("MaPhanLoai").Value)
                        'SoHieu = ConvertToStrSafe(.Item("SoHieu").Value)
                        'Ten = ConvertToStrSafe(.Item("Ten").Value)
                        'If pSongNgu Then
                        '    TenE = ConvertToStrSafe(.Item("TenE").Value)
                        'End If
                        'DiaChi = ConvertToStrSafe(.Item("DiaChi").Value)
                        'mst = ConvertToStrSafe(.Item("mst").Value)
                        'Tel = ConvertToStrSafe(.Item("Tel").Value)
                        'Fax = ConvertToStrSafe(.Item("Fax").Value)
                        'email = ConvertToStrSafe(.Item("email").Value)
                        'DuMax = ConvertToDblSafe(.Item("DuMax").Value)
                        'DaiDien = ConvertToStrSafe(.Item("DaiDien").Value)
                        'taikhoan = ConvertToStrSafe(.Item("taikhoan").Value)
                        'GhiChu = ConvertToStrSafe(.Item("GhiChu").Value)
                        'MaNT = ConvertToDblSafe(.Item("MaNT").Value)
                        If .Item("MaSo") IsNot Nothing Then
                            MaSo = ConvertToDblSafe(.Item("MaSo"))
                        End If
                        If .Item("MaPhanLoai") IsNot Nothing Then
                            MaPhanLoai = ConvertToDblSafe(.Item("MaPhanLoai"))
                        End If
                        If .Item("SoHieu") IsNot Nothing Then
                            SoHieu = ConvertToStrSafe(.Item("SoHieu"))
                        End If
                        If .Item("Ten") IsNot Nothing Then
                            Ten = ConvertToStrSafe(.Item("Ten"))
                        End If
                        'If pSongNgu Then
                        '    If .Item("TenE") IsNot Nothing Then
                        '        TenE = ConvertToStrSafe(.Item("TenE"))
                        '    End If
                        'End If
                        If .Item("DiaChi") IsNot Nothing Then
                            DiaChi = ConvertToStrSafe(.Item("DiaChi"))
                        End If
                        If .Item("mst") IsNot Nothing Then
                            mst = ConvertToStrSafe(.Item("mst"))
                        End If
                        If .Item("Tel") IsNot Nothing Then
                            Tel = ConvertToStrSafe(.Item("Tel"))
                        End If
                        If .Item("Fax") IsNot Nothing Then
                            Fax = ConvertToStrSafe(.Item("Fax"))
                        End If
                        If .Item("email") IsNot Nothing Then
                            email = ConvertToStrSafe(.Item("email"))
                        End If
                        If .Item("DuMax") IsNot Nothing Then
                            DuMax = ConvertToDblSafe(.Item("DuMax"))
                        End If
                        If .Item("DaiDien") IsNot Nothing Then
                            DaiDien = ConvertToStrSafe(.Item("DaiDien"))
                        End If
                        If .Item("taikhoan") IsNot Nothing Then
                            taikhoan = ConvertToStrSafe(.Item("taikhoan"))
                        End If
                        If .Item("GhiChu") IsNot Nothing Then
                            GhiChu = ConvertToStrSafe(.Item("GhiChu"))
                        End If
                        If .Item("MaNT") IsNot Nothing Then
                            MaNT = ConvertToDblSafe(.Item("MaNT"))
                        End If

                    End With
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub
    ''' <summary>
    ''' Thu tuc khoi tao object tu so hieu vat tu
    ''' </summary>
    ''' <param name="shkh">So hieu vat tu can tham chieu</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InitKhachHangSohieu(ByVal shkh As String) As String
        Dim sql As String = String.Format("SELECT DISTINCT MaSo AS F1 FROM KhachHang WHERE Sohieu=N'{0}'", shkh)
        InitKhachHangMaSo(ConvertToDblSafe(GetSelectValue(sql)))
        Return Ten
    End Function
    ''' <summary>
    ''' Thu tuc dang ky khách hàng
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GhiKhachHang() As Integer
        Dim result As Integer = 0
        Dim sql As String = String.Format("INSERT INTO KhachHang (MaSo,MaPhanLoai,SoHieu,Ten,DiaChi,MST,Tel,Fax,EMail,DaiDien,TaiKhoan,DuMax,GhiChu,MaNT) VALUES ({0},{1}, N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}', N'{10}',{11}, N'{12}',{13})", _
                                Lng_MaxValue("MaSo", "KhachHang") + 1, _
                                MaPhanLoai, _
                                SoHieu, _
                                Ten, _
                                DiaChi, _
                                mst, _
                                Tel, _
                                Fax, _
                                email, _
                                DaiDien, _
                                taikhoan, _
                                CStr(DuMax), _
                                GhiChu, _
                                MaNT)
        If ExecSQLNonQuery(sql) <> 0 Then
            result = -1
        Else
            result = 0
            MaSo = Lng_MaxValue("MaSo", "KhachHang")
        End If
        Return result
    End Function
    ''' <summary>
    ''' Hàm trả về số dư theo ngày
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <param name="duno"></param>
    ''' <param name="duco"></param>
    ''' <param name="dunt"></param>
    ''' <param name="mtk"></param>
    ''' <param name="shtk"></param>
    ''' <remarks></remarks>
    Public Sub SoDuKH(ByVal thang As Integer, ByRef duno As Double, ByRef duco As Double, ByRef dunt As Double, Optional ByVal mtk As Integer = 0, Optional ByVal shtk As String = "")
        Dim rs As DataTable
        Dim st As String = ConvertToStrSafe(CThangDB2(thang))
        If mtk > 0 Then
            rs = ExecSQLReturnDT(String.Format("SELECT Sum(DuNo_{0}) AS n,Sum(DuCo_{0}) AS c,Sum(DuNT_{0}) AS nt FROM SoDuKhachHang WHERE MaKhachHang={1}{2}", _
                                     st, _
                                     MaSo, _
                                     (IIf(mtk > 0, String.Format(" AND MaTaiKhoan={0}", mtk), String.Empty))))
        Else
            rs = ExecSQLReturnDT(String.Format("SELECT Sum(SoDuKhachHang.DuNo_{0}) AS n,Sum(SoDuKhachHang.DuCo_{0}) AS c,Sum(SoDuKhachHang.DuNT_{0}) AS nt FROM SoDuKhachHang INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo WHERE MaKhachHang={1} AND SoHieu LIKE '{2}%'", _
                                     st, _
                                     ConvertToStrSafe(MaSo), _
                                     shtk))
        End If
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If rsItem("n") IsNot Nothing Then
                duno = ConvertToDblSafe(rsItem("n"))
            End If
            If rsItem("c") IsNot Nothing Then
                duco = ConvertToDblSafe(rsItem("c"))
            End If
            If rsItem("nt") IsNot Nothing Then
                dunt = Math.Abs(ConvertToDblSafe(rsItem("nt")))
            End If

        Else
            duno = 0
            duco = 0
            dunt = 0
        End If
        If duno < 0 Then
            duco = -duno
            duno = 0
        End If
        If duco < 0 Then
            duno = -duco
            duco = 0
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="psn"></param>
    ''' <param name="psc"></param>
    ''' <param name="psn2"></param>
    ''' <param name="psc2"></param>
    ''' <param name="mtk"></param>
    ''' <remarks></remarks>
    Public Sub SoPhatSinh(ByVal tdau As Integer, ByVal tcuoi As Integer, ByRef psn As Double, ByRef psc As Double, ByRef psn2 As Double, ByRef psc2 As Double, Optional ByVal mtk As Integer = 0)
        Dim sqlc2 As New StringBuilder
        Dim sqln2 As New StringBuilder
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        psn = 0
        psc = 0
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            sqln.AppendFormat(" + No_{0}", i)
            sqlc.AppendFormat(" + Co_{0}", i)
            sqln2.AppendFormat(" + No_{0}", i)
            sqlc2.AppendFormat(" + Co_{0}", i)
        Next
        Dim sql As String = String.Format("SELECT DISTINCT SUM({0}) AS N,SUM({1}) AS C,SUM({2}) AS N2,SUM({3}) AS C2 FROM SoDuKhachHang WHERE MaKhachHang={4}{5}", _
                                sqln, _
                                sqlc, _
                                sqln2, _
                                sqlc2, _
                                MaSo, _
                                (IIf(mtk > 0, String.Format(" AND MaTaiKhoan={0}", mtk), String.Empty)))
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)

            If rsItem("n") IsNot Nothing Then
                psn = ConvertToDblSafe(rsItem("n"))
            End If

            If rsItem("c") IsNot Nothing Then
                psc = ConvertToDblSafe(rsItem("c"))
            End If

            If rsItem("n2") IsNot Nothing Then
                psn2 = ConvertToDblSafe(rsItem("n2"))
            End If

            If rsItem("c2") IsNot Nothing Then
                psc2 = ConvertToDblSafe(rsItem("c2"))
            End If
        Else
            psn = 0
            psc = 0
            psn2 = 0
            psc2 = 0
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SuaKH() As Integer
        Dim sql As String = String.Format("UPDATE KhachHang SET MaPhanLoai={0},SoHieu=N'{1}',Ten=N'{2}',DiaChi=N'{3}',MST =N'{4}',Tel=N'{5}',Fax=N'{6}',EMail=N'{7}',DaiDien=N'{8}',TaiKhoan=N'{9}',DuMax={10},GhiChu=N'{11}',MaNT={12} WHERE MaSo={13}", _
                                MaPhanLoai, _
                                SoHieu, _
                                Ten, _
                                DiaChi, _
                                mst, _
                                Tel, _
                                Fax, _
                                email, _
                                DaiDien, _
                                taikhoan, _
                                CStr(DuMax), _
                                GhiChu, _
                                MaNT, _
                                MaSo)
        Return ExecSQLNonQuery(sql)
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function XoaKH() As Integer
        Dim x As Double
        Dim result As Integer = -1
        If ConvertToDblSafe(GetSelectValue(String.Format("SELECT Count(MaSo) AS F1 FROM ChungTu WHERE MaKH={0} OR MaKHC={1}", _
                                               MaSo, _
                                               MaSo))) <> 0 _
          OrElse ConvertToDblSafe(GetSelectValue(String.Format("SELECT Count(MaSo) AS F1 FROM HoaDon WHERE MaKhachHang={0}", MaSo))) <> 0 _
          OrElse ConvertToDblSafe(GetSelectValue(String.Format("SELECT Count(MaSo) AS F1 FROM ChungTuLQ WHERE MaKH={0}", MaSo))) <> 0 Then
            Return result
        End If
        If ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(DuNo_0) AS F1,Sum(DuCo_0) AS F2 FROM SoDuKhachHang WHERE MaKhachHang={0}", MaSo), x)) <> 0 Then
            Return result
        End If
        If x <> 0 Then
            Return result
        End If
        If ExecSQLNonQuery(String.Format("DELETE  FROM SoDuKhachHang WHERE MaKhachHang={0}", MaSo)) <> 0 Then
            Return result
        End If
        result = ExecSQLNonQuery(String.Format("DELETE FROM KhachHang WHERE MaSo={0}", MaSo))
        If result = 0 Then
            SoDuTKCN()
        End If
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mtk"></param>
    ''' <param name="sodu1"></param>
    ''' <param name="sodu2"></param>
    ''' <param name="nt"></param>
    ''' <remarks></remarks>
    Public Sub GhiDauKy(ByVal mtk As Integer, ByVal sodu1 As Double, ByVal sodu2 As Double, ByVal nt As Double)
        Dim st3 As String = String.Empty
        Dim st As New StringBuilder
        Dim sql As String = String.Format("UPDATE SoDuKhachHang SET DuNo_0 = {0},DuCo_0 = {1},DuNT_0={2} WHERE MaTaiKhoan= {3} AND MaKhachHang={4}", sodu1, sodu2, nt, ConvertToStrSafe(mtk), ConvertToStrSafe(MaSo))
        Dim RecordsAffected As Integer = ExecSQLNonQueryUpdateInsertDeleteQuery(sql)
        If RecordsAffected = 0 Then
            ExecSQLNonQuery(String.Format("INSERT INTO SoDuKhachHang (MaSo,MaTaiKhoan,MaKhachHang) VALUES ({0},{1},{2})", _
                            (Lng_MaxValue("MaSo", "SoDuKhachHang") + 1), _
                            ConvertToStrSafe(mtk), _
                            ConvertToStrSafe(MaSo)))
            ExecSQLNonQuery(sql)
        End If
        sql = "UPDATE SoDuKhachHang SET MaTaiKhoan = MaTaiKhoan"
        For i As Integer = 1 To 12
            st = New StringBuilder("DuNo_0 - DuCo_0")
            For j As Integer = 1 To i
                st.Append(String.Format(" + No_{0} - Co_{0}", j))
            Next
            sql = String.Format("{0}, DuNo_{1} = CASE WHEN ({2} > 0) THEN {2} ELSE 0 END, DuCo_{1} =  CASE WHEN ({2} < 0) THEN -({2}) ELSE 0 END", _
                      sql, _
                      i, _
                      st)
        Next
        ExecSQLNonQuery(String.Format("{0} WHERE MaTaiKhoan= {1} AND MaKhachHang={2}", _
                            sql, _
                            ConvertToStrSafe(mtk), _
                            ConvertToStrSafe(MaSo)))
        If MaNT > 0 Then
            sql = "UPDATE SoDuKhachHang  SET "
            For i As Integer = 1 To 12
                ExecSQLNonQuery(String.Format("{0}DuNT_{1}=ABS(DuNT_{2}+ CASE WHEN (DuNo_{2}-DuCo_{2}>=0) THEN No_{1}_NT-Co_{1}_NT ELSE Co_{1}_NT-No_{1}_NT END) WHERE MaTaiKhoan= {3} AND MaKhachHang={4}", _
                                sql, _
                                ConvertToStrSafe(i), _
                                ConvertToStrSafe(i - 1), _
                                ConvertToStrSafe(mtk), _
                                ConvertToStrSafe(MaSo)))
            Next
        End If
        SoDuTKCN()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="TK"></param>
    ''' <param name="thang"></param>
    ''' <param name="ps"></param>
    ''' <param name="nt"></param>
    ''' <param name="loai"></param>
    ''' <remarks></remarks>
    Public Sub GhiSoPSKH(ByVal TK As ClsTaikhoan, ByVal thang As Integer, ByVal ps As Double, ByVal nt As Double, ByVal loai As Integer)
        Dim st As New StringBuilder
        st.Append(ConvertToStrSafe(CThangDB2(thang)))
        Dim sql As New StringBuilder
        sql.Append(String.Format("UPDATE SoDuKhachHang SET {0}{1}={0}{1}+{2}", _
                       (IIf(loai < 0, "No_", "Co_")), _
                       st, _
                       doidau(ps)))
        If MaNT > 0 Then sql.Append(String.Format("{0}{1}_NT={2}{1}_NT+{3}", _
                                        (IIf(loai < 0, ",No_", ",Co_")), _
                                        st, _
                                        (IIf(loai < 0, "No_", "Co_")), _
                                        doidau(nt)))
        Dim RecordsAffected As Integer = ExecSQLNonQueryUpdateInsertDeleteQuery(String.Format("{0} WHERE MaTaiKhoan= {1} AND MaKhachHang={2}", _
                                sql, _
                                ConvertToStrSafe(TK.maso), _
                                ConvertToStrSafe(MaSo)))
        If RecordsAffected = 0 And ps > 0 Then
            ExecSQLNonQuery(String.Format("INSERT INTO SoDuKhachHang (MaSo, MaTaiKhoan,MaKhachHang) VALUES ({0},{1},{2})", _
                            (Lng_MaxValue("MaSo", "SoDuKhachHang") + 1), _
                            ConvertToStrSafe(TK.maso), _
                            ConvertToStrSafe(MaSo)))
            ExecSQLNonQuery("update SoDuKhachHang set DuCo_0=0 where DuCo_0 is null")
            ExecSQLNonQuery("update SoDuKhachHang set DuNo_0=0 where DuNo_0 is null")
            ExecSQLNonQuery("update SoDuKhachHang set DuNT_0=0 where DuNT_0 is null")
            For i = 1 To 12
                ExecSQLNonQuery("update SoDuKhachHang set DuCo_" + CStr(i) + "=0 where DuCo_" + CStr(i) + " is null")
                ExecSQLNonQuery("update SoDuKhachHang set DuNo_" + CStr(i) + "=0 where DuNo_" + CStr(i) + " is null")
                ExecSQLNonQuery("update SoDuKhachHang set DuNT_" + CStr(i) + "=0 where DuNT_" + CStr(i) + " is null")
                ExecSQLNonQuery("update SoDuKhachHang set No_" + CStr(i) + "=0 where No_" + CStr(i) + " is null")
                ExecSQLNonQuery("update SoDuKhachHang set Co_" + CStr(i) + "=0 where Co_" + CStr(i) + " is null")
                ExecSQLNonQuery("update SoDuKhachHang set No_" + CStr(i) + "_NT=0 where No_" + CStr(i) + "_NT is null")
                ExecSQLNonQuery("update SoDuKhachHang set Co_" + CStr(i) + "_NT=0 where Co_" + CStr(i) + "_NT is null")
            Next
            ExecSQLNonQuery(String.Format("{0} WHERE MaTaiKhoan= {1} AND MaKhachHang={2}", _
                                sql, _
                                ConvertToStrSafe(TK.maso), _
                                ConvertToStrSafe(MaSo)))
        End If

        sql = New StringBuilder("UPDATE SoDuKhachHang SET MaTaiKhoan = MaTaiKhoan")
        For i As Integer = CThangDB(thang) To 12
            st = New StringBuilder(String.Format("DuNo_{0} - DuCo_{0}", CThangDB2(ThangTruoc(thang))))
            For j As Integer = CThangDB(thang) To i
                st.Append(String.Format(" + No_{0} - Co_{0}", j))
            Next
            sql.AppendFormat(", DuNo_{0} = CASE WHEN ({1} > 0) THEN {1} ELSE 0 END, DuCo_{0} =  CASE WHEN ({1} < 0) THEN -({1}) ELSE 0 END", _
                i, _
                st)
        Next
        ExecSQLNonQuery(String.Format("{0} WHERE MaTaiKhoan= {1} AND MaKhachHang={2}", _
                        sql, _
                        ConvertToStrSafe(TK.maso), _
                        ConvertToStrSafe(MaSo)))
        If MaNT > 0 Then
            sql = New StringBuilder("UPDATE SoDuKhachHang SET MaTaiKhoan = MaTaiKhoan")
            For i As Integer = CThangDB(thang) To 12
                st = New StringBuilder(String.Format("DuNT_{0}", CThangDB2(ThangTruoc(thang))))
                For j As Integer = CThangDB(thang) To i
                    If TK.kieu < 0 Then
                        st.AppendFormat(" + No_{0}_NT - Co_{0}_NT", j)
                    Else
                        st.AppendFormat(" - No_{0}_NT + Co_{0}_NT", j)
                    End If
                Next
                sql.AppendFormat(", DuNT_{0} = {1}", i, st)
            Next
            ExecSQLNonQuery(String.Format("{0} WHERE MaTaiKhoan= {1} AND MaKhachHang={2}", _
                            sql.ToString, _
                            ConvertToStrSafe(TK.maso), _
                            ConvertToStrSafe(MaSo)))
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mtk"></param>
    ''' <remarks></remarks>
    Public Sub GhiDauKy2(ByVal mtk As Integer)
        Dim st3 As String = String.Empty
        Dim st As New StringBuilder
        'Dim sodu2 As Double
        'Dim sodu1 As Double = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(DuNo_0) AS F1, Sum(DuCo_0) AS F2 FROM CNDauNam WHERE MaTaiKhoan={0} AND MaKhachHang={1}", _
        '                                                          mtk, _
        '                                                          ConvertToStrSafe(MaSo)), sodu2))
        Dim tam As String = String.Format("SELECT Sum(DuNo_0) AS F1, Sum(DuCo_0) AS F2 FROM CNDauNam WHERE MaTaiKhoan={0} AND MaKhachHang={1}", _
                                                                mtk, _
                                                                ConvertToStrSafe(MaSo))
        Dim tam2 As String = String.Format("SELECT Sum(DuNo_0) AS F2, Sum(DuCo_0) AS F1 FROM CNDauNam WHERE MaTaiKhoan={0} AND MaKhachHang={1}", _
                                                             mtk, _
                                                             ConvertToStrSafe(MaSo))
        Dim sodu1 As Double = ConvertToDblSafe(GetSelectValue(tam))
        Dim sodu2 As Double = ConvertToDblSafe(GetSelectValue(tam2))
        Dim nt As Double = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(DuNT_0) AS F1 FROM CNDauNam WHERE MaTaiKhoan={0} AND MaKhachHang={1}", _
                                                               mtk, _
                                                               ConvertToStrSafe(MaSo))))
        Dim sql As String = String.Format("UPDATE SoDuKhachHang SET DuNo_0 = {0},DuCo_0 = {1},DuNT_0={2} WHERE MaTaiKhoan= {3} AND MaKhachHang={4}", _
                                Math.Abs(sodu1), _
                                ConvertToStrSafe(Math.Abs(sodu2)), _
                                CStr(Math.Abs(nt)), _
                                ConvertToStrSafe(mtk), _
                                ConvertToStrSafe(MaSo))
        Dim RecordsAffected As Integer = ExecSQLNonQueryUpdateInsertDeleteQuery(sql)
        If RecordsAffected = 0 Then
            ExecSQLNonQuery(String.Format("INSERT INTO SoDuKhachHang (MaSo,MaTaiKhoan,MaKhachHang) VALUES ({0},{1},{2})", _
                            (Lng_MaxValue("MaSo", "SoDuKhachHang") + 1), _
                            mtk, _
                            MaSo))
            ExecSQLNonQuery(sql)
        End If
        sql = "UPDATE SoDuKhachHang SET MaTaiKhoan = MaTaiKhoan"
        For i As Integer = 1 To 12
            st = New StringBuilder("DuNo_0 - DuCo_0")
            For j As Integer = 1 To i
                st.AppendFormat(" + No_{0} - Co_{0}", j)
            Next
            sql = String.Format("{0}, DuNo_{1} = CASE WHEN ({2} > 0) THEN {2} ELSE 0 END, DuCo_{1} =  CASE WHEN ({2} < 0) THEN -({2}) ELSE 0 END", _
                      sql, _
                      i, _
                      st.ToString)
        Next
        ExecSQLNonQuery(String.Format("{0} WHERE MaTaiKhoan= {1} AND MaKhachHang={2}", _
                        sql, _
                        ConvertToStrSafe(mtk), _
                        ConvertToStrSafe(MaSo)))
        If MaNT > 0 Then
            sql = "UPDATE SoDuKhachHang  SET "
            For i As Integer = 1 To 12
                ExecSQLNonQuery(String.Format("{0}DuNT_{1}=ABS(DuNT_{2} + CASE WHEN (DuNo_{2}-DuCo_{2}>=0) THEN No_{1}_NT-Co_{1}_NT ELSE Co_{1}_NT-No_{1}_NT END) WHERE MaTaiKhoan= {3} AND MaKhachHang={4}", _
                                sql, _
                                ConvertToStrSafe(i), _
                                ConvertToStrSafe(i - 1), _
                                ConvertToStrSafe(mtk), _
                                ConvertToStrSafe(MaSo)))
            Next
        End If
        SoDuTKCN()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <param name="ngay"></param>
    ''' <param name="shtk"></param>
    ''' <param name="mkh"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function HDChuaTT(ByVal thang As Integer, ByVal ngay As Date, ByVal shtk As String, ByVal mkh As Integer) As String
        If pCongNoHD = 0 Then
            Return String.Empty
        End If
        Dim sql As String = String.Format("SELECT 'DK' AS SoHieu,'01/01/1980' AS NgayCT, N'{0}' AS DienGiai,CNDauNam.SoXuat,CNDauNam.DuNo_0 AS SoPS FROM CNDauNam INNER JOIN HethongTK ON CNDauNam.MaTaiKhoan=HethongTK.MaSo  WHERE HethongTK.SoHieu LIKE '{1}%' AND (MaKhachHang = {2}) AND (CNDauNam.DuNo_0>CNDauNam.SoXuat) UNION SELECT ChungTu.SoHieu, NgayCT, DienGiai, Sum(SoXuat), Sum(SoPS) FROM {3} WHERE HethongTK.SoHieu LIKE '{1}%' AND (ChungTu.MaKH = {2}) AND {4} GROUP BY MaCT,ChungTu.SoHieu,NgayCT,DienGiai HAVING Sum(SoPS)>Sum(SoXuat) ORDER BY NgayCT DESC, SoHieu DESC", _
                                "Dư đầu kỳ", _
                                shtk, _
                                ConvertToStrSafe(mkh), _
                                ChungTu2TKNC(-1), _
                                (IIf(thang > 0, WThang("ThangCT", 0, thang), WNgay("NgayGS", #1/1/1980#, ngay))))
        Dim rs_phieu As DataTable = ExecSQLReturnDT(sql)
        sql = ""
        For Each rsPhieuItem As DataRow In rs_phieu.Rows
            sql = String.Format("{0}CT: {1}{2}{3}{4}{5}; ", _
                                  sql, _
                                  rsPhieuItem("SoHieu"), _
                                  " - Ngày ", _
                                  IIf(ConvertToDateSafe(rsPhieuItem("NgayCT")).Year > 1980, Format(ConvertToDateSafe(rsPhieuItem("NgayCT")), Mask_D), String.Empty), _
                                  " - Số còn nợ: ", _
                                  Format(ConvertToDblSafe(rsPhieuItem("sops")) - ConvertToDblSafe(rsPhieuItem("SoXuat")), Mask_0))
        Next
        Return sql
    End Function
End Class