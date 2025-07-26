Imports System
Imports System.Data
Imports System.Drawing
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter
Imports Excel = Microsoft.Office.Interop.Excel


Partial Friend Class FrmChamconggio
    Dim str As String = String.Empty
    Dim rs As DataTable
    Const mau As Integer = &H808080
    Dim mnv As String = String.Empty
    Dim Loitrichluong As Integer
    Dim Cong As Integer
    Dim Nghi As Integer
    Dim Phep As Integer
    Dim Tangca As Integer
    Dim Le As Integer
    Dim dkn, clickthang As Integer
    Dim MaDaTim As Integer
    Dim macongtrinh, Taikhoanthay As String
    Dim congtrinh As Integer
    Dim n1 As Double
    Dim N10 As Double
    Dim N11 As Double
    Dim N12 As Double
    Dim N13 As Double
    Dim N14 As Double
    Dim N15 As Double
    Dim N16 As Double
    Dim N17 As Double
    Dim N18 As Double
    Dim N19 As Double
    Dim n2 As Double
    Dim N20 As Double
    Dim N21 As Double
    Dim N22 As Double
    Dim N23 As Double
    Dim N24 As Double
    Dim N25 As Double
    Dim N26 As Double
    Dim N27 As Double
    Dim N28 As Double
    Dim N29 As Double
    Dim N3 As Double
    Dim N30 As Double
    Dim N4 As Double
    Dim N5 As Double
    Dim N6 As Double
    Dim N7 As Double
    Dim N8 As Double
    Dim N9 As Double
    Dim N31 As Double
    Dim N10d As Double
    Dim N11d As Double
    Dim N12d As Double
    Dim N13d As Double
    Dim N14d As Double
    Dim N15d As Double
    Dim N16d As Double
    Dim N17d As Double
    Dim N18d As Double
    Dim N19d As Double
    Dim N1d As Double
    Dim N20d As Double
    Dim N21d As Double
    Dim N22d As Double
    Dim N23d As Double
    Dim N24d As Double
    Dim N25d As Double
    Dim N26d As Double
    Dim N27d As Double
    Dim N28d As Double
    Dim N29d As Double
    Dim N2d As Double
    Dim N30d As Double
    Dim N3d As Double
    Dim N4d As Double
    Dim N5d As Double
    Dim N6d As Double
    Dim N7d As Double
    Dim N8d As Double
    Dim N9d As Double
    Dim N31d As Double
    Dim N10c As Double
    Dim N11c As Double
    Dim N12c As Double
    Dim N13c As Double
    Dim N14c As Double
    Dim N15c As Double
    Dim N16c As Double
    Dim N17c As Double
    Dim N18c As Double
    Dim N19c As Double
    Dim N1c As Double
    Dim N20c As Double
    Dim N21c As Double
    Dim N22c As Double
    Dim N23c As Double
    Dim N24c As Double
    Dim N25c As Double
    Dim N26c As Double
    Dim N27c As Double
    Dim N28c As Double
    Dim N29c As Double
    Dim N2c As Double
    Dim N30c As Double
    Dim N3c As Double
    Dim N4c As Double
    Dim N5c As Double
    Dim N6c As Double
    Dim N7c As Double
    Dim N8c As Double
    Dim N9c As Double
    Dim N31c As Double
    Dim N10t As Double
    Dim N11t As Double
    Dim N12t As Double
    Dim N13t As Double
    Dim N14t As Double
    Dim N15t As Double
    Dim N16t As Double
    Dim N17t As Double
    Dim N18t As Double
    Dim N19t As Double
    Dim N1t As Double
    Dim N20t As Double
    Dim N21t As Double
    Dim N22t As Double
    Dim N23t As Double
    Dim N24t As Double
    Dim N25t As Double
    Dim N26t As Double
    Dim N27t As Double
    Dim N28t As Double
    Dim N29t As Double
    Dim N2t As Double
    Dim N30t As Double
    Dim N3t As Double
    Dim N4t As Double
    Dim N5t As Double
    Dim N6t As Double
    Dim N7t As Double
    Dim N8t As Double
    Dim N9t As Double
    Dim N31t As Double
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        'ColumnSetUp(GrdNhanvien, 0, 350, 2)
        'ColumnSetUp(GrdNhanvien, 1, 2380, 0)
        'ColumnSetUp(GrdNhanvien, 2, 1900, 0)
        'ColumnSetUp(GrdNhanvien, 3, 1900, 0)

        'GrdNhanvien.Cols = 36

        'For i As Integer = 1 To 31
        '    ColumnSetUp(GrdNhanvien, i + 3, 260, 2)
        'Next

        'Text = SetFormTitle(Text)

        'AddMonthToCbo(CboThang)
        'If CboThang.Items.Count > 0 Then
        '    CboThang.SelectedIndex = Today.Month - 1
        'End If
        'Hienthiluoi()
        Khoaquyen()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmChamconggio_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        'set icon
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
        ' Init form 
        Call FormInit()
        ColumnSetUp(GrdNhanvien, 0, 350, 2)
        ColumnSetUp(GrdNhanvien, 1, 2380, 0)
        ColumnSetUp(GrdNhanvien, 2, 1900, 0)
        ColumnSetUp(GrdNhanvien, 3, 1900, 0)

        GrdNhanvien.Cols = 36

        For i As Integer = 1 To 31
            ColumnSetUp(GrdNhanvien, i + 3, 260, 2)
        Next

        Text = SetFormTitle(Text)

        AddMonthToCbo(CboThang)
        If CboThang.Items.Count > 0 Then
            CboThang.SelectedIndex = Today.Month - 1
        End If
        Hienthiluoi()
        SetFont(Me)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboThang_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboThang.SelectedIndexChanged
        ResetLe()
        Lich.SelectionStart = Lich.SelectionStart.AddMonths(CboThang.SelectedValue - Lich.SelectionStart.Month)
        Lich.SelectionStart = Lich.SelectionStart.AddYears(frmMain._LbCty_7.Text - Lich.SelectionStart.Year)
        For i As Integer = 28 To 31
            Label(i).Visible = True
            txtnd(i).Visible = True
            txtnc(i).Visible = True
            txtn(i).Visible = True
            GrdNhanvien.Cols = ConvertToDblSafe(i + 5)
            ColumnSetUp(GrdNhanvien, i + 3, 225, 0)
        Next
        For i As Integer = DayofMonth(Lich) + 1 To 31
            Label(i).Visible = False
            txtnd(i).Visible = False
            txtnc(i).Visible = False
            txtn(i).Visible = False
            txtnd(i).Text = "0"
            txtnc(i).Text = "0"
            txtn(i).Text = "0"
            ColumnSetUp(GrdNhanvien, i + 3, 0, 0)
            GrdNhanvien.Cols = ConvertToDblSafe(GrdNhanvien.Cols - 1)
        Next
        txtnd(32).Left = txtnd(DayofMonth(Lich)).Left + txtnd(DayofMonth(Lich)).Width
        txtnc(32).Left = txtnc(DayofMonth(Lich)).Left + txtnc(DayofMonth(Lich)).Width
        txtn(32).Left = txtn(DayofMonth(Lich)).Left + txtn(DayofMonth(Lich)).Width
        dkn = Lich.SelectionStart.Month
        Hienthiluoi()
        clickthang = 1
        GrdNhanvien_DblClick(GrdNhanvien, New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim str1 As String = String.Empty
        If User_Right = 2 Then
            HienThongBao("Không có quyền truy cập!", 1)
            GoTo XongVT
        End If
        Me.Cursor = Cursors.WaitCursor
        If Index = 0 Or Index = 2 Then
            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT lock{0} as f1 FROM license", CboThang.SelectedValue))) = 1 Then
                If FrmPassword.GetPswX(String.Format("Dữ liệu tháng {0} đã bị khoá. Nhập mật khẩu ...", CboThang.SelectedValue)) <> "MS" Then GoTo XongVT
            End If
        End If
        Select Case Index
            Case 0
                Ghi()
                Tinhluong()
            Case 1
                Me.Close() : Exit Sub
            Case 2
                Xoa()
        End Select
XongVT:
        Hienthiluoi()
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Ngay"></param>
    ''' <param name="thang"></param>
    ''' <param name="Nam"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ChuNhat(ByRef Ngay As Integer, ByRef thang As Integer, ByRef Nam As Integer) As Boolean
        Dim result As Boolean = False
        If DateAndTime.Weekday(DateSerial(Nam, thang, Ngay), FirstDayOfWeek.Sunday) = 1 Then result = True
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Tinhluong()
        Dim nv As New ClsChucDanh
        Dim sogio, luonggiocu, luonggiomoi As Double
        Dim MasoNV As Integer
        If mnv.Length = 0 Then GoTo XongVT
        nv.InitMaSo(ConvertToDblSafe(GetSelectValue(String.Format("SELECT maso as f1 FROM chucdanh WHERE nhanvien=N'{0}' and nam={1} and thang={2} order by nam desc, thang desc", _
                                                        mnv, _
                                                        frmMain._LbCty_7.Text, _
                                                        ConvertToStrSafe(Lich.SelectionStart.Month)))))
        Dim dem1, dem2 As Double
        Dim str As String = String.Empty
        sogio = ConvertToDblSafe(GetSelectValue(String.Format("SELECT (n1t+n2t+n3t+n4t+n5t+n6t+n7t+n8t+n9t+n10t+n11t+n12t+n13t+n14t+n15t+n16t+n17t+n18t+n19t+n20t+n21t+n22t+n23t+n24t+n25t+n26t+n27t+n28t+n29t+n30t+n31t) as f1 FROM chamconggio WHERE manhanvien=N'{0}' and thang={1}", _
                                                    mnv, _
                                                    ConvertToStrSafe(Lich.SelectionStart.Month))))
        str = "SELECT(0"
        If nv.maso <> 0 Then
            For j As Integer = 1 To DateAndTime.Day(nv.NgayApdung) - 1
                str = String.Format("{0}+n{1}t", str, ConvertToStrSafe(j))
            Next
            str = String.Format("{0})as f1 FROM chamconggio WHERE manhanvien=N'{1}' and thang={2}", str, mnv, ConvertToStrSafe(Lich.SelectionStart.Month))
            dem1 = ConvertToDblSafe(GetSelectValue(str))
            luonggiomoi = Luonggio(nv, Lich)
            If DateAndTime.Day(nv.NgayApdung) = 1 Then GoTo Khongcu
        Else
            dem1 = sogio
        End If
Khongcu:
        dem2 = sogio - dem1
        MasoNV = ConvertToDblSafe((GetSelectValue(String.Format("SELECT maso as f1 FROM chucdanh WHERE nhanvien=N'{0}' and (nam<{1} or (nam={1} and thang<={2})) order by nam desc, thang desc", _
                                                                      mnv, _
                                                                      frmMain._LbCty_7.Text, _
                                                                      ConvertToStrSafe(Lich.SelectionStart.Month)))))
        On Error GoTo Loi
        If MasoNV <> 0 Then
            nv.InitMaSo(MasoNV) : luonggiocu = Luonggio(nv, Lich)
        End If
        Dim rowEffectCount As Integer = ExecSQLNonQuery(String.Format("UPDATE PhuCap SET Tangca={0} WHERE sohieunhanvien=N'{1}' AND thang={2}", _
                                                            CStr(luonggiomoi * dem2 + luonggiocu * dem1), _
                                                            nv.Nhanvien, _
                                                            ConvertToStrSafe(Lich.SelectionStart.Month)))
        If rowEffectCount <= 0 Then
            ExecSQLNonQuery(String.Format("INSERT INTO PhuCap (MaSo,maphanloai,machucvu,sohieunhanvien,loai,thang,tangca) VALUES ({0},{1},{2}, N'{3}',2,{4},{5})", _
                                Lng_MaxValue("MaSo", "PhuCap") + 1, _
                                Timten("maphanloai", nv.Nhanvien, "sohieu", "Quanlynhanvien"), _
                                ConvertToStrSafe(nv.chucvu), _
                                nv.Nhanvien, _
                                ConvertToStrSafe(Lich.SelectionStart.Month), _
                                CStr(luonggiomoi * dem2 + luonggiocu * dem1)))
        End If
        ExecSQLNonQuery(String.Format("UPDATE thongsoluong set tangcagio={0} WHERE sohieunhanvien=N'{1}' and thang={2}", _
                            luonggiomoi * dem2 + luonggiocu * dem1, _
                            nv.Nhanvien, _
                            ConvertToStrSafe(Lich.SelectionStart.Month)))
XongVT:
        nv = Nothing
        mnv = ""
        Exit Sub
Loi:
        MessageBox.Show(Ngonngu("Vui lòng chấm công tháng này trước khi chấm tăng ca", "Please attendance before overtime attendance"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="nv"></param>
    ''' <param name="Lich"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Luonggio(ByRef nv As ClsChucDanh, ByRef Lich As MonthCalendar) As Double
        Dim songay As Integer
        Dim ngaycuathang As Integer = DayofMonth(Lich)
        Dim rs1 As DataTable = ExecSQLReturnDT(String.Format("SELECT MaNhanVien,N1, N2, N3, N4, N5, N6, N7, N8, N9, N10, N11, N12, N13, N14, N15, N16, N17, N18, N19, N20, N21, N22, N23, N24, N25, N26, N27, N28, N29, N30, N31 FROM chamcong WHERE thang={0} order by manhanvien", Lich.SelectionStart.Month))
        Try
            For Each rsItem As DataRow In rs1.Rows
                If songay > 0 Then
                    Exit For
                End If
                For i As Integer = 1 To ngaycuathang
                    Dim testValue As String = ConvertToStrSafe(rsItem(String.Format("N{0}", i)))
                    If testValue.Trim = "c" Or testValue.Trim = "v" Or testValue.Trim = "p" Or testValue.Trim = "l" Or testValue.Trim = "r" Or testValue.Trim = "t" Then
                        songay += 1
                    End If
                    If testValue.Trim = "s" Or testValue.Trim = "n" Then
                        songay = 0
                        Exit For
                    End If
                Next
            Next
        Catch
        End Try
        If nv.LoaiLuong <> 4 Then
            Return Luongthang(nv) / songay / 8
            'If songay = 0 Then
            '    Return Luongthang(nv) / 8
            'Else
            '    Return Luongthang(nv) / songay / 8
            'End If
        Else
            Return Luongthang(nv) / 8
        End If
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
                result = ConvertToDblSafe(Format(ConvertToDblSafe(timtenmax(String.Format("HSB{0}", .BacLuong), ConvertToStrSafe(.chucvu), "maso", "Chucvu")) * ConvertToDblSafe((GetSelectValue("SELECT lcb as f1 FROM license"))), Mask_0))
            Else
                If .LoaiLuong = 2 Then
                    result = ConvertToDblSafe(Format(ConvertToDblSafe(timtenmax(String.Format("MLB{0}", .BacLuong), ConvertToStrSafe(.chucvu), "maso", "Chucvu")), Mask_0))
                Else
                    If .LoaiLuong = 3 Then
                        result = ConvertToDblSafe(Format(ConvertToDblSafe(timtenmax(String.Format("TVB{0}", .BacLuong), ConvertToStrSafe(.chucvu), "maso", "Chucvu")), Mask_0))
                    Else
                        result = ConvertToDblSafe(Format(ConvertToDblSafe(timtenmax(String.Format("LNB{0}", .BacLuong), ConvertToStrSafe(.chucvu), "maso", "Chucvu")), Mask_0))
                    End If
                End If
            End If
        End With
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Xoa()
        ExecSQLNonQuery(String.Format("UPDATE PhuCap SET Tangca=0 WHERE thang={0}", Lich.SelectionStart.Month))
        ExecSQLNonQuery(String.Format("UPDATE thongsoluong set tangcagio=0 WHERE thang={0}", Lich.SelectionStart.Month))
        ExecSQLNonQuery(String.Format("DELETE  FROM chamconggio WHERE thang={0}", Lich.SelectionStart.Month))
        Hienthiluoi()
        GrdNhanvien.Focus()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Ghi()
        Dim rs As DataTable
        Dim str, str1 As String
        If KiemTraSoLieu() And mnv.Length <> 0 Then
            str = String.Empty
            str1 = String.Empty
            str = String.Format("SELECT * FROM chamconggio WHERE thang={0} and manhanvien=N'{1}'", Lich.SelectionStart.Month, mnv)
            rs = ExecSQLReturnDT(str)
            If rs.Rows.Count = 0 Then
                str = String.Format("INSERT into chamconggio(maso,manhanvien,thang,cong,nghi,phep,tangca,n1,n2,n3,n4,n5,n6,n7,n8,n9,n10,n11,n12,n13,n14,n15,n16,n17,n18,n19,n20,n21,n22,n23,n24,n25,n26,n27,n28,n29,n30,n31,n1d,n2d,n3d,n4d,n5d,n6d,n7d,n8d,n9d,n10d,n11d,n12d,n13d,n14d,n15d,n16d,n17d,n18d,n19d,n20d,n21d,n22d,n23d,n24d,n25d,n26d,n27d,n28d,n29d,n30d,n31d,n1c,n2c,n3c,n4c,n5c,n6c,n7c,n8c,n9c,n10c,n11c,n12c,n13c,n14c,n15c,n16c,n17c,n18c,n19c,n20c,n21c,n22c,n23c,n24c,n25c,n26c,n27c,n28c,n29c,n30c,n31c,n1t,n2t,n3t,n4t,n5t,n6t,n7t,n8t,n9t,n10t,n11t,n12t,n13t,n14t,n15t,n16t,n17t,n18t,n19t,n20t,n21t,n22t,n23t,n24t,n25t,n26t,n27t,n28t,n29t,n30t,n31t) values({0}, N'{1}',{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27},{28},{29},{30},{31},{32},{33},{34},{35},{36},{37},{38},{39},{40},{41},{42},{43},{44},{45},{46},{47},{48},{49},{50},{51},{52},{53},{54},{55},{56},{57},{58},{59},{60},{61},{62},{63},{64},{65},{66},{67},{68},{69},{70},{71},{72},{73},{74},{75},{76},{77},{78},{79},{80},{81},{82},{83},{84},{85},{86},{87},{88},{89},{90},{91},{92},{93},{94},{95},{96},{97},{98},{99},{100},{101},{102},{103},{104},{105},{106},{107},{108},{109},{110},{111},{112},{113},{114},{115},{116},{117},{118},{119},{120},{121},{122},{123},{124},{125},{126},{127},{128},{129},{130})", _
                          ConvertToStrSafe(Lng_MaxValue("MaSo", "chamconggio") + 1), _
                          mnv, _
                          ConvertToStrSafe(CboThang.SelectedIndex + 1), _
                          ConvertToStrSafe(Cong), _
                          ConvertToStrSafe(Nghi), _
                          ConvertToStrSafe(Phep), _
                          ConvertToStrSafe(Tangca), _
                          ConvertToStrSafe(n1), _
                          ConvertToStrSafe(n2), _
                          ConvertToStrSafe(N3), _
                          ConvertToStrSafe(N4), _
                          ConvertToStrSafe(N5), _
                          ConvertToStrSafe(N6), _
                          ConvertToStrSafe(N7), _
                          ConvertToStrSafe(N8), _
                          ConvertToStrSafe(N9), _
                          ConvertToStrSafe(N10), _
                          ConvertToStrSafe(N11), _
                          ConvertToStrSafe(N12), _
                          ConvertToStrSafe(N13), _
                          ConvertToStrSafe(N14), _
                          ConvertToStrSafe(N15), _
                          ConvertToStrSafe(N16), _
                          ConvertToStrSafe(N17), _
                          ConvertToStrSafe(N18), _
                          ConvertToStrSafe(N19), _
                          ConvertToStrSafe(N20), _
                          ConvertToStrSafe(N21), _
                          ConvertToStrSafe(N22), _
                          ConvertToStrSafe(N23), _
                          ConvertToStrSafe(N24), _
                          ConvertToStrSafe(N25), _
                          ConvertToStrSafe(N26), _
                          ConvertToStrSafe(N27), _
                          ConvertToStrSafe(N28), _
                          ConvertToStrSafe(N29), _
                          ConvertToStrSafe(N30), _
                          ConvertToStrSafe(N31), _
                          ConvertToStrSafe(N1d), _
                          ConvertToStrSafe(N2d), _
                          ConvertToStrSafe(N3d), _
                          ConvertToStrSafe(N4d), _
                          ConvertToStrSafe(N5d), _
                          ConvertToStrSafe(N6d), _
                          ConvertToStrSafe(N7d), _
                          ConvertToStrSafe(N8d), _
                          ConvertToStrSafe(N9d), _
                          ConvertToStrSafe(N10d), _
                          ConvertToStrSafe(N11d), _
                          ConvertToStrSafe(N12d), _
                          ConvertToStrSafe(N13d), _
                          ConvertToStrSafe(N14d), _
                          ConvertToStrSafe(N15d), _
                          ConvertToStrSafe(N16d), _
                          ConvertToStrSafe(N17d), _
                          ConvertToStrSafe(N18d), _
                          ConvertToStrSafe(N19d), _
                          ConvertToStrSafe(N20d), _
                          ConvertToStrSafe(N21d), _
                          ConvertToStrSafe(N22d), _
                          ConvertToStrSafe(N23d), _
                          ConvertToStrSafe(N24d), _
                          ConvertToStrSafe(N25d), _
                          ConvertToStrSafe(N26d), _
                          ConvertToStrSafe(N27d), _
                          ConvertToStrSafe(N28d), _
                          ConvertToStrSafe(N29d), _
                          ConvertToStrSafe(N30d), _
                          ConvertToStrSafe(N31d), _
                          ConvertToStrSafe(N1c), _
                          ConvertToStrSafe(N2c), _
                          ConvertToStrSafe(N3c), _
                          ConvertToStrSafe(N4c), _
                          ConvertToStrSafe(N5c), _
                          ConvertToStrSafe(N6c), _
                          ConvertToStrSafe(N7c), _
                          ConvertToStrSafe(N8c), _
                          ConvertToStrSafe(N9c), _
                          ConvertToStrSafe(N10c), _
                          ConvertToStrSafe(N11c), _
                          ConvertToStrSafe(N12c), _
                          ConvertToStrSafe(N13c), _
                          ConvertToStrSafe(N14c), _
                          ConvertToStrSafe(N15c), _
                          ConvertToStrSafe(N16c), _
                          ConvertToStrSafe(N17c), _
                          ConvertToStrSafe(N18c), _
                          ConvertToStrSafe(N19c), _
                          ConvertToStrSafe(N20c), _
                          ConvertToStrSafe(N21c), _
                          ConvertToStrSafe(N22c), _
                          ConvertToStrSafe(N23c), _
                          ConvertToStrSafe(N24c), _
                          ConvertToStrSafe(N25c), _
                          ConvertToStrSafe(N26c), _
                          ConvertToStrSafe(N27c), _
                          ConvertToStrSafe(N28c), _
                          ConvertToStrSafe(N29c), _
                          ConvertToStrSafe(N30c), _
                          ConvertToStrSafe(N31c), _
                          ConvertToStrSafe(N1t), _
                          ConvertToStrSafe(N2t), _
                          ConvertToStrSafe(N3t), _
                          ConvertToStrSafe(N4t), _
                          ConvertToStrSafe(N5t), _
                          ConvertToStrSafe(N6t), _
                          ConvertToStrSafe(N7t), _
                          ConvertToStrSafe(N8t), _
                          ConvertToStrSafe(N9t), _
                          ConvertToStrSafe(N10t), _
                          ConvertToStrSafe(N11t), _
                          ConvertToStrSafe(N12t), _
                          ConvertToStrSafe(N13t), _
                          ConvertToStrSafe(N14t), _
                          ConvertToStrSafe(N15t), _
                          ConvertToStrSafe(N16t), _
                          ConvertToStrSafe(N17t), _
                          ConvertToStrSafe(N18t), _
                          ConvertToStrSafe(N19t), _
                          ConvertToStrSafe(N20t), _
                          ConvertToStrSafe(N21t), _
                          ConvertToStrSafe(N22t), _
                          ConvertToStrSafe(N23t), _
                          ConvertToStrSafe(N24t), _
                          ConvertToStrSafe(N25t), _
                          ConvertToStrSafe(N26t), _
                          ConvertToStrSafe(N27t), _
                          ConvertToStrSafe(N28t), _
                          ConvertToStrSafe(N29t), _
                          ConvertToStrSafe(N30t), _
                          ConvertToStrSafe(N31t))
            Else
                str = String.Format("UPDATE chamconggio set cong={0},phep={1},nghi={2},tangca={3},n1={4},n2={5},n3={6},n4={7},n5={8},n6={9},n7={10},n8={11},n9={12},n10={13},n11={14},n12={15},n13={16},n14={17},n15={18},n16={19},n17={20},n18={21},n19={22},n20={23},n21={24},n22={25},n23={26},n24={27},n25={28},n26={29},n27={30},n28={31},n29={32},n30={33},n31={34},n1d={35},n2d={36},n3d={37},n4d={38},n5d={39},n6d={40},n7d={41},n8d={42},n9d={43},n10d={44},n11d={45},n12d={46},n13d={47},n14d={48},n15d={49},n16d={50},n17d={51},n18d={52},n19d={53},n20d={54},n21d={55},n22d={56},n23d={57},n24d={58},n25d={59},n26d={60},n27d={61},n28d={62},n29d={63},n30d={64},n31d={65},n1c={66},n2c={67},n3c={68},n4c={69},n5c={70},n6c={71},n7c={72},n8c={73},n9c={74},n10c={75},n11c={76},n12c={77},n13c={78},n14c={79},n15c={80},n16c={81},n17c={82},n18c={83},n19c={84},n20c={85},n21c={86},n22c={87},n23c={88},n24c={89},n25c={90},n26c={91},n27c={92},n28c={93},n29c={94},n30c={95},n31c={96} WHERE thang={97} and manhanvien=N'{98}'", _
                          Cong, _
                          ConvertToStrSafe(Phep), _
                          ConvertToStrSafe(Nghi), _
                          ConvertToStrSafe(Tangca), _
                          ConvertToStrSafe(n1), _
                          ConvertToStrSafe(n2), _
                          ConvertToStrSafe(N3), _
                          ConvertToStrSafe(N4), _
                          ConvertToStrSafe(N5), _
                          ConvertToStrSafe(N6), _
                          ConvertToStrSafe(N7), _
                          ConvertToStrSafe(N8), _
                          ConvertToStrSafe(N9), _
                          ConvertToStrSafe(N10), _
                          ConvertToStrSafe(N11), _
                          ConvertToStrSafe(N12), _
                          ConvertToStrSafe(N13), _
                          ConvertToStrSafe(N14), _
                          ConvertToStrSafe(N15), _
                          ConvertToStrSafe(N16), _
                          ConvertToStrSafe(N17), _
                          ConvertToStrSafe(N18), _
                          ConvertToStrSafe(N19), _
                          ConvertToStrSafe(N20), _
                          ConvertToStrSafe(N21), _
                          ConvertToStrSafe(N22), _
                          ConvertToStrSafe(N23), _
                          ConvertToStrSafe(N24), _
                          ConvertToStrSafe(N25), _
                          ConvertToStrSafe(N26), _
                          ConvertToStrSafe(N27), _
                          ConvertToStrSafe(N28), _
                          ConvertToStrSafe(N29), _
                          ConvertToStrSafe(N30), _
                          ConvertToStrSafe(N31), _
                          ConvertToStrSafe(N1d), _
                          ConvertToStrSafe(N2d), _
                          ConvertToStrSafe(N3d), _
                          ConvertToStrSafe(N4d), _
                          ConvertToStrSafe(N5d), _
                          ConvertToStrSafe(N6d), _
                          ConvertToStrSafe(N7d), _
                          ConvertToStrSafe(N8d), _
                          ConvertToStrSafe(N9d), _
                          ConvertToStrSafe(N10d), _
                          ConvertToStrSafe(N11d), _
                          ConvertToStrSafe(N12d), _
                          ConvertToStrSafe(N13d), _
                          ConvertToStrSafe(N14d), _
                          ConvertToStrSafe(N15d), _
                          ConvertToStrSafe(N16d), _
                          ConvertToStrSafe(N17d), _
                          ConvertToStrSafe(N18d), _
                          ConvertToStrSafe(N19d), _
                          ConvertToStrSafe(N20d), _
                          ConvertToStrSafe(N21d), _
                          ConvertToStrSafe(N22d), _
                          ConvertToStrSafe(N23d), _
                          ConvertToStrSafe(N24d), _
                          ConvertToStrSafe(N25d), _
                          ConvertToStrSafe(N26d), _
                          ConvertToStrSafe(N27d), _
                          ConvertToStrSafe(N28d), _
                          ConvertToStrSafe(N29d), _
                          ConvertToStrSafe(N30d), _
                          ConvertToStrSafe(N31d), _
                          ConvertToStrSafe(N1c), _
                          ConvertToStrSafe(N2c), _
                          ConvertToStrSafe(N3c), _
                          ConvertToStrSafe(N4c), _
                          ConvertToStrSafe(N5c), _
                          ConvertToStrSafe(N6c), _
                          ConvertToStrSafe(N7c), _
                          ConvertToStrSafe(N8c), _
                          ConvertToStrSafe(N9c), _
                          ConvertToStrSafe(N10c), _
                          ConvertToStrSafe(N11c), _
                          ConvertToStrSafe(N12c), _
                          ConvertToStrSafe(N13c), _
                          ConvertToStrSafe(N14c), _
                          ConvertToStrSafe(N15c), _
                          ConvertToStrSafe(N16c), _
                          ConvertToStrSafe(N17c), _
                          ConvertToStrSafe(N18c), _
                          ConvertToStrSafe(N19c), _
                          ConvertToStrSafe(N20c), _
                          ConvertToStrSafe(N21c), _
                          ConvertToStrSafe(N22c), _
                          ConvertToStrSafe(N23c), _
                          ConvertToStrSafe(N24c), _
                          ConvertToStrSafe(N25c), _
                          ConvertToStrSafe(N26c), _
                          ConvertToStrSafe(N27c), _
                          ConvertToStrSafe(N28c), _
                          ConvertToStrSafe(N29c), _
                          ConvertToStrSafe(N30c), _
                          ConvertToStrSafe(N31c), _
                          ConvertToStrSafe(Lich.SelectionStart.Month), _
                          mnv)
                str1 = String.Format("UPDATE chamconggio set cong={0},phep={1},nghi={2},tangca={3},n1t={4},n2t={5},n3t={6},n4t={7},n5t={8},n6t={9},n7t={10},n8t={11},n9t={12},n10t={13},n11t={14},n12t={15},n13t={16},n14t={17},n15t={18},n16t={19},n17t={20},n18t={21},n19t={22},n20t={23},n21t={24},n22t={25},n23t={26},n24t={27},n25t={28},n26t={29},n27t={30},n28t={31},n29t={32},n30t={33},n31t={34} WHERE thang={35} and manhanvien=N'{36}'", _
                           Cong, _
                           ConvertToStrSafe(Phep), _
                           ConvertToStrSafe(Nghi), _
                           ConvertToStrSafe(Tangca), _
                           ConvertToStrSafe(N1t), _
                           ConvertToStrSafe(N2t), _
                           ConvertToStrSafe(N3t), _
                           ConvertToStrSafe(N4t), _
                           ConvertToStrSafe(N5t), _
                           ConvertToStrSafe(N6t), _
                           ConvertToStrSafe(N7t), _
                           ConvertToStrSafe(N8t), _
                           ConvertToStrSafe(N9t), _
                           ConvertToStrSafe(N10t), _
                           ConvertToStrSafe(N11t), _
                           ConvertToStrSafe(N12t), _
                           ConvertToStrSafe(N13t), _
                           ConvertToStrSafe(N14t), _
                           ConvertToStrSafe(N15t), _
                           ConvertToStrSafe(N16t), _
                           ConvertToStrSafe(N17t), _
                           ConvertToStrSafe(N18t), _
                           ConvertToStrSafe(N19t), _
                           ConvertToStrSafe(N20t), _
                           ConvertToStrSafe(N21t), _
                           ConvertToStrSafe(N22t), _
                           ConvertToStrSafe(N23t), _
                           ConvertToStrSafe(N24t), _
                           ConvertToStrSafe(N25t), _
                           ConvertToStrSafe(N26t), _
                           ConvertToStrSafe(N27t), _
                           ConvertToStrSafe(N28t), _
                           ConvertToStrSafe(N29t), _
                           ConvertToStrSafe(N30t), _
                           ConvertToStrSafe(N31t), _
                           ConvertToStrSafe(Lich.SelectionStart.Month), _
                           mnv)
            End If
            If rs.Rows.Count > 0 Then
                If ExecSQLNonQuery(str) <> 0 Or ExecSQLNonQuery(str1) <> 0 Then
                    ErrMsg(er_SoHieu)
                End If
            Else
                If ExecSQLNonQuery(str) <> 0 Then
                    ErrMsg(er_SoHieu)
                End If
            End If
        End If
        ResetLe()
        Hienthiluoi()
        For i As Integer = 0 To 31
            If i < 3 Then txtch(i).Text = String.Empty
            If i > 0 Then
                txtnd(i).Text = String.Empty
                txtnc(i).Text = String.Empty
                txtn(i).Text = String.Empty
            End If
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub ResetLe()
        For i As Integer = 41 To 71
            Label(i).Visible = False
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function KiemTraSoLieu() As Boolean
        Dim result As Boolean = False
        Dim TyLe As Double
        Cursor = Cursors.WaitCursor
        Dim txtnINT As Double = 0
        Dim txtndINT As Double = 0
        Dim txtncINT As Double = 0
        For i As Integer = 1 To 31
            txtnINT = 0
            txtndINT = 0
            txtncINT = 0

            Double.TryParse(txtn(i).Text, txtnINT)
            Double.TryParse(txtnd(i).Text, txtndINT)
            Double.TryParse(txtnc(i).Text, txtncINT)

            Select Case i
                Case 1
                    n1 = txtnINT
                    N1d = txtndINT
                    N1c = txtncINT
                    Exit Select
                Case 2
                    n2 = txtnINT
                    N2d = txtndINT
                    N2c = txtncINT
                    Exit Select
                Case 3
                    N3 = txtnINT
                    N3d = txtndINT
                    N3c = txtncINT
                    Exit Select
                Case 4
                    N4 = txtnINT
                    N4d = txtndINT
                    N4c = txtncINT
                    Exit Select
                Case 5
                    N5 = txtnINT
                    N5d = txtndINT
                    N5c = txtncINT
                    Exit Select
                Case 6
                    N6 = txtnINT
                    N6d = txtndINT
                    N6c = txtncINT
                    Exit Select
                Case 7
                    N7 = txtnINT
                    N7d = txtndINT
                    N7c = txtncINT
                    Exit Select
                Case 8
                    N8 = txtnINT
                    N8d = txtndINT
                    N8c = txtncINT
                    Exit Select
                Case 9
                    N9 = txtnINT
                    N9d = txtndINT
                    N9c = txtncINT
                    Exit Select
                Case 10
                    N10 = txtnINT
                    N10d = txtndINT
                    N10c = txtncINT
                    Exit Select
                Case 11
                    N11 = txtnINT
                    N11d = txtndINT
                    N11c = txtncINT
                    Exit Select
                Case 12
                    N12 = txtnINT
                    N12d = txtndINT
                    N12c = txtncINT
                    Exit Select
                Case 13
                    N13 = txtnINT
                    N13d = txtndINT
                    N13c = txtncINT
                    Exit Select
                Case 14
                    N14 = txtnINT
                    N14d = txtndINT
                    N14c = txtncINT
                    Exit Select
                Case 15
                    N15 = txtnINT
                    N15d = txtndINT
                    N15c = txtncINT
                    Exit Select
                Case 16
                    N16 = txtnINT
                    N16d = txtndINT
                    N16c = txtncINT
                    Exit Select
                Case 17
                    N17 = txtnINT
                    N17d = txtndINT
                    N17c = txtncINT
                    Exit Select
                Case 18
                    N18 = txtnINT
                    N18d = txtndINT
                    N18c = txtncINT
                    Exit Select
                Case 19
                    N19 = txtnINT
                    N19d = txtndINT
                    N19c = txtncINT
                    Exit Select
                Case 20
                    N20 = txtnINT
                    N20d = txtndINT
                    N20c = txtncINT
                    Exit Select
                Case 21
                    N21 = txtnINT
                    N21d = txtndINT
                    N21c = txtncINT
                    Exit Select
                Case 22
                    N22 = txtnINT
                    N22d = txtndINT
                    N22c = txtncINT
                    Exit Select
                Case 23
                    N23 = txtnINT
                    N23d = txtndINT
                    N23c = txtncINT
                    Exit Select
                Case 24
                    N24 = txtnINT
                    N24d = txtndINT
                    N24c = txtncINT
                    Exit Select
                Case 25
                    N25 = txtnINT
                    N25d = txtndINT
                    N25c = txtncINT
                    Exit Select
                Case 26
                    N26 = txtnINT
                    N26d = txtndINT
                    N26c = txtncINT
                    Exit Select
                Case 27
                    N27 = txtnINT
                    N27d = txtndINT
                    N27c = txtncINT
                    Exit Select
                Case 28
                    N28 = txtnINT
                    N28d = txtndINT
                    N28c = txtncINT
                    Exit Select
                Case 29
                    N29 = txtnINT
                    N29d = txtndINT
                    N29c = txtncINT
                    Exit Select
                Case 30
                    N30 = txtnINT
                    N30d = txtndINT
                    N30c = txtncINT
                    Exit Select
                Case 31
                    N31 = txtnINT
                    N31d = txtndINT
                    N31c = txtncINT
            End Select
        Next

        For i As Integer = 1 To 28
            If Label(i).BackColor.Equals(Color.Red) Then
                TyLe = ConvertToDblSafe(TxtChunhat.Text)
            Else
                If Label(i).BackColor.Equals(Color.Gray) Then
                    TyLe = ConvertToDblSafe(TxtNgayle.Text)
                Else
                    TyLe = ConvertToDblSafe(TxtTrongtuan.Text)
                End If
            End If
            Select Case i
                Case 1
                    N1t = TyLe * n1
                    Exit Select
                Case 2
                    N2t = TyLe * n2
                    Exit Select
                Case 3
                    N3t = TyLe * N3
                    Exit Select
                Case 4
                    N4t = TyLe * N4
                    Exit Select
                Case 5
                    N5t = TyLe * N5
                    Exit Select
                Case 6
                    N6t = TyLe * N6
                    Exit Select
                Case 7
                    N7t = TyLe * N7
                    Exit Select
                Case 8
                    N8t = TyLe * N8
                    Exit Select
                Case 9
                    N9t = TyLe * N9
                    Exit Select
                Case 10
                    N10t = TyLe * N10
                    Exit Select
                Case 11
                    N11t = TyLe * N11
                    Exit Select
                Case 12
                    N12t = TyLe * N12

                Case 13
                    N13t = TyLe * N13
                    Exit Select
                Case 14
                    N14t = TyLe * N14
                    Exit Select
                Case 15
                    N15t = TyLe * N15
                    Exit Select
                Case 16
                    N16t = TyLe * N16
                    Exit Select
                Case 17
                    N17t = TyLe * N17
                    Exit Select
                Case 18
                    N18t = TyLe * N18
                    Exit Select
                Case 19
                    N19t = TyLe * N19
                    Exit Select
                Case 20
                    N20t = TyLe * N20
                    Exit Select
                Case 21
                    N21t = TyLe * N21
                    Exit Select
                Case 22
                    N22t = TyLe * N22
                    Exit Select
                Case 23
                    N23t = TyLe * N23
                    Exit Select
                Case 24
                    N24t = TyLe * N24
                    Exit Select
                Case 25
                    N25t = TyLe * N25
                    Exit Select
                Case 26
                    N26t = TyLe * N26
                    Exit Select
                Case 27
                    N27t = TyLe * N27
                    Exit Select
                Case 28
                    N28t = TyLe * N28
                    Exit Select
                Case 29
                    N29t = TyLe * N29
                    Exit Select
                Case 30
                    N30t = TyLe * N30
                    Exit Select
                Case 31
                    N31t = ConvertToStrSafe(TyLe * ConvertToDblSafe(N31))
            End Select
        Next

        For i As Integer = 29 To 31
            If Not Label(i).Visible Then
                Select Case i
                    Case 29
                        N29t = 0
                        Exit Select
                    Case 30
                        N30t = 0
                        Exit Select
                    Case 31
                        N31t = "0"
                        Exit Select
                End Select
            Else
                If Label(i).BackColor.Equals(Color.Red) Then
                    TyLe = ConvertToDblSafe(TxtChunhat.Text)
                Else
                    If Label(i).BackColor.Equals(Color.Gray) Then
                        TyLe = ConvertToDblSafe(TxtNgayle.Text)
                    Else
                        TyLe = ConvertToDblSafe(TxtTrongtuan.Text)
                    End If
                End If
                Select Case i
                    Case 29
                        N29t = TyLe * N29
                        Exit Select
                    Case 30
                        N30t = TyLe * N30
                        Exit Select
                    Case 31
                        N31t = ConvertToStrSafe(TyLe * ConvertToDblSafe(N31))
                        Exit Select
                End Select
            End If
        Next
        Cursor = Cursors.Default
        Return True
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="uid"></param>
    ''' <remarks></remarks>
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(0).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        Command(2).Enabled = (User_Right <> 2 Or (UserID = uid))
        If User_Right <> 0 Then
            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT Lock{0} % 10 AS F1 FROM License", CboThang.SelectedValue))) > 0 Then
                Command(0).Enabled = False
                Command(2).Enabled = False
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmChamconggio_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case KeyCode
                Case Keys.G
                    Command(0).Focus()
                    Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.V
                    Command(1).Focus()
                    Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.X
                    Command(2).Focus()
                    Command_ClickEvent(Command(2), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Ngay"></param>
    ''' <param name="co"></param>
    ''' <param name="ngayts"></param>
    ''' <param name="thangnghi"></param>
    ''' <remarks></remarks>
    Sub ResetChkNgay(Optional ByRef Ngay As Integer = 0, Optional ByRef co As Integer = 0, Optional ByRef ngayts As Integer = 0, Optional ByRef thangnghi As Integer = 0)
        If Ngay = 0 Then
            If co = 0 Then
                For i As Integer = 1 To DayofMonth(Lich)
                    With GrdNhanvien
                        .Col = ConvertToDblSafe(i + 3)
                        .Items(.Row).SubItems(.Col).Text = "0"
                    End With

                Next
            Else
                If co = 1 Then
                    For i As Integer = 1 To DayofMonth(Lich)
                        With GrdNhanvien
                            .Col = ConvertToDblSafe(i + 3)
                            If i < ngayts Then
                                .Items(.Row).SubItems(.Col).Text = "0"
                            Else
                                .Items(.Row).SubItems(.Col).Text = "S"
                            End If
                        End With

                    Next
                Else
                    If co = 2 Then
                        For i As Integer = 1 To DayofMonth(Lich)
                            With GrdNhanvien
                                .Col = ConvertToDblSafe(i + 3)
                                If i > ngayts Then
                                    .Items(.Row).SubItems(.Col).Text = "0"
                                Else
                                    .Items(.Row).SubItems(.Col).Text = "S"
                                End If
                            End With

                        Next
                    Else
                        For i As Integer = 1 To DayofMonth(Lich)
                            With GrdNhanvien
                                .Col = ConvertToDblSafe(i + 3)
                                .Items(.Row).SubItems(.Col).Text = "S"
                            End With

                        Next
                    End If
                End If
            End If
        Else
            For i As Integer = 1 To DayofMonth(Lich)
                With GrdNhanvien
                    .Col = ConvertToDblSafe(i + 3)
                    If Lich.SelectionStart.Month = thangnghi Then
                        If i < Ngay Then
                            .Items(.Row).SubItems(.Col).Text = "0"
                        Else
                            .Items(.Row).SubItems(.Col).Text = "N"
                        End If
                    Else
                        .Items(.Row).SubItems(.Col).Text = "N"
                    End If
                End With

            Next
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub BoChuNhat()
        Dim thu As Integer
        For i As Integer = 1 To DayofMonth(Lich)
            Try
                thu = DateAndTime.Weekday(DateSerial(Lich.SelectionStart.Year, Lich.SelectionStart.Month, i), FirstDayOfWeek.Sunday)
                If Not Label(i + 40).Visible Then Label(i).BackColor = Color.Gray
                If thu = 1 Then
                    Label(i).BackColor = Color.Red
                End If
            Catch ex As Exception
                Exit For
            End Try
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Hienthiluoi()
        Me.Cursor = Cursors.WaitCursor
        Dim k As Integer

        str = String.Format("SELECT t1.maso,t1.ten as Hoten,t2.ten as Bophan,t3.ten as Chucvu,t1.sohieu,t1.nghiviec,t1.ngaynghi,t1.thaisan,t1.tungay,t1.denngay,t1.tuthang,t1.denthang,t1.tang,t1.thangtang,t1.the,t1.baohiem FROM chucvu t3 inner join (Phanloaiquanlynhanvien t2 inner join quanlynhanvien t1 on t1.maphanloai=t2.maso) on t1.machucvu=t3.maso WHERE 1=1 {0} group by t1.maso,t1.sohieu,t1.ten,t2.ten,t3.ten,t1.sohieu,t1.nghiviec,t1.ngaynghi,t1.thaisan,t1.tungay,t1.denngay,t1.tuthang,t1.denthang,t1.tang,t1.thangtang,t1.the,t1.baohiem ORDER BY t1.sohieu", IIf(ConvertToDblSafe(Me.Tag) = 1, String.Format(" and t1.sohieu=N'{0}'", cuongNhanvien), String.Empty))
        rs = ExecSQLReturnDT(str)
        On Error GoTo XongVT
        Dim tuthangts As Integer
        Dim thangnghi As Integer
        Dim Nghiviec As Integer
        Dim Ngaynghi As Integer
        Dim denthangts As Integer
        Dim ngayts As Integer
        Dim tungay As Integer
        Dim tuthang As Integer
        Dim Thaisan As Integer
        Dim denthang As Integer
        Dim denngay As Integer
        Dim co As Integer
        Dim str1 As String = String.Empty


        Dim rs1 As DataTable
        If rs.Rows.Count > 0 Then
            GrdNhanvien.Rows = rs.Rows.Count
            ClearGrid(GrdNhanvien, GrdNhanvien.Rows)
            If rs.Rows.Count < 18 Then
                GrdNhanvien.Width = 14050
            Else
                GrdNhanvien.Width = 14295
            End If
            With GrdNhanvien
                For i As Double = 0 To rs.Rows.Count - 1
                    Dim rowItem As DataRow = rs.Rows(i)
                    Dim DataRow = rs.Rows(i)
                    .Row = i
                    If rowItem("Nghiviec") IsNot Nothing Then
                        Nghiviec = IIf(Not IsDBNull(rowItem("Nghiviec")), ConvertToDblSafe(rowItem("Nghiviec")), 0)
                    End If
                    If rowItem("Ngaynghi") IsNot Nothing Then
                        thangnghi = IIf(Not IsDBNull(rowItem("Ngaynghi")), ConvertToDateSafe(rowItem("Ngaynghi")).Month, 0)
                        Ngaynghi = IIf(Nghiviec = 1 And thangnghi <= dkn, IIf(Not IsDBNull(rowItem("Ngaynghi")), ConvertToDateSafe(rowItem("Ngaynghi")).Day, 0), 0)
                    End If
                    If rowItem("ThaiSan") IsNot Nothing Then
                        Thaisan = IIf(Not IsDBNull(rowItem("Thaisan")), ConvertToDblSafe(rowItem("Thaisan")), 0)
                    End If
                    If rowItem("tuthang") IsNot Nothing Then
                        tuthang = IIf(Not IsDBNull(rowItem("tuthang")), ConvertToDblSafe(rowItem("tuthang")), 13)
                    End If
                    If rowItem("denthang") IsNot Nothing Then
                        denthang = IIf(Not IsDBNull(rowItem("denthang")), ConvertToDblSafe(rowItem("denthang")), 13)
                    End If
                    If rowItem("tungay") IsNot Nothing Then
                        tungay = IIf(Thaisan = 1, IIf(Not IsDBNull(ConvertToDateSafe(rowItem("tungay"))), ConvertToDateSafe(rowItem("tungay")).Day, 0), 0)
                    End If
                    If rowItem("denngay") IsNot Nothing Then
                        denngay = IIf(Thaisan = 1, (IIf(Not IsDBNull(ConvertToDateSafe(rowItem("denngay"))), ConvertToDateSafe(rowItem("denngay")).Day, 0)), 0)
                    End If
                    If rowItem("tungay") IsNot Nothing Then
                        tuthangts = IIf(Thaisan = 1, IIf(Not IsDBNull(rowItem("tungay")), ConvertToDateSafe(rowItem("tungay")).Month, 0), 0)
                    End If
                    If rowItem("denngay") IsNot Nothing Then
                        denthangts = IIf(Thaisan = 1, IIf(Not IsDBNull(rowItem("denngay")), ConvertToDateSafe(rowItem("denngay")).Month, 0), 0)
                    End If
                    ngayts = 0
                    co = 0
                    If Thaisan = 1 And tuthangts <= dkn And denthangts >= dkn Then
                        If Not (dkn < 7 And ConvertToDblSafe(frmMain.LbCty(7).Text) <= 2009) Then GoTo Boqua
                        If dkn = tuthangts Then
                            ngayts = tungay
                            co = 1
                        Else
                            If dkn = denthangts Then
                                ngayts = denngay
                                co = 2
                            Else
                                co = 3
                            End If
                        End If
                    End If
                    If (Nghiviec = 1 And tuthang <> 0 And tuthang <= dkn And (rowItem("The") <> 1 Or rowItem("Baohiem") = 1 Or (rowItem("The") = 1 And Not (dkn < 7 And ConvertToDblSafe(frmMain.LbCty(7).Text) <= 2009)))) Or (rowItem("Tang") = 1 And rowItem("ThangTang") > dkn) Then
Boqua:
                        str1 = ""
                        rs1 = Nothing
                        GrdNhanvien.Rows = ConvertToDblSafe(GrdNhanvien.Rows - 1)
                        'i -= 1
                    Else
                        If Nghiviec = 1 Then
                            If (((thangnghi < dkn Or (Ngaynghi = 1 And thangnghi = dkn)) And rowItem("Ngaynghi").Year = pNamTC) Or rowItem("Ngaynghi").Year < pNamTC) And rowItem("Baohiem") = 1 Then GoTo Boqua
                        End If
                        str1 = String.Format("SELECT manhanvien,N1, N2, N3, N4, N5, N6, N7, N8, N9, N10, N11, N12, N13, N14, N15, N16, N17, N18, N19, N20, N21, N22, N23, N24, N25, N26, N27, N28, N29, N30, N31,n1t,n2t,n3t,n4t,n5t,n6t,n7t,n8t,n9t,n10t,n11t,n12t,n13t,n14t,n15t,n16t,n17t,n18t,n19t,n20t,n21t,n22t,n23t,n24t,n25t,n26t,n27t,n28t,n29t,n30t,n31t FROM chamconggio WHERE manhanvien=N'{0}' and thang={1}", _
                                   rowItem("SoHieu"), _
                                   Lich.SelectionStart.Month)
                        rs1 = ExecSQLReturnDT(str1)
                        BoChuNhat()
                        Dim str10 As String = String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}", _
                                           i + 1, _
                                           Chr(9), _
                                           DataRow("Hoten"), _
                                           DataRow("Bophan"), _
                                           DataRow("Chucvu"), _
                                           DataRow("sohieu"))
                        .AddItem(str10)
                        If rs1.Rows.Count = 0 Then
                            ResetChkNgay(Ngaynghi, co, ngayts, thangnghi)
                        Else
                            Dim rs1Item As DataRow = rs1.Rows(0)
                            For T As Integer = 1 To DayofMonth(Lich)
                                Dim rs1ItemValue As Integer = ConvertToDblSafe(rs1Item(T))
                                .Col = ConvertToDblSafe(T + 3)
                                .Items(.Row).SubItems(.Col).Text = rs1ItemValue.ToString
                                If rs1ItemValue <> 0 And ((3 * rs1ItemValue) = ConvertToDblSafe(rs1Item(T + 31))) Then
                                    Label(T).BackColor = Color.Gray
                                    Label(T + 40).Visible = True
                                End If
                            Next
                        End If
                        .Col = ConvertToDblSafe(.Cols - 1)
                        .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(rowItem("SoHieu"))
                        rs1 = Nothing
                        .Col = 0
                        .Items(.Row).SubItems(.Col).Text = ConvertToStrSafe(i + 1)
                        For j As Integer = 1 To 3
                            .Col = ConvertToDblSafe(j)
                            If ConvertToStrSafe(rowItem(j)) <> "" Then .Items(.Row).SubItems(.Col).Text = rowItem(j)
                        Next
                    End If
                Next
            End With
        End If
XongVT:
        rs = Nothing
        Me.Cursor = Cursors.Default
        GrdNhanvien.Row = 0
    End Sub

    Private Sub FrmChamconggio_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        rs = Nothing
        cuongNhanvien = ""
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdNhanvien_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdNhanvien.Click
        'Dim i As Integer = GrdNhanvien.Col - 3
        'Dim j As Integer = GrdNhanvien.Col
        'GrdNhanvien.Col = ConvertToDblSafe(GrdNhanvien.Cols - 1)
        'Label(36).Text = Timten("ten", GrdNhanvien.CtlText, "sohieu", "quanlynhanvien")
        'GrdNhanvien.Col = ConvertToDblSafe(j)
        SetGridIndex(GrdNhanvien, GrdNhanvien.Row)
        If GrdNhanvien.Row < GrdNhanvien.Rows Then Label(36).Text = GrdNhanvien.Items(GrdNhanvien.Row).SubItems(1).Text
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdNhanvien_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdNhanvien.DoubleClick
        'Dim rs1 As DataTable
        'Dim dong As Integer = GrdNhanvien.Col
        '' GrdNhanvien.Col = ConvertToDblSafe(GrdNhanvien.Cols - 1)
        'GrdNhanvien.Col = 35
        ''Dim str As String = String.Format("SELECT NV.sohieu as sohieuNV,NV.ten as tenNV,CV.ten as tencv,PL.ten as tenpl FROM (quanlynhanvien NV inner join chucvu CV on NV.machucvu=CV.maso) inner join phanloaiquanlynhanvien PL on NV.maphanloai=PL.maso  WHERE NV.ten=N'{0}'", GrdNhanvien.CtlText)
        'Dim str As String = String.Format("SELECT NV.sohieu as sohieuNV,NV.ten as tenNV,CV.ten as tencv,PL.ten as tenpl FROM (quanlynhanvien NV inner join chucvu CV on NV.machucvu=CV.maso) inner join phanloaiquanlynhanvien PL on NV.maphanloai=PL.maso  WHERE NV.sohieu=N'{0}'", GrdNhanvien.CtlText)
        '' Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT NV.sohieu as sohieuNV,NV.ten as tenNV,CV.ten as tencv,PL.ten as tenpl FROM (quanlynhanvien NV inner join chucvu CV on NV.machucvu=CV.maso) inner join phanloaiquanlynhanvien PL on NV.maphanloai=PL.maso  WHERE NV.sohieu=N'{0}'", GrdNhanvien.CtlText))
        'Dim rs As DataTable = ExecSQLReturnDT(str)
        'If rs.Rows.Count > 0 Then
        '    Dim rsItem As DataRow = rs.Rows(0)
        '    mnv = ConvertToStrSafe(rsItem("sohieunv"))
        '    txtch(0).Text = ConvertToStrSafe(rsItem("TenNV"))
        '    txtch(1).Text = ConvertToStrSafe(rsItem("Tenpl"))
        '    txtch(2).Text = ConvertToStrSafe(rsItem("Tencv"))
        '    rs1 = ExecSQLReturnDT(String.Format("SELECT * FROM chamconggio WHERE manhanvien=N'{0}' and thang={1}", _
        '                              rsItem("sohieunv"), _
        '                              CboThang.SelectedIndex))
        '    If rs1.Rows.Count = 0 Then
        '        For i As Integer = 1 To 31
        '            txtn(i).Text = "0"
        '            txtnd(i).Text = "0"
        '            txtnc(i).Text = "0"
        '        Next
        '    Else
        '        Dim rs1Item As DataRow = rs1.Rows(0)
        '        For i As Integer = 1 To 31
        '            txtn(i).Text = ConvertToStrSafe(rs1Item(String.Format("N{0}", i)))
        '            txtnd(i).Text = ConvertToStrSafe(rs1Item(String.Format("N{0}D", i)))
        '            txtnc(i).Text = ConvertToStrSafe(rs1Item(String.Format("N{0}C", i)))
        '        Next
        '    End If
        'End If
        'GrdNhanvien.Col = dong
        'If clickthang = 0 Then txtnd(1).Focus()
        'clickthang = 0
        Try
            Dim rs1 As DataTable
            Dim dong As Integer = GrdNhanvien.Col
            GrdNhanvien.Col = GrdNhanvien.Cols - 1
            Dim str As String = String.Format("SELECT NV.sohieu as sohieuNV,NV.ten as tenNV,CV.ten as tencv,PL.ten as tenpl FROM (quanlynhanvien NV inner join chucvu CV on NV.machucvu=CV.maso) inner join phanloaiquanlynhanvien PL on NV.maphanloai=PL.maso  WHERE NV.sohieu=N'{0}'", GrdNhanvien.Items(GrdNhanvien.Row).SubItems(GrdNhanvien.Col).Text)
            Dim rs As DataTable = ExecSQLReturnDT(str)
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                mnv = ConvertToStrSafe(rsItem("sohieunv"))
                txtch(0).Text = ConvertToStrSafe(rsItem("TenNV"))
                txtch(1).Text = ConvertToStrSafe(rsItem("Tenpl"))
                txtch(2).Text = ConvertToStrSafe(rsItem("Tencv"))
                rs1 = ExecSQLReturnDT(String.Format("SELECT * FROM chamconggio WHERE manhanvien=N'{0}' and thang={1}", _
                                          rsItem("sohieunv"), _
                                          CboThang.SelectedValue))
                If rs1.Rows.Count = 0 Then
                    For i As Integer = 1 To 31
                        txtn(i).Text = "0"
                        txtnd(i).Text = "0"
                        txtnc(i).Text = "0"
                    Next
                Else
                    Dim rs1Item As DataRow = rs1.Rows(0)
                    For i As Integer = 1 To 31
                        txtn(i).Text = ConvertToStrSafe(rs1Item(String.Format("N{0}", i)))
                        txtnd(i).Text = ConvertToStrSafe(rs1Item(String.Format("N{0}D", i)))
                        txtnc(i).Text = ConvertToStrSafe(rs1Item(String.Format("N{0}C", i)))
                    Next
                End If
            End If
            GrdNhanvien.Col = dong
            If clickthang = 0 Then txtnd(1).Focus()
            clickthang = 0
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="dong"></param>
    ''' <param name="cot"></param>
    ''' <remarks></remarks>
    Sub SetLe(ByVal dong As Integer, ByRef cot As Integer)
        Dim j As Integer = GrdNhanvien.Row
        Dim k As Integer = GrdNhanvien.Col
        For i As Integer = 0 To GrdNhanvien.Rows - 1
            GrdNhanvien.Row = i
            GrdNhanvien.Col = cot
            If GrdNhanvien.CtlText = "C" Then GrdNhanvien.CtlText = ""
        Next
        GrdNhanvien.Row = ConvertToDblSafe(j)
        GrdNhanvien.Col = ConvertToDblSafe(k)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Label_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Label_82.Click, _Label_81.Click, _Label_37.Click, _Label_36.Click, _Label_41.Click, _Label_42.Click, _Label_43.Click, _Label_44.Click, _Label_45.Click, _Label_46.Click, _Label_47.Click, _Label_48.Click, _Label_49.Click, _Label_50.Click, _Label_51.Click, _Label_52.Click, _Label_53.Click, _Label_54.Click, _Label_55.Click, _Label_56.Click, _Label_57.Click, _Label_58.Click, _Label_59.Click, _Label_60.Click, _Label_61.Click, _Label_62.Click, _Label_63.Click, _Label_64.Click, _Label_65.Click, _Label_66.Click, _Label_67.Click, _Label_68.Click, _Label_69.Click, _Label_70.Click, _Label_71.Click, _Label_35.Click, _Label_31.Click, _Label_30.Click, _Label_29.Click, _Label_28.Click, _Label_27.Click, _Label_26.Click, _Label_25.Click, _Label_24.Click, _Label_23.Click, _Label_22.Click, _Label_21.Click, _Label_20.Click, _Label_19.Click, _Label_18.Click, _Label_17.Click, _Label_16.Click, _Label_15.Click, _Label_14.Click, _Label_13.Click, _Label_12.Click, _Label_11.Click, _Label_10.Click, _Label_9.Click, _Label_8.Click, _Label_7.Click, _Label_6.Click, _Label_5.Click, _Label_4.Click, _Label_3.Click, _Label_2.Click, _Label_1.Click, _Label_34.Click, _Label_32.Click, _Label_33.Click, _Label_0.Click
        Dim Index As Integer = Array.IndexOf(Label, eventSender)
        Dim co, i As Integer
        If Not (Index = 0 Or Index = 32 Or Index = 33 Or Index = 35) Then
            On Error GoTo Loi
            If ColorTranslator.ToOle(Label(Index).BackColor) = mau Then
                Label(Index + 40).Visible = True
                Label(Index).BackColor = Color.Gray
                co = 1
            Else
                If Label(Index).BackColor.Equals(Color.Gray) Then
                    Label(Index).BackColor = ColorTranslator.FromOle(mau)
                    Label(Index + 40).Visible = False
                    co = 2
                End If
            End If
        End If
Loi:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtch_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtch_2.Enter, _txtch_1.Enter, _txtch_0.Enter
        Dim Index As Integer = Array.IndexOf(txtch, eventSender)
        txtch(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private isInitializingComponent As Boolean
    Private Sub txtn_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtn_31.TextChanged, _txtn_30.TextChanged, _txtn_29.TextChanged, _txtn_28.TextChanged, _txtn_27.TextChanged, _txtn_26.TextChanged, _txtn_25.TextChanged, _txtn_24.TextChanged, _txtn_23.TextChanged, _txtn_22.TextChanged, _txtn_21.TextChanged, _txtn_20.TextChanged, _txtn_19.TextChanged, _txtn_18.TextChanged, _txtn_17.TextChanged, _txtn_16.TextChanged, _txtn_15.TextChanged, _txtn_14.TextChanged, _txtn_13.TextChanged, _txtn_12.TextChanged, _txtn_11.TextChanged, _txtn_10.TextChanged, _txtn_9.TextChanged, _txtn_8.TextChanged, _txtn_7.TextChanged, _txtn_6.TextChanged, _txtn_5.TextChanged, _txtn_4.TextChanged, _txtn_3.TextChanged, _txtn_2.TextChanged, _txtn_1.TextChanged
        If isInitializingComponent Then
            Exit Sub
        End If
        Dim Index As Integer = Array.IndexOf(txtn, eventSender)
        If ConvertToDblSafe(txtn(Index).Text) <= 0 Then txtn(Index).Text = ""
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtn_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtn_31.Enter, _txtn_30.Enter, _txtn_29.Enter, _txtn_28.Enter, _txtn_27.Enter, _txtn_26.Enter, _txtn_25.Enter, _txtn_24.Enter, _txtn_23.Enter, _txtn_22.Enter, _txtn_21.Enter, _txtn_20.Enter, _txtn_19.Enter, _txtn_18.Enter, _txtn_17.Enter, _txtn_16.Enter, _txtn_15.Enter, _txtn_14.Enter, _txtn_13.Enter, _txtn_12.Enter, _txtn_11.Enter, _txtn_10.Enter, _txtn_9.Enter, _txtn_8.Enter, _txtn_7.Enter, _txtn_6.Enter, _txtn_5.Enter, _txtn_4.Enter, _txtn_3.Enter, _txtn_2.Enter, _txtn_1.Enter
        Dim Index As Integer = Array.IndexOf(txtn, eventSender)
        txtn(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtnc_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtnc_31.Enter, _txtnc_30.Enter, _txtnc_29.Enter, _txtnc_28.Enter, _txtnc_27.Enter, _txtnc_26.Enter, _txtnc_25.Enter, _txtnc_24.Enter, _txtnc_23.Enter, _txtnc_22.Enter, _txtnc_21.Enter, _txtnc_20.Enter, _txtnc_19.Enter, _txtnc_18.Enter, _txtnc_17.Enter, _txtnc_16.Enter, _txtnc_15.Enter, _txtnc_14.Enter, _txtnc_13.Enter, _txtnc_12.Enter, _txtnc_11.Enter, _txtnc_10.Enter, _txtnc_9.Enter, _txtnc_8.Enter, _txtnc_7.Enter, _txtnc_6.Enter, _txtnc_5.Enter, _txtnc_4.Enter, _txtnc_3.Enter, _txtnc_2.Enter, _txtnc_1.Enter, _txtnc_0.Enter, _txtnc_32.Enter
        Dim Index As Integer = Array.IndexOf(txtnc, eventSender)
        txtnc(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtnc_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtnc_31.Leave, _txtnc_30.Leave, _txtnc_29.Leave, _txtnc_28.Leave, _txtnc_27.Leave, _txtnc_26.Leave, _txtnc_25.Leave, _txtnc_24.Leave, _txtnc_23.Leave, _txtnc_22.Leave, _txtnc_21.Leave, _txtnc_20.Leave, _txtnc_19.Leave, _txtnc_18.Leave, _txtnc_17.Leave, _txtnc_16.Leave, _txtnc_15.Leave, _txtnc_14.Leave, _txtnc_13.Leave, _txtnc_12.Leave, _txtnc_11.Leave, _txtnc_10.Leave, _txtnc_9.Leave, _txtnc_8.Leave, _txtnc_7.Leave, _txtnc_6.Leave, _txtnc_5.Leave, _txtnc_4.Leave, _txtnc_3.Leave, _txtnc_2.Leave, _txtnc_1.Leave, _txtnc_0.Leave, _txtnc_32.Leave
        Dim Index As Integer = Array.IndexOf(txtnc, eventSender)
        If mnv.Length <> 0 And (ConvertToDblSafe(txtnc(Index).Text) < 0 Or ConvertToDblSafe(txtnc(Index).Text) > 24) Then
            MessageBox.Show(Ngonngu("Chỉ được nhập giá trị từ 0 đến 24 !", "enter only value from 0 to 24"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : txtnc(Index).Text = "0"
        End If
        txtn(Index).Text = ConvertToStrSafe(ConvertToDblSafe(txtnc(Index).Text) - ConvertToDblSafe(txtnd(Index).Text))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtnd_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtnd_31.Enter, _txtnd_30.Enter, _txtnd_29.Enter, _txtnd_28.Enter, _txtnd_27.Enter, _txtnd_26.Enter, _txtnd_25.Enter, _txtnd_24.Enter, _txtnd_23.Enter, _txtnd_22.Enter, _txtnd_21.Enter, _txtnd_20.Enter, _txtnd_19.Enter, _txtnd_18.Enter, _txtnd_17.Enter, _txtnd_16.Enter, _txtnd_15.Enter, _txtnd_14.Enter, _txtnd_13.Enter, _txtnd_12.Enter, _txtnd_11.Enter, _txtnd_10.Enter, _txtnd_9.Enter, _txtnd_8.Enter, _txtnd_7.Enter, _txtnd_6.Enter, _txtnd_5.Enter, _txtnd_4.Enter, _txtnd_3.Enter, _txtnd_2.Enter, _txtnd_1.Enter, _txtnd_0.Enter, _txtnd_32.Enter
        Dim Index As Integer = Array.IndexOf(txtnd, eventSender)
        txtnd(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtnd_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtnd_31.Leave, _txtnd_30.Leave, _txtnd_29.Leave, _txtnd_28.Leave, _txtnd_27.Leave, _txtnd_26.Leave, _txtnd_25.Leave, _txtnd_24.Leave, _txtnd_23.Leave, _txtnd_22.Leave, _txtnd_21.Leave, _txtnd_20.Leave, _txtnd_19.Leave, _txtnd_18.Leave, _txtnd_17.Leave, _txtnd_16.Leave, _txtnd_15.Leave, _txtnd_14.Leave, _txtnd_13.Leave, _txtnd_12.Leave, _txtnd_11.Leave, _txtnd_10.Leave, _txtnd_9.Leave, _txtnd_8.Leave, _txtnd_7.Leave, _txtnd_6.Leave, _txtnd_5.Leave, _txtnd_4.Leave, _txtnd_3.Leave, _txtnd_2.Leave, _txtnd_1.Leave, _txtnd_0.Leave, _txtnd_32.Leave
        Dim Index As Integer = Array.IndexOf(txtnd, eventSender)
        If mnv.Length <> 0 And (ConvertToDblSafe(txtnd(Index).Text) < 0 Or ConvertToDblSafe(txtnd(Index).Text) > 24) Then
            MessageBox.Show(Ngonngu("Chỉ được nhập giá trị từ 0 đến 24 !", "enter only value from 0 to 24 !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : txtnd(Index).Text = "0"
        End If
        txtn(Index).Text = ConvertToStrSafe(ConvertToDblSafe(txtnc(Index).Text) - ConvertToDblSafe(txtnd(Index).Text))
    End Sub
End Class
