Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmQTTNDN
    Dim tdau, trang, tcuoi As Integer
    'Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_5.Click, _Command_6.Click, _Command_4.Click, _Command_0.Click, _Command_1.Click, _Command_2.Click
    '    Dim Index As Integer = Array.IndexOf(Command, eventSender)
    '    Select Case Index
    '        Case 0 : SetTrang(trang)
    '        Case 1
    '            ExecSQLNonQuery(String.Format("UPDATE license set ky='{0}',nghe=N'{1}',giahan={2},A1={3},B1={4},B2={5},B3={6},B4={7},B5={8},B6={9},B7={10},B8={11},B9={12},B10={13},B11={14},B12={15},B13={16},B14={17},B15={18},B16={19},B17={20},B18={21},B19={22},B20={23},B21={24},B22={25},B23={26},B24={27},B25={28},B26={29},B27={29},B28={30},B29={31},B30={32},B31={33},C1={34},C2={35},C3={36},C4={37},C5={38},C6={39},C7={40},C8={41},C9={42},C10={43},tyle0={44},tyle1={45},tyle2={46},k1={47},k2={48}, k3 = {49},k4={50}, k5 = {51},k6={52}", _
    '                                KY.Text, _
    '                                Nghe.Text, _
    '                                ConvertToStrSafe(chk(0).CheckState), _
    '                                cstr(ConvertToDblSafe(Txt(0).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(1).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(2).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(3).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(4).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(5).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(6).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(7).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(8).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(9).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(10).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(11).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(12).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(13).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(14).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(15).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(16).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(17).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(18).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(19).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(20).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(21).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(22).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(23).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(24).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(25).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(26).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(28).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(29).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(30).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(31).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(32).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(33).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(34).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(35).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(36).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(37).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(38).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(39).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(40).Text)), _
    '                                cstr(ConvertToDblSafe(Txt(41).Text)), _
    '                                cstr(ConvertToDblSafe(TL(0).Text)), _
    '                                cstr(ConvertToDblSafe(TL(1).Text)), _
    '                                cstr(ConvertToDblSafe(TL(2).Text)), _
    '                                ConvertToStrSafe(chk(1).CheckState), _
    '                                ConvertToStrSafe(chk(2).CheckState), _
    '                                ConvertToStrSafe(chk(3).CheckState), _
    '                                ConvertToStrSafe(chk(4).CheckState), _
    '                                ConvertToStrSafe(chk(5).CheckState), _
    '                                ConvertToStrSafe(chk(6).CheckState)))
    '        Case 2
    '            ExecSQLNonQuery("UPDATE license set ky='',nghe='',giahan=0,A1=0,B1=0,B2=0,B3=0,B4=0,B5=0,B6=0,B7=0,B8=0,B9=0,B10=0,B11=0,B12=0,B13=0,B14=0,B15=0,B16=0,B17=0,B18=0,B19=0,B20=0,B21=0,B22=0,B23=0,B24=0,B25=0,B26=0,B27=0,B28=0,B29=0,B30=0,B31=0,C1=0,C2=0,C3=0,C4=0,C5=0,C6=0,C7=0,C8=0,C9=0,C10=0,tyle0=0,tyle1=0,tyle2=0,k1=0,k2=0, k3 =0,k4=0, k5 =0,k6=0")
    '        Case 4 : XemIn()
    '        Case 5 : Me.Close()
    '        Case 6 : XemIn(1)
    '    End Select
    'End Sub
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_5.Click, _Command_6.Click, _Command_4.Click, _Command_0.Click, _Command_1.Click, _Command_2.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Select Case Index
            Case 0 : SetTrang(trang)
            Case 1
                Dim str As String = String.Format("UPDATE license set ky='{0}',nghe=N'{1}',giahan={2},A1={3},B1={4},B2={5},B3={6},B4={7},B5={8},B6={9},B7={10},B8={11},B9={12},B10={13},B11={14},B12={15},B13={16},B14={17},B15={18},B16={19},B17={20},B18={21},B19={22},B20={23},B21={24},B22={25},B23={26},B24={27},B25={28},B26={29},B27={29},B28={30},B29={31},B30={32},B31={33},C1={34},C2={35},C3={36},C4={37},C5={38},C6={39},C7={40},C8={41},C9={42},C10={43},tyle0={44},tyle1={45},tyle2={46},k1={47},k2={48}, k3 = {49},k4={50}, k5 = {51},k6={52}", _
                                    KY.Text, _
                                    Nghe.Text, _
                                    IIf(chk(0).CheckState = CheckState.Checked, "1", "0"), _
                                    CStr(ConvertToDblSafe(Txt(0).Text)), _
                                    CStr(ConvertToDblSafe(Txt(1).Text)), _
                                    CStr(ConvertToDblSafe(Txt(2).Text)), _
                                    CStr(ConvertToDblSafe(Txt(3).Text)), _
                                    CStr(ConvertToDblSafe(Txt(4).Text)), _
                                    CStr(ConvertToDblSafe(Txt(5).Text)), _
                                    CStr(ConvertToDblSafe(Txt(6).Text)), _
                                    CStr(ConvertToDblSafe(Txt(7).Text)), _
                                    CStr(ConvertToDblSafe(Txt(8).Text)), _
                                    CStr(ConvertToDblSafe(Txt(9).Text)), _
                                    CStr(ConvertToDblSafe(Txt(10).Text)), _
                                    CStr(ConvertToDblSafe(Txt(11).Text)), _
                                    CStr(ConvertToDblSafe(Txt(12).Text)), _
                                    CStr(ConvertToDblSafe(Txt(13).Text)), _
                                    CStr(ConvertToDblSafe(Txt(14).Text)), _
                                    CStr(ConvertToDblSafe(Txt(15).Text)), _
                                    CStr(ConvertToDblSafe(Txt(16).Text)), _
                                    CStr(ConvertToDblSafe(Txt(17).Text)), _
                                    CStr(ConvertToDblSafe(Txt(18).Text)), _
                                    CStr(ConvertToDblSafe(Txt(19).Text)), _
                                    CStr(ConvertToDblSafe(Txt(20).Text)), _
                                    CStr(ConvertToDblSafe(Txt(21).Text)), _
                                    CStr(ConvertToDblSafe(Txt(22).Text)), _
                                    CStr(ConvertToDblSafe(Txt(23).Text)), _
                                    CStr(ConvertToDblSafe(Txt(24).Text)), _
                                    CStr(ConvertToDblSafe(Txt(25).Text)), _
                                    CStr(ConvertToDblSafe(Txt(26).Text)), _
                                    CStr(ConvertToDblSafe(Txt(28).Text)), _
                                    CStr(ConvertToDblSafe(Txt(29).Text)), _
                                    CStr(ConvertToDblSafe(Txt(30).Text)), _
                                    CStr(ConvertToDblSafe(Txt(31).Text)), _
                                    CStr(ConvertToDblSafe(Txt(32).Text)), _
                                    CStr(ConvertToDblSafe(Txt(33).Text)), _
                                    CStr(ConvertToDblSafe(Txt(34).Text)), _
                                    CStr(ConvertToDblSafe(Txt(35).Text)), _
                                    CStr(ConvertToDblSafe(Txt(36).Text)), _
                                    CStr(ConvertToDblSafe(Txt(37).Text)), _
                                    CStr(ConvertToDblSafe(Txt(38).Text)), _
                                    CStr(ConvertToDblSafe(Txt(39).Text)), _
                                    CStr(ConvertToDblSafe(Txt(40).Text)), _
                                    CStr(ConvertToDblSafe(Txt(41).Text)), _
                                    CStr(ConvertToDblSafe(TL(0).Text)), _
                                    CStr(ConvertToDblSafe(TL(1).Text)), _
                                    CStr(ConvertToDblSafe(TL(2).Text)), _
                                    IIf(chk(1).CheckState = CheckState.Checked, "1", "0"), _
                                    IIf(chk(2).CheckState = CheckState.Checked, "1", "0"), _
                                   IIf(chk(3).CheckState = CheckState.Checked, "1", "0"), _
                                    IIf(chk(4).CheckState = CheckState.Checked, "1", "0"), _
                                    IIf(chk(5).CheckState = CheckState.Checked, "1", "0"), _
                                    IIf(chk(6).CheckState = CheckState.Checked, "1", "0"))
                ExecSQLNonQuery(str)
            Case 2
                ExecSQLNonQuery("UPDATE license set ky='',nghe='',giahan=0,A1=0,B1=0,B2=0,B3=0,B4=0,B5=0,B6=0,B7=0,B8=0,B9=0,B10=0,B11=0,B12=0,B13=0,B14=0,B15=0,B16=0,B17=0,B18=0,B19=0,B20=0,B21=0,B22=0,B23=0,B24=0,B25=0,B26=0,B27=0,B28=0,B29=0,B30=0,B31=0,C1=0,C2=0,C3=0,C4=0,C5=0,C6=0,C7=0,C8=0,C9=0,C10=0,tyle0=0,tyle1=0,tyle2=0,k1=0,k2=0, k3 =0,k4=0, k5 =0,k6=0")
            Case 4 : XemIn()
            Case 5 : Me.Close()
            Case 6 : XemIn(1)
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="inra"></param>
    ''' <remarks></remarks>
    Sub XemIn(Optional ByRef inra As Integer = 0)
        rptFrom.InitForm("QTTNDN.RPT", "SELECT * FROM License", "License")

        SetRptInfo()
        rptFrom.SetFormulas("NgayIn", Ngay(0).Text)
        rptFrom.SetFormulas("ThangIN", Ngay(1).Text)
        rptFrom.SetFormulas("NamIn", Ngay(2).Text)

        rptFrom.ReportWindowTitle = "Quyết toán thuế thu nhập danh nghiệp"
        rptFrom.ReportWindowState = System.Windows.Forms.FormWindowState.Maximized
        rptFrom.ReportDestination = 1
        rptFrom.ReportDestination = inra
        Me.Cursor = Cursors.Default
        InBaoCaoRPT()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CTY_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CTY.Enter
        CTY.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmQTTNDN_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.T
                    Command(0).Focus()
                    ' Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.X
                    Command(2).Focus()
                    ' Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.E
                    Command(4).Focus()
                    ' Command_ClickEvent(Command(4), New EventArgs())
                Case Keys.V
                    Command(5).Focus()
                    'Command_ClickEvent(Command(5), New EventArgs())
                Case Keys.I
                    Command(6).Focus()
                    'Command_ClickEvent(Command(6), New EventArgs())
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
    Private Sub FrmQTTNDN_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            Dim rs As DataTable
            CreateTableThueDanhNghiep()
            MST.Text = frmMain._LbCty_8.Text
            CTY.Text = frmMain._LbCty_0.Text
            Ngay(0).Text = ConvertToStrSafe(DateAndTime.Day(DateTime.Now))
            Ngay(1).Text = ConvertToStrSafe(DateTime.Now.Month)
            Ngay(2).Text = ConvertToStrSafe(DateTime.Now.Year)
            If Strings.Len(ConvertToStrSafe(GetSelectValue("SELECT ky as f1 FROM license"))) = 0 Then
Chuaco:
                With FrmMNBaocao
                    tdau = .CboThang(0).SelectedIndex
                    tcuoi = .CboThang(1).SelectedIndex
                    If tdau = tcuoi Then
                        KY.Text = String.Format("Tháng {0} năm {1}", tdau, ConvertToStrSafe(pNamTC))
                    Else
                        KY.Text = String.Format("Từ tháng {0} đến tháng {1} năm {2}", tdau, ConvertToStrSafe(tcuoi), ConvertToStrSafe(pNamTC))
                    End If
                End With
                InKqkd(tdau, tcuoi, 0, 0)
                Txt(0).Text = ConvertToStrSafe(GetSelectValue("SELECT kynay as f1 FROM kqkd  WHERE maso=50"))
                Txt_Leave(Txt(0), New EventArgs())
                TL(0).Text = ConvertToStrSafe(25)
                TL_Leave(TL(0), New EventArgs())
            Else
                rs = ExecSQLReturnDT("SELECT ky,nghe,giahan,tyle0,tyle1,tyle2,A1,B1,B2,B3,B4,B5,B6,B7,B8,B9,B10,B11,B12,B13,B14,B15,B16,B17,B18,B19,B20,B21,B22,B23,B24,B25,B26,B27,B28,B29,B30,B31,C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,K1,K2,K3,K4,K5,K6 FROM license")
                If rs.Rows.Count > 0 Then
                    Dim rsItem As DataRow = rs.Rows(0)
                    If IsDBNull(rsItem("KY")) Then GoTo Chuaco
                    KY.Text = ConvertToStrSafe(rsItem("KY"))
                    Nghe.Text = ConvertToStrSafe(rsItem("Nghe"))
                    chk(0).CheckState = ConvertToBoolSafe(rsItem("giahan"))
                    Txt(0).Text = Format(ConvertToDblSafe(rsItem("A1")), Mask_0)
                    TL(0).Text = Format(ConvertToDblSafe(rsItem("tyle0")), Mask_0)
                    TL(1).Text = Format(ConvertToDblSafe(rsItem("tyle1")), Mask_0)
                    TL(2).Text = Format(ConvertToDblSafe(rsItem("tyle2")), Mask_0)
                    Txt(1).Text = Format(ConvertToDblSafe(rsItem("B1")), Mask_0)
                    Txt(2).Text = Format(ConvertToDblSafe(rsItem("B2")), Mask_0)
                    Txt(3).Text = Format(ConvertToDblSafe(rsItem("B3")), Mask_0)
                    Txt(4).Text = Format(ConvertToDblSafe(rsItem("B4")), Mask_0)
                    Txt(5).Text = Format(ConvertToDblSafe(rsItem("B5")), Mask_0)
                    Txt(6).Text = Format(ConvertToDblSafe(rsItem("B6")), Mask_0)
                    Txt(7).Text = Format(ConvertToDblSafe(rsItem("B7")), Mask_0)
                    Txt(8).Text = Format(ConvertToDblSafe(rsItem("B8")), Mask_0)
                    Txt(9).Text = Format(ConvertToDblSafe(rsItem("B9")), Mask_0)
                    Txt(10).Text = Format(ConvertToDblSafe(rsItem("B10")), Mask_0)
                    Txt(11).Text = Format(ConvertToDblSafe(rsItem("B11")), Mask_0)
                    Txt(12).Text = Format(ConvertToDblSafe(rsItem("B12")), Mask_0)
                    Txt(13).Text = Format(ConvertToDblSafe(rsItem("B13")), Mask_0)
                    Txt(14).Text = Format(ConvertToDblSafe(rsItem("B14")), Mask_0)
                    Txt(15).Text = Format(ConvertToDblSafe(rsItem("B15")), Mask_0)
                    Txt(16).Text = Format(ConvertToDblSafe(rsItem("B16")), Mask_0)
                    Txt(17).Text = Format(ConvertToDblSafe(rsItem("B17")), Mask_0)
                    Txt(18).Text = Format(ConvertToDblSafe(rsItem("B18")), Mask_0)
                    Txt(19).Text = Format(ConvertToDblSafe(rsItem("B19")), Mask_0)
                    Txt(20).Text = Format(ConvertToDblSafe(rsItem("B20")), Mask_0)
                    Txt(21).Text = Format(ConvertToDblSafe(rsItem("B21")), Mask_0)
                    Txt(22).Text = Format(ConvertToDblSafe(rsItem("B22")), Mask_0)
                    Txt(23).Text = Format(ConvertToDblSafe(rsItem("B23")), Mask_0)
                    Txt(24).Text = Format(ConvertToDblSafe(rsItem("B24")), Mask_0)
                    Txt(25).Text = Format(ConvertToDblSafe(rsItem("B25")), Mask_0)
                    Txt(26).Text = Format(ConvertToDblSafe(rsItem("B26")), Mask_0)
                    Txt(27).Text = Format(ConvertToDblSafe(rsItem("B27")), Mask_0)
                    Txt(28).Text = Format(ConvertToDblSafe(rsItem("B28")), Mask_0)
                    Txt(29).Text = Format(ConvertToDblSafe(rsItem("B29")), Mask_0)
                    Txt(30).Text = Format(ConvertToDblSafe(rsItem("B30")), Mask_0)
                    Txt(31).Text = Format(ConvertToDblSafe(rsItem("B31")), Mask_0)
                    Txt(32).Text = Format(ConvertToDblSafe(rsItem("C1")), Mask_0)
                    Txt(33).Text = Format(ConvertToDblSafe(rsItem("c2")), Mask_0)
                    Txt(34).Text = Format(ConvertToDblSafe(rsItem("C3")), Mask_0)
                    Txt(35).Text = Format(ConvertToDblSafe(rsItem("C4")), Mask_0)
                    Txt(36).Text = Format(ConvertToDblSafe(rsItem("C5")), Mask_0)
                    Txt(37).Text = Format(ConvertToDblSafe(rsItem("C6")), Mask_0)
                    Txt(38).Text = Format(ConvertToDblSafe(rsItem("C7")), Mask_0)
                    Txt(39).Text = Format(ConvertToDblSafe(rsItem("C8")), Mask_0)
                    Txt(40).Text = Format(ConvertToDblSafe(rsItem("C9")), Mask_0)
                    Txt(41).Text = Format(ConvertToDblSafe(rsItem("C10")), Mask_0)
                    chk(1).CheckState = ConvertToBoolSafe(rsItem("K1"))
                    chk(2).CheckState = ConvertToBoolSafe(rsItem("k2"))
                    chk(3).CheckState = ConvertToBoolSafe(rsItem("k3"))
                    chk(4).CheckState = ConvertToBoolSafe(rsItem("k4"))
                    chk(5).CheckState = ConvertToBoolSafe(rsItem("k5"))
                    chk(6).CheckState = ConvertToBoolSafe(rsItem("k6"))
                    For i As Integer = 0 To 41
                        If Txt(i).Text = "" Then Txt(i).Text = "0"
                    Next
                    For i As Integer = 0 To 2
                        If TL(i).Text = "" Then TL(i).Text = "0"
                    Next
                Else
                    GoTo Chuaco
                End If
            End If
            SetTrang(2)
            SetFont(Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    Sub SetTrang(ByRef thutu As Integer)
        trang = 3 - thutu
        If trang = 1 Then
            Frame(1).Visible = True
            Frame(2).Visible = False
            If Command(0).Text = "&Trang trước" Then Command(0).Text = "&Trang sau"
            If Command(0).Text = "Prev" Then Command(0).Text = "Next"
        Else
            Frame(1).Visible = False
            Frame(2).Visible = True
            If Command(0).Text = "&Trang sau" Then Command(0).Text = "&Trang trước"
            If Command(0).Text = "Next" Then Command(0).Text = "Prev"
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub KY_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles KY.Enter
        KY.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MST_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MST.Enter
        MST.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Nghe_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Nghe.Enter
        Nghe.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TL_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _TL_2.Enter, _TL_1.Enter, _TL_0.Enter
        Dim Index As Integer = Array.IndexOf(TL, eventSender)
        TL(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub TL_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _TL_2.KeyPress, _TL_1.KeyPress, _TL_0.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(TL, eventSender)
        If KeyAscii <> 27 Then KeyProcess(TL(Index), KeyAscii, True)
        TL(Index).Text = Format(TL(Index).Text, Mask_0)
        If TL(Index).Text = "" Then TL(Index).Text = "0"
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
    Private Sub TL_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _TL_2.Leave, _TL_1.Leave, _TL_0.Leave
        Dim Index As Integer = Array.IndexOf(TL, eventSender)
        If Index = 0 Then
            If ConvertToDblSafe(TL(Index).Text) > 0 And ConvertToDblSafe(TL(Index).Text) < 100 Then
                TL(1).Text = TL(0).Text
                TL(2).Text = TL(0).Text
            End If
            Txt(33).Text = Format(ConvertToDblSafe(Txt(30).Text) * ConvertToDblSafe(TL(0).Text) / 100, Mask_0)
            If Txt(33).Text = "" Then Txt(33).Text = "0"
            Txt_Leave(Txt(33), New EventArgs())
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Txt_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Txt_19.Enter, _Txt_18.Enter, _Txt_17.Enter, _Txt_16.Enter, _Txt_15.Enter, _Txt_14.Enter, _Txt_13.Enter, _Txt_12.Enter, _Txt_11.Enter, _Txt_10.Enter, _Txt_9.Enter, _Txt_8.Enter, _Txt_7.Enter, _Txt_6.Enter, _Txt_5.Enter, _Txt_4.Enter, _Txt_3.Enter, _Txt_2.Enter, _Txt_1.Enter, _Txt_0.Enter, _Txt_20.Enter, _Txt_41.Enter, _Txt_40.Enter, _Txt_39.Enter, _Txt_38.Enter, _Txt_37.Enter, _Txt_36.Enter, _Txt_35.Enter, _Txt_34.Enter, _Txt_33.Enter, _Txt_32.Enter, _Txt_31.Enter, _Txt_30.Enter, _Txt_29.Enter, _Txt_28.Enter, _Txt_27.Enter, _Txt_26.Enter, _Txt_25.Enter, _Txt_24.Enter, _Txt_23.Enter, _Txt_22.Enter, _Txt_21.Enter
        Dim Index As Integer = Array.IndexOf(Txt, eventSender)
        Txt(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Txt_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _Txt_19.KeyPress, _Txt_18.KeyPress, _Txt_17.KeyPress, _Txt_16.KeyPress, _Txt_15.KeyPress, _Txt_14.KeyPress, _Txt_13.KeyPress, _Txt_12.KeyPress, _Txt_11.KeyPress, _Txt_10.KeyPress, _Txt_9.KeyPress, _Txt_8.KeyPress, _Txt_7.KeyPress, _Txt_6.KeyPress, _Txt_5.KeyPress, _Txt_4.KeyPress, _Txt_3.KeyPress, _Txt_2.KeyPress, _Txt_1.KeyPress, _Txt_0.KeyPress, _Txt_20.KeyPress, _Txt_41.KeyPress, _Txt_40.KeyPress, _Txt_39.KeyPress, _Txt_38.KeyPress, _Txt_37.KeyPress, _Txt_36.KeyPress, _Txt_35.KeyPress, _Txt_34.KeyPress, _Txt_33.KeyPress, _Txt_32.KeyPress, _Txt_31.KeyPress, _Txt_30.KeyPress, _Txt_29.KeyPress, _Txt_28.KeyPress, _Txt_27.KeyPress, _Txt_26.KeyPress, _Txt_25.KeyPress, _Txt_24.KeyPress, _Txt_23.KeyPress, _Txt_22.KeyPress, _Txt_21.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        Dim Index As Integer = Array.IndexOf(Txt, eventSender)
        If Index <> 1 And Index <> 17 And Index <> 23 And KeyAscii <> 27 Then KeyProcess(Txt(Index), KeyAscii, True)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        'eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub

    'Private Sub Txt_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Txt_19.Leave, _Txt_18.Leave, _Txt_17.Leave, _Txt_16.Leave, _Txt_15.Leave, _Txt_14.Leave, _Txt_13.Leave, _Txt_12.Leave, _Txt_11.Leave, _Txt_10.Leave, _Txt_9.Leave, _Txt_8.Leave, _Txt_7.Leave, _Txt_6.Leave, _Txt_5.Leave, _Txt_4.Leave, _Txt_3.Leave, _Txt_2.Leave, _Txt_1.Leave, _Txt_0.Leave, _Txt_20.Leave, _Txt_41.Leave, _Txt_40.Leave, _Txt_39.Leave, _Txt_38.Leave, _Txt_37.Leave, _Txt_36.Leave, _Txt_35.Leave, _Txt_34.Leave, _Txt_33.Leave, _Txt_32.Leave, _Txt_31.Leave, _Txt_30.Leave, _Txt_29.Leave, _Txt_28.Leave, _Txt_27.Leave, _Txt_26.Leave, _Txt_25.Leave, _Txt_24.Leave, _Txt_23.Leave, _Txt_22.Leave, _Txt_21.Leave
    '    Dim Index As Integer = Array.IndexOf(Txt, eventSender)
    '    Dim tien As Double
    '    Txt(Index).Text = Format(Txt(Index).Text, Mask_0)
    '    If Txt(Index).Text = "" Then Txt(Index).Text = "0"
    '    If Index >= 2 And Index <= 16 Then
    '        Txt(1).Text = Format(ConvertToDblSafe(Txt(2).Text) + ConvertToDblSafe(Txt(3).Text) + ConvertToDblSafe(Txt(4).Text) + ConvertToDblSafe(Txt(5).Text) + ConvertToDblSafe(Txt(6).Text) + ConvertToDblSafe(Txt(7).Text) + ConvertToDblSafe(Txt(8).Text) + ConvertToDblSafe(Txt(9).Text) + ConvertToDblSafe(Txt(10).Text) + ConvertToDblSafe(Txt(11).Text) + ConvertToDblSafe(Txt(12).Text) + ConvertToDblSafe(Txt(13).Text) + ConvertToDblSafe(Txt(14).Text) + ConvertToDblSafe(Txt(15).Text) + ConvertToDblSafe(Txt(16).Text), Mask_0)
    '        If Txt(1).Text = "" Then Txt(1).Text = "0"
    '        Txt_Leave(Txt(1), New EventArgs())
    '    End If
    '    If Index >= 18 And Index <= 22 Then
    '        Txt(17).Text = Format(ConvertToDblSafe(Txt(18).Text) + ConvertToDblSafe(Txt(19).Text) + ConvertToDblSafe(Txt(20).Text) + ConvertToDblSafe(Txt(21).Text) + ConvertToDblSafe(Txt(22).Text), Mask_0)
    '        If Txt(17).Text = "" Then Txt(17).Text = "0"
    '        Txt_Leave(Txt(17), New EventArgs())
    '    End If
    '    If Index = 0 Or Index = 1 Or Index = 17 Then
    '        Txt(23).Text = Format(ConvertToDblSafe(Txt(0).Text) + ConvertToDblSafe(Txt(1).Text) - ConvertToDblSafe(Txt(17).Text), Mask_0)
    '        If Txt(23).Text = "" Then Txt(23).Text = "0"
    '        Txt_Leave(Txt(23), New EventArgs())
    '    End If
    '    If Index = 23 Or Index = 25 Then
    '        Txt(24).Text = Format(ConvertToDblSafe(Txt(23).Text) - ConvertToDblSafe(Txt(25).Text), Mask_0)
    '        If Txt(24).Text = "" Then Txt(24).Text = "0"
    '        Txt_Leave(Txt(24), New EventArgs())
    '    End If
    '    If Index = 27 Or Index = 28 Then
    '        Txt(26).Text = Format(ConvertToDblSafe(Txt(27).Text) - ConvertToDblSafe(Txt(28).Text), Mask_0)
    '        If Txt(26).Text = "" Then Txt(26).Text = "0"
    '        Txt_Leave(Txt(26), New EventArgs())
    '    End If
    '    If Index = 24 Then
    '        tien = ConvertToDblSafe(GetSelectValue("SELECT duno_0 as f1 FROM hethongtk WHERE sohieu='4211'"))
    '        If ConvertToDblSafe(Txt(24).Text) < tien Then
    '            Txt(27).Text = Format(Txt(24).Text, Mask_0)
    '        Else
    '            Txt(27).Text = Format(tien, Mask_0)
    '        End If
    '        If Txt(27).Text = "" Then Txt(27).Text = "0"
    '        Txt_Leave(Txt(27), New EventArgs())
    '    End If
    '    If Index = 30 Or Index = 31 Then
    '        Txt(29).Text = Format(ConvertToDblSafe(Txt(30).Text) + ConvertToDblSafe(Txt(31).Text), Mask_0)
    '        If Txt(29).Text = "" Then Txt(29).Text = "0"
    '        Txt_Leave(Txt(29), New EventArgs())
    '        If Index = 30 Then
    '            Txt(33).Text = Format(ConvertToDblSafe(Txt(30).Text) * ConvertToDblSafe(TL(0).Text) / 100, Mask_0)
    '            If Txt(33).Text = "" Then Txt(33).Text = "0"
    '            Txt_Leave(Txt(33), New EventArgs())
    '        ElseIf Index = 31 Then
    '            Txt(37).Text = Format(ConvertToDblSafe(Txt(31).Text) * ConvertToDblSafe(TL(2).Text) / 100, Mask_0)
    '            If Txt(37).Text = "" Then Txt(37).Text = "0"
    '            Txt_Leave(Txt(37), New EventArgs())
    '        End If
    '    End If
    '    If Index = 24 Or Index = 27 Then
    '        Txt(30).Text = Format(ConvertToDblSafe(Txt(24).Text) - ConvertToDblSafe(Txt(27).Text), Mask_0)
    '        If Txt(30).Text = "" Then Txt(30).Text = "0"
    '        Txt_Leave(Txt(30), New EventArgs())
    '    End If
    '    If Index = 25 Or Index = 28 Then
    '        Txt(31).Text = Format(ConvertToDblSafe(Txt(25).Text) - ConvertToDblSafe(Txt(28).Text), Mask_0)
    '        If Txt(31).Text = "" Then Txt(31).Text = "0"
    '        Txt_Leave(Txt(31), New EventArgs())
    '    End If
    '    If Index >= 33 And Index <= 36 Then
    '        Txt(32).Text = Format(ConvertToDblSafe(Txt(33).Text) - ConvertToDblSafe(Txt(34).Text) - ConvertToDblSafe(Txt(35).Text) - ConvertToDblSafe(Txt(36).Text), Mask_0)
    '        If Txt(32).Text = "" Then Txt(32).Text = "0"
    '        Txt_Leave(Txt(32), New EventArgs())
    '    End If
    '    If Index >= 38 And Index <= 40 Then
    '        Txt(37).Text = Format(ConvertToDblSafe(Txt(38).Text) + ConvertToDblSafe(Txt(39).Text) - ConvertToDblSafe(Txt(40).Text), Mask_0)
    '        If Txt(37).Text = "" Then Txt(37).Text = "0"
    '        Txt_Leave(Txt(37), New EventArgs())
    '    End If
    '    If Index = 32 Or Index = 37 Then
    '        Txt(41).Text = Format(ConvertToDblSafe(Txt(32).Text) + ConvertToDblSafe(Txt(37).Text), Mask_0)
    '        If Txt(41).Text = "" Then Txt(41).Text = "0"
    '        Txt_Leave(Txt(41), New EventArgs())
    '    End If
    'End Sub
    Private Sub Txt_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Txt_19.Leave, _Txt_18.Leave, _Txt_17.Leave, _Txt_16.Leave, _Txt_15.Leave, _Txt_14.Leave, _Txt_13.Leave, _Txt_12.Leave, _Txt_11.Leave, _Txt_10.Leave, _Txt_9.Leave, _Txt_8.Leave, _Txt_7.Leave, _Txt_6.Leave, _Txt_5.Leave, _Txt_4.Leave, _Txt_3.Leave, _Txt_2.Leave, _Txt_1.Leave, _Txt_0.Leave, _Txt_20.Leave, _Txt_41.Leave, _Txt_40.Leave, _Txt_39.Leave, _Txt_38.Leave, _Txt_37.Leave, _Txt_36.Leave, _Txt_35.Leave, _Txt_34.Leave, _Txt_33.Leave, _Txt_32.Leave, _Txt_31.Leave, _Txt_30.Leave, _Txt_29.Leave, _Txt_28.Leave, _Txt_27.Leave, _Txt_26.Leave, _Txt_25.Leave, _Txt_24.Leave, _Txt_23.Leave, _Txt_22.Leave, _Txt_21.Leave
        Dim Index As Integer = Array.IndexOf(Txt, eventSender)
        Dim tien As Double
        Txt(Index).Text = Format(Txt(Index).Text, Mask_0)
        If Txt(Index).Text = "" Then Txt(Index).Text = "0"
        If Index >= 2 And Index <= 16 Then
            Txt(1).Text = Format(ConvertToDblSafe(Txt(2).Text) + ConvertToDblSafe(Txt(3).Text) + ConvertToDblSafe(Txt(4).Text) + ConvertToDblSafe(Txt(5).Text) + ConvertToDblSafe(Txt(6).Text) + ConvertToDblSafe(Txt(7).Text) + ConvertToDblSafe(Txt(8).Text) + ConvertToDblSafe(Txt(9).Text) + ConvertToDblSafe(Txt(10).Text) + ConvertToDblSafe(Txt(11).Text) + ConvertToDblSafe(Txt(12).Text) + ConvertToDblSafe(Txt(13).Text) + ConvertToDblSafe(Txt(14).Text) + ConvertToDblSafe(Txt(15).Text) + ConvertToDblSafe(Txt(16).Text), Mask_0)
            If Txt(1).Text = "" Then Txt(1).Text = "0"
            Txt_Leave(Txt(1), New EventArgs())
        End If
        If Index >= 18 And Index <= 22 Then
            Txt(17).Text = Format(ConvertToDblSafe(Txt(18).Text) + ConvertToDblSafe(Txt(19).Text) + ConvertToDblSafe(Txt(20).Text) + ConvertToDblSafe(Txt(21).Text) + ConvertToDblSafe(Txt(22).Text), Mask_0)
            If Txt(17).Text = "" Then Txt(17).Text = "0"
            Txt_Leave(Txt(17), New EventArgs())
        End If
        If Index = 0 Or Index = 1 Or Index = 17 Then
            Txt(23).Text = Format(ConvertToDblSafe(Txt(0).Text) + ConvertToDblSafe(Txt(1).Text) - ConvertToDblSafe(Txt(17).Text), Mask_0)
            If Txt(23).Text = "" Then Txt(23).Text = "0"
            Txt_Leave(Txt(23), New EventArgs())
        End If
        If Index = 23 Or Index = 25 Then
            Txt(24).Text = Format(ConvertToDblSafe(Txt(23).Text) - ConvertToDblSafe(Txt(25).Text), Mask_0)
            If Txt(24).Text = "" Then Txt(24).Text = "0"
            Txt_Leave(Txt(24), New EventArgs())
        End If
        If Index = 27 Or Index = 28 Then
            Txt(26).Text = Format(ConvertToDblSafe(Txt(27).Text) - ConvertToDblSafe(Txt(28).Text), Mask_0)
            If Txt(26).Text = "" Then Txt(26).Text = "0"
            Txt_Leave(Txt(26), New EventArgs())
        End If
        If Index = 24 Then
            tien = ConvertToDblSafe(GetSelectValue("SELECT duno_0 as f1 FROM hethongtk WHERE sohieu='4211'"))
            If ConvertToDblSafe(Txt(24).Text) < tien Then
                Txt(27).Text = Format(Txt(24).Text, Mask_0)
            Else
                Txt(27).Text = Format(tien, Mask_0)
            End If
            If Txt(27).Text = "" Then Txt(27).Text = "0"
            Txt_Leave(Txt(27), New EventArgs())
        End If
        If Index = 30 Or Index = 31 Then
            Txt(29).Text = Format(ConvertToDblSafe(Txt(30).Text) + ConvertToDblSafe(Txt(31).Text), Mask_0)
            If Txt(29).Text = "" Then Txt(29).Text = "0"
            Txt_Leave(Txt(29), New EventArgs())
            If Index = 30 Then
                Txt(33).Text = Format(ConvertToDblSafe(Txt(30).Text) * ConvertToDblSafe(TL(0).Text) / 100, Mask_0)
                If Txt(33).Text = "" Then Txt(33).Text = "0"
                Txt_Leave(Txt(33), New EventArgs())
            ElseIf Index = 31 Then
                Txt(37).Text = Format(ConvertToDblSafe(Txt(31).Text) * ConvertToDblSafe(TL(2).Text) / 100, Mask_0)
                If Txt(37).Text = "" Then Txt(37).Text = "0"
                Txt_Leave(Txt(37), New EventArgs())
            End If
        End If
        If Index = 24 Or Index = 27 Then
            Txt(30).Text = Format(ConvertToDblSafe(Txt(24).Text) - ConvertToDblSafe(Txt(27).Text), Mask_0)
            If Txt(30).Text = "" Then Txt(30).Text = "0"
            Txt_Leave(Txt(30), New EventArgs())
        End If
        If Index = 25 Or Index = 28 Then
            Txt(31).Text = Format(ConvertToDblSafe(Txt(25).Text) - ConvertToDblSafe(Txt(28).Text), Mask_0)
            If Txt(31).Text = "" Then Txt(31).Text = "0"
            Txt_Leave(Txt(31), New EventArgs())
        End If
        If Index >= 33 And Index <= 36 Then
            Txt(32).Text = Format(ConvertToDblSafe(Txt(33).Text) - ConvertToDblSafe(Txt(34).Text) - ConvertToDblSafe(Txt(35).Text) - ConvertToDblSafe(Txt(36).Text), Mask_0)
            If Txt(32).Text = "" Then Txt(32).Text = "0"
            Txt_Leave(Txt(32), New EventArgs())
        End If
        If Index >= 38 And Index <= 40 Then
            Txt(37).Text = Format(ConvertToDblSafe(Txt(38).Text) + ConvertToDblSafe(Txt(39).Text) - ConvertToDblSafe(Txt(40).Text), Mask_0)
            If Txt(37).Text = "" Then Txt(37).Text = "0"
            Txt_Leave(Txt(37), New EventArgs())
        End If
        If Index = 32 Or Index = 37 Then
            Txt(41).Text = Format(ConvertToDblSafe(Txt(32).Text) + ConvertToDblSafe(Txt(37).Text), Mask_0)
            If Txt(41).Text = "" Then Txt(41).Text = "0"
            Txt_Leave(Txt(41), New EventArgs())
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmQTTNDN_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
