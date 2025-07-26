Imports System
Imports System.Data
Imports UNET.Utility
Imports UNET.DataAdapter


Friend Class ClsPhucap
    Public maso As Integer
    Public MaPhanLoai As Integer
    Public MaChucvu As Integer
    Public Sohieunhanvien As String = String.Empty
    Public thang As Integer
    Public chucvu As Double
    Public Trachnhiem As Double
    Public Luudong As Double
    Public loai As Integer
    Public Khac1 As Double
    Public Ghichu1 As String = String.Empty
    Public Khac2 As Double
    Public Ghichu2 As String = String.Empty
    Public Khac3 As Double
    Public Ghichu3 As String = String.Empty
    Public Khac4 As Double
    Public Ghichu4 As String = String.Empty
    Public Khac5 As Double
    Public Ghichu5 As String = String.Empty
    Public Tamung As Double
    Public Trukhac As Double
    Public Trukhac1 As Double
    Public Trukhac2 As Double

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        MyBase.New()
        init()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub init()
        MaPhanLoai = 0
        MaChucvu = 0
        Sohieunhanvien = "0"
        thang = 0
        chucvu = 0
        Trachnhiem = 0
        Luudong = 0
        loai = 0
        Khac1 = 0
        Ghichu1 = String.Empty
        Khac2 = 0
        Ghichu2 = String.Empty
        Khac3 = 0
        Ghichu3 = String.Empty
        Khac4 = 0
        Ghichu4 = String.Empty
        Khac5 = 0
        Ghichu5 = String.Empty
        Tamung = 0
        Trukhac = 0
        Trukhac1 = 0
        Trukhac2 = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GhiNV() As Integer
        Dim kq As Integer, sql As String
        Try
            If thang >= DateTime.Now.Month Then
                For i As Integer = thang To 12
                    sql = String.Format("INSERT INTO Phucap (MaSo, MaPhanLoai, Machucvu, Sohieunhanvien, Thang, Chucvu, Trachnhiem, Luudong, Loai, Khac1, Ghichu1, Khac2, Ghichu2,Khac3, Ghichu3, Khac4,Ghichu4,Khac5, Ghichu5,tamung,trukhac,trukhac1,trukhac2)  VALUES ({0},{1},{2}, N'{3}',{4},{5},{6},{7},{8},{9}, N'{10}',{11}, N'{12}',{13}, N'{14}',{15}, N'{16}',{17}, N'{18}',{19},{20},{21},{22})", _
                                             Lng_MaxValue("MaSo", "Phucap") + 1, _
                                             ConvertToStrSafe(MaPhanLoai), _
                                             ConvertToStrSafe(MaChucvu), _
                                             Sohieunhanvien, _
                                             ConvertToStrSafe(i), _
                                             ConvertToStrSafe(chucvu), _
                                             ConvertToStrSafe(Trachnhiem), _
                                             ConvertToStrSafe(Luudong), _
                                             ConvertToStrSafe(loai), _
                                             ConvertToStrSafe(Khac1), _
                                             Ghichu1, _
                                             ConvertToStrSafe(Khac2), _
                                             Ghichu2, _
                                             ConvertToStrSafe(Khac3), _
                                             Ghichu3, _
                                             ConvertToStrSafe(Khac4), _
                                             Ghichu4, _
                                             ConvertToStrSafe(Khac5), _
                                             Ghichu5, _
                                             ConvertToStrSafe(Tamung), _
                                             ConvertToStrSafe(Trukhac), _
                                             ConvertToStrSafe(Trukhac1), _
                                             ConvertToStrSafe(Trukhac2))
                    kq = ExecSQLNonQuery(sql)
                    If kq = 0 Then
                        maso = Lng_MaxValue("MaSo", "Phucap")
                    Else
                        Exit For
                    End If
                Next
            Else
                kq = ExecSQLNonQuery(String.Format("INSERT INTO Phucap (MaSo, MaPhanLoai, Machucvu, Sohieunhanvien, Thang, Chucvu, Trachnhiem, Luudong, Loai, Khac1, Ghichu1, Khac2, Ghichu2,Khac3, Ghichu3, Khac4,Ghichu4,Khac5, Ghichu5,tamung,trukhac,trukhac1,trukhac2)  VALUES ({0},{1},{2}, N'{3}',{4},{5},{6},{7},{8},{9}, N'{10}',{11}, N'{12}',{13}, N'{14}',{15}, N'{16}',{17}, N'{18}',{19},{20},{21},{22})", _
                                         Lng_MaxValue("MaSo", "Phucap") + 1, _
                                         ConvertToStrSafe(MaPhanLoai), _
                                         ConvertToStrSafe(MaChucvu), _
                                         Sohieunhanvien, _
                                         ConvertToStrSafe(thang), _
                                         ConvertToStrSafe(chucvu), _
                                         ConvertToStrSafe(Trachnhiem), _
                                         ConvertToStrSafe(Luudong), _
                                         ConvertToStrSafe(loai), _
                                         ConvertToStrSafe(Khac1), _
                                         Ghichu1, _
                                         ConvertToStrSafe(Khac2), _
                                         Ghichu2, _
                                         ConvertToStrSafe(Khac3), _
                                         Ghichu3, _
                                         ConvertToStrSafe(Khac4), _
                                         Ghichu4, _
                                         ConvertToStrSafe(Khac5), _
                                         Ghichu5, _
                                         ConvertToStrSafe(Tamung), _
                                         ConvertToStrSafe(Trukhac), _
                                         ConvertToStrSafe(Trukhac1), _
                                         ConvertToStrSafe(Trukhac2)))
                If kq = 0 Then maso = Lng_MaxValue("MaSo", "Phucap")
            End If
        Catch
        End Try
        Return kq
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SuaNV() As Integer
        If thang >= DateTime.Now.Month Then
            Return ExecSQLNonQuery(String.Format("UPDATE Phucap SET trukhac2={0}, trukhac1={1}, tamung={2}, trukhac={3}, Machucvu={4},MaPhanLoai={5},chucvu={6},trachnhiem={7},luudong={8},loai={9},khac1={10},ghichu1=N'{11}',khac2={12},ghichu2=N'{13}',khac3={14},ghichu3=N'{15}',khac4={16},ghichu4=N'{17}',khac5={18},ghichu5=N'{19}' WHERE thang>={20} AND sohieunhanvien=N'{21}'", _
                                       Trukhac2, _
                                       ConvertToStrSafe(Trukhac1), _
                                       ConvertToStrSafe(Tamung), _
                                       ConvertToStrSafe(Trukhac), _
                                       ConvertToStrSafe(MaChucvu), _
                                       ConvertToStrSafe(MaPhanLoai), _
                                       ConvertToStrSafe(chucvu), _
                                       ConvertToStrSafe(Trachnhiem), _
                                       ConvertToStrSafe(Luudong), _
                                       ConvertToStrSafe(loai), _
                                       ConvertToStrSafe(Khac1), _
                                       Ghichu1, _
                                       ConvertToStrSafe(Khac2), _
                                       Ghichu2, _
                                       ConvertToStrSafe(Khac3), _
                                       Ghichu3, _
                                       ConvertToStrSafe(Khac4), _
                                       Ghichu4, _
                                       ConvertToStrSafe(Khac5), _
                                       Ghichu5, _
                                       ConvertToStrSafe(thang), _
                                       Sohieunhanvien))
        Else
            Return ExecSQLNonQuery(String.Format("UPDATE Phucap SET trukhac2={0}, trukhac1={1}, tamung={2}, trukhac={3}, Machucvu={4},MaPhanLoai={5},chucvu={6},trachnhiem={7},luudong={8},loai={9},khac1={10},ghichu1=N'{11}',khac2={12},ghichu2=N'{13}',khac3={14},ghichu3=N'{15}',khac4={16},ghichu4=N'{17}',khac5={18},ghichu5=N'{19}' WHERE thang={20} AND sohieunhanvien=N'{21}'", _
                                       Trukhac2, _
                                       ConvertToStrSafe(Trukhac1), _
                                       ConvertToStrSafe(Tamung), _
                                       ConvertToStrSafe(Trukhac), _
                                       ConvertToStrSafe(MaChucvu), _
                                       ConvertToStrSafe(MaPhanLoai), _
                                       ConvertToStrSafe(chucvu), _
                                       ConvertToStrSafe(Trachnhiem), _
                                       ConvertToStrSafe(Luudong), _
                                       ConvertToStrSafe(loai), _
                                       ConvertToStrSafe(Khac1), _
                                       Ghichu1, _
                                       ConvertToStrSafe(Khac2), _
                                       Ghichu2, _
                                       ConvertToStrSafe(Khac3), _
                                       Ghichu3, _
                                       ConvertToStrSafe(Khac4), _
                                       Ghichu4, _
                                       ConvertToStrSafe(Khac5), _
                                       Ghichu5, _
                                       ConvertToStrSafe(thang), _
                                       Sohieunhanvien))
        End If
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function XoaNV() As Integer
        If thang >= DateTime.Now.Month Then
            Return ExecSQLNonQuery(String.Format("DELETE  FROM Phucap WHERE thang>={0} AND sohieunhanvien=N'{1}'", _
                                       thang, _
                                       Sohieunhanvien))
        Else
            Return ExecSQLNonQuery(String.Format("DELETE  FROM Phucap WHERE thang={0} AND sohieunhanvien=N'{1}'", _
                                       thang, _
                                       Sohieunhanvien))
        End If
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ms"></param>
    ''' <remarks></remarks>
    Public Sub InitNVMaSo(ByRef ms As Integer)
        Dim rs As DataTable
        init()
        If ms > 0 Then
            rs = ExecSQLReturnDT(String.Format("SELECT * FROM Phucap WHERE MaSo={0}", ms))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                Try

                    If rsItem("maso") IsNot Nothing Then
                        maso = rsItem("maso")
                    End If

                    If rsItem("MaPhanLoai") IsNot Nothing Then
                        MaPhanLoai = rsItem("MaPhanLoai")
                    End If

                    If rsItem("MaChucvu") IsNot Nothing Then
                        MaChucvu = rsItem("MaChucvu")
                    End If

                    If rsItem("Sohieunhanvien") IsNot Nothing Then
                        Sohieunhanvien = rsItem("Sohieunhanvien")
                    End If

                    If rsItem("thang") IsNot Nothing Then
                        thang = rsItem("thang")
                    End If

                    If rsItem("chucvu") IsNot Nothing Then
                        chucvu = rsItem("chucvu")
                    End If

                    If rsItem("Trachnhiem") IsNot Nothing Then
                        Trachnhiem = rsItem("Trachnhiem")
                    End If

                    If rsItem("Luudong") IsNot Nothing Then
                        Luudong = rsItem("Luudong")
                    End If

                    If rsItem("loai") IsNot Nothing Then
                        loai = rsItem("loai")
                    End If

                    If rsItem("Khac1") IsNot Nothing Then
                        Khac1 = rsItem("Khac1")
                    End If

                    If rsItem("GhiChu1") IsNot Nothing Then
                        Ghichu1 = rsItem("Ghichu1")
                    End If

                    If rsItem("Khac2") IsNot Nothing Then
                        Khac2 = rsItem("Khac2")
                    End If

                    If rsItem("GhiChu2") IsNot Nothing Then
                        Ghichu2 = rsItem("Ghichu2")
                    End If

                    If rsItem("Khac3") IsNot Nothing Then
                        Khac3 = rsItem("Khac3")
                    End If

                    If rsItem("GhiChu3") IsNot Nothing Then
                        Ghichu3 = rsItem("Ghichu3")
                    End If

                    If rsItem("Khac4") IsNot Nothing Then
                        Khac4 = rsItem("Khac4")
                    End If

                    If rsItem("Ghichu4") IsNot Nothing Then
                        Ghichu4 = rsItem("Ghichu4")
                    End If

                    If rsItem("Khac5") IsNot Nothing Then
                        Khac5 = rsItem("Khac5")
                    End If

                    If rsItem("GhiChu5") IsNot Nothing Then
                        Ghichu5 = rsItem("Ghichu5")
                    End If

                    If rsItem("Tamung") IsNot Nothing Then
                        Tamung = rsItem("Tamung")
                    End If

                    If rsItem("Trukhac") IsNot Nothing Then
                        Trukhac = rsItem("Trukhac")
                    End If

                    If rsItem("Trukhac1") IsNot Nothing Then
                        Trukhac1 = rsItem("Trukhac1")
                    End If

                    If rsItem("Trukhac2") IsNot Nothing Then
                        Trukhac2 = rsItem("Trukhac2")
                    End If
                Catch
                End Try
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ms"></param>
    ''' <remarks></remarks>
    Public Sub InitNVMaSo1(ByRef ms As Integer)
        Dim rs As DataTable
        init()
        If ms > 0 Then
            rs = ExecSQLReturnDT(String.Format("SELECT * FROM Phucap WHERE MaSo={0}", ms))
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                Try
                    If rsItem("maso") IsNot Nothing Then
                        maso = rsItem("maso")
                    End If

                    If rsItem("MaPhanLoai") IsNot Nothing Then
                        MaPhanLoai = rsItem("MaPhanLoai")
                    End If

                    If rsItem("MaChucvu") IsNot Nothing Then
                        MaChucvu = rsItem("MaChucvu")
                    End If

                    If rsItem("Sohieunhanvien") IsNot Nothing Then
                        Sohieunhanvien = rsItem("Sohieunhanvien")
                    End If

                    If rsItem("thang") IsNot Nothing Then
                        thang = rsItem("thang")
                    End If

                    If rsItem("chucvu") IsNot Nothing Then
                        chucvu = rsItem("chucvu")
                    End If

                    If rsItem("Trachnhiem") IsNot Nothing Then
                        Trachnhiem = rsItem("Trachnhiem")
                    End If

                    If rsItem("Luudong") IsNot Nothing Then
                        Luudong = rsItem("Luudong")
                    End If

                    If rsItem("loai") IsNot Nothing Then
                        loai = rsItem("loai")
                    End If

                    If rsItem("Khac1") IsNot Nothing Then
                        Khac1 = rsItem("Khac1")
                    End If

                    If rsItem("GhiChu1") IsNot Nothing Then
                        Ghichu1 = rsItem("Ghichu1")
                    End If

                    If rsItem("Khac2") IsNot Nothing Then
                        Khac2 = rsItem("Khac2")
                    End If

                    If rsItem("GhiChu2") IsNot Nothing Then
                        Ghichu2 = rsItem("Ghichu2")
                    End If

                    If rsItem("Khac3") IsNot Nothing Then
                        Khac3 = rsItem("Khac3")
                    End If

                    If rsItem("GhiChu3") IsNot Nothing Then
                        Ghichu3 = rsItem("Ghichu3")
                    End If

                    If rsItem("Khac4") IsNot Nothing Then
                        Khac4 = rsItem("Khac4")
                    End If

                    If rsItem("Ghichu4") IsNot Nothing Then
                        Ghichu4 = rsItem("Ghichu4")
                    End If

                    If rsItem("Khac5") IsNot Nothing Then
                        Khac5 = rsItem("Khac5")
                    End If

                    If rsItem("GhiChu5") IsNot Nothing Then
                        Ghichu5 = rsItem("Ghichu5")
                    End If

                    If rsItem("Tamung") IsNot Nothing Then
                        Tamung = rsItem("Tamung")
                    End If

                    If rsItem("Trukhac") IsNot Nothing Then
                        Trukhac = rsItem("Trukhac")
                    End If

                    If rsItem("Trukhac1") IsNot Nothing Then
                        Trukhac1 = rsItem("Trukhac1")
                    End If

                    If rsItem("Trukhac2") IsNot Nothing Then
                        Trukhac2 = rsItem("Trukhac2")
                    End If
                Catch
                End Try
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="loai"></param>
    ''' <param name="sh"></param>
    ''' <param name="thang"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InitNVSoHieuNhanvien(ByVal loai As String, ByVal sh As String, Optional ByVal thang As Integer = 0) As Integer
        Dim ms As Integer = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM Phucap WHERE maphanloai={0} AND Sohieunhanvien=N'{1}'{2}", _
                                                                loai, _
                                                                sh, _
                                                                (IIf(thang <> 0, String.Format(" AND thang={0}", thang), String.Empty)))))
        If ms > 0 Then
            InitNVMaSo(ms)
        Else
            init()
        End If

        Return ms
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sh"></param>
    ''' <param name="thang"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InitNVSoHieuNhanvien1(ByRef sh As String, Optional ByRef thang As Integer = 0) As Integer
        Dim ms As Integer = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM Quanlynhanvien WHERE Sohieu=N'{0}'{1}", _
                                                                sh, _
                                                                (IIf(thang <> 0, String.Format(" AND thang={0}", thang), String.Empty)))))
        If ms > 0 Then
            InitNVMaSo1(ms)
        Else
            init()
        End If

        Return ms
    End Function
End Class
