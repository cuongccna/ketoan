Imports System
Imports System.Data
Imports UNET.Utility
Imports UNET.DataAdapter

Friend Class CLsGiaVTKH
    ' Kieu vat tu
    Public MaSo As Integer ' Ma vat tu
    Public SoHieuVT As String = String.Empty ' So hieu vat tu
    Public TenVattu As String = String.Empty ' Ten vat tu
    Public DVT1 As Integer ' Don vi tinh
    Public DVT2 As String = String.Empty
    Public TL As String = String.Empty
    ''' <summary>
    ''' Thu tuc khoi tao object tu ma so vat tu
    ''' mvt:  Ma so vat tu can tham chieu
    '''       =0 neu vat tu moi
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub InitTPMaSo(ByRef mvt As Integer)
        Dim rs_vattu As DataTable

        MaSo = 0
        SoHieuVT = "'...'"
        TenVattu = "'...'"
        DVT1 = 0
        DVT2 = "'...'"
        TL = "'...'"
        If mvt > 0 Then
            rs_vattu = ExecSQLReturnDT(String.Format("SELECT * FROM Vattu WHERE MaSo={0}", mvt))
            If rs_vattu.Rows.Count > 0 Then
                Dim rs_vattuItem As DataRow = rs_vattu.Rows(0)
                If rs_vattuItem("MaSo") IsNot Nothing Then
                    MaSo = rs_vattuItem("MaSo")
                End If
                If rs_vattuItem("TenVattu") IsNot Nothing Then
                    TenVattu = rs_vattuItem("TenVattu")
                End If
                If rs_vattuItem("SoHieu") IsNot Nothing Then
                    SoHieuVT = rs_vattuItem("SoHieu")
                End If
                If rs_vattuItem("DVT2") IsNot Nothing Then
                    DVT1 = rs_vattuItem("DVT2")
                End If
                If rs_vattuItem("DonVi2") IsNot Nothing Then
                    DVT2 = rs_vattuItem("DonVi2")
                End If

                If rs_vattuItem("TyLeQD") IsNot Nothing Then
                    TL = ConvertToDblSafe(rs_vattuItem("TyLeQD"))
                End If

            End If
        End If
    End Sub
    ''' <summary>
    ''' Thu tuc khoi tao object tu so hieu vat tu
    ''' mvt:  So hieu vat tu can tham chieu
    ''' </summary>
    ''' <remarks></remarks>
    Public Function InitTPSohieu(ByRef shvt As String) As String
        Dim sql As String = String.Format("SELECT DISTINCT MaSo AS F1 FROM vattu WHERE Sohieu=N'{0}'", shvt)
        InitTPMaSo(ConvertToDblSafe(GetSelectValue(sql)))
        Return TenVattu
    End Function
    ''' <summary>
    ''' Thu tuc dang ky vat tu
    ''' </summary>
    ''' <remarks></remarks>
    Public Function GhiTP(ByRef giaban As Integer, ByRef SoHieu As String) As Integer
        Dim sql As String = String.Format("INSERT INTO giavtkh (MaSo,SoHieuKH,SoHieuVT,Giaban) VALUES ({0},N'{1}',N'{2}',{3})", _
                                Lng_MaxValue("MaSo", "giavtkh") + 1, _
                                kh, _
                                SoHieu, _
                                ConvertToStrSafe(giaban))
        If ExecSQLNonQuery(sql) <> 0 Then
            Return -1
        Else
            Return 0
        End If
    End Function
    ''' <summary>
    ''' Cap nhat thong tin ve vat tu
    ''' </summary>
    ''' <remarks></remarks>
    Public Function SuaTP(ByRef giaban As Integer, ByRef SoHieu As String) As Integer
        Dim sql As String = String.Format("UPDATE giavtkh SET giaban={0} WHERE sohieukh=N'{1}' AND sohieuvt=N'{2}'", _
                                giaban, _
                                kh, _
                                SoHieu)
        If ExecSQLNonQuery(sql) <> 0 Then
            Return -1
        Else
            Return 0
        End If
    End Function
    ''' <summary>
    ''' Thu tuc xoa mot vat tu
    ''' </summary>
    ''' <remarks></remarks>
    Public Function XoaTP(ByRef SoHieu As String) As Integer
        Dim result As Integer = 0
        result = -1
        If ExecSQLNonQuery(String.Format("DELETE FROM giavtkh WHERE sohieukh=N'{0}' AND sohieuvt=N'{1}'", _
                               kh, _
                               SoHieu)) = 0 Then
            result = 0
        End If
        Return result
    End Function
End Class
