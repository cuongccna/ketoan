Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmNguon

    Dim ThemMoi As Integer

    ''' <summary>
    ''' Thêm, Ghi, Xóa nguyên tệ
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_2.Click, _Command_3.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim sql As String = String.Empty
        Select Case Index
            Case 0
                ThemMoi = 1
                txtNhap(0).Text = ""
                txtNhap(0).Focus()
                Khoaquyen()
            Case 1
                Me.Cursor = Cursors.WaitCursor
                Select Case ThemMoi
                    Case 0
                        ' If flag = True Then
                        Dim sql1 As String = "select * from NguonNhapXuat where SoHieu= '" & GrdNT.CtlText & "'"
                        Dim rs_chungtu As New DataTable
                        rs_chungtu = ExecSQLReturnDT(sql1)
                        If rs_chungtu.Rows.Count = 0 Then
                            If ExecSQLNonQuery("INSERT INTO NguonNhapXuat (MaSo,SoHieu,DienGiai) VALUES (" & Lng_MaxValue("MaSo", "NguonNhapXuat") + 1 & ",'" & txtNhap(0).Text & "',N'" & txtNhap(1).Text & "')") <> 0 Then GoTo XongNguon
                            GrdNT.AddItem(txtNhap(0).Text & Chr(9).ToString() & txtNhap(1).Text, InsertGridRow(GrdNT, 0, txtNhap(0).Text))
                            ThemMoi = 0
                            GrdNT.Row = ConvertToDblSafe(GrdNT.Rows - 1)
                            GrdNT.Col = 0
                            If Strings.Len(GrdNT.CtlText) = 0 Then
                                GrdNT.RemoveItem(GrdNT.Row)
                                GrdNT.Row = 0
                            End If
                        Else
                            GrdNT.Col = 0
                            If Strings.Len(GrdNT.CtlText) = 0 Or ExecSQLNonQuery("UPDATE NguonNhapXuat SET SoHieu= '" & txtNhap(0).Text & "', DienGiai=N'" & txtNhap(1).Text & "' WHERE SoHieu='" & GrdNT.CtlText & "'") <> 0 Then GoTo XongNguon
                            GrdNT.CtlText = txtNhap(0).Text
                            GrdNT.Col = 1
                            GrdNT.CtlText = txtNhap(1).Text
                            GrdNT.Col = 0
                        End If

                        'Else
                        '    flag = True
                        'End If

                    Case 1
                        ' If flag = True Then
                        If ExecSQLNonQuery("INSERT INTO NguonNhapXuat (MaSo,SoHieu,DienGiai) VALUES (" & Lng_MaxValue("MaSo", "NguonNhapXuat") + 1 & ",'" & txtNhap(0).Text & "',N'" & txtNhap(1).Text & "')") <> 0 Then GoTo XongNguon
                        GrdNT.AddItem(txtNhap(0).Text & Chr(9).ToString() & txtNhap(1).Text, InsertGridRow(GrdNT, 0, txtNhap(0).Text))
                        ThemMoi = 0
                        GrdNT.Row = ConvertToDblSafe(GrdNT.Rows - 1)
                        GrdNT.Col = 0
                        If Strings.Len(GrdNT.CtlText) = 0 Then
                            GrdNT.RemoveItem(GrdNT.Row)
                            GrdNT.Row = 0
                        End If
                        'Else
                        '    flag = True
                        'End If
                End Select
            Case 2
                '  If flag = True Then
                GrdNT.Col = 0
                If Strings.Len(GrdNT.CtlText) = 0 Then Exit Sub
                Me.Cursor = Cursors.WaitCursor
                sql = "SELECT DISTINCT Count(Chungtu.MaSo) AS F1 FROM Chungtu INNER JOIN NguonNhapXuat ON Chungtu.MaNguon = NguonNhapXuat.MaSo" & " WHERE (Chungtu.MaLoai = 1 Or Chungtu.MaLoai=2) AND Chungtu.MaVattu>0 And NguonNhapXuat.SoHieu = '" & GrdNT.CtlText & "'"
                If ConvertToDblSafe(GetSelectValue(sql)) = 0 Then
                    Dim d As Integer = ExecSQLNonQuery("DELETE FROM NguonNhapXuat WHERE Sohieu='" & txtNhap(0).Text & "'")
                    If ExecSQLNonQuery("DELETE FROM NguonNhapXuat WHERE Sohieu='" & txtNhap(0).Text & "'") <> 0 Then GoTo XongNguon
                    GrdNT.RemoveItem(GrdNT.FocusedItem().Index)
                    GrdNT.Refresh()
                    If GrdNT.Rows <= 20 Then GrdNT.Rows = 20
                Else
                    ErrMsg(er_CoPS)
                End If
                txtNhap(0).Focus()
                ThemMoi = 1
            Case 3
                Me.Close() : Exit Sub
        End Select
XongNguon:
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Khoaquyen()
    End Sub
    ''' <summary>
    ''' Xử lý phím nóng
    ''' </summary>
    ''' <remarks></remarks>
    Public flag As Boolean = True
    Private Sub FrmNguon_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.T
                    Command(0).Focus()
                    ' Command_ClickEvent(Command(0), New EventArgs())
                    flag = False
                    Exit Sub
                Case Keys.G
                    Command(1).Focus()
                    ' Command_ClickEvent(Command(1), New EventArgs())
                    flag = False
                    Exit Sub
                Case Keys.X
                    Command(2).Focus()
                    ' Command_ClickEvent(Command(2), New EventArgs())
                    flag = False
                    Exit Sub
                Case Keys.V
                    Command(3).Focus()
                    ' Command_ClickEvent(Command(3), New EventArgs())
                    flag = False
                    Exit Sub
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    ''' <summary>
    ''' Khởi tạo cửa sổ
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FrmNguon_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            ColumnSetUp(GrdNT, 0, 820, 2)
            ColumnSetUp(GrdNT, 1, 3340, 0)
            ThemMoi = 1
            Text = String.Format("{0} - {1}", Text, ConvertToStrSafe(pNamTC))
            LietKeNguon()
            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdNT_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdNT.Click
        With GrdNT
            .Col = 0
            If .CtlText.length = 0 Then Exit Sub
            txtNhap(0).Text = .CtlText
            .Col = 1
            txtNhap(1).Text = .CtlText
            .Col = 0
            ThemMoi = 0
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdNT_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdNT.DoubleClick
        txtNhap(0).Focus()
    End Sub

    Private Sub txtNhap_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtNhap_1.Enter, _txtNhap_0.Enter
        Dim Index As Integer = Array.IndexOf(txtNhap, eventSender)
        txtNhap(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' Hiển thị danh sách nguồn nhập xuất
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LietKeNguon()
        Dim rs_nguon As DataTable = ExecSQLReturnDT("SELECT SoHieu, DienGiai FROM NguonNhapXuat ORDER BY SoHieu DESC")
        For Each rsItem As DataRow In rs_nguon.Rows
            GrdNT.AddItem(String.Format("{0}{1}{2}", _
                              rsItem("SoHieu"), _
                              Chr(9), _
                              rsItem("DienGiai")), 0)
            ' Exit For
        Next
        GrdNT.Rows = IIf(rs_nguon.Rows.Count > ConvertToDblSafe(GrdNT.Tag), rs_nguon.Rows.Count, ConvertToDblSafe(GrdNT.Tag))
        GrdNT.Row = 0
        GrdNT_ClickEvent(GrdNT, New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtNhap_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtNhap_1.Leave, _txtNhap_0.Leave
        Dim Index As Integer = Array.IndexOf(txtNhap, eventSender)
        If Strings.Len(txtNhap(Index).Text) = 0 Then txtNhap(Index).Text = "..."
    End Sub
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(1).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        Command(2).Enabled = (User_Right <> 2 Or (UserID = uid))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmNguon_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GrdNT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdNT.KeyDown
        If e.KeyData = Keys.Down Or e.KeyCode = Keys.Up Then
            With GrdNT
                .Col = 0
                If .CtlText.length = 0 Then Exit Sub
                txtNhap(0).Text = .CtlText
                .Col = 1
                txtNhap(1).Text = .CtlText
                .Col = 0
            End With
        End If
    End Sub

    Private Sub GrdNT_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdNT.KeyUp
        If e.KeyData = Keys.Down Or e.KeyCode = Keys.Up Then
            With GrdNT
                .Col = 0
                If .CtlText.length = 0 Then Exit Sub
                txtNhap(0).Text = .CtlText
                .Col = 1
                txtNhap(1).Text = .CtlText
                .Col = 0
            End With
        End If
    End Sub
    
    Private Sub GrdNT_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles GrdNT.MouseDown
        If e.Button = MouseButtons.Right Then
            SearchObj(1, , GrdNT, GrdNT.Col)
        End If
    End Sub
End Class
