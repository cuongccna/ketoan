Imports System
Imports System.Text
Imports System.Data
Imports System.Drawing
Imports UNET.Utility
Imports System.Diagnostics
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter
Imports Excel = Microsoft.Office.Interop.Excel
Imports Word = Microsoft.Office.Interop.Word
Imports ComboBoxEx


Module AllCodes

    ''############################ Data Base ##############################
    ''' <summary>
    ''' Tên server
    ''' </summary>
    ''' <remarks></remarks>
    Public DB_Server As String = "."
    ''' <summary>
    ''' Tên Database
    ''' </summary>
    ''' <remarks></remarks>
    Public DB_Database As String = "NVC"
    ''' <summary>
    ''' Tên đăng nhập Database
    ''' </summary>
    ''' <remarks></remarks>
    Public DB_User As String = "sa"
    ''' <summary>
    ''' Mật khẩu đăng Database
    ''' </summary>
    ''' <remarks></remarks>
    Public DB_Pass As String = "123"

    Public DB_mode As Integer = 1
    ''############################ Data Base ##############################

    Public Connecstring As String
    Public cuongdauky As Integer
    Public Soquy As Integer
    Public cuongNhanvien As String = String.Empty
    Public cuongThang As Integer
    Public cuongUongluong As String = String.Empty
    Public cuongCapnhatCSDL As Integer
    Public cuongccdcsoluong As Integer
    Public cuongktphanbo As Integer
    Public cuongktphanbo1 As Integer
    Public cuongktluuccdc As Integer
    Public cuongccdc As String = String.Empty
    Public lenloai As Integer
    Public indexloai As Integer
    Public cuongccdcloai() As String
    Public lenma As Integer
    Public indexma As Integer
    Public cuongccdcma() As String
    Public lenthang As Integer
    Public indexthang As Integer
    Public cuongccdcthang() As String
    Public cuongccdcthang1 As String = String.Empty
    Public cuongktccdc As Integer
    Public kh As String = String.Empty
    Public hh As String = String.Empty
    Public ngayChungTuPublic As Date
    Public Mahopdong As Integer
    Public cuongthuchi As Integer
    Dim sBar As String = String.Empty
    Public ToolTipMain As System.Windows.Forms.ToolTip
    Public luu As Integer = 1

    Public Sub ResetDuLieu()
        lenloai = 0
        indexloai = 0
        ReDim cuongccdcloai(lenloai)
        lenthang = 0
        indexthang = 0
        ReDim cuongccdcthang(lenthang)
        lenma = 0
        indexma = 0
        ReDim cuongccdcma(lenma)
        cuongccdcsoluong = 0
        cuongktphanbo = 0
        cuongktphanbo1 = 0
        cuongktluuccdc = 0
        cuongccdc = ""
        cuongktccdc = 0
        cuongccdcthang1 = "0"
        ngayChungTuPublic = DateTime.Now
    End Sub

    Public Sub Code39(ByRef strCode As String)
        Try
            Dim varBar1() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "-", ".", " ", "$", "/", "+", "%", "*", ","}
            Dim varBar2() As String = {"111221211", "211211112", "112211112", "212211111", "111221112", "211221111", "112221111", "111211212", "211211211", "112211211", "211112112", "112112112", "212112111", "111122112", "211122111", "112122111", "111112212", "211112211", "112112211", "111122211", "211111122", "112111122", "212111121", "111121122", "211121121", "112121121", "111111222", "211111221", "112111221", "111121221", "221111112", "122111112", "222111111", "121121112", "221121111", "122121111", "121111212", "221111211", "122111211", "121212111", "121211121", "121112121", "111212121", "121121211"}
            sBar = "1211212111"
            For i0 As Integer = 1 To strCode.Length
                For i1 As Integer = 0 To varBar1.Length
                    If Strings.Mid(strCode, i0, 1) = ConvertToStrSafe(varBar1.GetValue(i1)) Then
                        sBar = String.Format("{0}{1}1", sBar, varBar2(i1))
                    End If
                Next
            Next
            sBar = String.Format("{0}121121211", sBar)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub

    Public Sub Code128(ByRef strCode As String)
        Try
            Dim varBar1() As String = {" ", "!", """", "#", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ":", ";", "<", "=", ">", "?", "@", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "[", "\", "]", "^", "_", "`", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "I", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "{", "|", "}", "~", "DEL", "FNC 3", "FNC 2", "SHIFT", "CODE C", "FNC 4", "CODE A", "FNC 1", "Start A", "Start B", "Start C", "Stop"}
            Dim varBar2() As String = {"212222", "222122", "222221", "121223", "121322", "131222", "122213", "122312", "132212", "221213", "221312", "231212", "112232", "122132", "122231", "113222", "123122", "123221", "223211", "221132", "221231", "213212", "223112", "312131", "311222", "321122", "321221", "312212", "322112", "322211", "212123", "212321", "232121", "111323", "131123", "131321", "112313", "132113", "132311", "211313", "231113", "231311", "112133", "112331", "132131", "113123", "113321", "133121", "313121", "211331", "231131", "213113", "213311", "213131", "311123", "311321", "331121", "312113", "312311", "332111", "314111", "221411", "431111", "111224", "111422", "121124", "121421", "141122", "141221", "112214", "112412", "122114", "122411", "142112", "142211", "241211", "221114", "413111", "241112", "134111", "111242", "121142", "121241", "114212", "124112", "124211", "411212", "421112", "421211", "212141", "214121", "412121", "111143", "111341", "131141", "114113", "114311", "411113", "411311", "113141", "114131", "311141", "411131", "211412", "211214", "211232", "2331112"}
            Dim chksum As Single = 104
            sBar = "211214"
            For i0 As Integer = 1 To strCode.Length
                For i1 As Integer = 0 To varBar1.Length
                    If Strings.Mid(strCode, i0, 1) = ConvertToStrSafe(varBar1(i1)) Then
                        sBar = String.Format("{0}{1}", sBar, varBar2(i1))
                        chksum += (i1 * i0)
                        Exit For
                    End If
                Next
            Next
            sBar = String.Format("{0}{1}2331112", _
                       sBar, _
                       ConvertToStrSafe(varBar2(chksum - (CSng(Math.Floor(chksum / 103)) * 103))))
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' BarCode
    ''' </summary>
    ''' <param name="strCode"></param>
    ''' <param name="Pic"></param>
    ''' <param name="barscale"></param>
    ''' <param name="barHeight"></param>
    ''' <param name="StartX"></param>
    ''' <param name="startY"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function BarCode(ByRef strCode As String, ByRef Pic As PictureBox, ByRef barscale As Integer, ByRef barHeight As Single, ByRef StartX As Single, ByRef startY As Single) As Object
        Try
            Dim barWidth As Single
            Code128(strCode)
            Dim barStart As Single = StartX
            For i0 As Integer = 1 To sBar.Length
                barWidth = ConvertToDblSafe(Strings.Mid(sBar, i0, 1)) * barscale
                If i0 Mod 2 > 0 Then
                    'Using Graphics
                    '    g.FillRectangle(New SolidBrush(Color.Black), New Point(barStart, startY), New Point(barWidth, barHeight))
                    'End Using
                End If
                barStart += (IIf(i0 Mod 2 > 0, barWidth, barWidth * 1.3))
            Next
            Return barWidth
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="vt"></param>
    ''' <param name="sl"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PrintBarCode(ByRef vt As ClsVattu, ByRef sl As Integer) As Double
        Dim i As Integer = sl \ 3 + (IIf(sl Mod 3 <> 0, 1, 0))
        Try

            ExecSQLNonQuery("DELETE FROM BarCode")
            For j As Integer = 1 To i
                ExecSQLNonQuery(String.Format("INSERT INTO BarCode (MaSo,BarCode, Ten, GiaBan) VALUES ({0}, N'{1}', N'{2}',{3})", _
                                    Lng_MaxValue("MaSo", "BarCode") + 1, _
                                    vt.sohieu, _
                                    vt.TenVattu, _
                                    doidau(vt.GiaBan1)))
            Next

            rptFrom.InitForm("BARCODEr.rpt", "SELECT * FROM BarCode", "BarCode")

            SetRptInfo()
            'frmMain.rpt.PrinterName = "DATAMAX DMX I-4208"
            rptFrom.ReportDestination = 1
            InBaoCaoRPT()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return i
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="truongten"></param>
    ''' <param name="ma"></param>
    ''' <param name="truongma"></param>
    ''' <param name="bang"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function timtenmax(ByRef truongten As String, ByRef ma As String, ByRef truongma As String, ByRef bang As String) As String
        Dim result As String = String.Empty
        Dim rs As DataTable
        Dim sql As String = String.Format("SELECT top 1 {0} FROM {1} WHERE {2}=N'{3}' ORDER BY {0} desc", _
                                truongten, _
                                bang, _
                                truongma, _
                                ma)
        On Error GoTo Lamlai
lamtiep:
        rs = ExecSQLReturnDT(sql)
        On Error GoTo 0
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            'rs.MoveLast()
            result = rsItem(0)
        End If
        ''rs.Close()
        Return result
Lamlai:
        sql = String.Format("SELECT top 1 {0} FROM {1} WHERE {2}={3} ORDER BY {0} desc", _
                  truongten, _
                  bang, _
                  truongma, _
                  ConvertToStrSafe(ConvertToDblSafe(ma)))
        GoTo lamtiep
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="truongten"></param>
    ''' <param name="ma"></param>
    ''' <param name="truongma"></param>
    ''' <param name="bang"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Timten(ByRef truongten As String, ByVal ma As String, ByVal truongma As String, ByVal bang As String) As String
        Dim rs As New DataTable
        Dim result As String = String.Empty
        Try
            Dim sql As String = String.Format("SELECT {0} FROM {1} WHERE {2}=N'{3}'", _
                                    truongten, _
                                    bang, _
                                    truongma, _
                                    ma)
            Try
                rs = ExecSQLReturnDT(sql)
            Catch ex As Exception
                sql = String.Format("SELECT {0} FROM {1} WHERE {2}={3}", _
                          truongten, _
                          bang, _
                          truongma, _
                          ma)
                Try
                    rs = ExecSQLReturnDT(sql)
                Catch
                End Try
            End Try
            For Each rsItem As DataRow In rs.Rows
                If Not IsDBNull(rsItem(0)) Then
                    If ConvertToStrSafe(rsItem(0)) <> "..." Then
                        result = ConvertToStrSafe(rsItem(0))
                        Exit For
                    End If
                End If
            Next
            rs.Dispose()
        Catch ex As Exception
            rs.Dispose()
            Throw New Exception(ex.Message)
        End Try
        
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="LstVt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function SHNVList(ByRef LstVt As ListBox) As String
        Dim i As Integer = 1
        Try

            While Strings.Mid(LstVt.Text, i, 1) <> " " And LstVt.Text <> ""
                i += 1
            End While
            i -= 1
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Strings.Left(LstVt.Text, i)
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="so"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Dinhdang(ByRef so As Excel.Validation) As String
        Try
            If Conversion.Val(ConvertToStrSafe(so)) = 0 Then
                Return "0"
            Else
                Return Format((so), "#,###")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="so"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Redinhdang(ByRef so As Excel.Validation) As String
        If Conversion.Val(ConvertToStrSafe(so)) = 0 Then
            Return "0"
        Else
            Return Format((so), "#########")
        End If
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Hoadautu(ByRef str As String) As String
        Try
            str = str.Trim()
            If str.Length = 0 Then
                Return String.Empty
                Exit Function
            End If
            str = str.ToLower()
            str = String.Format("{0}{1}", Strings.Left(str, 1).ToUpper(), Strings.Right(str, str.Length - 1))
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try        
        Return str
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Hoadautu1(ByRef str As String) As String
        Try
            str = str.Trim()
            If str.Length = 0 Then
                Return String.Empty
                Exit Function
            End If
            str = str.ToLower()
            str = Strings.Left(str, 1).ToUpper() & Strings.Right(str, str.Length - 1)
            For i As Integer = 1 To str.Length - 1
                If Strings.Mid(str, i, 1) = " " And Strings.Mid(str, i + 1, 1) = " " Then
                    str = Strings.Left(str, i) & Strings.Right(str, str.Length - i - 1)
                    i -= 1
                End If
                If Strings.Mid(str, i, 1) = " " And Strings.Mid(str, i + 1, 1) <> " " Then
                    Mid(str, i + 1, 1) = Strings.Mid(str, i + 1, 1).ToUpper()
                End If
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return str
        End Try        
        Return str
    End Function
    ''' <summary>
    '''  Thủ tục kiểm tra dữ liệu
    ''' </summary>
    ''' <remarks></remarks>
    Sub KiemTraDuLieu()
        Try
            Dim Traloi As DialogResult
            Dim rs_ct1 As DataTable
            Dim MaSo As Integer
            Dim sh As String = String.Empty
            Dim SoHieu As New StringBuilder
            Dim dem As Integer
            Dim rs_ct As DataTable = ExecSQLReturnDT("SELECT chungtu.maso,mact,ngayct,sops,matkco,matkno,chungtu.sohieu,hethongtk.sohieu AS sohieutk FROM chungtu,hethongtk WHERE ((matkno=0 AND matkco=hethongtk.maso) OR (matkco=0 AND matkno=hethongtk.maso)) ORDER BY mact,matkco")
            If rs_ct.Rows.Count > 0 Then
                Dim rs_ctItem As DataRow = rs_ct.Rows(0)
                SoHieu = New StringBuilder(String.Format("{0} Số hiệu {1} Ngày chứng từ {1} TK nợ {1} TK có {1} Số PS", _
                                               Environment.NewLine, _
                                               grdColSeperete))
                sh = ConvertToStrSafe(rs_ctItem("SoHieu"))
                dem = 0
            End If
            Dim rs_ctIndex As Integer = 0
            While rs_ctIndex < rs_ct.Rows.Count
                Dim rs_ctItem As DataRow = rs_ct.Rows(rs_ctIndex)
                rs_ctIndex += 1 ' C15 Rs LOOP CONTROL
                If sh <> ConvertToStrSafe(rs_ctItem("SoHieu")) Then
                    Traloi = MessageBox.Show(String.Format("Sửa chứng từ không có đối ứng: {0}{1}", Environment.NewLine, SoHieu), My.Application.Info.ProductName, (IIf(dem Mod 2 = 1, MessageBoxButtons.OKCancel, MessageBoxButtons.YesNo)), MessageBoxIcon.Exclamation)
                    If Traloi = System.Windows.Forms.DialogResult.Yes Then
                        rs_ct1 = ExecSQLReturnDT(String.Format("SELECT maso,mact,ngayct,sops,matkco,matkno,sohieu FROM chungtu WHERE sohieu=N'{0}' ORDER BY matkco", sh))
                        Dim rs_ct1Index As Integer = 0
                        While rs_ct1Index < rs_ct1.Rows.Count
                            Dim rs_ct1Item As DataRow = rs_ct1.Rows(rs_ct1Index)
                            rs_ct1Index += 1 ' C15 Rs LOOP CONTROL
                            If ConvertToDblSafe(rs_ct1Item("MaTkNo")) = 0 Then
                                If rs_ct.Rows.Count <> 0 Then
                                    ExecSQLNonQuery(String.Format("DELETE FROM chungtu WHERE (matkno=0 OR matkco=0) AND sohieu=N'{0}'", sh))
                                    GoTo Suaxong
                                End If
                            End If
                            MaSo = ConvertToDblSafe(GetSelectValue(String.Format("SELECT matkco AS f1 FROM chungtu WHERE sohieu=N'{0}' AND sops={1} AND maso<>{2}", _
                                                                       sh, _
                                                                       ConvertToStrSafe(rs_ct1Item("sops")), _
                                                                       rs_ct1Item("MaSo"))))
                            ExecSQLNonQuery(String.Format("UPDATE chungtu SET matkco={0},matktcco={1} WHERE maso={2}", MaSo, ConvertToStrSafe(MaSo), rs_ct1Item("MaSo")))
                            'rs_ct1.MoveNext()
                        End While
                    Else
                        If Traloi = System.Windows.Forms.DialogResult.Cancel Then Exit Sub
                    End If
Suaxong:
                    sh = rs_ctItem("SoHieu")
                    dem = 0
                    SoHieu = New StringBuilder(String.Format("{0} Số hiệu{1} Ngày chứng từ {1} TK nợ {1} TK có {1} Số PS", Environment.NewLine, grdColSeperete))
                End If
                dem += 1
                If ConvertToDblSafe(rs_ctItem("MaTkNo")) = 0 Then
                    SoHieu.AppendFormat("{0}{1}{2}{3}{2}{2}0{2}{4}{2}{5}", _
                        Environment.NewLine, _
                        ConvertToStrSafe(rs_ctItem("SoHieu")), _
                        grdColSeperete, _
                        ConvertToStrSafe(rs_ctItem("NgayCT")), _
                        ConvertToStrSafe(rs_ctItem("sohieutk")), _
                        rs_ctItem("sops"))
                Else
                    SoHieu.AppendFormat("{0}{1}{2}{3}{2}{2}{4}{2}0{2}{5}", _
                                      Environment.NewLine, _
                                      ConvertToStrSafe(rs_ctItem("SoHieu")), _
                                      grdColSeperete, _
                                      ConvertToStrSafe(rs_ctItem("NgayCT")), _
                                      ConvertToStrSafe(rs_ctItem("sohieutk")), _
                                      rs_ctItem("sops"))
                End If
            End While
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="SoHieu"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function taikhoanconnhat(ByRef SoHieu As String) As String
        Dim TK As New ClsTaikhoan
        Dim Tk1 As New ClsTaikhoan
        Try
            If SoHieu = "" Then Return SoHieu
            TK.InitTaikhoanSohieu(SoHieu)
            Tk1.InitTaikhoanMaSo(TKChitiet(ConvertToDblSafe((TK.maso))))
            While TK.sohieu <> Tk1.sohieu
                TK.InitTaikhoanMaSo(ConvertToDblSafe((Tk1.maso)))
                Tk1.InitTaikhoanMaSo(TKChitiet(ConvertToDblSafe((TK.maso))))
            End While
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return TK.sohieu
        End Try
        Return TK.sohieu
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Bangluongthang(ByRef tdau As Object, ByRef tcuoi As Object) As Boolean
        Dim result As Boolean = False
        Dim str As String = String.Empty
        Try
            If (tdau).Equals((tcuoi)) Then
                rptFrom.SetFormulas("thang", String.Format("'Tháng {0} - {1}'", _
                                                ConvertToStrSafe((tdau)), _
                                                ConvertToStrSafe(pNamTC)))
            Else
                rptFrom.SetFormulas("thang", String.Format("'Từ tháng {0} đến tháng {1} năm {2}'", _
                                                ConvertToStrSafe((tdau)), _
                                                ConvertToStrSafe((tcuoi)), _
                                                ConvertToStrSafe(pNamTC)))
            End If
            str = String.Format("SELECT nv.ten AS nhanvien,cv.ten AS chucvu,pl.ten AS tenloainv,bl.* FROM ((quanlynhanvien nv inner join phanloaiquanlynhanvien pl on nv.maphanloai=pl.maso) inner join chucvu cv on nv.machucvu=cv.maso) inner join bangluong bl on nv.maso=bl.manv WHERE thang>={0} AND thang<={1}", ConvertToStrSafe(tdau), ConvertToStrSafe(tcuoi))
            rptFrom.InitForm("Bangluong1.RPT", str, "Qtinhluong")

            rptFrom.ReportWindowTitle = "Bảng lương nhân viên"

            result = True
        Catch
        End Try
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="quyen"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function KiemtraUser(ByRef quyen As Integer) As Boolean
        Dim sql As String = String.Empty
        Try
            Dim rs_ngte As DataTable = ExecSQLReturnDT(String.Format("SELECT Users.* FROM Users WHERE Maso={0} ORDER BY TenNSD DESC", UserID))
            Dim k As Double = 10 ^ quyen
            If rs_ngte.Rows.Count > 0 Then
                Dim rs_ngteItem As DataRow = rs_ngte.Rows(0)
                Return ConvertToDblSafe(rs_ngteItem("vt")) Mod ConvertToDblSafe(10 * k) >= k
            Else
                Return True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return True
        End Try
        
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Grd"></param>
    ''' <param name="cottrong"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Xoadongtrongcuoi(ByRef Grd As ListViewEx.ListviewExt, Optional ByRef cottrong As Integer = 0) As Boolean
        Dim result As Boolean = False
        Try
            Grd.Col = ConvertToDblSafe(cottrong)
            Grd.Row = ConvertToDblSafe(Grd.Rows - 1)
            If Grd.CtlText = "" Then
                Grd.RemoveItem(ConvertToDblSafe(Grd.Rows - 1)) : result = True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return result
        End Try
        
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Grd"></param>
    ''' <param name="KeyCode"></param>
    ''' <remarks></remarks>
    Sub Chondongxanh(ByRef Grd As ListViewEx.ListviewExt, ByRef KeyCode As Integer)
        If KeyCode = 37 Or KeyCode = 38 Or KeyCode = 39 Or KeyCode = 40 Then SetGridIndex(Grd, Grd.Row)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="hientai"></param>
    ''' <param name="tuthang"></param>
    ''' <param name="denthang"></param>
    ''' <param name="luong"></param>
    ''' <param name="ngaytran"></param>
    ''' <param name="thangtru"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function DCBHXH(ByRef hientai As String, ByRef tuthang As String, ByRef denthang As String, ByRef luong As Double, Optional ByRef ngaytran As Date = #1/5/2010#, Optional ByRef thangtru As Integer = 0) As Double
        Try
            Dim sothang As Integer
            Dim tran, tien As Double
            Dim ngaytranduoi As Date
            If ngaytran = DateSerial(2010, 5, 1) Then
                tran = 14600000
                ngaytranduoi = DateSerial(2009, 5, 1)
            ElseIf ngaytran = DateSerial(2009, 5, 1) Then
                tran = 13000000
                ngaytranduoi = DateSerial(2008, 1, 1)
            ElseIf ngaytran = DateSerial(2008, 1, 1) Then
                tran = 10800000
            End If
            Dim tdau As Date = DateSerial(ConvertToDblSafe(Strings.Right(tuthang, 2)), ConvertToDblSafe(Strings.Left(tuthang, 2)), 1)
            Dim tcuoi As Date = DateSerial(ConvertToDblSafe(Strings.Right(denthang, 2)), ConvertToDblSafe(Strings.Left(denthang, 2)), 1)
            If luong > tran Then
                tien = tran
            Else
                tien = luong
            End If
            If tdau >= ngaytran And tcuoi >= ngaytran Then
                sothang = (tcuoi.Month + tcuoi.Year * 12) - (tdau.Month + tdau.Year * 12) + (IIf(hientai = denthang, 0, 1)) - thangtru
                Return sothang * tien
            ElseIf tdau < ngaytran And tcuoi >= ngaytran Then
                sothang = (tcuoi.Month + tcuoi.Year * 12) - (ngaytran.Month + ngaytran.Year * 12) + (IIf(hientai = denthang, 0, 1)) - thangtru
                Return sothang * tien + DCBHXH(hientai, tuthang, String.Format("{0}{1}/{2}", _
                                                                     (IIf(ngaytran.Month < 10, "0", String.Empty)), _
                                                                     ConvertToStrSafe(ngaytran.Month), _
                                                                     Strings.Right(ConvertToStrSafe(ngaytran.Year), 2)), luong, ngaytranduoi, IIf(hientai = denthang, 1, 0))
            Else
                Return DCBHXH(hientai, tuthang, denthang, luong, ngaytranduoi)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="hientai"></param>
    ''' <param name="tuthang"></param>
    ''' <param name="denthang"></param>
    ''' <param name="luong"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function DCBHYT(ByRef hientai As String, ByRef tuthang As String, ByRef denthang As String, ByRef luong As Double) As Double
        Try
            Dim tdau As Date = DateSerial(ConvertToDblSafe(Strings.Right(tuthang, 2)), ConvertToDblSafe(Strings.Left(tuthang, 2)), 1)
            Dim tcuoi As Date = DateSerial(ConvertToDblSafe(Strings.Right(denthang, 2)), ConvertToDblSafe(Strings.Left(denthang, 2)), 1)
            Dim sothang As Integer = (tcuoi.Month + tcuoi.Year * 12) - (tdau.Month + tdau.Year * 12) + (IIf(hientai = denthang, 0, 1))
            Return sothang * luong
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return 0
        End Try
       
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="hientai"></param>
    ''' <param name="tuthang"></param>
    ''' <param name="denthang"></param>
    ''' <param name="luongcu"></param>
    ''' <param name="LuongMoi"></param>
    ''' <param name="ngaytran"></param>
    ''' <param name="thangtru"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function DCBHXHII(ByRef hientai As String, ByRef tuthang As String, ByRef denthang As String, ByRef luongcu As Double, ByRef LuongMoi As Double, Optional ByRef ngaytran As Date = #1/5/2010#, Optional ByRef thangtru As Integer = 0) As Double
        Try
            Dim sothang As Integer
            Dim tran, tien As Double
            Dim ngaytranduoi As Date
            If ngaytran = DateSerial(2010, 5, 1) Then
                tran = 14600000
                ngaytranduoi = DateSerial(2009, 5, 1)
            ElseIf ngaytran = DateSerial(2009, 5, 1) Then
                tran = 13000000
                ngaytranduoi = DateSerial(2008, 1, 1)
            ElseIf ngaytran = DateSerial(2008, 1, 1) Then
                tran = 10800000
            End If
            Dim tdau As Date = DateSerial(ConvertToDblSafe(Strings.Right(tuthang, 2)), ConvertToDblSafe(Strings.Left(tuthang, 2)), 1)
            Dim tcuoi As Date = DateSerial(ConvertToDblSafe(Strings.Right(denthang, 2)), ConvertToDblSafe(Strings.Left(denthang, 2)), 1)
            If luongcu > tran Then
                tien = tran
            Else
                tien = luongcu
            End If
            If LuongMoi > tran Then
                tien = tran - tien
            Else
                tien = LuongMoi - tien
            End If
            If tien > 0 Then
                If tdau >= ngaytran And tcuoi >= ngaytran Then
                    sothang = (tcuoi.Month + tcuoi.Year * 12) - (tdau.Month + tdau.Year * 12) + (IIf(hientai = denthang, 0, 1)) - thangtru
                    Return sothang * tien
                ElseIf tdau < ngaytran And tcuoi >= ngaytran Then
                    sothang = (tcuoi.Month + tcuoi.Year * 12) - (ngaytran.Month + ngaytran.Year * 12) + (IIf(hientai = denthang, 0, 1)) - thangtru
                    Return sothang * tien + DCBHXHII(hientai, _
                                                tuthang, _
                                                String.Format("{0}{1}/{2}", (IIf(ngaytran.Month < 10, "0", String.Empty)), ConvertToStrSafe(ngaytran.Month), Strings.Right(ConvertToStrSafe(ngaytran.Year), 2)), _
                                                luongcu, _
                                                LuongMoi, _
                                                ngaytranduoi, _
                                                IIf(hientai = denthang, 1, 0))
                Else
                    Return DCBHXHII(hientai, tuthang, denthang, luongcu, LuongMoi, ngaytranduoi)
                End If
            Else
                Return 0
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return 0
        End Try
        
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="hientai"></param>
    ''' <param name="tuthang"></param>
    ''' <param name="denthang"></param>
    ''' <param name="luongcu"></param>
    ''' <param name="LuongMoi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function DCBHYTII(ByRef hientai As String, ByRef tuthang As String, ByRef denthang As String, ByRef luongcu As Double, ByRef LuongMoi As Double) As Double
        Try
            Dim sothang As Integer
            Dim tdau As Date = DateSerial(ConvertToDblSafe(Strings.Right(tuthang, 2)), ConvertToDblSafe(Strings.Left(tuthang, 2)), 1)
            Dim tcuoi As Date = DateSerial(ConvertToDblSafe(Strings.Right(denthang, 2)), ConvertToDblSafe(Strings.Left(denthang, 2)), 1)
            Dim tien As Double = LuongMoi - luongcu
            If tien > 0 Then
                sothang = (tcuoi.Month + tcuoi.Year * 12) - (tdau.Month + tdau.Year * 12) + (IIf(hientai = denthang, 0, 1))
                Return sothang * tien
            Else
                Return 0
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return 0
        End Try
        
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Filename"></param>
    ''' <remarks></remarks>
    Sub Openword(ByRef Filename As String)
        Try
            Dim WordDoc As New Word.Application
            With WordDoc
                .Documents.Open(Filename)
                .WindowState = Word.WdWindowState.wdWindowStateNormal
                .Visible = True
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Them12dong()
        While ConvertToDblSafe(GetSelectValue("SELECT count(maso) AS f1 FROM phieunx")) Mod 12 <> 0
            ExecSQLNonQuery(String.Format("INSERT INTO PhieuNX (MaSo,SoCT,DienGiaiCT,SoHieu,DienGiai,SoLuong,ThanhTien) VALUES ({0},'1','...','...','...',0,0)", Lng_MaxValue("MaSo", "PhieuNX") + 1))
        End While
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub XuatVattuRa()
        Dim excelFilename As String = "VATTURA.xls"
        Dim excelOutputPath As String = Path.Combine(pCurDir & "\temp\", excelFilename)
        Dim excelTemplateFilePath As String = pCurDir & String.Format("\RePorts\{0}", excelFilename)
        Dim curSheet As Excel.Worksheet
        Try
            OpenBook(excelTemplateFilePath)
            Select Case Information.Err().Number
                Case Is < 0
                    Conversion.ErrorToString(5)
                Case 1
            End Select
            Try
                Recycle(excelOutputPath)
            Catch ex As Exception
                Information.Err().Number = 0
            End Try

            With Excel_Global.ActiveWorkbook
                curSheet = Excel_Global.Worksheets(1)
                PrintSQL("SELECT t2.sohieu,t1.sohieu,t1.tenphanloai FROM phanloaivattu t1 inner join hethongtk t2 on t1.matk=t2.maso ORDER BY t2.sohieu", curSheet, 4, 2)
                curSheet = Excel_Global.Worksheets(2)
                PrintSQL("SELECT t2.sohieu,t1.sohieu,t1.tenvattu,t1.donvi,t3.luong_12,t3.tien_12 FROM (vattu t1 inner join phanloaivattu t2 on t1.maphanloai=t2.maso)left join tonkho t3 on t1.maso=t3.mavattu ORDER BY t2.sohieu,t1.sohieu", curSheet, 4, 2)
                curSheet.SaveAs(excelOutputPath)
                CloseBook(excelTemplateFilePath)
            End With
        Catch ex As Exception
        Finally
            CloseBook(excelTemplateFilePath)
            CallExcel("\temp\" & excelFilename)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub NhapVattuVao()

        Dim excelFilename As String = "VATTUVAO.xls"
        pCurDir = Path.GetFullPath(My.Application.Info.DirectoryPath)
        Dim excelTemplateFilePath As String = pCurDir & String.Format("\RePorts\{0}", excelFilename)
        Try
            Dim curSheet As Excel.Worksheet
            Dim dong, cot, makho As Integer
            Dim PhanLoai, SoHieu, taikhoan, ten, dvt As String
            Dim luong, tien As Double
            Dim MaTK, cap As Integer
            Dim masocha As String = String.Empty, tenkho As String = String.Empty

            'Open excel 
            OpenBook(excelTemplateFilePath)

            Select Case Information.Err().Number
                Case Is < 0
                    Conversion.ErrorToString(5)
                Case 1
                    Exit Sub
            End Select

            With Excel_Global.ActiveWorkbook
                curSheet = Excel_Global.Worksheets(1)
                dong = 4
                cot = 2
                If ConvertToStrSafe(curSheet.Cells(dong, cot)._Default) = "" Then
                    CloseBook(excelTemplateFilePath)
                    myUMessager.mInformation(String.Format("Danh sách phân loại vật tư - hàng hoá từ Excel chưa có.{0}Vui lòng nhập danh sách phân loại vật tư - hàng hoá vào Excel trước!", Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CallExcel(excelTemplateFilePath)
                    Exit Sub
                End If

                While ConvertToStrSafe(curSheet.Cells(dong, cot)._Default) <> ""
                    taikhoan = curSheet.Cells(dong, cot).Value
                    SoHieu = curSheet.Cells(dong, cot + 1).Value
                    ten = curSheet.Cells(dong, cot + 2).Value
                    cap = curSheet.Cells(dong, cot + 3).Value
                    masocha = SoHieu2MaSo(curSheet.Cells(dong, cot + 4).Value, "phanloaivattu")
                    makho = ConvertToIntSafe(timtenmax("MaSo", curSheet.Cells(dong, cot + 5).Value, "TenKho", "KhoHang"))
                    tenkho = curSheet.Cells(dong, cot + 5).Value

                    If makho = 0 Then
                        ExecSQLNonQuery(String.Format("INSERT INTO KhoHang (MaSo,TenKho,MaTK,MaTKGV)VALUES({0}, N'{1}',0,0)", _
                                           Lng_MaxValue("MaSo", "KhoHang") + 1, _
                                           tenkho))
                    End If

                    If ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(maso) AS f1 FROM phanloaivattu WHERE sohieu=N'{0}'", SoHieu))) = 0 Then
                        ExecSQLNonQuery(String.Format("INSERT INTO phanloaivattu (maso,sohieu,tenphanloai,vat,plcon,cap,matk,plcha)VALUES({0}, N'{1}', N'{2}',0,0,{3},{4},{5})", _
                                            Lng_MaxValue("maso", "phanloaivattu") + 1, _
                                            SoHieu, _
                                            ten, _
                                            (cap), _
                                            (SoHieu2MaSo(taikhoan, "hethongtk")), _
                                            masocha))
                    Else
                        ExecSQLNonQuery(String.Format("UPDATE phanloaivattu SET tenphanloai=N'{0}', cap={1},matk={2},plcha={3} WHERE sohieu=N'{4}'", _
                                            ten, _
                                            (cap), _
                                            (SoHieu2MaSo(taikhoan, "hethongtk")), _
                                            masocha, _
                                            SoHieu))
                    End If
                    If ConvertToDblSafe(masocha) > 0 Then
                        ExecSQLNonQuery(String.Format("UPDATE phanloaivattu SET plcon=1 WHERE maso={0}", masocha))
                    End If

                    dong += 1
                End While

                curSheet = Excel_Global.Worksheets(2)
                dong = 4

                If curSheet.Cells(dong, cot)._Default = "" Then
                    CloseBook(excelTemplateFilePath)
                    myUMessager.mInformation(String.Format("Danh sách vật tư - hàng hoá từ Excel chưa có.{0}Vui lòng nhập danh sách vật tư - hàng hoá vào Excel trước!", Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CallExcel(excelTemplateFilePath)
                    Exit Sub
                End If

                While curSheet.Cells(dong, cot).Value <> ""
                    PhanLoai = (curSheet.Cells(dong, cot)).Value
                    SoHieu = (curSheet.Cells(dong, cot + 1)).Value
                    ten = (curSheet.Cells(dong, cot + 2)).Value
                    dvt = (curSheet.Cells(dong, cot + 3)).Value
                    luong = ConvertToDblSafe((curSheet.Cells(dong, cot + 4)).Value)
                    tien = ConvertToDblSafe((curSheet.Cells(dong, cot + 5)).Value)
                    makho = ConvertToIntSafe(timtenmax("MaSo", curSheet.Cells(dong, cot + 6).Value, "TenKho", "KhoHang"))
                    If ConvertToDblSafe(GetSelectValue(String.Format("SELECT COUNT(maso) AS f1 FROM vattu WHERE sohieu=N'{0}'", SoHieu))) = 0 Then
                        ExecSQLNonQuery(String.Format("INSERT INTO vattu (maso,maphanloai,sohieu,tenvattu,donvi,tonmin,tonmax,giaduphong,giaht,dvt2,donvi2,tyleqd,ghichu,vat,giaban1,giaban2,giaban3,ck,thuenk,t,l)VALUES({0},{1}, N'{2}', N'{3}', N'{4}',0,0,0,0,0,'...',0,'...',0,0,0,0,0,0,0,0)", _
                                            Lng_MaxValue("maso", "vattu") + 1, _
                                            (SoHieu2MaSo(PhanLoai, "phanloaivattu")), _
                                            SoHieu, _
                                            ten, _
                                            dvt))
                    End If
                    taikhoan = taikhoanconnhat(ConvertToStrSafe(GetSelectValue(String.Format("SELECT hethongtk.sohieu AS F1 FROM hethongtk INNER JOIN phanloaivattu ON phanloaivattu.matk=hethongtk.maso WHERE phanloaivattu.sohieu=N'{0}'", PhanLoai))))
                    MaTK = SoHieu2MaSo(taikhoan, "hethongtk")
                    If ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(tonkho.maso) AS f1 FROM vattu inner join tonkho on vattu.maso=tonkho.mavattu WHERE vattu.sohieu=N'{0}' and tonkho.masokho={1} and tonkho.mataikhoan={2}", SoHieu, makho, MaTK))) = 0 Then
                        ExecSQLNonQuery(String.Format("INSERT INTO tonkho (maso,masokho,mataikhoan,mavattu,tien_0,luong_0,soxuat,tien_nhap_1,luong_nhap_1,tien_xuat_1,luong_xuat_1,tien_1,luong_1,tien_nhap_2,luong_nhap_2,tien_xuat_2,luong_xuat_2,tien_2,luong_2,tien_nhap_3,luong_nhap_3,tien_xuat_3,luong_xuat_3,tien_3,luong_3,tien_nhap_4,luong_nhap_4,tien_xuat_4,luong_xuat_4,tien_4,luong_4,tien_nhap_5,luong_nhap_5,tien_xuat_5,luong_xuat_5,tien_5,luong_5,tien_nhap_6,luong_nhap_6,tien_xuat_6,luong_xuat_6,tien_6,luong_6,tien_nhap_7,luong_nhap_7,tien_xuat_7,luong_xuat_7,tien_7,luong_7,tien_nhap_8,luong_nhap_8,tien_xuat_8,luong_xuat_8,tien_8,luong_8,tien_nhap_9,luong_nhap_9,tien_xuat_9,luong_xuat_9,tien_9,luong_9,tien_nhap_10,luong_nhap_10,tien_xuat_10,luong_xuat_10,tien_10,luong_10,tien_nhap_11,luong_nhap_11,tien_xuat_11,luong_xuat_11,tien_11,luong_11,tien_nhap_12,luong_nhap_12,tien_xuat_12,luong_xuat_12,tien_12,luong_12)VALUES({0},{1},{2},{3},{4},{5},0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0)", _
                                            ConvertToStrSafe(Lng_MaxValue("maso", "tonkho") + 1), _
                                            makho, _
                                            ConvertToStrSafe(MaTK), _
                                            ConvertToStrSafe(SoHieu2MaSo(SoHieu, "vattu")), _
                                            ConvertToStrSafe(tien), _
                                            ConvertToStrSafe(luong)))
                    Else
                        ExecSQLNonQuery(String.Format("UPDATE tonkho SET mataikhoan={0}, tien_0={1}, luong_0={2} from tonkho inner join vattu on tonkho.mavattu=vattu.maso WHERE vattu.sohieu=N'{3}' and tonkho.masokho={4}", _
                                            MaTK, _
                                            ConvertToStrSafe(tien), _
                                            ConvertToStrSafe(luong), _
                                            SoHieu, _
                                            makho))
                    End If
                    dong += 1
                End While
                CloseBook(excelTemplateFilePath)
                myUMessager.mInformation(Ngonngu("Đã tập hợp xong danh sách vật tư, hàng hoá\nlàm ơn kiểm tra nhập xuất tồn (menu dữ liệu) để cập nhật dữ liệu", "Imported material, goods on the list is complete"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End With
        Catch ex As Exception
            CloseBook(excelTemplateFilePath)
            Throw New Exception(ex.Message)
        End Try

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub XuatKhachhangRa(ByVal nhom As Integer)
        Dim excelFilename As String = "KHACHHANGRA.xls"
        pCurDir = Path.GetFullPath(My.Application.Info.DirectoryPath)
        Dim excelOutputPath As String = (pCurDir & "\temp\" & excelFilename)
        Dim excelTemplateFilePath As String = pCurDir & String.Format("\RePorts\{0}", excelFilename)
        Dim curSheet As Excel.Worksheet
        Try
            OpenBook(excelTemplateFilePath)
            Select Case Information.Err().Number
                Case Is < 0
                    Conversion.ErrorToString(5)
                Case 1
            End Select
            Try
                Recycle(excelOutputPath)
            Catch ex As Exception
                Information.Err().Number = 0
            End Try

            With Excel_Global.ActiveWorkbook
                curSheet = Excel_Global.Worksheets(1)
                PrintSQL("SELECT sohieu,tenphanloai FROM phanloaikhachhang ORDER BY sohieu", curSheet, 4, 2)
                curSheet = Excel_Global.Worksheets(2)
                Dim sql As String = "SELECT distinct t2.sohieu,t1.sohieu,t1.ten,t1.mst,t1.diachi,t1.tel,t1.fax,t1.email,t1.taikhoan,t1.daidien,t3.duno_12,t3.duco_12,t3.dunt_12,t4.sohieu from KhachHang t1 inner join PhanLoaiKhachHang t2 on t1.MaPhanLoai=t2.MaSo left join sodukhachhang t3 on t1.maso=t3.makhachhang left join hethongtk t4 on t3.mataikhoan=t4.maso where t1.MaPhanLoai='" & nhom.ToString & "'"
                PrintSQL(sql, curSheet, 4, 2)
                curSheet.SaveAs(excelOutputPath)
                CloseBook(excelTemplateFilePath)
            End With
        Catch ex As Exception
        Finally
            CloseBook(excelTemplateFilePath)
            CallExcel("\temp\" & excelFilename)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub NhapKhachhangVao()
        Dim excelFilename As String = "KHACHHANGVAO.xls"
        pCurDir = Path.GetFullPath(My.Application.Info.DirectoryPath)
        Dim excelTemplateFilePath As String = pCurDir & String.Format("\RePorts\{0}", excelFilename)
        Try
            Dim curSheet As Excel.Worksheet
            Dim dong, cot As Integer
            Dim MST, ten, SoHieu, PhanLoai, DiaChi, taikhoan, Fax, Tel, email, DaiDien As String
            Dim duco, duno, dunt As Double
            Dim sotaikhoan As String = String.Empty
            Dim MaTK As Integer
            OpenBook(excelTemplateFilePath)
            Select Case Information.Err().Number
                Case Is < 0
                    Conversion.ErrorToString(5)
                Case 1
                    Exit Sub
            End Select
            With Excel_Global.ActiveWorkbook
                curSheet = Excel_Global.Worksheets(1)
                dong = 4
                cot = 2

                If curSheet.Cells(dong, cot)._Default = "" Then
                    CloseBook(excelTemplateFilePath)
                    myUMessager.mInformation(String.Format("Danh sách phân loại khách hàng từ Excel chưa có.{0}Vui lòng nhập danh sách phân loại khách hàng vào Excel trước!", Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CallExcel(excelTemplateFilePath)
                    Exit Sub
                End If

                While curSheet.Cells(dong, cot)._Default <> ""
                    SoHieu = (curSheet.Cells(dong, cot))._Default
                    ten = (curSheet.Cells(dong, cot + 1))._Default
                    If ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(maso) AS f1 FROM phanloaikhachhang WHERE sohieu=N'{0}'", SoHieu))) = 0 Then
                        ExecSQLNonQuery("INSERT INTO phanloaikhachhang (maso,sohieu,tenphanloai,vat,plcon,plcha,cap)VALUES(" & Lng_MaxValue("maso", "phanloaikhachhang") + 1 & ",'" & SoHieu & "','" & ten & "',0,0,0,1)")
                    End If
                    dong += 1
                End While

                curSheet = Excel_Global.Worksheets(2)
                dong = 4

                If curSheet.Cells(dong, cot)._Default = "" Then
                    CloseBook(excelTemplateFilePath)
                    myUMessager.mInformation(String.Format("Danh sách khách hàng từ Excel chưa có.{0}Vui lòng nhập danh sách khách hàng vào Excel trước!", Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CallExcel(excelTemplateFilePath)
                    Exit Sub
                End If

                While curSheet.Cells(dong, cot)._Default <> ""
                    PhanLoai = (curSheet.Cells(dong, cot))._Default
                    SoHieu = (curSheet.Cells(dong, cot + 1))._Default
                    ten = (curSheet.Cells(dong, cot + 2))._Default
                    MST = (curSheet.Cells(dong, cot + 3))._Default
                    DiaChi = (curSheet.Cells(dong, cot + 4))._Default
                    Tel = (curSheet.Cells(dong, cot + 5))._Default
                    Fax = (curSheet.Cells(dong, cot + 6))._Default
                    email = (curSheet.Cells(dong, cot + 7))._Default
                    taikhoan = (curSheet.Cells(dong, cot + 8))._Default
                    DaiDien = (curSheet.Cells(dong, cot + 9))._Default
                    duno = (curSheet.Cells(dong, cot + 10))._Default
                    duco = (curSheet.Cells(dong, cot + 11))._Default
                    dunt = (curSheet.Cells(dong, cot + 12))._Default
                    sotaikhoan = (curSheet.Cells(dong, cot + 13))._Default

                    If ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(maso) AS f1 FROM khachhang WHERE sohieu=N'{0}'", SoHieu))) = 0 Then
                        Dim insert As String = String.Format("INSERT INTO khachhang (maso,maphanloai,sohieu,ten,mst,diachi,tel,fax,email,taikhoan,daidien)VALUES({0},{1}, N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}', N'{10}')", _
                                            Lng_MaxValue("maso", "khachhang") + 1, _
                                            ConvertToStrSafe(SoHieu2MaSo(PhanLoai, "phanloaikhachhang")), _
                                            SoHieu, _
                                            ten, _
                                            MST, _
                                            DiaChi, _
                                            Tel, _
                                            Fax, _
                                            email, _
                                            taikhoan, _
                                            DaiDien)
                        ExecSQLNonQuery(insert)
                    End If
                    MaTK = SoHieu2MaSo(taikhoanconnhat(sotaikhoan), "hethongtk")
                    If ConvertToDblSafe(GetSelectValue(String.Format("SELECT count(sodukhachhang.maso) AS f1 FROM sodukhachhang inner join khachhang on khachhang.maso=sodukhachhang.makhachhang WHERE khachhang.sohieu=N'{0}' AND sodukhachhang.mataikhoan={1}", _
                                                           SoHieu, _
                                                           ConvertToStrSafe(MaTK)))) = 0 Then
                        ExecSQLNonQuery(String.Format("INSERT INTO sodukhachhang (maso,mataikhoan,makhachhang,duno_0,duco_0,dunt_0,no_1,co_1,no_1_nt,co_1_nt,duno_1,duco_1,dunt_1,no_2,co_2,no_2_nt,co_2_nt,duno_2,duco_2,dunt_2,no_3,co_3,no_3_nt,co_3_nt,duno_3,duco_3,dunt_3,no_4,co_4,no_4_nt,co_4_nt,duno_4,duco_4,dunt_4,no_5,co_5,no_5_nt,co_5_nt,duno_5,duco_5,dunt_5,no_6,co_6,no_6_nt,co_6_nt,duno_6,duco_6,dunt_6,no_7,co_7,no_7_nt,co_7_nt,duno_7,duco_7,dunt_7,no_8,co_8,no_8_nt,co_8_nt,duno_8,duco_8,dunt_8,no_9,co_9,no_9_nt,co_9_nt,duno_9,duco_9,dunt_9,no_10,co_10,no_10_nt,co_10_nt,duno_10,duco_10,dunt_10,no_11,co_11,no_11_nt,co_11_nt,duno_11,duco_11,dunt_11,no_12,co_12,no_12_nt,co_12_nt,duno_12,duco_12,dunt_12)VALUES({0},{1},{2},{3},{4},{5},0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0)", _
                                            ConvertToStrSafe(Lng_MaxValue("maso", "sodukhachhang") + 1), _
                                            ConvertToStrSafe(MaTK), _
                                            ConvertToStrSafe(SoHieu2MaSo(SoHieu, "khachhang")), _
                                            ConvertToStrSafe(duno), _
                                            ConvertToStrSafe(duco), _
                                            ConvertToStrSafe(dunt)))
                    Else
                        ExecSQLNonQuery(String.Format("UPDATE sodukhachhang inner join khachhang on sodukhachhang.makhachhang=khachhang.maso SET duno_0={0}, duco_0={1}, dunt_0={2} WHERE khachhang.sohieu=N'{3}' AND sodukhachhang.mataikhoan={4}", _
                                            duno, _
                                            ConvertToStrSafe(duco), _
                                            ConvertToStrSafe(dunt), _
                                            SoHieu, _
                                            ConvertToStrSafe(MaTK)))
                    End If
                    dong += 1
                End While
                CloseBook(excelTemplateFilePath)
                myUMessager.mInformation(Ngonngu("Đã tập hợp xong danh sách khách hàng", "Imported customer list is complete"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End With
        Catch ex As Exception
            CloseBook(excelTemplateFilePath)
            Throw New Exception(ex.Message)
        End Try

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Kiemtrangay0()
        Try
            If Not TruongDaCo("license", "ngay") Then
                ExecSQLNonQuery("ALTER TABLE license add ngay datetime null,ngay1 integer null")
            End If

            Dim songay As Integer
            If ConvertToDblSafe(GetSelectValue("SELECT ngay AS f1 FROM license")) = 0 Then
                ExecSQLNonQuery(String.Format("UPDATE license SET ngay=N'{0}', ngay1=-1", Format(DateTime.Now, Mask_DB)))
                songay = ConvertToDblSafe(FrmGetStr.GetString(Ngonngu("Số ngày thực hiện:", "Number date apply"), My.Application.Info.ProductName, ConvertToStrSafe(30)))
                If songay = 0 Then songay = 30
                Interaction.SaveSetting("key", "license", "khoa", ConvertToStrSafe(songay))
                HienThongBao("Đã thực hiện khoá !", 1)
            Else
                If FrmPassword.GetPswX() = "misu1975" Then
                    ExecSQLNonQuery("UPDATE license SET ngay=null,ngay1=0")
                    HienThongBao("Đã mở khoá !", 1)
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Kiemtrangay()
        Try
            If Not TruongDaCo("license", "ngay") Then
                ExecSQLNonQuery("ALTER TABLE license add ngay datetime null,ngay1 integer null")
            End If
            ''        If ConvertToDblSafe(GetSelectValue("SELECT ngay AS f1 FROM license")) <> 0 AND ConvertToDblSafe((GetSelectValue("SELECT ngay1 AS f1 FROM license"))) = -1 Then
            ''            FrmOptions.Command(3).Text = "&Unlock"
            ''            If ConvertToStrSafe(GetSelectValue(String.Format("SELECT ABS (DATEDIFF(day, N'{0}', ngay)) AS f1 FROM license", Format(DateTime.Now, Mask_DB)))) > GetSetting("key", "license", "khoa", ConvertToStrSafe(30)) Then
            ''                If MessageBox.Show(String.Format("Hệ thống có vấn đề cần khắc phục.{0}Vui lòng liên hệ với Cty MiSu để tiếp tục sử dụng!", Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            ''                    If FPsw.GetPswX() = "misu1975" Then
            ''                        ExecSQLNonQuery("UPDATE license SET ngay=null,ngay1=0")
            ''                        HienThongBao("Đã mở khoá !", 1)
            ''                    Else
            ''                        GoTo khoa
            ''                    End If
            ''                Else
            ''khoa:
            ''                    HienThongBao("Kết thúc chương trình kế toán!", 1)
            ''                    CloseUp(1)
            ''                    'WSpace.Close()
            ''                    Environment.Exit(0)
            ''                End If
            ''            End If
            ''        Else
            ''            FrmOptions.Command(3).Text = "&Lock"
            ''        End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Kiemtramay() As Integer
        ''Dim result AS Integer = 0
        ''Dim kq, tmp, Serial, Length, k AS Integer
        ''Dim MST AS String = String.Empty
        ''Dim i AS Integer
        ''GetVolumeSerialNumber(("c").ToUpper() & ":\", 0, 0, Serial, 0, 0, 0, 0)
        ''If Serial <> ConvertToDblSafe(Interaction.GetSetting("key", "license", "may", "0")) Then
        ''    tmp = ConvertToDblSafe((FPsw.GetPswX("Nhập mã đăng ký sử dụng máy")))
        ''    If tmp <> ConvertToDblSafe("9032425") AND tmp <> Serial Then Return result
        ''        MessageBox.Show("Mã đăng ký của máy này          " & Serial, MsgBoxStyle.OkOnly, My.Application.Info.ProductName,My.Application.Info.ProductName, MessageBoxButtons.OK,  MessageBoxIcon.Information)  
        ''    Interaction.SaveSetting("key", "license", "may", ConvertToStrSafe(Serial))
        ''    Return 1
        ''Else
        ''    Return 1
        ''End If
        ''Return result
        Return 1
    End Function

    Public Sub InitCap(ByRef cbo As ComboBoxExt, ByVal chisodau As Integer, ByVal chisocuoi As Integer, Optional ByVal vitri As Integer = 0)
        Try
            cbo.Items.Clear()
            cbo.Items.ItemsBase.Clear()

            For i As Integer = chisodau To chisocuoi
                cbo.Items.Add(New ComboBoxItem(i, i - chisodau))
            Next

            If cbo.Items.Count > 0 Then cbo.SelectedIndex = vitri
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    Public Function UNItokdau(ByVal str As String) As String
        Dim kd As String = String.Empty, unI As String = String.Empty, i As Long, skd As String = String.Empty, arrkd() As String = {}, STT
        Try
            kd = "a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,e,e,e,e,e,e,e,e,e,e,e,i,i,i,i,i,o,o,o,o,o,o,o,o,o,o,o,o,o,o,o,o,o,u,u,u,u,u,u,u,u,u,u,u,y,y,y,y,y,d,A,A,A,A,A,A,A,A,A,A,A,A,A,A,A,A,A,E,E,E,E,E,E,E,E,E,E,E,I,I,I,I,I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,U,U,U,U,U,U,U,U,U,U,U,Y,Y,Y,Y,Y,D"
            unI = "02250224784302277841025978557857785978617863022678457847784978517853023302327867786978650234787178737875787778790237023678810297788302430242788702457885024478897891789378957897041778997901790379057907025002497911036179090432791379157917791979210253792379277929792502730193019278420195784002587854785678587860786201947844784678487850785202010200786678687864020278707872787478767878020502047880029678820211021078860213788402127888789078927894789604167898790079027904790602180217791003607908043179127914791679187920022179227926792879240272"
            arrkd = Split(kd, ",")
            For i = 1 To Len(str)
                If InStr(unI, AscW(Mid(str, i, 1))) > 0 And AscW(Mid(str, i, 1)) > 127 Then
                    STT = InStr(unI, AscW(Mid(str, i, 1))) \ 4
                    If AscW(Mid(str, i, 1)) = 250 Then skd = skd & "u" Else skd = skd & arrkd(STT) 'Tam sua ký tu ú
                Else
                    skd = skd & Mid(str, i, 1)
                End If
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return skd
        End Try        
        Return skd
    End Function

    Public Function Luoi(ByVal Grd As ListViewEx.ListviewExt, Optional ByVal dong As Integer = -1, Optional ByVal cot As Integer = -1) As String
        Try
            With Grd
                If dong >= 0 And cot >= 0 Then
                    Return .Items(dong).SubItems(cot).Text
                Else
                    Return .Items(.Row).SubItems(.Col).Text
                End If
            End With
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try        
    End Function

    Public Sub BoNull(ByVal TenBang As String)
        Try
            Dim rs As DataTable, sql As String
            rs = New DataTable
            sql = "select top 1 * from " + CStr(TenBang)
            rs = ExecSQLReturnDT(sql)
            If rs.Rows.Count > 0 Then
                For Each rsitem As DataColumn In rs.Columns
                    sql = "update " + CStr(TenBang) + " set " + CStr(rsitem.ColumnName) + "=0 where " + CStr(rsitem.ColumnName) + " is null"
                    ExecSQLNonQuery(sql)
                Next
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub

    Public Sub InitVAT(ByVal CboTL As ComboBoxExt)
        Try
            CboTL.Items.Clear()
            CboTL.Items.ItemsBase.Clear()
            CboTL.Items.Add(New ComboBoxItem("KCT", -2))
            CboTL.Items.Add(New ComboBoxItem("TB", -1))
            CboTL.Items.Add(New ComboBoxItem("0", 0))
            CboTL.Items.Add(New ComboBoxItem("1", 1))
            CboTL.Items.Add(New ComboBoxItem("3", 3))
            CboTL.Items.Add(New ComboBoxItem("5", 5))
            CboTL.Items.Add(New ComboBoxItem("10", 10))
            CboTL.Items.Add(New ComboBoxItem("10", 20))
            CboTL.Items.Add(New ComboBoxItem("5&10", 30))
            CboTL.Items.Add(New ComboBoxItem("HDBL", -3))
            CboTL.SelectedIndex = -1
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Sub
    Public Function ButtonString(ByRef str As String, ByVal vt1 As Long, ByVal vt2 As Long) As String
        Dim result As String = String.Empty
        Try
            Dim i As Long, timduoc As Boolean = False
            str = Trim(str)
            If Len(str) <= vt2 Then
                result = str
            Else
                For i = vt2 + 1 To (vt1 + vt2) / 2 Step -1
                    If Asc(Mid(str, i, 1)) = 0 Or Asc(Mid(str, i, 1)) = 13 Or Asc(Mid(str, i, 1)) = 32 Then timduoc = True : Exit For
                Next
                If timduoc = False Then
                    result = Left(str, vt2 - 2) & "-" & vbCrLf & ButtonString(str.Substring(vt2 - 2), vt1, vt2)
                Else
                    result = Left(str, i - 1) & vbCrLf & ButtonString(str.Substring(i), vt1, vt2)
                End If
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return result
        End Try
        Return result
    End Function

    Public Function Ngonngu(ByVal StrViet As String, ByVal strAnh As String) As String
        If pNN = 1 Then
            Return strAnh
        Else
            Return StrViet
        End If
    End Function

    Function doidau(ByVal so As Double) As String
        Return Strings.Replace(so.ToString, ",", ".")
    End Function

    Public Function Number2TextUSD(ByVal sNumber As Double) As String
        Dim toread, numstring, group, word As String
        Try
            Dim i As Byte, w, x, y, z As Double
            Dim fristcolum, secondcolum, readmetho
            If sNumber = 0 Then
                toread = "None"
            Else
                If Math.Abs(sNumber) >= 1.0E+15 Then
                    toread = "! Too long number ???"
                Else
                    fristcolum = Split("None;one;two;three;four;five;six;seven;eight;nine;ten;eleven;twelve;thirteen;fourteen;fifteen;sixteen;seventeen;eightteen;nineteen", ";")
                    secondcolum = Split("None;None;twenty;thirty;forty;fifty;sixty;seventy;eighty;ninety", ";")
                    readmetho = Split("None;trilion;billion;million;thousand;US dollars;cents", ";")
                    If sNumber < 0 Then
                        toread = "Minus" & Space(1)
                    Else
                        toread = Space(0)
                    End If
                    numstring = Format(Math.Abs(sNumber), "##############0.00")
                    numstring = Strings.Right(Space(15) & numstring, 18)
                    For i = 1 To 6
                        group = Strings.Mid(numstring, i * 3 - 2, 3)
                        If group <> Space(3) Then
                            Select Case group
                                Case "000"
                                    If i = 5 And Math.Abs(sNumber) > 1 Then
                                        word = "dollar" & Space(1)
                                    Else
                                        word = Space(0)
                                    End If
                                Case ",00"
                                    word = "only"
                                Case Else
                                    x = Val(Strings.Left(group, 1))
                                    y = Val(Strings.Mid(group, 2, 1))
                                    z = Val(Strings.Right(group, 1))
                                    w = Val(Strings.Right(group, 2))
                                    If x = 0 Then
                                        word = Space(0)
                                    Else
                                        word = fristcolum(x) & Space(1) & "hundred" & Space(1)
                                        If w > 0 And w < 21 Then
                                            word = word & "and" & Space(1)
                                        End If
                                    End If
                                    If i = 6 And Math.Abs(sNumber) > 1 Then
                                        word = "and" & Space(1) & word
                                    End If
                                    If w < 20 And w > 0 Then
                                        word = word & fristcolum(w) & Space(1)
                                    ElseIf w >= 20 Then
                                        word = word & secondcolum(y) & Space(1)
                                        If z > 0 Then
                                            word = word & fristcolum(z) & Space(1)
                                        End If
                                    End If
                                    word = word & readmetho(i) & Space(1)
                            End Select
                            toread = toread & word
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return UCase(Strings.Left(toread, 1)) & Strings.Mid(toread, 2)
        End Try
        
        Return UCase(Strings.Left(toread, 1)) & Strings.Mid(toread, 2)
    End Function

    Public Function Number2Text(ByVal sNumber1 As Double, Optional ByVal usd As Integer = 0) As String
        Dim i As Long
        Dim mDigit As String
        Dim C As String

        Dim mNumText As String() = Split("không;một;hai;ba;bốn;năm;sáu;bảy;tám;chín", ";")
        Dim sNumber As Long = sNumber1
        Dim mLen As Long = Len(sNumber.ToString)
        Dim mTemp As String = ""
        Try
            For i = 1 To mLen
                mDigit = Mid(sNumber, i, 1)
                mTemp = String.Format("{0} {1}", mTemp, mNumText(mDigit))
                If (mLen = i) Then Exit For
                Select Case (mLen - i) Mod 9
                    Case 0
                        mTemp = mTemp & " tỷ"
                        If Mid(sNumber, i + 1, 3) = "000" Then i = i + 3
                        If Mid(sNumber, i + 1, 3) = "000" Then i = i + 3
                        If Mid(sNumber, i + 1, 3) = "000" Then i = i + 3
                    Case 6
                        mTemp = mTemp & " triệu"
                        If Mid(sNumber, i + 1, 3) = "000" Then i = i + 3
                        If Mid(sNumber, i + 1, 3) = "000" Then i = i + 3
                    Case 3
                        mTemp = mTemp & " nghìn"
                        If Mid(sNumber, i + 1, 3) = "000" Then i = i + 3
                    Case Else
                        Select Case (mLen - i) Mod 3
                            Case 2
                                mTemp = mTemp & " trăm"
                            Case 1
                                mTemp = mTemp & " mươi"
                        End Select
                End Select
            Next
            'Loại bỏ trường hợp x00
            mTemp = Replace(mTemp, "không mươi không", "")
            'Loại bỏ trường hợp 00x
            mTemp = Replace(mTemp, "không mươi ", "linh ")
            'Loại bỏ trường hợp x0, x>=2
            mTemp = Replace(mTemp, "mươi không", "mươi")
            'Fix trường hợp 10
            mTemp = Replace(mTemp, "một mươi", "mười")
            'Fix trường hợp x4, x>=2
            mTemp = Replace(mTemp, "mươi bốn", "mươi tư")
            'Fix trường hợp x04
            mTemp = Replace(mTemp, "linh bốn", "linh tư")
            'Fix trường hợp x5, x>=2
            mTemp = Replace(mTemp, "mươi năm", "mươi lăm")
            'Fix trường hợp x1, x>=2
            mTemp = Replace(mTemp, "mươi một", "mươi mốt")
            'Fix trường hợp x15
            mTemp = Replace(mTemp, "mười năm", "mười lăm")
            'Bỏ ký tự space
            mTemp = Trim(mTemp)
            'Ucase ký tự đầu tiên
            C = Mid(mTemp, 1, 1)
            Mid(mTemp, 1, 1) = UCase(C)

            sNumber = (sNumber1 - sNumber) * 100
            If sNumber > 0 Then
                mLen = Len(sNumber.ToString)
                Dim mtemp1 As String = ""
                For i = 1 To mLen
                    mDigit = Mid(sNumber, i, 1)
                    mtemp1 = String.Format("{0} {1}", mtemp1, mNumText(mDigit))
                    If (mLen = i) Then Exit For
                    Select Case (mLen - i) Mod 9
                        Case 0
                            mtemp1 = mtemp1 & " tỷ"
                            If Mid(sNumber, i + 1, 3) = "000" Then i = i + 3
                            If Mid(sNumber, i + 1, 3) = "000" Then i = i + 3
                            If Mid(sNumber, i + 1, 3) = "000" Then i = i + 3
                        Case 6
                            mtemp1 = mtemp1 & " triệu"
                            If Mid(sNumber, i + 1, 3) = "000" Then i = i + 3
                            If Mid(sNumber, i + 1, 3) = "000" Then i = i + 3
                        Case 3
                            mtemp1 = mtemp1 & " nghìn"
                            If Mid(sNumber, i + 1, 3) = "000" Then i = i + 3
                        Case Else
                            Select Case (mLen - i) Mod 3
                                Case 2
                                    mtemp1 = mtemp1 & " trăm"
                                Case 1
                                    mtemp1 = mtemp1 & " mươi"
                            End Select
                    End Select
                Next
                'Loại bỏ trường hợp x00
                mtemp1 = Replace(mtemp1, "không mươi không", "")
                'Loại bỏ trường hợp 00x
                mtemp1 = Replace(mtemp1, "không mươi ", "linh ")
                'Loại bỏ trường hợp x0, x>=2
                mtemp1 = Replace(mtemp1, "mươi không", "mươi")
                'Fix trường hợp 10
                mtemp1 = Replace(mtemp1, "một mươi", "mười")
                'Fix trường hợp x4, x>=2
                mtemp1 = Replace(mtemp1, "mươi bốn", "mươi tư")
                'Fix trường hợp x04
                mtemp1 = Replace(mtemp1, "linh bốn", "linh tư")
                'Fix trường hợp x5, x>=2
                mtemp1 = Replace(mtemp1, "mươi năm", "mươi lăm")
                'Fix trường hợp x1, x>=2
                mtemp1 = Replace(mtemp1, "mươi một", "mươi mốt")
                'Fix trường hợp x15
                mtemp1 = Replace(mtemp1, "mười năm", "mười lăm")
                'Bỏ ký tự space
                mtemp1 = Trim(mtemp1)
                Return String.Format("{0}{1} {2}{3}.", Mid(mTemp, 1, 1), Mid(mTemp, 2), IIf(usd = 0, "đồng", "đô la Mỹ"), IIf(mtemp1.ToString.ToLower <> "không", Space(1) & mtemp1 & " cents", ""))
            Else
                Return String.Format("{0}{1} {2}.", Mid(mTemp, 1, 1), Mid(mTemp, 2), IIf(usd = 0, "đồng", "đô la Mỹ"))
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        
    End Function
End Module
