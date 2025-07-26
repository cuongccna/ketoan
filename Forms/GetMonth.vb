Imports System
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class GetMonth
    Dim thang(1) As Integer
    Dim esc As Integer
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GetMonth_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles MyBase.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case 27
                esc = 1
                Me.Close()
        End Select
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GetMonth_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            esc = 0
            For chi_so As Integer = 0 To 1
                AddMonthToCbo(CboThang(chi_so))
                If CboThang(chi_so).Items.Count > 0 Then CboThang(chi_so).SelectedIndex = DateTime.Now.Month - 1
            Next
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
    Private Sub CboThang_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _CboThang_1.KeyPress, _CboThang_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(CboThang, eventSender)
        If CboThang(1).Items.Count > 0 Then
            If CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
        End If

        If KeyAscii = 13 Then
            Select Case Index
                Case 0 : CboThang(1).Focus()
                Case 1 : CboThang_Leave(CboThang(1), New EventArgs())
                    Me.Close()
            End Select
        End If
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboThang_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _CboThang_1.Leave, _CboThang_0.Leave
        Dim Index As Integer = Array.IndexOf(CboThang, eventSender)
        thang(Index) = CboThang(Index).SelectedValue
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="s"></param>
    ''' <param name="thang1"></param>
    ''' <param name="thang2"></param>
    ''' <remarks></remarks>
    Public Sub GetMonth(ByRef s As String, ByRef thang1 As Integer, ByRef thang2 As Integer)
        Me.Text = s
        Me.ShowDialog()
        If esc = 0 Then
            thang1 = thang(0)
            thang2 = thang(1)
        Else
            thang1 = 0
            thang2 = 0
        End If
    End Sub
End Class
