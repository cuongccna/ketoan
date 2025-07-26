Public Class FrmSQLConnect

    Private Sub FrmSQLConnect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            Dim toolTip_MayChu As New ToolTip()
            toolTip_MayChu.SetToolTip(lab_MayChu, "Click để tìm danh sách máy chủ dữ liệu!")
            toolTip_MayChu.SetToolTip(labIP, "Click để tìm danh sách máy chủ dữ liệu!")
            Dim toolTip_database As New ToolTip()
            toolTip_database.SetToolTip(labCosodulieu, "Click để tìm danh sách cơ sở dữ liệu!")
            toolTip_database.SetToolTip(lab_data, "Click để tìm danh sách cơ sở dữ liệu!")

            Me.Cursor = Cursors.WaitCursor
            ' load default setting
            cmbMayChu.Text = IIf(My.Settings.DataSource = "", "local", My.Settings.DataSource)
            If (My.Settings.SQLAuthentic = True) Then
                cmbKieuKetNoi.SelectedIndex = 0
                txtUserName.Enabled = False
                txtPasswrod.Enabled = False
            Else
                cmbKieuKetNoi.SelectedIndex = 1
                txtUserName.Enabled = True
                txtPasswrod.Enabled = True
            End If
            
            txtUserName.Text = IIf(My.Settings.UserName.ToString() = String.Empty, "sa", My.Settings.UserName)
            txtPasswrod.Text = IIf(Crypto.StringDecrypt(My.Settings.Passwrod.ToString(), Crypto.cryptoKey) = "", "123", Crypto.StringDecrypt(My.Settings.Passwrod, Crypto.cryptoKey))

            Me.Activate()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbKieuKetNoi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKieuKetNoi.SelectedIndexChanged, cmbDatabaseList.SelectedIndexChanged
        Try
            txtUserName.Enabled = cmbKieuKetNoi.SelectedIndex <> 0
            txtPasswrod.Enabled = cmbKieuKetNoi.SelectedIndex <> 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lab_MayChu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lab_MayChu.Click, labIP.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            cmbMayChu.Enabled = False
            cmbMayChu.Items.Clear()
            For Each serverName As String In GetAvailableServers()
                cmbMayChu.Items.Add(serverName)
            Next
            If (cmbMayChu.Items.Count > 0) Then
                cmbMayChu.SelectedIndex = 0
            End If
            cmbMayChu.Enabled = True
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            cmbMayChu.Enabled = False
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnHuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGiupDo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGiupDo.Click
        Try
            Process.Start("https://ketoanunesco.com")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnKetNoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKetNoi.Click
        Try
            My.Settings.SQLAuthentic = (cmbKieuKetNoi.SelectedIndex <> 0)
            My.Settings.UserName = txtUserName.Text
            My.Settings.Passwrod = Crypto.StringEncrypt(txtPasswrod.Text, Crypto.cryptoKey)
            My.Settings.DataSource = cmbMayChu.Text
            My.Settings.DatabaseName = cmbDatabaseList.Text

            SQLSERVERConnection.ConnectStringControls.DataSource = My.Settings.DataSource
            SQLSERVERConnection.ConnectStringControls.Database = My.Settings.DatabaseName
            SQLSERVERConnection.ConnectStringControls.Password = Crypto.StringDecrypt(My.Settings.Passwrod, Crypto.cryptoKey)
            SQLSERVERConnection.ConnectStringControls.SqlAuthentication = My.Settings.SQLAuthentic
            SQLSERVERConnection.ConnectStringControls.UserName = My.Settings.UserName

            If cmbKieuKetNoi.SelectedIndex = 0 Then
                If cmbDatabaseList.Items.Count = 0 Then
                    myUMessager.mError("Thiếu cơ sở dữ liệu!", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            If (cmbKieuKetNoi.SelectedIndex = 1 And txtUserName.Text = String.Empty) Then
                myUMessager.mError("Thiếu tên đăng nhập!", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If TestConnectToDatabase() Then
                My.Settings.Save()
                frmMain._DatabaseName.Text = SQLSERVERConnection.ConnectStringControls.Database
                frmMain._ServerName.Text = SQLSERVERConnection.ConnectStringControls.DataSource
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                myUMessager.mError("Không thể kết nối tới cơ sở dữ liệu!", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Try
    End Sub

    Private Sub labCosodulieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labCosodulieu.Click, lab_data.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            cmbDatabaseList.Items.Clear()
            For Each item As String In GetDatabases(cmbMayChu.Text, cmbKieuKetNoi.SelectedIndex = 0, txtUserName.Text, txtPasswrod.Text)
                If (Not String.IsNullOrEmpty(item)) Then
                    cmbDatabaseList.Items.Add(item)
                End If
            Next
            If cmbDatabaseList.Items.Count > 0 Then
                cmbDatabaseList.SelectedIndex = 0
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnTaoDuLieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaoDuLieu.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            SQLSERVERConnection.ConnectStringControls.DataSource = cmbMayChu.Text
            SQLSERVERConnection.ConnectStringControls.Database = "master"
            SQLSERVERConnection.ConnectStringControls.Password = txtPasswrod.Text 'Crypto.StringDecrypt(txtPasswrod.Text, Crypto.cryptoKey)
            SQLSERVERConnection.ConnectStringControls.SqlAuthentication = (cmbKieuKetNoi.SelectedIndex <> 0)
            SQLSERVERConnection.ConnectStringControls.UserName = txtUserName.Text

            If (TestConnectToServer() <> True) Then
                Me.Cursor = Cursors.Default
                myUMessager.mError(String.Format("Không thể kết nới tới máy chủ với (tên/IP) : ' {0} '.", cmbMayChu.Text), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim frmCreatedata As New FrmCreateData()
            frmCreatedata.ShowDialog()
            If (frmCreatedata.isFinssh = True) Then
                SQLSERVERConnection.ConnectStringControls.Database = frmCreatedata.DatabaseName
                labCosodulieu_Click(sender, e)

                If (cmbDatabaseList.Items.Count > 0) Then
                    cmbDatabaseList.SelectedItem = frmCreatedata.DatabaseName
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class