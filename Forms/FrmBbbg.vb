Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmBbbg
    Dim tongthue As Double
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Chungtu_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Chungtu_10.Enter, _Chungtu_9.Enter, _Chungtu_8.Enter, _Chungtu_7.Enter, _Chungtu_6.Enter, _Chungtu_5.Enter, _Chungtu_4.Enter, _Chungtu_3.Enter, _Chungtu_2.Enter, _Chungtu_1.Enter, _Chungtu_14.Enter, _Chungtu_13.Enter, _Chungtu_12.Enter, _Chungtu_11.Enter
        Dim Index As Integer = Array.IndexOf(Chungtu, eventSender)
        Chungtu(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim dong As Integer
        Dim sql As String = String.Empty
        Select Case Index
            Case 0
                tongthue = ConvertToDblSafe(Tienthue(1).Text) + ConvertToDblSafe(Tienthue(2).Text) + ConvertToDblSafe(Tienthue(3).Text) + ConvertToDblSafe(Tienthue(4).Text)
                dong = GetRowNumber("bienbanbangiao")
                If dong = 0 Then
                    'Thêm
                    sql = String.Format("INSERT into bienbanbangiao(sosach1,sosach2,sosach3,sosach4,sosach5,sosach6,sosach7,thue1,thue2,thue3,thue4,thue5,chungtu1,chungtu2,chungtu3,chungtu4,chungtu5,chungtu6,chungtu7,nguoigiao,nguoinhan,nganhang,ghichu,ghichu1,ghichu2,thang,quy,nam,thang1) values(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}', N'{10}', N'{11}', N'{12}', N'{13}', N'{14}', N'{15}', N'{16}', N'{17}', N'{18}', N'{19}', N'{20}', N'{21}', N'{22}', N'{23}', N'{24}', N'{25}', N'{26}', N'{27}', N'{28}')", _
                              Sosach(1).Text, _
                              Sosach(2).Text, _
                              Sosach(3).Text, _
                              Sosach(4).Text, _
                              Sosach(5).Text, _
                              Sosach(6).Text, _
                              Sosach(7).Text, _
                              Tienthue(1).Text, _
                              Tienthue(2).Text, _
                              Tienthue(3).Text, _
                              Tienthue(4).Text, _
                              Format(tongthue, Mask_0), _
                              Chungtu(1).Text, _
                              Chungtu(2).Text, _
                              Chungtu(3).Text, _
                              Chungtu(4).Text, _
                              Chungtu(5).Text, _
                              Chungtu(6).Text, _
                              Chungtu(7).Text, _
                              Nguoigiao.Text, _
                              Nguoinhan.Text, _
                              Sosach(8).Text, _
                              Chungtu(8).Text, _
                              Chungtu(9).Text, _
                              Chungtu(10).Text, _
                              Chungtu(11).Text, _
                              Chungtu(12).Text, _
                              Chungtu(13).Text, _
                              Chungtu(14).Text)
                    ExecSQLNonQuery(sql)
                Else
                    'Sưa
                    sql = String.Format("UPDATE bienbanbangiao set thue5=N'{0}',ghichu2=N'{1}',ghichu1=N'{2}',ghichu=N'{3}',nganhang=N'{4}',sosach1=N'{5}',sosach2=N'{6}',sosach3=N'{7}',sosach4=N'{8}',sosach5=N'{9}',sosach6=N'{10}',sosach7=N'{11}',thue1=N'{12}',thue2=N'{13}',thue3=N'{14}',thue4=N'{15}',chungtu1=N'{16}',chungtu2=N'{17}',chungtu3=N'{18}',chungtu4=N'{19}',chungtu5=N'{20}',chungtu6=N'{21}',chungtu7=N'{22}',nguoigiao=N'{23}',nguoinhan=N'{24}',thang=N'{25}',quy=N'{26}',nam=N'{27}',thang1=N'{28}'", _
                              Format(tongthue, Mask_0), _
                              Chungtu(10).Text, _
                              Chungtu(9).Text, _
                              Chungtu(8).Text, _
                              Sosach(8).Text, _
                              Sosach(1).Text, _
                              Sosach(2).Text, _
                              Sosach(3).Text, _
                              Sosach(4).Text, _
                              Sosach(5).Text, _
                              Sosach(6).Text, _
                              Sosach(7).Text, _
                              Tienthue(1).Text, _
                              Tienthue(2).Text, _
                              Tienthue(3).Text, _
                              Tienthue(4).Text, _
                              Chungtu(1).Text, _
                              Chungtu(2).Text, _
                              Chungtu(3).Text, _
                              Chungtu(4).Text, _
                              Chungtu(5).Text, _
                              Chungtu(6).Text, _
                              Chungtu(7).Text, _
                              Nguoigiao.Text, _
                              Nguoinhan.Text, _
                              Chungtu(11).Text, _
                              Chungtu(12).Text, _
                              Chungtu(13).Text, _
                              Chungtu(14).Text)
                    ExecSQLNonQuery(sql)
                End If
            Case 1
                'Xem
                InBbbg()
            Case 2
                'In
                InBbbg(1)
            Case 3
                'Trở về
                Me.Hide()
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ShowChitiet()
        Dim rs As DataTable = ExecSQLReturnDT("SELECT * FROM bienbanbangiao")
        If rs.Rows.Count > 0 Then
            Dim rsItem As DataRow = rs.Rows(0)
            Sosach(1).Text = ConvertToStrSafe(rsItem("sosach1"))
            Sosach(2).Text = ConvertToStrSafe(rsItem("sosach2"))
            Sosach(3).Text = ConvertToStrSafe(rsItem("sosach3"))
            Sosach(4).Text = ConvertToStrSafe(rsItem("sosach4"))
            Sosach(5).Text = ConvertToStrSafe(rsItem("sosach5"))
            Sosach(6).Text = ConvertToStrSafe(rsItem("sosach6"))
            Sosach(7).Text = ConvertToStrSafe(rsItem("sosach7"))
            Sosach(8).Text = ConvertToStrSafe(rsItem("nganhang"))
            Tienthue(1).Text = Format(ConvertToDblSafe(rsItem("thue1")), Mask_0)
            Tienthue(2).Text = Format(ConvertToDblSafe(rsItem("thue2")), Mask_0)
            Tienthue(3).Text = Format(ConvertToDblSafe(rsItem("thue3")), Mask_0)
            Tienthue(4).Text = Format(ConvertToDblSafe(rsItem("thue4")), Mask_0)
            Chungtu(1).Text = ConvertToStrSafe(rsItem("chungtu1"))
            Chungtu(2).Text = ConvertToStrSafe(rsItem("chungtu2"))
            Chungtu(3).Text = ConvertToStrSafe(rsItem("chungtu3"))
            Chungtu(4).Text = ConvertToStrSafe(rsItem("chungtu4"))
            Chungtu(5).Text = ConvertToStrSafe(rsItem("chungtu5"))
            Chungtu(6).Text = ConvertToStrSafe(rsItem("chungtu6"))
            Chungtu(7).Text = ConvertToStrSafe(rsItem("chungtu7"))
            Chungtu(8).Text = ConvertToStrSafe(rsItem("GhiChu"))
            Chungtu(9).Text = ConvertToStrSafe(rsItem("Ghichu1"))
            Chungtu(10).Text = ConvertToStrSafe(rsItem("Ghichu2"))
            Chungtu(11).Text = ConvertToStrSafe(rsItem("thang"))
            Chungtu(12).Text = ConvertToStrSafe(rsItem("quy"))
            Chungtu(13).Text = ConvertToStrSafe(rsItem("Nam"))
            Chungtu(14).Text = ConvertToStrSafe(rsItem("thang1"))
            Nguoigiao.Text = ConvertToStrSafe(rsItem("Nguoigiao"))
            Nguoinhan.Text = ConvertToStrSafe(rsItem("Nguoinhan"))
        End If
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        ShowChitiet()
        Khoaquyen()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="co"></param>
    ''' <remarks></remarks>
    Private Sub InBbbg(Optional ByRef co As Integer = 0)
        rptFrom = rptFrom.copyReportObject(rptFrom)
        With rptFrom
            .InitForm("bbbg.RPT", "SELECT * FROM BienBanBanGiao", "BienBanBanGiao")
            .ReportDestination = co
            .SetFormulas("TenCty", String.Format("'{0}'", pTenCty))
            .SetFormulas("MST", String.Format("'{0}'", frmMain._LbCty_8.Text))
            .SetFormulas("Nam", String.Format("'{0}'", pNamTC))
            .SetFormulas("DiaChi", String.Format("'Địa chỉ: : {0}'", frmMain._LbCty_2.Text))
            .SetFormulas("Thang", String.Format("'{0}'", CboThang.SelectedValue))

            .ReportWindowTitle = "Biên bản bàn giao"
            .ReportWindowState = System.Windows.Forms.FormWindowState.Maximized

            Dim reportMessage As String = .DoReport()
            If String.IsNullOrEmpty(reportMessage) Then

            End If
        End With
        If Not RptOK(rptFrom.ReportFilename, 0) Then
            MessageBox.Show(Ngonngu("Mẫu báo cáo đã bị thay đổi!", "Change report form"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
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
    Private Sub FrmBbbg_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.G
                    Command(0).Focus()
                    ' Command_ClickEvent(Command(0), New EventArgs())
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
    Private Sub FrmBbbg_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            AddMonthToCbo(CboThang)
            If CboThang.Items.Count > 0 Then
                CboThang.SelectedIndex = Today.Month - 1
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
    Private Sub Nguoigiao_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Nguoigiao.Enter
        Nguoigiao.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Nguoinhan_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Nguoinhan.Enter
        Nguoinhan.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Sosach_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Sosach_7.Enter, _Sosach_6.Enter, _Sosach_5.Enter, _Sosach_8.Enter, _Sosach_4.Enter, _Sosach_3.Enter, _Sosach_2.Enter, _Sosach_1.Enter
        Dim Index As Integer = Array.IndexOf(Sosach, eventSender)
        Sosach(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Tienthue_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Tienthue_4.Enter, _Tienthue_3.Enter, _Tienthue_2.Enter, _Tienthue_1.Enter
        Dim Index As Integer = Array.IndexOf(Tienthue, eventSender)
        Tienthue(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Tienthue_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Tienthue_4.Leave, _Tienthue_3.Leave, _Tienthue_2.Leave, _Tienthue_1.Leave
        Dim Index As Integer = Array.IndexOf(Tienthue, eventSender)
        Tienthue(Index).Text = Format(ConvertToDblSafe(Tienthue(Index).Text), Mask_0)
    End Sub
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(0).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        If User_Right <> 0 Then
            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT Lock{0} % 10 AS F1 FROM License", CboThang.SelectedValue))) > 0 Then
                Command(0).Enabled = False
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmBbbg_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
