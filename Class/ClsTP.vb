Imports System
Imports System.Data
Imports UNET.Utility
Imports UNET.DataAdapter


Friend Class ClsThanhPham
    Public maso As Integer
    Public MaCT As Integer
    Public sohieu As String = String.Empty
    Public thang As Integer
    Public ngay As Date
    Public MaKhoTP As Integer
    Public MaKhoNVL As Integer
    Public MaTK As Integer
    Public MaTP As Integer
    Public soluong As Double
    Public MaTKCP As Integer
    Public MaTKNC As Integer
    Public MaTKSX As Integer
    Public MaTKKH As Integer

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Init()
        MaCT = 0
        sohieu = "."
        thang = 0
        ngay = DateTime.Today
        MaKhoTP = 0
        MaKhoNVL = 0
        MaTK = 0
        MaTP = 0
        soluong = 0
        MaTKCP = 0
        MaTKNC = 0
        MaTKSX = 0
        MaTKKH = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ms"></param>
    ''' <remarks></remarks>
    Public Sub InitTPMaSo(ByRef ms As Integer)
        Dim rs As DataTable
        Init()
        If ms > 0 Then
            rs = ExecSQLReturnDT(String.Format("SELECT DISTINCT * FROM ThanhPham WHERE MaSo={0}", ms))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                Try
                    If rsItem("MaCT") IsNot Nothing Then
                        MaCT = rsItem("MaCT")
                    End If

                    If rsItem("sohieu") IsNot Nothing Then
                        sohieu = rsItem("sohieu")
                    End If

                    If rsItem("thang") IsNot Nothing Then
                        thang = rsItem("thang")
                    End If

                    If rsItem("ngay") IsNot Nothing Then
                        ngay = rsItem("ngay")
                    End If

                    If rsItem("MaKhoTP") IsNot Nothing Then
                        MaKhoTP = rsItem("MaKhoTP")
                    End If

                    If rsItem("MaKhoNVL") IsNot Nothing Then
                        MaKhoNVL = rsItem("MaKhoNVL")
                    End If

                    If rsItem("MaTK") IsNot Nothing Then
                        MaTK = rsItem("MaTK")
                    End If

                    If rsItem("MaTP") IsNot Nothing Then
                        MaTP = rsItem("MaTP")
                    End If

                    If rsItem("soluong") IsNot Nothing Then
                        soluong = rsItem("soluong")
                    End If

                    If rsItem("MaTKCP") IsNot Nothing Then
                        MaTKCP = rsItem("MaTKCP")
                    End If

                    If rsItem("MaTKNC") IsNot Nothing Then
                        MaTKNC = rsItem("MaTKNC")
                    End If

                    If rsItem("MaTKSX") IsNot Nothing Then
                        MaTKSX = rsItem("MaTKSX")
                    End If

                    If rsItem("MaTKKH") IsNot Nothing Then
                        MaTKKH = rsItem("MaTKKH")
                    End If

                Catch ex As Exception

                End Try
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SaveTP() As Integer
        Dim result As Integer = 0
        result = ExecSQLNonQuery(String.Format("INSERT INTO ThanhPham (MaSo,MaCT,Thang,Ngay,SoHieu,MaKhoTP,MaKhoNVL,MaTK,MaTP,SoLuong,MaTKCP,MaTKNC,MaTKSX,MaTKKH) VALUES ({0},{1},{2}, N'{3}', N'{4}',{5},{6},{7},{8},{9},{10},{11},{12},{13})", _
                                     Lng_MaxValue("MaSo", "ThanhPham") + 1, _
                                     (MaCT), _
                                     (thang), _
                                     Format(CDate(ngay), Mask_DB), _
                                     sohieu, _
                                     (MaKhoTP), _
                                     (MaKhoNVL), _
                                     (MaTK), _
                                     (MaTP), _
                                     CStr(soluong), _
                                     (MaTKCP), _
                                     (MaTKNC), _
                                     (MaTKSX), _
                                     (MaTKKH)))
        maso = Lng_MaxValue("MaSo", "ThanhPham")
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DeleteTP() As Integer
        Return ExecSQLNonQuery(String.Format("DELETE  FROM ThanhPham WHERE MaSo={0}", maso))
    End Function
End Class
