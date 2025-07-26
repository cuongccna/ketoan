Imports System
Imports System.Data
Imports System.Text
Imports System.Drawing
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmThKC

    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim thangdau, thangcuoi As Integer
        Me.Cursor = Cursors.WaitCursor
        Select Case Index
            Case 0
                If CboThang(0).Items.Count > 0 Then
                    If CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
                End If

                thangdau = CboThang(0).SelectedValue
                thangcuoi = CboThang(1).SelectedValue
                For j As Integer = thangdau To thangcuoi
                    If ConvertToDblSafe(GetSelectValue(String.Format("SELECT lock{0} as f1 FROM license", j))) = 1 Then
                        If FrmPassword.GetPswX(String.Format("Dữ liệu tháng {0} đã bị khoá. Nhập mật khẩu ...", j)) <> "MS" Then GoTo kt
                    End If
                    If Not KiemTraThueGTGT(j) Then GoTo kt
                    For i As Integer = 0 To MaxKC - 1
                        If ConvertToDblSafe((ChkKC(i).Tag)) = 0 Then
                            Exit For
                        Else
                            If ChkKC(i).CheckState = CheckState.Checked Then KCTuDong(j, ConvertToDblSafe(ChkKC(i).Tag), ConvertToDblSafe(txt.Text))
                        End If
                    Next
                Next
        End Select
kt:
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        If Not ChkKC(0).Visible Then
            Me.Close()
            Exit Sub
        End If
        Khoaquyen()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmThKC_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.T
                    Command(0).Focus()
                    ' Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.V
                    Command(1).Focus()
                    '  Command_ClickEvent(Command(1), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmThKC_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            ChkKC(0).Visible = True
            Call FormInit()

            Dim i As Integer
            AddMonthToCbo(CboThang(0))
            AddMonthToCbo(CboThang(1))
            Dim rs As DataTable = ExecSQLReturnDT("SELECT * FROM CTKetChuyen ORDER BY STT")
            For Each rsItem As DataRow In rs.Rows
                ChkKC(i).Text = ConvertToStrSafe(rsItem("DienGiai"))
                ChkKC(i).Tag = ConvertToStrSafe(rsItem("MaSo"))
                'ChkKC(i).Font = New Font(pFontName, pFontSize)
                ChkKC(i).Visible = True
                ChkKC(i).CheckState = CheckState.Checked
                i += 1
                If i >= MaxKC Then GoTo kt
            Next
            LbKC(1).Visible = (pTygia > 0)
            txt.Visible = (pTygia > 0)
            If pTygia > 0 Then txt.Text = Format(TyGiaCuoi(), Mask_0)
            SetFont(Me)
kt:
            'If i > 0 Then Me.Height = ChkKC(0).Top + (i * 36)
            'Me.Width += VB6.TwipsToPixelsX(((iif(i / 16 > 0, Math.Floor(i / 16), Math.Ceiling(i / 16))) + (iif(i Mod 16 > 0, 0, -1))) * 3495)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    Function KiemTraThueGTGT(ByRef thang As Integer) As Boolean
        Dim result As Boolean = False
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        Dim cuoikyco, cuoikyno As Double
        Dim saukc As Boolean = True
        Dim tdau As Integer = thang
        Dim tcuoi As Integer = thang
        SoDuTKCN2(ThangTruoc(tdau))
        SoDuTKCN2(tcuoi)
        If Not saukc Then XacdinhKC(tdau, tcuoi)
        For i As Integer = CThangDB2(tdau) To CThangDB2(tcuoi)
            If sqln.Length = 0 Then
                sqln.Append(String.Format("HethongTk.No_{0}", i))
            Else
                sqln.Append(String.Format(" + HethongTk.No_{0}", i))
            End If

            If sqlc.Length = 0 Then
                sqlc.Append(String.Format("HethongTk.Co_{0}", i))
            Else
                sqlc.Append(String.Format(" + HethongTk.Co_{0}", i))
            End If
        Next
        Dim str As String = "SELECT DISTINCT HeThongTK.SoHieu, HeThongTK.Cap, HeThongTK.Ten," _
            & " HeThongTK.Kieu, HeThongTK.Loai, HeThongTK.DuNo_" + CStr(CThangDB(ThangTruoc(tdau))) + " As DkNo" _
            & " From HeThongTK Where (sohieu like '133%' or sohieu like '333%') and((HeThongTK.MaTC = 0 Or HethongTK.MaTC = HethongTK.MaSo) OR (TK_ID3 % 10 >= 1)) And (HeThongTK.Loai > 0)"
        
        Dim rs As DataTable = ExecSQLReturnDT("SELECT sohieu,dkno FROM (" & str & ") as qcdt WHERE sohieu='13311' or sohieu='33311'")
        Dim dem As Integer = 0
        For Each rsItem As DataRow In rs.Rows
            Dim Sohieu As String = ConvertToStrSafe(rsItem("SoHieu"))
            If Sohieu = "33311" Then
                dem += 1
                cuoikyco = ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(sops) as f1 FROM chungtu t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE t1.maloai=8 and left(t2.sohieu,5)='33311' and thangct>={0} and thangct<={1}", _
                                                                CThangDB(tdau), _
                                                                CThangDB(tcuoi))))
                cuoikyco -= ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(sops) as f1 FROM chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE t1.maloai=8 and left(t2.sohieu,5)='33311' and thangct>={0} and thangct<={1}", _
                                                                 CThangDB(tdau), _
                                                                 CThangDB(tcuoi))))
            End If
            If Sohieu Like "1331*" Then
                dem += 1
                cuoikyno = ConvertToDblSafe(rsItem("dkno")) + ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(sops) as f1 FROM chungtu t1 inner join hethongtk t2 on t1.matkno=t2.maso WHERE t1.maloai<>3 and left(t2.sohieu,4)='1331' and thangct>={0} and thangct<={1}", _
                                                                                                  CThangDB(tdau), _
                                                                                                  CThangDB(tcuoi))))
                cuoikyno -= ConvertToDblSafe(GetSelectValue(String.Format("SELECT sum(sops) as f1 FROM chungtu t1 inner join hethongtk t2 on t1.matkco=t2.maso WHERE t1.maloai<>3 and left(t2.sohieu,4)='1331' and thangct>={0} and thangct<={1}", _
                                                                CThangDB(tdau), _
                                                                CThangDB(tcuoi))))
            End If
            If dem = 2 Then
                Exit For
            End If
        Next
        rs = ExecSQLReturnDT("SELECT maso FROM ctketchuyen WHERE tk1='133' or tk1='333' order by stt DESC")
        Dim rsIndex As Integer = 1
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            ExecSQLNonQuery(String.Format("DELETE FROM ctketchuyen WHERE maso={0}", rsItem("MaSo")))
            rsIndex += 1
        Loop
        Dim rs1 As DataTable
        Dim taikhoan1, Taikhoan2 As Integer
        Dim Tk1, Tk2 As String
        Dim makc, MaSo As Integer
        If cuoikyno <= cuoikyco Then
            Tk1 = "tk1"
            Tk2 = "tk2"
        Else
            Tk1 = "tk2"
            Tk2 = "tk1"
        End If
        ExecSQLNonQuery(String.Format("UPDATE ctketchuyen set {0}='133',{1}='333' WHERE tk1='333' or tk1='133'", _
                            Tk1, _
                            Tk2))
        rs = ExecSQLReturnDT("SELECT maso FROM ctketchuyen WHERE tk1='133' or  tk1='333'")
        If rs.Rows.Count > 0 Then
            rs1 = ExecSQLReturnDT("SELECT maso FROM hethongtk WHERE left(sohieu,5)='13311' and cap>=(SELECT max(cap) FROM hethongtk WHERE left(sohieu,5)='13311') and (right(sohieu,len(sohieu)-5) = '1' or  right(sohieu,len(sohieu)-5) = '11' or  right(sohieu,len(sohieu)-5) = '111')")
            If rs1.Rows.Count > 0 Then
                Dim rs1Item As DataRow = rs1.Rows(0)
                taikhoan1 = ConvertToStrSafe(rs1Item("MaSo"))
            End If
            rs1 = ExecSQLReturnDT("SELECT maso FROM hethongtk WHERE left(sohieu,5)='33311' and cap>=(SELECT max(cap) FROM hethongtk WHERE left(sohieu,5)='33311') and (right(sohieu,len(sohieu)-5) = '1' or  right(sohieu,len(sohieu)-5) = '11' or  right(sohieu,len(sohieu)-5) = '111')")
            If rs1.Rows.Count > 0 Then
                Dim rs1Item As DataRow = rs1.Rows(0)
                Taikhoan2 = ConvertToStrSafe(rs1Item("MaSo"))
            End If
            ExecSQLNonQuery(String.Format("UPDATE kcchitiet set {0}={1},{2}={3} WHERE ({0}={1} and {2}={3})or({2}={1} and {0}={3})", _
                                Tk1, _
                                taikhoan1, _
                                Tk2, _
                                Taikhoan2))
            makc = ConvertToDblSafe(GetSelectValue(String.Format("SELECT makc as f1 FROM kcchitiet WHERE {0}={1} and {2}={3}", _
                                                       Tk1, _
                                                       taikhoan1, _
                                                       Tk2, _
                                                       Taikhoan2)))
            rs1 = ExecSQLReturnDT("SELECT maso FROM hethongtk WHERE left(sohieu,5)='13311' and cap>=all(SELECT cap FROM hethongtk WHERE left(sohieu,5)='13311') and (right(sohieu,len(sohieu)-5) = '2' or  right(sohieu,len(sohieu)-5) = '21' or  right(sohieu,len(sohieu)-5) = '211')")
            If rs1.Rows.Count > 0 Then
                Dim rs1Item As DataRow = rs1.Rows(0)
                taikhoan1 = ConvertToStrSafe(rs1Item("MaSo"))
            End If
            MaSo = ConvertToDblSafe(GetSelectValue(String.Format("SELECT maso as f1 FROM kcchitiet WHERE ({0}={1} and {2}={3})or({2}={1} and {0}={3})", _
                                                       Tk1, _
                                                       taikhoan1, _
                                                       Tk2, _
                                                       Taikhoan2)))
            If MaSo > 0 Then
                ExecSQLNonQuery(String.Format("UPDATE kcchitiet set {0}={1},{2}={3} WHERE maso={4}", _
                                    Tk1, _
                                    taikhoan1, _
                                    Tk2, _
                                    Taikhoan2, _
                                    MaSo))
            Else
                ExecSQLNonQuery(String.Format("INSERT into kcchitiet(Maso,makc,{0},{1}) values({5},{2},{3},{4})", _
                                    Tk1, _
                                    Tk2, _
                                    makc, _
                                    taikhoan1, _
                                    Taikhoan2, _
                                    Lng_MaxValue("MaSo", "KCChitiet") + 1))
            End If
        End If
        Return True
    End Function
    Private Sub txt_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txt.Enter
        txt.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txt_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles txt.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        KeyProcess(txt, KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(0).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmThKC_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
