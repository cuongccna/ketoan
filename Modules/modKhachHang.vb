Imports System
Imports System.Data
Imports UNET.Utility
Imports UNET.DataAdapter


Module modKhachHang
    ''' <summary>
    ''' Hàm trả về mã số, tên phân loại từ số hiệu
    ''' </summary>
    ''' <remarks></remarks>
    Public Function TenPLKH(ByRef sh As String, ByRef mpl As Integer) As String
        Dim result As String = String.Empty
        Dim rs_tk As DataTable = ExecSQLReturnDT(String.Format("SELECT MaSo,TenPhanLoai FROM PhanLoaiKhachHang WHERE SoHieu =N'{0}'", sh))
        If rs_tk.Rows.Count > 0 Then
            Dim rstkItem As DataRow = rs_tk.Rows(0)
            mpl = ConvertToDblSafe(rstkItem("MaSo"))
            result = ConvertToStrSafe(rstkItem("TenPhanLoai"))
        Else
            mpl = 0
            result = String.Empty
        End If
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SoDuTKCN()
        Dim taikhoan As New ClsTaikhoan
        ExecSQLNonQuery("UPDATE SoDuKhachHang SET DuNo_0=CASE WHEN (DuNo_0-DuCo_0>=0) THEN DuNo_0-DuCo_0 ELSE 0 END,DuCo_0= CASE WHEN (DuNo_0-DuCo_0<0) THEN -DuNo_0+DuCo_0 ELSE 0 END")
        Dim rs_tk As DataTable = ExecSQLReturnDT(String.Format("SELECT DISTINCT SoHieu FROM HethongTK INNER JOIN SoDuKhachHang ON HethongTK.MaSo=SoDuKhachHang.MaTaiKhoan WHERE (TKCon = 0) AND (TK_ID = {0} OR TK_ID = {1})", _
                                                     TKCNKH_ID, _
                                                     ConvertToStrSafe(TKCNPT_ID)))
        For Each rstkItem As DataRow In rs_tk.Rows
            taikhoan.InitTaikhoanSohieu(ConvertToDblSafe(rstkItem("SoHieu")))
            taikhoan.NoDauKy = 0
            taikhoan.CoDauKy = 0
            taikhoan.CapNhatTk()
        Next
        rs_tk = ExecSQLReturnDT("SELECT MaTaiKhoan, Sum(DuNo_0) AS DuNo, Sum(DuCo_0) AS DuCo FROM SoDuKhachHang GROUP BY MaTaiKhoan")
        For Each rstkItem As DataRow In rs_tk.Rows
            taikhoan.InitTaikhoanMaSo(ConvertToDblSafe(rstkItem("MaTaiKhoan")))
            If taikhoan.maso > 0 Then
                taikhoan.NoDauKy = ConvertToDblSafe(rstkItem("duno"))
                taikhoan.CoDauKy = ConvertToDblSafe(rstkItem("duco"))
                taikhoan.CapNhatTk()
            End If
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <param name="mtk"></param>
    ''' <param name="mst"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TenKH(ByRef sh As String, ByRef mtk As Integer, Optional ByRef mst As String = "") As String
        Dim rs_tk As DataTable
        Dim result As String = String.Empty
        If mtk > 0 Then
            rs_tk = ExecSQLReturnDT(String.Format("SELECT SoHieu, Ten, MST FROM KhachHang WHERE MaSo={0}", mtk))

            Dim rstkItem As DataRow = rs_tk.Rows(0)
            result = ConvertToStrSafe(rstkItem("Ten"))
            sh = ConvertToStrSafe(rstkItem("SoHieu"))
            mst = ConvertToStrSafe(rstkItem("mst"))
        Else
            rs_tk = ExecSQLReturnDT(String.Format("SELECT MaSo,Ten, MST FROM KhachHang WHERE SoHieu=N'{0}'", sh))
            If rs_tk.Rows.Count > 0 Then
                Dim rstkItem As DataRow = rs_tk.Rows(0)
                mtk = ConvertToDblSafe(rstkItem("MaSo"))
                result = ConvertToStrSafe(rstkItem("Ten"))
                mst = ConvertToStrSafe(rstkItem("mst"))
            Else
                mtk = 0
                result = String.Empty
                mst = String.Empty
            End If
        End If
        Return result
    End Function
    ''' <summary>
    ''' Hàm trả về số dư tài khoản cuối ngày, chỉ cho tài khoản chi tiết
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SoDuKHNgay(ByRef mkh As Integer, ByRef ngay As Date, ByRef duno As Double, ByRef duco As Double, ByRef dunt As Double, Optional ByRef mtk As Integer = 0, Optional ByRef shtk As String = "")
        Dim rs As DataTable
        Dim sql As String = String.Empty
        Dim y1, y2 As Double
        If mtk > 0 Then
            rs = ExecSQLReturnDT(String.Format("SELECT Sum(DuNo_0) AS n,Sum(DuCo_0) AS c,Sum(DuNT_0) AS nt FROM SoDuKhachHang WHERE MaKhachHang={0}{1}", _
                                     mkh, _
                                     (IIf(mtk > 0, String.Format(" AND MaTaiKhoan={0}", mtk), String.Empty))))
        Else
            rs = ExecSQLReturnDT(String.Format("SELECT Sum(SoDuKhachHang.DuNo_0) AS n,Sum(SoDuKhachHang.DuCo_0) AS c,Sum(SoDuKhachHang.DuNT_0) AS nt FROM SoDuKhachHang INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo WHERE MaKhachHang={0} AND SoHieu LIKE '{1}%'", _
                                     mkh, _
                                     shtk))
        End If
        Dim rsItem As DataRow = rs.Rows(0)
        If Not IsDBNull(rsItem("n")) Then
            duno = ConvertToDblSafe(rsItem("n"))
            duco = ConvertToDblSafe(rsItem("c"))
            dunt = ConvertToDblSafe(rsItem("nt"))
        Else
            duno = 0
            duco = 0
            dunt = 0
        End If
        Dim kieu As Boolean = duno >= duco
        Dim X As Double = ConvertToDblSafe(GetSelectValue(String.Format("SELECT DISTINCT Sum(SoPS) AS F1, Sum(SoPS2No) AS F2 FROM {0} WHERE (TK_ID={1} OR TK_ID={2}) AND NgayGS<=N'{3}' AND MaKH={4}{5}", _
                                                              ChungTu2TKNC(-1), _
                                                              ConvertToStrSafe(TKCNKH_ID), _
                                                              ConvertToStrSafe(TKCNPT_ID), _
                                                              Format(CDate(ngay), Mask_DB), _
                                                              ConvertToStrSafe(mkh), _
                                                              (IIf(mtk > 0, String.Format(" AND MaTKNo={0}", mtk), String.Empty))), y1))
        duno += X
        X = ConvertToDblSafe(GetSelectValue(String.Format("SELECT DISTINCT Sum(SoPS) AS F1, Sum(SoPS2Co) AS F2 FROM {0} WHERE (TK_ID={1} OR TK_ID={2}) AND NgayGS<=N'{3}' AND MaKHC={4}{5}", _
                                                ChungTu2TKNC(1), _
                                                ConvertToStrSafe(TKCNKH_ID), _
                                                ConvertToStrSafe(TKCNPT_ID), _
                                                Format(CDate(ngay), Mask_DB), _
                                                ConvertToStrSafe(mkh), _
                                                (IIf(mtk > 0, String.Format(" AND MaTKCo={0}", mtk), String.Empty))), y2))
        duco += X
        If duno - duco >= 0 Then
            duno -= duco
            duco = 0
            dunt = IIf(kieu, dunt + y1 - y2, dunt - y1 + y2)
        Else
            duco -= duno
            duno = 0
            dunt = IIf(kieu, dunt - y1 + y2, dunt + y1 - y2)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mkh"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="psn"></param>
    ''' <param name="psc"></param>
    ''' <param name="psn2"></param>
    ''' <param name="psc2"></param>
    ''' <param name="mtk"></param>
    ''' <remarks></remarks>
    Public Sub SoPhatSinhN(ByRef mkh As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef psn As Double, ByRef psc As Double, ByRef psn2 As Double, ByRef psc2 As Double, Optional ByRef mtk As Integer = 0)
        psn = ConvertToDblSafe(GetSelectValue(String.Format("SELECT DISTINCT Sum(SoPS) AS F1, Sum(SoPS2No) AS F2 FROM {0} WHERE (TK_ID={1} OR TK_ID={2}) AND {3} AND MaKH={4}{5}", _
                                                  ChungTu2TKNC(-1), _
                                                  ConvertToStrSafe(TKCNKH_ID), _
                                                  ConvertToStrSafe(TKCNPT_ID), _
                                                  WNgay("NgayGS", ndau, ncuoi), _
                                                  ConvertToStrSafe(mkh), _
                                                  (IIf(mtk > 0, String.Format(" AND MaTKNo={0}", mtk), String.Empty))), psn2))
        psc = ConvertToDblSafe(GetSelectValue(String.Format("SELECT DISTINCT Sum(SoPS) AS F1, Sum(SoPS2Co) AS F2 FROM {0} WHERE (TK_ID={1} OR TK_ID={2}) AND {3} AND MaKHC={4}{5}", _
                                                  ChungTu2TKNC(1), _
                                                  ConvertToStrSafe(TKCNKH_ID), _
                                                  ConvertToStrSafe(TKCNPT_ID), _
                                                  WNgay("NgayGS", ndau, ncuoi), _
                                                  ConvertToStrSafe(mkh), _
                                                  (IIf(mtk > 0, String.Format(" AND MaTKCo={0}", mtk), String.Empty))), psc2))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mpl"></param>
    ''' <remarks></remarks>
    Public Sub DanhDiemCN(ByRef mpl As Integer)
        Dim QChitiet As String = String.Format("SELECT DISTINCT KhachHang.SoHieu, Ten,PhanLoaiKhachHang.SoHieu AS SHPL,TenPhanLoai,PhanLoaiKhachHang.PLCha,DiaChi,MST,Tel,Fax,TaiKhoan,PhanLoaiKhachHang.MaSo AS MPL FROM KhachHang INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo WHERE LEFT(KhachHang.SoHieu,1)<>'X'")
        Dim QSoCai As String = String.Format("SELECT QChitiet.*, PhanLoaiKhachHang.SoHieu AS SH2,PhanLoaiKhachHang.TenPhanLoai AS TenPhanLoai2,PhanLoaiKhachHang.PLCha AS PLCha2,PhanLoaiKhachHang.MaSo AS MPL2 FROM ({0}) AS QChitiet LEFT JOIN PhanLoaiKhachHang ON QChitiet.PLCha=PhanLoaiKhachHang.MaSo", QChitiet)
        Dim QTongHopCT As String = String.Format("SELECT QSoCai.*, PhanLoaiKhachHang.SoHieu AS SH1,PhanLoaiKhachHang.TenPhanLoai AS TenPhanLoai1 FROM (" + QSoCai + ") AS QSoCai LEFT JOIN PhanLoaiKhachHang ON QSoCai.PLCha2=PhanLoaiKhachHang.MaSo {0} ORDER BY QSoCai.SoHieu", (IIf(mpl > 0, String.Format("WHERE PhanLoaiKhachHang.MaSo={0} OR MPL={1} OR MPL2={1}", mpl, ConvertToStrSafe(mpl)), String.Empty)))

        rptFrom.InitForm("DDCN.RPT", QTongHopCT, "QTongHopCT")
        rptFrom.ReportWindowTitle = "Bảng danh điểm công nợ"
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <remarks></remarks>
    Public Sub SoDuTKCN2(ByRef thang As Integer)
        Dim n, c As Double
        Dim TK As New ClsTaikhoan
        Dim st As String = ConvertToStrSafe(CThangDB2(thang))
        Dim rs_tk As DataTable

        Dim rs As DataTable = ExecSQLReturnDT("select sohieu, cap from hethongtk where tkcon=1 and (SoHieu LIKE '138%' OR HethongTK.SoHieu LIKE '333%' OR HethongTK.SoHieu LIKE '338%') order by cap desc")
        For Each rsItem As DataRow In rs.Rows
            rs_tk = ExecSQLReturnDT("SELECT sum(duno_" + st + ")as duno,sum(duco_" + st + ")as duco FROM HethongTK WHERE cap=" + CStr(rsItem("cap")) + "+1 and SoHieu LIKE '" + rsItem("SoHieu") + "%'")
            For Each rs_tkItem As DataRow In rs_tk.Rows
                ExecSQLNonQuery("UPDATE HethongTK SET DuNo_" + st + " = " + doidau(rs_tkItem("duno")) + ",DuCo_" + st + " = " + doidau(rs_tkItem("duco")) + " WHERE sohieu like '" + CStr(rsItem("SoHieu")) + "'")
            Next
        Next

        rs_tk = ExecSQLReturnDT(String.Format("SELECT MaTaiKhoan, Sum(SoDuKhachHang.DuNo_{0}) AS DuNo, Sum(SoDuKhachHang.DuCo_{0}) AS DuCo FROM SoDuKhachHang INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo WHERE {1} HethongTK.SoHieu LIKE '331%' OR HethongTK.SoHieu LIKE '138%' OR HethongTK.SoHieu LIKE '333%' OR HethongTK.SoHieu LIKE '338%' GROUP BY MaTaiKhoan", _
                                                     st, _
                                                     IIf(pSHPT <> "", String.Format(" HethongTK.SoHieu LIKE '{0}%' OR ", pSHPT), "")))
        For Each rsItem As DataRow In rs_tk.Rows
            n = ConvertToDblSafe(GetSelectValue(String.Format("SELECT DuNo_{0} AS F1, DuCo_{0} AS F2 FROM HethongTK WHERE MaSo={1}", _
                                                    st, _
                                                    rsItem("MaTaiKhoan")), c))
            TK.InitTaikhoanMaSo(rsItem("MaTaiKhoan"))
            ExecSQLNonQuery(String.Format("UPDATE HethongTK SET DuNo_{0} = DuNo_{0} -  {1} + {2},DuCo_{0} = DuCo_{0}-{3}+{4} WHERE MaSo = {5} OR MaSo = {6} OR MaSo = {7} OR MaSo = {8} OR MaSo = {9} OR MaSo = {10} OR MaSo = {11}", _
                                st, _
                                CStr(n), _
                                CStr(rsItem("duno")), _
                                CStr(c), _
                                CStr(rsItem("duco")), _
                                ConvertToStrSafe(TK.maso), _
                                ConvertToStrSafe(TK.TkCha0), _
                                ConvertToStrSafe(TK.TkCha1), _
                                ConvertToStrSafe(TK.TkCha2), _
                                ConvertToStrSafe(TK.TkCha3), _
                                ConvertToStrSafe(TK.TkCha4), _
                                ConvertToStrSafe(TK.TkCha5)))
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mkh"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function KHMaNT(ByRef mkh As Integer) As Double
        Return ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaNT AS F1 FROM KhachHang WHERE MaSo={0}", mkh)))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <param name="ms"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TenNV(ByRef sh As String, ByRef ms As Integer) As String
        Return ConvertToStrSafe(GetSelectValue(String.Format("SELECT SoHieu AS F2, Ten AS F1, MaSo AS F3 FROM NhanVien WHERE {0}", (IIf(ms > 0, String.Format("MaSo={0}", ms), String.Format("SoHieu=N'{0}'", sh)))), _
                                    sh, _
                                    ms))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="shtk"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="thue"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DoanhThuTK(ByRef shtk As String, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef thue As Double) As Double
        Dim result As Double = 0
        Dim Mientru As String = String.Format("SELECT MaCT, (TyLe) AS TL FROM {0} WHERE HoaDon.Loai=1 AND {1} GROUP BY MaCT", _
                              ChungTu2TKHD(0), _
                              WThang("ThangCT", tdau, tcuoi))
        result = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1, Sum(CASE WHEN ISNULL(TL) THEN 0 THEN CAST(0.5+SoPS*TL/100, INT) END) AS F2 FROM ({0}) LEFT JOIN (" & Mientru & ") as Mientru ON ChungTu.MaCT=Mientru.MaCT WHERE HethongTK.SoHieu LIKE '{1}%' AND {2}", _
                                                     ChungTu2TKNC(1), _
                                                     shtk, _
                                                     WThang("ThangCT", tdau, tcuoi)), thue))
        Return ConvertToDblSafe(result - ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM {0} WHERE MaLoai<>3 AND HethongTK.SoHieu LIKE '{1}%' AND (Not TK.SoHieu LIKE '3332%') AND {2}", _
                                                                 ChungTu2TKNC(0), _
                                                                 shtk, _
                                                                 WThang("ThangCT", tdau, tcuoi)))))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mkh"></param>
    ''' <param name="thang"></param>
    ''' <param name="duno"></param>
    ''' <param name="duco"></param>
    ''' <param name="dunt"></param>
    ''' <param name="mtk"></param>
    ''' <param name="shtk"></param>
    ''' <remarks></remarks>
    Public Sub SoDuKH(ByRef mkh As Integer, ByRef thang As Integer, ByRef duno As Double, ByRef duco As Double, ByRef dunt As Double, Optional ByRef mtk As Integer = 0, Optional ByRef shtk As String = "")
        Dim rs As DataTable
        Dim st As String = ConvertToStrSafe(CThangDB2(thang))
        If mtk > 0 Then
            rs = ExecSQLReturnDT(String.Format("SELECT Sum(DuNo_{0}) AS n,Sum(DuCo_{0}) AS c,Sum(DuNT_{0}) AS nt FROM SoDuKhachHang WHERE MaKhachHang={1}{2}", _
                                     st, _
                                     ConvertToStrSafe(mkh), _
                                     (IIf(mtk > 0, String.Format(" AND MaTaiKhoan={0}", mtk), String.Empty))))
        Else
            rs = ExecSQLReturnDT(String.Format("SELECT Sum(SoDuKhachHang.DuNo_{0}) AS n,Sum(SoDuKhachHang.DuCo_{0}) AS c,Sum(CASE WHEN SoDuKhachHang.DuCo_{0}>0 THEN SoDuKhachHang.DuNT_{0} ELSE -SoDuKhachHang.DuNT_{0} END) AS nt FROM SoDuKhachHang INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo WHERE MaKhachHang={1} AND SoHieu LIKE '{2}%'", _
                                     st, _
                                     ConvertToStrSafe(mkh), _
                                     shtk))
        End If
        duno = 0
        duco = 0
        dunt = 0
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            If Not IsDBNull(rsItem("n")) Then
                duno = ConvertToDblSafe(rsItem("n"))
                duco = ConvertToDblSafe(rsItem("c"))
                dunt = Math.Abs(ConvertToDblSafe(rsItem("nt")))
            End If
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
    ''' <param name="mtk"></param>
    ''' <param name="mkh"></param>
    ''' <param name="loai"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoNoTheoHoaDon(ByRef mtk As Integer, ByRef mkh As Integer, ByRef loai As Integer) As Double
        Dim sodu As Double
        If pCongNoHD = 0 Then
            Return 0
            Exit Function
        End If
        loai = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Kieu AS F1 FROM HethongTK WHERE MaSo={0}", mtk)))
        If loai < 0 Then
            sodu = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS-SoXuat) AS F1 FROM ChungTu WHERE MaTKNo={0} AND MaKH={1} AND SoPS>SoXuat", _
                                                       mtk, _
                                                       ConvertToStrSafe(mkh))))
            sodu += ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(DuNo_0-SoXuat) AS F1 FROM CNDauNam WHERE MaTaiKhoan={0} AND MaKhachHang={1} AND DuNo_0>SoXuat", _
                                                        mtk, _
                                                        ConvertToStrSafe(mkh))))
        Else
            sodu = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS-SoXuat) AS F1 FROM ChungTu WHERE MaTKCo={0} AND MaKHC={1} AND SoPS>SoXuat", _
                                                       mtk, _
                                                       ConvertToStrSafe(mkh))))
            sodu += ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(DuCo_0-SoXuat) AS F1 FROM CNDauNam WHERE MaTaiKhoan={0} AND MaKhachHang={1} AND DuCo_0>SoXuat", _
                                                        mtk, _
                                                        ConvertToStrSafe(mkh))))
        End If
        Return sodu
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="shtk"></param>
    ''' <param name="mcn"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="nx"></param>
    ''' <remarks></remarks>
    Public Sub BangKeTichSo2(ByRef shtk As String, ByRef mcn As Integer, ByRef ndau As Date, ByRef ncuoi As Date, Optional ByRef nx As Integer = 0)
        Dim rs As DataTable
        Dim n, n1 As Date
        Dim sql As String = String.Empty
        Dim ms As Integer
        Dim sdn, sdc As Double
        Dim sh As String = String.Empty
        Dim X As Double
        Dim rs2 As DataTable
        Dim k As Integer
        Dim mtk, mbc As Integer
        If shtk <> "" Then
            sh = shtk
            k = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 Kieu AS F1,MaSo AS F2 FROM HethongTK WHERE SoHieu LIKE '{0}%'", sh), mtk))
            sql = String.Format("SELECT -1 AS LoaiPS,NgayGS,Sum(SoPS) AS PS FROM (ChungTu INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo WHERE MaKH={0} AND {1} AND HethongTK.SoHieu LIKE '{2}%' AND CT_ID<>700000000 GROUP BY NgayGS UNION SELECT 1 AS LoaiPS,NgayGS,Sum(SoPS) AS PS FROM (ChungTu INNER JOIN HethongTK ON ChungTu.MaTKCo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKNo=TK.MaSo WHERE MaKHC={0} AND {1} AND HethongTK.SoHieu LIKE '{2}%' AND CT_ID<>700000000 GROUP BY NgayGS", mcn, WNgay("NgayGS", ndau, ncuoi), sh)
            rs = ExecSQLReturnDT("SELECT * FROM (" + sql + ") AS Mientru ORDER BY NgayGS")
            SoDuKHNgay(mcn, ndau.AddDays(-1), sdn, sdc, X, 0, sh)
            If nx = 0 Then
                ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
            End If
            mbc = Lng_MaxValue("MaSo", "BaoCaoCP2")
            n = ndau
            ms = mbc + 1
            ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten,MaCha,Kq3,Kq4,Ngay1) VALUES ({0}, N'{1}', N'{2}',{3},{4},{5}, N'{6}')", _
                                ms, _
                                tentk(shtk, 0), _
                                shtk, _
                                ConvertToStrSafe(mtk), _
                                ConvertToStrSafe(sdn), _
                                ConvertToStrSafe(sdc), _
                                Format(n, Mask_DB)))
            For Each rsItem As DataRow In rs.Rows
                If ConvertToDblSafe(rsItem("loaips")) < 0 Then
                    sdn += ConvertToDblSafe(rsItem("ps"))
                Else
                    sdc += ConvertToDblSafe(rsItem("ps"))
                End If
                If sdn - sdc >= 0 Then
                    sdn -= sdc
                    sdc = 0
                Else
                    sdc -= sdn
                    sdn = 0
                End If
                If ConvertToDateSafe(rsItem("NgayGS")) <> n Then
                    ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET Cap={0} WHERE MaSo={1}", _
                                        Math.Abs(DateDiff(DateInterval.Day, ConvertToDateSafe(rsItem("NgayGS")), n)), _
                                        ConvertToStrSafe(ms)))
                    n = ConvertToDateSafe(rsItem("NgayGS"))
                    ms += 1
                    ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten,MaCha,Kq1,Kq2,Kq3,Kq4,Ngay1) VALUES ({0}, N'{1}', N'{2}',{3},{4},{5},{6},{7}, N'{8}')", _
                                        ms, _
                                        ConvertToStrSafe(ms), _
                                        shtk, _
                                        ConvertToStrSafe(mtk), _
                                        IIf(ConvertToDblSafe(rsItem("loaips")) < 0, ConvertToStrSafe(rsItem("ps")), "0"), _
                                        (IIf(ConvertToDblSafe(rsItem("loaips")) > 0, ConvertToStrSafe(rsItem("ps")), "0")), _
                                        ConvertToStrSafe(sdn), _
                                        ConvertToStrSafe(sdc), _
                                        Format(n, Mask_DB)))
                Else
                    ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET {0},Kq3={1},Kq4={2} WHERE MaSo={3}", _
                                        (IIf(ConvertToDblSafe(rsItem("loaips")) < 0, String.Format("Kq1=Kq1+{0}", rsItem("ps")), String.Format("Kq2=Kq2+{0}", rsItem("ps")))), _
                                        ConvertToStrSafe(sdn), _
                                        ConvertToStrSafe(sdc), _
                                        ConvertToStrSafe(ms)))
                End If
            Next
            n1 = ncuoi
            If n <> n1 Then
                ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET Cap={0} WHERE MaSo={1}", _
                                    Math.Abs(DateDiff(DateInterval.Day, n1, n) + 1), _
                                    ConvertToStrSafe(ms)))
            Else
                ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET Cap=1 WHERE MaSo={0}", ms))
            End If
            ExecSQLNonQuery(String.Format("DELETE FROM BaoCaoCP2 WHERE Kq1=0 AND Kq2=0 AND Kq3=0 AND Kq4=0 AND MaSo>{0}", mbc))
            n = ConvertToDateSafe(GetSelectValue(String.Format("SELECT TOP 1 Ngay1 AS F1 FROM BaoCaoCP2 WHERE MaSo>{0} ORDER BY Ngay1", mbc)))
            X = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 LS AS F1 FROM LaiSuat INNER JOIN HethongTK ON LaiSuat.MaTK=HethongTK.MaSo WHERE HethongTK.SoHieu LIKE '{0}%' AND Ngay<=N'{1}' AND MaKH={2} ORDER BY Ngay DESC", _
                                                    sh, _
                                                    Format(n, Mask_DB), _
                                                    ConvertToStrSafe(mcn))))
            ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET Kq6={0} WHERE MaSo > {1}", CStr(ConvertToDblSafe(Format(X, Mask_2))), ConvertToStrSafe(mbc)))
            n = ncuoi.AddDays(1)
            rs = ExecSQLReturnDT(String.Format("SELECT * FROM BaoCaoCP2 WHERE MaSo > {0} ORDER BY Ngay1 DESC", mbc))
            For Each rsItem As DataRow In rs.Rows
                rs2 = ExecSQLReturnDT(String.Format("SELECT Ngay,LS FROM LaiSuat INNER JOIN HethongTK ON LaiSuat.MaTK=HethongTK.MaSo WHERE HethongTK.SoHieu LIKE '{0}%' AND Ngay >=N'{1}' AND Ngay < '{2}' ORDER BY Ngay DESC", _
                                          sh, _
                                          Format(ConvertToDateSafe(rsItem("ngay1")), Mask_DB), _
                                          Format(n, Mask_DB)))
                For Each rs2Item As DataRow In rs2.Rows
                    ms += 1
                    ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten,MaCha,Cap,Kq3,Kq4,Ngay1,Kq6) VALUES ({0}, N'{1}', N'{2}',{3},{4},{5},{6}, N'{7}',{8})", _
                                        ms, _
                                        ConvertToStrSafe(ms), _
                                        shtk, _
                                        ConvertToStrSafe(mtk), _
                                        Math.Abs(DateDiff(DateInterval.Day, n, ConvertToDateSafe(rs2Item("ngay")))), _
                                        rsItem("Kq3"), _
                                        rsItem("Kq4"), _
                                        Format(rs2Item("ngay"), Mask_DB), _
                                        CStr(ConvertToDblSafe(rs2Item("ls")))))
                    ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET Cap=Cap-{0} WHERE MaSo={1}", _
                                        Math.Abs(DateDiff(DateInterval.Day, n, ConvertToDateSafe(rs2Item("ngay")))), _
                                        rsItem("MaSo")))
                    n = ConvertToDateSafe(rs2Item("ngay"))
                Next
                n = ConvertToDateSafe(rsItem("ngay1"))
            Next
            ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET Kq5=Kq{0}*Cap WHERE MaSo>{1}", _
                                (IIf(k < 0, "3", "4")), _
                                ConvertToStrSafe(mbc)))
            ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET Kq7= cast(0.5+Kq5*Kq6/3000 AS INT) WHERE MaSo>{0}", mbc))
            ExecSQLNonQuery(String.Format("DELETE FROM BaoCaoCP2 WHERE Cap=0 AND MaSo>{0}", mbc))
        Else
            ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
            rs = ExecSQLReturnDT(String.Format("SELECT HethongTK.SoHieu FROM SoDuKhachHang INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo WHERE MaKhachHang={0} ORDER BY HethongTK.SoHieu", mcn))
            For Each rsItem As DataRow In rs.Rows
                BangKeTichSo(ConvertToStrSafe(rsItem("SoHieu")), mcn, ndau, ncuoi, 1)
            Next
        End If
        If nx = 0 Then
            rptFrom.InitForm("BKTSCN.RPT", "SELECT * FROM BaoCaoCP2", "BaoCaoCP2")
            rptFrom.ReportWindowTitle = "Bảng kê tích số"
            rptFrom.SetFormulas("ThoiGian", String.Format("'Từ ngày {0} đến {1}'", _
                                                        Format(ndau, Mask_DB), _
                                                        Format(ncuoi, Mask_DB)))
            rptFrom.SetFormulas("KH", String.Format("'{0} - {1}'", _
                                                        MaSo2SoHieu(mcn, "KhachHang"), _
                                                        TenKH("", mcn, "0")))
            RptSetDate(ncuoi)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="shtk"></param>
    ''' <param name="mcn"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="nx"></param>
    ''' <remarks></remarks>
    Public Sub BangKeTichSo(ByRef shtk As String, ByRef mcn As Integer, ByRef ndau As Date, ByRef ncuoi As Date, Optional ByRef nx As Integer = 0)
        Dim rs As DataTable
        Dim n, n1 As Date
        Dim sql As String = String.Empty
        Dim ms As Integer
        Dim sdn, sdc As Double
        Dim sh As String = String.Empty
        Dim X As Double
        Dim rs2 As DataTable
        Dim k As Integer
        Dim mtk, mbc As Integer
        If shtk <> "" Then
            sh = shtk
            k = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 Kieu AS F1,MaSo AS F2 FROM HethongTK WHERE SoHieu LIKE '{0}%'", sh), mtk))
            sql = String.Format("SELECT -1 AS LoaiPS,NgayGS,Sum(SoPS) AS PS FROM (ChungTu INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo WHERE MaKH={0} AND {1} AND HethongTK.SoHieu LIKE '{2}%' AND CT_ID<>700000000 GROUP BY NgayGS UNION SELECT 1 AS LoaiPS,NgayGS,Sum(SoPS) AS PS FROM (ChungTu INNER JOIN HethongTK ON ChungTu.MaTKCo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON ChungTu.MaTKNo=TK.MaSo WHERE MaKHC={0} AND {1} AND HethongTK.SoHieu LIKE '{2}%' AND CT_ID<>700000000 GROUP BY NgayGS", _
                      mcn, _
                      WNgay("NgayGS", ndau, ncuoi), _
                      sh)
            Dim Mientru As String = sql
            rs = ExecSQLReturnDT(String.Format("SELECT * FROM ({0}) AS Mientru ORDER BY NgayGS", Mientru))
            SoDuKHNgay(mcn, ndau.AddDays(-1), sdn, sdc, X, 0, sh)
            If nx = 0 Then
                ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
            End If
            mbc = Lng_MaxValue("MaSo", "BaoCaoCP2")
            n = ndau
            ms = mbc + 1
            ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten,MaCha,Kq3,Kq4,Ngay1) VALUES ({0}, N'{1}', N'{2}',{3},{4},{5}, N'{6}')", _
                                ms, _
                                tentk(shtk, 0), _
                                shtk, _
                                ConvertToStrSafe(mtk), _
                                ConvertToStrSafe(sdn), _
                                ConvertToStrSafe(sdc), _
                                Format(n, Mask_DB)))
            For Each rsItem As DataRow In rs.Rows
                If ConvertToDblSafe(rsItem("loaips")) < 0 Then
                    sdn += ConvertToDblSafe(rsItem("ps"))
                Else
                    sdc += ConvertToDblSafe(rsItem("ps"))
                End If
                If sdn - sdc >= 0 Then
                    sdn -= sdc
                    sdc = 0
                Else
                    sdc -= sdn
                    sdn = 0
                End If
                If ConvertToDateSafe(rsItem("NgayGS")) <> n Then
                    ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET Cap={0} WHERE MaSo={1}", _
                                        Math.Abs(DateDiff(DateInterval.Day, ConvertToDateSafe(rsItem("NgayGS")), n)), _
                                        ConvertToStrSafe(ms)))
                    n = ConvertToDateSafe(rsItem("NgayGS"))
                    ms += 1
                    ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten,MaCha,Kq1,Kq2,Kq3,Kq4,Ngay1) VALUES ({0}, N'{1}', N'{2}',{3},{4},{5},{6},{7}, N'{8}')", _
                                        ms, _
                                        ConvertToStrSafe(ms), _
                                        shtk, _
                                        ConvertToStrSafe(mtk), _
                                        IIf(ConvertToDblSafe(rsItem("loaips")) < 0, ConvertToDblSafe(rsItem("ps")), 0), _
                                        IIf(ConvertToDblSafe(rsItem("loaips")) > 0, ConvertToDblSafe(rsItem("ps")), 0), _
                                        ConvertToStrSafe(sdn), _
                                        ConvertToStrSafe(sdc), _
                                        Format(n, Mask_DB)))
                Else
                    ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET {0},Kq3={1},Kq4={2} WHERE MaSo={3}", _
                                        IIf(ConvertToDblSafe(rsItem("loaips")) < 0, _
                                            String.Format("Kq1=Kq1+{0}", rsItem("ps")), _
                                            String.Format("Kq2=Kq2+{0}", rsItem("ps"))), _
                                        ConvertToStrSafe(sdn), _
                                        ConvertToStrSafe(sdc), _
                                        ConvertToStrSafe(ms)))
                End If
            Next
            n1 = ncuoi
            If n <> n1 Then
                ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET Cap={0} WHERE MaSo={1}", _
                                    Math.Abs(DateDiff(DateInterval.Day, n1, n)) + 1, _
                                    ConvertToStrSafe(ms)))
            Else
                ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET Cap=1 WHERE MaSo={0}", ms))
            End If
            ExecSQLNonQuery(String.Format("DELETE FROM BaoCaoCP2 WHERE Kq1=0 AND Kq2=0 AND Kq3=0 AND Kq4=0 AND MaSo>{0}", mbc))
            n = ConvertToDateSafe(GetSelectValue(String.Format("SELECT TOP 1 Ngay1 AS F1 FROM BaoCaoCP2 WHERE MaSo>{0} ORDER BY Ngay1", mbc)))
            X = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 LS AS F1 FROM LaiSuat INNER JOIN HethongTK ON LaiSuat.MaTK=HethongTK.MaSo WHERE HethongTK.SoHieu LIKE '{0}%' AND Ngay<=N'{1}' AND MaKH={2} ORDER BY Ngay DESC", _
                                                    sh, _
                                                    Format(n, Mask_DB), _
                                                    ConvertToStrSafe(mcn))))
            ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET Kq6={0} WHERE MaSo>{1}", _
                                CStr(X), _
                                ConvertToStrSafe(mbc)))
            n = ncuoi.AddDays(1)
            rs = ExecSQLReturnDT(String.Format("SELECT * FROM BaoCaoCP2 WHERE MaSo>{0} ORDER BY Ngay1 DESC", mbc))
            For Each rsItem As DataRow In rs.Rows
                rs2 = ExecSQLReturnDT(String.Format("SELECT Ngay,LS FROM LaiSuat INNER JOIN HethongTK ON LaiSuat.MaTK=HethongTK.MaSo WHERE HethongTK.SoHieu LIKE '{0}%' AND Ngay>=N'{1}' AND Ngay<'{2}' ORDER BY Ngay DESC", _
                                          sh, _
                                          Format(ConvertToDateSafe(rsItem("ngay1")), Mask_DB), _
                                          Format(n, Mask_DB)))
                For Each rs2Item As DataRow In rs2.Rows
                    ms += 1
                    ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Ten,MaCha,Cap,Kq3,Kq4,Ngay1,Kq6) VALUES ({0}, N'{1}', N'{2}',{3},{4},{5},{6}, N'{7}',{8})", _
                                        ms, _
                                        ConvertToStrSafe(ms), _
                                        shtk, _
                                        ConvertToStrSafe(mtk), _
                                        Math.Abs(DateDiff(DateInterval.Day, n, ConvertToDateSafe(rs2Item("ngay")))), _
                                        rsItem("Kq3"), _
                                        rsItem("Kq4"), _
                                        Format(ConvertToDateSafe(rs2Item("ngay")), Mask_DB), _
                                        CStr(ConvertToDblSafe(Format(rs2("ls"), Mask_2)))))
                    ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET Cap=Cap-{0} WHERE MaSo={1}", _
                                        Math.Abs(DateDiff(DateInterval.Day, n, ConvertToDateSafe(rs2Item("ngay")))), _
                                        rsItem("MaSo")))
                    n = ConvertToDateSafe(rs2Item("ngay"))
                Next
                n = ConvertToDateSafe(rsItem("ngay1"))
            Next
            ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET Kq5=Kq{0}*Cap WHERE MaSo>{1}", _
                                (IIf(k < 0, "3", "4")), _
                                ConvertToStrSafe(mbc)))
            ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP2 SET Kq7=CAST(0.5+Kq5*Kq6/3000 AS INT) WHERE MaSo>{0}", mbc))
            ExecSQLNonQuery(String.Format("DELETE FROM BaoCaoCP2 WHERE Cap=0 AND MaSo>{0}", mbc))
        Else
            ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
            rs = ExecSQLReturnDT(String.Format("SELECT HethongTK.SoHieu FROM SoDuKhachHang INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo WHERE MaKhachHang={0} ORDER BY HethongTK.SoHieu", mcn))
            For Each rsItem As DataRow In rs.Rows
                BangKeTichSo(ConvertToDblSafe(rsItem("SoHieu")), mcn, ndau, ncuoi, 1)
            Next
        End If
        If nx = 0 Then
            rptFrom.InitForm("BKTS.RPT", "SELECT * FROM BaoCaoCP2", "BaoCaoCP2")
            rptFrom.ReportWindowTitle = "Bảng kê tích số"
            rptFrom.SetFormulas("ThoiGian", String.Format("'Từ ngày {0} đến {1}'", Format(ndau, Mask_DB), Format(ncuoi, Mask_DB)))
            rptFrom.SetFormulas("KH", String.Format("'{0} - {1}'", MaSo2SoHieu(mcn, "KhachHang"), TenKH("", mcn, "0")))
            RptSetDate(ncuoi)
        End If
    End Sub
End Module