Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmTaikhoantudong
    Public loai1, loai, loaino As Integer

    Private Sub CmdChitiet_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CmdChitiet.Click
        For i As Integer = 0 To 1
            If Strings.Len(LbTK(i).Text) = 0 Then
                txtNhap(i).Focus()
                Exit Sub
            Else
                If ConvertToDblSafe((txtNhap(i).Tag)) > 0 Then
                    MessageBox.Show(Ngonngu("Hãy nhập chi tiết tài khoản ", "Enter account details ") & txtNhap(i).Text, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtNhap(i).Focus()
                    Exit Sub
                End If
            End If
        Next
        If ConvertToDblSafe(GetSelectValue("SELECT count(*) as f1 FROM taikhoantudong WHERE tk1=" & ConvertToStrSafe(LbTK(0).Tag) & " and tk2=" & ConvertToStrSafe(LbTK(1).Tag) & " and loai=" & ConvertToStrSafe(loai) & " and loai1=" & ConvertToStrSafe(loai1) & " and loaino=" & ConvertToStrSafe(loaino))) > 0 Then
            MessageBox.Show(Ngonngu("Thông tin đã có. Vui lòng kiểm tra lại!", "Existing information, please check again!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNhap(0).Focus()
        Else
            If ExecSQLNonQuery("INSERT INTO Taikhoantudong (MaSo,TK1,TK2,loai,loai1,loaino) VALUES (" & Lng_MaxValue("MaSo", "taikhoantudong") + 1 & "," & ConvertToStrSafe(LbTK(0).Tag) & "," & ConvertToStrSafe(LbTK(1).Tag) & "," & ConvertToStrSafe(loai) & "," & ConvertToStrSafe(loai1) & "," & ConvertToStrSafe(loaino) & ")") = 0 Then
                GrdNT.AddItem(txtNhap(0).Text & Chr(9).ToString() & LbTK(0).Text & Chr(9).ToString() & txtNhap(1).Text & Chr(9).ToString() & LbTK(1).Text & Chr(9).ToString() & ConvertToStrSafe(Lng_MaxValue("MaSo", "taikhoantudong")), 0) ' NewRowIndex(GrdNT, 0)
                Xoadongtrongcuoi(GrdNT)
            End If
        End If
        '    For i = 0 To 1
        '        txtNhap(i).Text = ""
        '        txtNhap_LostFocus i
        '    Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmTaikhoantudong_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles MyBase.KeyPress
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
    Private Sub FrmTaikhoantudong_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ColumnSetUp(GrdNT, 0, 1300, 0)
            ColumnSetUp(GrdNT, 1, 2630, 0)
            ColumnSetUp(GrdNT, 2, 1300, 0)
            ColumnSetUp(GrdNT, 3, 2580, 0)
            ColumnSetUp(GrdNT, 4, 1, 0)
            Thongtin()
            SetFont(Me)
            Hienthi()

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    Sub Thongtin()
        Tk1.Text = "Tài khoản nợ"
        Tk2.Text = "Tài khoản có"
        Select Case loai
            Case 0
                If loai1 = 0 Then
                    Tieude.Text = "Đăng ký tài khoản chi phí"
                ElseIf loaino = 0 Then
                    Tieude.Text = "Đăng ký tài khoản thu nợ"
                    Tk1.Text = "Tài khoản có"
                    Tk2.Text = "Tài khoản nợ"
                Else
                    Tieude.Text = "Đăng ký tài khoản trả nợ"
                End If
            Case 1
                Tieude.Text = "Đăng ký tài khoản nhập hàng"
            Case 2
                Tieude.Text = "Đăng ký tài khoản xuất hàng"
                Tk1.Text = "Tài khoản có"
                Tk2.Text = "Tài khoản nợ"
            Case 8
                Tieude.Text = "Đăng ký tài khoản bán hàng"
                Tk1.Text = "Tài khoản có"
                Tk2.Text = "Tài khoản nợ"
        End Select
    End Sub
    Sub Hienthi()
        Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT tk1,tk1.sohieu as sh1,tk1.ten as ten1,tk2,tk2.sohieu as sh2,tk2.ten as ten2,tktd.maso FROM (taikhoantudong tktd inner join hethongtk tk1 on tktd.tk1=tk1.maso) inner join hethongtk tk2 on tktd.tk2=tk2.maso WHERE tktd.loai={0} and loai1={1} and loaino={2} order by tk1.sohieu desc, tk2.sohieu desc", _
                                                  loai, _
                                                  ConvertToStrSafe(loai1), _
                                                  ConvertToStrSafe(loaino)))
        If rs.Rows.Count > 18 Then
            GrdNT.Rows = rs.Rows.Count
        Else
            GrdNT.Rows = 18
        End If
        For Each rsItem As DataRow In rs.Rows
            GrdNT.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}", _
                              rsItem("sh1"), _
                              Chr(9), _
                              rsItem("ten1"), _
                              rsItem("sh2"), _
                              rsItem("ten2"), _
                              rsItem("MaSo")), 0)
            Xoadongtrongcuoi(GrdNT)
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdNT_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdNT.Click
        SetGridIndex(GrdNT, GrdNT.Row)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdNT_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdNT.DoubleClick
        GrdNT.Col = 0
        txtNhap(0).Text = GrdNT.CtlText
        txtNhap_Leave(txtNhap(0), New EventArgs())
        GrdNT.Col = 2
        txtNhap(1).Text = GrdNT.CtlText
        txtNhap_Leave(txtNhap(1), New EventArgs())
        GrdNT.Col = 4
        If GrdNT.CtlText <> "" Then
            ExecSQLNonQuery("DELETE FROM taikhoantudong WHERE maso=" & GrdNT.CtlText)
            If GrdNT.Rows = 18 Then GrdNT.AddItem("", 18)
            GrdNT.RemoveItem(GrdNT.Row)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdNT_KeyUpEvent(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles GrdNT.KeyUp
        Chondongxanh(GrdNT, eventArgs.KeyCode)
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
            If Index = 1 Then
                If Strings.Left(txtNhap(1).Text, 3) = Strings.Left(txtNhap(0).Text, 3) Then txtNhap(1).Text = ""
            End If
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
        If Strings.Left(txtNhap(1).Text, 3) = Strings.Left(txtNhap(0).Text, 3) Then txtNhap(1).Text = ""
        LbTK(Index).Text = tentk(txtNhap(Index).Text, mtk)
        txtNhap(Index).Tag = Timten("TKcon", ConvertToStrSafe(mtk), "maso", "hethongtk")
        LbTK(Index).Tag = ConvertToStrSafe(mtk)
    End Sub
    Private Sub FrmTaikhoantudong_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
