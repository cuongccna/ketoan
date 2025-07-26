Imports System
Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Media
Imports System.Drawing
Imports UNET.Utility
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter
Imports Excel = Microsoft.Office.Interop.Excel


Module modTaikhoan
    Public pXuLyTKTC As Integer
    ''' <summary>
    ''' Hàm trả về mã số tai khoản từ số hiệu và mã nguyên tệ
    ''' </summary>
    ''' <param name="shnt"></param>
    ''' <param name="MaNT"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function MaTKNguyenTe(ByRef shnt As String, ByRef MaNT As Integer) As String
        Dim sql As String = String.Format("SELECT MaSo AS F1 FROM HethongTK WHERE SoHieu =N'{0}' AND MaNT {1}", _
                                shnt, _
                                (IIf(MaNT <= 0, " <= 0", String.Format(" = {0}", MaNT))))
        Return ConvertToStrSafe(GetSelectValue(sql))
    End Function
    ''' <summary>
    ''' Hàm trả về số dư tài khoản cuối tháng
    ''' </summary>
    ''' <param name="mtk"></param>
    ''' <param name="thang"></param>
    ''' <param name="duno"></param>
    ''' <param name="duco"></param>
    ''' <param name="nt"></param>
    ''' <param name="MaSo"></param>
    ''' <remarks></remarks>
    Public Sub SoDuTK(ByRef mtk As Long, ByRef thang As Integer, ByRef duno As Double, ByRef duco As Double, Optional ByRef nt As Double = 0, Optional ByRef MaSo As Long = 0)
        Dim sql As String = String.Empty, SoHieu As String = String.Empty, Y As Double, sh As String = String.Empty, sohieu1 As String = String.Empty

        sohieu1 = Timten("sohieu", CStr(mtk), "maso", "hethongtk")
        SoHieu = Left(sohieu1, 5)
        If MaSo <> 0 Then sh = Timten("sohieu", CStr(MaSo), "maso", "hethongtk")
        If SoHieu = "13311" Then
            duco = 0
            sql = "SELECT DuNo_" + CStr(thang - pThangDauKy) + " As F1 FROM HethongTK WHERE sohieu='" + CStr(sohieu1) + "'"
            duno = GetSelectValue(sql) + ConvertToDblSafe(GetSelectValue("select sum(sops) as f1 from chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso where t1.maloai<>3 and t2.sohieu='" + CStr(sohieu1) + "' and thangct=" + CStr(thang)))
            duno = duno - ConvertToDblSafe(GetSelectValue("select sum(sops) as f1 from chungtu t1 inner join hethongtk t2 on t1.matkco=t2.maso where t2.sohieu='" + CStr(sohieu1) + "' and thangct=" + CStr(thang)))
        Else
            If SoHieu = "33311" Then
                duno = 0
                Y = ConvertToDblSafe(GetSelectValue("select sum(sops) as f1 from chungtu t1 inner join hethongtk t2 on t1.matkco=t2.maso where t1.maloai=8 and left(t2.sohieu,5)='" + CStr(SoHieu) + "' and thangct=" + CStr(thang)))
                Y = Y - ConvertToDblSafe(GetSelectValue("select sum(sops) as f1 from chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso where (t1.maloai=8 or t1.maloai=3) and left(t2.sohieu,5)='" + CStr(SoHieu) + "' and thangct=" + CStr(thang)))
                sql = "SELECT DuNo_" + CStr(thang - pThangDauKy) + " As F1 FROM HethongTK WHERE Sohieu='" + CStr(sh) + "'"
                duco = GetSelectValue(sql) + ConvertToDblSafe(GetSelectValue("select sum(sops) as f1 from chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso where t1.maloai<>3 and t2.sohieu='" + CStr(sh) + "' and thangct=" + CStr(thang)))
                duco = duco - ConvertToDblSafe(GetSelectValue("select sum(sops) as f1 from chungtu t1 inner join hethongtk t2 on t1.matkco=t2.maso where t2.sohieu='" + CStr(sh) + "' and thangct=" + CStr(thang)))
                If Y - duco <= 0 Then
                    duco = Y
                End If
            End If
        End If
        If SoHieu <> "13311" And SoHieu <> "33311" Then
            sql = "SELECT DuNo_" + CStr(CThangDB(thang)) + " As F1, DuCo_" + CStr(CThangDB(thang)) + " As F2 FROM HethongTK WHERE MaSo=" + CStr(mtk)
            duno = GetSelectValue(sql, duco)
        End If

        sql = "SELECT DuNT_" + CStr(CThangDB(thang)) + " As F1 FROM HethongTK WHERE MaSo=" + CStr(mtk)
        nt = GetSelectValue(sql)

    End Sub
    ''' <summary>
    ''' Hàm trả về ký hiệu nguyên tệ từ mã số
    ''' </summary>
    ''' <param name="nt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoHieuNT(ByRef nt As Integer) As String
        Dim sql As String = String.Format("SELECT DISTINCT KyHieu AS F1 FROM NguyenTe WHERE MaSo={0}", nt)
        Return ConvertToStrSafe(GetSelectValue(sql))
    End Function
    ''' <summary>
    ''' Hàm trả về số dư tài khoản cuối ngày, chỉ cho tài khoản chi tiết
    ''' </summary>
    ''' <param name="mtk"></param>
    ''' <param name="Ngay"></param>
    ''' <param name="duno"></param>
    ''' <param name="duco"></param>
    ''' <param name="dunt"></param>
    ''' <remarks></remarks>
    Public Sub SoDuTKNgay(ByRef mtk As Integer, ByRef Ngay As Date, ByRef duno As Double, ByRef duco As Double, Optional ByRef dunt As Double = 0)
        Dim ps As Double
        ' Số đầu tháng
        Dim sql As String = String.Format("SELECT DuNo_0 AS F1, DuCo_0 AS F2,DuNT_0 AS F3 FROM HethongTK WHERE MaSo={0}", mtk)
        duno = ConvertToDblSafe(GetSelectValue(sql, duco, dunt))
        dunt = IIf(duno - duco > 0, Math.Abs(dunt), -Math.Abs(dunt))
        ' Số phát sinh nợ
        sql = String.Format("SELECT Sum(SoPS) AS F1,Sum(SoPS2No) AS F2 FROM ChungTu WHERE MaTKNo = {0} AND NgayGS <='{1}'", _
                  mtk, _
                  Format(CDate(Ngay), Mask_DB))
        duno += ConvertToDblSafe(GetSelectValue(sql, ps))
        dunt += ps
        ' Số phát sinh có
        sql = String.Format("SELECT Sum(SoPS) AS F1,Sum(SoPS2Co) AS F2 FROM ChungTu WHERE MaTKCo = {0} AND NgayGS <='{1}'", _
                  mtk, _
                  Format(CDate(Ngay), Mask_DB))
        duco += ConvertToDblSafe(GetSelectValue(sql, ps))
        dunt -= ps
        If duno > duco Then
            duno -= duco
            duco = 0
        Else
            duco -= duno
            duno = 0
        End If
        dunt = Math.Abs(dunt)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="shtk"></param>
    ''' <param name="Ngay"></param>
    ''' <param name="duno"></param>
    ''' <param name="duco"></param>
    ''' <param name="dunt"></param>
    ''' <remarks></remarks>
    Public Sub SoDuTKNgaySH(ByRef shtk As String, ByRef Ngay As Date, ByRef duno As Double, ByRef duco As Double, ByRef dunt As Double)
        Dim ps As Double
        ' Số đầu tháng
        Dim sql As String = String.Format("SELECT Sum(DuNo_0) AS F1, Sum(DuCo_0) AS F2, Sum(DuNT_0) AS F3 FROM HethongTK WHERE SoHieu=N'{0}'", shtk)
        duno = ConvertToDblSafe(GetSelectValue(sql, duco, dunt))
        dunt = IIf(duno - duco > 0, Math.Abs(dunt), -Math.Abs(dunt))
        ' Số phát sinh nợ
        sql = String.Format("SELECT Sum(SoPS) AS F1,Sum(SoPS2No) AS F2 FROM {0} WHERE HethongTK.SoHieu =N'{1}' AND NgayGS <='{2}'", _
                  ChungTu2TKNC(-1), _
                  shtk, _
                  Format(CDate(Ngay), Mask_DB))
        duno += ConvertToDblSafe(GetSelectValue(sql, ps))
        dunt += ps
        ' Số phát sinh có
        sql = String.Format("SELECT Sum(SoPS) AS F1,Sum(SoPS2Co) AS F2 FROM {0} WHERE HethongTK.SoHieu =N'{1}' AND NgayGS <='{2}'", _
                  ChungTu2TKNC(1), _
                  shtk, _
                  Format(CDate(Ngay), Mask_DB))
        duco += ConvertToDblSafe(GetSelectValue(sql, ps))
        dunt -= ps
        If duno > duco Then
            duno -= duco
            duco = 0
        Else
            duco -= duno
            duno = 0
        End If
        dunt = Math.Abs(dunt)
    End Sub
    ''' <summary>
    ''' Thủ tục in sổ cái tài khoản
    ''' </summary>
    ''' <param name="taikhoan"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="thongbao"></param>
    ''' <param name="doiung"></param>
    ''' <param name="VV"></param>
    ''' <param name="loai"></param>
    ''' <param name="nn"></param>
    ''' <param name="mdt1"></param>
    ''' <param name="mdt2"></param>
    ''' <param name="mdt3"></param>
    ''' <param name="thutudong"></param>
    ''' <param name="lan"></param>
    ''' <param name="kiemtraamhang"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InSocaiTk(ByRef taikhoan As ClsTaikhoan, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef thongbao As Boolean, ByRef doiung As String, ByRef VV As Integer, ByRef loai As Integer, Optional ByRef nn As Integer = 0, Optional ByRef mdt1 As Integer = 0, Optional ByRef mdt2 As Integer = 0, Optional ByRef mdt3 As Integer = 0, Optional ByRef thutudong As Integer = 0, Optional ByRef lan As Boolean = False, Optional ByRef kiemtraamhang As Integer = 0) As Boolean
        Dim result As Boolean = False
        Dim dkc, dkn, dknt As Double
        Dim ps As Boolean
        Dim sqlw As String = String.Empty
        Dim psn, psc, mact As Double
        Dim sh As String = String.Empty
        Dim tienam As Double
        Dim rs As DataTable
        Dim str As String = String.Empty
        Dim rs_nk As DataTable
        Dim sql As String = String.Empty
        If tcuoi > 0 Then
            sqlw = WThang("ThangCT", tdau, tcuoi)
            RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        Else
            sqlw = WNgay("NgayGS", ndau, ncuoi)
            RptSetDate(ncuoi)
        End If
        With taikhoan
            If tcuoi > 0 Then
                ps = .TkCoPS(tdau, tcuoi)
                .SoDuTK(ThangTruoc(tdau), dkn, dkc, dknt)
            Else
                ps = .TkCoPSN(ndau, ncuoi)
                .SoDuNgay(DateSerial(ndau.Year, ndau.Month, ndau.Day - 1), dkn, dkc, dknt)
            End If
            ' In bao cao
            Dim Qsocai As String
            If dkn <> 0 Or dkc <> 0 Or ps Then
                'Tạo số thứ tự
                If Not (thutudong = 6 And lan) Then
                    If taikhoan.sohieu.Length = 3 Then
                        thutudong = MessageBox.Show(Ngonngu("Có in thứ tự dòng theo nhật ký không?", "Do you print line with the diary?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    Else
                        thutudong = 7
                    End If
                End If
                If Not (thutudong = 7 Or loai <> 0) Then
                    sql = String.Format("SELECT DISTINCT MAX(ChungTu{0}.MaSo) AS MS,ChungTu{0}.MaCT, ChungTu{0}.SoHieu, ChungTu{0}.NgayCT, ChungTu{0}.NgayGS, ChungTu{0}.DienGiai{1}, Sum(SoPS) AS SumOfSoPS, HeThongTK.SoHieu AS sohieutk, HeThongTK.Ten{1}, -1 AS LoaiPS FROM {2} WHERE SoPS<>0 AND (MaTKTCNo) > 0 AND (((HeThongTK.loai) > 0) AND ((chungtu{0}.maloai <> 4) OR (chungtu{0}.maloai=4 AND matkno<>matkco)) AND {3}){4}{5}{6}{7} GROUP BY ChungTu{0}.MaCT, ChungTu{0}.SoHieu, ChungTu{0}.NgayCT, ChungTu{0}.NgayGS, ChungTu{0}.DienGiai{1}, HeThongTK.SoHieu, HeThongTK.Ten{1} UNION SELECT DISTINCT MAX(ChungTu{0}.MaSo) AS MS,ChungTu{0}.MaCT, ChungTu{0}.SoHieu, ChungTu{0}.NgayCT, ChungTu{0}.NgayGS, ChungTu{0}.DienGiai{1}, Sum(SoPS) AS SumOfSoPS, HeThongTK.SoHieu, HeThongTK.Ten{1}, 1 AS LoaiPS FROM {8} WHERE SoPS<>0 AND (MaTKTCCo) > 0 AND (((HeThongTK.loai) > 0) AND ((chungtu{0}.maloai <> 4) OR (chungtu{0}.maloai=4 AND matkno<>matkco)) AND ({3})){4}{5}{6}{7} GROUP BY ChungTu{0}.MaCT, ChungTu{0}.SoHieu, ChungTu{0}.NgayCT, ChungTu{0}.NgayGS, ChungTu{0}.DienGiai{1}, HeThongTK.SoHieu, HeThongTK.Ten{1}", _
                              sh, _
                              (IIf(pNN > 0, "", String.Empty)), _
                              ChungTu2TKNC(-1), _
                              sqlw, _
                              (IIf(VV > 1, String.Format(" AND (ChungTu{0}.MaDT = {1})", sh, ConvertToStrSafe(VV)), String.Empty)), _
                              (IIf(mdt1 > 0, String.Format(" AND (ChungTu{0}.MaDT1 = {1})", sh, ConvertToStrSafe(mdt1)), String.Empty)), _
                              (IIf(mdt2 > 0, String.Format(" AND (ChungTu{0}.MaDT2 = {1})", sh, ConvertToStrSafe(mdt2)), String.Empty)), _
                              (IIf(mdt3 > 0, String.Format(" AND (ChungTu{0}.MaDT3 = {1})", sh, ConvertToStrSafe(mdt3)), String.Empty)), _
                              ChungTu2TKNC(1))
                    Dim Mientru As String = sql, xoa As Integer = 0, strc As String, loaips As Integer = 0
                    rs_nk = ExecSQLReturnDT(String.Format("SELECT Mientru.* FROM ({0}) AS Mientru ORDER BY NgayGS,sohieu,sohieutk,loaips,sumofsops desc", Mientru))
                    If rs_nk.Rows.Count > 0 Then
                        ExecSQLNonQuery("DROP TABLE BKNhomPS")
                        ExecSQLNonQuery("CREATE TABLE [dbo].[BKNhomPS]([MaSo] [int] IDENTITY(1,1) NOT NULL,[MaCT] [int] NULL,[SoHieu] [nvarchar](20) NULL,[Ngay] [datetime] NULL,[DienGiai] [nvarchar](100) NULL,[SoPSNo] [float] NULL,[SoPSCo] [float] NULL,[ShDU] [nvarchar](20) NULL,[ShTK] [nvarchar](20) NULL,[SoPS2No] [float] NULL,[SoPS2Co] [float] NULL,[NgayGS] [datetime] NULL,[ShVT] [nvarchar](20) NULL) ON [PRIMARY]")
                    End If
                    For Each rsnkItem As DataRow In rs_nk.Rows
                        If mact <> ConvertToDblSafe(rsnkItem("MaCT")) Then
                            mact = ConvertToDblSafe(rsnkItem("MaCT"))
                            Dim strb As String = String.Format("INSERT INTO BKNhomPS(shtk,sohieu) VALUES(N'{0}', N'{1}')", _
                                                Lng_MaxValue("maso", "BKNhomPS") + 1, _
                                                rsnkItem("MaCT"))
                            ExecSQLNonQuery(strb)
                            If rsnkItem("sohieutk") Like taikhoan.sohieu & "*" Then
                                loaips = rsnkItem("loaips")
                            Else
                                loaips = -rsnkItem("loaips")
                            End If
                            xoa = 1
                        End If
                        If loaips = rsnkItem("loaips") And rsnkItem("sohieutk") Like taikhoan.sohieu & "*" Then
                            xoa = 0
                            strc = String.Format("INSERT INTO BKNhomPS(shtk,sohieu,sopsno,mact,ngay,sops2no,sopsco,DienGiai) VALUES(N'{0}', N'{1}',{0},{1},N'{2}',{3},{4}, N'{5}')", _
                                                Lng_MaxValue("maso", "BKNhomPS") + 1, _
                                                rsnkItem("MaCT"), _
                                                Format(CDate(rsnkItem("NgayGS")), "MM/dd/yyyy"), _
                                                rsnkItem("loaips"), _
                                                rsnkItem("sumofsops"), _
                                                0)
                            ExecSQLNonQuery(strc)
                        ElseIf xoa = 1 And rsnkItem("sohieutk") Like taikhoan.sohieu & "*" Then
                            xoa = 0
                            loaips = rsnkItem("loaips")
                            strc = String.Format("INSERT INTO BKNhomPS(shtk,sohieu,sopsno,mact,ngay,sops2no,sopsco,DienGiai) VALUES(N'{0}', N'{1}',{0},{1},N'{2}',{3},{4}, N'{5}')", _
                                                Lng_MaxValue("maso", "BKNhomPS") + 1, _
                                                rsnkItem("MaCT"), _
                                                Format(CDate(rsnkItem("NgayGS")), "MM/dd/yyyy"), _
                                                rsnkItem("loaips"), _
                                                rsnkItem("sumofsops"), _
                                                0)
                            ExecSQLNonQuery(strc)
                        Else
                            strc = String.Format("INSERT INTO BKNhomPS(shtk,sohieu,sopsno,mact,ngay,sops2no,sopsco,DienGiai) VALUES(N'{0}', N'{1}',{0},{1},N'{2}',{3},{4}, N'{5}')", _
                                                Lng_MaxValue("maso", "BKNhomPS") + 1, _
                                                rsnkItem("MaCT"), _
                                                Format(CDate(rsnkItem("NgayGS")), "MM/dd/yyyy"), _
                                                rsnkItem("loaips"), _
                                                rsnkItem("sumofsops"), _
                                                rsnkItem("sohieutk"))
                            ExecSQLNonQuery(strc)
                        End If
                    Next
                End If
                If thutudong = 6 Then
                    Dim MienTru1 As String = String.Format("SELECT ChungTu.MaCT, ChungTu.ThangCT, ChungTu.SoHieu as [ChungTu.SoHieu], ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0}, ChungTu.SoPS, ChungTu.{1} AS GhiChu, HeThongTK.SoHieu as [HeThongTK.SoHieu], HeThongTK_1.SoHieu as [HeThongTK_1.SoHieu], ChungTu.MaTKTCNo, ChungTu.MaTKTCCo, {2}+'10'+CONVERT(nvarchar,ChungTu.ThangCT)+ChungTu.SoHieu AS SH1 FROM HeThongTK AS HeThongTK_3 RIGHT JOIN (HeThongTK AS HeThongTK_2 RIGHT JOIN (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo) ON HeThongTK_2.MaSo = ChungTu.MaTKNo) ON HeThongTK_3.MaSo = ChungTu.MaTKCo WHERE SoPS<>0 AND ((HethongTK.SoHieu LIKE '{3}%'{4}) OR (HethongTK_1.SoHieu LIKE '{3}%'{5})) AND {6}{7}{8}{9}{10} AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco)) ", _
                                                  IIf(pNN > 0, "", String.Empty), _
                                                  IIf(tdau = 0 And tcuoi = 0, "mathuchi", "ghichu"), _
                                                  IIf(.kieu < 0, String.Format("CASE WHEN HethongTK.SoHieu LIKE '{0}%' THEN '0' ELSE '1' END", .sohieu), String.Format("CASE WHEN HethongTK.SoHieu LIKE '{0}%' THEN '1' ELSE '0' END", .sohieu)), _
                                                  taikhoan.sohieu, _
                                                  IIf(doiung.Length = 0, "", String.Format(" AND HethongTK_3.SoHieu LIKE '{0}%'", doiung)), _
                                                  IIf(doiung.Length = 0, "", String.Format(" AND HethongTK_2.SoHieu LIKE '{0}%'", doiung)), _
                                                  sqlw, _
                                                  IIf(VV > 1, String.Format(" AND (ChungTu.MaDT = {0})", VV), String.Empty), _
                                                  IIf(mdt1 > 0, String.Format(" AND (ChungTu.MaDT1 = {0})", mdt1), String.Empty), _
                                                  IIf(mdt2 > 0, String.Format(" AND (ChungTu.MaDT2 = {0})", mdt2), String.Empty), _
                                                  IIf(mdt3 > 0, String.Format(" AND (ChungTu.MaDT3 = {0})", mdt3), String.Empty))
                    Dim QNhatky As String = String.Format("SELECT Mientru1.MaCT, Mientru1.ThangCT, Mientru1.[ChungTu.SoHieu], Mientru1.NgayCT, Mientru1.NgayGS, Mientru1.DienGiai, Sum(Mientru1.SoPS) AS SoPS, Mientru1.GhiChu, Mientru1.[HeThongTK.SoHieu], Mientru1.[HeThongTK_1.SoHieu], Mientru1.MaTKTCNo, Mientru1.MaTKTCCo, Mientru1.SH1 FROM ({0}) AS Mientru1 GROUP BY Mientru1.MaCT, Mientru1.ThangCT, Mientru1.[ChungTu.SoHieu], Mientru1.NgayCT, Mientru1.NgayGS, Mientru1.DienGiai, Mientru1.GhiChu, Mientru1.[HeThongTK.SoHieu], Mientru1.[HeThongTK_1.SoHieu], Mientru1.MaTKTCNo, Mientru1.MaTKTCCo, Mientru1.SH1", MienTru1)
                    Qsocai = String.Format("SELECT t1.*,t2.sopsno,t2.maso FROM ({0}) t1 LEFT join bknhomps t2 on t1.mact=t2.mact AND (t1.[hethongtk.sohieu]=t2.DienGiai OR t1.[hethongtk_1.sohieu]=t2.DienGiai) WHERE LEFT(t2.DienGiai,len({1}))<>'{1}' OR (matktcco=0 AND LEFT(t2.DienGiai,len({1}))=N'{1}') OR (matktcno=0 AND LEFT(t2.DienGiai,len({1}))=N'{1}')", _
                                              QNhatky, _
                                              taikhoan.sohieu)
                Else
                    Qsocai = String.Format("SELECT ChungTu.MaCT, ChungTu.ThangCT, ChungTu.SoHieu as [ChungTu.SoHieu], ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0}, ChungTu.SoPS, ChungTu.{1} AS GhiChu, HeThongTK.SoHieu as [HeThongTK.SoHieu], HeThongTK_1.SoHieu as [HeThongTK_1.SoHieu], ChungTu.MaTKTCNo, ChungTu.MaTKTCCo, {2} + '10' + CAST(ChungTu.ThangCT AS NVARCHAR) + ChungTu.SoHieu AS SH1 FROM HeThongTK AS HeThongTK_3 RIGHT JOIN (HeThongTK AS HeThongTK_2 RIGHT JOIN (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo) ON HeThongTK_2.MaSo = ChungTu.MaTKNo) ON HeThongTK_3.MaSo = ChungTu.MaTKCo WHERE SoPS<>0 AND ((HethongTK.SoHieu LIKE '{3}%'{4}) OR (HethongTK_1.SoHieu LIKE '{3}%'{5})) AND {6}{7}{8}{9}{10} AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco))  ", _
                                    (IIf(pNN > 0, "", String.Empty)), _
                                    (IIf(tdau = 0 And tcuoi = 0, "mathuchi", "ghichu")), _
                                    (IIf(.kieu < 0, String.Format("CASE WHEN HethongTK.SoHieu LIKE '{0}%' THEN '0' ELSE '1' END", .sohieu), String.Format(" CASE WHEN (HethongTK.SoHieu LIKE '{0}%') THEN '1' ELSE '0' END", .sohieu))), _
                                    taikhoan.sohieu, _
                                    (IIf(doiung.Length = 0, "", String.Format(" AND HethongTK_3.SoHieu LIKE '{0}%'", doiung))), _
                                    (IIf(doiung.Length = 0, "", String.Format(" AND HethongTK_2.SoHieu LIKE '{0}%'", doiung))), _
                                    sqlw, _
                                    (IIf(VV > 1, String.Format(" AND (ChungTu.MaDT = {0})", VV), String.Empty)), _
                                    (IIf(mdt1 > 0, String.Format(" AND (ChungTu.MaDT1 = {0})", mdt1), String.Empty)), _
                                    (IIf(mdt2 > 0, String.Format(" AND (ChungTu.MaDT2 = {0})", mdt2), String.Empty)), _
                                    (IIf(mdt3 > 0, String.Format(" AND (ChungTu.MaDT3 = {0})", mdt3), String.Empty)))
                End If

                If loai = 0 Then
                    If taikhoan.sohieu.StartsWith("112") And tcuoi = 0 Then
                        rptFrom.InitForm("SOTG.RPT", Qsocai, "QChitiet")
                    Else
                        If taikhoan.sohieu.StartsWith("111") And tcuoi = 0 Then
                            rptFrom.InitForm("SOQUY.RPT", Qsocai, "Qsocai")
                            If Soquy = 1 Then rptFrom.InitForm("SOQUY1.RPT", Qsocai, "Qsocai")
                        Else
                            Dim rptFilename As String = IIf(taikhoan.sohieu.Length > 3 And rptFrom.ReportDestination = 1, _
                                                                         "SOCHITIET.RPT", _
                                                                         (IIf(thutudong = 6, "SOCAI.RPT", "SOCAI1.RPT")))
                            rptFrom.InitForm(rptFilename, Qsocai, "Qsocai")
                            rptFrom.SetFormulas("LastRow", ConvertToStrSafe(GetLastRow(Qsocai, "MaCT")))
                        End If
                    End If
                Else
                    If tdau = tcuoi Then
                        rptFrom.InitForm("SOCAI2.RPT", Qsocai, "Qsocai")
                    Else
                        rptFrom.InitForm("SOCAI3.RPT", Qsocai, "Qsocai")
                    End If
                End If

                rptFrom.SetFormulas("Thangcuoi", tcuoi)
                rptFrom.SetFormulas("SoHieuTK", String.Format("'{0}'", .sohieu))
                rptFrom.SetFormulas("NoDK", dkn - dkc)
                '************************** Biến khởi đầu kiểm tra âm quỷ *****************************
                tienam = dkn - dkc
                '*******************************************************************************************
                rptFrom.SetFormulas("Kieu", .kieu)
                rptFrom.SetFormulas("TenTK", String.Format("'{0} - {1}{2}'", _
                                                            .sohieu, _
                                                            (IIf(pNN > 0, .TenE, .ten)), _
                                                            (IIf(VV > 1, String.Format(" - VV: {0}", TenVV(VV)), String.Empty))))
                If tcuoi > 0 Then
                    rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
                    RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
                    psn = SoPSTK(taikhoan.sohieu, pThangDauKy, tcuoi, -1)
                    psc = SoPSTK(taikhoan.sohieu, pThangDauKy, tcuoi, 1)
                    If VV > 1 Then
                        taikhoan.SoDuTK(tcuoi, dkn, dkc, dknt)
                        rptFrom.SetFormulas("DuCK", IIf(taikhoan.kieu < 0, dkn - dkc, dkc - dkn))
                    End If
                Else
                    rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianN(ndau, ncuoi, nn)))
                    RptSetDate(ncuoi)
                    taikhoan.SoPhatSinhN(NgayDauThang(pNamTC, pThangDauKy), ncuoi, psn, dkn, psc, dkc)
                    If VV > 1 Then
                        taikhoan.SoDuNgay(ncuoi, dkn, dkc, dknt)
                        rptFrom.SetFormulas("DnCk", IIf(taikhoan.kieu < 0, dkn - dkc, dkc - dkn))
                    End If
                End If
                rptFrom.SetFormulas("NoLK", psn)
                rptFrom.SetFormulas("CoLK", psc)
                result = True

                If loai = 0 Then
                    If taikhoan.sohieu.StartsWith("112") And tcuoi = 0 Then
                        ' rptFrom.ReportFilename = "SOTG.RPT"
                    Else
                        If taikhoan.sohieu.StartsWith("111") And tcuoi = 0 Then
                            If kiemtraamhang = 0 Then
                                '************************************ Kiểm tra âm hàng **********************************************
                                rs = ExecSQLReturnDT("SELECT DISTINCT [chungtu.sohieu] as SoHieu, MaCT, ThangCT, NgayCT, NgayGS, DienGiai, sum(SoPS) AS ps, sh1 FROM (" & Qsocai & ") as qsocai GROUP BY [chungtu.sohieu], MaCT, ThangCT, NgayCT, NgayGS, DienGiai, sh1 ORDER BY ngaygs,sh1")
                                For Each rsItem As DataRow In rs.Rows
                                    If ConvertToStrSafe(rsItem("sh1")).StartsWith("0") Then
                                        tienam += ConvertToDblSafe(rsItem("ps"))
                                        If tienam <> 0 Then tienam = ConvertToDblSafe(Format(tienam, Mask_2))
                                    Else
                                        tienam -= ConvertToDblSafe(rsItem("ps"))
                                        If tienam <> 0 Then tienam = ConvertToDblSafe(Format(tienam, Mask_2))
                                    End If
                                    If tienam < 0 Then str = String.Format("{0}{1}, ", str, rsItem("SoHieu"))
                                Next
                                If str <> "" Then
                                    If MessageBox.Show(String.Format("Âm tiền tại chứng từ có số hiệu: {0}{1}Tiếp tục ?", Strings.Left(str, str.Length - 2), Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then result = False
                                End If
                                '************************************ Hết kiểm tra ****************************************************
                            End If
                            'rptFrom.ReportFilename = "SOQUY.RPT"
                            'If Soquy = 1 Then rptFrom.ReportFilename = "SOQUY1.RPT"
                        Else
                            'rptFrom.ReportFilename = iif(taikhoan.sohieu.Length > 3 AND rptFrom.ReportDestination = Crystal.DestinationConstants.crptToWindow, _
                            '"SOCHITIET.RPT", _
                            '(iif(thutudong = 6, "SOCAI.RPT", "SOCAI1.RPT")))
                            rptFrom.SetFormulas("LastRow", ConvertToDblSafe(GetLastRow(Qsocai, "MaCT")))
                        End If
                    End If
                    'Else
                    '    If tdau = tcuoi Then
                    '        rptFrom.ReportFilename = "SOCAI2.RPT"
                    '    Else
                    '        rptFrom.ReportFilename = "SOCAI3.RPT"
                    '    End If
                End If
            Else
                If thongbao Then MessageBox.Show("Không có số đầu kỳ hoặc phát sinh !", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                result = False
            End If
        End With
        Return result
    End Function
    ''' <summary>
    ''' Thủ tục in sổ chi tiết
    ''' </summary>
    ''' <param name="taikhoan"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="thongbao"></param>
    ''' <param name="doiung"></param>
    ''' <param name="VV"></param>
    ''' <param name="loai"></param>
    ''' <param name="nn"></param>
    ''' <param name="mdt1"></param>
    ''' <param name="mdt2"></param>
    ''' <param name="mdt3"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InSoChitiet(ByRef taikhoan As ClsTaikhoan, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef thongbao As Boolean, ByRef doiung As String, ByRef VV As Integer, Optional ByRef loai As Integer = 0, Optional ByRef nn As Integer = 0, Optional ByRef mdt1 As Integer = 0, Optional ByRef mdt2 As Integer = 0, Optional ByRef mdt3 As Integer = 0) As Boolean
        Dim result As Boolean = False
        Dim psn, dkc, dkn, dknt, psc As Double
        Dim ps As Boolean
        Dim sqlw As String = String.Empty
        Dim sql As String
        'Dim inso AS Boolean
        'Dim i,j AS Integer
        If tcuoi > 0 Then
            ps = taikhoan.TkCoPS(tdau, tcuoi)
            taikhoan.SoDuTK(ThangTruoc(tdau), dkn, dkc, dknt)
            sqlw = WThang("ThangCT", tdau, tcuoi)
        Else
            ps = taikhoan.TkCoPSN(ndau, ncuoi)
            sqlw = WNgay("NgayGS", ndau, ncuoi)
            taikhoan.SoDuNgay(DateSerial(ndau.Year, ndau.Month, ndau.Day - 1), dkn, dkc, dknt)
        End If
        If Not (dkn = 0 And dkc = 0 And (Not ps)) Then
            ' In bao cao
            Dim QChitiet As String
            sql = String.Format("((HethongTK_2.SoHieu LIKE '{0}%'{1}) OR (HethongTK_3.SoHieu LIKE '{0}%'{2}))", _
                      taikhoan.sohieu, _
                      (IIf(doiung.Length > 0, String.Format(" AND HethongTK_3.SoHieu LIKE '{0}%'", doiung), String.Empty)), _
                      (IIf(doiung.Length > 0, String.Format(" AND HethongTK_2.SoHieu LIKE '{0}%'", doiung), String.Empty)))
            QChitiet = String.Format("SELECT ChungTu.MaCT, ChungTu.SoHieu as [ChungTu.SoHieu], ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0}, ChungTu.SoPS, ChungTu.SoPS2No, ChungTu.SoPS2Co, ChungTu.GhiChu, HeThongTK.SoHieu as [HeThongTK.SoHieu], HeThongTK_1.SoHieu as [HeThongTK_1.SoHieu], ChungTu.MaTKNo, ChungTu.MaTKCo, HethongTK_2.SoHieu AS SHNo, HethongTK_3.SoHieu AS SHCo,ThangCT FROM HeThongTK AS HeThongTK_3 RIGHT JOIN (HeThongTK AS HeThongTK_2 RIGHT JOIN (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo) ON HeThongTK_2.MaSo = ChungTu.MaTKNo) ON HeThongTK_3.MaSo = ChungTu.MaTKCo WHERE SoPS<>0 AND ({1} AND ({2})){3}{4}{5}{6} AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco)) ORDER BY ChungTu.NgayGS,chungtu.sops desc", _
                                       (IIf(pNN > 0, "", String.Empty)), _
                                       sqlw, _
                                       sql, _
                                       (IIf(VV > 1, String.Format(" AND (ChungTu.MaDT = {0})", VV), String.Empty)), _
                                       (IIf(mdt1 > 0, String.Format(" AND (ChungTu.MaDT1 = {0})", mdt1), String.Empty)), _
                                       (IIf(mdt2 > 0, String.Format(" AND (ChungTu.MaDT2 = {0})", mdt2), String.Empty)), _
                                       (IIf(mdt3 > 0, String.Format(" AND (ChungTu.MaDT3 = {0})", mdt3), String.Empty)))

            If tcuoi > 0 Then
                If loai = 0 Then
                    rptFrom.InitForm("CTTK.RPT", QChitiet, "QChitiet")
                Else
                    rptFrom.InitForm("CTTK2.RPT", QChitiet, "QChitiet")
                End If
            Else
                Select Case taikhoan.sohieu.Substring(0, 3)
                    Case "112"
                        rptFrom.InitForm("SOTG.RPT", QChitiet, "QChitiet")
                    Case "311", "315", "341"
                        rptFrom.InitForm("SOTV.RPT", QChitiet, "QChitiet")
                    Case Else
                        rptFrom.InitForm("CTTK.RPT", QChitiet, "QChitiet")
                End Select
            End If

            rptFrom.SetFormulas("SoHieuTK", String.Format("'{0}'", taikhoan.sohieu))
            rptFrom.SetFormulas("NoDK", dkn - dkc)
            rptFrom.SetFormulas("Kieu", taikhoan.kieu)
            rptFrom.SetFormulas("TenTK", String.Format("'{0} - {1}{2}'", _
                                                        taikhoan.sohieu, _
                                                        (IIf(pNN > 0, taikhoan.TenE, taikhoan.ten)), _
                                                        (IIf(VV > 1, String.Format(" - VV: {0}", TenVV(VV)), String.Empty))))
            Dim tienam As Double
            tienam = IIf(taikhoan.kieu < 0, dkn - dkc, dkc - dkn)
            Dim rs As DataTable
            Dim str, SoHieu As String
            str = ""
            SoHieu = ""
            If tcuoi > 0 Then
                RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
                rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
                If VV > 1 Then
                    taikhoan.SoDuTK(tcuoi, dkn, dkc, dknt)
                    rptFrom.SetFormulas("DuCk", IIf(taikhoan.kieu < 0, dkn - dkc, dkc - dkn))
                End If
                psn = SoPSTK(taikhoan.sohieu, pThangDauKy, tcuoi, -1)
                psc = SoPSTK(taikhoan.sohieu, pThangDauKy, tcuoi, 1)
                If loai = 0 Then
                    rptFrom.SetFormulas("LastRow", ConvertToDblSafe(GetLastRow(QChitiet, "MaCT")))
                End If
            Else
                RptSetDate(ncuoi)
                rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianN(ndau, ncuoi, nn)))
                If VV > 1 Then
                    taikhoan.SoDuNgay(ncuoi, dkn, dkc, dknt)
                    rptFrom.SetFormulas("DuCk", IIf(taikhoan.kieu < 0, dkn - dkc, dkc - dkn))
                End If
                taikhoan.SoPhatSinhN(NgayDauThang(pNamTC, pThangDauKy), ncuoi, psn, dkn, psc, dkc)
                Select Case taikhoan.sohieu.Substring(0, 3)
                    Case "112"
                        '************************************ Kiểm tra âm tiền gửi **********************************************
                        Dim QChitiet1 = String.Format("SELECT ChungTu.MaCT, ChungTu.SoHieu as SoHieu, ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0}, ChungTu.SoPS, ChungTu.SoPS2No, ChungTu.SoPS2Co, ChungTu.GhiChu, HeThongTK.SoHieu as [HeThongTK.SoHieu], HeThongTK_1.SoHieu as [HeThongTK_1.SoHieu], ChungTu.MaTKNo, ChungTu.MaTKCo, HethongTK_2.SoHieu AS SHNo, HethongTK_3.SoHieu AS SHCo,ThangCT FROM HeThongTK AS HeThongTK_3 RIGHT JOIN (HeThongTK AS HeThongTK_2 RIGHT JOIN (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo) ON HeThongTK_2.MaSo = ChungTu.MaTKNo) ON HeThongTK_3.MaSo = ChungTu.MaTKCo WHERE SoPS<>0 AND ({1} AND ({2})){3}{4}{5}{6} AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco))", _
                                       (IIf(pNN > 0, "", String.Empty)), _
                                       sqlw, _
                                       sql, _
                                       (IIf(VV > 1, String.Format(" AND (ChungTu.MaDT = {0})", VV), String.Empty)), _
                                       (IIf(mdt1 > 0, String.Format(" AND (ChungTu.MaDT1 = {0})", mdt1), String.Empty)), _
                                       (IIf(mdt2 > 0, String.Format(" AND (ChungTu.MaDT2 = {0})", mdt2), String.Empty)), _
                                       (IIf(mdt3 > 0, String.Format(" AND (ChungTu.MaDT3 = {0})", mdt3), String.Empty)))
                        rs = ExecSQLReturnDT(String.Format("SELECT DISTINCT shno,shco ,SoHieu,sops AS ps FROM ({0}) as qchitiet order by sohieu", QChitiet1))
                        For Each rsItem As DataRow In rs.Rows
                            If ConvertToStrSafe(rsItem("shno")) Like String.Format("{0}*", taikhoan.sohieu) Then
                                tienam += ConvertToDblSafe(rsItem("ps"))
                                If tienam <> 0 Then tienam = ConvertToDblSafe(Format(tienam, Mask_2))
                            ElseIf ConvertToStrSafe(rsItem("shco")) Like String.Format("{0}*", taikhoan.sohieu) Then
                                tienam -= ConvertToDblSafe(rsItem("ps"))
                                If tienam <> 0 Then tienam = ConvertToDblSafe(Format(tienam, Mask_2))
                            End If
                            If tienam < 0 And SoHieu <> ConvertToStrSafe(rsItem("SoHieu")) Then
                                str = String.Format("{0}{1}, ", str, rsItem("SoHieu"))
                                SoHieu = ConvertToStrSafe(rsItem("SoHieu"))
                            End If
                        Next
                        If str <> "" Then
                            If MessageBox.Show(String.Format("Âm tiền tại chứng từ có số hiệu: {0}{1}Tiếp tục ?", Strings.Left(str, str.Length - 2), Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then : Return False
                            End If
                        End If
                        '************************************ Hết kiểm tra ****************************************************

                        rptFrom.SetFormulas("TenTK", String.Format("'{0}'", taikhoan.ten))
                    Case "311", "315", "341"
                        rptFrom.SetFormulas("TenTK", String.Format("'{0} - {1}'", taikhoan.sohieu, taikhoan.ten))
                    Case Else
                        rptFrom.SetFormulas("TenTK", String.Format("'{0} - {1}{2}'", _
                                                                    taikhoan.sohieu, _
                                                                    taikhoan.ten, _
                                                                    (IIf(VV > 1, String.Format(" - VV: {0}", TenVV(VV)), String.Empty))))

                        rptFrom.SetFormulas("LastRow", ConvertToDblSafe(GetLastRow(QChitiet, "MaCT")))
                End Select
            End If
            rptFrom.SetFormulas("NoLK", psn)
            rptFrom.SetFormulas("CoLK", psc)
            Return True
        End If
        If thongbao Then MessageBox.Show("Không có số đầu kỳ hoặc phát sinh !", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return result
    End Function
    ''' <summary>
    ''' Hàm trả về mã số, tên TK từ số hiệu
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <param name="mtk"></param>
    ''' <param name="CoCon"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function tentk(ByRef sh As String, ByRef mtk As Integer, Optional ByRef CoCon As Integer = 0) As String
        Dim result As String = String.Empty
        Dim rs_tk As DataTable
        If mtk > 0 Then
            rs_tk = ExecSQLReturnDT(String.Format("SELECT SoHieu,Ten,TKCon,TenE FROM HethongTK WHERE MaSo = {0}", mtk))
            If rs_tk.Rows.Count > 0 Then
                result = ConvertToDblSafe(rs_tk.Rows(0)("ten" & IIf(pNN = 1, "E", "")))
                sh = ConvertToStrSafe(rs_tk.Rows(0)("SoHieu"))
                CoCon = ConvertToDblSafe(rs_tk.Rows(0)("tkcon"))
            End If
        Else
            rs_tk = ExecSQLReturnDT(String.Format("SELECT MaSo,Ten,TKCon,TenE FROM HethongTK WHERE SoHieu=N'{0}'", sh))
            If rs_tk.Rows.Count > 0 Then
                mtk = ConvertToDblSafe(rs_tk.Rows(0)("MaSo"))
                result = ConvertToStrSafe(rs_tk.Rows(0)("ten" & IIf(pNN = 1, "E", "")))
                CoCon = ConvertToDblSafe(rs_tk.Rows(0)("tkcon"))
            Else
                mtk = 0
                result = ""
            End If
        End If
        Return result
    End Function
    ''' <summary>
    ''' Hàm trả về mã số, tên NTK từ mã số
    ''' </summary>
    ''' <param name="mnt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TenNT(ByRef mnt As Integer) As String
        Dim sql As String = String.Empty
        If mnt > 0 Then
            sql = String.Format("SELECT KyHieu AS F1 FROM NguyenTe WHERE MaSo={0}", mnt)
            Return ConvertToStrSafe(GetSelectValue(sql))
        Else
            Return String.Empty
        End If
    End Function
    ''' <summary>
    ''' Hàm trả về mã số tài khoản chitiết của một tài khoản
    ''' </summary>
    ''' <param name="mtk"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TKChitiet(ByRef mtk As Integer) As Integer
        Dim sql As String = String.Empty
        Dim X As Integer
        Dim MaCT As Integer = mtk
        Do While True
            sql = String.Format("SELECT MaSo AS F1 FROM HethongTK WHERE TkCha0 = {0} order by sohieu", MaCT)
            X = ConvertToDblSafe(GetSelectValue(sql))
            If X > 0 Then
                MaCT = ConvertToDblSafe(GetSelectValue(sql))
            Else
                Exit Do
            End If
        Loop
        Return MaCT
    End Function
    ''' <summary>
    ''' Hàm trả về mã số tài khoản tài chính của một tài khoản
    ''' </summary>
    ''' <param name="mtk"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TKTaiChinh(ByRef mtk As Integer) As Integer
        Dim sql As String = String.Empty
        Dim ms As Integer
        If mtk > 0 Then
            sql = String.Format("SELECT MaTC AS F1 FROM HethongTK WHERE MaSo = {0}", mtk)
            ms = ConvertToDblSafe(GetSelectValue(sql))
            Return IIf(ms > 0, ms, mtk)
        Else
            Return 0
        End If
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="VV"></param>
    ''' <param name="MaSo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TenVV(ByRef VV As Integer, Optional ByRef MaSo As Integer = 0) As String
        Dim sql As String = String.Format("SELECT DISTINCT DienGiai AS F1,maso AS f2 FROM DoituongCT WHERE MaSo = {0}", VV)
        Return ConvertToStrSafe(GetSelectValue(sql, MaSo))
    End Function
    ''' <summary>
    ''' Thu tuc xac dinh cac cap tai khoan
    ''' </summary>
    ''' <param name="shtk"></param>
    ''' <remarks></remarks>
    Public Sub XDCapTK(ByRef shtk As String)
        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET CapDuoi = 0 WHERE SoHieu LIKE '{0}%'", shtk))
        Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT DISTINCT TKCha0 FROM HethongTK WHERE (TKCon = 1) AND (SoHieu LIKE '{0}%') GROUP BY TKCha0", shtk))
        For Each rsItem As DataRow In rs.Rows
            ExecSQLNonQuery(String.Format("UPDATE HethongTK SET CapDuoi = 1 WHERE TKCha0 = {0}", rsItem("TkCha0")))
        Next
    End Sub
    ''' <summary>
    ''' Thu tuc cong don so du ket chuyen
    ''' </summary>
    ''' <param name="cap0"></param>
    ''' <remarks></remarks>
    Public Sub CongDonKC(ByRef cap0 As Boolean)
        Dim sql As String = String.Empty
        Dim rs_sub As DataTable
        Dim rs_taikhoan As DataTable = ExecSQLReturnDT("SELECT HethongTK.MaSo FROM HethongTK WHERE Cap>0 AND TKCon>0 ORDER BY SoHieu DESC")
        For Each rstkItem As DataRow In rs_taikhoan.Rows
            rs_sub = ExecSQLReturnDT(String.Format("SELECT DISTINCT Sum(HethongTK.KC_N) AS KCN, Sum(HethongTK.KC_C) AS KCC, Sum(DuNo) AS DN, Sum(DuCo) AS DC FROM HethongTK WHERE HethongTK.TkCha0 = {0}", rstkItem("MaSo")))
            ExecSQLNonQuery(String.Format("UPDATE HethongTK SET KC_N = {0}, KC_C = {1}, DuNo = {2}, DuCo = {3} WHERE MaSo = {4}", _
                                CStr(ConvertToDblSafe(rs_sub.Rows(0)("KCN"))), _
                                CStr(ConvertToDblSafe(rs_sub.Rows(0)("KCC"))), _
                                CStr(ConvertToDblSafe(rs_sub.Rows(0)("dn"))), _
                                CStr(ConvertToDblSafe(rs_sub.Rows(0)("DC"))), _
                                rstkItem("MaSo")))
        Next
        If cap0 Then
            rs_taikhoan = ExecSQLReturnDT("SELECT HethongTK.MaSo FROM HethongTK WHERE Cap=0")
            For Each rstkItem As DataRow In rs_taikhoan.Rows
                rs_sub = ExecSQLReturnDT(String.Format("SELECT DISTINCT Sum(HethongTK.KC_N) AS KCN, Sum(HethongTK.KC_C) AS KCC, Sum(DuNo) AS DN, Sum(DuCo) AS DC FROM HethongTK WHERE HethongTK.TkCha0 = {0}", rstkItem("MaSo")))
                ExecSQLNonQuery(String.Format("UPDATE HethongTK SET KC_N = {0}, KC_C = {1}, DuNo = {2}, DuCo = {3} WHERE MaSo = {4}", _
                                    CStr(ConvertToDblSafe(rs_sub.Rows(0)("KCN"))), _
                                    CStr(ConvertToDblSafe(rs_sub.Rows(0)("KCC"))), _
                                    CStr(ConvertToDblSafe(rs_sub.Rows(0)("dn"))), _
                                    CStr(ConvertToDblSafe(rs_sub.Rows(0)("DC"))), _
                                    rstkItem("MaSo")))
            Next
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="shtk"></param>
    ''' <param name="shct"></param>
    ''' <param name="tenct"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function MaTKFix(ByRef shtk As String, ByRef shct As String, ByRef tenct As String) As Integer
        Dim m As Integer
        Dim TK As ClsTaikhoan
        Dim tentk As String = String.Empty
        Dim sh As String = shtk
        Do Until m > 0
            m = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 MaSo AS F1 FROM HethongTK WHERE SoHieu=N'{0}' ORDER BY SoHieu", sh)))
            If m = 0 Then
                sh = ConvertToStrSafe(GetSelectValueDB(Connecstring, String.Format("SELECT TK.SoHieu AS F1, HethongTK.Ten AS F2 FROM HethongTK INNER JOIN HethongTK AS TK ON HethongTK.TKCha0=TK.MaSo WHERE HethongTK.SoHieu=N'{0}'", sh), tentk))
                If sh = "0" Or sh = "" Then Return 0
                If shct = "#" Then
                    shct = Strings.Right(shtk, shtk.Length - sh.Length)
                    tenct = tentk
                End If
            End If
        Loop
        If shct.Length > 0 And shct <> "#" And Not shtk.StartsWith("211") And Not shtk.StartsWith("214") Then
            TK = New ClsTaikhoan()
            TK.InitTaikhoanSohieu(sh, shct)
            If TK.maso > 0 Then
                m = TK.maso
            Else
                TK.InitTaikhoanMaSo(m)
                m = TK.ThemTKCon(shct, tenct, "...", 0, 0)
            End If
            TK = Nothing
        End If
        Return m
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="loaips"></param>
    ''' <param name="ps2"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoPSTK(ByRef sh As String, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef loaips As Integer, Optional ByRef ps2 As Double = 0) As Double
        Dim result As Double = 0
        Dim sql2 As New StringBuilder
        Dim sql As New StringBuilder
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            If i > 0 And i < 13 Then sql.AppendFormat("+{0}", (IIf(loaips < 0, String.Format("No_{0}", i), String.Format("Co_{0}", i))))
            If i > 0 And i < 13 Then sql2.AppendFormat("+{0}", (IIf(loaips < 0, String.Format("No_{0}_NT", i), String.Format("Co_{0}_NT", i))))
        Next
        If sql.ToString().Length > 0 Then result = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum({0}) AS F1,Sum({1}) AS F2 FROM HethongTK WHERE TKCon=0 AND SoHieu LIKE '{2}%'", _
                                                                                       sql, _
                                                                                       sql2, _
                                                                                       sh), ps2))
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ms"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="loaips"></param>
    ''' <param name="ps2"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoPSTKMaSo(ByRef ms As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef loaips As Integer, Optional ByRef ps2 As Double = 0) As Double
        Dim result As Double = 0
        Dim sql2 As New StringBuilder
        Dim sql As New StringBuilder
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            If i > 0 And i < 13 Then sql.AppendFormat("+{0}", (IIf(loaips < 0, String.Format("No_{0}", i), String.Format("Co_{0}", i))))
            If i > 0 And i < 13 Then sql2.AppendFormat("+{0}", (IIf(loaips < 0, String.Format("No_{0}_NT", i), String.Format("Co_{0}_NT", i))))
        Next
        If sql.ToString().Length > 0 Then result = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum({0}) AS F1,Sum({1}) AS F2 FROM HethongTK WHERE MaSo={2}", _
                                                                                       sql, _
                                                                                       sql2, _
                                                                                       ConvertToStrSafe(ms)), ps2))
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="loai"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoDuTKSH(ByRef sh As String, ByRef tcuoi As Integer, Optional ByRef loai As Integer = 0) As Double
        Dim result As Double = 0
        Dim st As String = ConvertToStrSafe(CThangDB2(tcuoi))
        Select Case loai
            Case 0
                result = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(CASE WHEN Kieu<0 THEN DuNo_{0}-DuCo_{0} ELSE DuCo_{0}-DuNo_{0} END) AS F1 FROM HethongTK WHERE SoHieu=N'{1}'", _
                                                             st, _
                                                             sh)))
            Case -1
                result = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(DuNo_{0}) AS F1 FROM HethongTK WHERE SoHieu=N'{1}'", _
                                                             st, _
                                                             sh)))
            Case 1
                result = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(DuCo_{0}) AS F1 FROM HethongTK WHERE SoHieu=N'{1}'", _
                                                             st, _
                                                             sh)))
        End Select
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="cap"></param>
    ''' <remarks></remarks>
    Public Sub XDSoHieuCap(ByRef cap As Integer)
        If cap < 1 Then Exit Sub
        ExecSQLNonQuery("DELETE FROM BaoCaoCP")
        ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP (MaSo,SoHieu) SELECT MaSo AS MS,SoHieu FROM HethongTK WHERE (Cap={0}) OR (Cap<{1} AND TKCon=0) GROUP BY SoHieu", _
                            cap, _
                            ConvertToStrSafe(cap)))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="shno"></param>
    ''' <param name="shco"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="shct"></param>
    ''' <param name="xl"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PSDu(ByRef shno As String, ByRef shco As String, ByRef tdau As Integer, ByRef tcuoi As Integer, Optional ByRef shct As String = "", Optional ByRef xl As Integer = 0) As Double
        Dim result As Double = 0
        result = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM {0} WHERE HethongTK.SoHieu LIKE '{1}%' AND TK.SoHieu LIKE '{2}%' AND {3}{4}", _
                                                     ChungTu2TKNC(0), _
                                                     shno, _
                                                     shco, _
                                                     WThang("ThangCT", tdau, tcuoi), _
                                                     (IIf(shct.Length > 0, String.Format(" AND RIGHT(HethongTK.SoHieu,{0})=N'{1}'", shct.Length, shct), String.Empty)))))
        If xl = 0 Then result += ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM {0} WHERE HethongTK.SoHieu LIKE '{1}%' AND ChungTu.GhiChu like '%{2}%' AND {3}{4}", _
                                                                     ChungTu2TKNC(-1), _
                                                                     shno, _
                                                                     shco, _
                                                                     WThang("ThangCT", tdau, tcuoi), _
                                                                     (IIf(shct.Length > 0, String.Format(" AND RIGHT(HethongTK.SoHieu,{0})=N'{1}'", shct.Length, shct), String.Empty)))))
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="xlapp"></param>
    ''' <param name="xlsheet"></param>
    ''' <param name="TK"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="dg"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function BKChiTiet(ByRef xlapp As Excel.Application, ByRef xlsheet As Excel.Worksheet, ByRef TK As String, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, Optional ByRef dg As String = "") As Boolean
        Dim result As Boolean = False
        Dim i As Integer
        Dim ctk As New ClsTaikhoan
        Dim DC, dn, dnt As Double
        Dim j As Integer
        Dim X As String = String.Empty
        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        Dim sql As String = String.Format("SELECT DISTINCT LEFT(HethongTK.SoHieu,3) AS SHN,LEFT(TK.SoHieu,3) AS SHC FROM {0} WHERE (HethongTK.SoHieu LIKE '{1}%' OR TK.SoHieu LIKE '{1}%') AND {2} AND SoPS<>0  GROUP BY LEFT(HethongTK.SoHieu,3),LEFT(TK.SoHieu,3)", _
                                ChungTu2TKNC(0), _
                                TK, _
                                wsql)
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        If rs.Rows.Count = 0 Then GoTo KgIn
        Recycle(String.Format("{0}\temp\CTPS.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}\{1}REPORTS\CTPS.XLS", pCurDir, Ngonngu("", "E")), String.Format("{0}\temp\CTPS.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\CTPS.XLS", pCurDir))
        xlsheet = xlapp.Worksheets(1)
        On Error GoTo 0
        xlsheet.Cells(1, 1) = pTenCty
        xlsheet.Cells(2, 1) = pTenCn
        If dg.Length > 0 Then
            xlsheet.Cells(3, 1) = String.Format("{0} {1}", dg, TK)
        Else
            xlsheet.Cells(3, 1).Value2 = String.Format("{0} {1}", xlsheet.Cells(3, 1).value, TK)
        End If
        xlsheet.Cells(4, 1).Value2 = IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi))
        For Each rsItem As DataRow In rs.Rows
            X = IIf(ConvertToStrSafe(rsItem("SHN")) <> TK.Substring(0, 3), ConvertToStrSafe(rsItem("SHN")), ConvertToStrSafe(rsItem("shc")))
            For j = 1 To i
                If instr(1, xlsheet.Cells(7, 4 + j).value, x) > 0 Then Continue For
            Next
            i += 1
            xlsheet.Cells(7, 4 + i).Value2 = IIf(ConvertToStrSafe(rsItem("SHN")) <> TK.Substring(0, 3), ConvertToStrSafe(rsItem("SHN")), ConvertToStrSafe(rsItem("shc")))
        Next
        xlsheet.Range("E6", String.Format("{0}6", XLSCol(4 + i))).MergeCells = True
        sql = String.Format("SELECT DISTINCT LEFT(HethongTK.SoHieu,3) AS SHN,LEFT(TK.SoHieu,3) AS SHC, ChungTu.SoHieu,DienGiai,SoPS,ngayct FROM {0} WHERE (HethongTK.SoHieu LIKE '{1}%' OR TK.SoHieu LIKE '{1}%') AND {2} AND SoPS<>0 ORDER BY NgayCT", _
                  ChungTu2TKNC(0), _
                  TK, _
                  wsql)
        rs = ExecSQLReturnDT(sql)
        j = 0
        For Each rsItem As DataRow In rs.Rows
            j += 1
            xlsheet.Cells(7 + j, 1).Value2 = IIf(ConvertToStrSafe(rsItem("SHN")) = TK.Substring(0, 3), ConvertToStrSafe(rsItem("SoHieu")), String.Empty)
            xlsheet.Cells(7 + j, 2).Value2 = IIf(ConvertToStrSafe(rsItem("shc")) = TK.Substring(0, 3), ConvertToStrSafe(rsItem("SoHieu")), String.Empty)
            xlsheet.Cells(7 + j, 3).Value2 = ConvertToStrSafe(rsItem("DienGiai"))
            xlsheet.Cells(7 + j, 4).Value2 = ConvertToStrSafe(rsItem("sops"))
            X = IIf(ConvertToStrSafe(rsItem("SHN")) <> TK.Substring(0, 3), ConvertToStrSafe(rsItem("SHN")), ConvertToStrSafe(rsItem("shc")))
            For k As Integer = 1 To i
                If InStr(1, xlsheet.Cells(7, 4 + k).value, X) >= 0 Then
                    xlsheet.Cells(7 + j, 4 + k).Value2 = ConvertToStrSafe(rsItem("sops"))
                    Exit For
                End If
            Next
        Next
        For k As Integer = 0 To i
            xlsheet.Range(XLSCol(4 + k) & ConvertToStrSafe(8 + j)).Formula = String.Format("=SUM({0}8:{0}{1})", XLSCol(4 + k), ConvertToStrSafe(7 + j))
        Next
        With xlsheet.Range("A6", XLSCol(4 + i) & ConvertToStrSafe(8 + j))
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders.Weight = Excel.XlBorderWeight.xlThin
            Dim tempRefParam As Object = .Borders.Color
            tempRefParam = Color.FromArgb(0, 0, 0)
            Dim tempRefParam2 As Object = .RowHeight
            tempRefParam2 = 18
            .Font.Size = 8
            Dim tempRefParam3 As Object = .VerticalAlignment
            tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
        End With
        xlsheet.Cells(9 + j, 1).Value2 = Ngonngu("Số dư đầu kỳ", "Opening balance")
        xlsheet.Cells(10 + j, 1).Value2 = Ngonngu("Số dư cuối kỳ", "Ending balance")
        ctk.InitTaikhoanSohieu(TK)
        ctk.SoDuNgay(DateSerial(ndau.Year, ndau.Month, ndau.Day - 1), dn, DC, dnt)
        xlsheet.Cells(9 + j, 2).Value2 = IIf(ctk.kieu < 0, dn - DC, DC - dn)
        ctk.SoDuNgay(ncuoi, dn, DC, dnt)
        xlsheet.Cells(10 + j, 2).Value2 = IIf(ctk.kieu < 0, dn - DC, DC - dn)
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\CTPS.XLS")
        GoTo KetThuc
KgIn:
KetThuc:
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="shno"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="mtp"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PSTKCP(ByRef shno As String, ByRef tdau As Integer, ByRef tcuoi As Integer, Optional ByRef mtp As Integer = 0) As Double
        Dim result As Double = 0
        result = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM {0} WHERE HethongTK.SoHieu LIKE '{1}%' AND {2}{3}", _
                                                     ChungTu2TKNC(-1), _
                                                     shno, _
                                                     WThang("ThangCT", tdau, tcuoi), _
                                                     (IIf(mtp > 0, String.Format(" AND MaTP={0}", mtp), String.Empty)))))
        Return result - ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM {0} WHERE MaLoai<>3 AND TK.SoHieu LIKE '{1}%' AND LEFT(HethongTK.SoHieu,3)<>'154' AND {2}{3}", _
                                                                 ChungTu2TKNC(0), _
                                                                 shno, _
                                                                 WThang("ThangCT", tdau, tcuoi), _
                                                                 (IIf(mtp > 0, String.Format(" AND MaTP={0}", mtp), String.Empty)))))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="taikhoan"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="thongbao"></param>
    ''' <param name="doiung"></param>
    ''' <param name="VV"></param>
    ''' <param name="nn"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InSocaiTk2(ByRef taikhoan As ClsTaikhoan, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef thongbao As Boolean, ByRef doiung As String, ByRef VV As Integer, Optional ByRef nn As Integer = 0) As Boolean
        Dim result As Boolean = False
        Dim dkc, dkn, dknt As Double
        Dim ps As Boolean
        With taikhoan
            Dim QSocai As String
            ps = .TkCoPS(tdau, tcuoi)
            .SoDuTK(ThangTruoc(tdau), dkn, dkc, dknt)
            ' In bao cao
            If dkn <> 0 Or dkc <> 0 Or ps Then
                If ps Then
                    QSocai = String.Format("SELECT DISTINCT CTGhiSo.SoHieu, (ChungTu.NgayCT) AS NCT, (CTGhiSo.DienGiai) AS DG, Sum(CASE WHEN HethongTK.SoHieu LIKE '{0}%'THEN ChungTu.SoPS ELSE 0 END) AS PSNo, Sum(CASE WHEN HethongTK_1.SoHieu LIKE '{0}%' THEN ChungTu.SoPS ELSE 0 END) AS PSCo, CASE WHEN HethongTK.SoHieu LIKE '{0}%' THEN HeThongTK_1.SoHieu ELSE HeThongTK.SoHieu END AS TKDu FROM (HeThongTK AS HeThongTK_3 RIGHT JOIN (HeThongTK AS HeThongTK_2 RIGHT JOIN (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo) ON HeThongTK_2.MaSo = ChungTu.MaTKNo) ON HeThongTK_3.MaSo = ChungTu.MaTKCo) INNER JOIN CTGhiSo ON ChungTu.CTGS=CTGhiSo.MaSo WHERE SoPS<>0 AND ((HethongTK.SoHieu LIKE '{0}%'{1}) OR (HethongTK_1.SoHieu LIKE '{0}%'{2})) AND {3}{4} AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco)) GROUP BY CTGhiSo.SoHieu, CASE WHEN HethongTK.SoHieu LIKE '{0}%' THEN HeThongTK_1.SoHieu ELSE HeThongTK.SoHieu END", _
                                        taikhoan.sohieu, _
                                        (IIf(doiung.Length = 0, "", String.Format(" AND HethongTK_3.SoHieu LIKE '{0}%'", doiung))), _
                                        (IIf(doiung.Length = 0, "", String.Format(" AND HethongTK_2.SoHieu LIKE '{0}%'", doiung))), _
                                        WThang("ThangCT", tdau, tcuoi), _
                                        (IIf(VV > 1, String.Format(" AND (ChungTu.MaDT = {0})", VV), String.Empty)))
                    rptFrom.InitForm("SOCAI4.RPT", QSocai, "QSocai")
                Else
                    QSocai = "SELECT DISTINCT '' AS SoHieu,Null AS NCT, '' AS DienGiai, 0 AS PSNo, 0 AS PSCo, '' AS TKDu FROM ChungTu WHERE (chungtu.MaCT = 0)"
                    rptFrom.InitForm("SOCAI4.RPT", QSocai, "QSocai")
                    rptFrom.SetFormulas("DuCk", IIf(.kieu < 0, dkn - dkc, dkc - dkn))
                End If

                rptFrom.SetFormulas("Sohieu", String.Format("'{0}'", .sohieu))
                rptFrom.SetFormulas("NoDKD", dkn - dkc)
                rptFrom.SetFormulas("Kieu", .kieu)
                rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
                rptFrom.SetFormulas("TenTK", String.Format("'{0} - {1}{2}'", _
                                                            .sohieu, _
                                                            (IIf(pNN > 0, .TenE, .ten)), _
                                                            (IIf(VV > 1, String.Format(" - VV: {0}", TenVV(VV)), String.Empty))))
                If VV > 1 Then
                    taikhoan.SoDuTK(tcuoi, dkn, dkc, dknt)
                    rptFrom.SetFormulas("DuCk", IIf(taikhoan.kieu < 0, dkn - dkc, dkc - dkn))
                End If
                rptFrom.SetFormulas("NoLK", SoPSTK(taikhoan.sohieu, pThangDauKy, tcuoi, -1))
                rptFrom.SetFormulas("CoLK", CStr(SoPSTK(taikhoan.sohieu, pThangDauKy, tcuoi, 1)))
                result = True

                RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
                InBaoCaoRPT()
            Else
                If thongbao Then MessageBox.Show("Không có số đầu kỳ hoặc phát sinh !", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                result = False
            End If
        End With
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoDuTKSHCP(ByRef sh As String, ByRef tcuoi As Integer) As Double
        Dim result As Double = 0
        result = ConvertToDblSafe(GetSelectValue(String.Format("SELECT DuNo_{0}-DuCo_{1} AS F1 FROM HethongTK WHERE SoHieu=N'{2}'", _
                                                     CThangDB2(tcuoi), _
                                                     ConvertToStrSafe(CThangDB2(tcuoi)), _
                                                     sh)))
        Return result + ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM {0} WHERE {1} AND MaLoai=3 AND HethongTK.SoHieu LIKE '{2}%'", _
                                                            ChungTu2TKNC(1), _
                                                            WThang("ThangCT", 0, tcuoi), _
                                                            sh)))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="VV"></param>
    ''' <param name="dktg"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="nn"></param>
    ''' <param name="p"></param>
    ''' <param name="mdt1"></param>
    ''' <param name="mdt2"></param>
    ''' <param name="mdt3"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InNhatKy(ByRef tdau As Integer, _
        ByRef tcuoi As Integer, _
        ByRef VV As Integer, _
        ByRef dktg As Integer, _
        ByRef ndau As Date, _
        ByRef ncuoi As Date, _
        Optional ByRef nn As Integer = 0, _
        Optional ByRef p As Integer = 0, _
        Optional ByRef mdt1 As Integer = 0, _
        Optional ByRef mdt2 As Integer = 0, _
        Optional ByRef mdt3 As Integer = 0) As Boolean
        Dim sqlw As String = String.Empty
        Dim sh As String = IIf(p > 0, "P", String.Empty)
        If dktg = 0 Then
            sqlw = WThang("ThangCT", tdau, tcuoi)
        Else
            sqlw = WNgay("NgayGS", ndau, ncuoi)
        End If
        Dim sql As String = String.Format("SELECT DISTINCT min(ChungTu{0}.MaSo) AS MS,ChungTu{0}.MaCT, ChungTu{0}.SoHieu as [ChungTu{0}.SoHieu], ChungTu{0}.NgayCT, ChungTu{0}.NgayGS, ChungTu{0}.DienGiai{1}, Sum(SoPS) AS SumOfSoPS, HeThongTK.SoHieu as [HeThongTK.SoHieu], HeThongTK.Ten{1}, -1 AS LoaiPS FROM {2} WHERE SoPS<>0 AND (MaTKTCNo > 0 or MaTKTCCo > 0) AND (((HeThongTK.loai) > 0) AND ((chungtu{0}.maloai <> 4) OR (chungtu{0}.maloai=4 AND matkno<>matkco)) AND {3}){4}{5}{6}{7} GROUP BY ChungTu{0}.MaCT, ChungTu{0}.SoHieu, ChungTu{0}.NgayCT, ChungTu{0}.NgayGS, ChungTu{0}.DienGiai{1}, HeThongTK.SoHieu, HeThongTK.Ten{1} UNION SELECT DISTINCT min(ChungTu{0}.MaSo) AS MS,ChungTu{0}.MaCT, ChungTu{0}.SoHieu, ChungTu{0}.NgayCT, ChungTu{0}.NgayGS, ChungTu{0}.DienGiai{1}, Sum(SoPS) AS SumOfSoPS, HeThongTK.SoHieu as [HeThongTK.SoHieu], HeThongTK.Ten{1}, 1 AS LoaiPS FROM {8} WHERE SoPS<>0 AND (MaTKTCCo) > 0 AND (((HeThongTK.loai) > 0) AND ((chungtu{0}.maloai <> 4) OR (chungtu{0}.maloai=4 AND matkno<>matkco)) AND ({3})){4}{5}{6}{7} GROUP BY ChungTu{0}.MaCT, ChungTu{0}.SoHieu, ChungTu{0}.NgayCT, ChungTu{0}.NgayGS, ChungTu{0}.DienGiai{1}, HeThongTK.SoHieu, HeThongTK.Ten{1}", _
                                sh, _
                                (IIf(pNN > 0, "", String.Empty)), _
                                ChungTu2TKNC(-1, p), _
                                sqlw, _
                                (IIf(VV > 1, String.Format(" AND (ChungTu{0}.MaDT = {1})", sh, ConvertToStrSafe(VV)), String.Empty)), _
                                (IIf(mdt1 > 0, String.Format(" AND (ChungTu{0}.MaDT1 = {1})", sh, ConvertToStrSafe(mdt1)), String.Empty)), _
                                (IIf(mdt2 > 0, String.Format(" AND (ChungTu{0}.MaDT2 = {1})", sh, ConvertToStrSafe(mdt2)), String.Empty)), _
                                (IIf(mdt3 > 0, String.Format(" AND (ChungTu{0}.MaDT3 = {1})", sh, ConvertToStrSafe(mdt3)), String.Empty)), _
                                ChungTu2TKNC(1, p))
        Dim QNhatKy As String = String.Format("SELECT * FROM ({0}) AS Mientru ORDER BY NgayGS,mact,mientru.[hethongtk.sohieu],loaips,sumofsops desc", sql)
        rptFrom.InitForm("NHATKY.RPT", QNhatKy, "QNhatky")
        If dktg = 0 Then
            RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        Else
            RptSetDate(ncuoi)
        End If
        If VV > 1 Then
            rptFrom.SetFormulas("VV", String.Format("'VV: {0}'", TenVV(VV)))
        End If
        rptFrom.SetFormulas("Rows", ConvertToDblSafe(GetLastRow(QNhatKy, "MaCT")))
        rptFrom.SetFormulas("thang", tdau)
        rptFrom.SetFormulas("ThangCuoi", tcuoi)
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        Return True
    End Function
    ''' <summary>
    ''' Thủ tục xác định các phát sinh do kết chuyển
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Public Sub XacdinhKC(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim sql As String = String.Empty
        Dim rs_sub As DataTable
        Dim i As Integer
        ExecSQLNonQuery(String.Format("UPDATE HethongTK SET KC_N = 0, KC_C = 0, DuNo = DuNo_{0}, DuCo = DuCo_{1}", _
                            CThangDB2(tcuoi), _
                            ConvertToStrSafe(CThangDB2(tcuoi))))
        Dim QCdt As String = String.Format("SELECT DISTINCT ChungTu.MaTkNo, SUM(SoPS) AS KC_N FROM ChungTu WHERE (ChungTu.MaLoai = 3) AND {0} GROUP BY ChungTu.MaTkNo", WThang("ThangCT", tdau, tcuoi))
        Dim QChitiet As String = String.Format("SELECT DISTINCT ChungTu.MaTkCo, SUM(SoPS) AS KC_C FROM ChungTu WHERE (ChungTu.MaLoai = 3) AND {0} GROUP BY ChungTu.MaTkCo", WThang("ThangCT", tdau, tcuoi))
        Dim rs_taikhoan As DataTable = ExecSQLReturnDT(String.Format("SELECT DISTINCT  QCdt.* FROM ({0}) AS QCdt", QCdt))
        For Each rstkItem As DataRow In rs_taikhoan.Rows
            sql = String.Format("UPDATE HethongTK SET KC_N = {0}, DuCo = DuCo + {0} WHERE MaSo = {1}", _
                             CStr(ConvertToDblSafe(rstkItem("KC_N"))), _
                             rstkItem("MaTkNo"))
            ExecSQLNonQuery(sql)
            i = 1
        Next
        rs_taikhoan = ExecSQLReturnDT(String.Format("SELECT DISTINCT  QChitiet.* FROM ({0}) AS QChitiet", QChitiet))
        For Each rstkItem As DataRow In rs_taikhoan.Rows
            sql = String.Format("UPDATE HethongTK SET KC_C = {0}, DuNo = DuNo + {0} WHERE MaSo = {1}", _
                      CStr(ConvertToDblSafe(rstkItem("KC_C"))), _
                      rstkItem("MaTkCo"))
            ExecSQLNonQuery(sql)
            i = 1
        Next
        ExecSQLNonQuery("UPDATE HethongTK SET DuNo = 0, DuCo = 0 WHERE TkCon = 0 AND DuNo = DuCo")
        If i > 0 Then
            rs_taikhoan = ExecSQLReturnDT(String.Format("SELECT HethongTK.MaSo FROM HethongTK WHERE Cap>0 AND TKCon>0 ORDER BY SoHieu DESC"))
            For Each rstaikhoanItem As DataRow In rs_taikhoan.Rows
                rs_sub = ExecSQLReturnDT(String.Format("SELECT DISTINCT Sum(HethongTK.KC_N) AS KCN, Sum(HethongTK.KC_C) AS KCC, Sum(DuNo) AS DN, Sum(DuCo) AS DC FROM HethongTK WHERE HethongTK.TkCha0 = {0}", rstaikhoanItem("MaSo")))
                If rs_sub.Rows.Count > 0 Then
                    Dim rsSubItem As DataRow = rs_sub.Rows(0)
                    ExecSQLNonQuery(String.Format("UPDATE HethongTK SET KC_N = {0}, KC_C = {1}, DuNo = {2}, DuCo = {3} WHERE MaSo = {4}", _
                                                        CStr(ConvertToDblSafe(rsSubItem("KCN"))), _
                                                        CStr(ConvertToDblSafe(rsSubItem("KCC"))), _
                                                        CStr(ConvertToDblSafe(rsSubItem("dn"))), _
                                                        CStr(ConvertToDblSafe(rsSubItem("DC"))), _
                                                        rstaikhoanItem("MaSo")))
                End If
            Next
            rs_taikhoan = ExecSQLReturnDT("SELECT HethongTK.MaSo FROM HethongTK WHERE Cap=0 AND TKCon>0")
            For Each rsTaikhoanItem As DataRow In rs_taikhoan.Rows
                rs_sub = ExecSQLReturnDT(String.Format("SELECT DISTINCT Sum(HethongTK.KC_N) AS KCN, Sum(HethongTK.KC_C) AS KCC, Sum(DuNo) AS DN, Sum(DuCo) AS DC FROM HethongTK WHERE HethongTK.TkCha0 = {0}", rsTaikhoanItem("MaSo")))
                ExecSQLNonQuery(String.Format("UPDATE HethongTK SET KC_N = {0}, KC_C = {1}, DuNo = {2}, DuCo = {3} WHERE MaSo = {4}", _
                                    CStr(ConvertToDblSafe(rs_sub.Rows(0)("KCN"))), _
                                    CStr(ConvertToDblSafe(rs_sub.Rows(0)("KCC"))), _
                                    CStr(ConvertToDblSafe(rs_sub.Rows(0)("dn"))), _
                                    CStr(ConvertToDblSafe(rs_sub.Rows(0)("DC"))), _
                                    rsTaikhoanItem("MaSo")))
            Next
            rs_sub = Nothing
        End If
        ''rs_taikhoan.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="TK"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoPSTK2(ByRef TK As ClsTaikhoan, ByRef tdau As Integer, ByRef tcuoi As Integer) As Double
        Dim result As Double = 0
        Dim sql As New StringBuilder
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            If i > 0 And i < 13 Then sql.Append("+" & (IIf(TK.kieu < 0, String.Format("No_{0}", i), "Co_" & i)))
        Next
        If sql.ToString().Length > 0 Then result = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum({0}) AS F1 FROM HethongTK WHERE SoHieu='{1}'", sql, TK.sohieu)))
        If TK.loai > 4 Then result = ConvertToDblSafe(result - ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM {0} WHERE MaLoai<>3 AND HethongTK.SoHieu LIKE '{1}%' AND {2}", ChungTu2TKNC(IIf(TK.kieu < 0, 1, -1)), TK.sohieu, WThang("ThangCT", tdau, tcuoi)))))
        Return result
    End Function
    Public Function GetTK_ID(ByRef sh As String, ByRef mtk As Integer, Optional ByRef kieu As Integer = 0, Optional ByRef tkcon As Integer = 0) As Integer
        Return ConvertToDblSafe(GetSelectValue(String.Format("SELECT TK_ID AS F1,Kieu AS F2,TKCon AS F3,MaSo AS F4 FROM HethongTK WHERE {0}", (IIf(mtk > 0, "MaSo=" & mtk, "SoHieu='" & sh & "'"))), _
                                    kieu, _
                                    tkcon, _
                                    mtk))
    End Function
    Public Sub SoPSTKN(ByRef shtk As String, ByRef ndau As Date, ByRef ncuoi As Date, ByRef psn As Double, ByRef psc As Double)
        Dim sql As String = String.Format("SELECT DISTINCT Sum(SoPS) AS F1 FROM {0}WHERE HethongTK.SoHieu LIKE '{1}%' AND {2}", _
                                ChungTu2TKNC(-1), _
                                shtk, _
                                WNgay("NgayGS", ndau, ncuoi))
        psn = ConvertToDblSafe(GetSelectValue(sql))
        sql = String.Format("SELECT DISTINCT Sum(SoPS) AS F1 FROM {0}WHERE HethongTK.SoHieu LIKE '{1}%' AND {2}", _
                  ChungTu2TKNC(1), _
                  shtk, _
                  WNgay("NgayGS", ndau, ncuoi))
        psc = ConvertToDblSafe(GetSelectValue(sql))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="shtk"></param>
    ''' <param name="cap"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function LaySHTKCapTren(ByRef shtk As String, ByRef cap As Integer) As String
        Dim c As Integer
        Dim sh As String = shtk
        If cap > 0 Then
            c = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Cap AS F1 FROM HethongTK WHERE SoHieu='{0}'", sh)))
            For i As Integer = cap + 1 To c
                sh = ConvertToStrSafe(GetSelectValue(String.Format("SELECT TK.SoHieu AS F1 FROM HethongTK INNER JOIN HethongTK AS TK ON HethongTK.TKCha0=TK.MaSo WHERE HethongTK.SoHieu='{0}'", sh)))
            Next
        End If
        Return sh
    End Function

End Module
