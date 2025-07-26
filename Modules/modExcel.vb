Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Diagnostics
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Drawing


Module modExcel
    Public title As String = String.Empty
    Public BCHDQ As String
    Public DoanhThuQ As String
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="strFilePath"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function OpenBook(ByRef strFilePath As String) As Boolean
        ' This procedure checks to see if the workbook
        ' specified in the strFilePath argument is open.
        ' If it is open, the workbook is activated. If it is
        ' not open, the procedure opens it.
        Dim result As Boolean = False
        Dim strBookName As String = String.Empty
        Try
            ' Determine the name portion of the strFilePath argument.
            strBookName = Path.GetFileName(strFilePath)
            If strBookName.Length = 0 Then Return result

            If Excel_Global.Workbooks.Count > 0 Then
                For Each wkbCurrent As Excel.Workbook In Excel_Global.Workbooks
                    If wkbCurrent.Name.Trim().Equals("TEST.XLS") Then
                        wkbCurrent.Activate()
                        Return result
                    End If
                Next wkbCurrent
            End If
            Excel_Global.Workbooks.Open(strFilePath)
            result = True
        Catch
            result = False
        End Try
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="strFilePath"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CloseBook(ByRef strFilePath As String) As Boolean
        ' This procedure checks to see if the workbook
        ' specified in the strFilePath argument is open.
        ' If it is open, the workbook is activated. If it is
        ' not open, the procedure opens it.
        Dim result As Boolean = False
        Dim wkbCurrent As Excel.Workbook
        Dim strBookName As String = String.Empty
        Try
            ' Determine the name portion of the strFilePath argument.
            strBookName = Path.GetFileName(strFilePath)
            If strBookName.Length = 0 Then Return result
            If Excel_Global.Workbooks.Count > 0 Then
                '      For Each wkbCurrent In Workbooks
                For i As Integer = 1 To Excel_Global.Workbooks.Count
                    wkbCurrent = Excel_Global.Workbooks(i)
                    If wkbCurrent.Name.ToUpper() = strBookName.ToUpper() Then
                        wkbCurrent.Close()
                        Exit For
                    End If
                Next
            End If
            result = True
        Catch
            result = False
        End Try
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="strBookName"></param>
    ''' <param name="intNumSheets"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CreateNewWorkbook(Optional ByRef strBookName As String = "", Optional ByRef intNumSheets As Integer = 3) As Excel.Workbook
        ' This procedure creates a new workbook file AND saves it by using the path
        ' AND name specified in the strBookName argument. You use the intNumsheets
        ' argument to specify the number of worksheets in the workbook;
        ' the default is 3.
        Dim result As New Excel.Workbook
        Dim intOrigNumSheets As Integer
        Dim wkbNew As New Excel.Workbook
        Try
            intOrigNumSheets = Excel_Global.Application.SheetsInNewWorkbook
            If intOrigNumSheets <> intNumSheets Then
                Excel_Global.Application.SheetsInNewWorkbook = intNumSheets
            End If
            wkbNew = Excel_Global.Workbooks.Add()
            If strBookName.Length = 0 Then strBookName = ConvertToStrSafe(Excel_Global.Application.GetSaveAsFilename)
            wkbNew.SaveAs(strBookName)
            result = wkbNew
            Excel_Global.Application.SheetsInNewWorkbook = intOrigNumSheets
        Catch
            result = Nothing
            wkbNew.Close(False)
        End Try
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="curSheet"></param>
    ''' <param name="RowIdx"></param>
    ''' <param name="StartCol"></param>
    ''' <param name="thutu"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PrintSQL(ByRef sql As String, ByVal curSheet As Excel.Worksheet, ByVal RowIdx As Integer, ByRef StartCol As Integer, Optional ByRef thutu As Integer = 0) As Integer
        Dim dongdau As Integer
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If rs.Rows.Count > 1 Then
                curSheet.Range(String.Format("{0}:{1}", ConvertToStrSafe(RowIdx + 1), ConvertToStrSafe(RowIdx + rs.Rows.Count - 2 + 1))).EntireRow.Insert()
            End If
            Dim rsIndex As Integer = 0
            While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                If thutu > 0 Then
                    If dongdau = 0 Then
                        curSheet.Cells(RowIdx, StartCol - 1) = 1
                        dongdau = 1
                    Else
                        curSheet.Cells(RowIdx, StartCol - 1) = curSheet.Cells(RowIdx - 1, StartCol - 1).value + 1
                    End If
                End If
                For FieldCnt As Integer = 0 To rs.Columns.Count - 1
                    curSheet.Cells(RowIdx, FieldCnt + StartCol) = rsItem(FieldCnt)
                    If FieldCnt = 1 And rsItem(FieldCnt) Like "PC*" Then curSheet.Cells(RowIdx, FieldCnt + StartCol) = ""
                    If FieldCnt = 2 And rsItem(FieldCnt) Like "PT*" Then curSheet.Cells(RowIdx, FieldCnt + StartCol) = ""
                Next FieldCnt
               
                'rs.MoveNext()
                RowIdx += 1
            End While
        Else
            RowIdx += 1
        End If
        Return RowIdx
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="curSheet"></param>
    ''' <param name="RowIdx"></param>
    ''' <param name="StartCol"></param>
    ''' <param name="thutu"></param>
    ''' <param name="khongchiuthue"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PrintSQLqm(ByRef sql As String, ByVal curSheet As Excel.Worksheet, ByVal RowIdx As Integer, ByRef StartCol As Integer, Optional ByRef thutu As Integer = 0, Optional ByRef khongchiuthue As Integer = 0) As Integer
        Dim dongdau As Integer
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        If rs.Rows.Count > 0 Then
            If rs.Rows.Count > 1 Then
                curSheet.Range(String.Format("{0}:{1}", ConvertToStrSafe(RowIdx + 1), ConvertToStrSafe(RowIdx + rs.Rows.Count - 2 + 1))).EntireRow.Insert()
            End If
            Dim rsIndex As Integer = 0
            Dim co As Integer = 0
            While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                If thutu > 0 And StartCol > 1 Then
                    If dongdau = 0 Then
                        curSheet.Cells(RowIdx, StartCol - 2) = 1
                        dongdau = 1
                    Else
                        curSheet.Cells(RowIdx, StartCol - 2) = curSheet.Cells(RowIdx - 1, StartCol - 2).text + 1
                        co = 1
                    End If
                End If
                If co = 1 Then
                    For FieldCnt As Integer = 0 To rs.Columns.Count - 1
                        curSheet.Cells(RowIdx, FieldCnt + 2).Value = rsItem(FieldCnt)
                    Next FieldCnt
                Else
                    For FieldCnt As Integer = 0 To rs.Columns.Count - 1
                        curSheet.Cells(RowIdx, FieldCnt + StartCol).Value = rsItem(FieldCnt)
                    Next FieldCnt
                End If
                If khongchiuthue = 1 Then curSheet.Cells(RowIdx, rs.Rows.Count - 2).Value = String.Empty
                ''rs.MoveNext()
                RowIdx += 1
            End While
        End If
        Return RowIdx
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ten"></param>
    ''' <remarks></remarks>
    Public Sub CopyDataVao(Optional ByRef ten As String = "", Optional ByRef qnk As String = "")
        Dim curSheet As Excel.Worksheet
        Dim RowIdx As Integer
        RowIdx = IIf(ten <> "", 2, 18)
        Try
            Kill(String.Format("{0}\temp\VATmuavao{1}.xls", pCurDir, ten))
        Catch
        End Try
        'Process.Start(String.Format("cmd /c ""del {0}VATmuavao{1}.xls""", pCurDir, ten))
        With Excel_Global.ActiveWorkbook
            curSheet = Excel_Global.Worksheets(1)
            If ten <> "" Then
                RowIdx = PrintSQLqm(String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,Ten,MST,MatHang,ThanhTien,TyLe,t2.sops AS Thue,mauso FROM ({2}) as t1 LEFT join chungtu t2 on t1.maso = t2.maso WHERE HTTT = '1' AND (t2.matkno={0} OR t2.matkno={1}) ORDER BY NgayPH ASC,SoHD ASC", _
                                      Timten("maso", taikhoanconnhat("133111"), "sohieu", "hethongtk"), _
                                      Timten("maso", taikhoanconnhat("333121"), "sohieu", "hethongtk"), _
                                      qnk), curSheet, RowIdx, 3, 1)
                RowIdx = PrintSQLqm(String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,Ten,MST,MatHang,ThanhTien,TyLe,t2.sops AS Thue,mauso FROM ({2}) as t1 LEFT join chungtu t2 on t1.maso = t2.maso WHERE HTTT = '2' AND (t2.matkno={0} OR t2.matkno={1}) ORDER BY NgayPH ASC,SoHD ASC", _
                                      Timten("maso", taikhoanconnhat("133111"), "sohieu", "hethongtk"), _
                                      Timten("maso", taikhoanconnhat("333121"), "sohieu", "hethongtk"), _
                                      qnk), curSheet, RowIdx, 3, 1)
                RowIdx = PrintSQLqm(String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,Ten,MST,MatHang,ThanhTien,TyLe,t2.sops AS Thue,mauso FROM ({2}) as t1 LEFT join chungtu t2 on t1.maso = t2.maso WHERE HTTT = '3' AND (t2.matkno={0} OR t2.matkno={1}) ORDER BY NgayPH ASC,SoHD ASC", _
                                      Timten("maso", taikhoanconnhat("133111"), "sohieu", "hethongtk"), _
                                      Timten("maso", taikhoanconnhat("333121"), "sohieu", "hethongtk"), _
                                      qnk), curSheet, RowIdx, 3, 1)
                PrintSQLqm(String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,Ten,MST,MatHang,ThanhTien,TyLe,t2.sops AS Thue,mauso FROM ({2}) as t1 LEFT join chungtu t2 on t1.maso = t2.maso WHERE HTTT = '4' AND (t2.matkno={0} OR t2.matkno={1}) ORDER BY NgayPH ASC,SoHD ASC", _
                                      Timten("maso", taikhoanconnhat("133111"), "sohieu", "hethongtk"), _
                                      Timten("maso", taikhoanconnhat("333121"), "sohieu", "hethongtk"), _
                                      qnk), curSheet, RowIdx, 3, 1)
            Else
                RowIdx = PrintSQL(String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,Ten,MST,MatHang,ThanhTien,TyLe,t2.sops AS Thue,mauso FROM ({2}) as t1 LEFT join chungtu t2 on t1.maso = t2.maso WHERE HTTT = '1' AND (t2.matkno={0} OR t2.matkno={1}) ORDER BY NgayPH ASC,SoHD ASC", _
                                      Timten("maso", taikhoanconnhat("133111"), "sohieu", "hethongtk"), _
                                      Timten("maso", taikhoanconnhat("333121"), "sohieu", "hethongtk"), _
                                      qnk), curSheet, RowIdx, 3, 1)
                RowIdx += 2
                RowIdx = PrintSQL(String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,Ten,MST,MatHang,ThanhTien,TyLe,t2.sops AS Thue,mauso FROM ({2}) as t1 LEFT join chungtu t2 on t1.maso = t2.maso WHERE HTTT = '2' AND (t2.matkno={0} OR t2.matkno={1}) ORDER BY NgayPH ASC,SoHD ASC", _
                                      Timten("maso", taikhoanconnhat("133111"), "sohieu", "hethongtk"), _
                                      Timten("maso", taikhoanconnhat("333121"), "sohieu", "hethongtk"), _
                                      qnk), curSheet, RowIdx, 3, 1)
                RowIdx += 2
                RowIdx = PrintSQL(String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,Ten,MST,MatHang,ThanhTien,TyLe,t2.sops AS Thue,mauso FROM ({2}) as t1 LEFT join chungtu t2 on t1.maso = t2.maso WHERE HTTT = '3' AND (t2.matkno={0} OR t2.matkno={1}) ORDER BY NgayPH ASC,SoHD ASC", _
                                      Timten("maso", taikhoanconnhat("133111"), "sohieu", "hethongtk"), _
                                      Timten("maso", taikhoanconnhat("333121"), "sohieu", "hethongtk"), _
                                      qnk), curSheet, RowIdx, 3, 1)
                RowIdx += 2
                RowIdx = PrintSQL(String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,Ten,MST,MatHang,ThanhTien,TyLe,t2.sops AS Thue,mauso FROM ({2}) as t1 LEFT join chungtu t2 on t1.maso = t2.maso WHERE HTTT = '4' AND (t2.matkno={0} OR t2.matkno={1}) ORDER BY NgayPH ASC,SoHD ASC", _
                                      Timten("maso", taikhoanconnhat("133111"), "sohieu", "hethongtk"), _
                                      Timten("maso", taikhoanconnhat("333121"), "sohieu", "hethongtk"), _
                                      qnk), curSheet, RowIdx, 3, 1)
            End If
            curSheet.SaveAs(String.Format("{0}\temp\VATmuavao{1}.xls", pCurDir, ten))
            CloseBook(String.Format("{0}\temp\VATmuavao{1}.xls", pCurDir, ten))
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ten"></param>
    ''' <remarks></remarks>
    Public Sub CopyDataRa(Optional ByRef ten As String = "", Optional ByRef qnk As String = "")
        Dim curSheet As Excel.Worksheet
        Dim RowIdx As Integer
        Select Case Information.Err().Number
            Case Is < 0
                Conversion.ErrorToString(5)
            Case 1
                Exit Sub
        End Select
        RowIdx = IIf(ten <> "", 2, 18)
        Try
            Kill(String.Format("{0}\temp\VATbanra{1}.xls", pCurDir, ten))
        Catch
        End Try
        'Process.Start(String.Format("cmd /c ""del {0}VATbanra{1}.xls""", pCurDir, ten))
        With Excel_Global.ActiveWorkbook
            curSheet = Excel_Global.Worksheets(1)
            If ten <> "" Then
                RowIdx = PrintSQLqm(String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,Ten,MST,MatHang,ThanhTien,TyLe,t2.sops AS Thue,mauso FROM ({1}) as  t1 LEFT join chungtu t2 on t1.sohd=t2.sohieu WHERE KCT=1 AND t2.matkco={0} ORDER BY NgayPH ASC,SoHD ASC", Timten("maso", "333111", "sohieu", "hethongtk"), qnk), _
                             curSheet, _
                             RowIdx, _
                             1, _
                             1, _
                             1)
                RowIdx = PrintSQLqm(String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,Ten,MST,MatHang,ThanhTien,TyLe,t2.sops AS Thue,mauso FROM ({1}) as t1 LEFT join chungtu t2 on t1.sohd=t2.sohieu WHERE (TyLe=0) AND (KCT=0) AND t2.matkco={0} ORDER BY NgayPH ASC,SoHD ASC", Timten("maso", "333111", "sohieu", "hethongtk"), qnk), _
                             curSheet, _
                             RowIdx, _
                             1, _
                             1)
                RowIdx = PrintSQLqm(String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,Ten,MST,MatHang,ThanhTien,TyLe,t2.sops AS Thue,mauso FROM ({1}) as t1 LEFT join chungtu t2 on t1.sohd=t2.sohieu WHERE (TyLe=5) AND (KCT=0) AND t2.matkco={0} ORDER BY NgayPH ASC,SoHD ASC", Timten("maso", "333111", "sohieu", "hethongtk"), qnk), _
                             curSheet, _
                             RowIdx, _
                             1, _
                             1)
                PrintSQLqm(String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,Ten,MST,MatHang,ThanhTien,TyLe,t2.sops AS Thue,mauso FROM ({1}) as t1 LEFT join chungtu t2 on t1.sohd=t2.sohieu WHERE (TyLe=10) AND (KCT=0) AND t2.matkco={0} ORDER BY NgayPH ASC,SoHD ASC", Timten("maso", "333111", "sohieu", "hethongtk"), qnk), curSheet, RowIdx, 1, 1)
            Else
                RowIdx = PrintSQL(String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,Ten,MST,MatHang,ThanhTien,TyLe,t2.sops AS Thue,mauso FROM ({1}) as t1 LEFT join chungtu t2 on t1.sohd=t2.sohieu WHERE KCT=1 AND t2.matkco={0} ORDER BY NgayPH ASC,SoHD ASC", Timten("maso", "333111", "sohieu", "hethongtk"), qnk), _
                             curSheet, _
                             RowIdx, _
                             3, _
                             1)
                RowIdx += 2
                RowIdx = PrintSQL(String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,Ten,MST,MatHang,ThanhTien,TyLe,t2.sops AS Thue,mauso FROM ({1}) as t1 LEFT join chungtu t2 on t1.sohd=t2.sohieu WHERE (TyLe=0) AND (KCT=0) AND t2.matkco={0} ORDER BY NgayPH ASC,SoHD ASC", Timten("maso", "333111", "sohieu", "hethongtk"), qnk), _
                             curSheet, _
                             RowIdx, _
                             3, _
                             1)
                RowIdx += 2
                RowIdx = PrintSQL(String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,Ten,MST,MatHang,ThanhTien,TyLe,t2.sops AS Thue,mauso FROM ({1}) as t1 LEFT join chungtu t2 on t1.sohd=t2.sohieu WHERE (TyLe=5) AND (KCT=0) AND t2.matkco={0} ORDER BY NgayPH ASC,SoHD ASC", Timten("maso", "333111", "sohieu", "hethongtk"), qnk), _
                             curSheet, _
                             RowIdx, _
                             3, _
                             1)
                RowIdx += 2
                PrintSQL(String.Format("SELECT DISTINCT KyHieu,SoHD,NgayPH,Ten,MST,MatHang,ThanhTien,TyLe,t2.sops AS Thue,mauso FROM ({1}) as t1 LEFT join chungtu t2 on t1.sohd=t2.sohieu WHERE (TyLe=10) AND (KCT=0) AND t2.matkco={0} ORDER BY NgayPH ASC,SoHD ASC", Timten("maso", "333111", "sohieu", "hethongtk"), qnk), _
                    curSheet, _
                    RowIdx, _
                    3, _
                    1)
            End If
            curSheet.SaveAs(String.Format("{0}\temp\VATbanra{1}.xls", pCurDir, ten))
            CloseBook(String.Format("{0}\temp\VATbanra{1}.xls", pCurDir, ten))
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ten"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="TK"></param>
    ''' <param name="NoDK"></param>
    ''' <param name="nolk"></param>
    ''' <param name="colk"></param>
    ''' <remarks></remarks>
    Public Sub CopyDataRa1(ByVal QSocai As String, ByRef ten As String, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef TK As ClsTaikhoan, ByRef NoDK As Double, ByRef nolk As Double, ByRef colk As Double)
        Dim curSheet As Excel.Worksheet
        Dim RowIdx As Integer
        Dim Tongpsno, tongpsco As Double
        Dim dk1, dk2 As String
        Select Case Information.Err().Number
            Case Is < 0
                Conversion.ErrorToString(5)
            Case 1
                Exit Sub
        End Select
        If Not (ten = "") Then
            Recycle(String.Format("{0}\TEMP{1}", pCurDir, ten))
            With Excel_Global.ActiveWorkbook
                curSheet = Excel_Global.Worksheets(1)
                curSheet.Cells(1, 1) = pTenCty
                If pTenCn.Trim().Length = 0 Or pTenCn.StartsWith(".") Then
                    curSheet.Cells(2, 1) = String.Format("MST: {0}", frmMain._LbCty_8.Text)
                Else
                    curSheet.Cells(2, 1) = String.Format("{0} - MST: {1}", pTenCn, frmMain._LbCty_8.Text)
                End If
                curSheet.Cells(2, 4) = title
                If tdau = tcuoi Then
                    curSheet.Cells(3, 4) = String.Format("Tháng {0}{1}/{2}", (IIf(tcuoi < 10, "0", String.Empty)), ConvertToStrSafe(tcuoi), frmMain._LbCty_7.Text)
                Else
                    curSheet.Cells(3, 4) = String.Format("Từ tháng {0}{1} đến tháng {2}{3}/{4}", (IIf(tdau < 10, "0", String.Empty)), ConvertToStrSafe(tdau), (IIf(tcuoi < 10, "0", String.Empty)), ConvertToStrSafe(tcuoi), frmMain._LbCty_7.Text)
                End If
                curSheet.Cells(5, 4) = String.Format("{0} - {1}", TK.sohieu, TK.ten)
                NoDK = IIf(TK.sohieu Like "3*" Or TK.sohieu Like "4*" Or TK.sohieu Like "5*" Or TK.sohieu Like "7*" Or TK.sohieu Like "9*", 0 - NoDK, NoDK)
                curSheet.Cells(6, 9) = NoDK
                RowIdx = 9
                dk1 = "CASE WHEN LEFT(sh1,1)='0' THEN sops ELSE 0 END, CASE WHEN LEFT(sh1,1)='1' THEN sops ELSE 0 END"
                dk2 = "CASE WHEN LEFT(sh1,1)='1' THEN sops ELSE 0 END, CASE WHEN LEFT(sh1,1)='0' THEN sops ELSE 0 END"
                RowIdx = PrintSQL(String.Format("SELECT DISTINCT ngaygs,[chungtu.sohieu],ngayct,DienGiai,round(maso/39,0)+CASE WHEN maso % 39 = 0 THEN 0 ELSE 1 END AS sotrang,sopsno AS sodong,isnull(doiung,'') as doiung,{0} FROM (" & QSocai & ") as qsocai group by ngaygs,[chungtu.sohieu],ngayct,DienGiai,round(maso/39,0)+CASE WHEN maso % 39 = 0 THEN 0 ELSE 1 END,sopsno,doiung,{0}", (IIf(TK.sohieu Like "3*" Or TK.sohieu Like "4*" Or TK.sohieu Like "5*" Or TK.sohieu Like "7*" Or TK.sohieu Like "9*", dk2, dk1))), _
                             curSheet, _
                             RowIdx, _
                             1)
                curSheet.Range(String.Format("{0}:{0}", ConvertToStrSafe(RowIdx))).EntireRow.Delete()
                Tongpsno = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(CASE WHEN LEFT(sh1,1)=N'{0}' THEN sops ELSE 0 END)AS f1 FROM (" & QSocai & ") as qsocai", (IIf(TK.sohieu Like "3*" Or TK.sohieu Like "4*" Or TK.sohieu Like "5*" Or TK.sohieu Like "7*" Or TK.sohieu Like "9*", "1", "0")))))
                curSheet.Cells(RowIdx, 8) = Tongpsno
                tongpsco = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(CASE WHEN(LEFT(sh1,1)=N'{0}') THEN sops ELSE 0 END)AS f1 FROM (" & QSocai & ") as qsocai", (IIf(TK.sohieu Like "3*" Or TK.sohieu Like "4*" Or TK.sohieu Like "5*" Or TK.sohieu Like "7*" Or TK.sohieu Like "9*", "0", "1")))))
                curSheet.Cells(RowIdx, 9) = tongpsco
                RowIdx += 1
                curSheet.Cells(RowIdx, 8) = nolk
                curSheet.Cells(RowIdx, 9) = colk
                RowIdx += 1
                curSheet.Cells(RowIdx, 9) = NoDK + Tongpsno - tongpsco
                RowIdx += 3
                curSheet.Cells(RowIdx, 1) = String.Format("Ngày mở sổ: {0}", Format((GetSelectValue("SELECT min(ngaygs) AS f1 FROM (" & QSocai & ") as qsocai")), Mask_DB))
                RowIdx += 1
                curSheet.Cells(RowIdx, 9) = String.Format("Ngày {0} tháng {1}{2} năm {3}", _
                                                DateAndTime.Day(NgayCuoiThang(ConvertToDblSafe(frmMain._LbCty_7.Text), tcuoi)), _
                                                (IIf(tcuoi < 10, "0", String.Empty)), _
                                                ConvertToStrSafe(tcuoi), _
                                                frmMain._LbCty_7.Text)
                curSheet.SaveAs(String.Format("{0}\TEMP{1}", pCurDir, ten))
                CloseBook(String.Format("{0}\TEMP{1}", pCurDir, ten))
            End With
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ten"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="TK"></param>
    ''' <param name="NoDK"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <remarks></remarks>
    Public Sub CopySoQuy(ByRef ten As String, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef TK As ClsTaikhoan, ByRef NoDK As Double, ByRef ndau As Date, ByRef ncuoi As Date, ByVal socai As String)
        Dim curSheet As Excel.Worksheet
        Dim RowIdx As Integer
        Dim Tongpsno, tongpsco As Double
        Dim dk1, dk2 As String
        Select Case Information.Err().Number
            Case Is < 0
                Conversion.ErrorToString(5)
            Case 1
                Exit Sub
        End Select
        If Not (ten = "") Then
            Recycle(String.Format("{0}\TEMP{1}", pCurDir, ten))
            With Excel_Global.ActiveWorkbook
                curSheet = Excel_Global.Worksheets(1)
                curSheet.Cells(1, 1) = pTenCty
                If pTenCn.Trim().Length = 0 Or pTenCn.StartsWith(".") Then
                    curSheet.Cells(2, 1) = String.Format("MST: {0}", frmMain._LbCty_8.Text)
                Else
                    curSheet.Cells(2, 1) = String.Format("{0} - MST: {1}", pTenCn, frmMain._LbCty_8.Text)
                End If
                curSheet.Cells(2, 4) = title
                If tdau > 0 And tcuoi > 0 Then
                    If tdau = tcuoi Then
                        curSheet.Cells(3, 4) = String.Format("Tháng {0}{1}/{2}", (IIf(tcuoi < 10, "0", String.Empty)), ConvertToStrSafe(tcuoi), frmMain._LbCty_7.Text)
                    Else
                        curSheet.Cells(3, 4) = String.Format("Từ tháng {0}{1} đến tháng {2}{3}/{4}", (IIf(tdau < 10, "0", String.Empty)), ConvertToStrSafe(tdau), (IIf(tcuoi < 10, "0", String.Empty)), ConvertToStrSafe(tcuoi), frmMain._LbCty_7.Text)
                    End If
                Else
                    If ndau = ncuoi Then
                        curSheet.Cells(3, 4) = String.Format("Ngày {0}", FormatDate(ncuoi))
                    Else
                        curSheet.Cells(3, 4) = String.Format("Từ ngày {0} đến ngày {1}", FormatDate(ndau), FormatDate(ncuoi))
                    End If
                End If
                curSheet.Cells(5, 4) = String.Format("{0} - {1}", TK.sohieu, TK.ten)
                NoDK = IIf(TK.sohieu Like "3*" Or TK.sohieu Like "4*" Or TK.sohieu Like "5*" Or TK.sohieu Like "7*" Or TK.sohieu Like "9*", 0 - NoDK, NoDK)
                curSheet.Cells(8, 7) = NoDK
                RowIdx = 9
                dk1 = "sum(CASE WHEN LEFT(sh1,1)='0' THEN sops ELSE 0 END), sum(CASE WHEN LEFT(sh1,1)='1' THEN sops ELSE 0 END)"
                dk2 = "sum(CASE WHEN LEFT(sh1,1)='1' THEN sops ELSE 0 END), sum(CASE WHEN LEFT(sh1,1)='0' THEN sops ELSE 0 END)"
                RowIdx = PrintSQL(String.Format("SELECT ngaygs,ghichu,ghichu,DienGiai,{0},sh1,sohieu FROM ({1}) qsocai group by ngaygs,sohieu,ngayct,DienGiai,sh1,ghichu order by ngaygs,sh1", (IIf(TK.sohieu Like "3*" Or TK.sohieu Like "4*" Or TK.sohieu Like "5*" Or TK.sohieu Like "7*" Or TK.sohieu Like "9*", dk2, dk1)), socai), _
                             curSheet, _
                             RowIdx, _
                             1)

                For dong As Integer = 9 To RowIdx - 1
                    curSheet.Cells(dong, 7) = curSheet.Cells(dong - 1, 7).value + curSheet.Cells(dong, 5).value - curSheet.Cells(dong, 6).value
                Next

                Tongpsno = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(CASE WHEN LEFT(sh1,1)=N'{0}' THEN sops ELSE 0 END) AS f1 FROM (" & socai & ") as qsocai", (IIf(TK.sohieu Like "3*" Or TK.sohieu Like "4*" Or TK.sohieu Like "5*" Or TK.sohieu Like "7*" Or TK.sohieu Like "9*", "1", "0")))))
                curSheet.Cells(RowIdx, 5) = Tongpsno
                tongpsco = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(CASE WHEN LEFT(sh1,1)=N'{0}' THEN sops ELSE 0 END)AS f1 FROM (" & socai & ") as qsocai", (IIf(TK.sohieu Like "3*" Or TK.sohieu Like "4*" Or TK.sohieu Like "5*" Or TK.sohieu Like "7*" Or TK.sohieu Like "9*", "0", "1")))))
                curSheet.Cells(RowIdx, 6) = tongpsco
                RowIdx += 1
                curSheet.Cells(RowIdx, 7) = NoDK + Tongpsno - tongpsco
                RowIdx += 2
                curSheet.Cells(RowIdx, 1) = String.Format("Ngày mở sổ: {0}", Format((GetSelectValue("SELECT min(ngaygs) AS f1 FROM (" & socai & ") as qsocai")), Mask_DB))
                RowIdx += 1
                curSheet.Cells(RowIdx, 7) = String.Format("Ngày {0} tháng {1}{2} năm {3}", _
                                                DateAndTime.Day(ncuoi), _
                                                (IIf(ncuoi.Month < 10, "0", String.Empty)), _
                                                ConvertToStrSafe(ncuoi.Month), _
                                                ConvertToStrSafe(ncuoi.Year))
                curSheet.SaveAs(String.Format("{0}\TEMP{1}", pCurDir, ten))
                CloseBook(String.Format("{0}\TEMP{1}", pCurDir, ten))
            End With
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ten"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Public Sub CopyDataRa2(ByRef ten As String, ByRef tdau As Integer, ByRef tcuoi As Integer, Optional ByRef SQL As String = "")
        Dim curSheet As Excel.Worksheet
        Dim RowIdx As Integer
        Dim Tongpsno, tongpsco As Double
        Select Case Information.Err().Number
            Case Is < 0
                Conversion.ErrorToString(5)
            Case 1
                Exit Sub
        End Select
        If Not (ten = "") Then
            Recycle(String.Format("{0}\TEMP{1}", pCurDir, ten))
            With Excel_Global.ActiveWorkbook
                curSheet = Excel_Global.Worksheets(1)
                curSheet.Cells(1, 1) = pTenCty
                If pTenCn.Trim().Length = 0 Or pTenCn.StartsWith(".") Then
                    curSheet.Cells(2, 1) = String.Format("MST: {0}", frmMain._LbCty_8.Text)
                Else
                    curSheet.Cells(2, 1) = String.Format("{0} - MST: {1}", pTenCn, frmMain._LbCty_8.Text)
                End If
                curSheet.Cells(4, 1) = title
                If tdau = tcuoi Then
                    curSheet.Cells(5, 1) = String.Format("Tháng {0}{1}/{2}", _
                                               (IIf(tcuoi < 10, "0", String.Empty)), _
                                               ConvertToStrSafe(tcuoi), _
                                               frmMain._LbCty_7.Text)
                Else
                    curSheet.Cells(5, 1) = String.Format("Từ tháng {0}{1} đến tháng {2}{3}/{4}", _
                                               (IIf(tdau < 10, "0", String.Empty)), _
                                               ConvertToStrSafe(tdau), _
                                               (IIf(tcuoi < 10, "0", String.Empty)), _
                                               ConvertToStrSafe(tcuoi), _
                                               frmMain._LbCty_7.Text)
                End If
                RowIdx = 11
                RowIdx = PrintSQL("SELECT DISTINCT ngaygs,[chungtu.sohieu],ngayct,ten,'','',[hethongtk.sohieu], CASE WHEN loaips=-1 THEN sumofsops ELSE 0 END, CASE WHEN loaips=1 THEN sumofsops ELSE 0 END FROM (" & SQL & ") as mientru1", curSheet, RowIdx, 1)
                curSheet.Range(String.Format("{0}:{0}", ConvertToStrSafe(RowIdx))).EntireRow.Delete()
                Tongpsno = ConvertToDblSafe(GetSelectValue("SELECT sum(CASE WHEN loaips=-1 THEN sumofsops ELSE 0 END)AS f1 FROM (" & SQL & ") as mientru1"))
                curSheet.Cells(RowIdx, 8) = Tongpsno
                tongpsco = ConvertToDblSafe(GetSelectValue("SELECT sum(CASE WHEN loaips=1 THEN sumofsops ELSE 0 END)AS f1 FROM (" & SQL & ") as mientru1"))
                curSheet.Cells(RowIdx, 9) = tongpsco
                RowIdx += 2
                curSheet.Cells(RowIdx, 1) = String.Format("Ngày mở sổ: {0}", Format(CDate(GetSelectValue("SELECT min(ngaygs) AS f1 FROM (" & SQL & ") as mientru1")), Mask_DB))
                RowIdx += 1
                curSheet.Cells(RowIdx, 5) = String.Format("Ngày {0} tháng {1}{2} năm {3}", _
                                                DateAndTime.Day(NgayCuoiThang(ConvertToDblSafe(frmMain._LbCty_7.Text), tcuoi)), _
                                                (IIf(tcuoi < 10, "0", String.Empty)), _
                                                ConvertToStrSafe(tcuoi), _
                                                frmMain._LbCty_7.Text)
                curSheet.SaveAs(pCurDir & "\TEMP" & ten)
                CloseBook(pCurDir & "\TEMP" & ten)
            End With
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="rs"></param>
    ''' <param name="thangdau"></param>
    ''' <param name="thangcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function HDSuDung(ByRef rs As DataTable, ByRef thangdau As Integer, ByRef thangcuoi As Integer) As Integer
        Dim rsItem As DataRow = rs.Rows(0)
        Return ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(HoaDon.KyHieu) AS F1 FROM SLHOADON INNER JOIN (HoaDon INNER JOIN ChungTu ON HoaDon.MaSo = ChungTu.MaSo) ON SLHOADON.KyHieu = HoaDon.KyHieu WHERE (SoHDDau+SLHoaDon.Soluong-1>=CONVERT(bigint,HoaDon.sohd)) AND (SoHDDau<=CONVERT(bigint,HoaDon.sohd)) AND HoaDon.Loai=1 AND {0} AND (HoaDon.DC=0 OR HD=1) AND SLHoaDon.KyHieu=N'{1}' AND SLHoaDon.SoHDDau={2} AND SLHoaDon.SoLuong={3} AND hoadon.sohd<>'...' GROUP BY HoaDon.KyHieu,SLHoaDon.SoHDDau,SLHoaDon.SoLuong", _
                                                   WThang("ThangCT", thangdau, thangcuoi), _
                                                   rsItem("KyHieu"), _
                                                   rsItem("SoHDDau"), _
                                                   rsItem("soluong"))))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateSLHoaDonTable()
        Dim sql As String = String.Empty
        Try
            sql = "CREATE TABLE SLHoaDon (KyHieu varchar(20) NOT NULL ,SoHDDau Int NOT NULL , Soluong int NOT NULL,ThangNhap smallint NOT NULL,LoaiHD smallint NOT NULL,TonThang1 int,TonThang2 int,TonThang3 int,TonThang4 int,TonThang5 int,TonThang6 int,TonThang7 int,TonThang8 int, TonThang9 int,TonThang10 int,TonThang11 int, TonThang12 int)"
            ExecSQLNonQuery(sql)
            sql = "ALTER TABLE SLHoaDon ADD PRIMARY KEY (KyHieu, SoHDDau)"
            ExecSQLNonQuery(sql)
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub SuaSLHoaDon()
        Try
            If Not TruongDaCo("SLHoaDon", "thangtra") Then
                ExecSQLNonQuery("ALTER TABLE SLHoaDon add thangtra integer null")
            End If
        Catch
        End Try
        Try
            If Not TruongDaCo("SLHoaDon", "sotra") Then
                ExecSQLNonQuery("ALTER TABLE SLHoaDon add sotra integer null")
            End If
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateSLHoaDon()
        'sql = "SELECT SLHoaDon.KyHieu,SoHDDau,SLHoaDon.Soluong FROM SLHoaDon Inner Join HoaDon on SLHoaDon.KyHieu=HoaDon.KyHieu WHERE (SoHDDau+SLHoaDon.Soluong-1>=CONVERT(bigint,HoaDon.sohd)) AND (SoHDDau<=CONVERT(bigint,HoaDon.sohd)) AND (HoaDon.DC=0 OR HD=1)" 'AND " + ConvertToDblSafe(Format([NgayPH], "mm")) + "=1"
        Dim sql As String = "SELECT * FROM SLHoaDon"
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        Dim sl As Integer
        Dim rsIndex As Integer = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            sl = rsItem("soluong")
            If rsItem("ThangNhap") > 0 Then
                For i As Integer = 1 To rsItem("ThangNhap") - 1
                    ExecSQLNonQuery(String.Format("UPDATE SLHoaDon SET SLHoaDon.TonThang{0}=0 WHERE KyHieu=N'{1}' AND SoHDDau={2} AND SoLuong={3}", _
                                        i, _
                                        rsItem("KyHieu"), _
                                        rsItem("SoHDDau"), _
                                        rsItem("soluong")))
                Next
                ExecSQLNonQuery(String.Format("UPDATE SLHoaDon SET SLHoaDon.TonThang{0}={1} WHERE KyHieu=N'{2}' AND SoHDDau={3} AND SoLuong={1}", _
                                    rsItem("ThangNhap"), _
                                    rsItem("soluong"), _
                                    rsItem("KyHieu"), _
                                    rsItem("SoHDDau")))
                For i As Integer = rsItem("ThangNhap") + 1 To 12
                    sl -= HDSuDung(rs, i - 1, i - 1)
                    ExecSQLNonQuery(String.Format("UPDATE SLHoaDon SET SLHoaDon.TonThang{0}={1}{2} WHERE KyHieu=N'{3}' AND SoHDDau={4} AND SoLuong={5}", _
                                        i, _
                                        ConvertToStrSafe(sl), _
                                        (IIf(rsItem("thangtra") < i, String.Format("-{0}", rsItem("sotra")), String.Empty)), _
                                        rsItem("KyHieu"), _
                                        rsItem("SoHDDau"), _
                                        rsItem("soluong")))
                Next
            Else
                ExecSQLNonQuery(String.Format("UPDATE SLHoaDon SET SLHoaDon.TonThang{0}={1}{2} WHERE KyHieu=N'{3}' AND SoHDDau={4} AND SoLuong={1}", _
                                    rsItem("ThangNhap") + 1, _
                                    rsItem("soluong"), _
                                    (IIf(rsItem("thangtra") < rsItem("ThangNhap") + 1, String.Format("-{0}", rsItem("sotra")), String.Empty)), _
                                    rsItem("KyHieu"), _
                                    rsItem("SoHDDau")))
                For i As Integer = rsItem("ThangNhap") + 2 To 12
                    sl -= HDSuDung(rs, i - 1, i - 1)
                    ExecSQLNonQuery(String.Format("UPDATE SLHoaDon SET SLHoaDon.TonThang{0}={1}{2} WHERE KyHieu=N'{3}' AND SoHDDau={4} AND SoLuong={5}", _
                                         i, _
                                         ConvertToStrSafe(sl), _
                                         (IIf(rsItem("thangtra") < i, "-" & rsItem("sotra"), String.Empty)), _
                                         rsItem("KyHieu"), _
                                         rsItem("SoHDDau"), _
                                         rsItem("soluong")))
                Next
            End If
            ''rs.MoveNext()
        Loop
    End Sub
    'Tao bao cao hoa don thang

    'Public Sub TaoBCHoaDon(ByRef thang As Integer)
    '    Dim QBCHoaDon1 As String = String.Format("SELECT HoaDon.KyHieu,SoHDDau,(SoHDDau+SlHoaDon.Soluong-1) AS SoHDCuoi,count(HoaDon.KyHieu) AS SumHD FROM SLHOADON INNER JOIN (HoaDon INNER JOIN ChungTu ON HoaDon.MaSo = ChungTu.MaSo) ON SLHOADON.KyHieu = HoaDon.KyHieu WHERE (SoHDDau+SLHoaDon.Soluong-1>=CONVERT(bigint,HoaDon.sohd)) AND (SoHDDau<=CONVERT(bigint,HoaDon.sohd)) AND HoaDon.Loai=1 AND {0} AND (HoaDon.DC=0 OR HD=1) GROUP BY HoaDon.KyHieu,SoHDDau,SLHoaDon.SoLuong", WThang("ThangCT", thang, thang))
    '    Dim QBCHoaDon2 As String = String.Format("SELECT HoaDon.KyHieu,SoHDDau,(SoHDDau+SlHoaDon.Soluong-1) AS SoHDCuoi,count(HoaDon.KyHieu) AS SumHDH FROM SLHOADON INNER JOIN ({0}) ON SLHOADON.KyHieu = HoaDon.KyHieu WHERE (SoHDDau+SLHoaDon.Soluong-1>=CONVERT(bigint,HoaDon.sohd)) AND (SoHDDau<=CONVERT(bigint,HoaDon.sohd)) AND HoaDon.Loai=1 AND {1} AND (HoaDon.DC=0 OR HD=1) AND HoaDon.ThanhTien=0 AND KhachHang.SoHieu='H' GROUP BY HoaDon.KyHieu,SoHDDau,SlHoaDon.Soluong", ChungTu2TKHD(2), WThang("ThangCT", thang, thang))
    '    Dim sql As String = String.Format("SELECT DISTINCT sl.KyHieu,(sl.SoHDDau+sl.SoLuong-sl.TonThang{0}) AS SoHDDau, (sl.SoLuong+sl.SoHDDau-1) AS SoHDCuoi, CASE WHEN(sl.ThangNhap={1}) THEN 0 ELSE sl.TonThang{1} END AS TonThangTruoc,CASE WHEN(sl.ThangNhap={1}) THEN sl.TonThang{1} ELSE 0 END AS NhapMoi,SumHD,SumHDH,CASE WHEN(SumHDH>0) THEN SumHD-SumHDH ELSE SumHD END AS SumHDSD", _
    '                            thang, _
    '                            ConvertToStrSafe(thang))
    '    sql = String.Format("{0} FROM SLHoaDon sl LEFT JOIN ((" & QBCHoaDon1 & ") as q1 LEFT JOIN (" & QBCHoaDon2 & ") as q2 on q1.KyHieu=q2.KyHieu) ON (sl.KyHieu=q1.KyHieu AND sl.soHDDau=q1.soHDDau)", sql)
    '    sql = String.Format("{0} WHERE sl.TonThang{1}>0 ", _
    '              sql, _
    '              ConvertToStrSafe(thang))
    '    sql = String.Format("{0} GROUP BY  sl.KyHieu, q1.SumHD, q2.SumHDH, sl.SoHDDau, sl.SoLuong, sl.ThangNhap,sl.TonThang{1}", _
    '              sql, _
    '              ConvertToStrSafe(thang))
    '    SetSQL("QBCHoaDonChiTiet", sql)
    'End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thangdau"></param>
    ''' <param name="thangcuoi"></param>
    ''' <remarks></remarks>
    Public Sub TaoBCHoaDonQuy(ByRef thangdau As Integer, ByRef thangcuoi As Integer)
        Dim rschitiet, rsxoabo As DataTable
        Dim Max As Double
        Dim Min As Double
        Dim TonDau As Double
        Dim NhapMoi As Integer
        Dim somatchayhong, sohuy, soxoabo As String
        Dim luonghuy, luongmatchayhong As Integer
        Dim rs As DataTable = ExecSQLReturnDT("SELECT * FROM slhoadon ")
        ExecSQLNonQuery("DELETE FROM baocaocp2")
        ExecSQLNonQuery("DELETE FROM baocaocp")
        ExecSQLNonQuery("DELETE FROM phieunx")
        Dim rsIndex As Integer = 0
        While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            sohuy = ""
            somatchayhong = ""
            soxoabo = ""
            luonghuy = 0
            luongmatchayhong = 0
            rsxoabo = ExecSQLReturnDT(String.Format("SELECT chungtu.sohieu FROM (chungtu inner join hoadon on chungtu.sohieu=hoadon.sohd)inner join khachhang on hoadon.makhachhang=khachhang.maso WHERE loai=1 AND {0} AND (khachhang.sohieu='H' OR khachhang.sohieu='h') AND hoadon.kyhieu=N'{1}'", _
                                          WThang("thangct", thangdau, thangcuoi), _
                                          rsItem("KyHieu")))
            Dim rsxoaboIndex As Integer = 0
            While rsxoaboIndex < rsxoabo.Rows.Count
                Dim rsxoaboItem As DataRow = rsxoabo.Rows(rsxoaboIndex)
                rsxoaboIndex += 1 ' C15 Rs LOOP CONTROL
                soxoabo = String.Format("{0} , ", soxoabo + rsxoaboItem("SoHieu"))
                'rsxoabo.MoveNext()
            End While
            If soxoabo.Length > 0 Then
                soxoabo = Strings.Left(soxoabo, soxoabo.Length - 2)
                ExecSQLNonQuery(String.Format("INSERT INTO phieunx(maso,sohieu,kho)VALUES({0}, N'{1}', N'{2}')", _
                                    Lng_MaxValue("maso", "phieunx") + 1, _
                                    rsItem("KyHieu"), _
                                    soxoabo))
            End If
            rschitiet = ExecSQLReturnDT(String.Format("SELECT * FROM chitiethuy inner join thongtinhuy on chitiethuy.mathongtin=thongtinhuy.maso WHERE kyhieu=N'{0}' AND month(ngay)>={1} AND month(ngay)<={2} ORDER BY tuso", _
                                            rsItem("KyHieu"), _
                                            ConvertToStrSafe(thangdau), _
                                            ConvertToStrSafe(thangcuoi)))
            Dim rschitietIndex As Integer = 0
            While rschitietIndex < rschitiet.Rows.Count
                Dim rschitietItem As DataRow = rschitiet.Rows(rschitietIndex)
                rschitietIndex += 1 ' C15 Rs LOOP CONTROL
                If rschitietItem("tuso") <> rschitietItem("denso") Then
                    If rschitietItem("loaihuy") = 0 Then
                        sohuy = String.Format("{0}{1} - {2} , ", _
                                    sohuy, _
                                    rschitietItem("tuso"), _
                                    rschitietItem("denso"))
                        luonghuy += rschitietItem("soluong")
                    Else
                        somatchayhong = String.Format("{0}{1} - {2} , ", _
                                            somatchayhong, _
                                            rschitietItem("tuso"), _
                                            rschitietItem("denso"))
                        luongmatchayhong += rschitietItem("soluong")
                    End If
                Else
                    If rschitietItem("loaihuy") = 0 Then
                        sohuy = String.Format("{0}{1} , ", _
                                    sohuy, _
                                    rschitietItem("denso"))
                        luonghuy += rschitietItem("soluong")
                    Else
                        somatchayhong = String.Format("{0}{1} , ", somatchayhong, rschitietItem("denso"))
                        luongmatchayhong += rschitietItem("soluong")
                    End If
                End If
                'rschitiet.MoveNext()
            End While
            If luonghuy > 0 Then
                sohuy = Strings.Left(sohuy, sohuy.Length - 2)
                ExecSQLNonQuery(String.Format("UPDATE slhoadon SET sotra={0}, thangtra={1} WHERE kyhieu=N'{2}'", _
                                    luonghuy, _
                                    ConvertToStrSafe(thangcuoi), _
                                    rsItem("KyHieu")))
            Else
                ExecSQLNonQuery(String.Format("UPDATE slhoadon SET sotra=0, thangtra=0 WHERE kyhieu=N'{0}'", rsItem("KyHieu")))
            End If
            If luongmatchayhong > 0 Then
                somatchayhong = Strings.Left(somatchayhong, somatchayhong.Length - 2)
                ExecSQLNonQuery(String.Format("UPDATE slhoadon SET somat={0}, thangmat={1} WHERE kyhieu=N'{2}'", _
                                    luongmatchayhong, _
                                    ConvertToStrSafe(thangcuoi), _
                                    rsItem("KyHieu")))
            Else
                ExecSQLNonQuery(String.Format("UPDATE slhoadon SET somat=0, thangmat=0 WHERE kyhieu=N'{0}'", rsItem("KyHieu")))
            End If
            If sohuy.Length > 0 Then ExecSQLNonQuery(String.Format("INSERT INTO baocaocp2(maso,sohieu,ten)VALUES({0}, N'{1}', N'{2}')", _
                                                         Lng_MaxValue("maso", "baocaocp2") + 1, _
                                                         rsItem("KyHieu"), _
                                                         sohuy))
            If somatchayhong.Length > 0 Then ExecSQLNonQuery(String.Format("INSERT INTO baocaocp(maso,sohieu,ten)VALUES({0}, N'{1}', N'{2}')", _
                                                                 Lng_MaxValue("maso", "baocaocp") + 1, _
                                                                 rsItem("KyHieu"), _
                                                                 somatchayhong))
            ''rs.MoveNext()
        End While
        Dim QBCHoaDon1 As String = String.Format("SELECT HoaDon.KyHieu,SoHDDau,(SoHDDau+SlHoaDon.Soluong-1) AS SoHDCuoi,count(HoaDon.KyHieu) AS SumHD FROM SLHOADON INNER JOIN (HoaDon INNER JOIN ChungTu ON HoaDon.MaSo = ChungTu.MaSo) ON SLHOADON.KyHieu = HoaDon.KyHieu WHERE (SoHDDau+SLHoaDon.Soluong-1>=CONVERT(float,HoaDon.sohd)) AND (SoHDDau<=CONVERT(float,HoaDon.sohd)) AND HoaDon.Loai=1 AND {0} AND (HoaDon.DC=0 OR HD=1) GROUP BY HoaDon.KyHieu,SoHDDau,SLHoaDon.SoLuong", WThang("ThangCT", thangdau, thangcuoi))
        Dim QBCHoaDon2 As String = String.Format("SELECT HoaDon.KyHieu,SoHDDau,(SoHDDau+SlHoaDon.Soluong-1) AS SoHDCuoi,count(HoaDon.KyHieu) AS SumHDH FROM SLHOADON INNER JOIN ({0}) ON SLHOADON.KyHieu = HoaDon.KyHieu WHERE (SoHDDau+SLHoaDon.Soluong-1>=CONVERT(float,HoaDon.sohd)) AND (SoHDDau<=CONVERT(float,HoaDon.sohd)) AND HoaDon.Loai=1 AND {1} AND (HoaDon.DC=0 OR HD=1) AND HoaDon.ThanhTien=0 AND KhachHang.SoHieu='H' GROUP BY HoaDon.KyHieu,SoHDDau,SlHoaDon.Soluong", _
                                 ChungTu2TKHD(2), _
                                 WThang("ThangCT", thangdau, thangcuoi))
        Try
            ExecSQLNonQuery("DROP TABLE TTemp")
            ExecSQLNonQuery("SELECT KyHieu,SoHDDau,SoLuong,ThangNhap,LoaiHD,0 AS TonDau,0 AS NhapMoi,sotra,thangtra,somat,thangmat INTO TTemp FROM SLHoaDon GROUP BY KyHieu,SoHDDau,SoLuong,ThangNhap,LoaiHD,sotra,thangtra,somat,thangmat")
            rs = ExecSQLReturnDT("SELECT * FROM SLHoaDon")
            rsIndex = 0
            Do While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                MinMaxInRange(rsItem("KyHieu"), rsItem("SoHDDau"), thangdau, thangcuoi, Min, Max)
                NhapMoi = 0
                TonDau = 0
                If (Max = rsItem("soluong") And rsItem("ThangNhap") >= thangdau) Then
                    NhapMoi = ConvertToDblSafe(Max)
                Else
                    TonDau = Max
                End If
                If Max > 0 Then
                    ExecSQLNonQuery(String.Format("UPDATE TTemp SET TonDau={0},NhapMoi={1} WHERE KyHieu=N'{2}' AND SoHDDau={3}", _
                                        TonDau, _
                                        ConvertToStrSafe(NhapMoi), _
                                        rsItem("KyHieu"), _
                                        rsItem("SoHDDau")))
                End If
            Loop
            rs = Nothing
            Dim sql As String = "SELECT DISTINCT loai.ten as [qchitiet.ten],loai.sohieu AS kyhieuhoadon,sl.KyHieu,sl.SoHDDau+sl.Soluong-(sl.TonDau+sl.NhapMoi) AS SoHDDau, (sl.SoLuong+sl.SoHDDau-1) AS SoHDCuoi,sl.LoaiHD,sl.TonDau AS TonThangTruoc,sl.NhapMoi,SumHD,SumHDH,CASE WHEN(SumHDH>0) THEN SumHD-SumHDH ELSE SumHD END AS SumHDSD,sotra,thangtra,somat,thangmat"
            sql = String.Format(String.Format("{{0}} FROM (TTemp sl LEFT join loaihoadon loai on sl.loaihd=loai.maso) LEFT JOIN (({{1}}) AS q1 LEFT JOIN ({0}) AS q2 on q1.KyHieu=q2.KyHieu AND q1.sohddau=q2.sohddau) ON (sl.KyHieu=q1.KyHieu AND sl.soHDDau=q1.soHDDau)", QBCHoaDon2), sql, QBCHoaDon1)
            sql = String.Format("{0} WHERE (sl.TonDau>0 OR sl.NhapMoi>0)", sql)
            sql = String.Format("{0} GROUP BY  loai.ten,sl.KyHieu, q1.SumHD, q2.SumHDH, sl.SoHDDau, sl.SoLuong, sl.ThangNhap,sl.TonDau,sl.NhapMoi,loai.sohieu,sl.LoaiHD,sotra,thangtra,somat,thangmat", sql)
            BCHDQ = sql
            Dim Mientru As String = String.Format("SELECT mact FROM chungtu inner join hoadon on chungtu.sohieu=hoadon.sohd WHERE loai=1 AND {0} group by mact", WThang("thangct", thangdau, thangcuoi))
            DoanhThuQ = String.Format("SELECT sum(sops) AS doanhthu FROM chungtu inner join ({0}) as Mientru on chungtu.mact=Mientru.mact", Mientru)
        Catch exc As System.Exception
            'Resume in On-Error-Resume-Next Block
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="KyHieu"></param>
    ''' <param name="SoHDDau"></param>
    ''' <param name="thangdau"></param>
    ''' <param name="thangcuoi"></param>
    ''' <param name="Min"></param>
    ''' <param name="Max"></param>
    ''' <remarks></remarks>
    Public Sub MinMaxInRange(ByRef KyHieu As String, ByRef SoHDDau As Integer, ByRef thangdau As Integer, ByRef thangcuoi As Integer, ByRef Min As Double, ByRef Max As Double)
        Dim tmp As Integer
        Min = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TonThang{0} AS F1 FROM SLHoaDon WHERE KyHieu=N'{1}' AND SoHDDau={2}", _
                                                  thangdau, _
                                                  KyHieu, _
                                                  ConvertToStrSafe(SoHDDau))))
        Max = Min
        For i As Integer = thangdau + 1 To thangcuoi
            tmp = ConvertToDblSafe(GetSelectValue(String.Format("SELECT TonThang{0} AS F1 FROM SLHoaDon WHERE KyHieu=N'{1}' AND SoHDDau={2}", _
                                                      i, _
                                                      KyHieu, _
                                                      ConvertToStrSafe(SoHDDau))))
            If tmp < Min Then Min = tmp
            If tmp > Max Then Max = tmp
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="szFilePath"></param>
    ''' <remarks></remarks>
    Public Sub OpenExcelApp(ByRef szFilePath As String)
        Dim xlapp As New Excel.Application
        xlapp.Workbooks.Open(szFilePath)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thangdau"></param>
    ''' <param name="thangcuoi"></param>
    ''' <param name="loai"></param>
    ''' <remarks></remarks>
    Public Sub InSLHoaDon(ByRef thangdau As Integer, ByRef thangcuoi As Integer, ByRef loai As Integer)
        Dim RptFilename As String
        Select Case loai
            Case 1
                RptFilename = "BCSLHD.rpt"
            Case 2
                RptFilename = "BCSLHDQ.rpt"
            Case 3
                RptFilename = "BCSLHDN.rpt"
            Case Else
                RptFilename = "BCSLHD.rpt"
        End Select
        If loai = 2 Then
            rptFrom.InitForm(RptFilename, "select t1.*,t2.ten as [baocaocp.ten],t3.ten as [baocaocp2.ten],t4.kho from (((" & BCHDQ & ") as t1 left join baocaocp t2 on t1.kyhieu=t2.sohieu)left join baocaocp2 t3 on t1.kyhieu= t3.sohieu) left join phieunx t4 on t1.kyhieu=t4.sohieu", "QBCHoaDonChiTiet")
        Else
            rptFrom.InitForm(RptFilename, BCHDQ, "QBCHoaDonChiTiet")
        End If


        SetRptInfo()
        rptFrom.SetFormulas("ThangBC", String.Format("'{0}'", thangdau))
        rptFrom.SetFormulas("ThangBCCuoi", String.Format("'{0}'", thangcuoi))
        rptFrom.SetFormulas("Ngay", "'Ngày ....  Tháng ....  Năm ....'")
        rptFrom.SetFormulas("DiachiCTY", String.Format("'{0}'", frmMain._LbCty_2.Text))
        rptFrom.SetFormulas("Thangdauky", String.Format("'{0}'", pThangDauKy))
        rptFrom.ReportWindowTitle = "Bảng báo cáo hoá đơn sử dụng"
        InBaoCaoRPT()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="taikhoan"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="thongbao"></param>
    ''' <param name="doiung"></param>
    ''' <param name="VV"></param>
    ''' <param name="loai"></param>
    ''' <param name="nn"></param>
    ''' <param name="mdt1"></param>
    ''' <param name="mdt2"></param>
    ''' <param name="mdt3"></param>
    ''' <param name="ten"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function InSocaiTk1(ByRef taikhoan As ClsTaikhoan, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef thongbao As Boolean, ByRef doiung As String, ByRef VV As Integer, ByRef loai As Integer, Optional ByRef nn As Integer = 0, Optional ByRef mdt1 As Integer = 0, Optional ByRef mdt2 As Integer = 0, Optional ByRef mdt3 As Integer = 0, Optional ByRef ten As String = "") As Boolean
        Dim result As Boolean = False
        Dim dkc, dkn, dknt As Double
        Dim ps As Boolean
        Dim sqlw As String = String.Empty
        Dim psn, psc As Double
        Dim sql As String = String.Empty
        Dim rs_nk As DataTable
        Dim MaCT As Integer
        With taikhoan
            If tcuoi > 0 Then
                ps = .TkCoPS(tdau, tcuoi)
                .SoDuTK(ThangTruoc(tdau), dkn, dkc, dknt)
                sqlw = WThang("ThangCT", tdau, tcuoi)
            Else
                ps = .TkCoPSN(ndau, ncuoi)
                .SoDuNgay(ndau.AddDays(-1), dkn, dkc, dknt)
                sqlw = WNgay("NgayGS", ndau, ncuoi)
            End If
            'Tạo thứ tự dòng
            sql = String.Format("SELECT DISTINCT max(ChungTu.MaSo) AS MS,ChungTu.MaCT, ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0}, Sum(SoPS) AS SumOfSoPS, HeThongTK.SoHieu AS sohieutk, HeThongTK.Ten{0}, -1 AS LoaiPS FROM {1} WHERE SoPS<>0 AND (MaTKTCNo) > 0 AND (((HeThongTK.loai) > 0) AND ((chungtu.maloai <> 4) OR (chungtu.maloai=4 AND matkno<>matkco)) AND {2}){3}{4}{5}{6} GROUP BY ChungTu.MaCT, ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0}, HeThongTK.SoHieu, HeThongTK.Ten{0} UNION SELECT DISTINCT max(ChungTu.MaSo) AS MS,ChungTu.MaCT, ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0}, Sum(SoPS) AS SumOfSoPS, HeThongTK.SoHieu, HeThongTK.Ten{0}, 1 AS LoaiPS FROM {7} WHERE SoPS<>0 AND (MaTKTCCo) > 0 AND (((HeThongTK.loai) > 0) AND ((chungtu.maloai <> 4) OR (chungtu.maloai=4 AND matkno<>matkco)) AND ({2})){3}{4}{5}{6} GROUP BY ChungTu.MaCT, ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0}, HeThongTK.SoHieu, HeThongTK.Ten{0}", _
                            (IIf(pNN > 0, "E", String.Empty)), _
                            ChungTu2TKNC(-1), _
                            sqlw, _
                            (IIf(VV > 1, String.Format(" AND (ChungTu.MaDT = {0})", VV), String.Empty)), _
                            (IIf(mdt1 > 0, String.Format(" AND (ChungTu.MaDT1 = {0})", mdt1), String.Empty)), _
                            (IIf(mdt2 > 0, String.Format(" AND (ChungTu.MaDT2 = {0})", mdt2), String.Empty)), _
                            (IIf(mdt3 > 0, String.Format(" AND (ChungTu.MaDT3 = {0})", mdt3), String.Empty)), _
                            ChungTu2TKNC(1))
            rs_nk = ExecSQLReturnDT(String.Format("SELECT Mientru.* FROM ({0}) AS  Mientru ORDER BY NgayGS,sohieu,sohieutk,loaips,sumofsops desc", sql))
            If rs_nk.Rows.Count > 0 Then
                ExecSQLNonQuery("DELETE FROM BKNhomPS")
            End If
            Dim rs_nkIndex As Integer = 0
            While rs_nkIndex < rs_nk.Rows.Count
                Dim rs_nkItem As DataRow = rs_nk.Rows(rs_nkIndex)
                rs_nkIndex += 1 ' C15 Rs LOOP CONTROL
                If MaCT <> ConvertToStrSafe(rs_nkItem("MaCT")) Then
                    MaCT = rs_nkItem("MaCT")
                    ExecSQLNonQuery(String.Format("INSERT INTO BKNhomPS(shtk,sohieu) VALUES(N'{0}', N'{1}')", _
                                         ConvertToStrSafe(Lng_MaxValue("maso", "BKNhomPS") + 1), _
                                         ConvertToStrSafe(rs_nkItem("MaCT"))))
                End If
                ExecSQLNonQuery(String.Format("INSERT INTO BKNhomPS(shtk,sohieu,sopsno,mact,ngay,sops2no,sopsco,DienGiai) VALUES( N'{0}', N'{1}',{2},{1}, N'{3}',{4},{5}, N'{6}')", _
                                     ConvertToStrSafe(Lng_MaxValue("maso", "BKNhomPS") + 1), _
                                     ConvertToStrSafe(rs_nkItem("MaCT")), _
                                     ConvertToStrSafe(Lng_MaxValue("sopsno", "BKNhomPS") + 1), _
                                     Format(CDate(rs_nkItem("NgayGS")), Mask_DB), _
                                     ConvertToStrSafe(rs_nkItem("loaips")), _
                                     ConvertToStrSafe(rs_nkItem("sumofsops")), _
                                     ConvertToStrSafe(rs_nkItem("sohieutk"))))
                'rs_nk.MoveNext()
            End While
            ExecSQLNonQuery(String.Format("UPDATE BKNhomPS SET sopsco=0 WHERE LEFT(DienGiai,{0}) =N'{1}'", _
                                 taikhoan.sohieu.Length, _
                                 taikhoan.sohieu))
            'Tạo báo cáo
            If dkn <> 0 Or dkc <> 0 Or ps Then
                If ps Then
                    Dim MienTru1 As String = String.Format("SELECT ChungTu.MaCT, ChungTu.ThangCT, ChungTu.SoHieu as [ChungTu.SoHieu], ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0}, ChungTu.SoPS, ChungTu.{1} AS GhiChu, HeThongTK.SoHieu as [HeThongTK.SoHieu], HeThongTK_1.SoHieu as [HeThongTK_1.SoHieu], ChungTu.MaTKTCNo, ChungTu.MaTKTCCo, {2} + '10' + str(ChungTu.ThangCT) + ChungTu.SoHieu AS SH1 FROM HeThongTK AS HeThongTK_3 RIGHT JOIN (HeThongTK AS HeThongTK_2 RIGHT JOIN (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo) ON HeThongTK_2.MaSo = ChungTu.MaTKNo) ON HeThongTK_3.MaSo = ChungTu.MaTKCo WHERE SoPS<>0 AND ((HethongTK.SoHieu LIKE '{3}%'{4}) OR (HethongTK_1.SoHieu LIKE '{3}%'{5})) AND {6}{7}{8}{9}{10} AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco))", _
                                                 (IIf(pNN > 0, "E", String.Empty)), _
                                                 (IIf(tdau = 0 And tcuoi = 0, "mathuchi", "ghichu")), _
                                                 (IIf(.kieu < 0, String.Format("CASE WHEN HethongTK.SoHieu LIKE '{0}%' THEN '0' ELSE '1' END", .sohieu), String.Format("CASE WHEN HethongTK.SoHieu LIKE '{0}%' THEN '1' ELSE '0' END", .sohieu))), _
                                                 taikhoan.sohieu, _
                                                 (IIf(doiung.Length = 0, "", String.Format(" AND HethongTK_3.SoHieu LIKE '{0}%'", doiung))), _
                                                 (IIf(doiung.Length = 0, "", String.Format(" AND HethongTK_2.SoHieu LIKE '{0}%'", doiung))), _
                                                 sqlw, _
                                                 (IIf(VV > 1, String.Format(" AND (ChungTu.MaDT = {0})", VV), String.Empty)), _
                                                 (IIf(mdt1 > 0, String.Format(" AND (ChungTu.MaDT1 = {0})", mdt1), String.Empty)), _
                                                 (IIf(mdt2 > 0, String.Format(" AND (ChungTu.MaDT2 = {0})", mdt2), String.Empty)), _
                                                 (IIf(mdt3 > 0, String.Format(" AND (ChungTu.MaDT3 = {0})", mdt3), String.Empty)))

                    Dim QNhatky As String = String.Format("SELECT Mientru1.MaCT, Mientru1.ThangCT, Mientru1.[ChungTu.SoHieu], Mientru1.NgayCT, Mientru1.NgayGS, Mientru1.DienGiai, Sum(Mientru1.SoPS) AS SoPS, Mientru1.GhiChu, Mientru1.[HeThongTK.SoHieu] AS sh2, Mientru1.[HeThongTK_1.SoHieu] AS sh3, Mientru1.MaTKTCNo, Mientru1.MaTKTCCo, Mientru1.SH1 FROM ({0}) AS Mientru1 GROUP BY Mientru1.MaCT, Mientru1.ThangCT, Mientru1.[ChungTu.SoHieu], Mientru1.NgayCT, Mientru1.NgayGS, Mientru1.DienGiai, Mientru1.GhiChu, Mientru1.[HeThongTK.SoHieu], Mientru1.[HeThongTK_1.SoHieu], Mientru1.MaTKTCNo, Mientru1.MaTKTCCo, Mientru1.SH1", MienTru1)
                    sql = String.Format("SELECT t1.*,t2.sopsno,t2.maso,CASE WHEN t1.sh2 LIKE '{0}%' THEN sh3 ELSE sh2 END AS doiung FROM ({1}) AS t1 LEFT join bknhomps t2 on t1.mact=t2.mact AND t1.ngaygs=t2.ngay AND (t1.sh2=t2.DienGiai OR t1.sh3=t2.DienGiai) WHERE LEFT(t2.DienGiai,len({0}))<>'{0}' OR (matktcco=0 AND LEFT(t2.DienGiai,len({0}))=N'{0}') OR (matktcno=0 AND LEFT(t2.DienGiai,len({0}))=N'{0}')", _
                                         taikhoan.sohieu, _
                                         QNhatky)
                Else
                    sql = "SELECT DISTINCT 0 AS MaCT,0 AS ThangCT, '' AS SoHieu, Null AS NgayCT, Null AS NgayGS, '' AS DoiUng, '' AS DienGiai, 0 AS SoPS,0 AS SoPSNo,0 AS maso, '' AS GhiChu, '' AS SH1, '' AS SH2, '' AS SH3, 0 AS MaTKTCNo, 0 AS MaTKTCCo FROM ChungTu WHERE (chungtu.MaCT = 0)"
                End If
                If tcuoi > 0 Then
                    RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
                    psn = SoPSTK(taikhoan.sohieu, pThangDauKy, tcuoi, -1)
                    psc = SoPSTK(taikhoan.sohieu, pThangDauKy, tcuoi, 1)
                Else
                    RptSetDate(ncuoi)
                    taikhoan.SoPhatSinhN(NgayDauThang(ncuoi.Year, pThangDauKy), ncuoi, psn, dkn, psc, dkc)
                End If
                OpenBook(String.Format("{0}{1}", pCurDir, ten))
                CopyDataRa1(sql, Strings.Right(ten, ten.Length - 8), tdau, tcuoi, taikhoan, ConvertToDblSafe(CStr(dkn - dkc)), psn, psc)
                CloseBook(String.Format("{0}\REPORTS{1}", pCurDir, ten))
                CallExcel("\TEMP\Socai.xls")
                result = True
            Else
                If thongbao Then MessageBox.Show("Không có số đầu kỳ hoặc phát sinh !", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                result = False
            End If
        End With
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="taikhoan"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="thongbao"></param>
    ''' <param name="doiung"></param>
    ''' <param name="VV"></param>
    ''' <param name="loai"></param>
    ''' <param name="nn"></param>
    ''' <param name="mdt1"></param>
    ''' <param name="mdt2"></param>
    ''' <param name="mdt3"></param>
    ''' <param name="ten"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function InSoQuy(ByRef taikhoan As ClsTaikhoan, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef thongbao As Boolean, ByRef doiung As String, ByRef VV As Integer, ByRef loai As Integer, Optional ByRef nn As Integer = 0, Optional ByRef mdt1 As Integer = 0, Optional ByRef mdt2 As Integer = 0, Optional ByRef mdt3 As Integer = 0, Optional ByRef ten As String = "") As Boolean
        Dim result As Boolean = False
        Dim dkc, dkn, dknt As Double
        Dim ps As Boolean
        Dim sqlw As String = String.Empty
        Dim sql As String = String.Empty
        With taikhoan
            If tcuoi > 0 Then
                ps = .TkCoPS(tdau, tcuoi)
                .SoDuTK(ThangTruoc(tdau), dkn, dkc, dknt)
                sqlw = WThang("ThangCT", tdau, tcuoi)
            Else
                ps = .TkCoPSN(ndau, ncuoi)
                .SoDuNgay(ndau.AddDays(-1), dkn, dkc, dknt)
                sqlw = WNgay("NgayGS", ndau, ncuoi)
            End If
            'Tạo báo cáo
            If dkn <> 0 Or dkc <> 0 Or ps Then
                If ps Then
                    sql = String.Format("SELECT DISTINCT ChungTu.MaCT, ChungTu.ThangCT, ChungTu.SoHieu, ChungTu.NgayCT, ChungTu.NgayGS, ChungTu.DienGiai{0}, ChungTu.SoPS, ChungTu.{1} AS GhiChu, HeThongTK.SoHieu AS sh2, HeThongTK_1.SoHieu AS sh3, ChungTu.MaTKTCNo, ChungTu.MaTKTCCo, {2}+str(10+ChungTu.ThangCT)+ChungTu.SoHieu AS SH1 FROM HeThongTK AS HeThongTK_3 RIGHT JOIN (HeThongTK AS HeThongTK_2 RIGHT JOIN (HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKTCNo) ON HeThongTK_1.MaSo = ChungTu.MaTKTCCo) ON HeThongTK_2.MaSo = ChungTu.MaTKNo) ON HeThongTK_3.MaSo = ChungTu.MaTKCo WHERE SoPS<>0 AND ((HethongTK.SoHieu LIKE '{3}%'{4}) OR (HethongTK_1.SoHieu LIKE '{3}%'{5})) AND {6}{7}{8}{9}{10} AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco))", _
                                         (IIf(pNN > 0, "E", String.Empty)), _
                                         (IIf(tdau = 0 And tcuoi = 0, "mathuchi", "ghichu")), _
                                         (IIf(.kieu < 0, String.Format("CASE WHEN HethongTK.SoHieu LIKE '{0}%' THEN '0' ELSE '1' END", .sohieu), String.Format(" CASE WHEN HethongTK.SoHieu LIKE '{0}%' THEN '1' ELSE '0' END", .sohieu))), _
                                         taikhoan.sohieu, _
                                         (IIf(doiung.Length = 0, "", String.Format(" AND HethongTK_3.SoHieu LIKE '{0}%'", doiung))), _
                                         (IIf(doiung.Length = 0, "", String.Format(" AND HethongTK_2.SoHieu LIKE '{0}%'", doiung))), _
                                         sqlw, _
                                         (IIf(VV > 1, String.Format(" AND (ChungTu.MaDT = {0})", VV), String.Empty)), _
                                         (IIf(mdt1 > 0, String.Format(" AND (ChungTu.MaDT1 = {0})", mdt1), String.Empty)), _
                                         (IIf(mdt2 > 0, String.Format(" AND (ChungTu.MaDT2 = {0})", mdt2), String.Empty)), _
                                         (IIf(mdt3 > 0, String.Format(" AND (ChungTu.MaDT3 = {0})", mdt3), String.Empty)), _
                                         (IIf(.kieu < 0, String.Format("CASE WHEN HethongTK.SoHieu LIKE '{0}%' THEN '0' ELSE '1' END", .sohieu), String.Format("CASE WHEN HethongTK.SoHieu LIKE '{0}%' THEN '1' ELSE '0' END", .sohieu))))
                Else
                    sql = "SELECT DISTINCT 0 AS MaCT,0 AS ThangCT, '' AS SoHieu, Null AS NgayCT, Null AS NgayGS, '' AS DienGiai, 0 AS SoPS,'' AS GhiChu, '' AS SH1, '' AS SH2, '' AS SH3, 0 AS MaTKTCNo, 0 AS MaTKTCCo FROM ChungTu WHERE (chungtu.MaCT = 0)"
                End If
                OpenBook(String.Format("{0}{1}", pCurDir, ten))
                CopySoQuy(Strings.Right(ten, ten.Length - 8), tdau, tcuoi, taikhoan, ConvertToDblSafe(CStr(dkn - dkc)), ndau, ncuoi, sql)
                CloseBook(String.Format("{0}{1}", pCurDir, ten))
                CallExcel("\TEMP\Soquy.xls")
                result = True
            Else
                If thongbao Then MessageBox.Show("Không có số đầu kỳ hoặc phát sinh !", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                result = False
            End If
        End With
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ten"></param>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="VV"></param>
    ''' <param name="dktg"></param>
    ''' <param name="ndau"></param>
    ''' <param name="ncuoi"></param>
    ''' <param name="nn"></param>
    ''' <param name="p"></param>
    ''' <param name="mdt1"></param>
    ''' <param name="mdt2"></param>
    ''' <param name="mdt3"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function InNhatKy1(ByRef ten As String, ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef VV As Integer, ByRef dktg As Integer, ByRef ndau As Date, ByRef ncuoi As Date, ByRef nn As Integer, Optional ByRef p As Integer = 0, Optional ByRef mdt1 As Integer = 0, Optional ByRef mdt2 As Integer = 0, Optional ByRef mdt3 As Integer = 0, Optional ByRef sapxep As Integer = 1) As Boolean
        Dim sqlw As String = String.Empty
        Dim sh As String = IIf(p > 0, "P", String.Empty)
        If dktg = 0 Then
            sqlw = WThang("ThangCT", tdau, tcuoi)
            RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
        Else
            sqlw = WNgay("NgayGS", ndau, ncuoi)
            RptSetDate(ncuoi)
        End If
        Dim sql As String = String.Format("SELECT DISTINCT (ChungTu{0}.MaSo) AS MS,ChungTu{0}.MaCT, ChungTu{0}.SoHieu AS [ChungTu.SoHieu], ChungTu{0}.NgayCT, ChungTu{0}.NgayGS, ChungTu{0}.DienGiai{1}, Sum(SoPS) AS SumOfSoPS, HeThongTK.SoHieu AS [HeThongTK.SoHieu], HeThongTK.Ten{1}, -1 AS LoaiPS FROM {2} WHERE SoPS<>0 AND (MaTKTCNo) > 0 AND (((HeThongTK.loai) > 0) AND ((chungtu{0}.maloai <> 4) OR (chungtu{0}.maloai=4 AND matkno<>matkco)) AND {3}){4}{5}{6}{7} GROUP BY ChungTu{0}.MaCT,ChungTu{0}.MaSo, ChungTu{0}.SoHieu, ChungTu{0}.NgayCT, ChungTu{0}.NgayGS, ChungTu{0}.DienGiai{1}, HeThongTK.SoHieu, HeThongTK.Ten{1} UNION SELECT DISTINCT (ChungTu{0}.MaSo) AS MS,ChungTu{0}.MaCT, ChungTu{0}.SoHieu, ChungTu{0}.NgayCT, ChungTu{0}.NgayGS, ChungTu{0}.DienGiai{1}, Sum(SoPS) AS SumOfSoPS, HeThongTK.SoHieu, HeThongTK.Ten{1}, 1 AS LoaiPS FROM {8} WHERE SoPS<>0 AND (MaTKTCCo) > 0 AND (((HeThongTK.loai) > 0) AND ((chungtu{0}.maloai <> 4) OR (chungtu{0}.maloai=4 AND matkno<>matkco)) AND ({3})){4}{5}{6}{7} GROUP BY ChungTu{0}.MaCT,ChungTu{0}.MaSo, ChungTu{0}.SoHieu, ChungTu{0}.NgayCT, ChungTu{0}.NgayGS, ChungTu{0}.DienGiai{1}, HeThongTK.SoHieu, HeThongTK.Ten{1}", _
                                sh, _
                                (IIf(pnn > 0, "E", String.Empty)), _
                                ChungTu2TKNC(-1, p), _
                                sqlw, _
                                (IIf(VV > 1, String.Format(" AND (ChungTu{0}.MaDT = {1})", sh, ConvertToStrSafe(VV)), String.Empty)), _
                                (IIf(mdt1 > 0, String.Format(" AND (ChungTu{0}.MaDT1 = {1})", sh, ConvertToStrSafe(mdt1)), String.Empty)), _
                                (IIf(mdt2 > 0, String.Format(" AND (ChungTu{0}.MaDT2 = {1})", sh, ConvertToStrSafe(mdt2)), String.Empty)), _
                                (IIf(mdt3 > 0, String.Format(" AND (ChungTu{0}.MaDT3 = {1})", sh, ConvertToStrSafe(mdt3)), String.Empty)), _
                                ChungTu2TKNC(1, p))


        sql = String.Format("SELECT Mientru.* FROM ({0}) AS Mientru", sql)
        If sapxep = 1 Then sql = sql & " ORDER BY Mientru.NgayGS,Mientru.[ChungTu.SoHieu],Mientru.[HeThongTK.SoHieu],Mientru.loaips,Mientru.sumofsops desc"
        OpenBook(String.Format("{0}{1}", pCurDir, ten))
        CopyDataRa2(ten.Substring(8 + CInt(Ngonngu("0", "1"))), tdau, tcuoi, sql)
        CloseBook(String.Format("{0}{1}", pCurDir, ten))
        CallExcel("\TEMP\Nhatky.xls")
        Return True
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Public Sub CopyBC26(ByRef tdau As Integer, ByRef tcuoi As Integer)
        Dim curSheet As Excel.Worksheet
        Dim rs, rs1 As DataTable
        Dim RowIdx As Integer
        Dim x2, X1, x3 As String
        Dim x4, x5 As Double
        Dim i As Integer
        Dim x10, x8, x6, x7, x9, x11, x17, x12, x13, x19 As Double
        Dim x14, x18 As String
        Dim x20, x21, S17, S12, S8, S6, S7, S11, S13, S21 As Double
        Select Case Information.Err().Number
            Case Is < 0
                Conversion.ErrorToString(5)
            Case 1
                Exit Sub
        End Select
        Try
            Kill(String.Format("{0}\temp\BC26.xls", pCurDir))
        Catch
        End Try
        'Process.Start(String.Format("cmd /c ""del {0}BC26.xls""", pCurDir))
        With Excel_Global.ActiveWorkbook
            curSheet = Excel_Global.Worksheets(1)
            RowIdx = 12
            Dim STR As String = String.Format("SELECT loai.ten, loai.sohieu, ct.KyHieu, ct.SoHDDau, ct.SoHDCuoi, ct.TonThangTruoc, ct.NhapMoi,(ct.TonThangTruoc+ ct.NhapMoi) AS tong8, ct.SumHDSD AS sudung, ct.SumHDH AS huy,CASE WHEN(ct.thangtra>={0} AND ct.thangtra<={1}0) THEN ct.sotra ELSE 0 END AS tra FROM (" & BCHDQ & ") ct inner join loaihoadon loai on ct.loaihd=loai.maso group by loai.ten, loai.sohieu, ct.KyHieu, ct.SoHDDau, ct.SoHDCuoi, ct.TonThangTruoc, ct.NhapMoi,(ct.TonThangTruoc+ ct.NhapMoi), ct.SumHDSD, ct.SumHDH,CASE WHEN(ct.thangtra>={2} AND ct.thangtra<={1}) THEN  ct.sotra ELSE 0 END", _
                                     tdau, _
                                     ConvertToStrSafe(tcuoi), _
                                     ConvertToStrSafe(tdau))
            rs = ExecSQLReturnDT(String.Format("SELECT loai.ten, loai.sohieu, ct.KyHieu, ct.SoHDDau, ct.SoHDCuoi, ct.TonThangTruoc, ct.NhapMoi,(ct.TonThangTruoc+ ct.NhapMoi) AS tong8, ct.SumHDSD AS sudung, ct.SumHDH AS huy,CASE WHEN(ct.thangtra>={0} AND ct.thangtra<={1}0) THEN ct.sotra ELSE 0 END AS tra FROM (" & BCHDQ & ") ct inner join loaihoadon loai on ct.loaihd=loai.maso group by ct.thangtra,ct.sotra, loai.ten, loai.sohieu, ct.KyHieu, ct.SoHDDau, ct.SoHDCuoi, ct.TonThangTruoc, ct.NhapMoi,(ct.TonThangTruoc+ ct.NhapMoi), ct.SumHDSD, ct.SumHDH,CASE WHEN(ct.thangtra>={2} AND ct.thangtra<={1}) THEN  ct.sotra ELSE 0 END", _
                                     tdau, _
                                     ConvertToStrSafe(tcuoi), _
                                     ConvertToStrSafe(tdau)))
            If rs.Rows.Count > 1 Then
                curSheet.Range(String.Format("{0}:{1}", ConvertToStrSafe(RowIdx + 1), ConvertToStrSafe(RowIdx + rs.Rows.Count - 2 + 1))).EntireRow.Insert()
            End If
            Dim rsIndex As Integer = 0
            While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                x12 = IIf(Not IsDBNull(rsItem("sudung")), ConvertToDblSafe(rsItem("sudung")), 0)
                x13 = IIf(Not IsDBNull(rsItem("huy")), ConvertToDblSafe(rsItem("huy")), 0)
                x17 = ConvertToDblSafe(rsItem("tra"))
                x11 = x12 + x13 + x17
                X1 = rsItem("ten")
                x2 = rsItem("SoHieu")
                x3 = rsItem("KyHieu")
                x4 = ConvertToDblSafe(rsItem("SoHDDau"))
                x5 = ConvertToDblSafe(rsItem("sohdcuoi"))
                x6 = ConvertToDblSafe(rsItem("tonthangtruoc"))
                x7 = ConvertToDblSafe(rsItem("NhapMoi"))
                x8 = ConvertToDblSafe(rsItem("tong8"))
                x9 = IIf(x11 > 0, x4, 0) : x10 = IIf(x11 > 0, x4 + x11 - 1, 0)
                x19 = x4 + x11 : x20 = x5 : x21 = x8 - x11
                If x19 > x20 Then
                    x19 = 0 : x20 = 0
                End If
                x14 = ""
                If x13 > 0 Then
                    rs1 = ExecSQLReturnDT(String.Format("SELECT hd.sohd FROM hoadon hd inner join chungtu ct on hd.sohd=ct.sohieu WHERE hd.thanhtien=0 AND hd.kyhieu=N'{0}' AND {1} group by hd.sohd", _
                                              x3, _
                                              WThang("ct.thangct", tdau, tcuoi)))
                    Dim rs1Index As Integer = 0
                    While rs1Index < rs1.Rows.Count
                        Dim rs1Item As DataRow = rs1.Rows(rs1Index)
                        rs1Index += 1 ' C15 Rs LOOP CONTROL
                        x14 = String.Format("{0}{1},", x14, ConvertToStrSafe(rs1("sohd")))
                        'rs1.MoveNext()
                    End While
                    x14 = Strings.Left(x14, x14.Length - 1)
                End If
                x18 = ""
                If x17 > 0 Then
                    i = 0
                    While i < x17
                        x18 = String.Format("{0}{1},", x18, ConvertToStrSafe(x10 - i))
                        i += 1
                    End While
                    x18 = Strings.Left(x18, x18.Length - 1)
                End If
                S6 += x6
                S7 += x7
                S8 += x8
                S11 += x11
                S12 += x12
                S13 += x13
                S17 += x17
                S21 += x21
                curSheet.Cells(RowIdx, 3).Value = X1
                curSheet.Cells(RowIdx, 4).Value = x2
                curSheet.Cells(RowIdx, 5).Value = x3
                curSheet.Cells(RowIdx, 6).Value = x4
                curSheet.Cells(RowIdx, 7) = x5
                curSheet.Cells(RowIdx, 8).Value = x6
                curSheet.Cells(RowIdx, 9).Value = x7
                curSheet.Cells(RowIdx, 10).Value = x8
                curSheet.Cells(RowIdx, 11).Value = x9
                curSheet.Cells(RowIdx, 12) = x10
                curSheet.Cells(RowIdx, 13).Value = x11
                curSheet.Cells(RowIdx, 14).Value = x12
                curSheet.Cells(RowIdx, 15).Value = x13
                curSheet.Cells(RowIdx, 16).Value = x14
                curSheet.Cells(RowIdx, 19) = x17
                curSheet.Cells(RowIdx, 20).Value = x18
                curSheet.Cells(RowIdx, 21).Value = x19
                curSheet.Cells(RowIdx, 22).Value = x20
                curSheet.Cells(RowIdx, 23) = x21
                RowIdx += 1
                ''rs.MoveNext()
            End While
            curSheet.Cells(RowIdx, 8).Value = S6
            curSheet.Cells(RowIdx, 9).Value = S7
            curSheet.Cells(RowIdx, 10) = S8
            curSheet.Cells(RowIdx, 13).Value = S11
            curSheet.Cells(RowIdx, 14).Value = S12
            curSheet.Cells(RowIdx, 15) = S13
            curSheet.Cells(RowIdx, 19).Value = S17
            curSheet.Cells(RowIdx, 23) = S21
            curSheet.SaveAs(pCurDir & "\temp\BC26.xls")
            CloseBook(String.Format("{0}\temp\BC26.xls", pCurDir))
        End With
    End Sub
    'Public Function PrintSQLHoadontuin(ByVal report As XtraReport1, ByVal rs As DataTable, ByVal curSheet As Excel.Worksheet, ByVal RowIdx As Integer, ByRef StartCol As Integer, Optional ByRef thutu As Integer = 0) As Integer
    '    Dim dongdau As Integer = 0, dvt As String = "", tongtien As Double = 0, tienthue As Double = 0
    '    Dim hoadon As New HoaDonAdap
    '    If rs.Rows.Count > 0 Then
    '        Dim rsIndex As Integer = 0, co As Integer = 0
    '        curSheet.Cells(2, 6).Value = frmMain._LbCty_0.Text 'Don vi
    '        curSheet.Cells(3, 6).Value = curSheet.Cells(3, 6).Value + " " + frmMain._LbCty_8.Text 'MST
    '        curSheet.Cells(4, 6).Value = curSheet.Cells(4, 6).Value + " " + frmMain._LbCty_13.Text 'Dia chi
    '        curSheet.Cells(6, 6).Value = curSheet.Cells(6, 6).Value + " " + frmMain._LbCty_3.Text 'Dien Thoai
    '        curSheet.Cells(6, 9).Value = curSheet.Cells(6, 9).Value + " " + frmMain._LbCty_4.Text 'Fax
    '        curSheet.Cells(7, 6).Value = curSheet.Cells(7, 6).Value + " " + frmMain._LbCty_9.Text 'Email
    '        curSheet.Cells(8, 6).Value = curSheet.Cells(8, 6).Value + " " + frmMain._Label_7.Text 'Tai khoan

    '        While rsIndex < rs.Rows.Count
    '            Dim rsItem As DataRow = rs.Rows(rsIndex)
    '            rsIndex += 1 ' C15 Rs LOOP CONTROL
    '            If rsItem("SoHieu") Like "511*" Then
    '                If thutu > 0 And StartCol > 1 Then
    '                    If dongdau = 0 Then
    '                        curSheet.Cells(RowIdx, StartCol - 2) = 1
    '                        dongdau = 1
    '                    Else
    '                        curSheet.Cells(RowIdx, StartCol - 2) = curSheet.Cells(RowIdx - 1, StartCol - 2).text + 1
    '                        co = 1
    '                    End If
    '                End If
    '                curSheet.Cells(RowIdx, StartCol).Value = GetSelectValue("select TenVattu as f1, DonVi as f2 from Vattu where MaSo = " + CStr(rsItem("SoHieuVT")), dvt)
    '                If dvt = "0" Then dvt = GetSelectValue("select DonVi as f1 from DVTVattu where MaSo = " + CStr(rsItem("donvitinh")))
    '                curSheet.Cells(RowIdx, StartCol + 3).Value = dvt
    '                curSheet.Cells(RowIdx, StartCol + 4).Value = rsItem("SoLuong")
    '                curSheet.Cells(RowIdx, StartCol + 5).Value = rsItem("DonGia")
    '                curSheet.Cells(RowIdx, StartCol + 6).Value = rsItem("SoPS2Co")
    '                tongtien += rsItem("SoPS2Co")
    '                RowIdx += 1
    '            ElseIf rsItem("SoHieu") Like "333*" Then
    '                Dim tab1 As DataTable = hoadon.TimHoaDonTheoMaSoChungTu(rs.Rows(0)("maso"))
    '                If tab1.Rows.Count > 0 Then
    '                    curSheet.Cells(10, 10).Value = IF0005.mau_hd
    '                    curSheet.Cells(11, 10).Value = tab1.Rows(0)("KyHieu")
    '                    curSheet.Cells(12, 10).Value = "'" + ConvertToStrSafe(tab1.Rows(0)("SoHD"))
    '                    curSheet.Cells(13, 5).Value = curSheet.Cells(13, 5).Value + " " + (ReportHoaDonGTGT.lien & ": ")
    '                    curSheet.Cells(16, 3).Value = curSheet.Cells(16, 3).Value + " " + FrmIN.ten_mua_hang
    '                    curSheet.Cells(17, 3).Value = curSheet.Cells(17, 3).Value + " " + tab1.Rows(0)("Ten")
    '                    curSheet.Cells(18, 3).Value = curSheet.Cells(18, 3).Value + " " + tab1.Rows(0)("MST")
    '                    curSheet.Cells(19, 3).Value = curSheet.Cells(19, 3).Value + " " + tab1.Rows(0)("DiaChi")
    '                    curSheet.Cells(20, 3).Value = curSheet.Cells(20, 3).Value + " " + FrmIN.hinhthuc
    '                    curSheet.Cells(20, 8).Value = curSheet.Cells(20, 8).Value + " " + tab1.Rows(0)("TaiKhoan")
    '                End If
    '                Dim sql As String = "select Mucdich, Mau,hinh_logo,logo_nen,hinh_nen,size,font from CT_MAUHOADON where ID ='" & IF0005.ma_hd & "' and Lien = " & ReportHoaDonGTGT.lien
    '                tab1 = ExecSQLReturnDT(sql)
    '                If tab1.Rows.Count > 0 Then
    '                    'set background
    '                    Dim u1 As New Utilities
    '                    u1.ConvertBytesToImage(tab1.Rows(0)("hinh_nen"))
    '                    Dim hinh As Bitmap = u1.ConvertBytesToImage(tab1.Rows(0)("hinh_nen"))
    '                    Dim hinhsau As New Bitmap(700, 1050)
    '                    Dim b As Graphics = Graphics.FromImage(hinhsau)
    '                    b.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
    '                    b.DrawImage(hinh, New Rectangle(0, 0, 700, 1050), New Rectangle(0, 0, hinh.Width, hinh.Height), GraphicsUnit.Pixel)
    '                    b.Dispose()
    '                    hinh.Dispose()
    '                    hinhsau.Save(pCurDir + "\temp\nen.jpg")
    '                    hinhsau.Dispose()
    '                    curSheet.SetBackgroundPicture(pCurDir + "\temp\nen.jpg")

    '                    'set logo
    '                    u1.ConvertBytesToImage(tab1.Rows(0)("hinh_logo"))
    '                    hinh = u1.ConvertBytesToImage(tab1.Rows(0)("hinh_logo"))
    '                    hinhsau = New Bitmap(70, 105)
    '                    b = Graphics.FromImage(hinhsau)
    '                    b.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
    '                    b.DrawImage(hinh, New Rectangle(0, 0, 70, 105), New Rectangle(0, 0, hinh.Width, hinh.Height), GraphicsUnit.Pixel)
    '                    b.Dispose()
    '                    hinh.Dispose()
    '                    hinhsau.Save(pCurDir + "\temp\logo.jpg")
    '                    curSheet.Shapes.AddPicture(pCurDir + "\temp\logo.jpg", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoTrue, 32, 22, 100, 92)
    '                    hinhsau.Dispose()

    '                    'lien su dung
    '                    curSheet.Cells(13, 5).Value = curSheet.Cells(13, 5).Value + tab1.Rows(0)("Mucdich")
    '                End If
    '                If FrmIN.ngay_ct = "" Then
    '                    curSheet.Cells(14, 5).Value = "Ngày(Day) " + CStr(Date.Now.Day) + " tháng(month) " + CStr(Date.Now.Month) + " năm(year) " + CStr(Date.Now.Year)
    '                Else
    '                    curSheet.Cells(14, 5).Value = "Ngày(Day) " + CStr(FrmIN.ngay_ct.Substring(0, 2)) + " tháng(month) " + CStr(FrmIN.ngay_ct.Substring(3, 2)) + " năm(year) 20" + CStr(FrmIN.ngay_ct.Substring(FrmIN.ngay_ct.Length - 2))
    '                End If
    '                tienthue = rsItem("SoPS2Co")
    '                curSheet.Cells(39, StartCol + 6).Value = tienthue
    '                curSheet.Cells(39, 3).Value = curSheet.Cells(39, 3).Value + " " + CStr(rsItem("SoPS2Co") * 100 / tongtien) + " %"
    '            End If
    '        End While
    '        curSheet.Cells(41, 3).Value = curSheet.Cells(41, 23).Value + ToVNText(tongtien + tienthue) + "."
    '    End If
    '    Return RowIdx
    'End Function

    'Public Sub CopyHoadontuin(ByVal report As XtraReport1, ByVal mact As Long, Optional ByVal ten As String = "")
    '    Dim curSheet As Excel.Worksheet
    '    Dim dong As Integer
    '    Dim tb As New DataTable
    '    ten = ten + CStr(report.sohoadon)
    '    Try
    '        Kill(String.Format("{0}\temp\{1}.xls", pCurDir, ten))
    '    Catch
    '    End Try
    '    With Excel_Global.ActiveWorkbook
    '        curSheet = Excel_Global.Worksheets(1)
    '        tb = report.chungtu.HienThiChungTuTheoMaCT(mact)
    '        dong = 23
    '        dong = PrintSQLHoadontuin(report, tb, curSheet, dong, 4, 1)

    '        curSheet.SaveAs(String.Format("{0}\temp\{1}.xls", pCurDir, ten))
    '        CloseBook(String.Format("{0}\temp\{1}.xls", pCurDir, ten))
    '    End With
    'End Sub

    Public Function THPSNhomCN2Excel(ByVal tdau As Integer, ByVal tcuoi As Integer, Optional ByVal nn As Integer = 0) As Boolean
        Try
            Dim rs As DataTable, taikhoan As New ClsTaikhoan, psn2 As Double, psc2 As Double, kh As New clsKhachHang
            Dim dkn As Double, dkc As Double, dknt As Double, psn As Double, psc As Double, ckn As Double, ckc As Double, cknt As Double
            Dim rs_tk As DataTable, sql As String, s As String

            THPSNhomCN2Excel = False
            ExecSQLNonQuery("DELETE FROM BKNhomPS")
            rs = ExecSQLReturnDT("SELECT DISTINCT MaTaiKhoan,makhachhang FROM SoDuKhachHang")

            For Each rsitem As DataRow In rs.Rows
                taikhoan.InitTaikhoanMaSo(rsitem("MaTaiKhoan"))
                kh.InitKhachHangMaSo(rsitem("MaKhachHang"))
                kh.SoDuKH(ThangTruoc(tdau), dkn, dkc, dknt, rsitem("MaTaiKhoan"))
                psn = 0
                psc = 0
                psn2 = 0
                psc2 = 0
                ExecSQLNonQuery("INSERT INTO BKNhomPS (MaCT,ShTK,SoPSNo,SoPSCo,DienGiai,SoPS2No,SoPS2Co,shvt) VALUES (-1,'" & taikhoan.sohieu & "'," _
                    & doidau(IIf(dkn - dkc > 0, dkn - dkc, 0)) & "," & doidau(IIf(dkc - dkn > 0, dkc - dkn, 0)) & ",N'" & IIf(nn > 0, taikhoan.TenE, taikhoan.ten) & "'," & doidau(IIf(dkn - dkc > 0, dknt, 0)) & "," & doidau(IIf(dkc - dkn > 0, dknt, 0)) & ",'" & CStr(kh.SoHieu) & "')")

                sql = "SELECT DISTINCT ChungTu.MaCT,ChungTu.SoHieu,ChungTu.NgayCT,ChungTu.DienGiai" & IIf(nn > 0, "E", "") & " AS DG,ChungTu.SoPS,case when " & CStr(kh.MaNT) & ">0 then SoPS2No else 0 end AS SoPS2N,case when " & CStr(kh.MaNT) & ">0 then SoPS2Co else 0 end AS SoPS2C,HethongTK.SoHieu As SHNo, HethongTK_1.SoHieu As SHCo,MaKH" _
                    & " FROM HeThongTK AS HeThongTK_1 RIGHT JOIN (HeThongTK INNER JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo) ON HeThongTK_1.MaSo = ChungTu.MaTKCo" _
                    & " Where (MaTKNo=" & CStr(rsitem("MaTaiKhoan")) & ") AND (MaKH=" & CStr(kh.MaSo) & ") AND " & WThang("ThangCT", tdau, tcuoi) & " AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco)) ORDER BY ChungTu.NgayCT, ChungTu.MaCT"
                rs_tk = ExecSQLReturnDT(sql)
                For Each rsitem_tk As DataRow In rs_tk.Rows
                    psn = psn + rsitem_tk("sops")
                    psn2 = psn2 + rsitem_tk("SoPS2N")
                    If IsDBNull(rsitem_tk("shco")) Then s = "..." Else s = rsitem_tk("shco")
                    ExecSQLNonQuery("INSERT INTO BKNhomPS (MaCT,ShTK,SoPSNo,Ngay,SoHieu,DienGiai,ShDu,SoPS2No,shvt) VALUES (" & CStr(rsitem_tk!MaCT) & ",'" & taikhoan.sohieu & "'," & doidau(rsitem_tk!sops) _
                        & ",'" & Format(CDate(rsitem_tk("NgayCT")), Mask_DB) & "','" & rsitem_tk!SoHieu & "',N'" & rsitem_tk!dg & "','" & s & "'," & doidau(rsitem_tk!SoPS2N) & ",'" & CStr(kh.SoHieu) & "')")
                Next
                sql = "SELECT DISTINCT ChungTu.MaCT,ChungTu.SoHieu,ChungTu.NgayCT,ChungTu.DienGiai" & IIf(nn > 0, "E", "") & " AS DG,ChungTu.SoPS,case when " & CStr(kh.MaNT) & ">0 then SoPS2No else 0 end AS SoPS2N,case when " & CStr(kh.MaNT) & ">0 then SoPS2Co else 0 end AS SoPS2C,HethongTK.SoHieu As SHNo, HethongTK_1.SoHieu As SHCo,MaKH,MaKHC" _
                    & " FROM HeThongTK AS HeThongTK_1 INNER JOIN (HeThongTK RIGHT JOIN ChungTu ON HeThongTK.MaSo = ChungTu.MaTKNo) ON HeThongTK_1.MaSo = ChungTu.MaTKCo" _
                    & " Where (MaTKCo=" & CStr(rsitem("MaTaiKhoan")) & ") AND (MaKHC=" & CStr(kh.MaSo) & ") AND " & WThang("ThangCT", tdau, tcuoi) & " AND (Chungtu.MaLoai<>4 OR (Chungtu.MaLoai=4 AND Chungtu.MaTKNo<>Chungtu.MaTkco)) ORDER BY ChungTu.NgayCT, ChungTu.MaCT"
                rs_tk = ExecSQLReturnDT(sql)
                For Each rsitem_tk As DataRow In rs_tk.Rows
                    psc = psc + rsitem_tk("sops")
                    psc2 = psc2 + rsitem_tk("SoPS2C")
                    If IsDBNull(rsitem_tk("shno")) Then s = "..." Else s = rsitem_tk("shno")
                    ExecSQLNonQuery("INSERT INTO BKNhomPS (MaCT,ShTK,SoPSCo,Ngay,SoHieu,DienGiai,ShDu,SoPS2Co,shvt) VALUES (" & CStr(rsitem_tk("MaCT")) & ",'" & taikhoan.sohieu & "'," & doidau(rsitem_tk("sops")) _
                        & ",'" & Format(CDate(rsitem_tk("NgayCT")), Mask_DB) & "','" & rsitem_tk("SoHieu") & "',N'" & rsitem_tk("dg") & "','" & s & "'," & doidau(rsitem_tk("SoPS2C")) & ",'" & CStr(kh.SoHieu) & "')")
                Next
                ckn = dkn - dkc + psn - psc
                If ckn > 0 Then
                    ckc = 0
                Else
                    ckc = -ckn
                    ckn = 0
                End If
                cknt = IIf(ckc - ckn < 0, dknt + psn2 - psc2, dknt - psn2 + psc2)

                ExecSQLNonQuery("INSERT INTO BKNhomPS (MaCT,ShTK,SoPSNo,SoPSCo,DienGiai,SoPS2No,SoPS2Co,shvt) VALUES (0,'" & taikhoan.sohieu & "'," _
                & doidau(IIf(ckn - ckc > 0, ckn - ckc, 0)) & "," & doidau(IIf(ckc - ckn > 0, ckc - ckn, 0)) & ",N'" & IIf(nn > 0, taikhoan.TenE, taikhoan.ten) & "'," & doidau(IIf(ckn - ckc > 0, cknt, 0)) & "," & doidau(IIf(ckc - ckn > 0, cknt, 0)) & ",'" & CStr(kh.SoHieu) & "')")

                If dkn = 0 And dkc = 0 And psn = 0 And psc = 0 And psn2 = 0 And psc2 = 0 Then ExecSQLNonQuery("DELETE FROM BKNhomPS WHERE ShTK='" + kh.SoHieu + "'")
KhongIn:
            Next
            taikhoan = Nothing
            kh = Nothing
            Return (rs.Rows.Count > 0)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Function

    Public Sub Copycongno(ByVal tdau As Integer, ByVal tcuoi As Integer, ByVal ten As String)
        Dim curSheet As Excel.Worksheet, rs As DataTable
        Dim trang As Integer

        Try
            Kill(pCurDir & ten)
        Catch
        End Try
        Try
            trang = 1
            With Excel_Global.ActiveWorkbook
                rs = ExecSQLReturnDT("select shvt, shtk from BKNhomPS group by shvt, shtk having sum(sopsno)>0 or sum(sopsco)>0 or sum(sops2no)>0 or sum(sops2co)>0 order by shvt, shtk")
                curSheet = Excel_Global.Worksheets(trang)
                For Each rsitem As DataRow In rs.Rows
                    If CStr(rsitem("shtk")).Length >= 3 Then
                        curSheet = Excel_Global.Worksheets(trang)
                        curSheet.Copy(, .Sheets(trang))
                        curSheet.Name = Replace(Replace(Replace(Replace(Replace(Replace(Replace(CStr(rsitem("shvt")), ":", ""), "\", ""), "/", ""), "[", ""), "]", ""), "?", ""), "*", "") & " - " & rsitem("shtk").ToString.Substring(0, 3)
                        trang = trang + 1
                        curSheet.Cells(1, 2) = pTenCty
                        curSheet.Cells(2, 2) = "'" + CStr(pTenCn)
                        curSheet.Cells(5, 2) = rsitem("shtk").ToString.Substring(0, 3) & " - " & CStr(rsitem("shvt")) & " - " & CStr(GetSelectValue("select ten as f1 from khachhang where sohieu like '" + CStr(rsitem("shvt")) + "'"))
                        HienThongBao(curSheet.Cells(5, 2).Value, 1)
                        If tdau = tcuoi Then
                            curSheet.Cells(4, 2) = "Tháng " + CStr(tdau) + " năm " + CStr(pNamTC)
                        Else
                            curSheet.Cells(4, 2) = "Từ tháng " + CStr(tdau) + " đến tháng " + CStr(tcuoi) + " năm " + CStr(pNamTC)
                        End If
                        PrintSQLCN("select mact,sohieu,ngay,case when mact=-1 then N'Số dư đầu kỳ' else case when mact=0 then N'Số dư cuối kỳ' else DienGiai end end as dg , shdu, sopsno, sopsco, '0' as dups, case when mact>0 then sops2no else 0 end as ps2no, case when mact>0 then sops2co else 0 end as ps2co, case when mact>0 then sops2no else 0 end - case when mact>0 then sops2no else 0 end as du,shtk from BKNhomPS where shtk like '" & CStr(rsitem("shtk")) & "' and shvt like '" & CStr(rsitem("shvt")) & "' and mact<>0 order by ngay", curSheet, 8, 1)
                    End If                    
                Next

                'Luy ke
                Dim st As String, sqlc As String = String.Empty, sqln2 As String = String.Empty, sqlc2 As String = String.Empty, i As Integer
                Dim sqlnx As String = String.Empty, sqlcx As String = String.Empty, sqlnx2 As String = String.Empty, sqlcx2 As String = String.Empty
                Dim sqln As String = String.Empty
                curSheet = Excel_Global.Worksheets(trang + 1)
                curSheet.Copy(, .Sheets(trang))
                curSheet.Name = "Tonghopcongno"
                curSheet.Cells(1, 1) = pTenCty
                curSheet.Cells(2, 1) = "'" + CStr(pTenCn)
                If tdau = tcuoi Then
                    curSheet.Cells(5, 4) = "Tháng " + CStr(tdau) + " năm " + CStr(pNamTC)
                Else
                    curSheet.Cells(5, 4) = "Từ tháng " + CStr(tdau) + " đến tháng " + CStr(tcuoi) + " năm " + CStr(pNamTC)
                End If

                For i = CThangDB(tdau) To CThangDB(tcuoi)
                    st = CStr(i)
                    sqln = sqln + " + SoDuKhachHang.No_" + st
                    sqlc = sqlc + " + SoDuKhachHang.Co_" + st
                    sqln2 = sqln2 + " + SoDuKhachHang.No_" + st + "_NT"
                    sqlc2 = sqlc2 + " + SoDuKhachHang.Co_" + st + "_NT"
                Next
                For i = 1 To CThangDB(tcuoi)
                    st = CStr(i)
                    sqlnx = sqlnx + " + SoDuKhachHang.No_" + st
                    sqlcx = sqlcx + " + SoDuKhachHang.Co_" + st
                    sqlnx2 = sqlnx2 + " + SoDuKhachHang.No_" + st + "_NT"
                    sqlcx2 = sqlcx2 + " + SoDuKhachHang.Co_" + st + "_NT"
                Next

                st = CStr(CThangDB(ThangTruoc(tdau)))
                Dim QChitiet As String = "SELECT DISTINCT KhachHang.SoHieu, KhachHang.Ten, PhanLoaiKhachHang.SoHieu AS SHPL, TenPhanLoai,KyHieu," _
                    & " SoDuKhachHang.DuNo_" & st & " AS DkNo, SoDuKhachHang.DuCo_" & st & " AS DkCo, SoDuKhachHang.DuNT_" & st & " AS DkNT, (" & sqln & ") AS PsNo, (" & sqln2 & ") AS PsNo2, (" & sqlc & ") AS PsCo, (" & sqlc2 & ") AS PsCo2, (" & sqlnx & ") AS PsNoX, (" & sqlnx2 & ") AS PsNoX2, (" & sqlcx & ") AS PsCoX, (" & sqlcx2 & ") AS PsCoX2, SoDuKhachHang.DuNo_" _
                    & CStr(CThangDB(tcuoi)) & " AS CkNo, SoDuKhachHang.DuCo_" & CStr(CThangDB(tcuoi)) & " AS CkCo, SoDuKhachHang.DuNT_" & CStr(CThangDB(tcuoi)) & " AS CkNT,PhanLoaiKhachHang.PLCha,HethongTK.SoHieu AS SHTK,HethongTK.Ten AS TenTK" _
                    & " FROM (((KhachHang INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo) INNER JOIN SoDuKhachHang ON KhachHang.MaSo=SoDuKhachHang.MaKhachHang) LEFT JOIN NguyenTe ON KhachHang.MaNT=NguyenTe.MaSo) INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo " _
                    & " WHERE (SoDuKhachHang.DuNo_" & st & "<>0 OR SoDuKhachHang.DuCo_" & st & "<>0 OR (" & sqlnx & ") <>0 OR (" & sqlcx & ") <>0)" & " AND LEFT(KhachHang.SoHieu,1)<>'#'"
                Dim QSoCai As String = "SELECT QChitiet.*, PhanLoaiKhachHang.SoHieu AS SH2,PhanLoaiKhachHang.TenPhanLoai AS TenPhanLoai2,PhanLoaiKhachHang.PLCha AS PLCha2 FROM (" + QChitiet + ") as QChitiet LEFT JOIN PhanLoaiKhachHang ON QChitiet.PLCha=PhanLoaiKhachHang.MaSo"
                Dim QTongHopCT As String = "SELECT QSoCai.*, PhanLoaiKhachHang.SoHieu AS SH1,PhanLoaiKhachHang.TenPhanLoai AS TenPhanLoai1 FROM (" + QSoCai + ") as QSoCai LEFT JOIN PhanLoaiKhachHang ON QSoCai.PLCha2=PhanLoaiKhachHang.MaSo"

                Dim dong As Long
                dong = PrintSQLCNTH("select sohieu,ten,case when dkno-dkco>0 then dkno-dkco else 0 end, case when dkco-dkno>0 then dkco-dkno else 0 end,psno,psnox,psco,pscox,case when ckno-ckco>0 then ckno-ckco else 0 end, case when ckco-ckno>0 then ckco-ckno else 0 end from (" + QTongHopCT + ") as QTongHopCT order by sohieu", curSheet, 9, 1)
                curSheet.Cells(dong + 2, 9) = CStr(Day(NgayCuoiThang(pNamTC, tcuoi))) & " Tháng " & CStr(tcuoi) & " năm " & CStr(pNamTC)

                curSheet.SaveAs(pCurDir + ten)
                CloseBook(pCurDir + ten)
            End With
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function PrintSQLCNTH(ByVal sql As String, ByVal curSheet As Excel.Worksheet, ByVal RowIdx As Long, ByVal StartCol As Long, Optional ByVal thutu As Long = 0) As Long
        Dim rs As New DataTable
        Dim dongdau As Integer

        Try
            rs = ExecSQLReturnDT(sql)

            If rs.Rows.Count > 0 Then
                If rs.Rows.Count > 1 Then
                    curSheet.Range(CStr(RowIdx + 1) & ":" & CStr(RowIdx + rs.Rows.Count - 2 + 1)).EntireRow.Insert()
                End If
                For Each rsitem As DataRow In rs.Rows
                    If thutu > 0 Then
                        If dongdau = 0 Then
                            curSheet.Cells(RowIdx, StartCol - 1) = 1
                            dongdau = 1
                        Else
                            curSheet.Cells(RowIdx, StartCol - 1) = curSheet.Cells(RowIdx - 1, StartCol - 1) + 1
                        End If
                    End If
                    For FieldCnt As Integer = 0 To rs.Columns.Count - 1
                        If FieldCnt = 0 Then
                            curSheet.Cells(RowIdx, FieldCnt + StartCol).Value = rsitem(FieldCnt)
                        Else
                            curSheet.Cells(RowIdx, FieldCnt + StartCol).Value = rsitem(FieldCnt)
                        End If
                    Next FieldCnt
                    RowIdx = RowIdx + 1
                Next
                For FieldCnt As Integer = 2 To rs.Columns.Count - 1
                    curSheet.Cells(RowIdx, FieldCnt + StartCol).Formula = "=SUM(" + XLSCol(CStr(FieldCnt + StartCol)) + "9:" + XLSCol(CStr(FieldCnt + StartCol)) + CStr(rs.Columns.Count + 8) + ")"
                Next
            Else
                RowIdx = RowIdx + 1
            End If
            rs.Dispose()
            Return RowIdx
        Catch
            Return 0
        End Try
        Return 0
    End Function

    Public Function PrintSQLCN(ByVal sql As String, ByVal curSheet As Excel.Worksheet, ByVal RowIdx As Long, ByVal StartCol As Long, Optional ByVal thutu As Long = 0) As Long
        Dim rs As DataTable, ckno As Double
        Dim dongdau As Integer

        Try
            rs = ExecSQLReturnDT(sql)

            If rs.Rows.Count > 0 Then
                If rs.Rows.Count > 1 Then
                    curSheet.Range(CStr(RowIdx + 1) & ":" & CStr(RowIdx + rs.Rows.Count - 2 + 1)).EntireRow.Insert()
                End If
                For Each rsitem As DataRow In rs.Rows
                    If thutu > 0 Then
                        If dongdau = 0 Then
                            curSheet.Cells(RowIdx, StartCol - 1) = 1
                            dongdau = 1
                        Else
                            curSheet.Cells(RowIdx, StartCol - 1) = curSheet.Cells(RowIdx - 1, StartCol - 1) + 1
                        End If
                    End If
                    For FieldCnt As Integer = 0 To rs.Columns.Count - 2
                        If FieldCnt = 7 Then
                            If rsitem(0) <= 0 Then
                                If rsitem("shtk") Like "3*" Then
                                    ckno = ConvertToDblSafe(rsitem(6)) - ConvertToDblSafe(rsitem(5))
                                Else
                                    ckno = ConvertToDblSafe(rsitem(5)) - ConvertToDblSafe(rsitem(6))
                                End If
                            Else
                                If rsitem("shtk") Like "3*" Then
                                    ckno = ckno + ConvertToDblSafe(rsitem(6)) - ConvertToDblSafe(rsitem(5))
                                Else
                                    ckno = ckno + ConvertToDblSafe(rsitem(5)) - ConvertToDblSafe(rsitem(6))
                                End If
                            End If
                            curSheet.Cells(RowIdx, FieldCnt + StartCol).Value = ckno
                        Else
                            curSheet.Cells(RowIdx, FieldCnt + StartCol).Value = rsitem(FieldCnt)
                        End If
                    Next FieldCnt
                    RowIdx = RowIdx + 1
                Next
            Else
                RowIdx = RowIdx + 1
            End If
            PrintSQLCN = RowIdx
        Catch
            Return 0
        End Try
        Return PrintSQLCN
    End Function

    Public Function PrintSQLDoiChieuCN(ByVal sql As String, ByVal curSheet As Excel.Worksheet, ByVal RowIdx As Long, ByVal StartCol As Long, Optional ByVal Qchitiet As String = "") As Long
        Dim rs As DataTable, soct As String = String.Empty

        rs = ExecSQLReturnDT(sql)

        If rs.Rows.Count > 0 Then
            If rs.Rows.Count > 1 Then
                curSheet.Range(CStr(RowIdx + 1) & ":" & CStr(RowIdx + rs.Rows.Count - 1)).EntireRow.Insert()
            End If
            Dim rowid As Integer = 0, rsitem As DataRow, dongthue As Integer
            While rowid < rs.Rows.Count
                rsitem = rs.Rows(rowid)
                If soct <> rsitem("shct") Then
                    soct = rsitem("shct")
                    dongthue = RowIdx
                    If rsitem("tk_id") = "1330" Or rsitem("tk_id") = "3007" Then
                        curSheet.Cells(dongthue, StartCol + 7).Value = rsitem("tien")
                    End If
                    curSheet.Cells(RowIdx, StartCol).Value = rsitem("shct")
                    curSheet.Cells(RowIdx, StartCol + 1).Value = rsitem("ngayct")
                    curSheet.Cells(RowIdx, StartCol + 2).Value = rsitem("DienGiai")
                    curSheet.Cells(RowIdx, StartCol + 8).Value = GetSelectValue("select sum(tien) as f1 from (" + Qchitiet + ") as qchitiet where loai=" + CStr(rsitem("loai")) + " and ngayct='" + Format(CDate(rsitem("ngayct")), Mask_DB) + "' and shct like '" + CStr(rsitem("shct")) + "'")
                    curSheet.Cells(RowIdx, StartCol + 6).Value = ConvertToDblSafe(curSheet.Cells(RowIdx, StartCol + 8).Value) - ConvertToDblSafe(curSheet.Cells(RowIdx, StartCol + 7).Value)
                    If Not (rsitem("tk_id") = "1330" Or rsitem("tk_id") = "3007") Then
                        rowid = rowid - 1
                        curSheet.Range(CStr(RowIdx + 1) & ":" & CStr(RowIdx + 1)).EntireRow.Insert()
                    End If
                Else
                    For FieldCnt As Integer = 2 To rs.Columns.Count - 4
                        curSheet.Cells(RowIdx, FieldCnt + StartCol).Value = rsitem(FieldCnt)
                        If FieldCnt = 2 Then
                            If rsitem("loai") = 1 Then
                                If (rsitem("tk_id") = 1000 Or rsitem("tk_id") = 5000) Then
                                    curSheet.Cells(RowIdx, FieldCnt + StartCol).Value = rsitem("tenvattu")
                                ElseIf rsitem("tk_id") = 5210 Then
                                    curSheet.Cells(RowIdx, FieldCnt + StartCol).Value = "Chiết khấu"
                                ElseIf rsitem("tk_id") = 3310 Then
                                    curSheet.Cells(RowIdx, FieldCnt + StartCol).Value = "Chi phí"
                                ElseIf rsitem("tk_id") = 0 Then
                                    curSheet.Cells(RowIdx, FieldCnt + StartCol).Value = "Tài sản cố định"
                                End If
                            Else
                                If rsitem("sohieu") Like "111*" Then
                                    curSheet.Cells(RowIdx, FieldCnt + StartCol).Value = "Thanh toán tiền mặt"
                                ElseIf rsitem("sohieu") Like "112*" Then
                                    curSheet.Cells(RowIdx, FieldCnt + StartCol).Value = "Thanh toán chuyển khoản"
                                ElseIf rsitem("sohieu") Like "133*" Or rsitem("sohieu") Like "3331*" Then
                                    curSheet.Cells(RowIdx, FieldCnt + StartCol).Value = "Thuế GTGT"
                                Else
                                    curSheet.Cells(RowIdx, FieldCnt + StartCol).Value = rsitem("DienGiai")
                                End If
                            End If
                        ElseIf FieldCnt = 5 Then
                            If rsitem(FieldCnt - 1) > 0 Then
                                curSheet.Cells(RowIdx, FieldCnt + StartCol).Value = rsitem(FieldCnt + 1) / rsitem(FieldCnt - 1)
                            Else
                                curSheet.Cells(RowIdx, FieldCnt + StartCol).Value = 0
                            End If
                        End If
                    Next FieldCnt
                End If
                RowIdx = RowIdx + 1
                rowid = rowid + 1
            End While
        Else
            RowIdx = RowIdx + 1
        End If
        PrintSQLDoiChieuCN = RowIdx
    End Function

    Public Function PrintSQLDoiChieuCN1(ByVal sql As String, ByVal curSheet As Excel.Worksheet, ByVal RowIdx As Long, ByVal StartCol As Long, Optional ByVal Qchitiet As String = "") As Long
        Dim rs As DataTable

        rs = ExecSQLReturnDT(sql)

        If rs.Rows.Count > 0 Then
            If rs.Rows.Count > 1 Then
                curSheet.Range(CStr(RowIdx + 1) & ":" & CStr(RowIdx + rs.Rows.Count - 1)).EntireRow.Insert()
            End If
            Dim rowid As Integer = 0, rsitem As DataRow, dongthue As Integer
            Dim soct As String = String.Empty
            While rowid < rs.Rows.Count
                rsitem = rs.Rows(rowid)
                If soct <> rsitem("shct") Then
                    soct = rsitem("shct")
                    dongthue = RowIdx
                    If rsitem("tk_id") = "1330" Or rsitem("tk_id") = "3007" Then
                        curSheet.Cells(dongthue, StartCol + 4).Value = rsitem("tien")
                    End If
                    curSheet.Cells(RowIdx, StartCol).Value = rsitem("shct")
                    curSheet.Cells(RowIdx, StartCol + 1).Value = rsitem("ngayct")
                    curSheet.Cells(RowIdx, StartCol + 2).Value = rsitem("DienGiai")
                    curSheet.Cells(RowIdx, StartCol + 5).Value = GetSelectValue("select sum(tien) as f1 from (" + Qchitiet + ") as qchitiet where loai=" + CStr(rsitem("loai")) + " and ngayct='" + Format(CDate(rsitem("ngayct")), Mask_DB) + "' and shct like '" + CStr(rsitem("shct")) + "'")
                    curSheet.Cells(RowIdx, StartCol + 3).Value = ConvertToDblSafe(curSheet.Cells(RowIdx, StartCol + 5).Value) - ConvertToDblSafe(curSheet.Cells(RowIdx, StartCol + 4).Value)
                    If Not (rsitem("tk_id") = "1330" Or rsitem("tk_id") = "3007") Then
                        rowid = rowid - 1
                        curSheet.Range(CStr(RowIdx + 1) & ":" & CStr(RowIdx + 1)).EntireRow.Insert()
                    End If
                Else
                    curSheet.Range(CStr(RowIdx) & ":" & CStr(RowIdx)).EntireRow.Delete()
                    RowIdx = RowIdx - 1
                End If
                RowIdx = RowIdx + 1
                rowid = rowid + 1
            End While
        Else
            RowIdx = RowIdx + 1
        End If
        Return RowIdx
    End Function

    Public Function PrintSQLDoiChieuCN2(ByVal sql As String, ByVal curSheet As Excel.Worksheet, ByVal RowIdx As Long, ByVal StartCol As Long) As Long
        Dim rs As DataTable
        Dim soct As String = String.Empty

        rs = ExecSQLReturnDT(sql)

        If rs.Rows.Count > 0 Then
            If rs.Rows.Count > 1 Then
                curSheet.Range(CStr(RowIdx + 1) & ":" & CStr(RowIdx + rs.Rows.Count - 1)).EntireRow.Insert()
            End If
            For Each rsitem As DataRow In rs.Rows
                If soct <> rsitem("sohieu") Then
                    soct = rsitem("sohieu")
                    curSheet.Cells(RowIdx, StartCol).Value = rsitem("sohieu")
                    curSheet.Cells(RowIdx, StartCol + 1).Value = rsitem("ngay")
                    curSheet.Cells(RowIdx, StartCol + 2).Value = rsitem("DienGiai")
                    curSheet.Cells(RowIdx, StartCol + 4).Value = GetSelectValue("select sum(sopsno) as f1 from bknhomps where ngay='" + Format(CDate(rsitem("ngay")), Mask_DB) + "' and sohieu like '" + CStr(rsitem("sohieu")) + "' and (sopsco = 1330 or sopsco = 3007)")
                    curSheet.Cells(RowIdx, StartCol + 5).Value = GetSelectValue("select sum(sopsno) as f1 from bknhomps where ngay='" + Format(CDate(rsitem("ngay")), Mask_DB) + "' and sohieu like '" + CStr(rsitem("sohieu")) + "'")
                    curSheet.Cells(RowIdx, StartCol + 3).Value = ConvertToDblSafe(curSheet.Cells(RowIdx, StartCol + 5).Value) - ConvertToDblSafe(curSheet.Cells(RowIdx, StartCol + 4).Value)
                    curSheet.Cells(RowIdx, StartCol + 6).Value = GetSelectValue("select shdu as f1 from bknhomps where ngay='" + Format(CDate(rsitem("ngay")), Mask_DB) + "' and sohieu like '" + CStr(rsitem("sohieu")) + "' and shdu <> '...'")
                    curSheet.Cells(RowIdx, StartCol + 7).Value = GetSelectValue("select ngay as f1 from bknhomps where ngay='" + Format(CDate(rsitem("ngay")), Mask_DB) + "' and sohieu like '" + CStr(rsitem("sohieu")) + "' and shdu <> '...'")
                    curSheet.Cells(RowIdx, StartCol + 8).Value = GetSelectValue("select sum(sops2no) as f1 from bknhomps where ngay='" + Format(CDate(rsitem("ngay")), Mask_DB) + "' and sohieu like '" + CStr(rsitem("sohieu")) + "' and shdu <> '...'")
                Else
                    curSheet.Range(CStr(RowIdx) & ":" & CStr(RowIdx)).EntireRow.Delete()
                    RowIdx = RowIdx - 1
                End If
                RowIdx = RowIdx + 1
            Next
        Else
            RowIdx = RowIdx + 1
        End If
        Return RowIdx
    End Function
End Module
