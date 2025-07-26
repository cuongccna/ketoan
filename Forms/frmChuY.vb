Imports System
Imports System.Data.Common
Imports UNET.Utility
Imports System.Windows.Forms
Imports UNET.DataAdapter


Partial Friend Class frmChuY
    Private Sub cmdOK_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdOK.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmChuY_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If eventArgs.KeyCode = Keys.Escape Then
            ExecSQLNonQuery("UPDATE License set ChuY0='" & TxtChuY(0).Text.Trim() & "', ChuY1='" & TxtChuY(1).Text.Trim() & "'")
            Me.Close()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub frmChuY_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            If Not TruongDaCo("License", "ChuY0") Then
                ExecSQLNonQuery("alter table License add ChuY0 char(255) null,ChuY1 char(255) null")
            End If
            'OpenDB(pDataPath)
            Dim str1 As String = String.Empty
            Dim str0 As String = ConvertToStrSafe(GetSelectValue("SELECT ChuY0 as f1,ChuY1 as f2 FROM License", str1))
            If Not IsDBNull(str0) Then
                TxtChuY(0).Text = str0.Trim()
            Else
                TxtChuY(0).Text = ""
            End If
            If Not IsDBNull(str1) Then
                TxtChuY(1).Text = str1.Trim()
            Else
                TxtChuY(1).Text = ""
            End If
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
    Private Sub TxtChuY_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _TxtChuY_1.Leave, _TxtChuY_0.Leave
        Dim Index As Integer = Array.IndexOf(TxtChuY, eventSender)
        ExecSQLNonQuery(String.Format("UPDATE License set ChuY{0}=N'{1}'", Index, TxtChuY(Index).Text.Trim()))
    End Sub
    Private Sub frmChuY_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
