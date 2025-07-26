Imports System
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmPassword
    Dim pswx As String = String.Empty
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FPsw_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles MyBase.KeyPress
        Select Case eventArgs.KeyChar
            Case Chr(Keys.Enter)
                pswx = txtPsw.Text
                Me.Close()
            Case Chr(Keys.Escape)
                Me.Close()
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="des"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetPswX(Optional ByRef des As String = "Mật khẩu") As String
        pswx = ""
        Me.Text = des
        Me.ShowDialog()
        Return pswx
    End Function

    Private Sub FrmPassword_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
