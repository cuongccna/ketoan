Imports System.Text.RegularExpressions

Public Class FrmCreateData
    Public DatabaseName As String = String.Empty
    Public isFinssh As Boolean = False

    Private Sub FrmCreateData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Try            
            Me.ErrorProvider1.Clear()
            Me.TabControl_CreateDatabase.SelectedIndex = 0
            isFinssh = False
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnTiepTheo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTiepTheo.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            'validate ten data base
            If (ValidateDatabaseName(txtTenDuLieu.Text)) Then
                Me.ErrorProvider1.SetError(txtTenDuLieu, "Tên dữ liệu này đã tồn tại, làm ơn chọn tên khác tên hiện tại!")
            Else
                Me.TabControl_CreateDatabase.SelectedIndex = 1
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub txtTenDuLieu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTenDuLieu.TextChanged
        Me.Cursor = Cursors.WaitCursor
        Try
            Me.ErrorProvider1.Clear()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnThucHien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThucHien.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim isSuccess As Boolean = True
            Dim scriptHandle As String = String.Empty

            scriptHandle = String.Format("CREATE DATABASE [{0}]", txtTenDuLieu.Text)
            If (ExcuteScriptSQL(scriptHandle)) <> True Then
                Me.TabControl_CreateDatabase.SelectedIndex = 2
                labSuccess.Text = "Quá trình tạo dữ liệu thất bại!"
                labSuccess.ForeColor = Color.Red
                labSuccess_desc.Visible = False
                btnBatDauSuDung.Enabled = False
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            scriptHandle = String.Format("ALTER DATABASE [{0}] SET ANSI_NULL_DEFAULT OFF ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET ANSI_NULLS OFF  ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET ANSI_PADDING OFF   ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET ANSI_WARNINGS OFF   ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET ARITHABORT OFF   ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET AUTO_CLOSE OFF   ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET AUTO_CREATE_STATISTICS ON   ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET AUTO_SHRINK OFF   ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET AUTO_UPDATE_STATISTICS ON   ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET CURSOR_CLOSE_ON_COMMIT OFF  ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET CURSOR_DEFAULT  GLOBAL   ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET CONCAT_NULL_YIELDS_NULL OFF   ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET NUMERIC_ROUNDABORT OFF  ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET QUOTED_IDENTIFIER OFF   ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET RECURSIVE_TRIGGERS OFF   ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET  DISABLE_BROKER   ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET AUTO_UPDATE_STATISTICS_ASYNC OFF   ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET DATE_CORRELATION_OPTIMIZATION OFF   ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET TRUSTWORTHY OFF   ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET ALLOW_SNAPSHOT_ISOLATION OFF   ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET PARAMETERIZATION SIMPLE   ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET READ_COMMITTED_SNAPSHOT OFF   ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET RECOVERY SIMPLE   ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET  MULTI_USER   ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET PAGE_VERIFY CHECKSUM    ", txtTenDuLieu.Text) & vbNewLine & _
                        String.Format("ALTER DATABASE [{0}] SET DB_CHAINING OFF   ", txtTenDuLieu.Text) & vbNewLine
            If (ExcuteScriptSQL(scriptHandle)) <> True Then
                Me.TabControl_CreateDatabase.SelectedIndex = 2
                labSuccess.Text = "Quá trình tạo dữ liệu thất bại!"
                labSuccess.ForeColor = Color.Red
                labSuccess_desc.Visible = False
                btnBatDauSuDung.Enabled = False
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            SQLSERVERConnection.ConnectStringControls.Database = txtTenDuLieu.Text
            Dim script As String = File.ReadAllText(Application.StartupPath() & "\db\db.sql")
            Dim commandStrings As IEnumerable(Of String) = Regex.Split(script, "^\s*GO\s*$", RegexOptions.Multiline Or RegexOptions.IgnoreCase)
            ProgressBar_TienTrinh.Maximum = commandStrings.Count() + 1
            ProgressBar_TienTrinh.Minimum = 1
            btnThucHien.Enabled = False
            Dim i As Integer = 1
            For Each commandString As String In commandStrings

                If commandString.Trim() <> "" Then
                    i = i + 1
                    ProgressBar_TienTrinh.Value = i
                    If ExcuteScriptSQL(commandString.ToString()) <> True Then
                        isSuccess = False
                        Exit For
                    End If
                End If
            Next
            SQLSERVERConnection.ConnectStringControls.Database = "master"
            scriptHandle = String.Format("ALTER DATABASE [{0}] SET  READ_WRITE  ", txtTenDuLieu.Text) & vbNewLine
            If (ExcuteScriptSQL(scriptHandle)) <> True Then
                Me.TabControl_CreateDatabase.SelectedIndex = 2
                labSuccess.Text = "Quá trình tạo dữ liệu thất bại!"
                labSuccess.ForeColor = Color.Red
                labSuccess_desc.Visible = False
                btnBatDauSuDung.Enabled = False
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            SQLSERVERConnection.ConnectStringControls.Database = txtTenDuLieu.Text
            If isSuccess <> True Then
                btnThucHien.Enabled = True
                Me.TabControl_CreateDatabase.SelectedIndex = 2
                labSuccess.Text = "Quá trình tạo dữ liệu thất bại!"
                labSuccess.ForeColor = Color.Red
                labSuccess_desc.Visible = False
                btnBatDauSuDung.Enabled = False
            Else
                Me.TabControl_CreateDatabase.SelectedIndex = 2
                labSuccess.ForeColor = Color.Green
                labSuccess_desc.Visible = True
                btnBatDauSuDung.Enabled = True
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnBatDauSuDung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatDauSuDung.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If TestConnectToDatabase() Then
                My.Settings.DatabaseName = txtTenDuLieu.Text
                My.Settings.Save()
                frmMain._DatabaseName.Text = SQLSERVERConnection.ConnectStringControls.Database
                frmMain._ServerName.Text = SQLSERVERConnection.ConnectStringControls.DataSource
                Me.DatabaseName = txtTenDuLieu.Text
                isFinssh = True
                Me.Close()
            Else
                Me.DatabaseName = String.Empty
                isFinssh = False
                myUMessager.mError("Không thể kết nối tới cơ sở dữ liệu!", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class