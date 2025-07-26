Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class FrmDsTC
    Dim MaCTChon As Integer
    Dim Lietke As Boolean
    Dim Row As Integer
    Dim ord As Integer
    Dim Ngay(1) As Date
    Dim Lsql As String = String.Empty
    Private _kh As clsKhachHang = Nothing
    Property kh() As clsKhachHang
        Get
            If _kh Is Nothing Then
                _kh = New clsKhachHang()
            End If
            Return _kh
        End Get
        Set(ByVal Value As clsKhachHang)
            _kh = Value
        End Set
    End Property
    ''' <summary>
    ''' Liệt kê, Chọn chứng từ
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_6.Click, _Command_5.Click, _Command_4.Click, _Command_3.Click, _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim taikhoan As ClsTaikhoan
        Dim ms As Integer
        Select Case Index
            Case 0
                If CboThang(0).Items.Count > 0 And CboThang(1).Items.Count > 0 Then
                    If CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
                End If

                LietKeChungtu()
            Case 1
                GrdChungtu.Col = 7
                If GrdChungtu.CtlText.ToString = "" Then Exit Sub
                MaCTChon = ConvertToDblSafe(GrdChungtu.CtlText)
                Lietke = True
                Hide()
            Case 2
                MaCTChon = 0
                Lietke = True
                Hide()
            Case 3, 4
                If ConvertToDblSafe(L(3).Text) = 0 Then Exit Sub
                If OptLK(1).Checked And CboThang(2).Text = "111" Then
                    taikhoan = New ClsTaikhoan()
                    taikhoan.InitTaikhoanSohieu("111")
                    SetRptInfo()
                    InSocaiTk(taikhoan, 0, 0, Ngay(0), Ngay(1), True, "", 0, 0)
                    taikhoan = Nothing
                Else
                    InBangKe()
                End If
                rptFrom.ReportDestination = 4 - Index
                InBaoCaoRPT()
            Case 5
                Dim f3 As New FrmChungtu()
                f3.ShowDialog()
                With GrdChungtu
                    .Col = 7
                    For Each sItem As ListViewEx.GLItem In .SelectedItems
                        .Row = sItem.Index
                        ms = ConvertToDblSafe(.CtlText)
                        If ms > 0 Then
                            pPhieu = 0
                            f3.VaoSoNK(ConvertToDblSafe(GrdChungtu.CtlText))
                        End If
                    Next
                End With

                f3 = Nothing
                pPhieu = 1
                Command_ClickEvent(Command(0), New EventArgs())
            Case 6
                If CboThang(0).Items.Count > 0 And CboThang(1).Items.Count > 0 Then
                    If CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
                End If
                DoisoChungtu()
                SetSPTC()
        End Select
        If _CboThang_1.Items.Count > 0 Then
            chiso1 = _CboThang_1.SelectedIndex
        End If
        If _CboThang_0.Items.Count > 0 Then
            chiso0 = _CboThang_0.SelectedIndex
        End If
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        If Lietke Then
            Me.Refresh()
            Command_ClickEvent(Command(0), New EventArgs())
            Lietke = False
        Else
            SetFont(Me)
        End If
        Khoaquyen()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmDsTC_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.L
                    Command(0).Focus()
                    'Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.C
                    Command(1).Focus()
                    ' Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.V
                    Command(2).Focus()
                    ' Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.P
                    Command(6).Focus()
                    'Command_ClickEvent(Command(6), New EventArgs())
            End Select
        End If
        If (Shift And 2) > 0 And eventArgs.KeyCode = Keys.A Then GridSelAll(GrdChungtu)
        If eventArgs.KeyCode = Keys.Escape Then Command_ClickEvent(Command(2), New EventArgs())
    End Sub

    ' Khởi tạo cửa sổ

    Private chiso1 As Integer = -1
    Private chiso0 As Integer = -1
    Private Sub FrmDsTC_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            ' Init form 
            Call FormInit()

            ColumnSetUp(GrdChungtu, 0, 1300, 2)
            ColumnSetUp(GrdChungtu, 1, 820, 2)
            ColumnSetUp(GrdChungtu, 2, 1420, 0)
            ColumnSetUp(GrdChungtu, 3, 1420, 0)
            ColumnSetUp(GrdChungtu, 4, 1660, 0)
            ColumnSetUp(GrdChungtu, 5, 1300, 4)
            ColumnSetUp(GrdChungtu, 6, 1265, 4)
            ColumnSetUp(GrdChungtu, 7, 1, 0)
            AddMonthToCbo(CboThang(0))
            AddMonthToCbo(CboThang(1))
            For chi_so As Integer = 0 To 1
                InitDateVars(MedNgay(chi_so), Ngay(chi_so))
            Next
            Int_RecsetToCbo("SELECT CONVERT(bigint,LEFT(SoHieu,3)) As F2,LEFT(SoHieu,3) As F1 FROM HethongTK WHERE LEFT(SoHieu,3)='111' OR LEFT(SoHieu,3)='112' OR TK_ID2=112 GROUP BY LEFT(SoHieu,3)", CboThang(2))
            Int_RecsetToCbo("SELECT MaSo As F2,DienGiai As F1 FROM DoituongCT ORDER BY DienGiai", CboNguon)
            MaCTChon = 0
            GrdChungtu.Row = 0
            GrdChungtu_ClickEvent(GrdChungtu, New EventArgs())
            Lietke = False
            Text = SetFormTitle(Text)
            Command(5).Visible = (pPhieu > 0)
            ord = 0
            If chiso0 <> -1 And _CboThang_0.Items.Count > 0 Then
                _CboThang_0.SelectedIndex = chiso0
            End If
            If chiso1 <> -1 And _CboThang_1.Items.Count > 0 Then
                _CboThang_1.SelectedIndex = chiso1
            End If
        Catch ex As Exception
            myUMessager.mError(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try        
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmDsTC_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        kh = Nothing
        MemoryHelper.ReleaseMemory()
    End Sub
    ''' <summary>
    ''' Nhớ mã số CT được chọn
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdChungtu_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdChungtu.Click
        Row = GrdChungtu.Row
        SetGridIndex(GrdChungtu, Row)
        With GrdChungtu
            .Col = 7
            MaCTChon = IIf(.CtlText.length = 0, 0, ConvertToDblSafe(.CtlText))
            .Col = 0
        End With
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdChungtu_KeyPressEvent(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles GrdChungtu.KeyPress
        GrdChungtu_ClickEvent(GrdChungtu, New EventArgs())
        If eventArgs.KeyChar = Chr(Keys.Enter) Then Command_ClickEvent(Command(1), New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdChungtu_KeyUpEvent(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles GrdChungtu.KeyUp
        If eventArgs.KeyCode = 37 Or eventArgs.KeyCode = 38 Or eventArgs.KeyCode = 39 Or eventArgs.KeyCode = 40 Then SetGridIndex(GrdChungtu, GrdChungtu.Row)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdChungtu_MouseDownEvent(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles GrdChungtu.MouseDown
        If eventArgs.Button = MouseButtons.Right Then 'eventArgs.Button = 2
            SearchObj(1, , GrdChungtu, GrdChungtu.Col)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private isInitializingComponent As Boolean
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub SSOpt_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _SSOpt_0.CheckedChanged, _SSOpt_1.CheckedChanged, _SSOpt_2.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(SSOpt, eventSender)
            ord = Index
        End If
    End Sub
    ''' <summary>
    ''' Liệt kê chứng từ
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LietKeChungtu()
        Dim hoten, DiaChi As String
        Dim ovr As Integer
        Dim no, co As Double
        If ChkLoai(0).CheckState = CheckState.Unchecked And ChkLoai(1).CheckState = CheckState.Unchecked Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        Dim i As Integer = IIf(CboThang(2).Text = "111", 0, 3)
        Dim sh As String = IIf(pPhieu > 0, "P", String.Empty)

        Lsql = String.Format("SELECT DISTINCT Chungtu{0}.MaCT, ChungTu{0}.SoHieu, NgayCT, Sum(SoPS) AS TSoPS,Chungtu{0}.DienGiai{1} AS DG,ChungTuLQ{0}.HoTen,ChungTuLQ{0}.DiaChi,ChungTuLQ{0}.SoCTGoc,MaDT,min(HethongTK.SoHieu) AS SHNo,min(TK.SoHieu) AS SHCo,min(DoituongCT.DienGiai) AS BP , NgayGS FROM (((ChungTu{0} LEFT JOIN HethongTK ON Chungtu{0}.MaTKTCNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON Chungtu{0}.MaTKTCCo=TK.MaSo) INNER JOIN DoituongCT ON Chungtu{0}.MaDT=DoituongCT.MaSo) LEFT JOIN ChungTuLQ{0} ON (ChungTu{0}.MaCT=ChungTuLQ{0}.MaCT AND ChungTuLQ{0}.Loai={2}) WHERE ", sh, (IIf(pNN = 1, String.Empty, String.Empty)), ConvertToStrSafe(i))
        If ChkLoai(0).CheckState = CheckState.Checked And ChkLoai(1).CheckState = CheckState.Checked Then
            Lsql = String.Format("{0}(LEFT(HethongTK.SoHieu,3)='{1}' OR LEFT(TK.SoHieu,3)='{1}')", Lsql, CboThang(2).Text)
        Else
            Lsql = IIf(ChkLoai(0).CheckState = CheckState.Checked, String.Format("{0}(LEFT(HethongTK.SoHieu,3)='{1}')", Lsql, CboThang(2).Text), String.Format("{0}(LEFT(TK.SoHieu,3)='{1}')", Lsql, CboThang(2).Text))
        End If
        'Lsql = String.Format("{0} GROUp by Chungtu.MaCT, ChungTu.SoHieu, NgayCT,Chungtu.DienGiai,ChungTuLQ.HoTen,ChungTuLQ.DiaChi,ChungTuLQ.SoCTGoc,MaDT,HethongTK.SoHieu ,TK.SoHieu ,DoituongCT.DienGiai , NgayGS ,SoPS", Lsql)

        If CboNguon.SelectedIndex > 1 Then Lsql = String.Format("{0} AND ChungTu{1}.MaDT={2}", Lsql, sh, ConvertToStrSafe(CboNguon.SelectedValue))

        If OptLK(0).Checked Then
            Lsql = String.Format("{0} AND {1}", Lsql, WThang("ThangCT", CboThang(0).SelectedValue, CboThang(1).SelectedValue))
        Else
            Lsql = String.Format("{0} AND {1}", Lsql, WNgay("NgayGS", Ngay(0), Ngay(1)))
        End If
        If kh.MaSo > 0 Then Lsql = String.Format("{0} AND (ChungTuLQ{1}.MaKH={2})", Lsql, sh, ConvertToStrSafe(kh.MaSo))
        If pProcessMode = 1 Then Lsql = String.Format("{0} AND XuLy<2 ", Lsql)
        Lsql = String.Format("{0} GROUP BY ChungTu{1}.MaCT,ChungTu{1}.SoHieu,NgayCT,NgayGS,ChungTu{1}.DienGiai{2},ChungTuLQ{1}.HoTen,ChungTuLQ{1}.DiaChi,ChungTuLQ{1}.SoCTGoc,MaDT,NgayGS ", Lsql, sh, (IIf(pNN = 1, String.Empty, String.Empty)))
        Select Case ord
            Case 0
                Lsql = Lsql & " ORDER BY NgayGS DESC,ChungTu.SoHieu DESC"
            Case 1
                Lsql = Lsql & " ORDER BY NgayCT DESC,ChungTu.SoHieu DESC"
            Case 2
                Lsql = Lsql & " ORDER BY ChungTu.SoHieu DESC"
        End Select
        ClearGrid(GrdChungtu, ConvertToDblSafe(GrdChungtu.Tag))

        Dim rs_chungtu As DataTable = ExecSQLReturnDT(Lsql)
        Dim rs_chungtuIndex As Integer = 0
        Do While rs_chungtuIndex < rs_chungtu.Rows.Count
            Dim rs_chungtuItem As DataRow = rs_chungtu.Rows(rs_chungtuIndex)
            rs_chungtuIndex += 1 ' C15 Rs LOOP CONTROL
            If rs_chungtuItem("shno").ToString <> "" Then
                If rs_chungtuItem("shno").ToString Like CboThang(2).Text + "*" Then no += rs_chungtuItem("Tsops")
            End If
            If rs_chungtuItem("shco").ToString <> "" Then
                If rs_chungtuItem("shco").ToString Like CboThang(2).Text + "*" Then co += rs_chungtuItem("Tsops")
            End If

            hoten = IIf(IsDBNull(rs_chungtuItem("hoten")), "...", rs_chungtuItem("hoten"))
            DiaChi = IIf(IsDBNull(rs_chungtuItem("DiaChi")), "...", rs_chungtuItem("DiaChi"))
            If GrdChungtu.Rows < MaxGridRow Then

                GrdChungtu.AddItem(String.Format("{0}{1}{2:dd/MM}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}", _
                                       ConvertToStrSafe(rs_chungtuItem("SoHieu")), _
                                       Chr(9), _
                                       CDate(rs_chungtuItem("NgayCT")).ToShortDateString, _
                                       hoten, _
                                       DiaChi, _
                                       ConvertToStrSafe(rs_chungtuItem("dg")), _
                                       (IIf(rs_chungtuItem("shno").ToString Like CboThang(2).Text + "*", Format(rs_chungtuItem("Tsops"), Mask_0), String.Empty)), _
                                       (IIf(rs_chungtuItem("shco").ToString Like CboThang(2).Text + "*", Format(rs_chungtuItem("Tsops"), Mask_0), String.Empty)), _
                                       rs_chungtuItem("MaCT")))
            Else
                ovr = 1
            End If
            'rs_chungtu.MoveNext()
        Loop
        If rs_chungtu.Rows.Count > 0 Then
            If Row >= rs_chungtu.Rows.Count Then
                Row = rs_chungtu.Rows.Count - 1
            End If
        Else
            Row = 0
        End If
        ''GrdChungtu.Rows = iif(rs_chungtu.Rows.Count > ConvertToDblSafe(GrdChungtu.Tag), iif(rs_chungtu.Rows.Count > MaxGridRow, MaxGridRow, rs_chungtu.Rows.Count), ConvertToDblSafe(GrdChungtu.Tag))
        GrdChungtu.Col = 0
        L(3).Text = ConvertToStrSafe(rs_chungtu.Rows.Count)
        ''rs_chungtu.Close()
        rs_chungtu = Nothing
        Try
            GrdChungtu.Row = ConvertToDblSafe(Row)
            GrdChungtu_ClickEvent(GrdChungtu, New EventArgs())
            'If Not GrdChungtu.get_RowIsVisible(ConvertToDblSafe(Row)) Then GrdChungtu.TopRow = ConvertToDblSafe(Row - 12)
        Catch exc As System.Exception
            'Resume in On-Error-Resume-Next Block
        End Try
        L(0).Text = Format(no, Mask_0)
        L(1).Text = Format(co, Mask_0)
        L(2).Text = Format(no - co, Mask_0)
        Me.Cursor = Cursors.Default
        If ovr > 0 Then ErrMsg(er_NhieuCT)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DoisoChungtu()
        Dim hoten, DiaChi As String
        Dim ovr As Integer
        Dim no, co As Double
        If ChkLoai(0).CheckState = CheckState.Unchecked And ChkLoai(1).CheckState = CheckState.Unchecked Then
            MessageBox.Show(Ngonngu("Bạn muốn đổi số của phiếu thu hay phiếu chi", "You want to change the number of receipts and expenditures"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearGrid(GrdChungtu, ConvertToDblSafe(GrdChungtu.Tag))
            Exit Sub
        End If
        If ChkLoai(0).CheckState = CheckState.Checked And ChkLoai(1).CheckState = CheckState.Checked Then
            MessageBox.Show(Ngonngu("Bạn muốn đổi số của phiếu thu hay phiếu chi", "You want to change the number of receipts and expenditures"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearGrid(GrdChungtu, ConvertToDblSafe(GrdChungtu.Tag))
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim i As Integer = IIf(CboThang(2).Text = "111", 0, 3)
        Dim sh As String = IIf(pPhieu > 0, "P", String.Empty)

        Dim sql As String = String.Format("SELECT  Chungtu{0}.MaCT, ChungTu{0}.SoHieu, NgayCT, Sum(SoPS) AS TSoPS,Chungtu{0}.DienGiai{1} AS DG,ChungTuLQ{0}.HoTen,ChungTuLQ{0}.DiaChi,ChungTuLQ{0}.SoCTGoc,MaDT,HethongTK.SoHieu AS SHNo,TK.SoHieu AS SHCo,DoituongCT.DienGiai AS BP,chungtu{0}.mathuchi,chungtu{0}.thangct,chungtu{0}.maso,ngaygs FROM (((ChungTu{0} LEFT JOIN HethongTK ON Chungtu{0}.MaTKTCNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON Chungtu{0}.MaTKTCCo=TK.MaSo) INNER JOIN DoituongCT ON Chungtu{0}.MaDT=DoituongCT.MaSo) LEFT JOIN ChungTuLQ{0} ON (ChungTu{0}.MaCT=ChungTuLQ{0}.MaCT AND ChungTuLQ{0}.Loai={2}) WHERE ", sh, (IIf(pNN = 1, "E", String.Empty)), ConvertToStrSafe(i))
        Dim sql1 As String = String.Format("SELECT  Chungtu{0}.MaCT, ChungTu{0}.SoHieu, NgayCT, Sum(SoPS) AS TSoPS,Chungtu{0}.DienGiai{1} AS DG,ChungTuLQ{0}.HoTen,ChungTuLQ{0}.DiaChi,ChungTuLQ{0}.SoCTGoc,MaDT,HethongTK.SoHieu AS SHNo,TK.SoHieu AS SHCo,DoituongCT.DienGiai AS BP,chungtu{0}.mathuchi FROM (((ChungTu{0} LEFT JOIN HethongTK ON Chungtu{0}.MaTKTCNo=HethongTK.MaSo) LEFT JOIN HethongTK AS TK ON Chungtu{0}.MaTKTCCo=TK.MaSo) INNER JOIN DoituongCT ON Chungtu{0}.MaDT=DoituongCT.MaSo) LEFT JOIN ChungTuLQ{0} ON (ChungTu{0}.MaCT=ChungTuLQ{0}.MaCT AND ChungTuLQ{0}.Loai={2}) WHERE ", sh, (IIf(pNN = 1, "E", String.Empty)), ConvertToStrSafe(i))
        If ChkLoai(0).CheckState = CheckState.Checked And ChkLoai(1).CheckState = CheckState.Checked Then
            sql = String.Format("{0}(LEFT(HethongTK.SoHieu,3)='{1}' OR LEFT(TK.SoHieu,3)='{1}')", sql, CboThang(2).Text)
            sql1 = String.Format("{0}(LEFT(HethongTK.SoHieu,3)='{1}' OR LEFT(TK.SoHieu,3)='{1}')", sql1, CboThang(2).Text)
        Else
            If ChkLoai(0).CheckState = CheckState.Checked Then
                sql = String.Format("{0}(LEFT(HethongTK.SoHieu,3)='{1}')", sql, CboThang(2).Text)
                sql1 = String.Format("{0}(LEFT(HethongTK.SoHieu,3)='{1}')", sql1, CboThang(2).Text)
            Else
                sql = String.Format("{0}(LEFT(TK.SoHieu,3)='{1}')", sql, CboThang(2).Text)
                sql1 = String.Format("{0}(LEFT(TK.SoHieu,3)='{1}')", sql1, CboThang(2).Text)
            End If
        End If
        If ChkLoai(0).CheckState = CheckState.Unchecked And ChkLoai(1).CheckState = CheckState.Unchecked Then
            MessageBox.Show(Ngonngu("Bạn muốn đổi số của phiếu thu hay phiếu chi", "You want to change the number of receipts and expenditures"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End If
        If CboNguon.SelectedIndex > 1 Then
            sql = String.Format("{0} AND ChungTu{1}.MaDT={2}", sql, sh, ConvertToStrSafe(CboNguon.SelectedValue)) : sql1 = sql1 & " AND ChungTu" & sh & ".MaDT=" & ConvertToStrSafe(CboNguon.SelectedValue)
        End If
        If OptLK(0).Checked Then
            sql = String.Format("{0} AND {1}", sql, WThang("ThangCT", CboThang(0).SelectedValue, CboThang(1).SelectedValue))
            sql1 = String.Format("{0} AND {1}", sql1, WThang("ThangCT", CboThang(0).SelectedValue, CboThang(1).SelectedValue))
        Else
            Ngay(0) = _MedNgay_0.Text
            Ngay(1) = _MedNgay_1.Text
            sql = String.Format("{0} AND {1}", sql, WNgay("NgayGS", Ngay(0), Ngay(1)))
            sql1 = String.Format("{0} AND {1}", sql1, WNgay("NgayGS", Ngay(0), Ngay(1)))
        End If
        If kh.MaSo > 0 Then
            sql = String.Format("{0} AND (ChungTuLQ{1}.MaKH={2})", sql, sh, ConvertToStrSafe(kh.MaSo)) : sql1 = sql1 & " AND (ChungTuLQ" & sh & ".MaKH=" & ConvertToStrSafe(kh.MaSo) & ")"
        End If
        If pProcessMode = 1 Then
            sql = String.Format("{0} AND XuLy<2 ", sql)
            sql1 = String.Format("{0} AND XuLy<2 ", sql1)
        End If
        sql = String.Format("{0} GROUP BY ChungTu{1}.MaCT,ChungTu{1}.SoHieu,NgayCT,NgayGS,ChungTu{1}.DienGiai{2},ChungTuLQ{1}.HoTen,ChungTuLQ{1}.DiaChi,ChungTuLQ{1}.SoCTGoc,MaDT,HeThongTK.SoHieu,TK.SoHieu,DoituongCT.DienGiai,chungtu{1}.mathuchi,chungtu{1}.thangct,chungtu{1}.maso ", sql, sh, (IIf(pNN = 1, "E", String.Empty)))
        sql1 = String.Format("{0} GROUP BY ChungTu{1}.MaCT,ChungTu{1}.SoHieu,NgayCT,NgayGS,ChungTu{1}.DienGiai{2},ChungTuLQ{1}.HoTen,ChungTuLQ{1}.DiaChi,ChungTuLQ{1}.SoCTGoc,MaDT,HeThongTK.SoHieu,TK.SoHieu,DoituongCT.DienGiai,chungtu{1}.mathuchi ", sql1, sh, (IIf(pNN = 1, "E", String.Empty)))
        Select Case ord
            Case 0
                sql = String.Format("{0} ORDER BY NgayGS,ChungTu{1}.SoHieu", sql, sh)
                sql1 = String.Format("{0} ORDER BY NgayGS DESC,ChungTu{1}.SoHieu DESC", sql1, sh)
            Case 1
                sql = String.Format("{0} ORDER BY NgayCT,ChungTu{1}.SoHieu", sql, sh)
                sql1 = String.Format("{0} ORDER BY NgayCT DESC,ChungTu{1}.SoHieu DESC", sql1, sh)
            Case 2
                sql = String.Format("{0} ORDER BY ChungTu{1}.SoHieu", sql, sh)
                sql1 = String.Format("{0} ORDER BY ChungTu{1}.SoHieu DESC", sql1, sh)
        End Select
        ClearGrid(GrdChungtu, ConvertToDblSafe(GrdChungtu.Tag))
        '************************ Đổi số chứng từ *************************
        Dim rs_chungtu As DataTable = ExecSQLReturnDT(sql)
        Dim kt = String.Empty
        Dim sochungtudoi = String.Empty, kt1 As String = String.Empty
        Dim stt1 As Integer = 0 : Dim stt2 As Integer = 0
        If MessageBox.Show(Ngonngu("Mỗi ngày một phiếu ?", "One vote per day ?"), My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Soquy = 1
        Else
            Soquy = 0
        End If
        Dim rs_chungtuIndex As Integer = 0
        Do While rs_chungtuIndex < rs_chungtu.Rows.Count
            Dim rs_chungtuItem As DataRow = rs_chungtu.Rows(rs_chungtuIndex)
            rs_chungtuIndex += 1 ' C15 Rs LOOP CONTROL
            sochungtudoi = ""
            If ChkLoai(0).CheckState = CheckState.Checked Then
                If kt = ConvertToStrSafe(rs_chungtuItem("ThangCT")) Then
                    If Soquy = 1 Then
                        If kt1 <> ConvertToStrSafe(rs_chungtuItem("NgayGS")) Then stt1 += 1
                    Else
                        If kt1 <> ConvertToStrSafe(rs_chungtuItem("MaCT")) Then stt1 += 1
                    End If
                Else
                    stt1 = 1
                End If
                sochungtudoi = String.Format("PT{0}{1}", (IIf(ConvertToStrSafe(rs_chungtuItem("ThangCT")) < 10, String.Format("0{0}", rs_chungtuItem("ThangCT")), rs_chungtuItem("ThangCT"))), (IIf(stt1 >= 100, ConvertToStrSafe(stt1), (IIf(stt1 >= 10, "0" & stt1, "00" & stt1)))))
            Else
                If kt = ConvertToStrSafe(rs_chungtuItem("ThangCT")) Then
                    If Soquy = 1 Then
                        If kt1 <> ConvertToStrSafe(rs_chungtuItem("NgayGS")) Then stt2 += 1
                    Else
                        If kt1 <> ConvertToStrSafe(rs_chungtuItem("MaCT")) Then stt2 += 1
                    End If
                Else
                    stt2 = 1
                End If
                sochungtudoi = String.Format("PC{0}{1}", (IIf(ConvertToStrSafe(rs_chungtuItem("ThangCT")) < 10, "0" & rs_chungtuItem("ThangCT"), rs_chungtuItem("ThangCT"))), (IIf(stt2 >= 100, ConvertToStrSafe(stt2), (IIf(stt2 >= 10, "0" & stt2, "00" & stt2)))))
            End If
            ExecSQLNonQuery(String.Format("UPDATE chungtu set mathuchi='{0}' WHERE maso={1}", sochungtudoi, rs_chungtuItem("MaSo")))
            kt = rs_chungtuItem("ThangCT")
            If Soquy = 1 Then
                kt1 = rs_chungtuItem("NgayGS")
            Else
                kt1 = rs_chungtuItem("MaCT")
            End If
            'rs_chungtu.MoveNext()
        Loop
        rs_chungtu = Nothing
        '************************* Load dữ liệu lên lưới ***********************
        rs_chungtu = ExecSQLReturnDT(sql1)
        rs_chungtuIndex = 0
        Do While rs_chungtuIndex < rs_chungtu.Rows.Count
            Dim rs_chungtuItem As DataRow = rs_chungtu.Rows(rs_chungtuIndex)
            rs_chungtuIndex += 1 ' C15 Rs LOOP CONTROL
            'If Strings.Left(rs_chungtuItem("shno"), 3) = CboThang(2).Text Then no += rs_chungtuItem("Tsops")
            'If Strings.Left(rs_chungtuItem("shco"), 3) = CboThang(2).Text Then co += rs_chungtuItem("Tsops")
            If rs_chungtuItem("shno").ToString <> "" Then
                If Strings.Left(rs_chungtuItem("shno"), 3) = CboThang(2).Text Then no += rs_chungtuItem("Tsops")
            End If
            If rs_chungtuItem("shco").ToString <> "" Then
                If Strings.Left(rs_chungtuItem("shco"), 3) = CboThang(2).Text Then co += rs_chungtuItem("Tsops")
            End If
            hoten = IIf(IsDBNull(rs_chungtuItem("hoten")), "...", rs_chungtuItem("hoten"))
            DiaChi = IIf(IsDBNull(rs_chungtuItem("DiaChi")), "...", rs_chungtuItem("DiaChi"))
            If GrdChungtu.Rows < MaxGridRow Then
                If rs_chungtuItem("shno").ToString <> "" And rs_chungtuItem("shco").ToString <> "" Then
                    GrdChungtu.AddItem(String.Format("{0}{1}{2:dd/MM}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}", _
                                                       ConvertToStrSafe(rs_chungtuItem("mathuchi")), _
                                                       Chr(9), _
                                                       CDate(rs_chungtuItem("NgayCT")).ToShortDateString, _
                                                       hoten, _
                                                       DiaChi, _
                                                       ConvertToStrSafe(rs_chungtuItem("dg")), _
                                                       (IIf(Strings.Left(rs_chungtuItem("shno"), 3) = CboThang(2).Text, Format(rs_chungtuItem("Tsops"), Mask_0), String.Empty)), _
                                                       (IIf(Strings.Left(rs_chungtuItem("shco"), 3) = CboThang(2).Text, Format(rs_chungtuItem("Tsops"), Mask_0), String.Empty)), _
                                                       rs_chungtuItem("MaCT")))
                End If
                ' GrdChungtu.AddItem(ConvertToStrSafe(rs_chungtuItem("mathuchi")) + Chr(9).ToString() + DateTime.FromOADate(rs_chungtuItem("NgayCT")).ToString("dd/MM") + Chr(9).ToString() + hoten + Chr(9).ToString() + DiaChi + Chr(9).ToString() + ConvertToStrSafe(rs_chungtuItem("dg")) + Chr(9).ToString() + (IIf(Strings.Left(rs_chungtuItem("shno"), 3) = CboThang(2).Text, Format(rs_chungtuItem("Tsops"), Mask_0), String.Empty)) + Chr(9).ToString() + (IIf(Strings.Left(rs_chungtuItem("shco"), 3) = CboThang(2).Text, Format(rs_chungtuItem("Tsops"), Mask_0), String.Empty)) + Chr(9).ToString() + rs_chungtuItem("MaCT"), 0)
            Else
                ovr = 1
            End If
            'rs_chungtu.MoveNext()
        Loop
        If rs_chungtu.Rows.Count > 0 Then
            If Row >= rs_chungtu.Rows.Count Then
                Row = rs_chungtu.Rows.Count - 1
            End If
        Else
            Row = 0
        End If
        'GrdChungtu.Rows = iif(rs_chungtu.Rows.Count > ConvertToDblSafe(GrdChungtu.Tag), iif(rs_chungtu.Rows.Count > MaxGridRow, MaxGridRow, rs_chungtu.Rows.Count), ConvertToDblSafe(GrdChungtu.Tag))
        GrdChungtu.Col = 0
        L(3).Text = ConvertToStrSafe(rs_chungtu.Rows.Count)
        ''rs_chungtu.Close()
        rs_chungtu = Nothing
        Try
            GrdChungtu.Row = ConvertToDblSafe(Row)
            GrdChungtu_ClickEvent(GrdChungtu, New EventArgs())
            'If Not GrdChungtu.get_RowIsVisible(ConvertToDblSafe(Row)) Then GrdChungtu.TopRow = ConvertToDblSafe(Row - 12)
        Catch exc As System.Exception
            'Resume in On-Error-Resume-Next Block
        End Try
        L(0).Text = Format(no, Mask_0)
        L(1).Text = Format(co, Mask_0)
        L(2).Text = Format(no - co, Mask_0)
        Me.Cursor = Cursors.Default
        If ovr > 0 Then ErrMsg(er_NhieuCT)
    End Sub
    ''' <summary>
    ''' Hàm hiện cửa sổ danh sách và trả về mã số CT được chọn
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ChonCT() As Integer
        ShowDialog()
        Return MaCTChon
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_0.Enter, _MedNgay_1.Enter
        Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
        MedNgay(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_0.Leave, _MedNgay_1.Leave
        Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
        If Information.IsDate(MedNgay(Index).Text) Then
            Ngay(Index) = ConvertToDateSafe(MedNgay(Index).Text)
        Else
            MedNgay(Index).Focus()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InBangKe()
        If Lsql.Length = 0 Then Exit Sub
        rptFrom.InitForm("PHIEUTC.RPT", Lsql, "QNhatky")
        SetRptInfo()
        'SetSQL("QNhatky", Lsql)
        If OptLK(0).Checked Then
            If CboThang(0).SelectedIndex <> CboThang(1).SelectedIndex Then
                rptFrom.SetFormulas("ThoiGian", String.Format("IF PageNumber()=1 THEN 'Từ tháng {0} đến thang {1}'", CboThang(0).SelectedValue, ConvertToStrSafe(CboThang(1).SelectedValue)))
            Else
                rptFrom.SetFormulas("ThoiGian", String.Format("IF PageNumber()=1 THEN 'Tháng {0}'", CboThang(1).SelectedValue))
            End If
            RptSetDate(NgayCuoiThang(pNamTC, CboThang(1).SelectedValue))
        Else
            If Ngay(0) <> Ngay(1) Then
                rptFrom.SetFormulas("ThoiGian", String.Format("'IF PageNumber()=1 THEN Từ ngày {0} đến ngày {1}'", Format(Ngay(0), Mask_DB), Format(Ngay(1), Mask_DB)))
            Else
                rptFrom.SetFormulas("ThoiGian", String.Format("'IF PageNumber()=1 THEN Ngày {0}'", Format(Ngay(1), Mask_DB)))
            End If
            RptSetDate(Ngay(1))
        End If
        rptFrom.SetFormulas("BoPhan", String.Format("'{0}'", (IIf(CboNguon.SelectedIndex > 1, CboNguon.Text, String.Empty))))
        If kh.MaSo > 0 Then
            rptFrom.SetFormulas("TenKH", String.Format("'{0} - {1}'", kh.SoHieu, kh.Ten))
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtshkh_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtshkh.Enter
        txtshkh.SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtshkh_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtshkh.Leave
        kh.InitKhachHangSohieu(txtshkh.Text)
        lbkh.Text = kh.Ten
        HienThongBao(Me.Text, 1)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdkh_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdkh.Click
        Me.Cursor = Cursors.WaitCursor
        txtshkh.Text = FrmKhachHang.ChonKhachHang(txtshkh.Text)
        Me.Cursor = Cursors.Default
        txtshkh.Focus()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="uid"></param>
    ''' <remarks></remarks>
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(6).Enabled = (User_Right <> 2 Or (UserID = uid))
    End Sub
End Class
