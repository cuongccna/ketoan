Imports UNET.Utility


Partial Friend Class FrmPhuluc
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmPhuluc_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            txtVT(0).Text = frmMain._LbCty_7.Text
            txtVT(1).Text = String.Format("{0}.", frmMain._LbCty_0.Text)
            txtVT(2).Text = String.Format("{0}.", frmMain._LbCty_8.Text)
            txtVT(6).Text = ConvertToStrSafe(DateAndTime.Day(DateTime.Today))
            txtVT(7).Text = ConvertToStrSafe(DateTime.Today.Month)
            txtVT(8).Text = ConvertToStrSafe(DateTime.Today.Year)
            MedNgay.Text = Format(DateSerial(IIf(DateTime.Today.Month + 9 <= 12, DateTime.Today.Year, DateTime.Today.Year + 1), IIf(DateTime.Today.Month + 9 <= 12, DateTime.Today.Month + 9, DateTime.Today.Month + 9 - 12), DateAndTime.Day(DateTime.Today)), Mask_DB)
            If cboQuy.Items.Count > 0 Then cboQuy.SelectedIndex = 0
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
    Private Sub FrmPhuluc_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.X
                    Command(1).Focus()
                    ' Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.I
                    Command(2).Focus()
                    ' Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.V
                    Command(3).Focus()
                    ' Command_ClickEvent(Command(3), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_3.Click, _Command_2.Click, _Command_1.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim sql As String = String.Empty
        Select Case Index
            Case 1
                'Xem
                InPhuluc()
            Case 2
                'In
                InPhuluc(1)
            Case 3
                'Trở về
                Me.Close()
        End Select
    End Sub
    Sub InPhuluc(Optional ByRef co As Integer = 0)
        rptFrom.InitForm("Phuluc.RPT", "SELECT * FROM License", "License")

        rptFrom.ReportDestination = co
        rptFrom.SetFormulas("1", String.Format("'{0}'", cboQuy.Text))
        rptFrom.SetFormulas("2", String.Format("'{0}'", txtVT(0).Text))
        rptFrom.SetFormulas("3", String.Format("'{0}'", txtVT(1).Text))
        rptFrom.SetFormulas("4", String.Format("'{0}'", txtVT(2).Text))
        rptFrom.SetFormulas("5", String.Format("'{0}'", txtVT(3).Text))
        rptFrom.SetFormulas("6", String.Format("'{0}'", txtVT(4).Text))
        rptFrom.SetFormulas("7", String.Format("'{0}'", MedNgay.Text))
        rptFrom.SetFormulas("8", String.Format("'{0}'", txtVT(6).Text))
        rptFrom.SetFormulas("9", String.Format("'{0}'", txtVT(7).Text))
        rptFrom.SetFormulas("10", String.Format("'{0}'", txtVT(8).Text))
        rptFrom.SetFormulas("11", String.Format("'{0}'", txtVT(9).Text))
        'For i As Integer = 11 To 200
        '    rptFrom.SetFormulas(ConvertToDblSafe(i), String.Empty)
        'Next
        'frmMain.rpt.set_DataFiles(0, pDataPath)
        'frmMain.rpt.Connect = "DSN=;PWD=" & pPSW & ";UID=;DSQ="

        rptFrom.ReportWindowTitle = Ngonngu("Biên bản bàn giao", "Delivery records")
        rptFrom.ReportWindowState = System.Windows.Forms.FormWindowState.Maximized
        If Not RptOK(rptFrom.ReportFilename, 0) Then
            MessageBox.Show(Ngonngu("Mẫu báo cáo đã bị thay đổi!", "Change report form!"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            '    On Error GoTo Bad
            'frmMain.rpt.Action = 1
            Exit Sub
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MedNgay.Enter
        MedNgay.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtVT_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtVT_5.Enter, _txtVT_9.Enter, _txtVT_6.Enter, _txtVT_7.Enter, _txtVT_8.Enter, _txtVT_2.Enter, _txtVT_1.Enter, _txtVT_4.Enter, _txtVT_3.Enter, _txtVT_0.Enter
        Dim Index As Integer = Array.IndexOf(txtVT, eventSender)
        txtVT(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtVT_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _txtVT_5.KeyPress, _txtVT_9.KeyPress, _txtVT_6.KeyPress, _txtVT_7.KeyPress, _txtVT_8.KeyPress, _txtVT_2.KeyPress, _txtVT_1.KeyPress, _txtVT_4.KeyPress, _txtVT_3.KeyPress, _txtVT_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(txtVT, eventSender)
        Select Case Index
            Case 3, 4, 5
                If KeyAscii = ConvertToDblSafe(Keys.Return) Then txtVT(Index).Text = Format(FrmCalc.Calc(), Mask_0)
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
    Private Sub txtVT_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtVT_5.Leave, _txtVT_9.Leave, _txtVT_6.Leave, _txtVT_7.Leave, _txtVT_8.Leave, _txtVT_2.Leave, _txtVT_1.Leave, _txtVT_4.Leave, _txtVT_3.Leave, _txtVT_0.Leave
        Dim Index As Integer = Array.IndexOf(txtVT, eventSender)
        If Index = 5 Then
            txtVT(Index).Text = Format(txtVT(Index).Text, Mask_0)
            txtVT(3).Text = Format(ConvertToDblSafe(txtVT(Index).Text) * 0.3, Mask_0)
            txtVT(4).Text = ConvertToStrSafe(ConvertToDblSafe(txtVT(Index).Text) - ConvertToDblSafe(txtVT(3).Text))
        End If
        If Index = 6 Or Index = 7 Or Index = 8 Then MedNgay.Text = Format(DateSerial(IIf(ConvertToDblSafe(txtVT(7).Text) + 9 <= 12, ConvertToDblSafe(txtVT(8).Text), ConvertToDblSafe(txtVT(8).Text) + 1), IIf(ConvertToDblSafe(txtVT(7).Text) + 9 <= 12, ConvertToDblSafe(txtVT(7).Text) + 9, ConvertToDblSafe(txtVT(7).Text) + 9 - 12), ConvertToDblSafe(txtVT(6).Text)), Mask_DB)
        If Index = 3 Or Index = 4 Then txtVT(Index).Text = Format(txtVT(Index).Text, Mask_0)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmPhuluc_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
