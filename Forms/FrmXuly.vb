Imports System
Imports System.Data.Common
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmXuly

    Dim sh, ma, ma1 As String
    Dim MaSo As Double
    Dim OK As Integer

    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        MaSo = 0
        If Index = 0 Then
            OK = 1
            If Opt(0).Checked = True Then
                If Txt(0).Tag = 0 Then
                    MessageBox.Show(Ngonngu("Vui lòng nhập chính xác khách hàng cần chuyển đi", "Please correct customers need to move"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub
                ElseIf Txt(1).Tag = 0 Then
                    MessageBox.Show(Ngonngu("Vui lòng nhập chính xác khách hàng cần chuyển đến", "Please correct customers move to"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub
                End If
                ExecSQLNonQuery("update chungtu set makh=" & ConvertToStrSafe(Txt(1).Tag) & " where makh=" & ConvertToStrSafe(Txt(0).Tag))
                ExecSQLNonQuery("update chungtu set makhc=" & ConvertToStrSafe(Txt(1).Tag) & " where makhc=" & ConvertToStrSafe(Txt(0).Tag))
                ExecSQLNonQuery("update chungtulq set makh=" & ConvertToStrSafe(Txt(1).Tag) & ", hoten=khachhang.ten , diachi=khachhang.diachi from chungtulq inner join khachhang on chungtulq.makh=khachhang.maso where khachhang.maso=" & ConvertToStrSafe(Txt(0).Tag))
                ExecSQLNonQuery("update hoadon set makhachhang=" & ConvertToStrSafe(Txt(1).Tag) & " where makhachhang=" & ConvertToStrSafe(Txt(0).Tag))
            ElseIf Opt(1).Checked = True Then
                If Txt(0).Tag = 0 Then
                    MessageBox.Show(Ngonngu("Vui lòng nhập chính xác vật tư cần chuyển đi", "Please correct goods need to move"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub
                ElseIf Txt(1).Tag = 0 Then
                    MessageBox.Show(Ngonngu("Vui lòng nhập chính xác vật tư cần chuyển đến", "Please correct goods move to"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub
                End If
                ExecSQLNonQuery("UPDATE chungtu set mavattu=" & ConvertToStrSafe(Txt(1).Tag) & " WHERE mavattu=" & ConvertToStrSafe(Txt(0).Tag))
                'KiemTraVatTu()
            ElseIf Opt(2).Checked = True Then
                If Txt(0).Tag = 0 Then
                    MessageBox.Show(Ngonngu("Vui lòng nhập chính xác tài khoản cần chuyển đi", "Please correct code account need to move"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub
                ElseIf Txt(1).Tag = 0 Then
                    MessageBox.Show(Ngonngu("Vui lòng nhập chính xác tài khoản cần chuyển đến", "Please correct code account move to"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub
                End If
                Dim sotaikhoan As Integer
                sotaikhoan = ConvertToDblSafe((GetSelectValue(String.Format("SELECT count(*) as f1 FROM hethongtk WHERE left(sohieu,{0})='{1}'", Txt(0).Text.Length, Txt(0).Text))))
                If sotaikhoan <> 1 Then
                    MessageBox.Show(Ngonngu("Tài khoản " & Txt(0).Text & " có chi tiết hoặc không có trong hệ thống tài khoản ! ", "Account " & Txt(0).Text & " have details or not in the account list !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                sotaikhoan = ConvertToDblSafe((GetSelectValue(String.Format("SELECT count(*) as f1 FROM hethongtk WHERE left(sohieu,{0})='{1}'", Txt(1).Text.Length, Txt(1).Text))))
                If sotaikhoan <> 1 Then
                    MessageBox.Show(Ngonngu("Tài khoản " & Txt(1).Text & " có chi tiết hoặc không có trong hệ thống tài khoản ! ", "Account " & Txt(1).Text & " have details or not in the account list !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                If ((ConvertToDblSafe(Txt(0).Text.ToString.Substring(0, 3)) = 131 Or ConvertToDblSafe(Txt(0).Text.ToString.Substring(0, 3)) = 331) And (ConvertToDblSafe(Txt(1).Text.ToString.Substring(0, 3)) = 111 Or ConvertToDblSafe(Txt(1).Text.ToString.Substring(0, 3)) = 112)) _
                    Or ((ConvertToDblSafe(Txt(0).Text.ToString.Substring(0, 3)) = 111 Or ConvertToDblSafe(Txt(0).Text.ToString.Substring(0, 3)) = 112) And (ConvertToDblSafe(Txt(1).Text.ToString.Substring(0, 3)) = 131 Or ConvertToDblSafe(Txt(1).Text.ToString.Substring(0, 3)) = 331)) Then
                    MessageBox.Show(Ngonngu("Bạn vui lòng thực hiện thao tác này trong phần liệt kê chứng từ!", "You execute this operations at listing vouchers!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
                ExecSQLNonQuery("UPDATE chungtu set matkno=" & ConvertToStrSafe(Txt(1).Tag) & " WHERE matkno=" & ConvertToStrSafe(Txt(0).Tag))
                ExecSQLNonQuery("UPDATE chungtu set matkco=" & ConvertToStrSafe(Txt(1).Tag) & " WHERE matkco=" & ConvertToStrSafe(Txt(0).Tag))
                'KiemTraTaiKhoan()
            Else
                ExecSQLNonQuery(Txt(2).Text)
            End If
            MessageBox.Show(Ngonngu("Quá trình thực hiện thao tác thành công.", "Successful completion."), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.Close()
        End If
    End Sub

    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Khoaquyen()
    End Sub

    Private Sub FrmOptSuaTonkho_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.T
                    Command(0).Focus()
                Case Keys.V
                    Command(1).Focus()
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Command_ClickEvent(Command(1), New EventArgs())
    End Sub


    Private Sub FrmOptSuaTonkho_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()
            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private isInitializingComponent As Boolean
    Private Sub Opt_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Opt_3.CheckedChanged, _Opt_2.CheckedChanged, _Opt_1.CheckedChanged, _Opt_0.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(Opt, eventSender)
            If Opt(0).Checked Then
                Label.Text = Ngonngu("Mã khách hàng", "Customer code")
                Label1.Text = Ngonngu("Mã khách hàng", "Customer code")
            ElseIf Opt(1).Checked Then
                Label.Text = Ngonngu("Mã vật tư", "Material code")
                Label1.Text = Ngonngu("Mã vật tư", "Material code")
            ElseIf Opt(2).Checked Then
                Label.Text = Ngonngu("Mã tài khoản", "Account code")
                Label1.Text = Ngonngu("Mã tài khoản", "Account code")
            End If
            If Opt(3).Checked Then
                Txt(2).Enabled = True
                Txt(2).Focus()
            Else
                Txt(2).Enabled = False
                Txt(0).Focus()
            End If
        End If
    End Sub

    Private Sub txtVT_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _Txt_0.KeyPress, _Txt_1.KeyPress
        Dim Index As Integer = Array.IndexOf(Txt, eventSender)
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim ten As String = ""
        If KeyAscii = 27 Then
            Me.Close()
        ElseIf KeyAscii = 13 Then
            If Opt(0).Checked Then
                Txt(Index).Text = FrmKhachHang.ChonKhachHang(Txt(Index).Text)
                Txt(Index).Tag = ConvertToIntSafe(GetSelectValue("select maso as f1, ten as f2 from khachhang where sohieu like '" & Txt(Index).Text & "'", ten))
                Lab(Index).Text = ten
            ElseIf Opt(1).Checked Then
                Txt(Index).Text = FrmVattu.ChonVattu(Txt(Index).Text)
                Txt(Index).Tag = ConvertToIntSafe(GetSelectValue("select maso as f1, tenvattu as f2 from vattu where sohieu like '" & Txt(Index).Text & "'", ten))
                Lab(Index).Text = ten
            Else
                Txt(Index).Text = FrmTaikhoan.ChonTk(Txt(Index).Text)
                Txt(Index).Tag = ConvertToIntSafe(GetSelectValue("select maso as f1, ten as f2 from hethongtk where sohieu like '" & Txt(Index).Text & "'", ten))
                Lab(Index).Text = ten
            End If
        End If
    End Sub

    Public Function thuchien() As Integer
        OK = 0
        Me.ShowDialog()
        Return OK
    End Function

    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(0).Enabled = (User_Right <> 2 Or (UserID = uid))
    End Sub
    Private Sub FrmOptSuaTonkho_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub

    Private Sub _Txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles _Txt_0.LostFocus, _Txt_1.LostFocus
        Dim Index As Integer = Array.IndexOf(Txt, sender)
        Dim ten As String = ""
        If Opt(0).Checked Then
            Txt(Index).Tag = ConvertToIntSafe(GetSelectValue("select maso as f1, ten as f2 from khachhang where sohieu like '" & Txt(Index).Text & "'", ten))
            If ten <> "0" Then Lab(Index).Text = ten Else Lab(Index).Text = ""
        ElseIf Opt(1).Checked Then
            Txt(Index).Tag = ConvertToIntSafe(GetSelectValue("select maso as f1, tenvattu as f2 from vattu where sohieu like '" & Txt(Index).Text & "'", ten))
            If ten <> "0" Then Lab(Index).Text = ten Else Lab(Index).Text = ""
        Else
            Txt(Index).Tag = ConvertToIntSafe(GetSelectValue("select maso as f1, ten as f2 from hethongtk where sohieu like '" & Txt(Index).Text & "'", ten))
            If ten <> "0" Then Lab(Index).Text = ten Else Lab(Index).Text = ""
        End If
    End Sub
End Class
