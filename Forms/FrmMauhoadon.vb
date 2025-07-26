Imports System
Imports System.Data.Common
Imports UNET.Utility
Imports System.Windows.Forms
Imports UNET.DataAdapter


Partial Friend Class FrmMauhoadon
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_2.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        If Index = 2 Then Me.Close()
    End Sub

    Private Sub FrmMauhoadon_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmMauhoadon_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            opt1_CheckedChanged(opt1(0), New EventArgs())
            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private isInitializingComponent As Boolean
    Private Sub opt1_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _opt1_0.CheckedChanged, _opt1_1.CheckedChanged, _opt1_2.CheckedChanged, _opt1_3.CheckedChanged, _opt1_4.CheckedChanged, _opt1_5.CheckedChanged, _opt1_6.CheckedChanged, _opt1_7.CheckedChanged, _opt1_8.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(opt1, eventSender)
            Picture1.Image = ImageList1.Images.Item(Index)
        End If
    End Sub
    Private Sub FrmMauhoadon_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
