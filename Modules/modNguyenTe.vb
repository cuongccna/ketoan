Imports System
Imports UNET.Utility
Imports UNET.DataAdapter



Module modNguyenTe
    ''' <summary>
    ''' Hàm trả về giá trị VND từ lượng nguyên tệ theo tỷ giá mặc định
    ''' </summary>
    ''' <param name="mnt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TyGiaNT(ByRef mnt As Integer) As Double
        Dim sql As String = String.Empty

        If mnt < 0 Then
            Return 0
        Else
            If mnt = 0 Then
                sql = "SELECT TyGia AS F1 FROM NguyenTe WHERE KyHieu = 'USD'"

                Return ConvertToDblSafe(GetSelectValue(sql))
            Else
                sql = String.Format("SELECT TyGia AS F1 FROM NguyenTe WHERE MaSo = {0}", mnt)
                Return ConvertToDblSafe(GetSelectValue(sql))
            End If
        End If
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mnt"></param>
    ''' <param name="tygia"></param>
    ''' <remarks></remarks>
    Public Sub CapNhatTyGia(ByRef mnt As Integer, ByRef tygia As Double)
        If tygia <> 0 Then ExecSQLNonQuery(String.Format("UPDATE NguyenTe SET TyGia = {0} WHERE MaSo = {1}", _
                                               CStr(tygia), _
                                               ConvertToStrSafe(mnt)))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="shtk"></param>
    ''' <param name="mnt"></param>
    ''' <param name="ngay"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TyGiaBQ(ByRef shtk As String, ByRef mnt As Integer, ByRef ngay As Date) As Double
        Dim result As Double = 0
        Dim duco, duno, dunt As Double
        Dim mtk As Integer = ConvertToDblSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM HethongTK WHERE SoHieu=N'{0}' AND MaNT={1}", _
                                                                 shtk, _
                                                                 mnt)))
        If mtk > 0 Then
            SoDuTKNgay(mtk, ngay, duno, duco, dunt)
            If dunt <> 0 Then result = Math.Abs((duno - duco) / dunt)
        End If
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TyGiaDK() As Double
        Return ConvertToDblSafe(GetSelectValue("SELECT TyGia AS F1 FROM License"))
    End Function
End Module
