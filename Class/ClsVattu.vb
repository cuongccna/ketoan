Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports UNET.DataAdapter

Public Class ClsVattu
    ' Kieu vat tu
    Public MaSo As Integer ' Ma vat tu
    Public MaPhanLoai As Integer ' ma phan loai
    Public sohieu As String = String.Empty ' So hieu vat tu
    Public TenVattu As String = String.Empty ' Ten vat tu
    Public DonVi As String = String.Empty ' Don vi tinh
    Public TonMin As Double ' Luong ton toi thieu (=0 neu bo qua)
    Public TonMax As Double ' Luong ton toi da (=0 neu bo qua)
    Public GiaHT As Double
    Public Dvt2 As CheckState
    Public DonVi2 As String = String.Empty
    Public TyLeQD As Double
    Public GhiChu As String = String.Empty
    Public VAT As Integer
    Public GiaBan1 As Double
    Public GiaBan2 As Double
    Public GiaBan3 As Double
    Public CK As Double
    Public ThueNK As Double


    ''' Hàm kiểm tra tồn tại tên vật tư
    '''
    Public Function KiemTraTonTaiTenVatTu(ByVal _tenvattu As String) As Boolean
        Try
            Dim result As Boolean = False
            Dim sql As String = String.Format("SELECT DISTINCT Count(MaSo) AS F1 FROM Vattu WHERE tenvattu = N'{0}'", _tenvattu)
            result = ConvertToDblSafe(GetSelectValue(sql)) > 0
            Return result
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' Hàm kiểm tra tồn tại số hiệu vật tư
    '''
    Public Function KiemTraTonTaiSoHieuVatTu(ByVal _soHieu As String) As Boolean
        Try
            Dim result As Boolean = False
            Dim sql As String = String.Format("SELECT DISTINCT Count(MaSo) AS F1 FROM Vattu WHERE Sohieu = '{0}'", _soHieu)
            result = ConvertToDblSafe(GetSelectValue(sql)) > 0
            Return result
        Catch ex As Exception
            Return False
        End Try
    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Init()
        MaSo = 0
        MaPhanLoai = 0
        sohieu = ""
        TenVattu = ""
        DonVi = ""
        TonMin = 0
        TonMax = 0
        GiaHT = 0
        Dvt2 = CheckState.Unchecked
        DonVi2 = "..."
        TyLeQD = 0
        GhiChu = "..."
        VAT = 0
        GiaBan1 = 0
        GiaBan2 = 0
        GiaBan3 = 0
        CK = 0
        ThueNK = 0
    End Sub
    ''' <summary>
    ''' Thu tuc khoi tao object tu ma so vat tu
    ''' </summary>
    ''' <param name="mvt">Ma so vat tu can tham chieu = 0 neu vat tu moi</param>
    ''' <remarks></remarks>
    Public Sub InitVattuMaSo(ByRef mvt As Integer)
        Dim rs_vattu As DataTable
        Init()
        If mvt > 0 Then
            rs_vattu = ExecSQLReturnDT(String.Format("SELECT Vattu.* FROM Vattu WHERE Vattu.MaSo={0}", mvt))
            If rs_vattu.Rows.Count > 0 Then
                Dim rs_vattuItem As DataRow = rs_vattu.Rows(0)

                If rs_vattuItem("MaSo") IsNot Nothing Then
                    MaSo = ConvertToIDSafe(rs_vattuItem("MaSo"))
                End If

                If rs_vattuItem("MaPhanLoai") IsNot Nothing Then
                    MaPhanLoai = ConvertToIDSafe(rs_vattuItem("MaPhanLoai"))
                End If

                If rs_vattuItem("sohieu") IsNot Nothing Then
                    sohieu = ConvertToStrSafe(rs_vattuItem("sohieu"))
                End If

                If rs_vattuItem("TenVattu") IsNot Nothing Then
                    TenVattu = ConvertToStrSafe(rs_vattuItem("TenVattu"))
                End If

                If rs_vattuItem("DonVi") IsNot Nothing Then
                    DonVi = ConvertToStrSafe(rs_vattuItem("DonVi"))
                End If

                If rs_vattuItem("TonMin") IsNot Nothing Then
                    TonMin = ConvertToDblSafe(rs_vattuItem("TonMin"))
                End If

                If rs_vattuItem("TonMax") IsNot Nothing Then
                    TonMax = ConvertToDblSafe(rs_vattuItem("TonMax"))
                End If

                If rs_vattuItem("GiaHT") IsNot Nothing Then
                    GiaHT = ConvertToDblSafe(rs_vattuItem("GiaHT"))
                End If

                If rs_vattuItem("Dvt2") IsNot Nothing Then
                    Dvt2 = CType(ConvertToDblSafe(rs_vattuItem("Dvt2")), CheckState)
                End If

                If rs_vattuItem("DonVi2") IsNot Nothing Then
                    DonVi2 = ConvertToStrSafe(rs_vattuItem("DonVi2"))
                End If

                If rs_vattuItem("TyLeQD") IsNot Nothing Then
                    TyLeQD = ConvertToDblSafe(rs_vattuItem("TyLeQD"))
                End If

                If rs_vattuItem("GhiChu") IsNot Nothing Then
                    GhiChu = ConvertToStrSafe(rs_vattuItem("GhiChu"))
                End If

                If rs_vattuItem("VAT") IsNot Nothing Then
                    VAT = ConvertToDblSafe(rs_vattuItem("VAT"))
                End If

                If rs_vattuItem("GiaBan1") IsNot Nothing Then
                    GiaBan1 = ConvertToDblSafe(rs_vattuItem("GiaBan1"))
                End If

                If rs_vattuItem("GiaBan2") IsNot Nothing Then
                    GiaBan2 = ConvertToDblSafe(rs_vattuItem("GiaBan2"))
                End If

                If rs_vattuItem("GiaBan3") IsNot Nothing Then
                    GiaBan3 = ConvertToDblSafe(rs_vattuItem("GiaBan3"))
                End If

                If rs_vattuItem("CK") IsNot Nothing Then
                    CK = ConvertToDblSafe(rs_vattuItem("CK"))
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
    Public Function InitVattuSohieu(ByRef shvt As String) As String
        Dim sql As String = String.Format("SELECT DISTINCT MaSo AS F1 FROM Vattu WHERE Sohieu like N'{0}'", shvt)
        InitVattuMaSo(ConvertToDblSafe(GetSelectValue(sql)))
        Return TenVattu
    End Function
    ''' <summary>
    ''' Thu tuc dang ky vat tu
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GhiVattu() As Integer
        Dim result As Integer = 0
        Dim sql As String = String.Format("INSERT INTO Vattu (MaSo, MaPhanLoai,SoHieu,TenVattu,DonVi,TonMin,TonMax,GiaHT,Dvt2,DonVi2,TyLeQD,GhiChu,VAT,GiaBan1,GiaBan2,GiaBan3,CK,ThueNK) VALUES ({0},{1}, N'{2}', N'{3}', N'{4}',{5},{6},{7},{8}, N'{9}',{10}, N'{11}',{12},{13},{14},{15},{16},{17})", _
                                Lng_MaxValue("MaSo", "Vattu") + 1, _
                                ConvertToStrSafe(MaPhanLoai), _
                                sohieu, _
                                TenVattu, _
                                DonVi, _
                                CStr(TonMin), _
                                CStr(TonMax), _
                                CStr(RoundMoney(GiaHT)), _
                                IIf(Dvt2 = CheckState.Checked, "1", "0"), _
                                DonVi2, _
                                CStr(TyLeQD), _
                                GhiChu, _
                                ConvertToStrSafe(VAT), _
                                CStr(GiaBan1), _
                                CStr(GiaBan2), _
                                CStr(GiaBan3), _
                                CStr(CK), _
                                CStr(ThueNK))
        If ExecSQLNonQuery(sql) <> 0 Then
            result = -1
        Else
            result = 0
            MaSo = Lng_MaxValue("MaSo", "Vattu")
        End If
        Return result
    End Function
    ''' <summary>
    ''' Thu tuc tra ve TRUE neu vat tu da co phat sinh
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function VTCoDuLieu() As Boolean
        Dim result As Boolean = False
        Dim sql As String = String.Format("SELECT DISTINCT Count(MaSo) AS F1 FROM Chungtu WHERE MaVattu={0}", MaSo)
        result = ConvertToDblSafe(GetSelectValue(sql)) > 0
        If Not result Then
            sql = String.Format("SELECT DISTINCT Count(MaSo) AS F1 FROM DinhMuc WHERE MaNVL={0}", MaSo)
            result = ConvertToDblSafe(GetSelectValue(sql)) > 0
            If Not result Then
                sql = String.Format("SELECT DISTINCT Count(MaSo) AS F1 FROM Tonkho WHERE Mavattu={0} AND (tien_0<>0 OR luong_0<>0 OR tien_nhap_1<>0 OR luong_nhap_1<>0 OR tien_xuat_1<>0 OR luong_xuat_1<>0 OR tien_nhap_2<>0 OR luong_nhap_2<>0 OR tien_xuat_2<>0 OR luong_xuat_2<>0 OR tien_nhap_3<>0 OR luong_nhap_3<>0 OR tien_xuat_3<>0 OR luong_xuat_3<>0 OR tien_nhap_4<>0 OR luong_nhap_4<>0 OR tien_xuat_4<>0 OR luong_xuat_4<>0 OR tien_nhap_5<>0 OR luong_nhap_5<>0 OR tien_xuat_5<>0 OR luong_xuat_5<>0 OR tien_nhap_6<>0 OR luong_nhap_6<>0 OR tien_xuat_6<>0 OR luong_xuat_6<>0 OR tien_nhap_7<>0 OR luong_nhap_7<>0 OR tien_xuat_7<>0 OR luong_xuat_7<>0 OR tien_nhap_8<>0 OR luong_nhap_8<>0 OR tien_xuat_8<>0 OR luong_xuat_8<>0 OR tien_nhap_9<>0 OR luong_nhap_9<>0 OR tien_xuat_9<>0 OR luong_xuat_9<>0 OR tien_nhap_10<>0 OR luong_nhap_10<>0 OR tien_xuat_10<>0 OR luong_xuat_10<>0 OR tien_nhap_11<>0 OR luong_nhap_11<>0 OR tien_xuat_11<>0 OR luong_xuat_11<>0 OR tien_nhap_12<>0 OR luong_nhap_12<>0 OR tien_xuat_12<>0 OR luong_xuat_12<>0)", MaSo)
                result = ConvertToDblSafe(GetSelectValue(sql)) > 0
            End If
        End If
        Return result
    End Function
    ''' <summary>
    ''' Cap nhat thong tin ve vat tu
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SuaVT() As Integer
        Dim sql As String = String.Format("UPDATE Vattu SET MaPhanLoai={0},SoHieu=N'{1}',TenVattu=N'{2}',DonVi=N'{3}',TonMin={4},TonMax={5},GiaHT={6},Dvt2={7},DonVi2=N'{8}',TyLeQD={9},GhiChu=N'{10}',VAT={11},GiaBan1={12},GiaBan2={13},GiaBan3={14},CK={15},ThueNK={16} WHERE MaSo={17}", _
                                MaPhanLoai, _
                                sohieu, _
                                TenVattu, _
                                DonVi, _
                                CStr(TonMin), _
                                CStr(TonMax), _
                                CStr(RoundMoney(GiaHT)), _
                                ConvertToDblSafe(Dvt2), _
                                DonVi2, _
                                CStr(TyLeQD), _
                                GhiChu, _
                                ConvertToStrSafe(VAT), _
                                CStr(GiaBan1), _
                                CStr(GiaBan2), _
                                CStr(GiaBan3), _
                                CStr(CK), _
                                CStr(ThueNK), _
                                ConvertToStrSafe(MaSo))
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
    Public Function XoaVT() As Integer
        Dim sql As String = String.Empty
        If VTCoDuLieu() Then
            Return -1
        Else
            sql = String.Format("DELETE  FROM DVTVattu WHERE MaVattu={0}", MaSo)
            ExecSQLNonQuery(sql)
            sql = String.Format("DELETE FROM TonKho WHERE MaVattu={0} AND Luong_0=0 AND Tien_0=0 ", MaSo)
            For i As Integer = 1 To 12
                sql = String.Format("{0} AND Luong_Nhap_{1}=0 AND Tien_Nhap_{1}=0 ", sql, i)
            Next
            ExecSQLNonQuery(sql)
            If ExecSQLNonQuery(String.Format("DELETE FROM Vattu WHERE MaSo={0}", MaSo)) = 0 Then
                Return 0
            Else
                Return -1
            End If
        End If
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="m"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function XoaDVT(ByRef m As Integer) As Boolean
        Dim result As Boolean = False
        If ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaCT AS F1 FROM ChungTu WHERE MaVattu={0} AND DVT={1}", _
                                               MaSo, _
                                               m))) = 0 Then
            If ExecSQLNonQuery(String.Format("DELETE  FROM DVTVattu WHERE MaSo={0}", m)) = 0 Then
                result = True
            End If
        End If
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub KTraDVT2()
        Dim dv2 As Integer = ConvertToDblSafe(GetSelectValue(String.Format("SELECT Top 1 MaSo AS F1 FROM DVTVattu WHERE MaVattu={0}", MaSo)))
        ExecSQLNonQuery(String.Format("UPDATE Vattu SET Dvt2={0} WHERE MaSo={1}", _
                            (IIf(dv2 > 0, "1", "0")), _
                            MaSo))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sops"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SoChietKhau(ByRef sops As Double) As Double
        Return RoundMoney(sops * CK / 100)
    End Function
    Public Function LayVatTuTheoMaVatTu(ByVal mavt As Integer) As ClsVattu
        'Dim table As New DataTable
        Dim sql As String = "select MaSo,MaPhanLoai,SoHieu,TenVatTu,DonVi from VATTU where MaSo = " & mavt
        Dim table As DataTable = ExecSQLReturnDT(sql)
        Dim vt As New ClsVattu
        If table.Rows.Count > 0 Then
            vt.MaSo = table.Rows(0)("MaSo")
            vt.MaPhanLoai = table.Rows(0)("MaPhanLoai")
            vt.sohieu = table.Rows(0)("SoHieu").ToString()
            vt.TenVattu = table.Rows(0)("TenVatTu").ToString()
            vt.DonVi = table.Rows(0)("DonVi").ToString()
        End If
        Return vt
    End Function
End Class
