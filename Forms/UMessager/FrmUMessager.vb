Public Class FrmUMessager
    Private _type As Integer = -1

    Public Property Type() As Integer
        Get
            Return _type
        End Get
        Set(ByVal value As Integer)
            _type = value
        End Set
    End Property

    Private Sub FrmUMessager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text = My.Application.Info.CompanyName & " " & My.Application.Info.Version.Major
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            If _type = 1 Then
                btnOK.Visible = True
                btnNo.Visible = False
                btnYes.Visible = False
            ElseIf _type = 2 Then
                btnOK.Visible = False
                btnNo.Visible = True
                btnYes.Visible = True
                btnYes.Focus()
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYes.Click
        Me.DialogResult = DialogResult.Yes
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        Me.DialogResult = DialogResult.No
    End Sub

    Private Sub FrmUMessager_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try

            If e.KeyCode = Keys.Escape OrElse e.KeyCode = Keys.Enter Then

                If _type = 1 Then
                    Me.DialogResult = DialogResult.OK
                Else
                    Me.DialogResult = DialogResult.No
                End If

                Me.Close()
            End If

        Catch __unusedException1__ As Exception
            Throw
        End Try
    End Sub
End Class