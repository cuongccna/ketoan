Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmDsCT
    Dim MaCTChon As Integer
    Dim Lietke As Boolean
    Dim Row As Integer
    Dim ord As Integer
    Dim Ngay(1) As Date
    Public loai, tscc As Integer
    Public tracu As Boolean
    Dim chon As Integer

    Private Sub ChkLoai_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _ChkLoai_12.CheckStateChanged, _ChkLoai_11.CheckStateChanged, _ChkLoai_0.CheckStateChanged, _ChkLoai_1.CheckStateChanged, _ChkLoai_2.CheckStateChanged, _ChkLoai_3.CheckStateChanged, _ChkLoai_9.CheckStateChanged, _ChkLoai_10.CheckStateChanged, _ChkLoai_8.CheckStateChanged, _ChkLoai_7.CheckStateChanged, _ChkLoai_13.CheckStateChanged, _ChkLoai_14.CheckStateChanged, _ChkLoai_15.CheckStateChanged, _ChkLoai_16.CheckStateChanged
        Try
            If ChkLoai(7).CheckState = CheckState.Checked Then
                For i As Integer = 0 To 3
                    ChkLoai(i).CheckState = CheckState.Unchecked
                    ChkLoai(i).Enabled = False
                Next
                For i As Integer = 8 To 12
                    ChkLoai(i).CheckState = CheckState.Unchecked
                    ChkLoai(i).Enabled = False
                Next
            Else
                For i As Integer = 0 To 3
                    ChkLoai(i).Enabled = True
                Next
                For i As Integer = 8 To 13
                    ChkLoai(i).Enabled = True
                Next
            End If
            Command(5).Enabled = (ChkLoai(7).CheckState = CheckState.Unchecked)
            Command(7).Visible = (ChkLoai(1).CheckState = CheckState.Checked) Or (ChkLoai(2).CheckState = CheckState.Checked)
            Dim vs As Boolean = (ChkLoai(1).CheckState = CheckState.Checked Or ChkLoai(2).CheckState = CheckState.Checked Or ChkLoai(8).CheckState = CheckState.Checked)
            Label(8).Visible = vs
            Label(9).Visible = vs
            CboN(0).Visible = vs
            CboN(1).Visible = vs
            KiemtraUser()
        Catch ex As Exception

        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub ChkTaikhoan_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _ChkTaikhoan_0.Leave, _ChkTaikhoan_1.Leave, _ChkTaikhoan_2.Leave, _ChkTaikhoan_3.Leave, _ChkTaikhoan_4.Leave, _ChkTaikhoan_5.Leave, _ChkTaikhoan_6.Leave, _ChkTaikhoan_7.Leave, _ChkTaikhoan_8.Leave
        Command(6).Visible = ChkTaikhoan(0).CheckState = CheckState.Checked And Strings.Left(txtShTk(0).Text, 1) <> "." And Strings.Len(txtShTk(0).Text) <> 0
    End Sub
    '======================================================================================
    ' Liệt kê, Chọn chứng từ
    Private chiso1 As Integer = -1
    Private chiso0 As Integer = -1
    '======================================================================================
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_7.Click, _Command_4.Click, _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click, _Command_6.Click, _Command_5.Click
        Try
            Dim Index As Integer = Array.IndexOf(Command, eventSender)
            Dim SoCTChon, i As Integer
            Dim dong As Integer
            Dim MaCT(Max1000) As Integer
            Dim TK As New ClsTaikhoan
            Dim dk1 As Double
            Dim dk, sohieusang As String
            Dim rs As DataTable
            Dim f As Object
            Dim ms As Integer
            Select Case Index
                Case 0, 7
                    If ChkTaikhoan(0).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(0).Tag)) = 0 Then
                        ErrMsg(er_SHTaiKhoan1)
                        txtShTk(0).Focus()
                        Exit Sub
                    End If
                    If ChkTaikhoan(1).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(1).Tag)) = 0 Then
                        ErrMsg(er_SHVattu)
                        txtShTk(1).Focus()
                        Exit Sub
                    End If
                    If ChkTaikhoan(2).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(2).Tag)) = 0 Then
                        ErrMsg(er_SHTaiSan)
                        txtShTk(2).Focus()
                        Exit Sub
                    End If
                    If ChkTaikhoan(3).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(3).Tag)) = 0 Then
                        ErrMsg(er_SHKhachHang)
                        txtShTk(3).Focus()
                        Exit Sub
                    End If
                    If ChkTaikhoan(5).CheckState = CheckState.Checked And Strings.Len(txtShTk(4).Text) = 0 Then
                        MessageBox.Show(Ngonngu("Thiếu số hoá đơn !", "Missing number of voucher !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtShTk(4).Focus()
                        Exit Sub
                    End If
                    If CboThang(1).Items.Count > 0 And CboThang(0).Items.Count > 0 Then
                        If CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
                    End If

                    If Index = 0 Then
                        LietKeChungtu(IIf(ChkTaikhoan(0).CheckState = CheckState.Checked, txtShTk(0).Text, String.Empty), _
                            IIf(ChkTaikhoan(1).CheckState = CheckState.Checked, ConvertToDblSafe(txtShTk(1).Tag), IIf(ChkTaikhoan(8).CheckState = CheckState.Checked And ChkTaikhoan(0).CheckState = CheckState.Checked And Strings.Left(txtShTk(0).Text, 4) = "1422", ConvertToDblSafe(txtShTk(6).Tag), 0)), _
                            IIf(ChkTaikhoan(2).CheckState = CheckState.Checked, ConvertToDblSafe(txtShTk(2).Tag), 0), _
                            IIf(ChkTaikhoan(3).CheckState = CheckState.Checked, ConvertToDblSafe(txtShTk(3).Tag), 0), _
                            IIf(ChkTaikhoan(5).CheckState = CheckState.Checked, txtShTk(4).Text, String.Empty))
                    Else
                        DoisoChungtu(IIf(ChkTaikhoan(0).CheckState = CheckState.Checked, txtShTk(0).Text, String.Empty), _
                            IIf(ChkTaikhoan(1).CheckState = CheckState.Checked, ConvertToDblSafe(txtShTk(1).Tag), 0), _
                            IIf(ChkTaikhoan(2).CheckState = CheckState.Checked, ConvertToDblSafe(txtShTk(2).Tag), 0), _
                            IIf(ChkTaikhoan(3).CheckState = CheckState.Checked, ConvertToDblSafe(txtShTk(3).Tag), 0), _
                            IIf(ChkTaikhoan(5).CheckState = CheckState.Checked, txtShTk(4).Text, String.Empty))
                    End If
                Case 1
                    GrdChungtu.Col = 5
                    If Strings.Len(GrdChungtu.CtlText) = 0 Then Exit Sub
                    MaCTChon = ConvertToDblSafe(GrdChungtu.CtlText)
                    Row = GrdChungtu.Row
                    Hide()
                    Lietke = True
                Case 2
                    MaCTChon = 0
                    If Me.Visible Then Hide()
                    Lietke = True
                Case 3, 4
                    DSCTu(Index - 3)
                Case 5
                    f = New FrmChungtu()
                    f.ShowDialog()
                    With GrdChungtu
                        .Col = 5
                        For Each sItem As ListViewEx.GLItem In .SelectedItems
                            .Row = sItem.Index
                            ms = ConvertToDblSafe(.CtlText)
                            If ms > 0 Then
                                pPhieu = 0
                                Dim rfDbl As Double = ConvertToDblSafe(GrdChungtu.CtlText)
                                f.VaoSoNK(rfDbl)
                            End If
                        Next
                    End With

                    f = Nothing
                    pPhieu = 1
                    Command_ClickEvent(Command(0), New EventArgs())
                Case 6
                    If FrmPassword.GetPswX() <> "MS" Then GoTo Xong
                    dong = GrdChungtu.Rows
                    If CboThang(1).Items.Count > 0 And CboThang(0).Items.Count > 0 Then
                        If CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
                    End If

                    sohieusang = FrmGetStr.GetString(Ngonngu("Tài khoản chuyển đến:", "To Account:"), My.Application.Info.ProductName)
                    If sohieusang.Length = 0 Then Exit Sub
                    If ConvertToDblSafe(Timten("maso", sohieusang, "sohieu", "hethongtk")) = 0 Then Exit Sub
                    dk1 = ConvertToDblSafe((GetSelectValue(String.Format("SELECT count(*) as f1 FROM hethongtk WHERE left(sohieu,{0})='{1}'", sohieusang.Length, sohieusang))))
                    If dk1 <> 1 Then
                        MessageBox.Show(Ngonngu("Tài khoản có chi tiết hoặc không có trong hệ thống tài khoản ! ", "Account have details or not in the account list !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    TK.InitTaikhoanSohieu(sohieusang)
                    If Not ((TK.maso > 0 And TK.tkcon = 0 And TK.tk_id <> TKVT_ID And TK.tk_id <> TKDT_ID And TK.tk_id <> GTGTKT_ID And TK.tk_id <> GTGTPN_ID) Or (sohieusang.ToUpper() = "0")) Then
                        If sohieusang.Length > 0 Then ErrMsg(er_SHTaiKhoan1)
                    End If
                    If ConvertToDblSafe(Strings.Left(txtShTk(0).Text, 3)) = 131 Or ConvertToDblSafe(Strings.Left(txtShTk(0).Text, 3)) = 331 Then
                        SoCTChon = FrmA.ChonCTSoA(pDataPath, IIf(OptLK(0).Checked, CboThang(0).SelectedValue, 0), ConvertToDateSafe(MedNgay(0).Text), ConvertToDateSafe(MedNgay(1).Text), MaCT, IIf(OptLK(0).Checked, CboThang(1).SelectedValue, 0), txtShTk(0).Text, sohieusang)
                        If SoCTChon = 0 Then GoTo Xong
                        i = 0
                        dk = IIf(ConvertToDblSafe(Strings.Left(txtShTk(0).Text, 3)) = 131, "matkno", "matkco")
                        While MaCT(i) <> 0
                            rs = ExecSQLReturnDT(String.Format("SELECT t1.*,t4.maso as maso1,t4.ten,t4.diachi FROM (chungtu t1 inner join hethongtk t2 on t1.{0}=t2.maso)left join (hoadon t3 left join khachhang t4 on t3.makhachhang=t4.maso)on t1.sohieu=t3.sohd WHERE left(t2.sohieu,len({1}))='{1}' and T1.MaCT = {2}", _
                                                     dk, _
                                                     txtShTk(0).Text, _
                                                     ConvertToStrSafe(MaCT(i))))
                            Dim rsIndex As Integer = 0
                            While rsIndex < rs.Rows.Count
                                Dim rsItem As DataRow = rs.Rows(rsIndex)
                                rsIndex += 1 ' C15 Rs LOOP CONTROL
                                ExecSQLNonQuery(String.Format("UPDATE chungtu set {0}={1} WHERE maso={2}", dk, Timten("maso", sohieusang, "sohieu", "hethongtk"), rsItem("MaSo")))
                                If ConvertToDblSafe(GetSelectValue(String.Format("SELECT maso as f1 FROM chungtulq WHERE mact={0} or soctgoc=N'{1}'", rsItem("MaCT"), rsItem("SoHieu")))) = 0 Then
                                    ExecSQLNonQuery(String.Format("INSERT into chungtulq(maso,mact,loai,hoten,diachi,soctgoc,makh)values({0},{1},0, N'{2}', N'{3}', N'{4}',{5})", _
                                                        ConvertToStrSafe(Lng_MaxValue("maso", "chungtulq") + 1), _
                                                        rsItem("MaCT"), _
                                                        rsItem("ten"), _
                                                        rsItem("DiaChi"), _
                                                        rsItem("SoHieu"), _
                                                        rsItem("MaSo1")))
                                Else
                                    ExecSQLNonQuery(String.Format("UPDATE chungtulq set mact={0},loai=0,hoten=N'{1}',diachi=N'{2}',soctgoc=N'{3}',makh={4} WHERE mact={0} or soctgoc=N'{3}'", _
                                                        rsItem("MaCT"), _
                                                        IIf(Not IsDBNull(rsItem("ten")), rsItem("ten"), "..."), _
                                                        IIf(Not IsDBNull(rsItem("DiaChi")), rsItem("DiaChi"), "..."), _
                                                        rsItem("SoHieu"), _
                                                        IIf(Not IsDBNull(rsItem("MaSo1")), rsItem("MaSo1"), "0")))
                                End If
                            End While
                            If i = dong Then GoTo Loi
                            i += 1
                        End While
Loi:
                    Else
                        If ChkTaikhoan(0).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(0).Tag)) = 0 Then
                            ErrMsg(er_SHTaiKhoan1)
                            txtShTk(0).Focus()
                            Exit Sub
                        End If
                        If ChkTaikhoan(1).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(1).Tag)) = 0 Then
                            ErrMsg(er_SHVattu)
                            txtShTk(1).Focus()
                            Exit Sub
                        End If
                        If ChkTaikhoan(2).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(2).Tag)) = 0 Then
                            ErrMsg(er_SHTaiSan)
                            txtShTk(2).Focus()
                            Exit Sub
                        End If
                        If ChkTaikhoan(3).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(3).Tag)) = 0 Then
                            ErrMsg(er_SHKhachHang)
                            txtShTk(3).Focus()
                            Exit Sub
                        End If
                        If ChkTaikhoan(5).CheckState = CheckState.Checked And Strings.Len(txtShTk(4).Text) = 0 Then
                            MessageBox.Show(Ngonngu("Thiếu số hoá đơn !", "Missing number of voucher !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtShTk(4).Focus()
                            Exit Sub
                        End If
                        Dim chuyen As String = ""
                        LietKeChungtuchuyen(chuyen, sohieusang, _
                            IIf(ChkTaikhoan(0).CheckState = CheckState.Checked, txtShTk(0).Text, String.Empty), _
                            IIf(ChkTaikhoan(1).CheckState = CheckState.Checked, ConvertToDblSafe(txtShTk(1).Tag), 0), _
                            IIf(ChkTaikhoan(2).CheckState = CheckState.Checked, ConvertToDblSafe(txtShTk(2).Tag), 0), _
                            IIf(ChkTaikhoan(3).CheckState = CheckState.Checked, ConvertToDblSafe(txtShTk(3).Tag), 0), _
                            IIf(ChkTaikhoan(5).CheckState = CheckState.Checked, txtShTk(4).Text, String.Empty), _
                            MaCT, _
                            SoCTChon)
                        If SoCTChon = 0 Then GoTo Xong
                        i = 0
                        While MaCT(i) <> 0
                            rs = ExecSQLReturnDT(String.Format("SELECT t2.maso,t2.matkno,t2.matkco,t2.mact FROM (" & chuyen & ") t1 inner join chungtu t2 on t1.mact=t2.mact WHERE t2.mact={0} GROUP BY t2.maso,t2.matkno,t2.matkco,t2.mact", MaCT(i)))
                            Dim rsIndex As Integer = 0
                            While rsIndex < rs.Rows.Count
                                Dim rsItem As DataRow = rs.Rows(rsIndex)
                                rsIndex += 1 ' C15 Rs LOOP CONTROL
                                dk = IIf(Timten("sohieu", rsItem("MaTkNo"), "maso", "hethongtk") = txtShTk(0).Text, "MaTkNo", "matkco")
                                If Strings.Left(sohieusang, 4) = "3311" Then
                                    If ExecSQLNonQuery(String.Format("UPDATE chungtu set chungtu.{0}={1},chungtu.makhc={2} from chungtu inner join hethongtk on chungtu.{0}=hethongtk.maso WHERE chungtu.maso={3} and left(hethongtk.sohieu,len({4}))=N'{4}'", _
                                                           dk, _
                                                           Timten("maso", sohieusang, "sohieu", "hethongtk"), _
                                                           Timten("makh", rsItem("MaCT"), "mact", "chungtulq"), _
                                                           rsItem("MaSo"), _
                                                           txtShTk(0).Text), False) Then GoTo Loi1
                                Else
                                    If Strings.Left(sohieusang, 4) = "1311" Then
                                        If ExecSQLNonQuery(String.Format("UPDATE chungtu set chungtu.{0}={1},chungtu.makh={2} from chungtu inner join hethongtk on chungtu.{0}=hethongtk.maso WHERE chungtu.maso={3} and left(hethongtk.sohieu,len({4}))=N'{4}'", _
                                                               dk, _
                                                               Timten("maso", sohieusang, "sohieu", "hethongtk"), _
                                                               Timten("makh", rsItem("MaCT"), "mact", "chungtulq"), _
                                                               rsItem("MaSo"), _
                                                               txtShTk(0).Text), False) Then GoTo Loi1
                                    Else
Loi1:
                                        ExecSQLNonQuery(String.Format("UPDATE chungtu set chungtu.{0}={1} from chungtu inner join hethongtk on chungtu.{0}=hethongtk.maso WHERE chungtu.maso={2} and left(hethongtk.sohieu,len({3}))=N'{3}'", _
                                                            dk, _
                                                            Timten("maso", sohieusang, "sohieu", "hethongtk"), _
                                                            rsItem("MaSo"), _
                                                            txtShTk(0).Text))
                                    End If
                                End If
                            End While
                            i += 1
                        End While
                    End If
                    Command_ClickEvent(Command(0), New EventArgs())
            End Select
Xong:
            If _CboThang_1.Items.Count > 0 Then
                chiso1 = _CboThang_1.SelectedIndex
            End If
            If _CboThang_0.Items.Count > 0 Then
                chiso0 = _CboThang_0.SelectedIndex
            End If
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub DoisoChungtu(ByRef shtk As String, ByRef mvt As Integer, ByRef mts As Integer, ByRef mcn As Integer, ByRef shd As String)
        Dim mloai As Integer
        Dim uid, mct, mct1 As Integer
        Dim rs_chungtu As DataTable
        Dim ovr As Integer
        Dim sql1 As String = String.Empty
        Me.Cursor = Cursors.WaitCursor
        Dim st As Double = ConvertToDblSafe(txtShTk(5).Text)
        Dim sh As String = IIf(ChkLoai(7).CheckState = CheckState.Checked Or pPhieu > 0, "P", String.Empty)
        Dim sql As String = String.Format("SELECT MaCT,Sum(CASE WHEN MaTKCo>0 THEN SoPS ELSE 0 END) AS TPS FROM ChungTu{0} WHERE ", sh)
        If OptLK(0).Checked Then
            sql = String.Format("{0}{1}{2} GROUP BY MaCT", _
                      sql, _
                      WThang("ThangCT", CboThang(0).SelectedValue, CboThang(1).SelectedValue), _
                      (IIf(pProcessMode = 1, " AND XuLy<2", String.Empty)))
        Else
            sql = String.Format("{0}{1}{2} GROUP BY MaCT", _
                      sql, _
                      WNgay("NgayGS", Ngay(0), Ngay(1)), _
                      (IIf(pProcessMode = 1, " AND XuLy<2", String.Empty)))
        End If
        'SetSQL("MienTru", sql)
        Dim MienTru As String = sql
        If ChkLoai(13).CheckState = CheckState.Checked Then
            sql = String.Format("SELECT DISTINCT ChungTu{0}.MaCT, ChungTu{0}.SoHieu, NgayCT, NgayGS, ChungTu{0}.DienGiai{1} AS DG,TPS,[User_ID],ChungTu{0}.MaLoai,chungtu{0}.manhapxuat,chungtu{0}.thangct,chungtu{0}.maso FROM ((((ChungTu{0} INNER JOIN (" + MienTru + ") AS MienTru ON ChungTu{0}.MaCT=MienTru.MaCT) LEFT JOIN HoaDon{0} ON ChungTu{0}.MaSo=HoaDon{0}.MaSo) LEFT JOIN CTCongcudungcu ON ChungTu{0}.MaCT = CTCongcudungcu.MaCTKT) LEFT JOIN HeThongTK ON ChungTu{0}.MaTKNo = HeThongTK.MaSo) LEFT JOIN HeThongTK AS HeThongTK_1 ON ChungTu{0}.MaTKCo = HeThongTK_1.MaSo WHERE ChungTu{0}.MaLoai=1 OR ChungTu{0}.MaLoai=2 ", _
                      sh, _
                      (IIf(pNN = 1, "E", String.Empty)))
            sql1 = String.Format("SELECT DISTINCT ChungTu{0}.MaCT, ChungTu{0}.SoHieu, NgayCT, NgayGS, ChungTu{0}.DienGiai{1} AS DG,TPS,[User_ID],ChungTu{0}.MaLoai,chungtu{0}.manhapxuat FROM ((((ChungTu{0} INNER JOIN (" + MienTru + ") AS MienTru ON ChungTu{0}.MaCT=MienTru.MaCT) LEFT JOIN HoaDon{0} ON ChungTu{0}.MaSo=HoaDon{0}.MaSo) LEFT JOIN CTCongcudungcu ON ChungTu{0}.MaCT = CTCongcudungcu.MaCTKT) LEFT JOIN HeThongTK ON ChungTu{0}.MaTKNo = HeThongTK.MaSo) LEFT JOIN HeThongTK AS HeThongTK_1 ON ChungTu{0}.MaTKCo = HeThongTK_1.MaSo WHERE 1=1", _
                       sh, _
                       (IIf(pNN = 1, "E", String.Empty)))
        Else
            sql = String.Format("SELECT DISTINCT ChungTu{0}.MaCT, ChungTu{0}.SoHieu, NgayCT, NgayGS, ChungTu{0}.DienGiai{1} AS DG,TPS,[User_ID],ChungTu{0}.MaLoai,chungtu{0}.manhapxuat,chungtu{0}.thangct,chungtu{0}.maso FROM ((((ChungTu{0} INNER JOIN (" + MienTru + ") AS MienTru ON ChungTu{0}.MaCT=MienTru.MaCT) LEFT JOIN HoaDon{0} ON ChungTu{0}.MaSo=HoaDon{0}.MaSo) LEFT JOIN CTTaiSan ON ChungTu{0}.MaCT = CTTaiSan.MaCTKT) LEFT JOIN HeThongTK ON ChungTu{0}.MaTKNo = HeThongTK.MaSo) LEFT JOIN HeThongTK AS HeThongTK_1 ON ChungTu{0}.MaTKCo = HeThongTK_1.MaSo WHERE ChungTu{0}.MaLoai=1 OR ChungTu{0}.MaLoai=2 ", _
                      sh, _
                      (IIf(pNN = 1, "E", String.Empty)))
            sql1 = String.Format("SELECT DISTINCT ChungTu{0}.MaCT, ChungTu{0}.SoHieu, NgayCT, NgayGS, ChungTu{0}.DienGiai{1} AS DG,TPS,[User_ID],ChungTu{0}.MaLoai,chungtu{0}.manhapxuat FROM ((((ChungTu{0} INNER JOIN (" + MienTru + ") AS MienTru ON ChungTu{0}.MaCT=MienTru.MaCT) LEFT JOIN HoaDon{0} ON ChungTu{0}.MaSo=HoaDon{0}.MaSo) LEFT JOIN CTTaiSan ON ChungTu{0}.MaCT = CTTaiSan.MaCTKT) LEFT JOIN HeThongTK ON ChungTu{0}.MaTKNo = HeThongTK.MaSo) LEFT JOIN HeThongTK AS HeThongTK_1 ON ChungTu{0}.MaTKCo = HeThongTK_1.MaSo WHERE 1=1", _
                       sh, _
                       (IIf(pNN = 1, "E", String.Empty)))
        End If
        If shd.Length > 0 Then
            sql = String.Format("{0} AND (HoaDon{1}.SoHD LIKE '{2}%' OR ChungTu{1}.SoHieu LIKE '{2}%')", _
                      sql, _
                      sh, _
                      shd)
            sql1 = String.Format("{0} AND (HoaDon{1}.SoHD LIKE '{2}%' OR ChungTu{1}.SoHieu LIKE '{2}%')", _
                       sql1, _
                       sh, _
                       shd)
        End If
        If mvt > 0 Then
            sql = String.Format("{0} AND (ChungTu{1}.MaLoai = 1 OR ChungTu{1}.MaLoai = 2 OR ChungTu{1}.MaLoai = 8 OR ChungTu{1}.MaLoai = 13 OR ChungTu{1}.MaLoai = 14) AND (MaVattu = {2})", _
                      sql, _
                      sh, _
                      ConvertToStrSafe(mvt))
            sql1 = String.Format("{0} AND (ChungTu{1}.MaLoai = 1 OR ChungTu{1}.MaLoai = 2 OR ChungTu{1}.MaLoai = 8 OR ChungTu{1}.MaLoai = 13 OR ChungTu{1}.MaLoai = 14) AND (MaVattu = {2})", _
                       sql1, _
                       sh, _
                       ConvertToStrSafe(mvt))
        End If
        If mts > 0 Then
            sql = String.Format("{0} AND (CTTaiSan.MaTS = {1})", _
                      sql, _
                      ConvertToStrSafe(mts))
            sql1 = String.Format("{0} AND (CTTaiSan.MaTS = {1})", _
                       sql1, _
                       ConvertToStrSafe(mts))
        End If
        If mcn > 0 Then
            sql = String.Format("{0} AND (MaKH = {1} OR MaKhachHang = {1} OR MaKHC={1})", _
                      sql, _
                      ConvertToStrSafe(mcn))
            sql1 = String.Format("{0} AND (MaKH = {1} OR MaKhachHang = {1} OR MaKHC={1})", _
                       sql1, _
                       ConvertToStrSafe(mcn))
        End If
        If shtk.Length > 0 Then
            sql = String.Format("{0} AND (HethongTK.SoHieu LIKE '{1}%' OR HethongTK_1.SoHieu LIKE '{1}%'){2}", _
                      sql, _
                      shtk, _
                      (IIf(st <> 0, " AND SoPS=" & CStr(st), String.Empty)))
            sql1 = String.Format("{0} AND (HethongTK.SoHieu LIKE '{1}%' OR HethongTK_1.SoHieu LIKE '{1}%'){2}", _
                       sql1, _
                       shtk, _
                       (IIf(st <> 0, String.Format(" AND SoPS={0}", CStr(st)), String.Empty)))
            If ChkTaikhoan(7).CheckState = CheckState.Checked Then
                sql = String.Format("{0} AND ((HethongTK.TK_ID={1} OR HethongTK_1.TK_ID={2}) AND CT_ID=0)", sql, ConvertToStrSafe(TKCNPT_ID), ConvertToStrSafe(TKCNKH_ID))
                sql1 = String.Format("{0} AND ((HethongTK.TK_ID={1} OR HethongTK_1.TK_ID={2}) AND CT_ID=0)", sql1, ConvertToStrSafe(TKCNPT_ID), ConvertToStrSafe(TKCNKH_ID))
            End If
        End If
        If ChkTaikhoan(4).CheckState = CheckState.Checked And CboN(2).SelectedIndex >= 0 Then
            sql = String.Format("{0} AND ChungTu{1}.CTGS={2}", _
                      sql, _
                      sh, _
                      ConvertToStrSafe(CboN(2).SelectedValue))
            sql1 = String.Format("{0} AND ChungTu{1}.CTGS={2}", _
                       sql1, _
                       sh, _
                       ConvertToStrSafe(CboN(2).SelectedValue))
        End If
        If ChkTaikhoan(8).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(6).Tag)) > 0 Then
            sql = String.Format("{0} AND ChungTu{1}.MaTP={2}", _
                      sql, _
                      sh, _
                      ConvertToStrSafe(txtShTk(6).Tag))
            sql1 = String.Format("{0} AND ChungTu{1}.MaTP={2}", _
                       sql1, _
                       sh, _
                       ConvertToStrSafe(txtShTk(6).Tag))
        End If
        If ChkTaikhoan(6).CheckState = CheckState.Checked Then
            sql = String.Format("{0} AND (ChungTu{1}.User_ID={2})", _
                      sql, _
                      sh, _
                      ConvertToStrSafe(CboN(3).SelectedValue))
            sql1 = String.Format("{0} AND (ChungTu{1}.User_ID={2})", _
                       sql1, _
                       sh, _
                       ConvertToStrSafe(CboN(3).SelectedValue))
        End If
        Dim loaict As String = String.Empty
        For i As Integer = 0 To 14
            If i < 4 Or i > 6 Then
                If ChkLoai(i).CheckState = CheckState.Checked Then loaict = String.Format("{0}ChungTu{1}.MaLoai = {2} OR ", _
                                                                                loaict, _
                                                                                sh, _
                                                                                ConvertToStrSafe(i))
            End If
        Next
        If Not (loaict.Length = 0) Then
            If loaict.Length > 0 Then
                sql = String.Format("{0} AND ({1})", _
                          sql, _
                          Strings.Left(loaict, loaict.Length - 4))
                sql1 = String.Format("{0} AND ({1})", _
                           sql1, _
                           Strings.Left(loaict, loaict.Length - 4))
            End If
            If (ChkLoai(13).CheckState = CheckState.Checked Or ChkLoai(1).CheckState = CheckState.Checked Or ChkLoai(2).CheckState = CheckState.Checked Or ChkLoai(8).CheckState = CheckState.Checked) And CboN(0).SelectedIndex > 0 Then
                sql = String.Format("{0} AND (ChungTu{1}.MaKho={2})", _
                          sql, _
                          sh, _
                          ConvertToStrSafe(CboN(0).SelectedValue))
                sql1 = String.Format("{0} AND (ChungTu{1}.MaKho={2})", _
                           sql1, _
                           sh, _
                           ConvertToStrSafe(CboN(0).SelectedValue))
            End If
            If (ChkLoai(13).CheckState = CheckState.Checked Or ChkLoai(1).CheckState = CheckState.Checked Or ChkLoai(2).CheckState = CheckState.Checked Or ChkLoai(8).CheckState = CheckState.Checked) And CboN(1).SelectedIndex > 0 Then
                sql = String.Format("{0} AND (ChungTu{1}.MaNguon={2})", _
                          sql, _
                          sh, _
                          ConvertToStrSafe(CboN(1).SelectedValue))
                sql1 = String.Format("{0} AND (ChungTu{1}.MaNguon={2})", _
                           sql1, _
                           sh, _
                           ConvertToStrSafe(CboN(1).SelectedValue))
            End If
            If pProcessMode = 1 Then sql = String.Format("{0} AND XuLy<2 ", sql)
            sql = String.Format("{0} GROUP BY ChungTu{1}.MaCT,[User_ID],ChungTu{1}.MaLoai,ChungTu{1}.SoHieu, ChungTu{1}.NgayCT, ChungTu{1}.NgayGS, ChungTu{1}.DienGiai{2},TPS,chungtu{1}.manhapxuat,chungtu{1}.thangct,chungtu{1}.maso ", _
                      sql, _
                      sh, _
                      (IIf(pNN = 1, "E", String.Empty)))
            sql1 = String.Format("{0} GROUP BY ChungTu{1}.MaCT,[User_ID],ChungTu{1}.MaLoai,ChungTu{1}.SoHieu, ChungTu{1}.NgayCT, ChungTu{1}.NgayGS, ChungTu{1}.DienGiai{2},TPS,chungtu{1}.manhapxuat ", _
                       sql1, _
                       sh, _
                       (IIf(pNN = 1, "E", String.Empty)))
            Select Case ord
                Case 0
                    sql = String.Format("{0} ORDER BY NgayGS, ChungTu{1}.SoHieu ", sql, sh)
                    sql1 = String.Format("{0} ORDER BY NgayGS DESC, ChungTu{1}.SoHieu DESC", sql1, sh)
                Case 1
                    sql = String.Format("{0} ORDER BY NgayCT , ChungTu{1}.SoHieu ", sql, sh)
                    sql1 = String.Format("{0} ORDER BY NgayCT DESC, ChungTu{1}.SoHieu DESC", sql1, sh)
                Case 2
                    sql = String.Format("{0} ORDER BY ChungTu{1}.SoHieu ", sql, sh)
                    sql1 = String.Format("{0} ORDER BY ChungTu{1}.SoHieu DESC", sql1, sh)
            End Select
            ClearGrid(GrdChungtu, ConvertToDblSafe(GrdChungtu.Tag))
            '************************ Đổi số chứng từ *************************
            rs_chungtu = ExecSQLReturnDT(sql)
            Dim kt = String.Empty
            Dim sochungtudoi = String.Empty, kt1 As String = String.Empty
            Dim stt1, stt2 As Integer
            stt1 = 0 : stt2 = 0
            '    If frmthongbao.thongbaomoi("Mỗi ngày một phiếu ?", vbYesNo, App.ProductName) = vbYes Then
            '        Soquy = 1
            '    Else
            Soquy = 0
            '    End If
            Dim rs_chungtuIndex As Integer = 0
            Do While rs_chungtuIndex < rs_chungtu.Rows.Count
                Dim rs_chungtuItem As DataRow = rs_chungtu.Rows(rs_chungtuIndex)
                rs_chungtuIndex += 1 ' C15 Rs LOOP CONTROL
                sochungtudoi = ""
                If ConvertToStrSafe(rs_chungtuItem("maloai")) = 1 Then
                    If kt = ConvertToStrSafe(rs_chungtuItem("thangct")) Then
                        If Soquy = 1 Then
                            If rs_chungtuItem("NgayGS") IsNot Nothing Then
                                If kt1 <> ConvertToStrSafe(rs_chungtuItem("NgayGS")) Then stt1 += 1
                            End If

                        Else
                            If rs_chungtuItem("MaCT") IsNot Nothing Then
                                If kt1 <> ConvertToStrSafe(rs_chungtuItem("MaCT")) Then stt1 += 1
                            End If

                        End If
                    Else
                        stt1 = 1
                    End If
                    sochungtudoi = String.Format("PN{0}{1}", _
                                       (IIf(ConvertToStrSafe(rs_chungtuItem("thangct")) < 10, String.Format("0{0}", rs_chungtuItem("thangct")), rs_chungtuItem("thangct"))), _
                                       (IIf(stt1 >= 100, ConvertToStrSafe(stt1), (IIf(stt1 >= 10, String.Format("0{0}", stt1), String.Format("00{0}", stt1))))))
                Else
                    If kt = ConvertToStrSafe(rs_chungtuItem("thangct")) Then
                        If Soquy = 1 Then
                            If rs_chungtuItem("NgayGS") IsNot Nothing Then
                                If kt1 <> ConvertToStrSafe(rs_chungtuItem("NgayGS")) Then stt2 += 1
                            End If

                        Else
                            If rs_chungtuItem("MaCT") IsNot Nothing Then
                                If kt1 <> ConvertToStrSafe(rs_chungtuItem("MaCT")) Then stt2 += 1
                            End If

                        End If
                    Else
                        stt2 = 1
                    End If
                    sochungtudoi = String.Format("PX{0}{1}", _
                                       (IIf(ConvertToStrSafe(rs_chungtuItem("thangct")) < 10, String.Format("0{0}", rs_chungtuItem("thangct")), rs_chungtuItem("thangct"))), _
                                       (IIf(stt2 >= 100, ConvertToStrSafe(stt2), (IIf(stt2 >= 10, String.Format("0{0}", stt2), String.Format("00{0}", stt2))))))
                End If
                ExecSQLNonQuery(String.Format("UPDATE chungtu set manhapxuat=N'{0}' WHERE maso={1}", sochungtudoi, rs_chungtuItem("MaSo")))
                If rs_chungtuItem("thangct") IsNot Nothing Then
                    kt = rs_chungtuItem("thangct")
                End If

                If Soquy = 1 Then
                    If rs_chungtuItem("NgayGS") IsNot Nothing Then
                        kt1 = rs_chungtuItem("NgayGS")
                    End If

                Else
                    If rs_chungtuItem("MaCT") IsNot Nothing Then
                        kt1 = rs_chungtuItem("MaCT")
                    End If

                End If
                'rs_chungtu.MoveNext()
            Loop
            rs_chungtu = Nothing
            '************************* Load dữ liệu lên lưới ***********************
            rs_chungtu = ExecSQLReturnDT(sql1)
            rs_chungtuIndex = 0
            Do While rs_chungtuIndex < rs_chungtu.Rows.Count
                Dim rs_chungtuItem As DataRow = rs_chungtu.Rows(rs_chungtuIndex)
                rs_chungtuIndex += 1 ' C15 Rs LOOP CONTROL
                If mct <> ConvertToStrSafe(rs_chungtuItem("MaCT")) Then
                    If rs_chungtuItem("MaCT") IsNot Nothing Then
                        mct = rs_chungtuItem("MaCT")
                    End If

                    If rs_chungtuItem("User_ID") IsNot Nothing Then
                        uid = rs_chungtuItem("User_ID")
                    End If

                Else
                    If uid <> ConvertToStrSafe(rs_chungtuItem("User_ID")) Or mloai <> ConvertToStrSafe(rs_chungtuItem("maloai")) Then
                        mct1 = Lng_MaxValue("MaCT", String.Format("ChungTu{0}", sh)) + 1
                        ExecSQLNonQuery(String.Format("UPDATE ChungTu{0} SET MaCT={1} WHERE MaCT={2} AND User_ID={3}", _
                                            sh, _
                                            ConvertToStrSafe(mct1), _
                                            ConvertToStrSafe(mct), _
                                            rs_chungtuItem("User_ID")))
                        mct = mct1
                        If rs_chungtuItem("User_ID") IsNot Nothing Then
                            uid = rs_chungtuItem("User_ID")
                        End If
                        If rs_chungtuItem("maloai") IsNot Nothing Then
                            mloai = rs_chungtuItem("maloai")
                        End If

                    End If
                End If
                If GrdChungtu.Rows < MaxGridRow Then
                    GrdChungtu.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}", _
                                           rs_chungtuItem("manhapxuat"), _
                                           Chr(9), _
                                           Format(ConvertToDateSafe(rs_chungtuItem("NgayCT")), Mask_D), _
                                           Format(ConvertToDateSafe(rs_chungtuItem("NgayGS")), Mask_D), _
                                           ConvertToStrSafe(rs_chungtuItem("dg")), _
                                           Format(rs_chungtuItem("tps"), Mask_0), _
                                           ConvertToStrSafe(mct)), 0)
                Else
                    ovr = 1
                End If
                'rs_chungtu.MoveNext()
            Loop
            If rs_chungtu.Rows.Count > 0 Then
                If Row >= rs_chungtu.Rows.Count Then
                    Row = rs_chungtu.Rows.Count - 1
                End If
            Else
                Row = 0
            End If
            'GrdChungtu.Rows = iif(rs_chungtu.Rows.Count > ConvertToDblSafe(GrdChungtu.Tag), iif(rs_chungtu.Rows.Count > MaxGridRow, MaxGridRow, rs_chungtu.Rows.Count), ConvertToDblSafe(GrdChungtu.Tag))
            LbSoCT.Text = ConvertToStrSafe(rs_chungtu.Rows.Count)
            GrdChungtu.Col = 0
            ''rs_chungtu.Close()
            rs_chungtu = Nothing
            On Error Resume Next
            'GrdChungtu.Row = ConvertToDblSafe(Row)
            'GrdChungtu_ClickEvent(GrdChungtu, New EventArgs())
            'If Not GrdChungtu.get_RowIsVisible(ConvertToDblSafe(Row)) Then GrdChungtu.TopRow = ConvertToDblSafe(Row - 8)
            On Error GoTo 0
            If ovr > 0 Then ErrMsg(er_NhieuCT)
        End If
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' Hiện cửa sổ chọn tài khoản
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CmdTK_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _CmdTK_2.Click, _CmdTK_3.Click, _CmdTK_1.Click, _CmdTK_0.Click, _CmdTK_6.Click
        Dim Index As Integer = Array.IndexOf(CmdTK, eventSender)
        Me.Cursor = Cursors.WaitCursor
        Select Case Index
            Case 0
                FrmTaikhoan.initOption = txtShTk(0).Text
                txtShTk(0).Text = FrmTaikhoan.ChonTk(txtShTk(0).Text)
            Case 1
                FrmTaikhoan.initOption = txtShTk(1).Text
                txtShTk(1).Text = FrmVattu.ChonVattu(txtShTk(1).Text)
            Case 2
                FrmTaikhoan.initOption = txtShTk(2).Text
                txtShTk(2).Text = frmDSTaiSan.ChonTaiSan(txtShTk(2).Text, CboThang(0).SelectedValue, CboThang(1).SelectedValue)
            Case 3
                FrmTaikhoan.initOption = txtShTk(3).Text
                txtShTk(3).Text = FrmKhachHang.ChonKhachHang(txtShTk(3).Text)
            Case 6
                If Strings.Left(txtShTk(0).Text, 4) = "1422" Then
                    txtShTk(6).Text = FrmHD.ChonHD(txtShTk(6).Text)
                Else
                    txtShTk(6).Text = FrmTP.ChonTP(txtShTk(6).Text)
                End If
        End Select
        Me.Cursor = Cursors.Default
        txtShTk(Index).Focus()
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Xoaloai()
        If tracu Then
            ChkLoai(0).CheckState = CheckState.Checked
            ChkLoai(3).CheckState = CheckState.Checked
            ChkLoai(12).CheckState = CheckState.Checked
            ChkLoai(14).CheckState = CheckState.Checked
        Else
            If tscc = 1 Then
                ChkLoai(9).CheckState = CheckState.Checked
                ChkLoai(10).CheckState = CheckState.Checked
                ChkLoai(11).CheckState = CheckState.Checked
                ChkLoai(12).CheckState = CheckState.Checked
            ElseIf tscc = 2 Then
                ChkLoai(0).CheckState = CheckState.Checked
                ChkLoai(1).CheckState = CheckState.Checked
                ChkLoai(2).CheckState = CheckState.Checked
                ChkLoai(13).CheckState = CheckState.Checked
                ChkLoai(14).CheckState = CheckState.Checked
                ChkLoai(15).CheckState = CheckState.Checked
                ChkLoai(16).CheckState = CheckState.Checked
            Else
                ChkLoai(loai).CheckState = CheckState.Checked
            End If
        End If
        If Lietke Then
            Me.Refresh()
            Command_ClickEvent(Command(0), New EventArgs())
            Lietke = False
        Else
            SetFont(Me)
        End If
        KiemtraUser()
        Khoaquyen()
    End Sub
    Sub Xoaloai()
        _ChkLoai_0.CheckState = CheckState.Unchecked
        _ChkLoai_1.CheckState = CheckState.Unchecked
        _ChkLoai_2.CheckState = CheckState.Unchecked
        _ChkLoai_3.CheckState = CheckState.Unchecked
        _ChkLoai_7.CheckState = CheckState.Unchecked
        _ChkLoai_8.CheckState = CheckState.Unchecked
        _ChkLoai_9.CheckState = CheckState.Unchecked
        _ChkLoai_10.CheckState = CheckState.Unchecked
        _ChkLoai_11.CheckState = CheckState.Unchecked
        _ChkLoai_12.CheckState = CheckState.Unchecked
        _ChkLoai_13.CheckState = CheckState.Unchecked
        _ChkLoai_14.CheckState = CheckState.Unchecked
        _ChkLoai_15.CheckState = CheckState.Unchecked
        _ChkLoai_16.CheckState = CheckState.Unchecked
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmDsCT_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.L
                    Command(0).Focus()
                    'Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.C
                    Command(1).Focus()
                    'Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.V
                    Command(2).Focus()
                    'Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.X
                    Command(3).Focus()
                    'Command_ClickEvent(Command(3), New EventArgs())
                Case Keys.I
                    Command(4).Focus()
                    'Command_ClickEvent(Command(4), New EventArgs())
                Case Keys.S
                    If Command(5).Visible Then
                        Command(5).Focus()
                        'Command_ClickEvent(Command(5), New EventArgs())
                    End If
                Case Keys.D
                    If Command(6).Visible Then
                        Command(6).Focus()
                        'Command_ClickEvent(Command(6), New EventArgs())
                    End If
                Case Keys.P
                    If Command(7).Visible Then
                        Command(7).Focus()
                        'Command_ClickEvent(Command(7), New EventArgs())
                    End If
            End Select
        End If
        If (Shift And 2) > 0 And eventArgs.KeyCode = Keys.A Then GridSelAll(GrdChungtu)
        If eventArgs.KeyCode = Keys.Escape Then Command_ClickEvent(Command(2), New EventArgs())


    End Sub
    ''' <summary>
    ''' Khởi tạo cửa sổ
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>   
    Private Sub FrmDsCT_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            If pPhieu > 0 Then Me.Text = Ngonngu("Danh sách các phiếu chưa vào sổ", "Instrument is not in the book list")
            Command(5).Visible = (pPhieu > 0)
            Command(7).Visible = (ChkLoai(1).CheckState = CheckState.Checked) Or (ChkLoai(2).CheckState = CheckState.Checked)
            ChkLoai(7).Enabled = pBaoGia > 0 And ((pThuChiNhapXuat And pPhieu = 1) Or (Not pThuChiNhapXuat And pPhieu = 0)) 'vancuong edit 1/4/18
            ColumnSetUp(GrdChungtu, 0, 1350, 2)
            ColumnSetUp(GrdChungtu, 1, 950, 2)
            ColumnSetUp(GrdChungtu, 2, 950, 2)
            ColumnSetUp(GrdChungtu, 3, 4800, 0)
            ColumnSetUp(GrdChungtu, 4, 1260, 4)
            ColumnSetUp(GrdChungtu, 5, 1, 0)
            AddMonthToCbo(CboThang(0))
            AddMonthToCbo(CboThang(1))

            GrdChungtu.AllowMultiselect = True

            For chi_so As Integer = 0 To 1
                InitDateVars(MedNgay(chi_so), Ngay(chi_so))
            Next
            'MaCTChon = 0
            'GrdChungtu.Row = 0
            'GrdChungtu_ClickEvent(GrdChungtu, New EventArgs())
            Lietke = False
            Text = SetFormTitle(Text)
            ord = 0
            Int_RecsetToCbo("SELECT MaSo As F2,SoHieu As F1 FROM CTGhiSo ORDER BY SoHieu", CboN(2))

            'van.nguyen 13 Nov 2011
            'Dim MienTru = String.Format("SELECT MaSo As F2,SoHieu + ' - ' + DienGiai As F1 FROM NguonNhapXuat ORDER BY SoHieu  UNION SELECT 0, N'{0}' FROM License", (" Toàn bộ"))
            'Int_RecsetToCbo(String.Format("SELECT * FROM  ({0}) AS MienTru ORDER BY F1", MienTru), CboN(1))
            'MienTru = "SELECT MaSo As F2,TenKho As F1 FROM KhoHang ORDER BY TenKho  UNION SELECT 0,' Toàn bộ' FROM License"
            'Int_RecsetToCbo(String.Format("SELECT * FROM  ({0}) AS MienTru ORDER BY F1", MienTru), CboN(0))
            'Int_RecsetToCbo("SELECT MaSo As F2, TenNSD As F1 FROM Users ORDER BY TenNSD", CboN(3))

            Dim MienTru = String.Format("SELECT MaSo As F2,SoHieu + ' - ' + DienGiai As F1 FROM NguonNhapXuat  UNION SELECT 0, N'{0}' FROM License", Ngonngu(" Toàn bộ", " All"))
            Int_RecsetToCbo(MienTru, CboN(1))
            MienTru = "SELECT MaSo As F2,TenKho As F1 FROM KhoHang  UNION SELECT 0,N'" & Ngonngu("Toàn bộ", "All") & "' FROM License order by MaSo"
            Int_RecsetToCbo(MienTru, CboN(0))
            Int_RecsetToCbo("SELECT MaSo As F2, TenNSD As F1 FROM Users ORDER BY TenNSD", CboN(3))

            ChkTaikhoan(4).Visible = (pSoKT Mod 100 >= 10)
            CboN(2).Visible = (pSoKT Mod 100 >= 10)
            ChkTaikhoan(8).Enabled = (pDTTP <> 0)
            txtShTk(6).Enabled = (pDTTP <> 0)
            LbTenTk(6).Enabled = (pDTTP <> 0)
            If chiso0 <> -1 And _CboThang_0.Items.Count > 0 Then
                _CboThang_0.SelectedIndex = chiso0
            End If
            If chiso1 <> -1 And _CboThang_1.Items.Count > 0 Then
                _CboThang_1.SelectedIndex = chiso1
            End If
            If chon > 0 Then GrdChungtu.Row = chon : GrdChungtu_ClickEvent(GrdChungtu, New EventArgs)
        Catch ex As Exception
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try        
    End Sub
    '======================================================================================
    ' Nhớ mã số CT được chọn
    '======================================================================================
    Private Sub GrdChungtu_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdChungtu.Click
        Row = GrdChungtu.Row
        SetGridIndex(GrdChungtu, Row)
        With GrdChungtu
            .Col = 5
            MaCTChon = IIf(.CtlText.length = 0, 0, ConvertToDblSafe(.CtlText))
            .Col = 0
        End With
    End Sub

    Private Sub GrdChungtu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdChungtu.KeyDown
        If e.KeyValue = Keys.ShiftKey Then Command_ClickEvent(Command(1), New EventArgs())
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdChungtu_KeyPressEvent(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles GrdChungtu.KeyPress
        GrdChungtu_ClickEvent(GrdChungtu, New EventArgs())
        If eventArgs.KeyChar = Chr(Keys.ShiftKey) Then Command_ClickEvent(Command(1), New EventArgs())
    End Sub

    'Private Sub GrdChungtu_KeyUpEvent(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles GrdChungtu.KeyUp
    '    If eventArgs.KeyCode = 37 Or eventArgs.KeyCode = 38 Or eventArgs.KeyCode = 39 Or eventArgs.KeyCode = 40 Then SetGridIndex(GrdChungtu, GrdChungtu.Row)
    'End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdChungtu_MouseDownEvent(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles GrdChungtu.MouseDown
        If eventArgs.Button = MouseButtons.Right Then
            SearchObj(1, , GrdChungtu, GrdChungtu.Col)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private isInitializingComponent As Boolean

    Private Sub SSOpt_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _SSOpt_2.CheckedChanged, _SSOpt_1.CheckedChanged, _SSOpt_0.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(SSOpt, eventSender)
            ord = Index
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShTk_5.Enter, _txtShTk_0.Enter, _txtShTk_2.Enter, _txtShTk_4.Enter, _txtShTk_6.Enter, _txtShTk_1.Enter, _txtShTk_3.Enter
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        txtShTk(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtShTk_5.KeyPress, _txtShTk_0.KeyPress, _txtShTk_2.KeyPress, _txtShTk_4.KeyPress, _txtShTk_6.KeyPress, _txtShTk_1.KeyPress, _txtShTk_3.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        If Index = 5 Then KeyProcess(txtShTk(Index), KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    '======================================================================================
    ' Kiểm tra số hiệu tài khoản
    '======================================================================================
    Private Sub txtShTk_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtShTk_5.Leave, _txtShTk_0.Leave, _txtShTk_2.Leave, _txtShTk_4.Leave, _txtShTk_6.Leave, _txtShTk_1.Leave, _txtShTk_3.Leave
        Dim Index As Integer = Array.IndexOf(txtShTk, eventSender)
        Dim st As String = String.Empty
        Dim id As Integer
        Dim mtk As Integer = 0
        Select Case Index
            Case 0
                LbTenTk(0).Text = tentk(txtShTk(0).Text, mtk)
                id = GetTK_ID("", mtk)
                ChkTaikhoan(7).Visible = (id = TKCNKH_ID Or id = TKCNPT_ID)
                Command(6).Visible = ChkTaikhoan(0).CheckState = CheckState.Checked And Strings.Left(txtShTk(0).Text, 1) <> "." And Strings.Len(txtShTk(0).Text) <> 0
                If Strings.Left(txtShTk(0).Text, 4) = "1422" Then
                    ChkTaikhoan(8).Text = Ngonngu("Hợp đồng phát sinh", "Con tract")
                Else
                    ChkTaikhoan(8).Text = Ngonngu("Công trình, sản phẩm", "Construction, products")
                End If
            Case 1
                LbTenTk(1).Text = TenVT(txtShTk(1).Text, mtk, st)
            Case 2
                LbTenTk(2).Text = TenTS(txtShTk(2).Text, mtk)
            Case 3
                LbTenTk(3).Text = TenKH(txtShTk(3).Text, mtk)
            Case 5
                txtShTk(5).Text = Format(txtShTk(5).Text, Mask_0)
            Case 6
                If Strings.Left(txtShTk(0).Text, 4) = "1422" Then
                    LbTenTk(6).Text = TenVV(SoHieu2MaSo(txtShTk(6).Text, "DoituongCT"), mtk)
                Else
                    LbTenTk(6).Text = TenTP(txtShTk(6).Text, mtk)
                End If
        End Select
        txtShTk(Index).Tag = ConvertToStrSafe(mtk)
    End Sub
    '======================================================================================
    ' Liệt kê chứng từ
    '======================================================================================
    Private Sub LietKeChungtu(ByRef shtk As String, ByRef mvt As Integer, ByRef mts As Integer, ByRef mcn As Integer, ByRef shd As String)
        If FrmChungtu.flag <> 1 Then
            FrmChungtu.flag = 2
        End If
        Dim mloai As Integer
        Dim uid, mct, mct1 As Integer
        Dim rs_chungtu As DataTable
        Dim ovr As Integer
        Dim lochd As Boolean = ChkTaikhoan(0).CheckState = CheckState.Checked And Strings.Left(txtShTk(0).Text, 4) = "1422" And ChkTaikhoan(8).CheckState = CheckState.Checked
        Me.Cursor = Cursors.WaitCursor
        Dim st As Double = ConvertToDblSafe(txtShTk(5).Text)
        Dim sh As String = IIf(ChkLoai(7).CheckState = CheckState.Checked Or pPhieu > 0, "P", String.Empty)
        Dim sql As String = String.Format("SELECT MaCT,Sum(CASE WHEN MaTKCo>0 and (tk.loai<>0 or tk.sohieu like '003%') THEN SoPS ELSE 0 END) AS TPS FROM ChungTu{0} ct left join hethongtk tk on ct.matkco=tk.maso WHERE ", sh)
        If OptLK(0).Checked Then
            sql = String.Format("{0}{1}{2} GROUP BY MaCT", _
                      sql, _
                      WThang("ThangCT", CboThang(0).SelectedValue, CboThang(1).SelectedValue), _
                      (IIf(pProcessMode = 1, " AND XuLy<2", String.Empty)))
        Else
            'van.nguyen 29-Nov-2011
            Ngay(0) = IIf(Ngay(0) = "#12:00:00 AM#", MedNgay(0).Text, Ngay(0))
            Ngay(1) = IIf(Ngay(1) = "#12:00:00 AM#", MedNgay(1).Text, Ngay(1))
            sql = String.Format("{0}{1}{2} GROUP BY MaCT", _
                      sql, _
                      WNgay("NgayGS", Ngay(0), Ngay(1)), _
                      (IIf(pProcessMode = 1, " AND XuLy<2", String.Empty)))
        End If
        ' SetSQL("MienTru", sql)
        Dim Mientru As String = sql
        If ChkLoai(13).CheckState = CheckState.Checked Then
            sql = String.Format("SELECT DISTINCT ChungTu{0}.MaCT, ChungTu{0}.SoHieu, NgayCT, NgayGS, ChungTu{0}.DienGiai{1} AS DG,TPS,[User_ID],ChungTu{0}.MaLoai FROM ((((ChungTu{0} INNER JOIN (" + Mientru + ") AS MienTru ON ChungTu{0}.MaCT=MienTru.MaCT) LEFT JOIN HoaDon{0} ON ChungTu{0}.MaSo=HoaDon{0}.MaSo) LEFT JOIN CTCongcudungcu ON ChungTu{0}.MaCT = CTCongcudungcu.MaCTKT) LEFT JOIN HeThongTK ON ChungTu{0}.MaTKNo = HeThongTK.MaSo) LEFT JOIN HeThongTK AS HeThongTK_1 ON ChungTu{0}.MaTKCo = HeThongTK_1.MaSo Where (1=1) ", _
                      sh, _
                      (IIf(pNN = 1, String.Empty, String.Empty)))
        Else
            sql = String.Format("SELECT DISTINCT ChungTu{0}.MaCT, ChungTu{0}.SoHieu, NgayCT, NgayGS, ChungTu{0}.DienGiai{1} AS DG,TPS,[User_ID],ChungTu{0}.MaLoai FROM ((((ChungTu{0} INNER JOIN (" + Mientru + ") AS MienTru ON ChungTu{0}.MaCT=MienTru.MaCT) LEFT JOIN HoaDon{0} ON ChungTu{0}.MaSo=HoaDon{0}.MaSo) LEFT JOIN CTTaiSan ON ChungTu{0}.MaCT = CTTaiSan.MaCTKT) LEFT JOIN HeThongTK ON ChungTu{0}.MaTKNo = HeThongTK.MaSo) LEFT JOIN HeThongTK AS HeThongTK_1 ON ChungTu{0}.MaTKCo = HeThongTK_1.MaSo Where (1=1) ", _
                      sh, _
                      (IIf(pNN = 1, String.Empty, String.Empty)))
        End If

        If (FrmMNCongCu.Visible And ChkLoai(0).CheckState = CheckState.Checked) Or tscc = 2 Then sql = String.Format("{0} and (left(hethongtk.sohieu,3)='153' or left(hethongtk_1.sohieu,3)='153' or left(hethongtk.sohieu,4)='1421' or left(hethongtk_1.sohieu,4)='1421' or left(hethongtk.sohieu,3)='242' or left(hethongtk_1.sohieu,3)='242')", sql)
        If FrmMNCongCu.Visible Then
            If cuongdauky = 6 Then
                sql = String.Format("{0} and (left(hethongtk.sohieu,3)='153' or left(hethongtk_1.sohieu,3)='153') ", sql)
            ElseIf cuongdauky = 7 Then
                sql = String.Format("{0} and (left(hethongtk.sohieu,4)='1421' or left(hethongtk_1.sohieu,4)='1421' or left(hethongtk.sohieu,3)='242' or left(hethongtk_1.sohieu,3)='242')", sql)
            End If
        End If
        If FrmMNNhanVien.Visible Then sql = String.Format("{0} and (left(hethongtk.sohieu,3)='334' or left(hethongtk.sohieu,3)='338' or left(hethongtk_1.sohieu,3)='334' or left(hethongtk_1.sohieu,3)='338')", sql)
        If shd.Length > 0 Then sql = String.Format("{0} AND (HoaDon{1}.SoHD LIKE '{2}%' OR ChungTu{1}.SoHieu LIKE '{2}%')", sql, sh, shd)
        If mvt > 0 Then
            If lochd Then
                sql = String.Format("{0} AND (MaVattu = {1})", sql, ConvertToStrSafe(mvt))
            Else
                sql = String.Format("{0} AND (ChungTu{1}.MaLoai = 1 OR ChungTu{1}.MaLoai = 2 OR ChungTu{1}.MaLoai = 8 OR ChungTu{1}.MaLoai = 13 OR ChungTu{1}.MaLoai = 14) AND (MaVattu = {2})", sql, sh, ConvertToStrSafe(mvt))
            End If
        End If
        If mts > 0 Then sql = String.Format("{0} AND (CTTaiSan.MaTS = {1})", sql, ConvertToStrSafe(mts))
        If mcn > 0 Then sql = String.Format("{0} AND (MaKH = {1} OR MaKhachHang = {1} OR MaKHC={1})", sql, ConvertToStrSafe(mcn))
        If shtk.Length > 0 Then
            sql = String.Format("{0} AND (HethongTK.SoHieu LIKE '{1}%' OR HethongTK_1.SoHieu LIKE '{1}%'){2}", _
                      sql, _
                      shtk, _
                      (IIf(st <> 0, " AND SoPS=" & CStr(st), String.Empty)))
            If ChkTaikhoan(7).CheckState = CheckState.Checked Then sql = String.Format("{0} AND ((HethongTK.TK_ID={1} OR HethongTK_1.TK_ID={2}) AND CT_ID=0)", sql, ConvertToStrSafe(TKCNPT_ID), ConvertToStrSafe(TKCNKH_ID))
        End If
        If ChkTaikhoan(4).CheckState = CheckState.Checked And CboN(2).SelectedIndex >= 0 Then
            sql = String.Format("{0} AND ChungTu{1}.CTGS={2}", sql, sh, ConvertToStrSafe(CboN(2).SelectedValue))
        End If
        If ChkTaikhoan(8).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(6).Tag)) > 0 Then
            If lochd Then
                sql = String.Format("{0} AND (MaVattu = {1})", sql, ConvertToStrSafe(mvt))
            Else
                sql = String.Format("{0} AND ChungTu{1}.MaTP={2}", sql, sh, ConvertToStrSafe(txtShTk(6).Tag))
            End If
        End If
        If ChkTaikhoan(6).CheckState = CheckState.Checked Then sql = String.Format("{0} AND (ChungTu{1}.User_ID={2})", sql, sh, ConvertToStrSafe(CboN(3).SelectedValue))
        Dim loaict As String = String.Empty
        For i As Integer = 0 To 16
            If i < 4 Or i > 6 Then
                If ChkLoai(i).CheckState = CheckState.Checked Then loaict = String.Format("{0}ChungTu{1}.MaLoai = {2} OR ", loaict, sh, ConvertToStrSafe(i))
            End If
        Next
        If Not (loaict.Length = 0) Then
            If loaict.Length > 0 Then sql = String.Format("{0} AND ({1})", sql, Strings.Left(loaict, loaict.Length - 4))
            If (ChkLoai(13).CheckState = CheckState.Checked Or ChkLoai(1).CheckState = CheckState.Checked Or ChkLoai(2).CheckState = CheckState.Checked Or ChkLoai(8).CheckState = CheckState.Checked) And CboN(0).SelectedIndex > 0 Then sql = String.Format("{0} AND (ChungTu{1}.MaKho={2})", sql, sh, ConvertToStrSafe(CboN(0).SelectedValue))
            If (ChkLoai(13).CheckState = CheckState.Checked Or ChkLoai(1).CheckState = CheckState.Checked Or ChkLoai(2).CheckState = CheckState.Checked Or ChkLoai(8).CheckState = CheckState.Checked) And CboN(1).SelectedIndex > 0 Then sql = String.Format("{0} AND (ChungTu{1}.MaNguon={2})", sql, sh, ConvertToStrSafe(CboN(1).SelectedValue))
            If pProcessMode = 1 Then sql = String.Format("{0} AND XuLy<2 ", sql)
            sql = String.Format("{0} GROUP BY ChungTu{1}.MaCT,[User_ID],ChungTu{1}.MaLoai,ChungTu{1}.SoHieu, ChungTu{1}.NgayCT, ChungTu{1}.NgayGS, ChungTu{1}.DienGiai{2},TPS ", sql, sh, (IIf(pNN = 1, String.Empty, String.Empty)))
            Select Case ord
                Case 0
                    sql = String.Format("{0} ORDER BY NgayGS DESC, ChungTu{1}.SoHieu DESC", sql, sh)
                Case 1
                    sql = String.Format("{0} ORDER BY NgayCT DESC, ChungTu{1}.SoHieu DESC", sql, sh)
                Case 2
                    sql = String.Format("{0} ORDER BY ChungTu{1}.SoHieu DESC", sql, sh)
            End Select
            ClearGrid(GrdChungtu, ConvertToDblSafe(GrdChungtu.Tag))
            rs_chungtu = ExecSQLReturnDT(sql)
            Dim rs_chungtuIndex As Integer = 0
            Do While rs_chungtuIndex < rs_chungtu.Rows.Count
                Dim rs_chungtuItem As DataRow = rs_chungtu.Rows(rs_chungtuIndex)
                rs_chungtuIndex += 1 ' C15 Rs LOOP CONTROL
                If mct <> ConvertToStrSafe(rs_chungtuItem("MaCT")) Then
                    If rs_chungtuItem("MaCT") IsNot Nothing Then
                        mct = rs_chungtuItem("MaCT")
                    End If
                    If rs_chungtuItem("User_ID") IsNot Nothing Then
                        uid = rs_chungtuItem("User_ID")
                    End If

                Else
                    If uid <> ConvertToStrSafe(rs_chungtuItem("User_ID")) Or mloai <> ConvertToStrSafe(rs_chungtuItem("maloai")) Then
                        mct1 = Lng_MaxValue("MaCT", String.Format("ChungTu{0}", sh)) + 1
                        ExecSQLNonQuery(String.Format("UPDATE ChungTu{0} SET MaCT={1} WHERE MaCT={2} AND User_ID={3}", sh, ConvertToStrSafe(mct1), ConvertToStrSafe(mct), rs_chungtuItem("User_ID")))
                        mct = mct1
                        If rs_chungtuItem("maloai") IsNot Nothing Then
                            mloai = rs_chungtuItem("maloai")
                        End If
                        If rs_chungtuItem("User_ID") IsNot Nothing Then
                            uid = rs_chungtuItem("User_ID")
                        End If


                    End If
                End If
                'If GrdChungtu.Rows < MaxGridRow Then

                GrdChungtu.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}", _
                                       rs_chungtuItem("SoHieu"), _
                                       Chr(9), _
                                       Format(ConvertToDateSafe(rs_chungtuItem("NgayCT")), Mask_D), _
                                       Format(ConvertToDateSafe(rs_chungtuItem("NgayGS")), Mask_D), _
                                       ConvertToStrSafe(rs_chungtuItem("dg")), _
                                       Format(rs_chungtuItem("tps"), Mask_0), _
                                       ConvertToStrSafe(mct)), 0)
                'Else
                'ovr = 1
                'End If
                'rs_chungtu.MoveNext()
            Loop
            If rs_chungtu.Rows.Count > 0 Then
                If Row >= rs_chungtu.Rows.Count Then
                    Row = rs_chungtu.Rows.Count - 1
                End If
            Else
                Row = 0
            End If
            'GrdChungtu.Rows = iif(rs_chungtu.Rows.Count > ConvertToDblSafe(GrdChungtu.Tag), iif(rs_chungtu.Rows.Count > MaxGridRow, MaxGridRow, rs_chungtu.Rows.Count), ConvertToDblSafe(GrdChungtu.Tag))
            LbSoCT.Text = ConvertToStrSafe(rs_chungtu.Rows.Count)
            GrdChungtu.Col = 0

            rs_chungtu = Nothing
            On Error Resume Next
            'GrdChungtu.Row = ConvertToDblSafe(Row)
            'GrdChungtu_ClickEvent(GrdChungtu, New EventArgs())

            On Error GoTo 0
            If ovr > 0 Then ErrMsg(er_NhieuCT)
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub LietKeChungtuchuyen(ByRef sql As String, ByRef sohieusang As String, ByRef shtk As String, ByRef mvt As Integer, ByRef mts As Integer, ByRef mcn As Integer, ByRef shd As String, ByRef MaCT() As Integer, ByRef SoCTChon As Integer)
        Dim mloai As Integer
        Dim uid, mct, mct1 As Integer
        Me.Cursor = Cursors.WaitCursor
        Dim st As Double = ConvertToDblSafe(txtShTk(5).Text)
        Dim sh As String = IIf(ChkLoai(7).CheckState = CheckState.Checked Or pPhieu > 0, "P", String.Empty)
        sql = String.Format("SELECT MaCT,Sum(CASE WHEN MaTKCo>0 THEN SoPS ELSE 0 END) AS TPS FROM ChungTu{0} WHERE ", sh)
        If OptLK(0).Checked Then
            sql = String.Format("{0}{1}{2} GROUP BY MaCT", sql, WThang("ThangCT", CboThang(0).SelectedIndex, CboThang(1).SelectedIndex), (IIf(pProcessMode = 1, " AND XuLy<2", String.Empty)))
        Else
            sql = String.Format("{0}{1}{2} GROUP BY MaCT", sql, WNgay("NgayGS", Ngay(0), Ngay(1)), (IIf(pProcessMode = 1, " AND XuLy<2", String.Empty)))
        End If
        If ChkLoai(14).CheckState = CheckState.Checked Then
            sql = String.Format("SELECT DISTINCT ChungTu{0}.MaSo,ChungTu{0}.MaCT, ChungTu{0}.SoHieu, NgayCT, NgayGS, ChungTu{0}.DienGiai{1} AS DG,TPS,[User_ID],ChungTu{0}.MaLoai FROM ((((ChungTu{0} INNER JOIN (" & sql & ") as MienTru1 ON ChungTu{0}.MaCT=MienTru1.MaCT) LEFT JOIN HoaDon{0} ON ChungTu{0}.MaSo=HoaDon{0}.MaSo) LEFT JOIN CTCongcudungcu ON ChungTu{0}.MaCT = CTCongcudungcu.MaCTKT) LEFT JOIN HeThongTK ON ChungTu{0}.MaTKNo = HeThongTK.MaSo) LEFT JOIN HeThongTK AS HeThongTK_1 ON ChungTu{0}.MaTKCo = HeThongTK_1.MaSo WHERE (1=1)", sh, (IIf(pNN = 1, "E", String.Empty)))
        Else
            sql = String.Format("SELECT DISTINCT ChungTu{0}.MaSo,ChungTu{0}.MaCT, ChungTu{0}.SoHieu, NgayCT, NgayGS, ChungTu{0}.DienGiai{1} AS DG,TPS,[User_ID],ChungTu{0}.MaLoai FROM ((((ChungTu{0} INNER JOIN (" & sql & ") as MienTru1 ON ChungTu{0}.MaCT=MienTru1.MaCT) LEFT JOIN HoaDon{0} ON ChungTu{0}.MaSo=HoaDon{0}.MaSo) LEFT JOIN CTTaiSan ON ChungTu{0}.MaCT = CTTaiSan.MaCTKT) LEFT JOIN HeThongTK ON ChungTu{0}.MaTKNo = HeThongTK.MaSo) LEFT JOIN HeThongTK AS HeThongTK_1 ON ChungTu{0}.MaTKCo = HeThongTK_1.MaSo WHERE (1=1)", sh, (IIf(pNN = 1, "E", String.Empty)))
        End If
        If shd.Length > 0 Then sql = String.Format("{0} AND (HoaDon{1}.SoHD LIKE '{2}%' OR ChungTu{1}.SoHieu LIKE '{2}%')", sql, sh, shd)
        If mvt > 0 Then sql = String.Format("{0} AND (ChungTu{1}.MaLoai = 1 OR ChungTu{1}.MaLoai = 2 OR ChungTu{1}.MaLoai = 8) AND (MaVattu = {2})", sql, sh, ConvertToStrSafe(mvt))
        If mts > 0 Then sql = String.Format("{0} AND (CTTaiSan.MaTS = {1})", sql, ConvertToStrSafe(mts))
        If mcn > 0 Then sql = String.Format("{0} AND (MaKH = {1} OR MaKhachHang = {1} OR MaKHC={1})", sql, ConvertToStrSafe(mcn))
        If shtk.Length > 0 Then
            sql = String.Format("{0} AND (HethongTK.SoHieu LIKE '{1}%' OR HethongTK_1.SoHieu LIKE '{1}%'){2}", _
                      sql, _
                      shtk, _
                      (IIf(st <> 0, String.Format(" AND SoPS={0}", CStr(st)), String.Empty)))
            If ChkTaikhoan(7).CheckState = CheckState.Checked Then sql = String.Format("{0} AND ((HethongTK.TK_ID={1} OR HethongTK_1.TK_ID={2}) AND CT_ID=0)", sql, ConvertToStrSafe(TKCNPT_ID), ConvertToStrSafe(TKCNKH_ID))
        End If
        If ChkTaikhoan(4).CheckState = CheckState.Checked And CboN(2).SelectedIndex >= 0 Then
            sql = String.Format("{0} AND ChungTu{1}.CTGS={2}", sql, sh, ConvertToStrSafe(CboN(2).SelectedValue))
        End If
        If ChkTaikhoan(8).CheckState = CheckState.Checked And ConvertToDblSafe((txtShTk(6).Tag)) > 0 Then
            sql = String.Format("{0} AND ChungTu{1}.MaTP={2}", sql, sh, ConvertToStrSafe(txtShTk(6).Tag))
        End If
        If ChkTaikhoan(6).CheckState = CheckState.Checked Then sql = String.Format("{0} AND (ChungTu{1}.User_ID={2})", sql, sh, ConvertToStrSafe(CboN(3).SelectedValue))
        Dim loaict As String = String.Empty
        For i As Integer = 0 To 14
            If i < 4 Or i > 6 Then
                If ChkLoai(i).CheckState = CheckState.Checked Then loaict = String.Format("{0}ChungTu{1}.MaLoai = {2} OR ", loaict, sh, ConvertToStrSafe(i))
            End If
        Next
        If Not (loaict.Length = 0) Then
            If loaict.Length > 0 Then sql = String.Format("{0} AND ({1})", sql, Strings.Left(loaict, loaict.Length - 4))
            If (ChkLoai(1).CheckState = CheckState.Checked Or ChkLoai(2).CheckState = CheckState.Checked Or ChkLoai(8).CheckState = CheckState.Checked) And CboN(0).SelectedIndex > 0 Then sql = String.Format("{0} AND (ChungTu{1}.MaKho={2})", sql, sh, ConvertToStrSafe(CboN(0).SelectedValue))
            If (ChkLoai(1).CheckState = CheckState.Checked Or ChkLoai(2).CheckState = CheckState.Checked Or ChkLoai(8).CheckState = CheckState.Checked) And CboN(1).SelectedIndex > 0 Then sql = String.Format("{0} AND (ChungTu{1}.MaNguon={2})", sql, sh, ConvertToStrSafe(CboN(1).SelectedValue))
            If pProcessMode = 1 Then sql = sql & " AND XuLy<2 "
            sql = String.Format("{0} GROUP BY ChungTu{1}.MaSo,ChungTu{1}.MaCT,[User_ID],ChungTu{1}.MaLoai,ChungTu{1}.SoHieu, ChungTu{1}.NgayCT, ChungTu{1}.NgayGS, ChungTu{1}.DienGiai{2},TPS ", sql, sh, (IIf(pNN = 1, "E", String.Empty)))
            sql = "SELECT chungtu.*,chuyen111.tps FROM chungtu inner join (" & sql & ") as chuyen111 on chungtu.maso=chuyen111.maso"
            SoCTChon = FrmA.ChonCTSoB(sql, sohieusang, IIf(OptLK(0).Checked, CboThang(0).SelectedIndex, 0), ConvertToDateSafe(MedNgay(0).Text), ConvertToDateSafe(MedNgay(1).Text), MaCT, IIf(OptLK(0).Checked, CboThang(1).SelectedIndex, 0), txtShTk(0).Text)
            On Error GoTo 0
        End If
        Me.Cursor = Cursors.Default
    End Sub
    '======================================================================================
    ' Hàm hiện cửa sổ danh sách và trả về mã số CT được chọn
    '======================================================================================
    Public Function ChonCT(ByRef p As Integer) As Integer
        ShowDialog()
        p = IIf(ChkLoai(7).CheckState = CheckState.Checked Or pPhieu > 0, 1, 0)
        Return MaCTChon
    End Function
    Private Sub KiemtraUser()
        ChkLoai(3).Enabled = (ConvertToDblSafe(frmMain.Tag) Mod 10 >= 1)
        ChkLoai(0).Enabled = (ConvertToDblSafe(frmMain.Tag) Mod 10 >= 1)
        If Not (ConvertToDblSafe(frmMain.Tag) Mod 10 >= 1) Then
            ChkLoai(0).CheckState = CheckState.Unchecked
            ChkLoai(1).Enabled = (ConvertToDblSafe(frmMain.Tag) Mod 100 >= 10)
            ChkLoai(2).Enabled = (ConvertToDblSafe(frmMain.Tag) Mod 1000 >= 100)
            ChkLoai(9).Enabled = (ConvertToDblSafe(frmMain.Tag) Mod 10000 >= 1000)
            ChkLoai(10).Enabled = (ConvertToDblSafe(frmMain.Tag) Mod 10000 >= 1000)
            ChkLoai(11).Enabled = (ConvertToDblSafe(frmMain.Tag) Mod 10000 >= 1000)
            ChkLoai(12).Enabled = (ConvertToDblSafe(frmMain.Tag) Mod 10000 >= 1000)
            ChkLoai(13).Enabled = (ConvertToDblSafe(frmMain.Tag) Mod 10000 >= 1000)
            ChkLoai(7).Enabled = (ConvertToDblSafe(frmMain.Tag) Mod 100000 >= 10000)
            ChkLoai(8).Enabled = (ConvertToDblSafe(frmMain.Tag) Mod 100000 >= 10000)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_0.Enter, _MedNgay_1.Enter
        Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
        MedNgay(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_0.Leave, _MedNgay_1.Leave
        Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
        If Information.IsDate(MedNgay(Index).Text) Then
            Ngay(Index) = ConvertToDateSafe(MedNgay(Index).Text)
        Else
            MedNgay(Index).Focus()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="dest"></param>
    ''' <remarks></remarks>
    Private Sub DSCTu(ByRef dest As Integer)
        Cursor = Cursors.WaitCursor
        ExecSQLNonQuery("DELETE  FROM BaoCaoCP2")
        With GrdChungtu
            For i As Integer = 0 To .Rows - 1
                .Row = i
                .Col = 5
                If .CtlText.length = 0 Then Exit For
                ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP2 (MaSo,SoHieu) VALUES ({0}, N'{0}')", .CtlText))
            Next
        End With
        Dim sql As String = String.Format("SELECT -1 AS LoaiCT, MaCT, ChungTu.SoHieu AS SHCT, NgayCT, DienGiai{0}, Sum(SoPS) AS PS, Sum(SoPS2No) AS Luong, HethongTK.SoHieu AS SHTK, HethongTK.Ten AS TenTK, CASE WHEN (TK_ID={1}) THEN Vattu.SoHieu ELSE '' END AS SHVT, TenVattu AS TenVT, CASE WHEN (TK_ID={2} OR TK_ID={3}) THEN KhachHang.SoHieu ELSE '' END AS SHKH, KhachHang.Ten AS TenKH, HethongTK.Ten, Vattu.TenVattu FROM ((({4}) INNER JOIN BaoCaoCP2 ON ChungTu.MaCT=BaoCaoCP2.MaSo) LEFT JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo) LEFT JOIN KhachHang ON ChungTu.MaKH=KhachHang.MaSo GROUP BY MaCT, ChungTu.SoHieu, NgayCT, DienGiai, HethongTK.SoHieu, CASE WHEN(TK_ID={1}) THEN Vattu.SoHieu ELSE '' END, CASE WHEN (TK_ID={2} OR TK_ID={3}) THEN KhachHang.SoHieu ELSE '' END, HethongTK.Ten, Vattu.TenVattu, KhachHang.Ten UNION SELECT 1 AS LoaiCT, MaCT, ChungTu.SoHieu AS SHCT, NgayCT, DienGiai, Sum(SoPS) AS PS, Sum(SoPS2Co) AS Luong, HethongTK.SoHieu AS SHTK, HethongTK.Ten AS TenTK, CASE WHEN (TK_ID={5}) THEN Vattu.SoHieu ELSE '' END AS SHVT, TenVattu AS TenVT, CASE WHEN (TK_ID={2} OR TK_ID={3}) THEN KhachHang.SoHieu ELSE '' END AS SHKH, KhachHang.Ten AS TenKH , HethongTK.Ten, KhachHang.Ten FROM 	((({6}) INNER JOIN BaoCaoCP2 ON ChungTu.MaCT=BaoCaoCP2.MaSo) LEFT JOIN Vattu ON ChungTu.MaVattu=Vattu.MaSo)	 LEFT JOIN KhachHang ON ChungTu.MaKHC=KhachHang.MaSo GROUP BY MaCT, ChungTu.SoHieu, Vattu.TenVattu, HethongTK.Ten, KhachHang.Ten, NgayCT, DienGiai, HethongTK.SoHieu, CASE WHEN (TK_ID={1}) THEN Vattu.SoHieu ELSE '' END, CASE WHEN(TK_ID={2} OR TK_ID={3}) THEN KhachHang.SoHieu ELSE '' END", _
                                (IIf(pNN = 1, String.Empty, String.Empty)), _
                                ConvertToStrSafe(TKVT_ID), _
                                ConvertToStrSafe(TKCNKH_ID), _
                                ConvertToStrSafe(TKCNPT_ID), _
                                ChungTu2TKNC(-1), _
                                TKVT_ID, _
                                ChungTu2TKNC(1))

        rptFrom.InitForm("CHUNGTU3.RPT", sql, "QNhatky")
        rptFrom.ReportDestination = dest
        InBaoCaoRPT()
        Cursor = Cursors.Default
    End Sub
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(6).Enabled = (User_Right <> 2 Or (UserID = uid))
        Command(7).Enabled = (User_Right <> 2 Or (UserID = uid))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmDsCT_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub

    Private Sub GrdChungtu_SelectedIndexChanged(ByVal source As Object, ByVal e As ListViewEx.ClickEventArgs) Handles GrdChungtu.SelectedIndexChanged
        chon = e.ItemIndex
    End Sub
End Class
