Imports Microsoft.Office.Interop

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application AND the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected OR disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            Try
                'set application Environment
                SetupApplicationEnvironment()
                SQLSERVERConnection.ConnectStringControls.DataSource = My.Settings.DataSource
                SQLSERVERConnection.ConnectStringControls.Database = My.Settings.DatabaseName
                SQLSERVERConnection.ConnectStringControls.Password = Crypto.StringDecrypt(My.Settings.Passwrod, Crypto.cryptoKey)
                SQLSERVERConnection.ConnectStringControls.SqlAuthentication = My.Settings.SQLAuthentic
                SQLSERVERConnection.ConnectStringControls.UserName = My.Settings.UserName

                If TestConnectToDatabase() = False Then
                    If (FrmSQLConnect.ShowDialog() <> Windows.Forms.DialogResult.OK) Then
                        Environment.Exit(0)
                    Else
                        'chay kiem tra data thich hop
                        KiemTraDuLieuPhienBan()
                        'het kiem tra
                        Using loginFormDlg As New FrmLogin
                            loginFormDlg.ShowDialog()
                            If loginFormDlg.DialogResult = Windows.Forms.DialogResult.OK Then

                            Else
                                Environment.Exit(0)
                            End If
                        End Using
                        MemoryHelper.ReleaseMemory()
                    End If
                Else
                    'chay kiem tra data thich hop
                    KiemTraDuLieuPhienBan()
                    'het kiem tra
                    Using loginFormDlg As New FrmLogin
                        loginFormDlg.ShowDialog()
                        If loginFormDlg.DialogResult = Windows.Forms.DialogResult.OK Then

                        Else
                            Environment.Exit(0)
                        End If
                    End Using

                    MemoryHelper.ReleaseMemory()
                End If
            Catch ex As Exception
                Throw New ApplicationException("Exception Occured")
            End Try
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub MyApplication_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
            ' Close all Opening Excel
            Try
                If Excel_Global.Workbooks.Count > 0 Then
                    For Each wkbCurrent As Excel.Workbook In Excel_Global.Workbooks
                        Try
                            wkbCurrent.Close()
                        Catch ex As Exception
                        End Try
                    Next wkbCurrent
                End If
            Catch ex As Exception

            End Try
            ' Close all Opening Word
            Try
                If Word_Global.Documents.Count > 0 Then
                    For Each dcmCurrent As Word.Document In Word_Global.Documents
                        Try
                            dcmCurrent.Close()
                        Catch ex As Exception
                        End Try
                    Next dcmCurrent
                End If
            Catch ex As Exception

            End Try
        End Sub
    End Class
End Namespace
