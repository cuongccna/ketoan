Imports System
Imports System.Text
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmSoducongno
    Dim tdau, tcuoi As Integer
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Select Case Index
            Case 0
                If CboThang(1).Items.Count > 0 Then
                    If CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
                End If

                tdau = CboThang(0).SelectedValue
                tcuoi = CboThang(1).SelectedValue
                LietkeCN(tdau, tcuoi, IIf(Opt(0).Checked And ConvertToDblSafe(txtShTk.Tag) > 0, txtShTk.Text, String.Empty), IIf(Opt(1).Checked, CboKH.SelectedIndex, 0), 0)
            Case 1
                Me.Close()
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmSoducongno_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.V
                    Command(1).Focus()
                    'Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.L
                    Command(0).Focus()
                    'Command_ClickEvent(Command(0), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Command_ClickEvent(Command(1), New EventArgs())
    End Sub

    Private Sub Khoi_Tao()
        ColumnSetUp(Grd, 0, 350, 2)
        ColumnSetUp(Grd, 1, 1060, 0)
        ColumnSetUp(Grd, 2, 2750, 0)
        ColumnSetUp(Grd, 3, 1190, 2)
        ColumnSetUp(Grd, 4, 1190, 4)
        ColumnSetUp(Grd, 5, 1190, 4)
        ColumnSetUp(Grd, 6, 1190, 4)
        ColumnSetUp(Grd, 7, 1190, 4)
        ColumnSetUp(Grd, 8, 1190, 4)
        ColumnSetUp(Grd, 9, 1310, 4)
        ColumnSetUp(Grd, 10, 1400, 4)
        Grd.Cols = 11
    End Sub
    Dim co As Integer = 0
    Private Sub FrmSoducongno_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()
            If co = 0 Then Khoi_Tao()

            Int_RecsetToCbo("SELECT DISTINCT MaSo As F2,SoHieu + ' - '  + TenPhanLoai As F1 FROM PhanLoaiKhachHang WHERE PLCon=0 AND LEFT(SoHieu,1)<>'#' ORDER BY SoHieu + ' - '  + TenPhanLoai", CboKH)
            If flag = 0 Then
                AddMonthToCbo(CboThang(0))
                AddMonthToCbo(CboThang(1))
            End If

            SetFont(Me)
            SetFontBar()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    Private Sub SetFontBar()
        If pNN = 1 Then
            Dim s As String
            With MainMenu1
                For i = 0 To .Items.Count - 1
                    s = .Items(i).Tag
                    If s Is Nothing Then s = ""
                    If s.Length > 0 And Not IsNumeric(s) Then
                        .Items(i).Tag = .Items(i).Text
                        .Items(i).Text = s
                    End If
                    SetFontMenu(.Items(i))
                Next
            End With
        End If
    End Sub
    Private Sub SetFontMenu(ByVal menucon As System.Windows.Forms.ToolStripMenuItem)
        Dim s As String
        With menucon
            If .DropDownItems.Count = 0 Then
                Exit Sub
            Else
                For i = 0 To .DropDownItems.Count - 1
                    s = .DropDownItems(i).Tag
                    If s Is Nothing Then s = ""
                    If s.Length > 0 And Not IsNumeric(s) Then
                        .DropDownItems(i).Tag = .DropDownItems(i).Text
                        .DropDownItems(i).Text = s
                        SetFontMenu(.DropDownItems(i))
                    End If
                Next
            End If
        End With
    End Sub


    Dim flag As Integer = 0
    Public Sub Hienthi(ByRef LoaiKH As Integer, ByRef kh As String, ByRef tdau As Integer, ByRef tcuoi As Integer)
        flag = 1
        AddMonthToCbo(CboThang(0))
        AddMonthToCbo(CboThang(1))
        Opt(LoaiKH).Checked = True
        If LoaiKH = 0 Then
            txtShTk.Text = kh : txtShTk_Leave(txtShTk, New EventArgs())
        Else
            CboKH.Text = kh
        End If
        If CboThang(0).Items.Count > 0 Then CboThang(0).SelectedIndex = tdau - 1
        If CboThang(1).Items.Count > 0 Then CboThang(1).SelectedIndex = tcuoi - 1
        co = 1
        Me.ShowDialog()
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Grd.Rows = 30
        ClearGrid(Grd, Grd.Rows)
        Command_ClickEvent(Command(0), New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tdau"></param>
    ''' <param name="tcuoi"></param>
    ''' <param name="shtk"></param>
    ''' <param name="mpl"></param>
    ''' <param name="loai"></param>
    ''' <param name="th"></param>
    ''' <remarks></remarks>
    Private Sub LietkeCN(ByRef tdau As Integer, ByRef tcuoi As Integer, ByRef shtk As String, ByRef mpl As Integer, ByRef loai As Integer, Optional ByRef th As Integer = 0)

        Dim st As String = String.Empty
        Dim sqlc2 As New StringBuilder
        Dim sqln2 As New StringBuilder
        Dim sqlc As New StringBuilder
        Dim sqln As New StringBuilder
        Dim i As Integer
        Dim X, z As Double
        Dim sqlcx2 As New StringBuilder
        Dim sqlnx2 As New StringBuilder
        Dim sqlcx As New StringBuilder
        Dim sqlnx As New StringBuilder
        Dim nox, tkno, ckno, dkno, dkco, ckco, TkCo, cox As Double
        For i = CThangDB2(tdau) To CThangDB2(tcuoi)
            st = ConvertToStrSafe(i)
            sqln.Append(" + SoDuKhachHang.No_" & st)
            sqlc.Append(" + SoDuKhachHang.Co_" & st)
            sqln2.Append(" + SoDuKhachHang.No_" & st & "_NT")
            sqlc2.Append(" + SoDuKhachHang.Co_" & st & "_NT")
        Next
        For i = 1 To tcuoi
            st = ConvertToStrSafe(i)
            sqlnx.Append(" + SoDuKhachHang.No_" & st)
            sqlcx.Append(" + SoDuKhachHang.Co_" & st)
            sqlnx2.Append(" + SoDuKhachHang.No_" & st & "_NT")
            sqlcx2.Append(" + SoDuKhachHang.Co_" & st & "_NT")
        Next
        st = ConvertToStrSafe(CThangDB2(ThangTruoc(tdau)))
        Dim QChitiet As String = "SELECT DISTINCT KhachHang.SoHieu, KhachHang.Ten, PhanLoaiKhachHang.SoHieu AS SHPL, TenPhanLoai,KyHieu," & " Sum(SoDuKhachHang.DuNo_" & st & ") AS DkNo, Sum(SoDuKhachHang.DuCo_" & st & ") AS DkCo, Sum(SoDuKhachHang.DuNT_" & st & ") AS DkNT, Sum(" & sqln.ToString() & ") AS PsNo, Sum(" & sqln2.ToString() & ") AS PsNo2, Sum(" & sqlc.ToString() & ") AS PsCo, Sum(" & sqlc2.ToString() & ") AS PsCo2, Sum(" & sqlnx.ToString() & ") AS PsNoX, Sum(" & sqlnx2.ToString() & ") AS PsNoX2, Sum(" & sqlcx.ToString() & ") AS PsCoX, Sum(" & sqlcx2.ToString() & ") AS PsCoX2, Sum(SoDuKhachHang.DuNo_" & ConvertToStrSafe(tcuoi) & ") AS CkNo, Sum(SoDuKhachHang.DuCo_" & ConvertToStrSafe(tcuoi) & ") AS CkCo, Sum(SoDuKhachHang.DuNT_" & ConvertToStrSafe(tcuoi) & ") AS CkNT,PhanLoaiKhachHang.PLCha" & " FROM (((KhachHang INNER JOIN PhanLoaiKhachHang ON KhachHang.MaPhanLoai=PhanLoaiKhachHang.MaSo) INNER JOIN SoDuKhachHang ON KhachHang.MaSo=SoDuKhachHang.MaKhachHang) INNER JOIN HethongTK ON SoDuKhachHang.MaTaiKhoan=HethongTK.MaSo) LEFT JOIN NguyenTe ON KhachHang.MaNT=NguyenTe.MaSo " & " WHERE (SoDuKhachHang.DuNo_" & st & "<>0 OR SoDuKhachHang.DuCo_" & st & "<>0 OR (" & sqlnx.ToString() & ") <>0 OR (" & sqlcx.ToString() & ") <>0)" & (IIf(shtk.Length > 0, " AND HethongTK.SoHieu LIKE '" & shtk & "%'", String.Empty)) & (IIf(mpl > 0, " AND MaPhanLoai=" & mpl, String.Empty)) & (IIf(loai > 0, " AND KhachHang.MaNT>0", String.Empty)) & " AND LEFT(KhachHang.SoHieu,1)<>'' GROUP BY PhanLoaiKhachHang.Sohieu,KhachHang.SoHieu,KhachHang.Ten,TenPhanLoai,KyHieu,PLCha"
        Dim QSoCai As String = String.Format("SELECT QChitiet.*, PhanLoaiKhachHang.SoHieu AS SH2,PhanLoaiKhachHang.TenPhanLoai AS TenPhanLoai2,PhanLoaiKhachHang.PLCha AS PLCha2 FROM ({0}) as QChitiet LEFT JOIN PhanLoaiKhachHang ON QChitiet.PLCha=PhanLoaiKhachHang.MaSo", QChitiet)
        Dim sql As String = String.Format("SELECT QSoCai.*, PhanLoaiKhachHang.SoHieu AS SH1,PhanLoaiKhachHang.TenPhanLoai AS TenPhanLoai1 FROM ({0}) as QSoCai LEFT JOIN PhanLoaiKhachHang ON QSoCai.PLCha2=PhanLoaiKhachHang.MaSo", QSoCai)
        Dim rs As DataTable = ExecSQLReturnDT(sql)
        ClearGrid(Grd, Grd.Rows)
        Khoi_Tao()
        For i = 0 To rs.Rows.Count - 1
            Grd.AddItem(String.Format("{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}", Chr(9), " "))
        Next
        If rs.Rows.Count > 0 Then
            'rs.MoveLast()
            GauGe.Maximum = rs.Rows.Count
            Grd.Rows = rs.Rows.Count
            i = 1
            GauGe.Value = 1
            ''rs.MoveFirst()
            Dim rsIndex As Integer = 0
            While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                With Grd
                    .Row = (i - 1)
                    .Col = 0
                    .CtlText = ConvertToStrSafe(i)
                    .Col = 1
                    .CtlText = rsItem("SoHieu")
                    .Col = 2
                    .CtlText = rsItem("ten")
                    X = rsItem("dkno") : z = rsItem("dkco")
                    .Col = 3
                    If X - z > 0 Then
                        .CtlText = Format(X - z, Mask_0) : dkno = dkno + X - z
                    End If
                    .Col = 4
                    If z - X > 0 Then
                        .CtlText = Format(z - X, Mask_0) : dkco = dkco + z - X
                    End If
                    .Col = 5 : X = rsItem("psno")
                    .CtlText = Format(X, Mask_0) : tkno += X
                    .Col = 6 : X = rsItem("psnox")
                    .CtlText = Format(X, Mask_0) : nox += X
                    .Col = 7 : X = rsItem("psco")
                    .CtlText = Format(X, Mask_0) : TkCo += X
                    .Col = 8 : X = rsItem("pscox")
                    .CtlText = Format(X, Mask_0) : cox += X
                    X = rsItem("ckno") : z = rsItem("ckco")
                    .Col = 9
                    If X - z > 0 Then
                        .CtlText = Format(X - z, Mask_0) : ckno = ckno + X - z
                    End If
                    .Col = 10
                    If z - X > 0 Then
                        .CtlText = Format(z - X, Mask_0) : ckco = ckco + z - X
                    End If
                End With
                GauGe.Value = i
                i += 1
                ''rs.MoveNext()
            End While
        End If
        Label(30).Text = Format(dkno, Mask_0)
        Label(31).Text = Format(dkco, Mask_0)
        Label(32).Text = Format(tkno, Mask_0)
        Label(33).Text = Format(nox, Mask_0)
        Label(34).Text = Format(TkCo, Mask_0)
        Label(35).Text = Format(cox, Mask_0)
        Label(36).Text = Format(ckno, Mask_0)
        Label(37).Text = Format(ckco, Mask_0)
        Text = "Bảng tổng hợp số dư công nợ trong kỳ " & CboThang(0).Text & " - " & CboThang(1).Text
        If Grd.Rows < 29 Then Grd.Rows = 29
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdtk_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdtk.Click
        Me.Cursor = Cursors.WaitCursor
        txtShTk.Text = FrmTaikhoan.ChonTk(txtShTk.Text)
        txtShTk.Focus()
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Grd_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Grd.DoubleClick
        If CboThang(1).Items.Count > 0 Then If CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
        tdau = CboThang(0).SelectedValue
        tcuoi = CboThang(1).SelectedValue
        Grd.Col = 1
        FrmSochitietKh.Hienthi(tdau, tcuoi, ConvertToStrSafe(SoHieu2MaSo(Grd.CtlText, "khachhang")))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Grd_KeyUpEvent(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles Grd.KeyUp
        If eventArgs.KeyCode = 37 Or eventArgs.KeyCode = 38 Or eventArgs.KeyCode = 39 Or eventArgs.KeyCode = 40 Then SetGridIndex(Grd, Grd.Row)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtShTk.Enter
        txtShTk_Leave(txtShTk, New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles txtShTk.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then
            Me.Cursor = Cursors.WaitCursor
            txtShTk.Text = FrmTaikhoan.ChonTk(txtShTk.Text)
            txtShTk.Focus()
            Me.Cursor = Cursors.Default
        End If
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTk_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtShTk.Leave
        Dim mtk As Integer
        LbTenTk.Text = tentk(txtShTk.Text, mtk)
        txtShTk.Tag = ConvertToStrSafe(mtk)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmSoducongno_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
