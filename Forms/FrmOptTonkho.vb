Imports System
Imports System.Data.Common
Imports UNET.Utility
Imports System.Windows.Forms
Imports UNET.DataAdapter


Partial Friend Class FrmOptTonkho
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Me.Hide()
        If Index = 0 Then
            If Opt(0).Checked Then
                FrmTonkho.mnct_Click(FrmTonkho.mnct(0), New EventArgs())
            Else
                If Opt(1).Checked Then
                    FrmTonkho.mnct_Click(FrmTonkho.mnct(1), New EventArgs())
                Else
                    If Opt(2).Checked Then
                        FrmTonkho.mnct_Click(FrmTonkho.mnct(2), New EventArgs())
                    Else
                        FrmTonkho.mnct_Click(FrmTonkho.mnct(3), New EventArgs())
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub FrmOptTonkho_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.V
                    Command(1).Focus()
                    'Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.L
                    Command(0).Focus()
                    'Command_ClickEvent(Command(0), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Command_ClickEvent(Command(1), New EventArgs())
    End Sub

    Private Sub FrmOptTonkho_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub

    Private Sub FrmOptTonkho_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
