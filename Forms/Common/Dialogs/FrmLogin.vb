Imports UNET.Utility
Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter

Public Class FrmLogin
    Private _Password As String = String.Empty
    Private _PasswordMaxWrongCount As Integer
    Private _PasswordStatus As Status
    Private _Count As Integer = 0
    Private _UserName As String = String.Empty

    Sub New()
        InitializeComponent()
    End Sub

    Public Enum Status
        Denied = 0
        Accepted = 1
    End Enum
    Public Property UserName() As String
        Get
            Return _UserName
        End Get
        Set(ByVal value As String)
            If _UserName = value Then
                Return
            End If
            _UserName = value
        End Set
    End Property
    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            If _Password = value Then
                Return
            End If
            _Password = value
        End Set
    End Property
    Public Property PasswordMaxWrongCount() As Integer
        Get
            Return _PasswordMaxWrongCount
        End Get
        Set(ByVal value As Integer)
            If _PasswordMaxWrongCount = value Then
                Return
            End If
            _PasswordMaxWrongCount = value
        End Set
    End Property
    Public ReadOnly Property PasswordStatus() As Status
        Get
            Return _PasswordStatus
        End Get
    End Property


    Private Sub frm_Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.Activate()
            Text = "Đăng nhập"
            Int_RecsetToCbo("SELECT MaSo As F2, TenNSD As F1 FROM Users ORDER BY TenNSD", UserTextBox)
            UserTextBox.SelectAll()
            UserTextBox.Focus()
            _PasswordMaxWrongCount = 3
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try        
    End Sub

    Private Sub frm_Login_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If _PasswordStatus = Status.Accepted Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
        MemoryHelper.ReleaseMemory()
    End Sub

    Private Sub PasswordTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        UserTextBox.SelectAll()
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If CheckLogin(UserTextBox.Text, PasswordTextBox.Text) Then
            'Kiem tra so user login
            Dim Kiemtrauser As Integer = (ConvertToDblSafe(GetSelectValue("SELECT banhang as f1 FROM license")) Mod 100000) \ 10000
            If Kiemtrauser = 1 Then
                Updateuser()
                Dim rs As DataTable
                rs = ExecSQLReturnDT(String.Format("select up as f1 from users where tenNSD like N'{0}' and psw like N'{1}' ", UserTextBox.Text, PasswordTextBox.Text))
                If rs.Rows.Count > 0 Then
                    'If rs.Rows(0)("f1") > 0 Then
                    '    If MessageBox.Show("User nay đã có người đăng nhập rồi!" & vbCrLf & "Nếu bạn đăng nhập với user này." & vbCrLf & "có thể phát sinh lỗi khi ghi chứng từ!" & vbCrLf & "Bạn muốn tiếp tục không", My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
                    '        GoTo Thoat
                    '    End If
                    'End If
                End If
            End If
            'ExecSQLNonQuery(String.Format("update users set up=up+1 where tenNSD like N'{0}' and psw like N'{1}'", UserTextBox.Text, PasswordTextBox.Text))
            _UserName = UserTextBox.Text
            _PasswordStatus = Status.Accepted            
            DialogResult = System.Windows.Forms.DialogResult.OK
            ClsUser.TenNSD = UserTextBox.Text            
            Close()
        Else
            ClsUser.TenNSD = String.Empty
            _Count += 1
            _PasswordStatus = Status.Denied
            myUMessager.mError(Ngonngu("Sai tên đăng nhập hoặc mật khẩu! Xin vui lòng kiểm tra và thử lại.", _
                                        "False uer name or password! Please test and try again"), _
                   String.Format(Ngonngu("Truy cập bị từ chối - lần {0}!", "Access denied - leve{0}!"), _Count), _
                  MessageBoxButtons.OK, _
                  MessageBoxIcon.Exclamation)
            With UserTextBox
                .SelectAll()
                .Focus()
            End With
            If (_Count >= _PasswordMaxWrongCount) Then
                DialogResult = System.Windows.Forms.DialogResult.Cancel
                Close()
            End If
        End If
        GC.Collect()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Try            
            DialogResult = System.Windows.Forms.DialogResult.Cancel
            MemoryHelper.ReleaseMemory()
            Close()
        Catch ex As Exception
            myUMessager.mError(ex.Message, "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function CheckLogin(ByVal UserName As String, ByVal Password As String) As Boolean
        Dim returnValue As Boolean = False
        Try
            Dim dt As New DataTable

            dt = ExecSQLReturnDT(String.Format("SELECT Psw,userright,maso,tennsd FROM Users WHERE (LOWER(LTRIM(RTRIM(TenNSD))) = N'{0}') AND (Psw =N'{1}')", _
                                       UserName.Trim.ToLower, _
                                       Crypto.GetHash(Password)))
            If dt.Rows.Count > 0 Then
                returnValue = True

                User_Right = ConvertToIntSafe(dt.Rows(0)("UserRight"))                
                UserID = ConvertToIntSafe(dt.Rows(0)("MaSo"))
                UserName = ConvertToStrSafe(dt.Rows(0)("TenNSD"))

                ClsUser.UserRight = User_Right
                ClsUser.MaSo = UserID
                ClsUser.TenNSD = UserName
            Else
                returnValue = False
            End If
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return returnValue
    End Function

    
    Private Sub UserTextBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserTextBox.SelectedIndexChanged
        Try
            btnOK.Enabled = Not (String.IsNullOrEmpty((UserTextBox.Text.Trim)))
        Catch ex As Exception

        End Try
    End Sub
End Class
