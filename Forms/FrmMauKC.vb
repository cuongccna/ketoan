Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmMauKC
    Dim act As Integer

    Private Sub CmdChitiet_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CmdChitiet.Click
        For i As Integer = 0 To 1
            If Strings.Len(LbTK(i).Text) = 0 Then
                txtNhap(i).Focus()
                Exit Sub
            Else
                If ConvertToDblSafe((txtNhap(i).Tag)) > 0 And ConvertToDblSafe(Strings.Left(txtNhap(i).Text, ConvertToStrSafe(TK(i).Tag).Length)) = ConvertToDblSafe((TK(i).Tag)) Then
                    MessageBox.Show(Ngonngu("Hãy nhập chi tiết tài khoản ", "Enter detail account") & TK(i).Text, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtNhap(i).Focus()
                    Exit Sub
                End If
            End If
        Next
        If ExecSQLNonQuery("INSERT INTO KCChitiet (MaSo,MaKC,TK1,TK2) VALUES (" & Lng_MaxValue("MaSo", "KCChitiet") + 1 & "," & ConvertToStrSafe(Me.Tag) & "," & ConvertToStrSafe(LbTK(0).Tag) & "," & ConvertToStrSafe(LbTK(1).Tag) & ")") = 0 Then
            GrdNT(0).AddItem(txtNhap(0).Text & Chr(9).ToString() & LbTK(0).Text & Chr(9).ToString() & ConvertToStrSafe(LbTK(0).Tag) & Chr(9).ToString() & ConvertToStrSafe(Lng_MaxValue("MaSo", "KCChitiet")), NewRowIndex(GrdNT(0), 0))
            GrdNT(1).AddItem(txtNhap(1).Text & Chr(9).ToString() & LbTK(1).Text & Chr(9).ToString() & ConvertToStrSafe(LbTK(1).Tag), NewRowIndex(GrdNT(1), 0))
            GrdNT(0).Row = ConvertToDblSafe(GrdNT(0).Rows - 1)
            If Strings.Len(GrdNT(0).CtlText) = 0 Then
                GrdNT(0).RemoveItem(ConvertToDblSafe(GrdNT(0).Rows - 1))
                GrdNT(1).RemoveItem(ConvertToDblSafe(GrdNT(1).Rows - 1))
            End If
        End If
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Dim rs As DataTable
        Dim s, T As String
        If act = 0 Then
            rs = ExecSQLReturnDT("SELECT TK1 AS M1, HeThongTK.SoHieu AS S1, HeThongTK.Ten AS T1, TK2 AS M2, HeThongTK_1.SoHieu AS S2, HeThongTK_1.Ten AS T2, KCChitiet.MaSo " & "FROM (KCChitiet LEFT JOIN HeThongTK ON KCChitiet.TK1 = HeThongTK.MaSo) LEFT JOIN HeThongTK AS HeThongTK_1 ON KCChitiet.TK2 = HeThongTK_1.MaSo " & "WHERE KCChitiet.MaKC=" & ConvertToStrSafe(Me.Tag))
            Dim rsIndex As Integer = 0
            Do While rsIndex < rs.Rows.Count
                Dim rsItem As DataRow = rs.Rows(rsIndex)
                rsIndex += 1 ' C15 Rs LOOP CONTROL
                s = IIf(Not IsDBNull(rsItem("s1")), rsItem("s1"), "...")
                T = IIf(Not IsDBNull(rsItem("T1")), rsItem("T1"), "...")
                GrdNT(0).AddItem(s & Chr(9).ToString() & T & Chr(9).ToString() & rsItem("m1") & Chr(9).ToString() & rsItem("MaSo"), 0)
                s = IIf(Not IsDBNull(rsItem("s2")), rsItem("s2"), "...")
                T = IIf(Not IsDBNull(rsItem("t2")), rsItem("t2"), "...")
                GrdNT(1).AddItem(s & Chr(9).ToString() & T & Chr(9).ToString() & rsItem("m2"), 0)
                ''rs.MoveNext()
            Loop
            ''rs.Close()
            rs = Nothing
            act = 1
        End If
        'Dim rs As DataTable
        'Dim s, T, s1, T1, s2, T2 As String
        'If act = 0 Then
        '    Dim tam As String = String.Format("SELECT TK1 AS M1, HeThongTK.SoHieu AS S1, HeThongTK.Ten AS T1, TK2 AS M2, HeThongTK_1.SoHieu AS S2, HeThongTK_1.Ten AS T2, KCChitiet.MaSo " & "FROM (KCChitiet LEFT JOIN HeThongTK ON KCChitiet.TK1 = HeThongTK.MaSo) LEFT JOIN HeThongTK AS HeThongTK_1 ON KCChitiet.TK2 = HeThongTK_1.MaSo " & "WHERE KCChitiet.MaKC=" & ConvertToStrSafe(Me.Tag))
        '    rs = ExecSQLReturnDT(tam)
        '    Dim rsIndex As Integer = 0
        '    Do While rsIndex < rs.Rows.Count
        '        Dim rsItem As DataRow = rs.Rows(rsIndex)
        '        rsIndex += 1 ' C15 Rs LOOP CONTROL
        '        s1 = IIf(Not IsDBNull(rsItem("s1")), rsItem("s1"), "...")
        '        T1 = IIf(Not IsDBNull(rsItem("T1")), rsItem("T1"), "...")
        '        'GrdNT(0).AddItem(s & Chr(9).ToString() & T & Chr(9).ToString() & rsItem("m1") & Chr(9).ToString() & rsItem("MaSo"), 0)
        '        Dim gan1 As String = String.Format("{0}{1}{2}", s1, Chr(9), T1, 0)
        '        GrdNT(0).AddItem(gan1)
        '        s2 = IIf(Not IsDBNull(rsItem("s2")), rsItem("s2"), "...")
        '        T2 = IIf(Not IsDBNull(rsItem("t2")), rsItem("t2"), "...")
        '        Dim gan2 As String = String.Format("{0}{1}{2}", s2, Chr(9), T2, 0)
        '        GrdNT(1).AddItem(gan2)

        '    Loop

        'End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmMauKC_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles MyBase.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        If KeyAscii = ConvertToDblSafe(Keys.Escape) Then Me.Close()
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
    Private Sub FrmMauKC_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 


            ColumnSetUp(GrdNT(0), 0, 1300, 0)
            ColumnSetUp(GrdNT(1), 0, 1300, 0)
            ColumnSetUp(GrdNT(0), 1, 2570, 0)
            ColumnSetUp(GrdNT(1), 1, 2580, 0)
            ColumnSetUp(GrdNT(0), 2, 1, 0)
            ColumnSetUp(GrdNT(1), 2, 1, 0)
            ColumnSetUp(GrdNT(0), 3, 1, 0)
            Call FormInit()
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
    Private Sub FrmMauKC_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        act = 0
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdNT_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _GrdNT_1.DoubleClick, _GrdNT_0.DoubleClick
        If Strings.Len(GrdNT(0).CtlText) > 0 Then
            GrdNT(0).Col = 3
            If ExecSQLNonQuery("DELETE FROM KCChitiet WHERE MaSo=" & GrdNT(0).CtlText) = 0 Then
                GrdNT(1).RemoveItem(GrdNT(0).Row)
                GrdNT(0).RemoveItem(GrdNT(0).Row)
                If GrdNT(0).Rows < ConvertToDblSafe((GrdNT(0).Tag)) Then
                    GrdNT(0).Rows = ConvertToDblSafe(ConvertToDblSafe((GrdNT(0).Tag)))
                    GrdNT(1).Rows = ConvertToDblSafe(ConvertToDblSafe((GrdNT(1).Tag)))
                End If
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdNT_MouseDownEvent(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles _GrdNT_1.MouseDown, _GrdNT_0.MouseDown
        Dim Index As Integer = Array.IndexOf(GrdNT, eventSender)
        If eventArgs.Button = MouseButtons.Right Then
            SearchObj(1, , GrdNT(Index), GrdNT(Index).Col)
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
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtNhap_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtNhap_1.KeyPress, _txtNhap_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtNhap, eventSender)
        If KeyAscii = ConvertToDblSafe(Keys.Return) Then
            Me.Cursor = Cursors.WaitCursor
            txtNhap(Index).Text = FrmTaikhoan.ChonTk(txtNhap(Index).Text)
            Me.Cursor = Cursors.Default
            txtNhap_Leave(txtNhap(Index), New EventArgs())
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
    Private Sub txtNhap_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtNhap_1.Leave, _txtNhap_0.Leave
        Dim Index As Integer = Array.IndexOf(txtNhap, eventSender)
        Dim mtk As Integer
        LbTK(Index).Text = tentk(txtNhap(Index).Text, mtk, ConvertToDblSafe(txtNhap(Index).Tag))
        LbTK(Index).Tag = ConvertToStrSafe(mtk)
    End Sub
End Class
