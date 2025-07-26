Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmTongHop

    '    Const maxfile As Integer = 20
    '    Dim Ngay(1) As Date
    '    Dim pTK As CheckState
    '    Dim pCT As String = String.Empty
    '    Dim MaCT(Max1000 - 1) As Integer
    '    Dim SoCTChon As Integer
    '    Dim SoHieu As String = String.Empty
    '    Dim sqlcommand As New SqlCommand

    '    Private Sub FrmTongHop_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
    '        sqlcommand.CommandType = CommandType.Text
    '        Text = SetFormTitle(Text)
    '        For chi_so As Integer = 0 To 1
    '            AddMonthToCbo(CboThang(chi_so))
    '            InitDateVars(MedNgay(chi_so), Ngay(chi_so))
    '        Next
    '        LietKeDB()
    '        Chk(5).Visible = (LstDB(0).Items.Count = 1)
    '        SetFont(Me)
    '    End Sub
    '    Private Sub FrmTongHop_Activated(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Activated
    '        Khoaquyen()
    '    End Sub
    '    Private Sub TxtSohieu_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _TxtSohieu_1.Enter, _TxtSohieu_0.Enter
    '        Dim Index As Integer = Array.IndexOf(TxtSohieu, eventSender)
    '        TxtSohieu(Index).SelectAll()
    '    End Sub
    '    Private Sub TxtSohieu_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _TxtSohieu_1.KeyPress, _TxtSohieu_0.KeyPress
    '        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
    '        Dim Index As Integer = Array.IndexOf(TxtSohieu, eventSender)
    '        Me.Cursor = Cursors.WaitCursor
    '        If KeyAscii = 13 Then
    '            TxtSohieu(Index).Text = FrmTaikhoan.ChonTk(TxtSohieu(Index).Text)
    '        End If
    '        Me.Cursor = Cursors.Default
    '        TxtSohieu(Index).Focus()
    '        If KeyAscii = 0 Then
    '            eventArgs.Handled = True
    '        End If
    '    End Sub
    '    Private Sub TxtSohieu_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _TxtSohieu_1.Leave, _TxtSohieu_0.Leave
    '        Dim Index As Integer = Array.IndexOf(TxtSohieu, eventSender)
    '        Dim mtk As Integer
    '        LbTen(Index).Text = tentk(TxtSohieu(Index).Text.ToUpper(), mtk)
    '        TxtSohieu(Index).Tag = ConvertToStrSafe(mtk)
    '    End Sub
    '    Private Sub CboThang_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _CboThang_0.SelectedIndexChanged, _CboThang_1.SelectedIndexChanged
    '        Chk(5).Visible = (LstDB(0).Items.Count = 1)
    '    End Sub
    '    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_2.Click, _Command_0.Click, _Command_1.Click, _Command_3.Click
    '        Dim Index As Integer = Array.IndexOf(Command, eventSender)
    '        Dim j As Integer
    '        Select Case Index
    '            Case 0
    '                luu = 0
    '                'frmMain.ConnectionControl(, luu)
    '                luu = 1
    '                If Not Connecstring Is Nothing Then
    '                    For i As Integer = 0 To LstDB(1).Items.Count - 1
    '                        If VB6.GetItemString(LstDB(1), i) = Connecstring Then
    '                            MessageBox.Show("Tệp dữ liệu đã được chọn !", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                            Exit Sub
    '                        End If
    '                    Next
    '                    ThemDB(Connecstring, True)
    '                End If
    '            Case 1
    '                If LstDB(0).SelectedIndex >= 0 Then
    '                    LstDB(1).Items.RemoveAt(LstDB(0).SelectedIndex)
    '                    LstDB(0).Items.RemoveAt(LstDB(0).SelectedIndex)
    '                End If
    '            Case 2
    '                Me.Cursor = Cursors.WaitCursor
    '                SoHieu = TxtSohieu(1).Text
    '                If Chk(6).CheckState = CheckState.Checked And ConvertToDblSafe((TxtSohieu(0).Tag)) = 0 Then
    '                    ErrMsg(er_SHTaiKhoan)
    '                    TxtSohieu(0).Focus()
    '                    GoTo kt
    '                End If
    '                pTK = Chk(3).CheckState
    '                If Opt(0).Checked And CboThang(0).SelectedIndex > CboThang(1).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
    '                If Chk(5).CheckState = CheckState.Checked Or Chk(6).CheckState Then
    '                    SoCTChon = FrmA.ChonCTSoA(VB6.GetItemString(LstDB(1), 0), _
    '                                   IIf(Opt(0).Checked, CboThang(0).SelectedValue, 0), _
    '                                   Ngay(0), _
    '                                   Ngay(1), _
    '                                   MaCT, _
    '                                   IIf(Opt(0).Checked, CboThang(1).SelectedValue, 0), _
    '                                   IIf(Chk(6).CheckState = CheckState.Checked, TxtSohieu(0).Text, String.Empty))
    '                    Me.Refresh()
    '                End If
    '                j = 0
    '                For i As Integer = 0 To LstDB(0).Items.Count - 1
    '                    If LstDB(0).GetSelected(i) Then ' C15 Listbox GetSelected Then
    '                        On Error Resume Next
    '                        '******************* Tổng hợp số phát sinh *********************
    '                        If Chk(8).CheckState = CheckState.Checked Then
    '                            If Not NhapPS(IIf(Opt(0).Checked, CboThang(0).SelectedValue, 0), IIf(Opt(0).Checked, CboThang(1).SelectedValue, 0), Chk(0).CheckState, Chk(1).CheckState, Chk(2).CheckState, i + 1, Ngay(0), Ngay(1)) Then MessageBox.Show("Hệ thống tài khoản không hợp lệ!", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                        End If
    '                        If Chk(7).CheckState = CheckState.Checked Then
    '                            '******************* Cộng dồn số đầu kỳ của 2 data ************************
    '                            CBDL(ConvertToStrSafe(i))
    '                            If SoHieu Like "131*" Or SoHieu Like "331*" Then
    '                                CongDKCN(ConvertToStrSafe(i), VB6.GetItemString(LstDB(0), i), 0, pTK, pCT)
    '                            ElseIf SoHieu Like "15*" Then
    '                                CongDKVT(ConvertToStrSafe(i), VB6.GetItemString(LstDB(0), i), 0, pTK, pCT)
    '                            ElseIf SoHieu.Length = 0 Then
    '                                If MessageBox.Show("Tổng hợp số dư đầu kỳ của tất cả các tài khoản", My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.No Then GoTo kt
    '                                'LaySoDauNam()
    '                                CongDKCN(ConvertToStrSafe(i), VB6.GetItemString(LstDB(0), i), 0, pTK, pCT)
    '                                CongDKVT(ConvertToStrSafe(i), VB6.GetItemString(LstDB(0), i), 0, pTK, pCT)
    '                                CongDK1(ConvertToStrSafe(i), VB6.GetItemString(LstDB(0), i), 0, pTK, pCT, SoHieu)
    '                            ElseIf Not (SoHieu Like "211*" Or SoHieu Like "153*" Or SoHieu Like "142*" Or SoHieu Like "242*") Then
    '                                CongDK1(ConvertToStrSafe(i), VB6.GetItemString(LstDB(0), i), 0, pTK, pCT, SoHieu)
    '                            End If
    '                        End If
    '                        j += 1
    '                        HienThongBao("Đã tổng hợp " & VB6.GetItemString(LstDB(0), i), 1)
    '                    End If
    '                Next
    '                If j > 0 Then
    '                    If Chk(0).CheckState = CheckState.Unchecked Then ExecSQLNonQuery("UPDATE HethongTK SET TK_ID=0 WHERE TK_ID=" & TKVT_ID) Else KiemTraVatTu()
    '                    If Chk(1).CheckState = CheckState.Unchecked Then ExecSQLNonQuery("UPDATE HethongTK SET TK_ID=0 WHERE TK_ID=" & TKCNKH_ID & " OR TK_ID=" & ConvertToStrSafe(TKCNPT_ID))
    '                    If Chk(2).CheckState = CheckState.Checked Then SoDuTKTS()
    '                    KiemTraTaiKhoan()
    '                    MessageBox.Show("Phát sinh của " & j & " đơn vị đã được tập hợp vào số liệu của " & (pTenCn), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    CloseItemList()
    '                End If
    '            Case 3
    '                Me.Close()
    '        End Select
    '        Chk(5).Visible = (LstDB(0).Items.Count >= 1)
    'kt:
    '        SoHieu = ""
    '        Me.Cursor = Cursors.Default
    '    End Sub
    '    Private Sub FrmTongHop_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
    '        Dim Shift As Integer = eventArgs.KeyData \ &H10000
    '        If (Shift And 4) > 0 Then
    '            Select Case eventArgs.KeyCode
    '                Case Keys.T : Command(0).Focus()
    '                    Command_ClickEvent(Command(0), New EventArgs())
    '                    Exit Select
    '                Case Keys.X : Command(1).Focus()
    '                    Command_ClickEvent(Command(1), New EventArgs())
    '                    Exit Select
    '                Case Keys.H : Command(2).Focus()
    '                    Command_ClickEvent(Command(2), New EventArgs())
    '                    Exit Select
    '                Case Keys.V : Command(3).Focus()
    '                    Command_ClickEvent(Command(3), New EventArgs())
    '                    Exit Select
    '            End Select
    '        End If
    '        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    '    End Sub
    '    Private Sub LietKeDB()
    '        Dim Filename As String = String.Empty
    '        For i As Integer = 1 To maxfile
    '            Filename = Interaction.GetSetting(IniPath, "ImportFile", "File" & i, )
    '            If Filename.Length > 0 Then
    '                If FileSystem.Dir(Filename, FileAttribute.Normal).Length > 0 Then ThemDB(Filename, False)
    '            Else
    '                Exit For
    '            End If
    '        Next
    '    End Sub
    '    '=================================================================================================================
    '    ' Thủ tục thêm tệp dữ liệu được chọn vào danh sách
    '    '=================================================================================================================
    '    Private Sub ThemDB(ByRef file_name As String, ByRef thongbao As Boolean)
    '        Dim i As Integer = -1
    '        'Dim db As DAODatabaseHelper
    '        Dim rs_license As DataTable
    '        On Error GoTo LoiDB
    '        'db = WSpace.OpenDatabase("<Connection-String>")
    '        rs_license = ExecSQLReturnDT("SELECT DISTINCT * FROM License")
    '        For i = 0 To LstDB(1).Items.Count - 1
    '            If i = ConvertToStrSafe(rs_license.Rows(0)("TenCty_ID")) And i = ConvertToStrSafe(rs_license.Rows(0)("tencn_id")) Then
    '                If thongbao Then MessageBox.Show("Tệp dữ liệu đã được chọn !", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                GoTo KetThuc
    '            End If
    '            If ConvertToStrSafe(rs_license.Rows(0)("NamTC")) <> pNamTC Then
    '                If thongbao Then MessageBox.Show("Tệp dữ liệu không cùng năm tài chính với tệp dữ liệu hiện thời!", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                GoTo KetThuc
    '            End If
    '        Next
    '        LstDB(0).Items.Add(rs_license.Rows(0)("masothue"))
    '        VB6.SetItemData(LstDB(0), i, rs_license.Rows(0)("TenCty_ID"))
    '        LstDB(1).Items.Add(file_name)
    '        VB6.SetItemData(LstDB(1), i, rs_license.Rows(0)("tencn_id"))
    'KetThuc:
    '        On Error GoTo 0
    '        Exit Sub
    'LoiDB:
    '        If thongbao Then ErrMsg(er_DBFile)
    '        GoTo KetThuc
    '    End Sub
    '    Private Sub FrmTongHop_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
    '        If Not String.IsNullOrEmpty(IniPath) Then
    '            For i As Integer = 1 To LstDB(0).Items.Count
    '                Interaction.SaveSetting(IniPath, "ImportFile", "File" & i, VB6.GetItemString(LstDB(1), i - 1))
    '            Next
    '            Interaction.SaveSetting(IniPath, "ImportFile", "File" & LstDB(0).Items.Count + 1, String.Empty)
    '        End If

    '        MemoryHelper.ReleaseMemory()
    '    End Sub
    '    Private Sub LstDB_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _LstDB_1.SelectedIndexChanged, _LstDB_0.SelectedIndexChanged
    '        Dim Index As Integer = Array.IndexOf(LstDB, eventSender)
    '        If LstDB(Index).SelectedIndex >= 0 Then
    '            LstDB(1 - Index).SelectedIndex = LstDB(Index).SelectedIndex
    '            Connecstring = _LstDB_1.SelectedItem.ToString
    '        End If
    '        'For i As Integer = 0 To LstDB(Index).Items.Count - 1
    '        '    LstDB(1 - Index).SetSelected(i, LstDB(Index).GetSelected(i)) ' C15 Listbox SetSelected ' C15 Listbox GetSelected
    '        'Next
    '    End Sub
    '    Private Sub CBDL(ByRef s As String)
    '        If Not TruongDaCo("HethongTK", "n" & s) Then ThemTruong("HethongTK", "n" & s, DbType.Double)
    '        If Not TruongDaCo("HethongTK", "c" & s) Then ThemTruong("HethongTK", "c" & s, DbType.Double)
    '        If Not TruongDaCo("HethongTK", "nt" & s) Then ThemTruong("HethongTK", "nt" & s, DbType.Double)
    '        If Not TruongDaCo("SoDuKhachHang", "n" & s) Then ThemTruong("SoDuKhachHang", "n" & s, DbType.Double)
    '        If Not TruongDaCo("SoDuKhachHang", "c" & s) Then ThemTruong("SoDuKhachHang", "c" & s, DbType.Double)
    '        If Not TruongDaCo("SoDuKhachHang", "nt" & s) Then ThemTruong("SoDuKhachHang", "nt" & s, DbType.Double)
    '        If Not TruongDaCo("TonKho", "n" & s) Then ThemTruong("TonKho", "n" & s, DbType.Double)
    '        If Not TruongDaCo("TonKho", "c" & s) Then ThemTruong("TonKho", "c" & s, DbType.Double)
    '    End Sub
    '    '=================================================================================================================
    '    ' Thủ tục tổng hợp số liệu từ tệp được chọn vào tệp đang mở
    '    '    '=================================================================================================================
    '    Private Function NhapPS(ByRef thang As Integer, ByRef tcuoi As Integer, ByRef vt As Integer, ByRef cn As Integer, ByRef ts As Integer, ByRef tt As Integer, ByRef ndau As Date, ByRef ncuoi As Date) As Boolean
    '        '        Dim result As Boolean = False
    '        '        Dim soct As Integer
    '        '        Dim ctu As New ClsChungtu
    '        '        Dim k As Integer
    '        '        Dim macc() As String = {}, sohieuctcc() As String = {}
    '        '        Dim dai As Integer
    '        '        Dim id1, mct, m, id2 As Integer
    '        '        Dim st2 = String.Empty, st1 = String.Empty, st As String = String.Empty
    '        '        Dim mtkc, mtkn, ml As Integer
    '        '        Dim tencn As String = String.Empty
    '        '        Try
    '        '            If Not TruongDaCo("Chungtu", "SHTKNo") Then
    '        '                sqlcommand.CommandText = String.Format("ALTER TABLE {0} ADD {1} {2} DEFAULT({3})", "Chungtu", "SHTKNo", "[nvarchar](20)", "'...'")
    '        '                ExecuteSQLCommand(sqlcommand, Connecstring)
    '        '                sqlcommand.CommandText = String.Format("ALTER TABLE {0} ADD {1} {2} DEFAULT({3})", "Chungtu", "SHTKCo", "[nvarchar](20)", "'...'")
    '        '                ExecuteSQLCommand(sqlcommand, Connecstring)
    '        '            End If
    '        '        Catch exc As System.Exception
    '        '            'Resume in On-Error-Resume-Next Block
    '        '        End Try
    '        '        sqlcommand.CommandText = "SELECT DISTINCT * FROM License"
    '        '        Dim rs2 As DataTable = ExecuteSQLCommandDT(sqlcommand, Connecstring)
    '        '        Dim idcn As Integer = rs2.Rows(0)("tencn_id")
    '        '        tencn = rs2.Rows(0)("tencn")
    '        '        pCT = LaySH(rs2.Rows(0)("TKVattu"), 2, "-")
    '        '        If pCT.Length = 0 Or pCT = "..." Then pCT = ConvertToStrSafe(tt)
    '        '        If LstDB(0).Items.Count > 1 Then ExecSQLNonQuery(ConvertToStrSafe("INSERT INTO Users (MaSo, TenNSD, UserRight) VALUES (" & idcn & ",'" + (IIf(tencn <> "...", tencn, rs2("TenCty"))) + "',2"), False)

    '        '        sqlcommand.CommandText = "update chungtu set shtkno=hethongtk.sohieu from hethongtk where hethongtk.maso=chungtu.matkno"
    '        '        ExecuteSQLCommand(sqlcommand, Connecstring)
    '        '        sqlcommand.CommandText = "update chungtu set shtkco=hethongtk.sohieu from hethongtk where hethongtk.maso=chungtu.matkco"
    '        '        ExecuteSQLCommand(sqlcommand, Connecstring)
    '        '        ThemTruong("HoaDon", "MaKH1", DbType.Int64)
    '        '        ThemTruong("CTTaiSan", "ML", DbType.Int64)
    '        '        ThemTruong("CTTaiSan", "MN", DbType.Int64)
    '        '        ThemTruong("CTTaiSan", "MT", DbType.Int64)
    '        '        ThemTruong("ChungTu", "U", DbType.Int32)
    '        '        ThemTruong("ChungTu", "U2", DbType.Int32)
    '        '        ThemTruong("CTTaiSan", "U", DbType.Int32)
    '        '        ThemTruong("CTTaiSan", "U2", DbType.Int32)
    '        '        ThemTruong("CTCongcudungcu", "ML", DbType.Int64)
    '        '        ThemTruong("CTCongcudungcu", "MN", DbType.Int64)
    '        '        ThemTruong("CTCongcudungcu", "MT", DbType.Int64)
    '        '        ThemTruong("CTCongcudungcu", "U", DbType.Int32)
    '        '        ThemTruong("CTCongcudungcu", "U2", DbType.Int32)
    '        '        Dim mkh As Integer = Lng_MaxValue("MaSo", "KhachHang")
    '        '        If mkh = 0 Then
    '        '            mkh = 1
    '        '            ml = ConvertToDblSafe(GetSelectValue("SELECT MaSo AS F1 FROM PhanLoaiKhachHang WHERE LEFT(SoHieu,1)='#'"))
    '        '            ExecSQLNonQuery("INSERT INTO KhachHang (MaSo,MaPhanLoai,SoHieu) VALUES (1," & ml & ",'#1')")
    '        '        End If
    '        '        ml = Lng_MaxValue("MaSo", "LoaiChungTu")
    '        '        sqlcommand.CommandText = "SELECT * FROM DoituongCT WHERE MaSo>1"
    '        '        rs2 = ExecuteSQLCommandDT(sqlcommand, Connecstring)
    '        '        For Each rs2Item As DataRow In rs2.Rows
    '        '            k = ConvertToDblSafe(GetSelectValue("SELECT MaSo AS F1 FROM DoituongCT WHERE DienGiai='" + rs2Item("DienGiai") + "'"))
    '        '            If k = 0 Then ExecSQLNonQuery("INSERT INTO DoituongCT (MaSo,DienGiai) VALUES (" & Lng_MaxValue("MaSo", "DoituongCT") + 1 & ",'" + rs2Item("DienGiai") + "'")
    '        '        Next
    '        '        'LayCTBanHang = 0
    '        '        sqlcommand.CommandText = "SELECT DISTINCT ChungTu.*,DoituongCT.DienGiai AS DG FROM ChungTu INNER JOIN DoituongCT ON ChungTu.MaDT=DoituongCT.MaSo WHERE MaCT > 0 AND " & (IIf(thang > 0, WThang("ThangCT", thang, tcuoi), WNgay("NgayGS", ndau, ncuoi))) & " ORDER BY MaCT, ChungTu.MaSo"
    '        '        Dim rsct As DataTable = ExecuteSQLCommandDT(sqlcommand, Connecstring)
    '        '        Dim masocu As Integer = Lng_MaxValue("MaSo", "ChungTu")
    '        '        Dim mactcu As Integer = Lng_MaxValue("MaCT", "ChungTu")
    '        '        Dim MaCT As Integer = mactcu
    '        '        Dim rsctIndex As Integer = 0
    '        '        Do While rsctIndex < rsct.Rows.Count - 1
    '        '            Dim rsctItem As DataRow = rsct.Rows(rsctIndex)
    '        '            rsctIndex += 1 ' C15 Rs LOOP CONTROL
    '        '            If mct <> rsctItem("MaCT") Then
    '        'a:
    '        '                k = ConvertToDblSafe(GetSelectValue("SELECT ChungTu.maso AS F1 FROM ChungTu INNER JOIN DoituongCT ON ChungTu.MaDT=DoituongCT.MaSo WHERE ChungTu.Sohieu='" + rsctItem("SoHieu") + "' AND MaCT > 0 AND " + (IIf(thang > 0, WThang("ThangCT", thang, tcuoi), WNgay("NgayGS", ndau, ncuoi)))))
    '        '                If k <> 0 Then GoTo c
    '        '                mct = rsctItem("MaCT")
    '        '                If Not MaCTOK(mct) Then
    '        '                    Do While rsctItem("MaCT") = mct
    '        '                        rsctIndex += 1
    '        '                        rsctItem = rsct.Rows(rsctIndex)
    '        '                        If rsctIndex = rsct.Rows.Count Then GoTo B
    '        '                    Loop
    '        '                    GoTo a
    '        '                End If
    '        '                soct += 1
    '        '                MaCT += 1
    '        '            End If
    '        '            If IsDBNull(rsctItem("shtkno")) Then
    '        '                mtkn = 0
    '        '            Else
    '        '                mtkn = MaTKFix(rsctItem("shtkno"), IIf(pTK > 0, pCT, String.Empty), tencn)
    '        '            End If
    '        '            If IsDBNull(rsctItem("shtkco")) Then
    '        '                mtkc = 0
    '        '            Else
    '        '                mtkc = MaTKFix(rsctItem("shtkco"), IIf(pTK > 0, pCT, String.Empty), tencn)
    '        '            End If
    '        '            ctu.InitChungtuRS(rsctItem)
    '        '            ctu.MaDT = ConvertToDblSafe(GetSelectValue("SELECT MaSo AS F1 FROM DoituongCT WHERE DienGiai='" + rsctItem("dg") + "'"))
    '        '            If vt = 0 Then
    '        '                ctu.MaNguon = 0
    '        '                ctu.MaKho = 0
    '        '                ctu.MaVattu = 0
    '        '            End If
    '        '            If cn = 0 Then
    '        '                ctu.makh = 0
    '        '                ctu.MaKHC = 0
    '        '            End If
    '        '            If ctu.tkno.tkcon > 0 Then
    '        '                If pTK > 0 Then
    '        '                    ctu.tkno.InitTaikhoanMaSo(mtkn)
    '        '                Else
    '        '                    st = MaSo2SoHieu(rsctItem("MaTkNo"), "HethongTK")
    '        '                    st1 = ConvertToStrSafe(GetSelectValue("SELECT Ten AS F1, TenE AS F2 FROM HethongTK WHERE SoHieu='" + rsctItem("shtkno") + "'", st2, id1, id2))
    '        '                    m = ctu.tkno.ThemTKCon(Strings.Right(st, st.Length - ctu.tkno.sohieu.Length), st1, st2, id1, id2)
    '        '                    If m > 0 Then ctu.tkno.InitTaikhoanMaSo(m)
    '        '                End If
    '        '            End If
    '        '            If ctu.TkCo.tkcon > 0 Then
    '        '                If pTK > 0 Then
    '        '                    ctu.TkCo.InitTaikhoanMaSo(mtkc)
    '        '                Else
    '        '                    st = MaSo2SoHieu(rsctItem("MaTkCo"), "HethongTK")
    '        '                    st1 = ConvertToStrSafe(GetSelectValue("SELECT Ten AS F1, TenE AS F2 FROM HethongTK WHERE SoHieu='" + rsctItem("shtkco") + "'", st2, id1, id2))
    '        '                    m = ctu.TkCo.ThemTKCon(Strings.Right(st, st.Length - ctu.TkCo.sohieu.Length), st1, st2, id1, id2)
    '        '                    If m > 0 Then ctu.TkCo.InitTaikhoanMaSo(m)
    '        '                End If
    '        '            End If
    '        '            If ctu.tkno.tkcon > 0 Then
    '        '                MessageBox.Show("Kiểm tra tệp dữ liệu nguồn, chứng từ " & ctu.SoHieu & " có tài khoản " & ctu.tkno.sohieu & " không hợp lệ!", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        '            End If
    '        '            If ctu.TkCo.tkcon > 0 Then
    '        '                MessageBox.Show("Kiểm tra tệp dữ liệu nguồn, chứng từ " & ctu.SoHieu & " có tài khoản " & ctu.TkCo.sohieu & " không hợp lệ!", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        '            End If
    '        '            ctu.MaCT = MaCT
    '        '            ctu.CT_ID = ConvertToDblSafe(idcn + rsctItem("ThangCT") * 1000)
    '        '            ctu.User_ID = IIf(LstDB(0).Items.Count > 1, idcn, UserID)
    '        '            ctu.GhiChungtuTH(0, 1)
    '        '            rs2 = ExecSQLReturnDT("SELECT * FROM ChungTuLQ WHERE MaCT=" & rsctItem("MaCT"))
    '        '            Dim rs2Index As Integer = 0
    '        '            Do While rs2Index < rs2.Rows.Count
    '        '                Dim rs2Item As DataRow = rs2.Rows(rs2Index)
    '        '                rs2Index += 1 ' C15 Rs LOOP CONTROL
    '        '                If ConvertToDblSafe(GetSelectValue("SELECT MaSo AS F1 FROM ChungTuLQ WHERE MaCT=" & ctu.MaCT & " AND Loai=" & rs2Item("loai"))) = 0 Then
    '        '                    ExecSQLNonQuery("INSERT INTO ChungTuLQ (MaSo,MaCT,Loai,HoTen,DiaChi,SoCTGoc) VALUES (" & Lng_MaxValue("MaSo", "ChungTuLQ") + 1 & "," & ConvertToStrSafe(MaCT) & "," & rs2Item("loai") & ",'" + rs2Item("hoten") + "','" + rs2Item("DiaChi") + "','" + rs2Item("SoCTGoc") + "'")
    '        '                End If
    '        '            Loop
    '        '            If cn > 0 Then
    '        '                rs2 = ExecSQLReturnDT("SELECT HoaDon.* FROM HoaDon WHERE HoaDon.MaSo=" & rsctItem("MaSo"))
    '        '                rs2Index = 0
    '        '                Do While rs2Index < rs2.Rows.Count
    '        '                    Dim rs2Item As DataRow = rs2.Rows(rs2Index)
    '        '                    rs2Index += 1 ' C15 Rs LOOP CONTROL
    '        '                    ExecSQLNonQuery("INSERT INTO HoaDon (MaSo,Loai,MaKhachHang,KyHieu,SoHD,NgayPH,MatHang,SoLuong,ThanhTien,TyLe,HD,KCT,HDBL,HTTT,MauSo,MaKH1) VALUES (" & Lng_MaxValue("MaSo", "ChungTu") & "," & rs2Item("loai") & "," & ConvertToStrSafe(mkh) & ",'" + rs2Item("KyHieu") + "','" + rs2Item("sohd") + "','" + Format(CDate(rs2Item("NgayPH")), Mask_DB) + "','" + rs2Item("MatHang") + "'," + CStr(rs2Item("soluong")) + "," + CStr(rs2Item("ThanhTien")) + "," + rs2Item("TyLe") + "," + rs2Item("HD") + "," + rs2Item("KCT") + "," + rs2Item("HDBL") + ",'" + rs2Item("HTTT") + "','" + rs2Item("MauSo") + "'," + rs2Item("MaKhachHang") + "")
    '        '                Loop
    '        '            End If
    '        '            If ts > 0 And rsctItem("maloai") > 8 Then
    '        '                If rsctItem("maloai") <> 13 And rsctItem("maloai") <> 14 Then
    '        '                    If ConvertToDblSafe(GetSelectValue("SELECT MaSo AS F1 FROM CTTaiSan WHERE MaCTKT=" & MaCT)) = 0 Then
    '        '                        rs2 = ExecSQLReturnDT("SELECT TOP 1 CTTaiSan.* FROM CTTaiSan WHERE MaCTKT=" & rsctItem("MaCT"))
    '        '                        If rs2Index < rs2.Rows.Count Then
    '        '                            ExecSQLNonQuery("INSERT INTO CTTaiSan (MaSo, SoHieu, Thang, VaoSo, NgayGhi, DienGiai, MaLoai, MaNhom, MaTS, NG_NS, NG_TBS, NG_CNK, NG_TD, CL_NS, CL_TBS, CL_CNK, CL_TD, MaCTKT,ML,MN VALUES (" & Lng_MaxValue("MaSo", "CTTaiSan") + 1 & ",'" + rs2.Rows(0)("SoHieu") + "'," + rs2.Rows(0)("thang") + ",'" + Format(CDate(rs2.Rows(0)("VaoSo")), Mask_DB) + "','" + Format(CDate(rs2.Rows(0)("NgayGhi")), Mask_DB) + "','" + rs2.Rows(0)("DienGiai") + "'," + ConvertToStrSafe(ml) + "," + ConvertToStrSafe(ml) + "," + rs2.Rows(0)("MaTS") + "," + CStr(rs2.Rows(0)("NG_NS")) + "," + CStr(rs2.Rows(0)("NG_TBS")) + "," + CStr(rs2.Rows(0)("NG_CNK")) + "," + CStr(rs2.Rows(0)("NG_TD")) + "," + CStr(rs2.Rows(0)("CL_NS")) + "," + CStr(rs2.Rows(0)("CL_TBS")) + "," + CStr(rs2.Rows(0)("CL_CNK")) + "," + CStr(rs2.Rows(0)("CL_TD")) + "," + ConvertToStrSafe(MaCT) + "," + rs2.Rows(0)("maloai") + "," + rs2.Rows(0)("MaNhom") + ")")
    '        '                        End If
    '        '                    End If
    '        '                Else
    '        '                    If ConvertToDblSafe(GetSelectValue("SELECT MaSo AS F1 FROM CTCongcudungcu WHERE MaCTKT=" & MaCT)) = 0 Then
    '        '                        rs2 = ExecSQLReturnDT("SELECT TOP 1 CTCongcudungcu.* FROM CTCongcudungcu WHERE MaCTKT=" & rsctItem("MaCT"))
    '        '                        If rs2Index < rs2.Rows.Count Then
    '        '                            dai += 1
    '        '                            ReDim Preserve macc(dai)
    '        '                            macc(dai - 1) = MaSo2SoHieu(ctu.MaVattu, "VatTu")
    '        '                            ReDim Preserve sohieuctcc(dai)
    '        '                            sohieuctcc(dai - 1) = ctu.SoHieu
    '        '                            ExecSQLNonQuery("INSERT INTO CTCongcudungcu (MaSo, SoHieu, Thang, VaoSo, NgayGhi, DienGiai, MaLoai, MaNhom, MaTS, NG_NS, NG_TBS, NG_CNK, NG_TD, CL_NS, CL_TBS, CL_CNK, CL_TD, MaCTKT,ML,MN VALUES (" & Lng_MaxValue("MaSo", "CTCongcudungcu") + 1 & ",'" + rs2.Rows(0)("SoHieu") + "'," + rs2.Rows(0)("thang") + ",'" + Format(CDate(rs2.Rows(0)("VaoSo")), Mask_DB) + "','" + Format(CDate(rs2.Rows(0)("NgayGhi")), Mask_DB) + "','" + rs2.Rows(0)("DienGiai") + "'," + ConvertToStrSafe(ml) + "," + ConvertToStrSafe(ml) + "," + rs2.Rows(0)("MaTS") + "," + CStr(rs2.Rows(0)("NG_NS")) + "," + CStr(rs2.Rows(0)("NG_TBS")) + "," + CStr(rs2.Rows(0)("NG_CNK")) + "," + CStr(rs2.Rows(0)("NG_TD")) + "," + CStr(rs2.Rows(0)("CL_NS")) + "," + CStr(rs2.Rows(0)("CL_TBS")) + "," + CStr(rs2.Rows(0)("CL_CNK")) + "," + CStr(rs2.Rows(0)("CL_TD")) + "," + ConvertToStrSafe(MaCT) + "," + rs2.Rows(0)("maloai") + "," + rs2.Rows(0)("MaNhom") + ")")
    '        '                        End If
    '        '                    End If
    '        '                End If
    '        '            End If
    '        '            If ConvertToDblSafe(rsct.Rows.Count) Mod 100 = 0 Then
    '        '                Label1(3).Text = "Số CT đã tổng hợp: " & ConvertToDblSafe(ToolTipMain.GetToolTip(Label1(3))) + soct
    '        '                Me.Refresh()
    '        '            End If
    '        'c:
    '        '        Loop
    '        'B:
    '        '        If vt > 0 Then CongDDVT(masocu, tencn, Chk(4).CheckState, True, pTK, pCT)
    '        '        If cn > 0 Then CongDDCN(masocu, Chk(4).CheckState, True, pTK, pCT)
    '        '        If ts > 0 Then
    '        '            CongDDTS(mactcu, tencn, Chk(4).CheckState, True, pTK, pCT)
    '        '            ThemTruong("Thongso1", "MaTTSD", DbType.Int32)
    '        '            ThemTruong("Thongso1", "MaDTQL", DbType.Int32)
    '        '            CongDDCCDC(mactcu, tencn, Chk(4).CheckState, True, pTK, pCT, macc, sohieuctcc)
    '        '        End If
    '        '        If Chk(7).CheckState = CheckState.Checked Then
    '        '            If SoHieu = "" Then
    '        '                CongDKTS(mactcu, tencn, Chk(4).CheckState, True, pTK, pCT)
    '        '                ThemTruong("Thongso1", "MaTTSD", DbType.Int32)
    '        '                ThemTruong("Thongso1", "MaDTQL", DbType.Int32)
    '        '                CongDKCCDC(mactcu, tencn, Chk(4).CheckState, True, pTK, pCT, 1)
    '        '                CongDKCCDC(mactcu, tencn, Chk(4).CheckState, True, pTK, pCT)
    '        '            ElseIf SoHieu Like "211*" Then
    '        '                CongDKTS(mactcu, tencn, Chk(4).CheckState, True, pTK, pCT)
    '        '            ElseIf SoHieu Like "153*" Then
    '        '                ThemTruong("Thongso1", "MaTTSD", DbType.Int32)
    '        '                ThemTruong("Thongso1", "MaDTQL", DbType.Int32)
    '        '                CongDKCCDC(mactcu, tencn, Chk(4).CheckState, True, pTK, pCT, 1)
    '        '            ElseIf SoHieu Like "142*" Or SoHieu Like "242*" Then
    '        '                ThemTruong("Thongso1", "MaTTSD", DbType.Int32)
    '        '                ThemTruong("Thongso1", "MaDTQL", DbType.Int32)
    '        '                CongDKCCDC(mactcu, tencn, Chk(4).CheckState, True, pTK, pCT)
    '        '            End If
    '        '        End If
    '        '        result = True
    '        '        Return result
    '    End Function

    '    Private Sub MedNgay_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_0.Enter, _MedNgay_1.Enter
    '        Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
    '        MedNgay(Index).SelectAll()
    '    End Sub
    '    Private Sub MedNgay_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_0.Leave, _MedNgay_1.Leave
    '        Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
    '        If Information.IsDate(MedNgay(Index).Text) Then
    '            Ngay(Index) = ConverttodateSafe(MedNgay(Index).Text)
    '        Else
    '            MedNgay(Index).Focus()
    '        End If
    '    End Sub
    '    Private Function MaCTOK(ByRef mct As Integer) As Boolean
    '        Dim result As Boolean = False
    '        If SoCTChon = 0 Then
    '            result = True
    '        Else
    '            result = False
    '            For i As Integer = 1 To SoCTChon
    '                If MaCT(i - 1) = mct Then
    '                    result = True
    '                    Exit For
    '                End If
    '            Next
    '        End If
    '        Return result
    '    End Function
    '    Public Sub CongDKTS(ByRef mactcu As Integer, ByRef tencn As String, ByRef tachsh As Integer, ByRef cnct As Boolean, ByRef pTK As Integer, ByRef pCT As String)
    '        Dim rs2 As DataTable
    '        Dim mcha, m1 As Integer
    '        Dim i As Integer
    '        Dim sh As String = String.Empty

    '        If cnct Then ExecSQLNonQuery("UPDATE CTTaiSan SET U=0, U2=0")
    '        Dim matscu As Integer = Lng_MaxValue("MaSo", "TaiSan")
    '        sqlcommand = New SqlCommand
    '        sqlcommand.CommandText = "SELECT LoaiChungTu.*,PL.SoHieu AS SHCha FROM LoaiChungTu LEFT JOIN LoaiChungTu AS PL ON LoaiChungTu.CapTren=PL.MaSo ORDER BY LoaiChungTu.SoHieu"
    '        Dim rs As DataTable = ExecuteSQLCommandDT(sqlcommand, Connecstring)

    '        For Each rsItem As DataRow In rs.Rows
    '            sh = rsItem("SoHieu")
    '            mcha = SoHieu2MaSo(sh, "LoaiChungTu")
    '            If mcha = 0 Then
    '                If rsItem("CapTren") > 0 Then
    '                    m1 = SoHieu2MaSo(rsItem("shcha"), "LoaiChungTu")
    '                Else
    '                    m1 = 0
    '                End If
    '                ExecSQLNonQuery("INSERT INTO LoaiChungTu (MaSo,SoHieu,Ten,CapTren,Cap) VALUES (" & Lng_MaxValue("MaSo", "LoaiChungTu") + 1 & ",'" & sh & "','" & rsItem("ten") & "'," & ConvertToStrSafe(m1) & "," & rsItem("cap") & ")")
    '                mcha = SoHieu2MaSo(sh, "LoaiChungTu")
    '            End If
    '            If cnct Then
    '                ExecSQLNonQuery("UPDATE CTTaiSan SET MaLoai=" & mcha & ", U=1 WHERE U=0 AND ML=" & rsItem("MaSo") & " AND MaCTKT>" & ConvertToStrSafe(mactcu))
    '                ExecSQLNonQuery("UPDATE CTTaiSan SET MaNhom=" & mcha & ", U2=1 WHERE U2=0 AND MN=" & rsItem("MaSo") & " AND MaCTKT>" & ConvertToStrSafe(mactcu))
    '            End If
    '        Next
    '        sqlcommand = New SqlCommand

    '        rs = ExecSQLReturnDT("SELECT LoaiTaiSan.*,PL.SoHieu AS SHCha FROM LoaiTaiSan LEFT JOIN LoaiTaiSan AS PL ON LoaiTaiSan.CapTren=PL.MaSo ORDER BY LoaiTaiSan.SoHieu")
    '        For Each rsItem As DataRow In rs.Rows
    '            sh = rsItem("SoHieu")
    '            i = 0
    '            mcha = SoHieu2MaSo(sh, "LoaiTaiSan")
    '            If mcha > 0 And tachsh > 0 Then
    '                Do While mcha > 0
    '                    i += 1
    '                    sh = sh & Chr(64 + i).ToString()
    '                    mcha = SoHieu2MaSo(sh, "LoaiTaiSan")
    '                Loop
    '            End If
    '            If mcha = 0 Then
    '                If rsItem("CapTren") > 0 Then
    '                    m1 = SoHieu2MaSo(rsItem("shcha"), "LoaiTaiSan")
    '                Else
    '                    m1 = 0
    '                End If
    '                If ExecSQLNonQuery("INSERT INTO LoaiTaiSan (MaSo,SoHieu,Ten,CapTren,Cap) VALUES (" & Lng_MaxValue("MaSo", "LoaiTaiSan") + 1 & ",'" & sh & "',N'" & rsItem("ten") & "'," + ConvertToStrSafe(m1) + "," + rsItem("cap") + ")", False) <> 0 Then
    '                    i = 1
    '                    Do While ExecSQLNonQuery("INSERT INTO LoaiTaiSan (MaSo,SoHieu,Ten,CapTren,Cap) VALUES (" & Lng_MaxValue("MaSo", "LoaiTaiSan") + 1 & ",'" & sh & "',N'" + rsItem("ten") + "-" + ConvertToStrSafe(i) + "'," + ConvertToStrSafe(m1) + "," + rsItem("cap") + ")", False) <> 0
    '                        i += 1
    '                    Loop
    '                End If
    '            End If
    '        Next
    '        rs = ExecSQLReturnDT("SELECT * FROM QuocGia ORDER BY Ten")
    '        For Each rsItem As DataRow In rs.Rows
    '            mcha = ConvertToDblSafe(GetSelectValue("SELECT MaSo AS F1 FROM QuocGia WHERE Ten=N'" + rsItem("ten") + "'"))
    '            If mcha = 0 Then
    '                ExecSQLNonQuery("INSERT INTO QuocGia (MaSo,Ten) VALUES (" & Lng_MaxValue("MaSo", "QuocGia") + 1 & ",N'" + rsItem("ten") + "'")
    '            End If
    '        Next
    '        rs = ExecSQLReturnDT("SELECT * FROM DTQLy ORDER BY Ten")
    '        For Each rsItem As DataRow In rs.Rows
    '            mcha = ConvertToDblSafe(GetSelectValue("SELECT MaSo AS F1 FROM DTQLy WHERE Ten=N'" + rsItem("ten") + "'"))
    '            If mcha = 0 Then
    '                ExecSQLNonQuery("INSERT INTO DTQLy (MaSo,Ten) VALUES (" & Lng_MaxValue("MaSo", "DTQLy") + 1 & ",N'" + rsItem("ten") + "'")
    '            End If
    '        Next
    '        rs = ExecSQLReturnDT("SELECT * FROM TinhTrang ORDER BY Ten")
    '        For Each rsItem As DataRow In rs.Rows
    '            mcha = ConvertToDblSafe(GetSelectValue("SELECT MaSo AS F1 FROM TinhTrang WHERE Ten=N'" + rsItem("ten") + "'"))
    '            If mcha = 0 Then
    '                ExecSQLNonQuery("INSERT INTO TinhTrang (MaSo,Ten) VALUES (" & Lng_MaxValue("MaSo", "TinhTrang") + 1 & ",N'" + rsItem("ten") + "'")
    '            End If
    '        Next
    '        If cnct Then
    '            ExecSQLNonQuery("UPDATE CTTaiSan SET U=0")
    '            sqlcommand.CommandText = "UPDATE TaiSan SET NamKH=0 WHERE NamKH is null"
    '            ExecuteSQLCommand(sqlcommand, Connecstring)
    '        End If
    '        rs = ExecSQLReturnDT("SELECT TaiSan.*,LoaiTaiSan.SoHieu AS SHT,L1.SoHieu AS SHL, L2.SoHieu AS SHN,QuocGia.Ten AS QG FROM (((TaiSan INNER JOIN QuocGia ON TaiSan.MaNuoc=QuocGia.MaSo) INNER JOIN LoaiTaiSan ON TaiSan.MaTaiKhoan=LoaiTaiSan.MaSo) INNER JOIN LoaiTaiSan AS L1 ON TaiSan.MaLoai=L1.MaSo) LEFT JOIN LoaiTaiSan AS L2 ON TaiSan.MaNhom=L2.MaSo WHERE TaiSan.NamSD<" & pNamTC & " ORDER BY TaiSan.SoHieu")
    '        For Each rsItem As DataRow In rs.Rows
    '            sh = rsItem("SoHieu")
    '            i = 0
    '            mcha = SoHieu2MaSo(sh, "TaiSan")
    '            If mcha > 0 And tachsh > 0 Then
    '                Do While mcha > 0
    '                    i += 1
    '                    sh = sh & Chr(64 + i).ToString()
    '                    mcha = SoHieu2MaSo(sh, "TaiSan")
    '                Loop
    '            End If
    '            If mcha = 0 Then
    '                ExecSQLNonQuery("INSERT INTO TaiSan (MaSo,Ten, SoHieu, NangLuc, GhiChu, MaNuoc, NamSX, NamSD, MaTaiKhoan, MaLoai, MaNhom, ThangTang, ThangGiam,NamKH VALUES (" & Lng_MaxValue("MaSo", "TaiSan") + 1 & ",N'" + rsItem("ten") + "','" + sh + "','" + rsItem("NangLuc") + "',N'" + rsItem("GhiChu") + "'," + ConvertToStrSafe(ST2MaSo("Ten", rsItem("QG"), "QuocGia")) + "," + rsItem("NamSX") + "," + rsItem("NamSD") + "," + ConvertToStrSafe(SoHieu2MaSo(rsItem("SHT"), "LoaiTaiSan")) + "," + ConvertToStrSafe(SoHieu2MaSo(rsItem("SHL"), "LoaiTaiSan")) + "," + ConvertToStrSafe(SoHieu2MaSo(IIf(IsDBNull(rsItem("SHN")), "", rsItem("SHN")), "LoaiTaiSan")) + "," + rsItem("ThangTang") + "," + rsItem("ThangGiam") + "," + rsItem("NamKH") + ")")
    '                mcha = SoHieu2MaSo(sh, "TaiSan")
    '                rs2 = ExecSQLReturnDT("SELECT CTTaiSan.*,LoaiChungTu.SoHieu AS SHL,LCT.SoHieu AS SHN FROM (CTTaiSan INNER JOIN LoaiChungTu ON CTTaiSan.MaLoai=LoaiChungTu.MaSo) INNER JOIN LoaiChungTu AS LCT ON CTTaiSan.MaNhom=LCT.MaSo WHERE (Thang=0) AND MaTS=" & rsItem("MaSo"))
    '                If rs2.Rows.Count > 0 Then
    '                    ExecSQLNonQuery("INSERT INTO CTTaiSan (MaSo,SoHieu, Thang, VaoSo, NgayGhi, DienGiai, MaLoai, MaNhom, MaTS, NG_NS, NG_TBS, NG_CNK, NG_TD, CL_NS, CL_TBS, CL_CNK, CL_TD VALUES (" & CStr(Lng_MaxValue("MaSo", "TaiSan") + 1) & ",'" & rs2.Rows(0)("SoHieu") & "'," + rs2.Rows(0)("thang") + ",'" + Format(CDate(rs2.Rows(0)("VaoSo")), Mask_DB) + "','" + Format(CDate(rs2.Rows(0)("NgayGhi")), Mask_DB) + "','" + rs2.Rows(0)("DienGiai") + "'," + ConvertToStrSafe(SoHieu2MaSo(rs2.Rows(0)("SHL"), "LoaiChungTu")) + "," + ConvertToStrSafe(SoHieu2MaSo(rs2.Rows(0)("SHN"), "LoaiChungTu")) + "," + ConvertToStrSafe(mcha) + "," + CStr(rs2.Rows(0)("NG_NS")) + "," + CStr(rs2.Rows(0)("NG_TBS")) + "," + CStr(rs2.Rows(0)("NG_CNK")) + "," + CStr(rs2.Rows(0)("NG_TD")) + "," + CStr(rs2.Rows(0)("CL_NS")) + "," + CStr(rs2.Rows(0)("CL_TBS")) + "," + CStr(rs2.Rows(0)("CL_CNK")) + "," + CStr(rs2.Rows(0)("CL_TD")) + ")")
    '                End If
    '                rs2 = ExecSQLReturnDT("SELECT ThongSo.*,HethongTK.SoHieu AS SHTK,DTQLy.Ten AS QL,TinhTrang.Ten AS TT FROM ((ThongSo INNER JOIN HethongTK ON ThongSo.MaDTSD=HethongTK.MaSo) INNER JOIN DTQLy ON ThongSo.MaDTQL=DTQLy.MaSo) INNER JOIN TinhTrang ON ThongSo.MaTTSD=TinhTrang.MaSo WHERE MaTS=" & rsItem("MaSo"))
    '                For Each rs2Item As DataRow In rs2.Rows
    '                    ExecSQLNonQuery("INSERT INTO ThongSo ( MaSo, MaTS, Thang, NG_NS, NG_TBS, NG_CNK, NG_TD, CL_NS, CL_TBS, CL_CNK, CL_TD, KH_NS, KH_TBS, KH_CNK, KH_TD, MaDTQL, MaDTSD, MaTTSD ) VALUES (" & Lng_MaxValue("MaSo", "ThongSo") + 1 & "," & ConvertToStrSafe(mcha) & "," & rs2.Rows(0)("thang") & "," & CStr(rs2.Rows(0)("NG_NS")) & "," & CStr(rs2.Rows(0)("NG_TBS")) & "," & CStr(rs2.Rows(0)("NG_CNK")) & "," & CStr(rs2.Rows(0)("NG_TD")) & "," & CStr(rs2.Rows(0)("CL_NS")) & "," & CStr(rs2.Rows(0)("CL_TBS")) & "," & CStr(rs2.Rows(0)("CL_CNK")) & "," & CStr(rs2.Rows(0)("CL_TD")) & "," & CStr(rs2.Rows(0)("KH_NS")) & "," & CStr(rs2.Rows(0)("KH_TBS")) & "," & CStr(rs2.Rows(0)("KH_CNK")) & "," & CStr(rs2.Rows(0)("KH_TD")) & "," & ConvertToStrSafe(ST2MaSo("Ten", rs2.Rows(0)("QL"), "DTQLy")) & "," & ConvertToStrSafe(MaTKFix(rs2.Rows(0)("shtk"), IIf(pTK > 0, pCT, String.Empty), tencn)) & "," & ConvertToStrSafe(ST2MaSo("Ten", rs2.Rows(0)("tt"), "TinhTrang")) & ")")
    '                Next
    '            End If
    '            If cnct Then ExecSQLNonQuery("UPDATE CTTaiSan SET MaTS=" & mcha & ",U=1 WHERE U=0 AND MaTS=" & rsItem("MaSo") & " AND MaCTKT>" & ConvertToStrSafe(mactcu))
    '        Next
    '        rs = Nothing
    '        If cnct Then SoDuTKTS() Else ChuyenNamMoiTS()
    '    End Sub
    '    Public Sub CongDKCCDC(ByRef mactcu As Integer, ByRef tencn As String, ByRef tachsh As Integer, ByRef cnct As Boolean, ByRef pTK As Integer, ByRef pCT As String, Optional ByRef cc As Integer = 0)
    '        Dim rs2 As DataTable
    '        Dim mcha, m1 As Integer
    '        Dim i As Integer
    '        Dim sh As String = String.Empty
    '        If cnct Then ExecSQLNonQuery("UPDATE CTCongcudungcu SET U=0, U2=0")
    '        Dim matscu As Integer = Lng_MaxValue("MaSo", "Congcudungcu")
    '        Dim rs As DataTable = ExecSQLReturnDT("SELECT LoaiChungTu.*,PL.SoHieu AS SHCha FROM LoaiChungTu LEFT JOIN LoaiChungTu AS PL ON LoaiChungTu.CapTren=PL.MaSo ORDER BY LoaiChungTu.SoHieu")
    '        For Each rsItem As DataRow In rs.Rows
    '            sh = rsItem("SoHieu")
    '            mcha = SoHieu2MaSo(sh, "LoaiChungTu")
    '            If mcha = 0 Then
    '                If rsItem("CapTren") > 0 Then
    '                    m1 = SoHieu2MaSo(rsItem("shcha"), "LoaiChungTu")
    '                Else
    '                    m1 = 0
    '                End If
    '                ExecSQLNonQuery("INSERT INTO LoaiChungTu (MaSo,SoHieu,Ten,CapTren,Cap) VALUES (" & Lng_MaxValue("MaSo", "LoaiChungTu") + 1 & ",'" & sh & "','" + rsItem("ten") + "'," + ConvertToStrSafe(m1) + "," + rsItem("cap") + "")
    '                mcha = SoHieu2MaSo(sh, "LoaiChungTu")
    '            End If
    '            If cnct Then
    '                ExecSQLNonQuery("UPDATE CTCongcudungcu SET MaLoai=" & mcha & ", U=1 WHERE U=0 AND ML=" & rsItem("MaSo") & " AND MaCTKT>" & ConvertToStrSafe(mactcu))
    '                ExecSQLNonQuery("UPDATE CTCongcudungcu SET MaNhom=" & mcha & ", U2=1 WHERE U2=0 AND MN=" & rsItem("MaSo") & " AND MaCTKT>" & ConvertToStrSafe(mactcu))
    '            End If
    '        Next
    '        rs = ExecSQLReturnDT("SELECT LoaiCongcudungcu.*,PL.SoHieu AS SHCha FROM LoaiCongcudungcu LEFT JOIN LoaiCongcudungcu AS PL ON LoaiCongcudungcu.CapTren=PL.MaSo ORDER BY LoaiCongcudungcu.SoHieu")
    '        Dim rsIndex As Integer = 0
    '        Do While rsIndex < rs.Rows.Count
    '            Dim rsItem As DataRow = rs.Rows(rsIndex)
    '            rsIndex += 1 ' C15 Rs LOOP CONTROL
    '            sh = rsItem("SoHieu")
    '            i = 0
    '            mcha = SoHieu2MaSo(sh, "LoaiCongcudungcu")
    '            If mcha > 0 And tachsh > 0 Then
    '                Do While mcha > 0
    '                    i += 1
    '                    sh = sh & Chr(64 + i).ToString()
    '                    mcha = SoHieu2MaSo(sh, "LoaiCongcudungcu")
    '                Loop
    '            End If
    '            If mcha = 0 Then
    '                If rsItem("CapTren") > 0 Then
    '                    m1 = SoHieu2MaSo(rsItem("shcha"), "LoaiCongcudungcu")
    '                Else
    '                    m1 = 0
    '                End If
    '                If ExecSQLNonQuery("INSERT INTO LoaiCongcudungcu (MaSo,SoHieu,Ten,CapTren,Cap) VALUES (" & Lng_MaxValue("MaSo", "LoaiCongcudungcu") + 1 & ",'" & sh & "','" + rsItem("ten") + "'," + ConvertToStrSafe(m1) + "," + rsItem("cap") + "", False) <> 0 Then
    '                    i = 1
    '                    Do While ExecSQLNonQuery("INSERT INTO LoaiCongcudungcu (MaSo,SoHieu,Ten,CapTren,Cap) VALUES (" & Lng_MaxValue("MaSo", "LoaiCongcudungcu") + 1 & ",'" & sh & "','" + rsItem("ten") + "-" + ConvertToStrSafe(i) + "'," + ConvertToStrSafe(m1) + "," + rsItem("cap") + "", False) <> 0
    '                        i += 1
    '                    Loop
    '                End If
    '            End If
    '        Loop
    '        If cnct Then
    '            ExecSQLNonQuery("UPDATE CTCongcudungcu SET U=0")
    '            sqlcommand.CommandType = CommandType.Text
    '            sqlcommand.CommandText = "UPDATE Congcudungcu SET NamKH=0 WHERE IsNull(NamKH)"
    '            ExecuteSQLCommand(sqlcommand, Connecstring)
    '        End If
    '        rs = ExecSQLReturnDT("SELECT Congcudungcu.*,LoaiCongcudungcu.SoHieu AS SHT,L1.SoHieu AS SHL, 0 AS SHN,'' AS QG FROM (Congcudungcu INNER JOIN LoaiCongcudungcu ON Congcudungcu.MaTaiKhoan=LoaiCongcudungcu.MaSo) INNER JOIN LoaiCongcudungcu AS L1 ON Congcudungcu.MaLoai=L1.MaSo WHERE Congcudungcu.NamSX=" & cc & " and Congcudungcu.NamSD=1 ORDER BY Congcudungcu.SoHieu")
    '        For Each rsItem As DataRow In rs.Rows
    '            sh = rsItem("SoHieu")
    '            i = 0
    '            mcha = SoHieu2MaSo(sh, "Congcudungcu")
    '            If mcha > 0 And tachsh > 0 Then
    '                Do While mcha > 0
    '                    i += 1
    '                    sh = sh & Chr(64 + i).ToString()
    '                    mcha = SoHieu2MaSo(sh, "Congcudungcu")
    '                Loop
    '            End If
    '            If mcha = 0 Then
    '                ExecSQLNonQuery("INSERT INTO Congcudungcu (MaSo,Ten, SoHieu, NangLuc, GhiChu, MaNuoc, NamSX, NamSD, MaTaiKhoan, MaLoai, MaNhom, ThangTang, ThangGiam,NamKH,shct VALUES (" & Lng_MaxValue("MaSo", "Congcudungcu") + 1 & ",'" + rsItem("ten") + "','" + sh + "','" + rsItem("NangLuc") + "','" + rsItem("GhiChu") + "'," + ConvertToStrSafe(ST2MaSo("Ten", rsItem("QG"), "QuocGia")) + "," + rsItem("NamSX") + "," + rsItem("NamSD") + "," + ConvertToStrSafe(SoHieu2MaSo(rsItem("SHT"), "LoaiCongcudungcu")) + "," + ConvertToStrSafe(SoHieu2MaSo(rsItem("SHL"), "LoaiCongcudungcu")) + "," + ConvertToStrSafe(SoHieu2MaSo(IIf(IsDBNull(rsItem("SHN")), "", rsItem("SHN")), "LoaiCongcudungcu")) + "," + rsItem("ThangTang") + "," + rsItem("ThangGiam") + "," + rsItem("NamKH") + ",'" + rsItem("shct") + "')")
    '                mcha = SoHieu2MaSo(sh, "Congcudungcu")
    '                rs2 = ExecSQLReturnDT("SELECT CTCongcudungcu.*,LoaiChungTu.SoHieu AS SHL,0 AS SHN FROM CTCongcudungcu INNER JOIN LoaiChungTu ON CTCongcudungcu.MaLoai=LoaiChungTu.MaSo WHERE (Thang=0) AND MaTS=" & rsItem("MaSo"))
    '                If rs2.Rows.Count > 0 Then
    '                    ExecSQLNonQuery("INSERT INTO CTCongcudungcu (MaSo,SoHieu, Thang, VaoSo, NgayGhi, DienGiai, MaLoai, MaNhom, MaTS, NG_NS, NG_TBS, NG_CNK, NG_TD, " & "CL_NS, CL_TBS, CL_CNK, CL_TD VALUES (" & Lng_MaxValue("MaSo", "CTCongcudungcu") + 1 & ",'" + rs2.Rows(0)("SoHieu") + "'," + rs2.Rows(0)("thang") + ",'" + Format(CDate(rs2.Rows(0)("VaoSo")), Mask_DB) + "','" + Format(CDate(rs2.Rows(0)("NgayGhi")), Mask_DB) + "','" + rs2.Rows(0)("DienGiai") + "'," + ConvertToStrSafe(SoHieu2MaSo(rs2.Rows(0)("SHL"), "LoaiChungTu")) + "," + ConvertToStrSafe(SoHieu2MaSo(rs2.Rows(0)("SHN"), "LoaiChungTu")) + "," + ConvertToStrSafe(mcha) + "," + CStr(rs2.Rows(0)("NG_NS")) + "," + CStr(rs2.Rows(0)("NG_TBS")) + "," + CStr(rs2.Rows(0)("NG_CNK")) + "," + CStr(rs2.Rows(0)("NG_TD")) + "," + CStr(rs2.Rows(0)("CL_NS")) + "," + CStr(rs2.Rows(0)("CL_TBS")) + "," + CStr(rs2.Rows(0)("CL_CNK")) + "," + CStr(rs2.Rows(0)("CL_TD")) + ")")
    '                End If
    '                rs2 = ExecSQLReturnDT("SELECT Thongso1.*,HethongTK.SoHieu AS SHTK,'' AS QL,'' AS TT FROM Thongso1 INNER JOIN HethongTK ON Thongso1.MaDTSD=HethongTK.MaSo WHERE MaTS=" & rsItem("MaSo"))
    '                For Each rs2Item As DataRow In rs2.Rows
    '                    ExecSQLNonQuery("INSERT INTO Thongso1 ( MaSo, MaTS, Thang, NG_NS, NG_TBS, NG_CNK, NG_TD, CL_NS, CL_TBS, CL_CNK, CL_TD, KH_NS, KH_TBS, KH_CNK, KH_TD, MaDTQL, MaDTSD, MaTTSD ) VALUES (" & Lng_MaxValue("MaSo", "Thongso1") + 1 & "," & ConvertToStrSafe(mcha) & "," & rs2.Rows(0)("thang") & "," & CStr(rs2.Rows(0)("NG_NS")) & "," & CStr(rs2.Rows(0)("NG_TBS")) & "," & CStr(rs2.Rows(0)("NG_CNK")) & "," & CStr(rs2.Rows(0)("NG_TD")) & "," & CStr(rs2.Rows(0)("CL_NS")) & "," & CStr(rs2.Rows(0)("CL_TBS")) & "," & CStr(rs2.Rows(0)("CL_CNK")) & "," & CStr(rs2.Rows(0)("CL_TD")) & "," & CStr(rs2.Rows(0)("KH_NS")) & "," & CStr(rs2.Rows(0)("KH_TBS")) & "," & CStr(rs2.Rows(0)("KH_CNK")) & "," & CStr(rs2.Rows(0)("KH_TD")) & "," & ConvertToStrSafe(ST2MaSo("Ten", rs2.Rows(0)("QL"), "DTQLy")) & "," & ConvertToStrSafe(MaTKFix(rs2.Rows(0)("shtk"), IIf(pTK > 0, pCT, String.Empty), tencn)) & "," & ConvertToStrSafe(ST2MaSo("Ten", rs2.Rows(0)("tt"), "TinhTrang")) & ")")
    '                Next
    '            End If
    '            If cnct Then ExecSQLNonQuery("UPDATE CTCongcudungcu SET MaTS=" & mcha & ",U=1 WHERE U=0 AND MaTS=" & rsItem("MaSo") & " AND MaCTKT>" & ConvertToStrSafe(mactcu))
    '        Next
    '        rs = Nothing
    '        If cnct Then SoDuTKTSCCDC() Else ChuyenNamMoiCCDC()
    '    End Sub
    '    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
    '        Command(2).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
    '    End Sub

End Class
