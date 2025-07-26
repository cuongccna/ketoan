Imports System
Imports UNET.Utility
Imports UNET.DataAdapter


Friend Class ClsChucDanh
    Public maso As Integer
    Public chucvu As Integer
    Public Nhanvien As String = String.Empty
    Public BacLuong As Integer
    Public LoaiLuong As Integer
    Public NgayApdung As Date
    Public thang As Integer
    Public thang13 As Integer
    Public Nam As Integer

    Public Sub New()
        Call Init()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Init()
        maso = 0
        chucvu = 0
        Nhanvien = "..."
        BacLuong = 0
        LoaiLuong = 0
        thang = 0
        thang13 = 0
        Nam = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GhiNV() As Integer
        Dim kq As Integer = ExecSQLNonQuery(String.Format("INSERT INTO Chucdanh (NgayApdung,LoaiLuong,MaSo,ChucVu,Nhanvien,BacLuong,thang,thang13,nam,soplhd)  VALUES (N'{0}',{1},{2},{3},N'{4}',{5},{6},{7},{8},{9})", _
                                           Format(NgayApdung, Mask_DB), _
                                            ConvertToStrSafe(LoaiLuong), _
                                            ConvertToStrSafe(Lng_MaxValue("MaSo", "chucdanh") + 1), _
                                            ConvertToStrSafe(chucvu), _
                                            Nhanvien, _
                                            ConvertToStrSafe(BacLuong), _
                                            ConvertToStrSafe(thang), _
                                            ConvertToStrSafe(thang13), _
                                            ConvertToStrSafe(Nam), _
                                            ConvertToStrSafe(Lng_MaxValue("SoPLHD", "chucdanh") + 1)))
        If kq = 0 Then maso = Lng_MaxValue("MaSo", "Chucdanh")
        Return kq
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SuaNV() As Integer
        Return ExecSQLNonQuery(String.Format("UPDATE Chucdanh SET thang={0},thang13={1},nam={2},Bacluong={3},Chucvu={4},Nhanvien=N'{5}',ngayapdung='{6}',loailuong={7} WHERE MaSo={8}", _
                               thang, _
                               ConvertToStrSafe(thang13), _
                               ConvertToStrSafe(Nam), _
                               ConvertToStrSafe(BacLuong), _
                               ConvertToStrSafe(chucvu), _
                               Nhanvien, _
                               Format(NgayApdung, Mask_DB), _
                               ConvertToStrSafe(LoaiLuong), _
                               ConvertToStrSafe(maso)))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function XoaNV() As Integer
        If ConvertToDblSafe(GetSelectValue(String.Format("SELECT TOP 1 Maso AS F1 FROM chamcong WHERE manhanvien= N'{0}' AND thang>={1}", _
                              Nhanvien, _
                              ConvertToStrSafe(thang)))) = 0 Then
            Return ExecSQLNonQuery(String.Format("DELETE  FROM chucdanh WHERE MaSo={0}", maso))
        Else
            Return -1
        End If
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ms"></param>
    ''' <remarks></remarks>
    Public Sub InitMaSo(ByVal ms As Integer)
        Dim rs As DataTable
        If ms > 0 Then
            rs = ExecSQLReturnDT(String.Format("SELECT * FROM Chucdanh WHERE MaSo={0}", ms))
            If rs.Rows.Count = 0 Then
                Init()
            Else
                Try
                    Dim rsItem As DataRow = rs.Rows(0)
                    maso = rsItem("maso")
                    chucvu = rsItem("chucvu")
                    Nhanvien = rsItem("Nhanvien")
                    LoaiLuong = rsItem("LoaiLuong")
                    BacLuong = rsItem("BacLuong")
                    NgayApdung = ConvertToDateSafe(rsItem("NgayApdung"))
                    thang = rsItem("thang")
                    thang13 = rsItem("thang13")
                    Nam = rsItem("Nam")
                Catch ex As Exception
                End Try
            End If
            rs = Nothing
        Else
            Init()
        End If
    End Sub
End Class