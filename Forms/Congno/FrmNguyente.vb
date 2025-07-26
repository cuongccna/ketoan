Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmNguyente
    Dim ThemMoi As Integer
    Dim SoNT As Integer

    ''' <summary>
    ''' Khởi tạo cửa sổ
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmNguyente_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            ColumnSetUp(GrdNT, 0, 940, 2)
            ColumnSetUp(GrdNT, 1, 1300, 1)
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
    ''' Thêm, Ghi, Xóa nguyên tệ
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_0.Click, _Command_1.Click, _Command_2.Click, _Command_3.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim tygia As Double = RoundMoney(ConvertToDblSafe(txtNhap(1).Text))
        Dim sql As String = String.Empty
        Select Case Index
            Case 0
                ThemMoi = 1
                txtNhap(0).Text = ""
                txtNhap(0).Focus()
                Khoaquyen()
            Case 1
                If Strings.Len(txtNhap(0).Text) = 0 Then
                    txtNhap(0).Focus()
                    Exit Sub
                End If
                Select Case ThemMoi
                    Case 0
                        GrdNT.Col = 0
                        If Strings.Len(GrdNT.CtlText) = 0 Then Exit Sub
                        If ExecSQLNonQuery(String.Format("UPDATE Nguyente SET Kyhieu='{0}',TyGia={1} WHERE KyHieu='{2}'", _
                                               txtNhap(0).Text, _
                                              tygia, _
                                               GrdNT.CtlText)) <> 0 Then Exit Sub
                        GrdNT.CtlText = txtNhap(0).Text
                        GrdNT.Col = 1
                        GrdNT.CtlText = txtNhap(1).Text
                    Case 1
                        If ExecSQLNonQuery(String.Format("INSERT INTO Nguyente (MaSo,KyHieu,TyGia) VALUES ({0},'{1}',{2})", _
                                               Lng_MaxValue("MaSo", "NguyenTe") + 1, _
                                               txtNhap(0).Text, _
                                               tygia)) <> 0 Then Exit Sub
                        GrdNT.AddItem(String.Format("{0}{1}{2}", _
                                          txtNhap(0).Text, _
                                          Chr(9), _
                                          txtNhap(1).Text), InsertGridRow(GrdNT, 0, txtNhap(0).Text))
                        ThemMoi = 0
                        SoNT += 1
                        Command(0).Enabled = SoNT < 12
                        GrdNT.Row = ConvertToDblSafe(GrdNT.Rows - 1)
                        GrdNT.Col = 0
                        If Strings.Len(GrdNT.CtlText) = 0 Then GrdNT.RemoveItem(GrdNT.Row)
                        GrdNT.Row = 0
                End Select
            Case 2
                GrdNT.Col = 0
                If Strings.Len(GrdNT.CtlText) = 0 Then Exit Sub
                sql = String.Format("SELECT DISTINCT Count(HethongTK.MaNT) AS F1 FROM HethongTK INNER JOIN NguyenTe ON HethongTK.MaNT = NguyenTe.MaSo WHERE NguyenTe.KyHieu = '{0}'", GrdNT.CtlText)
                If ConvertToDblSafe(GetSelectValue(sql)) = 0 Then
                    If ExecSQLNonQuery(String.Format("DELETE FROM Nguyente WHERE Kyhieu='{0}'", GrdNT.CtlText)) <> 0 Then Exit Sub
                    GrdNT.RemoveItem(GrdNT.Row)
                    If GrdNT.Rows <= ConvertToDblSafe(GrdNT.Tag) Then GrdNT.Rows = ConvertToDblSafe(GrdNT.Tag)
                    SoNT -= 1
                    Command(0).Enabled = SoNT < 12
                Else
                    ErrMsg(er_CoPS)
                End If
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
    ''' <summary>
    ''' Xử lý phím nóng
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmNguyente_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.T
                    Command(0).Focus()
                    ' Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.G
                    Command(1).Focus()
                    ' Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.X
                    Command(2).Focus()
                    'Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.V
                    Command(3).Focus()
                    ' Command_ClickEvent(Command(3), New EventArgs())
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
    Private Sub FrmNguyente_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        CloseItemList()
        MemoryHelper.ReleaseMemory()
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
    ''' <summary>
    ''' Hiển thị danh sách nguyên tệ
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LietKeNgte()
        Dim rs_ngte As DataTable = ExecSQLReturnDT(String.Format("SELECT Kyhieu, TyGia FROM Nguyente WHERE KyHieu<>'{0}' ORDER BY Kyhieu DESC", pTienStr))
        Dim rs_ngteIndex As Integer = 0
        Do While rs_ngteIndex < rs_ngte.Rows.Count
            Dim rs_ngteItem As DataRow = rs_ngte.Rows(rs_ngteIndex)
            rs_ngteIndex += 1 ' C15 Rs LOOP CONTROL
            GrdNT.AddItem(String.Format("{0}{1}{2}", _
                              rs_ngteItem("KyHieu"), _
                              Chr(9), _
                              Format(ConvertToDblSafe(rs_ngteItem("tygia")), Mask_0)), 0)
            'rs_ngte.MoveNext()
        Loop
        SoNT = rs_ngte.Rows.Count
        Command(0).Enabled = SoNT < 12
        GrdNT.Rows = IIf(SoNT > ConvertToDblSafe(GrdNT.Tag), ConvertToDblSafe(SoNT), ConvertToDblSafe(GrdNT.Tag))
        GrdNT.Row = 0
        GrdNT.Col = 0
        ''rs_ngte.Close()
        rs_ngte = Nothing
        'GrdNT_ClickEvent(GrdNT, New EventArgs())
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
        Select Case Index
            Case 0
                If KeyAscii = 32 Or KeyAscii = 35 Or KeyAscii = 39 Or KeyAscii = 42 Then KeyAscii = 0
            Case 1
                KeyProcess(txtNhap(Index), KeyAscii)
        End Select
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
        If Index = 1 Then
            txtNhap(1).Text = Format(txtNhap(1).Text, Mask_0)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="uid"></param>
    ''' <remarks></remarks>
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(1).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        Command(2).Enabled = (User_Right <> 2 Or (UserID = uid))
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GrdNT_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdNT.DoubleClick
        txtNhap(1).Focus()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="source"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GrdNT_SelectedIndexChanged(ByVal source As Object, ByVal e As ListViewEx.ClickEventArgs) Handles GrdNT.SelectedIndexChanged
        ' SetGridIndex(GrdNT, GrdNT.Row)
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
End Class
