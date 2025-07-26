Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmCTGS
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
                For i As Integer = 0 To 1
                    txtNhap(i).Text = "..."
                Next
                txtNhap(0).Focus()
                Khoaquyen()
            Case 1
                Select Case ThemMoi
                    Case 0
                        GrdNT.Col = 0
                        If Strings.Len(GrdNT.CtlText) = 0 Then Exit Sub
                        If ExecSQLNonQuery(String.Format("UPDATE CTGhiSo SET SoHieu=N'{0}',DienGiai=N'{1}' WHERE SoHieu=N'{2}'", _
                                               txtNhap(0).Text, _
                                               txtNhap(1).Text, _
                                               GrdNT.CtlText)) <> 0 Then Exit Sub
                        For i As Integer = 0 To 1
                            GrdNT.Col = ConvertToDblSafe(i)
                            GrdNT.CtlText = txtNhap(i).Text
                        Next
                    Case 1
                        If ExecSQLNonQuery(String.Format("INSERT INTO CTGhiSo (MaSo,SoHieu,DienGiai) VALUES ({0}, N'{1}', N'{2}')", _
                                               Lng_MaxValue("MaSo", "CTGhiSo") + 1, _
                                               txtNhap(0).Text, _
                                               txtNhap(1).Text)) <> 0 Then Exit Sub
                        GrdNT.AddItem(String.Format("{0}{1}{2}", txtNhap(0).Text, Chr(9), txtNhap(1).Text), InsertGridRow(GrdNT, 0, txtNhap(0).Text))
                        ThemMoi = 0
                        GrdNT.Row = ConvertToDblSafe(GrdNT.Rows - 1)
                        GrdNT.Col = 0
                        If Strings.Len(GrdNT.CtlText) = 0 Then GrdNT.RemoveItem(GrdNT.Row)
                        GrdNT.Row = 0
                End Select
            Case 2
                GrdNT.Col = 0
                If Strings.Len(GrdNT.CtlText) = 0 Then Exit Sub
                If ExecSQLNonQuery(String.Format("DELETE FROM CTGhiSo WHERE SoHieu=N'{0}'", GrdNT.CtlText)) <> 0 Then Exit Sub
                GrdNT.RemoveItem(GrdNT.Row)
                If GrdNT.Rows < ConvertToDblSafe(GrdNT.Tag) Then GrdNT.Rows = ConvertToDblSafe(GrdNT.Tag)
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
    Private Sub FrmCTGS_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
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
                    ' Command_ClickEvent(Command(2), New EventArgs())
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
    Private Sub FrmCTGS_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            ColumnSetUp(GrdNT, 0, 1300, 2)
            ColumnSetUp(GrdNT, 1, 2620, 0)
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
            For i As Integer = 0 To 1
                .Col = ConvertToDblSafe(i)
                txtNhap(i).Text = .CtlText
            Next
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
        Dim rs_ngte As DataTable = ExecSQLReturnDT("SELECT * FROM CTGhiSo WHERE MaSo>1 ORDER BY SoHieu DESC")
        Dim rs_ngteIndex As Integer = 0
        Do While rs_ngteIndex < rs_ngte.Rows.Count
            Dim rs_ngteItem As DataRow = rs_ngte.Rows(rs_ngteIndex)
            rs_ngteIndex += 1 ' C15 Rs LOOP CONTROL
            GrdNT.AddItem(ConvertToStrSafe(rs_ngteItem("SoHieu")) + Chr(9).ToString() + rs_ngteItem("DienGiai"), 0)
            'rs_ngte.MoveNext()
        Loop
        GrdNT.Rows = IIf(rs_ngte.Rows.Count > ConvertToDblSafe(GrdNT.Tag), rs_ngte.Rows.Count, ConvertToDblSafe(GrdNT.Tag))
        GrdNT.Row = 0
        GrdNT.Col = 0
        ''rs_ngte.Close()
        rs_ngte = Nothing
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
        Select Case Index
            Case 0, 1
                If Strings.Len(txtNhap(Index).Text) = 0 Then txtNhap(Index).Text = "..."
        End Select
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
    Private Sub FrmCTGS_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
