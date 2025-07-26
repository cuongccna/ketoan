Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmDU

    Dim ThemMoi As Integer
    ''' <summary>
    ''' Thêm, Ghi, Xóa nguyên tệ
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Select Case Index
            Case 0
                ThemMoi = 1
                txtNhap(0).Text = ""
                txtNhap(1).Text = ""
                Label(3).Text = ""
                txtNhap(0).Focus()
                Khoaquyen()
            Case 1
                If Strings.Len(txtNhap(0).Text) = 0 Then
                    txtNhap(0).Focus()
                    Exit Sub
                End If
                If ConvertToDblSafe((txtNhap(1).Tag)) = 0 Then
                    txtNhap(1).Focus()
                    Exit Sub
                End If
                Select Case ThemMoi
                    Case 0
                        GrdNT.Col = 0
                        If Strings.Len(GrdNT.CtlText) = 0 Then Exit Sub
                        If ExecSQLNonQuery("UPDATE SHChungTu SET SoHieu='" & txtNhap(0).Text & "',SHTK='" & txtNhap(1).Text & " WHERE SoHieu='" & GrdNT.CtlText & "'") <> 0 Then Exit Sub
                        GrdNT.CtlText = txtNhap(0).Text
                        GrdNT.Col = 1
                        GrdNT.CtlText = txtNhap(1).Text
                        GrdNT.Col = 2
                        GrdNT.CtlText = Label(3).Text
                    Case 1
                        If ExecSQLNonQuery("INSERT INTO SHChungTu (MaSo,SoHieu,SHTK) VALUES (" & Lng_MaxValue("MaSo", "SHChungTu") + 1 & ",'" & txtNhap(0).Text & "','" & txtNhap(1).Text & "')") <> 0 Then Exit Sub
                        GrdNT.AddItem(txtNhap(0).Text & Chr(9).ToString() & txtNhap(1).Text & Chr(9).ToString() & Label(3).Text, InsertGridRow(GrdNT, 0, txtNhap(0).Text))
                        ThemMoi = 0
                        GrdNT.Row = ConvertToDblSafe(GrdNT.Rows - 1)
                        GrdNT.Col = 0
                        If Strings.Len(GrdNT.CtlText) = 0 Then GrdNT.RemoveItem(GrdNT.Row)
                        GrdNT.Row = 0
                End Select
            Case 2
                If ExecSQLNonQuery("DELETE FROM SHChungTu WHERE Sohieu='" & GrdNT.CtlText & "'") <> 0 Then Exit Sub
                GrdNT.RemoveItem(GrdNT.Row)
                If GrdNT.Rows <= ConvertToDblSafe(GrdNT.Tag) Then GrdNT.Rows = ConvertToDblSafe(GrdNT.Tag)
            Case 3
                Me.Close()
        End Select
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Khoaquyen()
    End Sub
    '====================================================================================================
    ' Xử lý phím nóng
    '====================================================================================================
    Private Sub FrmDU_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.T
                    Command(0).Focus()
                    'Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.G
                    Command(1).Focus()
                    'Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.X
                    Command(2).Focus()
                    'Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.V
                    Command(3).Focus()
                    'Command_ClickEvent(Command(3), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    '====================================================================================================
    ' Khởi tạo cửa sổ
    '====================================================================================================
    Private Sub FrmDU_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            ColumnSetUp(GrdNT, 0, 580, 2)
            ColumnSetUp(GrdNT, 1, 1300, 0)
            ColumnSetUp(GrdNT, 2, 2740, 0)
            txtNhap(0).MaxLength = SHCT_Len
            Text = SetFormTitle(Text)
            LietKeNgte()
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
        SendKeys.SendWait("{Home}")
        SetGridIndex(GrdNT, GrdNT.Row)
        With GrdNT
            .Col = 0
            If .CtlText.length = 0 Then Exit Sub
            txtNhap(0).Text = .CtlText
            .Col = 1
            txtNhap(1).Text = .CtlText
            .Col = 2
            Label(3).Text = .CtlText
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
    Private Sub GrdNT_KeyPressEvent(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles GrdNT.KeyPress
        SendKeys.SendWait("{Home}")
        SetGridIndex(GrdNT, GrdNT.Row)
        If eventArgs.KeyChar = Chr(Keys.Enter) Then GrdNT_ClickEvent(GrdNT, New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdNT_MouseDownEvent(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles GrdNT.MouseDown
        If eventArgs.Button = MouseButtons.Right Then
            SearchObj(1, , GrdNT, GrdNT.Col)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtNhap_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtNhap_1.Enter, _txtNhap_0.Enter
        Dim Index As Integer = Array.IndexOf(txtNhap, eventSender)
        txtNhap(Index).SelectAll()
    End Sub
    '====================================================================================================
    ' Hiển thị danh sách nguyên tệ
    '====================================================================================================
    Private Sub LietKeNgte()
        Dim rs_ngte As DataTable = ExecSQLReturnDT("SELECT SHChungTu.SoHieu,SHTK,Ten FROM SHChungTu INNER JOIN HethongTK ON SHChungTu.SHTK=HethongTK.SoHieu ORDER BY SHChungTu.SoHieu DESC")
        For Each rsngteItem As DataRow In rs_ngte.Rows
            GrdNT.AddItem(String.Format("{0}{1}{2}{1}{3}", _
                              rsngteItem("SoHieu"), _
                              Chr(9), _
                              rsngteItem("shtk"), _
                              rsngteItem("ten")), 0)
        Next
        GrdNT.Rows = IIf(rs_ngte.Rows.Count > ConvertToDblSafe(GrdNT.Tag), rs_ngte.Rows.Count, ConvertToDblSafe(GrdNT.Tag))
        GrdNT.Row = 0
        GrdNT.Col = 0
        GrdNT_ClickEvent(GrdNT, New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtNhap_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtNhap_1.KeyPress, _txtNhap_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtNhap, eventSender)
        If Index = 1 Then KeyProcess(txtNhap(Index), KeyAscii)
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
    Private Sub txtNhap_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtNhap_1.Leave, _txtNhap_0.Leave
        Dim Index As Integer = Array.IndexOf(txtNhap, eventSender)
        Dim mtk As Integer
        If Index = 1 Then
            Label(3).Text = tentk(txtNhap(1).Text, mtk)
            txtNhap(1).Tag = ConvertToStrSafe(mtk)
        End If
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
    Private Sub FrmDU_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
