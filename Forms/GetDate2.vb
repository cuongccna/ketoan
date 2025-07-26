Imports System
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class GetDate2
    Dim Ngay(1) As Date
    Dim esc As Integer
    ''' <summary>
    ''' GetDate2_KeyPress
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GetDate2_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles MyBase.KeyPress
        Try
            Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
            Select Case KeyAscii
                Case 27
                    esc = 1
                    Me.Close()
            End Select
            If KeyAscii = 0 Then
                eventArgs.Handled = True
            End If
        Catch ex As Exception
            myUMessager.mError(ex.Message, "Lấy ngày tháng", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try                
    End Sub
    ''' <summary>
    ''' GetDate2_Load
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GetDate2_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load        
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            esc = 0
            For chi_so As Integer = 0 To 1
                InitDateVars(MedNgay(chi_so), Ngay(chi_so))
            Next
            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    ''' <summary>
    ''' MedNgay_Enter
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_0.Enter, _MedNgay_1.Enter
        Try
            Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
            MedNgay(Index).SelectAll()
        Catch ex As Exception
            myUMessager.mError(ex.Message, "Lấy ngày tháng", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    ''' <summary>
    ''' MedNgay_KeyPressEvent
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_KeyPressEvent(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _MedNgay_0.KeyPress, _MedNgay_1.KeyPress
        Try
            Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
            Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
            If KeyAscii = 13 Then
                Select Case Index
                    Case 0 : MedNgay(1).Focus()
                    Case 1
                        MedNgay_Leave(MedNgay(1), New EventArgs())
                        Me.Close()
                End Select
            End If
            If KeyAscii = 0 Then
                eventArgs.Handled = True
            End If
        Catch ex As Exception
            myUMessager.mError(ex.Message, "Lấy ngày tháng", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' MedNgay_Leave
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_0.Leave, _MedNgay_1.Leave
        Try
            Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
            If Information.IsDate(MedNgay(Index).Text) Then
                Ngay(Index) = ConvertToDateSafe(MedNgay(Index).Text)
            Else
                MedNgay(Index).Focus()
            End If
        Catch ex As Exception
            myUMessager.mError(ex.Message, "Lấy ngày tháng", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    ''' <summary>
    ''' GetDate
    ''' </summary>
    ''' <param name="s"></param>
    ''' <param name="d1"></param>
    ''' <param name="d2"></param>
    ''' <param name="setndau"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDate(ByRef s As String, ByRef d1 As Date, ByRef d2 As Date, Optional ByRef setndau As Integer = 0) As Boolean
        Try
            Me.Text = s
            If setndau > 0 Then
                Ngay(0) = d1
                MedNgay(0).Text = Format(d1, Mask_D)
                MedNgay(0).Enabled = False
            End If
            Me.ShowDialog()
            If esc = 1 Then
                Return False
            Else
                d1 = Ngay(0)
                d2 = Ngay(1)
                Return True
            End If
        Catch ex As Exception
            myUMessager.mError(ex.Message, s, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Function
    ''' <summary>
    ''' GetDate1
    ''' </summary>
    ''' <param name="s"></param>
    ''' <param name="d1"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDate1(ByRef s As String, ByRef d1 As Date) As Boolean
        Try
            Me.Text = s
            MedNgay(1).Visible = False
            Me.ShowDialog()
            If esc = 1 Then
                Return False
            Else
                d1 = Ngay(0)
                Return True
            End If
        Catch ex As Exception
            myUMessager.mError(ex.Message, s, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try        
    End Function
End Class
