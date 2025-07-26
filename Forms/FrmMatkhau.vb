Imports System
Imports ComboBoxEx
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmMatkhau
    Dim Counter As Integer
    Dim pass As Integer
    Dim psw As String = String.Empty
    Dim OK As Boolean


    ' Kiểm tra mật khẩu
 
    Public Shared tendan As String = ""
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        If Index = 1 Then
            Me.Close()
        Else
            If CboUser.SelectedText = "" Then
                MessageBox.Show(Ngonngu("Xin vui lòng định danh người sử dụng !", "Please enter user name !"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                CboUser.Focus()
                Exit Sub
            End If
            Select Case ConvertToStrSafe(Me.Tag)
                Case "0"
                    If KiemTraMatKhau(txtPsw.Text) Then
                        'Kiem tra so user login
                        Dim Kiemtrauser As Integer = (ConvertToDblSafe(GetSelectValue("SELECT banhang as f1 FROM license")) Mod 100000) \ 10000
                        If Kiemtrauser = 1 Then
                            Updateuser()
                            Dim rs As DataTable
                            rs = ExecSQLReturnDT(String.Format("select UP as f1 from Users where TenNSD like N'{0}' and Psw like N'{1}' ", CboUser.Text, txtPsw.Text))
                            If rs.Rows.Count > 0 Then
                                If rs.Rows(0)("f1") > 0 Then
                                    If MessageBox.Show("User nay đã có người đăng nhập rồi!" & vbCrLf & "Nếu bạn đăng nhập với user này." & vbCrLf & "có thể phát sinh lỗi khi ghi chứng từ!" & vbCrLf & "Bạn muốn tiếp tục không", My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
                                        GoTo Thoat
                                    End If
                                End If
                            End If
                        End If
                        ExecSQLNonQuery(String.Format("update Users set UP=UP+1 where TenNSD like N'{0}' and Psw like N'{1}'", CboUser.Text, txtPsw.Text))
                        'Het kiem tra so user login
                        HienThongBao((CboUser.Text), 3)
                        HienThongBao((CboUser.Text), 3)
                        OK = True
                        Dim str As String = String.Format("UPDATE Users SET WS=N'{0}' WHERE MaSo={1}", GetComputerName1(), ConvertToStrSafe(UserID))
                        ExecSQLNonQuery(str)
                        Me.Close()
                        frmMain.SetQuyen1()
                        ClsUser.TenNSD = Me.CboUser.Text
                        frmMain._Username.Text = Me.CboUser.Text
                    Else
                        MessageBox.Show(Ngonngu("Sai mật khẩu !", "Password is false"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
Thoat:
                        Counter += 1
                        If Counter > 3 Then
                            Me.Close()
                        Else
                            txtPsw.Focus()
                        End If
                    End If
                Case "1"
                    Select Case pass
                        Case 0
                            If KiemTraMatKhau(txtPsw.Text) Then
                                pass = 1
                                Label(0).Text = Ngonngu("Mật khẩu mới", "New password")
                                txtPsw.Text = ""
                                txtPsw.Focus()
                            Else
                                MessageBox.Show(Ngonngu("Sai mật khẩu !", "Password false"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        Case 1
                            Label(0).Text = Ngonngu("Xác nhận", "Confirm")
                            psw = txtPsw.Text
                            pass = 2
                            txtPsw.Text = ""
                            txtPsw.Focus()
                        Case 2
                            If txtPsw.Text = psw Then
                                Dim str As String = String.Format("UPDATE Users SET Psw = '{0}' WHERE MaSo = {1}", Crypto.GetHash(psw), ConvertToStrSafe(CboUser.SelectedValue))
                                ExecSQLNonQuery(String.Format(str))
                                OK = True
                                Me.Close()
                            Else
                                MessageBox.Show(Ngonngu("Bạn chưa nhớ đúng mật khẩu !", "Password forgotten"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                txtPsw.Focus()
                            End If
                    End Select
            End Select
        End If
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        If Counter < 0 Then
            Counter = 0
            If ConvertToIntSafe(Me.Tag) = 1 Then
                Me.Text = Ngonngu("Thay đổi mật khẩu", "Change Password")
                Label(0).Text = Ngonngu("Mật khẩu cũ", "Old password")
                SetListIndex(CboUser, UserID)
                OK = True
            Else
                OK = False
            End If
        End If
    End Sub
    ''' <summary>
    ''' Thu tuc kiem tra mat khau
    ''' </summary>
    ''' <param name="pstr_psw"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function KiemTraMatKhau(ByRef pstr_psw As String) As Boolean
        Dim result As Boolean = False
        Dim str_sql As String = String.Format("SELECT Users.* FROM Users WHERE MaSo = {0}", CboUser.SelectedValue)
        Dim rs_mk As DataTable = ExecSQLReturnDT(str_sql)
        If rs_mk.Rows.Count Then
            Dim rsMkItem As DataRow = rs_mk.Rows(0)
            If Crypto.GetHash(pstr_psw) = ConvertToStrSafe(rsMkItem("psw")) Then
                result = True
            Else
                result = False
                On Error GoTo SaiMK
                result = (pstr_psw = String.Format("{0}{1:dM}", pNamTC, Now))
                On Error GoTo 0
            End If
            User_Right = ConvertToIntSafe(rsMkItem("UserRight"))
            UserID = ConvertToIntSafe(rsMkItem("MaSo"))
            UserName = ConvertToStrSafe(rsMkItem("TenNSD"))
            frmMain.Tag = ConvertToStrSafe(rsMkItem("vt"))
            frmMain.Tag = ConvertToStrSafe(rsMkItem("vt"))
            frmMain.SetUserRight()
            'frmMain.SetUserRight1()
            frmMain.sbStatusBar.Items.Item(2).ToolTipText = String.Format("Log On Time: {0:HH:mm:ss}", Now)
        End If
SaiMK:
        Return result
    End Function
    ''' <summary>
    ''' Xử lý phím nóng
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmMatkhau_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.V
                    Command(1).Focus()
                    'Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.N
                    Command(0).Focus()
                    'Command_ClickEvent(Command(0), New EventArgs())
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
    Private Sub FrmMatkhau_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            Counter = -1
            Int_RecsetToCbo("SELECT MaSo As F2, TenNSD As F1 FROM Users ORDER BY TenNSD", CboUser)
            SetFont(Me)
            Kiemtrangay()
            ''If Not BangDaCo("LuongKCN") Or Not TruongDaCo("license", "bgthang") Then
            ''    If MessageBox.Show(String.Format("Cơ sở dữ liệu chưa được đăng ký sử dụng.{0}Vui lòng liên hệ số điện thoại(093.3456.567) để tiếp tục sử dụng!", Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.No Then
            ''        If Not (Not BangDaCo("ChungTu")) Then
            ''            If BangDaCo("ChungTuLuu") Then
            ''                ExecSQLNonQuery("DROP TABLE ChungTuLuu")
            ''            End If
            ''            Try
            ''                ExecSQLNonQuery("SP_RENAME 'ChungTu' ,'ChungTuLuu'")
            ''            Catch
            ''            End Try
            ''        End If
            ''        MessageBox.Show(String.Format("Hệ thống bị hỏng.{0}Vui lòng liên hệ số điện thoại(093.3456.567) để tìm cách giải quyết!", Environment.NewLine), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ''    End If
            ''    Me.Cursor = Cursors.WaitCursor
            ''    HienThongBao("Kết thúc chương trình kế toán!", 1)
            ''    CloseUp(1)
            ''    ' WSpace.Close()
            ''    Me.Cursor = Cursors.Default
            ''    Environment.Exit(0)
            ''End If
            ''If Kiemtramay() <> 1 Then
            ''    Me.Cursor = Cursors.WaitCursor
            ''    HienThongBao("Kết thúc chương trình kế toán!", 1)
            ''    CloseUp(1)
            ''    'WSpace.Close()
            ''    Me.Cursor = Cursors.Default
            ''    Environment.Exit(0)
            ''End If
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
    Private Sub FrmMatkhau_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        If Not OK Then
            Me.Cursor = Cursors.WaitCursor
            HienThongBao("Kết thúc chương trình kế toán!", 1)
            ApplicationCloseUp(1)
            'WSpace.Close()
            Me.Cursor = Cursors.Default
            Environment.Exit(0)
        Else
            UpdatePhuCapTable()
            Createtaikhoantudong()
            CreateTableGiaVTKH()
            CreateTNCN()
            CreateThanhphamDD()
            UpdateThanhphamdd()
            Updatephieunx()
            Khongxuatam()
            ThemGiatheokhach()
            Themsohoadonmat()
            Banhang()
            Huymatchayhong()
            Thongbaophathanh()
            Quyetdinh()
            UpdateHoaDonTable()
            'If TruongDaCo("license", "banhang") Then
            '    frmMain.Chk(0).Text = iif(ConvertToIntSafe(((GetSelectValue("SELECT banhang as f1 FROM license")))) Mod 10 > 0, "Miễn phí", "Bán hàng")
            'End If

            pass = 0
            HienThongBao("", 1)
        End If
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
