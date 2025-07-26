Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmXulykiemtra
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Select Case Index
            Case 0
                ExecSQLNonQuery(String.Format("UPDATE license set bgthang='{0}',bgnam='{1}',bgxuly='{2}',bgnoidung1='{3}',bglydo1='{4}',bgthoigian1='{5}',bgkiemtra='{6}',bgnoidung2='{7}',bglydo2='{8}',bgthoigian2='{9}',bgnguoigiao='{10}',bgnguoinhan='{11}'", _
                                    Txt(0).Text, _
                                    CboNam.Text, _
                                    Txt(2).Text, _
                                    Txt(3).Text, _
                                    Txt(4).Text, _
                                    Txt(5).Text, _
                                    Txt(6).Text, _
                                    Txt(7).Text, _
                                    Txt(8).Text, _
                                    Txt(9).Text, _
                                    Txt(10).Text, _
                                    Txt(11).Text))
            Case 1
                Xem()
            Case 2
                Xem(1)
            Case 3
                Me.Close()
        End Select
    End Sub

    Sub Xem(Optional ByRef co As Integer = 0)
        Dim LoiIn As Boolean = False

        rptFrom.InitForm("BBBG1.RPT", "SELECT * FROM BienBanBanGiao", "BienBanBanGiao")

        SetRptInfo()
        rptFrom.SetFormulas("thang", String.Format("'{0}'", Txt(0).Text))
        rptFrom.SetFormulas("Nam", String.Format("'{0}'", CboNam.Text))
        rptFrom.SetFormulas("xuly", String.Format("'{0}'", Txt(2).Text))
        rptFrom.SetFormulas("noidung1", String.Format("'{0}'", Txt(3).Text))
        rptFrom.SetFormulas("lydo1", String.Format("'{0}'", Txt(4).Text))
        rptFrom.SetFormulas("thoigian1", String.Format("'{0}'", Txt(5).Text))
        rptFrom.SetFormulas("kiemtra", String.Format("'{0}'", Txt(6).Text))
        rptFrom.SetFormulas("noidung2", String.Format("'{0}'", Txt(7).Text))
        rptFrom.SetFormulas("lydo2", String.Format("'{0}'", Txt(8).Text))
        rptFrom.SetFormulas("thoigian2", String.Format("'{0}'", Txt(9).Text))
        rptFrom.SetFormulas("nguoigiao", String.Format("'{0}'", Txt(10).Text))
        rptFrom.SetFormulas("nguoinhan", String.Format("'{0}'", Txt(11).Text))

        rptFrom.ReportTitle = "Biên bản bàn giao công việc"
        rptFrom.ReportDestination = co
        If Not RptOK(rptFrom.ReportFilename, 0) Then Exit Sub
        Try
            LoiIn = True
            rptFrom.ReportWindowState = System.Windows.Forms.FormWindowState.Maximized

            InBaoCaoRPT()
            'frmMain.rpt.Action = 1
            LoiIn = False

        Catch excep As System.Exception
            If Not LoiIn Then
                Throw excep
            End If
            If LoiIn Then
                If Information.Err().Number = 20515 Then
                    MessageBox.Show(Ngonngu("Vui lòng không 'Enter' khi nhập nội dung, lý do, thoi gian, ...", "Please not press 'Enter' while enter content, reasons, time"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(String.Format("Error {0}: {1}", Information.Err().Number, excep.Message), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End Try
    End Sub

    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        Khoaquyen()
    End Sub

    Private Sub FrmXulykiemtra_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            For i As Integer = pNamTC - 1 To pNamTC + 1
                CboNam.Items.Add(ConvertToStrSafe(i))
            Next
            If CboNam.Items.Count > 0 Then CboNam.SelectedIndex = 1
            Dim rs As DataTable = ExecSQLReturnDT("SELECT bgthang,bgnam,bgxuly,bgnoidung1,bglydo1,bgthoigian1,bgkiemtra,bgnoidung2,bglydo2,bgthoigian2,bgnguoigiao,bgnguoinhan FROM license")
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                If ConvertToStrSafe(rsItem("bgthang")) <> "" Then
                    Txt(0).Text = rsItem("bgthang")
                    While CboNam.Text <> rsItem("bgnam") And CboNam.SelectedIndex < CboNam.Items.Count - 1
                        CboNam.SelectedIndex += 1
                    End While
                    Txt(2).Text = rsItem("bgxuly")
                    Txt(3).Text = rsItem("bgnoidung1")
                    Txt(4).Text = rsItem("bglydo1")
                    Txt(5).Text = rsItem("bgthoigian1")
                    Txt(6).Text = rsItem("bgkiemtra")
                    Txt(7).Text = rsItem("bgnoidung2")
                    Txt(8).Text = rsItem("bglydo2")
                    Txt(9).Text = rsItem("bgthoigian2")
                    Txt(10).Text = rsItem("bgnguoigiao")
                    Txt(11).Text = rsItem("bgnguoinhan")
                End If
            End If
            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub FrmXulykiemtra_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.X
                    Command(1).Focus()
                    ' Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.I
                    Command(2).Focus()
                    'Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.V
                    Command(3).Focus()
                    ' Command_ClickEvent(Command(3), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(0).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
    End Sub

    Private Sub Txt_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Txt_10.Enter, _Txt_11.Enter, _Txt_0.Enter, _Txt_6.Enter, _Txt_2.Enter, _Txt_9.Enter, _Txt_8.Enter, _Txt_7.Enter, _Txt_5.Enter, _Txt_4.Enter, _Txt_3.Enter
        Dim Index As Integer = Array.IndexOf(Txt, eventSender)
        Txt(Index).SelectAll()
    End Sub
    Private Sub FrmXulykiemtra_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
