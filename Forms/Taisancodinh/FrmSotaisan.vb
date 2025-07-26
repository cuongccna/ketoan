Imports System
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports UNET.Utility
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports UNET.DataAdapter
Imports Excel = Microsoft.Office.Interop.Excel


Partial Friend Class FrmSotaisan
    Dim baocao As Integer ' Chỉ số báo cáo được chọn
    Private Const dauky As Integer = 100
    Private Const Tang As Integer = 200
    Private Const GIAM As Integer = 300
    Private Const BINHQUAN As Integer = 400
    Dim pSelectSQL As String = String.Empty
    Dim TenFile As String = String.Empty
    Dim TenBaoCao As String = String.Empty
    Dim SoLieu(11) As Boolean
    Dim nn As Integer
    Dim xlapp As Excel.Application
    Dim xlsheet As Excel.Worksheet
    Private isInitializingComponent As Boolean

    Private Sub OptBC_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptBC_0.CheckedChanged, _OptBC_18.CheckedChanged, _OptBC_19.CheckedChanged, _OptBC_20.CheckedChanged, _OptBC_21.CheckedChanged, _OptBC_22.CheckedChanged, _OptBC_23.CheckedChanged, _OptBC_24.CheckedChanged, _OptBC_25.CheckedChanged, _OptBC_26.CheckedChanged, _OptBC_27.CheckedChanged, _OptBC_28.CheckedChanged, _OptBC_29.CheckedChanged, _OptBC_30.CheckedChanged, _OptBC_31.CheckedChanged, _OptBC_45.CheckedChanged, _OptBC_61.CheckedChanged, _OptBC_68.CheckedChanged, _OptBC_71.CheckedChanged, _OptBC_79.CheckedChanged
        If eventSender.Checked Then
            If isInitializingComponent Then
                Exit Sub
            End If
            Dim Index As Integer = Array.IndexOf(OptBC, eventSender)
            Dim thg_dau, thg_cuoi As Boolean
            baocao = Index
            Select Case Index
                Case 0
                    TenFile = "Thetaisan.rpt"
                    TenBaoCao = Ngonngu("THẺ TÀI SẢN CỐ ĐỊNH", "ASSETS TAG")
                    thg_dau = True : thg_cuoi = False
                Case 18
                    TenFile = "KHAUHAO.RPT"
                    TenBaoCao = Ngonngu("SỔ KHẤU HAO TÀI SẢN CỐ ĐỊNH", "BOOK DEPRECIATION")
                    thg_dau = True : thg_cuoi = True
                Case 61
                    TenFile = "KHAUHAO2.RPT"
                    TenBaoCao = Ngonngu("SỔ KHẤU HAO TỔNG HỢP", "AGGREGATE BOOK DEPRECIATION")
                    thg_dau = True : thg_cuoi = True
                Case 19
                    TenFile = "SODU.RPT"
                    TenBaoCao = Ngonngu("SỐ DƯ ĐẦU KỲ", "OPENING PALANCE")
                    thg_dau = True : thg_cuoi = False
                Case 20
                    TenFile = "SODU.RPT"
                    TenBaoCao = Ngonngu("SỐ DƯ CUỐI KỲ", "CLOSING BALANCE")
                    thg_dau = True : thg_cuoi = False
                Case 21
                    TenFile = "TANGGIAM.RPT"
                    TenBaoCao = Ngonngu("TĂNG TÀI SẢN CỐ ĐỊNH", "ASSETS INCREASING")
                    thg_dau = True : thg_cuoi = True
                Case 22
                    TenFile = "DANHGIA.RPT"
                    TenBaoCao = Ngonngu("ĐÁNH GIÁ LẠI", "ASSETS REVALUATION")
                    thg_dau = True : thg_cuoi = True
                Case 25
                    TenFile = "CHITIET.RPT"
                    TenBaoCao = Ngonngu("CHI TIẾT PHÂN BỔ KHẤU HAO", "DETAIL FOR ALLOCATIONS, DEPRECIATION")
                    thg_dau = True : thg_cuoi = True
                Case 26
                    TenFile = "TONGHOP.RPT"
                    TenBaoCao = Ngonngu("TỔNG HỢP KHẤU HAO", "COMMON FOR ALLOCATIONS, DEPRECIATION")
                    thg_dau = True : thg_cuoi = True
                Case 27
                    TenFile = "NANGLUC.RPT"
                    TenBaoCao = Ngonngu("NĂNG LỰC TÀI SẢN CỐ ĐỊNH", "CAPACITY ASSETS")
                    thg_dau = True : thg_cuoi = False
                Case 28
                    TenFile = "BIENDONG.RPT"
                    TenBaoCao = Ngonngu("TỔNG HỢP BIẾN ĐỘNG TRONG KỲ", "COMMON FLUCTUATION IN PUBLIC")
                    thg_dau = True : thg_cuoi = True
                Case 29
                    TenFile = "BIENDONG.RPT"
                    TenBaoCao = Ngonngu("TỔNG HỢP BIẾN ĐỘNG LŨY KẾ", "COMMON VARIATION ACCUMULATED")
                    thg_dau = False : thg_cuoi = True
                Case 30
                    TenFile = "MIENTRU.RPT"
                    TenBaoCao = Ngonngu("CHI TIẾT TÀI SẢN KHÔNG PHẢI TÍNH KHẤU HAO", "DETAIL OF ASSETS NOT DEPRECIATED")
                    thg_dau = True : thg_cuoi = False
                Case 31
                    TenFile = "BINHQUAN.RPT"
                    TenBaoCao = Ngonngu("BÌNH QUÂN TÀI SẢN CỐ ĐỊNH CẦN TÍNH KHẤU HAO", "AVERAGE OF ASSETS MUST BE DEPRECIATED")
                    thg_dau = True : thg_cuoi = True
                Case 23
                    TenFile = "TANGGIAM.RPT"
                    TenBaoCao = Ngonngu("GIẢM TÀI SẢN", "REDUCE ASSETS")
                    thg_dau = True : thg_cuoi = True
                Case 24
                    TenFile = "DANHGIA.RPT"
                    TenBaoCao = Ngonngu("ĐÍNH GIÁ LẠI", "REVALUATION OF ASSETS")
                    thg_dau = True : thg_cuoi = True
                Case 19, 20
                    thg_dau = False : thg_cuoi = False
                Case 22
                    thg_dau = False : thg_cuoi = True
                Case 45
                    TenFile = "SOTSCD.RPT"
                    TenBaoCao = Ngonngu("SỔ TÀI SẢN CỐ ĐỊNH", "ASSETS BOOK")
                    thg_dau = True : thg_cuoi = False
                Case 68
                    TenFile = "SOTSCD2.RPT"
                    TenBaoCao = Ngonngu("SỔ TÀI SẢN CỐ ĐỊNH", "ASSETS BOOK")
                    thg_dau = True : thg_cuoi = False
                Case 79
                    TenFile = "PBKH.RPT"
                    TenBaoCao = Ngonngu("BẢNG TÍNH VÀ PHÂN BỔ KHẤU HAO TÀI SẢN CỐ ĐỊNH", "SPREADSHEETS AND ALLOCATION OF DEPRECIATION OF ASSETS")
                    thg_dau = True : thg_cuoi = False
                Case Else
                    thg_dau = True : thg_cuoi = True
            End Select
            If thg_dau Then
                Label(0).Enabled = True
                CboThang(0).Enabled = True
            Else
                Label(0).Enabled = False
                CboThang(0).Enabled = False
            End If
            If thg_cuoi Then
                Label(1).Enabled = True
                CboThang(1).Enabled = True
            Else
                Label(1).Enabled = False
                CboThang(1).Enabled = False
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmSotaisan_KeyDown(ByVal eventSender As Object, ByVal eventArgs As KeyEventArgs) Handles MyBase.KeyDown
        'Dim KeyCode As Integer = eventArgs.KeyCode
        Dim Shift As Integer = eventArgs.KeyData \ &H10000
        If (Shift And 4) > 0 Then
            Select Case eventArgs.KeyCode
                Case Keys.X
                    Command(0).Focus()
                    Command_ClickEvent(Command(0), New EventArgs())
                Case Keys.I
                    Command(1).Focus()
                    Command_ClickEvent(Command(1), New EventArgs())
                Case Keys.V
                    Command(2).Focus()
                    Command_ClickEvent(Command(2), New EventArgs())
            End Select
        End If
        If (Shift And 2) > 0 And eventArgs.KeyCode = Keys.P Then
            frmMain.mnHT_Click(frmMain.mnHT, New EventArgs())
        End If
        If eventArgs.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub FrmSotaisan_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        xlapp = Nothing
        xlsheet = Nothing
        MemoryHelper.ReleaseMemory()
    End Sub

    Private chiso1 As Integer = -1
    Private chiso0 As Integer = -1
    Private Sub FrmSotaisan_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'set icon
            Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            AddMonthToCbo(CboThang(0))
            AddMonthToCbo(CboThang(1))
            Int_RecsetToCbo("SELECT Ten AS F1, MaSo as F2 FROM DTQly ORDER BY Ten", Cbo)
            For chi_so As Integer = 1 To 12
                SoLieu(chi_so - 1) = False
            Next
            OptBC_CheckedChanged(OptBC(18), New EventArgs())
            Text = SetFormTitle(Text)
            SetFont(Me)
            If chiso0 <> -1 And _CboThang_0.Items.Count > 0 Then
                _CboThang_0.SelectedIndex = chiso0
            End If
            If chiso1 <> -1 And _CboThang_1.Items.Count > 0 Then
                _CboThang_1.SelectedIndex = chiso1
            End If
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
    Public Sub Command_ClickEvent(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Command_2.Click, _Command_1.Click, _Command_0.Click
        Dim Index As Integer = Array.IndexOf(Command, eventSender)
        Dim tdau, tcuoi As Integer
        Dim tg As String = String.Empty
        Select Case Index
            Case 0, 1
                Me.Cursor = Cursors.WaitCursor
                GauGe.Value = 0
                If CboThang(1).Items.Count > 0 Then
                    If CboThang(0).Enabled And CboThang(1).SelectedIndex < CboThang(0).SelectedIndex Then CboThang(1).SelectedIndex = CboThang(0).SelectedIndex
                End If

                If baocao = 61 Then
                    If CboThang(0).Items.Count > 0 Then CboThang(0).SelectedIndex = 0
                    If CboThang(1).Items.Count > 0 Then CboThang(1).SelectedIndex = 11
                End If
                If CboThang(0).Items.Count > 0 Then tdau = CboThang(0).SelectedValue
                If CboThang(1).Items.Count > 0 Then tcuoi = CboThang(1).SelectedValue

                Select Case baocao
                    Case 71
                        Baocao211(tcuoi)
                        GoTo LoiBC
                    Case 0, 18 To 31, 45, 61, 68, 79
                        If CboThang(0).Enabled And CboThang(1).Enabled Then
                            tg = ThoiGianTheoThang(tdau, tcuoi)
                        Else
                            If CboThang(0).Enabled Then
                                tcuoi = tdau
                            Else
                                tdau = tcuoi
                            End If
                            tg = ThoiGianTheoThang(tdau, tdau)
                        End If
                        ' Chuẩn bị số liệu
                        TinhSoLieuBaoCao()
                        ' Tạo báo cáo
                        Dim reportDataBuild() As String = TaoBaoCao()
                        ' Tên File dữ liệu và báo cáo
                        rptFrom.InitForm(TenFile, reportDataBuild(0), reportDataBuild(1))
                        RptSetDate(NgayCuoiThang(pNamTC, tcuoi))
                        ' Công thức
                        rptFrom.SetFormulas("TenBaoCao", String.Format("'{0}'", TenBaoCao))
                        rptFrom.SetFormulas("ThoiGian", String.Format("'{0}'", tg))
                End Select
                rptFrom.ReportDestination = Index
a:
                If Not RptOK(rptFrom.ReportFilename, 0) Then
                    MessageBox.Show("Mẫu báo cáo đã bị thay đổi!", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    GoTo LoiBC
                End If
                rptFrom.ReportWindowTitle = OptBC(baocao).Text
                rptFrom.ReportWindowState = System.Windows.Forms.FormWindowState.Maximized
                InBaoCaoRPT()
                On Error GoTo Bad
                'frmMain.rpt.Action = 1
                On Error GoTo 0
                GoTo LoiBC
            Case 2
                Me.Close()
        End Select
        GoTo LoiBC
        ErrMsg(er_KoXem)
        GoTo LoiBC
Bad:
        'If Information.Err().Number = 20510 Then
        '    rptFrom.SetFormulas(52, String.Empty)
        '    rptFrom.SetFormulas(53, String.Empty)
        '    rptFrom.SetFormulas(54, String.Empty)
        '    GoTo a
        'End If
        MessageBox.Show(String.Format("Error {0}: {1}", Information.Err().Number, Information.Err().Description), My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
LoiBC:
        HienThongBao(Me.Text, 1)
        GauGe.Value = GauGe.Maximum
        Me.Cursor = Cursors.Default
        rptFrom.ReportDestination = 1
        If _CboThang_1.Items.Count > 0 Then
            chiso1 = _CboThang_1.SelectedIndex
        End If
        If _CboThang_0.Items.Count > 0 Then
            chiso0 = _CboThang_0.SelectedIndex
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tcuoi"></param>
    ''' <remarks></remarks>
    Private Sub Baocao211(ByRef tcuoi As Integer)
        Dim rs As DataTable
        Dim i, j As Integer
        Dim shtk = String.Empty, shpl As String = String.Empty
        Dim T(7) As Double
        Dim ncuoi As Date = NgayCuoiThang(pNamTC, tcuoi)
        Recycle(String.Format("{0}\temp\211.XLS", pCurDir))
        On Error GoTo KetThuc
        File.Copy(String.Format("{0}REPORTS\211.XLS", pCurDir), String.Format("{0}\temp\211.XLS", pCurDir))
        xlapp = New Excel.Application()
        xlapp.Workbooks.Open(String.Format("{0}\temp\211.XLS", pCurDir))
        On Error GoTo 0
        xlsheet = xlapp.Worksheets(1)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(4, 1) = String.Format("Đến 0h ngày : {0}", Format(ncuoi.AddDays(1), Mask_DB))
        Dim SoDuDauCuoiKy As String = String.Format("SELECT DISTINCT TaiSan.Ten AS TenTS, TaiSan.SoHieu AS SoHieuTS, LoaiTaiSan.SoHieu AS SoHieuTK, LoaiTaiSan.MaSo AS MaTK, LoaiTaiSan.Ten AS TenTK, ThongSo.NG_NS, ThongSo.NG_TBS, ThongSo.NG_CNK, ThongSo.NG_TD, ThongSo.CL_NS, ThongSo.CL_TBS, ThongSo.CL_CNK, ThongSo.CL_TD,LoaiTaiSan_1.SoHieu,LoaiTaiSan_1.Ten FROM LoaiTaiSan AS LoaiTaiSan_1 RIGHT JOIN ((LoaiTaiSan RIGHT JOIN TaiSan ON LoaiTaiSan.MaSo = TaiSan.MaTaiKhoan) RIGHT JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS) ON LoaiTaiSan_1.MaSo=TaiSan.MaLoai WHERE {0} AND {1} AND ThongSo.Thang = {2} ORDER BY TaiSan.SoHieu", _
                                          WThang("ThangTang", 0, tcuoi), _
                                          WThang2("ThangGiam", tcuoi, 0), _
                                          ConvertToStrSafe(CThangDB2(tcuoi)))
        rs = ExecSQLReturnDT(SoDuDauCuoiKy)
        Dim rsIndex As Integer = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
a:
            If shtk <> rsItem("sohieutk") Then
                shtk = rsItem("sohieutk")
                xlsheet.Cells(9 + i, 2) = rsItem("tentk")
                xlsheet.Cells(9 + i, 3) = shtk
                xlsheet.Range(String.Format("A{0}", 9 + i), String.Format("AE{0}", 9 + i)).Font.Bold = True
                xlsheet.Cells(9 + i, 7) = rsItem("NG_NS")
                xlsheet.Cells(9 + i, 8) = rsItem("NG_TBS")
                xlsheet.Cells(9 + i, 9) = rsItem("NG_TD")
                xlsheet.Cells(9 + i, 10) = rsItem("NG_CNK")
                If rsItem("NG_NS") IsNot Nothing Then
                    T(0) += rsItem("NG_NS")
                End If
                If rsItem("NG_TBS") IsNot Nothing Then
                    T(1) += rsItem("NG_TBS")
                End If
                If rsItem("NG_TD") IsNot Nothing Then
                    T(2) += rsItem("NG_TD")
                End If
                If rsItem("NG_CNK") IsNot Nothing Then
                    T(3) += rsItem("NG_CNK")
                End If

                xlsheet.Range(String.Format("F{0}", 9 + i)).Formula = String.Format("=SUM(G{0}:J{1})", _
                                                         9 + i, _
                                                         ConvertToStrSafe(9 + i)) 'Excel Fomular
                xlsheet.Cells(9 + i, 12) = rsItem("CL_NS")
                xlsheet.Cells(9 + i, 13) = rsItem("CL_TBS")
                xlsheet.Cells(9 + i, 14) = rsItem("CL_TD")
                xlsheet.Cells(9 + i, 15) = rsItem("CL_CNK")
                If rsItem("CL_NS") IsNot Nothing Then
                    T(4) += rsItem("CL_NS")
                End If
                If rsItem("CL_TBS") IsNot Nothing Then
                    T(5) += rsItem("CL_TBS")
                End If
                If rsItem("CL_TD") IsNot Nothing Then
                    T(6) += rsItem("CL_TD")
                End If
                If rsItem("CL_CNK") IsNot Nothing Then
                    T(7) += rsItem("CL_CNK")
                End If

                xlsheet.Range(String.Format("K{0}", 9 + i)).Formula = String.Format("=SUM(L{0}:O{1})", _
                                                         9 + i, _
                                                         ConvertToStrSafe(9 + i)) 'Excel Fomular
                i += 1
                GoTo a
            End If
            If shpl <> rsItem("SoHieu") Then
                shpl = rsItem("SoHieu")
                xlsheet.Cells(9 + i, 2) = rsItem("ten")
                xlsheet.Cells(9 + i, 3) = rsItem("SoHieu")
                xlsheet.Range(String.Format("A{0}", 9 + i), String.Format("AE{0}", 9 + i)).Font.Bold = True
                xlsheet.Range(String.Format("A{0}", 9 + i), String.Format("AE{0}", 9 + i)).Font.Italic = True
                xlsheet.Cells(9 + i, 7) = rsItem("NG_NS")
                xlsheet.Cells(9 + i, 8) = rsItem("NG_TBS")
                xlsheet.Cells(9 + i, 9) = rsItem("NG_TD")
                xlsheet.Cells(9 + i, 10) = rsItem("NG_CNK")
                xlsheet.Range(String.Format("F{0}", 9 + i)).Formula = String.Format("=SUM(G{0}:J{1})", 9 + i, ConvertToStrSafe(9 + i)) 'Excel Fomular
                xlsheet.Cells(9 + i, 12) = rsItem("CL_NS")
                xlsheet.Cells(9 + i, 13) = rsItem("CL_TBS")
                xlsheet.Cells(9 + i, 14) = rsItem("CL_TD")
                xlsheet.Cells(9 + i, 15) = rsItem("CL_CNK")
                xlsheet.Range(String.Format("K{0}", 9 + i)).Formula = String.Format("=SUM(L{0}:O{1})", 9 + i, ConvertToStrSafe(9 + i)) 'Excel Fomular
                i += 1
                GoTo a
            End If
            ''rs.MoveNext()
        Loop
        xlsheet.Range(String.Format("A{0}", 10 + i), String.Format("AE{0}", 10 + i)).Font.Bold = True
        xlsheet.Cells(10 + i, 2) = "Tổng cộng"
        xlsheet.Range(String.Format("F{0}", 10 + i)).Formula = String.Format("=SUM(G{0}:J{1})", 10 + i, ConvertToStrSafe(10 + i)) 'Excel Fomular
        xlsheet.Cells(10 + i, 7) = T(0)
        xlsheet.Cells(10 + i, 8) = T(1)
        xlsheet.Cells(10 + i, 9) = T(2)
        xlsheet.Cells(10 + i, 10) = T(3)
        xlsheet.Range(String.Format("K{0}", 10 + i)).Formula = String.Format("=SUM(L{0}:O{1})", 10 + i, ConvertToStrSafe(10 + i)) 'Excel Fomular
        xlsheet.Cells(10 + i, 12) = T(4)
        xlsheet.Cells(10 + i, 13) = T(5)
        xlsheet.Cells(10 + i, 14) = T(6)
        xlsheet.Cells(10 + i, 15) = T(7)
        With xlsheet.Range("A6", String.Format("AE{0}", 10 + i))
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders.Weight = Excel.XlBorderWeight.xlThin
            Dim tempRefParam As Object = .Borders.Color
            tempRefParam = Color.FromArgb(0, 0, 0)
            Dim tempRefParam2 As Object = .RowHeight
            tempRefParam2 = 18
            Dim tempRefParam3 As Object = .VerticalAlignment
            tempRefParam3 = Excel.XlVAlign.xlVAlignCenter
        End With
        XLSFooter(xlsheet, 12 + i, 31, NgayCuoiThang(pNamTC, tcuoi))
        For i = 1 To 8
            T(i - 1) = 0
        Next
        i = 0
        j = 0
        shtk = ""
        shpl = ""
        xlsheet = xlapp.Worksheets(2)
        xlsheet.Cells(1, 1) = String.Format("{0} - {1}", pTenCty, pTenCn)
        xlsheet.Cells(4, 1) = String.Format("Đến 0h ngày : {0}", Format(ncuoi.AddDays(1), Mask_DB))
        rs = ExecSQLReturnDT("SoDuDauCuoiKy")
        rsIndex = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
B:
            i += 1
            If shtk <> rsItem("sohieutk") Then
                shtk = rsItem("sohieutk")
                xlsheet.Cells(9 + i, 2) = rsItem("tentk")
                xlsheet.Cells(9 + i, 3) = shtk
                xlsheet.Range(String.Format("A{0}", 9 + i), String.Format("AE{0}", 9 + i)).Font.Bold = True
                xlsheet.Cells(9 + i, 7) = rsItem("NG_NS")
                xlsheet.Cells(9 + i, 8) = rsItem("NG_TBS")
                xlsheet.Cells(9 + i, 9) = rsItem("NG_TD")
                xlsheet.Cells(9 + i, 10) = rsItem("NG_CNK")
                xlsheet.Range(String.Format("F{0}", 9 + i)).Formula = String.Format("=SUM(G{0}:J{1})", 9 + i, ConvertToStrSafe(9 + i)) 'Excel Fomular
                xlsheet.Cells(9 + i, 12) = rsItem("CL_NS")
                xlsheet.Cells(9 + i, 13) = rsItem("CL_TBS")
                xlsheet.Cells(9 + i, 14) = rsItem("CL_TD")
                xlsheet.Cells(9 + i, 15) = rsItem("CL_CNK")
                xlsheet.Range(String.Format("K{0}", 9 + i)).Formula = String.Format("=SUM(L{0}:O{1})", 9 + i, ConvertToStrSafe(9 + i)) 'Excel Fomular
                If rsItem("NG_NS") IsNot Nothing Then
                    T(0) += rsItem("NG_NS")
                End If
                If rsItem("NG_TBS") IsNot Nothing Then
                    T(1) += rsItem("NG_TBS")
                End If
                If rsItem("NG_TD") IsNot Nothing Then
                    T(2) += rsItem("NG_TD")
                End If
                If rsItem("NG_CNK") IsNot Nothing Then
                    T(3) += rsItem("NG_CNK")
                End If
                If rsItem("CL_NS") IsNot Nothing Then
                    T(4) += rsItem("CL_NS")
                End If
                If rsItem("CL_TBS") IsNot Nothing Then
                    T(5) += rsItem("CL_TBS")
                End If
                If rsItem("CL_TD") IsNot Nothing Then
                    T(6) += rsItem("CL_TD")
                End If
                If rsItem("CL_CNK") IsNot Nothing Then
                    T(7) += rsItem("CL_CNK")
                End If
                GoTo B
            End If
            If shpl <> rsItem("SoHieu") Then
                shpl = rsItem("SoHieu")
                xlsheet.Cells(9 + i, 2) = rsItem("ten")
                xlsheet.Cells(9 + i, 3) = rsItem("SoHieu")
                xlsheet.Range(String.Format("A{0}", 9 + i), String.Format("AE{0}", 9 + i)).Font.Bold = True
                xlsheet.Range(String.Format("A{0}", 9 + i), String.Format("AE{0}", 9 + i)).Font.Italic = True
                xlsheet.Cells(9 + i, 7) = rsItem("NG_NS")
                xlsheet.Cells(9 + i, 8) = rsItem("NG_TBS")
                xlsheet.Cells(9 + i, 9) = rsItem("NG_TD")
                xlsheet.Cells(9 + i, 10) = rsItem("NG_CNK")
                xlsheet.Range(String.Format("F{0}", 9 + i)).Formula = String.Format("=SUM(G{0}:J{1})", 9 + i, ConvertToStrSafe(9 + i)) 'Excel Fomular
                xlsheet.Cells(9 + i, 12) = rsItem("CL_NS")
                xlsheet.Cells(9 + i, 13) = rsItem("CL_TBS")
                xlsheet.Cells(9 + i, 14) = rsItem("CL_TD")
                xlsheet.Cells(9 + i, 15) = rsItem("CL_CNK")
                xlsheet.Range(String.Format("K{0}", 9 + i)).Formula = String.Format("=SUM(L{0}:O{1})", 9 + i, ConvertToStrSafe(9 + i)) 'Excel Fomular
                GoTo B
            End If
            j += 1
            xlsheet.Cells(9 + i, 1) = ConvertToStrSafe(j)
            xlsheet.Cells(9 + i, 2) = rsItem("TenTS")
            xlsheet.Cells(9 + i, 3) = rsItem("SoHieuTS")
            xlsheet.Cells(9 + i, 7) = rsItem("NG_NS")
            xlsheet.Cells(9 + i, 8) = rsItem("NG_TBS")
            xlsheet.Cells(9 + i, 9) = rsItem("NG_TD")
            xlsheet.Cells(9 + i, 10) = rsItem("NG_CNK")
            xlsheet.Range(String.Format("F{0}", 9 + i)).Formula = String.Format("=SUM(G{0}:J{1})", 9 + i, ConvertToStrSafe(9 + i)) 'Excel Fomular
            xlsheet.Cells(9 + i, 12) = rsItem("CL_NS")
            xlsheet.Cells(9 + i, 13) = rsItem("CL_TBS")
            xlsheet.Cells(9 + i, 14) = rsItem("CL_TD")
            xlsheet.Cells(9 + i, 15) = rsItem("CL_CNK")
            xlsheet.Range(String.Format("K{0}", 9 + i)).Formula = String.Format("=SUM(L{0}:O{1})", 9 + i, ConvertToStrSafe(9 + i)) 'Excel Fomular
            ''rs.MoveNext()
        Loop
        xlsheet.Range(String.Format("A{0}", 10 + i), String.Format("AE{0}", 10 + i)).Font.Bold = True
        xlsheet.Cells(10 + i, 2) = "Tổng cộng"
        xlsheet.Range(String.Format("F{0}", 10 + i)).Formula = String.Format("=SUM(G{0}:J{1})", 10 + i, ConvertToStrSafe(10 + i)) 'Excel Fomular
        xlsheet.Cells(10 + i, 7) = T(0)
        xlsheet.Cells(10 + i, 8) = T(1)
        xlsheet.Cells(10 + i, 9) = T(2)
        xlsheet.Cells(10 + i, 10) = T(3)
        xlsheet.Range(String.Format("K{0}", 10 + i)).Formula = String.Format("=SUM(L{0}:O{1})", 10 + i, ConvertToStrSafe(10 + i)) 'Excel Fomular
        xlsheet.Cells(10 + i, 12) = T(4)
        xlsheet.Cells(10 + i, 13) = T(5)
        xlsheet.Cells(10 + i, 14) = T(6)
        xlsheet.Cells(10 + i, 15) = T(7)
        With xlsheet.Range("A6", String.Format("AE{0}", 10 + i))
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders.Weight = Excel.XlBorderWeight.xlThin
            Dim tempRefParam4 As Object = .Borders.Color
            tempRefParam4 = Color.FromArgb(0, 0, 0)
            Dim tempRefParam5 As Object = .RowHeight
            tempRefParam5 = 18
            Dim tempRefParam6 As Object = .VerticalAlignment
            tempRefParam6 = Excel.XlVAlign.xlVAlignCenter
        End With
        XLSFooter(xlsheet, 12 + i, 31, NgayCuoiThang(pNamTC, tcuoi))
        ''rs.Close()
        rs = Nothing
        xlapp.Workbooks(1).Save()
        xlapp.Workbooks.Close()
        CallExcel("\temp\211.XLS")
KetThuc:
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Function TaoBaoCao() As String()
        Dim thg_dau, thg_cuoi As Integer
        'Dim thg_dau, thg_cuoi As Integer
        Dim wsql As String = String.Empty
        If Opt(0).Checked And baocao <> 28 And baocao <> 29 And Strings.Len(txtShTS.Text) > 0 Then wsql = String.Format(" AND (TaiSan.SoHieu LIKE '{0}%') ", txtShTS.Text)
        If Opt(1).Checked Then wsql = String.Format(" AND (ThongSo.MaDTQL = {0}) ", Cbo.SelectedValue)
        If CboThang(0).Enabled Then thg_dau = CboThang(0).SelectedValue
        If CboThang(1).Enabled Then thg_cuoi = CboThang(1).SelectedValue

        Dim QChitiet As String = String.Empty
        Dim MienTru As String = String.Empty
        Dim SoDuDauCuoiKy As String = String.Empty
        Dim QNhatKy As String = String.Empty
        Dim SoKhauHao As String = String.Empty

        Dim returnQuery As String = String.Empty
        Dim returnTableName As String = String.Empty

        Select Case baocao
            Case 0
                QChitiet = String.Format("SELECT * FROM CTTaiSan WHERE {0} AND MaLoai=33", WThang("Thang", 0, thg_dau))
                MienTru = String.Format("SELECT DISTINCT TaiSan.maso as masots,TaiSan.SoHieu AS SoHieuTS, TaiSan.Ten AS TenTS,quocgia.ten as nuoc,taisan.namsx as namsx,thongso.madtql as ql,taisan.namsd as namsd,taisan.nangluc as nangluc,taisan.shct,taisan.nct as ngayct, taisan.namkh as namkh, (ThongSo.KH_NS+ThongSo.KH_TBS+ThongSo.KH_CNK+ThongSo.KH_TD) AS KH, (ThongSo.CL_NS+ThongSo.CL_TBS+ThongSo.CL_CNK+ThongSo.CL_TD) AS CL, (QChitiet.NG_NS+QChitiet.NG_TBS+QChitiet.NG_TD+QChitiet.NG_CNK-QChitiet.CL_NS-QChitiet.CL_TBS-QChitiet.CL_TD-QChitiet.CL_CNK) AS SoDaKH FROM ((TaiSan inner join quocgia on taisan.manuoc=quocgia.maso) inner join ThongSo ON TaiSan.MaSo = ThongSo.MaTS) left join ({0}) AS Qchitiet on taisan.maso=qchitiet.mats WHERE {1} AND {2} AND ThongSo.Thang >= {3} AND ThongSo.Thang <= {3}", _
                              QChitiet, _
                              WThang("ThangTang", 0, thg_dau), _
                              WThang("ThangGiam", thg_dau, 0), _
                              ConvertToStrSafe(CThangDB2(thg_dau)))
                SoDuDauCuoiKy = String.Format("SELECT mientru.*,cttaisan.DienGiai as DienGiai,(cttaisan.NG_NS + cttaisan.NG_TBS + cttaisan.NG_CNK + cttaisan.NG_TD) AS NG,DTQLy.ten as tenql FROM (({0}) AS  mientru inner join cttaisan on mientru.masots=cttaisan.mats)inner join DTQLy on mientru.ql=DTQLy.maso WHERE cttaisan.ng_ns>=0 AND cttaisan.ng_tbs>=0 AND cttaisan.ng_cnk>=0 AND cttaisan.ng_td>=0", MienTru)
                QNhatKy = String.Format("SELECT Distinct SoDuDauCuoiKy.masots,cttaisan.ngayghi as ngaygiamts,cttaisan.DienGiai as lydogiamts,loaichungtu.ten as lydogiamts1,chungtu.sohieu as soctgiam FROM (({0}) AS SoDuDauCuoiKy inner join (cttaisan inner join loaichungtu on cttaisan.manhom=loaichungtu.maso) on SoDuDauCuoiKy.masots=cttaisan.mats) inner join chungtu on chungtu.mact=cttaisan.mactkt WHERE cttaisan.ng_ns<0 or cttaisan.ng_tbs<0 or cttaisan.ng_cnk<0 or cttaisan.ng_td<0", SoDuDauCuoiKy)
                'looi
                returnQuery = String.Format("SELECT SoDuDauCuoiKy.*,qnhatky.* FROM ({0}) as SoDuDauCuoiKy left join ({1}) AS qnhatky on SoDuDauCuoiKy.masots=qnhatky.masots", SoDuDauCuoiKy, QNhatKy)
                returnTableName = "SoKhauHao"
            Case 61
                returnQuery = String.Format("SELECT DISTINCT TaiSan.SoHieu AS SoHieuTS, (TaiSan.Ten) AS TenTS, (LoaiTaiSan.SoHieu) AS SoHieuTK, (LoaiTaiSan.MaSo) AS MaTK, (LoaiTaiSan.Ten) AS TenTK, (TaiSan.NamKH) AS SoNamKH,(NG_NS+NG_TBS+NG_CNK+NG_TD) AS NG, Sum(CASE WHEN Thang=1 AND ThangGiam>={0} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH1, Sum(CASE WHEN Thang=2 AND ThangGiam>={1} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH2, Sum(CASE WHEN Thang=3 AND ThangGiam>={2} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH3, Sum(CASE WHEN Thang=4 AND ThangGiam>={3} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH4, Sum(CASE WHEN Thang=5 AND ThangGiam>={4} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH5, Sum(CASE WHEN Thang=6 AND ThangGiam>={5} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH6, Sum(CASE WHEN  Thang=7 AND ThangGiam>={6} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH7, Sum(CASE WHEN Thang=8 AND ThangGiam>={7} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH8, Sum(CASE WHEN Thang=9 AND ThangGiam>={8} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH9, Sum(CASE WHEN Thang=10 AND ThangGiam>={9} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH10, Sum(CASE WHEN Thang=11 AND ThangGiam>={10} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH11, Sum(CASE WHEN Thang=12 AND ThangGiam>={11} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH12 FROM (LoaiTaiSan RIGHT JOIN TaiSan ON LoaiTaiSan.MaSo = TaiSan.maloai) RIGHT JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS WHERE 1 = 1 {12} GROUP BY TaiSan.SoHieu,TaiSan.Ten,LoaiTaiSan.SoHieu,LoaiTaiSan.MaSo,LoaiTaiSan.Ten,TaiSan.NamKH,ThongSo.NG_NS,ThongSo.NG_TBS,ThongSo.NG_CNK,ThongSo.NG_TD", _
                                CThangFR(1), _
                                CThangFR(2), _
                                CThangFR(3), _
                                CThangFR(4), _
                                CThangFR(5), _
                                CThangFR(6), _
                                CThangFR(7), _
                                CThangFR(8), _
                                CThangFR(9), _
                                CThangFR(10), _
                                CThangFR(11), _
                                CThangFR(12), _
                                wsql)
                returnTableName = "SoKhauHao"
            Case 89 ' Sổ phân bổ OK
                Dim SoKhauHao142_153 As String = String.Format("SELECT DISTINCT Congcudungcu.maso as MaSoTS,Congcudungcu.SoHieu AS SoHieuTS, (Congcudungcu.Ten) AS TenTS, (LoaiCongcudungcu.SoHieu) AS SoHieuTK, (LoaiCongcudungcu.MaSo) AS MaTK, (LoaiCongcudungcu.Ten) AS TenTK, (Congcudungcu.NamKH) AS SoNamKH,(NG_NS+NG_TBS+NG_CNK+NG_TD) AS NG,(CL_NS+CL_TBS+CL_CNK+CL_TD) AS CL, (LoaiCongcudungcu_1.SoHieu) AS SHLoai,(LoaiCongcudungcu_1.Ten) AS TenLoai, Max(CASE WHEN Thang=1 AND ThangGiam>={0} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH1, Max(CASE WHEN Thang=2 AND ThangGiam>={1} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH2, Max(CASE WHEN Thang=3 AND ThangGiam>={2} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH3, Max(CASE WHEN Thang=4 AND ThangGiam>={3} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH4, Max(CASE WHEN Thang=5 AND ThangGiam>={4} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH5, Max(CASE WHEN Thang=6 AND ThangGiam>={5} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH6, Max(CASE WHEN Thang=7 AND ThangGiam>={6} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH7, Max(CASE WHEN Thang=8 AND ThangGiam>={7} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH8, Max(CASE WHEN Thang=9 AND ThangGiam>={8} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH9, Max(CASE WHEN Thang=10 AND ThangGiam>={9} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH10, Max(CASE WHEN Thang=11 AND ThangGiam>={10} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH11, Max(CASE WHEN Thang=12 AND ThangGiam>={11} THEN KH_NS+KH_TBS+KH_CNK+KH_TD ELSE 0 END) AS KH12 FROM LoaiCongcudungcu AS LoaiCongcudungcu_1 RIGHT JOIN ((LoaiCongcudungcu RIGHT JOIN Congcudungcu ON LoaiCongcudungcu.MaSo = Congcudungcu.MaTaiKhoan) RIGHT JOIN (ThongSo1 inner join chungtu on thongso1.thang=chungtu.thangct and thongso1.madtsd=chungtu.matktcno) ON Congcudungcu.MaSo = ThongSo1.MaTS) ON LoaiCongcudungcu_1.MaSo=Congcudungcu.MaLoai WHERE {13} and chungtu.maloai=14 GROUP BY Congcudungcu.maso,Congcudungcu.SoHieu, Congcudungcu.MaTaiKhoan,Congcudungcu.MaLoai,Congcudungcu.Ten,LoaiCongcudungcu.SoHieu,LoaiCongcudungcu.MaSo,LoaiCongcudungcu.Ten,Congcudungcu.NamKH,ThongSo1.ng_ns,ThongSo1.ng_tbs,ThongSo1.ng_cnk,ThongSo1.ng_td,ThongSo1.cl_ns,ThongSo1.cl_tbs,ThongSo1.cl_cnk,ThongSo1.cl_td,LoaiCongcudungcu_1.SoHieu,LoaiCongcudungcu_1.Ten", _
                                                    CThangFR(1), _
                                                    CThangFR(2), _
                                                    CThangFR(3), _
                                                    CThangFR(4), _
                                                    CThangFR(5), _
                                                    CThangFR(6), _
                                                    CThangFR(7), _
                                                    CThangFR(8), _
                                                    CThangFR(9), _
                                                    CThangFR(10), _
                                                    CThangFR(11), _
                                                    CThangFR(12), _
                                                    wsql)
                Dim Sodudaunam142_153 As String = "SELECT DISTINCT Congcudungcu.Maso AS MaSoTS, (CASE WHEN kh_ns+kh_tbs+kh_cnk+kh_td=0 and (cl_ns+cl_tbs+cl_cnk+cl_td)<(ng_ns+ng_tbs+ng_cnk+ng_td) THEN cl_ns+cl_tbs+cl_cnk+cl_td ELSE 0 END)as daunam FROM LoaiCongcudungcu AS LoaiCongcudungcu_1 RIGHT JOIN ((LoaiCongcudungcu RIGHT JOIN Congcudungcu ON LoaiCongcudungcu.MaSo = Congcudungcu.MaTaiKhoan) RIGHT JOIN ThongSo1 ON Congcudungcu.MaSo = ThongSo1.MaTS) ON LoaiCongcudungcu_1.MaSo=Congcudungcu.MaLoai WHERE thang=0 GROUP BY Congcudungcu.maso,Congcudungcu.SoHieu, Congcudungcu.MaTaiKhoan, Congcudungcu.MaLoai,ThongSo1.kh_ns,ThongSo1.kh_tbs,ThongSo1.kh_cnk,ThongSo1.kh_td,ThongSo1.cl_ns,ThongSo1.cl_tbs,ThongSo1.cl_cnk,ThongSo1.cl_td,ThongSo1.ng_ns,ThongSo1.ng_tbs,ThongSo1.ng_cnk,ThongSo1.ng_td,ThongSo1.cl_ns,ThongSo1.cl_tbs,ThongSo1.cl_cnk,ThongSo1.cl_td"
                SoKhauHao = String.Format("SELECT DISTINCT sokhauhao142_153.MaSoTS,sokhauhao142_153.SoHieuTS,sokhauhao142_153.TenTS,sokhauhao142_153.SoHieuTK,sokhauhao142_153.MaTK,sokhauhao142_153.TenTK,sokhauhao142_153.SoNamKH,sokhauhao142_153.NG,sokhauhao142_153.CL,sokhauhao142_153.SHLoai,sokhauhao142_153.TenLoai,sokhauhao142_153.KH1,sokhauhao142_153.KH2,sokhauhao142_153.KH3,sokhauhao142_153.KH4,sokhauhao142_153.KH5,sokhauhao142_153.KH6, sokhauhao142_153.KH7,sokhauhao142_153.KH8,sokhauhao142_153.KH9,sokhauhao142_153.KH10,sokhauhao142_153.KH11,sokhauhao142_153.KH12,sodudaunam142_153.MaSoTS,sodudaunam142_153.daunam FROM ({0}) AS sokhauhao142_153 left join ({1}) AS sodudaunam142_153 on sokhauhao142_153.masots=sodudaunam142_153.masots group by sokhauhao142_153.MaSoTS,sokhauhao142_153.SoHieuTS,sokhauhao142_153.TenTS,sokhauhao142_153.SoHieuTK,sokhauhao142_153.MaTK,sokhauhao142_153.TenTK,sokhauhao142_153.SoNamKH,sokhauhao142_153.NG,sokhauhao142_153.CL,sokhauhao142_153.SHLoai,sokhauhao142_153.TenLoai,sokhauhao142_153.KH1,sokhauhao142_153.KH2,sokhauhao142_153.KH3,sokhauhao142_153.KH4,sokhauhao142_153.KH5,sokhauhao142_153.KH6, sokhauhao142_153.KH7,sokhauhao142_153.KH8,sokhauhao142_153.KH9,sokhauhao142_153.KH10,sokhauhao142_153.KH11,sokhauhao142_153.KH12,sodudaunam142_153.MaSoTS,sodudaunam142_153.daunam ", _
                                SoKhauHao142_153, _
                                Sodudaunam142_153)
                returnQuery = SoKhauHao
                returnTableName = "SoKhauHao"
            Case 18 ' Sổ khấu hao OK
                SoKhauHao = String.Format("SELECT DISTINCT TaiSan.SoHieu AS SoHieuTS, (TaiSan.Ten) AS TenTS, (LoaiTaiSan.SoHieu) AS SoHieuTK, (LoaiTaiSan.MaSo) AS MaTK, (LoaiTaiSan.Ten) AS TenTK, (ThongSo.NG_NS) AS NG_NS, (ThongSo.NG_TBS) AS NG_TBS, (ThongSo.NG_CNK) AS NG_CNK, (ThongSo.NG_TD) AS NG_TD, Sum(ThongSo.KH_NS) AS KH_NS, Sum(ThongSo.KH_TBS) AS KH_TBS, Sum(ThongSo.KH_CNK) AS KH_CNK, Sum(ThongSo.KH_TD) AS KH_TD FROM (LoaiTaiSan RIGHT JOIN TaiSan ON LoaiTaiSan.MaSo = TaiSan.Maloai) RIGHT JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS WHERE {0} AND {1} AND ThongSo.Thang >= {2} AND ThongSo.Thang <= {3}{4} GROUP BY TaiSan.SoHieu,TaiSan.Ten,LoaiTaiSan.SoHieu,LoaiTaiSan.MaSo,LoaiTaiSan.Ten,ThongSo.NG_NS,ThongSo.NG_TBS,ThongSo.NG_CNK,ThongSo.NG_TD", _
                                WThang("ThangTang", 0, thg_cuoi), _
                                WThang("ThangGiam", thg_dau, 0), _
                                ConvertToStrSafe(CThangDB2(thg_dau)), _
                                ConvertToStrSafe(CThangDB2(thg_cuoi)), _
                                wsql)
                returnQuery = SoKhauHao
                returnTableName = "SoKhauHao"
            Case 19 ' Số dư đầu kỳ  OK
                SoDuDauCuoiKy = String.Format("SELECT DISTINCT TaiSan.Ten AS TenTS, TaiSan.SoHieu AS SoHieuTS, LoaiTaiSan.SoHieu AS SoHieuTK, LoaiTaiSan.MaSo AS MaTK, LoaiTaiSan.Ten AS TenTK, ThongSo.NG_NS, ThongSo.NG_TBS, ThongSo.NG_CNK, ThongSo.NG_TD, ThongSo.CL_NS, ThongSo.CL_TBS, ThongSo.CL_CNK, ThongSo.CL_TD FROM (LoaiTaiSan RIGHT JOIN TaiSan ON LoaiTaiSan.MaSo = TaiSan.Maloai) RIGHT JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS WHERE {0} AND {1} AND ThongSo.Thang = {2}{3} ORDER BY TaiSan.SoHieu", _
                                    WThang("ThangTang", 0, ThangTruoc(thg_dau)), _
                                    WThang("ThangGiam", thg_dau, 0), _
                                    ConvertToStrSafe(CThangDB2(ThangTruoc(thg_dau))), _
                                    wsql)
                returnQuery = SoDuDauCuoiKy
                returnTableName = "SoDuDauCuoiKy"
            Case 20 ' Số dư cuối kỳ OK
                SoDuDauCuoiKy = String.Format("SELECT DISTINCT TaiSan.Ten AS TenTS, TaiSan.SoHieu AS SoHieuTS, LoaiTaiSan.SoHieu AS SoHieuTK, LoaiTaiSan.MaSo AS MaTK, LoaiTaiSan.Ten AS TenTK, ThongSo.NG_NS, ThongSo.NG_TBS, ThongSo.NG_CNK, ThongSo.NG_TD, ThongSo.CL_NS, ThongSo.CL_TBS, ThongSo.CL_CNK, ThongSo.CL_TD FROM (LoaiTaiSan RIGHT JOIN TaiSan ON LoaiTaiSan.MaSo = TaiSan.Maloai) RIGHT JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS WHERE {0}  AND ThongSo.Thang = {2}{3} ORDER BY TaiSan.SoHieu", _
                                    WThang("ThangTang", 0, thg_dau), _
                                    WThang2("ThangGiam", thg_dau, 0), _
                                    ConvertToStrSafe(CThangDB2(thg_dau)), _
                                    wsql)
                returnQuery = SoDuDauCuoiKy
                returnTableName = "SoDuDauCuoiKy"
            Case 45 ' Sổ TSCĐ OK
                MienTru = "SELECT * FROM CTTaiSan WHERE (Thang=0 AND MaLoai=30)"
                SoDuDauCuoiKy = String.Format("SELECT DISTINCT TaiSan.Ten AS TenTS, TaiSan.SoHieu AS SoHieuTS,NangLuc,TaiSan.GhiChu,ThangTang,NamSX,NamSD, LoaiTaiSan.SoHieu AS SoHieuTK, LoaiTaiSan.MaSo AS MaTK, LoaiTaiSan.Ten AS TenTK, HethongTK.SoHieu AS DTCP,DTQLy.Ten AS DTQL,ThongSo.NG_NS, ThongSo.NG_TBS, ThongSo.NG_CNK, ThongSo.NG_TD, ThongSo.CL_NS, ThongSo.CL_TBS, ThongSo.CL_CNK, ThongSo.CL_TD,ThongSo.KH_NS, ThongSo.KH_TBS, ThongSo.KH_CNK, ThongSo.KH_TD,(MienTru.NG_NS+MienTru.NG_TBS+MienTru.NG_TD+MienTru.NG_CNK-MienTru.CL_NS-MienTru.CL_TBS-MienTru.CL_TD-MienTru.CL_CNK) AS CLDK FROM ((((LoaiTaiSan RIGHT JOIN TaiSan ON LoaiTaiSan.MaSo = TaiSan.Maloai) RIGHT JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS) INNER JOIN DTQLy ON ThongSo.MaDTQL=DTQLy.MaSo) INNER JOIN HethongTK ON ThongSo.MaDTSD=HethongTK.MaSo) LEFT JOIN ({0}) as  MienTru ON TaiSan.MaSo=MienTru.MaTS WHERE {1}  AND ThongSo.Thang = {2} ORDER BY TaiSan.SoHieu", MienTru, WThang("ThangTang", 0, thg_dau), ConvertToStrSafe(CThangDB2(thg_dau)), wsql)
                returnQuery = SoDuDauCuoiKy
                returnTableName = "SoDuDauCuoiKy"
            Case 90 ' Sổ CCDC  OK
                MienTru = "SELECT * FROM CTCongcudungcu WHERE (Thang=0 AND MaLoai=30)"
                Dim Mientru1 As String = String.Format("SELECT DISTINCT Congcudungcu.Ten AS TenTS, Congcudungcu.SoHieu AS SoHieuTS,NangLuc,Congcudungcu.GhiChu,ThangTang,NamSX,NamSD, LoaiCongcudungcu.SoHieu AS SoHieuTK, LoaiCongcudungcu.MaSo AS MaTK, LoaiCongcudungcu.Ten AS TenTK, HethongTK.SoHieu AS DTCP,Thongso1.NG_NS, Thongso1.NG_TBS, Thongso1.NG_CNK, Thongso1.NG_TD, Thongso1.CL_NS, Thongso1.CL_TBS, Thongso1.CL_CNK, Thongso1.CL_TD,Thongso1.KH_NS, Thongso1.KH_TBS, Thongso1.KH_CNK, Thongso1.KH_TD,LoaiCongcudungcu_1.SoHieu,LoaiCongcudungcu_1.Ten, (MienTru.NG_NS+MienTru.NG_TBS+MienTru.NG_TD+MienTru.NG_CNK-MienTru.CL_NS-MienTru.CL_TBS-MienTru.CL_TD-MienTru.CL_CNK) AS CLDK,congcudungcu.shct,congcudungcu.nct FROM ((LoaiCongcudungcu AS LoaiCongcudungcu_1 RIGHT JOIN ((LoaiCongcudungcu RIGHT JOIN Congcudungcu ON LoaiCongcudungcu.MaSo = Congcudungcu.MaTaiKhoan) RIGHT JOIN Thongso1 ON Congcudungcu.MaSo = Thongso1.MaTS) ON LoaiCongcudungcu_1.MaSo=Congcudungcu.MaLoai) INNER JOIN HethongTK ON Thongso1.MaDTSD=HethongTK.MaSo) LEFT JOIN ({0}) MienTru ON Congcudungcu.MaSo=MienTru.MaTS WHERE {1}  AND Thongso1.Thang = {3}{4} ORDER BY Congcudungcu.SoHieu", _
                                             MienTru, _
                                             WThang("ThangTang", 0, thg_dau), _
                                             WThang2("ThangGiam", thg_dau, 0), _
                                             ConvertToStrSafe(CThangDB2(thg_dau)), _
                                             wsql)
                SoDuDauCuoiKy = String.Format("SELECT CASE WHEN mt.tents<>'' THEN mt.tents ELSE ct.DienGiai END as TenTS,mt.SoHieuTS,mt.NangLuc,mt.GhiChu,mt.ThangTang,mt.NamSX,mt.NamSD,mt.SoHieuTK,mt.MaTK,mt.TenTK,mt.DTCP,mt.NG_NS,mt.NG_TBS,mt.NG_CNK,mt.NG_TD,mt.CL_NS,mt.CL_TBS,mt.CL_CNK,mt.CL_TD,mt.KH_NS,mt.KH_TBS,mt.KH_CNK,mt.KH_TD,mt.SoHieu,mt.Ten,mt.CLDK,mt.shct,mt.nct FROM ({0}) AS mientru1 mt left join chungtu ct on mt.shct=ct.sohieu GROUP BY  mt.SoHieuTS, mt.NangLuc, mt.GhiChu, mt.ThangTang, mt.NamSX, mt.NamSD, mt.SoHieuTK, mt.MaTK, mt.TenTK, mt.DTCP, mt.NG_NS, mt.NG_TBS, mt.NG_CNK, mt.NG_TD, mt.CL_NS, mt.CL_TBS, mt.CL_CNK, mt.CL_TD, mt.KH_NS, mt.KH_TBS, mt.KH_CNK, mt.KH_TD, mt.SoHieu, mt.Ten, mt.CLDK, mt.shct, mt.nct, CASE WHEN mt.tents<>'' THEN mt.tents ELSE ct.DienGiai END", Mientru1)
                returnQuery = SoDuDauCuoiKy
                returnTableName = "SoDuDauCuoiKy"
            Case 68 ' Sổ TSCĐ OK
                returnQuery = SoTSCD(thg_dau)
                returnTableName = "SoDuDauCuoiKy"
            Case 21, 23 ' Tăng giảm tài sản OK
                returnQuery = String.Format("SELECT DISTINCT TaiSan.MaSo AS MaTS, TaiSan.Ten AS TenTS, TaiSan.SoHieu AS SoHieuTS, LoaiTaiSan.MaSo AS MaTK, LoaiTaiSan.SoHieu AS SoHieuTK, LoaiChungTu.SoHieu AS SoHieuLoai, LoaiChungTu.Ten AS TenLoai, CTTaiSan.SoHieu AS SoHieuCT, CTTaiSan.VaoSo, CTTaiSan.DienGiai{0}, CTTaiSan.NG_NS, CTTaiSan.NG_TBS, CTTaiSan.NG_CNK, CTTaiSan.NG_TD, CTTaiSan.CL_NS, CTTaiSan.CL_TBS, CTTaiSan.CL_CNK, CTTaiSan.CL_TD FROM (LoaiChungTu RIGHT JOIN (LoaiTaiSan RIGHT JOIN (TaiSan INNER JOIN CTTaiSan ON TaiSan.MaSo = CTTaiSan.MaTS) ON LoaiTaiSan.MaSo = TaiSan.Maloai) ON LoaiChungTu.MaSo = CTTaiSan.MaNhom) INNER JOIN ThongSo ON (TaiSan.MaSo = ThongSo.MaTS AND TaiSan.ThangTang = ThongSo.Thang) WHERE CTTaiSan.MaLoai = {1} AND {2} AND {3}{4} ORDER BY TaiSan.SoHieu", _
                                  (IIf(pNN > 0, "E", String.Empty)), _
                                  (IIf(baocao = 21, NV_TANG, NV_GIAM)), _
                                  WThang("CTTaiSan.Thang", thg_dau, 0), _
                                  WThang("CTTaiSan.Thang", 0, thg_cuoi), _
                                  wsql)
                returnTableName = "TANGGIAM"
            Case 22, 24 ' Đánh giá lại tăng giảm  OK
                returnQuery = String.Format("SELECT DISTINCT TaiSan.MaSo AS MaTS, TaiSan.Ten AS TenTS, TaiSan.SoHieu AS SoHieuTS, LoaiTaiSan.MaSo AS MaTK, LoaiTaiSan.SoHieu AS SoHieuTK, LoaiChungTu.SoHieu AS SoHieuLoai, LoaiChungTu.Ten AS TenLoai, CTTaiSan.SoHieu AS SoHieuCT, CTTaiSan.VaoSo, CTTaiSan.DienGiai{0}, CTTaiSan.NG_NS, CTTaiSan.NG_TBS, CTTaiSan.NG_CNK, CTTaiSan.NG_TD, CTTaiSan.CL_NS, CTTaiSan.CL_TBS, CTTaiSan.CL_CNK, CTTaiSan.CL_TD FROM ThongSo RIGHT JOIN (LoaiChungTu RIGHT JOIN (LoaiTaiSan RIGHT JOIN (TaiSan RIGHT JOIN CTTaiSan ON TaiSan.MaSo = CTTaiSan.MaTS) ON LoaiTaiSan.MaSo = TaiSan.Maloai) ON LoaiChungTu.MaSo = CTTaiSan.MaNhom) ON (TaiSan.MaSo = ThongSo.MaTS AND TaiSan.ThangTang = ThongSo.Thang) WHERE CTTaiSan.MaLoai = {1} AND {2} AND {3} AND NOT (CTTaiSan.NG_NS + CTTaiSan.NG_TBS + CTTaiSan.NG_CNK + CTTaiSan.NG_TD) {4} AND NOT (CTTaiSan.CL_NS + CTTaiSan.CL_TBS + CTTaiSan.CL_CNK + CTTaiSan.CL_TD) {4}{5} ORDER BY TaiSan.SoHieu", _
                                  (IIf(pNN > 0, "E", String.Empty)), _
                                  NV_DGLAI, _
                                  WThang("CTTaiSan.Thang", thg_dau, 0), _
                                  WThang("CTTaiSan.Thang", 0, thg_cuoi), _
                                  (IIf(baocao = 22, "< 0", "> 0")), _
                                  wsql)
                returnTableName = "DanhGiaLai"
            Case 25, 26 ' Phân bổ khấu hao OK
                returnQuery = String.Format("SELECT DISTINCT TaiSan.Ten AS TenTS, TaiSan.SoHieu AS SoHieuTS, LoaiTaiSan.SoHieu AS SoHieuTKTS, Sum((ThongSo.KH_NS+ThongSo.KH_TBS+ThongSo.KH_CNK+ThongSo.KH_TD)) AS TKH, HethongTK.MaSo AS MaDT, HethongTK.SoHieu + ' - ' + HethongTK.Ten AS TenDT, HethongTK.SoHieu AS SoHieuTKCP FROM HethongTK RIGHT JOIN ((LoaiTaiSan RIGHT JOIN TaiSan ON LoaiTaiSan.MaSo = TaiSan.Maloai) RIGHT JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS) ON (HethongTK.MaSo = ThongSo.MaDTSD) AND (HethongTK.MaSo = ThongSo.MaDTSD) WHERE {0} AND {1} AND {2} AND {3}{4} GROUP BY TaiSan.Ten, TaiSan.SoHieu, LoaiTaiSan.SoHieu, HethongTK.MaSo, HethongTK.Ten, HethongTK.SoHieu ORDER BY TaiSan.SoHieu", _
                                  WThang("ThangTang", 0, thg_cuoi), _
                                  WThang("ThangGiam", thg_dau, 0), _
                                  WThang("ThongSo.Thang", thg_dau, 0), _
                                  WThang("ThongSo.Thang", 0, thg_cuoi), _
                                  wsql)
                returnTableName = "PhanBoKhauHao"
            Case 27 ' Năng lực tài sản OK
                returnQuery = String.Format("SELECT DISTINCT TaiSan.SoHieu, TaiSan.Ten AS TenTS, TaiSan.NangLuc, TaiSan.NamSX, TaiSan.NamSD, LoaiTaiSan.MaSo AS MaTK, LoaiTaiSan.Ten AS TenTK,LoaiTaiSan_1.MaSo AS MaLoai, LoaiTaiSan_1.Ten AS TenLoai,  TinhTrang.MaSo AS MaTT, TinhTrang.Ten AS TenTT, HethongTK.SoHieu + ' - '+ HethongTK.Ten AS TenDT FROM LoaiTaiSan AS LoaiTaiSan_1 RIGHT JOIN ((LoaiTaiSan RIGHT JOIN (QuocGia RIGHT JOIN TaiSan ON QuocGia.MaSo = TaiSan.MaNuoc) ON LoaiTaiSan.MaSo = TaiSan.MaTaiKhoan) RIGHT JOIN (TinhTrang RIGHT JOIN (HethongTK RIGHT JOIN ThongSo ON (HethongTK.MaSo = ThongSo.MaDTSD) AND (HethongTK.MaSo = ThongSo.MaDTSD)) ON TinhTrang.MaSo = ThongSo.MaTTSD) ON TaiSan.MaSo = ThongSo.MaTS) ON LoaiTaiSan_1.MaSo = TaiSan.MaLoai WHERE {0}  AND ThongSo.Thang = {1}{2} ORDER BY TaiSan.SoHieu", _
                                  WThang("ThangTang", 0, thg_dau), _
                                  ConvertToStrSafe(CThangDB2(thg_dau)), _
                                  wsql)
                returnTableName = "NangLucTaiSan"
            Case 28, 29 ' Tổng hợp biến động trong kỳ và luỹ kế  OK
                ' Lượng khấu hao trong kỳ - 3
                Dim sql As String
                Dim BienDong As String = String.Format("SELECT DISTINCT 'khấu hao' AS TenLoai, 'KH' AS SoHieuLoai, 'khấu hao trong kỳ' AS TenNhom, 'KH' AS SoHieuNhom, 0 AS TNG_NS, 0 AS TNG_TBS, 0 AS TNG_CNK, 0 AS TNG_TD, Sum(ThongSo.KH_NS) AS TCL_NS, Sum(ThongSo.KH_TBS) AS TCL_TBS, Sum(ThongSo.KH_CNK) AS TCL_CNK, Sum(ThongSo.KH_TD) AS TCL_TD, 3 AS TangGiam FROM ThongSo WHERE Thang >= {0} AND Thang <= {1}{2}", _
                                             CThangDB2(IIf(baocao = 29, pThangDauKy, thg_dau)), _
                                             ConvertToStrSafe(CThangDB2(thg_cuoi)), _
                                             wsql)
                'BienDong = sql
                ' Lượng tăng/giảm trong kỳ - 2/3
                sql = BienDong
                ExecSQLNonQuery(sql)
                sql = String.Format("{0} UNION SELECT DISTINCT LoaiChungTu.Ten AS TenLoai, LoaiChungTu.SoHieu AS SoHieuLoai, LoaiChungTu_1.Ten AS TenNhom, LoaiChungTu_1.SoHieu AS SoHieuNhom, Sum(CTTaiSan.NG_NS) AS TNG_NS, Sum(CTTaiSan.NG_TBS) AS TNG_TBS, Sum(CTTaiSan.NG_CNK) AS TNG_CNK, Sum(CTTaiSan.NG_TD) AS TNG_TD, Sum(CTTaiSan.CL_NS) AS TCL_NS, Sum(CTTaiSan.CL_TBS) AS TCL_TBS, Sum(CTTaiSan.CL_CNK) AS TCL_CNK, Sum(CTTaiSan.CL_TD) AS TCL_TD, CASE WHEN Sum(CTTaiSan.NG_NS)+Sum(CTTaiSan.NG_TBS)+Sum(CTTaiSan.NG_CNK)+Sum(CTTaiSan.NG_TD) > 0 THEN 2 ELSE 3 END AS TangGiam FROM ThongSo RIGHT JOIN (LoaiChungTu RIGHT JOIN (LoaiChungTu AS LoaiChungTu_1 RIGHT JOIN CTTaiSan ON LoaiChungTu_1.MaSo = CTTaiSan.MaNhom) ON LoaiChungTu.MaSo = CTTaiSan.MaLoai) ON (CTTaiSan.MaTS = ThongSo.MaTS AND CTTaiSan.Thang = ThongSo.Thang) WHERE {1} AND {2} AND LoaiChungTu.MaSo <> {3}{4} GROUP BY LoaiChungTu.Ten, LoaiChungTu.SoHieu, LoaiChungTu_1.Ten, LoaiChungTu_1.SoHieu", _
                          BienDong, _
                          WThang("CTTaiSan.Thang", IIf(baocao = 29, pThangDauKy, thg_dau), 0), _
                          WThang("CTTaiSan.Thang", 0, thg_cuoi), _
                          ConvertToStrSafe(NV_TKHAO), _
                          wsql)
                ExecSQLNonQuery(sql)
                ' Số đầu kỳ - 1
                ExecSQLNonQuery(sql)
                sql = String.Format("{0} UNION SELECT DISTINCT 'Đầu kỳ' AS TenLoai, 'DK' AS SoHieuLoai, 'Số dư đầu kỳ' AS TenNhom, 'DK' AS SoHieuNhom, Sum(ThongSo.NG_NS) AS TNG_NS, Sum(ThongSo.NG_TBS) AS TNG_TBS, Sum(ThongSo.NG_CNK) AS TNG_CNK, Sum(ThongSo.NG_TD) AS TNG_TD, Sum(ThongSo.CL_NS) AS TCL_NS, Sum(ThongSo.CL_TBS) AS TCL_TBS, Sum(ThongSo.CL_CNK) AS TCL_CNK, Sum(ThongSo.CL_TD) AS TCL_TD, 1 AS TangGiam FROM TaiSan RIGHT JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS WHERE ThongSo.Thang = {1}", _
                          BienDong, _
                          CThangDB2(IIf(baocao = 29, 0, ThangTruoc(thg_dau))))
                ExecSQLNonQuery(sql)
                ' Số Cuối kỳ - 4
                ExecSQLNonQuery(BienDong)
                sql = String.Format("{0} UNION SELECT DISTINCT 'Cuối kỳ' AS TenLoai, 'CK' AS SoHieuLoai, '' AS TenNhom, 'CK' AS SoHieuNhom, Sum(ThongSo.NG_NS) AS TNG_NS, Sum(ThongSo.NG_TBS) AS TNG_TBS, Sum(ThongSo.NG_CNK) AS TNG_CNK, Sum(ThongSo.NG_TD) AS TNG_TD, Sum(ThongSo.CL_NS) AS TCL_NS, Sum(ThongSo.CL_TBS) AS TCL_TBS, Sum(ThongSo.CL_CNK) AS TCL_CNK, Sum(ThongSo.CL_TD) AS TCL_TD, 4 AS TangGiam FROM TaiSan RIGHT JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS WHERE ThongSo.Thang = {1} AND {2}", _
                          BienDong, _
                          CThangDB2(thg_cuoi), _
                          WThang("ThangTang", 0, thg_cuoi), _
                          wsql)
                ExecSQLNonQuery(sql)

                returnQuery = BienDong
                returnTableName = "BienDong"
            Case 30 ' Tài sản không phải tính khấu hao 
                returnQuery = String.Format("SELECT DISTINCT TaiSan.SoHieu AS SoHieuTS, TaiSan.Ten AS TenTS, LoaiTaiSan.SoHieu AS SoHieuTK, LoaiTaiSan.Ten AS TenTK, ThongSo.NG_NS, ThongSo.NG_TBS, ThongSo.NG_CNK, ThongSo.NG_TD FROM (LoaiTaiSan RIGHT JOIN TaiSan ON LoaiTaiSan.MaSo = TaiSan.Maloai) RIGHT JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS WHERE ThongSo.Thang = {0} AND (ThongSo.CL_NS+ThongSo.CL_TBS+ThongSo.CL_CNK+ThongSo.CL_TD) = 0 AND TaiSan.ThangTang <= {1} ", _
                                  CThangDB2(thg_dau), _
                                  ConvertToStrSafe(thg_dau), _
                                  wsql)
                returnTableName = "MienTru"
            Case 79 'bang phan bo khau hao
                returnQuery = TinhPB(thg_dau)
                returnTableName = "BaoCaoCP"
            Case 31
                returnQuery = String.Format("select * from binhquan")
                returnTableName = "BinhQuan"
        End Select

        Return New String() {returnQuery, returnTableName}
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub TinhSoLieuBaoCao()
        Dim thg_dau, thg_cuoi As Integer
        ' Xác định các tháng cần tính số liệu
        Select Case baocao
            Case 18, 45, 61, 89, 90
                thg_dau = CboThang(0).SelectedIndex
                thg_cuoi = CboThang(1).SelectedIndex
            Case 20, 30 ' Sổ khấu hao, số dư cuối kỳ  và tài sản không tính khấu hao
                thg_dau = CboThang(0).SelectedIndex
                thg_cuoi = thg_dau
            Case 19 ' Số dư đầu kỳ
                thg_dau = ThangTruoc(CboThang(0).SelectedIndex)
                thg_cuoi = thg_dau
            Case 28, 31 ' Biến động trong kỳ và bình quân tài sản
                thg_dau = ThangTruoc(CboThang(0).SelectedIndex)
                thg_cuoi = CboThang(1).SelectedIndex
            Case 29 ' Biến động luỹ kế
                thg_dau = pThangDauKy
                thg_cuoi = CboThang(1).SelectedIndex
            Case 61, 89
                thg_dau = pThangDauKy
                thg_cuoi = ThangCuoiNamTC()
            Case Else : Exit Sub
        End Select
        ' Tính giá trị tài sản cho các tháng cần lấy số liệu
        HienThongBao("Cập nhật giá trị tài sản ...", 1)
        For chi_so As Integer = CThangDB2(thg_dau) To CThangDB2(thg_cuoi)
            If chi_so > 0 Then
                If Not SoLieu(chi_so - 1) Then
                    Me.Cursor = Cursors.WaitCursor
                    CapNhatGiaTriTaiSan(chi_so, GauGe)
                    SoLieu(chi_so - 1) = True
                    Me.Cursor = Cursors.Default
                End If
            End If
        Next
        ' Tính bình quân tài sản
        Dim mql As Integer
        Dim wsql As String = String.Empty
        If baocao = 31 Then
            mql = IIf(Opt(0).Checked, 0, Cbo.SelectedIndex)
            wsql = IIf(mql > 0, String.Format(" AND (ThongSo.MaDTQL = {0}) ", mql), String.Empty)
            Me.Cursor = Cursors.WaitCursor
            HienThongBao("Tính bình quân tài sản", 1)
            TinhTongNguyenGia(dauky, thg_dau, wsql) ' Giá trị đầu kỳ
            TinhLuongTangGiam(Tang, thg_dau + 1, thg_cuoi, wsql) ' Lượng tăng
            TinhLuongTangGiam(GIAM, thg_dau + 1, thg_cuoi, wsql) ' Lượng giảm
            TinhBinhQuan(thg_dau, thg_cuoi, wsql) ' Bình quân
            Me.Cursor = Cursors.Arrow
        End If
        HienThongBao("", 1)
    End Sub

    Dim trangthai As String = String.Empty
    Private Sub TinhTongNguyenGia(ByRef phan_loai As Integer, ByRef thg As Integer, ByRef wsql As String)
        trangthai = String.Format("SELECT DISTINCT ThongSo.MaTS, CASE WHEN (ThongSo.CL_NS+ThongSo.CL_TBS+ThongSo.CL_CNK+ThongSo.CL_TD=0) THEN 0 ELSE 1 END AS TrangThai, TaiSan.ThangTang, TaiSan.ThangGiam FROM TaiSan RIGHT JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS WHERE ThongSo.Thang = {0}{1} AND {2}{3}", CThangDB2(thg), (IIf(thg > 0, " AND " & WThang2("ThangGiam", thg, 0), String.Empty)), WThang("ThangTang", 0, thg), wsql)
        pSelectSQL = String.Format("SELECT DISTINCT Sum(ThongSo.NG_NS) AS NS, Sum(ThongSo.NG_TBS) AS TBS, Sum(ThongSo.NG_CNK) AS CNK, Sum(ThongSo.NG_TD) AS TD FROM ({2}) as TrangThai INNER JOIN ThongSo ON TrangThai.MaTS = ThongSo.MaTS WHERE ThongSo.Thang = {0} AND TrangThai.TrangThai = 1{1}", CThangDB2(thg), wsql, trangthai)
        CapNhatTongNguyenGia(phan_loai, 1)
        pSelectSQL = String.Format("SELECT DISTINCT Sum(ThongSo.NG_NS) AS NS, Sum(ThongSo.NG_TBS) AS TBS, Sum(ThongSo.NG_CNK) AS CNK, Sum(ThongSo.NG_TD) AS TD FROM ({2}) as TrangThai INNER JOIN ThongSo ON TrangThai.MaTS = ThongSo.MaTS WHERE ThongSo.Thang = {0} AND TrangThai.TrangThai = 0{1}", CThangDB2(thg), wsql, trangthai)
        CapNhatTongNguyenGia(phan_loai, 0)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="phan_loai"></param>
    ''' <param name="khau_hao"></param>
    ''' <remarks></remarks>
    Private Sub CapNhatTongNguyenGia(ByRef phan_loai As Integer, ByRef khau_hao As Integer)
        Dim rs_tongso As DataTable = ExecSQLReturnDT(pSelectSQL)
        For i = 0 To rs_tongso.Rows.Count - 1
            Dim dong As DataRow = rs_tongso.Rows(i)
            '  ExecSQLNonQuery(String.Format("UPDATE BinhQuan SET HT_NS = {0}, HT_TBS = {1}, HT_CNK = {2}, HT_TD = {3}, LK_NS = {0}, LK_TBS = {1}, LK_CNK = {2}, LK_TD = {3} WHERE PhanLoai = {4} AND KhauHao = {5}", cstr(IIf(IsDBNull(rs_tongso("NS")), 0, rs_tongso("NS"))), cstr(IIf(IsDBNull(rs_tongso("TBS")), 0, rs_tongso("TBS"))), cstr(IIf(IsDBNull(rs_tongso("CNK")), 0, rs_tongso("CNK"))), cstr(IIf(IsDBNull(rs_tongso("TD")), 0, rs_tongso("TD"))), ConvertToStrSafe(phan_loai), ConvertToStrSafe(khau_hao)))
            ExecSQLNonQuery(String.Format("UPDATE BinhQuan SET HT_NS = {0}, HT_TBS = {1}, HT_CNK = {2}, HT_TD = {3}, LK_NS = {0}, LK_TBS = {1}, LK_CNK = {2}, LK_TD = {3} WHERE PhanLoai = {4} AND KhauHao = {5}", CStr(IIf(IsDBNull(dong(0)), 0, dong(0))), CStr(IIf(IsDBNull(dong(1)), 0, dong(1))), CStr(IIf(IsDBNull(dong(2)), 0, dong(2))), CStr(IIf(IsDBNull(dong(3)), 0, dong(3))), ConvertToStrSafe(phan_loai), ConvertToStrSafe(khau_hao)))
            ''rs_tongso.Close()
        Next

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="phan_loai"></param>
    ''' <param name="thg_dau"></param>
    ''' <param name="thg_cuoi"></param>
    ''' <param name="wsql"></param>
    ''' <remarks></remarks>
    Private Sub TinhLuongTangGiam(ByRef phan_loai As Integer, ByRef thg_dau As Integer, ByRef thg_cuoi As Integer, ByRef wsql As String)
        ' Tài sản tăng/giảm trong kỳ phải tính khấu hao
        pSelectSQL = String.Format("SELECT DISTINCT Sum(CTTaiSan.NG_NS) AS NS, Sum(CTTaiSan.NG_TBS) AS TBS, Sum(CTTaiSan.NG_CNK) AS CNK, Sum(CTTaiSan.NG_TD) AS TD FROM CTTaiSan INNER JOIN ThongSo ON (CTTaiSan.MaTS = ThongSo.MaTS AND CTTaiSan.Thang = ThongSo.Thang) WHERE {0} AND {1} AND (CTTaiSan.NG_NS + CTTaiSan.NG_TBS + CTTaiSan.NG_CNK + CTTaiSan.NG_TD) {2} AND (CTTaiSan.CL_NS + CTTaiSan.CL_TBS + CTTaiSan.CL_CNK + CTTaiSan.CL_TD) <> 0 AND CTTaiSan.MaTS>0{3}", WThang("CTTaiSan.Thang", thg_dau, 0), WThang("CTTaiSan.Thang", 0, thg_cuoi), (IIf(phan_loai = Tang, "> 0", "< 0")), wsql)
        CapNhatLuongTangGiam("HT", phan_loai, 1)
        ' Tài sản tăng/giảm trong kỳ không phải tính khấu hao
        pSelectSQL = String.Format("SELECT DISTINCT Sum(CTTaiSan.NG_NS) AS NS, Sum(CTTaiSan.NG_TBS) AS TBS, Sum(CTTaiSan.NG_CNK) AS CNK, Sum(CTTaiSan.NG_TD) AS TD FROM CTTaiSan INNER JOIN ThongSo ON (CTTaiSan.MaTS = ThongSo.MaTS AND CTTaiSan.Thang = ThongSo.Thang) WHERE {0} AND {1} AND (CTTaiSan.NG_NS + CTTaiSan.NG_TBS + CTTaiSan.NG_CNK + CTTaiSan.NG_TD) {2} AND (CTTaiSan.CL_NS + CTTaiSan.CL_TBS + CTTaiSan.CL_CNK + CTTaiSan.CL_TD) = 0 AND CTTaiSan.MaTS>0{3}", WThang("CTTaiSan.Thang", thg_dau, 0), WThang("CTTaiSan.Thang", 0, thg_cuoi), (IIf(phan_loai = Tang, "> 0", "< 0")), wsql)
        CapNhatLuongTangGiam("HT", phan_loai, 0)
        ' Tài sản tăng/giảm lũy kế phải tính khấu hao
        pSelectSQL = String.Format("SELECT DISTINCT Sum(CTTaiSan.NG_NS) AS NS, Sum(CTTaiSan.NG_TBS) AS TBS, Sum(CTTaiSan.NG_CNK) AS CNK, Sum(CTTaiSan.NG_TD) AS TD FROM CTTaiSan INNER JOIN ThongSo ON (CTTaiSan.MaTS = ThongSo.MaTS AND CTTaiSan.Thang = ThongSo.Thang) WHERE {0} AND {1} AND (CTTaiSan.NG_NS + CTTaiSan.NG_TBS + CTTaiSan.NG_CNK + CTTaiSan.NG_TD) {2} AND (CTTaiSan.CL_NS + CTTaiSan.CL_TBS + CTTaiSan.CL_CNK + CTTaiSan.CL_TD) <> 0 AND CTTaiSan.MaTS>0{3}", WThang("CTTaiSan.Thang", pThangDauKy, 0), WThang("CTTaiSan.Thang", 0, thg_cuoi), (IIf(phan_loai = Tang, "> 0", "< 0")), wsql)
        CapNhatLuongTangGiam("LK", phan_loai, 1)
        ' Tài sản tăng/giảm lũy kế không phải tính khấu hao
        pSelectSQL = String.Format("SELECT DISTINCT Sum(CTTaiSan.NG_NS) AS NS, Sum(CTTaiSan.NG_TBS) AS TBS, Sum(CTTaiSan.NG_CNK) AS CNK, Sum(CTTaiSan.NG_TD) AS TD FROM CTTaiSan INNER JOIN ThongSo ON (CTTaiSan.MaTS = ThongSo.MaTS AND CTTaiSan.Thang = ThongSo.Thang) WHERE {0} AND {1} AND (CTTaiSan.NG_NS + CTTaiSan.NG_TBS + CTTaiSan.NG_CNK + CTTaiSan.NG_TD) {2} AND (CTTaiSan.CL_NS + CTTaiSan.CL_TBS + CTTaiSan.CL_CNK + CTTaiSan.CL_TD) = 0 AND CTTaiSan.MaTS>0{3}", WThang("CTTaiSan.Thang", pThangDauKy, 0), WThang("CTTaiSan.Thang", 0, thg_cuoi), (IIf(phan_loai = Tang, "> 0", "< 0")), wsql)
        CapNhatLuongTangGiam("LK", phan_loai, 0)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thoi_diem"></param>
    ''' <param name="phan_loai"></param>
    ''' <param name="khau_hao"></param>
    ''' <remarks></remarks>
    Private Sub CapNhatLuongTangGiam(ByRef thoi_diem As String, ByRef phan_loai As Integer, ByRef khau_hao As Integer)
        Dim rs_tongso As DataTable = ExecSQLReturnDT(pSelectSQL)
        For i = 0 To rs_tongso.Rows.Count - 1
            Dim dong As DataRow = rs_tongso.Rows(i)
            ExecSQLNonQuery(String.Format("UPDATE BinhQuan SET {0}_NS = {1}, {0}_TBS = {2}, {0}_CNK = {3}, {0}_TD = {4} WHERE PhanLoai = {5} AND KhauHao = {6}", thoi_diem, CStr(IIf(IsDBNull(dong(0)), 0, dong(0))), CStr(IIf(IsDBNull(dong(1)), 0, dong(1))), CStr(IIf(IsDBNull(dong(2)), 0, dong(2))), CStr(IIf(IsDBNull(dong(3)), 0, dong(3))), ConvertToStrSafe(phan_loai), ConvertToStrSafe(khau_hao)))
        Next
        '      ExecuteSQL5 False
        ''rs_tongso.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thg_dau"></param>
    ''' <param name="thg_cuoi"></param>
    ''' <param name="wsql"></param>
    ''' <remarks></remarks>
    Private Sub TinhBinhQuan(ByRef thg_dau As Integer, ByRef thg_cuoi As Integer, ByRef wsql As String)
        ' Tính tổng nguyên giá
        For chi_so As Integer = 0 To CThangDB2(thg_cuoi)
            TinhTongNguyenGia(CThangFR(chi_so), CThangFR(chi_so), wsql)
        Next
        CapNhatLuongBinhQuan(CThangDB2(thg_dau), CThangDB2(thg_cuoi), "HT", 1)
        CapNhatLuongBinhQuan(0, CThangDB2(thg_cuoi), "LK", 1)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thg_dau"></param>
    ''' <param name="thg_cuoi"></param>
    ''' <param name="thoi_diem"></param>
    ''' <param name="khau_hao"></param>
    ''' <remarks></remarks>
    Private Sub CapNhatLuongBinhQuan(ByRef thg_dau As Integer, ByRef thg_cuoi As Integer, ByRef thoi_diem As String, ByRef khau_hao As Integer)
        Dim NS, TBS, CNK, TD As Double
        pSelectSQL = String.Format("SELECT * FROM BinhQuan WHERE PhanLoai >= {0} AND PhanLoai <= {1} ORDER BY PhanLoai", thg_dau, ConvertToStrSafe(thg_cuoi))
        Dim rs_binhquan As DataTable = ExecSQLReturnDT(pSelectSQL)
        For Each rs_binhquanItem As DataRow In rs_binhquan.Rows
            If ConvertToStrSafe(rs_binhquanItem("PhanLoai")) = thg_dau Or ConvertToStrSafe(rs_binhquanItem("PhanLoai")) = thg_cuoi Then
                If rs_binhquanItem("HT_NS") IsNot Nothing Then
                    NS += ConvertToStrSafe(rs_binhquanItem("HT_NS")) / 2
                End If
                If rs_binhquanItem("HT_TBS") IsNot Nothing Then
                    TBS += ConvertToStrSafe(rs_binhquanItem("HT_TBS")) / 2
                End If
                If rs_binhquanItem("HT_CNK") IsNot Nothing Then
                    CNK += ConvertToStrSafe(rs_binhquanItem("HT_CNK")) / 2
                End If
                If rs_binhquanItem("HT_TD") IsNot Nothing Then
                    TD += ConvertToStrSafe(rs_binhquanItem("HT_TD")) / 2
                End If

            Else
                If rs_binhquanItem("HT_NS") IsNot Nothing Then
                    NS += ConvertToStrSafe(rs_binhquanItem("HT_NS"))
                End If
                If rs_binhquanItem("HT_TBS") IsNot Nothing Then
                    TBS += ConvertToStrSafe(rs_binhquanItem("HT_TBS"))
                End If
                If rs_binhquanItem("HT_CNK") IsNot Nothing Then
                    CNK += ConvertToStrSafe(rs_binhquanItem("HT_CNK"))
                End If
                If rs_binhquanItem("HT_TD") IsNot Nothing Then
                    TD += ConvertToStrSafe(rs_binhquanItem("HT_TD"))
                End If
            End If
            'rs_binhquan.MoveNext()
        Next
        If rs_binhquan.Rows.Count > 0 Then
            If thg_cuoi > thg_dau + 1 Then
                NS /= (thg_cuoi - thg_dau)
                TBS /= (thg_cuoi - thg_dau)
                CNK /= (thg_cuoi - thg_dau)
                TD /= (thg_cuoi - thg_dau)
            End If
        Else
            NS = 0
            TBS = 0
            CNK = 0
            TD = 0
        End If
        ExecSQLNonQuery(String.Format("UPDATE BinhQuan SET {0}_NS = {1}, {0}_TBS = {2}, {0}_CNK = {3}, {0}_TD = {4} WHERE PhanLoai = {5} AND KhauHao = {6}", thoi_diem, CStr(RoundMoney(NS)), CStr(RoundMoney(TBS)), CStr(RoundMoney(CNK)), CStr(RoundMoney(TD)), ConvertToStrSafe(BINHQUAN), ConvertToStrSafe(khau_hao)))
        ''rs_binhquan.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <remarks></remarks>
    Private Function SoTSCD(ByRef thang As Integer) As String
        Dim MienTru As String = String.Format("SELECT * FROM CTTaiSan WHERE {0} AND MaLoai=33", WThang("Thang", 0, thang))
        Dim SoDuDauCuoiKy As String = String.Format("SELECT DISTINCT TaiSan.Ten AS TenTS, TaiSan.SoHieu AS SoHieuTS,NangLuc,TaiSan.GhiChu,ThangTang,NamSX,NamSD, LoaiTaiSan_1.SoHieu AS SoHieuTK,LoaiTaiSan_1.MaSo AS MaTK, LoaiTaiSan_1.Ten AS TenTK,QuocGia.Ten AS NuocSX,(ThongSo.NG_NS+ThongSo.NG_TBS+ThongSo.NG_CNK+ThongSo.NG_TD) AS NG,(ThongSo.KH_NS+ThongSo.KH_TBS+ThongSo.KH_CNK+ThongSo.KH_TD) AS KH,LoaiTaiSan_1.SoHieu,LoaiTaiSan_1.Ten, TaiSan.SHCT AS SCsokhauhao142_153,TaiSan.NCT AS NCsokhauhao142_153,TaiSan.NCT AS NGS1, MienTru.SoHieu AS SCsodudaunam142_153,MienTru.VaoSo AS NCsodudaunam142_153,MienTru.DienGiai AS DG2, (MienTru.NG_NS+MienTru.NG_TBS+MienTru.NG_TD+MienTru.NG_CNK-MienTru.CL_NS-MienTru.CL_TBS-MienTru.CL_TD-MienTru.CL_CNK) AS SoDaKH,TaiSan.NamKH FROM ((LoaiTaiSan AS LoaiTaiSan_1 INNER JOIN TaiSan ON LoaiTaiSan_1.MaSo = TaiSan.Maloai INNER JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS) INNER JOIN QuocGia ON TaiSan.MaNuoc=QuocGia.MaSo LEFT JOIN (SELECT * FROM CTTaiSan WHERE  ((Thang>=1 OR Thang=0) AND Thang<=1)  AND MaLoai=33) AS MienTru ON TaiSan.MaSo=MienTru.MaTS )  WHERE {1} AND ((ThongSo.Thang = {2}) OR (ThongSo.Thang = ThangGiam-1 AND {3})) ORDER BY TaiSan.SoHieu", _
                                          MienTru, _
                                          WThang("ThangTang", 0, thang), _
                                          ConvertToStrSafe(CThangDB2(thang)), _
                                          WThang("ThangGiam", 0, thang))
        'Dim SoDuDauCuoiKy As String = String.Format("SELECT DISTINCT TaiSan.Ten AS TenTS, TaiSan.SoHieu AS SoHieuTS,NangLuc,TaiSan.GhiChu,ThangTang,NamSX,NamSD, LoaiTaiSan_1.SoHieu AS SoHieuTK, LoaiTaiSan_1.MaSo AS MaTK, LoaiTaiSan_1.Ten AS TenTK,QuocGia.Ten AS NuocSX,(ThongSo.NG_NS+ThongSo.NG_TBS+ThongSo.NG_CNK+ThongSo.NG_TD) AS NG, (ThongSo.KH_NS+ThongSo.KH_TBS+ThongSo.KH_CNK+ThongSo.KH_TD) AS KH,LoaiTaiSan_1.SoHieu,LoaiTaiSan_1.Ten, TaiSan.SHCT AS SCsokhauhao142_153,TaiSan.NCT AS NCsokhauhao142_153,TaiSan.NCT AS NGS1, MienTru.SoHieu AS SCsodudaunam142_153,MienTru.VaoSo AS NCsodudaunam142_153,MienTru.DienGiai AS DG2, (MienTru.NG_NS+MienTru.NG_TBS+MienTru.NG_TD+MienTru.NG_CNK-MienTru.CL_NS-MienTru.CL_TBS-MienTru.CL_TD-MienTru.CL_CNK) AS SoDaKH,TaiSan.NamKH FROM ((LoaiTaiSan AS LoaiTaiSan_1 INNER JOIN ((LoaiTaiSan INNER JOIN TaiSan ON LoaiTaiSan.MaSo = TaiSan.Maloai) INNER JOIN ThongSo ON TaiSan.MaSo = ThongSo.MaTS) ON LoaiTaiSan_1.MaSo=TaiSan.Manhom) INNER JOIN QuocGia ON TaiSan.MaNuoc=QuocGia.MaSo) LEFT JOIN ({0}) AS MienTru ON TaiSan.MaSo=MienTru.MaTS WHERE {1} AND ((ThongSo.Thang = {2}) OR (ThongSo.Thang = ThangGiam-1 AND {3})) ORDER BY TaiSan.SoHieu", _
        '                                  MienTru, _
        '                                  WThang("ThangTang", 0, thang), _
        '                                  ConvertToStrSafe(CThangDB2(thang)), _
        '                                  WThang("ThangGiam", 0, thang))
        Return SoDuDauCuoiKy
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="thang"></param>
    ''' <remarks></remarks>
    Private Function TinhPB(ByRef thang As Integer) As String
        Dim k5, k3, K1, k2, k4, k6 As Double
        ExecSQLNonQuery("DELETE FROM BaoCaoCP")
        ExecSQLNonQuery("INSERT INTO BaoCaoCP (MaSo,SoHieu,CoCon,Ten) VALUES (10000,'10000',1,N'I. Số khấu hao đã trích tháng trước')")
        ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP (MaSo,SoHieu,Ten,Cap,Kq1,Kq2,BC_ID,MaCha) SELECT MaTS+10000,CAST(MaTS+10000 AS Nvarchar(20)),Ten,NamKH,(NG_NS+NG_TBS+NG_TD+NG_CNK),(KH_NS+KH_TBS+KH_TD+KH_CNK),MaDTSD,10000  FROM ThongSo INNER JOIN TaiSan ON ThongSo.MaTS = TaiSan.MaSo WHERE (KH_NS+KH_TBS+KH_TD+KH_CNK)<>0 AND Thang={0} AND ThangTang<{1}", _
                            (IIf(thang > 1, thang - 1, 1)), _
                            ConvertToStrSafe(thang)))
        ExecSQLNonQuery("INSERT INTO BaoCaoCP (MaSo,SoHieu,CoCon,Ten) VALUES (20000,'20000',1,N'II. Số khấu hao TSCĐ tăng trong tháng')")
        ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP (MaSo,SoHieu,Ten,Cap,Kq1,Kq2,BC_ID,MaCha) SELECT MaTS+20000,CAST(MaTS+20000 as nvarchar(20)),Ten,NamKH,(NG_NS+NG_TBS+NG_TD+NG_CNK),(KH_NS+KH_TBS+KH_TD+KH_CNK),MaDTSD,20000  FROM ThongSo INNER JOIN TaiSan ON ThongSo.MaTS = TaiSan.MaSo WHERE (KH_NS+KH_TBS+KH_TD+KH_CNK)<>0 AND Thang={0} AND ThangTang={1}", _
                            thang, _
                            ConvertToStrSafe(thang)))
        ExecSQLNonQuery("INSERT INTO BaoCaoCP (MaSo,SoHieu,CoCon,Ten) VALUES (30000,'30000',1,N'III. Số khấu hao TSCĐ giảm trong tháng')")
        ExecSQLNonQuery(String.Format("INSERT INTO BaoCaoCP (MaSo,SoHieu,Ten,Cap,Kq1,Kq2,BC_ID,MaCha) SELECT MaTS+30000,cast(MaTS+30000 as nvarchar(20)),Ten,NamKH,(NG_NS+NG_TBS+NG_TD+NG_CNK),(KH_NS+KH_TBS+KH_TD+KH_CNK),MaDTSD,30000  FROM ThongSo INNER JOIN TaiSan ON ThongSo.MaTS = TaiSan.MaSo WHERE ((KH_NS+KH_TBS+KH_TD+KH_CNK)<>0 AND Thang={0} AND ThangGiam={1}) OR ((KH_NS+KH_TBS+KH_TD+KH_CNK)=0 AND Thang={2} AND ThangGiam={2})", _
                            thang - 1, _
                            ConvertToStrSafe(thang - 1), _
                            ConvertToStrSafe(thang)))
        ExecSQLNonQuery("INSERT INTO BaoCaoCP (MaSo,SoHieu,CoCon,Ten) VALUES (40000,'40000',1,N'IV. Số khấu hao TSCĐ phải trích tháng này')")
        ExecSQLNonQuery("UPDATE BaoCaoCP  SET Kq3= (Select top 1 (CASE WHEN (LEFT(HethongTK.SoHieu,3)='627') THEN Kq2 ELSE 0 END) as _kq2  FRom BaoCaoCP INNER JOIN HethongTK ON BaoCaoCP.BC_ID=HethongTK.MaSo) , Kq5= (select top 1 ( CASE WHEN (LEFT(HethongTK.SoHieu,3)='641') THEN Kq2 ELSE 0 END) as _kq3 FRom BaoCaoCP INNER JOIN HethongTK ON BaoCaoCP.BC_ID=HethongTK.MaSo  ), Kq6= (select top 1 (CASE WHEN(LEFT(HethongTK.SoHieu,3)='642') THEN Kq2 ELSE  0 END) as _kq4 from BaoCaoCP INNER JOIN HethongTK ON BaoCaoCP.BC_ID=HethongTK.MaSo)") 'UPDATE BaoCaoCP INNER JOIN HethongTK ON BaoCaoCP.BC_ID=HethongTK.MaSo SET Kq3= CASE WHEN (LEFT(HethongTK.SoHieu,3)='627') THEN Kq2 ELSE 0 END, Kq5= CASE WHEN (LEFT(HethongTK.SoHieu,3)='641') THEN Kq2 ELSE 0 END, Kq6=CASE WHEN(LEFT(HethongTK.SoHieu,3)='642') THEN Kq2 ELSE  0 END
        Dim rs As DataTable = ExecSQLReturnDT("SELECT MaCha, isnull(Sum(Kq1),0) AS K1,isnull(Sum(Kq2),0) AS K2,isnull(Sum(Kq3),0) AS K3,isnull(Sum(Kq4),0) AS K4,isnull(Sum(Kq5),0) AS K5,isnull(Sum(Kq6),0) AS K6  FROM BaoCaoCP WHERE MaCha>0 GROUP BY MaCha")
        Dim rsIndex As Integer = 0
        Do While rsIndex < rs.Rows.Count
            Dim rsItem As DataRow = rs.Rows(rsIndex)
            rsIndex += 1 ' C15 Rs LOOP CONTROL
            ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP SET Kq1={0},Kq2={1},Kq3={2},Kq4={3},Kq5={4},Kq6={5} WHERE MaSo={6}", _
                                IIf(rsItem("K1").ToString() = String.Empty, 0, rsItem("K1")), _
                                IIf(rsItem("k2").ToString() = String.Empty, 0, rsItem("k2")), _
                                IIf(rsItem("k3").ToString() = String.Empty, 0, rsItem("k3")), _
                                IIf(rsItem("k4").ToString() = String.Empty, 0, rsItem("k4")), _
                                IIf(rsItem("k5").ToString() = String.Empty, 0, rsItem("k5")), _
                                IIf(rsItem("k6").ToString() = String.Empty, 0, rsItem("k6")), _
                                rsItem("macha")))
            If rsItem("macha") < 30000 Then
                If rsItem("K1") IsNot Nothing Then
                    K1 += rsItem("K1")
                End If
                If rsItem("k2") IsNot Nothing Then
                    k2 += rsItem("k2")
                End If
                If rsItem("k3") IsNot Nothing Then
                    k3 += rsItem("k3")
                End If
                If rsItem("k4") IsNot Nothing Then
                    k4 += rsItem("k4")
                End If
                If rsItem("k5") IsNot Nothing Then
                    k5 += rsItem("k5")
                End If
                If rsItem("k6") IsNot Nothing Then
                    k6 += rsItem("k6")
                End If

            Else
                If rsItem("K1") IsNot Nothing Then
                    K1 -= rsItem("K1")
                End If
                If rsItem("k2") IsNot Nothing Then
                    k2 -= rsItem("k2")
                End If
                If rsItem("k3") IsNot Nothing Then
                    k3 -= rsItem("k3")
                End If
                If rsItem("k4") IsNot Nothing Then
                    k4 -= rsItem("k4")
                End If
                If rsItem("k5") IsNot Nothing Then
                    k5 -= rsItem("k5")
                End If
                If rsItem("k6") IsNot Nothing Then
                    k6 -= rsItem("k6")
                End If
            End If
            ''rs.MoveNext()
        Loop
        ExecSQLNonQuery(String.Format("UPDATE BaoCaoCP SET Kq1={0},Kq2={1},Kq3={2},Kq4={3},Kq5={4},Kq6={5} WHERE MaSo=40000", _
                            K1, _
                            ConvertToStrSafe(k2), _
                            ConvertToStrSafe(k3), _
                            ConvertToStrSafe(k4), _
                            ConvertToStrSafe(k5), _
                            ConvertToStrSafe(k6)))
        Return "SELECT * FROM BaoCaoCP"
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub txtShTS_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtShTS.Enter
        txtShTS.SelectAll()
    End Sub
End Class
