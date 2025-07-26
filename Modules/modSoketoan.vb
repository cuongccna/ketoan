Imports System
Imports System.Text
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter
Imports Excel = Microsoft.Office.Interop.Excel


Module ModSoketoan
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="dktg"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <remarks></remarks>
    Sub SoDangKyCT(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef dktg As Integer, ByRef ndau As Date, ByRef ncuoi As Date)
        Dim sqlw As String = String.Empty
        If dktg = 0 Then
            sqlw = WThang("ThangCT", tdau, tcuoi)
            rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        Else
            sqlw = WNgay("NgayGS", ndau, ncuoi)
            rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianN(ndau, ncuoi)))
        End If
        Dim QNhatKy As String = String.Format("SELECT CTGhiSo.SoHieu, CTGhiSo.DienGiai,Sum(SoPS) AS TPS FROM ({0}) INNER JOIN CTGhiSo ON ChungTu.CTGS=CTGhiSo.MaSo WHERE {1} AND HethongTK.Loai>0 GROUP BY CTGhiSo.SoHieu, CTGhiSo.DienGiai", ChungTu2TKNC(-1), sqlw)
        rptFrom.InitForm("SODKCT.RPT", QNhatKy, "QNhatKy")
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        rptFrom.SetFormulas("PSLK", ConvertToDblSafe(GetSelectValue(String.Format("SELECT Sum(SoPS) AS F1 FROM {0} WHERE {1} AND HethongTK.Loai>0", ChungTu2TKNC(-1), WThang("ThangCT", 0, tcuoi)))))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="GauGe"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="mkho"></param>
    ''' <param name="shtk"></param>
    ''' <param name="CK"></param>
    ''' <remarks></remarks>
    Sub THDoanhThuGiaVon(ByRef GauGe As ProgressBar, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef mkho As Integer, ByRef shtk As String, ByRef CK As Integer)
        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        Dim sql As String
        GauGe.Maximum = 3
        ExecSQLNonQuery("DELETE FROM BaoCaoCP")
        ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP (MaSo,SoHieu,Kq1,Kq2) SELECT DISTINCT MaVattu,MaVattu,Sum(SoPS2Co) AS SL,Sum(SoPS- CASE WHEN ({0}>0) THEN CK ELSE 0 END) AS TT FROM {1} WHERE TK_ID={2} AND {3}{4}{5} GROUP BY MaVattu", _
                            CK, _
                            ChungTu2TKNC(1), _
                            TKDT_ID, _
                            wsql, _
                            (IIf(mkho > 0, " AND MaKho=" & mkho, String.Empty)), _
                            (IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty))))
        GauGe.Value = 2
        sql = String.Format("SELECT ChungTu.SoHieu FROM {0} WHERE TK_ID={1} AND {2}{3}{4} GROUP BY ChungTu.SoHieu", _
                              ChungTu2TKNC(1), _
                              ConvertToStrSafe(TKDT_ID), _
                              wsql, _
                              (IIf(mkho > 0, String.Format(" AND MaKho={0}", mkho), String.Empty)), _
                              (IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty)))
        ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
        sql = String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,Kq3) SELECT DISTINCT MaVattu,MaVattu,Sum(SoPS) FROM ({0}) INNER JOIN ({3}) Mientru ON ChungTu.SoHieu=Mientru.SoHieu+'GV' WHERE HethongTK.SoHieu LIKE '632%' AND {1}{2} GROUP BY MaVattu", _
                            ChungTu2TKNC(-2), _
                            wsql, _
                            (IIf(mkho > 0, String.Format(" AND MaKho={0}", mkho), String.Empty)), _
                            sql)
        ExecSQLNonQuery(sql)
        GauGe.Value = 1
        sql = "SELECT Vattu.SoHieu,TenVattu,DonVi, PhanLoaiVattu.SoHieu AS SHPL,TenPhanLoai,BaoCaoCP.Kq1,BaoCaoCP.Kq2,BaoCaoCP2.Kq3 FROM ((BaoCaoCP LEFT JOIN BaoCaoCP2 ON BaoCaoCP.MaSo=BaoCaoCP2.MaSo) INNER JOIN Vattu ON BaoCaoCP.MaSo=Vattu.MaSo) INNER JOIN PhanLoaiVattu ON Vattu.MaPhanLoai=PhanLoaiVattu.MaSo"
        rptFrom.InitForm("GiaVon1.RPT", sql, "QLuyKe")

        RptSetDate(IIf(tdau > 0, NgayCuoiThang(pNamTC, tcuoi), ncuoi))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi)))))
        If mkho > 0 Then rptFrom.SetFormulas("TenKho", String.Format(Ngonngu("'Kho: {0}'", "'Stock: {0}'"), tenkho(mkho)))
        If shtk.Length > 0 Then rptFrom.SetFormulas("DG", String.Format("'TK: {0}'", shtk))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="GauGe"></param>
    ''' <param name="sql"></param>
    ''' <param name="curSheet"></param>
    ''' <param name="RowIdx"></param>
    ''' <param name="StartCol"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function PrintSQLLuyKe(ByRef GauGe As ProgressBar, ByRef sql As String, ByVal curSheet As Excel.Worksheet, ByVal RowIdx As Integer, ByRef StartCol As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer) As Integer
        Dim dong As Integer
        Dim Dieukien As String = String.Empty
        Dim tiennhap, dktien, tienxuat, ttn, ttdk, tldk, tln, ttt, ttx, tlx, tlt As Double
        Dim ngaybc As Date
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        GauGe.Maximum = rs.Rows.Count
        GauGe.Value = 0
        If tdau = tcuoi Then
            curSheet.Cells(3 = 3).Value = String.Format("Tháng {0}/{1}", tcuoi, ConvertToStrSafe(pNamTC))
        Else
            curSheet.Cells(3 = 3).Value = String.Format("Từ tháng {0}/{1} đến tháng {2}/{1}", tdau, ConvertToStrSafe(pNamTC), ConvertToStrSafe(tcuoi))
        End If
        If rs.Rows.Count > 0 Then
            If rs.Rows.Count > 1 Then
                curSheet.Range(String.Format("{0}:{1}", ConvertToStrSafe(RowIdx + 1), ConvertToStrSafe(RowIdx + rs.Rows.Count - 2 + 1))).EntireRow.Insert()
            End If
            Dim rsIndex As Integer = 0
            While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                GauGe.Value += 1
                If Dieukien <> rsItem("shtk") Then
                    If dong > 0 Then
                        'rs.MovePrevious()
                        curSheet.Cells(dong = 2).Value = rsItem("tentk")
                        curSheet.Cells(dong = 4).Value = rsItem("shtk")
                        curSheet.Cells(dong = 6).Value = dktien
                        curSheet.Cells(dong = 8).Value = tiennhap
                        curSheet.Cells(dong = 10).Value = tienxuat
                        curSheet.Cells(dong = 13).Value = dktien + tiennhap - tienxuat
                        dktien = 0 : tiennhap = 0 : tienxuat = 0
                        ''rs.MoveNext()
                    End If
                    Dieukien = rsItem("shtk")
                    curSheet.Range(String.Format("{0}:{0}", ConvertToStrSafe(RowIdx + 1))).EntireRow.Insert()
                    dong = RowIdx
                    RowIdx += 1
                End If
                curSheet.Cells(RowIdx = 1).Value = ConvertToDblSafe(IIf(curSheet.Cells(RowIdx - 1, 1).Value > 0, curSheet.Cells(RowIdx - 1, 1).Value, curSheet.Cells(RowIdx - 2, 1).Value2)) + 1
                dktien += rsItem("dktien")
                tiennhap += rsItem("tiennhap") : tienxuat += rsItem("tienxuat")
                ttdk += ConvertToDblSafe(rsItem("dktien"))
                tldk += ConvertToDblSafe(rsItem("dkluong"))
                ttn += ConvertToDblSafe(rsItem("tiennhap"))
                tln += ConvertToDblSafe(rsItem("luongnhap"))
                ttx += ConvertToDblSafe(rsItem("tienxuat"))
                tlx += ConvertToDblSafe(rsItem("luongxuat"))
                ttt += ConvertToDblSafe(rsItem("tienton"))
                tlt += ConvertToDblSafe(rsItem("luongton"))

                For FieldCnt As Integer = 0 To rs.Rows.Count - 3
                    curSheet.Cells(RowIdx = FieldCnt + StartCol).Value = rsItem(FieldCnt)
                Next FieldCnt
                ''rs.MoveNext()
                RowIdx += 1
            End While
            If dong > 0 Then
                Dim rsItem As DataRow = rs.Rows(rsIndex - 1)
                curSheet.Cells(dong = 2).Value = rsItem("tentk")
                curSheet.Cells(dong = 4).Value = rsItem("shtk")
                curSheet.Cells(dong = 6).Value = dktien
                curSheet.Cells(dong = 8).Value = tiennhap
                curSheet.Cells(dong = 10).Value = tienxuat
                curSheet.Cells(dong = 13).Value = dktien + tiennhap - tienxuat
                curSheet.Cells(RowIdx = 5).Value = tldk
                curSheet.Cells(RowIdx = 6).Value = ttdk
                curSheet.Cells(RowIdx = 7).Value = tln
                curSheet.Cells(RowIdx = 8).Value = ttn
                curSheet.Cells(RowIdx = 9).Value = tlx
                curSheet.Cells(RowIdx = 10).Value = ttx
                curSheet.Cells(RowIdx = 11).Value = tlt
                curSheet.Cells(RowIdx = 13).Value = ttt
                ngaybc = NgayCuoiThang(pNamTC, tcuoi)
                curSheet.Cells(RowIdx + 2 = 7).Value = String.Format("Ngày {0} tháng {1} năm {2}", _
                                                           DateAndTime.Day(ngaybc), _
                                                           ConvertToStrSafe(tcuoi), _
                                                           ConvertToStrSafe(pNamTC))
            End If
        End If
        Return RowIdx
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub InThuemonbai()
        Dim Bac As Integer
        Dim Thue As Double
        ExecSQLNonQuery("DELETE FROM BKNhomPS", False)
        For i As Integer = 1 To 10
            If FrmOptions.cn(i).Text <> "" And FrmOptions.cn(i).Text <> "..." Then
                ExecSQLNonQuery((String.Format("INSERT INTO BKNhomPS(DienGiai,sopsno) VALUES('{1}',{2})", _
                                     Lng_MaxValue("maso", "BKNhomPS") + 1, _
                                     FrmOptions.cn(i).Text, _
                                     (IIf(i Mod 2 = 0, "1000000", "0")))))
            End If
        Next

        rptFrom.InitForm("ThueMonBai.RPT", "SELECT * FROM BKNhomPS", "BKNhomPS")

        SetRptInfo()
        rptFrom.ReportWindowState = System.Windows.Forms.FormWindowState.Maximized
        rptFrom.ReportDestination = 0
        rptFrom.ReportWindowTitle = "Thẻ công cụ dụng cụ"
        'frmMain.rpt.set_DataFiles(0, pDataPath)

        rptFrom.SetFormulas("TenCn", String.Format("'{0}'", frmMain._LbCty_8.Text))
        rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))
        rptFrom.SetFormulas("Quan/Huyen", String.Format("'{0}'", frmMain._LbCty_10.Text))
        rptFrom.SetFormulas("Tinh/Thanhpho", String.Format("'{0}'", frmMain._LbCty_11.Text))
        rptFrom.SetFormulas("DienThoai", String.Format("'{0}'", frmMain._LbCty_3.Text))
        rptFrom.SetFormulas("Fax", String.Format("'{0}'", frmMain._LbCty_4.Text))
        rptFrom.SetFormulas("Mail", String.Format("'{0}'", frmMain._LbCty_9.Text))
        Dim von As Double = ConvertToDblSafe(CStr(ConvertToDblSafe(FrmOptions.Text_Renamed(26).Text)))
        Dim rsvon As DataTable = ExecSQLReturnDT("SELECT * FROM BacThue ORDER BY bac")
        Dim rsvonIndex As Integer = 0
        While rsvonIndex < rsvon.Rows.Count
            Dim rsvonItem As DataRow = rsvon.Rows(rsvonIndex)
            rsvonIndex += 1 ' C15 Rs LOOP CONTROL
            Bac = rsvonItem("Bac")
            Thue = rsvonItem("Thue")
            If von > rsvonItem("von") Then Exit While 'rsvon.MoveLast()
            'rsvon.MoveNext()
        End While
        rptFrom.SetFormulas("Von", von)
        rptFrom.SetFormulas("Bac", Bac)
        rptFrom.SetFormulas("Thue", Thue)
        rptFrom.SetFormulas("thang", pThangDauKy)
        rptFrom.SetFormulas("ThangCuoi", IIf(pThangDauKy = 1, 12, pThangDauKy - 1))
        rptFrom.SetFormulas("thangdauky", pThangDauKy)
        rptFrom.SetFormulas("Nam", pNamTC)
        rptFrom.SetFormulas("Tongthuenop", String.Format("'Tổng số thuế môn bài phải nộp năm {0} :'", pNamTC + 1))
        rptFrom.SetFormulas("KBS", String.Format("'{0}'", (IIf(FrmOptions.ChkKBS.CheckState = CheckState.Checked, "X", String.Empty))))
        rptFrom.SetFormulas("NNT", String.Format("'{0}'", FrmOptions.nnt.Text))
        rptFrom.SetFormulas("Ngayky", String.Format("'Quận/Huyện: {0}, ngày {1} tháng {2} năm {3}'", frmMain._LbCty_10.Text, ConvertToStrSafe(DateAndTime.Day(DateTime.Now)), ConvertToStrSafe(DateTime.Now.Month), ConvertToStrSafe(DateTime.Now.Year)))
        'For i AS Integer = 16 To 200
        '    rptFrom.SetFormulas(ConvertToDblSafe(i), String.Empty)
        'Next
        InBaoCaoRPT()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="GauGe"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="nn"></param>
    ''' <remarks></remarks>
    Sub InBCBH(ByRef GauGe As ProgressBar, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, Optional ByRef nn As Integer = 0)
        GauGe.Maximum = 3
        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        Dim sql As String = String.Format("SELECT DISTINCT Chungtu.MaCT,Chungtu.NgayGS,Chungtu.Sohieu as [Chungtu.Sohieu],Chungtu.NgayCT,Chungtu.DienGiai,Chungtu.SoPS,Chungtu.MaTKNO,Chungtu.MaTKCO,HethongTK.SoHieu as [HethongTK.SoHieu],-1 AS LoaiPS,vattu.tenvattu FROM HethongTK httk inner join (HethongTK inner join (chungtu LEFT join vattu on chungtu.mavattu=vattu.maso)on Chungtu.MaTKCo=HethongTK.Maso) on chungtu.matkno=httk.maso WHERE LEFT(httk.sohieu,3)='131' AND Chungtu.maloai=8 AND Chungtu.SoPs <> 0 AND LEFT(HethongTK.SoHieu,3)='511' AND {0}", wsql)
        Dim QChitiet As String = sql
        GauGe.Value = 1
        rptFrom.InitForm("NKBAN.RPT", QChitiet, "QChitiet")

        GauGe.Value = 2
        rptFrom.ReportWindowTitle = "Báo cáo chi tiết bán hàng"
        rptFrom.SetFormulas("Rows", ConvertToDblSafe(GetLastRow(QChitiet, "MaCT")))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi, nn)))))

        RptSetDate(IIf(tdau > 0, NgayCuoiThang(pNamTC, tcuoi), ncuoi))
        GauGe.Value = 3
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="GauGe"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="nn"></param>
    ''' <remarks></remarks>
    Sub InBCMH(ByRef GauGe As ProgressBar, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, Optional ByRef nn As Integer = 0)
        GauGe.Maximum = 3
        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        Dim sql As String = String.Format("SELECT DISTINCT Chungtu.MaCT,Chungtu.NgayGS,Chungtu.Sohieu as [Chungtu.Sohieu],Chungtu.NgayCT,Chungtu.DienGiai,Chungtu.SoPS,Chungtu.MaTKNO,Chungtu.MaTKCO,HethongTK.SoHieu as [HethongTK.SoHieu],-1 AS LoaiPS,vattu.tenvattu FROM HethongTK httk inner join (HethongTK inner join (Chungtu LEFT join vattu on chungtu.mavattu=vattu.maso)on Chungtu.MaTKNo=HethongTK.Maso) on chungtu.matkco=httk.maso WHERE Chungtu.maloai=1 AND {0} AND Chungtu.SoPs <> 0 AND (LEFT(HethongTK.SoHieu,3)='152' OR LEFT(HethongTK.SoHieu,3)='153' OR LEFT(HethongTK.SoHieu,3)='156') AND LEFT(httk.sohieu,3)='331' UNION SELECT DISTINCT Chungtu.MaCT,Chungtu.NgayGS,Chungtu.Sohieu,Chungtu.NgayCT,Chungtu.DienGiai,Chungtu.SoPS,Chungtu.MaTKNO,Chungtu.MaTKCO,HethongTK.SoHieu,-1 AS LoaiPS,vattu.tenvattu FROM HethongTK inner join (Chungtu LEFT join vattu on chungtu.mavattu=vattu.maso)on Chungtu.MaTKNo=HethongTK.Maso WHERE Chungtu.MaTKCo=0 AND Chungtu.maloai=1 AND {0} AND Chungtu.SoPs <> 0 AND (LEFT(HethongTK.SoHieu,3)='152' OR LEFT(HethongTK.SoHieu,3)='153' OR LEFT(HethongTK.SoHieu,3)='156')", wsql)
        Dim QChitiet As String = sql
        GauGe.Value = 1
        rptFrom.InitForm("NKMUA.RPT", QChitiet, "QChitiet")

        GauGe.Value = 2
        rptFrom.ReportWindowTitle = "Báo cáo chi tiết nhập hàng"
        rptFrom.SetFormulas("Rows", ConvertToDblSafe(GetLastRow(QChitiet, "MaCT")))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi, nn)))))

        RptSetDate(IIf(tdau > 0, NgayCuoiThang(pNamTC, tcuoi), ncuoi))
        GauGe.Value = 3
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="GauGe"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="sohieutk"></param>
    ''' <param name="nn"></param>
    ''' <remarks></remarks>
    Sub InBCTT(ByRef GauGe As ProgressBar, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, Optional ByRef sohieutk As String = "0", Optional ByRef nn As Integer = 0)
        GauGe.Maximum = 3
        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        Dim sql As String = String.Format("SELECT DISTINCT Chungtu.MaCT,Chungtu.NgayGS,Chungtu.Sohieu as [Chungtu.Sohieu],Chungtu.NgayCT,Chungtu.DienGiai,Chungtu.SoPS,Chungtu.MaTKNO,Chungtu.MaTKCO,HethongTK.SoHieu as [HethongTK.SoHieu],-1 AS LoaiPS,vattu.tenvattu FROM HethongTK httk inner join (HethongTK inner join (Chungtu LEFT join vattu on chungtu.mavattu=vattu.maso) on Chungtu.MaTKCo=HethongTK.Maso) on chungtu.matkno=httk.maso WHERE {0} AND Chungtu.SoPs <> 0 AND LEFT(httk.sohieu,3) LIKE '{1}'", _
                                wsql, _
                                (IIf(sohieutk.Length = 3, sohieutk, "11%")))
        Dim QChitiet As String = sql

        GauGe.Value = 1
        rptFrom.InitForm("NKTHU.RPT", QChitiet, "QChitiet")

        GauGe.Value = 2
        rptFrom.SetFormulas("Rows", ConvertToDblSafe(GetLastRow(QChitiet, "MaCT")))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi, nn)))))

        RptSetDate(IIf(tdau > 0, NgayCuoiThang(pNamTC, tcuoi), ncuoi))
        GauGe.Value = 3
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="GauGe"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="sohieutk"></param>
    ''' <param name="nn"></param>
    ''' <remarks></remarks>
    Sub InBCCT(ByRef GauGe As ProgressBar, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, Optional ByRef sohieutk As String = "0", Optional ByRef nn As Integer = 0)
        GauGe.Maximum = 3
        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        Dim sql As String = String.Format("SELECT DISTINCT Chungtu.MaCT,Chungtu.NgayGS,Chungtu.Sohieu as [Chungtu.Sohieu],Chungtu.NgayCT,Chungtu.DienGiai,Chungtu.SoPS,Chungtu.MaTKNO,Chungtu.MaTKCO,HethongTK.SoHieu as [HethongTK.SoHieu],-1 AS LoaiPS FROM Chungtu, HethongTK, HethongTK httk WHERE chungtu.matkco=httk.maso AND Chungtu.MaTKNo=HethongTK.Maso AND {0} AND Chungtu.SoPs <> 0 AND LEFT(httk.sohieu,3) LIKE '{1}'", _
                                wsql, _
                                (IIf(sohieutk.Length = 3, sohieutk, "11%")))
        Dim QChitiet As String = sql
        GauGe.Value = 1
        rptFrom.InitForm("NKCHI.RPT", QChitiet, "QChitiet")

        GauGe.Value = 2
        rptFrom.SetFormulas("Rows", ConvertToDblSafe(GetLastRow(QChitiet, "MaCT")))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi, nn)))))

        RptSetDate(IIf(tdau > 0, NgayCuoiThang(pNamTC, tcuoi), ncuoi))
        GauGe.Value = 3
    End Sub
    ''' <summary>
    ''' Thu tuc in bang can doi thu
    ''' </summary>
    ''' <param name="GauGe"></param>
    ''' <param name="saukc"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="cap"></param>
    ''' <param name="ct"></param>
    ''' <param name="nn"></param>
    ''' <remarks></remarks>
    Sub InCdt(ByRef GauGe As ProgressBar, ByRef saukc As Boolean, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef cap As Integer, ByRef ct As Integer, Optional ByRef nn As Integer = 0)
        Dim st As String = String.Empty
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        GauGe.Maximum = 3
        SoDuTKCN2(ThangTruoc(tdau))
        SoDuTKCN2(tcuoi)
        If Not saukc Then XacdinhKC(tdau, tcuoi)
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
        GauGe.Value = 1
        Dim QCdt As String = String.Format("SELECT DISTINCT HeThongTK.SoHieu, HeThongTK.Cap, HeThongTK.Ten{0} as [Ten], HeThongTK.Kieu, HeThongTK.Loai, HeThongTK.DuNo_{1} AS DkNo, HeThongTK.DuCo_{2} AS DkCo, {3} AS PsNo, {4} AS PsCo, KC_N, KC_C, {5} AS CkNo, {6} AS CkCo FROM HeThongTK WHERE ((HeThongTK.MaTC = 0 OR HethongTK.MaTC = HethongTK.MaSo) OR (TK_ID3 % 10 >= 1)) AND (HeThongTK.Loai > 0)  AND Cap<={7}{8}", _
                           (IIf(pNN > 0, "E", String.Empty)), _
                           CThangDB2(ThangTruoc(tdau)), _
                           ConvertToStrSafe(CThangDB2(ThangTruoc(tdau))), _
                           sqln, _
                           sqlc, _
                           (IIf(saukc, String.Format("HeThongTK.DuNo_{0}", st), "HethongTk.DuNo")), _
                           (IIf(saukc, String.Format("HeThongTK.DuCo_{0}", st), "HethongTk.DuCo")), _
                           ConvertToStrSafe(cap), _
                           (IIf(ct = 0, String.Format(" AND (DuNo_{0}<>0 OR DuCo_{0}<>0 OR ({1})<>0 OR ({2})<>0)", st, sqln, sqlc), String.Empty)))
        GauGe.Value = 2
        rptFrom.InitForm("CDT.RPT", QCdt, "QCdt")
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))
        If saukc Then
            rptFrom.SetFormulas("SauKc", "'TRUE'")
        Else
            rptFrom.SetFormulas("SauKc", "'FALSE'")
        End If
        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        GauGe.Value = 3
    End Sub
    ''' <summary>
    ''' InLuyKe
    ''' </summary>
    ''' <param name="GauGe"></param>
    ''' <param name="mkho"></param>
    ''' <param name="shtk"></param>
    ''' <param name="mloai"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="T"></param>
    ''' <param name="loailk"></param>
    ''' <param name="nn"></param>
    ''' <param name="KiemTra"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function InLuyKe(ByRef GauGe As ProgressBar, ByRef mkho As Integer, ByRef shtk As String, ByRef mloai As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer, Optional ByRef T As Boolean = True, Optional ByRef loailk As Integer = 0, Optional ByRef nn As Integer = 0, Optional ByRef KiemTra As Boolean = True) As Boolean
        Dim sql, st As String
        Dim sqltx2 As New StringBuilder
        Dim sqltn2 As New StringBuilder
        Dim sqltx As New StringBuilder
        Dim sqltn As New StringBuilder
        Dim sqllx As New StringBuilder
        Dim sqlln As New StringBuilder
        GauGe.Maximum = 3
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            If sqlln.Length = 0 Then
                sqlln.Append(String.Format("TonKho.Luong_Nhap_{0}", i))
            Else
                sqlln.Append(String.Format(" + TonKho.Luong_Nhap_{0}", i))
            End If
            '---
            If sqllx.Length = 0 Then
                sqllx.Append(String.Format("TonKho.Luong_Xuat_{0}", i))
            Else
                sqllx.Append(String.Format(" + TonKho.Luong_Xuat_{0}", i))
            End If
            '---
            If sqltn.Length = 0 Then
                sqltn.Append(String.Format("TonKho.Tien_Nhap_{0}", i))
            Else
                sqltn.Append(String.Format(" + TonKho.Tien_Nhap_{0}", i))
            End If
            '---
            If sqltx.Length = 0 Then
                sqltx.Append(String.Format("TonKho.Tien_Xuat_{0}", i))
            Else
                sqltx.Append(String.Format(" + TonKho.Tien_Xuat_{0}", i))
            End If
            '---
            If sqltn2.Length = 0 Then
                sqltn2.Append(String.Format("TonKho.USDTien_Nhap_{0}", i))
            Else
                sqltn2.Append(String.Format(" + TonKho.USDTien_Nhap_{0}", i))
            End If
            '---
            If sqltx2.Length = 0 Then
                sqltx2.Append(String.Format("TonKho.USDTien_Xuat_{0}", i))
            Else
                sqltx2.Append(String.Format(" + TonKho.USDTien_Xuat_{0}", i))
            End If
        Next
        GauGe.Value = 1
        st = ConvertToStrSafe(CThangDB2(tcuoi))
        XDTyLeQD(0)
        If mkho > 0 Then
            sql = String.Format("SELECT DISTINCT (HeThongTK.SoHieu) AS SHTK, (HeThongTK.Ten{0}) AS TenTK, (PhanLoaiVattu.PLCha) AS PLCha3, (PhanLoaiVattu.SoHieu) AS SHPL3, (PhanLoaiVattu.TenPhanLoai) AS TenPL3, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, Sum(TonKho.Tien_{1}) AS DkTien, Sum(TonKho.Luong_{1}) AS DkLuong, Sum({2}) AS TienNhap, Sum({3}) AS LuongNhap, Sum({4}) AS TienXuat, Sum({5}) AS LuongXuat, Sum(TonKho.Luong_{6}) AS CkLuong, Sum(TonKho.Tien_{6}) AS CkTien{7} FROM HeThongTK RIGHT JOIN ((PhanLoaiVattu RIGHT JOIN Vattu ON PhanLoaiVattu.MaSo = Vattu.MaPhanLoai) RIGHT JOIN TonKho ON Vattu.MaSo = TonKho.MaVatTu) ON HeThongTK.MaSo = TonKho.MaTaiKhoan GROUP BY Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, HethongTK.SoHieu, Tonkho.MaSoKho, Hethongtk.ten{0},phanloaivattu.PLCha,PhanLoaiVattu.sohieu,PhanLoaiVattu.TenPhanLoai {8}{9} Having (Sum(TonKho.Luong_{6})<>0 OR Sum(TonKho.Tien_{6})<>0 OR SUM({3})<>0 OR SUM({2})<>0 OR SUM({5})<>0 OR SUM({4})<>0{10}{11}{12}{13} ", _
                      (IIf(pNN > 0, "E", String.Empty)), _
                      CThangDB2(ThangTruoc(tdau)), _
                      sqltn, _
                      sqlln, _
                      sqltx, _
                      sqllx, _
                      st, _
                      (IIf(pGiaUSD > 0, String.Format(", Sum(TonKho.USDTien_{0}) AS DkUSD, Sum({1}) AS TienNhapUSD, Sum({2}) AS TienXuatUSD, Sum(TonKho.USDTien_{3}) AS CkUSD", CThangDB2(ThangTruoc(tdau)), sqltn2, sqltx2, st), String.Empty)), _
                      String.Empty, _
                      String.Empty, _
                      (IIf(pGiaUSD > 0, String.Format(" OR Sum(TonKho.USDTien_{0})<>0 OR SUM({1})<>0 OR SUM({2})<>0)", st, sqltn2, sqltx2), ")")), _
                      (IIf(mkho <> 0, String.Format(" AND TonKho.MaSoKho = {0}", mkho), String.Empty)), _
                      (IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty)), _
                      (IIf(mloai <> 0, String.Format(" AND PhanLoaiVattu.SoHieu LIKE '{0}%'", MaSo2SoHieu(mloai, "PhanLoaiVattu")), String.Empty)))
            '(IIf(mkho > 0, ", TonKho.MaSoKho", String.Empty)), _
            '(IIf(mloai > 0, ", PhanLoaiVattu.SoHieu", String.Empty)), _
        Else
            ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
            ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (SoHieu,MaCha,BC_ID,MK,Kq1,Kq2) SELECT SoHieu,MaTKNo,MaVattu,MaKho,Sum(SoPS2No),Sum(SoPS) FROM ChungTu WHERE MaLoai=4 AND MaTKNo=MaTKCo AND {0} GROUP BY SoHieu,MaKho,MaTKNo,MaVattu", WThang("ThangCT", tdau, tcuoi)))
            sql = String.Format("SELECT DISTINCT (HeThongTK.SoHieu) AS SHTK, (HeThongTK.Ten{0}) AS TenTK, (PhanLoaiVattu.PLCha) AS PLCha3, (PhanLoaiVattu.SoHieu) AS SHPL3, (PhanLoaiVattu.TenPhanLoai) AS TenPL3, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, Sum(TonKho.Tien_{1}) AS DkTien, Sum(TonKho.Luong_{1}) AS DkLuong, Sum({2}- ISNULL(Kq2,0)) AS TienNhap, Sum({3}- (case when Kq1 is null then 0 else Kq1 end)) AS LuongNhap, Sum({4}-ISNULL(Kq2,0)) AS TienXuat, Sum({5}-ISNULL(Kq1,0)) AS LuongXuat, Sum(TonKho.Luong_{6}) AS CkLuong, Sum(TonKho.Tien_{6}) AS CkTien{7} FROM (HeThongTK RIGHT JOIN ((PhanLoaiVattu RIGHT JOIN Vattu ON PhanLoaiVattu.MaSo = Vattu.MaPhanLoai) RIGHT JOIN TonKho ON Vattu.MaSo = TonKho.MaVatTu) ON HeThongTK.MaSo = TonKho.MaTaiKhoan) LEFT JOIN BaoCaoCP2 ON TonKho.MaSoKho=BaoCaoCP2.MK AND TonKho.MaTaiKhoan=BaoCaoCP2.MaCha AND TonKho.MaVattu=BaoCaoCP2.BC_ID GROUP BY Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, HethongTK.SoHieu {8},PhanLoaiVattu.TenPhanLoai,PhanLoaiVattu.SoHieu,PhanLoaiVattu.PLCha,HeThongTK.Ten{0} Having Sum(TonKho.Luong_{6})<>0 OR Sum(TonKho.Tien_{6})<>0 OR SUM({3})<>0 OR SUM({2})<>0 OR SUM({5})<>0 OR SUM({4})<>0{9}{10}{11}", _
                      (IIf(pNN > 0, "E", String.Empty)), _
                      CThangDB2(ThangTruoc(tdau)), _
                      sqltn, _
                      sqlln, _
                      sqltx, _
                      sqllx, _
                      st, _
                      (IIf(pGiaUSD > 0, String.Format(", Sum(TonKho.USDTien_{0}) AS DkUSD, Sum({1}) AS TienNhapUSD, Sum({2}) AS TienXuatUSD, Sum(TonKho.USDTien_{3}) AS CkUSD", CThangDB2(ThangTruoc(tdau)), sqltn2, sqltx2, st), String.Empty)), _
                      (IIf(mloai > 0, ", PhanLoaiVattu.SoHieu", String.Empty)), _
                      (IIf(pGiaUSD > 0, String.Format(" OR Sum(TonKho.USDTien_{0})<>0 OR SUM({1})<>0 OR SUM({2})<>0", st, sqltn2, sqltx2), String.Empty)), _
                      (IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty)), _
                      (IIf(mloai <> 0, String.Format(" AND PhanLoaiVattu.SoHieu LIKE '{0}%'", MaSo2SoHieu(mloai, "PhanLoaiVattu")), String.Empty)))
        End If
        'SetSQL("QChitiet", sql)
        sql = String.Format("SELECT QChitiet.*,PhanLoaiVattu.SoHieu AS SHPL2,TenPhanLoai AS TenPL2,PhanLoaiVattu.PLCha AS PLCha2 FROM ({0}) AS QChitiet LEFT JOIN PhanLoaiVattu ON QChitiet.PLCha3=PhanLoaiVattu.MaSo", sql)
        sql = String.Format("SELECT QDuPhong.*,PhanLoaiVattu.SoHieu AS SHPL1,TenPhanLoai AS TenPL1 FROM ({0}) AS QDuPhong LEFT JOIN PhanLoaiVattu ON QDuPhong.PLCha2=PhanLoaiVattu.MaSo  ", sql)
        Dim QLuyKe As String = sql
        '************************************ Kiểm tra âm hàng **********************************************
        Dim rs As DataTable
        Dim str As String = String.Empty
        If KiemTra Then
            rs = ExecSQLReturnDT(String.Format("SELECT DISTINCT TB.dkluong,TB.ckluong,TB.sohieu FROM ({0}) as TB ORDER BY TB.sohieu", QLuyKe))
            Dim rsIndex As Integer = 0
            While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                If rsItem("dkluong") < 0 Or rsItem("ckluong") < 0 Then
                    str = String.Format("{0}, ", ConvertToDblSafe(str) & rsItem("sohieu"))
                End If
            End While
            If str <> "" Then
                str = Strings.Left(str, str.Length - 2)
                myUMessager.mError(String.Format("Âm hàng tại vật tư có số hiệu {0}.", str), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        '************************************ Hết kiểm tra ****************************************************
        GauGe.Value = 2
        If T And loailk <> 1 Then
            rptFrom.InitForm(String.Format("LUYKE{0}.RPT", IIf(pGiaUSD > 0, "X", String.Empty)), QLuyKe, "QLuyKe")
        Else
            rptFrom.InitForm(String.Format("LUYKEL{0}.RPT", IIf(pGiaUSD > 0, "X", String.Empty)), QLuyKe, "QLuyKe")
        End If

        rptFrom.SetFormulas("TenKho", String.Format(Ngonngu("'Kho: {0}'", "'Stock: {0}'"), tenkho(mkho)))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        GauGe.Value = 3
        Return True
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="GauGe"></param>
    ''' <param name="mkho"></param>
    ''' <param name="shtk"></param>
    ''' <param name="mloai"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="T"></param>
    ''' <param name="loailk"></param>
    ''' <param name="nn"></param>
    ''' <remarks></remarks>
    Sub InLuyKeN(ByRef GauGe As ProgressBar, ByRef mkho As Integer, ByRef shtk As String, ByRef mloai As Integer, ByRef ndau As Date, ByRef ncuoi As Date, Optional ByRef T As Boolean = True, Optional ByRef loailk As Integer = 0, Optional ByRef nn As Integer = 0)
        'ExecSQLNonQuery("DELETE FROM BaoCaoCP")
        'GauGe.Maximum = 3
        'ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP (MaSo,SoHieu,MaCha,BC_ID,MK,Kq1,Kq2) SELECT (TonKho.MaSo),ConvertToStrSafe((TonKho.MaSo)),MaTaiKhoan,MaVattu,MaSoKho,Sum(Luong_0),Sum(Tien_0) FROM (TonKho INNER JOIN Vattu ON TonKho.MaVattu=Vattu.MaSo) INNER JOIN HethongTK ON TonKho.MaTaiKhoan=HethongTK.MaSo WHERE (TRUE){0}{1}{2} GROUP BY MaSoKho,MaTaiKhoan,MaVattu", _
        '                    (IIf(mkho > 0, String.Format(" AND MaSoKho={0}", mkho), String.Empty)), _
        '                    (IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty)), _
        '                    (IIf(mloai > 0, String.Format(" AND MaPhanLoai={0}", mloai), String.Empty))))
        '' Tinh dau ky
        'ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
        'ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,MaCha,BC_ID,MK,Kq1,Kq2) SELECT (ChungTu.MaSo),ConvertToStrSafe((ChungTu.MaSo)),MaTKNo,MaVattu,CASE WHEN(MaLoai=1) THEN MaKho ELSE MaNguon END,Sum(SoPS2No),Sum(SoPS) FROM (ChungTu INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo  WHERE (MaLoai=1{0} AND NgayGS<'{1}'{2}{3}{4} GROUP BY CASE WHEN(MaLoai=1) THEN MaKho ELSE MaNguon END,MaTKNo,MaVattu", _
        '                    (IIf(mkho > 0, " OR MaLoai=4)", ")")), _
        '                    Format(ndau, Mask_DB), _
        '                    (IIf(mkho > 0, String.Format(" AND ((MaKho={0} AND MaLoai=1) OR (MaNguon={1} AND MaLoai=4))", mkho, ConvertToStrSafe(mkho)), String.Empty)), _
        '                    (IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty)), _
        '                    (IIf(mloai > 0, String.Format(" AND MaPhanLoai={0}", mloai), String.Empty))))
        'ExecSQLNonQuery("UPDATE BaoCaoCP INNER JOIN BaoCaoCP2 ON BaoCaoCP.MaCha=BaoCaoCP2.MaCha AND BaoCaoCP.BC_ID=BaoCaoCP2.BC_ID AND BaoCaoCP.MK=BaoCaoCP2.MK SET BaoCaoCP.Kq1=BaoCaoCP.Kq1+BaoCaoCP2.Kq1,BaoCaoCP.Kq2=BaoCaoCP.Kq2+BaoCaoCP2.Kq2")
        'ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
        'ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,MaCha,BC_ID,MK,Kq1,Kq2) SELECT (ChungTu.MaSo),ConvertToStrSafe((ChungTu.MaSo)),MaTKCo,MaVattu,MaKho,Sum(SoPS2Co),Sum(SoPS) FROM (ChungTu INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN HethongTK ON ChungTu.MaTKCo=HethongTK.MaSo  WHERE (MaLoai=2{0} AND NgayGS<'{1}'{2}{3}{4} GROUP BY MaKho,MaTKCo,MaVattu", _
        '                    (IIf(mkho > 0, " OR MaLoai=4)", ")")), _
        '                    Format(ndau, Mask_DB), _
        '                    (IIf(mkho > 0, String.Format(" AND (MaKho={0})", mkho), String.Empty)), _
        '                    (IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty)), _
        '                    (IIf(mloai > 0, String.Format(" AND MaPhanLoai={0}", mloai), String.Empty))))
        'ExecSQLNonQuery("UPDATE BaoCaoCP INNER JOIN BaoCaoCP2 ON BaoCaoCP.MaCha=BaoCaoCP2.MaCha AND BaoCaoCP.BC_ID=BaoCaoCP2.BC_ID AND BaoCaoCP.MK=BaoCaoCP2.MK SET BaoCaoCP.Kq1=BaoCaoCP.Kq1-BaoCaoCP2.Kq1,BaoCaoCP.Kq2=BaoCaoCP.Kq2-BaoCaoCP2.Kq2")
        '' Tinh tong so nhap xuat
        'ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
        'ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,MaCha,BC_ID,MK,Kq1,Kq2) SELECT (ChungTu.MaSo),ConvertToStrSafe((ChungTu.MaSo)),MaTKNo,MaVattu,CASE WHEN(MaLoai=1) THEN MaKho ELSE MaNguon END, Sum(SoPS2No),Sum(SoPS) FROM (ChungTu INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo  WHERE (MaLoai=1{0} AND {1}{2}{3}{4} GROUP BY  CASE WHEN (MaLoai=1) THEN MaKho ELSE MaNguon END,MaTKNo,MaVattu", _
        '                    (IIf(mkho > 0, " OR MaLoai=4)", " OR (MaLoai=4 AND MaTKNo<>MaTKCo))")), _
        '                    WNgay("NgayGS", ndau, ncuoi), _
        '                    (IIf(mkho > 0, String.Format(" AND ((MaKho={0} AND MaLoai=1) OR (MaNguon={1} AND MaLoai=4))", mkho, ConvertToStrSafe(mkho)), String.Empty)), _
        '                    (IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty)), _
        '                    (IIf(mloai > 0, " AND MaPhanLoai=" & mloai, String.Empty))))
        'ExecSQLNonQuery("UPDATE BaoCaoCP INNER JOIN BaoCaoCP2 ON BaoCaoCP.MaCha=BaoCaoCP2.MaCha AND BaoCaoCP.BC_ID=BaoCaoCP2.BC_ID AND BaoCaoCP.MK=BaoCaoCP2.MK SET BaoCaoCP.Kq3=BaoCaoCP2.Kq1,BaoCaoCP.Kq4=BaoCaoCP2.Kq2")
        'ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
        'ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,MaCha,BC_ID,MK,Kq1,Kq2) SELECT (ChungTu.MaSo),ConvertToStrSafe((ChungTu.MaSo)),MaTKCo,MaVattu,MaKho,Sum(SoPS2Co),Sum(SoPS) FROM (ChungTu INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN HethongTK ON ChungTu.MaTKCo=HethongTK.MaSo  WHERE (MaLoai=2{0}) AND {1}{2}{3}{4} GROUP BY MaKho,MaTKCo,MaVattu", _
        '                    (IIf(mkho > 0, " OR MaLoai=4", " OR (MaLoai=4 AND MaTKNo<>MaTKCo)")), _
        '                    WNgay("NgayGS", ndau, ncuoi), _
        '                    (IIf(mkho > 0, String.Format(" AND (MaKho={0})", mkho), String.Empty)), _
        '                    (IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty)), _
        '                    (IIf(mloai > 0, String.Format(" AND MaPhanLoai={0}", mloai), String.Empty))))
        'ExecSQLNonQuery("UPDATE BaoCaoCP INNER JOIN BaoCaoCP2 ON BaoCaoCP.MaCha=BaoCaoCP2.MaCha AND BaoCaoCP.BC_ID=BaoCaoCP2.BC_ID AND BaoCaoCP.MK=BaoCaoCP2.MK SET BaoCaoCP.Kq5=BaoCaoCP2.Kq1,BaoCaoCP.Kq6=BaoCaoCP2.Kq2")

        'If ConvertToDblSafe(Interaction.GetSetting(IniPath, "Stock", "DailySummary", "0")) = 0 Then
        '    ExecSQLNonQuery("DELETE FROM BaoCaoCP WHERE Kq1=0 AND Kq2=0 AND Kq3=0 AND Kq4=0 AND Kq5=0 AND Kq6=0")
        'Else
        '    ExecSQLNonQuery("DELETE FROM BaoCaoCP WHERE Kq3=0 AND Kq4=0 AND Kq5=0 AND Kq6=0")
        'End If

        'ExecSQLNonQuery("UPDATE BaoCaoCP SET Kq7=Kq1+Kq3-Kq5,Kq8=Kq2+Kq4-Kq6")
        'XDTyLeQD(0)
        'GauGe.Value = 1

        'Dim sql As String = String.Format("SELECT DISTINCT (HeThongTK.SoHieu) AS SHTK, (HeThongTK.Ten{0}) AS TenTK, (PhanLoaiVattu.PLCha) AS PLCha3, (PhanLoaiVattu.SoHieu) AS SHPL3, (PhanLoaiVattu.TenPhanLoai) AS TenPL3, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, Sum(Kq2) AS DkTien, Sum(Kq1) AS DkLuong, Sum(Kq4) AS TienNhap, Sum(Kq3) AS LuongNhap, Sum(Kq6) AS TienXuat, Sum(Kq5) AS LuongXuat, Sum(Kq7) AS CkLuong, Sum(Kq8) AS CkTien, (Vattu.MaSo) AS MVT  FROM (HeThongTK RIGHT JOIN ((PhanLoaiVattu RIGHT JOIN Vattu ON PhanLoaiVattu.MaSo = Vattu.MaPhanLoai) RIGHT JOIN TonKho ON Vattu.MaSo = TonKho.MaVatTu) ON HeThongTK.MaSo = TonKho.MaTaiKhoan) INNER JOIN BaoCaoCP ON TonKho.MaSoKho=BaoCaoCP.MK AND TonKho.MaTaiKhoan=BaoCaoCP.MaCha AND TonKho.MaVattu=BaoCaoCP.BC_ID GROUP BY HeThongTK.MaSo, HeThongTK.SoHieu, HeThongTK.Ten, PhanLoaiVattu.MaSo, PhanLoaiVattu.SoHieu, PhanLoaiVattu.TenPhanLoai, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi {1} Having (1=1){2}{3}{4} ", _
        '                        (IIf(pnn > 0, "E", String.Empty)), _
        '                        (IIf(mkho > 0, ", TonKho.MaSoKho", String.Empty)), _
        '                        (IIf(mkho <> 0, String.Format(" AND TonKho.MaSoKho = {0}", mkho), String.Empty)), _
        '                        (IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty)), _
        '                        (IIf(mloai <> 0, String.Format(" AND PhanLoaiVattu.SoHieu LIKE '{0}%'", MaSo2SoHieu(mloai, "PhanLoaiVattu")), String.Empty)))
        ''SetSQL("QChitiet", sql)
        'sql = String.Format("SELECT QChitiet.*,PhanLoaiVattu.SoHieu AS SHPL2,TenPhanLoai AS TenPL2,PhanLoaiVattu.PLCha AS PLCha2 FROM ({0}) AS QChitiet LEFT JOIN PhanLoaiVattu ON QChitiet.PLCha3=PhanLoaiVattu.MaSo", sql)
        ''SetSQL("QDuPhong", sql)
        'sql = String.Format("SELECT QDuPhong.*,PhanLoaiVattu.SoHieu AS SHPL1,TenPhanLoai AS TenPL1 FROM ({0}) as QDuPhong LEFT JOIN PhanLoaiVattu ON QDuPhong.PLCha2=PhanLoaiVattu.MaSo ORDER BY QDuPhong.Sohieu", sql)
        'Dim QLuyKe As String = sql
        'GauGe.Value = 2

        'If T And loailk <> 1 Then
        '    rptFrom.InitForm("LUYKE.RPT", QLuyKe, "QLuyKe")
        'Else
        '    rptFrom.InitForm("LUYKEL.RPT", QLuyKe, "QLuyKe")
        'End If

        'rptFrom.SetFormulas("TenKho", String.Format("'Kho: {0}'", tenkho(mkho)))
        'rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianN(ndau, ncuoi)))

        'RptSetDate(ncuoi)
        ExecSQLNonQuery("DELETE FROM BaoCaoCP")
        GauGe.Maximum = 3
        Dim str As String = String.Format("INSERT INTO BaoCaoCP (MaSo,SoHieu,MaCha,BC_ID,MK,Kq1,Kq2) SELECT (TonKho.MaSo),TonKho.MaSo,MaTaiKhoan,MaVattu,MaSoKho,Sum(Luong_0),Sum(Tien_0) FROM (TonKho INNER JOIN Vattu ON TonKho.MaVattu=Vattu.MaSo) INNER JOIN HethongTK ON TonKho.MaTaiKhoan=HethongTK.MaSo WHERE 1=1 {0}{1}{2} GROUP BY MaSoKho,MaTaiKhoan,MaVattu,TonKho.MaSo", _
                            (IIf(mkho > 0, String.Format(" AND MaSoKho={0}", mkho), String.Empty)), _
                            (IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty)), _
                            (IIf(mloai > 0, String.Format(" AND MaPhanLoai={0}", mloai), String.Empty)))
        ExecSQLNonQuery(str)
        ' Tinh dau ky
        ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
        Dim tam As String = String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,MaCha,BC_ID,MK,Kq1,Kq2) SELECT (ChungTu.MaSo),ChungTu.MaSo,MaTKNo,MaVattu,CASE WHEN(MaLoai=1) THEN MaKho ELSE MaNguon END,Sum(SoPS2No),Sum(SoPS) FROM (ChungTu INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo  WHERE (MaLoai=1{0} AND NgayGS<'{1}'{2}{3}{4} GROUP BY CASE WHEN(MaLoai=1) THEN MaKho ELSE MaNguon END,MaTKNo,MaVattu,ChungTu.MaSo", _
                            (IIf(mkho > 0, " OR MaLoai=4)", ")")), _
                            Format(ndau, Mask_DB), _
                            (IIf(mkho > 0, String.Format(" AND ((MaKho={0} AND MaLoai=1) OR (MaNguon={1} AND MaLoai=4))", mkho, ConvertToStrSafe(mkho)), String.Empty)), _
                            (IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty)), _
                            (IIf(mloai > 0, String.Format(" AND MaPhanLoai={0}", mloai), String.Empty)))
        ExecSQLNonQuery(tam)
        Dim tam1 As String = String.Format("UPDATE BaoCaoCP SET BaoCaoCP.Kq1=BaoCaoCP.Kq1+BaoCaoCP2.Kq1,BaoCaoCP.Kq2=BaoCaoCP.Kq2+BaoCaoCP2.Kq2 from baocaocp INNER JOIN BaoCaoCP2 ON BaoCaoCP.MaCha=BaoCaoCP2.MaCha AND BaoCaoCP.BC_ID=BaoCaoCP2.BC_ID AND BaoCaoCP.MK=BaoCaoCP2.MK")
        ExecSQLNonQuery(tam1)
        ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
        Dim tam2 As String = String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,MaCha,BC_ID,MK,Kq1,Kq2) SELECT (ChungTu.MaSo),ChungTu.MaSo,MaTKCo,MaVattu,MaKho,Sum(SoPS2Co),Sum(SoPS) FROM (ChungTu INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN HethongTK ON ChungTu.MaTKCo=HethongTK.MaSo  WHERE (MaLoai=2{0} AND NgayGS<'{1}'{2}{3}{4} GROUP BY MaKho,MaTKCo,MaVattu, ChungTu.MaSo", _
                            (IIf(mkho > 0, " OR MaLoai=4)", ")")), _
                            Format(ndau, Mask_DB), _
                            (IIf(mkho > 0, String.Format(" AND (MaKho={0})", mkho), String.Empty)), _
                            (IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty)), _
                            (IIf(mloai > 0, String.Format(" AND MaPhanLoai={0}", mloai), String.Empty)))
        ExecSQLNonQuery(tam2)
        Dim tam3 As String = String.Format("UPDATE BaoCaoCP SET BaoCaoCP.Kq1= BaoCaoCP.Kq1-BaoCaoCP2.Kq1 ,BaoCaoCP.Kq2= BaoCaoCP.Kq2-BaoCaoCP2.Kq2 from baocaocp INNER JOIN BaoCaoCP2 ON BaoCaoCP.MaCha=BaoCaoCP2.MaCha AND BaoCaoCP.BC_ID=BaoCaoCP2.BC_ID AND BaoCaoCP.MK=BaoCaoCP2.MK ")
        ExecSQLNonQuery(tam3)
        ' Tinh tong so nhap xuat
        ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
        Dim tam4 As String = String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,MaCha,BC_ID,MK,Kq1,Kq2) SELECT (ChungTu.MaSo),ChungTu.MaSo,MaTKNo,MaVattu,CASE WHEN(MaLoai=1) THEN MaKho ELSE MaNguon END, Sum(SoPS2No),Sum(SoPS) FROM (ChungTu INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN HethongTK ON ChungTu.MaTKNo=HethongTK.MaSo  WHERE (MaLoai=1{0} AND {1}{2}{3}{4} GROUP BY  CASE WHEN (MaLoai=1) THEN MaKho ELSE MaNguon END,MaTKNo,MaVattu,ChungTu.MaSo", _
                            (IIf(mkho > 0, " OR MaLoai=4)", " OR (MaLoai=4 AND MaTKNo<>MaTKCo))")), _
                            WNgay("NgayGS", ndau, ncuoi), _
                            (IIf(mkho > 0, String.Format(" AND ((MaKho={0} AND MaLoai=1) OR (MaNguon={1} AND MaLoai=4))", mkho, ConvertToStrSafe(mkho)), String.Empty)), _
                            (IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty)), _
                            (IIf(mloai > 0, " AND MaPhanLoai=" & mloai, String.Empty)))
        ExecSQLNonQuery(tam4)
        Dim tam5 As String = String.Format("UPDATE BaoCaoCP SET BaoCaoCP.Kq3= BaoCaoCP2.Kq1 ,BaoCaoCP.Kq4= BaoCaoCP2.Kq2 from BaoCaoCP INNER JOIN BaoCaoCP2 ON BaoCaoCP.MaCha=BaoCaoCP2.MaCha AND BaoCaoCP.BC_ID=BaoCaoCP2.BC_ID AND BaoCaoCP.MK=BaoCaoCP2.MK")
        ExecSQLNonQuery(tam5)
        ExecSQLNonQuery("DELETE FROM BaoCaoCP2")
        Dim tam6 As String = String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu,MaCha,BC_ID,MK,Kq1,Kq2) SELECT (ChungTu.MaSo),ChungTu.MaSo,MaTKCo,MaVattu,MaKho,Sum(SoPS2Co),Sum(SoPS) FROM (ChungTu INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) INNER JOIN HethongTK ON ChungTu.MaTKCo=HethongTK.MaSo  WHERE (MaLoai=2{0}) AND {1}{2}{3}{4} GROUP BY MaKho,MaTKCo,MaVattu,ChungTu.MaSo", _
                            (IIf(mkho > 0, " OR MaLoai=4", " OR (MaLoai=4 AND MaTKNo<>MaTKCo)")), _
                            WNgay("NgayGS", ndau, ncuoi), _
                            (IIf(mkho > 0, String.Format(" AND (MaKho={0})", mkho), String.Empty)), _
                            (IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty)), _
                            (IIf(mloai > 0, String.Format(" AND MaPhanLoai={0}", mloai), String.Empty)))
        ExecSQLNonQuery(tam6)
        Dim tam7 As String = String.Format("UPDATE BaoCaoCP SET BaoCaoCP.Kq5=BaoCaoCP2.Kq1 ,BaoCaoCP.Kq6= BaoCaoCP2.Kq2 from BaoCaoCP INNER JOIN BaoCaoCP2 ON BaoCaoCP.MaCha=BaoCaoCP2.MaCha AND BaoCaoCP.BC_ID=BaoCaoCP2.BC_ID AND BaoCaoCP.MK=BaoCaoCP2.MK ")
        ExecSQLNonQuery(tam7)

        If ConvertToDblSafe(Interaction.GetSetting(IniPath, "Stock", "DailySummary", "0")) = 0 Then
            ExecSQLNonQuery("DELETE FROM BaoCaoCP WHERE Kq1=0 AND Kq2=0 AND Kq3=0 AND Kq4=0 AND Kq5=0 AND Kq6=0")
        Else
            ExecSQLNonQuery("DELETE FROM BaoCaoCP WHERE Kq3=0 AND Kq4=0 AND Kq5=0 AND Kq6=0")
        End If

        ExecSQLNonQuery("UPDATE BaoCaoCP SET Kq7=Kq1+Kq3-Kq5,Kq8=Kq2+Kq4-Kq6")
        XDTyLeQD(0)
        GauGe.Value = 1

        Dim sql As String = String.Format("SELECT DISTINCT (HeThongTK.SoHieu) AS SHTK, (HeThongTK.Ten{0}) AS TenTK, (PhanLoaiVattu.PLCha) AS PLCha3, (PhanLoaiVattu.SoHieu) AS SHPL3, (PhanLoaiVattu.TenPhanLoai) AS TenPL3, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi, Sum(Kq2) AS DkTien, Sum(Kq1) AS DkLuong, Sum(Kq4) AS TienNhap, Sum(Kq3) AS LuongNhap, Sum(Kq6) AS TienXuat, Sum(Kq5) AS LuongXuat, Sum(Kq7) AS CkLuong, Sum(Kq8) AS CkTien, (Vattu.MaSo) AS MVT  FROM (HeThongTK RIGHT JOIN ((PhanLoaiVattu RIGHT JOIN Vattu ON PhanLoaiVattu.MaSo = Vattu.MaPhanLoai) RIGHT JOIN TonKho ON Vattu.MaSo = TonKho.MaVatTu) ON HeThongTK.MaSo = TonKho.MaTaiKhoan) INNER JOIN BaoCaoCP ON TonKho.MaSoKho=BaoCaoCP.MK AND TonKho.MaTaiKhoan=BaoCaoCP.MaCha AND TonKho.MaVattu=BaoCaoCP.BC_ID GROUP BY TonKho.MaSoKho ,PLCha,vattu.MaSo,HeThongTK.MaSo, HeThongTK.SoHieu, HeThongTK.Ten, PhanLoaiVattu.MaSo, PhanLoaiVattu.SoHieu, PhanLoaiVattu.TenPhanLoai, Vattu.SoHieu, Vattu.TenVattu, Vattu.DonVi {1} Having 1=1 {2}{3}{4} ", _
                                (IIf(pNN > 0, "E", String.Empty)), _
                                (IIf(mkho > 0, ", TonKho.MaSoKho", String.Empty)), _
                                (IIf(mkho <> 0, String.Format(" AND TonKho.MaSoKho = {0}", mkho), String.Empty)), _
                                (IIf(shtk.Length > 0, String.Format(" AND HethongTK.SoHieu LIKE '{0}%'", shtk), String.Empty)), _
                                (IIf(mloai <> 0, String.Format(" AND PhanLoaiVattu.SoHieu LIKE '{0}%'", MaSo2SoHieu(mloai, "PhanLoaiVattu")), String.Empty)))
        'SetSQL("QChitiet", sql)
        sql = String.Format("SELECT QChitiet.*,PhanLoaiVattu.SoHieu AS SHPL2,TenPhanLoai AS TenPL2,PhanLoaiVattu.PLCha AS PLCha2 FROM ({0}) AS QChitiet LEFT JOIN PhanLoaiVattu ON QChitiet.PLCha3=PhanLoaiVattu.MaSo", sql)
        'SetSQL("QDuPhong", sql)
        sql = String.Format("SELECT QDuPhong.*,PhanLoaiVattu.SoHieu AS SHPL1,TenPhanLoai AS TenPL1 FROM ({0}) AS QDuPhong LEFT JOIN PhanLoaiVattu ON  QDuPhong.PLCha2=PhanLoaiVattu.MaSo ORDER BY QDuPhong.Sohieu", sql)
        Dim QLuyKe As String = sql
        GauGe.Value = 2

        If T And loailk <> 1 Then
            rptFrom.InitForm("LUYKE.RPT", QLuyKe, "QLuyKe")
        Else
            rptFrom.InitForm("LUYKEL.RPT", QLuyKe, "QLuyKe")
        End If

        rptFrom.SetFormulas("TenKho", String.Format(Ngonngu("'Kho: {0}'", "'Stock: {0}'"), tenkho(mkho)))
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianN(ndau, ncuoi)))

        RptSetDate(ncuoi)
        InBaoCaoRPT()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="GauGe"></param>
    ''' <param name="taikhoan"></param>
    ''' <param name="mcn"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="nt"></param>
    ''' <param name="nn"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function InSoChitietCN(ByRef GauGe As ProgressBar, ByRef taikhoan As ClsTaikhoan, ByRef mcn As Integer, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, Optional ByRef nt As Integer = 0, Optional ByRef nn As Integer = 0) As Boolean
        Dim result As Boolean = False
        Dim dknt, dkn, dkc, X As Double
        Dim sqlw As String = String.Empty
        Dim cn As New clsKhachHang
        Dim i As Integer

        GauGe.Maximum = 3
        cn.InitKhachHangMaSo(mcn)
        If tcuoi > 0 Then
            cn.SoDuKH(ThangTruoc(tdau), _
                dkn, _
                dkc, _
                dknt, _
                IIf(taikhoan.tkcon = 0, taikhoan.maso, 0), _
                IIf(taikhoan.tkcon > 0, taikhoan.sohieu, String.Empty))
            sqlw = WThang("ThangCT", tdau, tcuoi)
        Else
            SoDuKHNgay(cn.MaSo, _
                ndau.AddDays(-1), _
                dkn, _
                dkc, _
                dknt, _
                IIf(taikhoan.tkcon = 0, taikhoan.maso, 0), _
                IIf(taikhoan.tkcon > 0, taikhoan.sohieu, String.Empty))
            sqlw = WNgay("NgayGS", ndau, ncuoi)
        End If
        Dim sql As String = String.Format("((HethongTK_2.SoHieu LIKE '{0}%') OR (HethongTK_3.SoHieu LIKE '{0}%')) AND (MaKH={1} OR MaKHC={1})", _
                                taikhoan.sohieu, _
                                ConvertToStrSafe(mcn))
        GauGe.Value = 1
        If cn.MaNT = 0 Then
KhongNT:
            Dim QChitiet As String = String.Format("SELECT DISTINCT ChungTu.MaCT, ChungTu.SoHieu as [ChungTu.SoHieu], ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0}, ChungTu.SoPS, ChungTu.SoPS2No, ChungTu.SoPS2Co, ChungTu.GhiChu, HeThongTK.SoHieu as [HeThongTK.SoHieu], HeThongTK_1.SoHieu as [HeThongTK_1.SoHieu], ChungTu.MaTKNo, ChungTu.MaTKCo, HethongTK_2.SoHieu AS SHNo, HethongTK_3.SoHieu AS SHCo, MaKH,MaKHC, ThangCT FROM HeThongTK AS HeThongTK_3 RIGHT JOIN (HeThongTK AS HeThongTK_2 RIGHT JOIN (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo) ON HeThongTK_2.MaSo = ChungTu.MaTKNo) ON HeThongTK_3.MaSo = ChungTu.MaTKCo WHERE (SoPS<>0 OR SoPS2No<>0 OR SoPS2Co<>0) AND ({1} AND ({2})) AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco)) ORDER BY ChungTu.NgayGS, ChungTu.MaCT", _
                                   (IIf(pNN > 0, "E", String.Empty)), _
                                   sqlw, _
                                   sql)
            i = GetRowNumber(QChitiet)
            If i = 0 And dkn = 0 And dkc = 0 Then GoTo KhongIn
            rptFrom.InitForm("CTTKCN.RPT", QChitiet, "QChitiet")

            rptFrom.SetFormulas("SoHieuTk", String.Format("'{0}'", taikhoan.sohieu))
            rptFrom.SetFormulas("MaCN", cn.MaSo)
        Else
            If nt = 0 Then GoTo KhongNT
            If (taikhoan.kieu < 0 And dkc > dkn) Or (taikhoan.kieu > 0 And dkc < dkn) Then dknt = -dknt
            Dim QChitiet As String = String.Format("SELECT DISTINCT ChungTu.MaCT, ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0}, ChungTu.SoPS, ChungTu.SoPS2No, ChungTu.SoPS2Co, ChungTu.GhiChu, HeThongTK.SoHieu, HeThongTK_1.SoHieu, ChungTu.MaTKNo, ChungTu.MaTKCo, MaKH, MaKHC  FROM HeThongTK AS HeThongTK_3 RIGHT JOIN (HeThongTK AS HeThongTK_2 RIGHT JOIN (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo) ON HeThongTK_2.MaSo = ChungTu.MaTKNo) ON HeThongTK_3.MaSo = ChungTu.MaTKCo WHERE (SoPS<>0 OR SoPS2No<>0 OR SoPS2Co<>0) AND (MaKH={1} OR MaKHC={2}) AND {3} AND {4} ORDER BY Chungtu.NgayGS, Chungtu.MaCT", (IIf(pNN > 0, "E", String.Empty)), mcn, ConvertToStrSafe(mcn), sqlw, sql)
            i = GetRowNumber(QChitiet)
            If i = 0 And dkn = 0 And dkc = 0 Then GoTo KhongIn
            If i = 0 Then
                QChitiet = "SELECT DISTINCT 0 AS MaCT, '' AS SoHieu, Null AS NgayCT, Null AS NgayGS, '' AS DienGiai, 0 AS SoPS, 0 AS SoPS2No, 0 AS SoPS2Co, '' AS GhiChu, '' AS SoHieu1, '' AS SoHieu2, 0 AS MaTKNo, 0 AS MaTKCo, 0 AS MaKH,0 AS MaKHC" & " FROM ChungTu WHERE (chungtu.MaCT = 0)"
            End If
            rptFrom.InitForm("CTTKCNNT.RPT", QChitiet, "QChitiet")


            rptFrom.SetFormulas("MaTk", taikhoan.maso)
            rptFrom.SetFormulas("NoDkNT", dknt)
            rptFrom.SetFormulas("MaCN", cn.MaSo)
        End If
        GauGe.Value = 2

        rptFrom.SetFormulas("NoDk", dkn - dkc)
        rptFrom.SetFormulas("Kieu", taikhoan.kieu)
        If tcuoi > 0 Then
            RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
            cn.SoPhatSinh(pThangDauKy, _
                tcuoi, _
                dkn, _
                dkc, _
                dknt, _
                dknt, _
                taikhoan.maso)
        Else
            RptSetDate(ncuoi)
            SoPhatSinhN(cn.MaSo, _
                NgayDauThang(pNamTC, pThangDauKy), _
                ncuoi, _
                dkn, _
                dkc, _
                dknt, _
                X, _
                taikhoan.maso)
        End If

        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi)))))
        rptFrom.SetFormulas("NoLK", dkn)
        rptFrom.SetFormulas("CoLK", dkc)
        rptFrom.SetFormulas("TenTk", String.Format("'TK: {0} - {1}: {2}'", _
                                        taikhoan.sohieu, _
                                        cn.SoHieu, _
                                        (IIf(pNN > 0, cn.TenE, cn.Ten))))
        If pCongNoHD > 0 And taikhoan.tk_id = TKCNKH_ID Then
            sql = cn.HDChuaTT(Math.Max(tcuoi, 0), ncuoi, taikhoan.sohieu, cn.MaSo)
            If sql.Length > 0 Then rptFrom.SetFormulas("HDTT", String.Format("'{0}'", sql))
        End If
        result = True
        GoTo kt
KhongIn:
        result = False
kt:
        GauGe.Value = 3
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="mvt"></param>
    ''' <param name="nn"></param>
    ''' <remarks></remarks>
    Sub InCTDoanhThu2(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef mvt As Integer, Optional ByRef nn As Integer = 0)
        Dim st = String.Empty
        Dim dv As String = String.Empty
        Dim wsql As String = IIf(tdau > 0, WThang("ThangCT", tdau, tcuoi), WNgay("NgayGS", ndau, ncuoi))
        Dim sql As String = String.Format("SELECT DISTINCT ChungTu.MaSo,ChungTu.SoHieu, NgayCT, NgayGS, ChungTu.DienGiai{0}, ChungTu.SoPS, ChungTu.SoPS2Co, HethongTK.SoHieu AS TKDU  FROM (ChungTu INNER JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo) LEFT JOIN HethongTK ON ChungTu.MaTKNo = HethongTK.MaSo WHERE {1} AND TK.TK_ID={2} AND MaVattu={3}", _
                                (IIf(pNN > 0, "E", String.Empty)), _
                                wsql, _
                                ConvertToStrSafe(TKDT_ID), _
                                ConvertToStrSafe(mvt))
        sql = String.Format("{0} UNION SELECT DISTINCT ChungTu.MaSo,ChungTu.SoHieu, NgayCT, NgayGS, ChungTu.DienGiai{1}, ChungTu.SoPS, ChungTu.SoPS2No, TK.SoHieu AS TKDU  FROM (ChungTu INNER JOIN HethongTK AS TK ON ChungTu.MaTKCo=TK.MaSo) LEFT JOIN HethongTK ON ChungTu.MaTKNo = HethongTK.MaSo WHERE {2} AND HethongTK.TK_ID={3} AND TK.TK_ID={4} AND MaVattu={5}", _
                  sql, _
                  (IIf(pNN > 0, "E", String.Empty)), _
                  wsql, _
                  ConvertToStrSafe(TKDT_ID), _
                  ConvertToStrSafe(TKGT_ID), _
                  ConvertToStrSafe(mvt))

        rptFrom.InitForm("CTDT3.RPT", sql, "QChitiet")

        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", (IIf(tdau > 0, ThoiGianTheoThang(tdau, tcuoi), ThoiGianN(ndau, ncuoi)))))
        sql = String.Format("SELECT Sum(SoPS) AS F1 FROM {0} WHERE MaLoai=2 AND HethongTK.SoHieu LIKE '632%' AND MaVattu={1} AND {2}", ChungTu2TKNC(-2), ConvertToStrSafe(mvt), wsql)
        rptFrom.SetFormulas("GV ", ConvertToDblSafe(GetSelectValue(sql)))
        sql = TenVT(st, mvt, dv)
        rptFrom.SetFormulas("TenVt", String.Format(Ngonngu("'{0} - {1}- Đơn vị tính:{2}'", "'{0} - {1}- Unit:{2}'"), st, sql, dv))
        RptSetDate(ncuoi)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="GauGe"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="nn"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function InVATMienGiam(ByRef GauGe As ProgressBar, ByRef tdau As Integer, ByRef tcuoi As Integer, Optional ByRef nn As Integer = 0) As Boolean
        Dim result As Boolean = False
        Dim taikhoan As New ClsTaikhoan
        Dim dkc, dkn, dknt As Double
        GauGe.Maximum = 3
        Dim shtkmg1 As String = Interaction.GetSetting(IniPath, "VAT", "TK_DAURA", "333111")
        Dim shtkmg2 As String = Interaction.GetSetting(IniPath, "VAT", "TK_NK", "333121")
        Dim shtkdg1 As String = Interaction.GetSetting(IniPath, "VAT", "TK_GIAM", "333112")
        Dim shtkdg2 As String = Interaction.GetSetting(IniPath, "VAT", "TK_NKGIAM", "333122")
        Dim shtktntc As String = Interaction.GetSetting(IniPath, "VAT", "TK_TNTC", "721")
        taikhoan.InitTaikhoanSohieu(shtkdg1)
        taikhoan.SoDuTK(ThangTruoc(tdau), dkn, dkc, dknt)
        Dim dkco As Double = dkc - dkn
        GauGe.Value = 1
        taikhoan.InitTaikhoanSohieu(shtkdg2)
        taikhoan.SoDuTK(ThangTruoc(tdau), dkn, dkc, dknt)
        dkco = dkco + dkc - dkn
        GauGe.Value = 2
        Dim sql As String = String.Format("SELECT DISTINCT ChungTu.MaCT, ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0}, ChungTu.SoPS, ChungTu.GhiChu, HeThongTK.SoHieu, HeThongTK_1.SoHieu, ChungTu.MaTKTCNo, ChungTu.MaTKTCCo FROM HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo WHERE ((HethongTK.SoHieu LIKE '{1}%' AND HethongTK_1.SoHieu LIKE '{2}%') OR (HethongTK.SoHieu LIKE '{3}%' AND HethongTK_1.SoHieu LIKE '{4}%') OR ((HethongTK.SoHieu LIKE '{2}%' OR HethongTK.SoHieu LIKE '{4}%') AND HethongTK_1.SoHieu LIKE '{5}%')) AND {6} ORDER BY ChungTu.NgayGS, ChungTu.MaCT", _
                                (IIf(pNN > 0, "E", String.Empty)), _
                                shtkmg1, _
                                shtkdg1, _
                                shtkmg2, _
                                shtkdg2, _
                                shtktntc, _
                                WThang("ThangCT", tdau, tcuoi))
        Dim QSocai As String

        If GetRowNumber(sql) Then
            QSocai = sql
        Else
            If dkco = 0 Then GoTo KhongIn
            QSocai = String.Format("SELECT DISTINCT ChungTu.MaCT, ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0}, ChungTu.SoPS, ChungTu.GhiChu, HeThongTK.SoHieu, HeThongTK_1.SoHieu, ChungTu.MaTKTCNo, ChungTu.MaTKTCCo FROM HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo WHERE (chungtu.MaCT = 0)", (IIf(pNN > 0, "E", String.Empty)))
            rptFrom.SetFormulas("DuCk", dkco)
        End If
        GauGe.Value = 3
        rptFrom.InitForm("VATMG.RPT", QSocai, "QSocai")

        rptFrom.SetFormulas("SoHieuTK1", String.Format("'{0}'", shtkmg1))
        rptFrom.SetFormulas("SoHieuTK2", String.Format("'{0}'", shtkmg2))
        rptFrom.SetFormulas("NoDk", dkco)
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        InBaoCaoRPT()
        Return True
KhongIn:
        ErrMsg(er_KoPS1)
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="GauGe"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="nn"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function InVATHoanLai(ByRef GauGe As ProgressBar, ByRef tdau As Integer, ByRef tcuoi As Integer, Optional ByRef nn As Integer = 0) As Boolean
        Dim result As Boolean = False
        Dim taikhoan As New ClsTaikhoan
        Dim psn, dkc, dkn, dknt, psc As Double
        GauGe.Maximum = 5
        Dim shtkhl1 As String = Interaction.GetSetting(IniPath, "VAT", "TK_HOANLAI", String.Format("{0}112", pVATV))
        Dim shtkhl2 As String = Interaction.GetSetting(IniPath, "VAT", "TK_HOANLAI", String.Format("{0}212", pVATV))
        taikhoan.InitTaikhoanSohieu(shtkhl1)
        taikhoan.SoDuTK(ThangTruoc(tdau), dkn, dkc, dknt)
        Dim dkno As Double = dkn - dkc
        GauGe.Value = 1
        taikhoan.SoPhatSinh(tdau, tcuoi, psn, psc)
        Dim psno As Double = psn
        Dim psco As Double = psc
        GauGe.Value = 2
        taikhoan.InitTaikhoanSohieu(shtkhl2)
        taikhoan.SoDuTK(tdau, dkn, dkc, dknt)
        dkno = dkno + dkn - dkc
        GauGe.Value = 3
        taikhoan.SoPhatSinh(tdau, tcuoi, psn, psc)
        psno += psn
        psco += psc
        GauGe.Value = 4
        If dkno = 0 And psno = 0 And psco = 0 Then GoTo KhongIn

        Dim QSocai As String
        If psno <> 0 Or psco <> 0 Then
            QSocai = String.Format("SELECT DISTINCT ChungTu.MaCT, ChungTu.SoHieu as [ChungTu.SoHieu], ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0}, ChungTu.SoPS, ChungTu.GhiChu, HeThongTK.SoHieu as [HeThongTK.SoHieu], HeThongTK_1.SoHieu as [HeThongTK_1.SoHieu], ChungTu.MaTKTCNo, ChungTu.MaTKTCCo FROM HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo WHERE ((HethongTK.SoHieu LIKE '{1}%' OR HethongTK.SoHieu LIKE '{2}%') OR (HethongTK_1.SoHieu LIKE '{1}%' OR HethongTK_1.SoHieu LIKE '{2}%')) AND {3} ORDER BY ChungTu.NgayGS, ChungTu.MaCT", (IIf(pNN > 0, "E", String.Empty)), shtkhl1, shtkhl2, WThang("ThangCT", tdau, tcuoi))
            rptFrom.InitForm("VATHL.RPT", QSocai, "QSocai")
        Else
            QSocai = String.Format("SELECT DISTINCT ChungTu.MaCT, ChungTu.SoHieu as [ChungTu.SoHieu], ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0}, ChungTu.SoPS, ChungTu.GhiChu, HeThongTK.SoHieu as [HeThongTK.SoHieu], HeThongTK_1.SoHieu as [HeThongTK_1.SoHieu], ChungTu.MaTKTCNo, ChungTu.MaTKTCCo FROM HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo WHERE (chungtu.MaCT = 0)", (IIf(pNN > 0, "E", String.Empty)))
            rptFrom.InitForm("VATHL.RPT", QSocai, "QSocai")
            rptFrom.SetFormulas("DuCk", dkno)
        End If
        GauGe.Value = 5

        rptFrom.SetFormulas("SoHieuTK1", String.Format("'{0}'", shtkhl1))
        rptFrom.SetFormulas("SoHieuTK2", String.Format("'{0}'", shtkhl2))
        rptFrom.SetFormulas("NoDk", dkno)
        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianTheoThang(tdau, tcuoi)))

        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        Return True
KhongIn:
        ErrMsg(er_KoPS1)
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="GauGe"></param>
    ''' <param name="TK"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function BKChiTietRPT(ByRef GauGe As ProgressBar, ByRef TK As String, ByRef ndau As Date, ByRef ncuoi As Date) As Boolean
        Dim result As Boolean = False
        Dim i As Integer
        Dim tdau As Integer = ndau.Month - 1
        Dim tcuoi As Integer = ncuoi.Month
        Dim sql As String = String.Format("SELECT DISTINCT LEFT(HethongTK.SoHieu,4) AS SHN,(hethongtk.duno_{0}-hethongtk.duco_{1}) AS dauky,(hethongtk.duno_{2}-hethongtk.duco_{2}) AS cuoiky FROM {3} WHERE (HethongTK.SoHieu LIKE '{4}%') AND {5} AND SoPS<>0 ", _
                                tdau, _
                                ConvertToStrSafe(tdau), _
                                ConvertToStrSafe(tcuoi), _
                                ChungTu2TKNC(-1), _
                                TK, _
                                WNgay("NgayGS", ndau, ncuoi))
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        If Not (rs.Rows.Count = 0) Then
            sql = String.Format("SELECT DISTINCT LEFT(HethongTK.SoHieu,4) AS SHN,LEFT(TK.SoHieu,4) AS SHC, NgayGS,ChungTu.SoHieu,NgayCT,SoPS,CASE WHEN(HethongTK.SoHieu LIKE '{0}%') THEN LEFT(TK.SoHieu,3) ELSE LEFT(HethongTK.SoHieu,3) END AS TKDU,ChungTu.DienGiai FROM {1} WHERE (HethongTK.SoHieu LIKE '{0}%') AND {2} AND SoPS<>0 ORDER BY NgayCT", _
                     TK, _
                     ChungTu2TKNC(0), _
                     WNgay("NgayGS", ndau, ncuoi))

            rptFrom.InitForm("BKCT.RPT", sql, "QSoCai")

            Dim rsIndex As Integer = 0
            Do While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL AND i < 7
                i += 1
                rptFrom.SetFormulas("TK" & CStr(i), String.Format("'{0}'", rsItem("SHN")))
                rptFrom.SetFormulas("DK" & CStr(i), rsItem("dauky"))
                rptFrom.SetFormulas("CK" & CStr(i), rsItem("cuoiky"))
                ''rs.MoveNext()
            Loop
            ''rs.Close()
            rs = Nothing
            rptFrom.SetFormulas("SoHieuTK", String.Format("'{0}'", TK))
            rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", ThoiGianN(ndau, ncuoi)))
            rptFrom.SetFormulas("DiaChi", String.Format("'{0}'", frmMain._LbCty_2.Text))

            RptSetDate(ncuoi)
            Return True
        End If
        ''rs.Close()
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="GauGe"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function TDGTGT(ByRef GauGe As ProgressBar, ByRef tdau As Integer, ByRef tcuoi As Integer) As Boolean
        Dim Thue As Double
        Dim w As String = WThang("ThangCT", tdau, tcuoi)
        ExecSQLNonQuery("DELETE FROM BKNhomPS")
        Dim sql As String = "SELECT ct.mact, ct.sohieu, ct.ngaygs, ct.DienGiai, ct.sops,ct.thangct FROM (chungtu ct inner join hethongtk tkn on ct.matkno=tkn.maso) inner join hethongtk tkc on ct.matkco=tkc.maso WHERE (tkc.sohieu LIKE '111%' OR tkc.sohieu LIKE '112%') AND tkn.sohieu LIKE '3331%' AND " & w
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        Dim rsIndex As Integer = 0
        While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            If ConvertToDblSafe(GetSelectValue("SELECT count(ct.maso) AS f1 FROM (chungtu ct inner join hethongtk tkn on ct.matkno=tkn.maso) inner join hethongtk tkc on ct.matkco=tkc.maso WHERE ((LEFT(tkc.sohieu,3) <> '111' AND LEFT(tkc.sohieu,3) <> '112') OR LEFT(tkn.sohieu,4) <> '3331') AND mact=" & rsItem("MaCT"))) = 0 Then
                ExecSQLNonQuery(String.Format("INSERT INTO BKNhomPS(mact,sops2no, sohieu, ngay, DienGiai, sopsno, shtk) VALUES({1},{2}, N'{3}', N'{4}', N'{5}',{6},{7})", _
                                    Lng_MaxValue("maso", "BKNhomPS") + 1, _
                                    rsItem("MaCT"), _
                                    rsItem("ThangCT"), _
                                    rsItem("SoHieu"), _
                                    rsItem("NgayGS"), _
                                    rsItem("DienGiai"), _
                                    rsItem("sops"), _
                                    ConvertToStrSafe(Lng_MaxValue("shtk", "BKNhomPS") + 1)))
                Thue = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(chungtu.sops) AS f1 FROM{0} WHERE chungtu.thangct={1} AND (hethongtk.sohieu LIKE '111%' OR hethongtk.sohieu LIKE '112%') AND tk.sohieu LIKE '3331%' group by chungtu.thangct", _
                                                           ChungTu2TKNC(0), _
                                                           rsItem("ThangCT"))))
                ExecSQLNonQuery(String.Format("UPDATE BKNhomPS SET sopsco ={0} WHERE sohieu=N'{1}'", _
                                    Thue, _
                                    rsItem("SoHieu")))
            End If
            ''rs.MoveNext()
        End While
        rptFrom.InitForm("S26.RPT", "SELECT * FROM BKNhomPS", "BKNhomPS")

        rptFrom.SetFormulas("Diachi", String.Format("'{0}'", frmMain._LbCty_2.Text))
        rptFrom.SetFormulas("tdau", tdau)
        rptFrom.SetFormulas("tcuoi", tcuoi)
        InBaoCaoRPT()
        Return True
    End Function
End Module
