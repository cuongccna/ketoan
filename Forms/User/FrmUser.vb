Imports System
Imports System.Data
Imports System.Text
Imports UNET.Utility
Imports System.Windows.Forms
Imports UNET.DataAdapter


Partial Friend Class FrmUser
    Dim ThemMoi As Integer
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Chk_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Chk_6.CheckStateChanged, _Chk_5.CheckStateChanged, _Chk_4.CheckStateChanged, _Chk_3.CheckStateChanged, _Chk_2.CheckStateChanged, _Chk_1.CheckStateChanged, _Chk_0.CheckStateChanged
        If Chk(0).CheckState = CheckState.Checked Then
            For i As Integer = 1 To 6
                Chk(i).CheckState = CheckState.Checked
            Next
        End If
        For i As Integer = 1 To 6
            Chk(i).Enabled = (Chk(0).CheckState <> CheckState.Checked)
        Next
    End Sub
    ''' <summary>
    ''' Thêm, Ghi, Xóa nguyên tệ
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_4.Click, _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim sql As New StringBuilder
        If (Index = 1 And ThemMoi = 0) Or Index = 2 Then
            GrdNT.Col = 9
            If ConvertToDblSafe(GrdNT.CtlText) = 0 Then
                MessageBox.Show("Không thay đổi quyền Admin !", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If
        Select Case Index
            Case 0
                ThemMoi = 1
                txtNhap.Text = ""
                txtNhap.Focus()
            Case 1
                If Strings.Len(txtNhap.Text) = 0 Then
                    txtNhap.Focus()
                    Exit Sub
                End If
                If CboRight.SelectedIndex = 0 Then
                    MessageBox.Show("Không sử dụng quyền Admin !", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                Select Case ThemMoi
                    Case 0
                        GrdNT.Col = 0
                        If Strings.Len(GrdNT.CtlText) = 0 Then Exit Sub
                        If ExecSQLNonQuery(String.Format("UPDATE Users SET TenNSD =N'{0}', UserRight = {1}, VT = {2} WHERE TenNSD =N'{3}'", _
                                               txtNhap.Text, _
                                               ConvertToStrSafe(CboRight.SelectedValue), _
                                               ConvertToStrSafe(MakeR()), _
                                               GrdNT.CtlText)) <> 0 Then Exit Sub
                        GrdNT.CtlText = txtNhap.Text
                        GrdNT.Col = 1
                        GrdNT.CtlText = CboRight.Text
                        For i As Integer = 2 To 8
                            GrdNT.Col = ConvertToDblSafe(i)
                            GrdNT.CtlText = IIf(Chk(i - 2).CheckState = CheckState.Checked, "X", String.Empty)
                        Next
                        GrdNT.Col = 9
                        GrdNT.CtlText = ConvertToStrSafe(CboRight.SelectedValue)
                    Case 1
                        If ExecSQLNonQuery(String.Format("INSERT INTO Users (MaSo,TenNSD, UserRight, Psw, VT) VALUES ({0}, N'{1}',{2},{3},{4})", _
                                               Lng_MaxValue("MaSo", "Users") + 1, _
                                               txtNhap.Text, _
                                               ConvertToStrSafe(CboRight.SelectedValue), _
                                               ConvertToStrSafe(pNamTC), _
                                               ConvertToStrSafe(MakeR()))) <> 0 Then Exit Sub
                        For i As Integer = 0 To 6
                            sql.Append(String.Format("{0}{1}", _
                                           Chr(9), _
                                           (IIf(Chk(i).CheckState = CheckState.Checked, "X", String.Empty))))
                        Next
                        GrdNT.AddItem(String.Format("{0}{1}{2}{3}{1}{4}", _
                                          txtNhap.Text, _
                                          Chr(9), _
                                          CboRight.Text, _
                                          sql, _
                                          ConvertToStrSafe(CboRight.SelectedValue)), InsertGridRow(GrdNT, 0, txtNhap.Text))
                        ThemMoi = 0
                        GrdNT.Row = ConvertToDblSafe(GrdNT.Rows - 1)
                        GrdNT.Col = 0
                        If Strings.Len(GrdNT.CtlText) = 0 Then GrdNT.RemoveItem(GrdNT.Row)
                        GrdNT.Row = 0
                        ThemMoi = 0
                End Select
            Case 2
                GrdNT.Col = 0
                If Strings.Len(GrdNT.CtlText) = 0 Then Exit Sub
                If ConvertToDblSafe(GetSelectValue(String.Format("SELECT ChungTu.MaSo AS F1 FROM ChungTu INNER JOIN Users ON ChungTu.User_ID=Users.MaSo WHERE TenNSD =N'{0}'", GrdNT.CtlText))) = 0 Then
                    If ExecSQLNonQuery(String.Format("DELETE FROM Users WHERE TenNSD =N'{0}'", GrdNT.CtlText)) <> 0 Then Exit Sub
                    GrdNT.RemoveItem(GrdNT.Row)
                    If GrdNT.Rows <= 8 Then GrdNT.Rows = 8
                Else
                    MessageBox.Show("Người sử dụng đã nhập chứng từ!", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Case 3
                Me.Close()
            Case 4
                With GrdNT
                    .Col = 0
                    If .CtlText.length = 0 Then Exit Sub
                    FrmUser2.Tag = ConvertToStrSafe(GetSelectValue(String.Format("SELECT MaSo AS F1 FROM Users WHERE TenNSD=N'{0}'", .CtlText)))
                    FrmUser2.ShowDialog()
                End With
        End Select
    End Sub
    ''' <summary>
    ''' Xử lý phím chức năng
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmUser_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.T
                    Command(0).Focus()
                    Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.G
                    Command(1).Focus()
                    Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.X
                    Command(2).Focus()
                    Command_ClickEvent(Command(2), New EventArgs())
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
    Private Sub FrmUser_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ColumnSetUp(GrdNT, 0, 1780, 0)
            ColumnSetUp(GrdNT, 1, 1060, 0)
            ColumnSetUp(GrdNT, 2, 460, 2)
            ColumnSetUp(GrdNT, 3, 460, 2)
            ColumnSetUp(GrdNT, 4, 460, 2)
            ColumnSetUp(GrdNT, 5, 460, 2)
            ColumnSetUp(GrdNT, 6, 460, 2)
            ColumnSetUp(GrdNT, 7, 460, 2)
            ColumnSetUp(GrdNT, 8, 420, 2)
            ColumnSetUp(GrdNT, 9, 1, 0)
            CboRight.SelectedIndex = 0
            LietKeUser()
            Command(4).Visible = (pSoKT Mod 100 >= 10)
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
            txtNhap.Text = .CtlText
            .Col = 9
            CboRight.SelectedIndex = ConvertToDblSafe((.CtlText))
            For i As Integer = 2 To 8
                .Col = ConvertToDblSafe(i)
                Chk(i - 2).CheckState = IIf(.CtlText.length > 0, CheckState.Checked, CheckState.Unchecked)
            Next
            .Col = 0
            txtNhap.Focus()
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtNhap_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtNhap.Enter
        txtNhap.SelectAll()
    End Sub
    ''' <summary>
    ''' Hiển thị danh sách nguyên tệ
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LietKeUser()
        Dim sql As New StringBuilder
        Dim k As Integer
        Dim rs_ngte As DataTable = ExecSQLReturnDT("SELECT Users.* FROM Users ORDER BY TenNSD DESC")
        For Each rsngteItem As DataRow In rs_ngte.Rows
            sql = New StringBuilder("")
            For i As Integer = 0 To 6
                k = 10 ^ i
                sql.AppendFormat("{0}{1}", Chr(9), IIf(ConvertToDblSafe(rsngteItem("vt")) Mod 10 * k >= k, "X", String.Empty))
            Next
            GrdNT.AddItem(String.Format("{1}{0}{2}{3}{0}{4}", _
                              Chr(9), _
                              rsngteItem("TenNSD"), _
                              CboRight.Items(CboRight.FindString(ConvertToStrSafe(rsngteItem("UserRight")))).ToString, _
                              sql.ToString(), _
                              ConvertToStrSafe(rsngteItem("UserRight"))), _
                              0)
        Next
        GrdNT.Rows = IIf(rs_ngte.Rows.Count > ConvertToDblSafe(GrdNT.Tag), rs_ngte.Rows.Count, ConvertToDblSafe(GrdNT.Tag))
        GrdNT.Row = 0
        GrdNT_ClickEvent(GrdNT, New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function MakeR() As Integer
        Dim r As Integer
        For i As Integer = 0 To 6
            If Chk(i).CheckState = CheckState.Checked Then r += (10 ^ i)
        Next
        Return r
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmUser_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
