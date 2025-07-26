Imports System
Imports System.Data
Imports UNET.Utility
Imports UNET.DataAdapter


Friend Class ClsNhanVien
    Public MaSo As Integer
    Public MaPhanLoai As Integer
    Public SoHieu As String = String.Empty
    Public Ten As String = String.Empty
    Public DiaChi As String = String.Empty
    Public NgaySinh As Date
    Public CMND As String = String.Empty
    Public Tel1 As String = String.Empty
    Public Tel2 As String = String.Empty
    Public email As String = String.Empty
    Public taikhoan As String = String.Empty
    Public GhiChu As String = String.Empty

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        MyBase.New()
        Init()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Init()
        MaPhanLoai = 0
        SoHieu = "..."
        Ten = "..."
        DiaChi = "..."
        CMND = "..."
        Tel1 = "..."
        Tel2 = "..."
        email = "..."
        taikhoan = "..."
        GhiChu = "..."
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GhiNV() As Integer
        Dim kq As Integer = ExecSQLNonQuery(String.Format("INSERT INTO NhanVien (MaSo, MaPhanLoai, SoHieu, Ten, DiaChi, NgaySinh, CMND, Tel1, Tel2, EMail, TaiKhoan, GhiChu)  VALUES ({0},{1}, N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}', N'{10}', N'{11}')", _
                                                Lng_MaxValue("MaSo", "NhanVien") + 1, _
                                                ConvertToStrSafe(MaPhanLoai), _
                                                SoHieu, _
                                                Ten, _
                                                DiaChi, _
                                                Format(NgaySinh, Mask_DB), _
                                                CMND, _
                                                Tel1, _
                                                Tel2, _
                                                email, _
                                                taikhoan, _
                                                GhiChu))
        If kq = 0 Then MaSo = Lng_MaxValue("MaSo", "NhanVien")
        Return kq
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SuaNV() As Integer
        Return ExecSQLNonQuery(String.Format("UPDATE NhanVien SET MaPhanLoai={0},SoHieu=N'{1}',Ten=N'{2}',DiaChi=N'{3}',NgaySinh=N'{4}',CMND=N'{5}',Tel1=N'{6}',Tel2=N'{7}',EMail=N'{8}',TaiKhoan=N'{9}',GhiChu=N'{10}' WHERE MaSo={11}", MaPhanLoai, SoHieu, Ten, DiaChi, Format(NgaySinh, Mask_DB), CMND, Tel1, Tel2, email, taikhoan, GhiChu, ConvertToStrSafe(MaSo)))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function XoaNV() As Integer
        If ConvertToDblSafe(GetSelectValue("SELECT TOP 1 MaNV AS F1 FROM ChungTu WHERE MaNV>0")) = 0 Then
            Return ExecSQLNonQuery(String.Format("DELETE  FROM NhanVien WHERE MaSo={0}", MaSo))
        Else
            Return -1
        End If
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ms"></param>
    ''' <remarks></remarks>
    Public Sub InitNVMaSo(ByRef ms As Integer)
        Dim rs As DataTable
        Init()
        If ms > 0 Then
            rs = ExecSQLReturnDT(String.Format("SELECT * FROM NhanVien WHERE MaSo={0}", ms))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                Try
                    If rsItem("MaSo") IsNot Nothing Then
                        MaSo = rsItem("MaSo")
                    End If

                    If rsItem("MaPhanLoai") IsNot Nothing Then
                        MaPhanLoai = rsItem("MaPhanLoai")
                    End If

                    If rsItem("SoHieu") IsNot Nothing Then
                        SoHieu = rsItem("SoHieu")
                    End If

                    If rsItem("Ten") IsNot Nothing Then
                        Ten = rsItem("Ten")
                    End If

                    If rsItem("DiaChi") IsNot Nothing Then
                        DiaChi = rsItem("DiaChi")
                    End If

                    If rsItem("NgaySinh") IsNot Nothing Then
                        NgaySinh = rsItem("NgaySinh")
                    End If

                    If rsItem("CMND") IsNot Nothing Then
                        CMND = rsItem("CMND")
                    End If

                    If rsItem("Tel1") IsNot Nothing Then
                        Tel1 = rsItem("Tel1")
                    End If

                    If rsItem("Tel2") IsNot Nothing Then
                        Tel2 = rsItem("Tel2")
                    End If

                    If rsItem("email") IsNot Nothing Then
                        email = rsItem("email")
                    End If

                    If rsItem("taikhoan") IsNot Nothing Then
                        taikhoan = rsItem("taikhoan")
                    End If

                    If rsItem("GhiChu") IsNot Nothing Then
                        GhiChu = rsItem("GhiChu")
                    End If
                Catch
                End Try
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InitNVSoHieu(ByRef sh As String) As Integer
        Dim ms As Integer = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM NhanVien WHERE SoHieu=N'{0}'", sh)))
        If ms > 0 Then InitNVMaSo(ms)
        Return ms
    End Function
End Class
