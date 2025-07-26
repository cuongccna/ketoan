Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports UNET.DataAdapter


Partial Friend Class FrmOptTrichluong

    Dim thuchien As Integer

    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_0.Click, _Command_1.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Me.Hide()
        thuchien = Index
    End Sub

    Public Function Trichluong(ByRef bp1 As Integer, ByRef bp2 As Integer, ByRef bp3 As Integer, ByRef bp4 As Integer) As Integer
        Me.ShowDialog()
        If Chk(0).CheckState = CheckState.Checked Then bp1 = ConvertToDblSafe(Chk(0).Tag)
        If Chk(1).CheckState = CheckState.Checked Then bp2 = ConvertToDblSafe(Chk(1).Tag)
        If Chk(2).CheckState = CheckState.Checked Then bp3 = ConvertToDblSafe(Chk(2).Tag)
        If Chk(3).CheckState = CheckState.Checked Then bp4 = ConvertToDblSafe(Chk(3).Tag)
        Return thuchien
    End Function

    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Dim i As Integer
        Dim rs As DataTable = ExecSQLReturnDT("SELECT t1.maso, t1.ten FROM phanloaiquanlynhanvien t1 inner join quanlynhanvien t2 on t1.maso=t2.maphanloai WHERE cap=2 group by t1.maso,t1.ten")

        For i = 0 To 3
            Chk(i).Visible = False
        Next
        i = 0
        Dim rsIndex As Integer = 0
        While rsIndex < rs.Rows.Count And i <= 3
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL

            Chk(i).Visible = True
            Chk(i).Text = rsItem("ten")
            Chk(i).Tag = rsItem("MaSo")
            i += 1
            ''rs.MoveNext()
        End While

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmOptTrichluong_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.V
                    Command(1).Focus()
                    'Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.T
                    Command(0).Focus()
                    'Command_ClickEvent(Command(0), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Command_ClickEvent(Command(1), New EventArgs())
    End Sub


    Private Sub FrmOptTrichluong_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            SetFont(Me)
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
    Private Sub FrmOptTrichluong_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
