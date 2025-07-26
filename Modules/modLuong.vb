Imports System
Imports System.Text
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Module ModLuong
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="source"></param>
    ''' <param name="sDelim"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Join(ByRef source() As String, Optional ByRef sDelim As String = " ") As String
        Dim sOut As New StringBuilder
        Dim iC As Integer
        Try
            For iC = source.GetLowerBound(0) To source.GetUpperBound(0) - 1
                sOut.Append(source(iC) & sDelim)
            Next
            sOut.Append(source(iC))
            Return sOut.ToString()

        Catch
            Throw New System.Exception(Information.Err().Number.ToString())
        End Try
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sIn"></param>
    ''' <param name="sDelim"></param>
    ''' <param name="nLimit"></param>
    ''' <param name="bCompare"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Split(ByVal sIn As String, Optional ByRef sDelim As String = "", Optional ByRef nLimit As Integer = -1, Optional ByRef bCompare As CompareMethod = CompareMethod.Binary) As Object
        Dim result As Object = Nothing
        Dim sOut() As String
        Dim nC As Integer
        If sDelim = "" Then
            result = sIn
        End If
        Dim sRead As String = ReadUntil(sIn, sDelim, bCompare)
        Do
            ReDim Preserve sOut(nC)
            sOut(nC) = sRead
            nC += 1
            If nLimit <> -1 And nC >= nLimit Then Exit Do
            sRead = ReadUntil(sIn, sDelim)
        Loop While sRead <> ""
        ReDim Preserve sOut(nC)
        sOut(nC) = sIn
        Return sOut
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sIn"></param>
    ''' <param name="sDelim"></param>
    ''' <param name="bCompare"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ReadUntil(ByRef sIn As String, ByRef sDelim As String, Optional ByRef bCompare As CompareMethod = CompareMethod.Binary) As String
        Dim result As String = String.Empty
        Dim nPos As String = ConvertToStrSafe(Strings.InStr(1, sIn, sDelim, bCompare))
        If ConvertToDblSafe(nPos) > 0 Then
            result = Strings.Left(sIn, ConvertToDblSafe(ConvertToDblSafe(nPos) - 1))
            sIn = Strings.Mid(sIn, ConvertToDblSafe(nPos) + sDelim.Length)
        End If
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sIn"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function StrReverse(ByVal sIn As String) As String
        Return sIn.Reverse
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sIn"></param>
    ''' <param name="sFind"></param>
    ''' <param name="sReplace"></param>
    ''' <param name="nStart"></param>
    ''' <param name="nCount"></param>
    ''' <param name="bCompare"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Replace(ByRef sIn As String, ByRef sFind As String, ByRef sReplace As String, Optional ByRef nStart As Integer = 1, Optional ByRef nCount As Integer = -1, Optional ByRef bCompare As CompareMethod = CompareMethod.Binary) As String
        Dim nC As Integer
        Dim sOut As String = sIn
        Dim nPos As Integer = Strings.InStr(nStart, sOut, sFind, bCompare)
        If Not (nPos = 0) Then
            Do
                nC += 1
                sOut = Strings.Left(sOut, nPos - 1) & sReplace & _
                       Strings.Mid(sOut, nPos + sFind.Length)
                If nCount <> -1 And nC >= nCount Then Exit Do
                nPos = Strings.InStr(nStart, sOut, sFind, bCompare)
            Loop While nPos > 0
        End If
        Return sOut
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="MaCTChon"></param>
    ''' <remarks></remarks>
    Public Sub UpdateCPNVLTT(ByRef MaCTChon As Integer)
        Dim rs, rs1 As DataTable
        Dim sql As String = String.Empty
        Dim Chungtutong As New ClsChungtu
        Try
            sql = String.Format("SELECT * FROM chungtu WHERE mact={0} AND sohieu LIKE'CPNVLTT%'", MaCTChon)
            rs = ExecSQLReturnDT(sql)
            Dim i As Integer = 0
            For i = 0 To rs.Rows.Count - 1
                Dim rsItem As DataRow = rs.Rows(i)
                Chungtutong.InitChungtu(ConvertToDblSafe(rsItem("MaSo")), _
                    0, _
                    String.Empty, _
                    0, _
                    DateTime.Today, _
                    DateTime.Today, _
                    0, _
                    0, _
                    String.Empty, _
                    0, _
                    0, _
                    0, _
                    0, _
                    0, _
                    0, _
                    String.Empty, _
                    0, DateTime.Today)
                sql = String.Format("SELECT * FROM chungtu WHERE mact={0} AND sohieu LIKE'CPNVLTT%' AND mavattu={1} AND maso<>{2}", _
                          MaCTChon, _
                          rsItem("MaVattu"), _
                          rsItem("MaSo"))
                rs1 = ExecSQLReturnDT(sql)
                For Each rs1Item As DataRow In rs1.Rows
                    Chungtutong.sops += ConvertToDblSafe(rs1Item("sops"))
                    Chungtutong.SoPS2Co += ConvertToDblSafe(rs1Item("SoPS2Co"))
                Next
                If rs1.Rows.Count > 0 Then
                    ExecSQLNonQuery(String.Format("DELETE FROM chungtu WHERE mact={0} AND sohieu LIKE'CPNVLTT%' AND mavattu={1}", _
                                        MaCTChon, _
                                        rsItem("MaVattu")))
                    Chungtutong.GhiChungtu()
                    sql = String.Format("SELECT * FROM chungtu WHERE mact={0} AND sohieu LIKE'CPNVLTT%'", MaCTChon)
                    rs = ExecSQLReturnDT(sql)
                End If
                If i >= rs.Rows.Count Then
                    Exit For
                End If
                If rs1.Rows.Count > 0 And i < (rs.Rows.Count - 1) Then
                    i = 0
                End If
            Next
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Lich"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DayofMonth(ByRef Lich As MonthCalendar) As Integer
        Return System.DateTime.DaysInMonth(Lich.SelectionStart.Year, Lich.SelectionStart.Month)
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <param name="Nam"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DayofMonth1(ByRef thang As Integer, ByRef Nam As Integer) As Integer
        Return System.DateTime.DaysInMonth(Nam, thang)
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="nv"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Luongthang(ByRef nv As ClsChucDanh) As Double
        Dim result As Double = 0
        With nv
            If .LoaiLuong = 1 Then
                result = ConvertToDblSafe(Format(ConvertToDblSafe(timtenmax(String.Format("HSB{0}", .BacLuong), _
                                                          ConvertToStrSafe(.chucvu), _
                                                          "maso", _
                                                          "Chucvu")) * ConvertToDblSafe((GetSelectValue("SELECT lcb AS f1 FROM license"))), Mask_0))
            Else
                If .LoaiLuong = 2 Then
                    result = ConvertToDblSafe(Format(ConvertToDblSafe(timtenmax(String.Format("MLB{0}", .BacLuong), _
                                                              ConvertToStrSafe(.chucvu), _
                                                              "maso", _
                                                              "Chucvu")), Mask_0))
                Else
                    If .LoaiLuong = 3 Then
                        result = ConvertToDblSafe(Format(ConvertToDblSafe(timtenmax(String.Format("TVB{0}", .BacLuong), _
                                                                  ConvertToStrSafe(.chucvu), _
                                                                  "maso", _
                                                                  "Chucvu")), Mask_0))
                    Else
                        result = ConvertToDblSafe(Format(ConvertToDblSafe(timtenmax(String.Format("LNB{0}", .BacLuong), _
                                                                  ConvertToStrSafe(.chucvu), _
                                                                  "maso", _
                                                                  "Chucvu")), Mask_0))
                    End If
                End If
            End If
        End With
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="MaChucvu"></param>
    ''' <param name="Bac"></param>
    ''' <param name="LoaiLuong"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Luong1thang(ByRef MaChucvu As Integer, ByRef Bac As Integer, ByRef LoaiLuong As Integer) As String
        Dim result As String = String.Empty
        Try
            If LoaiLuong = 0 Then
                result = Format(ConvertToDblSafe(timtenmax(String.Format("HSB{0}", Bac), _
                                                     ConvertToStrSafe(MaChucvu), _
                                                     "maso", _
                                                     "Chucvu")) * ConvertToDblSafe(GetSelectValue("SELECT lcb AS f1 FROM license")), Mask_0)
            Else
                If LoaiLuong = 1 Then
                    result = Format(ConvertToDblSafe(timtenmax(String.Format("MLB{0}", Bac), _
                                                         ConvertToStrSafe(MaChucvu), _
                                                         "maso", _
                                                         "Chucvu")), Mask_0)
                Else
                    If LoaiLuong = 2 Then
                        result = Format(ConvertToDblSafe(timtenmax(String.Format("TVB{0}", Bac), _
                                                             ConvertToStrSafe(MaChucvu), _
                                                             "maso", _
                                                             "Chucvu")), Mask_0)
                    Else
                        If LoaiLuong = 3 Then result = Format(ConvertToDblSafe(timtenmax(String.Format("LNB{0}", Bac), _
                                                                                   ConvertToStrSafe(MaChucvu), _
                                                                                   "maso", _
                                                                                   "Chucvu")), Mask_0)
                    End If
                End If
            End If
        Catch
        End Try
        Return result
    End Function
End Module
