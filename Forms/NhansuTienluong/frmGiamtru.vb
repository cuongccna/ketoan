Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter


Partial Friend Class frmGiamtru
    Dim MaNV As Integer
    Dim thang As Integer

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub frmGiamtru_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        ' Init form 
        Call FormInit()
        '  Xoatextluoi()
        Dim CboQH_NewIndex As Integer = -1
        ColumnSetUp(GrdVT, 0, 3950, 0)
        ColumnSetUp(GrdVT, 1, 830, 1)
        ColumnSetUp(GrdVT, 2, 1430, 1)
        ColumnSetUp(GrdVT, 3, 1670, 0)
        ColumnSetUp(GrdVT, 4, 1190, 0)
        ColumnSetUp(GrdVT, 5, 950, 0)
        ColumnSetUp(GrdVT, 6, 1045, 0)
        ColumnSetUp(GrdVT, 7, 1, 0)
        CboQH.Items.Clear()
        CboQH.Items.ItemsBase.Clear()
        CboQH.Items.Add("Con", 1)
        CboQH.Items.Add("Vợ", 2)
        CboQH.Items.Add("Chồng", 3)
        CboQH.Items.Add("Cha", 4)
        CboQH.Items.Add("Mẹ", 5)
        CboQH.Items.Add("Cháu ruột", 6)
        CboQH.Items.Add("Họ hàng", 7)
        CboQH.Items.Add("Khác", 8)
        AddMonthToCbo(CboThang)
        If CboThang.Items.Count > 0 Then
            CboThang.SelectedIndex = Today.Month - 1
        End If
        Int_RecsetToCbo("SELECT DISTINCT MaSo As F2,SoHieu + ' - '  + Ten As F1 FROM PhanLoaiQuanLyNhanVien WHERE maso not in (select captren from phanloaiquanlynhanvien) ORDER BY MaSo ,F1", CboLoai)
        If CboLoai.Items.Count > 0 Then
            CboLoai.SelectedIndex = 0
        End If
        SetFont(Me)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Xoatextluoi()
        For i As Integer = 0 To 2
            txt(i).Text = "..."
        Next
        MedNgay(0).Text = "__/__/__"
        MedNgay(1).Text = "__/__"
        MedNgay(2).Text = "__/__"
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Xoatext()
        For i As Integer = 4 To 6
            txt(i).Text = "0"
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboLoai_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboLoai.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        Int_RecsetToListbox(String.Format("SELECT MaSo As F2, SoHieu + ' - ' + Ten As F1 FROM QuanLyNhanVien WHERE MaPhanLoai={0} ORDER BY SoHieu", CboLoai.SelectedValue), LstVt)
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub CboThang_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles CboThang.SelectedIndexChanged
        thang = CboThang.SelectedValue
        Hienthitext()
    End Sub
    Sub Hienthitext()
        Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT * FROM tuthien WHERE thang={0} and manv={1}", thang, ConvertToStrSafe(MaNV)))
        If rs.Rows.Count = 0 Then
            Xoatext()
        Else
            If rs.Rows.Count > 0 Then
                Dim rsItem As DataRow = rs.Rows(0)
                txt(4).Text = Format(ConvertToDblSafe(rsItem("tuthien")), Mask_0)
                txt(5).Text = Format(ConvertToDblSafe(rsItem("nhandao")), Mask_0)
                txt(6).Text = Format(ConvertToDblSafe(rsItem("khuyenhoc")), Mask_0)
            End If

        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdct_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdct.Click
        Dim str As String = String.Empty
        Dim MaSo As Integer
        If txt(0).Text Like ".*" Then
            MessageBox.Show(String.Format("Thiếu tên hoặc tên không hợp lệ! {0}", Information.Err().Description), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt(0).Focus()
        ElseIf Not IsDate(MedNgay(0).Text) Then
            MessageBox.Show(String.Format("Thiếu ngày sinh hoặc ngày sinh không hợp lệ! {0}", Information.Err().Description), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            MedNgay(0).Focus()
        ElseIf CboQH.Text = "" Then
            MessageBox.Show(String.Format("Thiếu quan hệ với người nộp thuế hoặc quan hệ không hợp lệ! {0}", Information.Err().Description), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CboQH.Focus()
        Else
            MaSo = Lng_MaxValue("maso", "giacanh") + 1
            ExecSQLNonQuery(String.Format("INSERT into giacanh(maso,manv,ten,ngaysinh,mst,cmnd,quanhe,tuthang,denthang) values({0}, N'{1}',N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}')", _
                                MaSo, _
                                ConvertToStrSafe(MaNV), _
                                txt(0).Text, _
                                MedNgay(0).Text, _
                                txt(1).Text, _
                                txt(2).Text, _
                                CboQH.Text, _
                                MedNgay(1).Text, _
                                MedNgay(2).Text))
            GrdVT.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}", _
                              txt(0).Text, _
                              Chr(9), _
                              MedNgay(0).Text, _
                              txt(1).Text, _
                              txt(2).Text, _
                              CboQH.Text, _
                              MedNgay(1).Text, _
                              MedNgay(2).Text, _
                              ConvertToStrSafe(MaSo)), 0)
            Xoatextluoi()
            txt(0).Focus()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Hienthiluoi()
        Cursor = Cursors.WaitCursor
        Dim rs As DataTable = ExecSQLReturnDT(String.Format("SELECT * FROM giacanh WHERE manv={0} order by maso", MaNV))
        ClearGrid(GrdVT, GrdVT.Rows)
        GrdVT.Rows = 1
        For Each rsItem As DataRow In rs.Rows
            GrdVT.AddItem(String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}", _
                              rsItem("ten"), _
                              Chr(9), _
                              rsItem("NgaySinh"), _
                              rsItem("MST"), _
                              rsItem("CMND"), _
                              rsItem("quanhe"), _
                              rsItem("tuthang"), _
                              rsItem("denthang"), _
                              rsItem("MaSo")), 0)
        Next
        Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_3.Click, _Command_4.Click, _Command_2.Click, _Command_1.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim str As String = String.Empty
        Dim rs As DataTable
        Select Case Index
            Case 1
                str = String.Format("SELECT * FROM tuthien WHERE thang={0} and manv={1}", thang, ConvertToStrSafe(MaNV))
                rs = ExecSQLReturnDT(str)
                If rs.Rows.Count = 0 Then
                    Themtuthien()
                Else
                    Suatuthien()
                End If
                Hienthitext()

            Case 2
                ExecSQLNonQuery(String.Format("DELETE  FROM tuthien WHERE thang={0} and manv={1}", thang, ConvertToStrSafe(MaNV)))
                Hienthitext()
            Case 3
                Me.Close()
            Case 4
                Xem()
        End Select
        GrdVT.Refresh()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Xem()
        Try
            rptFrom.InitForm("GiaCanh.RPT", _
                String.Format("SELECT t1.*,t2.ten,t2.mst FROM quanlynhanvien t2 INNER JOIN giacanh t1 ON t1.manv=t2.maso WHERE t1.manv={0}", MaNV), _
                "QDuPhong")

            SetRptInfo()
            'SetSQL("QGiaCanh", String.Format("SELECT t1.*,t2.ten,t2.mst FROM quanlynhanvien t2 INNER JOIN giacanh t1 ON t1.manv=t2.maso WHERE t1.manv={0}", MaNV))
            rptFrom.ReportWindowTitle = Ngonngu("Mẫu đăng ký người phụ thuộc giảm trừ gia cảnh", "Form dependent family allowances")
            rptFrom.SetFormulas("tinh", String.Format("'{0}'", frmMain._LbCty_11.Text))
            rptFrom.ReportWindowState = System.Windows.Forms.FormWindowState.Maximized

            rptFrom = rptFrom.copyReportObject(rptFrom)
            Dim reportMessage As String = rptFrom.DoReport()
            If String.IsNullOrEmpty(reportMessage) Then

            End If
            If Not RptOK(rptFrom.ReportFilename, 0) Then
                MessageBox.Show(Ngonngu("Mẫu báo cáo đã bị thay đổi!", "change report form"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            'frmMain.rpt.Action = 1
        Catch excep As System.Exception
            MessageBox.Show(String.Format("Error {0}: {1}", Information.Err().Number, excep.Message), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Themtuthien()
        Try
            Dim sql As String = String.Format("INSERT into tuthien(maso,manv,thang,tuthien,nhandao,khuyenhoc)values({0},{1},{2},{3},{4},{5})", _
                              Lng_MaxValue("maso", "tuthien") + 1, _
                              ConvertToStrSafe(MaNV), _
                              ConvertToStrSafe(thang), _
                              ConvertToDblSafe(IIf(txt(4).Text = "", 0, txt(4).Text)), _
                             ConvertToDblSafe(IIf(txt(5).Text = "", 0, txt(5).Text)), _
                              ConvertToDblSafe(IIf(txt(6).Text = "", 0, txt(6).Text)))

            ExecSQLNonQuery(sql)
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Suatuthien()
        Dim str As String = String.Format("UPDATE tuthien SET tuthien={0},nhandao={1},khuyenhoc={2} WHERE thang={3} and manv={4}", _
                        ConvertToDblSafe(IIf(txt(4).Text = "", 0, txt(4).Text)), _
                        ConvertToDblSafe(IIf(txt(5).Text = "", 0, txt(5).Text)), _
                        ConvertToDblSafe(IIf(txt(6).Text = "", 0, txt(6).Text)), _
                        ConvertToStrSafe(thang), _
                        ConvertToStrSafe(MaNV))
        ExecSQLNonQuery(str)
    End Sub
    ''' <summary>
    '''Init form 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormInit()
        '    Hienthiluoi
        Khoaquyen()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub frmGiamtru_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case KeyCode
                Case Keys.I
                    Command(4).Focus()
                    Command_ClickEvent(Command(4), New EventArgs())
                Case Keys.V
                    Command(3).Focus()
                    Command_ClickEvent(Command(3), New EventArgs())
                Case Keys.X
                    Command(2).Focus()
                    Command_ClickEvent(Command(2), New EventArgs())
                Case Keys.G
                    Command(1).Focus()
                    Command_ClickEvent(Command(1), New EventArgs())
            End Select
        End If
        If eventArgs.KeyCode = Keys.Escape Then Command_ClickEvent(Command(3), New EventArgs())
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdVT_DblClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles GrdVT.DoubleClick
        Hienthidong()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Hienthidong()
        If GrdVT.Rows > 0 Then
            GrdVT.Col = 0
            txt(0).Text = GrdVT.CtlText
            GrdVT.Col = 1
            MedNgay(0).Text = GrdVT.CtlText
            GrdVT.Col = 2
            txt(1).Text = GrdVT.CtlText
            GrdVT.Col = 3
            txt(2).Text = GrdVT.CtlText
            GrdVT.Col = 4
            If CboQH.Items.Count > 0 Then CboQH.SelectedIndex = 0
            Dim iIndex As Integer = 0
            While CboQH.Items(iIndex).Value <> GrdVT.CtlText And iIndex < (CboQH.Items.Count - 1)
                iIndex += 1
            End While
            GrdVT.Col = 5
            MedNgay(1).Text = GrdVT.CtlText
            GrdVT.Col = 6
            MedNgay(2).Text = GrdVT.CtlText
            GrdVT.Col = 7
            If Not String.IsNullOrEmpty(GrdVT.CtlText) Then
                ExecSQLNonQuery("DELETE FROM giacanh WHERE maso=" & GrdVT.CtlText)
                GrdVT.RemoveItem(GrdVT.Row)
                'van.nguyen 18-Nov-2011
                GrdVT.Refresh()
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub GrdVT_KeyUpEvent(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles GrdVT.KeyUp
        If eventArgs.KeyCode = 37 Or eventArgs.KeyCode = 38 Or eventArgs.KeyCode = 39 Or eventArgs.KeyCode = 40 Then SetGridIndex(GrdVT, GrdVT.Row)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub LstVt_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles LstVt.SelectedIndexChanged
        Dim currentCate As ValueDescriptionPair
        Dim index As Integer = IIf(LstVt.SelectedIndex = -1, 0, LstVt.SelectedIndex)
        currentCate = CType(LstVt.Items(index), ValueDescriptionPair)
        MaNV = currentCate.Value

        Hienthiluoi()
        Hienthitext()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_1.Enter, _MedNgay_2.Enter, _MedNgay_0.Enter
        'Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
        'MedNgay(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub MedNgay_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _MedNgay_1.Leave, _MedNgay_2.Leave, _MedNgay_0.Leave
        Dim Index As Integer = Array.IndexOf(MedNgay, eventSender)
        If Index = 1 Or Index = 2 Then
            If Strings.Right(MedNgay(Index).Text, 2) <> Strings.Right(ConvertToStrSafe(pNamTC), 2) Then
                MessageBox.Show(Ngonngu("Không được nhập khác năm tài chính", "Can not enter other finacial year"), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                MedNgay(Index).Focus()
                If Index = 1 Then MedNgay(2).Text = String.Format("12/{0}", Strings.Right(ConvertToStrSafe(pNamTC), 2))
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txt_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txt_4.Enter, _txt_5.Enter, _txt_6.Enter, _txt_2.Enter, _txt_1.Enter, _txt_0.Enter
        Dim Index As Integer = Array.IndexOf(txt, eventSender)
        txt(Index).SelectAll()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txt_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txt_4.Leave, _txt_5.Leave, _txt_6.Leave, _txt_2.Leave, _txt_1.Leave, _txt_0.Leave
        Dim Index As Integer = Array.IndexOf(txt, eventSender)
        Select Case Index
            Case 0 : txt(Index).Text = Hoadautu1(txt(Index).Text)
            Case 4 To 7 : txt(Index).Text = Format(txt(Index).Text, Mask_0)
        End Select
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="uid"></param>
    ''' <remarks></remarks>
    Sub Khoaquyen(Optional ByRef uid As Integer = 1)
        Command(1).Enabled = ChoNhapTiep() And (User_Right <> 2 Or (UserID = uid))
        Command(2).Enabled = (User_Right <> 2 Or (UserID = uid))
        If User_Right <> 0 Then
            If ConvertToDblSafe(GetSelectValue(String.Format("SELECT Lock{0} %  10 AS F1 FROM License", CboThang.SelectedValue))) > 0 Then
                Command(1).Enabled = False
                Command(2).Enabled = False
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub frmGiamtru_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
End Class
