Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmUser2
    Dim ms As Integer
    ''' <summary>
    ''' Thêm, Ghi, Xóa nguyên tệ
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_3.Click, _Command_1.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Select Case Index
            Case 1
                If GrdNT.Rows > 0 Then
                    ExecSQLNonQuery(String.Format("DELETE FROM User2 WHERE User={0}", ms))
                    With GrdNT
                        For i As Integer = 0 To .Rows - 1
                            .Row = i
                            .Col = 0
                            If .CtlText.length = 0 Then Exit Sub
                            .Col = 1
                            If .CtlText = "X" Then
                                .Col = 2
                                ExecSQLNonQuery(String.Format("INSERT INTO User2 (MaSo,User,CTGS) VALUES ({0},{1},{2})", _
                                                    Lng_MaxValue("MaSo", "User2") + 1, _
                                                    ConvertToStrSafe(ms), _
                                                    .CtlText))
                            End If
                        Next
                    End With
                End If
            Case 3
                Me.Close()
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FrmUser2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' Xử lý phím nóng
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmUser2_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.G
                    Command(1).Focus()
                    Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.V
                    Command(3).Focus()
                    Command_ClickEvent(Command(3), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    ''' <summary>
    ''' Khởi tạo cửa sổ
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmUser2_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            If ConvertToDblSafe(Me.Tag) > 0 Then
                ms = ConvertToDblSafe(Me.Tag)
                LietKeNgte()
                Me.Tag = "0"
            End If

            ColumnSetUp(GrdNT, 0, 2860, 0)
            ColumnSetUp(GrdNT, 1, 1050, 2)
            ColumnSetUp(GrdNT, 2, 500, 0)
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
    Private Sub GrdNT_KeyPressEvent(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles GrdNT.KeyPress
        If eventArgs.KeyChar = Chr(Keys.Enter) Then GrdNT_SelectedIndexChanged(GrdNT, Nothing)
    End Sub
    ''' <summary>
    ''' Hiển thị danh sách nguyên tệ
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LietKeNgte()
        Dim s As String = String.Empty
        Dim MienTru As String = String.Format("SELECT * FROM User2 WHERE [User]={0}", ms)
        Dim rs_ngte As DataTable = ExecSQLReturnDT(String.Format("SELECT SoHieu + ' - ' + DienGiai AS CTGS, CTGhiSo.MaSo, MienTru.[User] FROM CTGhiSo LEFT JOIN ({0}) AS MienTru ON CTGhiSo.MaSo=MienTru.CTGS WHERE CTGhiSo.MaSo>1 ORDER BY SoHieu DESC", MienTru))
        Dim rs_ngteIndex As Integer = 0
        Do While rs_ngteIndex < rs_ngte.Rows.Count
            Dim rs_ngteItem As DataRow = rs_ngte.Rows(rs_ngteIndex)
            rs_ngteIndex += 1 ' C15 Rs LOOP CONTROL
            s = IIf(IsDBNull(rs_ngte("USER")), "", "X")
            GrdNT.AddItem(String.Format("{0}{1}{2}{1}{3}", _
                              ConvertToStrSafe(rs_ngteItem("CTGS")), _
                              Chr(9), _
                              s, _
                              rs_ngteItem("MaSo")), 0)
        Loop
        _Command_1.Enabled = GrdNT.Rows > 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmUser2_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="source"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GrdNT_SelectedIndexChanged(ByVal source As Object, ByVal e As ListViewEx.ClickEventArgs) Handles GrdNT.SelectedIndexChanged
        _Command_1.Enabled = GrdNT.Rows > 0
        With GrdNT
            .Col = 1
            .CtlText = IIf(.CtlText.length = 0, "X", String.Empty)
        End With
    End Sub
End Class
