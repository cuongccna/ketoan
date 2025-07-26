Imports System
Imports System.Data
Imports System.Text
Imports UNET.Utility
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter

Friend Class Cls154
    ' Kieu vat tu
    Public MaSo As Integer ' Ma vat tu
    Public MaPhanLoai As Integer ' ma phan loai
    Public SoHieu As String = String.Empty ' So hieu vat tu
    Public TenVattu As String = String.Empty ' Ten vat tu
    Public DonVi As String = String.Empty ' Don vi tinh
    Public GhiChu As String = String.Empty
    Public MaTK As Integer
    Public MaPhanLoai1 As Long       ' ma phan loai nhom

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Init()
        MaSo = 0
        MaPhanLoai = 0
        MaPhanLoai1 = 0
        SoHieu = ""
        TenVattu = ""
        DonVi = ""
        GhiChu = "..."
        MaTK = 0
    End Sub
    ''' <summary>
    ''' Thu tuc khoi tao object tu ma so vat tu
    ''' </summary>
    ''' <param name="mvt">Ma so vat tu can tham chieu = 0 neu vat tu moi</param>
    ''' <remarks></remarks>
    Public Sub InitTPMaSo(ByRef mvt As Integer)
        Dim rs_vattu As DataTable
        Init()
        If mvt > 0 Then
            rs_vattu = ExecSQLReturnDT(String.Format("SELECT * FROM TP154 WHERE MaSo={0}", mvt))
            If rs_vattu.Rows.Count > 0 Then
                Dim rs_vattuItem As DataRow = rs_vattu.Rows(0)
                If rs_vattuItem("MaSo") IsNot Nothing Then
                    MaSo = rs_vattuItem("MaSo")
                End If

                If rs_vattuItem("MaPhanLoai") IsNot Nothing Then
                    MaPhanLoai = rs_vattuItem("MaPhanLoai")
                End If

                If rs_vattuItem("MaPhanLoai1") IsNot Nothing Then
                    MaPhanLoai1 = rs_vattuItem("MaPhanLoai1")
                End If

                If rs_vattuItem("SoHieu") IsNot Nothing Then
                    SoHieu = rs_vattuItem("SoHieu")
                End If

                If rs_vattuItem("TenVattu") IsNot Nothing Then
                    TenVattu = rs_vattuItem("TenVattu")
                End If

                If rs_vattuItem("DonVi") IsNot Nothing Then
                    DonVi = rs_vattuItem("DonVi")
                End If

                If rs_vattuItem("GhiChu") IsNot Nothing Then
                    GhiChu = rs_vattuItem("GhiChu")
                End If

                If rs_vattuItem("MaTK") IsNot Nothing Then
                    MaTK = rs_vattuItem("MaTK")
                End If
            End If
        End If
    End Sub
    ''' <summary>
    ''' Thu tuc khoi tao object tu so hieu vat tu
    ''' </summary>
    ''' <param name="shvt">So hieu vat tu can tham chieu</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InitTPSohieu(ByRef shvt As String) As String
        Dim sql As String = String.Format("SELECT DISTINCT MaSo AS F1 FROM TP154 WHERE Sohieu=N'{0}'", shvt)
        InitTPMaSo(ConvertToDblSafe(GetSelectValue(sql)))
        Return TenVattu
    End Function
    ''' <summary>
    ''' Thu tuc dang ky vat tu
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GhiTP() As Integer
        Dim result As Integer = 0
        Dim sql As String = String.Format("INSERT INTO TP154 (MaPhanLoai1,MaSo,MaPhanLoai,SoHieu,TenVattu,DonVi,GhiChu,MaTK) VALUES ({7},{0},{1}, N'{2}', N'{3}', N'{4}', N'{5}',{6})", _
                                Lng_MaxValue("MaSo", "TP154") + 1, _
                                MaPhanLoai, _
                                SoHieu, _
                                TenVattu, _
                                DonVi, _
                                GhiChu, _
                                ConvertToStrSafe(MaTK), _
                                MaPhanLoai1)
        If ExecSQLNonQuery(sql) <> 0 Then
            result = -1
        Else
            result = 0
            MaSo = Lng_MaxValue("MaSo", "TP154")
        End If
        Return result
    End Function
    ''' <summary>
    ''' Cap nhat thong tin ve vat tu
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SuaTP() As Integer
        Dim sql As String = String.Format("UPDATE TP154 SET MaPhanLoai1={7},MaPhanLoai={0},SoHieu=N'{1}',TenVattu=N'{2}',DonVi=N'{3}',GhiChu=N'{4}',MaTK={5} WHERE MaSo={6}", _
                                MaPhanLoai, _
                                SoHieu, _
                                TenVattu, _
                                DonVi, _
                                GhiChu, _
                                MaTK, _
                                MaSo, _
                                MaPhanLoai1)
        If ExecSQLNonQuery(sql) <> 0 Then
            Return -1
        Else
            Return 0
        End If
    End Function
    ''' <summary>
    ''' Thu tuc xoa mot vat tu
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function XoaTP() As Integer
        Dim result As Integer = 0
        Dim TK As New ClsTaikhoan
        result = -1
        If ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM ChungTu WHERE MaTP={0}", MaSo))) <> 0 Then Return result
        If ExecSQLNonQuery(String.Format("DELETE FROM TP154 WHERE MaSo={0}", MaSo)) = 0 Then result = 0
        TK.InitTaikhoanMaSo(MaTK)
        TK.NoDauKy = ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(DK) AS F1 FROM TP154 WHERE MaTK={0}", MaTK)))
        TK.CoDauKy = 0
        TK.CapNhatTk()
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoCPNVL(ByRef tdau As Integer, ByRef tcuoi As Integer) As Double
        Dim result As Double = 0
        Dim sql As String = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE HethongTK.SoHieu LIKE '621%' AND {1} AND MaTP={2}", _
                                ChungTu2TKNC(-1), _
                                WThang("ThangCT", tdau, tcuoi), _
                                MaSo)
        result = ConvertToDblSafe(GetSelectValue(sql))
        sql = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE HethongTK.SoHieu LIKE '152%' AND TK.SoHieu LIKE '621%' AND {1} AND MaTP={2}", _
                  ChungTu2TKNC(0), _
                  WThang("ThangCT", tdau, tcuoi), _
                  MaSo)
        result = result - ConvertToDblSafe(GetSelectValue(sql))
        If result = 0 Then
            sql = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE HethongTK.SoHieu LIKE '1541%' AND TK.SoHieu LIKE '621%' AND {1} AND MaTP={2}", _
                      ChungTu2TKNC(0), _
                      WThang("ThangCT", tdau, tcuoi), _
                      MaSo)
            result = ConvertToDblSafe(GetSelectValue(sql))
        End If
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoCPNC(ByRef tdau As Integer, ByRef tcuoi As Integer) As Double
        Dim result As Double = 0
        Dim sql As String = String.Empty
        If SoHieu.StartsWith("T") Then
            'Tong 622 cua lo san xuat LIKE "T*" tu dau den truoc thang hien tai
            result = ConvertToDblSafe(GetSelectValue(String.Format("SELECT ISNULL(SUM(SoPS),0) AS F1 FROM {0} WHERE HethongTK.SoHieu LIKE '622%' AND {1} AND MaTP={2}", _
                                                         ChungTu2TKNC(-1), _
                                                         WThang("ThangCT", tdau, tcuoi), _
                                                         MaSo)))
        Else
            'Tong 622 cua lo san xuat not LIKE "T*" thang truoc do
            result = ConvertToDblSafe(GetSelectValue(String.Format("SELECT ISNULL(SUM(SoPS),0) AS F1 FROM {0} WHERE HethongTK.SoHieu LIKE '622%' AND {1} AND MaTP={2}", _
                                                         ChungTu2TKNC(-1), _
                                                         WThang("ThangCT", tcuoi, tcuoi), _
                                                         MaSo)))
        End If
        Dim sh1, sh As String
        Dim sops627b, sops627a, TyLe As Double
        If MaSo <> 0 Then
            sh1 = "627" : sh = "622"
            sops627a = ConvertToDblSafe(GetSelectValue(String.Format("SELECT ISNULL(SUM(SoPS),0) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                            ChungTu2TKNC(-1), _
                                                            WThang("ThangCT", tdau, tcuoi), _
                                                            sh1, _
                                                            (IIf(MaSo > 0, String.Format(" AND MaTP={0} AND LEFT(tp154.sohieu, 1)=N'{1}'", _
                                                                               MaSo, _
                                                                               Strings.Left(SoHieu, 1)), String.Empty)))))
            If tdau <> tcuoi Then
                sops627a = ConvertToDblSafe(sops627a - ConvertToDblSafe(GetSelectValue(String.Format("SELECT ISNULL(SUM(SoPS),0) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE MaLoai<>3 AND {1} AND HethongTK.SoHieu LIKE '{2}%'{3}", _
                                                                                 ChungTu2TKNC(1), _
                                                                                 WThang("ThangCT", Math.Min(tcuoi - 1, tdau), tcuoi - 1), _
                                                                                 sh1, _
                                                                                 (IIf(MaSo > 0, String.Format(" AND MaTP={0} AND LEFT(tp154.sohieu, 1)=N'{1}'", MaSo, Strings.Left(SoHieu, 1)), String.Empty))))))
            End If

            sops627b = ConvertToDblSafe(GetSelectValue(String.Format("SELECT ISNULL(SUM(SoPS),0) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%' AND tp154.sohieu='T{3}'", _
                                                            ChungTu2TKNC(-1), _
                                                            WThang("ThangCT", 0, tcuoi), _
                                                            sh1, _
                                                            ConvertToStrSafe(tcuoi))))
            sops627b += ConvertToDblSafe(GetSelectValue(String.Format("SELECT ISNULL(SUM(SoPS),0) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%' AND LEFT(tp154.sohieu, 1)<>'T'", _
                                                             ChungTu2TKNC(-1), _
                                                             WThang("ThangCT", tcuoi, tcuoi), _
                                                             sh1), String.Empty))
            TyLe = sops627a / (IIf(sops627b <> 0, sops627b, 1))
            sops627a = ConvertToDblSafe(GetSelectValue(String.Format("SELECT ISNULL(SUM(SoPS),0) AS F1 FROM ({0})inner join tp154 on chungtu.matp=tp154.maso WHERE {1} AND HethongTK.SoHieu LIKE '{2}%' AND Upper(tp154.sohieu)='CH'", _
                                                            ChungTu2TKNC(-1), _
                                                            WThang("ThangCT", tcuoi, tcuoi), _
                                                            sh)))
            result = TyLe * sops627a + result
        End If
        If result = 0 Then
            sql = String.Format("SELECT ISNULL(SUM(SoPS),0) AS F1 FROM {0} WHERE HethongTK.SoHieu LIKE '1541%' AND TK.SoHieu LIKE '622%' AND {1} AND MaTP={2}", _
                      ChungTu2TKNC(0), _
                      WThang("ThangCT", tdau, tcuoi), _
                      MaSo)
            result = ConvertToDblSafe(GetSelectValue(sql))
        End If
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoCPKHTT(ByRef tdau As Integer, ByRef tcuoi As Integer) As Double
        Dim sql As String = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE MaLoai=12 AND TK_ID2={1} AND {2} AND MaTP={3}", _
                                ChungTu2TKNC(-1), _
                                ConvertToStrSafe(TKCPSX_ID), _
                                WThang("ThangCT", tdau, tcuoi), _
                                MaSo)
        Return ConvertToDblSafe(GetSelectValue(sql))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoSanLuong(ByRef tdau As Integer, ByRef tcuoi As Integer) As Double
        Dim sql As String = String.Format("SELECT SUM(SoLuong) AS F1 FROM ThanhPham WHERE {0} AND Ma154={1}", _
                                WThang("Thang", tdau, tcuoi), _
                                MaSo)
        Return ConvertToDblSafe(GetSelectValue(sql))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoCPM(ByRef tdau As Integer, ByRef tcuoi As Integer) As Double
        Dim result As Double = 0
        Dim sql As String = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE HethongTK.SoHieu LIKE '623%' AND {1} AND MaTP={2}", _
                                ChungTu2TKNC(-1), _
                                WThang("ThangCT", tdau, tcuoi), _
                                MaSo)
        result = ConvertToDblSafe(GetSelectValue(sql))
        If result = 0 Then
            sql = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE HethongTK.SoHieu LIKE '1541%' AND TK.SoHieu LIKE '623%' AND {1} AND MaTP={2}", _
                      ChungTu2TKNC(0), _
                      WThang("ThangCT", tdau, tcuoi), _
                      MaSo)
            result = ConvertToDblSafe(GetSelectValue(sql))
        End If
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoCPNVLPB(ByRef tdau As Integer, ByRef tcuoi As Integer) As Double
        Dim sql As String = String.Empty
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            If String.IsNullOrEmpty(sql) Then
                sql = String.Format("CPNVLPB{0}", i)
            Else
                sql = String.Format("{0}+CPNVLPB{1}", sql, i)
            End If
        Next
        sql = String.Format("SELECT ({0}) AS F1 FROM TP154 WHERE MaSo={1}", sql, MaSo)
        Return ConvertToDblSafe(GetSelectValue(sql))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoCPNCPB(ByRef tdau As Integer, ByRef tcuoi As Integer) As Double
        Dim sql As String = String.Empty
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            If String.IsNullOrEmpty(sql) Then
                sql = String.Format("CPNCPB{0}", i)
            Else
                sql = String.Format("{0}+CPNCPB{1}", sql, i)
            End If
        Next
        sql = String.Format("SELECT ({0}) AS F1 FROM TP154 WHERE MaSo={1}", sql, MaSo)
        Return ConvertToDblSafe(GetSelectValue(sql))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoCPMPB(ByRef tdau As Integer, ByRef tcuoi As Integer) As Double
        Dim sql As String = String.Empty
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            If String.IsNullOrEmpty(sql) Then
                sql = String.Format("CPMPB{0}", i)
            Else
                sql = String.Format("{0}+CPMPB{1}", sql, i)
            End If
        Next
        sql = String.Format("SELECT ({0}) AS F1 FROM TP154 WHERE MaSo={1}", sql, MaSo)
        Return ConvertToDblSafe(GetSelectValue(sql))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoCPKH(ByRef tdau As Integer, ByRef tcuoi As Integer) As Double
        Dim sql As String = String.Empty

        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            If String.IsNullOrEmpty(sql) Then
                sql = String.Format("CPKH_{0}", i)
            Else
                sql = String.Format("{0}+CPKH_{1}", sql, i)
            End If
        Next
        sql = String.Format("SELECT ({0}) AS F1 FROM TP154 WHERE MaSo={1}", sql, MaSo)
        Return ConvertToDblSafe(GetSelectValue(sql))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoCPSXC(ByRef tdau As Integer, ByRef tcuoi As Integer) As Double
        Dim sql As String = String.Empty
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            If String.IsNullOrEmpty(sql) Then
                sql = String.Format("CPSXC_{0}", i)
            Else
                sql = String.Format("{0}+CPSXC_{1}", sql, i)
            End If
        Next
        sql = String.Format("SELECT ({0}) AS F1 FROM TP154 WHERE MaSo={1}", sql, MaSo)
        Return ConvertToDblSafe(GetSelectValue(sql))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoCPSXCTT(ByRef tdau As Integer, ByRef tcuoi As Integer) As Double
        Dim result As Double = 0
        Dim sql As String = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE HethongTK.SoHieu LIKE '627%' AND {1} AND MaTP={2}", _
                                ChungTu2TKNC(-1), _
                                WThang("ThangCT", tdau, tcuoi), _
                                MaSo)
        result = ConvertToDblSafe(GetSelectValue(sql))
        If result = 0 Then
            sql = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE HethongTK.SoHieu LIKE '1541%' AND HethongTK.SoHieu NOT LIKE '621%' AND HethongTK.SoHieu NOT LIKE '622%' AND HethongTK.SoHieu NOT LIKE '627%' AND TK.SoHieu LIKE '627%' AND {1} AND MaTP={2}", _
                      ChungTu2TKNC(0), _
                      WThang("ThangCT", tdau, tcuoi), _
                      MaSo)
            result = ConvertToDblSafe(GetSelectValue(sql))
        End If
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoCPBH(ByRef tdau As Integer, ByRef tcuoi As Integer) As Double
        Dim sql As String = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE HethongTK.SoHieu LIKE '641%' AND {1} AND MaTP={2}", _
                                ChungTu2TKNC(-1), _
                                WThang("ThangCT", tdau, tcuoi), _
                                MaSo)
        Return ConvertToDblSafe(GetSelectValue(sql))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoCPQL(ByRef tdau As Integer, ByRef tcuoi As Integer) As Double
        Dim sql As String = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE (HethongTK.SoHieu LIKE '911%' AND (TK.SoHieu LIKE '142%' OR TK.SoHieu LIKE '242%')) AND {1} AND MaTP={2}", _
                                ChungTu2TKNC(0), _
                                WThang("ThangCT", tdau, tcuoi), _
                                MaSo)
        Dim kq As Double = ConvertToDblSafe(GetSelectValue(sql))
        sql = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE HethongTK.SoHieu LIKE '642%' AND {1} AND MaTP={2}", _
                  ChungTu2TKNC(-1), _
                  WThang("ThangCT", tdau, tcuoi), _
                  MaSo)
        Return ConvertToDblSafe(GetSelectValue(sql)) + kq
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoDT(ByRef tdau As Integer, ByRef tcuoi As Integer) As Double
        Dim result As Double = 0
        Dim sql As String = String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE HethongTK.TK_ID={1} AND {2} AND MaTP={3}", _
                                ChungTu2TKNC(1), _
                                ConvertToStrSafe(TKDT_ID), _
                                WThang("ThangCT", tdau, tcuoi), _
                                MaSo)
        result = ConvertToDblSafe(GetSelectValue(sql))
        If result = 0 Then
            sql = String.Format("SELECT SUM(SoPS) AS F1 FROM ({0}) INNER JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo WHERE HethongTK.TK_ID={1} AND {2} AND Vattu.SoHieu=N'{3}'", _
                      ChungTu2TKNC(1), _
                      ConvertToStrSafe(TKDT_ID), _
                      WThang("ThangCT", tdau, tcuoi), _
                      SoHieu)
            result = ConvertToDblSafe(GetSelectValue(sql))
        End If
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoDK() As Double
        Dim sql As String = String.Format("SELECT DK AS F1 FROM TP154 WHERE MaSo={0}", MaSo)
        Return ConvertToDblSafe(GetSelectValue(sql))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="dk"></param>
    ''' <remarks></remarks>
    Public Sub GhiDK(ByRef dk As Double)
        Dim TK As New ClsTaikhoan
        ExecSQLNonQuery(String.Format("UPDATE TP154 SET DK={0} WHERE MaSo={1}", CStr(dk), MaSo))
        TK.InitTaikhoanMaSo(MaTK)
        TK.NoDauKy = ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(DK) AS F1 FROM TP154 WHERE MaTK={0}", MaTK)))
        TK.CoDauKy = 0
        TK.CapNhatTk()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GiaThanhCK(ByRef thang As Integer) As Double
        Dim result As Double = 0
        Dim X As Double
        If thang > 0 Then
            result = SoDK() + SoCPNVL(pThangDauKy, thang) + SoCPNC(pThangDauKy, thang) + SoCPM(pThangDauKy, thang) + SoCPNVLPB(pThangDauKy, thang) + SoCPNCPB(pThangDauKy, thang) + SoCPMPB(pThangDauKy, thang) + SoCPSXCTT(pThangDauKy, thang) + SoCPSXC(pThangDauKy, thang)
            X = ConvertToDblSafe(GetSelectValue(String.Format("SELECT SUM(SoPS) AS F1 FROM {0} WHERE HethongTK.SoHieu LIKE '1541%' AND MaTP={1} AND {2}", _
                                                    ChungTu2TKNC(1), _
                                                    MaSo, _
                                                    WThang("ThangCT", 0, thang))))
            Return result - X
        Else
            Return SoDK()
        End If
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ChiPhiTP(ByRef thang As Integer) As Double
        If thang > 0 Then
            Return SoDK() + SoCPNVL(pThangDauKy, thang) + SoCPNC(pThangDauKy, thang) + SoCPM(pThangDauKy, thang) + SoCPNVLPB(pThangDauKy, thang) + SoCPNCPB(pThangDauKy, thang) + SoCPMPB(pThangDauKy, thang) + SoCPSXCTT(pThangDauKy, thang) + SoCPSXC(pThangDauKy, thang)
        Else
            Return SoDK()
        End If
    End Function
    Public Sub GhiCPTT(ByRef tdau As Integer, ByRef tcuoi As Integer)
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            ExecSQLNonQuery(String.Format("UPDATE TP154 SET CPBHTT{0}={1},CPQLTT{2}={3},CPSXCTT{2}={4} WHERE MaSo={5}", _
                                i, _
                                CStr(SoCPBH(i, i)), _
                                i, _
                                CStr(SoCPQL(i, i)), _
                                CStr(SoCPSXCTT(i, i)), _
                                MaSo))
        Next
        ExecSQLNonQuery(String.Format("UPDATE TP154 SET CPNVL={0},CPNC={1},CPM={2},DT={3},SanLuong={4} WHERE MaSo={5}", _
                            CStr(SoCPNVL(tdau, tcuoi)), _
                            CStr(SoCPNC(tdau, tcuoi)), _
                            CStr(SoCPM(tdau, tcuoi)), _
                            CStr(SoDT(tdau, tcuoi)), _
                            CStr(SoSanLuong(tdau, tcuoi)), _
                            MaSo))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="cpkh"></param>
    ''' <param name="cpsxc"></param>
    ''' <remarks></remarks>
    Public Sub GhiCPPB(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef cpkh As Double, ByRef cpsxc As Double)
        Dim sql As New StringBuilder
        For i As Integer = CThangDB2(tdau) To CThangDB2(ThangTruoc(tcuoi))
            sql.Append(String.Format(",CPKH_{0}=0,CPSXC_{0}=0", i))
        Next
        ExecSQLNonQuery(String.Format("UPDATE TP154 SET CPNC=CPNC{0} WHERE MaSo={1}", _
                            sql, _
                            MaSo))
        sql = New StringBuilder(ConvertToStrSafe(CThangDB2(tcuoi)))
        ExecSQLNonQuery(String.Format("UPDATE TP154 SET CPKH_{0}={1},CPSXC_{0}={2} WHERE MaSo={3}", _
                            sql, _
                            CStr(cpkh), _
                            CStr(cpsxc), _
                            MaSo))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="cpbh"></param>
    ''' <param name="cpql"></param>
    ''' <param name="cptc"></param>
    ''' <remarks></remarks>
    Public Sub GhiCPPB2(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef cpbh As Double, ByRef cpql As Double, ByRef cptc As Double)
        Dim sql As New StringBuilder
        For i As Integer = CThangDB2(tdau) To CThangDB2(ThangTruoc(tcuoi))
            sql.Append(String.Format(",CPBH{0}=0,CPQL{0}=0,CPTC{1}=0", i))
        Next
        ExecSQLNonQuery(String.Format("UPDATE TP154 SET CPNC=CPNC{0} WHERE MaSo={1}", _
                            sql, _
                            MaSo))
        sql = New StringBuilder(ConvertToStrSafe(CThangDB2(tcuoi)))
        ExecSQLNonQuery(String.Format("UPDATE TP154 SET CPBH{0}={1},CPQL{0}={2},CPTC{0}={3} WHERE MaSo={4}", _
                            sql, _
                            CStr(cpbh), _
                            CStr(cpql), _
                            CStr(cptc), _
                            MaSo))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="cpnc"></param>
    ''' <param name="cpm"></param>
    ''' <remarks></remarks>
    Public Sub GhiCPPB3(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef cpnc As Double, ByRef cpm As Double)
        Dim sql As New StringBuilder
        For i As Integer = CThangDB2(tdau) To CThangDB2(ThangTruoc(tcuoi))
            sql.Append(String.Format(",CPNCPB{0}=0,CPMPB{0}=0", i))
        Next
        ExecSQLNonQuery(String.Format("UPDATE TP154 SET CPNC=CPNC{0} WHERE MaSo={1}", _
                            sql, _
                            MaSo))
        sql = New StringBuilder(ConvertToStrSafe(CThangDB2(tcuoi)))
        ExecSQLNonQuery(String.Format("UPDATE TP154 SET CPNCPB{0}={1},CPMPB{0}={2} WHERE MaSo={3}", _
                            sql, _
                            CStr(cpnc), _
                            CStr(cpm), _
                            MaSo))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <remarks></remarks>
    Public Sub XDDauKy(ByRef thang As Integer)
        ExecSQLNonQuery(String.Format("UPDATE TP154 SET DK1={0} WHERE MaSo={1}", _
                            CStr(GiaThanhCK(ThangTruoc(thang))), _
                            MaSo))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <remarks></remarks>
    Public Sub XDCuoiKy(ByRef thang As Integer)
        ExecSQLNonQuery(String.Format("UPDATE TP154 SET CK1={0} WHERE MaSo={1}", _
                            CStr(GiaThanhCK(thang)), _
                            MaSo))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tp"></param>
    ''' <remarks></remarks>
    Public Sub DanXuat(ByRef tp As Cls154)
        With tp
            .MaSo = MaSo
            .MaPhanLoai = MaPhanLoai
            .MaPhanLoai1 = MaPhanLoai1
            .SoHieu = SoHieu
            .TenVattu = TenVattu
            .DonVi = DonVi
            .GhiChu = GhiChu
            .MaTK = MaTK
        End With
    End Sub
End Class
