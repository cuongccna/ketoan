Imports System
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmCalc
    Dim Status As Integer
    Dim Operator_Renamed As Integer
    Dim sDecimal As String = String.Empty
    Dim r1 As Double
    Dim m As Double
    Dim kb As Keys
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Calc() As Double
        Dim result As Double = 0
        Me.ShowDialog()
        result = ConvertToDblSafe(kq.Text)
        Me.Close()
        Return result
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FrmCalc_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmCal_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If kb = Keys.Return And eventArgs.KeyCode = Keys.Return Then
            Me.Hide()
            Exit Sub
        End If
        Select Case eventArgs.KeyCode
            Case Keys.D0 To Keys.D9 : If (Shift And 1) = 0 Then Label_Click(Label(eventArgs.KeyCode - 48), New EventArgs())
            Case Keys.NumPad0 To Keys.NumPad9 : Label_Click(Label(eventArgs.KeyCode - 96), New EventArgs())
            Case Keys.PageUp, Keys.PageDown : Label_Click(Label(10), New EventArgs())
            Case Keys.Decimal, 0 : Label_Click(Label(11), New EventArgs())
            Case Keys.Divide, 191 : Label_Click(Label(12), New EventArgs())
            Case Keys.Multiply : Label_Click(Label(13), New EventArgs())
            Case Keys.Subtract, 189 : Label_Click(Label(14), New EventArgs())
            Case Keys.Add : Label_Click(Label(15), New EventArgs())
            Case Keys.Home : Label_Click(Label(16), New EventArgs())
            Case 220 : Label_Click(Label(17), New EventArgs())
            Case Keys.End : Label_Click(Label(18), New EventArgs())
            Case Keys.Return : Label_Click(Label(19), New EventArgs())
            Case Keys.Back : Label_Click(Label(20), New EventArgs())
            Case Keys.Delete : Label_Click(Label(21), New EventArgs())
            Case Keys.F12 : Label_Click(Label(22), New EventArgs())
            Case Keys.C : Label_Click(Label(23), New EventArgs())
            Case Keys.R : Label_Click(Label(24), New EventArgs())
            Case Keys.M : Label_Click(Label(25), New EventArgs())
            Case Keys.P : Label_Click(Label(26), New EventArgs())
            Case Keys.Escape : Me.Hide()
        End Select
        kb = eventArgs.KeyCode
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmCal_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        sDecimal = sDecimal
        Operator_Renamed = 0
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Label_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Button_27.Click, _Button_26.Click, _Button_25.Click, _Button_24.Click, _Button_23.Click, _Button_22.Click, _Button_21.Click, _Button_20.Click, _Button_19.Click, _Button_18.Click, _Button_17.Click, _Button_16.Click, _Button_15.Click, _Button_14.Click, _Button_13.Click, _Button_12.Click, _Button_11.Click, _Button_10.Click, _Button_9.Click, _Button_8.Click, _Button_7.Click, _Button_6.Click, _Button_5.Click, _Button_4.Click, _Button_3.Click, _Button_2.Click, _Button_1.Click, _Button_0.Click
        Dim Index As Integer = Array.IndexOf(Label, eventSender)
        For i As Integer = 0 To Label.Length - 1
            Label(i).Font = VB6.FontChangeBold(Label(i).Font, i = Index)
        Next
        Dim r As Double = ConvertToDblSafe(kq.Text)
        Select Case Index
            Case 0 To 9
                kq.Text = IIf(Status = 0 And (r <> 0 Or kq.Text.IndexOf(sDecimal) > 0), String.Format("{0}{1}", kq.Text, ConvertToStrSafe(Index)), ConvertToStrSafe(Index))
                Status = 0
            Case 10
                If r = 0 Then Exit Sub
                kq.Text = IIf(Strings.Left(kq.Text, 1) <> "-", String.Format("-{0}", kq.Text), Strings.Right(kq.Text, Strings.Len(kq.Text) - 1))
            Case 11
                If (kq.Text.IndexOf(sDecimal) + 1) = 0 Then kq.Text = String.Format("{0}{1}", kq.Text, sDecimal)
            Case 12, 13, 14, 15
                If Operator_Renamed > 0 Then
                    Label_Click(Label(19), New EventArgs())
                    r = ConvertToDblSafe(kq.Text)
                End If
                r1 = r
                Operator_Renamed = Index - 11
                Status = 1
                GoTo d
            Case 16
                r = Math.Sqrt(r)
                GoTo d
            Case 17
                r /= 100
                GoTo d
            Case 18
                If r = 0 Then GoTo E
                r = 1 / r
                GoTo d
            Case 19
                Select Case Operator_Renamed
                    Case 1
                        If r = 0 Then GoTo E
                        r = r1 / r
                    Case 2
                        r = r1 * r
                    Case 3
                        r = r1 - r
                    Case 4
                        r = r1 + r
                    Case Else
                        Exit Sub
                End Select
                Status = 1
                Operator_Renamed = 0
                GoTo d
            Case 20
                If Strings.Len(kq.Text) > 0 Then kq.Text = Strings.Left(kq.Text, Strings.Len(kq.Text) - 1)
            Case 21
                kq.Text = "0"
                r = 0
            Case 22
                kq.Text = "0"
                Operator_Renamed = 0
                r = 0
                Status = 0
                Operator_Renamed = 0
            Case 23
                m = 0
                Memory()
                Status = 1
            Case 24
                r = m
                Status = 1
                GoTo d
            Case 25
                m = r
                Memory()
                Status = 1
            Case 26
                m += r
                Memory()
                Status = 1
        End Select
        Exit Sub
E:
        kq.Text = "E"
d:
        kq.Text = ConvertToStrSafe(r)
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Memory()
        Label(27).Text = IIf(m <> 0, "M", String.Empty)
    End Sub
End Class
