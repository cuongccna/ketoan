Imports System
Imports System.Data
Imports System.Drawing
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmChamcong
    Dim str As String = String.Empty
    Dim rs As DataTable
    Const mau As Integer = &H808000
    Dim mnv As String = String.Empty
    Dim Loitrichluong As Integer
    Dim Cong As Double
    Dim Nghi As Double
    Dim Phep As Double
    Dim Tangca As Double
    Dim Le As Double
    Dim dkn As Integer
    Dim str10 As String = String.Empty
    Dim MaDaTim As Integer
    Dim macongtrinh, Taikhoanthay As String
    Dim congtrinh As Integer
    Dim n1 As String = String.Empty
    Dim N10 As String = String.Empty
    Dim N11 As String = String.Empty
    Dim N12 As String = String.Empty
    Dim N13 As String = String.Empty
    Dim N14 As String = String.Empty
    Dim N15 As String = String.Empty
    Dim N16 As String = String.Empty
    Dim N17 As String = String.Empty
    Dim N18 As String = String.Empty
    Dim N19 As String = String.Empty
    Dim n2 As String = String.Empty
    Dim N20 As String = String.Empty
    Dim N21 As String = String.Empty
    Dim N22 As String = String.Empty
    Dim N23 As String = String.Empty
    Dim N24 As String = String.Empty
    Dim N25 As String = String.Empty
    Dim N26 As String = String.Empty
    Dim N27 As String = String.Empty
    Dim N28 As String = String.Empty
    Dim N29 As String = String.Empty
    Dim N3 As String = String.Empty
    Dim N30 As String = String.Empty
    Dim N4 As String = String.Empty
    Dim N5 As String = String.Empty
    Dim N6 As String = String.Empty
    Dim N7 As String = String.Empty
    Dim N8 As String = String.Empty
    Dim N9 As String = String.Empty
    Dim N31 As String = String.Empty
    Private Const GRID_ROWS As Integer = 100
    Private Const GRID_COLS As Integer = 36
    Dim currentSelectIdex As Integer = -2
    Dim formInitComplete As Boolean = False
    Dim tncn As Double
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboThang_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboThang.SelectedIndexChanged
        If CboThang.Items.Count > 0 Then currentSelectIdex = CboThang.SelectedIndex
        ResetLe()
        Lich.SelectionStart = Lich.SelectionStart.AddMonths(CboThang.SelectedValue - Lich.SelectionStart.Month)
        Lich.SelectionStart = Lich.SelectionStart.AddYears(frmMain._LbCty_7.Text - Lich.SelectionStart.Year)
        For i As Integer = 28 To 31
            Label(i).Visible = True
            GrdNhanvien.Cols = ConvertToDblSafe(i + 5)
            ColumnSetUp(GrdNhanvien, i + 3, 250, 0)
        Next
        For i As Integer = DayofMonth(Lich) + 1 To 31
            Label(i).Visible = False
            GrdNhanvien.Cols = ConvertToDblSafe(GrdNhanvien.Cols - 1)
        Next
        dkn = Lich.SelectionStart.Month
        Hienthiluoi()
        Chk.CheckState = CheckState.Unchecked
        'End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Chk_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Chk.CheckStateChanged
        FLuong13.Visible = Chk.CheckState = CheckState.Checked
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub ChkBaohiem_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles ChkBaohiem.CheckStateChanged
        FrameBaohiem.Visible = ChkBaohiem.CheckState
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Nhapluong()
        Dim str As String = String.Empty
        Dim dem As Integer
        'Đếm số ngày phải làm trong tháng
        Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT MaNhanVien,N1, N2, N3, N4, N5, N6, N7, N8, N9, N10, N11, N12, N13, N14, N15, N16, N17, N18, N19, N20, N21, N22, N23, N24, N25, N26, N27, N28, N29, N30, N31 FROM chamcong WHERE thang={0} order by manhanvien", Lich.SelectionStart.Month))
        Try
            For Each rsItem As DataRow In rs.Rows
                For i As Integer = 1 To DayofMonth(Lich)
                    Dim NiValue As String = LCase(ConvertToStrSafe(rsItem(i)).Trim.ToUpper)
                    If NiValue = "p" Or NiValue = "c" Or NiValue = "l" Or NiValue = "r" Or NiValue = "v" Then
                        dem += 1
                    End If
                    If NiValue = "s" Or NiValue = "n" Then
                        dem = 0
                        Exit For
                    End If
                Next
                If dem > 0 Then Exit For
            Next
        Catch
        End Try
        str = String.Format("SELECT t2.maso as manv,t4.maso as loainv,t1.ngaycong,CASE WHEN t1.luongcb<>0 THEN t1.luongcb ELSE 1 END *t1.heso as luongcb,t1.pccv,t1.pctn,t1.pcld,(t1.com+t1.pck) as pck,t1.thuong,t1.congkhac,t1.bhxh,t1.bhtn,t1.bhyt,t1.tamung,t1.trukhac as khac,t1.nghi,t1.phep,t1.tangca,t2.maphanloai,t4.ten,CASE WHEN t1.luongcb<>0 THEN t1.luongcb ELSE 1 END *t1.heso1 as luongcb1,t1.bhxh1,t1.bhtn1,t1.bhyt1,t1.pccv1,t1.pctn1,t1.pcld1,(t1.com1+t1.pck1) as pck1,t1.demcu,t1.demmoi,t1.tangcagio,t1.luong13 FROM thongsoluong t1 inner join((quanlynhanvien t2 inner join phanloaiquanlynhanvien t4 on t2.maphanloai=t4.maso) inner join chucvu t3 on t2.machucvu=t3.maso) on t1.sohieunhanvien=t2.sohieu WHERE t1.thang={0} order by t4.maso,t2.sohieu", Lich.SelectionStart.Month)
        rs = ExecSQLReturnDT(str)
        Dim luongchinh, luongcoban, thunhapkhac, BHYT, tongthunhap, BHXH, BHTN, Trukhac, Tamung, thuclanh, luongngay, luongcoban13 As Double
        Dim MaNV As Integer
        Dim loainv, thang As Integer
        Dim Ngaycong As Double
        If rs.Rows.Count > 0 Then
            thang = Lich.SelectionStart.Month
            ExecSQLNonQuery(String.Format("DELETE FROM BangLuong WHERE thang={0}", thang))
            For Each rsItem As DataRow In rs.Rows
                If rsItem("MaNV") IsNot Nothing Then
                    MaNV = ConvertToDblSafe(rsItem("MaNV"))
                End If
                If rsItem("loainv") IsNot Nothing Then
                    loainv = ConvertToDblSafe(rsItem("loainv"))
                End If
                If rsItem("Ngaycong") IsNot Nothing Then
                    Ngaycong = ConvertToDblSafe(rsItem("Ngaycong"))
                End If

                If ConvertToDblSafe(rsItem("luongcb")) <> 0 Then
                    If ConvertToDblSafe(rsItem("Demmoi")) <> 0 Then
                        luongcoban = (ConvertToDblSafe(rsItem("luongcb")) _
                                      * ConvertToDblSafe(rsItem("Demcu")) _
                                      + ConvertToDblSafe(rsItem("luongcb1")) _
                                      * ConvertToDblSafe(rsItem("Demmoi"))) / dem
                    Else
                        luongcoban = ConvertToDblSafe(rsItem("luongcb"))
                    End If
                End If
                luongngay = luongcoban / (IIf(dem <> 0, dem, 1))
                luongcoban13 = luongcoban * ConvertToDblSafe(rsItem("Luong13")) / 100
                If ConvertToDblSafe(rsItem("Demmoi")) = 0 Then
                    luongchinh = luongngay * (ConvertToDblSafe(rsItem("Ngaycong")) _
                                              + ConvertToDblSafe(rsItem("Tangca")) _
                                              + ConvertToDblSafe(rsItem("Phep"))) _
                                              + luongcoban13
                Else
                    luongchinh = luongcoban / dem * (ConvertToDblSafe(rsItem("Ngaycong")) _
                    + ConvertToStrSafe(rsItem("Tangca")) _
                    + ConvertToDblSafe(rsItem("Phep"))) + luongcoban13
                End If
                If ConvertToDblSafe(rsItem("Demmoi")) <> 0 Then
                    thunhapkhac = (ConvertToDblSafe(rsItem("PCCV")) _
                                   * ConvertToDblSafe(rsItem("Demcu")) _
                                   + ConvertToDblSafe(rsItem("PCCV1")) _
                                   * ConvertToDblSafe(rsItem("Demmoi"))) / dem _
                                   + (ConvertToDblSafe(rsItem("PCTN")) _
                                      * ConvertToDblSafe(rsItem("Demcu")) _
                                      + ConvertToDblSafe(rsItem("PCTN1")) _
                                      * ConvertToDblSafe(rsItem("Demmoi"))) / dem _
                                      + (ConvertToDblSafe(rsItem("PCLD")) _
                                         * ConvertToDblSafe(rsItem("Demcu")) _
                                         + ConvertToDblSafe(rsItem("PCLD1")) _
                                         * ConvertToDblSafe(rsItem("Demmoi"))) / dem _
                                         + (ConvertToDblSafe(rsItem("PCK")) _
                                            * ConvertToDblSafe(rsItem("Demcu")) _
                                            + ConvertToDblSafe(rsItem("PCK1")) _
                                            * ConvertToDblSafe(rsItem("Demmoi"))) / dem _
                                            + ConvertToDblSafe(rsItem("thuong")) _
                                            + ConvertToDblSafe(rsItem("congkhac")) _
                                            + ConvertToDblSafe(rsItem("tangcagio"))
                Else
                    thunhapkhac = ConvertToDblSafe(rsItem("PCCV")) _
                                + ConvertToDblSafe(rsItem("PCTN")) _
                                + ConvertToDblSafe(rsItem("PCLD")) _
                                + ConvertToDblSafe(rsItem("PCK")) _
                                + ConvertToDblSafe(rsItem("thuong")) _
                                + ConvertToDblSafe(rsItem("congkhac")) _
                                + ConvertToDblSafe(rsItem("tangcagio"))
                End If
                tongthunhap = luongchinh + thunhapkhac
                BHXH = Math.Round(ConvertToDblSafe(luongcoban * ConvertToDblSafe(rsItem("BHXH")) / 100))
                BHYT = Math.Round(ConvertToDblSafe(luongcoban * ConvertToDblSafe(rsItem("BHYT")) / 100))
                BHTN = Math.Round(ConvertToDblSafe(luongcoban * ConvertToDblSafe(rsItem("BHTN")) / 100))
                If rsItem("Tamung") IsNot Nothing Then
                    Tamung = ConvertToDblSafe(rsItem("Tamung"))
                End If
                If rsItem("khac") IsNot Nothing Then
                    Trukhac = ConvertToDblSafe(rsItem("khac"))
                End If

                thuclanh = tongthunhap - (BHXH + BHYT + Tamung + Trukhac + BHTN)
                str = String.Format("INSERT into BangLuong(MaSo, manv, loainv, thang, ngaycong, luongcoban, luongchinh, thunhapkhac, tongthunhap, BHXH, BHYT, BHTN, tamung, trukhac, thuclanh,tncn,giacanh) values({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})", _
                                    Lng_MaxValue("maso", "Bangluong") + 1, _
                                    ConvertToStrSafe(MaNV), _
                                    ConvertToStrSafe(loainv), _
                                    ConvertToStrSafe(thang), _
                                    ConvertToStrSafe(Ngaycong), _
                                    ConvertToStrSafe(luongcoban), _
                                    ConvertToStrSafe(luongchinh), _
                                    ConvertToStrSafe(thunhapkhac), _
                                    ConvertToStrSafe(tongthunhap), _
                                    ConvertToStrSafe(BHXH), _
                                    ConvertToStrSafe(BHYT), _
                                    ConvertToStrSafe(BHTN), _
                                    ConvertToStrSafe(Tamung), _
                                    ConvertToStrSafe(Trukhac), _
                                    ConvertToStrSafe(thuclanh), _
                                    ConvertToStrSafe(GetSelectValue("select t1.tncn as f1 from chamcong t1 inner join quanlynhanvien t2 on t1.manhanvien = t2.sohieu where t2.maso=" & CStr(MaNV) & " and t1.thang=" & CStr(thang))), _
                                    ConvertToStrSafe(GetSelectValue("select t1.giacanh as f1 from chamcong t1 inner join quanlynhanvien t2 on t1.manhanvien = t2.sohieu where t2.maso=" & CStr(MaNV) & " and t1.thang=" & CStr(thang))))
                ExecSQLNonQuery(str)
            Next
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_8.Click, _Command_9.Click, _Command_6.Click, _Command_5.Click, _Command_7.Click, _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim str1 As String = String.Empty
        If User_Right = 2 Then
            HienThongBao("Không có quyền truy cập!", 1)
            GoTo XongVT
        End If

        Me.Cursor = Cursors.WaitCursor
        If Index = 0 Or Index = 2 Or Index = 9 Then
            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT lock{0} as f1 FROM license", CboThang.SelectedValue))) = 1 Then
                If FrmPassword.GetPswX(String.Format("Dữ liệu tháng {0} đã bị khoá. Nhập mật khẩu ...", CboThang.SelectedValue)) <> "MS" Then GoTo XongVT
            End If
        End If
        Dim GiaTri As String = String.Empty
        Dim bp3, bp1, thang, bp2, bp4 As Integer
        Dim dkc, dkn, dkcp As String
        Select Case Index
            Case 0
                Ghi()
                Tinhluong()
                Nhapluong()
                FrmTNCN.Tinhthue(ConvertToDblSafe((Lich.SelectionStart.Month)))
            Case 1
                Me.Close()
            Case 2
                Xoa()
                Hienthiluoi()
            Case 3
                InBangluong(Lich, True)
            Case 5
                Hienthiluoi()
            Case 6
                InChamcong()
            Case 7
                InBangluong(Lich)
            Case 8
                GiaTri = ConvertToStrSafe(ConvertToDblSafe(FrmGetStr.GetString(Ngonngu("Lương tối thiểu:", "Minimum salary"), My.Application.Info.ProductName, "0")))
                If GiaTri <> "" Then ExecSQLNonQuery(String.Format("UPDATE license set lcb={0}", GiaTri))
                Dim LCB1, LCB2 As Double
                Dim KqLuong As String = String.Empty
                LCB1 = ConvertToDblSafe(GetSelectValue(String.Format("SELECT luongcb as f1 FROM thongsoluong WHERE luongcb<>0 and thang={0}", Lich.SelectionStart.Month)))
                LCB2 = ConvertToDblSafe(GetSelectValue("SELECT lcb as f1 FROM license"))
                KqLuong = Format(IIf(LCB1 <> 0, LCB1, LCB2), Mask_0)
                Label(37).Text = String.Format(Ngonngu("Lương tối thiểu : {0} đ", "Basic salary : {0} vnd"), (IIf(KqLuong <> "", KqLuong, 0)))
            Case 9
                thang = Lich.SelectionStart.Month
                If FrmOptTrichluong.Trichluong(bp1, bp2, bp3, bp4) Then
                    dkn = "" : dkc = "" : dkcp = ""
                    Dim rs As DataTable = ExecSQLReturnDT("SELECT t1.maso, t1.ten FROM phanloaiquanlynhanvien t1 inner join quanlynhanvien t2 on t1.maso=t2.maphanloai WHERE cap=2 group by t1.maso,t1.ten")
                    Dim demphanloai As Integer = rs.Rows.Count
                    If bp1 <> 0 Then
                        dkn = String.Format(" and (matkno= {0}", SoHieu2MaSo(MaSo2SoHieu(ConvertToDblSafe((bp1)), "Phanloaiquanlynhanvien"), "hethongtk"))
                        dkc = String.Format(" and (matkco= {0}", SoHieu2MaSo(MaSo2SoHieu(ConvertToDblSafe((bp1)), "Phanloaiquanlynhanvien"), "hethongtk"))
                        dkcp = String.Format(" and (matkno= {0}", TKChiPhi(ConvertToDblSafe((bp1))))
                        demphanloai -= 1
                    End If
                    If bp2 <> 0 Then
                        If dkn = "" Then
                            dkn = String.Format(" and (matkno= {0}", SoHieu2MaSo(MaSo2SoHieu(ConvertToDblSafe((bp2)), "Phanloaiquanlynhanvien"), "hethongtk"))
                        Else
                            dkn = String.Format("{0} or matkno= {1}", dkn, ConvertToStrSafe(SoHieu2MaSo(MaSo2SoHieu(ConvertToDblSafe((bp2)), "Phanloaiquanlynhanvien"), "hethongtk")))
                        End If
                        If dkc = "" Then
                            dkc = String.Format(" and (matkco= {0}", SoHieu2MaSo(MaSo2SoHieu(ConvertToDblSafe((bp2)), "Phanloaiquanlynhanvien"), "hethongtk"))
                        Else
                            dkc = String.Format("{0} or matkco= {1}", dkc, ConvertToStrSafe(SoHieu2MaSo(MaSo2SoHieu(ConvertToDblSafe((bp2)), "Phanloaiquanlynhanvien"), "hethongtk")))
                        End If
                        If dkcp = "" Then
                            dkcp = String.Format(" and (matkno= {0}", TKChiPhi(ConvertToDblSafe((bp2))))
                        Else
                            dkcp = String.Format("{0} or matkno= {1}", dkcp, ConvertToStrSafe(TKChiPhi(ConvertToDblSafe((bp2)))))
                        End If
                        demphanloai -= 1
                    End If
                    If bp3 <> 0 Then
                        If dkn = "" Then
                            dkn = String.Format(" and (matkno= {0}", SoHieu2MaSo(MaSo2SoHieu(ConvertToDblSafe((bp3)), "Phanloaiquanlynhanvien"), "hethongtk"))
                        Else
                            dkn = String.Format("{0} or matkno= {1}", dkn, ConvertToStrSafe(SoHieu2MaSo(MaSo2SoHieu(ConvertToDblSafe((bp3)), "Phanloaiquanlynhanvien"), "hethongtk")))
                        End If
                        If dkc = "" Then
                            dkc = String.Format(" and (matkco= {0}", SoHieu2MaSo(MaSo2SoHieu(ConvertToDblSafe((bp3)), "Phanloaiquanlynhanvien"), "hethongtk"))
                        Else
                            dkc = String.Format("{0} or matkco= {1}", dkc, ConvertToStrSafe(SoHieu2MaSo(MaSo2SoHieu(ConvertToDblSafe((bp3)), "Phanloaiquanlynhanvien"), "hethongtk")))
                        End If
                        If dkcp = "" Then
                            dkcp = String.Format(" and (matkno= {0}", TKChiPhi(ConvertToDblSafe((bp3))))
                        Else
                            dkcp = String.Format("{0} or matkno= {1}", dkcp, ConvertToStrSafe(TKChiPhi(ConvertToDblSafe((bp3)))))
                        End If
                        demphanloai -= 1
                    End If
                    If bp4 <> 0 Then
                        If dkn = "" Then
                            dkn = String.Format(" and (matkno= {0}", SoHieu2MaSo(MaSo2SoHieu(ConvertToDblSafe((bp4)), "Phanloaiquanlynhanvien"), "hethongtk"))
                        Else
                            dkn = String.Format("{0} or matkno= {1}", dkn, ConvertToStrSafe(SoHieu2MaSo(MaSo2SoHieu(ConvertToDblSafe((bp4)), "Phanloaiquanlynhanvien"), "hethongtk")))
                        End If
                        If dkc = "" Then
                            dkc = String.Format(" and (matkco= {0}", SoHieu2MaSo(MaSo2SoHieu(ConvertToDblSafe((bp4)), "Phanloaiquanlynhanvien"), "hethongtk"))
                        Else
                            dkc = String.Format("{0} or matkco= {1}", dkc, ConvertToStrSafe(SoHieu2MaSo(MaSo2SoHieu(ConvertToDblSafe((bp4)), "Phanloaiquanlynhanvien"), "hethongtk")))
                        End If
                        If dkcp = "" Then
                            dkcp = String.Format(" and (matkno= {0}", TKChiPhi(ConvertToDblSafe((bp4))))
                        Else
                            dkcp = String.Format("{0} or matkno= {1}", dkcp, ConvertToStrSafe(TKChiPhi(ConvertToDblSafe((bp4)))))
                        End If
                        demphanloai -= 1
                    End If
                    If dkn.Length > 0 Then dkn = String.Format("{0})", dkn)
                    If dkc.Length > 0 Then dkc = String.Format("{0})", dkc)
                    If dkcp.Length > 0 Then dkcp = String.Format("{0})", dkcp)

                    If demphanloai = 0 Then
                        ExecSQLNonQuery(String.Format("DELETE FROM chungtu WHERE sohieu = 'BHDN{0}'", (IIf(thang < 10, String.Format("0{0}", thang), ConvertToStrSafe(thang)))))
                        ExecSQLNonQuery(String.Format("DELETE FROM chungtu WHERE sohieu = 'BHNV{0}'", (IIf(thang < 10, String.Format("0{0}", thang), ConvertToStrSafe(thang)))))
                        ExecSQLNonQuery(String.Format("DELETE FROM chungtu WHERE sohieu = 'CLNV{0}'", (IIf(thang < 10, String.Format("0{0}", thang), ConvertToStrSafe(thang)))))
                        ExecSQLNonQuery(String.Format("DELETE FROM chungtu WHERE sohieu = 'CPNV{0}'", (IIf(thang < 10, String.Format("0{0}", thang), ConvertToStrSafe(thang)))))
                    Else
                        ExecSQLNonQuery(String.Format("DELETE FROM chungtu WHERE sohieu = 'BHDN{0}'{1}", (IIf(thang < 10, String.Format("0{0}", thang), ConvertToStrSafe(thang))), dkcp))
                        ExecSQLNonQuery(String.Format("DELETE FROM chungtu WHERE sohieu = 'BHNV{0}'{1}", (IIf(thang < 10, String.Format("0{0}", thang), ConvertToStrSafe(thang))), dkn))
                        ExecSQLNonQuery(String.Format("DELETE FROM chungtu WHERE sohieu = 'CLNV{0}'{1}", (IIf(thang < 10, String.Format("0{0}", thang), ConvertToStrSafe(thang))), dkn))
                        ExecSQLNonQuery(String.Format("DELETE FROM chungtu WHERE sohieu = 'CPNV{0}'{1}", (IIf(thang < 10, String.Format("0{0}", thang), ConvertToStrSafe(thang))), dkc))
                    End If

                    Loitrichluong = 0
                    If ChkBaohiem.CheckState Then
                        TrichBaohiemDN(bp1, bp2, bp3, bp4)
                        TrichBaohiemNV(bp1, bp2, bp3, bp4)
                    End If
                    Chiluongnhanvien(bp1, bp2, bp3, bp4)
                    Chiphinhanvien(bp1, bp2, bp3, bp4)
                    macongtrinh = ""
                    congtrinh = 0
                    Taikhoanthay = ""
                    If Loitrichluong = 0 Then MessageBox.Show(Ngonngu("Quá trình trích lương thành công !", "Complete salary deduction !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select
XongVT:
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="MaSo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function TKChiPhi(ByRef MaSo As Integer) As Integer
        Return ConvertToIntSafe(Timten("matk", CStr(MaSo), "maso", "phanloaiquanlynhanvien"))
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub InChamcong()
        Dim str As String = String.Format("SELECT t1.maso FROM chamcong t1 inner join quanlynhanvien t2 on t1.manhanvien=t2.sohieu WHERE t1.thang={0}", Lich.SelectionStart.Month)
        Dim rs As DataTable = ExecSQLReturnDT(str)

        Dim ReportFilename As String
        If rs.Rows.Count > 0 Then
            str = String.Format("SELECT t1.maso,t1.ten as Hoten,t2.ten as Bophan,t3.ten as Chucvu,t1.sohieu,N1, N2, N3, N4, N5, N6, N7, N8, N9, N10, N11, N12, N13, N14, N15, N16, N17, N18, N19, N20, N21, N22, N23, N24, N25, N26, N27, N28, N29, N30, N31 FROM chucvu t3 inner join (Phanloaiquanlynhanvien t2 inner join (quanlynhanvien t1 inner join chamcong t4 on t1.sohieu=t4.manhanvien) on t1.maphanloai=t2.maso) on t1.machucvu=t3.maso  group by t4.thang,t1.maso,t1.sohieu,t1.ten,t2.ten,t3.ten,t1.sohieu,N1, N2, N3, N4, N5, N6, N7, N8, N9, N10, N11, N12, N13, N14, N15, N16, N17, N18, N19, N20, N21, N22, N23, N24, N25, N26, N27, N28, N29, N30, N31 having  t4.thang={0} ORDER BY t1.sohieu", ConvertToStrSafe(Lich.SelectionStart.Month))
            ReportFilename = "Chamcong.RPT"
        Else
            str = "SELECT t1.maso,t1.ten as Hoten,t2.ten as Bophan,t3.ten as Chucvu,t1.sohieu FROM chucvu t3 inner join (Phanloaiquanlynhanvien t2 inner join quanlynhanvien t1 on t1.maphanloai=t2.maso) on t1.machucvu=t3.maso group by t1.maso,t1.sohieu,t1.ten,t2.ten,t3.ten,t1.sohieu  ORDER BY t1.sohieu"
            ReportFilename = "Chamcong1.RPT"
        End If
        rptFrom = rptFrom.copyReportObject(rptFrom)
        With rptFrom
            .InitForm(ReportFilename, str, "QChamCong")

            .SetFormulas("TenCty", String.Format("'{0}'", pTenCty))
            .SetFormulas("TenCn", String.Format("'MST: {0}'", frmMain._LbCty_8.Text))
            .ReportWindowTitle = "Bảng chấm công nhân viên"
            .SetFormulas("ngayky", String.Format("'ngày {0} tháng {1} năm {2}'", DayofMonth(Lich), ConvertToStrSafe(Lich.SelectionStart.Month), ConvertToStrSafe(Lich.SelectionStart.Year)))
            .SetFormulas("songay", DayofMonth(Lich))
            .SetFormulas("thang", String.Format("'Tháng {0} - {1}'", Lich.SelectionStart.Month, ConvertToStrSafe(Lich.SelectionStart.Year)))
            .ReportWindowState = System.Windows.Forms.FormWindowState.Maximized

            Dim reportMessage As String = .DoReport()
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Tinhluong()
        Dim rs1, rs2, rs3 As DataTable
        Dim str1 As String = String.Empty
        Dim co As Integer
        Dim luong As ClsThongsoluong
        Dim tuthang, Thaisan, denthang As Integer
        Dim tungay, denngay As Date
        Dim sh As String = String.Empty
        Dim kt As Double
        Dim CD As New ClsChucDanh
        Dim Tangbh, ThangTangbh As Integer
        Dim thang As Integer = Lich.SelectionStart.Month
        Dim Nam As Integer = IIf(thang < pThangDauKy, ConvertToDblSafe(frmMain._LbCty_7.Text) + 1, ConvertToDblSafe(frmMain._LbCty_7.Text))
        Dim dong As Integer = GrdNhanvien.Row
        Dim LCB As Double
        Dim dem1, dem2 As Integer
        Dim tangcagio As Double
        Dim dem As Integer
        Dim rowCount As Integer
        If cuongNhanvien.Length <> 0 Then
            rowCount = 0
        Else
            rowCount = GrdNhanvien.Rows - 1
        End If
        For i As Integer = 0 To rowCount
            GrdNhanvien.Row = i
            GrdNhanvien.Col = ConvertToDblSafe(GrdNhanvien.Cols - 1) : sh = GrdNhanvien.Items(i).SubItems(35).Text 'GrdNhanvien.CtlText
            str1 = String.Format("SELECT maso FROM phucap WHERE sohieunhanvien=N'{0}' And thang = {1}", sh, ConvertToStrSafe(thang))
            rs2 = ExecSQLReturnDT(str1)
            If rs2.Rows.Count > 0 Then
                str1 = String.Format("SELECT t5.bacluong,t1.sohieu,t3.cong,t2.HSB1,t2.HSB2,t2.HSB3,t2.HSB4,t2.HSB5,t2.MLB1,t2.MLB2,t2.MLB3,t2.MLB4,t2.MLB5,t2.TVB1,t2.TVB2,t2.TVB3,t2.TVB4,t2.TVB5,t2.LNB1,t2.LNB2,t2.LNB3,t2.LNB4,t2.LNB5,t5.LoaiLuong,t1.maso,t4.chucvu,t4.trachnhiem,t4.luudong,t4.khac1,t4.khac2+t4.khac3+t4.khac4+t4.khac5 AS pck,t4.tamung,(t4.trukhac+t4.trukhac1) as trukhac,t4.trukhac2 as thue,t3.tangca,t3.nghi,t3.phep,t5.maso as maso1,t1.thaisan,t1.tungay,t1.denngay,t1.tuthang,t1.denthang,t4.loai,t5.maso as maso1,t1.nghiviec,t1.the,t1.baohiem,t1.tangbh,t1.thangtangbh FROM (((quanlynhanvien t1 inner join chucdanh t5 on t1.sohieu=t5.nhanvien) inner join chucvu t2 on t5.chucvu=t2.maso) inner join chamcong t3 on t1.sohieu=t3.manhanvien)inner join phucap t4 on t1.sohieu=t4.sohieunhanvien WHERE t1.SoHieu=N'{0}' and t3.thang={1} and t4.thang={1} and (t5.nam<{2} or (t5.nam={2} and t5.thang <={1})) order by t5.nam desc,t5.thang desc", _
                           sh, _
                           ConvertToStrSafe(thang), _
                           ConvertToStrSafe(Nam))
                co = 1
            Else
                str1 = String.Format("SELECT t5.bacluong,t1.sohieu,t3.cong,t2.HSB1,t2.HSB2,t2.HSB3,t2.HSB4,t2.HSB5,t2.MLB1,t2.MLB2,t2.MLB3,t2.MLB4,t2.MLB5,t2.TVB1,t2.TVB2,t2.TVB3,t2.TVB4,t2.TVB5,t2.LNB1,t2.LNB2,t2.LNB3,t2.LNB4,t2.LNB5,t5.LoaiLuong,t1.maso,t3.tangca,t3.nghi,t3.phep,t1.thaisan,t1.tungay,t1.denngay,t1.tuthang,t1.denthang,t1.nghiviec,t1.the,t1.baohiem,t5.maso as maso1,t1.tangbh,t1.thangtangbh FROM ((quanlynhanvien t1 inner join chucdanh t5 on t5.nhanvien=t1.sohieu) inner join chucvu t2 on t5.chucvu=t2.maso) inner join chamcong t3 on t1.sohieu=t3.manhanvien WHERE t1.SoHieu=N'{0}'  and t3.thang={1} and (t5.nam<{2} or (t5.nam={2} and t5.thang <={1})) order by t5.nam desc,t5.thang desc", _
                           sh, _
                           ConvertToStrSafe(thang), _
                           ConvertToStrSafe(Nam))
                co = 2
            End If
            rs1 = ExecSQLReturnDT(str1)
            If rs1.Rows.Count = 0 Then
                If co = 1 Then
                    str1 = String.Format("SELECT t5.bacluong,t1.sohieu,t3.cong,t2.HSB1,t2.HSB2,t2.HSB3,t2.HSB4,t2.HSB5,t2.MLB1,t2.MLB2,t2.MLB3,t2.MLB4,t2.MLB5,t2.TVB1,t2.TVB2,t2.TVB3,t2.TVB4,t2.TVB5,t2.LNB1,t2.LNB2,t2.LNB3,t2.LNB4,t2.LNB5,t5.LoaiLuong,t1.maso,t4.chucvu,t4.trachnhiem,t4.luudong,t4.khac1,t4.khac2+t4.khac3+t4.khac4+t4.khac5 AS pck,t4.tamung,(t4.trukhac+t4.trukhac1) as trukhac,t4.trukhac2 as thue,t3.tangca,t3.nghi,t3.phep,t1.thaisan,t1.tuthang,t1.denthang,t4.loai,t1.nghiviec,t5.maso as maso1,t1.baohiem,t1.tangbh,t1.thangtangbh FROM (((quanlynhanvien t1 inner join chucdanh t5 on t1.sohieu=t5.nhanvien) inner join chucvu t2 on t5.chucvu=t2.maso) inner join chamcong t3 on t1.sohieu=t3.manhanvien)inner join phucap t4 on t1.sohieu=t4.sohieunhanvien WHERE t1.SoHieu=N'{0}' and t3.thang={1} and t4.thang={1} and (t5.nam<{2} or (t5.nam={2} and t5.thang <={1})) order by t5.nam desc,t5.thang desc", _
                               sh, _
                               ConvertToStrSafe(thang), _
                               ConvertToStrSafe(Nam))
                Else
                    str1 = String.Format("SELECT t5.bacluong,t1.sohieu,t3.cong,t2.HSB1,t2.HSB2,t2.HSB3,t2.HSB4,t2.HSB5,t2.MLB1,t2.MLB2,t2.MLB3,t2.MLB4,t2.MLB5,t2.TVB1,t2.TVB2,t2.TVB3,t2.TVB4,t2.TVB5,t2.LNB1,t2.LNB2,t2.LNB3,t2.LNB4,t2.LNB5,t5.LoaiLuong,t1.maso,t3.tangca,t3.nghi,t3.phep,t1.thaisan,t1.tuthang,t1.denthang,t5.maso as maso1,t1.nghiviec,t1.baohiem,t1.tangbh,t1.thangtangbh FROM ((quanlynhanvien t1 inner join chucdanh t5 on t5.nhanvien=t1.sohieu) inner join chucvu t2 on t5.chucvu=t2.maso) inner join chamcong t3 on t1.sohieu=t3.manhanvien WHERE t1.SoHieu=N'{0}'  and t3.thang={1} and (t5.nam<{2} or (t5.nam={2} and t5.thang <={1})) order by t5.nam desc,t5.thang desc", _
                               sh, _
                               ConvertToStrSafe(thang), _
                               ConvertToStrSafe(Nam))
                End If
                rs1 = ExecSQLReturnDT(str1)
                If rs1.Rows.Count = 0 Then
                    MessageBox.Show(String.Format("Thông tin lương của nhân viên {0} chưa có !{1}Vui lòng kiểm tra lại danh sách nhân viên và chức danh !", sh, Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
            'LuongMoi:
            Dim rs1Item As DataRow = rs1.Rows(0)
            Tangbh = 0
            ThangTangbh = 0
            If Not IsDBNull(rs1Item("Tangbh")) Then
                If ConvertToDblSafe(rs1Item("Tangbh")) <> 0 Then
                    If rs1Item("Tangbh") IsNot Nothing Then
                        Tangbh = ConvertToDblSafe(rs1Item("Tangbh"))
                    End If
                    If rs1Item("ThangTangbh") IsNot Nothing Then
                        ThangTangbh = ConvertToDblSafe(rs1Item("ThangTangbh"))
                    End If

                End If
            End If
            luong = New ClsThongsoluong()
            dem = 0
            With luong
                .Sohieunhanvien = sh
                .thang = thang
                If rs1Item("Cong") IsNot Nothing Then
                    .Ngaycong = ConvertToDblSafe(rs1Item("Cong"))
                End If

                If ConvertToDblSafe(rs1Item("LoaiLuong")) = 1 Then
                    .Heso = ConvertToDblSafe(rs1Item(2 + ConvertToIntSafe(rs1Item("BacLuong"))))
                    .LCB = ConvertToDblSafe(GetSelectValue("SELECT lcb as f1 FROM license"))
                Else
                    If ConvertToDblSafe(rs1Item("LoaiLuong")) = 2 Then
                        .Heso = ConvertToDblSafe(rs1Item(7 + ConvertToIntSafe(rs1Item("BacLuong"))))
                    Else
                        If ConvertToDblSafe(rs1Item("LoaiLuong")) = 3 Then
                            .Heso = ConvertToDblSafe(rs1Item(7 + ConvertToIntSafe(rs1Item("BacLuong")) + 5))
                        Else
                            rs3 = ExecSQLReturnDT(String.Format("SELECT MaNhanVien,N1, N2, N3, N4, N5, N6, N7, N8, N9, N10, N11, N12, N13, N14, N15, N16, N17, N18, N19, N20, N21, N22, N23, N24, N25, N26, N27, N28, N29, N30, N31 FROM chamcong WHERE thang={0} order by manhanvien", Lich.SelectionStart.Month))
                            Try
                                For Each rs3Item As DataRow In rs3.Rows
                                    If dem > 0 Then
                                        Exit For
                                    End If
                                    For j As Integer = 1 To DayofMonth(Lich)
                                        Dim currentValue As String = LCase(ConvertToStrSafe(rs3Item(j)).Trim.ToUpper)
                                        If currentValue = "p" Or currentValue = "c" Or currentValue = "l" Or currentValue = "r" Or currentValue = "v" Then
                                            dem += 1
                                        End If
                                        If currentValue = "s" Or currentValue = "n" Then
                                            dem = 0
                                            Exit For
                                        End If
                                    Next
                                Next
                            Catch
                            End Try
                            .Heso = ConvertToDblSafe(rs1Item(7 + ConvertToIntSafe(rs1Item("BacLuong")) + 10)) * dem
                        End If
                    End If
                    .LCB = 0
                End If
                Thaisan = IIf(ConvertToStrSafe(rs1Item("Thaisan")) <> Nothing, ConvertToDblSafe(rs1Item("Thaisan")), 0)
                If rs1Item("tungay") IsNot DBNull.Value Then
                    tungay = ConvertToDateSafe(rs1Item("tungay"))
                End If
                If rs1Item("denngay") IsNot DBNull.Value Then
                    denngay = ConvertToDateSafe(rs1Item("denngay"))
                End If
                Try
                    tuthang = IIf(ConvertToDblSafe(rs1Item("tuthang")) <> 0, ConvertToDblSafe(rs1Item("tuthang")), 13)
                    denthang = IIf(ConvertToDblSafe(rs1Item("denthang")) <> 0, ConvertToDblSafe(rs1Item("denthang")), 13)
                Catch ex As Exception
                    tuthang = 13
                    denthang = 13
                End Try
                Try
                    .BHXH = 0
                    .BHYT = 0
                    .BHTN = 0
                    If ConvertToDblSafe(rs1Item("Baohiem")) = 0 Or (Tangbh = 1 And ThangTangbh <= thang) Then
                        If ChkBaohiem.CheckState Then
                            .BHYT = ConvertToDblSafe(TxtNVYT.Text)
                            If Not ((Thaisan = 1 And thang >= tuthang And thang <= denthang) Or (ConvertToDblSafe(rs1Item("Nghiviec")) = 1 And thang >= tuthang)) Then
                                .BHXH = ConvertToDblSafe(TxtNVXH.Text)
                                .BHTN = ConvertToDblSafe(TxtNVTN.Text)
                            End If
                        End If
                    End If
                    If rs1Item("BacLuong") IsNot Nothing Then
                        .Bac = ConvertToDblSafe(rs1Item("BacLuong"))
                    End If
                    If rs1Item("Tangca") IsNot Nothing Then
                        .Tangca = ConvertToDblSafe(rs1Item("Tangca"))
                    End If
                    If rs1Item("Nghi") IsNot Nothing Then
                        .Nghi = ConvertToDblSafe(rs1Item("Nghi"))
                    End If
                    If rs1Item("Phep") IsNot Nothing Then
                        .Phep = ConvertToDblSafe(rs1Item("Phep"))
                    End If

                    If co = 1 And Not ((Thaisan = 1 And thang >= tungay.Month And thang <= denngay.Month) Or (ConvertToDblSafe(rs1Item("Nghiviec")) = 1 And thang >= tuthang)) Then
                        If ConvertToDblSafe(rs1Item("loai")) = 1 Then
                            kt = IIf(.LCB = 0, ConvertToDblSafe(GetSelectValue("SELECT lcb as f1 FROM license")), .LCB)
                            If rs1Item("chucvu") IsNot Nothing Then
                                .PCCV = ConvertToDblSafe(rs1Item("chucvu")) * kt
                            End If
                            If rs1Item("Trachnhiem") IsNot Nothing Then
                                .PCTN = ConvertToDblSafe(rs1Item("Trachnhiem")) * kt
                            End If
                            If rs1Item("Luudong") IsNot Nothing Then
                                .PCLD = ConvertToDblSafe(rs1Item("Luudong")) * kt
                            End If
                            If rs1Item("khac1") IsNot Nothing Then
                                .Com = ConvertToDblSafe(rs1Item("Khac1")) * kt
                            End If
                            If rs1Item("PCK") IsNot Nothing Then
                                .PCK = ConvertToDblSafe(rs1Item("PCK")) * kt
                            End If

                        Else
                            If rs1Item("chucvu") IsNot Nothing Then
                                .PCCV = ConvertToDblSafe(rs1Item("chucvu"))
                            End If
                            If rs1Item("Trachnhiem") IsNot Nothing Then
                                .PCTN = ConvertToDblSafe(rs1Item("Trachnhiem"))
                            End If
                            If rs1Item("Luudong") IsNot Nothing Then
                                .PCLD = ConvertToDblSafe(rs1Item("Luudong"))
                            End If
                            If rs1Item("khac1") IsNot Nothing Then
                                .Com = ConvertToDblSafe(rs1Item("Khac1"))
                            End If
                            If rs1Item("PCK") IsNot Nothing Then
                                .PCK = ConvertToDblSafe(rs1Item("PCK"))
                            End If
                        End If
                        If rs1Item("Tamung") IsNot Nothing Then
                            .Tamung = ConvertToDblSafe(rs1Item("Tamung"))
                        End If
                        If rs1Item("Trukhac") IsNot Nothing Then
                            .Trukhac = ConvertToDblSafe(rs1Item("Trukhac"))
                        End If
                        If rs1Item("Thue") IsNot Nothing Then
                            .Thue = ConvertToDblSafe(rs1Item("Thue"))
                        End If
                    Else
                        .Tamung = 0
                        .Trukhac = 0
                        .Thue = 0
                    End If
                    .thuong = 0
                    .congkhac = 0
                    '*************************** Tính lương khi tăng lương theo hợp đồng **************************
                    If ConvertToBoolSafe(GetSelectValue(String.Format("SELECT maso as f1 FROM chucdanh WHERE nhanvien=N'{0}' and nam={1} and thang={2}", _
                                                            sh, _
                                                            ConvertToStrSafe(Nam), _
                                                            ConvertToStrSafe(thang)))) Then
                        If rs2.Rows.Count > 0 Then
                            str1 = String.Format("SELECT t5.bacluong,t1.sohieu,t3.cong,t2.HSB1,t2.HSB2,t2.HSB3,t2.HSB4,t2.HSB5,t2.MLB1,t2.MLB2,t2.MLB3,t2.MLB4,t2.MLB5,t2.TVB1,t2.TVB2,t2.TVB3,t2.TVB4,t2.TVB5,t2.LNB1,t2.LNB2,t2.LNB3,t2.LNB4,t2.LNB5,t5.LoaiLuong,t1.maso,t4.chucvu,t4.trachnhiem,t4.luudong,t4.khac1,t4.khac2+t4.khac3+t4.khac4+t4.khac5 AS pck,t3.tangca,t3.nghi,t3.phep,t1.thaisan,t1.tungay,t1.denngay,t1.tuthang,t1.denthang,t4.loai,t1.nghiviec,t5.maso as maso1,t1.baohiem,t1.tangbh,t1.thangtangbh FROM (((quanlynhanvien t1 inner join chucdanh t5 on t1.sohieu=t5.nhanvien) inner join chucvu t2 on t5.chucvu=t2.maso) inner join chamcong t3 on t1.sohieu=t3.manhanvien)inner join phucap t4 on t1.sohieu=t4.sohieunhanvien WHERE t1.SoHieu=N'{0}' and t3.thang={1} and t4.thang={1} and t5.nam={2} and t5.thang={1} order by t5.nam desc,t5.thang desc", _
                                       sh, _
                                       ConvertToStrSafe(thang), _
                                       ConvertToStrSafe(Nam))
                            co = 1
                        Else
                            str1 = String.Format("SELECT t5.bacluong,t1.sohieu,t3.cong,t2.HSB1,t2.HSB2,t2.HSB3,t2.HSB4,t2.HSB5,t2.MLB1,t2.MLB2,t2.MLB3,t2.MLB4,t2.MLB5,t2.TVB1,t2.TVB2,t2.TVB3,t2.TVB4,t2.TVB5,t2.LNB1,t2.LNB2,t2.LNB3,t2.LNB4,t2.LNB5,t5.LoaiLuong,t1.maso,t3.tangca,t3.nghi,t3.phep,t1.thaisan,t1.tungay,t1.denngay,t1.tuthang,t1.denthang,t1.nghiviec,t5.maso as maso1,t1.baohiem,t1.tangbh,t1.thangtangbh FROM ((quanlynhanvien t1 inner join chucdanh t5 on t5.nhanvien=t1.sohieu) inner join chucvu t2 on t5.chucvu=t2.maso) inner join chamcong t3 on t1.sohieu=t3.manhanvien WHERE t1.SoHieu=N'{0}'  and t3.thang={1} and t5.nam={2} and t5.thang={1} order by t5.nam desc,t5.thang desc", _
                                       sh, _
                                       ConvertToStrSafe(thang), _
                                       ConvertToStrSafe(Nam))
                            co = 2
                        End If
                        rs1 = ExecSQLReturnDT(str1)
                        If rs1.Rows.Count = 0 Then
                            MessageBox.Show(String.Format("Thông tin lương của nhân viên {0} chưa có !{1}Vui lòng kiểm tra lại danh sách nhân viên và chức danh !", sh, Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        Else
                            Tangbh = 0
                            ThangTangbh = 0
                            If Not IsDBNull(rs1Item("Tangbh")) Then
                                If ConvertToDblSafe(rs1Item("Tangbh")) <> 0 Then
                                    If rs1Item("Tangbh") IsNot Nothing Then
                                        Tangbh = ConvertToDblSafe(rs1Item("Tangbh"))
                                    End If
                                    If rs1Item("ThangTangbh") IsNot Nothing Then
                                        ThangTangbh = ConvertToDblSafe(rs1Item("ThangTangbh"))
                                    End If
                                End If
                            End If
                            With luong
                                If ConvertToDblSafe(rs1Item("LoaiLuong")) = 1 Then
                                    .Heso1 = ConvertToDblSafe(rs1Item(2 + ConvertToIntSafe(rs1Item("BacLuong"))))
                                    LCB = ConvertToDblSafe(GetSelectValue("SELECT lcb as f1 FROM license"))
                                Else
                                    If ConvertToDblSafe(rs1Item("LoaiLuong")) = 2 Then
                                        .Heso1 = ConvertToDblSafe(rs1Item(7 + ConvertToIntSafe(rs1Item("BacLuong"))))
                                    Else
                                        If ConvertToDblSafe(rs1Item("LoaiLuong")) = 3 Then
                                            .Heso1 = ConvertToDblSafe(rs1Item(7 + ConvertToIntSafe(rs1Item("BacLuong")))) + 5
                                        Else
                                            rs3 = ExecSQLReturnDT(String.Format("SELECT MaNhanVien,N1, N2, N3, N4, N5, N6, N7, N8, N9, N10, N11, N12, N13, N14, N15, N16, N17, N18, N19, N20, N21, N22, N23, N24, N25, N26, N27, N28, N29, N30, N31 FROM chamcong WHERE thang={0} order by manhanvien", Lich.SelectionStart.Month))
                                            Try
                                                dem = 0
                                                For Each rs3Item As DataRow In rs3.Rows
                                                    If dem > 0 Then
                                                        Exit For
                                                    End If
                                                    For j As Integer = 1 To DayofMonth(Lich)
                                                        Dim currentValue As String = LCase(ConvertToStrSafe(rs3Item(j)).Trim.ToUpper)
                                                        If currentValue = "p" Or currentValue = "c" Or currentValue = "l" Or currentValue = "r" Or currentValue = "v" Then
                                                            dem += 1
                                                        End If
                                                        If currentValue = "s" Or currentValue = "n" Then
                                                            dem = 0
                                                            Exit For
                                                        End If
                                                    Next
                                                Next
                                            Catch
                                            End Try
                                            .Heso1 = ConvertToDblSafe(rs1Item(7 + ConvertToIntSafe(rs1Item("BacLuong")) + 10)) * dem
                                        End If
                                    End If
                                    LCB = 0
                                End If
                                Thaisan = IIf(ConvertToDblSafe(rs1Item("Thaisan")) <> Nothing, ConvertToDblSafe(rs1Item("Thaisan")), 0)
                                If rs1Item("tungay") Is DBNull.Value Then
                                    tungay = ConvertToDateSafe(rs1Item("tungay"))
                                End If
                                If rs1Item("denngay") Is DBNull.Value Then
                                    denngay = ConvertToDateSafe(rs1Item("denngay"))
                                End If
                                Try
                                    tuthang = IIf(ConvertToDblSafe(rs1Item("tuthang")) <> 0, ConvertToDblSafe(rs1Item("tuthang")), 13)
                                    denthang = IIf(ConvertToDblSafe(rs1Item("denthang")) <> 0, ConvertToDblSafe(rs1Item("denthang")), 13)
                                Catch ex As Exception
                                    tuthang = 13
                                    denthang = 13
                                End Try
                                .BHXH1 = 0
                                .BHYT1 = 0
                                .BHTN1 = 0
                                If ConvertToDblSafe(rs1Item("Baohiem")) = 0 Or (Tangbh = 1 And ThangTangbh <= thang) Then
                                    If ChkBaohiem.CheckState Then
                                        .BHYT1 = ConvertToDblSafe(TxtNVYT.Text)
                                        If Not ((Thaisan = 1 And thang >= tuthang And thang <= denthang) Or (ConvertToDblSafe(rs1Item("Nghiviec")) = 1 And thang >= tuthang)) Then
                                            .BHXH1 = ConvertToDblSafe(TxtNVXH.Text)
                                            .BHTN1 = ConvertToDblSafe(TxtNVTN.Text)
                                        End If
                                    End If
                                End If
                                If rs1Item("BacLuong") IsNot Nothing Then
                                    .Bac1 = ConvertToDblSafe(rs1Item("BacLuong"))
                                End If

                                If co = 1 And Not ((Thaisan = 1 And thang >= tungay.Month And thang <= denngay.Month) Or (ConvertToDblSafe(rs1Item("Nghiviec")) = 1 And thang >= tuthang)) Then
                                    If ConvertToDblSafe(rs1Item("loai")) = 1 Then
                                        kt = IIf(LCB = 0, ConvertToDblSafe(GetSelectValue("SELECT lcb as f1 FROM license")), LCB)
                                        If rs1Item("chucvu") IsNot Nothing Then
                                            .PCCV1 = ConvertToDblSafe(rs1Item("chucvu")) * kt
                                        End If
                                        If rs1Item("Trachnhiem") IsNot Nothing Then
                                            .PCTN1 = ConvertToDblSafe(rs1Item("Trachnhiem")) * kt
                                        End If
                                        If rs1Item("Luudong") IsNot Nothing Then
                                            .PCLD1 = ConvertToDblSafe(rs1Item("Luudong")) * kt
                                        End If
                                        If rs1Item("khac1") IsNot Nothing Then
                                            .com1 = ConvertToDblSafe(rs1Item("Khac1")) * kt
                                        End If
                                        If rs1Item("PCK") IsNot Nothing Then
                                            .PCK1 = ConvertToDblSafe(rs1Item("PCK")) * kt
                                        End If
                                    Else
                                        If rs1Item("chucvu") IsNot Nothing Then
                                            .PCCV1 = ConvertToDblSafe(rs1Item("chucvu"))
                                        End If
                                        If rs1Item("Trachnhiem") IsNot Nothing Then
                                            .PCTN1 = ConvertToDblSafe(rs1Item("Trachnhiem"))
                                        End If
                                        If rs1Item("Luudong") IsNot Nothing Then
                                            .PCLD1 = ConvertToDblSafe(rs1Item("Luudong"))
                                        End If
                                        If rs1Item("khac1") IsNot Nothing Then
                                            .com1 = ConvertToDblSafe(rs1Item("Khac1"))
                                        End If
                                        If rs1Item("PCK") IsNot Nothing Then
                                            .PCK1 = ConvertToDblSafe(rs1Item("PCK"))
                                        End If
                                    End If
                                End If
                                '***************************** Đếm ngày tính lương trước và sau khi tăng lương ***************
                                CD.InitMaSo(ConvertToDblSafe(rs1Item("MaSo1")))
                                rs3 = ExecSQLReturnDT(String.Format("SELECT MaNhanVien,N1, N2, N3, N4, N5, N6, N7, N8, N9, N10, N11, N12, N13, N14, N15, N16, N17, N18, N19, N20, N21, N22, N23, N24, N25, N26, N27, N28, N29, N30, N31 FROM chamcong WHERE thang={0} order by manhanvien", Lich.SelectionStart.Month))
                                Dim rs3Index As Integer = 0
                                For Each rs3Item As DataRow In rs3.Rows
                                    If dem > 0 Then
                                        Exit For
                                    End If
                                    If CD.NgayApdung.Day <> 1 Then
                                        For j As Integer = 1 To DateAndTime.Day(CD.NgayApdung) - 1
                                            Dim currentItem As String = LCase(ConvertToStrSafe(rs3Item(j)).Trim.ToUpper)
                                            If currentItem = "p" Or currentItem = "c" Or currentItem = "l" Or currentItem = "r" Or currentItem = "v" Then
                                                dem += 1
                                            End If
                                            If currentItem = "s" Or currentItem = "n" Then
                                                dem = 0
                                                Exit For
                                            End If
                                        Next
                                    Else
                                        Exit For
                                    End If
                                    rs3Index += 1
                                Next
                                If rs3Index = (rs3.Rows.Count - 1) Then
                                    If rs3Index > 0 Then
                                        rs3Index -= 1
                                    End If
                                End If
                                For k As Integer = rs3Index To rs3.Rows.Count - 1
                                    If dem2 > 0 Then
                                        Exit For
                                    End If
                                    Dim rs3Item As DataRow = rs3.Rows(k)
                                    For j As Integer = CD.NgayApdung.Day To DayofMonth(Lich)
                                        Dim currentItem As String = LCase(ConvertToStrSafe(rs3Item(j)).Trim.ToUpper)
                                        If currentItem = "p" Or currentItem = "c" Or currentItem = "l" Or currentItem = "r" Or currentItem = "v" Then
                                            dem += 1
                                        End If
                                        If currentItem = "s" Or currentItem = "n" Then
                                            dem = 0
                                            Exit For
                                        End If
                                    Next
                                Next
                                .Demcu = dem1
                                .Demmoi = dem2
                            End With
                        End If
                    End If
                    If Chk.CheckState = CheckState.Checked Then
                        luong.Luong13 = ConvertToDblSafe(Luong13.Text) / 100 * ConvertToDblSafe(GetSelectValue(String.Format("SELECT thang13 as f1, max(ngayapdung) FROM chucdanh WHERE nhanvien=N'{0}' group by thang13", sh)))
                    Else
                        luong.Luong13 = 0
                    End If
                    If ConvertToDblSafe(GetSelectValue(String.Format("SELECT maso as f1 FROM thongsoluong WHERE sohieunhanvien=N'{0}' and thang={1}", _
                                                           sh, _
                                                           luong.thang))) = 0 Then
                        luong.GhiNV()
                    Else
                        luong.SuaNV()
                    End If
                    '*********************************** Thêm tăng ca ngoài giờ **************************************
                    tangcagio = ConvertToDblSafe(GetSelectValue(String.Format("SELECT tangca as f1 FROM phucap WHERE sohieunhanvien=N'{0}' and thang={1}", _
                                                                    sh, _
                                                                    luong.thang)))
                    ExecSQLNonQuery(String.Format("UPDATE thongsoluong set tangcagio={0} WHERE sohieunhanvien=N'{1}' and thang={2}", _
                                        tangcagio, _
                                        sh, _
                                        luong.thang))
                    If cuongNhanvien.Length <> 0 Then
                        Exit For
                    End If
                Catch ex As Exception
                    MessageBox.Show(Ngonngu("Lỗi tính lương!", "Error salary deduction!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End With
        Next
        GrdNhanvien.Row = dong
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Xoa()
        Dim rs As DataTable
        If cuongNhanvien.Length = 0 Then
            ExecSQLNonQuery(String.Format("UPDATE phucap SET trukhac2=0 WHERE thang={0}", Lich.SelectionStart.Month))
            ExecSQLNonQuery(String.Format("DELETE  FROM chamcong WHERE thang={0}", Lich.SelectionStart.Month))
            ExecSQLNonQuery(String.Format("DELETE  FROM thongsoluong WHERE thang={0}", Lich.SelectionStart.Month))
            ExecSQLNonQuery(String.Format("DELETE  FROM bangluong WHERE thang={0}", Lich.SelectionStart.Month))
        Else
            Dim loopCount As Integer = 0
            If cuongNhanvien.Length <> 0 Then
                loopCount = 1
            Else
                loopCount = GrdNhanvien.Rows - 1
            End If
            Dim deleteTs As Boolean = True
            For i As Integer = 0 To loopCount
                GrdNhanvien.Row = i
                GrdNhanvien.Col = ConvertToDblSafe(GrdNhanvien.Cols - 1)
                If ExecSQLNonQuery(String.Format("DELETE  FROM Chamcong WHERE thang={0} and Manhanvien=N'{1}'", _
                                       Lich.SelectionStart.Month, _
                                       GrdNhanvien.CtlText)) <> 0 Then
                    deleteTs = False
                    Exit For
                End If
                rs = ExecSQLReturnDT(String.Format("SELECT maso FROM thongsoluong WHERE thang={0}", Lich.SelectionStart.Month))
                If rs.Rows.Count = 0 Then
                    HuyLe()
                End If
                ExecSQLNonQuery(String.Format("DELETE  FROM thongsoluong WHERE thang={0} and sohieunhanvien=N'{1}'", _
                                    Lich.SelectionStart.Month, _
                                    GrdNhanvien.CtlText))
                If cuongNhanvien.Length <> 0 Then
                    deleteTs = False
                    Exit For
                End If
            Next
            If deleteTs Then
                ExecSQLNonQuery(String.Format("DELETE  FROM thongsoluong WHERE thang={0}", Lich.SelectionStart.Month))
                ExecSQLNonQuery(String.Format("DELETE  FROM bangluong WHERE thang={0}", Lich.SelectionStart.Month))
                HuyLe()
            End If
        End If
        Hienthiluoi()
        GrdNhanvien.Focus()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub HuyLe()
        Dim dong As Integer = GrdNhanvien.Row
        Dim cot As Integer = GrdNhanvien.Col
        For T As Integer = 1 To DayofMonth(Lich)
            If Label(T).BackColor.Equals(Color.Blue) Then
                Label(T).BackColor = ColorTranslator.FromOle(mau)
                Label(T + 40).Visible = False
                For i As Integer = 0 To GrdNhanvien.Rows - 1
                    GrdNhanvien.Row = (i)
                    GrdNhanvien.Col = (T + 3)
                    GrdNhanvien.CtlText = "c"
                Next
            End If
        Next
        GrdNhanvien.Row = dong
        GrdNhanvien.Col = cot
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Ghi()
        Dim str As String = String.Empty
        Dim rs As DataTable
        Dim dong As Integer = GrdNhanvien.Row
        Dim loopCount As Integer = 0
        If cuongNhanvien.Length <> 0 Then
            loopCount = 1
        Else
            loopCount = GrdNhanvien.Rows - 1
        End If

        For i As Integer = 0 To loopCount
            GrdNhanvien.Row = i

            If Not KiemTraSoLieu1(i) Then
                Exit For
            End If
            mnv = GrdNhanvien.Items(i).SubItems(35).Text
            Dim a As String = GrdNhanvien.Items(i).SubItems(35).Text
            str = String.Format("SELECT * FROM chamcong WHERE thang={0} and manhanvien=N'{1}'", Lich.SelectionStart.Month, mnv)
            rs = ExecSQLReturnDT(str)
            If rs.Rows.Count = 0 Then
                str = String.Format("INSERT into Chamcong(maso,manhanvien,thang,cong,nghi,phep,tangca,n1,n2,n3,n4,n5,n6,n7,n8,n9,n10,n11,n12,n13,n14,n15,n16,n17,n18,n19,n20,n21,n22,n23,n24,n25,n26,n27,n28,n29,n30,n31,DNBHXH, DNBHYT, DNBHTN, NVBHXH, NVBHYT, NVBHTN, TNCN,GiaCanh) values({1}, N'{2}',{3},{4},{5},{6},{7}, N'{8}', N'{9}', N'{10}', N'{11}', N'{12}', N'{13}', N'{14}', N'{15}', N'{16}', N'{17}', N'{18}', N'{19}', N'{20}', N'{21}', N'{22}', N'{23}', N'{24}', N'{25}', N'{26}', N'{27}', N'{28}', N'{29}', N'{30}', N'{31}', N'{32}', N'{33}', N'{34}', N'{35}', N'{36}', N'{37}', N'{38}'{39})", _
                            "", _
                          (Lng_MaxValue("MaSo", "chamcong") + 1), _
                          mnv, _
                          (Lich.SelectionStart.Month), _
                          doidau(Cong), _
                          doidau(Nghi), _
                          doidau(Phep), _
                          doidau(Tangca), _
                          n1, _
                          n2, _
                          N3, _
                          N4, _
                          N5, _
                          N6, _
                          N7, _
                          N8, _
                          N9, _
                          N10, _
                          N11, _
                          N12, _
                          N13, _
                          N14, _
                          N15, _
                          N16, _
                          N17, _
                          N18, _
                          N19, _
                          N20, _
                          N21, _
                          N22, _
                          N23, _
                          N24, _
                          N25, _
                          N26, _
                          N27, _
                          N28, _
                          N29, _
                          N30, _
                          N31, _
                          String.Format(",{0},{1},{2},{3},{4},{5},{6},{7}", doidau(TxtDNXH.Text), doidau(TxtDNYT.Text), doidau(TxtDNTN.Text), doidau(TxtNVXH.Text), doidau(TxtNVYT.Text), doidau(TxtNVTN.Text), doidau(TxtTNCN.Text), doidau(TxtGiaCanh.Text)))
            Else
                str = String.Format("UPDATE chamcong set cong={0},phep={1},nghi={2},tangca={3},n1=N'{4}',n2=N'{5}',n3=N'{6}',n4=N'{7}',n5=N'{8}',n6=N'{9}',n7=N'{10}',n8=N'{11}',n9=N'{12}',n10=N'{13}',n11=N'{14}',n12=N'{15}',n13=N'{16}',n14=N'{17}',n15=N'{18}',n16=N'{19}',n17=N'{20}',n18=N'{21}',n19=N'{22}',n20=N'{23}',n21=N'{24}',n22=N'{25}',n23=N'{26}',n24=N'{27}',n25=N'{28}',n26=N'{29}',n27=N'{30}',n28=N'{31}',n29=N'{32}',n30=N'{33}',n31=N'{34}'{35} WHERE thang={36} and manhanvien=N'{37}'", _
                          doidau(Cong), _
                          doidau(Phep), _
                          doidau(Nghi), _
                          doidau(Tangca), _
                          n1, _
                          n2, _
                          N3, _
                          N4, _
                          N5, _
                          N6, _
                          N7, _
                          N8, _
                          N9, _
                          N10, _
                          N11, _
                          N12, _
                          N13, _
                          N14, _
                          N15, _
                          N16, _
                          N17, _
                          N18, _
                          N19, _
                          N20, _
                          N21, _
                          N22, _
                          N23, _
                          N24, _
                          N25, _
                          N26, _
                          N27, _
                          N28, _
                          N29, _
                          N30, _
                          N31, _
                          String.Format(",DNBHXH={0},DNBHYT={1},DNBHTN={2},NVBHXH={3},NVBHYT={4},NVBHTN={5},TNCN={6},GiaCanh={7}", doidau(TxtDNXH.Text), doidau(TxtDNYT.Text), doidau(TxtDNTN.Text), doidau(TxtNVXH.Text), doidau(TxtNVYT.Text), doidau(TxtNVTN.Text), doidau(TxtTNCN.Text), doidau(TxtGiaCanh.Text)), _
                          (Lich.SelectionStart.Month), _
                          mnv)
            End If
            If ExecSQLNonQuery(str) <> 0 Then
                ErrMsg(er_SoHieu)
                Exit For
            End If
            If cuongNhanvien.Length <> 0 Then
                Exit For
            End If
        Next
        ResetLe()
        Hienthiluoi()
        GrdNhanvien.Focus()
        GrdNhanvien.Row = (dong)
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
        With GrdNhanvien
            .Col = ConvertToDblSafe(.Cols - 1) : mnv = .CtlText
            Cong = 0
            Nghi = 0
            Phep = 0
            Tangca = 0
            Le = 0
            For i As Integer = 1 To DayofMonth(Lich)
                .Col = (i + 3)
                If .CtlText = "l" Then
                    Cong += 0.5 : Nghi += 0.5
                End If
                If .CtlText = "r" Then
                    Cong += 0.5 : Phep += 0.5
                End If
                If .CtlText = "c" Then Cong += 1
                If .CtlText = "v" Then Nghi += 1
                If .CtlText = "p" Then Phep += 1
                If .CtlText = "t" Then Tangca += 1
                If .CtlText = " t " Then Le += 1
                Select Case i
                    Case 1 : n1 = .CtlText : Case 2 : n2 = .CtlText : Case 3 : N3 = .CtlText : Case 4 : N4 = .CtlText : Case 5 : N5 = .CtlText
                    Case 6 : N6 = .CtlText : Case 7 : N7 = .CtlText : Case 8 : N8 = .CtlText : Case 9 : N9 = .CtlText : Case 10 : N10 = .CtlText
                    Case 11 : N11 = .CtlText : Case 12 : N12 = .CtlText : Case 13 : N13 = .CtlText : Case 14 : N14 = .CtlText : Case 15 : N15 = .CtlText
                    Case 16 : N16 = .CtlText : Case 17 : N17 = .CtlText : Case 18 : N18 = .CtlText : Case 19 : N19 = .CtlText : Case 20 : N20 = .CtlText
                    Case 21 : N21 = .CtlText : Case 22 : N22 = .CtlText : Case 23 : N23 = .CtlText : Case 24 : N24 = .CtlText : Case 25 : N25 = .CtlText
                    Case 26 : N26 = .CtlText : Case 27 : N27 = .CtlText : Case 28 : N28 = .CtlText : Case 29 : N29 = .CtlText : Case 30 : N30 = .CtlText : Case 31 : N31 = .CtlText
                End Select
            Next
            Tangca = Tangca * ConvertToDblSafe(TxtChunhat.Text) + Le * ConvertToDblSafe(TxtNgayle.Text)
        End With
        Return True
    End Function
    Private Function KiemTraSoLieu1(ByVal dong As Integer) As Boolean
        Dim result As Boolean = False
        With GrdNhanvien
            .Col = ConvertToDblSafe(.Cols - 1) : mnv = .Items(.Row).SubItems(.Cols - 1).Text
            Cong = 0
            Nghi = 0
            Phep = 0
            Tangca = 0
            Le = 0
            For i As Integer = 1 To DayofMonth(Lich)
                .Col = (i + 3)
                If GrdNhanvien.Items(dong).SubItems(i + 3).Text = "l" Then
                    Cong += 0.5 : Nghi += 0.5
                End If
                If GrdNhanvien.Items(dong).SubItems(i + 3).Text = "r" Then
                    Cong += 0.5 : Phep += 0.5
                End If
                If GrdNhanvien.Items(dong).SubItems(i + 3).Text = "c" Then Cong += 1
                If GrdNhanvien.Items(dong).SubItems(i + 3).Text = "v" Then Nghi += 1
                If GrdNhanvien.Items(dong).SubItems(i + 3).Text = "p" Then Phep += 1
                If GrdNhanvien.Items(dong).SubItems(i + 3).Text = "t" Then Tangca += 1
                If GrdNhanvien.Items(dong).SubItems(i + 3).Text = " t " Then Le += 1
                Select Case i
                    Case 1 : n1 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 2 : n2 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 3 : N3 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 4 : N4 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 5 : N5 = GrdNhanvien.Items(dong).SubItems(i + 3).Text
                    Case 6 : N6 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 7 : N7 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 8 : N8 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 9 : N9 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 10 : N10 = GrdNhanvien.Items(dong).SubItems(i + 3).Text
                    Case 11 : N11 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 12 : N12 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 13 : N13 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 14 : N14 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 15 : N15 = GrdNhanvien.Items(dong).SubItems(i + 3).Text
                    Case 16 : N16 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 17 : N17 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 18 : N18 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 19 : N19 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 20 : N20 = GrdNhanvien.Items(dong).SubItems(i + 3).Text
                    Case 21 : N21 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 22 : N22 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 23 : N23 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 24 : N24 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 25 : N25 = GrdNhanvien.Items(dong).SubItems(i + 3).Text
                    Case 26 : N26 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 27 : N27 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 28 : N28 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 29 : N29 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 30 : N30 = GrdNhanvien.Items(dong).SubItems(i + 3).Text : Case 31 : N31 = GrdNhanvien.Items(dong).SubItems(i + 3).Text
                End Select
            Next
            Tangca = Tangca * ConvertToDblSafe(TxtChunhat.Text) + Le * ConvertToDblSafe(TxtNgayle.Text)
        End With
        Return True
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Hienthiluoi()
        Chk.CheckState = CheckState.Unchecked
        Dim truongdacoChamcong As Boolean = TruongDaCo("Chamcong", "DNBHXH")
        Khoaquyen()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="uid"></param>
    ''' <remarks></remarks>
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(0).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        Command(2).Enabled = (User_Right <> 2 Or (UserID = uid))
        Command(9).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        If User_Right <> 0 Then
            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT Lock{0} % 10 AS F1 FROM License", CboThang.SelectedValue))) > 0 Then
                Command(0).Enabled = False
                Command(2).Enabled = False
                Command(9).Enabled = False
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmChamcong_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case KeyCode
                Case Keys.G
                    Command(0).Focus()
                Case Keys.V
                    Command(1).Focus()
                Case Keys.X
                    Command(2).Focus()
                Case Keys.P
                    Command(3).Focus()
                Case Keys.K
                    Command(5).Focus()
                Case Keys.B
                    Command(7).Focus()
                Case Keys.L
                    Command(9).Focus()
            End Select
        End If
        Try
            If eventArgs.KeyCode = Keys.Escape Then Me.Close()
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmChamcong_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Updatelicense()
        'set icon
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
        Call FormInit()
        Try
            Dim a As Integer
            If Not TruongDaCo("ThongSoLuong", "Luong13") Then
                ExecSQLNonQuery("alter table ThongSoLuong add Luong13 integer null")
            End If
            If Not TruongDaCo("Chucdanh", "thang13") Then
                ExecSQLNonQuery("alter table Chucdanh add thang13 integer null")
                rs = ExecSQLReturnDT("SELECT nhanvien,min(ngayapdung)as ngay FROM Chucdanh group by nhanvien")
                For Each rsItem As DataRow In rs.Rows
                    a = DateDiff(DateInterval.Month, DateSerial(pNamTC, 12, 31), ConvertToDateSafe(rsItem("Ngay"))) / 12 * 100
                    If a > 100 Then a -= 100
                    a = Math.Round(ConvertToDblSafe(a))
                    ExecSQLNonQuery(String.Format("UPDATE Chucdanh set thang13={0} WHERE nhanvien=N'{1}'", a, rsItem("Nhanvien")))
                Next
            End If
        Catch
        End Try

        ColumnSetUp(GrdNhanvien, 0, 350, System.Drawing.ContentAlignment.MiddleCenter)
        ColumnSetUp(GrdNhanvien, 1, 2400, System.Drawing.ContentAlignment.MiddleLeft)
        ColumnSetUp(GrdNhanvien, 2, 1920, System.Drawing.ContentAlignment.MiddleLeft)
        ColumnSetUp(GrdNhanvien, 3, 1920, System.Drawing.ContentAlignment.MiddleLeft)

        For i As Integer = 1 To 31
            ColumnSetUp(GrdNhanvien, i + 3, 250, System.Drawing.ContentAlignment.MiddleCenter)
        Next
        ColumnSetUp(GrdNhanvien, 35, 1, 0)
        Text = SetFormTitle(Text)
        AddMonthToCbo(CboThang)
        If CboThang.Items.Count > 0 Then
            CboThang.SelectedIndex = CThangDB2(Today.Month - 1)
        End If

        formInitComplete = True
        SetFont(Me)
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
                    GrdNhanvien.Col = (i + 3)
                    If ColorTranslator.ToOle(Label(i).BackColor) = mau Then GrdNhanvien.CtlText = "c"
                Next
            Else
                If co = 1 Then
                    For i As Integer = 1 To DayofMonth(Lich)
                        GrdNhanvien.Col = (i + 3)
                        If i < ngayts Then
                            If ColorTranslator.ToOle(Label(i).BackColor) = mau Then GrdNhanvien.CtlText = "c"
                        Else
                            GrdNhanvien.CtlText = "s"
                        End If
                    Next
                Else
                    If co = 2 Then
                        For i As Integer = 1 To DayofMonth(Lich)
                            GrdNhanvien.Col = (i + 3)
                            If i > ngayts Then
                                If ColorTranslator.ToOle(Label(i).BackColor) = mau Then GrdNhanvien.CtlText = "c"
                            Else
                                GrdNhanvien.CtlText = "s"
                            End If
                        Next
                    Else
                        For i As Integer = 1 To DayofMonth(Lich)
                            GrdNhanvien.Col = (i + 3)
                            GrdNhanvien.CtlText = "s"
                        Next
                    End If
                End If
            End If
        Else
            For i As Integer = 1 To DayofMonth(Lich)
                GrdNhanvien.Col = (i + 3)
                If Lich.SelectionStart.Month = thangnghi Then
                    If i < Ngay Then
                        If ColorTranslator.ToOle(Label(i).BackColor) = mau Then GrdNhanvien.CtlText = "c"
                    Else
                        GrdNhanvien.CtlText = "n"
                    End If
                Else
                    GrdNhanvien.CtlText = "n"
                End If
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
                If Not Label(i + 40).Visible Then Label(i).BackColor = Color.Teal
                If thu = 1 Then
                    Label(i).BackColor = Color.Red
                    GrdNhanvien.Col = (i + 3)
                    GrdNhanvien.CtlText = ""
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
    Function kiemtranamnhuan(ByRef nam As Integer) As Boolean
        If (nam Mod 400 = 0) Or (nam Mod 4 = 0 And nam Mod 100 <> 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub Hienthiluoi()
        Me.Cursor = Cursors.WaitCursor
        str = "SELECT t1.sohieu as manhanvien,t1.ten as Hoten,t2.ten as Bophan,t3.ten as Chucvu,t1.sohieu,t1.nghiviec,t1.ngaynghi,t1.thaisan,t1.tungay,t1.denngay,t1.tuthang,t1.denthang,t1.tang,t1.thangtang,t1.the,t1.den,t1.baohiem FROM chucvu t3 inner join (Phanloaiquanlynhanvien t2 inner join quanlynhanvien t1 on t1.maphanloai=t2.maso) on t1.machucvu=t3.maso WHERE 1=1 group by t1.maso,t1.sohieu,t1.ten,t2.ten,t3.ten,t1.sohieu,t1.nghiviec,t1.ngaynghi,t1.thaisan,t1.tungay,t1.denngay,t1.tuthang,t1.denthang,t1.tang,t1.thangtang,t1.the,t1.den,t1.baohiem ORDER BY t1.sohieu"
        rs = ExecSQLReturnDT(str)
        Try
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
            Dim tru As Integer = 0
            Dim lan As Integer = 0

            GrdNhanvien.BeginUpdate()
            If rs.Rows.Count > 0 Then
                ClearGrid(GrdNhanvien, GrdNhanvien.Rows)
                If rs.Rows.Count < 18 Then
                    GrdNhanvien.Width = 942 '14050
                Else
                    GrdNhanvien.Width = 956 '14295
                End If

                Dim rsItem As DataRow
                Dim dTungay As Date
                Dim dDenngay As Date
                Dim dNgaynghi As Date

                If rs.Rows.Count > 0 Then
                    With GrdNhanvien
                        HuyLe()

                        Dim tValue As String
                        Dim rs1Item As DataRow

                        BoChuNhat()
                        Dim nam As String = CboThang.Text.Split("/")(1)
                        Dim mangngay() As Integer = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
                        If kiemtranamnhuan(nam) = True Then
                            mangngay(2) = 29
                        End If
                        Dim mang As String() = {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
                        For i As Double = 0 To rs.Rows.Count - 1
                            .Row = i

                            rsItem = rs.Rows(i)
                            If rsItem("tungay") IsNot Nothing Then
                                dTungay = ConvertToDateSafe(rsItem("tungay"))
                            End If
                            If rsItem("denngay") IsNot Nothing Then
                                dDenngay = ConvertToDateSafe(rsItem("denngay"))
                            End If
                            If rsItem("Ngaynghi") IsNot Nothing Then
                                dNgaynghi = ConvertToDateSafe(rsItem("Ngaynghi"))
                            End If
                            If rsItem("Nghiviec") IsNot Nothing Then
                                Nghiviec = ConvertToDblSafe(rsItem("Nghiviec"), 0)
                            End If

                            thangnghi = IIf(dNgaynghi.Year = 1900, 0, dNgaynghi.Month)
                            Ngaynghi = IIf(Nghiviec = 1 AndAlso thangnghi <= dkn, IIf(dNgaynghi.Year = 1900, 0, dNgaynghi.Day), 0)
                            If rsItem("Thaisan") IsNot Nothing Then
                                Thaisan = ConvertToDblSafe(rsItem("Thaisan"), 0)
                            End If
                            If rsItem("tuthang") IsNot Nothing Then
                                tuthang = ConvertToDblSafe(rsItem("tuthang"), 13)
                            End If
                            If rsItem("denthang") IsNot Nothing Then
                                denthang = ConvertToDblSafe(rsItem("denthang"), 13)
                            End If

                            tungay = IIf(Thaisan = 1, IIf(dTungay.Year <> 1900, dTungay.Day, 0), 0)
                            denngay = IIf(Thaisan = 1, IIf(dDenngay.Year <> 1900, dDenngay.Day, 0), 0)
                            tuthangts = IIf(Thaisan = 1, IIf(dTungay.Year <> 1900, dTungay.Month, 0), 0)
                            denthangts = IIf(Thaisan = 1, IIf(dDenngay.Year <> 1900, dDenngay.Month, 0), 0)

                            ngayts = 0
                            co = 0
                            If Thaisan = 1 AndAlso tuthangts <= dkn AndAlso denthangts >= dkn Then
                                If dkn = tuthangts Then
                                    ngayts = tungay
                                    co = 1
                                    For ii As Integer = ngayts - 1 To mangngay(Lich.SelectionStart.Month) - 1
                                        If Label(ii + 1).BackColor = Color.Red Then
                                            mang(ii) = ""
                                        Else
                                            mang(ii) = "s"
                                        End If
                                    Next
                                Else
                                    If dkn = denthangts Then
                                        ngayts = denngay
                                        co = 2
                                        For ii As Integer = 0 To ngayts - 1
                                            If Label(ii + 1).BackColor = Color.Red Then
                                                mang(ii) = ""
                                            Else
                                                mang(ii) = "s"
                                            End If
                                        Next
                                    Else
                                        co = 3
                                        For ii As Integer = 0 To mangngay(Lich.SelectionStart.Month) - 1
                                            If Label(ii + 1).BackColor = Color.Red Then
                                                mang(ii) = ""
                                            Else
                                                mang(ii) = "s"
                                            End If
                                        Next
                                    End If
                                End If
                            Else
                                For ii As Integer = 0 To mangngay(Lich.SelectionStart.Month) - 1
                                    If Label(ii + 1).BackColor = Color.Red Then
                                        mang(ii) = ""
                                    Else
                                        mang(ii) = "c"
                                    End If
                                Next
                            End If

                            If (Nghiviec = 1 AndAlso tuthang <> 0 AndAlso tuthang <= dkn AndAlso (ConvertToDblSafe(rsItem("The")) <> 1 OrElse ConvertToDblSafe(rsItem("Baohiem")) = 1 OrElse (ConvertToDblSafe(rsItem("The")) = 1 AndAlso ConvertToDblSafe(rsItem("Den")) < dkn))) Or (ConvertToDblSafe(rsItem("Tang")) = 1 AndAlso ConvertToDblSafe(rsItem("ThangTang")) > dkn) Then
                                str1 = ""
                                rs1 = Nothing
                                tru += 1
                            Else
                                If Nghiviec = 1 Then

                                    If (((thangnghi < dkn OrElse (Ngaynghi = 1 AndAlso thangnghi = dkn)) AndAlso dNgaynghi.Year = pNamTC) OrElse dNgaynghi.Year < pNamTC) AndAlso ConvertToDblSafe(rsItem("Baohiem")) = 1 Then
                                        str1 = ""
                                        rs1 = Nothing
                                        tru += 1
                                        Continue For
                                    End If
                                End If
                                rs1 = New DataTable
                                str1 = String.Format("SELECT TOP 1 manhanvien,N1, N2, N3, N4, N5, N6, N7, N8, N9, N10, N11, N12, N13, N14, N15, N16, N17, N18, N19, N20, N21, N22, N23, N24, N25, N26, N27, N28, N29, N30, N31, DNBHXH, DNBHYT, DNBHTN, NVBHXH, NVBHYT, NVBHTN FROM chamcong WHERE manhanvien=N'{0}' and thang={1}", _
                                           rsItem("manhanvien"), _
                                           Lich.SelectionStart.Month)
                                rs1 = ExecSQLReturnDT(str1)

                                If rs1.Rows.Count = 0 Then
                                    rs1Item = Nothing
                                    TxtDNXH.Text = 16
                                    TxtDNYT.Text = 3
                                    TxtDNTN.Text = 0
                                    TxtNVXH.Text = 6
                                    TxtNVYT.Text = 1.5
                                    TxtNVTN.Text = 0
                                    str10 = String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}{1}{10}{1}{11}{1}{12}{1}{13}{1}{14}{1}{15}{1}{16}{1}{17}{1}{18}{1}{19}{1}{20}{1}{21}{1}{22}{1}{23}{1}{24}{1}{25}{1}{26}{1}{27}{1}{28}{1}{29}{1}{30}{1}{31}{1}{32}{1}{33}{1}{34}{1}{35}{1}{36}", _
                                                i + 1 - tru, _
                                                Chr(9), _
                                                rsItem("Hoten"), _
                                                rsItem("Bophan"), _
                                                rsItem("Chucvu"), _
                                                mang(0), _
                                                mang(1), _
                                                mang(2), _
                                                mang(3), _
                                                mang(4), _
                                                mang(5), _
                                                mang(6), _
                                                mang(7), _
                                                mang(8), _
                                                mang(9), _
                                                mang(10), _
                                                mang(11), _
                                                mang(12), _
                                                mang(13), _
                                                mang(14), _
                                                mang(15), _
                                                mang(16), _
                                                mang(17), _
                                                mang(18), _
                                                mang(19), _
                                                mang(20), _
                                                mang(21), _
                                                mang(22), _
                                                mang(23), _
                                                mang(24), _
                                                mang(25), _
                                                mang(26), _
                                                mang(27), _
                                                mang(28), _
                                                mang(29), _
                                                mang(30), _
                                                rsItem("manhanvien"))
                                Else
                                    rs1Item = rs1.Rows(0)
                                    If Not IsDBNull(rs1Item("DNBHXH")) Then
                                        TxtDNXH.Text = (rs1Item("DNBHXH"))
                                        TxtDNYT.Text = (rs1Item("DNBHYT"))
                                        TxtDNTN.Text = (rs1Item("dnbhtn"))
                                        TxtNVXH.Text = (rs1Item("nvbhxh"))
                                        TxtNVYT.Text = (rs1Item("nvbhyt"))
                                        TxtNVTN.Text = (rs1Item("NVBHTN"))
                                    Else
                                        TxtDNXH.Text = 0
                                        TxtDNYT.Text = 0
                                        TxtDNTN.Text = 0
                                        TxtNVXH.Text = 0
                                        TxtNVYT.Text = 0
                                        TxtNVTN.Text = 0
                                    End If
                                    If lan = 0 Then
                                        lan += 1
                                        For T As Integer = 1 To DayofMonth(Lich)
                                            tValue = rs1Item(T)
                                            Dim thu As Integer = Weekday(CStr(T) + "/" + CStr(Lich.SelectionStart.Month) + "/" + CStr(Lich.SelectionStart.Year), vbUseSystemDayOfWeek)
                                            If (tValue = "" Or tValue = " t ") And thu > 1 Then
                                                Label(T).BackColor = Color.Blue
                                                Label(T + 40).Visible = True
                                            End If
                                        Next
                                    End If
                                    .Col = .Cols - 1
                                    .CtlText = ConvertToStrSafe(rsItem("SoHieu"))
                                    .Col = 0
                                    .CtlText = ConvertToStrSafe(i + 1)
                                    For j As Integer = 1 To 3
                                        .Col = ConvertToDblSafe(j)
                                        If ConvertToStrSafe(rsItem(j)) <> "" Then .CtlText = rsItem(j)
                                    Next
                                    str10 = String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}{1}{10}{1}{11}{1}{12}{1}{13}{1}{14}{1}{15}{1}{16}{1}{17}{1}{18}{1}{19}{1}{20}{1}{21}{1}{22}{1}{23}{1}{24}{1}{25}{1}{26}{1}{27}{1}{28}{1}{29}{1}{30}{1}{31}{1}{32}{1}{33}{1}{34}{1}{35}{1}{36}", _
                                                i + 1 - tru, _
                                                Chr(9), _
                                                rsItem("Hoten"), _
                                                rsItem("Bophan"), _
                                                rsItem("Chucvu"), _
                                                IIf(IsDBNull(LCase(rs1Item("N1"))), 0, LCase(rs1Item("N1"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N2"))), 0, LCase(rs1Item("N2"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N3"))), 0, LCase(rs1Item("N3"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N4"))), 0, LCase(rs1Item("N4"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N5"))), 0, LCase(rs1Item("N5"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N6"))), 0, LCase(rs1Item("N6"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N7"))), 0, LCase(rs1Item("N7"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N8"))), 0, LCase(rs1Item("N8"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N9"))), 0, LCase(rs1Item("N9"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N10"))), 0, LCase(rs1Item("N10"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N11"))), 0, LCase(rs1Item("N11"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N12"))), 0, LCase(rs1Item("N12"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N13"))), 0, LCase(rs1Item("N13"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N14"))), 0, LCase(rs1Item("N14"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N15"))), 0, LCase(rs1Item("N15"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N16"))), 0, LCase(rs1Item("N16"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N17"))), 0, LCase(rs1Item("N17"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N18"))), 0, LCase(rs1Item("N18"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N19"))), 0, LCase(rs1Item("N19"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N20"))), 0, LCase(rs1Item("N20"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N21"))), 0, LCase(rs1Item("N21"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N22"))), 0, LCase(rs1Item("N22"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N23"))), 0, LCase(rs1Item("N23"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N24"))), 0, LCase(rs1Item("N24"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N25"))), 0, LCase(rs1Item("N25"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N26"))), 0, LCase(rs1Item("N26"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N27"))), 0, LCase(rs1Item("N27"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N28"))), 0, LCase(rs1Item("N28"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N29"))), 0, LCase(rs1Item("N29"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N30"))), 0, LCase(rs1Item("N30"))), _
                                                IIf(IsDBNull(LCase(rs1Item("N31"))), 0, LCase(rs1Item("N31"))), _
                                                rsItem("manhanvien"))
                                End If
                                .AddItem(str10)
                            End If
                        Next
                    End With
                End If
            End If
        Catch ex As Exception
            ColumnSetUp(GrdNhanvien, GrdNhanvien.Cols - 1, 1, 0)
            rs = Nothing
            Me.Cursor = Cursors.Default
            GrdNhanvien.Row = 0
            Dim LCB1, LCB2 As Double
            Dim KqLuong As String = String.Empty
            LCB1 = ConvertToDblSafe(GetSelectValue(String.Format("SELECT luongcb as f1 FROM thongsoluong WHERE luongcb<>0 and thang={0}", Lich.SelectionStart.Month)))
            LCB2 = ConvertToDblSafe(GetSelectValue("SELECT lcb as f1 FROM license"))
            KqLuong = Format(IIf(LCB1 <> 0, LCB1, LCB2), Mask_0)
            Label(37).Text = String.Format(Ngonngu("Lương tối thiểu : {0} đ", "Basic salary : {0} vnd"), (IIf(KqLuong <> "", KqLuong, 0)))
        Finally
            rs = Nothing
            Me.Cursor = Cursors.Default
            GrdNhanvien.Row = 0
            Dim LCB1, LCB2, LCB3, LCB4 As Double
            Dim KqLuong As String = String.Empty
            'Hien thi luong co ban
            LCB1 = ConvertToDblSafe(GetSelectValue(String.Format("SELECT luongcb as f1 FROM thongsoluong WHERE luongcb<>0 and thang={0}", Lich.SelectionStart.Month)))
            LCB2 = ConvertToDblSafe(GetSelectValue("SELECT lcb as f1 FROM license"))
            KqLuong = Format(IIf(LCB1 <> 0, LCB1, LCB2), Mask_0)
            Label(37).Text = String.Format(Ngonngu("Lương tối thiểu : {0} đ", "Basic salary : {0} vnd"), (IIf(KqLuong <> "", KqLuong, 0)))
            'Hien thi thue thu nhap ca nhan
            LCB1 = ConvertToDblSafe(GetSelectValue(String.Format("SELECT tncn as f1, giacanh as f2 FROM Chamcong WHERE (tncn<>0 or giacanh<>0) and thang={0}", Lich.SelectionStart.Month), LCB3))
            LCB2 = ConvertToDblSafe(GetSelectValue("SELECT tncn as f1, giacanh as f2 FROM license", LCB4))
            TxtTNCN.Text = Format(IIf(LCB1 <> 0, LCB1, LCB2), Mask_0)
            If (TxtTNCN.Text = String.Empty) Then
                TxtTNCN.Text = "0"
            End If
            TxtGiaCanh.Text = Format(IIf(LCB3 <> 0, LCB3, LCB4), Mask_0)
            If (TxtGiaCanh.Text = String.Empty) Then
                TxtGiaCanh.Text = "0"
            End If

            GrdNhanvien.EndUpdate()
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmChamcong_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
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
        If formInitComplete And GrdNhanvien.Row < GrdNhanvien.Rows Then
            Dim i As String = ConvertToStrSafe(GrdNhanvien.Col - 3)
            Dim j As Integer = GrdNhanvien.Col
            GrdNhanvien.Col = ConvertToDblSafe(GrdNhanvien.Cols - 1)
            Dim s As String = Nothing

            Try
                s = GrdNhanvien.Items(GrdNhanvien.Row).SubItems(GrdNhanvien.Col).Text
                Label(36).Text = Timten("ten", s, "sohieu", "quanlynhanvien")

                GrdNhanvien.Col = j
                If ColorTranslator.ToOle(Label(ConvertToDblSafe(i)).BackColor) = mau Then
                    If GrdNhanvien.CtlText = "l" Then
                        GrdNhanvien.CtlText = "c"
                        GrdNhanvien.Items(GrdNhanvien.FocusedItem().Index).Selected = True
                    ElseIf GrdNhanvien.CtlText = "c" Then
                        GrdNhanvien.CtlText = "v"
                        GrdNhanvien.Items(GrdNhanvien.FocusedItem().Index).Selected = True
                    ElseIf GrdNhanvien.CtlText = "v" Then
                        GrdNhanvien.CtlText = "p"
                        GrdNhanvien.Items(GrdNhanvien.FocusedItem().Index).Selected = True
                    ElseIf GrdNhanvien.CtlText = "p" Then
                        GrdNhanvien.CtlText = "r"
                        GrdNhanvien.Items(GrdNhanvien.FocusedItem().Index).Selected = True
                    ElseIf GrdNhanvien.CtlText = "r" Then
                        GrdNhanvien.CtlText = "l"
                        GrdNhanvien.Items(GrdNhanvien.FocusedItem().Index).Selected = True
                    End If
                Else
                    If GrdNhanvien.CtlText = "" Then
                        If Label(ConvertToDblSafe(i)).BackColor.Equals(Color.Red) Then
                            GrdNhanvien.CtlText = "t"
                            GrdNhanvien.Items(GrdNhanvien.FocusedItem().Index).Selected = True
                        Else
                            GrdNhanvien.CtlText = " t "
                            GrdNhanvien.Items(GrdNhanvien.FocusedItem().Index).Selected = True
                        End If
                    Else
                        If GrdNhanvien.CtlText <> "" And GrdNhanvien.CtlText <> "n" And GrdNhanvien.CtlText <> "s" Then
                            GrdNhanvien.CtlText = Timten("ten", s, "maso", "quanlynhanvien")
                            GrdNhanvien.Items(GrdNhanvien.FocusedItem().Index).Selected = True
                        End If
                    End If
                End If
            Catch
            End Try
        End If
    End Sub
    Private Sub GrdNhanvien_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrdNhanvien.DoubleClick
        Try
            Dim i As String = ConvertToStrSafe(GrdNhanvien.Col - 3)
            Dim j As Integer = GrdNhanvien.Col
            SetGridIndex(GrdNhanvien, GrdNhanvien.Row)
            If ColorTranslator.ToOle(Label(ConvertToDblSafe(i)).BackColor) = mau Then
                If GrdNhanvien.CtlText = "" Then
                    GrdNhanvien.CtlText = "c"
                    GrdNhanvien.Items(GrdNhanvien.FocusedItem().Index).Selected = True
                ElseIf GrdNhanvien.CtlText = "c" Then
                    GrdNhanvien.CtlText = "v"
                    GrdNhanvien.Items(GrdNhanvien.FocusedItem().Index).Selected = True
                ElseIf GrdNhanvien.CtlText = "v" Then
                    GrdNhanvien.CtlText = "p"
                    GrdNhanvien.Items(GrdNhanvien.FocusedItem().Index).Selected = True
                ElseIf GrdNhanvien.CtlText = "p" Then
                    GrdNhanvien.CtlText = "r"
                    GrdNhanvien.Items(GrdNhanvien.FocusedItem().Index).Selected = True
                ElseIf GrdNhanvien.CtlText = "r" Then
                    GrdNhanvien.CtlText = "l"
                    GrdNhanvien.Items(GrdNhanvien.FocusedItem().Index).Selected = True
                ElseIf GrdNhanvien.CtlText = "l" Then
                    GrdNhanvien.CtlText = ""
                    GrdNhanvien.Items(GrdNhanvien.FocusedItem().Index).Selected = True
                Else
                    GrdNhanvien.Items(GrdNhanvien.FocusedItem().Index).Selected = True
                End If
            Else
                If GrdNhanvien.CtlText = "" Then
                    If Label(ConvertToDblSafe(i)).BackColor.Equals(Color.Red) Then
                        GrdNhanvien.CtlText = "t"
                        GrdNhanvien.Items(GrdNhanvien.FocusedItem().Index).Selected = True
                    Else
                        GrdNhanvien.CtlText = "t"
                        GrdNhanvien.Items(GrdNhanvien.FocusedItem().Index).Selected = True
                    End If
                Else
                    If GrdNhanvien.CtlText <> "" And GrdNhanvien.CtlText <> "n" And GrdNhanvien.CtlText <> "s" Then
                    End If
                End If
            End If
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Label_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Label_81.Click, _Label_82.Click, _Label_83.Click, _Label_84.Click, _Label_88.Click, _Label_89.Click, _Label_90.Click, _Label_91.Click, _Label_80.Click, _Label_85.Click, _Label_86.Click, _Label_87.Click, _Label_79.Click, _Label_78.Click, _Label_77.Click, _Label_76.Click, _Label_75.Click, _Label_74.Click, _Label_73.Click, _Label_72.Click, _Label_40.Click, _Label_39.Click, _Label_38.Click, _Label_37.Click, _Label_36.Click, _Label_41.Click, _Label_42.Click, _Label_43.Click, _Label_44.Click, _Label_45.Click, _Label_46.Click, _Label_47.Click, _Label_48.Click, _Label_49.Click, _Label_50.Click, _Label_51.Click, _Label_52.Click, _Label_53.Click, _Label_54.Click, _Label_55.Click, _Label_56.Click, _Label_57.Click, _Label_58.Click, _Label_59.Click, _Label_60.Click, _Label_61.Click, _Label_62.Click, _Label_63.Click, _Label_64.Click, _Label_65.Click, _Label_66.Click, _Label_67.Click, _Label_68.Click, _Label_69.Click, _Label_70.Click, _Label_71.Click, _Label_35.Click, _Label_31.Click, _Label_30.Click, _Label_29.Click, _Label_28.Click, _Label_27.Click, _Label_26.Click, _Label_25.Click, _Label_24.Click, _Label_23.Click, _Label_22.Click, _Label_21.Click, _Label_20.Click, _Label_19.Click, _Label_18.Click, _Label_17.Click, _Label_16.Click, _Label_15.Click, _Label_14.Click, _Label_13.Click, _Label_12.Click, _Label_11.Click, _Label_10.Click, _Label_9.Click, _Label_8.Click, _Label_7.Click, _Label_6.Click, _Label_5.Click, _Label_4.Click, _Label_3.Click, _Label_2.Click, _Label_1.Click, _Label_34.Click, _Label_32.Click, _Label_33.Click, _Label_0.Click
        Dim Index As Integer = Array.IndexOf(Label, eventSender)
        Dim co As Integer
        Try
            If Not (Index = 0 Or Index = 32 Or Index = 33 Or Index = 35) Then
                If ColorTranslator.ToOle(Label(Index).BackColor) = mau Then
                    Label(Index + 40).Visible = True
                    Label(Index).BackColor = Color.Blue
                    co = 1
                Else
                    If Label(Index).BackColor.Equals(Color.Blue) Then
                        Label(Index).BackColor = ColorTranslator.FromOle(mau)
                        Label(Index + 40).Visible = False
                        co = 2
                    End If
                End If
                GrdNhanvien.Col = ConvertToDblSafe(Index + 3)
                For i As Integer = 0 To GrdNhanvien.Rows - 1
                    GrdNhanvien.Row = i
                    If co = 1 Then
                        If GrdNhanvien.Items(GrdNhanvien.Row).SubItems(GrdNhanvien.Col).Text <> "n" Or GrdNhanvien.Items(GrdNhanvien.Row).SubItems(GrdNhanvien.Col).Text <> "s" Then GrdNhanvien.Items(GrdNhanvien.Row).SubItems(GrdNhanvien.Col).Text = ""
                    Else
                        If co = 2 Then
                            If GrdNhanvien.Items(GrdNhanvien.Row).SubItems(GrdNhanvien.Col).Text <> "n" Or GrdNhanvien.Items(GrdNhanvien.Row).SubItems(GrdNhanvien.Col).Text <> "s" Then GrdNhanvien.Items(GrdNhanvien.Row).SubItems(GrdNhanvien.Col).Text = "c"
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
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
            If GrdNhanvien.CtlText = "c" Then GrdNhanvien.CtlText = ""
        Next
        GrdNhanvien.Row = ConvertToDblSafe(j)
        GrdNhanvien.Col = ConvertToDblSafe(k)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="bp1"></param>
    ''' <param name="bp2"></param>
    ''' <param name="bp3"></param>
    ''' <param name="bp4"></param>
    ''' <remarks></remarks>
    Sub Chiphinhanvien(ByRef bp1 As Integer, ByRef bp2 As Integer, ByRef bp3 As Integer, ByRef bp4 As Integer)
        Dim rs2 As DataTable
        Dim nv1 As New ClsChucDanh
        Dim MaPhanLoai As Integer
        Dim bophan As String = String.Empty
        If bp1 <> 0 Then bophan = String.Format(" and (t2.maphanloai= {0}", bp1)
        If bp2 <> 0 Then
            If bophan = "" Then
                bophan = String.Format(" and (t2.maphanloai= {0}", bp2)
            Else
                bophan = String.Format("{0} or t2.maphanloai= {1}", bophan, ConvertToStrSafe(bp2))
            End If
        End If
        If bp3 <> 0 Then
            If bophan = "" Then
                bophan = String.Format(" and (t2.maphanloai= {0}", bp3)
            Else
                bophan = String.Format("{0} or t2.maphanloai= {1}", bophan, ConvertToStrSafe(bp3))
            End If
        End If
        If bp4 <> 0 Then
            If bophan = "" Then
                bophan = String.Format(" and (t2.maphanloai= {0}", bp4)
            Else
                bophan = String.Format("{0} or t2.maphanloai= {1}", bophan, ConvertToStrSafe(bp4))
            End If
        End If
        If bophan.Length > 0 Then bophan = String.Format("{0})", bophan)
        Dim Chungtu As New ClsChungtu
        Dim kt As Integer
        Dim sohieutk As String = String.Empty
        Dim LN2, LN1, ln As Double
        Dim rs3 As DataTable
        Dim nv As New ClsChucDanh ', LuongTruocBH As Double
        Dim ngaycuathang, thang, dem As Integer
        Dim rs1 As DataTable
        Dim str As String = String.Format("SELECT distinct t4.sohieu as sohieutk,t2.loailuong,t3.ten,t1.ngaycong,t1.luongcb,t1.heso,t1.pccv,t1.pctn,t1.pcld,t1.pck,t1.thuong,t1.congkhac,t1.bhxh,t1.bhyt,t1.tamung,t1.trukhac,t1.nghi,t1.phep,t1.tangca,t1.com,t1.demcu,t1.demmoi,t1.tangcagio,t2.sohieu as nhanvien,t1.luong13,t2.maphanloai FROM thongsoluong t1 inner join((quanlynhanvien t2 inner join phanloaiquanlynhanvien t4 on t2.maphanloai=t4.maso) inner join chucvu t3 on t2.machucvu=t3.maso) on t1.sohieunhanvien=t2.sohieu WHERE t1.thang={0}{1} order by t4.sohieu", Lich.SelectionStart.Month, bophan)
        Dim rs As DataTable = ExecSQLReturnDT(str)
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            With Chungtu
                thang = Lich.SelectionStart.Month
                ngaycuathang = DayofMonth(Lich)
                rs1 = ExecSQLReturnDT(String.Format("SELECT MaNhanVien,N1, N2, N3, N4, N5, N6, N7, N8, N9, N10, N11, N12, N13, N14, N15, N16, N17, N18, N19, N20, N21, N22, N23, N24, N25, N26, N27, N28, N29, N30, N31 FROM chamcong WHERE thang={0} order by manhanvien", Lich.SelectionStart.Month))
                Try
                    For Each rs1Item As DataRow In rs1.Rows
                        If dem <> 0 Then
                            Exit For
                        End If
                        For i As Integer = 1 To ngaycuathang
                            Dim currentItem As String = LCase(ConvertToStrSafe(rs1Item(i)).Trim.ToUpper)
                            If currentItem = "p" Or currentItem = "c" Or currentItem = "l" Or currentItem = "r" Or currentItem = "v" Then
                                dem += 1
                            End If
                            If currentItem = "s" Or currentItem = "n" Then
                                dem = 0
                                Exit For
                            End If
                        Next
                    Next
                Catch
                End Try
                .NgayCT = DateSerial(Lich.SelectionStart.Year, thang, ngaycuathang)
                .NgayGS = .NgayCT
                .SoHieu = String.Format("CPNV{0}", IIf(thang < 10, String.Format("0{0}", thang), ConvertToStrSafe(thang)))
                .MaCT = ConvertToDblSafe((ConvertToDblSafe(Timten("mact", .SoHieu, "sohieu", "chungtu"))))
                If .MaCT = 0 Then
                    .MaCT = Lng_MaxValue("MaCT", "ChungTu") + 1
                End If
                .maloai = 0
                .thangct = thang
                .DienGiai = String.Format("Chi phí nhân viên tháng {0}", (IIf(thang < 10, String.Format("0{0}", thang), ConvertToStrSafe(thang))))
                .MaDT = 1
                .CTGS = 1
                kt = SoHieu2MaSo(ConvertToStrSafe(rsItem(0)), "hethongtk")
                If rsItem("MaPhanLoai") IsNot Nothing Then
                    MaPhanLoai = ConvertToStrSafe(rsItem("MaPhanLoai"))
                End If

                .TkCo.maso = kt
                .TkCo.MaTC = kt
                sohieutk = ConvertToStrSafe(rsItem("sohieutk"))

                'Xac dinh tai khoan chi phi
                .tkno.InitTaikhoanSohieu(Timten("matk", sohieutk, "sohieu", "Phanloaiquanlynhanvien"))
                If kt = 0 Then
                    MessageBox.Show(Ngonngu("Thiếu tài khoản ", "Major account ") + CStr(rsItem(0)) + " !", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : GoTo Loi
                End If
                If .tkno.sohieu Like "1542*" Or .tkno.sohieu Like "622*" Then
                    If ChkBaohiem.CheckState = CheckState.Unchecked Then
                        If MessageBox.Show(Ngonngu("Tháng này có phát sinh công trình sản phẩm không?", "Arise in the months building this product?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                            macongtrinh = Timten("maso", FrmGetStr.GetString(Ngonngu("Lô sản xuất:", "Production batch"), My.Application.Info.ProductName), "sohieu", "TP154")
                            If macongtrinh <> "" Then .MaTP = ConvertToDblSafe(macongtrinh)
                            congtrinh = 1
                        Else
                            Taikhoanthay = Timten("maso", taikhoanconnhat(FrmGetStr.GetString(Ngonngu("Tài khoản nợ ( 1541,6411, 6421, ...)", "Debt account (1541, 6411, 6421 ...)"), My.Application.Info.ProductName)), "sohieu", "hethongtk")
                            If Taikhoanthay <> "" Then .tkno.maso = ConvertToDblSafe(Taikhoanthay)
                        End If
                    Else
                        If congtrinh = 0 And Taikhoanthay = "" Then Taikhoanthay = Timten("maso", taikhoanconnhat(FrmGetStr.GetString(Ngonngu("Tài khoản nợ ( 1541,6411, 6421, ...)", "Debt account (1541, 6411, 6421 ...)"), My.Application.Info.ProductName)), "sohieu", "hethongtk")
                        If Taikhoanthay <> "" Then
                            .tkno.maso = ConvertToDblSafe(Taikhoanthay)
                        Else
                            If .tkno.maso = 0 Then
                                MessageBox.Show(Ngonngu("Thiếu tài khoản ", "Major account ") + CStr(Timten("matk", sohieutk, "sohieu", "Phanloaiquanlynhanvien")) + " !", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : GoTo Loi
                            End If
                        End If
                        If congtrinh = 1 And macongtrinh = "" Then macongtrinh = Timten("maso", FrmGetStr.GetString(Ngonngu("Lô sản xuất:", "Production batch:"), My.Application.Info.ProductName), "sohieu", "TP154")
                    End If
                    .tkno.MaTC = .tkno.maso
                    If macongtrinh <> "" Then .MaTP = ConvertToDblSafe(macongtrinh)
                End If
            End With
        End If
        Dim dem1, dem2 As Integer
        Dim kt1 As Integer
        Dim LCB As Double
        For Each rsItem As DataRow In rs.Rows
            kt1 = SoHieu2MaSo(ConvertToStrSafe(rsItem(0)), "hethongtk")
            If rsItem("luongcb") IsNot Nothing Then
                LCB = ConvertToStrSafe(rsItem("luongcb"))
            End If

            With Chungtu
                nv.InitMaSo(ConvertToDblSafe(GetSelectValue(String.Format("SELECT maso as f1 FROM chucdanh WHERE nhanvien=N'{0}' and (nam<{1} or (nam={1} and thang<={2})) order by nam desc, thang desc", _
                                                                rsItem("Nhanvien"), _
                                                                frmMain._LbCty_7.Text, _
                                                                thang))))
                If nv.maso = 0 Then
                    LN1 = 0
                Else
                    LN1 = FrmChamconggio.Luonggio(nv, Lich) * 8
                End If
                nv.InitMaSo(ConvertToDblSafe(GetSelectValue(String.Format("SELECT maso as f1 FROM chucdanh WHERE nhanvien=N'{0}' and nam={1} and thang={2} order by nam desc, thang desc", _
                                                                rsItem("Nhanvien"), _
                                                                frmMain._LbCty_7.Text, _
                                                                thang))))
                If nv.maso <> 0 Then
                    LN2 = FrmChamconggio.Luonggio(nv, Lich) * 8
                    rs3 = ExecSQLReturnDT(String.Format("SELECT MaNhanVien,N1, N2, N3, N4, N5, N6, N7, N8, N9, N10, N11, N12, N13, N14, N15, N16, N17, N18, N19, N20, N21, N22, N23, N24, N25, N26, N27, N28, N29, N30, N31 FROM chamcong WHERE thang={0} order by manhanvien", thang))
                    Dim processRowCount As Integer = 0
                    For Each rs3Item As DataRow In rs3.Rows
                        If dem1 <> 0 Then
                            Exit For
                        End If
                        If DateAndTime.Day(nv.NgayApdung) = 1 Then Exit For
                        For j As Integer = 1 To nv.NgayApdung.Day - 1
                            Dim currentItem As String = LCase(ConvertToStrSafe(rs3Item(j)).Trim.ToUpper)
                            If currentItem = "p" Or currentItem = "c" Or currentItem = "l" Or currentItem = "r" Or currentItem = "v" Then
                                dem1 += 1
                            End If
                            If currentItem = "s" Or currentItem = "n" Then
                                dem1 = 0
                                Exit For
                            End If
                        Next
                        processRowCount += 1
                    Next
                    If processRowCount >= (rs3.Rows.Count - 1) Then
                        processRowCount -= 1
                        If processRowCount < 0 Then
                            processRowCount = 0
                        End If
                    End If
                    For k As Integer = processRowCount To (rs3.Rows.Count - 1)
                        If dem2 <> 0 Then
                            Exit For
                        End If
                        Dim rs3Item As DataRow = rs3.Rows(k)
                        For j As Integer = nv.NgayApdung.Day To DayofMonth(Lich)
                            Dim currentItem As String = LCase(ConvertToStrSafe(rs3Item(j)).Trim.ToUpper)
                            If currentItem = "p" Or currentItem = "c" Or currentItem = "l" Or currentItem = "r" Or currentItem = "v" Then
                                dem2 += 1
                            End If
                            If currentItem = "s" Or currentItem = "n" Then
                                dem2 = 0
                                Exit For
                            End If
                        Next
                    Next
                    ln = (LN1 * dem1 + LN2 * dem2) / (dem1 + dem2)
                Else
                    ln = LN1
                End If
                If kt <> kt1 Then
                    If Chk.CheckState = CheckState.Checked Then
                        rs2 = ExecSQLReturnDT(String.Format("SELECT * FROM quanlynhanvien WHERE thaisan=1 and month(tungay)<={0} and month(denngay)>={1} and maphanloai={2}", _
                                                  thang, _
                                                  thang, _
                                                  MaPhanLoai))
                        For Each rs2Item As DataRow In rs2.Rows
                            nv1.InitMaSo(ConvertToDblSafe(GetSelectValue(String.Format("SELECT maso as f1 FROM chucdanh WHERE nhanvien=N'{0}' and (nam<{1} or (nam={1} and thang<{2}))) order by nam desc, thang desc", _
                                                                             rs2Item("SoHieu"), _
                                                                             pNamTC, _
                                                                             thang))))
                            .sops += FrmChamconggio.Luongthang(nv1) * nv1.thang13 / 100 * ConvertToDblSafe(Luong13.Text) / 100
                        Next
                    End If
                    .GhiChungtu()
                    .MaTP = 0
                    kt = kt1
                    If rsItem("MaPhanLoai") IsNot Nothing Then
                        MaPhanLoai = ConvertToDblSafe(rsItem("MaPhanLoai"))
                    End If

                    .TkCo.maso = kt
                    .TkCo.MaTC = kt
                    If rsItem("sohieutk") IsNot Nothing Then
                        sohieutk = ConvertToStrSafe(rsItem("sohieutk"))
                    End If

                    'Xac dinh tai khoan chi phi
                    .tkno.InitTaikhoanSohieu(Timten("matk", sohieutk, "sohieu", "Phanloaiquanlynhanvien"))
                    If kt = 0 Then
                        MessageBox.Show(Ngonngu("Thiếu tài khoản ", "Major account ") + CStr(rsItem(0)) + " !", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : GoTo Loi
                    End If
                    If .tkno.sohieu Like "1542*" Or .tkno.sohieu Like "622*" Then
                        If ChkBaohiem.CheckState = CheckState.Unchecked Then
                            If MessageBox.Show(Ngonngu("Tháng này có phát sinh công trình sản phẩm không?", "Arise in the month building this product?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                                macongtrinh = Timten("maso", FrmGetStr.GetString(Ngonngu("Lô sản xuất:", "Production batch:"), My.Application.Info.ProductName), "sohieu", "TP154")
                                If macongtrinh <> "" Then .MaTP = ConvertToDblSafe(macongtrinh)
                                congtrinh = 1
                            Else
                                Taikhoanthay = Timten("maso", taikhoanconnhat(FrmGetStr.GetString(Ngonngu("Tài khoản nợ (1541, 6411, 6421, ...)", "Debt account (1541, 6411, 6421, ...)"), My.Application.Info.ProductName)), "sohieu", "hethongtk")
                                If Taikhoanthay <> "" Then .tkno.maso = ConvertToDblSafe(Taikhoanthay)
                            End If
                        Else
                            If congtrinh = 0 And Taikhoanthay = "" Then Taikhoanthay = Timten("maso", taikhoanconnhat(FrmGetStr.GetString(Ngonngu("Tài khoản nợ (1541, 6411, 6421, ...)", "Debt account (1541, 6411, 6421, ...)"), My.Application.Info.ProductName)), "sohieu", "hethongtk")
                            If Taikhoanthay <> "" Then
                                .tkno.maso = ConvertToDblSafe(Taikhoanthay)
                            Else
                                If .tkno.maso = 0 Then
                                    MessageBox.Show(Ngonngu("Thiếu tài khoản ", "Major account ") + CStr(Timten("matk", sohieutk, "sohieu", "Phanloaiquanlynhanvien")) + " !", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : GoTo Loi
                                End If
                            End If
                            If congtrinh = 1 And macongtrinh = "" Then macongtrinh = Timten("maso", FrmGetStr.GetString(Ngonngu("Lô sản xuất:", "Production batch: "), My.Application.Info.ProductName), "sohieu", "TP154")
                        End If
                        .tkno.MaTC = .tkno.maso
                        If macongtrinh <> "" Then .MaTP = ConvertToDblSafe(macongtrinh)
                    End If
                    '****************************** Tang luong **********************************************************
                    .sops = Math.Round(ConvertToDblSafe(IIf(ConvertToDblSafe(rsItem("Luong13")) <> 0, ln * ConvertToDblSafe(rsItem("Ngaycong")) * ConvertToDblSafe(rsItem("Luong13")) / 100, 0)) + ln * ConvertToDblSafe(rsItem("Ngaycong") + ConvertToDblSafe(rsItem("Phep")) + ConvertToDblSafe(rsItem("Tangca"))) + ConvertToDblSafe(rsItem("PCCV")) + ConvertToDblSafe(rsItem("PCTN")) + ConvertToDblSafe(rsItem("PCLD")) + ConvertToDblSafe(rsItem("PCK")) + ConvertToDblSafe(rsItem("thuong")) + ConvertToDblSafe(rsItem("congkhac")) + ConvertToDblSafe(rsItem("Com")) + IIf(IsDBNull(rsItem("tangcagio")), 0, ConvertToDblSafe(rsItem("tangcagio"))), 0)
                Else
                    .sops += Math.Round(ConvertToDblSafe(IIf(ConvertToDblSafe(rsItem("Luong13")) <> 0, ln * ConvertToDblSafe(rsItem("Ngaycong")) * ConvertToDblSafe(rsItem("Luong13")) / 100, 0)) + ln * (ConvertToDblSafe(rsItem("Ngaycong")) + ConvertToDblSafe(rsItem("Phep")) + ConvertToDblSafe(rsItem("Tangca"))) + ConvertToDblSafe(rsItem("PCCV")) + ConvertToDblSafe(rsItem("PCTN")) + ConvertToDblSafe(rsItem("PCLD")) + ConvertToDblSafe(rsItem("PCK")) + ConvertToDblSafe(rsItem("thuong")) + ConvertToDblSafe(rsItem("congkhac")) + ConvertToDblSafe(rsItem("Com")) + IIf(IsDBNull(ConvertToDblSafe(rsItem("tangcagio"))), 0, ConvertToDblSafe(rsItem("tangcagio"))), 0)
                End If
            End With
        Next
        If rs.Rows.Count <> 0 Then Chungtu.GhiChungtu()
        Exit Sub
Loi:
        Loitrichluong = 1
        ExecSQLNonQuery(String.Format("DELETE  FROM chungtu WHERE sohieu = 'CPNV{0}'", (IIf(thang < 10, String.Format("0{0}", thang), ConvertToStrSafe(thang)))))
    End Sub
    Sub TrichBaohiemDN(ByRef bp1 As Integer, ByRef bp2 As Integer, ByRef bp3 As Integer, ByRef bp4 As Integer)
        Dim BHYT, BHXH, BHTN As Double
        Dim ThangTangbh, Tangbh, thang, denthang, tuthang, Thaisan As Integer
        Dim bophan As String = String.Empty
        If bp1 <> 0 Then bophan = String.Format(" and (t2.maphanloai= {0}", bp1)
        If bp2 <> 0 Then
            If bophan = "" Then
                bophan = String.Format(" and (t2.maphanloai= {0}", bp2)
            Else
                bophan = String.Format("{0} or t2.maphanloai= {1}", bophan, ConvertToStrSafe(bp2))
            End If
        End If
        If bp3 <> 0 Then
            If bophan = "" Then
                bophan = String.Format(" and (t2.maphanloai= {0}", bp3)
            Else
                bophan = String.Format("{0} or t2.maphanloai= {1}", bophan, ConvertToStrSafe(bp3))
            End If
        End If
        If bp4 <> 0 Then
            If bophan = "" Then
                bophan = String.Format(" and (t2.maphanloai= {0}", bp4)
            Else
                bophan = String.Format("{0} or t2.maphanloai= {1}", bophan, ConvertToStrSafe(bp4))
            End If
        End If
        If bophan.Length > 0 Then bophan = String.Format("{0})", bophan)
        Dim str As String = String.Format("SELECT distinct t4.sohieu as sohieutk,t1.bhxh,t1.bhyt,t1.bhtn,t1.demcu,t1.demmoi,t1.tangcagio,t2.sohieu as nhanvien,t2.baohiem,t2.tangbh,t2.thangtangbh,t2.nghiviec,t2.tuthang,t2.denthang,t2.thaisan FROM thongsoluong t1 inner join((quanlynhanvien t2 inner join phanloaiquanlynhanvien t4 on t2.maphanloai=t4.maso) inner join chucvu t3 on t2.machucvu=t3.maso) on t1.sohieunhanvien=t2.sohieu WHERE t1.thang={0}{1} order by t4.sohieu,t2.sohieu", Lich.SelectionStart.Month, bophan)
        Dim rs As DataTable = ExecSQLReturnDT(str)
        Dim Chungtu As New ClsChungtu
        Dim kt As Integer
        Dim sohieutk As String = String.Empty
        Dim masoco, LN2, LN1, ln As Double
        Dim rs3 As DataTable
        Dim nv As New ClsChucDanh
        Dim LuongTruocBH As Double
        Dim ngaycuathang, dem As Integer
        Dim rs1 As DataTable
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            With Chungtu
                thang = Lich.SelectionStart.Month
                ngaycuathang = DayofMonth(Lich)
                rs1 = ExecSQLReturnDT(String.Format("SELECT MaNhanVien,N1, N2, N3, N4, N5, N6, N7, N8, N9, N10, N11, N12, N13, N14, N15, N16, N17, N18, N19, N20, N21, N22, N23, N24, N25, N26, N27, N28, N29, N30, N31 FROM chamcong WHERE thang={0} order by manhanvien", Lich.SelectionStart.Month))
                Try
                    For Each rs1Item As DataRow In rs1.Rows
                        If dem <> 0 Then
                            Exit For
                        End If
                        For i As Integer = 1 To ngaycuathang
                            Dim currentItem As String = LCase(ConvertToStrSafe(rs1Item(i)).Trim)
                            If currentItem = "p" Or currentItem = "c" Or currentItem = "l" Or currentItem = "r" Or currentItem = "v" Then
                                dem += 1
                            End If
                            If currentItem = "s" Or currentItem = "n" Then
                                dem = 0
                                Exit For
                            End If
                        Next
                    Next
                Catch
                End Try
                .NgayCT = DateSerial(Lich.SelectionStart.Year, thang, ngaycuathang)
                .NgayGS = .NgayCT
                .SoHieu = String.Format("BHDN{0}", (IIf(thang < 10, String.Format("0{0}", thang), ConvertToStrSafe(thang))))
                .MaCT = ConvertToDblSafe((ConvertToDblSafe(Timten("mact", .SoHieu, "sohieu", "chungtu"))))
                If .MaCT = 0 Then .MaCT = Lng_MaxValue("MaCT", "ChungTu") + 1
                .maloai = 0
                .thangct = thang
                .DienGiai = String.Format("Trích BHXH ({0}%) , BHYT ({1}%){2} tháng {3}", TxtDNXH.Text, TxtDNYT.Text, (IIf(ConvertToDblSafe(TxtDNTN.Text) <> 0, String.Format(" và BHTN ({0}%)", TxtDNTN.Text), String.Empty)), (IIf(thang < 10, String.Format("0{0}", thang), ConvertToStrSafe(thang))))
                .MaDT = 1
                .CTGS = 1
                kt = SoHieu2MaSo(ConvertToStrSafe(rsItem(0)), "hethongtk")
                sohieutk = ConvertToStrSafe(rsItem("sohieutk"))
            End With
        End If
        Dim kt1 As Integer
        Dim dem1, dem2 As Integer
        For Each rsItem As DataRow In rs.Rows
            kt1 = SoHieu2MaSo(ConvertToStrSafe(rsItem(0)), "hethongtk")
            Tangbh = 0
            ThangTangbh = 0
            If Not IsDBNull(ConvertToStrSafe(rsItem("Tangbh"))) Then
                If ConvertToStrSafe(rsItem("Tangbh")) <> 0 Then
                    If rsItem("Tangbh") IsNot Nothing Then
                        Tangbh = ConvertToDblSafe(rsItem("Tangbh"))
                    End If
                    If rsItem("ThangTangbh") IsNot Nothing Then
                        ThangTangbh = ConvertToDblSafe(rsItem("ThangTangbh"))
                    End If
                End If
            End If
            Thaisan = IIf(ConvertToStrSafe(rsItem("Thaisan")) <> "", ConvertToDblSafe(rsItem("Thaisan")), 0)
            Try
                tuthang = IIf(ConvertToStrSafe(rsItem("tuthang")) <> 0, ConvertToDblSafe(rsItem("tuthang")), 13)
                denthang = IIf(ConvertToStrSafe(rsItem("denthang")) <> 0, ConvertToDblSafe(rsItem("denthang")), 13)
            Catch ex As Exception
                tuthang = 13
                denthang = 13
            End Try
            Try
                With Chungtu
                    nv.InitMaSo(ConvertToDblSafe(GetSelectValue(String.Format("SELECT maso AS f1 FROM chucdanh WHERE nhanvien=N'{0}' and (nam<{1} or (nam={1} and thang<={2})) order by nam desc, thang desc", _
                                                                    ConvertToStrSafe(rsItem("Nhanvien")), _
                                                                    frmMain._LbCty_7.Text, _
                                                                    ConvertToStrSafe(thang)))))
                    If nv.maso = 0 Then
                        LN1 = 0
                    Else
                        LN1 = FrmChamconggio.Luonggio(nv, Lich) * 8
                    End If
                    nv.InitMaSo(ConvertToDblSafe(GetSelectValue(String.Format("SELECT maso as f1 FROM chucdanh WHERE nhanvien=N'{0}' and nam={1} and thang={2} order by nam desc, thang desc", _
                                                                    ConvertToStrSafe(rsItem("Nhanvien")), _
                                                                    frmMain._LbCty_7.Text, _
                                                                    ConvertToStrSafe(thang)))))
                    If nv.maso <> 0 Then
                        LN2 = FrmChamconggio.Luonggio(nv, Lich) * 8
                        rs3 = ExecSQLReturnDT(String.Format("SELECT MaNhanVien,N1, N2, N3, N4, N5, N6, N7, N8, N9, N10, N11, N12, N13, N14, N15, N16, N17, N18, N19, N20, N21, N22, N23, N24, N25, N26, N27, N28, N29, N30, N31 FROM chamcong WHERE thang={0} order by manhanvien", thang))
                        Dim processRowCount As Integer = 0
                        For Each rs3Item As DataRow In rs3.Rows
                            If dem1 <> 0 Then
                                Exit For
                            End If
                            If DateAndTime.Day(nv.NgayApdung) = 1 Then Exit For
                            For j As Integer = 1 To nv.NgayApdung.Day - 1
                                Dim currentItem As String = ConvertToStrSafe(rs3Item(j)).Trim.ToLower
                                If currentItem = "p" Or currentItem = "c" Or currentItem = "l" Or currentItem = "r" Or currentItem = "v" Then
                                    dem1 += 1
                                End If
                                If currentItem = "s" Or currentItem = "n" Then
                                    dem1 = 0
                                    Exit For
                                End If
                            Next
                            processRowCount += 1
                        Next
                        If processRowCount >= (rs3.Rows.Count - 1) Then
                            processRowCount -= 1
                            If processRowCount < 0 Then
                                processRowCount = 0
                            End If
                        End If
                        For k As Integer = processRowCount To (rs3.Rows.Count - 1)
                            If dem2 <> 0 Then
                                Exit For
                            End If
                            Dim rs3Item As DataRow = rs3.Rows(k)
                            For j As Integer = nv.NgayApdung.Day To DayofMonth(Lich)
                                Dim currentItem As String = ConvertToStrSafe(rs3Item(j)).Trim.ToLower
                                If currentItem = "p" Or currentItem = "c" Or currentItem = "l" Or currentItem = "r" Or currentItem = "v" Then
                                    dem2 += 1
                                End If
                                If currentItem = "s" Or currentItem = "n" Then
                                    dem2 = 0
                                    Exit For
                                End If
                            Next
                        Next
                        ln = (LN1 * dem1 + LN2 * dem2) / (dem1 + dem2)
                    Else
                        ln = LN1
                    End If
                    LuongTruocBH = Math.Round(ConvertToDblSafe(ln * (IIf(dem2 = 0, dem, (dem1 + dem2)))), 0)
                    If kt <> kt1 Then
                        kt = kt1
                        'Xac dinh tai khoan chi phi
                        .tkno.InitTaikhoanSohieu(Timten("matk", sohieutk, "sohieu", "Phanloaiquanlynhanvien"))
                        If .tkno.sohieu Like "1542*" Or .tkno.sohieu Like "622*" Then
                            If MessageBox.Show(Ngonngu("Tháng này có phát sinh công trình sản phẩm không?", "Arise in the months building this product?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                                macongtrinh = Timten("maso", FrmGetStr.GetString(Ngonngu("Lô sản xuất:", "Production bactch:"), My.Application.Info.ProductName), "sohieu", "TP154")
                                If macongtrinh <> "" Then .MaTP = ConvertToDblSafe(macongtrinh)
                                congtrinh = 1
                            Else
                                Taikhoanthay = Timten("maso", taikhoanconnhat(FrmGetStr.GetString(Ngonngu("Tài khoản nợ (1541, 6411, 6421, ...)", "Debt account (1541, 6411, 6421, ...)"), My.Application.Info.ProductName)), "sohieu", "hethongtk")
                                If Taikhoanthay <> "" Then .tkno.maso = ConvertToDblSafe(Taikhoanthay)
                            End If
                            .tkno.MaTC = .tkno.maso
                        End If
                        sohieutk = ConvertToStrSafe(rsItem("sohieutk"))
                        If BHXH <> 0 Then
                            masoco = ConvertToDblSafe(Timten("maso", taikhoanconnhat("3383"), "sohieu", "hethongtk"))
                            .TkCo.maso = ConvertToDblSafe(masoco)
                            .TkCo.MaTC = ConvertToDblSafe(masoco)
                            .sops = Math.Round(ConvertToDblSafe(BHXH))
                            .GhiChungtu()
                            BHXH = 0
                        End If
                        If BHTN <> 0 Then
                            masoco = ConvertToDblSafe(Timten("maso", taikhoanconnhat("3389"), "sohieu", "hethongtk"))
                            If masoco = 0 Then
                                MessageBox.Show(Ngonngu("Thiếu tài khoản 3389 !", "Major account 3389 !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Loitrichluong = 2
                                ExecSQLNonQuery(String.Format("DELETE  FROM chungtu WHERE sohieu = 'BHDN{0}'", IIf(thang < 10, String.Format("0{0}", thang), thang)))
                                Exit Sub
                            End If
                            .TkCo.maso = ConvertToDblSafe(masoco)
                            .TkCo.MaTC = ConvertToDblSafe(masoco)
                            .sops = Math.Round(ConvertToDblSafe(BHTN))
                            .GhiChungtu()
                            BHTN = 0
                        End If
                        If BHYT <> 0 Then
                            masoco = ConvertToDblSafe(Timten("maso", taikhoanconnhat("3384"), "sohieu", "hethongtk"))
                            .TkCo.maso = ConvertToDblSafe(masoco)
                            .TkCo.MaTC = ConvertToDblSafe(masoco)
                            .sops = Math.Round(ConvertToDblSafe(BHYT))
                            .GhiChungtu()
                            BHYT = 0
                        End If
                        If ConvertToStrSafe(rsItem("Baohiem")) = 0 Or (Tangbh = 1 And ThangTangbh <= thang) Then
                            If ChkBaohiem.CheckState Then
                                BHYT = LuongTruocBH * ConvertToDblSafe(TxtDNYT.Text) / 100
                                If Not ((Thaisan = 1 And thang >= tuthang And thang <= denthang) Or (ConvertToStrSafe(rsItem("Nghiviec")) = 1 And thang >= tuthang)) Then
                                    BHXH = LuongTruocBH * ConvertToDblSafe(TxtDNXH.Text) / 100
                                    BHTN = LuongTruocBH * ConvertToDblSafe(TxtDNTN.Text) / 100
                                End If
                            End If
                        End If
                    Else
                        If ConvertToStrSafe(rsItem("Baohiem")) = 0 Or (Tangbh = 1 And ThangTangbh <= thang) Then
                            If ChkBaohiem.CheckState Then
                                BHYT += LuongTruocBH * ConvertToDblSafe(TxtDNYT.Text) / 100
                                If Not ((Thaisan = 1 And thang >= tuthang And thang <= denthang) Or (ConvertToStrSafe(rsItem("Nghiviec")) = 1 And thang >= tuthang)) Then
                                    BHXH += LuongTruocBH * ConvertToDblSafe(TxtDNXH.Text) / 100
                                    BHTN += LuongTruocBH * ConvertToDblSafe(TxtDNTN.Text) / 100
                                End If
                            End If
                        End If
                    End If
                End With
            Catch ex As Exception
                Loitrichluong = 2
                ExecSQLNonQuery(String.Format("DELETE  FROM chungtu WHERE sohieu = 'BHDN{0}'", IIf(thang < 10, String.Format("0{0}", thang), thang)))
                Exit Sub
            End Try
        Next
        If rs.Rows.Count <> 0 Then
            With Chungtu
                'Xac dinh tai khoan chi phi
                .tkno.InitTaikhoanSohieu(Timten("matk", sohieutk, "sohieu", "Phanloaiquanlynhanvien"))
                If .tkno.sohieu Like "1542*" Or .tkno.sohieu Like "622*" Then
                    If MessageBox.Show(Ngonngu("Tháng này có phát sinh công trình sản phẩm không?", "Arise in the months building this product?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                        macongtrinh = Timten("maso", FrmGetStr.GetString(Ngonngu("Lô sản xuất:", "Productiong batch"), My.Application.Info.ProductName), "sohieu", "TP154")
                        If macongtrinh <> "" Then .MaTP = ConvertToDblSafe(macongtrinh)
                        congtrinh = 1
                    Else
                        Taikhoanthay = Timten("maso", taikhoanconnhat(FrmGetStr.GetString(Ngonngu("Tài khoản nợ (1541, 6411, 6421, ...)", "Debt account (1541, 6411, 6421, ...)"), My.Application.Info.ProductName)), "sohieu", "hethongtk")
                        If Taikhoanthay <> "" Then .tkno.maso = ConvertToDblSafe(Taikhoanthay)
                    End If
                    .tkno.MaTC = .tkno.maso
                End If
                If BHXH <> 0 Then
                    masoco = ConvertToDblSafe(Timten("maso", taikhoanconnhat("3383"), "sohieu", "hethongtk"))
                    .TkCo.maso = ConvertToDblSafe(masoco)
                    .TkCo.MaTC = ConvertToDblSafe(masoco)
                    .sops = BHXH
                    .GhiChungtu()
                End If
                If BHTN <> 0 Then
                    masoco = ConvertToDblSafe(Timten("maso", taikhoanconnhat("3389"), "sohieu", "hethongtk"))
                    If masoco = 0 Then
                        MessageBox.Show(Ngonngu("Thiếu tài khoản 3389 !", "Major account 3389"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Loitrichluong = 2
                        ExecSQLNonQuery(String.Format("DELETE  FROM chungtu WHERE sohieu = 'BHDN{0}'", IIf(thang < 10, String.Format("0{0}", thang), thang)))
                        Exit Sub
                    End If
                    .TkCo.maso = ConvertToDblSafe(masoco)
                    .TkCo.MaTC = ConvertToDblSafe(masoco)
                    .sops = BHTN
                    .GhiChungtu()
                End If
                If BHYT <> 0 Then
                    masoco = ConvertToDblSafe(Timten("maso", taikhoanconnhat("3384"), "sohieu", "hethongtk"))
                    .TkCo.maso = ConvertToDblSafe(masoco)
                    .TkCo.MaTC = ConvertToDblSafe(masoco)
                    .sops = BHYT
                    .GhiChungtu()
                End If
            End With
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="bp1"></param>
    ''' <param name="bp2"></param>
    ''' <param name="bp3"></param>
    ''' <param name="bp4"></param>
    ''' <remarks></remarks>
    Sub TrichBaohiemNV(ByRef bp1 As Integer, ByRef bp2 As Integer, ByRef bp3 As Integer, ByRef bp4 As Integer)
        Dim BHYT, BHXH, BHTN As Double
        Dim ThangTangbh, Tangbh, thang, tuthang, Thaisan, denthang As Integer
        Dim bophan As String = String.Empty
        If bp1 <> 0 Then bophan = String.Format(" and (t2.maphanloai= {0}", bp1)
        If bp2 <> 0 Then
            If bophan = "" Then
                bophan = String.Format(" and (t2.maphanloai= {0}", bp2)
            Else
                bophan = String.Format("{0} or t2.maphanloai= {1}", bophan, ConvertToStrSafe(bp2))
            End If
        End If
        If bp3 <> 0 Then
            If bophan = "" Then
                bophan = String.Format(" and (t2.maphanloai= {0}", bp3)
            Else
                bophan = String.Format("{0} or t2.maphanloai= {1}", bophan, ConvertToStrSafe(bp3))
            End If
        End If
        If bp4 <> 0 Then
            If bophan = "" Then
                bophan = String.Format(" and (t2.maphanloai= {0}", bp4)
            Else
                bophan = String.Format("{0} or t2.maphanloai= {1}", bophan, ConvertToStrSafe(bp4))
            End If
        End If
        If bophan.Length > 0 Then bophan = String.Format("{0})", bophan)
        Dim str As String = String.Format("SELECT distinct t4.sohieu as sohieutk,t1.bhxh,t1.bhyt,t1.bhtn,t1.demcu,t1.demmoi,t1.tangcagio,t2.sohieu as nhanvien,t2.baohiem,t2.tangbh,t2.thangtangbh,t2.nghiviec,t2.tuthang,t2.denthang,t2.thaisan,t2.tungay,t2.denngay,t2.ngaynghi FROM thongsoluong t1 inner join((quanlynhanvien t2 inner join phanloaiquanlynhanvien t4 on t2.maphanloai=t4.maso) inner join chucvu t3 on t2.machucvu=t3.maso) on t1.sohieunhanvien=t2.sohieu WHERE t1.thang={0}{1} order by t4.sohieu,t2.sohieu", Lich.SelectionStart.Month, bophan)
        Dim rs As DataTable = ExecSQLReturnDT(str)
        Dim Chungtu As New ClsChungtu
        Dim kt As Integer
        Dim masoco, LN2, LN1, ln As Double
        Dim rs3 As DataTable
        Dim nv As New ClsChucDanh
        Dim LuongTruocBH As Double
        Dim ngaycuathang, dem As Integer
        Dim rs1 As DataTable
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            With Chungtu
                thang = Lich.SelectionStart.Month
                ngaycuathang = DayofMonth(Lich)
                rs1 = ExecSQLReturnDT(String.Format("SELECT MaNhanVien,N1, N2, N3, N4, N5, N6, N7, N8, N9, N10, N11, N12, N13, N14, N15, N16, N17, N18, N19, N20, N21, N22, N23, N24, N25, N26, N27, N28, N29, N30, N31 FROM chamcong WHERE thang={0} order by manhanvien", Lich.SelectionStart.Month))
                Try
                    For Each rs1Item As DataRow In rs1.Rows
                        If dem <> 0 Then
                            Exit For
                        End If
                        For i As Integer = 1 To ngaycuathang
                            Dim currentItem As String = LCase(ConvertToStrSafe(rs1Item(i)).Trim.ToUpper)
                            If currentItem = "p" Or currentItem = "c" Or currentItem = "l" Or currentItem = "r" Or currentItem = "v" Then
                                dem += 1
                            End If
                            If currentItem = "s" Or currentItem = "n" Then
                                dem = 0
                                Exit For
                            End If
                        Next
                    Next
                Catch
                End Try
                .NgayCT = DateSerial(Lich.SelectionStart.Year, thang, ngaycuathang)
                .NgayGS = .NgayCT
                .SoHieu = String.Format("BHNV{0}", (IIf(thang < 10, String.Format("0{0}", thang), ConvertToStrSafe(thang))))
                .MaCT = ConvertToDblSafe((ConvertToDblSafe(Timten("mact", .SoHieu, "sohieu", "chungtu"))))
                If .MaCT = 0 Then .MaCT = Lng_MaxValue("MaCT", "ChungTu") + 1
                .maloai = 0
                .thangct = thang
                .DienGiai = String.Format("Trích BHXH ({0}%) , BHYT ({1}%){2} tháng {3}", _
                                TxtNVXH.Text, _
                                TxtNVYT.Text, _
                                (IIf(ConvertToDblSafe(TxtNVTN.Text) <> 0, String.Format(" và BHTN ({0}%)", TxtNVTN.Text), String.Empty)), _
                                (IIf(thang < 10, String.Format("0{0}", thang), ConvertToStrSafe(thang))))
                .MaDT = 1
                .CTGS = 1
                kt = SoHieu2MaSo(ConvertToStrSafe(rsItem(0)), "hethongtk")
            End With
        End If
        Dim kt1 As Integer
        Dim dem1, dem2 As Integer
        For Each rsItem As DataRow In rs.Rows
            kt1 = SoHieu2MaSo(ConvertToStrSafe(rsItem(0)), "hethongtk")
            Tangbh = 0
            ThangTangbh = 0
            If Not IsDBNull(rsItem("Tangbh")) Then
                If ConvertToDblSafe(rsItem("Tangbh")) <> 0 Then
                    If rsItem("Tangbh") IsNot Nothing Then
                        Tangbh = ConvertToDblSafe(rsItem("Tangbh"))
                    End If
                    If rsItem("ThangTangbh") IsNot Nothing Then
                        ThangTangbh = ConvertToDblSafe(rsItem("ThangTangbh"))
                    End If
                End If
            End If
            Thaisan = IIf(ConvertToStrSafe(rsItem("Thaisan")) <> "", ConvertToStrSafe(rsItem("Thaisan")), 0)
            Try
                tuthang = IIf(ConvertToDblSafe(rsItem("tuthang")) <> 0, ConvertToDblSafe(rsItem("tuthang")), 13)
                denthang = IIf(ConvertToDblSafe(rsItem("denthang")) <> 0, ConvertToDblSafe(rsItem("denthang")), 13)
            Catch ex As Exception
                tuthang = 13
                denthang = 13
            End Try
            Try
                With Chungtu
                    nv.InitMaSo(ConvertToDblSafe(GetSelectValue(String.Format("SELECT maso as f1 FROM chucdanh WHERE nhanvien=N'{0}' and (nam<{1} or (nam={1} and thang<={2})) order by nam desc, thang desc", _
                                                                    rsItem("Nhanvien"), _
                                                                    frmMain._LbCty_7.Text, _
                                                                    thang))))
                    If nv.maso = 0 Then
                        LN1 = 0
                    Else
                        LN1 = FrmChamconggio.Luonggio(nv, Lich) * 8
                    End If
                    nv.InitMaSo(ConvertToDblSafe(GetSelectValue(String.Format("SELECT maso as f1 FROM chucdanh WHERE nhanvien=N'{0}' and nam={1} and thang={2} order by nam desc, thang desc", _
                                                                    rsItem("Nhanvien"), _
                                                                    frmMain._LbCty_7.Text, _
                                                                    thang))))
                    If nv.maso <> 0 Then
                        LN2 = FrmChamconggio.Luonggio(nv, Lich) * 8
                        rs3 = ExecSQLReturnDT(String.Format("SELECT MaNhanVien,N1, N2, N3, N4, N5, N6, N7, N8, N9, N10, N11, N12, N13, N14, N15, N16, N17, N18, N19, N20, N21, N22, N23, N24, N25, N26, N27, N28, N29, N30, N31 FROM chamcong WHERE thang={0} order by manhanvien", thang))
                        Dim processRowCount As Integer = 0
                        For Each rs3Item As DataRow In rs3.Rows
                            If dem1 <> 0 Then
                                Exit For
                            End If
                            If DateAndTime.Day(nv.NgayApdung) = 1 Then Exit For
                            For j As Integer = 1 To nv.NgayApdung.Day - 1
                                Dim currentItem As String = ConvertToStrSafe(rs3Item(j)).Trim.ToLower
                                If currentItem = "p" Or currentItem = "c" Or currentItem = "l" Or currentItem = "r" Or currentItem = "v" Then
                                    dem1 += 1
                                End If
                                If currentItem = "s" Or currentItem = "n" Then
                                    dem1 = 0
                                    Exit For
                                End If
                            Next
                            processRowCount += 1
                        Next
                        If processRowCount >= (rs3.Rows.Count - 1) Then
                            processRowCount -= 1
                            If processRowCount < 0 Then
                                processRowCount = 0
                            End If
                        End If
                        For k As Integer = processRowCount To (rs3.Rows.Count - 1)
                            If dem2 <> 0 Then
                                Exit For
                            End If
                            Dim rs3Item As DataRow = rs3.Rows(k)
                            For j As Integer = nv.NgayApdung.Day To DayofMonth(Lich)
                                Dim currentItem As String = ConvertToStrSafe(rs3Item(j)).Trim.ToLower
                                If currentItem = "p" Or currentItem = "c" Or currentItem = "l" Or currentItem = "r" Or currentItem = "v" Then
                                    dem2 += 1
                                End If
                                If currentItem = "s" Or currentItem = "n" Then
                                    dem2 = 0
                                    Exit For
                                End If
                            Next
                        Next
                        ln = (LN1 * dem1 + LN2 * dem2) / (dem1 + dem2)
                    Else
                        ln = LN1
                    End If
                    LuongTruocBH = Math.Round(ConvertToDblSafe(ln * (IIf(dem2 = 0, dem, (dem1 + dem2)))), 0)
                    If kt <> kt1 Then
                        .tkno.maso = kt
                        .tkno.MaTC = kt
                        kt = kt1
                        If BHXH <> 0 Then
                            masoco = ConvertToDblSafe(Timten("maso", taikhoanconnhat("3383"), "sohieu", "hethongtk"))
                            .TkCo.maso = ConvertToDblSafe(masoco)
                            .TkCo.MaTC = ConvertToDblSafe(masoco)
                            .sops = BHXH
                            .GhiChungtu()
                            BHXH = 0
                        End If
                        If BHTN <> 0 Then
                            masoco = ConvertToDblSafe(Timten("maso", taikhoanconnhat("3389"), "sohieu", "hethongtk"))
                            .TkCo.maso = ConvertToDblSafe(masoco)
                            .TkCo.MaTC = ConvertToDblSafe(masoco)
                            .sops = BHTN
                            .GhiChungtu()
                            BHTN = 0
                        End If
                        If BHYT <> 0 Then
                            masoco = ConvertToDblSafe(Timten("maso", taikhoanconnhat("3384"), "sohieu", "hethongtk"))
                            .TkCo.maso = ConvertToDblSafe(masoco)
                            .TkCo.MaTC = ConvertToDblSafe(masoco)
                            .sops = BHYT
                            .GhiChungtu()
                            BHYT = 0
                        End If
                        If rsItem("Baohiem") = 0 Or (Tangbh = 1 And ThangTangbh <= thang) Then
                            If ChkBaohiem.CheckState Then
                                BHYT = Math.Round(ConvertToDblSafe(LuongTruocBH * ConvertToDblSafe(TxtNVYT.Text) / 100))
                                If Not ((Thaisan = 1 And thang >= tuthang And thang <= denthang) Or (rsItem("Nghiviec") = 1 And thang >= tuthang)) Then
                                    BHXH = Math.Round(ConvertToDblSafe(LuongTruocBH * ConvertToDblSafe(TxtNVXH.Text) / 100))
                                    BHTN = Math.Round(ConvertToDblSafe(LuongTruocBH * ConvertToDblSafe(TxtNVTN.Text) / 100))
                                End If
                            End If
                        End If
                    Else
                        If rsItem("Baohiem") = 0 Or (Tangbh = 1 And ThangTangbh <= thang) Then
                            If ChkBaohiem.CheckState Then
                                BHYT += Math.Round(ConvertToDblSafe(LuongTruocBH * ConvertToDblSafe(TxtNVYT.Text) / 100))
                                If Not ((Thaisan = 1 And thang >= tuthang And thang <= denthang) Or (rsItem("Nghiviec") = 1 And thang >= tuthang)) Then
                                    BHXH += Math.Round(ConvertToDblSafe(LuongTruocBH * ConvertToDblSafe(TxtNVXH.Text) / 100))
                                    BHTN += Math.Round(ConvertToDblSafe(LuongTruocBH * ConvertToDblSafe(TxtNVTN.Text) / 100))
                                End If
                            End If
                        End If
                    End If
                End With
            Catch ex As Exception
                MessageBox.Show(Ngonngu("Lỗi trích bảo hiểm nhân viên!", "Error insurance deduction"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End Try
        Next
        Try
            If rs.Rows.Count <> 0 Then
                With Chungtu
                    .tkno.maso = kt
                    .tkno.MaTC = kt
                    If BHXH <> 0 Then
                        masoco = ConvertToDblSafe(Timten("maso", taikhoanconnhat("3383"), "sohieu", "hethongtk"))
                        .TkCo.maso = ConvertToDblSafe(masoco)
                        .TkCo.MaTC = ConvertToDblSafe(masoco)
                        .sops = BHXH
                        .GhiChungtu()
                    End If
                    If BHTN <> 0 Then
                        masoco = ConvertToDblSafe(Timten("maso", taikhoanconnhat("3389"), "sohieu", "hethongtk"))
                        .TkCo.maso = ConvertToDblSafe(masoco)
                        .TkCo.MaTC = ConvertToDblSafe(masoco)
                        .sops = BHTN
                        .GhiChungtu()
                    End If
                    If BHYT <> 0 Then
                        masoco = ConvertToDblSafe(Timten("maso", taikhoanconnhat("3384"), "sohieu", "hethongtk"))
                        .TkCo.maso = ConvertToDblSafe(masoco)
                        .TkCo.MaTC = ConvertToDblSafe(masoco)
                        .sops = BHYT
                        .GhiChungtu()
                    End If
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(Ngonngu("Lỗi trích bảo hiểm nhân viên!", "Error insurance deduction"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="bp1"></param>
    ''' <param name="bp2"></param>
    ''' <param name="bp3"></param>
    ''' <param name="bp4"></param>
    ''' <remarks></remarks>
    Sub Chiluongnhanvien(ByRef bp1 As Integer, ByRef bp2 As Integer, ByRef bp3 As Integer, ByRef bp4 As Integer)
        Dim rs2 As DataTable
        Dim nv1 As New ClsChucDanh
        Dim MaPhanLoai As Integer
        Dim bophan As String = String.Empty
        If bp1 <> 0 Then bophan = String.Format(" and (t2.maphanloai= {0}", bp1)
        If bp2 <> 0 Then
            If bophan = "" Then
                bophan = String.Format(" and (t2.maphanloai= {0}", bp2)
            Else
                bophan = String.Format("{0} or t2.maphanloai= {1}", bophan, ConvertToStrSafe(bp2))
            End If
        End If
        If bp3 <> 0 Then
            If bophan = "" Then
                bophan = String.Format(" and (t2.maphanloai= {0}", bp3)
            Else
                bophan = String.Format("{0} or t2.maphanloai= {1}", bophan, ConvertToStrSafe(bp3))
            End If
        End If
        If bp4 <> 0 Then
            If bophan = "" Then
                bophan = String.Format(" and (t2.maphanloai= {0}", bp4)
            Else
                bophan = String.Format("{0} or t2.maphanloai= {1}", bophan, ConvertToStrSafe(bp4))
            End If
        End If
        If bophan.Length > 0 Then bophan = String.Format("{0})", bophan)
        Dim Chungtu As New ClsChungtu
        Dim kt As Integer
        Dim sohieutk As String = String.Empty
        Dim masoco, Tamung, Trukhac, Thue, LN2, LN1, ln As Double
        Dim rs3 As DataTable
        Dim nv As New ClsChucDanh
        Dim ngaycuathang, thang, dem As Integer
        Dim LuongTruocBH As Double
        Dim rs1 As DataTable
        Dim str As String = String.Format("SELECT distinct t4.sohieu as sohieutk,t1.ngaycong,t1.luongcb,t1.heso,t1.pccv,t1.pctn,t1.pcld,t1.pck,t1.thuong,t1.congkhac,t1.bhxh,t1.bhyt,t1.bhtn,t1.tamung,t1.trukhac,t1.thue,t1.nghi,t1.phep,t1.tangca,t1.com,t1.heso1,t1.bhxh,t1.bhyt,t1.bhtn,t1.demcu,t1.demmoi,t1.tangcagio,t2.sohieu as nhanvien,t1.luong13,t2.maphanloai FROM thongsoluong t1 inner join((quanlynhanvien t2 inner join phanloaiquanlynhanvien t4 on t2.maphanloai=t4.maso) inner join chucvu t3 on t2.machucvu=t3.maso) on t1.sohieunhanvien=t2.sohieu WHERE t1.thang={0}{1} order by t4.sohieu", _
                                Lich.SelectionStart.Month, _
                                bophan)
        Dim rs As DataTable = ExecSQLReturnDT(str)
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            With Chungtu
                thang = Lich.SelectionStart.Month
                ngaycuathang = DayofMonth(Lich)
                rs1 = ExecSQLReturnDT(String.Format("SELECT MaNhanVien,N1, N2, N3, N4, N5, N6, N7, N8, N9, N10, N11, N12, N13, N14, N15, N16, N17, N18, N19, N20, N21, N22, N23, N24, N25, N26, N27, N28, N29, N30, N31 FROM chamcong WHERE thang={0} order by manhanvien", Lich.SelectionStart.Month))
                Try
                    For Each rs1Item As DataRow In rs1.Rows
                        If dem <> 0 Then
                            Exit For
                        End If
                        For i As Integer = 1 To ngaycuathang
                            Dim currentItem As String = LCase(ConvertToStrSafe(rs1Item(i)).Trim.ToUpper)
                            If currentItem = "p" Or currentItem = "c" Or currentItem = "l" Or currentItem = "r" Or currentItem = "v" Then
                                dem += 1
                            End If
                            If currentItem = "s" Or currentItem = "n" Then
                                dem = 0
                                Exit For
                            End If
                        Next
                    Next
                Catch
                End Try
                .NgayCT = DateSerial(Lich.SelectionStart.Year, thang, DayofMonth(Lich))
                .NgayGS = .NgayCT
                .SoHieu = String.Format("CLNV{0}", IIf(thang < 10, String.Format("0{0}", thang), ConvertToStrSafe(thang)))
                .MaCT = ConvertToDblSafe((ConvertToDblSafe(Timten("mact", .SoHieu, "sohieu", "chungtu"))))
                If .MaCT = 0 Then
                    .MaCT = Lng_MaxValue("MaCT", "ChungTu") + 1
                End If
                .maloai = 0
                .thangct = thang
                .DienGiai = String.Format("Chi lương nhân viên tháng {0}", (IIf(thang < 10, String.Format("0{0}", thang), ConvertToStrSafe(thang))))
                .MaDT = 1
                .CTGS = 1
                kt = SoHieu2MaSo(ConvertToStrSafe(rsItem(0)), "hethongtk")
                If rsItem("MaPhanLoai") IsNot Nothing Then
                    MaPhanLoai = ConvertToDblSafe(rsItem("MaPhanLoai"))
                End If

                .tkno.maso = kt
                .tkno.MaTC = kt
                masoco = ConvertToDblSafe(Timten("maso", taikhoanconnhat("1111"), "sohieu", "hethongtk"))
                .TkCo.maso = ConvertToDblSafe(masoco)
                .TkCo.MaTC = ConvertToDblSafe(masoco)
                If ConvertToDblSafe(Timten("maso", "KT", "sohieu", "khachhang")) = 0 Then
                    ExecSQLNonQuery(String.Format("INSERT into khachhang(maso,maphanloai,sohieu,ten) values({0},{1},'KT','Kế toán {2}')", _
                                        Lng_MaxValue("Maso", "khachhang") + 1, _
                                        Lng_MaxValue("Maso", "phanloaikhachhang"), _
                                        frmMain._LbCty_0.Text))
                End If
            End With
        End If
        Dim dem1, dem2 As Integer
        Dim kt1 As Integer
        Dim LCB As Double
        For Each rsItem As DataRow In rs.Rows
            If rsItem("luongcb") IsNot Nothing Then
                LCB = ConvertToDblSafe(rsItem("luongcb"))
            End If
            kt1 = SoHieu2MaSo(ConvertToStrSafe(rsItem(0)), "hethongtk")

            With Chungtu
                nv.InitMaSo(ConvertToDblSafe(GetSelectValue(String.Format("SELECT maso as f1 FROM chucdanh WHERE nhanvien=N'{0}' and (nam<{1} or (nam={1} and thang<{2})) order by nam desc, thang desc", _
                                                                ConvertToDblSafe(rsItem("Nhanvien")), _
                                                                frmMain._LbCty_7.Text, _
                                                                ConvertToStrSafe(thang)))))
                If nv.maso = 0 Then
                    LN1 = 0
                Else
                    LN1 = FrmChamconggio.Luonggio(nv, Lich) * 8
                End If
                nv.InitMaSo(ConvertToDblSafe(GetSelectValue(String.Format("SELECT maso as f1 FROM chucdanh WHERE nhanvien=N'{0}' and nam={1} and thang={2} order by nam desc, thang desc", _
                                                                ConvertToDblSafe(rsItem("Nhanvien")), _
                                                                frmMain._LbCty_7.Text, _
                                                                ConvertToStrSafe(thang)))))
                If nv.maso <> 0 Then
                    LN2 = FrmChamconggio.Luonggio(nv, Lich) * 8
                    rs3 = ExecSQLReturnDT(String.Format("SELECT MaNhanVien,N1, N2, N3, N4, N5, N6, N7, N8, N9, N10, N11, N12, N13, N14, N15, N16, N17, N18, N19, N20, N21, N22, N23, N24, N25, N26, N27, N28, N29, N30, N31 FROM chamcong WHERE thang={0} order by manhanvien", thang))
                    Dim processRowCount As Integer = 0
                    For Each rs3Item As DataRow In rs3.Rows
                        If dem1 <> 0 Then
                            Exit For
                        End If
                        If DateAndTime.Day(nv.NgayApdung) = 1 Then Exit For
                        For j As Integer = 1 To nv.NgayApdung.Day - 1
                            Dim currentItem As String = LCase(ConvertToStrSafe(rs3Item(j)).Trim.ToUpper)
                            If currentItem = "p" Or currentItem = "c" Or currentItem = "l" Or currentItem = "r" Or currentItem = "v" Then
                                dem1 += 1
                            End If
                            If currentItem = "s" Or currentItem = "n" Then
                                dem1 = 0
                                Exit For
                            End If
                        Next
                        processRowCount += 1
                    Next
                    If processRowCount >= (rs3.Rows.Count - 1) Then
                        processRowCount -= 1
                        If processRowCount < 0 Then
                            processRowCount = 0
                        End If
                    End If
                    For k As Integer = processRowCount To (rs3.Rows.Count - 1)
                        If dem2 <> 0 Then
                            Exit For
                        End If
                        Dim rs3Item As DataRow = rs3.Rows(k)
                        For j As Integer = nv.NgayApdung.Day To DayofMonth(Lich)
                            Dim currentItem As String = LCase(ConvertToStrSafe(rs3Item(j)).Trim.ToUpper)
                            If currentItem = "p" Or currentItem = "c" Or currentItem = "l" Or currentItem = "r" Or currentItem = "v" Then
                                dem2 += 1
                            End If
                            If currentItem = "s" Or currentItem = "n" Then
                                dem2 = 0
                                Exit For
                            End If
                        Next
                    Next
                    ln = (LN1 * dem1 + LN2 * dem2) / (dem1 + dem2)
                Else
                    ln = LN1
                End If
                If kt <> kt1 Then
                    If Chk.CheckState = CheckState.Checked Then
                        rs2 = ExecSQLReturnDT(String.Format("SELECT * FROM quanlynhanvien WHERE thaisan=1 and month(tungay)<={0} and month(denngay)>={1} and maphanloai={2}", _
                                                  thang, _
                                                  ConvertToStrSafe(thang), _
                                                  ConvertToStrSafe(MaPhanLoai)))
                        For Each rs2Item As DataRow In rs2.Rows
                            nv1.InitMaSo(ConvertToDblSafe(GetSelectValue(String.Format("SELECT maso as f1 FROM chucdanh WHERE nhanvien=N'{0}' and (nam<{1} or (nam={1} and thang<{2}))) order by nam desc, thang desc", _
                                                                             rs2Item("SoHieu"), _
                                                                             ConvertToStrSafe(pNamTC), _
                                                                             ConvertToStrSafe(thang)))))
                            .sops += FrmChamconggio.Luongthang(nv1) * nv1.thang13 / 100 * ConvertToDblSafe(Luong13.Text) / 100
                        Next
                    End If
                    .sops = .sops - Tamung - Trukhac - Thue
                    .GhiChungtu()
                    If Trukhac <> 0 Then
                        masoco = ConvertToDblSafe(Timten("maso", taikhoanconnhat("13888"), "sohieu", "hethongtk"))
                        If masoco = 0 Then
                            MessageBox.Show(Ngonngu("Thiếu tài khoản 13888 !", "Major account 13888 !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Loitrichluong = 4
                            ExecSQLNonQuery(String.Format("DELETE  FROM chungtu WHERE sohieu = 'CLNV{0}'", IIf(thang < 10, String.Format("0{0}", thang), ConvertToStrSafe(thang))))
                            Exit Sub
                        End If
                        .TkCo.maso = ConvertToDblSafe(masoco)
                        .TkCo.MaTC = ConvertToDblSafe(masoco)
                        .sops = Trukhac
                        .GhiChungtu()
                    End If
                    If Tamung <> 0 Then
                        masoco = ConvertToDblSafe(Timten("maso", taikhoanconnhat("141"), "sohieu", "hethongtk"))
                        If masoco = 0 Then
                            MessageBox.Show(Ngonngu("Thiếu tài khoản 141 !", "Major account 141 !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Loitrichluong = 4
                            ExecSQLNonQuery(String.Format("DELETE  FROM chungtu WHERE sohieu = 'CLNV{0}'", IIf(thang < 10, String.Format("0{0}", thang), ConvertToStrSafe(thang))))
                            Exit Sub
                        End If
                        .TkCo.maso = ConvertToDblSafe(masoco)
                        .TkCo.MaTC = ConvertToDblSafe(masoco)
                        .sops = Tamung
                        .GhiChungtu()
                    End If
                    kt = kt1
                    If rsItem("MaPhanLoai") IsNot Nothing Then
                        MaPhanLoai = ConvertToDblSafe(rsItem("MaPhanLoai"))
                    End If

                    .tkno.maso = kt
                    .tkno.MaTC = kt
                    masoco = ConvertToDblSafe(Timten("maso", taikhoanconnhat("1111"), "sohieu", "hethongtk"))
                    .TkCo.maso = ConvertToDblSafe(masoco)
                    .TkCo.MaTC = ConvertToDblSafe(masoco)
                    '****************************** Tang luong **********************************************************
                    LuongTruocBH = Math.Round(ln * (IIf(dem2 = 0, dem, (dem1 + dem2))), 0)
                    .sops = Math.Round(ln * (ConvertToDblSafe(rsItem("Ngaycong")) + ConvertToDblSafe(rsItem("Phep")) + ConvertToDblSafe(rsItem("Tangca"))) + ConvertToDblSafe(rsItem("PCCV")) + ConvertToDblSafe(rsItem("PCTN")) + ConvertToDblSafe(rsItem("PCLD")) + ConvertToDblSafe(rsItem("PCK")) + ConvertToDblSafe(rsItem("thuong")) + ConvertToDblSafe(rsItem("congkhac")) + ConvertToDblSafe(rsItem("Com")) + IIf(IsDBNull(rsItem("tangcagio")), 0, ConvertToDblSafe(rsItem("tangcagio"))), 0)
                    If ChkBaohiem.CheckState = CheckState.Checked Then
                        If ConvertToDblSafe(rsItem("BHXH")) <> 0 And ConvertToDblSafe(rsItem("BHYT")) <> 0 Then
                            .sops -= LuongTruocBH * (ConvertToDblSafe(rsItem("BHXH")) + ConvertToDblSafe(rsItem("BHYT")) + ConvertToDblSafe(rsItem("BHTN"))) / 100
                        End If
                    End If
                    .sops += Math.Round(IIf(ConvertToDblSafe(rsItem("Luong13")) <> 0, ln * ConvertToDblSafe(rsItem("Ngaycong")) * ConvertToDblSafe(rsItem("Luong13")) / 100, 0), 0)
                    If rsItem("Tamung") IsNot Nothing Then
                        Tamung = Math.Round(ConvertToDblSafe(rsItem("Tamung")))
                    End If
                    If rsItem("Trukhac") IsNot Nothing Then
                        Trukhac = Math.Round(ConvertToDblSafe(rsItem("Trukhac")))
                    End If
                    If rsItem("Thue") IsNot Nothing Then
                        Thue = Math.Round(ConvertToDblSafe(rsItem("Thue")))
                    End If
                Else
                    LuongTruocBH = Math.Round(ln * (IIf(dem2 = 0, dem, (dem1 + dem2))), 0)
                    .sops += Math.Round(ln * (ConvertToDblSafe(rsItem("Ngaycong")) + ConvertToDblSafe(rsItem("Phep")) + ConvertToDblSafe(rsItem("Tangca"))) + ConvertToDblSafe(rsItem("PCCV")) + ConvertToDblSafe(rsItem("PCTN")) + ConvertToDblSafe(rsItem("PCLD")) + ConvertToDblSafe(rsItem("PCK")) + ConvertToDblSafe(rsItem("thuong")) + ConvertToDblSafe(rsItem("congkhac")) + ConvertToDblSafe(rsItem("Com")) + (IIf(IsDBNull(ConvertToDblSafe(rsItem("tangcagio"))), 0, ConvertToDblSafe(rsItem("tangcagio")))), 0)
                    If ChkBaohiem.CheckState = CheckState.Checked Then
                        If ConvertToDblSafe(rsItem("BHXH")) <> 0 And ConvertToDblSafe(rsItem("BHYT")) <> 0 Then
                            .sops -= Math.Round(LuongTruocBH * (ConvertToDblSafe(rsItem("BHXH")) + ConvertToDblSafe(rsItem("BHYT")) + ConvertToDblSafe(rsItem("BHTN"))) / 100)
                        End If
                        .sops += Math.Round(ConvertToDblSafe(IIf(ConvertToDblSafe(rsItem("Luong13")) <> 0, ln * ConvertToDblSafe(rsItem("Ngaycong")) * ConvertToDblSafe(rsItem("Luong13")) / 100, 0)), 0)
                        If rsItem("Tamung") IsNot Nothing Then
                            Tamung += Math.Round(ConvertToDblSafe(ConvertToDblSafe(rsItem("Tamung"))))
                        End If
                        If rsItem("Trukhac") IsNot Nothing Then
                            Trukhac += Math.Round(ConvertToDblSafe(ConvertToDblSafe(rsItem("Trukhac"))))
                        End If
                        If rsItem("Thue") IsNot Nothing Then
                            Thue += Math.Round(ConvertToDblSafe(ConvertToDblSafe(rsItem("Thue"))))
                        End If

                    End If
                End If
            End With
        Next
        Dim KHTen = String.Empty, KHDiachi As String = String.Empty
        Dim KHMaso As Integer
        If rs.Rows.Count <> 0 Then
            With Chungtu
                If Chk.CheckState = CheckState.Checked Then
                    rs2 = ExecSQLReturnDT(String.Format("SELECT * FROM quanlynhanvien WHERE thaisan=1 and month(tungay)<={0} and month(denngay)>={1} and maphanloai={2}", _
                                              thang, _
                                              ConvertToStrSafe(thang), _
                                              ConvertToStrSafe(MaPhanLoai)))
                    For Each rs2Item As DataRow In rs2.Rows
                        nv1.InitMaSo(ConvertToDblSafe(GetSelectValue(String.Format("SELECT maso as f1 FROM chucdanh WHERE nhanvien=N'{0}' and (nam<{1} or (nam={1} and thang<{2})) order by nam desc, thang desc", _
                                                                         rs2Item("SoHieu"), _
                                                                         ConvertToStrSafe(pNamTC), _
                                                                         ConvertToStrSafe(thang)))))
                        .sops += FrmChamconggio.Luongthang(nv1) * nv1.thang13 / 100 * ConvertToDblSafe(Luong13.Text) / 100
                    Next
                End If
                .sops = .sops - Tamung - Trukhac - Thue
                .GhiChungtu()
                If Trukhac <> 0 Then
                    masoco = ConvertToDblSafe(Timten("maso", taikhoanconnhat("13888"), "sohieu", "hethongtk"))
                    If masoco = 0 Then
                        MessageBox.Show(Ngonngu("Thiếu tài khoản 13888 !", "Major account 13888 !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Loitrichluong = 4
                        ExecSQLNonQuery(String.Format("DELETE  FROM chungtu WHERE sohieu = 'CLNV{0}'", IIf(thang < 10, String.Format("0{0}", thang), ConvertToStrSafe(thang))))
                        Exit Sub
                    End If
                    .TkCo.maso = ConvertToDblSafe(masoco)
                    .TkCo.MaTC = ConvertToDblSafe(masoco)
                    .sops = Trukhac
                    .GhiChungtu()
                End If
                If Tamung <> 0 Then
                    masoco = ConvertToDblSafe(Timten("maso", taikhoanconnhat("141"), "sohieu", "hethongtk"))
                    If masoco = 0 Then
                        MessageBox.Show(Ngonngu("Thiếu tài khoản 141 !", "Major account 141 !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Loitrichluong = 4
                        ExecSQLNonQuery(String.Format("DELETE  FROM chungtu WHERE sohieu = 'CLNV{0}'", IIf(thang < 10, String.Format("0{0}", thang), ConvertToStrSafe(thang))))
                        Exit Sub
                    End If
                    .TkCo.maso = ConvertToDblSafe(masoco)
                    .TkCo.MaTC = ConvertToDblSafe(masoco)
                    .sops = Tamung
                    .GhiChungtu()
                End If
                'Thông tin thuế, khách hàng
                KHMaso = ConvertToDblSafe(GetSelectValue("SELECT maso as f1,isnull(ten,'') as f2,isnull(diachi,'') as f3 FROM khachhang WHERE sohieu='KT'", KHTen, KHDiachi))
                ExecSQLNonQuery((String.Format("DELETE  FROM chungtulq WHERE mact={0} or soctgoc=N'{1}'", .MaCT, .SoHieu)))
                If Thue <> 0 Then
                    ExecSQLNonQuery(String.Format("INSERT into chungtulq(maso,mact,loai,hoten,diachi,soctgoc,makh)values({0},{1},0, N'{2}', N'{3}', N'{4}',{5})", _
                                        ConvertToStrSafe(Lng_MaxValue("maso", "chungtulq") + 1), _
                                        .MaCT, _
                                        KHTen, _
                                        KHDiachi, _
                                        .SoHieu, _
                                        KHMaso))
                Else
                    .GhiThongtinCT(.maloai, KHTen, KHDiachi, .SoHieu, KHMaso)
                End If
            End With
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Lich"></param>
    ''' <param name="phieuluong"></param>
    ''' <remarks></remarks>
    Sub InBangluong(ByRef Lich As MonthCalendar, Optional ByRef phieuluong As Boolean = False)
        Dim str As String = String.Empty
        Dim dem As Integer

        If phieuluong Then
            str = String.Format("SELECT t2.ten as [t2.ten],t3.ten as [t3.ten],t1.ngaycong,CASE WHEN (t1.luongcb<>0) THEN t1.luongcb ELSE 1 END *t1.heso as luongcb,t1.heso,t1.pccv,t1.pctn,t1.pcld,t1.com,t1.pck,t1.thuong,t1.congkhac,t1.bhxh,t1.bhyt,t1.bhtn,t1.tamung,t1.trukhac,t1.thue,t1.nghi,t1.phep,t1.tangca,CASE WHEN (t1.luongcb<>0) THEN t1.luongcb ELSE 1 END *t1.heso1 as luongcb1,t1.heso1,t1.bhxh1,t1.bhtn1,t1.bhyt1,t1.pccv1,t1.pctn1,t1.pcld1,(t1.com1+t1.pck1) as pck1,t1.demcu,t1.demmoi,t1.tangcagio,t2.loailuong,t1.luong13 FROM (thongsoluong t1 left join phucap t5 on t1.sohieunhanvien=t5.sohieunhanvien and t1.thang=t5.thang)inner join((quanlynhanvien t2 inner join phanloaiquanlynhanvien t4 on t2.maphanloai=t4.maso) inner join chucvu t3 on t2.machucvu=t3.maso) on t1.sohieunhanvien=t2.sohieu WHERE t1.thang={0} order by t4.maso,t2.sohieu", Lich.SelectionStart.Month)
            rptFrom.InitForm("PHIEULUONG.RPT", str, "QTinhLuong")
            rptFrom.SetFormulas("LCB", ConvertToDblSafe(GetSelectValue("SELECT lcb as f1 FROM license")))
            rptFrom.ReportWindowTitle = "Phiếu lương nhân viên"
        Else
            str = String.Format("SELECT t2.ten as [t2.ten],t3.ten as [t3.ten],t1.ngaycong,CASE WHEN (t1.luongcb<>0) THEN t1.luongcb ELSE 1 END*t1.heso as luongcb,t1.pccv,t1.pctn,t1.pcld,(t1.com+t1.pck) as pck,t1.thuong,t1.congkhac,t1.bhxh,t1.bhtn,t1.bhyt,t1.tamung,t1.trukhac,t1.thue,t1.nghi,t1.phep,t1.tangca,t2.maphanloai,t4.ten as [t4.ten], CASE WHEN (t1.luongcb<>0) THEN t1.luongcb ELSE 1 END * t1.heso1 as luongcb1,t1.bhxh1,t1.bhtn1,t1.bhyt1,t1.pccv1,t1.pctn1,t1.pcld1,(t1.com1+t1.pck1) as pck1,t1.demcu,t1.demmoi,t1.tangcagio,t1.luong13 FROM thongsoluong t1 inner join((quanlynhanvien t2 inner join phanloaiquanlynhanvien t4 on t2.maphanloai=t4.maso) inner join chucvu t3 on t2.machucvu=t3.maso) on t1.sohieunhanvien=t2.sohieu WHERE t1.thang={0} order by t4.maso,t2.sohieu", Lich.SelectionStart.Month)
            rptFrom.InitForm("BANGLUONG.RPT", str, "QTinhLuong")
            rptFrom.ReportWindowTitle = "Bảng lương nhân viên"
        End If
        'Đếm số ngày phải làm trong tháng
        Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT MaNhanVien,N1, N2, N3, N4, N5, N6, N7, N8, N9, N10, N11, N12, N13, N14, N15, N16, N17, N18, N19, N20, N21, N22, N23, N24, N25, N26, N27, N28, N29, N30, N31 FROM chamcong WHERE thang={0} order by manhanvien", Lich.SelectionStart.Month))
        Try
            For Each rsItem As DataRow In rs.Rows
                For j As Integer = 1 To DayofMonth(Lich)
                    Dim currentItem As String = LCase(ConvertToStrSafe(rsItem(j)).Trim.ToUpper)
                    If currentItem = "p" Or currentItem = "c" Or currentItem = "l" Or currentItem = "r" Or currentItem = "v" Then
                        dem += 1
                    End If
                    If currentItem = "s" Or currentItem = "n" Then
                        dem = 0
                        Exit For
                    End If
                Next
                If dem > 0 Then Exit For
            Next
        Catch
        End Try
        rptFrom = rptFrom.copyReportObject(rptFrom)
        With rptFrom
            .SetFormulas("TenCty", String.Format("'{0}'", pTenCty))
            .SetFormulas("TenCn", String.Format("'MST: {0}'", frmMain._LbCty_8.Text))
            .SetFormulas("songay", dem)
            .SetFormulas("thang", String.Format("'Tháng {0} - {1}'", Lich.SelectionStart.Month, ConvertToStrSafe(Lich.SelectionStart.Year)))
            .SetFormulas("ngayky", String.Format("'ngày {0} tháng {1} năm {2}'", DayofMonth(Lich), ConvertToStrSafe(Lich.SelectionStart.Month), ConvertToStrSafe(Lich.SelectionStart.Year)))

            .ReportWindowState = System.Windows.Forms.FormWindowState.Maximized

            Dim reportMessage As String = .DoReport()
            If String.IsNullOrEmpty(reportMessage) Then

            End If
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TxtDNXH_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles TxtDNXH.Enter
        TxtDNXH.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TxtDNYT_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles TxtDNYT.Enter
        TxtDNYT.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TxtDNTN_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles TxtDNTN.Enter
        TxtDNTN.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TxtNVXH_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles TxtNVXH.Enter
        TxtNVXH.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TxtNVYT_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles TxtNVYT.Enter
        TxtNVYT.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TxtNVTN_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles TxtNVTN.Enter
        TxtNVTN.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TxtNVXH_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles TxtNVXH.Leave
        TxtNVXH.Text = ConvertToStrSafe(ConvertToDblSafe(TxtNVXH.Text))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TxtNVYT_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles TxtNVYT.Leave
        TxtNVYT.Text = ConvertToStrSafe(ConvertToDblSafe(TxtNVYT.Text))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TxtNVTN_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles TxtNVTN.Leave
        TxtNVTN.Text = ConvertToStrSafe(ConvertToDblSafe(TxtNVTN.Text))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TxtDNXH_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles TxtDNXH.Leave
        TxtDNXH.Text = ConvertToStrSafe(ConvertToDblSafe(TxtDNXH.Text))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TxtDNYT_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles TxtDNYT.Leave
        TxtDNYT.Text = ConvertToStrSafe(ConvertToDblSafe(TxtDNYT.Text))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TxtDNTN_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles TxtDNTN.Leave
        TxtDNTN.Text = ConvertToStrSafe(ConvertToDblSafe(TxtDNTN.Text))
    End Sub

    Private Sub TxtTNCN_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTNCN.LostFocus, TxtGiaCanh.LostFocus
        TxtTNCN.Text = Format(TxtTNCN.Text, Mask_0)
        If (TxtTNCN.Text = String.Empty) Then
            TxtTNCN.Text = "0"
        End If
        TxtGiaCanh.Text = Format(TxtGiaCanh.Text, Mask_0)
        If (TxtGiaCanh.Text = String.Empty) Then
            TxtGiaCanh.Text = "0"
        End If
        ExecSQLNonQuery("UPDATE license SET tncn=" + CStr(ConvertToDblSafe(TxtTNCN.Text)) + ", giacanh=" + CStr(ConvertToDblSafe(TxtGiaCanh.Text)))
    End Sub
End Class
