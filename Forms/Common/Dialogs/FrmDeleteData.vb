Public Class FrmDeleteData

    Private Sub FrmDeleteData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Try
            DanhSachDuLieu()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub FrmDeleteData_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Me.Cursor = Cursors.WaitCursor
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            ElseIf e.KeyCode = Keys.Enter Then
                ThucHienXoaDuLieu()
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Function ThucHienXoaDuLieu() As Boolean
        Me.Cursor = Cursors.WaitCursor
        Dim dataName As String = SQLSERVERConnection.ConnectStringControls.Database
        Try
            If myUMessager.mQuestion(Ngonngu("Bạn có chắc muốn xóa dữ liệu này không?", "Do you want delete this data?"), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Return False
            End If
            Me.Cursor = Cursors.WaitCursor
            If cmbDanhSachDulieu.Text = "" Then
                Me.Cursor = Cursors.Default
                myUMessager.mWarning(Ngonngu("Không có dữ liệu để xóa!", "Data is empty!, not work."), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            SQLSERVERConnection.ConnectStringControls.Database = "master"
            Dim scriptHandle As String = String.Format("DROP DATABASE [{0}]", cmbDanhSachDulieu.Text)
            If (ExcuteScriptSQL(scriptHandle)) <> True Then
                Me.Cursor = Cursors.Default
                myUMessager.mError(Ngonngu("Dữ liệu chưa được xóa!", "Data not delete."), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                SQLSERVERConnection.ConnectStringControls.Database = dataName
                Me.Cursor = Cursors.Default
                myUMessager.mInformation(Ngonngu("Dữ liệu xóa thành công!", "Data delete success."), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DanhSachDuLieu()
            End If
            Me.Cursor = Cursors.Default
            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
            SQLSERVERConnection.ConnectStringControls.Database = dataName
        End Try
        Me.Cursor = Cursors.Default

    End Function
    Private Sub DanhSachDuLieu()
        Me.Cursor = Cursors.WaitCursor
        Try
            Me.Cursor = Cursors.WaitCursor
            cmbDanhSachDulieu.Items.Clear()
            For Each item As String In GetDatabases(My.Settings.DataSource, My.Settings.SQLAuthentic, My.Settings.UserName, Crypto.StringDecrypt(My.Settings.Passwrod, Crypto.cryptoKey))
                If (Not String.IsNullOrEmpty(item)) Then
                    If SQLSERVERConnection.ConnectStringControls.Database <> item Then
                        cmbDanhSachDulieu.Items.Add(item)
                    End If
                End If
            Next
            If cmbDanhSachDulieu.Items.Count > 0 Then
                cmbDanhSachDulieu.SelectedIndex = 0
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default        
    End Sub

    Private Sub btnDong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub btnThucHien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThucHien.Click
        ThucHienXoaDuLieu()
    End Sub
End Class