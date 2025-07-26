Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FU1
    Dim M_TK As Integer
    Dim M_BC As Integer
    Dim f1 As Integer
    '====================================================================================================
    ' Xử lý phím nóng
    '====================================================================================================
    Private Sub FU1_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    '====================================================================================================
    ' Khởi tạo cửa sổ
    '====================================================================================================
    Private Sub FU1_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ColumnSetUp(GrdNT, 0, 1780, 0)
            ColumnSetUp(GrdNT, 1, 1040, 2)
            ColumnSetUp(GrdNT, 2, 1, 0)
            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Public Sub QuyenBCChitiet(ByRef bc As Integer, ByRef dg As String)
        Dim st As String = String.Empty

        M_BC = bc
        Dim rs_ngte As DataTable = ExecSQLReturnDT("SELECT Users.* FROM Users WHERE UserRight>0 AND UserRight<>1 ORDER BY TenNSD DESC")
        Dim rs_ngteIndex As Integer = 0
        Do While rs_ngteIndex < rs_ngte.Rows.Count
            Dim rs_ngteItem As DataRow = rs_ngte.Rows(rs_ngteIndex)
            rs_ngteIndex += 1 ' C15 Rs LOOP CONTROL
            If Not TruongDaCo("Users", "C" & bc) Then
                st = ""
            Else
                st = IIf(ConvertToDblSafe(GetSelectValue("SELECT C" & bc & " AS F1 FROM Users WHERE MaSo=" & rs_ngteItem("MaSo"))) > 0, "x", String.Empty)
            End If
            GrdNT.AddItem(ConvertToStrSafe(rs_ngteItem("TenNSD")) + Chr(9).ToString() + st + Chr(9).ToString() + rs_ngteItem("MaSo"), 0)
            'rs_ngte.MoveNext()
        Loop
        GrdNT.Rows = IIf(rs_ngte.Rows.Count > ConvertToDblSafe(GrdNT.Tag), rs_ngte.Rows.Count, ConvertToDblSafe(GrdNT.Tag))
        GrdNT.Row = 0
        ''rs_ngte.Close()
        rs_ngte = Nothing
        Me.Text = dg
        f1 = 2
        Me.ShowDialog()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="bc"></param>
    ''' <param name="dg"></param>
    ''' <remarks></remarks>
    Public Sub QuyenBCTongHop(ByRef bc As Integer, ByRef dg As String)
        Dim st As String = String.Empty
        M_BC = bc
        Dim rs_ngte As DataTable = ExecSQLReturnDT("SELECT Users.* FROM Users WHERE UserRight>0 AND UserRight<>1 ORDER BY TenNSD DESC")
        Dim rs_ngteIndex As Integer = 0
        Do While rs_ngteIndex < rs_ngte.Rows.Count
            Dim rs_ngteItem As DataRow = rs_ngte.Rows(rs_ngteIndex)
            rs_ngteIndex += 1 ' C15 Rs LOOP CONTROL
            If Not TruongDaCo("Users", "T" & bc) Then
                st = ""
            Else
                st = IIf(ConvertToDblSafe(GetSelectValue("SELECT T" & bc & " AS F1 FROM Users WHERE MaSo=" & rs_ngteItem("MaSo"))) > 0, "x", String.Empty)
            End If
            GrdNT.AddItem(ConvertToStrSafe(rs_ngteItem("TenNSD")) + Chr(9).ToString() + st + Chr(9).ToString() + rs_ngteItem("MaSo"), 0)
            'rs_ngte.MoveNext()
        Loop
        GrdNT.Rows = IIf(rs_ngte.Rows.Count > ConvertToDblSafe(GrdNT.Tag), rs_ngte.Rows.Count, ConvertToDblSafe(GrdNT.Tag))
        GrdNT.Row = 0
        ''rs_ngte.Close()
        rs_ngte = Nothing
        Me.Text = dg
        f1 = 3
        Me.ShowDialog()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdNT_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdNT.DoubleClick
        Dim m As Integer
        With GrdNT
            .Col = 2
            m = ConvertToDblSafe(.CtlText)
            If m = 0 Then Exit Sub
            .Col = 1
            Select Case f1
                Case 1
                    If .CtlText = "" Then
                        .CtlText = "x"
                        If Not TruongDaCo("HethongTK", "U" & m) Then ThemTruong("HethongTK", "U" & m, DbType.Int32)
                        ExecSQLNonQuery("UPDATE HethongTK SET U" & m & "=1 WHERE MaSo=" & ConvertToStrSafe(M_TK))
                    Else
                        .CtlText = ""
                        ExecSQLNonQuery("UPDATE HethongTK SET U" & m & "=0 WHERE MaSo=" & ConvertToStrSafe(m))
                    End If
                Case 2
                    If .CtlText.length = 0 Then
                        .CtlText = "x"
                        If Not TruongDaCo("Users", "C" & M_BC) Then ThemTruong("Users", "C" & M_BC, DbType.Int32)
                        ExecSQLNonQuery("UPDATE Users SET C" & M_BC & "=1 WHERE MaSo=" & ConvertToStrSafe(m))
                    Else
                        .CtlText = ""
                        ExecSQLNonQuery("UPDATE Users SET C" & M_BC & "=0 WHERE MaSo=" & ConvertToStrSafe(m))
                    End If
                Case 3
                    If .CtlText.length = 0 Then
                        .CtlText = "x"
                        If Not TruongDaCo("Users", "T" & M_BC) Then ThemTruong("Users", "T" & M_BC, DbType.Int32)
                        ExecSQLNonQuery("UPDATE Users SET T" & M_BC & "=1 WHERE MaSo=" & ConvertToStrSafe(m))
                    Else
                        .CtlText = ""
                        ExecSQLNonQuery("UPDATE Users SET T" & M_BC & "=0 WHERE MaSo=" & ConvertToStrSafe(m))
                    End If
            End Select
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mtk"></param>
    ''' <remarks></remarks>
    Public Sub QuyenTaiKhoan(ByRef mtk As Integer)
        Dim st As String = String.Empty
        M_TK = mtk
        Dim rs_ngte As DataTable = ExecSQLReturnDT("SELECT Users.* FROM Users WHERE UserRight>0 AND UserRight<>2 ORDER BY TenNSD DESC")
        Dim rs_ngteIndex As Integer = 0
        Do While rs_ngteIndex < rs_ngte.Rows.Count
            Dim rs_ngteItem As DataRow = rs_ngte.Rows(rs_ngteIndex)
            rs_ngteIndex += 1 ' C15 Rs LOOP CONTROL
            If Not TruongDaCo("HethongTK", "U" & rs_ngteItem("MaSo")) Then
                st = ""
            Else
                st = IIf(ConvertToDblSafe(GetSelectValue("SELECT U" & ConvertToStrSafe(rs_ngteItem("MaSo")) & " AS F1 FROM HethongTK WHERE MaSo=" & ConvertToStrSafe(mtk))) > 0, "x", String.Empty)
            End If
            GrdNT.AddItem(ConvertToStrSafe(rs_ngteItem("TenNSD")) + Chr(9).ToString() + st + Chr(9).ToString() + rs_ngteItem("MaSo"), 0)
            'rs_ngte.MoveNext()
        Loop
        GrdNT.Rows = IIf(rs_ngte.Rows.Count > ConvertToDblSafe(GrdNT.Tag), rs_ngte.Rows.Count, ConvertToDblSafe(GrdNT.Tag))
        GrdNT.Row = 0
        ''rs_ngte.Close()
        rs_ngte = Nothing
        Me.Text = "TK: " & MaSo2SoHieu(mtk, "HethongTK")
        f1 = 1
        Me.ShowDialog()
    End Sub
    Private Sub FU1_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
